Public Class frmAdmin
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        frmAddCliente.actualizarTablas()
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub pctSalir_Click(sender As Object, e As EventArgs) Handles pctSalir.Click
        End
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Me.Hide()
        frmAdminProducto.Show()
    End Sub

    Private Sub btnAgregarRest_Click(sender As Object, e As EventArgs) Handles btnAgregarRest.Click
        Me.Hide()
        frmAdminRestaurantes.Show()
    End Sub

    Private Sub btnAgregarMotorizado_Click(sender As Object, e As EventArgs) Handles btnAgregarMotorizado.Click
        Me.Hide()
        frmAdminMotorizado.Show()
    End Sub

    Private Sub btnVerClientes_Click(sender As Object, e As EventArgs) Handles btnVerClientes.Click
        Me.Hide()
        frmVerClientes.Show()
    End Sub
End Class