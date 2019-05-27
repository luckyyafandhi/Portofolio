Imports System.Data.SqlClient
Public Class ListPelanggan

    Sub list_view(Optional ByVal keyword As String = "")
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query_id As String
        LV.View = View.Details
        LV.Columns.Add("No", 50)
        LV.Columns.Add("Nama", 100)
        LV.Columns.Add("Umur", 50)
        LV.Columns.Add("Alamat", 150)
        LV.Columns.Add("Email", 100)
        LV.Columns.Add("No.KTP", 100)
        Call OpenKoneksi()
        query_id = "select * from pelanggan"
        If keyword.Trim <> "" Then
            query_id += " where nama LIKE '%" & keyword & "%'"
        End If
        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            LV.Items.Add(dr("id"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("nama"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("umur"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("alamat"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("email"))
            LV.Items(LV.Items.Count - 1).SubItems.Add(dr("ktp"))
        Loop
        dr.Close()
        Call CloseKoneksi()
    End Sub

    Private Sub ListPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Dim query As String = "delete from pelanggan where id='" + id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            LV.Clear()
            list_view()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LV.Refresh()
        LV.Clear()
        list_view()

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String
        id = LV.SelectedItems(0).Text
        Call OpenKoneksi()
        query = "select * from pelanggan where id='" + id + "'"
        cmd = New SqlCommand(query, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Tambah_Customer.Tbid.Text = dr("id")
        Tambah_Customer.Tbnama.Text = dr("nama")
        Tambah_Customer.Tbumur.Text = dr("umur")
        Tambah_Customer.Tbalamat.Text = dr("alamat")
        Tambah_Customer.Tbemail.Text = dr("email")
        Tambah_Customer.TbKTP.Text = dr("ktp")
        Tambah_Customer.Button1.Text = "Update"
        dr.Close()
        Call CloseKoneksi()
        Tambah_Customer.Show()
    End Sub

    Private Sub BtBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBack.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text
        LV.Clear()
        list_view(keyword)
    End Sub
End Class