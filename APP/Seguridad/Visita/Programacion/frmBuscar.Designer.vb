Namespace Visita.Programacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.cbbTipoVisita = New APPControls.uscComboParametrica()
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.rdbEstadoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbInactivo = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_vis_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_vis = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_vis_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCalendario = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.pnlBusqueda.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.cbbTipoVisita.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.pnlBusqueda.Controls.Add(Me.Panel1)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox3)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(851, 120)
            Me.pnlBusqueda.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.GroupBox7)
            Me.Panel1.Controls.Add(Me.GroupBox6)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(768, 120)
            Me.Panel1.TabIndex = 41
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.cbbTipoVisita)
            Me.GroupBox7.Location = New System.Drawing.Point(6, 47)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(236, 45)
            Me.GroupBox7.TabIndex = 62
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Regimen de Visita"
            '
            'cbbTipoVisita
            '
            Me.cbbTipoVisita._NoIndica = True
            Me.cbbTipoVisita._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoVisita._Todos = True
            Me.cbbTipoVisita._TodosMensaje = ""
            Me.cbbTipoVisita._Visible_Add = False
            Me.cbbTipoVisita._Visible_Buscar = False
            Me.cbbTipoVisita._Visible_Eliminar = False
            Me.cbbTipoVisita.CodigoPadre = -1
            Me.cbbTipoVisita.ComboTipo = CType(0, Short)
            Me.cbbTipoVisita.Controls.Add(Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde)
            Me.cbbTipoVisita.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoVisita.DropDownWidth = 178
            Me.cbbTipoVisita.DropDownWidthAuto = False
            Me.cbbTipoVisita.ListaIdsParaExcluir = Nothing
            Me.cbbTipoVisita.Location = New System.Drawing.Point(6, 16)
            Me.cbbTipoVisita.ModuloTratamiento = False
            Me.cbbTipoVisita.Name = "cbbTipoVisita"
            Me.cbbTipoVisita.Parametro1 = -1
            Me.cbbTipoVisita.Parametro2 = -1
            Me.cbbTipoVisita.SelectedIndex = -1
            Me.cbbTipoVisita.SelectedValue = 0
            Me.cbbTipoVisita.Size = New System.Drawing.Size(228, 22)
            Me.cbbTipoVisita.TabIndex = 59
            Me.cbbTipoVisita.verToolTipItemSeleccionado = False
            '
            'object_ea02f74d_e215_43b2_94f3_b14145a78cde
            '
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.DropDownWidth = 178
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.FormattingEnabled = True
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.Location = New System.Drawing.Point(0, 0)
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.Name = "object_ea02f74d_e215_43b2_94f3_b14145a78cde"
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.Size = New System.Drawing.Size(228, 21)
            Me.object_ea02f74d_e215_43b2_94f3_b14145a78cde.TabIndex = 2
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.rdbEstadoTodos)
            Me.GroupBox6.Controls.Add(Me.rdbInactivo)
            Me.GroupBox6.Controls.Add(Me.rdbActivo)
            Me.GroupBox6.Location = New System.Drawing.Point(280, 47)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(241, 45)
            Me.GroupBox6.TabIndex = 61
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Estado"
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Checked = True
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(146, 17)
            Me.rdbEstadoTodos.Name = "rdbEstadoTodos"
            Me.rdbEstadoTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbEstadoTodos.TabIndex = 2
            Me.rdbEstadoTodos.TabStop = True
            Me.rdbEstadoTodos.Text = "[Todos]"
            Me.rdbEstadoTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Location = New System.Drawing.Point(77, 18)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rdbInactivo.TabIndex = 1
            Me.rdbInactivo.Text = "Inactivo"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Location = New System.Drawing.Point(6, 18)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(55, 17)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.UsrRegionPenal1)
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(768, 41)
            Me.Panel3.TabIndex = 59
            '
            'UsrRegionPenal1
            '
            Me.UsrRegionPenal1._LicenciaID = -1
            Me.UsrRegionPenal1._NivelUsuario = CType(-1, Short)
            Me.UsrRegionPenal1._PenalID = 0
            Me.UsrRegionPenal1._PenalTodos = True
            Me.UsrRegionPenal1._PerfilUsuario = CType(-1, Short)
            Me.UsrRegionPenal1._RegionID = 0
            Me.UsrRegionPenal1._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Usuario
            Me.UsrRegionPenal1._UsuarioID = -1
            Me.UsrRegionPenal1._WidthLabelRegion = 47
            Me.UsrRegionPenal1.BackColor = System.Drawing.Color.Transparent
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(1, 8)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(520, 22)
            Me.UsrRegionPenal1.TabIndex = 41
            Me.UsrRegionPenal1.WidthRegion = 240
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label7.Location = New System.Drawing.Point(0, 38)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(768, 3)
            Me.Label7.TabIndex = 58
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.lblReg)
            Me.GroupBox3.Controls.Add(Me.ToolStrip1)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox3.Location = New System.Drawing.Point(768, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(83, 120)
            Me.GroupBox3.TabIndex = 40
            Me.GroupBox3.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 95)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 101)
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
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_reg_nom, Me.col_pen_nom, Me.col_reg_vis_id, Me.col_reg_vis_nom, Me.col_tip_vis, Me.col_tip_vis_nom, Me.col_fec_ini, Me.Column6, Me.col_reg_id, Me.col_pen_id})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 120)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(851, 311)
            Me.dgwGrilla.TabIndex = 1
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "CalendarioID"
            Me.col_id.HeaderText = "CalendarioID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Region"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Width = 200
            '
            'col_reg_vis_id
            '
            Me.col_reg_vis_id.DataPropertyName = "RegimenVisitaID"
            Me.col_reg_vis_id.HeaderText = "RegimenVisitaID"
            Me.col_reg_vis_id.Name = "col_reg_vis_id"
            Me.col_reg_vis_id.ReadOnly = True
            Me.col_reg_vis_id.Visible = False
            '
            'col_reg_vis_nom
            '
            Me.col_reg_vis_nom.DataPropertyName = "RegimenVisita"
            Me.col_reg_vis_nom.HeaderText = "Reg. Visita"
            Me.col_reg_vis_nom.Name = "col_reg_vis_nom"
            Me.col_reg_vis_nom.ReadOnly = True
            Me.col_reg_vis_nom.Width = 150
            '
            'col_tip_vis
            '
            Me.col_tip_vis.DataPropertyName = "VisitaTipoID"
            Me.col_tip_vis.HeaderText = "VisitaTipoID"
            Me.col_tip_vis.Name = "col_tip_vis"
            Me.col_tip_vis.ReadOnly = True
            Me.col_tip_vis.Visible = False
            '
            'col_tip_vis_nom
            '
            Me.col_tip_vis_nom.DataPropertyName = "VisitaTipo"
            Me.col_tip_vis_nom.HeaderText = "Tipo Visita"
            Me.col_tip_vis_nom.Name = "col_tip_vis_nom"
            Me.col_tip_vis_nom.ReadOnly = True
            Me.col_tip_vis_nom.Width = 150
            '
            'col_fec_ini
            '
            Me.col_fec_ini.DataPropertyName = "FechaRegistro"
            DataGridViewCellStyle1.Format = "d"
            Me.col_fec_ini.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_ini.HeaderText = "Fec. Registro"
            Me.col_fec_ini.Name = "col_fec_ini"
            Me.col_fec_ini.ReadOnly = True
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "EstadoNombre"
            Me.Column6.HeaderText = "Estado"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.HeaderText = "RegionID"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCalendario)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Controls.Add(Me.pnlExportar)
            Me.Panel2.Controls.Add(Me.pnlModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 431)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(851, 49)
            Me.Panel2.TabIndex = 40
            '
            'btnCalendario
            '
            Me.btnCalendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCalendario.Image = Global.SIPPOPE.My.Resources.Resources.Calendar_32
            Me.btnCalendario.Location = New System.Drawing.Point(381, -2)
            Me.btnCalendario.Name = "btnCalendario"
            Me.btnCalendario.Size = New System.Drawing.Size(88, 53)
            Me.btnCalendario.TabIndex = 70
            Me.btnCalendario.Text = "&Calendario"
            Me.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnCalendario.UseVisualStyleBackColor = True
            Me.btnCalendario.Visible = False
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSalir.Location = New System.Drawing.Point(277, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(95, 49)
            Me.pnlSalir.TabIndex = 69
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(3, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlExportar.Location = New System.Drawing.Point(184, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(93, 49)
            Me.pnlExportar.TabIndex = 68
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(3, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnNuevo)
            Me.pnlModificar.Controls.Add(Me.btnModificar)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(184, 49)
            Me.pnlModificar.TabIndex = 67
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(3, 5)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 40)
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
            Me.btnModificar.Location = New System.Drawing.Point(94, 5)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 40)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(851, 480)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Name = "frmBuscar"
            Me.Text = "Horario"
            Me.pnlBusqueda.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox7.ResumeLayout(False)
            Me.cbbTipoVisita.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbTipoVisita As APPControls.uscComboParametrica
        Friend WithEvents object_ea02f74d_e215_43b2_94f3_b14145a78cde As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbEstadoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
        Friend WithEvents btnCalendario As System.Windows.Forms.Button
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_vis_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_vis_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_vis As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_vis_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace