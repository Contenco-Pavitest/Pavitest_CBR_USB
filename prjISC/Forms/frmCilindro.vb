
Imports System.Data.OleDb

Public Class frmCilindro

    Dim odbAdaptador As OleDbDataAdapter
    Dim tblTable As DataTable
    Dim idCilindro As Integer
    Dim blnNovo As Boolean
    Dim jaConstruiuCampos As Boolean = True

    Private Sub frmCilindro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Atualizar navegador
        Call AtualizarNavegador()

        If (jaConstruiuCampos) Then
            Call ConstruirCampos()

            jaConstruiuCampos = False
        End If

        Call HabilitarBotoes(True, False)

        Call HabilitarCampos(False)
    End Sub

#Region "FUNÇÕES E PROCEDIMENTOS"

    Public Sub AtualizarNavegador()
        Dim strSql As String

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblCilindro] ORDER BY IdCilindro"

            'Criar o comando Adaptador
            odbAdaptador = New OleDbDataAdapter(strSql, oConnection)
            tblTable = New DataTable
            odbAdaptador.Fill(tblTable)

            'Link para a barra de ferramentas
            bdnSource.DataSource = tblTable

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarNavegador" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub ConstruirCampos()

        Try
            'Dados do corpo de prova
            txtIdCilindro.DataBindings.Add("Text", bdnSource, "IdCilindro", True, DataSourceUpdateMode.Never)
            txtNome.DataBindings.Add("Text", bdnSource, "Nome", True, DataSourceUpdateMode.Never)
            txtPeso.DataBindings.Add("Text", bdnSource, "Peso", True, DataSourceUpdateMode.Never, "", "0.00")
            txtVolume.DataBindings.Add("Text", bdnSource, "Volume", True, DataSourceUpdateMode.Never, "", "0.00")
            txtAltura.DataBindings.Add("Text", bdnSource, "Altura", True, DataSourceUpdateMode.Never, "", "0.00")

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConstruirCampos" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub HabilitarBotoes(ByVal blnHabilita As Boolean, ByVal blnDesabilita As Boolean)

        tsbAddCilindro.Enabled = blnHabilita
        tsbCountCilindro.Enabled = blnHabilita
        tsbDelete.Enabled = blnHabilita
        tsbEditCilindro.Enabled = blnHabilita
        tsbMoverFirstCilindro.Enabled = blnHabilita
        tsbMoverLastCilindro.Enabled = blnHabilita
        tsbMoverNextCilindro.Enabled = blnHabilita
        tsbMoverPreviousCilindro.Enabled = blnHabilita
        tsbPositionCilindro.Enabled = blnHabilita
        tsbSaveCilindro.Enabled = blnDesabilita
        tsbCancelCilindro.Enabled = blnDesabilita

    End Sub

    Private Sub HabilitarCampos(ByVal blnHabilita As Boolean)
        txtNome.Enabled = blnHabilita
        txtPeso.Enabled = blnHabilita
        txtAltura.Enabled = blnHabilita
        txtVolume.Enabled = blnHabilita
    End Sub

    Private Sub LimparCampos()

        txtNome.Text = ""
        txtPeso.Text = ""
        txtAltura.Text = ""
        txtVolume.Text = ""

    End Sub

#End Region

#Region "AÇÕES DOS BOTÕES (EDITAR, SALVAR, ADICIONAR, CANCELAR, DELETAR, OK)"

    Private Sub tsbEditCilindro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditCilindro.Click
        blnNovo = False

        Try

            HabilitarCampos(True)
            HabilitarBotoes(False, True)

            txtNome.Focus()
            txtNome.BackColor = Color.White
            txtAltura.BackColor = Color.White
            txtPeso.BackColor = Color.White
            txtVolume.BackColor = Color.White

            idCilindro = txtIdCilindro.Text

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbEditCilindro_Click" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub tsbCancelCilindro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelCilindro.Click
        Try

            HabilitarCampos(False)
            HabilitarBotoes(True, False)

            txtNome.BackColor = Color.Azure
            txtAltura.BackColor = Color.Azure
            txtPeso.BackColor = Color.Azure
            txtVolume.BackColor = Color.Azure

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbCancelCilindro_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub tsbAddCilindro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAddCilindro.Click
        blnNovo = True

        Try

            HabilitarCampos(True)
            HabilitarBotoes(False, True)
            LimparCampos()

            txtNome.Focus()
            txtNome.BackColor = Color.White
            txtAltura.BackColor = Color.White
            txtPeso.BackColor = Color.White
            txtVolume.BackColor = Color.White

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbEditCilindro_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub tsbDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDelete.Click
        idCilindro = txtIdCilindro.Text

        Dim strSql As String

        Try
            If MsgBox("Deseja realmente apagar o cilindro - " & txtNome.Text & "?" _
                      & Chr(13), vbQuestion + MsgBoxStyle.YesNo, "Apagar Corpo de Prova") = MsgBoxResult.No Then
                Exit Sub
            End If

            'Tabela CP
            strSql = "DELETE * FROM [tblCilindro] WHERE " _
                & "IdCilindro = " & idCilindro
            Call usrConexao.ComandoExecucao(strSql)

            AtualizarNavegador()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbDelete_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbSaveCilindro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSaveCilindro.Click
        'Comando sql
        Dim strSql As String
        Dim strComando As String

        Try
            If (txtNome.Text = "") Then
                MsgBox("O preenchimento do campo Nome é obrigatório!", MsgBoxStyle.Exclamation)
                txtNome.Focus()
                Exit Sub
            End If

            If (txtPeso.Text = "") Then
                MsgBox("O preenchimento do campo Peso é obrigatório!", MsgBoxStyle.Exclamation)
                txtPeso.Focus()
                Exit Sub
            End If

            If (txtVolume.Text = "") Then
                MsgBox("O preenchimento do campo Volume é obrigatório!", MsgBoxStyle.Exclamation)
                txtVolume.Focus()
                Exit Sub
            End If

            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            If blnNovo Then strComando = cmd_INSERT Else strComando = cmd_UPDATE

            'Identificadores do registro
            'Cadastro
            If txtNome.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Nome", txtNome.Text)
            If txtPeso.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Peso", txtPeso.Text)
            If txtAltura.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Altura", txtAltura.Text)
            If txtVolume.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Volume", txtVolume.Text)

            'Comando Sql
            If blnNovo Then
                If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"
                If strStruture_Valor <> "" Then strStruture_Valor = strStruture_Valor & ")"

                'Comando Sql (Adicionar)
                strSql = "INSERT INTO [tblCilindro] " _
                    & strStruture_Campo & strStruture_Valor

            Else
                'Comando Sql (Editar)
                strSql = "UPDATE [tblCilindro] SET " & strStruture_Campo _
                    & " WHERE IdCilindro = " & idCilindro

            End If

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

            AtualizarNavegador()
            HabilitarBotoes(True, False)
            HabilitarCampos(False)


            txtNome.BackColor = Color.Azure
            txtAltura.BackColor = Color.Azure
            txtPeso.BackColor = Color.Azure
            txtVolume.BackColor = Color.Azure

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ComandoSalvar" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        frmCadastrarCP.CarregarCilindro()

        Me.Close()
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        frmTransferenciaDados.ShowDialog()
    End Sub

#End Region

End Class