Namespace Registro.Carceleta.Clasificacion.Documento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDetGlosaPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetGlosaPopup))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtCodGlosa = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDescripcion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtDescCorta = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.txtDescCorta)
            Me.gbxFormChildContainer.Controls.Add(Me.txtDescripcion)
            Me.gbxFormChildContainer.Controls.Add(Me.txtCodGlosa)
            Me.gbxFormChildContainer.Controls.Add(Me.Label3)
            Me.gbxFormChildContainer.Controls.Add(Me.Label2)
            Me.gbxFormChildContainer.Controls.Add(Me.Label1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(666, 240)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 188)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(666, 52)
            Me.Panel1.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(583, 7)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 67
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(35, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Cod. Glosa:"
            '
            'txtCodGlosa
            '
            Me.txtCodGlosa._BloquearPaste = False
            Me.txtCodGlosa._SeleccionarTodo = False
            Me.txtCodGlosa.Location = New System.Drawing.Point(103, 6)
            Me.txtCodGlosa.Name = "txtCodGlosa"
            Me.txtCodGlosa.Size = New System.Drawing.Size(81, 20)
            Me.txtCodGlosa.TabIndex = 2
            Me.txtCodGlosa.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodGlosa.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDescripcion
            '
            Me.txtDescripcion._BloquearPaste = False
            Me.txtDescripcion._SeleccionarTodo = False
            Me.txtDescripcion.Location = New System.Drawing.Point(103, 76)
            Me.txtDescripcion.Multiline = True
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.ReadOnly = True
            Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescripcion.Size = New System.Drawing.Size(558, 107)
            Me.txtDescripcion.TabIndex = 3
            Me.txtDescripcion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDescripcion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(31, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(66, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Descripción:"
            '
            'txtDescCorta
            '
            Me.txtDescCorta._BloquearPaste = False
            Me.txtDescCorta._SeleccionarTodo = False
            Me.txtDescCorta.Location = New System.Drawing.Point(103, 29)
            Me.txtDescCorta.Multiline = True
            Me.txtDescCorta.Name = "txtDescCorta"
            Me.txtDescCorta.ReadOnly = True
            Me.txtDescCorta.Size = New System.Drawing.Size(558, 43)
            Me.txtDescCorta.TabIndex = 3
            Me.txtDescCorta.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDescCorta.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(4, 32)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(93, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Descripción corta:"
            '
            'frmDetGlosaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(666, 240)
            Me.Name = "frmDetGlosaPopup"
            Me.Text = "Detalle Glosa"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents txtDescripcion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCodGlosa As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtDescCorta As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class
End Namespace