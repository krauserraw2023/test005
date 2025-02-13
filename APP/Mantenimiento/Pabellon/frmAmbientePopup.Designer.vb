Namespace Mantenimiento.Pabellon
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmAmbientePopup
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
            Me.txtAmbiente = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkInactivo = New System.Windows.Forms.RadioButton()
            Me.chkActivo = New System.Windows.Forms.RadioButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblPabellon = New System.Windows.Forms.Label()
            Me.lblPiso = New System.Windows.Forms.Label()
            Me.lblAlero = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.lblAlero)
            Me.gbxFormChildContainer.Controls.Add(Me.lblPiso)
            Me.gbxFormChildContainer.Controls.Add(Me.lblPabellon)
            Me.gbxFormChildContainer.Controls.Add(Me.Label4)
            Me.gbxFormChildContainer.Controls.Add(Me.Label3)
            Me.gbxFormChildContainer.Controls.Add(Me.txtAmbiente)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Label2)
            Me.gbxFormChildContainer.Controls.Add(Me.Label1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(527, 211)
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 169)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(527, 42)
            Me.Panel2.TabIndex = 11
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Controls.Add(Me.btnOK)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(330, 0)
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
            'txtAmbiente
            '
            Me.txtAmbiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAmbiente.Location = New System.Drawing.Point(113, 82)
            Me.txtAmbiente.MaxLength = 100
            Me.txtAmbiente.Name = "txtAmbiente"
            Me.txtAmbiente.Size = New System.Drawing.Size(400, 20)
            Me.txtAmbiente.TabIndex = 19
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkInactivo)
            Me.GroupBox1.Controls.Add(Me.chkActivo)
            Me.GroupBox1.Location = New System.Drawing.Point(114, 110)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(397, 47)
            Me.GroupBox1.TabIndex = 18
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Situación del ambiente"
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
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(14, 85)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 17
            Me.Label2.Text = "Nombre ambiente:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(56, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 13)
            Me.Label1.TabIndex = 16
            Me.Label1.Text = "Pabellón:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(77, 40)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(30, 13)
            Me.Label3.TabIndex = 20
            Me.Label3.Text = "Piso:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(73, 66)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(34, 13)
            Me.Label4.TabIndex = 21
            Me.Label4.Text = "Alero:"
            '
            'lblPabellon
            '
            Me.lblPabellon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblPabellon.Location = New System.Drawing.Point(113, 13)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(400, 20)
            Me.lblPabellon.TabIndex = 22
            Me.lblPabellon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblPiso
            '
            Me.lblPiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblPiso.Location = New System.Drawing.Point(113, 36)
            Me.lblPiso.Name = "lblPiso"
            Me.lblPiso.Size = New System.Drawing.Size(400, 20)
            Me.lblPiso.TabIndex = 23
            Me.lblPiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblAlero
            '
            Me.lblAlero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblAlero.Location = New System.Drawing.Point(113, 59)
            Me.lblAlero.Name = "lblAlero"
            Me.lblAlero.Size = New System.Drawing.Size(400, 20)
            Me.lblAlero.TabIndex = 24
            Me.lblAlero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmAmbientePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(527, 211)
            Me.Name = "frmAmbientePopup"
            Me.Text = ".::. Mantenimiento de ambiente"
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
        Friend WithEvents txtAmbiente As TextBox
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents chkInactivo As RadioButton
        Friend WithEvents chkActivo As RadioButton
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents lblAlero As Label
        Friend WithEvents lblPiso As Label
        Friend WithEvents lblPabellon As Label
    End Class
End Namespace