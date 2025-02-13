Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscNotas
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
            Me.cbbTipoNota = New APPControls.uscComboParametrica()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.txtObsLib = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblObs = New System.Windows.Forms.Label()
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.PnlAutJudPrin = New System.Windows.Forms.Panel()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.Panel2.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.grbAutoridad.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.PnlAutJudPrin.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.cbbTipoNota)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(654, 24)
            Me.Panel2.TabIndex = 0
            '
            'cbbTipoNota
            '
            Me.cbbTipoNota._NoIndica = False
            Me.cbbTipoNota._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoNota._Todos = False
            Me.cbbTipoNota._TodosMensaje = ""
            Me.cbbTipoNota._Visible_Add = False
            Me.cbbTipoNota._Visible_Buscar = False
            Me.cbbTipoNota._Visible_Eliminar = False
            Me.cbbTipoNota.CodigoPadre = -1
            Me.cbbTipoNota.ComboTipo = CType(64, Short)
            Me.cbbTipoNota.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoNota.DropDownWidth = 325
            Me.cbbTipoNota.DropDownWidthAuto = True
            Me.cbbTipoNota.ListaIdsParaExcluir = Nothing
            Me.cbbTipoNota.Location = New System.Drawing.Point(110, 3)
            Me.cbbTipoNota.ModuloTratamiento = False
            Me.cbbTipoNota.Name = "cbbTipoNota"
            Me.cbbTipoNota.Parametro1 = -1
            Me.cbbTipoNota.Parametro2 = -1
            Me.cbbTipoNota.SelectedIndex = -1
            Me.cbbTipoNota.SelectedValue = 0
            Me.cbbTipoNota.Size = New System.Drawing.Size(233, 22)
            Me.cbbTipoNota.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(17, 6)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(31, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Tipo:"
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.txtFolio)
            Me.grbCabecera.Controls.Add(Me.txtLibro)
            Me.grbCabecera.Controls.Add(Me.Label8)
            Me.grbCabecera.Controls.Add(Me.Label7)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecRecep)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecha)
            Me.grbCabecera.Controls.Add(Me.Label10)
            Me.grbCabecera.Controls.Add(Me.txtNumDocumento)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbCabecera.Location = New System.Drawing.Point(0, 24)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(654, 59)
            Me.grbCabecera.TabIndex = 1
            Me.grbCabecera.TabStop = False
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtFolio.Location = New System.Drawing.Point(419, 34)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(66, 20)
            Me.txtFolio.TabIndex = 9
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtLibro.Location = New System.Drawing.Point(419, 10)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(66, 20)
            Me.txtLibro.TabIndex = 7
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label8
            '
            Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(352, 33)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 8
            Me.Label8.Text = "Folio:"
            '
            'Label7
            '
            Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(352, 13)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(33, 13)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Libro:"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(260, 34)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(110, 34)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(17, 37)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(69, 13)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Fecha Doc. :"
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(110, 10)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(233, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(17, 14)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(191, 37)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recep. :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(11, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(97, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Tipo de Autoridad :"
            '
            'pnlObs
            '
            Me.pnlObs.Controls.Add(Me.txtObsLib)
            Me.pnlObs.Controls.Add(Me.lblObs)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObs.Location = New System.Drawing.Point(0, 179)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(654, 56)
            Me.pnlObs.TabIndex = 3
            '
            'txtObsLib
            '
            Me.txtObsLib._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObsLib._BloquearPaste = False
            Me.txtObsLib._SeleccionarTodo = False
            Me.txtObsLib.BackColor = System.Drawing.SystemColors.Window
            Me.txtObsLib.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsLib.Location = New System.Drawing.Point(109, 0)
            Me.txtObsLib.MaxLength = 2500
            Me.txtObsLib.Multiline = True
            Me.txtObsLib.Name = "txtObsLib"
            Me.txtObsLib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsLib.Size = New System.Drawing.Size(545, 56)
            Me.txtObsLib.TabIndex = 1
            Me.txtObsLib.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObsLib.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblObs
            '
            Me.lblObs.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblObs.Location = New System.Drawing.Point(0, 0)
            Me.lblObs.Name = "lblObs"
            Me.lblObs.Size = New System.Drawing.Size(109, 56)
            Me.lblObs.TabIndex = 0
            Me.lblObs.Text = "     Observación:"
            Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.PnlOtraAutoridad)
            Me.grbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.grbAutoridad.Controls.Add(Me.PnlAutJudPrin)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(0, 83)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(654, 96)
            Me.grbAutoridad.TabIndex = 2
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Autoridad"
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label4)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label6)
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(3, 44)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(648, 61)
            Me.PnlOtraAutoridad.TabIndex = 1
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(107, 1)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(538, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(11, 26)
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
            Me.txtOtraAutoridadCargo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(108, 25)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(537, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(11, 4)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(98, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Nombre Autoridad :"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label5)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 44)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(648, 51)
            Me.PnlAutoridadJudicial.TabIndex = 1
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1._Todos = False
            Me.UscComboSala1._TodosMensaje = ""
            Me.UscComboSala1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscComboSala1.Location = New System.Drawing.Point(424, 2)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(221, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(424, 27)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(222, 20)
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
            Me.txtJuez.Size = New System.Drawing.Size(233, 20)
            Me.txtJuez.TabIndex = 5
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(13, 7)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(13, 28)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(35, 13)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Juez :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(347, 7)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(347, 28)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'UscComboDistritoJudicial1
            '            
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(107, 3)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(233, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 8
            '
            'PnlAutJudPrin
            '
            Me.PnlAutJudPrin.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlAutJudPrin.Controls.Add(Me.Label1)
            Me.PnlAutJudPrin.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutJudPrin.Location = New System.Drawing.Point(3, 16)
            Me.PnlAutJudPrin.Name = "PnlAutJudPrin"
            Me.PnlAutJudPrin.Size = New System.Drawing.Size(648, 28)
            Me.PnlAutJudPrin.TabIndex = 0
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
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(107, 3)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(233, 22)
            Me.cbbTipoAutJud.TabIndex = 1
            '
            'uscNotas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlObs)
            Me.Controls.Add(Me.grbAutoridad)
            Me.Controls.Add(Me.grbCabecera)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "uscNotas"
            Me.Size = New System.Drawing.Size(654, 235)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.grbAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.PnlAutJudPrin.ResumeLayout(False)
            Me.PnlAutJudPrin.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents cbbTipoNota As APPControls.uscComboParametrica
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents pnlObs As System.Windows.Forms.Panel
        Friend WithEvents txtObsLib As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblObs As System.Windows.Forms.Label
        Friend WithEvents grbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents PnlAutJudPrin As System.Windows.Forms.Panel
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
    End Class
End Namespace