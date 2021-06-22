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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lvgudang = New System.Windows.Forms.ListView()
        Me.cmbsatuan = New System.Windows.Forms.ComboBox()
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(442, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(442, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 46)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(589, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 46)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(589, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 46)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Bersih"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lvgudang
        '
        Me.lvgudang.HideSelection = False
        Me.lvgudang.Location = New System.Drawing.Point(45, 178)
        Me.lvgudang.Name = "lvgudang"
        Me.lvgudang.Size = New System.Drawing.Size(656, 249)
        Me.lvgudang.TabIndex = 14
        Me.lvgudang.UseCompatibleStateImageBehavior = False
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
        'Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 443)
        Me.Controls.Add(Me.cmbsatuan)
        Me.Controls.Add(Me.lvgudang)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lvgudang As ListView
    Friend WithEvents cmbsatuan As ComboBox
End Class
