﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thankyou
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(thankyou))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(200, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(645, 45)
        Label1.TabIndex = 0
        Label1.Text = "THANKYOU FOR SHOPPING WITH US!!!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 199)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(484, 334)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SeaShell
        Label2.Font = New Font("Stencil", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(141, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(330, 94)
        Label2.TabIndex = 2
        Label2.Text = "SMART" & vbCrLf & "        BUYERZZZZ"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1116, 147)
        Panel1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(580, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(429, 38)
        Label3.TabIndex = 5
        Label3.Text = "YOUR ORDER WAS SUCCESSFULL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(547, 327)
        Label4.Name = "Label4"
        Label4.Size = New Size(498, 32)
        Label4.TabIndex = 5
        Label4.Text = "WE WOULD LOVE TO HEAR FROM YOU."
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(598, 391)
        Button1.Name = "Button1"
        Button1.Size = New Size(377, 78)
        Button1.TabIndex = 6
        Button1.Text = "GIVE FEEDBACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RosyBrown
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(868, 658)
        Button2.Name = "Button2"
        Button2.Size = New Size(257, 68)
        Button2.TabIndex = 7
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' thankyou
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(1113, 724)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "thankyou"
        Text = "THANKYOU"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class