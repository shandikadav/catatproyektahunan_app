Imports System.Data.SqlClient
Public Class FrmMember
    Dim databaru As Boolean

    Sub tampikandata()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        konekdb()
        da = New SqlDataAdapter("SELECT * FROM Member", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Member")
        DataGridView1.DataSource = (ds.Tables("Member"))
    End Sub

    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
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

    Private Sub FrmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APP_CATATAN_PROYEK_TAHUNANDataSet3.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.APP_CATATAN_PROYEK_TAHUNANDataSet3.Member)
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
                simpan = "INSERT INTO Member(Kdmember,Username,Password,Nama,Level) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')"
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
                edit = "UPDATE Member SET Username = '" + TextBox2.Text + "', Password = '" + TextBox3.Text + "', Nama = '" + TextBox4.Text + "' WHERE Kdmember = '" + TextBox1.Text + "'"
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
            MsgBox("Silahkan cari data yang ingin di Hapus terlebih dahulu!", vbExclamation)
            Exit Sub
            TextBox1.Focus()
        Else
            If databaru Then
                pesan = MsgBox("Apakah Anda yakin ingin menghapus data ini?", vbYesNo + vbInformation)
                If pesan = vbNo Then
                    Exit Sub
                    TextBox1.Focus()
                End If
                hapus = "DELETE FROM Member WHERE Kdmember LIKE '" + TextBox1.Text + "'"
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
        sql = "SELECT * FROM Member WHERE Kdmember = '" + TextBox1.Text + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox1.Text = rd.Item(0)
            TextBox2.Text = rd.Item(1)
            TextBox3.Text = rd.Item(2)
            TextBox4.Text = rd.Item(3)
            ComboBox1.Text = rd.Item(4)
        Else
            MsgBox("Data tidak ditemukan, silahkan masukan Kode Member dengan benar!", vbExclamation)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox3.PasswordChar = ""
        Else
            TextBox3.PasswordChar = "*"
        End If
    End Sub
End Class