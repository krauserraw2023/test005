Namespace Registro.Identificacion.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscFamilia
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscFamilia))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlCabeceraAlias = New System.Windows.Forms.Panel()
            Me.GroupBox11 = New System.Windows.Forms.GroupBox()
            Me.txtNumHijos = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label27 = New System.Windows.Forms.Label()
            Me.txtNHijos = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label21 = New System.Windows.Forms.Label()
            Me.pnlAliasAdd = New System.Windows.Forms.Panel()
            Me.btnModFamilia = New System.Windows.Forms.Button()
            Me.btnAddFamilia = New System.Windows.Forms.Button()
            Me.pnlAliasEliminar = New System.Windows.Forms.Panel()
            Me.btnEliFamilia = New System.Windows.Forms.Button()
            Me.dgwFamilia = New System.Windows.Forms.DataGridView()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fam_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Vive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_hij_rec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.pnlCabeceraAlias.SuspendLayout()
            Me.GroupBox11.SuspendLayout()
            Me.pnlAliasAdd.SuspendLayout()
            Me.pnlAliasEliminar.SuspendLayout()
            CType(Me.dgwFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlCabeceraAlias
            '
            Me.pnlCabeceraAlias.Controls.Add(Me.GroupBox11)
            Me.pnlCabeceraAlias.Controls.Add(Me.pnlAliasAdd)
            Me.pnlCabeceraAlias.Controls.Add(Me.pnlAliasEliminar)
            Me.pnlCabeceraAlias.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabeceraAlias.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabeceraAlias.Name = "pnlCabeceraAlias"
            Me.pnlCabeceraAlias.Size = New System.Drawing.Size(805, 45)
            Me.pnlCabeceraAlias.TabIndex = 6
            '
            'GroupBox11
            '
            Me.GroupBox11.Controls.Add(Me.txtNumHijos)
            Me.GroupBox11.Controls.Add(Me.Label27)
            Me.GroupBox11.Controls.Add(Me.txtNHijos)
            Me.GroupBox11.Controls.Add(Me.Label21)
            Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox11.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox11.Name = "GroupBox11"
            Me.GroupBox11.Size = New System.Drawing.Size(324, 45)
            Me.GroupBox11.TabIndex = 92
            Me.GroupBox11.TabStop = False
            '
            'txtNumHijos
            '
            Me.txtNumHijos._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumHijos._BloquearPaste = False
            Me.txtNumHijos._SeleccionarTodo = False
            Me.txtNumHijos.Location = New System.Drawing.Point(60, 19)
            Me.txtNumHijos.Name = "txtNumHijos"
            Me.txtNumHijos.ReadOnly = True
            Me.txtNumHijos.Size = New System.Drawing.Size(45, 20)
            Me.txtNumHijos.TabIndex = 36
            Me.txtNumHijos.Text = "0"
            Me.txtNumHijos.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumHijos.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(3, 22)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(51, 13)
            Me.Label27.TabIndex = 63
            Me.Label27.Text = "N° Hijos :"
            '
            'txtNHijos
            '
            Me.txtNHijos._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNHijos._BloquearPaste = False
            Me.txtNHijos._SeleccionarTodo = False
            Me.txtNHijos.Location = New System.Drawing.Point(242, 19)
            Me.txtNHijos.Name = "txtNHijos"
            Me.txtNHijos.ReadOnly = True
            Me.txtNHijos.Size = New System.Drawing.Size(45, 20)
            Me.txtNHijos.TabIndex = 37
            Me.txtNHijos.Text = "0"
            Me.txtNHijos.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNHijos.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(165, 22)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(75, 13)
            Me.Label21.TabIndex = 19
            Me.Label21.Text = "N° Hijos < 18 :"
            '
            'pnlAliasAdd
            '
            Me.pnlAliasAdd.Controls.Add(Me.btnModFamilia)
            Me.pnlAliasAdd.Controls.Add(Me.btnAddFamilia)
            Me.pnlAliasAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAliasAdd.Location = New System.Drawing.Point(520, 0)
            Me.pnlAliasAdd.Name = "pnlAliasAdd"
            Me.pnlAliasAdd.Size = New System.Drawing.Size(196, 45)
            Me.pnlAliasAdd.TabIndex = 91
            '
            'btnModFamilia
            '
            Me.btnModFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModFamilia.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModFamilia.Location = New System.Drawing.Point(101, 0)
            Me.btnModFamilia.Name = "btnModFamilia"
            Me.btnModFamilia.Size = New System.Drawing.Size(90, 40)
            Me.btnModFamilia.TabIndex = 89
            Me.btnModFamilia.Text = "Modificar"
            Me.btnModFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAddFamilia
            '
            Me.btnAddFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddFamilia.Image = CType(resources.GetObject("btnAddFamilia.Image"), System.Drawing.Image)
            Me.btnAddFamilia.Location = New System.Drawing.Point(5, 0)
            Me.btnAddFamilia.Name = "btnAddFamilia"
            Me.btnAddFamilia.Size = New System.Drawing.Size(88, 40)
            Me.btnAddFamilia.TabIndex = 88
            Me.btnAddFamilia.Text = "&Agregar"
            Me.btnAddFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlAliasEliminar
            '
            Me.pnlAliasEliminar.Controls.Add(Me.btnEliFamilia)
            Me.pnlAliasEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAliasEliminar.Location = New System.Drawing.Point(716, 0)
            Me.pnlAliasEliminar.Name = "pnlAliasEliminar"
            Me.pnlAliasEliminar.Size = New System.Drawing.Size(89, 45)
            Me.pnlAliasEliminar.TabIndex = 90
            '
            'btnEliFamilia
            '
            Me.btnEliFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliFamilia.Image = CType(resources.GetObject("btnEliFamilia.Image"), System.Drawing.Image)
            Me.btnEliFamilia.Location = New System.Drawing.Point(1, 0)
            Me.btnEliFamilia.Name = "btnEliFamilia"
            Me.btnEliFamilia.Size = New System.Drawing.Size(88, 40)
            Me.btnEliFamilia.TabIndex = 90
            Me.btnEliFamilia.Text = "&Eliminar"
            Me.btnEliFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgwFamilia
            '
            Me.dgwFamilia.AllowUserToAddRows = False
            Me.dgwFamilia.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwFamilia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwFamilia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_id, Me.col_num_ing, Me.col_ing_nro_inpe, Me.col_fam_id, Me.DataGridViewTextBoxColumn4, Me.Column13, Me.DataGridViewTextBoxColumn10, Me.Column11, Me.Column12, Me.col_fec_nac, Me.Vive, Me.col_hij_rec})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwFamilia.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwFamilia.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwFamilia.GridColor = System.Drawing.Color.LightGray
            Me.dgwFamilia.Location = New System.Drawing.Point(0, 45)
            Me.dgwFamilia.MultiSelect = False
            Me.dgwFamilia.Name = "dgwFamilia"
            Me.dgwFamilia.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwFamilia.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwFamilia.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwFamilia.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwFamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwFamilia.Size = New System.Drawing.Size(805, 327)
            Me.dgwFamilia.TabIndex = 8
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.HeaderText = "PenalId"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_num_ing
            '
            Me.col_num_ing.DataPropertyName = "IngresoNro"
            Me.col_num_ing.HeaderText = "Nro Ingreso"
            Me.col_num_ing.Name = "col_num_ing"
            Me.col_num_ing.ReadOnly = True
            Me.col_num_ing.Width = 50
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "Nro Ingreso"
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.ReadOnly = True
            Me.col_ing_nro_inpe.Visible = False
            Me.col_ing_nro_inpe.Width = 50
            '
            'col_fam_id
            '
            Me.col_fam_id.DataPropertyName = "Codigo"
            Me.col_fam_id.HeaderText = "FamiliaID"
            Me.col_fam_id.Name = "col_fam_id"
            Me.col_fam_id.ReadOnly = True
            Me.col_fam_id.Visible = False
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "InternoID"
            Me.DataGridViewTextBoxColumn4.HeaderText = "InternoID"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Visible = False
            '
            'Column13
            '
            Me.Column13.DataPropertyName = "FamiliarTipoNombre"
            Me.Column13.HeaderText = "Tipo Familiar"
            Me.Column13.Name = "Column13"
            Me.Column13.ReadOnly = True
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.DataPropertyName = "ApellidoPaterno"
            Me.DataGridViewTextBoxColumn10.HeaderText = "Apellido Paterno"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.ReadOnly = True
            Me.DataGridViewTextBoxColumn10.Width = 120
            '
            'Column11
            '
            Me.Column11.DataPropertyName = "ApellidoMaterno"
            Me.Column11.HeaderText = "Apellido Materno"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.Width = 120
            '
            'Column12
            '
            Me.Column12.DataPropertyName = "Nombres"
            Me.Column12.HeaderText = "Nombres"
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            '
            'col_fec_nac
            '
            Me.col_fec_nac.DataPropertyName = "FechaNacimientoDate"
            Me.col_fec_nac.HeaderText = "Fecha Nac."
            Me.col_fec_nac.Name = "col_fec_nac"
            Me.col_fec_nac.ReadOnly = True
            Me.col_fec_nac.Width = 90
            '
            'Vive
            '
            Me.Vive.DataPropertyName = "Vive"
            Me.Vive.HeaderText = "Vivo"
            Me.Vive.Name = "Vive"
            Me.Vive.ReadOnly = True
            Me.Vive.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Vive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Vive.Width = 30
            '
            'col_hij_rec
            '
            Me.col_hij_rec.DataPropertyName = "HijoReclucido"
            Me.col_hij_rec.HeaderText = "Hijo Alb."
            Me.col_hij_rec.Name = "col_hij_rec"
            Me.col_hij_rec.ReadOnly = True
            Me.col_hij_rec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_hij_rec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_hij_rec.Width = 75
            '
            'uscFamilia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwFamilia)
            Me.Controls.Add(Me.pnlCabeceraAlias)
            Me.Name = "uscFamilia"
            Me.Size = New System.Drawing.Size(805, 372)
            Me.pnlCabeceraAlias.ResumeLayout(False)
            Me.GroupBox11.ResumeLayout(False)
            Me.GroupBox11.PerformLayout()
            Me.pnlAliasAdd.ResumeLayout(False)
            Me.pnlAliasEliminar.ResumeLayout(False)
            CType(Me.dgwFamilia, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlCabeceraAlias As System.Windows.Forms.Panel
        Friend WithEvents pnlAliasAdd As System.Windows.Forms.Panel
        Friend WithEvents btnModFamilia As System.Windows.Forms.Button
        Friend WithEvents btnAddFamilia As System.Windows.Forms.Button
        Friend WithEvents pnlAliasEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliFamilia As System.Windows.Forms.Button
        Friend WithEvents dgwFamilia As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumHijos As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtNHijos As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fam_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_nac As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Vive As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_hij_rec As System.Windows.Forms.DataGridViewCheckBoxColumn

    End Class
End Namespace