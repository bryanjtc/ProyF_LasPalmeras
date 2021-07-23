<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminRestaurantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminRestaurantes))
        Me.dgvRestaurantes = New System.Windows.Forms.DataGridView()
        Me.IdsucursalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestauranteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.lblRestauranteID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtRestaurantID = New System.Windows.Forms.TextBox()
        Me.txtNombreRest = New System.Windows.Forms.TextBox()
        Me.TelefonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.IdsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarRest = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnVerTelefonos = New System.Windows.Forms.Button()
        Me.btnTeleAdd = New System.Windows.Forms.Button()
        Me.TelefonoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.TelefonoTableAdapter()
        Me.RestauranteTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.RestauranteTableAdapter()
        Me.lblSeleccionado = New System.Windows.Forms.Label()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.RestauranteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblRegresar = New System.Windows.Forms.Label()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        Me.lblListado = New System.Windows.Forms.Label()
        CType(Me.dgvRestaurantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRestaurantes
        '
        Me.dgvRestaurantes.AllowUserToAddRows = False
        Me.dgvRestaurantes.AllowUserToDeleteRows = False
        Me.dgvRestaurantes.AutoGenerateColumns = False
        Me.dgvRestaurantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRestaurantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestaurantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsucursalDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvRestaurantes.DataSource = Me.RestauranteBindingSource
        Me.dgvRestaurantes.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvRestaurantes.Location = New System.Drawing.Point(43, 128)
        Me.dgvRestaurantes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRestaurantes.Name = "dgvRestaurantes"
        Me.dgvRestaurantes.ReadOnly = True
        Me.dgvRestaurantes.RowHeadersWidth = 51
        Me.dgvRestaurantes.Size = New System.Drawing.Size(1064, 188)
        Me.dgvRestaurantes.TabIndex = 0
        '
        'IdsucursalDataGridViewTextBoxColumn1
        '
        Me.IdsucursalDataGridViewTextBoxColumn1.DataPropertyName = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn1.HeaderText = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdsucursalDataGridViewTextBoxColumn1.Name = "IdsucursalDataGridViewTextBoxColumn1"
        Me.IdsucursalDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RestauranteBindingSource
        '
        Me.RestauranteBindingSource.DataMember = "Restaurante"
        Me.RestauranteBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'LasPalmerasDataSet
        '
        Me.LasPalmerasDataSet.DataSetName = "lasPalmerasDataSet"
        Me.LasPalmerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblRestauranteID
        '
        Me.lblRestauranteID.AutoSize = True
        Me.lblRestauranteID.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblRestauranteID.Location = New System.Drawing.Point(41, 455)
        Me.lblRestauranteID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRestauranteID.Name = "lblRestauranteID"
        Me.lblRestauranteID.Size = New System.Drawing.Size(184, 32)
        Me.lblRestauranteID.TabIndex = 1
        Me.lblRestauranteID.Text = "ID Restaurante"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.Location = New System.Drawing.Point(41, 383)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(294, 32)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre del Restaurante"
        '
        'txtRestaurantID
        '
        Me.txtRestaurantID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "id_sucursal", True))
        Me.txtRestaurantID.Location = New System.Drawing.Point(233, 464)
        Me.txtRestaurantID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRestaurantID.Name = "txtRestaurantID"
        Me.txtRestaurantID.Size = New System.Drawing.Size(132, 22)
        Me.txtRestaurantID.TabIndex = 5
        '
        'txtNombreRest
        '
        Me.txtNombreRest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "nombre", True))
        Me.txtNombreRest.Location = New System.Drawing.Point(343, 389)
        Me.txtNombreRest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreRest.Name = "txtNombreRest"
        Me.txtNombreRest.Size = New System.Drawing.Size(550, 22)
        Me.txtNombreRest.TabIndex = 6
        '
        'TelefonoBindingSource
        '
        Me.TelefonoBindingSource.DataMember = "Telefono"
        Me.TelefonoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.AllowUserToAddRows = False
        Me.dgvTelefonos.AllowUserToDeleteRows = False
        Me.dgvTelefonos.AutoGenerateColumns = False
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsucursalDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.dgvTelefonos.DataSource = Me.TelefonoBindingSource
        Me.dgvTelefonos.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvTelefonos.Location = New System.Drawing.Point(380, 445)
        Me.dgvTelefonos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.ReadOnly = True
        Me.dgvTelefonos.RowHeadersWidth = 51
        Me.dgvTelefonos.Size = New System.Drawing.Size(727, 195)
        Me.dgvTelefonos.TabIndex = 9
        '
        'IdsucursalDataGridViewTextBoxColumn
        '
        Me.IdsucursalDataGridViewTextBoxColumn.DataPropertyName = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.HeaderText = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdsucursalDataGridViewTextBoxColumn.Name = "IdsucursalDataGridViewTextBoxColumn"
        Me.IdsucursalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnAgregarRest
        '
        Me.btnAgregarRest.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregarRest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAgregarRest.FlatAppearance.BorderSize = 4
        Me.btnAgregarRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAgregarRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAgregarRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRest.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarRest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAgregarRest.Location = New System.Drawing.Point(43, 322)
        Me.btnAgregarRest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarRest.Name = "btnAgregarRest"
        Me.btnAgregarRest.Size = New System.Drawing.Size(231, 46)
        Me.btnAgregarRest.TabIndex = 10
        Me.btnAgregarRest.Text = "Agregar Restaurante"
        Me.btnAgregarRest.UseVisualStyleBackColor = True
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
        Me.btnBorrar.Location = New System.Drawing.Point(282, 322)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(214, 46)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar Restaurante"
        Me.btnBorrar.UseVisualStyleBackColor = True
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
        Me.btnGuardar.Location = New System.Drawing.Point(903, 370)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(204, 47)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar Restaurante"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnVerTelefonos
        '
        Me.btnVerTelefonos.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerTelefonos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVerTelefonos.FlatAppearance.BorderSize = 4
        Me.btnVerTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerTelefonos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnVerTelefonos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVerTelefonos.Location = New System.Drawing.Point(45, 562)
        Me.btnVerTelefonos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerTelefonos.Name = "btnVerTelefonos"
        Me.btnVerTelefonos.Size = New System.Drawing.Size(137, 78)
        Me.btnVerTelefonos.TabIndex = 14
        Me.btnVerTelefonos.Text = "Ver Telefonos"
        Me.btnVerTelefonos.UseVisualStyleBackColor = True
        '
        'btnTeleAdd
        '
        Me.btnTeleAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnTeleAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnTeleAdd.FlatAppearance.BorderSize = 4
        Me.btnTeleAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnTeleAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnTeleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeleAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTeleAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnTeleAdd.Location = New System.Drawing.Point(190, 562)
        Me.btnTeleAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeleAdd.Name = "btnTeleAdd"
        Me.btnTeleAdd.Size = New System.Drawing.Size(147, 78)
        Me.btnTeleAdd.TabIndex = 16
        Me.btnTeleAdd.Text = "Agregar Telefono"
        Me.btnTeleAdd.UseVisualStyleBackColor = True
        '
        'TelefonoTableAdapter
        '
        Me.TelefonoTableAdapter.ClearBeforeFill = True
        '
        'RestauranteTableAdapter
        '
        Me.RestauranteTableAdapter.ClearBeforeFill = True
        '
        'lblSeleccionado
        '
        Me.lblSeleccionado.AutoSize = True
        Me.lblSeleccionado.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblSeleccionado.Location = New System.Drawing.Point(41, 513)
        Me.lblSeleccionado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeleccionado.Name = "lblSeleccionado"
        Me.lblSeleccionado.Size = New System.Drawing.Size(198, 32)
        Me.lblSeleccionado.TabIndex = 18
        Me.lblSeleccionado.Text = "ID Seleccionado"
        '
        'cboID
        '
        Me.cboID.DataSource = Me.RestauranteBindingSource1
        Me.cboID.DisplayMember = "id_sucursal"
        Me.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(247, 521)
        Me.cboID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(118, 24)
        Me.cboID.TabIndex = 21
        '
        'RestauranteBindingSource1
        '
        Me.RestauranteBindingSource1.DataMember = "Restaurante"
        Me.RestauranteBindingSource1.DataSource = Me.LasPalmerasDataSet
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegresar.Location = New System.Drawing.Point(34, 79)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(90, 28)
        Me.lblRegresar.TabIndex = 23
        Me.lblRegresar.Text = "Regresar"
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.back
        Me.pctRegresar.Location = New System.Drawing.Point(51, 26)
        Me.pctRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(51, 50)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 22
        Me.pctRegresar.TabStop = False
        '
        'lblListado
        '
        Me.lblListado.AutoSize = True
        Me.lblListado.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblListado.Location = New System.Drawing.Point(240, 26)
        Me.lblListado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(701, 81)
        Me.lblListado.TabIndex = 24
        Me.lblListado.Text = "Listado de Restaurantes"
        '
        'frmAdminRestaurantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1120, 653)
        Me.Controls.Add(Me.lblListado)
        Me.Controls.Add(Me.lblRegresar)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.cboID)
        Me.Controls.Add(Me.lblSeleccionado)
        Me.Controls.Add(Me.btnTeleAdd)
        Me.Controls.Add(Me.btnVerTelefonos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregarRest)
        Me.Controls.Add(Me.dgvTelefonos)
        Me.Controls.Add(Me.txtNombreRest)
        Me.Controls.Add(Me.txtRestaurantID)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblRestauranteID)
        Me.Controls.Add(Me.dgvRestaurantes)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAdminRestaurantes"
        Me.Text = "Admin de restaurantes"
        CType(Me.dgvRestaurantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRestaurantes As DataGridView
    Friend WithEvents lblRestauranteID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtRestaurantID As TextBox
    Friend WithEvents txtNombreRest As TextBox
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents btnAgregarRest As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnVerTelefonos As Button
    Friend WithEvents btnTeleAdd As Button
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents TelefonoBindingSource As BindingSource
    Friend WithEvents TelefonoTableAdapter As lasPalmerasDataSetTableAdapters.TelefonoTableAdapter
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestauranteBindingSource As BindingSource
    Friend WithEvents RestauranteTableAdapter As lasPalmerasDataSetTableAdapters.RestauranteTableAdapter
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblSeleccionado As Label
    Friend WithEvents cboID As ComboBox
    Friend WithEvents RestauranteBindingSource1 As BindingSource
    Friend WithEvents lblRegresar As Label
    Friend WithEvents pctRegresar As PictureBox
    Friend WithEvents lblListado As Label
End Class
