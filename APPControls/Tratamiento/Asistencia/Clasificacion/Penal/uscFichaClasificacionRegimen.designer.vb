'Namespace Registro.Carceleta.Clasificacion
Namespace Tratamiento.Asistencia.Clasificacion.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscFichaClasificacionRegimen
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
            Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBotonesGrilla = New System.Windows.Forms.Panel()
            Me.btnBloquear = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.pnlBotonGrabarFicha = New System.Windows.Forms.Panel()
            Me.btnGrabarFicha = New System.Windows.Forms.Button()
            Me.btnListarVariables = New System.Windows.Forms.Button()
            Me.dgvFichaVariables = New System.Windows.Forms.DataGridView()
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
            Me.lblResultado = New System.Windows.Forms.Label()
            Me.lblEtiquetaResul = New System.Windows.Forms.Label()
            Me.gbDatosFicha = New System.Windows.Forms.GroupBox()
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
            Me.lblRegimen = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.pnlFichas = New System.Windows.Forms.Panel()
            Me.dgwGrillaFicha = New System.Windows.Forms.DataGridView()
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
            Me.pnlDatosApertura = New System.Windows.Forms.Panel()
            Me.txtNumClasif = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaRegimen = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.pnlSubDetalle = New System.Windows.Forms.Panel()
            Me.pnlDatosFicha = New System.Windows.Forms.Panel()
            Me.pnlDetalle2 = New System.Windows.Forms.Panel()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.dtpHoraETAPA = New System.Windows.Forms.DateTimePicker()
            Me.pnlBotonesGrilla.SuspendLayout()
            Me.pnlBotonGrabarFicha.SuspendLayout()
            CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlResultadoFicha.SuspendLayout()
            Me.gbUbicacion.SuspendLayout()
            Me.gbDatosFicha.SuspendLayout()
            Me.pnlFichas.SuspendLayout()
            CType(Me.dgwGrillaFicha, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCabecera.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlRegimen.SuspendLayout()
            Me.pnlDatosApertura.SuspendLayout()
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
            Me.pnlBotonesGrilla.Location = New System.Drawing.Point(1172, 0)
            Me.pnlBotonesGrilla.Name = "pnlBotonesGrilla"
            Me.pnlBotonesGrilla.Size = New System.Drawing.Size(38, 131)
            Me.pnlBotonesGrilla.TabIndex = 89
            '
            'btnBloquear
            '
            Me.btnBloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBloquear.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnBloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBloquear.Image = Global.APPControls.My.Resources.Resources.candado
            Me.btnBloquear.Location = New System.Drawing.Point(0, 80)
            Me.btnBloquear.Name = "btnBloquear"
            Me.btnBloquear.Size = New System.Drawing.Size(38, 40)
            Me.btnBloquear.TabIndex = 98
            Me.btnBloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnBloquear, "Finalizar ficha")
            '
            'btnReporte
            '
            Me.btnReporte.BackgroundImage = Global.APPControls.My.Resources.Resources.printer3
            Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnReporte.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnReporte.Location = New System.Drawing.Point(0, 40)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(38, 40)
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
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(38, 40)
            Me.btnRefresh.TabIndex = 96
            Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refrescar lista de fichas, permite ver las fichas de los demás.")
            Me.btnRefresh.UseVisualStyleBackColor = True
            '
            'pnlBotonGrabarFicha
            '
            Me.pnlBotonGrabarFicha.Controls.Add(Me.btnGrabarFicha)
            Me.pnlBotonGrabarFicha.Controls.Add(Me.btnListarVariables)
            Me.pnlBotonGrabarFicha.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotonGrabarFicha.Location = New System.Drawing.Point(1171, 0)
            Me.pnlBotonGrabarFicha.Name = "pnlBotonGrabarFicha"
            Me.pnlBotonGrabarFicha.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
            Me.pnlBotonGrabarFicha.Size = New System.Drawing.Size(39, 365)
            Me.pnlBotonGrabarFicha.TabIndex = 96
            '
            'btnGrabarFicha
            '
            Me.btnGrabarFicha.BackgroundImage = Global.APPControls.My.Resources.Resources.Diskette_32x32
            Me.btnGrabarFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnGrabarFicha.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnGrabarFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarFicha.Location = New System.Drawing.Point(0, 60)
            Me.btnGrabarFicha.Name = "btnGrabarFicha"
            Me.btnGrabarFicha.Size = New System.Drawing.Size(39, 40)
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
            Me.btnListarVariables.Location = New System.Drawing.Point(0, 20)
            Me.btnListarVariables.Name = "btnListarVariables"
            Me.btnListarVariables.Size = New System.Drawing.Size(39, 40)
            Me.btnListarVariables.TabIndex = 93
            Me.btnListarVariables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnListarVariables, "Actualizar Variables")
            '
            'dgvFichaVariables
            '
            Me.dgvFichaVariables.AllowUserToAddRows = False
            Me.dgvFichaVariables.AllowUserToDeleteRows = False
            Me.dgvFichaVariables.AllowUserToResizeRows = False
            DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvFichaVariables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle40
            Me.dgvFichaVariables.BackgroundColor = System.Drawing.Color.White
            Me.dgvFichaVariables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFichaVariables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle41
            Me.dgvFichaVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFichaVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fic_det_id, Me.col_mae_var_id, Me.col_var_mae_id, Me.col_fic_id, Me.DataGridViewTextBoxColumn4, Me.col_val_nom, Me.col_val_id_sel, Me.col_val_mae_sel, Me.col_valor, Me.col_ptje_noprev, Me.col_ptje2, Me.col_buton})
            DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFichaVariables.DefaultCellStyle = DataGridViewCellStyle46
            Me.dgvFichaVariables.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFichaVariables.GridColor = System.Drawing.Color.SkyBlue
            Me.dgvFichaVariables.Location = New System.Drawing.Point(0, 0)
            Me.dgvFichaVariables.MultiSelect = False
            Me.dgvFichaVariables.Name = "dgvFichaVariables"
            Me.dgvFichaVariables.ReadOnly = True
            DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFichaVariables.RowHeadersDefaultCellStyle = DataGridViewCellStyle47
            Me.dgvFichaVariables.RowHeadersVisible = False
            DataGridViewCellStyle48.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvFichaVariables.RowsDefaultCellStyle = DataGridViewCellStyle48
            Me.dgvFichaVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFichaVariables.Size = New System.Drawing.Size(1171, 206)
            Me.dgvFichaVariables.TabIndex = 22
            '
            'col_fic_det_id
            '
            Me.col_fic_det_id.HeaderText = "FicDetId"
            Me.col_fic_det_id.Name = "col_fic_det_id"
            Me.col_fic_det_id.ReadOnly = True
            Me.col_fic_det_id.Visible = False
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
            Me.col_var_mae_id.Name = "col_var_mae_id"
            Me.col_var_mae_id.ReadOnly = True
            Me.col_var_mae_id.Visible = False
            '
            'col_fic_id
            '
            Me.col_fic_id.DataPropertyName = "FichaId"
            Me.col_fic_id.HeaderText = "FichaId"
            Me.col_fic_id.Name = "col_fic_id"
            Me.col_fic_id.ReadOnly = True
            Me.col_fic_id.Visible = False
            Me.col_fic_id.Width = 50
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumeroOrdenString"
            DataGridViewCellStyle42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle42
            Me.DataGridViewTextBoxColumn4.HeaderText = "N°"
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
            Me.col_val_id_sel.Name = "col_val_id_sel"
            Me.col_val_id_sel.ReadOnly = True
            Me.col_val_id_sel.Visible = False
            Me.col_val_id_sel.Width = 30
            '
            'col_val_mae_sel
            '
            Me.col_val_mae_sel.HeaderText = "Val_mae_Select"
            Me.col_val_mae_sel.Name = "col_val_mae_sel"
            Me.col_val_mae_sel.ReadOnly = True
            Me.col_val_mae_sel.Visible = False
            '
            'col_valor
            '
            Me.col_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle43.ForeColor = System.Drawing.Color.Green
            DataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_valor.DefaultCellStyle = DataGridViewCellStyle43
            Me.col_valor.HeaderText = "Indicador seleccionado"
            Me.col_valor.Name = "col_valor"
            Me.col_valor.ReadOnly = True
            '
            'col_ptje_noprev
            '
            Me.col_ptje_noprev.DataPropertyName = "PuntajeNoPrevisto"
            DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle44.NullValue = "0"
            Me.col_ptje_noprev.DefaultCellStyle = DataGridViewCellStyle44
            Me.col_ptje_noprev.HeaderText = "NoPrevisto"
            Me.col_ptje_noprev.Name = "col_ptje_noprev"
            Me.col_ptje_noprev.ReadOnly = True
            Me.col_ptje_noprev.Width = 65
            '
            'col_ptje2
            '
            Me.col_ptje2.DataPropertyName = "Puntaje"
            DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle45.NullValue = "0"
            Me.col_ptje2.DefaultCellStyle = DataGridViewCellStyle45
            Me.col_ptje2.HeaderText = "Puntaje"
            Me.col_ptje2.Name = "col_ptje2"
            Me.col_ptje2.ReadOnly = True
            Me.col_ptje2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ptje2.Width = 50
            '
            'col_buton
            '
            Me.col_buton.HeaderText = ""
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
            Me.pnlResultadoFicha.Location = New System.Drawing.Point(0, 87)
            Me.pnlResultadoFicha.Name = "pnlResultadoFicha"
            Me.pnlResultadoFicha.Size = New System.Drawing.Size(1171, 72)
            Me.pnlResultadoFicha.TabIndex = 20
            '
            'gbUbicacion
            '
            Me.gbUbicacion.Controls.Add(Me.btnBuscarPabellon)
            Me.gbUbicacion.Controls.Add(Me.lblPabellon)
            Me.gbUbicacion.Controls.Add(Me.Label4)
            Me.gbUbicacion.Controls.Add(Me.lblResultado)
            Me.gbUbicacion.Controls.Add(Me.lblEtiquetaResul)
            Me.gbUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbUbicacion.Location = New System.Drawing.Point(0, 0)
            Me.gbUbicacion.Name = "gbUbicacion"
            Me.gbUbicacion.Size = New System.Drawing.Size(1171, 72)
            Me.gbUbicacion.TabIndex = 19
            Me.gbUbicacion.TabStop = False
            Me.gbUbicacion.Text = "RESULTADO"
            '
            'btnBuscarPabellon
            '
            Me.btnBuscarPabellon.BackgroundImage = Global.APPControls.My.Resources.Resources._1345240399_search_button
            Me.btnBuscarPabellon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBuscarPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPabellon.Location = New System.Drawing.Point(236, 39)
            Me.btnBuscarPabellon.Name = "btnBuscarPabellon"
            Me.btnBuscarPabellon.Size = New System.Drawing.Size(28, 26)
            Me.btnBuscarPabellon.TabIndex = 33
            Me.btnBuscarPabellon.UseVisualStyleBackColor = True
            Me.btnBuscarPabellon.Visible = False
            '
            'lblPabellon
            '
            Me.lblPabellon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPabellon.ForeColor = System.Drawing.Color.Black
            Me.lblPabellon.Location = New System.Drawing.Point(75, 41)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(161, 20)
            Me.lblPabellon.TabIndex = 32
            Me.lblPabellon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblPabellon.Visible = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(4, 47)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(66, 13)
            Me.Label4.TabIndex = 21
            Me.Label4.Text = "PABELLÓN:"
            Me.Label4.Visible = False
            '
            'lblResultado
            '
            Me.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblResultado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblResultado.Location = New System.Drawing.Point(75, 14)
            Me.lblResultado.Name = "lblResultado"
            Me.lblResultado.Size = New System.Drawing.Size(341, 20)
            Me.lblResultado.TabIndex = 19
            Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblEtiquetaResul
            '
            Me.lblEtiquetaResul.AutoSize = True
            Me.lblEtiquetaResul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaResul.Location = New System.Drawing.Point(10, 18)
            Me.lblEtiquetaResul.Name = "lblEtiquetaResul"
            Me.lblEtiquetaResul.Size = New System.Drawing.Size(60, 13)
            Me.lblEtiquetaResul.TabIndex = 13
            Me.lblEtiquetaResul.Text = "REGIMEN:"
            '
            'gbDatosFicha
            '
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
            Me.gbDatosFicha.Name = "gbDatosFicha"
            Me.gbDatosFicha.Size = New System.Drawing.Size(1171, 87)
            Me.gbDatosFicha.TabIndex = 17
            Me.gbDatosFicha.TabStop = False
            Me.gbDatosFicha.Text = "DATOS DE LA FICHA:"
            '
            'lblFichaFechaClasi
            '
            Me.lblFichaFechaClasi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFichaFechaClasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFichaFechaClasi.ForeColor = System.Drawing.Color.Black
            Me.lblFichaFechaClasi.Location = New System.Drawing.Point(252, 40)
            Me.lblFichaFechaClasi.Name = "lblFichaFechaClasi"
            Me.lblFichaFechaClasi.Size = New System.Drawing.Size(164, 18)
            Me.lblFichaFechaClasi.TabIndex = 29
            Me.lblFichaFechaClasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSituacionJuridica
            '
            Me.lblSituacionJuridica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblSituacionJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSituacionJuridica.ForeColor = System.Drawing.Color.Black
            Me.lblSituacionJuridica.Location = New System.Drawing.Point(111, 19)
            Me.lblSituacionJuridica.Name = "lblSituacionJuridica"
            Me.lblSituacionJuridica.Size = New System.Drawing.Size(305, 18)
            Me.lblSituacionJuridica.TabIndex = 27
            Me.lblSituacionJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(11, 21)
            Me.Label13.Margin = New System.Windows.Forms.Padding(0)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(98, 13)
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
            Me.txtobservacion.Location = New System.Drawing.Point(422, 41)
            Me.txtobservacion.MaxLength = 2000
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobservacion.Size = New System.Drawing.Size(743, 42)
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
            Me.txtFichaNumClasifi.Location = New System.Drawing.Point(111, 38)
            Me.txtFichaNumClasifi.MaxLength = 2
            Me.txtFichaNumClasifi.Name = "txtFichaNumClasifi"
            Me.txtFichaNumClasifi.ReadOnly = True
            Me.txtFichaNumClasifi.Size = New System.Drawing.Size(58, 21)
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
            Me.lblPuntaje.Location = New System.Drawing.Point(784, 19)
            Me.lblPuntaje.Name = "lblPuntaje"
            Me.lblPuntaje.Size = New System.Drawing.Size(83, 13)
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
            Me.txtPuntTotal.Location = New System.Drawing.Point(883, 14)
            Me.txtPuntTotal.Name = "txtPuntTotal"
            Me.txtPuntTotal.ReadOnly = True
            Me.txtPuntTotal.Size = New System.Drawing.Size(282, 21)
            Me.txtPuntTotal.TabIndex = 2
            Me.txtPuntTotal.Text = "0"
            Me.txtPuntTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(425, 24)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(73, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Observación :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(84, 13)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "N° Clasificación:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(172, 40)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(74, 13)
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
            Me.cbbSitJuridica.Location = New System.Drawing.Point(553, 6)
            Me.cbbSitJuridica.Name = "cbbSitJuridica"
            Me.cbbSitJuridica.Size = New System.Drawing.Size(124, 21)
            Me.cbbSitJuridica.TabIndex = 27
            '
            'Label9
            '
            Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(454, 11)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(95, 13)
            Me.Label9.TabIndex = 26
            Me.Label9.Text = "Situación Jurídica:"
            '
            'lblRegimen
            '
            Me.lblRegimen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblRegimen.AutoSize = True
            Me.lblRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegimen.Location = New System.Drawing.Point(19, 11)
            Me.lblRegimen.Name = "lblRegimen"
            Me.lblRegimen.Size = New System.Drawing.Size(63, 13)
            Me.lblRegimen.TabIndex = 7
            Me.lblRegimen.Text = "REGIMEN :"
            '
            'btnNuevo
            '
            Me.btnNuevo.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(32, 31)
            Me.btnNuevo.TabIndex = 89
            Me.btnNuevo.Tag = "Nuevo"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnNuevo, "Agregar")
            '
            'btnCancelar
            '
            Me.btnCancelar.BackgroundImage = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Location = New System.Drawing.Point(32, 0)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(32, 31)
            Me.btnCancelar.TabIndex = 89
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar")
            '
            'pnlFichas
            '
            Me.pnlFichas.Controls.Add(Me.dgwGrillaFicha)
            Me.pnlFichas.Controls.Add(Me.pnlBotonesGrilla)
            Me.pnlFichas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlFichas.Location = New System.Drawing.Point(0, 0)
            Me.pnlFichas.Name = "pnlFichas"
            Me.pnlFichas.Size = New System.Drawing.Size(1210, 131)
            Me.pnlFichas.TabIndex = 91
            '
            'dgwGrillaFicha
            '
            Me.dgwGrillaFicha.AllowUserToAddRows = False
            Me.dgwGrillaFicha.AllowUserToDeleteRows = False
            Me.dgwGrillaFicha.AllowUserToResizeRows = False
            Me.dgwGrillaFicha.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaFicha.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle49
            Me.dgwGrillaFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaFicha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.tip_fic_id, Me.col_num_clasif, Me.col_fic_id2, Me.col_nom_fic, Me.col_fec_cla, Me.col_ptje, Me.col_id_cat, Me.col_cat_nom, Me.col_fic_fin, Me.col_estado, Me.col_estado_id})
            DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaFicha.DefaultCellStyle = DataGridViewCellStyle50
            Me.dgwGrillaFicha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaFicha.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaFicha.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrillaFicha.MultiSelect = False
            Me.dgwGrillaFicha.Name = "dgwGrillaFicha"
            Me.dgwGrillaFicha.ReadOnly = True
            DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaFicha.RowHeadersDefaultCellStyle = DataGridViewCellStyle51
            Me.dgwGrillaFicha.RowHeadersVisible = False
            DataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaFicha.RowsDefaultCellStyle = DataGridViewCellStyle52
            Me.dgwGrillaFicha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaFicha.Size = New System.Drawing.Size(1172, 131)
            Me.dgwGrillaFicha.TabIndex = 91
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
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
            Me.col_num_clasif.Name = "col_num_clasif"
            Me.col_num_clasif.ReadOnly = True
            Me.col_num_clasif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_num_clasif.Width = 60
            '
            'col_fic_id2
            '
            Me.col_fic_id2.DataPropertyName = "IDFicha"
            Me.col_fic_id2.HeaderText = "IDFicha"
            Me.col_fic_id2.Name = "col_fic_id2"
            Me.col_fic_id2.ReadOnly = True
            Me.col_fic_id2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fic_id2.Visible = False
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
            Me.col_fec_cla.Name = "col_fec_cla"
            Me.col_fec_cla.ReadOnly = True
            Me.col_fec_cla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fec_cla.Width = 150
            '
            'col_ptje
            '
            Me.col_ptje.DataPropertyName = "Puntaje"
            Me.col_ptje.HeaderText = "Puntaje"
            Me.col_ptje.Name = "col_ptje"
            Me.col_ptje.ReadOnly = True
            Me.col_ptje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ptje.Width = 50
            '
            'col_id_cat
            '
            Me.col_id_cat.DataPropertyName = "CategoriaFichaId"
            Me.col_id_cat.HeaderText = "CategoriaID"
            Me.col_id_cat.Name = "col_id_cat"
            Me.col_id_cat.ReadOnly = True
            Me.col_id_cat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_id_cat.Visible = False
            '
            'col_cat_nom
            '
            Me.col_cat_nom.DataPropertyName = "CategoriaFichaNombre"
            Me.col_cat_nom.HeaderText = "Categoria"
            Me.col_cat_nom.Name = "col_cat_nom"
            Me.col_cat_nom.ReadOnly = True
            Me.col_cat_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_cat_nom.Visible = False
            Me.col_cat_nom.Width = 300
            '
            'col_fic_fin
            '
            Me.col_fic_fin.HeaderText = "Ficha Final"
            Me.col_fic_fin.Name = "col_fic_fin"
            Me.col_fic_fin.ReadOnly = True
            Me.col_fic_fin.Visible = False
            Me.col_fic_fin.Width = 70
            '
            'col_estado
            '
            Me.col_estado.DataPropertyName = "EstadoNombre"
            Me.col_estado.HeaderText = "Estado"
            Me.col_estado.Name = "col_estado"
            Me.col_estado.ReadOnly = True
            Me.col_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_estado.Width = 120
            '
            'col_estado_id
            '
            Me.col_estado_id.DataPropertyName = "Estado"
            Me.col_estado_id.HeaderText = "EstadoId"
            Me.col_estado_id.Name = "col_estado_id"
            Me.col_estado_id.ReadOnly = True
            Me.col_estado_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_estado_id.Visible = False
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.Panel1)
            Me.pnlCabecera.Controls.Add(Me.pnlRegimen)
            Me.pnlCabecera.Controls.Add(Me.pnlDatosApertura)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(1210, 34)
            Me.pnlCabecera.TabIndex = 90
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancelar)
            Me.Panel1.Controls.Add(Me.btnNuevo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(875, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(183, 34)
            Me.Panel1.TabIndex = 32
            '
            'pnlRegimen
            '
            Me.pnlRegimen.Controls.Add(Me.lblRegimen)
            Me.pnlRegimen.Controls.Add(Me.cbbRegimen)
            Me.pnlRegimen.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlRegimen.Location = New System.Drawing.Point(682, 0)
            Me.pnlRegimen.Name = "pnlRegimen"
            Me.pnlRegimen.Size = New System.Drawing.Size(193, 34)
            Me.pnlRegimen.TabIndex = 30
            Me.pnlRegimen.Visible = False
            '
            'cbbRegimen
            '
            Me.cbbRegimen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimen.Location = New System.Drawing.Point(89, 6)
            Me.cbbRegimen.Name = "cbbRegimen"
            Me.cbbRegimen.Size = New System.Drawing.Size(101, 23)
            Me.cbbRegimen.TabIndex = 8
            '
            'pnlDatosApertura
            '
            Me.pnlDatosApertura.Controls.Add(Me.Label9)
            Me.pnlDatosApertura.Controls.Add(Me.cbbSitJuridica)
            Me.pnlDatosApertura.Controls.Add(Me.dtpHoraETAPA)
            Me.pnlDatosApertura.Controls.Add(Me.txtNumClasif)
            Me.pnlDatosApertura.Controls.Add(Me.dtpFechaRegimen)
            Me.pnlDatosApertura.Controls.Add(Me.Label6)
            Me.pnlDatosApertura.Controls.Add(Me.Label11)
            Me.pnlDatosApertura.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlDatosApertura.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatosApertura.Name = "pnlDatosApertura"
            Me.pnlDatosApertura.Size = New System.Drawing.Size(682, 34)
            Me.pnlDatosApertura.TabIndex = 33
            '
            'txtNumClasif
            '
            Me.txtNumClasif._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumClasif._BloquearPaste = False
            Me.txtNumClasif._SeleccionarTodo = False
            Me.txtNumClasif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumClasif.Location = New System.Drawing.Point(111, 7)
            Me.txtNumClasif.MaxLength = 2
            Me.txtNumClasif.Name = "txtNumClasif"
            Me.txtNumClasif.ReadOnly = True
            Me.txtNumClasif.Size = New System.Drawing.Size(58, 21)
            Me.txtNumClasif.TabIndex = 29
            Me.txtNumClasif.Text = "0"
            Me.txtNumClasif.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumClasif.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'dtpFechaRegimen
            '
            Me.dtpFechaRegimen.Location = New System.Drawing.Point(282, 7)
            Me.dtpFechaRegimen.Name = "dtpFechaRegimen"
            Me.dtpFechaRegimen.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRegimen.TabIndex = 27
            Me.dtpFechaRegimen.Value = "/  /"
            Me.dtpFechaRegimen.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(11, 11)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(84, 13)
            Me.Label6.TabIndex = 28
            Me.Label6.Text = "N° Clasificación:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(180, 11)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(102, 13)
            Me.Label11.TabIndex = 26
            Me.Label11.Text = "Fecha Clasificación:"
            '
            'pnlSubDetalle
            '
            Me.pnlSubDetalle.Controls.Add(Me.pnlResultadoFicha)
            Me.pnlSubDetalle.Controls.Add(Me.pnlDatosFicha)
            Me.pnlSubDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlSubDetalle.Location = New System.Drawing.Point(0, 206)
            Me.pnlSubDetalle.Name = "pnlSubDetalle"
            Me.pnlSubDetalle.Size = New System.Drawing.Size(1171, 159)
            Me.pnlSubDetalle.TabIndex = 97
            '
            'pnlDatosFicha
            '
            Me.pnlDatosFicha.Controls.Add(Me.gbDatosFicha)
            Me.pnlDatosFicha.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDatosFicha.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatosFicha.Name = "pnlDatosFicha"
            Me.pnlDatosFicha.Size = New System.Drawing.Size(1171, 87)
            Me.pnlDatosFicha.TabIndex = 25
            '
            'pnlDetalle2
            '
            Me.pnlDetalle2.Controls.Add(Me.dgvFichaVariables)
            Me.pnlDetalle2.Controls.Add(Me.pnlSubDetalle)
            Me.pnlDetalle2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle2.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle2.Name = "pnlDetalle2"
            Me.pnlDetalle2.Size = New System.Drawing.Size(1171, 365)
            Me.pnlDetalle2.TabIndex = 97
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 34)
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
            Me.SplitContainer1.Size = New System.Drawing.Size(1210, 500)
            Me.SplitContainer1.SplitterDistance = 131
            Me.SplitContainer1.TabIndex = 99
            '
            'dtpHoraETAPA
            '
            Me.dtpHoraETAPA.CustomFormat = "hh:mm tt"
            Me.dtpHoraETAPA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHoraETAPA.Location = New System.Drawing.Point(367, 7)
            Me.dtpHoraETAPA.Name = "dtpHoraETAPA"
            Me.dtpHoraETAPA.ShowUpDown = True
            Me.dtpHoraETAPA.Size = New System.Drawing.Size(81, 20)
            Me.dtpHoraETAPA.TabIndex = 48
            Me.dtpHoraETAPA.Value = New Date(2023, 11, 16, 0, 0, 0, 0)
            '
            'uscFichaClasificacionRegimen
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SplitContainer1)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Name = "uscFichaClasificacionRegimen"
            Me.Size = New System.Drawing.Size(1210, 534)
            Me.pnlBotonesGrilla.ResumeLayout(False)
            Me.pnlBotonGrabarFicha.ResumeLayout(False)
            CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlResultadoFicha.ResumeLayout(False)
            Me.gbUbicacion.ResumeLayout(False)
            Me.gbUbicacion.PerformLayout()
            Me.gbDatosFicha.ResumeLayout(False)
            Me.gbDatosFicha.PerformLayout()
            Me.pnlFichas.ResumeLayout(False)
            CType(Me.dgwGrillaFicha, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCabecera.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlRegimen.ResumeLayout(False)
            Me.pnlRegimen.PerformLayout()
            Me.pnlDatosApertura.ResumeLayout(False)
            Me.pnlDatosApertura.PerformLayout()
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
        Friend WithEvents lblRegimen As System.Windows.Forms.Label
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
        Friend WithEvents dgwGrillaFicha As DataGridView
        Friend WithEvents pnlCabecera As Panel
        Friend WithEvents cbbRegimen As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label9 As Label
        Friend WithEvents dgvFichaVariables As DataGridView
        Friend WithEvents lblResultado As Label
        Friend WithEvents pnlRegimen As Panel
        Friend WithEvents pnlSubDetalle As Panel
        Friend WithEvents pnlDatosFicha As Panel
        Friend WithEvents pnlDetalle2 As Panel
        Friend WithEvents lblSituacionJuridica As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnNuevo As Button
        Friend WithEvents pnlDatosApertura As Panel
        Friend WithEvents txtNumClasif As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaRegimen As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents lblFichaFechaClasi As Label
        Friend WithEvents btnCancelar As Button
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
        Friend WithEvents btnBuscarPabellon As Button
        Friend WithEvents lblPabellon As Label
        Friend WithEvents btnBloquear As Button
        Friend WithEvents dtpHoraETAPA As DateTimePicker
    End Class
End Namespace