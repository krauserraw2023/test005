Namespace Visita.Programacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantenimiento
        Inherits Legolas.APPUIComponents.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimiento))
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblRegimenVisitaNom = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblTipoVisita = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.UscRegionPenalLabel1 = New APPControls.uscRegionPenalLabel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.UscProgramacionBusqueda1 = New APPControls.Visita.Programacion.uscProgramacionBusqueda()
            Me.pnlBoton = New System.Windows.Forms.Panel()
            Me.pnlBotonDer = New System.Windows.Forms.Panel()
            Me.pnlModificar = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlBoton.SuspendLayout()
            Me.pnlBotonDer.SuspendLayout()
            Me.pnlModificar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblRegimenVisitaNom)
            Me.GroupBox2.Location = New System.Drawing.Point(5, 13)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(292, 49)
            Me.GroupBox2.TabIndex = 15
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Regimen de Visita :"
            '
            'lblRegimenVisitaNom
            '
            Me.lblRegimenVisitaNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblRegimenVisitaNom.Location = New System.Drawing.Point(15, 19)
            Me.lblRegimenVisitaNom.Name = "lblRegimenVisitaNom"
            Me.lblRegimenVisitaNom.Size = New System.Drawing.Size(260, 23)
            Me.lblRegimenVisitaNom.TabIndex = 1
            Me.lblRegimenVisitaNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblTipoVisita)
            Me.GroupBox1.Location = New System.Drawing.Point(303, 13)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(228, 49)
            Me.GroupBox1.TabIndex = 14
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Tipo Visita :"
            '
            'lblTipoVisita
            '
            Me.lblTipoVisita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTipoVisita.Location = New System.Drawing.Point(10, 19)
            Me.lblTipoVisita.Name = "lblTipoVisita"
            Me.lblTipoVisita.Size = New System.Drawing.Size(209, 23)
            Me.lblTipoVisita.TabIndex = 0
            Me.lblTipoVisita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox3.Controls.Add(Me.UscRegionPenalLabel1)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(866, 37)
            Me.GroupBox3.TabIndex = 92
            Me.GroupBox3.TabStop = False
            '
            'UscRegionPenalLabel1
            '
            Me.UscRegionPenalLabel1._Penalid = -1
            Me.UscRegionPenalLabel1._PenalNombre = "************"
            Me.UscRegionPenalLabel1._RegionId = -1
            Me.UscRegionPenalLabel1._RegionNombre = "************"
            Me.UscRegionPenalLabel1._WidthRegion = 250
            Me.UscRegionPenalLabel1.BackColor = System.Drawing.Color.Transparent
            Me.UscRegionPenalLabel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscRegionPenalLabel1.Location = New System.Drawing.Point(3, 16)
            Me.UscRegionPenalLabel1.Margin = New System.Windows.Forms.Padding(1)
            Me.UscRegionPenalLabel1.Name = "UscRegionPenalLabel1"
            Me.UscRegionPenalLabel1.Size = New System.Drawing.Size(860, 18)
            Me.UscRegionPenalLabel1.TabIndex = 0
            Me.UscRegionPenalLabel1.UsuarioID = -1
            Me.UscRegionPenalLabel1.VersionInstalacionFile = 0
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox4.Controls.Add(Me.GroupBox2)
            Me.GroupBox4.Controls.Add(Me.GroupBox1)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 37)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(866, 69)
            Me.GroupBox4.TabIndex = 93
            Me.GroupBox4.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(866, 106)
            Me.Panel1.TabIndex = 95
            '
            'UscProgramacionBusqueda1
            '
            Me.UscProgramacionBusqueda1._CalendarioID = -1
            Me.UscProgramacionBusqueda1._InternoApellidosyNombres = "[SELECCIONE]"
            Me.UscProgramacionBusqueda1._InternoID = -1
            Me.UscProgramacionBusqueda1._PenalID = CType(-1, Short)
            Me.UscProgramacionBusqueda1._RegimenVisitaID = CType(-1, Short)
            Me.UscProgramacionBusqueda1._RegionID = CType(-1, Short)
            Me.UscProgramacionBusqueda1._TipoVisitaID = CType(-1, Short)
            Me.UscProgramacionBusqueda1._VisibleBotonAdd = True
            Me.UscProgramacionBusqueda1.BackColor = System.Drawing.Color.Transparent
            Me.UscProgramacionBusqueda1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscProgramacionBusqueda1.Location = New System.Drawing.Point(0, 106)
            Me.UscProgramacionBusqueda1.Name = "UscProgramacionBusqueda1"
            Me.UscProgramacionBusqueda1.Size = New System.Drawing.Size(866, 341)
            Me.UscProgramacionBusqueda1.TabIndex = 96
            '
            'pnlBoton
            '
            Me.pnlBoton.Controls.Add(Me.pnlBotonDer)
            Me.pnlBoton.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBoton.Location = New System.Drawing.Point(0, 447)
            Me.pnlBoton.Name = "pnlBoton"
            Me.pnlBoton.Size = New System.Drawing.Size(866, 48)
            Me.pnlBoton.TabIndex = 97
            '
            'pnlBotonDer
            '
            Me.pnlBotonDer.Controls.Add(Me.pnlModificar)
            Me.pnlBotonDer.Controls.Add(Me.Panel2)
            Me.pnlBotonDer.Controls.Add(Me.pnlEliminar)
            Me.pnlBotonDer.Controls.Add(Me.pnlSalir)
            Me.pnlBotonDer.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotonDer.Location = New System.Drawing.Point(348, 0)
            Me.pnlBotonDer.Name = "pnlBotonDer"
            Me.pnlBotonDer.Size = New System.Drawing.Size(518, 48)
            Me.pnlBotonDer.TabIndex = 67
            '
            'pnlModificar
            '
            Me.pnlModificar.Controls.Add(Me.btnGrabar)
            Me.pnlModificar.Controls.Add(Me.btnAnular)
            Me.pnlModificar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlModificar.Location = New System.Drawing.Point(61, 0)
            Me.pnlModificar.Name = "pnlModificar"
            Me.pnlModificar.Size = New System.Drawing.Size(185, 48)
            Me.pnlModificar.TabIndex = 91
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGrabar.Location = New System.Drawing.Point(3, 3)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(88, 40)
            Me.btnGrabar.TabIndex = 38
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnAnular.Location = New System.Drawing.Point(95, 3)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(88, 40)
            Me.btnAnular.TabIndex = 90
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(341, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(93, 48)
            Me.pnlEliminar.TabIndex = 92
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(3, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(88, 40)
            Me.btnEliminar.TabIndex = 89
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(434, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(84, 48)
            Me.pnlSalir.TabIndex = 93
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(1, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 40
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(3, 3)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 68
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnExportar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(246, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(95, 48)
            Me.Panel2.TabIndex = 98
            '
            'frmMantenimiento
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(866, 495)
            Me.Controls.Add(Me.UscProgramacionBusqueda1)
            Me.Controls.Add(Me.pnlBoton)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "frmMantenimiento"
            Me.Text = "Horario - Mantenimiento"
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlBoton.ResumeLayout(False)
            Me.pnlBotonDer.ResumeLayout(False)
            Me.pnlModificar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents UscRegionPenalLabel1 As APPControls.uscRegionPenalLabel
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        'Friend WithEvents UscBusquedaMovimiento1 As APPControls.Visita.Programacion.uscProgramacionBusqueda
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents UscProgramacionBusqueda1 As APPControls.Visita.Programacion.uscProgramacionBusqueda
        Friend WithEvents pnlBoton As System.Windows.Forms.Panel
        Friend WithEvents pnlBotonDer As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents lblTipoVisita As System.Windows.Forms.Label
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents pnlModificar As System.Windows.Forms.Panel
        Friend WithEvents lblRegimenVisitaNom As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
    End Class

End Namespace