
Namespace Seguridad.Penal
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
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbDependencia = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbNivelUsuario = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbBaja = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.txtNombres = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtApe = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.col_usu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_log_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_fec_cre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToOrderColumns = True
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_usu_id, Me.col_log_nom, Me.col_ape, Me.col_nom, Me.Column1, Me.Perfil, Me.Column2, Me.Column3, Me.col_fec_cre, Me.col_fec_mod, Me.Estado})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 152)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1257, 225)
            Me.dgwGrilla.TabIndex = 39
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 377)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1257, 48)
            Me.Panel2.TabIndex = 40
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnExportar)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel3.Location = New System.Drawing.Point(105, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(96, 48)
            Me.Panel3.TabIndex = 78
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(4, 3)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 76
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnModificar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(105, 48)
            Me.Panel1.TabIndex = 77
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.Location = New System.Drawing.Point(4, 3)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(97, 40)
            Me.btnModificar.TabIndex = 1
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(204, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 40)
            Me.btnSalir.TabIndex = 6
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(2, 22)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(39, 13)
            Me.Label26.TabIndex = 42
            Me.Label26.Text = "Login :"
            '
            'txtUsuario
            '
            Me.txtUsuario.Location = New System.Drawing.Point(88, 19)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.Size = New System.Drawing.Size(91, 20)
            Me.txtUsuario.TabIndex = 41
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox4)
            Me.GroupBox1.Controls.Add(Me.cbbDependencia)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.cbbNivelUsuario)
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.txtNombres)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtApe)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtUsuario)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1174, 152)
            Me.GroupBox1.TabIndex = 43
            Me.GroupBox1.TabStop = False
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.cbbRegion)
            Me.GroupBox4.Controls.Add(Me.cbbPenal)
            Me.GroupBox4.Location = New System.Drawing.Point(310, 71)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(309, 70)
            Me.GroupBox4.TabIndex = 78
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Region/Penal"
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.Region
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.Location = New System.Drawing.Point(6, 17)
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(296, 22)
            Me.cbbRegion.TabIndex = 53
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.Penal
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 178
            Me.cbbPenal.DropDownWidthAuto = True
            Me.cbbPenal.Location = New System.Drawing.Point(6, 42)
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(296, 22)
            Me.cbbPenal.TabIndex = 55
            '
            'cbbDependencia
            '
            Me.cbbDependencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDependencia.FormattingEnabled = True
            Me.cbbDependencia.Location = New System.Drawing.Point(402, 41)
            Me.cbbDependencia.Name = "cbbDependencia"
            Me.cbbDependencia.Size = New System.Drawing.Size(210, 21)
            Me.cbbDependencia.TabIndex = 76
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(307, 44)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(77, 13)
            Me.Label8.TabIndex = 75
            Me.Label8.Text = "Oficina /Perfil :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(307, 18)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(89, 13)
            Me.Label6.TabIndex = 74
            Me.Label6.Text = "Nivel de usuario :"
            '
            'cbbNivelUsuario
            '
            Me.cbbNivelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbNivelUsuario.FormattingEnabled = True
            Me.cbbNivelUsuario.Location = New System.Drawing.Point(402, 14)
            Me.cbbNivelUsuario.Name = "cbbNivelUsuario"
            Me.cbbNivelUsuario.Size = New System.Drawing.Size(210, 21)
            Me.cbbNivelUsuario.TabIndex = 73
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbTodos)
            Me.GroupBox2.Controls.Add(Me.rdbBaja)
            Me.GroupBox2.Controls.Add(Me.rdbActivo)
            Me.GroupBox2.Location = New System.Drawing.Point(6, 104)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(284, 32)
            Me.GroupBox2.TabIndex = 77
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
            'txtNombres
            '
            Me.txtNombres.Location = New System.Drawing.Point(88, 71)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(202, 20)
            Me.txtNombres.TabIndex = 47
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(2, 74)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 48
            Me.Label3.Text = "Nombres :"
            '
            'txtApe
            '
            Me.txtApe.Location = New System.Drawing.Point(88, 45)
            Me.txtApe.Name = "txtApe"
            Me.txtApe.Size = New System.Drawing.Size(202, 20)
            Me.txtApe.TabIndex = 43
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(2, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "Apellidos: "
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox3)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1257, 152)
            Me.pnlBusqueda.TabIndex = 44
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.lblReg)
            Me.GroupBox3.Controls.Add(Me.ToolStrip1)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox3.Location = New System.Drawing.Point(1174, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(83, 152)
            Me.GroupBox3.TabIndex = 39
            Me.GroupBox3.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 127)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 133)
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
            'col_usu_id
            '
            Me.col_usu_id.DataPropertyName = "Codigo"
            Me.col_usu_id.HeaderText = "UsuarioID"
            Me.col_usu_id.Name = "col_usu_id"
            Me.col_usu_id.ReadOnly = True
            Me.col_usu_id.Visible = False
            '
            'col_log_nom
            '
            Me.col_log_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_log_nom.DataPropertyName = "Login"
            Me.col_log_nom.HeaderText = "Login"
            Me.col_log_nom.Name = "col_log_nom"
            Me.col_log_nom.ReadOnly = True
            Me.col_log_nom.Width = 85
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
            'Column1
            '
            Me.Column1.DataPropertyName = "NivelUsuarioNombre"
            Me.Column1.HeaderText = "Nivel Usuario"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 150
            '
            'Perfil
            '
            Me.Perfil.DataPropertyName = "DependenciaNombre"
            Me.Perfil.HeaderText = "Oficina/Perfil"
            Me.Perfil.Name = "Perfil"
            Me.Perfil.ReadOnly = True
            Me.Perfil.Width = 200
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "Clave"
            Me.Column2.HeaderText = "Clave"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 85
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "ClaveNueva"
            Me.Column3.HeaderText = "Clave Rest."
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Column3.Width = 85
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
            'Estado
            '
            Me.Estado.DataPropertyName = "Activo"
            Me.Estado.HeaderText = "Usu. Inac."
            Me.Estado.Name = "Estado"
            Me.Estado.ReadOnly = True
            Me.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Estado.Width = 45
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1257, 425)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscar"
            Me.Text = "Permisos de Usuarios a Penales"
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents txtApe As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNombres As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Protected WithEvents cbbNivelUsuario As Legolas.APPUIComponents.MyComboBox
        Protected WithEvents cbbDependencia As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbBaja As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents col_usu_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_log_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Perfil As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_fec_cre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_mod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Estado As System.Windows.Forms.DataGridViewCheckBoxColumn
    End Class
End Namespace

