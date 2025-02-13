Namespace Registro.RegionLima.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolIngreso
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
            Me.PnlGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.UscExpeDeResolucionIng1 = New APPControls.Registro.Documento.uscExpeDeResolucionIng()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.uscResolIngreso = New APPControls.Registro.Resoluciones.uscResolIngreso()
            Me.UscResolucionesDetalle1 = New APPControls.Registro.Resoluciones.v5.uscResolucionesDetalle()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(901, 546)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 505)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(901, 41)
            Me.PnlInferior.TabIndex = 4
            '
            'PnlGrabar
            '
            Me.PnlGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlGrabar.Location = New System.Drawing.Point(706, 0)
            Me.PnlGrabar.Name = "PnlGrabar"
            Me.PnlGrabar.Size = New System.Drawing.Size(95, 41)
            Me.PnlGrabar.TabIndex = 1
            '
            'btnAceptar
            '
            Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
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
            Me.PnlBotones.Location = New System.Drawing.Point(801, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 41)
            Me.PnlBotones.TabIndex = 2
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(0, 0)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(100, 41)
            Me.btnCancel.TabIndex = 0
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
            Me.Panel1.Size = New System.Drawing.Size(901, 22)
            Me.Panel1.TabIndex = 0
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(804, 3)
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
            Me.Label5.Location = New System.Drawing.Point(746, 3)
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
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(3, 3)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(66, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Interno(a):"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel4)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 45)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(901, 141)
            Me.Panel2.TabIndex = 2
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.uscResolIngreso)
            Me.Panel4.Controls.Add(Me.UscResolucionesDetalle1)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(901, 141)
            Me.Panel4.TabIndex = 0
            '
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.lblTitulo)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(901, 23)
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
            Me.Label1.Size = New System.Drawing.Size(901, 3)
            Me.Label1.TabIndex = 0
            '
            'lblTitulo
            '
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblTitulo.Location = New System.Drawing.Point(2, 3)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(795, 23)
            Me.lblTitulo.TabIndex = 0
            Me.lblTitulo.Text = "RESOLUCION: INGRESO"
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.UscExpeDeResolucionIng1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 186)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(901, 319)
            Me.Panel3.TabIndex = 3
            '
            'UscExpeDeResolucionIng1
            '
            Me.UscExpeDeResolucionIng1._DocumentoJudicialExpedienteID = -1
            Me.UscExpeDeResolucionIng1._DocumentoJudicialID = -1
            Me.UscExpeDeResolucionIng1._Documentos_sin_mov = False
            Me.UscExpeDeResolucionIng1._FechaMovimiento = CType(0, Long)
            Me.UscExpeDeResolucionIng1._FormEliminar = False
            Me.UscExpeDeResolucionIng1._FormEscritura = False
            Me.UscExpeDeResolucionIng1._InternoID = -1
            Me.UscExpeDeResolucionIng1._InternoIngresoID = -1
            Me.UscExpeDeResolucionIng1._InternoIngresoInpeId = -1
            Me.UscExpeDeResolucionIng1._PenalID = -1
            Me.UscExpeDeResolucionIng1._PermisoEliminar = False
            Me.UscExpeDeResolucionIng1._RegionID = -1
            Me.UscExpeDeResolucionIng1._SubTipo = -1
            Me.UscExpeDeResolucionIng1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscExpeDeResolucionIng1._TipoResolucion = -1
            Me.UscExpeDeResolucionIng1._VariableMov = 0
            Me.UscExpeDeResolucionIng1._VisibleControlExpediente = False
            Me.UscExpeDeResolucionIng1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscExpeDeResolucionIng1.Location = New System.Drawing.Point(0, 0)
            Me.UscExpeDeResolucionIng1.Name = "UscExpeDeResolucionIng1"
            Me.UscExpeDeResolucionIng1.Size = New System.Drawing.Size(901, 319)
            Me.UscExpeDeResolucionIng1.TabIndex = 3
            Me.UscExpeDeResolucionIng1.TotalAnios = "0"
            Me.UscExpeDeResolucionIng1.TotalDias = "0"
            Me.UscExpeDeResolucionIng1.TotalMeses = "0"
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(706, 41)
            Me.UscAuditUser1.TabIndex = 0
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
            Me.uscResolIngreso.EstablecimentomentalId = -1
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
            Me.uscResolIngreso.Size = New System.Drawing.Size(554, 141)
            Me.uscResolIngreso.TabIndex = 0
            Me.uscResolIngreso.TotalAnios = 0
            Me.uscResolIngreso.TotalDias = 0
            Me.uscResolIngreso.TotalMeses = 0
            '
            'UscResolucionesDetalle1
            '
            Me.UscResolucionesDetalle1._blnNuevo = False
            Me.UscResolucionesDetalle1._Codigo = -1
            Me.UscResolucionesDetalle1._DocumJudicialD = -1
            Me.UscResolucionesDetalle1._IngresoInpeID = -1
            Me.UscResolucionesDetalle1._intCondicionGrupo = -1
            Me.UscResolucionesDetalle1._InternoID = -1
            Me.UscResolucionesDetalle1._MovimientoGrupo = -1
            Me.UscResolucionesDetalle1._MovimientoMotivo = 0
            Me.UscResolucionesDetalle1._MovimientoTipo = 0
            Me.UscResolucionesDetalle1._PenalDestino = 0
            Me.UscResolucionesDetalle1._PenalID = -1
            Me.UscResolucionesDetalle1._PenalID1 = -1
            Me.UscResolucionesDetalle1._RegionDestino = 0
            Me.UscResolucionesDetalle1._RegionID = -1
            Me.UscResolucionesDetalle1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolucionesDetalle1.Dock = System.Windows.Forms.DockStyle.Right
            Me.UscResolucionesDetalle1.DocumentoTipo = -1
            Me.UscResolucionesDetalle1.Location = New System.Drawing.Point(554, 0)
            Me.UscResolucionesDetalle1.Name = "UscResolucionesDetalle1"
            Me.UscResolucionesDetalle1.Size = New System.Drawing.Size(347, 141)
            Me.UscResolucionesDetalle1.TabIndex = 1
            '
            'frmResolIngreso
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(901, 546)
            Me.Name = "frmResolIngreso"
            Me.Text = "Resolución de ingreso"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.pnlTitulo.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
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
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents PnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents uscResolIngreso As APPControls.Registro.Resoluciones.uscResolIngreso
        Friend WithEvents UscResolucionesDetalle1 As APPControls.Registro.Resoluciones.v5.uscResolucionesDetalle
        Friend WithEvents UscExpeDeResolucionIng1 As APPControls.Registro.Documento.uscExpeDeResolucionIng
    End Class
End Namespace