Public Class frmAdminMotorizado
    Private Sub frmAdminMotorizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Motorizado' table. You can move, or remove it, as needed.
        Me.MotorizadoTableAdapter.Fill(Me.LasPalmerasDataSet.Motorizado)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MotorizadoBindingSource.AddNew()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MotorizadoBindingSource.EndEdit()
        MotorizadoTableAdapter.Update(LasPalmerasDataSet)
        MessageBox.Show("Datos Actualizados")
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        MotorizadoBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmAdmin.Show()
    End Sub

    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub
End Class