Namespace Registro.Sentencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscResolConmutacion
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblSala = New System.Windows.Forms.Label()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.PnlTipoAutoridad = New System.Windows.Forms.Panel()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblNroDocumento = New System.Windows.Forms.Label()
            Me.pnlDatosDocumento = New System.Windows.Forms.Panel()
            Me.pnlAutoridad = New System.Windows.Forms.Panel()
            Me.pnlObservacion = New System.Windows.Forms.Panel()
            Me.txtObsLib = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblObs = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.grbAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.PnlTipoAutoridad.SuspendLayout()
            Me.pnlDatosDocumento.SuspendLayout()
            Me.pnlAutoridad.SuspendLayout()
            Me.pnlObservacion.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.PnlOtraAutoridad)
            Me.grbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(0, 0)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(760, 70)
            Me.grbAutoridad.TabIndex = 0
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Autoridad"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label5)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 16)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(754, 51)
            Me.PnlAutoridadJudicial.TabIndex = 1
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(98, 3)
            Me.UscComboDistritoJudicial1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(247, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 22
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Controls.Add(Me.Label4)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label2)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(3, 16)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(754, 54)
            Me.PnlOtraAutoridad.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(3, 7)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Nombre Autoridad:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 29)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(86, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Cargo Autoridad:"
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(98, 26)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(652, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(98, 4)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(652, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDistrito.Location = New System.Drawing.Point(3, 7)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
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
            Me.UscComboSala1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscComboSala1.Location = New System.Drawing.Point(444, 2)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(306, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(359, 28)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSecretario.Location = New System.Drawing.Point(444, 25)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(306, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSala.Location = New System.Drawing.Point(359, 7)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtJuez.Location = New System.Drawing.Point(98, 25)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(247, 20)
            Me.txtJuez.TabIndex = 5
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 26)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 13)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Magistrado :"
            '
            'PnlTipoAutoridad
            '
            Me.PnlTipoAutoridad.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlTipoAutoridad.Controls.Add(Me.Label9)
            Me.PnlTipoAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlTipoAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlTipoAutoridad.Location = New System.Drawing.Point(0, 0)
            Me.PnlTipoAutoridad.Name = "PnlTipoAutoridad"
            Me.PnlTipoAutoridad.Size = New System.Drawing.Size(760, 22)
            Me.PnlTipoAutoridad.TabIndex = 0
            '
            'cbbTipoAutJud
            '
            Me.cbbTipoAutJud._NoIndica = True
            Me.cbbTipoAutJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoAutJud._Todos = True
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
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(100, 0)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(247, 22)
            Me.cbbTipoAutJud.TabIndex = 1
            Me.cbbTipoAutJud.verToolTipItemSeleccionado = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(3, 4)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(94, 13)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "Tipo de Autoridad:"
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Location = New System.Drawing.Point(446, 55)
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
            Me.txtLibro.Location = New System.Drawing.Point(446, 32)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(66, 20)
            Me.txtLibro.TabIndex = 7
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(389, 58)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 8
            Me.Label8.Text = "Folio:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(389, 35)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(33, 13)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Libro:"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(264, 56)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(184, 59)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(81, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fecha Recep. :"
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(101, 56)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(7, 59)
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
            Me.txtNumDocumento.Location = New System.Drawing.Point(101, 33)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(247, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblNroDocumento
            '
            Me.lblNroDocumento.AutoSize = True
            Me.lblNroDocumento.Location = New System.Drawing.Point(7, 36)
            Me.lblNroDocumento.Name = "lblNroDocumento"
            Me.lblNroDocumento.Size = New System.Drawing.Size(83, 13)
            Me.lblNroDocumento.TabIndex = 0
            Me.lblNroDocumento.Text = "N° Documento :"
            '
            'pnlDatosDocumento
            '
            Me.pnlDatosDocumento.Controls.Add(Me.pnlAutoridad)
            Me.pnlDatosDocumento.Controls.Add(Me.pnlCabecera)
            Me.pnlDatosDocumento.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDatosDocumento.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatosDocumento.Name = "pnlDatosDocumento"
            Me.pnlDatosDocumento.Size = New System.Drawing.Size(760, 183)
            Me.pnlDatosDocumento.TabIndex = 0
            '
            'pnlAutoridad
            '
            Me.pnlAutoridad.Controls.Add(Me.pnlObservacion)
            Me.pnlAutoridad.Controls.Add(Me.grbAutoridad)
            Me.pnlAutoridad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlAutoridad.Location = New System.Drawing.Point(0, 81)
            Me.pnlAutoridad.Name = "pnlAutoridad"
            Me.pnlAutoridad.Size = New System.Drawing.Size(760, 102)
            Me.pnlAutoridad.TabIndex = 1
            '
            'pnlObservacion
            '
            Me.pnlObservacion.Controls.Add(Me.txtObsLib)
            Me.pnlObservacion.Controls.Add(Me.lblObs)
            Me.pnlObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObservacion.Location = New System.Drawing.Point(0, 70)
            Me.pnlObservacion.Name = "pnlObservacion"
            Me.pnlObservacion.Size = New System.Drawing.Size(760, 32)
            Me.pnlObservacion.TabIndex = 4
            '
            'txtObsLib
            '
            Me.txtObsLib._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObsLib._BloquearPaste = False
            Me.txtObsLib._SeleccionarTodo = False
            Me.txtObsLib.BackColor = System.Drawing.SystemColors.Window
            Me.txtObsLib.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsLib.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObsLib.Location = New System.Drawing.Point(100, 0)
            Me.txtObsLib.MaxLength = 2500
            Me.txtObsLib.Multiline = True
            Me.txtObsLib.Name = "txtObsLib"
            Me.txtObsLib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsLib.Size = New System.Drawing.Size(660, 32)
            Me.txtObsLib.TabIndex = 1
            Me.txtObsLib.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObsLib.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblObs
            '
            Me.lblObs.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObs.Location = New System.Drawing.Point(0, 0)
            Me.lblObs.Name = "lblObs"
            Me.lblObs.Size = New System.Drawing.Size(100, 32)
            Me.lblObs.TabIndex = 0
            Me.lblObs.Text = " Observación :"
            Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.txtFolio)
            Me.pnlCabecera.Controls.Add(Me.lblNroDocumento)
            Me.pnlCabecera.Controls.Add(Me.PnlTipoAutoridad)
            Me.pnlCabecera.Controls.Add(Me.txtLibro)
            Me.pnlCabecera.Controls.Add(Me.Label8)
            Me.pnlCabecera.Controls.Add(Me.Label6)
            Me.pnlCabecera.Controls.Add(Me.Label7)
            Me.pnlCabecera.Controls.Add(Me.txtNumDocumento)
            Me.pnlCabecera.Controls.Add(Me.dtpDocJudFecha)
            Me.pnlCabecera.Controls.Add(Me.dtpDocJudFecRecep)
            Me.pnlCabecera.Controls.Add(Me.Label12)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(760, 81)
            Me.pnlCabecera.TabIndex = 0
            '
            'uscResolConmutacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlDatosDocumento)
            Me.Name = "uscResolConmutacion"
            Me.Size = New System.Drawing.Size(760, 183)
            Me.grbAutoridad.ResumeLayout(False)
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.PnlTipoAutoridad.ResumeLayout(False)
            Me.PnlTipoAutoridad.PerformLayout()
            Me.pnlDatosDocumento.ResumeLayout(False)
            Me.pnlAutoridad.ResumeLayout(False)
            Me.pnlObservacion.ResumeLayout(False)
            Me.pnlObservacion.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
        Friend WithEvents grbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents PnlTipoAutoridad As System.Windows.Forms.Panel
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents pnlDatosDocumento As System.Windows.Forms.Panel
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlAutoridad As System.Windows.Forms.Panel
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents pnlObservacion As Panel
        Friend WithEvents txtObsLib As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblObs As Label
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
    End Class
End Namespace