Namespace Tratamiento.Asistencia.Clasificacion.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMantClasifPenalLM
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantClasifPenalLM))
            Me.tbpInterno = New System.Windows.Forms.TabPage()
            Me.tcDatosInternos = New System.Windows.Forms.TabControl()
            Me.tbpDatos = New System.Windows.Forms.TabPage()
            Me.pnlDatosPer = New System.Windows.Forms.Panel()
            Me.pnlDatosAca = New System.Windows.Forms.Panel()
            Me.pnlUbigeo = New System.Windows.Forms.Panel()
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
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.chk_Obs_DNI = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.chkNoindica = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.tbpFoto = New System.Windows.Forms.TabPage()
            Me.uscFotoPerfiles = New APPControls.Registro.Captura.uscFotografia_LM()
            Me.tbpBandas = New System.Windows.Forms.TabPage()
            Me.UscOrganizacionCriminal = New APPControls.Registro.Siscrico.uscGrillaOrgCriminal_LM()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.pnlPiePagina = New System.Windows.Forms.Panel()
            Me.pnlAuditoria = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tbpMandDet = New System.Windows.Forms.TabPage()
            Me.UscResolucionesMain1 = New APPControls.Registro.Resoluciones.uscResolucionesMain_LM()
            Me.tbpClasificacion = New System.Windows.Forms.TabPage()
            Me.tcClasificacion = New System.Windows.Forms.TabControl()
            Me.tpRegimen = New System.Windows.Forms.TabPage()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.UscFichaClasificacion1 = New APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen()
            Me.tpEtapa = New System.Windows.Forms.TabPage()
            Me.UscFichaClasificacionEtapaLM1 = New APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionEtapaLM()
            Me.tabClasifRegresion = New System.Windows.Forms.TabPage()
            Me.UscFichaPorRegresion1 = New APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaPorRegresion()
            Me.tabAnexo05 = New System.Windows.Forms.TabPage()
            Me.UscFichaClasifTraslado1 = New APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasifTraslado()
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
            Me.btnsiguiente = New System.Windows.Forms.Button()
            Me.btnanterior = New System.Windows.Forms.Button()
            Me.pnlRegionPenal = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.pnlAddIngreso = New System.Windows.Forms.Panel()
            Me.pnlIngresoAdd = New System.Windows.Forms.Panel()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
            Me.UscOdotoNew1 = New APPControls.uscOdotoNew()
            Me.tbpInterno.SuspendLayout()
            Me.tcDatosInternos.SuspendLayout()
            Me.tbpDatos.SuspendLayout()
            Me.pnlDatosPer.SuspendLayout()
            Me.pnlUbigeo.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.tbpFoto.SuspendLayout()
            Me.tbpBandas.SuspendLayout()
            Me.pnlPiePagina.SuspendLayout()
            Me.pnlAuditoria.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tbpMandDet.SuspendLayout()
            Me.tbpClasificacion.SuspendLayout()
            Me.tcClasificacion.SuspendLayout()
            Me.tpRegimen.SuspendLayout()
            Me.tpEtapa.SuspendLayout()
            Me.tabClasifRegresion.SuspendLayout()
            Me.tabAnexo05.SuspendLayout()
            Me.pnlRegionPenal.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pnlAddIngreso.SuspendLayout()
            Me.pnlIngresoAdd.SuspendLayout()
            Me.SuspendLayout()
            '
            'tbpInterno
            '
            Me.tbpInterno.Controls.Add(Me.tcDatosInternos)
            Me.tbpInterno.Location = New System.Drawing.Point(4, 22)
            Me.tbpInterno.Name = "tbpInterno"
            Me.tbpInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpInterno.Size = New System.Drawing.Size(1144, 495)
            Me.tbpInterno.TabIndex = 0
            Me.tbpInterno.Text = "Identificación de interno"
            Me.tbpInterno.UseVisualStyleBackColor = True
            '
            'tcDatosInternos
            '
            Me.tcDatosInternos.Controls.Add(Me.tbpDatos)
            Me.tcDatosInternos.Controls.Add(Me.tbpFoto)
            Me.tcDatosInternos.Controls.Add(Me.tbpBandas)
            Me.tcDatosInternos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcDatosInternos.ImageList = Me.ImageList1
            Me.tcDatosInternos.Location = New System.Drawing.Point(3, 3)
            Me.tcDatosInternos.Name = "tcDatosInternos"
            Me.tcDatosInternos.SelectedIndex = 0
            Me.tcDatosInternos.Size = New System.Drawing.Size(1138, 489)
            Me.tcDatosInternos.TabIndex = 0
            '
            'tbpDatos
            '
            Me.tbpDatos.Controls.Add(Me.pnlDatosPer)
            Me.tbpDatos.ImageKey = "Personal-information-32.png"
            Me.tbpDatos.Location = New System.Drawing.Point(4, 25)
            Me.tbpDatos.Name = "tbpDatos"
            Me.tbpDatos.Size = New System.Drawing.Size(1130, 460)
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
            Me.pnlDatosPer.Size = New System.Drawing.Size(1130, 460)
            Me.pnlDatosPer.TabIndex = 36
            '
            'pnlDatosAca
            '
            Me.pnlDatosAca.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDatosAca.Location = New System.Drawing.Point(564, 0)
            Me.pnlDatosAca.Name = "pnlDatosAca"
            Me.pnlDatosAca.Size = New System.Drawing.Size(566, 460)
            Me.pnlDatosAca.TabIndex = 39
            '
            'pnlUbigeo
            '
            Me.pnlUbigeo.Controls.Add(Me.GroupBox1)
            Me.pnlUbigeo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlUbigeo.Location = New System.Drawing.Point(281, 0)
            Me.pnlUbigeo.Name = "pnlUbigeo"
            Me.pnlUbigeo.Size = New System.Drawing.Size(283, 460)
            Me.pnlUbigeo.TabIndex = 37
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
            Me.GroupBox1.Size = New System.Drawing.Size(283, 135)
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
            Me.GroupBox4.Controls.Add(Me.dtpFechaNac)
            Me.GroupBox4.Controls.Add(Me.chk_Obs_DNI)
            Me.GroupBox4.Controls.Add(Me.chkNoindica)
            Me.GroupBox4.Controls.Add(Me.GroupBox6)
            Me.GroupBox4.Controls.Add(Me.Label11)
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
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(281, 460)
            Me.GroupBox4.TabIndex = 35
            Me.GroupBox4.TabStop = False
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.Location = New System.Drawing.Point(104, 51)
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
            Me.txtNumDoc.Location = New System.Drawing.Point(104, 200)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(168, 20)
            Me.txtNumDoc.TabIndex = 19
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(104, 150)
            Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(4)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 11
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'chk_Obs_DNI
            '
            Me.chk_Obs_DNI.AutoSize = True
            Me.chk_Obs_DNI.Location = New System.Drawing.Point(199, 151)
            Me.chk_Obs_DNI.Name = "chk_Obs_DNI"
            Me.chk_Obs_DNI.Size = New System.Drawing.Size(71, 17)
            Me.chk_Obs_DNI.TabIndex = 12
            Me.chk_Obs_DNI.Text = "<18 Años"
            Me.chk_Obs_DNI.UseVisualStyleBackColor = True
            '
            'chkNoindica
            '
            Me.chkNoindica.AutoSize = True
            Me.chkNoindica.Location = New System.Drawing.Point(198, 177)
            Me.chkNoindica.Name = "chkNoindica"
            Me.chkNoindica.Size = New System.Drawing.Size(72, 17)
            Me.chkNoindica.TabIndex = 17
            Me.chkNoindica.Text = "No Indica"
            Me.chkNoindica.UseVisualStyleBackColor = True
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.Label26)
            Me.GroupBox6.Controls.Add(Me.txtCodInterno)
            Me.GroupBox6.Location = New System.Drawing.Point(6, 5)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(268, 41)
            Me.GroupBox6.TabIndex = 0
            Me.GroupBox6.TabStop = False
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(4, 13)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 0
            Me.Label26.Text = "Código Interno :"
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = False
            Me.txtCodInterno.Location = New System.Drawing.Point(98, 10)
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
            Me.Label11.Location = New System.Drawing.Point(7, 254)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(75, 13)
            Me.Label11.TabIndex = 24
            Me.Label11.Text = "Nacionalidad :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(5, 54)
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
            Me.cbbNacionalidad.Location = New System.Drawing.Point(104, 249)
            Me.cbbNacionalidad.Margin = New System.Windows.Forms.Padding(4)
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
            Me.Label3.Location = New System.Drawing.Point(7, 102)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Nombres :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 127)
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
            Me.txtNom.Location = New System.Drawing.Point(104, 99)
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
            Me.Label5.Location = New System.Drawing.Point(7, 156)
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
            Me.txtApeMat.Location = New System.Drawing.Point(104, 75)
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
            Me.Label12.Location = New System.Drawing.Point(7, 178)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(60, 13)
            Me.Label12.TabIndex = 15
            Me.Label12.Text = "Tipo Doc. :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(7, 204)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(76, 13)
            Me.Label13.TabIndex = 18
            Me.Label13.Text = "Número Doc. :"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(7, 227)
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
            Me.cbbSexo.Location = New System.Drawing.Point(104, 124)
            Me.cbbSexo.Margin = New System.Windows.Forms.Padding(4)
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
            Me.cbbTipoDoc.Location = New System.Drawing.Point(104, 175)
            Me.cbbTipoDoc.Margin = New System.Windows.Forms.Padding(4)
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
            Me.cbbEstadoCivil.Location = New System.Drawing.Point(104, 224)
            Me.cbbEstadoCivil.Margin = New System.Windows.Forms.Padding(4)
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
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(5, 78)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(96, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Segundo Apellido :"
            '
            'tbpFoto
            '
            Me.tbpFoto.Controls.Add(Me.uscFotoPerfiles)
            Me.tbpFoto.Location = New System.Drawing.Point(4, 25)
            Me.tbpFoto.Name = "tbpFoto"
            Me.tbpFoto.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpFoto.Size = New System.Drawing.Size(1130, 460)
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
            Me.uscFotoPerfiles.Margin = New System.Windows.Forms.Padding(4)
            Me.uscFotoPerfiles.Name = "uscFotoPerfiles"
            Me.uscFotoPerfiles.PenalID = -1
            Me.uscFotoPerfiles.RegionID = -1
            Me.uscFotoPerfiles.Size = New System.Drawing.Size(1124, 454)
            Me.uscFotoPerfiles.TabIndex = 0
            Me.uscFotoPerfiles.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'tbpBandas
            '
            Me.tbpBandas.Controls.Add(Me.UscOrganizacionCriminal)
            Me.tbpBandas.Location = New System.Drawing.Point(4, 25)
            Me.tbpBandas.Name = "tbpBandas"
            Me.tbpBandas.Size = New System.Drawing.Size(1130, 460)
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
            Me.UscOrganizacionCriminal.Margin = New System.Windows.Forms.Padding(4)
            Me.UscOrganizacionCriminal.Name = "UscOrganizacionCriminal"
            Me.UscOrganizacionCriminal.Size = New System.Drawing.Size(1130, 460)
            Me.UscOrganizacionCriminal.TabIndex = 1
            Me.UscOrganizacionCriminal.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "Personal-information-32.png")
            Me.ImageList1.Images.SetKeyName(1, "Regimen.png")
            Me.ImageList1.Images.SetKeyName(2, "Etapa.png")
            Me.ImageList1.Images.SetKeyName(3, "traslado.png")
            Me.ImageList1.Images.SetKeyName(4, "Regresion.png")
            '
            'pnlPiePagina
            '
            Me.pnlPiePagina.BackColor = System.Drawing.Color.Gainsboro
            Me.pnlPiePagina.Controls.Add(Me.pnlAuditoria)
            Me.pnlPiePagina.Controls.Add(Me.pnlSalir)
            Me.pnlPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPiePagina.Location = New System.Drawing.Point(0, 552)
            Me.pnlPiePagina.Name = "pnlPiePagina"
            Me.pnlPiePagina.Size = New System.Drawing.Size(1152, 45)
            Me.pnlPiePagina.TabIndex = 40
            '
            'pnlAuditoria
            '
            Me.pnlAuditoria.Controls.Add(Me.UscAuditUser1)
            Me.pnlAuditoria.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlAuditoria.Location = New System.Drawing.Point(0, 0)
            Me.pnlAuditoria.Name = "pnlAuditoria"
            Me.pnlAuditoria.Size = New System.Drawing.Size(1070, 45)
            Me.pnlAuditoria.TabIndex = 95
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.BackColor = System.Drawing.SystemColors.Control
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Margin = New System.Windows.Forms.Padding(4)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(1070, 45)
            Me.UscAuditUser1.TabIndex = 0
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(1070, 0)
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
            Me.TabControl1.Controls.Add(Me.tbpClasificacion)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 31)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1152, 521)
            Me.TabControl1.TabIndex = 1
            '
            'tbpMandDet
            '
            Me.tbpMandDet.Controls.Add(Me.UscResolucionesMain1)
            Me.tbpMandDet.Location = New System.Drawing.Point(4, 22)
            Me.tbpMandDet.Name = "tbpMandDet"
            Me.tbpMandDet.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpMandDet.Size = New System.Drawing.Size(1144, 495)
            Me.tbpMandDet.TabIndex = 5
            Me.tbpMandDet.Text = "Documentos judiciales"
            Me.tbpMandDet.UseVisualStyleBackColor = True
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
            Me.UscResolucionesMain1.Margin = New System.Windows.Forms.Padding(4)
            Me.UscResolucionesMain1.Name = "UscResolucionesMain1"
            Me.UscResolucionesMain1.Size = New System.Drawing.Size(1138, 489)
            Me.UscResolucionesMain1.TabIndex = 12
            '
            'tbpClasificacion
            '
            Me.tbpClasificacion.Controls.Add(Me.tcClasificacion)
            Me.tbpClasificacion.Location = New System.Drawing.Point(4, 22)
            Me.tbpClasificacion.Name = "tbpClasificacion"
            Me.tbpClasificacion.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpClasificacion.Size = New System.Drawing.Size(1144, 495)
            Me.tbpClasificacion.TabIndex = 6
            Me.tbpClasificacion.Text = "Clasificación"
            Me.tbpClasificacion.UseVisualStyleBackColor = True
            '
            'tcClasificacion
            '
            Me.tcClasificacion.Controls.Add(Me.tpRegimen)
            Me.tcClasificacion.Controls.Add(Me.tpEtapa)
            Me.tcClasificacion.Controls.Add(Me.tabClasifRegresion)
            Me.tcClasificacion.Controls.Add(Me.tabAnexo05)
            Me.tcClasificacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcClasificacion.ImageList = Me.ImageList1
            Me.tcClasificacion.Location = New System.Drawing.Point(3, 3)
            Me.tcClasificacion.Name = "tcClasificacion"
            Me.tcClasificacion.SelectedIndex = 0
            Me.tcClasificacion.Size = New System.Drawing.Size(1138, 489)
            Me.tcClasificacion.TabIndex = 2
            '
            'tpRegimen
            '
            Me.tpRegimen.Controls.Add(Me.Label21)
            Me.tpRegimen.Controls.Add(Me.UscFichaClasificacion1)
            Me.tpRegimen.ImageKey = "Regimen.png"
            Me.tpRegimen.Location = New System.Drawing.Point(4, 25)
            Me.tpRegimen.Name = "tpRegimen"
            Me.tpRegimen.Padding = New System.Windows.Forms.Padding(3)
            Me.tpRegimen.Size = New System.Drawing.Size(1130, 460)
            Me.tpRegimen.TabIndex = 0
            Me.tpRegimen.Text = "Clasificación a RÉGIMEN"
            Me.tpRegimen.UseVisualStyleBackColor = True
            '
            'Label21
            '
            Me.Label21.Location = New System.Drawing.Point(481, 419)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(45, 13)
            Me.Label21.TabIndex = 0
            Me.Label21.Text = "Label21"
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
            Me.UscFichaClasificacion1._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen.EnmFichaTab.enmRegimen
            Me.UscFichaClasificacion1._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscFichaClasificacion1._uscReporte = False
            Me.UscFichaClasificacion1._uscVisibleVariableNoPrevista = False
            Me.UscFichaClasificacion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFichaClasificacion1.IDPabellon = -1
            Me.UscFichaClasificacion1.Location = New System.Drawing.Point(3, 3)
            Me.UscFichaClasificacion1.Margin = New System.Windows.Forms.Padding(4)
            Me.UscFichaClasificacion1.Name = "UscFichaClasificacion1"
            Me.UscFichaClasificacion1.Size = New System.Drawing.Size(1124, 454)
            Me.UscFichaClasificacion1.TabIndex = 0
            '
            'tpEtapa
            '
            Me.tpEtapa.BackColor = System.Drawing.Color.Transparent
            Me.tpEtapa.Controls.Add(Me.UscFichaClasificacionEtapaLM1)
            Me.tpEtapa.ForeColor = System.Drawing.Color.Black
            Me.tpEtapa.ImageKey = "Regresion.png"
            Me.tpEtapa.Location = New System.Drawing.Point(4, 25)
            Me.tpEtapa.Name = "tpEtapa"
            Me.tpEtapa.Padding = New System.Windows.Forms.Padding(3)
            Me.tpEtapa.Size = New System.Drawing.Size(1130, 460)
            Me.tpEtapa.TabIndex = 1
            Me.tpEtapa.Text = "Clasificación a ETAPA"
            '
            'UscFichaClasificacionEtapaLM1
            '
            Me.UscFichaClasificacionEtapaLM1._IDIngreso = -1
            Me.UscFichaClasificacionEtapaLM1._IDIngresoInpe = -1
            Me.UscFichaClasificacionEtapaLM1._IDInterno = -1
            Me.UscFichaClasificacionEtapaLM1._IDPenal = CType(-1, Short)
            Me.UscFichaClasificacionEtapaLM1._IDRegion = CType(-1, Short)
            Me.UscFichaClasificacionEtapaLM1._InternoApeNom = ""
            Me.UscFichaClasificacionEtapaLM1._InternoEstado = CType(-1, Short)
            Me.UscFichaClasificacionEtapaLM1._uscEliminar = False
            Me.UscFichaClasificacionEtapaLM1._uscEscritura = False
            Me.UscFichaClasificacionEtapaLM1._uscFichaTab = APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionEtapaLM.EnmFichaTab.enmRegimen
            Me.UscFichaClasificacionEtapaLM1._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscFichaClasificacionEtapaLM1._uscReporte = False
            Me.UscFichaClasificacionEtapaLM1._uscVisibleVariableNoPrevista = False
            Me.UscFichaClasificacionEtapaLM1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFichaClasificacionEtapaLM1.IDPabellon = -1
            Me.UscFichaClasificacionEtapaLM1.Location = New System.Drawing.Point(3, 3)
            Me.UscFichaClasificacionEtapaLM1.Margin = New System.Windows.Forms.Padding(4)
            Me.UscFichaClasificacionEtapaLM1.Name = "UscFichaClasificacionEtapaLM1"
            Me.UscFichaClasificacionEtapaLM1.Size = New System.Drawing.Size(1124, 454)
            Me.UscFichaClasificacionEtapaLM1.TabIndex = 0
            '
            'tabClasifRegresion
            '
            Me.tabClasifRegresion.BackColor = System.Drawing.Color.Transparent
            Me.tabClasifRegresion.Controls.Add(Me.UscFichaPorRegresion1)
            Me.tabClasifRegresion.ImageKey = "Etapa.png"
            Me.tabClasifRegresion.Location = New System.Drawing.Point(4, 25)
            Me.tabClasifRegresion.Name = "tabClasifRegresion"
            Me.tabClasifRegresion.Padding = New System.Windows.Forms.Padding(3)
            Me.tabClasifRegresion.Size = New System.Drawing.Size(1130, 460)
            Me.tabClasifRegresion.TabIndex = 3
            Me.tabClasifRegresion.Text = "Anexo 04: Clasificación por regresión"
            '
            'UscFichaPorRegresion1
            '
            Me.UscFichaPorRegresion1._IDIngreso = -1
            Me.UscFichaPorRegresion1._IDIngresoInpe = -1
            Me.UscFichaPorRegresion1._IDInterno = -1
            Me.UscFichaPorRegresion1._IDPenal = CType(-1, Short)
            Me.UscFichaPorRegresion1._IDRegion = CType(-1, Short)
            Me.UscFichaPorRegresion1._InternoApeNom = ""
            Me.UscFichaPorRegresion1._InternoEstado = CType(-1, Short)
            Me.UscFichaPorRegresion1._uscEliminar = False
            Me.UscFichaPorRegresion1._uscEscritura = False
            Me.UscFichaPorRegresion1._uscLectura = False
            Me.UscFichaPorRegresion1._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscFichaPorRegresion1._uscReporte = False
            Me.UscFichaPorRegresion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFichaPorRegresion1.Location = New System.Drawing.Point(3, 3)
            Me.UscFichaPorRegresion1.Margin = New System.Windows.Forms.Padding(4)
            Me.UscFichaPorRegresion1.Name = "UscFichaPorRegresion1"
            Me.UscFichaPorRegresion1.Size = New System.Drawing.Size(1124, 454)
            Me.UscFichaPorRegresion1.TabIndex = 0
            '
            'tabAnexo05
            '
            Me.tabAnexo05.Controls.Add(Me.UscFichaClasifTraslado1)
            Me.tabAnexo05.ImageKey = "traslado.png"
            Me.tabAnexo05.Location = New System.Drawing.Point(4, 25)
            Me.tabAnexo05.Name = "tabAnexo05"
            Me.tabAnexo05.Padding = New System.Windows.Forms.Padding(3)
            Me.tabAnexo05.Size = New System.Drawing.Size(1130, 460)
            Me.tabAnexo05.TabIndex = 4
            Me.tabAnexo05.Text = "Anexo 05: Ubicación por Traslado"
            Me.tabAnexo05.UseVisualStyleBackColor = True
            '
            'UscFichaClasifTraslado1
            '
            Me.UscFichaClasifTraslado1._IDIngreso = -1
            Me.UscFichaClasifTraslado1._IDIngresoInpe = -1
            Me.UscFichaClasifTraslado1._IDInterno = -1
            Me.UscFichaClasifTraslado1._IDPenal = CType(-1, Short)
            Me.UscFichaClasifTraslado1._IDRegion = CType(-1, Short)
            Me.UscFichaClasifTraslado1._InternoApeNom = ""
            Me.UscFichaClasifTraslado1._InternoEstado = CType(-1, Short)
            Me.UscFichaClasifTraslado1._uscEliminar = False
            Me.UscFichaClasifTraslado1._uscEscritura = False
            Me.UscFichaClasifTraslado1._uscLectura = False
            Me.UscFichaClasifTraslado1._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
            Me.UscFichaClasifTraslado1._uscReporte = False
            Me.UscFichaClasifTraslado1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFichaClasifTraslado1.Location = New System.Drawing.Point(3, 3)
            Me.UscFichaClasifTraslado1.Margin = New System.Windows.Forms.Padding(4)
            Me.UscFichaClasifTraslado1.Name = "UscFichaClasifTraslado1"
            Me.UscFichaClasifTraslado1.Size = New System.Drawing.Size(1124, 454)
            Me.UscFichaClasifTraslado1.TabIndex = 0
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
            'btnsiguiente
            '
            Me.btnsiguiente.Image = CType(resources.GetObject("btnsiguiente.Image"), System.Drawing.Image)
            Me.btnsiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnsiguiente.Location = New System.Drawing.Point(713, 352)
            Me.btnsiguiente.Name = "btnsiguiente"
            Me.btnsiguiente.Size = New System.Drawing.Size(79, 26)
            Me.btnsiguiente.TabIndex = 10
            Me.btnsiguiente.Text = "Siguiente"
            Me.btnsiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ToolTipMensaje.SetToolTip(Me.btnsiguiente, "Odontogramas nueva version" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            Me.btnsiguiente.UseVisualStyleBackColor = True
            '
            'btnanterior
            '
            Me.btnanterior.Image = CType(resources.GetObject("btnanterior.Image"), System.Drawing.Image)
            Me.btnanterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnanterior.Location = New System.Drawing.Point(618, 352)
            Me.btnanterior.Name = "btnanterior"
            Me.btnanterior.Size = New System.Drawing.Size(89, 26)
            Me.btnanterior.TabIndex = 9
            Me.btnanterior.Text = "Anterior"
            Me.ToolTipMensaje.SetToolTip(Me.btnanterior, "Odontograma versiones anteriores")
            Me.btnanterior.UseVisualStyleBackColor = True
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
            Me.Panel1.Size = New System.Drawing.Size(1152, 31)
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
            'UscOdotoNew1
            '
            Me.UscOdotoNew1.CodIngreso = 1
            Me.UscOdotoNew1.CodIngresoInpe = 0
            Me.UscOdotoNew1.CodInterno = ""
            Me.UscOdotoNew1.CodOdontograma = -1
            Me.UscOdotoNew1.InternoId = -1
            Me.UscOdotoNew1.Location = New System.Drawing.Point(0, 0)
            Me.UscOdotoNew1.Margin = New System.Windows.Forms.Padding(4)
            Me.UscOdotoNew1.Name = "UscOdotoNew1"
            Me.UscOdotoNew1.NomInterno = ""
            Me.UscOdotoNew1.Odonto_nts = Nothing
            Me.UscOdotoNew1.PenalId = -1
            Me.UscOdotoNew1.RegionId = -1
            Me.UscOdotoNew1.Size = New System.Drawing.Size(850, 448)
            Me.UscOdotoNew1.SoloLectura = False
            Me.UscOdotoNew1.TabIndex = 0
            '
            'frmMantClasifPenalLM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1152, 597)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.pnlPiePagina)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "frmMantClasifPenalLM"
            Me.Text = "Interno - Detalle PLM"
            Me.tbpInterno.ResumeLayout(False)
            Me.tcDatosInternos.ResumeLayout(False)
            Me.tbpDatos.ResumeLayout(False)
            Me.pnlDatosPer.ResumeLayout(False)
            Me.pnlUbigeo.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.tbpFoto.ResumeLayout(False)
            Me.tbpBandas.ResumeLayout(False)
            Me.pnlPiePagina.ResumeLayout(False)
            Me.pnlAuditoria.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tbpMandDet.ResumeLayout(False)
            Me.tbpClasificacion.ResumeLayout(False)
            Me.tcClasificacion.ResumeLayout(False)
            Me.tpRegimen.ResumeLayout(False)
            Me.tpEtapa.ResumeLayout(False)
            Me.tabClasifRegresion.ResumeLayout(False)
            Me.tabAnexo05.ResumeLayout(False)
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
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents pnlDatosPer As System.Windows.Forms.Panel
        Friend WithEvents pnlUbigeo As System.Windows.Forms.Panel
        Friend WithEvents pnlDatosAca As System.Windows.Forms.Panel
        Friend WithEvents txtRegionPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlPiePagina As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents tbpFoto As System.Windows.Forms.TabPage
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents cbbSexo As APPControls.uscComboParametrica
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents cbbEstadoCivil As APPControls.uscComboParametrica
        Friend WithEvents txtCodigo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents chkNoindica As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents chk_Obs_DNI As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents tbpBandas As System.Windows.Forms.TabPage
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents cbbNroIngresos As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents ToolTipMensaje As System.Windows.Forms.ToolTip
        Friend WithEvents UscOrganizacionCriminal As APPControls.Registro.Siscrico.uscGrillaOrgCriminal_LM
        Friend WithEvents btnAddIngreso As System.Windows.Forms.Button
        Friend WithEvents uscFotoPerfiles As APPControls.Registro.Captura.uscFotografia_LM
        Friend WithEvents pnlRegionPenal As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents pnlAddIngreso As System.Windows.Forms.Panel
        Friend WithEvents pnlIngresoAdd As System.Windows.Forms.Panel
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents pnlAuditoria As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents tbpMandDet As System.Windows.Forms.TabPage
        Friend WithEvents UscResolucionesMain1 As APPControls.Registro.Resoluciones.uscResolucionesMain_LM
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Label35 As Label
        Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Label30 As Label
        Friend WithEvents btnsiguiente As Button
        Friend WithEvents btnanterior As Button
        Friend WithEvents UscOdotoNew1 As APPControls.uscOdotoNew
        Friend WithEvents tbpClasificacion As TabPage
        Friend WithEvents tcClasificacion As TabControl
        Friend WithEvents tpRegimen As TabPage
        Friend WithEvents UscFichaClasificacion1 As APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionRegimen
        Friend WithEvents tpEtapa As TabPage
        Friend WithEvents tabClasifRegresion As TabPage
        Friend WithEvents UscFichaPorRegresion1 As APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaPorRegresion
        Friend WithEvents tabAnexo05 As TabPage
        Friend WithEvents UscFichaClasifTraslado1 As APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasifTraslado
        Friend WithEvents Label21 As Label
        Friend WithEvents UscFichaClasificacionEtapaLM1 As APPControls.Tratamiento.Asistencia.Clasificacion.Penal.uscFichaClasificacionEtapaLM
        'Friend WithEvents UscClasificaciones2 As APPControls.Clasificacion.uscClasificaciones
    End Class
End Namespace