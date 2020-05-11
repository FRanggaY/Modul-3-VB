<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TomTanya = New System.Windows.Forms.Button()
        Me.TomKeluar = New System.Windows.Forms.Button()
        Me.NextModul = New System.Windows.Forms.Button()
        Me.MenuAwal = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(174, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 38)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "^"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(279, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 38)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(69, 195)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 38)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(174, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 38)
        Me.Button4.TabIndex = 72
        Me.Button4.Text = "V"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Modul_VB_3.My.Resources.Resources.pngtree_struggling_run_poster_background_image_130090
        Me.PictureBox1.Location = New System.Drawing.Point(158, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TomTanya)
        Me.GroupBox3.Controls.Add(Me.TomKeluar)
        Me.GroupBox3.Controls.Add(Me.NextModul)
        Me.GroupBox3.Controls.Add(Me.MenuAwal)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 302)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 68)
        Me.GroupBox3.TabIndex = 74
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
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(508, 381)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form8"
        Me.Text = "Modul 7"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Button1 As Button
    Public WithEvents Button2 As Button
    Public WithEvents Button3 As Button
    Public WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TomTanya As Button
    Friend WithEvents TomKeluar As Button
    Friend WithEvents NextModul As Button
    Friend WithEvents MenuAwal As Button
End Class
