Namespace Registro.Expediente
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmCargarProceso
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarProceso))
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.gbInimputable = New System.Windows.Forms.GroupBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtNumExpediente = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtSalaJudicial = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel1.SuspendLayout()
            Me.gbInimputable.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Location = New System.Drawing.Point(182, 8)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(94, 30)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancelar)
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 103)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(388, 45)
            Me.Panel1.TabIndex = 1
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Location = New System.Drawing.Point(282, 8)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(94, 30)
            Me.btnCancelar.TabIndex = 1
            Me.btnCancelar.Text = "&Cancelar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'gbInimputable
            '
            Me.gbInimputable.Controls.Add(Me.Label1)
            Me.gbInimputable.Controls.Add(Me.txtSalaJudicial)
            Me.gbInimputable.Controls.Add(Me.Label8)
            Me.gbInimputable.Controls.Add(Me.txtNumExpediente)
            Me.gbInimputable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbInimputable.Location = New System.Drawing.Point(0, 0)
            Me.gbInimputable.Name = "gbInimputable"
            Me.gbInimputable.Size = New System.Drawing.Size(388, 103)
            Me.gbInimputable.TabIndex = 0
            Me.gbInimputable.TabStop = False
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(11, 18)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(81, 13)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "N° Expediente :"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNumExpediente
            '
            Me.txtNumExpediente._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumExpediente._BloquearPaste = False
            Me.txtNumExpediente._SeleccionarTodo = False
            Me.txtNumExpediente.Location = New System.Drawing.Point(14, 34)
            Me.txtNumExpediente.Name = "txtNumExpediente"
            Me.txtNumExpediente.Size = New System.Drawing.Size(362, 20)
            Me.txtNumExpediente.TabIndex = 1
            Me.txtNumExpediente.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumExpediente.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 58)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(151, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Sala Judicial - Distrito Judicial :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSalaJudicial
            '
            Me.txtSalaJudicial._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSalaJudicial._BloquearPaste = False
            Me.txtSalaJudicial._SeleccionarTodo = False
            Me.txtSalaJudicial.Location = New System.Drawing.Point(14, 78)
            Me.txtSalaJudicial.Name = "txtSalaJudicial"
            Me.txtSalaJudicial.Size = New System.Drawing.Size(362, 20)
            Me.txtSalaJudicial.TabIndex = 3
            Me.txtSalaJudicial.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSalaJudicial.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'frmCargarProceso
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(388, 148)
            Me.Controls.Add(Me.gbInimputable)
            Me.Controls.Add(Me.Panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCargarProceso"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Otros procesos pendientes"
            Me.Panel1.ResumeLayout(False)
            Me.gbInimputable.ResumeLayout(False)
            Me.gbInimputable.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents btnAceptar As Button
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnCancelar As Button
        Friend WithEvents gbInimputable As GroupBox
        Friend WithEvents Label1 As Label
        Friend WithEvents txtSalaJudicial As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As Label
        Friend WithEvents txtNumExpediente As Legolas.APPUIComponents.MyTextBox
    End Class
End Namespace