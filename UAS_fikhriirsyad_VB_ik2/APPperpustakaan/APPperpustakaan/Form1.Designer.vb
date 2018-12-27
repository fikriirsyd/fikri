<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbidpinjam = New System.Windows.Forms.TextBox()
        Me.tbnamaanggota = New System.Windows.Forms.TextBox()
        Me.btadd = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbjudulbuku = New System.Windows.Forms.ComboBox()
        Me.lvpeminjaman = New System.Windows.Forms.ListView()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbidpinjam
        '
        Me.tbidpinjam.Location = New System.Drawing.Point(154, 53)
        Me.tbidpinjam.Name = "tbidpinjam"
        Me.tbidpinjam.Size = New System.Drawing.Size(200, 20)
        Me.tbidpinjam.TabIndex = 0
        '
        'tbnamaanggota
        '
        Me.tbnamaanggota.Location = New System.Drawing.Point(154, 79)
        Me.tbnamaanggota.Name = "tbnamaanggota"
        Me.tbnamaanggota.Size = New System.Drawing.Size(200, 20)
        Me.tbnamaanggota.TabIndex = 1
        '
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(369, 128)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(75, 23)
        Me.btadd.TabIndex = 4
        Me.btadd.Text = "Add"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(154, 176)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 5
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IdPinjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tgl pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Judul Buku"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(154, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'cbjudulbuku
        '
        Me.cbjudulbuku.FormattingEnabled = True
        Me.cbjudulbuku.Location = New System.Drawing.Point(154, 138)
        Me.cbjudulbuku.Name = "cbjudulbuku"
        Me.cbjudulbuku.Size = New System.Drawing.Size(200, 21)
        Me.cbjudulbuku.TabIndex = 11
        '
        'lvpeminjaman
        '
        Me.lvpeminjaman.Location = New System.Drawing.Point(29, 240)
        Me.lvpeminjaman.Name = "lvpeminjaman"
        Me.lvpeminjaman.Size = New System.Drawing.Size(415, 126)
        Me.lvpeminjaman.TabIndex = 12
        Me.lvpeminjaman.UseCompatibleStateImageBehavior = False
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(54, 215)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(50, 20)
        Me.tbjumlah.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 399)
        Me.Controls.Add(Me.tbjumlah)
        Me.Controls.Add(Me.lvpeminjaman)
        Me.Controls.Add(Me.cbjudulbuku)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.btadd)
        Me.Controls.Add(Me.tbnamaanggota)
        Me.Controls.Add(Me.tbidpinjam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbidpinjam As System.Windows.Forms.TextBox
    Friend WithEvents tbnamaanggota As System.Windows.Forms.TextBox
    Friend WithEvents btadd As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbjudulbuku As System.Windows.Forms.ComboBox
    Friend WithEvents lvpeminjaman As System.Windows.Forms.ListView
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox

End Class
