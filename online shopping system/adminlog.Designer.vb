<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminlog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminlog))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        email = New TextBox()
        password = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(271, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 45)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN LOGIN PAGE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(12, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(242, 24)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME/EMAIL ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(42, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 24)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' email
        ' 
        email.Location = New Point(257, 213)
        email.Name = "email"
        email.Size = New Size(178, 31)
        email.TabIndex = 3
        ' 
        ' password
        ' 
        password.Location = New Point(257, 295)
        password.Name = "password"
        password.Size = New Size(178, 31)
        password.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(152, 423)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 50)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(-10, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 6
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(4, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(945, 130)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(491, 127)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(455, 454)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' adminlog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(945, 579)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(password)
        Controls.Add(email)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "adminlog"
        Text = "adminlog"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
