Namespace Visita.Etapa


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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbEtapa = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.MyComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtInteApe = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
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
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlBusqueda.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.cbbEtapa.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel6.SuspendLayout()
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
            Me.pnlBusqueda.Size = New System.Drawing.Size(851, 123)
            Me.pnlBusqueda.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox7)
            Me.Panel1.Controls.Add(Me.GroupBox6)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(768, 123)
            Me.Panel1.TabIndex = 41
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbEtapa)
            Me.GroupBox1.Location = New System.Drawing.Point(284, 47)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(241, 71)
            Me.GroupBox1.TabIndex = 63
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Etapa"
            '
            'cbbEtapa
            '
            Me.cbbEtapa._NoIndica = True
            Me.cbbEtapa._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbEtapa._Todos = True
            Me.cbbEtapa._TodosMensaje = ""
            Me.cbbEtapa._Visible_Add = False
            Me.cbbEtapa._Visible_Buscar = False
            Me.cbbEtapa._Visible_Eliminar = False
            Me.cbbEtapa.CodigoPadre = -1
            Me.cbbEtapa.ComboTipo = CType(0, Short)
            Me.cbbEtapa.Controls.Add(Me.ComboBox1)
            Me.cbbEtapa.Controls.Add(Me.MyComboBox1)
            Me.cbbEtapa.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbEtapa.DropDownWidth = 178
            Me.cbbEtapa.DropDownWidthAuto = False
            Me.cbbEtapa.ListaIdsParaExcluir = Nothing
            Me.cbbEtapa.Location = New System.Drawing.Point(6, 16)
            Me.cbbEtapa.ModuloTratamiento = False
            Me.cbbEtapa.Name = "cbbEtapa"
            Me.cbbEtapa.Parametro1 = -1
            Me.cbbEtapa.Parametro2 = -1
            Me.cbbEtapa.SelectedIndex = -1
            Me.cbbEtapa.SelectedValue = 0
            Me.cbbEtapa.Size = New System.Drawing.Size(228, 22)
            Me.cbbEtapa.TabIndex = 59
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 178
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(228, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'MyComboBox1
            '
            Me.MyComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox1.DropDownWidth = 178
            Me.MyComboBox1.FormattingEnabled = True
            Me.MyComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox1.Name = "MyComboBox1"
            Me.MyComboBox1.Size = New System.Drawing.Size(228, 21)
            Me.MyComboBox1.TabIndex = 2
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.txtNom)
            Me.GroupBox7.Controls.Add(Me.Label3)
            Me.GroupBox7.Controls.Add(Me.txtInteApe)
            Me.GroupBox7.Controls.Add(Me.Label1)
            Me.GroupBox7.Location = New System.Drawing.Point(6, 47)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(272, 71)
            Me.GroupBox7.TabIndex = 62
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Interno :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(71, 41)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(190, 20)
            Me.txtNom.TabIndex = 32
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 45)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "Nombres :"
            '
            'txtInteApe
            '
            Me.txtInteApe._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtInteApe._BloquearPaste = False
            Me.txtInteApe._SeleccionarTodo = False
            Me.txtInteApe.Location = New System.Drawing.Point(71, 15)
            Me.txtInteApe.Name = "txtInteApe"
            Me.txtInteApe.Size = New System.Drawing.Size(190, 20)
            Me.txtInteApe.TabIndex = 29
            Me.txtInteApe.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtInteApe.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 13)
            Me.Label1.TabIndex = 30
            Me.Label1.Text = "Apellidos :"
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.rdbEstadoTodos)
            Me.GroupBox6.Controls.Add(Me.rdbInactivo)
            Me.GroupBox6.Controls.Add(Me.rdbActivo)
            Me.GroupBox6.Location = New System.Drawing.Point(531, 47)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(231, 71)
            Me.GroupBox6.TabIndex = 61
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Estado"
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(157, 17)
            Me.rdbEstadoTodos.Name = "rdbEstadoTodos"
            Me.rdbEstadoTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbEstadoTodos.TabIndex = 2
            Me.rdbEstadoTodos.Text = "[Todos]"
            Me.rdbEstadoTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Location = New System.Drawing.Point(84, 18)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rdbInactivo.TabIndex = 1
            Me.rdbInactivo.Text = "Inactivo"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Checked = True
            Me.rdbActivo.Location = New System.Drawing.Point(13, 18)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(55, 17)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.TabStop = True
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
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(517, 22)
            Me.UsrRegionPenal1.TabIndex = 41
            Me.UsrRegionPenal1.WidthRegion = 224
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
            Me.GroupBox3.Size = New System.Drawing.Size(83, 123)
            Me.GroupBox3.TabIndex = 40
            Me.GroupBox3.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 98)
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 104)
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
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_reg_nom, Me.col_pen_nom, Me.Column1, Me.Column2, Me.Column3, Me.col_fec_reg, Me.Column6, Me.col_reg_id, Me.col_pen_id})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 123)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(851, 308)
            Me.dgwGrilla.TabIndex = 1
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "CodigoID"
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
            'Column1
            '
            Me.Column1.DataPropertyName = "InternoApeNom"
            Me.Column1.HeaderText = "Interno"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 200
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "EtapaNombre"
            Me.Column2.HeaderText = "Etapa"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Documento"
            Me.Column3.HeaderText = "Documento"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            '
            'col_fec_reg
            '
            Me.col_fec_reg.DataPropertyName = "FechaRegistro"
            DataGridViewCellStyle2.Format = "d"
            Me.col_fec_reg.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fec_reg.HeaderText = "Fecha Reg."
            Me.col_fec_reg.Name = "col_fec_reg"
            Me.col_fec_reg.ReadOnly = True
            Me.col_fec_reg.Width = 90
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "EstadoNombre"
            Me.Column6.HeaderText = "Estado"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Width = 70
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
            Me.Panel2.Controls.Add(Me.Panel6)
            Me.Panel2.Controls.Add(Me.pnlExportar)
            Me.Panel2.Controls.Add(Me.pnlModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 431)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(851, 49)
            Me.Panel2.TabIndex = 40
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnSalir)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel6.Location = New System.Drawing.Point(281, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(89, 49)
            Me.Panel6.TabIndex = 93
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(5, 3)
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
            Me.pnlExportar.Location = New System.Drawing.Point(188, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(93, 49)
            Me.pnlExportar.TabIndex = 92
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(2, 3)
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
            Me.pnlModificar.Controls.Add(Me.btnEliminar)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(188, 49)
            Me.pnlModificar.TabIndex = 91
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(3, 3)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 40)
            Me.btnNuevo.TabIndex = 63
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnEliminar.Location = New System.Drawing.Point(96, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(88, 40)
            Me.btnEliminar.TabIndex = 90
            Me.btnEliminar.Text = "&Anular"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
            Me.Text = "Busqueda de Etapas del Interno"
            Me.pnlBusqueda.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.cbbEtapa.ResumeLayout(False)
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbEstadoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbEtapa As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtInteApe As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
    End Class
End Namespace