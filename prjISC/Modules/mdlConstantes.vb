Option Strict Off
Option Explicit On

Module mdlConstantes
    'Contenco Industria e Comercio Ltda.
    'Projeto Pavitest Marshall'Comando para movimentar a máquina
    Public Const COMANDO_INCREMENTAR As Integer = 1
    Public Const COMANDO_DECREMENTAR As Integer = 2
    Public Const COMANDO_PARAR As Integer = 3

    'Gerar Relatórios
    Public Const rpt_AXIAL As Short = 1
    Public Const rpt_ENSAIOS As Short = 2
    Public Const rpt_LISTAGEM As Short = 3
    Public Const rpt_RESULTADOS As Short = 4




    Public Const CANAL1_HABILITADO As Integer = 12
    Public Const CANAL2_HABILITADO As Integer = 13
    Public Const CANAL3_HABILITADO As Integer = 14
    Public Const CANAL4_HABILITADO As Integer = 15
    Public Const CANAL5_HABILITADO As Integer = 16
    Public Const CANAL6_HABILITADO As Integer = 17
    Public Const CANAL7_HABILITADO As Integer = 18
    Public Const CANAL8_HABILITADO As Integer = 19

    'Montar estruturas sql 
    Public cmd_CREATE As Integer = 1
    Public cmd_UPDATE As Integer = 2
    Public cmd_INSERT As Integer = 3

    'Leitores LVDT´s, EXTENSÔMETROS, CÉLULA DE CARGA, TRANSDUTOR
    Public Const LVDT As Short = 1
    Public Const RELOGIO_COMPARADOR As Short = 2
    Public Const CARGA As Short = 3
    Public Const DESABILITADO As Short = 4

    'Direção do ensaio (Incrementar/Tração ou Decrementar/Compressão)
    Public Const INCREMENTAR As Integer = 1
    Public Const DECREMENTAR As Integer = 2
    Public Const PARAR As Integer = 3
    Public Const EXECUTAR As Integer = 4
    Public Const FINALIZAR As Integer = 5
    Public Const CANCELAR As Integer = 6
    Public Const THRESHOLD As Integer = 7
    Public Const DESTINO As Integer = 8
    Public Const TAXA As Integer = 9
    Public Const INICIAR As Integer = 10

    'Etapa na ESTABILIZAÇÃO
    Public Const ESPERAR As Integer = 1
    Public Const AQUISIÇÃO As Integer = 2
    Public Const PRÓXIMA As Integer = 3
    Public Const CONCLUIDO As Integer = 4

    'Dimensões do CP
    Public Const DIÂMETRO As Integer = 1
    Public Const LARGURA As Integer = 2
    Public Const ALTURA As Integer = 3
    Public Const COMPRIMENTO As Integer = 4
    Public Const DISTÂNCIA As Integer = 5
    Public Const TENSÃO As Integer = 6
    Public Const MEDIDAS As Integer = 7

    'Valor do PI
    Public Const PI As Double = 3.1416

    'Converter valores para N e MPa
    Public Const CONVERTER As Double = 9.80665

    'Declaração que permite travar o formulário na MDI
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const WM_SYSCOMMAND As Integer = &H112
    Public Const HTCAPTION As Integer = &H2
    Public Const SC_MOVE As Integer = &HF010

    'Constantes de apresentação do form
    Public Const WM_PAINT As Integer = &HF
    Public Const HWND_TOPMOST As Integer = -1
    Public Const HWND_NOTOPMOST As Integer = -2
    Public Const SWP_NOSIZE As Integer = &H1
    Public Const SWP_NOMOVE As Integer = &H2
    Public Const SWP_NOACTIVATE As Integer = &H10
    Public Const SWP_SHOWWINDOW As Integer = &H40

    'Constante da função API Cancelar Botão X
    Public Const MF_BYPOSITION As Integer = &H400

    'Copiar, colar, limpar e recortar
    Public Const WM_COMMAND = &H111
    Public Const WM_CUT = &H300
    Public Const WM_COPY = &H301
    Public Const WM_PASTE = &H302
    Public Const EM_UNDO = &HC7
    Public Const EM_CANUNDO = &HC6
    Public Const EM_REPLACESEL = &HC2

End Module