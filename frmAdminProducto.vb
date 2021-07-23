Public Class frmAdminProducto
    Private Sub frmAdminProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.LasPalmerasDataSet.Producto)

    End Sub
End Class