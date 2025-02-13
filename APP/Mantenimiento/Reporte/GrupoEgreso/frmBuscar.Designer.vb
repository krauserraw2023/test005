
Namespace Mantenimiento.Reporte.GrupoEgreso
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_egr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_tbl = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ver_rpt = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbCuadro = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtNombreDet = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnMigrar = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DetalleEspecificoCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.Location = New System.Drawing.Point(6, 10)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(88, 53)
            Me.btnModificar.TabIndex = 1
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(190, 10)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 53)
            Me.btnSalir.TabIndex = 6
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToOrderColumns = True
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_tip_egr, Me.col_nom_tbl, Me.col_nom, Me.col_nom_det, Me.col_ver_rpt, Me.col_ord})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 117)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1087, 364)
            Me.dgwGrilla.TabIndex = 45
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 150
            '
            'col_tip_egr
            '
            Me.col_tip_egr.DataPropertyName = "TipoEgresoNombre"
            Me.col_tip_egr.HeaderText = "Tipo Egreso"
            Me.col_tip_egr.Name = "col_tip_egr"
            Me.col_tip_egr.ReadOnly = True
            Me.col_tip_egr.Width = 130
            '
            'col_nom_tbl
            '
            Me.col_nom_tbl.DataPropertyName = "TipoEgresoTabla"
            Me.col_nom_tbl.HeaderText = "Nombre Tabla"
            Me.col_nom_tbl.Name = "col_nom_tbl"
            Me.col_nom_tbl.ReadOnly = True
            Me.col_nom_tbl.Width = 130
            '
            'col_nom
            '
            Me.col_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nom.DataPropertyName = "Nombre"
            Me.col_nom.HeaderText = "Nombre"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            '
            'col_nom_det
            '
            Me.col_nom_det.DataPropertyName = "NombreDetalle"
            Me.col_nom_det.HeaderText = "Nombre Detalle"
            Me.col_nom_det.Name = "col_nom_det"
            Me.col_nom_det.ReadOnly = True
            Me.col_nom_det.Width = 400
            '
            'col_ver_rpt
            '
            Me.col_ver_rpt.DataPropertyName = "cuadro"
            Me.col_ver_rpt.HeaderText = "Version Reporte"
            Me.col_ver_rpt.Name = "col_ver_rpt"
            Me.col_ver_rpt.ReadOnly = True
            Me.col_ver_rpt.Width = 120
            '
            'col_ord
            '
            Me.col_ord.DataPropertyName = "Orden"
            Me.col_ord.HeaderText = "Orden"
            Me.col_ord.Name = "col_ord"
            Me.col_ord.ReadOnly = True
            '
            'lblReg
            '
            Me.lblReg.Location = New System.Drawing.Point(10, 84)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(64, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.lblReg)
            Me.GroupBox3.Controls.Add(Me.ToolStrip1)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox3.Location = New System.Drawing.Point(1004, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(83, 117)
            Me.GroupBox3.TabIndex = 39
            Me.GroupBox3.TabStop = False
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 98)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox3)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1087, 117)
            Me.pnlBusqueda.TabIndex = 47
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.cbbCuadro)
            Me.GroupBox1.Controls.Add(Me.txtNombreDet)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1004, 117)
            Me.GroupBox1.TabIndex = 43
            Me.GroupBox1.TabStop = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(3, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 48
            Me.Label2.Text = "Cuadro:"
            '
            'cbbCuadro
            '
            Me.cbbCuadro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbCuadro.FormattingEnabled = True
            Me.cbbCuadro.Location = New System.Drawing.Point(110, 77)
            Me.cbbCuadro.Name = "cbbCuadro"
            Me.cbbCuadro.Size = New System.Drawing.Size(299, 21)
            Me.cbbCuadro.TabIndex = 47
            '
            'txtNombreDet
            '
            Me.txtNombreDet._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombreDet._BloquearPaste = False
            Me.txtNombreDet._SeleccionarTodo = False
            Me.txtNombreDet.Location = New System.Drawing.Point(110, 48)
            Me.txtNombreDet.Name = "txtNombreDet"
            Me.txtNombreDet.Size = New System.Drawing.Size(299, 20)
            Me.txtNombreDet.TabIndex = 46
            Me.txtNombreDet.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombreDet.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(110, 22)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(299, 20)
            Me.txtNombre.TabIndex = 45
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(2, 51)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "Nombre Detalle:"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(2, 22)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(47, 13)
            Me.Label26.TabIndex = 42
            Me.Label26.Text = "Nombre:"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Controls.Add(Me.btnExportar)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Controls.Add(Me.btnModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 481)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1087, 66)
            Me.Panel2.TabIndex = 46
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnMigrar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(993, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(94, 66)
            Me.Panel1.TabIndex = 74
            '
            'btnMigrar
            '
            Me.btnMigrar.Enabled = False
            Me.btnMigrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMigrar.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnMigrar.Location = New System.Drawing.Point(3, 10)
            Me.btnMigrar.Name = "btnMigrar"
            Me.btnMigrar.Size = New System.Drawing.Size(88, 53)
            Me.btnMigrar.TabIndex = 73
            Me.btnMigrar.Text = "&Migrar"
            Me.btnMigrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnMigrar.UseVisualStyleBackColor = True
            Me.btnMigrar.Visible = False
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(100, 10)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(84, 53)
            Me.btnExportar.TabIndex = 72
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AllowUserToOrderColumns = True
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.DetalleEspecificoCodigo, Me.Column6})
            Me.DataGridView1.Location = New System.Drawing.Point(40, 142)
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DataGridView1.Size = New System.Drawing.Size(723, 159)
            Me.DataGridView1.TabIndex = 73
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "Codigo"
            Me.Column1.HeaderText = "Codigo"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "CodigoGenerico"
            Me.Column2.HeaderText = "CodigoGenerico"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Generico"
            Me.Column3.HeaderText = "Generico"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "Especifico"
            Me.Column4.HeaderText = "Especifico"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "DetalleGenerico"
            Me.Column5.HeaderText = "DetalleGenerico"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            '
            'DetalleEspecificoCodigo
            '
            Me.DetalleEspecificoCodigo.DataPropertyName = "DetalleEspecificoCodigo"
            Me.DetalleEspecificoCodigo.HeaderText = "DetalleEspecificoCodigo"
            Me.DetalleEspecificoCodigo.Name = "DetalleEspecificoCodigo"
            Me.DetalleEspecificoCodigo.ReadOnly = True
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "DetalleEspecifico"
            Me.Column6.HeaderText = "DetalleEspecifico"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1087, 547)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.DataGridView1)
            Me.Name = "frmBuscar"
            Me.Text = "Mantenimiento del Cuadro 13 - Reporte"
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents txtNombreDet As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DetalleEspecificoCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label2 As Label
        Friend WithEvents cbbCuadro As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnMigrar As Button
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_egr As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_tbl As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_det As DataGridViewTextBoxColumn
        Friend WithEvents col_ver_rpt As DataGridViewTextBoxColumn
        Friend WithEvents col_ord As DataGridViewTextBoxColumn
    End Class
End Namespace

