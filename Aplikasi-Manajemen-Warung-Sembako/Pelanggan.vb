Imports System.Data.Odbc
Public Class Pelanggan
    Sub bersih()
        txtnopelanggan.Text = ""
        txtnamapelanggan.Text = ""
        txtalamat.Text = ""
        txtnotelp.Text = ""
    End Sub
    Sub tampildgvdata()
        konek()
        Dim da As New OdbcDataAdapter("Select * from tbl_pelanggan", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvpelanggan.DataSource = dt
    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersih()
        tampildgvdata()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtnopelanggan.Text = "" Or txtnamapelanggan.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Then
            MsgBox("Tidak Boleh Kosong")
            bersih()
        Else
            konek()
            Dim simpan As String = "insert into tbl_pelanggan values ('" & txtnopelanggan.Text & "','" & txtnamapelanggan.Text & "','" & txtalamat.Text & "','" & txtnotelp.Text & "','" & "0" & "', '" & "LUNAS" & "' )"
            cmd = New OdbcCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call tampildgvdata()
            Call bersih()
        End If
    End Sub

    Private Sub txtnopelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnopelanggan.KeyPress
        txtnopelanggan.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            konek()
            cmd = New OdbcCommand("Select * From tbl_pelanggan  where nopelanggan='" & txtnopelanggan.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("No Gudang Tidak Ada, Silahkan coba lagi!")
                txtnopelanggan.Focus()
            Else
                txtnamapelanggan.Focus()
                txtnamapelanggan.Text = dr.Item("namapelanggan")
                txtalamat.Text = dr.Item("alamatpelanggan")
                txtnotelp.Text = dr.Item("notelp")
                btnsimpan.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        konek()
        Dim edit As String = "update tbl_pelanggan set namapelanggan='" & txtnamapelanggan.Text & "',alamatpelanggan='" & txtalamat.Text & "',notelp='" & txtnotelp.Text & "' where nopelanggan='" & txtnopelanggan.Text & "'"
        cmd = New OdbcCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        Call tampildgvdata()
        Call bersih()
        btnsimpan.Enabled = True
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtnopelanggan.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan No Barang dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                konek()
                Dim hapus As String = "delete From tbl_pelanggan  where nopelanggan='" & txtnopelanggan.Text & "'"
                cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call tampildgvdata()
                Call bersih()
            End If
        End If
    End Sub
End Class