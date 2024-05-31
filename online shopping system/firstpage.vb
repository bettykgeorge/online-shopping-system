Public Class firstpage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        register.Show()
    End Sub

    Private Sub adminlogin_Click(sender As Object, e As EventArgs) Handles adminlogin.Click
        Me.Hide()
        adminlog.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Hide
        feedback.Show
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub


End Class
