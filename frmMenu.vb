Public Class frmMenu
    Private Sub btnVerPedidos_Click(sender As Object, e As EventArgs) Handles btnVerPedidos.Click
        Me.Hide()
        frmVerPedidos.Show()
    End Sub


    Private Sub btnAdministracion_Click(sender As Object, e As EventArgs) Handles btnAdministracion.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub

    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmInfoCurso.Show()
    End Sub

    Private Sub pctSalir_Click(sender As Object, e As EventArgs) Handles pctSalir.Click
        End
    End Sub

    Private Sub btnNuevoPedido_Click(sender As Object, e As EventArgs) Handles btnNuevoPedido.Click
        Me.Hide()
        frmNewPedido.Show()
    End Sub
End Class