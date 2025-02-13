Namespace Registro.Reniec
    'jgjg

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReniecLineaV2
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.pnlListaNombres = New System.Windows.Forms.Panel()
            Me.UsrInternoReniecLineaV31 = New APPControls.Registro.Reniec.usrInternoReniecLineaV2()
            Me.UscListaReniec31 = New APPControls.Registro.Reniec.uscListaReniec2()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.btnRegresar = New System.Windows.Forms.Button()
            Me.lblLeyenda = New System.Windows.Forms.Label()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk_ = New System.Windows.Forms.Button()
            Me.pnlListaNombres.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlListaNombres
            '
            Me.pnlListaNombres.BackColor = System.Drawing.Color.Transparent
            Me.pnlListaNombres.Controls.Add(Me.UsrInternoReniecLineaV31)
            Me.pnlListaNombres.Controls.Add(Me.UscListaReniec31)
            Me.pnlListaNombres.Controls.Add(Me.pnlBotones)
            Me.pnlListaNombres.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlListaNombres.Location = New System.Drawing.Point(0, 0)
            Me.pnlListaNombres.Name = "pnlListaNombres"
            Me.pnlListaNombres.Size = New System.Drawing.Size(503, 475)
            Me.pnlListaNombres.TabIndex = 16
            '
            'UsrInternoReniecLineaV31
            '
            Me.UsrInternoReniecLineaV31._EnabledDobleClick = True
            Me.UsrInternoReniecLineaV31._ImagenSis = -1
            Me.UsrInternoReniecLineaV31._IngresoID = -1
            Me.UsrInternoReniecLineaV31._IngresoInpeID = -1
            Me.UsrInternoReniecLineaV31._InternoID = -1
            Me.UsrInternoReniecLineaV31._ListaInternoSisCabecera = ""
            Me.UsrInternoReniecLineaV31._ListaInternoSisData = ""
            Me.UsrInternoReniecLineaV31._NombreAsociadoValID = -1
            Me.UsrInternoReniecLineaV31._NombresAsociados = ""
            Me.UsrInternoReniecLineaV31._NumeroDni = ""
            Me.UsrInternoReniecLineaV31._NumeroDniAux = ""
            Me.UsrInternoReniecLineaV31._PenalID = -1
            Me.UsrInternoReniecLineaV31._RegionID = -1
            Me.UsrInternoReniecLineaV31._ReniecData = ""
            Me.UsrInternoReniecLineaV31._TipoComparacion = -1
            Me.UsrInternoReniecLineaV31._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UsrInternoReniecLineaV31.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UsrInternoReniecLineaV31.EstadoCivilId = -1
            Me.UsrInternoReniecLineaV31.FotoByte = Nothing
            Me.UsrInternoReniecLineaV31.Location = New System.Drawing.Point(0, 0)
            Me.UsrInternoReniecLineaV31.Name = "UsrInternoReniecLineaV31"
            Me.UsrInternoReniecLineaV31.Size = New System.Drawing.Size(503, 426)
            Me.UsrInternoReniecLineaV31.TabIndex = 0
            Me.UsrInternoReniecLineaV31.Visible = False
            '
            'UscListaReniec31
            '
            Me.UscListaReniec31._ApellidoMaterno = ""
            Me.UscListaReniec31._ApellidoPaterno = ""
            Me.UscListaReniec31._Comparacion = -1
            Me.UscListaReniec31._InternoID = -1
            Me.UscListaReniec31._NombreAsociadoValID = -1
            Me.UscListaReniec31._Nombres = ""
            Me.UscListaReniec31.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscListaReniec31.Location = New System.Drawing.Point(0, 0)
            Me.UscListaReniec31.Name = "UscListaReniec31"
            Me.UscListaReniec31.Size = New System.Drawing.Size(503, 426)
            Me.UscListaReniec31.TabIndex = 1
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.btnRegresar)
            Me.pnlBotones.Controls.Add(Me.lblLeyenda)
            Me.pnlBotones.Controls.Add(Me.btnOk)
            Me.pnlBotones.Controls.Add(Me.btnCancel)
            Me.pnlBotones.Controls.Add(Me.btnOk_)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(0, 426)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(503, 49)
            Me.pnlBotones.TabIndex = 0
            '
            'btnRegresar
            '
            Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRegresar.Image = Global.SIPPOPE.My.Resources.Resources.back_32
            Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnRegresar.Location = New System.Drawing.Point(4, 4)
            Me.btnRegresar.Name = "btnRegresar"
            Me.btnRegresar.Size = New System.Drawing.Size(85, 38)
            Me.btnRegresar.TabIndex = 0
            Me.btnRegresar.Text = " &Volver"
            Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRegresar.UseVisualStyleBackColor = True
            Me.btnRegresar.Visible = False
            '
            'lblLeyenda
            '
            Me.lblLeyenda.AutoSize = True
            Me.lblLeyenda.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLeyenda.Location = New System.Drawing.Point(0, 0)
            Me.lblLeyenda.Name = "lblLeyenda"
            Me.lblLeyenda.Size = New System.Drawing.Size(114, 39)
            Me.lblLeyenda.TabIndex = 88
            Me.lblLeyenda.Text = "LEYENDA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N : Datos Restingidos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S : Datos Disponibles. "
            Me.lblLeyenda.Visible = False
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOk.Location = New System.Drawing.Point(302, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(90, 40)
            Me.btnOk.TabIndex = 1
            Me.btnOk.Text = " &Aceptar"
            Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnOk.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(403, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk_
            '
            Me.btnOk_.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnOk_.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOk_.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk_.Location = New System.Drawing.Point(303, 4)
            Me.btnOk_.Name = "btnOk_"
            Me.btnOk_.Size = New System.Drawing.Size(90, 40)
            Me.btnOk_.TabIndex = 87
            Me.btnOk_.Text = "&Aceptar"
            Me.btnOk_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmReniecLineaV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(503, 475)
            Me.Controls.Add(Me.pnlListaNombres)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmReniecLineaV2"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Datos de Reniec"
            Me.pnlListaNombres.ResumeLayout(False)
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlBotones.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlListaNombres As System.Windows.Forms.Panel
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk_ As System.Windows.Forms.Button
        Friend WithEvents btnRegresar As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents UscListaReniec31 As APPControls.Registro.Reniec.uscListaReniec2
        Friend WithEvents lblLeyenda As System.Windows.Forms.Label
        Friend WithEvents UsrInternoReniecLineaV31 As APPControls.Registro.Reniec.usrInternoReniecLineaV2

    End Class
End Namespace