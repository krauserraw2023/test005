
Namespace Visita.Interno
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInternoHistoricoPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternoHistoricoPopup))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnOtro = New System.Windows.Forms.Button()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCodInterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.dgwMovi = New System.Windows.Forms.DataGridView()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.grbMovimiento = New System.Windows.Forms.GroupBox()
            Me.UscRegionPenalLabel1 = New APPControls.uscRegionPenalLabel()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnBuscarInternosPJ = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grbMovimiento.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlBusqueda)
            Me.gbxFormChildContainer.Controls.Add(Me.grbMovimiento)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(650, 443)
            '
            'btnOtro
            '
            Me.btnOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOtro.Image = Global.SIPPOPE.My.Resources.Resources.Camembert_32
            Me.btnOtro.Location = New System.Drawing.Point(7, 3)
            Me.btnOtro.Name = "btnOtro"
            Me.btnOtro.Size = New System.Drawing.Size(130, 40)
            Me.btnOtro.TabIndex = 39
            Me.btnOtro.Text = "Poblacion Penal"
            Me.btnOtro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOtro.UseVisualStyleBackColor = True
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.GroupBox8)
            Me.pnlBusqueda.Controls.Add(Me.grbBuscar)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 40)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(650, 132)
            Me.pnlBusqueda.TabIndex = 19
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.Label2)
            Me.GroupBox8.Controls.Add(Me.txtNumDoc)
            Me.GroupBox8.Controls.Add(Me.txtCodInterno)
            Me.GroupBox8.Controls.Add(Me.Label4)
            Me.GroupBox8.Controls.Add(Me.Label26)
            Me.GroupBox8.Controls.Add(Me.txtNom)
            Me.GroupBox8.Controls.Add(Me.Label3)
            Me.GroupBox8.Controls.Add(Me.txtApePat)
            Me.GroupBox8.Controls.Add(Me.Label1)
            Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(567, 132)
            Me.GroupBox8.TabIndex = 63
            Me.GroupBox8.TabStop = False
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Red
            Me.Label2.Location = New System.Drawing.Point(3, 98)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(561, 31)
            Me.Label2.TabIndex = 42
            Me.Label2.Text = "Seleccione el interno(a), luego haga doble click sobre el interno seleccionado, o" & _
        " haga click en el boton [Aceptar]"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(378, 15)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(111, 20)
            Me.txtNumDoc.TabIndex = 41
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtCodInterno
            '
            Me.txtCodInterno._BloquearPaste = False
            Me.txtCodInterno._SeleccionarTodo = False
            Me.txtCodInterno.Location = New System.Drawing.Point(113, 15)
            Me.txtCodInterno.Name = "txtCodInterno"
            Me.txtCodInterno.Size = New System.Drawing.Size(111, 20)
            Me.txtCodInterno.TabIndex = 40
            Me.txtCodInterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodInterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(273, 18)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(81, 13)
            Me.Label4.TabIndex = 39
            Me.Label4.Text = "Numero D.N.I. :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(9, 20)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(82, 13)
            Me.Label26.TabIndex = 38
            Me.Label26.Text = "Codigo Interno :"
            '
            'txtNom
            '
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(113, 68)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(376, 20)
            Me.txtNom.TabIndex = 28
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 73)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombres :"
            '
            'txtApePat
            '
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.Location = New System.Drawing.Point(113, 42)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(376, 20)
            Me.txtApePat.TabIndex = 0
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 46)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Apellidos  :"
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(567, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 132)
            Me.grbBuscar.TabIndex = 63
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 107)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(77, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbLimpiar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 113)
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
            'tsbLimpiar
            '
            Me.tsbLimpiar.BackColor = System.Drawing.Color.Transparent
            Me.tsbLimpiar.Image = Global.SIPPOPE.My.Resources.Resources.replace2
            Me.tsbLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbLimpiar.Name = "tsbLimpiar"
            Me.tsbLimpiar.Size = New System.Drawing.Size(75, 43)
            Me.tsbLimpiar.Text = "Limpiar"
            Me.tsbLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'dgwMovi
            '
            Me.dgwMovi.AllowUserToAddRows = False
            Me.dgwMovi.BackgroundColor = System.Drawing.Color.White
            Me.dgwMovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMovi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.col_int_id, Me.col_pdr, Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column5})
            Me.dgwMovi.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwMovi.GridColor = System.Drawing.Color.LightGray
            Me.dgwMovi.Location = New System.Drawing.Point(0, 0)
            Me.dgwMovi.MultiSelect = False
            Me.dgwMovi.Name = "dgwMovi"
            Me.dgwMovi.ReadOnly = True
            Me.dgwMovi.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwMovi.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwMovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMovi.Size = New System.Drawing.Size(500, 226)
            Me.dgwMovi.TabIndex = 9
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.ReadOnly = True
            Me.col_chk.Visible = False
            Me.col_chk.Width = 30
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_pdr
            '
            Me.col_pdr.DataPropertyName = "InternoCodigoPadre"
            Me.col_pdr.HeaderText = "InternoCodigoPadre"
            Me.col_pdr.Name = "col_pdr"
            Me.col_pdr.ReadOnly = True
            Me.col_pdr.Visible = False
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "InternoCodigo"
            Me.Column3.HeaderText = "Codigo"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 75
            '
            'Column1
            '
            Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column1.DataPropertyName = "InternoApellidosReadonly"
            Me.Column1.HeaderText = "Apellidos"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "InternoNombres"
            Me.Column2.HeaderText = "Nombres"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 150
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "InternoSitJuridica"
            Me.Column4.HeaderText = "Sit. Juridica"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Visible = False
            Me.Column4.Width = 120
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "InternoEstadoNom"
            Me.Column5.HeaderText = "Estado"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 65
            '
            'grbMovimiento
            '
            Me.grbMovimiento.Controls.Add(Me.UscRegionPenalLabel1)
            Me.grbMovimiento.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grbMovimiento.Name = "grbMovimiento"
            Me.grbMovimiento.Size = New System.Drawing.Size(650, 40)
            Me.grbMovimiento.TabIndex = 17
            Me.grbMovimiento.TabStop = False
            '
            'UscRegionPenalLabel1
            '
            Me.UscRegionPenalLabel1._Penalid = -1
            Me.UscRegionPenalLabel1._PenalNombre = "************"
            Me.UscRegionPenalLabel1._RegionId = -1
            Me.UscRegionPenalLabel1._RegionNombre = "************"
            Me.UscRegionPenalLabel1._WidthRegion = 250
            Me.UscRegionPenalLabel1.BackColor = System.Drawing.Color.Transparent
            Me.UscRegionPenalLabel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscRegionPenalLabel1.Location = New System.Drawing.Point(3, 16)
            Me.UscRegionPenalLabel1.Margin = New System.Windows.Forms.Padding(1)
            Me.UscRegionPenalLabel1.Name = "UscRegionPenalLabel1"
            Me.UscRegionPenalLabel1.Size = New System.Drawing.Size(644, 21)
            Me.UscRegionPenalLabel1.TabIndex = 29
            Me.UscRegionPenalLabel1.UsuarioID = -1
            Me.UscRegionPenalLabel1.VersionInstalacionFile = 0
            '
            'Timer1
            '
            '
            'BackgroundWorker1
            '
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.dgwMovi)
            Me.pnlGrilla.Controls.Add(Me.Panel2)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 172)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(650, 226)
            Me.pnlGrilla.TabIndex = 47
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscFotografia_2v1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(500, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(150, 226)
            Me.Panel2.TabIndex = 47
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(150, 226)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 69
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnCancel)
            Me.Panel3.Controls.Add(Me.btnOk)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(427, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(223, 45)
            Me.Panel3.TabIndex = 107
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(115, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 40)
            Me.btnCancel.TabIndex = 102
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(6, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(105, 40)
            Me.btnOk.TabIndex = 102
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnBuscarInternosPJ)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.btnOtro)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 398)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(650, 45)
            Me.Panel1.TabIndex = 0
            '
            'btnBuscarInternosPJ
            '
            Me.btnBuscarInternosPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarInternosPJ.Image = Global.SIPPOPE.My.Resources.Resources.logo_pj
            Me.btnBuscarInternosPJ.Location = New System.Drawing.Point(315, 3)
            Me.btnBuscarInternosPJ.Name = "btnBuscarInternosPJ"
            Me.btnBuscarInternosPJ.Size = New System.Drawing.Size(106, 40)
            Me.btnBuscarInternosPJ.TabIndex = 108
            Me.btnBuscarInternosPJ.Text = "Internos"
            Me.btnBuscarInternosPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnBuscarInternosPJ.UseVisualStyleBackColor = True
            Me.btnBuscarInternosPJ.Visible = False
            '
            'frmInternoHistoricoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(650, 443)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmInternoHistoricoPopup"
            Me.Text = "Busqueda de Internos Historicos del Visitante"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grbMovimiento.ResumeLayout(False)
            Me.pnlGrilla.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnOtro As System.Windows.Forms.Button
        Friend WithEvents dgwMovi As System.Windows.Forms.DataGridView
        Friend WithEvents grbMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents UscRegionPenalLabel1 As APPControls.uscRegionPenalLabel
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtCodInterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents col_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pdr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
        Friend WithEvents btnBuscarInternosPJ As System.Windows.Forms.Button

    End Class
End Namespace

