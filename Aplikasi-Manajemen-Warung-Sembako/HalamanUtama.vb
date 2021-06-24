Public Class HalamanUtama

    Sub menuUser()
        btndashboard.Enabled = True
        btnkasir.Enabled = True
        btnbukuutang.Enabled = True
        btngudang.Enabled = False
        btnlaporan.Enabled = False
        btnpengaturan.Enabled = False
    End Sub

    Sub menuAdmin()
        btndashboard.Enabled = True
        btnkasir.Enabled = True
        btnbukuutang.Enabled = True
        btngudang.Enabled = True
        btnlaporan.Enabled = True
        btnpengaturan.Enabled = True
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        tittletext.Text = btndashboard.Text
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

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        tittletext.Text = btnlaporan.Text
        Me.PanelUtama.Controls.Clear()
        Laporan.TopLevel = False
        Laporan.AutoSize = False
        Laporan.FormBorderStyle = FormBorderStyle.None
        Laporan.Dock = DockStyle.Fill
        Me.PanelUtama.Controls.Add(Laporan)
        Laporan.Show()
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

    Private Sub tittletext_Click(sender As Object, e As EventArgs) Handles tittletext.Click
        btndashboard.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Login.Show()
        Login.resetFormLogin()
    End Sub
End Class