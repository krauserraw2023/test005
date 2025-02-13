<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscDeclaraConsentida
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlConsentida = New System.Windows.Forms.Panel()
        Me.pnlResolucionConsentida = New System.Windows.Forms.Panel()
        Me.txtNumeroResolucion = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.ckbResolucion = New System.Windows.Forms.CheckBox()
        Me.ckbFecRecepcion = New System.Windows.Forms.CheckBox()
        Me.dtpFechaRecepResolucion = New Legolas.APPUIComponents.uscDateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ckbFecResolucion = New System.Windows.Forms.CheckBox()
        Me.dtpFechaResolucion = New Legolas.APPUIComponents.uscDateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtNoConsentida = New System.Windows.Forms.RadioButton()
        Me.rbtSiConsentida = New System.Windows.Forms.RadioButton()
        Me.lblConsentida = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlConsentida.SuspendLayout()
        Me.pnlResolucionConsentida.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlConsentida
        '
        Me.pnlConsentida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsentida.Controls.Add(Me.pnlResolucionConsentida)
        Me.pnlConsentida.Controls.Add(Me.rbtNoConsentida)
        Me.pnlConsentida.Controls.Add(Me.rbtSiConsentida)
        Me.pnlConsentida.Controls.Add(Me.lblConsentida)
        Me.pnlConsentida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConsentida.Location = New System.Drawing.Point(0, 0)
        Me.pnlConsentida.Name = "pnlConsentida"
        Me.pnlConsentida.Size = New System.Drawing.Size(900, 38)
        Me.pnlConsentida.TabIndex = 6
        '
        'pnlResolucionConsentida
        '
        Me.pnlResolucionConsentida.Controls.Add(Me.txtNumeroResolucion)
        Me.pnlResolucionConsentida.Controls.Add(Me.ckbResolucion)
        Me.pnlResolucionConsentida.Controls.Add(Me.ckbFecRecepcion)
        Me.pnlResolucionConsentida.Controls.Add(Me.dtpFechaRecepResolucion)
        Me.pnlResolucionConsentida.Controls.Add(Me.Label10)
        Me.pnlResolucionConsentida.Controls.Add(Me.ckbFecResolucion)
        Me.pnlResolucionConsentida.Controls.Add(Me.dtpFechaResolucion)
        Me.pnlResolucionConsentida.Controls.Add(Me.Label6)
        Me.pnlResolucionConsentida.Controls.Add(Me.Label5)
        Me.pnlResolucionConsentida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResolucionConsentida.Location = New System.Drawing.Point(191, 0)
        Me.pnlResolucionConsentida.Name = "pnlResolucionConsentida"
        Me.pnlResolucionConsentida.Size = New System.Drawing.Size(707, 36)
        Me.pnlResolucionConsentida.TabIndex = 3
        Me.pnlResolucionConsentida.Visible = False
        '
        'txtNumeroResolucion
        '
        Me.txtNumeroResolucion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNumeroResolucion._BloquearPaste = False
        Me.txtNumeroResolucion._SeleccionarTodo = False
        Me.txtNumeroResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroResolucion.Location = New System.Drawing.Point(99, 8)
        Me.txtNumeroResolucion.MaxLength = 120
        Me.txtNumeroResolucion.Name = "txtNumeroResolucion"
        Me.txtNumeroResolucion.Size = New System.Drawing.Size(220, 20)
        Me.txtNumeroResolucion.TabIndex = 1
        Me.txtNumeroResolucion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
        Me.txtNumeroResolucion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'ckbResolucion
        '
        Me.ckbResolucion.AutoSize = True
        Me.ckbResolucion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckbResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbResolucion.Location = New System.Drawing.Point(321, 10)
        Me.ckbResolucion.Name = "ckbResolucion"
        Me.ckbResolucion.Size = New System.Drawing.Size(15, 14)
        Me.ckbResolucion.TabIndex = 2
        Me.ckbResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckbResolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ckbResolucion, "Activar checked cuando no existe Nro de resolución.")
        Me.ckbResolucion.UseVisualStyleBackColor = True
        '
        'ckbFecRecepcion
        '
        Me.ckbFecRecepcion.AutoSize = True
        Me.ckbFecRecepcion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckbFecRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbFecRecepcion.Location = New System.Drawing.Point(690, 9)
        Me.ckbFecRecepcion.Name = "ckbFecRecepcion"
        Me.ckbFecRecepcion.Size = New System.Drawing.Size(15, 14)
        Me.ckbFecRecepcion.TabIndex = 8
        Me.ckbFecRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckbFecRecepcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ckbFecRecepcion, "Activar checked cuando no existe fecha de recepción de la resolución.")
        Me.ckbFecRecepcion.UseVisualStyleBackColor = True
        '
        'dtpFechaRecepResolucion
        '
        Me.dtpFechaRecepResolucion.Location = New System.Drawing.Point(604, 6)
        Me.dtpFechaRecepResolucion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpFechaRecepResolucion.Name = "dtpFechaRecepResolucion"
        Me.dtpFechaRecepResolucion.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaRecepResolucion.TabIndex = 7
        Me.dtpFechaRecepResolucion.Value = "/  /"
        Me.dtpFechaRecepResolucion.ValueLong = CType(0, Long)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(526, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "F. Recepción :"
        '
        'ckbFecResolucion
        '
        Me.ckbFecResolucion.AutoSize = True
        Me.ckbFecResolucion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckbFecResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbFecResolucion.Location = New System.Drawing.Point(508, 10)
        Me.ckbFecResolucion.Name = "ckbFecResolucion"
        Me.ckbFecResolucion.Size = New System.Drawing.Size(15, 14)
        Me.ckbFecResolucion.TabIndex = 5
        Me.ckbFecResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckbFecResolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ckbFecResolucion, "Activar checked cuando no existe fecha de resolución.")
        Me.ckbFecResolucion.UseVisualStyleBackColor = True
        '
        'dtpFechaResolucion
        '
        Me.dtpFechaResolucion.Location = New System.Drawing.Point(423, 7)
        Me.dtpFechaResolucion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpFechaResolucion.Name = "dtpFechaResolucion"
        Me.dtpFechaResolucion.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaResolucion.TabIndex = 4
        Me.dtpFechaResolucion.Value = "/  /"
        Me.dtpFechaResolucion.ValueLong = CType(0, Long)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "F. Resolución :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "N° de Resolución:"
        '
        'rbtNoConsentida
        '
        Me.rbtNoConsentida.AutoSize = True
        Me.rbtNoConsentida.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbtNoConsentida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNoConsentida.Location = New System.Drawing.Point(150, 0)
        Me.rbtNoConsentida.Name = "rbtNoConsentida"
        Me.rbtNoConsentida.Size = New System.Drawing.Size(41, 36)
        Me.rbtNoConsentida.TabIndex = 2
        Me.rbtNoConsentida.Text = "NO"
        Me.rbtNoConsentida.UseVisualStyleBackColor = True
        '
        'rbtSiConsentida
        '
        Me.rbtSiConsentida.AutoSize = True
        Me.rbtSiConsentida.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbtSiConsentida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSiConsentida.Location = New System.Drawing.Point(115, 0)
        Me.rbtSiConsentida.Name = "rbtSiConsentida"
        Me.rbtSiConsentida.Size = New System.Drawing.Size(35, 36)
        Me.rbtSiConsentida.TabIndex = 1
        Me.rbtSiConsentida.Text = "SI"
        Me.rbtSiConsentida.UseVisualStyleBackColor = True
        '
        'lblConsentida
        '
        Me.lblConsentida.AutoSize = True
        Me.lblConsentida.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblConsentida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsentida.Location = New System.Drawing.Point(0, 0)
        Me.lblConsentida.Name = "lblConsentida"
        Me.lblConsentida.Size = New System.Drawing.Size(115, 26)
        Me.lblConsentida.TabIndex = 0
        Me.lblConsentida.Text = "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sentencia firme :   "
        '
        'uscDeclaraConsentida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlConsentida)
        Me.Name = "uscDeclaraConsentida"
        Me.Size = New System.Drawing.Size(900, 38)
        Me.pnlConsentida.ResumeLayout(False)
        Me.pnlConsentida.PerformLayout()
        Me.pnlResolucionConsentida.ResumeLayout(False)
        Me.pnlResolucionConsentida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlConsentida As Panel
    Friend WithEvents rbtNoConsentida As RadioButton
    Friend WithEvents rbtSiConsentida As RadioButton
    Friend WithEvents lblConsentida As Label
    Friend WithEvents pnlResolucionConsentida As Panel
    Friend WithEvents txtNumeroResolucion As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents ckbResolucion As CheckBox
    Friend WithEvents ckbFecRecepcion As CheckBox
    Friend WithEvents dtpFechaRecepResolucion As Legolas.APPUIComponents.uscDateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents ckbFecResolucion As CheckBox
    Friend WithEvents dtpFechaResolucion As Legolas.APPUIComponents.uscDateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
