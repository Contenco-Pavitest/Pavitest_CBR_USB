Public Class mdiPrincipal

#Region "CARREGAR E DESCARREGAR FORMS"

    Private Sub mdiPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            'Cancelar fechar sistema
            e.Cancel = True
            Call tsbSair_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("MdiPrincipal_FormClosing" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub mdiPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Função para abrir somente uma vez o programa
            If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
                Call usrDiversos.VerificarAbrirPrograma(Me.Text)
            End If

            'Setando as classes
            usrLayout = New clsLayout
            usrInicializacao = New clsInicializacao
            usrInicializacaoFabricante = New clsInicializacao_Fabricante

            'Ajusta a cor da MDI que é por padrão marrom
            Call usrLayout.CorMdi()

            'Chama sub-rotinas da classe clsInicializacao
            Call usrInicializacao.Iniciar()
            Call usrInicializacao.AtualizaDisco()

            'Chama sub-rotinas da classe clsInicializacao
            Call usrInicializacaoFabricante.Iniciar()
            Call usrInicializacaoFabricante.AtualizarDisco()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mdiPrincipal_Load" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub mdiPrincipal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Try
            'Chamar a janela para selecionar o BD
            If Not blnBDCarregado Then
                blnBDCarregado = True
                Call tsbBaseDados_Click(Nothing, Nothing)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mdiPrincipal_Activated" & Chr(13) & ex.Message)

        End Try
    End Sub

#End Region

    Private Sub tsbSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSair.Click

        Try
            If MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sair do Sistema") = MsgBoxResult.Yes Then
                End
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tbrSair_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub mnuSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSair.Click

        Try
            tsbSair_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuSair_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub mnuInformacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInformacao.Click


        Try

            My.Forms.frmPavitest.MdiParent = Me
            Call usrLayout.CarregarFormulario(frmPavitest, True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuInformacao_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub tsbLogotipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLogotipo.Click

        Try
            My.Forms.frmLogotipo.MdiParent = Me
            Call usrLayout.CarregarFormulario(frmLogotipo, True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuInformacao_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub mnuLogotipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogotipo.Click
        Try
            tsbLogotipo_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuAlterarLogotipo_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbPainel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPainel.Click

        My.Forms.frmPainel.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmPainel, True)

    End Sub

    Private Sub tsbPortaSerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPortaSerial.Click

        My.Forms.frmPortaSerial.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmPortaSerial, True)

    End Sub

    Private Sub tsbComunicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbComunicar.Click

        My.Forms.frmComunicacaoSerial.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmComunicacaoSerial, True)

    End Sub

    Private Sub tsbLicença_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLicença.Click

        My.Forms.frmLicença.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmLicença, True)

    End Sub

    Private Sub tsbBaseDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBaseDados.Click

        My.Forms.frmCadastrarBD.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmCadastrarBD, True)

    End Sub

    Private Sub tsbConfigurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConfigurar.Click

        My.Forms.frmConfigurarEnsaio.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmConfigurarEnsaio, True)

    End Sub

    Private Sub tsbCalibrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCalibrar.Click

        My.Forms.frmCalibracao.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmCalibracao, True)

    End Sub

    Private Sub mnuComunicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuComunicar.Click
        tsbComunicar_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuConfigurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigurar.Click
        tsbConfigurar_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuPortaSerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPortaSerial.Click
        tsbPortaSerial_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuLicença_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLicença.Click
        tsbLicença_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuBancoDados2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBancoDados2.Click
        tsbBaseDados_Click(Nothing, Nothing)
    End Sub

    Private Sub tsbAmostras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAmostras.Click

        My.Forms.frmListagem.MdiParent = Me
        Call usrLayout.CarregarFormulario(frmListagem, False)

    End Sub

    Private Sub mnuCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCadastrar.Click
        tsbAmostras_Click(Nothing, Nothing)
    End Sub
End Class
