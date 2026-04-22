
Option Strict Off
Option Explicit On


Public Class clsLayout

    Public Sub RemoverX()

        Dim intMenu As Integer

        Try
            'Desabilitar o botão x
            intMenu = GetSystemMenu(BotaoX, False)
            DeleteMenu(intMenu, 6, MF_BYPOSITION)

        Catch ex As Exception
            'Mensagem de Erro
            MsgBox("RemoverX" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub HabilitarComandos(ByRef blnBloquear As Boolean)

        Try
            'Desabilirar menu e toolbar
            With mdiPrincipal
                'Toolbar
                .tlsBarraFerramenta.Enabled = blnBloquear
                'Menu
                .mnuBancoDados1.Enabled = blnBloquear
                .mnuEnsaiar.Enabled = blnBloquear
                .mnuUtilitarios.Enabled = blnBloquear
                .mnuHelp.Enabled = blnBloquear
            End With

        Catch ex As Exception
            'Mensagem de Erro
            MsgBox("HabilitarComandos" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub HabilitarAmostras(ByRef blnBloquear As Boolean)
        Try
            'Desabilirar menu e toolbar
            With mdiPrincipal
                'Toolbar
                .tsbAmostras.Enabled = blnBloquear
                'Menu
                .mnuEnsaiar.Enabled = blnBloquear
            End With

        Catch ex As Exception
            'Mensagem de Erro
            MsgBox("HabilitarComandos" & Chr(13) & ex.Message)

        End Try
    End Sub

    Public Sub CorMdi()

        Try
            'Ajusta a cor da MDI que é por padrão marrom
            For Each ctl As Control In mdiPrincipal.Controls

                If TypeOf ctl Is MdiClient Then
                    ctl.BackColor = mdiPrincipal.BackColor
                End If
            Next ctl

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CorMdi" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub CarregarFormulario(ByVal frmForm As Form, ByVal blnJanela As Boolean)

        Try
            'Colocar foco no formulário
            frmForm.Focus()

            'Abrir o formulário
            frmForm.Show()

            If blnJanela Then
                'Colocar a janela em estado normal devido ao form
                frmForm.WindowState = FormWindowState.Normal
            Else
                'Colocar a janela em estado máximo devido ao form
                frmForm.WindowState = FormWindowState.Maximized

                sizeFormMaximized = New Size(frmForm.Width, frmForm.Height)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarMdiChildren" & Chr(13) & ex.Message)

        End Try

    End Sub

End Class
