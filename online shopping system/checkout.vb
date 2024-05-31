Imports System.Data.SqlClient
Imports online_shopping_system.details
Public Class checkout

    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox9.Text = prod_name
        TextBox10.Text = prod_price
        TextBox11.Text = prod_qty
        TextBox12.Text = (prod_price * prod_qty)
        Label17.Visible = False
        TextBox13.Visible = False
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "CARD" Then
            Label17.Visible = True
            TextBox13.Visible = True
        Else
            Label17.Visible = False
            TextBox13.Visible = False
        End If

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim stmt As String
        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MessageBox.Show("Please enter all the required fields")
        Else
            If ComboBox1.Text = "CARD" Then
                If TextBox13.Text <> "" Then
                    stmt = "INSERT INTO orders values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & ComboBox1.Text & "','" & TextBox13.Text & "')"
                    cmd = New SqlCommand(stmt, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Your order has been placed", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    thankyou.Show()

                End If
            Else
                stmt = "INSERT INTO orders values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & ComboBox1.Text & "','" & TextBox13.Text & "')"
                cmd = New SqlCommand(stmt, con)
                cmd.ExecuteNonQuery()
                MsgBox("Your order has been placed", MsgBoxStyle.Information, "Success")
                Me.Hide()
                thankyou.Show()

            End If
        End If

        con.Close()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        home.Show()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only letters")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress, TextBox8.KeyPress, TextBox13.KeyPress
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