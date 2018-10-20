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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnameof = New System.Windows.Forms.TextBox()
        Me.tbidnumber = New System.Windows.Forms.TextBox()
        Me.tbunit = New System.Windows.Forms.TextBox()
        Me.Tbinstruction = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbtounitdestination = New System.Windows.Forms.TextBox()
        Me.tbac = New System.Windows.Forms.TextBox()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.cbtransportation = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpdateofissue = New System.Windows.Forms.DateTimePicker()
        Me.btsend = New System.Windows.Forms.Button()
        Me.tbtransportation = New System.Windows.Forms.TextBox()
        Me.lvrequest = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.trequestid = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Requestor"
        '
        'tbnameof
        '
        Me.tbnameof.Location = New System.Drawing.Point(152, 57)
        Me.tbnameof.Name = "tbnameof"
        Me.tbnameof.Size = New System.Drawing.Size(100, 20)
        Me.tbnameof.TabIndex = 1
        '
        'tbidnumber
        '
        Me.tbidnumber.Location = New System.Drawing.Point(152, 94)
        Me.tbidnumber.Name = "tbidnumber"
        Me.tbidnumber.Size = New System.Drawing.Size(100, 20)
        Me.tbidnumber.TabIndex = 2
        '
        'tbunit
        '
        Me.tbunit.Location = New System.Drawing.Point(152, 120)
        Me.tbunit.Name = "tbunit"
        Me.tbunit.Size = New System.Drawing.Size(100, 20)
        Me.tbunit.TabIndex = 3
        '
        'Tbinstruction
        '
        Me.Tbinstruction.Location = New System.Drawing.Point(152, 207)
        Me.Tbinstruction.Multiline = True
        Me.Tbinstruction.Name = "Tbinstruction"
        Me.Tbinstruction.Size = New System.Drawing.Size(404, 44)
        Me.Tbinstruction.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "date of issue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Instruction"
        '
        'tbtounitdestination
        '
        Me.tbtounitdestination.Location = New System.Drawing.Point(505, 57)
        Me.tbtounitdestination.Name = "tbtounitdestination"
        Me.tbtounitdestination.Size = New System.Drawing.Size(121, 20)
        Me.tbtounitdestination.TabIndex = 9
        '
        'tbac
        '
        Me.tbac.Location = New System.Drawing.Point(505, 83)
        Me.tbac.Name = "tbac"
        Me.tbac.Size = New System.Drawing.Size(121, 20)
        Me.tbac.TabIndex = 10
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(505, 163)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(121, 20)
        Me.tbphone.TabIndex = 11
        '
        'cbtransportation
        '
        Me.cbtransportation.FormattingEnabled = True
        Me.cbtransportation.Location = New System.Drawing.Point(505, 119)
        Me.cbtransportation.Name = "cbtransportation"
        Me.cbtransportation.Size = New System.Drawing.Size(121, 21)
        Me.cbtransportation.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(373, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "to Unit/Destination"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "A/C Reg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(373, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Transportation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(373, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Ext.Phone/HP"
        '
        'dtpdateofissue
        '
        Me.dtpdateofissue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdateofissue.Location = New System.Drawing.Point(152, 170)
        Me.dtpdateofissue.Name = "dtpdateofissue"
        Me.dtpdateofissue.Size = New System.Drawing.Size(164, 20)
        Me.dtpdateofissue.TabIndex = 17
        '
        'btsend
        '
        Me.btsend.Location = New System.Drawing.Point(152, 257)
        Me.btsend.Name = "btsend"
        Me.btsend.Size = New System.Drawing.Size(75, 23)
        Me.btsend.TabIndex = 18
        Me.btsend.Text = "send request"
        Me.btsend.UseVisualStyleBackColor = True
        '
        'tbtransportation
        '
        Me.tbtransportation.Location = New System.Drawing.Point(632, 124)
        Me.tbtransportation.Name = "tbtransportation"
        Me.tbtransportation.Size = New System.Drawing.Size(100, 20)
        Me.tbtransportation.TabIndex = 19
        '
        'lvrequest
        '
        Me.lvrequest.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvrequest.Location = New System.Drawing.Point(64, 308)
        Me.lvrequest.Name = "lvrequest"
        Me.lvrequest.Size = New System.Drawing.Size(652, 164)
        Me.lvrequest.TabIndex = 20
        Me.lvrequest.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(107, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.EditToolStripMenuItem.Text = "edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(264, 256)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(75, 23)
        Me.btupdate.TabIndex = 21
        Me.btupdate.Text = "update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'trequestid
        '
        Me.trequestid.Location = New System.Drawing.Point(591, 269)
        Me.trequestid.Name = "trequestid"
        Me.trequestid.Size = New System.Drawing.Size(48, 20)
        Me.trequestid.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 498)
        Me.Controls.Add(Me.trequestid)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.lvrequest)
        Me.Controls.Add(Me.tbtransportation)
        Me.Controls.Add(Me.btsend)
        Me.Controls.Add(Me.dtpdateofissue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbtransportation)
        Me.Controls.Add(Me.tbphone)
        Me.Controls.Add(Me.tbac)
        Me.Controls.Add(Me.tbtounitdestination)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tbinstruction)
        Me.Controls.Add(Me.tbunit)
        Me.Controls.Add(Me.tbidnumber)
        Me.Controls.Add(Me.tbnameof)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnameof As System.Windows.Forms.TextBox
    Friend WithEvents tbidnumber As System.Windows.Forms.TextBox
    Friend WithEvents tbunit As System.Windows.Forms.TextBox
    Friend WithEvents Tbinstruction As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbtounitdestination As System.Windows.Forms.TextBox
    Friend WithEvents tbac As System.Windows.Forms.TextBox
    Friend WithEvents tbphone As System.Windows.Forms.TextBox
    Friend WithEvents cbtransportation As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpdateofissue As System.Windows.Forms.DateTimePicker
    Friend WithEvents btsend As System.Windows.Forms.Button
    Friend WithEvents tbtransportation As System.Windows.Forms.TextBox
    Friend WithEvents lvrequest As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents trequestid As System.Windows.Forms.TextBox

End Class
