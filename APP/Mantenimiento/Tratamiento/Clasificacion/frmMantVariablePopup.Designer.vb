Namespace Mantenimiento.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantVariablePopup
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
            Me.txtDescripcion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtVariable = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNumOrd = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
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
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(680, 197)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pnlGrabar)
            Me.Panel1.Controls.Add(Me.pnlCancelar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 153)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(680, 44)
            Me.Panel1.TabIndex = 1
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.cmdAceptar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(482, 0)
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
            Me.pnlCancelar.Location = New System.Drawing.Point(579, 0)
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
            Me.GroupBox1.Controls.Add(Me.txtDescripcion)
            Me.GroupBox1.Controls.Add(Me.txtVariable)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtNumOrd)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(663, 142)
            Me.GroupBox1.TabIndex = 21
            Me.GroupBox1.TabStop = False
            '
            'txtDescripcion
            '
            Me.txtDescripcion._BloquearPaste = False
            Me.txtDescripcion._SeleccionarTodo = False
            Me.txtDescripcion.Location = New System.Drawing.Point(93, 65)
            Me.txtDescripcion.MaxLength = 500
            Me.txtDescripcion.Multiline = True
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescripcion.Size = New System.Drawing.Size(564, 68)
            Me.txtDescripcion.TabIndex = 1
            Me.txtDescripcion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDescripcion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtVariable
            '
            Me.txtVariable._BloquearPaste = False
            Me.txtVariable._SeleccionarTodo = False
            Me.txtVariable.Location = New System.Drawing.Point(93, 39)
            Me.txtVariable.MaxLength = 255
            Me.txtVariable.Name = "txtVariable"
            Me.txtVariable.Size = New System.Drawing.Size(564, 20)
            Me.txtVariable.TabIndex = 1
            Me.txtVariable.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtVariable.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(29, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 13)
            Me.Label1.TabIndex = 19
            Me.Label1.Text = "Núm. Ord.:"
            '
            'txtNumOrd
            '
            Me.txtNumOrd._BloquearPaste = False
            Me.txtNumOrd._SeleccionarTodo = False
            Me.txtNumOrd.Location = New System.Drawing.Point(93, 13)
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
            Me.Label5.Location = New System.Drawing.Point(21, 72)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(66, 13)
            Me.Label5.TabIndex = 19
            Me.Label5.Text = "Descripción:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(39, 43)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(48, 13)
            Me.Label4.TabIndex = 19
            Me.Label4.Text = "Variable:"
            '
            'frmMantVariablePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(680, 197)
            Me.Name = "frmMantVariablePopup"
            Me.Text = "Mantenimiento de variables por ficha de clasificación"
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
        Friend WithEvents txtVariable As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNumOrd As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
    End Class
End Namespace