Namespace Registro.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMovimientoLibertad
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
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSala = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtAutoridadJudicial = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTipoAutoridad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.UscMovExpediente1 = New APPControls.Registro.uscMovExpediente()
            Me.UscDelito1 = New APPControls.Registro.Documento.uscDelito()
            Me.grpMovimiento = New System.Windows.Forms.GroupBox()
            Me.uscMovDet = New APPControls.Registro.uscMovimientoDetalle()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.btnCargarDocumento = New Legolas.APPUIComponents.myButton()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.grpMovimiento.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.grpMovimiento)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(664, 499)
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
            Me.grbCabecera.Controls.Add(Me.Label11)
            Me.grbCabecera.Controls.Add(Me.Label1)
            Me.grbCabecera.Controls.Add(Me.txtSecretario)
            Me.grbCabecera.Controls.Add(Me.txtJuez)
            Me.grbCabecera.Controls.Add(Me.txtSala)
            Me.grbCabecera.Controls.Add(Me.txtAutoridadJudicial)
            Me.grbCabecera.Controls.Add(Me.txtTipoAutoridad)
            Me.grbCabecera.Controls.Add(Me.lblSala)
            Me.grbCabecera.Controls.Add(Me.Label5)
            Me.grbCabecera.Controls.Add(Me.lblDistrito)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Controls.Add(Me.txtNumDocumento)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecRecep)
            Me.grbCabecera.Controls.Add(Me.dtpDocJudFecha)
            Me.grbCabecera.Controls.Add(Me.Label6)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Location = New System.Drawing.Point(3, 3)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(650, 187)
            Me.grbCabecera.TabIndex = 0
            Me.grbCabecera.TabStop = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(330, 98)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 14
            Me.Label11.Text = "Secretario :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 98)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Juez :"
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(416, 96)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.ReadOnly = True
            Me.txtSecretario.Size = New System.Drawing.Size(228, 20)
            Me.txtSecretario.TabIndex = 15
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(107, 96)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.ReadOnly = True
            Me.txtJuez.Size = New System.Drawing.Size(199, 20)
            Me.txtJuez.TabIndex = 13
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSala
            '
            Me.txtSala._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSala._BloquearPaste = False
            Me.txtSala._SeleccionarTodo = False
            Me.txtSala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSala.Location = New System.Drawing.Point(107, 69)
            Me.txtSala.Name = "txtSala"
            Me.txtSala.ReadOnly = True
            Me.txtSala.Size = New System.Drawing.Size(537, 20)
            Me.txtSala.TabIndex = 11
            Me.txtSala.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSala.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtAutoridadJudicial
            '
            Me.txtAutoridadJudicial._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAutoridadJudicial._BloquearPaste = False
            Me.txtAutoridadJudicial._SeleccionarTodo = False
            Me.txtAutoridadJudicial.Location = New System.Drawing.Point(416, 42)
            Me.txtAutoridadJudicial.Name = "txtAutoridadJudicial"
            Me.txtAutoridadJudicial.ReadOnly = True
            Me.txtAutoridadJudicial.Size = New System.Drawing.Size(228, 20)
            Me.txtAutoridadJudicial.TabIndex = 9
            Me.txtAutoridadJudicial.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtAutoridadJudicial.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtTipoAutoridad
            '
            Me.txtTipoAutoridad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoAutoridad._BloquearPaste = False
            Me.txtTipoAutoridad._SeleccionarTodo = False
            Me.txtTipoAutoridad.Location = New System.Drawing.Point(107, 42)
            Me.txtTipoAutoridad.Name = "txtTipoAutoridad"
            Me.txtTipoAutoridad.ReadOnly = True
            Me.txtTipoAutoridad.Size = New System.Drawing.Size(199, 20)
            Me.txtTipoAutoridad.TabIndex = 7
            Me.txtTipoAutoridad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTipoAutoridad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(6, 71)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 10
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 45)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(93, 13)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Tipo de autoridad:"
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(330, 45)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 8
            Me.lblDistrito.Text = "Distrito Judicial :"
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
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(107, 16)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.ReadOnly = True
            Me.txtNumDocumento.Size = New System.Drawing.Size(199, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Enabled = False
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(561, 15)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Enabled = False
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
            'UscMovExpediente1
            '
            Me.UscMovExpediente1._CargarExpedientes = False
            Me.UscMovExpediente1._DocumentoJudicialID = -1
            Me.UscMovExpediente1._ExpedienteID = -1
            Me.UscMovExpediente1._GrillaExpId = -1
            Me.UscMovExpediente1._IngresoID = -1
            Me.UscMovExpediente1._InternoID = -1
            Me.UscMovExpediente1._InternoIngresoInpeId = -1
            Me.UscMovExpediente1._ListaCopy = Nothing
            Me.UscMovExpediente1._ListaExpedienteId = Nothing
            Me.UscMovExpediente1._ListaExpedienteOKID = Nothing
            Me.UscMovExpediente1._ListaExpedienteTotalID = Nothing
            Me.UscMovExpediente1._ListaExpNoEliminados = Nothing
            Me.UscMovExpediente1._ListaExpOK_IN = Nothing
            Me.UscMovExpediente1._ListaExpOK_OUT = Nothing
            Me.UscMovExpediente1._MovimientoID = -1
            Me.UscMovExpediente1._MovimientoTipoID = -1
            Me.UscMovExpediente1._RetornaOKEliminado = False
            Me.UscMovExpediente1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscMovExpediente1._TipoListado = ""
            Me.UscMovExpediente1._VisibleColumna = False
            Me.UscMovExpediente1._VisibleGrabar = False
            Me.UscMovExpediente1.AutoScroll = True
            Me.UscMovExpediente1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscMovExpediente1.GrillaCountExp = 0
            Me.UscMovExpediente1.Location = New System.Drawing.Point(3, 3)
            Me.UscMovExpediente1.Name = "UscMovExpediente1"
            Me.UscMovExpediente1.Size = New System.Drawing.Size(650, 88)
            Me.UscMovExpediente1.TabIndex = 46
            '
            'UscDelito1
            '
            Me.UscDelito1._ExpedienteID = -1
            Me.UscDelito1._IngresoID = -1
            Me.UscDelito1._IngresoInpeId = -1
            Me.UscDelito1._InternoID = -1
            Me.UscDelito1._TipoDocumentoID = -1
            Me.UscDelito1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscDelito1._TipoMovimineto = -1
            Me.UscDelito1.AutoScroll = True
            Me.UscDelito1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscDelito1.Location = New System.Drawing.Point(3, 91)
            Me.UscDelito1.Name = "UscDelito1"
            Me.UscDelito1.Size = New System.Drawing.Size(650, 99)
            Me.UscDelito1.TabIndex = 47
            '
            'grpMovimiento
            '
            Me.grpMovimiento.Controls.Add(Me.uscMovDet)
            Me.grpMovimiento.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grpMovimiento.Name = "grpMovimiento"
            Me.grpMovimiento.Size = New System.Drawing.Size(664, 185)
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
            Me.uscMovDet._Documentos_sin_mov = False
            Me.uscMovDet._DocumJudicialD = -1
            Me.uscMovDet._FechaMovimiento = CType(0, Long)
            Me.uscMovDet._IngresoID = -1
            Me.uscMovDet._intCondicionGrupo = -1
            Me.uscMovDet._InternoID = -1
            Me.uscMovDet._InternoIngresoInpeId = -1
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
            Me.uscMovDet._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscMovDet.BackColor = System.Drawing.Color.Transparent
            Me.uscMovDet.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMovDet.Enabletcontrol = False
            Me.uscMovDet.EstadoAuxID = 0
            Me.uscMovDet.EstadoID = -1
            Me.uscMovDet.EstadoTramite = ""
            Me.uscMovDet.EstadoTramiteID = -1
            Me.uscMovDet.Location = New System.Drawing.Point(3, 16)
            Me.uscMovDet.MovimientoGrupo = 0
            Me.uscMovDet.MovimientoGrupoNom = ""
            Me.uscMovDet.MovimientoMotivoIngreso = 0
            Me.uscMovDet.MovimientoTipo = 0
            Me.uscMovDet.Name = "uscMovDet"
            Me.uscMovDet.Observacion = ""
            Me.uscMovDet.Size = New System.Drawing.Size(658, 166)
            Me.uscMovDet.TabIndex = 0
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Location = New System.Drawing.Point(0, 409)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(664, 45)
            Me.PnlInferior.TabIndex = 101
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(464, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(200, 45)
            Me.PnlBotones.TabIndex = 1
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 454)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(664, 45)
            Me.UscAuditUser1.TabIndex = 0
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New System.Drawing.Point(0, 189)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(664, 219)
            Me.TabControl1.TabIndex = 1
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.grbCabecera)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(656, 193)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Datos del documento"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.UscDelito1)
            Me.TabPage2.Controls.Add(Me.UscMovExpediente1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(656, 193)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Datos del Expediente"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'btnCargarDocumento
            '
            Me.btnCargarDocumento.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnCargarDocumento.Location = New System.Drawing.Point(230, 187)
            Me.btnCargarDocumento.Name = "btnCargarDocumento"
            Me.btnCargarDocumento.Size = New System.Drawing.Size(22, 22)
            Me.btnCargarDocumento.TabIndex = 8
            Me.btnCargarDocumento.UseVisualStyleBackColor = True
            '
            'frmMovimientoLibertad
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(664, 499)
            Me.Controls.Add(Me.btnCargarDocumento)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoLibertad"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Libertad"
            Me.Controls.SetChildIndex(Me.gbxFormChildContainer, 0)
            Me.Controls.SetChildIndex(Me.btnCargarDocumento, 0)
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.grpMovimiento.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents uscMovDet As APPControls.Registro.uscMovimientoDetalle
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents UscMovExpediente1 As APPControls.Registro.uscMovExpediente
        Friend WithEvents UscDelito1 As APPControls.Registro.Documento.uscDelito
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtAutoridadJudicial As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSala As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtTipoAutoridad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents btnCargarDocumento As Legolas.APPUIComponents.myButton
    End Class
End Namespace

