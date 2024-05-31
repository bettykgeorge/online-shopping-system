Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class admuser

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim statement As String
        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Please enter all the details")
        Else

            Dim existingRecordQuery As String = "SELECT COUNT(*) FROM reg WHERE phno = @phno OR email = @email"
            cmd = New SqlCommand(existingRecordQuery, con)
            cmd.Parameters.AddWithValue("@phno", TextBox3.Text)
            cmd.Parameters.AddWithValue("@email", TextBox4.Text)
            Dim existingRecordCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If existingRecordCount > 0 Then
                MessageBox.Show("A record with the same phone number or email already exists in the database")
            Else
                statement = "INSERT INTO reg (fname, lname, email, phno,password , usertype) VALUES (@fname, @lname, @email, @phno, @password, @usertype)"
                cmd = New SqlCommand(statement, con)
                cmd.Parameters.AddWithValue("@fname", TextBox1.Text)
                cmd.Parameters.AddWithValue("@lname", TextBox2.Text)
                cmd.Parameters.AddWithValue("@email", TextBox4.Text)
                cmd.Parameters.AddWithValue("@phno", TextBox3.Text)
                cmd.Parameters.AddWithValue("@password", TextBox6.Text)
                cmd.Parameters.AddWithValue("@usertype", ComboBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("User details entered successfully", MsgBoxStyle.Information, "Success")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox6.Clear()
            End If
        End If

        con.Close()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim stmt As String
        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()
        If (ComboBox2.Text = "") Then
            MessageBox.Show("Enter user id")
        Else
            stmt = "Select * From reg where id= '" & ComboBox2.Text & "'"
            cmd = New SqlCommand(stmt, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                ComboBox2.Text = dr.GetValue(6)
                TextBox1.Text = dr.GetValue(0)
                TextBox2.Text = dr.GetValue(1)
                TextBox4.Text = dr.GetValue(2)
                TextBox3.Text = dr.GetValue(3)
                TextBox6.Text = dr.GetValue(4)
                ComboBox1.Text = dr.GetValue(5)

            Else
                MsgBox("No records found")
            End If


        End If



        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim stmt As String

        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()
        If (ComboBox2.Text = "") Then
            MessageBox.Show("Please enter user id")
        Else


            If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "") Then
                MessageBox.Show("Please enter all the details")

            Else
                stmt = "update reg set fname= '" & TextBox1.Text & "',lname= '" & TextBox2.Text & "',email= '" & TextBox4.Text & "',phno= '" & TextBox3.Text & "',password= '" & TextBox6.Text & "',usertype= '" & ComboBox1.Text & "' WHERE id='" & ComboBox2.Text & "' "
                cmd = New SqlCommand(stmt, con)
                cmd.ExecuteNonQuery()
                MsgBox("record updated successfully", MsgBoxStyle.Information, "success")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox6.Clear()
            End If
        End If

        con.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim stmt As String

        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()
        If (ComboBox2.Text = "") Then
            MessageBox.Show("Enter user id")

        Else
            stmt = "DELETE FROM reg WHERE id= '" & ComboBox2.Text & "'"

            cmd = New SqlCommand(stmt, con)
            cmd.ExecuteNonQuery()
            MsgBox("user deleted successfully", MsgBoxStyle.Information, "success")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
        End If


        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admdashboard.Show()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only letters")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers")
        End If
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating
        Dim phoneNumber As String = TextBox3.Text.Trim()


        If phoneNumber.Length <> 10 OrElse Not IsNumeric(phoneNumber) Then
            MessageBox.Show("Phone number must be a 10-digit numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
    Private Sub FillComboBox()
        ' Open connection to the database
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=BETTY_KUNJUMON\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;Encrypt=False"
        con.Open()

        ' SQL query to select all id values from the reg table
        Dim query As String = "SELECT id FROM reg"

        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        ' Clear existing items from the ComboBox
        ComboBox2.Items.Clear()

        ' Add id values to the ComboBox
        While dr.Read()
            ComboBox2.Items.Add(dr("id").ToString())
        End While

        ' Close connection to the database
        con.Close()
    End Sub

    Private Sub admuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call FillComboBox function when the form loads
        FillComboBox()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim emailSuffix As String = "@gmail.com"
        Dim currentText As String = TextBox4.Text

        ' Check if the current text ends with "@gmail.com"
        If Not currentText.EndsWith(emailSuffix) Then
            ' If not, modify the text to end with "@gmail.com"
            If currentText.Contains("@") Then
                Dim atIndex As Integer = currentText.IndexOf("@")
                currentText = currentText.Substring(0, atIndex)
            End If
            TextBox4.Text = currentText & emailSuffix

            ' Move the caret to the end of the text
            TextBox4.SelectionStart = TextBox4.Text.Length
        End If
    End Sub
End Class



