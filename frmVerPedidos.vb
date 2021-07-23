Public Class frmVerPedidos
    Public numPedido As String
    'Carga inicial de las conexiones de la data a las tablas
    Private Sub frmVerPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Restaurante' table. You can move, or remove it, as needed.
        Me.RestauranteTableAdapter.Fill(Me.LasPalmerasDataSet.Restaurante)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Pedido' table. You can move, or remove it, as needed.
        Me.PedidoTableAdapter.Fill(Me.LasPalmerasDataSet.Pedido)

    End Sub
    'Boton de retorno al menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
    'Boton para selecion de pedido para ver sus detalles
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim sucursal As String = cboSucursales.SelectedValue
        PedidoBindingSource.Filter = "id_sucursal= '" & sucursal & "'"
    End Sub

    'Boton para abrir el formulario de detalles de dicho producto
    Private Sub btmVerDetalles_Click(sender As Object, e As EventArgs) Handles btmVerDetalles.Click
        numPedido = txtNumPedido.Text
        frmVerDetalles.Show()
    End Sub
End Class