<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscInternoBuscar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscInternoBuscar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumeroDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.cbbTipoDoc = New APPControls.uscComboParametrica()
        Me.grbEtapa = New System.Windows.Forms.GroupBox()
        Me.cbbEtapa = New APPControls.uscComboParametrica()
        Me.grbPabellon = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_activo = New Legolas.APPUIComponents.myRadioButton()
        Me.rb_pasivo = New Legolas.APPUIComponents.myRadioButton()
        Me.rb_todos = New Legolas.APPUIComponents.myRadioButton()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
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
        Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
        Me.chkSelect = New System.Windows.Forms.CheckBox()
        Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_loc_row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_sed_row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ver_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sex_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nac_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pab_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_etp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPabellon = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grbEtapa.SuspendLayout()
        Me.grbPabellon.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBusqueda.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNumeroDoc)
        Me.GroupBox1.Controls.Add(Me.cbbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.grbEtapa)
        Me.GroupBox1.Controls.Add(Me.grbPabellon)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtCodInterno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtApePat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.txtApeMat)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 243)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Tipo Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Numero Doc. :"
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNumeroDoc._BloquearPaste = False
        Me.txtNumeroDoc._SeleccionarTodo = False
        Me.txtNumeroDoc.Location = New System.Drawing.Point(123, 69)
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(143, 20)
        Me.txtNumeroDoc.TabIndex = 73
        Me.txtNumeroDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtNumeroDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'cbbTipoDoc
        '
        Me.cbbTipoDoc._NoIndica = False
        Me.cbbTipoDoc._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
        Me.cbbTipoDoc._Todos = False
        Me.cbbTipoDoc._TodosMensaje = ""
        Me.cbbTipoDoc._Visible_Add = False
        Me.cbbTipoDoc._Visible_Buscar = False
        Me.cbbTipoDoc._Visible_Eliminar = False
        Me.cbbTipoDoc.CodigoPadre = -1
        Me.cbbTipoDoc.ComboTipo = CType(47, Short)
        Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
        Me.cbbTipoDoc.DropDownWidth = 143
        Me.cbbTipoDoc.DropDownWidthAuto = False
        Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
        Me.cbbTipoDoc.Location = New System.Drawing.Point(123, 42)
        Me.cbbTipoDoc.ModuloTratamiento = False
        Me.cbbTipoDoc.Name = "cbbTipoDoc"
        Me.cbbTipoDoc.Parametro1 = -1
        Me.cbbTipoDoc.Parametro2 = -1
        Me.cbbTipoDoc.SelectedIndex = -1
        Me.cbbTipoDoc.SelectedValue = 0
        Me.cbbTipoDoc.Size = New System.Drawing.Size(143, 22)
        Me.cbbTipoDoc.TabIndex = 71
        '
        'grbEtapa
        '
        Me.grbEtapa.Controls.Add(Me.cbbEtapa)
        Me.grbEtapa.Location = New System.Drawing.Point(295, 81)
        Me.grbEtapa.Name = "grbEtapa"
        Me.grbEtapa.Size = New System.Drawing.Size(241, 44)
        Me.grbEtapa.TabIndex = 67
        Me.grbEtapa.TabStop = False
        Me.grbEtapa.Text = "Etapa"
        Me.grbEtapa.Visible = False
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
        'grbPabellon
        '
        Me.grbPabellon.Controls.Add(Me.txtPabellon)
        Me.grbPabellon.Location = New System.Drawing.Point(295, 20)
        Me.grbPabellon.Name = "grbPabellon"
        Me.grbPabellon.Size = New System.Drawing.Size(241, 44)
        Me.grbPabellon.TabIndex = 70
        Me.grbPabellon.TabStop = False
        Me.grbPabellon.Text = "Pabellon"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UscFotografia_2v1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(777, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 224)
        Me.Panel1.TabIndex = 66
        '
        'UscFotografia_2v1
        '
        Me.UscFotografia_2v1._CheckImagen = False
        Me.UscFotografia_2v1._EnabledDobleClick = True
        Me.UscFotografia_2v1._HasImagen = False
        Me.UscFotografia_2v1._PanelAutorizacion = False
        Me.UscFotografia_2v1._PanelCheck = True
        Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UscFotografia_2v1.Location = New System.Drawing.Point(0, 0)
        Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
        Me.UscFotografia_2v1.Size = New System.Drawing.Size(158, 224)
        Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UscFotografia_2v1.TabIndex = 66
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_activo)
        Me.GroupBox3.Controls.Add(Me.rb_pasivo)
        Me.GroupBox3.Controls.Add(Me.rb_todos)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 173)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 42)
        Me.GroupBox3.TabIndex = 64
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
        Me.rb_activo.TabIndex = 61
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
        Me.rb_pasivo.TabIndex = 62
        Me.rb_pasivo.Text = "Inactivo"
        Me.rb_pasivo.UseVisualStyleBackColor = True
        '
        'rb_todos
        '
        Me.rb_todos.AutoSize = True
        Me.rb_todos.Location = New System.Drawing.Point(178, 17)
        Me.rb_todos.Name = "rb_todos"
        Me.rb_todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_todos.TabIndex = 63
        Me.rb_todos.Text = "Todos"
        Me.rb_todos.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 54
        Me.Label26.Text = "Codigo Interno :"
        '
        'txtCodInterno
        '
        Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCodInterno._BloquearPaste = False
        Me.txtCodInterno._SeleccionarTodo = False
        Me.txtCodInterno.Location = New System.Drawing.Point(123, 17)
        Me.txtCodInterno.Name = "txtCodInterno"
        Me.txtCodInterno.Size = New System.Drawing.Size(84, 20)
        Me.txtCodInterno.TabIndex = 47
        Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Apellido Paterno :"
        '
        'txtApePat
        '
        Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtApePat._BloquearPaste = False
        Me.txtApePat._SeleccionarTodo = False
        Me.txtApePat.Location = New System.Drawing.Point(123, 95)
        Me.txtApePat.Name = "txtApePat"
        Me.txtApePat.Size = New System.Drawing.Size(143, 20)
        Me.txtApePat.TabIndex = 50
        Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Apellido Materno :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nombres :"
        '
        'txtNom
        '
        Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNom._BloquearPaste = False
        Me.txtNom._SeleccionarTodo = False
        Me.txtNom.Location = New System.Drawing.Point(123, 147)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(143, 20)
        Me.txtNom.TabIndex = 52
        Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'txtApeMat
        '
        Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtApeMat._BloquearPaste = False
        Me.txtApeMat._SeleccionarTodo = False
        Me.txtApeMat.Location = New System.Drawing.Point(123, 121)
        Me.txtApeMat.Name = "txtApeMat"
        Me.txtApeMat.Size = New System.Drawing.Size(143, 20)
        Me.txtApeMat.TabIndex = 51
        Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblReg)
        Me.GroupBox4.Controls.Add(Me.ToolStrip1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox4.Location = New System.Drawing.Point(938, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(98, 243)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        '
        'lblReg
        '
        Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReg.Location = New System.Drawing.Point(3, 218)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(92, 224)
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
        Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
        Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbLimpiar.Name = "tsbLimpiar"
        Me.tsbLimpiar.Size = New System.Drawing.Size(90, 43)
        Me.tsbLimpiar.Text = "Limpiar"
        Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbLimpiar.ToolTipText = "Limpiar"
        '
        'dgwGrilla
        '
        Me.dgwGrilla.AllowUserToAddRows = False
        Me.dgwGrilla.AllowUserToDeleteRows = False
        Me.dgwGrilla.AllowUserToResizeRows = False
        Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
        Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.col_pdr, Me.col_int_id, Me.col_id_loc_row, Me.col_reg_id, Me.col_pen_id, Me.col_id_sed_row, Me.col_ver_int, Me.col_cod_rp, Me.Column3, Me.Column4, Me.col_ape_pat, Me.col_ape_mat, Me.Column1, Me.col_nom, Me.col_sex_nom, Me.col_fec_nac, Me.col_nac_nom, Me.col_pab_nom, Me.col_etp_nom, Me.col_est_nom, Me.col_reg_nom, Me.col_pen_nom})
        Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwGrilla.Location = New System.Drawing.Point(0, 293)
        Me.dgwGrilla.Name = "dgwGrilla"
        Me.dgwGrilla.RowHeadersVisible = False
        Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwGrilla.Size = New System.Drawing.Size(1036, 149)
        Me.dgwGrilla.TabIndex = 57
        Me.dgwGrilla.VisibleCampos = True
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
        Me.pnlBusqueda.Controls.Add(Me.GroupBox4)
        Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBusqueda.Location = New System.Drawing.Point(0, 50)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(1036, 243)
        Me.pnlBusqueda.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.UsrRegionPenal1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1036, 50)
        Me.GroupBox2.TabIndex = 58
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
        Me.UsrRegionPenal1.TabIndex = 53
        Me.UsrRegionPenal1.WidthRegion = 224
        '
        'chkSelect
        '
        Me.chkSelect.AutoSize = True
        Me.chkSelect.Location = New System.Drawing.Point(11, 298)
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Size = New System.Drawing.Size(15, 14)
        Me.chkSelect.TabIndex = 61
        Me.chkSelect.UseVisualStyleBackColor = True
        '
        'col_chk
        '
        Me.col_chk.DividerWidth = 1
        Me.col_chk.HeaderText = ""
        Me.col_chk.Name = "col_chk"
        Me.col_chk.Width = 35
        '
        'col_pdr
        '
        Me.col_pdr.DataPropertyName = "CodigoPadre"
        Me.col_pdr.DividerWidth = 1
        Me.col_pdr.HeaderText = "CodigoPadre"
        Me.col_pdr.Name = "col_pdr"
        Me.col_pdr.ReadOnly = True
        Me.col_pdr.Visible = False
        '
        'col_int_id
        '
        Me.col_int_id.DataPropertyName = "Codigo"
        Me.col_int_id.DividerWidth = 1
        Me.col_int_id.HeaderText = "IDInterno"
        Me.col_int_id.Name = "col_int_id"
        Me.col_int_id.ReadOnly = True
        Me.col_int_id.Visible = False
        '
        'col_id_loc_row
        '
        Me.col_id_loc_row.DataPropertyName = "RowID"
        Me.col_id_loc_row.DividerWidth = 1
        Me.col_id_loc_row.HeaderText = "IDLocalRow"
        Me.col_id_loc_row.Name = "col_id_loc_row"
        Me.col_id_loc_row.Visible = False
        '
        'col_reg_id
        '
        Me.col_reg_id.DataPropertyName = "IDRegion"
        Me.col_reg_id.DividerWidth = 1
        Me.col_reg_id.HeaderText = "IDRegion"
        Me.col_reg_id.Name = "col_reg_id"
        Me.col_reg_id.ReadOnly = True
        Me.col_reg_id.Visible = False
        '
        'col_pen_id
        '
        Me.col_pen_id.DataPropertyName = "IDPenal"
        Me.col_pen_id.DividerWidth = 1
        Me.col_pen_id.HeaderText = "IDPenal"
        Me.col_pen_id.Name = "col_pen_id"
        Me.col_pen_id.ReadOnly = True
        Me.col_pen_id.Visible = False
        '
        'col_id_sed_row
        '
        Me.col_id_sed_row.DataPropertyName = "SedeRowId"
        Me.col_id_sed_row.DividerWidth = 1
        Me.col_id_sed_row.HeaderText = "IDSedeRow"
        Me.col_id_sed_row.Name = "col_id_sed_row"
        Me.col_id_sed_row.Visible = False
        '
        'col_ver_int
        '
        Me.col_ver_int.DataPropertyName = "VersionRegistro"
        Me.col_ver_int.DividerWidth = 1
        Me.col_ver_int.HeaderText = "Ver. Reg. Interno"
        Me.col_ver_int.Name = "col_ver_int"
        Me.col_ver_int.Visible = False
        '
        'col_cod_rp
        '
        Me.col_cod_rp.DataPropertyName = "CodigoRP"
        Me.col_cod_rp.HeaderText = "Codigo"
        Me.col_cod_rp.Name = "col_cod_rp"
        Me.col_cod_rp.ReadOnly = True
        Me.col_cod_rp.Width = 85
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "TipoDocumentoNombre"
        Me.Column3.HeaderText = "Tipo Documento"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "NumeroDocumento"
        Me.Column4.HeaderText = "N° Documento"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'col_ape_pat
        '
        Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
        Me.col_ape_pat.HeaderText = "Paterno"
        Me.col_ape_pat.Name = "col_ape_pat"
        Me.col_ape_pat.ReadOnly = True
        '
        'col_ape_mat
        '
        Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
        Me.col_ape_mat.HeaderText = "Materno"
        Me.col_ape_mat.Name = "col_ape_mat"
        Me.col_ape_mat.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "getRApellidos"
        Me.Column1.HeaderText = "Apellidos"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 150
        '
        'col_nom
        '
        Me.col_nom.DataPropertyName = "Nombres"
        Me.col_nom.HeaderText = "Nombres"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.ReadOnly = True
        Me.col_nom.Width = 200
        '
        'col_sex_nom
        '
        Me.col_sex_nom.DataPropertyName = "SexoNombre"
        Me.col_sex_nom.HeaderText = "Sexo"
        Me.col_sex_nom.Name = "col_sex_nom"
        Me.col_sex_nom.ReadOnly = True
        '
        'col_fec_nac
        '
        Me.col_fec_nac.DataPropertyName = "FechaNacimiento"
        Me.col_fec_nac.HeaderText = "F. Nacimiento"
        Me.col_fec_nac.Name = "col_fec_nac"
        Me.col_fec_nac.ReadOnly = True
        Me.col_fec_nac.Visible = False
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
        'col_pab_nom
        '
        Me.col_pab_nom.DataPropertyName = "PabellonNombre"
        Me.col_pab_nom.HeaderText = "Pabellon"
        Me.col_pab_nom.Name = "col_pab_nom"
        Me.col_pab_nom.ReadOnly = True
        '
        'col_etp_nom
        '
        Me.col_etp_nom.DataPropertyName = "EtapaNombre"
        Me.col_etp_nom.HeaderText = "Etapa"
        Me.col_etp_nom.Name = "col_etp_nom"
        Me.col_etp_nom.ReadOnly = True
        Me.col_etp_nom.Visible = False
        Me.col_etp_nom.Width = 70
        '
        'col_est_nom
        '
        Me.col_est_nom.DataPropertyName = "getEstadoNombre"
        Me.col_est_nom.HeaderText = "Estado"
        Me.col_est_nom.Name = "col_est_nom"
        Me.col_est_nom.ReadOnly = True
        Me.col_est_nom.Width = 70
        '
        'col_reg_nom
        '
        Me.col_reg_nom.DataPropertyName = "RegionNombre"
        Me.col_reg_nom.HeaderText = "Region"
        Me.col_reg_nom.Name = "col_reg_nom"
        Me.col_reg_nom.ReadOnly = True
        Me.col_reg_nom.Visible = False
        Me.col_reg_nom.Width = 150
        '
        'col_pen_nom
        '
        Me.col_pen_nom.DataPropertyName = "PenalNombre"
        Me.col_pen_nom.HeaderText = "Penal"
        Me.col_pen_nom.Name = "col_pen_nom"
        Me.col_pen_nom.ReadOnly = True
        Me.col_pen_nom.Visible = False
        '
        'txtPabellon
        '
        Me.txtPabellon._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPabellon._BloquearPaste = False
        Me.txtPabellon._SeleccionarTodo = False
        Me.txtPabellon.Location = New System.Drawing.Point(6, 18)
        Me.txtPabellon.MaxLength = 100
        Me.txtPabellon.Name = "txtPabellon"
        Me.txtPabellon.Size = New System.Drawing.Size(228, 20)
        Me.txtPabellon.TabIndex = 51
        Me.txtPabellon.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
        Me.txtPabellon.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'uscInternoBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSelect)
        Me.Controls.Add(Me.dgwGrilla)
        Me.Controls.Add(Me.pnlBusqueda)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "uscInternoBuscar"
        Me.Size = New System.Drawing.Size(1036, 442)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbEtapa.ResumeLayout(False)
        Me.grbPabellon.ResumeLayout(False)
        Me.grbPabellon.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBusqueda.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_activo As Legolas.APPUIComponents.myRadioButton
    Friend WithEvents rb_pasivo As Legolas.APPUIComponents.myRadioButton
    Friend WithEvents rb_todos As Legolas.APPUIComponents.myRadioButton
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
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
    Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
    Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
    Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSelect As System.Windows.Forms.CheckBox
    Friend WithEvents grbEtapa As System.Windows.Forms.GroupBox
    Friend WithEvents cbbEtapa As APPControls.uscComboParametrica
    Friend WithEvents grbPabellon As System.Windows.Forms.GroupBox
    Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDoc As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
    Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_chk As DataGridViewCheckBoxColumn
    Friend WithEvents col_pdr As DataGridViewTextBoxColumn
    Friend WithEvents col_int_id As DataGridViewTextBoxColumn
    Friend WithEvents col_id_loc_row As DataGridViewTextBoxColumn
    Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
    Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
    Friend WithEvents col_id_sed_row As DataGridViewTextBoxColumn
    Friend WithEvents col_ver_int As DataGridViewTextBoxColumn
    Friend WithEvents col_cod_rp As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents col_ape_pat As DataGridViewTextBoxColumn
    Friend WithEvents col_ape_mat As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents col_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_sex_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_fec_nac As DataGridViewTextBoxColumn
    Friend WithEvents col_nac_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_pab_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_etp_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
    Friend WithEvents txtPabellon As Legolas.APPUIComponents.MyTextBox
End Class
