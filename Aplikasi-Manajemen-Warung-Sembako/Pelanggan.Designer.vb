<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Me.dgvpelanggan = New System.Windows.Forms.DataGridView()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtnamapelanggan = New System.Windows.Forms.TextBox()
        Me.txtnopelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvpelanggan
        '
        Me.dgvpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpelanggan.Location = New System.Drawing.Point(73, 183)
        Me.dgvpelanggan.Name = "dgvpelanggan"
        Me.dgvpelanggan.Size = New System.Drawing.Size(657, 231)
        Me.dgvpelanggan.TabIndex = 31
        '
        'btntutup
        '
        Me.btntutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btntutup.FlatAppearance.BorderSize = 0
        Me.btntutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntutup.ForeColor = System.Drawing.Color.White
        Me.btntutup.Location = New System.Drawing.Point(593, 103)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(113, 46)
        Me.btntutup.TabIndex = 29
        Me.btntutup.Text = " Tutup"
        Me.btntutup.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnhapus.FlatAppearance.BorderSize = 0
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(593, 51)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(113, 46)
        Me.btnhapus.TabIndex = 28
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(446, 104)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(113, 46)
        Me.btnedit.TabIndex = 27
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnsimpan.FlatAppearance.BorderSize = 0
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(446, 51)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(113, 46)
        Me.btnsimpan.TabIndex = 26
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'txtalamat
        '
        Me.txtalamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.ForeColor = System.Drawing.Color.White
        Me.txtalamat.Location = New System.Drawing.Point(179, 116)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(247, 45)
        Me.txtalamat.TabIndex = 25
        '
        'txtnotelp
        '
        Me.txtnotelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtnotelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnotelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnotelp.ForeColor = System.Drawing.Color.White
        Me.txtnotelp.Location = New System.Drawing.Point(179, 90)
        Me.txtnotelp.Multiline = True
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(247, 23)
        Me.txtnotelp.TabIndex = 24
        '
        'txtnamapelanggan
        '
        Me.txtnamapelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtnamapelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnamapelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamapelanggan.ForeColor = System.Drawing.Color.White
        Me.txtnamapelanggan.Location = New System.Drawing.Point(179, 63)
        Me.txtnamapelanggan.Multiline = True
        Me.txtnamapelanggan.Name = "txtnamapelanggan"
        Me.txtnamapelanggan.Size = New System.Drawing.Size(247, 23)
        Me.txtnamapelanggan.TabIndex = 23
        '
        'txtnopelanggan
        '
        Me.txtnopelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtnopelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnopelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnopelanggan.ForeColor = System.Drawing.Color.White
        Me.txtnopelanggan.Location = New System.Drawing.Point(179, 37)
        Me.txtnopelanggan.Name = "txtnopelanggan"
        Me.txtnopelanggan.Size = New System.Drawing.Size(247, 19)
        Me.txtnopelanggan.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "No Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "No Pelanggan"
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvpelanggan)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnotelp)
        Me.Controls.Add(Me.txtnamapelanggan)
        Me.Controls.Add(Me.txtnopelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.dgvpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvpelanggan As DataGridView
    Friend WithEvents btntutup As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtnotelp As TextBox
    Friend WithEvents txtnamapelanggan As TextBox
    Friend WithEvents txtnopelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
