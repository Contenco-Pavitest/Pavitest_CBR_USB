Option Strict Off
Option Explicit On

Public Class frmFabricante_Configuracoes

    'Recebe o valor proveniente do arquivo INI
    Private usrComunicacao As clsComunicacao = New clsComunicacao
    Dim strTexto As String
    Dim strDispostivos As String
    Dim intContErro As Integer
    Dim intContErro2 As Integer
    Dim strRespostaAnterior As String
    Public blnDescartaProxima As Boolean
    Dim intContadorExibicaoErro As Integer


    Private Sub frmAjustesFabricante_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            usrArduino_AD7192 = New clsArduino_AD7192
            usrComunicacao = New clsComunicacao
            usrPortaSerial = New clsPortaSerial

            'Desabilitar os comandos
            usrLayout.HabilitarComandos(False)

            'Seleciona o item inicial dos comboboxes
            cboNumeroPlaca.SelectedIndex = 0

            Call AtualizaCamposArquivoIni()

            'Recebe a placa que será verificada
            strPlaca = cboNumeroPlaca.SelectedItem

        Catch ex As Exception
            'Mesangem de erro
            MsgBox("frmAjustesFabricante_Load" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub frmFabricante_Configuracoes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try

            If spPortaSerial.IsOpen Then
                spPortaSerial.Close()
            End If

        Catch ex As Exception
            'Mesangem de erro
            MsgBox("frmFabricante_Configuracoes_FormClosed" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub AtualizaCamposArquivoIni()
        Try
            cboPlacaCelulaCarga.Text = usrInicializacaoFabricante.CELULACARGA_PLACA
            cboCanalCelulaCarga.Text = usrInicializacaoFabricante.CELULACARGA_CANAL
            cboPlacaDeformacao.Text = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA
            cboCanalDeformacao.Text = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL

            If usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "True" Then
                chkHabilitaDeslocamento.Checked = True
            Else
                chkHabilitaDeslocamento.Checked = False
            End If

            If usrInicializacaoFabricante.HABILITACAO_CARGA = "True" Then
                chkHabilitaCarga.Checked = True
            Else
                chkHabilitaCarga.Checked = False
            End If

            If usrInicializacaoFabricante.HABILITACAO_DADOS_PID = "True" Then
                chkHabilitacaoLeiturasPID.Checked = True
            Else
                chkHabilitacaoLeiturasPID.Checked = False
            End If

        Catch ex As Exception
            'Mesangem de erro
            MsgBox("AtualizaCamposArquivoIni()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub CarregarCanaisAD()
        Dim strCanalHabilitado As String = ""

        Try

            If strPlaca <> "" Or strPlaca <> Nothing Then
                'Ler status dos Canais
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_CANAIS_HABILITADOS_AD, "Leitura")
            Else
                Exit Sub
            End If

            'Condição de validação
            If Not usrArduino_AD7192.blnErroRespostaByteUnico Then

                strCanalHabilitado = usrComunicacao.Transformar_Bit_Canais_Habilitados(intValorByteUnico)

                If strCanalHabilitado.Contains("0") Then
                    pctCH0cz.Visible = False
                    chk_Canal0.Checked = True
                Else
                    pctCH0cz.Visible = True
                    chk_Canal0.Checked = False
                End If

                If strCanalHabilitado.Contains("1") Then
                    pctCH1cz.Visible = False
                    chk_Canal1.Checked = True
                Else
                    pctCH1cz.Visible = True
                    chk_Canal1.Checked = False
                End If

                If strCanalHabilitado.Contains("2") Then
                    pctCH2cz.Visible = False
                    chk_Canal2.Checked = True
                Else
                    pctCH2cz.Visible = True
                    chk_Canal2.Checked = False
                End If

                If strCanalHabilitado.Contains("3") Then
                    pctCH3cz.Visible = False
                    chk_Canal3.Checked = True
                Else
                    pctCH3cz.Visible = True
                    chk_Canal3.Checked = False
                End If

                If strCanalHabilitado.Contains("4") Then
                    pctCH4cz.Visible = False
                    chk_Canal4.Checked = True
                Else
                    pctCH4cz.Visible = True
                    chk_Canal4.Checked = False
                End If

                If strCanalHabilitado.Contains("5") Then
                    pctCH5cz.Visible = False
                    chk_Canal5.Checked = True
                Else
                    pctCH5cz.Visible = True
                    chk_Canal5.Checked = False
                End If

                If strCanalHabilitado.Contains("6") Then
                    pctCH6cz.Visible = False
                    chk_Canal6.Checked = True
                Else
                    pctCH6cz.Visible = True
                    chk_Canal6.Checked = False
                End If

                If strCanalHabilitado.Contains("7") Then
                    pctCH7cz.Visible = False
                    chk_Canal7.Checked = True
                Else
                    pctCH7cz.Visible = True
                    chk_Canal7.Checked = False
                End If
            Else
                lblMsgErro.Text = "Erro de comunicação com a leitura dos canais"
                lblMsgErro.Visible = True
                chk_Canal0.Checked = False : chk_Canal1.Checked = False : chk_Canal2.Checked = False : chk_Canal3.Checked = False : chk_Canal4.Checked = False : chk_Canal5.Checked = False : chk_Canal6.Checked = False : chk_Canal7.Checked = False
                pctCH0cz.Visible = True : pctCH1cz.Visible = True : pctCH2cz.Visible = True : pctCH3cz.Visible = True : pctCH4cz.Visible = True : pctCH5cz.Visible = True : pctCH6cz.Visible = True : pctCH7cz.Visible = True

            End If




        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarCanaisAD" & Chr(13) & ex.Message)
        End Try

    End Sub


    Private Sub chk_Canal0_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal0.CheckedChanged

        Try

            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 0


            If chk_Canal0.Checked = True Then

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")

            Else

                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal0_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Private Sub chk_Canal1_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal1.CheckedChanged

        Try

            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 1

            If chk_Canal1.Checked = True Then
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")
            Else
                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal1_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Private Sub chk_Canal2_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal2.CheckedChanged

        Try
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 2

            If chk_Canal2.Checked = True Then
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")
            Else
                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal2_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Private Sub chk_Canal3_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal3.CheckedChanged

        Try

            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 3

            If chk_Canal3.Checked = True Then
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")
            Else
                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal3_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Private Sub chk_Canal4_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal4.CheckedChanged

        Try

            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 4

            If chk_Canal3.Checked = True Then
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")
            Else
                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal4_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Private Sub chk_Canal5_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal5.CheckedChanged

        Try

            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 5

            If chk_Canal3.Checked = True Then
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")
            Else
                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal5_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Private Sub chk_Canal6_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal6.CheckedChanged

        Try

            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 6

            If chk_Canal3.Checked = True Then
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")
            Else
                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal6_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try

    End Sub

    Private Sub chk_Canal7_CheckedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Canal7.CheckedChanged

        Try

            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = False
            tmrLimparErros.Enabled = False

            strPlaca = cboNumeroPlaca.SelectedItem
            strValorCanalAD = 7

            If chk_Canal3.Checked = True Then
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_HABILITA_CANAL_AD, "Escrita")
            Else
                'Dasabilita Canal
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESABILITA_CANAL_AD, "Escrita")
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chk_Canal7_CheckedChanged" & Chr(13) & ex.Message)
        Finally
            'Desativa momentâneamente os timers
            tmrComunicacao.Enabled = True
            tmrLimparErros.Enabled = True
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try

            usrInicializacaoFabricante.CELULACARGA_PLACA = cboPlacaCelulaCarga.Text
            usrInicializacaoFabricante.CELULACARGA_CANAL = cboCanalCelulaCarga.Text

            usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA = cboPlacaDeformacao.Text
            usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL = cboCanalDeformacao.Text

            If chkHabilitaCarga.Checked Then
                usrInicializacaoFabricante.HABILITACAO_CARGA = "True"
            Else
                usrInicializacaoFabricante.HABILITACAO_CARGA = "False"
            End If

            If chkHabilitaDeslocamento.Checked Then
                usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "True"
            Else
                usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "False"
            End If

            If chkHabilitacaoLeiturasPID.Checked Then
                usrInicializacaoFabricante.HABILITACAO_DADOS_PID = "True"
            Else
                usrInicializacaoFabricante.HABILITACAO_DADOS_PID = "False"
            End If

            Call usrInicializacaoFabricante.AtualizarDisco()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)
        Finally
            'Fecha a janela
            Me.Close()
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            'Habilitar comandos
            usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        Finally
            'Fecha a janela
            Me.Close()
        End Try
    End Sub

    Private Sub btnConectar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConectar.Click
        Try

            If btnConectar.Text = "Conectar" Then

                'Abrir a porta de comunicação serial
                Call usrPortaSerial.Abrir_Porta_Comunicacao(spPortaSerial)
                If strErro_Porta_Comunicacao <> "" Or (spPortaSerial.IsOpen = False) Then Exit Sub

                barStatus.Enabled = True
                barStatus.Visible = True
                Call Barra_de_Progresso()

                btnConectar.Text = "Desconectar"
                grpAjustesFabricante.Enabled = True

                tmrComunicacao.Enabled = True
                tmrLimparErros.Enabled = True

            Else

                btnConectar.Text = "Conectar"
                grpAjustesFabricante.Enabled = False
                tmrComunicacao.Enabled = False
                tmrLimparErros.Enabled = False

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnConectar_Click" & Chr(13) & ex.Message)
        End Try

    End Sub


    Private Sub cboNumeroPlaca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumeroPlaca.SelectedIndexChanged
        Try

            If spPortaSerial.IsOpen Then

                strPlaca = cboNumeroPlaca.SelectedItem

                Call CarregarCanaisAD()

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("cboNumeroPlaca_SelectedIndexChanged" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub tmrComunicacao_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrComunicacao.Tick
        Try

            Call CarregarCanaisAD()

        Catch ex As Exception

            tmrComunicacao.Enabled = False

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

End Class