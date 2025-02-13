Namespace Tratamiento.TallerAsistencia

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMant
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMant))
            Me.tcInternos = New System.Windows.Forms.TabControl()
            Me.tpDatosPersonales = New System.Windows.Forms.TabPage()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.dgvListarActividades = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mot_ret_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ret_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ret = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.txtFechaLibertad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label28 = New System.Windows.Forms.Label()
            Me.txtEstado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label27 = New System.Windows.Forms.Label()
            Me.txtFechaIngresoPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label25 = New System.Windows.Forms.Label()
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label24 = New System.Windows.Forms.Label()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtNacionalidadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
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
            Me.Panel13 = New System.Windows.Forms.Panel()
            Me.UscFotografia_2v3 = New APPControls.Foto.uscFotografia_2v()
            Me.lblMarcacionID = New System.Windows.Forms.Label()
            Me.GroupBox13 = New System.Windows.Forms.GroupBox()
            Me.txtDistritoNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtProvinciaNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDepartamentoNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPaisNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtTipoNumeroDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtEdad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label33 = New System.Windows.Forms.Label()
            Me.GroupBox14 = New System.Windows.Forms.GroupBox()
            Me.rbtFemenino = New System.Windows.Forms.RadioButton()
            Me.rbtMasculino = New System.Windows.Forms.RadioButton()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.txtApellidoPat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label36 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label43 = New System.Windows.Forms.Label()
            Me.txtApellidoMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label44 = New System.Windows.Forms.Label()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.txtCodigoInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label46 = New System.Windows.Forms.Label()
            Me.tpControlAsistencia = New System.Windows.Forms.TabPage()
            Me.dgwListar = New System.Windows.Forms.DataGridView()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.gbCabecera = New System.Windows.Forms.GroupBox()
            Me.cbbTalleres = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.ckbSinsalida = New System.Windows.Forms.CheckBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.pnlRetirar = New System.Windows.Forms.Panel()
            Me.btnRetirar = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.ckbInasistencia = New System.Windows.Forms.CheckBox()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_asi = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_hor_ent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_hor_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_per = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tcInternos.SuspendLayout()
            Me.tpDatosPersonales.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.dgvListarActividades, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox12.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.GroupBox10.SuspendLayout()
            Me.Panel13.SuspendLayout()
            Me.GroupBox13.SuspendLayout()
            Me.GroupBox14.SuspendLayout()
            Me.tpControlAsistencia.SuspendLayout()
            CType(Me.dgwListar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.gbCabecera.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.ToolStrip2.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.pnlRetirar.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcInternos
            '
            Me.tcInternos.Controls.Add(Me.tpDatosPersonales)
            Me.tcInternos.Controls.Add(Me.tpControlAsistencia)
            Me.tcInternos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcInternos.Location = New System.Drawing.Point(0, 0)
            Me.tcInternos.Name = "tcInternos"
            Me.tcInternos.SelectedIndex = 0
            Me.tcInternos.Size = New System.Drawing.Size(1156, 581)
            Me.tcInternos.TabIndex = 0
            '
            'tpDatosPersonales
            '
            Me.tpDatosPersonales.Controls.Add(Me.Panel2)
            Me.tpDatosPersonales.Location = New System.Drawing.Point(4, 22)
            Me.tpDatosPersonales.Name = "tpDatosPersonales"
            Me.tpDatosPersonales.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDatosPersonales.Size = New System.Drawing.Size(1148, 555)
            Me.tpDatosPersonales.TabIndex = 1
            Me.tpDatosPersonales.Text = "Datos Generales"
            Me.tpDatosPersonales.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Controls.Add(Me.GroupBox12)
            Me.Panel2.Controls.Add(Me.GroupBox9)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(3, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(792, 549)
            Me.Panel2.TabIndex = 37
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.dgvListarActividades)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 405)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(792, 144)
            Me.Panel3.TabIndex = 30
            '
            'dgvListarActividades
            '
            Me.dgvListarActividades.AllowUserToAddRows = False
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvListarActividades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvListarActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvListarActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.col_cod, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn13, Me.col_mot_ret_id, Me.col_est_id, Me.DataGridViewTextBoxColumn14, Me.col_ret_nom, Me.col_fec_ret})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvListarActividades.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvListarActividades.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvListarActividades.Location = New System.Drawing.Point(0, 13)
            Me.dgvListarActividades.Name = "dgvListarActividades"
            Me.dgvListarActividades.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvListarActividades.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvListarActividades.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvListarActividades.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvListarActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvListarActividades.Size = New System.Drawing.Size(792, 131)
            Me.dgvListarActividades.TabIndex = 27
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "Contador"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Nº"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 35
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "Codigo"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            Me.col_cod.Width = 60
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "InternoID"
            Me.DataGridViewTextBoxColumn3.HeaderText = "InternoID"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Visible = False
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "NombreTaller"
            Me.DataGridViewTextBoxColumn7.HeaderText = "Actividad Laboral"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.Width = 170
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn10.DataPropertyName = "NombreActividad"
            Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo de Actividad"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.ReadOnly = True
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "NombreTipoActividad"
            Me.DataGridViewTextBoxColumn8.HeaderText = "Tipo"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            Me.DataGridViewTextBoxColumn8.Visible = False
            Me.DataGridViewTextBoxColumn8.Width = 170
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "FechaDate"
            Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha Inscripcion"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.ReadOnly = True
            Me.DataGridViewTextBoxColumn13.Width = 120
            '
            'col_mot_ret_id
            '
            Me.col_mot_ret_id.DataPropertyName = "MotivoRetiroID"
            Me.col_mot_ret_id.HeaderText = "RetiroID"
            Me.col_mot_ret_id.Name = "col_mot_ret_id"
            Me.col_mot_ret_id.ReadOnly = True
            Me.col_mot_ret_id.Visible = False
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "EstadoID"
            Me.col_est_id.HeaderText = "EstadoID"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.ReadOnly = True
            Me.col_est_id.Visible = False
            '
            'DataGridViewTextBoxColumn14
            '
            Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.DataGridViewTextBoxColumn14.DataPropertyName = "EstadoNombre"
            Me.DataGridViewTextBoxColumn14.HeaderText = "Estado"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.ReadOnly = True
            Me.DataGridViewTextBoxColumn14.Width = 90
            '
            'col_ret_nom
            '
            Me.col_ret_nom.DataPropertyName = "MotivoRetiroNombre"
            Me.col_ret_nom.HeaderText = "Motivo retiro"
            Me.col_ret_nom.Name = "col_ret_nom"
            Me.col_ret_nom.ReadOnly = True
            Me.col_ret_nom.Width = 120
            '
            'col_fec_ret
            '
            Me.col_fec_ret.DataPropertyName = "FechaRetiroString"
            Me.col_fec_ret.HeaderText = "Fercha Retiro"
            Me.col_fec_ret.Name = "col_fec_ret"
            Me.col_fec_ret.ReadOnly = True
            Me.col_fec_ret.Width = 95
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(103, 13)
            Me.Label1.TabIndex = 26
            Me.Label1.Text = "Tallares inscritos"
            '
            'GroupBox12
            '
            Me.GroupBox12.Controls.Add(Me.txtFechaLibertad)
            Me.GroupBox12.Controls.Add(Me.Label28)
            Me.GroupBox12.Controls.Add(Me.txtEstado)
            Me.GroupBox12.Controls.Add(Me.Label27)
            Me.GroupBox12.Controls.Add(Me.txtFechaIngresoPenal)
            Me.GroupBox12.Controls.Add(Me.Label25)
            Me.GroupBox12.Controls.Add(Me.txtPenal)
            Me.GroupBox12.Controls.Add(Me.Label24)
            Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox12.Location = New System.Drawing.Point(0, 315)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(792, 90)
            Me.GroupBox12.TabIndex = 29
            Me.GroupBox12.TabStop = False
            Me.GroupBox12.Text = "Datos del Ingreso"
            '
            'txtFechaLibertad
            '
            Me.txtFechaLibertad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaLibertad._BloquearPaste = True
            Me.txtFechaLibertad._SeleccionarTodo = False
            Me.txtFechaLibertad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaLibertad.Location = New System.Drawing.Point(356, 54)
            Me.txtFechaLibertad.Name = "txtFechaLibertad"
            Me.txtFechaLibertad.ReadOnly = True
            Me.txtFechaLibertad.Size = New System.Drawing.Size(171, 20)
            Me.txtFechaLibertad.TabIndex = 28
            Me.txtFechaLibertad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaLibertad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(262, 57)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(87, 13)
            Me.Label28.TabIndex = 27
            Me.Label28.Text = "F. egreso Penal :"
            '
            'txtEstado
            '
            Me.txtEstado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstado._BloquearPaste = True
            Me.txtEstado._SeleccionarTodo = False
            Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEstado.Location = New System.Drawing.Point(356, 22)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(171, 20)
            Me.txtEstado.TabIndex = 26
            Me.txtEstado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.Location = New System.Drawing.Point(262, 25)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(46, 13)
            Me.Label27.TabIndex = 25
            Me.Label27.Text = "Estado :"
            '
            'txtFechaIngresoPenal
            '
            Me.txtFechaIngresoPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaIngresoPenal._BloquearPaste = True
            Me.txtFechaIngresoPenal._SeleccionarTodo = False
            Me.txtFechaIngresoPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaIngresoPenal.Location = New System.Drawing.Point(97, 54)
            Me.txtFechaIngresoPenal.Name = "txtFechaIngresoPenal"
            Me.txtFechaIngresoPenal.ReadOnly = True
            Me.txtFechaIngresoPenal.Size = New System.Drawing.Size(162, 20)
            Me.txtFechaIngresoPenal.TabIndex = 24
            Me.txtFechaIngresoPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaIngresoPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(5, 57)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(86, 13)
            Me.Label25.TabIndex = 23
            Me.Label25.Text = "F. ingreso Penal:"
            '
            'txtPenal
            '
            Me.txtPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPenal._BloquearPaste = True
            Me.txtPenal._SeleccionarTodo = False
            Me.txtPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPenal.Location = New System.Drawing.Point(98, 22)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.ReadOnly = True
            Me.txtPenal.Size = New System.Drawing.Size(161, 20)
            Me.txtPenal.TabIndex = 22
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(5, 25)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(87, 13)
            Me.Label24.TabIndex = 4
            Me.Label24.Text = "Establecimiento :"
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.txtNacionalidadNombre)
            Me.GroupBox9.Controls.Add(Me.Label40)
            Me.GroupBox9.Controls.Add(Me.txtMadre)
            Me.GroupBox9.Controls.Add(Me.txtpadre)
            Me.GroupBox9.Controls.Add(Me.Label38)
            Me.GroupBox9.Controls.Add(Me.txtEstadoCivil)
            Me.GroupBox9.Controls.Add(Me.txtFechaNacimiento)
            Me.GroupBox9.Controls.Add(Me.Label29)
            Me.GroupBox9.Controls.Add(Me.GroupBox10)
            Me.GroupBox9.Controls.Add(Me.Panel13)
            Me.GroupBox9.Controls.Add(Me.GroupBox13)
            Me.GroupBox9.Controls.Add(Me.txtTipoNumeroDoc)
            Me.GroupBox9.Controls.Add(Me.txtEdad)
            Me.GroupBox9.Controls.Add(Me.Label33)
            Me.GroupBox9.Controls.Add(Me.GroupBox14)
            Me.GroupBox9.Controls.Add(Me.Label35)
            Me.GroupBox9.Controls.Add(Me.txtApellidoPat)
            Me.GroupBox9.Controls.Add(Me.Label36)
            Me.GroupBox9.Controls.Add(Me.Label37)
            Me.GroupBox9.Controls.Add(Me.Label39)
            Me.GroupBox9.Controls.Add(Me.Label42)
            Me.GroupBox9.Controls.Add(Me.txtNombres)
            Me.GroupBox9.Controls.Add(Me.Label43)
            Me.GroupBox9.Controls.Add(Me.txtApellidoMat)
            Me.GroupBox9.Controls.Add(Me.Label44)
            Me.GroupBox9.Controls.Add(Me.Label45)
            Me.GroupBox9.Controls.Add(Me.txtCodigoInterno)
            Me.GroupBox9.Controls.Add(Me.Label46)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(792, 315)
            Me.GroupBox9.TabIndex = 0
            Me.GroupBox9.TabStop = False
            '
            'txtNacionalidadNombre
            '
            Me.txtNacionalidadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNacionalidadNombre._BloquearPaste = True
            Me.txtNacionalidadNombre._SeleccionarTodo = False
            Me.txtNacionalidadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNacionalidadNombre.Location = New System.Drawing.Point(91, 284)
            Me.txtNacionalidadNombre.Name = "txtNacionalidadNombre"
            Me.txtNacionalidadNombre.ReadOnly = True
            Me.txtNacionalidadNombre.Size = New System.Drawing.Size(167, 20)
            Me.txtNacionalidadNombre.TabIndex = 39
            Me.txtNacionalidadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNacionalidadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
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
            Me.txtMadre.Location = New System.Drawing.Point(359, 179)
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
            Me.txtpadre.Location = New System.Drawing.Point(91, 179)
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
            Me.Label38.Location = New System.Drawing.Point(2, 183)
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
            Me.txtEstadoCivil.Location = New System.Drawing.Point(358, 149)
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
            Me.txtFechaNacimiento.Location = New System.Drawing.Point(90, 122)
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
            Me.rbtNoRNC.Checked = True
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
            Me.rbtSiRNC.Text = "SI"
            Me.rbtSiRNC.UseVisualStyleBackColor = True
            '
            'Panel13
            '
            Me.Panel13.Controls.Add(Me.UscFotografia_2v3)
            Me.Panel13.Controls.Add(Me.lblMarcacionID)
            Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel13.Location = New System.Drawing.Point(589, 16)
            Me.Panel13.Name = "Panel13"
            Me.Panel13.Size = New System.Drawing.Size(200, 296)
            Me.Panel13.TabIndex = 26
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
            Me.UscFotografia_2v3.Size = New System.Drawing.Size(200, 283)
            Me.UscFotografia_2v3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v3.TabIndex = 28
            '
            'lblMarcacionID
            '
            Me.lblMarcacionID.AutoSize = True
            Me.lblMarcacionID.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblMarcacionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMarcacionID.Location = New System.Drawing.Point(0, 283)
            Me.lblMarcacionID.Name = "lblMarcacionID"
            Me.lblMarcacionID.Size = New System.Drawing.Size(82, 13)
            Me.lblMarcacionID.TabIndex = 27
            Me.lblMarcacionID.Text = "ID marcación"
            '
            'GroupBox13
            '
            Me.GroupBox13.Controls.Add(Me.txtDistritoNacimiento)
            Me.GroupBox13.Controls.Add(Me.txtProvinciaNacimiento)
            Me.GroupBox13.Controls.Add(Me.txtDepartamentoNacimiento)
            Me.GroupBox13.Controls.Add(Me.txtPaisNacimiento)
            Me.GroupBox13.Controls.Add(Me.Label22)
            Me.GroupBox13.Controls.Add(Me.Label30)
            Me.GroupBox13.Controls.Add(Me.Label31)
            Me.GroupBox13.Controls.Add(Me.Label32)
            Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox13.Location = New System.Drawing.Point(5, 204)
            Me.GroupBox13.Name = "GroupBox13"
            Me.GroupBox13.Size = New System.Drawing.Size(541, 75)
            Me.GroupBox13.TabIndex = 22
            Me.GroupBox13.TabStop = False
            Me.GroupBox13.Text = "Lugar nacimiento"
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
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(255, 54)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(45, 13)
            Me.Label22.TabIndex = 6
            Me.Label22.Text = "Distrito :"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(5, 54)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(57, 13)
            Me.Label30.TabIndex = 4
            Me.Label30.Text = "Provincia :"
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label31.Location = New System.Drawing.Point(255, 23)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(80, 13)
            Me.Label31.TabIndex = 2
            Me.Label31.Text = "Departamento :"
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label32.Location = New System.Drawing.Point(5, 23)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(33, 13)
            Me.Label32.TabIndex = 0
            Me.Label32.Text = "Pais :"
            '
            'txtTipoNumeroDoc
            '
            Me.txtTipoNumeroDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoNumeroDoc._BloquearPaste = True
            Me.txtTipoNumeroDoc._SeleccionarTodo = False
            Me.txtTipoNumeroDoc.Location = New System.Drawing.Point(90, 95)
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
            Me.txtEdad.Location = New System.Drawing.Point(216, 121)
            Me.txtEdad.Name = "txtEdad"
            Me.txtEdad.ReadOnly = True
            Me.txtEdad.Size = New System.Drawing.Size(42, 20)
            Me.txtEdad.TabIndex = 21
            Me.txtEdad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEdad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Location = New System.Drawing.Point(177, 128)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(38, 13)
            Me.Label33.TabIndex = 20
            Me.Label33.Text = "Edad :"
            '
            'GroupBox14
            '
            Me.GroupBox14.Controls.Add(Me.rbtFemenino)
            Me.GroupBox14.Controls.Add(Me.rbtMasculino)
            Me.GroupBox14.Location = New System.Drawing.Point(90, 141)
            Me.GroupBox14.Name = "GroupBox14"
            Me.GroupBox14.Size = New System.Drawing.Size(168, 32)
            Me.GroupBox14.TabIndex = 13
            Me.GroupBox14.TabStop = False
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
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Location = New System.Drawing.Point(2, 99)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(83, 13)
            Me.Label35.TabIndex = 18
            Me.Label35.Text = "Doc. Identidad :"
            '
            'txtApellidoPat
            '
            Me.txtApellidoPat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidoPat._BloquearPaste = True
            Me.txtApellidoPat._SeleccionarTodo = False
            Me.txtApellidoPat.Location = New System.Drawing.Point(90, 39)
            Me.txtApellidoPat.MaxLength = 100
            Me.txtApellidoPat.Name = "txtApellidoPat"
            Me.txtApellidoPat.ReadOnly = True
            Me.txtApellidoPat.Size = New System.Drawing.Size(168, 20)
            Me.txtApellidoPat.TabIndex = 8
            Me.txtApellidoPat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidoPat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label36
            '
            Me.Label36.AutoSize = True
            Me.Label36.Location = New System.Drawing.Point(259, 153)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(67, 13)
            Me.Label36.TabIndex = 20
            Me.Label36.Text = "Estado civil :"
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.ForeColor = System.Drawing.Color.Black
            Me.Label37.Location = New System.Drawing.Point(2, 42)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(82, 13)
            Me.Label37.TabIndex = 7
            Me.Label37.Text = "Primer Apellido :"
            '
            'Label39
            '
            Me.Label39.AutoSize = True
            Me.Label39.Location = New System.Drawing.Point(2, 71)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(72, 13)
            Me.Label39.TabIndex = 11
            Me.Label39.Text = "Pre nombres :"
            '
            'Label42
            '
            Me.Label42.AutoSize = True
            Me.Label42.Location = New System.Drawing.Point(2, 128)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(69, 13)
            Me.Label42.TabIndex = 10
            Me.Label42.Text = "Fecha Nac. :"
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = True
            Me.txtNombres._SeleccionarTodo = False
            Me.txtNombres.Location = New System.Drawing.Point(90, 68)
            Me.txtNombres.MaxLength = 100
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.ReadOnly = True
            Me.txtNombres.Size = New System.Drawing.Size(437, 20)
            Me.txtNombres.TabIndex = 12
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Location = New System.Drawing.Point(2, 153)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(37, 13)
            Me.Label43.TabIndex = 8
            Me.Label43.Text = "Sexo :"
            '
            'txtApellidoMat
            '
            Me.txtApellidoMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidoMat._BloquearPaste = True
            Me.txtApellidoMat._SeleccionarTodo = False
            Me.txtApellidoMat.Location = New System.Drawing.Point(359, 39)
            Me.txtApellidoMat.MaxLength = 100
            Me.txtApellidoMat.Name = "txtApellidoMat"
            Me.txtApellidoMat.ReadOnly = True
            Me.txtApellidoMat.Size = New System.Drawing.Size(168, 20)
            Me.txtApellidoMat.TabIndex = 10
            Me.txtApellidoMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidoMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(259, 42)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(96, 13)
            Me.Label44.TabIndex = 9
            Me.Label44.Text = "Segundo Apellido :"
            '
            'Label45
            '
            Me.Label45.AutoSize = True
            Me.Label45.Location = New System.Drawing.Point(2, 13)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(82, 13)
            Me.Label45.TabIndex = 0
            Me.Label45.Text = "Codigo Interno :"
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
            'Label46
            '
            Me.Label46.AutoSize = True
            Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label46.Location = New System.Drawing.Point(259, 183)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(96, 13)
            Me.Label46.TabIndex = 35
            Me.Label46.Text = "Nom. de la madre :"
            '
            'tpControlAsistencia
            '
            Me.tpControlAsistencia.Controls.Add(Me.dgwListar)
            Me.tpControlAsistencia.Controls.Add(Me.Panel1)
            Me.tpControlAsistencia.Location = New System.Drawing.Point(4, 22)
            Me.tpControlAsistencia.Name = "tpControlAsistencia"
            Me.tpControlAsistencia.Padding = New System.Windows.Forms.Padding(3)
            Me.tpControlAsistencia.Size = New System.Drawing.Size(1148, 555)
            Me.tpControlAsistencia.TabIndex = 2
            Me.tpControlAsistencia.Text = "Registro Asistencia"
            Me.tpControlAsistencia.UseVisualStyleBackColor = True
            '
            'dgwListar
            '
            Me.dgwListar.AllowUserToAddRows = False
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwListar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwListar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_con_cod, Me.col_con_int_id, Me.col_con_ape_pat, Me.Column10, Me.col_fec_asi, Me.col_con_hor_ent, Me.col_con_hor_sal, Me.col_con_per, Me.col_con_obs})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwListar.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwListar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwListar.Location = New System.Drawing.Point(3, 120)
            Me.dgwListar.Name = "dgwListar"
            Me.dgwListar.ReadOnly = True
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwListar.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwListar.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwListar.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwListar.Size = New System.Drawing.Size(1142, 432)
            Me.dgwListar.TabIndex = 26
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.gbCabecera)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1142, 117)
            Me.Panel1.TabIndex = 25
            '
            'gbCabecera
            '
            Me.gbCabecera.Controls.Add(Me.ckbInasistencia)
            Me.gbCabecera.Controls.Add(Me.cbbTalleres)
            Me.gbCabecera.Controls.Add(Me.Label2)
            Me.gbCabecera.Controls.Add(Me.lblReg)
            Me.gbCabecera.Controls.Add(Me.dtpFechaFin)
            Me.gbCabecera.Controls.Add(Me.dtpFechaIni)
            Me.gbCabecera.Controls.Add(Me.ckbSinsalida)
            Me.gbCabecera.Controls.Add(Me.Label12)
            Me.gbCabecera.Controls.Add(Me.Label13)
            Me.gbCabecera.Controls.Add(Me.Label14)
            Me.gbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbCabecera.Location = New System.Drawing.Point(0, 0)
            Me.gbCabecera.Name = "gbCabecera"
            Me.gbCabecera.Size = New System.Drawing.Size(946, 117)
            Me.gbCabecera.TabIndex = 24
            Me.gbCabecera.TabStop = False
            '
            'cbbTalleres
            '
            Me.cbbTalleres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTalleres.FormattingEnabled = True
            Me.cbbTalleres.Location = New System.Drawing.Point(119, 39)
            Me.cbbTalleres.Name = "cbbTalleres"
            Me.cbbTalleres.Size = New System.Drawing.Size(247, 21)
            Me.cbbTalleres.TabIndex = 8
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(16, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(95, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Actividad Laboral :"
            '
            'lblReg
            '
            Me.lblReg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblReg.Location = New System.Drawing.Point(797, 81)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(149, 28)
            Me.lblReg.TabIndex = 1
            Me.lblReg.Text = "0 Reg. encontrados"
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.BottomLeft
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(282, 68)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 4
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(119, 68)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 2
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'ckbSinsalida
            '
            Me.ckbSinsalida.AutoSize = True
            Me.ckbSinsalida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbSinsalida.Location = New System.Drawing.Point(16, 94)
            Me.ckbSinsalida.Name = "ckbSinsalida"
            Me.ckbSinsalida.Size = New System.Drawing.Size(116, 17)
            Me.ckbSinsalida.TabIndex = 5
            Me.ckbSinsalida.Text = "Registros sin salida"
            Me.ckbSinsalida.UseVisualStyleBackColor = True
            '
            'Label12
            '
            Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(3, 16)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(940, 20)
            Me.Label12.TabIndex = 0
            Me.Label12.Text = "LISTA DE ASISTENCIA"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(16, 71)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(68, 13)
            Me.Label13.TabIndex = 1
            Me.Label13.Text = "Fecha Inicio:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(208, 71)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(57, 13)
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "Fecha Fin:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.ToolStrip2)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox1.Location = New System.Drawing.Point(946, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(196, 117)
            Me.GroupBox1.TabIndex = 22
            Me.GroupBox1.TabStop = False
            '
            'ToolStrip2
            '
            Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbLimpiar})
            Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip2.Name = "ToolStrip2"
            Me.ToolStrip2.Size = New System.Drawing.Size(190, 98)
            Me.ToolStrip2.TabIndex = 0
            Me.ToolStrip2.Text = "ToolStrip2"
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
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.pnlRetirar)
            Me.Panel8.Controls.Add(Me.pnlExportar)
            Me.Panel8.Controls.Add(Me.pnlReporte)
            Me.Panel8.Controls.Add(Me.Panel9)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel8.Location = New System.Drawing.Point(0, 581)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(1156, 44)
            Me.Panel8.TabIndex = 2
            '
            'pnlRetirar
            '
            Me.pnlRetirar.Controls.Add(Me.btnRetirar)
            Me.pnlRetirar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlRetirar.Location = New System.Drawing.Point(772, 0)
            Me.pnlRetirar.Name = "pnlRetirar"
            Me.pnlRetirar.Size = New System.Drawing.Size(94, 44)
            Me.pnlRetirar.TabIndex = 72
            '
            'btnRetirar
            '
            Me.btnRetirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRetirar.Image = Global.SIPPOPE.My.Resources.Resources.next_32
            Me.btnRetirar.Location = New System.Drawing.Point(3, 3)
            Me.btnRetirar.Name = "btnRetirar"
            Me.btnRetirar.Size = New System.Drawing.Size(88, 40)
            Me.btnRetirar.TabIndex = 39
            Me.btnRetirar.Text = "&Retirar"
            Me.btnRetirar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnRetirar.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExportar.Location = New System.Drawing.Point(866, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(99, 44)
            Me.pnlExportar.TabIndex = 71
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(5, 2)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 66
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlReporte.Location = New System.Drawing.Point(965, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(103, 44)
            Me.pnlReporte.TabIndex = 68
            '
            'btnReporte
            '
            Me.btnReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(7, 2)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 40)
            Me.btnReporte.TabIndex = 1
            Me.btnReporte.Text = "&Reportes"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.btnSalir)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel9.Location = New System.Drawing.Point(1068, 0)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(88, 44)
            Me.Panel9.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(3, 1)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 67
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'ckbInasistencia
            '
            Me.ckbInasistencia.AutoSize = True
            Me.ckbInasistencia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbInasistencia.Location = New System.Drawing.Point(223, 94)
            Me.ckbInasistencia.Name = "ckbInasistencia"
            Me.ckbInasistencia.Size = New System.Drawing.Size(143, 17)
            Me.ckbInasistencia.TabIndex = 9
            Me.ckbInasistencia.Text = "Registros de inasistencia"
            Me.ckbInasistencia.UseVisualStyleBackColor = True
            '
            'col_num
            '
            Me.col_num.DataPropertyName = "Contador"
            Me.col_num.HeaderText = "Nº"
            Me.col_num.Name = "col_num"
            Me.col_num.ReadOnly = True
            Me.col_num.Width = 35
            '
            'col_con_cod
            '
            Me.col_con_cod.DataPropertyName = "Codigo"
            Me.col_con_cod.HeaderText = "Codigo"
            Me.col_con_cod.Name = "col_con_cod"
            Me.col_con_cod.ReadOnly = True
            Me.col_con_cod.Visible = False
            '
            'col_con_int_id
            '
            Me.col_con_int_id.DataPropertyName = "InternoID"
            Me.col_con_int_id.HeaderText = "InternoID"
            Me.col_con_int_id.Name = "col_con_int_id"
            Me.col_con_int_id.ReadOnly = True
            Me.col_con_int_id.Visible = False
            '
            'col_con_ape_pat
            '
            Me.col_con_ape_pat.DataPropertyName = "TallerNombre"
            Me.col_con_ape_pat.HeaderText = "Actividad Laboral"
            Me.col_con_ape_pat.Name = "col_con_ape_pat"
            Me.col_con_ape_pat.ReadOnly = True
            Me.col_con_ape_pat.Width = 250
            '
            'Column10
            '
            Me.Column10.HeaderText = "Curso"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Visible = False
            '
            'col_fec_asi
            '
            Me.col_fec_asi.DataPropertyName = "FechaDate"
            Me.col_fec_asi.HeaderText = "Fecha Asistencia"
            Me.col_fec_asi.Name = "col_fec_asi"
            Me.col_fec_asi.ReadOnly = True
            Me.col_fec_asi.Width = 120
            '
            'col_con_hor_ent
            '
            Me.col_con_hor_ent.DataPropertyName = "HoraEntrada"
            Me.col_con_hor_ent.HeaderText = "Hora Entrada"
            Me.col_con_hor_ent.Name = "col_con_hor_ent"
            Me.col_con_hor_ent.ReadOnly = True
            '
            'col_con_hor_sal
            '
            Me.col_con_hor_sal.DataPropertyName = "HoraSalida"
            Me.col_con_hor_sal.HeaderText = "Hora Salida"
            Me.col_con_hor_sal.Name = "col_con_hor_sal"
            Me.col_con_hor_sal.ReadOnly = True
            '
            'col_con_per
            '
            Me.col_con_per.DataPropertyName = "Permanencia"
            Me.col_con_per.HeaderText = "Permanencia"
            Me.col_con_per.Name = "col_con_per"
            Me.col_con_per.ReadOnly = True
            '
            'col_con_obs
            '
            Me.col_con_obs.DataPropertyName = "MotivoJustificacionNombre"
            Me.col_con_obs.HeaderText = "Justificación"
            Me.col_con_obs.Name = "col_con_obs"
            Me.col_con_obs.ReadOnly = True
            Me.col_con_obs.Width = 160
            '
            'frmMant
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1156, 625)
            Me.Controls.Add(Me.tcInternos)
            Me.Controls.Add(Me.Panel8)
            Me.Name = "frmMant"
            Me.Text = "Datos del Interno"
            Me.tcInternos.ResumeLayout(False)
            Me.tpDatosPersonales.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            CType(Me.dgvListarActividades, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox10.PerformLayout()
            Me.Panel13.ResumeLayout(False)
            Me.Panel13.PerformLayout()
            Me.GroupBox13.ResumeLayout(False)
            Me.GroupBox13.PerformLayout()
            Me.GroupBox14.ResumeLayout(False)
            Me.GroupBox14.PerformLayout()
            Me.tpControlAsistencia.ResumeLayout(False)
            CType(Me.dgwListar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.gbCabecera.ResumeLayout(False)
            Me.gbCabecera.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ToolStrip2.ResumeLayout(False)
            Me.ToolStrip2.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.pnlRetirar.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents tcInternos As System.Windows.Forms.TabControl
        Friend WithEvents tpDatosPersonales As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaLibertad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtFechaIngresoPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNacionalidadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label40 As System.Windows.Forms.Label
        Friend WithEvents txtMadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtpadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents txtEstadoCivil As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
        Friend WithEvents rbtNoRNC As System.Windows.Forms.RadioButton
        Friend WithEvents rbtSiRNC As System.Windows.Forms.RadioButton
        Friend WithEvents Panel13 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDistritoNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtProvinciaNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDepartamentoNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPaisNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents txtTipoNumeroDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEdad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
        Friend WithEvents rbtFemenino As System.Windows.Forms.RadioButton
        Friend WithEvents rbtMasculino As System.Windows.Forms.RadioButton
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents txtApellidoPat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents Label42 As System.Windows.Forms.Label
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents txtApellidoMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents Label45 As System.Windows.Forms.Label
        Friend WithEvents txtCodigoInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents tpControlAsistencia As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents UscFotografia_2v3 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents lblMarcacionID As System.Windows.Forms.Label
        Friend WithEvents dgwListar As System.Windows.Forms.DataGridView
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents gbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents ckbSinsalida As System.Windows.Forms.CheckBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents dgvListarActividades As System.Windows.Forms.DataGridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cbbTalleres As System.Windows.Forms.ComboBox
        Friend WithEvents pnlRetirar As System.Windows.Forms.Panel
        Friend WithEvents btnRetirar As System.Windows.Forms.Button
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents col_cod As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
        Friend WithEvents col_mot_ret_id As DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
        Friend WithEvents col_ret_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ret As DataGridViewTextBoxColumn
        Friend WithEvents ckbInasistencia As CheckBox
        Friend WithEvents col_num As DataGridViewTextBoxColumn
        Friend WithEvents col_con_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_con_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_con_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents Column10 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_asi As DataGridViewTextBoxColumn
        Friend WithEvents col_con_hor_ent As DataGridViewTextBoxColumn
        Friend WithEvents col_con_hor_sal As DataGridViewTextBoxColumn
        Friend WithEvents col_con_per As DataGridViewTextBoxColumn
        Friend WithEvents col_con_obs As DataGridViewTextBoxColumn
    End Class
End Namespace