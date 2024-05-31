
Imports System.Data.SqlClient

Public Class register

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim emailExists As Boolean = False
        Dim phoneExists As Boolean = False

        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()

        ' Check if any of the required fields are empty
        If TextBox1.Text = "" OrElse TextBox2.Text = "" OrElse TextBox3.Text = "" OrElse TextBox4.Text = "" OrElse TextBox5.Text = "" Then
            MessageBox.Show("Please enter all the details")
        Else
            ' Check if email already exists
            cmd = New SqlCommand("SELECT COUNT(*) FROM reg WHERE email = @Email", con)
            cmd.Parameters.AddWithValue("@Email", TextBox3.Text)
            If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                emailExists = True
                MessageBox.Show("Email already exists. Please use a different email.")
            End If

            ' Check if phone number already exists
            cmd = New SqlCommand("SELECT COUNT(*) FROM reg WHERE phno = @PhoneNumber", con)
            cmd.Parameters.AddWithValue("@PhoneNumber", TextBox4.Text)
            If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                phoneExists = True
                MessageBox.Show("Phone number already exists. Please use a different phone number.")
            End If

            If Not emailExists AndAlso Not phoneExists Then
                ' If neither email nor phone number exists, proceed with registration
                cmd = New SqlCommand("INSERT INTO reg VALUES (@fname, @lname, @Email, @phno, @password, '0')", con)
                cmd.Parameters.AddWithValue("@fname", TextBox1.Text)
                cmd.Parameters.AddWithValue("@lname", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Email", TextBox3.Text)
                cmd.Parameters.AddWithValue("@phno", TextBox4.Text)
                cmd.Parameters.AddWithValue("@password", TextBox5.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully registered", MsgBoxStyle.Information, "Success")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                Me.Hide()
                login.Show()
            End If
        End If

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        firstpage.Show()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only letters")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers")
        End If
    End Sub

    Private Sub TextBox4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox4.Validating
        Dim phoneNumber As String = TextBox4.Text.Trim()

        ' Check if the phone number has exactly 10 digits
        If phoneNumber.Length <> 10 OrElse Not IsNumeric(phoneNumber) Then
            MessageBox.Show("Phone number must be a 10-digit numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True ' Cancel the event to keep focus on the TextBox
        End If
    End Sub


End Class

