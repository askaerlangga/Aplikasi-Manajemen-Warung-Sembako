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

    Sub ls()
    Private Sub Gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listsatuan()
        bersih()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bersih()
    End Sub
End Class