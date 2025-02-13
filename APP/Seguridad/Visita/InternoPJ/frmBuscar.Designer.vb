Namespace Visita.InternoPJ
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
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalirBusqueda = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlInactivar = New System.Windows.Forms.Panel()
            Me.btnInactivar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sex_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nac_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pab_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_egr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbPabellon = New APPControls.uscComboPabellon()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbTipoDocumento = New APPControls.uscComboParametrica()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.rb_activo = New Legolas.APPUIComponents.myRadioButton()
            Me.rb_pasivo = New Legolas.APPUIComponents.myRadioButton()
            Me.rb_todos = New Legolas.APPUIComponents.myRadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.chkSelect = New System.Windows.Forms.CheckBox()
            Me.Panel2.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlInactivar.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.cbbPabellon.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Controls.Add(Me.pnlExportar)
            Me.Panel2.Controls.Add(Me.pnlInactivar)
            Me.Panel2.Controls.Add(Me.pnlModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 443)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1167, 49)
            Me.Panel2.TabIndex = 55
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalirBusqueda)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSalir.Location = New System.Drawing.Point(381, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(95, 49)
            Me.pnlSalir.TabIndex = 87
            '
            'btnSalirBusqueda
            '
            Me.btnSalirBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalirBusqueda.Image = CType(resources.GetObject("btnSalirBusqueda.Image"), System.Drawing.Image)
            Me.btnSalirBusqueda.Location = New System.Drawing.Point(2, 5)
            Me.btnSalirBusqueda.Name = "btnSalirBusqueda"
            Me.btnSalirBusqueda.Size = New System.Drawing.Size(88, 40)
            Me.btnSalirBusqueda.TabIndex = 76
            Me.btnSalirBusqueda.Text = "&Salir"
            Me.btnSalirBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalirBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalirBusqueda.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlExportar.Location = New System.Drawing.Point(286, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(95, 49)
            Me.pnlExportar.TabIndex = 85
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(2, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 78
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlInactivar
            '
            Me.pnlInactivar.Controls.Add(Me.btnInactivar)
            Me.pnlInactivar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlInactivar.Location = New System.Drawing.Point(191, 0)
            Me.pnlInactivar.Name = "pnlInactivar"
            Me.pnlInactivar.Size = New System.Drawing.Size(95, 49)
            Me.pnlInactivar.TabIndex = 88
            '
            'btnInactivar
            '
            Me.btnInactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnInactivar.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnInactivar.Location = New System.Drawing.Point(4, 5)
            Me.btnInactivar.Name = "btnInactivar"
            Me.btnInactivar.Size = New System.Drawing.Size(88, 40)
            Me.btnInactivar.TabIndex = 76
            Me.btnInactivar.Text = "&Inactivar"
            Me.btnInactivar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnInactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnInactivar.UseVisualStyleBackColor = True
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnModificar)
            Me.pnlModificar.Controls.Add(Me.btnNuevo)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(191, 49)
            Me.pnlModificar.TabIndex = 83
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.Location = New System.Drawing.Point(95, 5)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(93, 40)
            Me.btnModificar.TabIndex = 79
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.Location = New System.Drawing.Point(2, 5)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 40)
            Me.btnNuevo.TabIndex = 77
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.UsrRegionPenal1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1167, 50)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
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
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(10, 17)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(465, 22)
            Me.UsrRegionPenal1.TabIndex = 0
            Me.UsrRegionPenal1.WidthRegion = 224
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.col_int_id, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_sex_nom, Me.col_nac_nom, Me.Column1, Me.Column2, Me.col_pab_nom, Me.col_fec_ing, Me.col_fec_egr, Me.col_est_nom, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 203)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1167, 240)
            Me.dgwGrilla.TabIndex = 2
            Me.dgwGrilla.VisibleCampos = True
            '
            'col_chk
            '
            Me.col_chk.DividerWidth = 1
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Width = 35
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "Codigo"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "Codigo"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "PrimerApellido"
            Me.col_ape_pat.HeaderText = "Primer Apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Width = 150
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "SegundoApellido"
            Me.col_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Width = 150
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "PreNombres"
            Me.col_nom.HeaderText = "PreNombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 150
            '
            'col_sex_nom
            '
            Me.col_sex_nom.DataPropertyName = "SexoNombreReadonly"
            Me.col_sex_nom.HeaderText = "Sexo"
            Me.col_sex_nom.Name = "col_sex_nom"
            Me.col_sex_nom.ReadOnly = True
            Me.col_sex_nom.Width = 60
            '
            'col_nac_nom
            '
            Me.col_nac_nom.DataPropertyName = "Nacionalidad"
            Me.col_nac_nom.HeaderText = "Nacionalidad"
            Me.col_nac_nom.Name = "col_nac_nom"
            Me.col_nac_nom.ReadOnly = True
            Me.col_nac_nom.Visible = False
            Me.col_nac_nom.Width = 120
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "TipoDocumento"
            Me.Column1.HeaderText = "Tipo Documento"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 120
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "NumeroDocumento"
            Me.Column2.HeaderText = "Numero Doc."
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            '
            'col_pab_nom
            '
            Me.col_pab_nom.DataPropertyName = "Pabellon"
            Me.col_pab_nom.HeaderText = "Pabellon"
            Me.col_pab_nom.Name = "col_pab_nom"
            Me.col_pab_nom.ReadOnly = True
            '
            'col_fec_ing
            '
            Me.col_fec_ing.DataPropertyName = "FechaIngreso"
            Me.col_fec_ing.HeaderText = "F. Ingreso"
            Me.col_fec_ing.Name = "col_fec_ing"
            Me.col_fec_ing.ReadOnly = True
            '
            'col_fec_egr
            '
            Me.col_fec_egr.DataPropertyName = "FechaEgreso"
            Me.col_fec_egr.HeaderText = "F. Egreso"
            Me.col_fec_egr.Name = "col_fec_egr"
            Me.col_fec_egr.ReadOnly = True
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombreReadonly"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 70
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "IDRegion"
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
            Me.col_pen_id.DataPropertyName = "IDPenal"
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
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox4)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 50)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1167, 153)
            Me.pnlBusqueda.TabIndex = 64
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.cbbPabellon)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtNumDoc)
            Me.GroupBox1.Controls.Add(Me.cbbTipoDocumento)
            Me.GroupBox1.Controls.Add(Me.GroupBox3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtApePat)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtNom)
            Me.GroupBox1.Controls.Add(Me.txtApeMat)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1069, 153)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'cbbPabellon
            '
            Me.cbbPabellon._Ninguno = False
            Me.cbbPabellon._PenalID = -1
            Me.cbbPabellon._RegionID = -1
            Me.cbbPabellon._SelectedValue = 0
            Me.cbbPabellon._Todos = False
            Me.cbbPabellon.Controls.Add(Me.ComboBox1)
            Me.cbbPabellon.Location = New System.Drawing.Point(398, 69)
            Me.cbbPabellon.Name = "cbbPabellon"
            Me.cbbPabellon.Size = New System.Drawing.Size(143, 22)
            Me.cbbPabellon.TabIndex = 76
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
            Me.ComboBox1.TabIndex = 0
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(285, 74)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(54, 13)
            Me.Label6.TabIndex = 11
            Me.Label6.Text = "Pabellon :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Location = New System.Drawing.Point(285, 47)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(108, 13)
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "Numero Documento :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(285, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(60, 13)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "Tipo Doc. :"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(398, 43)
            Me.txtNumDoc.MaxLength = 20
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(143, 20)
            Me.txtNumDoc.TabIndex = 10
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'cbbTipoDocumento
            '
            Me.cbbTipoDocumento._NoIndica = False
            Me.cbbTipoDocumento._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoDocumento._Todos = False
            Me.cbbTipoDocumento._TodosMensaje = ""
            Me.cbbTipoDocumento._Visible_Add = False
            Me.cbbTipoDocumento._Visible_Buscar = False
            Me.cbbTipoDocumento._Visible_Eliminar = False
            Me.cbbTipoDocumento.CodigoPadre = -1
            Me.cbbTipoDocumento.ComboTipo = CType(2, Short)
            Me.cbbTipoDocumento.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDocumento.DropDownWidth = 143
            Me.cbbTipoDocumento.DropDownWidthAuto = False
            Me.cbbTipoDocumento.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDocumento.Location = New System.Drawing.Point(398, 17)
            Me.cbbTipoDocumento.ModuloTratamiento = False
            Me.cbbTipoDocumento.Name = "cbbTipoDocumento"
            Me.cbbTipoDocumento.Parametro1 = -1
            Me.cbbTipoDocumento.Parametro2 = -1
            Me.cbbTipoDocumento.SelectedIndex = -1
            Me.cbbTipoDocumento.SelectedValue = 0
            Me.cbbTipoDocumento.Size = New System.Drawing.Size(143, 22)
            Me.cbbTipoDocumento.TabIndex = 8
            Me.cbbTipoDocumento.verToolTipItemSeleccionado = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rb_activo)
            Me.GroupBox3.Controls.Add(Me.rb_pasivo)
            Me.GroupBox3.Controls.Add(Me.rb_todos)
            Me.GroupBox3.Location = New System.Drawing.Point(12, 95)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(250, 42)
            Me.GroupBox3.TabIndex = 6
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Estado"
            '
            'rb_activo
            '
            Me.rb_activo.AutoSize = True
            Me.rb_activo.Checked = True
            Me.rb_activo.Location = New System.Drawing.Point(12, 17)
            Me.rb_activo.Name = "rb_activo"
            Me.rb_activo.Size = New System.Drawing.Size(55, 17)
            Me.rb_activo.TabIndex = 0
            Me.rb_activo.TabStop = True
            Me.rb_activo.Text = "Activo"
            Me.rb_activo.UseVisualStyleBackColor = True
            '
            'rb_pasivo
            '
            Me.rb_pasivo.AutoSize = True
            Me.rb_pasivo.Location = New System.Drawing.Point(94, 17)
            Me.rb_pasivo.Name = "rb_pasivo"
            Me.rb_pasivo.Size = New System.Drawing.Size(63, 17)
            Me.rb_pasivo.TabIndex = 1
            Me.rb_pasivo.Text = "Inactivo"
            Me.rb_pasivo.UseVisualStyleBackColor = True
            '
            'rb_todos
            '
            Me.rb_todos.AutoSize = True
            Me.rb_todos.Location = New System.Drawing.Point(178, 17)
            Me.rb_todos.Name = "rb_todos"
            Me.rb_todos.Size = New System.Drawing.Size(55, 17)
            Me.rb_todos.TabIndex = 2
            Me.rb_todos.Text = "Todos"
            Me.rb_todos.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(12, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Primer Apellido :"
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.Location = New System.Drawing.Point(119, 17)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(143, 20)
            Me.txtApePat.TabIndex = 1
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 47)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(96, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Segundo Apellido :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 74)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(71, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "PreNombres :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(119, 69)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(143, 20)
            Me.txtNom.TabIndex = 5
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = False
            Me.txtApeMat.Location = New System.Drawing.Point(119, 43)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(143, 20)
            Me.txtApeMat.TabIndex = 3
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.lblReg)
            Me.GroupBox4.Controls.Add(Me.ToolStrip1)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox4.Location = New System.Drawing.Point(1069, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(98, 153)
            Me.GroupBox4.TabIndex = 1
            Me.GroupBox4.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 128)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(92, 22)
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
            Me.ToolStrip1.Size = New System.Drawing.Size(92, 134)
            Me.ToolStrip1.TabIndex = 91
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(90, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = Global.SIPPOPE.My.Resources.Resources.replace2
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(90, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'chkSelect
            '
            Me.chkSelect.AutoSize = True
            Me.chkSelect.Location = New System.Drawing.Point(10, 207)
            Me.chkSelect.Name = "chkSelect"
            Me.chkSelect.Size = New System.Drawing.Size(15, 14)
            Me.chkSelect.TabIndex = 65
            Me.chkSelect.UseVisualStyleBackColor = True
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1167, 492)
            Me.Controls.Add(Me.chkSelect)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscar"
            Me.Text = "Buscar Poblacion PJ"
            Me.Panel2.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlInactivar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.cbbPabellon.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnSalirBusqueda As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
        Friend WithEvents btnInactivar As System.Windows.Forms.Button
        Friend WithEvents pnlInactivar As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents rb_activo As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rb_pasivo As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rb_todos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents chkSelect As System.Windows.Forms.CheckBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbTipoDocumento As APPControls.uscComboParametrica
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents cbbPabellon As APPControls.uscComboPabellon
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents col_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sex_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nac_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pab_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_egr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace