Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolAmpliaAutoapert
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
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotonesGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.UscExpeDeResolucion = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.UscResolAclaratoriaNombresAsoc1 = New APPControls.uscResolAclaratoriaNombresAsoc()
            Me.UscResolAclaratoriaExpe1 = New APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.UscResolAclaratoriaNombresAsoc1)
            Me.gbxFormChildContainer.Controls.Add(Me.UscExpeDeResolucion)
            Me.gbxFormChildContainer.Controls.Add(Me.UscResolAclaratoriaExpe1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(807, 608)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 608)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(807, 43)
            Me.PnlInferior.TabIndex = 103
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(612, 43)
            Me.UscAuditUser1.TabIndex = 0
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(612, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 43)
            Me.PnlBotonesGrabar.TabIndex = 2
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(2, 2)
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
            Me.PnlBotones.Location = New System.Drawing.Point(707, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 43)
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
            Me.Panel1.Size = New System.Drawing.Size(807, 22)
            Me.Panel1.TabIndex = 0
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(692, 3)
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
            Me.Label5.Location = New System.Drawing.Point(640, 3)
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
            Me.UscExpeDeResolucion.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscExpeDeResolucion.Location = New System.Drawing.Point(0, 235)
            Me.UscExpeDeResolucion.Name = "UscExpeDeResolucion"
            Me.UscExpeDeResolucion.Size = New System.Drawing.Size(807, 250)
            Me.UscExpeDeResolucion.TabIndex = 3
            '
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.Label2)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(807, 23)
            Me.pnlTitulo.TabIndex = 126
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(807, 3)
            Me.Label1.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(807, 18)
            Me.Label2.TabIndex = 110
            Me.Label2.Text = "RESOLUCION: AMPLIACION DE AUTOAPERTORIO"
            '
            'UscResolAclaratoriaNombresAsoc1
            '
            Me.UscResolAclaratoriaNombresAsoc1._CodDocJud = -1
            Me.UscResolAclaratoriaNombresAsoc1._Codigo = -1
            Me.UscResolAclaratoriaNombresAsoc1._DocumentoJudicialID = -1
            Me.UscResolAclaratoriaNombresAsoc1._DocumentoSubTipoId = -1
            Me.UscResolAclaratoriaNombresAsoc1._DocumentoTipoId = -1
            Me.UscResolAclaratoriaNombresAsoc1._InternoID = -1
            Me.UscResolAclaratoriaNombresAsoc1._InternoIngresoId = -1
            Me.UscResolAclaratoriaNombresAsoc1._InternoIngresoInpeId = -1
            Me.UscResolAclaratoriaNombresAsoc1._InternoNAIngresoId = -1
            Me.UscResolAclaratoriaNombresAsoc1._InternoNAIngresoInpeId = -1
            Me.UscResolAclaratoriaNombresAsoc1._PenalID = -1
            Me.UscResolAclaratoriaNombresAsoc1._ReferenciaEnablet = False
            Me.UscResolAclaratoriaNombresAsoc1._RegionID = -1
            Me.UscResolAclaratoriaNombresAsoc1._TipoAclaratoria = -1
            Me.UscResolAclaratoriaNombresAsoc1._TipoAclaratoriaCon = False
            Me.UscResolAclaratoriaNombresAsoc1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolAclaratoriaNombresAsoc1._ValorReferencia = False
            Me.UscResolAclaratoriaNombresAsoc1.ApellidoMaternoNA = ""
            Me.UscResolAclaratoriaNombresAsoc1.ApellidoPaternoNA = ""
            Me.UscResolAclaratoriaNombresAsoc1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscResolAclaratoriaNombresAsoc1.Location = New System.Drawing.Point(0, 485)
            Me.UscResolAclaratoriaNombresAsoc1.Name = "UscResolAclaratoriaNombresAsoc1"
            Me.UscResolAclaratoriaNombresAsoc1.NombresNA = ""
            Me.UscResolAclaratoriaNombresAsoc1.Size = New System.Drawing.Size(807, 123)
            Me.UscResolAclaratoriaNombresAsoc1.TabIndex = 127
            Me.UscResolAclaratoriaNombresAsoc1.ValorEli = False
            Me.UscResolAclaratoriaNombresAsoc1.ValorVal = False
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
            Me.UscResolAclaratoriaExpe1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscResolAclaratoriaExpe1.FechaMovimiento = CType(0, Long)
            Me.UscResolAclaratoriaExpe1.JuezNombre = ""
            Me.UscResolAclaratoriaExpe1.Location = New System.Drawing.Point(0, 45)
            Me.UscResolAclaratoriaExpe1.MovimientoMotivoId = -1
            Me.UscResolAclaratoriaExpe1.Name = "UscResolAclaratoriaExpe1"
            Me.UscResolAclaratoriaExpe1.NombresNA = ""
            Me.UscResolAclaratoriaExpe1.SalaJuzgado = 0
            Me.UscResolAclaratoriaExpe1.SalaJuzgadonombre = ""
            Me.UscResolAclaratoriaExpe1.SecretarioNombre = ""
            Me.UscResolAclaratoriaExpe1.Size = New System.Drawing.Size(807, 190)
            Me.UscResolAclaratoriaExpe1.TabIndex = 0
            Me.UscResolAclaratoriaExpe1.ValorEli = False
            Me.UscResolAclaratoriaExpe1.ValorRef = False
            Me.UscResolAclaratoriaExpe1.ValorVal = False
            '
            'frmResolAmpliaAutoapert
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(807, 651)
            Me.Controls.Add(Me.PnlInferior)
            Me.Name = "frmResolAmpliaAutoapert"
            Me.Text = "Resolución de ampliación de autoapertorio"
            Me.Controls.SetChildIndex(Me.PnlInferior, 0)
            Me.Controls.SetChildIndex(Me.gbxFormChildContainer, 0)
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlTitulo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblCodInterno As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblInterno As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents UscExpeDeResolucion As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents UscResolAclaratoriaNombresAsoc1 As APPControls.uscResolAclaratoriaNombresAsoc
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents UscResolAclaratoriaExpe1 As APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe
    End Class
End Namespace