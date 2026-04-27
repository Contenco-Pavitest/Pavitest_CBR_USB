Imports System.Data.OleDb

Public Class frmTransferenciaDados

    Function SelecionarBanco(titulo As String) As String
        Dim ofd As New OpenFileDialog()

        ofd.Title = titulo
        ofd.Filter = "Banco Access (*.accdb;*.mdb)|*.accdb;*.mdb"
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True

        If ofd.ShowDialog() = DialogResult.OK Then
            Return ofd.FileName
        End If

        Return ""
    End Function

    Sub TransferirTabela(nomeTabela As String)

        Dim connOrigem As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtCaminhoOrigem.Text & ";Mode=Share Deny None;")

        Dim origem = connOrigem

        connOrigem.Open()


        Dim cmdSelect As New OleDbCommand("SELECT * FROM [" & nomeTabela & "]", connOrigem)
        Dim reader As OleDbDataReader = cmdSelect.ExecuteReader()

        While reader.Read()
            Dim campos As New List(Of String)
            Dim valores As New List(Of String)

            For i = 0 To reader.FieldCount - 1
                campos.Add("[" & reader.GetName(i) & "]")
                valores.Add("?")
            Next

            Dim sql As String = "INSERT INTO [" & nomeTabela & "] (" & String.Join(",", campos) & ") VALUES (" & String.Join(",", valores) & ")"
            Dim cmdInsert As New OleDbCommand(sql, oConnection)

            For i = 0 To reader.FieldCount - 1
                cmdInsert.Parameters.AddWithValue("@", reader(i))
            Next

            cmdInsert.ExecuteNonQuery()
        End While

        reader.Close()
        connOrigem.Close()


    End Sub

    Function ContarCilindros(nomeTabela As String) As Integer
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtCaminhoOrigem.Text & ";Mode=Share Deny None;")

            conn.Open()

            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM [" & nomeTabela & "]", conn)
            Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            conn.Close()

            Return total

        Catch ex As Exception
            MsgBox("ContarCilindros" & ex.Message)
            Return 0
        End Try
    End Function

    Private Sub frmTransferenciaDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCilindro.Close()
        txtCaminhoDestino.Text = strBaseDados
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub btnBancoDestino_Click_1(sender As Object, e As EventArgs) Handles btnBancoDestino.Click
        Try
            txtCaminhoDestino.Text = SelecionarBanco("Selecione o Banco de Destino")

        Catch ex As Exception
            MsgBox("btnBancoDestino_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnBancoOrigem_Click_1(sender As Object, e As EventArgs) Handles btnBancoOrigem.Click
        Try
            txtCaminhoOrigem.Text = SelecionarBanco("Selecione o Banco de Origem")

        Catch ex As Exception
            MsgBox("btnBancoOrigem_Click" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub btnReplicarDados_Click(sender As Object, e As EventArgs) Handles btnReplicarDados.Click
        Try
            Dim tabela As String = "tblCilindro"
            Dim total As Integer = ContarCilindros(tabela)

            If total = 0 Then
                MsgBox("Nenhum registro encontrado para transferência.")
                Exit Sub
            End If

            Dim resposta = MsgBox("Serão transferidos " & total & " cilindro(s) cadastrados." & vbCrLf &
                          "Deseja continuar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmação")

            If resposta = MsgBoxResult.Yes Then
                TransferirTabela(tabela)
                MsgBox("Transferência concluída com sucesso!")
            Else
                MsgBox("Operação cancelada.")
            End If
        Catch ex As Exception
            MsgBox("btnReplicarDados_Click" & ex.Message)
        End Try
    End Sub
End Class