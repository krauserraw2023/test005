Namespace Tratamiento.TallerAsistencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRetiroTaller
        Inherits Legolas.APPUIComponents.Form

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
            Me.components = New System.ComponentModel.Container()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.cbbMotivoRetiro = New APPControls.uscComboParametrica()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblFechaIni = New System.Windows.Forms.Label()
            Me.dtpFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlDocumento = New System.Windows.Forms.Panel()
            Me.dtpFinFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtDocumento = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblFechaFin = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlPie.SuspendLayout()
            Me.pnlOK.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.gbrBuscarNumDoc.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlDocumento.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlSalir)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 194)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(372, 47)
            Me.pnlPie.TabIndex = 1
            '
            'pnlOK
            '
            Me.pnlOK.Controls.Add(Me.btnOk)
            Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlOK.Location = New System.Drawing.Point(186, 0)
            Me.pnlOK.Name = "pnlOK"
            Me.pnlOK.Size = New System.Drawing.Size(92, 47)
            Me.pnlOK.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(2, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(85, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(278, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(94, 47)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(4, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(85, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlDetalle
            '
            Me.pnlDetalle.BackColor = System.Drawing.Color.Transparent
            Me.pnlDetalle.Controls.Add(Me.cbbMotivoRetiro)
            Me.pnlDetalle.Controls.Add(Me.Label2)
            Me.pnlDetalle.Controls.Add(Me.lblFechaIni)
            Me.pnlDetalle.Controls.Add(Me.dtpFecha)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDetalle.Location = New System.Drawing.Point(3, 16)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(366, 60)
            Me.pnlDetalle.TabIndex = 0
            '
            'cbbMotivoRetiro
            '
            Me.cbbMotivoRetiro._NoIndica = False
            Me.cbbMotivoRetiro._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbMotivoRetiro._Todos = False
            Me.cbbMotivoRetiro._TodosMensaje = ""
            Me.cbbMotivoRetiro._Visible_Add = False
            Me.cbbMotivoRetiro._Visible_Buscar = False
            Me.cbbMotivoRetiro._Visible_Eliminar = False
            Me.cbbMotivoRetiro.CodigoPadre = -1
            Me.cbbMotivoRetiro.ComboTipo = CType(2, Short)
            Me.cbbMotivoRetiro.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMotivoRetiro.DropDownWidth = 200
            Me.cbbMotivoRetiro.DropDownWidthAuto = True
            Me.cbbMotivoRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbMotivoRetiro.ListaIdsParaExcluir = Nothing
            Me.cbbMotivoRetiro.Location = New System.Drawing.Point(105, 8)
            Me.cbbMotivoRetiro.ModuloTratamiento = False
            Me.cbbMotivoRetiro.Name = "cbbMotivoRetiro"
            Me.cbbMotivoRetiro.Parametro1 = -1
            Me.cbbMotivoRetiro.Parametro2 = -1
            Me.cbbMotivoRetiro.SelectedIndex = -1
            Me.cbbMotivoRetiro.SelectedValue = 0
            Me.cbbMotivoRetiro.Size = New System.Drawing.Size(252, 22)
            Me.cbbMotivoRetiro.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(102, 15)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Motivo de Retiro :"
            '
            'lblFechaIni
            '
            Me.lblFechaIni.AutoSize = True
            Me.lblFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaIni.Location = New System.Drawing.Point(6, 40)
            Me.lblFechaIni.Name = "lblFechaIni"
            Me.lblFechaIni.Size = New System.Drawing.Size(78, 15)
            Me.lblFechaIni.TabIndex = 2
            Me.lblFechaIni.Text = "Fecha retiro :"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Location = New System.Drawing.Point(105, 36)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecha.TabIndex = 3
            Me.dtpFecha.Value = "/  /"
            Me.dtpFecha.ValueLong = CType(0, Long)
            '
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.Panel2)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlDocumento)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlDetalle)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 0)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(372, 194)
            Me.gbrBuscarNumDoc.TabIndex = 0
            Me.gbrBuscarNumDoc.TabStop = False
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.txtObservacion)
            Me.Panel2.Controls.Add(Me.Label4)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(3, 136)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(366, 55)
            Me.Panel2.TabIndex = 2
            '
            'txtObservacion
            '
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(102, 0)
            Me.txtObservacion.MaxLength = 250
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(264, 55)
            Me.txtObservacion.TabIndex = 1
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(0, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(102, 15)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "  Observación :     "
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlDocumento
            '
            Me.pnlDocumento.Controls.Add(Me.dtpFinFecha)
            Me.pnlDocumento.Controls.Add(Me.txtDocumento)
            Me.pnlDocumento.Controls.Add(Me.Label3)
            Me.pnlDocumento.Controls.Add(Me.lblFechaFin)
            Me.pnlDocumento.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDocumento.Location = New System.Drawing.Point(3, 76)
            Me.pnlDocumento.Name = "pnlDocumento"
            Me.pnlDocumento.Size = New System.Drawing.Size(366, 60)
            Me.pnlDocumento.TabIndex = 1
            '
            'dtpFinFecha
            '
            Me.dtpFinFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinFecha.Location = New System.Drawing.Point(103, 33)
            Me.dtpFinFecha.Name = "dtpFinFecha"
            Me.dtpFinFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpFinFecha.TabIndex = 3
            Me.dtpFinFecha.Value = "/  /"
            Me.dtpFinFecha.ValueLong = CType(0, Long)
            '
            'txtDocumento
            '
            Me.txtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocumento.Location = New System.Drawing.Point(103, 8)
            Me.txtDocumento.MaxLength = 50
            Me.txtDocumento.Name = "txtDocumento"
            Me.txtDocumento.Size = New System.Drawing.Size(254, 21)
            Me.txtDocumento.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(6, 11)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(93, 15)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Nº Documento :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFechaFin
            '
            Me.lblFechaFin.AutoSize = True
            Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaFin.Location = New System.Drawing.Point(7, 35)
            Me.lblFechaFin.Name = "lblFechaFin"
            Me.lblFechaFin.Size = New System.Drawing.Size(75, 15)
            Me.lblFechaFin.TabIndex = 2
            Me.lblFechaFin.Text = "Fecha Doc. :"
            '
            'frmRetiroTaller
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(372, 241)
            Me.Controls.Add(Me.gbrBuscarNumDoc)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRetiroTaller"
            Me.ShowInTaskbar = False
            Me.Text = "Retiro de Actividad Laboral"
            Me.pnlPie.ResumeLayout(False)
            Me.pnlOK.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.pnlDetalle.PerformLayout()
            Me.gbrBuscarNumDoc.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlDocumento.ResumeLayout(False)
            Me.pnlDocumento.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents pnlOK As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblFechaIni As System.Windows.Forms.Label
        Friend WithEvents dtpFinFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblFechaFin As System.Windows.Forms.Label
        Friend WithEvents Label4 As Label
        Friend WithEvents cbbMotivoRetiro As APPControls.uscComboParametrica
        Friend WithEvents pnlDocumento As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents txtObservacion As TextBox
    End Class
End Namespace

