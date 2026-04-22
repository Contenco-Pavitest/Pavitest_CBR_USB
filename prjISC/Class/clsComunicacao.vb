Option Strict Off
Option Explicit On

Imports System.IO.Ports

Public Class clsComunicacao
    'Contenco Industria e Comercio Ltda.
    'Projeto Pavitest Marshall
    '
    'Classe que realiza a comunicação com os leitores
    'Célula de Carga, Transdutor de pressão, LVDT ou Extenômetro

#Region "VARIÁVEIS"

    Public strStatusMaquina(31) As String
    Public strStatusAD(7) As String
    Public strCanaisHabilitados As String
    Public strStatusErroPlacaAD As String
    Public strStatusInicializacaoPlacaAD As String

    Public blnErro As Boolean
    Public blnCanal0 As Boolean
    Public blnCanal1 As Boolean
    Public blnCanal4 As Boolean
    Public blnCanal5 As Boolean
    Public blnCanal6 As Boolean
    Public blnCanal7 As Boolean

#End Region

    Public Sub New()

        'Setar as classes de comunicação
        usrPortaSerial = New clsPortaSerial
        usrArduino_AD7192 = New clsArduino_AD7192

    End Sub

    Public Function VerificaCanaisHabilitadosPlaca0(ByRef spPortaSerial As SerialPort) As Boolean

        Try
            If blnComunicacao = False Then Exit Function

            blnCanal0 = False

            strPlaca = "0" '"b"
            'Comando para ler os canais do SLAV que estão habilitados
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_CANAIS_HABILITADOS_AD, "Leitura")

            If usrArduino_AD7192.blnErroLeituraStatusHabilitacaoCanaisAD = False Then
                'Remove indicação de erro
                blnErroLeituraStatusCanalPlaca0 = False

                If strCanalHabilitado_ArduinoSlave.Contains("0") Then
                    blnCanal0 = True
                    blnTemCanalHabilitadoPlaca0 = True
                Else
                    blnCanal0 = False
                    blnTemCanalHabilitadoPlaca0 = False
                End If
            Else
                blnErroLeituraStatusCanalPlaca0 = True
            End If

            VerificaCanaisHabilitadosPlaca0 = blnTemCanalHabilitadoPlaca0

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("VerificaCanaisHabilitadosPlaca0()" & Chr(13) & ex.Message)
        End Try

    End Function

    Public Function VerificaCanaisHabilitadosPlaca1(ByRef spPortaSerial As SerialPort) As Boolean
        Try

            If blnComunicacao = False Then Exit Function

            strPlaca = "1"
            'Comando para ler os canais do SLAV que estão habilitados
            Call usrArduino_AD7192.Comunicar_Arduino(spPortaSerial, LER_CANAIS_HABILITADOS_AD, "Leitura")

            If usrArduino_AD7192.blnErroLeituraStatusHabilitacaoCanaisAD = False Then

                'Remove indicação de erro
                blnErroLeituraStatusCanalPlaca1 = False

                If strCanalHabilitado_ArduinoSlave.Contains("4") Then
                    blnCanal4 = True
                Else
                    blnCanal4 = False
                End If

                If strCanalHabilitado_ArduinoSlave.Contains("5") Then
                    blnCanal5 = True
                Else
                    blnCanal5 = False
                End If

                If strCanalHabilitado_ArduinoSlave.Contains("6") Then
                    blnCanal6 = True
                Else
                    blnCanal6 = False
                End If

                If strCanalHabilitado_ArduinoSlave.Contains("7") Then
                    blnCanal7 = True
                Else
                    blnCanal7 = False
                End If

                If blnCanal4 Or blnCanal5 Or blnCanal6 Or blnCanal7 Then
                    blnTemCanalHabilitadoPlaca1 = True
                Else
                    blnTemCanalHabilitadoPlaca1 = False
                End If

            Else

                blnErroLeituraStatusCanalPlaca1 = True

            End If

            VerificaCanaisHabilitadosPlaca1 = blnTemCanalHabilitadoPlaca1

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("VerificaCanaisHabilitadosPlaca1()" & Chr(13) & ex.Message)
        End Try

    End Function

    Public Function StatusHabilitacaoCanais(ByVal intValor As Integer) As Boolean

        'Dim intCanaisHabilitados As Integer = 0

        Try
            'Recebe da função os canais habilitados
            strCanaisHabilitados = Transformar_Bit_Canais_Habilitados(intValor)

            'Evitar erro de disparada de mensagens quando não se consegue mais comunicar
            If strCanaisHabilitados = Nothing Then Exit Function

            'Canal 0
            If strCanaisHabilitados.Contains("0") Then
                blnCanal0 = True
            Else
                blnCanal0 = False
            End If

            'Canal 1
            If strCanaisHabilitados.Contains("1") Then
                blnCanal1 = True
            Else
                blnCanal1 = False
            End If

            'Canal 4
            If strCanaisHabilitados.Contains("4") Then
                blnCanal4 = True
            Else
                blnCanal4 = False
            End If

            'Canal 5
            If strCanaisHabilitados.Contains("5") Then
                blnCanal5 = True
            Else
                blnCanal5 = False
            End If

            'Canal 6
            If strCanaisHabilitados.Contains("6") Then
                blnCanal6 = True
            Else
                blnCanal6 = False
            End If

            'Canal 7
            If strCanaisHabilitados.Contains("7") Then
                blnCanal7 = True
            Else
                blnCanal7 = False
            End If

            'Se não há nenhum canal
            If strCanaisHabilitados = "" Then
                StatusHabilitacaoCanais = False
            Else
                StatusHabilitacaoCanais = True
            End If

            Return StatusHabilitacaoCanais

        Catch ex As Exception

            Return False

            'Mensagem de erro
            MsgBox("StatusHabilitacaoCanais()" & Chr(13) & ex.Message)
        End Try

    End Function

    Public Function Transformar_Bit_Canais_Habilitados(ByVal intValor As Integer) As String
        Dim intVetor(7) As Integer '0 ou 1
        Dim intX As Integer
        Dim intY As Integer
        Dim intCanal(7) As Integer
        Dim strCanal(7) As String

        Try
            For i = 0 To 7
                intX = intValor Mod 2
                intY = intValor \ 2
                intVetor(7 - i) = intX
                intValor = intY
            Next

            '                         Campos de Identificacao dos bits
            '
            '               x   x   x   x                           x   x   x   x
            '              ___ ___ ___ ___                         ___ ___ ___ ___
            '               0   1   2   3                           4   5   6   7


            '                    Campos de Identificacao das Entrdas Digitais do Arduino
            '
            '     Canal 7  Canal 6  Canal 5  Canal 3        Canal 3  Canal 2  Canal 1  Canal 0
            '     _______  _______  _______  _______        _______  _______  _______  _______  
            '      =128     =64       =32      =16             =8      =4       =2        =1
            '

            'Limpando Variáveis
            'For i = 0 To 7
            '    strCanal(i) = ""
            'Next

            'Limpa vetores
            ReDim strCanal(7)
            ReDim intCanal(7)

            'Volta Status do Canal
            strCanaisHabilitados = ""

            If intVetor(7) = 1 Then strCanal(0) = "0" : intCanal(0) = 1 'CANAL1_HABILITADO
            If intVetor(6) = 1 Then strCanal(1) = "1" : intCanal(1) = 1 'CANAL2_HABILITADO
            If intVetor(5) = 1 Then strCanal(2) = "2" : intCanal(2) = 1 'CANAL3_HABILITADO
            If intVetor(4) = 1 Then strCanal(3) = "3" : intCanal(3) = 1 'CANAL4_HABILITADO
            If intVetor(3) = 1 Then strCanal(4) = "4" : intCanal(4) = 1 'CANAL5_HABILITADO
            If intVetor(2) = 1 Then strCanal(5) = "5" : intCanal(5) = 1 'CANAL6_HABILITADO
            If intVetor(1) = 1 Then strCanal(6) = "6" : intCanal(6) = 1 'CANAL7_HABILITADO
            If intVetor(0) = 1 Then strCanal(7) = "7" : intCanal(7) = 1 'CANAL8_HABILITADO

            strCanaisHabilitados = strCanal(0) & strCanal(1) & strCanal(2) & strCanal(3) & strCanal(4) & strCanal(5) & strCanal(6) & strCanal(7)
            intSomaCanaisHabilitados = intCanal(0) + intCanal(1) + intCanal(2) + intCanal(3) + intCanal(4) + intCanal(5) + intCanal(6) + intCanal(7)

            Return strCanaisHabilitados

        Catch ex As Exception

            Return Nothing

            'Mensagem de erro
            MsgBox("Transformar_Bit_Status()" & Chr(13) & ex.Message)
        End Try

    End Function

    Public Function Somar_Canais_Habilitados(ByVal intValor As Integer) As Integer
        Dim intVetor(7) As Integer '0 ou 1
        Dim intX As Integer
        Dim intY As Integer

        Dim intCanal(7) As Integer

        Try
            For i = 0 To 7
                intX = intValor Mod 2
                intY = intValor \ 2
                intVetor(7 - i) = intX
                intValor = intY
            Next

            '                         Campos de Identificacao dos bits
            '
            '               x   x   x   x                           x   x   x   x
            '              ___ ___ ___ ___                         ___ ___ ___ ___
            '               0   1   2   3                           4   5   6   7


            '                    Campos de Identificacao das Entrdas Digitais do Arduino
            '
            '     Canal 7  Canal 6  Canal 5  Canal 3        Canal 3  Canal 2  Canal 1  Canal 0
            '     _______  _______  _______  _______        _______  _______  _______  _______  
            '      =128     =64       =32      =16             =8      =4       =2        =1
            '

            'Limpa vetor
            ReDim intCanal(7)

            If intVetor(7) = 1 Then intCanal(0) = 1 Else intCanal(0) = 0
            If intVetor(6) = 1 Then intCanal(1) = 1 Else intCanal(1) = 0
            If intVetor(5) = 1 Then intCanal(2) = 1 Else intCanal(2) = 0
            If intVetor(4) = 1 Then intCanal(3) = 1 Else intCanal(3) = 0
            If intVetor(3) = 1 Then intCanal(4) = 1 Else intCanal(4) = 0
            If intVetor(2) = 1 Then intCanal(5) = 1 Else intCanal(5) = 0
            If intVetor(1) = 1 Then intCanal(6) = 1 Else intCanal(6) = 0
            If intVetor(0) = 1 Then intCanal(7) = 1 Else intCanal(7) = 0

            Return (intCanal(0) + intCanal(1) + intCanal(2) + intCanal(3) + intCanal(4) + intCanal(5) + intCanal(6) + intCanal(7))

        Catch ex As Exception

            Return Nothing

            'Mensagem de erro
            MsgBox("Somar_Canais_Habilitados()" & Chr(13) & ex.Message)
        End Try

    End Function

    Public Sub Transformar_Bit_Status1(ByVal intValorP1 As Integer, ByVal intValorP2 As Integer)

        'STATUS DE BOOLEANOS DO PRESSURIZADOR

        Dim intVetorP1(7) As Integer '0 ou 1
        Dim intVetorP2(7) As Integer '0 ou 1
        Dim intX As Integer
        Dim intY As Integer

        Try
            For i = 0 To 7
                intX = intValorP2 Mod 2
                intY = intValorP2 \ 2
                intVetorP2(7 - i) = intX
                intValorP2 = intY
            Next

            For i = 0 To 7
                intX = intValorP1 Mod 2
                intY = intValorP1 \ 2
                intVetorP1(7 - i) = intX
                intValorP1 = intY
            Next

            '                         Campos de Identificacao dos bits (Parte 1 Mais Significativa)
            '
            '                           x   x   x   x                           x   x   x   x
            '                          ___ ___ ___ ___                         ___ ___ ___ ___
            '                           0   1   2   3                           4   5   6   7
            '
            '
            '    _______________    _______________   ______________  __________    _________   __________  __________  ___________  
            '          =128              =64               =32           =16            =8          =4          =2          =1
            '

            '                         Campos de Identificacao dos bits (Parte 2 Menos Significativa)
            '
            '                           x   x   x   x                           x   x   x   x
            '                          ___ ___ ___ ___                         ___ ___ ___ ___
            '                           0   1   2   3                           4   5   6   7
            '
            '
            '                  
            '                  
            '     ________  ________  __________  ____________  _____________  __________  _______________  _______________  
            '      =128       =64        =32          =16            =8            =4            =2               =1
            '


            'Limpa as variáveis antes de pegar o status atual
            For i = 0 To 15
                strStatusMaquina(i) = ""
            Next

            'Byte 1
            If intVetorP1(7) = 1 Then strStatusMaquina(0) = "Sobrecarga On" Else strStatusMaquina(0) = "Sobrecarga Off"
            If intVetorP1(6) = 1 Then strStatusMaquina(1) = "Fim de Curso Inferior"
            If intVetorP1(5) = 1 Then strStatusMaquina(2) = "Fim de Curso Superior"
            If intVetorP1(4) = 1 Then strStatusMaquina(3) = "Emergência"
            If intVetorP1(3) = 1 Then strStatusMaquina(4) = "Subindo"
            If intVetorP1(2) = 1 Then strStatusMaquina(5) = "Descendo"
            If intVetorP1(1) = 1 Then strStatusMaquina(6) = "Modo Local (Manual)" Else strStatusMaquina(6) = "Modo Remoto (Automático)"
            If intVetorP1(0) = 1 Then strStatusMaquina(7) = "Threshold de Deslocamento"
            'Byte 2
            If intVetorP2(7) = 1 Then strStatusMaquina(8) = "Threshold de Carga"
            If intVetorP2(6) = 1 Then strStatusMaquina(9) = "Célula de Carga Conectada" Else strStatusMaquina(8) = ""
            If intVetorP2(5) = 1 Then strStatusMaquina(10) = "Sobrecurso On" Else strStatusMaquina(10) = "Sobrecurso Off"
            If intVetorP2(4) = 0 Then strStatusMaquina(11) = "Reposicionou"
            If intVetorP2(3) = 1 Then strStatusMaquina(12) = "PID Ligado"
            If intVetorP2(2) = 1 Then strStatusMaquina(13) = "Subindo Setpoint"
            If intVetorP2(1) = 1 Then strStatusMaquina(14) = "Descendo Setpoint"
            If intVetorP2(0) = 1 Then strStatusMaquina(15) = ""

            'Lógica complementar:
            If (intVetorP1(0) = 1) And (intVetorP2(7) = 0) Then
                strStatusThreshold = "Limite de Deslocamento Atingido"
            ElseIf (intVetorP1(0) = 0) And (intVetorP2(7) = 0) Then
                strStatusThreshold = "Aguardando Início do Ensaio"
            ElseIf (intVetorP1(0) = 1) And (intVetorP2(7) = 1) Then
                strStatusThreshold = "Início de Monitoramento"
            Else
                strStatusThreshold = "Limite Inicial de Carga Atingido"
            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Transformar_Bit_Status1()" & Chr(13) & ex.Message)
        End Try
    End Sub

    Public Sub Transformar_Bit_StatusAD(ByVal intValorP1 As Integer)

        'STATUS DAS PLACAS AD

        Dim intVetorP1(7) As Integer '0 ou 1
        Dim intVetorP2(7) As Integer '0 ou 1
        Dim intX As Integer
        Dim intY As Integer

        Try

            For i = 0 To 7
                intX = intValorP1 Mod 2
                intY = intValorP1 \ 2
                intVetorP1(7 - i) = intX
                intValorP1 = intY
            Next

            '                                     Campos de Identificacao dos bits
            '
            '                           x   x   x   x                           x   x   x   x
            '                          ___ ___ ___ ___                         ___ ___ ___ ___
            '                           0   1   2   3                           4   5   6   7



            '                    Campos de Identificacao das Entrdas Digitais do Arduino                                                                                                 
            '     
            '     ________  ________  __________   __________      __________  _________  _________  ________  
            '      =128       =64        =32          =16              =8         =4         =2        =1
            '

            'Limpa as variáveis antes de pegar o status atual
            For i = 0 To 7
                strStatusAD(i) = ""
            Next

            'STATUS AD
            If intVetorP1(7) = 1 Then strStatusAD(0) = "AD inicializado com sucesso"
            If intVetorP1(6) = 1 Then strStatusAD(1) = "Erro AD" Else
            'If intVetorP1(5) = 1 Then 
            'If intVetorP1(4) = 1 Then 
            'If intVetorP1(3) = 1 Then 
            'If intVetorP1(2) = 1 Then 
            'If intVetorP1(1) = 1 Then 
            'If intVetorP1(0) = 1 Then 

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Transformar_Bit_StatusAD()" & Chr(13) & ex.Message)
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

End Class
