Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolProlongDetencion
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotonesGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.UscExpeDeResolucion = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.uscResolProlongDetencion = New APPControls.Registro.Resoluciones.uscPeriodoDetencion()
            Me.UscResolAclaratoriaExpe1 = New APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(913, 525)
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.lblCodInterno)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.lblInterno)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(913, 22)
            Me.Panel1.TabIndex = 0
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(809, 3)
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
            Me.Label5.Location = New System.Drawing.Point(745, 3)
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
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 483)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(913, 42)
            Me.PnlInferior.TabIndex = 4
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(718, 42)
            Me.UscAuditUser1.TabIndex = 0
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(718, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 42)
            Me.PnlBotonesGrabar.TabIndex = 1
            '
            'btnAceptar
            '
            Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(95, 42)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(813, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 42)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(1, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 39)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'UscExpeDeResolucion
            '
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
            Me.UscExpeDeResolucion._VariableMov = 0
            Me.UscExpeDeResolucion._VisibleControlExpediente = False
            Me.UscExpeDeResolucion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscExpeDeResolucion.Location = New System.Drawing.Point(0, 0)
            Me.UscExpeDeResolucion.Name = "UscExpeDeResolucion"
            Me.UscExpeDeResolucion.Size = New System.Drawing.Size(913, 257)
            Me.UscExpeDeResolucion.TabIndex = 0
            '
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.lblTitulo)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(913, 23)
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
            Me.Label1.Size = New System.Drawing.Size(913, 3)
            Me.Label1.TabIndex = 1
            '
            'lblTitulo
            '
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(913, 18)
            Me.lblTitulo.TabIndex = 0
            Me.lblTitulo.Text = "RESOLUCION: PROLONGACION DE DETENCION"
            '
            'uscResolProlongDetencion
            '
            Me.uscResolProlongDetencion._blnNuevo = False
            Me.uscResolProlongDetencion._Codigo = -1
            Me.uscResolProlongDetencion._DocumentoTipo = 10
            Me.uscResolProlongDetencion._InternoId = -1
            Me.uscResolProlongDetencion._InternoIngresoId = -1
            Me.uscResolProlongDetencion._PenalID = -1
            Me.uscResolProlongDetencion._RegionID = -1
            Me.uscResolProlongDetencion._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscResolProlongDetencion.Dock = System.Windows.Forms.DockStyle.Right
            Me.uscResolProlongDetencion.Location = New System.Drawing.Point(698, 0)
            Me.uscResolProlongDetencion.Name = "uscResolProlongDetencion"
            Me.uscResolProlongDetencion.ProlonDetencionFechFin = CType(0, Long)
            Me.uscResolProlongDetencion.ProlonDetencionFechIni = CType(0, Long)
            Me.uscResolProlongDetencion.ProlonDetencionTipoUnidad = ""
            Me.uscResolProlongDetencion.ProlonDetencionValor = 0
            Me.uscResolProlongDetencion.Size = New System.Drawing.Size(215, 181)
            Me.uscResolProlongDetencion.TabIndex = 3
            '
            'UscResolAclaratoriaExpe1
            '
            Me.UscResolAclaratoriaExpe1._blnNuevo = False
            Me.UscResolAclaratoriaExpe1._CodDocJud = -1
            Me.UscResolAclaratoriaExpe1._Codigo = -1
            Me.UscResolAclaratoriaExpe1._DocSubTipoID = -1
            Me.UscResolAclaratoriaExpe1._DocumentoTipo = -1
            Me.UscResolAclaratoriaExpe1._InternoID = -1
            Me.UscResolAclaratoriaExpe1._InternoIngresoId = -1
            Me.UscResolAclaratoriaExpe1._InternoIngresoInpeId = -1
            Me.UscResolAclaratoriaExpe1._PenalID = -1
            Me.UscResolAclaratoriaExpe1._PermisoEliminar = False
            Me.UscResolAclaratoriaExpe1._RegionID = -1
            Me.UscResolAclaratoriaExpe1._TipoAclaratoria = -1
            Me.UscResolAclaratoriaExpe1._TipoAclaratoriaCon = False
            Me.UscResolAclaratoriaExpe1._TipoAclaratoriaSeleccionado = -1
            Me.UscResolAclaratoriaExpe1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolAclaratoriaExpe1.ApellidoMaternoNA = ""
            Me.UscResolAclaratoriaExpe1.ApellidoPaternoNA = ""
            Me.UscResolAclaratoriaExpe1.AutoridadJuzgadonombre = ""
            Me.UscResolAclaratoriaExpe1.DistritoJudicial = 0
            Me.UscResolAclaratoriaExpe1.Dock = System.Windows.Forms.DockStyle.Fill
            'Me.UscResolAclaratoriaExpe1.EstadoEjecucionId = 0
            Me.UscResolAclaratoriaExpe1.FechaMovimiento = CType(0, Long)
            Me.UscResolAclaratoriaExpe1.JuezNombre = ""
            Me.UscResolAclaratoriaExpe1.Location = New System.Drawing.Point(0, 0)
            Me.UscResolAclaratoriaExpe1.MovimientoMotivoId = -1
            Me.UscResolAclaratoriaExpe1.Name = "UscResolAclaratoriaExpe1"
            Me.UscResolAclaratoriaExpe1.NombresNA = ""
            Me.UscResolAclaratoriaExpe1.SalaJuzgado = 0
            Me.UscResolAclaratoriaExpe1.SalaJuzgadonombre = ""
            Me.UscResolAclaratoriaExpe1.SecretarioNombre = ""
            Me.UscResolAclaratoriaExpe1.Size = New System.Drawing.Size(698, 181)
            Me.UscResolAclaratoriaExpe1.TabIndex = 2
            Me.UscResolAclaratoriaExpe1.ValorEli = False
            Me.UscResolAclaratoriaExpe1.ValorRef = False
            Me.UscResolAclaratoriaExpe1.ValorVal = False
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscResolAclaratoriaExpe1)
            Me.Panel2.Controls.Add(Me.uscResolProlongDetencion)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 45)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(913, 181)
            Me.Panel2.TabIndex = 2
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.UscExpeDeResolucion)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 226)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(913, 257)
            Me.Panel3.TabIndex = 3
            '
            'frmResolProlongDetencion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(913, 525)
            Me.Name = "frmResolProlongDetencion"
            Me.Text = "Resolución de prolongación de detención"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlTitulo.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblCodInterno As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblInterno As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents UscExpeDeResolucion As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents uscResolProlongDetencion As APPControls.Registro.Resoluciones.uscPeriodoDetencion
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents UscResolAclaratoriaExpe1 As APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe
    End Class

End Namespace