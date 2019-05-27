<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembayaran
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembayaran))
        Me.Tbid = New System.Windows.Forms.TextBox()
        Me.Tbpelanggan = New System.Windows.Forms.TextBox()
        Me.Tbhutang = New System.Windows.Forms.TextBox()
        Me.Tbpembayaran = New System.Windows.Forms.TextBox()
        Me.Tbkembalian = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LV = New System.Windows.Forms.ListView()
        Me.Btbayar = New System.Windows.Forms.Button()
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tbid
        '
        Me.Tbid.Location = New System.Drawing.Point(195, 12)
        Me.Tbid.Name = "Tbid"
        Me.Tbid.Size = New System.Drawing.Size(32, 20)
        Me.Tbid.TabIndex = 0
        '
        'Tbpelanggan
        '
        Me.Tbpelanggan.Location = New System.Drawing.Point(79, 12)
        Me.Tbpelanggan.Name = "Tbpelanggan"
        Me.Tbpelanggan.Size = New System.Drawing.Size(110, 20)
        Me.Tbpelanggan.TabIndex = 1
        '
        'Tbhutang
        '
        Me.Tbhutang.Location = New System.Drawing.Point(79, 49)
        Me.Tbhutang.Name = "Tbhutang"
        Me.Tbhutang.Size = New System.Drawing.Size(110, 20)
        Me.Tbhutang.TabIndex = 2
        '
        'Tbpembayaran
        '
        Me.Tbpembayaran.Location = New System.Drawing.Point(79, 85)
        Me.Tbpembayaran.Name = "Tbpembayaran"
        Me.Tbpembayaran.Size = New System.Drawing.Size(110, 20)
        Me.Tbpembayaran.TabIndex = 3
        '
        'Tbkembalian
        '
        Me.Tbkembalian.Location = New System.Drawing.Point(79, 121)
        Me.Tbkembalian.Name = "Tbkembalian"
        Me.Tbkembalian.Size = New System.Drawing.Size(110, 20)
        Me.Tbkembalian.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hutang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pembayaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kembalian"
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(233, 12)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(276, 129)
        Me.LV.TabIndex = 9
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'Btbayar
        '
        Me.Btbayar.Location = New System.Drawing.Point(91, 147)
        Me.Btbayar.Name = "Btbayar"
        Me.Btbayar.Size = New System.Drawing.Size(75, 23)
        Me.Btbayar.TabIndex = 10
        Me.Btbayar.Text = "Bayar"
        Me.Btbayar.UseVisualStyleBackColor = True
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.DeleteToolStripMenuItem1})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(141, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DeleteToolStripMenuItem.Text = "Pembayaran"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 181)
        Me.Controls.Add(Me.Btbayar)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tbkembalian)
        Me.Controls.Add(Me.Tbpembayaran)
        Me.Controls.Add(Me.Tbhutang)
        Me.Controls.Add(Me.Tbpelanggan)
        Me.Controls.Add(Me.Tbid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tbid As System.Windows.Forms.TextBox
    Friend WithEvents Tbpelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Tbhutang As System.Windows.Forms.TextBox
    Friend WithEvents Tbpembayaran As System.Windows.Forms.TextBox
    Friend WithEvents Tbkembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents Btbayar As System.Windows.Forms.Button
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
