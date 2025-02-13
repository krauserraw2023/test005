<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscAuditUser
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFechEdicion = New System.Windows.Forms.Label()
        Me.lblFechCrea = New System.Windows.Forms.Label()
        Me.lblEditadoPor = New System.Windows.Forms.Label()
        Me.lblCreadoPor = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Creado por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Actualizado por:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblFechEdicion)
        Me.Panel1.Controls.Add(Me.lblFechCrea)
        Me.Panel1.Controls.Add(Me.lblEditadoPor)
        Me.Panel1.Controls.Add(Me.lblCreadoPor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 42)
        Me.Panel1.TabIndex = 2
        '
        'lblFechEdicion
        '
        Me.lblFechEdicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechEdicion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFechEdicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechEdicion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechEdicion.Location = New System.Drawing.Point(496, 22)
        Me.lblFechEdicion.Name = "lblFechEdicion"
        Me.lblFechEdicion.Size = New System.Drawing.Size(160, 16)
        Me.lblFechEdicion.TabIndex = 2
        '
        'lblFechCrea
        '
        Me.lblFechCrea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechCrea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFechCrea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechCrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechCrea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechCrea.Location = New System.Drawing.Point(496, 3)
        Me.lblFechCrea.Name = "lblFechCrea"
        Me.lblFechCrea.Size = New System.Drawing.Size(160, 16)
        Me.lblFechCrea.TabIndex = 2
        '
        'lblEditadoPor
        '
        Me.lblEditadoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEditadoPor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEditadoPor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEditadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditadoPor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEditadoPor.Location = New System.Drawing.Point(86, 22)
        Me.lblEditadoPor.Name = "lblEditadoPor"
        Me.lblEditadoPor.Size = New System.Drawing.Size(408, 16)
        Me.lblEditadoPor.TabIndex = 2
        '
        'lblCreadoPor
        '
        Me.lblCreadoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreadoPor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCreadoPor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreadoPor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCreadoPor.Location = New System.Drawing.Point(86, 3)
        Me.lblCreadoPor.Name = "lblCreadoPor"
        Me.lblCreadoPor.Size = New System.Drawing.Size(408, 16)
        Me.lblCreadoPor.TabIndex = 2
        '
        'uscAuditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uscAuditUser"
        Me.Size = New System.Drawing.Size(657, 42)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFechEdicion As System.Windows.Forms.Label
    Friend WithEvents lblFechCrea As System.Windows.Forms.Label
    Friend WithEvents lblEditadoPor As System.Windows.Forms.Label
    Friend WithEvents lblCreadoPor As System.Windows.Forms.Label

End Class
