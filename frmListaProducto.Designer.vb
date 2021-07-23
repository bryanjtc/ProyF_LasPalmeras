<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaProducto))
        Me.lblListaProducto = New System.Windows.Forms.Label()
        Me.dgvListaProducto = New System.Windows.Forms.DataGridView()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.numCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblRegresar = New System.Windows.Forms.Label()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        CType(Me.dgvListaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblListaProducto
        '
        Me.lblListaProducto.AutoSize = True
        Me.lblListaProducto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblListaProducto.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblListaProducto.Location = New System.Drawing.Point(234, 34)
        Me.lblListaProducto.Name = "lblListaProducto"
        Me.lblListaProducto.Size = New System.Drawing.Size(342, 50)
        Me.lblListaProducto.TabIndex = 0
        Me.lblListaProducto.Text = "Lista de Productos"
        Me.lblListaProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvListaProducto
        '
        Me.dgvListaProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaProducto.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvListaProducto.Location = New System.Drawing.Point(15, 119)
        Me.dgvListaProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvListaProducto.Name = "dgvListaProducto"
        Me.dgvListaProducto.RowHeadersWidth = 51
        Me.dgvListaProducto.RowTemplate.Height = 25
        Me.dgvListaProducto.Size = New System.Drawing.Size(775, 375)
        Me.dgvListaProducto.TabIndex = 1
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSeleccionar.FlatAppearance.BorderSize = 4
        Me.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSeleccionar.Location = New System.Drawing.Point(583, 512)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(207, 49)
        Me.btnSeleccionar.TabIndex = 3
        Me.btnSeleccionar.Text = "Agregar al Pedido"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCantidad.Location = New System.Drawing.Point(415, 522)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(92, 28)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad"
        '
        'numCantidad
        '
        Me.numCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.numCantidad.Location = New System.Drawing.Point(513, 523)
        Me.numCantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(50, 27)
        Me.numCantidad.TabIndex = 5
        Me.numCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegresar.Location = New System.Drawing.Point(30, 76)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(90, 28)
        Me.lblRegresar.TabIndex = 25
        Me.lblRegresar.Text = "Regresar"
        '
        'frmListaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 574)
        Me.Controls.Add(Me.lblRegresar)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.numCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.dgvListaProducto)
        Me.Controls.Add(Me.lblListaProducto)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmListaProducto"
        Me.Text = "Lista de productos"
        CType(Me.dgvListaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblListaProducto As Label
    Friend WithEvents dgvListaProducto As DataGridView
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents lblRegresar As Label
    Friend WithEvents pctRegresar As PictureBox
End Class
