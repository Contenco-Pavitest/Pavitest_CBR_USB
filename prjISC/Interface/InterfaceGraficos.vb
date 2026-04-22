Public Interface InterfaceGraficos
    ' <summary>
    ' Obtem o Nome do Grafico
    ' </summary>
    Function Nome() As String

    ''' <summary>
    ''' Este Método Cria o Gráfico e atribuí ao objeto WinChartViewer no WinForms.
    ''' </summary>
    ''' <param name="WinChartViewer">Objeto ChartDirector.WinChartViewer proveniente da caixa de Ferramentas que será usado para plotar o gráfico.</param>
    Sub createChart(ByVal WinChartViewer As ChartDirector.WinChartViewer)
End Interface
