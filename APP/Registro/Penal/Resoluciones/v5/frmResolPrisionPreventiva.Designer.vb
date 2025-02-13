Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolPrisionPreventiva
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
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.UscResolIngreso1 = New APPControls.Registro.Resoluciones.uscResolIngreso()
            Me.UscResolProlongDetencion1 = New APPControls.Registro.Resoluciones.uscPeriodoDetencion()
            Me.UscMovimientoDetalle21 = New APPControls.Registro.uscMovimientoDetalle2()
            Me.UscExpeDeResolucion1 = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.UscMovimientoDetalle21)
            Me.gbxFormChildContainer.Controls.Add(Me.UscExpeDeResolucion1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlCabecera)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(957, 490)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 443)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(957, 47)
            Me.PnlInferior.TabIndex = 5
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(762, 47)
            Me.UscAuditUser1.TabIndex = 0
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(762, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 47)
            Me.PnlBotonesGrabar.TabIndex = 1
            '
            'btnAceptar
            '
            Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(91, 47)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(857, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 47)
            Me.PnlBotones.TabIndex = 2
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(3, 0)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 47)
            Me.btnCancel.TabIndex = 0
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
            Me.pnlCabecera.Size = New System.Drawing.Size(957, 22)
            Me.pnlCabecera.TabIndex = 0
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(860, 3)
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
            Me.Label5.Location = New System.Drawing.Point(806, 3)
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
            Me.pnlTitulo.Controls.Add(Me.lblTitulo)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(957, 23)
            Me.pnlTitulo.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(957, 3)
            Me.Label1.TabIndex = 1
            '
            'lblTitulo
            '
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(957, 18)
            Me.lblTitulo.TabIndex = 0
            Me.lblTitulo.Text = "RESOLUCION: INGRESO POR PRISION PREVENTIVA"
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.GroupBox2)
            Me.Panel3.Controls.Add(Me.UscResolProlongDetencion1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 45)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(611, 141)
            Me.Panel3.TabIndex = 2
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.UscResolIngreso1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(405, 141)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            '
            'UscResolIngreso1
            '
            Me.UscResolIngreso1._blnNuevo = False
            Me.UscResolIngreso1._Codigo = -1
            Me.UscResolIngreso1._DistritoJudicialID = -1
            Me.UscResolIngreso1._DistritoJudicialNombre = ""
            Me.UscResolIngreso1._InternoId = -1
            Me.UscResolIngreso1._InternoIngresoId = -1
            Me.UscResolIngreso1._InternoIngresoInpeId = -1
            Me.UscResolIngreso1._Juez = ""
            Me.UscResolIngreso1._MovimientoMotivo = -1
            Me.UscResolIngreso1._OtraAutoridadCargo = ""
            Me.UscResolIngreso1._OtraAutoridadNombre = ""
            Me.UscResolIngreso1._PenalID = -1
            Me.UscResolIngreso1._RegionID = -1
            Me.UscResolIngreso1._SalaJuzgado = -1
            Me.UscResolIngreso1._SalaJuzgadoNombre = ""
            Me.UscResolIngreso1._Secretario = ""
            Me.UscResolIngreso1._SituacionJuridicaId = -1
            Me.UscResolIngreso1._TipoAutoridadJudicialID = -1
            Me.UscResolIngreso1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolIngreso1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscResolIngreso1.DocumentoFecha = CType(0, Long)
            Me.UscResolIngreso1.DocumentoFechaRecepcion = CType(0, Long)
            Me.UscResolIngreso1.DocumentoJudicialPenalOrigen = ""
            Me.UscResolIngreso1.DocumentoNumero = ""
            Me.UscResolIngreso1.DocumentoSubTipo = -1
            Me.UscResolIngreso1.FechadeIngresoPenalOrigen = CType(0, Long)
            Me.UscResolIngreso1.FechaInternamientoPenalOrigen = CType(0, Long)
            Me.UscResolIngreso1.FechaMovimiento = CType(0, Long)
            Me.UscResolIngreso1.Location = New System.Drawing.Point(3, 16)
            Me.UscResolIngreso1.Name = "UscResolIngreso1"
            Me.UscResolIngreso1.Observacion = ""
            Me.UscResolIngreso1.ObservacionPenalOrigen = ""
            Me.UscResolIngreso1.PenalDestino = -1
            Me.UscResolIngreso1.RegionDestino = -1
            Me.UscResolIngreso1.Size = New System.Drawing.Size(399, 122)
            Me.UscResolIngreso1.TabIndex = 0
            '
            'UscResolProlongDetencion1
            '
            Me.UscResolProlongDetencion1._blnNuevo = False
            Me.UscResolProlongDetencion1._Codigo = -1
            Me.UscResolProlongDetencion1._DocumentoTipo = 0
            Me.UscResolProlongDetencion1._InternoId = -1
            Me.UscResolProlongDetencion1._InternoIngresoId = -1
            Me.UscResolProlongDetencion1._PenalID = -1
            Me.UscResolProlongDetencion1._RegionID = -1
            Me.UscResolProlongDetencion1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolProlongDetencion1.Dock = System.Windows.Forms.DockStyle.Right
            Me.UscResolProlongDetencion1.Location = New System.Drawing.Point(405, 0)
            Me.UscResolProlongDetencion1.Name = "UscResolProlongDetencion1"
            Me.UscResolProlongDetencion1.ProlonDetencionFechFin = CType(0, Long)
            Me.UscResolProlongDetencion1.ProlonDetencionFechIni = CType(0, Long)
            Me.UscResolProlongDetencion1.ProlonDetencionTipoUnidad = ""
            Me.UscResolProlongDetencion1.ProlonDetencionValor = 0
            Me.UscResolProlongDetencion1.Size = New System.Drawing.Size(206, 141)
            Me.UscResolProlongDetencion1.TabIndex = 1
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
            Me.UscMovimientoDetalle21.Location = New System.Drawing.Point(611, 45)
            Me.UscMovimientoDetalle21.Name = "UscMovimientoDetalle21"
            Me.UscMovimientoDetalle21.Size = New System.Drawing.Size(346, 141)
            Me.UscMovimientoDetalle21.TabIndex = 3
            '
            'UscExpeDeResolucion1
            '
            Me.UscExpeDeResolucion1._DocumentoJudicialExpedienteID = -1
            Me.UscExpeDeResolucion1._DocumentoJudicialID = -1
            Me.UscExpeDeResolucion1._Documentos_sin_mov = False
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
            Me.UscExpeDeResolucion1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscExpeDeResolucion1.Location = New System.Drawing.Point(0, 186)
            Me.UscExpeDeResolucion1.Name = "UscExpeDeResolucion1"
            Me.UscExpeDeResolucion1.Size = New System.Drawing.Size(957, 257)
            Me.UscExpeDeResolucion1.TabIndex = 4
            '
            'frmResolPrisionPreventiva
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(957, 490)
            Me.Name = "frmResolPrisionPreventiva"
            Me.Text = "Resolución de prisión preventiva"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.pnlTitulo.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
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
        Friend WithEvents UscExpeDeResolucion1 As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents UscMovimientoDetalle21 As APPControls.Registro.uscMovimientoDetalle2
        Friend WithEvents UscResolProlongDetencion1 As APPControls.Registro.Resoluciones.uscPeriodoDetencion
        Friend WithEvents UscResolIngreso1 As APPControls.Registro.Resoluciones.uscResolIngreso
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    End Class
End Namespace