<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerPedidos))
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.NumpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmotorizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraentregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoentregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValortotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.cboSucursales = New System.Windows.Forms.ComboBox()
        Me.RestauranteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btmVerDetalles = New System.Windows.Forms.Button()
        Me.lblRegresar = New System.Windows.Forms.Label()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        Me.lbltTitulo = New System.Windows.Forms.Label()
        Me.PedidoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.PedidoTableAdapter()
        Me.RestauranteTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.RestauranteTableAdapter()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AutoGenerateColumns = False
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumpedidoDataGridViewTextBoxColumn, Me.IdsucursalDataGridViewTextBoxColumn, Me.IdmotorizadoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.HoraentregaDataGridViewTextBoxColumn, Me.CostoentregaDataGridViewTextBoxColumn, Me.ValortotalDataGridViewTextBoxColumn})
        Me.dgvPedidos.DataSource = Me.PedidoBindingSource
        Me.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvPedidos.Location = New System.Drawing.Point(33, 154)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowHeadersWidth = 51
        Me.dgvPedidos.RowTemplate.Height = 25
        Me.dgvPedidos.Size = New System.Drawing.Size(1362, 351)
        Me.dgvPedidos.TabIndex = 0
        '
        'NumpedidoDataGridViewTextBoxColumn
        '
        Me.NumpedidoDataGridViewTextBoxColumn.DataPropertyName = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.HeaderText = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumpedidoDataGridViewTextBoxColumn.Name = "NumpedidoDataGridViewTextBoxColumn"
        Me.NumpedidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdsucursalDataGridViewTextBoxColumn
        '
        Me.IdsucursalDataGridViewTextBoxColumn.DataPropertyName = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.HeaderText = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdsucursalDataGridViewTextBoxColumn.Name = "IdsucursalDataGridViewTextBoxColumn"
        Me.IdsucursalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdmotorizadoDataGridViewTextBoxColumn
        '
        Me.IdmotorizadoDataGridViewTextBoxColumn.DataPropertyName = "id_motorizado"
        Me.IdmotorizadoDataGridViewTextBoxColumn.HeaderText = "id_motorizado"
        Me.IdmotorizadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdmotorizadoDataGridViewTextBoxColumn.Name = "IdmotorizadoDataGridViewTextBoxColumn"
        Me.IdmotorizadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraentregaDataGridViewTextBoxColumn
        '
        Me.HoraentregaDataGridViewTextBoxColumn.DataPropertyName = "hora_entrega"
        Me.HoraentregaDataGridViewTextBoxColumn.HeaderText = "hora_entrega"
        Me.HoraentregaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraentregaDataGridViewTextBoxColumn.Name = "HoraentregaDataGridViewTextBoxColumn"
        Me.HoraentregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoentregaDataGridViewTextBoxColumn
        '
        Me.CostoentregaDataGridViewTextBoxColumn.DataPropertyName = "costo_entrega"
        Me.CostoentregaDataGridViewTextBoxColumn.HeaderText = "costo_entrega"
        Me.CostoentregaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostoentregaDataGridViewTextBoxColumn.Name = "CostoentregaDataGridViewTextBoxColumn"
        Me.CostoentregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValortotalDataGridViewTextBoxColumn
        '
        Me.ValortotalDataGridViewTextBoxColumn.DataPropertyName = "valor_total"
        Me.ValortotalDataGridViewTextBoxColumn.HeaderText = "valor_total"
        Me.ValortotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValortotalDataGridViewTextBoxColumn.Name = "ValortotalDataGridViewTextBoxColumn"
        Me.ValortotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "Pedido"
        Me.PedidoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'LasPalmerasDataSet
        '
        Me.LasPalmerasDataSet.DataSetName = "lasPalmerasDataSet"
        Me.LasPalmerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblSucursal.Location = New System.Drawing.Point(33, 109)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(121, 38)
        Me.lblSucursal.TabIndex = 1
        Me.lblSucursal.Text = "Sucursal"
        '
        'cboSucursales
        '
        Me.cboSucursales.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidoBindingSource, "id_sucursal", True))
        Me.cboSucursales.DataSource = Me.RestauranteBindingSource
        Me.cboSucursales.DisplayMember = "nombre"
        Me.cboSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursales.FormattingEnabled = True
        Me.cboSucursales.Location = New System.Drawing.Point(160, 116)
        Me.cboSucursales.Name = "cboSucursales"
        Me.cboSucursales.Size = New System.Drawing.Size(1123, 24)
        Me.cboSucursales.TabIndex = 2
        Me.cboSucursales.ValueMember = "id_sucursal"
        '
        'RestauranteBindingSource
        '
        Me.RestauranteBindingSource.DataMember = "Restaurante"
        Me.RestauranteBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSelect.FlatAppearance.BorderSize = 4
        Me.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSelect.Location = New System.Drawing.Point(1309, 100)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(86, 46)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Ver"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btmVerDetalles
        '
        Me.btmVerDetalles.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btmVerDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btmVerDetalles.FlatAppearance.BorderSize = 4
        Me.btmVerDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btmVerDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btmVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmVerDetalles.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btmVerDetalles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btmVerDetalles.Location = New System.Drawing.Point(1237, 511)
        Me.btmVerDetalles.Name = "btmVerDetalles"
        Me.btmVerDetalles.Size = New System.Drawing.Size(158, 52)
        Me.btmVerDetalles.TabIndex = 4
        Me.btmVerDetalles.Text = "Ver Detalles"
        Me.btmVerDetalles.UseVisualStyleBackColor = True
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegresar.Location = New System.Drawing.Point(35, 75)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(90, 28)
        Me.lblRegresar.TabIndex = 26
        Me.lblRegresar.Text = "Regresar"
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.back
        Me.pctRegresar.Location = New System.Drawing.Point(52, 22)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(50, 50)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 25
        Me.pctRegresar.TabStop = False
        '
        'lbltTitulo
        '
        Me.lbltTitulo.AutoSize = True
        Me.lbltTitulo.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lbltTitulo.Location = New System.Drawing.Point(611, 22)
        Me.lbltTitulo.Name = "lbltTitulo"
        Me.lbltTitulo.Size = New System.Drawing.Size(313, 51)
        Me.lbltTitulo.TabIndex = 24
        Me.lbltTitulo.Text = "Lista de pedidos"
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'RestauranteTableAdapter
        '
        Me.RestauranteTableAdapter.ClearBeforeFill = True
        '
        'frmVerPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1493, 579)
        Me.Controls.Add(Me.lblRegresar)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.lbltTitulo)
        Me.Controls.Add(Me.btmVerDetalles)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cboSucursales)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.dgvPedidos)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVerPedidos"
        Me.Text = "Ver Pedidos"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents lblSucursal As Label
    Friend WithEvents cboSucursales As ComboBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btmVerDetalles As Button
    Friend WithEvents lblRegresar As Label
    Friend WithEvents pctRegresar As PictureBox
    Friend WithEvents lbltTitulo As Label
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents PedidoTableAdapter As lasPalmerasDataSetTableAdapters.PedidoTableAdapter
    Friend WithEvents NumpedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdmotorizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraentregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoentregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValortotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestauranteBindingSource As BindingSource
    Friend WithEvents RestauranteTableAdapter As lasPalmerasDataSetTableAdapters.RestauranteTableAdapter
End Class
