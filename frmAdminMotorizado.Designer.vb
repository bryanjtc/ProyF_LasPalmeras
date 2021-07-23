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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdmotorizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorizadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.lblMotoID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblListado = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MotorizadoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.MotorizadoTableAdapter()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorizadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmotorizadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MotorizadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(224, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(382, 313)
        Me.DataGridView1.TabIndex = 0
        '
        'IdmotorizadoDataGridViewTextBoxColumn
        '
        Me.IdmotorizadoDataGridViewTextBoxColumn.DataPropertyName = "id_motorizado"
        Me.IdmotorizadoDataGridViewTextBoxColumn.HeaderText = "id_motorizado"
        Me.IdmotorizadoDataGridViewTextBoxColumn.Name = "IdmotorizadoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
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
        Me.lblMotoID.Location = New System.Drawing.Point(13, 70)
        Me.lblMotoID.Name = "lblMotoID"
        Me.lblMotoID.Size = New System.Drawing.Size(88, 13)
        Me.lblMotoID.TabIndex = 1
        Me.lblMotoID.Text = "ID de Motorizado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Motorizado"
        '
        'lblListado
        '
        Me.lblListado.AutoSize = True
        Me.lblListado.Location = New System.Drawing.Point(221, 40)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(111, 13)
        Me.lblListado.TabIndex = 3
        Me.lblListado.Text = "Listado de Motorizado"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotorizadoBindingSource, "id_motorizado", True))
        Me.TextBox1.Location = New System.Drawing.Point(107, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotorizadoBindingSource, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(107, 103)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(31, 223)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar Motorizado"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(31, 252)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(121, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(31, 281)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(121, 23)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Despedir"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(31, 311)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(121, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MotorizadoTableAdapter
        '
        Me.MotorizadoTableAdapter.ClearBeforeFill = True
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(2, 146)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(99, 13)
        Me.lblApellido.TabIndex = 10
        Me.lblApellido.Text = "Apellido Motorizado"
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MotorizadoBindingSource, "apellido", True))
        Me.txtApellido.Location = New System.Drawing.Point(107, 146)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 11
        '
        'frmAdminMotorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 401)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblListado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMotoID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmAdminMotorizado"
        Me.Text = "frmAdminMotorizado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorizadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblMotoID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblListado As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents MotorizadoBindingSource As BindingSource
    Friend WithEvents MotorizadoTableAdapter As lasPalmerasDataSetTableAdapters.MotorizadoTableAdapter
    Friend WithEvents IdmotorizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido As TextBox
End Class
