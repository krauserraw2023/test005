Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmResolSentenciaNueva
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.PnlBotonesGrabar = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UsrResolSentenciaV21 = New APPControls.Registro.Sentencia.usrResolSentenciaV2()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.UscDetallRegistroSentenciaGrilla1 = New APPControls.Registro.Sentencias.uscDetallRegistroSentenciaGrilla()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotonesGrabar.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(921, 582)
            '
            'lblCodInterno
            '
            Me.lblCodInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCodInterno.AutoSize = True
            Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodInterno.Location = New System.Drawing.Point(824, 3)
            Me.lblCodInterno.Name = "lblCodInterno"
            Me.lblCodInterno.Size = New System.Drawing.Size(82, 13)
            Me.lblCodInterno.TabIndex = 3
            Me.lblCodInterno.Text = "lblCodInterno"
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
            Me.Panel1.Size = New System.Drawing.Size(921, 22)
            Me.Panel1.TabIndex = 0
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(766, 3)
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
            Me.PnlInferior.Location = New System.Drawing.Point(0, 540)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(921, 42)
            Me.PnlInferior.TabIndex = 4
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(726, 42)
            Me.UscAuditUser1.TabIndex = 0
            '
            'PnlBotonesGrabar
            '
            Me.PnlBotonesGrabar.Controls.Add(Me.btnAceptar)
            Me.PnlBotonesGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotonesGrabar.Location = New System.Drawing.Point(726, 0)
            Me.PnlBotonesGrabar.Name = "PnlBotonesGrabar"
            Me.PnlBotonesGrabar.Size = New System.Drawing.Size(95, 42)
            Me.PnlBotonesGrabar.TabIndex = 2
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(1, 0)
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
            Me.PnlBotones.Location = New System.Drawing.Point(821, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(100, 42)
            Me.PnlBotones.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(2, 0)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UsrResolSentenciaV21)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 22)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(921, 175)
            Me.Panel2.TabIndex = 6
            '
            'UsrResolSentenciaV21
            '
            Me.UsrResolSentenciaV21._blnNuevo = False
            Me.UsrResolSentenciaV21._Codigo = -1
            Me.UsrResolSentenciaV21._Documentos_sin_mov = False
            Me.UsrResolSentenciaV21._DocumentoTipoId = -1
            Me.UsrResolSentenciaV21._InternoID = -1
            Me.UsrResolSentenciaV21._InternoIngresoId = -1
            Me.UsrResolSentenciaV21._InternoIngresoInpeId = -1
            Me.UsrResolSentenciaV21._InternoNAIngresoInpeId = -1
            Me.UsrResolSentenciaV21._PenalID = -1
            Me.UsrResolSentenciaV21._RegionID = -1
            Me.UsrResolSentenciaV21._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UsrResolSentenciaV21.blnCadenaPerpetua = False
            Me.UsrResolSentenciaV21.DistritoJudicial = 0
            Me.UsrResolSentenciaV21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UsrResolSentenciaV21.DocumentoTipo = 17
            Me.UsrResolSentenciaV21.EstablecimientomentalId = -1
            Me.UsrResolSentenciaV21.Location = New System.Drawing.Point(0, 0)
            Me.UsrResolSentenciaV21.Name = "UsrResolSentenciaV21"
            Me.UsrResolSentenciaV21.NombreAsociado = ""
            Me.UsrResolSentenciaV21.SalaJuzgado = 0
            Me.UsrResolSentenciaV21.SentenciaCadenaPerpetua = False
            Me.UsrResolSentenciaV21.Size = New System.Drawing.Size(921, 175)
            Me.UsrResolSentenciaV21.TabIndex = 0
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.UscDetallRegistroSentenciaGrilla1)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(0, 197)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(921, 343)
            Me.Panel4.TabIndex = 8
            '
            'UscDetallRegistroSentenciaGrilla1
            '
            Me.UscDetallRegistroSentenciaGrilla1._DocumentoJudicialID = -1
            Me.UscDetallRegistroSentenciaGrilla1._ExpIDCopi = -1
            Me.UscDetallRegistroSentenciaGrilla1._Extramuro = -1
            Me.UscDetallRegistroSentenciaGrilla1._InternoId = -1
            Me.UscDetallRegistroSentenciaGrilla1._InternoIngresoId = -1
            Me.UscDetallRegistroSentenciaGrilla1._InternoIngresoInpeId = -1
            Me.UscDetallRegistroSentenciaGrilla1._PenalID = -1
            Me.UscDetallRegistroSentenciaGrilla1._PermisoEliminar = False
            Me.UscDetallRegistroSentenciaGrilla1._RegionID = -1
            Me.UscDetallRegistroSentenciaGrilla1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscDetallRegistroSentenciaGrilla1._TipoResolucion = -1
            Me.UscDetallRegistroSentenciaGrilla1._TotalAnhos = "0"
            Me.UscDetallRegistroSentenciaGrilla1._TotalDias = "0"
            Me.UscDetallRegistroSentenciaGrilla1._TotalMes = "0"
            Me.UscDetallRegistroSentenciaGrilla1.AutoridadJudicial = "0"
            Me.UscDetallRegistroSentenciaGrilla1.btnAgregarPerido = True
            Me.UscDetallRegistroSentenciaGrilla1.btnCajasPeriodo = False
            Me.UscDetallRegistroSentenciaGrilla1.DistritoJudicial = "0"
            Me.UscDetallRegistroSentenciaGrilla1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscDetallRegistroSentenciaGrilla1.Location = New System.Drawing.Point(0, 0)
            Me.UscDetallRegistroSentenciaGrilla1.Name = "UscDetallRegistroSentenciaGrilla1"
            Me.UscDetallRegistroSentenciaGrilla1.Size = New System.Drawing.Size(921, 343)
            Me.UscDetallRegistroSentenciaGrilla1.TabIndex = 0
            '
            'frmResolSentenciaNueva
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(921, 582)
            Me.Name = "frmResolSentenciaNueva"
            Me.Text = "Sentencia"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotonesGrabar.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
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
        Friend WithEvents PnlBotonesGrabar As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents UsrResolSentenciaV21 As APPControls.Registro.Sentencia.usrResolSentenciaV2
        Friend WithEvents UscDetallRegistroSentenciaGrilla1 As APPControls.Registro.Sentencias.uscDetallRegistroSentenciaGrilla
    End Class
End Namespace