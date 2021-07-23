Public Class frmAdminRestaurantes
    Private Sub frmAdminRestaurantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Pedido' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Restaurante' table. You can move, or remove it, as needed.
        Me.RestauranteTableAdapter.Fill(Me.LasPalmerasDataSet.Restaurante)
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Telefono' table. You can move, or remove it, as needed.
        Me.TelefonoTableAdapter.Fill(Me.LasPalmerasDataSet.Telefono)


    End Sub

    Private Sub dgvRestaurantes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRestaurantes.CellContentClick

    End Sub

    Private Sub btnAgregarRest_Click(sender As Object, e As EventArgs) Handles btnAgregarRest.Click
        RestauranteBindingSource.AddNew()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        RestauranteBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        RestauranteBindingSource.EndEdit()
        RestauranteTableAdapter.Update(LasPalmerasDataSet)

    End Sub

    Private Sub btnTeleAdd_Click(sender As Object, e As EventArgs) Handles btnTeleAdd.Click
        Dim selected As String = cboID.Text
        Dim telefone As String = InputBox("Telefono", "Mete un telefono")
        Dim newrow As DataRow = LasPalmerasDataSet.Tables("Telefono").NewRow()
        newrow(0) = selected
        newrow(1) = telefone
        LasPalmerasDataSet.Telefono.Rows.Add(newrow)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub

    Private Sub btnVerTelefonos_Click(sender As Object, e As EventArgs) Handles btnVerTelefonos.Click
        Dim s As String = cboID.Text
        TelefonoBindingSource.Filter() = "id_sucursal= '" & s & "'"
    End Sub


End Class