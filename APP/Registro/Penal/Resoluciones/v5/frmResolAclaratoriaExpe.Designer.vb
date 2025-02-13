Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolAclaratoriaExpe
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
            Me.PnlGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.UscExpeDeResolucion = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.UscResolAclaratoriaNombresAsoc1 = New APPControls.uscResolAclaratoriaNombresAsoc()
            Me.uscResolAclaratoria = New APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlGrabar.SuspendLayout()
            Me.PnlBotones2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.UscExpeDeResolucion)
            Me.gbxFormChildContainer.Controls.Add(Me.UscResolAclaratoriaNombresAsoc1)
            Me.gbxFormChildContainer.Controls.Add(Me.uscResolAclaratoria)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(807, 635)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones2)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 592)
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
            'PnlGrabar
            '
            Me.PnlGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlGrabar.Location = New System.Drawing.Point(612, 0)
            Me.PnlGrabar.Name = "PnlGrabar"
            Me.PnlGrabar.Size = New System.Drawing.Size(95, 43)
            Me.PnlGrabar.TabIndex = 0
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 2)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(91, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones2
            '
            Me.PnlBotones2.Controls.Add(Me.btnCancel)
            Me.PnlBotones2.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones2.Location = New System.Drawing.Point(707, 0)
            Me.PnlBotones2.Name = "PnlBotones2"
            Me.PnlBotones2.Size = New System.Drawing.Size(100, 43)
            Me.PnlBotones2.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(2, 2)
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
            Me.lblCodInterno.Location = New System.Drawing.Point(671, 3)
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
            Me.Label5.Location = New System.Drawing.Point(615, 3)
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
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.Label2)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(807, 23)
            Me.pnlTitulo.TabIndex = 125
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
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "RESOLUCION: ACLARATORIA"
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
            Me.UscExpeDeResolucion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscExpeDeResolucion.Location = New System.Drawing.Point(0, 232)
            Me.UscExpeDeResolucion.Name = "UscExpeDeResolucion"
            Me.UscExpeDeResolucion.Size = New System.Drawing.Size(807, 245)
            Me.UscExpeDeResolucion.TabIndex = 2
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
            Me.UscResolAclaratoriaNombresAsoc1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscResolAclaratoriaNombresAsoc1.Location = New System.Drawing.Point(0, 477)
            Me.UscResolAclaratoriaNombresAsoc1.Name = "UscResolAclaratoriaNombresAsoc1"
            Me.UscResolAclaratoriaNombresAsoc1.NombresNA = ""
            Me.UscResolAclaratoriaNombresAsoc1.Size = New System.Drawing.Size(807, 115)
            Me.UscResolAclaratoriaNombresAsoc1.TabIndex = 3
            Me.UscResolAclaratoriaNombresAsoc1.ValorEli = False
            Me.UscResolAclaratoriaNombresAsoc1.ValorVal = False
            '
            'uscResolAclaratoria
            '
            Me.uscResolAclaratoria._blnNuevo = False
            Me.uscResolAclaratoria._CodDocJud = -1
            Me.uscResolAclaratoria._Codigo = -1
            Me.uscResolAclaratoria._DocSubTipoID = -1
            Me.uscResolAclaratoria._DocumentoTipo = -1
            Me.uscResolAclaratoria._InternoID = -1
            Me.uscResolAclaratoria._InternoIngresoId = -1
            Me.uscResolAclaratoria._InternoIngresoInpeId = -1
            Me.uscResolAclaratoria._PenalID = -1
            Me.uscResolAclaratoria._PermisoEliminar = False
            Me.uscResolAclaratoria._RegionID = -1
            Me.uscResolAclaratoria._TipoAclaratoria = -1
            Me.uscResolAclaratoria._TipoAclaratoriaCon = False
            Me.uscResolAclaratoria._TipoAclaratoriaSeleccionado = -1
            Me.uscResolAclaratoria._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscResolAclaratoria.ApellidoMaternoNA = ""
            Me.uscResolAclaratoria.ApellidoPaternoNA = ""
            Me.uscResolAclaratoria.AutoridadJuzgadonombre = ""
            Me.uscResolAclaratoria.DistritoJudicial = 0
            Me.uscResolAclaratoria.Dock = System.Windows.Forms.DockStyle.Top
            Me.uscResolAclaratoria.FechaMovimiento = CType(0, Long)
            Me.uscResolAclaratoria.JuezNombre = ""
            Me.uscResolAclaratoria.Location = New System.Drawing.Point(0, 45)
            Me.uscResolAclaratoria.MovimientoMotivoId = -1
            Me.uscResolAclaratoria.Name = "uscResolAclaratoria"
            Me.uscResolAclaratoria.NombresNA = ""
            Me.uscResolAclaratoria.SalaJuzgado = 0
            Me.uscResolAclaratoria.SalaJuzgadonombre = ""
            Me.uscResolAclaratoria.SecretarioNombre = ""
            Me.uscResolAclaratoria.Size = New System.Drawing.Size(807, 187)
            Me.uscResolAclaratoria.TabIndex = 1
            Me.uscResolAclaratoria.ValorEli = False
            Me.uscResolAclaratoria.ValorRef = False
            Me.uscResolAclaratoria.ValorVal = False
            '
            'frmResolAclaratoriaExpe
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(807, 635)
            Me.Name = "frmResolAclaratoriaExpe"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.Text = "Resolución de aclaratoria"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlGrabar.ResumeLayout(False)
            Me.PnlBotones2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlTitulo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents PnlBotones2 As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblCodInterno As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblInterno As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents UscExpeDeResolucion As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents uscResolAclaratoria As APPControls.Registro.Resoluciones.uscResolAclaratoriaExpe
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents UscResolAclaratoriaNombresAsoc1 As APPControls.uscResolAclaratoriaNombresAsoc
    End Class
End Namespace