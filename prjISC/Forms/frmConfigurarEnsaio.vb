Option Strict Off
Option Explicit On


Friend Class frmConfigurarEnsaio

    '****** Janela Configurações
    'Configura a porta serial, intervalo e escalas

    Private Sub frmConfigurarEnsaio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Carrega dados iniciais da configuração
        Try
            txtIntervalo.Text = usrInicializacao.INTERVALO
            txtArea.Text = usrInicializacao.AREAPISTAO


            'New==========================================================
            blnSenhaFabricanteOK = False
            'New==========================================================

        Catch ex As Exception
            MsgBox("frmConfigurarEnsaio_Load()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("frmConfigurarEnsaio_Load" & Chr(13) & "Form_Load" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    '****************************************************************
    '******************** COMANDOS DE EXECUÇÃO **********************

#Region "EVENTOS CLICK DOS BOTÕES OK E CANCELAR"

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Confirma nova configuração
        Dim i As Integer

        Try

            'Intervalo do timer
            If Double.Parse(txtIntervalo.Text) < 0 Then
                MsgBox("O INTERVALO DE TEMPO PARA AQUISIÇÃO de dados do gráfico tem que ser um valor numérico inteiro e positivo.", vbExclamation)
                txtIntervalo.Focus()
                Exit Sub
            End If
            usrInicializacao.INTERVALO = txtIntervalo.Text

            'Área do Pistão
            If Double.Parse(txtArea.Text) < 0 Then
                MsgBox("A ÁREA DO PISTÃO tem que ser um valor numérico inteiro e positivo.", vbExclamation)
                txtArea.Focus()
                Exit Sub
            End If
            usrInicializacao.AREAPISTAO = txtArea.Text


            usrInicializacao.AtualizaDisco()

            Me.Close()

        Catch ex As Exception
            MsgBox("btnOk_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnOk_Click" & Chr(13) & "cmdOk_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()

        Catch ex As Exception
            MsgBox("btnCancelar_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnCancelar_Click" & Chr(13) & "cmdCancelar_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

#End Region

    '****************************************************************
    '******************** FORMATAR CAMPO TEXTO **********************

#Region "EVENTOS GOTFOCUS (FORMATAR PARA SOMENTE NÚMEROS) DOS TXTPENETRACAO - TXTPRESSAO - TXTAREA - TXTINTERVALO"

    Private Sub txtIntervalo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIntervalo.GotFocus
        Try

            'Selecionar o texto ao receber o foco
            Call usrDiversos.SelecionarFoco(txtIntervalo)

        Catch ex As Exception
            MsgBox("txtIntervalo_GotFocus()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtPenetracao_LostFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub txtIntervalo_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIntervalo.LostFocus
        'Formata o campo
        Try

            If IsNumeric(txtIntervalo.Text) Then txtIntervalo.Text = FormatNumber(txtIntervalo.Text, 0)

        Catch ex As Exception
            MsgBox("txtIntervalo_LostFocus1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtPenetracao_LostFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txtArea_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArea.GotFocus
        Try

            'Selecionar o texto ao receber o foco
            Call usrDiversos.SelecionarFoco(txtArea)

        Catch ex As Exception
            MsgBox("txtArea_GotFocus()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtPenetracao_LostFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub txtArea_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArea.LostFocus
        'Formata o campo
        Try

            If IsNumeric(txtArea.Text) Then txtArea.Text = FormatNumber(txtArea.Text, 0)

        Catch ex As Exception
            MsgBox("txtArea_LostFocus1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtPenetracao_LostFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub



#End Region

#Region "EVENTOS KEYPRESS (FORMATAR PARA SOMENTE NÚMEROS) DOS TXTPENETRACAO - TXTPRESSAO - TXTAREA - TXTINTERVALO"


    Private Sub txtArea_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArea.KeyPress
        'Válida valores numéricos
        Try

            Dim aux As Integer
            aux = Asc(e.KeyChar)
            '(OBJETO As TextBox, KeyAscii As Integer, REAL As Boolean, TABS As Boolean, ValorDecimal As Boolean, Negativo As Boolean)
            e.KeyChar = ChrW(usrDiversos.VNumerico(txtArea, aux, True, True, True, False))

        Catch ex As Exception
            MsgBox("txtArea_KeyPress()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("txtArea_KeyPress" & Chr(13) & "txtPenetracao_KeyPress" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txtIntervalo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntervalo.KeyPress
        'Válida valores numéricos
        Try

            Dim aux As Integer
            aux = Asc(e.KeyChar)
            '(OBJETO As TextBox, KeyAscii As Integer, REAL As Boolean, TABS As Boolean, ValorDecimal As Boolean, Negativo As Boolean)
            e.KeyChar = ChrW(usrDiversos.VNumerico(txtIntervalo, aux, True, True, True, False))

        Catch ex As Exception
            MsgBox("txtIntervalo_KeyPress()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("txtIntervalo_KeyPress" & Chr(13) & "txtPenetracao_KeyPress" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnParametrizacaoFabricante_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbcControl1_Click(sender As Object, e As EventArgs) Handles tbcControl1.Click
        Try

            btnParametrizacaoFabricante.Visible = False
            btnModoSimulacao.Visible = False

            If tbcControl1.SelectedIndex = 1 Then


                If blnModoSimulacao Then
                    btnModoSimulacao.Text = "Desativar Modo Simulação"
                Else
                    btnModoSimulacao.Text = "Ativar Modo Simulação"
                End If
                'Verificar a permissão de acesso
                blnTelaSenha = True
                frmSenhaAcesso.ShowDialog()
                If Not blnSenhaFabricanteOK Then Exit Sub

                btnParametrizacaoFabricante.Visible = True
                btnModoSimulacao.Visible = True

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tbcContro1_Click" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub btnParametrizacaoFabricante_Click_1(sender As Object, e As EventArgs) Handles btnParametrizacaoFabricante.Click
        frmFabricante_Configuracoes.Show()
    End Sub

    Private Sub btnModoSimulacao_Click(sender As Object, e As EventArgs) Handles btnModoSimulacao.Click
        If btnModoSimulacao.Text = "Ativar Modo Simulação" Then

            blnModoSimulacao = True
            btnModoSimulacao.Text = "Desativar Modo Simulação"

        Else

            blnModoSimulacao = False
            btnModoSimulacao.Text = "Ativar Modo Simulação"

        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

#End Region

End Class
