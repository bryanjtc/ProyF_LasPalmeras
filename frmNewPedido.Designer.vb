<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewPedido
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewPedido))
        Me.lblClienteID = New System.Windows.Forms.Label()
        Me.cboClienteID = New System.Windows.Forms.ComboBox()
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblRestaurante = New System.Windows.Forms.Label()
        Me.cboRestaurantes = New System.Windows.Forms.ComboBox()
        Me.RestauranteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblMotorizado = New System.Windows.Forms.Label()
        Me.cboMotorizado = New System.Windows.Forms.ComboBox()
        Me.MotorizadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblHoraEntrega = New System.Windows.Forms.Label()
        Me.txtHoraEntrega = New System.Windows.Forms.TextBox()
        Me.lblCostoDeEntrega = New System.Windows.Forms.Label()
        Me.txtCostoDeEntrega = New System.Windows.Forms.TextBox()
        Me.dgvInfoPedido = New System.Windows.Forms.DataGridView()
        Me.NumpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidoProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.lblPedidoAct = New System.Windows.Forms.Label()
        Me.btnAddProducto = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblRegresar = New System.Windows.Forms.Label()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        Me.PedidoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.PedidoTableAdapter()
        Me.RestauranteTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.RestauranteTableAdapter()
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.MotorizadoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.MotorizadoTableAdapter()
        Me.ClienteTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.ClienteTableAdapter()
        Me.Pedido_ProductoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.Pedido_ProductoTableAdapter()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.NumpedidoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmotorizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraentregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoentregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValortotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.ProductoTableAdapter()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorizadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClienteID
        '
        Me.lblClienteID.AutoSize = True
        Me.lblClienteID.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblClienteID.Location = New System.Drawing.Point(28, 377)
        Me.lblClienteID.Name = "lblClienteID"
        Me.lblClienteID.Size = New System.Drawing.Size(127, 32)
        Me.lblClienteID.TabIndex = 1
        Me.lblClienteID.Text = "ID Cliente"
        '
        'cboClienteID
        '
        Me.cboClienteID.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidoBindingSource, "cedula", True))
        Me.cboClienteID.DataSource = Me.ClienteBindingSource1
        Me.cboClienteID.DisplayMember = "cedula"
        Me.cboClienteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClienteID.FormattingEnabled = True
        Me.cboClienteID.Location = New System.Drawing.Point(153, 379)
        Me.cboClienteID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboClienteID.Name = "cboClienteID"
        Me.cboClienteID.Size = New System.Drawing.Size(120, 24)
        Me.cboClienteID.TabIndex = 2
        Me.cboClienteID.ValueMember = "cedula"
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
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAgregarCliente.FlatAppearance.BorderSize = 4
        Me.btnAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(328, 363)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(177, 46)
        Me.btnAgregarCliente.TabIndex = 3
        Me.btnAgregarCliente.Text = "Agregar Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'lblRestaurante
        '
        Me.lblRestaurante.AutoSize = True
        Me.lblRestaurante.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblRestaurante.Location = New System.Drawing.Point(28, 430)
        Me.lblRestaurante.Name = "lblRestaurante"
        Me.lblRestaurante.Size = New System.Drawing.Size(151, 32)
        Me.lblRestaurante.TabIndex = 5
        Me.lblRestaurante.Text = "Restaurante"
        '
        'cboRestaurantes
        '
        Me.cboRestaurantes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidoBindingSource, "id_sucursal", True))
        Me.cboRestaurantes.DataSource = Me.RestauranteBindingSource
        Me.cboRestaurantes.DisplayMember = "nombre"
        Me.cboRestaurantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRestaurantes.FormattingEnabled = True
        Me.cboRestaurantes.Location = New System.Drawing.Point(191, 430)
        Me.cboRestaurantes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboRestaurantes.Name = "cboRestaurantes"
        Me.cboRestaurantes.Size = New System.Drawing.Size(223, 24)
        Me.cboRestaurantes.TabIndex = 6
        Me.cboRestaurantes.ValueMember = "id_sucursal"
        '
        'RestauranteBindingSource
        '
        Me.RestauranteBindingSource.DataMember = "Restaurante"
        Me.RestauranteBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'lblMotorizado
        '
        Me.lblMotorizado.AutoSize = True
        Me.lblMotorizado.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblMotorizado.Location = New System.Drawing.Point(521, 421)
        Me.lblMotorizado.Name = "lblMotorizado"
        Me.lblMotorizado.Size = New System.Drawing.Size(149, 32)
        Me.lblMotorizado.TabIndex = 7
        Me.lblMotorizado.Text = "Motorizado"
        '
        'cboMotorizado
        '
        Me.cboMotorizado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidoBindingSource, "id_motorizado", True))
        Me.cboMotorizado.DataSource = Me.MotorizadoBindingSource
        Me.cboMotorizado.DisplayMember = "nombre"
        Me.cboMotorizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotorizado.FormattingEnabled = True
        Me.cboMotorizado.Location = New System.Drawing.Point(676, 430)
        Me.cboMotorizado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboMotorizado.Name = "cboMotorizado"
        Me.cboMotorizado.Size = New System.Drawing.Size(219, 24)
        Me.cboMotorizado.TabIndex = 8
        Me.cboMotorizado.ValueMember = "id_motorizado"
        '
        'MotorizadoBindingSource
        '
        Me.MotorizadoBindingSource.DataMember = "Motorizado"
        Me.MotorizadoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'lblHoraEntrega
        '
        Me.lblHoraEntrega.AutoSize = True
        Me.lblHoraEntrega.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblHoraEntrega.Location = New System.Drawing.Point(28, 481)
        Me.lblHoraEntrega.Name = "lblHoraEntrega"
        Me.lblHoraEntrega.Size = New System.Drawing.Size(201, 32)
        Me.lblHoraEntrega.TabIndex = 9
        Me.lblHoraEntrega.Text = "Hora de entrega"
        '
        'txtHoraEntrega
        '
        Me.txtHoraEntrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "hora_entrega", True))
        Me.txtHoraEntrega.Location = New System.Drawing.Point(235, 490)
        Me.txtHoraEntrega.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHoraEntrega.Name = "txtHoraEntrega"
        Me.txtHoraEntrega.Size = New System.Drawing.Size(162, 22)
        Me.txtHoraEntrega.TabIndex = 10
        '
        'lblCostoDeEntrega
        '
        Me.lblCostoDeEntrega.AutoSize = True
        Me.lblCostoDeEntrega.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblCostoDeEntrega.Location = New System.Drawing.Point(460, 476)
        Me.lblCostoDeEntrega.Name = "lblCostoDeEntrega"
        Me.lblCostoDeEntrega.Size = New System.Drawing.Size(210, 32)
        Me.lblCostoDeEntrega.TabIndex = 11
        Me.lblCostoDeEntrega.Text = "Costo de Entrega"
        '
        'txtCostoDeEntrega
        '
        Me.txtCostoDeEntrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "costo_entrega", True))
        Me.txtCostoDeEntrega.Location = New System.Drawing.Point(676, 485)
        Me.txtCostoDeEntrega.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCostoDeEntrega.Name = "txtCostoDeEntrega"
        Me.txtCostoDeEntrega.Size = New System.Drawing.Size(219, 22)
        Me.txtCostoDeEntrega.TabIndex = 12
        '
        'dgvInfoPedido
        '
        Me.dgvInfoPedido.AllowUserToAddRows = False
        Me.dgvInfoPedido.AllowUserToDeleteRows = False
        Me.dgvInfoPedido.AutoGenerateColumns = False
        Me.dgvInfoPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInfoPedido.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvInfoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfoPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumpedidoDataGridViewTextBoxColumn, Me.IdproductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
        Me.dgvInfoPedido.DataSource = Me.PedidoProductoBindingSource
        Me.dgvInfoPedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvInfoPedido.Location = New System.Drawing.Point(34, 242)
        Me.dgvInfoPedido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvInfoPedido.Name = "dgvInfoPedido"
        Me.dgvInfoPedido.ReadOnly = True
        Me.dgvInfoPedido.RowHeadersWidth = 51
        Me.dgvInfoPedido.RowTemplate.Height = 25
        Me.dgvInfoPedido.Size = New System.Drawing.Size(863, 91)
        Me.dgvInfoPedido.TabIndex = 13
        '
        'NumpedidoDataGridViewTextBoxColumn
        '
        Me.NumpedidoDataGridViewTextBoxColumn.DataPropertyName = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.HeaderText = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumpedidoDataGridViewTextBoxColumn.Name = "NumpedidoDataGridViewTextBoxColumn"
        Me.NumpedidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PedidoProductoBindingSource
        '
        Me.PedidoProductoBindingSource.DataMember = "Pedido_Producto"
        Me.PedidoProductoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblPedido.Location = New System.Drawing.Point(-605, -134)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(88, 32)
        Me.lblPedido.TabIndex = 14
        Me.lblPedido.Text = "Pedido"
        '
        'lblPedidoAct
        '
        Me.lblPedidoAct.AutoSize = True
        Me.lblPedidoAct.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblPedidoAct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPedidoAct.Location = New System.Drawing.Point(25, 133)
        Me.lblPedidoAct.Name = "lblPedidoAct"
        Me.lblPedidoAct.Size = New System.Drawing.Size(107, 38)
        Me.lblPedidoAct.TabIndex = 15
        Me.lblPedidoAct.Text = "Pedido"
        '
        'btnAddProducto
        '
        Me.btnAddProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAddProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAddProducto.FlatAppearance.BorderSize = 4
        Me.btnAddProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAddProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAddProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProducto.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAddProducto.Location = New System.Drawing.Point(678, 129)
        Me.btnAddProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProducto.Name = "btnAddProducto"
        Me.btnAddProducto.Size = New System.Drawing.Size(218, 53)
        Me.btnAddProducto.TabIndex = 16
        Me.btnAddProducto.Text = "Agregar al pedido"
        Me.btnAddProducto.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnBorrar.FlatAppearance.BorderSize = 4
        Me.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnBorrar.Location = New System.Drawing.Point(34, 537)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(147, 51)
        Me.btnBorrar.TabIndex = 17
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnConfirmar.FlatAppearance.BorderSize = 4
        Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnConfirmar.Location = New System.Drawing.Point(750, 537)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(147, 51)
        Me.btnConfirmar.TabIndex = 18
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(554, 546)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 32)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(631, 552)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(113, 22)
        Me.txtTotal.TabIndex = 20
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(371, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(275, 51)
        Me.lblTitulo.TabIndex = 21
        Me.lblTitulo.Text = "Nuevo Pedido"
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegresar.Location = New System.Drawing.Point(19, 71)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(90, 28)
        Me.lblRegresar.TabIndex = 23
        Me.lblRegresar.Text = "Regresar"
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.back
        Me.pctRegresar.Location = New System.Drawing.Point(36, 24)
        Me.pctRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(51, 50)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 24
        Me.pctRegresar.TabStop = False
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'RestauranteTableAdapter
        '
        Me.RestauranteTableAdapter.ClearBeforeFill = True
        '
        'txtNumPedido
        '
        Me.txtNumPedido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "num_pedido", True))
        Me.txtNumPedido.Location = New System.Drawing.Point(138, 147)
        Me.txtNumPedido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(177, 22)
        Me.txtNumPedido.TabIndex = 25
        '
        'MotorizadoTableAdapter
        '
        Me.MotorizadoTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Pedido_ProductoTableAdapter
        '
        Me.Pedido_ProductoTableAdapter.ClearBeforeFill = True
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.AllowUserToDeleteRows = False
        Me.dgvPedido.AutoGenerateColumns = False
        Me.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumpedidoDataGridViewTextBoxColumn1, Me.IdsucursalDataGridViewTextBoxColumn, Me.IdmotorizadoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.HoraentregaDataGridViewTextBoxColumn, Me.CostoentregaDataGridViewTextBoxColumn, Me.ValortotalDataGridViewTextBoxColumn})
        Me.dgvPedido.DataSource = Me.PedidoBindingSource
        Me.dgvPedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvPedido.Location = New System.Drawing.Point(31, 629)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.ReadOnly = True
        Me.dgvPedido.RowHeadersWidth = 51
        Me.dgvPedido.RowTemplate.Height = 24
        Me.dgvPedido.Size = New System.Drawing.Size(864, 150)
        Me.dgvPedido.TabIndex = 26
        '
        'NumpedidoDataGridViewTextBoxColumn1
        '
        Me.NumpedidoDataGridViewTextBoxColumn1.DataPropertyName = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn1.HeaderText = "num_pedido"
        Me.NumpedidoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NumpedidoDataGridViewTextBoxColumn1.Name = "NumpedidoDataGridViewTextBoxColumn1"
        Me.NumpedidoDataGridViewTextBoxColumn1.ReadOnly = True
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
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblProducto.Location = New System.Drawing.Point(348, 133)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(137, 38)
        Me.lblProducto.TabIndex = 27
        Me.lblProducto.Text = "Producto"
        '
        'cboProducto
        '
        Me.cboProducto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidoProductoBindingSource, "id_producto", True))
        Me.cboProducto.DataSource = Me.ProductoBindingSource
        Me.cboProducto.DisplayMember = "nombre"
        Me.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(491, 145)
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(168, 24)
        Me.cboProducto.TabIndex = 28
        Me.cboProducto.ValueMember = "id_producto"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(351, 183)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(134, 38)
        Me.lblCantidad.TabIndex = 29
        Me.lblCantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoProductoBindingSource, "cantidad", True))
        Me.txtCantidad.Location = New System.Drawing.Point(491, 197)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(168, 22)
        Me.txtCantidad.TabIndex = 30
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "Cliente"
        Me.ClienteBindingSource1.DataSource = Me.LasPalmerasDataSet
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 4
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(214, 537)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(147, 51)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmNewPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 791)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.txtNumPedido)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.lblRegresar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAddProducto)
        Me.Controls.Add(Me.lblPedidoAct)
        Me.Controls.Add(Me.lblPedido)
        Me.Controls.Add(Me.dgvInfoPedido)
        Me.Controls.Add(Me.txtCostoDeEntrega)
        Me.Controls.Add(Me.lblCostoDeEntrega)
        Me.Controls.Add(Me.txtHoraEntrega)
        Me.Controls.Add(Me.lblHoraEntrega)
        Me.Controls.Add(Me.cboMotorizado)
        Me.Controls.Add(Me.lblMotorizado)
        Me.Controls.Add(Me.cboRestaurantes)
        Me.Controls.Add(Me.lblRestaurante)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.cboClienteID)
        Me.Controls.Add(Me.lblClienteID)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmNewPedido"
        Me.Text = "Nuevo Pedido"
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorizadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInfoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblClienteID As Label
    Friend WithEvents cboClienteID As ComboBox
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblRestaurante As Label
    Friend WithEvents cboRestaurantes As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents cboMotorizado As ComboBox
    Friend WithEvents lblHoraEntrega As Label
    Friend WithEvents txtHoraEntrega As TextBox
    Friend WithEvents lblCostoDeEntrega As Label
    Friend WithEvents txtCostoDeEntrega As TextBox
    Friend WithEvents txtCostoDeEn As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dgvInfoPedido As DataGridView
    Friend WithEvents lblPedido As Label
    Friend WithEvents lblMotoriz As Label
    Friend WithEvents lblMoto As Label
    Friend WithEvents lblMotorizado As Label
    Friend WithEvents lblPedidoAct As Label
    Friend WithEvents btnAddProducto As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents lblPedid As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblRegresar As Label
    Friend WithEvents pctRegresar As PictureBox
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents PedidoTableAdapter As lasPalmerasDataSetTableAdapters.PedidoTableAdapter
    Friend WithEvents RestauranteBindingSource As BindingSource
    Friend WithEvents RestauranteTableAdapter As lasPalmerasDataSetTableAdapters.RestauranteTableAdapter
    Friend WithEvents txtNumPedido As TextBox
    Friend WithEvents MotorizadoBindingSource As BindingSource
    Friend WithEvents MotorizadoTableAdapter As lasPalmerasDataSetTableAdapters.MotorizadoTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As lasPalmerasDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents PedidoProductoBindingSource As BindingSource
    Friend WithEvents Pedido_ProductoTableAdapter As lasPalmerasDataSetTableAdapters.Pedido_ProductoTableAdapter
    Friend WithEvents NumpedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvPedido As DataGridView
    Friend WithEvents NumpedidoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdmotorizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraentregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoentregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValortotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblProducto As Label
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As lasPalmerasDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents ClienteBindingSource1 As BindingSource
    Friend WithEvents btnGuardar As Button
End Class
