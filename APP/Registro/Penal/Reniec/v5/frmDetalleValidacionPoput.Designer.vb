Namespace Registro.Reniec


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDetalleValidacionPoput
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleValidacionPoput))
            Me.grpTipovalidacion = New System.Windows.Forms.GroupBox()
            Me.txtRestriccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtEstado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaexpedicion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechainscripcion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechavalidacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTipodeverificacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblEtiquetaObservaciones = New System.Windows.Forms.Label()
            Me.lblEtiquetaDetalle = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.grpTipovalidacion.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'grpTipovalidacion
            '
            Me.grpTipovalidacion.Controls.Add(Me.txtRestriccion)
            Me.grpTipovalidacion.Controls.Add(Me.txtEstado)
            Me.grpTipovalidacion.Controls.Add(Me.txtFechaexpedicion)
            Me.grpTipovalidacion.Controls.Add(Me.txtFechainscripcion)
            Me.grpTipovalidacion.Controls.Add(Me.txtFechavalidacion)
            Me.grpTipovalidacion.Controls.Add(Me.txtTipodeverificacion)
            Me.grpTipovalidacion.Controls.Add(Me.Label7)
            Me.grpTipovalidacion.Controls.Add(Me.Label2)
            Me.grpTipovalidacion.Controls.Add(Me.txtObservacion)
            Me.grpTipovalidacion.Controls.Add(Me.Label6)
            Me.grpTipovalidacion.Controls.Add(Me.lblEstado)
            Me.grpTipovalidacion.Controls.Add(Me.Label4)
            Me.grpTipovalidacion.Controls.Add(Me.lblEtiquetaObservaciones)
            Me.grpTipovalidacion.Controls.Add(Me.lblEtiquetaDetalle)
            Me.grpTipovalidacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpTipovalidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpTipovalidacion.Location = New System.Drawing.Point(0, 0)
            Me.grpTipovalidacion.Name = "grpTipovalidacion"
            Me.grpTipovalidacion.Size = New System.Drawing.Size(444, 283)
            Me.grpTipovalidacion.TabIndex = 0
            Me.grpTipovalidacion.TabStop = False
            '
            'txtRestriccion
            '
            Me.txtRestriccion._BloquearPaste = True
            Me.txtRestriccion._SeleccionarTodo = False
            Me.txtRestriccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRestriccion.Location = New System.Drawing.Point(130, 122)
            Me.txtRestriccion.Name = "txtRestriccion"
            Me.txtRestriccion.ReadOnly = True
            Me.txtRestriccion.Size = New System.Drawing.Size(168, 20)
            Me.txtRestriccion.TabIndex = 11
            Me.txtRestriccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtRestriccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtEstado
            '
            Me.txtEstado._BloquearPaste = True
            Me.txtEstado._SeleccionarTodo = False
            Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEstado.Location = New System.Drawing.Point(130, 100)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(168, 20)
            Me.txtEstado.TabIndex = 9
            Me.txtEstado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtFechaexpedicion
            '
            Me.txtFechaexpedicion._BloquearPaste = True
            Me.txtFechaexpedicion._SeleccionarTodo = False
            Me.txtFechaexpedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaexpedicion.Location = New System.Drawing.Point(130, 78)
            Me.txtFechaexpedicion.Name = "txtFechaexpedicion"
            Me.txtFechaexpedicion.ReadOnly = True
            Me.txtFechaexpedicion.Size = New System.Drawing.Size(168, 20)
            Me.txtFechaexpedicion.TabIndex = 7
            Me.txtFechaexpedicion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaexpedicion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtFechainscripcion
            '
            Me.txtFechainscripcion._BloquearPaste = True
            Me.txtFechainscripcion._SeleccionarTodo = False
            Me.txtFechainscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechainscripcion.Location = New System.Drawing.Point(130, 56)
            Me.txtFechainscripcion.Name = "txtFechainscripcion"
            Me.txtFechainscripcion.ReadOnly = True
            Me.txtFechainscripcion.Size = New System.Drawing.Size(168, 20)
            Me.txtFechainscripcion.TabIndex = 5
            Me.txtFechainscripcion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechainscripcion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtFechavalidacion
            '
            Me.txtFechavalidacion._BloquearPaste = True
            Me.txtFechavalidacion._SeleccionarTodo = False
            Me.txtFechavalidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechavalidacion.Location = New System.Drawing.Point(130, 34)
            Me.txtFechavalidacion.Name = "txtFechavalidacion"
            Me.txtFechavalidacion.ReadOnly = True
            Me.txtFechavalidacion.Size = New System.Drawing.Size(168, 20)
            Me.txtFechavalidacion.TabIndex = 3
            Me.txtFechavalidacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechavalidacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtTipodeverificacion
            '
            Me.txtTipodeverificacion._BloquearPaste = True
            Me.txtTipodeverificacion._SeleccionarTodo = False
            Me.txtTipodeverificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipodeverificacion.Location = New System.Drawing.Point(130, 12)
            Me.txtTipodeverificacion.Name = "txtTipodeverificacion"
            Me.txtTipodeverificacion.ReadOnly = True
            Me.txtTipodeverificacion.Size = New System.Drawing.Size(168, 20)
            Me.txtTipodeverificacion.TabIndex = 1
            Me.txtTipodeverificacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTipodeverificacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(9, 83)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(97, 13)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Fecha expedicion :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(9, 61)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(96, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Fecha inscripcion :"
            '
            'txtObservacion
            '
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = False
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(130, 144)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ReadOnly = True
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(305, 40)
            Me.txtObservacion.TabIndex = 13
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(9, 17)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(89, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Tipo Verificacion:"
            '
            'lblEstado
            '
            Me.lblEstado.AutoSize = True
            Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstado.Location = New System.Drawing.Point(9, 105)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(46, 13)
            Me.lblEstado.TabIndex = 8
            Me.lblEstado.Text = "Estado :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(9, 127)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(63, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Restriccion:"
            '
            'lblEtiquetaObservaciones
            '
            Me.lblEtiquetaObservaciones.AutoSize = True
            Me.lblEtiquetaObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaObservaciones.Location = New System.Drawing.Point(9, 147)
            Me.lblEtiquetaObservaciones.Name = "lblEtiquetaObservaciones"
            Me.lblEtiquetaObservaciones.Size = New System.Drawing.Size(81, 13)
            Me.lblEtiquetaObservaciones.TabIndex = 12
            Me.lblEtiquetaObservaciones.Text = "Observaciones:"
            '
            'lblEtiquetaDetalle
            '
            Me.lblEtiquetaDetalle.AutoSize = True
            Me.lblEtiquetaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaDetalle.Location = New System.Drawing.Point(9, 38)
            Me.lblEtiquetaDetalle.Name = "lblEtiquetaDetalle"
            Me.lblEtiquetaDetalle.Size = New System.Drawing.Size(109, 13)
            Me.lblEtiquetaDetalle.TabIndex = 2
            Me.lblEtiquetaDetalle.Text = "Fecha de validacion :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 190)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(444, 46)
            Me.Panel2.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(356, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.grpTipovalidacion)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(444, 283)
            Me.Panel1.TabIndex = 0
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.UscAuditUser1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel3.Location = New System.Drawing.Point(0, 236)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(444, 47)
            Me.Panel3.TabIndex = 1
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(444, 47)
            Me.UscAuditUser1.TabIndex = 0
            '
            'frmDetalleValidacionPoput
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(444, 283)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDetalleValidacionPoput"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Detalle de Validacion"
            Me.grpTipovalidacion.ResumeLayout(False)
            Me.grpTipovalidacion.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grpTipovalidacion As System.Windows.Forms.GroupBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblEstado As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaObservaciones As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaDetalle As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtRestriccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaexpedicion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechainscripcion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechavalidacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtTipodeverificacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser

    End Class

End Namespace