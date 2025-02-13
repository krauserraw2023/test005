Namespace Registro.ConstanciaReclusion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmTramite
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.pnlCabeceraInterno = New System.Windows.Forms.Panel()
            Me.txtInterno = New System.Windows.Forms.TextBox()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtRegionPenal = New System.Windows.Forms.TextBox()
            Me.txtCodigoRP = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlTramite = New System.Windows.Forms.Panel()
            Me.grbTramite = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtNumeroTramite = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtEstado = New System.Windows.Forms.TextBox()
            Me.grbConstancia = New System.Windows.Forms.GroupBox()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNumeroCR = New System.Windows.Forms.TextBox()
            Me.txtFechaExp = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.dtpFechaRecepEP = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFechaRecepRP = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.pnlVerInterno = New System.Windows.Forms.Panel()
            Me.btnDetalleInterno = New System.Windows.Forms.Button()
            Me.pnlImprimir = New System.Windows.Forms.Panel()
            Me.btnImpresion = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnExpedir = New System.Windows.Forms.Button()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.grpDatosSolicitante = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTipoTramite = New System.Windows.Forms.TextBox()
            Me.cbbTipSolicitante = New APPControls.uscComboParametrica()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.grbDocReferencia = New System.Windows.Forms.GroupBox()
            Me.pnlNumeroRef = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.txtNumDocRef = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlSerie = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtSerRecibo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblNumero = New System.Windows.Forms.Label()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.dtpFechaRef = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.cbbTipoDocumentoRef = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.grpObs = New System.Windows.Forms.GroupBox()
            Me.txtobs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grbAnulacion = New System.Windows.Forms.GroupBox()
            Me.txtobs_anulacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlCuerpo = New System.Windows.Forms.Panel()
            Me.pnlObsAnu = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.grpDatosExpediente = New System.Windows.Forms.GroupBox()
            Me.txtNumExp = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtFechaIEP = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaISP = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscComboDistritoJudicial2 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtExpSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.UscComboSala2 = New APPControls.Busqueda.uscComboSala()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.txtDelitoNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlBotonesDelitos = New System.Windows.Forms.Panel()
            Me.btnAddDelito = New System.Windows.Forms.Button()
            Me.btnEliminarDelito = New System.Windows.Forms.Button()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.gbPoderJudicial = New System.Windows.Forms.GroupBox()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlCabeceraInterno.SuspendLayout()
            Me.pnlTramite.SuspendLayout()
            Me.grbTramite.SuspendLayout()
            Me.grbConstancia.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlVerInterno.SuspendLayout()
            Me.pnlImprimir.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grpDatosSolicitante.SuspendLayout()
            Me.grbDocReferencia.SuspendLayout()
            Me.pnlNumeroRef.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlSerie.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.grpObs.SuspendLayout()
            Me.grbAnulacion.SuspendLayout()
            Me.pnlCuerpo.SuspendLayout()
            Me.pnlObsAnu.SuspendLayout()
            Me.grpDatosExpediente.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.pnlBotonesDelitos.SuspendLayout()
            Me.gbPoderJudicial.SuspendLayout()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCuerpo)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTramite)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCabeceraInterno)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(879, 581)
            '
            'pnlCabeceraInterno
            '
            Me.pnlCabeceraInterno.BackColor = System.Drawing.Color.Transparent
            Me.pnlCabeceraInterno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlCabeceraInterno.Controls.Add(Me.txtInterno)
            Me.pnlCabeceraInterno.Controls.Add(Me.Label34)
            Me.pnlCabeceraInterno.Controls.Add(Me.Label12)
            Me.pnlCabeceraInterno.Controls.Add(Me.txtRegionPenal)
            Me.pnlCabeceraInterno.Controls.Add(Me.txtCodigoRP)
            Me.pnlCabeceraInterno.Controls.Add(Me.Label4)
            Me.pnlCabeceraInterno.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabeceraInterno.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabeceraInterno.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.pnlCabeceraInterno.Name = "pnlCabeceraInterno"
            Me.pnlCabeceraInterno.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.pnlCabeceraInterno.Size = New System.Drawing.Size(879, 33)
            Me.pnlCabeceraInterno.TabIndex = 1
            '
            'txtInterno
            '
            Me.txtInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtInterno.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtInterno.Location = New System.Drawing.Point(183, 5)
            Me.txtInterno.MaxLength = 120
            Me.txtInterno.Name = "txtInterno"
            Me.txtInterno.ReadOnly = True
            Me.txtInterno.Size = New System.Drawing.Size(327, 20)
            Me.txtInterno.TabIndex = 3
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Dock = System.Windows.Forms.DockStyle.Right
            Me.Label34.Location = New System.Drawing.Point(510, 5)
            Me.Label34.Name = "Label34"
            Me.Label34.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
            Me.Label34.Size = New System.Drawing.Size(113, 16)
            Me.Label34.TabIndex = 2
            Me.Label34.Text = "Oficina Regional/E.P. "
            '
            'Label12
            '
            Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label12.Location = New System.Drawing.Point(137, 5)
            Me.Label12.Name = "Label12"
            Me.Label12.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
            Me.Label12.Size = New System.Drawing.Size(46, 24)
            Me.Label12.TabIndex = 59
            Me.Label12.Text = "Interno :"
            '
            'txtRegionPenal
            '
            Me.txtRegionPenal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRegionPenal.Dock = System.Windows.Forms.DockStyle.Right
            Me.txtRegionPenal.Location = New System.Drawing.Point(623, 5)
            Me.txtRegionPenal.MaxLength = 120
            Me.txtRegionPenal.Name = "txtRegionPenal"
            Me.txtRegionPenal.ReadOnly = True
            Me.txtRegionPenal.Size = New System.Drawing.Size(252, 20)
            Me.txtRegionPenal.TabIndex = 4
            '
            'txtCodigoRP
            '
            Me.txtCodigoRP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoRP.Dock = System.Windows.Forms.DockStyle.Left
            Me.txtCodigoRP.Location = New System.Drawing.Point(49, 5)
            Me.txtCodigoRP.MaxLength = 120
            Me.txtCodigoRP.Name = "txtCodigoRP"
            Me.txtCodigoRP.ReadOnly = True
            Me.txtCodigoRP.Size = New System.Drawing.Size(88, 20)
            Me.txtCodigoRP.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label4.Location = New System.Drawing.Point(0, 5)
            Me.Label4.Name = "Label4"
            Me.Label4.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
            Me.Label4.Size = New System.Drawing.Size(49, 24)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Codigo :"
            '
            'pnlTramite
            '
            Me.pnlTramite.BackColor = System.Drawing.Color.Transparent
            Me.pnlTramite.Controls.Add(Me.grbTramite)
            Me.pnlTramite.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTramite.Location = New System.Drawing.Point(0, 33)
            Me.pnlTramite.Name = "pnlTramite"
            Me.pnlTramite.Size = New System.Drawing.Size(879, 47)
            Me.pnlTramite.TabIndex = 5
            '
            'grbTramite
            '
            Me.grbTramite.Controls.Add(Me.Label10)
            Me.grbTramite.Controls.Add(Me.txtNumeroTramite)
            Me.grbTramite.Controls.Add(Me.Label7)
            Me.grbTramite.Controls.Add(Me.txtEstado)
            Me.grbTramite.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbTramite.Location = New System.Drawing.Point(0, 0)
            Me.grbTramite.Name = "grbTramite"
            Me.grbTramite.Size = New System.Drawing.Size(879, 47)
            Me.grbTramite.TabIndex = 6
            Me.grbTramite.TabStop = False
            Me.grbTramite.Text = "Tramite"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Location = New System.Drawing.Point(12, 25)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(81, 13)
            Me.Label10.TabIndex = 37
            Me.Label10.Text = "N°. de Trámite :"
            '
            'txtNumeroTramite
            '
            Me.txtNumeroTramite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroTramite.Location = New System.Drawing.Point(108, 21)
            Me.txtNumeroTramite.MaxLength = 120
            Me.txtNumeroTramite.Name = "txtNumeroTramite"
            Me.txtNumeroTramite.ReadOnly = True
            Me.txtNumeroTramite.Size = New System.Drawing.Size(100, 20)
            Me.txtNumeroTramite.TabIndex = 7
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(224, 25)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(99, 13)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Estado de Trámite: "
            '
            'txtEstado
            '
            Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtEstado.Location = New System.Drawing.Point(323, 21)
            Me.txtEstado.MaxLength = 120
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(100, 20)
            Me.txtEstado.TabIndex = 8
            Me.txtEstado.Text = "PENDIENTE"
            '
            'grbConstancia
            '
            Me.grbConstancia.Controls.Add(Me.txtUsuario)
            Me.grbConstancia.Controls.Add(Me.Label1)
            Me.grbConstancia.Controls.Add(Me.Label11)
            Me.grbConstancia.Controls.Add(Me.txtNumeroCR)
            Me.grbConstancia.Controls.Add(Me.txtFechaExp)
            Me.grbConstancia.Controls.Add(Me.Label13)
            Me.grbConstancia.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.grbConstancia.Location = New System.Drawing.Point(0, 351)
            Me.grbConstancia.Name = "grbConstancia"
            Me.grbConstancia.Size = New System.Drawing.Size(879, 57)
            Me.grbConstancia.TabIndex = 9
            Me.grbConstancia.TabStop = False
            Me.grbConstancia.Text = "Datos de la Constancia de Reclusión"
            '
            'txtUsuario
            '
            Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUsuario.Location = New System.Drawing.Point(568, 21)
            Me.txtUsuario.MaxLength = 120
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.ReadOnly = True
            Me.txtUsuario.Size = New System.Drawing.Size(298, 20)
            Me.txtUsuario.TabIndex = 12
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(464, 25)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 13)
            Me.Label1.TabIndex = 116
            Me.Label1.Text = "Usuario expedición:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Location = New System.Drawing.Point(10, 25)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(93, 13)
            Me.Label11.TabIndex = 109
            Me.Label11.Text = "N° de Constancia:"
            '
            'txtNumeroCR
            '
            Me.txtNumeroCR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCR.Location = New System.Drawing.Point(111, 21)
            Me.txtNumeroCR.MaxLength = 120
            Me.txtNumeroCR.Name = "txtNumeroCR"
            Me.txtNumeroCR.ReadOnly = True
            Me.txtNumeroCR.Size = New System.Drawing.Size(100, 20)
            Me.txtNumeroCR.TabIndex = 10
            '
            'txtFechaExp
            '
            Me.txtFechaExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaExp.Location = New System.Drawing.Point(334, 21)
            Me.txtFechaExp.MaxLength = 120
            Me.txtFechaExp.Name = "txtFechaExp"
            Me.txtFechaExp.ReadOnly = True
            Me.txtFechaExp.Size = New System.Drawing.Size(121, 20)
            Me.txtFechaExp.TabIndex = 11
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.Location = New System.Drawing.Point(221, 25)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(109, 13)
            Me.Label13.TabIndex = 1
            Me.Label13.Text = "Fecha de expedición:"
            '
            'dtpFechaRecepEP
            '
            Me.dtpFechaRecepEP.Location = New System.Drawing.Point(204, 10)
            Me.dtpFechaRecepEP.Name = "dtpFechaRecepEP"
            Me.dtpFechaRecepEP.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRecepEP.TabIndex = 27
            Me.dtpFechaRecepEP.Value = "/  /"
            Me.dtpFechaRecepEP.ValueLong = CType(0, Long)
            '
            'dtpFechaRecepRP
            '
            Me.dtpFechaRecepRP.Location = New System.Drawing.Point(204, 35)
            Me.dtpFechaRecepRP.Name = "dtpFechaRecepRP"
            Me.dtpFechaRecepRP.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRecepRP.TabIndex = 28
            Me.dtpFechaRecepRP.Value = "/  /"
            Me.dtpFechaRecepRP.ValueLong = CType(0, Long)
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Location = New System.Drawing.Point(16, 40)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(155, 13)
            Me.Label9.TabIndex = 35
            Me.Label9.Text = "Fecha de recepción en el RP. :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Location = New System.Drawing.Point(16, 16)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(154, 13)
            Me.Label8.TabIndex = 34
            Me.Label8.Text = "Fecha de recepción en el EP. :"
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.pnlVerInterno)
            Me.PnlBotones.Controls.Add(Me.pnlImprimir)
            Me.PnlBotones.Controls.Add(Me.pnlEliminar)
            Me.PnlBotones.Controls.Add(Me.pnlModificar)
            Me.PnlBotones.Controls.Add(Me.Panel1)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 488)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(879, 51)
            Me.PnlBotones.TabIndex = 44
            '
            'pnlVerInterno
            '
            Me.pnlVerInterno.Controls.Add(Me.btnDetalleInterno)
            Me.pnlVerInterno.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlVerInterno.Location = New System.Drawing.Point(436, 0)
            Me.pnlVerInterno.Name = "pnlVerInterno"
            Me.pnlVerInterno.Size = New System.Drawing.Size(110, 51)
            Me.pnlVerInterno.TabIndex = 52
            '
            'btnDetalleInterno
            '
            Me.btnDetalleInterno.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnDetalleInterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDetalleInterno.Location = New System.Drawing.Point(2, 5)
            Me.btnDetalleInterno.Name = "btnDetalleInterno"
            Me.btnDetalleInterno.Size = New System.Drawing.Size(105, 40)
            Me.btnDetalleInterno.TabIndex = 53
            Me.btnDetalleInterno.Text = "Ver Interno"
            Me.btnDetalleInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnDetalleInterno.UseVisualStyleBackColor = True
            '
            'pnlImprimir
            '
            Me.pnlImprimir.Controls.Add(Me.btnImpresion)
            Me.pnlImprimir.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlImprimir.Location = New System.Drawing.Point(324, 0)
            Me.pnlImprimir.Name = "pnlImprimir"
            Me.pnlImprimir.Size = New System.Drawing.Size(112, 51)
            Me.pnlImprimir.TabIndex = 50
            '
            'btnImpresion
            '
            Me.btnImpresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImpresion.Image = Global.SIPPOPE.My.Resources.Resources.printer3
            Me.btnImpresion.Location = New System.Drawing.Point(3, 5)
            Me.btnImpresion.Name = "btnImpresion"
            Me.btnImpresion.Size = New System.Drawing.Size(105, 40)
            Me.btnImpresion.TabIndex = 51
            Me.btnImpresion.Text = "&Imprimir"
            Me.btnImpresion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(217, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(107, 51)
            Me.pnlEliminar.TabIndex = 48
            '
            'btnEliminar
            '
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(1, 5)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(100, 40)
            Me.btnEliminar.TabIndex = 49
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnExpedir)
            Me.pnlModificar.Controls.Add(Me.btnAnular)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(217, 51)
            Me.pnlModificar.TabIndex = 45
            '
            'btnExpedir
            '
            Me.btnExpedir.BackColor = System.Drawing.Color.Transparent
            Me.btnExpedir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExpedir.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnExpedir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExpedir.Location = New System.Drawing.Point(108, 5)
            Me.btnExpedir.Name = "btnExpedir"
            Me.btnExpedir.Size = New System.Drawing.Size(105, 39)
            Me.btnExpedir.TabIndex = 47
            Me.btnExpedir.Text = "&Expedir CR"
            Me.btnExpedir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExpedir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExpedir.UseVisualStyleBackColor = False
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnAnular.Location = New System.Drawing.Point(5, 5)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(100, 40)
            Me.btnAnular.TabIndex = 46
            Me.btnAnular.Text = "Anular"
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(662, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(217, 51)
            Me.Panel1.TabIndex = 54
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnAceptar.Location = New System.Drawing.Point(8, 5)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(94, 40)
            Me.btnAceptar.TabIndex = 55
            Me.btnAceptar.Text = "&Grabar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(108, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 56
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grpDatosSolicitante
            '
            Me.grpDatosSolicitante.Controls.Add(Me.Label3)
            Me.grpDatosSolicitante.Controls.Add(Me.txtTipoTramite)
            Me.grpDatosSolicitante.Controls.Add(Me.cbbTipSolicitante)
            Me.grpDatosSolicitante.Controls.Add(Me.Label5)
            Me.grpDatosSolicitante.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpDatosSolicitante.Location = New System.Drawing.Point(0, 0)
            Me.grpDatosSolicitante.Name = "grpDatosSolicitante"
            Me.grpDatosSolicitante.Size = New System.Drawing.Size(879, 43)
            Me.grpDatosSolicitante.TabIndex = 13
            Me.grpDatosSolicitante.TabStop = False
            Me.grpDatosSolicitante.Text = "Datos de la Solicitud"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(462, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(68, 13)
            Me.Label3.TabIndex = 110
            Me.Label3.Text = "Tipo tramite: "
            '
            'txtTipoTramite
            '
            Me.txtTipoTramite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoTramite.Location = New System.Drawing.Point(554, 19)
            Me.txtTipoTramite.MaxLength = 120
            Me.txtTipoTramite.Name = "txtTipoTramite"
            Me.txtTipoTramite.ReadOnly = True
            Me.txtTipoTramite.Size = New System.Drawing.Size(312, 20)
            Me.txtTipoTramite.TabIndex = 15
            '
            'cbbTipSolicitante
            '
            Me.cbbTipSolicitante._NoIndica = False
            Me.cbbTipSolicitante._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipSolicitante._Todos = False
            Me.cbbTipSolicitante._TodosMensaje = ""
            Me.cbbTipSolicitante._Visible_Add = False
            Me.cbbTipSolicitante._Visible_Buscar = False
            Me.cbbTipSolicitante._Visible_Eliminar = False
            Me.cbbTipSolicitante.CodigoPadre = -1
            Me.cbbTipSolicitante.ComboTipo = CType(17, Short)
            Me.cbbTipSolicitante.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipSolicitante.DropDownWidth = 325
            Me.cbbTipSolicitante.DropDownWidthAuto = False
            Me.cbbTipSolicitante.ListaIdsParaExcluir = Nothing
            Me.cbbTipSolicitante.Location = New System.Drawing.Point(108, 19)
            Me.cbbTipSolicitante.ModuloTratamiento = False
            Me.cbbTipSolicitante.Name = "cbbTipSolicitante"
            Me.cbbTipSolicitante.Parametro1 = -1
            Me.cbbTipSolicitante.Parametro2 = -1
            Me.cbbTipSolicitante.SelectedIndex = -1
            Me.cbbTipSolicitante.SelectedValue = 0
            Me.cbbTipSolicitante.Size = New System.Drawing.Size(315, 22)
            Me.cbbTipSolicitante.TabIndex = 14
            Me.cbbTipSolicitante.verToolTipItemSeleccionado = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(15, 22)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(62, 13)
            Me.Label5.TabIndex = 43
            Me.Label5.Text = "Solicitante: "
            '
            'grbDocReferencia
            '
            Me.grbDocReferencia.BackColor = System.Drawing.Color.Transparent
            Me.grbDocReferencia.Controls.Add(Me.pnlNumeroRef)
            Me.grbDocReferencia.Controls.Add(Me.Panel3)
            Me.grbDocReferencia.Controls.Add(Me.Panel2)
            Me.grbDocReferencia.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbDocReferencia.Location = New System.Drawing.Point(0, 113)
            Me.grbDocReferencia.Name = "grbDocReferencia"
            Me.grbDocReferencia.Size = New System.Drawing.Size(879, 97)
            Me.grbDocReferencia.TabIndex = 19
            Me.grbDocReferencia.TabStop = False
            Me.grbDocReferencia.Text = "Documento Referencia"
            '
            'pnlNumeroRef
            '
            Me.pnlNumeroRef.BackColor = System.Drawing.Color.Transparent
            Me.pnlNumeroRef.Controls.Add(Me.Panel4)
            Me.pnlNumeroRef.Controls.Add(Me.lblNumero)
            Me.pnlNumeroRef.Controls.Add(Me.lblFecha)
            Me.pnlNumeroRef.Controls.Add(Me.dtpFechaRef)
            Me.pnlNumeroRef.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlNumeroRef.Location = New System.Drawing.Point(3, 44)
            Me.pnlNumeroRef.Name = "pnlNumeroRef"
            Me.pnlNumeroRef.Size = New System.Drawing.Size(443, 50)
            Me.pnlNumeroRef.TabIndex = 22
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.txtNumDocRef)
            Me.Panel4.Controls.Add(Me.pnlSerie)
            Me.Panel4.Location = New System.Drawing.Point(105, 2)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(315, 22)
            Me.Panel4.TabIndex = 18
            '
            'txtNumDocRef
            '
            Me.txtNumDocRef._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocRef._BloquearPaste = False
            Me.txtNumDocRef._SeleccionarTodo = False
            Me.txtNumDocRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumDocRef.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtNumDocRef.Location = New System.Drawing.Point(44, 0)
            Me.txtNumDocRef.MaxLength = 20
            Me.txtNumDocRef.Name = "txtNumDocRef"
            Me.txtNumDocRef.Size = New System.Drawing.Size(271, 20)
            Me.txtNumDocRef.TabIndex = 24
            Me.txtNumDocRef.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDocRef.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlSerie
            '
            Me.pnlSerie.Controls.Add(Me.Label6)
            Me.pnlSerie.Controls.Add(Me.txtSerRecibo)
            Me.pnlSerie.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSerie.Location = New System.Drawing.Point(0, 0)
            Me.pnlSerie.Name = "pnlSerie"
            Me.pnlSerie.Size = New System.Drawing.Size(44, 22)
            Me.pnlSerie.TabIndex = 18
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label6.Location = New System.Drawing.Point(31, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(13, 22)
            Me.Label6.TabIndex = 17
            Me.Label6.Text = "-"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtSerRecibo
            '
            Me.txtSerRecibo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSerRecibo._BloquearPaste = False
            Me.txtSerRecibo._SeleccionarTodo = False
            Me.txtSerRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSerRecibo.Dock = System.Windows.Forms.DockStyle.Left
            Me.txtSerRecibo.Location = New System.Drawing.Point(0, 0)
            Me.txtSerRecibo.MaxLength = 3
            Me.txtSerRecibo.Name = "txtSerRecibo"
            Me.txtSerRecibo.Size = New System.Drawing.Size(31, 20)
            Me.txtSerRecibo.TabIndex = 23
            Me.txtSerRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtSerRecibo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSerRecibo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'lblNumero
            '
            Me.lblNumero.AutoSize = True
            Me.lblNumero.BackColor = System.Drawing.Color.Transparent
            Me.lblNumero.Location = New System.Drawing.Point(12, 8)
            Me.lblNumero.Name = "lblNumero"
            Me.lblNumero.Size = New System.Drawing.Size(86, 13)
            Me.lblNumero.TabIndex = 15
            Me.lblNumero.Text = "N° Serie-Recibo:"
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.BackColor = System.Drawing.Color.Transparent
            Me.lblFecha.Location = New System.Drawing.Point(12, 31)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(82, 13)
            Me.lblFecha.TabIndex = 17
            Me.lblFecha.Text = "Fecha de pago:"
            '
            'dtpFechaRef
            '
            Me.dtpFechaRef.Location = New System.Drawing.Point(105, 27)
            Me.dtpFechaRef.Name = "dtpFechaRef"
            Me.dtpFechaRef.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRef.TabIndex = 25
            Me.dtpFechaRef.Value = "/  /"
            Me.dtpFechaRef.ValueLong = CType(0, Long)
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.cbbTipoDocumentoRef)
            Me.Panel3.Controls.Add(Me.Label2)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(443, 28)
            Me.Panel3.TabIndex = 20
            '
            'cbbTipoDocumentoRef
            '
            Me.cbbTipoDocumentoRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipoDocumentoRef.FormattingEnabled = True
            Me.cbbTipoDocumentoRef.Location = New System.Drawing.Point(105, 4)
            Me.cbbTipoDocumentoRef.Name = "cbbTipoDocumentoRef"
            Me.cbbTipoDocumentoRef.Size = New System.Drawing.Size(315, 21)
            Me.cbbTipoDocumentoRef.TabIndex = 21
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(12, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(34, 13)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "Tipo :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.dtpFechaRecepEP)
            Me.Panel2.Controls.Add(Me.Label9)
            Me.Panel2.Controls.Add(Me.Label8)
            Me.Panel2.Controls.Add(Me.dtpFechaRecepRP)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(446, 16)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(430, 78)
            Me.Panel2.TabIndex = 26
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(15, 23)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(15, 46)
            Me.lblSala.Margin = New System.Windows.Forms.Padding(0)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'grpObs
            '
            Me.grpObs.Controls.Add(Me.txtobs)
            Me.grpObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpObs.Location = New System.Drawing.Point(0, 0)
            Me.grpObs.Name = "grpObs"
            Me.grpObs.Size = New System.Drawing.Size(446, 0)
            Me.grpObs.TabIndex = 30
            Me.grpObs.TabStop = False
            Me.grpObs.Text = "Observación"
            '
            'txtobs
            '
            Me.txtobs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtobs._BloquearPaste = False
            Me.txtobs._SeleccionarTodo = False
            Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtobs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtobs.Location = New System.Drawing.Point(3, 16)
            Me.txtobs.MaxLength = 200
            Me.txtobs.Multiline = True
            Me.txtobs.Name = "txtobs"
            Me.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobs.Size = New System.Drawing.Size(440, 0)
            Me.txtobs.TabIndex = 31
            Me.txtobs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtobs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'grbAnulacion
            '
            Me.grbAnulacion.Controls.Add(Me.txtobs_anulacion)
            Me.grbAnulacion.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbAnulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAnulacion.Location = New System.Drawing.Point(446, 0)
            Me.grbAnulacion.Name = "grbAnulacion"
            Me.grbAnulacion.Size = New System.Drawing.Size(433, 0)
            Me.grbAnulacion.TabIndex = 32
            Me.grbAnulacion.TabStop = False
            Me.grbAnulacion.Text = "Motivo de anulación"
            '
            'txtobs_anulacion
            '
            Me.txtobs_anulacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtobs_anulacion._BloquearPaste = False
            Me.txtobs_anulacion._SeleccionarTodo = False
            Me.txtobs_anulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtobs_anulacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtobs_anulacion.Location = New System.Drawing.Point(3, 16)
            Me.txtobs_anulacion.MaxLength = 250
            Me.txtobs_anulacion.Multiline = True
            Me.txtobs_anulacion.Name = "txtobs_anulacion"
            Me.txtobs_anulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobs_anulacion.Size = New System.Drawing.Size(427, 0)
            Me.txtobs_anulacion.TabIndex = 33
            Me.txtobs_anulacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtobs_anulacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlCuerpo
            '
            Me.pnlCuerpo.Controls.Add(Me.pnlObsAnu)
            Me.pnlCuerpo.Controls.Add(Me.Panel5)
            Me.pnlCuerpo.Controls.Add(Me.grpDatosExpediente)
            Me.pnlCuerpo.Controls.Add(Me.Panel6)
            Me.pnlCuerpo.Controls.Add(Me.grbConstancia)
            Me.pnlCuerpo.Controls.Add(Me.grbDocReferencia)
            Me.pnlCuerpo.Controls.Add(Me.gbPoderJudicial)
            Me.pnlCuerpo.Controls.Add(Me.grpDatosSolicitante)
            Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCuerpo.Location = New System.Drawing.Point(0, 80)
            Me.pnlCuerpo.Name = "pnlCuerpo"
            Me.pnlCuerpo.Size = New System.Drawing.Size(879, 408)
            Me.pnlCuerpo.TabIndex = 45
            '
            'pnlObsAnu
            '
            Me.pnlObsAnu.Controls.Add(Me.grpObs)
            Me.pnlObsAnu.Controls.Add(Me.grbAnulacion)
            Me.pnlObsAnu.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObsAnu.Location = New System.Drawing.Point(0, 210)
            Me.pnlObsAnu.Name = "pnlObsAnu"
            Me.pnlObsAnu.Size = New System.Drawing.Size(879, 0)
            Me.pnlObsAnu.TabIndex = 29
            '
            'Panel5
            '
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 198)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(879, 11)
            Me.Panel5.TabIndex = 35
            '
            'grpDatosExpediente
            '
            Me.grpDatosExpediente.BackColor = System.Drawing.Color.Transparent
            Me.grpDatosExpediente.Controls.Add(Me.txtNumExp)
            Me.grpDatosExpediente.Controls.Add(Me.Label15)
            Me.grpDatosExpediente.Controls.Add(Me.txtFechaIEP)
            Me.grpDatosExpediente.Controls.Add(Me.txtFechaISP)
            Me.grpDatosExpediente.Controls.Add(Me.UscComboDistritoJudicial2)
            Me.grpDatosExpediente.Controls.Add(Me.Label20)
            Me.grpDatosExpediente.Controls.Add(Me.Label21)
            Me.grpDatosExpediente.Controls.Add(Me.txtExpSecretario)
            Me.grpDatosExpediente.Controls.Add(Me.Label17)
            Me.grpDatosExpediente.Controls.Add(Me.Label18)
            Me.grpDatosExpediente.Controls.Add(Me.Label19)
            Me.grpDatosExpediente.Controls.Add(Me.Label14)
            Me.grpDatosExpediente.Controls.Add(Me.UscComboSala2)
            Me.grpDatosExpediente.Controls.Add(Me.Panel7)
            Me.grpDatosExpediente.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.grpDatosExpediente.Location = New System.Drawing.Point(0, 209)
            Me.grpDatosExpediente.Name = "grpDatosExpediente"
            Me.grpDatosExpediente.Size = New System.Drawing.Size(879, 131)
            Me.grpDatosExpediente.TabIndex = 34
            Me.grpDatosExpediente.TabStop = False
            Me.grpDatosExpediente.Text = "Datos del proceso por el cual se encuentra recluido "
            '
            'txtNumExp
            '
            Me.txtNumExp._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumExp._BloquearPaste = False
            Me.txtNumExp._SeleccionarTodo = False
            Me.txtNumExp.BackColor = System.Drawing.SystemColors.Control
            Me.txtNumExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumExp.Location = New System.Drawing.Point(568, 19)
            Me.txtNumExp.MaxLength = 20
            Me.txtNumExp.Name = "txtNumExp"
            Me.txtNumExp.ReadOnly = True
            Me.txtNumExp.Size = New System.Drawing.Size(298, 20)
            Me.txtNumExp.TabIndex = 39
            Me.txtNumExp.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumExp.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(15, 47)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(141, 13)
            Me.Label15.TabIndex = 44
            Me.Label15.Text = "Fecha último ingreso al E.P.:"
            '
            'txtFechaIEP
            '
            Me.txtFechaIEP._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaIEP._BloquearPaste = False
            Me.txtFechaIEP._SeleccionarTodo = False
            Me.txtFechaIEP.BackColor = System.Drawing.SystemColors.Control
            Me.txtFechaIEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaIEP.Location = New System.Drawing.Point(228, 45)
            Me.txtFechaIEP.MaxLength = 20
            Me.txtFechaIEP.Name = "txtFechaIEP"
            Me.txtFechaIEP.ReadOnly = True
            Me.txtFechaIEP.Size = New System.Drawing.Size(195, 20)
            Me.txtFechaIEP.TabIndex = 36
            Me.txtFechaIEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtFechaIEP.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaIEP.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtFechaISP
            '
            Me.txtFechaISP._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaISP._BloquearPaste = False
            Me.txtFechaISP._SeleccionarTodo = False
            Me.txtFechaISP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaISP.Location = New System.Drawing.Point(228, 19)
            Me.txtFechaISP.MaxLength = 20
            Me.txtFechaISP.Name = "txtFechaISP"
            Me.txtFechaISP.ReadOnly = True
            Me.txtFechaISP.Size = New System.Drawing.Size(195, 20)
            Me.txtFechaISP.TabIndex = 35
            Me.txtFechaISP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtFechaISP.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaISP.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'UscComboDistritoJudicial2
            '
            Me.UscComboDistritoJudicial2._DropDownWidthAuto = False
            Me.UscComboDistritoJudicial2._selectedValue = 0
            Me.UscComboDistritoJudicial2._Todos = False
            Me.UscComboDistritoJudicial2._TodosMensaje = ""
            Me.UscComboDistritoJudicial2._visibleBuscar = False
            Me.UscComboDistritoJudicial2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
            Me.UscComboDistritoJudicial2.BackColor = System.Drawing.SystemColors.Control
            Me.UscComboDistritoJudicial2.Location = New System.Drawing.Point(109, 73)
            Me.UscComboDistritoJudicial2.Name = "UscComboDistritoJudicial2"
            Me.UscComboDistritoJudicial2.Size = New System.Drawing.Size(314, 21)
            Me.UscComboDistritoJudicial2.TabIndex = 37
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(15, 77)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(83, 13)
            Me.Label20.TabIndex = 36
            Me.Label20.Text = "Distrito Judicial :"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(15, 105)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(70, 13)
            Me.Label21.TabIndex = 37
            Me.Label21.Text = "Aut. Judicial :"
            '
            'txtExpSecretario
            '
            Me.txtExpSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtExpSecretario._BloquearPaste = False
            Me.txtExpSecretario._SeleccionarTodo = True
            Me.txtExpSecretario.Location = New System.Drawing.Point(568, 45)
            Me.txtExpSecretario.MaxLength = 200
            Me.txtExpSecretario.Name = "txtExpSecretario"
            Me.txtExpSecretario.ReadOnly = True
            Me.txtExpSecretario.Size = New System.Drawing.Size(298, 20)
            Me.txtExpSecretario.TabIndex = 40
            Me.txtExpSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtExpSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.BackColor = System.Drawing.Color.Transparent
            Me.Label17.Location = New System.Drawing.Point(462, 77)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(45, 13)
            Me.Label17.TabIndex = 30
            Me.Label17.Text = "Delitos :"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.Location = New System.Drawing.Point(462, 47)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(58, 13)
            Me.Label18.TabIndex = 29
            Me.Label18.Text = "Secretario:"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.BackColor = System.Drawing.Color.Transparent
            Me.Label19.Location = New System.Drawing.Point(462, 22)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(78, 13)
            Me.Label19.TabIndex = 28
            Me.Label19.Text = "N° Expediente:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(15, 22)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(207, 13)
            Me.Label14.TabIndex = 43
            Me.Label14.Text = "Fecha de ingreso al Sistema Penitenciario:"
            '
            'UscComboSala2
            '
            Me.UscComboSala2._DistritoJudicialID = 0
            Me.UscComboSala2._DropDownWidthAuto = False
            Me.UscComboSala2._SalaJuzgadoID = 0
            Me.UscComboSala2._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala2._Todos = False
            Me.UscComboSala2._TodosMensaje = ""
            Me.UscComboSala2._visibleBuscar = True
            Me.UscComboSala2.Location = New System.Drawing.Point(109, 101)
            Me.UscComboSala2.Name = "UscComboSala2"
            Me.UscComboSala2.Size = New System.Drawing.Size(314, 21)
            Me.UscComboSala2.TabIndex = 45
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.txtDelitoNombre)
            Me.Panel7.Controls.Add(Me.pnlBotonesDelitos)
            Me.Panel7.Location = New System.Drawing.Point(568, 73)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(298, 51)
            Me.Panel7.TabIndex = 46
            '
            'txtDelitoNombre
            '
            Me.txtDelitoNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelitoNombre._BloquearPaste = False
            Me.txtDelitoNombre._SeleccionarTodo = False
            Me.txtDelitoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDelitoNombre.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtDelitoNombre.Location = New System.Drawing.Point(0, 0)
            Me.txtDelitoNombre.MaxLength = 0
            Me.txtDelitoNombre.Multiline = True
            Me.txtDelitoNombre.Name = "txtDelitoNombre"
            Me.txtDelitoNombre.ReadOnly = True
            Me.txtDelitoNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDelitoNombre.Size = New System.Drawing.Size(271, 51)
            Me.txtDelitoNombre.TabIndex = 43
            Me.txtDelitoNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelitoNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlBotonesDelitos
            '
            Me.pnlBotonesDelitos.Controls.Add(Me.btnAddDelito)
            Me.pnlBotonesDelitos.Controls.Add(Me.btnEliminarDelito)
            Me.pnlBotonesDelitos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotonesDelitos.Location = New System.Drawing.Point(271, 0)
            Me.pnlBotonesDelitos.Name = "pnlBotonesDelitos"
            Me.pnlBotonesDelitos.Size = New System.Drawing.Size(27, 51)
            Me.pnlBotonesDelitos.TabIndex = 0
            '
            'btnAddDelito
            '
            Me.btnAddDelito.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddDelito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddDelito.Location = New System.Drawing.Point(1, 2)
            Me.btnAddDelito.Name = "btnAddDelito"
            Me.btnAddDelito.Size = New System.Drawing.Size(25, 25)
            Me.btnAddDelito.TabIndex = 41
            Me.btnAddDelito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnEliminarDelito
            '
            Me.btnEliminarDelito.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminarDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarDelito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarDelito.Location = New System.Drawing.Point(1, 26)
            Me.btnEliminarDelito.Name = "btnEliminarDelito"
            Me.btnEliminarDelito.Size = New System.Drawing.Size(25, 25)
            Me.btnEliminarDelito.TabIndex = 42
            Me.btnEliminarDelito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel6
            '
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel6.Location = New System.Drawing.Point(0, 340)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(879, 11)
            Me.Panel6.TabIndex = 36
            '
            'gbPoderJudicial
            '
            Me.gbPoderJudicial.Controls.Add(Me.UscComboSala1)
            Me.gbPoderJudicial.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.gbPoderJudicial.Controls.Add(Me.lblDistrito)
            Me.gbPoderJudicial.Controls.Add(Me.lblSala)
            Me.gbPoderJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbPoderJudicial.Location = New System.Drawing.Point(0, 43)
            Me.gbPoderJudicial.Name = "gbPoderJudicial"
            Me.gbPoderJudicial.Size = New System.Drawing.Size(879, 70)
            Me.gbPoderJudicial.TabIndex = 16
            Me.gbPoderJudicial.TabStop = False
            Me.gbPoderJudicial.Text = "Datos de la Solicitud - Poder Judicial"
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
            Me.UscComboSala1.Location = New System.Drawing.Point(108, 43)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(735, 21)
            Me.UscComboSala1.TabIndex = 18
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._DropDownWidthAuto = False
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1._visibleBuscar = False
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(108, 17)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(735, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 17
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.BlinkRate = 0
            Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.ErrorProvider1.ContainerControl = Me
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 539)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(879, 42)
            Me.UscAuditUser1.TabIndex = 5
            '
            'frmTramite
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(879, 581)
            Me.Name = "frmTramite"
            Me.Text = "Registro de Trámite de Constancia de Reclusión"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlCabeceraInterno.ResumeLayout(False)
            Me.pnlCabeceraInterno.PerformLayout()
            Me.pnlTramite.ResumeLayout(False)
            Me.grbTramite.ResumeLayout(False)
            Me.grbTramite.PerformLayout()
            Me.grbConstancia.ResumeLayout(False)
            Me.grbConstancia.PerformLayout()
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlVerInterno.ResumeLayout(False)
            Me.pnlImprimir.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grpDatosSolicitante.ResumeLayout(False)
            Me.grpDatosSolicitante.PerformLayout()
            Me.grbDocReferencia.ResumeLayout(False)
            Me.pnlNumeroRef.ResumeLayout(False)
            Me.pnlNumeroRef.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.pnlSerie.ResumeLayout(False)
            Me.pnlSerie.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.grpObs.ResumeLayout(False)
            Me.grpObs.PerformLayout()
            Me.grbAnulacion.ResumeLayout(False)
            Me.grbAnulacion.PerformLayout()
            Me.pnlCuerpo.ResumeLayout(False)
            Me.pnlObsAnu.ResumeLayout(False)
            Me.grpDatosExpediente.ResumeLayout(False)
            Me.grpDatosExpediente.PerformLayout()
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.pnlBotonesDelitos.ResumeLayout(False)
            Me.gbPoderJudicial.ResumeLayout(False)
            Me.gbPoderJudicial.PerformLayout()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlCabeceraInterno As Panel
        Friend WithEvents Label34 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents pnlTramite As Panel
        Friend WithEvents Label10 As Label
        Friend WithEvents txtNumeroTramite As TextBox
        Friend WithEvents dtpFechaRecepRP As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label9 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents dtpFechaRecepEP As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtRegionPenal As TextBox
        Friend WithEvents txtCodigoRP As TextBox
        Friend WithEvents PnlBotones As Panel
        Friend WithEvents btnAceptar As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents grpDatosSolicitante As GroupBox
        Friend WithEvents grbDocReferencia As GroupBox
        Protected WithEvents cbbTipoDocumentoRef As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents pnlNumeroRef As Panel
        Friend WithEvents lblNumero As Label
        Friend WithEvents txtNumDocRef As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblFecha As Label
        Friend WithEvents dtpFechaRef As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label2 As Label
        Friend WithEvents txtSerRecibo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents cbbTipSolicitante As APPControls.uscComboParametrica
        Friend WithEvents UscComboDistritoJudicial1 As APPControls.Busqueda.uscComboDistritoJudicial
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents lblDistrito As Label
        Friend WithEvents lblSala As Label
        Friend WithEvents grpObs As GroupBox
        Friend WithEvents txtobs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents grbAnulacion As GroupBox
        Friend WithEvents txtobs_anulacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents txtNumeroCR As TextBox
        Friend WithEvents btnExpedir As Button
        Friend WithEvents btnImpresion As Button
        Friend WithEvents Label12 As Label
        Friend WithEvents txtInterno As TextBox
        Friend WithEvents grbConstancia As GroupBox
        Friend WithEvents txtFechaExp As TextBox
        Friend WithEvents Label13 As Label
        Friend WithEvents grbTramite As GroupBox
        Friend WithEvents Label7 As Label
        Friend WithEvents txtEstado As TextBox
        Friend WithEvents Panel4 As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents txtUsuario As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents pnlCuerpo As Panel
        Friend WithEvents grpDatosExpediente As GroupBox
        Friend WithEvents UscComboDistritoJudicial2 As APPControls.Busqueda.uscComboDistritoJudicial
        Friend WithEvents Label20 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents txtExpSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label17 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents Label19 As Label
        Friend WithEvents gbPoderJudicial As GroupBox
        Friend WithEvents Label3 As Label
        Friend WithEvents txtTipoTramite As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents btnAnular As Button
        Friend WithEvents pnlImprimir As Panel
        Friend WithEvents pnlModificar As Panel
        Friend WithEvents pnlSerie As Panel
        Friend WithEvents pnlObsAnu As Panel
        Friend WithEvents txtNumExp As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label15 As Label
        Friend WithEvents txtFechaIEP As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaISP As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label14 As Label
        Friend WithEvents ErrorProvider1 As ErrorProvider
        Friend WithEvents pnlEliminar As Panel
        Friend WithEvents btnEliminar As Button
        Friend WithEvents pnlVerInterno As Panel
        Friend WithEvents btnDetalleInterno As Button
        Friend WithEvents txtDelitoNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnEliminarDelito As Button
        Friend WithEvents btnAddDelito As Button
        Friend WithEvents Panel5 As Panel
        Friend WithEvents Panel6 As Panel
        Friend WithEvents UscComboSala2 As APPControls.Busqueda.uscComboSala
        Friend WithEvents Panel7 As Panel
        Friend WithEvents pnlBotonesDelitos As Panel
    End Class
End Namespace