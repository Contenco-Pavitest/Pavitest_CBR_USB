Option Explicit On
Imports System.IO.Ports

Public Class clsArduino_AD7192
    'Contenco Industria e Comercio Ltda.
    'Projeto Pavitest 

    'Arquivo que determina a comunicação com o Novus N1500 (Carga e LVDT)

    'Classe que realiza a comunicacao com o Arduino via MODBUS ASCII

#Region "DECLARAÇÃO DE VARIÁVEIS"


    Dim intresp As Integer
    'Número de bytes que o comando deverá responder
    Dim intNumeroBytes As Integer

    Dim strLixo As String
    Dim SubStringDataHi As String
    Dim SubStringDataLo As String
    Dim DataHi As String
    Dim DataLo As String

    Public lngSensor As Long

    Dim strTipoDado As String
    Dim strConfereEscrita As String

    'Vetor de resposta
    Dim bytVetor() As Byte

    Public blnErroGeral As Boolean
    Public blnErroLeituraCarga As Boolean
    Public blnErroLeituraStatusMaquina As Boolean
    Public blnErroLeituraStatusHabilitacaoCanaisAD As Boolean
    Public blnErroLeituraStatusAD_P0 As Boolean
    Public blnErroLeituraStatusAD_P1 As Boolean
    Public blnErroLeituraLVDT As Boolean
    Public blnErroLeituraConstantesAD As Boolean
    Public blnErroRespostaConferencia As Boolean
    Public blnErroRespostaArduinoByte As Boolean
    Public blnErroRespostaArduinoString As Boolean
    Public blnErroRespostaFloatNumber As Boolean
    Public blnErroRespostasMultiplas As Boolean
    Public blnErroRespostaByteUnico As Boolean
    Public blnErroRespostaWordNumber As Boolean


#End Region

#Region "COMUNICAR (ENVIAR)"

    Public Function Comunicar_Arduino(ByRef objPorta As SerialPort, ByVal intId As Integer, ByVal strTipo As String) As Double

        Try

            System.Threading.Thread.Sleep(30)

            Dim lixo As String = objPorta.ReadExisting()

            'Limpa variável de erro de porta COM
            strErro_Porta_Comunicacao = ""

            'Escrever no arduino
            Call Comando_Enviar(objPorta, intId)

            If strTipo = "Leitura" Or strTipo = "Escrita" Then
                If intNumeroBytes <> 0 Then
                    'Resposta de comandos em formato de bytes
                    Call RespostaArduinoByte(objPorta, intId, strTipo)
                Else
                    'Espera Tempo para resposta vir completa
                    Call System.Threading.Thread.Sleep(15)
                    'Resposta de comandos em formato texto
                    Call RespostaArduinoString(objPorta, intId)
                End If
            End If

        Catch ex As Exception
            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
            If blnJaFechouPorta = True Then Exit Function

            'Mensagem de erro
            strErro_Porta_Comunicacao = ex.Message

            If (objPorta.IsOpen = False) Or (Err.Number = 57) Then
                intErroNumber = Err.Number
                Call usrDiversos.FinalizarComunicacao()
                Exit Function
            End If
        End Try
    End Function

    Public Sub Comando_Enviar(ByRef objPorta As SerialPort, ByVal intId As Integer)

        Try

            'Limpa conferência após leitura
            strConfereEscrita = ""

            Select Case intId

                    '''''--------------------------------------------------------------------------------------------------
                    '''''Comandos leitura AD Slave
                    '''''--------------------------------------------------------------------------------------------------

                Case LER_MULTIPLAS_RESPOSTAS
                    objPorta.Write("rall" & vbLf)
                    '(2B_Status + 4B_Setpoint + 4B_OutputMotor + 1B_StatusInicilizacaoAD0 + 1B_CanaisHabilitadosAD0 + 4B_CelulaCarga + 1B_StatusInicilizacaoAD1 + 1B_CanaisHabilitadosAD1 ) LF CR
                    '(512 ? 01 1 ? 1 0 )
                    'intNumeroBytesDinamico = 1 + 2 + 4 + 4 + (2 * intNumeroPlacasInicializadas) + (intSomaCanaisHabilitadosAD0 * 4) + (intSomaCanaisHabilitadosAD1 * 4) + 1 + 1 + 1
                    intNumeroBytesDinamico = 1 + 2 + 4 + 4 + (2 * intNumeroPlacasInicializadas) + (intNumeroCanaisHabilitadosAD(0) * 4) + (intNumeroCanaisHabilitadosAD(1) * 4) + (intNumeroCanaisHabilitadosAD(2) * 4) + (intNumeroCanaisHabilitadosAD(3) * 4) + 1 + 1 + 1
                    intNumeroBytes = intNumeroBytesDinamico
                    'intNumeroBytes = 22 'intNumeroBytesDinamico 
                    strTipoDado = "FLOAT-LONG"

                Case LER_AD
                    'read
                    objPorta.Write("read" & strPlaca & strValorCanalAD & Chr(10)) 'double
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8 '[4 bytes de leitura] + [2 bytes de parentesis] + [2 bytes LineFeed e CarriageReturn]

                Case LER_OFFSET_CALIBRACAO_USUARIO
                    'rtar
                    objPorta.Write("rtar" & strPlaca & strValorCanalAD & Chr(10)) 'long
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "LONG"

                Case LER_ESCALA_CALIBRACAO_USUARIO
                    'resc
                    objPorta.Write("resc" & strPlaca & strValorCanalAD & Chr(10)) 'double
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_OFFSET_INTERNO_AD
                    'rzer
                    objPorta.Write("rzer" & strPlaca & strValorCanalAD & Chr(10)) 'long
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "LONG"

                Case LER_ESCALA_INTERNA_AD
                    'rful
                    objPorta.Write("rful" & strPlaca & strValorCanalAD & Chr(10)) 'long
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "LONG"

                Case LER_CANAIS_HABILITADOS_AD
                    'rcha 
                    objPorta.Write("rcha" & strPlaca & Chr(10)) 'long
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 5
                    'Tipo de dados 
                    strTipoDado = "LONG"

                Case LER_NUMERO_PLACAS_AD_INICIALIZADAS
                    'rnad
                    objPorta.Write("rnad" & Chr(10)) 'long
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 5
                    'Tipo de dados 
                    strTipoDado = "LONG"

                Case LER_STATUS_MAQUINA
                    'rdst
                    objPorta.Write("rdst" & Chr(10)) '5
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 6 ' [12 bytes de leitura] + [3bytes de ':'] + [2 bytes de parentesis] + [2 bytes LineFeed e CarriageReturn]

                Case LER_CONFIGURACOES
                    'Ler os valores de ajuste de calibração
                    objPorta.Write("conf" & strPlaca & Chr(10))

                Case LER_PICO_INSTRUMENTO_PROCESSADOR
                    'rpic
                    objPorta.Write("rpic" & Chr(10)) 'double
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_CARGA_MAX
                    'rmax
                    objPorta.Write("rmax" & Chr(10)) 'double
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_THRESHOLD_CARGA
                    'rthc
                    objPorta.Write("rthc" & Chr(10)) 'double
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_THRESHOLD_LVDT
                    'rthl
                    objPorta.Write("rthl" & Chr(10)) 'double
                    'Bytes que deverão vir na resposta
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_STATUS_AD
                    'rdsa
                    objPorta.Write("rdsa" & strPlaca & Chr(10)) 'long
                    'Bytes que deverão vir na resposta. Apesar de ser um comando tipo String, nunca virá mais do que 1 byte de resposta líquida, apenas 0 ou 1.
                    intNumeroBytes = 5
                    'Tipo de dados 
                    strTipoDado = "LONG"

                Case LER_DESTINO_CARGA
                    'rdtc
                    objPorta.Write("rdtc" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_TAXA_CARGA
                    'rtxc
                    objPorta.Write("rtxc" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_DESTINO_DESLOCAMENTO
                    'sdtd
                    objPorta.Write("sdtd" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_TAXA_DESLOCAMENTO
                    'stxd
                    objPorta.Write("stxd" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_BOUNCE_BREAK
                    'stbb
                    objPorta.Write("stbb" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "WORD"

                Case LER_ERROR_ADJUST
                    'staj
                    objPorta.Write("staj" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_CONSTANTE_KP_DESLOCAMENTO_PID
                    'stkp
                    objPorta.Write("stkp" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_CONSTANTE_KP_INCREMENTO_PID
                    'stkp
                    objPorta.Write("stkc" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"

                Case LER_SAMPLE_TIME
                    'stst
                    objPorta.Write("stst" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "WORD"

                Case LER_MINIMO_VALOR_AJUSTE
                    'stma
                    objPorta.Write("stma" & Chr(10))
                    'Bytes que deverão vir na resposta.
                    intNumeroBytes = 8
                    'Tipo de dados 
                    strTipoDado = "FLOAT"


                    ''--------------------------------------------------------------------------------------------------
                    ''Comandos de Escrita
                    ''--------------------------------------------------------------------------------------------------
                Case SET_TARE_INSTRUMENTO
                    'tare
                    objPorta.Write("tare" & strPlaca & strValorCanalAD & Chr(10))
                    strConfereEscrita = "tare"

                Case SET_OFFSET_INTERNO_AD
                    'szer
                    'objPorta.Write("szer" & strPlaca & strValorCanalAD & "," & strValor_Offset_Interno_Arduino_Delta & Chr(10))
                    objPorta.Write("szer" & strPlaca & strValorCanalAD & strValorOffsetInterno & Chr(10))
                    strConfereEscrita = "szer"

                Case SET_ESCALA_INTERNA_AD
                    'sful
                    'objPorta.Write("sful" & strPlaca & strValorCanalAD & "," & strValor_Escala_Interna_Arduino_Delta & Chr(10))
                    objPorta.Write("sful" & strPlaca & strValorCanalAD & strValorEscalaInterna & Chr(10))
                    strConfereEscrita = "sful"

                Case SET_ESCALA_CALIBRACAO_USUARIO
                    'sesc
                    objPorta.Write("sesc" & strPlaca & strValorCanalAD & strValorConstanteUsuario & Chr(10))
                    strConfereEscrita = "sesc"

                Case SET_OFFSET_CALIBRACAO_USUARIO
                    'star
                    'objPorta.Write("star" & strPlaca & strValorCanalAD & "," & strValor_Offset_Calibracao_Usuario_Arduino & Chr(10))
                    objPorta.Write("star" & strPlaca & strValorCanalAD & strValorOffsetUsuario & Chr(10))
                    strConfereEscrita = "star"

                Case SET_AUTO_ZERO_INTERNO_AD
                    'zero
                    objPorta.Write("zero" & strPlaca & strValorCanalAD & Chr(10))
                    strConfereEscrita = "zero"

                Case SET_AUTO_FULL_INTERNO_AD
                    'full
                    objPorta.Write("full" & strPlaca & strValorCanalAD & Chr(10))
                    strConfereEscrita = "full"

                Case SET_INIT_AD
                    'init - ajuste automático interno do AD Carga
                    objPorta.Write("init" & strPlaca & strValorCanalAD & Chr(10))
                    strConfereEscrita = "init"

                Case SET_CARGA_MAX
                    'smax
                    objPorta.Write("smax" & strValorFundoEscalaCarga & Chr(10))
                    strConfereEscrita = "smax"

                Case SET_PARAR_MOTOR
                    objPorta.Write("stop" & "0" & Chr(10))
                    strConfereEscrita = "stop"

                Case SET_REPOSICIONAR
                    objPorta.Write("srep" & Chr(10))
                    strConfereEscrita = "srep"

                Case RESET_REPOSICIONAR
                    objPorta.Write("rrep" & Chr(10))
                    strConfereEscrita = "rrep"

                Case SET_VELOCIDADE_REPOSICIONAR
                    objPorta.Write("svel" & "-5000" & Chr(10))
                    strConfereEscrita = "svel"

                Case SET_ZERAR_PICO_CARGA_PROCESSADOR
                    'zpic
                    objPorta.Write("zpic" & Chr(10))
                    strConfereEscrita = "zpic"

                Case SET_HABILITA_CANAL_AD
                    'habcX
                    objPorta.Write("habc" & strPlaca & strValorCanalAD & Chr(10))
                    strConfereEscrita = "habc"

                Case SET_DESABILITA_CANAL_AD
                    'dabcX
                    objPorta.Write("dabc" & strPlaca & strValorCanalAD & Chr(10))
                    strConfereEscrita = "dabc"

                Case SET_DESABILITA_TODOS_CANAIS_PROCESSADOR_AD
                    'dabcX
                    objPorta.Write("daba" & strPlaca & Chr(10))
                    strConfereEscrita = "daba"

                Case SET_MODO_OPERACAO_MANUAL
                    'loca
                    objPorta.Write("loca" & Chr(10))
                    strConfereEscrita = "loca"

                Case SET_MODO_OPERACAO_REMOTO
                    'remo
                    objPorta.Write("remo" & Chr(10))
                    strConfereEscrita = "remo"

                Case SET_LIGAR_DEBUG_PROCESSADOR
                    'dbon
                    objPorta.Write("dbon" & Chr(10))
                    strConfereEscrita = "dbon"

                Case SET_DESLIGAR_DEBUG_PROCESSADOR
                    'dbof
                    objPorta.Write("dbof" & Chr(10))
                    strConfereEscrita = "dbof"

                Case SET_DESLIGAR_READING_ON
                    'rdof
                    objPorta.Write("rdof" & Chr(10))
                    strConfereEscrita = "rdof"

                Case SET_RESET_PARAMETRIZACAO_PROCESSADOR
                    'rpar 
                    objPorta.Write("rpar" & Chr(10))
                    strConfereEscrita = "rpar"

                Case SET_VELOCIDADE_MOTOR
                    'svel
                    objPorta.Write("svel" & strVelocidadeMotor & Chr(10))
                    strConfereEscrita = "svel"

                Case SET_TESTE_AUTOMATICO
                    'stes
                    objPorta.Write("stes" & Chr(10))
                    strConfereEscrita = "stes"

                Case RESET_TESTE_AUTOMATICO
                    'rtes
                    objPorta.Write("rtes" & Chr(10))
                    strConfereEscrita = "rtes"

                Case SET_THRESHOLD_CARGA
                    'sthc
                    objPorta.Write("sthc" & strValorTheresholdCarga & Chr(10))
                    strConfereEscrita = "sthc"

                Case SET_THRESHOLD_LVDT
                    'sthl
                    objPorta.Write("sthl" & strValorTheresholdLvdt & Chr(10))
                    strConfereEscrita = "sthl"

                Case SET_DESTINO_CARGA
                    'sdtc
                    objPorta.Write("sdtc" & strValorDestinoCarga & Chr(10))
                    strConfereEscrita = "sdtc"

                Case SET_TAXA_CARGA
                    'stxc
                    objPorta.Write("stxc" & strValorTaxaCarga & Chr(10))
                    strConfereEscrita = "stxc"

                Case SET_CONTROLE_CARGA
                    'ctrc
                    objPorta.Write("ctrc" & Chr(10))
                    strConfereEscrita = "ctrc"

                Case SET_DESTINO_DESLOCAMENTO
                    'sdtc
                    objPorta.Write("sdtd" & strValorDestinoDeslocamento & Chr(10))
                    strConfereEscrita = "sdtd"

                Case SET_TAXA_DESLOCAMENTO
                    'stxc
                    objPorta.Write("stxd" & strValorTaxaDeslocamento & Chr(10))
                    strConfereEscrita = "stxd"

                Case SET_CONTROLE_DESLOCAMENTO
                    'ctrd
                    objPorta.Write("ctrd" & Chr(10))
                    strConfereEscrita = "ctrd"

                Case SET_ESTABILIZAR_CONTROLE_PROCESSADOR
                    'esta
                    objPorta.Write("esta" & Chr(10))
                    strConfereEscrita = "esta"

                Case SET_CONSTANTE_KP_DESLOCAMENTO_PID
                    'stkp
                    objPorta.Write("stkp" & strValorKP & Chr(10))
                    strConfereEscrita = "stkp"

                Case SET_CONSTANTE_KP_INCREMENTO_PID
                    'stkp
                    objPorta.Write("stkc" & strValorKP & Chr(10))
                    strConfereEscrita = "stkc"

                Case SET_BOUNCE_BREAK
                    'stbb
                    objPorta.Write("stbb" & strValorBB & Chr(10))
                    strConfereEscrita = "stbb"

                Case SET_ERROR_ADJUST
                    'staj
                    objPorta.Write("staj" & strValorErrorAdjust & Chr(10))
                    strConfereEscrita = "staj"

                Case SET_SAMPLE_TIME
                    'stst
                    objPorta.Write("stst" & strValorSampleTime & Chr(10))
                    strConfereEscrita = "stst"

                Case SET_MINIMO_VALOR_AJUSTE
                    'stma
                    objPorta.Write("stma" & strValorMinimoAjuste & Chr(10))
                    strConfereEscrita = "stma"

            End Select

            'Para os comandos de Escrita
            If strConfereEscrita <> "" Then intNumeroBytes = 8 'pois falta os parêntesis

        Catch ex As Exception

            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
            If blnJaFechouPorta = True Then Exit Sub

            'Mensagem de erro
            strErro_Porta_Comunicacao = ex.Message

            If (objPorta.IsOpen = False) Or (Err.Number = 57) Then
                intErroNumber = Err.Number
                Call usrDiversos.FinalizarComunicacao()
                Exit Sub
            End If

        End Try

    End Sub

#End Region

#Region "COMUNICAR (RESPOSTA)"

    Public Sub RespostaArduinoByte(ByRef objPorta As SerialPort, ByVal intId As Integer, ByVal strTipo As String)

        Dim intRespostaBruta As Integer
        Dim dblLastTime As Double
        Dim strRespostaConfereTratada As String

        Try
            'Variável com status inicial para assinalar erro de comunicação
            blnErroRespostaArduinoByte = True
            blnErroRespostaConferencia = True
            blnErroLeituraLVDT = True
            blnErroLeituraStatusMaquina = True
            blnErroLeituraCarga = True
            blnErroLeituraConstantesAD = True
            blnErroRespostaFloatNumber = True
            blnErroRespostasMultiplas = True
            blnErroRespostaByteUnico = True
            blnErroRespostaWordNumber = True

            'Se a quantidade de bytes recebidos como referência para o vetor não for maior que 0 (zero) eu cancelo saindo da Subrotina
            If intNumeroBytes = 0 Then Exit Sub

            'Redimensiono o tamanho do vetor de acordo com o comando que foi enviado
            ReDim bytVetor(intNumeroBytes - 1)

            'Pega o tempo atual para verificar tempo gasto dentro do while a seguir
            dblLastTime = timeGetTime

            'Enquanto não acumular 24 bytes no buffer AND a diferença de tempo não superar 200ms eu aguardo o buffer encher
            While (objPorta.BytesToRead < intNumeroBytes) And (timeGetTime - dblLastTime < 300)
                'Aguardando buffer encher 
                'Debug.Print(timeGetTime - dblLastTime)
            End While

            '--------------------------------------------------------------------------------------------------------
            '1º Critério - Se vier sem dados - o comando falhou ou não teve tempo da resposta chegar
            '--------------------------------------------------------------------------------------------------------
            If objPorta.BytesToRead = 0 Then
                'Variáveis para análise estatística
                intErroLeituraResposta += 1
                intContadorErrosGeral += 1
                intContadorErrosSemDados += 1
                blnComunicandoSucesso = False

                'Se o número de tentativas for inferior a 2, envia o comando novamente
                If intErroLeituraRespotaByte < 2 Then
                    intErroLeituraRespotaByte = 1 + intErroLeituraRespotaByte
                    If strTipo = "Leitura" Then
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Leitura")
                    Else
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Escrita")
                    End If
                Else
                    'Tentou 3 vezes o envio do comando e não obteve resposta
                    blnErroRespostaArduinoByte = True
                    blnErroRespostaConferencia = True
                End If

                'Sai da subrotina
                Exit Sub

                '-----------------------------------------------------------------------------------------------------------
                '2º Critério - Caso tenha saído do while e não tenha acumulado todos os bytes necessários, saio da subrotina
                '-----------------------------------------------------------------------------------------------------------
            ElseIf (objPorta.BytesToRead < intNumeroBytes) Then
                'Variáveis para análise estatística
                intErroLeituraResposta += 1
                intContadorErrosGeral += 1
                intContadorErrosMenorQEsperado += 1
                blnComunicandoSucesso = False

                'Limpa os dados exitentes como lixo
                strLixo = objPorta.ReadExisting()

                'Se o número de tentativas ainda for inferior a 2, envia o comando novamente
                If intErroLeituraRespotaByte < 2 Then
                    intErroLeituraRespotaByte = 1 + intErroLeituraRespotaByte
                    If strTipo = "Leitura" Then
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Leitura")
                    Else
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Escrita")
                    End If
                Else
                    'Tentou 3 vezes o envio do comando e não obteve resposta
                    blnErroRespostaArduinoByte = True
                    blnErroRespostaConferencia = True
                End If

                'Sai da subrotina
                Exit Sub

                '-----------------------------------------------------------------------------------------------------------
                '3º Critério - Caso tenha vindo mais dados do que o esperado
                '-----------------------------------------------------------------------------------------------------------
            ElseIf (objPorta.BytesToRead > intNumeroBytes) Then
                'Variáveis para análise estatística
                intErroLeituraResposta += 1
                intContadorErrosGeral += 1
                intContadorErrosMaiorQEsperado += 1
                blnComunicandoSucesso = False
                'Limpa os dados exitentes como lixo
                strLixo = objPorta.ReadExisting()

                'Se o número de tentativas ainda for inferior a 2, envia o comando novamente
                If intErroLeituraRespotaByte < 2 Then
                    intErroLeituraRespotaByte = 1 + intErroLeituraRespotaByte
                    If strTipo = "Leitura" Then
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Leitura")
                    Else
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Escrita")
                    End If
                Else
                    'Tentou 3 vezes o envio do comando e não obteve resposta
                    blnErroRespostaArduinoByte = True
                    blnErroRespostaConferencia = True
                End If

                'Sai da subrotina
                Exit Sub

            End If

            '-----------------------------------------------------------------------------------------
            'REALIZA A LEITURAS DOS BYTES
            '-----------------------------------------------------------------------------------------
            'Recebe a resposta bruta em bytes
            intRespostaBruta = objPorta.Read(bytVetor, 0, intNumeroBytes)

            '-----------------------------------------------------------------------------------------------
            '4º Critério - Verifica se o primeiro byte é um abre parêntesis "(" e se o último é Chr(10)/vblf
            '-----------------------------------------------------------------------------------------------
            If (Not (Chr(bytVetor(0))) = "(" Or Not Chr(bytVetor(intNumeroBytes - 1)) = vbLf) And strTipo = "Leitura" Then
                intErroLeituraResposta += 1
                intContadorErrosGeral += 1
                intContadorErrosLFCR += 1
                blnComunicandoSucesso = False
                'Limpa os dados exitentes como lixo
                strLixo = objPorta.ReadExisting()

                'Se o número de tentativas ainda for inferior a 2, envia o comando novamente
                If intErroLeituraRespotaByte < 2 Then
                    intErroLeituraRespotaByte = 1 + intErroLeituraRespotaByte
                    If strTipo = "Leitura" Then
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Leitura")
                    Else
                        Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Escrita")
                    End If
                Else
                    'Tentou 3 vezes o envio do comando e não obteve resposta
                    blnErroRespostaArduinoByte = True
                    blnErroRespostaConferencia = True
                End If

                'Sai da subrotina
                Exit Sub
            End If


            '-----------------------------------------------------------------------------------------
            'SE CHEGOU ATÉ AQUI NÃO HOUVE PROBLEMA
            '-----------------------------------------------------------------------------------------
            'Comunicação sem erro, zera a variável
            intErroLeituraRespotaByte = 0

            If strTipo = "Leitura" Then

                'Não houve erro de leitura geral do comando read até aqui
                blnErroRespostaArduinoByte = False
                'Sinaliza comunicação com sucesso
                blnComunicandoSucesso = True

                'DIRECIONA PARA A FILTRAGEM DOS VALORES DESEJADOS
                Select Case intId
                    Case LER_STATUS_MAQUINA '5 bytes
                        Call LeituraStatusMaquina()
                    Case LER_STATUS_AD
                        Call LeituraStatusAD()
                    Case LER_AD '8 bytes
                        Call LeituraRead()
                    Case LER_ESCALA_INTERNA_AD, LER_OFFSET_INTERNO_AD, LER_ESCALA_CALIBRACAO_USUARIO, LER_OFFSET_CALIBRACAO_USUARIO '8 bytes
                        Call LeituraConstantesADs()
                    Case LER_MULTIPLAS_RESPOSTAS
                        Call LeituraMultiplasRespostas()
                    Case LER_TAXA_CARGA, LER_DESTINO_CARGA, LER_CARGA_MAX, LER_THRESHOLD_CARGA, LER_THRESHOLD_LVDT, LER_KP_2, LER_ERROR_ADJUST, LER_MINIMO_VALOR_AJUSTE, LER_TAXA_DESLOCAMENTO, LER_DESTINO_DESLOCAMENTO, LER_CONSTANTE_KP_INCREMENTO_PID, LER_CONSTANTE_KP_DESLOCAMENTO_PID
                        Call LeituraFloatNumber()
                    Case LER_BOUNCE_BREAK, LER_SAMPLE_TIME
                        Call LeituraWordNumber()
                    Case LER_CANAIS_HABILITADOS_AD, LER_NUMERO_PLACAS_AD_INICIALIZADAS
                        Call LeituraByteUnico()
                End Select

            Else 'strTipo = "Escrita

                'Pega a posição do proximo caractere ':'. Será pego o primeiro que estiver após a posição 3.
                strRespostaConfereTratada = Chr(bytVetor(1)) & Chr(bytVetor(2)) & Chr(bytVetor(3)) & Chr(bytVetor(4))
                'strRespostaConfereTratada = Chr(bytVetor(0)) & Chr(bytVetor(1)) & Chr(bytVetor(2)) & Chr(bytVetor(3))

                If strRespostaConfereTratada = strConfereEscrita Then
                    blnErroRespostaConferencia = False
                    'Sinaliza comunicação com sucesso
                    blnComunicandoSucesso = True
                Else
                    'Teste
                    Exit Sub
                End If

            End If

        Catch ex As Exception
            'Mensagem de erro:
            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
            If blnJaFechouPorta = True Then Exit Sub

            'Mensagem de erro
            strErro_Porta_Comunicacao = ex.Message

            If (objPorta.IsOpen = False) Or (Err.Number = 57) Then
                intErroNumber = Err.Number
                Call usrDiversos.FinalizarComunicacao()
                Exit Sub
            End If

        End Try

    End Sub

    Public Sub RespostaArduinoString(ByRef objPorta As SerialPort, ByVal intId As Integer)

        Dim intTamanho As Integer

        Try

            dblValorFloatStringArduino = 0

            'Variável para assinalar erro de comunicação
            blnErroRespostaArduinoString = True
            blnErroLeituraStatusHabilitacaoCanaisAD = True

            'Se o buffer ainda não completou o mínimo de informações "(X)__" = 5 bytes, então deverá esperar mais um pouco
            If objPorta.BytesToRead < 5 Then
                System.Threading.Thread.Sleep(45)
            End If

            'Lê a resposta do arduino referente as entradas digitais
            strLeitura_Bruta = objPorta.ReadExisting()

            'Pega a quantidade de caracteres da leitura
            intTamanho = CInt(strLeitura_Bruta.Length)

            'Se o tamanho for menor que 3, exemplo: '()' ou ""; ou se o tamanho maior que 14, exemplo: '(-1000000000)'
            'If (intTamanho < 3) Or (intTamanho > 16) Then
            If (strLeitura_Bruta.Length < 3) Or (strLeitura_Bruta.Length > 16) Then
                If intErroLeituraRespotaString > 1 Then
                    intErroLeituraRespotaString = 0
                    blnErroRespostaArduinoString = True
                    Exit Sub
                Else
                    'Realiza nova tentativa de comunicação com o Arduino, caso a resposta não seja satisfatória
                    intErroLeituraRespotaString = 1 + intErroLeituraRespotaString
                    Call usrArduino_AD7192.Comunicar_Arduino(objPorta, intId, "Leitura")
                End If
                Exit Sub
            End If

            'Limpa quantidade
            intErroLeituraRespotaString = 0

            'Verifica se a resposta recebida possui abre parêntesis logo após um fechamento de parêntesis:')(' 
            If strLeitura_Bruta.Contains(")" & Chr(13) & Chr(10) & "(") Then
                Exit Sub
            End If

            'Verifica se a string recebida inicia com a abertura de parêtesis '('
            If Not strLeitura_Bruta.StartsWith("(") Then
                Exit Sub
            End If

            'Verifica se a string recebida termina com o fechamento de parêntesis ')'
            'If Not strLeitura_Bruta.EndsWith(")") Then Exit Sub
            If Not strLeitura_Bruta.EndsWith(Chr(10)) Then
                Exit Sub
            End If

            'Faz o filtro para retirar os parêntesis
            strLeitura_Liquida = strLeitura_Bruta.Substring(1, intTamanho - 4)

            If strTipoDado = "FLOAT" Then

                'Verifica se a parte líquida da leitura é numérica
                If IsNumeric(strLeitura_Liquida) Then
                    'Converte a string em double
                    dblValorFloatStringArduino = CDbl(strLeitura_Liquida)

                    dblValorFloatStringArduino = dblValorFloatStringArduino / 100

                    'Se o pedido de leitura for para constante de escala de calibração
                    If (intId = LER_ESCALA_CALIBRACAO_USUARIO) Or (intId = LER_ESCALA_CALIBRACAO_USUARIO) Then
                        'Vem com 3 casas decimais a mais depois da vírgula
                        dblValorFloatStringArduino = dblValorFloatStringArduino / 1000
                    End If
                End If

            Else 'Tipo LONG

                'Verifica se a parte líquida da leitura é numérica
                If IsNumeric(strLeitura_Liquida) Then
                    'Converte a string em double
                    'dblValor_Long_String_Arduino = CDbl(strLeitura_Liquida)
                    lngValorLongStringArduino = CLng(strLeitura_Liquida)
                End If

            End If

            'Se a varredura do código chegou até aqui, não houve erro de comunicação
            blnErroRespostaArduinoString = False

        Catch ex As Exception
            'Mensagem de erro:
            'Condição para evitar erro de porta COM ao fechar/desconectar manualmente, pois o ciclo de scan do ‘timer’ pode não ter terminado ainda e surgir mais de um msgbox de alerta.
            If blnJaFechouPorta = True Then Exit Sub

            'Mensagem de erro
            strErro_Porta_Comunicacao = ex.Message

            If (objPorta.IsOpen = False) Or (Err.Number = 57) Then
                intErroNumber = Err.Number
                Call usrDiversos.FinalizarComunicacao()
                Exit Sub
            End If
        End Try

    End Sub

    Public Sub LeituraFloatNumber()

        Dim FloatByte(3) As Byte
        Dim sngTemp As Single
        Dim lngTemp As Long

        Try

            'Filtra a substring do valor da carga
            FloatByte(0) = bytVetor(1)
            FloatByte(1) = bytVetor(2)
            FloatByte(2) = bytVetor(3)
            FloatByte(3) = bytVetor(4)

            sngTemp = BitConverter.ToSingle(FloatByte, 0)
            sngValorFloatRespostaByte = sngTemp

            'Se a varredura do código chegou até aqui, não houve erro de comunicação
            blnErroRespostaFloatNumber = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LeituraConstantesADs()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraWordNumber()

        Dim LeituraByte() As Byte
        Dim intTemp As Long

        Try

            ReDim LeituraByte(1)
            LeituraByte(0) = bytVetor(1)
            LeituraByte(1) = bytVetor(2)
            intTemp = BitConverter.ToInt16(LeituraByte, 0)
            intValorWordRespostaByte = intTemp

            'Se a varredura do código chegou até aqui, não houve erro de comunicação
            blnErroRespostaWordNumber = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LeituraWordNumber()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraByteUnico()

        Try

            'Filtra a substring do valor da carga
            intValorByteUnico = Val(bytVetor(1))

            'Se a varredura do código chegou até aqui, não houve erro de comunicação
            blnErroRespostaByteUnico = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LeituraByteUnico()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraConstantesADs()

        Dim ConstantesADByte(3) As Byte
        Dim sngTemp As Single
        Dim lngTemp As Long

        Try

            '----------------------------------------------------------------------------------------------
            'PARTE 2 - FILTRAR A SUBSTRING DO VALOR DO LVDT
            '----------------------------------------------------------------------------------------------
            'Filtra a substring do valor da carga
            ConstantesADByte(0) = bytVetor(1)
            ConstantesADByte(1) = bytVetor(2)
            ConstantesADByte(2) = bytVetor(3)
            ConstantesADByte(3) = bytVetor(4)

            If strTipoDado = "FLOAT" Then
                sngTemp = BitConverter.ToSingle(ConstantesADByte, 0)
                sngValorFloatRespostaByte = sngTemp
            Else
                lngTemp = BitConverter.ToInt32(ConstantesADByte, 0)
                lngValorLongRespostaByte = lngTemp
            End If

            'Se a varredura do código chegou até aqui, não houve erro de comunicação
            blnErroLeituraConstantesAD = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LeituraConstantesADs()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraMultiplasRespostas()

        Dim bytSetpoint(3), bytOutputMotor(3), bytCarga(3), bytDesloc(3), bytStatusInicializacaoAD0(0), bytStatusInicializacaoAD1(0), bytCanaisHabilitadosAD0(0), bytCanaisHabilitadosAD1(0) As Byte

        Try
            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DO STATUS INPUTS
            '----------------------------------------------------------------------------------------------
            strStatusInputs = Val(bytVetor(1)) & ":" & Val(bytVetor(2))

            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DO SETPOINT CARGA
            '----------------------------------------------------------------------------------------------
            'Filtra a substring do valor da carga
            bytSetpoint(0) = bytVetor(3)
            bytSetpoint(1) = bytVetor(4)
            bytSetpoint(2) = bytVetor(5)
            bytSetpoint(3) = bytVetor(6)
            sngSetpointCarga = BitConverter.ToSingle(bytSetpoint, 0)

            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DO OUTPUT MOTOR
            '----------------------------------------------------------------------------------------------
            'Filtra a substring do valor da carga
            bytOutputMotor(0) = bytVetor(7)
            bytOutputMotor(1) = bytVetor(8)
            bytOutputMotor(2) = bytVetor(9)
            bytOutputMotor(3) = bytVetor(10)
            sngOutputMotor = BitConverter.ToSingle(bytOutputMotor, 0)

            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DO STATUS DE INICIALIZAÇÃO DO AD0
            '----------------------------------------------------------------------------------------------
            intStatusInicializacaoAD0 = Val(bytVetor(11))

            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DOS CANAIS HABILITADOS AD0
            '----------------------------------------------------------------------------------------------
            intCanaisHabilitadosAD0 = Val(bytVetor(12))

            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DA CARGA
            '----------------------------------------------------------------------------------------------
            'Filtra a substring do valor da carga
            bytCarga(0) = bytVetor(13)
            bytCarga(1) = bytVetor(14)
            bytCarga(2) = bytVetor(15)
            bytCarga(3) = bytVetor(16)
            sngLeituraCarga = BitConverter.ToSingle(bytCarga, 0)

            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DO STATUS DE INICIALIZAÇÃO DO AD1
            '----------------------------------------------------------------------------------------------
            intStatusInicializacaoAD1 = Val(bytVetor(17))

            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DOS CANAIS HABILITADOS AD1
            '----------------------------------------------------------------------------------------------
            intCanaisHabilitadosAD1 = Val(bytVetor(18))

            If intNumeroBytesDinamico > 22 Then
                '----------------------------------------------------------------------------------------------
                'FILTRAR A SUBSTRING DO VALOR DO LVDT
                '----------------------------------------------------------------------------------------------
                'Filtra a substring do valor da carga
                bytDesloc(0) = bytVetor(19)
                bytDesloc(1) = bytVetor(20)
                bytDesloc(2) = bytVetor(21)
                bytDesloc(3) = bytVetor(22)
                sngLeituraDeslocamento = BitConverter.ToSingle(bytDesloc, 0)
            End If

            'Chegou até aqui teve sucesso
            blnErroRespostasMultiplas = False

        Catch ex As Exception

            'Se deu algum erro
            blnErroRespostasMultiplas = True

            'Mensagem de erro
            MsgBox("LeituraMultiplasRespostas()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraRead()

        Dim sngTemp As Single
        Dim LeituraByte(3) As Byte

        Try
            '----------------------------------------------------------------------------------------------
            'FILTRAR A SUBSTRING DO VALOR DA CARGA
            '----------------------------------------------------------------------------------------------
            'Filtra a substring do valor da carga
            LeituraByte(0) = bytVetor(1)
            LeituraByte(1) = bytVetor(2)
            LeituraByte(2) = bytVetor(3)
            LeituraByte(3) = bytVetor(4)
            sngTemp = BitConverter.ToSingle(LeituraByte, 0)

            'Valor líquido da Carga em variável single
            If strPlaca = "0" Then '"a"
                sngValorCargaRespostaByte = sngTemp
                'Não houve erro de leitura da Carga até aqui
                blnErroLeituraCarga = False
            Else
                'Valor líquido da Carga em variável single
                sngValorLVDTRespostaByte = sngTemp
                'Se a varredura do código chegou até aqui, não houve erro de comunicação
                blnErroLeituraLVDT = False
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LeituraRead()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraStatusAD()
        'Apesar de ser um comando tipo String, nunca virá mais do que 1 byte de resposta líquida, apenas 0 ou 1.

        Dim strStatusAD As String
        Try

            strStatusAD = Chr(bytVetor(1))

            If strPlaca = 0 Then
                If strStatusAD = "1" Then
                    blnErroLeituraStatusAD_P0 = False
                Else
                    blnErroLeituraStatusAD_P0 = True
                End If
            Else
                If strStatusAD = "1" Then
                    blnErroLeituraStatusAD_P1 = False
                Else
                    blnErroLeituraStatusAD_P1 = True
                End If
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LeituraStatusAD()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub LeituraStatusMaquina()

        Dim dblStatus1_P1 As Double
        Dim dblStatus1_P2 As Double

        Try
            '----------------------------------------------------------------------------------------------
            'PARTE 1 - FILTRAR A SUBSTRING DO STATUS 1
            '----------------------------------------------------------------------------------------------
            'Pega a posição do proximo caractere ':'. Será pego o primeiro que estiver após a posição 3.
            dblStatus1_P1 = Val(bytVetor(2))
            dblStatus1_P2 = Val(bytVetor(1))
            Call usrComunicacao.Transformar_Bit_Status1(dblStatus1_P1, dblStatus1_P2)
            'Não houve erro de leitura do Status até aqui
            blnErroLeituraStatusMaquina = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LeituraStatusMaquina()" & Chr(13) & ex.Message)
        End Try

    End Sub

#End Region

End Class
