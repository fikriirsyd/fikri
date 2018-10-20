Imports System.Data.SqlClient

Public Class Form1
    Dim transport As String
    Dim DateIssue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbtransportation.Items.Add("Pick Up")
        cbtransportation.Items.Add("Box")
        cbtransportation.Items.Add("Blind van")
        cbtransportation.Items.Add("truck")
        cbtransportation.Items.Add("BTT")
        cbtransportation.Items.Add("Forklift")
        cbtransportation.Items.Add("Other")

        tbtransportation.Visible = False
        trequestid.Visible = False
        btupdate.Visible = False
        list_view()

    End Sub

    Private Sub cbtransportation_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbtransportation.SelectedIndexChanged
        transport = cbtransportation.Text
        If cbtransportation.Text = "Other" Then
            tbtransportation.Visible = True
        End If
    End Sub

    Private Sub btsend_Click(sender As System.Object, e As System.EventArgs) Handles btsend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim requestid As String


        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(requestId)+1 AS MXID FROM transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            requestid = dr("MXID")
            dr.Close()
            MsgBox("berhasil")
            query = "INSERT INTO transportation (requestId,namerequestor,requestorld,unit,deteissue,unitdestination,acregis,transportation,phone,instruction)" & _
                     "VALUES (" & requestid & ",'" & tbnameof.Text & "','" & tbidnumber.Text & "','" & tbunit.Text & "','" & DateIssue & "','" & tbtounitdestination.Text & "','" & tbac.Text & "'," & _
                     " '" & transport & "','" & tbphone.Text & "','" & Tbinstruction.Text & "')"

        
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            clear_from()
            lvrequest.Clear()
            list_view()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub clear_from()

        tbnameof.Text = ""
        tbidnumber.Text = ""
        tbunit.Text = ""
        dtpdateofissue.Text = ""
        Tbinstruction.Text = ""
        tbtounitdestination.Text = ""
        tbac.Text = ""
        tbtransportation.Text = ""
        tbphone.Text = ""

    End Sub

    Private Sub tbtransportation_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbtransportation.TextChanged
        transport = tbtransportation.Text
    End Sub

    Private Sub list_view()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        lvrequest.View = View.Details
        lvrequest.Columns.Add("No", 50)
        lvrequest.Columns.Add("Nama of requestor", 150)
        lvrequest.Columns.Add("unit from", 100)
        lvrequest.Columns.Add("unit to", 150)
        lvrequest.Columns.Add("request date", 100)
        lvrequest.Columns.Add("Transportation", 200)
        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                lvrequest.Items.Add(dr("requestId"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("namerequestor"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("unit"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("unitdestination"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("deteissue"))
                lvrequest.Items(lvrequest.Items.Count - 1).SubItems.Add(dr("transportation"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String

        Try

            id = lvrequest.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "Select * from transportation Where requestId ='" + id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            tbnameof.Text = dr("namerequestor")
            tbunit.Text = dr("unit")
            tbtounitdestination.Text = dr("unitdestination")
            dtpdateofissue.Text = dr("deteissue")
            tbtransportation.Text = dr("transportation")
            tbidnumber.Text = dr("requestId")
            btsend.Text = "Update"
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            id = lvrequest.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "Delete from transportation Where requestId='" + id + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            lvrequest.Clear()
            list_view()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btupdate.Click
        btupdate.Visible = False
        btsend.Visible = True
        Dim cmd_gl As SqlCommand
        Dim dr_gl As SqlDataReader
        Dim query_gl As String

        Try
            Call OpenKoneksi()
            query_gl = "UPDATE requestId SET " & _
                                "namerequestor = '" & tbnameof.Text & "', " & _
                                "requestorld = '" & tbidnumber.Text & "', " & _
                                "unit = '" & tbunit.Text & "', " & _
                                "deteissue = '" & DateIssue & "', " & _
                                "unitdestination = '" & tbtounitdestination.Text & "', " & _
                                "acregis = '" & tbac.Text & "', " & _
                                "transportation = '" & transport & "', " & _
                                "phone= '" & tbphone.Text & "', " & _
                                "instruction = '" & Tbinstruction.Text & "' " & _
                                "WHERE requestId = " & trequestid.Text & " "
            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            clear_from()

            lvrequest.Clear()
            list_view()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
