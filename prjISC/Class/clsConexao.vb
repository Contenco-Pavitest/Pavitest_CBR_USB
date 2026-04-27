Option Strict Off
Option Explicit On

Imports System.Data
Imports System.Data.OleDb
Imports DAO

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

    Public Function ExisteColuna(ByVal strNomeColuna As String, ByVal strNomeTabela As String) As Boolean
        Dim comandoSql As String
        Dim ds As New DataSet()

        Try
            Dim strConexao As String = "Provider=Microsoft.Jet.OLEDB.4.0; " & "Data Source = " & strCaminho & "\" & strBaseDados
            comandoSql = "SELECT * From " & strNomeTabela
            Dim da As New OleDbDataAdapter(comandoSql, strConexao)
            da.Fill(ds, "tblCPs")

            If ds.Tables(0).Columns.Contains(strNomeColuna) Then
                ExisteColuna = True
            Else
                ExisteColuna = False
            End If

            da.Dispose()
            ds.Dispose()

        Catch ex As Exception
            ExisteColuna = False
        End Try
    End Function


    Public Function GetTipoColuna(coluna As String, tabela As String) As Type

        Dim schemaTable As DataTable = oConnection.GetSchema("Columns", New String() {Nothing, Nothing, tabela, coluna})

        ' Se o schema não retornar nenhuma linha, a coluna ou a tabela não existem.
        If schemaTable.Rows.Count = 0 Then
            Throw New ArgumentException($"A coluna '{coluna}' ou a tabela '{tabela}' não existem.")
        End If

        ' A coluna "DATA_TYPE" no schema contém um código numérico que representa o tipo de dado.
        ' O tipo deste valor é um OleDbType (se estiver usando OleDb).
        Dim tipoDb As OleDbType = CType(schemaTable.Rows(0)("DATA_TYPE"), OleDbType)

        Return GetDataTypeFromBD(tipoDb)

    End Function

    Private Function GetDataTypeFromBD(tipoDb As OleDbType) As Type

        ' Agora, mapeamos o tipo do banco de dados (OleDbType) para um System.Type do .NET
        Select Case tipoDb
            Case OleDbType.VarChar, OleDbType.LongVarChar, OleDbType.WChar, OleDbType.LongVarWChar, OleDbType.BSTR, OleDbType.Char
                Return GetType(String)

            Case OleDbType.Integer
                Return GetType(Integer) ' Equivalente a Int32

            Case OleDbType.SmallInt
                Return GetType(Short) ' Equivalente a Int16

            Case OleDbType.BigInt
                Return GetType(Long) ' Equivalente a Int64

            Case OleDbType.Single
                Return GetType(Single) ' Equivalente a float em C#

            Case OleDbType.Double, OleDbType.Currency
                Return GetType(Double)

            Case OleDbType.Decimal, OleDbType.Numeric
                Return GetType(Decimal)

            Case OleDbType.Date, OleDbType.DBDate, OleDbType.DBTimeStamp
                Return GetType(Date) ' Equivalente a DateTime em C#

            Case OleDbType.Boolean
                Return GetType(Boolean)

            Case OleDbType.Binary, OleDbType.LongVarBinary
                Return GetType(Byte())

            Case OleDbType.Guid
                Return GetType(Guid)

                ' Caso o tipo não esteja mapeado, lança uma exceção para evitar comportamento inesperado.
            Case Else
                Throw New ArgumentException($"O tipo de dado '{tipoDb}' não possui um mapeamento definido.")
        End Select
    End Function

    Public Function AdicionarColuna(ByVal strNomeColuna As String, ByVal strNomeTabela As String, ByVal tipoColuna As String) As Boolean
        Dim comandoSql As String

        Try

            comandoSql = "ALTER TABLE [" & strNomeTabela & "] ADD [" & strNomeColuna & "] " & tipoColuna & " ;"
            Call usrConexao.ComandoExecucao(comandoSql)

        Catch ex As Exception
            AdicionarColuna = False
            Throw New Exception(" AdicionarColuna() " & ex.Message)
        End Try
    End Function

    Public Function AlterarNomeColuna(strNomeTabela As String, strNovoNome As String, strNomeColuna As String) As Boolean

        'Não é possível alterar diretamente o nome da coluna via string SQL pois o provedor é versão inferior a 12.0
        Dim dbEngine As New DBEngine()
        Dim db As Database = dbEngine.OpenDatabase(String.Concat(strCaminho, $"\\{strBaseDados}"))

        Try
            db.TableDefs(strNomeTabela).Fields(strNomeColuna).Name = strNovoNome
            db.Close()

            Return True

        Catch ex As Exception
            MsgBox("AlterarNomeColuna" & Chr(13) & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeletarColuna(strNomeTabela As String, strNomeColuna As String) As Boolean

        Dim comandoSql = "ALTER TABLE  [" & strNomeTabela & "] DROP COLUMN " & strNomeColuna & ";"
        Try
            Call usrConexao.ComandoExecucao(comandoSql)
            Return True
        Catch ex As Exception
            MsgBox("DeletarColuna" & Chr(13) & ex.Message)
            Return False
        End Try
    End Function

#End Region

End Class