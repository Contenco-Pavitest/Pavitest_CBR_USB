Imports System.Data.OleDb
Imports System.IO
Imports ChartDirector
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmResultados

#Region "Declarações de variáveis"
    Dim intVariosY1, intVariosY2 As Integer
    Dim blnNovoY1 As Boolean
    Dim blnHabilitarCrossHair As Boolean
    Public blnGerarRelatorio As Boolean
    Public blnMudouGrafico As Boolean

    Dim intContVetor As Integer
    Dim intContEnsaios As Integer
    Dim intLarguraInicial As Integer
    Dim intAlturaInicial As Integer
    Public graficoPavitest As New clsGraficoChart()
    Public listaTeste As New List(Of Double)
    Public intListCPsMarcados As New List(Of Integer)
    Dim intListCores As New List(Of Integer)
    Dim intList As New List(Of Integer)
    Dim strUnidadeMedidaY1 As String
    Dim intContEtapas As Integer
    Dim intEscolhaGrafico, intEscolhaGraficoAnterior As Integer
    Dim strListNavegacaoCP As New List(Of String)
    Public strListNavegacaoCPMarcados As New List(Of String)
    Dim listaCarga As List(Of Double)
    Dim listaCargaN As List(Of Double) = New List(Of Double)
    Dim listaCargakN As List(Of Double) = New List(Of Double)
    Public listaDeformacaoEspecifica As New List(Of Double)
    Dim listaUmidade As New List(Of Double)
    Dim listaMassaSeca As New List(Of Double)
    Dim listaExpansao As New List(Of Double)
    Dim dblLiistaISC As New List(Of Double)
    Dim dblListaCarga As New List(Of Double)
    Dim dblListaPenetracao As New List(Of Double)
    Dim dblListaPressaokgfcm2 As New List(Of Double)
    Public listaDeformacao1 As New List(Of Double)
    Public listaDeformacao2 As New List(Of Double)
    Public listaDeformacao3 As New List(Of Double)
    Public listaDeformacao4 As New List(Of Double)
    Public listaDeformacao5 As New List(Of Double)
    Public listaDeformacaoMedia As New List(Of Double)
    Public listaDeslocamento As New List(Of Double)
    Public listaSetPoint As New List(Of Double)
    Public listaTempo As New List(Of Double)
    Public listaTensao As New List(Of Double)
    Public listaUsarEmY As New List(Of Double)
    Public listaUsarEmX As New List(Of Double)
    Public listaUsarEmY2 As New List(Of Double)
    Dim dblMaiorValor As Integer
    Public IdCp As Integer
    Public i As Integer
    Dim lngContador1 As Long
    Public deformContador As Integer
    Public cargaKGF(5) As Double
    Public intVetorRever() As Integer
    Private blnGraficoInicializado As Boolean
    Dim blnRemoveLista As Boolean
    Dim listaOpcoesBD As New List(Of String) From {
         "expansao", '0
         "MassaSeca", '1
         "Umidade", '2
         "ISC1", '3
         "iSC2", '4
         "Penetracao", '5
         "Carga", '6
         "Pressao" '7
       }

    Dim listaUnidadesMedidas As New List(Of String) From {
         "mm",
        "kgf",
        "kgf/cm²",
        "%",
        "g/cm³",
        "%",
        "%"
    }


    Dim listaOpcoesEixo As New List(Of String) From {
        "Penetração",
        "Carga",
        "Pressão",
        "Umidade",
        "Massa Específica Aparente Seca",
        "Expansão",
        "ISC"
    }

    Public listaX As New List(Of List(Of List(Of Double)))
    Public listaY As New List(Of List(Of List(Of Double)))
    Public listaOpcaoY2 As Integer
    Public minScaleEixoX As Double = 0
    Public maxScaleEixoX As Double = 0
    Public minScaleEixoY As Double = 0
    Public maxScaleEixoY As Double = 0
    Public maxScaleEixoY2 As Double = 0
    Public minScaleEixoY2 As Double = 0
    Public divisaoEscalaX As Double = maxScaleEixoX / 10
    Public divisaoEscalaY As Double = maxScaleEixoY / 10
    Public divisaoEscalaY2 As Double = maxScaleEixoY2 / 10
    Public nomeCPS As New List(Of String)
    Dim blnNull As Boolean
    Dim intOpcaoXls As Integer
    Dim intOpcaoYls As Integer
    Dim intOpcaoY2ls As Integer
    Dim blnNaoMudaescala As Boolean

#End Region


    Private Sub frmResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TenacidadeDataSet1.AMOSTRA1CP1'. Você pode movê-la ou removê-la conforme necessário.
        intOpcaoXls = 4
        intOpcaoYls = 5
        intOpcaoY2ls = 6
        'TODO: esta linha de código carrega dados na tabela 'TenacidadeDataSet.tblCPs'. Você pode movê-la ou removê-la conforme necessário.
        intEscolhaGrafico = 3
        blnGraficoInicializado = True


        eixosToolStripMenuItem.Enabled = False
        RelatórioToolStripMenuItem.Enabled = False
        btnAtualizar.Enabled = False

        tlsBarra.Enabled = False
        blnReverEnsaio = False
        blnTelaResultados = True

        intLarguraInicialGrupoGrafico = grbGrafico.Width
        intAlturaInicialGrupoGrafico = grbGrafico.Height
        graficoPavitest.blnMarcadorPonto = True

        If intEscolhaGrafico = 4 Then
            graficoPavitest.blnLinhaCurva = False
            graficoPavitest.blnMarcadorPonto = False
        Else
            graficoPavitest.blnLinhaCurva = True
            graficoPavitest.blnMarcadorPonto = True
        End If

        intOpcaoY2 = -1

        'Gráfico Inicial
        Call FormatarGrafico()

        Call FiltroCps()

        Call ListaCoresPredefinidas()

    End Sub



    Public Sub PlotarGraficos()
        Dim c As XYChart = New XYChart(graficoPavitest.chartWidth, graficoPavitest.chartHeight, &HF4F4F4)
        Dim b As LegendBox = c.addLegend(70, 600, False, "Arial", 8)
        Dim layer As LineLayer = c.addLineLayer()
        Dim layer2 As LineLayer = c.addLineLayer2()
        'Define uma cor fixa para Y2
        Dim corY2 As Color = ConvertCor("Red")
        Dim strTituloGrafico As String
        'Atibuir dados para o gráfico
        Dim odbReader As OleDbDataReader
        Dim Sql As String
        Dim i As Integer
        Dim j As Integer
        Dim intComp As Integer

        Try

            'Selecionar Amostra com os Registro dos CPs
            lngContador1 = 1
            i = 0
            j = 0
            Sql = "SELECT * FROM [tblCPs] WHERE IdAmostra = " & IdAmostraEnsaio

            odbReader = usrConexao.ComandoLeitura(Sql)
            lngContador1 = 1
            intComp = 0

            If intListCPsMarcados.Count = 0 Then Exit Sub

            While odbReader.Read

                If j <= intListCPsMarcados.Count Then
                    Do While Not i > intListCPsMarcados.Count - 1
                        If odbReader("IdCP".ToString) = intListCPsMarcados(i) Then

                            If Not IsDBNull(odbReader("Umidade".ToString)) Then listaUmidade.Add(odbReader("Umidade".ToString))
                            If Not IsDBNull(odbReader("MassaSeca".ToString)) Then listaMassaSeca.Add(odbReader("MassaSeca".ToString))
                            If Not IsDBNull(odbReader("Expansao".ToString)) Then listaExpansao.Add(odbReader("Expansao".ToString))
                            If Not IsDBNull(odbReader("ISC1".ToString)) And Not IsDBNull(odbReader("ISC2".ToString)) Then
                                'Gráfico 03 - ISC x Umidade
                                If odbReader("ISC1".ToString) > odbReader("ISC2".ToString) Then
                                    dblLiistaISC.Add(odbReader("ISC1".ToString))
                                Else
                                    dblLiistaISC.Add(odbReader("ISC2".ToString))
                                End If
                            End If

                            j = j + 1

                            Exit Do

                        End If

                        i = i + 1

                    Loop

                End If

                i = 0

            End While


            Select Case intEscolhaGrafico
                Case 1
                    'Gráfico 01 - Massa Seca x Umidade
                    Call MontarGrafico(listaMassaSeca)
                Case 2
                    'Gráfico 02 - Expansão x Umidade
                    Call MontarGrafico(listaExpansao)
                Case 3
                    'Gráfico 03 - ISC x Umidade
                    Call MontarGrafico(dblLiistaISC)
                Case 4
                    Call MontarGraficoMultiplasLinhas()
            End Select

        Catch ex As Exception
            MsgBox("PlotarGraficos()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub MontarGraficoMultiplasLinhas()


        Try
            For j = 0 To intListCPsMarcados.Count - 1
                IdCp = intListCPsMarcados(j)
                Dim sqlAmostras As String = "SELECT * FROM " & "AMOSTRA" & intIdAmostra & "CP" & IdCp
                Dim odbReader As OleDbDataReader
                odbReader = usrConexao.ComandoLeitura(sqlAmostras)


                Call LimparListas()

                While odbReader.Read()
                    dblListaPenetracao.Add(odbReader(listaOpcoesBD.ElementAt(5).ToString))
                    dblListaCarga.Add(odbReader(listaOpcoesBD.ElementAt(6).ToString))
                    dblListaPressaokgfcm2.Add(odbReader(listaOpcoesBD.ElementAt(7).ToString))
                End While

                listaUsarEmY = PreencheListaGenerica(intOpcaoYls)
                listaUsarEmX = PreencheListaGenerica(intOpcaoXls)


                If j > 0 Then
                    If listaUsarEmX.Count > graficoPavitest.dblVetorValorX.Count Then
                        graficoPavitest.dblVetorValorX = listaUsarEmX
                    End If
                Else
                    graficoPavitest.dblVetorValorX = listaUsarEmX
                End If

                graficoPavitest.dblMatrixEixoY1.Add(listaUsarEmY)
                graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))
                graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
                graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "

                If intOpcaoY2 <> -1 And intOpcaoY2 <> -11 Then
                    listaUsarEmY2 = PreencheListaGenerica(intOpcaoY2)
                    graficoPavitest.dblMatrixEixoY2.Add(listaUsarEmY2)
                    graficoPavitest.strTituloEixoY2 = listaOpcoesEixo.ElementAt(intOpcaoY2) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY2) & ") "
                    graficoPavitest.dblMatrixEixoY2.Add(listaUsarEmY2)
                End If

                'Ajusta os máximos e mínimos e casas decimais
                Call graficoPavitest.AjustarEscalaAutomaticoNova()
            Next


            Call graficoPavitest.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            MsgBox("AtualizarMultiplasListasResultados" & Chr(13) & ex.Message)
        End Try

    End Sub
    Public Sub MontarGrafico(ByRef dblMinhaLista As List(Of Double))
        'Mostrar Gráfico 01 = Massa Seca x Umidade
        Try
            'dblMinhaLista.Add(dblValorY)
            graficoPavitest.dblMatrixEixoY1.Add(dblMinhaLista)
            graficoPavitest.dblVetorValorX = (listaUmidade)

            'Ajustes no eixo (x)

            For Each item In listaUmidade
                If (item - 2) < graficoPavitest.dblMenorValorX Or graficoPavitest.dblMenorValorX = 0 Then
                    graficoPavitest.dblMenorValorX = item - 2
                End If

                If item > graficoPavitest.dblMaiorValorX Or graficoPavitest.dblMaiorValorX = 0 Then
                    graficoPavitest.dblMaiorValorX = item
                End If
            Next

            'ajustes no eixo (Y)
            For Each item In dblMinhaLista
                If item < graficoPavitest.dblMenorValorY_CBR Or graficoPavitest.dblMenorValorY_CBR = 0 Then
                    graficoPavitest.dblMenorValorY_CBR = item
                End If

                If item > graficoPavitest.dblMaiorValorY_CBR Or graficoPavitest.dblMaiorValorY_CBR = 0 Then
                    graficoPavitest.dblMaiorValorY_CBR = item
                End If
            Next

            'Ajusta a escala dos eixos automaticamente 
            graficoPavitest.AjustarEscalaCBR(intEscolhaGrafico)

            Call graficoPavitest.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            MsgBox("MontarGrafico1()" & Chr(13) & ex.Message)
        End Try

    End Sub
    Public Sub ListaCoresPredefinidas()

        intListCores = New List(Of Integer)

        intListCores.Add(&H5588CC)
        intListCores.Add(&H8000&)
        intListCores.Add(&HFF69B4&)
        intListCores.Add(&HFF4500&)
        intListCores.Add(&HFFFF00&)
        intListCores.Add(&HFF&)
        intListCores.Add(&HFF00&)
        intListCores.Add(&HFFFF&)
        intListCores.Add(&HDAA520&)
        intListCores.Add(&HBA55D3&)
        intListCores.Add(&H4682B4&)
        intListCores.Add(&H7FFFD4&)

    End Sub

    Public Function ConvertCor(texto As String) As Color
        'Pelo nome recebido, identifica a cor
        Dim slateBlue As Color = Color.FromName(texto)
        'Captura cada inteiro do sistema RGB
        Dim g As Integer = slateBlue.G
        Dim b As Integer = slateBlue.B
        Dim r As Integer = slateBlue.R
        Dim a As Integer = 0 ' O padrão precisa ser 0 para a conversão manter tonalidade
        'Faz a conversão dos interiros para  o sistema de cores ARGB
        Return Color.FromArgb(a, r, g, b)
    End Function

    Public Sub FiltroCps()
        Try

            intList = New List(Of Integer)
            strListNavegacaoCP = New List(Of String)

            Dim sql As String = "SELECT IdAmostra, IdCP From tblCPs WHERE IdAmostra = " & intIdAmostra & " ORDER BY IdCP"
            Dim cmd As New OleDbCommand(sql, oConnection)
            Dim myReader As OleDbDataReader = cmd.ExecuteReader()
            While (myReader.Read())
                'Atualizar contador
                intContEtapas = intContEtapas + 1

                chkListBox.Items.Add("CP " & intContEtapas & " - " & myReader(1))
                intList.Add(myReader(1))
                strListNavegacaoCP.Add("CP " & intContEtapas)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LimparListas()

        'obs: Usar método list.Clear() limpa também as listas que já receberam anteriormente valores proveninetes dessa lista de origem

        'Zera as listas 
        listaUmidade = New List(Of Double)
        listaMassaSeca = New List(Of Double)
        listaExpansao = New List(Of Double)
        dblLiistaISC = New List(Of Double)
        dblListaCarga = New List(Of Double)
        dblListaPenetracao = New List(Of Double)
        dblListaPressaokgfcm2 = New List(Of Double)
        listaUsarEmY = New List(Of Double)
        listaUsarEmX = New List(Of Double)

    End Sub

    Public Sub FormatarGrafico()


        Try

            'Muda status para condicionar uso de critério adicional em escala automática
            blnMudouGrafico = True

            'Parametrizar escalas manuais/automáticas e definir máximos iniciais para cada lista
            Call AtualizaOpcoesEscalas()

            'Atualiza as opções disponiveis para escolha no menu de eixos
            Call AtualizarOpcoesEixos()

            'Call AtualizarOpcoesDeCurvasEmY1()

            'Recompoe todas as escalas do grafico
            Call InicializarGrafico() 'Antigo --> RecomporEixos


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("FormatarGrafico" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub InicializarGrafico() 'Antigo -->RecomporEixos
        Try


            If blnPrintarGrafico = True Then
                graficoPavitest.chartWidth = 680
                graficoPavitest.chartHeight = 360
            Else
                graficoPavitest.chartWidth = intLarguraInicialGrupoGrafico - 20
                graficoPavitest.chartHeight = intAlturaInicialGrupoGrafico - 20
            End If

            Select Case intEscolhaGrafico
                Case 1
                    graficoPavitest.strTituloEixoX = "Umidade (%)"
                    graficoPavitest.strTituloEixoY = "Massa Específica Aparente Seca (g/cm³)"
                Case 2
                    graficoPavitest.strTituloEixoX = "Umidade (%)"
                    graficoPavitest.strTituloEixoY = "Expansão (%)"
                Case 3
                    graficoPavitest.strTituloEixoX = "Umidade (%)"
                    graficoPavitest.strTituloEixoY = "ISC (%)"
                Case 4
                    graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
                    graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
                Case Else
                    graficoPavitest.strTituloEixoX = "Umidade (%)"
                    graficoPavitest.strTituloEixoY = "ISC (%)"
            End Select


            'Cria o grafico na tela e deixa ele vazio com todos os valores zerados

            graficoPavitest.createChart(WinChartViewer1)


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

            'graficoPavitest.strVetorLinhasY1 = New List(Of String)
            'graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
            'graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
            'graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))

            'Eixos X e Y1

            '  graficoPavitest.strVetorLinhasY1 = New List(Of String)

            '  graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))


            'Eixo Y2
            intOpcaoY2 = -1
            graficoPavitest.strVetorLinhasY2 = New List(Of String)
            graficoPavitest.strTituloEixoY2 = strUnidadeConvertidaY2

            Call PlotarGraficos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("InicializarGrafico" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Function PreencheListaGenerica(intNovo As Integer) As List(Of Double)

        Dim listaAtual As List(Of Double)
        listaAtual = New List(Of Double)
        Try
            Select Case intNovo
                Case 0
                    listaAtual = listaExpansao
                Case 1
                    listaAtual = listaMassaSeca
                Case 2
                    listaAtual = listaUmidade
                Case 3
                    listaAtual = dblLiistaISC
                Case 4
                    listaAtual = dblListaPenetracao
                Case 5
                    listaAtual = dblListaCarga
                Case 6
                    listaAtual = dblListaPressaokgfcm2
            End Select

            PreencheListaGenerica = listaAtual

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("PreencheListaGenerica" & Chr(13) & ex.Message)
        End Try
    End Function

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmResultados_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        If blnPrintarGrafico Then
            Call RetomarDimensaoGrafico()
            blnPrintarGrafico = False
        End If

    End Sub

    Private Sub chkListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles chkListBox.SelectedValueChanged

        intListCPsMarcados = New List(Of Integer)
        strListNavegacaoCPMarcados = New List(Of String)

        For i = 0 To (intList.Count - 1)

            If chkListBox.GetItemChecked(i) Then
                intListCPsMarcados.Add(intList(i))
                strListNavegacaoCPMarcados.Add(strListNavegacaoCP(i))
            End If
        Next

        If intListCPsMarcados.Count > 0 Then
            btnAtualizar.Enabled = True

        Else
            FormatarGrafico()
            EscalaToolStripMenuItem.Enabled = False
            eixosToolStripMenuItem.Enabled = False
            RelatórioToolStripMenuItem.Enabled = False
            tlsBarra.Enabled = False
            btnAtualizar.Enabled = False

        End If

    End Sub

    Private Sub SelecionaTodos(CheckThem As Boolean)
        intListCPsMarcados = New List(Of Integer)
        strListNavegacaoCPMarcados = New List(Of String)

        For i As Integer = 0 To (chkListBox.Items.Count - 1)
            If CheckThem Then
                chkListBox.SetItemCheckState(i, CheckState.Checked)
                intListCPsMarcados.Add(intList(i))
                strListNavegacaoCPMarcados.Add(strListNavegacaoCP(i))
            Else
                chkListBox.SetItemCheckState(i, CheckState.Unchecked)
            End If
        Next

    End Sub

    Private Sub chkSelecionar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelecionar.CheckedChanged
        If (chkSelecionar.Checked) Then
            SelecionaTodos(True)
            btnAtualizar.Enabled = True

        Else
            SelecionaTodos(False)
            EscalaToolStripMenuItem.Enabled = False
            eixosToolStripMenuItem.Enabled = False
            RelatórioToolStripMenuItem.Enabled = False
            tlsBarra.Enabled = False
            btnAtualizar.Enabled = False
            FormatarGrafico()

        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click


        mnuAutoEixoXEscalaMin0.Checked = True
        mnuAutoEixoY1EscalaMin0.Checked = True
        mnuAutoEixoY2EscalaMin0.Checked = True
        graficoPavitest.strVetorLinhasY1 = New List(Of String)
        graficoPavitest.dblVetorValorX = New List(Of Double)
        graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))
        graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))
        listaUsarEmX = New List(Of Double)
        listaUsarEmY = New List(Of Double)
        listaUsarEmY2 = New List(Of Double)

        'Limpar maiores e menores valores 
        graficoPavitest.dblMaiorValorX = 0
        graficoPavitest.dblMenorValorX = 0
        graficoPavitest.dblScaleMinX = 0
        graficoPavitest.dblScaleMaxX = 0
        graficoPavitest.dblScaleMinY = 0
        graficoPavitest.dblScaleMaxY = 0
        graficoPavitest.dblScaleMinY2 = 0
        graficoPavitest.dblScaleMaxY2 = 0

        If btnAtualizar.Enabled = True Then
            EscalaToolStripMenuItem.Enabled = True
            RelatórioToolStripMenuItem.Enabled = True
            tlsBarra.Enabled = True
        Else
            EscalaToolStripMenuItem.Enabled = False
            RelatórioToolStripMenuItem.Enabled = False
            tlsBarra.Enabled = False
        End If

        LimparListas()

        Call PlotarGraficos()

        'Call PlotarGraficos

    End Sub

    Public Sub PreencheVetorRever()
        Call LimparValores()

        ReDim Preserve intVetorRever(0)
        intContVetor = 0

        For i = 0 To intContEnsaios - 1
            If chkListBox.Items.Item(i).Checked = True Then
                ReDim Preserve intVetorRever(intContVetor)
                intVetorRever(intContVetor) = chkListBox.Items.Item(i).SubItems(1).Text
                intContVetor = intContVetor + 1
            End If
        Next

        If intContVetor = 0 Then
            MsgBox("É necessário selecionar algum ensaio para rever.", vbInformation)
            Exit Sub
        End If
    End Sub
    Private Sub LimparValores()
        listaUmidade.Clear()
        listaMassaSeca.Clear()
        dblLiistaISC.Clear()
        listaExpansao.Clear()
    End Sub




#Region "Eixos"
    Private Sub AtualizarOpcoesEixos()
        Try
            ''Limpa as opções do menu
            mnuEixoX1.DropDownItems.Clear()
            mnuEixoY1.DropDownItems.Clear()

            For i = 0 To listaOpcoesEixo.Count - 1
                mnuEixoX1.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
                mnuEixoY1.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
            Next

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarOpcoesEixos" & Chr(13) & ex.Message)
        End Try
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

    Private Sub mnuEixoX1_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuEixoX1.DropDownItemClicked
        Try

            Dim strOpcaoX As String
            strOpcaoX = e.ClickedItem.Text

            For Each item In listaOpcoesEixo
                If strOpcaoX.Contains(item) Then
                    intOpcaoX = listaOpcoesEixo.IndexOf(item)
                    intOpcaoXls = intOpcaoX + 4
                End If
            Next
            'Limpa as listas
            Call LimparListas()
            Call RecomporEixoX()
            Call RecomporEixoY1()
            If intOpcaoY2 <> -1 And intOpcaoY2 <> -11 Then
                Call RecomporEixoY2()
            End If



            'Limpar maiores e menores valores de X

            mnuEixoX1.Checked = True
            mnuAutoTodosEixos.Checked = True
            Call mnuAutoTodosEixos_Click(Nothing, Nothing)
            tlsZoomOut.Enabled = False
            tlsZoomIn.Enabled = True
            intZoom = 0
            graficoPavitest.SelecionarModoZoom(WinChartViewer1, WinChartMouseUsage.Default)

            Call PlotarGraficos()


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
                    intOpcaoYls = intOpcaoY + 4
                End If
            Next


            Call LimparListas()
            Call RecomporEixoX()
            Call RecomporEixoY1()
            If intOpcaoY2 <> -1 And intOpcaoY2 <> -11 Then
                Call RecomporEixoY2()
            End If

            Call PlotarGraficos()

            mnuEixoY1.Checked = True
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuEixoX1_DropDownItemClicked" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuNovaLinhaY1_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim intYNovo As Integer
        Dim strOpcaoY As String

        strOpcaoY = e.ClickedItem.Text
        'intOpcaoY = listaOpcoesEixo.IndexOf(strOpcaoY)
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

        'Muda status para condicionar uso de critério adicional em escala automática
        blnMudouGrafico = True

        'Se for modo rever ensaio
        If blnReverEnsaio Then

            'Carrega lista de dados provinda do BD
            listaUsarEmY = PreencheListaGenerica(intYNovo)

            'Repassa para o vetor do eixo Y1 os valores da lista carregada
            graficoPavitest.dblMatrixEixoY1.Add(listaUsarEmY)

            If blnEscalaManualX = False And blnEscalaManualY1 = False And blnEscalaManualY2 = False Then



                '      Call CriterioAdicionalEscalaAutomaticaInicial()
                'Ajusta a escala dos eixos automaticamente 
                '     graficoPavitest.AjustarEscalaAutomaticoNova()
            End If

        End If

        'Plota a nova curva no gráfico
        PlotarGraficos()

        'Sinaliza que já existe mais de uma curva no eixo Y1
        intVariosY1 = 1
        'Sinaliza que não houve a troca de Y1 principal
        blnNovoY1 = False

        'FILTRA AS OPÇÕES RESTANTES QUE POSSUAM A MESMA UNIDADE DA GRANDEZA PRINCIPAL DO EIXO Y
        'Call AtualizarOpcoesDeCurvasEmY1()

    End Sub

    Private Sub mnuNovaLinhaY1_MouseEnter(sender As Object, e As EventArgs)
        Try

            'FILTRA AS OPÇÕES RESTANTES QUE POSSUAM A MESMA UNIDADE DA GRANDEZA PRINCIPAL DO EIXO Y
            'Call AtualizarOpcoesDeCurvasEmY1()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuNovaLinhaY1_MouseEnter" & Chr(13) & ex.Message)
        End Try
    End Sub






    Private Sub mnuEixoY2GrandezaConvertida_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim strOpcaoY2 As String

        Try

            'Limpa as listas
            Call LimparListas()
            Call RecomporEixoX()
            Call RecomporEixoY1()
            If intOpcaoY2 <> -1 And intOpcaoY2 <> -11 Then
                Call RecomporEixoY2()
            End If

            'Pega o título da opção clicada
            strOpcaoY2 = e.ClickedItem.Text
            intOpcaoY2 = -11 'Significa que existe uma lista da mesma grandeza com unidade convertida
            strUnidadeConvertidaY2 = strOpcaoY2

            If intOpcaoY2 = -11 Then  'Opção do eixo Y2 com unidades convertidas em relação ao eixo Y1
                graficoPavitest.strTituloEixoY2 = strUnidadeConvertidaY2
            ElseIf intOpcaoY2 <> -1 Then 'Opção do eixo Y2 com uma grandeza escolhida de forma independente de Y1
                graficoPavitest.strTituloEixoY2 = listaOpcoesEixo.ElementAt(intOpcaoY2) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY2) & ") "
                graficoPavitest.dblMatrixEixoY2.Add(PreencheListaGenerica(intOpcaoY2))
                listaUsarEmY2 = PreencheListaGenerica(intOpcaoY2)
            Else 'Não exibe eixo Y2
                graficoPavitest.strTituloEixoY2 = ""
            End If

            Call PlotarGraficos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuEixoY2_DropDownItemClicked" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub AtualizaEixos()

        Call PlotarGraficos()

    End Sub


    Private Sub RecomporEixoX()
        Try

            graficoPavitest.dblVetorValorX = New List(Of Double)
            listaUsarEmX = New List(Of Double)
            graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "


            graficoPavitest.dblScaleMaxX = 0
            graficoPavitest.dblScaleMinX = 0

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
            graficoPavitest.listTipoCurva = New List(Of String)
            graficoPavitest.listTipoCurva.Add("Continua")
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "

            graficoPavitest.dblScaleMaxY = 0
            graficoPavitest.dblScaleMinY = 0

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

            graficoPavitest.dblScaleMaxY2 = 0
            graficoPavitest.dblScaleMinY2 = 0

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("RecomporEixoY2" & Chr(13) & ex.Message)
        End Try

    End Sub







#End Region

#Region "Escalas"

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
        'If mnuAutoEixoY1EscalaMinMenor.Checked Then
        '    mnuAutoEixoY1EscalaMin0.Checked = False
        'End If
        Try

            graficoPavitest.blnEscalaAutomaticaEixoY1MinimoZero = False

            mnuAutoEixoY1.Checked = True
            mnuAutoEixoY1EscalaMin0.Checked = False

            blnEscalaManualY1 = False

            'Reinicia eixo para calcular automático na classe chart
            graficoPavitest.dblScaleMinY = 0
            graficoPavitest.dblScaleMaxY = 0
            graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))

            Call AplicaEscalaAutomatica()

            mnuManualY1.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoY1EscalaMinMenor_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
        PlotarGraficos()
    End Sub

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

    Public Sub mnuAutoEixoXEscalaMin0_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoXEscalaMin0.Click
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

            'Reinicia eixo para calcular automático na classe chart
            graficoPavitest.dblScaleMinY = 0
            graficoPavitest.dblScaleMaxX = 0

            Call AplicaEscalaAutomatica()

            mnuManualX.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoXEscalaMinMenor_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
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

            mnuManualX.Checked = True
            mnuAutoEixoX.Checked = False

            mnuAutoEixoXEscalaMin0.Checked = False
            mnuAutoEixoXEscalaMinMenor.Checked = False

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
            mnuAutoEixoY1EscalaMin0.Checked = False
            mnuAutoEixoY1EscalaMinMenor.Checked = False

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

        Catch ex As Exception
            MsgBox("btnAplicarAjustesEscalaX_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
        End Try
    End Sub

    Private Sub btnAplicarAjustesEscalaY2_Click(sender As Object, e As EventArgs) Handles btnAplicarAjustesEscalaY2.Click

        Try

            If txtMinimoY2.Text = "" And txtMaximoY2.Text = "" Then Exit Sub

            blnEscalaManualY2 = True

            mnuManualY2.Checked = True
            mnuAutoEixoY2.Checked = False
            mnuAutoEixoY2EscalaMin0.Checked = False
            mnuAutoEixoY2EscalaMinMenor.Checked = False

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

        Catch ex As Exception
            MsgBox("btnAplicarAjustesEscalaX_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
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


#End Region

#Region "Relatório"

    Public Sub CarregarFormulario()
        GerarRelatorio()
    End Sub

    Private Sub GerarRelatorio()



        Try

            frmRelatorio.strCondicao = SQLCondicao()
            blnPrintarGrafico = True

            Call ReduzirDimensaoGrafico()

            graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
            graficoPavitest.strVetorLinhasY1 = New List(Of String)
            graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))

            Call usrLayout.CarregarFormulario(frmRelatorio, False)


        Catch ex As Exception
            MsgBox("GerarRelatorio()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("GerarRelatorio" & Chr(13) & "GerarRelatorio" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try

        ''frmRelatorioResultados.strCondicao = SQLCondicao()

        'blnPrintarGrafico = True
        'Call ReduzirDimensaoGrafico()
        'graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
        'graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
        'graficoPavitest.strVetorLinhasY1 = New List(Of String)
        'graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))



        ''Call usrLayout.CarregarFormulario(frmRelatorioResultados, False)

    End Sub

    Private Function SQLCondicao() As String
        Dim strCondicao As String

        strCondicao = ""

        Try
            For i = 0 To intListCPsMarcados.Count - 1
                If strCondicao = "" Then
                    strCondicao = " IdCP = " & intListCPsMarcados(i)
                Else
                    strCondicao = strCondicao & " OR IdCP = " & intListCPsMarcados(i)
                End If
            Next
            If strCondicao <> "" Then
                strCondicao = "AND (" & strCondicao & ")"
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("SQLCondicao" & Chr(13) & ex.Message)

        End Try

        SQLCondicao = strCondicao

    End Function

    Private Sub RelatórioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioToolStripMenuItem.Click

        Try

            'Autorizando geração do relatório no evento activated
            blnGerarRelatorio = True
            intRelatorio = rpt_RESULTADOS
            'Gerar o relatório
            Call GerarRelatorio()

        Catch ex As Exception
            MsgBox("btnRelatorio_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("btnRelatorio_Click" & Chr(13) & "btnRelatorio_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & Err.Description)
            Exit Sub
        End Try
    End Sub

    Private Sub ReduzirDimensaoGrafico()

        intLarguraInicial = graficoPavitest.chartWidth
        intAlturaInicial = graficoPavitest.chartHeight

        graficoPavitest.chartWidth = 680
        graficoPavitest.chartHeight = 360

        blnPrintarGrafico = True

        intOrdemPrints = 0
        'selecionar grafico 1 (titulo, eixoX,eixoY)
        Call mnuGraficoMassaxUmidade_Click(Nothing, Nothing)

        intOrdemPrints = 1
        'selecionar grafico 2 (titulo, eixoX,eixoY)
        Call mnuGraficoExpansaoxUmidade_Click(Nothing, Nothing)

        intOrdemPrints = 2
        'selecionar grafico 3 (titulo, eixoX,eixoY)
        Call IscXUmidadeToolStripMenuItem_Click(Nothing, Nothing)

        intOrdemPrints = 3
        'selecionar grafico 4 (titulo, eixoX,eixoY)
        Call MultiplasLinhasToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    Private Sub RetomarDimensaoGrafico()

        graficoPavitest.chartWidth = intLarguraInicial
        graficoPavitest.chartHeight = intAlturaInicial


        graficoPavitest.AtualizarGraficoMultiplasListas()

    End Sub

#End Region

    Private Sub Grafico1_MouseClick(sender As Object, e As MouseEventArgs) Handles WinChartViewer1.MouseClick

        If strSentidoZoom = "ZoomIn" Then
            intZoom += 1
        ElseIf strSentidoZoom = "ZoomOut" Then
            intZoom -= 1
        Else
            Exit Sub
        End If

        coordenada_X_pixels = WinChartViewer1.ChartMouseX
        coordenada_Y_pixels = WinChartViewer1.ChartMouseY

        If intZoom >= 0 And intZoom <= 5 Then
            graficoPavitest.blnZoomLupa = True
            tlsZoomOut.Enabled = True
            Call graficoPavitest.AtualizarGraficoMultiplasListas()
        End If

        If intZoom >= 5 Then
            tlsZoomIn.Enabled = False
            tlsZoomOut.Enabled = True
            graficoPavitest.SelecionarModoZoom(WinChartViewer1, WinChartMouseUsage.Default)
        End If

        If intZoom <= 0 Then
            tlsZoomOut.Enabled = False
            tlsZoomCancel_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Grafico1_MouseMove(sender As Object, e As MouseEventArgs) Handles WinChartViewer1.MouseMove

        Dim viewer As WinChartViewer = sender

        If blnHabilitarCrossHair Then
            graficoPavitest.crossHair(viewer.Chart, viewer.PlotAreaMouseX, viewer.PlotAreaMouseY)
            viewer.updateDisplay()
            ' Hide the track cursor when the mouse leaves the plot area
            viewer.removeDynamicLayer("MouseLeavePlotArea")
        End If

    End Sub



#Region "Zoom"

    Private Sub tlsZoomIn_Click(sender As Object, e As EventArgs) Handles tlsZoomIn.Click
        Try

            intNumeroCurvaZoom = 0
            graficoPavitest.SelecionarModoZoom(WinChartViewer1, WinChartMouseUsage.ZoomIn)

            strSentidoZoom = "ZoomIn"

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tlsZoomIn_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub tlsZoomOut_Click(sender As Object, e As EventArgs) Handles tlsZoomOut.Click
        Try

            graficoPavitest.SelecionarModoZoom(WinChartViewer1, WinChartMouseUsage.ZoomOut)

            strSentidoZoom = "ZoomOut"

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tlsZoomOut_Click" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub tlsZoomCancel_Click(sender As Object, e As EventArgs) Handles tlsZoomCancel.Click
        Try

            mnuAutoTodosEixos.Checked = True
            Call mnuAutoTodosEixos_Click(Nothing, Nothing)

            tlsZoomOut.Enabled = False
            tlsZoomIn.Enabled = True

            intZoom = 0

            graficoPavitest.SelecionarModoZoom(WinChartViewer1, WinChartMouseUsage.Default)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tlsZoomCancel_Click" & Chr(13) & ex.Message)
        End Try

    End Sub


#End Region

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

    Private Sub chkLegenda_CheckedChanged(sender As Object, e As EventArgs) Handles chkLegenda.CheckedChanged

        If chkLegenda.Checked Then
            blnExibirLegenda = True
        Else
            blnExibirLegenda = False
        End If

    End Sub

    Private Sub mnuGraficoMassaxUmidade_Click(sender As Object, e As EventArgs) Handles mnuGraficoMassaxUmidade.Click
        eixosToolStripMenuItem.Enabled = False
        mnuGraficoMassaxUmidade.Checked = True
        mnuGraficoExpansaoxUmidade.Checked = False
        mnuGraficoISCxUmidade.Checked = False
        mnuGraficoMultiplasLinhas.Checked = False
        chkLegenda.Checked = False
        chkLegenda.Visible = False

        intEscolhaGraficoAnterior = intEscolhaGrafico
        intEscolhaGrafico = 1

        intOpcaoY = 4
        intOpcaoX = 3

        If intEscolhaGrafico = 4 Then
            graficoPavitest.blnLinhaCurva = False
            graficoPavitest.blnMarcadorPonto = False
        Else
            graficoPavitest.blnLinhaCurva = True
            graficoPavitest.blnMarcadorPonto = True
        End If

        graficoPavitest.dblMaiorValorY_CBR = 0
        graficoPavitest.dblMenorValorY_CBR = 0

        'Recompoe todas as escalas do grafico
        Call RecomporEixoY1()
        Call RecomporEixoX()

        Call LimparListas()

        Call AtualizarOpcoesEixos()

        'Call InicializarGrafico() 'A

        Call FormatarGrafico()

    End Sub

    Private Sub mnuGraficoExpansaoxUmidade_Click(sender As Object, e As EventArgs) Handles mnuGraficoExpansaoxUmidade.Click
        eixosToolStripMenuItem.Enabled = False
        mnuGraficoMassaxUmidade.Checked = False
        mnuGraficoExpansaoxUmidade.Checked = True
        mnuGraficoISCxUmidade.Checked = False
        mnuGraficoMultiplasLinhas.Checked = False
        chkLegenda.Checked = False
        chkLegenda.Visible = False


        'Armazena o índice do gráfico anterior
        intEscolhaGraficoAnterior = intEscolhaGrafico
        intEscolhaGrafico = 2

        intOpcaoY = 5
        intOpcaoX = 3

        If intEscolhaGrafico = 4 Then
            graficoPavitest.blnLinhaCurva = False
            graficoPavitest.blnMarcadorPonto = False
        Else
            graficoPavitest.blnLinhaCurva = True
            graficoPavitest.blnMarcadorPonto = True
        End If

        graficoPavitest.dblMaiorValorY_CBR = 0
        graficoPavitest.dblMenorValorY_CBR = 0
        'Recompoe todas as escalas do grafico
        Call RecomporEixoY1()
        Call RecomporEixoX()

        Call LimparListas()

        Call AtualizarOpcoesEixos()
        'Call InicializarGrafico() 'A

        Call FormatarGrafico()

    End Sub

    Private Sub IscXUmidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGraficoISCxUmidade.Click

        eixosToolStripMenuItem.Enabled = False
        mnuGraficoMassaxUmidade.Checked = False
        mnuGraficoExpansaoxUmidade.Checked = False
        mnuGraficoISCxUmidade.Checked = True
        mnuGraficoMultiplasLinhas.Checked = False
        chkLegenda.Checked = False
        chkLegenda.Visible = False

        'Armazena o índice do gráfico anterior
        intEscolhaGraficoAnterior = intEscolhaGrafico
        intEscolhaGrafico = 3

        intOpcaoY = 6
        intOpcaoX = 3

        If intEscolhaGrafico = 4 Then
            graficoPavitest.blnLinhaCurva = False
            graficoPavitest.blnMarcadorPonto = False
        Else
            graficoPavitest.blnLinhaCurva = True
            graficoPavitest.blnMarcadorPonto = True
        End If

        graficoPavitest.dblMaiorValorY_CBR = 0
        graficoPavitest.dblMenorValorY_CBR = 0

        'Recompoe todas as escalas do grafico
        Call RecomporEixoY1()
        Call RecomporEixoX()

        Call LimparListas()

        'Atualiza Titulos dos eixos e também as escalas.
        'Atualiza as opções disponiveis para escolha no menu de eixos
        Call AtualizarOpcoesEixos()

        'Call InicializarGrafico() 'A

        Call FormatarGrafico()

    End Sub
    Private Sub MultiplasLinhasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGraficoMultiplasLinhas.Click
        eixosToolStripMenuItem.Enabled = True
        mnuGraficoMassaxUmidade.Checked = False
        mnuGraficoExpansaoxUmidade.Checked = False
        mnuGraficoISCxUmidade.Checked = False
        mnuGraficoMultiplasLinhas.Checked = True
        chkLegenda.Visible = True

        'Armazena o índice do gráfico anterior
        intEscolhaGraficoAnterior = intEscolhaGrafico
        intEscolhaGrafico = 4


        intOpcaoX = 0
        intOpcaoY = 1

        If intEscolhaGrafico = 4 Then
            graficoPavitest.blnLinhaCurva = False
            graficoPavitest.blnMarcadorPonto = False
        Else
            graficoPavitest.blnLinhaCurva = True
            graficoPavitest.blnMarcadorPonto = True
        End If
        'Atualiza as opções disponiveis para escolha no menu de eixos
        '  Call AtualizarOpcoesEixos()
        'Call InicializarGrafico() 'A

        Call FormatarGrafico()

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



    Private Sub frmResultados_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
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
End Class
