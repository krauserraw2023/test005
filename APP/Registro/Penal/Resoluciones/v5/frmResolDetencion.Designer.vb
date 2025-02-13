Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolDetencion
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
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotonesEliminar = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblCodInterno = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlTitulo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblEtiqueta = New System.Windows.Forms.Label()
            Me.UscExpeDeResolucion1 = New APPControls.Registro.Documento.uscExpeDeResolucion()
            Me.uscResDetencion = New APPControls.Registro.Resoluciones.uscResolDetencion()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.PnlBotonesEliminar.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlTitulo.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.UscExpeDeResolucion1)
            Me.gbxFormChildContainer.Controls.Add(Me.uscResDetencion)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlTitulo)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(820, 490)
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Controls.Add(Me.PnlBotonesEliminar)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 443)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(820, 47)
            Me.PnlInferior.TabIndex = 103
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(629, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(93, 47)
            Me.PnlBotones.TabIndex = 0
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(1, 4)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(91, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'PnlBotonesEliminar
            '
            Me.PnlBotonesEliminar.Controls.Add(Me.btnCancel)
            Me.PnlBotonesEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesEliminar.Location = New System.Drawing.Point(722, 0)
            Me.PnlBotonesEliminar.Name = "PnlBotonesEliminar"
            Me.PnlBotonesEliminar.Size = New System.Drawing.Size(98, 47)
            Me.PnlBotonesEliminar.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(0, 3)
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
            Me.Panel1.Size = New System.Drawing.Size(820, 22)
            Me.Panel1.TabIndex = 113
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(723, 3)
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
            Me.Label5.Location = New System.Drawing.Point(669, 3)
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
            Me.pnlTitulo.Controls.Add(Me.lblEtiqueta)
            Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitulo.Location = New System.Drawing.Point(0, 22)
            Me.pnlTitulo.Name = "pnlTitulo"
            Me.pnlTitulo.Size = New System.Drawing.Size(820, 23)
            Me.pnlTitulo.TabIndex = 127
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(820, 3)
            Me.Label1.TabIndex = 111
            '
            'lblEtiqueta
            '
            Me.lblEtiqueta.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiqueta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.lblEtiqueta.Location = New System.Drawing.Point(0, 0)
            Me.lblEtiqueta.Name = "lblEtiqueta"
            Me.lblEtiqueta.Size = New System.Drawing.Size(820, 18)
            Me.lblEtiqueta.TabIndex = 110
            Me.lblEtiqueta.Text = "RESOLUCION: DETENCION"
            '
            'UscExpeDeResolucion1
            '
            Me.UscExpeDeResolucion1._DocumentoJudicialExpedienteID = -1
            Me.UscExpeDeResolucion1._DocumentoJudicialID = -1
            Me.UscExpeDeResolucion1._Documentos_sin_mov = False
            'Me.UscExpeDeResolucion1._EnabledBotonAgregarAgraviado = True
            'Me.UscExpeDeResolucion1._EnabledBotonAgregarDelito = True
            'Me.UscExpeDeResolucion1._EnabledBotonAgregarExpediente = True
            'Me.UscExpeDeResolucion1._EnabledBotonEditarAgraviado = True
            'Me.UscExpeDeResolucion1._EnabledBotonEditarDelito = True
            'Me.UscExpeDeResolucion1._EnabledBotonEditarExpediente = True
            'Me.UscExpeDeResolucion1._EnabledBotonEliminarAgraviado = True
            'Me.UscExpeDeResolucion1._EnabledBotonEliminarDelito = True
            'Me.UscExpeDeResolucion1._EnabledBotonEliminarExpediente = True
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
            'Me.UscExpeDeResolucion1._VisibleBotonEliminarAgraviado = True
            'Me.UscExpeDeResolucion1._VisibleBotonEliminarExpediente = True
            'Me.UscExpeDeResolucion1._VisiblePanelMantAgraviado = True
            'Me.UscExpeDeResolucion1._VisiblePanelMantDelito = True
            'Me.UscExpeDeResolucion1._VisiblePanelMantExpediente = True
            Me.UscExpeDeResolucion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscExpeDeResolucion1.Location = New System.Drawing.Point(0, 238)
            Me.UscExpeDeResolucion1.Name = "UscExpeDeResolucion1"
            Me.UscExpeDeResolucion1.Size = New System.Drawing.Size(820, 205)
            Me.UscExpeDeResolucion1.TabIndex = 2
            '
            'uscResDetencion
            '
            Me.uscResDetencion._blnNuevo = False
            Me.uscResDetencion._Codigo = -1
            Me.uscResDetencion._InternoId = -1
            Me.uscResDetencion._InternoIngresoId = -1
            Me.uscResDetencion._InternoIngresoInpeId = -1
            Me.uscResDetencion._PenalID = -1
            Me.uscResDetencion._RegionID = -1
            Me.uscResDetencion._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscResDetencion.DistritoJudicial = 0
            Me.uscResDetencion.Dock = System.Windows.Forms.DockStyle.Top
            Me.uscResDetencion.DocumentoTipo = -1
            Me.uscResDetencion.Location = New System.Drawing.Point(0, 45)
            Me.uscResDetencion.Name = "uscResDetencion"
            Me.uscResDetencion.SalaJuzgado = 0
            Me.uscResDetencion.Size = New System.Drawing.Size(820, 193)
            Me.uscResDetencion.TabIndex = 1
            Me.uscResDetencion.TipoAutoridadJudicial = 0
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(629, 47)
            Me.UscAuditUser1.TabIndex = 0
            '
            'frmResolDetencion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(820, 490)
            Me.Name = "frmResolDetencion"
            Me.Text = "Resolución de detención"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.PnlBotonesEliminar.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlTitulo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents PnlBotonesEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblCodInterno As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblInterno As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents uscResDetencion As APPControls.Registro.Resoluciones.uscResolDetencion
        Friend WithEvents UscExpeDeResolucion1 As APPControls.Registro.Documento.uscExpeDeResolucion
        Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblEtiqueta As System.Windows.Forms.Label
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
    End Class
End Namespace