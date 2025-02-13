Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmResolSentenciaConmutacion
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
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotonesGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.UscDetallResolucionConmutacion1 = New APPControls.Registro.Sentencia.uscDetallResolucionConmutacion()
            Me.UscResolConmutacion1 = New APPControls.Registro.Sentencia.uscResolConmutacion()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.UscDetallResolucionConmutacion1)
            Me.gbxFormChildContainer.Controls.Add(Me.UscResolConmutacion1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(941, 564)
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(844, 3)
            Me.lblCodInterno.Name = "lblCodInterno"
            Me.lblCodInterno.Size = New System.Drawing.Size(82, 13)
            Me.lblCodInterno.TabIndex = 105
            Me.lblCodInterno.Text = "lblCodInterno"
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(786, 3)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(50, 13)
            Me.Label5.TabIndex = 105
            Me.Label5.Text = "Código:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(7, 3)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(66, 13)
            Me.Label4.TabIndex = 105
            Me.Label4.Text = "Interno(a):"
            '
            'lblInterno
            '
            Me.lblInterno.AutoSize = True
            Me.lblInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInterno.Location = New System.Drawing.Point(68, 3)
            Me.lblInterno.Name = "lblInterno"
            Me.lblInterno.Size = New System.Drawing.Size(60, 13)
            Me.lblInterno.TabIndex = 105
            Me.lblInterno.Text = "lblInterno"
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
            Me.Panel1.Size = New System.Drawing.Size(941, 22)
            Me.Panel1.TabIndex = 127
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 522)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(941, 42)
            Me.PnlInferior.TabIndex = 128
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(746, 42)
            Me.UscAuditUser1.TabIndex = 3
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(746, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 42)
            Me.PnlBotonesGrabar.TabIndex = 4
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(2, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(91, 39)
            Me.btnAceptar.TabIndex = 19
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(841, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 42)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(2, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 39)
            Me.btnCancel.TabIndex = 20
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.lblTitulo)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(941, 23)
            Me.pnlTitulo.TabIndex = 131
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(941, 3)
            Me.Label1.TabIndex = 111
            '
            'lblTitulo
            '
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(941, 18)
            Me.lblTitulo.TabIndex = 110
            Me.lblTitulo.Text = "RESOLUCION: CONMUTACION DE PENA"
            '
            'UscDetallResolucionConmutacion1
            '
            Me.UscDetallResolucionConmutacion1._DocumentoJudicialID = -1
            Me.UscDetallResolucionConmutacion1._Documentos_sin_mov = False
            Me.UscDetallResolucionConmutacion1._InternoId = -1
            Me.UscDetallResolucionConmutacion1._InternoIngresoId = -1
            Me.UscDetallResolucionConmutacion1._InternoIngresoInpeId = -1
            Me.UscDetallResolucionConmutacion1._PenalID = -1
            Me.UscDetallResolucionConmutacion1._RegionID = -1
            Me.UscDetallResolucionConmutacion1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscDetallResolucionConmutacion1._TipoResolucion = -1
            Me.UscDetallResolucionConmutacion1._TotalAnhos = ""
            Me.UscDetallResolucionConmutacion1._TotalDias = ""
            Me.UscDetallResolucionConmutacion1._TotalMes = ""
            Me.UscDetallResolucionConmutacion1.btnAgregar = True
            Me.UscDetallResolucionConmutacion1.btnAgregarPerido = True
            Me.UscDetallResolucionConmutacion1.btnCajasPeriodo = False
            Me.UscDetallResolucionConmutacion1.btnEliminar = True
            Me.UscDetallResolucionConmutacion1.btnModificar = True
            Me.UscDetallResolucionConmutacion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscDetallResolucionConmutacion1.Location = New System.Drawing.Point(0, 228)
            Me.UscDetallResolucionConmutacion1.Name = "UscDetallResolucionConmutacion1"
            Me.UscDetallResolucionConmutacion1.Size = New System.Drawing.Size(941, 294)
            Me.UscDetallResolucionConmutacion1.TabIndex = 134
            '
            'UscResolConmutacion1
            '
            Me.UscResolConmutacion1._blnNuevo = False
            Me.UscResolConmutacion1._CodDocJud = -1
            Me.UscResolConmutacion1._Codigo = -1
            Me.UscResolConmutacion1._DocSubTipoID = -1
            Me.UscResolConmutacion1._DocumentoTipo = -1
            Me.UscResolConmutacion1._InternoID = -1
            Me.UscResolConmutacion1._InternoIngresoId = -1
            Me.UscResolConmutacion1._InternoIngresoInpeId = -1
            Me.UscResolConmutacion1._PenalID = -1
            Me.UscResolConmutacion1._PermisoEliminar = False
            Me.UscResolConmutacion1._RegionID = -1
            Me.UscResolConmutacion1._TipoAclaratoria = -1
            Me.UscResolConmutacion1._TipoAclaratoriaCon = False
            Me.UscResolConmutacion1._TipoAclaratoriaSeleccionado = -1
            Me.UscResolConmutacion1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscResolConmutacion1.ApellidoMaternoNA = ""
            Me.UscResolConmutacion1.ApellidoPaternoNA = ""
            Me.UscResolConmutacion1.AutoridadJuzgadonombre = ""
            Me.UscResolConmutacion1.DistritoJudicial = 0
            Me.UscResolConmutacion1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UscResolConmutacion1.FechaMovimiento = CType(0, Long)
            Me.UscResolConmutacion1.JuezNombre = ""
            Me.UscResolConmutacion1.Location = New System.Drawing.Point(0, 45)
            Me.UscResolConmutacion1.Name = "UscResolConmutacion1"
            Me.UscResolConmutacion1.NombresNA = ""
            Me.UscResolConmutacion1.SalaJuzgado = 0
            Me.UscResolConmutacion1.SalaJuzgadonombre = ""
            Me.UscResolConmutacion1.SecretarioNombre = ""
            Me.UscResolConmutacion1.Size = New System.Drawing.Size(941, 183)
            Me.UscResolConmutacion1.TabIndex = 133
            Me.UscResolConmutacion1.ValorEli = False
            Me.UscResolConmutacion1.ValorRef = False
            Me.UscResolConmutacion1.ValorVal = False
            '
            'frmResolSentenciaConmutacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(941, 564)
            Me.Name = "frmResolSentenciaConmutacion"
            Me.Text = "Sentencia"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlTitulo.ResumeLayout(False)
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
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents UscDetallResolucionConmutacion1 As APPControls.Registro.Sentencia.uscDetallResolucionConmutacion
        Friend WithEvents UscResolConmutacion1 As APPControls.Registro.Sentencia.uscResolConmutacion
    End Class

End Namespace