Public Class frmAdmin
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        frmAdminProducto.Show()
    End Sub

    Private Sub btnAgregarRest_Click(sender As Object, e As EventArgs) Handles btnAgregarRest.Click
        frmAdminRestaurantes.Show()
    End Sub

    Private Sub btnAgregarMotorizado_Click(sender As Object, e As EventArgs) Handles btnAgregarMotorizado.Click
        frmAdminMotorizado.Show()
    End Sub
End Class