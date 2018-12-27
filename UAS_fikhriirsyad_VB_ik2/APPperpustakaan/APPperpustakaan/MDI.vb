Public Class MDI

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PeminjamanToolStripMenuItem.Click
        Dim myform As New Form1()
        myform.Show()
        myform.MdiParent = Me
    End Sub
End Class