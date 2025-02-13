Namespace Mantenimiento.Pabellon
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMantAleroPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantAleroPopup))
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.txtNombreAlero = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkInactivo = New System.Windows.Forms.RadioButton()
            Me.chkActivo = New System.Windows.Forms.RadioButton()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.txtNombreAlero)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Label3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(503, 149)
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 107)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(503, 42)
            Me.Panel2.TabIndex = 11
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnSalir)
            Me.pnlGrabarDatos.Controls.Add(Me.btnOK)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(306, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(195, 40)
            Me.pnlGrabarDatos.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
            Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.ForeColor = System.Drawing.Color.Black
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(106, 0)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(85, 40)
            Me.btnSalir.TabIndex = 67
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = False
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnOK.Location = New System.Drawing.Point(10, 0)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Grabar"
            Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'txtNombreAlero
            '
            Me.txtNombreAlero.BackColor = System.Drawing.Color.White
            Me.txtNombreAlero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreAlero.Location = New System.Drawing.Point(70, 21)
            Me.txtNombreAlero.MaxLength = 100
            Me.txtNombreAlero.Name = "txtNombreAlero"
            Me.txtNombreAlero.Size = New System.Drawing.Size(400, 20)
            Me.txtNombreAlero.TabIndex = 16
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkInactivo)
            Me.GroupBox1.Controls.Add(Me.chkActivo)
            Me.GroupBox1.Location = New System.Drawing.Point(70, 47)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(400, 47)
            Me.GroupBox1.TabIndex = 14
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Situación del alero"
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
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(17, 24)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(47, 13)
            Me.Label3.TabIndex = 15
            Me.Label3.Text = "Nombre:"
            '
            'frmMantAleroPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(503, 149)
            Me.Name = "frmMantAleroPopup"
            Me.Text = ".::. Mantenimiento alero"
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
        Friend WithEvents btnOK As Button
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents chkInactivo As RadioButton
        Friend WithEvents chkActivo As RadioButton
        Friend WithEvents txtNombreAlero As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents btnSalir As Button
    End Class
End Namespace