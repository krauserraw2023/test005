Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolIngresoTraslado
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
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotonesGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlData = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.uscResolIngreso = New APPControls.Registro.Resoluciones.uscResolIngreso()
            Me.UscMovimientoDetalle21 = New APPControls.Registro.uscMovimientoDetalle2()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtNumOficio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.UscExpeDeResolucion1 = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlData.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.TabControl1)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlData)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCabecera)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(787, 535)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 494)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(787, 41)
            Me.PnlInferior.TabIndex = 4
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(592, 41)
            Me.UscAuditUser1.TabIndex = 1
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(592, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 41)
            Me.PnlBotonesGrabar.TabIndex = 2
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(2, 1)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(91, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(687, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 41)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(1, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlCabecera
            '
            Me.pnlCabecera.BackColor = System.Drawing.Color.Transparent
            Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlCabecera.Controls.Add(Me.lblCodInterno)
            Me.pnlCabecera.Controls.Add(Me.Label5)
            Me.pnlCabecera.Controls.Add(Me.lblInterno)
            Me.pnlCabecera.Controls.Add(Me.Label4)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(787, 22)
            Me.pnlCabecera.TabIndex = 0
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(505, 3)
            Me.lblCodInterno.Name = "lblCodInterno"
            Me.lblCodInterno.Size = New System.Drawing.Size(82, 13)
            Me.lblCodInterno.TabIndex = 3
            Me.lblCodInterno.Text = "lblCodInterno"
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(447, 3)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(50, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Código:"
            '
            'lblInterno
            '
            Me.lblInterno.AutoSize = True
            Me.lblInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInterno.Location = New System.Drawing.Point(74, 3)
            Me.lblInterno.Name = "lblInterno"
            Me.lblInterno.Size = New System.Drawing.Size(60, 13)
            Me.lblInterno.TabIndex = 1
            Me.lblInterno.Text = "lblInterno"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(66, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Interno(a):"
            '
            'pnlData
            '
            Me.pnlData.Controls.Add(Me.Panel4)
            Me.pnlData.Controls.Add(Me.UscMovimientoDetalle21)
            Me.pnlData.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlData.Location = New System.Drawing.Point(0, 45)
            Me.pnlData.Name = "pnlData"
            Me.pnlData.Size = New System.Drawing.Size(787, 146)
            Me.pnlData.TabIndex = 1
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.uscResolIngreso)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(437, 146)
            Me.Panel4.TabIndex = 0
            '
            'uscResolIngreso
            '
            Me.uscResolIngreso._blnNuevo = False
            Me.uscResolIngreso._Codigo = -1
            Me.uscResolIngreso._DistritoJudicialID = -1
            Me.uscResolIngreso._DistritoJudicialNombre = ""
            Me.uscResolIngreso._InternoId = -1
            Me.uscResolIngreso._InternoIngresoId = -1
            Me.uscResolIngreso._InternoIngresoInpeId = -1
            Me.uscResolIngreso._Juez = ""
            Me.uscResolIngreso._MovimientoMotivo = -1
            Me.uscResolIngreso._OtraAutoridadCargo = ""
            Me.uscResolIngreso._OtraAutoridadNombre = ""
            Me.uscResolIngreso._PenalID = -1
            Me.uscResolIngreso._RegionID = -1
            Me.uscResolIngreso._SalaJuzgado = -1
            Me.uscResolIngreso._SalaJuzgadoNombre = ""
            Me.uscResolIngreso._Secretario = ""
            Me.uscResolIngreso._SituacionJuridicaId = -1
            Me.uscResolIngreso._TipoAutoridadJudicialID = -1
            Me.uscResolIngreso._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscResolIngreso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscResolIngreso.DocumentoFecha = CType(0, Long)
            Me.uscResolIngreso.DocumentoFechaRecepcion = CType(0, Long)
            Me.uscResolIngreso.DocumentoJudicialPenalOrigen = ""
            Me.uscResolIngreso.DocumentoNumero = ""
            Me.uscResolIngreso.DocumentoSubTipo = -1
            Me.uscResolIngreso.FechadeIngresoPenalOrigen = CType(0, Long)
            Me.uscResolIngreso.FechaInternamientoPenalOrigen = CType(0, Long)
            Me.uscResolIngreso.FechaMovimiento = CType(0, Long)
            Me.uscResolIngreso.Location = New System.Drawing.Point(0, 0)
            Me.uscResolIngreso.Name = "uscResolIngreso"
            Me.uscResolIngreso.Observacion = ""
            Me.uscResolIngreso.ObservacionPenalOrigen = ""
            Me.uscResolIngreso.PenalDestino = -1
            Me.uscResolIngreso.ProlonDetencionCantidad = ""
            Me.uscResolIngreso.ProlonDetencionFechFin = CType(0, Long)
            Me.uscResolIngreso.ProlonDetencionFechIni = CType(0, Long)
            Me.uscResolIngreso.ProlonDetencionUnidad = ""
            Me.uscResolIngreso.RegionDestino = -1
            Me.uscResolIngreso.Size = New System.Drawing.Size(437, 146)
            Me.uscResolIngreso.TabIndex = 0
            Me.uscResolIngreso.TotalAnios = 0
            Me.uscResolIngreso.TotalDias = 0
            Me.uscResolIngreso.TotalMeses = 0
            '
            'UscMovimientoDetalle21
            '
            Me.UscMovimientoDetalle21._blnEnablecbbMotivo = True
            Me.UscMovimientoDetalle21._blnNuevo = False
            Me.UscMovimientoDetalle21._blnValor = False
            Me.UscMovimientoDetalle21._blnVisiblecbbMotivo = True
            Me.UscMovimientoDetalle21._blnVisiblelblMotivo = True
            Me.UscMovimientoDetalle21._CargarExpedientes = -1
            Me.UscMovimientoDetalle21._Codigo = -1
            Me.UscMovimientoDetalle21._CodigoResolucion = -1
            Me.UscMovimientoDetalle21._DocumJudicialD = -1
            Me.UscMovimientoDetalle21._FechaMovimiento = CType(0, Long)
            Me.UscMovimientoDetalle21._IngresoID = -1
            Me.UscMovimientoDetalle21._IngresoInpeID = -1
            Me.UscMovimientoDetalle21._intCondicionGrupo = -1
            Me.UscMovimientoDetalle21._InternoID = -1
            Me.UscMovimientoDetalle21._MovimientoGrupo = -1
            Me.UscMovimientoDetalle21._MovimientoMotivo = 0
            Me.UscMovimientoDetalle21._MovimientoMotivo2 = 0
            Me.UscMovimientoDetalle21._MovimientoTipo = 0
            Me.UscMovimientoDetalle21._MovimientoTipo2 = -1
            Me.UscMovimientoDetalle21._PenalID = -1
            Me.UscMovimientoDetalle21._PenalID1 = -1
            Me.UscMovimientoDetalle21._PenalID2 = -1
            Me.UscMovimientoDetalle21._PenalIngreso = -1
            Me.UscMovimientoDetalle21._RegionID = -1
            Me.UscMovimientoDetalle21._RegionIngreso = -1
            Me.UscMovimientoDetalle21._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscMovimientoDetalle21.Dock = System.Windows.Forms.DockStyle.Right
            Me.UscMovimientoDetalle21.DocumentoSubTipo = -1
            Me.UscMovimientoDetalle21.DocumentoTipo = -1
            Me.UscMovimientoDetalle21.Location = New System.Drawing.Point(437, 0)
            Me.UscMovimientoDetalle21.MovimientoTipo = "True"
            Me.UscMovimientoDetalle21.Name = "UscMovimientoDetalle21"
            Me.UscMovimientoDetalle21.Size = New System.Drawing.Size(350, 146)
            Me.UscMovimientoDetalle21.TabIndex = 1
            '
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.Label2)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(787, 23)
            Me.pnlTitulo.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(787, 3)
            Me.Label1.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(787, 23)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "RESOLUCION: INGRESO POR TRASLADO"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtObservacion)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(758, 256)
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Del Documento de Internamiento del Penal de Origen"
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = True
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(116, 105)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(639, 148)
            Me.txtObservacion.TabIndex = 4
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'Label10
            '
            Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(3, 105)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(113, 148)
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Observaciones:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.dtpDocJudFecRecep)
            Me.Panel3.Controls.Add(Me.dtpDocJudFecha)
            Me.Panel3.Controls.Add(Me.Label3)
            Me.Panel3.Controls.Add(Me.Label8)
            Me.Panel3.Controls.Add(Me.txtNumOficio)
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(752, 89)
            Me.Panel3.TabIndex = 2
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(113, 60)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(113, 35)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(2, 38)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(107, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Fecha Internamiento:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(2, 13)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(83, 13)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "N° Documento :"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNumOficio
            '
            Me.txtNumOficio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOficio._BloquearPaste = False
            Me.txtNumOficio._SeleccionarTodo = False
            Me.txtNumOficio.Location = New System.Drawing.Point(113, 10)
            Me.txtNumOficio.Name = "txtNumOficio"
            Me.txtNumOficio.Size = New System.Drawing.Size(330, 20)
            Me.txtNumOficio.TabIndex = 1
            Me.txtNumOficio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumOficio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(2, 58)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(89, 26)
            Me.Label7.TabIndex = 4
            Me.Label7.Text = "Fecha Ingreso al " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Penal de origen :"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 191)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(787, 303)
            Me.TabControl1.TabIndex = 2
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(779, 277)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Información Referencial"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.UscExpeDeResolucion1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(559, 168)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Expedientes"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'UscExpeDeResolucion1
            '
            Me.UscExpeDeResolucion1._DocumentoJudicialExpedienteID = -1
            Me.UscExpeDeResolucion1._DocumentoJudicialID = -1
            Me.UscExpeDeResolucion1._Documentos_sin_mov = False
            Me.UscExpeDeResolucion1._FechaMovimiento = CType(0, Long)
            Me.UscExpeDeResolucion1._FormEliminar = False
            Me.UscExpeDeResolucion1._FormEscritura = False
            Me.UscExpeDeResolucion1._InternoID = -1
            Me.UscExpeDeResolucion1._InternoIngresoID = -1
            Me.UscExpeDeResolucion1._InternoIngresoInpeId = -1
            Me.UscExpeDeResolucion1._PenalID = -1
            Me.UscExpeDeResolucion1._PermisoEliminar = False
            Me.UscExpeDeResolucion1._RegionID = -1
            Me.UscExpeDeResolucion1._SubTipo = -1
            Me.UscExpeDeResolucion1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscExpeDeResolucion1._TipoResolucion = -1
            Me.UscExpeDeResolucion1._VariableMov = 0
            Me.UscExpeDeResolucion1._VisibleControlExpediente = False
            Me.UscExpeDeResolucion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscExpeDeResolucion1.Location = New System.Drawing.Point(3, 3)
            Me.UscExpeDeResolucion1.Name = "UscExpeDeResolucion1"
            Me.UscExpeDeResolucion1.Size = New System.Drawing.Size(553, 162)
            Me.UscExpeDeResolucion1.TabIndex = 0
            '
            'frmResolIngresoTraslado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(787, 535)
            Me.Name = "frmResolIngresoTraslado"
            Me.Text = "Resolución de ingreso"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.pnlData.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.pnlTitulo.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents lblCodInterno As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblInterno As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents uscResolIngreso As APPControls.Registro.Resoluciones.uscResolIngreso
        Friend WithEvents pnlData As System.Windows.Forms.Panel
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents UscExpeDeResolucion1 As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtNumOficio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents UscMovimientoDetalle21 As APPControls.Registro.uscMovimientoDetalle2
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
      
    End Class
End Namespace