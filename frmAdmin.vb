Public Class frmAdmin
    'Boton de returno al menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        frmAddCliente.actualizarTablas()
        Me.Hide()
        frmMenu.Show()
    End Sub
    'Boton de salida del programa
    Private Sub pctSalir_Click(sender As Object, e As EventArgs) Handles pctSalir.Click
        End
    End Sub
    'Boton para abrir la administracion de productos
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Me.Hide()
        frmAdminProducto.Show()
    End Sub
    'Boton para abrir la administracion de restaurantes
    Private Sub btnAgregarRest_Click(sender As Object, e As EventArgs) Handles btnAgregarRest.Click
        Me.Hide()
        frmAdminRestaurantes.Show()
    End Sub
    'boton para abrir la administracion de motorizados
    Private Sub btnAgregarMotorizado_Click(sender As Object, e As EventArgs) Handles btnAgregarMotorizado.Click
        Me.Hide()
        frmAdminMotorizado.Show()
    End Sub
    'boton para ver la lista de clientes
    Private Sub btnVerClientes_Click(sender As Object, e As EventArgs) Handles btnVerClientes.Click
        Me.Hide()
        frmVerClientes.Show()
    End Sub
End Class