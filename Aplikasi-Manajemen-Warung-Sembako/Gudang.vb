Imports System.Data.Odbc
Public Class Gudang

    Sub listsatuan()
        cmbsatuan.Items.Clear()
        cmbsatuan.Items.Add("pcs")
        cmbsatuan.Items.Add("kardus")
        cmbsatuan.Items.Add("liter")
        cmbsatuan.Items.Add("kg")
        cmbsatuan.Text = "Pilih Salah Satu"
    End Sub
    Sub bersih()
        txnobarang.Text = ""
        txnamabarang.Text = ""
        txharga.Text = ""
        txjumlah.Text = ""
        txnobarang.Focus()
        listsatuan()
    End Sub

    Sub liatdata()
        konek()
        Dim da As New OdbcDataAdapter("Select * from gudang", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvgudang.DataSource = dt
    End Sub
    Private Sub Gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listsatuan()
        bersih()
        liatdata()
    End Sub

    Private Sub btnbersih_Click(sender As Object, e As EventArgs) Handles btnbersih.Click
        bersih()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txnobarang.Text = "" Or txnamabarang.Text = "" Or txharga.Text = "" Or txjumlah.Text = "" Or cmbsatuan.Text = "" Then
            MsgBox("Tidak Boleh Kosong")
            bersih()
        Else
            konek()
            Dim simpan As String = "insert into gudang values ('" & txnobarang.Text & "','" & txnamabarang.Text & "','" & txjumlah.Text & "','" & txharga.Text & "','" & cmbsatuan.Text & "')"
            cmd = New OdbcCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call liatdata()
            Call bersih()
        End If
    End Sub

    Private Sub txnobarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txnobarang.KeyPress
        txnobarang.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            konek()
            cmd = New OdbcCommand("Select * From gudang  where nogudang='" & txnobarang.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("No Gudang Tidak Ada, Silahkan coba lagi!")
                txnobarang.Focus()
            Else
                txnamabarang.Focus()
                txnamabarang.Text = dr.Item("NamaBarang")
                txjumlah.Text = dr.Item("jumlah")
                txharga.Text = dr.Item("harga")
                cmbsatuan.Text = dr.Item("satuan")

                btnsimpan.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        konek()
        Dim edit As String = "update gudang set NamaBarang='" & txnamabarang.Text & "',jumlah='" & txjumlah.Text & "',harga='" & txharga.Text & "',satuan='" & cmbsatuan.Text & "' where nogudang='" & txnobarang.Text & "'"
        cmd = New OdbcCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        Call liatdata()
        Call bersih()
        btnsimpan.Enabled = True
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txnobarang.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan No Barang dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                konek()
                Dim hapus As String = "delete From gudang  where nogudang='" & txnobarang.Text & "'"
                cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call liatdata()
                Call bersih()
            End If
        End If
    End Sub
End Class