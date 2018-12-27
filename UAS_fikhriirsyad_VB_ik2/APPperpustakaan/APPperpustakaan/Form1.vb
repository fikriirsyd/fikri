Imports System.Data.SqlClient
Public Class Form1
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String
    Dim query As String
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()
        tbjumlah.ReadOnly = True

        tbjumlah.Text = lvpeminjaman.Items.Count

        tbidpinjam.ReadOnly = True

        tbnamaanggota.MaxLength = 50

        Try
            sql = "select * from buku"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            cbjudulbuku.Items.Clear()
            Do While dr.Read
                cbjudulbuku.Items.Add(dr("idBuku") & "-" & dr("judulbuku"))
            Loop
            dr.Close()
            show_peminjaman()
            idPinjam()

            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub
    Private Sub show_peminjaman()
        lvpeminjaman.View = View.Details        lvpeminjaman.Columns.Add("NO", 50)        lvpeminjaman.Columns.Add("Id Buku", 150)        lvpeminjaman.Columns.Add("Judul Buku", 150)
    End Sub

    Private Sub btadd_Click(sender As System.Object, e As System.EventArgs) Handles btadd.Click
        Dim no As Integer
        Dim idBuku As String
        Dim buku As Array = cbjudulbuku.Text.Split("-")
        Dim JudulBuku As String

        If cbjudulbuku.Text = "" Then
            MsgBox("Pilih Buku")
            Exit Sub
        End If

        no = lvpeminjaman.Items.Count()
        idBuku = buku(0)
        JudulBuku = buku(1)

        lvpeminjaman.Items.Add(no + 1)
        lvpeminjaman.Items(lvpeminjaman.Items.Count - 1).SubItems.Add(idBuku)
        lvpeminjaman.Items(lvpeminjaman.Items.Count - 1).SubItems.Add(JudulBuku)

        cbjudulbuku.Text = ""
        tbjumlah.Text = lvpeminjaman.Items.Count
    End Sub
    Private Sub idPinjam()


        Try
            Call OpenKoneksi()
            cmd = New SqlCommand("select * from peminjaman_header order by idPinjaman desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If Not dr.HasRows Then
                tbidpinjam.Text = "P001"
            Else
                tbidpinjam.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("idPinjaman").ToString, 3, 2)) + 1
                If Len(tbidpinjam.Text) = 1 Then
                    tbidpinjam.Text = "P00" & tbidpinjam.Text & ""
                ElseIf Len(tbidpinjam.Text) = 2 Then
                    tbidpinjam.Text = "P0" & tbidpinjam.Text & ""
                ElseIf Len(tbidpinjam.Text) = 3 Then
                    tbidpinjam.Text = "P" & tbidpinjam.Text & ""
                End If
            End If

            Call CloseKoneksi()

        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub simpan_Click(sender As System.Object, e As System.EventArgs) Handles simpan.Click
        Dim detail_id As String
        Dim query_id As String

        If tbjumlah.Text = 0 Then
            MsgBox("Pilih Buku Terlebih Dahulu")
            Exit Sub
        End If

        If tbnamaanggota.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")
        End If

        Try
            Call OpenKoneksi()

            query = "INSERT INTO peminjaman_header(idPinjaman, NamaAnggota, Tglpinjam, jumlahpinjam)"
            query &= "VALUES('" & tbidpinjam.Text & "', '" & tbnamaanggota.Text & "', '" & DateTimePicker1.Text & "', '" & tbjumlah.Text & "')"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            query = "INSERT INTO peminjaman_detail(id,idPinjam,JudulBuku)VALUES"
            For i = 0 To lvpeminjaman.Items.Count - 1
                query_id = " select ISNULL(MAX(id),0)+1 as MXID from peminjaman_detail"
                cmd = New SqlCommand(query_id, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                detail_id = dr("MXID") + i
                dr.Close()

                query &= "(" & detail_id & ",'" & tbidpinjam.Text & "','" & lvpeminjaman.Items(i).SubItems(2).Text.Trim & "'),"
            Next
            cmd = New SqlCommand(query.Trim(","), conn)
            dr = cmd.ExecuteReader
            dr.Close()

            lvpeminjaman.Items.Clear()
            tbidpinjam.Text = ""
            tbjumlah.Text = ""
            tbnamaanggota.Text = ""
            DateTimePicker1.Text = ""

            idPinjam()
            tbjumlah.Text = lvpeminjaman.Items.Count

            MsgBox("Data Pinjam Berhasil Disimpan")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
