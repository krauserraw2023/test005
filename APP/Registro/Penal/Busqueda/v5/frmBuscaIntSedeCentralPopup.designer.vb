Namespace Registro.Penal.Busqueda.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscaIntSedeCentralPopup
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaIntSedeCentralPopup))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSiguiente = New System.Windows.Forms.Button()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnRegNuevo = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblTotReg01 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.grbBusDNI = New System.Windows.Forms.GroupBox()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.grbBusApellidos = New System.Windows.Forms.GroupBox()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.rdbPorDni = New System.Windows.Forms.RadioButton()
            Me.rdbApellidos = New System.Windows.Forms.RadioButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_row_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_doc_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_ident = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pizq_arch_dig_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pfron_arch_dig_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pder_arch_dig_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.rdbPD = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPF = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPI = New Legolas.APPUIComponents.myRadioButton()
            Me.pnlFoto = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.grbBusDNI.SuspendLayout()
            Me.grbBusApellidos.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.pnlFoto.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlFoto)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlBusqueda)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.lblTitulo)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(977, 467)
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "database_icon.png")
            Me.ImageList1.Images.SetKeyName(1, "bd_remote.jpg")
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnSiguiente)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 415)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(977, 52)
            Me.Panel1.TabIndex = 52
            '
            'btnSiguiente
            '
            Me.btnSiguiente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSiguiente.BackColor = System.Drawing.Color.Transparent
            Me.btnSiguiente.Image = Global.SIPPOPE.My.Resources.Resources.logo_reniec
            Me.btnSiguiente.Location = New System.Drawing.Point(138, 3)
            Me.btnSiguiente.Name = "btnSiguiente"
            Me.btnSiguiente.Size = New System.Drawing.Size(128, 47)
            Me.btnSiguiente.TabIndex = 110
            Me.btnSiguiente.Text = "Buscar en reniec"
            Me.btnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSiguiente.UseVisualStyleBackColor = False
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnRegNuevo)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(135, 52)
            Me.Panel4.TabIndex = 109
            '
            'btnRegNuevo
            '
            Me.btnRegNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRegNuevo.Image = Global.SIPPOPE.My.Resources.Resources.id_card_view
            Me.btnRegNuevo.Location = New System.Drawing.Point(4, 3)
            Me.btnRegNuevo.Name = "btnRegNuevo"
            Me.btnRegNuevo.Size = New System.Drawing.Size(128, 45)
            Me.btnRegNuevo.TabIndex = 107
            Me.btnRegNuevo.Text = "Registrar manualmente"
            Me.btnRegNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnAceptar)
            Me.Panel3.Controls.Add(Me.btnCancel)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(760, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(217, 52)
            Me.Panel3.TabIndex = 108
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(2, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(105, 45)
            Me.btnAceptar.TabIndex = 104
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(107, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 45)
            Me.btnCancel.TabIndex = 105
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlBusqueda.Controls.Add(Me.GroupBox2)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 22)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(977, 131)
            Me.pnlBusqueda.TabIndex = 55
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblTotReg01)
            Me.GroupBox2.Controls.Add(Me.Panel2)
            Me.GroupBox2.Controls.Add(Me.Panel6)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(893, 129)
            Me.GroupBox2.TabIndex = 57
            Me.GroupBox2.TabStop = False
            '
            'lblTotReg01
            '
            Me.lblTotReg01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTotReg01.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblTotReg01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotReg01.Location = New System.Drawing.Point(3, 109)
            Me.lblTotReg01.Name = "lblTotReg01"
            Me.lblTotReg01.Size = New System.Drawing.Size(887, 17)
            Me.lblTotReg01.TabIndex = 60
            Me.lblTotReg01.Text = "0 Reg."
            Me.lblTotReg01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.grbBusDNI)
            Me.Panel2.Controls.Add(Me.grbBusApellidos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(3, 40)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(887, 86)
            Me.Panel2.TabIndex = 56
            '
            'grbBusDNI
            '
            Me.grbBusDNI.Controls.Add(Me.cbbTipoDoc)
            Me.grbBusDNI.Controls.Add(Me.Label2)
            Me.grbBusDNI.Controls.Add(Me.txtNumDoc)
            Me.grbBusDNI.Controls.Add(Me.Label1)
            Me.grbBusDNI.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusDNI.Location = New System.Drawing.Point(0, 0)
            Me.grbBusDNI.Name = "grbBusDNI"
            Me.grbBusDNI.Size = New System.Drawing.Size(887, 86)
            Me.grbBusDNI.TabIndex = 56
            Me.grbBusDNI.TabStop = False
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
            Me.cbbTipoDoc.ComboTipo = CType(2, Short)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 150
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(90, 19)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(208, 22)
            Me.cbbTipoDoc.TabIndex = 46
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(315, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(89, 13)
            Me.Label2.TabIndex = 44
            Me.Label2.Text = "Número de doc. :"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(412, 21)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(188, 20)
            Me.txtNumDoc.TabIndex = 47
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(7, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(84, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "Tipo doc. ident.:"
            '
            'grbBusApellidos
            '
            Me.grbBusApellidos.Controls.Add(Me.txtNom)
            Me.grbBusApellidos.Controls.Add(Me.Label29)
            Me.grbBusApellidos.Controls.Add(Me.Label27)
            Me.grbBusApellidos.Controls.Add(Me.txtApePat)
            Me.grbBusApellidos.Controls.Add(Me.txtApeMat)
            Me.grbBusApellidos.Controls.Add(Me.Label28)
            Me.grbBusApellidos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusApellidos.Location = New System.Drawing.Point(0, 0)
            Me.grbBusApellidos.Name = "grbBusApellidos"
            Me.grbBusApellidos.Size = New System.Drawing.Size(887, 86)
            Me.grbBusApellidos.TabIndex = 57
            Me.grbBusApellidos.TabStop = False
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(90, 36)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(510, 20)
            Me.txtNom.TabIndex = 33
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Location = New System.Drawing.Point(6, 18)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(82, 13)
            Me.Label29.TabIndex = 28
            Me.Label29.Text = "Primer Apellido :"
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(33, 40)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(55, 13)
            Me.Label27.TabIndex = 30
            Me.Label27.Text = "Nombres :"
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.BackColor = System.Drawing.SystemColors.Info
            Me.txtApePat.ForeColor = System.Drawing.SystemColors.InfoText
            Me.txtApePat.Location = New System.Drawing.Point(90, 13)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(208, 20)
            Me.txtApePat.TabIndex = 31
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer))
            Me.txtApeMat.Location = New System.Drawing.Point(412, 12)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(188, 20)
            Me.txtApeMat.TabIndex = 32
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(312, 16)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(93, 13)
            Me.Label28.TabIndex = 29
            Me.Label28.Text = "Segundo Apellido:"
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.rdbPorDni)
            Me.Panel6.Controls.Add(Me.rdbApellidos)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(3, 16)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(887, 24)
            Me.Panel6.TabIndex = 61
            '
            'rdbPorDni
            '
            Me.rdbPorDni.AutoSize = True
            Me.rdbPorDni.BackColor = System.Drawing.Color.Transparent
            Me.rdbPorDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPorDni.Location = New System.Drawing.Point(213, 3)
            Me.rdbPorDni.Name = "rdbPorDni"
            Me.rdbPorDni.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.rdbPorDni.Size = New System.Drawing.Size(136, 19)
            Me.rdbPorDni.TabIndex = 58
            Me.rdbPorDni.Text = "Por Doc. Identidad"
            Me.rdbPorDni.UseVisualStyleBackColor = False
            '
            'rdbApellidos
            '
            Me.rdbApellidos.AutoSize = True
            Me.rdbApellidos.BackColor = System.Drawing.Color.Transparent
            Me.rdbApellidos.Checked = True
            Me.rdbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbApellidos.Location = New System.Drawing.Point(81, 3)
            Me.rdbApellidos.Name = "rdbApellidos"
            Me.rdbApellidos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.rdbApellidos.Size = New System.Drawing.Size(107, 19)
            Me.rdbApellidos.TabIndex = 59
            Me.rdbApellidos.TabStop = True
            Me.rdbApellidos.Text = "Por apellidos"
            Me.rdbApellidos.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.ToolStrip1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox1.Location = New System.Drawing.Point(893, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(82, 129)
            Me.GroupBox1.TabIndex = 62
            Me.GroupBox1.TabStop = False
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
            Me.ToolStrip1.Size = New System.Drawing.Size(76, 110)
            Me.ToolStrip1.TabIndex = 61
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(74, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbBuscar.ToolTipText = "BUSCAR"
            '
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(74, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiar.ToolTipText = "Limpiar"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_id, Me.col_sed_row_id, Me.col_pdr, Me.col_cod_rp, Me.col_tip_doc_id, Me.Column3, Me.col_num_doc, Me.col_doc_ident, Me.col_ape_pat, Me.col_ape_mat, Me.col_ape, Me.col_nom, Me.col_nom_comp, Me.Column1, Me.col_reg_id, Me.col_pen_id, Me.col_pen_nom, Me.col_ing_fec, Me.col_est_id, Me.col_est_nom, Me.col_pizq_arch_dig_id, Me.col_pfron_arch_dig_id, Me.col_pder_arch_dig_id})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 153)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(770, 262)
            Me.dgwGrilla.TabIndex = 56
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "int_id"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_sed_row_id
            '
            Me.col_sed_row_id.DataPropertyName = "_sed_rowid"
            Me.col_sed_row_id.HeaderText = "_sed_rowid"
            Me.col_sed_row_id.Name = "col_sed_row_id"
            Me.col_sed_row_id.ReadOnly = True
            Me.col_sed_row_id.Visible = False
            '
            'col_pdr
            '
            Me.col_pdr.DataPropertyName = "CodigoPadre"
            Me.col_pdr.HeaderText = "CodigoPadre"
            Me.col_pdr.Name = "col_pdr"
            Me.col_pdr.ReadOnly = True
            Me.col_pdr.Visible = False
            '
            'col_cod_rp
            '
            Me.col_cod_rp.DataPropertyName = "int_cod_rp"
            Me.col_cod_rp.DividerWidth = 1
            Me.col_cod_rp.HeaderText = "Código"
            Me.col_cod_rp.Name = "col_cod_rp"
            Me.col_cod_rp.ReadOnly = True
            Me.col_cod_rp.Width = 75
            '
            'col_tip_doc_id
            '
            Me.col_tip_doc_id.DataPropertyName = "tip_doc_id"
            Me.col_tip_doc_id.HeaderText = "IDTipoDocumento"
            Me.col_tip_doc_id.Name = "col_tip_doc_id"
            Me.col_tip_doc_id.ReadOnly = True
            Me.col_tip_doc_id.Visible = False
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "tip_doc_nom"
            Me.Column3.HeaderText = "Tipo Doc."
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Visible = False
            Me.Column3.Width = 80
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "int_doc_num"
            Me.col_num_doc.HeaderText = "N° Doc."
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            Me.col_num_doc.Visible = False
            Me.col_num_doc.Width = 80
            '
            'col_doc_ident
            '
            Me.col_doc_ident.DataPropertyName = "tip_y_num_doc"
            Me.col_doc_ident.HeaderText = "Doc. Identidad"
            Me.col_doc_ident.Name = "col_doc_ident"
            Me.col_doc_ident.ReadOnly = True
            Me.col_doc_ident.Width = 140
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "int_ape_pat"
            Me.col_ape_pat.HeaderText = "Primer Apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Visible = False
            Me.col_ape_pat.Width = 110
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "int_ape_mat"
            Me.col_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Visible = False
            Me.col_ape_mat.Width = 115
            '
            'col_ape
            '
            Me.col_ape.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_ape.DataPropertyName = "int_apellidos"
            Me.col_ape.HeaderText = "Apellidos"
            Me.col_ape.Name = "col_ape"
            Me.col_ape.ReadOnly = True
            Me.col_ape.Visible = False
            Me.col_ape.Width = 145
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "int_nom"
            Me.col_nom.HeaderText = "Pre Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Visible = False
            Me.col_nom.Width = 145
            '
            'col_nom_comp
            '
            Me.col_nom_comp.DataPropertyName = "int_nom_completo"
            Me.col_nom_comp.HeaderText = "Nombres"
            Me.col_nom_comp.Name = "col_nom_comp"
            Me.col_nom_comp.ReadOnly = True
            Me.col_nom_comp.Width = 200
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "reg_nom"
            Me.Column1.HeaderText = "Region"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "reg_id"
            Me.col_reg_id.HeaderText = "IDRegion"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "pen_id"
            Me.col_pen_id.HeaderText = "IDPenal"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "pen_nom"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Width = 140
            '
            'col_ing_fec
            '
            Me.col_ing_fec.DataPropertyName = "int_ing_fec"
            Me.col_ing_fec.HeaderText = "Fecha Ingreso"
            Me.col_ing_fec.Name = "col_ing_fec"
            Me.col_ing_fec.ReadOnly = True
            Me.col_ing_fec.Width = 98
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "int_est_id"
            Me.col_est_id.HeaderText = "EstadoID"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.ReadOnly = True
            Me.col_est_id.Visible = False
            '
            'col_est_nom
            '
            Me.col_est_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_est_nom.DataPropertyName = "int_est_nom"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            '
            'col_pizq_arch_dig_id
            '
            Me.col_pizq_arch_dig_id.DataPropertyName = "aut_fot_izq"
            Me.col_pizq_arch_dig_id.HeaderText = "col_pizq_id"
            Me.col_pizq_arch_dig_id.Name = "col_pizq_arch_dig_id"
            Me.col_pizq_arch_dig_id.ReadOnly = True
            Me.col_pizq_arch_dig_id.Visible = False
            '
            'col_pfron_arch_dig_id
            '
            Me.col_pfron_arch_dig_id.DataPropertyName = "aut_fot_fre"
            Me.col_pfron_arch_dig_id.HeaderText = "col_pfre_id"
            Me.col_pfron_arch_dig_id.Name = "col_pfron_arch_dig_id"
            Me.col_pfron_arch_dig_id.ReadOnly = True
            Me.col_pfron_arch_dig_id.Visible = False
            '
            'col_pder_arch_dig_id
            '
            Me.col_pder_arch_dig_id.DataPropertyName = "aut_fot_der"
            Me.col_pder_arch_dig_id.HeaderText = "col_pder_id"
            Me.col_pder_arch_dig_id.Name = "col_pder_arch_dig_id"
            Me.col_pder_arch_dig_id.ReadOnly = True
            Me.col_pder_arch_dig_id.Visible = False
            '
            'lblTitulo
            '
            Me.lblTitulo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(977, 22)
            Me.lblTitulo.TabIndex = 56
            Me.lblTitulo.Text = "BUSQUEDA EN LA BASE DE DATOS SEDE CENTRAL"
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(207, 239)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 0
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.rdbPD)
            Me.Panel5.Controls.Add(Me.rdbPF)
            Me.Panel5.Controls.Add(Me.rdbPI)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 239)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(207, 23)
            Me.Panel5.TabIndex = 0
            '
            'rdbPD
            '
            Me.rdbPD.AutoSize = True
            Me.rdbPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPD.Location = New System.Drawing.Point(118, 3)
            Me.rdbPD.Name = "rdbPD"
            Me.rdbPD.Size = New System.Drawing.Size(42, 17)
            Me.rdbPD.TabIndex = 2
            Me.rdbPD.Text = "PD"
            Me.rdbPD.UseVisualStyleBackColor = True
            '
            'rdbPF
            '
            Me.rdbPF.AutoSize = True
            Me.rdbPF.Checked = True
            Me.rdbPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPF.Location = New System.Drawing.Point(67, 3)
            Me.rdbPF.Name = "rdbPF"
            Me.rdbPF.Size = New System.Drawing.Size(40, 17)
            Me.rdbPF.TabIndex = 1
            Me.rdbPF.TabStop = True
            Me.rdbPF.Text = "PF"
            Me.rdbPF.UseVisualStyleBackColor = True
            '
            'rdbPI
            '
            Me.rdbPI.AutoSize = True
            Me.rdbPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPI.Location = New System.Drawing.Point(9, 3)
            Me.rdbPI.Name = "rdbPI"
            Me.rdbPI.Size = New System.Drawing.Size(37, 17)
            Me.rdbPI.TabIndex = 0
            Me.rdbPI.Text = "PI"
            Me.rdbPI.UseVisualStyleBackColor = True
            '
            'pnlFoto
            '
            Me.pnlFoto.Controls.Add(Me.UscFotografia_2v1)
            Me.pnlFoto.Controls.Add(Me.Panel5)
            Me.pnlFoto.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlFoto.Location = New System.Drawing.Point(770, 153)
            Me.pnlFoto.Name = "pnlFoto"
            Me.pnlFoto.Size = New System.Drawing.Size(207, 262)
            Me.pnlFoto.TabIndex = 58
            Me.pnlFoto.Visible = False
            '
            'frmBuscaIntSedeCentralPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(977, 467)
            Me.Name = "frmBuscaIntSedeCentralPopup"
            Me.Text = "Busqueda en la base de datos Sede Central"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.grbBusDNI.ResumeLayout(False)
            Me.grbBusDNI.PerformLayout()
            Me.grbBusApellidos.ResumeLayout(False)
            Me.grbBusApellidos.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlFoto.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents btnRegNuevo As System.Windows.Forms.Button
        Friend WithEvents lblTotReg01 As System.Windows.Forms.Label
        Friend WithEvents rdbApellidos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPorDni As System.Windows.Forms.RadioButton
        Friend WithEvents grbBusApellidos As System.Windows.Forms.GroupBox
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents grbBusDNI As System.Windows.Forms.GroupBox
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents tsbLimpiar As ToolStripButton
        Friend WithEvents pnlFoto As Panel
        Friend WithEvents Panel5 As Panel
        Friend WithEvents rdbPD As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPF As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPI As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents btnSiguiente As Button
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_row_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pdr As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_doc_id As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_ident As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_comp As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_fec As DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pizq_arch_dig_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pfron_arch_dig_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pder_arch_dig_id As DataGridViewTextBoxColumn
    End Class
End Namespace