Namespace Visita
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscar2
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar2))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.tbpRegistro = New System.Windows.Forms.TabPage()
            Me.UscMovimientov21 = New APPControls.Visita.uscMovimientov2()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnRegSalida = New System.Windows.Forms.Button()
            Me.btnNuevoMov = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnBusqueda = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.tbpBusqueda = New System.Windows.Forms.TabPage()
            Me.UscBusqueda1 = New APPControls.Visita.uscBusqueda()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.pbLeyenda = New System.Windows.Forms.PictureBox()
            Me.pnlSalida = New System.Windows.Forms.Panel()
            Me.btnSalirBusqueda = New System.Windows.Forms.Button()
            Me.pnlPendientes = New System.Windows.Forms.Panel()
            Me.btnPendientes = New System.Windows.Forms.Button()
            Me.pnlRegistrarSalida = New System.Windows.Forms.Panel()
            Me.btnRegistarSalida = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.pnlExportar = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlNuevo = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.GroupBox1.SuspendLayout()
            Me.tbpRegistro.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.tbpBusqueda.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            CType(Me.pbLeyenda, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSalida.SuspendLayout()
            Me.pnlPendientes.SuspendLayout()
            Me.pnlRegistrarSalida.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlExportar.SuspendLayout()
            Me.pnlNuevo.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.UsrRegionPenal1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(880, 35)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            '
            'UsrRegionPenal1
            '
            Me.UsrRegionPenal1._LicenciaID = -1
            Me.UsrRegionPenal1._PenalID = 0
            Me.UsrRegionPenal1._PenalTodos = True
            Me.UsrRegionPenal1._RegionID = 0
            Me.UsrRegionPenal1._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Usuario
            Me.UsrRegionPenal1._UsuarioID = -1
            Me.UsrRegionPenal1._WidthLabelRegion = 47
            Me.UsrRegionPenal1.BackColor = System.Drawing.Color.Transparent
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(3, 10)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(492, 22)
            Me.UsrRegionPenal1.TabIndex = 1
            Me.UsrRegionPenal1.WidthRegion = 224
            '
            'tbpRegistro
            '
            Me.tbpRegistro.Controls.Add(Me.UscMovimientov21)
            Me.tbpRegistro.Controls.Add(Me.Panel1)
            Me.tbpRegistro.Location = New System.Drawing.Point(4, 22)
            Me.tbpRegistro.Name = "tbpRegistro"
            Me.tbpRegistro.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpRegistro.Size = New System.Drawing.Size(872, 504)
            Me.tbpRegistro.TabIndex = 1
            Me.tbpRegistro.Text = "Registro"
            Me.tbpRegistro.UseVisualStyleBackColor = True
            '
            'UscMovimientov21
            '
            Me.UscMovimientov21._EsInternoPJ = False
            Me.UscMovimientov21._IDInternoPJ = -1
            Me.UscMovimientov21._InternoIDArray = Nothing
            Me.UscMovimientov21._PenalID = CType(-1, Short)
            Me.UscMovimientov21._PenalNombre = ""
            Me.UscMovimientov21._RegionID = CType(-1, Short)
            Me.UscMovimientov21._RegionNombre = ""
            Me.UscMovimientov21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscMovimientov21.IsVisitaAdministrativa = False
            Me.UscMovimientov21.Location = New System.Drawing.Point(3, 3)
            Me.UscMovimientov21.Name = "UscMovimientov21"
            Me.UscMovimientov21.Size = New System.Drawing.Size(866, 450)
            Me.UscMovimientov21.TabIndex = 74
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnRegSalida)
            Me.Panel1.Controls.Add(Me.btnNuevoMov)
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Controls.Add(Me.btnBusqueda)
            Me.Panel1.Controls.Add(Me.btnGrabar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(3, 453)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(866, 48)
            Me.Panel1.TabIndex = 72
            '
            'btnRegSalida
            '
            Me.btnRegSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRegSalida.Image = Global.SIPPOPE.My.Resources.Resources.next_32
            Me.btnRegSalida.Location = New System.Drawing.Point(193, 4)
            Me.btnRegSalida.Name = "btnRegSalida"
            Me.btnRegSalida.Size = New System.Drawing.Size(103, 40)
            Me.btnRegSalida.TabIndex = 76
            Me.btnRegSalida.Text = "Reg. &Salida"
            Me.btnRegSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnRegSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnRegSalida.UseVisualStyleBackColor = True
            '
            'btnNuevoMov
            '
            Me.btnNuevoMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoMov.Image = CType(resources.GetObject("btnNuevoMov.Image"), System.Drawing.Image)
            Me.btnNuevoMov.Location = New System.Drawing.Point(2, 4)
            Me.btnNuevoMov.Name = "btnNuevoMov"
            Me.btnNuevoMov.Size = New System.Drawing.Size(88, 40)
            Me.btnNuevoMov.TabIndex = 74
            Me.btnNuevoMov.Text = "&Nuevo"
            Me.btnNuevoMov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevoMov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevoMov.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(400, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 40)
            Me.btnSalir.TabIndex = 71
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnBusqueda
            '
            Me.btnBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBusqueda.Image = Global.SIPPOPE.My.Resources.Resources.Search_files_32
            Me.btnBusqueda.Location = New System.Drawing.Point(303, 4)
            Me.btnBusqueda.Name = "btnBusqueda"
            Me.btnBusqueda.Size = New System.Drawing.Size(91, 40)
            Me.btnBusqueda.TabIndex = 70
            Me.btnBusqueda.Text = "&Salida"
            Me.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnBusqueda.UseVisualStyleBackColor = True
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGrabar.Location = New System.Drawing.Point(96, 4)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(91, 40)
            Me.btnGrabar.TabIndex = 66
            Me.btnGrabar.Text = "&Grabar "
            Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'tbpBusqueda
            '
            Me.tbpBusqueda.Controls.Add(Me.UscBusqueda1)
            Me.tbpBusqueda.Controls.Add(Me.pnlBotones)
            Me.tbpBusqueda.Location = New System.Drawing.Point(4, 22)
            Me.tbpBusqueda.Name = "tbpBusqueda"
            Me.tbpBusqueda.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpBusqueda.Size = New System.Drawing.Size(872, 504)
            Me.tbpBusqueda.TabIndex = 0
            Me.tbpBusqueda.Text = "Salida"
            Me.tbpBusqueda.UseVisualStyleBackColor = True
            '
            'UscBusqueda1
            '
            Me.UscBusqueda1._ModificarSalida = False
            Me.UscBusqueda1._PenalID = -1
            Me.UscBusqueda1._RegionID = -1
            Me.UscBusqueda1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscBusqueda1.FechaFin = CType(0, Long)
            Me.UscBusqueda1.FechaInicio = CType(0, Long)
            Me.UscBusqueda1.Location = New System.Drawing.Point(3, 3)
            Me.UscBusqueda1.Name = "UscBusqueda1"
            Me.UscBusqueda1.Size = New System.Drawing.Size(866, 450)
            Me.UscBusqueda1.TabIndex = 72
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pbLeyenda)
            Me.pnlBotones.Controls.Add(Me.pnlSalida)
            Me.pnlBotones.Controls.Add(Me.pnlPendientes)
            Me.pnlBotones.Controls.Add(Me.pnlRegistrarSalida)
            Me.pnlBotones.Controls.Add(Me.pnlReporte)
            Me.pnlBotones.Controls.Add(Me.pnlExportar)
            Me.pnlBotones.Controls.Add(Me.pnlNuevo)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(3, 453)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(866, 48)
            Me.pnlBotones.TabIndex = 71
            '
            'pbLeyenda
            '
            Me.pbLeyenda.Dock = System.Windows.Forms.DockStyle.Left
            Me.pbLeyenda.Image = Global.SIPPOPE.My.Resources.Resources.planilla
            Me.pbLeyenda.Location = New System.Drawing.Point(606, 0)
            Me.pbLeyenda.Name = "pbLeyenda"
            Me.pbLeyenda.Size = New System.Drawing.Size(60, 48)
            Me.pbLeyenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbLeyenda.TabIndex = 83
            Me.pbLeyenda.TabStop = False
            '
            'pnlSalida
            '
            Me.pnlSalida.Controls.Add(Me.btnSalirBusqueda)
            Me.pnlSalida.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSalida.Location = New System.Drawing.Point(511, 0)
            Me.pnlSalida.Name = "pnlSalida"
            Me.pnlSalida.Size = New System.Drawing.Size(95, 48)
            Me.pnlSalida.TabIndex = 81
            '
            'btnSalirBusqueda
            '
            Me.btnSalirBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalirBusqueda.Image = CType(resources.GetObject("btnSalirBusqueda.Image"), System.Drawing.Image)
            Me.btnSalirBusqueda.Location = New System.Drawing.Point(2, 4)
            Me.btnSalirBusqueda.Name = "btnSalirBusqueda"
            Me.btnSalirBusqueda.Size = New System.Drawing.Size(88, 40)
            Me.btnSalirBusqueda.TabIndex = 72
            Me.btnSalirBusqueda.Text = "Salir"
            Me.btnSalirBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalirBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalirBusqueda.UseVisualStyleBackColor = True
            '
            'pnlPendientes
            '
            Me.pnlPendientes.Controls.Add(Me.btnPendientes)
            Me.pnlPendientes.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlPendientes.Location = New System.Drawing.Point(393, 0)
            Me.pnlPendientes.Name = "pnlPendientes"
            Me.pnlPendientes.Size = New System.Drawing.Size(118, 48)
            Me.pnlPendientes.TabIndex = 82
            '
            'btnPendientes
            '
            Me.btnPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPendientes.Image = Global.SIPPOPE.My.Resources.Resources.Personal_information_32
            Me.btnPendientes.Location = New System.Drawing.Point(2, 4)
            Me.btnPendientes.Name = "btnPendientes"
            Me.btnPendientes.Size = New System.Drawing.Size(114, 40)
            Me.btnPendientes.TabIndex = 72
            Me.btnPendientes.Text = "&Pendientes"
            Me.btnPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPendientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnPendientes.UseVisualStyleBackColor = True
            '
            'pnlRegistrarSalida
            '
            Me.pnlRegistrarSalida.Controls.Add(Me.btnRegistarSalida)
            Me.pnlRegistrarSalida.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlRegistrarSalida.Location = New System.Drawing.Point(285, 0)
            Me.pnlRegistrarSalida.Name = "pnlRegistrarSalida"
            Me.pnlRegistrarSalida.Size = New System.Drawing.Size(108, 48)
            Me.pnlRegistrarSalida.TabIndex = 80
            '
            'btnRegistarSalida
            '
            Me.btnRegistarSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRegistarSalida.Image = Global.SIPPOPE.My.Resources.Resources.next_32
            Me.btnRegistarSalida.Location = New System.Drawing.Point(2, 4)
            Me.btnRegistarSalida.Name = "btnRegistarSalida"
            Me.btnRegistarSalida.Size = New System.Drawing.Size(103, 40)
            Me.btnRegistarSalida.TabIndex = 76
            Me.btnRegistarSalida.Text = "Reg. &Salida"
            Me.btnRegistarSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnRegistarSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnRegistarSalida.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(190, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(95, 48)
            Me.pnlReporte.TabIndex = 79
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnReporte.Location = New System.Drawing.Point(2, 4)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(88, 40)
            Me.btnReporte.TabIndex = 68
            Me.btnReporte.Text = "&Reporte"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'pnlExportar
            '
            Me.pnlExportar.Controls.Add(Me.btnExportar)
            Me.pnlExportar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlExportar.Location = New System.Drawing.Point(95, 0)
            Me.pnlExportar.Name = "pnlExportar"
            Me.pnlExportar.Size = New System.Drawing.Size(95, 48)
            Me.pnlExportar.TabIndex = 78
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(2, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 75
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlNuevo
            '
            Me.pnlNuevo.Controls.Add(Me.btnNuevo)
            Me.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlNuevo.Location = New System.Drawing.Point(0, 0)
            Me.pnlNuevo.Name = "pnlNuevo"
            Me.pnlNuevo.Size = New System.Drawing.Size(95, 48)
            Me.pnlNuevo.TabIndex = 77
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.Location = New System.Drawing.Point(2, 4)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 40)
            Me.btnNuevo.TabIndex = 73
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tbpRegistro)
            Me.TabControl1.Controls.Add(Me.tbpBusqueda)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 35)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(880, 530)
            Me.TabControl1.TabIndex = 0
            '
            'frmBuscar2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(880, 565)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "frmBuscar2"
            Me.Text = "Visita"
            Me.GroupBox1.ResumeLayout(False)
            Me.tbpRegistro.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.tbpBusqueda.ResumeLayout(False)
            Me.pnlBotones.ResumeLayout(False)
            CType(Me.pbLeyenda, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSalida.ResumeLayout(False)
            Me.pnlPendientes.ResumeLayout(False)
            Me.pnlRegistrarSalida.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlExportar.ResumeLayout(False)
            Me.pnlNuevo.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents tbpRegistro As System.Windows.Forms.TabPage
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnNuevoMov As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnBusqueda As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents tbpBusqueda As System.Windows.Forms.TabPage
        Friend WithEvents UscBusqueda1 As APPControls.Visita.uscBusqueda
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents pnlSalida As System.Windows.Forms.Panel
        Friend WithEvents btnSalirBusqueda As System.Windows.Forms.Button
        Friend WithEvents pnlPendientes As System.Windows.Forms.Panel
        Friend WithEvents btnPendientes As System.Windows.Forms.Button
        Friend WithEvents pnlRegistrarSalida As System.Windows.Forms.Panel
        Friend WithEvents btnRegistarSalida As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents pnlExportar As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents pnlNuevo As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents UscMovimientov21 As APPControls.Visita.uscMovimientov2
        Friend WithEvents pbLeyenda As System.Windows.Forms.PictureBox
        Friend WithEvents btnRegSalida As Button
    End Class
End Namespace

