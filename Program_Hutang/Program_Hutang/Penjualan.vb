Imports System.Data.SqlClient
Public Class Penjualan


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim query As String = ""
        If Button1.Text = "Simpan" Then
            Call OpenKoneksi()
            Dim query_id As String = "select MAX(id)+1 AS MXID From barang"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()
            query = "insert into barang (id,kode,namabarang,harga,qty) values (" & uid & ",'" & Tbkode.Text & "','" & Tbnamabarang.Text & "','" & Tbharga.Text & "','" & Tbqty.Text & "')"
            MsgBox("Data '" + Tbnamabarang.Text + "'Telah Diinput")
        ElseIf Button1.Text = "Update" Then
            Call OpenKoneksi()
            query = "update barang set kode='" & Tbkode.Text & "',namabarang='" & Tbnamabarang.Text & "',harga='" & Tbharga.Text & "',qty='" & Tbqty.Text & "'where id='" & Tbid.Text & "'"
            MsgBox("Data '" + Tbnamabarang.Text + "'Telah DiUpdate")
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
        Tbkode.Text = ""
        Tbnamabarang.Text = ""
        Tbharga.Text = ""
        Tbqty.Text = ""
        Button1.Text = "Simpan"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bersih()
        Me.Close()
    End Sub

    Private Sub Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tbid.Visible = False
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class