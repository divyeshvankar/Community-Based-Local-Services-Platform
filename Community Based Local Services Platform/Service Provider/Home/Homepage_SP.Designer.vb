﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage_SP
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
        Panel1 = New Panel()
        Panel6 = New Panel()
        Label5 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label6 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        Label1.Location = New Point(79, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(285, 35)
        Label1.TabIndex = 0
        Label1.Text = "Service Provider Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F)
        Label2.Location = New Point(79, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 1
        Label2.Text = "Location"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F)
        Label3.Location = New Point(180, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(254, 20)
        Label3.TabIndex = 2
        Label3.Text = "Services from 09:00 AM to 05:00 PM  "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F)
        Label4.Location = New Point(440, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 20)
        Label4.TabIndex = 3
        Label4.Text = "Experience"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(237), CByte(237), CByte(237))
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(953, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(416, 931)
        Panel1.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(17, 148)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(367, 655)
        Panel6.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        Label5.Location = New Point(17, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 30)
        Label5.TabIndex = 1
        Label5.Text = "Reviews"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label6.Location = New Point(148, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(26, 41)
        Label6.TabIndex = 5
        Label6.Text = "."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label7.Location = New Point(421, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(26, 41)
        Label7.TabIndex = 6
        Label7.Text = "."
        ' 
        ' SP_profile
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1371, 928)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SP_profile"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
