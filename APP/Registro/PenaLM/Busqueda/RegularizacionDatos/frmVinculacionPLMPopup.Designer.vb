Namespace Registro.PenalLM.Busqueda


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmVinculacionPLMPopup
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
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtIDInternoSede = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnVerDiferencias = New System.Windows.Forms.Button()
            Me.btnVincular = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgwGrillaSede = New Legolas.APPUIComponents.myDatagridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgwGrillaPenal = New Legolas.APPUIComponents.myDatagridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_sed_row_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_cod_rp = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_id_tip_doc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_id_tip_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_num_doc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_pri_ape = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_pri_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_seg_ape = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_seg_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_nom = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_fec_nac = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_chk_id_nac = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_pen_id_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_sed_row_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_cod_rp = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_id_tip_doc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_id_tip_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_num_doc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_pri_ape = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_pri_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_seg_ape = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_seg_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_nom = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_fec_nac = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sed_chk_id_nac = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_sed_id_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.grbBusqueda.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgwGrillaSede, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwGrillaPenal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grbBusqueda
            '
            Me.grbBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.grbBusqueda.Controls.Add(Me.btnBuscar)
            Me.grbBusqueda.Controls.Add(Me.txtIDInternoSede)
            Me.grbBusqueda.Controls.Add(Me.Label26)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.grbBusqueda.Size = New System.Drawing.Size(1254, 51)
            Me.grbBusqueda.TabIndex = 2
            Me.grbBusqueda.TabStop = False
            '
            'btnBuscar
            '
            Me.btnBuscar.Location = New System.Drawing.Point(221, 15)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(146, 30)
            Me.btnBuscar.TabIndex = 8
            Me.btnBuscar.Text = "Buscar en Sede"
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'txtIDInternoSede
            '
            Me.txtIDInternoSede._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIDInternoSede._BloquearPaste = False
            Me.txtIDInternoSede._SeleccionarTodo = True
            Me.txtIDInternoSede.ForeColor = System.Drawing.Color.Black
            Me.txtIDInternoSede.Location = New System.Drawing.Point(116, 21)
            Me.txtIDInternoSede.MaxLength = 50
            Me.txtIDInternoSede.Name = "txtIDInternoSede"
            Me.txtIDInternoSede.Size = New System.Drawing.Size(87, 20)
            Me.txtIDInternoSede.TabIndex = 1
            Me.txtIDInternoSede.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtIDInternoSede.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(21, 24)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(71, 13)
            Me.Label26.TabIndex = 0
            Me.Label26.Text = "SedeRowID :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 354)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1254, 41)
            Me.Panel1.TabIndex = 3
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnVerDiferencias)
            Me.Panel2.Controls.Add(Me.btnVincular)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(956, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(298, 41)
            Me.Panel2.TabIndex = 2
            '
            'btnVerDiferencias
            '
            Me.btnVerDiferencias.Location = New System.Drawing.Point(5, 5)
            Me.btnVerDiferencias.Name = "btnVerDiferencias"
            Me.btnVerDiferencias.Size = New System.Drawing.Size(96, 30)
            Me.btnVerDiferencias.TabIndex = 2
            Me.btnVerDiferencias.Text = "Ver Diferencias"
            Me.btnVerDiferencias.UseVisualStyleBackColor = True
            '
            'btnVincular
            '
            Me.btnVincular.Enabled = False
            Me.btnVincular.Location = New System.Drawing.Point(107, 5)
            Me.btnVincular.Name = "btnVincular"
            Me.btnVincular.Size = New System.Drawing.Size(87, 30)
            Me.btnVincular.TabIndex = 0
            Me.btnVincular.Text = "Vincular"
            Me.btnVincular.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Location = New System.Drawing.Point(200, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(87, 30)
            Me.btnSalir.TabIndex = 1
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgwGrillaSede)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 51)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1254, 132)
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Sede Central"
            '
            'dgwGrillaSede
            '
            Me.dgwGrillaSede.AllowUserToAddRows = False
            Me.dgwGrillaSede.AllowUserToDeleteRows = False
            Me.dgwGrillaSede.AllowUserToResizeRows = False
            Me.dgwGrillaSede.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaSede.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaSede.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.col_sed_int_id, Me.col_sed_sed_row_id, Me.col_sed_chk_cod_rp, Me.col_sed_cod_rp, Me.col_sed_chk_id_tip_doc, Me.col_sed_id_tip_doc, Me.col_sed_chk_num_doc, Me.col_sed_num_doc, Me.col_sed_chk_pri_ape, Me.col_sed_pri_ape, Me.col_sed_chk_seg_ape, Me.col_sed_seg_ape, Me.col_sed_chk_nom, Me.col_sed_nom, Me.col_sed_chk_fec_nac, Me.col_sed_fec_nac, Me.col_sed_chk_id_nac, Me.col_sed_id_nac})
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaSede.DefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaSede.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaSede.GridColor = System.Drawing.Color.SkyBlue
            Me.dgwGrillaSede.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrillaSede.MultiSelect = False
            Me.dgwGrillaSede.Name = "dgwGrillaSede"
            Me.dgwGrillaSede.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaSede.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillaSede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgwGrillaSede.Size = New System.Drawing.Size(1248, 113)
            Me.dgwGrillaSede.TabIndex = 4
            Me.dgwGrillaSede.VisibleCampos = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dgwGrillaPenal)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 183)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1254, 138)
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
            Me.dgwGrillaPenal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column18, Me.col_pen_sed_row_id, Me.col_pen_chk_cod_rp, Me.col_pen_cod_rp, Me.col_pen_chk_id_tip_doc, Me.col_pen_id_tip_doc, Me.col_pen_chk_num_doc, Me.col_pen_num_doc, Me.col_pen_chk_pri_ape, Me.col_pen_pri_ape, Me.col_pen_chk_seg_ape, Me.col_pen_seg_ape, Me.col_pen_chk_nom, Me.col_pen_nom, Me.col_pen_chk_fec_nac, Me.col_pen_fec_nac, Me.col_pen_chk_id_nac, Me.col_pen_id_nac})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaPenal.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrillaPenal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaPenal.GridColor = System.Drawing.Color.SkyBlue
            Me.dgwGrillaPenal.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrillaPenal.MultiSelect = False
            Me.dgwGrillaPenal.Name = "dgwGrillaPenal"
            Me.dgwGrillaPenal.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaPenal.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrillaPenal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dgwGrillaPenal.Size = New System.Drawing.Size(1248, 119)
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
            Me.col_pen_sed_row_id.Width = 80
            '
            'col_pen_chk_cod_rp
            '
            Me.col_pen_chk_cod_rp.HeaderText = ""
            Me.col_pen_chk_cod_rp.Name = "col_pen_chk_cod_rp"
            Me.col_pen_chk_cod_rp.Width = 20
            '
            'col_pen_cod_rp
            '
            Me.col_pen_cod_rp.DataPropertyName = "int_cod_rp"
            Me.col_pen_cod_rp.HeaderText = "CodigoRP"
            Me.col_pen_cod_rp.Name = "col_pen_cod_rp"
            Me.col_pen_cod_rp.ReadOnly = True
            Me.col_pen_cod_rp.Width = 70
            '
            'col_pen_chk_id_tip_doc
            '
            Me.col_pen_chk_id_tip_doc.HeaderText = ""
            Me.col_pen_chk_id_tip_doc.Name = "col_pen_chk_id_tip_doc"
            Me.col_pen_chk_id_tip_doc.Width = 20
            '
            'col_pen_id_tip_doc
            '
            Me.col_pen_id_tip_doc.DataPropertyName = "tip_doc_id"
            Me.col_pen_id_tip_doc.HeaderText = "IDTipoDocumento"
            Me.col_pen_id_tip_doc.Name = "col_pen_id_tip_doc"
            Me.col_pen_id_tip_doc.ReadOnly = True
            '
            'col_pen_chk_num_doc
            '
            Me.col_pen_chk_num_doc.HeaderText = ""
            Me.col_pen_chk_num_doc.Name = "col_pen_chk_num_doc"
            Me.col_pen_chk_num_doc.Width = 20
            '
            'col_pen_num_doc
            '
            Me.col_pen_num_doc.DataPropertyName = "int_doc_num"
            Me.col_pen_num_doc.HeaderText = "NumeroDocumento"
            Me.col_pen_num_doc.Name = "col_pen_num_doc"
            Me.col_pen_num_doc.ReadOnly = True
            Me.col_pen_num_doc.Width = 105
            '
            'col_pen_chk_pri_ape
            '
            Me.col_pen_chk_pri_ape.HeaderText = ""
            Me.col_pen_chk_pri_ape.Name = "col_pen_chk_pri_ape"
            Me.col_pen_chk_pri_ape.Width = 20
            '
            'col_pen_pri_ape
            '
            Me.col_pen_pri_ape.DataPropertyName = "int_ape_pat"
            Me.col_pen_pri_ape.HeaderText = "PrimerApellido"
            Me.col_pen_pri_ape.Name = "col_pen_pri_ape"
            Me.col_pen_pri_ape.ReadOnly = True
            '
            'col_pen_chk_seg_ape
            '
            Me.col_pen_chk_seg_ape.HeaderText = ""
            Me.col_pen_chk_seg_ape.Name = "col_pen_chk_seg_ape"
            Me.col_pen_chk_seg_ape.Width = 20
            '
            'col_pen_seg_ape
            '
            Me.col_pen_seg_ape.DataPropertyName = "int_ape_mat"
            Me.col_pen_seg_ape.HeaderText = "SegundoApellido"
            Me.col_pen_seg_ape.Name = "col_pen_seg_ape"
            Me.col_pen_seg_ape.ReadOnly = True
            '
            'col_pen_chk_nom
            '
            Me.col_pen_chk_nom.HeaderText = ""
            Me.col_pen_chk_nom.Name = "col_pen_chk_nom"
            Me.col_pen_chk_nom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_pen_chk_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_pen_chk_nom.Width = 20
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "int_nom"
            Me.col_pen_nom.HeaderText = "Nombres"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            '
            'col_pen_chk_fec_nac
            '
            Me.col_pen_chk_fec_nac.HeaderText = ""
            Me.col_pen_chk_fec_nac.Name = "col_pen_chk_fec_nac"
            Me.col_pen_chk_fec_nac.Width = 20
            '
            'col_pen_fec_nac
            '
            Me.col_pen_fec_nac.DataPropertyName = "int_fec_nac"
            Me.col_pen_fec_nac.HeaderText = "FechaNacimiento"
            Me.col_pen_fec_nac.Name = "col_pen_fec_nac"
            Me.col_pen_fec_nac.ReadOnly = True
            Me.col_pen_fec_nac.Width = 120
            '
            'col_pen_chk_id_nac
            '
            Me.col_pen_chk_id_nac.HeaderText = ""
            Me.col_pen_chk_id_nac.Name = "col_pen_chk_id_nac"
            Me.col_pen_chk_id_nac.Width = 20
            '
            'col_pen_id_nac
            '
            Me.col_pen_id_nac.DataPropertyName = "nac_id"
            Me.col_pen_id_nac.HeaderText = "IDNacionalidad"
            Me.col_pen_id_nac.Name = "col_pen_id_nac"
            Me.col_pen_id_nac.ReadOnly = True
            Me.col_pen_id_nac.Width = 95
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "_regid"
            Me.DataGridViewTextBoxColumn9.HeaderText = "IDRegion"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            Me.DataGridViewTextBoxColumn9.Width = 65
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "_penid"
            Me.DataGridViewTextBoxColumn11.HeaderText = "IDPenal"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            Me.DataGridViewTextBoxColumn11.Width = 50
            '
            'col_sed_int_id
            '
            Me.col_sed_int_id.DataPropertyName = "int_id"
            Me.col_sed_int_id.HeaderText = "IDInterno"
            Me.col_sed_int_id.Name = "col_sed_int_id"
            Me.col_sed_int_id.ReadOnly = True
            Me.col_sed_int_id.Width = 85
            '
            'col_sed_sed_row_id
            '
            Me.col_sed_sed_row_id.DataPropertyName = "_sed_rowid"
            Me.col_sed_sed_row_id.HeaderText = "SedeRowID"
            Me.col_sed_sed_row_id.Name = "col_sed_sed_row_id"
            Me.col_sed_sed_row_id.Width = 80
            '
            'col_sed_chk_cod_rp
            '
            Me.col_sed_chk_cod_rp.HeaderText = ""
            Me.col_sed_chk_cod_rp.Name = "col_sed_chk_cod_rp"
            Me.col_sed_chk_cod_rp.Width = 20
            '
            'col_sed_cod_rp
            '
            Me.col_sed_cod_rp.DataPropertyName = "int_cod_rp"
            Me.col_sed_cod_rp.HeaderText = "CodigoRP"
            Me.col_sed_cod_rp.Name = "col_sed_cod_rp"
            Me.col_sed_cod_rp.ReadOnly = True
            Me.col_sed_cod_rp.Width = 70
            '
            'col_sed_chk_id_tip_doc
            '
            Me.col_sed_chk_id_tip_doc.HeaderText = ""
            Me.col_sed_chk_id_tip_doc.Name = "col_sed_chk_id_tip_doc"
            Me.col_sed_chk_id_tip_doc.Width = 20
            '
            'col_sed_id_tip_doc
            '
            Me.col_sed_id_tip_doc.DataPropertyName = "tip_doc_id"
            Me.col_sed_id_tip_doc.HeaderText = "IDTipoDocumento"
            Me.col_sed_id_tip_doc.Name = "col_sed_id_tip_doc"
            Me.col_sed_id_tip_doc.ReadOnly = True
            '
            'col_sed_chk_num_doc
            '
            Me.col_sed_chk_num_doc.HeaderText = ""
            Me.col_sed_chk_num_doc.Name = "col_sed_chk_num_doc"
            Me.col_sed_chk_num_doc.Width = 20
            '
            'col_sed_num_doc
            '
            Me.col_sed_num_doc.DataPropertyName = "int_doc_num"
            Me.col_sed_num_doc.HeaderText = "NumeroDocumento"
            Me.col_sed_num_doc.Name = "col_sed_num_doc"
            Me.col_sed_num_doc.ReadOnly = True
            Me.col_sed_num_doc.Width = 105
            '
            'col_sed_chk_pri_ape
            '
            Me.col_sed_chk_pri_ape.HeaderText = ""
            Me.col_sed_chk_pri_ape.Name = "col_sed_chk_pri_ape"
            Me.col_sed_chk_pri_ape.Width = 20
            '
            'col_sed_pri_ape
            '
            Me.col_sed_pri_ape.DataPropertyName = "int_ape_pat"
            Me.col_sed_pri_ape.HeaderText = "PrimerApellido"
            Me.col_sed_pri_ape.Name = "col_sed_pri_ape"
            Me.col_sed_pri_ape.ReadOnly = True
            '
            'col_sed_chk_seg_ape
            '
            Me.col_sed_chk_seg_ape.HeaderText = ""
            Me.col_sed_chk_seg_ape.Name = "col_sed_chk_seg_ape"
            Me.col_sed_chk_seg_ape.Width = 20
            '
            'col_sed_seg_ape
            '
            Me.col_sed_seg_ape.DataPropertyName = "int_ape_mat"
            Me.col_sed_seg_ape.HeaderText = "SegundoApellido"
            Me.col_sed_seg_ape.Name = "col_sed_seg_ape"
            Me.col_sed_seg_ape.ReadOnly = True
            '
            'col_sed_chk_nom
            '
            Me.col_sed_chk_nom.HeaderText = ""
            Me.col_sed_chk_nom.Name = "col_sed_chk_nom"
            Me.col_sed_chk_nom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_sed_chk_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_sed_chk_nom.Width = 20
            '
            'col_sed_nom
            '
            Me.col_sed_nom.DataPropertyName = "int_nom"
            Me.col_sed_nom.HeaderText = "Nombres"
            Me.col_sed_nom.Name = "col_sed_nom"
            Me.col_sed_nom.ReadOnly = True
            '
            'col_sed_chk_fec_nac
            '
            Me.col_sed_chk_fec_nac.HeaderText = ""
            Me.col_sed_chk_fec_nac.Name = "col_sed_chk_fec_nac"
            Me.col_sed_chk_fec_nac.Width = 20
            '
            'col_sed_fec_nac
            '
            Me.col_sed_fec_nac.DataPropertyName = "int_fec_nac"
            Me.col_sed_fec_nac.HeaderText = "FechaNacimiento"
            Me.col_sed_fec_nac.Name = "col_sed_fec_nac"
            Me.col_sed_fec_nac.ReadOnly = True
            Me.col_sed_fec_nac.Width = 120
            '
            'col_sed_chk_id_nac
            '
            Me.col_sed_chk_id_nac.HeaderText = ""
            Me.col_sed_chk_id_nac.Name = "col_sed_chk_id_nac"
            Me.col_sed_chk_id_nac.Width = 20
            '
            'col_sed_id_nac
            '
            Me.col_sed_id_nac.DataPropertyName = "nac_id"
            Me.col_sed_id_nac.HeaderText = "IDNacionalidad"
            Me.col_sed_id_nac.Name = "col_sed_id_nac"
            Me.col_sed_id_nac.ReadOnly = True
            Me.col_sed_id_nac.Width = 95
            '
            'frmVinculacionPLMPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1254, 395)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.grbBusqueda)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "frmVinculacionPLMPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Vinculacion Penal de Limametropolitana"
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgwGrillaSede, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgwGrillaPenal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbBusqueda As GroupBox
        Friend WithEvents txtIDInternoSede As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label26 As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnVincular As Button
        Friend WithEvents btnBuscar As Button
        Friend WithEvents btnSalir As Button
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents dgwGrillaPenal As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnVerDiferencias As Button
        Friend WithEvents dgwGrillaSede As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents Column18 As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_sed_row_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_cod_rp As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_cod_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_id_tip_doc As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_id_tip_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_num_doc As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_num_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_pri_ape As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_pri_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_seg_ape As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_seg_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_nom As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_fec_nac As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_fec_nac As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_chk_id_nac As DataGridViewCheckBoxColumn
        Friend WithEvents col_pen_id_nac As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_sed_row_id As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_cod_rp As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_cod_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_id_tip_doc As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_id_tip_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_num_doc As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_num_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_pri_ape As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_pri_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_seg_ape As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_seg_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_nom As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_fec_nac As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_fec_nac As DataGridViewTextBoxColumn
        Friend WithEvents col_sed_chk_id_nac As DataGridViewCheckBoxColumn
        Friend WithEvents col_sed_id_nac As DataGridViewTextBoxColumn
    End Class
End Namespace