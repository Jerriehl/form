Imports MySql.Data.MySqlClient
Public Class Form2
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim fullname, type, contact, address As String

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Dim sql As String
        fullname = txtfullname.Text
        type = txttype.Text
        address = txtaddress.Text
        contact = txtcontact.Text

        sql = "INSERT INTO customer(custName, custType, custAddress, custContact) VALUES( '" & fullname & "','" & type & "','" & address & "','" & contact & "')"


        Try


            With cmd
                .Connection = con
                .CommandText = sql
                'execute insert command
                result = .ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Inserted Successfully")
                    txtfullname.Clear()
                    txtaddress.Clear()
                    txtcontact.Clear()
                    txttype.Clear()
                Else
                    MsgBox("Insertion Failed")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        DataConnection()

    End Sub
End Class