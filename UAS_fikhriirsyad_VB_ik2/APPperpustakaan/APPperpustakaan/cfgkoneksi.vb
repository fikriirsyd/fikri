Imports System.IO
Imports System.Xml
Public Class cfgkoneksi

    Private Sub bttes_Click(sender As System.Object, e As System.EventArgs) Handles bttes.Click
        Dim writer As New XmlTextWriter("configDB.xml", System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Config")

        writer.WriteStartElement("dbconfig")

        writer.WriteStartElement("Hostname")
        writer.WriteString(tbhost.Text)
        writer.WriteEndElement()


        writer.WriteStartElement("DbName")
        writer.WriteString(tbname.Text)
        writer.WriteEndElement()

        writer.WriteStartElement("DbUser")
        writer.WriteString(tbuser.Text)
        writer.WriteEndElement()

        writer.WriteStartElement("DbPaswword")
        writer.WriteString(tbpass.Text)
        writer.WriteEndElement()

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()


        Call OpenKoneksi("testing")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class