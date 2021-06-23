<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BukuHutang
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
        Me.btnbersih = New System.Windows.Forms.Button()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txthutang = New System.Windows.Forms.TextBox()
        Me.txtnamapelanggan = New System.Windows.Forms.TextBox()
        Me.txtnopelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvpelanggan = New System.Windows.Forms.DataGridView()
        Me.btnpelanggan = New System.Windows.Forms.Button()
        Me.lbllunas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblnominal = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        CType(Me.dgvpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbersih
        '
        Me.btnbersih.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnbersih.FlatAppearance.BorderSize = 0
        Me.btnbersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbersih.ForeColor = System.Drawing.Color.White
        Me.btnbersih.Location = New System.Drawing.Point(427, 128)
        Me.btnbersih.Name = "btnbersih"
        Me.btnbersih.Size = New System.Drawing.Size(87, 46)
        Me.btnbersih.TabIndex = 27
        Me.btnbersih.Text = "Bersih"
        Me.btnbersih.UseVisualStyleBackColor = False
        '
        'btnbayar
        '
        Me.btnbayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnbayar.FlatAppearance.BorderSize = 0
        Me.btnbayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbayar.ForeColor = System.Drawing.Color.White
        Me.btnbayar.Location = New System.Drawing.Point(427, 28)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(87, 42)
        Me.btnbayar.TabIndex = 25
        Me.btnbayar.Text = "Bayar"
        Me.btnbayar.UseVisualStyleBackColor = False
        '
        'txtbayar
        '
        Me.txtbayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtbayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbayar.ForeColor = System.Drawing.Color.White
        Me.txtbayar.Location = New System.Drawing.Point(141, 108)
        Me.txtbayar.Multiline = True
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(248, 20)
        Me.txtbayar.TabIndex = 23
        '
        'txthutang
        '
        Me.txthutang.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txthutang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthutang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthutang.ForeColor = System.Drawing.Color.White
        Me.txthutang.Location = New System.Drawing.Point(141, 81)
        Me.txthutang.Multiline = True
        Me.txthutang.Name = "txthutang"
        Me.txthutang.ReadOnly = True
        Me.txthutang.Size = New System.Drawing.Size(248, 23)
        Me.txthutang.TabIndex = 22
        '
        'txtnamapelanggan
        '
        Me.txtnamapelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtnamapelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnamapelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamapelanggan.ForeColor = System.Drawing.Color.White
        Me.txtnamapelanggan.Location = New System.Drawing.Point(141, 54)
        Me.txtnamapelanggan.Multiline = True
        Me.txtnamapelanggan.Name = "txtnamapelanggan"
        Me.txtnamapelanggan.Size = New System.Drawing.Size(248, 23)
        Me.txtnamapelanggan.TabIndex = 21
        '
        'txtnopelanggan
        '
        Me.txtnopelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtnopelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnopelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnopelanggan.ForeColor = System.Drawing.Color.White
        Me.txtnopelanggan.Location = New System.Drawing.Point(141, 28)
        Me.txtnopelanggan.Name = "txtnopelanggan"
        Me.txtnopelanggan.Size = New System.Drawing.Size(248, 14)
        Me.txtnopelanggan.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Bayar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hutang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "No Pelanggan"
        '
        'dgvpelanggan
        '
        Me.dgvpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpelanggan.Location = New System.Drawing.Point(35, 186)
        Me.dgvpelanggan.Name = "dgvpelanggan"
        Me.dgvpelanggan.Size = New System.Drawing.Size(653, 267)
        Me.dgvpelanggan.TabIndex = 28
        '
        'btnpelanggan
        '
        Me.btnpelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnpelanggan.FlatAppearance.BorderSize = 0
        Me.btnpelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpelanggan.ForeColor = System.Drawing.Color.White
        Me.btnpelanggan.Location = New System.Drawing.Point(427, 76)
        Me.btnpelanggan.Name = "btnpelanggan"
        Me.btnpelanggan.Size = New System.Drawing.Size(87, 46)
        Me.btnpelanggan.TabIndex = 29
        Me.btnpelanggan.Text = "Pelanggan"
        Me.btnpelanggan.UseVisualStyleBackColor = False
        '
        'lbllunas
        '
        Me.lbllunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllunas.Location = New System.Drawing.Point(520, 28)
        Me.lbllunas.Name = "lbllunas"
        Me.lbllunas.Size = New System.Drawing.Size(114, 33)
        Me.lbllunas.TabIndex = 32
        Me.lbllunas.Text = "BELUM"
        Me.lbllunas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(520, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 33)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Rp."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnominal
        '
        Me.lblnominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnominal.Location = New System.Drawing.Point(574, 86)
        Me.lblnominal.Name = "lblnominal"
        Me.lblnominal.Size = New System.Drawing.Size(114, 33)
        Me.lblnominal.TabIndex = 34
        Me.lblnominal.Text = "0"
        Me.lblnominal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnhitung
        '
        Me.btnhitung.BackColor = System.Drawing.Color.Red
        Me.btnhitung.FlatAppearance.BorderSize = 0
        Me.btnhitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.ForeColor = System.Drawing.Color.White
        Me.btnhitung.Location = New System.Drawing.Point(141, 134)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(87, 46)
        Me.btnhitung.TabIndex = 35
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = False
        '
        'BukuHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(737, 486)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.lblnominal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbllunas)
        Me.Controls.Add(Me.btnpelanggan)
        Me.Controls.Add(Me.dgvpelanggan)
        Me.Controls.Add(Me.btnbersih)
        Me.Controls.Add(Me.btnbayar)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txthutang)
        Me.Controls.Add(Me.txtnamapelanggan)
        Me.Controls.Add(Me.txtnopelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BukuHutang"
        Me.Text = "BukuHutang"
        CType(Me.dgvpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbersih As Button
    Friend WithEvents btnbayar As Button
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents txthutang As TextBox
    Friend WithEvents txtnamapelanggan As TextBox
    Friend WithEvents txtnopelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvpelanggan As DataGridView
    Friend WithEvents btnpelanggan As Button
    Friend WithEvents lbllunas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblnominal As Label
    Friend WithEvents btnhitung As Button
End Class
