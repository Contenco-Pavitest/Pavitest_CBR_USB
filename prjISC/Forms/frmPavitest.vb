Public Class frmPavitest

    '////////////////////////////////////////////////////////////////
    '/////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

#Region "CARREGANDO E DESCARRENDO FORMS"

    Private Sub frmPavitest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Desabilitar os comandos
            usrLayout.HabilitarComandos(False)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmPavitest_Load" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub frmPavitest_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            'Desabilitar os comandos
            Call usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmPavitest_FormClosed" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////
    '/////////////// COMANDOS DE EXECUÇÃO (BUTTON) //////////////////

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Try

            'Desabilitar comandos 
            Call usrLayout.HabilitarComandos(False)

            'Fechar formulário
            Me.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

End Class