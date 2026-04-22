Imports System.Management
Imports System.IO

Public Class frmLicença

    Private Sub frmLicença_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        usrLicença = New clsLicença

        If usrLicença.AvisoLicença() Then
            lblStatusAtivação.Text = "ATIVADO"
            mdiPrincipal.Text = frmPavitest.lblVersao.Text
            btnCriarChave.Enabled = False
            btnAtivarLicença.Enabled = False
            Me.Size = New System.Drawing.Size(640, 235)
            lblStatusAtivação.ForeColor = Color.Green
            With mdiPrincipal
                .tsbBaseDados.Enabled = True
                .mnuBancoDados1.Enabled = True
                .mnuEnsaiar.Enabled = True
            End With
        Else
            lblStatusAtivação.Text = "DESATIVADO"
            btnCriarChave.Enabled = True
            btnAtivarLicença.Enabled = False
            mdiPrincipal.Text = frmPavitest.lblVersao.Text & " - [VERSÃO DE TESTE]"
            Me.Size = New System.Drawing.Size(640, 404)
            lblStatusAtivação.ForeColor = Color.Red
            With mdiPrincipal
                .tsbBaseDados.Enabled = False
                .tsbAmostras.Enabled = False
                .mnuBancoDados1.Enabled = False
                .mnuEnsaiar.Enabled = False
            End With
        End If

        'Exibe Contra-Chave na caixa de texto
        If blnLicença Then
            Dim fluxoTexto As StreamReader
            fluxoTexto = New IO.StreamReader(My.Application.Info.DirectoryPath & "\Licença.dll")
            mtxtContraChave.Text = fluxoTexto.ReadLine.Replace("-", "")
            fluxoTexto.Close()
        Else
            mtxtContraChave.Text = ""
        End If

    End Sub

    Private Sub btnCriarChave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarChave.Click
        Try

            'Save File Dialog
            'define o titulo da janela
            svfd1.Title = "Salvar chave do programa"
            'Define as extensões permitidas
            svfd1.Filter = "DLL File|.dll"
            'define o indice do filtro
            svfd1.FilterIndex = 0
            'Atribui um valor vazio ao nome do arquivo
            svfd1.FileName = "Chave"
            'Define a extensão padrão como .txt
            svfd1.DefaultExt = ".dll"
            'define o diretório padrão
            svfd1.InitialDirectory = My.Application.Info.DirectoryPath
            'restaura o diretorio atual antes de fechar a janela
            svfd1.RestoreDirectory = True

            'Abre a caixa de dialogo e determina qual botão foi pressionado
            Dim resultado As DialogResult = svfd1.ShowDialog()

            'Se o ousuário pressionar o botão Salvar
            If resultado = DialogResult.OK Then

                'Cria um stream usando o nome do arquivo
                Dim fs As New FileStream(svfd1.FileName, FileMode.Create)

                'Converte a chave e exibe na caixa de texto
                mtxtChave.Text = usrLicença.Criptografar_Chave()
                usrLicença.Gravar_Arquivo_Info_PC(fs)
            Else

                Exit Sub

            End If

            'Habilita botão
            btnAtivarLicença.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtxtContraChave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxtContraChave.KeyPress
        'Caracteres Maiúsculos
        e.KeyChar = e.KeyChar.ToString.ToUpper

        btnAtivarLicença.Enabled = True

    End Sub

    Private Sub btnAtivarLicença_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtivarLicença.Click

        usrLicença.Gravar_Arquivo_Licença(mtxtContraChave.Text)
        If usrLicença.AvisoLicença() Then
            lblStatusAtivação.Text = "ATIVADO"
            lblStatusAtivação.ForeColor = Color.Green
            mdiPrincipal.Text = frmPavitest.lblVersao.Text
            With mdiPrincipal
                .tsbBaseDados.Enabled = True
                .mnuBancoDados1.Enabled = True
                .mnuEnsaiar.Enabled = True
            End With
            MsgBox("O programa está ativado!", MsgBoxStyle.Information, "Ativação do Pavitest")
            Me.Close()
        Else
            lblStatusAtivação.Text = "DESATIVADO"
            lblStatusAtivação.ForeColor = Color.Red
            mdiPrincipal.Text = frmPavitest.lblVersao.Text & " - [VERSÃO DE TESTE]"
            With mdiPrincipal
                .tsbBaseDados.Enabled = False
                .tsbAmostras.Enabled = False
                .mnuBancoDados1.Enabled = False
                .mnuEnsaiar.Enabled = False
            End With
            MsgBox("O programa não está ativado!", MsgBoxStyle.Critical, "Erro")
        End If

    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("mailto:assistencia.tecnica@contenco.com.br")
    End Sub

End Class