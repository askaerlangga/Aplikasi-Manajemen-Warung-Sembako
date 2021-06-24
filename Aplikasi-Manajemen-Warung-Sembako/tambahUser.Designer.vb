<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBatalUser = New System.Windows.Forms.Button()
        Me.cmbJenisUser = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtJabatanUser = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNoTelpUser = New System.Windows.Forms.TextBox()
        Me.btnSimpanUser = New System.Windows.Forms.Button()
        Me.txtAlamatUser = New System.Windows.Forms.TextBox()
        Me.txtNamaUser = New System.Windows.Forms.TextBox()
        Me.txtPasswordUser = New System.Windows.Forms.TextBox()
        Me.txtUsernameUser = New System.Windows.Forms.TextBox()
        Me.txtKodeUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBatalUser)
        Me.GroupBox2.Controls.Add(Me.cmbJenisUser)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtJabatanUser)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNoTelpUser)
        Me.GroupBox2.Controls.Add(Me.btnSimpanUser)
        Me.GroupBox2.Controls.Add(Me.txtAlamatUser)
        Me.GroupBox2.Controls.Add(Me.txtNamaUser)
        Me.GroupBox2.Controls.Add(Me.txtPasswordUser)
        Me.GroupBox2.Controls.Add(Me.txtUsernameUser)
        Me.GroupBox2.Controls.Add(Me.txtKodeUser)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 322)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pengaturan User"
        '
        'btnBatalUser
        '
        Me.btnBatalUser.BackColor = System.Drawing.Color.Red
        Me.btnBatalUser.FlatAppearance.BorderSize = 0
        Me.btnBatalUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatalUser.ForeColor = System.Drawing.Color.White
        Me.btnBatalUser.Location = New System.Drawing.Point(260, 259)
        Me.btnBatalUser.Name = "btnBatalUser"
        Me.btnBatalUser.Size = New System.Drawing.Size(116, 41)
        Me.btnBatalUser.TabIndex = 30
        Me.btnBatalUser.Text = "Batal"
        Me.btnBatalUser.UseVisualStyleBackColor = False
        '
        'cmbJenisUser
        '
        Me.cmbJenisUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cmbJenisUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbJenisUser.ForeColor = System.Drawing.Color.White
        Me.cmbJenisUser.FormattingEnabled = True
        Me.cmbJenisUser.Items.AddRange(New Object() {"admin", "user"})
        Me.cmbJenisUser.Location = New System.Drawing.Point(130, 232)
        Me.cmbJenisUser.Name = "cmbJenisUser"
        Me.cmbJenisUser.Size = New System.Drawing.Size(247, 21)
        Me.cmbJenisUser.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Jenis User"
        '
        'txtJabatanUser
        '
        Me.txtJabatanUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtJabatanUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJabatanUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJabatanUser.ForeColor = System.Drawing.Color.White
        Me.txtJabatanUser.Location = New System.Drawing.Point(130, 205)
        Me.txtJabatanUser.Multiline = True
        Me.txtJabatanUser.Name = "txtJabatanUser"
        Me.txtJabatanUser.Size = New System.Drawing.Size(247, 23)
        Me.txtJabatanUser.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Jabatan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "No Telepon"
        '
        'txtNoTelpUser
        '
        Me.txtNoTelpUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtNoTelpUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoTelpUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelpUser.ForeColor = System.Drawing.Color.White
        Me.txtNoTelpUser.Location = New System.Drawing.Point(130, 178)
        Me.txtNoTelpUser.Multiline = True
        Me.txtNoTelpUser.Name = "txtNoTelpUser"
        Me.txtNoTelpUser.Size = New System.Drawing.Size(247, 23)
        Me.txtNoTelpUser.TabIndex = 22
        '
        'btnSimpanUser
        '
        Me.btnSimpanUser.BackColor = System.Drawing.Color.Red
        Me.btnSimpanUser.FlatAppearance.BorderSize = 0
        Me.btnSimpanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanUser.ForeColor = System.Drawing.Color.White
        Me.btnSimpanUser.Location = New System.Drawing.Point(130, 259)
        Me.btnSimpanUser.Name = "btnSimpanUser"
        Me.btnSimpanUser.Size = New System.Drawing.Size(124, 41)
        Me.btnSimpanUser.TabIndex = 20
        Me.btnSimpanUser.Text = "Simpan"
        Me.btnSimpanUser.UseVisualStyleBackColor = False
        '
        'txtAlamatUser
        '
        Me.txtAlamatUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAlamatUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlamatUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatUser.ForeColor = System.Drawing.Color.White
        Me.txtAlamatUser.Location = New System.Drawing.Point(130, 151)
        Me.txtAlamatUser.Multiline = True
        Me.txtAlamatUser.Name = "txtAlamatUser"
        Me.txtAlamatUser.Size = New System.Drawing.Size(247, 23)
        Me.txtAlamatUser.TabIndex = 19
        '
        'txtNamaUser
        '
        Me.txtNamaUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtNamaUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaUser.ForeColor = System.Drawing.Color.White
        Me.txtNamaUser.Location = New System.Drawing.Point(130, 124)
        Me.txtNamaUser.Multiline = True
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.Size = New System.Drawing.Size(247, 23)
        Me.txtNamaUser.TabIndex = 18
        '
        'txtPasswordUser
        '
        Me.txtPasswordUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtPasswordUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordUser.ForeColor = System.Drawing.Color.White
        Me.txtPasswordUser.Location = New System.Drawing.Point(130, 97)
        Me.txtPasswordUser.Multiline = True
        Me.txtPasswordUser.Name = "txtPasswordUser"
        Me.txtPasswordUser.Size = New System.Drawing.Size(247, 23)
        Me.txtPasswordUser.TabIndex = 17
        '
        'txtUsernameUser
        '
        Me.txtUsernameUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtUsernameUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsernameUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameUser.ForeColor = System.Drawing.Color.White
        Me.txtUsernameUser.Location = New System.Drawing.Point(130, 70)
        Me.txtUsernameUser.Multiline = True
        Me.txtUsernameUser.Name = "txtUsernameUser"
        Me.txtUsernameUser.Size = New System.Drawing.Size(247, 23)
        Me.txtUsernameUser.TabIndex = 16
        '
        'txtKodeUser
        '
        Me.txtKodeUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtKodeUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKodeUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKodeUser.Enabled = False
        Me.txtKodeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeUser.ForeColor = System.Drawing.Color.White
        Me.txtKodeUser.Location = New System.Drawing.Point(130, 43)
        Me.txtKodeUser.Multiline = True
        Me.txtKodeUser.Name = "txtKodeUser"
        Me.txtKodeUser.Size = New System.Drawing.Size(246, 23)
        Me.txtKodeUser.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Kode User"
        '
        'tambahUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 347)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "tambahUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tambahUser"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBatalUser As Button
    Friend WithEvents cmbJenisUser As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtJabatanUser As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNoTelpUser As TextBox
    Friend WithEvents btnSimpanUser As Button
    Friend WithEvents txtAlamatUser As TextBox
    Friend WithEvents txtNamaUser As TextBox
    Friend WithEvents txtPasswordUser As TextBox
    Friend WithEvents txtUsernameUser As TextBox
    Friend WithEvents txtKodeUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
