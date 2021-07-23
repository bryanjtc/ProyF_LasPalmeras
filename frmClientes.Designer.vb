<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblClienteID = New System.Windows.Forms.Label()
        Me.cboClienteID = New System.Windows.Forms.ComboBox()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblRestaurante = New System.Windows.Forms.Label()
        Me.cboRestaurantes = New System.Windows.Forms.ComboBox()
        Me.lblMotorizado = New System.Windows.Forms.Label()
        Me.cboMotorizado = New System.Windows.Forms.ComboBox()
        Me.lblHoraEntrega = New System.Windows.Forms.Label()
        Me.txtHoraEntrega = New System.Windows.Forms.TextBox()
        Me.lblCostoDeEntrega = New System.Windows.Forms.Label()
        Me.txtCostoDeEntrega = New System.Windows.Forms.TextBox()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.lblPedidoAct = New System.Windows.Forms.Label()
        Me.btnAddProducto = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblRegresar = New System.Windows.Forms.Label()
        Me.BindingSourceClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblNombreCliente.Location = New System.Drawing.Point(433, 135)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(195, 32)
        Me.lblNombreCliente.TabIndex = 0
        Me.lblNombreCliente.Text = "Nombre Cliente"
        '
        'lblClienteID
        '
        Me.lblClienteID.AutoSize = True
        Me.lblClienteID.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblClienteID.Location = New System.Drawing.Point(19, 135)
        Me.lblClienteID.Name = "lblClienteID"
        Me.lblClienteID.Size = New System.Drawing.Size(127, 32)
        Me.lblClienteID.TabIndex = 1
        Me.lblClienteID.Text = "ID Cliente"
        '
        'cboClienteID
        '
        Me.cboClienteID.FormattingEnabled = True
        Me.cboClienteID.Location = New System.Drawing.Point(144, 137)
        Me.cboClienteID.Name = "cboClienteID"
        Me.cboClienteID.Size = New System.Drawing.Size(120, 24)
        Me.cboClienteID.TabIndex = 2
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
        Me.btnAgregarCliente.Location = New System.Drawing.Point(286, 130)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(103, 36)
        Me.btnAgregarCliente.TabIndex = 3
        Me.btnAgregarCliente.Text = "Agregar Cliente"
        Me.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNombreCliente.Location = New System.Drawing.Point(619, 137)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(219, 22)
        Me.txtNombreCliente.TabIndex = 4
        '
        'lblRestaurante
        '
        Me.lblRestaurante.AutoSize = True
        Me.lblRestaurante.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblRestaurante.Location = New System.Drawing.Point(19, 188)
        Me.lblRestaurante.Name = "lblRestaurante"
        Me.lblRestaurante.Size = New System.Drawing.Size(151, 32)
        Me.lblRestaurante.TabIndex = 5
        Me.lblRestaurante.Text = "Restaurante"
        '
        'cboRestaurantes
        '
        Me.cboRestaurantes.FormattingEnabled = True
        Me.cboRestaurantes.Location = New System.Drawing.Point(166, 190)
        Me.cboRestaurantes.Name = "cboRestaurantes"
        Me.cboRestaurantes.Size = New System.Drawing.Size(223, 24)
        Me.cboRestaurantes.TabIndex = 6
        '
        'lblMotorizado
        '
        Me.lblMotorizado.AutoSize = True
        Me.lblMotorizado.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblMotorizado.Location = New System.Drawing.Point(476, 188)
        Me.lblMotorizado.Name = "lblMotorizado"
        Me.lblMotorizado.Size = New System.Drawing.Size(149, 32)
        Me.lblMotorizado.TabIndex = 7
        Me.lblMotorizado.Text = "Motorizado"
        '
        'cboMotorizado
        '
        Me.cboMotorizado.FormattingEnabled = True
        Me.cboMotorizado.Location = New System.Drawing.Point(619, 190)
        Me.cboMotorizado.Name = "cboMotorizado"
        Me.cboMotorizado.Size = New System.Drawing.Size(219, 24)
        Me.cboMotorizado.TabIndex = 8
        '
        'lblHoraEntrega
        '
        Me.lblHoraEntrega.AutoSize = True
        Me.lblHoraEntrega.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblHoraEntrega.Location = New System.Drawing.Point(19, 239)
        Me.lblHoraEntrega.Name = "lblHoraEntrega"
        Me.lblHoraEntrega.Size = New System.Drawing.Size(201, 32)
        Me.lblHoraEntrega.TabIndex = 9
        Me.lblHoraEntrega.Text = "Hora de entrega"
        '
        'txtHoraEntrega
        '
        Me.txtHoraEntrega.Location = New System.Drawing.Point(212, 244)
        Me.txtHoraEntrega.Name = "txtHoraEntrega"
        Me.txtHoraEntrega.Size = New System.Drawing.Size(177, 22)
        Me.txtHoraEntrega.TabIndex = 10
        '
        'lblCostoDeEntrega
        '
        Me.lblCostoDeEntrega.AutoSize = True
        Me.lblCostoDeEntrega.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblCostoDeEntrega.Location = New System.Drawing.Point(422, 242)
        Me.lblCostoDeEntrega.Name = "lblCostoDeEntrega"
        Me.lblCostoDeEntrega.Size = New System.Drawing.Size(210, 32)
        Me.lblCostoDeEntrega.TabIndex = 11
        Me.lblCostoDeEntrega.Text = "Costo de Entrega"
        '
        'txtCostoDeEntrega
        '
        Me.txtCostoDeEntrega.Location = New System.Drawing.Point(619, 244)
        Me.txtCostoDeEntrega.Name = "txtCostoDeEntrega"
        Me.txtCostoDeEntrega.Size = New System.Drawing.Size(219, 22)
        Me.txtCostoDeEntrega.TabIndex = 12
        '
        'dgvPedidos
        '
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgvPedidos.Location = New System.Drawing.Point(25, 353)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowHeadersWidth = 51
        Me.dgvPedidos.RowTemplate.Height = 25
        Me.dgvPedidos.Size = New System.Drawing.Size(808, 301)
        Me.dgvPedidos.TabIndex = 13
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
        Me.lblPedidoAct.Location = New System.Drawing.Point(14, 309)
        Me.lblPedidoAct.Name = "lblPedidoAct"
        Me.lblPedidoAct.Size = New System.Drawing.Size(119, 38)
        Me.lblPedidoAct.TabIndex = 15
        Me.lblPedidoAct.Text = "Pedidos"
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
        Me.btnAddProducto.Location = New System.Drawing.Point(25, 691)
        Me.btnAddProducto.Name = "btnAddProducto"
        Me.btnAddProducto.Size = New System.Drawing.Size(146, 36)
        Me.btnAddProducto.TabIndex = 16
        Me.btnAddProducto.Text = "Agregar Producto"
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
        Me.btnBorrar.Location = New System.Drawing.Point(207, 691)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(146, 36)
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
        Me.btnConfirmar.Location = New System.Drawing.Point(704, 691)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(129, 36)
        Me.btnConfirmar.TabIndex = 18
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(646, 657)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 32)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(719, 660)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(114, 22)
        Me.txtTotal.TabIndex = 20
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(286, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(306, 51)
        Me.lblTitulo.TabIndex = 21
        Me.lblTitulo.Text = "Lista de clientes"
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegresar.Location = New System.Drawing.Point(19, 59)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(90, 28)
        Me.lblRegresar.TabIndex = 23
        Me.lblRegresar.Text = "Regresar"
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.back
        Me.pctRegresar.Location = New System.Drawing.Point(36, 12)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(50, 50)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 24
        Me.pctRegresar.TabStop = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(861, 747)
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
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(Me.txtCostoDeEntrega)
        Me.Controls.Add(Me.lblCostoDeEntrega)
        Me.Controls.Add(Me.txtHoraEntrega)
        Me.Controls.Add(Me.lblHoraEntrega)
        Me.Controls.Add(Me.cboMotorizado)
        Me.Controls.Add(Me.lblMotorizado)
        Me.Controls.Add(Me.cboRestaurantes)
        Me.Controls.Add(Me.lblRestaurante)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.cboClienteID)
        Me.Controls.Add(Me.lblClienteID)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.Text = "Clientes"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblClienteID As Label
    Friend WithEvents cboClienteID As ComboBox
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtNombreCliente As TextBox
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
    Friend WithEvents dgvPedidos As DataGridView
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
    Friend WithEvents BindingSourceClientes As BindingSource
    Friend WithEvents pctRegresar As PictureBox
End Class
