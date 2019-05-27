Imports System.Data.SqlClient
Public Class ListData
    Sub list_view(Optional ByVal keyword As String = "")
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LV.View = View.Details
        LV.Columns.Add("No", 50)
        LV.Columns.Add("Kode Barang", 100)
        LV.Columns.Add("Nama Barang", 100)
        LV.Columns.Add("Harga", 50)
        LV.Columns.Add("Qty", 50)
        Call OpenKoneksi()
        Dim query_id As String = "select * from barang"
        If keyword <> "" Then
            query_id += " where namabarang LIKE '%" & keyword & "%'"
        End If

        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            LV.Items.Add(dr("id"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("kode"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("namabarang"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("harga"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("qty"))
        Loop
        dr.Close()
        Call CloseKoneksi()
    End Sub

    Private Sub ListData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        list_view()
    End Sub

    Private Sub LV_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Anda Yakin Ingin Menghapusnya?", vbYesNo) = MsgBoxResult.Yes Then
            id = LV.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "delete from barang where id='" + id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            LV.Clear()
            list_view()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String
        id = LV.SelectedItems(0).Text
        Call OpenKoneksi()
        query = "select * from barang where id='" + id + "'"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Penjualan.Tbid.Text = dr("id")
        Penjualan.Tbkode.Text = dr("kode")
        Penjualan.Tbnamabarang.Text = dr("namabarang")
        Penjualan.Tbharga.Text = dr("harga")
        Penjualan.Tbqty.Text = dr("qty")
        Penjualan.Button1.Text = "Update"

        Penjualan.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LV.Refresh()
        LV.Clear()
        list_view()
    End Sub

    Private Sub Btback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btback.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text
        LV.Clear()
        list_view(keyword)
    End Sub
End Class