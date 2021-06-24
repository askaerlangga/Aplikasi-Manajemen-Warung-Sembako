Imports System.Data.Odbc

Public Class Kasir
    Dim TglMysql As String

    Sub tampildata()
        konek()
        Try
            cmd = New OdbcCommand("select namabarang, satuan from gudang order by nogudang", conn)
            dr = cmd.ExecuteReader
            While dr.Read

            End While
        Catch ex As Exception

        End Try
    End Sub

    Sub kodepelanggan()
        konek()
        cmbidpelanggan.Items.Clear()
        cmd = New OdbcCommand("Select * from tbl_pelanggan", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmbidpelanggan.Items.Add(dr.Item(0))

        Loop
    End Sub

    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnamabarang.Focus()
        lbltanggal.Text = Today
        txtsubtotal.Text = "0"
        txtitem.Text = "0"
        kodepelanggan()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnamabarang.KeyPress
        If e.KeyChar = Chr(13) Then
            Call konek()
            cmd = New OdbcCommand("Select * From gudang where namabarang='" & txtnamabarang.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("namabarang tidak ada")
            Else
                txtnamabarang.Text = dr.Item("namabarang")
                txtharga.Text = dr.Item("harga")
                txtsatuan.Text = dr.Item("satuan")
                txtqty.Focus()
            End If
        End If
    End Sub

    Sub rumuscariitem()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To dgvkasir.Rows.Count - 1
            hitungitem = hitungitem + dgvkasir.Rows(i).Cells(1).Value
            txtitem.Text = hitungitem
        Next
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txtnamabarang.Text = "" Or txtqty.Text = "" Then
            MsgBox(" Silakan Masukan Nama Barang")
            txtnamabarang.Text = ""
            txtqty.Text = ""
            txtharga.Text = ""
            txttotal.Text = ""
            txtsatuan.Text = ""
            txtnamabarang.Focus()
            RumusTotal()
        Else
            dgvkasir.Rows.Add(New String() {txtnamabarang.Text, txtqty.Text, txtqty.Text, txtharga.Text, Val(txtqty.Text) * Val(txtharga.Text)})
            txtnamabarang.Text = ""
            txtqty.Text = ""
            txtharga.Text = ""
            txttotal.Text = ""
            txtsatuan.Text = ""
            txtnamabarang.Focus()
            RumusTotal()
            rumuscariitem()
        End If


    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        btntambah.Focus()

    End Sub
    Sub RumusTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To dgvkasir.Rows.Count - 1
            hitung = hitung + dgvkasir.Rows(i).Cells(4).Value
            txtsubtotal.Text = hitung
        Next
    End Sub

    Private Sub txtbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtbayar.Text) < Val(txtsubtotal.Text) Then
                MsgBox("Pembayaran Kurang")
                txtbayar.Text = ""
            ElseIf Val(txtbayar.Text) = Val(txtsubtotal.Text) Then
                txtkembali.Text = "0"
            ElseIf Val(txtbayar.Text) > Val(txtsubtotal.Text) Then
                txtkembali.Text = Val(txtbayar.Text) - Val(txtsubtotal.Text)
            End If
        End If
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        If txtbayar.Text = "" Or txtitem.Text = "" Or txtsubtotal.Text = "" Then
            MsgBox("Tidak Ada Transaksi, Silakan Transaksi dahulu")
        Else
            TglMysql = Format(lbltanggal, "yyy-MM-dd")
            Dim simpanbarang As String = "Insert into tbl_detailbarang values ('" & lblnota.Text & "','" & TglMysql & "','" & txtitem.Text & "', '" & txtsubtotal.Text & "', '" & txtbayar.Text & "', '" & txtkembali.Text & "', '" & txtnamaadmin.Text & "')"
            cmd = New OdbcCommand(simpanbarang, conn)
            cmd.ExecuteNonQuery()

        End If
    End Sub

    Private Sub cmbidpelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbidpelanggan.SelectedIndexChanged
        konek()
        cmd = New OdbcCommand("Select * from tbl_pelanggan where nopelanggan ='" & cmbidpelanggan.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtnamapelanggan.Text = dr!namapelanggan
        End If
    End Sub

    Private Sub btnbayarnanti_Click(sender As Object, e As EventArgs) Handles btnbayarnanti.Click
        If txtbayar.Text = "" Or txtitem.Text = "" Or txtsubtotal.Text = "" Then
            MsgBox("Tidak Ada Transaksi, Silakan Transaksi dahulu")
        Else
            TglMysql = Format(lbltanggal, "yyy-MM-dd")
            Dim simpanbarang As String = "Insert into tbl_detailbarang values ('" & lblnota.Text & "','" & TglMysql & "','" & txtitem.Text & "', '" & txtsubtotal.Text & "', '" & txtbayar.Text & "', '" & txtkembali.Text & "', '" & txtnamaadmin.Text & "')"
            cmd = New OdbcCommand(simpanbarang, conn)
            cmd.ExecuteNonQuery()

        End If
    End Sub
End Class