﻿Public Class frmVerClientes
    Private Sub frmVerClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LasPalmerasDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.LasPalmerasDataSet.Cliente)

    End Sub
End Class