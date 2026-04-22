Option Strict Off
Option Explicit On

Imports System.IO.Ports
Imports System.Threading


Public Class frmCalibracao

#Region "DECLARAÇÃO DE VARIÁVEIS"

    Dim intTentativaVerificaCanais As Integer

    'Calibrador
    Dim intInstrumento As Integer

    Dim intTentativaVerificaCanal0 As Integer
    Dim intTentativaVerificaCanal4 As Integer
    Dim intTentativaVerificaCanal5 As Integer

    Dim blnJaCarregouConstantes As Boolean
    'Condição para salvar os dados alterados
    Dim blnJaSalvou As Boolean
    Dim blnErroSalvar As Boolean

    'Variável suporte para fazer condições 
    Dim blnLeOffConst As Boolean

    'Calibrar os valores dos dispositivos
    Dim dblSensor As Double
    Dim lngOffsetCarga As Long
    Dim lngOffsetLVDT As Long
    Dim dblConstanteCarga As Double
    Dim dblConstanteLVDT As Double
    Dim dblLeitura As Double

    Dim intContadorRecebimento As Integer
    Dim intContadorExibicaoErro As Integer

    Dim blnComandoLocal As Boolean
    Dim blnComandoRemoto As Boolean
    Dim blnComandoSubir As Boolean
    Dim blnComandoDescer As Boolean
    Dim blnComandoParar As Boolean
    Dim blnEnviarVelocidadeTemporaria As Boolean
    Dim dblVelocMaxima As Double
    Dim dblVelocidade As Double
    Dim intMovimento As Integer
    Dim intUltimoMovimento As Integer
    Dim dblVelocidadeCalibracao As Double
    Dim intVerificacaModo As Integer
    Dim blnPrimeiroScan As Boolean
    Private blnSubindoPrensa As Boolean
    Private blnDescendoPrensa As Boolean
    Dim blnDbOffSucesso, blnReadingOffSucesso, blnLeuPlacasInicializadasComSucesso, blnVerificouCanaisHabilitadosComSucesso, blnLeuConstantesPIDComSucesso, blnComandosPreliminaresComSucesso As Boolean
    Dim intRetornoLeituraAD As Integer
    Dim strCanaisHabAD(3) As String
    Dim intPlacasLidasComSucesso() As Integer

#End Region

    Private Sub frmCalibracaoTeste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            'Pega ID form de comunicacao
            intID_Tela_Comunicacao = 2

            'Setar as Clases
            usrComunicacao = New clsComunicacao
            usrPortaSerial = New clsPortaSerial
            usrArduino_AD7192 = New clsArduino_AD7192
            usrDiversos = New clsDiversos

            'Desabilitar comandos
            usrLayout.HabilitarComandos(False)

            lblStatusComandoEscrita.Text = ""

            dblVelocMaxima = 6000 '60 Hz enviado de forma centesimal

            'Calibrar
            intInstrumento = CARGA

            If usrInicializacaoFabricante.HABILITACAO_CARGA = "False" And usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "False" Then
                btnLigar.Enabled = False
                grpLeituraAdicional.Visible = False
                MsgBox("Não existem instrumentos habilitados", MsgBoxStyle.Information, "Botão Ligar")
            ElseIf usrInicializacaoFabricante.HABILITACAO_CARGA = "False" And usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "True" Then
                rdbDeslocamento.Checked = True
                rdbCarga.Enabled = False
                grpLeituraAdicional.Visible = False
            ElseIf usrInicializacaoFabricante.HABILITACAO_CARGA = "true" And usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "false" Then
                rdbCarga.Checked = True
                rdbDeslocamento.Enabled = False
                grpLeituraAdicional.Visible = False
            Else
                rdbCarga.Checked = True
                grpLeituraAdicional.Visible = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCalibracao_Load" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub frmCalibracaoTeste_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            'Habilitar comandos
            usrLayout.HabilitarComandos(True)

            'Checar comando "Ligar"
            If btnLigar.Text = "Desligar >>" Then
                'Realizar os procedimentos e solicita gravação dos dados
                btnLigar_Click(Nothing, Nothing)
            End If

            'Zera o número de tentativas
            intTentativaVerificaCanal0 = 0
            intTentativaVerificaCanal4 = 0
            intTentativaVerificaCanal5 = 0
            'Limpa o Status para o próximo teste
            blnTemCanalHabilitadoPlaca0 = False
            blnTemCanalHabilitadoPlaca1 = False

            If tmrCalibracao.Enabled = True Then
                blnComunicacao = False
                tmrCalibracao.Enabled = False
            End If

            If spPortaSerial.IsOpen Then
                'Fechar porta serial 
                Call usrPortaSerial.FecharPorta(spPortaSerial)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCalibracao_FormClosed" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub btnLigar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLigar.Click
        Try
            'Verificar se comando iniciar
            If btnLigar.Text = "Ligar >>" Then

                'Iniciar a comunicação
                Call IniciarCalibracao()

                If strErro_Porta_Comunicacao <> "" Or (spPortaSerial.IsOpen = False) Then Exit Sub

                'Próximo comando "Desligar"
                btnLigar.Text = "Desligar >>"

                btnOffSet.Enabled = True
                grpLocalRemoto.Enabled = True
                grbAjusteCalibracao.Enabled = True
                grpInstrumentos.Enabled = True
                grpOperacao.Enabled = True
                grpOutputMotor.Enabled = True
                grpTaxa.Enabled = True
                grpLeituraAdicional.Enabled = True

                'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, 
                'pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
                blnJaFechouPorta = False

                'Condição para finalização comunicação em caso de falha na porta
                blnComunicacao = True

                btnSalvarCalibracao.Enabled = True

            Else

                'Finalizar a comunicação
                Call FinalizarCalibracao()

                'Voltar comando original
                btnLigar.Text = "Ligar >>"

                btnOffSet.Enabled = False
                grpLocalRemoto.Enabled = False
                grbAjusteCalibracao.Enabled = False
                grpGroupSelecionado.Enabled = False
                grpInstrumentos.Enabled = False
                grpOperacao.Enabled = False
                grpOutputMotor.Enabled = False
                grpTaxa.Enabled = False
                grpLeituraAdicional.Enabled = False

                'Condição para evitar erro de porta COM
                blnJaFechouPorta = True

                If blnJaSalvou = False Then
                    'Mensagem que o usuário escolhe se quer salvar ou não.
                    If MsgBox("Deseja salvar os valores da calibração do canal selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salvar valores") = MsgBoxResult.Yes Then
                        'Chamar a Rotina que grava os dados no *.ini
                        Call Gravar_Calibracao(intInstrumento)
                    End If

                End If

                'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, 
                'pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
                blnJaFechouPorta = True

                'Condição para finalização comunicação em caso de falha na porta
                blnComunicacao = False

                btnSalvarCalibracao.Enabled = False

                blnJaCarregouConstantes = False

                'Zera o número de tentativas
                intTentativaVerificaCanal0 = 0
                intTentativaVerificaCanal4 = 0
                intTentativaVerificaCanal5 = 0
                'Limpa o Status para o próximo teste
                blnTemCanalHabilitadoPlaca0 = False
                blnTemCanalHabilitadoPlaca1 = False

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("cmdLigar_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    '////////////////////////////////////////////////////////////////////////
    '///////////////////////// FUNÇÕES E PROCEDIMENTOS //////////////////////

#Region "FUNÇÕES E PROCEDIMENTOS - CALIBRAÇÃO"

    Private Sub IniciarCalibracao()
        'Iniciar a comunicação com os leitores

        Try
            'Habilitar comandos de execução
            Call HabilitarComandos(True, False)

            'Abrir a porta de comunicação serial
            Call usrPortaSerial.Abrir_Porta_Comunicacao(spPortaSerial)
            If strErro_Porta_Comunicacao <> "" Or (spPortaSerial.IsOpen = False) Then Exit Sub

            barStatus.Enabled = True
            barStatus.Visible = True
            Call Barra_de_Progresso()

            'Leitura do offset
            blnLeOffConst = True

            'Timer de comunicação
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("IniciarCalibracao" & Chr(13) & ex.Message)

        End Try
    End Sub

    Public Sub Barra_de_Progresso()

        barStatus.Visible = True

        Dim stopwatch As Stopwatch = Stopwatch.StartNew()

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 10

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 20

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 30

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 40

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 50

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 60

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 70

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 80

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 90

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 100

        stopwatch.Stop()

        barStatus.Enabled = False

        barStatus.Value = 0

        barStatus.Visible = False

        'Label2.Text = stopwatch.ElapsedMilliseconds

    End Sub

    Private Sub FinalizarCalibracao()
        'Finalizar a comunicação com os leitores

        Try
            'Desabilitar mensgem de erro
            lblMsgErro.Visible = False

            'Habilitar comandos de execução
            Call HabilitarComandos(False, True)

            'Timer de comunicação
            tmrCalibracao.Enabled = False

            'Fechar porta serial 
            Call usrPortaSerial.FecharPorta(spPortaSerial)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("FinalizarCalibracao" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub HabilitarComandos(ByVal blnOff As Boolean, ByVal blnOk As Boolean)
        'Habilitar os comandos para a calibração

        Try
            'Habilitar 
            btnSalvarCalibracao.Enabled = blnOff
            btnOk.Enabled = blnOk

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarComandos" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    Public Sub Gravar_Calibracao(ByVal intInstrumento As Integer)

        Try

            Select Case intInstrumento
                Case 1 'Deformação 1

                    'Placa
                    strPlaca = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA
                    'Canal do AD
                    strValorCanalAD = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL

                    'Constante
                    If Not IsNumeric(txtConst.Text) Then
                        MsgBox("Digitar um valor numérico para a CONSTANTE DE CALIBRAÇÃO.", MsgBoxStyle.Exclamation)
                        txtConst.Focus()
                        blnJaSalvou = False
                        blnErroSalvar = True
                        Exit Sub
                    End If

                    'Offset
                    If Not IsNumeric(txtOffSet.Text) Then
                        MsgBox("Digitar um valor numérico para o OffSET.", MsgBoxStyle.Exclamation)
                        txtOffSet.Focus()
                        blnJaSalvou = False
                        blnErroSalvar = True
                        Exit Sub
                    End If

                    'Float number maior que 7 dígitos
                    If txtConst.Text.Contains(",") Then
                        If txtConst.Text.Length > 8 Then
                            blnErroSalvar = True
                            Exit Sub
                        End If
                    Else
                        If txtConst.Text.Length > 7 Then
                            blnErroSalvar = True
                            Exit Sub
                        End If
                    End If

                    'Para Salvar no arquivo ini
                    dblConstanteLVDT = CDbl(txtConst.Text)
                    lngOffsetLVDT = CDbl(txtOffSet.Text)

                    'Passa o valor para string
                    strValorConstanteUsuario = FormatarPontoDecimal(txtConst.Text)
                    strValorOffsetUsuario = FormatarPontoDecimal(txtOffSet.Text)

                Case 3 'Carga

                    'Placa
                    strPlaca = usrInicializacaoFabricante.CELULACARGA_PLACA
                    'Canal do AD
                    strValorCanalAD = usrInicializacaoFabricante.CELULACARGA_CANAL

                    'Constante
                    If Not IsNumeric(txtConst.Text) Then
                        MsgBox("Digitar um valor numérico para a CONSTANTE DE CALIBRAÇÃO.", MsgBoxStyle.Exclamation)
                        txtConst.Focus()
                        blnJaSalvou = False
                        blnErroSalvar = True
                        Exit Sub
                    End If

                    'Offset
                    If Not IsNumeric(txtOffSet.Text) Then
                        MsgBox("Digitar um valor numérico para o OffSET.", MsgBoxStyle.Exclamation)
                        txtOffSet.Focus()
                        blnJaSalvou = False
                        blnErroSalvar = True
                        Exit Sub
                    End If

                    'Float number maior que 7 dígitos
                    If txtConst.Text.Contains(",") Then
                        If txtConst.Text.Length > 8 Then
                            blnErroSalvar = True
                            Exit Sub
                        End If
                    Else
                        If txtConst.Text.Length > 7 Then
                            blnErroSalvar = True
                            Exit Sub
                        End If
                    End If

                    'Para Salvar no arquivo ini
                    dblConstanteCarga = CDbl(txtConst.Text)
                    lngOffsetCarga = CDbl(txtOffSet.Text)

                    'Passa o valor para string
                    strValorConstanteUsuario = FormatarPontoDecimal(txtConst.Text)
                    strValorOffsetUsuario = FormatarPontoDecimal(txtOffSet.Text)

            End Select

            'Desativa momentâneamente os timers
            tmrCalibracao.Enabled = False
            tmrLimparErros.Enabled = False

            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_ESCALA_CALIBRACAO_USUARIO, "Escrita")
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_OFFSET_CALIBRACAO_USUARIO, "Escrita")

            blnJaSalvou = True
            blnErroSalvar = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Gravar_Calibracao" & Chr(13) & ex.Message)
        Finally
            'Volta a ligar timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Public Function FormatarPontoDecimal(ByVal strConstante As String) As String
        Try
            'Caso o número seja grande e tenha separação de milhar, tenho que remover esse ponto antes
            If strConstante.Contains(".") Then
                strConstante = strConstante.Replace(".", "")
            End If

            'A virgula que é a separação decimal deve ser substituida por ponto para o arduino entender
            FormatarPontoDecimal = strConstante.Replace(",", ".")

        Catch ex As Exception

            MsgBox("FormatarPontoDecimal()" & Chr(13) & ex.Message)

            Return Nothing

        End Try

    End Function

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            'Habilitar  comandos
            usrLayout.HabilitarComandos(True)
            'Fechar
            Me.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub btnSalvarCalibracao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarCalibracao.Click
        Try

            'Gravar
            Gravar_Calibracao(intInstrumento)

            If blnErroSalvar = False Then
                MsgBox("Os dados foram atualizados com sucesso!", MsgBoxStyle.Information, "Atualização")
                blnErroSalvar = False
            Else
                MsgBox("Os dados NÃO atenderam aos critérios!", MsgBoxStyle.Exclamation, "Atualização")
            End If

            If blnJaSalvou = True Then
                btnSalvarCalibracao.Enabled = False
            Else
                btnSalvarCalibracao.Enabled = True
            End If


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnSalvarCalibracao_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tmrCalibracao_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCalibracao.Tick
        Try

            'Condição para finalização comunicação em caso de falha na porta
            If Not blnComunicacao Then Exit Sub

            Call ComandosPreliminares()

            If blnComandoLocal Then Call ComandoModoLocal()
            If blnComandoRemoto Then Call ComandoModoRemoto()

            'Realizar leituras
            Call RealizarLeituras()

        Catch ex As Exception

            'Desabilita Timer
            tmrCalibracao.Enabled = False

            'Mensagem de erro
            MsgBox("tmrCalibracao_Tick" & Chr(13) & ex.Message)

            Me.Close()

        End Try
    End Sub

    Private Sub tmrLimparErros_Tick(sender As Object, e As EventArgs) Handles tmrLimparErros.Tick
        Try

            If intContadorExibicaoErro > 1 And lblMsgErro.Visible = True Then
                intContadorExibicaoErro = 0

                lblMsgErro.Text = ""
                lblMsgErro.Visible = False

            End If

            intContadorExibicaoErro += 1

        Catch ex As Exception

            'Desabilita Timer
            tmrLimparErros.Enabled = False

            'Mensagem de erro
            MsgBox("tmrLimparErros_Tick" & Chr(13) & ex.Message)

        End Try
    End Sub

#Region " FUNÇÕES E PROCEDIMENTOS - LEITURA"

    Private Sub ComandosPreliminares()

        Dim strCanaisHabilitadosAD0, strCanaisHabilitadosAD1 As String

        Try

            'Desabilitar o timer momentâneamente
            tmrCalibracao.Enabled = False

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
            tmrCalibracao.Enabled = False
            MsgBox("ComandosPreliminares" & Chr(13) & ex.Message)
        Finally
            'Reabilita do timer
            tmrCalibracao.Enabled = True
        End Try
    End Sub

    Private Sub DesligaDbon()
        Try

            'Desabilitar o timer momentâneamente
            tmrCalibracao.Enabled = False

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
            tmrCalibracao.Enabled = True
        End Try
    End Sub

    Private Sub DesligaReadingON()
        Try

            'Desabilitar o timer momentâneamente
            tmrCalibracao.Enabled = False

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
            tmrCalibracao.Enabled = True
        End Try
    End Sub

    Public Sub ComandoModoRemoto()
        Try

            'Desativa momentâneamente os timers
            tmrCalibracao.Enabled = False
            tmrLimparErros.Enabled = False

            blnComandoRemoto = False
            'Modo local
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_MODO_OPERACAO_REMOTO, "Escrita")
            Call ValidaComandoEscrita()

        Catch ex As Exception
            MsgBox("ModoRemoto()" & Chr(13) & ex.Message)
        Finally
            'Volta a ligar timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try
    End Sub

    Public Sub ComandoModoLocal()
        Try

            'Desativa momentâneamente os timers
            tmrCalibracao.Enabled = False
            tmrLimparErros.Enabled = False

            blnComandoLocal = False
            'Modo local
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_MODO_OPERACAO_MANUAL, "Escrita")
            Call ValidaComandoEscrita()

        Catch ex As Exception
            MsgBox("ModoLocal()" & Chr(13) & ex.Message)
        Finally
            'Volta a ligar timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try
    End Sub

    Public Sub ComandoPararMotor()
        Try

            'Desativa momentâneamente os timers
            tmrCalibracao.Enabled = False
            tmrLimparErros.Enabled = False

            'Modo local
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_PARAR_MOTOR, "Escrita")
            Call ValidaComandoEscrita()

        Catch ex As Exception
            MsgBox("ComandoPararMotor()" & Chr(13) & ex.Message)
        Finally
            'Volta a ligar timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try
    End Sub

    Public Function ValidaComandoEscrita() As Boolean
        Try
            'Acusa erro de leitura
            If usrArduino_AD7192.blnErroRespostaConferencia = True Then
                'ERRO NA CONFERÊNCIA DO COMANDO ENVIADO
                lblStatusComandoEscrita.ForeColor = Color.Red
                lblStatusComandoEscrita.Text = "Não Enviado"
                Return False
            Else
                'SUCESSO NA CONFERÊNCIA DO COMANDO ENVIADO
                lblStatusComandoEscrita.ForeColor = Color.DarkGray
                lblStatusComandoEscrita.Text = "Enviado"
                Return True
            End If
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ValidaComandoEscrita()" & Chr(13) & ex.Message)
        End Try
    End Function

    Private Sub LerNumeroPlacasInicializadas()
        Try

            'Desabilita momentaneamente
            tmrCalibracao.Enabled = False

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
            tmrCalibracao.Enabled = False
            MsgBox("LerNumeroPlacasInicializadas" & Chr(13) & ex.Message)
        Finally
            'Reabilita do timer
            tmrCalibracao.Enabled = True
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
            tmrCalibracao.Enabled = False

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
            tmrCalibracao.Enabled = False
            MsgBox("LerVerificarCanaisHabilitados" & Chr(13) & ex.Message)
        Finally
            'Reabilita do timer
            tmrCalibracao.Enabled = True
        End Try

    End Sub

    Private Sub RealizarLeituras()

        Try

            'Leitura dos instrumentos e sensores
            Call LeituraDeTudo()

            'Leitura da Constante e Offset
            If blnJaCarregouConstantes = False Then
                'Carrega do arduino o valor de Escala/Constante da Carga
                Call LeituraConstanteUsuario(intInstrumento)
                'Carrega do arduino o valor de Offset da Carga
                Call LeituraOffsetUsuario(intInstrumento)
                'Analisa se a Constante e Offset vieram com os valores zerados
                Call VerificaMemoriaEEPROMVazia(intInstrumento)
                'Sai da sub para antecipar esse ciclo de scan

                'Se o timer foi interrompido no meio de um comando volto texto dos labels
                If tmrCalibracao.Enabled = False Then
                    lblMsgErro.Text = ""
                    lblMsgErro.Visible = False
                End If

                Exit Sub

            End If

            'Leitura do Sensor
            Call CalculoSensorAD(intInstrumento)

            'Se o timer foi interrompido no meio de um comando volto texto dos labels
            If tmrCalibracao.Enabled = False Then
                lblMsgErro.Text = ""
                lblMsgErro.Visible = False
            End If

        Catch ex As Exception
            'Desabilita Timer
            tmrCalibracao.Enabled = False

            btnLigar.Text = "Ligar >>"

            'Mensagem de erro
            MsgBox("RealizarLeituras" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub LeituraDeTudo()
        Try
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_MULTIPLAS_RESPOSTAS, "Leitura")

            'Condição de validação
            If Not usrArduino_AD7192.blnErroRespostasMultiplas Then
                Call ApresentarLeituras()
                Call ApresentarStatus()
            Else
                lblLeitura.Text = ""
                lblMsgErro.Text = "Erro de comunicação nas leituras dos instrumentos e sensores ('rall')"
                lblMsgErro.Visible = True
                intContadorExibicaoErro = 0
            End If

        Catch ex As Exception
            MsgBox("LeituraDeTudo()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub ApresentarLeituras()
        Try

            'Leitura Calibrada
            Select Case intInstrumento

                Case LVDT

                    lblLeitura.Text = FormatNumber(sngLeituraDeslocamento, 3)
                    lblLeituraAdicional.Text = FormatNumber(sngLeituraCarga, 1)
                    grpLeituraAdicional.Text = "Carga (kgf)"

                Case CARGA

                    lblLeitura.Text = FormatNumber(sngLeituraCarga, 1)
                    lblLeituraAdicional.Text = FormatNumber(sngLeituraDeslocamento, 3)
                    grpLeituraAdicional.Text = "Deslocamento (mm)"

            End Select

            lblOutputMotor.Text = FormatNumber(sngOutputMotor / 100, 2)

        Catch ex As Exception
            MsgBox("ApresentarLeituras()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub ApresentarStatus()

        Dim strStatus(1) As String
        Dim intStatusParte1, intStatusParte2 As Integer

        Try

            If strStatusInputs <> "" Then

                'Se chegou até aqui a comunicação com Contralador foi com sucesso
                'Recebe os status para avaliar os demais dispositivo
                strStatus = strStatusInputs.Split(":")
                intStatusParte1 = CInt(strStatus(0))
                intStatusParte2 = CInt(strStatus(1))

                'Decodifica os status
                Call usrComunicacao.Transformar_Bit_Status1(intStatusParte1, intStatusParte2)

                'Leitura Status: Limites Threshold (Carga e LVDT)
                lblSituacaoEnsaio.Text = strStatusThreshold

                'Leitura Status: Modo Local / Modo Remoto
                lblStatusModoLocalRemoto.Text = usrComunicacao.strStatusMaquina(6)

                'Modo Local/Modo Remoto
                If usrComunicacao.strStatusMaquina(6) = "Modo Local (Manual)" Then
                    lblStatusModoLocalRemoto.ForeColor = Color.Navy
                Else
                    lblStatusModoLocalRemoto.ForeColor = Color.Red
                End If

                'Ajustes adicionais Modo Local/ Modo Remoto
                If usrComunicacao.strStatusMaquina(6) = "Modo Local (Manual)" And rdbRemoto.Checked Then
                    'Verifivação para garantir a atualização completa do Status
                    If intVerificacaModo > 1 Then
                        'Verifica a situação do check mediante ao status atual. Se ainda está marcando remoto, mas o status indica que está local, corrige a exibição para o usuário
                        rdbLocal.Checked = True
                        intVerificacaModo = 0
                    Else
                        intVerificacaModo += 1
                    End If

                ElseIf usrComunicacao.strStatusMaquina(6) = "Modo Remoto (Automático)" And rdbLocal.Checked Then
                    If intVerificacaModo > 1 Then
                        'Verifica a situação do check mediante ao status atual. Se ainda está marcando remoto, mas o status indica que está local, corrige a exibição para o usuário
                        rdbRemoto.Checked = True
                        grpGroupSelecionado.Enabled = True
                        intVerificacaModo = 0
                    Else
                        intVerificacaModo += 1
                    End If

                End If

                'FDC e Emergência
                If usrComunicacao.strStatusMaquina(1) = "Fim de Curso Inferior" Then
                    lblFimCursoInferior.ForeColor = Color.Red
                Else
                    lblFimCursoInferior.ForeColor = Color.DarkGray
                End If

                If usrComunicacao.strStatusMaquina(2) = "Fim de Curso Superior" Then
                    lblFimCursoSuperior.ForeColor = Color.Red
                Else
                    lblFimCursoSuperior.ForeColor = Color.DarkGray
                End If

                If usrComunicacao.strStatusMaquina(3) = "Emergência" Then
                    lblEmergencia.ForeColor = Color.Red
                Else
                    lblEmergencia.ForeColor = Color.DarkGray
                End If

                'Movimentação da Prensa
                If usrComunicacao.strStatusMaquina(4) = "" And usrComunicacao.strStatusMaquina(5) = "" Then
                    lblSubindoDescendo.Text = "Prensa Parada"
                    lblSubindoDescendo.ForeColor = Color.DarkGray
                    blnSubindoPrensa = False
                    blnDescendoPrensa = False
                ElseIf usrComunicacao.strStatusMaquina(4) = "Subindo" Then
                    lblSubindoDescendo.Text = "Prensa Subindo"
                    lblSubindoDescendo.ForeColor = Color.Navy
                    blnSubindoPrensa = True
                    blnDescendoPrensa = False
                ElseIf usrComunicacao.strStatusMaquina(5) = "Descendo" Then
                    lblSubindoDescendo.Text = "Prensa Descendo"
                    lblSubindoDescendo.ForeColor = Color.Navy
                    blnDescendoPrensa = True
                    blnSubindoPrensa = False

                End If

                'Leitura Status: Sobrecarga
                If usrComunicacao.strStatusMaquina(0) = "Sobrecarga On" Then
                    lblStatusFaixaCarga.Text = "Sobrecarga"
                    lblStatusFaixaCarga.ForeColor = Color.Red
                Else
                    lblStatusFaixaCarga.Text = "Sobrecarga"
                    lblStatusFaixaCarga.ForeColor = Color.DarkGray
                End If

                'Leitura Status: Sobrecurso
                If usrComunicacao.strStatusMaquina(10) = "Sobrecurso On" Then
                    lblStatusFaixaCurso.Text = "Sobrecurso"
                    lblStatusFaixaCurso.ForeColor = Color.Red
                Else
                    lblStatusFaixaCurso.Text = "Sobrecurso"
                    lblStatusFaixaCurso.ForeColor = Color.DarkGray
                End If

                'Leitura Status: PID
                If usrComunicacao.strStatusMaquina(12) = "PID Ligado" Then
                    lblPID.Text = "PID Ligado"
                    lblPID.ForeColor = Color.Navy
                Else
                    lblPID.Text = "PID Desligado"
                    lblPID.ForeColor = Color.DarkGray
                End If

                'Leitura Status: Sobrecurso
                If usrComunicacao.strStatusMaquina(13) = "" And usrComunicacao.strStatusMaquina(14) = "" Then
                    lblSetpoint.Text = "Setpoint Parado"
                    lblSetpoint.ForeColor = Color.DarkGray
                ElseIf usrComunicacao.strStatusMaquina(13) = "Subindo Setpoint" Then
                    lblSetpoint.Text = "Setpoint Subindo"
                    lblSetpoint.ForeColor = Color.Navy
                ElseIf usrComunicacao.strStatusMaquina(14) = "Descendo Setpoint" Then
                    lblSetpoint.Text = "Setpoint Descendo"
                    lblSetpoint.ForeColor = Color.Navy
                End If

                If usrComunicacao.strStatusMaquina(9) = "Célula de Carga Conectada" Then
                    lblConexaoCelula.Text = "Célula Conectada"
                    lblConexaoCelula.ForeColor = Color.Navy
                Else
                    lblConexaoCelula.Text = "Célula Desconectada"
                    lblConexaoCelula.ForeColor = Color.Red
                End If

            End If

        Catch ex As Exception
            MsgBox("ApresentarStatus()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub LeituraConstanteUsuario(ByVal intInstrumento As Integer)

        Try

            Select Case intInstrumento

                Case LVDT 'Deformação 1
                    strPlaca = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA
                    strValorCanalAD = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL

                    'Carrega Constantes de Calibração do Usuário da EEPROM do Arduino
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_ESCALA_CALIBRACAO_USUARIO, "Leitura")

                    'Se houver erro
                    If usrArduino_AD7192.blnErroLeituraConstantesAD Then
                        lblMsgErro.Text = "Erro na leitura da Constante da Deformação 1"
                        lblMsgErro.Visible = True
                        intContadorExibicaoErro = 0
                        Exit Sub
                    End If

                    dblConstanteLVDT = sngValorFloatRespostaByte

                    'Carrega o valor da constante de calibração do usuário
                    txtConst.Text = Math.Round(dblConstanteLVDT, 3)

                    'Limpa mensagem
                    lblMsgErro.BackColor = Color.Red
                    lblMsgErro.Visible = False

                Case CARGA 'Carga
                    strPlaca = usrInicializacaoFabricante.CELULACARGA_PLACA
                    strValorCanalAD = usrInicializacaoFabricante.CELULACARGA_CANAL

                    'Carrega Constantes de Calibração do Usuário da EEPROM do Arduino
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_ESCALA_CALIBRACAO_USUARIO, "Leitura")

                    'Se houver erro
                    If usrArduino_AD7192.blnErroLeituraConstantesAD Then
                        lblMsgErro.Text = "Erro na leitura da Constante da Carga"
                        lblMsgErro.Visible = True
                        intContadorExibicaoErro = 0
                        Exit Sub
                    End If

                    dblConstanteCarga = sngValorFloatRespostaByte

                    'Carrega o valor da constante de calibração do usuário
                    txtConst.Text = Math.Round(dblConstanteCarga, 3)

                    'Limpa mensagem
                    lblMsgErro.BackColor = Color.Red
                    lblMsgErro.Visible = False

            End Select

        Catch ex As Exception
            MsgBox("LeituraConstanteUsuario()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraOffsetUsuario(ByVal intInstrumento As Integer)
        Try

            Select Case intInstrumento

                Case LVDT 'Deformação 1
                    strPlaca = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA
                    strValorCanalAD = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL

                    'Carrega Constantes de Calibração do Usuário da EEPROM do Arduino
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_OFFSET_CALIBRACAO_USUARIO, "Leitura")

                    'Se houver erro
                    If usrArduino_AD7192.blnErroLeituraConstantesAD Then
                        lblMsgErro.Text = "Erro na leitura do Offset da Deformação 1"
                        lblMsgErro.Visible = True
                        intContadorExibicaoErro = 0
                        Exit Sub
                    End If

                    lngOffsetLVDT = lngValorLongRespostaByte

                    'Carrega o valor da constante de calibração do usuário
                    txtOffSet.Text = Math.Round(lngOffsetLVDT, 3)

                    'Limpa mensagem
                    lblMsgErro.BackColor = Color.Red
                    lblMsgErro.Visible = False

                Case CARGA 'Carga
                    strPlaca = usrInicializacaoFabricante.CELULACARGA_PLACA
                    strValorCanalAD = usrInicializacaoFabricante.CELULACARGA_CANAL

                    'Carrega Constantes de Calibração do Usuário da EEPROM do Arduino
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_OFFSET_CALIBRACAO_USUARIO, "Leitura")

                    'Se houver erro
                    If usrArduino_AD7192.blnErroLeituraConstantesAD Then
                        lblMsgErro.Text = "Erro na leitura do Offset da Carga"
                        lblMsgErro.Visible = True
                        intContadorExibicaoErro = 0
                        Exit Sub
                    End If

                    lngOffsetCarga = lngValorLongRespostaByte

                    'Carrega o valor da constante de calibração do usuário
                    txtOffSet.Text = Math.Round(lngOffsetCarga, 3)

                    'Limpa mensagem
                    lblMsgErro.BackColor = Color.Red
                    lblMsgErro.Visible = False

            End Select

        Catch ex As Exception
            MsgBox("LeituraOffsetUsuario()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraInstrumento(ByVal intInstrumento As Integer)

        'Try


        '    'Verifica a existência de canais habilitados na placa 0
        '    If blnTemCanalHabilitadoPlaca0 = False Then

        '                Call usrComunicacao.VerificaCanaisHabilitadosPlaca0(spPortaSerial)

        '                'Se houve erro no pedido de verificação dos canais
        '                If blnErroLeituraStatusCanalPlaca0 Then
        '                    lblMsgErro.Visible = True
        '                    lblMsgErro.Text = "Erro de leitura na verificação dos canais da Placa 0 ..."
        '                    Exit Sub
        '                End If

        '                'Se o verificador 'blnCanal0' não ficou verdadeiro, logo não habilitou canal 0
        '                If usrComunicacao.blnCanal0 = False Then
        '                    If intTentativaVerificaCanais < 2 Then
        '                        intTentativaVerificaCanais = intTentativaVerificaCanais + 1
        '                    Else
        '                        lblMsgErro.Visible = True
        '                        lblMsgErro.Text = "O Canal 0 da Placa 0 está desabilitado ..."
        '                        Exit Sub
        '                    End If
        '                End If

        '            End If

        '            'Se o canal 0 está habilitado prossegue com as demais verificações e leitura
        '            If usrComunicacao.blnCanal0 = True Then
        '                'Parametrização para leitura de carga
        '                strPlaca = "0"
        '                strValorCanalAD = "0"

        '                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_STATUS_AD, "Leitura")
        '                If usrArduino_AD7192.blnErroLeituraStatusAD_P0 Then
        '                    lblLeitura.Text = ""
        '                    lblMsgErro.Text = "Falha na comunicação SPI - AD Placa 0 ..."
        '                    lblMsgErro.Visible = True
        '                    Exit Sub
        '                End If

        '                'Comando de leitura de carga
        '                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_AD, "Leitura")

        '                'Resposta para o Controlador/servoconversor
        '                If Not usrArduino_AD7192.blnErroLeituraCarga Then
        '                    dblLeitura = Math.Round(sngValorCargaRespostaByte, 0)
        '                Else
        '                    lblLeitura.Text = ""
        '                    lblMsgErro.Text = "Erro de comunicação com a Carga"
        '                    lblMsgErro.Visible = True
        '                End If
        '            Else
        '                lblLeitura.Text = ""
        '                lblMsgErro.Text = "Canal 0 da Placa 0 está desabilitado ..."
        '                lblMsgErro.Visible = True
        '            End If
        '    End Select

        'Catch ex As Exception
        '    MsgBox("LeituraInstrumento()" & Chr(13) & ex.Message)
        'End Try

    End Sub

    Public Sub VerificaCanaisHabilitados(ByVal intInstrumento As Integer)

        'Try
        '    Select Case intInstrumento

        '        Case 1

        '            'VERIFICA 1 VEZ OS CANAIS QUE ESTÃO HABILITADOS NA PLACA 1
        '            If blnTemCanalHabilitadoPlaca1 = False Then
        '                usrComunicacao.VerificaCanaisHabilitadosPlaca1(spPortaSerial)

        '                'Se houve erro no pedido de verificação dos canais
        '                If blnErroLeituraStatusCanalPlaca1 Then
        '                    lblMsgErro.Visible = True
        '                    lblMsgErro.Text = "Erro de leitura na verificação dos canais da Placa 1 ..."
        '                    lblMsgErro.Visible = True
        '                    Exit Sub
        '                End If

        '                'Se o verificador 'blnCanal4' não ficou verdadeiro, logo não habilitou canal 4
        '                If usrComunicacao.blnCanal4 = False Then
        '                    If intTentativaVerificaCanal4 < 2 Then
        '                        intTentativaVerificaCanal4 = intTentativaVerificaCanal4 + 1
        '                    Else
        '                        lblMsgErro.Visible = True
        '                        lblMsgErro.Text = "O Canal 4 da Placa 1 está desabilitado ..."
        '                        lblMsgErro.Visible = True
        '                        Exit Sub
        '                    End If
        '                End If

        '                'Se o verificador 'blnCanal4' não ficou verdadeiro, logo não habilitou canal 4
        '                If usrComunicacao.blnCanal5 = False Then
        '                    If intTentativaVerificaCanal5 < 2 Then
        '                        intTentativaVerificaCanal5 = intTentativaVerificaCanal5 + 1
        '                    Else
        '                        lblMsgErro.Visible = True
        '                        lblMsgErro.Text = "O Canal 5 da Placa 1 está desabilitado ..."
        '                        lblMsgErro.Visible = True
        '                        Exit Sub
        '                    End If
        '                End If

        '                'CONFERE O STATUS DO AD
        '                strPlaca = "1"
        '                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_STATUS_AD, "Leitura")
        '                If usrArduino_AD7192.blnErroLeituraStatusAD_P1 Then
        '                    lblLeitura.Text = ""
        '                    lblMsgErro.Text = "Falha na comunicação SPI - AD Placa 1 ..."
        '                    lblMsgErro.Visible = True
        '                    Exit Sub
        '                End If

        '            End If

        '        Case 3
        '            'VERIFICA 1 VEZ OS CANAIS QUE ESTÃO HABILITADOS NA PLACA 0
        '            If blnTemCanalHabilitadoPlaca0 = False Then

        '                Call usrComunicacao.VerificaCanaisHabilitadosPlaca0(spPortaSerial)

        '                'Se houve erro no pedido de verificação dos canais
        '                If blnErroLeituraStatusCanalPlaca0 Then
        '                    lblMsgErro.Visible = True
        '                    lblMsgErro.Text = "Erro de leitura na verificação dos canais da Placa 0 ..."
        '                    Exit Sub
        '                End If

        '                'Se o verificador 'blnCanal0' não ficou verdadeiro, logo não habilitou canal 0
        '                If usrComunicacao.blnCanal0 = False Then
        '                    If intTentativaVerificaCanal0 < 2 Then
        '                        intTentativaVerificaCanal0 = intTentativaVerificaCanal0 + 1
        '                    Else
        '                        lblMsgErro.Visible = True
        '                        lblMsgErro.Text = "O Canal 0 da Placa 0 está desabilitado ..."
        '                        Exit Sub
        '                    End If
        '                End If

        '                'CONFERE O STATUS DO AD
        '                'Parametrização para leitura de carga
        '                strPlaca = "0"
        '                strValorCanalAD = "0"
        '                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_STATUS_AD, "Leitura")
        '                If usrArduino_AD7192.blnErroLeituraStatusAD_P0 Then
        '                    lblLeitura.Text = ""
        '                    lblMsgErro.Text = "Falha na comunicação SPI - AD Placa 0 ..."
        '                    lblMsgErro.Visible = True
        '                    Exit Sub
        '                End If

        '            End If

        '    End Select

        'Catch ex As Exception
        '    MsgBox("VerificaCanaisHabilitados()" & Chr(13) & ex.Message)
        'End Try

    End Sub

    Public Sub CalculoSensorAD(ByVal intInstrumento As Integer)
        Dim lngSensorParcial As Long

        Try
            Select Case intInstrumento

                Case LVDT
                    'Calculo aproximado do sensor do AD
                    '(Sensor - Offset) / K = Carga ==> (Carga * K) + Offset = Sensor
                    lngSensorParcial = Math.Round((sngLeituraDeslocamento * dblConstanteLVDT), 0)
                    lblSensor.Text = lngSensorParcial + lngOffsetLVDT
                Case CARGA
                    'Calculo aproximado do sensor do AD
                    '(Sensor - Offset) / K = Carga ==> (Carga * K) + Offset = Sensor
                    lngSensorParcial = Math.Round((sngLeituraCarga * dblConstanteCarga), 0)
                    lblSensor.Text = lngSensorParcial + lngOffsetCarga
            End Select

        Catch ex As Exception
            MsgBox("CalculoSensorAD()" & Chr(13) & ex.Message)
        End Try

    End Sub


    Public Sub VerificaMemoriaEEPROMVazia(ByVal intInstrumento As Integer)
        Try

            'Verificação de Erro ou Memória Vazia
            If intInstrumento = 1 Then
                If (lngOffsetLVDT = 0) And (dblConstanteLVDT = 1) Then
                    lblMsgErro.Visible = True
                    lblMsgErro.BackColor = Color.DarkGreen
                    'Se houver erro
                    lblMsgErro.Text = "A Memória está vazia ou houve um erro de leitura!"
                    intContadorExibicaoErro = 0
                End If
            Else
                If (lngOffsetCarga = 0) And (dblConstanteCarga = 1) Then
                    lblMsgErro.Visible = True
                    lblMsgErro.BackColor = Color.DarkGreen
                    'Se houver erro
                    lblMsgErro.Text = "A Memória está vazia ou houve um erro de leitura!"
                    intContadorExibicaoErro = 0
                End If
            End If

            'Altera o status da variável para não carregar novamente
            blnJaCarregouConstantes = True

        Catch ex As Exception
            MsgBox("VerificaMemoriaEEPROMVazia()" & Chr(13) & ex.Message)
        End Try

    End Sub

#End Region

    Private Sub rdbModoOperacao_Click(sender As Object, e As EventArgs) Handles rdbModoIncremento.Click, rdbModoVelocidadePercentual.Click, rdbModoDeslocamentoPID.Click
        Try

            If rdbModoIncremento.Checked Then
                grpTaxa.Visible = True
                grpTaxa.Text = "(kgf/s)"

                lblVeloc_1.Text = "kgf"
                lblVeloc_2.Text = "kgf"
                lblVeloc_2.Text = "kgf"
                lblVeloc_3.Text = "kgf"
                lblVeloc_4.Text = "kgf"
                lblVeloc_5.Text = "kgf"

                txtVeloc_1.Text = "5000"
                txtVeloc_2.Text = "1000"
                txtVeloc_3.Text = "500"
                txtVeloc_4.Text = "100"
                txtVeloc_5.Text = "50"

            ElseIf rdbModoVelocidadePercentual.Checked Then

                lblVeloc_1.Text = "%"
                lblVeloc_2.Text = "%"
                lblVeloc_2.Text = "%"
                lblVeloc_3.Text = "%"
                lblVeloc_4.Text = "%"
                lblVeloc_5.Text = "%"

                txtVeloc_1.Text = "100"
                txtVeloc_2.Text = "70"
                txtVeloc_3.Text = "30"
                txtVeloc_4.Text = "10"
                txtVeloc_5.Text = "0.83"

                grpTaxa.Visible = False

            Else

                grpTaxa.Visible = True
                grpTaxa.Text = "(mm/min)"

                lblVeloc_1.Text = "mm"
                lblVeloc_2.Text = "mm"
                lblVeloc_2.Text = "mm"
                lblVeloc_3.Text = "mm"
                lblVeloc_4.Text = "mm"
                lblVeloc_5.Text = "mm"

                txtVeloc_1.Text = "50"
                txtVeloc_2.Text = "10"
                txtVeloc_3.Text = "1"
                txtVeloc_4.Text = "0.5"
                txtVeloc_5.Text = "0.1"

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("rdbModoOperacao_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub rdbModoOperacao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbModoIncremento.CheckedChanged, rdbModoVelocidadePercentual.CheckedChanged, rdbModoDeslocamentoPID.CheckedChanged
        Try

            If spPortaSerial.IsOpen Then


                'SE MUDOU DE MODO DE OPERAÇÃO PARA O MOTOR PREVENTIVAMENTE E ZERA OS VALORES
                dblVelocidade = 0
                strVelocidadeMotor = "0"

                'Desativa momentâneamente os timers
                tmrCalibracao.Enabled = False
                tmrLimparErros.Enabled = False

                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_PARAR_MOTOR, "Escrita")
                Call ValidaComandoEscrita()

                If rdbModoVelocidadePercentual.Checked Then
                    btnVeloc_1.Text = "1ª Velocidade"
                    btnVeloc_2.Text = "2ª Velocidade"
                    btnVeloc_3.Text = "3ª Velocidade"
                    btnVeloc_4.Text = "4ª Velocidade"
                    btnVeloc_5.Text = "5ª Velocidade"

                ElseIf rdbModoIncremento.Checked Then
                    btnVeloc_1.Text = "1ª Destino"
                    btnVeloc_2.Text = "2ª Destino"
                    btnVeloc_3.Text = "3ª Destino"
                    btnVeloc_4.Text = "4ª Destino"
                    btnVeloc_5.Text = "5ª Destino"
                Else
                    btnVeloc_1.Text = "1ª Posição"
                    btnVeloc_2.Text = "2ª Posição"
                    btnVeloc_3.Text = "3ª Posição"
                    btnVeloc_4.Text = "4ª Posição"
                    btnVeloc_5.Text = "5ª Posição"
                End If

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("rdbModoOperacao_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Volta a ligar timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try
    End Sub

    Private Sub rdbCarga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCarga.CheckedChanged
        Try
            Call SelecionarInstrumento(CARGA)

            'Volta o status
            blnJaCarregouConstantes = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("rdbCarga_CheckedChanged" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub rdbDeformacao1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDeslocamento.CheckedChanged
        Try
            Call SelecionarInstrumento(LVDT)

            'Volta o status
            blnJaCarregouConstantes = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("rdbDeformacao1_CheckedChanged" & Chr(13) & ex.Message)

        End Try
    End Sub

    Public Sub SelecionarInstrumento(ByVal intID As Integer)

        Try

            If rdbCarga.Checked Then
                intInstrumento = CARGA
                strPlaca = "0"
                strValorCanalAD = "0"
                lblLegendaLeitura.Text = "Leitura (kgf)"
                'HabilitarInstrumentos(True, False, False)
            End If

            If rdbDeslocamento.Checked Then
                intInstrumento = LVDT
                strPlaca = "1"
                strValorCanalAD = "4"
                lblLegendaLeitura.Text = "Leitura (mm)"
                'HabilitarInstrumentos(False, True, False)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("SelecionarInstrumento" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub Velocidade_Movimento(ByRef txtVelocidade As TextBox)

        Try
            txtVeloc_1.BackColor = Color.LightGoldenrodYellow
            txtVeloc_2.BackColor = Color.LightGoldenrodYellow
            txtVeloc_3.BackColor = Color.LightGoldenrodYellow
            txtVeloc_4.BackColor = Color.LightGoldenrodYellow
            txtVeloc_5.BackColor = Color.LightGoldenrodYellow

            If txtVelocidade.Text <> "" And IsNumeric(txtVelocidade.Text) And (txtVelocidade.Text >= 0.17) And (txtVelocidade.Text <= 6000) Then

                '--------------------------------------------------------------------------------------------------------
                'rotação máxima do motor 6000 equivale a 60 Hz e equivale a 100% em percentual
                'rotação mínima para partida do motor 50 equivale a 0,5 Hz e equivale 0,83% em percentual
                'rotação mínima aceita depois da partida do motor 1 equivale a 0,01 Hz e equivale a 0.17% em percentual
                '--------------------------------------------------------------------------------------------------------

                If (intUltimoMovimento = COMANDO_PARAR) And (txtVelocidade.Text < 0.83) Then
                    'Se a velocidade inserida não for suficiente para armar a placa de frequência (60 bits), terei que JOGAR MOMENTANEAMENTE 60 bits E DEPOIS REDUZIR A VELOCIDADE PARA UM VALOR MENOR REQUERIDO
                    blnEnviarVelocidadeTemporaria = True
                End If

                dblVelocidade = dblVelocMaxima * (CDbl(txtVelocidade.Text) / 100)

                'Arredonda valor da velocidade para uma casa decimal
                dblVelocidadeCalibracao = Math.Round(dblVelocidade, 0)

                If blnComandoSubir Or blnComandoDescer Then
                    Call ComandoEnviaVelocidade()
                End If

                'Comando selecionado
                txtVelocidade.BackColor = Color.Yellow

                'Recebe o tipo de movimentação

                intUltimoMovimento = intMovimento

            Else
                MsgBox("A velocidade deve ser maior do que 0% e menor ou igual a 100%", MsgBoxStyle.Information, "Velocidade")
            End If

        Catch ex As Exception
            'Mensagem e erro
            MsgBox("Velocidade_Movimento" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub AlterarDestinoDeslocamento(ByRef txtVelocidade As TextBox)
        Dim dblDestinoDeslocamento As Double

        Try

            txtVeloc_1.BackColor = Color.LightGoldenrodYellow
            txtVeloc_2.BackColor = Color.LightGoldenrodYellow
            txtVeloc_3.BackColor = Color.LightGoldenrodYellow
            txtVeloc_4.BackColor = Color.LightGoldenrodYellow
            txtVeloc_5.BackColor = Color.LightGoldenrodYellow

            If txtVelocidade.Text <> "" And IsNumeric(txtVelocidade.Text) And (txtVelocidade.Text > 0) And (txtVelocidade.Text <= 5050) Then

                dblDestinoDeslocamento = txtVelocidade.Text

                'Arredonda valor da velocidade para uma casa decimal
                dblDestinoDeslocamento = Math.Round(dblDestinoDeslocamento, 0)

                strValorDestinoDeslocamento = FormatarPontoDecimal(dblDestinoDeslocamento)

                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESTINO_DESLOCAMENTO, "Escrita")
                Call ValidaComandoEscrita()

                System.Threading.Thread.Sleep(30)

                'Se a prensa já estiver em movimento atualiza o controle
                If blnSubindoPrensa Or blnDescendoPrensa Then
                    'Envia comando ao controlador
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_DESLOCAMENTO, "Escrita")
                    Call ValidaComandoEscrita()
                End If

                'Comando selecionado
                txtVelocidade.BackColor = Color.Yellow

                'Recebe o tipo de movimentação
                intUltimoMovimento = intMovimento

            Else
                MsgBox("O destino de deslocamento deve ser maior do que 0 e menor ou igual a 50 mm", MsgBoxStyle.Information, "Destino")
            End If

        Catch ex As Exception
            'Mensagem e erro
            MsgBox("AlterarDestinoDeslocamento" & Chr(13) & ex.Message)
        End Try

    End Sub


    Private Sub CargaDeDestino(ByRef txtVelocidade As TextBox)

        Dim dblDestinoCarga As Double

        Try
            txtVeloc_1.BackColor = Color.LightGoldenrodYellow
            txtVeloc_2.BackColor = Color.LightGoldenrodYellow
            txtVeloc_3.BackColor = Color.LightGoldenrodYellow
            txtVeloc_4.BackColor = Color.LightGoldenrodYellow
            txtVeloc_5.BackColor = Color.LightGoldenrodYellow

            If txtVelocidade.Text <> "" And IsNumeric(txtVelocidade.Text) And (txtVelocidade.Text > 0) And (txtVelocidade.Text <= 5050) Then

                dblDestinoCarga = txtVelocidade.Text

                'Arredonda valor da velocidade para uma casa decimal
                dblDestinoCarga = Math.Round(dblDestinoCarga, 0)

                strValorDestinoCarga = FormatarPontoDecimal(dblDestinoCarga)

                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESTINO_CARGA, "Escrita")
                Call ValidaComandoEscrita()

                'Comando selecionado
                txtVelocidade.BackColor = Color.Yellow

                'Recebe o tipo de movimentação
                intUltimoMovimento = intMovimento

            Else
                MsgBox("A velocidade deve ser maior do que 0 e menor ou igual a 5000", MsgBoxStyle.Information, "Velocidade")
            End If

        Catch ex As Exception
            'Mensagem e erro
            MsgBox("CargaDeDestino" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub ComandoEnviaVelocidade()

        '--------------------------------------------------------------------------------------------------------
        'rotação máxima do motor 6000 equivale a 60 Hz e equivale a 100% em percentual
        'rotação mínima para partida do motor 50 equivale a 0,5 Hz e equivale 0,83% em percentual
        'rotação mínima aceita depois da partida do motor 1 equivale a 0,01 Hz e equivale a 0.17% em percentual
        '--------------------------------------------------------------------------------------------------------

        Dim dblVelocidadeTratada As Double

        Try

            If blnEnviarVelocidadeTemporaria Then

                'Reset variável da velocidade temporária no próximo scan
                blnEnviarVelocidadeTemporaria = False

                dblVelocidadeTratada = 50

                strVelocidadeMotor = FormatarPontoDecimal(dblVelocidadeTratada)

                'Desativa momentâneamente os timers
                tmrCalibracao.Enabled = False
                tmrLimparErros.Enabled = False

                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_VELOCIDADE_MOTOR, "Escrita")
                Call ValidaComandoEscrita()

                'Aguarda um tempo para ocorrer a transição entre armar a placa e reduzir a velocidade
                System.Threading.Thread.Sleep(50)

                'Recebe novamente o valor inserido pelo usuário
                dblVelocidadeTratada = CInt(dblVelocidadeCalibracao)
            End If

            'A placa já estando armada, envia a velocidade de acordo com sentido de rotação
            If intMovimento = COMANDO_INCREMENTAR Then '[SUBIR]
                dblVelocidadeTratada = Math.Abs(dblVelocidadeCalibracao)
            ElseIf intMovimento = COMANDO_DECREMENTAR Then
                'Garante primeiro que o valor de 'svel' inicialmente está positivo 
                dblVelocidadeTratada = Math.Abs(dblVelocidadeCalibracao)
                'Transforma o valor de 'svel' em negativo
                dblVelocidadeTratada = -(dblVelocidadeTratada)
            ElseIf intMovimento = COMANDO_PARAR Then
                dblVelocidadeTratada = 0
            Else
                Exit Sub
            End If

            strVelocidadeMotor = FormatarPontoDecimal(dblVelocidadeTratada)

            'Envia comando ao controlador
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_VELOCIDADE_MOTOR, "Escrita")
            Call ValidaComandoEscrita()

        Catch ex As Exception
            MsgBox("ComandoEnviaVelocidade()" & Chr(13) & ex.Message)
            Exit Sub
        Finally
            'Volta a ligar os timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try
    End Sub

    Private Sub txtOffSet_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOffSet.GotFocus
        'Selecionar o texto ao receber o foco
        Call usrDiversos.SelecionarFoco(txtOffSet)
    End Sub

    Private Sub txtOffSet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOffSet.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtOffSet, AscW(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtOffSet_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOffSet.TextChanged
        blnJaSalvou = False
        btnSalvarCalibracao.Enabled = True
    End Sub

    Private Sub txtConst_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConst.GotFocus
        'Selecionar o texto ao receber o foco
        Call usrDiversos.SelecionarFoco(txtConst)
    End Sub

    Private Sub txtConst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConst.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtConst, AscW(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtConst_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConst.TextChanged
        blnJaSalvou = False
        btnSalvarCalibracao.Enabled = True
    End Sub

    Private Sub txtVelocidade_Taxa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVeloc_1.KeyPress, txtVeloc_2.KeyPress, txtVeloc_3.KeyPress, txtVeloc_4.KeyPress, txtVeloc_5.KeyPress, txtTaxa.KeyPress
        'Válidar valores numéricos
        e.KeyChar = usrDiversos.ValorNumerico(sender, e.KeyChar, True, True, False)
    End Sub

    Private Sub btnOffSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOffSet.Click
        Try

            'Pega o canal selecionado para zerar
            Select Case intInstrumento
                Case 1
                    strPlaca = 1
                    strValorCanalAD = 4
                Case 3
                    strPlaca = 0
                    strValorCanalAD = 0
            End Select

            'Desativa momentâneamente os timers
            tmrCalibracao.Enabled = False
            tmrLimparErros.Enabled = False

            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TARE_INSTRUMENTO, "Escrita")

            blnJaCarregouConstantes = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("cmdOffSet_Click" & Chr(13) & ex.Message)
        Finally
            'Volta a ligar timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try
    End Sub

    Private Sub rdbRemoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRemoto.Click
        Try

            blnComandoRemoto = True

            grpGroupSelecionado.Enabled = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("rdbRemoto_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub rdbLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbLocal.Click
        Try

            blnComandoLocal = True

            grpGroupSelecionado.Enabled = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("rdbLocal_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnVeloc_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeloc_1.Click
        Try
            If rdbModoVelocidadePercentual.Checked Then
                'Alterar a velocidade
                Call Velocidade_Movimento(txtVeloc_1)
            ElseIf rdbModoIncremento.Checked Then
                Call CargaDeDestino(txtVeloc_1)
            Else
                Call AlterarDestinoDeslocamento(txtVeloc_1)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnVeloc_1_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub btnVeloc_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeloc_2.Click
        Try

            If rdbModoVelocidadePercentual.Checked Then
                'Alterar a velocidade
                Call Velocidade_Movimento(txtVeloc_2)
            ElseIf rdbModoIncremento.Checked Then
                Call CargaDeDestino(txtVeloc_2)
            Else
                Call AlterarDestinoDeslocamento(txtVeloc_2)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnVeloc_2_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub btnVeloc_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeloc_3.Click
        Try
            If rdbModoVelocidadePercentual.Checked Then
                'Alterar a velocidade
                Call Velocidade_Movimento(txtVeloc_3)
            ElseIf rdbModoIncremento.Checked Then
                Call CargaDeDestino(txtVeloc_3)
            Else
                Call AlterarDestinoDeslocamento(txtVeloc_3)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnVeloc_3_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub btnVeloc_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeloc_4.Click
        Try

            If rdbModoVelocidadePercentual.Checked Then
                'Alterar a velocidade
                Call Velocidade_Movimento(txtVeloc_4)
            ElseIf rdbModoIncremento.Checked Then
                Call CargaDeDestino(txtVeloc_4)
            Else
                Call AlterarDestinoDeslocamento(txtVeloc_4)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnVeloc_4_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub btnVeloc_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeloc_5.Click
        Try

            If rdbModoVelocidadePercentual.Checked Then
                'Alterar a velocidade
                Call Velocidade_Movimento(txtVeloc_5)
            ElseIf rdbModoIncremento.Checked Then
                Call CargaDeDestino(txtVeloc_5)
            Else
                Call AlterarDestinoDeslocamento(txtVeloc_5)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnVeloc_5_Click" & Chr(13) & ex.Message)

        End Try
    End Sub


    Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click
        Try

            If rdbModoVelocidadePercentual.Checked Then
                intMovimento = COMANDO_INCREMENTAR
                Call ComandoEnviaVelocidade()
            ElseIf rdbModoDeslocamentoPID.Checked Then
                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_DESLOCAMENTO, "Escrita")
                Call ValidaComandoEscrita()
            Else

                'Analisa comando anterior
                If blnComandoDescer Then Call ComandoPararMotor()

                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_CARGA, "Escrita")
                Call ValidaComandoEscrita()
            End If

            blnComandoSubir = True
            blnComandoDescer = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnSubir_Click" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub btnParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParar.Click
        Try

            Call ComandoPararMotor()

            blnComandoSubir = False
            blnComandoDescer = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnParar_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnDescer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescer.Click
        Try

            If rdbModoVelocidadePercentual.Checked Then
                intMovimento = COMANDO_DECREMENTAR
                Call ComandoEnviaVelocidade()
            ElseIf rdbModoDeslocamentoPID.Checked Then
                'Destino 0 para descer
                strValorDestinoDeslocamento = "0"
                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESTINO_DESLOCAMENTO, "Escrita")
                Call ValidaComandoEscrita()

                System.Threading.Thread.Sleep(50)

                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_DESLOCAMENTO, "Escrita")
                Call ValidaComandoEscrita()
            Else

                'Analisa comando anterior
                If blnComandoSubir Then Call ComandoPararMotor()

                strValorDestinoCarga = "0"
                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESTINO_CARGA, "Escrita")
                Call ValidaComandoEscrita()
                System.Threading.Thread.Sleep(50)
                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_CARGA, "Escrita")
                Call ValidaComandoEscrita()
            End If

            blnComandoDescer = True
            blnComandoSubir = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnDescer_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnEnviarTaxa_Click(sender As Object, e As EventArgs) Handles btnEnviarTaxa.Click

        Dim dblTaxa As Double

        Try

            'Desativa momentâneamente os timers
            tmrCalibracao.Enabled = False
            tmrLimparErros.Enabled = False

            dblTaxa = txtTaxa.Text

            If rdbModoIncremento.Checked Then
                strValorTaxaCarga = FormatarPontoDecimal(dblTaxa)
                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TAXA_CARGA, "Escrita")
                Call ValidaComandoEscrita()
            ElseIf rdbModoDeslocamentoPID.Checked Then
                strValorTaxaDeslocamento = FormatarPontoDecimal(dblTaxa)
                'Envia comando ao controlador
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TAXA_DESLOCAMENTO, "Escrita")
                Call ValidaComandoEscrita()
            End If

            'Comando selecionado
            txtTaxa.BackColor = Color.Yellow

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnEnviarTaxa_Click" & Chr(13) & ex.Message)
        Finally
            'Volta a ligar timers
            tmrCalibracao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try


    End Sub

    Private Sub grbAjusteCalibracao_Enter(sender As Object, e As EventArgs) Handles grbAjusteCalibracao.Enter

    End Sub
End Class