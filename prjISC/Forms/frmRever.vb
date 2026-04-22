Imports System.Data.OleDb
Imports System.IO
Imports ChartDirector

Public Class frmRever
#Region "Declaração de variáveis"

    Public dblISC1 As Double
    Public dblISC2 As Double
    Dim blnBuscar1 As Boolean
    Dim blnBuscar2 As Boolean
    Dim dblPLeitura1 As Double
    Dim dblPLeitura2 As Double
    Dim dblVetorPenetracao() As Double
    Dim intLarguraInicial, intAlturaInicial As Integer
    Dim intVariosY1, intVariosY2, intNovo As Integer
    Dim blnMudouGrafico, blnCarregarBD, blnNovoY2 As Boolean
    Dim strUnidadeMedidaY1 As String
    Dim blnNovoY1 As Boolean
    Dim blnHabilitarCrossHair As Boolean
    Dim blnGerarRelatorio As Boolean
    'Lista de dados para cada  leitura referente a cada eixo
    Dim listaUsarEmX As New List(Of Double)
    Dim listaUsarEmY As New List(Of Double)
    Dim listaUsarEmY2 As New List(Of Double)
#Region "Declaração das lista que armazenarão dados brutos"
    'Listas para armazenamento de dados lidos de cada CP

    Dim listaTempo As List(Of Double) = New List(Of Double)
    Dim listaCarga As List(Of Double) = New List(Of Double)

    Dim listaCargaN As List(Of Double) = New List(Of Double)
    Dim listaCargakN As List(Of Double) = New List(Of Double)
    Dim listaTensao As List(Of Double) = New List(Of Double)
    Dim listaDeformacao1 As List(Of Double) = New List(Of Double)
    Dim listaDeformacao2 As List(Of Double) = New List(Of Double)
    Dim listaDeformacao3 As List(Of Double) = New List(Of Double)
    Dim listaDeformacao4 As List(Of Double) = New List(Of Double)
    Dim listaDeformacao5 As List(Of Double) = New List(Of Double)
    Dim listaDeformacaoMedia As List(Of Double) = New List(Of Double)
    Dim listaDeformacaoEspecifica As List(Of Double) = New List(Of Double)
    Dim listaDeslocamento As List(Of Double) = New List(Of Double)
    Dim listaSetpoint As List(Of Double) = New List(Of Double)

#End Region
    Dim listaOpcoesEscalas As List(Of Double) = New List(Of Double) From {
            50,   '0 - Penetração
            500,  '1 - Carga kgf  
            0.01, '2 - Pressão 1 
            0.01} '3 - Pressao 2           


    Dim listaOpcoesEixo As New List(Of String) From {
        "Penetração",
        "Carga",
        "Pressão1",
        "Pressão2"
         }

    Dim listaUnidadesMedidas As New List(Of String) From {
       "mm",
       "kgf",
       "kgf/cm²",
       "MPa"
    } '8

    'Lista para usar em leituras do BD e variaveis
    Dim listaOpcoesBD As New List(Of String) From {
        "Penetracao",
        "Carga",
        "Pressao"
                }

    Public graficoPavitest As New clsGraficoChart
    Dim strTabela As String
    Private blnGraficoInicializado As Boolean
    Dim blnLinhaContinua As Boolean
    Dim strUnidadeAnterior As String
    Private listaCurvasPlotadas As New List(Of String)
    Private blnLinhaTracejada As Boolean
    Private dblTensaoMaxima As Double



#End Region
    Private Sub frmRever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaPenetracao = New List(Of Double)
        listaPressaokgfcm2 = New List(Of Double)
        listaPressaoMPa = New List(Of Double)
        y1 = 0
        y2 = 0
        x1 = 0
        x2 = 0

        'Pega tamanho maximizado do groupbox
        intLarguraInicialGrupoGrafico = grbGrafico.Width
        intAlturaInicialGrupoGrafico = grbGrafico.Height
        blnTelaResultados = False

        strTabela = "AMOSTRA" & intIdAmostra & "CP" & intIdCP

        'Verifica se exite a tabela
        If Not usrConexao.ExistirTabela(strTabela, False) Then
            MsgBox("Não está disponível a visualização deste ensaio!", vbInformation, "Pavitest")
            Me.Close()
            Exit Sub
        End If

        intLarguraInicialGrupoGrafico = grbGrafico.Width
        intAlturaInicialGrupoGrafico = grbGrafico.Height

        Call FormatarGrafico()

        Call VerificaResultadosBD()

        Call CarregarBD(strTabela)

        Call PlotarDadosGraficoEnsaiar()

        blnGraficoInicializado = True

        graficoPavitest.blnMarcadorPonto = True

        graficoPavitest.blnLinhaCurva = False 'Não precisaria dessa linha, o padrão ja é False

        If strTipoEnsaio = "ABNT NBR 9895" Then
            Label4.Text = "Calculada (MPa)"
            Label22.Text = "Corrigida (MPa)"
            Label23.Text = "Padrão (MPa)"
            lblLegendaPressao.Text = "Pressão (MPa)"
            txtPadrao0.Text = "6,90"
            txtPadrao1.Text = "10,35"
            lblPressao.Text = FormatNumber(listaPressaokgfcm2.Max * 0.1, 2) 'admite-se 1 kgf/cm² = 0,1 MPa
            If txtCalculada0.Text <> "" Then txtCalculada0.Text = FormatNumber(txtCalculada0.Text * 0.1, 2)
            If txtCalculada1.Text <> "" Then txtCalculada1.Text = FormatNumber(txtCalculada1.Text * 0.1, 2)
            If txtCorrigida0.Text <> "" Then txtCorrigida0.Text = FormatNumber(txtCorrigida0.Text * 0.1, 2)
            If txtCorrigida1.Text <> "" Then txtCorrigida1.Text = FormatNumber(txtCorrigida1.Text * 0.1, 2)
            'blnMudouUnidadeMPa = True
        Else
            intOpcaoY = 2
            Label4.Text = "Calculada (kgf/cm²)"
            Label22.Text = "Corrigida (kgf/cm²)"
            Label23.Text = "Padrão (kgf/cm²)"
            lblLegendaPressao.Text = "Pressão (kgf/cm²)"
            lblPressao.Text = FormatNumber(listaPressaokgfcm2.Max, 2)
            txtPadrao0.Text = "70,31"
            txtPadrao1.Text = "105,46"
            'blnMudouUnidadeMPa = False
        End If

    End Sub

    Private Sub frmGraficoPavitest_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If blnPrintarGrafico Then
            Call RetomarDimensaoGrafico()
            blnPrintarGrafico = False
        End If
    End Sub

    Private Sub VerificaResultadosBD()
        Dim strSql As String
        Dim odbReader As OleDbDataReader

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblCPs] WHERE IdAmostra = " & IdAmostraEnsaio & " AND IdCP = " & intIdCP

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            odbReader.Read()

            'Atribuir os valores 
            If Not IsDBNull(odbReader("PCorrigida1".ToString)) Then txtCorrigida0.Text = FormatNumber(odbReader("PCorrigida1".ToString), 2)
            If Not IsDBNull(odbReader("PCorrigida2".ToString)) Then txtCorrigida1.Text = FormatNumber(odbReader("PCorrigida2".ToString), 2)
            If Not IsDBNull(odbReader("PCalculada1".ToString)) Then txtCalculada0.Text = FormatNumber(odbReader("PCalculada1".ToString), 2)
            If Not IsDBNull(odbReader("PCalculada2".ToString)) Then txtCalculada1.Text = FormatNumber(odbReader("PCalculada2".ToString), 2)
            If Not IsDBNull(odbReader("ISC1".ToString)) Then txtISC0.Text = FormatNumber(odbReader("ISC1".ToString), 2)
            If Not IsDBNull(odbReader("ISC2".ToString)) Then txtISC1.Text = FormatNumber(odbReader("ISC2".ToString), 2)

            odbReader.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("VerificaResultadosBD" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub FormatarGrafico()

        Try

            intOpcaoX = 0 'Opção Tempo para X

            If strTipoEnsaio = "ABNT NBR 9895" Then
                intOpcaoY = 3
            Else
                intOpcaoY = 2
            End If

            intOpcaoY2 = -1 'Sem Y2

            'Muda status para condicionar uso de critério adicional em escala automática
            blnMudouGrafico = True

            'Parametrizar escalas manuais/automáticas e definir máximos iniciais para cada lista
            Call AtualizaOpcoesEscalas()

            'Atualiza as opções disponiveis para escolha no menu de eixos
            Call AtualizarOpcoesEixos()

            'Filtra as opções que possuem a mesma unidade da grandeza principal no eixo Y
            Call AtualizarOpcoesDeCurvasEmY1()

            'Recompoe todas as escalas do grafico
            Call InicializarGrafico() 'Antigo --> RecomporEixos

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("FormatarGrafico" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub RelatórioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioToolStripMenuItem.Click
        Try
            CarregarFormulario()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub CarregarFormulario()
        GerarRelatorio()
    End Sub

    Private Sub GerarRelatorio()

        blnPrintarGrafico = True
        Call ReduzirDimensaoGrafico()
        graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
        graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
        graficoPavitest.strVetorLinhasY1 = New List(Of String)

        graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))


        intRelatorio = rpt_ENSAIOS

        Call usrLayout.CarregarFormulario(frmRelatorio, False)

    End Sub

    Private Sub AtualizaOpcoesEscalas()
        'Carrega na lista de opcoes de escalas, as escalas preconfiguradas, escalas encontradas no arquivo de inicialização.
        Try

            graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = True
            mnuAutoEixoXEscalaMin0.Checked = True

            graficoPavitest.blnEscalaAutomaticaEixoY1MinimoZero = True
            mnuAutoEixoY1EscalaMin0.Checked = True

            graficoPavitest.blnEscalaAutomaticaEixoY2MinimoZero = True
            mnuAutoEixoY2EscalaMin0.Checked = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizaOpcoesEscalas" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub AtualizarOpcoesEixos()
        Try
            'Limpa as opções do menu
            mnuEixoX1.DropDownItems.Clear()
            mnuEixoY1.DropDownItems.Clear()

            For i = 0 To listaOpcoesEixo.Count - 1
                mnuEixoX1.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
                mnuEixoY1.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
            Next


            'Call AtualizarOpcoesDeListasConvertidasY2()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarOpcoesEixos" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub AtualizarOpcoesDeCurvasEmY1()
        'FILTRA AS OPÇÕES QUE POSSUAM A MESMA UNIDADE DA GRANDEZA PRINCIPAL DO EIXO Y
        'COLOCA ESSAS GRANDEZAS FILTRADAS NO MENU 'Adicionar Curva em Y1' OU 'Adicionar Curva em Y2'

        Dim strUnidadeMedidaY1 As String
        'Dim strUnidadeMedidaY2 As String
        Try

            strUnidadeMedidaY1 = listaUnidadesMedidas.ElementAt(intOpcaoY)

            'Limpa as opções do menu
            mnuNovaLinhaY1.DropDownItems.Clear()

            'Atualiza as opções do menu
            For i = 0 To listaUnidadesMedidas.Count - 1
                If listaUnidadesMedidas.ElementAt(i) = strUnidadeMedidaY1 Then 'And i <> intOpcaoY 
                    If graficoPavitest.strVetorLinhasY1.Contains(listaOpcoesEixo.ElementAt(i)) Then
                        Continue For
                    Else
                        mnuNovaLinhaY1.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
                    End If
                End If

            Next

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarOpcoesDeCurvasEmY1" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub InicializarGrafico() 'Antigo -->RecomporEixos
        Try

            graficoPavitest.chartWidth = intLarguraInicialGrupoGrafico - 30
            graficoPavitest.chartHeight = intAlturaInicialGrupoGrafico - 30

            'Cria o grafico na tela e deixa ele vazio com todos os valores zerados
            graficoPavitest.createChart(Me.Grafico1)

            'Limpa as listas
            graficoPavitest.dblVetorValorX = New List(Of Double)
            graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))
            graficoPavitest.listaEixoY1Tracejada = New List(Of List(Of Double))
            graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))
            listaUsarEmX = New List(Of Double)
            listaUsarEmY = New List(Of Double)
            listaUsarEmY2 = New List(Of Double)

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

            graficoPavitest.listTipoCurva.Add("Continua")

            strUnidadeAnterior = listaUnidadesMedidas.ElementAt(intOpcaoY)

            'Eixo Y2
            intOpcaoY2 = -1
            graficoPavitest.strVetorLinhasY2 = New List(Of String)
            graficoPavitest.strTituloEixoY2 = strUnidadeConvertidaY2

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("InicializarGrafico" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub RetomarDimensaoGrafico()

        graficoPavitest.chartWidth = intLarguraInicial
        graficoPavitest.chartHeight = intAlturaInicial

        graficoPavitest.dblMatrixEixoY1.Add(PreencheListaGenerica(intOpcaoY))


        graficoPavitest.AtualizarGraficoMultiplasListas()

    End Sub

    Private Sub CarregarBD(strTabela As String)
        Dim strSql As String
        Dim odbReader As OleDbDataReader
        Dim index As Integer

        Try

            strSql = "SELECT * FROM " & strTabela & " ORDER BY Carga  ASC"
            odbReader = usrConexao.ComandoLeitura(strSql)

            While odbReader.Read()
                listaPenetracao.Add(odbReader(listaOpcoesBD.ElementAt(0).ToString))
                listaCarga.Add(odbReader(listaOpcoesBD.ElementAt(1).ToString))
                listaPressaokgfcm2.Add(odbReader(listaOpcoesBD.ElementAt(2).ToString))
                listaPressaoMPa.Add(Math.Round((listaPressaokgfcm2(index) * 0.1), 2)) 'Admite-se 1 kgf/cm² = 0,1 MPa
                index += 1
            End While


            lblCarga.Text = FormatNumber(listaCarga.Max, 0)

            If strTipoEnsaio = "DNIT 172 - ME" Then
                'Pressão (kgf/cm²)
                lblLegendaPressao.Text = "Pressão (kgf/cm²)"
                lblPressao.Text = FormatNumber(listaPressaokgfcm2.Max, 2)
            Else
                'Pressão (MPa)
                lblLegendaPressao.Text = "Pressão (MPa)"
                lblPressao.Text = FormatNumber(listaPressaokgfcm2.Max * 0.1, 2)
            End If

            lblPenetracao.Text = FormatNumber(listaPenetracao.Max, 3)

            odbReader.Close()

            Call AtualizaListaDoGrafico()

            blnCarregarBD = True

        Catch ex As Exception
            MsgBox("CarregarBD" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub AtualizaListaDoGrafico()
        'ALIMENTA O VETOR X E VETOR Y COM A LISTA DE DADOS SELECIONADA (TEMPO REAL OU BD)
        Dim intY1Novo, intY2Novo As Integer

        graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))
        graficoPavitest.dblVetorValorX = PreencheListaGenerica(intOpcaoX)
        For Each nomeY As String In graficoPavitest.strVetorLinhasY1
            intY1Novo = listaOpcoesEixo.IndexOf(nomeY)
            graficoPavitest.dblMatrixEixoY1.Add(PreencheListaGenerica(intY1Novo))
            listaUsarEmY = PreencheListaGenerica(intOpcaoY)
        Next

        'Se o eixo Y2 está exibindo a escala com uma grandeza independe de Y1
        If intOpcaoY2 <> -1 And intOpcaoY2 <> -11 Then
            graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))

            'Carrega uma lista de uma grandeza padrão
            For Each nomeY2 As String In graficoPavitest.strVetorLinhasY2
                intY2Novo = listaOpcoesEixo.IndexOf(nomeY2)
                graficoPavitest.dblMatrixEixoY2.Add(PreencheListaGenerica(intY2Novo))
                listaUsarEmY2 = PreencheListaGenerica(intOpcaoY2)
            Next

        End If
    End Sub

    Public Sub PlotarDadosGraficoEnsaiar()
        'TRAÇA O GRÁFICO COM AS LISTAS SELECIONADAS
        Try
            If blnEscalaManualX = False And blnEscalaManualY1 = False And blnEscalaManualY2 = False Then

                graficoPavitest.dblScaleMinX = 0

                'Atualiza as escalas máximas para 0 para depois se reajustarem automáticamente
                graficoPavitest.dblScaleMaxX = 0
                graficoPavitest.dblScaleMaxY = 0

                'Analisar sugestão de mudança de critério da escala automática caso contenha valor menor que zero e esteja configurado para exibir o mínimo igual a 0
                Call CriterioAdicionalEscalaAutomaticaInicial()

                'Ajusta a escala dos eixos automaticamente 
                graficoPavitest.AjustarEscalaAutomaticoNova()

            End If

            'Atualizar os títulos dos eixos de acordo com a opção escolhida para X e Y1
            graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "

            ''Atualiza o títulos do eixo Y2 de acordo com a opção escolhida
            If intOpcaoY2 = -11 Then
                graficoPavitest.strTituloEixoY2 = strUnidadeConvertidaY2
            ElseIf intOpcaoY2 <> -1 Then
                graficoPavitest.strTituloEixoY2 = listaOpcoesEixo.ElementAt(intOpcaoY2) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY2) & ") "
            Else
                graficoPavitest.strTituloEixoY2 = ""
            End If

            graficoPavitest.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub CriterioAdicionalEscalaAutomaticaInicial()
        Try
            'Analisar sugestão de mudança de critério da escala automática caso contenha valor menor que zero e esteja configurado para exibir o mínimo igual a 0
            If listaUsarEmY.Count > 0 Then
                If listaUsarEmY.Min < 0 And mnuAutoEixoY1EscalaMin0.Checked = True Then
                    'Sugerir mudança de default
                    mnuAutoEixoY1EscalaMinMenor.Checked = True
                    mnuAutoEixoY1EscalaMin0.Checked = False
                    graficoPavitest.blnEscalaAutomaticaEixoY1MinimoZero = False
                End If
            End If

            If listaUsarEmY2.Count > 0 Then
                If listaUsarEmY2.Min < 0 And mnuAutoEixoY2EscalaMin0.Checked = True Then
                    'Sugerir mudança de default
                    mnuAutoEixoY2EscalaMinMenor.Checked = True
                    mnuAutoEixoY2EscalaMin0.Checked = False
                    graficoPavitest.blnEscalaAutomaticaEixoY2MinimoZero = False
                End If
            End If

            If graficoPavitest.dblVetorValorX.Count > 0 Then
                If graficoPavitest.dblVetorValorX.Min < 0 And mnuAutoEixoXEscalaMin0.Checked = True Then
                    'Sugerir mudança de default
                    mnuAutoEixoXEscalaMinMenor.Checked = True
                    mnuAutoEixoXEscalaMin0.Checked = False
                    graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = False
                End If
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CriterioAdicionalEscalaAutomaticaInicial" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Function PreencheListaGenerica(intNovo As Integer) As List(Of Double)

        Dim listaAtual As List(Of Double)
        listaAtual = New List(Of Double)
        Try
            Select Case intNovo
                Case 0
                    listaAtual = listaPenetracao
                Case 1
                    listaAtual = listaCarga
                Case 2
                    listaAtual = listaPressaokgfcm2
                Case 3
                    listaAtual = listaPressaoMPa

            End Select

            PreencheListaGenerica = listaAtual

        Catch ex As Exception
            MsgBox("PreencheListaGenerica" & Chr(13) & ex.Message)
        End Try
    End Function

#Region "Eixos"
    Private Sub RemoverEixoY2(ByVal blnAtualizarEixos As Boolean)
        Try
            intOpcaoY2 = -1
            graficoPavitest.strVetorLinhasY2 = New List(Of String)
            graficoPavitest.strTituloEixoY2 = ""
            graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))
            listaUsarEmY2 = New List(Of Double)

            If blnAtualizarEixos Then Call AtualizaEixos()

        Catch ex As Exception
            MsgBox("RemoverEixoY2()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub AtualizaEixos()

        Try
            'Se mudou a opção do eixo no rever consulta novamente o banco de dados
            If blnReverEnsaio Then

                If blnCarregarBD Then

                    Call AtualizaListaDoGrafico()

                    Call PlotarDadosGraficoEnsaiar()

                Else
                    strTabela = "AMOSTRA" & intIdAmostra & "CP" & intIdCP
                    Call CarregarBD(strTabela)
                End If

            Else 'Se mudou a opção do eixo durante o ensaio atualiza os titulos e escalas padrão do grafico

                Call AtualizaListaDoGrafico()

                'Apenas atualiza os titulos do grafico de acordo com a opção escolhida
                graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
                graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "

                'Deixar escalas máximas padrão de acordo com a opção escolhida
                graficoPavitest.dblScaleMaxX = listaOpcoesEscalas.ElementAt(intOpcaoX)
                graficoPavitest.dblScaleMaxY = listaOpcoesEscalas.ElementAt(intOpcaoY)

                'Escala mínima do eixo Y1
                If listaUsarEmY.Count > 0 Then

                    graficoPavitest.dblScaleMinY = 0
                    graficoPavitest.dblScaleMinX = 0
                    graficoPavitest.dblScaleMaxY = 0
                    graficoPavitest.dblScaleMaxX = 0

                    'Ajusta a escala dos eixos automaticamente 
                    graficoPavitest.AjustarEscalaAutomaticoNova()

                End If

                If intOpcaoY2 = -11 Then  'Opção do eixo Y2 com unidades convertidas em relação ao eixo Y1
                    graficoPavitest.strTituloEixoY2 = strUnidadeConvertidaY2
                ElseIf intOpcaoY2 <> -1 Then 'Opção do eixo Y2 com uma grandeza escolhida de forma independente de Y1
                    graficoPavitest.strTituloEixoY2 = listaOpcoesEixo.ElementAt(intOpcaoY2) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY2) & ") "
                    graficoPavitest.dblScaleMaxY2 = listaOpcoesEscalas.ElementAt(intOpcaoY2)
                    graficoPavitest.dblMatrixEixoY2.Add(PreencheListaGenerica(intOpcaoY2))
                    listaUsarEmY2 = PreencheListaGenerica(intOpcaoY2)
                Else 'Não exibe eixo Y2
                    graficoPavitest.strTituloEixoY2 = ""
                End If

                graficoPavitest.AtualizarGraficoMultiplasListas()

            End If

        Catch ex As Exception
            MsgBox("AtualizaEixos" & Chr(13) & ex.Message)
        End Try

    End Sub



    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RecomporEixoX()
        Try

            graficoPavitest.dblScaleMaxX = listaOpcoesEscalas.ElementAt(intOpcaoX)
            graficoPavitest.dblScaleMinX = 0
            graficoPavitest.AtualizarDivisores()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("RecomporEixoX" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub RecomporEixoY1()
        Try

            'Uma troca de grandeza em Y1 implica no reset de outras possíveis curvas já existentes
            intVariosY1 = -1
            graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))
            listaUsarEmY = New List(Of Double)

            graficoPavitest.strVetorLinhasY1 = New List(Of String)
            graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "

            If blnReverEnsaio Then
                graficoPavitest.dblScaleMaxY = 0
            Else
                graficoPavitest.dblScaleMaxY = listaOpcoesEscalas.ElementAt(intOpcaoY)
            End If

            graficoPavitest.dblScaleMinY = 0

            'Se o eixo Y2 foi plotado com grandezas convertidas, logo ele deverá ser limpo também.
            'If intOpcaoY2 = -11 Then Call RemoverEixoY2(False)

            graficoPavitest.AtualizarDivisores()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("RecomporEixoY1" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub RecomporEixoY2()
        Try

            'Uma troca de grandeza em Y2 implica no reset de outras possíveis curvas já existentes
            intVariosY2 = -1
            graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))
            listaUsarEmY2 = New List(Of Double)

            graficoPavitest.strVetorLinhasY2 = New List(Of String)
            graficoPavitest.strVetorLinhasY2.Add(listaOpcoesEixo.ElementAt(intOpcaoY2))
            graficoPavitest.strTituloEixoY2 = listaOpcoesEixo.ElementAt(intOpcaoY2) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY2) & ") "

            If blnReverEnsaio Then
                graficoPavitest.dblScaleMaxY2 = 0
            Else
                graficoPavitest.dblScaleMaxY2 = listaOpcoesEscalas.ElementAt(intOpcaoY2)
            End If

            graficoPavitest.dblScaleMinY2 = 0
            graficoPavitest.AtualizarDivisores()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("RecomporEixoY2" & Chr(13) & ex.Message)
        End Try

    End Sub


    Private Sub mnuEixoX1_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuEixoX1.DropDownItemClicked
        Try

            Dim strOpcaoX As String
            strOpcaoX = e.ClickedItem.Text

            For Each item In listaOpcoesEixo
                If strOpcaoX.Contains(item) Then
                    intOpcaoX = listaOpcoesEixo.IndexOf(item)
                End If
            Next

            blnEscalaManualX = False
            mnuManualX.Checked = False
            mnuAutoEixoX.Checked = True
            'Atualiza Titulos dos eixos e também as escalas.
            Call AtualizaEixos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuEixoX1_DropDownItemClicked" & Chr(13) & ex.Message)
        End Try

    End Sub
    Private Sub mnuEixoY1_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuEixoY1.DropDownItemClicked
        Try
            Dim strOpcaoY As String
            strOpcaoY = e.ClickedItem.Text

            For Each item In listaOpcoesEixo
                If strOpcaoY.Contains(item) Then
                    intOpcaoY = listaOpcoesEixo.IndexOf(item)
                End If
            Next

            'Sinaliza a troca do eixo Y principal
            blnNovoY1 = True
            blnEscalaManualY1 = False
            mnuManualY1.Checked = False
            mnuAutoEixoY1.Checked = True

            listaCurvasPlotadas.Clear()
            'Adiciona curva principal a lista de plotadas
            listaCurvasPlotadas.Add(listaOpcoesEixo.ElementAt(intOpcaoY))

            'Muda status para condicionar uso de critério adicional em escala automática
            blnMudouGrafico = True

            'Recompoe todas as escalas do grafico
            Call RecomporEixoY1()

            'Atualiza Titulos dos eixos e também as escalas.
            Call AtualizaEixos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuEixoY1_DropDownItemClicked" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub mnuNovaLinhaY1_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuNovaLinhaY1.DropDownItemClicked
        Dim intYNovo As Integer
        Dim strOpcaoY As String
        blnLinhaTracejada = False

        strOpcaoY = e.ClickedItem.Text

        For Each item In listaOpcoesEixo
            If strOpcaoY.Contains(item) Then
                intYNovo = listaOpcoesEixo.IndexOf(item)
            End If
        Next

        'Se a grandeza escolhida já está na lista de opções, sai da subrotina
        If graficoPavitest.strVetorLinhasY1.Contains(listaOpcoesEixo.ElementAt(intYNovo)) Then
            Exit Sub
        End If

        'Adiciona grandeza escolhida como uma nova curva para o eixo Y1
        graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intYNovo))
        graficoPavitest.listTipoCurva.Add("Continua")
        listaCurvasPlotadas.Add(listaOpcoesEixo.ElementAt(intYNovo))
        If graficoPavitest.strVetorLinhasY1.Count > 1 Then blnExibirLegenda = True Else blnExibirLegenda = False

        'Muda status para condicionar uso de critério adicional em escala automática
        blnMudouGrafico = True

        'Se for modo rever ensaio
        If blnReverEnsaio Then

            'Carrega lista de dados provinda do BD
            listaUsarEmY = PreencheListaGenerica(intYNovo)

            'Repassa para o vetor do eixo Y1 os valores da lista carregada
            graficoPavitest.dblMatrixEixoY1.Add(listaUsarEmY)
            graficoPavitest.listaEixoY1Tracejada.Add(listaUsarEmY)

            If blnEscalaManualX = False And blnEscalaManualY1 = False And blnEscalaManualY2 = False Then

                Call CriterioAdicionalEscalaAutomaticaInicial()

                'Ajusta a escala dos eixos automaticamente 
                graficoPavitest.AjustarEscalaAutomaticoNova()
            End If

        End If

        'Plota a nova curva no gráfico
        graficoPavitest.AtualizarGraficoMultiplasListas()

        'Sinaliza que já existe mais de uma curva no eixo Y1
        intVariosY1 = 1
        'Sinaliza que não houve a troca de Y1 principal
        blnNovoY1 = False

        'FILTRA AS OPÇÕES RESTANTES QUE POSSU
        Call AtualizarOpcoesDeCurvasEmY1()
    End Sub

    Private Sub mnuNovaLinhaY1_MouseEnter(sender As Object, e As EventArgs) Handles mnuNovaLinhaY1.MouseEnter
        Try

            'FILTRA AS OPÇÕES RESTANTES QUE POSSUAM A MESMA UNIDADE DA GRANDEZA PRINCIPAL DO EIXO Y
            Call AtualizarOpcoesDeCurvasEmY1()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuNovaLinhaY1_MouseEnter" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuEixoY2_MouseEnter(sender As Object, e As EventArgs) Handles mnuEixoY2.MouseEnter

        If mnuEixoY2.DropDownItems.Count = 1 Then
            'Atualiza as opções do menu
            For i = 0 To listaOpcoesEixo.Count - 1
                mnuEixoY2.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
            Next
        End If
    End Sub

    Private Sub mnuEixoY2_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuEixoY2.DropDownItemClicked

        Dim strOpcaoY2 As String
        'blnEscalaManualY2 = True
        'Pega o título da opção clicada
        strOpcaoY2 = e.ClickedItem.Text

        'Impede que o código prossiga ao clicar no mnu de grandeza convertida
        If strOpcaoY2 = "Grandeza Convertida" Then Exit Sub

        'Remove totalmente o eixo Y2
        If strOpcaoY2 = "Remover Eixo Y2" Then Call RemoverEixoY2(True) : Exit Sub

        'Carrega o índice da curva a ser plotada
        For Each item In listaOpcoesEixo
            If strOpcaoY2.Contains(item) Then
                intOpcaoY2 = listaOpcoesEixo.IndexOf(item)

                Exit For
            End If
        Next

        'Limpa a escalas mínima e máxima para Y2
        graficoPavitest.dblScaleMaxY2 = 0
        graficoPavitest.dblScaleMinY2 = 0

        'Sinaliza a troca do eixo Y principal
        blnNovoY2 = True

        'Muda status para condicionar uso de critério adicional em escala automática
        blnMudouGrafico = True
        blnEscalaManualY2 = False
        mnuManualY2.Checked = False
        mnuAutoEixoY2.Checked = True

        Call RecomporEixoY2()

        'Atualiza Titulos dos eixos e também as escalas.
        Call AtualizaEixos()

    End Sub

#End Region

#Region "Escalas"
    Private Sub AplicaEscalaAutomatica()
        Try

            Call graficoPavitest.AjustarEscalaAutomaticoNova()

            'If intOpcaoY2 = -1 Or intOpcaoY2 = -11 Then
            Call graficoPavitest.AtualizarGraficoMultiplasListas()
            'Else
            'Call graficoPavitest.AtualizarGraficoY1Y2Independentes()
            'End If

        Catch ex As Exception
            MsgBox("AplicaEscalaAutomatica()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub
    Private Sub mnuAutoEixoXEscalaMin0_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoXEscalaMin0.Click
        Try

            graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = True

            mnuAutoEixoX.Checked = True
            mnuAutoEixoXEscalaMinMenor.Checked = False

            blnEscalaManualX = False

            'Reinicia eixo para calcular automático na classe chart
            graficoPavitest.dblScaleMinX = 0
            graficoPavitest.dblScaleMaxX = 0

            Call AplicaEscalaAutomatica()

            mnuManualX.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoXEscalaMin0_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub mnuAutoEixoXEscalaMinMenor_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoXEscalaMinMenor.Click
        Try

            graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = False

            mnuAutoEixoX.Checked = True
            mnuAutoEixoXEscalaMin0.Checked = False

            blnEscalaManualX = False

            ''Reinicia eixo para calcular automático na classe chart
            graficoPavitest.dblScaleMinY = 0
            graficoPavitest.dblScaleMaxX = 0

            Call AplicaEscalaAutomatica()

            mnuManualX.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoXEscalaMinMenor_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub

    Private Sub mnuAutoEixoY1EscalaMin0_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoY1EscalaMin0.Click
        Try

            graficoPavitest.blnEscalaAutomaticaEixoY1MinimoZero = True

            mnuAutoEixoY1.Checked = True
            mnuAutoEixoY1EscalaMinMenor.Checked = False

            blnEscalaManualY1 = False

            'Reinicia eixo para calcular automático na classe chart
            graficoPavitest.dblScaleMinY = 0
            graficoPavitest.dblScaleMaxY = 0

            Call AplicaEscalaAutomatica()

            mnuManualY1.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoY1EscalaMin0_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub mnuAutoEixoY1EscalaMinMenor_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoY1EscalaMinMenor.Click
        Try

            graficoPavitest.blnEscalaAutomaticaEixoY1MinimoZero = False

            mnuAutoEixoY1.Checked = True
            mnuAutoEixoY1EscalaMin0.Checked = False

            blnEscalaManualY1 = False

            'Reinicia eixo para calcular automático na classe chart
            graficoPavitest.dblScaleMinY = 0
            graficoPavitest.dblScaleMaxY = 0

            Call AplicaEscalaAutomatica()

            mnuManualY1.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoY1EscalaMinMenor_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub txtSubdivisaoX_Click(sender As Object, e As EventArgs) Handles txtSubdivisaoX.Click
        Try

            If txtMinimoX.Text <> "" And txtMaximoX.Text <> "" Then

                txtSubdivisaoX.Text = Math.Abs(txtMaximoX.Text - txtMinimoX.Text) / 10

            End If

        Catch ex As Exception
            MsgBox("txtSubdivisaoX_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub

    Private Sub mnuAutoEixoY2EscalaMin0_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoY2EscalaMin0.Click
        Try

            graficoPavitest.blnEscalaAutomaticaEixoY2MinimoZero = True

            mnuAutoEixoY2.Checked = True
            mnuAutoEixoY2EscalaMinMenor.Checked = False

            blnEscalaManualY2 = False

            Call AplicaEscalaAutomatica()

            mnuManualY2.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoY2EscalaMin0_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub mnuAutoEixoY2EscalaMinMenor_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoY2EscalaMinMenor.Click

        Try
            graficoPavitest.blnEscalaAutomaticaEixoY2MinimoZero = False

            mnuAutoEixoY2.Checked = True
            mnuAutoEixoY2EscalaMin0.Checked = False

            blnEscalaManualY2 = False

            Call AplicaEscalaAutomatica()

            mnuManualY2.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoY2EscalaMinMenor_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub btnAplicarAjustesEscalaX_Click(sender As Object, e As EventArgs) Handles btnAplicarAjustesEscalaX.Click
        Try

            If txtMinimoX.Text = "" And txtMaximoX.Text = "" Then Exit Sub
            blnEscalaManualX = True
            mnuManualX.Checked = True
            mnuAutoEixoX.Checked = False

            mnuAutoEixoXEscalaMin0.Checked = False
            mnuAutoEixoXEscalaMinMenor.Checked = False
            DesmarcaSubMenusEscalaAutomaticaX()

            If CDbl(txtMinimoX.Text) > CDbl(txtMaximoX.Text) Then
                'Evita que ordem seja invertida pelo usuário
                graficoPavitest.dblScaleMaxX = txtMaximoX.Text
                graficoPavitest.dblScaleMinX = txtMinimoX.Text
            Else
                'Situação normal
                graficoPavitest.dblScaleMinX = txtMinimoX.Text
                graficoPavitest.dblScaleMaxX = txtMaximoX.Text
            End If
            graficoPavitest.dblDivisaoEscalaX = txtSubdivisaoX.Text


            Call graficoPavitest.AtualizarGraficoMultiplasListas()


        Catch ex As Exception
            MsgBox("btnAplicarAjustesEscalaX_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub btnAplicarAjustesEscalaY1_Click(sender As Object, e As EventArgs) Handles btnAplicarAjustesEscalaY1.Click

        Try

            If txtMinimoY1.Text = "" And txtMaximoY1.Text = "" Then Exit Sub

            blnEscalaManualY1 = True

            mnuManualY1.Checked = True
            mnuAutoEixoY1.Checked = False

            Call DesmarcaSubMenusEscalaAutomaticaY1()

            If CDbl(txtMinimoY1.Text) > CDbl(txtMaximoY1.Text) Then
                'Evita que ordem seja invertida pelo usuário
                graficoPavitest.dblScaleMinY = txtMaximoY1.Text
                graficoPavitest.dblScaleMaxY = txtMinimoY1.Text
            Else
                'Situação normal
                graficoPavitest.dblScaleMinY = txtMinimoY1.Text
                graficoPavitest.dblScaleMaxY = txtMaximoY1.Text
            End If

            'Subidivisões
            graficoPavitest.dblDivisaoEscalaY = txtSubdivisaoY1.Text

            'If intOpcaoY2 = -1 Or intOpcaoY2 = -11 Then
            Call graficoPavitest.AtualizarGraficoMultiplasListas()
            'Else
            'Call graficoPavitest.AtualizarGraficoY1Y2Independentes()
            'End If

        Catch ex As Exception
            MsgBox("btnAplicarAjustesEscalaY1_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub btnAplicarAjustesEscalaY2_Click(sender As Object, e As EventArgs) Handles btnAplicarAjustesEscalaY2.Click
        Try

            If txtMinimoY2.Text = "" And txtMaximoY2.Text = "" Then Exit Sub

            blnEscalaManualY2 = False

            mnuManualY2.Checked = True
            mnuAutoEixoY2.Checked = False

            Call DesmarcaSubMenusEscalaAutomaticaY2()

            If CDbl(txtMinimoY2.Text) > CDbl(txtMaximoY2.Text) Then
                'Evita que ordem seja invertida pelo usuário
                graficoPavitest.dblScaleMinY2 = txtMaximoY2.Text
                graficoPavitest.dblScaleMaxY2 = txtMinimoY2.Text
            Else
                'Situação normal
                graficoPavitest.dblScaleMinY2 = txtMinimoY2.Text
                graficoPavitest.dblScaleMaxY2 = txtMaximoY2.Text
            End If

            'Subdivisões
            graficoPavitest.dblDivisaoEscalaY2 = txtSubdivisaoY2.Text

            'If intOpcaoY2 = -1 Or intOpcaoY2 = -11 Then
            Call graficoPavitest.AtualizarGraficoMultiplasListas()
            'Else
            'Call graficoPavitest.AtualizarGraficoY1Y2Independentes()
            'End If

        Catch ex As Exception
            MsgBox("btnAplicarAjustesEscalaY2_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub DesmarcaSubMenusEscalaAutomaticaX()
        Try

            mnuAutoEixoXEscalaMin0.Checked = False
            mnuAutoEixoXEscalaMinMenor.Checked = False

        Catch ex As Exception
            MsgBox("DesmarcaSubMenusEscalaAutomaticaX()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub

    Private Sub DesmarcaSubMenusEscalaAutomaticaY1()
        Try

            mnuAutoEixoY1EscalaMin0.Checked = False
            mnuAutoEixoY1EscalaMinMenor.Checked = False

        Catch ex As Exception
            MsgBox("DesmarcaSubMenusEscalaAutomaticaY1()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub

    Private Sub DesmarcaSubMenusEscalaAutomaticaY2()
        Try

            mnuAutoEixoY2EscalaMin0.Checked = False
            mnuAutoEixoY2EscalaMinMenor.Checked = False

        Catch ex As Exception
            MsgBox("DesmarcaSubMenusEscalaAutomaticaY2()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub


    Private Sub txtMaximoX_LosFocus(sender As Object, e As EventArgs) Handles txtMaximoX.LostFocus
        Try

            If txtMinimoX.Text <> "" And txtMaximoX.Text <> "" Then

                txtSubdivisaoX.Text = Math.Abs(txtMaximoX.Text - txtMinimoX.Text) / 10

            End If

        Catch ex As Exception
            MsgBox("txtMaximoX_LosFocus()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub txtMaximoY1_LosFocus(sender As Object, e As EventArgs) Handles txtMaximoY1.LostFocus
        Try

            If txtMinimoY1.Text <> "" And txtMaximoY1.Text <> "" Then

                txtSubdivisaoY1.Text = Math.Abs(txtMaximoY1.Text - txtMinimoY1.Text) / 10

            End If

        Catch ex As Exception
            MsgBox("txtMaximoY1_LosFocus()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub txtMaximoY2_LosFocus(sender As Object, e As EventArgs) Handles txtMaximoY2.LostFocus
        Try

            If txtMinimoY2.Text <> "" And txtMaximoY2.Text <> "" Then

                txtSubdivisaoY2.Text = Math.Abs(txtMaximoY2.Text - txtMinimoY2.Text) / 10

            End If

        Catch ex As Exception
            MsgBox("txtMaximoY2_LosFocus()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try

    End Sub

    Private Sub Grafico1_MouseClick(sender As Object, e As MouseEventArgs) Handles Grafico1.MouseClick

        If strSentidoZoom = "ZoomIn" Then
            intZoom += 1
        ElseIf strSentidoZoom = "ZoomOut" Then
            intZoom -= 1
        Else
            Exit Sub
        End If

        coordenada_X_pixels = Grafico1.ChartMouseX
        coordenada_Y_pixels = Grafico1.ChartMouseY

        If intZoom > 0 And intZoom <= 5 Then
            graficoPavitest.blnZoomLupa = True
            tlsZoomOut.Enabled = True
            Call graficoPavitest.AtualizarGraficoMultiplasListas()
        End If

        If intZoom >= 5 Then
            tlsZoomIn.Enabled = False
            tlsZoomOut.Enabled = True
            graficoPavitest.SelecionarModoZoom(Grafico1, WinChartMouseUsage.Default)
        End If

        If intZoom <= 0 Then
            tlsZoomOut.Enabled = False
            tlsZoomCancel_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Grafico1_MouseMove(sender As Object, e As MouseEventArgs) Handles Grafico1.MouseMove

        Dim viewer As WinChartViewer = sender

        If blnHabilitarCrossHair Then
            graficoPavitest.crossHair(viewer.Chart, viewer.PlotAreaMouseX, viewer.PlotAreaMouseY)
            viewer.updateDisplay()
            ' Hide the track cursor when the mouse leaves the plot area
            viewer.removeDynamicLayer("MouseLeavePlotArea")

        End If
    End Sub

    Private Sub tlsCrossHair_Click_1(sender As Object, e As EventArgs) Handles tlsCrossHair.Click

        If tlsCrossHair.Text = "CoordenadasOn" Then
            blnHabilitarCrossHair = False
            tlsCrossHair.Text = "CoordenadasOff"

        Else
            blnHabilitarCrossHair = True
            tlsCrossHair.Text = "CoordenadasOn"
        End If


    End Sub

    Private Sub mnuAutoTodosEixos_Click(sender As Object, e As EventArgs) Handles mnuAutoTodosEixos.Click
        Try

            If mnuAutoTodosEixos.Checked Then

                Call DestacaMenusEscalaManual(False, False, False, False)
                Call DestacaMenusEscalaAutomatica(True, True, True, True)

                blnEscalaManualX = False
                blnEscalaManualY1 = False
                blnEscalaManualY2 = False

                'Reinicia todos os eixos para calculo automatico
                graficoPavitest.dblScaleMinY = 0
                graficoPavitest.dblScaleMinY2 = 0
                graficoPavitest.dblScaleMinX = 0

                graficoPavitest.dblScaleMaxY = 0
                graficoPavitest.dblScaleMaxY2 = 0
                graficoPavitest.dblScaleMaxX = 0

                Call AplicaEscalaAutomatica()

            Else

                Call DestacaMenusEscalaAutomatica(False, False, False, False)

                blnEscalaManualX = True
                blnEscalaManualY1 = True
                blnEscalaManualY2 = True

            End If

        Catch ex As Exception
            MsgBox("mnuAutoTodosEixos_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub

    Private Sub DestacaMenusEscalaAutomatica(ByVal blnX As Boolean, ByVal blnY1 As Boolean, ByVal blnY2 As Boolean, ByVal blnTodos As Boolean)
        Try

            If blnX = True Then
                mnuAutoEixoX.Checked = True
            Else
                mnuAutoEixoX.Checked = False
                mnuAutoEixoXEscalaMin0.Checked = False
                mnuAutoEixoXEscalaMinMenor.Checked = False

            End If

            If blnY1 = True Then
                mnuAutoEixoY1.Checked = True
            Else
                mnuAutoEixoY1.Checked = False
                mnuAutoEixoY1EscalaMin0.Checked = False
                mnuAutoEixoY1EscalaMinMenor.Checked = False
            End If

            If blnY2 = True Then
                mnuAutoEixoY2.Checked = True
            Else
                mnuAutoEixoY2.Checked = False
                mnuAutoEixoY2EscalaMin0.Checked = False
                mnuAutoEixoY2EscalaMinMenor.Checked = False
            End If

            If blnTodos = True Then
                mnuAutoTodosEixos.Checked = True
            Else
                mnuAutoTodosEixos.Checked = False
            End If

        Catch ex As Exception
            MsgBox("DestacaMenusEscalaAutomatica()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub
    Private Sub DestacaMenusEscalaManual(ByVal blnX As Boolean, ByVal blnY1 As Boolean, ByVal blnY2 As Boolean, ByVal blnTodos As Boolean)
        Try

            If blnX = True Then
                mnuManualX.Checked = True
            Else
                mnuManualX.Checked = False
            End If

            If blnY1 = True Then
                mnuManualY1.Checked = True
            Else
                mnuManualY1.Checked = False
            End If

            If blnY2 = True Then
                mnuManualY2.Checked = True
            Else
                mnuManualY2.Checked = False
            End If

            If blnTodos = True Then
                mnuManualX.Checked = True
                mnuManualY1.Checked = True
                mnuManualY2.Checked = True
            Else
                mnuManualX.Checked = False
                mnuManualY1.Checked = False
                mnuManualY2.Checked = False
            End If

        Catch ex As Exception
            MsgBox("DestacaMenusEscalaManual()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub


#End Region

#Region "Zoom"

    Private Sub tlsZoomIn_Click(sender As Object, e As EventArgs) Handles tlsZoomIn.Click
        Try

            intNumeroCurvaZoom = 0
            graficoPavitest.SelecionarModoZoom(Grafico1, WinChartMouseUsage.ZoomIn)

            strSentidoZoom = "ZoomIn"

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tlsZoomIn_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub frmRever_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If blnGraficoInicializado Then
            Call RedimensionaGrafico()
        End If
    End Sub

    Public Sub RedimensionaGrafico()

        intLarguraInicialGrupoGrafico = grbGrafico.Width
        intAlturaInicialGrupoGrafico = grbGrafico.Height

        'Recompoe todas as escalas do grafico
        graficoPavitest.chartWidth = intLarguraInicialGrupoGrafico - 30
        graficoPavitest.chartHeight = intAlturaInicialGrupoGrafico - 30
        graficoPavitest.AtualizarGraficoMultiplasListas()

    End Sub

    Private Sub mnuCurvaTracejada_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuCurvaTracejada.DropDownItemClicked
        Dim intYNovo As Integer
        Dim strOpcaoY As String
        blnLinhaTracejada = True

        Try
            strOpcaoY = e.ClickedItem.Text

            For Each item In listaOpcoesEixo
                If strOpcaoY.Contains(item) Then
                    intYNovo = listaOpcoesEixo.IndexOf(item)
                End If
            Next

            If graficoPavitest.strVetorLinhasY1.Contains(listaOpcoesEixo.ElementAt(intYNovo)) Then
                Exit Sub
            End If

            graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intYNovo))
            graficoPavitest.listTipoCurva.Add("Tracejada")
            listaCurvasPlotadas.Add(listaOpcoesEixo.ElementAt(intYNovo))
            If graficoPavitest.strVetorLinhasY1.Count > 1 Then blnExibirLegenda = True Else blnExibirLegenda = False

            blnMudouGrafico = True

            If blnReverEnsaio Then

                listaUsarEmY = PreencheListaGenerica(intYNovo)
                graficoPavitest.dblMatrixEixoY1.Add(listaUsarEmY)

                If blnEscalaManualX = False And blnEscalaManualY1 = False And blnEscalaManualY2 = False Then

                    Call CriterioAdicionalEscalaAutomaticaInicial()
                    graficoPavitest.AjustarEscalaAutomaticoNova()
                End If
            End If

            graficoPavitest.AtualizarGraficoMultiplasListas()

            'Sinaliza que já existe mais de uma curva no eixo Y1
            intVariosY1 = 1
            'Sinaliza que não houve a troca de Y1 principal
            blnNovoY1 = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub mnuCurvaTracejada_MouseEnter(sender As Object, e As EventArgs) Handles mnuCurvaTracejada.MouseEnter
        Dim strUnidadeMedidaY1 As String

        strUnidadeMedidaY1 = listaUnidadesMedidas.ElementAt(intOpcaoY)
        mnuCurvaTracejada.DropDownItems.Clear()

        'Atualiza as opções do menu
        For i = 0 To listaUnidadesMedidas.Count - 1
            If listaUnidadesMedidas.ElementAt(i) = strUnidadeMedidaY1 Then 'And i <> intOpcaoY 
                If graficoPavitest.strVetorLinhasY1.Contains(listaOpcoesEixo.ElementAt(i)) Then
                    Continue For
                Else
                    mnuCurvaTracejada.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
                End If
            End If
        Next
    End Sub

    Private Sub tlsZoomOut_Click(sender As Object, e As EventArgs) Handles tlsZoomOut.Click
        Try

            graficoPavitest.SelecionarModoZoom(Grafico1, WinChartMouseUsage.ZoomOut)

            strSentidoZoom = "ZoomOut"

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tlsZoomOut_Click" & Chr(13) & ex.Message)
        End Try

    End Sub



    Private Sub mnuRemoverCurva_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuRemoverCurva.DropDownItemClicked
        Dim contador As Integer
        Dim strOpcaoY As String
        Dim blnRemoverLinha As Boolean
        Dim blnRemoverLinhaTracejada As Boolean

        strOpcaoY = e.ClickedItem.Text

        If listaCurvasPlotadas.Count > 1 Then
            For Each item In listaCurvasPlotadas

                If strOpcaoY.Contains(item) Then
                    graficoPavitest.strVetorLinhasY1.RemoveAt(contador)
                    graficoPavitest.dblMatrixEixoY1.RemoveAt(contador)
                    mnuRemoverCurva.DropDownItems.RemoveAt(contador)
                    graficoPavitest.listTipoCurva.RemoveAt(contador)
                    blnRemoverLinha = True
                    Exit For
                End If
                contador += 1
            Next
        End If

        If blnRemoverLinha Then
            listaCurvasPlotadas.RemoveAt(contador)
        Else
            'Sai da sub por não ter removido nada
            Exit Sub
        End If

        If graficoPavitest.strVetorLinhasY1.Count > 1 Then blnExibirLegenda = True Else blnExibirLegenda = False

        If contador = 0 Then
            'Se a curva principal que tem o indice 0 for removida, será necessario atualizar o titulo do gráfico
            graficoPavitest.strTituloEixoY = listaCurvasPlotadas.ElementAt(0) & " (" & strUnidadeAnterior & ") "
        End If

        Call graficoPavitest.AtualizarGraficoMultiplasListas()
    End Sub

    Private Sub mnuRemoverCurva_MouseEnter(sender As Object, e As EventArgs) Handles mnuRemoverCurva.MouseEnter
        Call ExibirCurvasPlotadas()
    End Sub

    Private Sub ExibirCurvasPlotadas()

        mnuRemoverCurva.DropDownItems.Clear()

        For i = 0 To graficoPavitest.strVetorLinhasY1.Count - 1
            mnuRemoverCurva.DropDownItems.Add(graficoPavitest.strVetorLinhasY1(i))
        Next

    End Sub

    Private Sub lblLabel3_Click(sender As Object, e As EventArgs) Handles lblLabel3.Click

    End Sub

    Private Sub Grafico1_Click(sender As Object, e As EventArgs) Handles Grafico1.Click
        Dim viewer As WinChartViewer = sender
        If strSentidoZoom = "ZoomIn" Then
            intZoom += 1
        ElseIf strSentidoZoom = "ZoomOut" Then
            intZoom -= 1
        Else

            cornenadaEncontradaY = graficoPavitest.PegarValorY(viewer.PlotAreaMouseY, viewer.Chart)
            If blnPegarY1 = True And blnPegarY2 = False Then
                frmRegressaoLinear.txtY1.Text = Math.Floor(cornenadaEncontradaY)
            ElseIf blnPegarY1 = False And blnPegarY2 = True Then
                frmRegressaoLinear.txtY2.Text = Math.Ceiling(cornenadaEncontradaY)
            End If

            frmRegressaoLinear.Focus()

            Exit Sub
        End If

        coordenada_X_pixels = Grafico1.ChartMouseX
        coordenada_Y_pixels = Grafico1.ChartMouseY

        If intZoom > 0 And intZoom <= 5 Then
            graficoPavitest.blnZoomLupa = True
            tlsZoomOut.Enabled = True
            Call graficoPavitest.AtualizarGraficoMultiplasListas()
        End If

        If intZoom >= 5 Then
            tlsZoomIn.Enabled = False
            tlsZoomOut.Enabled = True
            graficoPavitest.SelecionarModoZoom(Grafico1, WinChartMouseUsage.Default)
        End If

        If intZoom <= 0 Then
            tlsZoomOut.Enabled = False
            tlsZoomCancel_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        Try

            blnGerarRelatorio = True
            intRelatorio = rpt_ENSAIOS
            'Gerar o relatório
            Call GerarRelatorio()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnCorrigir2_Click(sender As Object, e As EventArgs) Handles btnCorrigir2.Click
        Try

            Call btnCalcularRegressão_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("btnCalcularRegressão_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub


    Private Sub btnCalcularRegressão_Click(sender As Object, e As EventArgs) Handles btnCalcularRegressão.Click
        Try

            If intOpcaoY = 3 Then

                blnMudouUnidadeMPa = True

                intOpcaoY = 3
                intOpcaoX = 0

                intOpcaoY2 = -1 'Sem Y2
                'Recompoe todas as escalas do grafico
                Call RecomporEixoY1()

                'Atualiza Titulos dos eixos e também as escalas.
                Call AtualizaEixos()

            Else

                blnMudouUnidadeMPa = False

                intOpcaoY = 2
                intOpcaoX = 0
                intOpcaoY2 = -1 'Sem Y2

                'Recompoe todas as escalas do grafico
                Call RecomporEixoY1()

                'Atualiza Titulos dos eixos e também as escalas.
                Call AtualizaEixos()

                Label4.Text = "Calculada (kgf/cm²)"
                Label22.Text = "Corrigida (kgf/cm²)"
                Label23.Text = "Padrão (kgf/cm²)"
                lblLegendaPressao.Text = "Pressão (kgf/cm²)"
                lblPressao.Text = FormatNumber(listaPressaokgfcm2.Max, 0)
                Call VerificaResultadosBD()

            End If

            frmRegressaoLinear.Show()

        Catch ex As Exception
            MsgBox("btnCalcularRegressão_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub mnuLegenda_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tlsZoomCancel_Click(sender As Object, e As EventArgs) Handles tlsZoomCancel.Click
        Try

            mnuAutoTodosEixos.Checked = True
            Call mnuAutoTodosEixos_Click(Nothing, Nothing)

            tlsZoomOut.Enabled = False
            tlsZoomIn.Enabled = True

            intZoom = 0

            graficoPavitest.SelecionarModoZoom(Grafico1, WinChartMouseUsage.Default)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tlsZoomCancel_Click" & Chr(13) & ex.Message)
        End Try

    End Sub


#End Region

    Private Sub ReduzirDimensaoGrafico()

        intLarguraInicial = graficoPavitest.chartWidth
        intAlturaInicial = graficoPavitest.chartHeight

        graficoPavitest.chartWidth = 680
        graficoPavitest.chartHeight = 400

        graficoPavitest.AtualizarGraficoMultiplasListas()

    End Sub



End Class