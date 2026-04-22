Option Strict Off
Option Explicit On

Imports System
Imports System.Management
Imports Microsoft.Win32
Imports System.IO
Imports System.Net

Friend Class clsLicença

    Dim strUUID As String
    Dim strGUID As String

#Region "GRAVAR ARQUIVO E LER INFO DO PC"

    Public Sub Gravar_Arquivo_Licença(ByVal strContraChave As String)

        Dim oEscrever As New System.IO.FileStream(My.Application.Info.DirectoryPath & "\Licença.dll", IO.FileMode.Create)
        Dim oArquivo As New System.IO.StreamWriter(oEscrever)

        Try
            oArquivo.Write(strContraChave)
            oArquivo.Close()
            oEscrever.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub Gravar_Arquivo_Info_PC(ByVal oEscrever As FileStream)

        'Dim oEscrever As New System.IO.FileStream(My.Application.Info.DirectoryPath & "\Chave.dll", IO.FileMode.Create)
        Dim oArquivo As New System.IO.StreamWriter(oEscrever)

        Try
            oArquivo.Write(frmLicença.mtxtChave.Text & vbCrLf)
            oArquivo.Write(Ler_Info_PC("CPU", "Processor", "ProcessorID") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("MAC Address", "NetworkAdapterConfiguration", "MacAddress") & vbCrLf)
            oArquivo.Write(Dns.GetHostByName(Dns.GetHostName()).AddressList(0).ToString() & vbCrLf)
            oArquivo.Write(Ler_Info_PC("HD", "DiskDrive", "SerialNumber") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("BIOS", "BIOS", "SerialNumber") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Placa-Mãe", "BaseBoard", "Product") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Placa-Mãe", "BaseBoard", "Manufacturer") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Placa-Mãe", "BaseBoard", "Version") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Placa-Mãe", "BaseBoard", "SerialNumber") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("RAM", "PhysicalMemory", "SerialNumber") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Nome do PC", "ComputerSystem", "Name") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Nome do Domínio", "ComputerSystem", "Domain") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Modelo do PC", "ComputerSystem", "Model") & vbCrLf)
            oArquivo.Write(Ler_Info_PC("Tipo do Sistema", "ComputerSystem", "SystemType"))

            oArquivo.Close()
            oEscrever.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Function Ler_Info_PC(ByVal strComponente As String, ByVal strComponenteCMD As String, ByVal strPropriedadeComponente As String) As String

        Dim objMOS As ManagementObjectSearcher
        Dim objMOC As Management.ManagementObjectCollection
        Dim objMO As Management.ManagementObject = Nothing
        'Contador para pegar apenas o primeiro dispositivo
        Dim intContador As Integer = 0
        Dim strInfoPC As String = ""

        Try
            objMOS = New ManagementObjectSearcher("Select * From Win32_" & strComponenteCMD)
            objMOC = objMOS.Get

            For Each objMO In objMOC

                If (objMO(strPropriedadeComponente) <> "") And (intContador = 0) Then

                    strInfoPC = (objMO(strPropriedadeComponente)).Replace("-", "")
                    strInfoPC = strInfoPC.ToUpper()
                    intContador += 1

                End If

            Next

            objMOS.Dispose()
            objMOS = Nothing
            objMO.Dispose()
            objMO = Nothing

            Ler_Info_PC = strInfoPC

        Catch ex As Exception

            'Mensagem de erro
            Ler_Info_PC = ""

        End Try
    End Function

    Public Function VerificarComputador(ByVal strUUID As String, ByVal strGUID As String) As Boolean

        Dim strUUIDPC As String
        Dim strGUIDPC As String

        Try
            'Ler UUID do Computador
            strUUIDPC = Ler_Info_PC("UUID", "ComputerSystemProduct", "UUID")

            'Ler MachineGUID do Computador
            strGUIDPC = Read64bitRegistryFrom32bitApp.RegistryWOW6432.GetRegKey64(Read64bitRegistryFrom32bitApp.RegHive.HKEY_LOCAL_MACHINE, "SOFTWARE\\Microsoft\\Cryptography", "MachineGuid").ToUpper.Replace("-", "")

            If ((strUUID = strUUIDPC) And (strGUID = strGUIDPC)) Then
                VerificarComputador = True
                blnLicença = True
            Else
                VerificarComputador = False
                blnLicença = False
            End If

        Catch ex As Exception

            VerificarComputador = False
            blnLicença = False

        End Try

    End Function

#End Region

#Region "CRIPTOGRAFAR E DESCRIPTOGRAFAR CHAVE"

    Public Function Criptografar_Chave() As String

        Dim intIndiceUUID As Integer = 0
        Dim intIndiceGUID As Integer = 0
        Dim vetorChave(63) As Char

        Try
            'Ler UUID do Computador
            strUUID = Ler_Info_PC("UUID", "ComputerSystemProduct", "UUID")

            'Ler MachineGUID do Computador
            strGUID = Read64bitRegistryFrom32bitApp.RegistryWOW6432.GetRegKey64(Read64bitRegistryFrom32bitApp.RegHive.HKEY_LOCAL_MACHINE, "SOFTWARE\\Microsoft\\Cryptography", "MachineGuid").ToUpper.Replace("-", "")

            'Intercala o UUID com o GUID
            For intIndiceChave As Integer = 0 To 63

                If intIndiceChave Mod 2 = 0 Then

                    vetorChave(intIndiceChave) = strUUID(intIndiceUUID)
                    intIndiceUUID += 1

                ElseIf intIndiceChave Mod 2 = 1 Then

                    vetorChave(intIndiceChave) = strGUID(intIndiceGUID)
                    intIndiceGUID += 1

                End If
            Next

            'Substitui os caracteres de acordo com a tabela
            For i As Integer = 0 To vetorChave.Length - 1

                If vetorChave(i) = "0" Then
                    vetorChave(i) = "6"
                ElseIf vetorChave(i) = "1" Then
                    vetorChave(i) = "E"
                ElseIf vetorChave(i) = "2" Then
                    vetorChave(i) = "0"
                ElseIf vetorChave(i) = "3" Then
                    vetorChave(i) = "5"
                ElseIf vetorChave(i) = "4" Then
                    vetorChave(i) = "D"
                ElseIf vetorChave(i) = "5" Then
                    vetorChave(i) = "7"
                ElseIf vetorChave(i) = "6" Then
                    vetorChave(i) = "4"
                ElseIf vetorChave(i) = "7" Then
                    vetorChave(i) = "B"
                ElseIf vetorChave(i) = "8" Then
                    vetorChave(i) = "A"
                ElseIf vetorChave(i) = "9" Then
                    vetorChave(i) = "3"
                ElseIf vetorChave(i) = "A" Then
                    vetorChave(i) = "C"
                ElseIf vetorChave(i) = "B" Then
                    vetorChave(i) = "9"
                ElseIf vetorChave(i) = "C" Then
                    vetorChave(i) = "2"
                ElseIf vetorChave(i) = "D" Then
                    vetorChave(i) = "F"
                ElseIf vetorChave(i) = "E" Then
                    vetorChave(i) = "1"
                ElseIf vetorChave(i) = "F" Then
                    vetorChave(i) = "8"
                End If

            Next

            Criptografar_Chave = CStr(vetorChave)

        Catch ex As Exception

            Criptografar_Chave = ""

        End Try

    End Function

    Public Sub Descriptografar_Contra_Chave(ByRef vetorContraChave() As Char)

        Dim strContraChaveTemporaria As String
        Dim intIndicePar As Integer = 0
        Dim intIndiceImpar As Integer = 1
        strUUID = ""
        strGUID = ""

        If vetorContraChave.Length <> 64 Then Exit Sub

        strContraChaveTemporaria = vetorContraChave

        'Refaz a inversão entre UUID e GUID
        For i As Integer = 0 To vetorContraChave.Length - 1

            If i Mod 2 = 0 Then

                vetorContraChave(i) = strContraChaveTemporaria(intIndiceImpar)
                intIndiceImpar += 2

            ElseIf i Mod 2 = 1 Then

                vetorContraChave(i) = strContraChaveTemporaria(intIndicePar)
                intIndicePar += 2

            End If
        Next

        'Desfaz a conversão da tabela de contra-chave
        For i As Integer = 0 To vetorContraChave.Length - 1

            If vetorContraChave(i) = "4" Then
                vetorContraChave(i) = "0"
            ElseIf vetorContraChave(i) = "C" Then
                vetorContraChave(i) = "1"
            ElseIf vetorContraChave(i) = "8" Then
                vetorContraChave(i) = "2"
            ElseIf vetorContraChave(i) = "1" Then
                vetorContraChave(i) = "3"
            ElseIf vetorContraChave(i) = "F" Then
                vetorContraChave(i) = "4"
            ElseIf vetorContraChave(i) = "E" Then
                vetorContraChave(i) = "5"
            ElseIf vetorContraChave(i) = "2" Then
                vetorContraChave(i) = "6"
            ElseIf vetorContraChave(i) = "9" Then
                vetorContraChave(i) = "7"
            ElseIf vetorContraChave(i) = "B" Then
                vetorContraChave(i) = "8"
            ElseIf vetorContraChave(i) = "D" Then
                vetorContraChave(i) = "9"
            ElseIf vetorContraChave(i) = "5" Then
                vetorContraChave(i) = "A"
            ElseIf vetorContraChave(i) = "0" Then
                vetorContraChave(i) = "B"
            ElseIf vetorContraChave(i) = "7" Then
                vetorContraChave(i) = "C"
            ElseIf vetorContraChave(i) = "3" Then
                vetorContraChave(i) = "D"
            ElseIf vetorContraChave(i) = "A" Then
                vetorContraChave(i) = "E"
            ElseIf vetorContraChave(i) = "6" Then
                vetorContraChave(i) = "F"
            End If

        Next

        'Desfaz a conversão da tabela de chave
        For i As Integer = 0 To vetorContraChave.Length - 1

            If vetorContraChave(i) = "6" Then
                vetorContraChave(i) = "0"
            ElseIf vetorContraChave(i) = "E" Then
                vetorContraChave(i) = "1"
            ElseIf vetorContraChave(i) = "0" Then
                vetorContraChave(i) = "2"
            ElseIf vetorContraChave(i) = "5" Then
                vetorContraChave(i) = "3"
            ElseIf vetorContraChave(i) = "D" Then
                vetorContraChave(i) = "4"
            ElseIf vetorContraChave(i) = "7" Then
                vetorContraChave(i) = "5"
            ElseIf vetorContraChave(i) = "4" Then
                vetorContraChave(i) = "6"
            ElseIf vetorContraChave(i) = "B" Then
                vetorContraChave(i) = "7"
            ElseIf vetorContraChave(i) = "A" Then
                vetorContraChave(i) = "8"
            ElseIf vetorContraChave(i) = "3" Then
                vetorContraChave(i) = "9"
            ElseIf vetorContraChave(i) = "C" Then
                vetorContraChave(i) = "A"
            ElseIf vetorContraChave(i) = "9" Then
                vetorContraChave(i) = "B"
            ElseIf vetorContraChave(i) = "2" Then
                vetorContraChave(i) = "C"
            ElseIf vetorContraChave(i) = "F" Then
                vetorContraChave(i) = "D"
            ElseIf vetorContraChave(i) = "1" Then
                vetorContraChave(i) = "E"
            ElseIf vetorContraChave(i) = "8" Then
                vetorContraChave(i) = "F"
            End If

        Next

        For i As Integer = 0 To vetorContraChave.Length - 1

            If i Mod 2 = 0 Then

                strUUID = strUUID & vetorContraChave(i)

            Else

                strGUID = strGUID & vetorContraChave(i)

            End If

        Next

    End Sub

#End Region

    Public Function VerificarLicença() As Boolean

        Try

            Dim fso As Scripting.FileSystemObject
            Dim fluxoTexto As StreamReader
            Dim strContraChave As String
            Dim vetorContraChave(63) As Char

            fso = New Scripting.FileSystemObject

            'Escreve valores iniciais
            If Not fso.FileExists(My.Application.Info.DirectoryPath & "\Licença.dll") Then

                VerificarLicença = False
                blnLicença = False

                If MsgBox("A licença desse software não foi encontrada." & Chr(13) & "Deseja solicitar uma nova licença?", vbQuestion + vbYesNo, "Ativação do Software Pavitest") = vbYes Then

                    frmLicença.ShowDialog()

                    If blnLicença Then VerificarLicença = True

                End If

            Else

                fluxoTexto = New IO.StreamReader(My.Application.Info.DirectoryPath & "\Licença.dll")
                strContraChave = fluxoTexto.ReadLine.Replace("-", "")
                fluxoTexto.Close()
                vetorContraChave = strContraChave
                Descriptografar_Contra_Chave(vetorContraChave)

                If VerificarComputador(strUUID, strGUID) Then

                    VerificarLicença = True
                    blnLicença = True

                Else

                    VerificarLicença = False
                    blnLicença = False
                    If MsgBox("A licença desse software não foi encontrada." & Chr(13) & "Deseja solicitar uma nova licença?", vbQuestion + vbYesNo, "Ativação do Software Pavitest") = vbYes Then

                        frmLicença.ShowDialog()

                        If blnLicença Then VerificarLicença = True

                    End If

                End If

            End If

        Catch ex As Exception

            VerificarLicença = False
            blnLicença = False

        End Try

    End Function

    Public Function AvisoLicença() As Boolean

        Try

            Dim fso As Scripting.FileSystemObject
            Dim fluxoTexto As StreamReader
            Dim strContraChave As String
            Dim vetorContraChave(63) As Char

            fso = New Scripting.FileSystemObject

            'Escreve valores iniciais
            If Not fso.FileExists(My.Application.Info.DirectoryPath & "\Licença.dll") Then

                AvisoLicença = False
                blnLicença = False

            Else

                fluxoTexto = New IO.StreamReader(My.Application.Info.DirectoryPath & "\Licença.dll")
                strContraChave = fluxoTexto.ReadLine.Replace("-", "")
                fluxoTexto.Close()
                vetorContraChave = strContraChave
                Descriptografar_Contra_Chave(vetorContraChave)

                If VerificarComputador(strUUID, strGUID) Then

                    AvisoLicença = True
                    blnLicença = True

                Else

                    AvisoLicença = False
                    blnLicença = False

                End If

            End If

        Catch ex As Exception

            AvisoLicença = False
            blnLicença = False

        End Try

    End Function

End Class