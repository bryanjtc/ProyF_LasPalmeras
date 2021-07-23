Public Class frmVerDetalles
    Private Sub frmVerDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Pedido_Producto' table. You can move, or remove it, as needed.
        Me.Pedido_ProductoTableAdapter.Fill(Me.LasPalmerasDataSet.Pedido_Producto)
        txtPedidoID.Text = frmVerPedidos.numPedido
        PedidoProductoBindingSource.Filter() = "num_pedido= '" & txtPedidoID.Text & "'"

    End Sub

    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmVerPedidos.Show()
    End Sub
End Class