Imports System.Data.SqlClient
Public Class Tambah_Customer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim query As String = ""
        If Button1.Text = "Simpan" Then
            Call OpenKoneksi()
            Dim query_id As String = "select MAX(id)+1 AS MXID From pelanggan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()
            query = "insert into pelanggan (id,nama,umur,alamat,email,ktp) values (" & uid & ",'" & Tbnama.Text & "','" & Tbumur.Text & "','" & Tbalamat.Text & "','" & Tbemail.Text & "','" & TbKTP.Text & "')"
            MsgBox("Data '" + Tbnama.Text + "'Telah Diinput")
        ElseIf Button1.Text = "Update" Then
            Call OpenKoneksi()
            query = "update pelanggan set nama='" & Tbnama.Text & "',umur='" & Tbumur.Text & "',alamat='" & Tbalamat.Text & "',email='" & Tbemail.Text & "',ktp='" & TbKTP.Text & "'where id='" & Tbid.Text & "'"
            MsgBox("Data'" + Tbnama.Text + "'Telah Diupdate")
        End If
        Try
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            bersih()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub
    Sub bersih()
        Tbid.Text = ""
        Tbnama.Text = ""
        Tbumur.Text = ""
        Tbalamat.Text = ""
        TbKTP.Text = ""
        Tbemail.Text = ""
        Button1.Text = "Simpan"
    End Sub

    Private Sub Tambah_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tbid.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class