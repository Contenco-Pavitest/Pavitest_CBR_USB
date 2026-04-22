Imports System.Runtime.InteropServices
Imports System.Text

Public Class Read64bitRegistryFrom32bitApp

    Public Enum RegSAM
        QueryValue = &H1
        SetValue = &H2
        CreateSubKey = &H4
        EnumerateSubKeys = &H8
        Notify = &H10
        CreateLink = &H20
        WOW64_32Key = &H200
        WOW64_64Key = &H100
        WOW64_Res = &H300
        Read = &H20019
        Write = &H20006
        Execute = &H20019
        AllAccess = &HF003F
    End Enum

    Public NotInheritable Class RegHive
        Private Sub New()
        End Sub
        Public Shared HKEY_LOCAL_MACHINE As New UIntPtr(&H80000002UI)
        Public Shared HKEY_CURRENT_USER As New UIntPtr(&H80000001UI)
    End Class

    Public NotInheritable Class RegistryWOW6432
        Private Sub New()
        End Sub
#Region "Member Variables"
#Region "Read 64bit Reg from 32bit app"
        <DllImport("Advapi32.dll")> _
        Private Shared Function RegOpenKeyEx(ByVal hKey As UIntPtr, ByVal lpSubKey As String, ByVal ulOptions As UInteger, ByVal samDesired As Integer, ByRef phkResult As Integer) As UInteger
        End Function

        <DllImport("Advapi32.dll")> _
        Private Shared Function RegCloseKey(ByVal hKey As Integer) As UInteger
        End Function

        <DllImport("advapi32.dll", EntryPoint:="RegQueryValueEx")> _
        Public Shared Function RegQueryValueEx(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As UInteger, ByVal lpData As System.Text.StringBuilder, ByRef lpcbData As UInteger) As Integer
        End Function
#End Region
#End Region

#Region "Functions"
        Public Shared Function GetRegKey64(ByVal inHive As UIntPtr, ByVal inKeyName As [String], ByVal inPropertyName As [String]) As String
            Return GetRegKey64(inHive, inKeyName, RegSAM.WOW64_64Key, inPropertyName)
        End Function

        Public Shared Function GetRegKey32(ByVal inHive As UIntPtr, ByVal inKeyName As [String], ByVal inPropertyName As [String]) As String
            Return GetRegKey64(inHive, inKeyName, RegSAM.WOW64_32Key, inPropertyName)
        End Function

        Public Shared Function GetRegKey64(ByVal inHive As UIntPtr, ByVal inKeyName As [String], ByVal in32or64key As RegSAM, ByVal inPropertyName As [String]) As String
            Dim hkey As Integer = 0

            Try
                Dim lResult As UInteger = RegOpenKeyEx(RegHive.HKEY_LOCAL_MACHINE, inKeyName, 0, CInt(RegSAM.QueryValue) Or CInt(in32or64key), hkey)
                If 0 <> lResult Then
                    Return Nothing
                End If
                Dim lpType As UInteger = 0
                Dim lpcbData As UInteger = 1024
                Dim AgeBuffer As New StringBuilder(1024)
                RegQueryValueEx(hkey, inPropertyName, 0, lpType, AgeBuffer, lpcbData)
                Dim Age As String = AgeBuffer.ToString()
                Return Age
            Finally
                If 0 <> hkey Then
                    RegCloseKey(hkey)
                End If
            End Try
        End Function
#End Region

#Region "Enums"
#End Region
    End Class
End Class
