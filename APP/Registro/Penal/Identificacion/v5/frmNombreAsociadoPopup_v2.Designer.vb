Namespace Registro.Penal.Identificacion.v5


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmNombreAsociadoPopup_v2
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNombreAsociadoPopup_v2))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.gbTiponombre = New System.Windows.Forms.GroupBox()
            Me.rdbAsociado = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPrincipal = New Legolas.APPUIComponents.myRadioButton()
            Me.Panel11 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtApePaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.grbNombreAso = New System.Windows.Forms.GroupBox()
            Me.dgwNomAsoc = New System.Windows.Forms.DataGridView()
            Me.grbNombres = New System.Windows.Forms.GroupBox()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_asoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_prin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_prin2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_aclara = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_img = New System.Windows.Forms.DataGridViewImageColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.gbTiponombre.SuspendLayout()
            Me.Panel11.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.grbNombreAso.SuspendLayout()
            CType(Me.dgwNomAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grbNombres.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbNombreAso)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel11)
            Me.gbxFormChildContainer.Controls.Add(Me.grbNombres)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(386, 260)
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAgregar.Location = New System.Drawing.Point(106, 4)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(85, 41)
            Me.btnAgregar.TabIndex = 0
            Me.btnAgregar.Text = "&Agregar"
            Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancelar.Location = New System.Drawing.Point(193, 4)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(91, 41)
            Me.btnCancelar.TabIndex = 1
            Me.btnCancelar.Text = "&Modificar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(289, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(97, 50)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(3, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(90, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'gbTiponombre
            '
            Me.gbTiponombre.Controls.Add(Me.rdbAsociado)
            Me.gbTiponombre.Controls.Add(Me.rdbPrincipal)
            Me.gbTiponombre.Location = New System.Drawing.Point(129, 104)
            Me.gbTiponombre.Name = "gbTiponombre"
            Me.gbTiponombre.Size = New System.Drawing.Size(211, 46)
            Me.gbTiponombre.TabIndex = 6
            Me.gbTiponombre.TabStop = False
            Me.gbTiponombre.Text = "Tipo de nombre"
            '
            'rdbAsociado
            '
            Me.rdbAsociado.AutoSize = True
            Me.rdbAsociado.Checked = True
            Me.rdbAsociado.Location = New System.Drawing.Point(96, 20)
            Me.rdbAsociado.Name = "rdbAsociado"
            Me.rdbAsociado.Size = New System.Drawing.Size(69, 17)
            Me.rdbAsociado.TabIndex = 1
            Me.rdbAsociado.TabStop = True
            Me.rdbAsociado.Text = "Asociado"
            Me.rdbAsociado.UseVisualStyleBackColor = True
            '
            'rdbPrincipal
            '
            Me.rdbPrincipal.AutoSize = True
            Me.rdbPrincipal.Location = New System.Drawing.Point(10, 20)
            Me.rdbPrincipal.Name = "rdbPrincipal"
            Me.rdbPrincipal.Size = New System.Drawing.Size(65, 17)
            Me.rdbPrincipal.TabIndex = 0
            Me.rdbPrincipal.Text = "Principal"
            Me.rdbPrincipal.UseVisualStyleBackColor = True
            '
            'Panel11
            '
            Me.Panel11.Controls.Add(Me.UscAuditUser1)
            Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel11.Location = New System.Drawing.Point(0, 210)
            Me.Panel11.Name = "Panel11"
            Me.Panel11.Size = New System.Drawing.Size(386, 50)
            Me.Panel11.TabIndex = 8
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(31, 30)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(90, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Primer Apellido :"
            '
            'txtApePaterno
            '
            Me.txtApePaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePaterno._BloquearPaste = True
            Me.txtApePaterno._SeleccionarTodo = False
            Me.txtApePaterno.Location = New System.Drawing.Point(129, 28)
            Me.txtApePaterno.Name = "txtApePaterno"
            Me.txtApePaterno.Size = New System.Drawing.Size(211, 20)
            Me.txtApePaterno.TabIndex = 1
            Me.txtApePaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(31, 58)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Segundo Apellido :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(31, 85)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombres :"
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = True
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(129, 80)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(211, 20)
            Me.txtNombre.TabIndex = 5
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApeMaterno
            '
            Me.txtApeMaterno._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMaterno._BloquearPaste = True
            Me.txtApeMaterno._SeleccionarTodo = False
            Me.txtApeMaterno.Location = New System.Drawing.Point(129, 54)
            Me.txtApeMaterno.Name = "txtApeMaterno"
            Me.txtApeMaterno.Size = New System.Drawing.Size(211, 20)
            Me.txtApeMaterno.TabIndex = 3
            Me.txtApeMaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.pnlSalir)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 160)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(386, 50)
            Me.Panel1.TabIndex = 10
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnCancelar)
            Me.Panel4.Controls.Add(Me.btnAgregar)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(289, 50)
            Me.Panel4.TabIndex = 2
            '
            'grbNombreAso
            '
            Me.grbNombreAso.Controls.Add(Me.dgwNomAsoc)
            Me.grbNombreAso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbNombreAso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbNombreAso.Location = New System.Drawing.Point(0, 0)
            Me.grbNombreAso.Name = "grbNombreAso"
            Me.grbNombreAso.Size = New System.Drawing.Size(386, 160)
            Me.grbNombreAso.TabIndex = 11
            Me.grbNombreAso.TabStop = False
            '
            'dgwNomAsoc
            '
            Me.dgwNomAsoc.AllowUserToAddRows = False
            Me.dgwNomAsoc.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgwNomAsoc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwNomAsoc.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwNomAsoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwNomAsoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwNomAsoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel, Me.col_codigo, Me.col_doc_jud_id, Me.col_int_nom_aso_id, Me.col_nom_asoc, Me.DataGridViewTextBoxColumn3, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_prin, Me.col_est_id, Me.name1, Me.col_ape_pat2, Me.col_ape_mat2, Me.col_nom2, Me.col_prin2, Me.col_nom_aclara, Me.col_img})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwNomAsoc.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwNomAsoc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwNomAsoc.GridColor = System.Drawing.Color.LightGray
            Me.dgwNomAsoc.Location = New System.Drawing.Point(3, 16)
            Me.dgwNomAsoc.MultiSelect = False
            Me.dgwNomAsoc.Name = "dgwNomAsoc"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwNomAsoc.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwNomAsoc.RowHeadersVisible = False
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwNomAsoc.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwNomAsoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwNomAsoc.Size = New System.Drawing.Size(380, 141)
            Me.dgwNomAsoc.TabIndex = 1
            '
            'grbNombres
            '
            Me.grbNombres.Controls.Add(Me.gbTiponombre)
            Me.grbNombres.Controls.Add(Me.Label1)
            Me.grbNombres.Controls.Add(Me.txtApePaterno)
            Me.grbNombres.Controls.Add(Me.txtApeMaterno)
            Me.grbNombres.Controls.Add(Me.Label2)
            Me.grbNombres.Controls.Add(Me.txtNombre)
            Me.grbNombres.Controls.Add(Me.Label3)
            Me.grbNombres.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbNombres.Location = New System.Drawing.Point(0, 0)
            Me.grbNombres.Name = "grbNombres"
            Me.grbNombres.Size = New System.Drawing.Size(386, 260)
            Me.grbNombres.TabIndex = 2
            Me.grbNombres.TabStop = False
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(386, 50)
            Me.UscAuditUser1.TabIndex = 0
            '
            'col_sel
            '
            Me.col_sel.HeaderText = ""
            Me.col_sel.Name = "col_sel"
            Me.col_sel.ToolTipText = "Seleccionar"
            Me.col_sel.Visible = False
            Me.col_sel.Width = 30
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "DocNombreAsociadoID"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 40
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_doc_jud_id.DataPropertyName = "DocumentoJudicialID"
            Me.col_doc_jud_id.HeaderText = "DocumentoId"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 80
            '
            'col_int_nom_aso_id
            '
            Me.col_int_nom_aso_id.DataPropertyName = "InternoNombreAsociadoID"
            Me.col_int_nom_aso_id.HeaderText = "NomAsocIdFk"
            Me.col_int_nom_aso_id.Name = "col_int_nom_aso_id"
            Me.col_int_nom_aso_id.Visible = False
            Me.col_int_nom_aso_id.Width = 45
            '
            'col_nom_asoc
            '
            Me.col_nom_asoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nom_asoc.DataPropertyName = "NombreAsociadoCompleto"
            Me.col_nom_asoc.HeaderText = "Apellidos y Nombres"
            Me.col_nom_asoc.Name = "col_nom_asoc"
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "InternoID"
            Me.DataGridViewTextBoxColumn3.HeaderText = "InternoID"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Visible = False
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "NAPaterno"
            Me.col_ape_pat.HeaderText = "Primer Apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Visible = False
            Me.col_ape_pat.Width = 180
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "NAMAterno"
            Me.col_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Visible = False
            Me.col_ape_mat.Width = 180
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "NANombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Visible = False
            Me.col_nom.Width = 180
            '
            'col_prin
            '
            Me.col_prin.DataPropertyName = "NAPrincipal"
            Me.col_prin.HeaderText = "Principal"
            Me.col_prin.Name = "col_prin"
            Me.col_prin.ReadOnly = True
            Me.col_prin.Visible = False
            Me.col_prin.Width = 90
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "NAEstado"
            Me.col_est_id.HeaderText = "EstadoID"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.Visible = False
            '
            'name1
            '
            Me.name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.name1.DataPropertyName = "NAEstadoOri"
            Me.name1.HeaderText = "AccionID"
            Me.name1.Name = "name1"
            Me.name1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.name1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.name1.Visible = False
            '
            'col_ape_pat2
            '
            Me.col_ape_pat2.DataPropertyName = "NAPaterno2"
            Me.col_ape_pat2.HeaderText = "ApellidoPaterno2"
            Me.col_ape_pat2.Name = "col_ape_pat2"
            Me.col_ape_pat2.Visible = False
            '
            'col_ape_mat2
            '
            Me.col_ape_mat2.DataPropertyName = "NAMAterno2"
            Me.col_ape_mat2.HeaderText = "ApellidoMaterno2"
            Me.col_ape_mat2.Name = "col_ape_mat2"
            Me.col_ape_mat2.Visible = False
            '
            'col_nom2
            '
            Me.col_nom2.DataPropertyName = "NANombres2"
            Me.col_nom2.HeaderText = "Nombres2"
            Me.col_nom2.Name = "col_nom2"
            Me.col_nom2.Visible = False
            '
            'col_prin2
            '
            Me.col_prin2.DataPropertyName = "NAPrincipal2"
            Me.col_prin2.HeaderText = "Principal2"
            Me.col_prin2.Name = "col_prin2"
            Me.col_prin2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_prin2.Visible = False
            Me.col_prin2.Width = 50
            '
            'col_nom_aclara
            '
            Me.col_nom_aclara.DataPropertyName = "ApellidosyNombres2"
            Me.col_nom_aclara.HeaderText = "Nombres y Apellidos (Aclaratoria)"
            Me.col_nom_aclara.Name = "col_nom_aclara"
            Me.col_nom_aclara.Visible = False
            Me.col_nom_aclara.Width = 320
            '
            'col_img
            '
            Me.col_img.HeaderText = ""
            Me.col_img.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.col_img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_img.Name = "col_img"
            Me.col_img.ToolTipText = "Eliminar"
            Me.col_img.Width = 30
            '
            'frmNombreAsociadoPopup_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(386, 260)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmNombreAsociadoPopup_v2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Nombres Asociados"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.gbTiponombre.ResumeLayout(False)
            Me.gbTiponombre.PerformLayout()
            Me.Panel11.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.grbNombreAso.ResumeLayout(False)
            CType(Me.dgwNomAsoc, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grbNombres.ResumeLayout(False)
            Me.grbNombres.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtApePaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApeMaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents gbTiponombre As System.Windows.Forms.GroupBox
        Friend WithEvents rdbAsociado As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPrincipal As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents Panel11 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents grbNombres As GroupBox
        Friend WithEvents grbNombreAso As GroupBox
        Friend WithEvents dgwNomAsoc As DataGridView
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents col_sel As DataGridViewCheckBoxColumn
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_int_nom_aso_id As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_asoc As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_prin As DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As DataGridViewTextBoxColumn
        Friend WithEvents name1 As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat2 As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat2 As DataGridViewTextBoxColumn
        Friend WithEvents col_nom2 As DataGridViewTextBoxColumn
        Friend WithEvents col_prin2 As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_aclara As DataGridViewTextBoxColumn
        Friend WithEvents col_img As DataGridViewImageColumn
    End Class
End Namespace