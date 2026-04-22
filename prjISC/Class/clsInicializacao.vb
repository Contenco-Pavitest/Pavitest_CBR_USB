'Arquivo que determina a classe de inicializacao do sistema. Aqui está contido o tratamento de informacoes necessarias a cada inicializacao do programa

Option Explicit On

Public Class clsInicializacao
    'Contenco Industria e Comercio Ltda.
    'Projeto Pavitest ISC - (Índice de suporte califórnia)

#Region "DECLARAÇÕES"

    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    '
    'Atributos gerais
    Private Const NomeArquivoIni As String = "\PavitestISC.ini"

    Public ENDERECO_P1 As String
    Public ENDERECO_P2 As String

    Public PORTA As Long
    Public LOGOTIPO As String
    Public INTERVALO As Long
    Public AREAPISTAO As Double
    Public CALIBRACAO As Boolean

#End Region

    'Escalas das coordenadas do gráfico

#Region "LER ARQUIVO .INI E SALVAR NO ARQUIVO .INI"

    Private Sub LeDisco()
        'Le atributos relacionados ao projeto do disco
        Dim strAux As String    'Variavel utilizada para leitura dos atributos no disco
        Dim e As Integer

        'Lê ENDEREÇO P1
        strAux = Space(100)
        Call GetPrivateProfileString("Pavitest ISC", "ENDERECO_P1", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        ENDERECO_P1 = strAux

        'Lê ENDEREÇO P2
        strAux = Space(100)
        Call GetPrivateProfileString("Pavitest ISC", "ENDERECO_P2", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        ENDERECO_P2 = strAux

        'Le PORTA
        strAux = Space(100)
        Call GetPrivateProfileString("Pavitest ISC", "PORTA", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left$(strAux, InStr(strAux, Chr(0)) - 1)
        If IsNumeric(strAux) Then PORTA = CLng(strAux) Else PORTA = -1

        'Le LOGOTIPO
        strAux = Space(100)
        Call GetPrivateProfileString("Pavitest ISC", "LOGOTIPO", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left$(strAux, InStr(strAux, Chr(0)) - 1)
        LOGOTIPO = strAux

        'Le INTERVALO
        strAux = Space(100)
        Call GetPrivateProfileString("Pavitest ISC", "INTERVALO", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left$(strAux, InStr(strAux, Chr(0)) - 1)
        If IsNumeric(strAux) Then INTERVALO = CLng(strAux) Else INTERVALO = -1

        'Le ÁREA DO PISTÃO
        strAux = Space(100)
        Call GetPrivateProfileString("Pavitest ISC", "AREAPISTAO", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left$(strAux, InStr(strAux, Chr(0)) - 1)
        If IsNumeric(strAux) Then AREAPISTAO = CDbl(strAux) Else AREAPISTAO = -1

    End Sub

    Public Sub AtualizaDisco()
        'Escreve atributos relacionados ao projeto no arquivo
        Dim e As Long   'Contador de escalas

        'Escreve atributos
        Call WritePrivateProfileString("Pavitest ISC", "ENDERECO_P1", CStr(ENDERECO_P1), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("Pavitest ISC", "ENDERECO_P2", CStr(ENDERECO_P2), My.Application.Info.DirectoryPath & NomeArquivoIni)

        Call WritePrivateProfileString("Pavitest ISC", "PORTA", CStr(PORTA), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("Pavitest ISC", "LOGOTIPO", CStr(LOGOTIPO), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("Pavitest ISC", "INTERVALO", CStr(INTERVALO), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("Pavitest ISC", "AREAPISTAO", CStr(AREAPISTAO), My.Application.Info.DirectoryPath & NomeArquivoIni)

    End Sub

    Public Sub Iniciar()
        'Inicializa, construindo o arquivo ini
        Dim fso As Scripting.FileSystemObject
        Dim e

        Dim strDiretorioCompleto As String = My.Application.Info.DirectoryPath

        If (strDiretorioCompleto.Length) >= 99 Then
            usrInicializacao.ENDERECO_P1 = strDiretorioCompleto.Substring(0, 99)
            usrInicializacao.ENDERECO_P2 = strDiretorioCompleto.Substring(99, (strDiretorioCompleto.Length - 99))
        Else
            usrInicializacao.ENDERECO_P1 = strDiretorioCompleto
            usrInicializacao.ENDERECO_P2 = ""
        End If

        fso = New Scripting.FileSystemObject

        'Escreve valores iniciais
        If Not fso.FileExists(My.Application.Info.DirectoryPath & NomeArquivoIni) Then
            'Se não existir, cria com valores iniciais
            PORTA = 1
            LOGOTIPO = "False"
            INTERVALO = 500
            AREAPISTAO = 19.32


            'Escreve pela primeira vez no arquivo ini
            Call AtualizaDisco()
        End If

        'Le atributos do disco
        Call LeDisco()

    End Sub

#End Region

    Private Sub Class_Terminate_Renamed()
        'Termina a classe, escrevendo as configuracoes atuais
        AtualizaDisco()

    End Sub

End Class
