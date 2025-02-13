
Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscar
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_usu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_log = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_fec_cre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnRestaurar = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbBaja = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cbbNivelUsuario = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.cbbDependencia = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApellidos = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtUsuario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToOrderColumns = True
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_usu_id, Me.col_log, Me.col_ape, Me.col_nom, Me.col_cor, Me.Column3, Me.Column2, Me.Column4, Me.Column5, Me.col_fec_cre, Me.col_fec_mod, Me.Column1})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 134)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(861, 252)
            Me.dgwGrilla.TabIndex = 39
            Me.dgwGrilla.VisibleCampos = True
            '
            'col_usu_id
            '
            Me.col_usu_id.DataPropertyName = "Codigo"
            Me.col_usu_id.HeaderText = "UsuarioID"
            Me.col_usu_id.Name = "col_usu_id"
            Me.col_usu_id.ReadOnly = True
            Me.col_usu_id.Visible = False
            '
            'col_log
            '
            Me.col_log.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_log.DataPropertyName = "Login"
            Me.col_log.HeaderText = "Login"
            Me.col_log.Name = "col_log"
            Me.col_log.ReadOnly = True
            Me.col_log.Width = 85
            '
            'col_ape
            '
            Me.col_ape.DataPropertyName = "ApellidosReadonly"
            Me.col_ape.HeaderText = "Apellidos"
            Me.col_ape.Name = "col_ape"
            Me.col_ape.ReadOnly = True
            Me.col_ape.Width = 150
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 120
            '
            'col_cor
            '
            Me.col_cor.DataPropertyName = "Correo"
            Me.col_cor.HeaderText = "Correo"
            Me.col_cor.Name = "col_cor"
            Me.col_cor.ReadOnly = True
            Me.col_cor.Width = 120
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "NivelUsuarioNombre"
            Me.Column3.HeaderText = "Nivel Usuario"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 150
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "DependenciaNombre"
            Me.Column2.HeaderText = "Oficina/Perfil"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 300
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "Clave"
            Me.Column4.HeaderText = "Clave"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Visible = False
            Me.Column4.Width = 50
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "ClaveNueva"
            Me.Column5.HeaderText = "Clave Rest."
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Column5.Width = 85
            '
            'col_fec_cre
            '
            Me.col_fec_cre.DataPropertyName = "Audit_FechaCreacion"
            Me.col_fec_cre.HeaderText = "F. Creacion"
            Me.col_fec_cre.Name = "col_fec_cre"
            Me.col_fec_cre.ReadOnly = True
            Me.col_fec_cre.Width = 135
            '
            'col_fec_mod
            '
            Me.col_fec_mod.DataPropertyName = "Audit_FechaModificacion"
            Me.col_fec_mod.HeaderText = "F. Modificacion"
            Me.col_fec_mod.Name = "col_fec_mod"
            Me.col_fec_mod.ReadOnly = True
            Me.col_fec_mod.Width = 135
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "Activo"
            Me.Column1.HeaderText = "Inactivo"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Column1.Width = 50
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnExportar)
            Me.Panel2.Controls.Add(Me.btnModificar)
            Me.Panel2.Controls.Add(Me.btnNuevo)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Controls.Add(Me.btnRestaurar)
            Me.Panel2.Controls.Add(Me.btnEliminar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 386)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(861, 60)
            Me.Panel2.TabIndex = 40
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(390, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(109, 53)
            Me.btnExportar.TabIndex = 77
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.Location = New System.Drawing.Point(95, 4)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(84, 53)
            Me.btnModificar.TabIndex = 66
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.Location = New System.Drawing.Point(5, 4)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(84, 53)
            Me.btnNuevo.TabIndex = 65
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(507, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(109, 53)
            Me.btnSalir.TabIndex = 6
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnRestaurar
            '
            Me.btnRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
            Me.btnRestaurar.Location = New System.Drawing.Point(275, 4)
            Me.btnRestaurar.Name = "btnRestaurar"
            Me.btnRestaurar.Size = New System.Drawing.Size(109, 53)
            Me.btnRestaurar.TabIndex = 3
            Me.btnRestaurar.Text = "&Restaurar Clave"
            Me.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnRestaurar.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(185, 4)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(84, 53)
            Me.btnEliminar.TabIndex = 2
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(6, 22)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(39, 13)
            Me.Label26.TabIndex = 42
            Me.Label26.Text = "Login :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.cbbNivelUsuario)
            Me.GroupBox1.Controls.Add(Me.cbbDependencia)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.txtNumDoc)
            Me.GroupBox1.Controls.Add(Me.txtNombres)
            Me.GroupBox1.Controls.Add(Me.txtApellidos)
            Me.GroupBox1.Controls.Add(Me.txtUsuario)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(778, 134)
            Me.GroupBox1.TabIndex = 43
            Me.GroupBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbTodos)
            Me.GroupBox2.Controls.Add(Me.rdbBaja)
            Me.GroupBox2.Controls.Add(Me.rdbActivo)
            Me.GroupBox2.Location = New System.Drawing.Point(9, 93)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(284, 32)
            Me.GroupBox2.TabIndex = 73
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Estado Usuario"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(216, 11)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 2
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbBaja
            '
            Me.rdbBaja.AutoSize = True
            Me.rdbBaja.Location = New System.Drawing.Point(152, 11)
            Me.rdbBaja.Name = "rdbBaja"
            Me.rdbBaja.Size = New System.Drawing.Size(46, 17)
            Me.rdbBaja.TabIndex = 1
            Me.rdbBaja.Text = "Baja"
            Me.rdbBaja.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Checked = True
            Me.rdbActivo.Location = New System.Drawing.Point(87, 11)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(55, 17)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.TabStop = True
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(326, 23)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(89, 13)
            Me.Label5.TabIndex = 72
            Me.Label5.Text = "Nivel de usuario :"
            '
            'cbbNivelUsuario
            '
            Me.cbbNivelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbNivelUsuario.FormattingEnabled = True
            Me.cbbNivelUsuario.Location = New System.Drawing.Point(421, 19)
            Me.cbbNivelUsuario.Name = "cbbNivelUsuario"
            Me.cbbNivelUsuario.Size = New System.Drawing.Size(210, 21)
            Me.cbbNivelUsuario.TabIndex = 71
            '
            'cbbDependencia
            '
            Me.cbbDependencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDependencia.FormattingEnabled = True
            Me.cbbDependencia.Location = New System.Drawing.Point(421, 48)
            Me.cbbDependencia.Name = "cbbDependencia"
            Me.cbbDependencia.Size = New System.Drawing.Size(210, 21)
            Me.cbbDependencia.TabIndex = 70
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(325, 51)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(77, 13)
            Me.Label8.TabIndex = 69
            Me.Label8.Text = "Oficina /Perfil :"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(216, 19)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(77, 20)
            Me.txtNumDoc.TabIndex = 55
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNombres
            '
            Me.txtNombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombres._BloquearPaste = False
            Me.txtNombres._SeleccionarTodo = False
            Me.txtNombres.Location = New System.Drawing.Point(68, 70)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(225, 20)
            Me.txtNombres.TabIndex = 54
            Me.txtNombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtApellidos
            '
            Me.txtApellidos._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApellidos._BloquearPaste = False
            Me.txtApellidos._SeleccionarTodo = False
            Me.txtApellidos.Location = New System.Drawing.Point(68, 45)
            Me.txtApellidos.Name = "txtApellidos"
            Me.txtApellidos.Size = New System.Drawing.Size(225, 20)
            Me.txtApellidos.TabIndex = 52
            Me.txtApellidos.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApellidos.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtUsuario
            '
            Me.txtUsuario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtUsuario._BloquearPaste = False
            Me.txtUsuario._SeleccionarTodo = False
            Me.txtUsuario.Location = New System.Drawing.Point(68, 19)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.Size = New System.Drawing.Size(77, 20)
            Me.txtUsuario.TabIndex = 51
            Me.txtUsuario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUsuario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(148, 22)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(64, 13)
            Me.Label4.TabIndex = 50
            Me.Label4.Text = "Num. Doc. :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 74)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 48
            Me.Label3.Text = "Nombres :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "Apellidos :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(861, 134)
            Me.Panel1.TabIndex = 44
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.lblReg)
            Me.GroupBox3.Controls.Add(Me.ToolStrip1)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox3.Location = New System.Drawing.Point(778, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(83, 134)
            Me.GroupBox3.TabIndex = 39
            Me.GroupBox3.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 112)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 19)
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
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbLimpiar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 115)
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
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(75, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(861, 446)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscar"
            Me.Text = "Gestion de Usuarios"
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnRestaurar As System.Windows.Forms.Button
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtUsuario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApellidos As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNombres As Legolas.APPUIComponents.MyTextBox
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Protected WithEvents cbbDependencia As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Protected WithEvents cbbNivelUsuario As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbBaja As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents col_usu_id As DataGridViewTextBoxColumn
        Friend WithEvents col_log As DataGridViewTextBoxColumn
        Friend WithEvents col_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_cor As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewCheckBoxColumn
        Friend WithEvents col_fec_cre As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_mod As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    End Class
End Namespace

