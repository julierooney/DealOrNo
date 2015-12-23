Public Class frmLogin
    Public strPlayerName As String
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        strPlayerName = txtName.Text

        Me.Hide()
        Dim frmMain As New frmMain
        frmMain.ShowDialog()
        Me.Close()

    End Sub
End Class