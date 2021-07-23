<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMotorizado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMotorizado))
        Me.dgvMotorizados = New System.Windows.Forms.DataGridView()
        Me.IdmotorizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorizadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.lblMotoID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblListado = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.MotorizadoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.MotorizadoTableAdapter()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblRegresar = New System.Windows.Forms.Label()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        CType(Me.dgvMotorizados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorizadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMotorizados
        '
        Me.dgvMotorizados.AllowUserToAddRows = False
        Me.dgvMotorizados.AllowUserToDeleteRows = False
        Me.dgvMotorizados.AutoGenerateColumns = False
        Me.dgvMotorizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMotorizados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvMotorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMotorizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmotorizadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn})
        Me.dgvMotorizados.DataSource = Me.MotorizadoBindingSource
        Me.dgvMotorizados.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvMotorizados.Location = New System.Drawing.Point(484, 122)
        Me.dgvMotorizados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMotorizados.Name = "dgvMotorizados"
        Me.dgvMotorizados.ReadOnly = True
        Me.dgvMotorizados.RowHeadersWidth = 51
        Me.dgvMotorizados.Size = New System.Drawing.Size(672, 334)
        Me.dgvMotorizados.TabIndex = 0
        '
        'IdmotorizadoDataGridViewTextBoxColumn
        '
        Me.IdmotorizadoDataGridViewTextBoxColumn.DataPropertyName = "id_motorizado"
        Me.IdmotorizadoDataGridViewTextBoxColumn.HeaderText = "id_motorizado"
        Me.IdmotorizadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdmotorizadoDataGridViewTextBoxColumn.Name = "IdmotorizadoDataGridViewTextBoxColumn"
        Me.IdmotorizadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotorizadoBindingSource
        '
        Me.MotorizadoBindingSource.DataMember = "Motorizado"
        Me.MotorizadoBindingSource.DataSource = Me.LasPalmerasDataSet
        '
        'LasPalmerasDataSet
        '
        Me.LasPalmerasDataSet.DataSetName = "lasPalmerasDataSet"
        Me.LasPalmerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMotoID
        '
        Me.lblMotoID.AutoSize = True
        Me.lblMotoID.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotoID.Location = New System.Drawing.Point(13, 138)
        Me.lblMotoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMotoID.Name = "lblMotoID"
        Me.lblMotoID.Size = New System.Drawing.Size(217, 32)
        Me.lblMotoID.TabIndex = 1
        Me.lblMotoID.Text = "ID de Motorizado"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.Location = New System.Drawing.Point(13, 173)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(250, 32)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre Motorizado"
        '
        'lblListado
        '
        Me.lblListado.AutoSize = True
        Me.lblListado.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblListado.Location = New System.Drawing.Point(223, 19)
        Me.lblListado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(671, 81)
        Me.lblListado.TabIndex = 3
        Me.lblListado.Text = "Listado de Motorizado"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotorizadoBindingSource, "id_motorizado", True))
        Me.txtID.Location = New System.Drawing.Point(302, 148)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(132, 22)
        Me.txtID.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotorizadoBindingSource, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(302, 183)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 22)
        Me.txtNombre.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 4
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(19, 273)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(222, 58)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar Motorizado"
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        Me.btnGuardar.Location = New System.Drawing.Point(19, 339)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(222, 58)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        Me.btnBorrar.Location = New System.Drawing.Point(19, 406)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(222, 58)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Despedir"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'MotorizadoTableAdapter
        '
        Me.MotorizadoTableAdapter.ClearBeforeFill = True
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblApellido.Location = New System.Drawing.Point(13, 212)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(252, 32)
        Me.lblApellido.TabIndex = 10
        Me.lblApellido.Text = "Apellido Motorizado"
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotorizadoBindingSource, "apellido", True))
        Me.txtApellido.Location = New System.Drawing.Point(302, 221)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(132, 22)
        Me.txtApellido.TabIndex = 11
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegresar.Location = New System.Drawing.Point(33, 88)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(90, 28)
        Me.lblRegresar.TabIndex = 15
        Me.lblRegresar.Text = "Regresar"
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.back
        Me.pctRegresar.Location = New System.Drawing.Point(50, 35)
        Me.pctRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(51, 50)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 14
        Me.pctRegresar.TabStop = False
        '
        'frmAdminMotorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1209, 494)
        Me.Controls.Add(Me.lblRegresar)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblListado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblMotoID)
        Me.Controls.Add(Me.dgvMotorizados)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAdminMotorizado"
        Me.Text = "Admin del Motorizado"
        CType(Me.dgvMotorizados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorizadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMotorizados As DataGridView
    Friend WithEvents lblMotoID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblListado As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents MotorizadoBindingSource As BindingSource
    Friend WithEvents MotorizadoTableAdapter As lasPalmerasDataSetTableAdapters.MotorizadoTableAdapter
    Friend WithEvents IdmotorizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblRegresar As Label
    Friend WithEvents pctRegresar As PictureBox
End Class
