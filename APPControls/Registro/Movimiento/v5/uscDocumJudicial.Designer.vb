Namespace Registro.Movimiento.v5

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscDocumJudicial
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
            Me.PnlAutJudPrin = New System.Windows.Forms.Panel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.lblObs = New System.Windows.Forms.Label()
            Me.txtObsLib = New Legolas.APPUIComponents.MyTextBox()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox()
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65 = New Legolas.APPUIComponents.MyComboBox()
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671 = New Legolas.APPUIComponents.MyComboBox()
            Me.MyComboBox6 = New Legolas.APPUIComponents.MyComboBox()
            Me.MyComboBox7 = New Legolas.APPUIComponents.MyComboBox()
            Me.MyComboBox8 = New Legolas.APPUIComponents.MyComboBox()
            Me.MyComboBox9 = New Legolas.APPUIComponents.MyComboBox()
            Me.MyComboBox10 = New Legolas.APPUIComponents.MyComboBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.pnlUsc = New System.Windows.Forms.Panel()
            Me.pnlObservacion = New System.Windows.Forms.Panel()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.PnlAutJudPrin.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlUsc.SuspendLayout()
            Me.pnlObservacion.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.SuspendLayout()
            '
            'PnlAutJudPrin
            '
            Me.PnlAutJudPrin.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlAutJudPrin.Controls.Add(Me.Label5)
            Me.PnlAutJudPrin.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutJudPrin.Location = New System.Drawing.Point(0, 32)
            Me.PnlAutJudPrin.Name = "PnlAutJudPrin"
            Me.PnlAutJudPrin.Size = New System.Drawing.Size(660, 30)
            Me.PnlAutJudPrin.TabIndex = 1
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(3, 7)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(93, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Tipo de autoridad:"
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(102, 24)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(555, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(4, 6)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(98, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Nombre Autoridad :"
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(102, 2)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(555, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 28)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(63, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Cargo Aut. :"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Controls.Add(Me.cbbDistritoJud)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(0, 109)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(660, 48)
            Me.PnlAutoridadJudicial.TabIndex = 3
            Me.PnlAutoridadJudicial.Visible = False
            '
            'txtSecretario
            '
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(428, 24)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(229, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtJuez
            '
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(102, 24)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(245, 20)
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
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(4, 29)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Juez :"
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
            Me.Label11.Location = New System.Drawing.Point(347, 29)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'lblObs
            '
            Me.lblObs.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblObs.Location = New System.Drawing.Point(0, 0)
            Me.lblObs.Name = "lblObs"
            Me.lblObs.Size = New System.Drawing.Size(101, 89)
            Me.lblObs.TabIndex = 0
            Me.lblObs.Text = "Observación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Documento :"
            Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtObsLib
            '
            Me.txtObsLib._BloquearPaste = False
            Me.txtObsLib._SeleccionarTodo = False
            Me.txtObsLib.BackColor = System.Drawing.SystemColors.Window
            Me.txtObsLib.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsLib.Location = New System.Drawing.Point(101, 0)
            Me.txtObsLib.MaxLength = 500
            Me.txtObsLib.Multiline = True
            Me.txtObsLib.Name = "txtObsLib"
            Me.txtObsLib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObsLib.Size = New System.Drawing.Size(559, 89)
            Me.txtObsLib.TabIndex = 1
            Me.txtObsLib.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObsLib.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 325
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(245, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'object_9d468817_5cab_41b1_8244_ceb6a2500e65
            '
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.DropDownWidth = 325
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.FormattingEnabled = True
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.Location = New System.Drawing.Point(0, 0)
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.Name = "object_9d468817_5cab_41b1_8244_ceb6a2500e65"
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.Size = New System.Drawing.Size(245, 21)
            Me.object_9d468817_5cab_41b1_8244_ceb6a2500e65.TabIndex = 2
            '
            'object_82c16e32_b850_4de1_9c1c_f8b81ee93671
            '
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.DropDownWidth = 325
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.FormattingEnabled = True
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.Location = New System.Drawing.Point(0, 0)
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.Name = "object_82c16e32_b850_4de1_9c1c_f8b81ee93671"
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.Size = New System.Drawing.Size(245, 21)
            Me.object_82c16e32_b850_4de1_9c1c_f8b81ee93671.TabIndex = 2
            '
            'MyComboBox6
            '
            Me.MyComboBox6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox6.DropDownWidth = 325
            Me.MyComboBox6.FormattingEnabled = True
            Me.MyComboBox6.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox6.Name = "MyComboBox6"
            Me.MyComboBox6.Size = New System.Drawing.Size(245, 21)
            Me.MyComboBox6.TabIndex = 2
            '
            'MyComboBox7
            '
            Me.MyComboBox7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox7.DropDownWidth = 325
            Me.MyComboBox7.FormattingEnabled = True
            Me.MyComboBox7.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox7.Name = "MyComboBox7"
            Me.MyComboBox7.Size = New System.Drawing.Size(245, 21)
            Me.MyComboBox7.TabIndex = 2
            '
            'MyComboBox8
            '
            Me.MyComboBox8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox8.DropDownWidth = 325
            Me.MyComboBox8.FormattingEnabled = True
            Me.MyComboBox8.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox8.Name = "MyComboBox8"
            Me.MyComboBox8.Size = New System.Drawing.Size(245, 21)
            Me.MyComboBox8.TabIndex = 2
            '
            'MyComboBox9
            '
            Me.MyComboBox9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox9.DropDownWidth = 325
            Me.MyComboBox9.FormattingEnabled = True
            Me.MyComboBox9.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox9.Name = "MyComboBox9"
            Me.MyComboBox9.Size = New System.Drawing.Size(245, 21)
            Me.MyComboBox9.TabIndex = 2
            '
            'MyComboBox10
            '
            Me.MyComboBox10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MyComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MyComboBox10.DropDownWidth = 325
            Me.MyComboBox10.FormattingEnabled = True
            Me.MyComboBox10.Location = New System.Drawing.Point(0, 0)
            Me.MyComboBox10.Name = "MyComboBox10"
            Me.MyComboBox10.Size = New System.Drawing.Size(245, 21)
            Me.MyComboBox10.TabIndex = 2
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(4, 11)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(362, 11)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Fec. Doc. :"
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(419, 7)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(501, 11)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recep. :"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(573, 7)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(102, 7)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(245, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.Label30)
            Me.pnlCabecera.Controls.Add(Me.dtpDocJudFecha)
            Me.pnlCabecera.Controls.Add(Me.Label12)
            Me.pnlCabecera.Controls.Add(Me.dtpDocJudFecRecep)
            Me.pnlCabecera.Controls.Add(Me.txtNumDocumento)
            Me.pnlCabecera.Controls.Add(Me.Label6)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(660, 32)
            Me.pnlCabecera.TabIndex = 0
            '
            'pnlUsc
            '
            Me.pnlUsc.Controls.Add(Me.PnlAutoridadJudicial)
            Me.pnlUsc.Controls.Add(Me.PnlOtraAutoridad)
            Me.pnlUsc.Controls.Add(Me.PnlAutJudPrin)
            Me.pnlUsc.Controls.Add(Me.pnlObservacion)
            Me.pnlUsc.Controls.Add(Me.pnlCabecera)
            Me.pnlUsc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlUsc.Location = New System.Drawing.Point(0, 0)
            Me.pnlUsc.Name = "pnlUsc"
            Me.pnlUsc.Size = New System.Drawing.Size(660, 246)
            Me.pnlUsc.TabIndex = 1
            '
            'pnlObservacion
            '
            Me.pnlObservacion.Controls.Add(Me.txtObsLib)
            Me.pnlObservacion.Controls.Add(Me.lblObs)
            Me.pnlObservacion.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlObservacion.Location = New System.Drawing.Point(0, 157)
            Me.pnlObservacion.Name = "pnlObservacion"
            Me.pnlObservacion.Size = New System.Drawing.Size(660, 89)
            Me.pnlObservacion.TabIndex = 4
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label4)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label3)
            Me.PnlOtraAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(0, 62)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(660, 47)
            Me.PnlOtraAutoridad.TabIndex = 2
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1.Location = New System.Drawing.Point(428, 2)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(229, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'cbbDistritoJud
            '
            Me.cbbDistritoJud._NoIndica = False
            Me.cbbDistritoJud._Todos = False
            Me.cbbDistritoJud._TodosMensaje = ""
            Me.cbbDistritoJud._Visible_Add = False
            Me.cbbDistritoJud._Visible_Buscar = False
            Me.cbbDistritoJud._Visible_Eliminar = False
            Me.cbbDistritoJud.CodigoPadre = -1
            Me.cbbDistritoJud.ComboTipo = Type.Combo.ComboTipo.AutorizacionJudicial
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 325
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.Location = New System.Drawing.Point(102, 2)
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(245, 22)
            Me.cbbDistritoJud.TabIndex = 1
            '
            'cbbTipoAutJud
            '
            Me.cbbTipoAutJud._NoIndica = False
            Me.cbbTipoAutJud._Todos = False
            Me.cbbTipoAutJud._TodosMensaje = ""
            Me.cbbTipoAutJud._Visible_Add = False
            Me.cbbTipoAutJud._Visible_Buscar = False
            Me.cbbTipoAutJud._Visible_Eliminar = False
            Me.cbbTipoAutJud.CodigoPadre = -1
            Me.cbbTipoAutJud.ComboTipo = Type.Combo.ComboTipo.TipoAutoridadJudicial
            Me.cbbTipoAutJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoAutJud.DropDownWidth = 325
            Me.cbbTipoAutJud.DropDownWidthAuto = False
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(102, 4)
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(245, 22)
            Me.cbbTipoAutJud.TabIndex = 1
            '
            'uscDocumJudicial
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlUsc)
            Me.Name = "uscDocumJudicial"
            Me.Size = New System.Drawing.Size(660, 246)
            Me.PnlAutJudPrin.ResumeLayout(False)
            Me.PnlAutJudPrin.PerformLayout()
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.pnlUsc.ResumeLayout(False)
            Me.pnlObservacion.ResumeLayout(False)
            Me.pnlObservacion.PerformLayout()
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlAutJudPrin As System.Windows.Forms.Panel
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblObs As System.Windows.Forms.Label
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtObsLib As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents object_9d468817_5cab_41b1_8244_ceb6a2500e65 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents object_82c16e32_b850_4de1_9c1c_f8b81ee93671 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox6 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox7 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox8 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox9 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents MyComboBox10 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlUsc As System.Windows.Forms.Panel
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents pnlObservacion As System.Windows.Forms.Panel
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
    End Class
End Namespace