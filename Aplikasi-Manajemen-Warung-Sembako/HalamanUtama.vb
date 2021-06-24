Public Class HalamanUtama

    Sub menuUser()
        btnkasir.Enabled = True
        btnbukuutang.Enabled = True
        btngudang.Enabled = False
        btnpengaturan.Enabled = False
        Kasir.txtnamaadmin.Text = "Karyawan"
    End Sub

    Sub menuAdmin()
        btnkasir.Enabled = True
        btnbukuutang.Enabled = True
        btngudang.Enabled = True
        btnpengaturan.Enabled = True
        Kasir.txtnamaadmin.Text = "ADMIN"

    End Sub

    Private Sub btnkasir_Click(sender As Object, e As EventArgs) Handles btnkasir.Click
        tittletext.Text = btnkasir.Text
        Me.PanelUtama.Controls.Clear()
        Kasir.TopLevel = False
        Kasir.AutoSize = False
        Kasir.FormBorderStyle = FormBorderStyle.None
        Kasir.Dock = DockStyle.Fill
        Me.PanelUtama.Controls.Add(Kasir)
        Kasir.Show()
    End Sub

    Private Sub btnbukuutang_Click(sender As Object, e As EventArgs) Handles btnbukuutang.Click
        tittletext.Text = btnbukuutang.Text
        Me.PanelUtama.Controls.Clear()
        BukuHutang.TopLevel = False
        BukuHutang.AutoSize = False
        BukuHutang.FormBorderStyle = FormBorderStyle.None
        BukuHutang.Dock = DockStyle.Fill
        Me.PanelUtama.Controls.Add(BukuHutang)
        BukuHutang.Show()
    End Sub

    Private Sub btngudang_Click(sender As Object, e As EventArgs) Handles btngudang.Click
        tittletext.Text = btngudang.Text
        Me.PanelUtama.Controls.Clear()
        Gudang.TopLevel = False
        Gudang.AutoSize = False
        Gudang.FormBorderStyle = FormBorderStyle.None
        Gudang.Dock = DockStyle.Fill
        Me.PanelUtama.Controls.Add(Gudang)
        Gudang.Show()
    End Sub

    Private Sub btnpengaturan_Click(sender As Object, e As EventArgs) Handles btnpengaturan.Click
        tittletext.Text = btnpengaturan.Text
        Me.PanelUtama.Controls.Clear()
        Pengaturan.TopLevel = False
        Pengaturan.AutoSize = False
        Pengaturan.FormBorderStyle = FormBorderStyle.None
        Pengaturan.Dock = DockStyle.Fill
        Me.PanelUtama.Controls.Add(Pengaturan)
        Pengaturan.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Login.Show()
        Login.resetFormLogin()
    End Sub

    Private Sub HalamanUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tittletext.Text = btnkasir.Text
        Me.PanelUtama.Controls.Clear()
        Kasir.TopLevel = False
        Kasir.AutoSize = False
        Kasir.FormBorderStyle = FormBorderStyle.None
        Kasir.Dock = DockStyle.Fill
        Me.PanelUtama.Controls.Add(Kasir)
        Kasir.Show()
    End Sub
End Class