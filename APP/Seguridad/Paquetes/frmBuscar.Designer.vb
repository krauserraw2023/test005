Namespace Seguridad.Paquetes
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscar
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.tbpRegistro = New System.Windows.Forms.TabPage()
            Me.UscRegistroDetalle1 = New APPControls.Seguridad.Paquetes.uscRegistroDetalle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnNuevoMov = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.tbpBusqueda = New System.Windows.Forms.TabPage()
            Me.UscBusqueda1 = New APPControls.Seguridad.Paquetes.uscBusquedaPaquete()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.pnlSalida = New System.Windows.Forms.Panel()
            Me.btnSalirBusqueda = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlNuevo = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.btnVerPaquetes = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.tbpRegistro.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.tbpBusqueda.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            Me.pnlSalida.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
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
            Me.GroupBox1.Size = New System.Drawing.Size(1331, 35)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            '
            'UsrRegionPenal1
            '
            Me.UsrRegionPenal1._LicenciaID = -1
            Me.UsrRegionPenal1._NivelUsuario = CType(-1, Short)
            Me.UsrRegionPenal1._PenalID = 0
            Me.UsrRegionPenal1._PenalTodos = True
            Me.UsrRegionPenal1._PerfilUsuario = CType(-1, Short)
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
            Me.tbpRegistro.Controls.Add(Me.UscRegistroDetalle1)
            Me.tbpRegistro.Controls.Add(Me.Panel1)
            Me.tbpRegistro.Location = New System.Drawing.Point(4, 22)
            Me.tbpRegistro.Name = "tbpRegistro"
            Me.tbpRegistro.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpRegistro.Size = New System.Drawing.Size(1323, 504)
            Me.tbpRegistro.TabIndex = 1
            Me.tbpRegistro.Text = "Registro de paquetes"
            Me.tbpRegistro.UseVisualStyleBackColor = True
            '
            'UscRegistroDetalle1
            '
            Me.UscRegistroDetalle1._idPenal = CType(-1, Short)
            Me.UscRegistroDetalle1._idRegion = CType(-1, Short)
            Me.UscRegistroDetalle1._penalNombre = ""
            Me.UscRegistroDetalle1._regionNombre = ""
            Me.UscRegistroDetalle1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscRegistroDetalle1.Location = New System.Drawing.Point(3, 3)
            Me.UscRegistroDetalle1.Name = "UscRegistroDetalle1"
            Me.UscRegistroDetalle1.Size = New System.Drawing.Size(1317, 450)
            Me.UscRegistroDetalle1.TabIndex = 75
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnVerPaquetes)
            Me.Panel1.Controls.Add(Me.btnNuevoMov)
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Controls.Add(Me.btnGrabar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(3, 453)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1317, 48)
            Me.Panel1.TabIndex = 72
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
            Me.btnSalir.Location = New System.Drawing.Point(321, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 40)
            Me.btnSalir.TabIndex = 71
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
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
            Me.tbpBusqueda.Size = New System.Drawing.Size(1323, 504)
            Me.tbpBusqueda.TabIndex = 0
            Me.tbpBusqueda.Text = "Paquetes ingresados"
            Me.tbpBusqueda.UseVisualStyleBackColor = True
            '
            'UscBusqueda1
            '
            Me.UscBusqueda1._idPenal = -1
            Me.UscBusqueda1._idRegion = -1
            Me.UscBusqueda1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscBusqueda1.Location = New System.Drawing.Point(3, 3)
            Me.UscBusqueda1.Name = "UscBusqueda1"
            Me.UscBusqueda1.Size = New System.Drawing.Size(1317, 450)
            Me.UscBusqueda1.TabIndex = 72
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pnlSalida)
            Me.pnlBotones.Controls.Add(Me.pnlReporte)
            Me.pnlBotones.Controls.Add(Me.pnlNuevo)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(3, 453)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(1317, 48)
            Me.pnlBotones.TabIndex = 71
            '
            'pnlSalida
            '
            Me.pnlSalida.Controls.Add(Me.btnSalirBusqueda)
            Me.pnlSalida.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSalida.Location = New System.Drawing.Point(288, 0)
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
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(95, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(193, 48)
            Me.pnlReporte.TabIndex = 79
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnReporte.Location = New System.Drawing.Point(97, 5)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(88, 40)
            Me.btnReporte.TabIndex = 68
            Me.btnReporte.Text = "&Reporte"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(3, 4)
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
            Me.TabControl1.Size = New System.Drawing.Size(1331, 530)
            Me.TabControl1.TabIndex = 0
            '
            'btnVerPaquetes
            '
            Me.btnVerPaquetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVerPaquetes.Image = Global.SIPPOPE.My.Resources.Resources.Search_files_32
            Me.btnVerPaquetes.Location = New System.Drawing.Point(194, 4)
            Me.btnVerPaquetes.Name = "btnVerPaquetes"
            Me.btnVerPaquetes.Size = New System.Drawing.Size(120, 40)
            Me.btnVerPaquetes.TabIndex = 75
            Me.btnVerPaquetes.Text = "Ver Paquetes"
            Me.btnVerPaquetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVerPaquetes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnVerPaquetes.UseVisualStyleBackColor = True
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1331, 565)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "frmBuscar"
            Me.Text = "Modulo de Paquetes"
            Me.GroupBox1.ResumeLayout(False)
            Me.tbpRegistro.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.tbpBusqueda.ResumeLayout(False)
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlSalida.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
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
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents tbpBusqueda As System.Windows.Forms.TabPage
        Friend WithEvents UscBusqueda1 As APPControls.Seguridad.Paquetes.uscBusquedaPaquete
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents pnlSalida As System.Windows.Forms.Panel
        Friend WithEvents btnSalirBusqueda As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents pnlNuevo As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents UscRegistroDetalle1 As APPControls.Seguridad.Paquetes.uscRegistroDetalle
        Friend WithEvents btnVerPaquetes As Button
    End Class
End Namespace

