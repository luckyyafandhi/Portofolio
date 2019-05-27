Imports System.Data.SqlClient
Public Class Ganti_Pass

    Private Sub Ganti_Pass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim sql As String = "select * from login"
        cmd = New SqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            Cbid.Items.Add(dr("id"))
        Loop
        dr.Close()
        Call CloseKoneksi()
    End Sub
    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Call OpenKoneksi()
        If Tbpassbaru1.Text <> Tbpassbaru2.Text Then
            MsgBox("Password Tidak Sama", vbCritical, "Pesan")
        End If
        sql = "Update login set password='" & Tbpassbaru2.Text & "'where id='" & Cbid.Text & "'"
        cmd = New SqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Close()
        Call CloseKoneksi()
        MsgBox("Password" + Cbid.Text + "Telah Diganti")
    End Sub

    Private Sub Btcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btcancel.Click
        Home.Show()
        Me.Close()
    End Sub
End Class