Imports System.Data.Odbc
Public Class Login

    'Mencegah User menekan Enter dan Spasi pada textbox
    Private Sub txtUsername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    'Placeholder pada textbox
    Private Sub txtUsername_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Masukan Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Masukan Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Masukan Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Masukan Password"
            txtPassword.ForeColor = Color.Gray
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        konek()
        cmd = New OdbcCommand("select * from tabelUser where username_user='" & txtUsername.Text & "' and password_user='" & txtPassword.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr("jenis_user") = "admin" Then
                HalamanUtama.menuAdmin()
            Else
                HalamanUtama.menuUser()
            End If
            MessageBox.Show("Login Berhasil, Selamat datang " + dr("nama_user").ToString + "!")
            Me.Hide()
            HalamanUtama.Show()
        Else
            MessageBox.Show("Login Gagal! Username atau Password anda salah")
            txtPassword.Focus()
        End If
    End Sub
End Class
