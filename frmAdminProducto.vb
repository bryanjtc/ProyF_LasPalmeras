Public Class frmAdminProducto
    'Conexion de base da dato a la tabla especifica
    Private Sub frmAdminProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.LasPalmerasDataSet.Producto)

    End Sub
    'Boton para agregar un nuevo producto
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        ProductoBindingSource.AddNew()
    End Sub
    'Boton para guardar los datos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ProductoBindingSource.EndEdit()
        ProductoTableAdapter.Update(LasPalmerasDataSet)
        MessageBox.Show("Datos Guardados")
    End Sub
    'Boton para borrar un producto de la lista
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ProductoBindingSource.RemoveCurrent()
    End Sub

    'Boton para regresar al menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub
End Class