Public Class frmVerClientes

    'Boton ver clientes activos
    Private Sub frmVerClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.LasPalmerasDataSet.Cliente)

    End Sub
    'Boton de regresar al menu anterior
    Private Sub pctRegresar_Click(sender As Object, e As EventArgs) Handles pctRegresar.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub
End Class