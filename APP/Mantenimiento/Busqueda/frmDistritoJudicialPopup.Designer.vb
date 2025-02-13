Namespace Mantenimiento.Busqueda


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmDistritoJudicialPopup
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDistritoJudicialPopup))
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbInactivo = New System.Windows.Forms.RadioButton()
            Me.rbHistorico = New System.Windows.Forms.RadioButton()
            Me.rbVigente = New System.Windows.Forms.RadioButton()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dis_jud_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(688, 337)
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.GroupBox2)
            Me.Panel3.Controls.Add(Me.Label11)
            Me.Panel3.Controls.Add(Me.txtNombre)
            Me.Panel3.Controls.Add(Me.grbBuscar)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(688, 84)
            Me.Panel3.TabIndex = 9
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rbTodos)
            Me.GroupBox2.Controls.Add(Me.rbInactivo)
            Me.GroupBox2.Controls.Add(Me.rbHistorico)
            Me.GroupBox2.Controls.Add(Me.rbVigente)
            Me.GroupBox2.Location = New System.Drawing.Point(15, 35)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(459, 40)
            Me.GroupBox2.TabIndex = 99
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Estado"
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Location = New System.Drawing.Point(379, 14)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rbTodos.TabIndex = 84
            Me.rbTodos.Text = "Todos"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'rbInactivo
            '
            Me.rbInactivo.AutoSize = True
            Me.rbInactivo.Location = New System.Drawing.Point(286, 14)
            Me.rbInactivo.Name = "rbInactivo"
            Me.rbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rbInactivo.TabIndex = 83
            Me.rbInactivo.Text = "Inactivo"
            Me.rbInactivo.UseVisualStyleBackColor = True
            '
            'rbHistorico
            '
            Me.rbHistorico.AutoSize = True
            Me.rbHistorico.Location = New System.Drawing.Point(190, 14)
            Me.rbHistorico.Name = "rbHistorico"
            Me.rbHistorico.Size = New System.Drawing.Size(66, 17)
            Me.rbHistorico.TabIndex = 82
            Me.rbHistorico.Text = "Historico"
            Me.rbHistorico.UseVisualStyleBackColor = True
            '
            'rbVigente
            '
            Me.rbVigente.AutoSize = True
            Me.rbVigente.Checked = True
            Me.rbVigente.Location = New System.Drawing.Point(109, 14)
            Me.rbVigente.Name = "rbVigente"
            Me.rbVigente.Size = New System.Drawing.Size(61, 17)
            Me.rbVigente.TabIndex = 0
            Me.rbVigente.TabStop = True
            Me.rbVigente.Text = "Vigente"
            Me.rbVigente.UseVisualStyleBackColor = True
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(12, 12)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(83, 13)
            Me.Label11.TabIndex = 87
            Me.Label11.Text = "Distrito Judicial :"
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(119, 9)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(355, 20)
            Me.txtNombre.TabIndex = 89
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(605, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 84)
            Me.grbBuscar.TabIndex = 63
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 59)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 65)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 287)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(688, 50)
            Me.Panel1.TabIndex = 8
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOK)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(484, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(204, 50)
            Me.Panel2.TabIndex = 6
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(104, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 97
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(4, 5)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 96
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_dis_jud_nom, Me.col_est, Me.col_est_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 84)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(688, 203)
            Me.dgwGrilla.TabIndex = 65
            Me.dgwGrilla.VisibleCampos = True
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_dis_jud_nom
            '
            Me.col_dis_jud_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_dis_jud_nom.DataPropertyName = "Nombre"
            Me.col_dis_jud_nom.HeaderText = "Distrito Judicial"
            Me.col_dis_jud_nom.Name = "col_dis_jud_nom"
            Me.col_dis_jud_nom.ReadOnly = True
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "estado"
            Me.col_est.HeaderText = "EstadoID"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "estadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 80
            '
            'frmDistritoJudicialPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(688, 337)
            Me.Name = "frmDistritoJudicialPopup"
            Me.Text = "Busqueda de Distrito Judicial"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents rbTodos As RadioButton
        Friend WithEvents rbInactivo As RadioButton
        Friend WithEvents rbHistorico As RadioButton
        Friend WithEvents rbVigente As RadioButton
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_dis_jud_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_est As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
    End Class

End Namespace