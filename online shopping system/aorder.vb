Imports System.Data.SqlClient

Public Class aorder
    Dim connectionString As String = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
    Dim connection As New SqlConnection(connectionString)
    Dim adapter As New SqlDataAdapter()
    Dim dataSet As New DataSet()

    Private Sub aorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData("SELECT * FROM orders")
    End Sub

    Private Sub GetData(query As String)
        Try
            connection.Open()
            adapter.SelectCommand = New SqlCommand(query, connection)
            dataSet.Clear()
            adapter.Fill(dataSet, "orders")
            DataGridView1.DataSource = dataSet.Tables("orders")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        admdashboard.Show()
    End Sub
End Class