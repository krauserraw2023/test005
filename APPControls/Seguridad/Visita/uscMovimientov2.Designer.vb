Namespace Visita


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscMovimientov2
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaVis = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.chkVisitaAdmin = New System.Windows.Forms.CheckBox()
            Me.lblRegimen = New System.Windows.Forms.Label()
            Me.pnlVisita = New System.Windows.Forms.Panel()
            Me.UscRegistrov2 = New APPControls.Visita.Penal.uscRegistrov2()
            Me.UscRegistroAdminv2 = New APPControls.Visita.Administrativa.uscRegistroAdminv2()
            Me.pnlCabecera.SuspendLayout()
            Me.grbCabecera.SuspendLayout()
            Me.pnlVisita.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.grbCabecera)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(1338, 40)
            Me.pnlCabecera.TabIndex = 2
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.Label3)
            Me.grbCabecera.Controls.Add(Me.Label2)
            Me.grbCabecera.Controls.Add(Me.Label1)
            Me.grbCabecera.Controls.Add(Me.dtpFechaVis)
            Me.grbCabecera.Controls.Add(Me.chkVisitaAdmin)
            Me.grbCabecera.Controls.Add(Me.lblRegimen)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Location = New System.Drawing.Point(0, 0)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(1338, 40)
            Me.grbCabecera.TabIndex = 25
            Me.grbCabecera.TabStop = False
            '
            'Label3
            '
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label3.Location = New System.Drawing.Point(267, 12)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(3, 25)
            Me.Label3.TabIndex = 97
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label2.Location = New System.Drawing.Point(410, 12)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(3, 25)
            Me.Label2.TabIndex = 96
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(273, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(43, 13)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "Fecha :"
            '
            'dtpFechaVis
            '
            Me.dtpFechaVis.Enabled = False
            Me.dtpFechaVis.Location = New System.Drawing.Point(322, 15)
            Me.dtpFechaVis.Name = "dtpFechaVis"
            Me.dtpFechaVis.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaVis.TabIndex = 1
            Me.dtpFechaVis.Value = "/  /"
            Me.dtpFechaVis.ValueLong = CType(0, Long)
            '
            'chkVisitaAdmin
            '
            Me.chkVisitaAdmin.AutoSize = True
            Me.chkVisitaAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkVisitaAdmin.ForeColor = System.Drawing.Color.Red
            Me.chkVisitaAdmin.Location = New System.Drawing.Point(419, 16)
            Me.chkVisitaAdmin.Name = "chkVisitaAdmin"
            Me.chkVisitaAdmin.Size = New System.Drawing.Size(195, 17)
            Me.chkVisitaAdmin.TabIndex = 95
            Me.chkVisitaAdmin.Text = "Registrar Visita Administrativa"
            Me.chkVisitaAdmin.UseVisualStyleBackColor = True
            '
            'lblRegimen
            '
            Me.lblRegimen.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegimen.Location = New System.Drawing.Point(3, 16)
            Me.lblRegimen.Name = "lblRegimen"
            Me.lblRegimen.Size = New System.Drawing.Size(258, 21)
            Me.lblRegimen.TabIndex = 19
            Me.lblRegimen.Text = "Regimen :"
            '
            'pnlVisita
            '
            Me.pnlVisita.Controls.Add(Me.UscRegistrov2)
            Me.pnlVisita.Controls.Add(Me.UscRegistroAdminv2)
            Me.pnlVisita.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlVisita.Location = New System.Drawing.Point(0, 40)
            Me.pnlVisita.Name = "pnlVisita"
            Me.pnlVisita.Size = New System.Drawing.Size(1338, 475)
            Me.pnlVisita.TabIndex = 3
            '
            'UscRegistrov2
            '
            Me.UscRegistrov2._FechaVisita = CType(0, Long)
            Me.UscRegistrov2._HabilitarCapHuellaValReniec = False
            Me.UscRegistrov2._HabilitarHuellaDigital = False
            Me.UscRegistrov2._HabilitarInternoPJ = False
            Me.UscRegistrov2._PenalID = CType(-1, Short)
            Me.UscRegistrov2._PenalNombre = ""
            Me.UscRegistrov2._RegimenTipoID = CType(-1, Short)
            Me.UscRegistrov2._RegionID = CType(-1, Short)
            Me.UscRegistrov2._RegionNombre = ""
            Me.UscRegistrov2._SolicitarAutoRegAbogado = False
            Me.UscRegistrov2._SolicitarAutoRegOrdinario = False
            Me.UscRegistrov2._SolicitarInfoPabellon = False
            Me.UscRegistrov2._ValidarModuloVisConMigraciones = False
            Me.UscRegistrov2._ValidarModuloVisConReniec = False
            Me.UscRegistrov2._ValidarVisitanteConMigraciones = False
            Me.UscRegistrov2._ValidarVisitanteConReniec = False
            Me.UscRegistrov2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscRegistrov2.Location = New System.Drawing.Point(0, 0)
            Me.UscRegistrov2.Name = "UscRegistrov2"
            Me.UscRegistrov2.Size = New System.Drawing.Size(1338, 475)
            Me.UscRegistrov2.TabIndex = 0
            '
            'UscRegistroAdminv2
            '
            Me.UscRegistroAdminv2._FechaVisita = CType(0, Long)
            Me.UscRegistroAdminv2._HabilitarCapHuellaValReniec = False
            Me.UscRegistroAdminv2._HabilitarHuellaDigital = False
            Me.UscRegistroAdminv2._PenalID = -1
            Me.UscRegistroAdminv2._PenalNombre = ""
            Me.UscRegistroAdminv2._RegionID = -1
            Me.UscRegistroAdminv2._RegionNombre = ""
            Me.UscRegistroAdminv2._SolicitarAutoRegOrdinario = False
            Me.UscRegistroAdminv2._ValidarModuloVisConMigraciones = False
            Me.UscRegistroAdminv2._ValidarModuloVisConReniec = False
            Me.UscRegistroAdminv2._ValidarVisitanteConMigraciones = False
            Me.UscRegistroAdminv2._ValidarVisitanteConReniec = False
            Me.UscRegistroAdminv2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscRegistroAdminv2.Location = New System.Drawing.Point(0, 0)
            Me.UscRegistroAdminv2.Name = "UscRegistroAdminv2"
            Me.UscRegistroAdminv2.Size = New System.Drawing.Size(1338, 475)
            Me.UscRegistroAdminv2.TabIndex = 1
            '
            'uscMovimientov2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlVisita)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Name = "uscMovimientov2"
            Me.Size = New System.Drawing.Size(1338, 515)
            Me.pnlCabecera.ResumeLayout(False)
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.pnlVisita.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblRegimen As System.Windows.Forms.Label
        Friend WithEvents dtpFechaVis As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents pnlVisita As System.Windows.Forms.Panel
        Friend WithEvents UscRegistrov2 As APPControls.Visita.Penal.uscRegistrov2
        Friend WithEvents UscRegistroAdminv2 As APPControls.Visita.Administrativa.uscRegistroAdminv2
        Friend WithEvents chkVisitaAdmin As System.Windows.Forms.CheckBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label

    End Class
End Namespace