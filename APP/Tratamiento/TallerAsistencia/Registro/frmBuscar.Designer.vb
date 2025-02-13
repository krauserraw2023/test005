Namespace Tratamiento.TallerAsistencia

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscar
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pri_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_fec_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pabellon = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_ico_pi = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_fot_ico_pf = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_fot_ico_pd = New System.Windows.Forms.DataGridViewImageColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pri_fec_asi = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_vinc_bio = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.pnlFotografia = New System.Windows.Forms.Panel()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.UscFotografia_2v2 = New APPControls.Foto.uscFotografia_2v()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rbtTodos = New System.Windows.Forms.RadioButton()
            Me.rbtEstadoInactivo = New System.Windows.Forms.RadioButton()
            Me.rbtEstadoActivo = New System.Windows.Forms.RadioButton()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbTalleres = New APPControls.uscComboParametrica()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtBuscaNumeroDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.rdbSexoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbMuj = New System.Windows.Forms.RadioButton()
            Me.rdbHom = New System.Windows.Forms.RadioButton()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbEstadoTodos = New System.Windows.Forms.RadioButton()
            Me.rdbInactivo = New System.Windows.Forms.RadioButton()
            Me.rdbActivo = New System.Windows.Forms.RadioButton()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblRegPrin = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscarInterno = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiarGrilla = New System.Windows.Forms.ToolStripButton()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.pnlVincularBiometrico = New System.Windows.Forms.Panel()
            Me.btnViculaBiometrico = New System.Windows.Forms.Button()
            Me.pnlNuevo = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Panel3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFotografia.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.pnlBusqueda.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlVincularBiometrico.SuspendLayout()
            Me.pnlNuevo.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.GroupBox1)
            Me.Panel3.Controls.Add(Me.pnlFotografia)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 181)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(1156, 362)
            Me.Panel3.TabIndex = 38
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgwGrilla)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(960, 362)
            Me.GroupBox1.TabIndex = 73
            Me.GroupBox1.TabStop = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_pdr, Me.col_pri_int_id, Me.col_cod_rp, Me.col_int_ape_pat, Me.col_int_ape_mat, Me.col_int_ape, Me.col_int_nom, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column6, Me.col_int_fec_nac, Me.DataGridViewTextBoxColumn6, Me.Column17, Me.col_pabellon, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom, Me.col_est_nom, Me.col_est_int, Me.col_est_gen, Me.col_fot_ico_pi, Me.col_fot_ico_pf, Me.col_fot_ico_pd, Me.DataGridViewTextBoxColumn7, Me.Column2, Me.col_pri_fec_asi, Me.col_reg_vinc_bio})
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(954, 343)
            Me.dgwGrilla.TabIndex = 0
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'col_pdr
            '
            Me.col_pdr.DataPropertyName = "CodigoPadre"
            Me.col_pdr.DividerWidth = 1
            Me.col_pdr.HeaderText = "CodigoPadre"
            Me.col_pdr.Name = "col_pdr"
            Me.col_pdr.ReadOnly = True
            Me.col_pdr.Visible = False
            '
            'col_pri_int_id
            '
            Me.col_pri_int_id.DataPropertyName = "InternoID"
            Me.col_pri_int_id.DividerWidth = 1
            Me.col_pri_int_id.HeaderText = "InternoID"
            Me.col_pri_int_id.Name = "col_pri_int_id"
            Me.col_pri_int_id.ReadOnly = True
            Me.col_pri_int_id.Visible = False
            '
            'col_cod_rp
            '
            Me.col_cod_rp.DataPropertyName = "CodigoRP"
            Me.col_cod_rp.DividerWidth = 1
            Me.col_cod_rp.HeaderText = "CodigoRp"
            Me.col_cod_rp.Name = "col_cod_rp"
            Me.col_cod_rp.ReadOnly = True
            Me.col_cod_rp.Width = 69
            '
            'col_int_ape_pat
            '
            Me.col_int_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_int_ape_pat.HeaderText = "Primer Apellido"
            Me.col_int_ape_pat.Name = "col_int_ape_pat"
            Me.col_int_ape_pat.ReadOnly = True
            Me.col_int_ape_pat.Width = 105
            '
            'col_int_ape_mat
            '
            Me.col_int_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_int_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_int_ape_mat.Name = "col_int_ape_mat"
            Me.col_int_ape_mat.ReadOnly = True
            Me.col_int_ape_mat.Width = 115
            '
            'col_int_ape
            '
            Me.col_int_ape.DataPropertyName = "Apellidos"
            Me.col_int_ape.HeaderText = "Apellidos"
            Me.col_int_ape.Name = "col_int_ape"
            Me.col_int_ape.ReadOnly = True
            Me.col_int_ape.Visible = False
            Me.col_int_ape.Width = 130
            '
            'col_int_nom
            '
            Me.col_int_nom.DataPropertyName = "Nombres"
            Me.col_int_nom.HeaderText = "Nombres"
            Me.col_int_nom.Name = "col_int_nom"
            Me.col_int_nom.ReadOnly = True
            Me.col_int_nom.Width = 130
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "SexoNombre"
            Me.Column3.HeaderText = "Sexo"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Visible = False
            Me.Column3.Width = 40
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "TipoDocumentoNombre"
            Me.Column4.HeaderText = "Tipo Doc."
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 80
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "NumeroDocumento"
            Me.Column5.HeaderText = "Numero Doc."
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 95
            '
            'Column9
            '
            Me.Column9.DataPropertyName = "TipoDocumentoyNumeroDocumento"
            Me.Column9.HeaderText = "Doc. Identidad"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.Visible = False
            Me.Column9.Width = 110
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "Edad"
            Me.Column6.HeaderText = "Edad"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Visible = False
            Me.Column6.Width = 45
            '
            'col_int_fec_nac
            '
            Me.col_int_fec_nac.DataPropertyName = "FechaNacimiento"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
            DataGridViewCellStyle9.Format = "d"
            DataGridViewCellStyle9.NullValue = Nothing
            Me.col_int_fec_nac.DefaultCellStyle = DataGridViewCellStyle9
            Me.col_int_fec_nac.HeaderText = "F. Nac."
            Me.col_int_fec_nac.Name = "col_int_fec_nac"
            Me.col_int_fec_nac.ReadOnly = True
            Me.col_int_fec_nac.Width = 67
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "NacionalidadNombre"
            Me.DataGridViewTextBoxColumn6.HeaderText = "Nacionalidad"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 70
            '
            'Column17
            '
            Me.Column17.DataPropertyName = "InternoAlias"
            Me.Column17.HeaderText = "Alias"
            Me.Column17.Name = "Column17"
            Me.Column17.ReadOnly = True
            Me.Column17.Visible = False
            '
            'col_pabellon
            '
            Me.col_pabellon.DataPropertyName = "PabellonNombre"
            Me.col_pabellon.HeaderText = "Pabellon"
            Me.col_pabellon.Name = "col_pabellon"
            Me.col_pabellon.ReadOnly = True
            Me.col_pabellon.Visible = False
            Me.col_pabellon.Width = 60
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "RegionID"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Region"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Visible = False
            Me.col_pen_nom.Width = 85
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoLaboralNombre"
            Me.col_est_nom.HeaderText = "Sit. Laboral"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 85
            '
            'col_est_int
            '
            Me.col_est_int.DataPropertyName = "EstadoNombre"
            Me.col_est_int.HeaderText = "Estado"
            Me.col_est_int.Name = "col_est_int"
            Me.col_est_int.ReadOnly = True
            Me.col_est_int.Width = 70
            '
            'col_est_gen
            '
            Me.col_est_gen.DataPropertyName = "EstadoEspecificoNombre"
            Me.col_est_gen.HeaderText = "Est. Fisico"
            Me.col_est_gen.Name = "col_est_gen"
            Me.col_est_gen.ReadOnly = True
            Me.col_est_gen.ToolTipText = "Estado fisico del interno"
            Me.col_est_gen.Visible = False
            '
            'col_fot_ico_pi
            '
            Me.col_fot_ico_pi.DataPropertyName = "FotoIconoPI"
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
            Me.col_fot_ico_pi.DefaultCellStyle = DataGridViewCellStyle10
            Me.col_fot_ico_pi.DividerWidth = 1
            Me.col_fot_ico_pi.HeaderText = "I."
            Me.col_fot_ico_pi.Name = "col_fot_ico_pi"
            Me.col_fot_ico_pi.ReadOnly = True
            Me.col_fot_ico_pi.ToolTipText = "Fotografia perfil izquierdo"
            Me.col_fot_ico_pi.Visible = False
            Me.col_fot_ico_pi.Width = 17
            '
            'col_fot_ico_pf
            '
            Me.col_fot_ico_pf.DataPropertyName = "FotoIconoPF"
            Me.col_fot_ico_pf.DividerWidth = 1
            Me.col_fot_ico_pf.HeaderText = "F."
            Me.col_fot_ico_pf.Name = "col_fot_ico_pf"
            Me.col_fot_ico_pf.ReadOnly = True
            Me.col_fot_ico_pf.ToolTipText = "Fotografia perfil frontal"
            Me.col_fot_ico_pf.Width = 18
            '
            'col_fot_ico_pd
            '
            Me.col_fot_ico_pd.DataPropertyName = "FotoIconoPD"
            Me.col_fot_ico_pd.DividerWidth = 1
            Me.col_fot_ico_pd.HeaderText = "D."
            Me.col_fot_ico_pd.Name = "col_fot_ico_pd"
            Me.col_fot_ico_pd.ReadOnly = True
            Me.col_fot_ico_pd.ToolTipText = "Fotografia perfil derecho"
            Me.col_fot_ico_pd.Visible = False
            Me.col_fot_ico_pd.Width = 18
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "EstadoRnc"
            Me.DataGridViewTextBoxColumn7.HeaderText = "Reniec"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.Width = 45
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "ActividadLaboral"
            Me.Column2.HeaderText = "Actividad Laboral"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 210
            '
            'col_pri_fec_asi
            '
            Me.col_pri_fec_asi.DataPropertyName = "FechaInscripcion"
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_pri_fec_asi.DefaultCellStyle = DataGridViewCellStyle11
            Me.col_pri_fec_asi.HeaderText = "F. Inscripción"
            Me.col_pri_fec_asi.Name = "col_pri_fec_asi"
            Me.col_pri_fec_asi.ReadOnly = True
            Me.col_pri_fec_asi.Width = 105
            '
            'col_reg_vinc_bio
            '
            Me.col_reg_vinc_bio.DataPropertyName = "BioRegistroVinculado"
            Me.col_reg_vinc_bio.HeaderText = "【☺】"
            Me.col_reg_vinc_bio.Name = "col_reg_vinc_bio"
            Me.col_reg_vinc_bio.ReadOnly = True
            Me.col_reg_vinc_bio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_reg_vinc_bio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_reg_vinc_bio.ToolTipText = "Vincular registro con el equipo biométrico"
            Me.col_reg_vinc_bio.Width = 40
            '
            'pnlFotografia
            '
            Me.pnlFotografia.Controls.Add(Me.GroupBox6)
            Me.pnlFotografia.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlFotografia.Location = New System.Drawing.Point(960, 0)
            Me.pnlFotografia.Name = "pnlFotografia"
            Me.pnlFotografia.Size = New System.Drawing.Size(196, 362)
            Me.pnlFotografia.TabIndex = 72
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.UscFotografia_2v2)
            Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.GroupBox6.Size = New System.Drawing.Size(196, 362)
            Me.GroupBox6.TabIndex = 0
            Me.GroupBox6.TabStop = False
            '
            'UscFotografia_2v2
            '
            Me.UscFotografia_2v2._CheckImagen = False
            Me.UscFotografia_2v2._EnabledDobleClick = True
            Me.UscFotografia_2v2._HasImagen = False
            Me.UscFotografia_2v2._PanelAutorizacion = False
            Me.UscFotografia_2v2._PanelCheck = False
            Me.UscFotografia_2v2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v2.Location = New System.Drawing.Point(3, 13)
            Me.UscFotografia_2v2.Name = "UscFotografia_2v2"
            Me.UscFotografia_2v2.Size = New System.Drawing.Size(190, 346)
            Me.UscFotografia_2v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v2.TabIndex = 2
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.grbBusqueda)
            Me.pnlBusqueda.Controls.Add(Me.grbBuscar)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 32)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1156, 149)
            Me.pnlBusqueda.TabIndex = 37
            '
            'grbBusqueda
            '
            Me.grbBusqueda.Controls.Add(Me.GroupBox2)
            Me.grbBusqueda.Controls.Add(Me.GroupBox3)
            Me.grbBusqueda.Controls.Add(Me.GroupBox4)
            Me.grbBusqueda.Controls.Add(Me.GroupBox5)
            Me.grbBusqueda.Controls.Add(Me.grbEstado)
            Me.grbBusqueda.Controls.Add(Me.GroupBox8)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.grbBusqueda.Size = New System.Drawing.Size(960, 149)
            Me.grbBusqueda.TabIndex = 1
            Me.grbBusqueda.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rbtTodos)
            Me.GroupBox2.Controls.Add(Me.rbtEstadoInactivo)
            Me.GroupBox2.Controls.Add(Me.rbtEstadoActivo)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(732, 105)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(222, 40)
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Estado del Interno"
            '
            'rbtTodos
            '
            Me.rbtTodos.AutoSize = True
            Me.rbtTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtTodos.Location = New System.Drawing.Point(136, 16)
            Me.rbtTodos.Name = "rbtTodos"
            Me.rbtTodos.Size = New System.Drawing.Size(61, 17)
            Me.rbtTodos.TabIndex = 2
            Me.rbtTodos.Text = "[Todos]"
            Me.rbtTodos.UseVisualStyleBackColor = True
            '
            'rbtEstadoInactivo
            '
            Me.rbtEstadoInactivo.AutoSize = True
            Me.rbtEstadoInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtEstadoInactivo.Location = New System.Drawing.Point(68, 15)
            Me.rbtEstadoInactivo.Name = "rbtEstadoInactivo"
            Me.rbtEstadoInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rbtEstadoInactivo.TabIndex = 1
            Me.rbtEstadoInactivo.Text = "Inactivo"
            Me.rbtEstadoInactivo.UseVisualStyleBackColor = True
            '
            'rbtEstadoActivo
            '
            Me.rbtEstadoActivo.AutoSize = True
            Me.rbtEstadoActivo.Checked = True
            Me.rbtEstadoActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtEstadoActivo.Location = New System.Drawing.Point(5, 15)
            Me.rbtEstadoActivo.Name = "rbtEstadoActivo"
            Me.rbtEstadoActivo.Size = New System.Drawing.Size(55, 17)
            Me.rbtEstadoActivo.TabIndex = 0
            Me.rbtEstadoActivo.TabStop = True
            Me.rbtEstadoActivo.Text = "Activo"
            Me.rbtEstadoActivo.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.cbbTalleres)
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(253, 80)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(473, 65)
            Me.GroupBox3.TabIndex = 3
            Me.GroupBox3.TabStop = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(4, 28)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(95, 13)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "Actividad Laboral :"
            '
            'cbbTalleres
            '
            Me.cbbTalleres._NoIndica = False
            Me.cbbTalleres._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTalleres._Todos = False
            Me.cbbTalleres._TodosMensaje = ""
            Me.cbbTalleres._Visible_Add = False
            Me.cbbTalleres._Visible_Buscar = False
            Me.cbbTalleres._Visible_Eliminar = False
            Me.cbbTalleres.CodigoPadre = -1
            Me.cbbTalleres.ComboTipo = CType(2, Short)
            Me.cbbTalleres.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTalleres.DropDownWidth = 160
            Me.cbbTalleres.DropDownWidthAuto = False
            Me.cbbTalleres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTalleres.ListaIdsParaExcluir = Nothing
            Me.cbbTalleres.Location = New System.Drawing.Point(115, 24)
            Me.cbbTalleres.ModuloTratamiento = False
            Me.cbbTalleres.Name = "cbbTalleres"
            Me.cbbTalleres.Parametro1 = -1
            Me.cbbTalleres.Parametro2 = -1
            Me.cbbTalleres.SelectedIndex = -1
            Me.cbbTalleres.SelectedValue = 0
            Me.cbbTalleres.Size = New System.Drawing.Size(194, 22)
            Me.cbbTalleres.TabIndex = 163
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtBuscaNumeroDocumento)
            Me.GroupBox4.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox4.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.Label8)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(253, 10)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(474, 70)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            '
            'txtBuscaNumeroDocumento
            '
            Me.txtBuscaNumeroDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtBuscaNumeroDocumento._BloquearPaste = False
            Me.txtBuscaNumeroDocumento._SeleccionarTodo = True
            Me.txtBuscaNumeroDocumento.ForeColor = System.Drawing.Color.Black
            Me.txtBuscaNumeroDocumento.Location = New System.Drawing.Point(316, 11)
            Me.txtBuscaNumeroDocumento.Name = "txtBuscaNumeroDocumento"
            Me.txtBuscaNumeroDocumento.Size = New System.Drawing.Size(155, 20)
            Me.txtBuscaNumeroDocumento.TabIndex = 2
            Me.txtBuscaNumeroDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtBuscaNumeroDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = CType(4, Short)
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 143
            Me.cbbNacionalidad.DropDownWidthAuto = False
            Me.cbbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(116, 36)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(194, 22)
            Me.cbbNacionalidad.TabIndex = 4
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = CType(2, Short)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 143
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(116, 9)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(194, 22)
            Me.cbbTipoDoc.TabIndex = 1
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(1, 13)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(115, 13)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Documento Identidad :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(4, 41)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(75, 13)
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "Nacionalidad :"
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.rdbSexoTodos)
            Me.GroupBox5.Controls.Add(Me.rdbMuj)
            Me.GroupBox5.Controls.Add(Me.rdbHom)
            Me.GroupBox5.Location = New System.Drawing.Point(732, 10)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(222, 40)
            Me.GroupBox5.TabIndex = 1
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Sexo"
            '
            'rdbSexoTodos
            '
            Me.rdbSexoTodos.AutoSize = True
            Me.rdbSexoTodos.Checked = True
            Me.rdbSexoTodos.Location = New System.Drawing.Point(139, 15)
            Me.rdbSexoTodos.Name = "rdbSexoTodos"
            Me.rdbSexoTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbSexoTodos.TabIndex = 2
            Me.rdbSexoTodos.TabStop = True
            Me.rdbSexoTodos.Text = "[Todos]"
            Me.rdbSexoTodos.UseVisualStyleBackColor = True
            '
            'rdbMuj
            '
            Me.rdbMuj.AutoSize = True
            Me.rdbMuj.Location = New System.Drawing.Point(75, 15)
            Me.rdbMuj.Name = "rdbMuj"
            Me.rdbMuj.Size = New System.Drawing.Size(62, 17)
            Me.rdbMuj.TabIndex = 1
            Me.rdbMuj.Text = "Mujeres"
            Me.rdbMuj.UseVisualStyleBackColor = True
            '
            'rdbHom
            '
            Me.rdbHom.AutoSize = True
            Me.rdbHom.Location = New System.Drawing.Point(6, 15)
            Me.rdbHom.Name = "rdbHom"
            Me.rdbHom.Size = New System.Drawing.Size(67, 17)
            Me.rdbHom.TabIndex = 0
            Me.rdbHom.Text = "Hombres"
            Me.rdbHom.UseVisualStyleBackColor = True
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbEstadoTodos)
            Me.grbEstado.Controls.Add(Me.rdbInactivo)
            Me.grbEstado.Controls.Add(Me.rdbActivo)
            Me.grbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbEstado.Location = New System.Drawing.Point(732, 57)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(222, 40)
            Me.grbEstado.TabIndex = 2
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Sit. Act. Lab."
            '
            'rdbEstadoTodos
            '
            Me.rdbEstadoTodos.AutoSize = True
            Me.rdbEstadoTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbEstadoTodos.Location = New System.Drawing.Point(136, 16)
            Me.rdbEstadoTodos.Name = "rdbEstadoTodos"
            Me.rdbEstadoTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbEstadoTodos.TabIndex = 2
            Me.rdbEstadoTodos.Text = "[Todos]"
            Me.rdbEstadoTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbInactivo.Location = New System.Drawing.Point(68, 15)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rdbInactivo.TabIndex = 1
            Me.rdbInactivo.Text = "Inactivo"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Checked = True
            Me.rdbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbActivo.Location = New System.Drawing.Point(5, 15)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(55, 17)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.TabStop = True
            Me.rdbActivo.Text = "Activo"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.txtApeMat)
            Me.GroupBox8.Controls.Add(Me.txtNom)
            Me.GroupBox8.Controls.Add(Me.txtApePat)
            Me.GroupBox8.Controls.Add(Me.txtCodInterno)
            Me.GroupBox8.Controls.Add(Me.Label9)
            Me.GroupBox8.Controls.Add(Me.Label15)
            Me.GroupBox8.Controls.Add(Me.Label16)
            Me.GroupBox8.Controls.Add(Me.Label26)
            Me.GroupBox8.Location = New System.Drawing.Point(3, 10)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(245, 136)
            Me.GroupBox8.TabIndex = 0
            Me.GroupBox8.TabStop = False
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer))
            Me.txtApeMat.Location = New System.Drawing.Point(101, 66)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(140, 20)
            Me.txtApeMat.TabIndex = 5
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(101, 97)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(140, 20)
            Me.txtNom.TabIndex = 7
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.Location = New System.Drawing.Point(101, 37)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(140, 20)
            Me.txtApePat.TabIndex = 3
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = True
            Me.txtCodInterno.ForeColor = System.Drawing.Color.Black
            Me.txtCodInterno.Location = New System.Drawing.Point(101, 9)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.Size = New System.Drawing.Size(87, 20)
            Me.txtCodInterno.TabIndex = 1
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(6, 101)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(72, 13)
            Me.Label9.TabIndex = 6
            Me.Label9.Text = "Pre nombres :"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(6, 70)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(93, 13)
            Me.Label15.TabIndex = 4
            Me.Label15.Text = "Segundo Apellido:"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(6, 41)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(82, 13)
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "Primer Apellido :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(6, 12)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 0
            Me.Label26.Text = "Código Interno :"
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblRegPrin)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(960, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(196, 149)
            Me.grbBuscar.TabIndex = 0
            Me.grbBuscar.TabStop = False
            '
            'lblRegPrin
            '
            Me.lblRegPrin.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblRegPrin.Location = New System.Drawing.Point(3, 124)
            Me.lblRegPrin.Name = "lblRegPrin"
            Me.lblRegPrin.Size = New System.Drawing.Size(190, 22)
            Me.lblRegPrin.TabIndex = 1
            Me.lblRegPrin.Text = "0 Reg."
            Me.lblRegPrin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscarInterno, Me.tsbLimpiarGrilla})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(190, 130)
            Me.ToolStrip1.TabIndex = 0
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscarInterno
            '
            Me.tsbBuscarInterno.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscarInterno.Image = CType(resources.GetObject("tsbBuscarInterno.Image"), System.Drawing.Image)
            Me.tsbBuscarInterno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscarInterno.Name = "tsbBuscarInterno"
            Me.tsbBuscarInterno.Size = New System.Drawing.Size(188, 43)
            Me.tsbBuscarInterno.Text = "Buscar"
            Me.tsbBuscarInterno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscarInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'tsbLimpiarGrilla
            '
            Me.tsbLimpiarGrilla.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiarGrilla.Image = CType(resources.GetObject("tsbLimpiarGrilla.Image"), System.Drawing.Image)
            Me.tsbLimpiarGrilla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiarGrilla.Name = "tsbLimpiarGrilla"
            Me.tsbLimpiarGrilla.Size = New System.Drawing.Size(188, 43)
            Me.tsbLimpiarGrilla.Text = "Limpiar"
            Me.tsbLimpiarGrilla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiarGrilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.tsbLimpiarGrilla.ToolTipText = "Limpiar"
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.pnlGrabar)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel8.Location = New System.Drawing.Point(0, 543)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(1156, 44)
            Me.Panel8.TabIndex = 2
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.Panel2)
            Me.pnlGrabar.Controls.Add(Me.Panel9)
            Me.pnlGrabar.Controls.Add(Me.pnlReporte)
            Me.pnlGrabar.Controls.Add(Me.pnlVincularBiometrico)
            Me.pnlGrabar.Controls.Add(Me.pnlNuevo)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrabar.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(1156, 44)
            Me.pnlGrabar.TabIndex = 70
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(490, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(177, 44)
            Me.Panel2.TabIndex = 71
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(25, Byte), Integer))
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Location = New System.Drawing.Point(4, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(165, 17)
            Me.Label1.TabIndex = 70
            Me.Label1.Text = "【☺】 Vinculado con biométrico"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Location = New System.Drawing.Point(4, 23)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(165, 17)
            Me.Label3.TabIndex = 70
            Me.Label3.Text = "【☺】 Sin vincular con biométrico"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.btnSalir)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel9.Location = New System.Drawing.Point(402, 0)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(88, 44)
            Me.Panel9.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(3, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 67
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(217, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(185, 44)
            Me.pnlReporte.TabIndex = 68
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(2, 3)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 66
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(93, 3)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(91, 40)
            Me.btnReporte.TabIndex = 1
            Me.btnReporte.Text = "&Reportes"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'pnlVincularBiometrico
            '
            Me.pnlVincularBiometrico.Controls.Add(Me.btnViculaBiometrico)
            Me.pnlVincularBiometrico.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlVincularBiometrico.Location = New System.Drawing.Point(91, 0)
            Me.pnlVincularBiometrico.Name = "pnlVincularBiometrico"
            Me.pnlVincularBiometrico.Size = New System.Drawing.Size(126, 44)
            Me.pnlVincularBiometrico.TabIndex = 69
            Me.pnlVincularBiometrico.Visible = False
            '
            'btnViculaBiometrico
            '
            Me.btnViculaBiometrico.Image = CType(resources.GetObject("btnViculaBiometrico.Image"), System.Drawing.Image)
            Me.btnViculaBiometrico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnViculaBiometrico.Location = New System.Drawing.Point(2, 3)
            Me.btnViculaBiometrico.Name = "btnViculaBiometrico"
            Me.btnViculaBiometrico.Size = New System.Drawing.Size(120, 40)
            Me.btnViculaBiometrico.TabIndex = 0
            Me.btnViculaBiometrico.Text = "Vincular con biométrico"
            Me.btnViculaBiometrico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnViculaBiometrico.UseVisualStyleBackColor = True
            '
            'pnlNuevo
            '
            Me.pnlNuevo.Controls.Add(Me.btnNuevo)
            Me.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlNuevo.Location = New System.Drawing.Point(0, 0)
            Me.pnlNuevo.Name = "pnlNuevo"
            Me.pnlNuevo.Size = New System.Drawing.Size(91, 44)
            Me.pnlNuevo.TabIndex = 41
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.SIPPOPE.My.Resources.Resources._1277961158_folder_new
            Me.btnNuevo.Location = New System.Drawing.Point(2, 3)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 40)
            Me.btnNuevo.TabIndex = 40
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'miniToolStrip
            '
            Me.miniToolStrip.AutoSize = False
            Me.miniToolStrip.BackColor = System.Drawing.Color.Transparent
            Me.miniToolStrip.CanOverflow = False
            Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
            Me.miniToolStrip.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.miniToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.miniToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.miniToolStrip.Location = New System.Drawing.Point(78, 92)
            Me.miniToolStrip.Name = "miniToolStrip"
            Me.miniToolStrip.Size = New System.Drawing.Size(190, 130)
            Me.miniToolStrip.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.cbbPenal)
            Me.Panel1.Controls.Add(Me.Label34)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.cbbRegion)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1156, 32)
            Me.Panel1.TabIndex = 39
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Location = New System.Drawing.Point(0, 29)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(1156, 3)
            Me.Label2.TabIndex = 58
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = CType(36, Short)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 238
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(313, 5)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(232, 22)
            Me.cbbPenal.TabIndex = 3
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Location = New System.Drawing.Point(249, 9)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(40, 13)
            Me.Label34.TabIndex = 2
            Me.Label34.Text = "Penal :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(3, 9)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Región :"
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = CType(37, Short)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(56, 5)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(189, 22)
            Me.cbbRegion.TabIndex = 1
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1156, 587)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.Panel8)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "frmBuscar"
            Me.Text = "Inscripcion Taller"
            Me.Panel3.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFotografia.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.pnlBusqueda.ResumeLayout(False)
            Me.grbBusqueda.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlVincularBiometrico.ResumeLayout(False)
            Me.pnlNuevo.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents pnlFotografia As System.Windows.Forms.Panel
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents UscFotografia_2v2 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblRegPrin As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscarInterno As System.Windows.Forms.ToolStripButton
        Public WithEvents tsbLimpiarGrilla As System.Windows.Forms.ToolStripButton
        Friend WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
        Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents txtBuscaNumeroDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSexoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbMuj As System.Windows.Forms.RadioButton
        Friend WithEvents rdbHom As System.Windows.Forms.RadioButton
        Friend WithEvents grbEstado As System.Windows.Forms.GroupBox
        Friend WithEvents rdbEstadoTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents pnlNuevo As System.Windows.Forms.Panel
        Friend WithEvents cbbTalleres As APPControls.uscComboParametrica
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents rbtTodos As RadioButton
        Friend WithEvents rbtEstadoInactivo As RadioButton
        Friend WithEvents rbtEstadoActivo As RadioButton
        Friend WithEvents pnlVincularBiometrico As Panel
        Friend WithEvents btnViculaBiometrico As Button
        Friend WithEvents Label3 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_pdr As DataGridViewTextBoxColumn
        Friend WithEvents col_pri_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_int_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_int_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_int_ape As DataGridViewTextBoxColumn
        Friend WithEvents col_int_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents Column9 As DataGridViewTextBoxColumn
        Friend WithEvents Column6 As DataGridViewTextBoxColumn
        Friend WithEvents col_int_fec_nac As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents Column17 As DataGridViewTextBoxColumn
        Friend WithEvents col_pabellon As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_est_int As DataGridViewTextBoxColumn
        Friend WithEvents col_est_gen As DataGridViewTextBoxColumn
        Friend WithEvents col_fot_ico_pi As DataGridViewImageColumn
        Friend WithEvents col_fot_ico_pf As DataGridViewImageColumn
        Friend WithEvents col_fot_ico_pd As DataGridViewImageColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents col_pri_fec_asi As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_vinc_bio As DataGridViewCheckBoxColumn
    End Class
End Namespace