Namespace Mantenimiento.Tratamiento.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantResultadoPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.cmdAceptar = New System.Windows.Forms.Button()
            Me.pnlCancelar = New System.Windows.Forms.Panel()
            Me.cmdCancelar = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkTabla = New System.Windows.Forms.CheckBox()
            Me.txtNombreTabla = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtDescripcion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNumOrd = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlCancelar.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(523, 225)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pnlGrabar)
            Me.Panel1.Controls.Add(Me.pnlCancelar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 181)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(523, 44)
            Me.Panel1.TabIndex = 1
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.cmdAceptar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(325, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(97, 44)
            Me.pnlGrabar.TabIndex = 6
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.cmdAceptar.Location = New System.Drawing.Point(2, 2)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(94, 40)
            Me.cmdAceptar.TabIndex = 0
            Me.cmdAceptar.Text = "&Aceptar"
            Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlCancelar
            '
            Me.pnlCancelar.Controls.Add(Me.cmdCancelar)
            Me.pnlCancelar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlCancelar.Location = New System.Drawing.Point(422, 0)
            Me.pnlCancelar.Name = "pnlCancelar"
            Me.pnlCancelar.Size = New System.Drawing.Size(101, 44)
            Me.pnlCancelar.TabIndex = 5
            '
            'cmdCancelar
            '
            Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.cmdCancelar.Location = New System.Drawing.Point(1, 2)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(97, 40)
            Me.cmdCancelar.TabIndex = 2
            Me.cmdCancelar.Text = "&Cancelar"
            Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkTabla)
            Me.GroupBox1.Controls.Add(Me.txtNombreTabla)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtDescripcion)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtNumOrd)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(523, 181)
            Me.GroupBox1.TabIndex = 21
            Me.GroupBox1.TabStop = False
            '
            'chkTabla
            '
            Me.chkTabla.AutoSize = True
            Me.chkTabla.Location = New System.Drawing.Point(120, 119)
            Me.chkTabla.Name = "chkTabla"
            Me.chkTabla.Size = New System.Drawing.Size(135, 17)
            Me.chkTabla.TabIndex = 22
            Me.chkTabla.Text = "Utiliza tabla del sistema"
            Me.chkTabla.UseVisualStyleBackColor = True
            '
            'txtNombreTabla
            '
            Me.txtNombreTabla._BloquearPaste = False
            Me.txtNombreTabla._SeleccionarTodo = False
            Me.txtNombreTabla.Location = New System.Drawing.Point(120, 145)
            Me.txtNombreTabla.MaxLength = 50
            Me.txtNombreTabla.Name = "txtNombreTabla"
            Me.txtNombreTabla.Size = New System.Drawing.Size(385, 20)
            Me.txtNombreTabla.TabIndex = 20
            Me.txtNombreTabla.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombreTabla.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(22, 148)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(91, 13)
            Me.Label2.TabIndex = 21
            Me.Label2.Text = "Nombre de tabla :"
            '
            'txtDescripcion
            '
            Me.txtDescripcion._BloquearPaste = False
            Me.txtDescripcion._SeleccionarTodo = False
            Me.txtDescripcion.Location = New System.Drawing.Point(120, 65)
            Me.txtDescripcion.MaxLength = 500
            Me.txtDescripcion.Multiline = True
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescripcion.Size = New System.Drawing.Size(385, 47)
            Me.txtDescripcion.TabIndex = 1
            Me.txtDescripcion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDescripcion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNombre
            '
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(120, 39)
            Me.txtNombre.MaxLength = 255
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(385, 20)
            Me.txtNombre.TabIndex = 1
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(22, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 13)
            Me.Label1.TabIndex = 19
            Me.Label1.Text = "Núm. Ord.:"
            '
            'txtNumOrd
            '
            Me.txtNumOrd._BloquearPaste = False
            Me.txtNumOrd._SeleccionarTodo = False
            Me.txtNumOrd.Location = New System.Drawing.Point(120, 13)
            Me.txtNumOrd.MaxLength = 2
            Me.txtNumOrd.Name = "txtNumOrd"
            Me.txtNumOrd.Size = New System.Drawing.Size(97, 20)
            Me.txtNumOrd.TabIndex = 1
            Me.txtNumOrd.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumOrd.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(22, 73)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(66, 13)
            Me.Label5.TabIndex = 19
            Me.Label5.Text = "Descripción:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(22, 44)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 13)
            Me.Label3.TabIndex = 19
            Me.Label3.Text = "Nombre :"
            '
            'frmMantResultadoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(523, 225)
            Me.Name = "frmMantResultadoPopup"
            Me.Text = "Resultado por ficha de clasificacion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlCancelar.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents cmdAceptar As System.Windows.Forms.Button
        Friend WithEvents pnlCancelar As System.Windows.Forms.Panel
        Friend WithEvents cmdCancelar As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDescripcion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNumOrd As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents chkTabla As System.Windows.Forms.CheckBox
        Friend WithEvents txtNombreTabla As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace