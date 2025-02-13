Namespace Tratamiento.Asistencia.Clasificacion.Penal.Pabellon
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbInactivo = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label26 = New System.Windows.Forms.Label()
            Me.dgwGrillaPabellon = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_gen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_gen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_esp_str = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.dgwPiso = New System.Windows.Forms.DataGridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel10 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblPabNomSel = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.btnEliminarPiso = New System.Windows.Forms.Button()
            Me.btnEditPiso = New System.Windows.Forms.Button()
            Me.btnAddPiso = New System.Windows.Forms.Button()
            Me.dgwAlero = New System.Windows.Forms.DataGridView()
            Me.col_codigo_ale = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_ale = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_ale = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel11 = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblPisoSel = New System.Windows.Forms.Label()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnEliminarAlero = New System.Windows.Forms.Button()
            Me.btnEditAlero = New System.Windows.Forms.Button()
            Me.btnAddAlero = New System.Windows.Forms.Button()
            Me.Panel2.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwGrillaPabellon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer2.Panel1.SuspendLayout()
            Me.SplitContainer2.Panel2.SuspendLayout()
            Me.SplitContainer2.SuspendLayout()
            CType(Me.dgwPiso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel10.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel8.SuspendLayout()
            CType(Me.dgwAlero, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel11.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 518)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1005, 45)
            Me.Panel2.TabIndex = 47
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSalir.Location = New System.Drawing.Point(0, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(82, 45)
            Me.pnlSalir.TabIndex = 78
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(2, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(77, 39)
            Me.btnSalir.TabIndex = 6
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Location = New System.Drawing.Point(0, 93)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(32, 31)
            Me.btnEliminar.TabIndex = 73
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(32, 31)
            Me.btnNuevo.TabIndex = 68
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnAnular
            '
            Me.btnAnular.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Location = New System.Drawing.Point(0, 62)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(32, 31)
            Me.btnAnular.TabIndex = 74
            Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnular.UseVisualStyleBackColor = True
            '
            'btnModificar
            '
            Me.btnModificar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Location = New System.Drawing.Point(0, 31)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(32, 31)
            Me.btnModificar.TabIndex = 1
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.UsrRegionPenal1)
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(922, 67)
            Me.GroupBox1.TabIndex = 48
            Me.GroupBox1.TabStop = False
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
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(6, 12)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(517, 22)
            Me.UsrRegionPenal1.TabIndex = 41
            Me.UsrRegionPenal1.WidthRegion = 224
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbTodos)
            Me.GroupBox2.Controls.Add(Me.rdbInactivo)
            Me.GroupBox2.Controls.Add(Me.rdbActivo)
            Me.GroupBox2.Location = New System.Drawing.Point(543, 12)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(210, 43)
            Me.GroupBox2.TabIndex = 61
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Estado"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(136, 19)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 2
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Location = New System.Drawing.Point(67, 19)
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
            Me.rdbActivo.Location = New System.Drawing.Point(6, 19)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(55, 17)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.TabStop = True
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(54, 40)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(470, 20)
            Me.txtNombre.TabIndex = 45
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(4, 43)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(50, 13)
            Me.Label26.TabIndex = 42
            Me.Label26.Text = "Nombre :"
            '
            'dgwGrillaPabellon
            '
            Me.dgwGrillaPabellon.AllowUserToAddRows = False
            Me.dgwGrillaPabellon.AllowUserToDeleteRows = False
            Me.dgwGrillaPabellon.AllowUserToOrderColumns = True
            Me.dgwGrillaPabellon.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaPabellon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaPabellon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_gen_id, Me.col_cod_gen, Me.col_gen_nom, Me.Column2, Me.col_esp_nom, Me.col_cod_esp_str, Me.col_est, Me.col_est_nom})
            Me.dgwGrillaPabellon.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaPabellon.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrillaPabellon.MultiSelect = False
            Me.dgwGrillaPabellon.Name = "dgwGrillaPabellon"
            Me.dgwGrillaPabellon.ReadOnly = True
            Me.dgwGrillaPabellon.RowHeadersVisible = False
            Me.dgwGrillaPabellon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaPabellon.Size = New System.Drawing.Size(973, 220)
            Me.dgwGrillaPabellon.TabIndex = 49
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 150
            '
            'col_gen_id
            '
            Me.col_gen_id.DataPropertyName = "RegionID"
            Me.col_gen_id.HeaderText = "RegionID"
            Me.col_gen_id.Name = "col_gen_id"
            Me.col_gen_id.ReadOnly = True
            Me.col_gen_id.Visible = False
            '
            'col_cod_gen
            '
            Me.col_cod_gen.DataPropertyName = "RegionNombre"
            Me.col_cod_gen.HeaderText = "Región"
            Me.col_cod_gen.Name = "col_cod_gen"
            Me.col_cod_gen.ReadOnly = True
            Me.col_cod_gen.Width = 150
            '
            'col_gen_nom
            '
            Me.col_gen_nom.DataPropertyName = "PenalID"
            Me.col_gen_nom.HeaderText = "PenalID"
            Me.col_gen_nom.Name = "col_gen_nom"
            Me.col_gen_nom.ReadOnly = True
            Me.col_gen_nom.Visible = False
            Me.col_gen_nom.Width = 350
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "PenalNombre"
            Me.Column2.HeaderText = "Penal"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 150
            '
            'col_esp_nom
            '
            Me.col_esp_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_esp_nom.DataPropertyName = "Nombre"
            Me.col_esp_nom.HeaderText = "Nombre"
            Me.col_esp_nom.Name = "col_esp_nom"
            Me.col_esp_nom.ReadOnly = True
            '
            'col_cod_esp_str
            '
            Me.col_cod_esp_str.DataPropertyName = "NombreCorto"
            Me.col_cod_esp_str.HeaderText = "Nombre Corto"
            Me.col_cod_esp_str.Name = "col_cod_esp_str"
            Me.col_cod_esp_str.ReadOnly = True
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.HeaderText = "EstadoID"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 50
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox3)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1005, 67)
            Me.pnlBusqueda.TabIndex = 50
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.ToolStrip1)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox3.Location = New System.Drawing.Point(922, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(83, 67)
            Me.GroupBox3.TabIndex = 49
            Me.GroupBox3.TabStop = False
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 48)
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
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.pnlBusqueda)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
            Me.SplitContainer1.Size = New System.Drawing.Size(1005, 518)
            Me.SplitContainer1.SplitterDistance = 287
            Me.SplitContainer1.TabIndex = 51
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.dgwGrillaPabellon)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 67)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1005, 220)
            Me.Panel1.TabIndex = 51
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnEliminar)
            Me.Panel3.Controls.Add(Me.btnAnular)
            Me.Panel3.Controls.Add(Me.btnModificar)
            Me.Panel3.Controls.Add(Me.btnNuevo)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(973, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(32, 220)
            Me.Panel3.TabIndex = 50
            '
            'SplitContainer2
            '
            Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer2.Name = "SplitContainer2"
            '
            'SplitContainer2.Panel1
            '
            Me.SplitContainer2.Panel1.Controls.Add(Me.dgwPiso)
            Me.SplitContainer2.Panel1.Controls.Add(Me.Panel10)
            Me.SplitContainer2.Panel1.Controls.Add(Me.Panel5)
            Me.SplitContainer2.Panel1.Controls.Add(Me.Panel4)
            '
            'SplitContainer2.Panel2
            '
            Me.SplitContainer2.Panel2.Controls.Add(Me.dgwAlero)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Panel11)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Panel7)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Panel6)
            Me.SplitContainer2.Size = New System.Drawing.Size(1005, 227)
            Me.SplitContainer2.SplitterDistance = 513
            Me.SplitContainer2.TabIndex = 3
            '
            'dgwPiso
            '
            Me.dgwPiso.AllowUserToAddRows = False
            Me.dgwPiso.AllowUserToDeleteRows = False
            Me.dgwPiso.AllowUserToOrderColumns = True
            Me.dgwPiso.BackgroundColor = System.Drawing.Color.White
            Me.dgwPiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwPiso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_nom, Me.col_habilitado})
            Me.dgwPiso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwPiso.Location = New System.Drawing.Point(0, 53)
            Me.dgwPiso.MultiSelect = False
            Me.dgwPiso.Name = "dgwPiso"
            Me.dgwPiso.ReadOnly = True
            Me.dgwPiso.RowHeadersVisible = False
            Me.dgwPiso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwPiso.Size = New System.Drawing.Size(475, 174)
            Me.dgwPiso.TabIndex = 1
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'col_nom
            '
            Me.col_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nom.DataPropertyName = "Nombre"
            Me.col_nom.HeaderText = "Piso"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            '
            'col_habilitado
            '
            Me.col_habilitado.DataPropertyName = "PisoHabilitadoStr"
            Me.col_habilitado.HeaderText = "Estado"
            Me.col_habilitado.Name = "col_habilitado"
            Me.col_habilitado.ReadOnly = True
            Me.col_habilitado.Width = 150
            '
            'Panel10
            '
            Me.Panel10.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel10.Controls.Add(Me.Label3)
            Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel10.Location = New System.Drawing.Point(0, 29)
            Me.Panel10.Name = "Panel10"
            Me.Panel10.Size = New System.Drawing.Size(475, 24)
            Me.Panel10.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 4)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(105, 15)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Pisos de pabellón"
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.Label1)
            Me.Panel5.Controls.Add(Me.lblPabNomSel)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(475, 29)
            Me.Panel5.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(4, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(54, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Pabellón :"
            '
            'lblPabNomSel
            '
            Me.lblPabNomSel.AutoSize = True
            Me.lblPabNomSel.Location = New System.Drawing.Point(61, 14)
            Me.lblPabNomSel.Name = "lblPabNomSel"
            Me.lblPabNomSel.Size = New System.Drawing.Size(95, 13)
            Me.lblPabNomSel.TabIndex = 0
            Me.lblPabNomSel.Text = "Pisos del pabellón "
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.Panel8)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel4.Location = New System.Drawing.Point(475, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(38, 227)
            Me.Panel4.TabIndex = 0
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.btnEliminarPiso)
            Me.Panel8.Controls.Add(Me.btnEditPiso)
            Me.Panel8.Controls.Add(Me.btnAddPiso)
            Me.Panel8.Location = New System.Drawing.Point(0, 28)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(32, 105)
            Me.Panel8.TabIndex = 78
            '
            'btnEliminarPiso
            '
            Me.btnEliminarPiso.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminarPiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarPiso.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnEliminarPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarPiso.Location = New System.Drawing.Point(0, 62)
            Me.btnEliminarPiso.Name = "btnEliminarPiso"
            Me.btnEliminarPiso.Size = New System.Drawing.Size(32, 31)
            Me.btnEliminarPiso.TabIndex = 77
            Me.btnEliminarPiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminarPiso.UseVisualStyleBackColor = True
            '
            'btnEditPiso
            '
            Me.btnEditPiso.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnEditPiso.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnEditPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditPiso.Location = New System.Drawing.Point(0, 31)
            Me.btnEditPiso.Name = "btnEditPiso"
            Me.btnEditPiso.Size = New System.Drawing.Size(32, 31)
            Me.btnEditPiso.TabIndex = 75
            Me.btnEditPiso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnEditPiso.UseVisualStyleBackColor = True
            '
            'btnAddPiso
            '
            Me.btnAddPiso.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddPiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPiso.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnAddPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddPiso.Location = New System.Drawing.Point(0, 0)
            Me.btnAddPiso.Name = "btnAddPiso"
            Me.btnAddPiso.Size = New System.Drawing.Size(32, 31)
            Me.btnAddPiso.TabIndex = 76
            Me.btnAddPiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAddPiso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAddPiso.UseVisualStyleBackColor = True
            '
            'dgwAlero
            '
            Me.dgwAlero.AllowUserToAddRows = False
            Me.dgwAlero.AllowUserToDeleteRows = False
            Me.dgwAlero.AllowUserToOrderColumns = True
            Me.dgwAlero.BackgroundColor = System.Drawing.Color.White
            Me.dgwAlero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwAlero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo_ale, Me.col_nom_ale, Me.col_est_ale})
            Me.dgwAlero.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwAlero.Location = New System.Drawing.Point(0, 53)
            Me.dgwAlero.MultiSelect = False
            Me.dgwAlero.Name = "dgwAlero"
            Me.dgwAlero.ReadOnly = True
            Me.dgwAlero.RowHeadersVisible = False
            Me.dgwAlero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwAlero.Size = New System.Drawing.Size(455, 174)
            Me.dgwAlero.TabIndex = 4
            '
            'col_codigo_ale
            '
            Me.col_codigo_ale.DataPropertyName = "Codigo"
            Me.col_codigo_ale.HeaderText = "Codigo"
            Me.col_codigo_ale.Name = "col_codigo_ale"
            Me.col_codigo_ale.ReadOnly = True
            Me.col_codigo_ale.Visible = False
            '
            'col_nom_ale
            '
            Me.col_nom_ale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nom_ale.DataPropertyName = "Nombre"
            Me.col_nom_ale.HeaderText = "Alero"
            Me.col_nom_ale.Name = "col_nom_ale"
            Me.col_nom_ale.ReadOnly = True
            '
            'col_est_ale
            '
            Me.col_est_ale.DataPropertyName = "AleroHabilitadoStr"
            Me.col_est_ale.HeaderText = "Estado"
            Me.col_est_ale.Name = "col_est_ale"
            Me.col_est_ale.ReadOnly = True
            Me.col_est_ale.Width = 150
            '
            'Panel11
            '
            Me.Panel11.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Panel11.Controls.Add(Me.Label4)
            Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel11.Location = New System.Drawing.Point(0, 29)
            Me.Panel11.Name = "Panel11"
            Me.Panel11.Size = New System.Drawing.Size(455, 24)
            Me.Panel11.TabIndex = 5
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(4, 4)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 15)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Aleros por piso"
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.Label2)
            Me.Panel7.Controls.Add(Me.lblPisoSel)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel7.Location = New System.Drawing.Point(0, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(455, 29)
            Me.Panel7.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(4, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(30, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Piso:"
            '
            'lblPisoSel
            '
            Me.lblPisoSel.AutoSize = True
            Me.lblPisoSel.Location = New System.Drawing.Point(35, 11)
            Me.lblPisoSel.Name = "lblPisoSel"
            Me.lblPisoSel.Size = New System.Drawing.Size(16, 13)
            Me.lblPisoSel.TabIndex = 0
            Me.lblPisoSel.Text = "---"
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.Panel9)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(455, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(33, 227)
            Me.Panel6.TabIndex = 1
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.btnEliminarAlero)
            Me.Panel9.Controls.Add(Me.btnEditAlero)
            Me.Panel9.Controls.Add(Me.btnAddAlero)
            Me.Panel9.Location = New System.Drawing.Point(1, 29)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(32, 164)
            Me.Panel9.TabIndex = 0
            '
            'btnEliminarAlero
            '
            Me.btnEliminarAlero.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminarAlero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarAlero.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnEliminarAlero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarAlero.Location = New System.Drawing.Point(0, 62)
            Me.btnEliminarAlero.Name = "btnEliminarAlero"
            Me.btnEliminarAlero.Size = New System.Drawing.Size(32, 31)
            Me.btnEliminarAlero.TabIndex = 78
            Me.btnEliminarAlero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminarAlero.UseVisualStyleBackColor = True
            '
            'btnEditAlero
            '
            Me.btnEditAlero.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditAlero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnEditAlero.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnEditAlero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditAlero.Location = New System.Drawing.Point(0, 31)
            Me.btnEditAlero.Name = "btnEditAlero"
            Me.btnEditAlero.Size = New System.Drawing.Size(32, 31)
            Me.btnEditAlero.TabIndex = 75
            Me.btnEditAlero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnEditAlero.UseVisualStyleBackColor = True
            '
            'btnAddAlero
            '
            Me.btnAddAlero.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddAlero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddAlero.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnAddAlero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddAlero.Location = New System.Drawing.Point(0, 0)
            Me.btnAddAlero.Name = "btnAddAlero"
            Me.btnAddAlero.Size = New System.Drawing.Size(32, 31)
            Me.btnAddAlero.TabIndex = 76
            Me.btnAddAlero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAddAlero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAddAlero.UseVisualStyleBackColor = True
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1005, 563)
            Me.Controls.Add(Me.SplitContainer1)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscar"
            Me.Text = "Pabellón - Buscar"
            Me.Panel2.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgwGrillaPabellon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.SplitContainer2.Panel1.ResumeLayout(False)
            Me.SplitContainer2.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.ResumeLayout(False)
            CType(Me.dgwPiso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel10.ResumeLayout(False)
            Me.Panel10.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel8.ResumeLayout(False)
            CType(Me.dgwAlero, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel11.ResumeLayout(False)
            Me.Panel11.PerformLayout()
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents dgwGrillaPabellon As System.Windows.Forms.DataGridView
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents dgwPiso As DataGridView
        Friend WithEvents Panel4 As Panel
        Friend WithEvents Panel5 As Panel
        Friend WithEvents lblPabNomSel As Label
        Friend WithEvents btnEliminarPiso As Button
        Friend WithEvents btnAddPiso As Button
        Friend WithEvents btnEditPiso As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents SplitContainer2 As SplitContainer
        Friend WithEvents Panel7 As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents lblPisoSel As Label
        Friend WithEvents Panel6 As Panel
        Friend WithEvents btnAddAlero As Button
        Friend WithEvents btnEditAlero As Button
        Friend WithEvents dgwAlero As DataGridView
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_habilitado As DataGridViewTextBoxColumn
        Friend WithEvents col_codigo_ale As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_ale As DataGridViewTextBoxColumn
        Friend WithEvents col_est_ale As DataGridViewTextBoxColumn
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_gen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_gen As DataGridViewTextBoxColumn
        Friend WithEvents col_gen_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents col_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_esp_str As DataGridViewTextBoxColumn
        Friend WithEvents col_est As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents btnEliminarAlero As Button
        Friend WithEvents Panel8 As Panel
        Friend WithEvents Panel9 As Panel
        Friend WithEvents Panel10 As Panel
        Friend WithEvents Label3 As Label
        Friend WithEvents Panel11 As Panel
        Friend WithEvents Label4 As Label
    End Class
End Namespace