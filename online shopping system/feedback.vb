Imports System.Data.SqlClient

Public Class feedback


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim stmt As String

        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()

        If ComboBox1.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("All fields are mandatory")
        Else
            stmt = "INSERT into feedback values('" & ComboBox1.Text & "','" & TextBox1.Text & "')"
            cmd = New SqlCommand(stmt, con)
            cmd.ExecuteNonQuery()
            MsgBox("Thankyou for your feedback", MsgBoxStyle.Information, "success")
        End If




        con.Close()
        Me.Hide()
        thankyou.Show()
    End Sub




End Class