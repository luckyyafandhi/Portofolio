Imports System.Data.SqlClient
Public Class Home
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Jam.Text = FormatDateTime(Now)
    End Sub

    Private Sub TambahCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tambah_Customer.MdiParent = Me
        Tambah_Customer.Show()
    End Sub
    Private Sub CatatanHutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatatanHutangToolStripMenuItem.Click
        Catatan.MdiParent = Me
        Catatan.Show()
    End Sub
    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Pembayaran.MdiParent = Me
        Pembayaran.Show()
    End Sub

    Private Sub TambahDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataToolStripMenuItem.Click
        Penjualan.MdiParent = Me
        Penjualan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        ListData.MdiParent = Me
        ListData.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        login.Show()
    End Sub

    Private Sub TambahCustomerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahCustomerToolStripMenuItem.Click
        Tambah_Customer.MdiParent = Me
        Tambah_Customer.Show()
    End Sub


    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        ListPelanggan.MdiParent = Me
        ListPelanggan.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Apakah Anda Yakin Ingin Logout?", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            Me.Close()
            login.Show()
            login.CBid.Text = ""
            login.TbPass.Text = ""
        End If
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        Ganti_Pass.MdiParent = Me
        Ganti_Pass.Show()
    End Sub
End Class
