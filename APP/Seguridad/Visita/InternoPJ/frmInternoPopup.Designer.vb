Namespace Visita.InternoPJ
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInternoPopup
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternoPopup))
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtApe = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.cbbTipoDocumento = New APPControls.uscComboParametrica()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.btnOtro = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.gbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.UscRegionPenalLabel1 = New APPControls.uscRegionPenalLabel()
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox8.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.gbRegionPenal.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.gbRegionPenal)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(650, 443)
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_num_doc, Me.col_ape, Me.col_nom, Me.Column1})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(650, 224)
            Me.dgwGrilla.TabIndex = 39
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.DividerWidth = 1
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 75
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "TipoDocyNumDocReadonly"
            Me.col_num_doc.HeaderText = "Tipo y Num. Doc."
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            Me.col_num_doc.Width = 120
            '
            'col_ape
            '
            Me.col_ape.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ape.DataPropertyName = "ApellidosReadonly"
            Me.col_ape.HeaderText = "Apellidos"
            Me.col_ape.Name = "col_ape"
            Me.col_ape.ReadOnly = True
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "PreNombres"
            Me.col_nom.HeaderText = "PreNombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 150
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "Pabellon"
            Me.Column1.HeaderText = "Pabellon"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.txtNom)
            Me.GroupBox8.Controls.Add(Me.Label5)
            Me.GroupBox8.Controls.Add(Me.txtNumDoc)
            Me.GroupBox8.Controls.Add(Me.Label4)
            Me.GroupBox8.Controls.Add(Me.Label3)
            Me.GroupBox8.Controls.Add(Me.txtApe)
            Me.GroupBox8.Controls.Add(Me.Label1)
            Me.GroupBox8.Controls.Add(Me.Label26)
            Me.GroupBox8.Controls.Add(Me.cbbTipoDocumento)
            Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(567, 134)
            Me.GroupBox8.TabIndex = 61
            Me.GroupBox8.TabStop = False
            '
            'txtNom
            '
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(113, 66)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(377, 20)
            Me.txtNom.TabIndex = 28
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Red
            Me.Label5.Location = New System.Drawing.Point(3, 99)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(561, 32)
            Me.Label5.TabIndex = 43
            Me.Label5.Text = "Seleccione el registro, luego haga doble click , o haga click en el boton [Acepta" & _
        "r]"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(374, 14)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(115, 20)
            Me.txtNumDoc.TabIndex = 37
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(273, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(76, 13)
            Me.Label4.TabIndex = 35
            Me.Label4.Text = "Numero Doc. :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 71)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombres :"
            '
            'txtApe
            '
            Me.txtApe._BloquearPaste = False
            Me.txtApe._SeleccionarTodo = False
            Me.txtApe.Location = New System.Drawing.Point(113, 41)
            Me.txtApe.Name = "txtApe"
            Me.txtApe.Size = New System.Drawing.Size(377, 20)
            Me.txtApe.TabIndex = 0
            Me.txtApe.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApe.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 44)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Apellidos :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(9, 17)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(92, 13)
            Me.Label26.TabIndex = 33
            Me.Label26.Text = "Tipo Documento: "
            '
            'cbbTipoDocumento
            '
            Me.cbbTipoDocumento._NoIndica = False
            Me.cbbTipoDocumento._Todos = False
            Me.cbbTipoDocumento._TodosMensaje = ""
            Me.cbbTipoDocumento._Visible_Add = False
            Me.cbbTipoDocumento._Visible_Buscar = False
            Me.cbbTipoDocumento._Visible_Eliminar = False
            Me.cbbTipoDocumento.CodigoPadre = -1
            Me.cbbTipoDocumento.ComboTipo = Type.Combo.ComboTipo.PenalPabellon
            Me.cbbTipoDocumento.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDocumento.DropDownWidth = 143
            Me.cbbTipoDocumento.DropDownWidthAuto = False
            Me.cbbTipoDocumento.Location = New System.Drawing.Point(113, 14)
            Me.cbbTipoDocumento.Name = "cbbTipoDocumento"
            Me.cbbTipoDocumento.Parametro1 = -1
            Me.cbbTipoDocumento.Parametro2 = -1
            Me.cbbTipoDocumento.SelectedIndex = -1
            Me.cbbTipoDocumento.SelectedValue = 0
            Me.cbbTipoDocumento.Size = New System.Drawing.Size(111, 22)
            Me.cbbTipoDocumento.TabIndex = 109
            '
            'grbBuscar
            '
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(567, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(83, 134)
            Me.grbBuscar.TabIndex = 62
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 109)
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 115)
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
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.GroupBox8)
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 40)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(650, 134)
            Me.Panel1.TabIndex = 63
            '
            'Timer1
            '
            '
            'BackgroundWorker1
            '
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel4)
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 398)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(650, 45)
            Me.Panel2.TabIndex = 64
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnAgregar)
            Me.Panel4.Controls.Add(Me.btnOtro)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(427, 45)
            Me.Panel4.TabIndex = 107
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAgregar.Location = New System.Drawing.Point(321, 3)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(100, 40)
            Me.btnAgregar.TabIndex = 108
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'btnOtro
            '
            Me.btnOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOtro.Image = Global.SIPPOPE.My.Resources.Resources.Camembert_32
            Me.btnOtro.Location = New System.Drawing.Point(7, 3)
            Me.btnOtro.Name = "btnOtro"
            Me.btnOtro.Size = New System.Drawing.Size(130, 40)
            Me.btnOtro.TabIndex = 107
            Me.btnOtro.Text = "Poblacion Penal"
            Me.btnOtro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOtro.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnCancel)
            Me.Panel3.Controls.Add(Me.btnAceptar)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(427, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(223, 45)
            Me.Panel3.TabIndex = 106
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(115, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 40)
            Me.btnCancel.TabIndex = 104
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(6, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(105, 40)
            Me.btnAceptar.TabIndex = 103
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'gbRegionPenal
            '
            Me.gbRegionPenal.Controls.Add(Me.UscRegionPenalLabel1)
            Me.gbRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbRegionPenal.Location = New System.Drawing.Point(0, 0)
            Me.gbRegionPenal.Name = "gbRegionPenal"
            Me.gbRegionPenal.Size = New System.Drawing.Size(650, 40)
            Me.gbRegionPenal.TabIndex = 65
            Me.gbRegionPenal.TabStop = False
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
            Me.UscRegionPenalLabel1.TabIndex = 63
            Me.UscRegionPenalLabel1.UsuarioID = -1
            Me.UscRegionPenalLabel1.VersionInstalacionFile = 0
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.dgwGrilla)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 174)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(650, 224)
            Me.pnlGrilla.TabIndex = 66
            '
            'frmInternoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(650, 443)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmInternoPopup"
            Me.Text = "Busqueda de Poblacion del Poder Judicial"
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.gbRegionPenal.ResumeLayout(False)
            Me.pnlGrilla.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtApe As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents UscRegionPenalLabel1 As APPControls.uscRegionPenalLabel
        Public WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
        Friend WithEvents gbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnOtro As System.Windows.Forms.Button
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents cbbTipoDocumento As APPControls.uscComboParametrica
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace

