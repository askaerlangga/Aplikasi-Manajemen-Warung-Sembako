﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblnota = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dgvkasir = New System.Windows.Forms.DataGridView()
        Me.barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        CType(Me.dgvkasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(838, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSAKSI PENJUALAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Nota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Qty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(622, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal"
        '
        'lblnota
        '
        Me.lblnota.BackColor = System.Drawing.Color.White
        Me.lblnota.Location = New System.Drawing.Point(115, 64)
        Me.lblnota.Name = "lblnota"
        Me.lblnota.Size = New System.Drawing.Size(122, 21)
        Me.lblnota.TabIndex = 6
        Me.lblnota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(279, 130)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(90, 20)
        Me.txtqty.TabIndex = 2
        '
        'lbltanggal
        '
        Me.lbltanggal.BackColor = System.Drawing.Color.White
        Me.lbltanggal.Location = New System.Drawing.Point(695, 64)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(122, 21)
        Me.lbltanggal.TabIndex = 9
        Me.lbltanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btntambah.FlatAppearance.BorderSize = 0
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Location = New System.Drawing.Point(742, 99)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 10
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'dgvkasir
        '
        Me.dgvkasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.barang, Me.qty, Me.satuan, Me.harga, Me.total})
        Me.dgvkasir.Location = New System.Drawing.Point(39, 160)
        Me.dgvkasir.Name = "dgvkasir"
        Me.dgvkasir.Size = New System.Drawing.Size(778, 223)
        Me.dgvkasir.TabIndex = 11
        '
        'barang
        '
        Me.barang.HeaderText = "BARANG"
        Me.barang.Name = "barang"
        Me.barang.Width = 200
        '
        'qty
        '
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        Me.qty.Width = 90
        '
        'satuan
        '
        Me.satuan.HeaderText = "SATUAN"
        Me.satuan.Name = "satuan"
        Me.satuan.Width = 150
        '
        'harga
        '
        Me.harga.HeaderText = "HARGA"
        Me.harga.Name = "harga"
        Me.harga.Width = 150
        '
        'total
        '
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 150
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 31)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "BAYAR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(39, 433)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 31)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Rp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(95, 496)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Kembalian  :"
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(199, 496)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.ReadOnly = True
        Me.txtkembali.Size = New System.Drawing.Size(124, 20)
        Me.txtkembali.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(337, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 86)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Cetak"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(435, 429)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 86)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Bersih"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.Location = New System.Drawing.Point(586, 445)
        Me.txtsubtotal.Multiline = True
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(231, 39)
        Me.txtsubtotal.TabIndex = 22
        Me.txtsubtotal.Text = "0"
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(531, 445)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 31)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Rp"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(531, 398)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 31)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "TOTAL"
        '
        'txtitem
        '
        Me.txtitem.Location = New System.Drawing.Point(750, 410)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.ReadOnly = True
        Me.txtitem.Size = New System.Drawing.Size(67, 20)
        Me.txtitem.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(661, 410)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 17)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Jumlah Item"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(520, 130)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.ReadOnly = True
        Me.txtharga.Size = New System.Drawing.Size(148, 20)
        Me.txtharga.TabIndex = 27
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(674, 130)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(143, 20)
        Me.txttotal.TabIndex = 28
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(82, 130)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(191, 20)
        Me.txtnamabarang.TabIndex = 1
        '
        'txtsatuan
        '
        Me.txtsatuan.Location = New System.Drawing.Point(375, 130)
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(139, 20)
        Me.txtsatuan.TabIndex = 31
        '
        'txtbayar
        '
        Me.txtbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbayar.Location = New System.Drawing.Point(94, 430)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(229, 38)
        Me.txtbayar.TabIndex = 14
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 527)
        Me.Controls.Add(Me.txtsatuan)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvkasir)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.lbltanggal)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.lblnota)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Kasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasir"
        CType(Me.dgvkasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblnota As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lbltanggal As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents dgvkasir As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents barang As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents satuan As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtitem As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents txtsatuan As TextBox
    Friend WithEvents txtbayar As TextBox
End Class