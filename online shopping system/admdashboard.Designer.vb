<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admdashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Panel1 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        Usertotal = New Label()
        Panel3 = New Panel()
        ordertotal = New Label()
        Panel4 = New Panel()
        Button5 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(388, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(354, 45)
        Label1.TabIndex = 1
        Label1.Text = "ADMIN DASHBOARD"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(29, 205)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 426)
        Panel1.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Teal
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button4.Location = New Point(97, 333)
        Button4.Name = "Button4"
        Button4.Size = New Size(183, 58)
        Button4.TabIndex = 7
        Button4.Text = "HOME"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Teal
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button3.Location = New Point(97, 247)
        Button3.Name = "Button3"
        Button3.Size = New Size(183, 61)
        Button3.TabIndex = 6
        Button3.Text = "FEEDBACK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Teal
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button2.Location = New Point(97, 154)
        Button2.Name = "Button2"
        Button2.Size = New Size(183, 67)
        Button2.TabIndex = 5
        Button2.Text = "ORDER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, -9)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 38)
        Label2.TabIndex = 3
        Label2.Text = "MENU BAR"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button1.Location = New Point(97, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 63)
        Button1.TabIndex = 4
        Button1.Text = "USERS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(Usertotal)
        Panel2.Location = New Point(436, 333)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(308, 198)
        Panel2.TabIndex = 3
        ' 
        ' Usertotal
        ' 
        Usertotal.AutoSize = True
        Usertotal.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Usertotal.Location = New Point(72, 80)
        Usertotal.Name = "Usertotal"
        Usertotal.Size = New Size(193, 38)
        Usertotal.TabIndex = 4
        Usertotal.Text = "TOTAL USERS"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.Controls.Add(ordertotal)
        Panel3.Location = New Point(787, 333)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(308, 198)
        Panel3.TabIndex = 4
        ' 
        ' ordertotal
        ' 
        ordertotal.AutoSize = True
        ordertotal.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ordertotal.Location = New Point(72, 80)
        ordertotal.Name = "ordertotal"
        ordertotal.Size = New Size(217, 38)
        ordertotal.TabIndex = 4
        ordertotal.Text = "TOTAL ORDERS"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Teal
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(2, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1203, 145)
        Panel4.TabIndex = 5
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Black
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Location = New Point(3, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 2
        Button5.Text = "BACK"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' admdashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1201, 747)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "admdashboard"
        Text = "admdashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Usertotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ordertotal As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button5 As Button
End Class
