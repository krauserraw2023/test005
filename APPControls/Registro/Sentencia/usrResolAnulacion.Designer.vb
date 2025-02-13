Namespace Registro.Sentencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class usrResolAnulacion
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
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.dtpFecSentencia = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.chkCadenaPerpetua = New System.Windows.Forms.CheckBox()
            Me.pnlJornadas = New System.Windows.Forms.Panel()
            Me.txtCant = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.chkConsentida = New System.Windows.Forms.CheckBox()
            Me.lblTextCondena = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.pnlSemicabecera = New System.Windows.Forms.Panel()
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.txtFolio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtLibro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpFechRecepDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpFechDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtNumOficio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.cbbAnulacion = New APPControls.uscComboParametrica()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel5.SuspendLayout()
            Me.pnlPie.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlJornadas.SuspendLayout()
            Me.pnlSemicabecera.SuspendLayout()
            Me.grbAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.pnlPie)
            Me.Panel5.Controls.Add(Me.pnlSemicabecera)
            Me.Panel5.Controls.Add(Me.pnlCabecera)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(666, 222)
            Me.Panel5.TabIndex = 0
            '
            'pnlPie
            '
            Me.pnlPie.Controls.Add(Me.Panel7)
            Me.pnlPie.Controls.Add(Me.Panel3)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPie.Location = New System.Drawing.Point(0, 148)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(666, 74)
            Me.pnlPie.TabIndex = 2
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.txtObservacion)
            Me.Panel7.Controls.Add(Me.Panel1)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(0, 35)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(666, 39)
            Me.Panel7.TabIndex = 4
            '
            'txtObservacion
            '
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Location = New System.Drawing.Point(97, 0)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(569, 39)
            Me.txtObservacion.TabIndex = 2
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(97, 39)
            Me.Panel1.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(0, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(83, 17)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "   Observación :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label3.UseCompatibleTextRendering = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.dtpFecSentencia)
            Me.Panel3.Controls.Add(Me.Label17)
            Me.Panel3.Controls.Add(Me.chkCadenaPerpetua)
            Me.Panel3.Controls.Add(Me.pnlJornadas)
            Me.Panel3.Controls.Add(Me.chkConsentida)
            Me.Panel3.Controls.Add(Me.lblTextCondena)
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(666, 35)
            Me.Panel3.TabIndex = 3
            '
            'dtpFecSentencia
            '
            Me.dtpFecSentencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpFecSentencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecSentencia.Location = New System.Drawing.Point(365, 8)
            Me.dtpFecSentencia.Name = "dtpFecSentencia"
            Me.dtpFecSentencia.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecSentencia.TabIndex = 2
            Me.dtpFecSentencia.Value = "/  /"
            Me.dtpFecSentencia.ValueLong = CType(0, Long)
            '
            'Label17
            '
            Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(292, 12)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(71, 13)
            Me.Label17.TabIndex = 1
            Me.Label17.Text = "Fecha Sent. :"
            '
            'chkCadenaPerpetua
            '
            Me.chkCadenaPerpetua.AutoSize = True
            Me.chkCadenaPerpetua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCadenaPerpetua.Location = New System.Drawing.Point(181, 10)
            Me.chkCadenaPerpetua.Name = "chkCadenaPerpetua"
            Me.chkCadenaPerpetua.Size = New System.Drawing.Size(109, 17)
            Me.chkCadenaPerpetua.TabIndex = 1
            Me.chkCadenaPerpetua.Text = "Cadena Perpetua"
            Me.chkCadenaPerpetua.UseVisualStyleBackColor = True
            '
            'pnlJornadas
            '
            Me.pnlJornadas.Controls.Add(Me.txtCant)
            Me.pnlJornadas.Controls.Add(Me.Label4)
            Me.pnlJornadas.Controls.Add(Me.Label2)
            Me.pnlJornadas.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlJornadas.Location = New System.Drawing.Point(451, 0)
            Me.pnlJornadas.Name = "pnlJornadas"
            Me.pnlJornadas.Size = New System.Drawing.Size(215, 35)
            Me.pnlJornadas.TabIndex = 3
            Me.pnlJornadas.Visible = False
            '
            'txtCant
            '
            Me.txtCant._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCant._BloquearPaste = False
            Me.txtCant._SeleccionarTodo = False
            Me.txtCant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCant.Location = New System.Drawing.Point(127, 8)
            Me.txtCant.Name = "txtCant"
            Me.txtCant.Size = New System.Drawing.Size(30, 20)
            Me.txtCant.TabIndex = 1
            Me.txtCant.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtCant.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(158, 11)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(50, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Jornadas"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(5, 4)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(121, 26)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Prestación de Servicios " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             a Comunitarios :"
            '
            'chkConsentida
            '
            Me.chkConsentida.AutoSize = True
            Me.chkConsentida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkConsentida.Location = New System.Drawing.Point(99, 10)
            Me.chkConsentida.Name = "chkConsentida"
            Me.chkConsentida.Size = New System.Drawing.Size(79, 17)
            Me.chkConsentida.TabIndex = 0
            Me.chkConsentida.Text = "Consentida"
            Me.chkConsentida.UseVisualStyleBackColor = True
            '
            'lblTextCondena
            '
            Me.lblTextCondena.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTextCondena.AutoSize = True
            Me.lblTextCondena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTextCondena.Location = New System.Drawing.Point(3, 3)
            Me.lblTextCondena.Name = "lblTextCondena"
            Me.lblTextCondena.Size = New System.Drawing.Size(64, 13)
            Me.lblTextCondena.TabIndex = 0
            Me.lblTextCondena.Text = "Sentencia"
            '
            'Panel4
            '
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Location = New System.Drawing.Point(96, 6)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(196, 23)
            Me.Panel4.TabIndex = 4
            '
            'pnlSemicabecera
            '
            Me.pnlSemicabecera.Controls.Add(Me.grbAutoridad)
            Me.pnlSemicabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSemicabecera.Location = New System.Drawing.Point(0, 82)
            Me.pnlSemicabecera.Name = "pnlSemicabecera"
            Me.pnlSemicabecera.Size = New System.Drawing.Size(666, 66)
            Me.pnlSemicabecera.TabIndex = 1
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(0, 0)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(666, 66)
            Me.grbAutoridad.TabIndex = 0
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
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 16)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(660, 47)
            Me.PnlAutoridadJudicial.TabIndex = 0
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(94, 1)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(281, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 21
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
            Me.UscComboSala1.Location = New System.Drawing.Point(463, 1)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(190, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(463, 24)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(190, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(93, 24)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(282, 20)
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
            Me.Label1.Location = New System.Drawing.Point(4, 27)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Juez :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(388, 7)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(388, 27)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.grbCabecera)
            Me.pnlCabecera.Controls.Add(Me.Panel2)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(666, 82)
            Me.pnlCabecera.TabIndex = 0
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.txtFolio)
            Me.grbCabecera.Controls.Add(Me.txtLibro)
            Me.grbCabecera.Controls.Add(Me.Label8)
            Me.grbCabecera.Controls.Add(Me.Label7)
            Me.grbCabecera.Controls.Add(Me.dtpFechRecepDoc)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Controls.Add(Me.dtpFechDoc)
            Me.grbCabecera.Controls.Add(Me.Label9)
            Me.grbCabecera.Controls.Add(Me.txtNumOficio)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbCabecera.Location = New System.Drawing.Point(0, 26)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(666, 56)
            Me.grbCabecera.TabIndex = 1
            Me.grbCabecera.TabStop = False
            '
            'txtFolio
            '
            Me.txtFolio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFolio._BloquearPaste = False
            Me.txtFolio._SeleccionarTodo = False
            Me.txtFolio.Location = New System.Drawing.Point(466, 32)
            Me.txtFolio.MaxLength = 4
            Me.txtFolio.Name = "txtFolio"
            Me.txtFolio.Size = New System.Drawing.Size(84, 20)
            Me.txtFolio.TabIndex = 9
            Me.txtFolio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFolio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtLibro
            '
            Me.txtLibro._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtLibro._BloquearPaste = False
            Me.txtLibro._SeleccionarTodo = False
            Me.txtLibro.Location = New System.Drawing.Point(466, 8)
            Me.txtLibro.MaxLength = 20
            Me.txtLibro.Name = "txtLibro"
            Me.txtLibro.Size = New System.Drawing.Size(84, 20)
            Me.txtLibro.TabIndex = 7
            Me.txtLibro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtLibro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(388, 38)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 8
            Me.Label8.Text = "Folio:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(388, 15)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(33, 13)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Libro:"
            '
            'dtpFechRecepDoc
            '
            Me.dtpFechRecepDoc.Location = New System.Drawing.Point(295, 32)
            Me.dtpFechRecepDoc.Name = "dtpFechRecepDoc"
            Me.dtpFechRecepDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechRecepDoc.TabIndex = 5
            Me.dtpFechRecepDoc.Value = "/  /"
            Me.dtpFechRecepDoc.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(213, 35)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(78, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fecha Recep :"
            '
            'dtpFechDoc
            '
            Me.dtpFechDoc.Location = New System.Drawing.Point(96, 32)
            Me.dtpFechDoc.Name = "dtpFechDoc"
            Me.dtpFechDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechDoc.TabIndex = 3
            Me.dtpFechDoc.Value = "/  /"
            Me.dtpFechDoc.ValueLong = CType(0, Long)
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(5, 36)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(69, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Fecha Doc. :"
            '
            'txtNumOficio
            '
            Me.txtNumOficio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOficio._BloquearPaste = False
            Me.txtNumOficio._SeleccionarTodo = False
            Me.txtNumOficio.Location = New System.Drawing.Point(96, 8)
            Me.txtNumOficio.MaxLength = 120
            Me.txtNumOficio.Name = "txtNumOficio"
            Me.txtNumOficio.Size = New System.Drawing.Size(282, 20)
            Me.txtNumOficio.TabIndex = 1
            Me.txtNumOficio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumOficio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(5, 12)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.cbbAnulacion)
            Me.Panel2.Controls.Add(Me.Label5)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(666, 26)
            Me.Panel2.TabIndex = 0
            '
            'cbbAnulacion
            '
            Me.cbbAnulacion._NoIndica = False
            Me.cbbAnulacion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbAnulacion._Todos = False
            Me.cbbAnulacion._TodosMensaje = ""
            Me.cbbAnulacion._Visible_Add = False
            Me.cbbAnulacion._Visible_Buscar = False
            Me.cbbAnulacion._Visible_Eliminar = False
            Me.cbbAnulacion.CodigoPadre = -1
            Me.cbbAnulacion.ComboTipo = CType(75, Short)
            Me.cbbAnulacion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbAnulacion.DropDownWidth = 325
            Me.cbbAnulacion.DropDownWidthAuto = False
            Me.cbbAnulacion.ListaIdsParaExcluir = Nothing
            Me.cbbAnulacion.Location = New System.Drawing.Point(96, 2)
            Me.cbbAnulacion.ModuloTratamiento = False
            Me.cbbAnulacion.Name = "cbbAnulacion"
            Me.cbbAnulacion.Parametro1 = -1
            Me.cbbAnulacion.Parametro2 = -1
            Me.cbbAnulacion.SelectedIndex = -1
            Me.cbbAnulacion.SelectedValue = 0
            Me.cbbAnulacion.Size = New System.Drawing.Size(282, 22)
            Me.cbbAnulacion.TabIndex = 2
            Me.cbbAnulacion.verToolTipItemSeleccionado = False
            '
            'Label5
            '
            Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(1, 7)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(96, 13)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Tipo Anulación:"
            '
            'usrResolAnulacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel5)
            Me.Name = "usrResolAnulacion"
            Me.Size = New System.Drawing.Size(666, 222)
            Me.Panel5.ResumeLayout(False)
            Me.pnlPie.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlJornadas.ResumeLayout(False)
            Me.pnlJornadas.PerformLayout()
            Me.pnlSemicabecera.ResumeLayout(False)
            Me.grbAutoridad.ResumeLayout(False)
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
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
        Friend WithEvents grbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents chkConsentida As System.Windows.Forms.CheckBox
        Friend WithEvents chkCadenaPerpetua As System.Windows.Forms.CheckBox
        Friend WithEvents dtpFecSentencia As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblTextCondena As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents UscComboSala1 As Busqueda.uscComboSala
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents pnlSemicabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents pnlJornadas As System.Windows.Forms.Panel
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCant As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbbAnulacion As APPControls.uscComboParametrica
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
    End Class
End Namespace