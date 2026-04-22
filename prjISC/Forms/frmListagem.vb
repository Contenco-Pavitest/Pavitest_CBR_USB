Option Explicit On
Imports System.Data.OleDb

Public Class frmListagem

#Region "Declarações"

    Dim odbAdaptador As OleDbDataAdapter
    Dim tblTable As DataTable
    Dim mngResgistro As CurrencyManager

    'Ordenar listagem
    Dim strCampo As String = "Data"
    Dim strOrdenar As String = "DESC"

    '(incluir, alterar, excluir, editar...)

    Public strNovoEditar As String

    Dim cnnUniversal As ADODB.Connection
    Dim blnCabecalho As Boolean
    'Gerar relatório
    Dim rstItens As ADODB.Recordset

#End Region


#Region "CARREGAR E DESCARREGAR"

    Private Sub frmListagem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            'Desabilitar os comandos
            Call usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmListagem_Load" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub frmListagem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Desabilitar os comandos
            Call usrLayout.HabilitarComandos(False)

            'Atualizar Data grid
            Call AtualizarDataGrid()

            'Call tsbFindTodos_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmListagem_Load" & Chr(13) & ex.Message)

        End Try
    End Sub

#End Region

    '**********************************************************************
    '************************ COMANDOS DE EXECUÇÃO ************************

#Region "AÇÕES DOS BOTÕES"

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        'Cadastra uma nova amostra
        Try

            blnNovaAmostra = True
            strNovoEditar = "Novo"
            frmCadastrarAmostra.Show()
            frmCadastrarAmostra.Focus()

        Catch ex As Exception
            MsgBox("btnNovo_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnNovo_Click" & Chr(13) & "btnNovo_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Edita amostra já cadastrada
        Try

            intIdAmostra = dtgGrid.CurrentRow.Cells(0).Value
            blnNovaAmostra = False

            strNovoEditar = "Editar"
            frmCadastrarAmostra.Show()
            frmCadastrarAmostra.Focus()

        Catch ex As Exception
            MsgBox("btnAmostra_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnAmostra_Click" & Chr(13) & "btnAmostra_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnApagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApagar.Click
        'Comando sql
        Dim odbReader As OleDbDataReader
        Dim intPosicao As Integer
        Dim strSql As String
        Dim dtrRegistro As DataRow
        Dim strAmostra As String
        Dim strTabela As String

        Try
            'Posição do registro
            intPosicao = mngResgistro.Position
            'Selecionar registro
            dtrRegistro = tblTable.Rows(intPosicao)
            'Selecionar o Identificador da amostra
            intIdAmostra = dtrRegistro("IdAmostra")
            strAmostra = dtrRegistro("Nome")

            If MsgBox("Deseja realmente apagar a amostra: " & strAmostra & "?" _
                      & Chr(13) & "Todos os dados e ensaios referentes á amostra serão apagados.", vbQuestion + MsgBoxStyle.YesNo, "Apagar Amostra") = MsgBoxResult.No Then
                Exit Sub
            End If

            'Selecionar os CP´s da amostra
            strSql = "SELECT IdCP FROM [tblCPs] " _
                & "WHERE IdAmostra = " & intIdAmostra

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)

            'Apaga a tabela
            While odbReader.Read
                'Apagar tabela de Ensaio do CP da amostra
                strTabela = "AMOSTRA" & intIdAmostra & "CP" & odbReader(0)
                'Apagar tabela se já existir
                Call usrConexao.ExistirTabela(strTabela, True)
            End While

            'Tabela Amostra
            strSql = "DELETE * FROM [tblAmostra] " _
                & "WHERE IdAmostra = " & intIdAmostra

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

            'Tabela CP
            strSql = "DELETE * FROM [tblCPs] " _
                & "WHERE IdAmostra = " & intIdAmostra

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

            'Atualizar o data grid
            Call AtualizarDataGrid()

        Catch ex As Exception
            MsgBox("btnApagar_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnApagar_Click" & Chr(13) & "btnApagar_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub btnCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCP.Click
        Try

            intIdAmostra = dtgGrid.CurrentRow.Cells(0).Value
            If bdnNavegator.Items.Count > 0 Then
                strNovoEditar = "Editar"
                IdAmostraEnsaio = dtgGrid.CurrentRow.Cells(0).Value
                strNomeAmostra = dtgGrid.CurrentRow.Cells(1).Value
                strCompactacao = dtgGrid.CurrentRow.Cells(4).Value
                dteData = dtgGrid.CurrentRow.Cells(3).Value

                frmCadastrarCP.Show()
                frmCadastrarCP.Focus()
            Else
                MsgBox("É necessário cadastrar a amostra para depois cadastrar os corpos de prova.", vbInformation)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("btnCP_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnCP_Click" & Chr(13) & "btnCP_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try

            Me.Close()

        Catch ex As Exception
            MsgBox("btnOk_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnOk_Click" & Chr(13) & "btnOk_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub dtgGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGrid.CellDoubleClick
        'Se clicar duas vezes no Grid entra na tela de Editar/Ensaiar
        Try

            If bdnNavegator.Items.Count > 0 Then Call btnEditar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("dtgGrid_CellDoubleClick()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("dtgGrid_CellDoubleClick" & Chr(13) & "dtgGrid_CellDoubleClick" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

#End Region

    '**********************************************************************
    '********************* GERAR RELATÓRIO DA LISTAGEM ********************

    Private Sub btnRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorio.Click
        'Imprime todos os corpos de prova já cadastrados
        Try

            intRelatorio = rpt_LISTAGEM
            frmRelatorio.Show()

        Catch ex As Exception
            MsgBox("btnRelatorio_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnRelatorio_Click" & Chr(13) & "btnRelatorio_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub AtualizarDataGrid()
        Dim strSql As String

        Try
            'Selecionar os campos da tabela
            strSql = "SELECT * FROM [tblAmostra] ORDER BY " & strCampo & " " & strOrdenar

            'Criar o comando Adaptador
            odbAdaptador = New OleDbDataAdapter(strSql, oConnection)
            tblTable = New DataTable
            odbAdaptador.Fill(tblTable)

            'Link para a barra de ferramentas
            bdnSource.DataSource = tblTable
            'Exibir os dados da tabela no grid
            dtgGrid.DataSource = bdnSource

            'Registro corrente
            mngResgistro = CType(dtgGrid.BindingContext(bdnSource), CurrencyManager)

            If mngResgistro.Count >= 1 Then
                'Call HabilitarComandos(True, True, True, True, True)
            Else
                'Call HabilitarComandos(False, True, False, False, False)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtulizarDataGrid" & Chr(13) & ex.Message)

        End Try

    End Sub

#Region "AÇÕES DO FILTRO"

    Private Sub tsbClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClean.Click
        Call Me.AtualizarDataGrid()
        tsbFind.Text = ""
        tsbClean.Visible = False
        tsbFind.Focus()
    End Sub

    Private Sub tsbFind_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tsbFind.KeyPress
        'e.KeyChar.Equals(ChrW(8)) serve para identificar se o BackSpace foi pressionado
        If tsbFindData.Checked = True And Not e.KeyChar.Equals(ChrW(13)) Then

            'Aceitar valores numéricos
            If Char.IsNumber(e.KeyChar) = False And Not e.KeyChar.Equals(ChrW(8)) And Not e.KeyChar.Equals(ChrW(13)) Then e.KeyChar = ""

            'Colocar as barras de data
            If (tsbFind.Text.Length = 2 Or tsbFind.Text.Length = 5) And Not (e.KeyChar.Equals(ChrW(8))) Then

                tsbFind.Text = tsbFind.Text & "/"
                tsbFind.SelectionStart = tsbFind.Text.Length + 1

            End If

        End If

        'Desativa o botão de limpar e atualiza o datagrid se a caixa de texto for vazia
        If (tsbFind.Text.Length = 1 And e.KeyChar.Equals(ChrW(8))) Or tsbFind.Text.Length = 0 Then

            tsbClean.Visible = False
            AtualizarDataGrid()

        End If
    End Sub

    Private Sub tsbFind_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFind.TextChanged
        If Not tsbFind.Text = "" Then Call tsbFindItem_ButtonClick(Nothing, Nothing)
    End Sub


    Private Sub tsbFindItem_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFindItem.ButtonClick
        Dim strCampo As String = ""
        Dim strSql As String
        Dim strTextoProcurado As String = ""
        Dim strCampos As String = "IdAmostra, Nome, Responsavel, Compactacao, Data, QteCPs"
        Dim strOrdenar As String = "Data DESC"

        Try
            'Montar seleção/filtro
            If tsbFindNome.Checked Then

                strCampo = "Nome"
                strTextoProcurado = "'%" & tsbFind.Text & "%'"

            ElseIf tsbFindResponsavel.Checked Then

                strCampo = "Responsavel"
                strTextoProcurado = "'%" & tsbFind.Text & "%'"

            ElseIf tsbFindQteCP.Checked Then

                strCampo = "QteCPs"
                strTextoProcurado = "'%" & tsbFind.Text & "%'"

            ElseIf tsbFindData.Checked Then

                strCampo = "Data"
                strTextoProcurado = "FORMAT('" & tsbFind.Text & "', 'dd/mm/yyyy') OR Data LIKE '%" & tsbFind.Text & "%'"

            ElseIf tsbFindCompactacao.Checked Then

                strCampo = "Compactacao"
                strTextoProcurado = "'%" & tsbFind.Text & "%'"

            End If

            If tsbFindTodos.Checked Then

                strSql = "SELECT " & strCampos & " FROM [tblAmostra] WHERE Nome LIKE '%" & _
                _tsbFind.Text & "%' OR Responsavel LIKE '%" & tsbFind.Text & "%' OR Compactacao LIKE '%" & _
                _tsbFind.Text & "%' OR Data LIKE '%" & tsbFind.Text & "%' OR Data LIKE FORMAT('" & _
                _tsbFind.Text & "', 'dd/mm/yyyy') OR QteCPs LIKE '%" & tsbFind.Text & "%' ORDER BY " & strOrdenar

            Else

                strSql = "SELECT " & strCampos & " FROM [tblAmostra] WHERE " & strCampo & " LIKE " & strTextoProcurado & " ORDER BY " & strOrdenar

            End If

            'Criar o comando Adaptador
            odbAdaptador = New OleDbDataAdapter(strSql, oConnection)
            tblTable = New DataTable
            odbAdaptador.Fill(tblTable)

            'Link para a barra de ferramentas
            bdnSource.DataSource = tblTable
            'Exibir os dados da tabela no grid
            dtgGrid.DataSource = bdnSource

            'Registro corrente
            mngResgistro = CType(dtgGrid.BindingContext(bdnSource), CurrencyManager)

            'If mngResgistro.Count >= 1 Then
            '    Call HabilitarComandos(True, True, True, True, True)
            'Else
            '    Call HabilitarComandos(False, True, False, False, False)
            'End If

            tsbClean.Visible = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Nenhum resultado foi encontrado com: " & "''" & tsbFind.Text & "''" & ", para o critério de busca utilizado.", MsgBoxStyle.Exclamation, "Pesquisar")

        End Try
    End Sub

    Private Sub tsbFindTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFindTodos.Click
        Try
            'Identificador da coluna
            'intTipo = 6
            If tsbFindTodos.CheckState Then
                tsbFindTodos.Checked = False
            Else
                Call DesabilitarChecked()
                tsbFindTodos.Checked = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbFindTipo_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbFindData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFindData.Click
        Try
            'Identificador da coluna
            'intTipo = 4
            If tsbFindData.CheckState Then
                tsbFindData.Checked = False
            Else
                Call DesabilitarChecked()
                tsbFindData.Checked = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbFindData_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbFindResponsavel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFindResponsavel.Click
        Try
            'Identificador da coluna
            'intTipo = 2
            If tsbFindResponsavel.CheckState Then
                tsbFindResponsavel.Checked = False
            Else
                Call DesabilitarChecked()
                tsbFindResponsavel.Checked = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbFindResponsavel_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbFindNome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFindNome.Click
        Try
            'Identificador da coluna
            'intTipo = 1
            If tsbFindNome.CheckState Then
                tsbFindNome.Checked = False
            Else
                Call DesabilitarChecked()
                tsbFindNome.Checked = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbFindNome_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbFindCompactacao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFindCompactacao.Click
        Try
            'Identificador da coluna
            'intTipo = 1
            If tsbFindCompactacao.CheckState Then
                tsbFindCompactacao.Checked = False
            Else
                Call DesabilitarChecked()
                tsbFindCompactacao.Checked = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbFindCompactacao_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Function DesabilitarChecked() As Boolean

        Try

            tsbFindTodos.Checked = False
            tsbFindNome.Checked = False
            tsbFindResponsavel.Checked = False
            tsbFindQteCP.Checked = False
            tsbFindData.Checked = False
            tsbFindCompactacao.Checked = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("DesabilitarChecked" & Chr(13) & ex.Message)

        End Try

    End Function

    Private Sub tsbFindQteCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFindQteCP.Click
        Try
            'Identificador da coluna
            'intTipo = 6
            If tsbFindQteCP.CheckState Then
                tsbFindQteCP.Checked = False
            Else
                Call DesabilitarChecked()
                tsbFindQteCP.Checked = True
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbFindTipo_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click

        Try
            'Chamar o comando novo
            Call btnNovo_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbAdd_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub tsbDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDelete.Click

        Try
            'Chamar o comando novo
            Call btnApagar_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbDelete_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

End Class