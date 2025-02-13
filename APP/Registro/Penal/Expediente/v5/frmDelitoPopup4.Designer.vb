Namespace Registro.Expediente.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDelitoPopup4
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtTitulo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscComboDelito1 = New APPControls.Busqueda.UscComboDelito()
            Me.txtArticulo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSeccionNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSeccionNro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCapituloNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCapituloNro = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtDelitogenerico = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgvAgraviados = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblMantenimientoAgraviado = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnDelAgraviado = New System.Windows.Forms.Button()
            Me.btnAddAgraviado = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pnlGrabarDatosAgraviado = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            CType(Me.dgvAgraviados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlGrabarDatosAgraviado.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(475, 432)
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.txtObservacion)
            Me.GroupBox4.Controls.Add(Me.txtTitulo)
            Me.GroupBox4.Controls.Add(Me.UscComboDelito1)
            Me.GroupBox4.Controls.Add(Me.txtArticulo)
            Me.GroupBox4.Controls.Add(Me.txtSeccionNom)
            Me.GroupBox4.Controls.Add(Me.txtSeccionNro)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.txtCapituloNombre)
            Me.GroupBox4.Controls.Add(Me.txtCapituloNro)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.txtDelitogenerico)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(475, 158)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(2, 93)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(79, 13)
            Me.Label6.TabIndex = 11
            Me.Label6.Text = "DELITO ESP. :"
            '
            'txtObservacion
            '
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = True
            Me.txtObservacion.Location = New System.Drawing.Point(88, 112)
            Me.txtObservacion.MaxLength = 2500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(375, 44)
            Me.txtObservacion.TabIndex = 14
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            '
            'txtTitulo
            '
            Me.txtTitulo._BloquearPaste = False
            Me.txtTitulo._SeleccionarTodo = True
            Me.txtTitulo.Location = New System.Drawing.Point(88, 9)
            Me.txtTitulo.Name = "txtTitulo"
            Me.txtTitulo.ReadOnly = True
            Me.txtTitulo.Size = New System.Drawing.Size(35, 20)
            Me.txtTitulo.TabIndex = 1
            Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtTitulo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTitulo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'UscComboDelito1
            '
            Me.UscComboDelito1._CondicionElimina = False
            Me.UscComboDelito1._DelitoArticuloNombre = ""
            Me.UscComboDelito1._DelitoCapituloNombre = ""
            Me.UscComboDelito1._DelitoCapituloNumero = ""
            Me.UscComboDelito1._DelitoEspecifico_ID = -1
            Me.UscComboDelito1._DelitoEstado = -1
            Me.UscComboDelito1._DelitoGenericoID = -1
            Me.UscComboDelito1._DelitoGenericoNombre = ""
            Me.UscComboDelito1._DelitoParCod = ""
            Me.UscComboDelito1._DelitoSeccionNombre = ""
            Me.UscComboDelito1._DelitoSeccionNumero = ""
            Me.UscComboDelito1._DelitoTitulo = ""
            Me.UscComboDelito1.Location = New System.Drawing.Point(88, 89)
            Me.UscComboDelito1.Name = "UscComboDelito1"
            Me.UscComboDelito1.Size = New System.Drawing.Size(376, 21)
            Me.UscComboDelito1.TabIndex = 12
            '
            'txtArticulo
            '
            Me.txtArticulo._BloquearPaste = False
            Me.txtArticulo._SeleccionarTodo = True
            Me.txtArticulo.Location = New System.Drawing.Point(88, 67)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.ReadOnly = True
            Me.txtArticulo.Size = New System.Drawing.Size(35, 20)
            Me.txtArticulo.TabIndex = 10
            Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtArticulo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtArticulo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtSeccionNom
            '
            Me.txtSeccionNom._BloquearPaste = False
            Me.txtSeccionNom._SeleccionarTodo = True
            Me.txtSeccionNom.Location = New System.Drawing.Point(129, 49)
            Me.txtSeccionNom.Name = "txtSeccionNom"
            Me.txtSeccionNom.ReadOnly = True
            Me.txtSeccionNom.Size = New System.Drawing.Size(334, 20)
            Me.txtSeccionNom.TabIndex = 8
            Me.txtSeccionNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSeccionNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtSeccionNro
            '
            Me.txtSeccionNro._BloquearPaste = False
            Me.txtSeccionNro._SeleccionarTodo = True
            Me.txtSeccionNro.Location = New System.Drawing.Point(88, 49)
            Me.txtSeccionNro.Name = "txtSeccionNro"
            Me.txtSeccionNro.ReadOnly = True
            Me.txtSeccionNro.Size = New System.Drawing.Size(35, 20)
            Me.txtSeccionNro.TabIndex = 7
            Me.txtSeccionNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtSeccionNro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSeccionNro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(2, 36)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(81, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "CAPITULO N° :"
            '
            'txtCapituloNombre
            '
            Me.txtCapituloNombre._BloquearPaste = False
            Me.txtCapituloNombre._SeleccionarTodo = True
            Me.txtCapituloNombre.Location = New System.Drawing.Point(129, 29)
            Me.txtCapituloNombre.Name = "txtCapituloNombre"
            Me.txtCapituloNombre.ReadOnly = True
            Me.txtCapituloNombre.Size = New System.Drawing.Size(334, 20)
            Me.txtCapituloNombre.TabIndex = 5
            Me.txtCapituloNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtCapituloNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtCapituloNro
            '
            Me.txtCapituloNro._BloquearPaste = False
            Me.txtCapituloNro._SeleccionarTodo = True
            Me.txtCapituloNro.Location = New System.Drawing.Point(88, 29)
            Me.txtCapituloNro.Name = "txtCapituloNro"
            Me.txtCapituloNro.ReadOnly = True
            Me.txtCapituloNro.Size = New System.Drawing.Size(35, 20)
            Me.txtCapituloNro.TabIndex = 4
            Me.txtCapituloNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtCapituloNro.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtCapituloNro.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(2, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(67, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "TITULO N° :"
            '
            'txtDelitogenerico
            '
            Me.txtDelitogenerico._BloquearPaste = False
            Me.txtDelitogenerico._SeleccionarTodo = True
            Me.txtDelitogenerico.Location = New System.Drawing.Point(129, 9)
            Me.txtDelitogenerico.Name = "txtDelitogenerico"
            Me.txtDelitogenerico.ReadOnly = True
            Me.txtDelitogenerico.Size = New System.Drawing.Size(335, 20)
            Me.txtDelitogenerico.TabIndex = 2
            Me.txtDelitogenerico.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDelitogenerico.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(2, 54)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(60, 13)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "SECCIÓN :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(2, 72)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(67, 13)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "ARTÍCULO :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(2, 119)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(87, 13)
            Me.Label3.TabIndex = 13
            Me.Label3.Text = "OBSERVACION:"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 343)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(475, 47)
            Me.Panel2.TabIndex = 2
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnOk)
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(174, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(198, 47)
            Me.pnlGrabarDatos.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(99, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(372, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(103, 47)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(3, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dgvAgraviados
            '
            Me.dgvAgraviados.AllowUserToAddRows = False
            Me.dgvAgraviados.BackgroundColor = System.Drawing.Color.White
            Me.dgvAgraviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAgraviados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.col_agr_id, Me.col_agr_nom, Me.col_agr_obs, Me.col_agr_item})
            Me.dgvAgraviados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvAgraviados.GridColor = System.Drawing.Color.LightGray
            Me.dgvAgraviados.Location = New System.Drawing.Point(3, 44)
            Me.dgvAgraviados.MultiSelect = False
            Me.dgvAgraviados.Name = "dgvAgraviados"
            Me.dgvAgraviados.ReadOnly = True
            Me.dgvAgraviados.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvAgraviados.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAgraviados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAgraviados.Size = New System.Drawing.Size(469, 138)
            Me.dgvAgraviados.TabIndex = 1
            '
            'Column1
            '
            Me.Column1.HeaderText = "N°"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 25
            '
            'col_agr_id
            '
            Me.col_agr_id.DataPropertyName = "Codigo"
            Me.col_agr_id.HeaderText = "AgraviadoID"
            Me.col_agr_id.Name = "col_agr_id"
            Me.col_agr_id.ReadOnly = True
            Me.col_agr_id.Visible = False
            Me.col_agr_id.Width = 35
            '
            'col_agr_nom
            '
            Me.col_agr_nom.DataPropertyName = "AgraviadoNombre"
            Me.col_agr_nom.HeaderText = "Agraviado"
            Me.col_agr_nom.Name = "col_agr_nom"
            Me.col_agr_nom.ReadOnly = True
            Me.col_agr_nom.Width = 220
            '
            'col_agr_obs
            '
            Me.col_agr_obs.DataPropertyName = "Observacion"
            Me.col_agr_obs.HeaderText = "Observacion"
            Me.col_agr_obs.Name = "col_agr_obs"
            Me.col_agr_obs.ReadOnly = True
            Me.col_agr_obs.Width = 150
            '
            'col_agr_item
            '
            Me.col_agr_item.DataPropertyName = "AgraviadoItem"
            Me.col_agr_item.HeaderText = "AgraviadoItem"
            Me.col_agr_item.Name = "col_agr_item"
            Me.col_agr_item.ReadOnly = True
            Me.col_agr_item.Visible = False
            Me.col_agr_item.Width = 25
            '
            'lblMantenimientoAgraviado
            '
            Me.lblMantenimientoAgraviado.AutoSize = True
            Me.lblMantenimientoAgraviado.Location = New System.Drawing.Point(3, 8)
            Me.lblMantenimientoAgraviado.Name = "lblMantenimientoAgraviado"
            Me.lblMantenimientoAgraviado.Size = New System.Drawing.Size(195, 13)
            Me.lblMantenimientoAgraviado.TabIndex = 0
            Me.lblMantenimientoAgraviado.Text = "MANTENIMIENTO DE AGRAVIADOS :"
            '
            'ToolTip1
            '
            Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "MANTENIMIENTO DE AGRAVIADO"
            '
            'btnDelAgraviado
            '
            Me.btnDelAgraviado.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnDelAgraviado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelAgraviado.Location = New System.Drawing.Point(31, 3)
            Me.btnDelAgraviado.Name = "btnDelAgraviado"
            Me.btnDelAgraviado.Size = New System.Drawing.Size(27, 22)
            Me.btnDelAgraviado.TabIndex = 2
            Me.ToolTip1.SetToolTip(Me.btnDelAgraviado, "Quitar el agraviado seleccionado")
            Me.btnDelAgraviado.UseVisualStyleBackColor = True
            '
            'btnAddAgraviado
            '
            Me.btnAddAgraviado.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddAgraviado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddAgraviado.Location = New System.Drawing.Point(3, 3)
            Me.btnAddAgraviado.Name = "btnAddAgraviado"
            Me.btnAddAgraviado.Size = New System.Drawing.Size(27, 22)
            Me.btnAddAgraviado.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.btnAddAgraviado, "Agregar agraviados")
            Me.btnAddAgraviado.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgvAgraviados)
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 158)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(475, 185)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pnlGrabarDatosAgraviado)
            Me.Panel1.Controls.Add(Me.lblMantenimientoAgraviado)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(469, 28)
            Me.Panel1.TabIndex = 0
            '
            'pnlGrabarDatosAgraviado
            '
            Me.pnlGrabarDatosAgraviado.Controls.Add(Me.btnDelAgraviado)
            Me.pnlGrabarDatosAgraviado.Controls.Add(Me.btnAddAgraviado)
            Me.pnlGrabarDatosAgraviado.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatosAgraviado.Location = New System.Drawing.Point(408, 0)
            Me.pnlGrabarDatosAgraviado.Name = "pnlGrabarDatosAgraviado"
            Me.pnlGrabarDatosAgraviado.Size = New System.Drawing.Size(61, 28)
            Me.pnlGrabarDatosAgraviado.TabIndex = 3
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 390)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(475, 42)
            Me.UscAuditUser1.TabIndex = 3
            '
            'frmDelitoPopup4
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(475, 432)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmDelitoPopup4"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Delitos del Interno"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            CType(Me.dgvAgraviados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.pnlGrabarDatosAgraviado.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtDelitogenerico As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtCapituloNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCapituloNro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtArticulo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSeccionNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSeccionNro As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dgvAgraviados As System.Windows.Forms.DataGridView
        Friend WithEvents lblMantenimientoAgraviado As System.Windows.Forms.Label
        Friend WithEvents btnAddAgraviado As System.Windows.Forms.Button
        Friend WithEvents btnDelAgraviado As System.Windows.Forms.Button
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents UscComboDelito1 As APPControls.Busqueda.UscComboDelito
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents txtTitulo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabarDatosAgraviado As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label

    End Class
End Namespace
