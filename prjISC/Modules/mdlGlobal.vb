Option Strict Off
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

Module mdlGlobal
    '****************************************************************
    'Declaração de funções globais e variáveis globais

    'Variáveis globais
    Public usrDiversos As clsDiversos
    Public usrInicializacao As New clsInicializacao
    Public usrInicializacaoFabricante As clsInicializacao_Fabricante
    Public usrNovus As clsNovus
    Public usrPortaSerial As clsPortaSerial
    Public usrConexao As clsConexao
    Public usrGrafico As clsGrafico
    'Public usrComandos As clsComandos
    Public usrComunicacao As clsComunicacao
    Public usrLayout As clsLayout
    Public usrArduino_AD7192 As New clsArduino_AD7192

    Public usrLicença As clsLicença
    'Global usrTeste                         As clsTeste

    '(Desabilitar botão X)
    Public BotaoX As Object
    'Form Ativo - verificação de erro
    Public strFrmAtivo As String

    'Controle da máquina o ensaio
    Public blnReposicionar As Boolean
    Public blnReposicionou As Boolean

    'Condição do ensaio
    Public intEstadoEnsaio As Integer
    Public intEstadoAnterior As Integer

    'Identificador da amostra/Ensaio
    Public IdAmostraEnsaio As Long
    Public IdCPEnsaio As Long
    Public dteData As Date
    Public strNomeAmostra As String
    Public strCompactacao As String
    Public dblAreaEnsaio As Double
    'Voltar na posição da amostra ensaiada ou revista
    Public blnVoltarPosicaoCP As Boolean
    'Form Carregado
    Public blnFormCPs As Boolean
    Public blnFormAmostras As Boolean
    'Carregar as janela para ensaio ou rever
    Public blnEnsaioGravado As Boolean
    Public blnFormCarregado As Boolean
    'Identificador de posição do CP
    Public intPosicaoFantasia As Integer

    'Visualizar amostras
    Public blnNovaAmostra As Boolean


    'Carregar o form Cadastrar BD
    Public blnBDCarregado As Boolean

    'Conexão com a Base de Dados e Tabelas
    Public oConnection As New OleDbConnection

    'Caminho e Base de Dados
    Public strCaminho As String
    Public strBaseDados As String

    'Montar estruturas sql 
    Public strStruture_Campo As String
    Public strStruture_Valor As String

    'Variáveis erro de porta de comunicação
    Public strErro_Porta_Comunicacao As String
    Public intTentativaAbrirPorta As Integer
    'Recebe o valor do erro (System Error Codes 0-499) – Geralmente erro 5 e/ou 57
    Public intErroNumber As Integer

    'Controla o fechamento manual da porta e a interrupção do timer
    Public blnJaFechouPorta As Boolean
    Public blnErro_Leitura_N1500 As Boolean
    Public blnErro_Leitura_N1500_LVDT As Boolean
    Public blnErro_Leitura_Arduino As Boolean
    Public blnErro_Leitura_Fundo_Escala As Boolean
    Public blnErro_Leitura_Incremento As Boolean
    Public blnErro_Leitura_Send As Boolean
    Public blnErro_Leitura_Slav As Boolean
    Public blnErro_Leitura_Constantes_Calibracao As Boolean
    Public blnErro_Leiturar_Canal_Slave As Boolean
    Public blnErro_AD_09_16 As Boolean
    Public blnCanal_Desabilitado_AD As Boolean
    Public intNumeroCurvaZoom As Integer

    'Condição para finalização comunicação em caso de falha na porta
    Public blnComunicacao As Boolean

    'Gerar relatorios
    Public intRelatorio As Short

    '
    Public strLeitura_Bruta As String
    '
    Public strLeitura_Liquida As String
    'Recebe o valor do comando RTU sem CRC
    Public strComando_ModBus_RTU As String
    'Recebe o valor do comando ASCII
    Public strComando_ModBus_ASCII As String

    'Recebe o valor do fundo escala desejado
    Public strValorFundoEscala_Arduino As String
    'Recebe o valor da escala desejada
    Public strValorEscala_Arduino As String

    'Letra que traz referência a placa AD utilizada
    Public strPlaca As String
    'Recebe o valor do canal desejado
    Public strValorCanalAD As String

    'Recebe o valor a ser alterado no AD slave
    Public strValorOffsetUsuario As String
    Public strValorConstanteUsuario As String '(Escala de Usuário)

    ' Valor a ser modificado do fundo de escala da célula de carga
    Public strValor_Fundo_Escala_Carga_Arduino As String

    ' Valor a ser modificado na constante/escala da célula de carga
    Public strValor_Escala_Calibracao_Constante_Arduino As String

    ' Valor a ser modificado na Revolução
    Public strValor_Escala_Interna_Arduino_Delta As String

    ' Valor a ser modificado na Revolução
    Public strValor_Offset_Interno_Arduino_Delta As String

    ' Valor a ser modificado na Revolução
    Public strValor_Offset_Calibracao_Usuario_Arduino As String

    Public dblValor_Velocidade_Arduino As Double

    Public strValor_Velocidade_Arduino As String

    Public strValor_Thereshold_Carga As String

    Public strValor_Thereshold_Lvdt As String

    Public blnInterromperWhileLeituraMaster As Boolean

    Public blnInterromperWhileEscrita As Boolean

    'Recebe a quantidade de erros de leitura com o Arduino
    Public intErro_Leitura_Resposta_Read As Integer

    'Recebe a quantidade de erros de leitura com o Arduino
    Public intErro_Leitura_Resposta_Slave As Integer

    'Recebe a quantidade de erros de leitura com o Arduino
    Public intErro_Leitura_Respota_String As Integer

    Public intErro_Escrita_Respota_String As Integer

    'Recebe a quantidade de erros de leitura com o Arduino
    Public intErro_Leitura_Respota_Byte As Integer

    Public intLerStatusMaquina As Integer
    Public intLerStatusAD As Integer


    'Valor liquido de uma leitura geral
    Public dblValorFloatRespostaString As Double
    Public lngValorLongRespostaString As Long
    Public sngValorFloatRespostaByte As Single
    Public lngValorLongRespostaByte As Long
    Public sngValorCargaRespostaByte As Single
    Public sngValorLVDTRespostaByte As Single
    Public strStatusArduino(15) As String

    'Valor liquido de uma leitura geral
    Public dblValor_Float_String_Arduino As Double

    'Valor liquido de uma leitura geral
    'Public dblValor_Long_String_Arduino As Double
    Public lngValor_Long_String_Arduino As Long

    Public blnErroLeituraStatusCanalPlaca0 As Boolean
    Public blnErroLeituraStatusCanalPlaca1 As Boolean

    Public strRegressaoY1 As String
    Public strRegressaoY2 As String

    Public strRespostaConferida As String

    'Recebe o valor a ser alterado no AD slave
    Public strValorAlteradoConstante As String
    Public strValorAlteradoOffset As String
    Public strValorAlteradoZero As String
    Public strValorAlteradoFull As String


    'Variáveis clsArduino_N1500
    Public intErro_Leitura_Arduino_Novus As Integer
    Public intErro_Leitura_Arduino_Novus_LVDT As Integer
    Public intErro_Leitura_Incremento As Integer
    Public intErro_Leitura_Fundo_Escala As Integer
    Public intErro_Leitura_Send As Integer
    Public intErro_Leitura_Slav As Integer
    Public intErro_Leitura_Canal_Slave As Integer
    Public intErro_Leitura_Status As Integer


    Public dblCarga_Arduino_N1500 As Double
    Public dblTaxa_Arduino_N1500 As Double
    Public dblFundo_Escala_Arduino1 As Double
    Public dblFundo_Escala_Arduino2 As Double
    Public dblDeformacao_Arduino_N1500 As Double
    Public dblValor_Constantes_Calibracao As Double

    Public strCanalHabilitado_ArduinoSlave As String
    Public blnErro_Leitura_Status As Boolean

    Public sngValor_LVDT_Arduino_N1500 As Single
    Public dblValor_Status_Canais As Double

    'Recebe o valor de identificação da tela
    Public intID_Tela_Comunicacao As Integer

    'Verificar Licença Pavitest
    Public blnLicença As Boolean

    'Se há canais habilitados
    Public blnTemCanalHabilitadoPlaca0 As Boolean
    Public blnTemCanalHabilitadoPlaca1 As Boolean

    'Identicadores
    Public intEnsaio As Integer
    Public intIdAmostra As Integer
    Public intIdCP As Integer

    Public sizeFormMaximized As System.Drawing.Size

    Public intErroLeituraResposta As Integer
    Public intContadorErrosGeral As Integer
    Public intContadorErrosSemDados As Integer
    Public intContadorErrosMenorQEsperado As Integer
    Public intContadorErrosMaiorQEsperado As Integer
    Public intContadorErrosLFCR As Integer

    'Acompanhar quando posso limpar status de label de erro em tela
    Public blnComunicandoSucesso As Boolean

    Public intSomaCanaisHabilitados As Integer
    Public strStatusThreshold As String
    Public intValorByteUnico As Integer
    Public blnSenhaOk As Boolean
    Public blnSenhaFabricanteOK As Boolean
    Public blnTelaSenha As String 'False é Calibração, True é configuração
    Public intSomaCanaisHabilitadosAD0, intSomaCanaisHabilitadosAD1, intNumeroPlacasInicializadas As Integer
    Public intNumeroBytesDinamico As Integer
    Public strValorOffsetInterno, strValorEscalaInterna, strValorFundoEscalaCarga As String
    Public strVelocidadeMotor, strValorTheresholdCarga, strValorTheresholdLvdt, strValorDestinoCarga, strValorTaxaCarga, strValorDestinoDeslocamento, strValorTaxaDeslocamento As String
    Public strValorKP, strValorBB, strValorErrorAdjust, strValorSampleTime, strValorMinimoAjuste As String
    Public intErroLeituraRespotaByte, intErroLeituraRespotaString As Integer
    Public dblValorFloatStringArduino, dblValorLongStringArduino As Double
    Public lngValorLongStringArduino As Long
    Public intValorWordRespostaByte As Integer
    Public strStatusInputs As String
    Public sngSetpointCarga, sngOutputMotor, sngLeituraCarga, sngLeituraDeslocamento As Single
    Public intStatusInicializacaoAD0, intStatusInicializacaoAD1, intCanaisHabilitadosAD0, intCanaisHabilitadosAD1 As Integer
    Public blnPortaCOMFechada As Boolean
    Public intNumeroCanaisHabilitadosAD(3) As Integer

    'Novas variaveis
    Public intOpcaoX As Integer
    Public intOpcaoY As Integer
    Public intOpcaoY2 As Integer

    Public blnEscalaManualX As Boolean
    Public blnEscalaManualY1 As Boolean
    Public blnEscalaManualY2 As Boolean

    Public strUnidadeConvertidaY2 As String
    Public blnReverEnsaio As Boolean

    Public intZoom As Integer
    Public strSentidoZoom As String

    Public blnTelaResultados As Boolean
    Public blnExibirLegenda As Boolean
    Public blnPrintarGrafico As Boolean
    Public intNumeroPrints, intOrdemPrints As Integer

    Public intAlturaInicialGrupoGrafico, intLarguraInicialGrupoGrafico As Integer
    Public blnProcessamentoGraficoCarregado As Boolean
    Public rotacionaGrafico As Boolean
    Public blnLinhaTracejada As Boolean
    Public blnRotacionarGrafico As Boolean
    Public blnModoSimulacao As Boolean

    Public coordenada_X_pixels As Integer
    Public coordenada_Y_pixels As Integer
    Public dblCordenadaX As Double
    Public dblCordenadaY As Double
    Public cornenadaEncontradaY As Double
    Public coordenada_X_valorAproximado As Double
    Public coordenada_Y_valor As Double
    Public coordenada_X_valor As Double
    Public xCoor As Double

    Public listaPenetracao As New List(Of Double)
    Public listaPressaokgfcm2 As New List(Of Double)
    Public listaPressaoMPa As New List(Of Double)
    Public dblMatriz(,) As Double
    Public y1, y2, x1, x2 As Double
    Public dblA As Double
    Public dblB As Double
    Public dblA2 As Double
    Public dblB2 As Double
    Public dblA3 As Double
    Public dblB3 As Double
    Public dblX As Double
    Public dblY As Double
    Public dblValorYCorrigido1 As Double
    Public dblValorYCorrigido2 As Double
    Public dblInterceptY1 As Double
    Public dblSlopeY1 As Double
    Public dblIntercepY2 As Double
    Public dblSlopeY2 As Double
    Public dblX1_Corrigido As Double
    Public dblX2_Corrigido As Double
    Public dblResultMenorYP1 As Double
    Public dblResultMaiorYP1 As Double
    Public dblResultMenorXP1 As Double
    Public dblResultMaiorXP1 As Double

    Public blnEncontrouMaiorMenorY1, blnEncontrouMaiorMenorY2 As Boolean

    Public dblResultMenorYP2 As Double
    Public dblResultMaiorYP2 As Double
    Public dblResultMenorxP2 As Double
    Public dblResultMaiorxP2 As Double

    Public blnPegarY1 As Boolean
    Public blnPegarY2 As Boolean

    Public dblISC1 As Double
    Public dblISC2 As Double

    Public blnAtualizarTelaCadastro As Boolean

    Public blnMudouUnidadeMPa As Boolean
    Public strTipoEnsaio As String
    Public blnStatusExecucaoSQL, blnExisteColunaTipoEnsaio As Boolean

    Public blnHaCPsEnsaiados As Boolean
End Module
