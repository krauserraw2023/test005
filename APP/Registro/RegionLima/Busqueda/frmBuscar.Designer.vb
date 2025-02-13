Namespace Registro.Main.Region
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.rdbNacTodos = New System.Windows.Forms.RadioButton()
            Me.rdbExtranjero = New System.Windows.Forms.RadioButton()
            Me.rdbPeruano = New System.Windows.Forms.RadioButton()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.rdbSexoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbMuj = New System.Windows.Forms.RadioButton()
            Me.rdbHom = New System.Windows.Forms.RadioButton()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbEstadoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbInactivo = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.txtAlias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cbbDelitoGenerico = New APPControls.uscComboParametrica()
            Me.cbbDelitoEspecifico = New APPControls.uscComboParametrica()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.grbSitJur = New System.Windows.Forms.GroupBox()
            Me.rdbSentProcs = New System.Windows.Forms.RadioButton()
            Me.rdbSitJurTodos = New System.Windows.Forms.RadioButton()
            Me.rdbSentenciado = New System.Windows.Forms.RadioButton()
            Me.rdbProcesado = New System.Windows.Forms.RadioButton()
            Me.pnlRegionPenal = New System.Windows.Forms.Panel()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblSegundo = New System.Windows.Forms.Label()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.pnlBotonesAccion = New System.Windows.Forms.Panel()
            Me.pblLeyenda = New System.Windows.Forms.Panel()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.pnlBotonOtros = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlBotonReporte = New System.Windows.Forms.Panel()
            Me.btnFicha = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlAnular = New System.Windows.Forms.Panel()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.pnlBotonModificar = New System.Windows.Forms.Panel()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.pnlNuevo = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
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
            Me.txtPenalClasificacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label24 = New System.Windows.Forms.Label()
            Me.txtFechaEgreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtTipoEgreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtSituacionJur = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtIngresoFecha = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtIngresoNum = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.pnlCuerpoPrincipal = New System.Windows.Forms.Panel()
            Me.tbcPrincipal = New System.Windows.Forms.TabControl()
            Me.tpConsultaMovimiento = New System.Windows.Forms.TabPage()
            Me.UscBusquedaMovimiento1 = New APPControls.Registro.Main.uscBusquedaMovimiento_LM()
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
            Me.tpAntecedente = New System.Windows.Forms.TabPage()
            Me.dgwGrillaCAJ = New Legolas.APPUIComponents.myDatagridView()
            Me.col_cod_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_aj_id_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_num_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_sol_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_imp_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_usu_caj = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dat_hist_migra = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.rbNoProPendMD = New System.Windows.Forms.RadioButton()
            Me.rbTupa = New System.Windows.Forms.RadioButton()
            Me.drbPositivo = New System.Windows.Forms.RadioButton()
            Me.rdbTodosTipAnt = New System.Windows.Forms.RadioButton()
            Me.rdbNegativo = New System.Windows.Forms.RadioButton()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbAnulado = New System.Windows.Forms.RadioButton()
            Me.rdbImpreso = New System.Windows.Forms.RadioButton()
            Me.rdbTerminado = New System.Windows.Forms.RadioButton()
            Me.rdbPendiente = New System.Windows.Forms.RadioButton()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtApePatCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaFinCAJ = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtNombresCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtApeMatCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label21 = New System.Windows.Forms.Label()
            Me.dtpFechaIniCAJ = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtInternoCodCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.txtDocSolicitudCAJ = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.pnlInferior = New System.Windows.Forms.Panel()
            Me.btnVerLibros = New System.Windows.Forms.Button()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.pnlBusqueda.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.grbSitJur.SuspendLayout()
            Me.pnlRegionPenal.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.pnlBotonesAccion.SuspendLayout()
            Me.pblLeyenda.SuspendLayout()
            Me.pnlBotonOtros.SuspendLayout()
            Me.pnlBotonReporte.SuspendLayout()
            Me.pnlAnular.SuspendLayout()
            Me.pnlBotonModificar.SuspendLayout()
            Me.pnlNuevo.SuspendLayout()
            Me.pnlFotografia.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            Me.pnlCuerpoPrincipal.SuspendLayout()
            Me.tbcPrincipal.SuspendLayout()
            Me.tpConsultaMovimiento.SuspendLayout()
            Me.tpConsultaInterno.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpAntecedente.SuspendLayout()
            CType(Me.dgwGrillaCAJ, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel6.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.pnlInferior.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.grbBusqueda)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(3, 3)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1049, 146)
            Me.pnlBusqueda.TabIndex = 37
            '
            'grbBusqueda
            '
            Me.grbBusqueda.Controls.Add(Me.GroupBox6)
            Me.grbBusqueda.Controls.Add(Me.GroupBox2)
            Me.grbBusqueda.Controls.Add(Me.GroupBox3)
            Me.grbBusqueda.Controls.Add(Me.grbEstado)
            Me.grbBusqueda.Controls.Add(Me.GroupBox8)
            Me.grbBusqueda.Controls.Add(Me.GroupBox7)
            Me.grbBusqueda.Controls.Add(Me.grbSitJur)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.grbBusqueda.Size = New System.Drawing.Size(1049, 146)
            Me.grbBusqueda.TabIndex = 1
            Me.grbBusqueda.TabStop = False
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.dtpFechaFin)
            Me.GroupBox6.Controls.Add(Me.Label6)
            Me.GroupBox6.Controls.Add(Me.dtpFechaIni)
            Me.GroupBox6.Controls.Add(Me.Label5)
            Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox6.Location = New System.Drawing.Point(557, 69)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(377, 43)
            Me.GroupBox6.TabIndex = 22
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Fecha de Ingreso"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFin.Location = New System.Drawing.Point(219, 19)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 24
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(169, 23)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 58
            Me.Label6.Text = "Hasta :"
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaIni.Location = New System.Drawing.Point(62, 19)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 23
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(9, 23)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "Desde :"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox2.Controls.Add(Me.rdbNacTodos)
            Me.GroupBox2.Controls.Add(Me.rdbExtranjero)
            Me.GroupBox2.Controls.Add(Me.rdbPeruano)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(250, 10)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(303, 60)
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
            Me.cbbNacionalidad.Location = New System.Drawing.Point(66, 35)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(232, 22)
            Me.cbbNacionalidad.TabIndex = 31
            '
            'rdbNacTodos
            '
            Me.rdbNacTodos.AutoSize = True
            Me.rdbNacTodos.Checked = True
            Me.rdbNacTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNacTodos.Location = New System.Drawing.Point(165, 13)
            Me.rdbNacTodos.Name = "rdbNacTodos"
            Me.rdbNacTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbNacTodos.TabIndex = 12
            Me.rdbNacTodos.TabStop = True
            Me.rdbNacTodos.Text = "[Todos]"
            Me.rdbNacTodos.UseVisualStyleBackColor = True
            '
            'rdbExtranjero
            '
            Me.rdbExtranjero.AutoSize = True
            Me.rdbExtranjero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExtranjero.Location = New System.Drawing.Point(82, 13)
            Me.rdbExtranjero.Name = "rdbExtranjero"
            Me.rdbExtranjero.Size = New System.Drawing.Size(77, 17)
            Me.rdbExtranjero.TabIndex = 11
            Me.rdbExtranjero.Text = "Extranjeros"
            Me.rdbExtranjero.UseVisualStyleBackColor = True
            '
            'rdbPeruano
            '
            Me.rdbPeruano.AutoSize = True
            Me.rdbPeruano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPeruano.Location = New System.Drawing.Point(6, 13)
            Me.rdbPeruano.Name = "rdbPeruano"
            Me.rdbPeruano.Size = New System.Drawing.Size(70, 17)
            Me.rdbPeruano.TabIndex = 10
            Me.rdbPeruano.Text = "Peruanos"
            Me.rdbPeruano.UseVisualStyleBackColor = True
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(1, 41)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(66, 13)
            Me.Label13.TabIndex = 34
            Me.Label13.Text = "Seleccione :"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rdbSexoTodos)
            Me.GroupBox3.Controls.Add(Me.rdbMuj)
            Me.GroupBox3.Controls.Add(Me.rdbHom)
            Me.GroupBox3.Location = New System.Drawing.Point(250, 69)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(303, 43)
            Me.GroupBox3.TabIndex = 13
            Me.GroupBox3.TabStop = False
            '
            'rdbSexoTodos
            '
            Me.rdbSexoTodos.AutoSize = True
            Me.rdbSexoTodos.Checked = True
            Me.rdbSexoTodos.Location = New System.Drawing.Point(171, 13)
            Me.rdbSexoTodos.Name = "rdbSexoTodos"
            Me.rdbSexoTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbSexoTodos.TabIndex = 16
            Me.rdbSexoTodos.TabStop = True
            Me.rdbSexoTodos.Text = "[Todos]"
            Me.rdbSexoTodos.UseVisualStyleBackColor = True
            '
            'rdbMuj
            '
            Me.rdbMuj.AutoSize = True
            Me.rdbMuj.Location = New System.Drawing.Point(87, 13)
            Me.rdbMuj.Name = "rdbMuj"
            Me.rdbMuj.Size = New System.Drawing.Size(62, 17)
            Me.rdbMuj.TabIndex = 15
            Me.rdbMuj.Text = "Mujeres"
            Me.rdbMuj.UseVisualStyleBackColor = True
            '
            'rdbHom
            '
            Me.rdbHom.AutoSize = True
            Me.rdbHom.Location = New System.Drawing.Point(6, 13)
            Me.rdbHom.Name = "rdbHom"
            Me.rdbHom.Size = New System.Drawing.Size(67, 17)
            Me.rdbHom.TabIndex = 14
            Me.rdbHom.Text = "Hombres"
            Me.rdbHom.UseVisualStyleBackColor = True
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbEstadoTodos)
            Me.grbEstado.Controls.Add(Me.rdbInactivo)
            Me.grbEstado.Controls.Add(Me.rdbActivo)
            Me.grbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbEstado.Location = New System.Drawing.Point(937, 9)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(109, 133)
            Me.grbEstado.TabIndex = 5
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado"
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Checked = True
            Me.rdbEstadoTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(25, 75)
            Me.rdbEstadoTodos.Name = "rdbEstadoTodos"
            Me.rdbEstadoTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbEstadoTodos.TabIndex = 8
            Me.rdbEstadoTodos.TabStop = True
            Me.rdbEstadoTodos.Text = "[Todos]"
            Me.rdbEstadoTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbInactivo.Location = New System.Drawing.Point(25, 50)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rdbInactivo.TabIndex = 7
            Me.rdbInactivo.Text = "Inactivo"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbActivo.Location = New System.Drawing.Point(25, 25)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(55, 17)
            Me.rdbActivo.TabIndex = 6
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.txtApeMat)
            Me.GroupBox8.Controls.Add(Me.txtNom)
            Me.GroupBox8.Controls.Add(Me.txtApePat)
            Me.GroupBox8.Controls.Add(Me.txtCodInterno)
            Me.GroupBox8.Controls.Add(Me.Label3)
            Me.GroupBox8.Controls.Add(Me.Label2)
            Me.GroupBox8.Controls.Add(Me.Label1)
            Me.GroupBox8.Controls.Add(Me.Label26)
            Me.GroupBox8.Location = New System.Drawing.Point(3, 10)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(245, 102)
            Me.GroupBox8.TabIndex = 17
            Me.GroupBox8.TabStop = False
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer))
            Me.txtApeMat.Location = New System.Drawing.Point(101, 55)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(140, 20)
            Me.txtApeMat.TabIndex = 20
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(101, 78)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(140, 20)
            Me.txtNom.TabIndex = 21
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.Location = New System.Drawing.Point(101, 32)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(140, 20)
            Me.txtApePat.TabIndex = 19
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = True
            Me.txtCodInterno.ForeColor = System.Drawing.Color.Black
            Me.txtCodInterno.Location = New System.Drawing.Point(101, 9)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.Size = New System.Drawing.Size(87, 20)
            Me.txtCodInterno.TabIndex = 18
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 82)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombres :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 59)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Segundo Apellido:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 36)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Primer Apellido :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(6, 12)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 33
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
            Me.GroupBox7.Size = New System.Drawing.Size(931, 39)
            Me.GroupBox7.TabIndex = 30
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
            Me.cbbDelitoGenerico.Location = New System.Drawing.Point(313, 12)
            Me.cbbDelitoGenerico.ModuloTratamiento = False
            Me.cbbDelitoGenerico.Name = "cbbDelitoGenerico"
            Me.cbbDelitoGenerico.Parametro1 = -1
            Me.cbbDelitoGenerico.Parametro2 = -1
            Me.cbbDelitoGenerico.SelectedIndex = -1
            Me.cbbDelitoGenerico.SelectedValue = 0
            Me.cbbDelitoGenerico.Size = New System.Drawing.Size(233, 22)
            Me.cbbDelitoGenerico.TabIndex = 3
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
            Me.cbbDelitoEspecifico.Location = New System.Drawing.Point(616, 12)
            Me.cbbDelitoEspecifico.ModuloTratamiento = False
            Me.cbbDelitoEspecifico.Name = "cbbDelitoEspecifico"
            Me.cbbDelitoEspecifico.Parametro1 = -1
            Me.cbbDelitoEspecifico.Parametro2 = -1
            Me.cbbDelitoEspecifico.SelectedIndex = -1
            Me.cbbDelitoEspecifico.SelectedValue = 0
            Me.cbbDelitoEspecifico.Size = New System.Drawing.Size(310, 22)
            Me.cbbDelitoEspecifico.TabIndex = 5
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
            Me.Label8.Location = New System.Drawing.Point(554, 8)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(62, 26)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Delito " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Especifico :"
            '
            'grbSitJur
            '
            Me.grbSitJur.Controls.Add(Me.rdbSentProcs)
            Me.grbSitJur.Controls.Add(Me.rdbSitJurTodos)
            Me.grbSitJur.Controls.Add(Me.rdbSentenciado)
            Me.grbSitJur.Controls.Add(Me.rdbProcesado)
            Me.grbSitJur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbSitJur.Location = New System.Drawing.Point(557, 10)
            Me.grbSitJur.Name = "grbSitJur"
            Me.grbSitJur.Size = New System.Drawing.Size(377, 60)
            Me.grbSitJur.TabIndex = 25
            Me.grbSitJur.TabStop = False
            Me.grbSitJur.Text = "Situacion Juridica"
            '
            'rdbSentProcs
            '
            Me.rdbSentProcs.AutoSize = True
            Me.rdbSentProcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSentProcs.Location = New System.Drawing.Point(198, 23)
            Me.rdbSentProcs.Name = "rdbSentProcs"
            Me.rdbSentProcs.Size = New System.Drawing.Size(80, 17)
            Me.rdbSentProcs.TabIndex = 29
            Me.rdbSentProcs.Text = "Sent./Proc."
            Me.rdbSentProcs.UseVisualStyleBackColor = True
            '
            'rdbSitJurTodos
            '
            Me.rdbSitJurTodos.AutoSize = True
            Me.rdbSitJurTodos.Checked = True
            Me.rdbSitJurTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSitJurTodos.Location = New System.Drawing.Point(293, 22)
            Me.rdbSitJurTodos.Name = "rdbSitJurTodos"
            Me.rdbSitJurTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbSitJurTodos.TabIndex = 28
            Me.rdbSitJurTodos.TabStop = True
            Me.rdbSitJurTodos.Text = "[Todos]"
            Me.rdbSitJurTodos.UseVisualStyleBackColor = True
            '
            'rdbSentenciado
            '
            Me.rdbSentenciado.AutoSize = True
            Me.rdbSentenciado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSentenciado.Location = New System.Drawing.Point(99, 25)
            Me.rdbSentenciado.Name = "rdbSentenciado"
            Me.rdbSentenciado.Size = New System.Drawing.Size(85, 17)
            Me.rdbSentenciado.TabIndex = 27
            Me.rdbSentenciado.Text = "Sentenciado"
            Me.rdbSentenciado.UseVisualStyleBackColor = True
            '
            'rdbProcesado
            '
            Me.rdbProcesado.AutoSize = True
            Me.rdbProcesado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbProcesado.Location = New System.Drawing.Point(6, 25)
            Me.rdbProcesado.Name = "rdbProcesado"
            Me.rdbProcesado.Size = New System.Drawing.Size(76, 17)
            Me.rdbProcesado.TabIndex = 26
            Me.rdbProcesado.Text = "Procesado"
            Me.rdbProcesado.UseVisualStyleBackColor = True
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
            Me.pnlRegionPenal.Size = New System.Drawing.Size(1063, 32)
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
            Me.cbbRegion.Location = New System.Drawing.Point(53, 5)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(189, 22)
            Me.cbbRegion.TabIndex = 1
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label7.Location = New System.Drawing.Point(0, 29)
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
            Me.cbbPenal.Location = New System.Drawing.Point(313, 6)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(232, 22)
            Me.cbbPenal.TabIndex = 3
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Location = New System.Drawing.Point(249, 10)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(51, 13)
            Me.Label34.TabIndex = 2
            Me.Label34.Text = "Penales :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(3, 10)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Region :"
            '
            'grbBuscar
            '
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
            Me.pnlBotonesAccion.Controls.Add(Me.pblLeyenda)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonOtros)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonReporte)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlAnular)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonModificar)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlNuevo)
            Me.pnlBotonesAccion.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonesAccion.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotonesAccion.Name = "pnlBotonesAccion"
            Me.pnlBotonesAccion.Size = New System.Drawing.Size(882, 47)
            Me.pnlBotonesAccion.TabIndex = 39
            '
            'pblLeyenda
            '
            Me.pblLeyenda.BackColor = System.Drawing.Color.White
            Me.pblLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pblLeyenda.Controls.Add(Me.Label25)
            Me.pblLeyenda.Controls.Add(Me.Label28)
            Me.pblLeyenda.Controls.Add(Me.Label29)
            Me.pblLeyenda.Controls.Add(Me.Label30)
            Me.pblLeyenda.Controls.Add(Me.Label31)
            Me.pblLeyenda.Controls.Add(Me.Label32)
            Me.pblLeyenda.Location = New System.Drawing.Point(541, 11)
            Me.pblLeyenda.Name = "pblLeyenda"
            Me.pblLeyenda.Size = New System.Drawing.Size(277, 29)
            Me.pblLeyenda.TabIndex = 87
            Me.pblLeyenda.Visible = False
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(32, 7)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(57, 13)
            Me.Label25.TabIndex = 84
            Me.Label25.Text = "Terminado"
            '
            'Label28
            '
            Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label28.Location = New System.Drawing.Point(7, 3)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(22, 21)
            Me.Label28.TabIndex = 85
            '
            'Label29
            '
            Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label29.Location = New System.Drawing.Point(97, 3)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(22, 21)
            Me.Label29.TabIndex = 85
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(206, 7)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(46, 13)
            Me.Label30.TabIndex = 84
            Me.Label30.Text = "Anulado"
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(122, 7)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(44, 13)
            Me.Label31.TabIndex = 84
            Me.Label31.Text = "Impreso"
            '
            'Label32
            '
            Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer))
            Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label32.Location = New System.Drawing.Point(181, 3)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(22, 21)
            Me.Label32.TabIndex = 85
            '
            'pnlBotonOtros
            '
            Me.pnlBotonOtros.Controls.Add(Me.btnSalir)
            Me.pnlBotonOtros.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonOtros.Location = New System.Drawing.Point(456, 0)
            Me.pnlBotonOtros.Name = "pnlBotonOtros"
            Me.pnlBotonOtros.Size = New System.Drawing.Size(84, 47)
            Me.pnlBotonOtros.TabIndex = 72
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(2, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlBotonReporte
            '
            Me.pnlBotonReporte.Controls.Add(Me.btnFicha)
            Me.pnlBotonReporte.Controls.Add(Me.btnExportar)
            Me.pnlBotonReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonReporte.Location = New System.Drawing.Point(273, 0)
            Me.pnlBotonReporte.Name = "pnlBotonReporte"
            Me.pnlBotonReporte.Size = New System.Drawing.Size(183, 47)
            Me.pnlBotonReporte.TabIndex = 71
            '
            'btnFicha
            '
            Me.btnFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFicha.Image = CType(resources.GetObject("btnFicha.Image"), System.Drawing.Image)
            Me.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.Location = New System.Drawing.Point(91, 5)
            Me.btnFicha.Name = "btnFicha"
            Me.btnFicha.Size = New System.Drawing.Size(90, 40)
            Me.btnFicha.TabIndex = 67
            Me.btnFicha.Text = "&Reporte"
            Me.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnFicha.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(1, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlAnular
            '
            Me.pnlAnular.BackColor = System.Drawing.SystemColors.Control
            Me.pnlAnular.Controls.Add(Me.btnAnular)
            Me.pnlAnular.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAnular.Location = New System.Drawing.Point(180, 0)
            Me.pnlAnular.Name = "pnlAnular"
            Me.pnlAnular.Size = New System.Drawing.Size(93, 47)
            Me.pnlAnular.TabIndex = 89
            Me.pnlAnular.Visible = False
            '
            'btnAnular
            '
            Me.btnAnular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnAnular.Location = New System.Drawing.Point(0, 5)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(93, 40)
            Me.btnAnular.TabIndex = 0
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlBotonModificar
            '
            Me.pnlBotonModificar.Controls.Add(Me.btnModificar)
            Me.pnlBotonModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonModificar.Location = New System.Drawing.Point(87, 0)
            Me.pnlBotonModificar.Name = "pnlBotonModificar"
            Me.pnlBotonModificar.Size = New System.Drawing.Size(93, 47)
            Me.pnlBotonModificar.TabIndex = 70
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.Location = New System.Drawing.Point(2, 5)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'pnlNuevo
            '
            Me.pnlNuevo.Controls.Add(Me.btnNuevo)
            Me.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlNuevo.Location = New System.Drawing.Point(0, 0)
            Me.pnlNuevo.Name = "pnlNuevo"
            Me.pnlNuevo.Size = New System.Drawing.Size(87, 47)
            Me.pnlNuevo.TabIndex = 88
            Me.pnlNuevo.Visible = False
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(1, 5)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(86, 40)
            Me.btnNuevo.TabIndex = 64
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
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
            Me.GroupBox1.Controls.Add(Me.UscFotografia_2v1)
            Me.GroupBox1.Controls.Add(Me.Panel4)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 189)
            Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox1.Size = New System.Drawing.Size(196, 257)
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
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(190, 218)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 0
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.rdbPD)
            Me.Panel4.Controls.Add(Me.rdbPF)
            Me.Panel4.Controls.Add(Me.rdbPI)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel4.Location = New System.Drawing.Point(3, 231)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(190, 23)
            Me.Panel4.TabIndex = 0
            '
            'rdbPD
            '
            Me.rdbPD.AutoSize = True
            Me.rdbPD.Location = New System.Drawing.Point(74, 3)
            Me.rdbPD.Name = "rdbPD"
            Me.rdbPD.Size = New System.Drawing.Size(40, 17)
            Me.rdbPD.TabIndex = 2
            Me.rdbPD.Text = "PD"
            Me.ToolTip1.SetToolTip(Me.rdbPD, "Ver foto del perfil derecho")
            Me.rdbPD.UseVisualStyleBackColor = True
            '
            'rdbPF
            '
            Me.rdbPF.AutoSize = True
            Me.rdbPF.Checked = True
            Me.rdbPF.Location = New System.Drawing.Point(37, 3)
            Me.rdbPF.Name = "rdbPF"
            Me.rdbPF.Size = New System.Drawing.Size(38, 17)
            Me.rdbPF.TabIndex = 1
            Me.rdbPF.TabStop = True
            Me.rdbPF.Text = "PF"
            Me.ToolTip1.SetToolTip(Me.rdbPF, "Ver foto del perfil frontal")
            Me.rdbPF.UseVisualStyleBackColor = True
            '
            'rdbPI
            '
            Me.rdbPI.AutoSize = True
            Me.rdbPI.Location = New System.Drawing.Point(3, 3)
            Me.rdbPI.Name = "rdbPI"
            Me.rdbPI.Size = New System.Drawing.Size(35, 17)
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
            Me.Panel5.Controls.Add(Me.txtPenalClasificacion)
            Me.Panel5.Controls.Add(Me.Label24)
            Me.Panel5.Controls.Add(Me.txtFechaEgreso)
            Me.Panel5.Controls.Add(Me.Label15)
            Me.Panel5.Controls.Add(Me.txtTipoEgreso)
            Me.Panel5.Controls.Add(Me.Label14)
            Me.Panel5.Controls.Add(Me.txtSituacionJur)
            Me.Panel5.Controls.Add(Me.txtIngresoFecha)
            Me.Panel5.Controls.Add(Me.Label12)
            Me.Panel5.Controls.Add(Me.Label11)
            Me.Panel5.Controls.Add(Me.Label10)
            Me.Panel5.Controls.Add(Me.txtIngresoNum)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 446)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(196, 150)
            Me.Panel5.TabIndex = 1
            '
            'txtPenalClasificacion
            '
            Me.txtPenalClasificacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPenalClasificacion._BloquearPaste = False
            Me.txtPenalClasificacion._SeleccionarTodo = True
            Me.txtPenalClasificacion.ForeColor = System.Drawing.Color.Black
            Me.txtPenalClasificacion.Location = New System.Drawing.Point(72, 75)
            Me.txtPenalClasificacion.Name = "txtPenalClasificacion"
            Me.txtPenalClasificacion.ReadOnly = True
            Me.txtPenalClasificacion.Size = New System.Drawing.Size(120, 20)
            Me.txtPenalClasificacion.TabIndex = 11
            Me.txtPenalClasificacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtPenalClasificacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Location = New System.Drawing.Point(3, 79)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(68, 13)
            Me.Label24.TabIndex = 10
            Me.Label24.Text = "Penal Clasif.:"
            '
            'txtFechaEgreso
            '
            Me.txtFechaEgreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaEgreso._BloquearPaste = False
            Me.txtFechaEgreso._SeleccionarTodo = True
            Me.txtFechaEgreso.ForeColor = System.Drawing.Color.Black
            Me.txtFechaEgreso.Location = New System.Drawing.Point(72, 99)
            Me.txtFechaEgreso.Name = "txtFechaEgreso"
            Me.txtFechaEgreso.ReadOnly = True
            Me.txtFechaEgreso.Size = New System.Drawing.Size(120, 20)
            Me.txtFechaEgreso.TabIndex = 9
            Me.txtFechaEgreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaEgreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.txtFechaEgreso.Visible = False
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(3, 103)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(67, 13)
            Me.Label15.TabIndex = 8
            Me.Label15.Text = "Fec. Egreso:"
            Me.Label15.Visible = False
            '
            'txtTipoEgreso
            '
            Me.txtTipoEgreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoEgreso._BloquearPaste = False
            Me.txtTipoEgreso._SeleccionarTodo = True
            Me.txtTipoEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoEgreso.ForeColor = System.Drawing.Color.Black
            Me.txtTipoEgreso.Location = New System.Drawing.Point(71, 123)
            Me.txtTipoEgreso.Name = "txtTipoEgreso"
            Me.txtTipoEgreso.ReadOnly = True
            Me.txtTipoEgreso.Size = New System.Drawing.Size(120, 20)
            Me.txtTipoEgreso.TabIndex = 7
            Me.txtTipoEgreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTipoEgreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.txtTipoEgreso.Visible = False
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(2, 127)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(67, 13)
            Me.Label14.TabIndex = 6
            Me.Label14.Text = "Tipo Egreso:"
            Me.Label14.Visible = False
            '
            'txtSituacionJur
            '
            Me.txtSituacionJur._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSituacionJur._BloquearPaste = False
            Me.txtSituacionJur._SeleccionarTodo = True
            Me.txtSituacionJur.ForeColor = System.Drawing.Color.Black
            Me.txtSituacionJur.Location = New System.Drawing.Point(71, 51)
            Me.txtSituacionJur.Name = "txtSituacionJur"
            Me.txtSituacionJur.ReadOnly = True
            Me.txtSituacionJur.Size = New System.Drawing.Size(120, 20)
            Me.txtSituacionJur.TabIndex = 5
            Me.txtSituacionJur.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSituacionJur.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtIngresoFecha
            '
            Me.txtIngresoFecha._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIngresoFecha._BloquearPaste = False
            Me.txtIngresoFecha._SeleccionarTodo = True
            Me.txtIngresoFecha.ForeColor = System.Drawing.Color.Black
            Me.txtIngresoFecha.Location = New System.Drawing.Point(71, 27)
            Me.txtIngresoFecha.Name = "txtIngresoFecha"
            Me.txtIngresoFecha.ReadOnly = True
            Me.txtIngresoFecha.Size = New System.Drawing.Size(120, 20)
            Me.txtIngresoFecha.TabIndex = 3
            Me.txtIngresoFecha.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIngresoFecha.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(2, 55)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(64, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Sit. Juridica:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(1, 30)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(69, 13)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Fec. Ingreso:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(1, 7)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(65, 13)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "N° Ult. Ing. :"
            '
            'txtIngresoNum
            '
            Me.txtIngresoNum._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIngresoNum._BloquearPaste = False
            Me.txtIngresoNum._SeleccionarTodo = True
            Me.txtIngresoNum.ForeColor = System.Drawing.Color.Black
            Me.txtIngresoNum.Location = New System.Drawing.Point(71, 3)
            Me.txtIngresoNum.Name = "txtIngresoNum"
            Me.txtIngresoNum.ReadOnly = True
            Me.txtIngresoNum.Size = New System.Drawing.Size(120, 20)
            Me.txtIngresoNum.TabIndex = 1
            Me.txtIngresoNum.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIngresoNum.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.pnlCuerpoPrincipal)
            Me.pnlGrilla.Controls.Add(Me.pnlRegionPenal)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(1063, 549)
            Me.pnlGrilla.TabIndex = 41
            '
            'pnlCuerpoPrincipal
            '
            Me.pnlCuerpoPrincipal.Controls.Add(Me.tbcPrincipal)
            Me.pnlCuerpoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCuerpoPrincipal.Location = New System.Drawing.Point(0, 32)
            Me.pnlCuerpoPrincipal.Name = "pnlCuerpoPrincipal"
            Me.pnlCuerpoPrincipal.Size = New System.Drawing.Size(1063, 517)
            Me.pnlCuerpoPrincipal.TabIndex = 44
            '
            'tbcPrincipal
            '
            Me.tbcPrincipal.Controls.Add(Me.tpConsultaMovimiento)
            Me.tbcPrincipal.Controls.Add(Me.tpConsultaInterno)
            Me.tbcPrincipal.Controls.Add(Me.tpAntecedente)
            Me.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbcPrincipal.ImageList = Me.ImageList1
            Me.tbcPrincipal.Location = New System.Drawing.Point(0, 0)
            Me.tbcPrincipal.Name = "tbcPrincipal"
            Me.tbcPrincipal.SelectedIndex = 0
            Me.tbcPrincipal.Size = New System.Drawing.Size(1063, 517)
            Me.tbcPrincipal.TabIndex = 0
            '
            'tpConsultaMovimiento
            '
            Me.tpConsultaMovimiento.Controls.Add(Me.UscBusquedaMovimiento1)
            Me.tpConsultaMovimiento.ImageKey = "movimiento32x32.png"
            Me.tpConsultaMovimiento.Location = New System.Drawing.Point(4, 27)
            Me.tpConsultaMovimiento.Name = "tpConsultaMovimiento"
            Me.tpConsultaMovimiento.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultaMovimiento.Size = New System.Drawing.Size(1055, 486)
            Me.tpConsultaMovimiento.TabIndex = 1
            Me.tpConsultaMovimiento.Text = "Consulta de movimientos"
            Me.tpConsultaMovimiento.UseVisualStyleBackColor = True
            '
            'UscBusquedaMovimiento1
            '
            Me.UscBusquedaMovimiento1._ColorFondoGrilla = System.Drawing.Color.White
            Me.UscBusquedaMovimiento1._IDPenal = -1
            Me.UscBusquedaMovimiento1._IDRegion = -1
            Me.UscBusquedaMovimiento1._PerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscBusquedaMovimiento1._TipoBusqueda = False
            Me.UscBusquedaMovimiento1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscBusquedaMovimiento1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscBusquedaMovimiento1.Location = New System.Drawing.Point(3, 3)
            Me.UscBusquedaMovimiento1.Name = "UscBusquedaMovimiento1"
            Me.UscBusquedaMovimiento1.Size = New System.Drawing.Size(1049, 480)
            Me.UscBusquedaMovimiento1.TabIndex = 0
            '
            'tpConsultaInterno
            '
            Me.tpConsultaInterno.Controls.Add(Me.Panel2)
            Me.tpConsultaInterno.Controls.Add(Me.pnlBusqueda)
            Me.tpConsultaInterno.ImageIndex = 1
            Me.tpConsultaInterno.Location = New System.Drawing.Point(4, 27)
            Me.tpConsultaInterno.Name = "tpConsultaInterno"
            Me.tpConsultaInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultaInterno.Size = New System.Drawing.Size(1055, 486)
            Me.tpConsultaInterno.TabIndex = 0
            Me.tpConsultaInterno.Text = "Consulta de internos"
            Me.tpConsultaInterno.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.dgwGrilla)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(3, 149)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1049, 334)
            Me.Panel2.TabIndex = 38
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pdr, Me.col_int_id, Me.col_id_loc_row, Me.col_reg_id, Me.col_pen_id, Me.col_id_sed_row, Me.col_ver_int, Me.col_cod_rp, Me.Column1, Me.Column2, Me.col_ape, Me.col_nom, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column6, Me.col_fec_nac, Me.Column7, Me.Column17, Me.col_pabellon, Me.col_reg_nom, Me.col_pen_nom, Me.col_est_nom, Me.col_est_gen, Me.col_fot_ico_pi, Me.col_fot_ico_pf, Me.col_fot_ico_pd, Me.Column8})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1049, 334)
            Me.dgwGrilla.TabIndex = 38
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
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_id_loc_row
            '
            Me.col_id_loc_row.DataPropertyName = "RowID"
            Me.col_id_loc_row.DividerWidth = 1
            Me.col_id_loc_row.HeaderText = "IDLocalRow"
            Me.col_id_loc_row.Name = "col_id_loc_row"
            Me.col_id_loc_row.ReadOnly = True
            Me.col_id_loc_row.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "IDRegion"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "IDPenal"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_id_sed_row
            '
            Me.col_id_sed_row.DataPropertyName = "SedeRowId"
            Me.col_id_sed_row.DividerWidth = 1
            Me.col_id_sed_row.HeaderText = "IDSedeRow"
            Me.col_id_sed_row.Name = "col_id_sed_row"
            Me.col_id_sed_row.ReadOnly = True
            Me.col_id_sed_row.Visible = False
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
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.col_fec_nac.DefaultCellStyle = DataGridViewCellStyle2
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
            Me.col_est_nom.Visible = False
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
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.col_fot_ico_pi.DefaultCellStyle = DataGridViewCellStyle3
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
            'tpAntecedente
            '
            Me.tpAntecedente.Controls.Add(Me.dgwGrillaCAJ)
            Me.tpAntecedente.Controls.Add(Me.Panel6)
            Me.tpAntecedente.ImageIndex = 3
            Me.tpAntecedente.Location = New System.Drawing.Point(4, 27)
            Me.tpAntecedente.Name = "tpAntecedente"
            Me.tpAntecedente.Padding = New System.Windows.Forms.Padding(3)
            Me.tpAntecedente.Size = New System.Drawing.Size(1055, 486)
            Me.tpAntecedente.TabIndex = 2
            Me.tpAntecedente.Text = "Antecedentes judiciales"
            Me.tpAntecedente.UseVisualStyleBackColor = True
            '
            'dgwGrillaCAJ
            '
            Me.dgwGrillaCAJ.AllowUserToAddRows = False
            Me.dgwGrillaCAJ.AllowUserToDeleteRows = False
            Me.dgwGrillaCAJ.AllowUserToResizeRows = False
            Me.dgwGrillaCAJ.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaCAJ.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaCAJ.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwGrillaCAJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaCAJ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cod_caj, Me.col_est_id_caj, Me.col_est_caj, Me.col_tip_aj_id_caj, Me.col_tip_caj, Me.col_sol_num_caj, Me.col_fec_sol_caj, Me.col_ape_pat_caj, Me.col_ape_mat_caj, Me.col_nom_caj, Me.col_num_imp_caj, Me.col_cod_usu_caj, Me.col_dat_hist_migra})
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaCAJ.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgwGrillaCAJ.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaCAJ.Location = New System.Drawing.Point(3, 131)
            Me.dgwGrillaCAJ.MultiSelect = False
            Me.dgwGrillaCAJ.Name = "dgwGrillaCAJ"
            Me.dgwGrillaCAJ.ReadOnly = True
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaCAJ.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgwGrillaCAJ.RowHeadersVisible = False
            Me.dgwGrillaCAJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaCAJ.Size = New System.Drawing.Size(1049, 352)
            Me.dgwGrillaCAJ.TabIndex = 76
            Me.dgwGrillaCAJ.VisibleCampos = False
            '
            'col_cod_caj
            '
            Me.col_cod_caj.DataPropertyName = "Codigo"
            Me.col_cod_caj.HeaderText = "Codigo"
            Me.col_cod_caj.Name = "col_cod_caj"
            Me.col_cod_caj.ReadOnly = True
            Me.col_cod_caj.Visible = False
            '
            'col_est_id_caj
            '
            Me.col_est_id_caj.DataPropertyName = "EstadoSolicitudId"
            Me.col_est_id_caj.DividerWidth = 1
            Me.col_est_id_caj.HeaderText = "estadoId"
            Me.col_est_id_caj.Name = "col_est_id_caj"
            Me.col_est_id_caj.ReadOnly = True
            Me.col_est_id_caj.Visible = False
            '
            'col_est_caj
            '
            Me.col_est_caj.HeaderText = "Est."
            Me.col_est_caj.Name = "col_est_caj"
            Me.col_est_caj.ReadOnly = True
            Me.col_est_caj.Width = 30
            '
            'col_tip_aj_id_caj
            '
            Me.col_tip_aj_id_caj.DataPropertyName = "TipoAntecedenteId"
            Me.col_tip_aj_id_caj.HeaderText = "TipoAjId"
            Me.col_tip_aj_id_caj.Name = "col_tip_aj_id_caj"
            Me.col_tip_aj_id_caj.ReadOnly = True
            Me.col_tip_aj_id_caj.Visible = False
            '
            'col_tip_caj
            '
            Me.col_tip_caj.DataPropertyName = "TipoAntecedenteStr"
            Me.col_tip_caj.HeaderText = "Tipo de antecedente"
            Me.col_tip_caj.Name = "col_tip_caj"
            Me.col_tip_caj.ReadOnly = True
            Me.col_tip_caj.Width = 150
            '
            'col_sol_num_caj
            '
            Me.col_sol_num_caj.DataPropertyName = "NumSolicitudStr"
            Me.col_sol_num_caj.HeaderText = "N° Solicitud"
            Me.col_sol_num_caj.Name = "col_sol_num_caj"
            Me.col_sol_num_caj.ReadOnly = True
            '
            'col_fec_sol_caj
            '
            Me.col_fec_sol_caj.DataPropertyName = "FechaSolicitudStr"
            Me.col_fec_sol_caj.HeaderText = "Fecha solicitud"
            Me.col_fec_sol_caj.Name = "col_fec_sol_caj"
            Me.col_fec_sol_caj.ReadOnly = True
            Me.col_fec_sol_caj.Width = 90
            '
            'col_ape_pat_caj
            '
            Me.col_ape_pat_caj.DataPropertyName = "InternoApePaterno"
            Me.col_ape_pat_caj.HeaderText = "Primer Ap."
            Me.col_ape_pat_caj.Name = "col_ape_pat_caj"
            Me.col_ape_pat_caj.ReadOnly = True
            Me.col_ape_pat_caj.Width = 150
            '
            'col_ape_mat_caj
            '
            Me.col_ape_mat_caj.DataPropertyName = "InternoApeMaterno"
            Me.col_ape_mat_caj.HeaderText = "Segundo Ap."
            Me.col_ape_mat_caj.Name = "col_ape_mat_caj"
            Me.col_ape_mat_caj.ReadOnly = True
            Me.col_ape_mat_caj.Width = 150
            '
            'col_nom_caj
            '
            Me.col_nom_caj.DataPropertyName = "InternoNombres"
            Me.col_nom_caj.HeaderText = "Nombre(s)"
            Me.col_nom_caj.Name = "col_nom_caj"
            Me.col_nom_caj.ReadOnly = True
            Me.col_nom_caj.Width = 150
            '
            'col_num_imp_caj
            '
            Me.col_num_imp_caj.DataPropertyName = "NumImpresiones"
            Me.col_num_imp_caj.HeaderText = "N° Impr."
            Me.col_num_imp_caj.Name = "col_num_imp_caj"
            Me.col_num_imp_caj.ReadOnly = True
            Me.col_num_imp_caj.Width = 40
            '
            'col_cod_usu_caj
            '
            Me.col_cod_usu_caj.DataPropertyName = "UsuarioCrea"
            Me.col_cod_usu_caj.HeaderText = "Usuario"
            Me.col_cod_usu_caj.Name = "col_cod_usu_caj"
            Me.col_cod_usu_caj.ReadOnly = True
            Me.col_cod_usu_caj.Width = 190
            '
            'col_dat_hist_migra
            '
            Me.col_dat_hist_migra.DataPropertyName = "DataHistoricaMigracion"
            Me.col_dat_hist_migra.HeaderText = "col_dat_hist_migra"
            Me.col_dat_hist_migra.Name = "col_dat_hist_migra"
            Me.col_dat_hist_migra.ReadOnly = True
            Me.col_dat_hist_migra.Visible = False
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.GroupBox4)
            Me.Panel6.Controls.Add(Me.GroupBox5)
            Me.Panel6.Controls.Add(Me.GroupBox9)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(3, 3)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(1049, 128)
            Me.Panel6.TabIndex = 1
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.rbNoProPendMD)
            Me.GroupBox4.Controls.Add(Me.rbTupa)
            Me.GroupBox4.Controls.Add(Me.drbPositivo)
            Me.GroupBox4.Controls.Add(Me.rdbTodosTipAnt)
            Me.GroupBox4.Controls.Add(Me.rdbNegativo)
            Me.GroupBox4.Location = New System.Drawing.Point(3, 5)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(444, 36)
            Me.GroupBox4.TabIndex = 65
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Tipo antecedente"
            '
            'rbNoProPendMD
            '
            Me.rbNoProPendMD.AutoSize = True
            Me.rbNoProPendMD.Location = New System.Drawing.Point(79, 13)
            Me.rbNoProPendMD.Name = "rbNoProPendMD"
            Me.rbNoProPendMD.Size = New System.Drawing.Size(124, 17)
            Me.rbNoProPendMD.TabIndex = 4
            Me.rbNoProPendMD.TabStop = True
            Me.rbNoProPendMD.Text = "No Registra P.P.M.D"
            Me.rbNoProPendMD.UseVisualStyleBackColor = True
            '
            'rbTupa
            '
            Me.rbTupa.AutoSize = True
            Me.rbTupa.Location = New System.Drawing.Point(6, 13)
            Me.rbTupa.Name = "rbTupa"
            Me.rbTupa.Size = New System.Drawing.Size(50, 17)
            Me.rbTupa.TabIndex = 3
            Me.rbTupa.TabStop = True
            Me.rbTupa.Text = "Tupa"
            Me.rbTupa.UseVisualStyleBackColor = True
            '
            'drbPositivo
            '
            Me.drbPositivo.AutoSize = True
            Me.drbPositivo.Location = New System.Drawing.Point(209, 13)
            Me.drbPositivo.Name = "drbPositivo"
            Me.drbPositivo.Size = New System.Drawing.Size(62, 17)
            Me.drbPositivo.TabIndex = 2
            Me.drbPositivo.TabStop = True
            Me.drbPositivo.Text = "Positivo"
            Me.drbPositivo.UseVisualStyleBackColor = True
            '
            'rdbTodosTipAnt
            '
            Me.rdbTodosTipAnt.AutoSize = True
            Me.rdbTodosTipAnt.Checked = True
            Me.rdbTodosTipAnt.Location = New System.Drawing.Point(360, 13)
            Me.rdbTodosTipAnt.Name = "rdbTodosTipAnt"
            Me.rdbTodosTipAnt.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodosTipAnt.TabIndex = 1
            Me.rdbTodosTipAnt.TabStop = True
            Me.rdbTodosTipAnt.Text = "[Todos]"
            Me.rdbTodosTipAnt.UseVisualStyleBackColor = True
            '
            'rdbNegativo
            '
            Me.rdbNegativo.AutoSize = True
            Me.rdbNegativo.Location = New System.Drawing.Point(277, 13)
            Me.rdbNegativo.Name = "rdbNegativo"
            Me.rdbNegativo.Size = New System.Drawing.Size(68, 17)
            Me.rdbNegativo.TabIndex = 0
            Me.rdbNegativo.TabStop = True
            Me.rdbNegativo.Text = "Negativo"
            Me.rdbNegativo.UseVisualStyleBackColor = True
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.rdbTodos)
            Me.GroupBox5.Controls.Add(Me.rdbAnulado)
            Me.GroupBox5.Controls.Add(Me.rdbImpreso)
            Me.GroupBox5.Controls.Add(Me.rdbTerminado)
            Me.GroupBox5.Controls.Add(Me.rdbPendiente)
            Me.GroupBox5.Location = New System.Drawing.Point(640, 7)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(400, 36)
            Me.GroupBox5.TabIndex = 64
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Estado"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(311, 15)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodos.TabIndex = 4
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "[Todos]"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbAnulado
            '
            Me.rdbAnulado.AutoSize = True
            Me.rdbAnulado.Location = New System.Drawing.Point(239, 15)
            Me.rdbAnulado.Name = "rdbAnulado"
            Me.rdbAnulado.Size = New System.Drawing.Size(64, 17)
            Me.rdbAnulado.TabIndex = 3
            Me.rdbAnulado.Text = "Anulado"
            Me.rdbAnulado.UseVisualStyleBackColor = True
            '
            'rdbImpreso
            '
            Me.rdbImpreso.AutoSize = True
            Me.rdbImpreso.Location = New System.Drawing.Point(168, 15)
            Me.rdbImpreso.Name = "rdbImpreso"
            Me.rdbImpreso.Size = New System.Drawing.Size(62, 17)
            Me.rdbImpreso.TabIndex = 2
            Me.rdbImpreso.Text = "Impreso"
            Me.rdbImpreso.UseVisualStyleBackColor = True
            '
            'rdbTerminado
            '
            Me.rdbTerminado.AutoSize = True
            Me.rdbTerminado.Location = New System.Drawing.Point(85, 15)
            Me.rdbTerminado.Name = "rdbTerminado"
            Me.rdbTerminado.Size = New System.Drawing.Size(75, 17)
            Me.rdbTerminado.TabIndex = 1
            Me.rdbTerminado.Text = "Terminado"
            Me.rdbTerminado.UseVisualStyleBackColor = True
            '
            'rdbPendiente
            '
            Me.rdbPendiente.AutoSize = True
            Me.rdbPendiente.Location = New System.Drawing.Point(5, 15)
            Me.rdbPendiente.Name = "rdbPendiente"
            Me.rdbPendiente.Size = New System.Drawing.Size(73, 17)
            Me.rdbPendiente.TabIndex = 0
            Me.rdbPendiente.Text = "Pendiente"
            Me.rdbPendiente.UseVisualStyleBackColor = True
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.txtApePatCAJ)
            Me.GroupBox9.Controls.Add(Me.dtpFechaFinCAJ)
            Me.GroupBox9.Controls.Add(Me.Label17)
            Me.GroupBox9.Controls.Add(Me.Label18)
            Me.GroupBox9.Controls.Add(Me.Label19)
            Me.GroupBox9.Controls.Add(Me.txtNombresCAJ)
            Me.GroupBox9.Controls.Add(Me.Label20)
            Me.GroupBox9.Controls.Add(Me.txtApeMatCAJ)
            Me.GroupBox9.Controls.Add(Me.Label21)
            Me.GroupBox9.Controls.Add(Me.dtpFechaIniCAJ)
            Me.GroupBox9.Controls.Add(Me.txtInternoCodCAJ)
            Me.GroupBox9.Controls.Add(Me.Label22)
            Me.GroupBox9.Controls.Add(Me.Label23)
            Me.GroupBox9.Controls.Add(Me.txtDocSolicitudCAJ)
            Me.GroupBox9.Location = New System.Drawing.Point(5, 40)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(1036, 62)
            Me.GroupBox9.TabIndex = 59
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "Datos de búsqueda"
            '
            'txtApePatCAJ
            '
            Me.txtApePatCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePatCAJ._BloquearPaste = False
            Me.txtApePatCAJ._SeleccionarTodo = False
            Me.txtApePatCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApePatCAJ.Location = New System.Drawing.Point(100, 15)
            Me.txtApePatCAJ.Name = "txtApePatCAJ"
            Me.txtApePatCAJ.Size = New System.Drawing.Size(209, 20)
            Me.txtApePatCAJ.TabIndex = 13
            Me.txtApePatCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePatCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpFechaFinCAJ
            '
            Me.dtpFechaFinCAJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFinCAJ.Location = New System.Drawing.Point(873, 37)
            Me.dtpFechaFinCAJ.Name = "dtpFechaFinCAJ"
            Me.dtpFechaFinCAJ.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinCAJ.TabIndex = 24
            Me.dtpFechaFinCAJ.Value = "/  /"
            Me.dtpFechaFinCAJ.ValueLong = CType(0, Long)
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(327, 41)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(69, 13)
            Me.Label17.TabIndex = 57
            Me.Label17.Text = "N° Doc. Sol.:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(836, 41)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(16, 13)
            Me.Label18.TabIndex = 58
            Me.Label18.Text = "---"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(632, 41)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(97, 13)
            Me.Label19.TabIndex = 57
            Me.Label19.Text = "F. Solicitud desde :"
            '
            'txtNombresCAJ
            '
            Me.txtNombresCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombresCAJ._BloquearPaste = False
            Me.txtNombresCAJ._SeleccionarTodo = False
            Me.txtNombresCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombresCAJ.Location = New System.Drawing.Point(733, 15)
            Me.txtNombresCAJ.Name = "txtNombresCAJ"
            Me.txtNombresCAJ.Size = New System.Drawing.Size(224, 20)
            Me.txtNombresCAJ.TabIndex = 2
            Me.txtNombresCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombresCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(28, 41)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(68, 13)
            Me.Label20.TabIndex = 57
            Me.Label20.Text = "Cod. Interno:"
            '
            'txtApeMatCAJ
            '
            Me.txtApeMatCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMatCAJ._BloquearPaste = False
            Me.txtApeMatCAJ._SeleccionarTodo = False
            Me.txtApeMatCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApeMatCAJ.Location = New System.Drawing.Point(400, 15)
            Me.txtApeMatCAJ.Name = "txtApeMatCAJ"
            Me.txtApeMatCAJ.Size = New System.Drawing.Size(209, 20)
            Me.txtApeMatCAJ.TabIndex = 1
            Me.txtApeMatCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMatCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(30, 19)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(61, 13)
            Me.Label21.TabIndex = 57
            Me.Label21.Text = "Primer Ap. :"
            '
            'dtpFechaIniCAJ
            '
            Me.dtpFechaIniCAJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaIniCAJ.Location = New System.Drawing.Point(733, 37)
            Me.dtpFechaIniCAJ.Name = "dtpFechaIniCAJ"
            Me.dtpFechaIniCAJ.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIniCAJ.TabIndex = 23
            Me.dtpFechaIniCAJ.Value = "/  /"
            Me.dtpFechaIniCAJ.ValueLong = CType(0, Long)
            '
            'txtInternoCodCAJ
            '
            Me.txtInternoCodCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtInternoCodCAJ._BloquearPaste = False
            Me.txtInternoCodCAJ._SeleccionarTodo = False
            Me.txtInternoCodCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtInternoCodCAJ.Location = New System.Drawing.Point(100, 38)
            Me.txtInternoCodCAJ.Name = "txtInternoCodCAJ"
            Me.txtInternoCodCAJ.Size = New System.Drawing.Size(128, 20)
            Me.txtInternoCodCAJ.TabIndex = 3
            Me.txtInternoCodCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtInternoCodCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(329, 19)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(75, 13)
            Me.Label22.TabIndex = 57
            Me.Label22.Text = "Segundo Ap. :"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(671, 19)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(58, 13)
            Me.Label23.TabIndex = 57
            Me.Label23.Text = "Nombre(s):"
            '
            'txtDocSolicitudCAJ
            '
            Me.txtDocSolicitudCAJ._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDocSolicitudCAJ._BloquearPaste = False
            Me.txtDocSolicitudCAJ._SeleccionarTodo = False
            Me.txtDocSolicitudCAJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocSolicitudCAJ.Location = New System.Drawing.Point(400, 38)
            Me.txtDocSolicitudCAJ.Name = "txtDocSolicitudCAJ"
            Me.txtDocSolicitudCAJ.Size = New System.Drawing.Size(209, 20)
            Me.txtDocSolicitudCAJ.TabIndex = 4
            Me.txtDocSolicitudCAJ.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDocSolicitudCAJ.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "recibir.png")
            Me.ImageList1.Images.SetKeyName(1, "internos-32-32.png")
            Me.ImageList1.Images.SetKeyName(2, "movimiento32x32.png")
            Me.ImageList1.Images.SetKeyName(3, "if_document-open_23214.png")
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
            Me.pnlInferior.Controls.Add(Me.btnVerLibros)
            Me.pnlInferior.Controls.Add(Me.pnlBotonesAccion)
            Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlInferior.Location = New System.Drawing.Point(0, 549)
            Me.pnlInferior.Name = "pnlInferior"
            Me.pnlInferior.Size = New System.Drawing.Size(1063, 47)
            Me.pnlInferior.TabIndex = 70
            '
            'btnVerLibros
            '
            Me.btnVerLibros.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnVerLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVerLibros.Image = Global.SIPPOPE.My.Resources.Resources.Libro
            Me.btnVerLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVerLibros.Location = New System.Drawing.Point(983, 0)
            Me.btnVerLibros.Name = "btnVerLibros"
            Me.btnVerLibros.Size = New System.Drawing.Size(80, 47)
            Me.btnVerLibros.TabIndex = 67
            Me.btnVerLibros.Text = "&Ver Libros"
            Me.btnVerLibros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnVerLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnVerLibros.UseVisualStyleBackColor = True
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
            Me.pnlDetalle.TabIndex = 71
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
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1259, 596)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Name = "frmBuscar"
            Me.Text = "Busqueda - ORL"
            Me.pnlBusqueda.ResumeLayout(False)
            Me.grbBusqueda.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.grbSitJur.ResumeLayout(False)
            Me.grbSitJur.PerformLayout()
            Me.pnlRegionPenal.ResumeLayout(False)
            Me.pnlRegionPenal.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.pnlBotonesAccion.ResumeLayout(False)
            Me.pblLeyenda.ResumeLayout(False)
            Me.pblLeyenda.PerformLayout()
            Me.pnlBotonOtros.ResumeLayout(False)
            Me.pnlBotonReporte.ResumeLayout(False)
            Me.pnlAnular.ResumeLayout(False)
            Me.pnlBotonModificar.ResumeLayout(False)
            Me.pnlNuevo.ResumeLayout(False)
            Me.pnlFotografia.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlGrilla.ResumeLayout(False)
            Me.pnlCuerpoPrincipal.ResumeLayout(False)
            Me.tbcPrincipal.ResumeLayout(False)
            Me.tpConsultaMovimiento.ResumeLayout(False)
            Me.tpConsultaInterno.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpAntecedente.ResumeLayout(False)
            CType(Me.dgwGrillaCAJ, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel6.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.pnlInferior.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
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
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents pnlBotonesAccion As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExtranjero As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPeruano As System.Windows.Forms.RadioButton
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
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
        Friend WithEvents pnlRegionPenal As System.Windows.Forms.Panel
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbbDelitoEspecifico As APPControls.uscComboParametrica
        Friend WithEvents cbbDelitoGenerico As APPControls.uscComboParametrica
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents grbSitJur As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSitJurTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSentenciado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbProcesado As System.Windows.Forms.RadioButton
        'Friend WithEvents UscGrillaCampo1 As APPControls.Grilla.uscGrillaCampo
        Friend WithEvents lblSegundo As System.Windows.Forms.Label
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
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
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents txtIngresoFecha As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtIngresoNum As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSituacionJur As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents txtFechaEgreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents txtTipoEgreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents pnlInferior As System.Windows.Forms.Panel
        Friend WithEvents pnlBotonModificar As System.Windows.Forms.Panel
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
        Friend WithEvents tbcPrincipal As System.Windows.Forms.TabControl
        Friend WithEvents tpConsultaInterno As System.Windows.Forms.TabPage
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlCuerpoPrincipal As System.Windows.Forms.Panel
        Friend WithEvents tpConsultaMovimiento As System.Windows.Forms.TabPage
        Friend WithEvents UscBusquedaMovimiento1 As APPControls.Registro.Main.uscBusquedaMovimiento_LM
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents tpAntecedente As System.Windows.Forms.TabPage
        Friend WithEvents pblLeyenda As System.Windows.Forms.Panel
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents drbPositivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbTodosTipAnt As System.Windows.Forms.RadioButton
        Friend WithEvents rdbNegativo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbAnulado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbImpreso As System.Windows.Forms.RadioButton
        Friend WithEvents rdbTerminado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPendiente As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents txtApePatCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaFinCAJ As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtNombresCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtApeMatCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaIniCAJ As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtInternoCodCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents txtDocSolicitudCAJ As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlNuevo As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents dgwGrillaCAJ As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents pnlAnular As System.Windows.Forms.Panel
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents btnVerLibros As System.Windows.Forms.Button
        Friend WithEvents txtPenalClasificacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents rbTupa As RadioButton
        Friend WithEvents rbNoProPendMD As RadioButton
        Friend WithEvents col_cod_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_est_id_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_est_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_aj_id_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_sol_num_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_sol_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_num_imp_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_usu_caj As DataGridViewTextBoxColumn
        Friend WithEvents col_dat_hist_migra As DataGridViewTextBoxColumn
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
    End Class
End Namespace

