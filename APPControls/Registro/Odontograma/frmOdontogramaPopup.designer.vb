Namespace Registro.Odontograma
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmOdontogramaPopup
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
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlObsEsp = New System.Windows.Forms.Panel()
            Me.grbObsEsp = New System.Windows.Forms.GroupBox()
            Me.pnlEspe = New System.Windows.Forms.Panel()
            Me.txtEspecific = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.txtObs = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.pnlOdontograma = New System.Windows.Forms.Panel()
            'Me.UscOdontograma1 = New MiOdontograma.uscOdontograma()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlObsEsp.SuspendLayout()
            Me.grbObsEsp.SuspendLayout()
            Me.pnlEspe.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.pnlOdontograma.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlOdontograma)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlObsEsp)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(1042, 691)
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscAuditUser1)
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 644)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1042, 47)
            Me.Panel2.TabIndex = 4
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnOk)
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(741, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(198, 47)
            Me.pnlGrabarDatos.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(99, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(939, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(103, 47)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.APPControls.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(3, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlObsEsp
            '
            Me.pnlObsEsp.BackColor = System.Drawing.Color.Transparent
            Me.pnlObsEsp.Controls.Add(Me.grbObsEsp)
            Me.pnlObsEsp.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlObsEsp.Location = New System.Drawing.Point(666, 0)
            Me.pnlObsEsp.Name = "pnlObsEsp"
            Me.pnlObsEsp.Size = New System.Drawing.Size(376, 644)
            Me.pnlObsEsp.TabIndex = 7
            '
            'grbObsEsp
            '
            Me.grbObsEsp.Controls.Add(Me.pnlEspe)
            Me.grbObsEsp.Controls.Add(Me.pnlObs)
            Me.grbObsEsp.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbObsEsp.Location = New System.Drawing.Point(0, 0)
            Me.grbObsEsp.Name = "grbObsEsp"
            Me.grbObsEsp.Size = New System.Drawing.Size(376, 644)
            Me.grbObsEsp.TabIndex = 9
            Me.grbObsEsp.TabStop = False
            Me.grbObsEsp.Text = "Observaciones/Especificaciones"
            '
            'pnlEspe
            '
            Me.pnlEspe.Controls.Add(Me.txtEspecific)
            Me.pnlEspe.Controls.Add(Me.Label7)
            Me.pnlEspe.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlEspe.Location = New System.Drawing.Point(3, 160)
            Me.pnlEspe.Name = "pnlEspe"
            Me.pnlEspe.Size = New System.Drawing.Size(370, 149)
            Me.pnlEspe.TabIndex = 16
            '
            'txtEspecific
            '
            Me.txtEspecific.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtEspecific.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtEspecific.Location = New System.Drawing.Point(0, 20)
            Me.txtEspecific.MaxLength = 1000
            Me.txtEspecific.Multiline = True
            Me.txtEspecific.Name = "txtEspecific"
            Me.txtEspecific.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtEspecific.Size = New System.Drawing.Size(370, 129)
            Me.txtEspecific.TabIndex = 1
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label7.Location = New System.Drawing.Point(0, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(370, 20)
            Me.Label7.TabIndex = 15
            Me.Label7.Text = "Especificaciones:"
            '
            'pnlObs
            '
            Me.pnlObs.Controls.Add(Me.txtObs)
            Me.pnlObs.Controls.Add(Me.Label8)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlObs.Location = New System.Drawing.Point(3, 16)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(370, 144)
            Me.pnlObs.TabIndex = 10
            '
            'txtObs
            '
            Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObs.Location = New System.Drawing.Point(0, 20)
            Me.txtObs.MaxLength = 1000
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(370, 124)
            Me.txtObs.TabIndex = 0
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.Location = New System.Drawing.Point(0, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(370, 20)
            Me.Label8.TabIndex = 14
            Me.Label8.Text = "Observaciones:"
            '
            'pnlOdontograma
            '
            ' Me.pnlOdontograma.Controls.Add(Me.UscOdontograma1)
            Me.pnlOdontograma.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlOdontograma.Location = New System.Drawing.Point(0, 0)
            Me.pnlOdontograma.Name = "pnlOdontograma"
            Me.pnlOdontograma.Size = New System.Drawing.Size(666, 644)
            Me.pnlOdontograma.TabIndex = 8
            '
            'UscOdontograma1
            '
            'Me.UscOdontograma1._visiblePanelBotones = True
            'Me.UscOdontograma1.BackColor = System.Drawing.Color.White
            'Me.UscOdontograma1.Dock = System.Windows.Forms.DockStyle.Fill
            'Me.UscOdontograma1.Location = New System.Drawing.Point(0, 0)
            'Me.UscOdontograma1.Name = "UscOdontograma1"
            'Me.UscOdontograma1.Size = New System.Drawing.Size(666, 650)
            'Me.UscOdontograma1.TabIndex = 8
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 5)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(741, 42)
            Me.UscAuditUser1.TabIndex = 6
            '
            'frmOdontogramaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1042, 691)
            Me.Name = "frmOdontogramaPopup"
            Me.Text = "Odontograma del Interno"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlObsEsp.ResumeLayout(False)
            Me.grbObsEsp.ResumeLayout(False)
            Me.pnlEspe.ResumeLayout(False)
            Me.pnlEspe.PerformLayout()
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.pnlOdontograma.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlObsEsp As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents grbObsEsp As System.Windows.Forms.GroupBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtEspecific As System.Windows.Forms.TextBox
        Friend WithEvents txtObs As System.Windows.Forms.TextBox
        Friend WithEvents pnlEspe As Panel
        Friend WithEvents pnlObs As Panel
        Friend WithEvents pnlOdontograma As Panel
        'Friend WithEvents UscOdontograma1 As MiOdontograma.uscOdontograma
    End Class
End Namespace