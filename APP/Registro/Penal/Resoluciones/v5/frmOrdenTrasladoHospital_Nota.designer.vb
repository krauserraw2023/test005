Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmOrdenTrasladoHospital_Nota
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenTrasladoHospital_Nota))
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotonesGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtFechaProgramadaTraslado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtFechaDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscExpeDeResolucion = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.UscResolAclaratoriaExpe1 = New APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.UscExpeDeResolucion)
            Me.gbxFormChildContainer.Controls.Add(Me.UscResolAclaratoriaExpe1)
            Me.gbxFormChildContainer.Controls.Add(Me.lblTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCabecera)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(834, 491)
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
            Me.pnlCabecera.Size = New System.Drawing.Size(834, 22)
            Me.pnlCabecera.TabIndex = 1
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(737, 3)
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
            Me.Label5.Location = New System.Drawing.Point(679, 3)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(50, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Código:"
            '
            'lblInterno
            '
            Me.lblInterno.AutoSize = True
            Me.lblInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInterno.Location = New System.Drawing.Point(68, 3)
            Me.lblInterno.Name = "lblInterno"
            Me.lblInterno.Size = New System.Drawing.Size(60, 13)
            Me.lblInterno.TabIndex = 1
            Me.lblInterno.Text = "lblInterno"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(7, 3)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(66, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Interno(a):"
            '
            'lblTitulo
            '
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 22)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(834, 18)
            Me.lblTitulo.TabIndex = 2
            Me.lblTitulo.Text = "TRASLADO A HOSPITAL DE SALUD MENTAL"
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 450)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(834, 41)
            Me.PnlInferior.TabIndex = 5
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(639, 41)
            Me.UscAuditUser1.TabIndex = 0
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(639, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 41)
            Me.PnlBotonesGrabar.TabIndex = 1
            '
            'btnAceptar
            '
            Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
            Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(95, 41)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(734, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 41)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
            Me.btnCancel.Location = New System.Drawing.Point(1, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Azure
            Me.GroupBox1.Controls.Add(Me.txtFechaProgramadaTraslado)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtFechaDocumento)
            Me.GroupBox1.Controls.Add(Me.txtNumDocumento)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.GroupBox1.Location = New System.Drawing.Point(4, 114)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(830, 55)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Referencia del Documento de Traslado"
            '
            'txtFechaProgramadaTraslado
            '
            Me.txtFechaProgramadaTraslado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaProgramadaTraslado._BloquearPaste = False
            Me.txtFechaProgramadaTraslado._SeleccionarTodo = False
            Me.txtFechaProgramadaTraslado.Location = New System.Drawing.Point(693, 20)
            Me.txtFechaProgramadaTraslado.MaxLength = 120
            Me.txtFechaProgramadaTraslado.Name = "txtFechaProgramadaTraslado"
            Me.txtFechaProgramadaTraslado.ReadOnly = True
            Me.txtFechaProgramadaTraslado.Size = New System.Drawing.Size(115, 20)
            Me.txtFechaProgramadaTraslado.TabIndex = 7
            Me.txtFechaProgramadaTraslado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaProgramadaTraslado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Azure
            Me.Label3.Location = New System.Drawing.Point(510, 23)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(172, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Fecha de inscripción del Traslado: "
            '
            'txtFechaDocumento
            '
            Me.txtFechaDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaDocumento._BloquearPaste = False
            Me.txtFechaDocumento._SeleccionarTodo = False
            Me.txtFechaDocumento.Location = New System.Drawing.Point(358, 19)
            Me.txtFechaDocumento.MaxLength = 120
            Me.txtFechaDocumento.Name = "txtFechaDocumento"
            Me.txtFechaDocumento.ReadOnly = True
            Me.txtFechaDocumento.Size = New System.Drawing.Size(140, 20)
            Me.txtFechaDocumento.TabIndex = 5
            Me.txtFechaDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtFechaDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(98, 20)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.ReadOnly = True
            Me.txtNumDocumento.Size = New System.Drawing.Size(161, 20)
            Me.txtNumDocumento.TabIndex = 4
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(267, 23)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(86, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Fec. Documento"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(85, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Nro. Documento"
            '
            'UscExpeDeResolucion
            '
            Me.UscExpeDeResolucion._CadenaPerpetua = False
            Me.UscExpeDeResolucion._DocumentoJudicialExpedienteID = -1
            Me.UscExpeDeResolucion._DocumentoJudicialID = -1
            Me.UscExpeDeResolucion._Documentos_sin_mov = False
            Me.UscExpeDeResolucion._FechaMovimiento = CType(0, Long)
            Me.UscExpeDeResolucion._FormEliminar = False
            Me.UscExpeDeResolucion._FormEscritura = False
            Me.UscExpeDeResolucion._InternoID = -1
            Me.UscExpeDeResolucion._InternoIngresoID = -1
            Me.UscExpeDeResolucion._InternoIngresoInpeId = -1
            Me.UscExpeDeResolucion._PenalID = -1
            Me.UscExpeDeResolucion._PermisoEliminar = False
            Me.UscExpeDeResolucion._RegionID = -1
            Me.UscExpeDeResolucion._SubTipo = -1
            Me.UscExpeDeResolucion._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscExpeDeResolucion._TipoResolucion = -1
            Me.UscExpeDeResolucion._TotalAnhos = "0"
            Me.UscExpeDeResolucion._TotalDias = "0"
            Me.UscExpeDeResolucion._TotalMes = "0"
            Me.UscExpeDeResolucion._VariableMov = 0
            Me.UscExpeDeResolucion._VisibleControlExpediente = False
            Me.UscExpeDeResolucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscExpeDeResolucion.chk_Queda = False
            Me.UscExpeDeResolucion.Estado_Documento_Judicial_exp = -1
            Me.UscExpeDeResolucion.Location = New System.Drawing.Point(4, 175)
            Me.UscExpeDeResolucion.Name = "UscExpeDeResolucion"
            Me.UscExpeDeResolucion.Size = New System.Drawing.Size(818, 277)
            Me.UscExpeDeResolucion.TabIndex = 4
            '
            'UscResolAclaratoriaExpe1
            '
            Me.UscResolAclaratoriaExpe1._blnNuevo = False
            Me.UscResolAclaratoriaExpe1._CodDocJud = -1
            Me.UscResolAclaratoriaExpe1._Codigo = -1
            Me.UscResolAclaratoriaExpe1._DocSubTipoID = -1
            Me.UscResolAclaratoriaExpe1._DocumentoTipo = -1
            Me.UscResolAclaratoriaExpe1._fechaejecucionMov = ""
            Me.UscResolAclaratoriaExpe1._InternoID = -1
            Me.UscResolAclaratoriaExpe1._InternoIngresoId = -1
            Me.UscResolAclaratoriaExpe1._InternoIngresoInpeId = -1
            Me.UscResolAclaratoriaExpe1._PenalID = -1
            Me.UscResolAclaratoriaExpe1._PermisoEliminar = False
            Me.UscResolAclaratoriaExpe1._Proceso_Pendiente_queda = -1
            Me.UscResolAclaratoriaExpe1._RegionID = -1
            Me.UscResolAclaratoriaExpe1._TipoAclaratoria = -1
            Me.UscResolAclaratoriaExpe1._TipoAclaratoriaCon = False
            Me.UscResolAclaratoriaExpe1._TipoAclaratoriaSeleccionado = -1
            Me.UscResolAclaratoriaExpe1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolAclaratoriaExpe1.ApellidoMaternoNA = ""
            Me.UscResolAclaratoriaExpe1.ApellidoPaternoNA = ""
            Me.UscResolAclaratoriaExpe1.AutoridadJuzgadonombre = ""
            Me.UscResolAclaratoriaExpe1.DistritoJudicial = 0
            Me.UscResolAclaratoriaExpe1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscResolAclaratoriaExpe1.Estado_Documento_Judicial = -1
            Me.UscResolAclaratoriaExpe1.FechaInscripcion = CType(0, Long)
            Me.UscResolAclaratoriaExpe1.FechaMovimiento = CType(0, Long)
            Me.UscResolAclaratoriaExpe1.idEstadoTraslado = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo
            Me.UscResolAclaratoriaExpe1.JuezNombre = ""
            Me.UscResolAclaratoriaExpe1.Location = New System.Drawing.Point(0, 40)
            Me.UscResolAclaratoriaExpe1.MovimientoMotivoId = -1
            Me.UscResolAclaratoriaExpe1.Name = "UscResolAclaratoriaExpe1"
            Me.UscResolAclaratoriaExpe1.NombresNA = ""
            Me.UscResolAclaratoriaExpe1.observacionEstEjecucion = Nothing
            Me.UscResolAclaratoriaExpe1.SalaJuzgado = 0
            Me.UscResolAclaratoriaExpe1.SalaJuzgadonombre = ""
            Me.UscResolAclaratoriaExpe1.SecretarioNombre = ""
            Me.UscResolAclaratoriaExpe1.Size = New System.Drawing.Size(834, 101)
            Me.UscResolAclaratoriaExpe1.TabIndex = 3
            Me.UscResolAclaratoriaExpe1.ValorEli = False
            Me.UscResolAclaratoriaExpe1.ValorRef = False
            Me.UscResolAclaratoriaExpe1.ValorVal = False
            '
            'frmOrdenTrasladoHospital_Nota
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(834, 491)
            Me.Name = "frmOrdenTrasladoHospital_Nota"
            Me.Text = "Traslado a Hospital de Salud Mental"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlCabecera As Panel
        Friend WithEvents lblCodInterno As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents lblInterno As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblTitulo As Label
        Friend WithEvents UscResolAclaratoriaExpe1 As APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe
        Friend WithEvents UscExpeDeResolucion As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents PnlInferior As Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents PnlBotonesGrabar As Panel
        Friend WithEvents btnAceptar As Button
        Friend WithEvents PnlBotones As Panel
        Friend WithEvents btnCancel As Button
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents txtFechaDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaProgramadaTraslado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As Label
    End Class
End Namespace