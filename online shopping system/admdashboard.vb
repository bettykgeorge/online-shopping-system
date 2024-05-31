Imports System.Data.SqlClient
Public Class admdashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        admuser.Show()
    End Sub

    Private Sub admdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()

        'users data view

        Dim user_cmd As New SqlCommand
        Dim user_stmt As String
        Dim usertotalcount As String
        user_stmt = "SELECT count(*) FROM reg"
        user_cmd = New SqlCommand(user_stmt, con)
        usertotalcount = user_cmd.ExecuteScalar()
        Usertotal.Text = "Total users:" + usertotalcount

        'order data view

        Dim order_cmd As New SqlCommand
        Dim order_stmt As String
        Dim ordertotalcount As String
        order_stmt = "SELECT count(*) FROM orders"
        order_cmd = New SqlCommand(order_stmt, con)
        ordertotalcount = order_cmd.ExecuteScalar()
        ordertotal.Text = "Total orders:" + ordertotalcount
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        aorder.show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        feedbackreport.show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        home.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        firstpage.Show()
    End Sub
End Class