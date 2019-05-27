Imports System.Data.SqlClient
Public Class Pembayaran
    Sub listview()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim id As String
        LV.View = View.Details
        LV.Columns.Add("No", 50)
        LV.Columns.Add("Pelanggan", 100)
        LV.Columns.Add("Hutang", 75)
        Call OpenKoneksi()
        id = "select * from catatan"
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

    Private Sub Pembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listview()
        Tbpelanggan.Enabled = False
        Tbid.Visible = False
        Tbhutang.Enabled = False
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
        Tbhutang.Text = dr("total")
        Tbpelanggan.Text = dr("pelanggan")
        dr.Close()
    End Sub

    Private Sub Btbayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btbayar.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String = "update catatan set total='" & Tbkembalian.Text & "'where id='" & Tbid.Text & "'"
        MessageBox.Show("Terima Kasih Telah Membayar Hutang Anda")
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Close()
        LV.Clear()
        listview()
        bersih()
    End Sub
    Sub bersih()
        Tbid.Text = ""
        Tbpelanggan.Text = ""
        Tbhutang.Text = ""
        Tbpembayaran.Text = ""
        Tbkembalian.Text = ""
    End Sub
    Private Sub Tbpembayaran_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tbpembayaran.KeyUp
        Tbkembalian.Text = Val(Tbhutang.Text) - Val(Tbpembayaran.Text)
    End Sub

    Private Sub LV_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseDown
       If e.Button = Windows.Forms.MouseButtons.Right Then
            CMS.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Anda Yakin Ingin Menghapusnya?", vbYesNo) = MsgBoxResult.Yes Then
            id = LV.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "delete from catatan where id='" + id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            LV.Clear()
            listview()
        End If
    End Sub
End Class