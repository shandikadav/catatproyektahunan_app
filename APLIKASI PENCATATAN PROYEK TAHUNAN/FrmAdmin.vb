Public Class FrmAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminNav.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmProyek.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub
End Class