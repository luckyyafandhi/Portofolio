Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Module Koneksi
    Public comSQl As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection

    Public str As String = "Data Source=DESKTOP-2067H0G;" & _
                            "Initial Catalog=dbhutang;" & _
                            "Persist Security Info=True;" & _
                            "UID=sa;PWD=admin"
    Public Sub OpenKoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Anda Gagal Dibuka" & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub CloseKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Koneksi Anda Eror " & ex.ToString)
            End Try
        End If
    End Sub
End Module
