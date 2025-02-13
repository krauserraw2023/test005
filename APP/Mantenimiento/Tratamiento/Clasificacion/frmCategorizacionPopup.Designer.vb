Namespace Mantenimiento.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCategorizacionPopup
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
            Me.txtCategoria = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtValMin = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtValMax = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
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
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(553, 133)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pnlGrabar)
            Me.Panel1.Controls.Add(Me.pnlCancelar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 89)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(553, 44)
            Me.Panel1.TabIndex = 0
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.cmdAceptar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(355, 0)
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
            Me.pnlCancelar.Location = New System.Drawing.Point(452, 0)
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
            'txtCategoria
            '
            Me.txtCategoria._BloquearPaste = False
            Me.txtCategoria._SeleccionarTodo = False
            Me.txtCategoria.Location = New System.Drawing.Point(113, 17)
            Me.txtCategoria.MaxLength = 250
            Me.txtCategoria.Name = "txtCategoria"
            Me.txtCategoria.Size = New System.Drawing.Size(404, 20)
            Me.txtCategoria.TabIndex = 1
            Me.txtCategoria.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtCategoria.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtValMin
            '
            Me.txtValMin._BloquearPaste = False
            Me.txtValMin._SeleccionarTodo = False
            Me.txtValMin.Location = New System.Drawing.Point(113, 46)
            Me.txtValMin.MaxLength = 3
            Me.txtValMin.Name = "txtValMin"
            Me.txtValMin.Size = New System.Drawing.Size(97, 20)
            Me.txtValMin.TabIndex = 1
            Me.txtValMin.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtValMin.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtValMax
            '
            Me.txtValMax._BloquearPaste = False
            Me.txtValMax._SeleccionarTodo = False
            Me.txtValMax.Location = New System.Drawing.Point(420, 42)
            Me.txtValMax.MaxLength = 3
            Me.txtValMax.Name = "txtValMax"
            Me.txtValMax.Size = New System.Drawing.Size(97, 20)
            Me.txtValMax.TabIndex = 1
            Me.txtValMax.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtValMax.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(49, 21)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 19
            Me.Label4.Text = "Categoria:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(343, 46)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 13)
            Me.Label1.TabIndex = 19
            Me.Label1.Text = "Valor Máximo:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(35, 49)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 13)
            Me.Label2.TabIndex = 19
            Me.Label2.Text = "Valor Mínimo:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtCategoria)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtValMin)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtValMax)
            Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(530, 75)
            Me.GroupBox1.TabIndex = 20
            Me.GroupBox1.TabStop = False
            '
            'frmCategorizacionPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(553, 133)
            Me.Name = "frmCategorizacionPopup"
            Me.Text = "Categoria ficha"
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
        Friend WithEvents txtValMax As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtValMin As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCategoria As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace