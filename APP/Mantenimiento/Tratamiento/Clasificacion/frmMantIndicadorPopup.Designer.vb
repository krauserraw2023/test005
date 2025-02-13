Namespace Mantenimiento.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Class frmManValoresPopup
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtIndicador = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPuntaje = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumOrd = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(558, 199)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pnlGrabar)
            Me.Panel1.Controls.Add(Me.pnlCancelar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 155)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(558, 44)
            Me.Panel1.TabIndex = 2
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.cmdAceptar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(360, 0)
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
            Me.pnlCancelar.Location = New System.Drawing.Point(457, 0)
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
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 49)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(94, 13)
            Me.Label2.TabIndex = 20
            Me.Label2.Text = "Nombre Indicador:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(48, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 13)
            Me.Label1.TabIndex = 20
            Me.Label1.Text = "Núm. Ord.:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(60, 119)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(46, 13)
            Me.Label3.TabIndex = 20
            Me.Label3.Text = "Puntaje:"
            '
            'txtIndicador
            '
            Me.txtIndicador._BloquearPaste = False
            Me.txtIndicador._SeleccionarTodo = False
            Me.txtIndicador.Location = New System.Drawing.Point(111, 45)
            Me.txtIndicador.MaxLength = 500
            Me.txtIndicador.Multiline = True
            Me.txtIndicador.Name = "txtIndicador"
            Me.txtIndicador.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtIndicador.Size = New System.Drawing.Size(431, 64)
            Me.txtIndicador.TabIndex = 3
            Me.txtIndicador.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtIndicador.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtPuntaje
            '
            Me.txtPuntaje._BloquearPaste = False
            Me.txtPuntaje._SeleccionarTodo = False
            Me.txtPuntaje.Location = New System.Drawing.Point(111, 115)
            Me.txtPuntaje.MaxLength = 3
            Me.txtPuntaje.Name = "txtPuntaje"
            Me.txtPuntaje.Size = New System.Drawing.Size(76, 20)
            Me.txtPuntaje.TabIndex = 3
            Me.txtPuntaje.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPuntaje.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtNumOrd
            '
            Me.txtNumOrd._BloquearPaste = False
            Me.txtNumOrd._SeleccionarTodo = False
            Me.txtNumOrd.Location = New System.Drawing.Point(111, 19)
            Me.txtNumOrd.MaxLength = 2
            Me.txtNumOrd.Name = "txtNumOrd"
            Me.txtNumOrd.Size = New System.Drawing.Size(76, 20)
            Me.txtNumOrd.TabIndex = 3
            Me.txtNumOrd.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumOrd.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNumOrd)
            Me.GroupBox1.Controls.Add(Me.txtPuntaje)
            Me.GroupBox1.Controls.Add(Me.txtIndicador)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(549, 145)
            Me.GroupBox1.TabIndex = 23
            Me.GroupBox1.TabStop = False
            '
            'frmManValoresPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(558, 199)
            Me.Name = "frmManValoresPopup"
            Me.Text = "Mantenimiento de indicadores por variable"
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
        Friend WithEvents txtNumOrd As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPuntaje As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtIndicador As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace