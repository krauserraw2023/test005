Namespace Registro.Expediente.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmExpedientePopup3
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpedientePopup3))
            Me.dteExpFechaRecepDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFechaExp = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNumExp = New System.Windows.Forms.TextBox()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.lblMensaje = New System.Windows.Forms.Label()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.pnlDoc = New System.Windows.Forms.Panel()
            Me.gbAutoridad = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlSituaciojur = New System.Windows.Forms.Panel()
            Me.ckbFlagrancia = New System.Windows.Forms.CheckBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbSitJuridica = New APPControls.uscComboParametrica()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.pnlDoc.SuspendLayout()
            Me.gbAutoridad.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlSituaciojur.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlSituaciojur)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlBotones)
            Me.gbxFormChildContainer.Controls.Add(Me.gbAutoridad)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlDoc)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(698, 355)
            '
            'dteExpFechaRecepDoc
            '
            Me.dteExpFechaRecepDoc.Location = New System.Drawing.Point(325, 28)
            Me.dteExpFechaRecepDoc.Name = "dteExpFechaRecepDoc"
            Me.dteExpFechaRecepDoc.Size = New System.Drawing.Size(84, 21)
            Me.dteExpFechaRecepDoc.TabIndex = 5
            Me.dteExpFechaRecepDoc.Value = "/  /"
            Me.dteExpFechaRecepDoc.ValueLong = CType(0, Long)
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(212, 32)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 13)
            Me.Label10.TabIndex = 4
            Me.Label10.Text = "Fecha Recep.  Doc. :"
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(107, 87)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Observación :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpFechaExp
            '
            Me.dtpFechaExp.Location = New System.Drawing.Point(95, 28)
            Me.dtpFechaExp.Name = "dtpFechaExp"
            Me.dtpFechaExp.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaExp.TabIndex = 3
            Me.dtpFechaExp.Value = "/  /"
            Me.dtpFechaExp.ValueLong = CType(0, Long)
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Location = New System.Drawing.Point(1, 33)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(69, 13)
            Me.Label35.TabIndex = 2
            Me.Label35.Text = "Fecha Doc. :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(1, 8)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(93, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Situacion Juridica:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(1, 11)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(74, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Numero Exp. :"
            '
            'txtNumExp
            '
            Me.txtNumExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumExp.Location = New System.Drawing.Point(95, 5)
            Me.txtNumExp.MaxLength = 120
            Me.txtNumExp.Name = "txtNumExp"
            Me.txtNumExp.Size = New System.Drawing.Size(314, 20)
            Me.txtNumExp.TabIndex = 1
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pnlGrabarDatos)
            Me.pnlBotones.Controls.Add(Me.lblMensaje)
            Me.pnlBotones.Controls.Add(Me.pnlSalir)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(0, 266)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(698, 47)
            Me.pnlBotones.TabIndex = 4
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnOk)
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(415, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(186, 47)
            Me.pnlGrabarDatos.TabIndex = 1
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(90, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(94, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblMensaje
            '
            Me.lblMensaje.AutoSize = True
            Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMensaje.ForeColor = System.Drawing.Color.Red
            Me.lblMensaje.Location = New System.Drawing.Point(1, 28)
            Me.lblMensaje.Name = "lblMensaje"
            Me.lblMensaje.Size = New System.Drawing.Size(54, 13)
            Me.lblMensaje.TabIndex = 0
            Me.lblMensaje.Text = "Mensaje"
            Me.lblMensaje.Visible = False
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(601, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(97, 47)
            Me.pnlSalir.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(3, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(90, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label6)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label12)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 16)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(692, 77)
            Me.PnlAutoridadJudicial.TabIndex = 2
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._DropDownWidthAuto = False
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1._visibleBuscar = True
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(92, 6)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(596, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 1
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(409, 55)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(279, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = 0
            Me.UscComboSala1._DropDownWidthAuto = False
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1._Todos = False
            Me.UscComboSala1._TodosMensaje = ""
            Me.UscComboSala1._visibleBuscar = True
            Me.UscComboSala1.Location = New System.Drawing.Point(92, 30)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(600, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(92, 55)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(245, 20)
            Me.txtJuez.TabIndex = 5
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(1, 60)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(65, 13)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "Magistrado :"
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(1, 10)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(341, 59)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(61, 13)
            Me.Label12.TabIndex = 6
            Me.Label12.Text = "Secretario :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(7, 33)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'object_7d3844af_8207_4604_8105_d17e0e4c92f5
            '
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.DropDownWidth = 325
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.FormattingEnabled = True
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.Location = New System.Drawing.Point(0, 0)
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.Name = "object_7d3844af_8207_4604_8105_d17e0e4c92f5"
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.Size = New System.Drawing.Size(176, 21)
            Me.object_7d3844af_8207_4604_8105_d17e0e4c92f5.TabIndex = 2
            '
            'object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed
            '
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed.DropDownWidth = 325
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed.FormattingEnabled = True
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed.Location = New System.Drawing.Point(0, 0)
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed.Name = "object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed"
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed.Size = New System.Drawing.Size(160, 21)
            Me.object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed.TabIndex = 2
            '
            'object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a
            '
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.DropDownWidth = 325
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.FormattingEnabled = True
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.Location = New System.Drawing.Point(0, 0)
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.Name = "object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a"
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.Size = New System.Drawing.Size(282, 21)
            Me.object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a.TabIndex = 0
            '
            'pnlDoc
            '
            Me.pnlDoc.Controls.Add(Me.dteExpFechaRecepDoc)
            Me.pnlDoc.Controls.Add(Me.Label4)
            Me.pnlDoc.Controls.Add(Me.Label10)
            Me.pnlDoc.Controls.Add(Me.txtNumExp)
            Me.pnlDoc.Controls.Add(Me.Label35)
            Me.pnlDoc.Controls.Add(Me.dtpFechaExp)
            Me.pnlDoc.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnlDoc.Location = New System.Drawing.Point(0, 0)
            Me.pnlDoc.Name = "pnlDoc"
            Me.pnlDoc.Size = New System.Drawing.Size(698, 50)
            Me.pnlDoc.TabIndex = 0
            '
            'gbAutoridad
            '
            Me.gbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.gbAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbAutoridad.Location = New System.Drawing.Point(0, 50)
            Me.gbAutoridad.Name = "gbAutoridad"
            Me.gbAutoridad.Size = New System.Drawing.Size(698, 96)
            Me.gbAutoridad.TabIndex = 1
            Me.gbAutoridad.TabStop = False
            Me.gbAutoridad.Text = "Autoridad"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.txtObservacion)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 179)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(698, 87)
            Me.Panel1.TabIndex = 3
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = True
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Right
            Me.txtObservacion.Location = New System.Drawing.Point(95, 0)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(603, 87)
            Me.txtObservacion.TabIndex = 1
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'pnlSituaciojur
            '
            Me.pnlSituaciojur.Controls.Add(Me.ckbFlagrancia)
            Me.pnlSituaciojur.Controls.Add(Me.Label1)
            Me.pnlSituaciojur.Controls.Add(Me.Label5)
            Me.pnlSituaciojur.Controls.Add(Me.cbbSitJuridica)
            Me.pnlSituaciojur.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSituaciojur.Location = New System.Drawing.Point(0, 146)
            Me.pnlSituaciojur.Name = "pnlSituaciojur"
            Me.pnlSituaciojur.Size = New System.Drawing.Size(698, 33)
            Me.pnlSituaciojur.TabIndex = 2
            '
            'ckbFlagrancia
            '
            Me.ckbFlagrancia.AutoSize = True
            Me.ckbFlagrancia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbFlagrancia.Location = New System.Drawing.Point(429, 7)
            Me.ckbFlagrancia.Name = "ckbFlagrancia"
            Me.ckbFlagrancia.Size = New System.Drawing.Size(15, 14)
            Me.ckbFlagrancia.TabIndex = 3
            Me.ckbFlagrancia.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(344, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(86, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Caso flagrancia :"
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
            Me.cbbSitJuridica.CodigoPadre = -1
            Me.cbbSitJuridica.ComboTipo = CType(17, Short)
            Me.cbbSitJuridica.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSitJuridica.DropDownWidth = 325
            Me.cbbSitJuridica.DropDownWidthAuto = False
            Me.cbbSitJuridica.ListaIdsParaExcluir = Nothing
            Me.cbbSitJuridica.Location = New System.Drawing.Point(95, 3)
            Me.cbbSitJuridica.ModuloTratamiento = False
            Me.cbbSitJuridica.Name = "cbbSitJuridica"
            Me.cbbSitJuridica.Parametro1 = -1
            Me.cbbSitJuridica.Parametro2 = -1
            Me.cbbSitJuridica.SelectedIndex = -1
            Me.cbbSitJuridica.SelectedValue = 0
            Me.cbbSitJuridica.Size = New System.Drawing.Size(245, 22)
            Me.cbbSitJuridica.TabIndex = 1
            Me.cbbSitJuridica.verToolTipItemSeleccionado = False
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 313)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(698, 42)
            Me.UscAuditUser1.TabIndex = 4
            '
            'frmExpedientePopup3
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(698, 355)
            Me.Name = "frmExpedientePopup3"
            Me.Text = "Ingreso de Expediente"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlBotones.PerformLayout()
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.pnlDoc.ResumeLayout(False)
            Me.pnlDoc.PerformLayout()
            Me.gbAutoridad.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlSituaciojur.ResumeLayout(False)
            Me.pnlSituaciojur.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dteExpFechaRecepDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaExp As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNumExp As System.Windows.Forms.TextBox
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents lblMensaje As System.Windows.Forms.Label
        Friend WithEvents object_7d3844af_8207_4604_8105_d17e0e4c92f5 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents object_ffe6c8c0_b59d_4cce_b671_d37e5d8822ed As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents cbbSitJuridica As APPControls.uscComboParametrica
        Friend WithEvents object_21d9b9af_0f35_466a_98dd_8eb22a8ba94a As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents pnlDoc As System.Windows.Forms.Panel
        Friend WithEvents gbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlSituaciojur As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents ckbFlagrancia As System.Windows.Forms.CheckBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents UscComboDistritoJudicial1 As APPControls.Busqueda.uscComboDistritoJudicial
    End Class
End Namespace