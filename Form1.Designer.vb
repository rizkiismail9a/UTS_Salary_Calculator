<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        InputName = New TextBox()
        InputMainSalary = New TextBox()
        Label2 = New Label()
        InputChild = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TotalSalary = New TextBox()
        Label5 = New Label()
        ButtonCount = New Button()
        ErroSalary = New Label()
        ErrorChild = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(69, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 45)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' InputName
        ' 
        InputName.Font = New Font("Segoe UI", 12F)
        InputName.Location = New Point(282, 66)
        InputName.Name = "InputName"
        InputName.Size = New Size(367, 50)
        InputName.TabIndex = 1
        ' 
        ' InputMainSalary
        ' 
        InputMainSalary.Font = New Font("Segoe UI", 12F)
        InputMainSalary.Location = New Point(282, 169)
        InputMainSalary.Name = "InputMainSalary"
        InputMainSalary.Size = New Size(367, 50)
        InputMainSalary.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(69, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 45)
        Label2.TabIndex = 2
        Label2.Text = "Gaji pokok"
        ' 
        ' InputChild
        ' 
        InputChild.Font = New Font("Segoe UI", 12F)
        InputChild.Location = New Point(282, 273)
        InputChild.Name = "InputChild"
        InputChild.Size = New Size(367, 50)
        InputChild.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(69, 278)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 45)
        Label3.TabIndex = 4
        Label3.Text = "Jumlah anak"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(688, 286)
        Label4.Name = "Label4"
        Label4.Size = New Size(226, 32)
        Label4.TabIndex = 6
        Label4.Text = "maksimal anak ke-3"
        ' 
        ' TotalSalary
        ' 
        TotalSalary.Enabled = False
        TotalSalary.Font = New Font("Segoe UI", 12F)
        TotalSalary.Location = New Point(282, 447)
        TotalSalary.Name = "TotalSalary"
        TotalSalary.Size = New Size(367, 50)
        TotalSalary.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(86, 452)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 45)
        Label5.TabIndex = 7
        Label5.Text = "Gaji total"
        ' 
        ' ButtonCount
        ' 
        ButtonCount.Location = New Point(688, 66)
        ButtonCount.Name = "ButtonCount"
        ButtonCount.Size = New Size(201, 153)
        ButtonCount.TabIndex = 9
        ButtonCount.Text = "Hitung"
        ButtonCount.UseVisualStyleBackColor = True
        ' 
        ' ErroSalary
        ' 
        ErroSalary.AutoSize = True
        ErroSalary.ForeColor = Color.Red
        ErroSalary.Location = New Point(439, 222)
        ErroSalary.Name = "ErroSalary"
        ErroSalary.Size = New Size(195, 32)
        ErroSalary.TabIndex = 10
        ErroSalary.Text = "Isi dengan angka"
        ErroSalary.Visible = False
        ' 
        ' ErrorChild
        ' 
        ErrorChild.AutoSize = True
        ErrorChild.ForeColor = Color.Red
        ErrorChild.Location = New Point(439, 336)
        ErrorChild.Name = "ErrorChild"
        ErrorChild.Size = New Size(195, 32)
        ErrorChild.TabIndex = 11
        ErrorChild.Text = "Isi dengan angka"
        ErrorChild.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(963, 633)
        Controls.Add(ErrorChild)
        Controls.Add(ErroSalary)
        Controls.Add(ButtonCount)
        Controls.Add(TotalSalary)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(InputChild)
        Controls.Add(Label3)
        Controls.Add(InputMainSalary)
        Controls.Add(Label2)
        Controls.Add(InputName)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InputName As TextBox
    Friend WithEvents InputMainSalary As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InputChild As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalSalary As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonCount As Button
    Friend WithEvents ErroSalary As Label
    Friend WithEvents ErrorChild As Label

End Class
