Option Strict Off
Option Explicit On

Imports System.IO.Ports

Friend Class clsPortaSerial
    'Arquivo que trata abrir e fechar porta serial

    Public Function AbrirPorta(ByRef objPorta As SerialPort) As Boolean
        'Entrada:
        ' objPorta - porta de comunicacao serial do VB aberta e configurada
       
        'Abrir porta de comunicacao serial
        Try
            objPorta.Close()
            objPorta.PortName = "COM" & CStr(usrInicializacao.PORTA)
            objPorta.Open()

            AbrirPorta = True
            blnPortaCOMFechada = False

        Catch ex As Exception
            AbrirPorta = False
            'Mensagem de erro
            If intTentativaAbrirPorta >= 1 Then
                strErro_Porta_Comunicacao = ex.Message
                Throw New Exception("AbrirPorta( )" & Chr(13) & ex.Message)
            End If
        End Try

    End Function

    Public Function FecharPorta(ByRef objPorta As SerialPort) As Boolean
        'Saída:
        ' objPorta - porta de comunicacao serial do VB fechada
       
        'Fechar porta de comunicacao serial
        Try
            objPorta.Close()
            FecharPorta = True
            blnPortaCOMFechada = True

        Catch ex As Exception
            FecharPorta = False
            'Mensagem de erro
            MsgBox("FecharPorta" & Chr(13) & ex.Message)

        End Try

    End Function

    Public Sub Abrir_Porta_Comunicacao(ByRef objPorta As SerialPort)

        Try

Tentativas_Abrir_Porta:
            'Abrir porta serial 
            Call AbrirPorta(objPorta)

            If objPorta.IsOpen = False Then
                If intTentativaAbrirPorta < 1 Then
                    intTentativaAbrirPorta = intTentativaAbrirPorta + 1
                    GoTo Tentativas_Abrir_Porta
                Else
                    intTentativaAbrirPorta = 0
                End If
            Else
                intTentativaAbrirPorta = 0
                strErro_Porta_Comunicacao = ""
            End If

        Catch ex As Exception
            'Mensagem de erro
            Throw New Exception("Abrir_Porta_Comunicacao( )" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub Barra_de_Progresso(ByVal barStatus As ProgressBar)
        Try

            Dim stopwatch As Stopwatch = stopwatch.StartNew()

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 10

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 20

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 30

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 50

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 60

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 75

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 85

            System.Threading.Thread.Sleep(250)

            barStatus.Value = 100

            stopwatch.Stop()

            barStatus.Enabled = False

            barStatus.Value = 0

            barStatus.Visible = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Barra_de_Progresso" & Chr(13) & ex.Message)
        End Try

    End Sub

End Class