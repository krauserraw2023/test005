Namespace Registro.Penal.Busqueda
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMant_v3_Odon
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMant_v2))
            Me.tbpInterno = New System.Windows.Forms.TabPage()
            Me.tbcDatosInternos = New System.Windows.Forms.TabControl()
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
            Me.Label38 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
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
            Me.uscFotoPerfiles = New APPControls.Registro.Captura.uscFotografia3()
            Me.tbpReniec = New System.Windows.Forms.TabPage()
            Me.UscValidacionReniecV21 = New APPControls.Registro.Reniec.uscValidacionReniecV2()
            Me.tbpAlias = New System.Windows.Forms.TabPage()
            Me.UscBandas21 = New APPControls.uscBandas2()
            Me.UscAlias21 = New APPControls.Registro.Identificacion.v5.uscAlias2()
            Me.tbpOrgCriminal = New System.Windows.Forms.TabPage()
            Me.UscGrillaBandasV21 = New APPControls.Registro.Siscrico.uscGrillaOrgCriminalV2()
            Me.tbpFamiliares = New System.Windows.Forms.TabPage()
            Me.UscFamilias1 = New APPControls.Registro.Identificacion.v5.uscFamilia()
            Me.tbpOdontograma = New System.Windows.Forms.TabPage()
            Me.UscOdont = New APPControls.Registro.Odontograma.uscOdontogramaBuscar()
            Me.tbpHuella = New System.Windows.Forms.TabPage()
            Me.UscVisorDetalleHuellas1 = New APPControls.Registro.Huellas.uscVisorDetalleHuellas()
            Me.pnlBoton = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.pnlLeyenda = New System.Windows.Forms.Panel()
            Me.lblLeyenda2 = New System.Windows.Forms.Label()
            Me.lblLeyenda1 = New System.Windows.Forms.Label()
            Me.pnlNuevoReniec = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.btnIngreso = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlVerLibro = New System.Windows.Forms.Panel()
            Me.btnVerLibros = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnFicha = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tbpResoluciones = New System.Windows.Forms.TabPage()
            Me.TabControl3 = New System.Windows.Forms.TabControl()
            Me.tbpListaExpedientes = New System.Windows.Forms.TabPage()
            Me.btnDelitosHistoricos = New System.Windows.Forms.Button()
            Me.UscMandatoDetencion = New APPControls.Registro.Documento.uscMandatoDetencion()
            Me.tbpDocumentos = New System.Windows.Forms.TabPage()
            Me.UscResolucionesMain1 = New APPControls.Registro.Resoluciones.uscResolucionesMain()
            Me.tbpMovimientos = New System.Windows.Forms.TabPage()
            Me.tcMovimientos = New System.Windows.Forms.TabControl()
            Me.tbMovInterno = New System.Windows.Forms.TabPage()
            Me.UscMovimiento1 = New APPControls.Registro.uscMovimiento()
            Me.tbConstanciaReclu = New System.Windows.Forms.TabPage()
            Me.UscInternoDetalle1 = New APPControls.Registro.ConsultaReclusion.uscInternoDetalle()
            Me.tbpClasificacion = New System.Windows.Forms.TabPage()
            Me.tcClasificacion = New System.Windows.Forms.TabControl()
            Me.tpRegimen = New System.Windows.Forms.TabPage()
            Me.UscFichaClasificacion1 = New APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacion()
            Me.tpEtapa = New System.Windows.Forms.TabPage()
            Me.UscFichaClasificacion2 = New APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacion()
            Me.tpPabellon = New System.Windows.Forms.TabPage()
            Me.UscPabellon1 = New APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscPabellon()
            Me.btnAddIngreso = New System.Windows.Forms.Button()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.cbbNroIngresos = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtEstado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtCodigo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label35 = New System.Windows.Forms.Label()
            Me.txtInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtRegionPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ToolTipMensaje = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlRegionPenal = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.Panel10 = New System.Windows.Forms.Panel()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.pnlAddIngreso = New System.Windows.Forms.Panel()
            Me.pnlIngresoAdd = New System.Windows.Forms.Panel()
            Me.pnlInactivar = New System.Windows.Forms.Panel()
            Me.btnInactivar = New System.Windows.Forms.Button()
            Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
            Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.tbpInterno.SuspendLayout()
            Me.tbcDatosInternos.SuspendLayout()
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
            Me.tbpAlias.SuspendLayout()
            Me.tbpOrgCriminal.SuspendLayout()
            Me.tbpFamiliares.SuspendLayout()
            Me.tbpOdontograma.SuspendLayout()
            Me.tbpHuella.SuspendLayout()
            Me.pnlBoton.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlLeyenda.SuspendLayout()
            Me.pnlNuevoReniec.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlVerLibro.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tbpResoluciones.SuspendLayout()
            Me.TabControl3.SuspendLayout()
            Me.tbpListaExpedientes.SuspendLayout()
            Me.tbpDocumentos.SuspendLayout()
            Me.tbpMovimientos.SuspendLayout()
            Me.tcMovimientos.SuspendLayout()
            Me.tbMovInterno.SuspendLayout()
            Me.tbConstanciaReclu.SuspendLayout()
            Me.tbpClasificacion.SuspendLayout()
            Me.tcClasificacion.SuspendLayout()
            Me.tpRegimen.SuspendLayout()
            Me.tpEtapa.SuspendLayout()
            Me.tpPabellon.SuspendLayout()
            Me.pnlRegionPenal.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.Panel10.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pnlAddIngreso.SuspendLayout()
            Me.pnlIngresoAdd.SuspendLayout()
            Me.pnlInactivar.SuspendLayout()
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tbpInterno
            '
            Me.tbpInterno.Controls.Add(Me.tbcDatosInternos)
            Me.tbpInterno.Location = New System.Drawing.Point(4, 22)
            Me.tbpInterno.Name = "tbpInterno"
            Me.tbpInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpInterno.Size = New System.Drawing.Size(1269, 501)
            Me.tbpInterno.TabIndex = 0
            Me.tbpInterno.Text = "Identificación de interno"
            Me.tbpInterno.UseVisualStyleBackColor = True
            '
            'tbcDatosInternos
            '
            Me.tbcDatosInternos.Controls.Add(Me.tbpDatos)
            Me.tbcDatosInternos.Controls.Add(Me.tbpDatosComplement)
            Me.tbcDatosInternos.Controls.Add(Me.tbpNombresAsoc)
            Me.tbcDatosInternos.Controls.Add(Me.tbpFoto)
            Me.tbcDatosInternos.Controls.Add(Me.tbpReniec)
            Me.tbcDatosInternos.Controls.Add(Me.tbpAlias)
            Me.tbcDatosInternos.Controls.Add(Me.tbpOrgCriminal)
            Me.tbcDatosInternos.Controls.Add(Me.tbpFamiliares)
            Me.tbcDatosInternos.Controls.Add(Me.tbpOdontograma)
            Me.tbcDatosInternos.Controls.Add(Me.tbpHuella)
            Me.tbcDatosInternos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbcDatosInternos.Location = New System.Drawing.Point(3, 3)
            Me.tbcDatosInternos.Name = "tbcDatosInternos"
            Me.tbcDatosInternos.SelectedIndex = 0
            Me.tbcDatosInternos.Size = New System.Drawing.Size(1263, 495)
            Me.tbcDatosInternos.TabIndex = 0
            '
            'tbpDatos
            '
            Me.tbpDatos.Controls.Add(Me.pnlDatosPer)
            Me.tbpDatos.Location = New System.Drawing.Point(4, 22)
            Me.tbpDatos.Name = "tbpDatos"
            Me.tbpDatos.Size = New System.Drawing.Size(1255, 469)
            Me.tbpDatos.TabIndex = 2
            Me.tbpDatos.Text = "Datos Personales"
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
            Me.pnlDatosPer.Size = New System.Drawing.Size(1255, 469)
            Me.pnlDatosPer.TabIndex = 36
            '
            'pnlDatosAca
            '
            Me.pnlDatosAca.Controls.Add(Me.Panel7)
            Me.pnlDatosAca.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDatosAca.Location = New System.Drawing.Point(541, 0)
            Me.pnlDatosAca.Name = "pnlDatosAca"
            Me.pnlDatosAca.Size = New System.Drawing.Size(714, 469)
            Me.pnlDatosAca.TabIndex = 39
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.grpVerificarReniec)
            Me.Panel7.Controls.Add(Me.GroupBox8)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel7.Location = New System.Drawing.Point(0, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(288, 469)
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
            Me.grpVerificarReniec.Location = New System.Drawing.Point(0, 248)
            Me.grpVerificarReniec.Name = "grpVerificarReniec"
            Me.grpVerificarReniec.Size = New System.Drawing.Size(288, 159)
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
            Me.txtFechaVerRnc.Location = New System.Drawing.Point(76, 86)
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
            Me.txtTipoVerRnc.Location = New System.Drawing.Point(76, 63)
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
            Me.txtEstadoVerRnc.Location = New System.Drawing.Point(76, 39)
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
            Me.txtObservacionRnc.Location = New System.Drawing.Point(76, 109)
            Me.txtObservacionRnc.Multiline = True
            Me.txtObservacionRnc.Name = "txtObservacionRnc"
            Me.txtObservacionRnc.ReadOnly = True
            Me.txtObservacionRnc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacionRnc.Size = New System.Drawing.Size(201, 46)
            Me.txtObservacionRnc.TabIndex = 8
            Me.txtObservacionRnc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacionRnc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.Location = New System.Drawing.Point(5, 112)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(73, 13)
            Me.Label29.TabIndex = 7
            Me.Label29.Text = "Observacion :"
            '
            'Label40
            '
            Me.Label40.AutoSize = True
            Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label40.Location = New System.Drawing.Point(5, 92)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(43, 13)
            Me.Label40.TabIndex = 5
            Me.Label40.Text = "Fecha :"
            '
            'Label41
            '
            Me.Label41.AutoSize = True
            Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label41.Location = New System.Drawing.Point(4, 58)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(67, 26)
            Me.Label41.TabIndex = 3
            Me.Label41.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "verificacion :"
            '
            'Label42
            '
            Me.Label42.AutoSize = True
            Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label42.Location = New System.Drawing.Point(2, 42)
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
            Me.GroupBox8.Controls.Add(Me.Label38)
            Me.GroupBox8.Controls.Add(Me.Label34)
            Me.GroupBox8.Controls.Add(Me.txtObs)
            Me.GroupBox8.Controls.Add(Me.Label33)
            Me.GroupBox8.Controls.Add(Me.Label23)
            Me.GroupBox8.Controls.Add(Me.Label24)
            Me.GroupBox8.Controls.Add(Me.cbbAndina)
            Me.GroupBox8.Controls.Add(Me.cbbAndinaEsp)
            Me.GroupBox8.Controls.Add(Me.txtPabellon)
            Me.GroupBox8.Controls.Add(Me.cbbPabellon)
            Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(288, 248)
            Me.GroupBox8.TabIndex = 0
            Me.GroupBox8.TabStop = False
            Me.GroupBox8.Text = "Comunidad"
            '
            'txtDecadactDer
            '
            Me.txtDecadactDer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDecadactDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDecadactDer.Location = New System.Drawing.Point(61, 222)
            Me.txtDecadactDer.MaxLength = 5
            Me.txtDecadactDer.Name = "txtDecadactDer"
            Me.txtDecadactDer.Size = New System.Drawing.Size(68, 21)
            Me.txtDecadactDer.TabIndex = 39
            '
            'txtDecadactIzq
            '
            Me.txtDecadactIzq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDecadactIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDecadactIzq.Location = New System.Drawing.Point(195, 222)
            Me.txtDecadactIzq.MaxLength = 5
            Me.txtDecadactIzq.Name = "txtDecadactIzq"
            Me.txtDecadactIzq.Size = New System.Drawing.Size(83, 21)
            Me.txtDecadactIzq.TabIndex = 37
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.Location = New System.Drawing.Point(138, 225)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(53, 13)
            Me.Label50.TabIndex = 36
            Me.Label50.Text = "Izquierda:"
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label43.Location = New System.Drawing.Point(8, 225)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(51, 13)
            Me.Label43.TabIndex = 38
            Me.Label43.Text = "Derecha:"
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label38.Location = New System.Drawing.Point(2, 202)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(309, 13)
            Me.Label38.TabIndex = 35
            Me.Label38.Text = "_____________ Fórmula decadactilar ____________________"
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label34.Location = New System.Drawing.Point(9, 181)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(54, 13)
            Me.Label34.TabIndex = 6
            Me.Label34.Text = "Pabellon :"
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObs.Location = New System.Drawing.Point(9, 115)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(268, 53)
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
            Me.Label33.Text = "Observacion :"
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
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(6, 56)
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
            Me.cbbAndina.verToolTipItemSeleccionado = False
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
            Me.cbbAndinaEsp.Location = New System.Drawing.Point(9, 74)
            Me.cbbAndinaEsp.ModuloTratamiento = False
            Me.cbbAndinaEsp.Name = "cbbAndinaEsp"
            Me.cbbAndinaEsp.Parametro1 = -1
            Me.cbbAndinaEsp.Parametro2 = -1
            Me.cbbAndinaEsp.SelectedIndex = -1
            Me.cbbAndinaEsp.SelectedValue = 0
            Me.cbbAndinaEsp.Size = New System.Drawing.Size(268, 22)
            Me.cbbAndinaEsp.TabIndex = 3
            Me.cbbAndinaEsp.verToolTipItemSeleccionado = False
            '
            'txtPabellon
            '
            Me.txtPabellon._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPabellon._BloquearPaste = False
            Me.txtPabellon._SeleccionarTodo = False
            Me.txtPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPabellon.Location = New System.Drawing.Point(69, 177)
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
            Me.cbbPabellon.Location = New System.Drawing.Point(69, 177)
            Me.cbbPabellon.ModuloTratamiento = False
            Me.cbbPabellon.Name = "cbbPabellon"
            Me.cbbPabellon.Parametro1 = -1
            Me.cbbPabellon.Parametro2 = -1
            Me.cbbPabellon.SelectedIndex = -1
            Me.cbbPabellon.SelectedValue = 0
            Me.cbbPabellon.Size = New System.Drawing.Size(208, 22)
            Me.cbbPabellon.TabIndex = 34
            Me.cbbPabellon.verToolTipItemSeleccionado = False
            Me.cbbPabellon.Visible = False
            '
            'pnlUbigeo
            '
            Me.pnlUbigeo.Controls.Add(Me.GroupBox3)
            Me.pnlUbigeo.Controls.Add(Me.GroupBox2)
            Me.pnlUbigeo.Controls.Add(Me.GroupBox1)
            Me.pnlUbigeo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlUbigeo.Location = New System.Drawing.Point(269, 0)
            Me.pnlUbigeo.Name = "pnlUbigeo"
            Me.pnlUbigeo.Size = New System.Drawing.Size(272, 469)
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
            Me.GroupBox3.Text = "Datos Academicos :"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(6, 20)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(93, 13)
            Me.Label20.TabIndex = 0
            Me.Label20.Text = "Nivel Academico :"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(6, 64)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(57, 13)
            Me.Label22.TabIndex = 2
            Me.Label22.Text = "Profesion :"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(6, 104)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(65, 13)
            Me.Label25.TabIndex = 4
            Me.Label25.Text = "Ocupacion :"
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
            Me.cbbNivelAca.verToolTipItemSeleccionado = False
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
            Me.cbbProfesion.verToolTipItemSeleccionado = False
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
            Me.cbbOcupacion.verToolTipItemSeleccionado = False
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
            Me.GroupBox4.Size = New System.Drawing.Size(269, 469)
            Me.GroupBox4.TabIndex = 35
            Me.GroupBox4.TabStop = False
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.Location = New System.Drawing.Point(95, 73)
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
            Me.txtNumDoc.Location = New System.Drawing.Point(95, 292)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(168, 20)
            Me.txtNumDoc.TabIndex = 19
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'chk_Homonimia
            '
            Me.chk_Homonimia.AutoSize = True
            Me.chk_Homonimia.Location = New System.Drawing.Point(95, 147)
            Me.chk_Homonimia.Name = "chk_Homonimia"
            Me.chk_Homonimia.Size = New System.Drawing.Size(78, 17)
            Me.chk_Homonimia.TabIndex = 7
            Me.chk_Homonimia.Text = "Homonimia"
            Me.chk_Homonimia.UseVisualStyleBackColor = True
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(95, 194)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 11
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'Label39
            '
            Me.Label39.AutoSize = True
            Me.Label39.Location = New System.Drawing.Point(7, 227)
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
            Me.txtObs_dni.Location = New System.Drawing.Point(95, 220)
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
            Me.chk_Obs_DNI.Location = New System.Drawing.Point(190, 195)
            Me.chk_Obs_DNI.Name = "chk_Obs_DNI"
            Me.chk_Obs_DNI.Size = New System.Drawing.Size(71, 17)
            Me.chk_Obs_DNI.TabIndex = 12
            Me.chk_Obs_DNI.Text = "<18 Años"
            Me.chk_Obs_DNI.UseVisualStyleBackColor = True
            '
            'chkNoindica
            '
            Me.chkNoindica.AutoSize = True
            Me.chkNoindica.Location = New System.Drawing.Point(189, 268)
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
            Me.GroupBox6.Size = New System.Drawing.Size(257, 63)
            Me.GroupBox6.TabIndex = 0
            Me.GroupBox6.TabStop = False
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Location = New System.Drawing.Point(90, 34)
            Me.txtLibro.MaxLength = 4
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(51, 20)
            Me.txtLibro.TabIndex = 4
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(1, 37)
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
            Me.txtFolio.Location = New System.Drawing.Point(204, 34)
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
            Me.Label26.Location = New System.Drawing.Point(1, 13)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 0
            Me.Label26.Text = "Codigo Interno :"
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Location = New System.Drawing.Point(150, 38)
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
            Me.txtCodInterno.Location = New System.Drawing.Point(90, 10)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.ReadOnly = True
            Me.txtCodInterno.Size = New System.Drawing.Size(84, 20)
            Me.txtCodInterno.TabIndex = 1
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(7, 375)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(75, 13)
            Me.Label11.TabIndex = 24
            Me.Label11.Text = "Nacionalidad :"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(7, 349)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(78, 13)
            Me.Label18.TabIndex = 22
            Me.Label18.Text = "Discapacidad :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(5, 76)
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
            Me.cbbNacionalidad.Location = New System.Drawing.Point(95, 370)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(169, 22)
            Me.cbbNacionalidad.TabIndex = 25
            Me.cbbNacionalidad.verToolTipItemSeleccionado = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(7, 125)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Nombres :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 170)
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
            Me.txtNom.Location = New System.Drawing.Point(95, 122)
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
            Me.Label5.Location = New System.Drawing.Point(7, 200)
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
            Me.txtApeMat.Location = New System.Drawing.Point(95, 97)
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
            Me.Label12.Location = New System.Drawing.Point(7, 269)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(60, 13)
            Me.Label12.TabIndex = 15
            Me.Label12.Text = "Tipo Doc. :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(7, 296)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(76, 13)
            Me.Label13.TabIndex = 18
            Me.Label13.Text = "Numero Doc. :"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(7, 320)
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
            Me.cbbSexo.Location = New System.Drawing.Point(95, 167)
            Me.cbbSexo.ModuloTratamiento = False
            Me.cbbSexo.Name = "cbbSexo"
            Me.cbbSexo.Parametro1 = -1
            Me.cbbSexo.Parametro2 = -1
            Me.cbbSexo.SelectedIndex = -1
            Me.cbbSexo.SelectedValue = 0
            Me.cbbSexo.Size = New System.Drawing.Size(168, 22)
            Me.cbbSexo.TabIndex = 9
            Me.cbbSexo.verToolTipItemSeleccionado = False
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
            Me.cbbTipoDoc.Location = New System.Drawing.Point(95, 266)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(65, 22)
            Me.cbbTipoDoc.TabIndex = 16
            Me.cbbTipoDoc.verToolTipItemSeleccionado = False
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
            Me.cbbEstadoCivil.Location = New System.Drawing.Point(95, 317)
            Me.cbbEstadoCivil.ModuloTratamiento = False
            Me.cbbEstadoCivil.Name = "cbbEstadoCivil"
            Me.cbbEstadoCivil.Parametro1 = -1
            Me.cbbEstadoCivil.Parametro2 = -1
            Me.cbbEstadoCivil.SelectedIndex = -1
            Me.cbbEstadoCivil.SelectedValue = 0
            Me.cbbEstadoCivil.Size = New System.Drawing.Size(169, 22)
            Me.cbbEstadoCivil.TabIndex = 21
            Me.cbbEstadoCivil.verToolTipItemSeleccionado = False
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
            Me.cbbDiscapacitado.Location = New System.Drawing.Point(95, 344)
            Me.cbbDiscapacitado.ModuloTratamiento = False
            Me.cbbDiscapacitado.Name = "cbbDiscapacitado"
            Me.cbbDiscapacitado.Parametro1 = -1
            Me.cbbDiscapacitado.Parametro2 = -1
            Me.cbbDiscapacitado.SelectedIndex = -1
            Me.cbbDiscapacitado.SelectedValue = 0
            Me.cbbDiscapacitado.Size = New System.Drawing.Size(169, 22)
            Me.cbbDiscapacitado.TabIndex = 23
            Me.cbbDiscapacitado.verToolTipItemSeleccionado = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(5, 100)
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
            Me.tbpDatosComplement.Location = New System.Drawing.Point(4, 22)
            Me.tbpDatosComplement.Name = "tbpDatosComplement"
            Me.tbpDatosComplement.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpDatosComplement.Size = New System.Drawing.Size(1255, 469)
            Me.tbpDatosComplement.TabIndex = 9
            Me.tbpDatosComplement.Text = "Datos Complementarios"
            Me.tbpDatosComplement.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscEtniaLenguaMaterna_v21)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(787, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(394, 463)
            Me.Panel2.TabIndex = 6
            '
            'UscEtniaLenguaMaterna_v21
            '
            Me.UscEtniaLenguaMaterna_v21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscEtniaLenguaMaterna_v21.Location = New System.Drawing.Point(0, 0)
            Me.UscEtniaLenguaMaterna_v21.Name = "UscEtniaLenguaMaterna_v21"
            Me.UscEtniaLenguaMaterna_v21.Size = New System.Drawing.Size(394, 463)
            Me.UscEtniaLenguaMaterna_v21.TabIndex = 6
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.GroupBox9)
            Me.Panel6.Controls.Add(Me.GroupBox7)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel6.Location = New System.Drawing.Point(395, 3)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(392, 463)
            Me.Panel6.TabIndex = 4
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.UscDomicilio1)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox9.Location = New System.Drawing.Point(0, 215)
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
            Me.UscDomicilio1.Size = New System.Drawing.Size(386, 171)
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
            Me.GroupBox7.Size = New System.Drawing.Size(392, 215)
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
            Me.UscGradosAcademicos1.Size = New System.Drawing.Size(386, 196)
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
            Me.Panel4.Size = New System.Drawing.Size(392, 463)
            Me.Panel4.TabIndex = 3
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
            Me.GroupBox5.Location = New System.Drawing.Point(3, 214)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(386, 191)
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
            Me.UscIdiomaInterno1.Size = New System.Drawing.Size(380, 172)
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
            Me.cbbIdiomaPrincipal.verToolTipItemSeleccionado = False
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
            Me.cbbGenero.verToolTipItemSeleccionado = False
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
            Me.cbbReligion.verToolTipItemSeleccionado = False
            '
            'tbpNombresAsoc
            '
            Me.tbpNombresAsoc.Controls.Add(Me.UscGrillaNombresAsociadosV21)
            Me.tbpNombresAsoc.Location = New System.Drawing.Point(4, 22)
            Me.tbpNombresAsoc.Name = "tbpNombresAsoc"
            Me.tbpNombresAsoc.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpNombresAsoc.Size = New System.Drawing.Size(1255, 469)
            Me.tbpNombresAsoc.TabIndex = 0
            Me.tbpNombresAsoc.Text = "Nombres Asociados"
            Me.tbpNombresAsoc.UseVisualStyleBackColor = True
            '
            'UscGrillaNombresAsociadosV21
            '
            Me.UscGrillaNombresAsociadosV21._Documentos_sin_mov = False
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
            Me.UscGrillaNombresAsociadosV21.Size = New System.Drawing.Size(1249, 463)
            Me.UscGrillaNombresAsociadosV21.TabIndex = 1
            Me.UscGrillaNombresAsociadosV21.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpFoto
            '
            Me.tbpFoto.Controls.Add(Me.uscFotoPerfiles)
            Me.tbpFoto.Location = New System.Drawing.Point(4, 22)
            Me.tbpFoto.Name = "tbpFoto"
            Me.tbpFoto.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpFoto.Size = New System.Drawing.Size(1255, 469)
            Me.tbpFoto.TabIndex = 4
            Me.tbpFoto.Text = "Fotos"
            Me.tbpFoto.UseVisualStyleBackColor = True
            '
            'uscFotoPerfiles
            '
            Me.uscFotoPerfiles._InternoCodigoRP = ""
            Me.uscFotoPerfiles._InternoID = -1
            Me.uscFotoPerfiles._VisibleEliminar = False
            Me.uscFotoPerfiles._VisibleGrabar = False
            Me.uscFotoPerfiles.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscFotoPerfiles.InternoFotoID = -1
            Me.uscFotoPerfiles.InternoIngresoId = -1
            Me.uscFotoPerfiles.InternoIngresoNro = -1
            Me.uscFotoPerfiles.InternoRasgoID = -1
            Me.uscFotoPerfiles.Location = New System.Drawing.Point(3, 3)
            Me.uscFotoPerfiles.Name = "uscFotoPerfiles"
            Me.uscFotoPerfiles.PenalID = -1
            Me.uscFotoPerfiles.RegionID = -1
            Me.uscFotoPerfiles.Size = New System.Drawing.Size(1249, 463)
            Me.uscFotoPerfiles.TabIndex = 0
            '
            'tbpReniec
            '
            Me.tbpReniec.AutoScroll = True
            Me.tbpReniec.Controls.Add(Me.UscValidacionReniecV21)
            Me.tbpReniec.Location = New System.Drawing.Point(4, 22)
            Me.tbpReniec.Name = "tbpReniec"
            Me.tbpReniec.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpReniec.Size = New System.Drawing.Size(1255, 469)
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
            Me.UscValidacionReniecV21.Size = New System.Drawing.Size(1249, 463)
            Me.UscValidacionReniecV21.TabIndex = 0
            Me.UscValidacionReniecV21.TipoValidacion = -1
            '
            'tbpAlias
            '
            Me.tbpAlias.Controls.Add(Me.UscBandas21)
            Me.tbpAlias.Controls.Add(Me.UscAlias21)
            Me.tbpAlias.Location = New System.Drawing.Point(4, 22)
            Me.tbpAlias.Name = "tbpAlias"
            Me.tbpAlias.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpAlias.Size = New System.Drawing.Size(1255, 469)
            Me.tbpAlias.TabIndex = 1
            Me.tbpAlias.Text = "Alias y Bandas"
            Me.tbpAlias.UseVisualStyleBackColor = True
            '
            'UscBandas21
            '
            Me.UscBandas21._VisibleEliminar = False
            Me.UscBandas21._VisibleGrabar = False
            Me.UscBandas21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscBandas21.IngresoID = -1
            Me.UscBandas21.InternoID = -1
            Me.UscBandas21.Location = New System.Drawing.Point(496, 3)
            Me.UscBandas21.Name = "UscBandas21"
            Me.UscBandas21.Size = New System.Drawing.Size(756, 463)
            Me.UscBandas21.TabIndex = 1
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
            Me.UscAlias21.Size = New System.Drawing.Size(493, 463)
            Me.UscAlias21.TabIndex = 0
            Me.UscAlias21.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpOrgCriminal
            '
            Me.tbpOrgCriminal.Controls.Add(Me.UscGrillaBandasV21)
            Me.tbpOrgCriminal.Location = New System.Drawing.Point(4, 22)
            Me.tbpOrgCriminal.Name = "tbpOrgCriminal"
            Me.tbpOrgCriminal.Size = New System.Drawing.Size(1255, 469)
            Me.tbpOrgCriminal.TabIndex = 5
            Me.tbpOrgCriminal.Text = "Organización criminal"
            Me.tbpOrgCriminal.UseVisualStyleBackColor = True
            '
            'UscGrillaBandasV21
            '
            Me.UscGrillaBandasV21._Codigo = -1
            Me.UscGrillaBandasV21._InternoID = -1
            Me.UscGrillaBandasV21._InternoIngresoID = -1
            Me.UscGrillaBandasV21._PenalID = -1
            Me.UscGrillaBandasV21._RegionID = -1
            Me.UscGrillaBandasV21._VisibleEliminar = False
            Me.UscGrillaBandasV21._VisibleGrabar = False
            Me.UscGrillaBandasV21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscGrillaBandasV21.Location = New System.Drawing.Point(0, 0)
            Me.UscGrillaBandasV21.Name = "UscGrillaBandasV21"
            Me.UscGrillaBandasV21.Size = New System.Drawing.Size(1255, 469)
            Me.UscGrillaBandasV21.TabIndex = 1
            '
            'tbpFamiliares
            '
            Me.tbpFamiliares.Controls.Add(Me.UscFamilias1)
            Me.tbpFamiliares.Location = New System.Drawing.Point(4, 22)
            Me.tbpFamiliares.Name = "tbpFamiliares"
            Me.tbpFamiliares.Size = New System.Drawing.Size(1255, 469)
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
            Me.UscFamilias1.Size = New System.Drawing.Size(1255, 469)
            Me.UscFamilias1.TabIndex = 0
            Me.UscFamilias1.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpOdontograma
            '
            Me.tbpOdontograma.Controls.Add(Me.UscOdont)
            Me.tbpOdontograma.Location = New System.Drawing.Point(4, 22)
            Me.tbpOdontograma.Name = "tbpOdontograma"
            Me.tbpOdontograma.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpOdontograma.Size = New System.Drawing.Size(1255, 469)
            Me.tbpOdontograma.TabIndex = 8
            Me.tbpOdontograma.Text = "Odontograma"
            Me.tbpOdontograma.UseVisualStyleBackColor = True
            '
            'UscOdont
            '
            Me.UscOdont._visibleEliminar = False
            Me.UscOdont._visibleGrabar = False
            Me.UscOdont.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscOdont.Location = New System.Drawing.Point(3, 3)
            Me.UscOdont.Name = "UscOdont"
            Me.UscOdont.Size = New System.Drawing.Size(1249, 463)
            Me.UscOdont.TabIndex = 3
            '
            'tbpHuella
            '
            Me.tbpHuella.Controls.Add(Me.UscVisorDetalleHuellas1)
            Me.tbpHuella.Location = New System.Drawing.Point(4, 22)
            Me.tbpHuella.Name = "tbpHuella"
            Me.tbpHuella.Size = New System.Drawing.Size(1255, 469)
            Me.tbpHuella.TabIndex = 7
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
            Me.UscVisorDetalleHuellas1.Location = New System.Drawing.Point(0, 0)
            Me.UscVisorDetalleHuellas1.Name = "UscVisorDetalleHuellas1"
            Me.UscVisorDetalleHuellas1.Size = New System.Drawing.Size(1255, 469)
            Me.UscVisorDetalleHuellas1.TabIndex = 2
            '
            'pnlBoton
            '
            Me.pnlBoton.Controls.Add(Me.Panel3)
            Me.pnlBoton.Controls.Add(Me.pnlLeyenda)
            Me.pnlBoton.Controls.Add(Me.pnlNuevoReniec)
            Me.pnlBoton.Controls.Add(Me.pnlGrabarDatos)
            Me.pnlBoton.Controls.Add(Me.pnlEliminar)
            Me.pnlBoton.Controls.Add(Me.pnlVerLibro)
            Me.pnlBoton.Controls.Add(Me.pnlReporte)
            Me.pnlBoton.Controls.Add(Me.pnlSalir)
            Me.pnlBoton.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBoton.Location = New System.Drawing.Point(0, 558)
            Me.pnlBoton.Name = "pnlBoton"
            Me.pnlBoton.Size = New System.Drawing.Size(1277, 45)
            Me.pnlBoton.TabIndex = 2
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.UscAuditUser1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(159, 45)
            Me.Panel3.TabIndex = 0
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(159, 45)
            Me.UscAuditUser1.TabIndex = 77
            '
            'pnlLeyenda
            '
            Me.pnlLeyenda.Controls.Add(Me.lblLeyenda2)
            Me.pnlLeyenda.Controls.Add(Me.lblLeyenda1)
            Me.pnlLeyenda.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlLeyenda.Location = New System.Drawing.Point(159, 0)
            Me.pnlLeyenda.Name = "pnlLeyenda"
            Me.pnlLeyenda.Size = New System.Drawing.Size(471, 45)
            Me.pnlLeyenda.TabIndex = 1
            '
            'lblLeyenda2
            '
            Me.lblLeyenda2.AutoSize = True
            Me.lblLeyenda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLeyenda2.ForeColor = System.Drawing.Color.Red
            Me.lblLeyenda2.Location = New System.Drawing.Point(3, 24)
            Me.lblLeyenda2.Name = "lblLeyenda2"
            Me.lblLeyenda2.Size = New System.Drawing.Size(465, 13)
            Me.lblLeyenda2.TabIndex = 1
            Me.lblLeyenda2.Text = "n(2).- Delito de la Sentencia de mayor pena, esta informacion sera procesada en e" &
    "l reporte Padin."
            Me.lblLeyenda2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblLeyenda1
            '
            Me.lblLeyenda1.AutoSize = True
            Me.lblLeyenda1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLeyenda1.ForeColor = System.Drawing.Color.Red
            Me.lblLeyenda1.Location = New System.Drawing.Point(2, 4)
            Me.lblLeyenda1.Name = "lblLeyenda1"
            Me.lblLeyenda1.Size = New System.Drawing.Size(388, 13)
            Me.lblLeyenda1.TabIndex = 0
            Me.lblLeyenda1.Text = "n(1).- Delito de mayor pena, esta informacion sera procesada en el reporte Padin." &
    ""
            Me.lblLeyenda1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlNuevoReniec
            '
            Me.pnlNuevoReniec.Controls.Add(Me.btnNuevo)
            Me.pnlNuevoReniec.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlNuevoReniec.Location = New System.Drawing.Point(630, 0)
            Me.pnlNuevoReniec.Name = "pnlNuevoReniec"
            Me.pnlNuevoReniec.Size = New System.Drawing.Size(90, 45)
            Me.pnlNuevoReniec.TabIndex = 101
            '
            'btnNuevo
            '
            Me.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(2, 4)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(87, 40)
            Me.btnNuevo.TabIndex = 0
            Me.btnNuevo.Text = "&Validar"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTipMensaje.SetToolTip(Me.btnNuevo, "Click aqui para realizar una nueva validación")
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnGrabar)
            Me.pnlGrabarDatos.Controls.Add(Me.btnIngreso)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(720, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(190, 45)
            Me.pnlGrabarDatos.TabIndex = 100
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
            Me.btnGrabar.Location = New System.Drawing.Point(96, 4)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(90, 40)
            Me.btnGrabar.TabIndex = 0
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'btnIngreso
            '
            Me.btnIngreso.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnIngreso.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnIngreso.Location = New System.Drawing.Point(4, 4)
            Me.btnIngreso.Name = "btnIngreso"
            Me.btnIngreso.Size = New System.Drawing.Size(91, 40)
            Me.btnIngreso.TabIndex = 0
            Me.btnIngreso.Text = "Nuevo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Ingreso"
            Me.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTipMensaje.SetToolTip(Me.btnIngreso, "Click aqui para realizar una nueva validación")
            Me.btnIngreso.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(910, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(92, 45)
            Me.pnlEliminar.TabIndex = 99
            '
            'btnEliminar
            '
            Me.btnEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
            Me.btnEliminar.Location = New System.Drawing.Point(1, 4)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(89, 40)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlVerLibro
            '
            Me.pnlVerLibro.Controls.Add(Me.btnVerLibros)
            Me.pnlVerLibro.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlVerLibro.Location = New System.Drawing.Point(1002, 0)
            Me.pnlVerLibro.Name = "pnlVerLibro"
            Me.pnlVerLibro.Size = New System.Drawing.Size(100, 45)
            Me.pnlVerLibro.TabIndex = 96
            '
            'btnVerLibros
            '
            Me.btnVerLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVerLibros.Image = Global.SIPPOPE.My.Resources.Resources.Libro
            Me.btnVerLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVerLibros.Location = New System.Drawing.Point(4, 4)
            Me.btnVerLibros.Name = "btnVerLibros"
            Me.btnVerLibros.Size = New System.Drawing.Size(95, 40)
            Me.btnVerLibros.TabIndex = 68
            Me.btnVerLibros.Text = "&Ver Libros"
            Me.btnVerLibros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnVerLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnVerLibros.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnFicha)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlReporte.Location = New System.Drawing.Point(1102, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(90, 45)
            Me.pnlReporte.TabIndex = 94
            '
            'btnFicha
            '
            Me.btnFicha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFicha.Image = CType(resources.GetObject("btnFicha.Image"), System.Drawing.Image)
            Me.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.Location = New System.Drawing.Point(0, 4)
            Me.btnFicha.Name = "btnFicha"
            Me.btnFicha.Size = New System.Drawing.Size(90, 40)
            Me.btnFicha.TabIndex = 0
            Me.btnFicha.Text = "&Reportes"
            Me.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnFicha.UseVisualStyleBackColor = True
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(1192, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(85, 45)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(2, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tbpInterno)
            Me.TabControl1.Controls.Add(Me.tbpResoluciones)
            Me.TabControl1.Controls.Add(Me.tbpClasificacion)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 31)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1277, 527)
            Me.TabControl1.TabIndex = 0
            '
            'tbpResoluciones
            '
            Me.tbpResoluciones.Controls.Add(Me.TabControl3)
            Me.tbpResoluciones.Location = New System.Drawing.Point(4, 22)
            Me.tbpResoluciones.Name = "tbpResoluciones"
            Me.tbpResoluciones.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpResoluciones.Size = New System.Drawing.Size(1269, 501)
            Me.tbpResoluciones.TabIndex = 3
            Me.tbpResoluciones.Text = "Documentos judiciales y Movimientos"
            Me.tbpResoluciones.UseVisualStyleBackColor = True
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
            Me.TabControl3.Size = New System.Drawing.Size(1263, 495)
            Me.TabControl3.TabIndex = 13
            '
            'tbpListaExpedientes
            '
            Me.tbpListaExpedientes.Controls.Add(Me.btnDelitosHistoricos)
            Me.tbpListaExpedientes.Controls.Add(Me.UscMandatoDetencion)
            Me.tbpListaExpedientes.Location = New System.Drawing.Point(4, 22)
            Me.tbpListaExpedientes.Name = "tbpListaExpedientes"
            Me.tbpListaExpedientes.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpListaExpedientes.Size = New System.Drawing.Size(1255, 469)
            Me.tbpListaExpedientes.TabIndex = 0
            Me.tbpListaExpedientes.Text = "Lista de procesos"
            Me.tbpListaExpedientes.UseVisualStyleBackColor = True
            '
            'btnDelitosHistoricos
            '
            Me.btnDelitosHistoricos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDelitosHistoricos.Location = New System.Drawing.Point(1070, 2)
            Me.btnDelitosHistoricos.Name = "btnDelitosHistoricos"
            Me.btnDelitosHistoricos.Size = New System.Drawing.Size(181, 20)
            Me.btnDelitosHistoricos.TabIndex = 3
            Me.btnDelitosHistoricos.Text = "Historial de Selección DMP y SMP"
            Me.btnDelitosHistoricos.UseVisualStyleBackColor = True
            '
            'UscMandatoDetencion
            '
            Me.UscMandatoDetencion._FormEscritura = False
            Me.UscMandatoDetencion._ObjEntAgr = Nothing
            Me.UscMandatoDetencion._ObjEntAgrCol = Nothing
            Me.UscMandatoDetencion._objEntCol = Nothing
            Me.UscMandatoDetencion._ObjEntDel = Nothing
            Me.UscMandatoDetencion._ObjEntExp = Nothing
            Me.UscMandatoDetencion._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscMandatoDetencion.AutoScroll = True
            Me.UscMandatoDetencion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMandatoDetencion.IngresoID = -1
            Me.UscMandatoDetencion.InternoEstado = -1
            Me.UscMandatoDetencion.InternoID = -1
            Me.UscMandatoDetencion.Location = New System.Drawing.Point(3, 3)
            Me.UscMandatoDetencion.Name = "UscMandatoDetencion"
            Me.UscMandatoDetencion.PenalID = -1
            Me.UscMandatoDetencion.RegionID = -1
            Me.UscMandatoDetencion.Size = New System.Drawing.Size(1249, 463)
            Me.UscMandatoDetencion.TabIndex = 0
            '
            'tbpDocumentos
            '
            Me.tbpDocumentos.Controls.Add(Me.UscResolucionesMain1)
            Me.tbpDocumentos.Location = New System.Drawing.Point(4, 22)
            Me.tbpDocumentos.Name = "tbpDocumentos"
            Me.tbpDocumentos.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpDocumentos.Size = New System.Drawing.Size(1255, 469)
            Me.tbpDocumentos.TabIndex = 1
            Me.tbpDocumentos.Text = "Documentos judiciales y Resoluciones"
            Me.tbpDocumentos.UseVisualStyleBackColor = True
            '
            'UscResolucionesMain1
            '
            Me.UscResolucionesMain1._Codigo = 0
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
            Me.UscResolucionesMain1.Size = New System.Drawing.Size(1249, 463)
            Me.UscResolucionesMain1.TabIndex = 12
            '
            'tbpMovimientos
            '
            Me.tbpMovimientos.Controls.Add(Me.tcMovimientos)
            Me.tbpMovimientos.Location = New System.Drawing.Point(4, 22)
            Me.tbpMovimientos.Name = "tbpMovimientos"
            Me.tbpMovimientos.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpMovimientos.Size = New System.Drawing.Size(1255, 469)
            Me.tbpMovimientos.TabIndex = 2
            Me.tbpMovimientos.Text = "Movimiento de Ingreso/Egreso"
            Me.tbpMovimientos.UseVisualStyleBackColor = True
            '
            'tcMovimientos
            '
            Me.tcMovimientos.Controls.Add(Me.tbMovInterno)
            Me.tcMovimientos.Controls.Add(Me.tbConstanciaReclu)
            Me.tcMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcMovimientos.Location = New System.Drawing.Point(3, 3)
            Me.tcMovimientos.Name = "tcMovimientos"
            Me.tcMovimientos.SelectedIndex = 0
            Me.tcMovimientos.Size = New System.Drawing.Size(1249, 463)
            Me.tcMovimientos.TabIndex = 1
            '
            'tbMovInterno
            '
            Me.tbMovInterno.Controls.Add(Me.UscMovimiento1)
            Me.tbMovInterno.Location = New System.Drawing.Point(4, 22)
            Me.tbMovInterno.Name = "tbMovInterno"
            Me.tbMovInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tbMovInterno.Size = New System.Drawing.Size(1241, 437)
            Me.tbMovInterno.TabIndex = 0
            Me.tbMovInterno.Text = "Movimientos del Interno"
            Me.tbMovInterno.UseVisualStyleBackColor = True
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
            Me.UscMovimiento1.Location = New System.Drawing.Point(3, 3)
            Me.UscMovimiento1.Name = "UscMovimiento1"
            Me.UscMovimiento1.Size = New System.Drawing.Size(1235, 431)
            Me.UscMovimiento1.TabIndex = 0
            '
            'tbConstanciaReclu
            '
            Me.tbConstanciaReclu.Controls.Add(Me.UscInternoDetalle1)
            Me.tbConstanciaReclu.Location = New System.Drawing.Point(4, 22)
            Me.tbConstanciaReclu.Name = "tbConstanciaReclu"
            Me.tbConstanciaReclu.Padding = New System.Windows.Forms.Padding(3)
            Me.tbConstanciaReclu.Size = New System.Drawing.Size(1241, 437)
            Me.tbConstanciaReclu.TabIndex = 1
            Me.tbConstanciaReclu.Text = "Constancia de Reclusion"
            Me.tbConstanciaReclu.UseVisualStyleBackColor = True
            '
            'UscInternoDetalle1
            '
            Me.UscInternoDetalle1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscInternoDetalle1.Location = New System.Drawing.Point(3, 3)
            Me.UscInternoDetalle1.Name = "UscInternoDetalle1"
            Me.UscInternoDetalle1.Size = New System.Drawing.Size(1235, 431)
            Me.UscInternoDetalle1.TabIndex = 0
            '
            'tbpClasificacion
            '
            Me.tbpClasificacion.Controls.Add(Me.tcClasificacion)
            Me.tbpClasificacion.Location = New System.Drawing.Point(4, 22)
            Me.tbpClasificacion.Name = "tbpClasificacion"
            Me.tbpClasificacion.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpClasificacion.Size = New System.Drawing.Size(1269, 501)
            Me.tbpClasificacion.TabIndex = 4
            Me.tbpClasificacion.Text = "Clasificacion"
            Me.tbpClasificacion.UseVisualStyleBackColor = True
            '
            'tcClasificacion
            '
            Me.tcClasificacion.Controls.Add(Me.tpRegimen)
            Me.tcClasificacion.Controls.Add(Me.tpEtapa)
            Me.tcClasificacion.Controls.Add(Me.tpPabellon)
            Me.tcClasificacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcClasificacion.Location = New System.Drawing.Point(3, 3)
            Me.tcClasificacion.Name = "tcClasificacion"
            Me.tcClasificacion.SelectedIndex = 0
            Me.tcClasificacion.Size = New System.Drawing.Size(1263, 495)
            Me.tcClasificacion.TabIndex = 1
            '
            'tpRegimen
            '
            Me.tpRegimen.Controls.Add(Me.UscFichaClasificacion1)
            Me.tpRegimen.Location = New System.Drawing.Point(4, 22)
            Me.tpRegimen.Name = "tpRegimen"
            Me.tpRegimen.Padding = New System.Windows.Forms.Padding(3)
            Me.tpRegimen.Size = New System.Drawing.Size(1255, 469)
            Me.tpRegimen.TabIndex = 0
            Me.tpRegimen.Text = "Clasificacion de Regimen"
            Me.tpRegimen.UseVisualStyleBackColor = True
            '
            'UscFichaClasificacion1
            '
            Me.UscFichaClasificacion1._IDIngreso = -1
            Me.UscFichaClasificacion1._IDIngresoInpe = -1
            Me.UscFichaClasificacion1._IDInterno = -1
            Me.UscFichaClasificacion1._IDPenal = CType(-1, Short)
            Me.UscFichaClasificacion1._IDRegion = CType(-1, Short)
            Me.UscFichaClasificacion1._InternoApeNom = ""
            Me.UscFichaClasificacion1._InternoEstado = CType(-1, Short)
            Me.UscFichaClasificacion1._uscEliminar = False
            Me.UscFichaClasificacion1._uscEscritura = False
            Me.UscFichaClasificacion1._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacion.enmFichaTab.enmRegimen
            Me.UscFichaClasificacion1._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscFichaClasificacion1._uscReporte = False
            Me.UscFichaClasificacion1._uscVisibleVariableNoPrevista = False
            Me.UscFichaClasificacion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFichaClasificacion1.Location = New System.Drawing.Point(3, 3)
            Me.UscFichaClasificacion1.Name = "UscFichaClasificacion1"
            Me.UscFichaClasificacion1.Size = New System.Drawing.Size(1249, 463)
            Me.UscFichaClasificacion1.TabIndex = 0
            '
            'tpEtapa
            '
            Me.tpEtapa.Controls.Add(Me.UscFichaClasificacion2)
            Me.tpEtapa.Location = New System.Drawing.Point(4, 22)
            Me.tpEtapa.Name = "tpEtapa"
            Me.tpEtapa.Padding = New System.Windows.Forms.Padding(3)
            Me.tpEtapa.Size = New System.Drawing.Size(1255, 469)
            Me.tpEtapa.TabIndex = 1
            Me.tpEtapa.Text = "Clasificacion de Etapa"
            Me.tpEtapa.UseVisualStyleBackColor = True
            '
            'UscFichaClasificacion2
            '
            Me.UscFichaClasificacion2._IDIngreso = -1
            Me.UscFichaClasificacion2._IDIngresoInpe = -1
            Me.UscFichaClasificacion2._IDInterno = -1
            Me.UscFichaClasificacion2._IDPenal = CType(-1, Short)
            Me.UscFichaClasificacion2._IDRegion = CType(-1, Short)
            Me.UscFichaClasificacion2._InternoApeNom = ""
            Me.UscFichaClasificacion2._InternoEstado = CType(-1, Short)
            Me.UscFichaClasificacion2._uscEliminar = False
            Me.UscFichaClasificacion2._uscEscritura = False
            Me.UscFichaClasificacion2._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacion.enmFichaTab.enmRegimen
            Me.UscFichaClasificacion2._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscFichaClasificacion2._uscReporte = False
            Me.UscFichaClasificacion2._uscVisibleVariableNoPrevista = False
            Me.UscFichaClasificacion2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFichaClasificacion2.Location = New System.Drawing.Point(3, 3)
            Me.UscFichaClasificacion2.Name = "UscFichaClasificacion2"
            Me.UscFichaClasificacion2.Size = New System.Drawing.Size(1249, 463)
            Me.UscFichaClasificacion2.TabIndex = 1
            '
            'tpPabellon
            '
            Me.tpPabellon.Controls.Add(Me.UscPabellon1)
            Me.tpPabellon.Location = New System.Drawing.Point(4, 22)
            Me.tpPabellon.Name = "tpPabellon"
            Me.tpPabellon.Size = New System.Drawing.Size(1255, 469)
            Me.tpPabellon.TabIndex = 2
            Me.tpPabellon.Text = "Ubicacion de Pabellon"
            Me.tpPabellon.UseVisualStyleBackColor = True
            '
            'UscPabellon1
            '
            Me.UscPabellon1._IDIngreso = -1
            Me.UscPabellon1._IDIngresoInpe = -1
            Me.UscPabellon1._IDInterno = -1
            Me.UscPabellon1._IDPenal = CType(-1, Short)
            Me.UscPabellon1._IDRegion = CType(-1, Short)
            Me.UscPabellon1._InternoApeNom = ""
            Me.UscPabellon1._InternoEstado = CType(-1, Short)
            Me.UscPabellon1._uscEliminar = False
            Me.UscPabellon1._uscEscritura = False
            Me.UscPabellon1._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscPabellon1._uscReporte = False
            Me.UscPabellon1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscPabellon1.IDPabellon = -1
            Me.UscPabellon1.Location = New System.Drawing.Point(0, 0)
            Me.UscPabellon1.Name = "UscPabellon1"
            Me.UscPabellon1.Size = New System.Drawing.Size(1255, 469)
            Me.UscPabellon1.TabIndex = 0
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
            Me.cbbNroIngresos.Size = New System.Drawing.Size(108, 21)
            Me.cbbNroIngresos.TabIndex = 1
            '
            'txtEstado
            '
            Me.txtEstado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstado._BloquearPaste = False
            Me.txtEstado._SeleccionarTodo = False
            Me.txtEstado.BackColor = System.Drawing.Color.White
            Me.txtEstado.Location = New System.Drawing.Point(54, 3)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(71, 20)
            Me.txtEstado.TabIndex = 5
            Me.txtEstado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtEstado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label36
            '
            Me.Label36.AutoSize = True
            Me.Label36.Location = New System.Drawing.Point(6, 7)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(46, 13)
            Me.Label36.TabIndex = 4
            Me.Label36.Text = "Estado :"
            '
            'txtCodigo
            '
            Me.txtCodigo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodigo._BloquearPaste = False
            Me.txtCodigo._SeleccionarTodo = False
            Me.txtCodigo.BackColor = System.Drawing.Color.White
            Me.txtCodigo.Location = New System.Drawing.Point(54, 3)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.ReadOnly = True
            Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
            Me.txtCodigo.TabIndex = 1
            Me.txtCodigo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodigo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Location = New System.Drawing.Point(8, 6)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(46, 13)
            Me.Label35.TabIndex = 0
            Me.Label35.Text = "Codigo :"
            '
            'txtInterno
            '
            Me.txtInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtInterno._BloquearPaste = False
            Me.txtInterno._SeleccionarTodo = False
            Me.txtInterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtInterno.BackColor = System.Drawing.Color.White
            Me.txtInterno.Location = New System.Drawing.Point(52, 3)
            Me.txtInterno.Name = "txtInterno"
            Me.txtInterno.ReadOnly = True
            Me.txtInterno.Size = New System.Drawing.Size(335, 20)
            Me.txtInterno.TabIndex = 3
            Me.txtInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label30
            '
            Me.Label30.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label30.Location = New System.Drawing.Point(0, 0)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(46, 27)
            Me.Label30.TabIndex = 2
            Me.Label30.Text = "Interno :"
            Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtRegionPenal
            '
            Me.txtRegionPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRegionPenal._BloquearPaste = False
            Me.txtRegionPenal._SeleccionarTodo = False
            Me.txtRegionPenal.BackColor = System.Drawing.Color.White
            Me.txtRegionPenal.Location = New System.Drawing.Point(88, 3)
            Me.txtRegionPenal.Name = "txtRegionPenal"
            Me.txtRegionPenal.ReadOnly = True
            Me.txtRegionPenal.Size = New System.Drawing.Size(220, 20)
            Me.txtRegionPenal.TabIndex = 1
            Me.txtRegionPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegionPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(6, 6)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(79, 13)
            Me.Label28.TabIndex = 0
            Me.Label28.Text = "Region/Penal :"
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
            Me.pnlRegionPenal.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlRegionPenal.Location = New System.Drawing.Point(667, 0)
            Me.pnlRegionPenal.Name = "pnlRegionPenal"
            Me.pnlRegionPenal.Size = New System.Drawing.Size(311, 27)
            Me.pnlRegionPenal.TabIndex = 6
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.Panel9)
            Me.Panel1.Controls.Add(Me.Panel10)
            Me.Panel1.Controls.Add(Me.Panel8)
            Me.Panel1.Controls.Add(Me.pnlRegionPenal)
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Controls.Add(Me.pnlInactivar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1277, 31)
            Me.Panel1.TabIndex = 0
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.txtInterno)
            Me.Panel9.Controls.Add(Me.Label30)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel9.Location = New System.Drawing.Point(143, 0)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(390, 27)
            Me.Panel9.TabIndex = 11
            '
            'Panel10
            '
            Me.Panel10.Controls.Add(Me.Label35)
            Me.Panel10.Controls.Add(Me.txtCodigo)
            Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel10.Location = New System.Drawing.Point(0, 0)
            Me.Panel10.Name = "Panel10"
            Me.Panel10.Size = New System.Drawing.Size(143, 27)
            Me.Panel10.TabIndex = 12
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.txtEstado)
            Me.Panel8.Controls.Add(Me.Label36)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel8.Location = New System.Drawing.Point(533, 0)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(134, 27)
            Me.Panel8.TabIndex = 10
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.pnlAddIngreso)
            Me.Panel5.Controls.Add(Me.cbbNroIngresos)
            Me.Panel5.Controls.Add(Me.Label37)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel5.Location = New System.Drawing.Point(978, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(199, 27)
            Me.Panel5.TabIndex = 7
            '
            'pnlAddIngreso
            '
            Me.pnlAddIngreso.Controls.Add(Me.pnlIngresoAdd)
            Me.pnlAddIngreso.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAddIngreso.Location = New System.Drawing.Point(173, 0)
            Me.pnlAddIngreso.Name = "pnlAddIngreso"
            Me.pnlAddIngreso.Size = New System.Drawing.Size(26, 27)
            Me.pnlAddIngreso.TabIndex = 2
            '
            'pnlIngresoAdd
            '
            Me.pnlIngresoAdd.Controls.Add(Me.btnAddIngreso)
            Me.pnlIngresoAdd.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlIngresoAdd.Location = New System.Drawing.Point(0, 0)
            Me.pnlIngresoAdd.Name = "pnlIngresoAdd"
            Me.pnlIngresoAdd.Size = New System.Drawing.Size(25, 27)
            Me.pnlIngresoAdd.TabIndex = 0
            '
            'pnlInactivar
            '
            Me.pnlInactivar.Controls.Add(Me.btnInactivar)
            Me.pnlInactivar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlInactivar.Location = New System.Drawing.Point(1177, 0)
            Me.pnlInactivar.Name = "pnlInactivar"
            Me.pnlInactivar.Size = New System.Drawing.Size(96, 27)
            Me.pnlInactivar.TabIndex = 9
            '
            'btnInactivar
            '
            Me.btnInactivar.BackColor = System.Drawing.Color.Maroon
            Me.btnInactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnInactivar.ForeColor = System.Drawing.SystemColors.ButtonFace
            Me.btnInactivar.Location = New System.Drawing.Point(4, 1)
            Me.btnInactivar.Name = "btnInactivar"
            Me.btnInactivar.Size = New System.Drawing.Size(86, 25)
            Me.btnInactivar.TabIndex = 8
            Me.btnInactivar.Text = "Inactivar"
            Me.btnInactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.btnInactivar.UseVisualStyleBackColor = False
            '
            'frmMant_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1277, 603)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.pnlBoton)
            Me.Name = "frmMant_v2"
            Me.Text = "Identificacion Penal - Detalle"
            Me.ToolTipMensaje.SetToolTip(Me, "Activar estado del Interno")
            Me.tbpInterno.ResumeLayout(False)
            Me.tbcDatosInternos.ResumeLayout(False)
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
            Me.tbpAlias.ResumeLayout(False)
            Me.tbpOrgCriminal.ResumeLayout(False)
            Me.tbpFamiliares.ResumeLayout(False)
            Me.tbpOdontograma.ResumeLayout(False)
            Me.tbpHuella.ResumeLayout(False)
            Me.pnlBoton.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.pnlLeyenda.ResumeLayout(False)
            Me.pnlLeyenda.PerformLayout()
            Me.pnlNuevoReniec.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlVerLibro.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tbpResoluciones.ResumeLayout(False)
            Me.TabControl3.ResumeLayout(False)
            Me.tbpListaExpedientes.ResumeLayout(False)
            Me.tbpDocumentos.ResumeLayout(False)
            Me.tbpMovimientos.ResumeLayout(False)
            Me.tcMovimientos.ResumeLayout(False)
            Me.tbMovInterno.ResumeLayout(False)
            Me.tbConstanciaReclu.ResumeLayout(False)
            Me.tbpClasificacion.ResumeLayout(False)
            Me.tcClasificacion.ResumeLayout(False)
            Me.tpRegimen.ResumeLayout(False)
            Me.tpEtapa.ResumeLayout(False)
            Me.tpPabellon.ResumeLayout(False)
            Me.pnlRegionPenal.ResumeLayout(False)
            Me.pnlRegionPenal.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.Panel9.PerformLayout()
            Me.Panel10.ResumeLayout(False)
            Me.Panel10.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.Panel8.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlAddIngreso.ResumeLayout(False)
            Me.pnlIngresoAdd.ResumeLayout(False)
            Me.pnlInactivar.ResumeLayout(False)
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tbpInterno As System.Windows.Forms.TabPage
        Friend WithEvents tbcDatosInternos As System.Windows.Forms.TabControl
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
        Friend WithEvents tbpAlias As System.Windows.Forms.TabPage
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
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents pnlBoton As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
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
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents tbpNombresAsoc As System.Windows.Forms.TabPage
        Friend WithEvents chkNoindica As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents txtPabellon As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents chk_Obs_DNI As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents txtObs_dni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents tbpOrgCriminal As System.Windows.Forms.TabPage
        Friend WithEvents tbpResoluciones As System.Windows.Forms.TabPage
        Friend WithEvents UscResolucionesMain1 As APPControls.Registro.Resoluciones.uscResolucionesMain
        Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
        Friend WithEvents tbpListaExpedientes As System.Windows.Forms.TabPage
        Friend WithEvents tbpDocumentos As System.Windows.Forms.TabPage
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents cbbNroIngresos As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents UscMandatoDetencion As APPControls.Registro.Documento.uscMandatoDetencion
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents tbpReniec As System.Windows.Forms.TabPage
        Friend WithEvents ToolTipMensaje As System.Windows.Forms.ToolTip
        Friend WithEvents btnFicha As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents UscGrillaNombresAsociadosV21 As APPControls.Registro.uscGrillaNombresAsociadosV2
        Friend WithEvents UscGrillaBandasV21 As APPControls.Registro.Siscrico.uscGrillaOrgCriminalV2
        Friend WithEvents tbpMovimientos As System.Windows.Forms.TabPage
        Friend WithEvents UscMovimiento1 As APPControls.Registro.uscMovimiento
        Friend WithEvents UscValidacionReniecV21 As APPControls.Registro.Reniec.uscValidacionReniecV2
        Friend WithEvents btnAddIngreso As System.Windows.Forms.Button
        Friend WithEvents uscFotoPerfiles As APPControls.Registro.Captura.uscFotografia3
        Friend WithEvents pnlRegionPenal As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
        Friend WithEvents chk_Homonimia As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApellidosNombresreniec As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents UscAlias21 As APPControls.Registro.Identificacion.v5.uscAlias2
        Friend WithEvents UscBandas21 As APPControls.uscBandas2
        Friend WithEvents UscFamilias1 As APPControls.Registro.Identificacion.v5.uscFamilia
        Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
        Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
        'Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
        Friend WithEvents tbpHuella As System.Windows.Forms.TabPage
        Friend WithEvents UscVisorDetalleHuellas1 As APPControls.Registro.Huellas.uscVisorDetalleHuellas
        Friend WithEvents pnlInactivar As Panel
        Friend WithEvents btnInactivar As Button
        Friend WithEvents tbpOdontograma As TabPage
        Friend WithEvents UscOdont As APPControls.Registro.Odontograma.uscOdontogramaBuscar
        Friend WithEvents txtDecadactDer As TextBox
        Friend WithEvents txtDecadactIzq As TextBox
        Friend WithEvents Label50 As Label
        Friend WithEvents Label43 As Label
        Friend WithEvents Label38 As Label
        Friend WithEvents tbpDatosComplement As TabPage
        Friend WithEvents Panel6 As Panel
        Friend WithEvents GroupBox9 As GroupBox
        Friend WithEvents UscDomicilio1 As APPControls.Registro.Identificacion.uscDomicilio
        Friend WithEvents GroupBox7 As GroupBox
        Friend WithEvents UscGradosAcademicos1 As APPControls.Registro.Identificacion.uscGradosAcademicos
        Friend WithEvents Panel4 As Panel
        Friend WithEvents cbbCentroReclu As ComboBox
        Friend WithEvents Label27 As Label
        Friend WithEvents cbbCodFuerArmada As ComboBox
        Friend WithEvents cbbCodigoRango As ComboBox
        Friend WithEvents Label21 As Label
        Friend WithEvents txtNomClaveInt As TextBox
        Friend WithEvents Label49 As Label
        Friend WithEvents GroupBox5 As GroupBox
        Friend WithEvents UscIdiomaInterno1 As APPControls.Registro.Identificacion.uscIdiomaInterno
        Friend WithEvents Label45 As Label
        Friend WithEvents Label48 As Label
        Friend WithEvents cbbIdiomaPrincipal As APPControls.uscComboParametrica
        Friend WithEvents Label47 As Label
        Friend WithEvents Label44 As Label
        Friend WithEvents Label46 As Label
        Friend WithEvents cbbGenero As APPControls.uscComboParametrica
        Friend WithEvents txtCentroTrabajo As TextBox
        Friend WithEvents cbbReligion As APPControls.uscComboParametrica
        Friend WithEvents pnlVerLibro As Panel
        Friend WithEvents btnVerLibros As Button
        Friend WithEvents Panel3 As Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents pnlLeyenda As Panel
        Friend WithEvents lblLeyenda2 As Label
        Friend WithEvents lblLeyenda1 As Label
        Friend WithEvents pnlNuevoReniec As Panel
        Friend WithEvents btnNuevo As Button
        Friend WithEvents pnlGrabarDatos As Panel
        Friend WithEvents btnGrabar As Button
        Friend WithEvents btnIngreso As Button
        Friend WithEvents pnlEliminar As Panel
        Friend WithEvents btnEliminar As Button
        Friend WithEvents tbpClasificacion As TabPage
        Friend WithEvents UscFichaClasificacion1 As APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacion
        Friend WithEvents tcClasificacion As TabControl
        Friend WithEvents tpRegimen As TabPage
        Friend WithEvents tpEtapa As TabPage
        Friend WithEvents tpPabellon As TabPage
        Friend WithEvents UscFichaClasificacion2 As APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacion
        Friend WithEvents UscPabellon1 As APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscPabellon
        Friend WithEvents Panel9 As Panel
        Friend WithEvents Panel10 As Panel
        Friend WithEvents Panel8 As Panel
        Friend WithEvents btnDelitosHistoricos As Button
        Friend WithEvents Panel2 As Panel
        Friend WithEvents UscEtniaLenguaMaterna_v21 As APPControls.Registro.Identificacion.uscEtniaLenguaMaterna_v2
        Friend WithEvents tcMovimientos As TabControl
        Friend WithEvents tbMovInterno As TabPage
        Friend WithEvents tbConstanciaReclu As TabPage
        Friend WithEvents UscInternoDetalle1 As APPControls.Registro.ConsultaReclusion.uscInternoDetalle
    End Class
End Namespace