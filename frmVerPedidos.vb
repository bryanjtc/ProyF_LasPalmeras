Public Class frmVerPedidos

    Private Sub frmVerPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Restaurante' table. You can move, or remove it, as needed.
        Me.RestauranteTableAdapter.Fill(Me.LasPalmerasDataSet.Restaurante)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Pedido' table. You can move, or remove it, as needed.
        Me.PedidoTableAdapter.Fill(Me.LasPalmerasDataSet.Pedido)

    End Sub

    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim sucursal As String = cboSucursales.SelectedValue
        PedidoBindingSource.Filter = "id_sucursal= '" & sucursal & "'"
    End Sub
End Class