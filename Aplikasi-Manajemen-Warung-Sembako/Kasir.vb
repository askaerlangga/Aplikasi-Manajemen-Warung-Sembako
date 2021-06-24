Imports System.Data.Odbc

Public Class Kasir
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

    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnamabarang.Focus()
        lbltanggal.Text = Today
        txtsubtotal.Text = "0"
        txtitem.Text = "0"
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

End Class