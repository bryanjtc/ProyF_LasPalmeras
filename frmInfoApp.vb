Public Class frmInfoApp
    'Boton Regresar al menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmInfoCurso.Show()
    End Sub
End Class