Public Class FrmOperator
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmProyek.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub
End Class