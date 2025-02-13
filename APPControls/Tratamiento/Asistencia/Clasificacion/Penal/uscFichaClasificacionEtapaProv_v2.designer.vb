'Namespace Registro.Carceleta.Clasificacion
Namespace Tratamiento.Asistencia.Clasificacion.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscFichaClasificacionEtapaProv_v2
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBotonesGrilla = New System.Windows.Forms.Panel()
            Me.btnBloquear = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.pnlBotonGrabarFicha = New System.Windows.Forms.Panel()
            Me.btnGrabarFicha = New System.Windows.Forms.Button()
            Me.btnListarVariables = New System.Windows.Forms.Button()
            Me.dgvVar = New System.Windows.Forms.DataGridView()
            Me.col_fic_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mae_var_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_var_mae_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_val_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_val_id_sel = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_val_mae_sel = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje_noprev = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_buton = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.pnlResultadoFicha = New System.Windows.Forms.Panel()
            Me.gbUbicacion = New System.Windows.Forms.GroupBox()
            Me.btnBuscarPabellon = New System.Windows.Forms.Button()
            Me.lblPabellon = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnUbicacion = New System.Windows.Forms.Button()
            Me.lblResultado = New System.Windows.Forms.Label()
            Me.lblEtiquetaResul = New System.Windows.Forms.Label()
            Me.gbDatosFicha = New System.Windows.Forms.GroupBox()
            Me.pnlOrgCrim = New System.Windows.Forms.Panel()
            Me.rdbOrgCrimSI = New System.Windows.Forms.RadioButton()
            Me.rdbOrgCrimNO = New System.Windows.Forms.RadioButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblRegimen = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblFichaFechaClasi = New System.Windows.Forms.Label()
            Me.lblSituacionJuridica = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtobservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFichaNumClasifi = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblPuntaje = New System.Windows.Forms.Label()
            Me.txtPuntTotal = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbSitJuridica = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnCancelEdit = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.pnlFichas = New System.Windows.Forms.Panel()
            Me.dgwFic = New System.Windows.Forms.DataGridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tip_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_clasif = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_fic = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cat_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_fin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_estado_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pnlRegimen = New System.Windows.Forms.Panel()
            Me.cbbRegimen = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.pnlSituacionJur = New System.Windows.Forms.Panel()
            Me.pnlDatosApertura = New System.Windows.Forms.Panel()
            Me.dtpHoraETAPA = New System.Windows.Forms.DateTimePicker()
            Me.txtNumClasif = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaRegimen = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnHelpClasifEtap = New System.Windows.Forms.Button()
            Me.pnlSubDetalle = New System.Windows.Forms.Panel()
            Me.pnlDatosFicha = New System.Windows.Forms.Panel()
            Me.pnlDetalle2 = New System.Windows.Forms.Panel()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.pnlBotonesGrilla.SuspendLayout()
            Me.pnlBotonGrabarFicha.SuspendLayout()
            CType(Me.dgvVar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlResultadoFicha.SuspendLayout()
            Me.gbUbicacion.SuspendLayout()
            Me.gbDatosFicha.SuspendLayout()
            Me.pnlOrgCrim.SuspendLayout()
            Me.pnlFichas.SuspendLayout()
            CType(Me.dgwFic, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCabecera.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlRegimen.SuspendLayout()
            Me.pnlSituacionJur.SuspendLayout()
            Me.pnlDatosApertura.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlSubDetalle.SuspendLayout()
            Me.pnlDatosFicha.SuspendLayout()
            Me.pnlDetalle2.SuspendLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBotonesGrilla
            '
            Me.pnlBotonesGrilla.Controls.Add(Me.btnBloquear)
            Me.pnlBotonesGrilla.Controls.Add(Me.btnReporte)
            Me.pnlBotonesGrilla.Controls.Add(Me.btnRefresh)
            Me.pnlBotonesGrilla.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotonesGrilla.Location = New System.Drawing.Point(1562, 0)
            Me.pnlBotonesGrilla.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlBotonesGrilla.Name = "pnlBotonesGrilla"
            Me.pnlBotonesGrilla.Size = New System.Drawing.Size(51, 161)
            Me.pnlBotonesGrilla.TabIndex = 89
            '
            'btnBloquear
            '
            Me.btnBloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBloquear.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnBloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBloquear.Image = Global.APPControls.My.Resources.Resources.candado
            Me.btnBloquear.Location = New System.Drawing.Point(0, 98)
            Me.btnBloquear.Margin = New System.Windows.Forms.Padding(4)
            Me.btnBloquear.Name = "btnBloquear"
            Me.btnBloquear.Size = New System.Drawing.Size(51, 49)
            Me.btnBloquear.TabIndex = 97
            Me.btnBloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnBloquear, "Finalizar ficha")
            '
            'btnReporte
            '
            Me.btnReporte.BackgroundImage = Global.APPControls.My.Resources.Resources.printer3
            Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnReporte.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnReporte.Location = New System.Drawing.Point(0, 49)
            Me.btnReporte.Margin = New System.Windows.Forms.Padding(4)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(51, 49)
            Me.btnReporte.TabIndex = 94
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnReporte, "Imprimir ficha")
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'btnRefresh
            '
            Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnRefresh.Image = Global.APPControls.My.Resources.Resources.replace2
            Me.btnRefresh.Location = New System.Drawing.Point(0, 0)
            Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(51, 49)
            Me.btnRefresh.TabIndex = 96
            Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refrescar lista de fichas, permite ver las fichas de los demás.")
            Me.btnRefresh.UseVisualStyleBackColor = True
            '
            'pnlBotonGrabarFicha
            '
            Me.pnlBotonGrabarFicha.Controls.Add(Me.btnGrabarFicha)
            Me.pnlBotonGrabarFicha.Controls.Add(Me.btnListarVariables)
            Me.pnlBotonGrabarFicha.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotonGrabarFicha.Location = New System.Drawing.Point(1561, 0)
            Me.pnlBotonGrabarFicha.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlBotonGrabarFicha.Name = "pnlBotonGrabarFicha"
            Me.pnlBotonGrabarFicha.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
            Me.pnlBotonGrabarFicha.Size = New System.Drawing.Size(52, 449)
            Me.pnlBotonGrabarFicha.TabIndex = 96
            '
            'btnGrabarFicha
            '
            Me.btnGrabarFicha.BackgroundImage = Global.APPControls.My.Resources.Resources.Diskette_32x32
            Me.btnGrabarFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnGrabarFicha.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnGrabarFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarFicha.Location = New System.Drawing.Point(0, 74)
            Me.btnGrabarFicha.Margin = New System.Windows.Forms.Padding(4)
            Me.btnGrabarFicha.Name = "btnGrabarFicha"
            Me.btnGrabarFicha.Size = New System.Drawing.Size(52, 49)
            Me.btnGrabarFicha.TabIndex = 91
            Me.btnGrabarFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnGrabarFicha, "Grabar Ficha")
            '
            'btnListarVariables
            '
            Me.btnListarVariables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnListarVariables.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnListarVariables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnListarVariables.Image = Global.APPControls.My.Resources.Resources.replace2
            Me.btnListarVariables.Location = New System.Drawing.Point(0, 25)
            Me.btnListarVariables.Margin = New System.Windows.Forms.Padding(4)
            Me.btnListarVariables.Name = "btnListarVariables"
            Me.btnListarVariables.Size = New System.Drawing.Size(52, 49)
            Me.btnListarVariables.TabIndex = 93
            Me.btnListarVariables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnListarVariables, "Actualizar Variables")
            '
            'dgvVar
            '
            Me.dgvVar.AllowUserToAddRows = False
            Me.dgvVar.AllowUserToDeleteRows = False
            Me.dgvVar.AllowUserToResizeRows = False
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvVar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvVar.BackgroundColor = System.Drawing.Color.White
            Me.dgvVar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvVar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvVar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvVar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fic_det_id, Me.col_mae_var_id, Me.col_var_mae_id, Me.col_fic_id, Me.DataGridViewTextBoxColumn4, Me.col_val_nom, Me.col_val_id_sel, Me.col_val_mae_sel, Me.col_valor, Me.col_ptje_noprev, Me.col_ptje2, Me.col_buton})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvVar.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvVar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvVar.GridColor = System.Drawing.Color.SkyBlue
            Me.dgvVar.Location = New System.Drawing.Point(0, 0)
            Me.dgvVar.Margin = New System.Windows.Forms.Padding(4)
            Me.dgvVar.MultiSelect = False
            Me.dgvVar.Name = "dgvVar"
            Me.dgvVar.ReadOnly = True
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvVar.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvVar.RowHeadersVisible = False
            Me.dgvVar.RowHeadersWidth = 51
            DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvVar.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvVar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvVar.Size = New System.Drawing.Size(1561, 253)
            Me.dgvVar.TabIndex = 22
            '
            'col_fic_det_id
            '
            Me.col_fic_det_id.HeaderText = "FicDetId"
            Me.col_fic_det_id.MinimumWidth = 6
            Me.col_fic_det_id.Name = "col_fic_det_id"
            Me.col_fic_det_id.ReadOnly = True
            Me.col_fic_det_id.Visible = False
            Me.col_fic_det_id.Width = 125
            '
            'col_mae_var_id
            '
            Me.col_mae_var_id.DataPropertyName = "Codigo"
            Me.col_mae_var_id.HeaderText = "MaeVariableId"
            Me.col_mae_var_id.MinimumWidth = 20
            Me.col_mae_var_id.Name = "col_mae_var_id"
            Me.col_mae_var_id.ReadOnly = True
            Me.col_mae_var_id.Visible = False
            Me.col_mae_var_id.Width = 80
            '
            'col_var_mae_id
            '
            Me.col_var_mae_id.DataPropertyName = "VariableMaestraID"
            Me.col_var_mae_id.HeaderText = "MaeCriteriosId"
            Me.col_var_mae_id.MinimumWidth = 6
            Me.col_var_mae_id.Name = "col_var_mae_id"
            Me.col_var_mae_id.ReadOnly = True
            Me.col_var_mae_id.Visible = False
            Me.col_var_mae_id.Width = 125
            '
            'col_fic_id
            '
            Me.col_fic_id.DataPropertyName = "FichaId"
            Me.col_fic_id.HeaderText = "FichaId"
            Me.col_fic_id.MinimumWidth = 6
            Me.col_fic_id.Name = "col_fic_id"
            Me.col_fic_id.ReadOnly = True
            Me.col_fic_id.Visible = False
            Me.col_fic_id.Width = 50
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumeroOrdenString"
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
            Me.DataGridViewTextBoxColumn4.HeaderText = "N°"
            Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 35
            '
            'col_val_nom
            '
            Me.col_val_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_val_nom.DataPropertyName = "Nombre"
            Me.col_val_nom.HeaderText = "Variables"
            Me.col_val_nom.MinimumWidth = 200
            Me.col_val_nom.Name = "col_val_nom"
            Me.col_val_nom.ReadOnly = True
            Me.col_val_nom.Width = 200
            '
            'col_val_id_sel
            '
            Me.col_val_id_sel.HeaderText = "Val_id_Select"
            Me.col_val_id_sel.MinimumWidth = 6
            Me.col_val_id_sel.Name = "col_val_id_sel"
            Me.col_val_id_sel.ReadOnly = True
            Me.col_val_id_sel.Visible = False
            Me.col_val_id_sel.Width = 30
            '
            'col_val_mae_sel
            '
            Me.col_val_mae_sel.HeaderText = "Val_mae_Select"
            Me.col_val_mae_sel.MinimumWidth = 6
            Me.col_val_mae_sel.Name = "col_val_mae_sel"
            Me.col_val_mae_sel.ReadOnly = True
            Me.col_val_mae_sel.Visible = False
            Me.col_val_mae_sel.Width = 125
            '
            'col_valor
            '
            Me.col_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_valor.DefaultCellStyle = DataGridViewCellStyle4
            Me.col_valor.HeaderText = "Indicador seleccionado"
            Me.col_valor.MinimumWidth = 6
            Me.col_valor.Name = "col_valor"
            Me.col_valor.ReadOnly = True
            '
            'col_ptje_noprev
            '
            Me.col_ptje_noprev.DataPropertyName = "PuntajeNoPrevisto"
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.NullValue = "0"
            Me.col_ptje_noprev.DefaultCellStyle = DataGridViewCellStyle5
            Me.col_ptje_noprev.HeaderText = "NoPrevisto"
            Me.col_ptje_noprev.MinimumWidth = 6
            Me.col_ptje_noprev.Name = "col_ptje_noprev"
            Me.col_ptje_noprev.ReadOnly = True
            Me.col_ptje_noprev.Width = 65
            '
            'col_ptje2
            '
            Me.col_ptje2.DataPropertyName = "Puntaje"
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.NullValue = "0"
            Me.col_ptje2.DefaultCellStyle = DataGridViewCellStyle6
            Me.col_ptje2.HeaderText = "Puntaje"
            Me.col_ptje2.MinimumWidth = 6
            Me.col_ptje2.Name = "col_ptje2"
            Me.col_ptje2.ReadOnly = True
            Me.col_ptje2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ptje2.Width = 50
            '
            'col_buton
            '
            Me.col_buton.HeaderText = ""
            Me.col_buton.MinimumWidth = 6
            Me.col_buton.Name = "col_buton"
            Me.col_buton.ReadOnly = True
            Me.col_buton.Text = "---"
            Me.col_buton.UseColumnTextForButtonValue = True
            Me.col_buton.Width = 60
            '
            'pnlResultadoFicha
            '
            Me.pnlResultadoFicha.Controls.Add(Me.gbUbicacion)
            Me.pnlResultadoFicha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlResultadoFicha.Location = New System.Drawing.Point(0, 107)
            Me.pnlResultadoFicha.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlResultadoFicha.Name = "pnlResultadoFicha"
            Me.pnlResultadoFicha.Size = New System.Drawing.Size(1561, 89)
            Me.pnlResultadoFicha.TabIndex = 20
            '
            'gbUbicacion
            '
            Me.gbUbicacion.Controls.Add(Me.btnBuscarPabellon)
            Me.gbUbicacion.Controls.Add(Me.lblPabellon)
            Me.gbUbicacion.Controls.Add(Me.Label4)
            Me.gbUbicacion.Controls.Add(Me.btnUbicacion)
            Me.gbUbicacion.Controls.Add(Me.lblResultado)
            Me.gbUbicacion.Controls.Add(Me.lblEtiquetaResul)
            Me.gbUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbUbicacion.Location = New System.Drawing.Point(0, 0)
            Me.gbUbicacion.Margin = New System.Windows.Forms.Padding(4)
            Me.gbUbicacion.Name = "gbUbicacion"
            Me.gbUbicacion.Padding = New System.Windows.Forms.Padding(4)
            Me.gbUbicacion.Size = New System.Drawing.Size(1561, 89)
            Me.gbUbicacion.TabIndex = 19
            Me.gbUbicacion.TabStop = False
            Me.gbUbicacion.Text = "RESULTADO"
            '
            'btnBuscarPabellon
            '
            Me.btnBuscarPabellon.BackgroundImage = Global.APPControls.My.Resources.Resources._1345240399_search_button
            Me.btnBuscarPabellon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBuscarPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPabellon.Location = New System.Drawing.Point(315, 48)
            Me.btnBuscarPabellon.Margin = New System.Windows.Forms.Padding(4)
            Me.btnBuscarPabellon.Name = "btnBuscarPabellon"
            Me.btnBuscarPabellon.Size = New System.Drawing.Size(37, 32)
            Me.btnBuscarPabellon.TabIndex = 33
            Me.btnBuscarPabellon.UseVisualStyleBackColor = True
            Me.btnBuscarPabellon.Visible = False
            '
            'lblPabellon
            '
            Me.lblPabellon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPabellon.ForeColor = System.Drawing.Color.Black
            Me.lblPabellon.Location = New System.Drawing.Point(100, 50)
            Me.lblPabellon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(215, 25)
            Me.lblPabellon.TabIndex = 32
            Me.lblPabellon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblPabellon.Visible = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(5, 58)
            Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(85, 17)
            Me.Label4.TabIndex = 21
            Me.Label4.Text = "PABELLÓN:"
            Me.Label4.Visible = False
            '
            'btnUbicacion
            '
            Me.btnUbicacion.Image = Global.APPControls.My.Resources.Resources.view
            Me.btnUbicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUbicacion.Location = New System.Drawing.Point(360, 43)
            Me.btnUbicacion.Margin = New System.Windows.Forms.Padding(4)
            Me.btnUbicacion.Name = "btnUbicacion"
            Me.btnUbicacion.Size = New System.Drawing.Size(195, 43)
            Me.btnUbicacion.TabIndex = 20
            Me.btnUbicacion.Text = "O.T.T. - Ubicación"
            Me.btnUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUbicacion.UseVisualStyleBackColor = True
            Me.btnUbicacion.Visible = False
            '
            'lblResultado
            '
            Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblResultado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblResultado.Location = New System.Drawing.Point(100, 17)
            Me.lblResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblResultado.Name = "lblResultado"
            Me.lblResultado.Size = New System.Drawing.Size(455, 25)
            Me.lblResultado.TabIndex = 19
            Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblEtiquetaResul
            '
            Me.lblEtiquetaResul.AutoSize = True
            Me.lblEtiquetaResul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaResul.Location = New System.Drawing.Point(27, 22)
            Me.lblEtiquetaResul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblEtiquetaResul.Name = "lblEtiquetaResul"
            Me.lblEtiquetaResul.Size = New System.Drawing.Size(61, 17)
            Me.lblEtiquetaResul.TabIndex = 13
            Me.lblEtiquetaResul.Text = "ETAPA: "
            '
            'gbDatosFicha
            '
            Me.gbDatosFicha.Controls.Add(Me.pnlOrgCrim)
            Me.gbDatosFicha.Controls.Add(Me.lblRegimen)
            Me.gbDatosFicha.Controls.Add(Me.Label7)
            Me.gbDatosFicha.Controls.Add(Me.lblFichaFechaClasi)
            Me.gbDatosFicha.Controls.Add(Me.lblSituacionJuridica)
            Me.gbDatosFicha.Controls.Add(Me.Label13)
            Me.gbDatosFicha.Controls.Add(Me.txtobservacion)
            Me.gbDatosFicha.Controls.Add(Me.txtFichaNumClasifi)
            Me.gbDatosFicha.Controls.Add(Me.lblPuntaje)
            Me.gbDatosFicha.Controls.Add(Me.txtPuntTotal)
            Me.gbDatosFicha.Controls.Add(Me.Label3)
            Me.gbDatosFicha.Controls.Add(Me.Label1)
            Me.gbDatosFicha.Controls.Add(Me.Label2)
            Me.gbDatosFicha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbDatosFicha.Location = New System.Drawing.Point(0, 0)
            Me.gbDatosFicha.Margin = New System.Windows.Forms.Padding(4)
            Me.gbDatosFicha.Name = "gbDatosFicha"
            Me.gbDatosFicha.Padding = New System.Windows.Forms.Padding(4)
            Me.gbDatosFicha.Size = New System.Drawing.Size(1561, 107)
            Me.gbDatosFicha.TabIndex = 17
            Me.gbDatosFicha.TabStop = False
            Me.gbDatosFicha.Text = "DATOS DE LA FICHA:"
            '
            'pnlOrgCrim
            '
            Me.pnlOrgCrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlOrgCrim.Controls.Add(Me.rdbOrgCrimSI)
            Me.pnlOrgCrim.Controls.Add(Me.rdbOrgCrimNO)
            Me.pnlOrgCrim.Controls.Add(Me.Label5)
            Me.pnlOrgCrim.Location = New System.Drawing.Point(913, 16)
            Me.pnlOrgCrim.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlOrgCrim.Name = "pnlOrgCrim"
            Me.pnlOrgCrim.Size = New System.Drawing.Size(357, 30)
            Me.pnlOrgCrim.TabIndex = 41
            Me.pnlOrgCrim.Visible = False
            '
            'rdbOrgCrimSI
            '
            Me.rdbOrgCrimSI.AutoSize = True
            Me.rdbOrgCrimSI.Location = New System.Drawing.Point(231, 5)
            Me.rdbOrgCrimSI.Margin = New System.Windows.Forms.Padding(4)
            Me.rdbOrgCrimSI.Name = "rdbOrgCrimSI"
            Me.rdbOrgCrimSI.Size = New System.Drawing.Size(40, 20)
            Me.rdbOrgCrimSI.TabIndex = 41
            Me.rdbOrgCrimSI.TabStop = True
            Me.rdbOrgCrimSI.Text = "SI"
            Me.rdbOrgCrimSI.UseVisualStyleBackColor = True
            '
            'rdbOrgCrimNO
            '
            Me.rdbOrgCrimNO.AutoSize = True
            Me.rdbOrgCrimNO.Location = New System.Drawing.Point(285, 5)
            Me.rdbOrgCrimNO.Margin = New System.Windows.Forms.Padding(4)
            Me.rdbOrgCrimNO.Name = "rdbOrgCrimNO"
            Me.rdbOrgCrimNO.Size = New System.Drawing.Size(48, 20)
            Me.rdbOrgCrimNO.TabIndex = 42
            Me.rdbOrgCrimNO.TabStop = True
            Me.rdbOrgCrimNO.Text = "NO"
            Me.rdbOrgCrimNO.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(4, 7)
            Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(219, 17)
            Me.Label5.TabIndex = 40
            Me.Label5.Text = "Pertenece Organización Criminal:"
            '
            'lblRegimen
            '
            Me.lblRegimen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegimen.ForeColor = System.Drawing.Color.Black
            Me.lblRegimen.Location = New System.Drawing.Point(148, 47)
            Me.lblRegimen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblRegimen.Name = "lblRegimen"
            Me.lblRegimen.Size = New System.Drawing.Size(407, 22)
            Me.lblRegimen.TabIndex = 36
            Me.lblRegimen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(71, 53)
            Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(65, 16)
            Me.Label7.TabIndex = 35
            Me.Label7.Text = "Régimen:"
            '
            'lblFichaFechaClasi
            '
            Me.lblFichaFechaClasi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFichaFechaClasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFichaFechaClasi.ForeColor = System.Drawing.Color.Black
            Me.lblFichaFechaClasi.Location = New System.Drawing.Point(336, 75)
            Me.lblFichaFechaClasi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblFichaFechaClasi.Name = "lblFichaFechaClasi"
            Me.lblFichaFechaClasi.Size = New System.Drawing.Size(219, 22)
            Me.lblFichaFechaClasi.TabIndex = 29
            Me.lblFichaFechaClasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSituacionJuridica
            '
            Me.lblSituacionJuridica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblSituacionJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSituacionJuridica.ForeColor = System.Drawing.Color.Black
            Me.lblSituacionJuridica.Location = New System.Drawing.Point(148, 23)
            Me.lblSituacionJuridica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblSituacionJuridica.Name = "lblSituacionJuridica"
            Me.lblSituacionJuridica.Size = New System.Drawing.Size(407, 22)
            Me.lblSituacionJuridica.TabIndex = 27
            Me.lblSituacionJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(9, 26)
            Me.Label13.Margin = New System.Windows.Forms.Padding(0)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(118, 16)
            Me.Label13.TabIndex = 28
            Me.Label13.Text = "Situación Jurídica :"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtobservacion
            '
            Me.txtobservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtobservacion._BloquearPaste = False
            Me.txtobservacion._SeleccionarTodo = False
            Me.txtobservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtobservacion.BackColor = System.Drawing.Color.White
            Me.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtobservacion.Location = New System.Drawing.Point(563, 50)
            Me.txtobservacion.Margin = New System.Windows.Forms.Padding(4)
            Me.txtobservacion.MaxLength = 2000
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobservacion.Size = New System.Drawing.Size(990, 51)
            Me.txtobservacion.TabIndex = 8
            Me.txtobservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtobservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtFichaNumClasifi
            '
            Me.txtFichaNumClasifi._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFichaNumClasifi._BloquearPaste = False
            Me.txtFichaNumClasifi._SeleccionarTodo = False
            Me.txtFichaNumClasifi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFichaNumClasifi.ForeColor = System.Drawing.Color.Black
            Me.txtFichaNumClasifi.Location = New System.Drawing.Point(148, 73)
            Me.txtFichaNumClasifi.Margin = New System.Windows.Forms.Padding(4)
            Me.txtFichaNumClasifi.MaxLength = 2
            Me.txtFichaNumClasifi.Name = "txtFichaNumClasifi"
            Me.txtFichaNumClasifi.ReadOnly = True
            Me.txtFichaNumClasifi.Size = New System.Drawing.Size(76, 24)
            Me.txtFichaNumClasifi.TabIndex = 22
            Me.txtFichaNumClasifi.Text = "0"
            Me.txtFichaNumClasifi.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFichaNumClasifi.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'lblPuntaje
            '
            Me.lblPuntaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPuntaje.AutoSize = True
            Me.lblPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPuntaje.ForeColor = System.Drawing.Color.Black
            Me.lblPuntaje.Location = New System.Drawing.Point(1280, 22)
            Me.lblPuntaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPuntaje.Name = "lblPuntaje"
            Me.lblPuntaje.Size = New System.Drawing.Size(105, 17)
            Me.lblPuntaje.TabIndex = 0
            Me.lblPuntaje.Text = "Puntaje total:"
            '
            'txtPuntTotal
            '
            Me.txtPuntTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPuntTotal.BackColor = System.Drawing.Color.WhiteSmoke
            Me.txtPuntTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPuntTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPuntTotal.ForeColor = System.Drawing.Color.Black
            Me.txtPuntTotal.Location = New System.Drawing.Point(1396, 17)
            Me.txtPuntTotal.Margin = New System.Windows.Forms.Padding(4)
            Me.txtPuntTotal.Name = "txtPuntTotal"
            Me.txtPuntTotal.ReadOnly = True
            Me.txtPuntTotal.Size = New System.Drawing.Size(153, 24)
            Me.txtPuntTotal.TabIndex = 2
            Me.txtPuntTotal.Text = "0"
            Me.txtPuntTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(567, 30)
            Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(90, 16)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Observación :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(27, 79)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(103, 16)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "N° Clasificación:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(229, 75)
            Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(90, 16)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Fecha Clasif. :"
            '
            'cbbSitJuridica
            '
            Me.cbbSitJuridica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbbSitJuridica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbSitJuridica.FormattingEnabled = True
            Me.cbbSitJuridica.Items.AddRange(New Object() {"[--SELECCIONE--]", "PROCESADO", "SENTENCIADO"})
            Me.cbbSitJuridica.Location = New System.Drawing.Point(130, 10)
            Me.cbbSitJuridica.Margin = New System.Windows.Forms.Padding(4)
            Me.cbbSitJuridica.Name = "cbbSitJuridica"
            Me.cbbSitJuridica.Size = New System.Drawing.Size(164, 24)
            Me.cbbSitJuridica.TabIndex = 27
            '
            'Label9
            '
            Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(9, 14)
            Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(115, 16)
            Me.Label9.TabIndex = 26
            Me.Label9.Text = "Situación Jurídica:"
            '
            'Label21
            '
            Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(16, 11)
            Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(68, 17)
            Me.Label21.TabIndex = 7
            Me.Label21.Text = "Régimen:"
            '
            'btnCancelEdit
            '
            Me.btnCancelEdit.BackgroundImage = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancelEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnCancelEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelEdit.Location = New System.Drawing.Point(43, 0)
            Me.btnCancelEdit.Margin = New System.Windows.Forms.Padding(4)
            Me.btnCancelEdit.Name = "btnCancelEdit"
            Me.btnCancelEdit.Size = New System.Drawing.Size(43, 38)
            Me.btnCancelEdit.TabIndex = 90
            Me.btnCancelEdit.Tag = ""
            Me.btnCancelEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnCancelEdit, "Cancelar")
            Me.btnCancelEdit.Visible = False
            '
            'btnNuevo
            '
            Me.btnNuevo.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
            Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(43, 38)
            Me.btnNuevo.TabIndex = 89
            Me.btnNuevo.Tag = "Nuevo"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnNuevo, "Agregar")
            '
            'pnlFichas
            '
            Me.pnlFichas.Controls.Add(Me.dgwFic)
            Me.pnlFichas.Controls.Add(Me.pnlBotonesGrilla)
            Me.pnlFichas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlFichas.Location = New System.Drawing.Point(0, 0)
            Me.pnlFichas.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlFichas.Name = "pnlFichas"
            Me.pnlFichas.Size = New System.Drawing.Size(1613, 161)
            Me.pnlFichas.TabIndex = 91
            '
            'dgwFic
            '
            Me.dgwFic.AllowUserToAddRows = False
            Me.dgwFic.AllowUserToDeleteRows = False
            Me.dgwFic.AllowUserToResizeRows = False
            Me.dgwFic.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwFic.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgwFic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwFic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.tip_fic_id, Me.col_num_clasif, Me.col_fic_id2, Me.col_nom_fic, Me.col_fec_cla, Me.col_ptje, Me.col_id_cat, Me.col_cat_nom, Me.col_fic_fin, Me.col_estado, Me.col_estado_id})
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwFic.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgwFic.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwFic.GridColor = System.Drawing.Color.LightGray
            Me.dgwFic.Location = New System.Drawing.Point(0, 0)
            Me.dgwFic.Margin = New System.Windows.Forms.Padding(4)
            Me.dgwFic.MultiSelect = False
            Me.dgwFic.Name = "dgwFic"
            Me.dgwFic.ReadOnly = True
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwFic.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgwFic.RowHeadersVisible = False
            Me.dgwFic.RowHeadersWidth = 51
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwFic.RowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgwFic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwFic.Size = New System.Drawing.Size(1562, 161)
            Me.dgwFic.TabIndex = 91
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.MinimumWidth = 6
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 50
            '
            'tip_fic_id
            '
            Me.tip_fic_id.DataPropertyName = "TipoFichaId"
            Me.tip_fic_id.HeaderText = "TipoFichaId"
            Me.tip_fic_id.MinimumWidth = 6
            Me.tip_fic_id.Name = "tip_fic_id"
            Me.tip_fic_id.ReadOnly = True
            Me.tip_fic_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.tip_fic_id.Visible = False
            Me.tip_fic_id.Width = 153
            '
            'col_num_clasif
            '
            Me.col_num_clasif.DataPropertyName = "NumeroClasificacion"
            Me.col_num_clasif.HeaderText = "N° Clasif."
            Me.col_num_clasif.MinimumWidth = 6
            Me.col_num_clasif.Name = "col_num_clasif"
            Me.col_num_clasif.ReadOnly = True
            Me.col_num_clasif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_num_clasif.Width = 60
            '
            'col_fic_id2
            '
            Me.col_fic_id2.DataPropertyName = "IDFicha"
            Me.col_fic_id2.HeaderText = "IDFicha"
            Me.col_fic_id2.MinimumWidth = 6
            Me.col_fic_id2.Name = "col_fic_id2"
            Me.col_fic_id2.ReadOnly = True
            Me.col_fic_id2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fic_id2.Visible = False
            Me.col_fic_id2.Width = 125
            '
            'col_nom_fic
            '
            Me.col_nom_fic.DataPropertyName = "FichaNombre"
            Me.col_nom_fic.HeaderText = "Ficha"
            Me.col_nom_fic.MinimumWidth = 250
            Me.col_nom_fic.Name = "col_nom_fic"
            Me.col_nom_fic.ReadOnly = True
            Me.col_nom_fic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nom_fic.Width = 600
            '
            'col_fec_cla
            '
            Me.col_fec_cla.DataPropertyName = "FechaClasificacionDate"
            Me.col_fec_cla.HeaderText = "F. Clasificación"
            Me.col_fec_cla.MinimumWidth = 6
            Me.col_fec_cla.Name = "col_fec_cla"
            Me.col_fec_cla.ReadOnly = True
            Me.col_fec_cla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fec_cla.Width = 150
            '
            'col_ptje
            '
            Me.col_ptje.DataPropertyName = "Puntaje"
            Me.col_ptje.HeaderText = "Puntaje"
            Me.col_ptje.MinimumWidth = 6
            Me.col_ptje.Name = "col_ptje"
            Me.col_ptje.ReadOnly = True
            Me.col_ptje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ptje.Width = 50
            '
            'col_id_cat
            '
            Me.col_id_cat.DataPropertyName = "CategoriaFichaId"
            Me.col_id_cat.HeaderText = "CategoriaID"
            Me.col_id_cat.MinimumWidth = 6
            Me.col_id_cat.Name = "col_id_cat"
            Me.col_id_cat.ReadOnly = True
            Me.col_id_cat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_id_cat.Visible = False
            Me.col_id_cat.Width = 125
            '
            'col_cat_nom
            '
            Me.col_cat_nom.DataPropertyName = "CategoriaFichaNombre"
            Me.col_cat_nom.HeaderText = "Categoria"
            Me.col_cat_nom.MinimumWidth = 6
            Me.col_cat_nom.Name = "col_cat_nom"
            Me.col_cat_nom.ReadOnly = True
            Me.col_cat_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_cat_nom.Visible = False
            Me.col_cat_nom.Width = 300
            '
            'col_fic_fin
            '
            Me.col_fic_fin.HeaderText = "Ficha Final"
            Me.col_fic_fin.MinimumWidth = 6
            Me.col_fic_fin.Name = "col_fic_fin"
            Me.col_fic_fin.ReadOnly = True
            Me.col_fic_fin.Visible = False
            Me.col_fic_fin.Width = 70
            '
            'col_estado
            '
            Me.col_estado.DataPropertyName = "EstadoNombre"
            Me.col_estado.HeaderText = "Estado"
            Me.col_estado.MinimumWidth = 6
            Me.col_estado.Name = "col_estado"
            Me.col_estado.ReadOnly = True
            Me.col_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_estado.Width = 120
            '
            'col_estado_id
            '
            Me.col_estado_id.DataPropertyName = "Estado"
            Me.col_estado_id.HeaderText = "EstadoId"
            Me.col_estado_id.MinimumWidth = 6
            Me.col_estado_id.Name = "col_estado_id"
            Me.col_estado_id.ReadOnly = True
            Me.col_estado_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_estado_id.Visible = False
            Me.col_estado_id.Width = 125
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.Panel1)
            Me.pnlCabecera.Controls.Add(Me.pnlRegimen)
            Me.pnlCabecera.Controls.Add(Me.pnlSituacionJur)
            Me.pnlCabecera.Controls.Add(Me.pnlDatosApertura)
            Me.pnlCabecera.Controls.Add(Me.Panel2)
            Me.pnlCabecera.Controls.Add(Me.Panel3)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(1613, 42)
            Me.pnlCabecera.TabIndex = 90
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancelEdit)
            Me.Panel1.Controls.Add(Me.btnNuevo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(1287, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(102, 42)
            Me.Panel1.TabIndex = 35
            '
            'pnlRegimen
            '
            Me.pnlRegimen.Controls.Add(Me.Label21)
            Me.pnlRegimen.Controls.Add(Me.cbbRegimen)
            Me.pnlRegimen.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlRegimen.Location = New System.Drawing.Point(864, 0)
            Me.pnlRegimen.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlRegimen.Name = "pnlRegimen"
            Me.pnlRegimen.Size = New System.Drawing.Size(423, 42)
            Me.pnlRegimen.TabIndex = 30
            '
            'cbbRegimen
            '
            Me.cbbRegimen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimen.Location = New System.Drawing.Point(87, 7)
            Me.cbbRegimen.Margin = New System.Windows.Forms.Padding(4)
            Me.cbbRegimen.Name = "cbbRegimen"
            Me.cbbRegimen.Size = New System.Drawing.Size(332, 26)
            Me.cbbRegimen.TabIndex = 8
            '
            'pnlSituacionJur
            '
            Me.pnlSituacionJur.Controls.Add(Me.Label9)
            Me.pnlSituacionJur.Controls.Add(Me.cbbSitJuridica)
            Me.pnlSituacionJur.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSituacionJur.Location = New System.Drawing.Point(565, 0)
            Me.pnlSituacionJur.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlSituacionJur.Name = "pnlSituacionJur"
            Me.pnlSituacionJur.Size = New System.Drawing.Size(299, 42)
            Me.pnlSituacionJur.TabIndex = 29
            '
            'pnlDatosApertura
            '
            Me.pnlDatosApertura.Controls.Add(Me.dtpHoraETAPA)
            Me.pnlDatosApertura.Controls.Add(Me.txtNumClasif)
            Me.pnlDatosApertura.Controls.Add(Me.dtpFechaRegimen)
            Me.pnlDatosApertura.Controls.Add(Me.Label6)
            Me.pnlDatosApertura.Controls.Add(Me.Label11)
            Me.pnlDatosApertura.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlDatosApertura.Location = New System.Drawing.Point(53, 0)
            Me.pnlDatosApertura.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlDatosApertura.Name = "pnlDatosApertura"
            Me.pnlDatosApertura.Size = New System.Drawing.Size(512, 42)
            Me.pnlDatosApertura.TabIndex = 33
            '
            'dtpHoraETAPA
            '
            Me.dtpHoraETAPA.CustomFormat = "hh:mm tt"
            Me.dtpHoraETAPA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHoraETAPA.Location = New System.Drawing.Point(412, 9)
            Me.dtpHoraETAPA.Margin = New System.Windows.Forms.Padding(4)
            Me.dtpHoraETAPA.Name = "dtpHoraETAPA"
            Me.dtpHoraETAPA.ShowUpDown = True
            Me.dtpHoraETAPA.Size = New System.Drawing.Size(91, 22)
            Me.dtpHoraETAPA.TabIndex = 48
            Me.dtpHoraETAPA.Value = New Date(2023, 11, 16, 0, 0, 0, 0)
            '
            'txtNumClasif
            '
            Me.txtNumClasif._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumClasif._BloquearPaste = False
            Me.txtNumClasif._SeleccionarTodo = False
            Me.txtNumClasif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumClasif.Location = New System.Drawing.Point(115, 9)
            Me.txtNumClasif.Margin = New System.Windows.Forms.Padding(4)
            Me.txtNumClasif.MaxLength = 2
            Me.txtNumClasif.Name = "txtNumClasif"
            Me.txtNumClasif.ReadOnly = True
            Me.txtNumClasif.Size = New System.Drawing.Size(43, 24)
            Me.txtNumClasif.TabIndex = 29
            Me.txtNumClasif.Text = "0"
            Me.txtNumClasif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtNumClasif.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumClasif.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'dtpFechaRegimen
            '
            Me.dtpFechaRegimen.Location = New System.Drawing.Point(306, 9)
            Me.dtpFechaRegimen.Margin = New System.Windows.Forms.Padding(5)
            Me.dtpFechaRegimen.Name = "dtpFechaRegimen"
            Me.dtpFechaRegimen.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRegimen.TabIndex = 27
            Me.dtpFechaRegimen.Value = "/  /"
            Me.dtpFechaRegimen.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 14)
            Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(103, 16)
            Me.Label6.TabIndex = 28
            Me.Label6.Text = "N° Clasificación:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(173, 13)
            Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(127, 16)
            Me.Label11.TabIndex = 26
            Me.Label11.Text = "Fecha Clasificación:"
            '
            'Panel2
            '
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(1561, 0)
            Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(52, 42)
            Me.Panel2.TabIndex = 34
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnHelpClasifEtap)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(53, 42)
            Me.Panel3.TabIndex = 36
            '
            'btnHelpClasifEtap
            '
            Me.btnHelpClasifEtap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnHelpClasifEtap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnHelpClasifEtap.Location = New System.Drawing.Point(3, 4)
            Me.btnHelpClasifEtap.Name = "btnHelpClasifEtap"
            Me.btnHelpClasifEtap.Size = New System.Drawing.Size(43, 36)
            Me.btnHelpClasifEtap.TabIndex = 49
            Me.btnHelpClasifEtap.Text = "?"
            Me.btnHelpClasifEtap.UseVisualStyleBackColor = False
            '
            'pnlSubDetalle
            '
            Me.pnlSubDetalle.Controls.Add(Me.pnlResultadoFicha)
            Me.pnlSubDetalle.Controls.Add(Me.pnlDatosFicha)
            Me.pnlSubDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlSubDetalle.Location = New System.Drawing.Point(0, 253)
            Me.pnlSubDetalle.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlSubDetalle.Name = "pnlSubDetalle"
            Me.pnlSubDetalle.Size = New System.Drawing.Size(1561, 196)
            Me.pnlSubDetalle.TabIndex = 97
            '
            'pnlDatosFicha
            '
            Me.pnlDatosFicha.Controls.Add(Me.gbDatosFicha)
            Me.pnlDatosFicha.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDatosFicha.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatosFicha.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlDatosFicha.Name = "pnlDatosFicha"
            Me.pnlDatosFicha.Size = New System.Drawing.Size(1561, 107)
            Me.pnlDatosFicha.TabIndex = 25
            '
            'pnlDetalle2
            '
            Me.pnlDetalle2.Controls.Add(Me.dgvVar)
            Me.pnlDetalle2.Controls.Add(Me.pnlSubDetalle)
            Me.pnlDetalle2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle2.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle2.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlDetalle2.Name = "pnlDetalle2"
            Me.pnlDetalle2.Size = New System.Drawing.Size(1561, 449)
            Me.pnlDetalle2.TabIndex = 97
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
            Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
            Me.SplitContainer1.Name = "SplitContainer1"
            Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.pnlFichas)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.pnlDetalle2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.pnlBotonGrabarFicha)
            Me.SplitContainer1.Size = New System.Drawing.Size(1613, 615)
            Me.SplitContainer1.SplitterDistance = 161
            Me.SplitContainer1.SplitterWidth = 5
            Me.SplitContainer1.TabIndex = 99
            '
            'uscFichaClasificacionEtapaProv_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SplitContainer1)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "uscFichaClasificacionEtapaProv_v2"
            Me.Size = New System.Drawing.Size(1613, 657)
            Me.pnlBotonesGrilla.ResumeLayout(False)
            Me.pnlBotonGrabarFicha.ResumeLayout(False)
            CType(Me.dgvVar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlResultadoFicha.ResumeLayout(False)
            Me.gbUbicacion.ResumeLayout(False)
            Me.gbUbicacion.PerformLayout()
            Me.gbDatosFicha.ResumeLayout(False)
            Me.gbDatosFicha.PerformLayout()
            Me.pnlOrgCrim.ResumeLayout(False)
            Me.pnlOrgCrim.PerformLayout()
            Me.pnlFichas.ResumeLayout(False)
            CType(Me.dgwFic, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCabecera.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlRegimen.ResumeLayout(False)
            Me.pnlRegimen.PerformLayout()
            Me.pnlSituacionJur.ResumeLayout(False)
            Me.pnlSituacionJur.PerformLayout()
            Me.pnlDatosApertura.ResumeLayout(False)
            Me.pnlDatosApertura.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.pnlSubDetalle.ResumeLayout(False)
            Me.pnlDatosFicha.ResumeLayout(False)
            Me.pnlDetalle2.ResumeLayout(False)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBotonesGrilla As System.Windows.Forms.Panel
        Friend WithEvents btnListarVariables As System.Windows.Forms.Button
        Friend WithEvents btnGrabarFicha As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents gbUbicacion As System.Windows.Forms.GroupBox
        Friend WithEvents lblEtiquetaResul As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents gbDatosFicha As System.Windows.Forms.GroupBox
        Friend WithEvents txtFichaNumClasifi As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblPuntaje As System.Windows.Forms.Label
        Friend WithEvents txtobservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPuntTotal As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents pnlBotonGrabarFicha As System.Windows.Forms.Panel
        Friend WithEvents pnlFichas As System.Windows.Forms.Panel
        Friend WithEvents pnlResultadoFicha As System.Windows.Forms.Panel
        Friend WithEvents btnRefresh As System.Windows.Forms.Button
        Friend WithEvents cbbSitJuridica As ComboBox
        Friend WithEvents dgwFic As DataGridView
        Friend WithEvents pnlCabecera As Panel
        Friend WithEvents cbbRegimen As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label9 As Label
        Friend WithEvents dgvVar As DataGridView
        Friend WithEvents lblResultado As Label
        Friend WithEvents pnlRegimen As Panel
        Friend WithEvents pnlSituacionJur As Panel
        Friend WithEvents pnlSubDetalle As Panel
        Friend WithEvents pnlDatosFicha As Panel
        Friend WithEvents pnlDetalle2 As Panel
        Friend WithEvents lblSituacionJuridica As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents pnlDatosApertura As Panel
        Friend WithEvents txtNumClasif As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaRegimen As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents lblFichaFechaClasi As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnBloquear As Button
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents tip_fic_id As DataGridViewTextBoxColumn
        Friend WithEvents col_num_clasif As DataGridViewTextBoxColumn
        Friend WithEvents col_fic_id2 As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_fic As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_cla As DataGridViewTextBoxColumn
        Friend WithEvents col_ptje As DataGridViewTextBoxColumn
        Friend WithEvents col_id_cat As DataGridViewTextBoxColumn
        Friend WithEvents col_cat_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_fic_fin As DataGridViewCheckBoxColumn
        Friend WithEvents col_estado As DataGridViewTextBoxColumn
        Friend WithEvents col_estado_id As DataGridViewTextBoxColumn
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents col_fic_det_id As DataGridViewTextBoxColumn
        Friend WithEvents col_mae_var_id As DataGridViewTextBoxColumn
        Friend WithEvents col_var_mae_id As DataGridViewTextBoxColumn
        Friend WithEvents col_fic_id As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents col_val_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_val_id_sel As DataGridViewTextBoxColumn
        Friend WithEvents col_val_mae_sel As DataGridViewTextBoxColumn
        Friend WithEvents col_valor As DataGridViewTextBoxColumn
        Friend WithEvents col_ptje_noprev As DataGridViewTextBoxColumn
        Friend WithEvents col_ptje2 As DataGridViewTextBoxColumn
        Friend WithEvents col_buton As DataGridViewButtonColumn
        Friend WithEvents Label4 As Label
        Friend WithEvents btnUbicacion As Button
        Friend WithEvents btnBuscarPabellon As Button
        Friend WithEvents lblPabellon As Label
        Friend WithEvents lblRegimen As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents dtpHoraETAPA As DateTimePicker
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnCancelEdit As Button
        Friend WithEvents btnNuevo As Button
        Friend WithEvents pnlOrgCrim As Panel
        Friend WithEvents rdbOrgCrimSI As RadioButton
        Friend WithEvents rdbOrgCrimNO As RadioButton
        Friend WithEvents Label5 As Label
        Friend WithEvents Panel3 As Panel
        Friend WithEvents btnHelpClasifEtap As Button
    End Class
End Namespace