Imports ChartDirector
Imports System.Collections

Public Class clsGraficoChart
    Implements InterfaceGraficos

#Region "Declaração de variáveis"

    'OBJETOS DIVERSOS-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private viewer As WinChartViewer
    Private corY2 As Color = ConvertCor("Red") 'Define uma cor fixa para Y2

    'Cores da primeira linha abaixo são as cores escuras - Cores da segunda linha abaixo são as cores mais claras
    Public coresPredefinidas() As Color = {ConvertCor("MediumBlue"), ConvertCor("Yellow"), ConvertCor("DarkGreen"), ConvertCor("DarkMagenta"), ConvertCor("DarkOrange"), ConvertCor("DarkTurquoise"), ConvertCor("SaddleBrown"), ConvertCor("HotPink"),
        ConvertCor("RoyalBlue"), ConvertCor("Khaki"), ConvertCor("LimeGreen"), ConvertCor("Magenta"), ConvertCor("Coral"), ConvertCor("Cyan"), ConvertCor("Peru"), ConvertCor("White"), ConvertCor("Black")}
    'OBJETOS DIVERSOS-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'LISTAS----------------------------------------------------------------------------------------------------------------
    Public coresDasLinhas As New List(Of Color)
    Public dblVetorValorX As New List(Of Double)
    Public dblVetorValorCustomizado As New List(Of List(Of Double))
    Public dblMatrixEixoY1 As New List(Of List(Of Double))
    Public dblMatrixEixoY2 As New List(Of List(Of Double))
    Public strVetorLinhasY1 As New List(Of String)
    Public strVetorLinhasY2 As New List(Of String)
    Public listTipoCurva As New List(Of String)
    Public strLinhasY1Tracejada As New List(Of String)
    Public listaEixoY1Tracejada As New List(Of List(Of Double))
    'LISTAS----------------------------------------------------------------------------------------------------------------

    'STRING----------------------------------------------------------------------------------------------------------------
    Public strTituloGrafico As String = "Titulo"
    Public strTituloEixoX As String = "Eixo X"
    Public strTituloEixoY As String = "Eixo Y"
    Public strTituloEixoY2 As String = ""
    Dim nomesGrandezas() As String
    Dim nomesCPs() As String
    Dim lastCurva As String
    Dim lastCurvaY2 As String
    'STRING----------------------------------------------------------------------------------------------------------------

    'INTEGER----------------------------------------------------------------------------------------------------------------
    Public chartWidth As Integer = 900 'Largura
    Public chartHeight As Integer = 403 'Altura
    Public intQuantidadeCurvasY1 As Integer
    Public intPosicaoX_Legenda, intPosicaoY_Legenda, intLarguraGrafico, intAlturaGrafico As Integer
    Dim totalItens As Integer
    Dim totalItensResultados As Integer
    Dim totalItensRever As Integer
    Dim contTracejada As Integer
    Dim intLegCaracteres As Integer
    Dim intLegCaracteresY2 As Integer
    'INTEGER----------------------------------------------------------------------------------------------------------------

    'DOUBLE-----------------------------------------------------------------------------------------------------------------
    Public chartMultiplicadorZoom As Double = 1.2
    Public dblScaleMaxX As Double = 30 'Define a escala maxima inicial
    Public dblScaleMaxY As Double = 10
    Public dblScaleMaxY2 As Double = 10
    Public dblScaleMinX As Double = 0 ' Define a escala minima inicial
    Public dblScaleMinY As Double = 0
    Public dblScaleMinY2 As Double = 0
    Public dblDivisaoEscalaX As Double = dblScaleMaxX / 10 'Define as divisões da escala no gráfico
    Public dblDivisaoEscalaY As Double = dblScaleMaxY / 10
    Public dblDivisaoEscalaY2 As Double = dblScaleMaxY2 / 10
    Public dblMaiorValorX, dblMenorValorX As Double
    Public dblMaiorValorY_CBR, dblMenorValorY_CBR As Double
    'DOUBLE-----------------------------------------------------------------------------------------------------------------

    'BOOLEAN----------------------------------------------------------------------------------------------------------------
    Public blnZoomLupa As Boolean 'Zoom ativo = true
    Public blnEscalaAutomaticaEixoY2MinimoZero As Boolean
    Public blnEscalaAutomaticaEixoY1MinimoZero As Boolean
    Public blnEscalaAutomaticaEixoXMinimoZero As Boolean
    Public blnEscalaAutomaticaEixoXTempoOrigemDinamica As Boolean
    Public blnLegendaHorizontal As Boolean
    Public blnMarcadorPonto As Boolean
    Public blnLinhaCurva As Boolean
    Public blnTrendLayer As Boolean
    Public blnRegressaoLinear1, blnRegressaoLinear2, blnRegressaoLinear3 As Boolean
    Public blnRotacionarGrafico As Boolean
    'BOOLEAN----------------------------------------------------------------------------------------------------------------

#End Region

    'Nome do Grafico
    Public Function Nome() As String Implements InterfaceGraficos.Nome
        Return strTituloGrafico
    End Function

    Public Sub createChart(viewer As WinChartViewer) _
        Implements InterfaceGraficos.createChart

        Dim objChart As ChartDirector.XYChart = New ChartDirector.XYChart(chartWidth, chartHeight)

        'Atualiza o titulo do grafico quando for atualizar o grafico
        strTituloGrafico = strTituloEixoY & " x " & strTituloEixoX

        With objChart
            .addTitle(8, strTituloGrafico, "Verdana Bold", 8, &H80)
            .setPlotArea(70, 25, chartWidth - 100, chartHeight - 90, Chart.CColor(Color.LightGray), -1, -1, .dashLineColor(&H80000000, Chart.DotLine), -1)
            .setClipping()

            dblScaleMaxX = 100
                dblDivisaoEscalaX = 10
                dblScaleMaxY = 100
                dblDivisaoEscalaY = 10


            .xAxis().setLinearScale(0, dblScaleMaxX, dblDivisaoEscalaX)
            .yAxis().setLinearScale(0, dblScaleMaxY, dblDivisaoEscalaY)
            .setBorder(Chart.CColor(Color.WhiteSmoke))
            .setBackground(Chart.CColor(Color.WhiteSmoke))
            .xAxis.setTitle(strTituloEixoX, "Verdana Bold", 8, &H80)
            .yAxis.setTitle(strTituloEixoY, "Verdana Bold", 8, &H80)

        End With

        viewer.Chart = objChart
        Me.viewer = viewer
    End Sub

    Public Sub AtualizarGraficoMultiplasListas()

        Dim strMsg As String
        Dim objChart As ChartDirector.XYChart = New ChartDirector.XYChart(chartWidth, chartHeight)
        Dim chartLine As ChartDirector.LineLayer = objChart.addLineLayer2()
        Dim splineLine As ChartDirector.SplineLayer = objChart.addSplineLayer

        Dim contador As Integer

        Try

            'Define o título do gráfico
            If strTituloEixoY2 = "" And blnRotacionarGrafico = False Then
                strTituloGrafico = strTituloEixoY & " x " & strTituloEixoX
            ElseIf strTituloEixoY2 = "" And blnRotacionarGrafico = True Then
                strTituloGrafico = strTituloEixoX & " x " & strTituloEixoY
            Else
                strTituloGrafico = strTituloEixoY & " x " & strTituloEixoX & " x " & strTituloEixoY2
            End If

            'Seta configurações do grafico
            With objChart
                .addTitle(8, strTituloGrafico, "Verdana Bold", 8, &H80)

                If blnExibirLegenda = True And strVetorLinhasY1.Count > 1 Then

                    Call FormatarLegenda()

                    .setPlotArea(70, 25, intLarguraGrafico, intAlturaGrafico, ChartDirector.Chart.CColor(Color.LightGray), -1, -1, .dashLineColor(&H80000000, ChartDirector.Chart.DotLine), -1)

                    If blnLegendaHorizontal Then
                        .addLegend(intPosicaoX_Legenda, intPosicaoY_Legenda, False, "arial", 10)
                    Else
                        .addLegend(intPosicaoX_Legenda, intPosicaoY_Legenda, True, "arial", 10)
                    End If

                Else
                    'Plota a área do gráfico maior sem considerar espaço para a caixa de legenda
                    'Funciona pra Y1 sem legenda
                    .setPlotArea(70, 25, chartWidth - 100, chartHeight - 90, ChartDirector.Chart.CColor(Color.LightGray), -1, -1, .dashLineColor(&H80000000, ChartDirector.Chart.DotLine), -1)
                End If
                .setClipping()

                'If blnRotacionarGrafico = True Then
                '    .swapXY()
                '    .yAxis.setTitle(strTituloEixoY, "Verdana Bold", 8, &H80)
                '    .yAxis().setLinearScale(dblScaleMinY, dblScaleMaxY, dblDivisaoEscalaY)
                'ElseIf blnRotacionarGrafico = False Then
                .yAxis().setLinearScale(dblScaleMinY, dblScaleMaxY, dblDivisaoEscalaY)
                .yAxis.setTitle(strTituloEixoY, "Verdana Bold", 8, &H80)
                'End If

                .xAxis().setLinearScale(dblScaleMinX, dblScaleMaxX, dblDivisaoEscalaX)
                .setBorder(ChartDirector.Chart.CColor(Color.WhiteSmoke))
                .setBackground(ChartDirector.Chart.CColor(Color.WhiteSmoke))
                .xAxis.setTitle(strTituloEixoX, "Verdana Bold", 8, &H80)
                .yAxis.setTitle(strTituloEixoY, "Verdana Bold", 8, &H80)

                If strTituloEixoY2 <> "" Then
                    If blnExibirLegenda Then
                        Call FormatarLegenda()
                        .setPlotArea(70, 25, intLarguraGrafico, intAlturaGrafico, ChartDirector.Chart.CColor(Color.LightGray), -1, -1, .dashLineColor(&H80000000, ChartDirector.Chart.DotLine), -1)
                    Else
                        .setPlotArea(70, 25, chartWidth - 140, chartHeight - 90, ChartDirector.Chart.CColor(Color.LightGray), -1, -1, .dashLineColor(&H80000000, ChartDirector.Chart.DotLine), -1)
                    End If

                    .yAxis2.setTitle(strTituloEixoY2, "Verdana Bold", 8, &H80)
                    .yAxis2().setLinearScale(dblScaleMinY2, dblScaleMaxY2, dblDivisaoEscalaY2)

                    If dblMatrixEixoY2.Count <> 0 Then
                        If intOpcaoY2 <> -1 Then

                            .yAxis2().setColors(CInt(corY2.ToArgb), CInt(corY2.ToArgb), CInt(corY2.ToArgb)) 'Vermelho
                            Dim layer2 As LineLayer = objChart.addLineLayer(dblMatrixEixoY2(0).ToArray(), CInt(corY2.ToArgb), strVetorLinhasY2(0)) 'strTituloEixoY2)
                            layer2.setLineWidth(2)
                            layer2.setUseYAxis2()
                            'Referência eixo X para layer 2
                            layer2.setXData(dblVetorValorX.ToArray())
                        End If
                    End If
                End If

            End With

            'Determina que a linha do grafico terá 3 pixels


            'Zera o contador e cria a variavel que recebe cores atuais
            contador = 0
            Dim corRecebida As Color
            contTracejada = 0

            'Preenche o grafico com a lista de dados de cada CP da lista de CPs
            'Para cada CP busca uma nova cor, caso as cores ultrapssem as predefinidas cria novas cores randomizadas
            For Each dadosCadaCP As List(Of Double) In dblMatrixEixoY1
                If contador < coresPredefinidas.Length Then
                    corRecebida = coresPredefinidas(contador)
                    contador = contador + 1
                Else
                    corRecebida = RandomRGBColor()
                End If

                If blnExibirLegenda Then
                    If blnTelaResultados Then
                        chartLine.addDataSet(dadosCadaCP.ToArray(), CInt(corRecebida.ToArgb), frmResultados.strListNavegacaoCPMarcados(contador - 1))
                    Else
                        totalItensRever = strVetorLinhasY1.Count - 1
                        ReDim Preserve nomesGrandezas(totalItensRever)
                        Dim nomeY As String = strVetorLinhasY1(contTracejada)
                        nomesGrandezas(contTracejada) = nomeY

                        If listTipoCurva(contTracejada) = "Tracejada" Then
                            chartLine.addDataSet(dadosCadaCP.ToArray(), objChart.dashLineColor(CInt(corRecebida.ToArgb), Chart.DashLine), nomesGrandezas(contTracejada))
                        ElseIf listTipoCurva(contTracejada) = "Continua" Then
                            chartLine.addDataSet(dadosCadaCP.ToArray(), CInt(corRecebida.ToArgb), nomesGrandezas(contTracejada))
                        End If

                        coresDasLinhas.Add(corRecebida)
                        intQuantidadeCurvasY1 = contTracejada
                        contTracejada += 1

                    End If

                Else
                    If blnMarcadorPonto = False Then
                        If blnLinhaCurva = False Then
                            chartLine.addDataSet(dadosCadaCP.ToArray(), CInt(corRecebida.ToArgb))
                        Else
                            splineLine.addDataSet(dadosCadaCP.ToArray(), CInt(corRecebida.ToArgb))
                        End If
                    Else
                        If blnLinhaCurva = False Then
                            chartLine.addDataSet(dadosCadaCP.ToArray(), CInt(corRecebida.ToArgb)).setDataSymbol(Chart.CircleSymbol, 7)
                        Else
                            splineLine.addDataSet(dadosCadaCP.ToArray(), CInt(corRecebida.ToArgb)).setDataSymbol(Chart.CircleSymbol, 7)
                        End If
                    End If

                End If
            Next

            'Adiciona o vetor de valores para o eixo X  
            If blnLinhaCurva = False Then
                chartLine.setXData(dblVetorValorX.ToArray())
            Else
                splineLine.setXData(dblVetorValorX.ToArray())
            End If

            'Opção para calcular regressão linar
            If blnTrendLayer Then Call CalcularRegressaoLinear(objChart, chartLine)

            'Constroi o gráfico
            Me.viewer.Chart = objChart

            Me.viewer.ImageMap = objChart.getHTMLImageMap("clickable", "", "title='(x, y) = ({x}, {value})'")

            If blnPrintarGrafico Then
                objChart.makeChart(PrintGrafico(intOrdemPrints))
            End If

            'Get the data x-value that is nearest to the mouse, and find its pixel coordinate.
            coordenada_X_valorAproximado = objChart.getNearestXValue(coordenada_X_pixels)
            coordenada_Y_valor = objChart.getYValue(coordenada_Y_pixels)
            coordenada_X_valor = objChart.getXValue(coordenada_X_pixels)

            If blnZoomLupa Then Call ZoomGrafico()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarGraficoMultiplasListas" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub CalcularRegressaoLinear(ByRef objChart As ChartDirector.XYChart, ByRef chartLine As ChartDirector.LineLayer)

        Dim vetorY() As Double = {y1, y2}
        Dim vetorX() As Double = {x1, x2}
        Dim trendLayer As TrendLayer = objChart.addTrendLayer2(vetorX, vetorY, objChart.dashLineColor(&HFF0000, Chart.DashLine))
        dblA = trendLayer.getSlope
        dblB = trendLayer.getIntercept
        chartLine.setLineWidth(2)
        trendLayer.setLineWidth(3)
        trendLayer.setHTMLImageMap("", "", "title='Trend Line: y = {slope|P4} x + {intercept|P4}'")

        If blnRegressaoLinear2 Then
            Dim vetorYLinha2() As Double = {dblResultMenorYP1, dblResultMaiorYP1}
            Dim vetorXLinha2() As Double = {dblResultMenorXP1, dblResultMaiorXP1}
            Dim trendLayer2 As TrendLayer = objChart.addTrendLayer2(vetorXLinha2, vetorYLinha2, Chart.Transparent)
            dblA2 = trendLayer2.getSlope
            dblB2 = trendLayer2.getIntercept
            dblValorYCorrigido1 = Math.Round((dblA2 * dblX1_Corrigido) + dblB2, 2)

        End If

        If blnRegressaoLinear3 Then
            Dim vetorYLinha3() As Double = {dblResultMenorYP2, dblResultMaiorYP2}
            Dim vetorXLinha3() As Double = {dblResultMenorxP2, dblResultMaiorxP2}
            Dim trendLayer3 As TrendLayer = objChart.addTrendLayer2(vetorXLinha3, vetorYLinha3, Chart.Transparent)
            dblA3 = trendLayer3.getSlope
            dblB3 = trendLayer3.getIntercept
            dblValorYCorrigido2 = Math.Round((dblA3 * dblX2_Corrigido) + dblB3, 2)

        End If

    End Sub

    Private Function PrintGrafico(ByVal intNumeroGrafico As Integer) As String

        If intNumeroGrafico = 0 Then
            Return My.Application.Info.DirectoryPath & "\Imagens\Grafico.bmp"
        Else
            Return My.Application.Info.DirectoryPath & "\Imagens\Grafico" & intNumeroGrafico & ".bmp"
        End If


    End Function

    Private Sub FormatarLegenda()

        Try

            '------------------------------------------------------------------------------
            'Contabilza o tamanho da legenda
            '------------------------------------------------------------------------------
            If strVetorLinhasY1.Count > 0 Then
                lastCurva = strVetorLinhasY1.Count - 1
                intLegCaracteres = strVetorLinhasY1(lastCurva).Length
            End If

            If intOpcaoY2 <> -1 Then 'And frmResultados.chkLegenda.Checked = True Then
                lastCurvaY2 = strVetorLinhasY2.Count - 1
                intLegCaracteresY2 = strVetorLinhasY2(lastCurvaY2).Length
            End If
            '------------------------------------------------------------------------------

            ''-----------------------------------------------------------------------------
            'Condições para tratar a legenda
            ''-----------------------------------------------------------------------------
            If blnLegendaHorizontal = False Then
                If (intOpcaoY2 = -1 Or intOpcaoY2 = -11) And intLegCaracteres < 28 Then
                    'Sem Y2 e com menos de 28 caracteres
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = intLarguraInicialGrupoGrafico - 260
                        intPosicaoY_Legenda = 30
                        intLarguraGrafico = chartWidth - 310
                        intAlturaGrafico = chartHeight - 90
                    Else
                        intPosicaoX_Legenda = intLarguraInicialGrupoGrafico - 110
                        intPosicaoY_Legenda = 30
                        intLarguraGrafico = chartWidth - 180
                        intAlturaGrafico = chartHeight - 90
                    End If
                ElseIf (intOpcaoY2 = -1 Or intOpcaoY2 = -11) And intLegCaracteres >= 28 Then
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = intLarguraInicialGrupoGrafico - 290
                        intPosicaoY_Legenda = 30
                        intLarguraGrafico = chartWidth - 350
                        intAlturaGrafico = chartHeight - 90
                    Else
                        'TELA DE RESULTADOS NÃO TERÁ CURVA COM NOME MAIOR DO QUE "CP 100"
                    End If
                ElseIf intOpcaoY2 > -1 And strVetorLinhasY1.Count > 1 And intLegCaracteres < 28 Then
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = intLarguraInicialGrupoGrafico - 290
                        intPosicaoY_Legenda = 30
                        intLarguraGrafico = chartWidth - 410
                        intAlturaGrafico = chartHeight - 90
                    Else
                        intPosicaoX_Legenda = intLarguraInicialGrupoGrafico - 140
                        intPosicaoY_Legenda = 30
                        intLarguraGrafico = chartWidth - 250
                        intAlturaGrafico = chartHeight - 90
                    End If
                ElseIf intOpcaoY2 > -1 And strVetorLinhasY1.Count > 1 And intLegCaracteres >= 28 Then
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = intLarguraInicialGrupoGrafico - 290
                        intPosicaoY_Legenda = 30
                        intLarguraGrafico = chartWidth - 400
                        intAlturaGrafico = chartHeight - 90
                    Else
                        'TELA DE RESULTADOS NÃO TERÁ CURVA COM NOME MAIOR DO QUE "CP 100"
                    End If
                End If
            Else
                If (intOpcaoY2 = -1 Or intOpcaoY2 = -11) And strVetorLinhasY1.Count < 4 Then
                    'Sem Y2 e com menos de 28 caracteres
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = 5
                        intPosicaoY_Legenda = intAlturaInicialGrupoGrafico - 70
                        intLarguraGrafico = chartWidth - 80
                        intAlturaGrafico = chartHeight - 120
                    Else
                        intPosicaoX_Legenda = intLarguraInicialGrupoGrafico - 1100
                        intPosicaoY_Legenda = intAlturaInicialGrupoGrafico - 80
                        intLarguraGrafico = chartWidth - 80
                        intAlturaGrafico = chartHeight - 160
                    End If
                ElseIf (intOpcaoY2 = -1 Or intOpcaoY2 = -11) And strVetorLinhasY1.Count >= 4 Then
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = 5
                        intPosicaoY_Legenda = intAlturaInicialGrupoGrafico - 110
                        intLarguraGrafico = chartWidth - 80
                        intAlturaGrafico = chartHeight - 150
                    Else
                        'TELA DE RESULTADOS NÃO TERÁ CURVA COM NOME MAIOR DO QUE "CP 100"
                    End If
                ElseIf intOpcaoY2 > -1 And strVetorLinhasY1.Count > 1 And strVetorLinhasY1.Count < 4 Then
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = 5
                        intPosicaoY_Legenda = intAlturaInicialGrupoGrafico - 70
                        intLarguraGrafico = chartWidth - 140
                        intAlturaGrafico = chartHeight - 120
                    Else
                        intPosicaoX_Legenda = 5
                        intPosicaoY_Legenda = intAlturaInicialGrupoGrafico - 70
                        intLarguraGrafico = chartWidth - 140
                        intAlturaGrafico = chartHeight - 120
                    End If
                ElseIf intOpcaoY2 > -1 And strVetorLinhasY1.Count > 1 And strVetorLinhasY1.Count >= 4 Then
                    If blnTelaResultados = False Then
                        intPosicaoX_Legenda = 5
                        intPosicaoY_Legenda = intAlturaInicialGrupoGrafico - 110
                        intLarguraGrafico = chartWidth - 140
                        intAlturaGrafico = chartHeight - 150
                    Else
                        'TELA DE RESULTADOS NÃO TERÁ CURVA COM NOME MAIOR DO QUE "CP 100"
                    End If
                End If
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("FormatarLegenda" & Chr(13) & ex.Message)
        End Try

    End Sub
    Public Function RandomRGBColor() As Color

        'Variavel para receber cor dinamica
        Dim corRecebida As Color

        'Variaveis para receber números Randomicos
        Dim a, r, g, b As Integer

        'Intancia de Random
        Dim numRandom As Random = New Random()

        System.Threading.Thread.Sleep(1)
        a = CInt(numRandom.Next(20, 70))
        System.Threading.Thread.Sleep(1)
        r = CInt(numRandom.Next(0, 170))
        System.Threading.Thread.Sleep(1)
        g = CInt(numRandom.Next(0, 170))
        System.Threading.Thread.Sleep(1)
        b = CInt(numRandom.Next(0, 170))

        'If para evitar cores transparentes, porem cria somente tonalidades sem vermelho
        If g <> 0 And b <> 0 Then
            r = 0
        End If

        'Cria uma nova cor de acordo com os inteiros
        corRecebida = Color.FromArgb(a, r, g, b)

        'Se a cor criada já estiver presente no array, entra em recursividade, até encontrar uma cor realmente nova.
        If coresDasLinhas.Contains(corRecebida) Then
            corRecebida = RandomRGBColor()
        End If

        Return corRecebida
    End Function

    'Conversor de cor RGB para Argb, recebendo o nome da cor presente no sistema.
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

    Public Sub ZoomGrafico()


        Try

            Select Case intZoom
                Case 1
                    dblScaleMinX = coordenada_X_valor * 0.5
                    dblScaleMaxX = coordenada_X_valor * 1.5

                    dblScaleMinY = coordenada_Y_valor * 0.5
                    dblScaleMaxY = coordenada_Y_valor * 1.5
                Case 2
                    dblScaleMinX = coordenada_X_valor * 0.6
                    dblScaleMaxX = coordenada_X_valor * 1.4


                    dblScaleMinY = coordenada_Y_valor * 0.6
                    dblScaleMaxY = coordenada_Y_valor * 1.4

                Case 3
                    dblScaleMinX = coordenada_X_valor * 0.7
                    dblScaleMaxX = coordenada_X_valor * 1.3

                    dblScaleMinY = coordenada_Y_valor * 0.7
                    dblScaleMaxY = coordenada_Y_valor * 1.3

                Case 4
                    dblScaleMinX = coordenada_X_valor * 0.8
                    dblScaleMaxX = coordenada_X_valor * 1.2

                    dblScaleMinY = coordenada_Y_valor * 0.8
                    dblScaleMaxY = coordenada_Y_valor * 1.2

                Case 5
                    dblScaleMinX = coordenada_X_valor * 0.9
                    dblScaleMaxX = coordenada_X_valor * 1.1

                    dblScaleMinY = coordenada_Y_valor * 0.9
                    dblScaleMaxY = coordenada_Y_valor * 1.1

            End Select

            Call AjustaCasasDecimaisZoom()

            Call AtualizarDivisores()

            blnZoomLupa = False

            Call AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ZoomGrafico" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub AjustaCasasDecimaisZoom()

        'AJUSTA VALORES DE Y
        If Math.Abs(dblScaleMaxY) >= 100 Then
            dblScaleMaxY = Math.Round(dblScaleMaxY, 0)
            dblScaleMinY = Math.Round(dblScaleMinY, 0)
        ElseIf Math.Abs(dblScaleMaxY) >= 1 Then
            dblScaleMaxY = Math.Round(dblScaleMaxY, 1)
            dblScaleMinY = Math.Round(dblScaleMinY, 1)
        ElseIf Math.Abs(dblScaleMaxY) >= 0.1 Then
            dblScaleMaxY = Math.Round(dblScaleMaxY, 2)
            dblScaleMinY = Math.Round(dblScaleMinY, 2)
        ElseIf Math.Abs(dblScaleMaxY) >= 0.01 Then
            dblScaleMaxY = Math.Round(dblScaleMaxY, 3)
            dblScaleMinY = Math.Round(dblScaleMinY, 3)
        ElseIf dblScaleMaxY = 0 Then
            dblScaleMaxY = 0
            dblScaleMinY = 0
        Else
            dblScaleMaxY = Math.Round(dblScaleMaxY, 4)
            dblScaleMinY = Math.Round(dblScaleMinY, 4)
        End If

        'AJUSTA VALORES MÍNIMOS DE X 
        If Math.Abs(dblScaleMaxX) >= 100 Then
            dblScaleMaxX = Math.Round(dblScaleMaxX, 0)
            dblScaleMinX = Math.Round(dblScaleMinX, 0)
        ElseIf Math.Abs(dblScaleMaxX) >= 1 Then
            dblScaleMaxX = Math.Round(dblScaleMaxX, 1)
            dblScaleMinX = Math.Round(dblScaleMinX, 1)
        ElseIf Math.Abs(dblScaleMaxX) >= 0.1 Then
            dblScaleMaxX = Math.Round(dblScaleMaxX, 2)
            dblScaleMinX = Math.Round(dblScaleMinX, 2)
        ElseIf Math.Abs(dblScaleMaxX) >= 0.01 Then
            dblScaleMaxX = Math.Round(dblScaleMaxX, 3)
            dblScaleMinX = Math.Round(dblScaleMinX, 3)
        ElseIf dblScaleMaxX = 0 Then
            dblScaleMaxX = 0
            dblScaleMinX = 0
        Else
            dblScaleMaxX = Math.Round(dblScaleMaxX, 4)
            dblScaleMinX = Math.Round(dblScaleMinX, 4)
        End If

    End Sub

    Public Sub AjustarEscalaAutomaticoNova()
        Dim dblMaiorValorY, dblMaiorValorY2 As Double 'dblMaiorValorX,
        Dim dblMenorValorY, dblMenorValorY2 As Double 'dblMenorValorX

        '-------------------------------------------------------------------------------------------------
        'EIXO X
        '-------------------------------------------------------------------------------------------------
        If dblVetorValorX.Count > 0 And blnEscalaManualX = False Then

            If blnTelaResultados = False Then
                dblMaiorValorX = dblVetorValorX.Max
                dblMenorValorX = dblVetorValorX.Min
            Else
                'Analisa máximo e mínimo para tela de resultados
                If dblVetorValorX.Max > dblMaiorValorX Then
                    dblMaiorValorX = Math.Round(dblVetorValorX.Max, 4)
                End If

                If dblVetorValorX.Min <= dblMenorValorX Then
                    dblMenorValorX = Math.Round(dblVetorValorX.Min, 4)
                    dblScaleMinX = Math.Round(dblVetorValorX.Min, 4)
                End If

            End If

            'Define se exibirá o menor valor da lista/vetor ou sempre a partir de 0
            If blnEscalaAutomaticaEixoXMinimoZero = True Then
                dblMenorValorX = 0
                dblScaleMinX = 0
            Else 'Se o usuário escolheu mostrar sempre o menor valor de X
                If blnTelaResultados = True Then
                    If dblMenorValorX = 0 Then 'Primeira passagem
                        dblMenorValorX = dblVetorValorX.Min
                        dblScaleMinX = dblVetorValorX.Min
                    ElseIf dblVetorValorX.Min < dblMenorValorX Then
                        dblMenorValorX = Math.Round(dblVetorValorX.Min, 4)
                    End If
                End If
            End If

            If blnEscalaAutomaticaEixoXTempoOrigemDinamica = True Then

                If dblVetorValorX.Max >= dblScaleMaxX And dblScaleMaxX < 30 Then
                    dblScaleMaxX = Math.Round(dblMaiorValorX * chartMultiplicadorZoom, 1)
                    dblScaleMinX = dblScaleMaxX / 10

                ElseIf dblScaleMaxX >= 30 And dblScaleMaxX < dblVetorValorX.Max Then
                    chartMultiplicadorZoom = 1.1
                    dblScaleMaxX = Math.Round(dblMaiorValorX + 10, 1)
                    dblScaleMinX = dblScaleMaxX - 30
                End If

            End If

            If blnEscalaAutomaticaEixoXTempoOrigemDinamica = False Then

                If dblScaleMaxX <= dblMaiorValorX Then
                    If Math.Abs(dblMaiorValorX) >= 100 Then
                        dblScaleMaxX = Math.Round(dblMaiorValorX * chartMultiplicadorZoom, 0)
                    ElseIf Math.Abs(dblMaiorValorX) >= 1 Then
                        dblScaleMaxX = Math.Round(dblMaiorValorX * chartMultiplicadorZoom, 1)
                    ElseIf Math.Abs(dblMaiorValorX) >= 0.1 Then
                        dblScaleMaxX = Math.Round(dblMaiorValorX * chartMultiplicadorZoom, 2)
                    ElseIf Math.Abs(dblMaiorValorX) >= 0.01 Then
                        dblScaleMaxX = Math.Round(dblMaiorValorX * chartMultiplicadorZoom, 3)
                    ElseIf dblMaiorValorX = 0 Then
                        dblScaleMaxX = 0
                    Else
                        dblScaleMaxX = Math.Round(dblMaiorValorX * chartMultiplicadorZoom, 4)
                    End If
                End If

                If dblScaleMinX >= dblMenorValorX Then
                    If dblMenorValorX >= 100 Then
                        dblScaleMinX = Math.Round(dblMenorValorX - 5, 0)
                    ElseIf dblMenorValorX <= -100 Then
                        dblScaleMinX = Math.Round(dblMenorValorX * chartMultiplicadorZoom, 0)
                    ElseIf dblMenorValorX >= 1 Then
                        dblScaleMinX = Math.Round(dblMenorValorX - 0.5, 1)
                    ElseIf dblMenorValorX <= -1 Then
                        dblScaleMinX = Math.Round(dblMenorValorX * chartMultiplicadorZoom, 1)
                    ElseIf dblMenorValorX >= 0.1 Then
                        dblScaleMinX = Math.Round(dblMenorValorX - 0.05, 2)
                    ElseIf dblMenorValorX <= -0.1 Then
                        dblScaleMinX = Math.Round(dblMenorValorX * chartMultiplicadorZoom, 2)
                    ElseIf dblMenorValorX >= 0.01 Then
                        dblScaleMinX = Math.Round(dblMenorValorX - 0.005, 3)
                    ElseIf dblMenorValorX <= -0.01 Then
                        dblScaleMinX = Math.Round(dblMenorValorX * chartMultiplicadorZoom, 3)
                    ElseIf dblMenorValorX = 0 Then
                        dblScaleMinX = 0
                    Else
                        If dblScaleMinX < 0 Then
                            dblScaleMinX = Math.Round(dblMenorValorX * chartMultiplicadorZoom, 4)
                        Else
                            dblScaleMinX = Math.Round(dblMenorValorX - 0.0005, 4)
                        End If
                    End If
                End If

            End If
        End If

        '-------------------------------------------------------------------------------------------------
        'EIXO Y1
        '-------------------------------------------------------------------------------------------------
        If dblMatrixEixoY1.Count > 0 And blnEscalaManualY1 = False Then
            For Each listaCorrente As List(Of Double) In dblMatrixEixoY1
                If listaCorrente.Count > 0 Then

                    '------------------------------------------
                    'Maior valor da Escala Y1
                    '------------------------------------------
                    If listaCorrente.Max > dblMaiorValorY Then
                        dblMaiorValorY = Math.Round(listaCorrente.Max, 4)
                    End If

                    '-------------------------------------------------------------
                    'Menor valor da escala Y1
                    '-------------------------------------------------------------
                    'Se o usuário escolheu exibir sempre zero como escala mínima:
                    If blnEscalaAutomaticaEixoY1MinimoZero = True Then
                        dblMenorValorY = 0
                        dblScaleMinY = 0
                        Continue For

                    Else 'Se o usuário escolheu mostrar sempre o menor valor de Y1

                        If dblMenorValorY = 0 Then 'Primeiro passagem
                            dblMenorValorY = listaCorrente.Min
                            dblScaleMinY = listaCorrente.Min
                        ElseIf listaCorrente.Min < dblMenorValorY Then 'Demais listas
                            dblMenorValorY = Math.Round(listaCorrente.Min, 4)
                        End If

                    End If

                End If
            Next

            If dblScaleMaxY <= dblMaiorValorY Then
                If Math.Abs(dblMaiorValorY) >= 100 Then
                    dblScaleMaxY = Math.Round(dblMaiorValorY * chartMultiplicadorZoom, 0)
                ElseIf Math.Abs(dblMaiorValorY) >= 1 Then
                    dblScaleMaxY = Math.Round(dblMaiorValorY * chartMultiplicadorZoom, 1)
                ElseIf Math.Abs(dblMaiorValorY) >= 0.1 Then
                    dblScaleMaxY = Math.Round(dblMaiorValorY * chartMultiplicadorZoom, 2)
                ElseIf Math.Abs(dblMaiorValorY) >= 0.01 Then
                    dblScaleMaxY = Math.Round(dblMaiorValorY * chartMultiplicadorZoom, 3)
                ElseIf dblMaiorValorY = 0 Then
                    dblScaleMaxY = 0
                Else
                    dblScaleMaxY = Math.Round(dblMaiorValorY * chartMultiplicadorZoom, 4)
                End If
            End If

            If dblScaleMinY >= dblMenorValorY Then
                If dblMenorValorY >= 100 Then
                    dblScaleMinY = Math.Round(dblMenorValorY - 5, 0)
                ElseIf dblMenorValorY <= -100 Then
                    dblScaleMinY = Math.Round(dblMenorValorY * chartMultiplicadorZoom, 0)
                ElseIf dblMenorValorY >= 1 Then
                    dblScaleMinY = Math.Round(dblMenorValorY - 0.5, 1)
                ElseIf dblMenorValorY <= -1 Then
                    dblScaleMinY = Math.Round(dblMenorValorY * chartMultiplicadorZoom, 1)
                ElseIf dblMenorValorY >= 0.1 Then
                    dblScaleMinY = Math.Round(dblMenorValorY - 0.05, 2)
                ElseIf dblMenorValorY <= -0.1 Then
                    dblScaleMinY = Math.Round(dblMenorValorY * chartMultiplicadorZoom, 2)
                ElseIf dblMenorValorY >= 0.01 Then
                    dblScaleMinY = Math.Round(dblMenorValorY - 0.005, 3)
                ElseIf dblMenorValorY <= -0.01 Then
                    dblScaleMinY = Math.Round(dblMenorValorY * chartMultiplicadorZoom, 3)
                ElseIf dblMenorValorY = 0 Then
                    dblScaleMinY = 0
                Else
                    If dblScaleMinY < 0 Then
                        dblScaleMinY = Math.Round(dblMenorValorY * chartMultiplicadorZoom, 4)
                    Else
                        dblScaleMinY = Math.Round(dblMenorValorY - 0.0005, 4)
                    End If
                End If
            End If

            ''Mesmo se não houve atualização da escala mínima garante a formatação sem casas decimais para leituras grandes
            'If Math.Abs(dblMenorValorY) >= 100 Or Math.Abs(dblMaiorValorY) >= 100 Then
            '    dblScaleMinY = Math.Round(dblScaleMinY, 0)
            '    dblScaleMaxY = Math.Round(dblScaleMaxY, 0)
            'ElseIf Math.Abs(dblMenorValorY) >= 1 Or Math.Abs(dblMaiorValorY) >= 1 Then
            '    dblScaleMinY = Math.Round(dblScaleMinY, 1)
            '    dblScaleMaxY = Math.Round(dblScaleMaxY, 1)
            'End If

        End If


        '-------------------------------------------------------------------------------------------------
        'EIXO Y2
        '-------------------------------------------------------------------------------------------------
        'Se o eixo é unidade convertida 
        If intOpcaoY2 = -11 And blnEscalaManualY2 = False Then

            Call PreencheListaConvertida(strUnidadeConvertidaY2)

            If Math.Abs(dblScaleMaxY2) >= 100 Then
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 0)
            ElseIf Math.Abs(dblScaleMaxY2) >= 1 Then
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 1)
            ElseIf Math.Abs(dblScaleMaxY2) >= 0.1 Then
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 2)
            ElseIf Math.Abs(dblScaleMaxY2) >= 0.01 Then
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 3)
            ElseIf dblScaleMaxY2 = 0 Then
                dblScaleMaxY2 = 0
            Else
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 4)
            End If

            If Math.Abs(dblScaleMinY2) >= 100 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 0)
            ElseIf Math.Abs(dblScaleMinY2) >= 1 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 1)
            ElseIf Math.Abs(dblScaleMinY2) >= 0.1 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 2)
            ElseIf Math.Abs(dblScaleMinY2) >= 0.01 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 3)
            ElseIf dblScaleMinY2 = 0 Then
                dblScaleMinY2 = 0
            Else
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 4)
            End If

            ''Mesmo se não houve atualização da escala mínima garante a formatação sem casas decimais para leituras grandes
            If Math.Abs(dblScaleMinY2) >= 100 Or Math.Abs(dblScaleMaxY2) >= 100 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 0)
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 0)
            ElseIf Math.Abs(dblScaleMinY2) >= 1 Or Math.Abs(dblScaleMaxY2) >= 1 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 1)
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 1)
            End If

            'Se o eixo é unidade independente
        ElseIf intOpcaoY2 <> -1 And dblMatrixEixoY2.Count > 0 And blnEscalaManualY2 = False Then

            For Each listaCorrente As List(Of Double) In dblMatrixEixoY2
                If listaCorrente.Count > 0 Then

                    If listaCorrente.Max > dblMaiorValorY2 Then
                        dblMaiorValorY2 = Math.Round(listaCorrente.Max, 4)
                    End If

                    If blnEscalaAutomaticaEixoY2MinimoZero = True Or (intOpcaoY2 = -11 And dblMenorValorY = 0) Then
                        dblMenorValorY2 = 0
                        dblScaleMinY2 = 0
                        Continue For

                    Else 'Se o usuário escolheu mostrar sempre o menor valor de Y1

                        If dblMenorValorY2 = 0 Then 'Primeira passagem
                            dblMenorValorY2 = listaCorrente.Min
                            dblScaleMinY2 = listaCorrente.Min
                        ElseIf listaCorrente.Min < dblMenorValorY2 Then 'Demais listas
                            dblMenorValorY2 = Math.Round(listaCorrente.Min, 4)
                        End If

                    End If

                End If

                'End If
            Next

            If dblScaleMaxY2 < dblMaiorValorY2 Then
                If Math.Abs(dblMaiorValorY2) >= 100 Then
                    dblScaleMaxY2 = Math.Round(dblMaiorValorY2 * chartMultiplicadorZoom, 0)
                ElseIf Math.Abs(dblMaiorValorY2) >= 1 Then
                    dblScaleMaxY2 = Math.Round(dblMaiorValorY2 * chartMultiplicadorZoom, 1)
                ElseIf Math.Abs(dblMaiorValorY2) >= 0.1 Then
                    dblScaleMaxY2 = Math.Round(dblMaiorValorY2 * chartMultiplicadorZoom, 2)
                ElseIf Math.Abs(dblMaiorValorY2) >= 0.01 Then
                    dblScaleMaxY2 = Math.Round(dblMaiorValorY2 * chartMultiplicadorZoom, 3)
                ElseIf dblMaiorValorY2 = 0 Then
                    dblScaleMaxY2 = 0
                Else
                    dblScaleMaxY2 = Math.Round(dblMaiorValorY2 * chartMultiplicadorZoom, 4)
                End If
            End If

            If dblScaleMinY2 >= dblMenorValorY2 Then
                If dblMenorValorY2 >= 100 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 - 5, 0)
                ElseIf dblMenorValorY2 <= -100 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 * chartMultiplicadorZoom, 0)
                ElseIf dblMenorValorY2 >= 1 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 - 0.5, 1)
                ElseIf dblMenorValorY2 <= -1 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 * chartMultiplicadorZoom, 1)
                ElseIf dblMenorValorY2 >= 0.1 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 - 0.05, 2)
                ElseIf dblMenorValorY2 <= -0.1 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 * chartMultiplicadorZoom, 2)
                ElseIf dblMenorValorY2 >= 0.01 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 - 0.005, 3)
                ElseIf dblMenorValorY2 <= -0.01 Then
                    dblScaleMinY2 = Math.Round(dblMenorValorY2 * chartMultiplicadorZoom, 3)
                ElseIf dblMenorValorY2 = 0 Then
                    dblScaleMinY2 = 0
                Else
                    If dblScaleMinY2 < 0 Then
                        dblScaleMinY2 = Math.Round(dblMenorValorY2 * chartMultiplicadorZoom, 4)
                    Else
                        dblScaleMinY2 = Math.Round(dblMenorValorY2 - 0.0005, 4)
                    End If
                End If
            End If

            ''Mesmo se não houve atualização da escala mínima garante a formatação sem casas decimais para leituras grandes
            If Math.Abs(dblMenorValorY2) >= 100 Or Math.Abs(dblMaiorValorY2) >= 100 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 0)
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 0)
            ElseIf Math.Abs(dblMenorValorY2) >= 1 Or Math.Abs(dblMaiorValorY2) >= 1 Then
                dblScaleMinY2 = Math.Round(dblScaleMinY2, 1)
                dblScaleMaxY2 = Math.Round(dblScaleMaxY2, 1)
            End If

        End If

        'Verifica necessidade de atualizar as divisões das escalas do gráfico
        If blnEscalaManualX And blnEscalaManualY1 And blnEscalaManualY2 Then Exit Sub

        '-------------------------------------------------------------------------------------------------
        'ATUALIZAR NÚMERO DE DIVISÕES NO GRÁFICO
        '-------------------------------------------------------------------------------------------------
        Call AtualizarDivisores()

    End Sub

    Public Sub AjustarEscalaCBR(ByVal intGrafico As Integer)


        Select Case intGrafico
            Case 1

                dblScaleMinX = dblMenorValorX
                dblScaleMaxX = dblMaiorValorX + 2

                dblScaleMinY = dblMenorValorY_CBR - 0.05
                dblScaleMaxY = dblMaiorValorY_CBR + 0.05

            Case 2

                dblScaleMinX = dblMenorValorX
                dblScaleMaxX = dblMaiorValorX + 2

                dblScaleMinY = dblMenorValorY_CBR - 0.15
                dblScaleMaxY = dblMaiorValorY_CBR + 0.15

            Case 3

                dblScaleMinX = dblMenorValorX
                dblScaleMaxX = dblMaiorValorX + 2

                dblScaleMinY = dblMenorValorY_CBR - 15
                dblScaleMaxY = dblMaiorValorY_CBR + 15


        End Select

        Call AtualizarDivisores()

    End Sub

    Public Sub AtualizarDivisores()



        Dim dblValorX, dblValorY, dblValorY2 As Double

        dblValorX = dblScaleMaxX - dblScaleMinX
        dblValorY = dblScaleMaxY - dblScaleMinY
        dblValorY2 = dblScaleMaxY2 - dblScaleMinY2

        If blnEscalaManualX = False Or blnZoomLupa = True Then
            'DIVISÕES EIXO X1
            If Math.Abs(dblValorX) >= 10 Then
                dblDivisaoEscalaX = Math.Round(dblValorX / 10, 0)
            ElseIf Math.Abs(dblValorX) >= 1 Then
                dblDivisaoEscalaX = Math.Round(dblValorX / 10, 1)
            ElseIf Math.Abs(dblValorX) >= 0.1 Then
                dblDivisaoEscalaX = Math.Round(dblValorX / 10, 2)
            ElseIf Math.Abs(dblValorX) >= 0.01 Then
                dblDivisaoEscalaX = Math.Round(dblValorX / 10, 3)
            ElseIf Math.Abs(dblValorX) >= 0.001 Then
                dblDivisaoEscalaX = Math.Round(dblValorX / 10, 4)
            Else
                dblDivisaoEscalaX = (dblValorX / 10)
            End If
        End If

        If blnEscalaManualY1 = False Or blnZoomLupa = True Then
            'DIVISÕES EIXO Y1
            If Math.Abs(dblValorY) >= 10 Then
                dblDivisaoEscalaY = Math.Round(dblValorY / 10, 0)
            ElseIf Math.Abs(dblValorY) >= 1 Then
                dblDivisaoEscalaY = Math.Round(dblValorY / 10, 1)
            ElseIf Math.Abs(dblValorY) >= 0.1 Then
                dblDivisaoEscalaY = Math.Round(dblValorY / 10, 2)
            ElseIf Math.Abs(dblValorY) >= 0.01 Then
                dblDivisaoEscalaY = Math.Round(dblValorY / 10, 3)
            ElseIf Math.Abs(dblValorY) >= 0.001 Then
                dblDivisaoEscalaY = Math.Round(dblValorY / 10, 4)
            Else
                dblDivisaoEscalaY = dblValorY / 10
            End If
        End If

        If blnEscalaManualY2 = False Or blnZoomLupa = True Then
            'DIVISÕES EIXO Y2
            If Math.Abs(dblValorY2) >= 10 Then
                dblDivisaoEscalaY2 = Math.Round(dblValorY2 / 10, 0)
            ElseIf Math.Abs(dblValorY2) >= 1 Then
                dblDivisaoEscalaY2 = Math.Round(dblValorY2 / 10, 1)
            ElseIf Math.Abs(dblValorY2) >= 0.1 Then
                dblDivisaoEscalaY2 = Math.Round(dblValorY2 / 10, 2)
            ElseIf Math.Abs(dblValorY2) >= 0.01 Then
                dblDivisaoEscalaY2 = Math.Round(dblValorY2 / 10, 3)
            ElseIf Math.Abs(dblValorY2) >= 0.001 Then
                dblDivisaoEscalaY2 = Math.Round(dblValorY2 / 10, 4)
            Else
                dblDivisaoEscalaY2 = dblValorY2 / 10
            End If
        End If

    End Sub

    Private Sub PreencheListaConvertida(ByVal strUnidade As String)

        'ESSA FUNÇÃO FILTRA O MENOR E O MAIOR VALOR DE CADA LISTA ATIVA EM Y1, EM SEGUIDA CONVERTE ESSES DOIS VALORES PARA UMA UNIDADE SIMILAR       

        Try

            'Realiza a conversão para a unidade selecionada
            Select Case True
                Case strUnidade.Contains("Pressão")
                    Call ConvertePressao(strUnidade)
                Case strUnidade.Contains("Força")
                    Call ConverteCarga(strUnidade)
                Case strUnidade.Contains("Temperatura")
                    Call ConverteTemperatura(strUnidade)
                Case strUnidade.Contains("Tempo")
                    Call ConverteTempo(strUnidade)
                Case strUnidade.Contains("Volume")
                    Call ConverteVolume(strUnidade)
                Case strUnidade.Contains("Deslocamento")
                    Call ConverteDeslocamento(strUnidade)
                Case strUnidade.Contains("Vazão")
                    Call ConverteVazao(strUnidade)
            End Select

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("PreencheListaConvertida" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub ConvertePressao(ByVal strUnidade As String)

        Dim dblMenorValorTemp, dblMaiorValorTemp As Double

        Try

            If strUnidade.Contains("MPa") Then

                dblMenorValorTemp = dblScaleMinY / 1000

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY / 1000


            ElseIf strUnidade.Contains("bar") Then

                dblMenorValorTemp = dblScaleMinY / 100

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY / 100


            ElseIf strUnidade.Contains("kgf/cm²") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 98.0665, 0)

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 98.0665, 0)

            ElseIf strUnidade.Contains("ksi") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 6894.7591, 0)

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 6894.7591, 0)

            ElseIf strUnidade.Contains("psi") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 6.8948, 0)

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 6.8948, 0)

            Else

                dblMenorValorTemp = dblScaleMinY

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY

            End If


            'Recebe o menor e o maior valor filtrado (já arredondado)
            dblScaleMinY2 = dblMenorValorTemp
            dblScaleMaxY2 = dblMaiorValorTemp


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConvertePressao" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub ConverteCarga(ByVal strUnidade As String)

        Dim dblMenorValorTemp, dblMaiorValorTemp As Double

        Try

            If strUnidade.Contains("tf") Then

                dblMenorValorTemp = dblScaleMinY / 1000

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY / 1000

            ElseIf strUnidade.Contains("kN") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 101.9716, 1)

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 101.9716, 1)

            ElseIf strUnidade.Contains("N") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 0.10197, 0)

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 0.10197, 0)

            ElseIf strUnidade.Contains("lbf") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 0.4536, 0)

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1

                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 0.4536, 0)

            Else

                dblMenorValorTemp = dblScaleMinY
                dblMaiorValorTemp = dblScaleMaxY

            End If

            'Recebe o menor e o maior valor filtrado (já arredondado)
            dblScaleMinY2 = dblMenorValorTemp
            dblScaleMaxY2 = dblMaiorValorTemp

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConverteCarga" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub ConverteTemperatura(ByVal strUnidade As String)

        Dim dblMenorValorTemp, dblMaiorValorTemp As Double

        Try

            If strUnidade.Contains("K") Then

                'T (K) = T (° C) + 273,15

                dblMenorValorTemp = Math.Round(dblScaleMinY + 273.15, 1)

                'No maior valor considera também o zoom que o gráfico irá dar para definir o maior valor da escala convertida
                dblMaiorValorTemp = Math.Round(dblScaleMaxY + 273.15, 1)

            ElseIf strUnidade.Contains("°F") Then

                'T(° F) = T(° C) × 9/5 + 32

                dblMenorValorTemp = Math.Round((dblScaleMinY * 9 / 5) + 32, 1)

                'No maior valor considera também o zoom que o gráfico irá dar para definir o maior valor da escala convertida
                dblMaiorValorTemp = Math.Round((dblScaleMaxY * 9 / 5) + 32, 1)

            Else

                dblMenorValorTemp = dblScaleMinY
                dblMaiorValorTemp = dblScaleMaxY

            End If

            'Recebe o menor e o maior valor filtrado (já arredondado)
            dblScaleMinY2 = dblMenorValorTemp
            dblScaleMaxY2 = dblMaiorValorTemp

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConverteTemperatura" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub ConverteTempo(ByVal strUnidade As String)

        Dim dblMenorValorTemp, dblMaiorValorTemp As Double

        Try

            If strUnidade.Contains("min") Then

                dblMenorValorTemp = dblScaleMinY / 60
                dblMaiorValorTemp = dblScaleMaxY / 60


            ElseIf strUnidade.Contains("h") Then

                dblMenorValorTemp = dblScaleMinY / 3600
                dblMaiorValorTemp = dblScaleMaxY / 3600


            ElseIf strUnidade.Contains("dia") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 86400, 0)
                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 86400, 0)

            ElseIf strUnidade.Contains("mês") Then

                dblMenorValorTemp = Math.Round(dblScaleMinY / 2592000, 0)
                dblMaiorValorTemp = Math.Round(dblScaleMaxY / 2592000, 0)

            Else

                dblMenorValorTemp = dblScaleMinY
                dblMaiorValorTemp = dblScaleMaxY

            End If


            'Recebe o menor e o maior valor filtrado (já arredondado)
            dblScaleMinY2 = dblMenorValorTemp
            dblScaleMaxY2 = dblMaiorValorTemp


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConverteTempo" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub ConverteVolume(ByVal strUnidade As String)

        Dim dblMenorValorTemp, dblMaiorValorTemp As Double

        Try

            If strUnidade.Contains("ml") Then
                'ml = cm³
                dblMenorValorTemp = dblScaleMinY
                dblMaiorValorTemp = dblScaleMaxY

            Else

                'Litros
                dblMenorValorTemp = dblScaleMinY / 1000
                dblMaiorValorTemp = dblScaleMaxY / 1000

            End If

            'Recebe o menor e o maior valor filtrado (já arredondado)
            dblScaleMinY2 = dblMenorValorTemp
            dblScaleMaxY2 = dblMaiorValorTemp

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConverteVolume" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub ConverteDeslocamento(ByVal strUnidade As String)

        Dim dblMenorValorTemp, dblMaiorValorTemp As Double

        Try

            If strUnidade.Contains("µm") Then

                dblMenorValorTemp = dblScaleMinY / 0.001

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY / 0.001

            ElseIf strUnidade.Contains("cm") Then

                dblMenorValorTemp = dblScaleMinY / 10

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY / 10

            ElseIf strUnidade.Contains("in") Then

                dblMenorValorTemp = dblScaleMinY / 25.4

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY / 25.4

            Else

                dblMenorValorTemp = dblScaleMinY

                'Para o maior valor já considera a multiplicação pelo zoom da escala de Y1
                dblMaiorValorTemp = dblScaleMaxY

            End If

            'Recebe o menor e o maior valor filtrado (já arredondado)
            dblScaleMinY2 = dblMenorValorTemp
            dblScaleMaxY2 = dblMaiorValorTemp

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConverteDeslocamento" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub ConverteVazao(ByVal strUnidade As String)

        Dim dblMenorValorTemp, dblMaiorValorTemp As Double

        Try
            'ml/min

            dblMenorValorTemp = dblScaleMinY
            dblMaiorValorTemp = dblScaleMaxY

            'Recebe o menor e o maior valor filtrado (já arredondado)
            dblScaleMinY2 = dblMenorValorTemp
            dblScaleMaxY2 = dblMaiorValorTemp

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConverteVazao" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub trackLineLabel(ByVal c As XYChart, ByVal mouseX As Integer)

        ' Clear the current dynamic layer and get the DrawArea object to draw on it.
        Dim d As DrawArea = c.initDynamicLayer()

        ' The plot area object
        Dim plotArea As PlotArea = c.getPlotArea()

        ' Get the data x-value that is nearest to the mouse, and find its pixel coordinate.
        Dim xValue As Double = c.getNearestXValue(mouseX)
        Dim xCoor As Integer = c.getXCoor(xValue)
        If xCoor < plotArea.getLeftX() Then
            Return
        End If

        ' Draw a vertical track line at the x-position
        d.vline(plotArea.getTopY(), plotArea.getBottomY(), xCoor, &H888888)

        '' Draw a label on the x-axis to show the track line position.
        'Dim xlabel As String = "<*font,bgColor=000000*> " & c.xAxis().getFormattedLabel(xValue,
        '    "hh:nn:ss.ff") & " <*/font*>"

        Dim xlabel As String = "<*font,bgColor=000000*> " & xValue & " <*/font*>"
        'Dim xlabel As String = "<*font,bgColor=FFFFFFFF*> Eixo X: " & xValue

        Dim t As TTFText = d.text(xlabel, "Arial Bold", 10)

        ' Restrict the x-pixel position of the label to make sure it stays inside the chart image.
        Dim xLabelPos As Integer = Math.Max(0, Math.Min(xCoor - t.getWidth() / 2,
            c.getWidth() - t.getWidth()))
        t.draw(xLabelPos, plotArea.getBottomY() + 6, &HFFFFFF)

        ' Iterate through all layers to draw the data labels
        For i As Integer = 0 To c.getLayerCount() - 1
            Dim layer As Layer = c.getLayerByZ(i)

            ' The data array index of the x-value
            Dim xIndex As Integer = layer.getXIndexOf(xValue)

            ' Iterate through all the data sets in the layer
            For j As Integer = 0 To layer.getDataSetCount() - 1
                Dim dataSet As ChartDirector.DataSet = layer.getDataSetByZ(j)

                ' Get the color and position of the data label
                Dim color As Integer = dataSet.getDataColor()
                Dim yCoor As Integer = c.getYCoor(dataSet.getPosition(xIndex), dataSet.getUseYAxis())

                ' Draw a track dot with a label next to it for visible data points in the plot area
                If (yCoor >= plotArea.getTopY()) And (yCoor <= plotArea.getBottomY()) And (color <>
                    Chart.Transparent) Then

                    d.circle(xCoor, yCoor, 4, 4, color, color)

                    Dim label As String = "<*font,bgColor=" & Hex(color) & "*> " & c.formatValue(
                        dataSet.getValue(xIndex), "{value|P4}") & " <*/font*>"
                    t = d.text(label, "Arial Bold", 10)

                    ' Draw the label on the right side of the dot if the mouse is on the left side the chart,
                    ' and vice versa. This ensures the label will not go outside the chart image.
                    If xCoor <= (plotArea.getLeftX() + plotArea.getRightX()) / 2 Then
                        t.draw(xCoor + 5, yCoor, &HFFFFFF, Chart.Left)
                    Else
                        t.draw(xCoor - 5, yCoor, &HFFFFFF, Chart.Right)
                    End If
                End If
            Next
        Next

    End Sub

    Public Sub SelecionarModoZoom(ByRef objChartViewer As WinChartViewer, ByVal intModo As Integer)

        objChartViewer.MouseUsage = intModo

    End Sub

    Public Sub crossHair(c As XYChart, mouseX As Integer, mouseY As Integer)

        ' Clear the current dynamic layer and get the DrawArea object to draw on it.
        Dim d As DrawArea = c.initDynamicLayer()

        ' The plot area object
        Dim plotArea As PlotArea = c.getPlotArea()

        ' Draw a vertical line and a horizontal line as the cross hair
        d.vline(plotArea.getTopY(), plotArea.getBottomY(), mouseX, d.dashLineColor(&H0, &H101))
        d.hline(plotArea.getLeftX(), plotArea.getRightX(), mouseY, d.dashLineColor(&H0, &H101))

        ' Draw y-axis label
        Dim label As String = "<*block,bgColor=FFFFDD,margin=3,edgeColor=000000*>" & c.formatValue(
            c.getYValue(mouseY, c.yAxis()), "{value|P4}") & "<*/*>"
        Dim t As TTFText = d.text(label, "Arial Bold", 8)
        t.draw(plotArea.getLeftX() - 5, mouseY, &H0, Chart.Right)

        ' Draw x-axis label
        label = "<*block,bgColor=FFFFDD,margin=3,edgeColor=000000*>" & c.formatValue(c.getXValue(mouseX),
            "{value|P4}") & "<*/*>"
        t = d.text(label, "Arial Bold", 8)
        t.draw(mouseX, plotArea.getBottomY() + 5, &H0, Chart.Top)

    End Sub

    Public Function PegarValorY(valorY As Double, c As XYChart) As Double
        Dim yConvertido As Double = c.getYValue(valorY, c.yAxis())
        Return yConvertido

    End Function

    Public Sub trackBoxLegend(c As XYChart, mouseX As Integer, mouseY As Integer)
        Dim d As DrawArea = c.initDynamicLayer()
        Dim plotArea As PlotArea = c.getPlotArea()
        Dim xValue As Double = c.getNearestXValue(mouseX)
        Dim xCoor As Integer = c.getXCoor(xValue)
        Dim xlabel As String = "<*font,bgColor=FFFFFFFF*> Logaritmo da Pressão (kgf/cm²): " & xValue
        '00 00 00 00     AA RR GG BB  'Dim xlabel As String = "<*font,bgColor=00F5F5F5*> Logaritmo da Pressão (kgf/cm²): " & xValue '& " <*/font*>"
        Dim t As TTFText = d.text(xlabel, "Arial Bold", 8)
        For i As Integer = 0 To c.getLayerCount() - 1
            Dim layer As Layer = c.getLayerByZ(i)
            Dim xIndex As Integer = layer.getXIndexOf(xValue)
            For j As Integer = 0 To layer.getDataSetCount() - 1
                Dim dataSet As ChartDirector.DataSet = layer.getDataSetByZ(j)
                Dim colorDataLabel As Integer = dataSet.getDataColor()
                Dim yCoor As Integer = c.getYCoor(dataSet.getPosition(xIndex), dataSet.getUseYAxis())
                If (yCoor >= plotArea.getTopY()) And (yCoor <= plotArea.getBottomY()) And (colorDataLabel <>
                    Chart.Transparent) Then
                    d.circle(xCoor, yCoor, 4, 4, colorDataLabel, colorDataLabel)
                    Dim label As String = "<*br*>Índice de vazios: " & c.formatValue(dataSet.getValue(xIndex), "{value|P4}") & " <*/font*>"
                    t = d.text((xlabel & " " & label), "Arial Bold", 8)
                    If xCoor <= (plotArea.getLeftX() + plotArea.getRightX()) / 2 Then
                        t.draw(xCoor + 5, yCoor, RGB(0, 0, 0), Chart.Left)
                    Else
                        t.draw(xCoor - 5, yCoor, RGB(0, 0, 0), Chart.Right)
                    End If
                End If
            Next
        Next
    End Sub

    ''-----------------------------------------------------------------------------------------------
    ''CRIAR UM LINHA DE REFERÊNCIA NO GRÁFICO - SETPOINT/THRESHOLD
    '' Add a horizontal mark line to the chart at y = 40
    'Dim mark As Mark = objChart.yAxis().addMark(5290, -1, "Threshold")
    'mark.setLineWidth(2)
    '' Set the mark line to purple (880088) dash line. Use white (ffffff) for the mark label.
    'mark.setMarkColor(objChart.dashLineColor(&H880088), &HFFFFFF)
    '' Put the mark label at the left side of the mark, with a purple (880088) background.
    'mark.setAlignment(Chart.Left)
    'mark.setBackground(&H880088)
    ''-----------------------------------------------------------------------------------------------

    '------------------------------------------------------------------------------------------------
    ' Quando quer mostrar os dois eixos Y com a mesma escala
    '.syncYAxis()
    '------------------------------------------------------------------------------------------------


End Class
