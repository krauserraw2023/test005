
Namespace Mantenimiento.Reporte
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbCuadro = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtDelEsp = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDelGene = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
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
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_gen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_gen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_esp_str = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_id_str = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cua = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
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
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_gen_id, Me.col_cod_gen, Me.col_gen_nom, Me.col_esp_nom, Me.col_cod_esp_str, Me.col_del_id_str, Me.col_cua, Me.col_ord, Me.col_est})
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
            Me.GroupBox1.Controls.Add(Me.txtDelEsp)
            Me.GroupBox1.Controls.Add(Me.txtDelGene)
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
            Me.Label2.Location = New System.Drawing.Point(3, 82)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 48
            Me.Label2.Text = "Cuadro:"
            '
            'cbbCuadro
            '
            Me.cbbCuadro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbCuadro.FormattingEnabled = True
            Me.cbbCuadro.Location = New System.Drawing.Point(131, 77)
            Me.cbbCuadro.Name = "cbbCuadro"
            Me.cbbCuadro.Size = New System.Drawing.Size(299, 21)
            Me.cbbCuadro.TabIndex = 47
            '
            'txtDelEsp
            '
            Me.txtDelEsp._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelEsp._BloquearPaste = False
            Me.txtDelEsp._SeleccionarTodo = False
            Me.txtDelEsp.Location = New System.Drawing.Point(131, 48)
            Me.txtDelEsp.Name = "txtDelEsp"
            Me.txtDelEsp.Size = New System.Drawing.Size(299, 20)
            Me.txtDelEsp.TabIndex = 46
            Me.txtDelEsp.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelEsp.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDelGene
            '
            Me.txtDelGene._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelGene._BloquearPaste = False
            Me.txtDelGene._SeleccionarTodo = False
            Me.txtDelGene.Location = New System.Drawing.Point(131, 22)
            Me.txtDelGene.Name = "txtDelGene"
            Me.txtDelGene.Size = New System.Drawing.Size(299, 20)
            Me.txtDelGene.TabIndex = 45
            Me.txtDelGene.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelGene.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(2, 51)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(124, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "Grupo Delito Especifico :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(2, 22)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(118, 13)
            Me.Label26.TabIndex = 42
            Me.Label26.Text = "Grupo Delito Generico :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnExportar)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Controls.Add(Me.btnModificar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 481)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1087, 66)
            Me.Panel2.TabIndex = 46
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
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 150
            '
            'col_gen_id
            '
            Me.col_gen_id.DataPropertyName = "GenericoID"
            Me.col_gen_id.HeaderText = "GenericoID"
            Me.col_gen_id.Name = "col_gen_id"
            Me.col_gen_id.ReadOnly = True
            Me.col_gen_id.Visible = False
            '
            'col_cod_gen
            '
            Me.col_cod_gen.DataPropertyName = "CodigoGenerico"
            Me.col_cod_gen.HeaderText = "CodigoGenerico"
            Me.col_cod_gen.Name = "col_cod_gen"
            Me.col_cod_gen.ReadOnly = True
            Me.col_cod_gen.Visible = False
            '
            'col_gen_nom
            '
            Me.col_gen_nom.DataPropertyName = "Generico"
            Me.col_gen_nom.HeaderText = "Grupo Delito Generico"
            Me.col_gen_nom.Name = "col_gen_nom"
            Me.col_gen_nom.ReadOnly = True
            Me.col_gen_nom.Width = 350
            '
            'col_esp_nom
            '
            Me.col_esp_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_esp_nom.DataPropertyName = "Especifico"
            Me.col_esp_nom.HeaderText = "Grupo Delito Especifico"
            Me.col_esp_nom.Name = "col_esp_nom"
            Me.col_esp_nom.ReadOnly = True
            '
            'col_cod_esp_str
            '
            Me.col_cod_esp_str.DataPropertyName = "CodigoEspecifico"
            Me.col_cod_esp_str.HeaderText = "CodigoEspecifico"
            Me.col_cod_esp_str.Name = "col_cod_esp_str"
            Me.col_cod_esp_str.ReadOnly = True
            Me.col_cod_esp_str.Visible = False
            '
            'col_del_id_str
            '
            Me.col_del_id_str.DataPropertyName = "DelitoString"
            Me.col_del_id_str.HeaderText = "DelitoString"
            Me.col_del_id_str.Name = "col_del_id_str"
            Me.col_del_id_str.ReadOnly = True
            Me.col_del_id_str.Visible = False
            '
            'col_cua
            '
            Me.col_cua.DataPropertyName = "Cuadro"
            Me.col_cua.HeaderText = "Cuadro"
            Me.col_cua.Name = "col_cua"
            Me.col_cua.ReadOnly = True
            '
            'col_ord
            '
            Me.col_ord.DataPropertyName = "Orden"
            Me.col_ord.HeaderText = "Orden"
            Me.col_ord.Name = "col_ord"
            Me.col_ord.ReadOnly = True
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.HeaderText = "Estado"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
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
            Me.Text = "Mantenimiento - Padin F1-Cuadro 2 "
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
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
        Friend WithEvents txtDelEsp As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDelGene As Legolas.APPUIComponents.MyTextBox
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
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_gen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_gen As DataGridViewTextBoxColumn
        Friend WithEvents col_gen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_esp_str As DataGridViewTextBoxColumn
        Friend WithEvents col_del_id_str As DataGridViewTextBoxColumn
        Friend WithEvents col_cua As DataGridViewTextBoxColumn
        Friend WithEvents col_ord As DataGridViewTextBoxColumn
        Friend WithEvents col_est As DataGridViewTextBoxColumn
    End Class
End Namespace

