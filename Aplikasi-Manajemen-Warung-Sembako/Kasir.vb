Imports System.Data.Odbc

Public Class Kasir
    Sub tampildata()
        konek()
        Try
            cmd = New OdbcCommand("select namabarang from gudang order by nogudang", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cmbnamabarang.Items.Add(dr("namabarang"))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        lbltanggal.Text = Today
    End Sub
End Class