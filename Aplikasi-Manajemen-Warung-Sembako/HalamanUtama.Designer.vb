﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnpengaturan = New FontAwesome.Sharp.IconButton()
        Me.btngudang = New FontAwesome.Sharp.IconButton()
        Me.btnbukuutang = New FontAwesome.Sharp.IconButton()
        Me.btnkasir = New FontAwesome.Sharp.IconButton()
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
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnpengaturan)
        Me.Panel1.Controls.Add(Me.btngudang)
        Me.Panel1.Controls.Add(Me.btnbukuutang)
        Me.Panel1.Controls.Add(Me.btnkasir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 639)
        Me.Panel1.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 40
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(12, 195)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(185, 42)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
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
        Me.btnpengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpengaturan.Location = New System.Drawing.Point(12, 147)
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
        Me.btngudang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngudang.Location = New System.Drawing.Point(9, 99)
        Me.btngudang.Name = "btngudang"
        Me.btngudang.Size = New System.Drawing.Size(185, 42)
        Me.btngudang.TabIndex = 4
        Me.btngudang.Text = "Gudang"
        Me.btngudang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btngudang.UseVisualStyleBackColor = True
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
        Me.btnbukuutang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbukuutang.Location = New System.Drawing.Point(9, 51)
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
        Me.btnkasir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkasir.Location = New System.Drawing.Point(9, 3)
        Me.btnkasir.Name = "btnkasir"
        Me.btnkasir.Size = New System.Drawing.Size(185, 42)
        Me.btnkasir.TabIndex = 1
        Me.btnkasir.Text = "Kasir"
        Me.btnkasir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnkasir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tittletext)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(909, 44)
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
        Me.PanelUtama.Size = New System.Drawing.Size(909, 595)
        Me.PanelUtama.TabIndex = 2
        '
        'HalamanUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 639)
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
    Friend WithEvents btnpengaturan As FontAwesome.Sharp.IconButton
    Friend WithEvents btngudang As FontAwesome.Sharp.IconButton
    Friend WithEvents btnbukuutang As FontAwesome.Sharp.IconButton
    Friend WithEvents btnkasir As FontAwesome.Sharp.IconButton
    Friend WithEvents tittletext As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelUtama As Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
End Class
