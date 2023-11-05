Imports System.Data.SqlClient
Public Class FrmCategoryProyek
    Dim databaru As Boolean

    Sub tampikandata()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        konekdb()
        da = New SqlDataAdapter("SELECT * FROM Kategori_proyek", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Kategori_proyek")
        DataGridView1.DataSource = (ds.Tables("Kategori_proyek"))
    End Sub

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub jalankansql(ByVal sql As String)
        Dim sqlcmd As New SqlCommand
        Try
            konekdb()
            sqlcmd.Connection = konek
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.CommandText = sql
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try
    End Sub
    Private Sub FrmCategoryProyek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CATATAN_PROYEK_TAHUNANDataSet1.Kategori_proyek' table. You can move, or remove it, as needed.
        Me.Kategori_proyekTableAdapter1.Fill(Me.APP_CATATAN_PROYEK_TAHUNANDataSet1.Kategori_proyek)
        databaru = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesan, simpan As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah Anda yakin ingin menambahkan data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                simpan = "INSERT INTO Kategori_proyek(Kdkategori,Nama_kategori) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "')"
                jalankansql(simpan)
                MsgBox("Data berhasil ditambahkan!", vbInformation)
                bersihkandata()
                tampikandata()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan, edit As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan cari data yang ingin di Edit terlebih dahulu!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah Anda yakin ingin mengedit data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                edit = "UPDATE Kategori_proyek SET Nama_kategori = '" + TextBox2.Text + "' WHERE Kdkategori = '" + TextBox1.Text + "'"
                jalankansql(edit)
                MsgBox("Data berhasil diedit!", vbInformation)
                bersihkandata()
                tampikandata()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan, hapus As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan cari Data yang ingin dihapus terlebih dahulu!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah Anda yakin ingin menghapuss data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                hapus = "DELETE FROM Kategori_proyek WHERE Kdkategori LIKE '" + TextBox1.Text + "'"
                jalankansql(hapus)
                MsgBox("Data berhasil di Hapus!", vbInformation)
                bersihkandata()
                tampikandata()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM Kategori_proyek WHERE Kdkategori = '" + TextBox1.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox1.Text = rd.Item(0)
            TextBox2.Text = rd.Item(1)
        Else
            MsgBox("Data tidak ditemukan, silahkan masukan Kode Kategori dengan benar!", vbExclamation)
        End If
    End Sub
End Class