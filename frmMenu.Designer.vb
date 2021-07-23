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
        Me.pctPedidos = New System.Windows.Forms.PictureBox()
        Me.pctNewPedido = New System.Windows.Forms.PictureBox()
        Me.pctAdmin = New System.Windows.Forms.PictureBox()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        Me.pctSalir = New System.Windows.Forms.PictureBox()
        Me.pctRegresar = New System.Windows.Forms.PictureBox()
        Me.lblRegresar = New System.Windows.Forms.Label()
        CType(Me.pctPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctNewPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAdministracion.Location = New System.Drawing.Point(30, 241)
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
        Me.btnNuevoPedido.Location = New System.Drawing.Point(334, 241)
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
        Me.btnVerPedidos.Location = New System.Drawing.Point(636, 241)
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
        Me.lblSalir.Location = New System.Drawing.Point(828, 335)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(62, 32)
        Me.lblSalir.TabIndex = 10
        Me.lblSalir.Text = "Salir"
        '
        'pctPedidos
        '
        Me.pctPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pctPedidos.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.to_do_list
        Me.pctPedidos.Location = New System.Drawing.Point(664, 262)
        Me.pctPedidos.Name = "pctPedidos"
        Me.pctPedidos.Size = New System.Drawing.Size(40, 40)
        Me.pctPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPedidos.TabIndex = 23
        Me.pctPedidos.TabStop = False
        '
        'pctNewPedido
        '
        Me.pctNewPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pctNewPedido.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.order
        Me.pctNewPedido.Location = New System.Drawing.Point(366, 257)
        Me.pctNewPedido.Name = "pctNewPedido"
        Me.pctNewPedido.Size = New System.Drawing.Size(45, 45)
        Me.pctNewPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctNewPedido.TabIndex = 22
        Me.pctNewPedido.TabStop = False
        '
        'pctAdmin
        '
        Me.pctAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pctAdmin.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.budget
        Me.pctAdmin.Location = New System.Drawing.Point(59, 262)
        Me.pctAdmin.Name = "pctAdmin"
        Me.pctAdmin.Size = New System.Drawing.Size(40, 40)
        Me.pctAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAdmin.TabIndex = 21
        Me.pctAdmin.TabStop = False
        '
        'pctLogo
        '
        Me.pctLogo.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.palm_tree
        Me.pctLogo.Location = New System.Drawing.Point(41, 56)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(70, 70)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogo.TabIndex = 20
        Me.pctLogo.TabStop = False
        '
        'pctSalir
        '
        Me.pctSalir.Image = Global.ProyF_LasPalmeras.My.Resources.Resources._exit
        Me.pctSalir.Location = New System.Drawing.Point(896, 337)
        Me.pctSalir.Name = "pctSalir"
        Me.pctSalir.Size = New System.Drawing.Size(30, 30)
        Me.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctSalir.TabIndex = 19
        Me.pctSalir.TabStop = False
        '
        'pctRegresar
        '
        Me.pctRegresar.Image = Global.ProyF_LasPalmeras.My.Resources.Resources.back
        Me.pctRegresar.Location = New System.Drawing.Point(12, 337)
        Me.pctRegresar.Name = "pctRegresar"
        Me.pctRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pctRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRegresar.TabIndex = 26
        Me.pctRegresar.TabStop = False
        '
        'lblRegresar
        '
        Me.lblRegresar.AutoSize = True
        Me.lblRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblRegresar.Location = New System.Drawing.Point(48, 335)
        Me.lblRegresar.Name = "lblRegresar"
        Me.lblRegresar.Size = New System.Drawing.Size(110, 32)
        Me.lblRegresar.TabIndex = 27
        Me.lblRegresar.Text = "Regresar"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(938, 379)
        Me.Controls.Add(Me.lblRegresar)
        Me.Controls.Add(Me.pctRegresar)
        Me.Controls.Add(Me.pctPedidos)
        Me.Controls.Add(Me.pctNewPedido)
        Me.Controls.Add(Me.pctAdmin)
        Me.Controls.Add(Me.pctLogo)
        Me.Controls.Add(Me.pctSalir)
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
        CType(Me.pctPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctNewPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAdministracion As Button
    Friend WithEvents btnNuevoPedido As Button
    Friend WithEvents btnVerPedidos As Button
    Friend WithEvents lblLabelPrincipal As Label
    Friend WithEvents lblSalir As Label
    Friend WithEvents pctSalir As PictureBox
    Friend WithEvents pctLogo As PictureBox
    Friend WithEvents pctAdmin As PictureBox
    Friend WithEvents pctNewPedido As PictureBox
    Friend WithEvents pctPedidos As PictureBox
    Friend WithEvents pctRegresar As PictureBox
    Friend WithEvents lblRegresar As Label
End Class
