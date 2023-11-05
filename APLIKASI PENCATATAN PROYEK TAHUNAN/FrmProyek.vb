Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Public Class FrmProyek
    Dim databaru As Boolean

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Sub tampilkandata()
        konekdb()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        da = New SqlDataAdapter("SELECT * FROM Proyek", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Proyek")
        DataGridView1.DataSource = (ds.Tables("Proyek"))
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

    Private Sub FrmProyek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CATATAN_PROYEK_TAHUNANDataSet4.Proyek' table. You can move, or remove it, as needed.
        Me.ProyekTableAdapter.Fill(Me.APP_CATATAN_PROYEK_TAHUNANDataSet4.Proyek)
        databaru = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Pilih Gambar(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            TextBox8.Text = (opf.FileName)
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesan As String
        konekdb()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Data belum lengkap!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            pesan = MsgBox("Apakah Anda ingin yakin ingin menambahkan data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
            End If
            Dim cmd As New SqlCommand("INSERT INTO Proyek(Kdproyek,Kdkategori,Kdjenisperusahaan,Judul_proyek,Deskripsi_pekerjaan,Tahun_proyek,Nilai_kontrak,Kdmember,Foto) VALUES (@kdproyek,@kdkategori,@kdjenis,@judul,@deskripsi,@tahun,@Nilai,@kdmember,@foto)", konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            cmd.Parameters.Add("@kdproyek", SqlDbType.Int).Value = TextBox1.Text
            cmd.Parameters.Add("@kdkategori", SqlDbType.Int).Value = TextBox2.Text
            cmd.Parameters.Add("@kdjenis", SqlDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@judul", SqlDbType.VarChar).Value = TextBox4.Text
            cmd.Parameters.Add("@deskripsi", SqlDbType.VarChar).Value = TextBox5.Text
            cmd.Parameters.Add("@tahun", SqlDbType.VarChar).Value = ComboBox1.Text
            cmd.Parameters.Add("@Nilai", SqlDbType.Decimal).Value = TextBox6.Text
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = ms.ToArray
            cmd.Parameters.Add("@kdmember", SqlDbType.Int).Value = TextBox7.Text
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("Data berhasil disimpan!", vbInformation)
                tampilkandata()
                bersihkandata()
            Else
                MsgBox("Data gagal disimpan!", vbExclamation)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan As String
        konekdb()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Silahkan cari data yang ingin di Ubah terlebih dahulu!", vbExclamation)
            Exit Sub
        Else
            pesan = MsgBox("Apakah anda ingin melanjutkan mengubah data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
                TextBox1.Focus()
            End If
            Dim ubah As String = "UPDATE Proyek SET Kdkategori = '" + TextBox2.Text + "', Kdjenisperusahaan = '" + TextBox3.Text + "', Judul_proyek = '" + TextBox4.Text + "', Deskripsi_pekerjaan = '" + TextBox5.Text + "', Tahun_proyek = '" + ComboBox1.Text + "', Nilai_kontrak = '" + TextBox6.Text + "', Kdmember = '" + TextBox7.Text + "', Foto=@photo WHERE Kdproyek = '" + TextBox1.Text + "'"
            Dim cmd As New SqlCommand(ubah, konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img As Byte()
            img = ms.ToArray
            cmd.Parameters.Add("@photo", SqlDbType.Image).Value = img
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("Data berhasil diubah!", vbInformation)
                bersihkandata()
                tampilkandata()
            Else
                MsgBox("Data gagal diubah!", vbExclamation)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        konekdb()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Silahkan cari data terlebih dahulu!", vbExclamation)
            Exit Sub
        Else
            pesan = MsgBox("Apakah anda ingin melanjutkan menghapus data ini?", vbYesNo + vbInformation)
            If pesan = vbNo Then
                Exit Sub
                TextBox1.Focus()
            End If
            Dim hapus As String = "DELETE FROM Proyek WHERE Kdproyek LIKE '" + TextBox1.Text + "'"
            Dim cmd As New SqlCommand(hapus, konek)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img As Byte()
            img = ms.ToArray
            cmd.Parameters.Add("@photo", SqlDbType.Image).Value = img
            If cmd.ExecuteNonQuery = 1 Then
                MsgBox("Data berhasil dihapus!", vbInformation)
                bersihkandata()
            Else
                MsgBox("Data gagal dihapus!", vbExclamation)
            End If
            konek.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql As String
        konekdb()
        sql = "SELECT * FROM Proyek Where Kdmember = '" + TextBox1.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        Dim img As Byte() = DirectCast(rd.Item(7), Byte())
        Dim ms As MemoryStream = New MemoryStream(img)
        If rd.HasRows Then
            TextBox1.Text = rd.Item(0)
            TextBox2.Text = rd.Item(1)
            TextBox3.Text = rd.Item(2)
            TextBox4.Text = rd.Item(3)
            TextBox5.Text = rd.Item(4)
            ComboBox1.Text = rd.Item(5)
            TextBox6.Text = rd.Item(6)
            TextBox7.Text = rd.Item(8)
            PictureBox1.Image = Image.FromStream(ms)
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If FrmAdmin.Label3.Text = "Administrator" Then
            FrmAdmin.Show()
            Me.Hide()
        ElseIf FrmOperator.Label3.Text = "Budiyono" Then
            FrmOperator.Show()
            Me.Hide()
        ElseIf FrmOperator.Label3.Text = "Loliyanto" Then
            FrmOperator.Show()
            Me.Hide()
        End If
    End Sub
End Class