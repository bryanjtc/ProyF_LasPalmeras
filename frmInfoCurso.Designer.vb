<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoCurso))
        Me.lblInfoCurso = New System.Windows.Forms.Label()
        Me.btnVerProyecto = New System.Windows.Forms.Button()
        Me.btnVerInfoApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfoCurso
        '
        Me.lblInfoCurso.AutoSize = True
        Me.lblInfoCurso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoCurso.Location = New System.Drawing.Point(25, 18)
        Me.lblInfoCurso.Name = "lblInfoCurso"
        Me.lblInfoCurso.Size = New System.Drawing.Size(476, 756)
        Me.lblInfoCurso.TabIndex = 0
        Me.lblInfoCurso.Text = resources.GetString("lblInfoCurso.Text")
        Me.lblInfoCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerProyecto
        '
        Me.btnVerProyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerProyecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVerProyecto.FlatAppearance.BorderSize = 4
        Me.btnVerProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProyecto.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.btnVerProyecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVerProyecto.Location = New System.Drawing.Point(30, 835)
        Me.btnVerProyecto.Name = "btnVerProyecto"
        Me.btnVerProyecto.Size = New System.Drawing.Size(225, 94)
        Me.btnVerProyecto.TabIndex = 1
        Me.btnVerProyecto.Text = "Proyecto Las Palmeras"
        Me.btnVerProyecto.UseVisualStyleBackColor = False
        '
        'btnVerInfoApp
        '
        Me.btnVerInfoApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerInfoApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVerInfoApp.FlatAppearance.BorderSize = 4
        Me.btnVerInfoApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerInfoApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerInfoApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerInfoApp.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.btnVerInfoApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVerInfoApp.Location = New System.Drawing.Point(276, 835)
        Me.btnVerInfoApp.Name = "btnVerInfoApp"
        Me.btnVerInfoApp.Size = New System.Drawing.Size(225, 94)
        Me.btnVerInfoApp.TabIndex = 2
        Me.btnVerInfoApp.Text = "Informacion de la aplicacion"
        Me.btnVerInfoApp.UseVisualStyleBackColor = False
        '
        'frmInfoCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 982)
        Me.Controls.Add(Me.btnVerInfoApp)
        Me.Controls.Add(Me.btnVerProyecto)
        Me.Controls.Add(Me.lblInfoCurso)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmInfoCurso"
        Me.Text = "Informacion del curso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoCurso As Label
    Friend WithEvents btnVerProyecto As Button
    Friend WithEvents btnVerInfoApp As Button
End Class
