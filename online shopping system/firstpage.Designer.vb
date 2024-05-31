<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class firstpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(firstpage))
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        adminlogin = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(45, 269)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(431, 317)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkCyan
        Button2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Button2.Location = New Point(623, 485)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 84)
        Button2.TabIndex = 5
        Button2.Text = "REGITSER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Button1.Location = New Point(623, 282)
        Button1.Name = "Button1"
        Button1.Size = New Size(239, 94)
        Button1.TabIndex = 4
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' adminlogin
        ' 
        adminlogin.BackColor = Color.LightSeaGreen
        adminlogin.Location = New Point(-11, 674)
        adminlogin.Name = "adminlogin"
        adminlogin.Size = New Size(154, 52)
        adminlogin.TabIndex = 8
        adminlogin.Text = "ADMIN LOGIN"
        adminlogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1247, 190)
        Panel1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Handwriting", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(232, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(758, 41)
        Label2.TabIndex = 8
        Label2.Text = "WELCOME TO OUR SHOPPING PARADISE"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightSeaGreen
        Button3.Location = New Point(1106, 673)
        Button3.Name = "Button3"
        Button3.Size = New Size(141, 55)
        Button3.TabIndex = 10
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' firstpage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1242, 718)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(adminlogin)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "firstpage"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents adminlogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button

End Class
