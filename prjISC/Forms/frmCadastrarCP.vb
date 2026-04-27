Option Strict Off
Option Explicit On

Imports System.Data.OleDb
Imports System.Math
Imports System.Drawing
Imports System.Runtime.InteropServices.DllImportAttribute
Imports Excel = Microsoft.Office.Interop.Excel


Friend Class frmCadastrarCP

#Region "Declaração de variáveis"

    Inherits System.Windows.Forms.Form

    Dim odbAdaptador As OleDbDataAdapter
    Dim tblTable As DataTable

    'Adicionar novo Ensaio (adicionar ou editar)    
    Dim blnAdicionarCP As Boolean
    Dim blnExisteEnsaio As Boolean
    Dim existeEnsaio As Boolean

    'Carregando os dados
    Dim blnCarregarDados As Boolean

    'Variáveis Excel
    Dim strCampo(,) As String
    Dim objData(,) As Object
    Dim blnExcel As Boolean
    Dim blnCalc As Boolean

    'Vetor do cilindro
    Dim strVetor(,) As String

#End Region

    '////////////////////////////////////////////////////////////////////
    '/////////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

#Region "CARREGAR E DESCARREGAR FORMS"

    Private Sub frmCadastrarCP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            If usrConexao.ExistirColuna("TipoEnsaio", "tblAmostra") = False Then
                blnExisteColunaTipoEnsaio = usrConexao.AcrescentarColunaNaTabela("TipoEnsaio", "tblAmostra")
            Else
                blnExisteColunaTipoEnsaio = True
            End If

            'Habilitar CP´s
            Call HabilitarCP(False)
            'Dados da Amostra
            Call AtualizarDadosAmostra()

            blnExisteEnsaio = False

            'Atualizar navegador                                                                  
            Call AtualizarNavegador()
            'Construir link para os campos
            Call ConstruirCampos()

            'Habilitar comandos CP
            Call HabilitarComandosCP(True, False, False, False, False)
            'Habilitar comandos ensaio
            Call HabilitarComandosEnsaio(False, False)

            'Carregar os cilindros cadastrados
            Call CarregarCilindro()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCadastrarCP_Load" & Chr(13) & ex.Message)

        End Try

    End Sub
    Public Sub FormataTabela()


        If lblTipoEnsaio.Text = "DNIT 172 - ME" Then
            lblLegendaPressao.Text = "Pressão (kgf/cm²)"
            txtPadrao0.Text = "70,31"
            txtPadrao1.Text = "105,46"
        ElseIf lblTipoEnsaio.Text = "ABNT NBR 9895" Then
            lblLegendaPressao.Text = "Pressão (MPa)"

            If txtCalculada1.Text <> "" And txtCalculada0.Text <> "" Then
                txtCalculada0.Text = 0.1 * txtCalculada0.Text
                txtCalculada1.Text = 0.1 * txtCalculada1.Text
            End If

            If txtCorrigida1.Text <> "" And txtCorrigida0.Text <> "" Then
                txtCorrigida0.Text = 0.1 * txtCorrigida0.Text
                txtCorrigida1.Text = 0.1 * txtCorrigida1.Text
            End If

            txtPadrao0.Text = "6,9"
            txtPadrao1.Text = "10,35"
        End If
    End Sub
    Private Sub frmCadastrarCP_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Try

            If bdnSource.Count > 0 Then
                'Habilitar comandos/botões cp
                Call HabilitarComandosCP(True, True, True, False, False)

                'Habilitar comandos/botões do ensaio
                If txtEnsaioRealizado.Text = "" Or txtEnsaioRealizado.Text = "False" Then
                    blnExisteEnsaio = False
                Else
                    blnExisteEnsaio = True
                End If

                If blnExisteEnsaio Then
                    Call HabilitarComandosEnsaio(False, True)
                Else
                    Call HabilitarComandosEnsaio(True, False)
                End If

            Else
                'Habilitar comandos/botões cp
                Call HabilitarComandosCP(True, False, False, False, False)
                'Habilitar comandos/botões do ensaio
                Call HabilitarComandosEnsaio(False, False)

            End If

            If blnAtualizarTelaCadastro = True Then
                'Atualizar navegador
                Call AtualizarNavegador()
                blnAtualizarTelaCadastro = False
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCadastrarCP_Activated" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////////
    '///////////////////////// COMANDOS DE EXECUÇÃO /////////////////////

#Region "COMANDOS DE EXECUÇÃO - BUTTON"

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Try
            'Fechar o formulario corrente
            Me.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnEnsaiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnsaiar.Click

        Try
            If Not ValidarDados() Then Exit Sub

            blnEnsaioGravado = False
            blnFormCarregado = False
            blnReverEnsaio = False

            'Atribuir valor ao identificador
            intIdCP = CInt(txtId.Text)

            frmGraficoPavitest.Focus()
            'Carregar formulário
            Call usrLayout.CarregarFormulario(frmGraficoPavitest, False)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnEnsaiar_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnRever_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRever.Click

        Try
            If Not ValidarDados() Then Exit Sub

            blnEnsaioGravado = True
            blnFormCarregado = False
            blnReverEnsaio = True

            'Atribuir valor ao identificador
            intIdCP = CInt(txtId.Text)

            'Carregar formulário
            Call usrLayout.CarregarFormulario(frmRever, False)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnRever_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub LerEExportarDadosParaTabela()

        Dim strTabela As String
        Dim strSql As String
        Dim odbReader As OleDbDataReader
        Dim intColuna As Int32
        Dim intLinha As Int32

        Try
            'Atribuir valor ao identificador
            intIdCP = CInt(txtId.Text)
            'Nome da Tabela
            'AMOSTRAxxCPxx
            strTabela = "AMOSTRA" & IdAmostraEnsaio & "CP" & intIdCP
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM " & strTabela '& " ORDER BY Tempo"

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)

            'Dimensionar o array para os nomes dos campos
            'o número de colunas precisa ser obtido
            intColuna = odbReader.FieldCount - 1
            intLinha = 0
            ReDim strCampo(0, intColuna)
            'O DataReader é um conjunto de dados somente para frente e somente leitura
            'Por isso não podemos saber o número de registros até que ele os retorne
            'a solução possível é estimar o numero de registro e usar 
            ReDim objData(10000, intColuna)

            'Preencher o array dos nomes dos campos usando o método GetName do DataReader
            For intCont = 0 To intColuna
                strCampo(0, intCont) = odbReader.GetName(intCont)
            Next

            'Preencher o array de registros lendo todos os registros no DataReader
            While odbReader.Read
                For intCont = 0 To intColuna
                    objData(intLinha, intCont) = odbReader.Item(intCont)
                Next
                intLinha = intLinha + 1
            End While
            'Fechar a conexão e o DataReader.
            odbReader.Close()

            'Exportar os dados do vetor para o Excel
            If blnExcel Then Call ComandoExcel(intLinha, intColuna)

            'Exportar os dados do vetor para o Calc
            If blnCalc Then Call ComandoCalc(intLinha, intColuna)

        Catch ex As Exception
            'Mensagem de erro
            Dim strErroSemExcel As String = "Falha na recuperação de factory de classes COM do componente" &
            " com CLSID {00024500-0000-0000-C000-000000000046} devido ao seguinte erro: 80040154."

            If ex.Message = strErroSemExcel Then
                MsgBox("O programa detectou que o Microsoft Excel não está instalado no sistema. Caso não" &
                       " possua licensa, instale o programa gratuito Apache OpenOffice Calc.", MsgBoxStyle.Information, "Aviso")
            Else
                MsgBox("LerEExportarDadosParaTabela" & Chr(13) & ex.Message)
            End If

        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            'Define para qual programa ocorrerá a exportação
            blnExcel = True
            blnCalc = False

            'Adquirir dados para exportação e exportar
            Call LerEExportarDadosParaTabela()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnExcel_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        Try
            'Define para qual programa ocorrerá a exportação
            blnExcel = False
            blnCalc = True

            'Adquirir dados para exportação e exportar
            Call LerEExportarDadosParaTabela()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnCalc_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub ComandoExcel(ByVal intLinha As Int32, ByVal intColuna As Int32)
        'Definir as variáveis para tratar com o Excel.
        Dim xlApp As New Excel.Application
        Dim xlWBook As Excel.Workbook = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet)
        Dim xlWSheet As Excel.Worksheet = CType(xlWBook.Worksheets(1), Excel.Worksheet)
        Dim xlCalc As Excel.XlCalculation

        Try
            'Salvar a configuração atual para o modo de calculo do Excel e a desliga
            With xlApp
                xlCalc = .Calculation
                .Calculation = Excel.XlCalculation.xlCalculationManual
            End With

            'Escrever o nome dos campos e os dados para a planilha destino
            With xlWSheet
                .Range(.Cells(1, 1), .Cells(1, intColuna + 1)).Value = strCampo
                .Range(.Cells(2, 1), .Cells(intLinha + 2, intColuna + 1)).Value = objData
                .UsedRange.Columns.AutoFit()
            End With

            'Tornar o Excel disponível 
            With xlApp
                .Visible = True
                .UserControl = True
                'Restaura o modo de cálculo
                .Calculation = xlCalc
            End With

            'Liberar os objetos da memória
            xlWSheet = Nothing
            xlWBook = Nothing
            xlApp = Nothing
            GC.Collect()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ComandoExcel" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub ComandoCalc(ByVal intLinha As Int32, ByVal intColuna As Int32)

        Dim myDoc As Object
        Dim firstSheet As Object
        Dim fields As Object = ""
        Dim unoWrap As Object
        Dim sortDx As Object
        Dim n As Integer

        Try
            'Abre Conexão com o OpenOffice
            ConnectOpenOffice()

            myDoc = StarDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, dummyArray)

            'Seleciona primeira tabela
            firstSheet = myDoc.Sheets.getByIndex(0)

            'Escreve os nomes das colunas
            For n = 0 To intColuna

                firstSheet.getCellByPosition(n, 0).String = strCampo(0, n)

            Next

            'Escreve os dados das colunas
            For n = 0 To intLinha
                For j = 0 To intColuna
                    firstSheet.getCellByPosition(j, n + 1).String = objData(n, j)
                Next
            Next

            unoWrap = OpenOffice.Bridge_GetValueObject
            unoWrap.set("[]com.sun.star.table.TableSortField", fields)
            sortDx = CreateProperties("ContainsHeader", True, "SortFields", unoWrap)

            'Fecha conexão com o OpenOffice
            DisconnectOpenOffice()

        Catch ex As Exception
            'Mensagem de erro
            Dim strErroCalc As String = "Conexão OpenOffice é impossível"

            If ex.Message = strErroCalc Then
                MsgBox("O programa detectou que o Apache OpenOffice Calc não está instalado no sistema. Instale-o" &
                       ", ou utilize o Microsoft Excel.", MsgBoxStyle.Information, "Aviso")
            Else
                MsgBox("ComandoCalc" & Chr(13) & ex.Message)
            End If

        End Try

    End Sub

    Private Sub btnResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResultado.Click

        Try
            If Not ValidarDados() Then Exit Sub

            'Colocar o foco no formulário
            frmResultadosJ.Focus()

            'Atribuir valor ao identificador
            intIdCP = CInt(txtId.Text)

            'Carregar formulário
            Call usrLayout.CarregarFormulario(frmResultados, False)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnResultado_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "COMANDOS DE EXECUÇÃO - BARRA DE FERRAMENTAS"

    Private Sub tsbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdd.Click

        Try
            tbcCP.SelectedIndex = 0

            'Limpar campos do ensaio
            Call LimparEnsaio()

            txtAltura.Text = ""

            'Habilitar CP´s
            Call HabilitarCP(True)
            Call HabilitarComandosCP(False, False, False, True, True)
            Call HabilitarComandosEnsaio(False, False)

            'Adicionar CP e Ensaio
            blnAdicionarCP = True

            'Foco no campo de identificação do Cilindro
            cmbCilindro.Focus()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbAdd_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub tsbDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDelete.Click
        'Comando sql
        Dim strTabela As String
        Dim strSql As String

        Try
            If MsgBox("Deseja realmente apagar o corpo de prova - " & txtCapsula.Text & "?" _
                      & Chr(13) & "Todos os dados e ensaios referentes ao CP serão apagados." _
                      , vbQuestion + MsgBoxStyle.YesNo, "Apagar Corpo de Prova") = MsgBoxResult.No Then
                Exit Sub
            End If

            intIdCP = txtId.Text

            'Apagar tabela de Ensaio do CP da amostra
            strTabela = "AMOSTRA" & intIdAmostra & "CP" & intIdCP
            'Apagar tabela se já existir
            Call usrConexao.ExistirTabela(strTabela, True)

            'Tabela CP
            strSql = "DELETE * FROM [tblCPs] WHERE " _
                & "IdAmostra = " & intIdAmostra & " AND IdCP = " & intIdCP
            Call usrConexao.ComandoExecucao(strSql)

            'Atualizar navegador do cadastro de CP's
            Call AtualizarNavegador()

            'Atualizar contador de CP´s
            Call AtualizarContadorCP()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbDelete_Click" & Chr(13) & ex.Message)

        End Try
    End Sub

    Private Sub tsbEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEdit.Click

        Try
            'Habilitar CP´s
            Call HabilitarCP(True)
            Call HabilitarComandosCP(False, False, False, True, True)
            Call HabilitarComandosEnsaio(False, False)

            'Adicionar CP e Ensaio
            blnAdicionarCP = False

            'Foco no campo cápsula 01
            txtPeso.Focus()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbEdit_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub tsbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSave.Click

        Try


            'Verificar se dados válidos
            If Not ValidarDados() Then Exit Sub

            'Determinar o id do Ensaio senão continua o mesmo
            If blnAdicionarCP Then
                'Verificar existência dos ensaios
                intIdCP = DeterminarIdCP()
            Else
                intIdCP = txtId.Text
            End If

            'Salvar os dados do CP/Ensaio
            Call ComandoSalvar()

            'Atualizar navegador
            Call AtualizarNavegador()

            'Mover para o ultimo ensaio cadstrado e atualizar contador de CP
            If blnAdicionarCP Then
                bdnSource.MoveLast()
                'Atualizar contador de CP´s
                Call AtualizarContadorCP()
            End If

            'Salvou novo ensaio
            blnAdicionarCP = False
            blnNovaAmostra = False

            'Habilitar CP´s
            Call HabilitarCP(False)
            'Habilitar comandos cp
            Call HabilitarComandosCP(True, True, True, False, False)
            'Habilitar ensaiar/rever
            If txtISC2.Text = "" Then
                Call HabilitarComandosEnsaio(True, False)
            Else
                Call HabilitarComandosEnsaio(False, True)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbSave_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub tsbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancel.Click

        Try
            'Atualizar dados
            Call AtualizarNavegador()

            'Habilitar CP´s
            Call HabilitarCP(False)
            'Habilitar comandos
            Call HabilitarComandosCP(True, True, True, False, False)

            If txtEnsaioRealizado.Text = "False" Or txtEnsaioRealizado.Text = "" Then
                Call HabilitarComandosEnsaio(True, False)
            Else
                Call HabilitarComandosEnsaio(False, True)
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tsbCancel_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '///////////////////////////////////////////////////////////////////
    '//////////////////// FUNÇÕES E PROCEDIMENTOS //////////////////////

#Region "FUNÇÕES E PROCEDIMENTOS - ATUALIZAR TABELAS, NAVEGAR, CONTADOR"

    Private Sub AtualizarDadosAmostra()
        Dim strSql As String
        Dim odbReader As OleDbDataReader

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblAmostra] WHERE IdAmostra = " & IdAmostraEnsaio

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            odbReader.Read()

            'Atribuir os valores 
            If Not IsDBNull(odbReader("Nome".ToString)) Then lblNome.Text = odbReader("Nome".ToString)
            If Not IsDBNull(odbReader("Compactacao".ToString)) Then lblEnergia.Text = odbReader("Compactacao".ToString)
            If Not IsDBNull(odbReader("Data".ToString)) Then lblData.Text = odbReader("Data".ToString)
            If IsDBNull(odbReader("TipoEnsaio".ToString)) Then
                strTipoEnsaio = "DNIT 172 - ME"
            Else
                strTipoEnsaio = odbReader("TipoEnsaio".ToString)
            End If

            lblTipoEnsaio.Text = strTipoEnsaio

            odbReader.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarDadosAmostra" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub AtualizarNavegador()
        Dim strSql As String

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblCPs]" _
                   & "WHERE IdAmostra = " & IdAmostraEnsaio _
                   & " ORDER BY IdCP"

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

    Public Sub AtualizarContadorCP()
        Dim strSql As String
        Dim odbReader As OleDbDataReader
        Dim lngCont As Long

        Try
            'Atualizar o contador de CP´s
            'Selecionar quantidade de CP´s da amostra
            strSql = "SELECT COUNT(*) AS ContadorCPs FROM [tblCPs] " _
                    & "WHERE IdAmostra = " & IdAmostraEnsaio

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            odbReader.Read()
            lngCont = odbReader(0)
            'Fechar
            odbReader.Close()

            'Atualizar a tabela de amostras
            strSql = "UPDATE [tblAmostra] SET QteCPs = " & lngCont _
                    & " WHERE IdAmostra = " & IdAmostraEnsaio

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)

            'Atualizar o data grid
            Call frmListagem.AtualizarDataGrid()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarContadorCP" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "FUNÇÕES E PROCEDIMENTOS - CONSTRUIR CAMPO"

    Public Sub ConstruirCampos()

        Try
            'Dados do corpo de prova

            txtPeso.DataBindings.Add("Text", bdnSource, "Peso", True, DataSourceUpdateMode.Never, "", "0.00")
            cmbCilindro.DataBindings.Add("Text", bdnSource, "Cilindro", True, DataSourceUpdateMode.Never)
            txtCapsula.DataBindings.Add("Text", bdnSource, "Capsula", True, DataSourceUpdateMode.Never)
            txtVolume.DataBindings.Add("Text", bdnSource, "Volume", True, DataSourceUpdateMode.Never)
            txtSoloCilindro.DataBindings.Add("Text", bdnSource, "UmidoCilindro", True, DataSourceUpdateMode.Never)
            lblSoloUmido.DataBindings.Add("Text", bdnSource, "SoloUmido", True, DataSourceUpdateMode.Never)
            lblMassaUmida.DataBindings.Add("Text", bdnSource, "MassaUmido", True, DataSourceUpdateMode.Never)
            txtUmidoTara.DataBindings.Add("Text", bdnSource, "UmidoTara", True, DataSourceUpdateMode.Never)
            txtSecoTara.DataBindings.Add("Text", bdnSource, "SecoTara", True, DataSourceUpdateMode.Never)
            lblAgua.DataBindings.Add("Text", bdnSource, "Agua", True, DataSourceUpdateMode.Never)
            txtTara.DataBindings.Add("Text", bdnSource, "Tara", True, DataSourceUpdateMode.Never)
            lblSoloSeco.DataBindings.Add("Text", bdnSource, "SoloSeco", True, DataSourceUpdateMode.Never)
            lblUmidade.DataBindings.Add("Text", bdnSource, "Umidade", True, DataSourceUpdateMode.Never)
            lblMassaSeca.DataBindings.Add("Text", bdnSource, "MassaSeca", True, DataSourceUpdateMode.Never)
            lblDiferenca.DataBindings.Add("Text", bdnSource, "Diferenca", True, DataSourceUpdateMode.Never)
            txtAltura.DataBindings.Add("Text", bdnSource, "Altura", True, DataSourceUpdateMode.Never)
            lblExpansao.DataBindings.Add("Text", bdnSource, "Expansao", True, DataSourceUpdateMode.Never)
            lblMoldeInicial.DataBindings.Add("Text", bdnSource, "MoldeUmidoInicial", True, DataSourceUpdateMode.Never)
            txtMoldeFinal.DataBindings.Add("Text", bdnSource, "MoldeUmidoFinal", True, DataSourceUpdateMode.Never)
            lblAguaAbsorvida.DataBindings.Add("Text", bdnSource, "AguaAbsorvida", True, DataSourceUpdateMode.Never)

            txtCalculada0.DataBindings.Add("Text", bdnSource, "PCalculada1", True, DataSourceUpdateMode.Never, "", "0.00")
            txtCalculada1.DataBindings.Add("Text", bdnSource, "PCalculada2", True, DataSourceUpdateMode.Never, "", "0.00")
            txtCorrigida0.DataBindings.Add("Text", bdnSource, "PCorrigida1", True, DataSourceUpdateMode.Never, "", "0.00")
            txtCorrigida1.DataBindings.Add("Text", bdnSource, "PCorrigida2", True, DataSourceUpdateMode.Never, "", "0.00")

            If lblTipoEnsaio.Text = "ABNT NBR 9895" Then
                If txtCalculada0.Text <> "" And txtCalculada1.Text <> "" Then
                    txtCalculada0.Text = 0.1 * txtCalculada0.Text
                    txtCalculada1.Text = 0.1 * txtCalculada1.Text
                End If
                If txtCorrigida0.Text <> "" And txtCorrigida1.Text <> "" Then
                    txtCorrigida0.Text = 0.1 * txtCorrigida0.Text
                    txtCorrigida1.Text = 0.1 * txtCorrigida1.Text
                End If
            End If

            txtISC0.DataBindings.Add("Text", bdnSource, "ISC1", True, DataSourceUpdateMode.Never, "", "0.00")
            txtISC1.DataBindings.Add("Text", bdnSource, "ISC2", True, DataSourceUpdateMode.Never, "", "0.00")
            If txtISC0.Text > txtISC1.Text Then txtISC2.DataBindings.Add("Text", bdnSource, "ISC1", True, DataSourceUpdateMode.Never, "", "0.00") Else txtISC2.DataBindings.Add("Text", bdnSource, "ISC2", True, DataSourceUpdateMode.Never, "", "0.00")
            mskData0.DataBindings.Add("Text", bdnSource, "Data1", True, DataSourceUpdateMode.Never, "", "d")
            mskData1.DataBindings.Add("Text", bdnSource, "Data2", True, DataSourceUpdateMode.Never, "", "d")
            mskData2.DataBindings.Add("Text", bdnSource, "Data3", True, DataSourceUpdateMode.Never, "", "d")
            mskData3.DataBindings.Add("Text", bdnSource, "Data4", True, DataSourceUpdateMode.Never, "", "d")
            mskData4.DataBindings.Add("Text", bdnSource, "Data5", True, DataSourceUpdateMode.Never, "", "d")
            mskHora0.DataBindings.Add("Text", bdnSource, "Hora1", True, DataSourceUpdateMode.Never, "", "t")
            mskHora1.DataBindings.Add("Text", bdnSource, "Hora2", True, DataSourceUpdateMode.Never, "", "t")
            mskHora2.DataBindings.Add("Text", bdnSource, "Hora3", True, DataSourceUpdateMode.Never, "", "t")
            mskHora3.DataBindings.Add("Text", bdnSource, "Hora4", True, DataSourceUpdateMode.Never, "", "t")
            mskHora4.DataBindings.Add("Text", bdnSource, "Hora5", True, DataSourceUpdateMode.Never, "", "t")
            txtLeitura0.DataBindings.Add("Text", bdnSource, "Leitura1", True, DataSourceUpdateMode.Never)
            txtLeitura1.DataBindings.Add("Text", bdnSource, "Leitura2", True, DataSourceUpdateMode.Never)
            txtLeitura2.DataBindings.Add("Text", bdnSource, "Leitura3", True, DataSourceUpdateMode.Never)
            txtLeitura3.DataBindings.Add("Text", bdnSource, "Leitura4", True, DataSourceUpdateMode.Never)
            txtLeitura4.DataBindings.Add("Text", bdnSource, "Leitura5", True, DataSourceUpdateMode.Never)
            txtEnsaioRealizado.DataBindings.Add("Text", bdnSource, "EnsaioRealizado", True, DataSourceUpdateMode.Never)
            txtId.DataBindings.Add("Text", bdnSource, "IdCP", True, DataSourceUpdateMode.Never)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConstruirCampos" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "FUNÇÕES E PROCEDIMENTOS - HABILITAR COMANDOS E CAMPOS"

    Public Sub HabilitarComandosCP(ByRef blnAdicionar As Boolean, ByVal blnEditar As Boolean, ByVal blnApagar As Boolean, ByRef blnSalvar As Boolean, ByRef blnCancelar As Boolean)

        Try
            tsbAdd.Enabled = blnAdicionar
            tsbEdit.Enabled = blnEditar
            tsbDelete.Enabled = blnApagar

            tsbSave.Enabled = blnSalvar
            tsbCancel.Enabled = blnCancelar

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarComandosCP" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub HabilitarCP(ByVal btnComando As Boolean)

        Try
            'Cadastro
            cmbCilindro.Enabled = btnComando
            txtPeso.Enabled = btnComando
            txtVolume.Enabled = btnComando
            txtSoloCilindro.Enabled = btnComando
            txtCapsula.Enabled = btnComando
            txtUmidoTara.Enabled = btnComando
            txtSecoTara.Enabled = btnComando
            txtTara.Enabled = btnComando
            txtAltura.Enabled = btnComando
            txtMoldeFinal.Enabled = btnComando
            mskData0.Enabled = btnComando
            mskData1.Enabled = btnComando
            mskData2.Enabled = btnComando
            mskData3.Enabled = btnComando
            mskData4.Enabled = btnComando
            mskHora0.Enabled = btnComando
            mskHora1.Enabled = btnComando
            mskHora2.Enabled = btnComando
            mskHora3.Enabled = btnComando
            mskHora4.Enabled = btnComando
            txtCalculada0.Enabled = btnComando
            txtCalculada1.Enabled = btnComando
            txtCorrigida0.Enabled = btnComando
            txtCorrigida1.Enabled = btnComando
            txtISC0.Enabled = btnComando
            txtISC1.Enabled = btnComando

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarCP" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub HabilitarComandosEnsaio(ByRef blnEnsaiar As Boolean, ByVal blnRever As Boolean)

        Try
            btnEnsaiar.Enabled = blnEnsaiar
            btnRever.Enabled = blnRever
            btnExcel.Enabled = blnRever
            btnCalc.Enabled = blnRever
            'btnResultado.Enabled = blnRever

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarComandosEnsaio" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "FUNÇÕES E PROCEDIMENTOS - SALVAR OS DADOS VÁLIDOS"

    Private Sub LimparEnsaio()

        Try
            cmbCilindro.Text = ""
            txtPeso.Text = ""
            txtVolume.Text = ""
            txtSoloCilindro.Text = ""
            txtCapsula.Text = ""
            txtUmidoTara.Text = ""
            txtSecoTara.Text = ""
            txtTara.Text = ""
            txtMoldeFinal.Text = ""
            mskData0.Text = ""
            mskData1.Text = ""
            mskData2.Text = ""
            mskData3.Text = ""
            mskData4.Text = ""
            mskHora0.Text = ""
            mskHora1.Text = ""
            mskHora2.Text = ""
            mskHora3.Text = ""
            mskHora4.Text = ""
            txtCalculada0.Text = ""
            txtCalculada1.Text = ""
            txtCorrigida0.Text = ""
            txtCorrigida1.Text = ""
            txtISC0.Text = ""
            txtISC1.Text = ""
            lblAgua.Text = ""
            lblAguaAbsorvida.Text = ""
            lblDiferenca.Text = ""
            lblExpansao.Text = ""
            lblMassaSeca.Text = ""
            lblMassaUmida.Text = ""
            lblMoldeInicial.Text = ""
            lblSoloSeco.Text = ""
            lblSoloUmido.Text = ""
            lblUmidade.Text = ""


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LimparEnsaio" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Function ValidarDados() As Boolean

        ValidarDados = False

        Try
            'Verificar se CP é valido
            If cmbCilindro.Text = "" Then
                MsgBox("O preenchimento correto do campo CILINDRO é obrigatório!", vbExclamation, "CILINDRO inválido")
                cmbCilindro.Focus()
                Exit Function
            End If

            'Verificar se VOLUME é valido
            If txtCapsula.Text = "" Then
                MsgBox("O preenchimento correto do campo CÁPSULA é obrigatório!", vbExclamation, "CÁPSULA inválido")
                Exit Function
            End If

            'Área do Pistão
            dblAreaEnsaio = usrInicializacao.AREAPISTAO

            ValidarDados = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ValidarDados" & Chr(13) & ex.Message)

        End Try

    End Function

    Public Function DeterminarIdCP() As Integer
        'Determinar o id do ensaio
        Dim strSql As String
        Dim odbReader As OleDbDataReader
        Dim intTemp As Integer

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblCPs] " _
                   & "WHERE IdAmostra = " & IdAmostraEnsaio & " ORDER BY IdCP"

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)

            'Leitura
            While odbReader.Read()
                'Identificador o último CP cadastro
                intTemp = odbReader("IdCP".ToString)
            End While

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("DeterminarIdCP" & Chr(13) & ex.Message)

        Finally
            'Id no ensaio
            DeterminarIdCP = intTemp + 1

        End Try


    End Function

    Private Sub ComandoSalvar()
        'Comando sql
        Dim strSql As String
        Dim strComando As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            If blnAdicionarCP Then strComando = cmd_INSERT Else strComando = cmd_UPDATE

            'Identificadores do registro
            If blnAdicionarCP Then Call usrConexao.ConstruirSQL(strComando, "IdAmostra", IdAmostraEnsaio)
            If blnAdicionarCP Then Call usrConexao.ConstruirSQL(strComando, "IdCP", intIdCP)

            'Cadastro
            If cmbCilindro.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Cilindro", cmbCilindro.Text)
            If txtPeso.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Peso", txtPeso.Text)
            If txtCapsula.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Capsula", txtCapsula.Text)
            If txtVolume.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Volume", txtVolume.Text)
            If txtSoloCilindro.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "UmidoCilindro", txtSoloCilindro.Text)
            If lblSoloUmido.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "SoloUmido", lblSoloUmido.Text)
            If lblMassaUmida.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "MassaUmido", lblMassaUmida.Text)
            If txtUmidoTara.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "UmidoTara", txtUmidoTara.Text)
            If txtSecoTara.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "SecoTara", txtSecoTara.Text)
            If lblAgua.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Agua", lblAgua.Text)
            If txtTara.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Tara", txtTara.Text)
            If lblSoloSeco.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "SoloSeco", lblSoloSeco.Text)
            If lblUmidade.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Umidade", lblUmidade.Text)
            If lblMassaSeca.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "MassaSeca", lblMassaSeca.Text)
            If lblDiferenca.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Diferenca", lblDiferenca.Text)
            If txtAltura.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Altura", txtAltura.Text)
            If lblExpansao.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Expansao", lblExpansao.Text)
            If lblMoldeInicial.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "MoldeUmidoInicial", lblMoldeInicial.Text)
            If txtMoldeFinal.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "MoldeUmidoFinal", txtMoldeFinal.Text)
            If lblAguaAbsorvida.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "AguaAbsorvida", lblAguaAbsorvida.Text)
            If (mskData0.Text <> "  /  /") Then Call usrConexao.ConstruirSQL(strComando, "Data1", mskData0.Text)
            If (mskData1.Text <> "  /  /") Then Call usrConexao.ConstruirSQL(strComando, "Data2", mskData1.Text)
            If (mskData2.Text <> "  /  /") Then Call usrConexao.ConstruirSQL(strComando, "Data3", mskData2.Text)
            If (mskData3.Text <> "  /  /") Then Call usrConexao.ConstruirSQL(strComando, "Data4", mskData3.Text)
            If (mskData4.Text <> "  /  /") Then Call usrConexao.ConstruirSQL(strComando, "Data5", mskData4.Text)
            If (mskHora0.Text <> "  :") Then Call usrConexao.ConstruirSQL(strComando, "Hora1", mskHora0.Text)
            If (mskHora1.Text <> "  :") Then Call usrConexao.ConstruirSQL(strComando, "Hora2", mskHora1.Text)
            If (mskHora2.Text <> "  :") Then Call usrConexao.ConstruirSQL(strComando, "Hora3", mskHora2.Text)
            If (mskHora3.Text <> "  :") Then Call usrConexao.ConstruirSQL(strComando, "Hora4", mskHora3.Text)
            If (mskHora4.Text <> "  :") Then Call usrConexao.ConstruirSQL(strComando, "Hora5", mskHora4.Text)
            If txtLeitura0.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Leitura1", txtLeitura0.Text)
            If txtLeitura1.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Leitura2", txtLeitura1.Text)
            If txtLeitura2.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Leitura3", txtLeitura2.Text)
            If txtLeitura3.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Leitura4", txtLeitura3.Text)
            If txtLeitura4.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Leitura5", txtLeitura4.Text)

            'Comando Sql
            If blnAdicionarCP Then
                If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"
                If strStruture_Valor <> "" Then strStruture_Valor = strStruture_Valor & ")"

                'Comando Sql (Adicionar)
                strSql = "INSERT INTO [tblCPs] " _
                    & strStruture_Campo & strStruture_Valor

            Else
                'Comando Sql (Editar)
                strSql = "UPDATE [tblCPs] SET " & strStruture_Campo _
                    & " WHERE IdAmostra = " & IdAmostraEnsaio & " AND IdCP = " & intIdCP

            End If

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ComandoSalvar" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////
    '///////////// FORMATAR E VERIFICAR  CAMPO TEXTO ////////////////

#Region "Corpo de Prova - Verificar valores numéricos e selecionar foco"

    Private Sub txtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtPeso, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtAltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtAltura, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtCalculada0_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalculada0.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtCalculada0, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtCalculada1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalculada1.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtCalculada1, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtCapsula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapsula.KeyPress
        'Válidar valores numéricos
        'e.KeyChar = ChrW(usrDiversos.VNumerico(txtCapsula, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtCorrigida0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrigida0.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtCorrigida0, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtCorrigida1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorrigida1.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtCorrigida1, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtISC0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISC0.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtISC0, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtISC1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISC1.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtISC1, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtLeitura0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeitura0.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtLeitura0, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtLeitura1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeitura1.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtLeitura1, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtLeitura2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeitura2.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtLeitura2, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtLeitura3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeitura3.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtLeitura3, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtLeitura4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeitura4.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtLeitura4, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtMoldeFinal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMoldeFinal.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtMoldeFinal, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtSecoTara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSecoTara.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtSecoTara, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtSoloCilindro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSoloCilindro.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtSoloCilindro, Asc(e.KeyChar), True, True, False, False))
    End Sub

    Private Sub txtTara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTara.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtTara, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtUmidoTara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUmidoTara.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtUmidoTara, Asc(e.KeyChar), True, True, True, False))
    End Sub

    Private Sub txtVolume_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolume.KeyPress
        'Válidar valores numéricos
        e.KeyChar = ChrW(usrDiversos.VNumerico(txtVolume, Asc(e.KeyChar), True, True, False, False))
    End Sub

#End Region

#Region "Resultado do Ensaio"

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged

        Try
            If txtId.Text <> "" Then
                'Identificador do cp
                intIdCP = txtId.Text
                lblAlturaCP.Text = txtAltura.Text
                lblMoldeInicial.Text = txtSoloCilindro.Text

                Call FormataTabela()

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("txtId_TextChanged" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '//////////////////////////////////////////////////////////////
    '/////////////////// CALCULAR CAMPOS ENSAIO //////////////////

#Region "Calcular campos do ensaio"


#End Region

#Region "CILINDRO"

    Private Sub cmbCilindro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCilindro.SelectedIndexChanged
        Call BuscarCilindro()
    End Sub

    Public Sub CarregarCilindro()
        'Carregar os dados do cilindro
        Dim odbReader As OleDbDataReader
        Dim strSql As String

        Try

            cmbCilindro.Items.Clear()

            strSql = "SELECT * FROM tblCilindro"

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura


            While odbReader.Read()

                'Atribuir os valores 
                If Not IsDBNull(odbReader("Nome".ToString)) Then
                    cmbCilindro.Items.Add(odbReader("Nome".ToString))
                End If

            End While
            odbReader.Close()

        Catch ex As Exception
            MsgBox("CarregarCilindro()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CarregarCilindro" & Chr(13) & "CarregarCilindro" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

#End Region

#Region "CÁLCULOS DOS CAMPOS NÃO OBRIGATÓRIOS"

    Public Sub CalcularAgua()
        'Calcular o campo
        Try

            lblAgua.Text = ""

            If IsNumeric(txtUmidoTara.Text) Then
                If IsNumeric(txtSecoTara.Text) Then
                    'lblAgua.Text = FormatNumber(Double.Parse(txtUmidoTara.Text) - Double.Parse(txtSecoTara.Text, 2))
                    lblAgua.Text = txtUmidoTara.Text - txtSecoTara.Text
                    lblAgua.Text = FormatNumber(lblAgua.Text, 2)
                End If
            End If

            'Calcular campos
            Call CalcularUmidade()

        Catch ex As Exception
            MsgBox("CalcularAgua()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularAgua" & Chr(13) & "CalcularAgua" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub CalcularAguaAbsorvida()
        'Calcular o campo
        Try

            lblAguaAbsorvida.Text = ""

            If IsNumeric(txtMoldeFinal.Text) Then
                If IsNumeric(lblMoldeInicial.Text) Then
                    lblAguaAbsorvida.Text = FormatNumber(Double.Parse(txtMoldeFinal.Text) - Double.Parse(lblMoldeInicial.Text), 0)
                End If
            End If

        Catch ex As Exception
            MsgBox("CalcularAguaAbsorvida()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularAguaAbsorvida" & Chr(13) & "CalcularAguaAbsorvida" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub CalcularDiferenca(ByVal txtLeitura As TextBox)
        'Calcular o campo
        Dim dblTemp As Double
        Dim leitura As Double
        Dim primeira_leitura As Double

        If (txtLeitura0.Text <> "") Then
            primeira_leitura = Double.Parse(txtLeitura0.Text)
        ElseIf (txtLeitura0.Text = "" And txtLeitura1.Text <> "") Then
            primeira_leitura = txtLeitura1.Text
        ElseIf (txtLeitura1.Text = "" And txtLeitura2.Text <> "") Then
            primeira_leitura = txtLeitura2.Text
        ElseIf (txtLeitura2.Text = "" And txtLeitura3.Text <> "") Then
            primeira_leitura = txtLeitura3.Text
        ElseIf (txtLeitura3.Text = "" And txtLeitura4.Text <> "") Then
            primeira_leitura = txtLeitura4.Text
        End If

        Try
            If txtLeitura.Text <> "" Then
                leitura = Double.Parse(txtLeitura.Text)

                lblDiferenca.Text = ""
                dblTemp = 0

                If IsNumeric(primeira_leitura) Then 'Primeira Leitura
                    'Achar maior leitura
                    If IsNumeric(leitura) Then
                        If Abs(leitura - primeira_leitura) > dblTemp Then
                            dblTemp = Abs(leitura - primeira_leitura)
                            lblDiferenca.Text = dblTemp
                        End If
                    End If
                End If

            End If
            'Calcular campos
            Call CalcularExpansao()

        Catch ex As Exception
            MsgBox("CalcularDiferenca()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularDiferenca" & Chr(13) & "CalcularDiferenca" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub


    Public Sub CalcularExpansao()
        'Calcular o campo
        Try

            lblExpansao.Text = ""

            If IsNumeric(lblDiferenca.Text) Then
                If IsNumeric(txtAltura.Text) Then
                    If Double.Parse(txtAltura.Text) <> 0 Then
                        lblExpansao.Text = FormatNumber(Double.Parse(lblDiferenca.Text) / Double.Parse(txtAltura.Text) * 100, 2)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("CalcularExpansao()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularExpansao" & Chr(13) & "CalcularExpansao" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub CalcularMassaEspApSeca()
        'Calcular o campo
        Try

            lblMassaSeca.Text = ""

            If IsNumeric(lblMassaUmida.Text) Then
                If IsNumeric(lblUmidade.Text) Then
                    If Double.Parse(lblUmidade.Text) <> -100 Then
                        lblMassaSeca.Text = FormatNumber((Double.Parse(lblMassaUmida.Text) * 100) / (100 + Double.Parse(lblUmidade.Text)), 3)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("CalcularMassaEspApSeca()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularMassaEspApSeca" & Chr(13) & "CalcularMassaEspApSeca" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub CalcularMassaEspApUmida()
        'Calcular o campo
        Try

            lblMassaUmida.Text = ""

            If IsNumeric(lblSoloUmido.Text) Then
                If IsNumeric(txtVolume.Text) Then
                    If Double.Parse(txtVolume.Text) <> 0 Then
                        lblMassaUmida.Text = FormatNumber(Double.Parse(lblSoloUmido.Text) / Double.Parse(txtVolume.Text), 3)
                    End If
                End If
            End If

            'Calcular campos
            Call CalcularMassaEspApSeca()

        Catch ex As Exception
            MsgBox("CalcularMassaEspApUmida()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularMassaEspApUmida" & Chr(13) & "CalcularMassaEspApUmida" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub CalcularSoloSeco()
        'Calcular o campo
        Try

            lblSoloSeco.Text = ""

            If IsNumeric(txtSecoTara.Text) Then
                If IsNumeric(txtTara.Text) Then
                    lblSoloSeco.Text = FormatNumber(Double.Parse(txtSecoTara.Text) - Double.Parse(txtTara.Text), 2)
                End If
            End If

            'Calcular campos
            Call CalcularUmidade()

        Catch ex As Exception
            MsgBox("CalcularSoloSeco()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularSoloSeco" & Chr(13) & "CalcularSoloSeco" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub CalcularSoloUmido()
        'Calcular o campo
        Try

            lblSoloUmido.Text = ""

            If IsNumeric(txtPeso.Text) Then
                If IsNumeric(txtSoloCilindro.Text) Then
                    lblSoloUmido.Text = FormatNumber(Double.Parse(txtSoloCilindro.Text) - Double.Parse(txtPeso.Text), 2)
                End If
            End If

            'Calcular campos
            Call CalcularMassaEspApUmida()

        Catch ex As Exception
            MsgBox("CalcularSoloUmido()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularSoloUmido" & Chr(13) & "CalcularSoloUmido" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub CalcularUmidade()
        'Calcular o campo
        Try

            lblUmidade.Text = ""

            If IsNumeric(lblAgua.Text) Then
                If IsNumeric(lblSoloSeco.Text) Then
                    If Double.Parse(lblSoloSeco.Text) <> 0 Then
                        'lblUmidade.Text = FormatNumber(Double.Parse(lblAgua.Text) / Double.Parse(lblSoloSeco.Text) * 100, 1)
                        lblUmidade.Text = (lblAgua.Text / lblSoloSeco.Text) * 100
                        lblUmidade.Text = FormatNumber(lblUmidade.Text, 1)
                    End If
                End If
            End If

            'Calcular campos
            Call CalcularMassaEspApSeca()

        Catch ex As Exception
            MsgBox("CalcularUmidade()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("CalcularUmidade" & Chr(13) & "CalcularUmidade" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub BuscarCilindro()
        'Carregar os dados do cilindro
        Dim odbReader As OleDbDataReader
        Dim strSql As String
        Dim cilindro As String

        Try
            cilindro = cmbCilindro.Text
            strSql = "SELECT * FROM tblCilindro WHERE Nome = '" & cilindro & "'"

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura


            While odbReader.Read()
                If Not IsDBNull(odbReader("Peso".ToString)) Then txtPeso.Text = odbReader("Peso".ToString)
                If Not IsDBNull(odbReader("Volume".ToString)) Then txtVolume.Text = odbReader("Volume".ToString)
                If Not IsDBNull(odbReader("Altura".ToString)) Then txtAltura.Text = odbReader("Altura".ToString)
            End While

        Catch ex As Exception
            MsgBox("cmbCilindro_SelectedIndexChanged()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("cmbCilindro_SelectedIndexChanged" & Chr(13) & "cmbCilindro_SelectedIndexChanged" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub PreencherDatasExpansao()
        Try
            Dim dataBase As DateTime
            Dim odbReader As OleDbDataReader

            Dim strSql As String = "SELECT Data FROM tblAmostra WHERE IdAmostra = " & intIdAmostra

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura

            If odbReader IsNot Nothing AndAlso odbReader.Read() Then

                If Not IsDBNull(odbReader("Data")) Then
                    dataBase = Convert.ToDateTime(odbReader("Data"))

                    ' Preenche sequencialmente
                    mskData0.Text = dataBase.ToString("dd/MM/yyyy")
                    mskData1.Text = dataBase.AddDays(1).ToString("dd/MM/yyyy")
                    mskData2.Text = dataBase.AddDays(2).ToString("dd/MM/yyyy")
                    mskData3.Text = dataBase.AddDays(3).ToString("dd/MM/yyyy")
                    mskData4.Text = dataBase.AddDays(4).ToString("dd/MM/yyyy")
                Else
                    LimparDatas()
                End If

            Else
                LimparDatas()
            End If
        Catch ex As Exception
            MsgBox("PreencherDatasExpansao()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub LimparDatas()
        mskData0.Text = ""
        mskData1.Text = ""
        mskData2.Text = ""
        mskData3.Text = ""
        mskData4.Text = ""
    End Sub

#End Region

#Region "LOCAIS ONDE OS CÁLCULOS DOS CAMPOS NÃO OBRIGATÓRIOS SÃO CHAMADOS"

    Private Sub txtSecoTara_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSecoTara.LostFocus

        'Calcular campos
        Call CalcularAgua()
        Call CalcularSoloSeco()
    End Sub

    Private Sub txtMoldeFinal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMoldeFinal.LostFocus
        'Calcular campos
        lblMoldeInicial.Text = txtSoloCilindro.Text

        Call CalcularAguaAbsorvida()
    End Sub

    Private Sub txtSoloCilindro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSoloCilindro.LostFocus
        If IsNumeric(txtSoloCilindro.Text) Then
            If Double.Parse(txtSoloCilindro.Text) > 0 Then
                txtSoloCilindro.Text = FormatNumber(txtSoloCilindro.Text, 2)
                lblMoldeInicial.Text = FormatNumber(txtSoloCilindro.Text, 2)
                'Calcular campos
                Call CalcularAguaAbsorvida()
            End If
        End If

        'Calcular campos
        Call CalcularSoloUmido()
    End Sub

    Private Sub txtLeitura0_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLeitura0.LostFocus
        Call CalcularDiferenca(txtLeitura0)
    End Sub

    Private Sub txtLeitura1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLeitura1.LostFocus
        Call CalcularDiferenca(txtLeitura1)
    End Sub

    Private Sub txtLeitura2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLeitura2.LostFocus
        Call CalcularDiferenca(txtLeitura2)
    End Sub

    Private Sub txtLeitura3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLeitura3.LostFocus
        Call CalcularDiferenca(txtLeitura3)
    End Sub

    Private Sub txtLeitura4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLeitura4.LostFocus
        Call CalcularDiferenca(txtLeitura4)
    End Sub

    Private Sub txtAltura_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Calcular campos
        Call CalcularExpansao()
    End Sub

    Private Sub txtVolume_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVolume.LostFocus
        'Calcular campos
        Call CalcularMassaEspApUmida()
    End Sub

    Private Sub txtTara_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTara.LostFocus
        'Calcular campos
        Call CalcularSoloSeco()
    End Sub

    Private Sub txtPeso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeso.LostFocus
        'Calcular campos
        Call CalcularSoloUmido()
    End Sub

#End Region

    Private Sub btnCilindro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCilindro.Click
        frmCilindro.ShowDialog()
    End Sub

    Private Sub txtEnsaioRealizado_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnsaioRealizado.BindingContextChanged
        If txtEnsaioRealizado.Text = "True" Then
            HabilitarComandosEnsaio(False, True)
        Else
            HabilitarComandosEnsaio(True, False)
        End If
    End Sub

    Private Sub txtEnsaioRealizado_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnsaioRealizado.TextChanged
        If txtEnsaioRealizado.Text = "True" Then
            HabilitarComandosEnsaio(False, True)
        Else
            HabilitarComandosEnsaio(True, False)
        End If
    End Sub

    Private Sub txtCalculada0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCalculada0.TextChanged
        'If txtCalculada0.Text <> "" And IsNumeric(txtCalculada0.Text) Then
        '    FormatNumber(txtCalculada0.Text, 2)
        'End If
    End Sub

    Private Sub txtCalculada1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCalculada1.TextChanged
        'If txtCalculada1.Text <> "" And IsNumeric(txtCalculada1.Text) Then
        '    FormatNumber(txtCalculada1.Text, 2)
        'End If
    End Sub

    Private Sub txtCorrigida0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorrigida0.TextChanged
        'If txtCorrigida0.Text <> "" And IsNumeric(txtCorrigida0.Text) Then
        '    FormatNumber(txtCorrigida0.Text, 2)
        'End If
    End Sub

    Private Sub txtCorrigida1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorrigida1.TextChanged
        'If txtCorrigida1.Text <> "" And IsNumeric(txtCorrigida1.Text) Then
        '    FormatNumber(txtCorrigida1.Text, 2)
        'End If
    End Sub

    Private Sub txtISC0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtISC0.TextChanged
        'If txtISC0.Text <> "" And IsNumeric(txtISC0.Text) Then
        '    FormatNumber(txtISC0.Text, 2)
        'End If
    End Sub

    Private Sub txtISC1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtISC1.TextChanged
        'If txtISC1.Text <> "" And IsNumeric(txtISC1.Text) Then
        '    FormatNumber(txtISC1.Text, 2)
        'End If
    End Sub

    Private Sub txtISC2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtISC2.TextChanged
        'If txtISC2.Text <> "" And IsNumeric(txtISC2.Text) Then
        '    FormatNumber(txtISC2.Text, 2)
        'End If
    End Sub

    Private Sub lblMoldeInicial_TextChanged(sender As Object, e As EventArgs) Handles lblMoldeInicial.TextChanged

        Call CalcularAguaAbsorvida()

    End Sub

    Private Sub txtMoldeFinal_TextChanged(sender As Object, e As EventArgs) Handles txtMoldeFinal.TextChanged

        lblMoldeInicial.Text = txtSoloCilindro.Text

        Call CalcularAguaAbsorvida()

    End Sub

    Private Sub tbpPenetracao_Click(sender As Object, e As EventArgs) Handles tbpPenetracao.Click


    End Sub

    Private Sub tbcCP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcCP.SelectedIndexChanged

        If tbcCP.SelectedIndex = 2 Then
            Call FormataTabela()
        ElseIf tbcCP.SelectedIndex = 1 Then
            Call PreencherDatasExpansao()
        End If
    End Sub

    Private Sub btnBuscarCilindro_Click(sender As Object, e As EventArgs) Handles btnBuscarCilindro.Click
        Call BuscarCilindro()
    End Sub
End Class