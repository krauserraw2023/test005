<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uscQueda
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblNroExpedientes = New System.Windows.Forms.Label()
        Me.grp01 = New System.Windows.Forms.GroupBox()
        Me.chk_queda_no = New System.Windows.Forms.RadioButton()
        Me.chk_queda_si = New System.Windows.Forms.RadioButton()
        Me.grp02 = New System.Windows.Forms.GroupBox()
        Me.lbOtrosProcesos = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.txtobs_queda = New System.Windows.Forms.TextBox()
        Me.dgwExpediente_queda = New Legolas.APPUIComponents.myDatagridView()
        Me.colu_eleg = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_nro_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_num_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_sit_jur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_tip_aut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_sal_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_sal_jud_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_juez = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.col_doc_tip_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgwDelito_queda = New System.Windows.Forms.DataGridView()
        Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_del_anulacion = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colEliminarDelito = New System.Windows.Forms.DataGridViewImageColumn()
        Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwAgraviados_queda = New Legolas.APPUIComponents.myDatagridView()
        Me.col_agr_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_agr_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_agr_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_delito_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp01.SuspendLayout()
        Me.grp02.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgwExpediente_queda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDelito_queda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwAgraviados_queda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNroExpedientes
        '
        Me.lblNroExpedientes.AutoSize = True
        Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroExpedientes.Location = New System.Drawing.Point(532, 6)
        Me.lblNroExpedientes.Name = "lblNroExpedientes"
        Me.lblNroExpedientes.Size = New System.Drawing.Size(130, 13)
        Me.lblNroExpedientes.TabIndex = 2
        Me.lblNroExpedientes.Text = "# Expedientes 0 Reg."
        '
        'grp01
        '
        Me.grp01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp01.Controls.Add(Me.chk_queda_no)
        Me.grp01.Controls.Add(Me.chk_queda_si)
        Me.grp01.Location = New System.Drawing.Point(9, 190)
        Me.grp01.Name = "grp01"
        Me.grp01.Size = New System.Drawing.Size(345, 100)
        Me.grp01.TabIndex = 4
        Me.grp01.TabStop = False
        Me.grp01.Text = "Conclusión:"
        '
        'chk_queda_no
        '
        Me.chk_queda_no.AutoSize = True
        Me.chk_queda_no.Location = New System.Drawing.Point(18, 54)
        Me.chk_queda_no.Name = "chk_queda_no"
        Me.chk_queda_no.Size = New System.Drawing.Size(265, 17)
        Me.chk_queda_no.TabIndex = 1
        Me.chk_queda_no.TabStop = True
        Me.chk_queda_no.Text = "No presenta proceso(s) o sentencia(s) pendiente(s)"
        Me.chk_queda_no.UseVisualStyleBackColor = True
        '
        'chk_queda_si
        '
        Me.chk_queda_si.AutoSize = True
        Me.chk_queda_si.Location = New System.Drawing.Point(18, 31)
        Me.chk_queda_si.Name = "chk_queda_si"
        Me.chk_queda_si.Size = New System.Drawing.Size(260, 17)
        Me.chk_queda_si.TabIndex = 0
        Me.chk_queda_si.TabStop = True
        Me.chk_queda_si.Text = "Si presenta proceso(s) o sentencia(s) pendiente(s)"
        Me.chk_queda_si.UseVisualStyleBackColor = True
        '
        'grp02
        '
        Me.grp02.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp02.Controls.Add(Me.lbOtrosProcesos)
        Me.grp02.Controls.Add(Me.Panel1)
        Me.grp02.Controls.Add(Me.txtobs_queda)
        Me.grp02.Location = New System.Drawing.Point(362, 190)
        Me.grp02.Name = "grp02"
        Me.grp02.Size = New System.Drawing.Size(384, 100)
        Me.grp02.TabIndex = 5
        Me.grp02.TabStop = False
        Me.grp02.Text = "Otros procesos pendientes:"
        '
        'lbOtrosProcesos
        '
        Me.lbOtrosProcesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbOtrosProcesos.FormattingEnabled = True
        Me.lbOtrosProcesos.Location = New System.Drawing.Point(3, 16)
        Me.lbOtrosProcesos.Name = "lbOtrosProcesos"
        Me.lbOtrosProcesos.ScrollAlwaysVisible = True
        Me.lbOtrosProcesos.Size = New System.Drawing.Size(349, 81)
        Me.lbOtrosProcesos.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnQuitar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(352, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(29, 81)
        Me.Panel1.TabIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Image = Global.APPControls.My.Resources.Resources.add_32
        Me.btnAgregar.Location = New System.Drawing.Point(2, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(25, 30)
        Me.btnAgregar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar otros procesos")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Image = Global.APPControls.My.Resources.Resources.delete_32
        Me.btnQuitar.Location = New System.Drawing.Point(2, 35)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(25, 30)
        Me.btnQuitar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnQuitar, "Quitar proceso")
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'txtobs_queda
        '
        Me.txtobs_queda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtobs_queda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs_queda.Location = New System.Drawing.Point(7, 19)
        Me.txtobs_queda.Multiline = True
        Me.txtobs_queda.Name = "txtobs_queda"
        Me.txtobs_queda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobs_queda.Size = New System.Drawing.Size(371, 75)
        Me.txtobs_queda.TabIndex = 0
        Me.txtobs_queda.Visible = False
        '
        'dgwExpediente_queda
        '
        Me.dgwExpediente_queda.AllowUserToAddRows = False
        Me.dgwExpediente_queda.AllowUserToDeleteRows = False
        Me.dgwExpediente_queda.AllowUserToResizeRows = False
        Me.dgwExpediente_queda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwExpediente_queda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgwExpediente_queda.BackgroundColor = System.Drawing.Color.White
        Me.dgwExpediente_queda.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwExpediente_queda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwExpediente_queda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwExpediente_queda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colu_eleg, Me.col_nro_ing, Me.col_codigo, Me.col_doc_jud, Me.col_exp_item, Me.colu_num_exp, Me.colu_sit_jur, Me.colu_tip_aut, Me.DataGridViewTextBoxColumn50, Me.colu_aut_jud, Me.colu_sal_jud_id, Me.colu_sal_jud_nom, Me.colu_juez, Me.colu_secre, Me.Column1, Me.DataGridViewImageColumn5, Me.col_doc_tip_id})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwExpediente_queda.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwExpediente_queda.GridColor = System.Drawing.Color.LightGray
        Me.dgwExpediente_queda.Location = New System.Drawing.Point(9, 30)
        Me.dgwExpediente_queda.MultiSelect = False
        Me.dgwExpediente_queda.Name = "dgwExpediente_queda"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwExpediente_queda.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgwExpediente_queda.RowHeadersVisible = False
        Me.dgwExpediente_queda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgwExpediente_queda.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgwExpediente_queda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwExpediente_queda.Size = New System.Drawing.Size(737, 154)
        Me.dgwExpediente_queda.TabIndex = 8
        Me.dgwExpediente_queda.VisibleCampos = True
        '
        'colu_eleg
        '
        Me.colu_eleg.HeaderText = "Elegir"
        Me.colu_eleg.Name = "colu_eleg"
        Me.colu_eleg.Width = 39
        '
        'col_nro_ing
        '
        Me.col_nro_ing.DataPropertyName = "IngresoNro"
        Me.col_nro_ing.HeaderText = "Nº Ingreso"
        Me.col_nro_ing.Name = "col_nro_ing"
        Me.col_nro_ing.Visible = False
        Me.col_nro_ing.Width = 82
        '
        'col_codigo
        '
        Me.col_codigo.DataPropertyName = "Codigo"
        Me.col_codigo.DividerWidth = 1
        Me.col_codigo.HeaderText = "Codigo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Visible = False
        Me.col_codigo.Width = 66
        '
        'col_doc_jud
        '
        Me.col_doc_jud.DataPropertyName = "CreaDocJudicialId"
        Me.col_doc_jud.DividerWidth = 1
        Me.col_doc_jud.HeaderText = "DocJudicialId"
        Me.col_doc_jud.Name = "col_doc_jud"
        Me.col_doc_jud.Visible = False
        Me.col_doc_jud.Width = 97
        '
        'col_exp_item
        '
        Me.col_exp_item.DataPropertyName = "ExpedienteItem"
        Me.col_exp_item.HeaderText = "Item"
        Me.col_exp_item.Name = "col_exp_item"
        Me.col_exp_item.Visible = False
        Me.col_exp_item.Width = 52
        '
        'colu_num_exp
        '
        Me.colu_num_exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colu_num_exp.DataPropertyName = "ExpedienteNumero"
        Me.colu_num_exp.HeaderText = "N° Exp."
        Me.colu_num_exp.Name = "colu_num_exp"
        '
        'colu_sit_jur
        '
        Me.colu_sit_jur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colu_sit_jur.DataPropertyName = "SituacionJuridicaNombre"
        Me.colu_sit_jur.HeaderText = "Sit. Juridica"
        Me.colu_sit_jur.Name = "colu_sit_jur"
        '
        'colu_tip_aut
        '
        Me.colu_tip_aut.DataPropertyName = "TipoAutoridadJudicialID"
        Me.colu_tip_aut.HeaderText = "Tipo Aut."
        Me.colu_tip_aut.Name = "colu_tip_aut"
        Me.colu_tip_aut.Visible = False
        Me.colu_tip_aut.Width = 75
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "AutoridadJudicialID"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Aut. JudicialID"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Visible = False
        '
        'colu_aut_jud
        '
        Me.colu_aut_jud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colu_aut_jud.DataPropertyName = "AutoridadJudicialNombre"
        Me.colu_aut_jud.HeaderText = "Aut. Judicial"
        Me.colu_aut_jud.Name = "colu_aut_jud"
        '
        'colu_sal_jud_id
        '
        Me.colu_sal_jud_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colu_sal_jud_id.DataPropertyName = "SalaJudicialID"
        Me.colu_sal_jud_id.HeaderText = "SalaJudID"
        Me.colu_sal_jud_id.Name = "colu_sal_jud_id"
        Me.colu_sal_jud_id.Visible = False
        '
        'colu_sal_jud_nom
        '
        Me.colu_sal_jud_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colu_sal_jud_nom.DataPropertyName = "SalaJudicialNombre"
        Me.colu_sal_jud_nom.HeaderText = "Sala Judicial"
        Me.colu_sal_jud_nom.Name = "colu_sal_jud_nom"
        '
        'colu_juez
        '
        Me.colu_juez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colu_juez.DataPropertyName = "ExpedienteJuez"
        Me.colu_juez.HeaderText = "Juez"
        Me.colu_juez.Name = "colu_juez"
        Me.colu_juez.Visible = False
        '
        'colu_secre
        '
        Me.colu_secre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colu_secre.DataPropertyName = "ExpedienteSecretario"
        Me.colu_secre.HeaderText = "Secretario"
        Me.colu_secre.Name = "colu_secre"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Inimputable"
        Me.Column1.HeaderText = "Inimputable/Posible inimputable"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.DataPropertyName = "Eliminar"
        Me.DataGridViewImageColumn5.HeaderText = ""
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn5.Visible = False
        Me.DataGridViewImageColumn5.Width = 19
        '
        'col_doc_tip_id
        '
        Me.col_doc_tip_id.DataPropertyName = "DocumentoTipoID"
        Me.col_doc_tip_id.HeaderText = "DocumTipo"
        Me.col_doc_tip_id.Name = "col_doc_tip_id"
        Me.col_doc_tip_id.Visible = False
        Me.col_doc_tip_id.Width = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Procesos o sentencias pendientes y no anulados"
        '
        'dgwDelito_queda
        '
        Me.dgwDelito_queda.AllowUserToAddRows = False
        Me.dgwDelito_queda.AllowUserToDeleteRows = False
        Me.dgwDelito_queda.AllowUserToResizeRows = False
        Me.dgwDelito_queda.BackgroundColor = System.Drawing.Color.White
        Me.dgwDelito_queda.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwDelito_queda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgwDelito_queda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDelito_queda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_del_id, Me.col_exp_id, Me.DataGridViewTextBoxColumn1, Me.col_del_item, Me.col_del_esp_nom, Me.col_del_esp_id, Me.DataGridViewTextBoxColumn3, Me.col_del_anulacion, Me.colEliminarDelito, Me.col_del_obs, Me.col_doc_jud_id})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwDelito_queda.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgwDelito_queda.GridColor = System.Drawing.Color.LightGray
        Me.dgwDelito_queda.Location = New System.Drawing.Point(9, 103)
        Me.dgwDelito_queda.MultiSelect = False
        Me.dgwDelito_queda.Name = "dgwDelito_queda"
        Me.dgwDelito_queda.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwDelito_queda.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgwDelito_queda.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.dgwDelito_queda.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgwDelito_queda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgwDelito_queda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDelito_queda.Size = New System.Drawing.Size(345, 86)
        Me.dgwDelito_queda.TabIndex = 10
        Me.dgwDelito_queda.Visible = False
        '
        'col_int_del_id
        '
        Me.col_int_del_id.DataPropertyName = "Codigo"
        Me.col_int_del_id.DividerWidth = 1
        Me.col_int_del_id.HeaderText = "InternoDelitoId"
        Me.col_int_del_id.Name = "col_int_del_id"
        Me.col_int_del_id.ReadOnly = True
        Me.col_int_del_id.Visible = False
        Me.col_int_del_id.Width = 50
        '
        'col_exp_id
        '
        Me.col_exp_id.DataPropertyName = "ExpedienteId"
        Me.col_exp_id.HeaderText = "ExpeId"
        Me.col_exp_id.Name = "col_exp_id"
        Me.col_exp_id.ReadOnly = True
        Me.col_exp_id.Visible = False
        Me.col_exp_id.Width = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ExpedienteItem"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ExpedienteItem"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 20
        '
        'col_del_item
        '
        Me.col_del_item.DataPropertyName = "DelitoItem"
        Me.col_del_item.HeaderText = "DelitoItem"
        Me.col_del_item.Name = "col_del_item"
        Me.col_del_item.ReadOnly = True
        Me.col_del_item.Visible = False
        Me.col_del_item.Width = 20
        '
        'col_del_esp_nom
        '
        Me.col_del_esp_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
        Me.col_del_esp_nom.HeaderText = "Delito Especifico"
        Me.col_del_esp_nom.Name = "col_del_esp_nom"
        Me.col_del_esp_nom.ReadOnly = True
        '
        'col_del_esp_id
        '
        Me.col_del_esp_id.DataPropertyName = "DelitoEspecifico"
        Me.col_del_esp_id.HeaderText = "DelitoEspecificoID"
        Me.col_del_esp_id.Name = "col_del_esp_id"
        Me.col_del_esp_id.ReadOnly = True
        Me.col_del_esp_id.Visible = False
        Me.col_del_esp_id.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DelitoGenericoNombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Delito Generico"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 280
        '
        'col_del_anulacion
        '
        Me.col_del_anulacion.DataPropertyName = "EstadoImage"
        Me.col_del_anulacion.HeaderText = "Anul."
        Me.col_del_anulacion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.col_del_anulacion.Name = "col_del_anulacion"
        Me.col_del_anulacion.ReadOnly = True
        Me.col_del_anulacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_del_anulacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_del_anulacion.Visible = False
        Me.col_del_anulacion.Width = 30
        '
        'colEliminarDelito
        '
        Me.colEliminarDelito.DataPropertyName = "Eliminar"
        Me.colEliminarDelito.HeaderText = ""
        Me.colEliminarDelito.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colEliminarDelito.Name = "colEliminarDelito"
        Me.colEliminarDelito.ReadOnly = True
        Me.colEliminarDelito.ToolTipText = "Eliminar Delito"
        Me.colEliminarDelito.Visible = False
        Me.colEliminarDelito.Width = 35
        '
        'col_del_obs
        '
        Me.col_del_obs.DataPropertyName = "Observacion"
        Me.col_del_obs.HeaderText = "Observacion"
        Me.col_del_obs.Name = "col_del_obs"
        Me.col_del_obs.ReadOnly = True
        Me.col_del_obs.Visible = False
        Me.col_del_obs.Width = 50
        '
        'col_doc_jud_id
        '
        Me.col_doc_jud_id.DataPropertyName = "CreaDocJudicialId"
        Me.col_doc_jud_id.HeaderText = "DocJudID"
        Me.col_doc_jud_id.Name = "col_doc_jud_id"
        Me.col_doc_jud_id.ReadOnly = True
        Me.col_doc_jud_id.Visible = False
        Me.col_doc_jud_id.Width = 30
        '
        'dgwAgraviados_queda
        '
        Me.dgwAgraviados_queda.AllowUserToAddRows = False
        Me.dgwAgraviados_queda.AllowUserToDeleteRows = False
        Me.dgwAgraviados_queda.AllowUserToResizeRows = False
        Me.dgwAgraviados_queda.BackgroundColor = System.Drawing.Color.White
        Me.dgwAgraviados_queda.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwAgraviados_queda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgwAgraviados_queda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAgraviados_queda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_agr_id, Me.col_agr_exp_item, Me.col_agr_del_item, Me.col_agr_item, Me.nom_agrav, Me.col_obs, Me.col_delito_id})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwAgraviados_queda.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgwAgraviados_queda.GridColor = System.Drawing.Color.LightGray
        Me.dgwAgraviados_queda.Location = New System.Drawing.Point(414, 107)
        Me.dgwAgraviados_queda.MultiSelect = False
        Me.dgwAgraviados_queda.Name = "dgwAgraviados_queda"
        Me.dgwAgraviados_queda.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwAgraviados_queda.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgwAgraviados_queda.RowHeadersVisible = False
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.dgwAgraviados_queda.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgwAgraviados_queda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgwAgraviados_queda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwAgraviados_queda.Size = New System.Drawing.Size(332, 86)
        Me.dgwAgraviados_queda.TabIndex = 10
        Me.dgwAgraviados_queda.Visible = False
        Me.dgwAgraviados_queda.VisibleCampos = True
        '
        'col_agr_id
        '
        Me.col_agr_id.DataPropertyName = "Codigo"
        Me.col_agr_id.HeaderText = "AgraviadoId"
        Me.col_agr_id.Name = "col_agr_id"
        Me.col_agr_id.ReadOnly = True
        Me.col_agr_id.Visible = False
        Me.col_agr_id.Width = 40
        '
        'col_agr_exp_item
        '
        Me.col_agr_exp_item.DataPropertyName = "ExpedienteItem"
        Me.col_agr_exp_item.HeaderText = "ExpItem"
        Me.col_agr_exp_item.Name = "col_agr_exp_item"
        Me.col_agr_exp_item.ReadOnly = True
        Me.col_agr_exp_item.Visible = False
        Me.col_agr_exp_item.Width = 40
        '
        'col_agr_del_item
        '
        Me.col_agr_del_item.DataPropertyName = "DelitoItem"
        Me.col_agr_del_item.HeaderText = "DelitoItem"
        Me.col_agr_del_item.Name = "col_agr_del_item"
        Me.col_agr_del_item.ReadOnly = True
        Me.col_agr_del_item.Visible = False
        Me.col_agr_del_item.Width = 40
        '
        'col_agr_item
        '
        Me.col_agr_item.DataPropertyName = "AgraviadoItem"
        Me.col_agr_item.HeaderText = "AgraviadoItem"
        Me.col_agr_item.Name = "col_agr_item"
        Me.col_agr_item.ReadOnly = True
        Me.col_agr_item.Visible = False
        Me.col_agr_item.Width = 40
        '
        'nom_agrav
        '
        Me.nom_agrav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nom_agrav.DataPropertyName = "AgraviadoNombre"
        Me.nom_agrav.HeaderText = "Nombre(s)"
        Me.nom_agrav.Name = "nom_agrav"
        Me.nom_agrav.ReadOnly = True
        '
        'col_obs
        '
        Me.col_obs.DataPropertyName = "Observacion"
        Me.col_obs.HeaderText = "Observación"
        Me.col_obs.Name = "col_obs"
        Me.col_obs.ReadOnly = True
        Me.col_obs.Visible = False
        '
        'col_delito_id
        '
        Me.col_delito_id.DataPropertyName = "DelitoID"
        Me.col_delito_id.HeaderText = "DelitoId"
        Me.col_delito_id.Name = "col_delito_id"
        Me.col_delito_id.ReadOnly = True
        Me.col_delito_id.Visible = False
        '
        'uscQueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgwDelito_queda)
        Me.Controls.Add(Me.dgwAgraviados_queda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgwExpediente_queda)
        Me.Controls.Add(Me.grp02)
        Me.Controls.Add(Me.grp01)
        Me.Controls.Add(Me.lblNroExpedientes)
        Me.Name = "uscQueda"
        Me.Size = New System.Drawing.Size(754, 302)
        Me.grp01.ResumeLayout(False)
        Me.grp01.PerformLayout()
        Me.grp02.ResumeLayout(False)
        Me.grp02.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgwExpediente_queda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDelito_queda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwAgraviados_queda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNroExpedientes As Label
    Friend WithEvents grp01 As GroupBox
    Friend WithEvents chk_queda_no As RadioButton
    Friend WithEvents chk_queda_si As RadioButton
    Friend WithEvents grp02 As GroupBox
    Friend WithEvents txtobs_queda As TextBox
    Friend WithEvents dgwExpediente_queda As Legolas.APPUIComponents.myDatagridView
    Friend WithEvents colu_eleg As DataGridViewCheckBoxColumn
    Friend WithEvents col_nro_ing As DataGridViewTextBoxColumn
    Friend WithEvents col_codigo As DataGridViewTextBoxColumn
    Friend WithEvents col_doc_jud As DataGridViewTextBoxColumn
    Friend WithEvents col_exp_item As DataGridViewTextBoxColumn
    Friend WithEvents colu_num_exp As DataGridViewTextBoxColumn
    Friend WithEvents colu_sit_jur As DataGridViewTextBoxColumn
    Friend WithEvents colu_tip_aut As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents colu_aut_jud As DataGridViewTextBoxColumn
    Friend WithEvents colu_sal_jud_id As DataGridViewTextBoxColumn
    Friend WithEvents colu_sal_jud_nom As DataGridViewTextBoxColumn
    Friend WithEvents colu_juez As DataGridViewTextBoxColumn
    Friend WithEvents colu_secre As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents col_doc_tip_id As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents dgwDelito_queda As DataGridView
    Friend WithEvents col_int_del_id As DataGridViewTextBoxColumn
    Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents col_del_item As DataGridViewTextBoxColumn
    Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_del_esp_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents col_del_anulacion As DataGridViewImageColumn
    Friend WithEvents colEliminarDelito As DataGridViewImageColumn
    Friend WithEvents col_del_obs As DataGridViewTextBoxColumn
    Friend WithEvents col_doc_jud_id As DataGridViewTextBoxColumn
    Friend WithEvents dgwAgraviados_queda As Legolas.APPUIComponents.myDatagridView
    Friend WithEvents col_agr_id As DataGridViewTextBoxColumn
    Friend WithEvents col_agr_exp_item As DataGridViewTextBoxColumn
    Friend WithEvents col_agr_del_item As DataGridViewTextBoxColumn
    Friend WithEvents col_agr_item As DataGridViewTextBoxColumn
    Friend WithEvents nom_agrav As DataGridViewTextBoxColumn
    Friend WithEvents col_obs As DataGridViewTextBoxColumn
    Friend WithEvents col_delito_id As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbOtrosProcesos As ListBox
    Friend WithEvents Panel1 As Panel
End Class
