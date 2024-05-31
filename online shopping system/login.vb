Imports System.Data.SqlClient
Imports System.DirectoryServices

Public Class Login


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()
        Dim stmt As String = "SELECT * FROM reg WHERE email = '" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "'"

        cmd = New SqlCommand(stmt, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            MessageBox.Show("you have logged in successfully")
            Me.Hide()
            home.Show()
        Else
            MessageBox.Show("Invalid login credentials")
            TextBox2.Clear()

        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        firstpage.Show()
    End Sub
End Class