Namespace Estadistica

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportePopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.grbFiltro = New System.Windows.Forms.GroupBox()
            Me.grbNacionalidad = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbExtran = New System.Windows.Forms.RadioButton()
            Me.rdbPerua = New System.Windows.Forms.RadioButton()
            Me.grbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtRegion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.grbFiltro.SuspendLayout()
            Me.grbNacionalidad.SuspendLayout()
            Me.grbRegionPenal.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbFiltro)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(592, 396)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 351)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(592, 45)
            Me.Panel1.TabIndex = 102
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(390, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(202, 45)
            Me.Panel2.TabIndex = 103
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(103, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 98
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 97
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbFiltro
            '
            Me.grbFiltro.Controls.Add(Me.grbNacionalidad)
            Me.grbFiltro.Controls.Add(Me.grbRegionPenal)
            Me.grbFiltro.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbFiltro.Location = New System.Drawing.Point(315, 0)
            Me.grbFiltro.Name = "grbFiltro"
            Me.grbFiltro.Size = New System.Drawing.Size(277, 351)
            Me.grbFiltro.TabIndex = 103
            Me.grbFiltro.TabStop = False
            '
            'grbNacionalidad
            '
            Me.grbNacionalidad.Controls.Add(Me.rdbTodos)
            Me.grbNacionalidad.Controls.Add(Me.rdbExtran)
            Me.grbNacionalidad.Controls.Add(Me.rdbPerua)
            Me.grbNacionalidad.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbNacionalidad.Location = New System.Drawing.Point(3, 93)
            Me.grbNacionalidad.Name = "grbNacionalidad"
            Me.grbNacionalidad.Size = New System.Drawing.Size(271, 39)
            Me.grbNacionalidad.TabIndex = 9
            Me.grbNacionalidad.TabStop = False
            Me.grbNacionalidad.Text = "Nacionalidad"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(205, 14)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 61
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbExtran
            '
            Me.rdbExtran.AutoSize = True
            Me.rdbExtran.Location = New System.Drawing.Point(100, 14)
            Me.rdbExtran.Name = "rdbExtran"
            Me.rdbExtran.Size = New System.Drawing.Size(77, 17)
            Me.rdbExtran.TabIndex = 60
            Me.rdbExtran.Text = "Extranjeros"
            Me.rdbExtran.UseVisualStyleBackColor = True
            '
            'rdbPerua
            '
            Me.rdbPerua.AutoSize = True
            Me.rdbPerua.Checked = True
            Me.rdbPerua.Location = New System.Drawing.Point(7, 14)
            Me.rdbPerua.Name = "rdbPerua"
            Me.rdbPerua.Size = New System.Drawing.Size(70, 17)
            Me.rdbPerua.TabIndex = 59
            Me.rdbPerua.TabStop = True
            Me.rdbPerua.Text = "Peruanos"
            Me.rdbPerua.UseVisualStyleBackColor = True
            '
            'grbRegionPenal
            '
            Me.grbRegionPenal.Controls.Add(Me.txtRegion)
            Me.grbRegionPenal.Controls.Add(Me.txtPenal)
            Me.grbRegionPenal.Controls.Add(Me.Label11)
            Me.grbRegionPenal.Controls.Add(Me.Label28)
            Me.grbRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbRegionPenal.Location = New System.Drawing.Point(3, 16)
            Me.grbRegionPenal.Name = "grbRegionPenal"
            Me.grbRegionPenal.Size = New System.Drawing.Size(271, 77)
            Me.grbRegionPenal.TabIndex = 47
            Me.grbRegionPenal.TabStop = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(12, 50)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(40, 13)
            Me.Label11.TabIndex = 12
            Me.Label11.Text = "Penal :"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(12, 20)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(47, 13)
            Me.Label28.TabIndex = 44
            Me.Label28.Text = "Region :"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.dgwGrilla)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(315, 351)
            Me.GroupBox4.TabIndex = 104
            Me.GroupBox4.TabStop = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.ColumnHeadersVisible = False
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_reg_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 39)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(309, 309)
            Me.dgwGrilla.TabIndex = 4
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_reg_nom.DataPropertyName = "Nombre"
            Me.col_reg_nom.HeaderText = "Nombre"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Location = New System.Drawing.Point(3, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(309, 23)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Seleccione el tipo de Reporte..."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtRegion
            '
            Me.txtRegion._BloquearPaste = False
            Me.txtRegion._SeleccionarTodo = False
            Me.txtRegion.Location = New System.Drawing.Point(77, 17)
            Me.txtRegion.Name = "txtRegion"
            Me.txtRegion.ReadOnly = True
            Me.txtRegion.Size = New System.Drawing.Size(185, 20)
            Me.txtRegion.TabIndex = 61
            Me.txtRegion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtPenal
            '
            Me.txtPenal._BloquearPaste = False
            Me.txtPenal._SeleccionarTodo = False
            Me.txtPenal.Location = New System.Drawing.Point(77, 45)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.ReadOnly = True
            Me.txtPenal.Size = New System.Drawing.Size(185, 20)
            Me.txtPenal.TabIndex = 62
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'frmReportePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(592, 396)
            Me.Name = "frmReportePopup"
            Me.Text = "Reportes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.grbFiltro.ResumeLayout(False)
            Me.grbNacionalidad.ResumeLayout(False)
            Me.grbNacionalidad.PerformLayout()
            Me.grbRegionPenal.ResumeLayout(False)
            Me.grbRegionPenal.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
        Friend WithEvents grbNacionalidad As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents grbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExtran As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPerua As System.Windows.Forms.RadioButton
        Friend WithEvents txtRegion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox

    End Class
End Namespace