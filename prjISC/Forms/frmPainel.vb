Option Explicit On

Public Class frmPainel
    '****** Leitura de Carga e de Deslocamento *******

#Region "DECLARAÇÃO DE VARIÁVEIS"

    Dim dblCarga As Double
    Dim dblLVDT As Double

    Dim blnTara As Boolean
    'Zerar CARGA
    Dim blnZerarCarga As Boolean
    'Zerar LVDT
    Dim blnZerarLVDT As Boolean

    Dim blnPrimeiroScan As Boolean

    Dim strCanaisHabilitadosAD0, strCanaisHabilitadosAD1 As String

    Dim strCanaisHabAD(3) As String
    Dim intPlacasLidasComSucesso() As Integer
    Dim blnDbOffSucesso, blnReadingOffSucesso, blnLeuPlacasInicializadasComSucesso, blnVerificouCanaisHabilitadosComSucesso, blnLeuConstantesPIDComSucesso, blnComandosPreliminaresComSucesso As Boolean
    Dim intRetornoLeituraAD As Integer

#End Region

#Region "CARREGAR E DESCARREGAR FORMULÁRIO"

    '********************************************************************
    '*************** APRESENTANDO E CARREGANDO O FORM *******************

    Private Sub frmPainel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Carrega os dados iniciais

        Try

            'Form Ativo
            strFrmAtivo = "Painel"
            intID_Tela_Comunicacao = 2

            'Setar objeto de comunicação serial
            usrPortaSerial = New clsPortaSerial
            usrArduino_AD7192 = New clsArduino_AD7192
            usrComunicacao = New clsComunicacao

            'Se não houver LVDT
            If usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "False" Then
                chkSelecaoDeformacao.Enabled = False
                pctZerarDeformacao.Enabled = False
            End If

            Call usrPortaSerial.Abrir_Porta_Comunicacao(spPortaSerial)
            If strErro_Porta_Comunicacao <> "" Or (spPortaSerial.IsOpen = False) Then Exit Sub

            'Barra de Progresso - 3 segundos
            barStatus.Enabled = True
            barStatus.Visible = True
            Call usrPortaSerial.Barra_de_Progresso(barStatus)

            grpPainel.Enabled = True

            tmrComunicacao.Interval = 500
            tmrComunicacao.Enabled = True
            blnComunicacao = True

            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, pois o ciclo de scan do â€˜timerâ€™ pode nÃ£o ter terminado ainda e surgir mais de um msgbox de alerta.
            blnJaFechouPorta = False

        Catch ex As Exception
            MsgBox("frmPainel_Load()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub frmPainel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try

            tmrComunicacao.Enabled = False
            blnComunicacao = False

            If spPortaSerial.IsOpen Then
                'Fechar porta serial 
                Call usrPortaSerial.FecharPorta(spPortaSerial)
            End If

            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, pois o ciclo de scan do â€˜timerâ€™ pode nÃ£o ter terminado ainda e surgir mais de um msgbox de alerta.
            blnJaFechouPorta = True

            'Limpa o Status para o próximo teste
            blnTemCanalHabilitadoPlaca0 = False
            blnTemCanalHabilitadoPlaca1 = False

        Catch ex As Exception
            MsgBox("frmPainel_FormClosed()" & Chr(13) & ex.Message)
        End Try
    End Sub

#End Region

    '********************************************************************
    '*************** COMANDOS DE EXECUÇÃO DO FORM ***********************

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        'Sair da tela de calibração
        Try

            Me.Close()

        Catch ex As Exception
            MsgBox("btnSair_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    '********************************************************************
    '********************* TIMER DE COMUNICAÇÃO COM OS CANAIS ***********
    Private Sub tmrComunicacao_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrComunicacao.Tick

        Try

            'Condição para finalização comunicação em caso de falha na porta
            If Not blnComunicacao Then Exit Sub

            'Piscar lâmpada
            Call PiscarInformações()

            Call ComandosPreliminares()

            'TARA DOS INSTRUMENTOS
            If blnTara = True Then
                'Verificar zerar dos instrumentos
                Call TaraInstrumentos()
                Exit Sub
            End If

            If (chkSelecaoCarga.Checked = True) Or (chkSelecaoDeformacao.Checked = True) Then
                'Realizar leituras
                Call LeituraDeTudo()
            End If

            If (chkSelecaoCarga.Checked = False) And (chkSelecaoDeformacao.Checked = False) Then lblMsgErro.Visible = False

        Catch ex As Exception
            MsgBox("tmrComunicacao_Tick()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub LeituraDeTudo()
        Try
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_MULTIPLAS_RESPOSTAS, "Leitura")

            'Condição de validação
            If Not usrArduino_AD7192.blnErroRespostasMultiplas Then
                Call ApresentarLeituras()
            Else
                lblMsgErro.Text = "Erro de comunicação nas leituras dos instrumentos e sensores ('rall')"
                lblMsgErro.Visible = True
            End If

        Catch ex As Exception
            MsgBox("LeituraDeTudo()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub ApresentarLeituras()
        Try

            'Leitura Calibrada
            If chkSelecaoCarga.Checked Then
                lblCarga.Text = FormatNumber(sngLeituraCarga, 1)
            Else
                lblCarga.Text = ""
            End If

            If chkSelecaoDeformacao.Checked Then

                lblLVDT.Text = FormatNumber(sngLeituraDeslocamento, 3)
            Else
                lblLVDT.Text = ""
            End If

        Catch ex As Exception
            MsgBox("ApresentarLeituras()" & Chr(13) & ex.Message)
        End Try
    End Sub

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


    Private Sub TaraInstrumentos()

        Try

            'Enquanto escreve o comando desabilito o timer
            tmrComunicacao.Enabled = False

            'Reinicia a condição de tara geral
            blnTara = False

            If blnZerarCarga Then
                'Reinicia condição
                blnZerarCarga = False
                'Define placa e canal
                strPlaca = usrInicializacaoFabricante.CELULACARGA_PLACA
                strValorCanalAD = usrInicializacaoFabricante.CELULACARGA_CANAL
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TARE_INSTRUMENTO, "Escrita")
                Call ValidaComandoEscrita()
            End If

            If blnZerarLVDT Then
                'Reinicia condição
                blnZerarLVDT = False
                'Define placa e canal
                strPlaca = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA
                strValorCanalAD = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TARE_INSTRUMENTO, "Escrita")
                Call ValidaComandoEscrita()
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("TaraInstrumentos" & Chr(13) & ex.Message)
        Finally
            tmrComunicacao.Enabled = True
        End Try
    End Sub

    '********************************************************************
    '********************* FUNÇÕES E PROCEDIMENTOS **********************

    Private Sub PiscarInformações()
        Try
            'Pisca
            If pctLeituraSim.Visible Then
                pctLeituraSim.Visible = False
                pctLeituraNao.Visible = True
            Else
                pctLeituraNao.Visible = False
                pctLeituraSim.Visible = True
            End If

        Catch ex As Exception
            MsgBox("PiscarInformações()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub FormatarLeitura(ByVal intLeitura As Integer)
        Try

            Select Case intLeitura

                Case CARGA : lblCarga.Text = FormatNumber(dblCarga, 0)  'Carga
                Case LVDT : lblLVDT.Text = FormatNumber(dblLVDT, 3)    'LVDT

            End Select

        Catch ex As Exception
            MsgBox("FormatarLeitura()" & Chr(13) & ex.Message)
        End Try

    End Sub

    '********************************************************************
    '********************* ZERAR OS LEITORES SELECIONADOS ***************

#Region "AÇÕES DOS BOTÕES"

    Private Sub chkSelecaoCarga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelecaoCarga.CheckedChanged
        Try

            If chkSelecaoCarga.Checked = True Then
                pctZerarCarga.Enabled = True
            Else
                lblMsgErro.Text = ""
                lblMsgErro.Visible = False
            End If

        Catch ex As Exception
            MsgBox("chkSelecaoCarga_CheckedChanged()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub chkSelecaoDeformacao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelecaoDeformacao.CheckedChanged

        Try

            If chkSelecaoDeformacao.Checked = True Then
                pctZerarDeformacao.Enabled = True
            Else
                lblMsgErro.Text = ""
                lblMsgErro.Visible = False
            End If

        Catch ex As Exception
            MsgBox("chkSelecaoDeformacao_CheckedChanged()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub pctZerarCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctZerarCarga.Click
        Try

            blnTara = True
            blnZerarCarga = True

        Catch ex As Exception
            MsgBox("pctZerarCarga_Click()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub grpPainel_Enter(sender As Object, e As EventArgs) Handles grpPainel.Enter

    End Sub

    Private Sub pctZerarDeformacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctZerarDeformacao.Click
        Try

            blnTara = True
            blnZerarLVDT = True

        Catch ex As Exception
            MsgBox("pctZerarDeformacao_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

#End Region

End Class