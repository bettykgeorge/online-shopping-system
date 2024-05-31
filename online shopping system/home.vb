
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports online_shopping_system.details
Public Class home

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pqty1.Text = "" Then
            pqty1.Text = 1
        End If
        If pqty1.Text.Trim() = "" Then
            MessageBox.Show("Enter the quantity higher than 0.")
            pqty1.Focus()
        End If


        prod_name = pname1.Text
        prod_price = pprice1.Text
        prod_qty = pqty1.Text


        Me.Hide()
        checkout.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If pqty2.Text = "" Then
            pqty2.Text = 1
        End If
        If pqty2.Text.Trim() = "" Then
            MessageBox.Show("Enter the quantity.")
            pqty2.Focus()
        End If
        prod_name = pname2.Text
        prod_price = pprice2.Text
        prod_qty = pqty2.Text
        Me.Hide()
        checkout.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If pqty3.Text = "" Then
            pqty3.Text = 1
        End If
        If pqty3.Text.Trim() = "" Then
            MessageBox.Show("Enter the quantity.")
            pqty3.Focus()
        End If
        prod_name = pname3.Text
        prod_price = pprice3.Text
        prod_qty = pqty3.Text
        Me.Hide()
        checkout.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If pqty4.Text = "" Then
            pqty4.Text = 1
        End If
        If pqty4.Text.Trim() = "" Then
            MessageBox.Show("Enter the quantity.")
            pqty4.Focus()
        End If
        prod_name = pname4.Text
        prod_price = pprice4.Text
        prod_qty = pqty4.Text
        Me.Hide()
        checkout.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If pqty5.Text = "" Then
            pqty5.Text = 1
        End If
        If pqty5.Text.Trim() = "" Then
            MessageBox.Show("Enter the quantity.")
            pqty5.Focus()
        End If
        prod_name = pname5.Text
        prod_price = pprice5.Text
        prod_qty = pqty5.Text
        Me.Hide()
        checkout.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If pqty6.Text = "" Then
            pqty6.Text = 1
        End If
        If pqty6.Text.Trim() = "" Then
            MessageBox.Show("Enter the quantity.")
            pqty6.Focus()
        End If
        prod_name = pname6.Text
        prod_price = pprice6.Text
        prod_qty = pqty6.Text
        Me.Hide()
        checkout.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        firstpage.Show()
    End Sub



End Class
