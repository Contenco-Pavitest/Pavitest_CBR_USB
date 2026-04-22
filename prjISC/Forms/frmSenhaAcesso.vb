
Public Class frmSenhaAcesso

    Dim strSenha As String

    '////////////////////////////////////////////////////////////////
    '/////////////////// CARREGANDO E DESCARRENDO FORMS /////////////

#Region "CARREGANDO E DESCARRENDO FORMS"

    Private Sub frmSenhaAcesso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            txtSenha.Select()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmSenhaAcesso_Load" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////
    '/////////////////// COMANDOS DE EXECUÇÃO ///////////////////////

#Region " COMANDOS DE EXECUÇÃO - BUTTON"

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try
            blnSenhaFabricanteOK = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnCancelar_Click" & Chr(13) & ex.Message)

        Finally
            If blnTelaSenha = False Then
                frmCalibracao.Enabled = True
            Else
                frmConfigurarEnsaio.Enabled = True
            End If

            Me.Close()

        End Try

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim intDia, intMes, intAno As Integer

        Try

            Select Case blnTelaSenha

                Case False ' Tela de Calibração

                    intDia = Today.Day
                    intMes = Today.Month
                    intAno = Today.Year

                    strSenha = txtSenha.Text

                    If strSenha = (intDia & intMes & intAno) Then
                        blnSenhaOk = True
                        txtSenha.Text = Nothing

                        'frmCalibracao.Enabled = True
                        Me.Close()

                    Else
                        blnSenhaOk = False
                        txtSenha.Text = ""
                        strSenha = ""

                        MsgBox("Senha incorreta.", vbExclamation, "Pavitest")
                        txtSenha.Focus()
                        txtSenha.SelectAll()

                    End If

                Case True 'Tela de COnfigurações do Fabricante

                    strSenha = txtSenha.Text

                    If strSenha = "2221" Then
                        blnSenhaFabricanteOK = True
                        txtSenha.Text = Nothing

                        frmConfigurarEnsaio.Enabled = True

                        Me.Close()

                    Else
                        blnSenhaFabricanteOK = False
                        txtSenha.Text = ""
                        strSenha = ""

                        MsgBox("Senha incorreta.", vbExclamation, "Pavitest")
                        txtSenha.Focus()
                        txtSenha.SelectAll()

                    End If

            End Select

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

End Class