﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(feedback))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 12F, FontStyle.Bold)
        Label1.Location = New Point(26, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 28)
        Label1.TabIndex = 0
        Label1.Text = "TITLE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 12F, FontStyle.Bold)
        Label2.Location = New Point(26, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 28)
        Label2.TabIndex = 1
        Label2.Text = "COMMENTS"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(212, 326)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(310, 166)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(320, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(289, 45)
        Label3.TabIndex = 4
        Label3.Text = "FEEDBACK FORM"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"EXCELLENT", "GOOD", "NEEDS IMPROVEMENT", "BAD", "OTHERS "})
        ComboBox1.Location = New Point(212, 216)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(310, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(170, 559)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 60)
        Button1.TabIndex = 6
        Button1.Text = "SUBMIT FEEDBACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1036, 145)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(541, 143)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(494, 539)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' feedback
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1036, 680)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "feedback"
        Text = "feedback"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
