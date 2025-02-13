Namespace Tratamiento.TallerAsistencia

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmControlAsistencia
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlAsistencia))
            Me.dgwListar = New System.Windows.Forms.DataGridView()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nac_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tal_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_asi = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_hor_ent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_hor_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_per = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_jus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.ckbInasistencia = New System.Windows.Forms.CheckBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ckbSinsalida = New System.Windows.Forms.CheckBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.cbbTalleres = New APPControls.uscComboParametrica()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApellidos = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.pnlRegularizar = New System.Windows.Forms.Panel()
            Me.btnSuspender = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlImporAsistencia = New System.Windows.Forms.Panel()
            Me.btnImportarAsis = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.dgwListar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel6.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.ToolStrip2.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.pnlRegularizar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlImporAsistencia.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
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
            Me.dgwListar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_con_cod, Me.col_con_int_id, Me.col_cod_rp, Me.Column8, Me.col_con_ape_pat, Me.col_con_ape_mat, Me.col_con_nom, Me.col_fec_nac, Me.col_nac_nom, Me.col_tal_nom, Me.col_fec_asi, Me.col_con_hor_ent, Me.col_con_hor_sal, Me.col_con_per, Me.col_jus_id, Me.col_con_obs})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwListar.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwListar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwListar.Location = New System.Drawing.Point(0, 0)
            Me.dgwListar.Name = "dgwListar"
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
            Me.dgwListar.Size = New System.Drawing.Size(1156, 232)
            Me.dgwListar.TabIndex = 0
            '
            'col_num
            '
            Me.col_num.DataPropertyName = "Contador"
            Me.col_num.HeaderText = "Nº"
            Me.col_num.Name = "col_num"
            Me.col_num.Width = 35
            '
            'col_con_cod
            '
            Me.col_con_cod.DataPropertyName = "Codigo"
            Me.col_con_cod.HeaderText = "Codigo"
            Me.col_con_cod.Name = "col_con_cod"
            Me.col_con_cod.Visible = False
            '
            'col_con_int_id
            '
            Me.col_con_int_id.DataPropertyName = "InternoID"
            Me.col_con_int_id.HeaderText = "InternoID"
            Me.col_con_int_id.Name = "col_con_int_id"
            Me.col_con_int_id.Visible = False
            '
            'col_cod_rp
            '
            Me.col_cod_rp.DataPropertyName = "CodigoRP"
            Me.col_cod_rp.HeaderText = "Codigo"
            Me.col_cod_rp.Name = "col_cod_rp"
            Me.col_cod_rp.Width = 90
            '
            'Column8
            '
            Me.Column8.DataPropertyName = "TipoNumeroDocumento"
            Me.Column8.HeaderText = "Tipo Doc. / Nº Doc."
            Me.Column8.Name = "Column8"
            Me.Column8.Width = 140
            '
            'col_con_ape_pat
            '
            Me.col_con_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_con_ape_pat.HeaderText = "Primer Apellido"
            Me.col_con_ape_pat.Name = "col_con_ape_pat"
            Me.col_con_ape_pat.Width = 130
            '
            'col_con_ape_mat
            '
            Me.col_con_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_con_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_con_ape_mat.Name = "col_con_ape_mat"
            Me.col_con_ape_mat.Width = 130
            '
            'col_con_nom
            '
            Me.col_con_nom.DataPropertyName = "Nombres"
            Me.col_con_nom.HeaderText = "Pre Nombres"
            Me.col_con_nom.Name = "col_con_nom"
            Me.col_con_nom.Width = 150
            '
            'col_fec_nac
            '
            Me.col_fec_nac.DataPropertyName = "FechaNacimiento"
            Me.col_fec_nac.HeaderText = "F. Nacimiento"
            Me.col_fec_nac.Name = "col_fec_nac"
            Me.col_fec_nac.Visible = False
            '
            'col_nac_nom
            '
            Me.col_nac_nom.DataPropertyName = "NacionalidadNombre"
            Me.col_nac_nom.HeaderText = "Nacionalidad"
            Me.col_nac_nom.Name = "col_nac_nom"
            '
            'col_tal_nom
            '
            Me.col_tal_nom.DataPropertyName = "TallerNombre"
            Me.col_tal_nom.HeaderText = "Actividad Laboral"
            Me.col_tal_nom.Name = "col_tal_nom"
            Me.col_tal_nom.Width = 115
            '
            'col_fec_asi
            '
            Me.col_fec_asi.DataPropertyName = "Fecha"
            Me.col_fec_asi.HeaderText = "Fecha"
            Me.col_fec_asi.Name = "col_fec_asi"
            '
            'col_con_hor_ent
            '
            Me.col_con_hor_ent.DataPropertyName = "HoraEntrada"
            Me.col_con_hor_ent.HeaderText = "Hora Entrada"
            Me.col_con_hor_ent.Name = "col_con_hor_ent"
            '
            'col_con_hor_sal
            '
            Me.col_con_hor_sal.DataPropertyName = "HoraSalida"
            Me.col_con_hor_sal.HeaderText = "Hora Salida"
            Me.col_con_hor_sal.Name = "col_con_hor_sal"
            '
            'col_con_per
            '
            Me.col_con_per.DataPropertyName = "Permanencia"
            Me.col_con_per.HeaderText = "Permanencia"
            Me.col_con_per.Name = "col_con_per"
            '
            'col_jus_id
            '
            Me.col_jus_id.DataPropertyName = "MotivoJustificacionID"
            Me.col_jus_id.HeaderText = "JustificacionID"
            Me.col_jus_id.Name = "col_jus_id"
            Me.col_jus_id.Visible = False
            '
            'col_con_obs
            '
            Me.col_con_obs.DataPropertyName = "MotivoJustificacionNombre"
            Me.col_con_obs.HeaderText = "Justificación"
            Me.col_con_obs.Name = "col_con_obs"
            Me.col_con_obs.Width = 170
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.GroupBox2)
            Me.Panel6.Controls.Add(Me.GroupBox1)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(0, 34)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(1156, 125)
            Me.Panel6.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.GroupBox4)
            Me.GroupBox2.Controls.Add(Me.GroupBox3)
            Me.GroupBox2.Controls.Add(Me.GroupBox8)
            Me.GroupBox2.Controls.Add(Me.Panel1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(960, 125)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.ckbInasistencia)
            Me.GroupBox4.Controls.Add(Me.lblReg)
            Me.GroupBox4.Controls.Add(Me.ckbSinsalida)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(671, 16)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(286, 82)
            Me.GroupBox4.TabIndex = 2
            Me.GroupBox4.TabStop = False
            '
            'ckbInasistencia
            '
            Me.ckbInasistencia.AutoSize = True
            Me.ckbInasistencia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbInasistencia.Location = New System.Drawing.Point(16, 24)
            Me.ckbInasistencia.Name = "ckbInasistencia"
            Me.ckbInasistencia.Size = New System.Drawing.Size(138, 17)
            Me.ckbInasistencia.TabIndex = 2
            Me.ckbInasistencia.Text = "Registro de inasistencia"
            Me.ckbInasistencia.UseVisualStyleBackColor = True
            '
            'lblReg
            '
            Me.lblReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReg.Location = New System.Drawing.Point(156, 54)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(127, 20)
            Me.lblReg.TabIndex = 1
            Me.lblReg.Text = "0 Reg. encontrados"
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'ckbSinsalida
            '
            Me.ckbSinsalida.AutoSize = True
            Me.ckbSinsalida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbSinsalida.Location = New System.Drawing.Point(37, 54)
            Me.ckbSinsalida.Name = "ckbSinsalida"
            Me.ckbSinsalida.Size = New System.Drawing.Size(116, 17)
            Me.ckbSinsalida.TabIndex = 0
            Me.ckbSinsalida.Text = "Registros sin salida"
            Me.ckbSinsalida.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label14)
            Me.GroupBox3.Controls.Add(Me.Label13)
            Me.GroupBox3.Controls.Add(Me.dtpFechaFin)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.dtpFechaIni)
            Me.GroupBox3.Controls.Add(Me.cbbTalleres)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(336, 16)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(335, 82)
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(184, 57)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(57, 13)
            Me.Label14.TabIndex = 4
            Me.Label14.Text = "Fecha Fin:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(4, 58)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(68, 13)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Fecha Inicio:"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(244, 54)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 5
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(4, 27)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(88, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Actividad laboral:"
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(94, 54)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 3
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'cbbTalleres
            '
            Me.cbbTalleres._NoIndica = False
            Me.cbbTalleres._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTalleres._Todos = False
            Me.cbbTalleres._TodosMensaje = ""
            Me.cbbTalleres._Visible_Add = False
            Me.cbbTalleres._Visible_Buscar = False
            Me.cbbTalleres._Visible_Eliminar = False
            Me.cbbTalleres.CodigoPadre = -1
            Me.cbbTalleres.ComboTipo = CType(2, Short)
            Me.cbbTalleres.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTalleres.DropDownWidth = 143
            Me.cbbTalleres.DropDownWidthAuto = False
            Me.cbbTalleres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTalleres.ListaIdsParaExcluir = Nothing
            Me.cbbTalleres.Location = New System.Drawing.Point(94, 24)
            Me.cbbTalleres.ModuloTratamiento = False
            Me.cbbTalleres.Name = "cbbTalleres"
            Me.cbbTalleres.Parametro1 = -1
            Me.cbbTalleres.Parametro2 = -1
            Me.cbbTalleres.SelectedIndex = -1
            Me.cbbTalleres.SelectedValue = 0
            Me.cbbTalleres.Size = New System.Drawing.Size(233, 22)
            Me.cbbTalleres.TabIndex = 1
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.txtNombres)
            Me.GroupBox8.Controls.Add(Me.txtApellidos)
            Me.GroupBox8.Controls.Add(Me.Label9)
            Me.GroupBox8.Controls.Add(Me.Label16)
            Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox8.Location = New System.Drawing.Point(3, 16)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(333, 82)
            Me.GroupBox8.TabIndex = 0
            Me.GroupBox8.TabStop = False
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = False
            Me.txtNombres._SeleccionarTodo = True
            Me.txtNombres.Location = New System.Drawing.Point(79, 54)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(248, 20)
            Me.txtNombres.TabIndex = 3
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApellidos
            '
            Me.txtApellidos._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidos._BloquearPaste = False
            Me.txtApellidos._SeleccionarTodo = True
            Me.txtApellidos.Location = New System.Drawing.Point(79, 24)
            Me.txtApellidos.Name = "txtApellidos"
            Me.txtApellidos.Size = New System.Drawing.Size(248, 20)
            Me.txtApellidos.TabIndex = 1
            Me.txtApellidos.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApellidos.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(4, 58)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(67, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "NOMBRES :"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(4, 28)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(72, 13)
            Me.Label16.TabIndex = 0
            Me.Label16.Text = "APELLIDOS :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(3, 98)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(954, 24)
            Me.Panel1.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(28, 1)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(162, 22)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "LISTADO DE ASISTENCIA"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.ToolStrip2)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox1.Location = New System.Drawing.Point(960, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(196, 125)
            Me.GroupBox1.TabIndex = 1
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
            Me.ToolStrip2.Size = New System.Drawing.Size(190, 106)
            Me.ToolStrip2.TabIndex = 0
            Me.ToolStrip2.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.tsbLimpiar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(53, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.pnlRegularizar)
            Me.Panel8.Controls.Add(Me.pnlEliminar)
            Me.Panel8.Controls.Add(Me.pnlExportar)
            Me.Panel8.Controls.Add(Me.pnlImporAsistencia)
            Me.Panel8.Controls.Add(Me.pnlReporte)
            Me.Panel8.Controls.Add(Me.Panel9)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel8.Location = New System.Drawing.Point(0, 391)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(1156, 44)
            Me.Panel8.TabIndex = 2
            '
            'pnlRegularizar
            '
            Me.pnlRegularizar.Controls.Add(Me.btnSuspender)
            Me.pnlRegularizar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlRegularizar.Location = New System.Drawing.Point(657, 0)
            Me.pnlRegularizar.Name = "pnlRegularizar"
            Me.pnlRegularizar.Size = New System.Drawing.Size(120, 44)
            Me.pnlRegularizar.TabIndex = 74
            Me.pnlRegularizar.Visible = False
            '
            'btnSuspender
            '
            Me.btnSuspender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSuspender.Image = Global.SIPPOPE.My.Resources.Resources.up
            Me.btnSuspender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSuspender.Location = New System.Drawing.Point(7, 2)
            Me.btnSuspender.Name = "btnSuspender"
            Me.btnSuspender.Size = New System.Drawing.Size(107, 40)
            Me.btnSuspender.TabIndex = 0
            Me.btnSuspender.Text = "&Justificar Inasistencia"
            Me.btnSuspender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSuspender.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(777, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(97, 44)
            Me.pnlEliminar.TabIndex = 73
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
            Me.btnEliminar.Location = New System.Drawing.Point(3, 2)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(92, 40)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExportar.Location = New System.Drawing.Point(874, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(97, 44)
            Me.pnlExportar.TabIndex = 72
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(4, 2)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(89, 40)
            Me.btnExportar.TabIndex = 0
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlImporAsistencia
            '
            Me.pnlImporAsistencia.Controls.Add(Me.btnImportarAsis)
            Me.pnlImporAsistencia.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlImporAsistencia.Location = New System.Drawing.Point(0, 0)
            Me.pnlImporAsistencia.Name = "pnlImporAsistencia"
            Me.pnlImporAsistencia.Size = New System.Drawing.Size(473, 44)
            Me.pnlImporAsistencia.TabIndex = 0
            '
            'btnImportarAsis
            '
            Me.btnImportarAsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImportarAsis.Image = Global.SIPPOPE.My.Resources.Resources._1316210268_go_bottom
            Me.btnImportarAsis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnImportarAsis.Location = New System.Drawing.Point(4, 2)
            Me.btnImportarAsis.Name = "btnImportarAsis"
            Me.btnImportarAsis.Size = New System.Drawing.Size(110, 40)
            Me.btnImportarAsis.TabIndex = 0
            Me.btnImportarAsis.Text = "&Importar Asistencia"
            Me.btnImportarAsis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnImportarAsis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnImportarAsis, "Permite importar y consolidar las marcaciones de los internos desde la base de da" &
        "tos intermedia temporal.")
            Me.btnImportarAsis.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlReporte.Location = New System.Drawing.Point(971, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(97, 44)
            Me.pnlReporte.TabIndex = 68
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(4, 2)
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
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.dgwListar)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(0, 159)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(1156, 232)
            Me.Panel7.TabIndex = 3
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.cbbPenal)
            Me.Panel2.Controls.Add(Me.Label34)
            Me.Panel2.Controls.Add(Me.Label4)
            Me.Panel2.Controls.Add(Me.cbbRegion)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1156, 34)
            Me.Panel2.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Location = New System.Drawing.Point(0, 31)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(1156, 3)
            Me.Label2.TabIndex = 3
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
            Me.Label34.Size = New System.Drawing.Size(40, 13)
            Me.Label34.TabIndex = 2
            Me.Label34.Text = "Penal :"
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
            'frmControlAsistencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1156, 435)
            Me.Controls.Add(Me.Panel7)
            Me.Controls.Add(Me.Panel6)
            Me.Controls.Add(Me.Panel8)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmControlAsistencia"
            Me.Text = "Control de Asistencia"
            CType(Me.dgwListar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel6.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ToolStrip2.ResumeLayout(False)
            Me.ToolStrip2.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.pnlRegularizar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlImporAsistencia.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents dgwListar As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnImportarAsis As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents pnlImporAsistencia As System.Windows.Forms.Panel
        Friend WithEvents btnSuspender As Button
        Friend WithEvents GroupBox8 As GroupBox
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApellidos As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label9 As Label
        Friend WithEvents Label16 As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label3 As Label
        Friend WithEvents GroupBox4 As GroupBox
        Friend WithEvents lblReg As Label
        Friend WithEvents ckbSinsalida As CheckBox
        Friend WithEvents GroupBox3 As GroupBox
        Friend WithEvents Label14 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents cbbTalleres As APPControls.uscComboParametrica
        Friend WithEvents col_num As DataGridViewTextBoxColumn
        Friend WithEvents col_con_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_con_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_rp As DataGridViewTextBoxColumn
        Friend WithEvents Column8 As DataGridViewTextBoxColumn
        Friend WithEvents col_con_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_con_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_con_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_nac As DataGridViewTextBoxColumn
        Friend WithEvents col_nac_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_tal_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_asi As DataGridViewTextBoxColumn
        Friend WithEvents col_con_hor_ent As DataGridViewTextBoxColumn
        Friend WithEvents col_con_hor_sal As DataGridViewTextBoxColumn
        Friend WithEvents col_con_per As DataGridViewTextBoxColumn
        Friend WithEvents col_jus_id As DataGridViewTextBoxColumn
        Friend WithEvents col_con_obs As DataGridViewTextBoxColumn
        Friend WithEvents pnlRegularizar As Panel
        Friend WithEvents pnlEliminar As Panel
        Friend WithEvents pnlExportar As Panel
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents ckbInasistencia As CheckBox
    End Class
End Namespace