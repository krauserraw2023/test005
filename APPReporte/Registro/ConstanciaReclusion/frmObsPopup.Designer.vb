Namespace Registro.ConstanciaReclusion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmObsPopup
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.grbAnulacion = New System.Windows.Forms.GroupBox()
            Me.txtObsAnu = New System.Windows.Forms.TextBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbAnulacion.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbAnulacion)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(472, 181)
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.Panel1)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 127)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(472, 54)
            Me.PnlBotones.TabIndex = 39
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(255, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(217, 54)
            Me.Panel1.TabIndex = 69
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.APPReporte.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(8, 5)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(94, 40)
            Me.btnAceptar.TabIndex = 30
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPReporte.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(108, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 31
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbAnulacion
            '
            Me.grbAnulacion.Controls.Add(Me.txtObsAnu)
            Me.grbAnulacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbAnulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAnulacion.Location = New System.Drawing.Point(0, 0)
            Me.grbAnulacion.Name = "grbAnulacion"
            Me.grbAnulacion.Size = New System.Drawing.Size(472, 127)
            Me.grbAnulacion.TabIndex = 45
            Me.grbAnulacion.TabStop = False
            '
            'txtObsAnu
            '
            Me.txtObsAnu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObsAnu.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsAnu.Location = New System.Drawing.Point(3, 16)
            Me.txtObsAnu.MaxLength = 250
            Me.txtObsAnu.Multiline = True
            Me.txtObsAnu.Name = "txtObsAnu"
            Me.txtObsAnu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsAnu.Size = New System.Drawing.Size(466, 108)
            Me.txtObsAnu.TabIndex = 115
            '
            'frmObsPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(472, 181)
            Me.Name = "frmObsPopup"
            Me.Text = "Ingrese el motivo de reimpresion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grbAnulacion.ResumeLayout(False)
            Me.grbAnulacion.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents PnlBotones As Panel
        Friend WithEvents grbAnulacion As GroupBox
        Friend WithEvents txtObsAnu As TextBox
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnAceptar As Button
        Friend WithEvents btnCancel As Button
    End Class

End Namespace
