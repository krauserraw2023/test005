Namespace Tratamiento.AfiliacionSIS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscarSIS
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarSIS))
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rdbAfiliacionTodos = New System.Windows.Forms.RadioButton()
            Me.rdbAfiliacionNO = New System.Windows.Forms.RadioButton()
            Me.rdbAfiliacionSI = New System.Windows.Forms.RadioButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtNumeroDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.Label5 = New System.Windows.Forms.Label()
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
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.pnlCuerpoPrincipal = New System.Windows.Forms.Panel()
            Me.tcPrincipal = New System.Windows.Forms.TabControl()
            Me.tpPoblacionInterno = New System.Windows.Forms.TabPage()
            Me.tcInternos = New System.Windows.Forms.TabControl()
            Me.tpBusquedaInternos = New System.Windows.Forms.TabPage()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_ico_pi = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_fot_ico_pf = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_fot_ico_pd = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_afil_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlFotografia = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblSegundo = New System.Windows.Forms.Label()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.tpDatosPersonales = New System.Windows.Forms.TabPage()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.txtFechaLibertad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label28 = New System.Windows.Forms.Label()
            Me.txtEstado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label27 = New System.Windows.Forms.Label()
            Me.txtFechaIngreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label25 = New System.Windows.Forms.Label()
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label24 = New System.Windows.Forms.Label()
            Me.GroupBox11 = New System.Windows.Forms.GroupBox()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.rbtAfiliacionNO = New System.Windows.Forms.RadioButton()
            Me.rbtAfiliacionSI = New System.Windows.Forms.RadioButton()
            Me.dtpFechaAfi = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.txtNacionalidad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.btnValidarReniec = New System.Windows.Forms.Button()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.txtMadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtpadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label38 = New System.Windows.Forms.Label()
            Me.txtEstadoCivil = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label29 = New System.Windows.Forms.Label()
            Me.GroupBox10 = New System.Windows.Forms.GroupBox()
            Me.rbtNoRNC = New System.Windows.Forms.RadioButton()
            Me.rbtSiRNC = New System.Windows.Forms.RadioButton()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.UscFotografia_2v2 = New APPControls.Foto.uscFotografia_2v()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtDistritoNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtProvinciaNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDepartamentoNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPaisNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtTipoNumeroDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtEdad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label17 = New System.Windows.Forms.Label()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.rbtFemenino = New System.Windows.Forms.RadioButton()
            Me.rbtMasculino = New System.Windows.Forms.RadioButton()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtApellidoPat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtApellidoMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtCodigoInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label37 = New System.Windows.Forms.Label()
            Me.tpSolicitudAfiliaciones = New System.Windows.Forms.TabPage()
            Me.pnlSolicitudes = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.dgwGrillaSolicitudes = New Legolas.APPUIComponents.myDatagridView()
            Me.col_sol_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_nro_sol = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_tip_pob = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_pen_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_int_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_tip_doc_env = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_tip_doc_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_tip_doc_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_fec_str = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_sex_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_fec_env = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_fec_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_fec_egr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_det_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sol_obs_img = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_sol_tip_ope = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbBusqueda = New System.Windows.Forms.GroupBox()
            Me.lblEtiqueta = New System.Windows.Forms.Label()
            Me.txtFechaEnvio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label35 = New System.Windows.Forms.Label()
            Me.txtFechaRegistro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label33 = New System.Windows.Forms.Label()
            Me.txtEstadoSolicitud = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label32 = New System.Windows.Forms.Label()
            Me.cbbMes = New Legolas.APPUIComponents.uscComboMes()
            Me.ckbVer = New System.Windows.Forms.CheckBox()
            Me.cbbRegistro = New APPControls.uscComboParametrica()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.pnlPiesolicitud = New System.Windows.Forms.Panel()
            Me.GroupBox14 = New System.Windows.Forms.GroupBox()
            Me.dgwResumen = New Legolas.APPUIComponents.myDatagridView()
            Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_res_lib = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_res_tras = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_res_ning = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox13 = New System.Windows.Forms.GroupBox()
            Me.chkRegistrosObservados = New System.Windows.Forms.CheckBox()
            Me.txtDocumentoBusca = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label39 = New System.Windows.Forms.Label()
            Me.txtApellidosNombresBus = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label36 = New System.Windows.Forms.Label()
            Me.cbbEstablecimientoPenitenciario = New APPControls.uscComboParametrica()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.cbbOficinaRegional = New APPControls.uscComboParametrica()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.UscFotografia_2v3 = New APPControls.Foto.uscFotografia_2v()
            Me.GroupBox16 = New System.Windows.Forms.GroupBox()
            Me.lblSegundoSol = New System.Windows.Forms.Label()
            Me.lblRegSolicitud = New System.Windows.Forms.Label()
            Me.tsbBuscarSolicitudes = New System.Windows.Forms.ToolStrip()
            Me.tsbListarSolicitudesAfi = New System.Windows.Forms.ToolStripButton()
            Me.gbBotones = New System.Windows.Forms.GroupBox()
            Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
            Me.tsbGenerarSolicitud = New System.Windows.Forms.ToolStripButton()
            Me.tsbExportar = New System.Windows.Forms.ToolStripButton()
            Me.pnlInferior = New System.Windows.Forms.Panel()
            Me.pnlBotonOtros = New System.Windows.Forms.Panel()
            Me.btnFicha = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlBotonReporte = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
            Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
            Me.pnlBusqueda.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlCuerpoPrincipal.SuspendLayout()
            Me.tcPrincipal.SuspendLayout()
            Me.tpPoblacionInterno.SuspendLayout()
            Me.tcInternos.SuspendLayout()
            Me.tpBusquedaInternos.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFotografia.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.tpDatosPersonales.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox12.SuspendLayout()
            Me.GroupBox11.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox10.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.tpSolicitudAfiliaciones.SuspendLayout()
            Me.pnlSolicitudes.SuspendLayout()
            Me.Panel7.SuspendLayout()
            CType(Me.dgwGrillaSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBusqueda.SuspendLayout()
            Me.pnlPiesolicitud.SuspendLayout()
            Me.GroupBox14.SuspendLayout()
            CType(Me.dgwResumen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox13.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.GroupBox16.SuspendLayout()
            Me.tsbBuscarSolicitudes.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            Me.ToolStrip2.SuspendLayout()
            Me.pnlInferior.SuspendLayout()
            Me.pnlBotonOtros.SuspendLayout()
            Me.pnlBotonReporte.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.grbBusqueda)
            Me.pnlBusqueda.Controls.Add(Me.Panel3)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1035, 149)
            Me.pnlBusqueda.TabIndex = 37
            '
            'grbBusqueda
            '
            Me.grbBusqueda.Controls.Add(Me.GroupBox2)
            Me.grbBusqueda.Controls.Add(Me.GroupBox4)
            Me.grbBusqueda.Controls.Add(Me.GroupBox3)
            Me.grbBusqueda.Controls.Add(Me.grbEstado)
            Me.grbBusqueda.Controls.Add(Me.GroupBox8)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 34)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.grbBusqueda.Size = New System.Drawing.Size(1035, 115)
            Me.grbBusqueda.TabIndex = 1
            Me.grbBusqueda.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbAfiliacionTodos)
            Me.GroupBox2.Controls.Add(Me.rdbAfiliacionNO)
            Me.GroupBox2.Controls.Add(Me.rdbAfiliacionSI)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(506, 69)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(223, 43)
            Me.GroupBox2.TabIndex = 19
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Afiliado al SIS"
            '
            'rdbAfiliacionTodos
            '
            Me.rdbAfiliacionTodos.AutoSize = True
            Me.rdbAfiliacionTodos.Checked = True
            Me.rdbAfiliacionTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbAfiliacionTodos.Location = New System.Drawing.Point(143, 16)
            Me.rdbAfiliacionTodos.Name = "rdbAfiliacionTodos"
            Me.rdbAfiliacionTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbAfiliacionTodos.TabIndex = 8
            Me.rdbAfiliacionTodos.TabStop = True
            Me.rdbAfiliacionTodos.Text = "[Todos]"
            Me.rdbAfiliacionTodos.UseVisualStyleBackColor = True
            '
            'rdbAfiliacionNO
            '
            Me.rdbAfiliacionNO.AutoSize = True
            Me.rdbAfiliacionNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbAfiliacionNO.Location = New System.Drawing.Point(74, 18)
            Me.rdbAfiliacionNO.Name = "rdbAfiliacionNO"
            Me.rdbAfiliacionNO.Size = New System.Drawing.Size(41, 17)
            Me.rdbAfiliacionNO.TabIndex = 7
            Me.rdbAfiliacionNO.Text = "NO"
            Me.rdbAfiliacionNO.UseVisualStyleBackColor = True
            '
            'rdbAfiliacionSI
            '
            Me.rdbAfiliacionSI.AutoSize = True
            Me.rdbAfiliacionSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbAfiliacionSI.Location = New System.Drawing.Point(13, 19)
            Me.rdbAfiliacionSI.Name = "rdbAfiliacionSI"
            Me.rdbAfiliacionSI.Size = New System.Drawing.Size(35, 17)
            Me.rdbAfiliacionSI.TabIndex = 6
            Me.rdbAfiliacionSI.Text = "SI"
            Me.rdbAfiliacionSI.UseVisualStyleBackColor = True
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtNumeroDoc)
            Me.GroupBox4.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox4.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label13)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(250, 10)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(479, 60)
            Me.GroupBox4.TabIndex = 18
            Me.GroupBox4.TabStop = False
            '
            'txtNumeroDoc
            '
            Me.txtNumeroDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumeroDoc._BloquearPaste = False
            Me.txtNumeroDoc._SeleccionarTodo = True
            Me.txtNumeroDoc.ForeColor = System.Drawing.Color.Black
            Me.txtNumeroDoc.Location = New System.Drawing.Point(318, 11)
            Me.txtNumeroDoc.Name = "txtNumeroDoc"
            Me.txtNumeroDoc.Size = New System.Drawing.Size(155, 20)
            Me.txtNumeroDoc.TabIndex = 35
            Me.txtNumeroDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumeroDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
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
            Me.cbbNacionalidad.ComboTipo = Type.Combo.ComboTipo.Nacionalidad
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 143
            Me.cbbNacionalidad.DropDownWidthAuto = False
            Me.cbbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(118, 33)
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(194, 22)
            Me.cbbNacionalidad.TabIndex = 31
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
            Me.cbbTipoDoc.ComboTipo = Type.Combo.ComboTipo.TipoDoc
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 143
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(118, 9)
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(194, 22)
            Me.cbbTipoDoc.TabIndex = 31
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(1, 13)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(115, 13)
            Me.Label5.TabIndex = 34
            Me.Label5.Text = "Documento Identidad :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(4, 38)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(75, 13)
            Me.Label13.TabIndex = 34
            Me.Label13.Text = "Nacionalidad :"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rdbSexoTodos)
            Me.GroupBox3.Controls.Add(Me.rdbMuj)
            Me.GroupBox3.Controls.Add(Me.rdbHom)
            Me.GroupBox3.Location = New System.Drawing.Point(250, 69)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(250, 43)
            Me.GroupBox3.TabIndex = 13
            Me.GroupBox3.TabStop = False
            '
            'rdbSexoTodos
            '
            Me.rdbSexoTodos.AutoSize = True
            Me.rdbSexoTodos.Checked = True
            Me.rdbSexoTodos.Location = New System.Drawing.Point(171, 15)
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
            Me.rdbMuj.Location = New System.Drawing.Point(87, 15)
            Me.rdbMuj.Name = "rdbMuj"
            Me.rdbMuj.Size = New System.Drawing.Size(62, 17)
            Me.rdbMuj.TabIndex = 15
            Me.rdbMuj.Text = "Mujeres"
            Me.rdbMuj.UseVisualStyleBackColor = True
            '
            'rdbHom
            '
            Me.rdbHom.AutoSize = True
            Me.rdbHom.Location = New System.Drawing.Point(6, 15)
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
            Me.grbEstado.Location = New System.Drawing.Point(733, 10)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(251, 61)
            Me.grbEstado.TabIndex = 5
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado"
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Checked = True
            Me.rdbEstadoTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(143, 19)
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
            Me.rdbInactivo.Location = New System.Drawing.Point(74, 19)
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
            Me.rdbActivo.Location = New System.Drawing.Point(13, 20)
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
            Me.Label3.Size = New System.Drawing.Size(72, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Pre nombres :"
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
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Controls.Add(Me.cbbPenal)
            Me.Panel3.Controls.Add(Me.Label34)
            Me.Panel3.Controls.Add(Me.Label4)
            Me.Panel3.Controls.Add(Me.cbbRegion)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(1035, 34)
            Me.Panel3.TabIndex = 0
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label7.Location = New System.Drawing.Point(0, 33)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(1035, 1)
            Me.Label7.TabIndex = 58
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
            Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.Penal
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 238
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(313, 6)
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
            Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.RegionUsuario
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(56, 6)
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(189, 22)
            Me.cbbRegion.TabIndex = 1
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
            'pnlCuerpoPrincipal
            '
            Me.pnlCuerpoPrincipal.Controls.Add(Me.tcPrincipal)
            Me.pnlCuerpoPrincipal.Controls.Add(Me.pnlInferior)
            Me.pnlCuerpoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCuerpoPrincipal.Location = New System.Drawing.Point(0, 0)
            Me.pnlCuerpoPrincipal.Name = "pnlCuerpoPrincipal"
            Me.pnlCuerpoPrincipal.Size = New System.Drawing.Size(1259, 596)
            Me.pnlCuerpoPrincipal.TabIndex = 0
            '
            'tcPrincipal
            '
            Me.tcPrincipal.Controls.Add(Me.tpPoblacionInterno)
            Me.tcPrincipal.Controls.Add(Me.tpSolicitudAfiliaciones)
            Me.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcPrincipal.Location = New System.Drawing.Point(0, 0)
            Me.tcPrincipal.Name = "tcPrincipal"
            Me.tcPrincipal.SelectedIndex = 0
            Me.tcPrincipal.Size = New System.Drawing.Size(1259, 546)
            Me.tcPrincipal.TabIndex = 0
            '
            'tpPoblacionInterno
            '
            Me.tpPoblacionInterno.Controls.Add(Me.tcInternos)
            Me.tpPoblacionInterno.ImageIndex = 0
            Me.tpPoblacionInterno.Location = New System.Drawing.Point(4, 22)
            Me.tpPoblacionInterno.Name = "tpPoblacionInterno"
            Me.tpPoblacionInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tpPoblacionInterno.Size = New System.Drawing.Size(1251, 520)
            Me.tpPoblacionInterno.TabIndex = 0
            Me.tpPoblacionInterno.Text = "Poblacíon procesados/sentenciados"
            Me.tpPoblacionInterno.UseVisualStyleBackColor = True
            '
            'tcInternos
            '
            Me.tcInternos.Controls.Add(Me.tpBusquedaInternos)
            Me.tcInternos.Controls.Add(Me.tpDatosPersonales)
            Me.tcInternos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcInternos.Location = New System.Drawing.Point(3, 3)
            Me.tcInternos.Name = "tcInternos"
            Me.tcInternos.SelectedIndex = 0
            Me.tcInternos.Size = New System.Drawing.Size(1245, 514)
            Me.tcInternos.TabIndex = 0
            '
            'tpBusquedaInternos
            '
            Me.tpBusquedaInternos.Controls.Add(Me.Panel2)
            Me.tpBusquedaInternos.Controls.Add(Me.pnlFotografia)
            Me.tpBusquedaInternos.Location = New System.Drawing.Point(4, 22)
            Me.tpBusquedaInternos.Name = "tpBusquedaInternos"
            Me.tpBusquedaInternos.Padding = New System.Windows.Forms.Padding(3)
            Me.tpBusquedaInternos.Size = New System.Drawing.Size(1237, 488)
            Me.tpBusquedaInternos.TabIndex = 0
            Me.tpBusquedaInternos.Text = "Busqueda de internos"
            Me.tpBusquedaInternos.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.dgwGrilla)
            Me.Panel2.Controls.Add(Me.pnlBusqueda)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(3, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1035, 482)
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
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pdr, Me.col_int_id, Me.col_ing_id, Me.col_cod_rp, Me.Column1, Me.Column2, Me.col_ape, Me.col_nom, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column6, Me.col_fec_nac, Me.Column7, Me.Column17, Me.col_pabellon, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom, Me.col_est_nom, Me.col_est_gen, Me.col_fot_ico_pi, Me.col_fot_ico_pf, Me.col_fot_ico_pd, Me.Column8, Me.col_afil_nom})
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
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 149)
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
            Me.dgwGrilla.Size = New System.Drawing.Size(1035, 333)
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
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoID"
            Me.col_ing_id.DividerWidth = 1
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
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
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "RegionID"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Region"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
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
            Me.Column8.Width = 45
            '
            'col_afil_nom
            '
            Me.col_afil_nom.DataPropertyName = "EstadoAfiliacionNom"
            Me.col_afil_nom.HeaderText = "SIS"
            Me.col_afil_nom.Name = "col_afil_nom"
            Me.col_afil_nom.ReadOnly = True
            '
            'pnlFotografia
            '
            Me.pnlFotografia.Controls.Add(Me.GroupBox1)
            Me.pnlFotografia.Controls.Add(Me.Panel1)
            Me.pnlFotografia.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlFotografia.Location = New System.Drawing.Point(1038, 3)
            Me.pnlFotografia.Name = "pnlFotografia"
            Me.pnlFotografia.Size = New System.Drawing.Size(196, 482)
            Me.pnlFotografia.TabIndex = 72
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.UscFotografia_2v1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 189)
            Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox1.Size = New System.Drawing.Size(196, 293)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = False
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(3, 13)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(190, 277)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 2
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
            'tpDatosPersonales
            '
            Me.tpDatosPersonales.Controls.Add(Me.GroupBox5)
            Me.tpDatosPersonales.Location = New System.Drawing.Point(4, 22)
            Me.tpDatosPersonales.Name = "tpDatosPersonales"
            Me.tpDatosPersonales.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDatosPersonales.Size = New System.Drawing.Size(1237, 488)
            Me.tpDatosPersonales.TabIndex = 1
            Me.tpDatosPersonales.Text = "Datos Generales"
            Me.tpDatosPersonales.UseVisualStyleBackColor = True
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.GroupBox12)
            Me.GroupBox5.Controls.Add(Me.GroupBox11)
            Me.GroupBox5.Controls.Add(Me.GroupBox6)
            Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(1231, 482)
            Me.GroupBox5.TabIndex = 36
            Me.GroupBox5.TabStop = False
            '
            'GroupBox12
            '
            Me.GroupBox12.Controls.Add(Me.txtFechaLibertad)
            Me.GroupBox12.Controls.Add(Me.Label28)
            Me.GroupBox12.Controls.Add(Me.txtEstado)
            Me.GroupBox12.Controls.Add(Me.Label27)
            Me.GroupBox12.Controls.Add(Me.txtFechaIngreso)
            Me.GroupBox12.Controls.Add(Me.Label25)
            Me.GroupBox12.Controls.Add(Me.txtPenal)
            Me.GroupBox12.Controls.Add(Me.Label24)
            Me.GroupBox12.Location = New System.Drawing.Point(5, 313)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(781, 65)
            Me.GroupBox12.TabIndex = 29
            Me.GroupBox12.TabStop = False
            '
            'txtFechaLibertad
            '
            Me.txtFechaLibertad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaLibertad._BloquearPaste = True
            Me.txtFechaLibertad._SeleccionarTodo = False
            Me.txtFechaLibertad.Location = New System.Drawing.Point(356, 37)
            Me.txtFechaLibertad.Name = "txtFechaLibertad"
            Me.txtFechaLibertad.ReadOnly = True
            Me.txtFechaLibertad.Size = New System.Drawing.Size(166, 20)
            Me.txtFechaLibertad.TabIndex = 28
            Me.txtFechaLibertad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaLibertad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(262, 40)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(75, 13)
            Me.Label28.TabIndex = 27
            Me.Label28.Text = "Fecha Salida :"
            '
            'txtEstado
            '
            Me.txtEstado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstado._BloquearPaste = True
            Me.txtEstado._SeleccionarTodo = False
            Me.txtEstado.Location = New System.Drawing.Point(356, 11)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(166, 20)
            Me.txtEstado.TabIndex = 26
            Me.txtEstado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(262, 14)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(46, 13)
            Me.Label27.TabIndex = 25
            Me.Label27.Text = "Estado :"
            '
            'txtFechaIngreso
            '
            Me.txtFechaIngreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaIngreso._BloquearPaste = True
            Me.txtFechaIngreso._SeleccionarTodo = False
            Me.txtFechaIngreso.Location = New System.Drawing.Point(106, 37)
            Me.txtFechaIngreso.Name = "txtFechaIngreso"
            Me.txtFechaIngreso.ReadOnly = True
            Me.txtFechaIngreso.Size = New System.Drawing.Size(153, 20)
            Me.txtFechaIngreso.TabIndex = 24
            Me.txtFechaIngreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaIngreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(5, 40)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(80, 13)
            Me.Label25.TabIndex = 23
            Me.Label25.Text = "Fecha ingreso :"
            '
            'txtPenal
            '
            Me.txtPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPenal._BloquearPaste = True
            Me.txtPenal._SeleccionarTodo = False
            Me.txtPenal.Location = New System.Drawing.Point(106, 11)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.ReadOnly = True
            Me.txtPenal.Size = New System.Drawing.Size(153, 20)
            Me.txtPenal.TabIndex = 22
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(5, 14)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(87, 13)
            Me.Label24.TabIndex = 4
            Me.Label24.Text = "Establecimiento :"
            '
            'GroupBox11
            '
            Me.GroupBox11.Controls.Add(Me.btnCancelar)
            Me.GroupBox11.Controls.Add(Me.btnAgregar)
            Me.GroupBox11.Controls.Add(Me.Label23)
            Me.GroupBox11.Controls.Add(Me.Label14)
            Me.GroupBox11.Controls.Add(Me.rbtAfiliacionNO)
            Me.GroupBox11.Controls.Add(Me.rbtAfiliacionSI)
            Me.GroupBox11.Controls.Add(Me.dtpFechaAfi)
            Me.GroupBox11.Location = New System.Drawing.Point(5, 379)
            Me.GroupBox11.Name = "GroupBox11"
            Me.GroupBox11.Size = New System.Drawing.Size(780, 50)
            Me.GroupBox11.TabIndex = 28
            Me.GroupBox11.TabStop = False
            Me.GroupBox11.Text = "Datos de afiliación al SIS"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
            Me.btnCancelar.Location = New System.Drawing.Point(547, 9)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(39, 39)
            Me.btnCancelar.TabIndex = 65
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnCancelar, "Quitar Afiliacion")
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnAgregar
            '
            Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
            Me.btnAgregar.Location = New System.Drawing.Point(485, 9)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(39, 39)
            Me.btnAgregar.TabIndex = 64
            Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnAgregar, "Afiliar Interno")
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(262, 26)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(87, 13)
            Me.Label23.TabIndex = 4
            Me.Label23.Text = "Fecha afiliación :"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(5, 26)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(47, 13)
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "Afiliado :"
            '
            'rbtAfiliacionNO
            '
            Me.rbtAfiliacionNO.AutoSize = True
            Me.rbtAfiliacionNO.Checked = True
            Me.rbtAfiliacionNO.Enabled = False
            Me.rbtAfiliacionNO.Location = New System.Drawing.Point(170, 23)
            Me.rbtAfiliacionNO.Name = "rbtAfiliacionNO"
            Me.rbtAfiliacionNO.Size = New System.Drawing.Size(41, 17)
            Me.rbtAfiliacionNO.TabIndex = 1
            Me.rbtAfiliacionNO.TabStop = True
            Me.rbtAfiliacionNO.Text = "NO"
            Me.rbtAfiliacionNO.UseVisualStyleBackColor = True
            '
            'rbtAfiliacionSI
            '
            Me.rbtAfiliacionSI.AutoSize = True
            Me.rbtAfiliacionSI.Enabled = False
            Me.rbtAfiliacionSI.Location = New System.Drawing.Point(109, 23)
            Me.rbtAfiliacionSI.Name = "rbtAfiliacionSI"
            Me.rbtAfiliacionSI.Size = New System.Drawing.Size(35, 17)
            Me.rbtAfiliacionSI.TabIndex = 0
            Me.rbtAfiliacionSI.Text = "SI"
            Me.rbtAfiliacionSI.UseVisualStyleBackColor = True
            '
            'dtpFechaAfi
            '
            Me.dtpFechaAfi.Location = New System.Drawing.Point(356, 18)
            Me.dtpFechaAfi.Name = "dtpFechaAfi"
            Me.dtpFechaAfi.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaAfi.TabIndex = 11
            Me.dtpFechaAfi.Value = "/  /"
            Me.dtpFechaAfi.ValueLong = CType(0, Long)
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.Label41)
            Me.GroupBox6.Controls.Add(Me.txtNacionalidad)
            Me.GroupBox6.Controls.Add(Me.btnValidarReniec)
            Me.GroupBox6.Controls.Add(Me.Label40)
            Me.GroupBox6.Controls.Add(Me.txtMadre)
            Me.GroupBox6.Controls.Add(Me.txtpadre)
            Me.GroupBox6.Controls.Add(Me.Label38)
            Me.GroupBox6.Controls.Add(Me.txtEstadoCivil)
            Me.GroupBox6.Controls.Add(Me.txtFechaNacimiento)
            Me.GroupBox6.Controls.Add(Me.Label29)
            Me.GroupBox6.Controls.Add(Me.GroupBox10)
            Me.GroupBox6.Controls.Add(Me.Panel5)
            Me.GroupBox6.Controls.Add(Me.GroupBox9)
            Me.GroupBox6.Controls.Add(Me.txtTipoNumeroDoc)
            Me.GroupBox6.Controls.Add(Me.txtEdad)
            Me.GroupBox6.Controls.Add(Me.Label17)
            Me.GroupBox6.Controls.Add(Me.GroupBox7)
            Me.GroupBox6.Controls.Add(Me.Label15)
            Me.GroupBox6.Controls.Add(Me.txtApellidoPat)
            Me.GroupBox6.Controls.Add(Me.Label19)
            Me.GroupBox6.Controls.Add(Me.Label8)
            Me.GroupBox6.Controls.Add(Me.Label9)
            Me.GroupBox6.Controls.Add(Me.Label12)
            Me.GroupBox6.Controls.Add(Me.txtNombres)
            Me.GroupBox6.Controls.Add(Me.Label10)
            Me.GroupBox6.Controls.Add(Me.txtApellidoMat)
            Me.GroupBox6.Controls.Add(Me.Label16)
            Me.GroupBox6.Controls.Add(Me.Label6)
            Me.GroupBox6.Controls.Add(Me.txtCodigoInterno)
            Me.GroupBox6.Controls.Add(Me.Label37)
            Me.GroupBox6.Location = New System.Drawing.Point(6, 3)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(780, 311)
            Me.GroupBox6.TabIndex = 0
            Me.GroupBox6.TabStop = False
            '
            'Label41
            '
            Me.Label41.AutoSize = True
            Me.Label41.Location = New System.Drawing.Point(293, 104)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(94, 13)
            Me.Label41.TabIndex = 67
            Me.Label41.Text = "Consultar RENIEC"
            '
            'txtNacionalidad
            '
            Me.txtNacionalidad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNacionalidad._BloquearPaste = True
            Me.txtNacionalidad._SeleccionarTodo = False
            Me.txtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNacionalidad.Location = New System.Drawing.Point(91, 284)
            Me.txtNacionalidad.Name = "txtNacionalidad"
            Me.txtNacionalidad.ReadOnly = True
            Me.txtNacionalidad.Size = New System.Drawing.Size(167, 20)
            Me.txtNacionalidad.TabIndex = 39
            Me.txtNacionalidad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNacionalidad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'btnValidarReniec
            '
            Me.btnValidarReniec.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnValidarReniec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnValidarReniec.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnValidarReniec.Location = New System.Drawing.Point(261, 94)
            Me.btnValidarReniec.Name = "btnValidarReniec"
            Me.btnValidarReniec.Size = New System.Drawing.Size(29, 29)
            Me.btnValidarReniec.TabIndex = 66
            Me.btnValidarReniec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnValidarReniec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnValidarReniec, "Consultar RENIEC")
            Me.btnValidarReniec.UseVisualStyleBackColor = True
            '
            'Label40
            '
            Me.Label40.AutoSize = True
            Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label40.Location = New System.Drawing.Point(6, 288)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(75, 13)
            Me.Label40.TabIndex = 38
            Me.Label40.Text = "Nacionalidad :"
            '
            'txtMadre
            '
            Me.txtMadre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMadre._BloquearPaste = True
            Me.txtMadre._SeleccionarTodo = False
            Me.txtMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMadre.Location = New System.Drawing.Point(359, 183)
            Me.txtMadre.Name = "txtMadre"
            Me.txtMadre.ReadOnly = True
            Me.txtMadre.Size = New System.Drawing.Size(168, 20)
            Me.txtMadre.TabIndex = 37
            Me.txtMadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtpadre
            '
            Me.txtpadre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtpadre._BloquearPaste = True
            Me.txtpadre._SeleccionarTodo = False
            Me.txtpadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtpadre.Location = New System.Drawing.Point(91, 183)
            Me.txtpadre.Name = "txtpadre"
            Me.txtpadre.ReadOnly = True
            Me.txtpadre.Size = New System.Drawing.Size(168, 20)
            Me.txtpadre.TabIndex = 36
            Me.txtpadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtpadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label38.Location = New System.Drawing.Point(2, 187)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(85, 13)
            Me.Label38.TabIndex = 34
            Me.Label38.Text = "Nom. del padre :"
            '
            'txtEstadoCivil
            '
            Me.txtEstadoCivil._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstadoCivil._BloquearPaste = True
            Me.txtEstadoCivil._SeleccionarTodo = False
            Me.txtEstadoCivil.Location = New System.Drawing.Point(358, 153)
            Me.txtEstadoCivil.Name = "txtEstadoCivil"
            Me.txtEstadoCivil.ReadOnly = True
            Me.txtEstadoCivil.Size = New System.Drawing.Size(168, 20)
            Me.txtEstadoCivil.TabIndex = 29
            Me.txtEstadoCivil.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstadoCivil.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtFechaNacimiento
            '
            Me.txtFechaNacimiento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaNacimiento._BloquearPaste = True
            Me.txtFechaNacimiento._SeleccionarTodo = False
            Me.txtFechaNacimiento.Location = New System.Drawing.Point(90, 126)
            Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
            Me.txtFechaNacimiento.ReadOnly = True
            Me.txtFechaNacimiento.Size = New System.Drawing.Size(84, 20)
            Me.txtFechaNacimiento.TabIndex = 22
            Me.txtFechaNacimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaNacimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Location = New System.Drawing.Point(259, 13)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(99, 13)
            Me.Label29.TabIndex = 28
            Me.Label29.Text = "Validación Reniec :"
            '
            'GroupBox10
            '
            Me.GroupBox10.Controls.Add(Me.rbtNoRNC)
            Me.GroupBox10.Controls.Add(Me.rbtSiRNC)
            Me.GroupBox10.Location = New System.Drawing.Point(359, 3)
            Me.GroupBox10.Name = "GroupBox10"
            Me.GroupBox10.Size = New System.Drawing.Size(168, 30)
            Me.GroupBox10.TabIndex = 27
            Me.GroupBox10.TabStop = False
            '
            'rbtNoRNC
            '
            Me.rbtNoRNC.AutoSize = True
            Me.rbtNoRNC.Enabled = False
            Me.rbtNoRNC.Location = New System.Drawing.Point(58, 9)
            Me.rbtNoRNC.Name = "rbtNoRNC"
            Me.rbtNoRNC.Size = New System.Drawing.Size(41, 17)
            Me.rbtNoRNC.TabIndex = 1
            Me.rbtNoRNC.TabStop = True
            Me.rbtNoRNC.Text = "NO"
            Me.rbtNoRNC.UseVisualStyleBackColor = True
            '
            'rbtSiRNC
            '
            Me.rbtSiRNC.AutoSize = True
            Me.rbtSiRNC.Enabled = False
            Me.rbtSiRNC.Location = New System.Drawing.Point(6, 10)
            Me.rbtSiRNC.Name = "rbtSiRNC"
            Me.rbtSiRNC.Size = New System.Drawing.Size(35, 17)
            Me.rbtSiRNC.TabIndex = 0
            Me.rbtSiRNC.TabStop = True
            Me.rbtSiRNC.Text = "SI"
            Me.rbtSiRNC.UseVisualStyleBackColor = True
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.UscFotografia_2v2)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel5.Location = New System.Drawing.Point(577, 16)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(200, 292)
            Me.Panel5.TabIndex = 26
            '
            'UscFotografia_2v2
            '
            Me.UscFotografia_2v2._CheckImagen = False
            Me.UscFotografia_2v2._EnabledDobleClick = True
            Me.UscFotografia_2v2._HasImagen = False
            Me.UscFotografia_2v2._PanelAutorizacion = False
            Me.UscFotografia_2v2._PanelCheck = False
            Me.UscFotografia_2v2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v2.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v2.Name = "UscFotografia_2v2"
            Me.UscFotografia_2v2.Size = New System.Drawing.Size(200, 292)
            Me.UscFotografia_2v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v2.TabIndex = 26
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.txtDistritoNacimiento)
            Me.GroupBox9.Controls.Add(Me.txtProvinciaNacimiento)
            Me.GroupBox9.Controls.Add(Me.txtDepartamentoNacimiento)
            Me.GroupBox9.Controls.Add(Me.txtPaisNacimiento)
            Me.GroupBox9.Controls.Add(Me.Label18)
            Me.GroupBox9.Controls.Add(Me.Label20)
            Me.GroupBox9.Controls.Add(Me.Label21)
            Me.GroupBox9.Controls.Add(Me.Label22)
            Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox9.Location = New System.Drawing.Point(5, 203)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(533, 78)
            Me.GroupBox9.TabIndex = 22
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "Lugar nacimiento"
            '
            'txtDistritoNacimiento
            '
            Me.txtDistritoNacimiento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDistritoNacimiento._BloquearPaste = True
            Me.txtDistritoNacimiento._SeleccionarTodo = False
            Me.txtDistritoNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDistritoNacimiento.Location = New System.Drawing.Point(351, 50)
            Me.txtDistritoNacimiento.Name = "txtDistritoNacimiento"
            Me.txtDistritoNacimiento.ReadOnly = True
            Me.txtDistritoNacimiento.Size = New System.Drawing.Size(168, 20)
            Me.txtDistritoNacimiento.TabIndex = 33
            Me.txtDistritoNacimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDistritoNacimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtProvinciaNacimiento
            '
            Me.txtProvinciaNacimiento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtProvinciaNacimiento._BloquearPaste = True
            Me.txtProvinciaNacimiento._SeleccionarTodo = False
            Me.txtProvinciaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProvinciaNacimiento.Location = New System.Drawing.Point(85, 50)
            Me.txtProvinciaNacimiento.Name = "txtProvinciaNacimiento"
            Me.txtProvinciaNacimiento.ReadOnly = True
            Me.txtProvinciaNacimiento.Size = New System.Drawing.Size(168, 20)
            Me.txtProvinciaNacimiento.TabIndex = 32
            Me.txtProvinciaNacimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtProvinciaNacimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtDepartamentoNacimiento
            '
            Me.txtDepartamentoNacimiento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDepartamentoNacimiento._BloquearPaste = True
            Me.txtDepartamentoNacimiento._SeleccionarTodo = False
            Me.txtDepartamentoNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDepartamentoNacimiento.Location = New System.Drawing.Point(351, 22)
            Me.txtDepartamentoNacimiento.Name = "txtDepartamentoNacimiento"
            Me.txtDepartamentoNacimiento.ReadOnly = True
            Me.txtDepartamentoNacimiento.Size = New System.Drawing.Size(168, 20)
            Me.txtDepartamentoNacimiento.TabIndex = 31
            Me.txtDepartamentoNacimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDepartamentoNacimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtPaisNacimiento
            '
            Me.txtPaisNacimiento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPaisNacimiento._BloquearPaste = True
            Me.txtPaisNacimiento._SeleccionarTodo = False
            Me.txtPaisNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPaisNacimiento.Location = New System.Drawing.Point(85, 22)
            Me.txtPaisNacimiento.Name = "txtPaisNacimiento"
            Me.txtPaisNacimiento.ReadOnly = True
            Me.txtPaisNacimiento.Size = New System.Drawing.Size(168, 20)
            Me.txtPaisNacimiento.TabIndex = 30
            Me.txtPaisNacimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtPaisNacimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(255, 55)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(45, 13)
            Me.Label18.TabIndex = 6
            Me.Label18.Text = "Distrito :"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(5, 54)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(57, 13)
            Me.Label20.TabIndex = 4
            Me.Label20.Text = "Provincia :"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(255, 23)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(80, 13)
            Me.Label21.TabIndex = 2
            Me.Label21.Text = "Departamento :"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(5, 22)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(33, 13)
            Me.Label22.TabIndex = 0
            Me.Label22.Text = "Pais :"
            '
            'txtTipoNumeroDoc
            '
            Me.txtTipoNumeroDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoNumeroDoc._BloquearPaste = True
            Me.txtTipoNumeroDoc._SeleccionarTodo = False
            Me.txtTipoNumeroDoc.Location = New System.Drawing.Point(90, 99)
            Me.txtTipoNumeroDoc.Name = "txtTipoNumeroDoc"
            Me.txtTipoNumeroDoc.ReadOnly = True
            Me.txtTipoNumeroDoc.Size = New System.Drawing.Size(168, 20)
            Me.txtTipoNumeroDoc.TabIndex = 19
            Me.txtTipoNumeroDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTipoNumeroDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtEdad
            '
            Me.txtEdad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEdad._BloquearPaste = True
            Me.txtEdad._SeleccionarTodo = False
            Me.txtEdad.Location = New System.Drawing.Point(216, 125)
            Me.txtEdad.Name = "txtEdad"
            Me.txtEdad.ReadOnly = True
            Me.txtEdad.Size = New System.Drawing.Size(42, 20)
            Me.txtEdad.TabIndex = 21
            Me.txtEdad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEdad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(177, 132)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(38, 13)
            Me.Label17.TabIndex = 20
            Me.Label17.Text = "Edad :"
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.rbtFemenino)
            Me.GroupBox7.Controls.Add(Me.rbtMasculino)
            Me.GroupBox7.Location = New System.Drawing.Point(90, 145)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(168, 32)
            Me.GroupBox7.TabIndex = 13
            Me.GroupBox7.TabStop = False
            '
            'rbtFemenino
            '
            Me.rbtFemenino.AutoSize = True
            Me.rbtFemenino.Enabled = False
            Me.rbtFemenino.Location = New System.Drawing.Point(93, 9)
            Me.rbtFemenino.Name = "rbtFemenino"
            Me.rbtFemenino.Size = New System.Drawing.Size(51, 17)
            Me.rbtFemenino.TabIndex = 1
            Me.rbtFemenino.TabStop = True
            Me.rbtFemenino.Text = "Mujer"
            Me.rbtFemenino.UseVisualStyleBackColor = True
            '
            'rbtMasculino
            '
            Me.rbtMasculino.AutoSize = True
            Me.rbtMasculino.Enabled = False
            Me.rbtMasculino.Location = New System.Drawing.Point(7, 10)
            Me.rbtMasculino.Name = "rbtMasculino"
            Me.rbtMasculino.Size = New System.Drawing.Size(62, 17)
            Me.rbtMasculino.TabIndex = 0
            Me.rbtMasculino.TabStop = True
            Me.rbtMasculino.Text = "Hombre"
            Me.rbtMasculino.UseVisualStyleBackColor = True
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(2, 103)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(83, 13)
            Me.Label15.TabIndex = 18
            Me.Label15.Text = "Doc. Identidad :"
            '
            'txtApellidoPat
            '
            Me.txtApellidoPat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidoPat._BloquearPaste = True
            Me.txtApellidoPat._SeleccionarTodo = False
            Me.txtApellidoPat.Location = New System.Drawing.Point(90, 43)
            Me.txtApellidoPat.MaxLength = 100
            Me.txtApellidoPat.Name = "txtApellidoPat"
            Me.txtApellidoPat.ReadOnly = True
            Me.txtApellidoPat.Size = New System.Drawing.Size(168, 20)
            Me.txtApellidoPat.TabIndex = 8
            Me.txtApellidoPat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidoPat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(259, 155)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(67, 13)
            Me.Label19.TabIndex = 20
            Me.Label19.Text = "Estado civil :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(2, 46)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(82, 13)
            Me.Label8.TabIndex = 7
            Me.Label8.Text = "Primer Apellido :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(2, 75)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(72, 13)
            Me.Label9.TabIndex = 11
            Me.Label9.Text = "Pre nombres :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(2, 132)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(69, 13)
            Me.Label12.TabIndex = 10
            Me.Label12.Text = "Fecha Nac. :"
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = True
            Me.txtNombres._SeleccionarTodo = False
            Me.txtNombres.Location = New System.Drawing.Point(90, 72)
            Me.txtNombres.MaxLength = 100
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.ReadOnly = True
            Me.txtNombres.Size = New System.Drawing.Size(437, 20)
            Me.txtNombres.TabIndex = 12
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(2, 160)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(37, 13)
            Me.Label10.TabIndex = 8
            Me.Label10.Text = "Sexo :"
            '
            'txtApellidoMat
            '
            Me.txtApellidoMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidoMat._BloquearPaste = True
            Me.txtApellidoMat._SeleccionarTodo = False
            Me.txtApellidoMat.Location = New System.Drawing.Point(359, 43)
            Me.txtApellidoMat.MaxLength = 100
            Me.txtApellidoMat.Name = "txtApellidoMat"
            Me.txtApellidoMat.ReadOnly = True
            Me.txtApellidoMat.Size = New System.Drawing.Size(168, 20)
            Me.txtApellidoMat.TabIndex = 10
            Me.txtApellidoMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidoMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(259, 46)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(96, 13)
            Me.Label16.TabIndex = 9
            Me.Label16.Text = "Segundo Apellido :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(2, 13)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(82, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Codigo Interno :"
            '
            'txtCodigoInterno
            '
            Me.txtCodigoInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodigoInterno._BloquearPaste = False
            Me.txtCodigoInterno._SeleccionarTodo = False
            Me.txtCodigoInterno.Location = New System.Drawing.Point(90, 10)
            Me.txtCodigoInterno.Name = "txtCodigoInterno"
            Me.txtCodigoInterno.ReadOnly = True
            Me.txtCodigoInterno.Size = New System.Drawing.Size(84, 20)
            Me.txtCodigoInterno.TabIndex = 1
            Me.txtCodigoInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodigoInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label37.Location = New System.Drawing.Point(259, 188)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(96, 13)
            Me.Label37.TabIndex = 35
            Me.Label37.Text = "Nom. de la madre :"
            '
            'tpSolicitudAfiliaciones
            '
            Me.tpSolicitudAfiliaciones.Controls.Add(Me.pnlSolicitudes)
            Me.tpSolicitudAfiliaciones.Controls.Add(Me.pnlCabecera)
            Me.tpSolicitudAfiliaciones.Location = New System.Drawing.Point(4, 22)
            Me.tpSolicitudAfiliaciones.Name = "tpSolicitudAfiliaciones"
            Me.tpSolicitudAfiliaciones.Padding = New System.Windows.Forms.Padding(3)
            Me.tpSolicitudAfiliaciones.Size = New System.Drawing.Size(1251, 520)
            Me.tpSolicitudAfiliaciones.TabIndex = 1
            Me.tpSolicitudAfiliaciones.Text = "Solicitudes Afiliaciones"
            Me.tpSolicitudAfiliaciones.UseVisualStyleBackColor = True
            '
            'pnlSolicitudes
            '
            Me.pnlSolicitudes.Controls.Add(Me.Panel7)
            Me.pnlSolicitudes.Controls.Add(Me.pnlPiesolicitud)
            Me.pnlSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlSolicitudes.Location = New System.Drawing.Point(3, 3)
            Me.pnlSolicitudes.Name = "pnlSolicitudes"
            Me.pnlSolicitudes.Size = New System.Drawing.Size(1036, 514)
            Me.pnlSolicitudes.TabIndex = 0
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.dgwGrillaSolicitudes)
            Me.Panel7.Controls.Add(Me.gbBusqueda)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(0, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(1036, 376)
            Me.Panel7.TabIndex = 0
            '
            'dgwGrillaSolicitudes
            '
            Me.dgwGrillaSolicitudes.AllowUserToAddRows = False
            Me.dgwGrillaSolicitudes.AllowUserToDeleteRows = False
            Me.dgwGrillaSolicitudes.AllowUserToResizeRows = False
            Me.dgwGrillaSolicitudes.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwGrillaSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sol_chk, Me.col_nro_sol, Me.col_sol_anio, Me.col_sol_mes, Me.col_sol_tip_pob, Me.col_sol_pen_cod, Me.col_sol_pen_id, Me.col_sol_pen_nom, Me.col_sol_int_id, Me.col_sol_int_cod, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.col_sol_ape_nom, Me.col_sol_tip_doc_env, Me.col_sol_tip_doc_id, Me.col_sol_num_doc, Me.col_sol_tip_doc_num, Me.DataGridViewTextBoxColumn13, Me.col_sol_fec_nac, Me.col_sol_fec_str, Me.col_sol_sex_id, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.col_est_id, Me.DataGridViewImageColumn4, Me.col_fec_reg, Me.col_sol_fec_env, Me.col_tip_mov, Me.col_sol_fec_ing, Me.col_sol_fec_egr, Me.col_sol_det_est_nom, Me.col_sol_obs, Me.col_sol_obs_img, Me.col_sol_tip_ope})
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaSolicitudes.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgwGrillaSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaSolicitudes.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaSolicitudes.Location = New System.Drawing.Point(0, 63)
            Me.dgwGrillaSolicitudes.MultiSelect = False
            Me.dgwGrillaSolicitudes.Name = "dgwGrillaSolicitudes"
            Me.dgwGrillaSolicitudes.ReadOnly = True
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgwGrillaSolicitudes.RowHeadersVisible = False
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaSolicitudes.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgwGrillaSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaSolicitudes.Size = New System.Drawing.Size(1036, 313)
            Me.dgwGrillaSolicitudes.TabIndex = 42
            Me.dgwGrillaSolicitudes.VisibleCampos = False
            '
            'col_sol_chk
            '
            Me.col_sol_chk.DividerWidth = 1
            Me.col_sol_chk.HeaderText = ""
            Me.col_sol_chk.Name = "col_sol_chk"
            Me.col_sol_chk.ReadOnly = True
            Me.col_sol_chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_sol_chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_sol_chk.Visible = False
            Me.col_sol_chk.Width = 20
            '
            'col_nro_sol
            '
            Me.col_nro_sol.DataPropertyName = "NumeroSol"
            Me.col_nro_sol.HeaderText = "Nº Sol."
            Me.col_nro_sol.Name = "col_nro_sol"
            Me.col_nro_sol.ReadOnly = True
            Me.col_nro_sol.ToolTipText = "Numero de Solicitud"
            Me.col_nro_sol.Visible = False
            Me.col_nro_sol.Width = 65
            '
            'col_sol_anio
            '
            Me.col_sol_anio.DataPropertyName = "Anio"
            Me.col_sol_anio.HeaderText = "Anho"
            Me.col_sol_anio.Name = "col_sol_anio"
            Me.col_sol_anio.ReadOnly = True
            Me.col_sol_anio.Visible = False
            Me.col_sol_anio.Width = 70
            '
            'col_sol_mes
            '
            Me.col_sol_mes.DataPropertyName = "Mes"
            Me.col_sol_mes.HeaderText = "Nº Mes"
            Me.col_sol_mes.Name = "col_sol_mes"
            Me.col_sol_mes.ReadOnly = True
            Me.col_sol_mes.Width = 65
            '
            'col_sol_tip_pob
            '
            Me.col_sol_tip_pob.DataPropertyName = "TipoPoblacion"
            Me.col_sol_tip_pob.HeaderText = "Tipo_Poblacion"
            Me.col_sol_tip_pob.Name = "col_sol_tip_pob"
            Me.col_sol_tip_pob.ReadOnly = True
            Me.col_sol_tip_pob.Visible = False
            Me.col_sol_tip_pob.Width = 80
            '
            'col_sol_pen_cod
            '
            Me.col_sol_pen_cod.DataPropertyName = "PenalCodigo"
            Me.col_sol_pen_cod.DividerWidth = 1
            Me.col_sol_pen_cod.HeaderText = "Codigo_EEPP"
            Me.col_sol_pen_cod.Name = "col_sol_pen_cod"
            Me.col_sol_pen_cod.ReadOnly = True
            Me.col_sol_pen_cod.Visible = False
            Me.col_sol_pen_cod.Width = 80
            '
            'col_sol_pen_id
            '
            Me.col_sol_pen_id.DataPropertyName = "PenalId"
            Me.col_sol_pen_id.HeaderText = "PenalId"
            Me.col_sol_pen_id.Name = "col_sol_pen_id"
            Me.col_sol_pen_id.ReadOnly = True
            Me.col_sol_pen_id.Visible = False
            '
            'col_sol_pen_nom
            '
            Me.col_sol_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_sol_pen_nom.HeaderText = "Penal"
            Me.col_sol_pen_nom.Name = "col_sol_pen_nom"
            Me.col_sol_pen_nom.ReadOnly = True
            '
            'col_sol_int_id
            '
            Me.col_sol_int_id.DataPropertyName = "InternoID"
            Me.col_sol_int_id.DividerWidth = 1
            Me.col_sol_int_id.HeaderText = "InternoID"
            Me.col_sol_int_id.Name = "col_sol_int_id"
            Me.col_sol_int_id.ReadOnly = True
            Me.col_sol_int_id.Visible = False
            '
            'col_sol_int_cod
            '
            Me.col_sol_int_cod.DataPropertyName = "CodigoRP"
            Me.col_sol_int_cod.DividerWidth = 1
            Me.col_sol_int_cod.HeaderText = "Codigo"
            Me.col_sol_int_cod.Name = "col_sol_int_cod"
            Me.col_sol_int_cod.ReadOnly = True
            Me.col_sol_int_cod.Width = 75
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "ApellidoPaterno"
            Me.DataGridViewTextBoxColumn5.HeaderText = "Primer Apellido"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            Me.DataGridViewTextBoxColumn5.Width = 105
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "ApellidoMaterno"
            Me.DataGridViewTextBoxColumn6.HeaderText = "Segundo Apellido"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 115
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nombres"
            Me.DataGridViewTextBoxColumn8.HeaderText = "Nombres"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            Me.DataGridViewTextBoxColumn8.Width = 130
            '
            'col_sol_ape_nom
            '
            Me.col_sol_ape_nom.DataPropertyName = "ApellidosyNombres"
            Me.col_sol_ape_nom.HeaderText = "Apellidos Nombres"
            Me.col_sol_ape_nom.Name = "col_sol_ape_nom"
            Me.col_sol_ape_nom.ReadOnly = True
            Me.col_sol_ape_nom.Visible = False
            Me.col_sol_ape_nom.Width = 130
            '
            'col_sol_tip_doc_env
            '
            Me.col_sol_tip_doc_env.DataPropertyName = "TipoDocumentoEnv"
            Me.col_sol_tip_doc_env.HeaderText = "Tipo_Documento"
            Me.col_sol_tip_doc_env.Name = "col_sol_tip_doc_env"
            Me.col_sol_tip_doc_env.ReadOnly = True
            Me.col_sol_tip_doc_env.Visible = False
            Me.col_sol_tip_doc_env.Width = 80
            '
            'col_sol_tip_doc_id
            '
            Me.col_sol_tip_doc_id.DataPropertyName = "TipoDocumentoNombre"
            Me.col_sol_tip_doc_id.HeaderText = "Tipo Documento"
            Me.col_sol_tip_doc_id.Name = "col_sol_tip_doc_id"
            Me.col_sol_tip_doc_id.ReadOnly = True
            Me.col_sol_tip_doc_id.Visible = False
            Me.col_sol_tip_doc_id.Width = 110
            '
            'col_sol_num_doc
            '
            Me.col_sol_num_doc.DataPropertyName = "NumeroDocumento"
            Me.col_sol_num_doc.HeaderText = "Nº Documento"
            Me.col_sol_num_doc.Name = "col_sol_num_doc"
            Me.col_sol_num_doc.ReadOnly = True
            Me.col_sol_num_doc.Visible = False
            '
            'col_sol_tip_doc_num
            '
            Me.col_sol_tip_doc_num.DataPropertyName = "TipoDocumentoyNumeroDocumento"
            Me.col_sol_tip_doc_num.HeaderText = "Doc. Identidad"
            Me.col_sol_tip_doc_num.Name = "col_sol_tip_doc_num"
            Me.col_sol_tip_doc_num.ReadOnly = True
            Me.col_sol_tip_doc_num.Width = 110
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "Edad"
            Me.DataGridViewTextBoxColumn13.HeaderText = "Edad"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.ReadOnly = True
            Me.DataGridViewTextBoxColumn13.Visible = False
            Me.DataGridViewTextBoxColumn13.Width = 45
            '
            'col_sol_fec_nac
            '
            Me.col_sol_fec_nac.DataPropertyName = "FechaNacimiento"
            DataGridViewCellStyle8.Format = "d"
            DataGridViewCellStyle8.NullValue = Nothing
            Me.col_sol_fec_nac.DefaultCellStyle = DataGridViewCellStyle8
            Me.col_sol_fec_nac.HeaderText = "F. Nacimiento"
            Me.col_sol_fec_nac.Name = "col_sol_fec_nac"
            Me.col_sol_fec_nac.ReadOnly = True
            '
            'col_sol_fec_str
            '
            Me.col_sol_fec_str.DataPropertyName = "FechaNacimientoStr"
            Me.col_sol_fec_str.HeaderText = "Fech_Nac"
            Me.col_sol_fec_str.Name = "col_sol_fec_str"
            Me.col_sol_fec_str.ReadOnly = True
            Me.col_sol_fec_str.Visible = False
            Me.col_sol_fec_str.Width = 110
            '
            'col_sol_sex_id
            '
            Me.col_sol_sex_id.DataPropertyName = "SexoID"
            Me.col_sol_sex_id.FillWeight = 50.0!
            Me.col_sol_sex_id.HeaderText = "Sexo"
            Me.col_sol_sex_id.Name = "col_sol_sex_id"
            Me.col_sol_sex_id.ReadOnly = True
            Me.col_sol_sex_id.Visible = False
            Me.col_sol_sex_id.Width = 40
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "NacionalidadNombre"
            Me.DataGridViewTextBoxColumn15.HeaderText = "Nacionalidad"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.ReadOnly = True
            Me.DataGridViewTextBoxColumn15.Visible = False
            Me.DataGridViewTextBoxColumn15.Width = 70
            '
            'DataGridViewTextBoxColumn18
            '
            Me.DataGridViewTextBoxColumn18.DataPropertyName = "RegionID"
            Me.DataGridViewTextBoxColumn18.DividerWidth = 1
            Me.DataGridViewTextBoxColumn18.HeaderText = "RegionID"
            Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
            Me.DataGridViewTextBoxColumn18.ReadOnly = True
            Me.DataGridViewTextBoxColumn18.Visible = False
            '
            'DataGridViewTextBoxColumn19
            '
            Me.DataGridViewTextBoxColumn19.DataPropertyName = "RegionNombre"
            Me.DataGridViewTextBoxColumn19.HeaderText = "Region"
            Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
            Me.DataGridViewTextBoxColumn19.ReadOnly = True
            Me.DataGridViewTextBoxColumn19.Visible = False
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "EstadoID"
            Me.col_est_id.HeaderText = "Estado"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.ReadOnly = True
            Me.col_est_id.Visible = False
            Me.col_est_id.Width = 60
            '
            'DataGridViewImageColumn4
            '
            Me.DataGridViewImageColumn4.DataPropertyName = "FotoIconoPF"
            Me.DataGridViewImageColumn4.DividerWidth = 1
            Me.DataGridViewImageColumn4.HeaderText = "F."
            Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
            Me.DataGridViewImageColumn4.ReadOnly = True
            Me.DataGridViewImageColumn4.ToolTipText = "Fotografia perfil frontal"
            Me.DataGridViewImageColumn4.Visible = False
            Me.DataGridViewImageColumn4.Width = 18
            '
            'col_fec_reg
            '
            Me.col_fec_reg.DataPropertyName = "FechaRegistro"
            Me.col_fec_reg.DividerWidth = 1
            Me.col_fec_reg.HeaderText = "FechaRegistro"
            Me.col_fec_reg.Name = "col_fec_reg"
            Me.col_fec_reg.ReadOnly = True
            Me.col_fec_reg.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_fec_reg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fec_reg.Visible = False
            Me.col_fec_reg.Width = 18
            '
            'col_sol_fec_env
            '
            Me.col_sol_fec_env.DataPropertyName = "FechaEnvio"
            Me.col_sol_fec_env.HeaderText = "FechaEnvio"
            Me.col_sol_fec_env.Name = "col_sol_fec_env"
            Me.col_sol_fec_env.ReadOnly = True
            Me.col_sol_fec_env.Visible = False
            '
            'col_tip_mov
            '
            Me.col_tip_mov.DataPropertyName = "TipoMovimientoNom"
            Me.col_tip_mov.HeaderText = "Tip. Movimiento"
            Me.col_tip_mov.Name = "col_tip_mov"
            Me.col_tip_mov.ReadOnly = True
            Me.col_tip_mov.Width = 110
            '
            'col_sol_fec_ing
            '
            Me.col_sol_fec_ing.DataPropertyName = "FechaIngreso"
            Me.col_sol_fec_ing.HeaderText = "F. Ingreso"
            Me.col_sol_fec_ing.Name = "col_sol_fec_ing"
            Me.col_sol_fec_ing.ReadOnly = True
            Me.col_sol_fec_ing.Width = 80
            '
            'col_sol_fec_egr
            '
            Me.col_sol_fec_egr.DataPropertyName = "FechaLibertad"
            Me.col_sol_fec_egr.HeaderText = "F. Egreso"
            Me.col_sol_fec_egr.Name = "col_sol_fec_egr"
            Me.col_sol_fec_egr.ReadOnly = True
            Me.col_sol_fec_egr.Width = 80
            '
            'col_sol_det_est_nom
            '
            Me.col_sol_det_est_nom.DataPropertyName = "EstadoDetalleNombre"
            Me.col_sol_det_est_nom.HeaderText = "Estado"
            Me.col_sol_det_est_nom.Name = "col_sol_det_est_nom"
            Me.col_sol_det_est_nom.ReadOnly = True
            Me.col_sol_det_est_nom.Visible = False
            Me.col_sol_det_est_nom.Width = 80
            '
            'col_sol_obs
            '
            Me.col_sol_obs.DataPropertyName = "ObservacionRegistro"
            Me.col_sol_obs.HeaderText = "ObservacionRegistro"
            Me.col_sol_obs.Name = "col_sol_obs"
            Me.col_sol_obs.ReadOnly = True
            Me.col_sol_obs.Visible = False
            Me.col_sol_obs.Width = 70
            '
            'col_sol_obs_img
            '
            Me.col_sol_obs_img.DataPropertyName = "ObservacionRegistroImg"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle9.NullValue = CType(resources.GetObject("DataGridViewCellStyle9.NullValue"), Object)
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
            Me.col_sol_obs_img.DefaultCellStyle = DataGridViewCellStyle9
            Me.col_sol_obs_img.DividerWidth = 1
            Me.col_sol_obs_img.HeaderText = "Obs."
            Me.col_sol_obs_img.Name = "col_sol_obs_img"
            Me.col_sol_obs_img.ReadOnly = True
            Me.col_sol_obs_img.ToolTipText = "Registro observado"
            Me.col_sol_obs_img.Width = 40
            '
            'col_sol_tip_ope
            '
            Me.col_sol_tip_ope.DataPropertyName = "TipoOperacion"
            Me.col_sol_tip_ope.HeaderText = "Tipo_Operacion"
            Me.col_sol_tip_ope.Name = "col_sol_tip_ope"
            Me.col_sol_tip_ope.ReadOnly = True
            Me.col_sol_tip_ope.Visible = False
            Me.col_sol_tip_ope.Width = 90
            '
            'gbBusqueda
            '
            Me.gbBusqueda.Controls.Add(Me.lblEtiqueta)
            Me.gbBusqueda.Controls.Add(Me.txtFechaEnvio)
            Me.gbBusqueda.Controls.Add(Me.Label35)
            Me.gbBusqueda.Controls.Add(Me.txtFechaRegistro)
            Me.gbBusqueda.Controls.Add(Me.Label33)
            Me.gbBusqueda.Controls.Add(Me.txtEstadoSolicitud)
            Me.gbBusqueda.Controls.Add(Me.Label32)
            Me.gbBusqueda.Controls.Add(Me.cbbMes)
            Me.gbBusqueda.Controls.Add(Me.ckbVer)
            Me.gbBusqueda.Controls.Add(Me.cbbRegistro)
            Me.gbBusqueda.Controls.Add(Me.cbbAnio)
            Me.gbBusqueda.Controls.Add(Me.Label11)
            Me.gbBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.gbBusqueda.Name = "gbBusqueda"
            Me.gbBusqueda.Size = New System.Drawing.Size(1036, 63)
            Me.gbBusqueda.TabIndex = 0
            Me.gbBusqueda.TabStop = False
            '
            'lblEtiqueta
            '
            Me.lblEtiqueta.AutoSize = True
            Me.lblEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiqueta.Location = New System.Drawing.Point(3, 44)
            Me.lblEtiqueta.Name = "lblEtiqueta"
            Me.lblEtiqueta.Size = New System.Drawing.Size(324, 15)
            Me.lblEtiqueta.TabIndex = 13
            Me.lblEtiqueta.Text = "Lista de Procesados/Sentenciados para Afiliación"
            '
            'txtFechaEnvio
            '
            Me.txtFechaEnvio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaEnvio._BloquearPaste = False
            Me.txtFechaEnvio._SeleccionarTodo = True
            Me.txtFechaEnvio.Location = New System.Drawing.Point(888, 37)
            Me.txtFechaEnvio.Name = "txtFechaEnvio"
            Me.txtFechaEnvio.ReadOnly = True
            Me.txtFechaEnvio.Size = New System.Drawing.Size(140, 20)
            Me.txtFechaEnvio.TabIndex = 12
            Me.txtFechaEnvio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaEnvio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Location = New System.Drawing.Point(809, 40)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(74, 13)
            Me.Label35.TabIndex = 11
            Me.Label35.Text = "Fecha envío :"
            '
            'txtFechaRegistro
            '
            Me.txtFechaRegistro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaRegistro._BloquearPaste = False
            Me.txtFechaRegistro._SeleccionarTodo = True
            Me.txtFechaRegistro.Location = New System.Drawing.Point(666, 37)
            Me.txtFechaRegistro.Name = "txtFechaRegistro"
            Me.txtFechaRegistro.ReadOnly = True
            Me.txtFechaRegistro.Size = New System.Drawing.Size(120, 20)
            Me.txtFechaRegistro.TabIndex = 10
            Me.txtFechaRegistro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaRegistro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Location = New System.Drawing.Point(583, 41)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(80, 13)
            Me.Label33.TabIndex = 9
            Me.Label33.Text = "Fecha registro :"
            '
            'txtEstadoSolicitud
            '
            Me.txtEstadoSolicitud._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstadoSolicitud._BloquearPaste = False
            Me.txtEstadoSolicitud._SeleccionarTodo = True
            Me.txtEstadoSolicitud.Location = New System.Drawing.Point(666, 11)
            Me.txtEstadoSolicitud.Name = "txtEstadoSolicitud"
            Me.txtEstadoSolicitud.ReadOnly = True
            Me.txtEstadoSolicitud.Size = New System.Drawing.Size(120, 20)
            Me.txtEstadoSolicitud.TabIndex = 6
            Me.txtEstadoSolicitud.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstadoSolicitud.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Location = New System.Drawing.Point(583, 15)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(46, 13)
            Me.Label32.TabIndex = 5
            Me.Label32.Text = "Estado :"
            '
            'cbbMes
            '
            Me.cbbMes._Todos = True
            Me.cbbMes.Location = New System.Drawing.Point(227, 11)
            Me.cbbMes.Mes = -1
            Me.cbbMes.MesAbreviatura = False
            Me.cbbMes.Name = "cbbMes"
            Me.cbbMes.Size = New System.Drawing.Size(126, 21)
            Me.cbbMes.TabIndex = 2
            Me.cbbMes.Value = -1
            '
            'ckbVer
            '
            Me.ckbVer.AutoSize = True
            Me.ckbVer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbVer.Location = New System.Drawing.Point(395, 14)
            Me.ckbVer.Name = "ckbVer"
            Me.ckbVer.Size = New System.Drawing.Size(145, 17)
            Me.ckbVer.TabIndex = 4
            Me.ckbVer.Text = "Ver registros no enviados"
            Me.ckbVer.UseVisualStyleBackColor = True
            Me.ckbVer.Visible = False
            '
            'cbbRegistro
            '
            Me.cbbRegistro._NoIndica = False
            Me.cbbRegistro._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegistro._Todos = False
            Me.cbbRegistro._TodosMensaje = ""
            Me.cbbRegistro._Visible_Add = False
            Me.cbbRegistro._Visible_Buscar = False
            Me.cbbRegistro._Visible_Eliminar = False
            Me.cbbRegistro.CodigoPadre = -1
            Me.cbbRegistro.ComboTipo = Type.Combo.ComboTipo.SolicitudSIS
            Me.cbbRegistro.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegistro.DropDownWidth = 200
            Me.cbbRegistro.DropDownWidthAuto = False
            Me.cbbRegistro.ListaIdsParaExcluir = Nothing
            Me.cbbRegistro.Location = New System.Drawing.Point(357, 11)
            Me.cbbRegistro.Name = "cbbRegistro"
            Me.cbbRegistro.Parametro1 = -1
            Me.cbbRegistro.Parametro2 = -1
            Me.cbbRegistro.SelectedIndex = -1
            Me.cbbRegistro.SelectedValue = 0
            Me.cbbRegistro.Size = New System.Drawing.Size(15, 22)
            Me.cbbRegistro.TabIndex = 3
            Me.cbbRegistro.Visible = False
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 1900
            Me.cbbAnio.Location = New System.Drawing.Point(106, 11)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(116, 21)
            Me.cbbAnio.TabIndex = 1
            Me.cbbAnio.Value = -1
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(8, 15)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(91, 13)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Año/ Mes / Reg :"
            '
            'pnlPiesolicitud
            '
            Me.pnlPiesolicitud.Controls.Add(Me.GroupBox14)
            Me.pnlPiesolicitud.Controls.Add(Me.GroupBox13)
            Me.pnlPiesolicitud.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPiesolicitud.Location = New System.Drawing.Point(0, 376)
            Me.pnlPiesolicitud.Name = "pnlPiesolicitud"
            Me.pnlPiesolicitud.Size = New System.Drawing.Size(1036, 138)
            Me.pnlPiesolicitud.TabIndex = 1
            '
            'GroupBox14
            '
            Me.GroupBox14.Controls.Add(Me.dgwResumen)
            Me.GroupBox14.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox14.Location = New System.Drawing.Point(572, 0)
            Me.GroupBox14.Name = "GroupBox14"
            Me.GroupBox14.Size = New System.Drawing.Size(464, 138)
            Me.GroupBox14.TabIndex = 0
            Me.GroupBox14.TabStop = False
            Me.GroupBox14.Text = "Resumen"
            '
            'dgwResumen
            '
            Me.dgwResumen.AllowUserToAddRows = False
            Me.dgwResumen.AllowUserToDeleteRows = False
            Me.dgwResumen.AllowUserToResizeRows = False
            Me.dgwResumen.BackgroundColor = System.Drawing.Color.White
            Me.dgwResumen.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwResumen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgwResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.col_res_lib, Me.col_res_tras, Me.col_res_ning})
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwResumen.DefaultCellStyle = DataGridViewCellStyle14
            Me.dgwResumen.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwResumen.GridColor = System.Drawing.Color.LightGray
            Me.dgwResumen.Location = New System.Drawing.Point(3, 16)
            Me.dgwResumen.MultiSelect = False
            Me.dgwResumen.Name = "dgwResumen"
            Me.dgwResumen.ReadOnly = True
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwResumen.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgwResumen.RowHeadersVisible = False
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwResumen.RowsDefaultCellStyle = DataGridViewCellStyle16
            Me.dgwResumen.RowTemplate.Height = 20
            Me.dgwResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwResumen.Size = New System.Drawing.Size(458, 119)
            Me.dgwResumen.TabIndex = 40
            Me.dgwResumen.VisibleCampos = False
            '
            'DataGridViewTextBoxColumn42
            '
            Me.DataGridViewTextBoxColumn42.DataPropertyName = "RegionID"
            Me.DataGridViewTextBoxColumn42.DividerWidth = 1
            Me.DataGridViewTextBoxColumn42.HeaderText = "RegionID"
            Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
            Me.DataGridViewTextBoxColumn42.ReadOnly = True
            Me.DataGridViewTextBoxColumn42.Visible = False
            '
            'DataGridViewTextBoxColumn43
            '
            Me.DataGridViewTextBoxColumn43.DataPropertyName = "RegionNombre"
            Me.DataGridViewTextBoxColumn43.HeaderText = "Region"
            Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
            Me.DataGridViewTextBoxColumn43.ReadOnly = True
            Me.DataGridViewTextBoxColumn43.Width = 120
            '
            'DataGridViewTextBoxColumn44
            '
            Me.DataGridViewTextBoxColumn44.DataPropertyName = "PenalID"
            Me.DataGridViewTextBoxColumn44.DividerWidth = 1
            Me.DataGridViewTextBoxColumn44.HeaderText = "PenalID"
            Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
            Me.DataGridViewTextBoxColumn44.ReadOnly = True
            Me.DataGridViewTextBoxColumn44.Visible = False
            '
            'DataGridViewTextBoxColumn45
            '
            Me.DataGridViewTextBoxColumn45.DataPropertyName = "PenalNombre"
            Me.DataGridViewTextBoxColumn45.HeaderText = "Penal"
            Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
            Me.DataGridViewTextBoxColumn45.ReadOnly = True
            Me.DataGridViewTextBoxColumn45.Width = 130
            '
            'DataGridViewTextBoxColumn46
            '
            Me.DataGridViewTextBoxColumn46.DataPropertyName = "Cantidad"
            Me.DataGridViewTextBoxColumn46.HeaderText = "Cant. Internos"
            Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
            Me.DataGridViewTextBoxColumn46.ReadOnly = True
            '
            'DataGridViewTextBoxColumn47
            '
            Me.DataGridViewTextBoxColumn47.DataPropertyName = "Ingresos"
            Me.DataGridViewTextBoxColumn47.HeaderText = "Ingresos"
            Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
            Me.DataGridViewTextBoxColumn47.ReadOnly = True
            Me.DataGridViewTextBoxColumn47.ToolTipText = "Estado fisico del interno"
            Me.DataGridViewTextBoxColumn47.Width = 60
            '
            'col_res_lib
            '
            Me.col_res_lib.DataPropertyName = "Egresos"
            Me.col_res_lib.HeaderText = "Libertad"
            Me.col_res_lib.Name = "col_res_lib"
            Me.col_res_lib.ReadOnly = True
            Me.col_res_lib.Width = 60
            '
            'col_res_tras
            '
            Me.col_res_tras.DataPropertyName = "Traslados"
            Me.col_res_tras.HeaderText = "Traslados"
            Me.col_res_tras.Name = "col_res_tras"
            Me.col_res_tras.ReadOnly = True
            Me.col_res_tras.Width = 65
            '
            'col_res_ning
            '
            Me.col_res_ning.DataPropertyName = "Ninguno"
            Me.col_res_ning.HeaderText = "Ninguna"
            Me.col_res_ning.Name = "col_res_ning"
            Me.col_res_ning.ReadOnly = True
            Me.col_res_ning.Visible = False
            '
            'GroupBox13
            '
            Me.GroupBox13.Controls.Add(Me.chkRegistrosObservados)
            Me.GroupBox13.Controls.Add(Me.txtDocumentoBusca)
            Me.GroupBox13.Controls.Add(Me.Label39)
            Me.GroupBox13.Controls.Add(Me.txtApellidosNombresBus)
            Me.GroupBox13.Controls.Add(Me.Label36)
            Me.GroupBox13.Controls.Add(Me.cbbEstablecimientoPenitenciario)
            Me.GroupBox13.Controls.Add(Me.Label31)
            Me.GroupBox13.Controls.Add(Me.Label30)
            Me.GroupBox13.Controls.Add(Me.cbbOficinaRegional)
            Me.GroupBox13.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox13.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox13.Name = "GroupBox13"
            Me.GroupBox13.Size = New System.Drawing.Size(572, 138)
            Me.GroupBox13.TabIndex = 0
            Me.GroupBox13.TabStop = False
            Me.GroupBox13.Text = "Filtrar persona :"
            '
            'chkRegistrosObservados
            '
            Me.chkRegistrosObservados.AutoSize = True
            Me.chkRegistrosObservados.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkRegistrosObservados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkRegistrosObservados.Location = New System.Drawing.Point(439, 64)
            Me.chkRegistrosObservados.Name = "chkRegistrosObservados"
            Me.chkRegistrosObservados.Size = New System.Drawing.Size(128, 17)
            Me.chkRegistrosObservados.TabIndex = 6
            Me.chkRegistrosObservados.Text = "Registros observados"
            Me.chkRegistrosObservados.UseVisualStyleBackColor = True
            '
            'txtDocumentoBusca
            '
            Me.txtDocumentoBusca._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDocumentoBusca._BloquearPaste = False
            Me.txtDocumentoBusca._SeleccionarTodo = True
            Me.txtDocumentoBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocumentoBusca.Location = New System.Drawing.Point(124, 61)
            Me.txtDocumentoBusca.Name = "txtDocumentoBusca"
            Me.txtDocumentoBusca.Size = New System.Drawing.Size(187, 20)
            Me.txtDocumentoBusca.TabIndex = 5
            Me.txtDocumentoBusca.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDocumentoBusca.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label39
            '
            Me.Label39.AutoSize = True
            Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label39.Location = New System.Drawing.Point(4, 64)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(114, 13)
            Me.Label39.TabIndex = 4
            Me.Label39.Text = "Documento identidad :"
            '
            'txtApellidosNombresBus
            '
            Me.txtApellidosNombresBus._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidosNombresBus._BloquearPaste = False
            Me.txtApellidosNombresBus._SeleccionarTodo = True
            Me.txtApellidosNombresBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidosNombresBus.Location = New System.Drawing.Point(124, 99)
            Me.txtApellidosNombresBus.Name = "txtApellidosNombresBus"
            Me.txtApellidosNombresBus.Size = New System.Drawing.Size(442, 20)
            Me.txtApellidosNombresBus.TabIndex = 8
            Me.txtApellidosNombresBus.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidosNombresBus.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label36
            '
            Me.Label36.AutoSize = True
            Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.Location = New System.Drawing.Point(4, 103)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(105, 13)
            Me.Label36.TabIndex = 7
            Me.Label36.Text = "Apellidos y Nombres:"
            '
            'cbbEstablecimientoPenitenciario
            '
            Me.cbbEstablecimientoPenitenciario._NoIndica = False
            Me.cbbEstablecimientoPenitenciario._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbEstablecimientoPenitenciario._Todos = False
            Me.cbbEstablecimientoPenitenciario._TodosMensaje = ""
            Me.cbbEstablecimientoPenitenciario._Visible_Add = False
            Me.cbbEstablecimientoPenitenciario._Visible_Buscar = False
            Me.cbbEstablecimientoPenitenciario._Visible_Eliminar = False
            Me.cbbEstablecimientoPenitenciario.CodigoPadre = -1
            Me.cbbEstablecimientoPenitenciario.ComboTipo = Type.Combo.ComboTipo.Penal
            Me.cbbEstablecimientoPenitenciario.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbEstablecimientoPenitenciario.DropDownWidth = 238
            Me.cbbEstablecimientoPenitenciario.DropDownWidthAuto = False
            Me.cbbEstablecimientoPenitenciario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbEstablecimientoPenitenciario.ListaIdsParaExcluir = Nothing
            Me.cbbEstablecimientoPenitenciario.Location = New System.Drawing.Point(379, 16)
            Me.cbbEstablecimientoPenitenciario.Name = "cbbEstablecimientoPenitenciario"
            Me.cbbEstablecimientoPenitenciario.Parametro1 = -1
            Me.cbbEstablecimientoPenitenciario.Parametro2 = -1
            Me.cbbEstablecimientoPenitenciario.SelectedIndex = -1
            Me.cbbEstablecimientoPenitenciario.SelectedValue = 0
            Me.cbbEstablecimientoPenitenciario.Size = New System.Drawing.Size(188, 22)
            Me.cbbEstablecimientoPenitenciario.TabIndex = 3
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label31.Location = New System.Drawing.Point(325, 17)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(51, 13)
            Me.Label31.TabIndex = 2
            Me.Label31.Text = "Penales :"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(27, 21)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(91, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "Oficina Regional :"
            '
            'cbbOficinaRegional
            '
            Me.cbbOficinaRegional._NoIndica = False
            Me.cbbOficinaRegional._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbOficinaRegional._Todos = False
            Me.cbbOficinaRegional._TodosMensaje = ""
            Me.cbbOficinaRegional._Visible_Add = False
            Me.cbbOficinaRegional._Visible_Buscar = False
            Me.cbbOficinaRegional._Visible_Eliminar = False
            Me.cbbOficinaRegional.CodigoPadre = -1
            Me.cbbOficinaRegional.ComboTipo = Type.Combo.ComboTipo.Region
            Me.cbbOficinaRegional.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbOficinaRegional.DropDownWidth = 178
            Me.cbbOficinaRegional.DropDownWidthAuto = False
            Me.cbbOficinaRegional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbOficinaRegional.ListaIdsParaExcluir = Nothing
            Me.cbbOficinaRegional.Location = New System.Drawing.Point(124, 16)
            Me.cbbOficinaRegional.Name = "cbbOficinaRegional"
            Me.cbbOficinaRegional.Parametro1 = -1
            Me.cbbOficinaRegional.Parametro2 = -1
            Me.cbbOficinaRegional.SelectedIndex = -1
            Me.cbbOficinaRegional.SelectedValue = 0
            Me.cbbOficinaRegional.Size = New System.Drawing.Size(187, 22)
            Me.cbbOficinaRegional.TabIndex = 1
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.Panel9)
            Me.pnlCabecera.Controls.Add(Me.GroupBox16)
            Me.pnlCabecera.Controls.Add(Me.gbBotones)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlCabecera.Location = New System.Drawing.Point(1039, 3)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(209, 514)
            Me.pnlCabecera.TabIndex = 41
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.UscFotografia_2v3)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel9.Location = New System.Drawing.Point(0, 104)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(209, 272)
            Me.Panel9.TabIndex = 41
            '
            'UscFotografia_2v3
            '
            Me.UscFotografia_2v3._CheckImagen = False
            Me.UscFotografia_2v3._EnabledDobleClick = True
            Me.UscFotografia_2v3._HasImagen = False
            Me.UscFotografia_2v3._PanelAutorizacion = False
            Me.UscFotografia_2v3._PanelCheck = False
            Me.UscFotografia_2v3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v3.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v3.Name = "UscFotografia_2v3"
            Me.UscFotografia_2v3.Size = New System.Drawing.Size(209, 272)
            Me.UscFotografia_2v3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v3.TabIndex = 1
            '
            'GroupBox16
            '
            Me.GroupBox16.Controls.Add(Me.lblSegundoSol)
            Me.GroupBox16.Controls.Add(Me.lblRegSolicitud)
            Me.GroupBox16.Controls.Add(Me.tsbBuscarSolicitudes)
            Me.GroupBox16.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox16.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox16.Name = "GroupBox16"
            Me.GroupBox16.Size = New System.Drawing.Size(209, 104)
            Me.GroupBox16.TabIndex = 28
            Me.GroupBox16.TabStop = False
            '
            'lblSegundoSol
            '
            Me.lblSegundoSol.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSegundoSol.AutoSize = True
            Me.lblSegundoSol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblSegundoSol.Location = New System.Drawing.Point(81, 68)
            Me.lblSegundoSol.Name = "lblSegundoSol"
            Me.lblSegundoSol.Size = New System.Drawing.Size(49, 13)
            Me.lblSegundoSol.TabIndex = 1
            Me.lblSegundoSol.Text = "00:00:00"
            Me.lblSegundoSol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblRegSolicitud
            '
            Me.lblRegSolicitud.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblRegSolicitud.Location = New System.Drawing.Point(3, 87)
            Me.lblRegSolicitud.Name = "lblRegSolicitud"
            Me.lblRegSolicitud.Size = New System.Drawing.Size(203, 14)
            Me.lblRegSolicitud.TabIndex = 2
            Me.lblRegSolicitud.Text = "0 Reg."
            Me.lblRegSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'tsbBuscarSolicitudes
            '
            Me.tsbBuscarSolicitudes.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscarSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tsbBuscarSolicitudes.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.tsbBuscarSolicitudes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.tsbBuscarSolicitudes.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.tsbBuscarSolicitudes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbListarSolicitudesAfi})
            Me.tsbBuscarSolicitudes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.tsbBuscarSolicitudes.Location = New System.Drawing.Point(3, 16)
            Me.tsbBuscarSolicitudes.Name = "tsbBuscarSolicitudes"
            Me.tsbBuscarSolicitudes.Size = New System.Drawing.Size(203, 85)
            Me.tsbBuscarSolicitudes.TabIndex = 0
            Me.tsbBuscarSolicitudes.Text = "ToolStrip3"
            '
            'tsbListarSolicitudesAfi
            '
            Me.tsbListarSolicitudesAfi.BackColor = System.Drawing.Color.Transparent
            Me.tsbListarSolicitudesAfi.Image = CType(resources.GetObject("tsbListarSolicitudesAfi.Image"), System.Drawing.Image)
            Me.tsbListarSolicitudesAfi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbListarSolicitudesAfi.Name = "tsbListarSolicitudesAfi"
            Me.tsbListarSolicitudesAfi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tsbListarSolicitudesAfi.Size = New System.Drawing.Size(201, 43)
            Me.tsbListarSolicitudesAfi.Text = "Buscar"
            Me.tsbListarSolicitudesAfi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbListarSolicitudesAfi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'gbBotones
            '
            Me.gbBotones.Controls.Add(Me.ToolStrip2)
            Me.gbBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gbBotones.Location = New System.Drawing.Point(0, 376)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(209, 138)
            Me.gbBotones.TabIndex = 1
            Me.gbBotones.TabStop = False
            '
            'ToolStrip2
            '
            Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGenerarSolicitud, Me.tsbExportar})
            Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip2.Name = "ToolStrip2"
            Me.ToolStrip2.Size = New System.Drawing.Size(203, 119)
            Me.ToolStrip2.TabIndex = 0
            Me.ToolStrip2.Text = "ToolStrip2"
            '
            'tsbGenerarSolicitud
            '
            Me.tsbGenerarSolicitud.BackColor = System.Drawing.Color.Transparent
            Me.tsbGenerarSolicitud.Image = CType(resources.GetObject("tsbGenerarSolicitud.Image"), System.Drawing.Image)
            Me.tsbGenerarSolicitud.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbGenerarSolicitud.Name = "tsbGenerarSolicitud"
            Me.tsbGenerarSolicitud.Size = New System.Drawing.Size(201, 43)
            Me.tsbGenerarSolicitud.Text = "Generar Solicitud"
            Me.tsbGenerarSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbGenerarSolicitud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tsbExportar
            '
            Me.tsbExportar.BackColor = System.Drawing.Color.Transparent
            Me.tsbExportar.Image = CType(resources.GetObject("tsbExportar.Image"), System.Drawing.Image)
            Me.tsbExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbExportar.Name = "tsbExportar"
            Me.tsbExportar.Size = New System.Drawing.Size(201, 43)
            Me.tsbExportar.Text = "Exportar"
            Me.tsbExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbExportar.ToolTipText = "Exportar"
            '
            'pnlInferior
            '
            Me.pnlInferior.Controls.Add(Me.pnlBotonOtros)
            Me.pnlInferior.Controls.Add(Me.pnlBotonReporte)
            Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlInferior.Location = New System.Drawing.Point(0, 546)
            Me.pnlInferior.Name = "pnlInferior"
            Me.pnlInferior.Size = New System.Drawing.Size(1259, 50)
            Me.pnlInferior.TabIndex = 43
            '
            'pnlBotonOtros
            '
            Me.pnlBotonOtros.Controls.Add(Me.btnFicha)
            Me.pnlBotonOtros.Controls.Add(Me.btnSalir)
            Me.pnlBotonOtros.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonOtros.Location = New System.Drawing.Point(95, 0)
            Me.pnlBotonOtros.Name = "pnlBotonOtros"
            Me.pnlBotonOtros.Size = New System.Drawing.Size(890, 50)
            Me.pnlBotonOtros.TabIndex = 74
            '
            'btnFicha
            '
            Me.btnFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFicha.Image = CType(resources.GetObject("btnFicha.Image"), System.Drawing.Image)
            Me.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.Location = New System.Drawing.Point(91, 6)
            Me.btnFicha.Name = "btnFicha"
            Me.btnFicha.Size = New System.Drawing.Size(90, 40)
            Me.btnFicha.TabIndex = 67
            Me.btnFicha.Text = "&Reportes"
            Me.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnFicha.UseVisualStyleBackColor = True
            Me.btnFicha.Visible = False
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(5, 5)
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
            Me.pnlBotonReporte.Controls.Add(Me.btnExportar)
            Me.pnlBotonReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonReporte.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotonReporte.Name = "pnlBotonReporte"
            Me.pnlBotonReporte.Size = New System.Drawing.Size(95, 50)
            Me.pnlBotonReporte.TabIndex = 73
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(2, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
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
            'pnlDetalle
            '
            Me.pnlDetalle.Controls.Add(Me.pnlCuerpoPrincipal)
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
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "baby.png")
            '
            'BackgroundWorker2
            '
            Me.BackgroundWorker2.WorkerSupportsCancellation = True
            '
            'BackgroundWorker3
            '
            '
            'frmBuscarSIS
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1259, 596)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Name = "frmBuscarSIS"
            Me.Text = "Busqueda "
            Me.pnlBusqueda.ResumeLayout(False)
            Me.grbBusqueda.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlCuerpoPrincipal.ResumeLayout(False)
            Me.tcPrincipal.ResumeLayout(False)
            Me.tpPoblacionInterno.ResumeLayout(False)
            Me.tcInternos.ResumeLayout(False)
            Me.tpBusquedaInternos.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFotografia.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.tpDatosPersonales.ResumeLayout(False)
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.GroupBox11.ResumeLayout(False)
            Me.GroupBox11.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox10.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.tpSolicitudAfiliaciones.ResumeLayout(False)
            Me.pnlSolicitudes.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            CType(Me.dgwGrillaSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBusqueda.ResumeLayout(False)
            Me.gbBusqueda.PerformLayout()
            Me.pnlPiesolicitud.ResumeLayout(False)
            Me.GroupBox14.ResumeLayout(False)
            CType(Me.dgwResumen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox13.ResumeLayout(False)
            Me.GroupBox13.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.GroupBox16.ResumeLayout(False)
            Me.GroupBox16.PerformLayout()
            Me.tsbBuscarSolicitudes.ResumeLayout(False)
            Me.tsbBuscarSolicitudes.PerformLayout()
            Me.gbBotones.ResumeLayout(False)
            Me.gbBotones.PerformLayout()
            Me.ToolStrip2.ResumeLayout(False)
            Me.ToolStrip2.PerformLayout()
            Me.pnlInferior.ResumeLayout(False)
            Me.pnlBotonOtros.ResumeLayout(False)
            Me.pnlBotonReporte.ResumeLayout(False)
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
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents rdbEstadoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSexoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbMuj As System.Windows.Forms.RadioButton
        Friend WithEvents rdbHom As System.Windows.Forms.RadioButton
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        'Friend WithEvents UscGrillaCampo1 As APPControls.Grilla.uscGrillaCampo
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents tcPrincipal As System.Windows.Forms.TabControl
        Friend WithEvents tpPoblacionInterno As System.Windows.Forms.TabPage
        Friend WithEvents tpSolicitudAfiliaciones As System.Windows.Forms.TabPage
        Friend WithEvents pnlInferior As System.Windows.Forms.Panel
        Friend WithEvents pnlCuerpoPrincipal As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbAfiliacionTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbAfiliacionNO As System.Windows.Forms.RadioButton
        Friend WithEvents rdbAfiliacionSI As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumeroDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents tcInternos As System.Windows.Forms.TabControl
        Friend WithEvents tpBusquedaInternos As System.Windows.Forms.TabPage
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents tpDatosPersonales As System.Windows.Forms.TabPage
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents pnlFotografia As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblSegundo As System.Windows.Forms.Label
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents pnlBotonOtros As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlBotonReporte As System.Windows.Forms.Panel
        Friend WithEvents btnFicha As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents txtTipoNumeroDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEdad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents rbtFemenino As System.Windows.Forms.RadioButton
        Friend WithEvents rbtMasculino As System.Windows.Forms.RadioButton
        Friend WithEvents dtpFechaAfi As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents txtApellidoPat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtApellidoMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtCodigoInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaLibertad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtFechaIngreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents rbtAfiliacionNO As System.Windows.Forms.RadioButton
        Friend WithEvents rbtAfiliacionSI As System.Windows.Forms.RadioButton
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
        Friend WithEvents rbtNoRNC As System.Windows.Forms.RadioButton
        Friend WithEvents rbtSiRNC As System.Windows.Forms.RadioButton
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents UscFotografia_2v2 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtEstadoCivil As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDistritoNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtProvinciaNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDepartamentoNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPaisNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents pnlPiesolicitud As System.Windows.Forms.Panel
        Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwResumen As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents txtDocumentoBusca As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents txtApellidosNombresBus As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbGenerarSolicitud As System.Windows.Forms.ToolStripButton
        Public WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
        Friend WithEvents pnlSolicitudes As System.Windows.Forms.Panel
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaEnvio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents txtFechaRegistro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents txtEstadoSolicitud As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents cbbEstablecimientoPenitenciario As APPControls.uscComboParametrica
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents cbbOficinaRegional As APPControls.uscComboParametrica
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
        Public WithEvents tsbBuscarSolicitudes As System.Windows.Forms.ToolStrip
        Public WithEvents tsbListarSolicitudesAfi As System.Windows.Forms.ToolStripButton
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents cbbRegistro As APPControls.uscComboParametrica
        Friend WithEvents lblRegSolicitud As System.Windows.Forms.Label
        Friend WithEvents ckbVer As System.Windows.Forms.CheckBox
        Friend WithEvents UscFotografia_2v3 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents dgwGrillaSolicitudes As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents cbbMes As Legolas.APPUIComponents.uscComboMes
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents lblSegundoSol As System.Windows.Forms.Label
        Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
        Friend WithEvents lblEtiqueta As System.Windows.Forms.Label
        Friend WithEvents chkRegistrosObservados As System.Windows.Forms.CheckBox
        Friend WithEvents txtMadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtpadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents txtNacionalidad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label40 As System.Windows.Forms.Label
        Friend WithEvents btnValidarReniec As System.Windows.Forms.Button
        Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Label41 As System.Windows.Forms.Label
        Friend WithEvents col_pdr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod_rp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_nac As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pabellon As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_gen As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fot_ico_pi As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_fot_ico_pf As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_fot_ico_pd As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_afil_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_res_lib As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_res_tras As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_res_ning As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_nro_sol As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_anio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_mes As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_tip_pob As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_pen_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_int_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_ape_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_tip_doc_env As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_tip_doc_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_tip_doc_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_fec_nac As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_fec_str As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_sex_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_fec_env As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_mov As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_fec_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_fec_egr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_det_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sol_obs_img As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_sol_tip_ope As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace

