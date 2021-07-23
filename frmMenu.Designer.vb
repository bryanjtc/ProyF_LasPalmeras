<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAdministracion = New System.Windows.Forms.Button()
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.btnVerPedidos = New System.Windows.Forms.Button()
        Me.lblLabelPrincipal = New System.Windows.Forms.Label()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Black", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(132, 45)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(776, 81)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Restaurante LasPalmeras"
        '
        'btnAdministracion
        '
        Me.btnAdministracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAdministracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAdministracion.FlatAppearance.BorderSize = 4
        Me.btnAdministracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdministracion.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.btnAdministracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAdministracion.Location = New System.Drawing.Point(12, 240)
        Me.btnAdministracion.Name = "btnAdministracion"
        Me.btnAdministracion.Size = New System.Drawing.Size(290, 76)
        Me.btnAdministracion.TabIndex = 0
        Me.btnAdministracion.Text = "Administracion"
        Me.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdministracion.UseVisualStyleBackColor = False
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnNuevoPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnNuevoPedido.FlatAppearance.BorderSize = 4
        Me.btnNuevoPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNuevoPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoPedido.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.btnNuevoPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnNuevoPedido.Location = New System.Drawing.Point(316, 240)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(290, 76)
        Me.btnNuevoPedido.TabIndex = 1
        Me.btnNuevoPedido.Text = "Nuevo pedido"
        Me.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoPedido.UseVisualStyleBackColor = False
        '
        'btnVerPedidos
        '
        Me.btnVerPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVerPedidos.FlatAppearance.BorderSize = 4
        Me.btnVerPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerPedidos.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.btnVerPedidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVerPedidos.Location = New System.Drawing.Point(618, 240)
        Me.btnVerPedidos.Name = "btnVerPedidos"
        Me.btnVerPedidos.Size = New System.Drawing.Size(290, 76)
        Me.btnVerPedidos.TabIndex = 2
        Me.btnVerPedidos.Text = "Ver los pedidos"
        Me.btnVerPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerPedidos.UseVisualStyleBackColor = False
        '
        'lblLabelPrincipal
        '
        Me.lblLabelPrincipal.AutoSize = True
        Me.lblLabelPrincipal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblLabelPrincipal.Location = New System.Drawing.Point(316, 141)
        Me.lblLabelPrincipal.Name = "lblLabelPrincipal"
        Me.lblLabelPrincipal.Size = New System.Drawing.Size(306, 54)
        Me.lblLabelPrincipal.TabIndex = 4
        Me.lblLabelPrincipal.Text = "Menu Principal"
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblSalir.Location = New System.Drawing.Point(812, 342)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(62, 32)
        Me.lblSalir.TabIndex = 10
        Me.lblSalir.Text = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(921, 379)
        Me.Controls.Add(Me.lblSalir)
        Me.Controls.Add(Me.btnVerPedidos)
        Me.Controls.Add(Me.lblLabelPrincipal)
        Me.Controls.Add(Me.btnNuevoPedido)
        Me.Controls.Add(Me.btnAdministracion)
        Me.Controls.Add(Me.lblTitulo)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt As Button
    Friend WithEvents btn As Button
    Friend WithEvents b As Button
    Friend WithEvents botona As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAdministracion As Button
    Friend WithEvents btnNuevoPedido As Button
    Friend WithEvents btnVerPedidos As Button
    Friend WithEvents lblLabelPrincipal As Label
    Friend WithEvents lblSalir As Label
End Class
