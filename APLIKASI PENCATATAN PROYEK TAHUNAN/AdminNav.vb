Public Class AdminNav
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCategoryProyek.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmJenisPerusahaan.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmMember.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmAdmin.Show()
        Me.Hide()
    End Sub
End Class