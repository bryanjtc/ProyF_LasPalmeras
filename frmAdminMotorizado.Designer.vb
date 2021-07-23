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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddMoto = New System.Windows.Forms.Button()
        Me.btnDespedir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblMotoID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtMotoID = New System.Windows.Forms.TextBox()
        Me.txtNombreMoto = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(248, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 398)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAddMoto
        '
        Me.btnAddMoto.Location = New System.Drawing.Point(53, 302)
        Me.btnAddMoto.Name = "btnAddMoto"
        Me.btnAddMoto.Size = New System.Drawing.Size(145, 23)
        Me.btnAddMoto.TabIndex = 1
        Me.btnAddMoto.Text = "Agregar Motorizado"
        Me.btnAddMoto.UseVisualStyleBackColor = True
        '
        'btnDespedir
        '
        Me.btnDespedir.Location = New System.Drawing.Point(53, 331)
        Me.btnDespedir.Name = "btnDespedir"
        Me.btnDespedir.Size = New System.Drawing.Size(145, 23)
        Me.btnDespedir.TabIndex = 2
        Me.btnDespedir.Text = "Despedir"
        Me.btnDespedir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(53, 360)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(145, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblMotoID
        '
        Me.lblMotoID.AutoSize = True
        Me.lblMotoID.Location = New System.Drawing.Point(22, 59)
        Me.lblMotoID.Name = "lblMotoID"
        Me.lblMotoID.Size = New System.Drawing.Size(88, 13)
        Me.lblMotoID.TabIndex = 5
        Me.lblMotoID.Text = "ID de Motorizado"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(11, 95)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(99, 13)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre Motorizado"
        '
        'txtMotoID
        '
        Me.txtMotoID.Location = New System.Drawing.Point(116, 56)
        Me.txtMotoID.Name = "txtMotoID"
        Me.txtMotoID.Size = New System.Drawing.Size(100, 20)
        Me.txtMotoID.TabIndex = 7
        '
        'txtNombreMoto
        '
        Me.txtNombreMoto.Location = New System.Drawing.Point(116, 92)
        Me.txtNombreMoto.Name = "txtNombreMoto"
        Me.txtNombreMoto.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreMoto.TabIndex = 8
        '
        'frmAdminMotorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 450)
        Me.Controls.Add(Me.txtNombreMoto)
        Me.Controls.Add(Me.txtMotoID)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblMotoID)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnDespedir)
        Me.Controls.Add(Me.btnAddMoto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmAdminMotorizado"
        Me.Text = "frmAdminMotorizado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddMoto As Button
    Friend WithEvents btnDespedir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblMotoID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtMotoID As TextBox
    Friend WithEvents txtNombreMoto As TextBox
End Class
