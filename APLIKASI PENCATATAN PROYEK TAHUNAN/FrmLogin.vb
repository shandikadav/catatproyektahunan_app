Imports System.Data.SqlClient
Public Class FrmLogin
    Sub bersihkandata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql, user, pass, level As String
        konekdb()
        user = TextBox1.Text
        pass = TextBox2.Text
        level = ComboBox1.Text
        sql = "SELECT * FROM Member WHERE Username = '" + user + "' AND Password = '" + pass + "'AND Level = '" + level + "'"
        cmd = New SqlCommand(sql, konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data belum Lengkap!", vbExclamation)
        Else
            If level = "Admin" Then
                If rd.HasRows = True Then
                    MsgBox("Login Administrator berhasil!", vbInformation)
                    FrmAdmin.Label3.Text = rd.Item(3)
                    FrmAdmin.Show()
                    Me.Hide()
                    bersihkandata()
                End If
            ElseIf level = "Operator" Then
                If rd.HasRows = True Then
                    MsgBox("Login Operator berhasil!", vbInformation)
                    FrmOperator.Label3.Text = rd.Item(3)
                    FrmOperator.Show()
                    Me.Hide()
                    bersihkandata()
                End If
            Else
                MessageBox.Show("Username, Password atau Level salah, silahkan cek kembali!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bersihkandata()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class
