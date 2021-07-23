﻿Public Class frmAddCliente
    Private Sub frmAddCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.LasPalmerasDataSet.Cliente)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim newrow As DataRow = LasPalmerasDataSet.Tables("Cliente").NewRow()
        newrow(0) = txtCedula.Text
        newrow(1) = txtNombre.Text
        newrow(2) = txtApellido.Text
        newrow(3) = txtTelefono.Text
        newrow(4) = txtDirec.Text
        LasPalmerasDataSet.Cliente.Rows.Add(newrow)
        ClienteBindingSource.EndEdit()
        ClienteTableAdapter.Update(LasPalmerasDataSet)
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtDirec.Text = ""
    End Sub

    Public Sub actualizarTablas()
        frmEditPedido.ClienteBindingSource.EndEdit()
        frmEditPedido.PedidoBindingSource.EndEdit()
        frmEditPedido.RestauranteBindingSource.EndEdit()
        frmEditPedido.MotorizadoBindingSource.EndEdit()
        frmEditPedido.PedidoProductoBindingSource.EndEdit()
        frmEditPedido.PedidoTableAdapter.Update(LasPalmerasDataSet)
        frmEditPedido.RestauranteTableAdapter.Update(LasPalmerasDataSet)
        frmEditPedido.MotorizadoTableAdapter.Update(LasPalmerasDataSet)
        frmEditPedido.Pedido_ProductoTableAdapter.Update(LasPalmerasDataSet)
        frmEditPedido.ClienteTableAdapter.Update(LasPalmerasDataSet)
        frmEditPedido.ClienteBindingSource1.EndEdit()
        frmVerClientes.ClienteBindingSource.EndEdit()
        frmVerClientes.ClienteTableAdapter.Update(LasPalmerasDataSet)
        frmAdminMotorizado.MotorizadoBindingSource.EndEdit()
        frmAdminMotorizado.MotorizadoTableAdapter.Update(LasPalmerasDataSet)
        frmAdminProducto.ProductoBindingSource.EndEdit()
        frmAdminProducto.ProductoTableAdapter.Update(LasPalmerasDataSet)
        frmAdminRestaurantes.RestauranteBindingSource.EndEdit()
        frmAdminRestaurantes.RestauranteTableAdapter.Update(LasPalmerasDataSet)
        frmAdminRestaurantes.TelefonoBindingSource.EndEdit()
        frmAdminRestaurantes.TelefonoTableAdapter.Update(LasPalmerasDataSet)


    End Sub

    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        actualizarTablas()
        Me.Hide()
        frmEditPedido.Show()
    End Sub
End Class