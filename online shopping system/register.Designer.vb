<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Label3 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold)
        Label3.Location = New Point(699, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 25)
        Label3.TabIndex = 28
        Label3.Text = "LAST NAME"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(936, 586)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(247, 31)
        TextBox5.TabIndex = 27
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(936, 469)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(247, 31)
        TextBox4.TabIndex = 26
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(936, 363)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(247, 31)
        TextBox3.TabIndex = 25
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(936, 241)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(247, 31)
        TextBox2.TabIndex = 24
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(936, 151)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 31)
        TextBox1.TabIndex = 23
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkCyan
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(885, 691)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 62)
        Button1.TabIndex = 22
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold)
        Label7.Location = New Point(701, 586)
        Label7.Name = "Label7"
        Label7.Size = New Size(147, 25)
        Label7.TabIndex = 21
        Label7.Text = "PASSWORD"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold)
        Label5.Location = New Point(701, 472)
        Label5.Name = "Label5"
        Label5.Size = New Size(205, 25)
        Label5.TabIndex = 20
        Label5.Text = "PHONE NUMBER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold)
        Label4.Location = New Point(703, 369)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 25)
        Label4.TabIndex = 19
        Label4.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold)
        Label2.Location = New Point(701, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 25)
        Label2.TabIndex = 18
        Label2.Text = "FIRST NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(304, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(592, 68)
        Label1.TabIndex = 17
        Label1.Text = "REGISTERATION PAGE"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1240, 121)
        Panel1.TabIndex = 29
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(0, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 36)
        Button2.TabIndex = 18
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 120)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(617, 684)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1224, 803)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Name = "register"
        Text = "register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
