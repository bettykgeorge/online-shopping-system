Imports System.Data.SqlClient

Public Class adminlog
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        firstpage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()
        Dim stmt As String = "SELECT * FROM reg WHERE email = '" & email.Text & "' AND password = '" & password.Text & "' AND usertype= '1' "

        cmd = New SqlCommand(stmt, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            MessageBox.Show("ADMIN login success")
            Me.Hide()
            admdashboard.Show()
        Else
            MessageBox.Show("Invalid login credentials")
            password.Clear()

        End If
        con.Close()
    End Sub
End Class