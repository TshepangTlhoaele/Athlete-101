﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(178, 97)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(178, 180)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 253)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 25)
        Label3.TabIndex = 2
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(178, 338)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 25)
        Label4.TabIndex = 3
        Label4.Text = "Enter Your Weight"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(178, 425)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(188, 25)
        Label5.TabIndex = 4
        Label5.Text = "Enter Your Height(m)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(294, 512)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 25)
        Label6.TabIndex = 5
        Label6.Text = "BMI"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Palatino Linotype", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(404, 9)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(167, 39)
        Label7.TabIndex = 6
        Label7.Text = "Athlete 101"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(166, 499)
        Button1.Margin = New Padding(5)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 38)
        Button1.TabIndex = 7
        Button1.Text = "Results for"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(393, 83)
        TextBox1.Margin = New Padding(5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(155, 33)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(393, 167)
        TextBox2.Margin = New Padding(5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(155, 33)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(393, 240)
        TextBox3.Margin = New Padding(5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(155, 33)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(393, 325)
        TextBox4.Margin = New Padding(5)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(155, 33)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(393, 412)
        TextBox5.Margin = New Padding(5)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(155, 33)
        TextBox5.TabIndex = 8
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(393, 500)
        TextBox6.Margin = New Padding(5)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(155, 33)
        TextBox6.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1257, 750)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox

End Class
