Namespace Registro.Penal.Busqueda
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblSegundo = New System.Windows.Forms.Label()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.pnlBotonesAccion = New System.Windows.Forms.Panel()
            Me.pblLeyendaEmiAnte = New System.Windows.Forms.Panel()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.pnlBotonOtros = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlBotonReporte = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlAnular = New System.Windows.Forms.Panel()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.pnlBotonGrabar = New System.Windows.Forms.Panel()
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
            Me.tbcSeccion = New System.Windows.Forms.TabControl()
            Me.tpConsultaInterno = New System.Windows.Forms.TabPage()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.DMP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.SMP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
            Me.tpConsultaMovimiento = New System.Windows.Forms.TabPage()
            Me.UscBusquedaMovimiento1 = New APPControls.Registro.Main.uscBusquedaMovimiento()
            Me.tpEmisionAntec = New System.Windows.Forms.TabPage()
            Me.UscEmisionAntecedentes1 = New APPControls.Penal.uscEmisionAntecedentes()
            Me.pnlBarraestado = New System.Windows.Forms.Panel()
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
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
            Me.Panel3.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.pnlBotonesAccion.SuspendLayout()
            Me.pblLeyendaEmiAnte.SuspendLayout()
            Me.pnlBotonOtros.SuspendLayout()
            Me.pnlBotonReporte.SuspendLayout()
            Me.pnlAnular.SuspendLayout()
            Me.pnlBotonGrabar.SuspendLayout()
            Me.pnlFotografia.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            Me.pnlCuerpoPrincipal.SuspendLayout()
            Me.tbcSeccion.SuspendLayout()
            Me.tpConsultaInterno.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultaMovimiento.SuspendLayout()
            Me.tpEmisionAntec.SuspendLayout()
            Me.pnlBarraestado.SuspendLayout()
            Me.StatusStrip1.SuspendLayout()
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
            Me.grbEstado.Size = New System.Drawing.Size(109, 96)
            Me.grbEstado.TabIndex = 5
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado"
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Checked = True
            Me.rdbEstadoTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(25, 68)
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
            Me.rdbInactivo.Location = New System.Drawing.Point(25, 43)
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
            Me.rdbActivo.Location = New System.Drawing.Point(25, 18)
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
            Me.Panel3.Size = New System.Drawing.Size(1063, 32)
            Me.Panel3.TabIndex = 0
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label7.Location = New System.Drawing.Point(0, 29)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(1063, 3)
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
            Me.cbbRegion.Location = New System.Drawing.Point(56, 6)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(189, 22)
            Me.cbbRegion.TabIndex = 1
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
            Me.pnlBotonesAccion.Controls.Add(Me.pblLeyendaEmiAnte)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonOtros)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonReporte)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlAnular)
            Me.pnlBotonesAccion.Controls.Add(Me.pnlBotonGrabar)
            Me.pnlBotonesAccion.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotonesAccion.Name = "pnlBotonesAccion"
            Me.pnlBotonesAccion.Size = New System.Drawing.Size(854, 50)
            Me.pnlBotonesAccion.TabIndex = 39
            '
            'pblLeyendaEmiAnte
            '
            Me.pblLeyendaEmiAnte.BackColor = System.Drawing.Color.Transparent
            Me.pblLeyendaEmiAnte.Controls.Add(Me.Label25)
            Me.pblLeyendaEmiAnte.Controls.Add(Me.Label28)
            Me.pblLeyendaEmiAnte.Controls.Add(Me.Label29)
            Me.pblLeyendaEmiAnte.Controls.Add(Me.Label30)
            Me.pblLeyendaEmiAnte.Controls.Add(Me.Label31)
            Me.pblLeyendaEmiAnte.Controls.Add(Me.Label32)
            Me.pblLeyendaEmiAnte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pblLeyendaEmiAnte.Location = New System.Drawing.Point(553, 0)
            Me.pblLeyendaEmiAnte.Name = "pblLeyendaEmiAnte"
            Me.pblLeyendaEmiAnte.Size = New System.Drawing.Size(262, 50)
            Me.pblLeyendaEmiAnte.TabIndex = 88
            Me.pblLeyendaEmiAnte.Visible = False
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(32, 18)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(57, 13)
            Me.Label25.TabIndex = 84
            Me.Label25.Text = "Terminado"
            '
            'Label28
            '
            Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label28.Location = New System.Drawing.Point(7, 14)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(22, 21)
            Me.Label28.TabIndex = 85
            '
            'Label29
            '
            Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label29.Location = New System.Drawing.Point(97, 14)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(22, 21)
            Me.Label29.TabIndex = 85
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(206, 18)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(46, 13)
            Me.Label30.TabIndex = 84
            Me.Label30.Text = "Anulado"
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(122, 18)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(44, 13)
            Me.Label31.TabIndex = 84
            Me.Label31.Text = "Impreso"
            '
            'Label32
            '
            Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer))
            Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label32.Location = New System.Drawing.Point(181, 14)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(22, 21)
            Me.Label32.TabIndex = 85
            '
            'pnlBotonOtros
            '
            Me.pnlBotonOtros.Controls.Add(Me.btnSalir)
            Me.pnlBotonOtros.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonOtros.Location = New System.Drawing.Point(461, 0)
            Me.pnlBotonOtros.Name = "pnlBotonOtros"
            Me.pnlBotonOtros.Size = New System.Drawing.Size(92, 50)
            Me.pnlBotonOtros.TabIndex = 72
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
            Me.pnlBotonReporte.Controls.Add(Me.btnReporte)
            Me.pnlBotonReporte.Controls.Add(Me.btnExportar)
            Me.pnlBotonReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonReporte.Location = New System.Drawing.Point(278, 0)
            Me.pnlBotonReporte.Name = "pnlBotonReporte"
            Me.pnlBotonReporte.Size = New System.Drawing.Size(183, 50)
            Me.pnlBotonReporte.TabIndex = 71
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(92, 5)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 40)
            Me.btnReporte.TabIndex = 67
            Me.btnReporte.Text = "&Reportes"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
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
            'pnlAnular
            '
            Me.pnlAnular.BackColor = System.Drawing.SystemColors.Control
            Me.pnlAnular.Controls.Add(Me.btnAnular)
            Me.pnlAnular.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAnular.Location = New System.Drawing.Point(185, 0)
            Me.pnlAnular.Name = "pnlAnular"
            Me.pnlAnular.Size = New System.Drawing.Size(93, 50)
            Me.pnlAnular.TabIndex = 90
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
            'pnlBotonGrabar
            '
            Me.pnlBotonGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlBotonGrabar.Controls.Add(Me.btnModificar)
            Me.pnlBotonGrabar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBotonGrabar.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotonGrabar.Name = "pnlBotonGrabar"
            Me.pnlBotonGrabar.Size = New System.Drawing.Size(185, 50)
            Me.pnlBotonGrabar.TabIndex = 70
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(3, 5)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(86, 40)
            Me.btnNuevo.TabIndex = 63
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
            Me.btnModificar.Location = New System.Drawing.Point(93, 5)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
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
            Me.Panel5.Location = New System.Drawing.Point(0, 473)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(196, 123)
            Me.Panel5.TabIndex = 1
            '
            'txtFechaEgreso
            '
            Me.txtFechaEgreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaEgreso._BloquearPaste = False
            Me.txtFechaEgreso._SeleccionarTodo = True
            Me.txtFechaEgreso.ForeColor = System.Drawing.Color.Black
            Me.txtFechaEgreso.Location = New System.Drawing.Point(75, 93)
            Me.txtFechaEgreso.Name = "txtFechaEgreso"
            Me.txtFechaEgreso.ReadOnly = True
            Me.txtFechaEgreso.Size = New System.Drawing.Size(95, 20)
            Me.txtFechaEgreso.TabIndex = 9
            Me.txtFechaEgreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaEgreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(5, 97)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(67, 13)
            Me.Label15.TabIndex = 8
            Me.Label15.Text = "Fec. Egreso:"
            '
            'txtTipoEgreso
            '
            Me.txtTipoEgreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoEgreso._BloquearPaste = False
            Me.txtTipoEgreso._SeleccionarTodo = True
            Me.txtTipoEgreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoEgreso.ForeColor = System.Drawing.Color.Black
            Me.txtTipoEgreso.Location = New System.Drawing.Point(74, 70)
            Me.txtTipoEgreso.Name = "txtTipoEgreso"
            Me.txtTipoEgreso.ReadOnly = True
            Me.txtTipoEgreso.Size = New System.Drawing.Size(95, 20)
            Me.txtTipoEgreso.TabIndex = 7
            Me.txtTipoEgreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTipoEgreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(4, 74)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(67, 13)
            Me.Label14.TabIndex = 6
            Me.Label14.Text = "Tipo Egreso:"
            '
            'txtSituacionJur
            '
            Me.txtSituacionJur._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSituacionJur._BloquearPaste = False
            Me.txtSituacionJur._SeleccionarTodo = True
            Me.txtSituacionJur.ForeColor = System.Drawing.Color.Black
            Me.txtSituacionJur.Location = New System.Drawing.Point(74, 47)
            Me.txtSituacionJur.Name = "txtSituacionJur"
            Me.txtSituacionJur.ReadOnly = True
            Me.txtSituacionJur.Size = New System.Drawing.Size(95, 20)
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
            Me.txtIngresoFecha.Location = New System.Drawing.Point(74, 25)
            Me.txtIngresoFecha.Name = "txtIngresoFecha"
            Me.txtIngresoFecha.ReadOnly = True
            Me.txtIngresoFecha.Size = New System.Drawing.Size(95, 20)
            Me.txtIngresoFecha.TabIndex = 3
            Me.txtIngresoFecha.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIngresoFecha.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(4, 51)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(64, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Sit. Juridica:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(3, 28)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(69, 13)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Fec. Ingreso:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(3, 7)
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
            Me.txtIngresoNum.Location = New System.Drawing.Point(74, 3)
            Me.txtIngresoNum.Name = "txtIngresoNum"
            Me.txtIngresoNum.ReadOnly = True
            Me.txtIngresoNum.Size = New System.Drawing.Size(95, 20)
            Me.txtIngresoNum.TabIndex = 1
            Me.txtIngresoNum.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIngresoNum.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.pnlCuerpoPrincipal)
            Me.pnlGrilla.Controls.Add(Me.pnlBarraestado)
            Me.pnlGrilla.Controls.Add(Me.Panel3)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(1063, 546)
            Me.pnlGrilla.TabIndex = 41
            '
            'pnlCuerpoPrincipal
            '
            Me.pnlCuerpoPrincipal.Controls.Add(Me.tbcSeccion)
            Me.pnlCuerpoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCuerpoPrincipal.Location = New System.Drawing.Point(0, 32)
            Me.pnlCuerpoPrincipal.Name = "pnlCuerpoPrincipal"
            Me.pnlCuerpoPrincipal.Size = New System.Drawing.Size(1063, 491)
            Me.pnlCuerpoPrincipal.TabIndex = 44
            '
            'tbcSeccion
            '
            Me.tbcSeccion.Controls.Add(Me.tpConsultaInterno)
            Me.tbcSeccion.Controls.Add(Me.tpConsultaMovimiento)
            Me.tbcSeccion.Controls.Add(Me.tpEmisionAntec)
            Me.tbcSeccion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbcSeccion.Location = New System.Drawing.Point(0, 0)
            Me.tbcSeccion.Name = "tbcSeccion"
            Me.tbcSeccion.SelectedIndex = 0
            Me.tbcSeccion.Size = New System.Drawing.Size(1063, 491)
            Me.tbcSeccion.TabIndex = 0
            '
            'tpConsultaInterno
            '
            Me.tpConsultaInterno.Controls.Add(Me.Panel2)
            Me.tpConsultaInterno.Controls.Add(Me.pnlBusqueda)
            Me.tpConsultaInterno.Location = New System.Drawing.Point(4, 22)
            Me.tpConsultaInterno.Name = "tpConsultaInterno"
            Me.tpConsultaInterno.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultaInterno.Size = New System.Drawing.Size(1055, 465)
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
            Me.Panel2.Size = New System.Drawing.Size(1049, 313)
            Me.Panel2.TabIndex = 38
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DMP, Me.SMP, Me.col_pdr, Me.col_int_id, Me.col_ing_id, Me.col_cod_rp, Me.Column1, Me.Column2, Me.col_ape, Me.col_nom, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column6, Me.col_fec_nac, Me.Column7, Me.Column17, Me.col_pabellon, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom, Me.col_est_nom, Me.col_est_gen, Me.col_fot_ico_pi, Me.col_fot_ico_pf, Me.col_fot_ico_pd, Me.Column8})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1049, 313)
            Me.dgwGrilla.TabIndex = 38
            Me.dgwGrilla.VisibleCampos = False
            '
            'DMP
            '
            Me.DMP.DataPropertyName = "DMP"
            Me.DMP.FalseValue = "0"
            Me.DMP.HeaderText = "DMP"
            Me.DMP.Name = "DMP"
            Me.DMP.ReadOnly = True
            Me.DMP.ToolTipText = "Delito de Mayor Pena"
            Me.DMP.TrueValue = "1"
            Me.DMP.Width = 33
            '
            'SMP
            '
            Me.SMP.DataPropertyName = "SMP"
            Me.SMP.FalseValue = "0"
            Me.SMP.HeaderText = "SMP"
            Me.SMP.Name = "SMP"
            Me.SMP.ReadOnly = True
            Me.SMP.ToolTipText = "Sentencia de Mayor Pena"
            Me.SMP.TrueValue = "1"
            Me.SMP.Width = 32
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
            Me.tpConsultaMovimiento.Controls.Add(Me.UscBusquedaMovimiento1)
            Me.tpConsultaMovimiento.Location = New System.Drawing.Point(4, 22)
            Me.tpConsultaMovimiento.Name = "tpConsultaMovimiento"
            Me.tpConsultaMovimiento.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultaMovimiento.Size = New System.Drawing.Size(1055, 465)
            Me.tpConsultaMovimiento.TabIndex = 1
            Me.tpConsultaMovimiento.Text = "Consulta de movimientos"
            Me.tpConsultaMovimiento.UseVisualStyleBackColor = True
            '
            'UscBusquedaMovimiento1
            '
            Me.UscBusquedaMovimiento1._ColorFondoGrilla = System.Drawing.Color.White
            Me.UscBusquedaMovimiento1._IDPenal = -1
            Me.UscBusquedaMovimiento1._IDRegion = -1
            Me.UscBusquedaMovimiento1._TipoBusqueda = False
            Me.UscBusquedaMovimiento1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscBusquedaMovimiento1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscBusquedaMovimiento1.Location = New System.Drawing.Point(3, 3)
            Me.UscBusquedaMovimiento1.Name = "UscBusquedaMovimiento1"
            Me.UscBusquedaMovimiento1.Size = New System.Drawing.Size(1049, 459)
            Me.UscBusquedaMovimiento1.TabIndex = 0
            '
            'tpEmisionAntec
            '
            Me.tpEmisionAntec.Controls.Add(Me.UscEmisionAntecedentes1)
            Me.tpEmisionAntec.Location = New System.Drawing.Point(4, 22)
            Me.tpEmisionAntec.Name = "tpEmisionAntec"
            Me.tpEmisionAntec.Size = New System.Drawing.Size(1055, 465)
            Me.tpEmisionAntec.TabIndex = 2
            Me.tpEmisionAntec.Text = "Emision de Antecedentes"
            Me.tpEmisionAntec.UseVisualStyleBackColor = True
            '
            'UscEmisionAntecedentes1
            '
            Me.UscEmisionAntecedentes1._IDPenal = CType(-1, Short)
            Me.UscEmisionAntecedentes1._IDRegion = CType(-1, Short)
            Me.UscEmisionAntecedentes1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscEmisionAntecedentes1.Location = New System.Drawing.Point(0, 0)
            Me.UscEmisionAntecedentes1.Name = "UscEmisionAntecedentes1"
            Me.UscEmisionAntecedentes1.Size = New System.Drawing.Size(1055, 465)
            Me.UscEmisionAntecedentes1.TabIndex = 0
            '
            'pnlBarraestado
            '
            Me.pnlBarraestado.Controls.Add(Me.StatusStrip1)
            Me.pnlBarraestado.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBarraestado.Location = New System.Drawing.Point(0, 523)
            Me.pnlBarraestado.Name = "pnlBarraestado"
            Me.pnlBarraestado.Size = New System.Drawing.Size(1063, 23)
            Me.pnlBarraestado.TabIndex = 43
            '
            'StatusStrip1
            '
            Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
            Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Size = New System.Drawing.Size(1063, 23)
            Me.StatusStrip1.TabIndex = 41
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'ToolStripStatusLabel1
            '
            Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
            Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 18)
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
            Me.pnlInferior.Location = New System.Drawing.Point(0, 546)
            Me.pnlInferior.Name = "pnlInferior"
            Me.pnlInferior.Size = New System.Drawing.Size(1063, 50)
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
            Me.btnVerLibros.Size = New System.Drawing.Size(80, 50)
            Me.btnVerLibros.TabIndex = 68
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
            Me.Text = "Busqueda "
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
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.pnlBotonesAccion.ResumeLayout(False)
            Me.pblLeyendaEmiAnte.ResumeLayout(False)
            Me.pblLeyendaEmiAnte.PerformLayout()
            Me.pnlBotonOtros.ResumeLayout(False)
            Me.pnlBotonReporte.ResumeLayout(False)
            Me.pnlAnular.ResumeLayout(False)
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
            Me.tbcSeccion.ResumeLayout(False)
            Me.tpConsultaInterno.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpConsultaMovimiento.ResumeLayout(False)
            Me.tpEmisionAntec.ResumeLayout(False)
            Me.pnlBarraestado.ResumeLayout(False)
            Me.pnlBarraestado.PerformLayout()
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
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
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
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
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
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
        Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
        Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
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
        Friend WithEvents tbcSeccion As System.Windows.Forms.TabControl
        Friend WithEvents tpConsultaInterno As System.Windows.Forms.TabPage
        Friend WithEvents tpConsultaMovimiento As System.Windows.Forms.TabPage
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlBarraestado As System.Windows.Forms.Panel
        Friend WithEvents pnlCuerpoPrincipal As System.Windows.Forms.Panel
        Friend WithEvents DMP As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents SMP As System.Windows.Forms.DataGridViewCheckBoxColumn
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
        Friend WithEvents UscBusquedaMovimiento1 As APPControls.Registro.Main.uscBusquedaMovimiento
        Friend WithEvents btnVerLibros As Button
        Friend WithEvents tpEmisionAntec As TabPage
        Friend WithEvents UscEmisionAntecedentes1 As APPControls.Penal.uscEmisionAntecedentes
        Friend WithEvents pnlAnular As Panel
        Friend WithEvents btnAnular As Button
        Friend WithEvents pblLeyendaEmiAnte As Panel
        Friend WithEvents Label25 As Label
        Friend WithEvents Label28 As Label
        Friend WithEvents Label29 As Label
        Friend WithEvents Label30 As Label
        Friend WithEvents Label31 As Label
        Friend WithEvents Label32 As Label
    End Class
End Namespace

