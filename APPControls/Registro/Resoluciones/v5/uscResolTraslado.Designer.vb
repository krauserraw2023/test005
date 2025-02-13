Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscResolTraslado
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
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.cbbMotivoTraslado = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechMov = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.lblNumeroDocumento = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblObs = New System.Windows.Forms.Label()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.pnlTipoAutoridad = New System.Windows.Forms.Panel()
            Me.txtNroDocumento2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblNumeroDocumento2 = New System.Windows.Forms.Label()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblRegion = New System.Windows.Forms.Label()
            Me.rdbPenalOrigen = New Legolas.APPUIComponents.myRadioButton()
            Me.lblPenal = New System.Windows.Forms.Label()
            Me.cbbPenalOrigen = New APPControls.uscComboParametrica()
            Me.cbbRegionOrigen = New APPControls.uscComboParametrica()
            Me.rdbOtroLugarOrigen = New Legolas.APPUIComponents.myRadioButton()
            Me.txtOtroLugarOrigen = New System.Windows.Forms.TextBox()
            Me.pnlOrigenDestino = New System.Windows.Forms.Panel()
            Me.txtObsLib = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblRegionDestino = New System.Windows.Forms.Label()
            Me.rdbPenalDest = New Legolas.APPUIComponents.myRadioButton()
            Me.lblPenalDestino = New System.Windows.Forms.Label()
            Me.cbbPenalDest = New APPControls.uscComboParametrica()
            Me.cbbRegionDest = New APPControls.uscComboParametrica()
            Me.rdbOtroLugarDest = New Legolas.APPUIComponents.myRadioButton()
            Me.txtOtroLugarDest = New System.Windows.Forms.TextBox()
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.cbbMotivoTraslado.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.pnlTipoAutoridad.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlOrigenDestino.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.grbAutoridad.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.txtFolio)
            Me.Panel2.Controls.Add(Me.dtpFechMov)
            Me.Panel2.Controls.Add(Me.txtLibro)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.txtNumDocumento)
            Me.Panel2.Controls.Add(Me.Label10)
            Me.Panel2.Controls.Add(Me.lblNumeroDocumento)
            Me.Panel2.Controls.Add(Me.Label13)
            Me.Panel2.Controls.Add(Me.dtpDocJudFecha)
            Me.Panel2.Controls.Add(Me.Label6)
            Me.Panel2.Controls.Add(Me.dtpDocJudFecRecep)
            Me.Panel2.Controls.Add(Me.Label12)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(592, 93)
            Me.Panel2.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.cbbMotivoTraslado)
            Me.Panel1.Location = New System.Drawing.Point(110, 2)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(243, 24)
            Me.Panel1.TabIndex = 1
            '
            'cbbMotivoTraslado
            '
            Me.cbbMotivoTraslado._NoIndica = False
            Me.cbbMotivoTraslado._TipoTexto = Type.Combo.enmTipoTexto.Mayuscula
            Me.cbbMotivoTraslado._Todos = False
            Me.cbbMotivoTraslado._TodosMensaje = ""
            Me.cbbMotivoTraslado._Visible_Add = False
            Me.cbbMotivoTraslado._Visible_Buscar = False
            Me.cbbMotivoTraslado._Visible_Eliminar = False
            Me.cbbMotivoTraslado.CodigoPadre = -1
            Me.cbbMotivoTraslado.ComboTipo = CType(52, Short)
            Me.cbbMotivoTraslado.Controls.Add(Me.ComboBox1)
            Me.cbbMotivoTraslado.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMotivoTraslado.DropDownWidth = 325
            Me.cbbMotivoTraslado.DropDownWidthAuto = True
            Me.cbbMotivoTraslado.ListaIdsParaExcluir = Nothing
            Me.cbbMotivoTraslado.Location = New System.Drawing.Point(0, 2)
            Me.cbbMotivoTraslado.ModuloTratamiento = False
            Me.cbbMotivoTraslado.Name = "cbbMotivoTraslado"
            Me.cbbMotivoTraslado.Parametro1 = -1
            Me.cbbMotivoTraslado.Parametro2 = -1
            Me.cbbMotivoTraslado.SelectedIndex = -1
            Me.cbbMotivoTraslado.SelectedValue = 0
            Me.cbbMotivoTraslado.Size = New System.Drawing.Size(243, 22)
            Me.cbbMotivoTraslado.TabIndex = 129
            Me.cbbMotivoTraslado.verToolTipItemSeleccionado = False
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 325
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(243, 21)
            Me.ComboBox1.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(4, 75)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(67, 13)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "Fecha Mov.:"
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtFolio.Location = New System.Drawing.Point(448, 70)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(82, 20)
            Me.txtFolio.TabIndex = 13
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'dtpFechMov
            '
            Me.dtpFechMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechMov.Location = New System.Drawing.Point(109, 72)
            Me.dtpFechMov.Name = "dtpFechMov"
            Me.dtpFechMov.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechMov.TabIndex = 9
            Me.dtpFechMov.Value = "/  /"
            Me.dtpFechMov.ValueLong = CType(0, Long)
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtLibro.Location = New System.Drawing.Point(448, 49)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(82, 20)
            Me.txtLibro.TabIndex = 11
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(4, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(42, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Motivo:"
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(109, 27)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(243, 20)
            Me.txtNumDocumento.TabIndex = 3
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label10
            '
            Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(363, 77)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(32, 13)
            Me.Label10.TabIndex = 12
            Me.Label10.Text = "Folio:"
            '
            'lblNumeroDocumento
            '
            Me.lblNumeroDocumento.AutoSize = True
            Me.lblNumeroDocumento.Location = New System.Drawing.Point(5, 30)
            Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
            Me.lblNumeroDocumento.Size = New System.Drawing.Size(55, 13)
            Me.lblNumeroDocumento.TabIndex = 2
            Me.lblNumeroDocumento.Text = "N° Oficio :"
            '
            'Label13
            '
            Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(363, 54)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(33, 13)
            Me.Label13.TabIndex = 10
            Me.Label13.Text = "Libro:"
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(109, 49)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 5
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(4, 53)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 13)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "Fec. Doc. :"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(269, 49)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 7
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(195, 54)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 13)
            Me.Label12.TabIndex = 6
            Me.Label12.Text = "Fec. Recep. :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(4, 6)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(94, 13)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Tipo de Autoridad:"
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(109, 3)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(470, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(433, 25)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(146, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(109, 25)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(241, 20)
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
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(10, 29)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(86, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Cargo Autoridad:"
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(109, 26)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(470, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(10, 7)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Nombre Autoridad:"
            '
            'lblObs
            '
            Me.lblObs.AutoSize = True
            Me.lblObs.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblObs.Location = New System.Drawing.Point(0, 110)
            Me.lblObs.Name = "lblObs"
            Me.lblObs.Size = New System.Drawing.Size(108, 13)
            Me.lblObs.TabIndex = 0
            Me.lblObs.Text = "        Observaciones :"
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label3)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label4)
            Me.PnlOtraAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(3, 89)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(586, 51)
            Me.PnlOtraAutoridad.TabIndex = 0
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label5)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 40)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(586, 49)
            Me.PnlAutoridadJudicial.TabIndex = 1
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(109, 3)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(241, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 22
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
            Me.UscComboSala1.Location = New System.Drawing.Point(433, 2)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(145, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(4, 28)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 13)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Magistrado :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(356, 7)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(356, 28)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'pnlTipoAutoridad
            '
            Me.pnlTipoAutoridad.Controls.Add(Me.txtNroDocumento2)
            Me.pnlTipoAutoridad.Controls.Add(Me.lblNumeroDocumento2)
            Me.pnlTipoAutoridad.Controls.Add(Me.cbbTipoAutJud)
            Me.pnlTipoAutoridad.Controls.Add(Me.Label7)
            Me.pnlTipoAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTipoAutoridad.Location = New System.Drawing.Point(3, 16)
            Me.pnlTipoAutoridad.Name = "pnlTipoAutoridad"
            Me.pnlTipoAutoridad.Size = New System.Drawing.Size(586, 24)
            Me.pnlTipoAutoridad.TabIndex = 0
            '
            'txtNroDocumento2
            '
            Me.txtNroDocumento2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNroDocumento2._BloquearPaste = False
            Me.txtNroDocumento2._SeleccionarTodo = False
            Me.txtNroDocumento2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNroDocumento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroDocumento2.Location = New System.Drawing.Point(433, 3)
            Me.txtNroDocumento2.MaxLength = 120
            Me.txtNroDocumento2.Name = "txtNroDocumento2"
            Me.txtNroDocumento2.Size = New System.Drawing.Size(147, 20)
            Me.txtNroDocumento2.TabIndex = 3
            Me.txtNroDocumento2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNroDocumento2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblNumeroDocumento2
            '
            Me.lblNumeroDocumento2.AutoSize = True
            Me.lblNumeroDocumento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroDocumento2.Location = New System.Drawing.Point(357, 6)
            Me.lblNumeroDocumento2.Name = "lblNumeroDocumento2"
            Me.lblNumeroDocumento2.Size = New System.Drawing.Size(44, 13)
            Me.lblNumeroDocumento2.TabIndex = 2
            Me.lblNumeroDocumento2.Text = "N° RD :"
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
            Me.cbbTipoAutJud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTipoAutJud.ListaIdsParaExcluir = Nothing
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(109, 2)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(240, 22)
            Me.cbbTipoAutJud.TabIndex = 1
            Me.cbbTipoAutJud.verToolTipItemSeleccionado = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblRegion)
            Me.GroupBox1.Controls.Add(Me.rdbPenalOrigen)
            Me.GroupBox1.Controls.Add(Me.lblPenal)
            Me.GroupBox1.Controls.Add(Me.cbbPenalOrigen)
            Me.GroupBox1.Controls.Add(Me.cbbRegionOrigen)
            Me.GroupBox1.Controls.Add(Me.rdbOtroLugarOrigen)
            Me.GroupBox1.Controls.Add(Me.txtOtroLugarOrigen)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(592, 52)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Origen"
            '
            'lblRegion
            '
            Me.lblRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegion.Location = New System.Drawing.Point(10, 30)
            Me.lblRegion.Name = "lblRegion"
            Me.lblRegion.Size = New System.Drawing.Size(93, 16)
            Me.lblRegion.TabIndex = 3
            Me.lblRegion.Text = "Región:"
            Me.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'rdbPenalOrigen
            '
            Me.rdbPenalOrigen.AutoSize = True
            Me.rdbPenalOrigen.Checked = True
            Me.rdbPenalOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPenalOrigen.Location = New System.Drawing.Point(110, 7)
            Me.rdbPenalOrigen.Name = "rdbPenalOrigen"
            Me.rdbPenalOrigen.Size = New System.Drawing.Size(52, 17)
            Me.rdbPenalOrigen.TabIndex = 1
            Me.rdbPenalOrigen.TabStop = True
            Me.rdbPenalOrigen.Text = "Penal"
            Me.rdbPenalOrigen.UseVisualStyleBackColor = True
            '
            'lblPenal
            '
            Me.lblPenal.AutoSize = True
            Me.lblPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPenal.Location = New System.Drawing.Point(363, 31)
            Me.lblPenal.Name = "lblPenal"
            Me.lblPenal.Size = New System.Drawing.Size(37, 13)
            Me.lblPenal.TabIndex = 5
            Me.lblPenal.Text = "Penal:"
            '
            'cbbPenalOrigen
            '
            Me.cbbPenalOrigen._NoIndica = False
            Me.cbbPenalOrigen._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenalOrigen._Todos = False
            Me.cbbPenalOrigen._TodosMensaje = ""
            Me.cbbPenalOrigen._Visible_Add = False
            Me.cbbPenalOrigen._Visible_Buscar = False
            Me.cbbPenalOrigen._Visible_Eliminar = False
            Me.cbbPenalOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbPenalOrigen.CodigoPadre = -1
            Me.cbbPenalOrigen.ComboTipo = CType(23, Short)
            Me.cbbPenalOrigen.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenalOrigen.DropDownWidth = 325
            Me.cbbPenalOrigen.DropDownWidthAuto = True
            Me.cbbPenalOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPenalOrigen.ListaIdsParaExcluir = Nothing
            Me.cbbPenalOrigen.Location = New System.Drawing.Point(436, 27)
            Me.cbbPenalOrigen.ModuloTratamiento = False
            Me.cbbPenalOrigen.Name = "cbbPenalOrigen"
            Me.cbbPenalOrigen.Parametro1 = -1
            Me.cbbPenalOrigen.Parametro2 = -1
            Me.cbbPenalOrigen.SelectedIndex = -1
            Me.cbbPenalOrigen.SelectedValue = 0
            Me.cbbPenalOrigen.Size = New System.Drawing.Size(150, 22)
            Me.cbbPenalOrigen.TabIndex = 6
            Me.cbbPenalOrigen.verToolTipItemSeleccionado = False
            '
            'cbbRegionOrigen
            '
            Me.cbbRegionOrigen._NoIndica = False
            Me.cbbRegionOrigen._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionOrigen._Todos = False
            Me.cbbRegionOrigen._TodosMensaje = ""
            Me.cbbRegionOrigen._Visible_Add = False
            Me.cbbRegionOrigen._Visible_Buscar = False
            Me.cbbRegionOrigen._Visible_Eliminar = False
            Me.cbbRegionOrigen.CodigoPadre = -1
            Me.cbbRegionOrigen.ComboTipo = CType(24, Short)
            Me.cbbRegionOrigen.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionOrigen.DropDownWidth = 325
            Me.cbbRegionOrigen.DropDownWidthAuto = False
            Me.cbbRegionOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegionOrigen.ListaIdsParaExcluir = Nothing
            Me.cbbRegionOrigen.Location = New System.Drawing.Point(109, 28)
            Me.cbbRegionOrigen.ModuloTratamiento = False
            Me.cbbRegionOrigen.Name = "cbbRegionOrigen"
            Me.cbbRegionOrigen.Parametro1 = -1
            Me.cbbRegionOrigen.Parametro2 = -1
            Me.cbbRegionOrigen.SelectedIndex = -1
            Me.cbbRegionOrigen.SelectedValue = 0
            Me.cbbRegionOrigen.Size = New System.Drawing.Size(243, 22)
            Me.cbbRegionOrigen.TabIndex = 4
            Me.cbbRegionOrigen.verToolTipItemSeleccionado = False
            '
            'rdbOtroLugarOrigen
            '
            Me.rdbOtroLugarOrigen.AutoSize = True
            Me.rdbOtroLugarOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbOtroLugarOrigen.Location = New System.Drawing.Point(181, 7)
            Me.rdbOtroLugarOrigen.Name = "rdbOtroLugarOrigen"
            Me.rdbOtroLugarOrigen.Size = New System.Drawing.Size(75, 17)
            Me.rdbOtroLugarOrigen.TabIndex = 2
            Me.rdbOtroLugarOrigen.Text = "Otro Lugar"
            Me.rdbOtroLugarOrigen.UseVisualStyleBackColor = True
            '
            'txtOtroLugarOrigen
            '
            Me.txtOtroLugarOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtroLugarOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtOtroLugarOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtroLugarOrigen.Location = New System.Drawing.Point(110, 28)
            Me.txtOtroLugarOrigen.MaxLength = 120
            Me.txtOtroLugarOrigen.Name = "txtOtroLugarOrigen"
            Me.txtOtroLugarOrigen.Size = New System.Drawing.Size(474, 20)
            Me.txtOtroLugarOrigen.TabIndex = 5
            Me.txtOtroLugarOrigen.Visible = False
            '
            'pnlOrigenDestino
            '
            Me.pnlOrigenDestino.Controls.Add(Me.txtObsLib)
            Me.pnlOrigenDestino.Controls.Add(Me.lblObs)
            Me.pnlOrigenDestino.Controls.Add(Me.GroupBox2)
            Me.pnlOrigenDestino.Controls.Add(Me.GroupBox1)
            Me.pnlOrigenDestino.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlOrigenDestino.Location = New System.Drawing.Point(0, 182)
            Me.pnlOrigenDestino.Name = "pnlOrigenDestino"
            Me.pnlOrigenDestino.Size = New System.Drawing.Size(592, 180)
            Me.pnlOrigenDestino.TabIndex = 2
            '
            'txtObsLib
            '
            Me.txtObsLib._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObsLib._BloquearPaste = False
            Me.txtObsLib._SeleccionarTodo = False
            Me.txtObsLib.BackColor = System.Drawing.SystemColors.Window
            Me.txtObsLib.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsLib.Location = New System.Drawing.Point(108, 110)
            Me.txtObsLib.MaxLength = 2500
            Me.txtObsLib.Multiline = True
            Me.txtObsLib.Name = "txtObsLib"
            Me.txtObsLib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsLib.Size = New System.Drawing.Size(484, 70)
            Me.txtObsLib.TabIndex = 2
            Me.txtObsLib.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObsLib.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblRegionDestino)
            Me.GroupBox2.Controls.Add(Me.rdbPenalDest)
            Me.GroupBox2.Controls.Add(Me.lblPenalDestino)
            Me.GroupBox2.Controls.Add(Me.cbbPenalDest)
            Me.GroupBox2.Controls.Add(Me.cbbRegionDest)
            Me.GroupBox2.Controls.Add(Me.rdbOtroLugarDest)
            Me.GroupBox2.Controls.Add(Me.txtOtroLugarDest)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(0, 52)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(592, 58)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Destino"
            '
            'lblRegionDestino
            '
            Me.lblRegionDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegionDestino.Location = New System.Drawing.Point(14, 34)
            Me.lblRegionDestino.Name = "lblRegionDestino"
            Me.lblRegionDestino.Size = New System.Drawing.Size(93, 13)
            Me.lblRegionDestino.TabIndex = 2
            Me.lblRegionDestino.Text = "Región:"
            Me.lblRegionDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'rdbPenalDest
            '
            Me.rdbPenalDest.AutoSize = True
            Me.rdbPenalDest.Checked = True
            Me.rdbPenalDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPenalDest.Location = New System.Drawing.Point(111, 10)
            Me.rdbPenalDest.Name = "rdbPenalDest"
            Me.rdbPenalDest.Size = New System.Drawing.Size(52, 17)
            Me.rdbPenalDest.TabIndex = 0
            Me.rdbPenalDest.TabStop = True
            Me.rdbPenalDest.Text = "Penal"
            Me.rdbPenalDest.UseVisualStyleBackColor = True
            '
            'lblPenalDestino
            '
            Me.lblPenalDestino.AutoSize = True
            Me.lblPenalDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPenalDestino.Location = New System.Drawing.Point(363, 34)
            Me.lblPenalDestino.Name = "lblPenalDestino"
            Me.lblPenalDestino.Size = New System.Drawing.Size(37, 13)
            Me.lblPenalDestino.TabIndex = 4
            Me.lblPenalDestino.Text = "Penal:"
            '
            'cbbPenalDest
            '
            Me.cbbPenalDest._NoIndica = False
            Me.cbbPenalDest._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenalDest._Todos = False
            Me.cbbPenalDest._TodosMensaje = ""
            Me.cbbPenalDest._Visible_Add = False
            Me.cbbPenalDest._Visible_Buscar = False
            Me.cbbPenalDest._Visible_Eliminar = False
            Me.cbbPenalDest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbPenalDest.CodigoPadre = -1
            Me.cbbPenalDest.ComboTipo = CType(23, Short)
            Me.cbbPenalDest.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenalDest.DropDownWidth = 325
            Me.cbbPenalDest.DropDownWidthAuto = True
            Me.cbbPenalDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPenalDest.ListaIdsParaExcluir = Nothing
            Me.cbbPenalDest.Location = New System.Drawing.Point(436, 30)
            Me.cbbPenalDest.ModuloTratamiento = False
            Me.cbbPenalDest.Name = "cbbPenalDest"
            Me.cbbPenalDest.Parametro1 = -1
            Me.cbbPenalDest.Parametro2 = -1
            Me.cbbPenalDest.SelectedIndex = -1
            Me.cbbPenalDest.SelectedValue = 0
            Me.cbbPenalDest.Size = New System.Drawing.Size(150, 22)
            Me.cbbPenalDest.TabIndex = 5
            Me.cbbPenalDest.verToolTipItemSeleccionado = False
            '
            'cbbRegionDest
            '
            Me.cbbRegionDest._NoIndica = False
            Me.cbbRegionDest._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionDest._Todos = False
            Me.cbbRegionDest._TodosMensaje = ""
            Me.cbbRegionDest._Visible_Add = False
            Me.cbbRegionDest._Visible_Buscar = False
            Me.cbbRegionDest._Visible_Eliminar = False
            Me.cbbRegionDest.CodigoPadre = -1
            Me.cbbRegionDest.ComboTipo = CType(24, Short)
            Me.cbbRegionDest.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionDest.DropDownWidth = 325
            Me.cbbRegionDest.DropDownWidthAuto = False
            Me.cbbRegionDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegionDest.ListaIdsParaExcluir = Nothing
            Me.cbbRegionDest.Location = New System.Drawing.Point(109, 31)
            Me.cbbRegionDest.ModuloTratamiento = False
            Me.cbbRegionDest.Name = "cbbRegionDest"
            Me.cbbRegionDest.Parametro1 = -1
            Me.cbbRegionDest.Parametro2 = -1
            Me.cbbRegionDest.SelectedIndex = -1
            Me.cbbRegionDest.SelectedValue = 0
            Me.cbbRegionDest.Size = New System.Drawing.Size(241, 22)
            Me.cbbRegionDest.TabIndex = 3
            Me.cbbRegionDest.verToolTipItemSeleccionado = False
            '
            'rdbOtroLugarDest
            '
            Me.rdbOtroLugarDest.AutoSize = True
            Me.rdbOtroLugarDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbOtroLugarDest.Location = New System.Drawing.Point(182, 10)
            Me.rdbOtroLugarDest.Name = "rdbOtroLugarDest"
            Me.rdbOtroLugarDest.Size = New System.Drawing.Size(75, 17)
            Me.rdbOtroLugarDest.TabIndex = 1
            Me.rdbOtroLugarDest.Text = "Otro Lugar"
            Me.rdbOtroLugarDest.UseVisualStyleBackColor = True
            '
            'txtOtroLugarDest
            '
            Me.txtOtroLugarDest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtroLugarDest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtOtroLugarDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtroLugarDest.Location = New System.Drawing.Point(112, 31)
            Me.txtOtroLugarDest.MaxLength = 120
            Me.txtOtroLugarDest.Name = "txtOtroLugarDest"
            Me.txtOtroLugarDest.Size = New System.Drawing.Size(474, 20)
            Me.txtOtroLugarDest.TabIndex = 5
            Me.txtOtroLugarDest.Visible = False
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.PnlOtraAutoridad)
            Me.grbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.grbAutoridad.Controls.Add(Me.pnlTipoAutoridad)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(0, 93)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(592, 89)
            Me.grbAutoridad.TabIndex = 1
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Autoridad"
            '
            'uscResolTraslado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlOrigenDestino)
            Me.Controls.Add(Me.grbAutoridad)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "uscResolTraslado"
            Me.Size = New System.Drawing.Size(592, 362)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.cbbMotivoTraslado.ResumeLayout(False)
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.pnlTipoAutoridad.ResumeLayout(False)
            Me.pnlTipoAutoridad.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.pnlOrigenDestino.ResumeLayout(False)
            Me.pnlOrigenDestino.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.grbAutoridad.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpFechMov As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblObs As System.Windows.Forms.Label
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblRegion As System.Windows.Forms.Label
        Friend WithEvents rdbPenalOrigen As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents lblPenal As System.Windows.Forms.Label
        Friend WithEvents cbbPenalOrigen As APPControls.uscComboParametrica
        Friend WithEvents cbbRegionOrigen As APPControls.uscComboParametrica
        Friend WithEvents rdbOtroLugarOrigen As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents txtOtroLugarOrigen As System.Windows.Forms.TextBox
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents cbbMotivoTraslado As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents pnlOrigenDestino As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlTipoAutoridad As System.Windows.Forms.Panel
        Friend WithEvents grbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents txtNroDocumento2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblNumeroDocumento2 As System.Windows.Forms.Label
        Friend WithEvents txtObsLib As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents lblRegionDestino As System.Windows.Forms.Label
        Friend WithEvents rdbPenalDest As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents lblPenalDestino As System.Windows.Forms.Label
        Friend WithEvents cbbPenalDest As APPControls.uscComboParametrica
        Friend WithEvents cbbRegionDest As APPControls.uscComboParametrica
        Friend WithEvents rdbOtroLugarDest As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents txtOtroLugarDest As System.Windows.Forms.TextBox
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
    End Class
End Namespace
