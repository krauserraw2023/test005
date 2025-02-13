Namespace Mantenimiento.Pabellon
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMantPisoPopup
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
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkInactivo = New System.Windows.Forms.RadioButton()
            Me.chkActivo = New System.Windows.Forms.RadioButton()
            Me.txtNombrePiso = New System.Windows.Forms.TextBox()
            Me.txtPabellon = New System.Windows.Forms.TextBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.txtPabellon)
            Me.gbxFormChildContainer.Controls.Add(Me.txtNombrePiso)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Label2)
            Me.gbxFormChildContainer.Controls.Add(Me.Label1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(503, 187)
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 145)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(503, 42)
            Me.Panel2.TabIndex = 10
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Controls.Add(Me.btnOK)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(306, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(195, 40)
            Me.pnlGrabarDatos.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(96, 0)
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
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnOK.Location = New System.Drawing.Point(2, 0)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Grabar"
            Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(36, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 13)
            Me.Label1.TabIndex = 11
            Me.Label1.Text = "Pabellón:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(18, 49)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(69, 13)
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "Nombre piso:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkInactivo)
            Me.GroupBox1.Controls.Add(Me.chkActivo)
            Me.GroupBox1.Location = New System.Drawing.Point(93, 76)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(400, 47)
            Me.GroupBox1.TabIndex = 13
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Situación del piso"
            '
            'chkInactivo
            '
            Me.chkInactivo.AutoSize = True
            Me.chkInactivo.Location = New System.Drawing.Point(169, 19)
            Me.chkInactivo.Name = "chkInactivo"
            Me.chkInactivo.Size = New System.Drawing.Size(126, 17)
            Me.chkInactivo.TabIndex = 1
            Me.chkInactivo.Text = "Inactivo (Inhabilitado)"
            Me.chkInactivo.UseVisualStyleBackColor = True
            '
            'chkActivo
            '
            Me.chkActivo.AutoSize = True
            Me.chkActivo.Checked = True
            Me.chkActivo.Location = New System.Drawing.Point(36, 19)
            Me.chkActivo.Name = "chkActivo"
            Me.chkActivo.Size = New System.Drawing.Size(111, 17)
            Me.chkActivo.TabIndex = 0
            Me.chkActivo.TabStop = True
            Me.chkActivo.Text = "Activo (Habilitado)"
            Me.chkActivo.UseVisualStyleBackColor = True
            '
            'txtNombrePiso
            '
            Me.txtNombrePiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombrePiso.Location = New System.Drawing.Point(93, 46)
            Me.txtNombrePiso.MaxLength = 100
            Me.txtNombrePiso.Name = "txtNombrePiso"
            Me.txtNombrePiso.Size = New System.Drawing.Size(400, 20)
            Me.txtNombrePiso.TabIndex = 14
            '
            'txtPabellon
            '
            Me.txtPabellon.Enabled = False
            Me.txtPabellon.Location = New System.Drawing.Point(93, 19)
            Me.txtPabellon.Name = "txtPabellon"
            Me.txtPabellon.Size = New System.Drawing.Size(400, 20)
            Me.txtPabellon.TabIndex = 15
            '
            'frmMantPisoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(503, 187)
            Me.Name = "frmMantPisoPopup"
            Me.Text = ".:: Mantenimiento de piso"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel2 As Panel
        Friend WithEvents pnlGrabarDatos As Panel
        Friend WithEvents btnCancel As Button
        Friend WithEvents btnOK As Button
        Friend WithEvents txtPabellon As TextBox
        Friend WithEvents txtNombrePiso As TextBox
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents chkInactivo As RadioButton
        Friend WithEvents chkActivo As RadioButton
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
    End Class
End Namespace