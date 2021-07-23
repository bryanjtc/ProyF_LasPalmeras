Public Class frmInfoCurso

    Private Sub btnVerInfoApp_Click(sender As Object, e As EventArgs) Handles btnVerInfoApp.Click
        Me.Hide()
        frmInfoApp.Show()
    End Sub

    Private Sub btnVerProyecto_Click(sender As Object, e As EventArgs) Handles btnVerProyecto.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class