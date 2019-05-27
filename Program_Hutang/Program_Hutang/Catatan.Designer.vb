<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catatan))
        Me.Cbpelanggan = New System.Windows.Forms.ComboBox()
        Me.Cbbarang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbharga = New System.Windows.Forms.TextBox()
        Me.Tbqty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kodebarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btinput = New System.Windows.Forms.Button()
        Me.Btsave = New System.Windows.Forms.Button()
        Me.Bttambah = New System.Windows.Forms.Button()
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tbnamabarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbupdatehutang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tbtambahhutang = New System.Windows.Forms.TextBox()
        Me.Tbid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LV = New System.Windows.Forms.ListView()
        Me.Tbcari = New System.Windows.Forms.TextBox()
        Me.Btcari = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cbpelanggan
        '
        Me.Cbpelanggan.FormattingEnabled = True
        Me.Cbpelanggan.Location = New System.Drawing.Point(12, 22)
        Me.Cbpelanggan.Name = "Cbpelanggan"
        Me.Cbpelanggan.Size = New System.Drawing.Size(121, 21)
        Me.Cbpelanggan.TabIndex = 0
        '
        'Cbbarang
        '
        Me.Cbbarang.FormattingEnabled = True
        Me.Cbbarang.Location = New System.Drawing.Point(12, 59)
        Me.Cbbarang.Name = "Cbbarang"
        Me.Cbbarang.Size = New System.Drawing.Size(121, 21)
        Me.Cbbarang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Barang"
        '
        'Tbharga
        '
        Me.Tbharga.Location = New System.Drawing.Point(242, 59)
        Me.Tbharga.Name = "Tbharga"
        Me.Tbharga.Size = New System.Drawing.Size(100, 20)
        Me.Tbharga.TabIndex = 4
        '
        'Tbqty
        '
        Me.Tbqty.Location = New System.Drawing.Point(348, 59)
        Me.Tbqty.Name = "Tbqty"
        Me.Tbqty.Size = New System.Drawing.Size(44, 20)
        Me.Tbqty.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Qty"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(384, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(131, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2018, 10, 26, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tanggal"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodebarang, Me.namabarang, Me.harga, Me.qty, Me.jumlah})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(503, 126)
        Me.DataGridView1.TabIndex = 10
        '
        'kodebarang
        '
        Me.kodebarang.HeaderText = "Kode Barang"
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.ReadOnly = True
        '
        'namabarang
        '
        Me.namabarang.HeaderText = "Nama Barang"
        Me.namabarang.Name = "namabarang"
        Me.namabarang.ReadOnly = True
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'Tbtotal
        '
        Me.Tbtotal.Location = New System.Drawing.Point(402, 218)
        Me.Tbtotal.Name = "Tbtotal"
        Me.Tbtotal.Size = New System.Drawing.Size(113, 20)
        Me.Tbtotal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(329, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Hutang"
        '
        'Btinput
        '
        Me.Btinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btinput.Location = New System.Drawing.Point(421, 32)
        Me.Btinput.Name = "Btinput"
        Me.Btinput.Size = New System.Drawing.Size(94, 48)
        Me.Btinput.TabIndex = 13
        Me.Btinput.Text = "Input"
        Me.Btinput.UseVisualStyleBackColor = True
        '
        'Btsave
        '
        Me.Btsave.Location = New System.Drawing.Point(12, 218)
        Me.Btsave.Name = "Btsave"
        Me.Btsave.Size = New System.Drawing.Size(75, 23)
        Me.Btsave.TabIndex = 14
        Me.Btsave.Text = "Simpan"
        Me.Btsave.UseVisualStyleBackColor = True
        '
        'Bttambah
        '
        Me.Bttambah.Location = New System.Drawing.Point(93, 219)
        Me.Bttambah.Name = "Bttambah"
        Me.Bttambah.Size = New System.Drawing.Size(75, 23)
        Me.Bttambah.TabIndex = 15
        Me.Bttambah.Text = "Batal"
        Me.Bttambah.UseVisualStyleBackColor = True
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMSToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(108, 26)
        '
        'CMSToolStripMenuItem
        '
        Me.CMSToolStripMenuItem.Name = "CMSToolStripMenuItem"
        Me.CMSToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CMSToolStripMenuItem.Text = "Delete"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nama Barang"
        '
        'Tbnamabarang
        '
        Me.Tbnamabarang.Location = New System.Drawing.Point(139, 60)
        Me.Tbnamabarang.Name = "Tbnamabarang"
        Me.Tbnamabarang.Size = New System.Drawing.Size(100, 20)
        Me.Tbnamabarang.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Update Hutang"
        '
        'Tbupdatehutang
        '
        Me.Tbupdatehutang.Location = New System.Drawing.Point(402, 269)
        Me.Tbupdatehutang.Name = "Tbupdatehutang"
        Me.Tbupdatehutang.Size = New System.Drawing.Size(113, 20)
        Me.Tbupdatehutang.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Hutang"
        '
        'Tbtambahhutang
        '
        Me.Tbtambahhutang.Location = New System.Drawing.Point(402, 243)
        Me.Tbtambahhutang.Name = "Tbtambahhutang"
        Me.Tbtambahhutang.Size = New System.Drawing.Size(113, 20)
        Me.Tbtambahhutang.TabIndex = 21
        '
        'Tbid
        '
        Me.Tbid.Location = New System.Drawing.Point(139, 22)
        Me.Tbid.Name = "Tbid"
        Me.Tbid.Size = New System.Drawing.Size(44, 20)
        Me.Tbid.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(521, 32)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(300, 257)
        Me.LV.TabIndex = 25
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'Tbcari
        '
        Me.Tbcari.Location = New System.Drawing.Point(627, 9)
        Me.Tbcari.Name = "Tbcari"
        Me.Tbcari.Size = New System.Drawing.Size(113, 20)
        Me.Tbcari.TabIndex = 26
        '
        'Btcari
        '
        Me.Btcari.Location = New System.Drawing.Point(746, 7)
        Me.Btcari.Name = "Btcari"
        Me.Btcari.Size = New System.Drawing.Size(75, 23)
        Me.Btcari.TabIndex = 27
        Me.Btcari.Text = "Cari"
        Me.Btcari.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(596, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Cari"
        '
        'Catatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 301)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btcari)
        Me.Controls.Add(Me.Tbcari)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tbid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tbtambahhutang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tbupdatehutang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tbnamabarang)
        Me.Controls.Add(Me.Bttambah)
        Me.Controls.Add(Me.Btsave)
        Me.Controls.Add(Me.Btinput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tbtotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tbqty)
        Me.Controls.Add(Me.Tbharga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbbarang)
        Me.Controls.Add(Me.Cbpelanggan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Catatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catatan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbpelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents Cbbarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tbharga As System.Windows.Forms.TextBox
    Friend WithEvents Tbqty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents kodebarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namabarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btinput As System.Windows.Forms.Button
    Friend WithEvents Btsave As System.Windows.Forms.Button
    Friend WithEvents Bttambah As System.Windows.Forms.Button
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tbupdatehutang As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tbtambahhutang As System.Windows.Forms.TextBox
    Friend WithEvents Tbid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents Tbcari As System.Windows.Forms.TextBox
    Friend WithEvents Btcari As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
