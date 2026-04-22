'Arquivo que determina o controle da máquina

Option Explicit On

Public Class clsComandos
    'Contenco Industria e Comercio Ltda.
    'Projeto Pavitest
    '
    Public ErroComando As Boolean


    Public Sub ControleMaquina(ByRef objCom As Object, ByVal intComando As Integer)
        'Envia comandos para a máquina
        Dim strPalavra As String
        Dim strPalavraFiltrada As String
        Dim strLixo As String

        Try

            ErroComando = True

            'Comandos da máquina
            Select Case intComando

                Case COMANDO_INCREMENTAR
                    'Enviar a palavra de leitura
                    'objCom.Write(":ISS" & Chr(13))
                    'objCom.Write("slav" & ":ISS" & Chr(10))
                    'objCom.Write("srel0" & Chr(10))
                    objCom.Write("sobe" & Chr(10))
                Case COMANDO_DECREMENTAR
                    'Enviar a palavra de leitura
                    'objCom.Write(":ISD" & Chr(13))
                    'objCom.Write("slav" & ":ISD" & Chr(10))
                    '            objCom.Write("rrel2" & Chr(10))
                    '            'Espera resposta
                    '            Call System.Threading.Thread.Sleep(40)
                    '            'Limpa porta serial
                    '            strLixo = objCom.ReadExisting()
                    '            objCom.Write("srel1" & Chr(10))

                    objCom.Write("desc" & Chr(10))

                Case COMANDO_PARAR
                    'Enviar a palavra de leitura
                    objCom.Write(":ISP" & Chr(13))
                    objCom.Write("slav" & ":ISP" & Chr(10))
                    objCom.Write("rrel0" & Chr(10))
                    objCom.Write("para" & Chr(10))
            End Select

            'Espera resposta
            Call System.Threading.Thread.Sleep(40)

            'Resposta
            strPalavra = objCom.ReadExisting()

            If Len(strPalavra) <> 0 Then
                If Len(strPalavra) = 8 Then
                    strPalavraFiltrada = Mid(strPalavra, 2, 4)

                    Select Case intComando
                        Case COMANDO_INCREMENTAR
                            If strPalavraFiltrada = "sobe" Then ErroComando = False
                        Case COMANDO_DECREMENTAR
                            If strPalavraFiltrada = "desc" Then ErroComando = False
                        Case COMANDO_PARAR
                            If strPalavraFiltrada = "para" Then ErroComando = False
                    End Select

                Else

                    If intErro_Leitura_Slav > 2 Then
                        intErro_Leitura_Slav = 0
                        blnErro_Leitura_Slav = True
                        Exit Sub
                    Else
                        intErro_Leitura_Slav = 1 + intErro_Leitura_Slav
                        'Call usrComandos.ControleMaquina(objCom, intComando)
                        Exit Sub
                    End If

                End If
            End If

        Catch ex As Exception

            'Err.Clear
            If blnJaFechouPorta = True Then Exit Sub

            'Mensagem de erro
            strErro_Porta_Comunicacao = ex.Message
            MsgBox("ControleMaquina" & Chr(13) & ex.Message)
            'Call usrDiversos.ExibeErros("Comando_Resposta_N1500" & Chr(13) & "Erro número: " & Err.Number & Chr(13) & "Descrição: " & ex.Message)

            If (objCom.PortOpen = False) Or (Err.Number = 57) Then
                intErroNumber = Err.Number
                Call usrDiversos.FinalizarComunicacao()
                Exit Sub
            End If

        End Try
    End Sub

End Class
