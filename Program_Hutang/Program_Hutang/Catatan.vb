Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Catatan
    Sub listview(Optional ByVal keyword As String = "")
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim id As String
        LV.View = View.Details
        LV.Columns.Add("No", 50)
        LV.Columns.Add("Pelanggan", 100)
        LV.Columns.Add("Hutang", 75)
        Call OpenKoneksi()
        id = "select * from catatan"
        If keyword.Trim <> "" Then
            id += " where pelanggan LIKE '%" & keyword & "%'"
        End If

        cmd = New SqlCommand(id, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            LV.Items.Add(dr("id"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("pelanggan"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("total"))
        Loop
        dr.Close()
        Call CloseKoneksi()
    End Sub
    Private Sub Catatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tbtambahhutang.Visible = False
        Tbupdatehutang.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        DateTimePicker1.Value = Now
        Tbid.Visible = False
        listview()
        Call OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Try
            Dim sql As String = "select * from pelanggan"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                Cbpelanggan.Items.Add(dr("nama"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            Call OpenKoneksi()
            Dim cd As SqlCommand
            Dim dt As SqlDataReader
            Dim sql1 As String = "select * from barang"
            cd = New SqlCommand(sql1, conn)
            dt = cd.ExecuteReader
            Do While dt.Read
                Cbbarang.Items.Add(dt(0) & "-" & dt(1) & "-" & dt(2) & "-" & dt(3))
            Loop
            dt.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Dim table As New DataTable("table")

    Private Sub Cbbarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbbarang.SelectedIndexChanged
        Dim h() As String
        Try
            h = Cbbarang.Text.Split("-") 'pecahkan
            Tbnamabarang.Text = Trim(h(2))
            Tbharga.Text = Trim(h(3))
            Tbqty.Text = "1"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub jumlahh()
        Dim x As Integer
        For line As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(line).Cells(4).Value
        Next
        Tbtotal.Text = x
    End Sub
    Sub DGVjumlah()
        Dim j As Double = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            j += Int(DataGridView1.Rows(i).Cells(4).Value)
        Next
        Tbtotal.Text = j
    End Sub
    Private Sub Btinput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btinput.Click
        If Cbpelanggan.Text = "" Then Exit Sub
        If Cbbarang.Text = "" Then Exit Sub
        Dim b() As String
        b = Cbbarang.Text.Split("-")
        Dim row() As String = New String() {b(1), b(2), b(3), Tbqty.Text, Int(Tbqty.Text) * Int(b(3))}
        DataGridView1.Rows.Add(row)
        DGVjumlah()
        jumlahh()
    End Sub

    Private Sub DataGridView1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CMS.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub CMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMSToolStripMenuItem.Click
        Dim index As Integer = DataGridView1.CurrentRow.Index
        'hapus baris terpilih
        If MsgBox("Hapus Baris ini?", vbYesNo, "Pesan") = vbYes Then
            DataGridView1.Rows.RemoveAt(index)
            DGVjumlah()
            jumlahh()
        End If
    End Sub
    Sub batal()
        Cbpelanggan.Text = ""
        DateTimePicker1.Value = Now
        Cbbarang.Text = ""
        Tbharga.Text = "0"
        Tbnamabarang.Text = ""
        Tbqty.Text = "0"
        Btsave.Text = "Simpan"
        Tbtambahhutang.Text = ""
        Tbupdatehutang.Text = ""
        Tbtotal.Text = "0"
        Tbid.Text = ""
        Cbpelanggan.Enabled = True
        Tbtambahhutang.Visible = False
        Tbupdatehutang.Visible = False
        DataGridView1.Rows.Clear()
    End Sub
    Private Sub Btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btsave.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim query As String = ""
        If Btsave.Text = "Simpan" Then
            Call OpenKoneksi()
            Dim query_id As String = "select MAX(id)+1 AS MXID From catatan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()
            query = "insert into catatan (id,pelanggan,total) values (" & uid & ",'" & Cbpelanggan.Text & "','" & Tbtotal.Text & "')"
            MsgBox("data'" + Cbpelanggan.Text + "' Telah di input")
        ElseIf Btsave.Text = "Update" Then
            Call OpenKoneksi()
            query = "update catatan set total='" & Tbupdatehutang.Text & "'where id='" & Tbid.Text & "'"
            MsgBox("data'" + Cbpelanggan.Text + "' Telah Menambah Hutangnya")
        End If
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Close()
        Call CloseKoneksi()
        batal()
        LV.Clear()
        listview()
    End Sub

    Private Sub Bttambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttambah.Click
        batal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim id As String
        Dim query As String
        id = LV.SelectedItems(0).Text
        Call OpenKoneksi()
        query = "select * from catatan where id='" + id + "'"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Tbid.Text = dr("id")
        Tbtambahhutang.Text = dr("total")
        Cbpelanggan.Text = dr("pelanggan")
        Tbtambahhutang.Visible = True
        Tbupdatehutang.Visible = True
        Label8.Visible = False
        Label9.Visible = False
        Btsave.Text = "Update"
        dr.Close()
    End Sub
    Private Sub Tbtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbtotal.TextChanged
        Tbupdatehutang.Text = Val(Tbtotal.Text) + Val(Tbtambahhutang.Text)
    End Sub

    Private Sub Btcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btcari.Click
        Dim keyword As String = Tbcari.Text
        LV.Clear()
        listview(keyword)
    End Sub
End Class