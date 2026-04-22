Option Strict Off
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

Friend Class clsConexao

#Region "CONECTAR E DESCONECTAR"

    Public Function Conectar() As OleDbConnection
        'Abrir a conexão com o banco de dados
        Dim strConexao As String

        strConexao = "Provider=Microsoft.Jet.OLEDB.4.0; " & _
                         "Data Source = " & strCaminho & "\" & strBaseDados

        Try
            If oConnection.State Then
                'Fechar conexão
                Desconectar()
            End If

            'Instância novamente o objeto de conexão
            oConnection.ConnectionString = strConexao

            'Abrir a conexão
            oConnection.Open()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Conectar" & Chr(13) & ex.Message)

        End Try

        Return oConnection

    End Function

    Public Sub Desconectar()
        'Fechar a conexão com o banco de dados

        Try
            'Fechar a conexão
            oConnection.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Desconectar" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "COMANDOS E CONSTRUÇÕES"

    Public Function AcrescentarColunaNaTabela(ByVal strNomeColuna As String, ByVal strNomeTabela As String) As Boolean
        'Acrescenta uma coluna/campo na tabela tblCP do BD

        Dim strSql As String

        Try
            strSql = "ALTER TABLE [" & strNomeTabela & "] ADD [" & strNomeColuna & "] TEXT(100);"

            Call ComandoExecucao(strSql)

            'Se o comando SQL foi corretamente executado
            If blnStatusExecucaoSQL Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            'Erro - Não existe a tabela
            AcrescentarColunaNaTabela = False
        End Try

    End Function
    Public Sub ComandoExecucao(ByVal strSql As String)
        'Comando de execução com o banco de dados
        Dim odbComando As OleDbCommand

        Try
            blnStatusExecucaoSQL = False
            'Comando do banco de dados
            odbComando = oConnection.CreateCommand
            'Comando select 
            odbComando.CommandText = strSql
            'Executar o comando sql 
            odbComando.ExecuteNonQuery()

            blnStatusExecucaoSQL = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ComandoExecucao" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Function ComandoLeitura(ByVal strSql As String) As OleDbDataReader
        'Comando de leitura do banco de dados
        Dim odbComando As OleDbCommand

        'Comando do banco de dados
        odbComando = oConnection.CreateCommand

        Try
            'Comando select 
            odbComando.CommandText = strSql

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ComandoLeitura" & Chr(13) & ex.Message)

        End Try

        'Executar o comando sql 
        Return odbComando.ExecuteReader

    End Function

    Public Function ExistirTabela(ByVal strTabela As String, ByVal blnApagar As Boolean) As Boolean
        'Verifica se a tabela existe senão retorna erro
        Dim strSql As String
        Dim odbComando As OleDbCommand
        Dim odbReader As OleDbDataReader

        Try
            'Faz a seleção da tabela do banco.
            strSql = "SELECT * FROM [" & strTabela & "]"

            'Comando do banco de dados
            odbComando = oConnection.CreateCommand
            'Comando select 
            odbComando.CommandText = strSql
            'Comando de leitura do banco de dados
            odbReader = odbComando.ExecuteReader()

            'Leitura
            odbReader.Read()
            'Fechar
            odbReader.Close()

            'Apagar
            If blnApagar Then
                strSql = "DROP TABLE [" & strTabela & "]"
                'Comando do banco de dados
                Call ComandoExecucao(strSql)
            End If

            ExistirTabela = True

        Catch ex As Exception
            'Erro - Não existe a tabela
            ExistirTabela = False

        End Try

    End Function

    Public Function ExistirColuna(ByVal strNomeColuna As String, ByVal strNomeTabela As String) As Boolean
        'Verifica se a tabela existe senão retorna erro
        Dim strSql As String
        Dim ds As New DataSet()

        Try
            Dim strConexao As String = "Provider=Microsoft.Jet.OLEDB.4.0; " & "Data Source = " & strCaminho & "\" & strBaseDados

            strSql = "SELECT * FROM " & strNomeTabela

            Dim da As New OleDbDataAdapter(strSql, strConexao)
            da.Fill(ds, strNomeTabela)

            If ds.Tables(0).Columns.Contains(strNomeColuna) Then
                ExistirColuna = True
            Else
                ExistirColuna = False
            End If

            da.Dispose()
            ds.Dispose()

        Catch ex As Exception
            'Erro - Não existe a tabela
            ExistirColuna = False
        End Try

    End Function

    Public Sub ConstruirSQL(ByVal strComando As String, ByVal strCampo As String, ByVal strValor As String)

        Try
            Select Case strComando
                Case cmd_CREATE
                    'Criar a tabela com seus campos
                    Call ConstruirSQL_Create(strCampo, strValor)

                Case cmd_INSERT
                    'Adicionar registro
                    Call ConstruirSQL_Insert(strCampo, strValor)

                Case cmd_UPDATE
                    'Atualizar registro
                    Call ConstruirSQL_Update(strCampo, strValor)

            End Select

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConstruirSQL" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub ConstruirSQL_Insert(ByVal strCampo As String, ByVal strValor As String)

        Try
            If strStruture_Campo <> "" And strStruture_Valor <> "" Then
                strStruture_Campo = strStruture_Campo & "," & strCampo
                strStruture_Valor = strStruture_Valor & ",'" & strValor & "'"

            Else
                strStruture_Campo = "(" & strCampo
                strStruture_Valor = " VALUES ('" & strValor & "'"

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConstruirSQL_Insert" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub ConstruirSQL_Update(ByVal strCampo As String, ByVal strValor As String)

        Try
            If strStruture_Campo <> "" Then
                If strCampo = "EnsaioRealizado" Then
                    strStruture_Campo = strStruture_Campo & "," & strCampo & "=" & strValor & ""
                Else
                    strStruture_Campo = strStruture_Campo & "," & strCampo & "='" & strValor & "'"
                End If


            Else

                strStruture_Campo = strCampo & "='" & strValor & "'"

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConstruirSQL_Update" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub ConstruirSQL_Create(ByVal strCampo As String, ByVal strValor As String)

        Try
            If strStruture_Campo <> "" Then
                strStruture_Campo = strStruture_Campo & "," & strCampo & " " & strValor

            Else
                strStruture_Campo = "(" & strCampo & " " & strValor

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ConstruirSQL_Create" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

End Class