Option Strict Off
Option Explicit On

Module mdlComandos
    'Contenco Industria e Comercio Ltda.

    'Comandos Gerais Arduino/ESP-----------------------------------------------------------------------
    Public Const LER_VERSAO_PROCESSADOR As Integer = 1 'rver
    Public Const SET_LIGAR_DEBUG_PROCESSADOR As Integer = 2 'dbon
    Public Const SET_DESLIGAR_DEBUG_PROCESSADOR As Integer = 3 'dbof
    Public Const SET_LIGAR_READING_ON As Integer = 4 'rdon
    Public Const SET_DESLIGAR_READING_ON As Integer = 5 'rdof
    Public Const SET_RESET_PROCESSADOR As Integer = 6 'rset
    Public Const SET_RESET_CALIBRACAO_PROCESSADOR As Integer = 7 'rcal
    Public Const SET_RESET_PARAMETRIZACAO_PROCESSADOR As Integer = 8 'rpar
    Public Const SET_ENVIAR_PROCESSADOR_ASCII As Integer = 9 'slav
    Public Const SET_ENVIAR_PROCESSADOR_RTU As Integer = 10 'send
    Public Const LER_CONFIGURACOES As Integer = 11 'conf
    Public Const LER_CANAIS_HABILITADOS_AD As Integer = 12 'rcha
    Public Const LER_OFFSET_INTERNO_AD As Integer = 13 'rzer
    Public Const SET_OFFSET_INTERNO_AD As Integer = 14 'szer
    Public Const LER_ESCALA_INTERNA_AD As Integer = 15 'rful
    Public Const SET_ESCALA_INTERNA_AD As Integer = 16 'sful
    Public Const LER_OFFSET_CALIBRACAO_USUARIO As Integer = 17 'rtar
    Public Const SET_OFFSET_CALIBRACAO_USUARIO As Integer = 18 'star
    Public Const LER_ESCALA_CALIBRACAO_USUARIO As Integer = 19 'resc
    Public Const SET_ESCALA_CALIBRACAO_USUARIO As Integer = 20 'sesc
    Public Const SET_AUTO_ZERO_INTERNO_AD As Integer = 21 'zero
    Public Const SET_AUTO_FULL_INTERNO_AD As Integer = 22 'full
    Public Const SET_HABILITA_CANAL_AD As Integer = 23 'habc
    Public Const SET_DESABILITA_CANAL_AD As Integer = 24 'dabc
    Public Const SET_TARE_INSTRUMENTO As Integer = 25 'tare
    Public Const SET_INIT_AD As Integer = 26 'init
    Public Const LER_STATUS_MAQUINA As Integer = 27 'rdst
    Public Const LER_AD As Integer = 28 'read
    Public Const SET_DESABILITA_TODOS_CANAIS_PROCESSADOR_AD As Integer = 29 'daba
    Public Const SET_RESET_AD As Integer = 30 'rsta
    Public Const SET_POLARIDADE_AD As Integer = 31 'pola
    Public Const LER_ID_CARGA_DISPLAY As Integer = 32 'ridc
    Public Const SET_ID_CARGA_DISPLAY As Integer = 33 'sidc
    Public Const SET_GANHO_AD As Integer = 34 'gain
    Public Const LER_MEDIA_AD As Integer = 35 'ravr
    Public Const SET_MEDIA_AD As Integer = 36 'savr
    Public Const LER_INFORMACAO_PROCESSADOR As Integer = 37 'info
    Public Const LER_CONTAGEM_BOOT_PROCESSADOR As Integer = 38 'rcnt
    Public Const SET_CONTAGEM_BOOT_PROCESSADOR As Integer = 39 'scnt
    Public Const LER_PARAMETROS_AD As Integer = 40 'rcon
    Public Const LER_NUMERO_PLACAS_AD_INICIALIZADAS As Integer = 41 'rnad
    Public Const SET_CARGA_MAX As Integer = 42 'smax
    Public Const LER_CARGA_MAX As Integer = 43 'rmax 
    'Comandos Gerais Arduino/ESP-----------------------------------------------------------------------

    'Comandos Específicos Wi-fi------------------------------------------------------------------------
    Public Const SET_LIGAR_ACCESSPOINT As Integer = 101 'apon
    Public Const SET_DESLIGAR_ACCESSPOINT As Integer = 102 'apof
    Public Const SET_NOME_REDE_WIFI As Integer = 103 'ssid 
    Public Const LER_NOME_REDE_WIFI As Integer = 104 'rsid 
    Public Const LER_PASSWORD_REDE_WIFI As Integer = 105 'rpwd
    Public Const SET_PASSWORD_REDE_WIFI As Integer = 106 'spwd
    Public Const SET_ECHO_OFF_WIFI As Integer = 107 'ecof
    Public Const SET_ECHO_ON_WIFI As Integer = 108 'econ
    Public Const SET_TCP_ENABLED_WIFI As Integer = 109 'etcp
    Public Const SET_TCP_DISABLED_WIFI As Integer = 110 'dtcp
    Public Const SET_TCP_KICK_WIFI As Integer = 111 'ktcp
    Public Const SET_IP_WIFI As Integer = 112 'stip
    Public Const LER_IP_WIFI As Integer = 113 'rdip
    Public Const SET_GATEWAY_WIFI As Integer = 114 'stgw
    Public Const LER_GATEWAY_WIFI As Integer = 115 'rdgw
    Public Const SET_SUBNETWORK_WIFI As Integer = 116 'stsn
    Public Const LER_SUBNETWORK_WIFI As Integer = 117 'rdsn
    Public Const SET_PORTA_TCP_WIFI As Integer = 118 'sprt
    Public Const LER_PORTA_TCP_WIFI As Integer = 119 'rprt
    Public Const SET_CANAL_WIFI As Integer = 120 'schn
    Public Const LER_CANAL_WIFI As Integer = 121 'rchn
    Public Const SET_HIDE_REDE_WIFI As Integer = 122 'shid
    Public Const LER_HIDE_REDE_WIFI As Integer = 123 'rhid
    Public Const SET_KICK_ALIVE_TCP_WIFI As Integer = 124 'kalv
    Public Const SET_DISABLED_WIFI As Integer = 125 'dwif
    Public Const SET_ENABLED_WIFI As Integer = 126 'ewif
    Public Const LER_KICK_ALIVE_TCP_WIFI As Integer = 127 'kalv também, mas sem número na frente
    'Comandos Específicos Wi-fi------------------------------------------------------------------------


    'Comandos Específicos Servomotor-------------------------------------------------------------------
    Public Const SET_PARAR_MOTOR As Integer = 201 'stop
    Public Const LER_VELOCIDADE_MOTOR As Integer = 202 'rvel
    Public Const SET_VELOCIDADE_MOTOR As Integer = 203 'svel
    Public Const SET_POSICAO_MODO_DESLOCAMENTO_SERVO As Integer = 204 'spos
    Public Const LER_STATUS_ESTABILIZANDO_PARANDO_PROCESSADOR As Integer = 205 'rdes
    Public Const LER_ENCODER_SERVO As Integer = 206 'renc - leitura vem embutida no comando 'rdst'
    Public Const SET_ZERAR_ENCODER_SERVO As Integer = 207 'zenc
    Public Const SET_MODO_OPERACAO_MANUAL As Integer = 208 'loca
    Public Const SET_MODO_OPERACAO_REMOTO As Integer = 209 'remo
    Public Const SET_CONSTANTE_KP_PID As Integer = 210 'stkp
    Public Const LER_CONSTANTE_KP_PID As Integer = 212 'rdkp
    Public Const SET_CONSTANTE_KI_PID As Integer = 213 'stki
    Public Const LER_CONSTANTE_KI_PID As Integer = 214 'rdki
    Public Const SET_CONSTANTE_KD_PID As Integer = 215 'stkd
    Public Const LER_CONSTANTE_KD_PID As Integer = 216 'rdkd
    Public Const SET_MODO_OPERACAO_HCAL_PROCESSADOR_SERVO As Integer = 217 'hcal
    Public Const LER_HOLDING_REGISTER_SERVO As Integer = 218 'rdhr
    Public Const SET_HOLDING_REGISTER_SERVO As Integer = 219 'sthr
    Public Const SET_RESET_SERVO As Integer = 220 'rstd
    Public Const SET_BYPASS_DIGITAL_SERVO As Integer = 221 'rstd
    'Comandos Específicos Servomotor-------------------------------------------------------------------

    'Comandos Específicos Pressurizador/Aplicador------------------------------------------------------
    Public Const LER_PAGINA_IHM_APLICADOR As Integer = 301 'rpag
    Public Const SET_PAGINA_IHM_APLICADOR As Integer = 302 'spag
    Public Const LER_DESTINO_PRESSAO As Integer = 303 'rdtp
    Public Const SET_DESTINO_PRESSAO As Integer = 304 'sdtp
    Public Const LER_VOLUME_APLICADOR As Integer = 305 'rvol
    Public Const SET_TARA_VOLUME_APLICADOR As Integer = 306 'tvol
    Public Const SET_ZERAR_TARA_VOLUME_APLICADOR As Integer = 307 'zvol
    Public Const LER_DESTINO_VAZAO As Integer = 308 'rdtv
    Public Const SET_DESTINO_VAZAO As Integer = 309 'sdtv
    Public Const LER_MAXIMA_VELOCIDADE_APLICADOR As Integer = 310 'rmxv 
    Public Const SET_MAXIMA_VELOCIDADE_APLICADOR As Integer = 311 'smxv
    Public Const LER_CURSO_MAXIMO_APLICADOR As Integer = 312 'rmxc
    Public Const SET_CURSO_MAXIMO_APLICADOR As Integer = 313 'scmx
    Public Const LER_MAXIMA_PRESSAO_APLICADOR As Integer = 314 'rmxp
    Public Const SET_MAXIMA_PRESSAO_APLICADOR As Integer = 315 'smxp
    Public Const LER_MAXIMO_VOLUME_APLICADOR As Integer = 316 'rmxo
    Public Const SET_MAXIMO_VOLUME_APLICADOR As Integer = 317 'smxo
    Public Const LER_AREA_CALIBRACAO_VOLUME As Integer = 318 'rare
    Public Const SET_AREA_CALIBRACAO_VOLUME As Integer = 319 'sare
    Public Const LER_PASSO_FUSO As Integer = 320 'rpas
    Public Const SET_PASSO_FUSO As Integer = 321 'spas
    Public Const SET_REDUCAO_TOTAL As Integer = 322 'sred
    Public Const LER_REDUCAO_TOTAL As Integer = 323 'rred
    Public Const LER_TAXA_PRESSAO_APLICADOR As Integer = 324 'rtxp
    Public Const SET_TAXA_PRESSAO_APLICADOR As Integer = 325 'stxp
    Public Const LER_VAZAO_APLICADOR As Integer = 326 'rtxv
    Public Const SET_VAZAO_APLICADOR As Integer = 327 'stxv
    Public Const SET_INICIAR_CONTROLE_PRESSAO As Integer = 328 'ctrp
    Public Const SET_INICIAR_CONTROLE_VOLUME As Integer = 329 'ctrv
    Public Const SET_REFIL_CENTRAL_PROCESSADOR_SERVO As Integer = 330 'refi
    Public Const SET_DRENO_CENTRAL_PROCESSADOR_SERVO As Integer = 331 'drai
    Public Const SET_DESLOCAMENTO_MODO_VAZAO_SERVO As Integer = 332 'npos
    Public Const SET_ESTABILIZAR_CONTROLE_PROCESSADOR As Integer = 333 'esta
    Public Const LER_MULTIPLAS_RESPOSTAS As Integer = 334 'rall
    Public Const SET_MODO_CONTROLE_APLICADOR As Integer = 335 'smca
    Public Const SET_DESTINO_DESLOCAMENTO As Integer = 336 'sdtd
    Public Const LER_DESTINO_DESLOCAMENTO As Integer = 337 'rdtd
    Public Const SET_TAXA_DESLOCAMENTO As Integer = 338 'stxd
    Public Const LER_TAXA_DESLOCAMENTO As Integer = 339 'rtxd
    Public Const LER_AREA_BOOSTER As Integer = 340 'rarb
    Public Const LER_AREA_PRENSA As Integer = 341 'rarp
    Public Const SET_AREA_BOOSTER As Integer = 342 'sarb
    Public Const SET_AREA_PRENSA As Integer = 343 'sarp
    Public Const LER_DESLOCAMENTO_MINIMO_PRENSA As Integer = 344 'dmin
    Public Const LER_DESLOCAMENTO_MAXIMO_PRENSA As Integer = 345 'dmax
    Public Const LER_VOLUME_MINIMO_PRENSA As Integer = 346 'vmin
    Public Const LER_VOLUME_MAXIMO_PRENSA As Integer = 347 'vmax
    'Comandos Específicos Pressurizador/Aplicador------------------------------------------------------

    'Comandos Específicos Prensa Elétrica--------------------------------------------------------------
    Public Const LER_FAIXA_CALIBRACAO As Integer = 401 'rscl
    Public Const SET_ZERAR_PICO_CARGA_PROCESSADOR As Integer = 402 'zpic
    Public Const LER_PICO_INSTRUMENTO_PROCESSADOR As Integer = 403 'rpic
    Public Const LER_STATUS_AD As Integer = 404 'rdsa
    Public Const SET_DELAY_PROCESSADOR As Integer = 405 'dlay
    'Public Const SET_FUNDO_ESCALA_CARGA_PROCESSADOR As Integer = 406 'smax
    'Public Const LER_FUNDO_ESCALA_CARGA_ATUAL_PROCESSADOR As Integer = 407 'rmax 
    Public Const SET_DESLIGA_BOMBA As Integer = 408 'puof
    'Comandos Específicos Prensa Elétrica--------------------------------------------------------------

    'Comandos Específicos Triaxial---------------------------------------------------------------------
    'Bureta Digital
    Public Const LER_CONSTANTE_CONVERSAO_ML As Integer = 501 'rdpv
    Public Const SET_CONSTANTE_CONVERSAO_ML As Integer = 502 'wrpv
    'Comandos Específicos Triaxial---------------------------------------------------------------------

    'Comandos Específicos Prensas Incremento Carga------------------------------------------------------
    Public Const LER_TAXA_INCREMENTO As Integer = 601 'rrat
    Public Const SET_TAXA_INCREMENTO_PROCESSADOR As Integer = 602 'rate
    Public Const LER_PERCENTUAL_FINALIZACAO_AUTO_PROCESSADOR As Integer = 603 'rper
    Public Const INICIAR_CONTROLE_PROCESSADOR As Integer = 604 'ctrl
    Public Const DRENO_CRUZADO_PROCESSADOR_DELTA As Integer = 605 'drac 
    Public Const REFIL_CRUZADO_PROCESSADOR_DELTA As Integer = 606 'refc
    Public Const SET_VALVULA_PARALELA_PROCESSADOR_DELTA As Integer = 607 'spar
    Public Const SET_VALVULA_CRUZADA_PROCESSADOR_DELTA As Integer = 608 'scru
    Public Const SET_VALVULA_CENTRAL_PROCESSADOR_DELTA As Integer = 609 'scen
    Public Const LER_ID_PRESSAO_DISPLAY As Integer = 610 'ridp
    Public Const SET_ID_PRESSAO_DISPLAY As Integer = 611 'sidp
    Public Const LER_ID_LVDT_DISPLAY As Integer = 612 'ridl
    Public Const SET_ID_LVDT_DISPLAY As Integer = 613 'sidl
    Public Const LER_ID_MAIN_DISPLAY As Integer = 614 'ridm - Instrumento principal para exibição do LCD e no controle PID
    Public Const SET_ID_MAIN_DISPLAY As Integer = 615 'sidm - Instrumento principal para exibição do LCD e no controle PID
    Public Const SET_RESET_DISPLAY As Integer = 616 'rdis
    Public Const SET_RESET_LASER As Integer = 617 'rstl
    Public Const SET_BOUNCE_BREAK As Integer = 618 'stbbX
    Public Const SET_ERROR_ADJUST As Integer = 619 'stajX
    Public Const LER_BOUNCE_BREAK As Integer = 620 'stbb
    Public Const LER_ERROR_ADJUST As Integer = 621 'staj
    Public Const LER_KP_2 As Integer = 622 'stkp
    Public Const SET_SAMPLE_TIME As Integer = 623 'stst
    Public Const LER_SAMPLE_TIME As Integer = 624 'stst
    Public Const SET_MINIMO_VALOR_AJUSTE As Integer = 625 'stma
    Public Const LER_MINIMO_VALOR_AJUSTE As Integer = 626 'stma
    'Comandos Específicos Prensas Incremento Carga------------------------------------------------------

    'Comandos Específicos CBR-Marshall-PVC-Ceramica-----------------------------------------------------------------
    Public Const LER_THRESHOLD_CARGA As Integer = 701 'rthc
    Public Const SET_THRESHOLD_CARGA As Integer = 702 'sthc
    Public Const LER_THRESHOLD_LVDT As Integer = 703 'rthl
    Public Const SET_THRESHOLD_LVDT As Integer = 704 'sthl
    Public Const SET_REPOSICIONAR As Integer = 705 'srep
    Public Const RESET_REPOSICIONAR As Integer = 706 'rrep
    Public Const SET_VELOCIDADE_REPOSICIONAR As Integer = 707 'svel6000
    Public Const SET_TESTE_AUTOMATICO As Integer = 708 'stes
    Public Const RESET_TESTE_AUTOMATICO As Integer = 709 'rtes
    Public Const SET_DESLIGA_PID As Integer = 710 'dpid
    Public Const LER_DESTINO_CARGA As Integer = 711 'rdtc
    Public Const SET_DESTINO_CARGA As Integer = 712 'sdtc
    Public Const LER_TAXA_CARGA As Integer = 713 'rtxc
    Public Const SET_TAXA_CARGA As Integer = 714 'stxc
    Public Const SET_CONTROLE_CARGA As Integer = 715 'ctrc
    'Public Const SET_DESTINO_DESLOCAMENTO As Integer = 336 'sdtdX
    'Public Const LER_DESTINO_DESLOCAMENTO As Integer = 337 'sdtd
    'Public Const SET_TAXA_DESLOCAMENTO As Integer = 338 'stxdX
    'Public Const LER_TAXA_DESLOCAMENTO As Integer = 339 'stxd
    Public Const SET_CONTROLE_DESLOCAMENTO As Integer = 716 'ctrd
    'Comandos Específicos CBR-Marshall-----------------------------------------------------------------


    'Comandos Antigos CBR-Marshall--------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Não implementados, mas equivalem aos coeficientes da equação: 'Expressão Atual : [(y * 19,80) + 31,50 = x]
    Public Const LER_CONSTANTE_CONVERSAO_INVERSOR As Integer = 801 'rcvl - ler o valor da constante para o calculo de conversão de bits para mm/min para acionar o inversor de frequencia
    Public Const LER_OFFSER_CONVERSAO_INVERSOR As Integer = 802 'rovl - ler o valor do offset para o calculo de conversão de bits para mm/min para acionar o inversor de frequencia
    Public Const LER_ARDUINO_N1500_LVDT As Integer = 803
    Public Const LER_ARDUINO_N1500 As Integer = 804
    Public Const TARA_ARDUINO_N1500 As Integer = 805
    Public Const ESCALA_ARDUINO_N1500 As Integer = 806
    Public Const TAXA_INCREMENTO_ARDUINO_N1500 As Integer = 807
    Public Const LER_FUNDOS_DE_ESCALA_ARDUINO As Integer = 808
    Public Const TRANSFERIR_NOVUS_EEPROM_ARDUINO As Integer = 809
    Public Const TRANSFERIR_EEPROM_NOVUS_ARDUINO As Integer = 810
    Public Const SET_FUNDO_ESCALA_ARDUINO As Integer = 811
    Public Const START_AD As Integer = 812
    Public Const STOP_AD As Integer = 813
    Public Const SET_CONSTANTE_KP_INCREMENTO_PID As Integer = 814 'stkcX
    Public Const LER_CONSTANTE_KP_INCREMENTO_PID As Integer = 815 'stkc
    Public Const SET_CONSTANTE_KP_DESLOCAMENTO_PID As Integer = 816 'stkpX
    Public Const LER_CONSTANTE_KP_DESLOCAMENTO_PID As Integer = 817 'stkp
    'Comandos Antigos CBR-Marshall--------------------------------------------------------------------------------------------------------------------------------------------------------------


    'CONSTANTE PARA CONVERSÃO DE KGF/CM² EM KPA
    Public Const CONSTANTE_KILOGRAMAFORCA_KPA As Double = 98.06652

End Module