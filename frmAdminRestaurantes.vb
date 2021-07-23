Public Class frmAdminRestaurantes
    'Carga de base de datos, y enlazarlos a las tablas
    Private Sub frmAdminRestaurantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Pedido' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Restaurante' table. You can move, or remove it, as needed.
        Me.RestauranteTableAdapter.Fill(Me.LasPalmerasDataSet.Restaurante)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Telefono' table. You can move, or remove it, as needed.
        Me.TelefonoTableAdapter.Fill(Me.LasPalmerasDataSet.Telefono)


    End Sub
    'boton agregar un restaurante
    Private Sub btnAgregarRest_Click(sender As Object, e As EventArgs) Handles btnAgregarRest.Click
        RestauranteBindingSource.AddNew()
    End Sub
    'Boton borrar un restaurante
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        RestauranteBindingSource.RemoveCurrent()
    End Sub
    'Boton guardar informacion
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        RestauranteBindingSource.EndEdit()
        RestauranteTableAdapter.Update(LasPalmerasDataSet)

    End Sub
    'boton Agragar un telefono
    Private Sub btnTeleAdd_Click(sender As Object, e As EventArgs) Handles btnTeleAdd.Click
        Dim selected As String = cboID.Text
        Dim telefone As String = InputBox("Telefono", "Mete un telefono")
        Dim newrow As DataRow = LasPalmerasDataSet.Tables("Telefono").NewRow()
        newrow(0) = selected
        newrow(1) = telefone
        LasPalmerasDataSet.Telefono.Rows.Add(newrow)
    End Sub
    'boton ver telefonos relacionados al restaurante
    Private Sub btnVerTelefonos_Click(sender As Object, e As EventArgs) Handles btnVerTelefonos.Click
        Dim s As String = cboID.Text
        TelefonoBindingSource.Filter() = "id_sucursal= '" & s & "'"
    End Sub
    'Boton regresar al menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub
End Class