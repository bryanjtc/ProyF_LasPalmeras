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
        Me.dgvRestaurantes = New System.Windows.Forms.DataGridView()
        Me.lblRestauranteID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTelefono1 = New System.Windows.Forms.Label()
        Me.lblTelefono2 = New System.Windows.Forms.Label()
        Me.txtRestaurantID = New System.Windows.Forms.TextBox()
        Me.txtNombreRest = New System.Windows.Forms.TextBox()
        Me.txtTele1 = New System.Windows.Forms.TextBox()
        Me.txtTele2 = New System.Windows.Forms.TextBox()
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dgvRestaurantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRestaurantes
        '
        Me.dgvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestaurantes.Location = New System.Drawing.Point(291, 12)
        Me.dgvRestaurantes.Name = "dgvRestaurantes"
        Me.dgvRestaurantes.Size = New System.Drawing.Size(261, 214)
        Me.dgvRestaurantes.TabIndex = 0
        '
        'lblRestauranteID
        '
        Me.lblRestauranteID.AutoSize = True
        Me.lblRestauranteID.Location = New System.Drawing.Point(56, 50)
        Me.lblRestauranteID.Name = "lblRestauranteID"
        Me.lblRestauranteID.Size = New System.Drawing.Size(79, 13)
        Me.lblRestauranteID.TabIndex = 1
        Me.lblRestauranteID.Text = "ID Restaurante"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 95)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(122, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre del Restaurante"
        '
        'lblTelefono1
        '
        Me.lblTelefono1.AutoSize = True
        Me.lblTelefono1.Location = New System.Drawing.Point(76, 137)
        Me.lblTelefono1.Name = "lblTelefono1"
        Me.lblTelefono1.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefono1.TabIndex = 3
        Me.lblTelefono1.Text = "Telefono 1"
        '
        'lblTelefono2
        '
        Me.lblTelefono2.AutoSize = True
        Me.lblTelefono2.Location = New System.Drawing.Point(76, 179)
        Me.lblTelefono2.Name = "lblTelefono2"
        Me.lblTelefono2.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefono2.TabIndex = 4
        Me.lblTelefono2.Text = "Telefono 2"
        '
        'txtRestaurantID
        '
        Me.txtRestaurantID.Location = New System.Drawing.Point(141, 47)
        Me.txtRestaurantID.Name = "txtRestaurantID"
        Me.txtRestaurantID.Size = New System.Drawing.Size(100, 20)
        Me.txtRestaurantID.TabIndex = 5
        '
        'txtNombreRest
        '
        Me.txtNombreRest.Location = New System.Drawing.Point(140, 92)
        Me.txtNombreRest.Name = "txtNombreRest"
        Me.txtNombreRest.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreRest.TabIndex = 6
        '
        'txtTele1
        '
        Me.txtTele1.Location = New System.Drawing.Point(141, 134)
        Me.txtTele1.Name = "txtTele1"
        Me.txtTele1.Size = New System.Drawing.Size(100, 20)
        Me.txtTele1.TabIndex = 7
        '
        'txtTele2
        '
        Me.txtTele2.Location = New System.Drawing.Point(141, 176)
        Me.txtTele2.Name = "txtTele2"
        Me.txtTele2.Size = New System.Drawing.Size(100, 20)
        Me.txtTele2.TabIndex = 8
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.Location = New System.Drawing.Point(291, 281)
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.Size = New System.Drawing.Size(261, 143)
        Me.dgvTelefonos.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Agregar Restaurante"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Borrar Restaurante"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(58, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Guardar Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(58, 339)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(58, 310)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Ver Telefonos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmAdminRestaurantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvTelefonos)
        Me.Controls.Add(Me.txtTele2)
        Me.Controls.Add(Me.txtTele1)
        Me.Controls.Add(Me.txtNombreRest)
        Me.Controls.Add(Me.txtRestaurantID)
        Me.Controls.Add(Me.lblTelefono2)
        Me.Controls.Add(Me.lblTelefono1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblRestauranteID)
        Me.Controls.Add(Me.dgvRestaurantes)
        Me.Name = "frmAdminRestaurantes"
        Me.Text = "frmAdminRestaurantes"
        CType(Me.dgvRestaurantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRestaurantes As DataGridView
    Friend WithEvents lblRestauranteID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTelefono1 As Label
    Friend WithEvents lblTelefono2 As Label
    Friend WithEvents txtRestaurantID As TextBox
    Friend WithEvents txtNombreRest As TextBox
    Friend WithEvents txtTele1 As TextBox
    Friend WithEvents txtTele2 As TextBox
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
