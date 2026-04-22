
'Contenco Industria e Comercio Ltda.
'Projeto Pavitest
'Arquivo que determina a classe de inicializacao dos ajustes do fabricante. 
'Aqui está contido o tratamento de informacoes necessarias a cada inicializacao do programa

Option Strict Off
Option Explicit On

Friend Class clsInicializacao_Fabricante

    'Atributos gerais
    Private Const NomeArquivoIni As String = "\PavitestOption.ini"

    Public CELULACARGA_PLACA As String
    Public CELULACARGA_CANAL As String

    Public DESLOCAMENTO_PRENSA_PLACA As String
    Public DESLOCAMENTO_PRENSA_CANAL As String

    Public HABILITACAO_CARGA As String
    Public HABILITACAO_DESLOCAMENTO As String
    Public HABILITACAO_DADOS_PID As String

    'Funcoes da biblioteca API do Windows
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    '/////////////////////////////////////////////////////////////////////////////////////
    '////////////////////// FUNÇOES DE CRIAÇÃO DO ARQUIVO .INI ///////////////////////////

    Private Sub LeDisco()
        'Lê atributos relacionados ao projeto do disco
        Dim strAux As String 'Variavel utilizada para leitura dos atributos no disco


        'Lê CELULACARGA_PLACA
        strAux = Space(100)
        Call GetPrivateProfileString("-----------------INSTRUMENTOS------------------", "CELULACARGA_PLACA", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        CELULACARGA_PLACA = strAux

        'Lê CELULACARGA_CANAL
        strAux = Space(100)
        Call GetPrivateProfileString("-----------------INSTRUMENTOS------------------", "CELULACARGA_CANAL", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        CELULACARGA_CANAL = strAux

        'Lê DESLOCAMENTO_PRENSA_PLACA
        strAux = Space(100)
        Call GetPrivateProfileString("-----------------INSTRUMENTOS------------------", "DESLOCAMENTO_PRENSA_PLACA", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        DESLOCAMENTO_PRENSA_PLACA = strAux

        'Lê DESLOCAMENTO_PRENSA_CANAL
        strAux = Space(100)
        Call GetPrivateProfileString("-----------------INSTRUMENTOS------------------", "DESLOCAMENTO_PRENSA_CANAL", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        DESLOCAMENTO_PRENSA_CANAL = strAux

        'Lê HABILITACAO_CARGA
        strAux = Space(100)
        Call GetPrivateProfileString("-----------------INSTRUMENTOS------------------", "HABILITACAO_CARGA", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        HABILITACAO_CARGA = strAux

        'Lê HABILITACAO_DESLOCAMENTO
        strAux = Space(100)
        Call GetPrivateProfileString("-----------------INSTRUMENTOS------------------", "HABILITACAO_DESLOCAMENTO", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        HABILITACAO_DESLOCAMENTO = strAux

        'Lê HABILITACAO_DADOS_PID
        strAux = Space(100)
        Call GetPrivateProfileString("-----------------INSTRUMENTOS------------------", "HABILITACAO_DADOS_PID", My.Application.Info.DirectoryPath, strAux, Len(strAux), My.Application.Info.DirectoryPath & NomeArquivoIni)
        strAux = Left(strAux, InStr(strAux, Chr(0)) - 1)
        HABILITACAO_DADOS_PID = strAux

    End Sub

    Public Sub AtualizarDisco()
        'Escreve atributos relacionados ao projeto no arquivo

        Call WritePrivateProfileString("-----------------INSTRUMENTOS------------------", "CELULACARGA_PLACA", CStr(CELULACARGA_PLACA), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("-----------------INSTRUMENTOS------------------", "CELULACARGA_CANAL", CStr(CELULACARGA_CANAL), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("-----------------INSTRUMENTOS------------------", "DESLOCAMENTO_PRENSA_PLACA", CStr(DESLOCAMENTO_PRENSA_PLACA), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("-----------------INSTRUMENTOS------------------", "DESLOCAMENTO_PRENSA_CANAL", CStr(DESLOCAMENTO_PRENSA_CANAL), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("-----------------INSTRUMENTOS------------------", "HABILITACAO_CARGA", CStr(HABILITACAO_CARGA), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("-----------------INSTRUMENTOS------------------", "HABILITACAO_DESLOCAMENTO", CStr(HABILITACAO_DESLOCAMENTO), My.Application.Info.DirectoryPath & NomeArquivoIni)
        Call WritePrivateProfileString("-----------------INSTRUMENTOS------------------", "HABILITACAO_DADOS_PID", CStr(HABILITACAO_DADOS_PID), My.Application.Info.DirectoryPath & NomeArquivoIni)

    End Sub

    Public Sub Iniciar()
        'Inicializa, construindo o arquivo ini
        Dim fso As Scripting.FileSystemObject
        'Dim e As Object

        fso = New Scripting.FileSystemObject

        'Escreve valores iniciais
        If Not fso.FileExists(My.Application.Info.DirectoryPath & NomeArquivoIni) Then
            'Se não existir, cria com valores iniciais

            CELULACARGA_PLACA = "0"
            CELULACARGA_CANAL = "0"
            DESLOCAMENTO_PRENSA_PLACA = "1"
            DESLOCAMENTO_PRENSA_CANAL = "0" 'era valor 4 nas prensas anteriores

            HABILITACAO_CARGA = "True"
            HABILITACAO_DESLOCAMENTO = "True"
            HABILITACAO_DADOS_PID = "False"

            'Escreve pela primeira vez no arquivo ini
            Call AtualizarDisco()
        End If

        'Lê atributos do disco
        Call LeDisco()

    End Sub

End Class

