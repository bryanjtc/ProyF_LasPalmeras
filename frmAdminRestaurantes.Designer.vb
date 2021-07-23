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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVerTelefonos = New System.Windows.Forms.Button()
        Me.btnTeleAdd = New System.Windows.Forms.Button()
        Me.TelefonoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.TelefonoTableAdapter()
        Me.RestauranteTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.RestauranteTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.RestauranteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvRestaurantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRestaurantes
        '
        Me.dgvRestaurantes.AutoGenerateColumns = False
        Me.dgvRestaurantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestaurantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsucursalDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvRestaurantes.DataSource = Me.RestauranteBindingSource
        Me.dgvRestaurantes.Location = New System.Drawing.Point(30, 12)
        Me.dgvRestaurantes.Name = "dgvRestaurantes"
        Me.dgvRestaurantes.Size = New System.Drawing.Size(798, 121)
        Me.dgvRestaurantes.TabIndex = 0
        '
        'IdsucursalDataGridViewTextBoxColumn1
        '
        Me.IdsucursalDataGridViewTextBoxColumn1.DataPropertyName = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn1.HeaderText = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn1.Name = "IdsucursalDataGridViewTextBoxColumn1"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
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
        Me.lblRestauranteID.Location = New System.Drawing.Point(36, 172)
        Me.lblRestauranteID.Name = "lblRestauranteID"
        Me.lblRestauranteID.Size = New System.Drawing.Size(79, 13)
        Me.lblRestauranteID.TabIndex = 1
        Me.lblRestauranteID.Text = "ID Restaurante"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(227, 172)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(122, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre del Restaurante"
        '
        'txtRestaurantID
        '
        Me.txtRestaurantID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "id_sucursal", True))
        Me.txtRestaurantID.Location = New System.Drawing.Point(121, 169)
        Me.txtRestaurantID.Name = "txtRestaurantID"
        Me.txtRestaurantID.Size = New System.Drawing.Size(100, 20)
        Me.txtRestaurantID.TabIndex = 5
        '
        'txtNombreRest
        '
        Me.txtNombreRest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "nombre", True))
        Me.txtNombreRest.Location = New System.Drawing.Point(355, 169)
        Me.txtNombreRest.Name = "txtNombreRest"
        Me.txtNombreRest.Size = New System.Drawing.Size(314, 20)
        Me.txtNombreRest.TabIndex = 6
        '
        'TelefonoBindingSource
        '
        Me.TelefonoBindingSource.DataMember = "Telefono"
        Me.TelefonoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.AutoGenerateColumns = False
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsucursalDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.dgvTelefonos.DataSource = Me.TelefonoBindingSource
        Me.dgvTelefonos.Location = New System.Drawing.Point(290, 216)
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.Size = New System.Drawing.Size(252, 210)
        Me.dgvTelefonos.TabIndex = 9
        '
        'IdsucursalDataGridViewTextBoxColumn
        '
        Me.IdsucursalDataGridViewTextBoxColumn.DataPropertyName = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.HeaderText = "id_sucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.Name = "IdsucursalDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'btnAgregarRest
        '
        Me.btnAgregarRest.Location = New System.Drawing.Point(30, 139)
        Me.btnAgregarRest.Name = "btnAgregarRest"
        Me.btnAgregarRest.Size = New System.Drawing.Size(153, 23)
        Me.btnAgregarRest.TabIndex = 10
        Me.btnAgregarRest.Text = "Agregar Restaurante"
        Me.btnAgregarRest.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(196, 139)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(153, 23)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar Restaurante"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(675, 169)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(153, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar Restaurante"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(66, 370)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(153, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVerTelefonos
        '
        Me.btnVerTelefonos.Location = New System.Drawing.Point(30, 255)
        Me.btnVerTelefonos.Name = "btnVerTelefonos"
        Me.btnVerTelefonos.Size = New System.Drawing.Size(103, 23)
        Me.btnVerTelefonos.TabIndex = 14
        Me.btnVerTelefonos.Text = "Ver Telefonos"
        Me.btnVerTelefonos.UseVisualStyleBackColor = True
        '
        'btnTeleAdd
        '
        Me.btnTeleAdd.Location = New System.Drawing.Point(139, 255)
        Me.btnTeleAdd.Name = "btnTeleAdd"
        Me.btnTeleAdd.Size = New System.Drawing.Size(110, 23)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ID Seleccionado"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboID
        '
        Me.cboID.DataSource = Me.RestauranteBindingSource1
        Me.cboID.DisplayMember = "id_sucursal"
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(128, 216)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(121, 21)
        Me.cboID.TabIndex = 21
        '
        'RestauranteBindingSource1
        '
        Me.RestauranteBindingSource1.DataMember = "Restaurante"
        Me.RestauranteBindingSource1.DataSource = Me.LasPalmerasDataSet
        '
        'frmAdminRestaurantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 450)
        Me.Controls.Add(Me.cboID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTeleAdd)
        Me.Controls.Add(Me.btnVerTelefonos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregarRest)
        Me.Controls.Add(Me.dgvTelefonos)
        Me.Controls.Add(Me.txtNombreRest)
        Me.Controls.Add(Me.txtRestaurantID)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblRestauranteID)
        Me.Controls.Add(Me.dgvRestaurantes)
        Me.Name = "frmAdminRestaurantes"
        Me.Text = "frmAdminRestaurantes"
        CType(Me.dgvRestaurantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSalir As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cboID As ComboBox
    Friend WithEvents RestauranteBindingSource1 As BindingSource
End Class
