Option Explicit On

Imports System.Text
Imports System.Data.OleDb

Public Class clsDiversos

    Public Sub EsperarTempo(ByVal INTERVALO As Long)
        'Espera de tempo, liberando sistema operacional para
        'executar outros eventos

        Dim Delay As Double 'Tempo final de espera

        Delay = timeGetTime + INTERVALO
        Do Until timeGetTime > Delay
            My.Application.DoEvents()
        Loop

    End Sub
    Public Sub TransfereListasParaMatriz(ByVal listX As List(Of Double), ByVal listY As List(Of Double))

        Dim i As Integer

        'Armazena valores lidos da prensa na matriz de dados
        ReDim dblMatriz(0 To 1, listX.Count - 1)

        For Each item In listX
            dblMatriz(0, i) = item
            i += 1
        Next

        'Reinicia contador
        i = 0

        For Each item In listY
            dblMatriz(1, i) = item
            i += 1
        Next

    End Sub

    'Public Sub ExibeErros(ByVal strMensagemErro As String)
    '    On Error Resume Next

    '    MsgBox(strMensagemErro, vbInformation, "Ocorreu um erro !")
    'End Sub

    Public Function ExisteArquivo(ByVal Arquivo As String) As Integer
        'Verifica a existe do arquivo
        Dim Aux As String

        Aux = Dir(Arquivo)
        If Len(Aux) = 0 Then
            ExisteArquivo = False
        Else
            ExisteArquivo = True
        End If
    End Function

    Public Function ExisteTabela(ByVal strTabela As String, ByVal blnApagar As Boolean) As Boolean
        'Verifica se a tabela existe senão retorna erro
        Dim strSql As String
        Dim odbComando As OleDbCommand
        Dim odbReader As OleDbDataReader

        Try
            'Faz a seleção da tabela do banco.
            strSql = "SELECT * FROM [" & strTabela & "]"

            'Comando do banco de dados
            odbComando = oConnection.CreateCommand
            'Comando select 
            odbComando.CommandText = strSql
            'Comando de leitura do banco de dados
            odbReader = odbComando.ExecuteReader()

            'Leitura
            odbReader.Read()
            'Fechar
            odbReader.Close()

            'Apagar
            If blnApagar Then
                strSql = "DROP TABLE [" & strTabela & "]"
                'Comando do banco de dados
                Call usrConexao.ComandoExecucao(strSql)
            End If

            ExisteTabela = True

        Catch ex As Exception
            'Erro - Não existe a tabela
            ExisteTabela = False

        End Try
    End Function

    Public Function ValorNumerico(ByVal txtObjeto As TextBox, ByRef chrAscii As Char, ByRef blnDouble As Boolean, ByRef blnTABS As Boolean, ByRef blnNegativo As Boolean) As Char
        'Aceitar somente números nos campos indicados
        Dim shtPosicao As Short

        ValorNumerico = ""

        Try
            Select Case AscW(chrAscii)
                Case 13
                    '{TAB}
                    If blnTABS Then System.Windows.Forms.SendKeys.Send("{TAB}")
                Case 48 To 57, 8
                    'Valores numéricos (de 0 a 9) e Backspace
                    ValorNumerico = chrAscii
                Case 45
                    'Valores Negativos " - "
                    If blnNegativo Then
                        shtPosicao = InStr(1, txtObjeto.Text, "-", 1)
                        If shtPosicao = 0 Then
                            shtPosicao = txtObjeto.SelectionStart
                            txtObjeto.Text = "-" & txtObjeto.Text
                            txtObjeto.SelectionStart = shtPosicao + 1
                        Else
                            shtPosicao = txtObjeto.SelectionStart
                            txtObjeto.Text = Replace(txtObjeto.Text, "-", "")
                            txtObjeto.SelectionStart = shtPosicao + 1
                        End If
                    End If
                Case 46, 44
                    'Transformar ponto em vírgula
                    If blnDouble = True Then
                        ValorNumerico = ","
                        shtPosicao = InStr(1, txtObjeto.Text, ",", 1)
                        If shtPosicao > 0 Then
                            txtObjeto.SelectionStart = shtPosicao
                            ValorNumerico = ""
                        End If
                    Else
                        Beep()
                    End If
                Case Else
                    Beep()
            End Select

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ValorNumerico" & Chr(13) & ex.Message)

        End Try

    End Function
    Public Function VNumerico(ByVal Objeto As TextBox, ByVal KeyAscii As Integer, ByVal Real As Boolean, ByVal TABS As Boolean, ByVal Inteiro As Boolean, ByVal Negativo As Boolean) As Integer
        'Aceitar somente números nos campos indicados
        Dim Posicao As Integer

        VNumerico = 0

        Select Case KeyAscii
            '{TAB}
            Case 13
                If TABS Then SendKeys.Send("{TAB}")
                'Números de 0 a 9
                'BACKSPACE
            Case 48 To 57, 8
                VNumerico = KeyAscii
                'Valores Negativos " - "
            Case 45
                If Negativo Then
                    Posicao = InStr(1, Objeto.Text, "-", 1)
                    If Posicao = 0 Then
                        Posicao = Objeto.SelectionStart
                        Objeto.Text = "-" & Objeto.Text
                        Objeto.SelectionStart = Posicao + 1
                    Else
                        Posicao = Objeto.SelectionStart
                        Objeto.Text = Replace(Objeto.Text, "-", "")
                        Objeto.SelectionStart = Posicao + 1
                    End If
                End If
                'Transformar ponto em vírgula
            Case 46, 44
                If Inteiro Then
                    If Real = True Then
                        VNumerico = 44
                        Posicao = InStr(1, Objeto.Text, ",", 1)
                        If Posicao > 0 Then
                            Objeto.SelectionStart = Posicao
                            VNumerico = 0
                        End If
                    Else
                        Beep()
                    End If
                End If
            Case Else
                Beep()
        End Select
    End Function

    Public Function ValorNumericoToolStrip(ByVal txtObjeto As ToolStripTextBox, ByRef chrAscii As Char, ByRef blnDouble As Boolean, ByRef blnTABS As Boolean, ByRef blnNegativo As Boolean) As Char
        'Aceitar somente números nos campos indicados
        Dim shtPosicao As Short

        ValorNumericoToolStrip = ""

        Try
            Select Case AscW(chrAscii)
                Case 13
                    '{TAB}
                    If blnTABS Then System.Windows.Forms.SendKeys.Send("{TAB}")
                Case 48 To 57, 8
                    'Valores numéricos (de 0 a 9) e Backspace
                    ValorNumericoToolStrip = chrAscii
                Case 45
                    'Valores Negativos " - "
                    If blnNegativo Then
                        shtPosicao = InStr(1, txtObjeto.Text, "-", 1)
                        If shtPosicao = 0 Then
                            shtPosicao = txtObjeto.SelectionStart
                            txtObjeto.Text = "-" & txtObjeto.Text
                            txtObjeto.SelectionStart = shtPosicao + 1
                        Else
                            shtPosicao = txtObjeto.SelectionStart
                            txtObjeto.Text = Replace(txtObjeto.Text, "-", "")
                            txtObjeto.SelectionStart = shtPosicao + 1
                        End If
                    End If
                Case 46, 44
                    'Transformar ponto em vírgula
                    If blnDouble = True Then
                        ValorNumericoToolStrip = ","
                        shtPosicao = InStr(1, txtObjeto.Text, ",", 1)
                        If shtPosicao > 0 Then
                            txtObjeto.SelectionStart = shtPosicao
                            ValorNumericoToolStrip = ""
                        End If
                    Else
                        'Beep()
                    End If
                Case Else
                    'Beep()
            End Select

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ValorNumericoToolStrip" & Chr(13) & ex.Message)
        End Try

    End Function

    Public Sub FormatarCampo(ByVal dblCampoBD As Object, ByVal txtCampo As TextBox)
        Try

            If Not (dblCampoBD = 0) Then
                If dblCampoBD = 0 Then txtCampo.Text = "" Else txtCampo.Text = FormatNumber(dblCampoBD, 2)
            Else
                txtCampo.Text = ""
            End If

        Catch ex As Exception
            MsgBox("FormatarCampo" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("Classe Diversos" & Chr(13) & "FormatarCampo" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub FormatarCampoOP2(ByVal dblCampoBD As Object, ByVal strTxtRegressao As String)
        Try

            If Not (dblCampoBD = 0) Then
                'If dblCampoBD = 0 Then txtCampo.Text = "" Else txtCampo.Text = FormatNumber(dblCampoBD, 1)

                If dblCampoBD = 0 Then strTxtRegressao = "" Else strTxtRegressao = FormatNumber(dblCampoBD, 2)
            Else
                strTxtRegressao = ""
            End If

        Catch ex As Exception
            MsgBox("FormatarCampo" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("Classe Diversos" & Chr(13) & "FormatarCampo" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub SelecionarFoco(ByVal txtObjeto As TextBox)
        'Selecionar ao receber o foco

        Try
            txtObjeto.SelectAll()
            txtObjeto.Focus()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("SelecionarFoco" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub FinalizarComunicacao()
        Try

            Select Case intID_Tela_Comunicacao

                Case 1
                    'Depois voltar ao normal
                    With frmComunicacaoSerial
                        .lblMsgErro.Visible = True
                        .lblMsgErro.Text = "A Comunicação com a porta COM" & usrInicializacao.PORTA & " falhou!" & " Saia da tela e tente novamente!"
                        .lblControlador.Text = "ERRO de leitura ..."
                        .lblCarga.Text = "ERRO de leitura ..."
                        .lblLVDT.Text = "ERRO de leitura ..."
                        .tmrComunicacao.Enabled = False
                        .btnTestar.Enabled = True
                        .btnOk.Enabled = True
                        blnComunicacao = False
                    End With
                Case 2
                    With frmPainel
                        .lblMsgErro.Visible = True
                        .lblMsgErro.Text = "A Comunicação com a porta COM" & usrInicializacao.PORTA & " falhou!" & " Saia da tela e tente novamente!"
                        .tmrComunicacao.Enabled = False
                        .chkSelecaoCarga.Enabled = False
                        .chkSelecaoDeformacao.Enabled = False

                        .btnSair.Enabled = True
                        .lblCarga.Text = ""
                        .lblLVDT.Text = ""
                        blnComunicacao = False
                    End With
                Case 3
                    With frmGraficoPavitest
                        .lblMsgErro.Visible = True
                        .lblMsgErro.Text = "A Comunicação com a porta COM" & usrInicializacao.PORTA & " falhou!" & " Saia da tela de ensaio e teste a comunicação novamente!"
                        .btnIncrementar.Enabled = False
                        .btnDecrementar.Enabled = False
                        .btnParar.Enabled = False
                        .btnCancelar.Enabled = False
                        .btnFinalizar.Enabled = False
                        .tmrLeituras.Enabled = False
                        blnComunicacao = False
                    End With
            End Select

        Catch ex As Exception
            MsgBox("FinalizarComunicacao()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("Classe Diversos" & Chr(13) & "FinalizarComunicacao" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
        
    End Sub

    Public Sub VerificarAbrirPrograma(ByVal strPalavra As String)

        Dim lngPrev As Long
        Dim lngResult As Long

        Dim objProcess As New Process 'Variável de cada processo
        Dim objProcesses() As Process 'Coleção de todos os processos rodando na máquina

        objProcesses = Process.GetProcesses() 'Get all processes into the collection()

        For Each objProcess In objProcesses
            'Checar se já existe um projeto aberto
            If UCase(objProcess.MainWindowTitle) = UCase(strPalavra) Then
                frmApresentacao.Close()
                lngPrev = objProcess.MainWindowHandle.ToInt32()
                Exit For
            End If
        Next

        'Se nenhum preocesso aberto sair do procedimento
        If lngPrev = 0 Then Exit Sub

        'Restaurar o programa
        lngResult = OpenIcon(lngPrev)
        lngResult = SetForegroundWindow(lngPrev)

        'Finalizar a aplicação
        End

    End Sub

End Class
