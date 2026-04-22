Module mdlAPIs
    'Declaração de funções API

    'Copia figura

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Object) As Long


    Declare Function GetSystemMenu Lib "user32" _
        (ByVal hWnd As Long, ByVal bRevert As Long) As Long

    'Função controladora de tempo
    Declare Function timeGetTime Lib "winmm.dll" () As Long


    Declare Function MessageBox Lib "user32" Alias "MessageBoxA" _
        (ByVal hWnd As Long, ByVal lpText As String, ByVal lpCaption As String, ByVal wType As Long) As Long

    'Apaga botão X (Fechar do Windows)
    Declare Function DeleteMenu Lib "user32" _
        (ByVal hMenu As Long, ByVal nPosition As Long, ByVal wFlags As Long) As Long


    'Função para impedir de abrir o software mais de uma vez
    Declare Function OpenIcon Lib "user32" (ByVal hwnd As Long) As Long
    Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As Long) As Long


End Module
