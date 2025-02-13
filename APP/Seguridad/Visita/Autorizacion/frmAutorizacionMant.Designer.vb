Namespace Visita.Autorizacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAutorizacionMant
        Inherits Legolas.APPUIComponents.Form

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizacionMant))
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.lblPabellonNombre = New System.Windows.Forms.Label()
            Me.lblEtapaNombre = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.lblInternoApeNom = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscRegionPenalLabel1 = New APPControls.uscRegionPenalLabel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblCountReg = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSalirBusqueda = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.UscAutorizacion1 = New APPControls.Visita.uscAutorizacion()
            Me.GroupBox2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.Panel3)
            Me.GroupBox2.Controls.Add(Me.pnlCabecera)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1186, 78)
            Me.GroupBox2.TabIndex = 93
            Me.GroupBox2.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.lblPabellonNombre)
            Me.Panel3.Controls.Add(Me.lblEtapaNombre)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 41)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(1180, 25)
            Me.Panel3.TabIndex = 4
            '
            'lblPabellonNombre
            '
            Me.lblPabellonNombre.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblPabellonNombre.Location = New System.Drawing.Point(245, 0)
            Me.lblPabellonNombre.Name = "lblPabellonNombre"
            Me.lblPabellonNombre.Size = New System.Drawing.Size(318, 23)
            Me.lblPabellonNombre.TabIndex = 3
            Me.lblPabellonNombre.Text = "Pabellon :"
            Me.lblPabellonNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblEtapaNombre
            '
            Me.lblEtapaNombre.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblEtapaNombre.Location = New System.Drawing.Point(0, 0)
            Me.lblEtapaNombre.Name = "lblEtapaNombre"
            Me.lblEtapaNombre.Size = New System.Drawing.Size(245, 23)
            Me.lblEtapaNombre.TabIndex = 2
            Me.lblEtapaNombre.Text = "Etapa :"
            Me.lblEtapaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlCabecera
            '
            Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCabecera.Controls.Add(Me.lblInternoApeNom)
            Me.pnlCabecera.Controls.Add(Me.Label1)
            Me.pnlCabecera.Controls.Add(Me.UscRegionPenalLabel1)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(3, 16)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(1180, 25)
            Me.pnlCabecera.TabIndex = 3
            '
            'lblInternoApeNom
            '
            Me.lblInternoApeNom.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblInternoApeNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInternoApeNom.Location = New System.Drawing.Point(563, 0)
            Me.lblInternoApeNom.Name = "lblInternoApeNom"
            Me.lblInternoApeNom.Size = New System.Drawing.Size(615, 23)
            Me.lblInternoApeNom.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label1.Location = New System.Drawing.Point(512, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 23)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Interno :"
            '
            'UscRegionPenalLabel1
            '
            Me.UscRegionPenalLabel1._Penalid = -1
            Me.UscRegionPenalLabel1._PenalNombre = "************"
            Me.UscRegionPenalLabel1._RegionId = -1
            Me.UscRegionPenalLabel1._RegionNombre = "************"
            Me.UscRegionPenalLabel1._WidthRegion = 200
            Me.UscRegionPenalLabel1.BackColor = System.Drawing.Color.Transparent
            Me.UscRegionPenalLabel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.UscRegionPenalLabel1.Location = New System.Drawing.Point(0, 0)
            Me.UscRegionPenalLabel1.Margin = New System.Windows.Forms.Padding(1)
            Me.UscRegionPenalLabel1.Name = "UscRegionPenalLabel1"
            Me.UscRegionPenalLabel1.Size = New System.Drawing.Size(512, 23)
            Me.UscRegionPenalLabel1.TabIndex = 0
            Me.UscRegionPenalLabel1.UsuarioID = -1
            Me.UscRegionPenalLabel1.VersionInstalacionFile = 0
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.lblCountReg)
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Controls.Add(Me.pnlExportar)
            Me.Panel2.Controls.Add(Me.pnlModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 492)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1186, 49)
            Me.Panel2.TabIndex = 96
            '
            'lblCountReg
            '
            Me.lblCountReg.BackColor = System.Drawing.Color.Transparent
            Me.lblCountReg.Dock = System.Windows.Forms.DockStyle.Right
            Me.lblCountReg.Location = New System.Drawing.Point(1090, 0)
            Me.lblCountReg.Name = "lblCountReg"
            Me.lblCountReg.Size = New System.Drawing.Size(96, 49)
            Me.lblCountReg.TabIndex = 97
            Me.lblCountReg.Text = "0 Reg."
            Me.lblCountReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnSalirBusqueda)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(278, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(95, 49)
            Me.Panel1.TabIndex = 88
            '
            'btnSalirBusqueda
            '
            Me.btnSalirBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalirBusqueda.Image = CType(resources.GetObject("btnSalirBusqueda.Image"), System.Drawing.Image)
            Me.btnSalirBusqueda.Location = New System.Drawing.Point(3, 5)
            Me.btnSalirBusqueda.Name = "btnSalirBusqueda"
            Me.btnSalirBusqueda.Size = New System.Drawing.Size(88, 40)
            Me.btnSalirBusqueda.TabIndex = 76
            Me.btnSalirBusqueda.Text = "&Salir"
            Me.btnSalirBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalirBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalirBusqueda.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnReporte)
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlExportar.Location = New System.Drawing.Point(95, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(183, 49)
            Me.pnlExportar.TabIndex = 87
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnReporte.Location = New System.Drawing.Point(94, 5)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(88, 40)
            Me.btnReporte.TabIndex = 89
            Me.btnReporte.Text = "&Reporte"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(2, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 78
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnAnular)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlModificar.Location = New System.Drawing.Point(0, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(95, 49)
            Me.pnlModificar.TabIndex = 85
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnAnular.Location = New System.Drawing.Point(3, 5)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(88, 40)
            Me.btnAnular.TabIndex = 88
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAnular.UseVisualStyleBackColor = True
            '
            'UscAutorizacion1
            '
            Me.UscAutorizacion1._AutorizavionVista = Type.Enumeracion.Visita.AutorizacionVista.Interno
            Me.UscAutorizacion1._InternoID = -1
            Me.UscAutorizacion1._VisibleBotonAdd = True
            Me.UscAutorizacion1._visibleCabecera = True
            Me.UscAutorizacion1._VisitanteID = -1
            Me.UscAutorizacion1.BackColor = System.Drawing.Color.Transparent
            Me.UscAutorizacion1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAutorizacion1.Location = New System.Drawing.Point(0, 78)
            Me.UscAutorizacion1.Name = "UscAutorizacion1"
            Me.UscAutorizacion1.Size = New System.Drawing.Size(1186, 414)
            Me.UscAutorizacion1.TabIndex = 94
            '
            'frmAutorizacionMant
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(1186, 541)
            Me.Controls.Add(Me.UscAutorizacion1)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.GroupBox2)
            Me.Name = "frmAutorizacionMant"
            Me.Text = "Autorizacion - Mantenimiento"
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents UscRegionPenalLabel1 As APPControls.uscRegionPenalLabel
        Friend WithEvents UscAutorizacion1 As APPControls.Visita.uscAutorizacion
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents btnSalirBusqueda As System.Windows.Forms.Button
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents lblInternoApeNom As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents lblCountReg As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents lblPabellonNombre As System.Windows.Forms.Label
        Friend WithEvents lblEtapaNombre As System.Windows.Forms.Label
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel

    End Class

End Namespace