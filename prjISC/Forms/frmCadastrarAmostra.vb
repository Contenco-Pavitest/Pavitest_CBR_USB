'Cadastrar ou Editar uma nova amostra

Option Strict Off
Option Explicit On

Imports System.Data.OleDb
Imports System.Nullable


Public Class frmCadastrarAmostra

#Region "Declarações de variáveis"

    Dim blnSalvar As Boolean
    Dim blnFrmAmostraCarregado As Boolean


#End Region

    '////////////////////////////////////////////////////////////////
    '/////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

#Region "CARREGAR E DESCARREGAR FORMS"

    Private Sub frmCadastrarAmostra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            cmbCompactacao.SelectedIndex = 0

            blnFrmAmostraCarregado = True

            If usrConexao.ExistirColuna("TipoEnsaio", "tblAmostra") = False Then
                blnExisteColunaTipoEnsaio = usrConexao.AcrescentarColunaNaTabela("TipoEnsaio", "tblAmostra")
            Else
                blnExisteColunaTipoEnsaio = True
            End If

            If usrConexao.ExistirColuna("QteCPs", "tblAmostra") = False Then
                blnExisteColunaTipoEnsaio = usrConexao.AcrescentarColunaNaTabela("QteCPs", "tblAmostra")
            Else
                blnExisteColunaTipoEnsaio = True
            End If

            'Setar variáveis 
            blnSalvar = True

            If blnNovaAmostra = False Then
                Call VerificaCPEnsaiado()
                If blnHaCPsEnsaiados = True Then
                    btnEditar.Enabled = False
                End If
                blnSalvar = True
                Call AtualizarDados()
                Call HabilitarComandos(True, True, False)
                Call HabilitarAmostra(False)
            Else
                If RadioButtonAbnt.Checked Then
                    strTipoEnsaio = RadioButtonAbnt.Text
                    txtTipoEnsaio.Text = strTipoEnsaio
                Else
                    strTipoEnsaio = RadioButtonDnit.Text
                    txtTipoEnsaio.Text = strTipoEnsaio
                End If

                Call HabilitarAmostra(True)
                Call HabilitarComandos(False, False, False)
                mskData.Text = CStr(DateTime.Now.ToShortDateString)
            End If

            If blnHaCPsEnsaiados = True Then
                btnEditar.Enabled = False
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCadastrarAmostra_Load" & Chr(13) & ex.Message)

        End Try

    End Sub
    Private Sub VerificaCPEnsaiado()
        Try
            Dim odbReader As OleDbDataReader
            Dim intQtdCPs As Integer

            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM [tblCPs] WHERE IdAmostra = " & intIdAmostra & " AND EnsaioRealizado = True", oConnection)
            Dim totalCPs As Long = CInt(cmd.ExecuteScalar())

            If totalCPs > 0 Then
                blnHaCPsEnsaiados = True
            Else
                blnHaCPsEnsaiados = False
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("VerificaCPEnsaiado" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub frmCadastrarAmostra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            'Foco para o campo amostra
            txtNome.SelectAll()
            txtNome.Focus()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCadastrarAmostra_Activated" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub frmCadastrarAmostra_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            'Atualizar o data grid
            Call frmListagem.AtualizarDataGrid()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCadastrarAmostra_FormClosed" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////////
    '///////////////////////// COMANDOS DE EXECUÇÃO /////////////////////

#Region "COMANDOS DE EXECUÇÃO - BUTTON"

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        'Salvar inclusão ou alteração
        'Comando sql
        Dim strSql As String
        Dim strComando As String

        Try
            'Verificar os valores
            If Not VerificarValidade() Then Exit Sub

            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            txtTipoEnsaio.Text = "DNIT 172 - ME"

            If blnNovaAmostra Then strComando = cmd_INSERT Else strComando = cmd_UPDATE

            If txtNome.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Nome", txtNome.Text)
            If txtResponsavel.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Responsavel", txtResponsavel.Text)
            If mskData.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Data", mskData.Text)
            If txtPrograma.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Programa", txtPrograma.Text)
            If txtNumero.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Numero", txtNumero.Text)
            If cmbCompactacao.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Compactacao", cmbCompactacao.Text)
            If txtTipoEnsaio.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "TipoEnsaio", txtTipoEnsaio.Text)

            If blnNovaAmostra Then
                If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"
                If strStruture_Valor <> "" Then strStruture_Valor = strStruture_Valor & ")"

                'Comando Sql (Adicionar)
                strSql = "INSERT INTO [tblAmostra] " _
                    & strStruture_Campo & strStruture_Valor

            Else
                'Comando Sql (Editar)
                strSql = "UPDATE [tblAmostra] SET " & strStruture_Campo _
                    & " WHERE IdAmostra = " & intIdAmostra

            End If

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

            'Atualizar o Identificador da amostra
            If blnNovaAmostra Then Call AtualizarId()

            'Salvou 
            blnSalvar = True
            Call HabilitarComandos(True, True, False)
            Call HabilitarAmostra(False)

            frmGraficoPavitest.CarregarVetorPenetracao()
            'Atualizar o data grid
            Call frmListagem.AtualizarDataGrid()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnSalvar_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Try

            Call HabilitarAmostra(True)
            Call HabilitarComandos(False, False, True)

            blnNovaAmostra = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnEditar_Click" & Chr(13) & ex.Message)

        End Try

    End Sub



    Private Sub btnCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCP.Click

        Try
            frmListagem.btnCP_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnCP_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Try
            Me.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////////////
    '///////////////////////// FUNÇÕES E PROCEDIMENTOS //////////////////////

#Region "FUNÇÕES E PROCEDIMENTOS - ATUALIZAR"

    Private Sub AtualizarDados()
        Dim strSql As String
        Dim odbReader As OleDbDataReader

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblAmostra] WHERE IdAmostra = " & intIdAmostra

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            odbReader.Read()

            'Atribuir os valores 
            If Not IsDBNull(odbReader("IdAmostra".ToString)) Then txtIdAmostra.Text = odbReader("IdAmostra".ToString)
            If Not IsDBNull(odbReader("Nome".ToString)) Then txtNome.Text = odbReader("Nome".ToString)
            If Not IsDBNull(odbReader("Responsavel".ToString)) Then txtResponsavel.Text = odbReader("Responsavel".ToString)
            mskData.Text = odbReader("Data".ToString)
            If Not IsDBNull(odbReader("Numero".ToString)) Then txtNumero.Text = odbReader("Numero".ToString)
            If Not IsDBNull(odbReader("Programa".ToString)) Then txtPrograma.Text = odbReader("Programa".ToString)
            If Not IsDBNull(odbReader("Compactacao".ToString)) Then cmbCompactacao.Text = odbReader("Compactacao".ToString)
            If Not IsDBNull(odbReader("TipoEnsaio".ToString)) Then txtTipoEnsaio.Text = odbReader("TipoEnsaio".ToString)

            strTipoEnsaio = txtTipoEnsaio.Text

            If txtTipoEnsaio.Text = RadioButtonAbnt.Text Then
                RadioButtonAbnt.Checked = True
            Else
                RadioButtonDnit.Checked = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarDados" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub AtualizarId()
        Dim strSql As String
        Dim odbReader As OleDbDataReader

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT IdAmostra FROM [tblAmostra] ORDER BY IdAmostra DESC"

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            odbReader.Read()

            'Identificador a última amostra cadastra
            intIdAmostra = odbReader("IdAmostra".ToString)

            'Fechar
            odbReader.Close()

            'Atualizou
            blnNovaAmostra = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarId" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "FUNÇÕES E PROCEDIMENTOS - HABILITAR"

    Private Sub HabilitarComandos(ByVal blnCP As Boolean, ByVal blnEditar As Boolean, ByVal blnSalvar As Boolean)

        Try
            btnCP.Enabled = blnCP
            btnEditar.Enabled = blnEditar
            btnSalvar.Enabled = blnSalvar

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarComandos" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub HabilitarAmostra(ByVal blnComando As Boolean)

        Try
            txtNome.Enabled = blnComando
            txtResponsavel.Enabled = blnComando
            mskData.Enabled = blnComando
            cmbCompactacao.Enabled = blnComando
            txtPrograma.Enabled = blnComando
            txtNumero.Enabled = blnComando
            RadioButtonAbnt.Enabled = blnComando
            RadioButtonDnit.Enabled = blnComando
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarAmostra" & Chr(13) & ex.Message)

        End Try
    End Sub

#End Region

    Private Function VerificarValidade() As Boolean
        'Verifica se os dados cadastrados são válidos

        'Dados inválidos
        VerificarValidade = False

        Try
            'Verificar nome da amostra
            If txtNome.Text = Nothing Then
                MsgBox("O preenchimento do NOME da amostra é obrigatório!", vbExclamation, "NOME da amostra vazio")
                txtNome.Focus()
                Exit Function
            End If

            'Verificar nome do número do programa
            If txtPrograma.Text = Nothing Then
                MsgBox("O preenchimento do NÚMERO DO PROGRAMA da amostra é obrigatório!", vbExclamation, "NÚMERO DO PROGRAMA da amostra vazio")
                txtPrograma.Focus()
                Exit Function
            End If

            'Verificar nome do núemro da amostra
            If txtNumero.Text = Nothing Then
                MsgBox("O preenchimento do NÚMERO DA AMOSTRA é obrigatório!", vbExclamation, "NÚMERO DA AMOSTRA vazio")
                txtNumero.Focus()
                Exit Function
            End If

            'Verificar nome da amostra
            If txtResponsavel.Text = Nothing Then
                MsgBox("O preenchimento do RESPONSÁVEL da amostra é obrigatório!", vbExclamation, "RESPONSÁVEL da amostra vazio")
                txtResponsavel.Focus()
                Exit Function
            End If

            'Verificar data da amostra
            If Not IsDate(mskData.Text) Then
                MsgBox("O preenchimento da DATA DO ENSAIO da amostra é obrigatório!", vbExclamation, "DATA DE MOLDAGEM da amostra vazia")
                mskData.Focus()
                Exit Function
            End If

            'Verificação válida
            VerificarValidade = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("VerificarValidade" & Chr(13) & ex.Message)

        End Try

    End Function

    '////////////////////////////////////////////////////////////////
    '////////////////////// TEXTOS - VALORES NUMÉRICOS //////////////

#Region "Verificar valores numéricos e selecionar foco"

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        'Habilita botão salvar

        Try
            Call HabilitarComandos(False, False, True)
            blnSalvar = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("txtNome_TextChanged" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub cmbCompactacao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompactacao.Click
        'Habilita botão salvar

        Try
            Call HabilitarComandos(False, False, True)
            blnSalvar = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("cmbCompactacao_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub txtResponsavel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Habilita botão salvar

        Try
            Call HabilitarComandos(False, False, True)
            blnSalvar = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("txtResponsavel_TextChanged" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub txtNumero_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged
        'Habilita botão salvar

        Try
            Call HabilitarComandos(False, False, True)
            blnSalvar = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("txtNumero_TextChanged" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub txtPrograma_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrograma.TextChanged
        'Habilita botão salvar

        Try
            Call HabilitarComandos(False, False, True)
            blnSalvar = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("txtPrograma_TextChanged" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub RadioButtonAbnt_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAbnt.CheckedChanged, RadioButtonDnit.CheckedChanged
        If RadioButtonAbnt.Checked Then
            strTipoEnsaio = RadioButtonAbnt.Text
            txtTipoEnsaio.Text = strTipoEnsaio
        Else
            strTipoEnsaio = RadioButtonDnit.Text
            txtTipoEnsaio.Text = strTipoEnsaio
        End If
    End Sub


#End Region

End Class