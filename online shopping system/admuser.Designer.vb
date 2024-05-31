<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admuser
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
        fname = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Lname = New Label()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        pass = New Label()
        TextBox6 = New TextBox()
        userttp = New Label()
        email = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        phno = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel2 = New Panel()
        ComboBox2 = New ComboBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(123, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(834, 45)
        Label1.TabIndex = 2
        Label1.Text = "USER DETAILS ADD,RETRIEVE,EDIT,UPDATE,DELETE"
        ' 
        ' fname
        ' 
        fname.AutoSize = True
        fname.Font = New Font("Segoe UI", 10F)
        fname.Location = New Point(71, 56)
        fname.Name = "fname"
        fname.Size = New Size(121, 28)
        fname.TabIndex = 3
        fname.Text = "FIRST NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlLight
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(223, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 34)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ControlLight
        TextBox2.Font = New Font("Segoe UI", 10F)
        TextBox2.Location = New Point(597, 62)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(211, 34)
        TextBox2.TabIndex = 6
        ' 
        ' Lname
        ' 
        Lname.AutoSize = True
        Lname.Font = New Font("Segoe UI", 10F)
        Lname.Location = New Point(445, 62)
        Lname.Name = "Lname"
        Lname.Size = New Size(117, 28)
        Lname.TabIndex = 5
        Lname.Text = "LAST NAME"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(pass)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(userttp)
        Panel1.Controls.Add(email)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(phno)
        Panel1.Controls.Add(fname)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Lname)
        Panel1.Location = New Point(24, 172)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(840, 347)
        Panel1.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ControlLight
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"0", "1"})
        ComboBox1.Location = New Point(587, 267)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(236, 33)
        ComboBox1.TabIndex = 14
        ' 
        ' pass
        ' 
        pass.AutoSize = True
        pass.Font = New Font("Segoe UI", 10F)
        pass.Location = New Point(71, 261)
        pass.Name = "pass"
        pass.Size = New Size(117, 28)
        pass.TabIndex = 11
        pass.Text = "PASSWORD"
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = SystemColors.ControlLight
        TextBox6.Font = New Font("Segoe UI", 10F)
        TextBox6.Location = New Point(223, 264)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(186, 34)
        TextBox6.TabIndex = 12
        ' 
        ' userttp
        ' 
        userttp.AutoSize = True
        userttp.Font = New Font("Segoe UI", 10F)
        userttp.Location = New Point(445, 267)
        userttp.Name = "userttp"
        userttp.Size = New Size(190, 56)
        userttp.TabIndex = 13
        userttp.Text = "USERTYPE" & vbCrLf & "(ADMIN=1,USER=0)"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(71, 158)
        email.Name = "email"
        email.Size = New Size(72, 25)
        email.TabIndex = 7
        email.Text = "EMAIL"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ControlLight
        TextBox3.Font = New Font("Segoe UI", 10F)
        TextBox3.Location = New Point(597, 164)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(211, 34)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ControlLight
        TextBox4.Font = New Font("Segoe UI", 10F)
        TextBox4.Location = New Point(223, 161)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(186, 34)
        TextBox4.TabIndex = 8
        ' 
        ' phno
        ' 
        phno.AutoSize = True
        phno.Font = New Font("Segoe UI", 10F)
        phno.Location = New Point(445, 164)
        phno.Name = "phno"
        phno.Size = New Size(112, 28)
        phno.TabIndex = 9
        phno.Text = "PHONE NO"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(0, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 8
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Teal
        Button2.Location = New Point(889, 172)
        Button2.Name = "Button2"
        Button2.Size = New Size(190, 63)
        Button2.TabIndex = 9
        Button2.Text = "ADD USER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Teal
        Button3.Location = New Point(889, 297)
        Button3.Name = "Button3"
        Button3.Size = New Size(190, 69)
        Button3.TabIndex = 10
        Button3.Text = "SEARCH USER"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Teal
        Button4.Location = New Point(889, 380)
        Button4.Name = "Button4"
        Button4.Size = New Size(190, 62)
        Button4.TabIndex = 12
        Button4.Text = "UPDATE USER"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Teal
        Button5.Location = New Point(889, 462)
        Button5.Name = "Button5"
        Button5.Size = New Size(190, 57)
        Button5.TabIndex = 13
        Button5.Text = "DELETE USER"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(-1, -5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1109, 136)
        Panel2.TabIndex = 14
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(889, 258)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(190, 33)
        ComboBox2.TabIndex = 15
        ' 
        ' admuser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1101, 610)
        Controls.Add(ComboBox2)
        Controls.Add(Panel2)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Name = "admuser"
        Text = "admuser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents fname As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Lname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pass As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents userttp As Label
    Friend WithEvents email As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents phno As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox2 As ComboBox
End Class
