Namespace Registro.Sentencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class usrResolSentenciaV2
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
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.pnlDetalleResolucion = New System.Windows.Forms.Panel()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.txtResolucion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.ckbFecRecepcion = New System.Windows.Forms.CheckBox()
            Me.ckbResolucion = New System.Windows.Forms.CheckBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.ckbFecResolucion = New System.Windows.Forms.CheckBox()
            Me.dtpFechaRecepResolucion = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaResolucion = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblResolucion = New System.Windows.Forms.Label()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.dtpFechRecepDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpFechDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.txtNumOficio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label30 = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.chkCadenaPerpetua = New System.Windows.Forms.CheckBox()
            Me.UscDateTimePicker3 = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.chkConsentida = New System.Windows.Forms.CheckBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.rdbSi = New System.Windows.Forms.RadioButton()
            Me.rdbNo = New System.Windows.Forms.RadioButton()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Panel5.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.pnlDetalleResolucion.SuspendLayout()
            Me.grbAutoridad.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.grbCabecera)
            Me.Panel5.Controls.Add(Me.pnlCabecera)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(707, 188)
            Me.Panel5.TabIndex = 0
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.Label4)
            Me.grbCabecera.Controls.Add(Me.Label9)
            Me.grbCabecera.Controls.Add(Me.pnlDetalleResolucion)
            Me.grbCabecera.Controls.Add(Me.txtSecretario)
            Me.grbCabecera.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.grbCabecera.Controls.Add(Me.txtJuez)
            Me.grbCabecera.Controls.Add(Me.Label1)
            Me.grbCabecera.Controls.Add(Me.UscComboSala1)
            Me.grbCabecera.Controls.Add(Me.dtpFechRecepDoc)
            Me.grbCabecera.Controls.Add(Me.lblDistrito)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Controls.Add(Me.dtpFechDoc)
            Me.grbCabecera.Controls.Add(Me.lblSala)
            Me.grbCabecera.Controls.Add(Me.txtNumOficio)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbCabecera.Location = New System.Drawing.Point(0, 23)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(707, 165)
            Me.grbCabecera.TabIndex = 1
            Me.grbCabecera.TabStop = False
            Me.grbCabecera.Text = "Datos del Oficio"
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(382, 77)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(61, 13)
            Me.Label4.TabIndex = 16
            Me.Label4.Text = "Secretario :"
            '
            'Label9
            '
            Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(381, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(96, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Fecha documento:"
            '
            'pnlDetalleResolucion
            '
            Me.pnlDetalleResolucion.Controls.Add(Me.txtObservacion)
            Me.pnlDetalleResolucion.Controls.Add(Me.Label3)
            Me.pnlDetalleResolucion.Controls.Add(Me.grbAutoridad)
            Me.pnlDetalleResolucion.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlDetalleResolucion.Location = New System.Drawing.Point(3, 98)
            Me.pnlDetalleResolucion.Name = "pnlDetalleResolucion"
            Me.pnlDetalleResolucion.Size = New System.Drawing.Size(701, 64)
            Me.pnlDetalleResolucion.TabIndex = 14
            '
            'txtObservacion
            '
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(382, 17)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(319, 47)
            Me.txtObservacion.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(382, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(83, 17)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "   Observación :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label3.UseCompatibleTextRendering = True
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.txtResolucion)
            Me.grbAutoridad.Controls.Add(Me.ckbFecRecepcion)
            Me.grbAutoridad.Controls.Add(Me.ckbResolucion)
            Me.grbAutoridad.Controls.Add(Me.Label10)
            Me.grbAutoridad.Controls.Add(Me.ckbFecResolucion)
            Me.grbAutoridad.Controls.Add(Me.dtpFechaRecepResolucion)
            Me.grbAutoridad.Controls.Add(Me.Label6)
            Me.grbAutoridad.Controls.Add(Me.dtpFechaResolucion)
            Me.grbAutoridad.Controls.Add(Me.lblResolucion)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(0, 0)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(382, 64)
            Me.grbAutoridad.TabIndex = 0
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Comunicación de la Resolución"
            '
            'txtResolucion
            '
            Me.txtResolucion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtResolucion._BloquearPaste = False
            Me.txtResolucion._SeleccionarTodo = False
            Me.txtResolucion.Location = New System.Drawing.Point(93, 17)
            Me.txtResolucion.MaxLength = 120
            Me.txtResolucion.Name = "txtResolucion"
            Me.txtResolucion.Size = New System.Drawing.Size(264, 20)
            Me.txtResolucion.TabIndex = 1
            Me.txtResolucion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtResolucion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.ToolTip1.SetToolTip(Me.txtResolucion, "N° de Resolución Inimputable")
            '
            'ckbFecRecepcion
            '
            Me.ckbFecRecepcion.AutoSize = True
            Me.ckbFecRecepcion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbFecRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ckbFecRecepcion.Location = New System.Drawing.Point(358, 43)
            Me.ckbFecRecepcion.Name = "ckbFecRecepcion"
            Me.ckbFecRecepcion.Size = New System.Drawing.Size(15, 14)
            Me.ckbFecRecepcion.TabIndex = 7
            Me.ckbFecRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbFecRecepcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ToolTip1.SetToolTip(Me.ckbFecRecepcion, "Habilitar opción para indicar que no se cuenta con el dato.")
            Me.ckbFecRecepcion.UseVisualStyleBackColor = True
            Me.ckbFecRecepcion.Visible = False
            '
            'ckbResolucion
            '
            Me.ckbResolucion.AutoSize = True
            Me.ckbResolucion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ckbResolucion.Location = New System.Drawing.Point(358, 20)
            Me.ckbResolucion.Name = "ckbResolucion"
            Me.ckbResolucion.Size = New System.Drawing.Size(15, 14)
            Me.ckbResolucion.TabIndex = 2
            Me.ckbResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbResolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ckbResolucion.ThreeState = True
            Me.ToolTip1.SetToolTip(Me.ckbResolucion, "Habilitar opción para indicar que no se cuenta con el dato.")
            Me.ckbResolucion.UseVisualStyleBackColor = True
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(196, 44)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(77, 13)
            Me.Label10.TabIndex = 5
            Me.Label10.Text = "F. Recepción :"
            Me.Label10.Visible = False
            '
            'ckbFecResolucion
            '
            Me.ckbFecResolucion.AutoSize = True
            Me.ckbFecResolucion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbFecResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ckbFecResolucion.Location = New System.Drawing.Point(177, 43)
            Me.ckbFecResolucion.Name = "ckbFecResolucion"
            Me.ckbFecResolucion.Size = New System.Drawing.Size(15, 14)
            Me.ckbFecResolucion.TabIndex = 5
            Me.ckbFecResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbFecResolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ToolTip1.SetToolTip(Me.ckbFecResolucion, "Habilitar opción para indicar que no se cuenta con el dato.")
            Me.ckbFecResolucion.UseVisualStyleBackColor = True
            '
            'dtpFechaRecepResolucion
            '
            Me.dtpFechaRecepResolucion.Location = New System.Drawing.Point(274, 40)
            Me.dtpFechaRecepResolucion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaRecepResolucion.Name = "dtpFechaRecepResolucion"
            Me.dtpFechaRecepResolucion.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRecepResolucion.TabIndex = 6
            Me.dtpFechaRecepResolucion.Value = "/  /"
            Me.dtpFechaRecepResolucion.ValueLong = CType(0, Long)
            Me.dtpFechaRecepResolucion.Visible = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(2, 44)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(78, 13)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "F. Resolución :"
            '
            'dtpFechaResolucion
            '
            Me.dtpFechaResolucion.Location = New System.Drawing.Point(93, 41)
            Me.dtpFechaResolucion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaResolucion.Name = "dtpFechaResolucion"
            Me.dtpFechaResolucion.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaResolucion.TabIndex = 4
            Me.dtpFechaResolucion.Value = "/  /"
            Me.dtpFechaResolucion.ValueLong = CType(0, Long)
            '
            'lblResolucion
            '
            Me.lblResolucion.AutoSize = True
            Me.lblResolucion.Location = New System.Drawing.Point(2, 20)
            Me.lblResolucion.Name = "lblResolucion"
            Me.lblResolucion.Size = New System.Drawing.Size(93, 13)
            Me.lblResolucion.TabIndex = 0
            Me.lblResolucion.Text = "N° de Resolución:"
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSecretario.Location = New System.Drawing.Point(477, 74)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(227, 20)
            Me.txtSecretario.TabIndex = 13
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._DropDownWidthAuto = False
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1._visibleBuscar = True
            Me.UscComboDistritoJudicial1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.UscComboDistritoJudicial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(96, 37)
            Me.UscComboDistritoJudicial1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(279, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 7
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtJuez.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtJuez.Location = New System.Drawing.Point(96, 74)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(279, 20)
            Me.txtJuez.TabIndex = 11
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 77)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Juez :"
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._DropDownWidthAuto = False
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1._Todos = False
            Me.UscComboSala1._TodosMensaje = ""
            Me.UscComboSala1._visibleBuscar = True
            Me.UscComboSala1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscComboSala1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscComboSala1.Location = New System.Drawing.Point(477, 37)
            Me.UscComboSala1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(231, 21)
            Me.UscComboSala1.TabIndex = 9
            '
            'dtpFechRecepDoc
            '
            Me.dtpFechRecepDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechRecepDoc.Location = New System.Drawing.Point(653, 13)
            Me.dtpFechRecepDoc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.dtpFechRecepDoc.Name = "dtpFechRecepDoc"
            Me.dtpFechRecepDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechRecepDoc.TabIndex = 5
            Me.dtpFechRecepDoc.Value = "/  /"
            Me.dtpFechRecepDoc.ValueLong = CType(0, Long)
            '
            'lblDistrito
            '
            Me.lblDistrito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDistrito.Location = New System.Drawing.Point(3, 42)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 6
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(562, 16)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(90, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fecha recepción:"
            '
            'dtpFechDoc
            '
            Me.dtpFechDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpFechDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechDoc.Location = New System.Drawing.Point(477, 13)
            Me.dtpFechDoc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.dtpFechDoc.Name = "dtpFechDoc"
            Me.dtpFechDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechDoc.TabIndex = 3
            Me.dtpFechDoc.Value = "/  /"
            Me.dtpFechDoc.ValueLong = CType(0, Long)
            '
            'lblSala
            '
            Me.lblSala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSala.AutoSize = True
            Me.lblSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSala.Location = New System.Drawing.Point(381, 42)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(93, 13)
            Me.lblSala.TabIndex = 8
            Me.lblSala.Text = "Autoridad Judicial:"
            '
            'txtNumOficio
            '
            Me.txtNumOficio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOficio._BloquearPaste = False
            Me.txtNumOficio._SeleccionarTodo = False
            Me.txtNumOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumOficio.Location = New System.Drawing.Point(96, 13)
            Me.txtNumOficio.MaxLength = 120
            Me.txtNumOficio.Name = "txtNumOficio"
            Me.txtNumOficio.Size = New System.Drawing.Size(279, 20)
            Me.txtNumOficio.TabIndex = 1
            Me.txtNumOficio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumOficio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(3, 18)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.Label5)
            Me.pnlCabecera.Controls.Add(Me.txtFolio)
            Me.pnlCabecera.Controls.Add(Me.Panel2)
            Me.pnlCabecera.Controls.Add(Me.Label8)
            Me.pnlCabecera.Controls.Add(Me.txtLibro)
            Me.pnlCabecera.Controls.Add(Me.Label7)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(707, 23)
            Me.pnlCabecera.TabIndex = 0
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Location = New System.Drawing.Point(0, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(395, 20)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "RESOLUCION QUE DECLARA CONSENTIDA LA SENTENCIA"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label5.UseCompatibleTextRendering = True
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFolio.Location = New System.Drawing.Point(645, 2)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(61, 20)
            Me.txtFolio.TabIndex = 4
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label11)
            Me.Panel2.Controls.Add(Me.chkCadenaPerpetua)
            Me.Panel2.Controls.Add(Me.UscDateTimePicker3)
            Me.Panel2.Controls.Add(Me.chkConsentida)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.rdbSi)
            Me.Panel2.Controls.Add(Me.rdbNo)
            Me.Panel2.Location = New System.Drawing.Point(345, 4)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(51, 13)
            Me.Panel2.TabIndex = 14
            Me.Panel2.Visible = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(213, 4)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(73, 13)
            Me.Label11.TabIndex = 3
            Me.Label11.Text = "F. Sentencia :"
            '
            'chkCadenaPerpetua
            '
            Me.chkCadenaPerpetua.AutoSize = True
            Me.chkCadenaPerpetua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCadenaPerpetua.Location = New System.Drawing.Point(586, 3)
            Me.chkCadenaPerpetua.Name = "chkCadenaPerpetua"
            Me.chkCadenaPerpetua.Size = New System.Drawing.Size(112, 17)
            Me.chkCadenaPerpetua.TabIndex = 6
            Me.chkCadenaPerpetua.Text = " Cadena Perpetua"
            Me.chkCadenaPerpetua.UseVisualStyleBackColor = True
            '
            'UscDateTimePicker3
            '
            Me.UscDateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscDateTimePicker3.Location = New System.Drawing.Point(289, 1)
            Me.UscDateTimePicker3.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.UscDateTimePicker3.Name = "UscDateTimePicker3"
            Me.UscDateTimePicker3.Size = New System.Drawing.Size(84, 21)
            Me.UscDateTimePicker3.TabIndex = 4
            Me.UscDateTimePicker3.Value = "/  /"
            Me.UscDateTimePicker3.ValueLong = CType(0, Long)
            '
            'chkConsentida
            '
            Me.chkConsentida.AutoSize = True
            Me.chkConsentida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkConsentida.Location = New System.Drawing.Point(498, 3)
            Me.chkConsentida.Name = "chkConsentida"
            Me.chkConsentida.Size = New System.Drawing.Size(82, 17)
            Me.chkConsentida.TabIndex = 5
            Me.chkConsentida.Text = " Consentida"
            Me.chkConsentida.UseVisualStyleBackColor = True
            Me.chkConsentida.Visible = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(24, 4)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Consentida:"
            '
            'rdbSi
            '
            Me.rdbSi.AutoSize = True
            Me.rdbSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSi.Location = New System.Drawing.Point(96, 3)
            Me.rdbSi.Name = "rdbSi"
            Me.rdbSi.Size = New System.Drawing.Size(35, 17)
            Me.rdbSi.TabIndex = 1
            Me.rdbSi.Text = "SI"
            Me.rdbSi.UseVisualStyleBackColor = True
            '
            'rdbNo
            '
            Me.rdbNo.AutoSize = True
            Me.rdbNo.Checked = True
            Me.rdbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNo.Location = New System.Drawing.Point(137, 3)
            Me.rdbNo.Name = "rdbNo"
            Me.rdbNo.Size = New System.Drawing.Size(41, 17)
            Me.rdbNo.TabIndex = 2
            Me.rdbNo.TabStop = True
            Me.rdbNo.Text = "NO"
            Me.rdbNo.UseVisualStyleBackColor = True
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(604, 4)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "Folio:"
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtLibro.Location = New System.Drawing.Point(533, 2)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(61, 20)
            Me.txtLibro.TabIndex = 2
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(491, 6)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(33, 13)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Libro:"
            '
            'object_54cb3d30_851e_467f_b037_d3de6ef8c4c2
            '
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.DropDownWidth = 325
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.FormattingEnabled = True
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Location = New System.Drawing.Point(0, 0)
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Name = "object_54cb3d30_851e_467f_b037_d3de6ef8c4c2"
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Size = New System.Drawing.Size(388, 21)
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.TabIndex = 2
            '
            'object_a2eed2a7_9942_4461_8690_c4ded575d9fb
            '
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.DropDownWidth = 325
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.FormattingEnabled = True
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Location = New System.Drawing.Point(0, 0)
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Name = "object_a2eed2a7_9942_4461_8690_c4ded575d9fb"
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Size = New System.Drawing.Size(388, 21)
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.TabIndex = 2
            '
            'usrResolSentenciaV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel5)
            Me.Name = "usrResolSentenciaV2"
            Me.Size = New System.Drawing.Size(707, 188)
            Me.Panel5.ResumeLayout(False)
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.pnlDetalleResolucion.ResumeLayout(False)
            Me.pnlDetalleResolucion.PerformLayout()
            Me.grbAutoridad.ResumeLayout(False)
            Me.grbAutoridad.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents txtFolio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtLibro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpFechRecepDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpFechDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtNumOficio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents chkConsentida As System.Windows.Forms.CheckBox
        Friend WithEvents object_54cb3d30_851e_467f_b037_d3de6ef8c4c2 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents object_a2eed2a7_9942_4461_8690_c4ded575d9fb As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents UscComboSala1 As Busqueda.uscComboSala
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents lblSala As Label
        Friend WithEvents rdbNo As RadioButton
        Friend WithEvents rdbSi As RadioButton
        Friend WithEvents chkCadenaPerpetua As CheckBox
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
        Friend WithEvents pnlDetalleResolucion As Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents grbAutoridad As GroupBox
        Friend WithEvents Label10 As Label
        Friend WithEvents ckbFecResolucion As CheckBox
        Friend WithEvents dtpFechaRecepResolucion As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaResolucion As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtResolucion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblResolucion As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents ckbFecRecepcion As CheckBox
        Friend WithEvents ckbResolucion As CheckBox
        Friend WithEvents Label11 As Label
        Friend WithEvents UscDateTimePicker3 As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtObservacion As TextBox
        Friend WithEvents Label4 As Label
    End Class
End Namespace