<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminProducto
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblNombreP = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.LasPalmerasDataSet = New ProyF_LasPalmeras.lasPalmerasDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New ProyF_LasPalmeras.lasPalmerasDataSetTableAdapters.ProductoTableAdapter()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.AutoGenerateColumns = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.dgvProductos.DataSource = Me.ProductoBindingSource
        Me.dgvProductos.Location = New System.Drawing.Point(302, 12)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(351, 426)
        Me.dgvProductos.TabIndex = 0
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(50, 49)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(65, 13)
        Me.lblProductID.TabIndex = 1
        Me.lblProductID.Text = "Id_Producto"
        '
        'lblNombreP
        '
        Me.lblNombreP.AutoSize = True
        Me.lblNombreP.Location = New System.Drawing.Point(9, 103)
        Me.lblNombreP.Name = "lblNombreP"
        Me.lblNombreP.Size = New System.Drawing.Size(106, 13)
        Me.lblNombreP.TabIndex = 2
        Me.lblNombreP.Text = "Nombre del producto"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(76, 164)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 3
        Me.lblPrecio.Text = "Precio"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(121, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(121, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(12, 313)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(126, 42)
        Me.btnAddNew.TabIndex = 8
        Me.btnAddNew.Text = "Agregar"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(170, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 42)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 378)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 42)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(170, 313)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(126, 42)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'LasPalmerasDataSet
        '
        Me.LasPalmerasDataSet.DataSetName = "lasPalmerasDataSet"
        Me.LasPalmerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'frmAdminProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombreP)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "frmAdminProducto"
        Me.Text = "frmAdminProducto"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LasPalmerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblNombreP As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents LasPalmerasDataSet As lasPalmerasDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As lasPalmerasDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
