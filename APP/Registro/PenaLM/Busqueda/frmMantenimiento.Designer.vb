Namespace Registro.PenalLM.Busqueda
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMantenimiento
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimiento))
            Me.pnlNuevoReniec = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.tbpInterno = New System.Windows.Forms.TabPage()
            Me.tcDatosInternos = New System.Windows.Forms.TabControl()
            Me.tbpDatos = New System.Windows.Forms.TabPage()
            Me.pnlDatosPer = New System.Windows.Forms.Panel()
            Me.pnlDatosAca = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.grpVerificarReniec = New System.Windows.Forms.GroupBox()
            Me.txtApellidosNombresreniec = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaVerRnc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTipoVerRnc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtEstadoVerRnc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtObservacionRnc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.txtDecadactDer = New System.Windows.Forms.TextBox()
            Me.txtDecadactIzq = New System.Windows.Forms.TextBox()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.cbbAndina = New APPControls.uscComboParametrica()
            Me.cbbAndinaEsp = New APPControls.uscComboParametrica()
            Me.txtPabellon = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbPabellon = New APPControls.uscComboParametrica()
            Me.pnlUbigeo = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.cbbNivelAca = New APPControls.uscComboParametrica()
            Me.cbbProfesion = New APPControls.uscComboParametrica()
            Me.cbbOcupacion = New APPControls.uscComboParametrica()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtDomicilio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.cbbDomicilioDist = New System.Windows.Forms.ComboBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cbbDomicilioProv = New System.Windows.Forms.ComboBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.cbbDomicilioDepa = New System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtUbigeoOtro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbDistrito = New System.Windows.Forms.ComboBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbbProvincia = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.CbbDepartamento = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbPais = New System.Windows.Forms.ComboBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.chk_Homonimia = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.txtObs_dni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.chk_Obs_DNI = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.chkNoindica = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label31 = New System.Windows.Forms.Label()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.cbbSexo = New APPControls.uscComboParametrica()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.cbbEstadoCivil = New APPControls.uscComboParametrica()
            Me.cbbDiscapacitado = New APPControls.uscComboParametrica()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.tbpDatosComplement = New System.Windows.Forms.TabPage()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UscEtniaLenguaMaterna_v21 = New APPControls.Registro.Identificacion.uscEtniaLenguaMaterna_v2()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.UscDomicilio1 = New APPControls.Registro.Identificacion.uscDomicilio()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.UscGradosAcademicos1 = New APPControls.Registro.Identificacion.uscGradosAcademicos()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.cbbCentroReclu = New System.Windows.Forms.ComboBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.cbbCodFuerArmada = New System.Windows.Forms.ComboBox()
            Me.cbbCodigoRango = New System.Windows.Forms.ComboBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtNomClaveInt = New System.Windows.Forms.TextBox()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.UscIdiomaInterno1 = New APPControls.Registro.Identificacion.uscIdiomaInterno()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.cbbIdiomaPrincipal = New APPControls.uscComboParametrica()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.cbbGenero = New APPControls.uscComboParametrica()
            Me.txtCentroTrabajo = New System.Windows.Forms.TextBox()
            Me.cbbReligion = New APPControls.uscComboParametrica()
            Me.tbpNombresAsoc = New System.Windows.Forms.TabPage()
            Me.UscGrillaNombresAsociadosV21 = New APPControls.Registro.uscGrillaNombresAsociadosV2()
            Me.tbpFoto = New System.Windows.Forms.TabPage()
            Me.uscFotoPerfiles = New APPControls.Registro.Captura.uscFotografia_LM()
            Me.tbpReniec = New System.Windows.Forms.TabPage()
            Me.UscValidacionReniecV21 = New APPControls.Registro.Reniec.v5.uscValidacionReniecV2_LM()
            Me.tbpAliasBandas = New System.Windows.Forms.TabPage()
            Me.UscBandas21 = New APPControls.Registro.Identificacion.v5.UserBandas_LM()
            Me.UscAlias21 = New APPControls.Registro.Identificacion.v5.uscAlias2()
            Me.tbpBandas = New System.Windows.Forms.TabPage()
            Me.UscOrganizacionCriminal = New APPControls.Registro.Siscrico.uscGrillaOrgCriminal_LM()
            Me.tbpFamiliares = New System.Windows.Forms.TabPage()
            Me.UscFamilias1 = New APPControls.Registro.Identificacion.v5.uscFamilia()
            Me.tbpOdontograma = New System.Windows.Forms.TabPage()
            Me.UscOdont = New APPControls.Registro.Odontograma.uscOdontogramaMain_LM()
            Me.tbpHuella = New System.Windows.Forms.TabPage()
            Me.UscVisorDetalleHuellas1 = New APPControls.Registro.Huellas.uscVisorDetalleHuellas()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.pnlPiePagina = New System.Windows.Forms.Panel()
            Me.pnlAuditoria = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.pnlUpdateDocJud = New System.Windows.Forms.Panel()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnIngreso = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnFicha = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tbpMandDet = New System.Windows.Forms.TabPage()
            Me.TabControl3 = New System.Windows.Forms.TabControl()
            Me.tbpListaExpedientes = New System.Windows.Forms.TabPage()
            Me.btnDelitosHistoricos = New System.Windows.Forms.Button()
            Me.UscMandatoDetencion = New APPControls.Registro.Documento.uscMandatoDetencion_LM()
            Me.tbpDocumentos = New System.Windows.Forms.TabPage()
            Me.UscResolucionesMain1 = New APPControls.Registro.Resoluciones.uscResolucionesMain_LM()
            Me.tbpMovimientos = New System.Windows.Forms.TabPage()
            Me.UscMovimiento1 = New APPControls.Registro.uscMovimiento()
            Me.btnAddIngreso = New System.Windows.Forms.Button()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.cbbNroIngresos = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtEstado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtCodigo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtRegionPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ToolTipMensaje = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlRegionPenal = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.pnlAddIngreso = New System.Windows.Forms.Panel()
            Me.pnlIngresoAdd = New System.Windows.Forms.Panel()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
            Me.pnlNuevoReniec.SuspendLayout()
            Me.tbpInterno.SuspendLayout()
            Me.tcDatosInternos.SuspendLayout()
            Me.tbpDatos.SuspendLayout()
            Me.pnlDatosPer.SuspendLayout()
            Me.pnlDatosAca.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.grpVerificarReniec.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.pnlUbigeo.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.tbpDatosComplement.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.tbpNombresAsoc.SuspendLayout()
            Me.tbpFoto.SuspendLayout()
            Me.tbpReniec.SuspendLayout()
            Me.tbpAliasBandas.SuspendLayout()
            Me.tbpBandas.SuspendLayout()
            Me.tbpFamiliares.SuspendLayout()
            Me.tbpOdontograma.SuspendLayout()
            Me.tbpHuella.SuspendLayout()
            Me.pnlPiePagina.SuspendLayout()
            Me.pnlAuditoria.SuspendLayout()
            Me.pnlUpdateDocJud.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tbpMandDet.SuspendLayout()
            Me.TabControl3.SuspendLayout()
            Me.tbpListaExpedientes.SuspendLayout()
            Me.tbpDocumentos.SuspendLayout()
            Me.tbpMovimientos.SuspendLayout()
            Me.pnlRegionPenal.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pnlAddIngreso.SuspendLayout()
            Me.pnlIngresoAdd.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlNuevoReniec
            '
            Me.pnlNuevoReniec.Controls.Add(Me.btnNuevo)
            Me.pnlNuevoReniec.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlNuevoReniec.Location = New System.Drawing.Point(749, 0)
            Me.pnlNuevoReniec.Name = "pnlNuevoReniec"
            Me.pnlNuevoReniec.Size = New System.Drawing.Size(90, 45)
            Me.pnlNuevoReniec.TabIndex = 41
            '
            'btnNuevo
            '
            Me.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
            Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(1, 1)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(87, 40)
            Me.btnNuevo.TabIndex = 0
            Me.btnNuevo.Text = "&Validar"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTipMensaje.SetToolTip(Me.btnNuevo, "Click aqui para realizar una nueva validación")
            Me.btnNuevo.UseVisualStyleBackColor = False
            '
            'tbpInterno
            '
            Me.tbpInterno.Controls.Add(Me.tcDatosInternos)
            Me.tbpInterno.Location = New System.Drawing.Point(4, 22)
            Me.tbpInterno.Name = "tbpInterno"
            Me.tbpInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpInterno.Size = New System.Drawing.Size(1288, 441)
            Me.tbpInterno.TabIndex = 0
            Me.tbpInterno.Text = "Identificación de interno"
            Me.tbpInterno.UseVisualStyleBackColor = True
            '
            'tcDatosInternos
            '
            Me.tcDatosInternos.Controls.Add(Me.tbpDatos)
            Me.tcDatosInternos.Controls.Add(Me.tbpDatosComplement)
            Me.tcDatosInternos.Controls.Add(Me.tbpNombresAsoc)
            Me.tcDatosInternos.Controls.Add(Me.tbpFoto)
            Me.tcDatosInternos.Controls.Add(Me.tbpReniec)
            Me.tcDatosInternos.Controls.Add(Me.tbpAliasBandas)
            Me.tcDatosInternos.Controls.Add(Me.tbpBandas)
            Me.tcDatosInternos.Controls.Add(Me.tbpFamiliares)
            Me.tcDatosInternos.Controls.Add(Me.tbpOdontograma)
            Me.tcDatosInternos.Controls.Add(Me.tbpHuella)
            Me.tcDatosInternos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcDatosInternos.ImageList = Me.ImageList1
            Me.tcDatosInternos.Location = New System.Drawing.Point(3, 3)
            Me.tcDatosInternos.Name = "tcDatosInternos"
            Me.tcDatosInternos.SelectedIndex = 0
            Me.tcDatosInternos.Size = New System.Drawing.Size(1282, 435)
            Me.tcDatosInternos.TabIndex = 0
            '
            'tbpDatos
            '
            Me.tbpDatos.Controls.Add(Me.pnlDatosPer)
            Me.tbpDatos.ImageKey = "Personal-information-32.png"
            Me.tbpDatos.Location = New System.Drawing.Point(4, 25)
            Me.tbpDatos.Name = "tbpDatos"
            Me.tbpDatos.Size = New System.Drawing.Size(1196, 406)
            Me.tbpDatos.TabIndex = 2
            Me.tbpDatos.Text = "Dato Personal"
            Me.tbpDatos.UseVisualStyleBackColor = True
            '
            'pnlDatosPer
            '
            Me.pnlDatosPer.AutoScroll = True
            Me.pnlDatosPer.Controls.Add(Me.pnlDatosAca)
            Me.pnlDatosPer.Controls.Add(Me.pnlUbigeo)
            Me.pnlDatosPer.Controls.Add(Me.GroupBox4)
            Me.pnlDatosPer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDatosPer.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatosPer.Name = "pnlDatosPer"
            Me.pnlDatosPer.Size = New System.Drawing.Size(1196, 406)
            Me.pnlDatosPer.TabIndex = 36
            '
            'pnlDatosAca
            '
            Me.pnlDatosAca.Controls.Add(Me.Panel7)
            Me.pnlDatosAca.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDatosAca.Location = New System.Drawing.Point(553, 0)
            Me.pnlDatosAca.Name = "pnlDatosAca"
            Me.pnlDatosAca.Size = New System.Drawing.Size(643, 406)
            Me.pnlDatosAca.TabIndex = 39
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.grpVerificarReniec)
            Me.Panel7.Controls.Add(Me.GroupBox8)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel7.Location = New System.Drawing.Point(0, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(283, 406)
            Me.Panel7.TabIndex = 33
            '
            'grpVerificarReniec
            '
            Me.grpVerificarReniec.Controls.Add(Me.txtApellidosNombresreniec)
            Me.grpVerificarReniec.Controls.Add(Me.txtFechaVerRnc)
            Me.grpVerificarReniec.Controls.Add(Me.txtTipoVerRnc)
            Me.grpVerificarReniec.Controls.Add(Me.txtEstadoVerRnc)
            Me.grpVerificarReniec.Controls.Add(Me.txtObservacionRnc)
            Me.grpVerificarReniec.Controls.Add(Me.Label29)
            Me.grpVerificarReniec.Controls.Add(Me.Label40)
            Me.grpVerificarReniec.Controls.Add(Me.Label41)
            Me.grpVerificarReniec.Controls.Add(Me.Label42)
            Me.grpVerificarReniec.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpVerificarReniec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpVerificarReniec.Location = New System.Drawing.Point(0, 239)
            Me.grpVerificarReniec.Name = "grpVerificarReniec"
            Me.grpVerificarReniec.Size = New System.Drawing.Size(283, 198)
            Me.grpVerificarReniec.TabIndex = 1
            Me.grpVerificarReniec.TabStop = False
            Me.grpVerificarReniec.Text = "Identificación según RENIEC"
            '
            'txtApellidosNombresreniec
            '
            Me.txtApellidosNombresreniec._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidosNombresreniec._BloquearPaste = False
            Me.txtApellidosNombresreniec._SeleccionarTodo = False
            Me.txtApellidosNombresreniec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidosNombresreniec.Location = New System.Drawing.Point(9, 16)
            Me.txtApellidosNombresreniec.Name = "txtApellidosNombresreniec"
            Me.txtApellidosNombresreniec.ReadOnly = True
            Me.txtApellidosNombresreniec.Size = New System.Drawing.Size(268, 20)
            Me.txtApellidosNombresreniec.TabIndex = 0
            Me.txtApellidosNombresreniec.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidosNombresreniec.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtFechaVerRnc
            '
            Me.txtFechaVerRnc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaVerRnc._BloquearPaste = False
            Me.txtFechaVerRnc._SeleccionarTodo = False
            Me.txtFechaVerRnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaVerRnc.Location = New System.Drawing.Point(76, 92)
            Me.txtFechaVerRnc.Name = "txtFechaVerRnc"
            Me.txtFechaVerRnc.ReadOnly = True
            Me.txtFechaVerRnc.Size = New System.Drawing.Size(201, 20)
            Me.txtFechaVerRnc.TabIndex = 6
            Me.txtFechaVerRnc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaVerRnc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtTipoVerRnc
            '
            Me.txtTipoVerRnc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoVerRnc._BloquearPaste = False
            Me.txtTipoVerRnc._SeleccionarTodo = False
            Me.txtTipoVerRnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoVerRnc.Location = New System.Drawing.Point(76, 67)
            Me.txtTipoVerRnc.Name = "txtTipoVerRnc"
            Me.txtTipoVerRnc.ReadOnly = True
            Me.txtTipoVerRnc.Size = New System.Drawing.Size(201, 20)
            Me.txtTipoVerRnc.TabIndex = 4
            Me.txtTipoVerRnc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoVerRnc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtEstadoVerRnc
            '
            Me.txtEstadoVerRnc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstadoVerRnc._BloquearPaste = False
            Me.txtEstadoVerRnc._SeleccionarTodo = False
            Me.txtEstadoVerRnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEstadoVerRnc.Location = New System.Drawing.Point(76, 41)
            Me.txtEstadoVerRnc.Name = "txtEstadoVerRnc"
            Me.txtEstadoVerRnc.ReadOnly = True
            Me.txtEstadoVerRnc.Size = New System.Drawing.Size(201, 20)
            Me.txtEstadoVerRnc.TabIndex = 2
            Me.txtEstadoVerRnc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstadoVerRnc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtObservacionRnc
            '
            Me.txtObservacionRnc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacionRnc._BloquearPaste = False
            Me.txtObservacionRnc._SeleccionarTodo = False
            Me.txtObservacionRnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionRnc.Location = New System.Drawing.Point(76, 117)
            Me.txtObservacionRnc.Multiline = True
            Me.txtObservacionRnc.Name = "txtObservacionRnc"
            Me.txtObservacionRnc.ReadOnly = True
            Me.txtObservacionRnc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacionRnc.Size = New System.Drawing.Size(201, 45)
            Me.txtObservacionRnc.TabIndex = 8
            Me.txtObservacionRnc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacionRnc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.Location = New System.Drawing.Point(5, 120)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(73, 13)
            Me.Label29.TabIndex = 7
            Me.Label29.Text = "Observación :"
            '
            'Label40
            '
            Me.Label40.AutoSize = True
            Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label40.Location = New System.Drawing.Point(5, 98)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(43, 13)
            Me.Label40.TabIndex = 5
            Me.Label40.Text = "Fecha :"
            '
            'Label41
            '
            Me.Label41.AutoSize = True
            Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label41.Location = New System.Drawing.Point(4, 62)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(67, 26)
            Me.Label41.TabIndex = 3
            Me.Label41.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "verificación :"
            '
            'Label42
            '
            Me.Label42.AutoSize = True
            Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label42.Location = New System.Drawing.Point(2, 44)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(82, 13)
            Me.Label42.TabIndex = 1
            Me.Label42.Text = "Estado Result. :"
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.txtDecadactDer)
            Me.GroupBox8.Controls.Add(Me.txtDecadactIzq)
            Me.GroupBox8.Controls.Add(Me.Label50)
            Me.GroupBox8.Controls.Add(Me.Label43)
            Me.GroupBox8.Controls.Add(Me.Label34)
            Me.GroupBox8.Controls.Add(Me.txtObs)
            Me.GroupBox8.Controls.Add(Me.Label33)
            Me.GroupBox8.Controls.Add(Me.Label23)
            Me.GroupBox8.Controls.Add(Me.Label38)
            Me.GroupBox8.Controls.Add(Me.Label24)
            Me.GroupBox8.Controls.Add(Me.cbbAndina)
            Me.GroupBox8.Controls.Add(Me.cbbAndinaEsp)
            Me.GroupBox8.Controls.Add(Me.txtPabellon)
            Me.GroupBox8.Controls.Add(Me.cbbPabellon)
            Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(283, 239)
            Me.GroupBox8.TabIndex = 0
            Me.GroupBox8.TabStop = False
            Me.GroupBox8.Text = "Comunidad"
            '
            'txtDecadactDer
            '
            Me.txtDecadactDer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDecadactDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDecadactDer.Location = New System.Drawing.Point(101, 207)
            Me.txtDecadactDer.MaxLength = 6
            Me.txtDecadactDer.Name = "txtDecadactDer"
            Me.txtDecadactDer.Size = New System.Drawing.Size(69, 20)
            Me.txtDecadactDer.TabIndex = 10
            '
            'txtDecadactIzq
            '
            Me.txtDecadactIzq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDecadactIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDecadactIzq.Location = New System.Drawing.Point(208, 207)
            Me.txtDecadactIzq.MaxLength = 6
            Me.txtDecadactIzq.Name = "txtDecadactIzq"
            Me.txtDecadactIzq.Size = New System.Drawing.Size(69, 20)
            Me.txtDecadactIzq.TabIndex = 12
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.Location = New System.Drawing.Point(183, 210)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(24, 13)
            Me.Label50.TabIndex = 11
            Me.Label50.Text = "Izq."
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label43.Location = New System.Drawing.Point(72, 210)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(27, 13)
            Me.Label43.TabIndex = 9
            Me.Label43.Text = "Der."
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label34.Location = New System.Drawing.Point(9, 183)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(54, 13)
            Me.Label34.TabIndex = 6
            Me.Label34.Text = "Pabellón :"
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObs.Location = New System.Drawing.Point(9, 117)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(268, 56)
            Me.txtObs.TabIndex = 5
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label33.Location = New System.Drawing.Point(9, 99)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(73, 13)
            Me.Label33.TabIndex = 4
            Me.Label33.Text = "Observación :"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(6, 15)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(102, 13)
            Me.Label23.TabIndex = 0
            Me.Label23.Text = "Comunidad Andina :"
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label38.Location = New System.Drawing.Point(-1, 210)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(73, 13)
            Me.Label38.TabIndex = 8
            Me.Label38.Text = "Decadactilar :"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(6, 57)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(97, 13)
            Me.Label24.TabIndex = 2
            Me.Label24.Text = "Com. Andina Esp. :"
            '
            'cbbAndina
            '
            Me.cbbAndina._NoIndica = False
            Me.cbbAndina._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbAndina._Todos = False
            Me.cbbAndina._TodosMensaje = ""
            Me.cbbAndina._Visible_Add = False
            Me.cbbAndina._Visible_Buscar = False
            Me.cbbAndina._Visible_Eliminar = False
            Me.cbbAndina.CodigoPadre = -1
            Me.cbbAndina.ComboTipo = CType(20, Short)
            Me.cbbAndina.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbAndina.DropDownWidth = 143
            Me.cbbAndina.DropDownWidthAuto = False
            Me.cbbAndina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbAndina.ListaIdsParaExcluir = Nothing
            Me.cbbAndina.Location = New System.Drawing.Point(9, 31)
            Me.cbbAndina.ModuloTratamiento = False
            Me.cbbAndina.Name = "cbbAndina"
            Me.cbbAndina.Parametro1 = -1
            Me.cbbAndina.Parametro2 = -1
            Me.cbbAndina.SelectedIndex = -1
            Me.cbbAndina.SelectedValue = 0
            Me.cbbAndina.Size = New System.Drawing.Size(268, 22)
            Me.cbbAndina.TabIndex = 1
            '
            'cbbAndinaEsp
            '
            Me.cbbAndinaEsp._NoIndica = False
            Me.cbbAndinaEsp._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbAndinaEsp._Todos = False
            Me.cbbAndinaEsp._TodosMensaje = ""
            Me.cbbAndinaEsp._Visible_Add = False
            Me.cbbAndinaEsp._Visible_Buscar = False
            Me.cbbAndinaEsp._Visible_Eliminar = False
            Me.cbbAndinaEsp.CodigoPadre = -1
            Me.cbbAndinaEsp.ComboTipo = CType(21, Short)
            Me.cbbAndinaEsp.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbAndinaEsp.DropDownWidth = 143
            Me.cbbAndinaEsp.DropDownWidthAuto = False
            Me.cbbAndinaEsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbAndinaEsp.ListaIdsParaExcluir = Nothing
            Me.cbbAndinaEsp.Location = New System.Drawing.Point(9, 73)
            Me.cbbAndinaEsp.ModuloTratamiento = False
            Me.cbbAndinaEsp.Name = "cbbAndinaEsp"
            Me.cbbAndinaEsp.Parametro1 = -1
            Me.cbbAndinaEsp.Parametro2 = -1
            Me.cbbAndinaEsp.SelectedIndex = -1
            Me.cbbAndinaEsp.SelectedValue = 0
            Me.cbbAndinaEsp.Size = New System.Drawing.Size(268, 22)
            Me.cbbAndinaEsp.TabIndex = 3
            '
            'txtPabellon
            '
            Me.txtPabellon._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPabellon._BloquearPaste = False
            Me.txtPabellon._SeleccionarTodo = False
            Me.txtPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPabellon.Location = New System.Drawing.Point(69, 179)
            Me.txtPabellon.MaxLength = 20
            Me.txtPabellon.Name = "txtPabellon"
            Me.txtPabellon.Size = New System.Drawing.Size(208, 20)
            Me.txtPabellon.TabIndex = 7
            Me.txtPabellon.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPabellon.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbPabellon
            '
            Me.cbbPabellon._NoIndica = False
            Me.cbbPabellon._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPabellon._Todos = False
            Me.cbbPabellon._TodosMensaje = ""
            Me.cbbPabellon._Visible_Add = False
            Me.cbbPabellon._Visible_Buscar = False
            Me.cbbPabellon._Visible_Eliminar = False
            Me.cbbPabellon.CodigoPadre = -1
            Me.cbbPabellon.ComboTipo = CType(47, Short)
            Me.cbbPabellon.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPabellon.DropDownWidth = 143
            Me.cbbPabellon.DropDownWidthAuto = False
            Me.cbbPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPabellon.ListaIdsParaExcluir = Nothing
            Me.cbbPabellon.Location = New System.Drawing.Point(69, 179)
            Me.cbbPabellon.ModuloTratamiento = False
            Me.cbbPabellon.Name = "cbbPabellon"
            Me.cbbPabellon.Parametro1 = -1
            Me.cbbPabellon.Parametro2 = -1
            Me.cbbPabellon.SelectedIndex = -1
            Me.cbbPabellon.SelectedValue = 0
            Me.cbbPabellon.Size = New System.Drawing.Size(208, 22)
            Me.cbbPabellon.TabIndex = 34
            Me.cbbPabellon.Visible = False
            '
            'pnlUbigeo
            '
            Me.pnlUbigeo.Controls.Add(Me.GroupBox3)
            Me.pnlUbigeo.Controls.Add(Me.GroupBox2)
            Me.pnlUbigeo.Controls.Add(Me.GroupBox1)
            Me.pnlUbigeo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlUbigeo.Location = New System.Drawing.Point(281, 0)
            Me.pnlUbigeo.Name = "pnlUbigeo"
            Me.pnlUbigeo.Size = New System.Drawing.Size(272, 406)
            Me.pnlUbigeo.TabIndex = 37
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label20)
            Me.GroupBox3.Controls.Add(Me.Label22)
            Me.GroupBox3.Controls.Add(Me.Label25)
            Me.GroupBox3.Controls.Add(Me.cbbNivelAca)
            Me.GroupBox3.Controls.Add(Me.cbbProfesion)
            Me.GroupBox3.Controls.Add(Me.cbbOcupacion)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(0, 250)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(272, 159)
            Me.GroupBox3.TabIndex = 2
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Datos Académicos :"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(6, 20)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(93, 13)
            Me.Label20.TabIndex = 0
            Me.Label20.Text = "Nivel Académico :"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(6, 64)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(57, 13)
            Me.Label22.TabIndex = 2
            Me.Label22.Text = "Profesión :"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(6, 104)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(65, 13)
            Me.Label25.TabIndex = 4
            Me.Label25.Text = "Ocupación :"
            '
            'cbbNivelAca
            '
            Me.cbbNivelAca._NoIndica = False
            Me.cbbNivelAca._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbNivelAca._Todos = False
            Me.cbbNivelAca._TodosMensaje = ""
            Me.cbbNivelAca._Visible_Add = False
            Me.cbbNivelAca._Visible_Buscar = False
            Me.cbbNivelAca._Visible_Eliminar = False
            Me.cbbNivelAca.CodigoPadre = -1
            Me.cbbNivelAca.ComboTipo = CType(9, Short)
            Me.cbbNivelAca.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNivelAca.DropDownWidth = 143
            Me.cbbNivelAca.DropDownWidthAuto = False
            Me.cbbNivelAca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbNivelAca.ListaIdsParaExcluir = Nothing
            Me.cbbNivelAca.Location = New System.Drawing.Point(9, 36)
            Me.cbbNivelAca.ModuloTratamiento = False
            Me.cbbNivelAca.Name = "cbbNivelAca"
            Me.cbbNivelAca.Parametro1 = -1
            Me.cbbNivelAca.Parametro2 = -1
            Me.cbbNivelAca.SelectedIndex = -1
            Me.cbbNivelAca.SelectedValue = 0
            Me.cbbNivelAca.Size = New System.Drawing.Size(259, 22)
            Me.cbbNivelAca.TabIndex = 1
            '
            'cbbProfesion
            '
            Me.cbbProfesion._NoIndica = False
            Me.cbbProfesion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbProfesion._Todos = False
            Me.cbbProfesion._TodosMensaje = ""
            Me.cbbProfesion._Visible_Add = False
            Me.cbbProfesion._Visible_Buscar = False
            Me.cbbProfesion._Visible_Eliminar = False
            Me.cbbProfesion.CodigoPadre = -1
            Me.cbbProfesion.ComboTipo = CType(10, Short)
            Me.cbbProfesion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbProfesion.DropDownWidth = 143
            Me.cbbProfesion.DropDownWidthAuto = False
            Me.cbbProfesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbProfesion.ListaIdsParaExcluir = Nothing
            Me.cbbProfesion.Location = New System.Drawing.Point(9, 80)
            Me.cbbProfesion.ModuloTratamiento = False
            Me.cbbProfesion.Name = "cbbProfesion"
            Me.cbbProfesion.Parametro1 = -1
            Me.cbbProfesion.Parametro2 = -1
            Me.cbbProfesion.SelectedIndex = -1
            Me.cbbProfesion.SelectedValue = 0
            Me.cbbProfesion.Size = New System.Drawing.Size(259, 22)
            Me.cbbProfesion.TabIndex = 3
            '
            'cbbOcupacion
            '
            Me.cbbOcupacion._NoIndica = False
            Me.cbbOcupacion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbOcupacion._Todos = False
            Me.cbbOcupacion._TodosMensaje = ""
            Me.cbbOcupacion._Visible_Add = False
            Me.cbbOcupacion._Visible_Buscar = False
            Me.cbbOcupacion._Visible_Eliminar = False
            Me.cbbOcupacion.CodigoPadre = -1
            Me.cbbOcupacion.ComboTipo = CType(11, Short)
            Me.cbbOcupacion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbOcupacion.DropDownWidth = 143
            Me.cbbOcupacion.DropDownWidthAuto = False
            Me.cbbOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbOcupacion.ListaIdsParaExcluir = Nothing
            Me.cbbOcupacion.Location = New System.Drawing.Point(9, 120)
            Me.cbbOcupacion.ModuloTratamiento = False
            Me.cbbOcupacion.Name = "cbbOcupacion"
            Me.cbbOcupacion.Parametro1 = -1
            Me.cbbOcupacion.Parametro2 = -1
            Me.cbbOcupacion.SelectedIndex = -1
            Me.cbbOcupacion.SelectedValue = 0
            Me.cbbOcupacion.Size = New System.Drawing.Size(259, 22)
            Me.cbbOcupacion.TabIndex = 5
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtDomicilio)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.cbbDomicilioDist)
            Me.GroupBox2.Controls.Add(Me.Label16)
            Me.GroupBox2.Controls.Add(Me.cbbDomicilioProv)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Controls.Add(Me.cbbDomicilioDepa)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(0, 135)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(272, 115)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Domicilio "
            '
            'txtDomicilio
            '
            Me.txtDomicilio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDomicilio._BloquearPaste = False
            Me.txtDomicilio._SeleccionarTodo = False
            Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDomicilio.Location = New System.Drawing.Point(89, 90)
            Me.txtDomicilio.Name = "txtDomicilio"
            Me.txtDomicilio.Size = New System.Drawing.Size(176, 20)
            Me.txtDomicilio.TabIndex = 7
            Me.txtDomicilio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDomicilio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(6, 93)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(55, 13)
            Me.Label14.TabIndex = 6
            Me.Label14.Text = "Domicilio :"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(6, 68)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(45, 13)
            Me.Label15.TabIndex = 4
            Me.Label15.Text = "Distrito :"
            '
            'cbbDomicilioDist
            '
            Me.cbbDomicilioDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDomicilioDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbDomicilioDist.FormattingEnabled = True
            Me.cbbDomicilioDist.Location = New System.Drawing.Point(89, 65)
            Me.cbbDomicilioDist.Name = "cbbDomicilioDist"
            Me.cbbDomicilioDist.Size = New System.Drawing.Size(176, 21)
            Me.cbbDomicilioDist.TabIndex = 5
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(6, 43)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(57, 13)
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "Provincia :"
            '
            'cbbDomicilioProv
            '
            Me.cbbDomicilioProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDomicilioProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbDomicilioProv.FormattingEnabled = True
            Me.cbbDomicilioProv.Location = New System.Drawing.Point(89, 40)
            Me.cbbDomicilioProv.Name = "cbbDomicilioProv"
            Me.cbbDomicilioProv.Size = New System.Drawing.Size(176, 21)
            Me.cbbDomicilioProv.TabIndex = 3
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(6, 18)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(80, 13)
            Me.Label17.TabIndex = 0
            Me.Label17.Text = "Departamento :"
            '
            'cbbDomicilioDepa
            '
            Me.cbbDomicilioDepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDomicilioDepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbDomicilioDepa.FormattingEnabled = True
            Me.cbbDomicilioDepa.Location = New System.Drawing.Point(89, 15)
            Me.cbbDomicilioDepa.Name = "cbbDomicilioDepa"
            Me.cbbDomicilioDepa.Size = New System.Drawing.Size(176, 21)
            Me.cbbDomicilioDepa.TabIndex = 1
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtUbigeoOtro)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.cbbDistrito)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.cbbProvincia)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.CbbDepartamento)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.cbbPais)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(272, 135)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Nacimiento"
            '
            'txtUbigeoOtro
            '
            Me.txtUbigeoOtro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtUbigeoOtro._BloquearPaste = False
            Me.txtUbigeoOtro._SeleccionarTodo = False
            Me.txtUbigeoOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbigeoOtro.Location = New System.Drawing.Point(89, 110)
            Me.txtUbigeoOtro.Name = "txtUbigeoOtro"
            Me.txtUbigeoOtro.Size = New System.Drawing.Size(176, 20)
            Me.txtUbigeoOtro.TabIndex = 9
            Me.txtUbigeoOtro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeoOtro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(3, 113)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(38, 13)
            Me.Label10.TabIndex = 8
            Me.Label10.Text = "Otros :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(3, 88)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(45, 13)
            Me.Label9.TabIndex = 6
            Me.Label9.Text = "Distrito :"
            '
            'cbbDistrito
            '
            Me.cbbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbDistrito.FormattingEnabled = True
            Me.cbbDistrito.Location = New System.Drawing.Point(89, 85)
            Me.cbbDistrito.Name = "cbbDistrito"
            Me.cbbDistrito.Size = New System.Drawing.Size(176, 21)
            Me.cbbDistrito.TabIndex = 7
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(3, 64)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(57, 13)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Provincia :"
            '
            'cbbProvincia
            '
            Me.cbbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbProvincia.FormattingEnabled = True
            Me.cbbProvincia.Location = New System.Drawing.Point(89, 61)
            Me.cbbProvincia.Name = "cbbProvincia"
            Me.cbbProvincia.Size = New System.Drawing.Size(176, 21)
            Me.cbbProvincia.TabIndex = 5
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(3, 40)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(80, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Departamento :"
            '
            'CbbDepartamento
            '
            Me.CbbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CbbDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CbbDepartamento.FormattingEnabled = True
            Me.CbbDepartamento.Location = New System.Drawing.Point(89, 37)
            Me.CbbDepartamento.Name = "CbbDepartamento"
            Me.CbbDepartamento.Size = New System.Drawing.Size(176, 21)
            Me.CbbDepartamento.TabIndex = 3
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 17)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(33, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Pais :"
            '
            'cbbPais
            '
            Me.cbbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPais.FormattingEnabled = True
            Me.cbbPais.Location = New System.Drawing.Point(89, 13)
            Me.cbbPais.Name = "cbbPais"
            Me.cbbPais.Size = New System.Drawing.Size(176, 21)
            Me.cbbPais.TabIndex = 1
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtApePat)
            Me.GroupBox4.Controls.Add(Me.txtNumDoc)
            Me.GroupBox4.Controls.Add(Me.chk_Homonimia)
            Me.GroupBox4.Controls.Add(Me.dtpFechaNac)
            Me.GroupBox4.Controls.Add(Me.Label39)
            Me.GroupBox4.Controls.Add(Me.txtObs_dni)
            Me.GroupBox4.Controls.Add(Me.chk_Obs_DNI)
            Me.GroupBox4.Controls.Add(Me.chkNoindica)
            Me.GroupBox4.Controls.Add(Me.GroupBox6)
            Me.GroupBox4.Controls.Add(Me.Label11)
            Me.GroupBox4.Controls.Add(Me.Label18)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.txtNom)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.txtApeMat)
            Me.GroupBox4.Controls.Add(Me.Label12)
            Me.GroupBox4.Controls.Add(Me.Label13)
            Me.GroupBox4.Controls.Add(Me.Label19)
            Me.GroupBox4.Controls.Add(Me.cbbSexo)
            Me.GroupBox4.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox4.Controls.Add(Me.cbbEstadoCivil)
            Me.GroupBox4.Controls.Add(Me.cbbDiscapacitado)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(281, 406)
            Me.GroupBox4.TabIndex = 35
            Me.GroupBox4.TabStop = False
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.Location = New System.Drawing.Point(104, 93)
            Me.txtApePat.MaxLength = 100
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(168, 20)
            Me.txtApePat.TabIndex = 2
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = True
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(104, 308)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(168, 20)
            Me.txtNumDoc.TabIndex = 19
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'chk_Homonimia
            '
            Me.chk_Homonimia.AutoSize = True
            Me.chk_Homonimia.Location = New System.Drawing.Point(104, 166)
            Me.chk_Homonimia.Name = "chk_Homonimia"
            Me.chk_Homonimia.Size = New System.Drawing.Size(78, 17)
            Me.chk_Homonimia.TabIndex = 7
            Me.chk_Homonimia.Text = "Homonimia"
            Me.chk_Homonimia.UseVisualStyleBackColor = True
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(104, 212)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 11
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'Label39
            '
            Me.Label39.AutoSize = True
            Me.Label39.Location = New System.Drawing.Point(7, 244)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(84, 26)
            Me.Label39.TabIndex = 13
            Me.Label39.Text = "Justific. Registro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Menor Edad"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtObs_dni
            '
            Me.txtObs_dni._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs_dni._BloquearPaste = False
            Me.txtObs_dni._SeleccionarTodo = False
            Me.txtObs_dni.Enabled = False
            Me.txtObs_dni.Location = New System.Drawing.Point(104, 237)
            Me.txtObs_dni.MaxLength = 500
            Me.txtObs_dni.Multiline = True
            Me.txtObs_dni.Name = "txtObs_dni"
            Me.txtObs_dni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs_dni.Size = New System.Drawing.Size(169, 39)
            Me.txtObs_dni.TabIndex = 14
            Me.txtObs_dni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs_dni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'chk_Obs_DNI
            '
            Me.chk_Obs_DNI.AutoSize = True
            Me.chk_Obs_DNI.Location = New System.Drawing.Point(199, 213)
            Me.chk_Obs_DNI.Name = "chk_Obs_DNI"
            Me.chk_Obs_DNI.Size = New System.Drawing.Size(71, 17)
            Me.chk_Obs_DNI.TabIndex = 12
            Me.chk_Obs_DNI.Text = "<18 Años"
            Me.chk_Obs_DNI.UseVisualStyleBackColor = True
            '
            'chkNoindica
            '
            Me.chkNoindica.AutoSize = True
            Me.chkNoindica.Location = New System.Drawing.Point(198, 285)
            Me.chkNoindica.Name = "chkNoindica"
            Me.chkNoindica.Size = New System.Drawing.Size(72, 17)
            Me.chkNoindica.TabIndex = 17
            Me.chkNoindica.Text = "No Indica"
            Me.chkNoindica.UseVisualStyleBackColor = True
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.txtLibro)
            Me.GroupBox6.Controls.Add(Me.Label31)
            Me.GroupBox6.Controls.Add(Me.txtFolio)
            Me.GroupBox6.Controls.Add(Me.Label26)
            Me.GroupBox6.Controls.Add(Me.Label32)
            Me.GroupBox6.Controls.Add(Me.txtCodInterno)
            Me.GroupBox6.Location = New System.Drawing.Point(6, 5)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(268, 84)
            Me.GroupBox6.TabIndex = 0
            Me.GroupBox6.TabStop = False
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Location = New System.Drawing.Point(95, 58)
            Me.txtLibro.MaxLength = 15
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(51, 20)
            Me.txtLibro.TabIndex = 4
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(1, 61)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(51, 13)
            Me.Label31.TabIndex = 3
            Me.Label31.Text = "N° Libro :"
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Location = New System.Drawing.Point(208, 58)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(51, 20)
            Me.txtFolio.TabIndex = 5
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(1, 37)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 0
            Me.Label26.Text = "Código Interno :"
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Location = New System.Drawing.Point(154, 62)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(50, 13)
            Me.Label32.TabIndex = 19
            Me.Label32.Text = "N° Folio :"
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = False
            Me.txtCodInterno.Location = New System.Drawing.Point(95, 34)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.ReadOnly = True
            Me.txtCodInterno.Size = New System.Drawing.Size(109, 20)
            Me.txtCodInterno.TabIndex = 1
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(7, 389)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(75, 13)
            Me.Label11.TabIndex = 24
            Me.Label11.Text = "Nacionalidad :"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(7, 363)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(78, 13)
            Me.Label18.TabIndex = 22
            Me.Label18.Text = "Discapacidad :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(5, 96)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Primer Apellido :"
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
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(104, 384)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(169, 22)
            Me.cbbNacionalidad.TabIndex = 25
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(7, 144)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Nombres :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 189)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Sexo :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = True
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(104, 141)
            Me.txtNom.MaxLength = 100
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(168, 20)
            Me.txtNom.TabIndex = 6
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(7, 218)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(69, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "Fecha Nac. :"
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = True
            Me.txtApeMat._SeleccionarTodo = False
            Me.txtApeMat.Location = New System.Drawing.Point(104, 117)
            Me.txtApeMat.MaxLength = 100
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(168, 20)
            Me.txtApeMat.TabIndex = 4
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(7, 286)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(60, 13)
            Me.Label12.TabIndex = 15
            Me.Label12.Text = "Tipo Doc. :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(7, 312)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(76, 13)
            Me.Label13.TabIndex = 18
            Me.Label13.Text = "Número Doc. :"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(7, 335)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(67, 13)
            Me.Label19.TabIndex = 20
            Me.Label19.Text = "Estado civil :"
            '
            'cbbSexo
            '
            Me.cbbSexo._NoIndica = False
            Me.cbbSexo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbSexo._Todos = False
            Me.cbbSexo._TodosMensaje = ""
            Me.cbbSexo._Visible_Add = False
            Me.cbbSexo._Visible_Buscar = False
            Me.cbbSexo._Visible_Eliminar = False
            Me.cbbSexo.CodigoPadre = -1
            Me.cbbSexo.ComboTipo = CType(1, Short)
            Me.cbbSexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSexo.DropDownWidth = 143
            Me.cbbSexo.DropDownWidthAuto = False
            Me.cbbSexo.ListaIdsParaExcluir = Nothing
            Me.cbbSexo.Location = New System.Drawing.Point(104, 186)
            Me.cbbSexo.ModuloTratamiento = False
            Me.cbbSexo.Name = "cbbSexo"
            Me.cbbSexo.Parametro1 = -1
            Me.cbbSexo.Parametro2 = -1
            Me.cbbSexo.SelectedIndex = -1
            Me.cbbSexo.SelectedValue = 0
            Me.cbbSexo.Size = New System.Drawing.Size(168, 22)
            Me.cbbSexo.TabIndex = 9
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
            Me.cbbTipoDoc.Location = New System.Drawing.Point(104, 283)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(65, 22)
            Me.cbbTipoDoc.TabIndex = 16
            '
            'cbbEstadoCivil
            '
            Me.cbbEstadoCivil._NoIndica = False
            Me.cbbEstadoCivil._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbEstadoCivil._Todos = False
            Me.cbbEstadoCivil._TodosMensaje = ""
            Me.cbbEstadoCivil._Visible_Add = False
            Me.cbbEstadoCivil._Visible_Buscar = False
            Me.cbbEstadoCivil._Visible_Eliminar = False
            Me.cbbEstadoCivil.CodigoPadre = -1
            Me.cbbEstadoCivil.ComboTipo = CType(3, Short)
            Me.cbbEstadoCivil.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbEstadoCivil.DropDownWidth = 143
            Me.cbbEstadoCivil.DropDownWidthAuto = False
            Me.cbbEstadoCivil.ListaIdsParaExcluir = Nothing
            Me.cbbEstadoCivil.Location = New System.Drawing.Point(104, 332)
            Me.cbbEstadoCivil.ModuloTratamiento = False
            Me.cbbEstadoCivil.Name = "cbbEstadoCivil"
            Me.cbbEstadoCivil.Parametro1 = -1
            Me.cbbEstadoCivil.Parametro2 = -1
            Me.cbbEstadoCivil.SelectedIndex = -1
            Me.cbbEstadoCivil.SelectedValue = 0
            Me.cbbEstadoCivil.Size = New System.Drawing.Size(169, 22)
            Me.cbbEstadoCivil.TabIndex = 21
            '
            'cbbDiscapacitado
            '
            Me.cbbDiscapacitado._NoIndica = False
            Me.cbbDiscapacitado._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbDiscapacitado._Todos = False
            Me.cbbDiscapacitado._TodosMensaje = ""
            Me.cbbDiscapacitado._Visible_Add = False
            Me.cbbDiscapacitado._Visible_Buscar = False
            Me.cbbDiscapacitado._Visible_Eliminar = False
            Me.cbbDiscapacitado.CodigoPadre = -1
            Me.cbbDiscapacitado.ComboTipo = CType(19, Short)
            Me.cbbDiscapacitado.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDiscapacitado.DropDownWidth = 143
            Me.cbbDiscapacitado.DropDownWidthAuto = False
            Me.cbbDiscapacitado.ListaIdsParaExcluir = Nothing
            Me.cbbDiscapacitado.Location = New System.Drawing.Point(104, 358)
            Me.cbbDiscapacitado.ModuloTratamiento = False
            Me.cbbDiscapacitado.Name = "cbbDiscapacitado"
            Me.cbbDiscapacitado.Parametro1 = -1
            Me.cbbDiscapacitado.Parametro2 = -1
            Me.cbbDiscapacitado.SelectedIndex = -1
            Me.cbbDiscapacitado.SelectedValue = 0
            Me.cbbDiscapacitado.Size = New System.Drawing.Size(169, 22)
            Me.cbbDiscapacitado.TabIndex = 23
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(5, 120)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(96, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Segundo Apellido :"
            '
            'tbpDatosComplement
            '
            Me.tbpDatosComplement.Controls.Add(Me.Panel2)
            Me.tbpDatosComplement.Controls.Add(Me.Panel6)
            Me.tbpDatosComplement.Controls.Add(Me.Panel4)
            Me.tbpDatosComplement.ImageKey = "Personal-information-32.png"
            Me.tbpDatosComplement.Location = New System.Drawing.Point(4, 25)
            Me.tbpDatosComplement.Name = "tbpDatosComplement"
            Me.tbpDatosComplement.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpDatosComplement.Size = New System.Drawing.Size(1274, 406)
            Me.tbpDatosComplement.TabIndex = 7
            Me.tbpDatosComplement.Text = "Datos Complementarios"
            Me.tbpDatosComplement.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscEtniaLenguaMaterna_v21)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(787, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(392, 400)
            Me.Panel2.TabIndex = 8
            '
            'UscEtniaLenguaMaterna_v21
            '
            Me.UscEtniaLenguaMaterna_v21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscEtniaLenguaMaterna_v21.Location = New System.Drawing.Point(0, 0)
            Me.UscEtniaLenguaMaterna_v21.Name = "UscEtniaLenguaMaterna_v21"
            Me.UscEtniaLenguaMaterna_v21.Size = New System.Drawing.Size(392, 400)
            Me.UscEtniaLenguaMaterna_v21.TabIndex = 7
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.GroupBox9)
            Me.Panel6.Controls.Add(Me.GroupBox7)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel6.Location = New System.Drawing.Point(395, 3)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(392, 400)
            Me.Panel6.TabIndex = 2
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.UscDomicilio1)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox9.Location = New System.Drawing.Point(0, 211)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(392, 211)
            Me.GroupBox9.TabIndex = 0
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "Domicilios registrados"
            '
            'UscDomicilio1
            '
            Me.UscDomicilio1._IngresoId = -1
            Me.UscDomicilio1._IngresoInpeID = -1
            Me.UscDomicilio1._IngresoNroLetra = ""
            Me.UscDomicilio1._InternoId = -1
            Me.UscDomicilio1._PenalId = -1
            Me.UscDomicilio1._RegionId = -1
            Me.UscDomicilio1._VisibleEliminar = False
            Me.UscDomicilio1._VisibleGrabar = False
            Me.UscDomicilio1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscDomicilio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscDomicilio1.Location = New System.Drawing.Point(3, 16)
            Me.UscDomicilio1.Name = "UscDomicilio1"
            Me.UscDomicilio1.Size = New System.Drawing.Size(386, 169)
            Me.UscDomicilio1.TabIndex = 0
            Me.UscDomicilio1.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.UscGradosAcademicos1)
            Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(392, 211)
            Me.GroupBox7.TabIndex = 6
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Grados academicos"
            '
            'UscGradosAcademicos1
            '
            Me.UscGradosAcademicos1._IngresoId = 0
            Me.UscGradosAcademicos1._IngresoInpeID = -1
            Me.UscGradosAcademicos1._IngresoNroLetra = ""
            Me.UscGradosAcademicos1._InternoId = -1
            Me.UscGradosAcademicos1._PenalId = -1
            Me.UscGradosAcademicos1._RegionId = -1
            Me.UscGradosAcademicos1._VisibleEliminar = False
            Me.UscGradosAcademicos1._VisibleGrabar = False
            Me.UscGradosAcademicos1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscGradosAcademicos1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscGradosAcademicos1.Location = New System.Drawing.Point(3, 16)
            Me.UscGradosAcademicos1.Name = "UscGradosAcademicos1"
            Me.UscGradosAcademicos1.Size = New System.Drawing.Size(386, 192)
            Me.UscGradosAcademicos1.TabIndex = 0
            Me.UscGradosAcademicos1.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.cbbCentroReclu)
            Me.Panel4.Controls.Add(Me.Label27)
            Me.Panel4.Controls.Add(Me.cbbCodFuerArmada)
            Me.Panel4.Controls.Add(Me.cbbCodigoRango)
            Me.Panel4.Controls.Add(Me.Label21)
            Me.Panel4.Controls.Add(Me.txtNomClaveInt)
            Me.Panel4.Controls.Add(Me.Label49)
            Me.Panel4.Controls.Add(Me.GroupBox5)
            Me.Panel4.Controls.Add(Me.Label45)
            Me.Panel4.Controls.Add(Me.Label48)
            Me.Panel4.Controls.Add(Me.cbbIdiomaPrincipal)
            Me.Panel4.Controls.Add(Me.Label47)
            Me.Panel4.Controls.Add(Me.Label44)
            Me.Panel4.Controls.Add(Me.Label46)
            Me.Panel4.Controls.Add(Me.cbbGenero)
            Me.Panel4.Controls.Add(Me.txtCentroTrabajo)
            Me.Panel4.Controls.Add(Me.cbbReligion)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel4.Location = New System.Drawing.Point(3, 3)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(392, 400)
            Me.Panel4.TabIndex = 1
            '
            'cbbCentroReclu
            '
            Me.cbbCentroReclu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbCentroReclu.FormattingEnabled = True
            Me.cbbCentroReclu.Items.AddRange(New Object() {"", "Ninguno", "Maranga", "Juan Pablo Segundo", "Hermelinda Carrera"})
            Me.cbbCentroReclu.Location = New System.Drawing.Point(127, 186)
            Me.cbbCentroReclu.Name = "cbbCentroReclu"
            Me.cbbCentroReclu.Size = New System.Drawing.Size(259, 21)
            Me.cbbCentroReclu.TabIndex = 45
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(35, 189)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(86, 13)
            Me.Label27.TabIndex = 46
            Me.Label27.Text = "Centro reclusión:"
            '
            'cbbCodFuerArmada
            '
            Me.cbbCodFuerArmada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbCodFuerArmada.FormattingEnabled = True
            Me.cbbCodFuerArmada.Location = New System.Drawing.Point(127, 107)
            Me.cbbCodFuerArmada.Name = "cbbCodFuerArmada"
            Me.cbbCodFuerArmada.Size = New System.Drawing.Size(259, 21)
            Me.cbbCodFuerArmada.TabIndex = 44
            '
            'cbbCodigoRango
            '
            Me.cbbCodigoRango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbCodigoRango.FormattingEnabled = True
            Me.cbbCodigoRango.Location = New System.Drawing.Point(127, 134)
            Me.cbbCodigoRango.Name = "cbbCodigoRango"
            Me.cbbCodigoRango.Size = New System.Drawing.Size(259, 21)
            Me.cbbCodigoRango.TabIndex = 43
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(46, 8)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(77, 13)
            Me.Label21.TabIndex = 42
            Me.Label21.Text = "Nombre Clave:"
            Me.ToolTipMensaje.SetToolTip(Me.Label21, "Nombre clave del interno")
            '
            'txtNomClaveInt
            '
            Me.txtNomClaveInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNomClaveInt.Location = New System.Drawing.Point(127, 5)
            Me.txtNomClaveInt.MaxLength = 20
            Me.txtNomClaveInt.Name = "txtNomClaveInt"
            Me.txtNomClaveInt.Size = New System.Drawing.Size(125, 20)
            Me.txtNomClaveInt.TabIndex = 41
            Me.ToolTipMensaje.SetToolTip(Me.txtNomClaveInt, "Nombre clave del interno")
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Location = New System.Drawing.Point(36, 138)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(88, 13)
            Me.Label49.TabIndex = 4
            Me.Label49.Text = "Código de rango:"
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.UscIdiomaInterno1)
            Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox5.Location = New System.Drawing.Point(3, 211)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(386, 185)
            Me.GroupBox5.TabIndex = 5
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Otros idiomas"
            '
            'UscIdiomaInterno1
            '
            Me.UscIdiomaInterno1._IngresoId = -1
            Me.UscIdiomaInterno1._IngresoInpeID = -1
            Me.UscIdiomaInterno1._IngresoNroLetra = ""
            Me.UscIdiomaInterno1._InternoId = -1
            Me.UscIdiomaInterno1._PenalId = -1
            Me.UscIdiomaInterno1._RegionId = -1
            Me.UscIdiomaInterno1._VisibleEliminar = False
            Me.UscIdiomaInterno1._VisibleGrabar = False
            Me.UscIdiomaInterno1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscIdiomaInterno1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscIdiomaInterno1.Location = New System.Drawing.Point(3, 16)
            Me.UscIdiomaInterno1.Name = "UscIdiomaInterno1"
            Me.UscIdiomaInterno1.Size = New System.Drawing.Size(380, 166)
            Me.UscIdiomaInterno1.TabIndex = 2
            Me.UscIdiomaInterno1.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'Label45
            '
            Me.Label45.AutoSize = True
            Me.Label45.Location = New System.Drawing.Point(44, 164)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(75, 13)
            Me.Label45.TabIndex = 3
            Me.Label45.Text = "Idioma Nativo:"
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Location = New System.Drawing.Point(6, 112)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(113, 13)
            Me.Label48.TabIndex = 4
            Me.Label48.Text = "Código fuerza armada:"
            '
            'cbbIdiomaPrincipal
            '
            Me.cbbIdiomaPrincipal._NoIndica = False
            Me.cbbIdiomaPrincipal._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbIdiomaPrincipal._Todos = False
            Me.cbbIdiomaPrincipal._TodosMensaje = ""
            Me.cbbIdiomaPrincipal._Visible_Add = False
            Me.cbbIdiomaPrincipal._Visible_Buscar = False
            Me.cbbIdiomaPrincipal._Visible_Eliminar = False
            Me.cbbIdiomaPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbIdiomaPrincipal.CodigoPadre = -1
            Me.cbbIdiomaPrincipal.ComboTipo = CType(77, Short)
            Me.cbbIdiomaPrincipal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbIdiomaPrincipal.DropDownWidth = 281
            Me.cbbIdiomaPrincipal.DropDownWidthAuto = False
            Me.cbbIdiomaPrincipal.ListaIdsParaExcluir = Nothing
            Me.cbbIdiomaPrincipal.Location = New System.Drawing.Point(127, 160)
            Me.cbbIdiomaPrincipal.ModuloTratamiento = False
            Me.cbbIdiomaPrincipal.Name = "cbbIdiomaPrincipal"
            Me.cbbIdiomaPrincipal.Parametro1 = -1
            Me.cbbIdiomaPrincipal.Parametro2 = -1
            Me.cbbIdiomaPrincipal.SelectedIndex = -1
            Me.cbbIdiomaPrincipal.SelectedValue = 0
            Me.cbbIdiomaPrincipal.Size = New System.Drawing.Size(259, 22)
            Me.cbbIdiomaPrincipal.TabIndex = 4
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Location = New System.Drawing.Point(28, 33)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(91, 13)
            Me.Label47.TabIndex = 4
            Me.Label47.Text = "Centro de trabajo:"
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(74, 59)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(45, 13)
            Me.Label44.TabIndex = 1
            Me.Label44.Text = "Género:"
            '
            'Label46
            '
            Me.Label46.AutoSize = True
            Me.Label46.Location = New System.Drawing.Point(71, 84)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(48, 13)
            Me.Label46.TabIndex = 4
            Me.Label46.Text = "Religión:"
            '
            'cbbGenero
            '
            Me.cbbGenero._NoIndica = False
            Me.cbbGenero._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbGenero._Todos = False
            Me.cbbGenero._TodosMensaje = ""
            Me.cbbGenero._Visible_Add = False
            Me.cbbGenero._Visible_Buscar = False
            Me.cbbGenero._Visible_Eliminar = False
            Me.cbbGenero.CodigoPadre = -1
            Me.cbbGenero.ComboTipo = CType(78, Short)
            Me.cbbGenero.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbGenero.DropDownWidth = 277
            Me.cbbGenero.DropDownWidthAuto = False
            Me.cbbGenero.ListaIdsParaExcluir = Nothing
            Me.cbbGenero.Location = New System.Drawing.Point(127, 54)
            Me.cbbGenero.ModuloTratamiento = False
            Me.cbbGenero.Name = "cbbGenero"
            Me.cbbGenero.Parametro1 = -1
            Me.cbbGenero.Parametro2 = -1
            Me.cbbGenero.SelectedIndex = -1
            Me.cbbGenero.SelectedValue = 0
            Me.cbbGenero.Size = New System.Drawing.Size(259, 22)
            Me.cbbGenero.TabIndex = 0
            '
            'txtCentroTrabajo
            '
            Me.txtCentroTrabajo.Location = New System.Drawing.Point(127, 29)
            Me.txtCentroTrabajo.MaxLength = 150
            Me.txtCentroTrabajo.Name = "txtCentroTrabajo"
            Me.txtCentroTrabajo.Size = New System.Drawing.Size(259, 20)
            Me.txtCentroTrabajo.TabIndex = 2
            '
            'cbbReligion
            '
            Me.cbbReligion._NoIndica = False
            Me.cbbReligion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbReligion._Todos = False
            Me.cbbReligion._TodosMensaje = ""
            Me.cbbReligion._Visible_Add = False
            Me.cbbReligion._Visible_Buscar = False
            Me.cbbReligion._Visible_Eliminar = False
            Me.cbbReligion.CodigoPadre = -1
            Me.cbbReligion.ComboTipo = CType(79, Short)
            Me.cbbReligion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbReligion.DropDownWidth = 259
            Me.cbbReligion.DropDownWidthAuto = False
            Me.cbbReligion.ListaIdsParaExcluir = Nothing
            Me.cbbReligion.Location = New System.Drawing.Point(127, 80)
            Me.cbbReligion.ModuloTratamiento = False
            Me.cbbReligion.Name = "cbbReligion"
            Me.cbbReligion.Parametro1 = -1
            Me.cbbReligion.Parametro2 = -1
            Me.cbbReligion.SelectedIndex = -1
            Me.cbbReligion.SelectedValue = 0
            Me.cbbReligion.Size = New System.Drawing.Size(259, 22)
            Me.cbbReligion.TabIndex = 1
            '
            'tbpNombresAsoc
            '
            Me.tbpNombresAsoc.Controls.Add(Me.UscGrillaNombresAsociadosV21)
            Me.tbpNombresAsoc.Location = New System.Drawing.Point(4, 25)
            Me.tbpNombresAsoc.Name = "tbpNombresAsoc"
            Me.tbpNombresAsoc.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpNombresAsoc.Size = New System.Drawing.Size(1196, 406)
            Me.tbpNombresAsoc.TabIndex = 0
            Me.tbpNombresAsoc.Text = "Nombres Asociados"
            Me.tbpNombresAsoc.UseVisualStyleBackColor = True
            '
            'UscGrillaNombresAsociadosV21
            '
            Me.UscGrillaNombresAsociadosV21._Documentos_sin_mov = True
            Me.UscGrillaNombresAsociadosV21._IngresoID = -1
            Me.UscGrillaNombresAsociadosV21._IngresoInpeID = -1
            Me.UscGrillaNombresAsociadosV21._InternoID = -1
            Me.UscGrillaNombresAsociadosV21._PenalID = -1
            Me.UscGrillaNombresAsociadosV21._RegionID = -1
            Me.UscGrillaNombresAsociadosV21._VisibleEliminar = False
            Me.UscGrillaNombresAsociadosV21._VisibleGrabar = False
            Me.UscGrillaNombresAsociadosV21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscGrillaNombresAsociadosV21.Location = New System.Drawing.Point(3, 3)
            Me.UscGrillaNombresAsociadosV21.Name = "UscGrillaNombresAsociadosV21"
            Me.UscGrillaNombresAsociadosV21.Size = New System.Drawing.Size(1190, 400)
            Me.UscGrillaNombresAsociadosV21.TabIndex = 1
            Me.UscGrillaNombresAsociadosV21.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpFoto
            '
            Me.tbpFoto.Controls.Add(Me.uscFotoPerfiles)
            Me.tbpFoto.Location = New System.Drawing.Point(4, 25)
            Me.tbpFoto.Name = "tbpFoto"
            Me.tbpFoto.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpFoto.Size = New System.Drawing.Size(1196, 406)
            Me.tbpFoto.TabIndex = 4
            Me.tbpFoto.Text = "Foto"
            Me.tbpFoto.UseVisualStyleBackColor = True
            '
            'uscFotoPerfiles
            '
            Me.uscFotoPerfiles._IngresoInpeID = -1
            Me.uscFotoPerfiles._InternoCodigoRP = ""
            Me.uscFotoPerfiles._InternoID = -1
            Me.uscFotoPerfiles._VisibleEliminar = False
            Me.uscFotoPerfiles._VisibleGrabar = False
            Me.uscFotoPerfiles.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscFotoPerfiles.InternoFotoID = -1
            Me.uscFotoPerfiles.InternoIngresoNro = -1
            Me.uscFotoPerfiles.InternoRasgoID = -1
            Me.uscFotoPerfiles.Location = New System.Drawing.Point(3, 3)
            Me.uscFotoPerfiles.Name = "uscFotoPerfiles"
            Me.uscFotoPerfiles.PenalID = -1
            Me.uscFotoPerfiles.RegionID = -1
            Me.uscFotoPerfiles.Size = New System.Drawing.Size(1190, 400)
            Me.uscFotoPerfiles.TabIndex = 0
            Me.uscFotoPerfiles.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpReniec
            '
            Me.tbpReniec.AutoScroll = True
            Me.tbpReniec.Controls.Add(Me.UscValidacionReniecV21)
            Me.tbpReniec.Location = New System.Drawing.Point(4, 25)
            Me.tbpReniec.Name = "tbpReniec"
            Me.tbpReniec.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpReniec.Size = New System.Drawing.Size(1196, 406)
            Me.tbpReniec.TabIndex = 6
            Me.tbpReniec.Text = "RENIEC"
            Me.tbpReniec.UseVisualStyleBackColor = True
            '
            'UscValidacionReniecV21
            '
            Me.UscValidacionReniecV21._CondicionBusqueda = -1
            Me.UscValidacionReniecV21._Contador = -1
            Me.UscValidacionReniecV21._InternoID = -1
            Me.UscValidacionReniecV21._ListaCabeceraInterno = ""
            Me.UscValidacionReniecV21._ListaDataInterno = ""
            Me.UscValidacionReniecV21._NombreImagen = ""
            Me.UscValidacionReniecV21._NombresAsociados = ""
            Me.UscValidacionReniecV21._NombresAsociadosData = ""
            Me.UscValidacionReniecV21._NombresAsociadosID = ""
            Me.UscValidacionReniecV21._NumeroImagen = -1
            Me.UscValidacionReniecV21._TipoLicencia = -1
            Me.UscValidacionReniecV21._VarHistorico = -1
            Me.UscValidacionReniecV21.AutoScroll = True
            Me.UscValidacionReniecV21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscValidacionReniecV21.ListaRnc = ""
            Me.UscValidacionReniecV21.ListaRncMatriz = Nothing
            Me.UscValidacionReniecV21.Location = New System.Drawing.Point(3, 3)
            Me.UscValidacionReniecV21.Name = "UscValidacionReniecV21"
            Me.UscValidacionReniecV21.Size = New System.Drawing.Size(1190, 400)
            Me.UscValidacionReniecV21.TabIndex = 0
            Me.UscValidacionReniecV21.TipoValidacion = -1
            '
            'tbpAliasBandas
            '
            Me.tbpAliasBandas.Controls.Add(Me.UscBandas21)
            Me.tbpAliasBandas.Controls.Add(Me.UscAlias21)
            Me.tbpAliasBandas.Location = New System.Drawing.Point(4, 25)
            Me.tbpAliasBandas.Name = "tbpAliasBandas"
            Me.tbpAliasBandas.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpAliasBandas.Size = New System.Drawing.Size(1196, 406)
            Me.tbpAliasBandas.TabIndex = 1
            Me.tbpAliasBandas.Text = "Alias y Banda"
            Me.tbpAliasBandas.UseVisualStyleBackColor = True
            '
            'UscBandas21
            '
            Me.UscBandas21._VisibleEliminar = False
            Me.UscBandas21._VisibleGrabar = False
            Me.UscBandas21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscBandas21.IngresoId = -1
            Me.UscBandas21.IngresoInpeID = -1
            Me.UscBandas21.InternoID = -1
            Me.UscBandas21.Location = New System.Drawing.Point(496, 3)
            Me.UscBandas21.Name = "UscBandas21"
            Me.UscBandas21.PenalID = -1
            Me.UscBandas21.RegionID = -1
            Me.UscBandas21.Size = New System.Drawing.Size(697, 400)
            Me.UscBandas21.TabIndex = 1
            Me.UscBandas21.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'UscAlias21
            '
            Me.UscAlias21._VisibleEliminar = False
            Me.UscAlias21._VisibleGrabar = False
            Me.UscAlias21.Dock = System.Windows.Forms.DockStyle.Left
            Me.UscAlias21.IngresoID = -1
            Me.UscAlias21.IngresoInpeID = -1
            Me.UscAlias21.InternoID = -1
            Me.UscAlias21.Location = New System.Drawing.Point(3, 3)
            Me.UscAlias21.Name = "UscAlias21"
            Me.UscAlias21.PenalID = -1
            Me.UscAlias21.RegionID = -1
            Me.UscAlias21.Size = New System.Drawing.Size(493, 400)
            Me.UscAlias21.TabIndex = 0
            Me.UscAlias21.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpBandas
            '
            Me.tbpBandas.Controls.Add(Me.UscOrganizacionCriminal)
            Me.tbpBandas.Location = New System.Drawing.Point(4, 25)
            Me.tbpBandas.Name = "tbpBandas"
            Me.tbpBandas.Size = New System.Drawing.Size(1196, 406)
            Me.tbpBandas.TabIndex = 5
            Me.tbpBandas.Text = "Organización criminal"
            Me.tbpBandas.UseVisualStyleBackColor = True
            '
            'UscOrganizacionCriminal
            '
            Me.UscOrganizacionCriminal._Codigo = -1
            Me.UscOrganizacionCriminal._IngresoInpeID = -1
            Me.UscOrganizacionCriminal._InternoID = -1
            Me.UscOrganizacionCriminal._InternoIngresoID = -1
            Me.UscOrganizacionCriminal._PenalID = -1
            Me.UscOrganizacionCriminal._RegionID = -1
            Me.UscOrganizacionCriminal._VisibleEliminar = False
            Me.UscOrganizacionCriminal._VisibleGrabar = False
            Me.UscOrganizacionCriminal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscOrganizacionCriminal.Location = New System.Drawing.Point(0, 0)
            Me.UscOrganizacionCriminal.Name = "UscOrganizacionCriminal"
            Me.UscOrganizacionCriminal.Size = New System.Drawing.Size(1196, 406)
            Me.UscOrganizacionCriminal.TabIndex = 1
            Me.UscOrganizacionCriminal.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpFamiliares
            '
            Me.tbpFamiliares.Controls.Add(Me.UscFamilias1)
            Me.tbpFamiliares.Location = New System.Drawing.Point(4, 25)
            Me.tbpFamiliares.Name = "tbpFamiliares"
            Me.tbpFamiliares.Size = New System.Drawing.Size(1196, 406)
            Me.tbpFamiliares.TabIndex = 3
            Me.tbpFamiliares.Text = "Familiares"
            Me.tbpFamiliares.UseVisualStyleBackColor = True
            '
            'UscFamilias1
            '
            Me.UscFamilias1._IDIngreso = -1
            Me.UscFamilias1._IDInterno = -1
            Me.UscFamilias1._IngresoInpeID = -1
            Me.UscFamilias1._PenalID = -1
            Me.UscFamilias1._RegionID = -1
            Me.UscFamilias1._VisibleEliminar = False
            Me.UscFamilias1._VisibleGrabar = False
            Me.UscFamilias1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFamilias1.Location = New System.Drawing.Point(0, 0)
            Me.UscFamilias1.Name = "UscFamilias1"
            Me.UscFamilias1.Size = New System.Drawing.Size(1196, 406)
            Me.UscFamilias1.TabIndex = 1
            Me.UscFamilias1.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpOdontograma
            '
            Me.tbpOdontograma.Controls.Add(Me.UscOdont)
            Me.tbpOdontograma.Location = New System.Drawing.Point(4, 25)
            Me.tbpOdontograma.Name = "tbpOdontograma"
            Me.tbpOdontograma.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpOdontograma.Size = New System.Drawing.Size(1196, 406)
            Me.tbpOdontograma.TabIndex = 8
            Me.tbpOdontograma.Text = "Odontograma"
            Me.tbpOdontograma.UseVisualStyleBackColor = True
            '
            'UscOdont
            '
            Me.UscOdont._IngresoID = -1
            Me.UscOdont._IngresoInpeID = -1
            Me.UscOdont._InternoId = -1
            Me.UscOdont._InternoIngresoID = -1
            Me.UscOdont._PenalId = -1
            Me.UscOdont._RegionId = -1
            Me.UscOdont._VisibleEliminar = False
            Me.UscOdont._VisibleGrabar = False
            Me.UscOdont.Location = New System.Drawing.Point(0, 0)
            Me.UscOdont.Name = "UscOdont"
            Me.UscOdont.Size = New System.Drawing.Size(860, 496)
            Me.UscOdont.TabIndex = 2
            Me.UscOdont.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpHuella
            '
            Me.tbpHuella.Controls.Add(Me.UscVisorDetalleHuellas1)
            Me.tbpHuella.Location = New System.Drawing.Point(4, 25)
            Me.tbpHuella.Name = "tbpHuella"
            Me.tbpHuella.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpHuella.Size = New System.Drawing.Size(1196, 406)
            Me.tbpHuella.TabIndex = 10
            Me.tbpHuella.Text = "Huella dactilar"
            Me.tbpHuella.UseVisualStyleBackColor = True
            '
            'UscVisorDetalleHuellas1
            '
            Me.UscVisorDetalleHuellas1._ApeMat = ""
            Me.UscVisorDetalleHuellas1._ApePat = ""
            Me.UscVisorDetalleHuellas1._CodRP = ""
            Me.UscVisorDetalleHuellas1._ControlSoloVista = False
            Me.UscVisorDetalleHuellas1._InternoId = 0
            Me.UscVisorDetalleHuellas1._Nombres = ""
            Me.UscVisorDetalleHuellas1._NumDocIdent = ""
            Me.UscVisorDetalleHuellas1._PenId = 0
            Me.UscVisorDetalleHuellas1._RegId = 0
            Me.UscVisorDetalleHuellas1._TipDocIdentId = -1
            Me.UscVisorDetalleHuellas1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscVisorDetalleHuellas1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscVisorDetalleHuellas1.Location = New System.Drawing.Point(3, 3)
            Me.UscVisorDetalleHuellas1.Name = "UscVisorDetalleHuellas1"
            Me.UscVisorDetalleHuellas1.Size = New System.Drawing.Size(1190, 400)
            Me.UscVisorDetalleHuellas1.TabIndex = 1
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "Personal-information-32.png")
            '
            'pnlPiePagina
            '
            Me.pnlPiePagina.BackColor = System.Drawing.Color.Gainsboro
            Me.pnlPiePagina.Controls.Add(Me.pnlAuditoria)
            Me.pnlPiePagina.Controls.Add(Me.pnlUpdateDocJud)
            Me.pnlPiePagina.Controls.Add(Me.pnlNuevoReniec)
            Me.pnlPiePagina.Controls.Add(Me.pnlGrabarDatos)
            Me.pnlPiePagina.Controls.Add(Me.pnlEliminar)
            Me.pnlPiePagina.Controls.Add(Me.pnlReporte)
            Me.pnlPiePagina.Controls.Add(Me.pnlSalir)
            Me.pnlPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPiePagina.Location = New System.Drawing.Point(0, 498)
            Me.pnlPiePagina.Name = "pnlPiePagina"
            Me.pnlPiePagina.Size = New System.Drawing.Size(1296, 45)
            Me.pnlPiePagina.TabIndex = 40
            '
            'pnlAuditoria
            '
            Me.pnlAuditoria.Controls.Add(Me.UscAuditUser1)
            Me.pnlAuditoria.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlAuditoria.Location = New System.Drawing.Point(0, 0)
            Me.pnlAuditoria.Name = "pnlAuditoria"
            Me.pnlAuditoria.Size = New System.Drawing.Size(571, 45)
            Me.pnlAuditoria.TabIndex = 95
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(571, 45)
            Me.UscAuditUser1.TabIndex = 0
            '
            'pnlUpdateDocJud
            '
            Me.pnlUpdateDocJud.Controls.Add(Me.btnRefresh)
            Me.pnlUpdateDocJud.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlUpdateDocJud.Location = New System.Drawing.Point(571, 0)
            Me.pnlUpdateDocJud.Name = "pnlUpdateDocJud"
            Me.pnlUpdateDocJud.Size = New System.Drawing.Size(178, 45)
            Me.pnlUpdateDocJud.TabIndex = 96
            '
            'btnRefresh
            '
            Me.btnRefresh.Image = Global.SIPPOPE.My.Resources.Resources._1316210268_go_bottom
            Me.btnRefresh.Location = New System.Drawing.Point(2, 2)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(172, 40)
            Me.btnRefresh.TabIndex = 13
            Me.btnRefresh.Text = "Descargar Documentos Judiciales de la O.R.L."
            Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTipMensaje.SetToolTip(Me.btnRefresh, "Descargar actualización de datos del interno actual desde la Oficina Regional.")
            Me.btnRefresh.UseVisualStyleBackColor = True
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnIngreso)
            Me.pnlGrabarDatos.Controls.Add(Me.btnGrabar)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(839, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(192, 45)
            Me.pnlGrabarDatos.TabIndex = 0
            '
            'btnIngreso
            '
            Me.btnIngreso.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnIngreso.BackColor = System.Drawing.SystemColors.Control
            Me.btnIngreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnIngreso.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnIngreso.Location = New System.Drawing.Point(2, 1)
            Me.btnIngreso.Name = "btnIngreso"
            Me.btnIngreso.Size = New System.Drawing.Size(95, 40)
            Me.btnIngreso.TabIndex = 0
            Me.btnIngreso.Text = "Nuevo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Ingreso"
            Me.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTipMensaje.SetToolTip(Me.btnIngreso, "Click aqui para realizar una nueva validación")
            Me.btnIngreso.UseVisualStyleBackColor = False
            '
            'btnGrabar
            '
            Me.btnGrabar.BackColor = System.Drawing.SystemColors.Control
            Me.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
            Me.btnGrabar.Location = New System.Drawing.Point(98, 1)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(94, 40)
            Me.btnGrabar.TabIndex = 0
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = False
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(1031, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(86, 45)
            Me.pnlEliminar.TabIndex = 1
            '
            'btnEliminar
            '
            Me.btnEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
            Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
            Me.btnEliminar.Location = New System.Drawing.Point(1, 1)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(85, 40)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnFicha)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlReporte.Location = New System.Drawing.Point(1117, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(97, 45)
            Me.pnlReporte.TabIndex = 94
            '
            'btnFicha
            '
            Me.btnFicha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnFicha.BackColor = System.Drawing.SystemColors.Control
            Me.btnFicha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnFicha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFicha.Image = CType(resources.GetObject("btnFicha.Image"), System.Drawing.Image)
            Me.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.Location = New System.Drawing.Point(2, 1)
            Me.btnFicha.Name = "btnFicha"
            Me.btnFicha.Size = New System.Drawing.Size(94, 40)
            Me.btnFicha.TabIndex = 0
            Me.btnFicha.Text = "&Reportes"
            Me.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnFicha.UseVisualStyleBackColor = False
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(1214, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(82, 45)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
            Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(1, 1)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(77, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = False
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tbpInterno)
            Me.TabControl1.Controls.Add(Me.tbpMandDet)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 31)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1296, 467)
            Me.TabControl1.TabIndex = 1
            '
            'tbpMandDet
            '
            Me.tbpMandDet.Controls.Add(Me.TabControl3)
            Me.tbpMandDet.Location = New System.Drawing.Point(4, 22)
            Me.tbpMandDet.Name = "tbpMandDet"
            Me.tbpMandDet.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpMandDet.Size = New System.Drawing.Size(1210, 441)
            Me.tbpMandDet.TabIndex = 5
            Me.tbpMandDet.Text = "Documentos judiciales y Movimientos"
            Me.tbpMandDet.UseVisualStyleBackColor = True
            '
            'TabControl3
            '
            Me.TabControl3.Controls.Add(Me.tbpListaExpedientes)
            Me.TabControl3.Controls.Add(Me.tbpDocumentos)
            Me.TabControl3.Controls.Add(Me.tbpMovimientos)
            Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl3.Location = New System.Drawing.Point(3, 3)
            Me.TabControl3.Name = "TabControl3"
            Me.TabControl3.SelectedIndex = 0
            Me.TabControl3.Size = New System.Drawing.Size(1204, 435)
            Me.TabControl3.TabIndex = 14
            '
            'tbpListaExpedientes
            '
            Me.tbpListaExpedientes.Controls.Add(Me.btnDelitosHistoricos)
            Me.tbpListaExpedientes.Controls.Add(Me.UscMandatoDetencion)
            Me.tbpListaExpedientes.Location = New System.Drawing.Point(4, 22)
            Me.tbpListaExpedientes.Name = "tbpListaExpedientes"
            Me.tbpListaExpedientes.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpListaExpedientes.Size = New System.Drawing.Size(1196, 409)
            Me.tbpListaExpedientes.TabIndex = 0
            Me.tbpListaExpedientes.Text = "Lista de procesos"
            Me.tbpListaExpedientes.UseVisualStyleBackColor = True
            '
            'btnDelitosHistoricos
            '
            Me.btnDelitosHistoricos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDelitosHistoricos.Location = New System.Drawing.Point(1013, 2)
            Me.btnDelitosHistoricos.Name = "btnDelitosHistoricos"
            Me.btnDelitosHistoricos.Size = New System.Drawing.Size(179, 20)
            Me.btnDelitosHistoricos.TabIndex = 1
            Me.btnDelitosHistoricos.Text = "Historial de Selección DMP y SMP"
            Me.btnDelitosHistoricos.UseVisualStyleBackColor = True
            '
            'UscMandatoDetencion
            '
            Me.UscMandatoDetencion._IDIngresoINPE = -1
            Me.UscMandatoDetencion._InternoEstado = -1
            Me.UscMandatoDetencion._InternoID = -1
            Me.UscMandatoDetencion._ObjEntAgr = Nothing
            Me.UscMandatoDetencion._ObjEntAgrCol = Nothing
            Me.UscMandatoDetencion._objEntCol = Nothing
            Me.UscMandatoDetencion._ObjEntDel = Nothing
            Me.UscMandatoDetencion._ObjEntExp = Nothing
            Me.UscMandatoDetencion._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscMandatoDetencion._VisibleAnulacion = False
            Me.UscMandatoDetencion._VisiblePadin = False
            Me.UscMandatoDetencion.AutoScroll = True
            Me.UscMandatoDetencion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMandatoDetencion.Location = New System.Drawing.Point(3, 3)
            Me.UscMandatoDetencion.Name = "UscMandatoDetencion"
            Me.UscMandatoDetencion.PenalID = -1
            Me.UscMandatoDetencion.RegionID = -1
            Me.UscMandatoDetencion.Size = New System.Drawing.Size(1190, 403)
            Me.UscMandatoDetencion.TabIndex = 0
            '
            'tbpDocumentos
            '
            Me.tbpDocumentos.Controls.Add(Me.UscResolucionesMain1)
            Me.tbpDocumentos.Location = New System.Drawing.Point(4, 22)
            Me.tbpDocumentos.Name = "tbpDocumentos"
            Me.tbpDocumentos.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpDocumentos.Size = New System.Drawing.Size(1196, 409)
            Me.tbpDocumentos.TabIndex = 1
            Me.tbpDocumentos.Text = "Documentos judiciales y Resoluciones"
            Me.tbpDocumentos.UseVisualStyleBackColor = True
            '
            'UscResolucionesMain1
            '
            Me.UscResolucionesMain1._Codigo = 0
            Me.UscResolucionesMain1._ExcluirMandatoDeCarceleta = False
            Me.UscResolucionesMain1._IngresoInpeID = -1
            Me.UscResolucionesMain1._InternoID = -1
            Me.UscResolucionesMain1._NroIngresoID = -1
            Me.UscResolucionesMain1._OpcionListar = 5
            Me.UscResolucionesMain1._PenalID = -1
            Me.UscResolucionesMain1._RegionID = -1
            Me.UscResolucionesMain1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolucionesMain1._VisibleEliminar = False
            Me.UscResolucionesMain1._VisibleGrabar = False
            Me.UscResolucionesMain1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscResolucionesMain1.Location = New System.Drawing.Point(3, 3)
            Me.UscResolucionesMain1.Name = "UscResolucionesMain1"
            Me.UscResolucionesMain1.Size = New System.Drawing.Size(1190, 403)
            Me.UscResolucionesMain1.TabIndex = 12
            '
            'tbpMovimientos
            '
            Me.tbpMovimientos.Controls.Add(Me.UscMovimiento1)
            Me.tbpMovimientos.Location = New System.Drawing.Point(4, 22)
            Me.tbpMovimientos.Name = "tbpMovimientos"
            Me.tbpMovimientos.Size = New System.Drawing.Size(1196, 409)
            Me.tbpMovimientos.TabIndex = 2
            Me.tbpMovimientos.Text = "Movimientos de Ingreso/Egreso"
            Me.tbpMovimientos.UseVisualStyleBackColor = True
            '
            'UscMovimiento1
            '
            Me.UscMovimiento1._IngresoInpeID = -1
            Me.UscMovimiento1._InternoID = -1
            Me.UscMovimiento1._NroIngresoID = -1
            Me.UscMovimiento1._PenalID = -1
            Me.UscMovimiento1._RegionID = -1
            Me.UscMovimiento1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscMovimiento1._VisibleEliminar = False
            Me.UscMovimiento1._VisibleGrabar = False
            Me.UscMovimiento1.Codigo = 0
            Me.UscMovimiento1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMovimiento1.Location = New System.Drawing.Point(0, 0)
            Me.UscMovimiento1.Name = "UscMovimiento1"
            Me.UscMovimiento1.Size = New System.Drawing.Size(1196, 409)
            Me.UscMovimiento1.TabIndex = 0
            '
            'btnAddIngreso
            '
            Me.btnAddIngreso.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddIngreso.Location = New System.Drawing.Point(0, 0)
            Me.btnAddIngreso.Name = "btnAddIngreso"
            Me.btnAddIngreso.Size = New System.Drawing.Size(25, 25)
            Me.btnAddIngreso.TabIndex = 2
            Me.btnAddIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.btnAddIngreso.UseVisualStyleBackColor = True
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label37.Location = New System.Drawing.Point(2, 6)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(60, 13)
            Me.Label37.TabIndex = 0
            Me.Label37.Text = "N° Ingreso:"
            '
            'cbbNroIngresos
            '
            Me.cbbNroIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbNroIngresos.FormattingEnabled = True
            Me.cbbNroIngresos.Location = New System.Drawing.Point(61, 2)
            Me.cbbNroIngresos.Name = "cbbNroIngresos"
            Me.cbbNroIngresos.Size = New System.Drawing.Size(242, 21)
            Me.cbbNroIngresos.TabIndex = 1
            '
            'txtEstado
            '
            Me.txtEstado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstado._BloquearPaste = False
            Me.txtEstado._SeleccionarTodo = False
            Me.txtEstado.BackColor = System.Drawing.Color.White
            Me.txtEstado.Location = New System.Drawing.Point(395, 3)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(61, 20)
            Me.txtEstado.TabIndex = 5
            Me.txtEstado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtEstado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label36
            '
            Me.Label36.AutoSize = True
            Me.Label36.Location = New System.Drawing.Point(354, 6)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(43, 13)
            Me.Label36.TabIndex = 4
            Me.Label36.Text = "Estado:"
            '
            'txtCodigo
            '
            Me.txtCodigo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodigo._BloquearPaste = False
            Me.txtCodigo._SeleccionarTodo = False
            Me.txtCodigo.BackColor = System.Drawing.Color.White
            Me.txtCodigo.Location = New System.Drawing.Point(48, 4)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.ReadOnly = True
            Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
            Me.txtCodigo.TabIndex = 1
            Me.txtCodigo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodigo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtInterno
            '
            Me.txtInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtInterno._BloquearPaste = False
            Me.txtInterno._SeleccionarTodo = False
            Me.txtInterno.BackColor = System.Drawing.Color.White
            Me.txtInterno.Location = New System.Drawing.Point(169, 4)
            Me.txtInterno.Name = "txtInterno"
            Me.txtInterno.ReadOnly = True
            Me.txtInterno.Size = New System.Drawing.Size(183, 20)
            Me.txtInterno.TabIndex = 3
            Me.txtInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtRegionPenal
            '
            Me.txtRegionPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRegionPenal._BloquearPaste = False
            Me.txtRegionPenal._SeleccionarTodo = False
            Me.txtRegionPenal.BackColor = System.Drawing.Color.White
            Me.txtRegionPenal.Location = New System.Drawing.Point(75, 1)
            Me.txtRegionPenal.Name = "txtRegionPenal"
            Me.txtRegionPenal.ReadOnly = True
            Me.txtRegionPenal.Size = New System.Drawing.Size(206, 20)
            Me.txtRegionPenal.TabIndex = 1
            Me.txtRegionPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegionPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(2, 4)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(76, 13)
            Me.Label28.TabIndex = 0
            Me.Label28.Text = "Región/Penal:"
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.Location = New System.Drawing.Point(106, 3)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(97, 40)
            Me.Button1.TabIndex = 66
            Me.Button1.Text = "&Salir"
            Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.Button1.UseVisualStyleBackColor = True
            '
            'pnlRegionPenal
            '
            Me.pnlRegionPenal.Controls.Add(Me.txtRegionPenal)
            Me.pnlRegionPenal.Controls.Add(Me.Label28)
            Me.pnlRegionPenal.Location = New System.Drawing.Point(457, 3)
            Me.pnlRegionPenal.Name = "pnlRegionPenal"
            Me.pnlRegionPenal.Size = New System.Drawing.Size(283, 23)
            Me.pnlRegionPenal.TabIndex = 6
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Controls.Add(Me.txtCodigo)
            Me.Panel1.Controls.Add(Me.pnlRegionPenal)
            Me.Panel1.Controls.Add(Me.txtEstado)
            Me.Panel1.Controls.Add(Me.Label35)
            Me.Panel1.Controls.Add(Me.txtInterno)
            Me.Panel1.Controls.Add(Me.Label30)
            Me.Panel1.Controls.Add(Me.Label36)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1296, 31)
            Me.Panel1.TabIndex = 0
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.pnlAddIngreso)
            Me.Panel5.Controls.Add(Me.cbbNroIngresos)
            Me.Panel5.Controls.Add(Me.Label37)
            Me.Panel5.Location = New System.Drawing.Point(738, 1)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(329, 26)
            Me.Panel5.TabIndex = 7
            '
            'pnlAddIngreso
            '
            Me.pnlAddIngreso.Controls.Add(Me.pnlIngresoAdd)
            Me.pnlAddIngreso.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAddIngreso.Location = New System.Drawing.Point(303, 0)
            Me.pnlAddIngreso.Name = "pnlAddIngreso"
            Me.pnlAddIngreso.Size = New System.Drawing.Size(26, 26)
            Me.pnlAddIngreso.TabIndex = 2
            '
            'pnlIngresoAdd
            '
            Me.pnlIngresoAdd.Controls.Add(Me.btnAddIngreso)
            Me.pnlIngresoAdd.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlIngresoAdd.Location = New System.Drawing.Point(0, 0)
            Me.pnlIngresoAdd.Name = "pnlIngresoAdd"
            Me.pnlIngresoAdd.Size = New System.Drawing.Size(25, 26)
            Me.pnlIngresoAdd.TabIndex = 0
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Location = New System.Drawing.Point(2, 6)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(46, 13)
            Me.Label35.TabIndex = 0
            Me.Label35.Text = "Código :"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(128, 7)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(43, 13)
            Me.Label30.TabIndex = 2
            Me.Label30.Text = "Interno:"
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'BackgroundWorker2
            '
            Me.BackgroundWorker2.WorkerSupportsCancellation = True
            '
            'frmMantenimiento
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1296, 543)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.pnlPiePagina)
            Me.Name = "frmMantenimiento"
            Me.Text = "Interno - Detalle PLM"
            Me.pnlNuevoReniec.ResumeLayout(False)
            Me.tbpInterno.ResumeLayout(False)
            Me.tcDatosInternos.ResumeLayout(False)
            Me.tbpDatos.ResumeLayout(False)
            Me.pnlDatosPer.ResumeLayout(False)
            Me.pnlDatosAca.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.grpVerificarReniec.ResumeLayout(False)
            Me.grpVerificarReniec.PerformLayout()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.pnlUbigeo.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.tbpDatosComplement.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox7.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.tbpNombresAsoc.ResumeLayout(False)
            Me.tbpFoto.ResumeLayout(False)
            Me.tbpReniec.ResumeLayout(False)
            Me.tbpAliasBandas.ResumeLayout(False)
            Me.tbpBandas.ResumeLayout(False)
            Me.tbpFamiliares.ResumeLayout(False)
            Me.tbpOdontograma.ResumeLayout(False)
            Me.tbpHuella.ResumeLayout(False)
            Me.pnlPiePagina.ResumeLayout(False)
            Me.pnlAuditoria.ResumeLayout(False)
            Me.pnlUpdateDocJud.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tbpMandDet.ResumeLayout(False)
            Me.TabControl3.ResumeLayout(False)
            Me.tbpListaExpedientes.ResumeLayout(False)
            Me.tbpDocumentos.ResumeLayout(False)
            Me.tbpMovimientos.ResumeLayout(False)
            Me.pnlRegionPenal.ResumeLayout(False)
            Me.pnlRegionPenal.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlAddIngreso.ResumeLayout(False)
            Me.pnlIngresoAdd.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tbpInterno As System.Windows.Forms.TabPage
        Friend WithEvents tcDatosInternos As System.Windows.Forms.TabControl
        Friend WithEvents tbpDatos As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeoOtro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbbDistrito As System.Windows.Forms.ComboBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cbbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents CbbDepartamento As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cbbPais As System.Windows.Forms.ComboBox
        Friend WithEvents tbpAliasBandas As System.Windows.Forms.TabPage
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tbpFamiliares As System.Windows.Forms.TabPage
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents pnlDatosPer As System.Windows.Forms.Panel
        Friend WithEvents pnlUbigeo As System.Windows.Forms.Panel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDomicilio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents cbbDomicilioDist As System.Windows.Forms.ComboBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cbbDomicilioProv As System.Windows.Forms.ComboBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents cbbDomicilioDepa As System.Windows.Forms.ComboBox
        Friend WithEvents pnlDatosAca As System.Windows.Forms.Panel
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents txtRegionPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents pnlPiePagina As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents tbpFoto As System.Windows.Forms.TabPage
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents cbbSexo As APPControls.uscComboParametrica
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents cbbEstadoCivil As APPControls.uscComboParametrica
        Friend WithEvents cbbDiscapacitado As APPControls.uscComboParametrica
        Friend WithEvents cbbAndina As APPControls.uscComboParametrica
        Friend WithEvents cbbNivelAca As APPControls.uscComboParametrica
        Friend WithEvents cbbProfesion As APPControls.uscComboParametrica
        Friend WithEvents cbbOcupacion As APPControls.uscComboParametrica
        Friend WithEvents cbbAndinaEsp As APPControls.uscComboParametrica
        Friend WithEvents cbbPabellon As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents tbpNombresAsoc As System.Windows.Forms.TabPage
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents chkNoindica As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents txtPabellon As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents chk_Obs_DNI As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents txtObs_dni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents pnlNuevoReniec As System.Windows.Forms.Panel
        Friend WithEvents tbpBandas As System.Windows.Forms.TabPage
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents cbbNroIngresos As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents tbpReniec As System.Windows.Forms.TabPage
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents ToolTipMensaje As System.Windows.Forms.ToolTip
        Friend WithEvents btnFicha As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents UscGrillaNombresAsociadosV21 As APPControls.Registro.uscGrillaNombresAsociadosV2
        Friend WithEvents UscOrganizacionCriminal As APPControls.Registro.Siscrico.uscGrillaOrgCriminal_LM
        Friend WithEvents UscValidacionReniecV21 As APPControls.Registro.Reniec.v5.uscValidacionReniecV2_LM
        Friend WithEvents btnAddIngreso As System.Windows.Forms.Button
        Friend WithEvents uscFotoPerfiles As APPControls.Registro.Captura.uscFotografia_LM
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents pnlRegionPenal As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents pnlAddIngreso As System.Windows.Forms.Panel
        Friend WithEvents pnlIngresoAdd As System.Windows.Forms.Panel
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents grpVerificarReniec As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaVerRnc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtTipoVerRnc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEstadoVerRnc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtObservacionRnc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents Label40 As System.Windows.Forms.Label
        Friend WithEvents Label41 As System.Windows.Forms.Label
        Friend WithEvents Label42 As System.Windows.Forms.Label
        Friend WithEvents pnlAuditoria As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents chk_Homonimia As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents btnIngreso As System.Windows.Forms.Button
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApellidosNombresreniec As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents UscAlias21 As APPControls.Registro.Identificacion.v5.uscAlias2
        Friend WithEvents UscBandas21 As APPControls.Registro.Identificacion.v5.UserBandas_LM
        Friend WithEvents tbpDatosComplement As System.Windows.Forms.TabPage
        Friend WithEvents tbpOdontograma As System.Windows.Forms.TabPage
        Friend WithEvents UscOdont As APPControls.Registro.Odontograma.uscOdontogramaMain_LM
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents UscIdiomaInterno1 As APPControls.Registro.Identificacion.uscIdiomaInterno
        Friend WithEvents Label45 As System.Windows.Forms.Label
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents cbbIdiomaPrincipal As APPControls.uscComboParametrica
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents cbbGenero As APPControls.uscComboParametrica
        Friend WithEvents txtCentroTrabajo As System.Windows.Forms.TextBox
        Friend WithEvents cbbReligion As APPControls.uscComboParametrica
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents UscDomicilio1 As APPControls.Registro.Identificacion.uscDomicilio
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents UscGradosAcademicos1 As APPControls.Registro.Identificacion.uscGradosAcademicos
        Friend WithEvents tbpMandDet As System.Windows.Forms.TabPage
        Friend WithEvents UscFamilias1 As APPControls.Registro.Identificacion.v5.uscFamilia
        Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
        Friend WithEvents tbpListaExpedientes As System.Windows.Forms.TabPage
        Friend WithEvents UscMandatoDetencion As APPControls.Registro.Documento.uscMandatoDetencion_LM
        Friend WithEvents tbpDocumentos As System.Windows.Forms.TabPage
        Friend WithEvents UscResolucionesMain1 As APPControls.Registro.Resoluciones.uscResolucionesMain_LM
        Friend WithEvents UscMovimiento1 As APPControls.Registro.uscMovimiento
        Friend WithEvents btnRefresh As System.Windows.Forms.Button
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtNomClaveInt As System.Windows.Forms.TextBox
        Friend WithEvents txtDecadactDer As System.Windows.Forms.TextBox
        Friend WithEvents txtDecadactIzq As System.Windows.Forms.TextBox
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents tbpHuella As System.Windows.Forms.TabPage
        Friend WithEvents UscVisorDetalleHuellas1 As APPControls.Registro.Huellas.uscVisorDetalleHuellas
        Friend WithEvents cbbCodFuerArmada As System.Windows.Forms.ComboBox
        Friend WithEvents cbbCodigoRango As System.Windows.Forms.ComboBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents cbbCentroReclu As ComboBox
        Friend WithEvents Label27 As Label
        Friend WithEvents Label35 As Label
        Friend WithEvents tbpMovimientos As TabPage
        Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
        Friend WithEvents pnlUpdateDocJud As Panel
        Friend WithEvents Label30 As Label
        Friend WithEvents btnDelitosHistoricos As Button
        Friend WithEvents Panel2 As Panel
        Friend WithEvents UscEtniaLenguaMaterna_v21 As APPControls.Registro.Identificacion.uscEtniaLenguaMaterna_v2
        'Friend WithEvents UscClasificaciones2 As APPControls.Clasificacion.uscClasificaciones
    End Class
End Namespace