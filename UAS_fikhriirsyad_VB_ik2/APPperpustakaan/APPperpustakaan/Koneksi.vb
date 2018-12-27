Imports System.IO
Imports System.Xml

Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module Koneksi
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection


    Public Sub OpenKoneksi(Optional ByVal mode = "")
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim cfg_host As String = ""
        Dim cfg_name As String = ""
        Dim cfg_uname As String = ""
        Dim cfg_pas As String = ""


        Try
            Dim fs As New FileStream("configDB.xml", FileMode.Open, FileAccess.Read)
            xmldoc.Load(fs)
            xmlnode = xmldoc.GetElementsByTagName("dbconfig")
            For i = 0 To xmlnode.Count - 1
                cfg_host = xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                cfg_name = xmlnode(i).ChildNodes.Item(1).InnerText.Trim()
                cfg_uname = xmlnode(i).ChildNodes.Item(2).InnerText.Trim()
                cfg_pas = xmlnode(i).ChildNodes.Item(3).InnerText.Trim()

            Next
            fs.Close()
        Catch ex As Exception
            MsgBox("Error Config: " & ex.ToString)
        End Try

        Dim str As String = "Data Source=" + cfg_host + ";" & _
                            "Initial Catalog=" + cfg_name + ";" & _
                            "Persist Security Info=True;" & _
                            "UID=" + cfg_uname + ";PWD=" + cfg_pas + ""



        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal: " & ex.ToString)
                Exit Sub
            End Try
        End If

        If mode = "testing" Then
            MsgBox("Berhasil")
        End If
    End Sub

    Public Sub CloseKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Error " & ex.ToString)
            End Try
        End If
    End Sub

End Module
