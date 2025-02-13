Namespace Mantenimiento.Registro.Delito

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscar_v2
        Inherits Legolas.APPUIComponents.Form

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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar_v2))
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_del_art_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_gen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tit_del = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cap = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_gru_generico = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_gru_generico = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_gru_especifico = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_esp_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbbDelitoGenerico = New APPControls.uscComboParametrica()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbEstado = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtDelitoEspecifico = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtArticulo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtGrupoGenerico = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtGrupoEspecifico = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_del_art_nom, Me.col_del_esp_id, Me.col_del_esp_nom, Me.col_tip_del_id, Me.col_exp_id, Me.col_del_gen_id, Me.col_tit_del, Me.col_cap, Me.col_sec, Me.col_del_esp_est, Me.col_cud_id, Me.col_cod_gru_generico, Me.col_gru_generico, Me.col_gru_especifico, Me.col_esp_est_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 153)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1246, 279)
            Me.dgwGrilla.TabIndex = 1
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_del_art_nom
            '
            Me.col_del_art_nom.DataPropertyName = "DelitoArticulo"
            Me.col_del_art_nom.HeaderText = "Articulo"
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
            Me.col_del_esp_nom.Width = 450
            '
            'col_tip_del_id
            '
            Me.col_tip_del_id.DataPropertyName = "DelitoTipoID"
            Me.col_tip_del_id.DividerWidth = 1
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
            Me.col_exp_id.Width = 150
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
            Me.col_tit_del.HeaderText = "Titulo/Generico"
            Me.col_tit_del.Name = "col_tit_del"
            Me.col_tit_del.ReadOnly = True
            Me.col_tit_del.Width = 200
            '
            'col_cap
            '
            Me.col_cap.DataPropertyName = "Capitulo"
            Me.col_cap.HeaderText = "Capitulo"
            Me.col_cap.Name = "col_cap"
            Me.col_cap.ReadOnly = True
            '
            'col_sec
            '
            Me.col_sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_sec.DataPropertyName = "Seccion"
            Me.col_sec.HeaderText = "Seccion"
            Me.col_sec.Name = "col_sec"
            Me.col_sec.ReadOnly = True
            '
            'col_del_esp_est
            '
            Me.col_del_esp_est.DataPropertyName = "DelitoEspecificoEstado"
            Me.col_del_esp_est.DividerWidth = 1
            Me.col_del_esp_est.HeaderText = "DelitoEspecificoEstado"
            Me.col_del_esp_est.Name = "col_del_esp_est"
            Me.col_del_esp_est.ReadOnly = True
            Me.col_del_esp_est.Visible = False
            '
            'col_cud_id
            '
            Me.col_cud_id.DataPropertyName = "DelitoCuadroGrupoId"
            Me.col_cud_id.DividerWidth = 1
            Me.col_cud_id.HeaderText = "CuadroDelitoId"
            Me.col_cud_id.Name = "col_cud_id"
            Me.col_cud_id.ReadOnly = True
            Me.col_cud_id.Visible = False
            '
            'col_cod_gru_generico
            '
            Me.col_cod_gru_generico.DataPropertyName = "DelitoGrupoGenericoId"
            Me.col_cod_gru_generico.DividerWidth = 1
            Me.col_cod_gru_generico.HeaderText = "GrupoGenericoId"
            Me.col_cod_gru_generico.Name = "col_cod_gru_generico"
            Me.col_cod_gru_generico.ReadOnly = True
            Me.col_cod_gru_generico.Visible = False
            '
            'col_gru_generico
            '
            Me.col_gru_generico.DataPropertyName = "DelitoGrupoGenericoNombre"
            Me.col_gru_generico.HeaderText = "Grupo Generico"
            Me.col_gru_generico.Name = "col_gru_generico"
            Me.col_gru_generico.ReadOnly = True
            Me.col_gru_generico.Visible = False
            Me.col_gru_generico.Width = 200
            '
            'col_gru_especifico
            '
            Me.col_gru_especifico.DataPropertyName = "GrupoDelitoGenericoEspecifico"
            Me.col_gru_especifico.HeaderText = "Grupo Generico/Especifico"
            Me.col_gru_especifico.Name = "col_gru_especifico"
            Me.col_gru_especifico.ReadOnly = True
            Me.col_gru_especifico.Width = 300
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
            'Panel3
            '
            Me.Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Panel3.Controls.Add(Me.GroupBox2)
            Me.Panel3.Controls.Add(Me.GroupBox1)
            Me.Panel3.Controls.Add(Me.grbBuscar)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(1246, 153)
            Me.Panel3.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.cbbDelitoGenerico)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.cbbEstado)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtDelitoEspecifico)
            Me.GroupBox2.Controls.Add(Me.txtArticulo)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1163, 112)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            '
            'cbbDelitoGenerico
            '
            Me.cbbDelitoGenerico._NoIndica = False
            Me.cbbDelitoGenerico._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbDelitoGenerico._Todos = False
            Me.cbbDelitoGenerico._TodosMensaje = "[Todos]"
            Me.cbbDelitoGenerico._Visible_Add = False
            Me.cbbDelitoGenerico._Visible_Buscar = False
            Me.cbbDelitoGenerico._Visible_Eliminar = False
            Me.cbbDelitoGenerico.CodigoPadre = -1
            Me.cbbDelitoGenerico.ComboTipo = CType(12, Short)
            Me.cbbDelitoGenerico.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDelitoGenerico.DropDownWidth = 209
            Me.cbbDelitoGenerico.DropDownWidthAuto = True
            Me.cbbDelitoGenerico.ListaIdsParaExcluir = Nothing
            Me.cbbDelitoGenerico.Location = New System.Drawing.Point(148, 13)
            Me.cbbDelitoGenerico.ModuloTratamiento = False
            Me.cbbDelitoGenerico.Name = "cbbDelitoGenerico"
            Me.cbbDelitoGenerico.Parametro1 = -1
            Me.cbbDelitoGenerico.Parametro2 = -1
            Me.cbbDelitoGenerico.SelectedIndex = -1
            Me.cbbDelitoGenerico.SelectedValue = 0
            Me.cbbDelitoGenerico.Size = New System.Drawing.Size(378, 22)
            Me.cbbDelitoGenerico.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(50, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(86, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Delito Generico :"
            '
            'cbbEstado
            '
            Me.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEstado.FormattingEnabled = True
            Me.cbbEstado.Location = New System.Drawing.Point(148, 88)
            Me.cbbEstado.Name = "cbbEstado"
            Me.cbbEstado.Size = New System.Drawing.Size(122, 21)
            Me.cbbEstado.TabIndex = 7
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(50, 68)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Delito Especifico :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(50, 93)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(46, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Estado :"
            '
            'txtDelitoEspecifico
            '
            Me.txtDelitoEspecifico._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelitoEspecifico._BloquearPaste = False
            Me.txtDelitoEspecifico._SeleccionarTodo = False
            Me.txtDelitoEspecifico.Location = New System.Drawing.Point(148, 63)
            Me.txtDelitoEspecifico.Name = "txtDelitoEspecifico"
            Me.txtDelitoEspecifico.Size = New System.Drawing.Size(378, 20)
            Me.txtDelitoEspecifico.TabIndex = 5
            Me.txtDelitoEspecifico.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelitoEspecifico.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtArticulo
            '
            Me.txtArticulo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtArticulo._BloquearPaste = False
            Me.txtArticulo._SeleccionarTodo = False
            Me.txtArticulo.Location = New System.Drawing.Point(148, 38)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(122, 20)
            Me.txtArticulo.TabIndex = 3
            Me.txtArticulo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtArticulo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(50, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(48, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Articulo :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtGrupoGenerico)
            Me.GroupBox1.Controls.Add(Me.txtGrupoEspecifico)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox1.Location = New System.Drawing.Point(0, 112)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1163, 41)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Grupo Delito"
            '
            'txtGrupoGenerico
            '
            Me.txtGrupoGenerico._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtGrupoGenerico._BloquearPaste = False
            Me.txtGrupoGenerico._SeleccionarTodo = False
            Me.txtGrupoGenerico.Location = New System.Drawing.Point(148, 13)
            Me.txtGrupoGenerico.Name = "txtGrupoGenerico"
            Me.txtGrupoGenerico.Size = New System.Drawing.Size(378, 20)
            Me.txtGrupoGenerico.TabIndex = 1
            Me.txtGrupoGenerico.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGrupoGenerico.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtGrupoEspecifico
            '
            Me.txtGrupoEspecifico._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtGrupoEspecifico._BloquearPaste = False
            Me.txtGrupoEspecifico._SeleccionarTodo = False
            Me.txtGrupoEspecifico.Location = New System.Drawing.Point(635, 13)
            Me.txtGrupoEspecifico.Name = "txtGrupoEspecifico"
            Me.txtGrupoEspecifico.Size = New System.Drawing.Size(378, 20)
            Me.txtGrupoEspecifico.TabIndex = 3
            Me.txtGrupoEspecifico.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGrupoEspecifico.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(537, 18)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(94, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Grupo Especifico :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(50, 18)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(88, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Grupo Generico :"
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(1163, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 153)
            Me.grbBuscar.TabIndex = 2
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 128)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 1
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
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbLimpiar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 134)
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
            '
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(75, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Controls.Add(Me.pnlExportar)
            Me.Panel2.Controls.Add(Me.pnlEliminar)
            Me.Panel2.Controls.Add(Me.pnlModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 432)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1246, 66)
            Me.Panel2.TabIndex = 2
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSalir.Location = New System.Drawing.Point(462, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(96, 66)
            Me.pnlSalir.TabIndex = 3
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(2, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 53)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlExportar.Location = New System.Drawing.Point(369, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(93, 66)
            Me.pnlExportar.TabIndex = 2
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(4, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(84, 53)
            Me.btnExportar.TabIndex = 0
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(276, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(93, 66)
            Me.pnlEliminar.TabIndex = 1
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(6, 4)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(84, 53)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnNuevo)
            Me.pnlModificar.Controls.Add(Me.btnAnular)
            Me.pnlModificar.Controls.Add(Me.btnModificar)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(276, 66)
            Me.pnlModificar.TabIndex = 0
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(5, 4)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 53)
            Me.btnNuevo.TabIndex = 0
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnAnular.Location = New System.Drawing.Point(191, 4)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(84, 53)
            Me.btnAnular.TabIndex = 2
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnular.UseVisualStyleBackColor = True
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.Location = New System.Drawing.Point(97, 4)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(88, 53)
            Me.btnModificar.TabIndex = 1
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'frmBuscar_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1246, 498)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel3)
            Me.Name = "frmBuscar_v2"
            Me.Text = "Mantenimiento de Delitos"
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents txtDelitoEspecifico As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbDelitoGenerico As APPControls.uscComboParametrica
        Friend WithEvents txtArticulo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents cbbEstado As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents txtGrupoEspecifico As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents txtGrupoGenerico As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents col_del_art_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_del_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_del_gen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_tit_del As DataGridViewTextBoxColumn
        Friend WithEvents col_cap As DataGridViewTextBoxColumn
        Friend WithEvents col_sec As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_est As DataGridViewTextBoxColumn
        Friend WithEvents col_cud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_gru_generico As DataGridViewTextBoxColumn
        Friend WithEvents col_gru_generico As DataGridViewTextBoxColumn
        Friend WithEvents col_gru_especifico As DataGridViewTextBoxColumn
        Friend WithEvents col_esp_est_nom As DataGridViewTextBoxColumn
    End Class

End Namespace