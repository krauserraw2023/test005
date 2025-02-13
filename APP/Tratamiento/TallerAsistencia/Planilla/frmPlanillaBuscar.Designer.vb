Namespace Tratamiento.TallerAsistencia.Planilla

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPlanillaBuscar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaBuscar))
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbMes = New Legolas.APPUIComponents.uscComboMes()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnPadinDetalle = New System.Windows.Forms.Button()
            Me.pnlNuevo = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_correla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mes_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tal_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pab_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_Obs = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usu_cre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usu_mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbTalleres = New APPControls.uscComboParametrica()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.ckbAnulado = New System.Windows.Forms.CheckBox()
            Me.gbEstado = New System.Windows.Forms.GroupBox()
            Me.rbtProcesados = New System.Windows.Forms.RadioButton()
            Me.rbtTerminados = New System.Windows.Forms.RadioButton()
            Me.rbtTodos = New System.Windows.Forms.RadioButton()
            Me.Panel6.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.ToolStrip2.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlNuevo.SuspendLayout()
            Me.Panel7.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.gbEstado.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.grbEstado)
            Me.Panel6.Controls.Add(Me.GroupBox3)
            Me.Panel6.Controls.Add(Me.GroupBox1)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(0, 34)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(1156, 124)
            Me.Panel6.TabIndex = 0
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.gbEstado)
            Me.grbEstado.Controls.Add(Me.ckbAnulado)
            Me.grbEstado.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbEstado.Location = New System.Drawing.Point(327, 0)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(703, 124)
            Me.grbEstado.TabIndex = 23
            Me.grbEstado.TabStop = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.cbbAnio)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.cbbMes)
            Me.GroupBox3.Controls.Add(Me.Label9)
            Me.GroupBox3.Controls.Add(Me.Label8)
            Me.GroupBox3.Controls.Add(Me.cbbTalleres)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(327, 124)
            Me.GroupBox3.TabIndex = 24
            Me.GroupBox3.TabStop = False
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 1900
            Me.cbbAnio.Location = New System.Drawing.Point(104, 45)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(207, 21)
            Me.cbbAnio.TabIndex = 17
            Me.cbbAnio.Value = -1
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(6, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(96, 13)
            Me.Label6.TabIndex = 21
            Me.Label6.Text = "ACTIVIDAD LAB. :"
            '
            'cbbMes
            '
            Me.cbbMes._Todos = True
            Me.cbbMes.Location = New System.Drawing.Point(104, 74)
            Me.cbbMes.Mes = -1
            Me.cbbMes.MesAbreviatura = False
            Me.cbbMes.Name = "cbbMes"
            Me.cbbMes.Size = New System.Drawing.Size(207, 21)
            Me.cbbMes.TabIndex = 18
            Me.cbbMes.Value = -1
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(7, 78)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(36, 13)
            Me.Label9.TabIndex = 20
            Me.Label9.Text = "MES :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(7, 49)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(36, 13)
            Me.Label8.TabIndex = 19
            Me.Label8.Text = "AÑO :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblReg)
            Me.GroupBox1.Controls.Add(Me.ToolStrip2)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox1.Location = New System.Drawing.Point(1030, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(126, 124)
            Me.GroupBox1.TabIndex = 21
            Me.GroupBox1.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 108)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(120, 13)
            Me.lblReg.TabIndex = 25
            Me.lblReg.Text = "0 Reg. encontrados"
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            Me.ToolStrip2.Size = New System.Drawing.Size(120, 105)
            Me.ToolStrip2.TabIndex = 0
            Me.ToolStrip2.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(118, 42)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(118, 42)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.Panel9)
            Me.Panel8.Controls.Add(Me.pnlEliminar)
            Me.Panel8.Controls.Add(Me.pnlReporte)
            Me.Panel8.Controls.Add(Me.pnlGrabar)
            Me.Panel8.Controls.Add(Me.pnlNuevo)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel8.Location = New System.Drawing.Point(0, 334)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(1156, 44)
            Me.Panel8.TabIndex = 2
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.btnSalir)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel9.Location = New System.Drawing.Point(501, 0)
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
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(401, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(100, 44)
            Me.pnlEliminar.TabIndex = 73
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEliminar.Location = New System.Drawing.Point(3, 2)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(91, 40)
            Me.btnEliminar.TabIndex = 67
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(200, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(201, 44)
            Me.pnlReporte.TabIndex = 68
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(7, 3)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 66
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnReporte
            '
            Me.btnReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(102, 2)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 40)
            Me.btnReporte.TabIndex = 1
            Me.btnReporte.Text = "&Reportes"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnPadinDetalle)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGrabar.Location = New System.Drawing.Point(100, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(100, 44)
            Me.pnlGrabar.TabIndex = 70
            Me.pnlGrabar.Visible = False
            '
            'btnPadinDetalle
            '
            Me.btnPadinDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPadinDetalle.Image = CType(resources.GetObject("btnPadinDetalle.Image"), System.Drawing.Image)
            Me.btnPadinDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPadinDetalle.Location = New System.Drawing.Point(6, 2)
            Me.btnPadinDetalle.Name = "btnPadinDetalle"
            Me.btnPadinDetalle.Size = New System.Drawing.Size(90, 40)
            Me.btnPadinDetalle.TabIndex = 69
            Me.btnPadinDetalle.Text = "&Ver Planilla"
            Me.btnPadinDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPadinDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnPadinDetalle.UseVisualStyleBackColor = True
            '
            'pnlNuevo
            '
            Me.pnlNuevo.Controls.Add(Me.btnNuevo)
            Me.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlNuevo.Location = New System.Drawing.Point(0, 0)
            Me.pnlNuevo.Name = "pnlNuevo"
            Me.pnlNuevo.Size = New System.Drawing.Size(100, 44)
            Me.pnlNuevo.TabIndex = 72
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(3, 2)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(90, 40)
            Me.btnNuevo.TabIndex = 71
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.dgwGrilla)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(0, 158)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(1156, 176)
            Me.Panel7.TabIndex = 3
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom, Me.col_correla, Me.col_anio, Me.col_mes_num, Me.col_mes, Me.col_tal_nom, Me.col_pab_nom, Me.col_fec, Me.col_fec_pro, Me.col_est_nom, Me.col_Obs, Me.col_est_id, Me.col_usu_cre, Me.col_usu_mod})
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle18
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1156, 176)
            Me.dgwGrilla.TabIndex = 41
            Me.dgwGrilla.VisibleCampos = False
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
            Me.col_correla.DataPropertyName = "Correlativo"
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_correla.DefaultCellStyle = DataGridViewCellStyle11
            Me.col_correla.HeaderText = "Correlativo"
            Me.col_correla.Name = "col_correla"
            Me.col_correla.Width = 60
            '
            'col_anio
            '
            Me.col_anio.DataPropertyName = "Anio"
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_anio.DefaultCellStyle = DataGridViewCellStyle12
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
            Me.col_mes.DataPropertyName = "NombreMes"
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_mes.DefaultCellStyle = DataGridViewCellStyle13
            Me.col_mes.HeaderText = "Mes"
            Me.col_mes.Name = "col_mes"
            Me.col_mes.Width = 90
            '
            'col_tal_nom
            '
            Me.col_tal_nom.DataPropertyName = "TallerNombre"
            Me.col_tal_nom.HeaderText = "Taller"
            Me.col_tal_nom.Name = "col_tal_nom"
            Me.col_tal_nom.Width = 150
            '
            'col_pab_nom
            '
            Me.col_pab_nom.DataPropertyName = "Pabellon"
            Me.col_pab_nom.HeaderText = "Pabellon"
            Me.col_pab_nom.Name = "col_pab_nom"
            Me.col_pab_nom.Visible = False
            '
            'col_fec
            '
            Me.col_fec.DataPropertyName = "Fecha"
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.Format = "d"
            DataGridViewCellStyle14.NullValue = Nothing
            Me.col_fec.DefaultCellStyle = DataGridViewCellStyle14
            Me.col_fec.HeaderText = "Fecha Crea."
            Me.col_fec.Name = "col_fec"
            Me.col_fec.ToolTipText = "F. de Creación"
            Me.col_fec.Visible = False
            Me.col_fec.Width = 75
            '
            'col_fec_pro
            '
            Me.col_fec_pro.DataPropertyName = "FechaProceso"
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.NullValue = Nothing
            Me.col_fec_pro.DefaultCellStyle = DataGridViewCellStyle15
            Me.col_fec_pro.HeaderText = "F. Proc."
            Me.col_fec_pro.Name = "col_fec_pro"
            Me.col_fec_pro.ToolTipText = "Fecha de Procesamiento"
            Me.col_fec_pro.Width = 120
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
            'col_usu_cre
            '
            Me.col_usu_cre.DataPropertyName = "Audit_UsuarioCreacion"
            Me.col_usu_cre.HeaderText = "Usuario Creacion"
            Me.col_usu_cre.Name = "col_usu_cre"
            Me.col_usu_cre.Width = 200
            '
            'col_usu_mod
            '
            Me.col_usu_mod.DataPropertyName = "Audit_UsuarioModificacion"
            Me.col_usu_mod.HeaderText = "Usuario Modificacion"
            Me.col_usu_mod.Name = "col_usu_mod"
            Me.col_usu_mod.Width = 200
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
            Me.Panel2.TabIndex = 41
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Location = New System.Drawing.Point(0, 31)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(1156, 3)
            Me.Label2.TabIndex = 58
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
            Me.cbbTalleres.Location = New System.Drawing.Point(104, 15)
            Me.cbbTalleres.ModuloTratamiento = False
            Me.cbbTalleres.Name = "cbbTalleres"
            Me.cbbTalleres.Parametro1 = -1
            Me.cbbTalleres.Parametro2 = -1
            Me.cbbTalleres.SelectedIndex = -1
            Me.cbbTalleres.SelectedValue = 0
            Me.cbbTalleres.Size = New System.Drawing.Size(207, 22)
            Me.cbbTalleres.TabIndex = 161
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
            'ckbAnulado
            '
            Me.ckbAnulado.AutoSize = True
            Me.ckbAnulado.Location = New System.Drawing.Point(233, 91)
            Me.ckbAnulado.Name = "ckbAnulado"
            Me.ckbAnulado.Size = New System.Drawing.Size(65, 17)
            Me.ckbAnulado.TabIndex = 29
            Me.ckbAnulado.Text = "Anulado"
            Me.ckbAnulado.UseVisualStyleBackColor = True
            '
            'gbEstado
            '
            Me.gbEstado.Controls.Add(Me.rbtTodos)
            Me.gbEstado.Controls.Add(Me.rbtTerminados)
            Me.gbEstado.Controls.Add(Me.rbtProcesados)
            Me.gbEstado.Dock = System.Windows.Forms.DockStyle.Left
            Me.gbEstado.Location = New System.Drawing.Point(3, 16)
            Me.gbEstado.Name = "gbEstado"
            Me.gbEstado.Size = New System.Drawing.Size(215, 105)
            Me.gbEstado.TabIndex = 30
            Me.gbEstado.TabStop = False
            Me.gbEstado.Text = "Estado"
            '
            'rbtProcesados
            '
            Me.rbtProcesados.AutoSize = True
            Me.rbtProcesados.Location = New System.Drawing.Point(48, 19)
            Me.rbtProcesados.Name = "rbtProcesados"
            Me.rbtProcesados.Size = New System.Drawing.Size(76, 17)
            Me.rbtProcesados.TabIndex = 0
            Me.rbtProcesados.Text = "Procesado"
            Me.rbtProcesados.UseVisualStyleBackColor = True
            '
            'rbtTerminados
            '
            Me.rbtTerminados.AutoSize = True
            Me.rbtTerminados.Location = New System.Drawing.Point(49, 47)
            Me.rbtTerminados.Name = "rbtTerminados"
            Me.rbtTerminados.Size = New System.Drawing.Size(75, 17)
            Me.rbtTerminados.TabIndex = 1
            Me.rbtTerminados.Text = "Terminado"
            Me.rbtTerminados.UseVisualStyleBackColor = True
            '
            'rbtTodos
            '
            Me.rbtTodos.AutoSize = True
            Me.rbtTodos.Checked = True
            Me.rbtTodos.Location = New System.Drawing.Point(50, 74)
            Me.rbtTodos.Name = "rbtTodos"
            Me.rbtTodos.Size = New System.Drawing.Size(55, 17)
            Me.rbtTodos.TabIndex = 2
            Me.rbtTodos.TabStop = True
            Me.rbtTodos.Text = "Todos"
            Me.rbtTodos.UseVisualStyleBackColor = True
            '
            'frmPlanillaBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1156, 378)
            Me.Controls.Add(Me.Panel7)
            Me.Controls.Add(Me.Panel6)
            Me.Controls.Add(Me.Panel8)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmPlanillaBuscar"
            Me.Text = "Planilla Asistencia"
            Me.Panel6.ResumeLayout(False)
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ToolStrip2.ResumeLayout(False)
            Me.ToolStrip2.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlNuevo.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.gbEstado.ResumeLayout(False)
            Me.gbEstado.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Public WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cbbMes As Legolas.APPUIComponents.uscComboMes
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents btnPadinDetalle As System.Windows.Forms.Button
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlNuevo As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents cbbTalleres As APPControls.uscComboParametrica
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_correla As DataGridViewTextBoxColumn
        Friend WithEvents col_anio As DataGridViewTextBoxColumn
        Friend WithEvents col_mes_num As DataGridViewTextBoxColumn
        Friend WithEvents col_mes As DataGridViewTextBoxColumn
        Friend WithEvents col_tal_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pab_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_fec As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_pro As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_Obs As DataGridViewImageColumn
        Friend WithEvents col_est_id As DataGridViewTextBoxColumn
        Friend WithEvents col_usu_cre As DataGridViewTextBoxColumn
        Friend WithEvents col_usu_mod As DataGridViewTextBoxColumn
        Friend WithEvents gbEstado As GroupBox
        Friend WithEvents rbtTodos As RadioButton
        Friend WithEvents rbtTerminados As RadioButton
        Friend WithEvents rbtProcesados As RadioButton
        Friend WithEvents ckbAnulado As CheckBox
    End Class
End Namespace