<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cfgkoneksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbhost = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbuser = New System.Windows.Forms.TextBox()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.bttes = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hostname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "db name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'tbhost
        '
        Me.tbhost.Location = New System.Drawing.Point(119, 39)
        Me.tbhost.Name = "tbhost"
        Me.tbhost.Size = New System.Drawing.Size(100, 20)
        Me.tbhost.TabIndex = 4
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(119, 73)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(100, 20)
        Me.tbname.TabIndex = 5
        '
        'tbuser
        '
        Me.tbuser.Location = New System.Drawing.Point(119, 108)
        Me.tbuser.Name = "tbuser"
        Me.tbuser.Size = New System.Drawing.Size(100, 20)
        Me.tbuser.TabIndex = 6
        '
        'tbpass
        '
        Me.tbpass.Location = New System.Drawing.Point(119, 136)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.Size = New System.Drawing.Size(100, 20)
        Me.tbpass.TabIndex = 7
        '
        'bttes
        '
        Me.bttes.Location = New System.Drawing.Point(119, 171)
        Me.bttes.Name = "bttes"
        Me.bttes.Size = New System.Drawing.Size(75, 23)
        Me.bttes.TabIndex = 8
        Me.bttes.Text = "tes"
        Me.bttes.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(114, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cfgkoneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bttes)
        Me.Controls.Add(Me.tbpass)
        Me.Controls.Add(Me.tbuser)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.tbhost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cfgkoneksi"
        Me.Text = "cfgkoneksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbhost As System.Windows.Forms.TextBox
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents tbuser As System.Windows.Forms.TextBox
    Friend WithEvents tbpass As System.Windows.Forms.TextBox
    Friend WithEvents bttes As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
