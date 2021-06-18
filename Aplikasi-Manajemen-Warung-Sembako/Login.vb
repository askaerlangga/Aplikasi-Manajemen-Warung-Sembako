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
End Class
