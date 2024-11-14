Imports MySql.Data.MySqlClient
Public Class Form1
    Dim sqlQuery As String
    Dim dTable As DataTable 'hold table record
    Dim dAdapter As MySqlDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataConnection() 'call Module Sub procedure
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Try
            sqlQuery = "select * from customer"
            'send the sql query command to server
            dAdapter = New MySqlDataAdapter(sqlQuery, con)
            dTable = New DataTable
            'fill the data table from mysql table
            dAdapter.Fill(dTable)
            'display data from dTable in datagridview
            DataInfo.DataSource = dTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
