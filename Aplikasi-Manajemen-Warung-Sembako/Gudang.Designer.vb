<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gudang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txnobarang = New System.Windows.Forms.TextBox()
        Me.txnamabarang = New System.Windows.Forms.TextBox()
        Me.txharga = New System.Windows.Forms.TextBox()
        Me.txjumlah = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnbersih = New System.Windows.Forms.Button()
        Me.cmbsatuan = New System.Windows.Forms.ComboBox()
        Me.dgvgudang = New System.Windows.Forms.DataGridView()
        CType(Me.dgvgudang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Satuan"
        '
        'txnobarang
        '
        Me.txnobarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txnobarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txnobarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txnobarang.ForeColor = System.Drawing.Color.White
        Me.txnobarang.Location = New System.Drawing.Point(151, 33)
        Me.txnobarang.Multiline = True
        Me.txnobarang.Name = "txnobarang"
        Me.txnobarang.Size = New System.Drawing.Size(247, 23)
        Me.txnobarang.TabIndex = 5
        '
        'txnamabarang
        '
        Me.txnamabarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txnamabarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txnamabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txnamabarang.ForeColor = System.Drawing.Color.White
        Me.txnamabarang.Location = New System.Drawing.Point(151, 59)
        Me.txnamabarang.Multiline = True
        Me.txnamabarang.Name = "txnamabarang"
        Me.txnamabarang.Size = New System.Drawing.Size(247, 23)
        Me.txnamabarang.TabIndex = 6
        '
        'txharga
        '
        Me.txharga.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txharga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txharga.ForeColor = System.Drawing.Color.White
        Me.txharga.Location = New System.Drawing.Point(151, 86)
        Me.txharga.Multiline = True
        Me.txharga.Name = "txharga"
        Me.txharga.Size = New System.Drawing.Size(247, 23)
        Me.txharga.TabIndex = 7
        '
        'txjumlah
        '
        Me.txjumlah.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txjumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txjumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txjumlah.ForeColor = System.Drawing.Color.White
        Me.txjumlah.Location = New System.Drawing.Point(151, 112)
        Me.txjumlah.Multiline = True
        Me.txjumlah.Name = "txjumlah"
        Me.txjumlah.Size = New System.Drawing.Size(247, 23)
        Me.txjumlah.TabIndex = 8
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnsimpan.FlatAppearance.BorderSize = 0
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(442, 49)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(113, 46)
        Me.btnsimpan.TabIndex = 10
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(442, 102)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(113, 46)
        Me.btnedit.TabIndex = 11
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnhapus.FlatAppearance.BorderSize = 0
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(589, 49)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(113, 46)
        Me.btnhapus.TabIndex = 12
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnbersih
        '
        Me.btnbersih.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnbersih.FlatAppearance.BorderSize = 0
        Me.btnbersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbersih.ForeColor = System.Drawing.Color.White
        Me.btnbersih.Location = New System.Drawing.Point(589, 101)
        Me.btnbersih.Name = "btnbersih"
        Me.btnbersih.Size = New System.Drawing.Size(113, 46)
        Me.btnbersih.TabIndex = 13
        Me.btnbersih.Text = "Bersih"
        Me.btnbersih.UseVisualStyleBackColor = False
        '
        'cmbsatuan
        '
        Me.cmbsatuan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cmbsatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsatuan.ForeColor = System.Drawing.Color.White
        Me.cmbsatuan.FormattingEnabled = True
        Me.cmbsatuan.Location = New System.Drawing.Point(151, 141)
        Me.cmbsatuan.Name = "cmbsatuan"
        Me.cmbsatuan.Size = New System.Drawing.Size(247, 23)
        Me.cmbsatuan.TabIndex = 15
        '
        'dgvgudang
        '
        Me.dgvgudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgudang.Location = New System.Drawing.Point(45, 179)
        Me.dgvgudang.Name = "dgvgudang"
        Me.dgvgudang.Size = New System.Drawing.Size(657, 231)
        Me.dgvgudang.TabIndex = 16
        '
        'Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 443)
        Me.Controls.Add(Me.dgvgudang)
        Me.Controls.Add(Me.cmbsatuan)
        Me.Controls.Add(Me.btnbersih)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txjumlah)
        Me.Controls.Add(Me.txharga)
        Me.Controls.Add(Me.txnamabarang)
        Me.Controls.Add(Me.txnobarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gudang"
        Me.Text = "Gudang"
        CType(Me.dgvgudang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txnobarang As TextBox
    Friend WithEvents txnamabarang As TextBox
    Friend WithEvents txharga As TextBox
    Friend WithEvents txjumlah As TextBox
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnbersih As Button
    Friend WithEvents cmbsatuan As ComboBox
    Friend WithEvents dgvgudang As DataGridView
End Class
