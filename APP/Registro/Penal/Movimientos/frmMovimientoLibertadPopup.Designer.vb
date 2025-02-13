Namespace Registro.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMovimientoLibertadPoput
        Inherits Legolas.APPUIComponents.FormPopup

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.gbAutoridad = New System.Windows.Forms.GroupBox()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.PnlTipoAutoridad = New System.Windows.Forms.Panel()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.grpMovimiento = New System.Windows.Forms.GroupBox()
            Me.uscMovDet = New APPControls.Registro.uscMovimientoDetalle()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.gbAutoridad.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.PnlTipoAutoridad.SuspendLayout()
            Me.grpMovimiento.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.grpMovimiento)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(661, 456)
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(98, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 20
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(93, 40)
            Me.btnAceptar.TabIndex = 19
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.gbAutoridad)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Controls.Add(Me.txtNumDocumento)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecRecep)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecha)
            Me.grbCabecera.Controls.Add(Me.Label6)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Location = New System.Drawing.Point(3, 3)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(650, 137)
            Me.grbCabecera.TabIndex = 0
            Me.grbCabecera.TabStop = False
            '
            'gbAutoridad
            '
            Me.gbAutoridad.Controls.Add(Me.PnlOtraAutoridad)
            Me.gbAutoridad.Controls.Add(Me.PnlAutoridadJudicial)
            Me.gbAutoridad.Controls.Add(Me.PnlTipoAutoridad)
            Me.gbAutoridad.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbAutoridad.Location = New System.Drawing.Point(3, 41)
            Me.gbAutoridad.Name = "gbAutoridad"
            Me.gbAutoridad.Size = New System.Drawing.Size(644, 93)
            Me.gbAutoridad.TabIndex = 16
            Me.gbAutoridad.TabStop = False
            Me.gbAutoridad.Text = "Autoridad"
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label7)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label8)
            Me.PnlOtraAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(3, 91)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(638, 51)
            Me.PnlOtraAutoridad.TabIndex = 2
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(101, 4)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(510, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(1, 29)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(89, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Cargo Autoridad :"
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(101, 28)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(510, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(1, 7)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(98, 13)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "Nombre Autoridad :"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label2)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label3)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.cbbDistritoJud)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label4)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label9)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 40)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(638, 51)
            Me.PnlAutoridadJudicial.TabIndex = 2
            '
            'txtSecretario
            '
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(380, 28)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(254, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = 0
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1.Location = New System.Drawing.Point(380, 3)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(231, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(300, 33)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(61, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Secretario :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(300, 8)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(70, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Aut. Judicial :"
            '
            'txtJuez
            '
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(101, 28)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(199, 20)
            Me.txtJuez.TabIndex = 5
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
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
            Me.cbbDistritoJud.Location = New System.Drawing.Point(101, 4)
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(199, 22)
            Me.cbbDistritoJud.TabIndex = 1
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(1, 33)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(35, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Juez :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(1, 8)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(83, 13)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "Distrito Judicial :"
            '
            'PnlTipoAutoridad
            '
            Me.PnlTipoAutoridad.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlTipoAutoridad.Controls.Add(Me.Label10)
            Me.PnlTipoAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlTipoAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlTipoAutoridad.Location = New System.Drawing.Point(3, 16)
            Me.PnlTipoAutoridad.Name = "PnlTipoAutoridad"
            Me.PnlTipoAutoridad.Size = New System.Drawing.Size(638, 24)
            Me.PnlTipoAutoridad.TabIndex = 1
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
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(101, 1)
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(199, 22)
            Me.cbbTipoAutJud.TabIndex = 1
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(1, 4)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(93, 13)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "Tipo de autoridad:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(6, 19)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(107, 16)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(199, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(561, 15)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(416, 15)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(331, 19)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Fec. Doc. :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(498, 19)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recep. :"
            '
            'grpMovimiento
            '
            Me.grpMovimiento.Controls.Add(Me.uscMovDet)
            Me.grpMovimiento.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grpMovimiento.Name = "grpMovimiento"
            Me.grpMovimiento.Size = New System.Drawing.Size(661, 185)
            Me.grpMovimiento.TabIndex = 0
            Me.grpMovimiento.TabStop = False
            Me.grpMovimiento.Text = "Movimiento"
            '
            'uscMovDet
            '
            Me.uscMovDet._blnNuevo = False
            Me.uscMovDet._blnVisiblecbbMotivo = True
            Me.uscMovDet._blnVisiblelblMotivo = True
            Me.uscMovDet._blnVisibleOrigenDestino = True
            Me.uscMovDet._CargarExpedientes = -1
            Me.uscMovDet._Codigo = 0
            Me.uscMovDet._DocumJudicialD = -1
            Me.uscMovDet._FechaMovimiento = CType(0, Long)
            Me.uscMovDet._IngresoID = -1
            Me.uscMovDet._intCondicionGrupo = -1
            Me.uscMovDet._InternoID = -1
            Me.uscMovDet._MovimientoTipoID = -1
            Me.uscMovDet._PenalDestinoID = -1
            Me.uscMovDet._PenalID = 0
            Me.uscMovDet._PenalID1 = -1
            Me.uscMovDet._PenalID2 = -1
            Me.uscMovDet._PenalMovID = 0
            Me.uscMovDet._PenalOrigenID = -1
            Me.uscMovDet._RegionDestinoID = -1
            Me.uscMovDet._RegionID = 0
            Me.uscMovDet._RegionMovID = 0
            Me.uscMovDet._RegionOrigenID = -1
            Me.uscMovDet.BackColor = System.Drawing.Color.Transparent
            Me.uscMovDet.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMovDet.Enabletcontrol = False
            Me.uscMovDet.EstadoID = 1
            Me.uscMovDet.EstadoTramite = ""
            'Me.uscMovDet.EstadoTramiteID = -1
            Me.uscMovDet.Location = New System.Drawing.Point(3, 16)
            Me.uscMovDet.MovimientoGrupo = 0
            Me.uscMovDet.MovimientoGrupoNom = ""
            Me.uscMovDet.MovimientoTipo = 0
            Me.uscMovDet.Name = "uscMovDet"
            Me.uscMovDet.Size = New System.Drawing.Size(655, 166)
            Me.uscMovDet.TabIndex = 0
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Location = New System.Drawing.Point(0, 360)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(664, 50)
            Me.PnlInferior.TabIndex = 101
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(464, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(200, 50)
            Me.PnlBotones.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Location = New System.Drawing.Point(0, 189)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(664, 169)
            Me.TabControl1.TabIndex = 1
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.grbCabecera)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(656, 143)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Datos del documento"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 411)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(661, 45)
            Me.UscAuditUser1.TabIndex = 2
            '
            'frmMovimientoLibertadPoput
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(661, 456)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoLibertadPoput"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Libertad"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.gbAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.PnlTipoAutoridad.ResumeLayout(False)
            Me.PnlTipoAutoridad.PerformLayout()
            Me.grpMovimiento.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents uscMovDet As APPControls.Registro.uscMovimientoDetalle
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents gbAutoridad As System.Windows.Forms.GroupBox
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents PnlTipoAutoridad As System.Windows.Forms.Panel
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents Label10 As System.Windows.Forms.Label

    End Class
End Namespace

