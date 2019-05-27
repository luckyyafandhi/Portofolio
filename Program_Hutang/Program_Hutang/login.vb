Imports System.Data.SqlClient
Public Class login
    Sub bersih()
        CBID.Text = ""
        TBPass.Text = ""
        CBID.Focus()
    End Sub
    Sub login()
        Call OpenKoneksi()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        conn.Close()
        Call OpenKoneksi()
        If CBid.Text = "" And TbPass.Text = "" Then
            MsgBox("Silahkan Isi Username dan passwordnya!", vbInformation, "pesan")
        Else
            sql = "select * from login where id='" & CBid.Text & "'and password='" & TbPass.Text & "'"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                Home.Show()
                Me.Hide()
                dr.Close()
            Else
                MsgBox("Harap Input Dengan Benar", vbCritical, "Pesan")
            End If
        End If
    End Sub
    Sub panggil_id()
        OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String = "select * from login"
        cmd = New SqlCommand(strsql, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            CBid.Items.Add(dr("id"))
        Loop
        dr.Close()
        Call CloseKoneksi()
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggil_id()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        login()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class