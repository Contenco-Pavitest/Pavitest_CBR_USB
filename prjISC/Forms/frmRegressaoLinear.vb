
Imports ChartDirector
Imports System.Collections
Imports System.Data.OleDb

Public Class frmRegressaoLinear
    Dim listax As New List(Of Double)
    Public graficoPavitest As New clsGraficoChart
    Dim M, B As Double
    Dim blnSairSub As Boolean


    Public dblY1_Anterior, dblY1_IgualOuPosterior, dblX1_Anterior, dblX1_IgualOuPosterior As Double
    Public dblY2_Posterior, dblY2_IgualOuAnterior, dblX2_Posterior, dblX2_IgualOuAnterior As Double


    Private Sub frmRegressaoLinear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call VerificaResultadosBD()
    End Sub

    Private Sub btnRecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'Calcular Regressão para determinar Pressão Corrigida
        Dim i As Integer
        Dim j As Integer
        Dim strMsg As String

        'Limpar variáveis
        blnEncontrouMaiorMenorY1 = False
        blnEncontrouMaiorMenorY2 = False
        dblResultMaiorYP1 = 0
        dblResultMenorYP1 = 0
        dblResultMaiorXP1 = 0
        dblResultMenorXP1 = 0
        dblResultMaiorYP2 = 0
        dblResultMenorYP2 = 0
        dblResultMaiorxP2 = 0
        dblResultMenorxP2 = 0


        Try

            If blnMudouUnidadeMPa = False Then
                Call usrDiversos.TransfereListasParaMatriz(listaPenetracao, listaPressaokgfcm2)
            Else
                Call usrDiversos.TransfereListasParaMatriz(listaPenetracao, listaPressaoMPa)
            End If

            'Localiza 2 pontos mais próximos dentro do intervalo digitado
            Call LocalizarYMaisProximos(dblMatriz)

            If blnSairSub Then Exit Sub

            If blnReverEnsaio Then
                With frmRever.graficoPavitest
                    .blnTrendLayer = True
                    'Chama a plotagem do gráfico com a primeira regressão
                    .AtualizarGraficoMultiplasListas()
                    .blnRegressaoLinear2 = True
                    .blnRegressaoLinear3 = True
                End With
            Else
                With frmGraficoPavitest.graficoPavitest
                    .blnTrendLayer = True
                    'Chama a plotagem do gráfico com a primeira regressão
                    .AtualizarGraficoMultiplasListas()
                    .blnRegressaoLinear2 = True
                    .blnRegressaoLinear3 = True
                End With
            End If

            'Calcula o valor de X quando Y=0, dessa forma X terá o valor do parâmetro C da norma NBR 9895.
            If dblA <> 0 Then dblX = (dblY - dblB) / dblA Else dblX = 0

            strMsg = "Valores calculados na regressão linear (y = Ax + B):" & Chr(13) & Chr(13) &
                    "      A = " & FormatNumber(dblA, 1) & Chr(13) &
                    "      B = " & FormatNumber(dblB, 1) & Chr(13) &
                    "      Deslocamento (C) = " & FormatNumber(dblX, 3) & " mm."
            Call MsgBox(strMsg, vbInformation, "Deslocamento (C)")

            'Verifica se o valor da correção é um valor inválido (menor que zero)
            If dblX < 0 Then
                MsgBox("Os valores inseridos para Y1 e Y2 representam um intervalo inadequado para correção de uma possível inflexão. Insira um novo intervalo!", MsgBoxStyle.Exclamation, "Intervalo Inválido")
                txtY1.Text = ""
                txtY2.Text = ""
                lblISC1.Text = ""
                lblISC2.Text = ""
                Exit Sub
            End If

            Call LocalizarPontosCorrigidos(dblX, dblMatriz)

            'Localiza 2 pontos mais próximos do ponto X1 corrigido e outros 2 pontos mais próximos do ponto X2 corrigido                Call LocalizarPontosCorrigidos(dblX, dblMatriz)
            If blnEncontrouMaiorMenorY1 = False Or blnEncontrouMaiorMenorY2 = False Then
                MsgBox("Não foram encontrados pontos para o intervalo inserido!", MsgBoxStyle.Exclamation, "Intervalo Inválido")
                Exit Sub
            End If

            If blnReverEnsaio Then
                frmRever.graficoPavitest.AtualizarGraficoMultiplasListas()
                'Chama a plotagem do gráfico para a segunda e terceira regressões com os valores corrigidos
            Else
                frmGraficoPavitest.graficoPavitest.AtualizarGraficoMultiplasListas()
                'Chama a plotagem do gráfico para a segunda e terceira regressões com os valores corrigidos
            End If

            'Calcula o resultado percentual ISC com os valores de Y1 e Y2 corrigidos
            Call CalcularResultadoISC()

            If blnMudouUnidadeMPa = False Then
                strMsg = "Valor da pressão corrigida:" & Chr(13) & Chr(13) &
                 "      Penteração " & FormatNumber(2.54 + dblX, 2) & " mm = " & FormatNumber(dblValorYCorrigido1, 2) & " (kgf/cm²). " & Chr(13) &
                 "      Penteração " & FormatNumber(5.08 + dblX, 2) & " mm = " & FormatNumber(dblValorYCorrigido2, 2) & " (kgf/cm²). " & Chr(13) &
                 Chr(13) & Chr(13) &
                 "Deseja gravar os valores?"
            Else
                strMsg = "Valor da pressão corrigida:" & Chr(13) & Chr(13) &
                 "      Penteração " & FormatNumber(2.54 + dblX, 2) & " mm = " & FormatNumber(dblValorYCorrigido1, 2) & " (MPa). " & Chr(13) &
                 "      Penteração " & FormatNumber(5.08 + dblX, 2) & " mm = " & FormatNumber(dblValorYCorrigido2, 2) & " (MPa). " & Chr(13) &
                 Chr(13) & Chr(13) &
                 "Deseja gravar os valores?"
            End If

            If MsgBox(strMsg, vbQuestion + vbYesNo, "Gravar Correção") = vbYes Then
                Call frmGraficoPavitest.GravarCorrecao(dblValorYCorrigido1, dblValorYCorrigido2, txtY1.Text, txtY2.Text)
                blnAtualizarTelaCadastro = True
            End If


            If Not VerificarY() Then Exit Sub

            'Habilitar comando resetar
            btnReset.Enabled = True

            btnOk.Enabled = True

        Catch ex As Exception
            MsgBox("btnRecalcular_Click()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "cmdRecalcular_Click" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub LocalizarPontosCorrigidos(ByVal dblCorrecao As Double, ByVal matriz(,) As Double)
        'Calcular valor corrigido

        dblX1_Corrigido = 2.54 + dblCorrecao
        dblX2_Corrigido = 5.08 + dblCorrecao

        Try


            For index As Integer = 0 To (matriz.Length / 2) - 1
                If matriz(0, index) > dblX1_Corrigido Then
                    dblResultMaiorYP1 = matriz(1, index)
                    dblResultMenorYP1 = matriz(1, index - 1)
                    dblResultMaiorXP1 = matriz(0, index)
                    dblResultMenorXP1 = matriz(0, index - 1)
                    blnEncontrouMaiorMenorY1 = True

                    Exit For
                End If
            Next

            For index As Integer = 0 To (matriz.Length / 2) - 1
                If matriz(0, index) > dblX2_Corrigido Then
                    dblResultMaiorxP2 = matriz(0, index)
                    dblResultMenorxP2 = matriz(0, index - 1)
                    dblResultMaiorYP2 = matriz(1, index)
                    dblResultMenorYP2 = matriz(1, index - 1)
                    blnEncontrouMaiorMenorY2 = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("LocalizarPontosCorrigidos" & Chr(13) & ex.Message.ToString)
        End Try

    End Sub

    Public Sub CalcularResultadoISC()
        'Calcular valor corrigido
        Dim dblResult1 As Double
        Dim dblResult2 As Double

        Try

            If blnMudouUnidadeMPa = False Then
                dblISC1 = Math.Round(dblValorYCorrigido1 * 100 / 70.31, 2) '6,9 MPa ou 70,36 kgf/cm²
            Else
                dblISC1 = Math.Round(dblValorYCorrigido1 * 100 / 6.9, 2) 'MPa ou 70,36 kgf/cm²
            End If

            'txtCorrigida0.Text = FormatNumber(dblResult1, 1)
            lblISC1.Text = FormatNumber(dblISC1, 2)

            If blnMudouUnidadeMPa = False Then
                dblISC2 = Math.Round(dblValorYCorrigido2 * 100 / 105.46, 2) '10,35 MPa ou 105,46 kgf/cm²
            Else
                dblISC2 = Math.Round(dblValorYCorrigido2 * 100 / 10.35, 2) 'MPa ou 105,46 kgf/cm²
            End If

            'txtCorrigida1.Text = FormatNumber(dblResult2, 1)
            lblISC2.Text = FormatNumber(dblISC2, 2)

            If blnEnsaioGravado = False Then
                'exibe na tabela da tela de ensaio
                frmGraficoPavitest.txtCorrigida0.Text = FormatNumber(dblValorYCorrigido1, 2)
                frmGraficoPavitest.txtCorrigida1.Text = FormatNumber(dblValorYCorrigido2, 2)
                frmGraficoPavitest.txtISC0.Text = FormatNumber(dblISC1, 2)
                frmGraficoPavitest.txtISC1.Text = FormatNumber(dblISC2, 2)
            Else
                'exibe na tabela da tela de rever
                frmRever.txtCorrigida0.Text = FormatNumber(dblValorYCorrigido1, 2)
                frmRever.txtCorrigida1.Text = FormatNumber(dblValorYCorrigido2, 2)
                frmRever.txtISC0.Text = FormatNumber(dblISC1, 2)
                frmRever.txtISC1.Text = FormatNumber(dblISC2, 2)
            End If

        Catch ex As Exception
            MsgBox("CalcularResultadoISC()" & Chr(13) & ex.Message)
        End Try

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
            If Not IsDBNull(odbReader("Y1".ToString)) Then
                If blnMudouUnidadeMPa = False Then
                    txtY1.Text = odbReader("Y1".ToString)
                Else
                    txtY1.Text = FormatNumber(odbReader("Y1".ToString) * 0.1, 2) 'Admite-se 1 kgf/cm² = 0,1 MPa
                End If
            End If

            If Not IsDBNull(odbReader("Y2".ToString)) Then
                If blnMudouUnidadeMPa = False Then
                    txtY2.Text = odbReader("Y2".ToString)
                Else
                    txtY2.Text = FormatNumber(odbReader("Y2".ToString) * 0.1, 2) 'Admite-se 1 kgf/cm² = 0,1 MPa
                End If
            End If

            If Not IsDBNull(odbReader("ISC1".ToString)) Then lblISC1.Text = FormatNumber(odbReader("ISC1".ToString), 2)
            If Not IsDBNull(odbReader("ISC2".ToString)) Then lblISC2.Text = FormatNumber(odbReader("ISC2".ToString), 2)

            odbReader.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("VerificaResultadosBD" & Chr(13) & ex.Message)

        End Try

    End Sub



    Private Sub LocalizarYMaisProximos(ByVal matriz(,) As Double)

        Try


            y1 = txtY1.Text
            y2 = txtY2.Text

            ''---------------------------------------------------------------------------------------------------------------------------------------------------------------------
            'IDENTIFICANDO O PONTO MAIS PRÓXIMO DE Y1 - DENTRO DO INTERVALO
            '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
            For i As Integer = 0 To (matriz.Length / 2) - 1
                'Se o valor analisado for maior ou igual ao primeiro ponto escolhido eu guardo a coordenada xy
                If matriz(1, i) >= txtY1.Text Then
                    dblY1_IgualOuPosterior = matriz(1, i) 'y1
                    dblX1_IgualOuPosterior = matriz(0, i) 'x1

                    If i > 0 Then
                        'Anoto um ponto anterior, para sugestão ao usuário, caso Y1 e Y2 detectados, sejam o mesmo ponto, o que não permitiria traçar uma reta com apenas 1 ponto
                        dblY1_Anterior = matriz(1, i - 1)
                        dblX1_Anterior = matriz(0, i - 1)
                    Else
                        'Se o já for o primeiro ponto da lista/array não tem como pegar um ponto anterior
                        dblY1_Anterior = dblY1_IgualOuPosterior
                        dblX1_Anterior = dblX1_IgualOuPosterior
                    End If

                    Exit For
                End If
            Next

            '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
            'IDENTIFICANDO O PONTO MAIS PRÓXIMO DE Y2 - DENTRO DO INTERVALO
            '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
            For i = 0 To (matriz.Length / 2) - 1
                'Se o valor analisado for igual ao segundo ponto escolhido eu guardo a coordenada xy
                If matriz(1, i) = txtY2.Text Then
                    dblY2_IgualOuAnterior = matriz(1, i) 'y2
                    dblX2_IgualOuAnterior = matriz(0, i) 'x2

                    'Se ainda não chegou a última posição da lista/array, posso pegar o ponto posterior
                    If i < (matriz.Length / 2) - 1 Then
                        dblY2_Posterior = matriz(1, i + 1)
                        dblX2_Posterior = matriz(0, i + 1)
                    Else
                        dblY2_Posterior = matriz(1, i)
                        dblX2_Posterior = matriz(0, i)
                    End If

                ElseIf matriz(1, i) > txtY2.Text Then
                    'Se o valor analisado for maior que Y2, eu pego o valor anterior dentro do intervalo, desde que esse não seja o primeiro ponto da lista/array 
                    If i > 0 Then
                        dblY2_IgualOuAnterior = matriz(1, i - 1) 'y2
                        dblX2_IgualOuAnterior = matriz(0, i - 1) 'x2

                        dblY2_Posterior = matriz(1, i)
                        dblX2_Posterior = matriz(0, i)

                    Else

                        dblY2_IgualOuAnterior = matriz(1, i) 'y2
                        dblX2_IgualOuAnterior = matriz(0, i) 'x2

                        'Se ainda não chegou a última posição da lista/array, posso pegar o ponto posterior 
                        If i < (matriz.Length / 2) - 1 Then
                            dblY2_Posterior = matriz(1, i + 1)
                            dblX2_Posterior = matriz(0, i + 1)
                        Else
                            dblY2_Posterior = matriz(1, i)
                            dblX2_Posterior = matriz(0, i)
                        End If

                    End If

                    Exit For

                ElseIf i = (matriz.Length / 2) - 1 And matriz(1, i) < txtY2.Text Then
                    dblY2_IgualOuAnterior = matriz(1, i) 'y2
                    dblX2_IgualOuAnterior = matriz(0, i) 'x2
                    dblY2_Posterior = matriz(1, i)
                    dblX2_Posterior = matriz(0, i)
                End If
            Next

            'Analisa se o ponto localizado para Y1 e Y2 é o mesmo, se for terá que ser utilizado um outro ponto mais próximo para traçar a reta da regressão
            If dblY1_IgualOuPosterior = dblY2_IgualOuAnterior Then
                'Se o valor anterior de Y1 e o valor posterior de Y2 são diferentes (é o que se espera), então
                If dblY1_Anterior <> dblY2_Posterior Then
                    If MsgBox("Dentro do intervalo inserido, foi encontrado apenas 1 ponto, contudo para traçar a reta são necessários dois pontos." & Chr(13) & Chr(13) & "Deseja utilizar um ponto mais próximo que esteja fora desse intervalo para complementar?", vbQuestion + vbYesNo, "Intervalo para Correção") = vbYes Then
                        'Pega o segundo valor que possuir a menor diferença

                        If (dblY2_IgualOuAnterior = dblY2_Posterior) Then
                            y1 = dblY1_Anterior
                            x1 = dblX1_Anterior
                            y2 = dblY2_IgualOuAnterior
                            x2 = dblX2_IgualOuAnterior
                        ElseIf dblY1_IgualOuPosterior = dblY1_Anterior Then
                            y1 = dblY1_IgualOuPosterior
                            x1 = dblX1_IgualOuPosterior
                            y2 = dblY2_Posterior
                            x2 = dblX2_Posterior
                        ElseIf (dblY1_IgualOuPosterior - dblY1_Anterior) <= (dblY2_Posterior - dblY2_IgualOuAnterior) Then
                            y1 = dblY1_Anterior
                            x1 = dblX1_Anterior
                            y2 = dblY2_IgualOuAnterior
                            x2 = dblX2_IgualOuAnterior
                        Else
                            y1 = dblY1_IgualOuPosterior
                            x1 = dblX1_IgualOuPosterior
                            y2 = dblY2_Posterior
                            x2 = dblX2_Posterior
                        End If
                    Else
                        blnSairSub = True
                        Exit Sub
                    End If
                Else
                    MsgBox("Escolha outro intervalo que contenha pelo menos dois pontos distintos para que a regressão linear possa ser feita!", MsgBoxStyle.Exclamation, "Intervalo Inválido")
                End If

            Else

                'Repassa 2 os pontos localizados dentro do intervalo
                y1 = dblY1_IgualOuPosterior
                x1 = dblX1_IgualOuPosterior
                y2 = dblY2_IgualOuAnterior
                x2 = dblX2_IgualOuAnterior

            End If

            ''Seleciona matriz.GetUpperBound(1) para dados de coluna na matriz, matriz.GetUpperBound(0) para dados de linha na matriz
            'Dim aux As Integer = matriz.GetUpperBound(1)
            ''Esse while irá varrer de trás para frente os valores para encontrar o compatível
            'While aux > 0

            '    If y2 > 0 Then
            '        If matriz(1, aux) > txtY2.Text Then
            '            y2 = matriz(1, aux) 'y2 = matriz(aux, 0)
            '            x2 = matriz(0, aux) 'x2 = matriz(aux, 1)
            '            'Exit While
            '        End If
            '    Else
            '        If matriz(1, aux) > txtY2.Text Then
            '            y2 = matriz(1, aux) 'y2 = matriz(aux, 0)
            '            x2 = matriz(0, aux) 'x2 = matriz(aux, 1)
            '            'Exit While
            '        End If
            '    End If

            '    aux = aux - 1
            'End While

        Catch ex As Exception
            MsgBox("LocalizarYMaisProximos()" & Chr(13) & ex.Message)
        End Try


    End Sub

    Private Sub LocalizarXMaisProximos(ByVal matriz(,) As Double)
        'y1 = txtY1.Text
        'y2 = txtY2.Text

        'ACHAR UM PONTO IMEDIAAMENTE MENOR QUE O X CORRIGIDO E UM PONTO IMEDIATAMENTE MENOR QUE O X CORRIGIDO

        For index As Integer = 0 To (matriz.Length / 2) - 1
            If x1 > 0 Then
                If matriz(1, index) > txtY1.Text Then
                    y1 = matriz(1, index - 1) 'y1 = matriz(index - 1, 0)
                    x1 = matriz(0, index - 1) 'x1 = matriz(index - 1, 1)
                    Exit For
                End If
            Else
                If matriz(1, index) < txtY1.Text Then
                    y1 = matriz(1, index) 'y1 = matriz(index, 0)
                    x1 = matriz(0, index) 'x1 = matriz(index, 1)
                    Exit For
                End If
            End If
        Next

        'Seleciona matriz.GetUpperBound(1) para dados de coluna na matriz, matriz.GetUpperBound(0) para dados de linha na matriz
        Dim aux As Integer = matriz.GetUpperBound(1)
        'Esse while irá varrer de trás para frente os valores para encontrar o compatível
        While aux > 0

            If y2 > 0 Then
                If matriz(1, aux) > txtY2.Text Then
                    y2 = matriz(1, aux) 'y2 = matriz(aux, 0)
                    x2 = matriz(0, aux) 'x2 = matriz(aux, 1)
                    'Exit While
                End If
            Else
                If matriz(1, aux) > txtY2.Text Then
                    y2 = matriz(1, aux) 'y2 = matriz(aux, 0)
                    x2 = matriz(0, aux) 'x2 = matriz(aux, 1)
                    'Exit While
                End If
            End If

            aux = aux - 1
        End While
    End Sub

    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Try


            'Desabilitar comando resetar
            btnReset.Enabled = False

            'Limpar os campos
            frmGraficoPavitest.txtCorrigida0.Text = ""
            frmGraficoPavitest.txtCorrigida1.Text = ""


            If blnReverEnsaio = False Then

                If frmGraficoPavitest.txtCalculada0.Text <> "" Then
                    dblISC1 = frmGraficoPavitest.txtCalculada0.Text * 100 / 70.31
                    frmGraficoPavitest.txtISC0.Text = FormatNumber(dblISC1, 2)
                End If

                If frmGraficoPavitest.txtCalculada1.Text <> "" Then
                    dblISC2 = frmGraficoPavitest.txtCalculada1.Text * 100 / 105.46
                    frmGraficoPavitest.txtISC1.Text = FormatNumber(dblISC2, 2)
                End If

            Else

                If frmRever.txtCalculada0.Text <> "" Then
                    dblISC1 = frmRever.txtCalculada0.Text * 100 / 70.31
                    frmRever.txtISC0.Text = FormatNumber(dblISC1, 2)
                End If

                If frmRever.txtCalculada1.Text <> "" Then
                    dblISC2 = frmRever.txtCalculada1.Text * 100 / 105.46
                    frmRever.txtISC1.Text = FormatNumber(dblISC2, 2)
                End If

            End If

            Call frmGraficoPavitest.GravarCorrecao(0, 0, 0, 0)

        Catch ex As Exception
            MsgBox("btnReset_Click()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Function VerificarY() As Boolean

        Try

            VerificarY = False

            If txtY1.Text = "" Then
                MsgBox("É necessário digitar um valor para o Y1 para calcular a REGRESSÃO LINEAR.", vbInformation, "Erro Y1")
                txtY1.Focus()
                Exit Function
            End If

            If txtY2.Text = "" Then
                MsgBox("É necessário digitar um valor para o Y2 para calcular a REGRESSÃO LINEAR.", vbInformation, "Erro Y2")
                txtY2.Focus()
                Exit Function
            End If

            VerificarY = True

        Catch ex As Exception
            MsgBox("VerificarY()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "VerificarY" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Function
        End Try

    End Function

    Private Sub txtY1_Click(sender As Object, e As EventArgs) Handles txtY1.Click

    End Sub

    Private Sub txtY1_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtY1.GotFocus
        'Seleciona todo campo
        Try
            'Selecionar o texto ao receber o foco
            Call usrDiversos.SelecionarFoco(txtY1)

            blnPegarY1 = True
            blnPegarY2 = False

        Catch ex As Exception
            MsgBox("txtY1_GotFocus1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtY1_GotFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txtY1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY1.KeyPress
        'Válida valores numéricos
        Try

            '(OBJETO As TextBox, KeyAscii As Integer, REAL As Boolean, TABS As Boolean, ValorDecimal As Boolean, Negativo As Boolean)
            e.KeyChar = ChrW(usrDiversos.VNumerico(txtY1, Asc(e.KeyChar), True, True, True, False))

        Catch ex As Exception
            MsgBox("txtY1_KeyPress1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtY1_KeyPress" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txtY1_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtY1.LostFocus
        'Formata o campo
        Try

            If IsNumeric(txtY1.Text) Then txtY1.Text = FormatNumber(txtY1.Text, 2)

        Catch ex As Exception
            MsgBox("txtY1_LostFocus1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtY1_LostFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txtY2_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtY2.GotFocus
        'Seleciona todo campo
        Try
            'Selecionar o texto ao receber o foco
            Call usrDiversos.SelecionarFoco(txtY2)

            blnPegarY1 = False
            blnPegarY2 = True

        Catch ex As Exception
            MsgBox("txtY2_GotFocus1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtY2_GotFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txtY2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY2.KeyPress
        'Válida valores numéricos
        Try

            '(OBJETO As TextBox, KeyAscii As Integer, REAL As Boolean, TABS As Boolean, ValorDecimal As Boolean, Negativo As Boolean)
            e.KeyChar = ChrW(usrDiversos.VNumerico(txtY2, Asc(e.KeyChar), True, True, True, False))

        Catch ex As Exception
            MsgBox("txtY2_KeyPress1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtY2_KeyPress" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txtY2_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtY2.LostFocus
        'Formata o campo
        Try

            If IsNumeric(txtY2.Text) Then txtY2.Text = FormatNumber(txtY2.Text, 2)

        Catch ex As Exception
            MsgBox("txtY2_LostFocus1()" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros(Me.Text & Chr(13) & "txtY2_LostFocus" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)
            Exit Sub
        End Try
    End Sub



    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class