Public Class frmInfoCurso
    'boton ver informacion del proyecto
    Private Sub btnVerInfoApp_Click(sender As Object, e As EventArgs) Handles btnVerInfoApp.Click
        Me.Hide()
        frmInfoApp.Show()
    End Sub
    'Boton inicial el programa
    Private Sub btnVerProyecto_Click(sender As Object, e As EventArgs) Handles btnVerProyecto.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class