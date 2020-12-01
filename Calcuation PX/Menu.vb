Public Class MainMenu
    Private Sub btnContent1_Click(sender As Object, e As EventArgs) Handles btnContent1.Click
        Spec.Show()
        Me.Hide()
    End Sub

    Private Sub btnContent2_Click(sender As Object, e As EventArgs) Handles btnContent2.Click
        Capacity.Show()
        Me.Hide()
    End Sub

    Private Sub btnShell_Click(sender As Object, e As EventArgs) Handles btnShell.Click
        Shell.Show()
        Me.Hide()
    End Sub
End Class
