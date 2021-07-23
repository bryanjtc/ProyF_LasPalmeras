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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerDetalles))
        Me.lblPedidoID = New System.Windows.Forms.Label()
        Me.txtPedidoID = New System.Windows.Forms.TextBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.NumpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidoProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.Pedido_ProductoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.Pedido_ProductoTableAdapter()
        Me.lblListado = New System.Windows.Forms.Label()
        Me.lblRegresar = New System.Windows.Forms.Label()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPedidoID
        '
        Me.lblPedidoID.AutoSize = True
        Me.lblPedidoID.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPedidoID.Location = New System.Drawing.Point(13, 111)
        Me.lblPedidoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPedidoID.Name = "lblPedidoID"
        Me.lblPedidoID.Size = New System.Drawing.Size(237, 32)
        Me.lblPedidoID.TabIndex = 0
        Me.lblPedidoID.Text = "Numero del Pedido"
        '
        'txtPedidoID
        '
        Me.txtPedidoID.Location = New System.Drawing.Point(258, 117)
        Me.txtPedidoID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPedidoID.Name = "txtPedidoID"
        Me.txtPedidoID.ReadOnly = True
        Me.txtPedidoID.Size = New System.Drawing.Size(132, 22)
        Me.txtPedidoID.TabIndex = 1
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AutoGenerateColumns = False
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumpedidoDataGridViewTextBoxColumn, Me.IdproductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
        Me.dgvDetalles.DataSource = Me.PedidoProductoBindingSource
        Me.dgvDetalles.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvDetalles.Location = New System.Drawing.Point(13, 147)
        Me.dgvDetalles.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.RowHeadersWidth = 51
        Me.dgvDetalles.Size = New System.Drawing.Size(452, 418)
        Me.dgvDetalles.TabIndex = 2
        '
        'NumpedidoDataGridViewTextBoxColumn
        '
        Me.NumpedidoDataGridViewTextBoxColumn.DataPropertyName = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.HeaderText = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumpedidoDataGridViewTextBoxColumn.Name = "NumpedidoDataGridViewTextBoxColumn"
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PedidoProductoBindingSource
        '
        Me.PedidoProductoBindingSource.DataMember = "Pedido_Producto"
        Me.PedidoProductoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'LasPalmerasDataSet
        '
        Me.LasPalmerasDataSet.DataSetName = "lasPalmerasDataSet"
        Me.LasPalmerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pedido_ProductoTableAdapter
        '
        Me.Pedido_ProductoTableAdapter.ClearBeforeFill = True
        '
        'lblListado
        '
        Me.lblListado.AutoSize = True
        Me.lblListado.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblListado.Location = New System.Drawing.Point(145, 9)
        Me.lblListado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(230, 81)
        Me.lblListado.TabIndex = 4
        Me.lblListado.Text = "Pedido"
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegresar.Location = New System.Drawing.Point(24, 82)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(90, 28)
        Me.lblRegresar.TabIndex = 17
        Me.lblRegresar.Text = "Regresar"
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.back
        Me.pctRegresar.Location = New System.Drawing.Point(41, 29)
        Me.pctRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(51, 50)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 16
        Me.pctRegresar.TabStop = False
        '
        'frmVerDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 650)
        Me.Controls.Add(Me.lblRegresar)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.lblListado)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Controls.Add(Me.txtPedidoID)
        Me.Controls.Add(Me.lblPedidoID)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVerDetalles"
        Me.Text = "Detalles"
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPedidoID As Label
    Friend WithEvents txtPedidoID As TextBox
    Friend WithEvents dgvDetalles As DataGridView
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents PedidoProductoBindingSource As BindingSource
    Friend WithEvents Pedido_ProductoTableAdapter As lasPalmerasDataSetTableAdapters.Pedido_ProductoTableAdapter
    Friend WithEvents NumpedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblListado As Label
    Friend WithEvents lblRegresar As Label
    Friend WithEvents pctRegresar As PictureBox
End Class
