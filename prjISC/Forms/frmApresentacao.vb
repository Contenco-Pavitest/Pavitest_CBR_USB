' Contenco Industria e Comercio Ltda.
' Projeto: Pavitest Global.
' Descricao: Programa para realizar ensaios em geral.

Option Strict Off
Option Explicit On

Friend Class frmApresentacao

    '//////////////////////////////////////////////////////////////////////////
    '///////////////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

    Private Sub frmApresentacao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Try
            'Efeito de Ampulheta
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            'Informação Copyright
            'lblCopyright.Text = My.Application.Info.Copyright
           
            'Setando a classe
            usrDiversos = New clsDiversos
           
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmApresentacao_Load" & vbCrLf & ex.Message)

        End Try

    End Sub

End Class
