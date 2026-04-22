Public Class frmLogotipo

    Dim imgImagem As Image
    Dim blnAlterar As Boolean

    '////////////////////////////////////////////////////////////////
    '/////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

#Region "CARREGANDO E DESCARRENDO FORMS"

    Private Sub frmLogotipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Desabilita os comandos
            usrLayout.HabilitarComandos(False)

            'Setar variável
            blnAlterar = False

            'Carrega a imagem atual do relatorio 
            imgImagem = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagens\logotipo.jpg")
            pctLogotipo.Image = imgImagem

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmLogotipo_Load" & Chr(13) & ex.Message)

        End Try


    End Sub

    Private Sub frmLogotipo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            'Habilitar os comandos
            usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmLogotipo_FormClosed" & Chr(13) & ex.Message)

        End Try
    End Sub

#End Region

    '////////////////////////////////////////////////////////////////
    '///////////////////// COMANDOS DE EXECUÇÃO /////////////////////

#Region "COMANDOS DE EXECUÇÃO - BUTTON"

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try
            'Habilitar comandos
            usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnCancelar_Click" & Chr(13) & ex.Message)

        Finally
            Me.Close()

        End Try

    End Sub

    Private Sub btnCarregarImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click

        Try
            ofdDialogo.ShowDialog()
            If blnAlterar Then
                imgImagem.Dispose()
                'Carrega a imagem no formulário
                imgImagem = Image.FromFile(ofdDialogo.FileName)
                If imgImagem.Width < 88 Or imgImagem.Height < 63 Or imgImagem.Width > 295 Or imgImagem.Height > 80 Then
                    MsgBox("A imagem deve conter as dimensões máximas de: 295 pixels de largura e 80 pixels de altura. E mínimas de: 88 pixels de largura e 63 pixels de altura!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                pctLogotipo.Image = imgImagem
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnCarregarImagem_Click" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation, Me.Text)

        End Try

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Try
            If blnAlterar Then AlterarLogo()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        Finally
            'Habilitar os comandos
            usrLayout.HabilitarComandos(True)
            Me.Close()

        End Try

    End Sub

#End Region

#Region "COMANDOS DE EXECUÇÃO - FIGURA"

    Private Sub ofdDialogo_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ofdDialogo.Disposed

        Try
            'Setar variável
            blnAlterar = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ofdDialogo_Disposed" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub ofdDialogo_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdDialogo.FileOk

        Try
            'Setar variável
            blnAlterar = True
          
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ofdDialogo_FileOk" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////////////
    '///////////////////////// FUNÇÕES E PROCEDIMENTOS //////////////////////

    Private Sub AlterarLogo()
        
        Try
            pctLogotipo.Image.Save(My.Application.Info.DirectoryPath & "\Imagens\Logotipo.jpg", Imaging.ImageFormat.Jpeg)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AlterarLogo" & Chr(13) & ex.Message)

        Finally
            Me.Close()

        End Try

    End Sub

End Class