Namespace Registro.Expediente.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAgraviadoPopup3
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNombres = New System.Windows.Forms.TextBox()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(482, 217)
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtObservacion)
            Me.GroupBox4.Controls.Add(Me.Label10)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.txtNombres)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(482, 217)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            '
            'txtObservacion
            '
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = True
            Me.txtObservacion.Location = New System.Drawing.Point(81, 43)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(389, 87)
            Me.txtObservacion.TabIndex = 3
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(4, 43)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(70, 13)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Observación:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(4, 18)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Agraviado :"
            '
            'txtNombres
            '
            Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombres.Location = New System.Drawing.Point(81, 15)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(390, 20)
            Me.txtNombres.TabIndex = 1
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(380, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(102, 45)
            Me.pnlSalir.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(2, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 1
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(99, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(3, 3)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 130)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(482, 45)
            Me.Panel2.TabIndex = 1
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Controls.Add(Me.btnOK)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(180, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(200, 45)
            Me.pnlGrabarDatos.TabIndex = 1
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 175)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(482, 42)
            Me.UscAuditUser1.TabIndex = 2
            '
            'frmAgraviadoPopup3
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(482, 217)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmAgraviadoPopup3"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Agraviado(s)"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.pnlSalir.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNombres As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox

    End Class
End Namespace