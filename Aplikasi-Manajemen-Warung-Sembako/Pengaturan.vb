Imports System.Data.Odbc
Public Class Pengaturan
    Sub formPengaturanUserOff()
        txtUsernameUser.Enabled = False
        txtPasswordUser.Enabled = False
        txtNamaUser.Enabled = False
        txtAlamatUser.Enabled = False
        txtNoTelpUser.Enabled = False
        txtJabatanUser.Enabled = False
        cmbJenisUser.Enabled = False
    End Sub

    Sub formPengaturanUserOn()
        txtUsernameUser.Enabled = True
        txtPasswordUser.Enabled = True
        txtNamaUser.Enabled = True
        txtAlamatUser.Enabled = True
        txtNoTelpUser.Enabled = True
        txtJabatanUser.Enabled = True
        cmbJenisUser.Enabled = True
    End Sub

    Private Sub txtCariUser_Click(sender As Object, e As EventArgs) Handles txtCariUser.Click
        If txtCariUser.Text = "" Then
            MessageBox.Show("Form Tidak boleh Kosong!")
        Else
            konek()
            cmd = New OdbcCommand("select * from tabelUser where kode_user ='" & txtKodeUser.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtUsernameUser.Text = dr("username_user")
                txtPasswordUser.Text = dr("password_user")
                txtNamaUser.Text = dr("nama_user")
                txtAlamatUser.Text = dr("alamat_user")
                txtNoTelpUser.Text = dr("no_telp_user")
                txtJabatanUser.Text = dr("jabatan_user")
                If dr("jenis_user") = "admin" Then
                    cmbJenisUser.SelectedIndex = 0
                Else
                    cmbJenisUser.SelectedIndex = 1
                End If
                btnEditUser.Enabled = True
                btnHapusUser.Enabled = True
            Else
                MessageBox.Show("Data tidak Ditemukan!")
            End If
        End If
    End Sub

    Private Sub Pengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formPengaturanUserOff()
        btnSimpanUser.Enabled = False
        btnBatalUser.Enabled = False
        btnEditUser.Enabled = False
        btnHapusUser.Enabled = False
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        formPengaturanUserOn()
        btnBatalUser.Enabled = True
        btnSimpanUser.Enabled = True
        btnEditUser.Enabled = False
        btnHapusUser.Enabled = False
    End Sub

    Private Sub btnBatalUser_Click(sender As Object, e As EventArgs) Handles btnBatalUser.Click
        btnEditUser.Enabled = True
        btnHapusUser.Enabled = True
        btnBatalUser.Enabled = False
        btnSimpanUser.Enabled = False
        formPengaturanUserOff()
    End Sub

    Private Sub btnTambahUser_Click(sender As Object, e As EventArgs) Handles btnTambahUser.Click
        tambahUser.ShowDialog()
    End Sub

    Private Sub btnSimpanUser_Click(sender As Object, e As EventArgs) Handles btnSimpanUser.Click
        str = "update tabelUser set username_user = '" & txtUsernameUser.Text & "', password_user = '" & txtPasswordUser.Text & "', nama_user = '" & txtNamaUser.Text & "' , alamat_user = '" & txtAlamatUser.Text & "', no_telp_user = '" & txtNoTelpUser.Text & "' , jabatan_user = '" & txtJabatanUser.Text & "' , jenis_user = '" & cmbJenisUser.Text & "' where kode_user = '" & txtKodeUser.Text & "'"
        cmd = New OdbcCommand(str, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Tersimpan")
        formPengaturanUserOff()
        btnEditUser.Enabled = False
        btnHapusUser.Enabled = False
        btnBatalUser.Enabled = False
        btnSimpanUser.Enabled = False
        txtUsernameUser.Text = ""
        txtPasswordUser.Text = ""
        txtNamaUser.Text = ""
        txtAlamatUser.Text = ""
        txtNoTelpUser.Text = ""
        txtJabatanUser.Text = ""
        cmbJenisUser.SelectedIndex = -1
        txtKodeUser.Focus()
    End Sub

    Private Sub btnHapusUser_Click(sender As Object, e As EventArgs) Handles btnHapusUser.Click
        Dim tanya = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Hapus user", MessageBoxButtons.YesNo)
        If tanya = vbYes Then
            konek()
            str = "delete from tabelUser where kode_user = '" & txtKodeUser.Text & "'"
            cmd = New OdbcCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Terhapus!")
            formPengaturanUserOff()
            btnEditUser.Enabled = False
            btnHapusUser.Enabled = False
            btnBatalUser.Enabled = False
            btnSimpanUser.Enabled = False
            txtUsernameUser.Text = ""
            txtPasswordUser.Text = ""
            txtNamaUser.Text = ""
            txtAlamatUser.Text = ""
            txtNoTelpUser.Text = ""
            txtJabatanUser.Text = ""
            cmbJenisUser.SelectedIndex = -1
            txtKodeUser.Focus()
        End If

    End Sub
End Class