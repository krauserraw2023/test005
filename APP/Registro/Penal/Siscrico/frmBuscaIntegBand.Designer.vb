Namespace Registro.Siscrico
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscaIntegBand
        Inherits Legolas.APPUIComponents.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaIntegBand))
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgwIntegrantesBanda = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_ban_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_complet = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ape_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nom_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nac_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tip_int_ban = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_org_crim_tip_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ban_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_band_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dist_jud_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fech_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblNomBanda = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtNomInt = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label26 = New System.Windows.Forms.Label()
            Me.dgwGrillaBandas = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.rbFiltXInterno = New System.Windows.Forms.RadioButton()
            Me.rbFiltXOrgCrim = New System.Windows.Forms.RadioButton()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Panel10 = New System.Windows.Forms.Panel()
            Me.pnlAnular = New System.Windows.Forms.Panel()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlEditar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.cbbBandaTipo = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblReg = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.pnlBusXBand = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.cbbTipoIntegranteBan = New APPControls.uscComboParametrica()
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox2 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.rdbBaja = New System.Windows.Forms.RadioButton()
            Me.rdbVigente = New System.Windows.Forms.RadioButton()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            CType(Me.dgwIntegrantesBanda, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgwGrillaBandas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.Panel10.SuspendLayout()
            Me.pnlAnular.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlEditar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.cbbBandaTipo.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.pnlBusXBand.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.cbbTipoIntegranteBan.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.cbbPenal.SuspendLayout()
            Me.cbbRegion.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(78, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Denominación:"
            '
            'dgwIntegrantesBanda
            '
            Me.dgwIntegrantesBanda.AllowUserToAddRows = False
            Me.dgwIntegrantesBanda.AllowUserToDeleteRows = False
            Me.dgwIntegrantesBanda.AllowUserToResizeRows = False
            Me.dgwIntegrantesBanda.BackgroundColor = System.Drawing.Color.White
            Me.dgwIntegrantesBanda.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwIntegrantesBanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwIntegrantesBanda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ing_id, Me.col_reg_nom, Me.col_pen_nom, Me.int_ban_id, Me.int_cod_rp, Me.col_nom_complet, Me.ape_int, Me.nom_int, Me.num_doc, Me.nac_int, Me.tip_int_ban, Me.doc_jud_id, Me.col_reg_id, Me.col_pen_id, Me.col_int_id, Me.col_org_crim_tip_nom, Me.col_ban_nom, Me.col_band_id, Me.col_dist_jud_nom, Me.col_sal_jud_nom, Me.col_num_doc_jud, Me.col_fech_doc_jud, Me.col_secre_doc_jud, Me.col_estado})
            Me.dgwIntegrantesBanda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwIntegrantesBanda.GridColor = System.Drawing.Color.LightGray
            Me.dgwIntegrantesBanda.Location = New System.Drawing.Point(0, 366)
            Me.dgwIntegrantesBanda.MultiSelect = False
            Me.dgwIntegrantesBanda.Name = "dgwIntegrantesBanda"
            Me.dgwIntegrantesBanda.ReadOnly = True
            Me.dgwIntegrantesBanda.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwIntegrantesBanda.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwIntegrantesBanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwIntegrantesBanda.Size = New System.Drawing.Size(943, 191)
            Me.dgwIntegrantesBanda.TabIndex = 91
            Me.dgwIntegrantesBanda.VisibleCampos = True
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoID"
            Me.col_ing_id.DividerWidth = 1
            Me.col_ing_id.HeaderText = "IngresoId"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNom"
            Me.col_reg_nom.HeaderText = "Región"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNom"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            '
            'int_ban_id
            '
            Me.int_ban_id.DataPropertyName = "Codigo"
            Me.int_ban_id.DividerWidth = 1
            Me.int_ban_id.HeaderText = "InternoBandaId"
            Me.int_ban_id.Name = "int_ban_id"
            Me.int_ban_id.ReadOnly = True
            Me.int_ban_id.Visible = False
            '
            'int_cod_rp
            '
            Me.int_cod_rp.DataPropertyName = "CodigoInterno"
            Me.int_cod_rp.DividerWidth = 1
            Me.int_cod_rp.HeaderText = "Código"
            Me.int_cod_rp.Name = "int_cod_rp"
            Me.int_cod_rp.ReadOnly = True
            Me.int_cod_rp.Width = 84
            '
            'col_nom_complet
            '
            Me.col_nom_complet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_nom_complet.DataPropertyName = "NombresCompletos"
            Me.col_nom_complet.HeaderText = "Apellidos y nombres"
            Me.col_nom_complet.MinimumWidth = 50
            Me.col_nom_complet.Name = "col_nom_complet"
            Me.col_nom_complet.ReadOnly = True
            Me.col_nom_complet.Width = 114
            '
            'ape_int
            '
            Me.ape_int.DataPropertyName = "ApellidosInterno"
            Me.ape_int.DividerWidth = 1
            Me.ape_int.HeaderText = "Apellidos"
            Me.ape_int.MinimumWidth = 100
            Me.ape_int.Name = "ape_int"
            Me.ape_int.ReadOnly = True
            Me.ape_int.Visible = False
            Me.ape_int.Width = 144
            '
            'nom_int
            '
            Me.nom_int.DataPropertyName = "NombresInterno"
            Me.nom_int.DividerWidth = 1
            Me.nom_int.HeaderText = "Nombres"
            Me.nom_int.Name = "nom_int"
            Me.nom_int.ReadOnly = True
            Me.nom_int.Visible = False
            Me.nom_int.Width = 144
            '
            'num_doc
            '
            Me.num_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.num_doc.DataPropertyName = "DocIdenInt"
            Me.num_doc.HeaderText = "Doc. Identidad"
            Me.num_doc.MinimumWidth = 100
            Me.num_doc.Name = "num_doc"
            Me.num_doc.ReadOnly = True
            '
            'nac_int
            '
            Me.nac_int.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.nac_int.DataPropertyName = "NacionalidadInt"
            Me.nac_int.HeaderText = "Nacionalidad"
            Me.nac_int.Name = "nac_int"
            Me.nac_int.ReadOnly = True
            Me.nac_int.Width = 94
            '
            'tip_int_ban
            '
            Me.tip_int_ban.DataPropertyName = "BandaMiembroTipoNombre_Ini"
            Me.tip_int_ban.HeaderText = "Tipo Int."
            Me.tip_int_ban.Name = "tip_int_ban"
            Me.tip_int_ban.ReadOnly = True
            Me.tip_int_ban.Width = 45
            '
            'doc_jud_id
            '
            Me.doc_jud_id.DataPropertyName = "DocJudicialID_Crea"
            Me.doc_jud_id.DividerWidth = 1
            Me.doc_jud_id.HeaderText = "IdDocJudicial"
            Me.doc_jud_id.Name = "doc_jud_id"
            Me.doc_jud_id.ReadOnly = True
            Me.doc_jud_id.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegioId"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "Regionid"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalId"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "PenalId"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "InternoId"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_org_crim_tip_nom
            '
            Me.col_org_crim_tip_nom.DataPropertyName = "BandaTipoNom_Ini"
            Me.col_org_crim_tip_nom.HeaderText = "Tipo Org. Criminal"
            Me.col_org_crim_tip_nom.Name = "col_org_crim_tip_nom"
            Me.col_org_crim_tip_nom.ReadOnly = True
            Me.col_org_crim_tip_nom.Visible = False
            Me.col_org_crim_tip_nom.Width = 80
            '
            'col_ban_nom
            '
            Me.col_ban_nom.DataPropertyName = "BandaNombre"
            Me.col_ban_nom.HeaderText = "Organización criminal"
            Me.col_ban_nom.Name = "col_ban_nom"
            Me.col_ban_nom.ReadOnly = True
            Me.col_ban_nom.Visible = False
            Me.col_ban_nom.Width = 170
            '
            'col_band_id
            '
            Me.col_band_id.DataPropertyName = "BandaID"
            Me.col_band_id.DividerWidth = 1
            Me.col_band_id.HeaderText = "OrgCrimId"
            Me.col_band_id.Name = "col_band_id"
            Me.col_band_id.ReadOnly = True
            Me.col_band_id.Visible = False
            '
            'col_dist_jud_nom
            '
            Me.col_dist_jud_nom.DataPropertyName = "DocJudDistNom"
            Me.col_dist_jud_nom.HeaderText = "Distrito Judicial"
            Me.col_dist_jud_nom.Name = "col_dist_jud_nom"
            Me.col_dist_jud_nom.ReadOnly = True
            Me.col_dist_jud_nom.Width = 120
            '
            'col_sal_jud_nom
            '
            Me.col_sal_jud_nom.DataPropertyName = "DocJudSalaNom"
            Me.col_sal_jud_nom.HeaderText = "Sala Judicial"
            Me.col_sal_jud_nom.Name = "col_sal_jud_nom"
            Me.col_sal_jud_nom.ReadOnly = True
            Me.col_sal_jud_nom.Width = 200
            '
            'col_num_doc_jud
            '
            Me.col_num_doc_jud.DataPropertyName = "DocJudNum"
            Me.col_num_doc_jud.HeaderText = "N° Doc. Jud."
            Me.col_num_doc_jud.Name = "col_num_doc_jud"
            Me.col_num_doc_jud.ReadOnly = True
            '
            'col_fech_doc_jud
            '
            Me.col_fech_doc_jud.DataPropertyName = "FechDocJudConFormato"
            Me.col_fech_doc_jud.HeaderText = "Fecha Doc. Jud."
            Me.col_fech_doc_jud.Name = "col_fech_doc_jud"
            Me.col_fech_doc_jud.ReadOnly = True
            Me.col_fech_doc_jud.Width = 77
            '
            'col_secre_doc_jud
            '
            Me.col_secre_doc_jud.DataPropertyName = "DocJudSecre"
            Me.col_secre_doc_jud.HeaderText = "Secretario Doc. Jud."
            Me.col_secre_doc_jud.Name = "col_secre_doc_jud"
            Me.col_secre_doc_jud.ReadOnly = True
            Me.col_secre_doc_jud.Width = 150
            '
            'col_estado
            '
            Me.col_estado.DataPropertyName = "EstadoNombre"
            Me.col_estado.HeaderText = "Estado"
            Me.col_estado.Name = "col_estado"
            Me.col_estado.ReadOnly = True
            Me.col_estado.Width = 70
            '
            'lblNomBanda
            '
            Me.lblNomBanda.BackColor = System.Drawing.Color.Transparent
            Me.lblNomBanda.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblNomBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNomBanda.Location = New System.Drawing.Point(0, 351)
            Me.lblNomBanda.Name = "lblNomBanda"
            Me.lblNomBanda.Size = New System.Drawing.Size(943, 15)
            Me.lblNomBanda.TabIndex = 88
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(469, 16)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(92, 13)
            Me.Label5.TabIndex = 74
            Me.Label5.Text = "Apellido Materno :"
            '
            'txtNomInt
            '
            Me.txtNomInt._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNomInt._BloquearPaste = False
            Me.txtNomInt._SeleccionarTodo = True
            Me.txtNomInt.Location = New System.Drawing.Point(280, 33)
            Me.txtNomInt.Name = "txtNomInt"
            Me.txtNomInt.Size = New System.Drawing.Size(446, 20)
            Me.txtNomInt.TabIndex = 76
            Me.txtNomInt.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNomInt.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(225, 36)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(52, 13)
            Me.Label7.TabIndex = 73
            Me.Label7.Text = "Nombres:"
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.Location = New System.Drawing.Point(280, 12)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(168, 20)
            Me.txtApePat.TabIndex = 76
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(187, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(90, 13)
            Me.Label6.TabIndex = 73
            Me.Label6.Text = "Apellido Paterno :"
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = True
            Me.txtCodInterno.ForeColor = System.Drawing.Color.Black
            Me.txtCodInterno.Location = New System.Drawing.Point(92, 12)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.Size = New System.Drawing.Size(75, 20)
            Me.txtCodInterno.TabIndex = 75
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(5, 16)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 78
            Me.Label26.Text = "Código Interno :"
            '
            'dgwGrillaBandas
            '
            Me.dgwGrillaBandas.AllowUserToAddRows = False
            Me.dgwGrillaBandas.AllowUserToDeleteRows = False
            Me.dgwGrillaBandas.AllowUserToResizeRows = False
            Me.dgwGrillaBandas.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaBandas.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaBandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaBandas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.colNombre, Me.colTipo})
            Me.dgwGrillaBandas.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwGrillaBandas.Location = New System.Drawing.Point(0, 108)
            Me.dgwGrillaBandas.MultiSelect = False
            Me.dgwGrillaBandas.Name = "dgwGrillaBandas"
            Me.dgwGrillaBandas.ReadOnly = True
            Me.dgwGrillaBandas.RowHeadersVisible = False
            Me.dgwGrillaBandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaBandas.Size = New System.Drawing.Size(943, 153)
            Me.dgwGrillaBandas.TabIndex = 86
            Me.dgwGrillaBandas.VisibleCampos = True
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.DividerWidth = 1
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'colNombre
            '
            Me.colNombre.DataPropertyName = "BandaNombre"
            Me.colNombre.HeaderText = "Nombre"
            Me.colNombre.MinimumWidth = 350
            Me.colNombre.Name = "colNombre"
            Me.colNombre.ReadOnly = True
            Me.colNombre.Width = 350
            '
            'colTipo
            '
            Me.colTipo.DataPropertyName = "BandaTipoNombre"
            Me.colTipo.HeaderText = "Tipo Grupo Criminal"
            Me.colTipo.Name = "colTipo"
            Me.colTipo.ReadOnly = True
            Me.colTipo.Width = 150
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.rbFiltXInterno)
            Me.Panel1.Controls.Add(Me.rbFiltXOrgCrim)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(943, 23)
            Me.Panel1.TabIndex = 92
            '
            'rbFiltXInterno
            '
            Me.rbFiltXInterno.AutoSize = True
            Me.rbFiltXInterno.BackColor = System.Drawing.Color.Transparent
            Me.rbFiltXInterno.Location = New System.Drawing.Point(205, 4)
            Me.rbFiltXInterno.Name = "rbFiltXInterno"
            Me.rbFiltXInterno.Size = New System.Drawing.Size(157, 17)
            Me.rbFiltXInterno.TabIndex = 83
            Me.rbFiltXInterno.Text = "Buscar por datos del interno"
            Me.rbFiltXInterno.UseVisualStyleBackColor = False
            '
            'rbFiltXOrgCrim
            '
            Me.rbFiltXOrgCrim.AutoSize = True
            Me.rbFiltXOrgCrim.BackColor = System.Drawing.Color.Transparent
            Me.rbFiltXOrgCrim.Checked = True
            Me.rbFiltXOrgCrim.Location = New System.Drawing.Point(12, 4)
            Me.rbFiltXOrgCrim.Name = "rbFiltXOrgCrim"
            Me.rbFiltXOrgCrim.Size = New System.Drawing.Size(177, 17)
            Me.rbFiltXOrgCrim.TabIndex = 82
            Me.rbFiltXOrgCrim.TabStop = True
            Me.rbFiltXOrgCrim.Text = "Buscar por organización criminal"
            Me.rbFiltXOrgCrim.UseVisualStyleBackColor = False
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer))
            Me.txtApeMat.Location = New System.Drawing.Point(565, 12)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(161, 20)
            Me.txtApeMat.TabIndex = 77
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(443, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(87, 49)
            Me.pnlEliminar.TabIndex = 96
            Me.pnlEliminar.Visible = False
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(1, 5)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(85, 40)
            Me.btnEliminar.TabIndex = 91
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(0, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(76, 40)
            Me.btnSalir.TabIndex = 68
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Panel10
            '
            Me.Panel10.Controls.Add(Me.btnSalir)
            Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel10.Location = New System.Drawing.Point(530, 0)
            Me.Panel10.Name = "Panel10"
            Me.Panel10.Size = New System.Drawing.Size(77, 49)
            Me.Panel10.TabIndex = 97
            '
            'pnlAnular
            '
            Me.pnlAnular.Controls.Add(Me.btnAnular)
            Me.pnlAnular.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAnular.Location = New System.Drawing.Point(357, 0)
            Me.pnlAnular.Name = "pnlAnular"
            Me.pnlAnular.Size = New System.Drawing.Size(86, 49)
            Me.pnlAnular.TabIndex = 95
            Me.pnlAnular.Visible = False
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnAnular.Location = New System.Drawing.Point(1, 5)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(85, 40)
            Me.btnAnular.TabIndex = 90
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnReporte
            '
            Me.btnReporte.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(93, 5)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(87, 40)
            Me.btnReporte.TabIndex = 93
            Me.btnReporte.Text = "&Reporte"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.Panel7)
            Me.Panel2.Controls.Add(Me.Label8)
            Me.Panel2.Controls.Add(Me.Panel10)
            Me.Panel2.Controls.Add(Me.pnlEliminar)
            Me.Panel2.Controls.Add(Me.pnlAnular)
            Me.Panel2.Controls.Add(Me.pnlReporte)
            Me.Panel2.Controls.Add(Me.pnlEditar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 557)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(943, 49)
            Me.Panel2.TabIndex = 89
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.Label13)
            Me.Panel7.Controls.Add(Me.Label14)
            Me.Panel7.Controls.Add(Me.Label9)
            Me.Panel7.Controls.Add(Me.Label12)
            Me.Panel7.Controls.Add(Me.Label10)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel7.Location = New System.Drawing.Point(731, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(209, 49)
            Me.Panel7.TabIndex = 101
            '
            'Label13
            '
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.Gray
            Me.Label13.Location = New System.Drawing.Point(-3, -2)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(9, 52)
            Me.Label13.TabIndex = 100
            Me.Label13.Text = "|||||"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(121, 16)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(85, 13)
            Me.Label14.TabIndex = 99
            Me.Label14.Text = "FNC:  Financista"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(6, 3)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(98, 13)
            Me.Label9.TabIndex = 99
            Me.Label9.Text = "Tipo Integrante."
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(19, 16)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(85, 13)
            Me.Label12.TabIndex = 99
            Me.Label12.Text = "INT :  Integrante"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(19, 33)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(105, 13)
            Me.Label10.TabIndex = 99
            Me.Label10.Text = "C/L : Cabecilla/Lider"
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.Red
            Me.Label8.Location = New System.Drawing.Point(607, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(124, 49)
            Me.Label8.TabIndex = 98
            Me.Label8.Text = "Doble click en el registro para ver detalle del interno."
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(176, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(181, 49)
            Me.pnlReporte.TabIndex = 94
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(1, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(92, 40)
            Me.btnExportar.TabIndex = 92
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlEditar
            '
            Me.pnlEditar.Controls.Add(Me.btnNuevo)
            Me.pnlEditar.Controls.Add(Me.btnModificar)
            Me.pnlEditar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEditar.Location = New System.Drawing.Point(0, 0)
            Me.pnlEditar.Name = "pnlEditar"
            Me.pnlEditar.Size = New System.Drawing.Size(176, 49)
            Me.pnlEditar.TabIndex = 93
            Me.pnlEditar.Visible = False
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(1, 5)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(84, 40)
            Me.btnNuevo.TabIndex = 69
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.Location = New System.Drawing.Point(85, 5)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 40)
            Me.btnModificar.TabIndex = 70
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
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
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(84, 48)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'grbBusqueda
            '
            Me.grbBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.grbBusqueda.Controls.Add(Me.Label3)
            Me.grbBusqueda.Controls.Add(Me.cbbBandaTipo)
            Me.grbBusqueda.Controls.Add(Me.Label11)
            Me.grbBusqueda.Controls.Add(Me.txtNom)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Size = New System.Drawing.Size(734, 85)
            Me.grbBusqueda.TabIndex = 81
            Me.grbBusqueda.TabStop = False
            '
            'cbbBandaTipo
            '
            Me.cbbBandaTipo._NoIndica = False
            Me.cbbBandaTipo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbBandaTipo._Todos = False
            Me.cbbBandaTipo._TodosMensaje = ""
            Me.cbbBandaTipo._Visible_Add = False
            Me.cbbBandaTipo._Visible_Buscar = False
            Me.cbbBandaTipo._Visible_Eliminar = False
            Me.cbbBandaTipo.CodigoPadre = -1
            Me.cbbBandaTipo.ComboTipo = CType(60, Short)
            Me.cbbBandaTipo.Controls.Add(Me.ComboBox1)
            Me.cbbBandaTipo.Controls.Add(Me.MyComboBox1)
            Me.cbbBandaTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBandaTipo.DropDownWidth = 222
            Me.cbbBandaTipo.DropDownWidthAuto = False
            Me.cbbBandaTipo.ListaIdsParaExcluir = Nothing
            Me.cbbBandaTipo.Location = New System.Drawing.Point(91, 20)
            Me.cbbBandaTipo.ModuloTratamiento = False
            Me.cbbBandaTipo.Name = "cbbBandaTipo"
            Me.cbbBandaTipo.Parametro1 = -1
            Me.cbbBandaTipo.Parametro2 = -1
            Me.cbbBandaTipo.SelectedIndex = -1
            Me.cbbBandaTipo.SelectedValue = 0
            Me.cbbBandaTipo.Size = New System.Drawing.Size(631, 22)
            Me.cbbBandaTipo.TabIndex = 77
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 222
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(631, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'MyComboBox1
            '
            Me.MyComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox1.DropDownWidth = 222
            Me.MyComboBox1.FormattingEnabled = True
            Me.MyComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox1.Name = "MyComboBox1"
            Me.MyComboBox1.Size = New System.Drawing.Size(631, 21)
            Me.MyComboBox1.TabIndex = 2
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(8, 23)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(28, 13)
            Me.Label11.TabIndex = 76
            Me.Label11.Text = "Tipo"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(92, 45)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(630, 20)
            Me.txtNom.TabIndex = 80
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblReg.Location = New System.Drawing.Point(3, 64)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(84, 19)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'grbBuscar
            '
            Me.grbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbBuscar.Location = New System.Drawing.Point(734, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(90, 85)
            Me.grbBuscar.TabIndex = 82
            Me.grbBuscar.TabStop = False
            '
            'pnlBusXBand
            '
            Me.pnlBusXBand.BackColor = System.Drawing.Color.Transparent
            Me.pnlBusXBand.Controls.Add(Me.grbBuscar)
            Me.pnlBusXBand.Controls.Add(Me.grbBusqueda)
            Me.pnlBusXBand.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusXBand.Location = New System.Drawing.Point(0, 23)
            Me.pnlBusXBand.Name = "pnlBusXBand"
            Me.pnlBusXBand.Size = New System.Drawing.Size(943, 85)
            Me.pnlBusXBand.TabIndex = 87
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Panel6)
            Me.GroupBox2.Controls.Add(Me.txtApeMat)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtNomInt)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.txtApePat)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.Label26)
            Me.GroupBox2.Controls.Add(Me.txtCodInterno)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(734, 56)
            Me.GroupBox2.TabIndex = 84
            Me.GroupBox2.TabStop = False
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.cbbTipoIntegranteBan)
            Me.Panel6.Controls.Add(Me.Label2)
            Me.Panel6.Controls.Add(Me.Panel5)
            Me.Panel6.Controls.Add(Me.Label1)
            Me.Panel6.Location = New System.Drawing.Point(6, 10)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(725, 43)
            Me.Panel6.TabIndex = 79
            '
            'cbbTipoIntegranteBan
            '
            Me.cbbTipoIntegranteBan._NoIndica = True
            Me.cbbTipoIntegranteBan._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoIntegranteBan._Todos = True
            Me.cbbTipoIntegranteBan._TodosMensaje = "[Todos]"
            Me.cbbTipoIntegranteBan._Visible_Add = False
            Me.cbbTipoIntegranteBan._Visible_Buscar = False
            Me.cbbTipoIntegranteBan._Visible_Eliminar = False
            Me.cbbTipoIntegranteBan.CodigoPadre = -1
            Me.cbbTipoIntegranteBan.ComboTipo = CType(62, Short)
            Me.cbbTipoIntegranteBan.Controls.Add(Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26)
            Me.cbbTipoIntegranteBan.Controls.Add(Me.MyComboBox2)
            Me.cbbTipoIntegranteBan.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoIntegranteBan.DropDownWidth = 325
            Me.cbbTipoIntegranteBan.DropDownWidthAuto = True
            Me.cbbTipoIntegranteBan.ListaIdsParaExcluir = Nothing
            Me.cbbTipoIntegranteBan.Location = New System.Drawing.Point(88, 12)
            Me.cbbTipoIntegranteBan.ModuloTratamiento = False
            Me.cbbTipoIntegranteBan.Name = "cbbTipoIntegranteBan"
            Me.cbbTipoIntegranteBan.Parametro1 = -1
            Me.cbbTipoIntegranteBan.Parametro2 = -1
            Me.cbbTipoIntegranteBan.SelectedIndex = -1
            Me.cbbTipoIntegranteBan.SelectedValue = 0
            Me.cbbTipoIntegranteBan.Size = New System.Drawing.Size(257, 22)
            Me.cbbTipoIntegranteBan.TabIndex = 70
            '
            'object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26
            '
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.DropDownWidth = 325
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.FormattingEnabled = True
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.Location = New System.Drawing.Point(0, 0)
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.Name = "object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26"
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.Size = New System.Drawing.Size(257, 21)
            Me.object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26.TabIndex = 2
            '
            'MyComboBox2
            '
            Me.MyComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox2.DropDownWidth = 325
            Me.MyComboBox2.FormattingEnabled = True
            Me.MyComboBox2.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox2.Name = "MyComboBox2"
            Me.MyComboBox2.Size = New System.Drawing.Size(257, 21)
            Me.MyComboBox2.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(370, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(98, 13)
            Me.Label2.TabIndex = 71
            Me.Label2.Text = "Estado integrantes:"
            '
            'Panel5
            '
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.rdbBaja)
            Me.Panel5.Controls.Add(Me.rdbVigente)
            Me.Panel5.Controls.Add(Me.rdbTodos)
            Me.Panel5.Location = New System.Drawing.Point(474, 11)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(243, 25)
            Me.Panel5.TabIndex = 72
            '
            'rdbBaja
            '
            Me.rdbBaja.AutoSize = True
            Me.rdbBaja.Location = New System.Drawing.Point(157, 3)
            Me.rdbBaja.Name = "rdbBaja"
            Me.rdbBaja.Size = New System.Drawing.Size(64, 17)
            Me.rdbBaja.TabIndex = 77
            Me.rdbBaja.Text = "Anulado"
            Me.rdbBaja.UseVisualStyleBackColor = True
            '
            'rdbVigente
            '
            Me.rdbVigente.AutoSize = True
            Me.rdbVigente.Location = New System.Drawing.Point(72, 3)
            Me.rdbVigente.Name = "rdbVigente"
            Me.rdbVigente.Size = New System.Drawing.Size(55, 17)
            Me.rdbVigente.TabIndex = 76
            Me.rdbVigente.Text = "Activo"
            Me.rdbVigente.UseVisualStyleBackColor = True
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(4, 3)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 75
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(3, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(85, 13)
            Me.Label1.TabIndex = 69
            Me.Label1.Text = "Tipo Integrante :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.cbbPenal)
            Me.GroupBox1.Controls.Add(Me.cbbRegion)
            Me.GroupBox1.Controls.Add(Me.Label34)
            Me.GroupBox1.Location = New System.Drawing.Point(3, -4)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(734, 37)
            Me.GroupBox1.TabIndex = 57
            Me.GroupBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 56
            Me.Label4.Text = "Región :"
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = CType(36, Short)
            Me.cbbPenal.Controls.Add(Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 238
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(430, 12)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(289, 22)
            Me.cbbPenal.TabIndex = 54
            '
            'object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388
            '
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.DropDownWidth = 238
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.FormattingEnabled = True
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.Location = New System.Drawing.Point(0, 0)
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.Name = "object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388"
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.Size = New System.Drawing.Size(289, 21)
            Me.object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388.TabIndex = 2
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = CType(37, Short)
            Me.cbbRegion.Controls.Add(Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(92, 12)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(256, 22)
            Me.cbbRegion.TabIndex = 53
            '
            'object_1f4b3030_9703_4d43_ac6d_eb88bb91914f
            '
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.DropDownWidth = 178
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.FormattingEnabled = True
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.Location = New System.Drawing.Point(0, 0)
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.Name = "object_1f4b3030_9703_4d43_ac6d_eb88bb91914f"
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.Size = New System.Drawing.Size(256, 21)
            Me.object_1f4b3030_9703_4d43_ac6d_eb88bb91914f.TabIndex = 2
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Location = New System.Drawing.Point(373, 16)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(51, 13)
            Me.Label34.TabIndex = 55
            Me.Label34.Text = "Penales :"
            '
            'Panel3
            '
            Me.Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Panel3.Controls.Add(Me.GroupBox2)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 295)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(943, 56)
            Me.Panel3.TabIndex = 90
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.Transparent
            Me.Panel4.Controls.Add(Me.GroupBox1)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(0, 261)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(943, 34)
            Me.Panel4.TabIndex = 93
            '
            'frmBuscaIntegBand
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(943, 606)
            Me.Controls.Add(Me.dgwIntegrantesBanda)
            Me.Controls.Add(Me.lblNomBanda)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.Panel4)
            Me.Controls.Add(Me.dgwGrillaBandas)
            Me.Controls.Add(Me.pnlBusXBand)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "frmBuscaIntegBand"
            Me.Text = "Siscrico"
            CType(Me.dgwIntegrantesBanda, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgwGrillaBandas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlEliminar.ResumeLayout(False)
            Me.Panel10.ResumeLayout(False)
            Me.pnlAnular.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlEditar.ResumeLayout(False)
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            Me.cbbBandaTipo.ResumeLayout(False)
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.pnlBusXBand.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.cbbTipoIntegranteBan.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.cbbPenal.ResumeLayout(False)
            Me.cbbRegion.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dgwIntegrantesBanda As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents lblNomBanda As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNomInt As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents dgwGrillaBandas As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents rbFiltXInterno As System.Windows.Forms.RadioButton
        Friend WithEvents rbFiltXOrgCrim As System.Windows.Forms.RadioButton
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Panel10 As System.Windows.Forms.Panel
        Friend WithEvents pnlAnular As System.Windows.Forms.Panel
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents pnlEditar As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents cbbBandaTipo As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox1 As Legolas.APPUIComponents.MyComboBox
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents pnlBusXBand As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents object_27f3ab2c_7ff3_423f_bb34_aaf1c7896388 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents object_1f4b3030_9703_4d43_ac6d_eb88bb91914f As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents cbbTipoIntegranteBan As APPControls.uscComboParametrica
        Friend WithEvents object_7d3a117e_90d2_4e48_b5fd_875cf48f0c26 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox2 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents rdbBaja As System.Windows.Forms.RadioButton
        Friend WithEvents rdbVigente As System.Windows.Forms.RadioButton
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_ban_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_cod_rp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom_complet As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ape_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nom_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nac_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tip_int_ban As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_org_crim_tip_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ban_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_band_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_dist_jud_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fech_doc_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_secre_doc_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class

End Namespace
