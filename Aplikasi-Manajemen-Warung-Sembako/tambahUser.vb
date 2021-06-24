Imports System.Data.Odbc
Public Class tambahUser
    Sub loadKodeUser()
        txtKodeUser.Enabled = False
        Dim urutan As String
        Dim hitung As Long
        konek()
        cmd = New OdbcCommand("Select * from tabelUser where kode_user in (select max(kode_user) from tabelUser)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "USER" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urutan = "USER" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtKodeUser.Text = urutan
        txtUsernameUser.Text = ""
        txtPasswordUser.Text = ""
        txtNamaUser.Text = ""
        txtAlamatUser.Text = ""
        txtNoTelpUser.Text = ""
        txtJabatanUser.Text = ""
        cmbJenisUser.SelectedIndex = -1
    End Sub

    Private Sub btnSimpanUser_Click(sender As Object, e As EventArgs) Handles btnSimpanUser.Click
        konek()
        cmd = New OdbcCommand("insert into tabelUser values ('" & txtKodeUser.Text & "','" &
                               txtUsernameUser.Text & "','" & txtPasswordUser.Text & "','" & txtNamaUser.Text & "','" & txtAlamatUser.Text & "','" &
                               txtNoTelpUser.Text & "','" & txtJabatanUser.Text & "','" & cmbJenisUser.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan!")
        loadKodeUser()
    End Sub

    Private Sub tambahUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadKodeUser()
    End Sub

    Private Sub btnBatalUser_Click(sender As Object, e As EventArgs) Handles btnBatalUser.Click
        Me.Close()
    End Sub
End Class