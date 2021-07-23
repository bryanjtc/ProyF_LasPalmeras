Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmNewPedido
    ReadOnly connect As New SqlClient.SqlConnection("Data Source=herramientas.database.windows.net;Initial Catalog=lasPalmeras;Persist Security Info=True;User ID=bryan;Password=kpgA@F!obNqN6Grog2sP")

    Private Sub ExecuteQuery(Query As String)
        Dim command As New SqlCommand(Query, connect)
        connect.Open()
        command.ExecuteNonQuery()
        connect.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub dgvPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInfoPedido.CellContentClick

    End Sub

    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub frmNewPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.LasPalmerasDataSet.Producto)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.LasPalmerasDataSet.Cliente)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Motorizado' table. You can move, or remove it, as needed.
        Me.MotorizadoTableAdapter.Fill(Me.LasPalmerasDataSet.Motorizado)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Restaurante' table. You can move, or remove it, as needed.
        Me.RestauranteTableAdapter.Fill(Me.LasPalmerasDataSet.Restaurante)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Pedido' table. You can move, or remove it, as needed.
        Me.PedidoTableAdapter.Fill(Me.LasPalmerasDataSet.Pedido)

    End Sub



    Private Sub btnAddProducto_Click(sender As Object, e As EventArgs) Handles btnAddProducto.Click
        Dim numPedido As String = txtNumPedido.Text
        Dim idProducto As String = cboProducto.SelectedValue
        Dim cantidad As String = txtCantidad.Text
        Try
            Dim query As String = "insert into Pedido_Producto values('" & numPedido & "','" & idProducto & "','" & cantidad & "')"
            ExecuteQuery(query)
            Pedido_ProductoTableAdapter.Update(LasPalmerasDataSet.Pedido_Producto)
            Pedido_ProductoTableAdapter.Fill(LasPalmerasDataSet.Pedido_Producto)
            PedidoProductoBindingSource.Filter = "num_pedido= '" & numPedido & "'"
        Catch ex As Exception
            MsgBox("No puede agregar el mismo producto mas de una vez")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim numPedido As String = txtNumPedido.Text
        Dim cedula As String = cboClienteID.SelectedValue
        Dim sucursal As String = cboRestaurantes.SelectedValue
        Dim horaEntrega As String = txtHoraEntrega.Text
        Dim motorizado As String = cboMotorizado.SelectedValue
        Dim costoEntrega As String = txtCostoDeEntrega.Text
        Dim nameProduct As String
        Dim cantidadProduct As Integer
        Dim subTotal As Double = 0
        connect.Open()
        Using Com As New SqlCommand("Select * From Pedido_Producto where num_pedido= '" & numPedido & "'", connect)
            Using RDR = Com.ExecuteReader()
                If RDR.HasRows Then
                    Do While RDR.Read
                        nameProduct = RDR.Item("id_producto").ToString()
                        cantidadProduct = Convert.ToInt32(RDR.Item("cantidad").ToString())
                        Dim connectTemp As New SqlClient.SqlConnection("Data Source=herramientas.database.windows.net;Initial Catalog=lasPalmeras;Persist Security Info=True;User ID=bryan;Password=kpgA@F!obNqN6Grog2sP")
                        connectTemp.Open()
                        Using ComTemp As New SqlCommand("Select * From Producto where id_producto= '" & nameProduct & "'", connectTemp)
                            Using RDRTemp = ComTemp.ExecuteReader()
                                If RDRTemp.HasRows Then
                                    Do While RDRTemp.Read
                                        subTotal += Convert.ToDouble(RDRTemp.Item("precio").ToString()) * cantidadProduct
                                    Loop
                                End If
                            End Using
                        End Using
                        connectTemp.Close()
                    Loop
                End If
            End Using
        End Using
        connect.Close()
        txtTotal.Text = (subTotal + Convert.ToDouble(costoEntrega)).ToString()
    End Sub

End Class