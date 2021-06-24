Imports System.Data.Odbc
Public Class BukuHutang


    Sub bersih()
        txtnopelanggan.Text = ""
        txtnamapelanggan.Text = ""
        txthutang.Text = ""
        txtbayar.Text = ""
        txtnopelanggan.Focus()

    End Sub
    Sub tampildgvdata()
        konek()
        Dim da As New OdbcDataAdapter("Select * from tbl_pelanggan", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvpelanggan.DataSource = dt
    End Sub
    Private Sub BukuHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampildgvdata()
    End Sub

    Private Sub txtnopelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnopelanggan.KeyPress
        txtnopelanggan.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            konek()
            cmd = New OdbcCommand("Select * From tbl_pelanggan  where nopelanggan='" & txtnopelanggan.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("No pelanggan Tidak Ada, Silahkan coba lagi!")
                txtnopelanggan.Focus()
            Else

                txtnamapelanggan.Text = dr.Item("namapelanggan")
                txthutang.Text = dr.Item("hutang")

            End If
        End If
    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        konek()
        Dim edit As String = "update tbl_pelanggan set hutang='" & lblnominal.Text & "', keterangan='" & lbllunas.Text & "' where nopelanggan='" & txtnopelanggan.Text & "'"
        cmd = New OdbcCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        Call tampildgvdata()
        Call bersih()
    End Sub


    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim total As Integer
        total = Val(txthutang.Text) - Val(txtbayar.Text)
        lblnominal.Text = total
        If lblnominal.Text = 0 Then
            lbllunas.Text = "LUNAS"
        ElseIf lblnominal.Text > 0 Then
            lbllunas.Text = "BELUM"
        Else

        End If
    End Sub

    Private Sub btnpelanggan_Click(sender As Object, e As EventArgs) Handles btnpelanggan.Click
        Pelanggan.Show()
    End Sub
End Class