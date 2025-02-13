Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscResolDetencion
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
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.PnlTipoAutoridad = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbSitJuridica = New APPControls.uscComboParametrica()
            Me.lblFolio = New System.Windows.Forms.Label()
            Me.lblLibro = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.ckbFlagrancia = New System.Windows.Forms.CheckBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtObsLib = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblObs = New System.Windows.Forms.Label()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.grbAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.PnlTipoAutoridad.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.grbAutoridad.Controls.Add(Me.PnlOtraAutoridad)
            Me.grbAutoridad.Controls.Add(Me.PnlTipoAutoridad)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(0, 56)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(710, 93)
            Me.grbAutoridad.TabIndex = 1
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Autoridad"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label8)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 40)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(704, 50)
            Me.PnlAutoridadJudicial.TabIndex = 1
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1._Todos = False
            Me.UscComboSala1._TodosMensaje = ""
            Me.UscComboSala1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscComboSala1.Location = New System.Drawing.Point(453, 4)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(247, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(453, 27)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(248, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(107, 27)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(256, 20)
            Me.txtJuez.TabIndex = 5
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(4, 7)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(4, 34)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(65, 13)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Magistrado :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(368, 7)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(368, 28)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label4)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label5)
            Me.PnlOtraAutoridad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(3, 40)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(704, 50)
            Me.PnlOtraAutoridad.TabIndex = 2
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(107, 4)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(593, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(4, 29)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(89, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Cargo Autoridad :"
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(107, 28)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(593, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(4, 7)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(98, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Nombre Autoridad :"
            '
            'PnlTipoAutoridad
            '
            Me.PnlTipoAutoridad.Controls.Add(Me.Label2)
            Me.PnlTipoAutoridad.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlTipoAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlTipoAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlTipoAutoridad.Location = New System.Drawing.Point(3, 16)
            Me.PnlTipoAutoridad.Name = "PnlTipoAutoridad"
            Me.PnlTipoAutoridad.Size = New System.Drawing.Size(704, 24)
            Me.PnlTipoAutoridad.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(4, 4)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(79, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Tipo Autoridad:"
            '
            'cbbTipoAutJud
            '
            Me.cbbTipoAutJud._NoIndica = False
            Me.cbbTipoAutJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoAutJud._Todos = False
            Me.cbbTipoAutJud._TodosMensaje = ""
            Me.cbbTipoAutJud._Visible_Add = False
            Me.cbbTipoAutJud._Visible_Buscar = False
            Me.cbbTipoAutJud._Visible_Eliminar = False
            Me.cbbTipoAutJud.CodigoPadre = -1
            Me.cbbTipoAutJud.ComboTipo = CType(63, Short)
            Me.cbbTipoAutJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoAutJud.DropDownWidth = 325
            Me.cbbTipoAutJud.DropDownWidthAuto = False
            Me.cbbTipoAutJud.ListaIdsParaExcluir = Nothing
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(107, 1)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(256, 22)
            Me.cbbTipoAutJud.TabIndex = 1
            Me.cbbTipoAutJud.verToolTipItemSeleccionado = False
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.txtFolio)
            Me.grbCabecera.Controls.Add(Me.txtLibro)
            Me.grbCabecera.Controls.Add(Me.cbbSitJuridica)
            Me.grbCabecera.Controls.Add(Me.lblFolio)
            Me.grbCabecera.Controls.Add(Me.lblLibro)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecRecep)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecha)
            Me.grbCabecera.Controls.Add(Me.Label6)
            Me.grbCabecera.Controls.Add(Me.txtNumDocumento)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Controls.Add(Me.Label1)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbCabecera.Location = New System.Drawing.Point(0, 0)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(710, 56)
            Me.grbCabecera.TabIndex = 0
            Me.grbCabecera.TabStop = False
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Location = New System.Drawing.Point(575, 10)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(73, 20)
            Me.txtFolio.TabIndex = 9
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Location = New System.Drawing.Point(456, 10)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(73, 20)
            Me.txtLibro.TabIndex = 7
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'cbbSitJuridica
            '
            Me.cbbSitJuridica._NoIndica = False
            Me.cbbSitJuridica._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbSitJuridica._Todos = False
            Me.cbbSitJuridica._TodosMensaje = ""
            Me.cbbSitJuridica._Visible_Add = False
            Me.cbbSitJuridica._Visible_Buscar = False
            Me.cbbSitJuridica._Visible_Eliminar = False
            Me.cbbSitJuridica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbSitJuridica.CodigoPadre = -1
            Me.cbbSitJuridica.ComboTipo = CType(17, Short)
            Me.cbbSitJuridica.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSitJuridica.DropDownWidth = 325
            Me.cbbSitJuridica.DropDownWidthAuto = False
            Me.cbbSitJuridica.ListaIdsParaExcluir = Nothing
            Me.cbbSitJuridica.Location = New System.Drawing.Point(456, 32)
            Me.cbbSitJuridica.ModuloTratamiento = False
            Me.cbbSitJuridica.Name = "cbbSitJuridica"
            Me.cbbSitJuridica.Parametro1 = -1
            Me.cbbSitJuridica.Parametro2 = -1
            Me.cbbSitJuridica.SelectedIndex = -1
            Me.cbbSitJuridica.SelectedValue = 0
            Me.cbbSitJuridica.Size = New System.Drawing.Size(249, 22)
            Me.cbbSitJuridica.TabIndex = 11
            Me.cbbSitJuridica.verToolTipItemSeleccionado = False
            '
            'lblFolio
            '
            Me.lblFolio.AutoSize = True
            Me.lblFolio.Location = New System.Drawing.Point(535, 13)
            Me.lblFolio.Name = "lblFolio"
            Me.lblFolio.Size = New System.Drawing.Size(32, 13)
            Me.lblFolio.TabIndex = 8
            Me.lblFolio.Text = "Folio:"
            '
            'lblLibro
            '
            Me.lblLibro.AutoSize = True
            Me.lblLibro.Location = New System.Drawing.Point(368, 15)
            Me.lblLibro.Name = "lblLibro"
            Me.lblLibro.Size = New System.Drawing.Size(33, 13)
            Me.lblLibro.TabIndex = 6
            Me.lblLibro.Text = "Libro:"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(282, 33)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(195, 36)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(89, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recepción :"
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(110, 33)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 37)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(69, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Fecha Doc. :"
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(110, 10)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(256, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(6, 14)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(81, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Expediente :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(368, 36)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 13)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Sit. Jurídica:"
            '
            'pnlObs
            '
            Me.pnlObs.Controls.Add(Me.ckbFlagrancia)
            Me.pnlObs.Controls.Add(Me.Label3)
            Me.pnlObs.Controls.Add(Me.txtObsLib)
            Me.pnlObs.Controls.Add(Me.lblObs)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObs.Location = New System.Drawing.Point(0, 149)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(710, 55)
            Me.pnlObs.TabIndex = 2
            Me.pnlObs.Tag = "2"
            '
            'ckbFlagrancia
            '
            Me.ckbFlagrancia.AutoSize = True
            Me.ckbFlagrancia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbFlagrancia.Dock = System.Windows.Forms.DockStyle.Left
            Me.ckbFlagrancia.Location = New System.Drawing.Point(456, 0)
            Me.ckbFlagrancia.Name = "ckbFlagrancia"
            Me.ckbFlagrancia.Size = New System.Drawing.Size(15, 55)
            Me.ckbFlagrancia.TabIndex = 3
            Me.ckbFlagrancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbFlagrancia.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label3.Location = New System.Drawing.Point(365, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(91, 55)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "  Flagrancia :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtObsLib
            '
            Me.txtObsLib._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObsLib._BloquearPaste = False
            Me.txtObsLib._SeleccionarTodo = False
            Me.txtObsLib.BackColor = System.Drawing.SystemColors.Window
            Me.txtObsLib.Dock = System.Windows.Forms.DockStyle.Left
            Me.txtObsLib.Location = New System.Drawing.Point(109, 0)
            Me.txtObsLib.MaxLength = 2500
            Me.txtObsLib.Multiline = True
            Me.txtObsLib.Name = "txtObsLib"
            Me.txtObsLib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsLib.Size = New System.Drawing.Size(256, 55)
            Me.txtObsLib.TabIndex = 1
            Me.txtObsLib.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObsLib.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblObs
            '
            Me.lblObs.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblObs.Location = New System.Drawing.Point(0, 0)
            Me.lblObs.Name = "lblObs"
            Me.lblObs.Size = New System.Drawing.Size(109, 55)
            Me.lblObs.TabIndex = 0
            Me.lblObs.Text = "  Observación :"
            Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(106, 2)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(257, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 23
            '
            'uscResolDetencion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlObs)
            Me.Controls.Add(Me.grbAutoridad)
            Me.Controls.Add(Me.grbCabecera)
            Me.Name = "uscResolDetencion"
            Me.Size = New System.Drawing.Size(710, 204)
            Me.grbAutoridad.ResumeLayout(False)
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.PnlTipoAutoridad.ResumeLayout(False)
            Me.PnlTipoAutoridad.PerformLayout()
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents PnlTipoAutoridad As System.Windows.Forms.Panel
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblFolio As System.Windows.Forms.Label
        Friend WithEvents lblLibro As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents cbbSitJuridica As APPControls.uscComboParametrica
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents pnlObs As Panel
        Friend WithEvents ckbFlagrancia As CheckBox
        Friend WithEvents Label3 As Label
        Friend WithEvents txtObsLib As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblObs As Label
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
    End Class
End Namespace