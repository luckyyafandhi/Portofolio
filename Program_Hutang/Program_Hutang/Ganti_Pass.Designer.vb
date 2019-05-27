<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ganti_Pass
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbid = New System.Windows.Forms.ComboBox()
        Me.Tbpasslama = New System.Windows.Forms.TextBox()
        Me.Tbpassbaru1 = New System.Windows.Forms.TextBox()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Btcancel = New System.Windows.Forms.Button()
        Me.Tbpassbaru2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ganti Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password lama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password Baru"
        '
        'Cbid
        '
        Me.Cbid.FormattingEnabled = True
        Me.Cbid.Location = New System.Drawing.Point(106, 62)
        Me.Cbid.Name = "Cbid"
        Me.Cbid.Size = New System.Drawing.Size(121, 21)
        Me.Cbid.TabIndex = 4
        '
        'Tbpasslama
        '
        Me.Tbpasslama.Location = New System.Drawing.Point(107, 89)
        Me.Tbpasslama.Name = "Tbpasslama"
        Me.Tbpasslama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tbpasslama.Size = New System.Drawing.Size(120, 20)
        Me.Tbpasslama.TabIndex = 5
        '
        'Tbpassbaru1
        '
        Me.Tbpassbaru1.Location = New System.Drawing.Point(107, 115)
        Me.Tbpassbaru1.Name = "Tbpassbaru1"
        Me.Tbpassbaru1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tbpassbaru1.Size = New System.Drawing.Size(120, 20)
        Me.Tbpassbaru1.TabIndex = 6
        '
        'Bsave
        '
        Me.Bsave.Location = New System.Drawing.Point(79, 167)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 7
        Me.Bsave.Text = "Simpan"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Btcancel
        '
        Me.Btcancel.Location = New System.Drawing.Point(167, 167)
        Me.Btcancel.Name = "Btcancel"
        Me.Btcancel.Size = New System.Drawing.Size(75, 23)
        Me.Btcancel.TabIndex = 8
        Me.Btcancel.Text = "Cancel"
        Me.Btcancel.UseVisualStyleBackColor = True
        '
        'Tbpassbaru2
        '
        Me.Tbpassbaru2.Location = New System.Drawing.Point(106, 141)
        Me.Tbpassbaru2.Name = "Tbpassbaru2"
        Me.Tbpassbaru2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tbpassbaru2.Size = New System.Drawing.Size(120, 20)
        Me.Tbpassbaru2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password Baru"
        '
        'Ganti_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 280)
        Me.Controls.Add(Me.Tbpassbaru2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btcancel)
        Me.Controls.Add(Me.Bsave)
        Me.Controls.Add(Me.Tbpassbaru1)
        Me.Controls.Add(Me.Tbpasslama)
        Me.Controls.Add(Me.Cbid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ganti_Pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ganti_Pass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cbid As System.Windows.Forms.ComboBox
    Friend WithEvents Tbpasslama As System.Windows.Forms.TextBox
    Friend WithEvents Tbpassbaru1 As System.Windows.Forms.TextBox
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Btcancel As System.Windows.Forms.Button
    Friend WithEvents Tbpassbaru2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
