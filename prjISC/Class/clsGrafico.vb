Option Explicit On
Imports FLPGRFLib

Public Class clsGrafico
    'Contenco Industria e Comercio Ltda.
    'Arquivo que trata a classe de tratamento de graficos Flipper Graph especificamente para a Contenco

    Public Sub InicializaGrafico(ByRef objGrf As AxFLPGRFLib.AxFlpGrf, ByVal intData As Integer, ByVal intTipo As Integer, ByVal strTitulo As String, _
           ByVal strCoordX As String, ByVal strCoordY As String)

        'Inicializa o grafico
        Try

            'Dados gerais
            'Dimensões e tipo do gráfico, formatação do título
            With objGrf
                .DataInit = intData                             'Dimensões do gráfico
                .GraphType = intTipo                            'Tipo do gráfico

                'Detalhes do título
                .GraphTitle = strTitulo                         'Título do gráfico
                .GraphTitleColor = Color.DarkBlue               'Cor do título
                .FontOpen = "Verdana,8,B"                       'Fonte do título
                .GraphTitleFont = .FontCurrent                  'Campo título recebe seus atributos
                .ObjectFindButton(1)

                'Definição do eixo (X) - Tempo
                .Axis = flpAxisNumber.flpX
                .AxisScaleManual = True
                .AxisScaleSkip = 1                              'Subdivisões entre os pontos de escala
                .AxisScaleMin = 0                               'Início da escala
                .AxisScaleMax = 30                              'Fim da escala
                .AxisScaleInc = 1.5                             'Quantidade de intervalos vezes 2
                .AxisScaleDec = 0                               'Número de casas decimais
                .AxisDecimalSeparator = ","                     'Decimal ponto ou vírgula
                .AxisGrid = True                                'Mostra grades
                .AxisGridPattern = 0 '1                         'Determina espessura das grades
                .AxisTitle = strCoordX                          'Nome da abscissa
                .AxisTitleDistance = 1                          'Distância do nome da abscissa do gráfico
                .FontOpen = "Verdana,8,B"                       'Fonte do título
                .AxisTitleFont = .FontCurrent                   'Campo nome recebe seus atributosF
                .AxisTitleColor = Color.DarkBlue                'Cor do nome
                .AxisGridColor = Color.LightGray 'Color.Gray    'Determina a cor da grade
                .AxisScaleColor = Color.DarkBlue                'Cor das escalas

                'Definição do eixo (Y)
                .Axis = flpAxisNumber.flpY
                .AxisScaleManual = True
                .AxisScaleSkip = 1                              'Subdivisões entre os pontos de escala
                .AxisScaleMin = 0                               'Início da escala
                .AxisScaleMax = 50                              'Fim da escala
                .AxisScaleInc = 5                               'Quantidade de intervalos vezes 2
                .AxisScaleDec = 0                               'Número de casas decimais
                .AxisDecimalSeparator = ","                     'Decimal ponto ou vírgula
                .AxisGrid = True                                'Mostra grades
                .AxisGridPattern = 0 '1                          'Determina espessura das grades
                .AxisTitle = strCoordY                          'Nome da abscissa
                .AxisTitleDistance = 1                          'Distância do nome da abscissa do gráfico
                .FontOpen = "Verdana,8,B"                       'Fonte do título
                .AxisTitleFont = .FontCurrent                   'Campo nome recebe seus atributos
                .AxisTitleColor = Color.DarkBlue                'Cor do nome
                .AxisGridColor = Color.LightGray 'Color.Gray    'Determina a cor da gradee
                .AxisScaleColor = Color.DarkBlue                'Cor das escalas

                If intData = 2 Then
                    .Column = 1                                 'Determinação da segunda columa
                    .ColumnAxis = flpAxisNumber.flpY
                    .ColumnLabels = 0
                    .ColumnLineWidth = 1
                    .ColumnType = flpColumnType.flpCurvedLine
                    .ColumnColor = Color.Red                    'Cor da linha traçada vermelho
                    .ColumnStyle = 12
                    .ColumnMarkSize = 2
                Else
                    .Column = 1                                 'Determinação da segunda columa
                    .ColumnAxis = flpAxisNumber.flpY
                    .ColumnLabels = 0
                    .ColumnLineWidth = 1
                    .ColumnType = flpColumnType.flpLine
                    .ColumnColor = Color.Red                    'Cor da linha traçada vermelho
                    .ColumnStyle = 12
                    .ColumnMarkSize = 2                         'Apresentação de marcas para os pontos
                    .Column = 2                                 'Determinação da segunda columa
                    .ColumnAxis = flpAxisNumber.flpY
                    .ColumnType = flpColumnType.flpNone
                    .ColumnColor = Color.Red                    'Cor da linha traçada vermelho
                    .ColumnMarkSize = 2                         'Apresentação de marcas para os pontos
                    .ColumnPattern = 0                          'Linha
                End If

                .GraphFrameColor = Color.Gray               'Borda do gráfico

            End With

        Catch ex As Exception

            MsgBox("InicializaGrafico()" & Chr(13) & ex.Message)
            'usrDiversos.ExibeErros(ex.Message)

        End Try
    End Sub

#Region "PROCEDIMENTOS DAS ESCALAS"



    Public Sub AjustarEscalaAutomatico(ByRef objGrf As AxFLPGRFLib.AxFlpGrf, ByRef objSliderX As Windows.Forms.TrackBar, ByRef objSliderY As Windows.Forms.TrackBar, _
            ByVal dblValorX As Double, ByVal dblValorY As Double)
        'Ajusta a escala do gráfico automaticamente

        Dim dblAjusteX As Double
        Dim dblAjusteY As Double

        Try

            'Penetração (mm)
            objGrf.Axis = flpAxisNumber.flpX   'X
            If objSliderX.Value < 6 Then
                If objGrf.AxisScaleMax <= dblValorX Then

                    objGrf.AxisScaleMax = dblAjusteX
                    objGrf.AxisScaleInc = dblAjusteX / 20
                    objSliderX.Value = objSliderX.Value + 1
                End If
            End If
            'Pressão (kgf/cm²)
            objGrf.Axis = flpAxisNumber.flpY   'Y
            If objSliderY.Value < 6 Then
                If objGrf.AxisScaleMax <= dblValorY Then

                    objGrf.AxisScaleMax = dblAjusteY
                    objGrf.AxisScaleInc = dblAjusteY / 20
                    objSliderY.Value = objSliderY.Value + 1
                End If
            End If

        Catch ex As Exception
            MsgBox("AjustarEscalaAutomatico()" & Chr(13) & ex.Message)
            'usrDiversos.ExibeErros(ex.Message)
        End Try

    End Sub

    Public Sub DividirEscalas(ByRef objGrf As AxFLPGRFLib.AxFlpGrf, ByVal dblMaximo As Double)
        Try

            Select Case dblMaximo / 20
                Case Is <= 0.01
                    objGrf.AxisScaleDec = 3
                    objGrf.AxisScaleMax = FormatNumber(dblMaximo, 3)
                    objGrf.AxisScaleInc = FormatNumber(dblMaximo / 20, 4)
                Case Is <= 0.1
                    objGrf.AxisScaleDec = 2
                    objGrf.AxisScaleMax = FormatNumber(dblMaximo, 2)
                    objGrf.AxisScaleInc = FormatNumber(dblMaximo / 20, 3)
                Case Is <= 1
                    objGrf.AxisScaleDec = 1
                    objGrf.AxisScaleMax = FormatNumber(dblMaximo, 1)
                    objGrf.AxisScaleInc = FormatNumber(dblMaximo / 20, 2)
                Case Else
                    objGrf.AxisScaleDec = 0
                    objGrf.AxisScaleMax = FormatNumber(dblMaximo, 0)
                    objGrf.AxisScaleInc = FormatNumber(dblMaximo / 20, 1)
            End Select

        Catch ex As Exception
            MsgBox("DividirEscalas()" & Chr(13) & ex.Message)
            'usrDiversos.ExibeErros(ex.Message)
        End Try

    End Sub

#End Region

#Region "CONFIGURAÇÕES"

    Public Function ConfiguraEditar(ByRef objGrf As FlpGrf, ByVal intPropriedades As Integer) As Boolean
        'Configura as edicoes no grafico
        'Entrada:
        ' objGrf - grafico Flipper Graph a ser editado
        ' blnPropriedades - vetor de 4 posicoes (a partir do zero) indicando se as propriedades Axis, Data, Graph e Other serao escolhidas na edicao
        'Saida:
        ' verdade se sucesso
        Try

            Dim intConfiguracao As Integer  'Configuracao calculada

            'Calcula a configuracao a ser utilizada
            intConfiguracao = 0
            If intPropriedades = 0 Then intConfiguracao = flpGraphEdit.flpAxisMenus
            If intPropriedades = 1 Then intConfiguracao = intConfiguracao + flpGraphEdit.flpDataMenus
            If intPropriedades = 2 Then intConfiguracao = intConfiguracao + flpGraphEdit.flpGraphMenus
            If intPropriedades = 3 Then intConfiguracao = intConfiguracao + flpGraphEdit.flpOtherMenus

            'Configura edicao
            Call objGrf.ObjectFindButton(2)
            objGrf.GraphEdit = intConfiguracao

            'Termina normalmente
            ConfiguraEditar = True

            Exit Function


        Catch ex As Exception
            ConfiguraEditar = False
            MsgBox("ConfiguraEditar()" & Chr(13) & ex.Message)
            'usrDiversos.ExibeErros(ex.Message)
        End Try

    End Function

    Public Function ConfiguraZoom(ByRef objGrf As FlpGrf, ByVal blnAmpliado As Boolean) As Boolean
        'Configura zoom do grafico
        'Entrada:
        ' objGrf - grafico Flipper Graph a ser editado
        ' blnAmpliado - zoom normal (false) ou ampliado (true)
        'Saida:
        ' verdade se sucesso
        Try

            'Configura zoom
            With objGrf
                If Not blnAmpliado Then
                    .Axis = flpAxisNumber.flpX
                    .AxisScaleSkip = 1                              'Subdivisões entre os pontos de escala
                    .AxisScaleMin = 0                               'Início da escala
                    .AxisScaleMax = 60                              'Fim da escala
                    .AxisScaleInc = 3                               'Quantidade de intervalos vezes 2
                    .AxisScaleDec = 1                               'Número de casas decimais

                    .Axis = flpAxisNumber.flpY
                    .AxisScaleSkip = 1                              'Subdivisões entre os pontos de escala
                    .AxisScaleMin = 0                               'Início da escala
                    .AxisScaleMax = 1000                            'Fim da escala
                    .AxisScaleInc = 50                              'Quantidade de intervalos vezes 2
                    .AxisScaleDec = 0                               'Número de casas decimais

                    .ObjectFindButton(1)
                    .ObjectFindAutoZoom = False
                Else
                    .ObjectFindButton(5)
                    .ObjectFindAutoZoom = True
                End If
            End With

            'Termina normalmente
            ConfiguraZoom = True

            Exit Function


        Catch ex As Exception

            ConfiguraZoom = False
            MsgBox("ConfiguraZoom()" & Chr(13) & ex.Message)
            'usrDiversos.ExibeErros(ex.Message)

        End Try
    End Function

#End Region

End Class
