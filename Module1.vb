Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Dim dbase As String = "it2cdb"
    Dim host As String = "127.0.0.1" 'ip address
    Dim user As String = "root"
    Dim pwd As String = "admin"
    Public Sub DataConnection()
        'check if connection exist
        If Not con Is Nothing Then
            con.Close() 'close connection establish connection string
            con.ConnectionString = "Server=" & host & ";user id=" & user & ";password=" & pwd & ";database=" & dbase & ""
            Try
                con.Open() 'open connection
                MsgBox("Connected")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Module
