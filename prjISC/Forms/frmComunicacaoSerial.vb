Option Strict Off
Option Explicit On

Imports System.IO.Ports

Public Class frmComunicacaoSerial

#Region "Declarações"

    'Piscar informações do teste de comunicação
    Dim blnPisca As Boolean

    'Desligar debug do arduino
    Dim blnTemCanalHabilitado As Boolean
    Dim intTentativaVerificaCanais As Integer
    Dim blnPrimeiroScan As Boolean
    Dim strCanaisHabilitadosAD0, strCanaisHabilitadosAD1 As String
    Dim strCanaisHabAD(3) As String
    Dim intPlacasLidasComSucesso() As Integer
    Dim blnDbOffSucesso, blnReadingOffSucesso, blnLeuPlacasInicializadasComSucesso, blnVerificouCanaisHabilitadosComSucesso, blnLeuConstantesPIDComSucesso, blnComandosPreliminaresComSucesso As Boolean
    Dim intRetornoLeituraAD As Integer

#End Region

    '////////////////////////////////////////////////////////////////
    '/////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

    Private Sub frmComunicacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            strFrmAtivo = "Comunicação"
            'Pega ID form de comunicacao
            intID_Tela_Comunicacao = 1

            'Setar as clases
            usrComunicacao = New clsComunicacao
            usrDiversos = New clsDiversos
            'usrComandos = New clsComandos
            usrPortaSerial = New clsPortaSerial
            usrArduino_AD7192 = New clsArduino_AD7192
            usrPortaSerial = New clsPortaSerial

            'Desabilitar comandos
            usrLayout.HabilitarComandos(False)

            'Habilitar comandos form
            Call HabilitarComandos(True, False, True)

            'Realizar comunicação
            blnComunicacao = False
            tmrComunicacao.Enabled = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmComunicacao_Load" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub frmComunicacao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            'Habilitar comandos
            usrLayout.HabilitarComandos(True)

            'Zera o número de tentativas
            intTentativaVerificaCanais = 0
            'Limpa o Status para o próximo teste
            blnTemCanalHabilitadoPlaca0 = False
            blnTemCanalHabilitadoPlaca1 = False

            If tmrComunicacao.Enabled = True Then
                blnComunicacao = False
                tmrComunicacao.Enabled = False
            End If

            If spPortaSerial.IsOpen Then
                'Fechar porta serial 
                Call usrPortaSerial.FecharPorta(spPortaSerial)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmComunicacao_FormClosed" & Chr(13) & ex.Message)

        End Try

    End Sub

    '////////////////////////////////////////////////////////////////
    '/////////////// COMANDOS DE EXECUÇÃO (BUTTON) //////////////////

#Region "AÇÕES DOS BOTÕES"

    Private Sub btnTestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestar.Click

        Try
            'Habilitar comandos form
            Call HabilitarComandos(False, True, False)

            Call usrPortaSerial.Abrir_Porta_Comunicacao(spPortaSerial)
            If strErro_Porta_Comunicacao <> "" Or (spPortaSerial.IsOpen = False) Then Exit Sub

            'Barra de Progresso - 3 segundos
            barStatus.Enabled = True
            barStatus.Visible = True
            Call usrPortaSerial.Barra_de_Progresso(barStatus)

            'Ativar timer de comunicação 
            blnComunicacao = True
            tmrComunicacao.Enabled = True

            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
            blnJaFechouPorta = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnTestar_Click" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub btnParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParar.Click

        Try
            'Habilitar comandos form
            Call HabilitarComandos(True, False, True)

            'Fechar porta serial 
            Call usrPortaSerial.FecharPorta(spPortaSerial)

            'Ativar timer de comunicação 
            blnComunicacao = False
            tmrComunicacao.Enabled = False

            'Retorna para o estado inicial das labels
            lblControlador.Text = "Teste de comunicação ...."
            lblCarga.Text = "Teste de comunicação ...."
            lblLVDT.Text = "Teste de comunicação ...."

            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, 
            'pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
            blnJaFechouPorta = True

            'Zera o número de tentativas
            intTentativaVerificaCanais = 0
            'Limpa o Status para o próximo teste
            blnTemCanalHabilitadoPlaca0 = False
            blnTemCanalHabilitadoPlaca1 = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnParar_Click" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Try
            'Habilitar comandos
            usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        Finally
            Me.Close()

        End Try

    End Sub

    Private Sub tmrComunicacao_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrComunicacao.Tick

        Try

            'Condição para finalização comunicação em caso de falha na porta
            If Not blnComunicacao Then Exit Sub
            'Indicar a realização de leituras
            Call IndicadorComunicacao()

            Call ComandosPreliminares()

            'Realizar leituras
            Call RealizarLeituras()

        Catch ex As Exception

            'Mensagem de erro
            MsgBox("tmrComunicacao_Tick" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////////////
    '///////////////////////// FUNÇÕES E PROCEDIMENTOS //////////////////////

#Region "FUNÇÕES E PROCEDIMENTOS"

    Private Sub ComandosPreliminares()

        Try

            'Desabilitar o timer momentâneamente
            tmrComunicacao.Enabled = False

            If blnReadingOffSucesso = False Then
                Call DesligaReadingON()
            End If

            If blnDbOffSucesso = False Then
                Call DesligaDbon()
            End If

            If blnLeuPlacasInicializadasComSucesso = False Then
                Call LerNumeroPlacasInicializadas()
            End If

            If blnVerificouCanaisHabilitadosComSucesso = False Then
                Call LerVerificarCanaisHabilitados()
            End If

        Catch ex As Exception
            tmrComunicacao.Enabled = False
            MsgBox("ComandosPreliminares" & Chr(13) & ex.Message)
        Finally
            'Reabilita do timer
            tmrComunicacao.Enabled = True
        End Try

    End Sub

    Private Sub DesligaReadingON()
        Try

            'Desabilitar o timer momentâneamente
            tmrComunicacao.Enabled = False

            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESLIGAR_READING_ON, "Escrita")

            If ValidaComandoEscrita() = True Then
                blnReadingOffSucesso = True
            Else
                blnReadingOffSucesso = False
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("DesligaReadingON()" & Chr(13) & ex.Message)
        Finally
            'reabilita o timer 
            tmrComunicacao.Enabled = True
        End Try
    End Sub

    Private Sub DesligaDbon()
        Try

            'Desabilitar o timer momentâneamente
            tmrComunicacao.Enabled = False

            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESLIGAR_DEBUG_PROCESSADOR, "Escrita")

            If ValidaComandoEscrita() = True Then
                blnDbOffSucesso = True
            Else
                blnDbOffSucesso = False
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("DesligaDbon()" & Chr(13) & ex.Message)
        Finally
            'reabilita o timer 
            tmrComunicacao.Enabled = True
        End Try
    End Sub

    Private Sub LerNumeroPlacasInicializadas()
        Try

            'Desabilita momentaneamente
            tmrComunicacao.Enabled = False

            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_NUMERO_PLACAS_AD_INICIALIZADAS, "Leitura")

            If usrArduino_AD7192.blnErroRespostaByteUnico = False Then
                intNumeroPlacasInicializadas = intValorByteUnico
                blnLeuPlacasInicializadasComSucesso = True
            Else
                lblMsgErro.Text = "Não foi possível identificar a quantidade de placas inicializadas. As leituras não irão ser exibidas até a comunicação ser restabelecida"
                lblMsgErro.Visible = True
                blnLeuPlacasInicializadasComSucesso = False
            End If

        Catch ex As Exception
            tmrComunicacao.Enabled = False
            MsgBox("LerNumeroPlacasInicializadas" & Chr(13) & ex.Message)
        Finally
            'Reabilita do timer
            tmrComunicacao.Enabled = True
        End Try

    End Sub

    Private Function LerNumeroCanaisHabilitadosAD(ByVal strPlacaTemp As String) As Integer

        Dim intValorDecimalCanaisHabilitadosAD As Integer

        Try

            strPlaca = strPlacaTemp
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_CANAIS_HABILITADOS_AD, "Leitura")

            If usrArduino_AD7192.blnErroRespostaByteUnico = False Then
                intValorDecimalCanaisHabilitadosAD = intValorByteUnico
                intRetornoLeituraAD = 1
                Return usrComunicacao.Somar_Canais_Habilitados(intValorDecimalCanaisHabilitadosAD)
            Else
                intRetornoLeituraAD = 0
                lblMsgErro.Text = "Não foi possível identificar a quantidade de canais habilitados do AD0. As leituras não irão ser exibidas até a comunicação ser restabelecida"
                lblMsgErro.Visible = True
                Return 0
                Exit Function
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LerNumeroCanaisHabilitadosAD()" & Chr(13) & ex.Message)
        End Try

    End Function

    Private Sub LerVerificarCanaisHabilitados()
        Try

            'Desabilita momentaneamente
            tmrComunicacao.Enabled = False

            'Analisa Controlador
            If intNumeroPlacasInicializadas > 0 Then
                'Redimensiona o vetor que verifica os canais habilitados de cada placa
                'ReDim intNumeroCanaisHabilitadosAD(intNumeroPlacasInicializadas - 1)
                ReDim intPlacasLidasComSucesso(intNumeroPlacasInicializadas - 1)

                For i = 0 To intNumeroPlacasInicializadas - 1
                    intNumeroCanaisHabilitadosAD(i) = LerNumeroCanaisHabilitadosAD(i)
                    strCanaisHabAD(i) = usrComunicacao.Transformar_Bit_Canais_Habilitados(intValorByteUnico)
                    intPlacasLidasComSucesso(i) = intRetornoLeituraAD
                Next

            Else
                lblMsgErro.Visible = True
                lblMsgErro.Text = "Não foi possível detectar nenhuma placa inicializada. Verifique se o equipamento está energizado."
            End If

            'Para identificar que a resposta do comando 'rcha' para todas as placas foi corretamente recebida
            For i = 0 To intNumeroPlacasInicializadas - 1
                If intPlacasLidasComSucesso(i) = 0 Then
                    blnVerificouCanaisHabilitadosComSucesso = False
                    Exit For
                Else
                    blnVerificouCanaisHabilitadosComSucesso = True
                End If
            Next

        Catch ex As Exception
            tmrComunicacao.Enabled = False
            MsgBox("LerVerificarCanaisHabilitados" & Chr(13) & ex.Message)
        Finally
            'Reabilita do timer
            tmrComunicacao.Enabled = True
        End Try

    End Sub

    Public Function ValidaComandoEscrita() As Boolean
        Try
            'Acusa erro de leitura
            If usrArduino_AD7192.blnErroRespostaConferencia = True Then
                'ERRO NA CONFERÊNCIA DO COMANDO ENVIADO
                lblMsgErro.Visible = True
                lblMsgErro.BackColor = Color.Red
                lblMsgErro.Text = "O comando de escrita direcionado ao controlador não pôde ser enviado"
                Return False
            Else
                'SUCESSO NA CONFERÊNCIA DO COMANDO ENVIADO
                Return True
            End If
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ValidaComandoEscrita()" & Chr(13) & ex.Message)
        End Try
    End Function

    Private Sub HabilitarComandos(ByVal blnTestar As Boolean, ByVal blnParar As Boolean, ByVal blnOk As Boolean)

        Try
            btnTestar.Enabled = blnTestar
            btnParar.Enabled = blnParar
            btnOk.Enabled = blnOk

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarComandos" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub IndicadorComunicacao()

        Try
            If blnPisca Then
                lblControlador.ForeColor = Color.Blue
                lblCarga.ForeColor = Color.Blue
                lblLVDT.ForeColor = Color.Blue
            Else
                lblControlador.ForeColor = Color.Red
                lblCarga.ForeColor = Color.Red
                lblLVDT.ForeColor = Color.Red
            End If

            blnPisca = Not blnPisca

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("IndicadorComunicacao" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub RealizarLeituras()
        Try
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_MULTIPLAS_RESPOSTAS, "Leitura")

            'Condição de validação
            If Not usrArduino_AD7192.blnErroRespostasMultiplas Then

                lblControlador.Text = "Leitura realizada com SUCESSO ..."

                If intStatusInicializacaoAD0 = 1 And intNumeroCanaisHabilitadosAD(0) = 1 Then
                    lblCarga.Text = "Leitura realizada com SUCESSO ..."
                ElseIf intStatusInicializacaoAD0 = 0 Then
                    lblCarga.Text = "Placa 0 não inicializada ..."
                Else
                    lblCarga.Text = "O canal " & usrInicializacaoFabricante.CELULACARGA_CANAL & " da placa " & usrInicializacaoFabricante.CELULACARGA_PLACA & " não está habilitado"
                End If

                If usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "True" Then
                    If intStatusInicializacaoAD1 = 1 And intNumeroCanaisHabilitadosAD(1) Then
                        lblLVDT.Text = "Leitura realizada com SUCESSO ..."
                    ElseIf intStatusInicializacaoAD1 = 0 Then
                        lblLVDT.Text = "Placa 1 não inicializada ..."
                    Else
                        lblLVDT.Text = "O canal " & usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL & " da placa " & usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA & " não está habilitado"
                    End If

                Else
                    lblLVDT.Text = "Desabilitado ..."

                End If

            Else

                lblMsgErro.Visible = True

                lblMsgErro.Text = "Erro de comunicação nas leituras dos instrumentos e sensores ('rall')"

            End If

        Catch ex As Exception
            'Desabilita Timer
            tmrComunicacao.Enabled = False

            MsgBox("RealizarLeituras()" & Chr(13) & ex.Message)
        End Try

    End Sub

    'Public Sub LeituraCarga()
    '    Try

    '        'Verifica a existência de canais habilitados na placa 0
    '        If blnTemCanalHabilitadoPlaca0 = False Then

    '            Call usrComunicacao.VerificaCanaisHabilitadosPlaca0(spPortaSerial)

    '            'Se houve erro no pedido de verificação dos canais
    '            If blnErroLeituraStatusCanalPlaca0 Then
    '                lblMsgErro.Visible = True
    '                lblMsgErro.Text = "Erro de leitura na verificação dos canais da Placa 0 ..."
    '                Exit Sub
    '            End If

    '            'Se o verificador 'blnCanal0' não ficou verdadeiro, logo não habilitou canal 0
    '            If usrComunicacao.blnCanal0 = False Then
    '                If intTentativaVerificaCanais < 2 Then
    '                    intTentativaVerificaCanais = intTentativaVerificaCanais + 1
    '                Else
    '                    lblCarga.Text = "O canal 0 da placa 0 está desabilitado ..."
    '                    Exit Sub
    '                End If
    '            End If

    '        End If

    '        'Se o canal 0 está habilitado prossegue com as demais verificações e leitura
    '        If usrComunicacao.blnCanal0 = True Then
    '            'Parametrização para leitura de carga
    '            strPlaca = "0"
    '            strValorCanalAD = "0"

    '            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_STATUS_AD, "Leitura")
    '            If Not usrArduino_AD7192.blnErroLeituraStatusAD_P0 Then
    '                lblCarga.Text = "Leitura realizada com SUCESSO ..."
    '            Else
    '                lblCarga.Text = "Falha na comunicação SPI com AD da Placa 0 ..."
    '                Exit Sub
    '            End If

    '            'Comando de leitura de carga
    '            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_AD, "Leitura")

    '            'Resposta para o Controlador/servoconversor
    '            If Not usrArduino_AD7192.blnErroLeituraCarga Then
    '                lblCarga.Text = "Leitura realizada com SUCESSO ..."
    '            Else
    '                lblCarga.Text = "ERRO de leitura ..."
    '            End If
    '        Else
    '            lblCarga.Text = "O canal 0 da placa 0 está desabilitado ..."
    '        End If

    '    Catch ex As Exception
    '        'Mensagem de erro
    '        MsgBox("LeituraCarga" & Chr(13) & ex.Message)
    '    End Try
    'End Sub

    'Public Sub LeituraLVDT()
    '    Try

    '        'Verifica a existência de canais habilitados na placa 1
    '        If blnTemCanalHabilitadoPlaca1 = False Then
    '            Call usrComunicacao.VerificaCanaisHabilitadosPlaca1(spPortaSerial)

    '            'Se houve erro no pedido de verificação dos canais
    '            If blnErroLeituraStatusCanalPlaca1 Then
    '                lblMsgErro.Visible = True
    '                lblMsgErro.Text = "Erro de leitura na verificação dos canais da Placa 1 ..."
    '                Exit Sub
    '            End If

    '            'Se o verificador 'blnCanal4' não ficou verdadeiro, logo não habilitou canal 4
    '            If usrComunicacao.blnCanal4 = False Then
    '                If intTentativaVerificaCanais < 2 Then
    '                    intTentativaVerificaCanais = intTentativaVerificaCanais + 1
    '                Else
    '                    lblLVDT.Text = "O canal 4 da placa 1 está desabilitado ..."
    '                    Exit Sub
    '                End If
    '            End If
    '        End If

    '        If usrComunicacao.blnCanal4 = True Then
    '            'Número do CH
    '            strPlaca = "1"
    '            strValorCanalAD = "4"

    '            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_STATUS_AD, "Leitura")
    '            If Not usrArduino_AD7192.blnErroLeituraStatusAD_P1 Then
    '                lblLVDT.Text = "Leitura realizada com SUCESSO ..."
    '            Else
    '                lblLVDT.Text = "Falha na comunicação SPI com AD da Placa 1 ..."
    '                Exit Sub
    '            End If

    '            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_AD, "Leitura")
    '            'Condição de validação
    '            If Not usrArduino_AD7192.blnErroLeituraLVDT Then
    '                lblLVDT.Text = "Leitura realizada com SUCESSO ..."
    '            Else
    '                lblLVDT.Text = "ERRO de leitura ..."
    '            End If

    '        Else
    '            lblLVDT.Text = "O canal 4 da placa 1 está desabilitado ..."
    '        End If

    '        'Se o timer foi interrompido no meio de um comando volto texto dos labels
    '        If tmrComunicacao.Enabled = False Then
    '            lblControlador.Text = "Teste de comunicação ...."
    '            lblCarga.Text = "Teste de comunicação ...."
    '            lblLVDT.Text = "Teste de comunicação ...."
    '        End If

    '    Catch ex As Exception
    '        'Mensagem de erro
    '        MsgBox("LeituraLVDT" & Chr(13) & ex.Message)
    '    End Try
    'End Sub


#End Region


End Class
