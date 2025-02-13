Namespace Mantenimiento.Tratamiento.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantResultadoPopupDet
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
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNumOrd = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtPuntajeIni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtPuntajeFin = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbTabla = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
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
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(392, 184)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pnlGrabar)
            Me.Panel1.Controls.Add(Me.pnlCancelar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 140)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(392, 44)
            Me.Panel1.TabIndex = 1
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.cmdAceptar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(194, 0)
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
            Me.pnlCancelar.Location = New System.Drawing.Point(291, 0)
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
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cbbTabla)
            Me.GroupBox1.Controls.Add(Me.txtPuntajeFin)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtPuntajeIni)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtNumOrd)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(392, 140)
            Me.GroupBox1.TabIndex = 21
            Me.GroupBox1.TabStop = False
            '
            'txtNombre
            '
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(107, 65)
            Me.txtNombre.MaxLength = 255
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(258, 20)
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
            Me.txtNumOrd.Location = New System.Drawing.Point(107, 14)
            Me.txtNumOrd.MaxLength = 2
            Me.txtNumOrd.Name = "txtNumOrd"
            Me.txtNumOrd.Size = New System.Drawing.Size(85, 20)
            Me.txtNumOrd.TabIndex = 1
            Me.txtNumOrd.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumOrd.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(22, 69)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(50, 13)
            Me.Label4.TabIndex = 19
            Me.Label4.Text = "Nombre :"
            '
            'txtPuntajeIni
            '
            Me.txtPuntajeIni._BloquearPaste = False
            Me.txtPuntajeIni._SeleccionarTodo = False
            Me.txtPuntajeIni.Location = New System.Drawing.Point(107, 39)
            Me.txtPuntajeIni.MaxLength = 3
            Me.txtPuntajeIni.Name = "txtPuntajeIni"
            Me.txtPuntajeIni.Size = New System.Drawing.Size(85, 20)
            Me.txtPuntajeIni.TabIndex = 23
            Me.txtPuntajeIni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPuntajeIni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(22, 43)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(79, 13)
            Me.Label3.TabIndex = 24
            Me.Label3.Text = "Puntaje Inicial :"
            '
            'txtPuntajeFin
            '
            Me.txtPuntajeFin._BloquearPaste = False
            Me.txtPuntajeFin._SeleccionarTodo = False
            Me.txtPuntajeFin.Location = New System.Drawing.Point(272, 39)
            Me.txtPuntajeFin.MaxLength = 3
            Me.txtPuntajeFin.Name = "txtPuntajeFin"
            Me.txtPuntajeFin.Size = New System.Drawing.Size(93, 20)
            Me.txtPuntajeFin.TabIndex = 25
            Me.txtPuntajeFin.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPuntajeFin.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(195, 43)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(74, 13)
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "Puntaje Final :"
            '
            'cbbTabla
            '
            Me.cbbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTabla.FormattingEnabled = True
            Me.cbbTabla.Location = New System.Drawing.Point(107, 91)
            Me.cbbTabla.Name = "cbbTabla"
            Me.cbbTabla.Size = New System.Drawing.Size(258, 21)
            Me.cbbTabla.TabIndex = 109
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(22, 96)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 13)
            Me.Label2.TabIndex = 110
            Me.Label2.Text = "Tabla :"
            '
            'frmMantResultadoPopupDet
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(392, 184)
            Me.Name = "frmMantResultadoPopupDet"
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
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNumOrd As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtPuntajeFin As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtPuntajeIni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cbbTabla As Legolas.APPUIComponents.MyComboBox
    End Class
End Namespace