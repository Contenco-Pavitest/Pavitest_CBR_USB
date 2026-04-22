Option Explicit On

Public Class clsNovus
    'Contenco Industria e Comercio Ltda.
    'Projeto Pavitest
    '
    'Arquivo que determina a comunicação com o Novus (Carga e LVDT)

#Region "DECLARAÇÃO DE VARIÁVEIS"

    Dim lngCRCLo As Long
    Dim lngCRCHi As Long

    Public ErroNovus As Boolean
    Public ErroComunicacao As Boolean
    Public lngSensor As Long

#End Region


    Public Function ComunicacaoNovus(ByRef objCom As Object, ByVal intLeitor As Integer) As Double
        'Le a carga e o LVDT atraves do Novus
        Dim dblConst As Double
        Dim lngOffset As Long

        Dim strPalavra As String
        Dim lngTam As Long
        Dim intCont As Integer

        Dim a
        Dim DataHi
        Dim DataLo
        Dim dblValor

        Try

            ErroNovus = True
            ErroComunicacao = True

            'Lê os valores da carga e dos LVDT´s através do Novus
            Select Case intLeitor
                Case CARGA
                    objCom.Write(Chr(1) & Chr(3) & Chr(0) & Chr(0) & Chr(0) & Chr(1) & Chr(132) & Chr(10))
                Case LVDT
                    objCom.Write(Chr(2) & Chr(3) & Chr(0) & Chr(0) & Chr(0) & Chr(1) & Chr(132) & Chr(57))
            End Select

            'Espera resposta
            Call System.Threading.Thread.Sleep(120)

            a = objCom.ReadExisting()

            If Len(a) <> 0 Then
                If Len(a) = 7 Then
                    DataHi = Asc(Mid(a, 4, 1))
                    DataLo = Asc(Mid(a, 5, 1))

                    If DataHi * 256 + DataLo >= 32768 Then
                        ComunicacaoNovus = (DataHi * 256 + DataLo) - 65536
                    Else
                        ComunicacaoNovus = DataHi * 256 + DataLo
                    End If

                    If intLeitor = LVDT Then ComunicacaoNovus = ComunicacaoNovus / 100

                    ErroNovus = False
                    ErroComunicacao = False
                Else
                    ErroComunicacao = False
                End If
            End If

            Exit Function


        Catch ex As Exception
            ErroNovus = True
            Err.Clear()
        End Try

    End Function

    Public Function Leitura_Offset(ByRef objCom As Object) As Double
        '
        Dim a
        Dim DataHi
        Dim DataLo
        Dim dblValor

        Try

            ErroNovus = True

            'Lê o valor do OFFSET do LVDT
            objCom.Write(Chr(2) & Chr(3) & Chr(0) & Chr(15) & Chr(0) & Chr(1) & Chr(180) & Chr(58))

            'Espera resposta
            Call System.Threading.Thread.Sleep(120)

            a = objCom.ReadExisting()

            If Len(a) <> 0 Then
                If Len(a) = 7 Then
                    DataHi = Asc(Mid(a, 4, 1))
                    DataLo = Asc(Mid(a, 5, 1))

                    If DataHi * 256 + DataLo >= 32768 Then
                        Leitura_Offset = (DataHi * 256 + DataLo) - 65536
                    Else
                        Leitura_Offset = DataHi * 256 + DataLo
                    End If

                    ErroNovus = False
                End If
            End If

            Exit Function


        Catch ex As Exception
            ErroNovus = True
            Err.Clear()
        End Try

    End Function

    Public Function Escrita_Offset(ByRef objCom As Object, ByVal dblOffset As Double) As Double
        '
        Dim intValor As Integer
        Dim lngOffset As Long
        Dim strOffset As String
        Dim strPalavra As String

        Dim strOff1, strOff2 As String
        Dim lngOff1, lngOff2 As Long

        Try

            intValor = CInt(dblOffset * 100)
            intValor = Math.Abs(intValor)
            '
            lngOffset = 65535 - intValor
            strOffset = Hex(lngOffset)
            '
            strPalavra = "0206000F" & strOffset
            'Calcular CRC
            Call CalcularCRC(strPalavra)

            '
            strOff1 = Mid(strOffset, 1, 2)
            strOff2 = Mid(strOffset, 3, 4)
            lngOff1 = Asc(Chr("&H" & strOff1))
            lngOff2 = Asc(Chr("&H" & strOff2))

            'Escrever o valor do OFFSET do LVDT
            objCom.Write(Chr(2) & Chr(6) & Chr(0) & Chr(15) & Chr(lngOff1) & Chr(lngOff2))
            '
            objCom.Write(Chr(lngCRCLo) & Chr(lngCRCHi))

            'Espera resposta
            Call System.Threading.Thread.Sleep(120)

            Exit Function


        Catch ex As Exception
            Err.Clear()
        End Try

    End Function

    Private Sub CalcularCRC(ByVal strPalavra As String)
        'Calcular CRC
        Dim intTam As Integer
        Dim lngCRCByte As Long
        Dim i, j As Integer
        Dim blnCarryHi As Boolean
        Dim blnCarryLo As Boolean

        Try

            lngCRCLo = 255
            lngCRCHi = 255

            intTam = Len(strPalavra)

            For j = 1 To intTam Step 2
                lngCRCByte = (Asc(Chr("&H" & Mid(strPalavra, j, 2))))
                lngCRCLo = lngCRCByte Xor lngCRCLo
                For i = 1 To 8
                    If lngCRCHi Mod 2 = 1 Then blnCarryHi = True Else blnCarryHi = False
                    If lngCRCLo Mod 2 = 1 Then blnCarryLo = True Else blnCarryLo = False
                    lngCRCHi = lngCRCHi \ 2 ' rotacao para direita
                    lngCRCLo = lngCRCLo \ 2 ' rotacao para direita
                    If blnCarryHi = True Then lngCRCLo = lngCRCLo + 128
                    If blnCarryLo = True Then
                        lngCRCHi = lngCRCHi Xor &HA0
                        lngCRCLo = lngCRCLo Xor &H1
                    End If
                Next i
            Next j

        Catch ex As Exception
            Err.Clear()
        End Try

    End Sub

    Private Function Transformar02Bytes(ByVal intValor As Integer) As String
        Dim strHex As String

        Try

            'Transformar em hexadecimal
            strHex = Hex(CDbl(intValor))

            Select Case Len(strHex)
                Case 1 : strHex = "000" & strHex
                Case 2 : strHex = "00" & strHex
                Case 3 : strHex = "0" & strHex
            End Select

            Transformar02Bytes = strHex

            Exit Function


        Catch ex As Exception
            Err.Clear()
            Transformar02Bytes = ""
        End Try

    End Function

End Class
