Module mdlPortaSerial
    'Declarações de constantes e função API para detectar porta de comunicação no micro

    Structure DCB
        Dim DCBlength As Long
        Dim BaudRate As Long
        Dim fBitFields As Long
        Dim wReserved As Integer
        Dim XonLim As Integer
        Dim XoffLim As Integer
        Dim ByteSize As Byte
        Dim Parity As Byte
        Dim StopBits As Byte
        Dim XonChar As Byte
        Dim XoffChar As Byte
        Dim ErrorChar As Byte
        Dim EofChar As Byte
        Dim EvtChar As Byte
        Dim wReserved1 As Integer
    End Structure

    Structure COMMCONFIG
        Dim dwSize As Long
        Dim wVersion As Integer
        Dim wReserved As Integer
        Dim dcbx As DCB
        Dim dwProviderSubType As Long
        Dim dwProviderOffset As Long
        Dim dwProviderSize As Long
        Dim wcProviderData As Byte
    End Structure


    Declare Function GetDefaultCommConfig Lib "kernel32" Alias "GetDefaultCommConfigA" _
        (ByVal lpszName As String, ByVal lpCC As COMMCONFIG, ByVal lpdwSize As Long) As Long


End Module
