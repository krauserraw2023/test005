Namespace Registro.PenalLM.Busqueda


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmUpdateIngresoInpePopup
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtIDIngreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIDIngresoInpe = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label26 = New System.Windows.Forms.Label()
            Me.nudNumIngreso = New System.Windows.Forms.NumericUpDown()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgwGrillaPenal = New Legolas.APPUIComponents.myDatagridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_sed_row_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id_tip_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_pri_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_seg_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgwGrillaIngresoInpe = New Legolas.APPUIComponents.myDatagridView()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dgwGrillaIngreso = New Legolas.APPUIComponents.myDatagridView()
            Me.grbBusqueda.SuspendLayout()
            CType(Me.nudNumIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwGrillaPenal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgwGrillaIngresoInpe, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgwGrillaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grbBusqueda
            '
            Me.grbBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.grbBusqueda.Controls.Add(Me.Label2)
            Me.grbBusqueda.Controls.Add(Me.txtIDIngreso)
            Me.grbBusqueda.Controls.Add(Me.Label1)
            Me.grbBusqueda.Controls.Add(Me.txtIDIngresoInpe)
            Me.grbBusqueda.Controls.Add(Me.Label26)
            Me.grbBusqueda.Controls.Add(Me.nudNumIngreso)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 273)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.grbBusqueda.Size = New System.Drawing.Size(1094, 51)
            Me.grbBusqueda.TabIndex = 2
            Me.grbBusqueda.TabStop = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(410, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 13)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "N° Ingreso :"
            '
            'txtIDIngreso
            '
            Me.txtIDIngreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIDIngreso._BloquearPaste = False
            Me.txtIDIngreso._SeleccionarTodo = True
            Me.txtIDIngreso.ForeColor = System.Drawing.Color.Black
            Me.txtIDIngreso.Location = New System.Drawing.Point(300, 13)
            Me.txtIDIngreso.MaxLength = 50
            Me.txtIDIngreso.Name = "txtIDIngreso"
            Me.txtIDIngreso.Size = New System.Drawing.Size(87, 20)
            Me.txtIDIngreso.TabIndex = 10
            Me.txtIDIngreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIDIngreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(225, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(59, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "ID Ingreso:"
            '
            'txtIDIngresoInpe
            '
            Me.txtIDIngresoInpe._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIDIngresoInpe._BloquearPaste = False
            Me.txtIDIngresoInpe._SeleccionarTodo = True
            Me.txtIDIngresoInpe.ForeColor = System.Drawing.Color.Black
            Me.txtIDIngresoInpe.Location = New System.Drawing.Point(107, 13)
            Me.txtIDIngresoInpe.MaxLength = 50
            Me.txtIDIngresoInpe.Name = "txtIDIngresoInpe"
            Me.txtIDIngresoInpe.Size = New System.Drawing.Size(87, 20)
            Me.txtIDIngresoInpe.TabIndex = 1
            Me.txtIDIngresoInpe.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIDIngresoInpe.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(12, 16)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(87, 13)
            Me.Label26.TabIndex = 0
            Me.Label26.Text = "ID Ingreso INPE:"
            '
            'nudNumIngreso
            '
            Me.nudNumIngreso.Location = New System.Drawing.Point(491, 13)
            Me.nudNumIngreso.Name = "nudNumIngreso"
            Me.nudNumIngreso.Size = New System.Drawing.Size(87, 20)
            Me.nudNumIngreso.TabIndex = 13
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 348)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1094, 41)
            Me.Panel1.TabIndex = 3
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnUpdate)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(898, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(196, 41)
            Me.Panel2.TabIndex = 2
            '
            'btnUpdate
            '
            Me.btnUpdate.Location = New System.Drawing.Point(7, 5)
            Me.btnUpdate.Name = "btnUpdate"
            Me.btnUpdate.Size = New System.Drawing.Size(87, 30)
            Me.btnUpdate.TabIndex = 0
            Me.btnUpdate.Text = "Actualizar"
            Me.btnUpdate.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Location = New System.Drawing.Point(100, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(87, 30)
            Me.btnSalir.TabIndex = 1
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dgwGrillaPenal)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1094, 91)
            Me.GroupBox2.TabIndex = 5
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Penal LM"
            '
            'dgwGrillaPenal
            '
            Me.dgwGrillaPenal.AllowUserToAddRows = False
            Me.dgwGrillaPenal.AllowUserToDeleteRows = False
            Me.dgwGrillaPenal.AllowUserToResizeRows = False
            Me.dgwGrillaPenal.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaPenal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaPenal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaPenal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column18, Me.col_pen_sed_row_id, Me.col_pen_cod_rp, Me.col_pen_id_tip_doc, Me.col_pen_num_doc, Me.col_pen_pri_ape, Me.col_pen_seg_ape, Me.col_pen_nom, Me.col_pen_fec_nac, Me.col_pen_id_nac})
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaPenal.DefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaPenal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaPenal.GridColor = System.Drawing.Color.SkyBlue
            Me.dgwGrillaPenal.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrillaPenal.MultiSelect = False
            Me.dgwGrillaPenal.Name = "dgwGrillaPenal"
            Me.dgwGrillaPenal.ReadOnly = True
            Me.dgwGrillaPenal.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaPenal.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillaPenal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgwGrillaPenal.Size = New System.Drawing.Size(1088, 72)
            Me.dgwGrillaPenal.TabIndex = 3
            Me.dgwGrillaPenal.VisibleCampos = False
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "_regid"
            Me.DataGridViewTextBoxColumn1.HeaderText = "IDRegion"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 65
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "_penid"
            Me.DataGridViewTextBoxColumn2.HeaderText = "IDPenal"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.Width = 50
            '
            'Column18
            '
            Me.Column18.DataPropertyName = "int_id"
            Me.Column18.HeaderText = "IDInterno"
            Me.Column18.Name = "Column18"
            Me.Column18.ReadOnly = True
            Me.Column18.Width = 85
            '
            'col_pen_sed_row_id
            '
            Me.col_pen_sed_row_id.DataPropertyName = "_sed_rowid"
            Me.col_pen_sed_row_id.HeaderText = "SedeRowID"
            Me.col_pen_sed_row_id.Name = "col_pen_sed_row_id"
            Me.col_pen_sed_row_id.ReadOnly = True
            Me.col_pen_sed_row_id.Width = 80
            '
            'col_pen_cod_rp
            '
            Me.col_pen_cod_rp.DataPropertyName = "int_cod_rp"
            Me.col_pen_cod_rp.HeaderText = "CodigoRP"
            Me.col_pen_cod_rp.Name = "col_pen_cod_rp"
            Me.col_pen_cod_rp.ReadOnly = True
            Me.col_pen_cod_rp.Width = 70
            '
            'col_pen_id_tip_doc
            '
            Me.col_pen_id_tip_doc.DataPropertyName = "tip_doc_id"
            Me.col_pen_id_tip_doc.HeaderText = "IDTipoDocumento"
            Me.col_pen_id_tip_doc.Name = "col_pen_id_tip_doc"
            Me.col_pen_id_tip_doc.ReadOnly = True
            '
            'col_pen_num_doc
            '
            Me.col_pen_num_doc.DataPropertyName = "int_doc_num"
            Me.col_pen_num_doc.HeaderText = "NumeroDocumento"
            Me.col_pen_num_doc.Name = "col_pen_num_doc"
            Me.col_pen_num_doc.ReadOnly = True
            Me.col_pen_num_doc.Width = 105
            '
            'col_pen_pri_ape
            '
            Me.col_pen_pri_ape.DataPropertyName = "int_ape_pat"
            Me.col_pen_pri_ape.HeaderText = "PrimerApellido"
            Me.col_pen_pri_ape.Name = "col_pen_pri_ape"
            Me.col_pen_pri_ape.ReadOnly = True
            '
            'col_pen_seg_ape
            '
            Me.col_pen_seg_ape.DataPropertyName = "int_ape_mat"
            Me.col_pen_seg_ape.HeaderText = "SegundoApellido"
            Me.col_pen_seg_ape.Name = "col_pen_seg_ape"
            Me.col_pen_seg_ape.ReadOnly = True
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "int_nom"
            Me.col_pen_nom.HeaderText = "Nombres"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            '
            'col_pen_fec_nac
            '
            Me.col_pen_fec_nac.DataPropertyName = "int_fec_nac"
            Me.col_pen_fec_nac.HeaderText = "FechaNacimiento"
            Me.col_pen_fec_nac.Name = "col_pen_fec_nac"
            Me.col_pen_fec_nac.ReadOnly = True
            Me.col_pen_fec_nac.Width = 120
            '
            'col_pen_id_nac
            '
            Me.col_pen_id_nac.DataPropertyName = "nac_id"
            Me.col_pen_id_nac.HeaderText = "IDNacionalidad"
            Me.col_pen_id_nac.Name = "col_pen_id_nac"
            Me.col_pen_id_nac.ReadOnly = True
            Me.col_pen_id_nac.Width = 95
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgwGrillaIngresoInpe)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 91)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1094, 91)
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Ingreso INPE"
            '
            'dgwGrillaIngresoInpe
            '
            Me.dgwGrillaIngresoInpe.AllowUserToAddRows = False
            Me.dgwGrillaIngresoInpe.AllowUserToDeleteRows = False
            Me.dgwGrillaIngresoInpe.AllowUserToResizeRows = False
            Me.dgwGrillaIngresoInpe.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaIngresoInpe.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaIngresoInpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaIngresoInpe.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrillaIngresoInpe.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaIngresoInpe.GridColor = System.Drawing.Color.SkyBlue
            Me.dgwGrillaIngresoInpe.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrillaIngresoInpe.MultiSelect = False
            Me.dgwGrillaIngresoInpe.Name = "dgwGrillaIngresoInpe"
            Me.dgwGrillaIngresoInpe.ReadOnly = True
            Me.dgwGrillaIngresoInpe.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaIngresoInpe.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrillaIngresoInpe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgwGrillaIngresoInpe.Size = New System.Drawing.Size(1088, 72)
            Me.dgwGrillaIngresoInpe.TabIndex = 3
            Me.dgwGrillaIngresoInpe.VisibleCampos = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.dgwGrillaIngreso)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox3.Location = New System.Drawing.Point(0, 182)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1094, 91)
            Me.GroupBox3.TabIndex = 7
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Ingresos"
            '
            'dgwGrillaIngreso
            '
            Me.dgwGrillaIngreso.AllowUserToAddRows = False
            Me.dgwGrillaIngreso.AllowUserToDeleteRows = False
            Me.dgwGrillaIngreso.AllowUserToResizeRows = False
            Me.dgwGrillaIngreso.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaIngreso.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgwGrillaIngreso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaIngreso.GridColor = System.Drawing.Color.SkyBlue
            Me.dgwGrillaIngreso.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrillaIngreso.MultiSelect = False
            Me.dgwGrillaIngreso.Name = "dgwGrillaIngreso"
            Me.dgwGrillaIngreso.ReadOnly = True
            Me.dgwGrillaIngreso.RowHeadersVisible = False
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaIngreso.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgwGrillaIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgwGrillaIngreso.Size = New System.Drawing.Size(1088, 72)
            Me.dgwGrillaIngreso.TabIndex = 3
            Me.dgwGrillaIngreso.VisibleCampos = False
            '
            'frmUpdateIngresoInpePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1094, 389)
            Me.Controls.Add(Me.grbBusqueda)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "frmUpdateIngresoInpePopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Actualizacion de N° Ingresos Inpe"
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            CType(Me.nudNumIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgwGrillaPenal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgwGrillaIngresoInpe, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            CType(Me.dgwGrillaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbBusqueda As GroupBox
        Friend WithEvents txtIDIngresoInpe As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label26 As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnUpdate As Button
        Friend WithEvents btnSalir As Button
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents dgwGrillaPenal As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents txtIDIngreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents nudNumIngreso As NumericUpDown
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents dgwGrillaIngresoInpe As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents GroupBox3 As GroupBox
        Friend WithEvents dgwGrillaIngreso As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents Column18 As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_sed_row_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_cod_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id_tip_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_num_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_pri_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_seg_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_fec_nac As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id_nac As DataGridViewTextBoxColumn
    End Class
End Namespace