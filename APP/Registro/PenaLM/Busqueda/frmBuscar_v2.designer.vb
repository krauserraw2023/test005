Namespace Registro.PenalLM.Busqueda
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscar_v2
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar_v2))
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grbSitJur = New System.Windows.Forms.GroupBox()
            Me.rdbSentProcs = New System.Windows.Forms.RadioButton()
            Me.rdbSitJurTodos = New System.Windows.Forms.RadioButton()
            Me.rdbSentenciado = New System.Windows.Forms.RadioButton()
            Me.rdbProcesado = New System.Windows.Forms.RadioButton()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.btnVerifHuella = New System.Windows.Forms.Button()
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.rdbNacTodos = New System.Windows.Forms.RadioButton()
            Me.rdbExtranjero = New System.Windows.Forms.RadioButton()
            Me.rdbPeruano = New System.Windows.Forms.RadioButton()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.rdbSexoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbMuj = New System.Windows.Forms.RadioButton()
            Me.rdbHom = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbEstadoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbInactivo = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.txtAlias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cbbDelitoGenerico = New APPControls.uscComboParametrica()
            Me.cbbDelitoEspecifico = New APPControls.uscComboParametrica()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblSegundo = New System.Windows.Forms.Label()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.pnlBotonesAccion = New System.Windows.Forms.Panel()
            Me.pnlBotonOtros = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlBotonReporte = New System.Windows.Forms.Panel()
            Me.btnFicha = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlBotonGrabar = New System.Windows.Forms.Panel()
            Me.btnTramite = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.pnlFotografia = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.rdbPD = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPF = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPI = New Legolas.APPUIComponents.myRadioButton()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.txtSituacionJur = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaEgreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTipoEgreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtIngresoFecha = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtIngresoNum = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblResFecEgreso = New System.Windows.Forms.Label()
            Me.lblResTipoEgreso = New System.Windows.Forms.Label()
            Me.lblResSitJur = New System.Windows.Forms.Label()
            Me.lblResFecIngreso = New System.Windows.Forms.Label()
            Me.lblResUltIngreso = New System.Windows.Forms.Label()
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.pnlCuerpoPrincipal = New System.Windows.Forms.Panel()
            Me.tcBusqueda = New System.Windows.Forms.TabControl()
            Me.tpBandeja = New System.Windows.Forms.TabPage()
            Me.dgwBandeja = New Legolas.APPUIComponents.myDatagridView()
            Me.bnd_col_mov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_ori_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_ori_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_trs_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.bnd_col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pizq_arch_dig_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pfron_arch_dig_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pder_arch_dig_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_ori_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_idn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ban_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ban_tip_doc_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ban_num_doc_ident = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_mov_origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpConsultaInterno = New System.Windows.Forms.TabPage()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_loc_row = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_sed_row = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ver_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pabellon = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_ico_pi = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_fot_ico_pf = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_fot_ico_pd = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpConsultaMovimiento = New System.Windows.Forms.TabPage()
            Me.UscBusquedaMovimiento1 = New APPControls.Registro.PenalLM.uscBusquedaMovimientosPLM()
            Me.tpConsultaConsReclu = New System.Windows.Forms.TabPage()
            Me.UscConsultaTramite1 = New APPControls.Registro.ConsultaReclusion.uscConsultaTramite()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.pnlRegionPenal = New System.Windows.Forms.Panel()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnRefresBandeja = New System.Windows.Forms.Button()
            Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.pnlInferior = New System.Windows.Forms.Panel()
            Me.pnlStatusBar = New System.Windows.Forms.Panel()
            Me.btnListarDescarga = New System.Windows.Forms.Button()
            Me.StatusStrip1 = New System.Windows.Forms.Label()
            Me.pnlBandeja = New System.Windows.Forms.Panel()
            Me.btnDescargar = New System.Windows.Forms.Button()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.bgwDownloadData = New System.ComponentModel.BackgroundWorker()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItemCR = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.pnlBusqueda.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.grbSitJur.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.pnlBotonesAccion.SuspendLayout()
            Me.pnlBotonOtros.SuspendLayout()
            Me.pnlBotonReporte.SuspendLayout()
            Me.pnlBotonGrabar.SuspendLayout()
            Me.pnlFotografia.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            Me.pnlCuerpoPrincipal.SuspendLayout()
            Me.tcBusqueda.SuspendLayout()
            Me.tpBandeja.SuspendLayout()
            CType(Me.dgwBandeja, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultaInterno.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultaMovimiento.SuspendLayout()
            Me.tpConsultaConsReclu.SuspendLayout()
            Me.pnlRegionPenal.SuspendLayout()
            Me.pnlInferior.SuspendLayout()
            Me.pnlStatusBar.SuspendLayout()
            Me.pnlBandeja.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.BackColor = System.Drawing.SystemColors.Control
            Me.pnlBusqueda.Controls.Add(Me.grbBusqueda)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(3, 3)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1049, 146)
            Me.pnlBusqueda.TabIndex = 0
            '
            'grbBusqueda
            '
            Me.grbBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.grbBusqueda.Controls.Add(Me.txtApeMat)
            Me.grbBusqueda.Controls.Add(Me.GroupBox4)
            Me.grbBusqueda.Controls.Add(Me.txtNom)
            Me.grbBusqueda.Controls.Add(Me.grbSitJur)
            Me.grbBusqueda.Controls.Add(Me.txtApePat)
            Me.grbBusqueda.Controls.Add(Me.btnVerifHuella)
            Me.grbBusqueda.Controls.Add(Me.txtCodInterno)
            Me.grbBusqueda.Controls.Add(Me.Label3)
            Me.grbBusqueda.Controls.Add(Me.GroupBox2)
            Me.grbBusqueda.Controls.Add(Me.Label2)
            Me.grbBusqueda.Controls.Add(Me.GroupBox3)
            Me.grbBusqueda.Controls.Add(Me.Label1)
            Me.grbBusqueda.Controls.Add(Me.grbEstado)
            Me.grbBusqueda.Controls.Add(Me.Label26)
            Me.grbBusqueda.Controls.Add(Me.GroupBox7)
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.grbBusqueda.Size = New System.Drawing.Size(1049, 146)
            Me.grbBusqueda.TabIndex = 0
            Me.grbBusqueda.TabStop = False
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer))
            Me.txtApeMat.Location = New System.Drawing.Point(104, 62)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(140, 20)
            Me.txtApeMat.TabIndex = 5
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.Label18)
            Me.GroupBox4.Controls.Add(Me.Label17)
            Me.GroupBox4.Controls.Add(Me.txtNumDoc)
            Me.GroupBox4.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox4.Location = New System.Drawing.Point(647, 10)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(300, 103)
            Me.GroupBox4.TabIndex = 12
            Me.GroupBox4.TabStop = False
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(9, 61)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(95, 13)
            Me.Label18.TabIndex = 2
            Me.Label18.Text = "N° Doc. Identidad:"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(6, 16)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(107, 13)
            Me.Label17.TabIndex = 0
            Me.Label17.Text = "Tipo Doc.  Identidad:"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(9, 77)
            Me.txtNumDoc.MaxLength = 20
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(228, 20)
            Me.txtNumDoc.TabIndex = 3
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = CType(2, Short)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 150
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(9, 32)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(228, 22)
            Me.cbbTipoDoc.TabIndex = 1
            Me.cbbTipoDoc.verToolTipItemSeleccionado = False
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(104, 85)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(140, 20)
            Me.txtNom.TabIndex = 7
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'grbSitJur
            '
            Me.grbSitJur.Controls.Add(Me.rdbSentProcs)
            Me.grbSitJur.Controls.Add(Me.rdbSitJurTodos)
            Me.grbSitJur.Controls.Add(Me.rdbSentenciado)
            Me.grbSitJur.Controls.Add(Me.rdbProcesado)
            Me.grbSitJur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbSitJur.Location = New System.Drawing.Point(523, 10)
            Me.grbSitJur.Name = "grbSitJur"
            Me.grbSitJur.Size = New System.Drawing.Size(123, 103)
            Me.grbSitJur.TabIndex = 11
            Me.grbSitJur.TabStop = False
            Me.grbSitJur.Text = "Situación Juridica"
            '
            'rdbSentProcs
            '
            Me.rdbSentProcs.AutoSize = True
            Me.rdbSentProcs.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbSentProcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSentProcs.Location = New System.Drawing.Point(24, 59)
            Me.rdbSentProcs.Name = "rdbSentProcs"
            Me.rdbSentProcs.Size = New System.Drawing.Size(86, 18)
            Me.rdbSentProcs.TabIndex = 2
            Me.rdbSentProcs.Text = "Sent./Proc."
            Me.rdbSentProcs.UseVisualStyleBackColor = True
            '
            'rdbSitJurTodos
            '
            Me.rdbSitJurTodos.AutoSize = True
            Me.rdbSitJurTodos.Checked = True
            Me.rdbSitJurTodos.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbSitJurTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSitJurTodos.Location = New System.Drawing.Point(24, 81)
            Me.rdbSitJurTodos.Name = "rdbSitJurTodos"
            Me.rdbSitJurTodos.Size = New System.Drawing.Size(67, 18)
            Me.rdbSitJurTodos.TabIndex = 3
            Me.rdbSitJurTodos.TabStop = True
            Me.rdbSitJurTodos.Text = "[Todos]"
            Me.rdbSitJurTodos.UseVisualStyleBackColor = True
            '
            'rdbSentenciado
            '
            Me.rdbSentenciado.AutoSize = True
            Me.rdbSentenciado.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbSentenciado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSentenciado.Location = New System.Drawing.Point(24, 38)
            Me.rdbSentenciado.Name = "rdbSentenciado"
            Me.rdbSentenciado.Size = New System.Drawing.Size(91, 18)
            Me.rdbSentenciado.TabIndex = 1
            Me.rdbSentenciado.Text = "Sentenciado"
            Me.rdbSentenciado.UseVisualStyleBackColor = True
            '
            'rdbProcesado
            '
            Me.rdbProcesado.AutoSize = True
            Me.rdbProcesado.FlatAppearance.BorderColor = System.Drawing.Color.Red
            Me.rdbProcesado.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbProcesado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbProcesado.Location = New System.Drawing.Point(24, 15)
            Me.rdbProcesado.Name = "rdbProcesado"
            Me.rdbProcesado.Size = New System.Drawing.Size(82, 18)
            Me.rdbProcesado.TabIndex = 0
            Me.rdbProcesado.Text = "Procesado"
            Me.rdbProcesado.UseVisualStyleBackColor = True
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.Location = New System.Drawing.Point(104, 39)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(140, 20)
            Me.txtApePat.TabIndex = 3
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'btnVerifHuella
            '
            Me.btnVerifHuella.BackColor = System.Drawing.SystemColors.Control
            Me.btnVerifHuella.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnVerifHuella.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnVerifHuella.Image = Global.SIPPOPE.My.Resources.Resources.verificar_biometria_32x32
            Me.btnVerifHuella.Location = New System.Drawing.Point(952, 101)
            Me.btnVerifHuella.Name = "btnVerifHuella"
            Me.btnVerifHuella.Size = New System.Drawing.Size(97, 40)
            Me.btnVerifHuella.TabIndex = 14
            Me.btnVerifHuella.Text = "Buscar por huella"
            Me.btnVerifHuella.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnVerifHuella.UseVisualStyleBackColor = False
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = True
            Me.txtCodInterno.ForeColor = System.Drawing.Color.Black
            Me.txtCodInterno.Location = New System.Drawing.Point(104, 16)
            Me.txtCodInterno.MaxLength = 10
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.Size = New System.Drawing.Size(87, 20)
            Me.txtCodInterno.TabIndex = 1
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 89)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Nombres :"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox2.Controls.Add(Me.rdbNacTodos)
            Me.GroupBox2.Controls.Add(Me.rdbExtranjero)
            Me.GroupBox2.Controls.Add(Me.rdbPeruano)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(250, 10)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(272, 60)
            Me.GroupBox2.TabIndex = 9
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Nacionalidad"
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = CType(4, Short)
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 143
            Me.cbbNacionalidad.DropDownWidthAuto = False
            Me.cbbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(73, 35)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(192, 22)
            Me.cbbNacionalidad.TabIndex = 4
            Me.cbbNacionalidad.verToolTipItemSeleccionado = False
            '
            'rdbNacTodos
            '
            Me.rdbNacTodos.AutoSize = True
            Me.rdbNacTodos.Checked = True
            Me.rdbNacTodos.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbNacTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNacTodos.Location = New System.Drawing.Point(165, 13)
            Me.rdbNacTodos.Name = "rdbNacTodos"
            Me.rdbNacTodos.Size = New System.Drawing.Size(67, 18)
            Me.rdbNacTodos.TabIndex = 2
            Me.rdbNacTodos.TabStop = True
            Me.rdbNacTodos.Text = "[Todos]"
            Me.rdbNacTodos.UseVisualStyleBackColor = True
            '
            'rdbExtranjero
            '
            Me.rdbExtranjero.AutoSize = True
            Me.rdbExtranjero.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbExtranjero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExtranjero.Location = New System.Drawing.Point(82, 13)
            Me.rdbExtranjero.Name = "rdbExtranjero"
            Me.rdbExtranjero.Size = New System.Drawing.Size(83, 18)
            Me.rdbExtranjero.TabIndex = 1
            Me.rdbExtranjero.Text = "Extranjeros"
            Me.rdbExtranjero.UseVisualStyleBackColor = True
            '
            'rdbPeruano
            '
            Me.rdbPeruano.AutoSize = True
            Me.rdbPeruano.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbPeruano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPeruano.Location = New System.Drawing.Point(6, 13)
            Me.rdbPeruano.Name = "rdbPeruano"
            Me.rdbPeruano.Size = New System.Drawing.Size(76, 18)
            Me.rdbPeruano.TabIndex = 0
            Me.rdbPeruano.Text = "Peruanos"
            Me.rdbPeruano.UseVisualStyleBackColor = True
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(1, 39)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(66, 13)
            Me.Label13.TabIndex = 3
            Me.Label13.Text = "Seleccione :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 66)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Segundo Apellido:"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rdbSexoTodos)
            Me.GroupBox3.Controls.Add(Me.rdbMuj)
            Me.GroupBox3.Controls.Add(Me.rdbHom)
            Me.GroupBox3.Location = New System.Drawing.Point(250, 62)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(272, 51)
            Me.GroupBox3.TabIndex = 10
            Me.GroupBox3.TabStop = False
            '
            'rdbSexoTodos
            '
            Me.rdbSexoTodos.AutoSize = True
            Me.rdbSexoTodos.Checked = True
            Me.rdbSexoTodos.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbSexoTodos.Location = New System.Drawing.Point(171, 23)
            Me.rdbSexoTodos.Name = "rdbSexoTodos"
            Me.rdbSexoTodos.Size = New System.Drawing.Size(67, 18)
            Me.rdbSexoTodos.TabIndex = 2
            Me.rdbSexoTodos.TabStop = True
            Me.rdbSexoTodos.Text = "[Todos]"
            Me.rdbSexoTodos.UseVisualStyleBackColor = True
            '
            'rdbMuj
            '
            Me.rdbMuj.AutoSize = True
            Me.rdbMuj.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbMuj.Location = New System.Drawing.Point(87, 23)
            Me.rdbMuj.Name = "rdbMuj"
            Me.rdbMuj.Size = New System.Drawing.Size(68, 18)
            Me.rdbMuj.TabIndex = 1
            Me.rdbMuj.Text = "Mujeres"
            Me.rdbMuj.UseVisualStyleBackColor = True
            '
            'rdbHom
            '
            Me.rdbHom.AutoSize = True
            Me.rdbHom.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbHom.Location = New System.Drawing.Point(6, 23)
            Me.rdbHom.Name = "rdbHom"
            Me.rdbHom.Size = New System.Drawing.Size(73, 18)
            Me.rdbHom.TabIndex = 0
            Me.rdbHom.Text = "Hombres"
            Me.rdbHom.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Primer Apellido :"
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbEstadoTodos)
            Me.grbEstado.Controls.Add(Me.rdbInactivo)
            Me.grbEstado.Controls.Add(Me.rdbActivo)
            Me.grbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbEstado.Location = New System.Drawing.Point(953, 9)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(95, 90)
            Me.grbEstado.TabIndex = 13
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado"
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Checked = True
            Me.rdbEstadoTodos.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbEstadoTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(19, 64)
            Me.rdbEstadoTodos.Name = "rdbEstadoTodos"
            Me.rdbEstadoTodos.Size = New System.Drawing.Size(67, 18)
            Me.rdbEstadoTodos.TabIndex = 2
            Me.rdbEstadoTodos.TabStop = True
            Me.rdbEstadoTodos.Text = "[Todos]"
            Me.rdbEstadoTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbInactivo.Location = New System.Drawing.Point(19, 41)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(69, 18)
            Me.rdbInactivo.TabIndex = 1
            Me.rdbInactivo.Text = "Inactivo"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbActivo.Location = New System.Drawing.Point(19, 19)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(61, 18)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(9, 19)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 0
            Me.Label26.Text = "Codigo Interno :"
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.txtAlias)
            Me.GroupBox7.Controls.Add(Me.Label16)
            Me.GroupBox7.Controls.Add(Me.cbbDelitoGenerico)
            Me.GroupBox7.Controls.Add(Me.cbbDelitoEspecifico)
            Me.GroupBox7.Controls.Add(Me.Label9)
            Me.GroupBox7.Controls.Add(Me.Label8)
            Me.GroupBox7.Location = New System.Drawing.Point(3, 106)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(944, 39)
            Me.GroupBox7.TabIndex = 8
            Me.GroupBox7.TabStop = False
            '
            'txtAlias
            '
            Me.txtAlias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAlias._BloquearPaste = False
            Me.txtAlias._SeleccionarTodo = True
            Me.txtAlias.Location = New System.Drawing.Point(101, 13)
            Me.txtAlias.Name = "txtAlias"
            Me.txtAlias.Size = New System.Drawing.Size(140, 20)
            Me.txtAlias.TabIndex = 1
            Me.txtAlias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtAlias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(6, 17)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(35, 13)
            Me.Label16.TabIndex = 0
            Me.Label16.Text = "Alias :"
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
            Me.cbbDelitoGenerico.Location = New System.Drawing.Point(320, 12)
            Me.cbbDelitoGenerico.ModuloTratamiento = False
            Me.cbbDelitoGenerico.Name = "cbbDelitoGenerico"
            Me.cbbDelitoGenerico.Parametro1 = -1
            Me.cbbDelitoGenerico.Parametro2 = -1
            Me.cbbDelitoGenerico.SelectedIndex = -1
            Me.cbbDelitoGenerico.SelectedValue = 0
            Me.cbbDelitoGenerico.Size = New System.Drawing.Size(270, 22)
            Me.cbbDelitoGenerico.TabIndex = 3
            Me.cbbDelitoGenerico.verToolTipItemSeleccionado = False
            '
            'cbbDelitoEspecifico
            '
            Me.cbbDelitoEspecifico._NoIndica = False
            Me.cbbDelitoEspecifico._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbDelitoEspecifico._Todos = False
            Me.cbbDelitoEspecifico._TodosMensaje = "[Todos]"
            Me.cbbDelitoEspecifico._Visible_Add = False
            Me.cbbDelitoEspecifico._Visible_Buscar = False
            Me.cbbDelitoEspecifico._Visible_Eliminar = False
            Me.cbbDelitoEspecifico.CodigoPadre = -1
            Me.cbbDelitoEspecifico.ComboTipo = CType(13, Short)
            Me.cbbDelitoEspecifico.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDelitoEspecifico.DropDownWidth = 209
            Me.cbbDelitoEspecifico.DropDownWidthAuto = True
            Me.cbbDelitoEspecifico.ListaIdsParaExcluir = Nothing
            Me.cbbDelitoEspecifico.Location = New System.Drawing.Point(653, 12)
            Me.cbbDelitoEspecifico.ModuloTratamiento = False
            Me.cbbDelitoEspecifico.Name = "cbbDelitoEspecifico"
            Me.cbbDelitoEspecifico.Parametro1 = -1
            Me.cbbDelitoEspecifico.Parametro2 = -1
            Me.cbbDelitoEspecifico.SelectedIndex = -1
            Me.cbbDelitoEspecifico.SelectedValue = 0
            Me.cbbDelitoEspecifico.Size = New System.Drawing.Size(291, 22)
            Me.cbbDelitoEspecifico.TabIndex = 5
            Me.cbbDelitoEspecifico.verToolTipItemSeleccionado = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(245, 9)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(56, 26)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Delito " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Generico :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(594, 8)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(62, 26)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Delito " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Especifico :"
            '
            'grbBuscar
            '
            Me.grbBuscar.BackColor = System.Drawing.SystemColors.Control
            Me.grbBuscar.Controls.Add(Me.lblSegundo)
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBuscar.Location = New System.Drawing.Point(0, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(196, 189)
            Me.grbBuscar.TabIndex = 0
            Me.grbBuscar.TabStop = False
            '
            'lblSegundo
            '
            Me.lblSegundo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSegundo.AutoSize = True
            Me.lblSegundo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblSegundo.Location = New System.Drawing.Point(72, 143)
            Me.lblSegundo.Name = "lblSegundo"
            Me.lblSegundo.Size = New System.Drawing.Size(49, 13)
            Me.lblSegundo.TabIndex = 0
            Me.lblSegundo.Text = "00:00:00"
            Me.lblSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 164)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(190, 22)
            Me.lblReg.TabIndex = 1
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
            Me.ToolStrip1.Size = New System.Drawing.Size(190, 170)
            Me.ToolStrip1.TabIndex = 0
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(188, 43)
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
            Me.tsbLimpiar.Size = New System.Drawing.Size(188, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'pnlBotonesAccion
            '
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonOtros)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonReporte)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonGrabar)
            Me.pnlBotonesAccion.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonesAccion.Location = New System.Drawing.Point(206, 0)
            Me.pnlBotonesAccion.Name = "pnlBotonesAccion"
            Me.pnlBotonesAccion.Size = New System.Drawing.Size(565, 43)
            Me.pnlBotonesAccion.TabIndex = 39
            '
            'pnlBotonOtros
            '
            Me.pnlBotonOtros.BackColor = System.Drawing.SystemColors.Control
            Me.pnlBotonOtros.Controls.Add(Me.btnSalir)
            Me.pnlBotonOtros.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBotonOtros.Location = New System.Drawing.Point(467, 0)
            Me.pnlBotonOtros.Name = "pnlBotonOtros"
            Me.pnlBotonOtros.Size = New System.Drawing.Size(98, 43)
            Me.pnlBotonOtros.TabIndex = 72
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
            Me.btnSalir.Location = New System.Drawing.Point(2, 1)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(85, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = False
            '
            'pnlBotonReporte
            '
            Me.pnlBotonReporte.BackColor = System.Drawing.SystemColors.Control
            Me.pnlBotonReporte.Controls.Add(Me.btnFicha)
            Me.pnlBotonReporte.Controls.Add(Me.btnExportar)
            Me.pnlBotonReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonReporte.Location = New System.Drawing.Point(280, 0)
            Me.pnlBotonReporte.Name = "pnlBotonReporte"
            Me.pnlBotonReporte.Size = New System.Drawing.Size(187, 43)
            Me.pnlBotonReporte.TabIndex = 71
            Me.pnlBotonReporte.Visible = False
            '
            'btnFicha
            '
            Me.btnFicha.BackColor = System.Drawing.SystemColors.Control
            Me.btnFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnFicha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnFicha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFicha.ForeColor = System.Drawing.Color.Black
            Me.btnFicha.Image = CType(resources.GetObject("btnFicha.Image"), System.Drawing.Image)
            Me.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.Location = New System.Drawing.Point(92, 1)
            Me.btnFicha.Name = "btnFicha"
            Me.btnFicha.Size = New System.Drawing.Size(94, 40)
            Me.btnFicha.TabIndex = 67
            Me.btnFicha.Text = "&Reportes"
            Me.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnFicha.UseVisualStyleBackColor = False
            '
            'btnExportar
            '
            Me.btnExportar.BackColor = System.Drawing.SystemColors.Control
            Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.ForeColor = System.Drawing.Color.Black
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(2, 1)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = False
            '
            'pnlBotonGrabar
            '
            Me.pnlBotonGrabar.BackColor = System.Drawing.SystemColors.Control
            Me.pnlBotonGrabar.Controls.Add(Me.btnTramite)
            Me.pnlBotonGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlBotonGrabar.Controls.Add(Me.btnModificar)
            Me.pnlBotonGrabar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonGrabar.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotonGrabar.Name = "pnlBotonGrabar"
            Me.pnlBotonGrabar.Size = New System.Drawing.Size(280, 43)
            Me.pnlBotonGrabar.TabIndex = 70
            Me.pnlBotonGrabar.Visible = False
            '
            'btnTramite
            '
            Me.btnTramite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTramite.Image = Global.SIPPOPE.My.Resources.Resources.row_add_before
            Me.btnTramite.Location = New System.Drawing.Point(186, 1)
            Me.btnTramite.Name = "btnTramite"
            Me.btnTramite.Size = New System.Drawing.Size(90, 40)
            Me.btnTramite.TabIndex = 66
            Me.btnTramite.Text = "&Tramite"
            Me.btnTramite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnTramite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnTramite.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
            Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.ForeColor = System.Drawing.Color.Black
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(2, 1)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(86, 40)
            Me.btnNuevo.TabIndex = 63
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = False
            '
            'btnModificar
            '
            Me.btnModificar.BackColor = System.Drawing.SystemColors.Control
            Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.ForeColor = System.Drawing.Color.Black
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.Location = New System.Drawing.Point(89, 1)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(94, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = False
            '
            'Timer1
            '
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.HeaderText = "Nombres Asociados"
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            '
            'pnlFotografia
            '
            Me.pnlFotografia.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.pnlFotografia.Controls.Add(Me.GroupBox1)
            Me.pnlFotografia.Controls.Add(Me.Panel1)
            Me.pnlFotografia.Controls.Add(Me.Panel5)
            Me.pnlFotografia.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlFotografia.Location = New System.Drawing.Point(1063, 0)
            Me.pnlFotografia.Name = "pnlFotografia"
            Me.pnlFotografia.Size = New System.Drawing.Size(196, 596)
            Me.pnlFotografia.TabIndex = 40
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
            Me.GroupBox1.Controls.Add(Me.UscFotografia_2v1)
            Me.GroupBox1.Controls.Add(Me.Panel4)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 189)
            Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox1.Size = New System.Drawing.Size(196, 284)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = False
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = True
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(3, 13)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(190, 245)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 0
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.rdbPD)
            Me.Panel4.Controls.Add(Me.rdbPF)
            Me.Panel4.Controls.Add(Me.rdbPI)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel4.Location = New System.Drawing.Point(3, 258)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(190, 23)
            Me.Panel4.TabIndex = 0
            '
            'rdbPD
            '
            Me.rdbPD.AutoSize = True
            Me.rdbPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPD.Location = New System.Drawing.Point(118, 3)
            Me.rdbPD.Name = "rdbPD"
            Me.rdbPD.Size = New System.Drawing.Size(42, 17)
            Me.rdbPD.TabIndex = 2
            Me.rdbPD.Text = "PD"
            Me.ToolTip1.SetToolTip(Me.rdbPD, "Ver foto del perfil derecho")
            Me.rdbPD.UseVisualStyleBackColor = True
            '
            'rdbPF
            '
            Me.rdbPF.AutoSize = True
            Me.rdbPF.Checked = True
            Me.rdbPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPF.Location = New System.Drawing.Point(67, 3)
            Me.rdbPF.Name = "rdbPF"
            Me.rdbPF.Size = New System.Drawing.Size(40, 17)
            Me.rdbPF.TabIndex = 1
            Me.rdbPF.TabStop = True
            Me.rdbPF.Text = "PF"
            Me.ToolTip1.SetToolTip(Me.rdbPF, "Ver foto del perfil frontal")
            Me.rdbPF.UseVisualStyleBackColor = True
            '
            'rdbPI
            '
            Me.rdbPI.AutoSize = True
            Me.rdbPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPI.Location = New System.Drawing.Point(9, 3)
            Me.rdbPI.Name = "rdbPI"
            Me.rdbPI.Size = New System.Drawing.Size(37, 17)
            Me.rdbPI.TabIndex = 0
            Me.rdbPI.Text = "PI"
            Me.ToolTip1.SetToolTip(Me.rdbPI, "Ver foto del perfil izquierdo")
            Me.rdbPI.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(196, 189)
            Me.Panel1.TabIndex = 2
            '
            'Panel5
            '
            Me.Panel5.AutoScroll = True
            Me.Panel5.BackColor = System.Drawing.SystemColors.Control
            Me.Panel5.Controls.Add(Me.txtSituacionJur)
            Me.Panel5.Controls.Add(Me.txtFechaEgreso)
            Me.Panel5.Controls.Add(Me.txtTipoEgreso)
            Me.Panel5.Controls.Add(Me.txtIngresoFecha)
            Me.Panel5.Controls.Add(Me.txtIngresoNum)
            Me.Panel5.Controls.Add(Me.lblResFecEgreso)
            Me.Panel5.Controls.Add(Me.lblResTipoEgreso)
            Me.Panel5.Controls.Add(Me.lblResSitJur)
            Me.Panel5.Controls.Add(Me.lblResFecIngreso)
            Me.Panel5.Controls.Add(Me.lblResUltIngreso)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 473)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(196, 123)
            Me.Panel5.TabIndex = 1
            '
            'txtSituacionJur
            '
            Me.txtSituacionJur._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSituacionJur._BloquearPaste = False
            Me.txtSituacionJur._SeleccionarTodo = True
            Me.txtSituacionJur.ForeColor = System.Drawing.Color.Black
            Me.txtSituacionJur.Location = New System.Drawing.Point(73, 51)
            Me.txtSituacionJur.Name = "txtSituacionJur"
            Me.txtSituacionJur.ReadOnly = True
            Me.txtSituacionJur.Size = New System.Drawing.Size(119, 20)
            Me.txtSituacionJur.TabIndex = 15
            Me.txtSituacionJur.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSituacionJur.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtFechaEgreso
            '
            Me.txtFechaEgreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaEgreso._BloquearPaste = False
            Me.txtFechaEgreso._SeleccionarTodo = True
            Me.txtFechaEgreso.ForeColor = System.Drawing.Color.Black
            Me.txtFechaEgreso.Location = New System.Drawing.Point(74, 98)
            Me.txtFechaEgreso.Name = "txtFechaEgreso"
            Me.txtFechaEgreso.ReadOnly = True
            Me.txtFechaEgreso.Size = New System.Drawing.Size(119, 20)
            Me.txtFechaEgreso.TabIndex = 14
            Me.txtFechaEgreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaEgreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtTipoEgreso
            '
            Me.txtTipoEgreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoEgreso._BloquearPaste = False
            Me.txtTipoEgreso._SeleccionarTodo = True
            Me.txtTipoEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoEgreso.ForeColor = System.Drawing.Color.Black
            Me.txtTipoEgreso.Location = New System.Drawing.Point(73, 74)
            Me.txtTipoEgreso.Name = "txtTipoEgreso"
            Me.txtTipoEgreso.ReadOnly = True
            Me.txtTipoEgreso.Size = New System.Drawing.Size(119, 20)
            Me.txtTipoEgreso.TabIndex = 13
            Me.txtTipoEgreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTipoEgreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtIngresoFecha
            '
            Me.txtIngresoFecha._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIngresoFecha._BloquearPaste = False
            Me.txtIngresoFecha._SeleccionarTodo = True
            Me.txtIngresoFecha.ForeColor = System.Drawing.Color.Black
            Me.txtIngresoFecha.Location = New System.Drawing.Point(73, 27)
            Me.txtIngresoFecha.Name = "txtIngresoFecha"
            Me.txtIngresoFecha.ReadOnly = True
            Me.txtIngresoFecha.Size = New System.Drawing.Size(119, 20)
            Me.txtIngresoFecha.TabIndex = 11
            Me.txtIngresoFecha.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIngresoFecha.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtIngresoNum
            '
            Me.txtIngresoNum._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIngresoNum._BloquearPaste = False
            Me.txtIngresoNum._SeleccionarTodo = True
            Me.txtIngresoNum.ForeColor = System.Drawing.Color.Black
            Me.txtIngresoNum.Location = New System.Drawing.Point(73, 4)
            Me.txtIngresoNum.Name = "txtIngresoNum"
            Me.txtIngresoNum.ReadOnly = True
            Me.txtIngresoNum.Size = New System.Drawing.Size(119, 20)
            Me.txtIngresoNum.TabIndex = 10
            Me.txtIngresoNum.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIngresoNum.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblResFecEgreso
            '
            Me.lblResFecEgreso.AutoSize = True
            Me.lblResFecEgreso.ForeColor = System.Drawing.Color.Black
            Me.lblResFecEgreso.Location = New System.Drawing.Point(5, 101)
            Me.lblResFecEgreso.Name = "lblResFecEgreso"
            Me.lblResFecEgreso.Size = New System.Drawing.Size(67, 13)
            Me.lblResFecEgreso.TabIndex = 8
            Me.lblResFecEgreso.Text = "Fec. Egreso:"
            Me.lblResFecEgreso.Visible = False
            '
            'lblResTipoEgreso
            '
            Me.lblResTipoEgreso.AutoSize = True
            Me.lblResTipoEgreso.ForeColor = System.Drawing.Color.Black
            Me.lblResTipoEgreso.Location = New System.Drawing.Point(4, 78)
            Me.lblResTipoEgreso.Name = "lblResTipoEgreso"
            Me.lblResTipoEgreso.Size = New System.Drawing.Size(67, 13)
            Me.lblResTipoEgreso.TabIndex = 6
            Me.lblResTipoEgreso.Text = "Tipo Egreso:"
            Me.lblResTipoEgreso.Visible = False
            '
            'lblResSitJur
            '
            Me.lblResSitJur.AutoSize = True
            Me.lblResSitJur.ForeColor = System.Drawing.Color.Black
            Me.lblResSitJur.Location = New System.Drawing.Point(4, 53)
            Me.lblResSitJur.Name = "lblResSitJur"
            Me.lblResSitJur.Size = New System.Drawing.Size(64, 13)
            Me.lblResSitJur.TabIndex = 4
            Me.lblResSitJur.Text = "Sit. Juridica:"
            Me.lblResSitJur.Visible = False
            '
            'lblResFecIngreso
            '
            Me.lblResFecIngreso.AutoSize = True
            Me.lblResFecIngreso.ForeColor = System.Drawing.Color.Black
            Me.lblResFecIngreso.Location = New System.Drawing.Point(3, 30)
            Me.lblResFecIngreso.Name = "lblResFecIngreso"
            Me.lblResFecIngreso.Size = New System.Drawing.Size(69, 13)
            Me.lblResFecIngreso.TabIndex = 2
            Me.lblResFecIngreso.Text = "Fec. Ingreso:"
            Me.lblResFecIngreso.Visible = False
            '
            'lblResUltIngreso
            '
            Me.lblResUltIngreso.AutoSize = True
            Me.lblResUltIngreso.ForeColor = System.Drawing.Color.Black
            Me.lblResUltIngreso.Location = New System.Drawing.Point(3, 8)
            Me.lblResUltIngreso.Name = "lblResUltIngreso"
            Me.lblResUltIngreso.Size = New System.Drawing.Size(65, 13)
            Me.lblResUltIngreso.TabIndex = 0
            Me.lblResUltIngreso.Text = "N° Ult. Ing. :"
            Me.lblResUltIngreso.Visible = False
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.pnlCuerpoPrincipal)
            Me.pnlGrilla.Controls.Add(Me.pnlRegionPenal)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(1063, 553)
            Me.pnlGrilla.TabIndex = 0
            '
            'pnlCuerpoPrincipal
            '
            Me.pnlCuerpoPrincipal.Controls.Add(Me.tcBusqueda)
            Me.pnlCuerpoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCuerpoPrincipal.Location = New System.Drawing.Point(0, 29)
            Me.pnlCuerpoPrincipal.Name = "pnlCuerpoPrincipal"
            Me.pnlCuerpoPrincipal.Size = New System.Drawing.Size(1063, 524)
            Me.pnlCuerpoPrincipal.TabIndex = 0
            '
            'tcBusqueda
            '
            Me.tcBusqueda.Controls.Add(Me.tpBandeja)
            Me.tcBusqueda.Controls.Add(Me.tpConsultaInterno)
            Me.tcBusqueda.Controls.Add(Me.tpConsultaMovimiento)
            Me.tcBusqueda.Controls.Add(Me.tpConsultaConsReclu)
            Me.tcBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcBusqueda.ImageList = Me.ImageList1
            Me.tcBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.tcBusqueda.Multiline = True
            Me.tcBusqueda.Name = "tcBusqueda"
            Me.tcBusqueda.SelectedIndex = 0
            Me.tcBusqueda.Size = New System.Drawing.Size(1063, 524)
            Me.tcBusqueda.TabIndex = 0
            '
            'tpBandeja
            '
            Me.tpBandeja.Controls.Add(Me.dgwBandeja)
            Me.tpBandeja.ImageKey = "recibir.png"
            Me.tpBandeja.Location = New System.Drawing.Point(4, 27)
            Me.tpBandeja.Name = "tpBandeja"
            Me.tpBandeja.Padding = New System.Windows.Forms.Padding(3)
            Me.tpBandeja.Size = New System.Drawing.Size(1055, 493)
            Me.tpBandeja.TabIndex = 2
            Me.tpBandeja.Text = "Bandeja de entrada     "
            Me.tpBandeja.UseVisualStyleBackColor = True
            '
            'dgwBandeja
            '
            Me.dgwBandeja.AllowUserToAddRows = False
            Me.dgwBandeja.AllowUserToDeleteRows = False
            Me.dgwBandeja.AllowUserToResizeRows = False
            Me.dgwBandeja.BackgroundColor = System.Drawing.Color.White
            Me.dgwBandeja.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwBandeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwBandeja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bnd_col_mov_id, Me.col_reg_ori_id, Me.col_pen_ori_id, Me.col_doc_trs_num, Me.bnd_col_int_id, Me.col_pizq_arch_dig_id, Me.col_pfron_arch_dig_id, Me.col_pder_arch_dig_id, Me.col_pen_ori_nom, Me.col_cod, Me.col_ape_pat, Me.col_ape_mat, Me.col_int_nom, Me.col_doc_idn, Me.ban_fec_nac, Me.ban_tip_doc_id, Me.ban_num_doc_ident, Me.col_fec_mov_origen})
            Me.dgwBandeja.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwBandeja.Location = New System.Drawing.Point(3, 3)
            Me.dgwBandeja.MultiSelect = False
            Me.dgwBandeja.Name = "dgwBandeja"
            Me.dgwBandeja.ReadOnly = True
            Me.dgwBandeja.RowHeadersVisible = False
            Me.dgwBandeja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwBandeja.Size = New System.Drawing.Size(1049, 487)
            Me.dgwBandeja.TabIndex = 0
            Me.dgwBandeja.VisibleCampos = False
            '
            'bnd_col_mov_id
            '
            Me.bnd_col_mov_id.DataPropertyName = "mov_id"
            Me.bnd_col_mov_id.HeaderText = "MovimientoId"
            Me.bnd_col_mov_id.Name = "bnd_col_mov_id"
            Me.bnd_col_mov_id.ReadOnly = True
            Me.bnd_col_mov_id.Visible = False
            '
            'col_reg_ori_id
            '
            Me.col_reg_ori_id.DataPropertyName = "mov_reg_org_id"
            Me.col_reg_ori_id.HeaderText = "col_reg_ori_id"
            Me.col_reg_ori_id.Name = "col_reg_ori_id"
            Me.col_reg_ori_id.ReadOnly = True
            Me.col_reg_ori_id.Visible = False
            '
            'col_pen_ori_id
            '
            Me.col_pen_ori_id.DataPropertyName = "mov_pen_org"
            Me.col_pen_ori_id.HeaderText = "col_pen_ori_id"
            Me.col_pen_ori_id.Name = "col_pen_ori_id"
            Me.col_pen_ori_id.ReadOnly = True
            Me.col_pen_ori_id.Visible = False
            '
            'col_doc_trs_num
            '
            Me.col_doc_trs_num.DataPropertyName = "trs_doc_num"
            Me.col_doc_trs_num.HeaderText = "N° Doc. Traslado"
            Me.col_doc_trs_num.Name = "col_doc_trs_num"
            Me.col_doc_trs_num.ReadOnly = True
            Me.col_doc_trs_num.Width = 160
            '
            'bnd_col_int_id
            '
            Me.bnd_col_int_id.DataPropertyName = "int_id"
            Me.bnd_col_int_id.HeaderText = "InternoId"
            Me.bnd_col_int_id.Name = "bnd_col_int_id"
            Me.bnd_col_int_id.ReadOnly = True
            Me.bnd_col_int_id.Visible = False
            '
            'col_pizq_arch_dig_id
            '
            Me.col_pizq_arch_dig_id.DataPropertyName = "aut_fot_izq"
            Me.col_pizq_arch_dig_id.HeaderText = "PerfilIzq"
            Me.col_pizq_arch_dig_id.Name = "col_pizq_arch_dig_id"
            Me.col_pizq_arch_dig_id.ReadOnly = True
            Me.col_pizq_arch_dig_id.Visible = False
            '
            'col_pfron_arch_dig_id
            '
            Me.col_pfron_arch_dig_id.DataPropertyName = "aut_fot_fre"
            Me.col_pfron_arch_dig_id.HeaderText = "PerfilFron"
            Me.col_pfron_arch_dig_id.Name = "col_pfron_arch_dig_id"
            Me.col_pfron_arch_dig_id.ReadOnly = True
            Me.col_pfron_arch_dig_id.Visible = False
            '
            'col_pder_arch_dig_id
            '
            Me.col_pder_arch_dig_id.DataPropertyName = "aut_fot_der"
            Me.col_pder_arch_dig_id.HeaderText = "PerfilDer"
            Me.col_pder_arch_dig_id.Name = "col_pder_arch_dig_id"
            Me.col_pder_arch_dig_id.ReadOnly = True
            Me.col_pder_arch_dig_id.Visible = False
            '
            'col_pen_ori_nom
            '
            Me.col_pen_ori_nom.DataPropertyName = "pen_origen"
            Me.col_pen_ori_nom.HeaderText = "Origen"
            Me.col_pen_ori_nom.Name = "col_pen_ori_nom"
            Me.col_pen_ori_nom.ReadOnly = True
            Me.col_pen_ori_nom.Width = 250
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "int_cod_rp"
            Me.col_cod.HeaderText = "Código"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Width = 90
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "int_ape_pat"
            Me.col_ape_pat.HeaderText = "Primer apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Width = 150
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "int_ape_mat"
            Me.col_ape_mat.HeaderText = "Segundo apellido"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Width = 150
            '
            'col_int_nom
            '
            Me.col_int_nom.DataPropertyName = "int_nom"
            Me.col_int_nom.HeaderText = "Nombres"
            Me.col_int_nom.Name = "col_int_nom"
            Me.col_int_nom.ReadOnly = True
            Me.col_int_nom.Width = 150
            '
            'col_doc_idn
            '
            Me.col_doc_idn.DataPropertyName = "doc_ident"
            Me.col_doc_idn.HeaderText = "Doc.  identidad"
            Me.col_doc_idn.Name = "col_doc_idn"
            Me.col_doc_idn.ReadOnly = True
            Me.col_doc_idn.Width = 130
            '
            'ban_fec_nac
            '
            Me.ban_fec_nac.DataPropertyName = "int_fec_nac"
            Me.ban_fec_nac.HeaderText = "F. Nac."
            Me.ban_fec_nac.Name = "ban_fec_nac"
            Me.ban_fec_nac.ReadOnly = True
            Me.ban_fec_nac.Width = 90
            '
            'ban_tip_doc_id
            '
            Me.ban_tip_doc_id.DataPropertyName = "tip_doc_id"
            Me.ban_tip_doc_id.HeaderText = "TipoDocIdentId"
            Me.ban_tip_doc_id.Name = "ban_tip_doc_id"
            Me.ban_tip_doc_id.ReadOnly = True
            Me.ban_tip_doc_id.Visible = False
            '
            'ban_num_doc_ident
            '
            Me.ban_num_doc_ident.DataPropertyName = "int_doc_num"
            Me.ban_num_doc_ident.HeaderText = "NumDocIdent"
            Me.ban_num_doc_ident.Name = "ban_num_doc_ident"
            Me.ban_num_doc_ident.ReadOnly = True
            Me.ban_num_doc_ident.Visible = False
            '
            'col_fec_mov_origen
            '
            Me.col_fec_mov_origen.DataPropertyName = "fec_sal_mov_ori"
            Me.col_fec_mov_origen.HeaderText = "F. Traslado/Conduc."
            Me.col_fec_mov_origen.Name = "col_fec_mov_origen"
            Me.col_fec_mov_origen.ReadOnly = True
            Me.col_fec_mov_origen.Width = 140
            '
            'tpConsultaInterno
            '
            Me.tpConsultaInterno.BackColor = System.Drawing.SystemColors.Control
            Me.tpConsultaInterno.Controls.Add(Me.Panel2)
            Me.tpConsultaInterno.Controls.Add(Me.pnlBusqueda)
            Me.tpConsultaInterno.ImageKey = "internos-32-32.png"
            Me.tpConsultaInterno.Location = New System.Drawing.Point(4, 27)
            Me.tpConsultaInterno.Name = "tpConsultaInterno"
            Me.tpConsultaInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultaInterno.Size = New System.Drawing.Size(1055, 493)
            Me.tpConsultaInterno.TabIndex = 0
            Me.tpConsultaInterno.Text = "Consulta de internos"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.SystemColors.Control
            Me.Panel2.Controls.Add(Me.dgwGrilla)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(3, 149)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1049, 341)
            Me.Panel2.TabIndex = 1
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pdr, Me.col_int_id, Me.col_id_loc_row, Me.col_reg_id, Me.col_pen_id, Me.col_id_sed_row, Me.col_ver_int, Me.col_cod_rp, Me.Column1, Me.Column2, Me.col_ape, Me.col_nom, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column6, Me.col_fec_nac, Me.Column7, Me.Column17, Me.col_pabellon, Me.col_reg_nom, Me.col_pen_nom, Me.col_est_nom, Me.col_est_gen, Me.col_fot_ico_pi, Me.col_fot_ico_pf, Me.col_fot_ico_pd, Me.Column8})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.SkyBlue
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1049, 341)
            Me.dgwGrilla.TabIndex = 0
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_pdr
            '
            Me.col_pdr.DataPropertyName = "CodigoPadre"
            Me.col_pdr.DividerWidth = 1
            Me.col_pdr.HeaderText = "CodigoPadre"
            Me.col_pdr.Name = "col_pdr"
            Me.col_pdr.ReadOnly = True
            Me.col_pdr.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "Codigo"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "IDInterno"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            Me.col_int_id.Width = 90
            '
            'col_id_loc_row
            '
            Me.col_id_loc_row.DataPropertyName = "RowID"
            Me.col_id_loc_row.DividerWidth = 1
            Me.col_id_loc_row.HeaderText = "IDLocalRow"
            Me.col_id_loc_row.Name = "col_id_loc_row"
            Me.col_id_loc_row.ReadOnly = True
            Me.col_id_loc_row.Visible = False
            Me.col_id_loc_row.Width = 90
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "IDRegion"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            Me.col_reg_id.Width = 90
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "IDPenal"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            Me.col_pen_id.Width = 90
            '
            'col_id_sed_row
            '
            Me.col_id_sed_row.DataPropertyName = "SedeRowId"
            Me.col_id_sed_row.DividerWidth = 1
            Me.col_id_sed_row.HeaderText = "IDSedeRow"
            Me.col_id_sed_row.Name = "col_id_sed_row"
            Me.col_id_sed_row.ReadOnly = True
            Me.col_id_sed_row.Visible = False
            Me.col_id_sed_row.Width = 90
            '
            'col_ver_int
            '
            Me.col_ver_int.DataPropertyName = "VersionRegistro"
            Me.col_ver_int.DividerWidth = 1
            Me.col_ver_int.HeaderText = "Ver. Reg. Interno"
            Me.col_ver_int.Name = "col_ver_int"
            Me.col_ver_int.ReadOnly = True
            Me.col_ver_int.Visible = False
            '
            'col_cod_rp
            '
            Me.col_cod_rp.DataPropertyName = "CodigoRP"
            Me.col_cod_rp.DividerWidth = 1
            Me.col_cod_rp.HeaderText = "Codigo"
            Me.col_cod_rp.Name = "col_cod_rp"
            Me.col_cod_rp.ReadOnly = True
            Me.col_cod_rp.Width = 69
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "ApellidoPaterno"
            Me.Column1.HeaderText = "Primer Apellido"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 105
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "ApellidoMaterno"
            Me.Column2.HeaderText = "Segundo Apellido"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 115
            '
            'col_ape
            '
            Me.col_ape.DataPropertyName = "Apellidos"
            Me.col_ape.HeaderText = "Apellidos"
            Me.col_ape.Name = "col_ape"
            Me.col_ape.ReadOnly = True
            Me.col_ape.Visible = False
            Me.col_ape.Width = 130
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 130
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "SexoNombre"
            Me.Column3.HeaderText = "Sexo"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Visible = False
            Me.Column3.Width = 40
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "TipoDocumentoNombre"
            Me.Column4.HeaderText = "Tipo Documen."
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Visible = False
            Me.Column4.Width = 54
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "NumeroDocumento"
            Me.Column5.HeaderText = "Num. Documento"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Visible = False
            Me.Column5.Width = 60
            '
            'Column9
            '
            Me.Column9.DataPropertyName = "TipoDocumentoyNumeroDocumento"
            Me.Column9.HeaderText = "Doc. Identidad"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.Width = 110
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "Edad"
            Me.Column6.HeaderText = "Edad"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Visible = False
            Me.Column6.Width = 45
            '
            'col_fec_nac
            '
            Me.col_fec_nac.DataPropertyName = "FechaNacimiento"
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.col_fec_nac.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_nac.HeaderText = "F. Nac."
            Me.col_fec_nac.Name = "col_fec_nac"
            Me.col_fec_nac.ReadOnly = True
            Me.col_fec_nac.Width = 67
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "NacionalidadNombre"
            Me.Column7.HeaderText = "Nacionalidad"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Width = 70
            '
            'Column17
            '
            Me.Column17.DataPropertyName = "InternoAlias"
            Me.Column17.HeaderText = "Alias"
            Me.Column17.Name = "Column17"
            Me.Column17.ReadOnly = True
            Me.Column17.Visible = False
            '
            'col_pabellon
            '
            Me.col_pabellon.DataPropertyName = "PabellonNombre"
            Me.col_pabellon.HeaderText = "Pabellon"
            Me.col_pabellon.Name = "col_pabellon"
            Me.col_pabellon.ReadOnly = True
            Me.col_pabellon.Visible = False
            Me.col_pabellon.Width = 60
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Region"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.Visible = False
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Visible = False
            Me.col_pen_nom.Width = 85
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 60
            '
            'col_est_gen
            '
            Me.col_est_gen.DataPropertyName = "EstadoEspecificoNombre"
            Me.col_est_gen.HeaderText = "Est. Fisico"
            Me.col_est_gen.Name = "col_est_gen"
            Me.col_est_gen.ReadOnly = True
            Me.col_est_gen.ToolTipText = "Estado fisico del interno"
            '
            'col_fot_ico_pi
            '
            Me.col_fot_ico_pi.DataPropertyName = "FotoIconoPI"
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.NullValue = Nothing
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.col_fot_ico_pi.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fot_ico_pi.DividerWidth = 1
            Me.col_fot_ico_pi.HeaderText = "I."
            Me.col_fot_ico_pi.Name = "col_fot_ico_pi"
            Me.col_fot_ico_pi.ReadOnly = True
            Me.col_fot_ico_pi.ToolTipText = "Fotografia perfil izquierdo"
            Me.col_fot_ico_pi.Width = 17
            '
            'col_fot_ico_pf
            '
            Me.col_fot_ico_pf.DataPropertyName = "FotoIconoPF"
            Me.col_fot_ico_pf.DividerWidth = 1
            Me.col_fot_ico_pf.HeaderText = "F."
            Me.col_fot_ico_pf.Name = "col_fot_ico_pf"
            Me.col_fot_ico_pf.ReadOnly = True
            Me.col_fot_ico_pf.ToolTipText = "Fotografia perfil frontal"
            Me.col_fot_ico_pf.Width = 18
            '
            'col_fot_ico_pd
            '
            Me.col_fot_ico_pd.DataPropertyName = "FotoIconoPD"
            Me.col_fot_ico_pd.DividerWidth = 1
            Me.col_fot_ico_pd.HeaderText = "D."
            Me.col_fot_ico_pd.Name = "col_fot_ico_pd"
            Me.col_fot_ico_pd.ReadOnly = True
            Me.col_fot_ico_pd.ToolTipText = "Fotografia perfil derecho"
            Me.col_fot_ico_pd.Width = 18
            '
            'Column8
            '
            Me.Column8.DataPropertyName = "EstadoRnc"
            Me.Column8.HeaderText = "Reniec"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.Width = 41
            '
            'tpConsultaMovimiento
            '
            Me.tpConsultaMovimiento.BackColor = System.Drawing.SystemColors.Control
            Me.tpConsultaMovimiento.Controls.Add(Me.UscBusquedaMovimiento1)
            Me.tpConsultaMovimiento.ImageKey = "movimiento32x32.png"
            Me.tpConsultaMovimiento.Location = New System.Drawing.Point(4, 27)
            Me.tpConsultaMovimiento.Name = "tpConsultaMovimiento"
            Me.tpConsultaMovimiento.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultaMovimiento.Size = New System.Drawing.Size(1055, 493)
            Me.tpConsultaMovimiento.TabIndex = 1
            Me.tpConsultaMovimiento.Text = "Consulta de movimientos"
            '
            'UscBusquedaMovimiento1
            '
            Me.UscBusquedaMovimiento1._ColorFondoGrilla = System.Drawing.SystemColors.Control
            Me.UscBusquedaMovimiento1._IDPenal = CType(-1, Short)
            Me.UscBusquedaMovimiento1._IDRegion = CType(-1, Short)
            Me.UscBusquedaMovimiento1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscBusquedaMovimiento1.BackColor = System.Drawing.Color.Transparent
            Me.UscBusquedaMovimiento1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscBusquedaMovimiento1.EstadoID = 0
            Me.UscBusquedaMovimiento1.EstadoTramite = ""
            Me.UscBusquedaMovimiento1.EstadoTramiteID = -1
            Me.UscBusquedaMovimiento1.Location = New System.Drawing.Point(3, 3)
            Me.UscBusquedaMovimiento1.Name = "UscBusquedaMovimiento1"
            Me.UscBusquedaMovimiento1.Size = New System.Drawing.Size(1049, 487)
            Me.UscBusquedaMovimiento1.TabIndex = 0
            '
            'tpConsultaConsReclu
            '
            Me.tpConsultaConsReclu.Controls.Add(Me.UscConsultaTramite1)
            Me.tpConsultaConsReclu.Location = New System.Drawing.Point(4, 27)
            Me.tpConsultaConsReclu.Name = "tpConsultaConsReclu"
            Me.tpConsultaConsReclu.Size = New System.Drawing.Size(1055, 493)
            Me.tpConsultaConsReclu.TabIndex = 3
            Me.tpConsultaConsReclu.Text = "Consulta de Trámites de constancias de reclusión"
            Me.tpConsultaConsReclu.UseVisualStyleBackColor = True
            '
            'UscConsultaTramite1
            '
            Me.UscConsultaTramite1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscConsultaTramite1.Location = New System.Drawing.Point(0, 0)
            Me.UscConsultaTramite1.Name = "UscConsultaTramite1"
            Me.UscConsultaTramite1.Size = New System.Drawing.Size(1055, 493)
            Me.UscConsultaTramite1.TabIndex = 1
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "recibir.png")
            Me.ImageList1.Images.SetKeyName(1, "internos-32-32.png")
            Me.ImageList1.Images.SetKeyName(2, "movimiento32x32.png")
            '
            'pnlRegionPenal
            '
            Me.pnlRegionPenal.Controls.Add(Me.cbbRegion)
            Me.pnlRegionPenal.Controls.Add(Me.Label7)
            Me.pnlRegionPenal.Controls.Add(Me.cbbPenal)
            Me.pnlRegionPenal.Controls.Add(Me.Label34)
            Me.pnlRegionPenal.Controls.Add(Me.Label4)
            Me.pnlRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRegionPenal.Location = New System.Drawing.Point(0, 0)
            Me.pnlRegionPenal.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.pnlRegionPenal.Name = "pnlRegionPenal"
            Me.pnlRegionPenal.Size = New System.Drawing.Size(1063, 29)
            Me.pnlRegionPenal.TabIndex = 0
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
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(53, 3)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(189, 22)
            Me.cbbRegion.TabIndex = 1
            Me.cbbRegion.verToolTipItemSeleccionado = False
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label7.Location = New System.Drawing.Point(0, 26)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(1063, 3)
            Me.Label7.TabIndex = 0
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
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 238
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(330, 3)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(215, 22)
            Me.cbbPenal.TabIndex = 3
            Me.cbbPenal.verToolTipItemSeleccionado = False
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.ForeColor = System.Drawing.Color.Black
            Me.Label34.Location = New System.Drawing.Point(259, 7)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(51, 13)
            Me.Label34.TabIndex = 2
            Me.Label34.Text = "Penales :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(3, 7)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Región :"
            '
            'btnRefresBandeja
            '
            Me.btnRefresBandeja.BackColor = System.Drawing.SystemColors.Control
            Me.btnRefresBandeja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnRefresBandeja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnRefresBandeja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnRefresBandeja.ForeColor = System.Drawing.Color.Black
            Me.btnRefresBandeja.Image = Global.SIPPOPE.My.Resources.Resources.Refrescar
            Me.btnRefresBandeja.Location = New System.Drawing.Point(3, 1)
            Me.btnRefresBandeja.Name = "btnRefresBandeja"
            Me.btnRefresBandeja.Size = New System.Drawing.Size(101, 40)
            Me.btnRefresBandeja.TabIndex = 1
            Me.btnRefresBandeja.Text = "Refrescar bandeja"
            Me.btnRefresBandeja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnRefresBandeja.UseVisualStyleBackColor = False
            '
            'DataGridViewImageColumn2
            '
            Me.DataGridViewImageColumn2.HeaderText = "Nom. Asoc."
            Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
            Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
            Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn2.Width = 34
            '
            'pnlInferior
            '
            Me.pnlInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.pnlInferior.Controls.Add(Me.pnlStatusBar)
            Me.pnlInferior.Controls.Add(Me.pnlBotonesAccion)
            Me.pnlInferior.Controls.Add(Me.pnlBandeja)
            Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlInferior.Location = New System.Drawing.Point(0, 553)
            Me.pnlInferior.Name = "pnlInferior"
            Me.pnlInferior.Size = New System.Drawing.Size(1063, 43)
            Me.pnlInferior.TabIndex = 70
            '
            'pnlStatusBar
            '
            Me.pnlStatusBar.BackColor = System.Drawing.SystemColors.Control
            Me.pnlStatusBar.Controls.Add(Me.btnListarDescarga)
            Me.pnlStatusBar.Controls.Add(Me.StatusStrip1)
            Me.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlStatusBar.Location = New System.Drawing.Point(771, 0)
            Me.pnlStatusBar.Name = "pnlStatusBar"
            Me.pnlStatusBar.Size = New System.Drawing.Size(292, 43)
            Me.pnlStatusBar.TabIndex = 41
            '
            'btnListarDescarga
            '
            Me.btnListarDescarga.BackColor = System.Drawing.SystemColors.Control
            Me.btnListarDescarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnListarDescarga.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnListarDescarga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnListarDescarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnListarDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnListarDescarga.ForeColor = System.Drawing.Color.Black
            Me.btnListarDescarga.Image = Global.SIPPOPE.My.Resources.Resources._1316210268_go_bottom
            Me.btnListarDescarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnListarDescarga.Location = New System.Drawing.Point(132, 0)
            Me.btnListarDescarga.Name = "btnListarDescarga"
            Me.btnListarDescarga.Size = New System.Drawing.Size(160, 43)
            Me.btnListarDescarga.TabIndex = 68
            Me.btnListarDescarga.Text = "&Listado de Documentos Judiciales por la ORL"
            Me.btnListarDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnListarDescarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnListarDescarga.UseVisualStyleBackColor = False
            '
            'StatusStrip1
            '
            Me.StatusStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.StatusStrip1.Location = New System.Drawing.Point(6, 14)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Size = New System.Drawing.Size(282, 19)
            Me.StatusStrip1.TabIndex = 42
            Me.StatusStrip1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'pnlBandeja
            '
            Me.pnlBandeja.BackColor = System.Drawing.SystemColors.Control
            Me.pnlBandeja.Controls.Add(Me.btnDescargar)
            Me.pnlBandeja.Controls.Add(Me.btnRefresBandeja)
            Me.pnlBandeja.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBandeja.Location = New System.Drawing.Point(0, 0)
            Me.pnlBandeja.Name = "pnlBandeja"
            Me.pnlBandeja.Size = New System.Drawing.Size(206, 43)
            Me.pnlBandeja.TabIndex = 40
            '
            'btnDescargar
            '
            Me.btnDescargar.BackColor = System.Drawing.SystemColors.Control
            Me.btnDescargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnDescargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnDescargar.ForeColor = System.Drawing.Color.Black
            Me.btnDescargar.Image = Global.SIPPOPE.My.Resources.Resources.recibir
            Me.btnDescargar.Location = New System.Drawing.Point(105, 1)
            Me.btnDescargar.Name = "btnDescargar"
            Me.btnDescargar.Size = New System.Drawing.Size(101, 40)
            Me.btnDescargar.TabIndex = 2
            Me.btnDescargar.Text = "Recibir"
            Me.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnDescargar.UseVisualStyleBackColor = False
            '
            'pnlDetalle
            '
            Me.pnlDetalle.Controls.Add(Me.pnlGrilla)
            Me.pnlDetalle.Controls.Add(Me.pnlInferior)
            Me.pnlDetalle.Controls.Add(Me.pnlFotografia)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(1259, 596)
            Me.pnlDetalle.TabIndex = 0
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 143
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(232, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'MyComboBox1
            '
            Me.MyComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox1.FormattingEnabled = True
            Me.MyComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox1.Name = "MyComboBox1"
            Me.MyComboBox1.Size = New System.Drawing.Size(232, 21)
            Me.MyComboBox1.TabIndex = 2
            '
            'bgwDownloadData
            '
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemCR, Me.ToolStripSeparator1})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(330, 54)
            '
            'ToolStripMenuItemCR
            '
            Me.ToolStripMenuItemCR.Name = "ToolStripMenuItemCR"
            Me.ToolStripMenuItemCR.Size = New System.Drawing.Size(329, 22)
            Me.ToolStripMenuItemCR.Text = "Registro de solicitud de Constancia de Reclusión"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(326, 6)
            '
            'frmBuscar_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1259, 596)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Name = "frmBuscar_v2"
            Me.Text = "Busqueda - Penal LM"
            Me.pnlBusqueda.ResumeLayout(False)
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.grbSitJur.ResumeLayout(False)
            Me.grbSitJur.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.pnlBotonesAccion.ResumeLayout(False)
            Me.pnlBotonOtros.ResumeLayout(False)
            Me.pnlBotonReporte.ResumeLayout(False)
            Me.pnlBotonGrabar.ResumeLayout(False)
            Me.pnlFotografia.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlGrilla.ResumeLayout(False)
            Me.pnlCuerpoPrincipal.ResumeLayout(False)
            Me.tcBusqueda.ResumeLayout(False)
            Me.tpBandeja.ResumeLayout(False)
            CType(Me.dgwBandeja, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpConsultaInterno.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpConsultaMovimiento.ResumeLayout(False)
            Me.tpConsultaConsReclu.ResumeLayout(False)
            Me.pnlRegionPenal.ResumeLayout(False)
            Me.pnlRegionPenal.PerformLayout()
            Me.pnlInferior.ResumeLayout(False)
            Me.pnlStatusBar.ResumeLayout(False)
            Me.pnlBandeja.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents pnlBotonesAccion As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExtranjero As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPeruano As System.Windows.Forms.RadioButton
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents rdbEstadoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSexoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbMuj As System.Windows.Forms.RadioButton
        Friend WithEvents rdbHom As System.Windows.Forms.RadioButton
        Friend WithEvents rdbNacTodos As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbbDelitoEspecifico As APPControls.uscComboParametrica
        Friend WithEvents cbbDelitoGenerico As APPControls.uscComboParametrica
        Friend WithEvents grbSitJur As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSitJurTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSentenciado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbProcesado As System.Windows.Forms.RadioButton
        'Friend WithEvents UscGrillaCampo1 As APPControls.Grilla.uscGrillaCampo
        Friend WithEvents lblSegundo As System.Windows.Forms.Label
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnFicha As System.Windows.Forms.Button
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents pnlFotografia As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents rdbPD As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPF As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPI As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents pnlInferior As System.Windows.Forms.Panel
        Friend WithEvents pnlBotonGrabar As System.Windows.Forms.Panel
        Friend WithEvents pnlBotonReporte As System.Windows.Forms.Panel
        Friend WithEvents pnlBotonOtros As System.Windows.Forms.Panel
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents rdbSentProcs As System.Windows.Forms.RadioButton
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents txtAlias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents tcBusqueda As System.Windows.Forms.TabControl
        Friend WithEvents tpConsultaInterno As System.Windows.Forms.TabPage
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlCuerpoPrincipal As System.Windows.Forms.Panel
        Friend WithEvents tpConsultaMovimiento As System.Windows.Forms.TabPage
        Friend WithEvents UscBusquedaMovimiento1 As APPControls.Registro.PenalLM.uscBusquedaMovimientosPLM
        Friend WithEvents tpBandeja As System.Windows.Forms.TabPage
        Friend WithEvents btnRefresBandeja As System.Windows.Forms.Button
        Friend WithEvents dgwBandeja As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlBandeja As System.Windows.Forms.Panel
        Friend WithEvents btnDescargar As System.Windows.Forms.Button
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents btnVerifHuella As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
        Friend WithEvents StatusStrip1 As System.Windows.Forms.Label
        Friend WithEvents pnlRegionPenal As System.Windows.Forms.Panel
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents lblResFecEgreso As System.Windows.Forms.Label
        Friend WithEvents lblResTipoEgreso As System.Windows.Forms.Label
        Friend WithEvents lblResSitJur As System.Windows.Forms.Label
        Friend WithEvents lblResFecIngreso As System.Windows.Forms.Label
        Friend WithEvents lblResUltIngreso As System.Windows.Forms.Label
        Friend WithEvents txtFechaEgreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtTipoEgreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtIngresoFecha As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtIngresoNum As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSituacionJur As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents bgwDownloadData As System.ComponentModel.BackgroundWorker
        Friend WithEvents bnd_col_mov_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_ori_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_ori_id As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_trs_num As DataGridViewTextBoxColumn
        Friend WithEvents bnd_col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pizq_arch_dig_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pfron_arch_dig_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pder_arch_dig_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_ori_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_int_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_idn As DataGridViewTextBoxColumn
        Friend WithEvents ban_fec_nac As DataGridViewTextBoxColumn
        Friend WithEvents ban_tip_doc_id As DataGridViewTextBoxColumn
        Friend WithEvents ban_num_doc_ident As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_mov_origen As DataGridViewTextBoxColumn
        Friend WithEvents col_pdr As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_id_loc_row As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_id_sed_row As DataGridViewTextBoxColumn
        Friend WithEvents col_ver_int As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_rp As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents col_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents Column9 As DataGridViewTextBoxColumn
        Friend WithEvents Column6 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_nac As DataGridViewTextBoxColumn
        Friend WithEvents Column7 As DataGridViewTextBoxColumn
        Friend WithEvents Column17 As DataGridViewTextBoxColumn
        Friend WithEvents col_pabellon As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_est_gen As DataGridViewTextBoxColumn
        Friend WithEvents col_fot_ico_pi As DataGridViewImageColumn
        Friend WithEvents col_fot_ico_pf As DataGridViewImageColumn
        Friend WithEvents col_fot_ico_pd As DataGridViewImageColumn
        Friend WithEvents Column8 As DataGridViewTextBoxColumn
        Friend WithEvents btnListarDescarga As Button
        Friend WithEvents tpConsultaConsReclu As TabPage
        Friend WithEvents UscConsultaTramite1 As APPControls.Registro.ConsultaReclusion.uscConsultaTramite
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents ToolStripMenuItemCR As ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents btnTramite As Button
    End Class
End Namespace

