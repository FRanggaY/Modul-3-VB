<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.combobox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TomTanya = New System.Windows.Forms.Button()
        Me.TomKeluar = New System.Windows.Forms.Button()
        Me.NextModul = New System.Windows.Forms.Button()
        Me.MenuAwal = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'combobox1
        '
        Me.combobox1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox1.FormattingEnabled = True
        Me.combobox1.Location = New System.Drawing.Point(168, 26)
        Me.combobox1.Name = "combobox1"
        Me.combobox1.Size = New System.Drawing.Size(214, 31)
        Me.combobox1.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(21, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 24)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Nama Pulau"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(21, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Provinsi"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Location = New System.Drawing.Point(168, 98)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(214, 234)
        Me.ListBox1.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(410, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 38)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(410, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 38)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Tambahkan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 23
        Me.ListBox2.Location = New System.Drawing.Point(622, 98)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(214, 234)
        Me.ListBox2.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(618, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Provinsi Terpilih"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TomTanya)
        Me.GroupBox3.Controls.Add(Me.TomKeluar)
        Me.GroupBox3.Controls.Add(Me.NextModul)
        Me.GroupBox3.Controls.Add(Me.MenuAwal)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(25, 355)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 68)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        '
        'TomTanya
        '
        Me.TomTanya.BackColor = System.Drawing.Color.Black
        Me.TomTanya.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomTanya.ForeColor = System.Drawing.Color.White
        Me.TomTanya.Location = New System.Drawing.Point(16, 19)
        Me.TomTanya.Name = "TomTanya"
        Me.TomTanya.Size = New System.Drawing.Size(65, 43)
        Me.TomTanya.TabIndex = 15
        Me.TomTanya.Text = "?"
        Me.TomTanya.UseVisualStyleBackColor = False
        '
        'TomKeluar
        '
        Me.TomKeluar.BackColor = System.Drawing.Color.Black
        Me.TomKeluar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomKeluar.ForeColor = System.Drawing.Color.White
        Me.TomKeluar.Location = New System.Drawing.Point(96, 19)
        Me.TomKeluar.Name = "TomKeluar"
        Me.TomKeluar.Size = New System.Drawing.Size(65, 43)
        Me.TomKeluar.TabIndex = 14
        Me.TomKeluar.Text = "X"
        Me.TomKeluar.UseVisualStyleBackColor = False
        '
        'NextModul
        '
        Me.NextModul.BackColor = System.Drawing.Color.Black
        Me.NextModul.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextModul.ForeColor = System.Drawing.Color.White
        Me.NextModul.Location = New System.Drawing.Point(335, 19)
        Me.NextModul.Name = "NextModul"
        Me.NextModul.Size = New System.Drawing.Size(134, 44)
        Me.NextModul.TabIndex = 12
        Me.NextModul.Text = "Next Modul"
        Me.NextModul.UseVisualStyleBackColor = False
        '
        'MenuAwal
        '
        Me.MenuAwal.BackColor = System.Drawing.Color.Black
        Me.MenuAwal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuAwal.ForeColor = System.Drawing.Color.White
        Me.MenuAwal.Location = New System.Drawing.Point(178, 19)
        Me.MenuAwal.Name = "MenuAwal"
        Me.MenuAwal.Size = New System.Drawing.Size(134, 44)
        Me.MenuAwal.TabIndex = 11
        Me.MenuAwal.Text = "Menu Awal"
        Me.MenuAwal.UseVisualStyleBackColor = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(858, 435)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combobox1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Form9"
        Me.Text = "Modul 8"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combobox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Public WithEvents Button2 As Button
    Public WithEvents Button1 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TomTanya As Button
    Friend WithEvents TomKeluar As Button
    Friend WithEvents NextModul As Button
    Friend WithEvents MenuAwal As Button
End Class
