Option Strict Off
Option Explicit On

'Importando Namespaces de Conexão
Imports System.Math
Imports System.Data.OleDb
Imports System.Drawing.Point


Public Class frmGraficoPavitest
    '******Tela de Aquisição
    'O programa faz aquisição da pressão e da penetração

#Region "DECLARAÇÃO DE VARIÁVEIS"

    'Identificado do ensaio
    Dim intEnsaio As Integer
    'Comando de execução do ensaio
    Dim blnBotaoIniciar As Boolean
    Dim blnBotaoParar As Boolean
    Dim blnBotaoFinalizarManual As Boolean
    Dim blnBotaoFinalizarAuto As Boolean
    Dim blnBotaoFinalizar As Boolean
    Dim blnBotaoCancelar As Boolean
    Dim blnComandoParar As Boolean
    'Vetor de Deformações
    Dim dblVetorPenetracao() As Double
    'Contador
    Dim intContPosicao As Integer
    'Leituras realizadas
    Dim dblCarga As Double
    Dim dblPressao As Double
    Dim dblPenetracao As Double
    'Maior leitura da carga
    Dim dblCargaMaxima As Double
    Dim dblPenetracaoFinal As Double
    '(Ensaio - Intervalo de aquisição)
    Dim dblLoopAnterior As Double
    Dim intContAdvertencia As Integer
    'Resultados Parciais do Ensaio
    Dim dblPLeitura1 As Double
    Dim dblPLeitura2 As Double
    Dim blnBuscar1 As Boolean
    Dim blnBuscar2 As Boolean
    'Contador de erros
    Dim intContErroCarga As Integer
    Dim intContErroLVDT As Integer
    'Valores armazenados
    Dim dblVetor(,) As Double
    'Gerar relatório
    Dim rstItens As ADODB.Recordset
    'Controle dos comandos do ensaio
    Dim intControleEnsaio As Integer
    'Finalização automática
    Dim dblPorcentagemCargaMaxima As Double
    Dim blnModoAutomatico As Boolean

    Dim blnLeituraOFFSET As Boolean
    Dim blnEscritaOFFSET As Boolean

    Dim dblOffTemp As Double

    Dim blnEnviarVelocidadeTemporaria As Boolean
    Dim dblTaxaEnsaio As Double
    Dim dblCargaMinimaLimite As Double

    Dim blnEnviaVelocidade As Boolean
    Dim blnVelocidadeNegativa As Boolean
    Dim blnIniciaThreshold As Boolean
    Dim blnResetThreshold As Boolean
    Dim blnEnviaReposicionamento As Boolean
    Dim intContadorParadaMotor As Integer

    Dim intTentativaVerificaCanais As Integer
    Dim strNomeTabelaBD As String
    Dim dblLVDTTeste As Double
    Dim dblCargaTeste As Double

    Dim strTipoFinalizacao As String
    Dim blnPrimeiroScan As Boolean

    Dim blnDbOffSucesso, blnReadingOffSucesso, blnLeuPlacasInicializadasComSucesso, blnVerificouCanaisHabilitadosComSucesso, blnLeuConstantesPIDComSucesso, blnComandosPreliminaresComSucesso As Boolean
    Dim blnLeuKPDeslocamentoComSucesso, blnLeuKPIncrementoComSucesso, blnLeuBBComSucesso, blnLeuAJComSucesso, blnLeuSPComSucesso, blnLeuMAComSucesso As Boolean
    Dim strCanaisHabAD(3) As String
    Dim intPlacasLidasComSucesso() As Integer
    Dim intRetornoLeituraAD As Integer
    Dim dblErroPID As Double
    Dim strEstabilizacaoAutomatica As String
    Dim blnEmergenciaAcionada, blnFCS_Acionado, blnFCI_Acionado, blnSobrecargaAcionada, blnSobrecursoAcionado, blnModoRemoto As Boolean
    Dim blnTara, blnZerarCelulaCarga, blnZerarDeslocamentoPrensa As Boolean
    Dim blnThresholdCargaEnviado, blnThresholdLVDTEnviado As Boolean
    Dim intContadorErroComandoRall As Integer

    'Leituras

    Dim dblCargaAnterior As Double
    Dim dblFluenciaFinal As Double
    Dim dblTempo As Double
    Dim dblTempoMaximo As Double
    Dim dblDeformacao As Double
    Dim dblEstabilidade As Double
    Dim lngContadorTempo As Long

    'Contadores

    Dim lngContDif As Long
    Dim intContGrafico As Integer
    Dim lngGrafico As Long

    Dim listaCarga As List(Of Double) = New List(Of Double)
    'Dim listaPressaokgfcm2 As List(Of Double) = New List(Of Double)
    'Dim listapenetracao As List(Of Double) = New List(Of Double)


    Public graficoPavitest As New clsGraficoChart()
    Dim blnMudouGrafico As Boolean
    Dim strUnidadeAnterior As String


    Dim listaCurvasPlotadas As New List(Of String)
    Dim listaUsarEmX As New List(Of Double)
    Dim listaUsarEmY As New List(Of Double)
    Dim listaUsarEmY2 As New List(Of Double)

    Dim intLarguraInicial, intAlturaInicial As Integer

    Public blnEscalaManualX As Boolean
    Public blnEscalaManualY1 As Boolean
    Public blnEscalaManualY2 As Boolean


    Public strUnidadeConvertidaY2 As String
    Public blnReverEnsaio As Boolean

    Dim blnNovoY1, blnNovoY2 As Boolean
    Dim intVariosY1 As Integer = -1
    Dim intVariosY2 As Integer = -1
    Dim blnGraficoInicializado As Boolean

    Dim blnCarregarBD As Boolean = False
    Dim strTabela As String
    Dim blnAquisicaoRapida, blnLimpouVetorAquisicaoRapida, blnHabilitouAquisicaoRapida, blnSelecionouIDAquisicaoRapida, blnEnviouDestinoAquisicaoRapida, blnPulaConfiguracaoAquisicaoRapida As Boolean

    Dim strUnidadeMedidaY1 As String

    Dim blnPrimeiroPonto As Boolean

    Dim listaOpcoesEixo As New List(Of String) From {
        "Penetração",
        "Carga",
        "Pressão1",
        "Pressão2"}

    Dim listaUnidadesMedidas As New List(Of String) From {
       "mm",
       "kgf",
       "kgf/cm²",
       "MPa"}

    'Lista para usar em leituras do BD e variaveis
    Dim listaOpcoesBD As New List(Of String) From {
     "Penetracao",
     "Carga",
     "Pressao"}

    Dim listaOpcoesEscalas As List(Of Double) = New List(Of Double) From {
            1,
            10,
            0.01,
            0.01}
    Private blnCriarTabelaBD As Boolean


#End Region
    '**************************************************************
    '***************** CARREGANDO E FECHANDO O FORM ENSAIAR *****

#Region "CARREGANDO E DESCARREGANDO FORM"

    Private Sub frmGraficoPavitest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Carrega dados iniciais
        Try

            strFrmAtivo = "Ensaio"

            'Carregar a classe Gráfico
            usrGrafico = New clsGrafico
            usrPortaSerial = New clsPortaSerial
            usrDiversos = New clsDiversos
            usrConexao = New clsConexao
            'usrComandos = New clsComandos
            usrArduino_AD7192 = New clsArduino_AD7192
            usrComunicacao = New clsComunicacao

            Me.Text = strCompactacao
            intLarguraInicialGrupoGrafico = grbGrafico.Width
            intAlturaInicialGrupoGrafico = grbGrafico.Height

            'Setar gráficos
            Call FormatarGrafico()

            'Setar comandos de execução
            Call HabilitarComandos(True, False, False, False, False, False)
            'Habilitar comando relatório e sair
            Call HabilitarRelatorio(False)
            Call HabilitarSair(True)
            Call HabilitarZerar(True)

            'Zerar valores iniciais
            Call IniciandoVariaveis()

            'Deslocamento e velocidade padão
            dblPenetracaoFinal = CDbl(txtPenetracaoLimite.Text)

            If usrInicializacaoFabricante.HABILITACAO_DADOS_PID = "True" Then
                Call HabilitaLeiturasPID(True)
            Else
                Call HabilitaLeiturasPID(False)
            End If

            ''Carregar o vetor de deforamções
            Call CarregarVetorPenetracao()

            blnPrimeiroScan = True

            graficoPavitest.blnMarcadorPonto = True

            If strTipoEnsaio = "ABNT NBR 9895" Then
                intOpcaoY = 3
                Label4.Text = "Calculada (MPa)"
                Label22.Text = "Corrigida (MPa)"
                Label23.Text = "Padrão (MPa)"
                lblLegendaPressao.Text = "Pressão (MPa)"
                txtPadrao0.Text = "6,90"
                txtPadrao1.Text = "10,35"
                blnMudouUnidadeMPa = True
            Else
                intOpcaoY = 2
                Label4.Text = "Calculada (kgf/cm²)"
                Label22.Text = "Corrigida (kgf/cm²)"
                Label23.Text = "Padrão (kgf/cm²)"
                lblLegendaPressao.Text = "Pressão (kgf/cm²)"
                txtPadrao0.Text = "70,31"
                txtPadrao1.Text = "105,46"
                blnMudouUnidadeMPa = False
            End If

            blnGraficoInicializado = True

            'Habilitar timer de comunicação
            tmrLeituras.Interval = 500
            tmrLeituras.Enabled = True

        Catch ex As Exception
            MsgBox("frmEnsaiar_Load()" & Chr(13) & ex.Message)
        End Try
    End Sub


    Private Sub frmGraicoPavitest_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Try
            If blnPrintarGrafico Then
                Call RetomarDimensaoGrafico()
                blnPrintarGrafico = False
            End If

            If Not blnFormCarregado Then
                blnFormCarregado = True
            End If 'se não carregado

        Catch ex As Exception
            MsgBox("frmEnsaiar_Activated()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Function AbrirPortaComunicacao() As Boolean
        Try

            'Abrir a porta de comunicação serial
            Call usrPortaSerial.Abrir_Porta_Comunicacao(spPortaSerial)
            If strErro_Porta_Comunicacao <> "" Or (spPortaSerial.IsOpen = False) Then Return False

            barStatus.Enabled = True
            barStatus.Visible = True
            Call Barra_de_Progresso()

            Return True

        Catch ex As Exception
            tmrLeituras.Enabled = False
            lblMsgErro.Visible = True
            lblMsgErro.Text = "Não foi possível abrir a porta de comunicação. Verifique se o equipamento está ligado ou se porta COM" & usrInicializacao.PORTA & " encontra-se disponível."
            Return False
        End Try
    End Function

    Public Sub Barra_de_Progresso()

        barStatus.Visible = True

        Dim stopwatch As Stopwatch = Stopwatch.StartNew()

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 10

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 20

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 30

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 40

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 50

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 60

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 70

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 80

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 90

        System.Threading.Thread.Sleep(300)

        barStatus.Value = 100

        stopwatch.Stop()

        barStatus.Enabled = False

        barStatus.Value = 0

        barStatus.Visible = False

    End Sub

    Public Sub FormatarGrafico()

        Try
            '-------------------------------------------------------------------------------------------
            'Legenda P/ Y2:
            'intOpcaoY2 = -11 'Significa que existe uma lista da mesma grandeza com unidade convertida
            'intOpcaoY2 = -1  'Significa que NÃO existe uma lista para Y2
            '-------------------------------------------------------------------------------------------

            'Define quais são as opções iniciais para os eixos
            intOpcaoX = 0  'Opção Tempo para X

            If strTipoEnsaio = "ABNT NBR 9895" Then
                intOpcaoY = 3   'Opção Carga Fixa para Y1
            Else
                intOpcaoY = 2
            End If

            intOpcaoY2 = -1 'Sem Y2

            'Adiciona curva principal a lista de plotadas
            listaCurvasPlotadas.Add(listaOpcoesEixo.ElementAt(intOpcaoY))

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

            'Atualiza a formatação do gráfico para múltiplas curvas
            Call graficoPavitest.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("FormatarGrafico" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub InstanciarListas()

        Try

            'Instância as variáveis
            listaCarga = New List(Of Double)
            listaPressaokgfcm2 = New List(Of Double)
            listaPressaoMPa = New List(Of Double)
            listaPenetracao = New List(Of Double)


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("InstanciarListas" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub InicializarGrafico() 'Antigo -->RecomporEixos
        Try

            graficoPavitest.strVetorLinhasY1 = New List(Of String)
            graficoPavitest.listTipoCurva = New List(Of String)
            graficoPavitest.strLinhasY1Tracejada = New List(Of String)
            graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
            graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))
            graficoPavitest.listTipoCurva.Add("Continua")
            strUnidadeAnterior = listaUnidadesMedidas.ElementAt(intOpcaoY)

            graficoPavitest.chartWidth = intLarguraInicialGrupoGrafico - 30 '+ 80
            graficoPavitest.chartHeight = intAlturaInicialGrupoGrafico - 30

            'Cria o grafico na tela e deixa ele vazio com todos os valores zerados
            graficoPavitest.createChart(Me.WinChartViewer1)

            'Limpa as listas
            graficoPavitest.dblVetorValorX = New List(Of Double)
            graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))
            graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))
            listaUsarEmX = New List(Of Double)
            listaUsarEmY = New List(Of Double)
            listaUsarEmY2 = New List(Of Double)

            'Valores máximos
            If blnReverEnsaio Then
                graficoPavitest.dblScaleMaxX = 0
                graficoPavitest.dblScaleMaxY = 0
                graficoPavitest.dblScaleMaxY2 = 0
            Else
                graficoPavitest.dblScaleMaxX = listaOpcoesEscalas.ElementAt(intOpcaoX)
                graficoPavitest.dblScaleMaxY = listaOpcoesEscalas.ElementAt(intOpcaoY)
                If graficoPavitest.strTituloEixoY2 <> "" Then
                    graficoPavitest.dblScaleMaxY2 = listaOpcoesEscalas.ElementAt(intOpcaoY2)
                Else
                    graficoPavitest.dblScaleMaxY2 = 0
                End If
            End If

            'Valores mínimos
            graficoPavitest.dblScaleMinX = 0
            graficoPavitest.dblScaleMinY = 0
            graficoPavitest.dblScaleMinY2 = 0

            'Divisor de escala
            graficoPavitest.AtualizarDivisores()

            'Se o botão cancelar foi acionado, não é necessário apagar os eixos que estavam selecionados
            If intEnsaio <> CANCELAR Or blnNovoY1 Then

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

            End If


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("InicializarGrafico" & Chr(13) & ex.Message)
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

    Private Sub AtualizarOpcoesEixos()
        Try
            'Limpa as opções do menu
            mnuEixoX1.DropDownItems.Clear()
            mnuEixoY1.DropDownItems.Clear()

            'Atualiza as opções do menu
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


    Private Sub AtualizaOpcoesEscalas()
        'Carrega na lista de opcoes de escalas, as escalas preconfiguradas, escalas encontradas no arquivo de inicialização.
        Try

            '--------------------------------------------------------------------------

            'Condições Iniciais para as escalas
            graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = True
            mnuAutoEixoXEscalaMin0.Checked = True

            graficoPavitest.blnEscalaAutomaticaEixoY1MinimoZero = True
            mnuAutoEixoY1EscalaMin0.Checked = True

            graficoPavitest.blnEscalaAutomaticaEixoY2MinimoZero = True
            mnuAutoEixoY2EscalaMin0.Checked = True

            graficoPavitest.blnEscalaAutomaticaEixoXTempoOrigemDinamica = False
            mnuAutoEixoTempoOrigemFixa.Checked = True

            '--------------------------------------------------------------------------

            ''Valores máximos inicias de cada escala
            'listaOpcoesEscalas.Add(50)   '0 - Carga kgf
            'listaOpcoesEscalas.Add(500)  '1 - Carga Newton
            'listaOpcoesEscalas.Add(0.01) '2 - Deformação 1
            'listaOpcoesEscalas.Add(0.01) '3 - Deformação 2
            'listaOpcoesEscalas.Add(0.01) '4 - Deformação 3
            'listaOpcoesEscalas.Add(0.01) '5 - Deformação Média
            'listaOpcoesEscalas.Add(10)   '6 - Deslocamento Prensa
            'listaOpcoesEscalas.Add(100)  '7 - Setpoint Carga
            'listaOpcoesEscalas.Add(10)   '8 - Tempo
            'listaOpcoesEscalas.Add(100)  '9 - Tensão

            '--------------------------------------------------------------------------

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizaOpcoesEscalas" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub frmEnsaiar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Fechar a tela Aquisição e cancelar timer
        Try

            tmrLeituras.Enabled = False
            tmrLeituras.Interval = 1

            blnComunicacao = False

            'Fechar a porta de comunicação serial
            Call usrPortaSerial.FecharPorta(spPortaSerial)

            blnVoltarPosicaoCP = True

            'Zera o número de tentativas
            intTentativaVerificaCanais = 0
            'Limpa o Status para o próximo teste
            blnTemCanalHabilitadoPlaca0 = False
            blnTemCanalHabilitadoPlaca1 = False

        Catch ex As Exception
            MsgBox("frmEnsaiar_FormClosing()" & Chr(13) & ex.Message)
        End Try
    End Sub

#End Region

    '*****************************************************************
    '********** TIMER DE COMUNICAÇÃO - CONTROLADOR DO ENSAIO *********

#Region "FUNÇÃO DO TIMER"

    Private Sub tmrComunicacao_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrLeituras.Tick
        Try

            If Not spPortaSerial.IsOpen And Not blnModoSimulacao Then
                If AbrirPortaComunicacao() = False Then Exit Sub
            End If

            'Sinalização de comunicação
            Call PiscaPisca()

            Call ComandosPreliminares()

            If blnTara Then
                Call RealizarTaraInstrumentos()
            End If

            'LEITURA DOS INSTRUMENTOS E STATUS DA MÁQUINA
            Call RealizarLeituras()

            If blnModoSimulacao = True Then
                LeiturasSimuladas()
            End If

            If blnBotaoIniciar Then
                Call RealizarEnsaio()
                If intEstadoEnsaio = EXECUTAR Then

                    'Executando o ensaio
                    Call TrabalharDados()

                End If
            Else
                If blnEmergenciaAcionada = True Then
                    lblMensagem.Text = "EMERGÊNCIA ACIONADA !!! "
                End If

                If blnFCS_Acionado = True Then
                    lblMensagem.Text = "FIM DE CURSO SUPERIOR ACIONADO! REPOSCIONE O EQUIPAMENTO MANUALMENTE PELO PAINEL ."
                End If

                If blnSobrecargaAcionada = True Then
                    lblMensagem.Text = "A CARGA ÚLTRAPASSOU O VALOR MÁXIMO PERMITIDO - SOBRECARGA!!!"
                End If

                If blnSobrecursoAcionado = True Then
                    lblMensagem.Text = "O PRATO DO EQUIPAMENTO CHEGOU AO CURSO MÁXIMO PERMITIDO - SOBRECURSO!!!"
                End If

                If blnEmergenciaAcionada = False And blnFCI_Acionado = False And blnSobrecargaAcionada = False And blnSobrecursoAcionado = False Then
                    lblMensagem.Text = "AGUARDANDO INÍCIO DO ENSAIO"
                End If
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tmrComunicacao_Tick" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub TrabalharDados()

        Try
            If strTipoEnsaio = "ABNT NBR 9895" Then
                If intContPosicao = 14 Then Exit Sub
            Else
                If intContPosicao = 9 Then Exit Sub
            End If

            If dblPenetracao >= dblVetorPenetracao(intContPosicao) Or blnPrimeiroPonto Then

                If blnPrimeiroPonto = True Then
                    blnPrimeiroPonto = False
                Else
                    'Atualizar posição do vetor
                    intContPosicao = intContPosicao + 1
                End If


                'Atualiza listas de leituras, adicionando os valores recem adquiridos
                Call AdicionarLeiturasNasListas()

                'Salva todas as leituras no banco de dados 
                Call ArmazenarDadosAquisitados()

                'De acordo com as definições escolhidas para o eixo atualizo as listas inerentes ao grafico
                Call AtualizaListaDoGraficoEnsaiar()

                'Antes de chamar plotar grafico preciso definir qual lista realmente será usada.
                Call PlotarDadosGraficoEnsaiar()
            End If


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ComandoAlterarIncremento" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub PlotarDadosGraficoEnsaiar()

        'TRAÇA O GRÁFICO COM AS LISTAS SELECIONADAS

        Try
            If blnEscalaManualX = False And blnEscalaManualY1 = False And blnEscalaManualY2 = False Then

                If graficoPavitest.blnEscalaAutomaticaEixoXTempoOrigemDinamica = False Then
                    'Escala mínima do eixo X se o eixo permanecer fixo na origem
                    graficoPavitest.dblScaleMinX = 0
                Else
                    'Criar lógica do X dinâmico
                    '
                End If

                If blnReverEnsaio Then
                    'Atualiza as escalas máximas para 0 para depois se reajustarem automáticamente
                    graficoPavitest.dblScaleMaxX = 0
                    graficoPavitest.dblScaleMaxY = 0

                    'Analisar sugestão de mudança de critério da escala automática caso contenha valor menor que zero e esteja configurado para exibir o mínimo igual a 0
                    Call CriterioAdicionalEscalaAutomaticaInicial()

                End If

                If blnMudouGrafico Then
                    'Analisar sugestão de mudança de critério da escala automática caso contenha valor menor que zero e esteja configurado para exibir o mínimo igual a 0
                    Call CriterioAdicionalEscalaAutomaticaInicial()
                    'Reinicia variável
                    blnMudouGrafico = False
                End If

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

            'Atualiza o gráfico
            graficoPavitest.AtualizarGraficoMultiplasListas()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("PlotarDadosGraficoEnsaiar" & Chr(13) & ex.Message)
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
    Private Sub AtualizaListaDoGraficoEnsaiar()
        'ALIMENTA O VETOR X E VETOR Y COM A LISTA DE DADOS SELECIONADA (TEMPO REAL OU BD)

        Dim intY1Novo, intY2Novo As Integer

        Try

            graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))


            graficoPavitest.dblVetorValorX = PreencheListaGenerica(intOpcaoX)
            For Each nomeY As String In graficoPavitest.strVetorLinhasY1
                intY1Novo = listaOpcoesEixo.IndexOf(nomeY)
                graficoPavitest.dblMatrixEixoY1.Add(PreencheListaGenerica(intY1Novo))
                listaUsarEmY = PreencheListaGenerica(intY1Novo)
            Next



            'Para Y2 com eixo convertido, os valores são definidos dentro da subrotina AjustarEscalaAutomaticoNova()

            'Se o eixo Y2 está exibindo a escala com uma grandeza independe de Y1
            If intOpcaoY2 <> -1 And intOpcaoY2 <> -11 Then
                graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))

                'Carrega uma lista de uma grandeza padrão
                For Each nomeY2 As String In graficoPavitest.strVetorLinhasY2
                    intY2Novo = listaOpcoesEixo.IndexOf(nomeY2)
                    graficoPavitest.dblMatrixEixoY2.Add(PreencheListaGenerica(intY2Novo))
                    listaUsarEmY2 = PreencheListaGenerica(intY2Novo)
                Next

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizaListaDoGraficoEnsaiar" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub ArmazenarDadosAquisitados()
        'Nome da Tabela
        Dim strTabela As String
        'Comando sql
        Dim strSql As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""


            Call usrConexao.ConstruirSQL(cmd_INSERT, listaOpcoesBD.ElementAt(0), dblPenetracao)
            Call usrConexao.ConstruirSQL(cmd_INSERT, listaOpcoesBD.ElementAt(1), dblCarga)
            Call usrConexao.ConstruirSQL(cmd_INSERT, listaOpcoesBD.ElementAt(2), dblPressao)


            If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"
            If strStruture_Valor <> "" Then strStruture_Valor = strStruture_Valor & ")"

            'Nome da Tabela
            strTabela = "AMOSTRA" & intIdAmostra & "CP" & intIdCP

            'Comando Sql (Adicionar)
            strSql = "INSERT INTO [" & strTabela & "] " _
                & strStruture_Campo & strStruture_Valor

            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ArmazenarDadosAquisitados" & Chr(13) & ex.Message)
        End Try

    End Sub
    Private Sub AdicionarLeiturasNasListas()
        Try

            'De acordo com o sinal da célula de carga

            listaCarga.Add(dblCarga)
            listapenetracao.Add(dblPenetracao)
            listaPressaokgfcm2.Add(dblPressao)
            listaPressaoMPa.Add(dblPressao * 0.1)


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AdicionarLeiturasNasListas()" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub LEITURASSIMULACAO()

        dblCarga = dblCarga + 0.1

        Call FormatarLeituras(CARGA)

        dblPenetracao = dblPenetracao + 0.01

        Call FormatarLeituras(LVDT)

    End Sub
    Private Sub tmrReposicionar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReposicionar.Tick

        Try
            'SINALIZAÇÃO DE COMUNICAÇÃO
            Call PiscaPisca()

            'LEITURA DOS INSTRUMENTOS E STATUS DA MÁQUINA
            Call RealizarLeituras()

            If blnReposicionar Then
                blnReposicionar = False
                blnReposicionou = False
                lblMensagem.Visible = True
                lblMensagem.Text = "REPOSICIONANDO..."
                blnEnviaReposicionamento = True
                Exit Sub
            End If

            If blnEnviaReposicionamento Then
                Call ComandoReposicionarMotor()
                'Se não houve erro no envio do comando reposicionar
                If usrArduino_AD7192.blnErroRespostaConferencia = False Then
                    blnEnviaReposicionamento = False
                    Exit Sub
                End If
            End If

            If blnReposicionou = False Then
                If usrComunicacao.strStatusMaquina(11) = "Reposicionou" Or usrComunicacao.strStatusMaquina(1) = "Fim de Curso Inferior" Then
                    blnReposicionou = True
                End If
            End If

            If blnReposicionou Then

                tmrReposicionar.Enabled = False

                lblMensagem.Text = "PRENSA REPOSICIONADA"

                'Habilitar sair da tela de ensaio
                Call HabilitarSair(True)

                'Habilitar relatório
                Call HabilitarRelatorio(True)

                If blnModoRemoto Then
                    'Habilitar modo local
                    Call ComandoModoLocal()
                End If

                If intEstadoEnsaio = CANCELAR Then
                    'Desabilitar os comandos
                    Call HabilitarComandos(True, False, False, False, False, False)
                    Call HabilitarZerar(True)
                    tmrLeituras.Enabled = True
                    tmrLeituras.Interval = 500
                    Exit Sub
                End If

            End If


        Catch ex As Exception
            'Mensagem de erro
            MsgBox("tmrComunictmrReposicionar_Tickacao_Tick" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub RealizarEnsaio()
        Try
            Call IntervaloAquisicao()

            Select Case intEstadoEnsaio

                Case INICIAR

                    'Exibe mensagem interativa
                    lblMensagem.Text = "PREPARANDO O INÍCIO DO ENSAIO ..."

                    'Se já estiver no modo remoto avança para próxima etapa
                    If blnModoRemoto Then intEstadoEnsaio = DESTINO : Exit Sub

                    If blnModoRemoto = False Then
                        Call ComandoModoRemoto()
                        If ValidaComandoEscrita() Then
                            intEstadoEnsaio = TAXA : intEstadoAnterior = INICIAR
                        Else
                            'Repete comando no próximo scan
                            intEstadoEnsaio = INICIAR
                        End If
                    End If

                Case TAXA

                    'Exibe mensagem interativa
                    lblMensagem.Text = "PREPARANDO ENVIO DA TAXA ..."

                    'Valida a taxa enviada
                    Call ComandoAlterarTaxa()

                    tmrLeituras.Enabled = False
                    If rdbModoIncrementoCarga.Checked Then
                        strValorTaxaCarga = FormatarPontoDecimal(dblTaxaEnsaio)
                        If blnModoSimulacao = False Then
                            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TAXA_CARGA, "Escrita")
                        End If
                    Else
                        strValorTaxaDeslocamento = FormatarPontoDecimal(dblTaxaEnsaio)
                        If blnModoSimulacao = False Then
                            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TAXA_DESLOCAMENTO, "Escrita")
                        End If
                    End If
                    tmrLeituras.Enabled = True

                    If ValidaComandoEscrita() Then
                        If intEstadoAnterior = EXECUTAR Then
                            intEstadoEnsaio = EXECUTAR
                        Else
                            intEstadoEnsaio = DESTINO
                        End If
                        'Atualiza status
                        intEstadoAnterior = TAXA
                    End If

                Case DESTINO

                    'Exibe mensagem interativa
                    lblMensagem.Text = "PREPARANDO ENVIO DO DESTINO ..."

                    tmrLeituras.Enabled = False

                    If btnIncrementar.Enabled = False Then

                        If rdbModoIncrementoCarga.Checked Then
                            strValorDestinoCarga = "5000" 'Destino Máximo
                            If blnModoSimulacao = False Then
                                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESTINO_CARGA, "Escrita")
                            End If
                            If ValidaComandoEscrita() Then intEstadoEnsaio = INCREMENTAR : intEstadoAnterior = DESTINO
                        Else
                            strValorDestinoDeslocamento = "70" 'Deslocamento Máximo
                            If blnModoSimulacao = False Then
                                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESTINO_DESLOCAMENTO, "Escrita")
                            End If
                            If ValidaComandoEscrita() Then intEstadoEnsaio = INCREMENTAR : intEstadoAnterior = DESTINO
                        End If

                    ElseIf btnDecrementar.Enabled = False Then

                        strValorDestinoDeslocamento = "0" 'Deslocamento Máximo
                        If blnModoSimulacao = False Then
                            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESTINO_DESLOCAMENTO, "Escrita")
                        End If
                        If ValidaComandoEscrita() Then intEstadoEnsaio = DECREMENTAR : intEstadoAnterior = DESTINO

                    End If

                    tmrLeituras.Enabled = True

                Case INCREMENTAR

                    'SE OS LIMITES (Threshold) FORAM CONSIDERADOS
                    If blnIniciaThreshold Then
                        'DESATIVADO ATÉ O FRED VERIFICAR===
                        'VERIFICAR COM O FRED SE ESSE COMANDO TEM QUE SER ENVIADO ANTES DE UM CTRC/CTRP OU DEPOIS, POIS SE ENVIADO DEPOIS A PRENSA ESTAVA PARANDO
                        'Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TESTE_AUTOMATICO, "Escrita")
                        'If ValidaComandoEscrita() Then blnIniciaThreshold = False
                        'System.Threading.Thread.Sleep(50)
                        'DESATIVADO ATÉ O FRED VERIFICAR===
                    End If

                    'Mensagem
                    lblMensagem.Text = "MOVIMENTANDO PRENSA ..."
                    lblMensagem.BackColor = Color.DarkOliveGreen

                    tmrLeituras.Enabled = False
                    If rdbModoIncrementoCarga.Checked Then
                        Call ComandoPararMotor()
                        If blnModoSimulacao = False Then
                            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_CARGA, "Escrita")
                        End If
                        lblMensagem.Text = "INCREMENTANDO CARGA"
                    Else
                        Call ComandoPararMotor()
                        If blnModoSimulacao = False Then
                            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_DESLOCAMENTO, "Escrita")
                        End If
                        lblMensagem.Text = "SUBINDO A PRENSA"
                    End If

                    If ValidaComandoEscrita() Then
                        If blnIniciaThreshold And chkIniciarGraficoAposCargaMinima.Checked Then
                            blnIniciaThreshold = False
                            intEstadoEnsaio = THRESHOLD : intEstadoAnterior = INCREMENTAR
                        Else
                            intEstadoEnsaio = EXECUTAR : intEstadoAnterior = INCREMENTAR
                        End If
                    End If
                    tmrLeituras.Enabled = True

                Case DECREMENTAR
                    'Mensagem
                    lblMensagem.Text = "DECREMENTANDO CARGA"
                    lblMensagem.BackColor = Color.DarkRed
                    tmrLeituras.Enabled = False

                    tmrLeituras.Enabled = False
                    If rdbModoIncrementoCarga.Checked Then
                        Call ComandoPararMotor()
                        If blnModoSimulacao = False Then
                            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_CARGA, "Escrita")
                        End If
                        lblMensagem.Text = "DECREMENTANTO CARGA"
                    Else
                        Call ComandoPararMotor()
                        If blnModoSimulacao = False Then
                            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONTROLE_DESLOCAMENTO, "Escrita")
                        End If
                        lblMensagem.Text = "DESCENDO A PRENSA"
                    End If

                    If ValidaComandoEscrita() Then
                        intEstadoEnsaio = EXECUTAR : intEstadoAnterior = DECREMENTAR
                    End If
                    tmrLeituras.Enabled = True


                Case THRESHOLD

                    'Mensagem
                    lblMensagem.Text = "INCREMENTANDO CARGA - MONITORANDO A CARGA MÍNIMA DE " & txtCargaMinimaLimite.Text & " kgf PARA O INÍCIO DO ENSAIO "
                    lblMensagem.BackColor = Color.DimGray

                    'SE OS LIMITES (Threshold) FORAM CONSIDERADOS
                    If blnIniciaThreshold Then
                        'DESATIVADO ATÉ O FRED VERIFICAR===
                        'VERIFICAR COM O FRED SE ESSE COMANDO TEM QUE SER ENVIADO ANTES DE UM CTRC/CTRP OU DEPOIS, POIS SE ENVIADO DEPOIS A PRENSA ESTAVA PARANDO
                        'Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TESTE_AUTOMATICO, "Escrita")
                        'If ValidaComandoEscrita() Then blnIniciaThreshold = False
                        'DESATIVADO ATÉ O FRED VERIFICAR===
                    Else
                        If chkIniciarGraficoAposCargaMinima.Checked And dblCarga >= dblCargaMinimaLimite Then
                            blnTara = True
                            blnZerarCelulaCarga = True
                            blnZerarDeslocamentoPrensa = True
                            intEstadoEnsaio = EXECUTAR
                            intEstadoAnterior = intEstadoEnsaio
                            lblMensagem.Text = "Realizando Ensaio: Incrementando"
                            lblMensagem.BackColor = Color.DarkOliveGreen
                        End If
                    End If

                    'DESATIVADO ATÉ O FRED VERIFICAR===
                    'Se o status atualizar, sinalizando o início do ensaio
                    'If strStatusMaquina(8) = "Threshold de Carga" Then
                    '      intEstadoEnsaio = EXECUTAR
                    '      intEstadoAnterior = intEstadoEnsaio
                    '      lblMensagem.Text = "Realizando Ensaio: Incrementando"
                    '      lblMensagem.BackColor = Color.DarkOliveGreen
                    'End If
                    'DESATIVADO ATÉ O FRED VERIFICAR===

                Case PARAR
                    'Mensagem
                    lblMensagem.Text = "PRENSA PARADA"
                    lblMensagem.BackColor = Color.DimGray

                    'Comando Parar
                    Call ComandoPararMotor()

                    intEstadoAnterior = intEstadoEnsaio
                    intEstadoEnsaio = EXECUTAR

                Case EXECUTAR

                    'Buscar resultados
                    Call BuscarResultado()
                    'Executando o ensaio
                    'Call ExecutarEnsaio() 'Substituído por TrabalharDados()

                    If blnZerarCelulaCarga Or blnZerarDeslocamentoPrensa Then
                        ComandoPararMotor()
                        lblMensagem.Text = "Ensaio interrompido, pois a confirmação de zeramento/tara da leitura de carga/deslocamento não foi recebida."
                        lblMensagem.Visible = True
                        intEstadoEnsaio = CANCELAR
                    End If

                    'Cancelamento do Ensaio por Emergência
                    If blnEmergenciaAcionada Then
                        intEnsaio = CANCELAR
                        lblMensagem.Text = "EMERGÊNCIA - ENSAIO CANCELADO"
                    End If

                    If blnFCS_Acionado Then
                        intEnsaio = CANCELAR
                        lblMensagem.Text = "FIM DE CURSO SUPERIOR - ENSAIO CANCELADO"
                    End If

                    If blnSobrecargaAcionada = True Then
                        intEnsaio = CANCELAR
                        lblMensagem.Text = "SOBRECARGA - ENSAIO CANCELADO"
                    End If

                    If blnSobrecursoAcionado = True Then
                        intEnsaio = CANCELAR
                        lblMensagem.Text = "SOBRECURSO - ENSAIO CANCELADO"
                    End If

                    'Finalização automática
                    If chkFinalizacaoAposPenetracao.Checked Then
                        'LVDT - Penetração
                        If dblPenetracao >= dblPenetracaoFinal Then
                            intEstadoEnsaio = FINALIZAR
                            blnResetThreshold = True
                            blnBotaoFinalizarAuto = True
                            strTipoFinalizacao = "A penetração configurada foi atingida"
                        ElseIf dblPenetracao >= 12.7 Then
                            intEstadoEnsaio = FINALIZAR
                            blnResetThreshold = True
                            blnBotaoFinalizarAuto = True
                            strTipoFinalizacao = "Chegou ao último ponto de penetração da norma (12,7 mm)"
                        End If

                    End If

                Case CANCELAR
                    'Mensagem
                    lblMensagem.Text = "CANCELANDO ENSAIO ..."
                    lblMensagem.BackColor = Color.DarkOliveGreen

                    'Finalizou ou cancelou ensaio
                    blnBotaoIniciar = False
                    'Se o botão parar ou cancelar for apertado PARA O ENSAIO
                    tmrLeituras.Enabled = False

                    If blnModoRemoto = False Then Call ComandoModoRemoto()

                    Call ComandoPararMotor()

                    'Cancelar Ensaio
                    Call CancelarFinalizar()

                Case FINALIZAR
                    'Mensagem
                    lblMensagem.Text = "FINALIZANDO ENSAIO ..."
                    lblMensagem.BackColor = Color.Blue

                    'Finalizou ou cancelou ensaio
                    blnBotaoIniciar = False
                    'Se o botão parar ou cancelar for apertado PARA O ENSAIO
                    tmrLeituras.Enabled = False
                    tmrLeituras.Interval = 1

                    If blnModoRemoto = False Then Call ComandoModoRemoto()

                    'Comando Parar
                    Call ComandoPararMotor()

                    'Finalizar o ensaio
                    Call CancelarFinalizar()

            End Select

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("RealizarEnsaio" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Function ValidaComandoEscrita() As Boolean
        Try
            'Acusa erro de leitura
            If usrArduino_AD7192.blnErroRespostaConferencia = True Then
                'ERRO NA CONFERÊNCIA DO COMANDO ENVIADO
                lblMsgErro.Visible = True
                lblMsgErro.Text = "O comando de escrita direcionado ao controlador não pôde ser enviado"
                Return False
            Else
                'SUCESSO NA CONFERÊNCIA DO COMANDO ENVIADO
                Return True
            End If
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ValidaComandoEscrita()" & Chr(13) & ex.Message)
        End Try
    End Function

    Private Sub PiscaPisca()

        Try
            If pctPiscar1.Visible Then
                pctPiscar1.Visible = False
                pctPiscar2.Visible = True
            Else
                pctPiscar1.Visible = True
                pctPiscar2.Visible = False
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("PiscarInformacao" & Chr(13) & ex.Message)
        End Try

    End Sub

#End Region

    '*****************************************************************
    '*********************** COMANDOS DE EXECUÇÃO ********************

#Region "AÇÕES DOS BOTÕES"

    Private Sub btnIncrementar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIncrementar.Click

        Try

            If blnModoSimulacao = True Then
                dblCarga = 0
                dblPressao = 0
                dblPenetracao = 0
                lblPenetracao.Text = 0
            End If

            If Not VerificarDados() Then Exit Sub

            If rdbModoDeslocamento.Checked Then
                'Habilitar comandos
                Call HabilitarComandos(False, True, True, False, True, True)
            Else
                'Habilitar comandos
                Call HabilitarComandos(False, True, True, True, True, True)
            End If

            If Not blnBotaoIniciar Then
                Call btnCondicoesEnsaio_Click(Nothing, Nothing)
                Call ComandoIniciar()
                intEstadoEnsaio = INICIAR
            Else
                'Altera Destino primeiro
                intEstadoEnsaio = DESTINO 'INCREMENTAR
            End If

            If rdbModoDeslocamento.Checked Then
                btnIncrementar.Text = "&Subir"
                btnDecrementar.Text = "&Descer"
            Else

                btnIncrementar.Text = "&Incrementar"
                btnDecrementar.Text = "&Decrementar"
            End If

        Catch ex As Exception
            MsgBox("btnIncrementar_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnDecrementar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecrementar.Click
        Try

            'Habilita envio do comando velocidade
            blnEnviaVelocidade = True
            'Enviar velocidade negativa (Descer)
            blnVelocidadeNegativa = True

            If rdbModoDeslocamento.Checked Then
                'Habilitar comandos
                Call HabilitarComandos(True, True, False, False, True, True)
            Else
                'Habilitar comandos
                Call HabilitarComandos(True, True, False, True, True, True)
            End If

            If Not blnBotaoIniciar Then Call ComandoIniciar()

            'Altera destino primeiro
            intEstadoEnsaio = DESTINO 'DECREMENTAR

            If rdbModoDeslocamento.Checked Then
                btnIncrementar.Text = "&Subir"
                btnDecrementar.Text = "&Descer"
            Else

                btnIncrementar.Text = "&Incrementar"
                btnDecrementar.Text = "&Decrementar"
            End If

        Catch ex As Exception
            MsgBox("btnDecrementar_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Function PreencheListaGenerica(intNovo As Integer) As List(Of Double)

        Dim listaAtual As List(Of Double)
        listaAtual = New List(Of Double)
        Try
            Select Case intNovo
                Case 0
                    listaAtual = listapenetracao
                Case 1
                    listaAtual = listaCarga
                Case 2
                    listaAtual = listaPressaokgfcm2
                Case 3
                    listaAtual = listaPressaoMPa
            End Select

            PreencheListaGenerica = listaAtual

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("PreencheListaGenerica" & Chr(13) & ex.Message)
        End Try
    End Function
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try

            blnResetThreshold = True

            intEstadoEnsaio = CANCELAR
            blnBotaoFinalizarManual = False
            blnBotaoFinalizarAuto = False
            lblMensagem.Text = "CANCELAR ENSAIO ..."

        Catch ex As Exception
            MsgBox("btnCancelar_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        Try

            blnResetThreshold = True

            intEstadoEnsaio = FINALIZAR
            blnBotaoFinalizarManual = True
            lblMensagem.Text = "FINALIZAR ENSAIO ..."

        Catch ex As Exception
            MsgBox("btnFinalizar_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnRelatorio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRelatorio.Click
        'Imprimir gráfico e dados dos canais
        Dim CorAnterior

        Try
            blnPrintarGrafico = True
            Call ReduzirDimensaoGrafico()
            graficoPavitest.strTituloEixoX = listaOpcoesEixo.ElementAt(intOpcaoX) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoX) & ") "
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "
            graficoPavitest.strVetorLinhasY1 = New List(Of String)

            graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))


            intRelatorio = rpt_ENSAIOS

            Call usrLayout.CarregarFormulario(frmRelatorio, False)

        Catch ex As Exception
            MsgBox("btnRelatorio_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub tlsSair_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlsSair.Click
        'Comando para sair da tela de Aquisição
        Try

            Me.Close()

        Catch ex As Exception
            MsgBox("tlsSair_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

#End Region

    '******************************************************************
    '**************** FUNÇÕES E PROCEDIMENTOS - TIMER *****************

#Region "PROCEDIMENTOS Do ENSAIO"

    Private Sub IntervaloAquisicao()
        Dim lngIntervalo As Long
        Dim dblDifLoop As Double

        Try
            'Ajustar intervalo de leitura
            If dblLoopAnterior <> 0 Then
                dblDifLoop = timeGetTime - dblLoopAnterior
            End If
            dblLoopAnterior = timeGetTime
            lngIntervalo = tmrLeituras.Interval - (dblDifLoop - usrInicializacao.INTERVALO)
            If lngIntervalo > 0 Then
                tmrLeituras.Interval = lngIntervalo
                'Debug.Print(lngIntervalo)
                intContAdvertencia = 0
            Else
                intContAdvertencia = intContAdvertencia + 1
                If intContAdvertencia >= 3 Then
                    tmrLeituras.Interval = 1
                    lblAdvertencia.Text = "Advertência: Aumentar Intervalo em " & (dblDifLoop - usrInicializacao.INTERVALO)
                    lblAdvertencia.Visible = True
                End If
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("IntervaloAquisicao" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub ComandosPreliminares()

        If blnModoSimulacao = False Then

            Try

                If blnReadingOffSucesso = False Then
                    Call DesligaReadingON()
                End If

                If blnDbOffSucesso = False Then
                    Call DesligaDbon()
                End If

                If blnLeuPlacasInicializadasComSucesso = False Then
                    Call LerNumeroPlacasInicializadas()
                End If

                If blnVerificouCanaisHabilitadosComSucesso = False Then
                    Call LerVerificarCanaisHabilitados()
                End If

                'If blnLeuConstantesPIDComSucesso = False Then
                '    Call LerConstantesPID()
                'End If

            Catch ex As Exception
                tmrLeituras.Enabled = False
                MsgBox("ComandosPreliminares" & Chr(13) & ex.Message)
            End Try

        End If

    End Sub

    Private Sub LerVerificarCanaisHabilitados()
        Try

            'Desabilita momentaneamente
            tmrLeituras.Enabled = False

            'Analisa Controlador
            If intNumeroPlacasInicializadas > 0 Then
                'Redimensiona o vetor que verifica os canais habilitados de cada placa
                'ReDim intNumeroCanaisHabilitadosAD(intNumeroPlacasInicializadas - 1)
                ReDim intPlacasLidasComSucesso(intNumeroPlacasInicializadas - 1)

                For i = 0 To intNumeroPlacasInicializadas - 1
                    intNumeroCanaisHabilitadosAD(i) = LerNumeroCanaisHabilitadosAD(i)
                    strCanaisHabAD(i) = usrComunicacao.Transformar_Bit_Canais_Habilitados(intValorByteUnico)
                    intPlacasLidasComSucesso(i) = intRetornoLeituraAD
                Next

            Else
                lblMsgErro.Visible = True
                lblMsgErro.Text = "Não foi possível detectar nenhuma placa inicializada. Verifique se o equipamento está energizado."
            End If

            'Para identificar que a resposta do comando 'rcha' para todas as placas foi corretamente recebida
            For i = 0 To intNumeroPlacasInicializadas - 1
                If intPlacasLidasComSucesso(i) = 0 Then
                    blnVerificouCanaisHabilitadosComSucesso = False
                    Exit For
                Else
                    blnVerificouCanaisHabilitadosComSucesso = True
                End If
            Next

        Catch ex As Exception
            tmrLeituras.Enabled = False
            MsgBox("LerVerificarCanaisHabilitados" & Chr(13) & ex.Message)
        Finally
            'Reabilita do timer
            tmrLeituras.Enabled = True
        End Try

    End Sub

    Private Sub LerNumeroPlacasInicializadas()
        If blnModoSimulacao = False Then
            Try

                'Desabilita momentaneamente
                tmrLeituras.Enabled = False

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_NUMERO_PLACAS_AD_INICIALIZADAS, "Leitura")

                If usrArduino_AD7192.blnErroRespostaByteUnico = False Then
                    intNumeroPlacasInicializadas = intValorByteUnico
                    blnLeuPlacasInicializadasComSucesso = True
                Else
                    lblMsgErro.Text = "Não foi possível identificar a quantidade de placas inicializadas. As leituras não irão ser exibidas até a comunicação ser restabelecida"
                    lblMsgErro.Visible = True
                    blnLeuPlacasInicializadasComSucesso = False
                End If

            Catch ex As Exception
                tmrLeituras.Enabled = False
                MsgBox("LerNumeroPlacasInicializadas" & Chr(13) & ex.Message)
            Finally
                'Reabilita do timer
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Function LerNumeroCanaisHabilitadosAD(ByVal strPlacaTemp As String) As Integer
        If blnModoSimulacao = False Then
            Dim intValorDecimalCanaisHabilitadosAD As Integer

            Try

                strPlaca = strPlacaTemp
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_CANAIS_HABILITADOS_AD, "Leitura")

                If usrArduino_AD7192.blnErroRespostaByteUnico = False Then
                    intValorDecimalCanaisHabilitadosAD = intValorByteUnico
                    intRetornoLeituraAD = 1
                    Return usrComunicacao.Somar_Canais_Habilitados(intValorDecimalCanaisHabilitadosAD)
                Else
                    intRetornoLeituraAD = 0
                    lblMsgErro.Text = "Não foi possível identificar a quantidade de canais habilitados do AD0. As leituras não irão ser exibidas até a comunicação ser restabelecida"
                    lblMsgErro.Visible = True
                    Return 0
                    Exit Function
                End If

            Catch ex As Exception
                'Mensagem de erro
                MsgBox("LerNumeroCanaisHabilitadosAD()" & Chr(13) & ex.Message)
            End Try
        End If
    End Function

    Private Sub LerConstantesPID()
        If blnModoSimulacao = False Then
            Try

                tmrLeituras.Enabled = False

                If blnLeuKPDeslocamentoComSucesso = False Then
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_CONSTANTE_KP_DESLOCAMENTO_PID, "Leitura")

                    If usrArduino_AD7192.blnErroRespostaFloatNumber = False Then
                        txtKP_Deslocamento.Text = FormatNumber(sngValorFloatRespostaByte, 3)
                        blnLeuKPDeslocamentoComSucesso = True
                    Else
                        blnLeuKPDeslocamentoComSucesso = False
                    End If
                End If

                System.Threading.Thread.Sleep(30)

                If blnLeuKPIncrementoComSucesso = False Then
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_CONSTANTE_KP_INCREMENTO_PID, "Leitura")

                    If usrArduino_AD7192.blnErroRespostaFloatNumber = False Then
                        txtKP_Incremento.Text = FormatNumber(sngValorFloatRespostaByte, 3)
                        blnLeuKPIncrementoComSucesso = True
                    Else
                        blnLeuKPIncrementoComSucesso = False
                    End If
                End If

                System.Threading.Thread.Sleep(30)

                If blnLeuBBComSucesso = False Then
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_BOUNCE_BREAK, "Leitura")

                    If usrArduino_AD7192.blnErroRespostaWordNumber = False Then
                        txtBounceBreak.Text = intValorWordRespostaByte
                        blnLeuBBComSucesso = True
                    Else
                        blnLeuBBComSucesso = False
                    End If
                End If

                System.Threading.Thread.Sleep(30)

                If blnLeuAJComSucesso = False Then
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_ERROR_ADJUST, "Leitura")

                    If usrArduino_AD7192.blnErroRespostaFloatNumber = False Then
                        txtErrorAdjust.Text = FormatNumber(sngValorFloatRespostaByte, 3)
                        blnLeuAJComSucesso = True
                    Else
                        blnLeuAJComSucesso = False
                    End If
                End If

                System.Threading.Thread.Sleep(30)

                If blnLeuSPComSucesso = False Then
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_SAMPLE_TIME, "Leitura")

                    If usrArduino_AD7192.blnErroRespostaWordNumber = False Then
                        txtSampleTime.Text = intValorWordRespostaByte
                        blnLeuSPComSucesso = True
                    Else
                        blnLeuSPComSucesso = False
                    End If
                End If

                System.Threading.Thread.Sleep(30)

                If blnLeuMAComSucesso = False Then
                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_MINIMO_VALOR_AJUSTE, "Leitura")

                    If usrArduino_AD7192.blnErroRespostaFloatNumber = False Then
                        txtMinimoAjuste.Text = FormatNumber(sngValorFloatRespostaByte, 3)
                        blnLeuMAComSucesso = True
                    Else
                        blnLeuMAComSucesso = False
                    End If

                End If

            Catch ex As Exception
                MsgBox("LerConstantesPID()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AlterarKP_Deslocamento()
        If blnModoSimulacao = False Then
            Dim strTemp As String = ""

            Try

                tmrLeituras.Enabled = False

                strTemp = txtKP_Deslocamento.Text

                strValorKP = FormatarPontoDecimal(strTemp)

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONSTANTE_KP_DESLOCAMENTO_PID, "Escrita")

            Catch ex As Exception
                MsgBox("AlterarKP_Deslocamento()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AlterarKP_Incremento()
        If blnModoSimulacao = False Then
            Dim strTemp As String = ""

            Try

                tmrLeituras.Enabled = False

                strTemp = txtKP_Incremento.Text

                strValorKP = FormatarPontoDecimal(strTemp)

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_CONSTANTE_KP_INCREMENTO_PID, "Escrita")

            Catch ex As Exception
                MsgBox("AlterarKP_Incremento()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AlterarBB()
        If blnModoSimulacao = False Then
            Dim strTemp As String = ""

            Try

                tmrLeituras.Enabled = False

                strTemp = txtBounceBreak.Text

                strValorBB = FormatarPontoDecimal(strTemp)

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_BOUNCE_BREAK, "Escrita")

            Catch ex As Exception
                MsgBox("AlterarBB()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AlterarErrorAdjust()
        If blnModoSimulacao = False Then
            Dim strTemp As String = ""

            Try

                tmrLeituras.Enabled = False

                strTemp = txtErrorAdjust.Text

                strValorErrorAdjust = FormatarPontoDecimal(strTemp)

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_ERROR_ADJUST, "Escrita")

            Catch ex As Exception
                MsgBox("AlterarErrorAdjust()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AlterarSampleTime()
        If blnModoSimulacao = False Then
            Dim strTemp As String = ""

            Try

                tmrLeituras.Enabled = False

                strTemp = txtSampleTime.Text

                strValorSampleTime = FormatarPontoDecimal(strTemp)

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_SAMPLE_TIME, "Escrita")

            Catch ex As Exception
                MsgBox("AlterarSampleTime()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Sub AlterarMinimoAjuste()
        If blnModoSimulacao = False Then
            Dim strTemp As String = ""

            Try

                tmrLeituras.Enabled = False

                strTemp = txtMinimoAjuste.Text

                strValorMinimoAjuste = FormatarPontoDecimal(strTemp)

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_MINIMO_VALOR_AJUSTE, "Escrita")

            Catch ex As Exception
                MsgBox("AlterarMinimoAjuste()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Public Sub RealizarLeituras()
        If blnModoSimulacao = False Then

            Try

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_MULTIPLAS_RESPOSTAS, "Leitura")

                'Condição de validação
                If Not usrArduino_AD7192.blnErroRespostasMultiplas Then
                    Call ApresentarLeituras()
                    Call ApresentarStatus()
                    intContadorErroComandoRall = 0
                Else
                    intContadorErroComandoRall += 1
                    If intContadorErroComandoRall >= 20 Then
                        lblMsgErro.Text = "Erro de comunicação nas leituras dos instrumentos e sensores ('rall')"
                        lblMsgErro.Visible = True
                    End If
                End If

            Catch ex As Exception
                Err.Clear()
            End Try

        End If
    End Sub

    Private Sub ApresentarLeituras()
        Try

            If usrInicializacaoFabricante.HABILITACAO_CARGA = "True" Then
                dblCarga = FormatNumber(sngLeituraCarga, 1)
                'Leitura do Valor
                Call FormatarLeituras(CARGA)
            Else
                dblCarga = -1
            End If

            If usrInicializacaoFabricante.HABILITACAO_DESLOCAMENTO = "True" Then
                dblPenetracao = FormatNumber(sngLeituraDeslocamento, 3)
                'Leitura do Valor
                Call FormatarLeituras(LVDT)
            Else
                dblPenetracao = -1
            End If

            lblOutputMotor.Text = FormatNumber(sngOutputMotor / 100, 2) & " Hz"

            lblSetpointCarga.Text = FormatNumber(sngSetpointCarga, 0) & " kgf"

            dblErroPID = sngSetpointCarga - dblCarga

            lblErroPID.Text = FormatNumber(dblErroPID, 0) & " kgf"

        Catch ex As Exception
            MsgBox("ApresentarLeituras()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub ApresentarStatus()

        Dim strStatus(1) As String
        Dim intStatusParte1, intStatusParte2 As Integer

        Try

            If strStatusInputs <> "" Then

                'Se chegou até aqui a comunicação com Contralador foi com sucesso
                'Recebe os status para avaliar os demais dispositivo
                strStatus = strStatusInputs.Split(":")
                intStatusParte1 = CInt(strStatus(0))
                intStatusParte2 = CInt(strStatus(1))

                'Decodifica os status
                Call usrComunicacao.Transformar_Bit_Status1(intStatusParte1, intStatusParte2)

                'Leitura Status: Modo Local / Modo Remoto
                lblModoRemotoLocal.Text = usrComunicacao.strStatusMaquina(6)

                'Modo Local/Modo Remoto
                If usrComunicacao.strStatusMaquina(6) = "Modo Local (Manual)" Then
                    lblModoRemotoLocal.ForeColor = Color.Navy
                    blnModoRemoto = False
                Else
                    lblModoRemotoLocal.ForeColor = Color.Red
                    blnModoRemoto = True
                End If

                'FDC e Emergência
                If usrComunicacao.strStatusMaquina(1) = "" And usrComunicacao.strStatusMaquina(2) = "" Then
                    lblFimCurso.Text = "Fim de Curso - ok"
                    lblFimCurso.ForeColor = Color.DarkGray
                    blnFCI_Acionado = False
                    blnFCS_Acionado = False
                ElseIf usrComunicacao.strStatusMaquina(1) = "Fim de Curso Inferior" Then
                    lblFimCurso.Text = "Fim de Curso Inferior"
                    lblFimCurso.ForeColor = Color.Red
                    blnFCS_Acionado = False
                    blnFCI_Acionado = True
                ElseIf usrComunicacao.strStatusMaquina(2) = "Fim de Curso Superior" Then
                    lblFimCurso.Text = "Fim de Curso Superior"
                    lblFimCurso.ForeColor = Color.DarkGray
                    blnFCS_Acionado = True
                    blnFCI_Acionado = False
                Else
                    lblFimCurso.Text = "FDC_I + FDC_S"
                    lblFimCurso.ForeColor = Color.Red
                    blnFCI_Acionado = True
                    blnFCS_Acionado = True
                End If

                If usrComunicacao.strStatusMaquina(3) = "Emergência" Then
                    lblEmergencia.ForeColor = Color.Red
                    blnEmergenciaAcionada = True
                Else
                    blnEmergenciaAcionada = False
                    lblEmergencia.ForeColor = Color.DarkGray
                End If

                'Leitura Status: Sobrecarga
                If usrComunicacao.strStatusMaquina(0) = "Sobrecarga On" Then
                    lblSobrecarga.ForeColor = Color.Red
                    blnSobrecargaAcionada = True
                Else
                    lblSobrecarga.ForeColor = Color.DarkGray
                    blnSobrecargaAcionada = False
                End If

                'Leitura Status: Sobrecurso
                If usrComunicacao.strStatusMaquina(10) = "Sobrecurso On" Then
                    lblSobrecurso.ForeColor = Color.Red
                    blnSobrecursoAcionado = True
                Else
                    lblSobrecurso.ForeColor = Color.DarkGray
                    blnSobrecursoAcionado = False
                End If

                If usrComunicacao.strStatusMaquina(8) = "Threshold de Carga" Then
                    'Leitura Status: Limites Threshold (Carga e LVDT)
                    lblThresholdCarga.ForeColor = Color.Navy
                Else
                    lblThresholdCarga.ForeColor = Color.DarkGray
                End If

                If usrComunicacao.strStatusMaquina(7) = "Threshold de Deslocamento" Then
                    lblThresholdDeslocamento.ForeColor = Color.Navy
                Else
                    lblThresholdDeslocamento.ForeColor = Color.DarkGray
                End If


                'Leitura Status: PID
                If usrComunicacao.strStatusMaquina(12) = "PID Ligado" Then
                    lblPID.Text = "PID Ligado"
                    lblPID.ForeColor = Color.Navy
                Else
                    lblPID.Text = "PID Desligado"
                    lblPID.ForeColor = Color.DarkGray
                End If

                If usrComunicacao.strStatusMaquina(13) = "" And usrComunicacao.strStatusMaquina(14) = "" Then
                    lblSetpointSubindo.ForeColor = Color.DarkGray
                    lblSetpointDescendo.ForeColor = Color.DarkGray

                    'Se alem se setpoints parados, o PID continua ligado, então está estabilizando
                    If usrComunicacao.strStatusMaquina(12) = "PID Ligado" Then
                        strEstabilizacaoAutomatica = "Estabilizando"
                    Else
                        strEstabilizacaoAutomatica = "Parado"
                    End If

                ElseIf usrComunicacao.strStatusMaquina(13) = "Subindo Setpoint" Then
                    lblSetpointSubindo.ForeColor = Color.Navy
                    lblSetpointDescendo.ForeColor = Color.DarkGray
                ElseIf usrComunicacao.strStatusMaquina(14) = "Descendo Setpoint" Then
                    lblSetpointSubindo.ForeColor = Color.DarkGray
                    lblSetpointDescendo.ForeColor = Color.Navy
                End If

                'Movimentação da Prensa
                If usrComunicacao.strStatusMaquina(4) = "Subindo" Then
                    lblSubindo.Text = "Prensa Subindo"
                    lblSubindo.ForeColor = Color.Navy
                Else
                    lblSubindo.Text = "Prensa Parada"
                    lblSubindo.ForeColor = Color.DarkGray
                End If

                If usrComunicacao.strStatusMaquina(5) = "Descendo" Then
                    lblDescendo.Text = "Prensa Descendo"
                    lblDescendo.ForeColor = Color.Navy
                Else
                    lblDescendo.Text = "Prensa Parada"
                    lblDescendo.ForeColor = Color.DarkGray
                End If

                If usrComunicacao.strStatusMaquina(9) = "Célula de Carga Conectada" Then
                    lblConexaoCelula.Text = "Célula Conectada"
                    lblConexaoCelula.ForeColor = Color.Navy
                Else
                    lblConexaoCelula.Text = "Célula Desconectada"
                    lblConexaoCelula.ForeColor = Color.Red
                End If

                If usrComunicacao.strStatusMaquina(11) = "Reposicionou" Then
                    lblReposicionamento.Text = "Reposicionou"
                    lblReposicionamento.ForeColor = Color.Navy
                Else
                    lblReposicionamento.ForeColor = Color.DarkGray
                    lblReposicionamento.Text = "Reposicionamento"
                End If

            End If

        Catch ex As Exception
            MsgBox("ApresentarStatus()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub FormatarLeituras(ByVal intLeitura As Integer)
        Try

            Select Case intLeitura
                Case CARGA
                    'Carga (kgf)
                    lblCarga.Text = FormatNumber(dblCarga, 0)  'Carga

                    dblPressao = dblCarga / dblAreaEnsaio

                    If strTipoEnsaio = "DNIT 172 - ME" Then
                        'Pressão (kgf/cm²)
                        lblLegendaPressao.Text = "Pressão (kgf/cm²)"
                        lblPressao.Text = FormatNumber(dblPressao, 2) 'Pressão (kgf/cm²)
                    Else
                        'Pressão (MPa)
                        lblLegendaPressao.Text = "Pressão (MPa)"
                        lblPressao.Text = FormatNumber(dblPressao * 0.1, 2) 'Pressão (MPa)
                    End If

                Case LVDT
                    'Penetração(mm)
                    lblPenetracao.Text = FormatNumber(dblPenetracao, 3)    'LVDT
            End Select

        Catch ex As Exception
            MsgBox("FormatarLeituras()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub RealizarTaraInstrumentos()

        If blnModoSimulacao = False Then

            Try

                'Desabilita momentâneamente
                tmrLeituras.Enabled = False

                If blnZerarCelulaCarga Then

                    strPlaca = usrInicializacaoFabricante.CELULACARGA_PLACA
                    strValorCanalAD = usrInicializacaoFabricante.CELULACARGA_CANAL

                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TARE_INSTRUMENTO, "Escrita")
                    If ValidaComandoEscrita() Then
                        blnZerarCelulaCarga = False
                        blnTara = False
                    End If

                    'Aguarda tempo adicional para enviar dois comandos seguidos
                    If blnZerarDeslocamentoPrensa = True Then System.Threading.Thread.Sleep(30)

                End If

                If blnZerarDeslocamentoPrensa Then

                    strPlaca = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_PLACA
                    strValorCanalAD = usrInicializacaoFabricante.DESLOCAMENTO_PRENSA_CANAL

                    Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TARE_INSTRUMENTO, "Escrita")
                    If ValidaComandoEscrita() Then
                        blnZerarDeslocamentoPrensa = False
                        blnTara = False
                    End If

                End If

            Catch ex As Exception
                'Mensagem de erro
                MsgBox("RealizarTaraInstrumentos" & Chr(13) & ex.Message)
            Finally
                'Reabilita o timer
                tmrLeituras.Enabled = True
            End Try

        End If
    End Sub

    Public Sub CarregarVetorPenetracao()
        Try

            'Intervalo de aquisição dos dados de acordo com as deformações geradas
            If strTipoEnsaio = "ABNT NBR 9895" Then
                ReDim dblVetorPenetracao(0 To 13)
                dblVetorPenetracao(0) = 0.63
                dblVetorPenetracao(1) = 1.27
                dblVetorPenetracao(2) = 1.9
                dblVetorPenetracao(3) = 2.54
                dblVetorPenetracao(4) = 3.17
                dblVetorPenetracao(5) = 3.81
                dblVetorPenetracao(6) = 4.44
                dblVetorPenetracao(7) = 5.08
                dblVetorPenetracao(8) = 6.35
                dblVetorPenetracao(9) = 7.62
                dblVetorPenetracao(10) = 8.89
                dblVetorPenetracao(11) = 10.16
                dblVetorPenetracao(12) = 11.43
                dblVetorPenetracao(13) = 12.7
            Else
                ReDim dblVetorPenetracao(0 To 8)
                dblVetorPenetracao(0) = 0.63
                dblVetorPenetracao(1) = 1.27
                dblVetorPenetracao(2) = 1.9
                dblVetorPenetracao(3) = 2.54
                dblVetorPenetracao(4) = 3.81
                dblVetorPenetracao(5) = 5.08
                dblVetorPenetracao(6) = 7.62
                dblVetorPenetracao(7) = 10.16
                dblVetorPenetracao(8) = 12.7
            End If

            'quando nbr 9895
            'tem 14 posições conferir

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarVetorPenetracao" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub BuscarResultado()
        Try

            If blnBuscar1 Then
                If dblPenetracao >= dblVetorPenetracao(3) Then ' 2.54 mm
                    blnBuscar1 = False
                    dblPLeitura1 = dblPressao
                    dblISC1 = dblPressao * 100 / 70.31

                    If blnMudouUnidadeMPa = False Then
                        txtCalculada0.Text = FormatNumber(dblPLeitura1, 2)
                    Else
                        txtCalculada0.Text = FormatNumber(dblPLeitura1 * 0.1, 2)
                    End If

                    txtISC0.Text = FormatNumber(dblISC1, 2)

                End If
                End If

            If blnBuscar2 Then
                If dblPenetracao >= dblVetorPenetracao(5) Then ' 5.08 mm
                    blnBuscar2 = False
                    dblPLeitura2 = dblPressao

                    dblISC2 = dblPressao * 100 / 105.46

                    If blnMudouUnidadeMPa = False Then
                        txtCalculada1.Text = FormatNumber(dblPLeitura2, 2)
                    Else
                        txtCalculada1.Text = FormatNumber(dblPLeitura2 * 0.1, 2)
                    End If

                    txtISC1.Text = FormatNumber(dblISC2, 2)

                End If
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("BuscarResultado" & Chr(13) & ex.Message)
            'Err.Clear()
        End Try

    End Sub

    Public Sub CancelarFinalizar()
        Dim strMensagem As String
        strMensagem = ""

        Try

            blnComunicacao = False

            blnBotaoIniciar = False

            If intEstadoEnsaio = FINALIZAR Then

                'Desabilitar os comandos
                Call HabilitarComandos(False, False, False, False, False, False)

                'Ensaio finalizado
                Me.Text = Me.Text & " - ensaio concluido"
                lblMensagem.Text = "Ensaio finalizado."

                'Mensagem de finalizacao
                If blnBotaoFinalizarManual Then
                    strMensagem = "O ensaio foi finalizado pelo usuário." &
                                Chr(13) & "Deseja gravar os dados obtidos neste ensaio?"
                End If

                If blnBotaoFinalizarAuto Then
                    strMensagem = "A aquisição de dados foi finalizada. " & strTipoFinalizacao & ". " &
                        Chr(13) & Chr(13) & "Deseja gravar os dados obtidos neste ensaio?"
                End If

                'Comando Salvar dados
                If MsgBox(strMensagem, vbQuestion + vbYesNo, strCompactacao) = vbYes Then
                    strTabela = "AMOSTRA" & IdAmostraEnsaio & "CP" & intIdCP
                    'Call GravarEnsaio_CriarTabela(strTabela)
                    'Call GravarDadosLeitura()
                    Call GravarResultado()
                    blnAtualizarTelaCadastro = True
                    frmCadastrarCP.AtualizarNavegador()
                End If

                'Se reposicionar máquina
                If MsgBox("Deseja reposicionar a prensa?", MsgBoxStyle.YesNo, "Reposicionar") = MsgBoxResult.Yes Then
                    If blnModoSimulacao = False Then
                        blnReposicionar = True
                        tmrReposicionar.Enabled = True
                        blnComunicacao = True
                    Else
                        'Habilitar gerar relatório
                        HabilitarRelatorio(True)
                        'Habilitar sair
                        Call HabilitarSair(True)
                    End If
                Else
                    'Habilitar gerar relatório
                    HabilitarRelatorio(True)
                    'Habilitar sair
                    Call HabilitarSair(True)
                End If

            Else

                'Se reposicionar máquina
                If MsgBox("Deseja reposicionar a prensa?", MsgBoxStyle.YesNo, "Reposicionar") = MsgBoxResult.Yes Then
                    blnReposicionar = True
                    tmrReposicionar.Enabled = True
                    blnComunicacao = True
                Else
                    'Desabilitar os comandos
                    Call HabilitarComandos(True, False, False, False, False, False)
                    'Habilitar sair da tela de ensaio
                    Call HabilitarSair(True)
                    'Habilitar relatório
                    Call HabilitarRelatorio(True)

                    lblMensagem.Text = "Ensaio Cancelado"
                    lblMensagem.BackColor = Color.DarkOliveGreen
                    'Reabilita botões    
                    Call HabilitarZerar(True)

                    If blnModoRemoto Then
                        Call ComandoModoLocal()
                    End If

                    'Reabilita timer
                    tmrLeituras.Enabled = True
                    tmrLeituras.Interval = 500
                End If

            End If

        Catch ex As Exception
            MsgBox("CancelarFinalizar()" & Chr(13) & ex.Message)
        End Try

    End Sub

#End Region

    '**************************************************************
    '****************** FUNÇÕES E PROCEDIMENTOS *******************

#Region "FUNÇÕES E PROCEDIMENTOS INICIAIS"

    Public Sub IniciandoVariaveis()

        Try

            'Iniciando o programa
            blnBotaoIniciar = False
            blnBotaoParar = False
            blnBotaoFinalizarManual = False
            blnBotaoFinalizarAuto = False

            blnComandoParar = False

            intContPosicao = 0

            dblCargaMaxima = 0

            dblPLeitura1 = 0
            dblPLeitura2 = 0
            blnBuscar1 = True
            blnBuscar2 = True

        Catch ex As Exception
            MsgBox("IniciandoVariaveis()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub HabilitaLeiturasPID(ByVal blnHabilita As Boolean)
        Try

            lblSeparadorSetpoint.Visible = blnHabilita
            lblSeparadorOutput.Visible = blnHabilita
            lblSeparadorErroPID.Visible = blnHabilita
            lblSeparadorIntervalo1.Visible = blnHabilita
            lblSeparadorIntervalo2.Visible = blnHabilita
            lblSeparadorReset.Visible = blnHabilita

            lblLegendaSepoint.Visible = blnHabilita
            lblLegendaOutput.Visible = blnHabilita
            lblLegendaErroPID.Visible = blnHabilita
            lblLegendaIntervalo1.Visible = blnHabilita
            lblLegendaIntervalo2.Visible = blnHabilita
            lblResetDisplay.Visible = blnHabilita

            lblSetpointCarga.Visible = blnHabilita
            lblOutputMotor.Visible = blnHabilita
            lblErroPID.Visible = blnHabilita
            lblIncrementoMPa.Visible = blnHabilita
            lblIncrementokgf.Visible = blnHabilita

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitaLeiturasPID" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub HabilitarComandos(ByVal blnIncrementar As Boolean, ByVal blnParar As Boolean, ByVal blnDecrementar As Boolean, ByVal blnEstabilizar As Boolean, ByVal blnCancelar As Boolean, ByVal blnFinalizar As Boolean)
        Try

            'Comando INCREMENTAR
            btnIncrementar.Enabled = blnIncrementar
            mnuIncrementar.Enabled = blnIncrementar

            'Comando PARAR
            btnParar.Enabled = blnParar
            mnuParar.Enabled = blnParar

            'Comando Estabilizar
            btnEstabilizar.Enabled = blnEstabilizar
            mnuEstabilizar.Enabled = blnEstabilizar

            'Comando DECREMENTAR
            btnDecrementar.Enabled = blnDecrementar
            mnuDecrementar.Enabled = blnDecrementar

            'Comando Cancelar
            btnCancelar.Enabled = blnCancelar
            mnuCancelar.Enabled = blnCancelar

            'Comando Finalizar
            btnFinalizar.Enabled = blnFinalizar
            mnuFinalizar.Enabled = blnFinalizar

        Catch ex As Exception
            MsgBox("HabilitarComandos()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub HabilitarRelatorio(ByVal blnRelatorio As Boolean)
        Try

            'Relatório
            btnRelatorio.Enabled = blnRelatorio
            tlsRelatorio.Enabled = blnRelatorio
            btnCalcularRegressão.Enabled = blnRelatorio

        Catch ex As Exception
            MsgBox("HabilitarRelatorio()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub HabilitarZerar(ByVal blnZerar As Boolean)
        Try

            'Carga
            pctZerarCarga.Enabled = blnZerar
            pctZerarPenetracao.Enabled = blnZerar

        Catch ex As Exception
            MsgBox("HabilitarZerar()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub HabilitarSair(ByVal btnSair As Boolean)
        Try

            tlsSair.Enabled = btnSair
            mnuSair.Enabled = btnSair
            Me.btnSair.Enabled = btnSair

        Catch ex As Exception
            MsgBox("HabilitarSair()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub ComandoIniciar()
        Try

            If blnCriarTabelaBD = False Then
                'Nome da Tabela - AMOSTRAxxCPxx
                Dim strTabela As String = "AMOSTRA" & intIdAmostra & "CP" & intIdCP
                'Criar tabela dos dados de leitura
                Call GravarEnsaio_CriarTabela(strTabela)
                blnCriarTabelaBD = True
            End If

            blnPrimeiroPonto = True

            ''Formatar o gráfico
            Call FormatarGrafico()

            'Variáveis de controle
            Call IniciandoVariaveis()

            Call InstanciarListas()

            'Desabilitar sair
            Call HabilitarSair(False)

            Call HabilitarZerar(False)

            'Iniciar o ensaio
            blnBotaoIniciar = True

        Catch ex As Exception
            MsgBox("ComandoIniciar()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub ComandoModoRemoto()
        If blnModoSimulacao = False Then
            Try
                tmrLeituras.Enabled = False
                'Modo local
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_MODO_OPERACAO_REMOTO, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ModoRemoto()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Public Sub ComandoModoLocal()
        If blnModoSimulacao = False Then
            Try
                'Modo local
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_MODO_OPERACAO_MANUAL, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ModoLocal()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Sub ComandoTesteAutomatico()
        If blnModoSimulacao = False Then
            Try
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_TESTE_AUTOMATICO, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoTesteAutomatico()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Sub ComandoResetTesteAutomatico()
        If blnModoSimulacao = False Then
            Try

                tmrLeituras.Enabled = False

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, RESET_TESTE_AUTOMATICO, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoResetTesteAutomatico()" & Chr(13) & ex.Message)
            Finally
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Public Sub ComandoSetThresholdCarga()
        If blnModoSimulacao = False Then
            Try

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_THRESHOLD_CARGA, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoSetThresholdCarga()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Sub ComandoLerThresholdCarga()
        If blnModoSimulacao = False Then
            Try

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_THRESHOLD_CARGA, "Leitura")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoLerThresholdCarga()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DesligaDbon()
        If blnModoSimulacao = False Then
            Try

                'Desabilitar o timer momentâneamente
                tmrLeituras.Enabled = False

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESLIGAR_DEBUG_PROCESSADOR, "Escrita")

                If ValidaComandoEscrita() = True Then
                    blnDbOffSucesso = True
                Else
                    blnDbOffSucesso = False
                End If

            Catch ex As Exception
                'Mensagem de erro
                MsgBox("DesligaDbon()" & Chr(13) & ex.Message)
            Finally
                'reabilita o timer 
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Private Sub DesligaReadingON()
        If blnModoSimulacao = False Then
            Try

                'Desabilitar o timer momentâneamente
                tmrLeituras.Enabled = False

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_DESLIGAR_READING_ON, "Escrita")

                If ValidaComandoEscrita() = True Then
                    blnReadingOffSucesso = True
                Else
                    blnReadingOffSucesso = False
                End If

            Catch ex As Exception
                'Mensagem de erro
                MsgBox("DesligaReadingON()" & Chr(13) & ex.Message)
            Finally
                'reabilita o timer 
                tmrLeituras.Enabled = True
            End Try
        End If
    End Sub

    Public Sub ComandoAlterarTaxa()

        Try
            'Recebe o valor da velocidade digitado pelo usuário
            dblTaxaEnsaio = CDbl(txtVelocidade.Text)

            If rdbModoIncrementoCarga.Checked Then

                If (dblTaxaEnsaio > 0) And (dblTaxaEnsaio <= 500) Then
                    'Altera a cor do texto validando
                    txtVelocidade.ForeColor = Color.Blue
                Else
                    lblMensagem.Text = "O equipamento aceita somente taxas no intervalo entre 0,1 a 500 kgf/s"
                    lblMensagem.BackColor = Color.DarkRed
                    txtVelocidade.Text = "5,0"
                    dblTaxaEnsaio = 5
                    txtVelocidade.ForeColor = Color.Red
                End If

            Else

                If (dblTaxaEnsaio >= 1) And (dblTaxaEnsaio <= 50) Then
                    'Altera a cor do texto validando
                    txtVelocidade.ForeColor = Color.Blue
                Else
                    lblMensagem.Text = "O equipamento aceita somente velocidades no intervalo de 0,5 a 50,00 mm/min"
                    lblMensagem.BackColor = Color.DarkRed
                    txtVelocidade.Text = "1,27"
                    dblTaxaEnsaio = 1.27
                    txtVelocidade.ForeColor = Color.Red
                End If

            End If

        Catch ex As Exception
            MsgBox("ComandoAlteraVelocidade()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub ComandoPararMotor()
        If blnModoSimulacao = False Then
            Try

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_PARAR_MOTOR, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoPararMotor()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Sub ComandoEstabilizar()
        If blnModoSimulacao = False Then
            Try

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_ESTABILIZAR_CONTROLE_PROCESSADOR, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoEstabilizar()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Sub ComandoReposicionarMotor()
        If blnModoSimulacao = False Then
            Try
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_REPOSICIONAR, "Escrita")
                If ValidaComandoEscrita() = False Then
                    lblMsgErro.Text = "Não foi possível enviar o comando 'srep'. Será tentado novamente no próximo ciclo"
                    lblMsgErro.Visible = True
                    Exit Sub
                End If

                usrDiversos.EsperarTempo(25)

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_VELOCIDADE_REPOSICIONAR, "Escrita")
                If ValidaComandoEscrita() = False Then
                    lblMsgErro.Text = "Não foi possível enviar a velocidade de reposicionamento. Será tentado novamente no próximo ciclo"
                    lblMsgErro.Visible = True
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox("ComandoPararMotor()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Sub ComandoZerarPicoCarga()
        If blnModoSimulacao = False Then
            Try

                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_ZERAR_PICO_CARGA_PROCESSADOR, "Escrita")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoZerarPicoCarga()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Sub ComandoLerPico()
        If blnModoSimulacao = False Then
            Try
                Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_PICO_INSTRUMENTO_PROCESSADOR, "Leitura")
                Call ValidaComandoEscrita()

            Catch ex As Exception
                MsgBox("ComandoLerPico()" & Chr(13) & ex.Message)
            End Try
        End If
    End Sub

    Public Function VerificarDados() As Boolean

        Try
            'Desabilita momentâneamente o timer
            tmrLeituras.Enabled = False

            VerificarDados = False

            If chkFinalizacaoAposPenetracao.Checked Then
                If txtPenetracaoLimite.Text = "" Then
                    MsgBox("É necessário digitar um valor de referência para a finalização automática", vbInformation, "Penetração de Referência")
                    txtPenetracaoLimite.Focus()
                    Exit Function
                End If

                If IsNumeric(lblPenetracao.Text) Then
                    If CDbl(txtPenetracaoLimite.Text) < CDbl(lblPenetracao.Text) Then
                        MsgBox("A leitura atual de Penetração (mm) já está superior a condição inicial de finalização automática: " & txtPenetracaoLimite.Text & ". Ajuste a posição do instrumento ou zere a sua leitura.", vbInformation, "Penetração de Referência")
                        Exit Function
                    End If
                Else
                    MsgBox("O campo 'Penetração (mm)' não apresenta um valor númerico!", vbInformation, "Insira um valor numérico")
                    Exit Function
                End If

            End If

            VerificarDados = True

            'Reativa o timer
            tmrLeituras.Enabled = True

        Catch ex As Exception
            MsgBox("VerificarDados()" & Chr(13) & ex.Message)
        End Try

    End Function

#End Region

    '********************************************************************
    '********************* ZERAR OS LEITORES E GUARDO NO .INI ***********

#Region "ZERAR LEITORES E GUARDAR NO ARQUIVO .INI"

    Private Sub pctZerarCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctZerarCarga.Click
        Try

            blnTara = True
            blnZerarCelulaCarga = True

        Catch ex As Exception
            MsgBox("pctZerar_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub pctZerarPenetracao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctZerarPenetracao.Click
        Try

            blnTara = True
            blnZerarDeslocamentoPrensa = True

        Catch ex As Exception
            MsgBox("pctZerarPenetracao_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

#End Region

    '**************************************************************
    '***************** MENSAGEM DE ADVERTÊNCIA ********************

    Private Sub lblAdvertencia_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAdvertencia.Click
        'Apagar mensagem
        Try

            lblAdvertencia.Visible = False

        Catch ex As Exception
            MsgBox("lblAdvertencia_Click1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    '**************************************************************
    '*************** FUNÇÕES E PROCEDIMENTOS - ENSAIO *************

#Region "GRAVAR OS DADOS DO ENSAIO"

    Public Sub AtualizarGrafico()
        'Mostrar valores dos gráficos
        Try

            'With flpGrafico
            '    .set_DataValue(lngContador + 1, 0, dblPenetracao)  'Penetração
            '    .set_DataValue(lngContador + 1, 1, dblPressao)  'Pressão
            'End With

        Catch ex As Exception
            MsgBox("AtualizarGrafico()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub GravarEnsaio_CriarTabela(ByVal strTabela As String)
        'Grava os dados do ensaio em uma tabela
        Dim strSql As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""

            'Apagar tabela se já existir
            Call usrConexao.ExistirTabela(strTabela, True)

            'Criar a tabela
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Penetracao", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Carga", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Pressao", "DOUBLE")

            If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"

            'Comando Sql (Adicionar)
            strSql = "CREATE TABLE [" & strTabela & "] " _
                & strStruture_Campo

            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("GravarEnsaio_CriarTabela" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub GravarDadosLeitura()
        'Grava os dados da leitura
        Dim strSql As String
        Dim odbAdapter As New OleDbDataAdapter()
        Dim dsData As New DataSet()
        Dim dtTable As New DataTable
        Dim dtRow As DataRow

        Try
            'Atribuir valores para os campos
            strSql = "SELECT * FROM [" & strTabela & "]"

            'Conectar 
            odbAdapter.SelectCommand = New OleDbCommand(strSql, oConnection)
            Dim odbBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(odbAdapter)

            odbAdapter.Fill(dsData, strTabela)
            dtTable = dsData.Tables(strTabela)

            For i = 1 To UBound(dblVetor, 2)

                dtRow = dtTable.NewRow()
                dtRow("Penetracao") = dblVetor(0, i)
                dtTable.Rows.Add(dtRow)

                dtTable.Rows(i - 1)("Carga") = dblVetor(1, i)
                dtTable.Rows(i - 1)("Pressao") = dblVetor(2, i)

                odbAdapter.Update(dsData, strNomeTabelaBD)

            Next

        Catch ex As Exception
            MsgBox("GravarDadosLeitura()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub GravarResultado()
        Dim strSql As String
        strStruture_Campo = ""

        Try
            Call usrConexao.ConstruirSQL(cmd_UPDATE, "PCalculada1", dblPLeitura1)
            Call usrConexao.ConstruirSQL(cmd_UPDATE, "PCalculada2", dblPLeitura2)
            Call usrConexao.ConstruirSQL(cmd_UPDATE, "ISC1", dblISC1)
            Call usrConexao.ConstruirSQL(cmd_UPDATE, "ISC2", dblISC2)
            Call usrConexao.ConstruirSQL(cmd_UPDATE, "EnsaioRealizado", True)

            'Comando Sql (Editar)
            strSql = "UPDATE [tblCPs] SET " _
                    & strStruture_Campo _
                    & " WHERE IdAmostra=" & intIdAmostra & " AND IdCP=" & intIdCP

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            MsgBox("GravarResultado()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub GravarCorrecao(ByVal dblPC1 As Double, ByVal dblPC2 As Double, ByVal dblY1 As Double, ByVal dblY2 As Double)
        Dim strSql As String

        Try

            'Gravar apenas na unidade kgf/cm², caso tenha alterado para MPa, faz a conversão
            If blnMudouUnidadeMPa = True Then
                dblPC1 = dblPC1 / 0.1
                dblPC2 = dblPC2 / 0.1
                dblY1 = dblY1 / 0.1
                dblY2 = dblY2 / 0.1
            End If

            strSql = "UPDATE [tblCPs] SET " _
                   & "PCorrigida1 = '" & dblPC1 & "', PCorrigida2 = '" & dblPC2 _
                   & "', Y1 = '" & dblY1 & "', Y2 = '" & dblY2 _
                   & "', ISC1 = '" & FormatNumber(dblISC1, 2) & "', ISC2 = '" & FormatNumber(dblISC2, 2) & "'" _
                   & " WHERE IdAmostra = " & IdAmostraEnsaio & " AND IdCP = " & intIdCP

            usrConexao.ComandoExecucao(strSql)

            blnAtualizarTelaCadastro = True

        Catch ex As Exception
            MsgBox("GravarCorrecao()" & Chr(13) & ex.Message)
        End Try

    End Sub

#End Region

    Public Sub GerarRelatorio()
        Dim strEndereco As String

        Try

            'Relatório dos CP's
            strEndereco = My.Application.Info.DirectoryPath & "\Imagens\Grafico.bmp"
            Call ReduzirDimensaoGrafico()

            intRelatorio = rpt_ENSAIOS

            frmRelatorio.Show()

        Catch ex As Exception
            MsgBox("GerarRelatorio()" & Chr(13) & ex.Message)
        End Try

    End Sub
    Private Sub RetomarDimensaoGrafico()

        graficoPavitest.chartWidth = intLarguraInicial
        graficoPavitest.chartHeight = intAlturaInicial

        graficoPavitest.dblMatrixEixoY1.Add(PreencheListaGenerica(intOpcaoY))


        graficoPavitest.AtualizarGraficoMultiplasListas()

    End Sub
    Private Sub ReduzirDimensaoGrafico()

        intLarguraInicial = graficoPavitest.chartWidth
        intAlturaInicial = graficoPavitest.chartHeight

        graficoPavitest.chartWidth = 680
        graficoPavitest.chartHeight = 290

        graficoPavitest.AtualizarGraficoMultiplasListas()

    End Sub
    '****************************************************************************
    '***************** COMANDOS DE EXECUÇÃO - VELOCIDADE E FINALIZAÇÃO **********

#Region "VELOCIDADE E FINALIZAÇÃO DO ENSAIO"

    Private Sub btnCondicoesEnsaio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCondicoesEnsaio.Click
        'Enviar ponto para finalização
        Try

            'CARGA MÍNIMA PARA INÍCIO DO ENSAIO
            dblCargaMinimaLimite = CDbl(txtCargaMinimaLimite.Text)

            If dblCargaMinimaLimite < 0 Or dblCargaMinimaLimite > 5000 Then
                MsgBox("O maior valor permitido para esse campo é 5000 kgf", MsgBoxStyle.Exclamation, "Carga Mínima - Início de Ensaio")
                txtCargaMinimaLimite.Text = "5"
                dblCargaMinimaLimite = 5
                txtCargaMinimaLimite.ForeColor = Color.Red
                'Reativa o timer
                tmrLeituras.Enabled = True
                Exit Sub
            End If

            txtCargaMinimaLimite.ForeColor = Color.Blue

            'Prepara valor do threshold de carga
            strValor_Thereshold_Carga = FormatarPontoDecimal(dblCargaMinimaLimite)

            '--------------------------------------------------------------------------------------------------------------------------------------
            'COMENTADO ATÉ A VERIFICAÇÃO DO FRED
            ''Desabilita momentâneamente o timer
            'tmrLeituras.Enabled = False
            'Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_THRESHOLD_CARGA, "Escrita")
            'If ValidaComandoEscrita() Then blnThresholdCargaEnviado = True
            '--------------------------------------------------------------------------------------------------------------------------------------

            'DELOCAMENTO MÁXIMO PARA FINALIZAÇÃO DO ENSAIO
            dblPenetracaoFinal = CDbl(txtPenetracaoLimite.Text)

            If dblPenetracaoFinal < 0 Or dblPenetracaoFinal > 50.0 Then
                MsgBox("O maior valor permitido para esse campo é 50.00 mm", MsgBoxStyle.Exclamation, "Penetração Limite - Finalização do Ensaio")
                txtPenetracaoLimite.Text = "12,70"
                dblPenetracaoFinal = 12.7
                txtPenetracaoLimite.ForeColor = Color.Red
                'Reativa o timer
                tmrLeituras.Enabled = True
                Exit Sub
            End If

            txtPenetracaoLimite.ForeColor = Color.Blue
            'Prepara valor do threshold do LVDT
            strValor_Thereshold_Lvdt = FormatarPontoDecimal(dblPenetracaoFinal)

            '--------------------------------------------------------------------------------------------------------------------------------------
            'COMENTADO ATÉ A VERIFICAÇÃO DO FRED
            'Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, SET_THRESHOLD_LVDT, "Escrita")
            'If ValidaComandoEscrita() Then blnThresholdLVDTEnviado = True
            ''Reativa o timer
            'tmrLeituras.Enabled = True
            'If blnThresholdCargaEnviado And blnThresholdLVDTEnviado Then
            '    blnIniciaThreshold = True
            'End If
            '--------------------------------------------------------------------------------------------------------------------------------------

            blnIniciaThreshold = True

        Catch ex As Exception
            MsgBox("btnCondicoesEnsaio_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub RegreesãoLinearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegressao.Click
        Try

            frmRegressaoLinear.Show()

        Catch ex As Exception
            MsgBox("RegreesãoLinearToolStripMenuItem_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnEnviarVelocidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarVelocidade.Click
        Try

            intEstadoEnsaio = TAXA

        Catch ex As Exception
            MsgBox("btnEnviarVelocidade_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Function FormatarPontoDecimal(ByVal strConstante As String) As String
        Try
            'Caso o número seja grande e tenha separação de milhar, tenho que remover esse ponto antes
            If strConstante.Contains(".") Then
                strConstante = strConstante.Replace(".", "")
            End If

            'A virgula que é a separação decimal deve ser substituida por ponto para o arduino entender
            FormatarPontoDecimal = strConstante.Replace(",", ".")

        Catch ex As Exception
            MsgBox("FormatarPontoDecimal()" & Chr(13) & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub CalcularCorrigida(ByVal dblCorrecao As Double)
        'Calcular valor corrigido
        Dim dblX1_Corrigido As Double
        Dim dblX2_Corrigido As Double
        Dim dblResult1 As Double
        Dim dblResult2 As Double

        Try

            dblX1_Corrigido = 2.54 + dblCorrecao
            dblX2_Corrigido = 5.08 + dblCorrecao

            dblResult1 = CalcularEquacaoReta(dblX1_Corrigido)
            dblISC1 = dblResult1 * 100 / 70.31
            txtCorrigida0.Text = FormatNumber(dblResult1, 2)
            txtISC0.Text = FormatNumber(dblISC1, 2)

            dblResult2 = CalcularEquacaoReta(dblX2_Corrigido)
            dblISC2 = dblResult2 * 100 / 105.46
            txtCorrigida1.Text = FormatNumber(dblResult2, 2)
            txtISC1.Text = FormatNumber(dblISC2, 2)

        Catch ex As Exception
            MsgBox("CalcularCorrigida()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Function CalcularEquacaoReta(ByVal dblX As Double) As Double
        'Atraves da equação da reta y = ax + b entre os dois pontos mais próximo
        'posso determinar o ponto (x,y) correspondente a correção
        Dim blnAchou As Boolean
        Dim dblX1, dblY1 As Double
        Dim dblX2, dblY2 As Double
        Dim dbla, dblB As Double
        Dim i As Integer

        Try

            blnAchou = False



            'Achar equação da reta y = ax + b

            '1º) a = (y2 - y1) / (x2 - x1)
            If (dblX2 - dblX1) <> 0 Then dbla = (dblY2 - dblY1) / (dblX2 - dblX1)

            '2º) b = y1 - (a * x1)
            dblB = dblY1 - (dbla * dblX1)

            '3º)Jogar os valores de a, b e x na equação
            CalcularEquacaoReta = (dbla * dblX) + dblB

        Catch ex As Exception
            MsgBox("CalcularEquacaoReta()" & Chr(13) & ex.Message)
        End Try

    End Function

#End Region

    '**************************************************************
    '********** EXECUTANDO OS MENU'S - COMANDO DE EXECUÇÃO ********

#Region "BOTÕES DO MENU SUPERIOR"

    Private Sub mnuIncrementar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuIncrementar.Click
        Try

            btnIncrementar.Focus()
            Call btnIncrementar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuIncrementar_Click1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuDecrementar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDecrementar.Click
        Try

            btnDecrementar.Focus()
            Call btnDecrementar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuDecrementar_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuCancelar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCancelar.Click
        'Comandos de execução do ensaio
        Try

            btnCancelar.Focus()
            btnCancelar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuCancelar_Click1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuFinalizar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFinalizar.Click
        'Comandos de execução do ensaio
        Try

            btnFinalizar.Focus()
            btnFinalizar_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuFinalizar_Click1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuSair_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSair.Click
        'Comandos de execução do ensaio
        Try

            tlsSair_Click(Nothing, Nothing)

        Catch ex As Exception
            MsgBox("mnuSair_Click1()" & Chr(13) & ex.Message)
        End Try
    End Sub

#End Region

    '*****************************************************************************************
    '************************** FORMATAR OS CAMPOS TEXTOS ************************************

#Region "FORMATAÇÃO DOS CAMPOS (ACEITAR SOMENTE NÚMEROS)"

    Private Sub txtPenetracaoLimite_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPenetracaoLimite.GotFocus

        'Selecionar o texto ao receber o foco
        Call usrDiversos.SelecionarFoco(txtPenetracaoLimite)

    End Sub

    Private Sub txtPenetracao_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPenetracaoLimite.KeyPress
        'Válida valores numéricos
        Try

            'Mudança para cor vermelha indicando para enviar velocidade
            txtPenetracaoLimite.ForeColor = Color.Red

            '(OBJETO As TextBox, KeyAscii As Integer, REAL As Boolean, TABS As Boolean, ValorDecimal As Boolean, Negativo As Boolean)
            e.KeyChar = ChrW(usrDiversos.VNumerico(txtPenetracaoLimite, Asc(e.KeyChar), True, True, True, False))

        Catch ex As Exception
            MsgBox("txtPenetracao_KeyPress1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub txtPenetracao_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPenetracaoLimite.LostFocus
        'Formata o campo
        Try

            If IsNumeric(txtPenetracaoLimite.Text) Then txtPenetracaoLimite.Text = FormatNumber(txtPenetracaoLimite.Text, 2)

        Catch ex As Exception
            MsgBox("txtPenetracao_LostFocus1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub txtCargaMinimaLimite_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargaMinimaLimite.GotFocus

        'Selecionar o texto ao receber o foco
        Call usrDiversos.SelecionarFoco(txtCargaMinimaLimite)

    End Sub

    Private Sub txtCargaMinimaLimite_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCargaMinimaLimite.KeyPress
        'Válida valores numéricos
        Try

            'Mudança para cor vermelha indicando para enviar velocidade
            txtCargaMinimaLimite.ForeColor = Color.Red

            '(OBJETO As TextBox, KeyAscii As Integer, REAL As Boolean, TABS As Boolean, ValorDecimal As Boolean, Negativo As Boolean)
            e.KeyChar = ChrW(usrDiversos.VNumerico(txtCargaMinimaLimite, Asc(e.KeyChar), False, True, False, False))

        Catch ex As Exception
            MsgBox("txtCargaMinimaLimite_KeyPress1" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub txtCargaMinimaLimite_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargaMinimaLimite.LostFocus
        'Formata o campo
        Try

            If IsNumeric(txtCargaMinimaLimite.Text) Then txtCargaMinimaLimite.Text = FormatNumber(txtCargaMinimaLimite.Text, 0)

        Catch ex As Exception
            MsgBox("txtCargaMinimaLimite_LostFocus1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub txtVelocidade_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVelocidade.GotFocus

        'Selecionar o texto ao receber o foco
        Call usrDiversos.SelecionarFoco(txtVelocidade)

    End Sub

    Private Sub txtVelocidade_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVelocidade.KeyPress
        'Válida valores numéricos
        Try

            'Mudança para cor vermelha indicando para enviar velocidade
            txtVelocidade.ForeColor = Color.Red

            '(OBJETO As TextBox, KeyAscii As Integer, REAL As Boolean, TABS As Boolean, ValorDecimal As Boolean, Negativo As Boolean)
            e.KeyChar = ChrW(usrDiversos.VNumerico(txtVelocidade, Asc(e.KeyChar), True, True, True, False))

        Catch ex As Exception
            MsgBox("txtVelocidade_KeyPress1()" & Chr(13) & ex.Message)
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

            Call RecomporEixoX()

            'Atualiza Titulos dos eixos e também as escalas.
            Call AtualizaEixos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuEixoX1_DropDownItemClicked" & Chr(13) & ex.Message)
        End Try

    End Sub
    Private Sub CarregarBD(strTabela As String)
        Dim strSql As String
        Dim odbReader As OleDbDataReader

        Try
            'Dados da tabela de ensaio
            strSql = "SELECT * FROM " & strTabela & " ORDER BY Tempo ASC"

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)

            While odbReader.Read

                listaCarga.Add(odbReader(listaOpcoesBD.ElementAt(0).ToString))
                listaPressaokgfcm2.Add(odbReader(listaOpcoesBD.ElementAt(1).ToString))
                listapenetracao.Add(odbReader(listaOpcoesBD.ElementAt(2).ToString))
                'listaTempo.Add(odbReader(listaOpcoesBD.ElementAt(3).ToString))


            End While

            'Terminar leitura
            odbReader.Close()

            'ALIMENTA O VETOR X E VETOR Y COM A LISTA DE DADOS SELECIONADA (TEMPO REAL OU BD)
            Call AtualizaListaDoGraficoEnsaiar()

            'MONTA O GRÁFICO
            Call PlotarDadosGraficoEnsaiar() ' Ou AtualizaEixos()

            blnCarregarBD = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarBD" & Chr(13) & ex.Message)
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

            'Limpa curvas anteriomente adicionadas
            listaCurvasPlotadas.Clear()
            'Adiciona curva principal a lista de plotadas
            listaCurvasPlotadas.Add(listaOpcoesEixo.ElementAt(intOpcaoY))

            'Sinaliza a troca do eixo Y principal
            blnNovoY1 = True

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

    Private Sub RecomporEixoY1()
        Try

            'Uma troca de grandeza em Y1 implica no reset de outras possíveis curvas já existentes
            intVariosY1 = -1
            graficoPavitest.dblMatrixEixoY1 = New List(Of List(Of Double))
            graficoPavitest.listaEixoY1Tracejada = New List(Of List(Of Double))
            listaUsarEmY = New List(Of Double)

            graficoPavitest.strVetorLinhasY1 = New List(Of String)
            graficoPavitest.strVetorLinhasY1.Add(listaOpcoesEixo.ElementAt(intOpcaoY))
            graficoPavitest.listTipoCurva = New List(Of String)
            graficoPavitest.listTipoCurva.Add("Continua")
            graficoPavitest.strTituloEixoY = listaOpcoesEixo.ElementAt(intOpcaoY) & " (" & listaUnidadesMedidas.ElementAt(intOpcaoY) & ") "

            strUnidadeAnterior = listaUnidadesMedidas.ElementAt(intOpcaoY)

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

    Private Sub mnuEixoY1_MouseEnter(sender As Object, e As EventArgs) Handles mnuEixoY1.MouseEnter

        If blnAquisicaoRapida Then
            Call AtualizarOpcoesEixosSqueezeFlow()
        End If

    End Sub
    Private Sub mnuEixoY2_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuEixoY2.DropDownItemClicked

        Dim strOpcaoY2 As String

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

        Call RecomporEixoY2()

        'Atualiza Titulos dos eixos e também as escalas.
        Call AtualizaEixos()

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

    Private Sub RemoverEixoY2(ByVal blnAtualizarEixos As Boolean)
        Try
            'Desativa Eixo Y2
            intOpcaoY2 = -1
            graficoPavitest.strVetorLinhasY2 = New List(Of String)
            graficoPavitest.strTituloEixoY2 = ""
            graficoPavitest.dblMatrixEixoY2 = New List(Of List(Of Double))
            listaUsarEmY2 = New List(Of Double)

            If blnAtualizarEixos Then Call AtualizaEixos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("RemoverEixoY2()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuEixoY2_MouseEnter(sender As Object, e As EventArgs) Handles mnuEixoY2.MouseEnter

        If mnuEixoY2.DropDownItems.Count = 2 Then
            'Atualiza as opções do menu
            For i = 0 To listaOpcoesEixo.Count - 1
                mnuEixoY2.DropDownItems.Add(listaOpcoesEixo.Item(i) & " (" & listaUnidadesMedidas.ElementAt(i) & ") ")
            Next
        End If
    End Sub

    Private Sub mnuEixoY2GrandezaConvertida_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuEixoY2GrandezaConvertida.DropDownItemClicked
        Dim strOpcaoY2 As String

        Try

            'Pega o título da opção clicada
            strOpcaoY2 = e.ClickedItem.Text

            'Limpa a escala máxima para pode atualizar automaticamente quando um valor máximo atual for menor que o máximo anterior
            graficoPavitest.dblScaleMaxY2 = 0
            graficoPavitest.dblScaleMinY2 = 0

            intOpcaoY2 = -11 'Significa que existe uma lista da mesma grandeza com unidade convertida
            strUnidadeConvertidaY2 = strOpcaoY2

            'Atualiza Titulos dos eixos e também as escalas.
            Call AtualizaEixos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuEixoY2_DropDownItemClicked" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuEixoY2GrandezaConvertida_MouseEnter(sender As Object, e As EventArgs) Handles mnuEixoY2GrandezaConvertida.MouseEnter
        Try

            'FILTRA AS OPÇÕES RESTANTES QUE POSSUAM A MESMA UNIDADE DA GRANDEZA PRINCIPAL DO EIXO Y
            Call AtualizarOpcoesDeListasConvertidasY2()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuEixoY2GrandezaConvertida_MouseEnter" & Chr(13) & ex.Message)
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

    Private Sub mnuAutoEixoTempoOrigemFixa_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoTempoOrigemFixa.Click

        Try

            graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = True
            graficoPavitest.blnEscalaAutomaticaEixoXTempoOrigemDinamica = False
            mnuAutoEixoTempoOrigemDinamica.Checked = False
            mnuAutoEixoX.Checked = True
            mnuAutoEixoXEscalaMinMenor.Checked = False
            mnuAutoEixoTempoOrigemFixa.Checked = True

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

    Private Sub mnuAutoEixoTempoOrigemDinamica_Click(sender As Object, e As EventArgs) Handles mnuAutoEixoTempoOrigemDinamica.Click

        Try

            graficoPavitest.blnEscalaAutomaticaEixoXTempoOrigemDinamica = True
            graficoPavitest.blnEscalaAutomaticaEixoXMinimoZero = False
            mnuAutoEixoX.Checked = True
            mnuAutoEixoTempoOrigemDinamica.Checked = True
            mnuAutoEixoTempoOrigemFixa.Checked = False
            mnuAutoEixoXEscalaMin0.Checked = False
            mnuAutoEixoXEscalaMinMenor.Checked = False

            blnEscalaManualX = False



            Call AplicaEscalaAutomatica()


            mnuManualX.Checked = False

        Catch ex As Exception
            MsgBox("mnuAutoEixoTempoOrigemDinamica_Click()" & Chr(13) & ex.Message & Chr(13) & ex.StackTrace)
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

    Private Sub AtualizaEixos()

        Try

            'Se mudou a opção do eixo no rever consulta novamente o banco de dados
            If blnReverEnsaio Then

                If blnCarregarBD Then

                    Call AtualizaListaDoGraficoEnsaiar()

                    Call PlotarDadosGraficoEnsaiar()

                Else
                    strTabela = "AMOSTRA" & intIdAmostra & "CP" & intIdCP
                    Call CarregarBD(strTabela)
                End If

            Else 'Se mudou a opção do eixo durante o ensaio atualiza os titulos e escalas padrão do grafico

                Call AtualizaListaDoGraficoEnsaiar()

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
            'Mensagem de erro
            MsgBox("AtualizaEixos" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub tlsCancelar_Click(sender As Object, e As EventArgs) Handles tlsCancelar.Click

        Call btnCancelar_Click(Nothing, Nothing)

    End Sub

    Private Sub tlsFinalizar_Click(sender As Object, e As EventArgs) Handles tlsFinalizar.Click
        Call btnFinalizar_Click(Nothing, Nothing)
    End Sub

    Private Sub tlsRelatorio_Click(sender As Object, e As EventArgs) Handles tlsRelatorio.Click
        Call btnRelatorio_Click(Nothing, Nothing)
    End Sub

    Private Sub tlsDecrementar_Click(sender As Object, e As EventArgs) Handles tlsDecrementar.Click
        Call btnDecrementar_Click(Nothing, Nothing)
    End Sub

    Private Sub tlsIncrementar_Click(sender As Object, e As EventArgs) Handles tlsIncrementar.Click
        Call btnIncrementar_Click(Nothing, Nothing)
    End Sub

    Private Sub frmGraficoPavitest_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
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

    Private Sub WinChartViewer1_Click(sender As Object, e As EventArgs) Handles WinChartViewer1.Click
        Dim viewer As ChartDirector.WinChartViewer = sender
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

        coordenada_X_pixels = WinChartViewer1.ChartMouseX
        coordenada_Y_pixels = WinChartViewer1.ChartMouseY
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

    Private Sub mnuEixoX1_MouseEnter(sender As Object, e As EventArgs) Handles mnuEixoX1.MouseEnter

        If blnAquisicaoRapida Then
            Call AtualizarOpcoesEixosSqueezeFlow()
        End If

    End Sub
    Private Sub AtualizarOpcoesEixosSqueezeFlow()
        Try
            'Limpa as opções do menu
            mnuEixoX1.DropDownItems.Clear()
            mnuEixoY1.DropDownItems.Clear()

            'Atualiza as opções do menu
            mnuEixoX1.DropDownItems.Add(listaOpcoesEixo.Item(0) & " (" & listaUnidadesMedidas.ElementAt(0) & ") ")
            mnuEixoX1.DropDownItems.Add(listaOpcoesEixo.Item(10) & " (" & listaUnidadesMedidas.ElementAt(10) & ") ")
            mnuEixoX1.DropDownItems.Add(listaOpcoesEixo.Item(12) & " (" & listaUnidadesMedidas.ElementAt(12) & ") ")

            mnuEixoY1.DropDownItems.Add(listaOpcoesEixo.Item(0) & " (" & listaUnidadesMedidas.ElementAt(0) & ") ")
            mnuEixoY1.DropDownItems.Add(listaOpcoesEixo.Item(10) & " (" & listaUnidadesMedidas.ElementAt(10) & ") ")
            mnuEixoY1.DropDownItems.Add(listaOpcoesEixo.Item(12) & " (" & listaUnidadesMedidas.ElementAt(12) & ") ")

            Call AtualizarOpcoesDeListasConvertidasY2()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarOpcoesEixosSqueezeFlow" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub AtualizarOpcoesDeListasConvertidasY2()

        'FILTRA AS OPÇÕES PARA O EIXO Y2, CONDIÇÕES:
        ' (1)- SE Y1 CONTÉM APENAS 1 CURVA, POSSO ADICIONAR UM EIXO Y2 QUE POSSUA UMA CURVA QUE SE RELACIONE DE FORMA INDEPENDENTE;
        ' (2)- SE Y1 CONTÉM N CURVAS DE MESMA UNIDADE, Y2 PODERÁ EXIBIR UMA ESCALA PROPORCIONAL A Y1, EXEMPLO UNIDADE CONVERTIDA (Psi/bar);

        Try

            'Limpa as opções do menu do 'Eixo Y2'
            mnuEixoY2GrandezaConvertida.DropDownItems.Clear()

            'Realiza levantamento para saber qual a unidade já está sendo usada para Y1
            strUnidadeMedidaY1 = listaUnidadesMedidas.ElementAt(intOpcaoY)

            Select Case strUnidadeMedidaY1

                Case "MPa"
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Pressão (GPa)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Pressão (bar)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Pressão (kgf/cm²)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Pressão (ksi)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Pressão (psi)")
                Case "kgf"
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Força (tf)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Força (kN)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Força (N)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Força (lbf)")
                Case "s"
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Tempo (min)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Tempo (h)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Tempo (dia)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Tempo (mês)")
                Case "mm"
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Deslocamento (µm)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Deslocamento (cm)")
                    mnuEixoY2GrandezaConvertida.DropDownItems.Add("Deslocamento (in)")
            End Select

            If graficoPavitest.strVetorLinhasY1.Count = 1 Then



                'Atualiza as opções do menu
                For i = 0 To listaUnidadesMedidas.Count - 1

                    If graficoPavitest.strVetorLinhasY2.Contains(listaOpcoesEixo.ElementAt(i)) Then
                        Continue For

                    End If

                Next

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("AtualizarOpcoesDeListasConvertidasY2" & Chr(13) & ex.Message)
        End Try

    End Sub
    Private Sub txtVelocidade_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVelocidade.LostFocus
        'Formata o campo
        Try

            If IsNumeric(txtVelocidade.Text) Then txtVelocidade.Text = FormatNumber(txtVelocidade.Text, 2)

        Catch ex As Exception
            MsgBox("txtVelocidade_LostFocus1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub mnuAjustes_Click(sender As Object, e As EventArgs) Handles mnuAjustes.Click
        Try

            If blnEnsaioGravado = False Then
                blnLeuKPDeslocamentoComSucesso = False
                blnLeuKPIncrementoComSucesso = False
                blnLeuBBComSucesso = False
                blnLeuAJComSucesso = False
                blnLeuSPComSucesso = False
                blnLeuMAComSucesso = False
                Call LerConstantesPID()
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("mnuAjustes_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnEnviarKP_Deslocamento_Click(sender As Object, e As EventArgs) Handles btnEnviarKP_Deslocamento.Click
        Call AlterarKP_Deslocamento()
    End Sub

    Private Sub btnEnviarKP_Incremento_Click(sender As Object, e As EventArgs) Handles btnEnviarKP_Incremento.Click
        Call AlterarKP_Incremento()
    End Sub

    Private Sub btnEnviarBounceBreak_Click(sender As Object, e As EventArgs) Handles btnEnviarBounceBreak.Click
        Call AlterarBB()
    End Sub

    Private Sub btnEnviarErrorAdjust_Click(sender As Object, e As EventArgs) Handles btnEnviarErrorAdjust.Click
        Call AlterarErrorAdjust()
    End Sub

    Private Sub txtEnviarSampleTime_Click(sender As Object, e As EventArgs) Handles btnEnviarSampleTime.Click
        Call AlterarSampleTime()
    End Sub

    Private Sub btnCalcularRegressão_Click(sender As Object, e As EventArgs) Handles btnCalcularRegressão.Click
        Try

            frmRegressaoLinear.Show()

        Catch ex As Exception
            MsgBox("btnCalcularRegressão_Click()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub rdbModoDeslocamento_CheckedChanged(sender As Object, e As EventArgs) Handles rdbModoDeslocamento.CheckedChanged, rdbModoIncrementoCarga.CheckedChanged
        If rdbModoIncrementoCarga.Checked Then
            lblUnidadeTaxaPrensa.Text = "Taxa (kgf/s)"
            txtVelocidade.Text = "5"
            btnIncrementar.Text = "&Incrementar"
            btnDecrementar.Text = "&Decrementar"
        Else
            lblUnidadeTaxaPrensa.Text = "Taxa (mm/min)"
            txtVelocidade.Text = "1.27"
            btnIncrementar.Text = "&Subir"
            btnDecrementar.Text = "&Descer"
        End If

        If blnBotaoIniciar = False Then
            btnIncrementar.Text = "&Iniciar"
        End If

    End Sub

    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click

        tmrLeituras.Enabled = False

        Call ComandoPararMotor()

        'Habilitar comandos
        If rdbModoDeslocamento.Checked Then
            Call HabilitarComandos(True, False, True, False, True, True)
        Else
            Call HabilitarComandos(True, False, True, True, True, True)
        End If

        btnIncrementar.Enabled = True
        btnDecrementar.Enabled = True
        btnParar.Enabled = False
        btnEstabilizar.Enabled = True

        tmrLeituras.Enabled = True

    End Sub

    Private Sub btnEstabilizar_Click(sender As Object, e As EventArgs) Handles btnEstabilizar.Click

        tmrLeituras.Enabled = False

        Call ComandoEstabilizar()

        'Habilitar comandos
        Call HabilitarComandos(True, True, True, False, True, True)

        tmrLeituras.Enabled = True

    End Sub

    Private Sub mnuParar_Click(sender As Object, e As EventArgs) Handles mnuParar.Click
        Call btnParar_Click(Nothing, Nothing)
    End Sub
    Private Sub mnuEstabilizar_Click(sender As Object, e As EventArgs) Handles mnuEstabilizar.Click
        Call btnEstabilizar_Click(Nothing, Nothing)
    End Sub

    Private Sub btnEnviarMinimoAjuste_Click(sender As Object, e As EventArgs) Handles btnEnviarMinimoAjuste.Click
        Call AlterarMinimoAjuste()
    End Sub

    Private Sub txtKP_AJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKP_Incremento.KeyPress, txtKP_Deslocamento.KeyPress, txtErrorAdjust.KeyPress
        'Validar valores numéricos
        e.KeyChar = usrDiversos.ValorNumericoToolStrip(sender, e.KeyChar, True, True, False)
    End Sub

    Private Sub txtBounceBreak_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBounceBreak.KeyPress, txtSampleTime.KeyPress
        'Validar valores numéricos
        e.KeyChar = usrDiversos.ValorNumericoToolStrip(sender, e.KeyChar, False, True, False)
    End Sub

#End Region

    '**************************************************************
    '***************** SLIDER'S - ESCALAS DO GRÁFICO **************

#Region "ALTERAR ESCALA DO GRÁFICO"

    Private Sub sldSliderX_Scroll1(ByVal sender As Object, ByVal e As System.EventArgs)
        'Chama função para ajustar as escalas do gráfico1
        Try



        Catch ex As Exception
            MsgBox("sldSliderX_Scroll1()" & Chr(13) & ex.Message)
        End Try
    End Sub



#End Region


    Private Sub lblMsgErro_Click(sender As Object, e As EventArgs) Handles lblMsgErro.Click
        lblMsgErro.Visible = False
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Public Sub LeiturasSimuladas()
        dblCarga = 10 + dblCarga
        lblCarga.Text = FormatNumber(dblCarga, 0)
        dblPenetracao = 0.1 + dblPenetracao
        lblPenetracao.Text = FormatNumber(dblPenetracao, 3)
        dblPressao = dblCarga / dblAreaEnsaio

        If strTipoEnsaio = "DNIT 172 - ME" Then
            'Pressão (kgf/cm²)
            lblLegendaPressao.Text = "Pressão (kgf/cm²)"
            lblPressao.Text = FormatNumber(dblPressao, 2) 'Pressão (kgf/cm²)
        Else
            'Pressão (MPa)
            lblLegendaPressao.Text = "Pressão (MPa)"
            lblPressao.Text = FormatNumber(dblPressao * 0.1, 2) 'Pressão (MPa)
        End If

    End Sub
End Class