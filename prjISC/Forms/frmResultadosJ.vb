'Janela de rever os ensaios realizados
Option Strict Off
Option Explicit On

'Importando Namespaces de Conexão
Imports System.Math
Imports System.Data.OleDb
Imports System
Imports ChartDirector


Public Class frmResultadosJ
    'Mostrar os CP's que já realizau ensaios
    'Traçar os gráficos juntos
    'Gerar gráfico do resultado final

#Region "DECLARAÇÃO DE VARIÁVEIS"
    Dim intLarguraInicial As Integer
    Dim intAlturaInicial As Integer
    Public blnGerarRelatorio As Boolean
    'Base de dados e tabelas
    Dim cnnUniversal As ADODB.Connection
    'Qte. de CPs para traçar gráfico
    Public intVetorRever() As Integer
    Dim intContVetor As Integer
    'Contador vetor gráfico
    Dim lngContador1 As Long
    Dim lngContador2 As Long
    Dim lngContador3 As Long
    'Máximo e Mínimo dos Gráficos 1 e 2
    Dim dblXMin As Double
    Dim dblXMax As Double
    Dim dblYMin(2) As Double
    Dim dblYMax(2) As Double
    'Vetor gráfico Final
    Dim intGraficoTracado As Integer
    'Preencher listagem
    Dim intContEnsaios As Integer
    'Gerar relatório
    Dim rstItens As ADODB.Recordset
    Public strListNavegacaoCPMarcados As New List(Of String)
    Public Grafico1 As New clsGraficoChart
    Public Grafico2 As New clsGraficoChart
    Public Grafico3 As New clsGraficoChart
    Public GraficoMultriplasLinhas As New clsGraficoChart
    Public graficoPavitest As New clsGraficoChart
    Dim dblListaUmidade As New List(Of Double)
    Dim dblListaMassaSeca As New List(Of Double)
    Dim dblListaExpansao As New List(Of Double)
    Dim dblLiistaISC As New List(Of Double)

    Dim dblListaEixox As New List(Of Double)
    Dim dblListaEixoy As New List(Of Double)
    Public blnMudouGrafico As Boolean
    Dim strUnidadeAnterior As String


    Dim listaOpcoesBD As New List(Of String) From {
         "expansao", '0
         "MassaSeca", '1
         "Umidade", '2
         "ISC1",
         "iSC2"
       }
    Dim listaUnidadesMedidas As New List(Of String) From {
        "%",
        "g/cm³", '0
        "%",
        "%"
    }

    Dim listaOpcoesEixo As New List(Of String) From {
        "Expansão",
        "Massa Específica Aparente Seca",
        "Umidade",
        "ISC"
    }
    Dim intVariosY1 As Integer
    Dim intVariosY2 As Integer
    Dim blnNovoY1 As Boolean

#End Region

#Region "CARREGAR E DESCARREGAR FORM"

    Private Sub frmResultado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Me.Text = strCompactacao

            Call PreencherListView()

            graficoPavitest.chartWidth = 1100
            graficoPavitest.chartHeight = 600

            'Grafico1 = graficoPavitest
            'Grafico2 = graficoPavitest
            'Grafico3 = graficoPavitest
            'Carregar a classe Gráfico
            'Gráfico Inicial

            'Habilitar comandos de rever
            Call HabilitarComandos(False, False, False, False, True)

            grpGroupEscala.Visible = False

            Grafico1.blnMarcadorPonto = True
            Grafico2.blnMarcadorPonto = True
            Grafico3.blnMarcadorPonto = True

            Grafico1.blnLinhaCurva = True
            Grafico2.blnLinhaCurva = True
            Grafico3.blnLinhaCurva = True

            'Setar gráficos
            Call SetarGraficos()

        Catch ex As Exception
            MsgBox("frmResultado_Load()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("Form_Load" & Chr(13) & "Form_Load" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

    Private Sub frmResultado_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try

            'Preencher a listagem com a quantidade de ensaios realizados


            If blnPrintarGrafico Then
                Call RetomarDimensaoGrafico()
                blnPrintarGrafico = False
            End If
            'Call PreencherListView()

        Catch ex As Exception
            MsgBox("frmResultado_Activated()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("Form_Activate" & Chr(13) & "Form_Activate" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

#End Region

    '**************************************************************
    '***************** COMANDOS DE EXECUÇÃO - REVER ***************

#Region "AÇÕES DOS BOTÕES"

    Private Sub btnAtualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Dim i As Integer

        Try

            Call LimparValores()

            ReDim Preserve intVetorRever(0)
            intContVetor = 0

            For i = 0 To intContEnsaios - 1
                If lstView.Items.Item(i).Checked = True Then
                    ReDim Preserve intVetorRever(intContVetor)
                    intVetorRever(intContVetor) = lstView.Items.Item(i).SubItems(1).Text
                    intContVetor = intContVetor + 1
                End If
            Next

            If intContVetor = 0 Then
                MsgBox("É necessário selecionar algum ensaio para rever.", vbInformation)
                Exit Sub
            End If

            'Formatando o gráfico
            Call SetarGraficos()

            System.Windows.Forms.Application.DoEvents()

            'Traçar 3 tipos de gráficos 
            Call PlotarGraficos()

            'Habilitar comandos de rever
            Call HabilitarComandos(True, True, False, True, True)

        Catch ex As Exception
            MsgBox("btnAtualizar_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub LimparValores()
        dblListaUmidade.Clear()
        dblListaMassaSeca.Clear()
        dblLiistaISC.Clear()
        dblListaExpansao.Clear()

        Grafico1.dblMaiorValorY_CBR = 0
        Grafico2.dblMaiorValorY_CBR = 0
        Grafico3.dblMaiorValorY_CBR = 0

        Grafico1.dblMenorValorY_CBR = 0
        Grafico2.dblMenorValorY_CBR = 0
        Grafico3.dblMenorValorY_CBR = 0

        Grafico1.dblMenorValorX = 0
        Grafico2.dblMenorValorX = 0
        Grafico3.dblMenorValorX = 0

        Grafico1.dblMaiorValorX = 0
        Grafico2.dblMaiorValorX = 0
        Grafico3.dblMaiorValorX = 0

    End Sub

    Private Sub btnRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorio.Click
        'Gerando relatórios

        Try

            'Autorizando geração do relatório no evento activated
            blnGerarRelatorio = True

            'Gerar o relatório
            Call GerarRelatorio()

        Catch ex As Exception
            MsgBox("btnRelatorio_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnRelatorio_Click" & Chr(13) & "btnRelatorio_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

    Public Sub FormatarGrafico()

        Try

            intOpcaoX = 10   'Opção Tempo para X
            intOpcaoY = 0   'Opção Carga Fixa para Y1
            intOpcaoY2 = -1 'Sem Y2

            'Muda status para condicionar uso de critério adicional em escala automática
            blnMudouGrafico = True

            'Parametrizar escalas manuais/automáticas e definir máximos iniciais para cada lista
            Call AtualizaOpcoesEscalas()

            'Atualiza as opções disponiveis para escolha no menu de eixos
            Call AtualizarOpcoesEixos()

            'Recompoe todas as escalas do grafico
            Call InicializarGrafico() 'Antigo --> RecomporEixos

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("FormatarGrafico" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub AtualizaOpcoesEscalas()
        'Carrega na lista de opcoes de escalas, as escalas preconfiguradas, escalas encontradas no arquivo de inicialização.
        Try

            graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = True
            ' mnuAutoEixoXEscalaMin0.Checked = True

            graficoPavitest.blnEscalaAutomaticaEixoY1MinimoZero = True
            'mnuAutoEixoY1EscalaMin0.Checked = True

            graficoPavitest.blnEscalaAutomaticaEixoY2MinimoZero = True
            'mnuAutoEixoY2EscalaMin0.Checked = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizaOpcoesEscalas" & Chr(13) & ex.Message)
        End Try
    End Sub
    Public Sub InicializarGrafico() 'Antigo -->RecomporEixos
        Try

            graficoPavitest.chartWidth = intLarguraInicialGrupoGrafico - 30
            graficoPavitest.chartHeight = intAlturaInicialGrupoGrafico - 30

            'Cria o grafico na tela e deixa ele vazio com todos os valores zerados
            graficoPavitest.createChart(GraficoResultados1)

            'graficoPavitest.AtualizarMultiplasListasResultadosVazioResultados(WinChartViewer1)

            graficoPavitest.dblVetorValorX = New List(Of Double)
            graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))
            graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))

            Call LimparListas()

            'Valores máximos
            graficoPavitest.dblScaleMaxX = 0
            graficoPavitest.dblScaleMaxY = 0
            graficoPavitest.dblScaleMaxY2 = 0

            'Divisor de escala
            graficoPavitest.AtualizarDivisores()

            'Uma troca de grandeza em Y1 implica no reset de outras possíveis curvas já existentes
            intVariosY1 = -1
            intVariosY2 = -1

            'Reinicia variável de controle
            blnNovoY1 = False

            'Eixos X e Y1
            graficoPavitest.strVetorLinhasY1 = New List(Of String)
            graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
            graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))

            'Eixo Y2
            intOpcaoY2 = -1
            graficoPavitest.strVetorLinhasY2 = New List(Of String)
            graficoPavitest.strTituloEixoY2 = strUnidadeConvertidaY2


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("InicializarGrafico" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub LimparListas()

        'obs: Usar método list.Clear() limpa também as listas que já receberam anteriormente valores proveninetes dessa lista de origem

        'Zera as listas 




    End Sub
    Private Sub AtualizarOpcoesEixos()
        '    Try
        '    Limpa as opções do menu
        'mnuEixoX1.DropDownItems.Clear()
        '  mnuEixoY1.DropDownItems.Clear()

        '    Atualiza as opções do menu
        '    For i = 0 To listaOpcoesEixo.Count - 1
        '        mnuEixoX1.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
        '        mnuEixoY1.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
        '    Next

        '    frmGraficoPavitest.AtualizarOpcoesDeListasConvertidasY2()


        'Catch ex As Exception
        '    'Mensagem de erro
        '    MsgBox("AtualizarOpcoesEixos" & Chr(13) & ex.Message)
        'End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Sair da tela de ensaio rápido
        Try

            Me.Close()

        Catch ex As Exception
            MsgBox("btnOk_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnSair_Click" & Chr(13) & "btnSair_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

#End Region

    '**************************************************************
    '***************** BARRA DE FERRAMENTAS DO REVER **************


    '*********************************************************************************
    '*************************** MENU'S DO FORM REVER ENSAIOS ************************

#Region "BOTÕES DO MENU SUPERIOR"

    Private Sub mnuSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSair.Click
        'Sair da tela de ensaio rápido
        Try

            btnOk.Focus()
            Call btnOk_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuSair_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("mnuSair_Click" & Chr(13) & "mnuSair_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

    Private Sub mnuAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAtualizar.Click
        Try

            btnAtualizar.Focus()
            Call btnAtualizar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuAtualizar_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("mnuAtualizar_Click" & Chr(13) & "mnuAtualizar_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

    Private Sub mnuRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRelatorio.Click
        Try

            btnRelatorio.Focus()
            Call btnRelatorio_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuRelatorio_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("mnuRelatorio_Click" & Chr(13) & "mnuRelatorio_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

#End Region

    '**************************************************************
    '********** EXECUTANDO OS MENU'S - COMANDO DO GRÁFICO *********

#Region "OPÇÕES DO GRÁFICO"

    Private Sub mnu0_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu0.Click
        'Girar o gráfico de acordo com o grau determinado
        Try



            Call SelecionaCampoGrau(0)

        Catch ex As Exception
            MsgBox("mnu0_Click1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("mnu0_Click" & Chr(13) & "mnu0_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

    Private Sub mnu15_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu15.Click
        'Girar o gráfico de acordo com o grau determinado
        Try



            Call SelecionaCampoGrau(15)

        Catch ex As Exception
            MsgBox("mnu15_Click1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("mnu15_Click" & Chr(13) & "mnu15_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

    Private Sub mnu30_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu30.Click
        'Girar o gráfico de acordo com o grau determinado
        Try

            Call SelecionaCampoGrau(30)

        Catch ex As Exception
            MsgBox("mnu30_Click1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("mnu30_Click" & Chr(13) & "mnu30_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

    Private Sub mnu45_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu45.Click
        'Girar o gráfico de acordo com o grau determinado
        Try



            Call SelecionaCampoGrau(45)

        Catch ex As Exception
            MsgBox("mnu45_Click1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("mnu45_Click" & Chr(13) & "mnu45_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

#End Region

    '**************************************************************
    '******************* FUNÇÕES E PROCEDIMENTOS ******************

#Region "FUNÇÕES E PROCEDIMENTOS"

    Public Sub HabilitarComandos(ByVal blnAtualizar As Boolean, ByVal blnResultado As Boolean, ByVal blnTangente As Boolean, ByVal blnRelatorio As Boolean, ByVal blnSair As Boolean)
        'Habilitar e desabilitar os comandos
        Try

            'Comando Atualizar
            btnAtualizar.Enabled = blnAtualizar
            mnuAtualizar.Enabled = blnAtualizar
            'tbrBarraFerramenta(0).Buttons(2).Enabled = blnAtualizar
            'Comando Relatório
            btnRelatorio.Enabled = blnRelatorio
            mnuRelatorio.Enabled = blnRelatorio
            'tbrBarraFerramenta(0).Buttons(4).Enabled = blnRelatorio
            'Comando sair
            btnOk.Enabled = blnSair
            mnuSair.Enabled = blnSair
            'tbrBarraFerramenta(0).Buttons(6).Enabled = blnSair

        Catch ex As Exception
            MsgBox("HabilitarComandos()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("HabilitarComandos" & Chr(13) & "HabilitarComandos" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

    Public Sub SetarGraficos()
        'Inicializando os gráficos do ensaio
        Try


            Grafico1.strTituloEixoX = listaOpcoesEixo.ElementAt(2) & " (" & listaUnidadesMedidas.ElementAt(2) & ") "
            Grafico1.strTituloEixoY = listaOpcoesEixo.ElementAt(1) & " (" & listaUnidadesMedidas.ElementAt(1) & ") "
            Grafico1.chartWidth = 1100
            Grafico1.chartHeight = 600
            Call Grafico1.createChart(GraficoResultados1)

            Grafico2.strTituloEixoX = listaOpcoesEixo.ElementAt(2) & " (" & listaUnidadesMedidas.ElementAt(2) & ") "
            Grafico2.strTituloEixoY = listaOpcoesEixo.ElementAt(0) & " (" & listaUnidadesMedidas.ElementAt(0) & ") "
            Grafico2.chartWidth = 1100
            Grafico2.chartHeight = 600
            Call Grafico2.createChart(GraficoResultados2)


            Grafico3.strTituloEixoX = listaOpcoesEixo.ElementAt(2) & " (" & listaUnidadesMedidas.ElementAt(2) & ") "
            Grafico3.strTituloEixoY = listaOpcoesEixo.ElementAt(3) & " (" & listaUnidadesMedidas.ElementAt(3) & ") "
            Grafico3.chartWidth = 1100
            Grafico3.chartHeight = 600
            Call Grafico3.createChart(GraficoResultados3)

            GraficoMultriplasLinhas.chartWidth = 1100
            GraficoMultriplasLinhas.chartHeight = 600
            Call GraficoMultriplasLinhas.createChart(graficoResultados4)

            Grafico1.dblMatrixEixoY1.Clear()
            Grafico1.dblVetorValorX.Clear()

            Grafico2.dblMatrixEixoY1.Clear()
            Grafico2.dblVetorValorX.Clear()

            Grafico3.dblMatrixEixoY1.Clear()
            Grafico3.dblVetorValorX.Clear()

        Catch ex As Exception
            MsgBox("SetarGraficos()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("SetarGrafico" & Chr(13) & "SetarGrafico" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

    Public Sub SelecionaCampoGrau(ByVal Valor As Integer)

        Try

            mnu0.Checked = False
            mnu15.Checked = False
            mnu30.Checked = False
            mnu45.Checked = False

            Select Case Valor
                Case 0 : mnu0.Checked = True
                Case 15 : mnu15.Checked = True
                Case 30 : mnu30.Checked = True
                Case 45 : mnu45.Checked = True
            End Select

        Catch ex As Exception
            MsgBox("SelecionaCampoGrau()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("SelecionaCampoGrau" & Chr(13) & "SelecionaCampoGrau" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

    Public Sub PreencherListView()
        Dim odbReader As OleDbDataReader
        Dim Sql As String
        Dim i As Integer
        Dim ItemLst As ListViewItem

        Try
            intContEnsaios = 0
            'Limpa o cabeçalho
            lstView.Items.Clear()

            'Abrir e listar os identificadores
            Sql = "SELECT IdCP FROM [tblCPs] " _
                & "WHERE IdAmostra = " & intIdAmostra

            odbReader = usrConexao.ComandoLeitura(Sql)

            'Preenche o controle listview com os dados da tabela
            While odbReader.Read
                'Atualizar contador
                intContEnsaios = intContEnsaios + 1
                ItemLst = lstView.Items.Add("CP " & odbReader("IdCP".ToString))
                'cada item precisa de um subitem para exibir na lista
                ItemLst.SubItems.Add(1)
                ItemLst.SubItems(1).Text = CStr(odbReader("IdCP".ToString)) 'Identificador
            End While
            odbReader.Close()

        Catch ex As Exception
            MsgBox("PreencherListView()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("PreencherListView" & Chr(13) & "PreencherListView" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

#End Region

    '    '**************************************************************
    '    '************* FUNÇÕES E PROCEDIMENTOS - GRÁFICOS *************

#Region "'MONTAR' OS GRÁFICOS"

    Public Sub PlotarGraficos()
        'Atibuir dados para o gráfico
        Dim odbReader As OleDbDataReader
        Dim Sql As String
        Dim i As Integer
        Dim j As Integer
        Dim intComp As Integer
        Dim intExp As Integer
        Dim intISC As Integer
        Dim dblISC As Double

        Try

            lngContador1 = 1
            i = 0
            j = 0

            intComp = 0

            'Selecionar Amostra com os Registro dos CPs
            Sql = "SELECT * FROM [tblCPs] WHERE IdAmostra = " & IdAmostraEnsaio & " ORDER BY Umidade"
            odbReader = usrConexao.ComandoLeitura(Sql)

            While odbReader.Read

                If j <= UBound(intVetorRever) Then
                    Do While Not i > UBound(intVetorRever)
                        If odbReader("IdCP".ToString) = intVetorRever(i) Then
                            If Not IsDBNull(odbReader("Umidade".ToString)) Then

                                'Popula Lista Umidade
                                dblListaUmidade.Add(odbReader("Umidade".ToString))


                                If Not IsDBNull(odbReader("MassaSeca".ToString)) Then
                                    'Gráfico 01 - Massa Seca x Umidade
                                    Call MontarGrafico1(odbReader("MassaSeca".ToString), odbReader("Umidade".ToString), intComp)
                                    'Contador de pontos no grafico
                                    intComp = intComp + 1
                                End If

                                If Not IsDBNull(odbReader("Expansao".ToString)) Then
                                    'Gráfico 02 - Expansão x Umidade
                                    Call MontarGrafico2(odbReader("Expansao".ToString), odbReader("Umidade".ToString), intExp)
                                    'Contador de pontos no grafico
                                    intExp = intExp + 1
                                End If

                                If Not IsDBNull(odbReader("ISC1".ToString)) And Not IsDBNull(odbReader("ISC2".ToString)) Then
                                    'Gráfico 03 - ISC x Umidade
                                    If odbReader("ISC1".ToString) > odbReader("ISC2".ToString) Then dblISC = odbReader("ISC1".ToString) Else dblISC = odbReader("ISC2".ToString)
                                    Call MontarGrafico3(dblISC, odbReader("Umidade".ToString), intISC)
                                    'Contador de pontos no grafico
                                    intISC = intISC + 1
                                End If


                                'Contador de CPs ja tracados
                                j = j + 1
                            End If
                            Exit Do
                        End If
                        'Contador de CPs
                        i = i + 1
                    Loop
                End If
                'Contador de CPs
                i = 0
            End While

        Catch ex As Exception
            MsgBox("PlotarGraficos()" & Chr(13) & ex.Message)
        End Try

    End Sub
    Public Sub MontarGrafico1(ByVal dblMassaSeca As Double, ByVal dblUmidade As Double, ByVal intLeitura As Integer)
        'Mostrar Gráfico 01 = Massa Seca x Umidade
        Try
            dblListaMassaSeca.Add(dblMassaSeca)
            Grafico1.dblMatrixEixoY1.Add(dblListaMassaSeca)
            Grafico1.dblVetorValorX = (dblListaUmidade)

            'Ajustes no eixo (x)

            If (dblUmidade - 2) < Grafico1.dblMenorValorX Or Grafico1.dblMenorValorX = 0 Then
                Grafico1.dblMenorValorX = dblUmidade - 2
            End If

            If dblUmidade > Grafico1.dblMaiorValorX Or Grafico1.dblMaiorValorX = 0 Then
                Grafico1.dblMaiorValorX = dblUmidade
            End If

            'ajustes no eixo (Y)

            If dblMassaSeca < Grafico1.dblMenorValorY_CBR Or Grafico1.dblMenorValorY_CBR = 0 Then
                Grafico1.dblMenorValorY_CBR = dblMassaSeca
            End If

            If dblMassaSeca > Grafico1.dblMaiorValorY_CBR Or Grafico1.dblMaiorValorY_CBR = 0 Then
                Grafico1.dblMaiorValorY_CBR = dblMassaSeca
            End If


            'Ajusta a escala dos eixos automaticamente 
            Grafico1.AjustarEscalaCBR(1)

            'Call Grafico1.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            MsgBox("MontarGrafico1()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub LimparListas(lista1 As List(Of Double), lista2 As List(Of Double))

        lista1 = New List(Of Double)
        lista2 = New List(Of Double)

    End Sub

    Public Sub MontarGrafico2(ByVal dblExpansao As Double, ByVal dblUmidade As Double, ByVal intLeitura As Integer)


        Try
            dblListaExpansao.Add(dblExpansao)
            Grafico2.dblMatrixEixoY1.Add(dblListaExpansao)
            Grafico2.dblVetorValorX = dblListaUmidade

            'Ajustes no eixo (x)

            If (dblUmidade - 2) < Grafico2.dblMenorValorX Or Grafico2.dblMenorValorX = 0 Then
                Grafico2.dblMenorValorX = dblUmidade - 2
            End If

            If dblUmidade > Grafico2.dblMaiorValorX Or Grafico2.dblMaiorValorX = 0 Then
                Grafico2.dblMaiorValorX = dblUmidade
            End If

            'ajustes no eixo (Y)

            If dblExpansao < Grafico2.dblMenorValorY_CBR Or Grafico2.dblMenorValorY_CBR = 0 Then
                Grafico2.dblMenorValorY_CBR = dblExpansao
            End If

            If dblExpansao > Grafico2.dblMaiorValorY_CBR Or Grafico2.dblMaiorValorY_CBR = 0 Then
                Grafico2.dblMaiorValorY_CBR = dblExpansao
            End If

            'Ajusta a escala dos eixos automaticamente 
            Grafico2.AjustarEscalaCBR(2)

            Call Grafico2.AtualizarGraficoMultiplasListas()

            ''Ajusta a escala dos eixos automaticamente 
            'Grafico2.AjustarEscalaAutomaticoNova()
            'Call Grafico2.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            MsgBox("MontarGrafico2()" & Chr(13) & ex.Message)
        End Try

    End Sub


    Public Sub MontarGrafico3(ByVal dblISC As Double, ByVal dblUmidade As Double, ByVal intLeitura As Integer)

        Try
            dblLiistaISC.Add(dblISC)
            Grafico3.dblMatrixEixoY1.Add(dblLiistaISC)
            Grafico3.dblVetorValorX = (dblListaUmidade)

            If (dblUmidade - 2) < Grafico3.dblMenorValorX Or Grafico3.dblMenorValorX = 0 Then
                Grafico3.dblMenorValorX = dblUmidade - 2
            End If

            If dblUmidade > Grafico3.dblMaiorValorX Or Grafico3.dblMaiorValorX = 0 Then
                Grafico3.dblMaiorValorX = dblUmidade
            End If

            'ajustes no eixo (Y)

            If dblISC < Grafico3.dblMenorValorY_CBR Or Grafico3.dblMenorValorY_CBR = 0 Then
                Grafico3.dblMenorValorY_CBR = dblISC
            End If

            If dblISC > Grafico3.dblMaiorValorY_CBR Or Grafico3.dblMaiorValorY_CBR = 0 Then
                Grafico3.dblMaiorValorY_CBR = dblISC
            End If


            'Ajusta a escala dos eixos automaticamente 
            Grafico3.AjustarEscalaCBR(3)

            Call Grafico3.AtualizarGraficoMultiplasListas()

            ''Ajusta a escala dos eixos automaticamente 
            'Grafico3.AjustarEscalaAutomaticoNova()
            'Call Grafico3.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            MsgBox("MontarGrafico3()" & Chr(13) & ex.Message)
        End Try

    End Sub

#End Region

    '*********************************************************************************
    '*************************** LISTAGEM DOS ENSAIOS REALIZADOS *********************

    Private Sub lstView_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lstView.ItemChecked
        Dim intCont As Integer

        Try

            If lstView.Items.Count > 0 Then
                For intCont = 0 To lstView.Items.Count - 1
                    If lstView.Items(intCont).Checked = True Then
                        'Habilitar comandos de rever
                        Call HabilitarComandos(True, False, False, False, True)
                        Exit Sub
                    Else
                        'Habilitar comandos de rever
                        Call HabilitarComandos(False, False, False, False, True)
                    End If
                Next
            End If

        Catch ex As Exception
            MsgBox("lstView_ItemChecked()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("lstView_ItemCheck" & Chr(13) & "lstView_ItemCheck" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

    '**************************************************************
    '***************** FUNÇÕES PARA GERAR RELATÓRIO ***************

#Region "FUNÇÕES DO RELATÓRIO"


    Public Sub GerarRelatorio()

        Try

            intRelatorio = rpt_RESULTADOS

            'frmRelatorio.strCondicao = SQLCondicao()

            blnPrintarGrafico = True

            Call ReduzirDimensaoGrafico()

            Call usrLayout.CarregarFormulario(frmRelatorio, False)


        Catch ex As Exception
            MsgBox("GerarRelatorio()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("GerarRelatorio" & Chr(13) & "GerarRelatorio" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

    End Sub

    Private Sub ReduzirDimensaoGrafico()

        intLarguraInicial = graficoPavitest.chartWidth
        intAlturaInicial = graficoPavitest.chartHeight

        Grafico1.chartWidth = 312
        Grafico1.chartHeight = 367
        intOrdemPrints = 1
        Grafico1.strTituloEixoX = "Umidade" & " (%)"
        Grafico1.strTituloEixoY = "Massa Esp. Apar. Seca" & " (g/cm³)"
        Grafico1.strTituloGrafico = Grafico1.strTituloEixoY & " x " & Grafico1.strTituloEixoX
        Grafico1.AtualizarGraficoMultiplasListas()

        Grafico2.chartWidth = 312
        Grafico2.chartHeight = 367
        intOrdemPrints = 2
        Grafico2.AtualizarGraficoMultiplasListas()

        Grafico3.chartWidth = 312
        Grafico3.chartHeight = 367
        intOrdemPrints = 3
        Grafico3.AtualizarGraficoMultiplasListas()

    End Sub

    Private Sub RetomarDimensaoGrafico()

        Grafico1.chartWidth = intLarguraInicial
        Grafico1.chartHeight = intAlturaInicial
        Grafico1.strTituloEixoY = listaOpcoesEixo.ElementAt(1) & " (" & listaUnidadesMedidas.ElementAt(1) & ") "
        Grafico1.strTituloGrafico = Grafico1.strTituloEixoY & " x " & Grafico1.strTituloEixoX
        Grafico1.AtualizarGraficoMultiplasListas()

        Grafico2.chartWidth = intLarguraInicial
        Grafico2.chartHeight = intAlturaInicial
        Grafico2.AtualizarGraficoMultiplasListas()

        Grafico3.chartWidth = intLarguraInicial
        Grafico3.chartHeight = intAlturaInicial
        Grafico3.AtualizarGraficoMultiplasListas()

    End Sub


    Private Sub AtualizarLegenda(ByRef objGrf As AxFLPGRFLib.AxFlpGrf)

        Try


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarLegenda" & Chr(13) & ex.Message)

        End Try

    End Sub


    Private Sub chkSelecionar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelecionar.CheckedChanged
        Dim blnChecked As Boolean

        Try
            If chkSelecionar.Checked = True Then blnChecked = True Else blnChecked = False

            For i = 0 To lstView.Items.Count - 1
                lstView.Items.Item(i).Checked = blnChecked
            Next
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("chkSelecionar_CheckedChanged" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub mnuMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuMenu.ItemClicked

    End Sub

    Private Sub lstView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstView.SelectedIndexChanged

    End Sub






#End Region

End Class