Namespace Visita.Administrativa
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscRegistroAdminv2
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UscVisitante1 = New APPControls.Visita.Visitante.uscVisitanteRegistro()
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.grbMovimiento = New System.Windows.Forms.GroupBox()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.grbObs = New System.Windows.Forms.GroupBox()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dgwMovi = New System.Windows.Forms.DataGridView()
            Me.col_mov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eli = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pbTipoDocumento = New System.Windows.Forms.PictureBox()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            Me.grbMovimiento.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.grbObs.SuspendLayout()
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.pbTipoDocumento)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(990, 256)
            Me.pnlBusqueda.TabIndex = 31
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.UscVisitante1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(503, 256)
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Datos del Visitante"
            '
            'UscVisitante1
            '
            Me.UscVisitante1._FechaVisita = CType(0, Long)
            Me.UscVisitante1._HabilitarCapHuellaValReniec = False
            Me.UscVisitante1._HabilitarHuellaDigital = False
            Me.UscVisitante1._PenalID = -1
            Me.UscVisitante1._PenalNombre = ""
            Me.UscVisitante1._RegimenTipoID = CType(-1, Short)
            Me.UscVisitante1._RegionID = -1
            Me.UscVisitante1._RegionNombre = ""
            Me.UscVisitante1._SolicitarAutoRegOrdinario = False
            Me.UscVisitante1._TipoVisita = Type.Enumeracion.Visita.EnumTipo.Ninguno
            Me.UscVisitante1._ValidarFechaNacimiento = False
            Me.UscVisitante1._ValidarModuloVisConMigraciones = False
            Me.UscVisitante1._ValidarModuloVisConReniec = False
            Me.UscVisitante1._ValidarVisitanteConMigraciones = False
            Me.UscVisitante1._ValidarVisitanteConReniec = False
            Me.UscVisitante1._VisitanteIngresaPor = CType(0, Short)
            Me.UscVisitante1._VisitanteNumeroRecaptura = CType(0, Short)
            Me.UscVisitante1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscVisitante1.Location = New System.Drawing.Point(3, 16)
            Me.UscVisitante1.Name = "UscVisitante1"
            Me.UscVisitante1.objTipoVisita = Type.Enumeracion.Visita.EnumTipo.Ninguno
            Me.UscVisitante1.Size = New System.Drawing.Size(497, 237)
            Me.UscVisitante1.TabIndex = 0
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.grbMovimiento)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 256)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(990, 224)
            Me.pnlGrilla.TabIndex = 32
            '
            'grbMovimiento
            '
            Me.grbMovimiento.Controls.Add(Me.pnlDetalle)
            Me.grbMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grbMovimiento.Name = "grbMovimiento"
            Me.grbMovimiento.Size = New System.Drawing.Size(990, 224)
            Me.grbMovimiento.TabIndex = 12
            Me.grbMovimiento.TabStop = False
            '
            'pnlDetalle
            '
            Me.pnlDetalle.Controls.Add(Me.grbObs)
            Me.pnlDetalle.Controls.Add(Me.dgwMovi)
            Me.pnlDetalle.Controls.Add(Me.Panel1)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(3, 16)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(984, 205)
            Me.pnlDetalle.TabIndex = 13
            '
            'grbObs
            '
            Me.grbObs.Controls.Add(Me.txtObservacion)
            Me.grbObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbObs.Location = New System.Drawing.Point(0, 70)
            Me.grbObs.Name = "grbObs"
            Me.grbObs.Size = New System.Drawing.Size(788, 135)
            Me.grbObs.TabIndex = 11
            Me.grbObs.TabStop = False
            Me.grbObs.Text = "Observacion"
            '
            'txtObservacion
            '
            Me.txtObservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = False
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObservacion.Location = New System.Drawing.Point(3, 16)
            Me.txtObservacion.MaxLength = 500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(782, 116)
            Me.txtObservacion.TabIndex = 10
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dgwMovi
            '
            Me.dgwMovi.AllowUserToAddRows = False
            Me.dgwMovi.AllowUserToDeleteRows = False
            Me.dgwMovi.AllowUserToOrderColumns = True
            Me.dgwMovi.AllowUserToResizeRows = False
            Me.dgwMovi.BackgroundColor = System.Drawing.Color.White
            Me.dgwMovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMovi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_mov_id, Me.Column2, Me.Column4, Me.Column3, Me.Column1, Me.Column6, Me.col_par_nom, Me.DataGridViewTextBoxColumn16, Me.Column5, Me.col_eli})
            Me.dgwMovi.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwMovi.GridColor = System.Drawing.Color.LightGray
            Me.dgwMovi.Location = New System.Drawing.Point(0, 0)
            Me.dgwMovi.MultiSelect = False
            Me.dgwMovi.Name = "dgwMovi"
            Me.dgwMovi.ReadOnly = True
            Me.dgwMovi.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwMovi.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwMovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMovi.Size = New System.Drawing.Size(788, 70)
            Me.dgwMovi.TabIndex = 9
            '
            'col_mov_id
            '
            Me.col_mov_id.DataPropertyName = "Codigo"
            Me.col_mov_id.HeaderText = "MovimientoID"
            Me.col_mov_id.Name = "col_mov_id"
            Me.col_mov_id.ReadOnly = True
            Me.col_mov_id.Visible = False
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "PaseNumero"
            Me.Column2.HeaderText = "Pase"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 60
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "VisitanteTipoDocumento"
            Me.Column4.HeaderText = "Tipo Doc."
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 80
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "VisitanteNumeroDocumento"
            Me.Column3.HeaderText = "Nro. Doc."
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 80
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "VisitanteApellidosyNombresReadonly"
            Me.Column1.HeaderText = "Visitante"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 200
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "RegimenVisitaNombreCortoReadonly"
            Me.Column6.HeaderText = "Reg. Vis."
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Width = 70
            '
            'col_par_nom
            '
            Me.col_par_nom.DataPropertyName = "ParentescoNombre"
            Me.col_par_nom.HeaderText = "Tipo Visita"
            Me.col_par_nom.Name = "col_par_nom"
            Me.col_par_nom.ReadOnly = True
            Me.col_par_nom.Width = 120
            '
            'DataGridViewTextBoxColumn16
            '
            Me.DataGridViewTextBoxColumn16.DataPropertyName = "FechaIngresoDate"
            Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha Visita"
            Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
            Me.DataGridViewTextBoxColumn16.ReadOnly = True
            Me.DataGridViewTextBoxColumn16.Width = 80
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "HoraIngreso"
            Me.Column5.HeaderText = "Hora Ing."
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 75
            '
            'col_eli
            '
            Me.col_eli.HeaderText = "Eli"
            Me.col_eli.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.col_eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_eli.Name = "col_eli"
            Me.col_eli.ReadOnly = True
            Me.col_eli.ToolTipText = "Eliminar registro"
            Me.col_eli.Width = 35
            '
            'Panel1
            '
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(788, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(196, 205)
            Me.Panel1.TabIndex = 12
            '
            'ToolTip1
            '
            Me.ToolTip1.ShowAlways = True
            '
            'pbTipoDocumento
            '
            Me.pbTipoDocumento.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbTipoDocumento.Image = Global.APPControls.My.Resources.Resources.dni
            Me.pbTipoDocumento.Location = New System.Drawing.Point(503, 0)
            Me.pbTipoDocumento.Name = "pbTipoDocumento"
            Me.pbTipoDocumento.Size = New System.Drawing.Size(487, 256)
            Me.pbTipoDocumento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbTipoDocumento.TabIndex = 5
            Me.pbTipoDocumento.TabStop = False
            '
            'uscRegistroAdminv2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Name = "uscRegistroAdminv2"
            Me.Size = New System.Drawing.Size(990, 480)
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.pnlGrilla.ResumeLayout(False)
            Me.grbMovimiento.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.grbObs.ResumeLayout(False)
            Me.grbObs.PerformLayout()
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        'Friend WithEvents cbbSexo As APPControls.uscComboParametrica
        'Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        'Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        'Friend WithEvents cbbTipo As APPControls.uscComboParametrica
        Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents grbMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents dgwMovi As System.Windows.Forms.DataGridView
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents UscVisitante1 As APPControls.Visita.Visitante.uscVisitanteRegistro
        Friend WithEvents grbObs As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents col_mov_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eli As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents pbTipoDocumento As PictureBox
    End Class

End Namespace
