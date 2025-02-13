Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmUsuarioPopupBasico
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.chkModuloUsuarios = New System.Windows.Forms.CheckBox()
            Me.chkValPC = New System.Windows.Forms.CheckBox()
            Me.grbUsuario = New System.Windows.Forms.GroupBox()
            Me.txtApellidosnombres = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtCueUsuario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTrabajador = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.chkLogin = New System.Windows.Forms.CheckBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.chkValidarPorHuella = New System.Windows.Forms.CheckBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCorreo = New System.Windows.Forms.TextBox()
            Me.cbbDependencia = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbNivelUsuario = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtCargo = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtNom = New System.Windows.Forms.TextBox()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtApeMat = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtApePaterno = New System.Windows.Forms.TextBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.DgwPC = New System.Windows.Forms.DataGridView()
            Me.col_ite = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usu_pc_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pc_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hos_nam = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnAddPc = New System.Windows.Forms.Button()
            Me.pnlTrabajador = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.BtnActivarUsuario = New System.Windows.Forms.Button()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.BtnOk = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.pnlPrincipal = New System.Windows.Forms.Panel()
            Me.DgwPermisos = New System.Windows.Forms.DataGridView()
            Me.col_display = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_display2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_modulos = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_modulo_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo_padre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_read = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_write = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_reporte = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_impresion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.DgwPenal = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.BtnEliminar = New System.Windows.Forms.Button()
            Me.BtnAddPenal = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.grbUsuario.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.DgwPC, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.pnlTrabajador.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.pnlPrincipal.SuspendLayout()
            CType(Me.DgwPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            CType(Me.DgwPenal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtUsuario
            '
            Me.txtUsuario.Location = New System.Drawing.Point(118, 25)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.ReadOnly = True
            Me.txtUsuario.Size = New System.Drawing.Size(93, 20)
            Me.txtUsuario.TabIndex = 43
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(12, 27)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(49, 13)
            Me.Label26.TabIndex = 44
            Me.Label26.Text = "Usuario :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox5)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox1.Location = New System.Drawing.Point(3, 283)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(819, 74)
            Me.GroupBox1.TabIndex = 51
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Permisos"
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.chkModuloUsuarios)
            Me.GroupBox5.Controls.Add(Me.chkValPC)
            Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox5.Location = New System.Drawing.Point(3, 16)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(813, 55)
            Me.GroupBox5.TabIndex = 51
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Administración"
            '
            'chkModuloUsuarios
            '
            Me.chkModuloUsuarios.AutoSize = True
            Me.chkModuloUsuarios.Location = New System.Drawing.Point(97, 19)
            Me.chkModuloUsuarios.Name = "chkModuloUsuarios"
            Me.chkModuloUsuarios.Size = New System.Drawing.Size(120, 17)
            Me.chkModuloUsuarios.TabIndex = 54
            Me.chkModuloUsuarios.Text = "Modulo de Usuarios"
            Me.chkModuloUsuarios.UseVisualStyleBackColor = True
            '
            'chkValPC
            '
            Me.chkValPC.AutoSize = True
            Me.chkValPC.Location = New System.Drawing.Point(6, 19)
            Me.chkValPC.Name = "chkValPC"
            Me.chkValPC.Size = New System.Drawing.Size(75, 17)
            Me.chkValPC.TabIndex = 53
            Me.chkValPC.Text = "Validar PC"
            Me.chkValPC.UseVisualStyleBackColor = True
            '
            'grbUsuario
            '
            Me.grbUsuario.Controls.Add(Me.txtApellidosnombres)
            Me.grbUsuario.Controls.Add(Me.Label10)
            Me.grbUsuario.Controls.Add(Me.Panel1)
            Me.grbUsuario.Controls.Add(Me.chkLogin)
            Me.grbUsuario.Controls.Add(Me.txtUsuario)
            Me.grbUsuario.Controls.Add(Me.Label26)
            Me.grbUsuario.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbUsuario.Location = New System.Drawing.Point(0, 0)
            Me.grbUsuario.Name = "grbUsuario"
            Me.grbUsuario.Size = New System.Drawing.Size(833, 115)
            Me.grbUsuario.TabIndex = 52
            Me.grbUsuario.TabStop = False
            Me.grbUsuario.Text = "Datos de Usuario"
            '
            'txtApellidosnombres
            '
            Me.txtApellidosnombres.Location = New System.Drawing.Point(118, 64)
            Me.txtApellidosnombres.Name = "txtApellidosnombres"
            Me.txtApellidosnombres.ReadOnly = True
            Me.txtApellidosnombres.Size = New System.Drawing.Size(290, 20)
            Me.txtApellidosnombres.TabIndex = 64
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(12, 66)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(106, 13)
            Me.Label10.TabIndex = 65
            Me.Label10.Text = "Apellidos y nombres :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label9)
            Me.Panel1.Controls.Add(Me.txtCueUsuario)
            Me.Panel1.Controls.Add(Me.txtTrabajador)
            Me.Panel1.Controls.Add(Me.Label11)
            Me.Panel1.Location = New System.Drawing.Point(519, 49)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(221, 59)
            Me.Panel1.TabIndex = 63
            Me.Panel1.Visible = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(3, 9)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(74, 13)
            Me.Label9.TabIndex = 55
            Me.Label9.Text = "CUE Usuario :"
            '
            'txtCueUsuario
            '
            Me.txtCueUsuario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCueUsuario._BloquearPaste = False
            Me.txtCueUsuario._SeleccionarTodo = False
            Me.txtCueUsuario.Location = New System.Drawing.Point(104, 6)
            Me.txtCueUsuario.Name = "txtCueUsuario"
            Me.txtCueUsuario.ReadOnly = True
            Me.txtCueUsuario.Size = New System.Drawing.Size(93, 20)
            Me.txtCueUsuario.TabIndex = 56
            Me.txtCueUsuario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCueUsuario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtTrabajador
            '
            Me.txtTrabajador._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTrabajador._BloquearPaste = False
            Me.txtTrabajador._SeleccionarTodo = False
            Me.txtTrabajador.Location = New System.Drawing.Point(104, 32)
            Me.txtTrabajador.Name = "txtTrabajador"
            Me.txtTrabajador.ReadOnly = True
            Me.txtTrabajador.Size = New System.Drawing.Size(93, 20)
            Me.txtTrabajador.TabIndex = 60
            Me.txtTrabajador.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTrabajador.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(3, 35)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(78, 13)
            Me.Label11.TabIndex = 59
            Me.Label11.Text = "Trabajador ID :"
            '
            'chkLogin
            '
            Me.chkLogin.AutoSize = True
            Me.chkLogin.Location = New System.Drawing.Point(217, 27)
            Me.chkLogin.Name = "chkLogin"
            Me.chkLogin.Size = New System.Drawing.Size(90, 17)
            Me.chkLogin.TabIndex = 52
            Me.chkLogin.Text = "Habiliar Login"
            Me.chkLogin.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.chkValidarPorHuella)
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.txtCorreo)
            Me.GroupBox3.Controls.Add(Me.cbbDependencia)
            Me.GroupBox3.Controls.Add(Me.Label1)
            Me.GroupBox3.Controls.Add(Me.cbbNivelUsuario)
            Me.GroupBox3.Controls.Add(Me.Label3)
            Me.GroupBox3.Controls.Add(Me.txtCargo)
            Me.GroupBox3.Controls.Add(Me.Label8)
            Me.GroupBox3.Controls.Add(Me.Label7)
            Me.GroupBox3.Controls.Add(Me.txtNom)
            Me.GroupBox3.Controls.Add(Me.txtNumDoc)
            Me.GroupBox3.Controls.Add(Me.Label4)
            Me.GroupBox3.Controls.Add(Me.txtApeMat)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.txtApePaterno)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(317, 280)
            Me.GroupBox3.TabIndex = 53
            Me.GroupBox3.TabStop = False
            '
            'chkValidarPorHuella
            '
            Me.chkValidarPorHuella.AutoSize = True
            Me.chkValidarPorHuella.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkValidarPorHuella.Location = New System.Drawing.Point(9, 254)
            Me.chkValidarPorHuella.Name = "chkValidarPorHuella"
            Me.chkValidarPorHuella.Size = New System.Drawing.Size(231, 19)
            Me.chkValidarPorHuella.TabIndex = 73
            Me.chkValidarPorHuella.Text = "Habilitar el inicio de sesión por huella"
            Me.chkValidarPorHuella.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 203)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 13)
            Me.Label2.TabIndex = 70
            Me.Label2.Text = "Email :"
            '
            'txtCorreo
            '
            Me.txtCorreo.Location = New System.Drawing.Point(9, 221)
            Me.txtCorreo.MaxLength = 64
            Me.txtCorreo.Name = "txtCorreo"
            Me.txtCorreo.Size = New System.Drawing.Size(294, 20)
            Me.txtCorreo.TabIndex = 69
            '
            'cbbDependencia
            '
            Me.cbbDependencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDependencia.DropDownWidth = 250
            Me.cbbDependencia.FormattingEnabled = True
            Me.cbbDependencia.Location = New System.Drawing.Point(113, 148)
            Me.cbbDependencia.Name = "cbbDependencia"
            Me.cbbDependencia.Size = New System.Drawing.Size(190, 21)
            Me.cbbDependencia.TabIndex = 68
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(8, 122)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(89, 13)
            Me.Label1.TabIndex = 67
            Me.Label1.Text = "Nivel de usuario :"
            '
            'cbbNivelUsuario
            '
            Me.cbbNivelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbNivelUsuario.FormattingEnabled = True
            Me.cbbNivelUsuario.Location = New System.Drawing.Point(113, 119)
            Me.cbbNivelUsuario.Name = "cbbNivelUsuario"
            Me.cbbNivelUsuario.Size = New System.Drawing.Size(190, 21)
            Me.cbbNivelUsuario.TabIndex = 66
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 180)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(41, 13)
            Me.Label3.TabIndex = 65
            Me.Label3.Text = "Cargo :"
            '
            'txtCargo
            '
            Me.txtCargo.Location = New System.Drawing.Point(113, 176)
            Me.txtCargo.Name = "txtCargo"
            Me.txtCargo.Size = New System.Drawing.Size(190, 20)
            Me.txtCargo.TabIndex = 61
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(8, 151)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(77, 13)
            Me.Label8.TabIndex = 62
            Me.Label8.Text = "Oficina /Perfil :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(8, 17)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(54, 13)
            Me.Label7.TabIndex = 60
            Me.Label7.Text = "N°  Doc. :"
            '
            'txtNom
            '
            Me.txtNom.Location = New System.Drawing.Point(113, 91)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.ReadOnly = True
            Me.txtNom.Size = New System.Drawing.Size(190, 20)
            Me.txtNom.TabIndex = 57
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(113, 14)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(89, 20)
            Me.txtNumDoc.TabIndex = 63
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 94)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 58
            Me.Label4.Text = "Nombres :"
            '
            'txtApeMat
            '
            Me.txtApeMat.Location = New System.Drawing.Point(113, 65)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.ReadOnly = True
            Me.txtApeMat.Size = New System.Drawing.Size(190, 20)
            Me.txtApeMat.TabIndex = 55
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 42)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(75, 13)
            Me.Label5.TabIndex = 54
            Me.Label5.Text = "Ape. Paterno :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(8, 68)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(77, 13)
            Me.Label6.TabIndex = 56
            Me.Label6.Text = "Ape. Materno :"
            '
            'txtApePaterno
            '
            Me.txtApePaterno.Location = New System.Drawing.Point(113, 39)
            Me.txtApePaterno.Name = "txtApePaterno"
            Me.txtApePaterno.ReadOnly = True
            Me.txtApePaterno.Size = New System.Drawing.Size(190, 20)
            Me.txtApePaterno.TabIndex = 53
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.DgwPC)
            Me.GroupBox4.Controls.Add(Me.Panel3)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(317, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(502, 280)
            Me.GroupBox4.TabIndex = 54
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "P.C."
            '
            'DgwPC
            '
            Me.DgwPC.AllowUserToAddRows = False
            Me.DgwPC.AllowUserToDeleteRows = False
            Me.DgwPC.AllowUserToOrderColumns = True
            Me.DgwPC.BackgroundColor = System.Drawing.Color.White
            Me.DgwPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DgwPC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ite, Me.col_usu_pc_id, Me.col_pc_id, Me.col_hos_nam, Me.col_mac})
            Me.DgwPC.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DgwPC.Location = New System.Drawing.Point(3, 49)
            Me.DgwPC.MultiSelect = False
            Me.DgwPC.Name = "DgwPC"
            Me.DgwPC.ReadOnly = True
            Me.DgwPC.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.DgwPC.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DgwPC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DgwPC.Size = New System.Drawing.Size(496, 228)
            Me.DgwPC.TabIndex = 4
            '
            'col_ite
            '
            Me.col_ite.HeaderText = "Item"
            Me.col_ite.Name = "col_ite"
            Me.col_ite.ReadOnly = True
            Me.col_ite.Visible = False
            '
            'col_usu_pc_id
            '
            Me.col_usu_pc_id.HeaderText = "UsuarioPCID"
            Me.col_usu_pc_id.Name = "col_usu_pc_id"
            Me.col_usu_pc_id.ReadOnly = True
            Me.col_usu_pc_id.Visible = False
            '
            'col_pc_id
            '
            Me.col_pc_id.HeaderText = "PCID"
            Me.col_pc_id.Name = "col_pc_id"
            Me.col_pc_id.ReadOnly = True
            Me.col_pc_id.Visible = False
            '
            'col_hos_nam
            '
            Me.col_hos_nam.HeaderText = "HostName"
            Me.col_hos_nam.Name = "col_hos_nam"
            Me.col_hos_nam.ReadOnly = True
            Me.col_hos_nam.Width = 120
            '
            'col_mac
            '
            Me.col_mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_mac.HeaderText = "M.A.C."
            Me.col_mac.Name = "col_mac"
            Me.col_mac.ReadOnly = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnAddPc)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(496, 33)
            Me.Panel3.TabIndex = 5
            '
            'btnAddPc
            '
            Me.btnAddPc.Location = New System.Drawing.Point(313, 6)
            Me.btnAddPc.Name = "btnAddPc"
            Me.btnAddPc.Size = New System.Drawing.Size(94, 23)
            Me.btnAddPc.TabIndex = 46
            Me.btnAddPc.Text = "Agregar PC."
            '
            'pnlTrabajador
            '
            Me.pnlTrabajador.Controls.Add(Me.GroupBox4)
            Me.pnlTrabajador.Controls.Add(Me.GroupBox3)
            Me.pnlTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlTrabajador.Location = New System.Drawing.Point(3, 3)
            Me.pnlTrabajador.Name = "pnlTrabajador"
            Me.pnlTrabajador.Size = New System.Drawing.Size(819, 280)
            Me.pnlTrabajador.TabIndex = 56
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel6)
            Me.Panel2.Controls.Add(Me.Panel4)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 501)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(833, 45)
            Me.Panel2.TabIndex = 57
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.BtnActivarUsuario)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel6.Location = New System.Drawing.Point(0, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(136, 45)
            Me.Panel6.TabIndex = 48
            '
            'BtnActivarUsuario
            '
            Me.BtnActivarUsuario.Enabled = False
            Me.BtnActivarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnActivarUsuario.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.BtnActivarUsuario.Location = New System.Drawing.Point(3, 3)
            Me.BtnActivarUsuario.Name = "BtnActivarUsuario"
            Me.BtnActivarUsuario.Size = New System.Drawing.Size(123, 40)
            Me.BtnActivarUsuario.TabIndex = 45
            Me.BtnActivarUsuario.Text = "Activar usuario"
            Me.BtnActivarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.BtnOk)
            Me.Panel4.Controls.Add(Me.BtnCancel)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel4.Location = New System.Drawing.Point(626, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(207, 45)
            Me.Panel4.TabIndex = 47
            '
            'BtnOk
            '
            Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnOk.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.BtnOk.Location = New System.Drawing.Point(3, 3)
            Me.BtnOk.Name = "BtnOk"
            Me.BtnOk.Size = New System.Drawing.Size(94, 40)
            Me.BtnOk.TabIndex = 45
            Me.BtnOk.Text = "&Grabar"
            Me.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'BtnCancel
            '
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.BtnCancel.Location = New System.Drawing.Point(102, 3)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(94, 40)
            Me.BtnCancel.TabIndex = 46
            Me.BtnCancel.Text = "&Salir"
            Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 115)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(833, 386)
            Me.TabControl1.TabIndex = 52
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.pnlTrabajador)
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(825, 360)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Datos del trabajador"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.pnlPrincipal)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(825, 360)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Permisos"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'pnlPrincipal
            '
            Me.pnlPrincipal.Controls.Add(Me.DgwPermisos)
            Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPrincipal.Location = New System.Drawing.Point(3, 3)
            Me.pnlPrincipal.Name = "pnlPrincipal"
            Me.pnlPrincipal.Size = New System.Drawing.Size(819, 354)
            Me.pnlPrincipal.TabIndex = 197
            '
            'DgwPermisos
            '
            Me.DgwPermisos.AllowUserToAddRows = False
            Me.DgwPermisos.AllowUserToDeleteRows = False
            Me.DgwPermisos.AllowUserToResizeColumns = False
            Me.DgwPermisos.AllowUserToResizeRows = False
            Me.DgwPermisos.BackgroundColor = System.Drawing.Color.White
            Me.DgwPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DgwPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.DgwPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DgwPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_display, Me.col_display2, Me.col_modulos, Me.col_modulo_codigo, Me.col_codigo_padre, Me.col_read, Me.col_write, Me.col_reporte, Me.col_impresion, Me.col_eliminar, Me.col_codigo})
            Me.DgwPermisos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DgwPermisos.Location = New System.Drawing.Point(0, 0)
            Me.DgwPermisos.Margin = New System.Windows.Forms.Padding(0)
            Me.DgwPermisos.MultiSelect = False
            Me.DgwPermisos.Name = "DgwPermisos"
            Me.DgwPermisos.ReadOnly = True
            Me.DgwPermisos.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.DgwPermisos.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.DgwPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.DgwPermisos.Size = New System.Drawing.Size(819, 354)
            Me.DgwPermisos.TabIndex = 0
            '
            'col_display
            '
            Me.col_display.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.col_display.Frozen = True
            Me.col_display.HeaderText = ""
            Me.col_display.Name = "col_display"
            Me.col_display.ReadOnly = True
            Me.col_display.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_display.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_display.Width = 5
            '
            'col_display2
            '
            Me.col_display2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.col_display2.Frozen = True
            Me.col_display2.HeaderText = ""
            Me.col_display2.MinimumWidth = 2
            Me.col_display2.Name = "col_display2"
            Me.col_display2.ReadOnly = True
            Me.col_display2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_display2.Width = 2
            '
            'col_modulos
            '
            Me.col_modulos.DataPropertyName = "ModuloNombre"
            Me.col_modulos.Frozen = True
            Me.col_modulos.HeaderText = "Modulos"
            Me.col_modulos.Name = "col_modulos"
            Me.col_modulos.ReadOnly = True
            Me.col_modulos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_modulos.Width = 340
            '
            'col_modulo_codigo
            '
            Me.col_modulo_codigo.DataPropertyName = "ModuloCodigo"
            Me.col_modulo_codigo.Frozen = True
            Me.col_modulo_codigo.HeaderText = "ModuloCodigo"
            Me.col_modulo_codigo.Name = "col_modulo_codigo"
            Me.col_modulo_codigo.ReadOnly = True
            Me.col_modulo_codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_modulo_codigo.Visible = False
            Me.col_modulo_codigo.Width = 20
            '
            'col_codigo_padre
            '
            Me.col_codigo_padre.DataPropertyName = "ModuloCodigoPadre"
            Me.col_codigo_padre.Frozen = True
            Me.col_codigo_padre.HeaderText = "CodigoPadre"
            Me.col_codigo_padre.Name = "col_codigo_padre"
            Me.col_codigo_padre.ReadOnly = True
            Me.col_codigo_padre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_codigo_padre.Visible = False
            Me.col_codigo_padre.Width = 20
            '
            'col_read
            '
            Me.col_read.DataPropertyName = "Lectura"
            Me.col_read.Frozen = True
            Me.col_read.HeaderText = "Lectura"
            Me.col_read.Name = "col_read"
            Me.col_read.ReadOnly = True
            Me.col_read.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_read.Width = 70
            '
            'col_write
            '
            Me.col_write.DataPropertyName = "Escritura"
            Me.col_write.Frozen = True
            Me.col_write.HeaderText = "Escritura"
            Me.col_write.Name = "col_write"
            Me.col_write.ReadOnly = True
            Me.col_write.Width = 70
            '
            'col_reporte
            '
            Me.col_reporte.DataPropertyName = "Reporte"
            Me.col_reporte.Frozen = True
            Me.col_reporte.HeaderText = "Reporte"
            Me.col_reporte.Name = "col_reporte"
            Me.col_reporte.ReadOnly = True
            Me.col_reporte.Width = 70
            '
            'col_impresion
            '
            Me.col_impresion.DataPropertyName = "Impresion"
            Me.col_impresion.Frozen = True
            Me.col_impresion.HeaderText = "Impresión"
            Me.col_impresion.Name = "col_impresion"
            Me.col_impresion.ReadOnly = True
            Me.col_impresion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_impresion.Visible = False
            Me.col_impresion.Width = 70
            '
            'col_eliminar
            '
            Me.col_eliminar.DataPropertyName = "Eliminar"
            Me.col_eliminar.Frozen = True
            Me.col_eliminar.HeaderText = "Eliminar"
            Me.col_eliminar.Name = "col_eliminar"
            Me.col_eliminar.ReadOnly = True
            Me.col_eliminar.Width = 70
            '
            'col_codigo
            '
            Me.col_codigo.Frozen = True
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.GroupBox6)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New System.Drawing.Size(825, 360)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Acceso a Penales"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.chkTodos)
            Me.GroupBox6.Controls.Add(Me.DgwPenal)
            Me.GroupBox6.Controls.Add(Me.Panel5)
            Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(825, 360)
            Me.GroupBox6.TabIndex = 55
            Me.GroupBox6.TabStop = False
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Location = New System.Drawing.Point(13, 65)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(15, 14)
            Me.chkTodos.TabIndex = 49
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'DgwPenal
            '
            Me.DgwPenal.AllowUserToAddRows = False
            Me.DgwPenal.AllowUserToDeleteRows = False
            Me.DgwPenal.AllowUserToOrderColumns = True
            Me.DgwPenal.BackgroundColor = System.Drawing.Color.White
            Me.DgwPenal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DgwPenal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_chk, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.DataGridViewTextBoxColumn1})
            Me.DgwPenal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DgwPenal.Location = New System.Drawing.Point(3, 61)
            Me.DgwPenal.MultiSelect = False
            Me.DgwPenal.Name = "DgwPenal"
            Me.DgwPenal.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.DgwPenal.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.DgwPenal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DgwPenal.Size = New System.Drawing.Size(819, 296)
            Me.DgwPenal.TabIndex = 4
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "CodigoID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Width = 30
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
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
            Me.col_reg_nom.Width = 200
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "Codigo"
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "PenalNombre"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Penal"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.BtnEliminar)
            Me.Panel5.Controls.Add(Me.BtnAddPenal)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(3, 16)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(819, 45)
            Me.Panel5.TabIndex = 5
            '
            'BtnEliminar
            '
            Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.BtnEliminar.Location = New System.Drawing.Point(634, 1)
            Me.BtnEliminar.Name = "BtnEliminar"
            Me.BtnEliminar.Size = New System.Drawing.Size(96, 40)
            Me.BtnEliminar.TabIndex = 49
            Me.BtnEliminar.Text = "&Eliminar"
            Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.BtnEliminar.UseVisualStyleBackColor = True
            '
            'BtnAddPenal
            '
            Me.BtnAddPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAddPenal.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.BtnAddPenal.Location = New System.Drawing.Point(533, 1)
            Me.BtnAddPenal.Name = "BtnAddPenal"
            Me.BtnAddPenal.Size = New System.Drawing.Size(94, 40)
            Me.BtnAddPenal.TabIndex = 88
            Me.BtnAddPenal.Text = "&Penal"
            Me.BtnAddPenal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmUsuarioPopupBasico
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(833, 546)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.grbUsuario)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmUsuarioPopupBasico"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Mantenimiento de Usuarios"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.grbUsuario.ResumeLayout(False)
            Me.grbUsuario.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.DgwPC, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.pnlTrabajador.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.pnlPrincipal.ResumeLayout(False)
            CType(Me.DgwPermisos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            CType(Me.DgwPenal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
        Friend WithEvents BtnOk As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents grbUsuario As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtNom As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtApePaterno As System.Windows.Forms.TextBox
        Friend WithEvents txtCargo As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents DgwPC As System.Windows.Forms.DataGridView
        Friend WithEvents pnlTrabajador As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnAddPc As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents col_ite As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_usu_pc_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pc_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hos_nam As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mac As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents chkValPC As System.Windows.Forms.CheckBox
        Friend WithEvents chkLogin As System.Windows.Forms.CheckBox
        Friend WithEvents txtTrabajador As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtCueUsuario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents chkModuloUsuarios As System.Windows.Forms.CheckBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Protected WithEvents cbbDependencia As Legolas.APPUIComponents.MyComboBox
        Protected WithEvents cbbNivelUsuario As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents BtnActivarUsuario As System.Windows.Forms.Button
        Friend WithEvents Label2 As Label
        Friend WithEvents txtCorreo As TextBox
        Friend WithEvents txtApellidosnombres As TextBox
        Friend WithEvents Label10 As Label
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents GroupBox6 As GroupBox
        Friend WithEvents chkTodos As CheckBox
        Friend WithEvents DgwPenal As DataGridView
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_chk As DataGridViewCheckBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents Panel5 As Panel
        Friend WithEvents BtnEliminar As Button
        Friend WithEvents BtnAddPenal As Button
        Friend WithEvents pnlPrincipal As Panel
        Friend WithEvents DgwPermisos As DataGridView
        Friend WithEvents col_display As DataGridViewTextBoxColumn
        Friend WithEvents col_display2 As DataGridViewTextBoxColumn
        Friend WithEvents col_modulos As DataGridViewTextBoxColumn
        Friend WithEvents col_modulo_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_codigo_padre As DataGridViewTextBoxColumn
        Friend WithEvents col_read As DataGridViewCheckBoxColumn
        Friend WithEvents col_write As DataGridViewCheckBoxColumn
        Friend WithEvents col_reporte As DataGridViewCheckBoxColumn
        Friend WithEvents col_impresion As DataGridViewCheckBoxColumn
        Friend WithEvents col_eliminar As DataGridViewCheckBoxColumn
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents chkValidarPorHuella As CheckBox
    End Class
End Namespace

