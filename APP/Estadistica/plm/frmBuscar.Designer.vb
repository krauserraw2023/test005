Namespace Estadistica.plm


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscar
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
            Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_correla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mes_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_cor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_env = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_Obs = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pad_ver = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ver_rpt = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pad_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usu_cre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usu_mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.ckbAnulados = New System.Windows.Forms.CheckBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.chkFechaCorte = New System.Windows.Forms.CheckBox()
            Me.dtpFechaCorte = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbbMes = New Legolas.APPUIComponents.uscComboMes()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbProcesado = New System.Windows.Forms.RadioButton()
            Me.rdbEnvSdCentral = New System.Windows.Forms.RadioButton()
            Me.rdbPendiente = New System.Windows.Forms.RadioButton()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.PnlPie = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnFicha = New System.Windows.Forms.Button()
            Me.btnCuadro14 = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnCuadro15 = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnPadinDetalle = New System.Windows.Forms.Button()
            Me.pnlNuevoModificar = New System.Windows.Forms.Panel()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.chkSeleccionar = New System.Windows.Forms.CheckBox()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.PadinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.PnlPie.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlNuevoModificar.SuspendLayout()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle45
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_check, Me.col_id, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom, Me.col_correla, Me.col_anio, Me.col_mes_num, Me.col_mes, Me.col_fec, Me.col_fec_cor, Me.col_fec_pro, Me.col_fec_env, Me.col_est_nom, Me.col_Obs, Me.col_est_id, Me.col_pad_ver, Me.col_ver_rpt, Me.col_pad_col, Me.col_usu_cre, Me.col_usu_mod})
            DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle53
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 147)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle54
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle55
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1020, 306)
            Me.dgwGrilla.TabIndex = 40
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_check
            '
            Me.col_check.HeaderText = ""
            Me.col_check.Name = "col_check"
            Me.col_check.Width = 35
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.DividerWidth = 1
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.Visible = False
            Me.col_id.Width = 75
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "RegionID"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Region"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.Width = 120
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.Visible = False
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.Width = 130
            '
            'col_correla
            '
            Me.col_correla.DataPropertyName = "Numero"
            DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_correla.DefaultCellStyle = DataGridViewCellStyle46
            Me.col_correla.HeaderText = "Correlativo"
            Me.col_correla.Name = "col_correla"
            Me.col_correla.Width = 60
            '
            'col_anio
            '
            Me.col_anio.DataPropertyName = "Anio"
            DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_anio.DefaultCellStyle = DataGridViewCellStyle47
            Me.col_anio.HeaderText = "Año"
            Me.col_anio.Name = "col_anio"
            Me.col_anio.Width = 40
            '
            'col_mes_num
            '
            Me.col_mes_num.DataPropertyName = "Mes"
            Me.col_mes_num.HeaderText = "MesNumero"
            Me.col_mes_num.Name = "col_mes_num"
            Me.col_mes_num.Visible = False
            '
            'col_mes
            '
            Me.col_mes.DataPropertyName = "MesNombre"
            DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_mes.DefaultCellStyle = DataGridViewCellStyle48
            Me.col_mes.HeaderText = "Mes"
            Me.col_mes.Name = "col_mes"
            Me.col_mes.Width = 90
            '
            'col_fec
            '
            Me.col_fec.DataPropertyName = "Fecha"
            DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle49.Format = "d"
            DataGridViewCellStyle49.NullValue = Nothing
            Me.col_fec.DefaultCellStyle = DataGridViewCellStyle49
            Me.col_fec.HeaderText = "Fecha Crea."
            Me.col_fec.Name = "col_fec"
            Me.col_fec.ToolTipText = "F. de Creación"
            Me.col_fec.Visible = False
            Me.col_fec.Width = 75
            '
            'col_fec_cor
            '
            Me.col_fec_cor.DataPropertyName = "FechaCorte"
            DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle50.Format = "d"
            DataGridViewCellStyle50.NullValue = Nothing
            Me.col_fec_cor.DefaultCellStyle = DataGridViewCellStyle50
            Me.col_fec_cor.HeaderText = "F. Corte"
            Me.col_fec_cor.Name = "col_fec_cor"
            Me.col_fec_cor.Width = 75
            '
            'col_fec_pro
            '
            Me.col_fec_pro.DataPropertyName = "FechaProceso"
            DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle51.NullValue = Nothing
            Me.col_fec_pro.DefaultCellStyle = DataGridViewCellStyle51
            Me.col_fec_pro.HeaderText = "F. Proc."
            Me.col_fec_pro.Name = "col_fec_pro"
            Me.col_fec_pro.ToolTipText = "Fecha de Procesamiento"
            Me.col_fec_pro.Width = 120
            '
            'col_fec_env
            '
            Me.col_fec_env.DataPropertyName = "FechaEnvio"
            DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle52.NullValue = Nothing
            Me.col_fec_env.DefaultCellStyle = DataGridViewCellStyle52
            Me.col_fec_env.HeaderText = "F. Envio"
            Me.col_fec_env.Name = "col_fec_env"
            Me.col_fec_env.ToolTipText = "Fecha de Envio a Sede Central"
            Me.col_fec_env.Width = 120
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.Width = 120
            '
            'col_Obs
            '
            Me.col_Obs.DataPropertyName = "ObservacionImg"
            Me.col_Obs.HeaderText = "Obs."
            Me.col_Obs.Name = "col_Obs"
            Me.col_Obs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_Obs.Visible = False
            Me.col_Obs.Width = 35
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "Estado"
            Me.col_est_id.DividerWidth = 1
            Me.col_est_id.HeaderText = "EstadoId"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.Visible = False
            '
            'col_pad_ver
            '
            Me.col_pad_ver.DataPropertyName = "Version"
            Me.col_pad_ver.DividerWidth = 1
            Me.col_pad_ver.HeaderText = "Version"
            Me.col_pad_ver.Name = "col_pad_ver"
            Me.col_pad_ver.Visible = False
            '
            'col_ver_rpt
            '
            Me.col_ver_rpt.DataPropertyName = "VersionReporte"
            Me.col_ver_rpt.HeaderText = "VersionReporte"
            Me.col_ver_rpt.Name = "col_ver_rpt"
            Me.col_ver_rpt.Visible = False
            '
            'col_pad_col
            '
            Me.col_pad_col.DataPropertyName = "PadinColor"
            Me.col_pad_col.DividerWidth = 1
            Me.col_pad_col.HeaderText = "Color"
            Me.col_pad_col.Name = "col_pad_col"
            Me.col_pad_col.Visible = False
            '
            'col_usu_cre
            '
            Me.col_usu_cre.DataPropertyName = "UsuarioCreacion"
            Me.col_usu_cre.HeaderText = "Usuario Creacion"
            Me.col_usu_cre.Name = "col_usu_cre"
            Me.col_usu_cre.Width = 150
            '
            'col_usu_mod
            '
            Me.col_usu_mod.DataPropertyName = "UsuarioModific"
            Me.col_usu_mod.HeaderText = "Usuario Modificacion"
            Me.col_usu_mod.Name = "col_usu_mod"
            Me.col_usu_mod.Width = 150
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Controls.Add(Me.grbBuscar)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1020, 147)
            Me.pnlBusqueda.TabIndex = 42
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.ckbAnulados)
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Controls.Add(Me.grbEstado)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(937, 147)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            '
            'ckbAnulados
            '
            Me.ckbAnulados.AutoSize = True
            Me.ckbAnulados.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbAnulados.Location = New System.Drawing.Point(247, 97)
            Me.ckbAnulados.Name = "ckbAnulados"
            Me.ckbAnulados.Size = New System.Drawing.Size(113, 17)
            Me.ckbAnulados.TabIndex = 24
            Me.ckbAnulados.Text = "Mostrar anulados :"
            Me.ckbAnulados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbAnulados.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.chkFechaCorte)
            Me.Panel1.Controls.Add(Me.dtpFechaCorte)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Label9)
            Me.Panel1.Controls.Add(Me.cbbAnio)
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Controls.Add(Me.cbbMes)
            Me.Panel1.Location = New System.Drawing.Point(2, 60)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(219, 80)
            Me.Panel1.TabIndex = 21
            '
            'chkFechaCorte
            '
            Me.chkFechaCorte.AutoSize = True
            Me.chkFechaCorte.Location = New System.Drawing.Point(81, 58)
            Me.chkFechaCorte.Name = "chkFechaCorte"
            Me.chkFechaCorte.Size = New System.Drawing.Size(15, 14)
            Me.chkFechaCorte.TabIndex = 23
            Me.chkFechaCorte.UseVisualStyleBackColor = True
            '
            'dtpFechaCorte
            '
            Me.dtpFechaCorte.Location = New System.Drawing.Point(122, 55)
            Me.dtpFechaCorte.Name = "dtpFechaCorte"
            Me.dtpFechaCorte.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaCorte.TabIndex = 22
            Me.dtpFechaCorte.Value = "12/12/1985"
            Me.dtpFechaCorte.ValueLong = CType(121476852000000000, Long)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 59)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(68, 13)
            Me.Label1.TabIndex = 21
            Me.Label1.Text = "Fecha Corte:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(7, 33)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(33, 13)
            Me.Label9.TabIndex = 20
            Me.Label9.Text = "Mes :"
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 1900
            Me.cbbAnio.Location = New System.Drawing.Point(80, 4)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(126, 21)
            Me.cbbAnio.TabIndex = 17
            Me.cbbAnio.Value = -1
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(7, 8)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 19
            Me.Label8.Text = "Año :"
            '
            'cbbMes
            '
            Me.cbbMes._Todos = True
            Me.cbbMes.Location = New System.Drawing.Point(80, 29)
            Me.cbbMes.Mes = -1
            Me.cbbMes.MesAbreviatura = False
            Me.cbbMes.Name = "cbbMes"
            Me.cbbMes.Size = New System.Drawing.Size(126, 21)
            Me.cbbMes.TabIndex = 18
            Me.cbbMes.Value = -1
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Controls.Add(Me.cbbPenal)
            Me.Panel3.Controls.Add(Me.Label34)
            Me.Panel3.Controls.Add(Me.Label4)
            Me.Panel3.Controls.Add(Me.cbbRegion)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(931, 39)
            Me.Panel3.TabIndex = 2
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label7.Location = New System.Drawing.Point(0, 36)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(931, 3)
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
            Me.cbbPenal.Location = New System.Drawing.Point(373, 7)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(303, 22)
            Me.cbbPenal.TabIndex = 4
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Location = New System.Drawing.Point(318, 13)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(51, 13)
            Me.Label34.TabIndex = 50
            Me.Label34.Text = "Penales :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(3, 13)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 52
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
            Me.cbbRegion.Location = New System.Drawing.Point(56, 7)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(254, 22)
            Me.cbbRegion.TabIndex = 3
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbTodos)
            Me.grbEstado.Controls.Add(Me.rdbProcesado)
            Me.grbEstado.Controls.Add(Me.rdbEnvSdCentral)
            Me.grbEstado.Controls.Add(Me.rdbPendiente)
            Me.grbEstado.Location = New System.Drawing.Point(246, 57)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(432, 35)
            Me.grbEstado.TabIndex = 5
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Estado"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(353, 14)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodos.TabIndex = 8
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "[Todos]"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbProcesado
            '
            Me.rdbProcesado.AutoSize = True
            Me.rdbProcesado.Location = New System.Drawing.Point(119, 14)
            Me.rdbProcesado.Name = "rdbProcesado"
            Me.rdbProcesado.Size = New System.Drawing.Size(76, 17)
            Me.rdbProcesado.TabIndex = 7
            Me.rdbProcesado.Text = "Procesado"
            Me.rdbProcesado.UseVisualStyleBackColor = True
            '
            'rdbEnvSdCentral
            '
            Me.rdbEnvSdCentral.AutoSize = True
            Me.rdbEnvSdCentral.Location = New System.Drawing.Point(225, 14)
            Me.rdbEnvSdCentral.Name = "rdbEnvSdCentral"
            Me.rdbEnvSdCentral.Size = New System.Drawing.Size(99, 17)
            Me.rdbEnvSdCentral.TabIndex = 10
            Me.rdbEnvSdCentral.Text = "Env a S.Central"
            Me.rdbEnvSdCentral.UseVisualStyleBackColor = True
            '
            'rdbPendiente
            '
            Me.rdbPendiente.AutoSize = True
            Me.rdbPendiente.Location = New System.Drawing.Point(18, 14)
            Me.rdbPendiente.Name = "rdbPendiente"
            Me.rdbPendiente.Size = New System.Drawing.Size(73, 17)
            Me.rdbPendiente.TabIndex = 6
            Me.rdbPendiente.Text = "Pendiente"
            Me.rdbPendiente.UseVisualStyleBackColor = True
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(937, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 147)
            Me.grbBuscar.TabIndex = 38
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 122)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 34
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
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 128)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'PnlPie
            '
            Me.PnlPie.Controls.Add(Me.Panel5)
            Me.PnlPie.Controls.Add(Me.Panel4)
            Me.PnlPie.Controls.Add(Me.pnlReporte)
            Me.PnlPie.Controls.Add(Me.pnlEliminar)
            Me.PnlPie.Controls.Add(Me.Panel2)
            Me.PnlPie.Controls.Add(Me.pnlNuevoModificar)
            Me.PnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlPie.Location = New System.Drawing.Point(0, 453)
            Me.PnlPie.Name = "PnlPie"
            Me.PnlPie.Size = New System.Drawing.Size(1020, 47)
            Me.PnlPie.TabIndex = 41
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.Label3)
            Me.Panel5.Controls.Add(Me.Label2)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel5.Location = New System.Drawing.Point(823, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(167, 47)
            Me.Panel5.TabIndex = 76
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(64, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(87, 13)
            Me.Label3.TabIndex = 78
            Me.Label3.Text = "Registro anulado"
            Me.Label3.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Location = New System.Drawing.Point(3, 14)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(58, 18)
            Me.Label2.TabIndex = 77
            Me.Label2.Visible = False
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnSalir)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel4.Location = New System.Drawing.Point(740, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(83, 47)
            Me.Panel4.TabIndex = 75
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(1, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnFicha)
            Me.pnlReporte.Controls.Add(Me.btnCuadro14)
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Controls.Add(Me.btnCuadro15)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(373, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(367, 47)
            Me.pnlReporte.TabIndex = 72
            '
            'btnFicha
            '
            Me.btnFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFicha.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.Location = New System.Drawing.Point(95, 4)
            Me.btnFicha.Name = "btnFicha"
            Me.btnFicha.Size = New System.Drawing.Size(88, 40)
            Me.btnFicha.TabIndex = 67
            Me.btnFicha.Text = "Reporte F1"
            Me.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnFicha.UseVisualStyleBackColor = True
            '
            'btnCuadro14
            '
            Me.btnCuadro14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCuadro14.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnCuadro14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCuadro14.Location = New System.Drawing.Point(186, 4)
            Me.btnCuadro14.Name = "btnCuadro14"
            Me.btnCuadro14.Size = New System.Drawing.Size(88, 40)
            Me.btnCuadro14.TabIndex = 69
            Me.btnCuadro14.Text = "Cuadro 14"
            Me.btnCuadro14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCuadro14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCuadro14.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(2, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(90, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnCuadro15
            '
            Me.btnCuadro15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCuadro15.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnCuadro15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCuadro15.Location = New System.Drawing.Point(277, 4)
            Me.btnCuadro15.Name = "btnCuadro15"
            Me.btnCuadro15.Size = New System.Drawing.Size(88, 40)
            Me.btnCuadro15.TabIndex = 70
            Me.btnCuadro15.Text = "Cuadro 15"
            Me.btnCuadro15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCuadro15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCuadro15.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(281, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(92, 47)
            Me.pnlEliminar.TabIndex = 73
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(1, 4)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(90, 40)
            Me.btnEliminar.TabIndex = 93
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnPadinDetalle)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(188, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(93, 47)
            Me.Panel2.TabIndex = 74
            '
            'btnPadinDetalle
            '
            Me.btnPadinDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPadinDetalle.Image = CType(resources.GetObject("btnPadinDetalle.Image"), System.Drawing.Image)
            Me.btnPadinDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPadinDetalle.Location = New System.Drawing.Point(1, 4)
            Me.btnPadinDetalle.Name = "btnPadinDetalle"
            Me.btnPadinDetalle.Size = New System.Drawing.Size(90, 40)
            Me.btnPadinDetalle.TabIndex = 68
            Me.btnPadinDetalle.Text = "&Ver Padin"
            Me.btnPadinDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPadinDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnPadinDetalle.UseVisualStyleBackColor = True
            '
            'pnlNuevoModificar
            '
            Me.pnlNuevoModificar.Controls.Add(Me.btnModificar)
            Me.pnlNuevoModificar.Controls.Add(Me.btnNuevo)
            Me.pnlNuevoModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlNuevoModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlNuevoModificar.Name = "pnlNuevoModificar"
            Me.pnlNuevoModificar.Size = New System.Drawing.Size(188, 47)
            Me.pnlNuevoModificar.TabIndex = 71
            Me.pnlNuevoModificar.Visible = False
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.Location = New System.Drawing.Point(96, 4)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(3, 4)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(90, 40)
            Me.btnNuevo.TabIndex = 63
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'chkSeleccionar
            '
            Me.chkSeleccionar.AutoSize = True
            Me.chkSeleccionar.Location = New System.Drawing.Point(10, 151)
            Me.chkSeleccionar.Name = "chkSeleccionar"
            Me.chkSeleccionar.Size = New System.Drawing.Size(15, 14)
            Me.chkSeleccionar.TabIndex = 43
            Me.chkSeleccionar.UseVisualStyleBackColor = True
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.EgresosToolStripMenuItem, Me.PadinToolStripMenuItem})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 70)
            '
            'PadinToolStripMenuItem
            '
            Me.PadinToolStripMenuItem.Name = "PadinToolStripMenuItem"
            Me.PadinToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.PadinToolStripMenuItem.Text = "Padin"
            '
            'IngresosToolStripMenuItem
            '
            Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
            Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.IngresosToolStripMenuItem.Text = "Ingresos"
            '
            'EgresosToolStripMenuItem
            '
            Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
            Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.EgresosToolStripMenuItem.Text = "Egresos"
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1020, 500)
            Me.Controls.Add(Me.chkSeleccionar)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.PnlPie)
            Me.Name = "frmBuscar"
            Me.Text = "Padin - Lima Metropolitana"
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.PnlPie.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlNuevoModificar.ResumeLayout(False)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents PnlPie As System.Windows.Forms.Panel
        Friend WithEvents btnFicha As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbProcesado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPendiente As System.Windows.Forms.RadioButton
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnPadinDetalle As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cbbMes As Legolas.APPUIComponents.uscComboMes
        Friend WithEvents btnCuadro14 As System.Windows.Forms.Button
        Friend WithEvents btnCuadro15 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaCorte As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents chkFechaCorte As System.Windows.Forms.CheckBox
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents pnlNuevoModificar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents rdbEnvSdCentral As System.Windows.Forms.RadioButton
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ckbAnulados As System.Windows.Forms.CheckBox
        Friend WithEvents chkSeleccionar As System.Windows.Forms.CheckBox
        Friend WithEvents col_check As DataGridViewCheckBoxColumn
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_correla As DataGridViewTextBoxColumn
        Friend WithEvents col_anio As DataGridViewTextBoxColumn
        Friend WithEvents col_mes_num As DataGridViewTextBoxColumn
        Friend WithEvents col_mes As DataGridViewTextBoxColumn
        Friend WithEvents col_fec As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_cor As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_pro As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_env As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_Obs As DataGridViewImageColumn
        Friend WithEvents col_est_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pad_ver As DataGridViewTextBoxColumn
        Friend WithEvents col_ver_rpt As DataGridViewTextBoxColumn
        Friend WithEvents col_pad_col As DataGridViewTextBoxColumn
        Friend WithEvents col_usu_cre As DataGridViewTextBoxColumn
        Friend WithEvents col_usu_mod As DataGridViewTextBoxColumn
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents PadinToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents EgresosToolStripMenuItem As ToolStripMenuItem
    End Class
End Namespace