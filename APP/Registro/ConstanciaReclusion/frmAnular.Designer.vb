Namespace Registro.ConstanciaReclusion

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmAnular
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
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.txtObservacionAnulado = New System.Windows.Forms.TextBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.txtObservacionAnulado)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(395, 171)
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 171)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(395, 47)
            Me.PnlBotones.TabIndex = 4
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(196, 4)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(93, 40)
            Me.btnAceptar.TabIndex = 1
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(295, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'txtObservacionAnulado
            '
            Me.txtObservacionAnulado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionAnulado.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacionAnulado.Location = New System.Drawing.Point(0, 0)
            Me.txtObservacionAnulado.MaxLength = 500
            Me.txtObservacionAnulado.Multiline = True
            Me.txtObservacionAnulado.Name = "txtObservacionAnulado"
            Me.txtObservacionAnulado.Size = New System.Drawing.Size(395, 171)
            Me.txtObservacionAnulado.TabIndex = 0
            '
            'frmAnular
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(395, 218)
            Me.Controls.Add(Me.PnlBotones)
            Me.Name = "frmAnular"
            Me.Text = "Motivo de Anulación"
            Me.Controls.SetChildIndex(Me.PnlBotones, 0)
            Me.Controls.SetChildIndex(Me.gbxFormChildContainer, 0)
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.PnlBotones.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents PnlBotones As Panel
        Friend WithEvents btnAceptar As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents txtObservacionAnulado As TextBox
    End Class
End Namespace
