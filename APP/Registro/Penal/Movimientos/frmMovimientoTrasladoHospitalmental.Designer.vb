Namespace Registro.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMovimientoTrasladoHospitalmental
        Inherits Legolas.APPUIComponents.FormPopup

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoTrasladoHospitalmental))
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grpMovimiento = New System.Windows.Forms.GroupBox()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCargarDocumento = New Legolas.APPUIComponents.myButton()
            Me.grpReferencia = New System.Windows.Forms.GroupBox()
            Me.grpEstadoEjecucion = New System.Windows.Forms.GroupBox()
            Me.lblEtiquetaObservacionEjecucion = New System.Windows.Forms.Label()
            Me.txtObservacionEjecucion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.ChkEgresoTemporal = New System.Windows.Forms.CheckBox()
            Me.chkEstadoEjecucion = New System.Windows.Forms.CheckBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.lblDocumentoOriginal = New System.Windows.Forms.Label()
            Me.txtNumDocumentoOriginal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaProgramadaTraslado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtFechaDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.UscMovExpediente1 = New APPControls.Registro.uscMovExpediente()
            Me.UscDelito1 = New APPControls.Registro.Documento.uscDelito()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.uscMovDet = New APPControls.Registro.uscMovimientoDetalle()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grpMovimiento.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.grpReferencia.SuspendLayout()
            Me.grpEstadoEjecucion.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grpReferencia)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.grpMovimiento)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(667, 611)
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
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(7, 26)
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
            Me.txtNumDocumento.Location = New System.Drawing.Point(89, 22)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.ReadOnly = True
            Me.txtNumDocumento.Size = New System.Drawing.Size(174, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'grpMovimiento
            '
            Me.grpMovimiento.Controls.Add(Me.uscMovDet)
            Me.grpMovimiento.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grpMovimiento.Name = "grpMovimiento"
            Me.grpMovimiento.Size = New System.Drawing.Size(667, 185)
            Me.grpMovimiento.TabIndex = 0
            Me.grpMovimiento.TabStop = False
            Me.grpMovimiento.Text = "Movimiento"
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(3, 333)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(661, 45)
            Me.PnlInferior.TabIndex = 101
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(461, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(200, 45)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCargarDocumento
            '
            Me.btnCargarDocumento.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnCargarDocumento.Location = New System.Drawing.Point(313, 5)
            Me.btnCargarDocumento.Name = "btnCargarDocumento"
            Me.btnCargarDocumento.Size = New System.Drawing.Size(22, 22)
            Me.btnCargarDocumento.TabIndex = 8
            Me.btnCargarDocumento.UseVisualStyleBackColor = True
            Me.btnCargarDocumento.Visible = False
            '
            'grpReferencia
            '
            Me.grpReferencia.Controls.Add(Me.UscMovExpediente1)
            Me.grpReferencia.Controls.Add(Me.UscDelito1)
            Me.grpReferencia.Controls.Add(Me.grpEstadoEjecucion)
            Me.grpReferencia.Controls.Add(Me.PnlInferior)
            Me.grpReferencia.Controls.Add(Me.txtNumDocumento)
            Me.grpReferencia.Controls.Add(Me.Label30)
            Me.grpReferencia.Controls.Add(Me.Panel3)
            Me.grpReferencia.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpReferencia.Location = New System.Drawing.Point(0, 185)
            Me.grpReferencia.Name = "grpReferencia"
            Me.grpReferencia.Size = New System.Drawing.Size(667, 381)
            Me.grpReferencia.TabIndex = 102
            Me.grpReferencia.TabStop = False
            Me.grpReferencia.Text = "Referencia del Documento de Traslado"
            '
            'grpEstadoEjecucion
            '
            Me.grpEstadoEjecucion.Controls.Add(Me.lblEtiquetaObservacionEjecucion)
            Me.grpEstadoEjecucion.Controls.Add(Me.txtObservacionEjecucion)
            Me.grpEstadoEjecucion.Controls.Add(Me.ChkEgresoTemporal)
            Me.grpEstadoEjecucion.Controls.Add(Me.chkEstadoEjecucion)
            Me.grpEstadoEjecucion.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.grpEstadoEjecucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpEstadoEjecucion.Location = New System.Drawing.Point(3, 269)
            Me.grpEstadoEjecucion.Name = "grpEstadoEjecucion"
            Me.grpEstadoEjecucion.Size = New System.Drawing.Size(661, 64)
            Me.grpEstadoEjecucion.TabIndex = 108
            Me.grpEstadoEjecucion.TabStop = False
            Me.grpEstadoEjecucion.Text = "Estado de la Orden de Traslado a Hospital de Salud Mental"
            Me.grpEstadoEjecucion.Visible = False
            '
            'lblEtiquetaObservacionEjecucion
            '
            Me.lblEtiquetaObservacionEjecucion.AutoSize = True
            Me.lblEtiquetaObservacionEjecucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaObservacionEjecucion.Location = New System.Drawing.Point(282, 20)
            Me.lblEtiquetaObservacionEjecucion.Name = "lblEtiquetaObservacionEjecucion"
            Me.lblEtiquetaObservacionEjecucion.Size = New System.Drawing.Size(69, 26)
            Me.lblEtiquetaObservacionEjecucion.TabIndex = 17
            Me.lblEtiquetaObservacionEjecucion.Text = "Detalle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Ejecución"
            '
            'txtObservacionEjecucion
            '
            Me.txtObservacionEjecucion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacionEjecucion._BloquearPaste = False
            Me.txtObservacionEjecucion._SeleccionarTodo = False
            Me.txtObservacionEjecucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionEjecucion.Location = New System.Drawing.Point(357, 16)
            Me.txtObservacionEjecucion.MaxLength = 2500
            Me.txtObservacionEjecucion.Multiline = True
            Me.txtObservacionEjecucion.Name = "txtObservacionEjecucion"
            Me.txtObservacionEjecucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacionEjecucion.Size = New System.Drawing.Size(295, 39)
            Me.txtObservacionEjecucion.TabIndex = 5
            Me.txtObservacionEjecucion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacionEjecucion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'ChkEgresoTemporal
            '
            Me.ChkEgresoTemporal.AutoSize = True
            Me.ChkEgresoTemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ChkEgresoTemporal.ForeColor = System.Drawing.Color.Red
            Me.ChkEgresoTemporal.Location = New System.Drawing.Point(16, 41)
            Me.ChkEgresoTemporal.Name = "ChkEgresoTemporal"
            Me.ChkEgresoTemporal.Size = New System.Drawing.Size(106, 17)
            Me.ChkEgresoTemporal.TabIndex = 4
            Me.ChkEgresoTemporal.Text = "Egreso Temporal"
            Me.ChkEgresoTemporal.UseVisualStyleBackColor = True
            '
            'chkEstadoEjecucion
            '
            Me.chkEstadoEjecucion.AutoSize = True
            Me.chkEstadoEjecucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkEstadoEjecucion.ForeColor = System.Drawing.Color.Red
            Me.chkEstadoEjecucion.Location = New System.Drawing.Point(16, 19)
            Me.chkEstadoEjecucion.Name = "chkEstadoEjecucion"
            Me.chkEstadoEjecucion.Size = New System.Drawing.Size(222, 17)
            Me.chkEstadoEjecucion.TabIndex = 3
            Me.chkEstadoEjecucion.Text = "Se Ejecuta dando atención al documento"
            Me.chkEstadoEjecucion.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.PictureBox1)
            Me.Panel3.Controls.Add(Me.lblDocumentoOriginal)
            Me.Panel3.Controls.Add(Me.txtNumDocumentoOriginal)
            Me.Panel3.Controls.Add(Me.txtFechaProgramadaTraslado)
            Me.Panel3.Controls.Add(Me.Label3)
            Me.Panel3.Controls.Add(Me.txtFechaDocumento)
            Me.Panel3.Controls.Add(Me.Label2)
            Me.Panel3.Controls.Add(Me.btnCargarDocumento)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(661, 61)
            Me.Panel3.TabIndex = 103
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(9, 25)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(67, 28)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 18
            Me.PictureBox1.TabStop = False
            '
            'lblDocumentoOriginal
            '
            Me.lblDocumentoOriginal.AutoSize = True
            Me.lblDocumentoOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDocumentoOriginal.Location = New System.Drawing.Point(82, 36)
            Me.lblDocumentoOriginal.Name = "lblDocumentoOriginal"
            Me.lblDocumentoOriginal.Size = New System.Drawing.Size(118, 13)
            Me.lblDocumentoOriginal.TabIndex = 17
            Me.lblDocumentoOriginal.Text = "Nro. Orden de Traslado"
            Me.lblDocumentoOriginal.Visible = False
            '
            'txtNumDocumentoOriginal
            '
            Me.txtNumDocumentoOriginal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumentoOriginal._BloquearPaste = False
            Me.txtNumDocumentoOriginal._SeleccionarTodo = False
            Me.txtNumDocumentoOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDocumentoOriginal.Location = New System.Drawing.Point(206, 33)
            Me.txtNumDocumentoOriginal.MaxLength = 120
            Me.txtNumDocumentoOriginal.Name = "txtNumDocumentoOriginal"
            Me.txtNumDocumentoOriginal.ReadOnly = True
            Me.txtNumDocumentoOriginal.Size = New System.Drawing.Size(217, 20)
            Me.txtNumDocumentoOriginal.TabIndex = 16
            Me.txtNumDocumentoOriginal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumentoOriginal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.txtNumDocumentoOriginal.Visible = False
            '
            'txtFechaProgramadaTraslado
            '
            Me.txtFechaProgramadaTraslado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaProgramadaTraslado._BloquearPaste = False
            Me.txtFechaProgramadaTraslado._SeleccionarTodo = False
            Me.txtFechaProgramadaTraslado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaProgramadaTraslado.Location = New System.Drawing.Point(577, 8)
            Me.txtFechaProgramadaTraslado.MaxLength = 120
            Me.txtFechaProgramadaTraslado.Name = "txtFechaProgramadaTraslado"
            Me.txtFechaProgramadaTraslado.ReadOnly = True
            Me.txtFechaProgramadaTraslado.Size = New System.Drawing.Size(82, 20)
            Me.txtFechaProgramadaTraslado.TabIndex = 15
            Me.txtFechaProgramadaTraslado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaProgramadaTraslado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(430, 11)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(147, 13)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Fec. Programada de Traslado"
            '
            'txtFechaDocumento
            '
            Me.txtFechaDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaDocumento._BloquearPaste = False
            Me.txtFechaDocumento._SeleccionarTodo = False
            Me.txtFechaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaDocumento.Location = New System.Drawing.Point(350, 7)
            Me.txtFechaDocumento.MaxLength = 120
            Me.txtFechaDocumento.Name = "txtFechaDocumento"
            Me.txtFechaDocumento.ReadOnly = True
            Me.txtFechaDocumento.Size = New System.Drawing.Size(73, 20)
            Me.txtFechaDocumento.TabIndex = 13
            Me.txtFechaDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(266, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(86, 13)
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "Fec. Documento"
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
            Me.UscMovExpediente1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMovExpediente1.GrillaCountExp = 0
            Me.UscMovExpediente1.Location = New System.Drawing.Point(3, 77)
            Me.UscMovExpediente1.Name = "UscMovExpediente1"
            Me.UscMovExpediente1.Size = New System.Drawing.Size(661, 106)
            Me.UscMovExpediente1.TabIndex = 105
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
            Me.UscDelito1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscDelito1.Location = New System.Drawing.Point(3, 183)
            Me.UscDelito1.Name = "UscDelito1"
            Me.UscDelito1.Size = New System.Drawing.Size(661, 86)
            Me.UscDelito1.TabIndex = 109
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 566)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(667, 45)
            Me.UscAuditUser1.TabIndex = 0
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
            Me.uscMovDet._Establecimientomental = ""
            Me.uscMovDet._EstablecimientomentalId = -1
            Me.uscMovDet._EstadoEjecucionMovimientoOriginal = -1
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
            Me.uscMovDet._uscEscritura = False
            Me.uscMovDet.BackColor = System.Drawing.Color.Transparent
            Me.uscMovDet.DocJudicialReferencia_OTHSM = -1
            Me.uscMovDet.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMovDet.Enabletcontrol = False
            Me.uscMovDet.Estado_Ejecucion_Ejecutado = -1
            Me.uscMovDet.EstadoAuxID = 0
            Me.uscMovDet.EstadoID = 0
            Me.uscMovDet.estadoMovimientoNombre = "EN DESARROLLO"
            Me.uscMovDet.EstadoTramite = ""
            Me.uscMovDet.EstadoTramiteID = -1
            Me.uscMovDet.FechaInscripcionLibertad = CType(0, Long)
            Me.uscMovDet.Location = New System.Drawing.Point(3, 16)
            Me.uscMovDet.Movimiento_Observacion_Estado_Ejecucion_MD = Nothing
            Me.uscMovDet.MovimientoGrupo = 0
            Me.uscMovDet.MovimientoGrupoNom = ""
            Me.uscMovDet.MovimientoMotivo = 0
            Me.uscMovDet.MovimientoMotivoIngreso = 0
            Me.uscMovDet.MovimientoTipo = 0
            Me.uscMovDet.Name = "uscMovDet"
            Me.uscMovDet.Observacion = ""
            Me.uscMovDet.OtroLugar = ""
            Me.uscMovDet.Size = New System.Drawing.Size(661, 166)
            Me.uscMovDet.TabIndex = 0
            '
            'frmMovimientoTrasladoHospitalmental
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(667, 611)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoTrasladoHospitalmental"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Movimiento Orden de Traslado"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grpMovimiento.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.grpReferencia.ResumeLayout(False)
            Me.grpReferencia.PerformLayout()
            Me.grpEstadoEjecucion.ResumeLayout(False)
            Me.grpEstadoEjecucion.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents uscMovDet As APPControls.Registro.uscMovimientoDetalle
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnCargarDocumento As Legolas.APPUIComponents.myButton
        Friend WithEvents grpReferencia As GroupBox
        Friend WithEvents UscMovExpediente1 As APPControls.Registro.uscMovExpediente
        Friend WithEvents Panel3 As Panel
        Friend WithEvents grpEstadoEjecucion As GroupBox
        Friend WithEvents lblEtiquetaObservacionEjecucion As Label
        Friend WithEvents txtObservacionEjecucion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents ChkEgresoTemporal As CheckBox
        Friend WithEvents chkEstadoEjecucion As CheckBox
        Friend WithEvents txtFechaProgramadaTraslado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents txtFechaDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents UscDelito1 As APPControls.Registro.Documento.uscDelito
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents lblDocumentoOriginal As Label
        Friend WithEvents txtNumDocumentoOriginal As Legolas.APPUIComponents.MyTextBox
    End Class
End Namespace

