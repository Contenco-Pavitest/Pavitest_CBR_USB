Partial Class dtsTabelas
    Partial Class dttImagensDataTable

        Private Sub dttImagensDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.LogotipoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
