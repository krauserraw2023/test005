Namespace Registro.Siscrico

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBusquedaBanda
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaBanda))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbbBandaTipo = New APPControls.uscComboParametrica()
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ban_tip_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.cbbBandaTipo.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(547, 446)
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.grbBusqueda)
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(547, 103)
            Me.Panel1.TabIndex = 85
            '
            'grbBusqueda
            '
            Me.grbBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.grbBusqueda.Controls.Add(Me.Label3)
            Me.grbBusqueda.Controls.Add(Me.cbbBandaTipo)
            Me.grbBusqueda.Controls.Add(Me.Label11)
            Me.grbBusqueda.Controls.Add(Me.txtNom)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Size = New System.Drawing.Size(457, 103)
            Me.grbBusqueda.TabIndex = 38
            Me.grbBusqueda.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 58)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombre :"
            '
            'cbbBandaTipo
            '
            Me.cbbBandaTipo._NoIndica = False
            Me.cbbBandaTipo._Todos = False
            Me.cbbBandaTipo._TodosMensaje = ""
            Me.cbbBandaTipo._Visible_Add = False
            Me.cbbBandaTipo._Visible_Buscar = False
            Me.cbbBandaTipo._Visible_Eliminar = False
            Me.cbbBandaTipo.CodigoPadre = -1
            Me.cbbBandaTipo.ComboTipo = Type.Combo.ComboTipo.BandaTipo
            Me.cbbBandaTipo.Controls.Add(Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b)
            Me.cbbBandaTipo.Controls.Add(Me.object_ec9230cf_3586_407a_93d2_6d65901e7650)
            Me.cbbBandaTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBandaTipo.DropDownWidth = 222
            Me.cbbBandaTipo.DropDownWidthAuto = False
            Me.cbbBandaTipo.Location = New System.Drawing.Point(69, 27)
            Me.cbbBandaTipo.Name = "cbbBandaTipo"
            Me.cbbBandaTipo.Parametro1 = -1
            Me.cbbBandaTipo.Parametro2 = -1
            Me.cbbBandaTipo.SelectedIndex = -1
            Me.cbbBandaTipo.SelectedValue = 0
            Me.cbbBandaTipo.Size = New System.Drawing.Size(375, 22)
            Me.cbbBandaTipo.TabIndex = 77
            '
            'object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b
            '
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.DropDownWidth = 222
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.FormattingEnabled = True
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.Location = New System.Drawing.Point(0, 0)
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.Name = "object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b"
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.Size = New System.Drawing.Size(375, 21)
            Me.object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b.TabIndex = 2
            '
            'object_ec9230cf_3586_407a_93d2_6d65901e7650
            '
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.DropDownWidth = 222
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.FormattingEnabled = True
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Location = New System.Drawing.Point(0, 0)
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Name = "object_ec9230cf_3586_407a_93d2_6d65901e7650"
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Size = New System.Drawing.Size(375, 21)
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.TabIndex = 2
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(10, 30)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(28, 13)
            Me.Label11.TabIndex = 76
            Me.Label11.Text = "Tipo"
            '
            'txtNom
            '
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(70, 55)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(374, 20)
            Me.txtNom.TabIndex = 80
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'grbBuscar
            '
            Me.grbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(457, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(90, 103)
            Me.grbBuscar.TabIndex = 80
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 81)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(84, 19)
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
            Me.ToolStrip1.Size = New System.Drawing.Size(84, 84)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(82, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_ban_tip_id, Me.colTipo, Me.colNombre})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 103)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(547, 292)
            Me.dgwGrilla.TabIndex = 88
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
            'col_ban_tip_id
            '
            Me.col_ban_tip_id.DataPropertyName = "BandaTipoID"
            Me.col_ban_tip_id.HeaderText = "BandaTipoID"
            Me.col_ban_tip_id.Name = "col_ban_tip_id"
            Me.col_ban_tip_id.ReadOnly = True
            Me.col_ban_tip_id.Visible = False
            '
            'colTipo
            '
            Me.colTipo.DataPropertyName = "BandaTipoNombre"
            Me.colTipo.HeaderText = "Tipo Organización"
            Me.colTipo.Name = "colTipo"
            Me.colTipo.ReadOnly = True
            Me.colTipo.Width = 150
            '
            'colNombre
            '
            Me.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.colNombre.DataPropertyName = "BandaNombre"
            Me.colNombre.HeaderText = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.ReadOnly = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnAceptar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 395)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(547, 51)
            Me.Panel2.TabIndex = 89
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(434, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 43)
            Me.btnCancel.TabIndex = 104
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(325, 4)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(105, 43)
            Me.btnAceptar.TabIndex = 103
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmBusquedaBanda
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(547, 446)
            Me.Name = "frmBusquedaBanda"
            Me.Text = ".::. Buscar organización criminal .::."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            Me.cbbBandaTipo.ResumeLayout(False)
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbbBandaTipo As APPControls.uscComboParametrica
        Friend WithEvents object_275fd4a6_20bf_49cd_814a_610b6b3c8a2b As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents object_ec9230cf_3586_407a_93d2_6d65901e7650 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ban_tip_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class

End Namespace