Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolIntegracionSent
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
        Me.lblCodInterno = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblInterno = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UscDetallResolucionIntegracionSent1 = New APPControls.Registro.Sentencias.uscDetallResolucionIntegracionSent()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.UsrResolSentencia1 = New APPControls.Registro.Sentencia.usrResolSentencia()
        Me.gbxFormChildContainer.SuspendLayout
        Me.PnlInferior.SuspendLayout
        Me.PnlBotonesGrabar.SuspendLayout
        Me.PnlBotones.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.pnlTitulo.SuspendLayout
        Me.SuspendLayout
        '
        'gbxFormChildContainer
        '
        Me.gbxFormChildContainer.Controls.Add(Me.UsrResolSentencia1)
        Me.gbxFormChildContainer.Controls.Add(Me.UscDetallResolucionIntegracionSent1)
        Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
        Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
        Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(914, 563)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesGrabar)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 522)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(914, 41)
            Me.PnlInferior.TabIndex = 4
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(719, 41)
            Me.UscAuditUser1.TabIndex = 0
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(719, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 41)
            Me.PnlBotonesGrabar.TabIndex = 1
            '
            'btnAceptar
            '
            Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(4, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(91, 41)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(814, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 41)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(3, 0)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 41)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(817, 3)
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
            Me.Label5.Location = New System.Drawing.Point(759, 3)
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
            Me.Panel1.Size = New System.Drawing.Size(914, 22)
            Me.Panel1.TabIndex = 0
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
            'UscDetallResolucionIntegracionSent1
            '
            Me.UscDetallResolucionIntegracionSent1._DocumentoJudicialID = -1
            Me.UscDetallResolucionIntegracionSent1._InternoId = -1
            Me.UscDetallResolucionIntegracionSent1._InternoIngresoId = -1
            Me.UscDetallResolucionIntegracionSent1._InternoIngresoInpeId = -1
            Me.UscDetallResolucionIntegracionSent1._PenalID = -1
            Me.UscDetallResolucionIntegracionSent1._PermisoEliminar = False
            Me.UscDetallResolucionIntegracionSent1._RegionID = -1
            Me.UscDetallResolucionIntegracionSent1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscDetallResolucionIntegracionSent1._TipoResolucion = -1
            Me.UscDetallResolucionIntegracionSent1._TotalAnhos = 0
            Me.UscDetallResolucionIntegracionSent1._TotalDias = 0
            Me.UscDetallResolucionIntegracionSent1._TotalMes = 0
            Me.UscDetallResolucionIntegracionSent1.btnAgregarPerido = True
            Me.UscDetallResolucionIntegracionSent1.btnCajasPeriodo = False
            Me.UscDetallResolucionIntegracionSent1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscDetallResolucionIntegracionSent1.Location = New System.Drawing.Point(0, 248)
            Me.UscDetallResolucionIntegracionSent1.Name = "UscDetallResolucionIntegracionSent1"
            Me.UscDetallResolucionIntegracionSent1.Size = New System.Drawing.Size(914, 274)
            Me.UscDetallResolucionIntegracionSent1.TabIndex = 3
            '
            'pnlTitulo
            '
            Me.pnlTitulo.Controls.Add(Me.Label1)
            Me.pnlTitulo.Controls.Add(Me.lblTitulo)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(914, 23)
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
            Me.Label1.Size = New System.Drawing.Size(914, 3)
            Me.Label1.TabIndex = 1
            '
            'lblTitulo
            '
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(914, 18)
            Me.lblTitulo.TabIndex = 0
            Me.lblTitulo.Text = "RESOLUCION: INTEGRACION DE SENTENCIA"
            '
            'UsrResolSentencia1
            '
            Me.UsrResolSentencia1._blnNuevo = False
            Me.UsrResolSentencia1._Codigo = -1
            Me.UsrResolSentencia1._Documentos_sin_mov = False
            Me.UsrResolSentencia1._DocumentoTipoId = -1
            Me.UsrResolSentencia1._InternoID = -1
            Me.UsrResolSentencia1._InternoIngresoId = -1
            Me.UsrResolSentencia1._InternoIngresoInpeId = -1
            Me.UsrResolSentencia1._InternoNAIngresoInpeId = -1
            Me.UsrResolSentencia1._PenalID = -1
            Me.UsrResolSentencia1._RegionID = -1
            Me.UsrResolSentencia1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UsrResolSentencia1.blnCadenaPerpetua = False
            Me.UsrResolSentencia1.DistritoJudicial = 0
            Me.UsrResolSentencia1.Dock = System.Windows.Forms.DockStyle.Top
            Me.UsrResolSentencia1.DocumentoTipo = 17
            Me.UsrResolSentencia1.EstablecimientomentalId = -1
            Me.UsrResolSentencia1.Location = New System.Drawing.Point(0, 45)
            Me.UsrResolSentencia1.Name = "UsrResolSentencia1"
            Me.UsrResolSentencia1.NombreAsociado = "Prestación de Servicios  Comunitarios :"
            Me.UsrResolSentencia1.ProlonDetencionValor = 0
            Me.UsrResolSentencia1.SalaJuzgado = 0
            Me.UsrResolSentencia1.SentenciaCadenaPerpetua = False
            Me.UsrResolSentencia1.Size = New System.Drawing.Size(914, 197)
            Me.UsrResolSentencia1.TabIndex = 2
            '
            'frmResolIntegracionSent
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(914, 563)
            Me.Name = "frmResolIntegracionSent"
        Me.Text = "Integracion de Sentencia"
        Me.gbxFormChildContainer.ResumeLayout(false)
        Me.PnlInferior.ResumeLayout(false)
        Me.PnlBotonesGrabar.ResumeLayout(false)
        Me.PnlBotones.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.pnlTitulo.ResumeLayout(false)
        Me.ResumeLayout(false)

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
        Friend WithEvents UscDetallResolucionIntegracionSent1 As APPControls.Registro.Sentencias.uscDetallResolucionIntegracionSent
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents UsrResolSentencia1 As APPControls.Registro.Sentencia.usrResolSentencia

        'Friend WithEvents usrResolSentenciaxxxx As APPControls.Registro.Resoluciones.uscResolEncabezado
    End Class
End Namespace