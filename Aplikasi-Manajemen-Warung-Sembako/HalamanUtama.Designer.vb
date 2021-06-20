<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanUtama
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnpengaturan = New FontAwesome.Sharp.IconButton()
        Me.btngudang = New FontAwesome.Sharp.IconButton()
        Me.btnlaporan = New FontAwesome.Sharp.IconButton()
        Me.btnbukuutang = New FontAwesome.Sharp.IconButton()
        Me.btnkasir = New FontAwesome.Sharp.IconButton()
        Me.btndashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tittletext = New FontAwesome.Sharp.IconButton()
        Me.PanelUtama = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnpengaturan)
        Me.Panel1.Controls.Add(Me.btngudang)
        Me.Panel1.Controls.Add(Me.btnlaporan)
        Me.Panel1.Controls.Add(Me.btnbukuutang)
        Me.Panel1.Controls.Add(Me.btnkasir)
        Me.Panel1.Controls.Add(Me.btndashboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 579)
        Me.Panel1.TabIndex = 0
        '
        'btnpengaturan
        '
        Me.btnpengaturan.FlatAppearance.BorderSize = 0
        Me.btnpengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpengaturan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpengaturan.ForeColor = System.Drawing.Color.White
        Me.btnpengaturan.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.btnpengaturan.IconColor = System.Drawing.Color.White
        Me.btnpengaturan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnpengaturan.IconSize = 40
        Me.btnpengaturan.Location = New System.Drawing.Point(15, 340)
        Me.btnpengaturan.Name = "btnpengaturan"
        Me.btnpengaturan.Size = New System.Drawing.Size(185, 42)
        Me.btnpengaturan.TabIndex = 5
        Me.btnpengaturan.Text = "Pengaturan"
        Me.btnpengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpengaturan.UseVisualStyleBackColor = True
        '
        'btngudang
        '
        Me.btngudang.FlatAppearance.BorderSize = 0
        Me.btngudang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngudang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngudang.ForeColor = System.Drawing.Color.White
        Me.btngudang.IconChar = FontAwesome.Sharp.IconChar.Boxes
        Me.btngudang.IconColor = System.Drawing.Color.White
        Me.btngudang.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btngudang.IconSize = 40
        Me.btngudang.Location = New System.Drawing.Point(3, 244)
        Me.btngudang.Name = "btngudang"
        Me.btngudang.Size = New System.Drawing.Size(185, 42)
        Me.btngudang.TabIndex = 4
        Me.btngudang.Text = "Gudang"
        Me.btngudang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btngudang.UseVisualStyleBackColor = True
        '
        'btnlaporan
        '
        Me.btnlaporan.FlatAppearance.BorderSize = 0
        Me.btnlaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.ForeColor = System.Drawing.Color.White
        Me.btnlaporan.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        Me.btnlaporan.IconColor = System.Drawing.Color.White
        Me.btnlaporan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnlaporan.IconSize = 40
        Me.btnlaporan.Location = New System.Drawing.Point(3, 292)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(185, 42)
        Me.btnlaporan.TabIndex = 3
        Me.btnlaporan.Text = "Laporan"
        Me.btnlaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlaporan.UseVisualStyleBackColor = True
        '
        'btnbukuutang
        '
        Me.btnbukuutang.FlatAppearance.BorderSize = 0
        Me.btnbukuutang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbukuutang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbukuutang.ForeColor = System.Drawing.Color.White
        Me.btnbukuutang.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnbukuutang.IconColor = System.Drawing.Color.White
        Me.btnbukuutang.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnbukuutang.IconSize = 40
        Me.btnbukuutang.Location = New System.Drawing.Point(3, 196)
        Me.btnbukuutang.Name = "btnbukuutang"
        Me.btnbukuutang.Size = New System.Drawing.Size(185, 42)
        Me.btnbukuutang.TabIndex = 2
        Me.btnbukuutang.Text = "Buku Hutang"
        Me.btnbukuutang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbukuutang.UseVisualStyleBackColor = True
        '
        'btnkasir
        '
        Me.btnkasir.FlatAppearance.BorderSize = 0
        Me.btnkasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkasir.ForeColor = System.Drawing.Color.White
        Me.btnkasir.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.btnkasir.IconColor = System.Drawing.Color.White
        Me.btnkasir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnkasir.IconSize = 40
        Me.btnkasir.Location = New System.Drawing.Point(3, 148)
        Me.btnkasir.Name = "btnkasir"
        Me.btnkasir.Size = New System.Drawing.Size(185, 42)
        Me.btnkasir.TabIndex = 1
        Me.btnkasir.Text = "Kasir"
        Me.btnkasir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnkasir.UseVisualStyleBackColor = True
        '
        'btndashboard
        '
        Me.btndashboard.FlatAppearance.BorderSize = 0
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.White
        Me.btndashboard.IconChar = FontAwesome.Sharp.IconChar.HouseDamage
        Me.btndashboard.IconColor = System.Drawing.Color.White
        Me.btndashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btndashboard.IconSize = 40
        Me.btndashboard.Location = New System.Drawing.Point(3, 100)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(185, 42)
        Me.btndashboard.TabIndex = 0
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndashboard.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tittletext)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(861, 44)
        Me.Panel2.TabIndex = 1
        '
        'tittletext
        '
        Me.tittletext.Dock = System.Windows.Forms.DockStyle.Left
        Me.tittletext.FlatAppearance.BorderSize = 0
        Me.tittletext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tittletext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tittletext.ForeColor = System.Drawing.Color.White
        Me.tittletext.IconChar = FontAwesome.Sharp.IconChar.None
        Me.tittletext.IconColor = System.Drawing.Color.White
        Me.tittletext.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.tittletext.IconSize = 40
        Me.tittletext.Location = New System.Drawing.Point(0, 0)
        Me.tittletext.Name = "tittletext"
        Me.tittletext.Size = New System.Drawing.Size(186, 44)
        Me.tittletext.TabIndex = 5
        Me.tittletext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tittletext.UseVisualStyleBackColor = True
        '
        'PanelUtama
        '
        Me.PanelUtama.BackColor = System.Drawing.Color.White
        Me.PanelUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUtama.Location = New System.Drawing.Point(200, 44)
        Me.PanelUtama.Name = "PanelUtama"
        Me.PanelUtama.Size = New System.Drawing.Size(861, 535)
        Me.PanelUtama.TabIndex = 2
        '
        'HalamanUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 579)
        Me.Controls.Add(Me.PanelUtama)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HalamanUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HalamanUtama"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btndashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnpengaturan As FontAwesome.Sharp.IconButton
    Friend WithEvents btngudang As FontAwesome.Sharp.IconButton
    Friend WithEvents btnlaporan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnbukuutang As FontAwesome.Sharp.IconButton
    Friend WithEvents btnkasir As FontAwesome.Sharp.IconButton
    Friend WithEvents tittletext As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelUtama As Panel
End Class
