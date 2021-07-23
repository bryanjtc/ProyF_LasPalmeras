<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoApp))
        Me.lblInfoApp = New System.Windows.Forms.Label()
        Me.btnVerInfoApp = New System.Windows.Forms.Button()
        Me.btnVerProjecto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfoApp
        '
        Me.lblInfoApp.AutoSize = True
        Me.lblInfoApp.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblInfoApp.Location = New System.Drawing.Point(21, 18)
        Me.lblInfoApp.Name = "lblInfoApp"
        Me.lblInfoApp.Size = New System.Drawing.Size(1667, 350)
        Me.lblInfoApp.TabIndex = 0
        Me.lblInfoApp.Text = resources.GetString("lblInfoApp.Text")
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
        Me.btnVerInfoApp.Location = New System.Drawing.Point(270, 486)
        Me.btnVerInfoApp.Name = "btnVerInfoApp"
        Me.btnVerInfoApp.Size = New System.Drawing.Size(225, 94)
        Me.btnVerInfoApp.TabIndex = 4
        Me.btnVerInfoApp.Text = "Informacion de la aplicacion"
        Me.btnVerInfoApp.UseVisualStyleBackColor = False
        '
        'btnVerProjecto
        '
        Me.btnVerProjecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerProjecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVerProjecto.FlatAppearance.BorderSize = 4
        Me.btnVerProjecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerProjecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVerProjecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProjecto.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.btnVerProjecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVerProjecto.Location = New System.Drawing.Point(26, 486)
        Me.btnVerProjecto.Name = "btnVerProjecto"
        Me.btnVerProjecto.Size = New System.Drawing.Size(225, 94)
        Me.btnVerProjecto.TabIndex = 3
        Me.btnVerProjecto.Text = "Proyecto Las Palmeras"
        Me.btnVerProjecto.UseVisualStyleBackColor = False
        '
        'frmInfoApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1711, 611)
        Me.Controls.Add(Me.btnVerInfoApp)
        Me.Controls.Add(Me.btnVerProjecto)
        Me.Controls.Add(Me.lblInfoApp)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmInfoApp"
        Me.Text = "Informacion de la aplicacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoApp As Label
    Friend WithEvents btnVerInfoApp As Button
    Friend WithEvents btnVerProjecto As Button
End Class
