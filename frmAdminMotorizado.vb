Public Class frmAdminMotorizado
    Private Sub frmAdminMotorizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Motorizado' table. You can move, or remove it, as needed.
        Me.MotorizadoTableAdapter.Fill(Me.LasPalmerasDataSet.Motorizado)

    End Sub
End Class