Public Class frmAdminMotorizado
    'Enlaze de la base de datos a la tabla
    Private Sub frmAdminMotorizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Motorizado' table. You can move, or remove it, as needed.
        Me.MotorizadoTableAdapter.Fill(Me.LasPalmerasDataSet.Motorizado)

    End Sub
    'Boton para agregar un nuevo motorizado al sistema
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MotorizadoBindingSource.AddNew()
    End Sub
    'Boton para guardar los datos actualizado en la base de datos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MotorizadoBindingSource.EndEdit()
        MotorizadoTableAdapter.Update(LasPalmerasDataSet)
        MessageBox.Show("Datos Actualizados")
    End Sub
    'Boton para eliminar un motorizado en la lista 
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        MotorizadoBindingSource.RemoveCurrent()
    End Sub

    'Boton para regresar al menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub
End Class