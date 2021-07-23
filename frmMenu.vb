Public Class frmMenu
    'boton ver pedidos registrados
    Private Sub btnVerPedidos_Click(sender As Object, e As EventArgs) Handles btnVerPedidos.Click
        Me.Hide()
        frmVerPedidos.Show()
    End Sub

    'Boton abrir la consola de administracion
    Private Sub btnAdministracion_Click(sender As Object, e As EventArgs) Handles btnAdministracion.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub
    'Boton regresar a un menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmInfoCurso.Show()
    End Sub
    'Boton salir del programa
    Private Sub pctSalir_Click(sender As Object, e As EventArgs) Handles pctSalir.Click
        End
    End Sub
    'Boton editar pedido 
    Private Sub btnNuevoPedido_Click(sender As Object, e As EventArgs) Handles btnNuevoPedido.Click
        frmAddCliente.actualizarTablas()
        Me.Hide()
        frmEditPedido.Show()
    End Sub



End Class