Namespace Visita


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportePopup
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.rdbOpcion3 = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbOpcion2 = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbOpcion1 = New Legolas.APPUIComponents.myRadioButton()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(492, 211)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.rdbOpcion3)
            Me.GroupBox1.Controls.Add(Me.rdbOpcion2)
            Me.GroupBox1.Controls.Add(Me.rdbOpcion1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(492, 160)
            Me.GroupBox1.TabIndex = 102
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Seleccione el Tipo de Reporte"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.UsrRegionPenal1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(486, 50)
            Me.GroupBox2.TabIndex = 59
            Me.GroupBox2.TabStop = False
            '
            'UsrRegionPenal1
            '
            Me.UsrRegionPenal1._LicenciaID = -1
            Me.UsrRegionPenal1._NivelUsuario = CType(-1, Short)
            Me.UsrRegionPenal1._PenalID = 0
            Me.UsrRegionPenal1._PenalTodos = True
            Me.UsrRegionPenal1._PerfilUsuario = CType(-1, Short)
            Me.UsrRegionPenal1._RegionID = 0
            Me.UsrRegionPenal1._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Usuario
            Me.UsrRegionPenal1._UsuarioID = -1
            Me.UsrRegionPenal1._WidthLabelRegion = 47
            Me.UsrRegionPenal1.BackColor = System.Drawing.Color.Transparent
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(10, 17)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(465, 22)
            Me.UsrRegionPenal1.TabIndex = 53
            Me.UsrRegionPenal1.WidthRegion = 224
            '
            'rdbOpcion3
            '
            Me.rdbOpcion3.AutoSize = True
            Me.rdbOpcion3.Location = New System.Drawing.Point(13, 118)
            Me.rdbOpcion3.Name = "rdbOpcion3"
            Me.rdbOpcion3.Size = New System.Drawing.Size(227, 17)
            Me.rdbOpcion3.TabIndex = 2
            Me.rdbOpcion3.Text = "Registro de Sanciones de Internos - Todos"
            Me.rdbOpcion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.rdbOpcion3.UseVisualStyleBackColor = True
            '
            'rdbOpcion2
            '
            Me.rdbOpcion2.AutoSize = True
            Me.rdbOpcion2.Location = New System.Drawing.Point(13, 95)
            Me.rdbOpcion2.Name = "rdbOpcion2"
            Me.rdbOpcion2.Size = New System.Drawing.Size(243, 17)
            Me.rdbOpcion2.TabIndex = 1
            Me.rdbOpcion2.Text = "Registro de Sanciones de Internos - Historicos"
            Me.rdbOpcion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.rdbOpcion2.UseVisualStyleBackColor = True
            '
            'rdbOpcion1
            '
            Me.rdbOpcion1.AutoSize = True
            Me.rdbOpcion1.Checked = True
            Me.rdbOpcion1.Location = New System.Drawing.Point(13, 72)
            Me.rdbOpcion1.Name = "rdbOpcion1"
            Me.rdbOpcion1.Size = New System.Drawing.Size(238, 17)
            Me.rdbOpcion1.TabIndex = 0
            Me.rdbOpcion1.TabStop = True
            Me.rdbOpcion1.Text = "Registro de Sanciones de Internos - Vigentes"
            Me.rdbOpcion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.rdbOpcion1.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 160)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(492, 51)
            Me.Panel1.TabIndex = 101
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(291, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(201, 51)
            Me.Panel2.TabIndex = 99
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 5)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 97
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(103, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 98
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmReportePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(492, 211)
            Me.Name = "frmReportePopup"
            Me.Text = "Reportes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbOpcion3 As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbOpcion2 As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbOpcion1 As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents Panel2 As Panel
    End Class
End Namespace