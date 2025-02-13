Namespace Mantenimiento.Busqueda


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDelitoPopup
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelitoPopup))
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_del_art_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_gen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tit_del = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_gen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cap_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cap_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cap = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_sec_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_sec_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_esp_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.cbbTipo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.rdbArticulo = New System.Windows.Forms.RadioButton()
            Me.rdbDescripcion = New System.Windows.Forms.RadioButton()
            Me.txtBuscar = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(750, 337)
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_del_art_nom, Me.col_del_esp_id, Me.col_del_esp_nom, Me.col_del_gen_id, Me.col_tit_del, Me.col_del_gen_nom, Me.col_tip_del_id, Me.col_exp_id, Me.col_del_est, Me.col_cap_num, Me.col_cap_nom, Me.col_cap, Me.col_del_sec_num, Me.col_del_sec_nom, Me.col_sec, Me.col_par_cod, Me.col_esp_est_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 69)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(750, 218)
            Me.dgwGrilla.TabIndex = 1
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_del_art_nom
            '
            Me.col_del_art_nom.DataPropertyName = "DelitoArticulo"
            Me.col_del_art_nom.HeaderText = "Artículo"
            Me.col_del_art_nom.Name = "col_del_art_nom"
            Me.col_del_art_nom.ReadOnly = True
            Me.col_del_art_nom.Width = 45
            '
            'col_del_esp_id
            '
            Me.col_del_esp_id.DataPropertyName = "DelitoEspecificoID"
            Me.col_del_esp_id.HeaderText = "DelitoEspecificoID"
            Me.col_del_esp_id.Name = "col_del_esp_id"
            Me.col_del_esp_id.ReadOnly = True
            Me.col_del_esp_id.Visible = False
            Me.col_del_esp_id.Width = 35
            '
            'col_del_esp_nom
            '
            Me.col_del_esp_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
            Me.col_del_esp_nom.HeaderText = "Delito Especifico"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            Me.col_del_esp_nom.Width = 250
            '
            'col_del_gen_id
            '
            Me.col_del_gen_id.DataPropertyName = "DelitoGenericoID"
            Me.col_del_gen_id.HeaderText = "DelitoGenericoID"
            Me.col_del_gen_id.Name = "col_del_gen_id"
            Me.col_del_gen_id.ReadOnly = True
            Me.col_del_gen_id.Visible = False
            Me.col_del_gen_id.Width = 35
            '
            'col_tit_del
            '
            Me.col_tit_del.DataPropertyName = "Titulo"
            Me.col_tit_del.HeaderText = "Titulo"
            Me.col_tit_del.Name = "col_tit_del"
            Me.col_tit_del.ReadOnly = True
            Me.col_tit_del.Width = 150
            '
            'col_del_gen_nom
            '
            Me.col_del_gen_nom.DataPropertyName = "DelitoGenericoNombre"
            Me.col_del_gen_nom.HeaderText = "Delito Generico"
            Me.col_del_gen_nom.Name = "col_del_gen_nom"
            Me.col_del_gen_nom.ReadOnly = True
            Me.col_del_gen_nom.Visible = False
            Me.col_del_gen_nom.Width = 150
            '
            'col_tip_del_id
            '
            Me.col_tip_del_id.DataPropertyName = "DelitoTipoID"
            Me.col_tip_del_id.HeaderText = "TipoID"
            Me.col_tip_del_id.Name = "col_tip_del_id"
            Me.col_tip_del_id.ReadOnly = True
            Me.col_tip_del_id.Visible = False
            '
            'col_exp_id
            '
            Me.col_exp_id.DataPropertyName = "DelitoTipoNombre"
            Me.col_exp_id.HeaderText = "Tipo"
            Me.col_exp_id.Name = "col_exp_id"
            Me.col_exp_id.ReadOnly = True
            Me.col_exp_id.Visible = False
            Me.col_exp_id.Width = 60
            '
            'col_del_est
            '
            Me.col_del_est.DataPropertyName = "DelitoEspecificoEstado"
            Me.col_del_est.HeaderText = "DelitoEspecificoEstado"
            Me.col_del_est.Name = "col_del_est"
            Me.col_del_est.ReadOnly = True
            Me.col_del_est.Visible = False
            '
            'col_cap_num
            '
            Me.col_cap_num.DataPropertyName = "DelitoCapituloNro"
            Me.col_cap_num.HeaderText = "Capitulo Numero"
            Me.col_cap_num.Name = "col_cap_num"
            Me.col_cap_num.ReadOnly = True
            Me.col_cap_num.Visible = False
            Me.col_cap_num.Width = 50
            '
            'col_cap_nom
            '
            Me.col_cap_nom.DataPropertyName = "DelitoCapituloNombre"
            Me.col_cap_nom.HeaderText = "Capitulo Nombre"
            Me.col_cap_nom.Name = "col_cap_nom"
            Me.col_cap_nom.ReadOnly = True
            Me.col_cap_nom.Visible = False
            Me.col_cap_nom.Width = 50
            '
            'col_cap
            '
            Me.col_cap.DataPropertyName = "Capitulo"
            Me.col_cap.HeaderText = "Capítulo"
            Me.col_cap.Name = "col_cap"
            Me.col_cap.ReadOnly = True
            '
            'col_del_sec_num
            '
            Me.col_del_sec_num.DataPropertyName = "DelitoSeccionNumero"
            Me.col_del_sec_num.HeaderText = "Seccion Nro"
            Me.col_del_sec_num.Name = "col_del_sec_num"
            Me.col_del_sec_num.ReadOnly = True
            Me.col_del_sec_num.Visible = False
            Me.col_del_sec_num.Width = 50
            '
            'col_del_sec_nom
            '
            Me.col_del_sec_nom.DataPropertyName = "DelitoSeccionNombre"
            Me.col_del_sec_nom.HeaderText = "Seccion Nombre"
            Me.col_del_sec_nom.Name = "col_del_sec_nom"
            Me.col_del_sec_nom.ReadOnly = True
            Me.col_del_sec_nom.Visible = False
            Me.col_del_sec_nom.Width = 50
            '
            'col_sec
            '
            Me.col_sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_sec.DataPropertyName = "Seccion"
            Me.col_sec.HeaderText = "Sección"
            Me.col_sec.Name = "col_sec"
            Me.col_sec.ReadOnly = True
            '
            'col_par_cod
            '
            Me.col_par_cod.DataPropertyName = "DelitoCodigoSB"
            Me.col_par_cod.HeaderText = "ParCodigo"
            Me.col_par_cod.Name = "col_par_cod"
            Me.col_par_cod.ReadOnly = True
            Me.col_par_cod.Visible = False
            '
            'col_esp_est_nom
            '
            Me.col_esp_est_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_esp_est_nom.DataPropertyName = "EstadoEspecificoNombre"
            Me.col_esp_est_nom.HeaderText = "Estado"
            Me.col_esp_est_nom.Name = "col_esp_est_nom"
            Me.col_esp_est_nom.ReadOnly = True
            Me.col_esp_est_nom.Width = 55
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblReg)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 287)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(750, 50)
            Me.Panel1.TabIndex = 2
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblReg.Location = New System.Drawing.Point(0, 0)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 50)
            Me.lblReg.TabIndex = 0
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOK)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(546, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(204, 50)
            Me.Panel2.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(104, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 1
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
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.cbbTipo)
            Me.Panel3.Controls.Add(Me.rdbArticulo)
            Me.Panel3.Controls.Add(Me.rdbDescripcion)
            Me.Panel3.Controls.Add(Me.txtBuscar)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Controls.Add(Me.grbBuscar)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(750, 69)
            Me.Panel3.TabIndex = 0
            '
            'cbbTipo
            '
            Me.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipo.FormattingEnabled = True
            Me.cbbTipo.Location = New System.Drawing.Point(80, 22)
            Me.cbbTipo.Name = "cbbTipo"
            Me.cbbTipo.Size = New System.Drawing.Size(209, 21)
            Me.cbbTipo.TabIndex = 1
            '
            'rdbArticulo
            '
            Me.rdbArticulo.AutoSize = True
            Me.rdbArticulo.Location = New System.Drawing.Point(305, 32)
            Me.rdbArticulo.Name = "rdbArticulo"
            Me.rdbArticulo.Size = New System.Drawing.Size(75, 17)
            Me.rdbArticulo.TabIndex = 3
            Me.rdbArticulo.Text = "N° Articulo"
            Me.rdbArticulo.UseVisualStyleBackColor = True
            '
            'rdbDescripcion
            '
            Me.rdbDescripcion.AutoSize = True
            Me.rdbDescripcion.Checked = True
            Me.rdbDescripcion.Location = New System.Drawing.Point(305, 11)
            Me.rdbDescripcion.Name = "rdbDescripcion"
            Me.rdbDescripcion.Size = New System.Drawing.Size(81, 17)
            Me.rdbDescripcion.TabIndex = 2
            Me.rdbDescripcion.TabStop = True
            Me.rdbDescripcion.Text = "Descripción"
            Me.rdbDescripcion.UseVisualStyleBackColor = True
            '
            'txtBuscar
            '
            Me.txtBuscar._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtBuscar._BloquearPaste = False
            Me.txtBuscar._SeleccionarTodo = False
            Me.txtBuscar.ForeColor = System.Drawing.Color.Gray
            Me.txtBuscar.Location = New System.Drawing.Point(389, 21)
            Me.txtBuscar.Name = "txtBuscar"
            Me.txtBuscar.Size = New System.Drawing.Size(271, 20)
            Me.txtBuscar.TabIndex = 4
            Me.txtBuscar.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtBuscar.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(8, 26)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Tipo Delito :"
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(667, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 69)
            Me.grbBuscar.TabIndex = 5
            Me.grbBuscar.TabStop = False
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 50)
            Me.ToolStrip1.TabIndex = 0
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
            Me.tsbBuscar.ToolTipText = "INGRESE EL DELITO ESPECIFICO / ARTICULO"
            '
            'frmDelitoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(750, 337)
            Me.Name = "frmDelitoPopup"
            Me.Text = "Busqueda de Delitos"
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents txtBuscar As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents rdbArticulo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbDescripcion As System.Windows.Forms.RadioButton
        Friend WithEvents cbbTipo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents col_del_art_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_gen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tit_del As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_gen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_del_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_est As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cap_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cap_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cap As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_sec_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_sec_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sec As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_esp_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class

End Namespace