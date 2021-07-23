<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerDetalles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPedidoID = New System.Windows.Forms.Label()
        Me.txtPedidoID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPedidoID
        '
        Me.lblPedidoID.AutoSize = True
        Me.lblPedidoID.Location = New System.Drawing.Point(36, 39)
        Me.lblPedidoID.Name = "lblPedidoID"
        Me.lblPedidoID.Size = New System.Drawing.Size(97, 13)
        Me.lblPedidoID.TabIndex = 0
        Me.lblPedidoID.Text = "Numero del Pedido"
        '
        'txtPedidoID
        '
        Me.txtPedidoID.Location = New System.Drawing.Point(139, 36)
        Me.txtPedidoID.Name = "txtPedidoID"
        Me.txtPedidoID.Size = New System.Drawing.Size(100, 20)
        Me.txtPedidoID.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(265, 397)
        Me.DataGridView1.TabIndex = 2
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(139, 465)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(50, 468)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total del pedido"
        '
        'frmVerDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 528)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPedidoID)
        Me.Controls.Add(Me.lblPedidoID)
        Me.Name = "frmVerDetalles"
        Me.Text = "frmVerDetalles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPedidoID As Label
    Friend WithEvents txtPedidoID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
End Class
