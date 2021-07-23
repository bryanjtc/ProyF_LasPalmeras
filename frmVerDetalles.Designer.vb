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
        Me.components = New System.ComponentModel.Container()
        Me.lblPedidoID = New System.Windows.Forms.Label()
        Me.txtPedidoID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.PedidoProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pedido_ProductoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.Pedido_ProductoTableAdapter()
        Me.NumpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumpedidoDataGridViewTextBoxColumn, Me.IdproductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PedidoProductoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(339, 397)
        Me.DataGridView1.TabIndex = 2
        '
        'LasPalmerasDataSet
        '
        Me.LasPalmerasDataSet.DataSetName = "lasPalmerasDataSet"
        Me.LasPalmerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidoProductoBindingSource
        '
        Me.PedidoProductoBindingSource.DataMember = "Pedido_Producto"
        Me.PedidoProductoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'Pedido_ProductoTableAdapter
        '
        Me.Pedido_ProductoTableAdapter.ClearBeforeFill = True
        '
        'NumpedidoDataGridViewTextBoxColumn
        '
        Me.NumpedidoDataGridViewTextBoxColumn.DataPropertyName = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.HeaderText = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.Name = "NumpedidoDataGridViewTextBoxColumn"
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'frmVerDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 528)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPedidoID)
        Me.Controls.Add(Me.lblPedidoID)
        Me.Name = "frmVerDetalles"
        Me.Text = "frmVerDetalles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPedidoID As Label
    Friend WithEvents txtPedidoID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents PedidoProductoBindingSource As BindingSource
    Friend WithEvents Pedido_ProductoTableAdapter As lasPalmerasDataSetTableAdapters.Pedido_ProductoTableAdapter
    Friend WithEvents NumpedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
