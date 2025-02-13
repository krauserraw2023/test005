Namespace Registro.Identificacion.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmIngresoPopup3
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoPopup3))
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.ckbHistorico = New System.Windows.Forms.CheckBox()
            Me.dtpFechaIngresoISP = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtobservacion = New System.Windows.Forms.TextBox()
            Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFechaIng = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnIngreso = New System.Windows.Forms.Button()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgwIngreso = New System.Windows.Forms.DataGridView()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_isp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing_lng = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_lib_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_lib_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_lib = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblRegIngreso = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgwIngreso)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox9)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(374, 399)
            '
            'GroupBox9
            '
            Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox9.Controls.Add(Me.ckbHistorico)
            Me.GroupBox9.Controls.Add(Me.dtpFechaIngresoISP)
            Me.GroupBox9.Controls.Add(Me.Label4)
            Me.GroupBox9.Controls.Add(Me.Label3)
            Me.GroupBox9.Controls.Add(Me.txtobservacion)
            Me.GroupBox9.Controls.Add(Me.NumericUpDown1)
            Me.GroupBox9.Controls.Add(Me.Label2)
            Me.GroupBox9.Controls.Add(Me.dtpFechaIng)
            Me.GroupBox9.Controls.Add(Me.Label33)
            Me.GroupBox9.Location = New System.Drawing.Point(0, 146)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(374, 157)
            Me.GroupBox9.TabIndex = 2
            Me.GroupBox9.TabStop = False
            '
            'ckbHistorico
            '
            Me.ckbHistorico.AutoSize = True
            Me.ckbHistorico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbHistorico.Location = New System.Drawing.Point(266, 69)
            Me.ckbHistorico.Name = "ckbHistorico"
            Me.ckbHistorico.Size = New System.Drawing.Size(103, 17)
            Me.ckbHistorico.TabIndex = 6
            Me.ckbHistorico.Text = "Ingreso historico"
            Me.ckbHistorico.UseVisualStyleBackColor = True
            Me.ckbHistorico.Visible = False
            '
            'dtpFechaIngresoISP
            '
            Me.dtpFechaIngresoISP.Location = New System.Drawing.Point(158, 42)
            Me.dtpFechaIngresoISP.Name = "dtpFechaIngresoISP"
            Me.dtpFechaIngresoISP.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIngresoISP.TabIndex = 3
            Me.dtpFechaIngresoISP.Value = "/  /"
            Me.dtpFechaIngresoISP.ValueLong = CType(0, Long)
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(5, 45)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(153, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Fec. Ing. al Sist. Penitenciario :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(4, 93)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(73, 13)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Observación :"
            '
            'txtobservacion
            '
            Me.txtobservacion.Location = New System.Drawing.Point(158, 96)
            Me.txtobservacion.MaxLength = 500
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobservacion.Size = New System.Drawing.Size(213, 57)
            Me.txtobservacion.TabIndex = 8
            '
            'NumericUpDown1
            '
            Me.NumericUpDown1.Location = New System.Drawing.Point(158, 17)
            Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
            Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.NumericUpDown1.Name = "NumericUpDown1"
            Me.NumericUpDown1.Size = New System.Drawing.Size(84, 20)
            Me.NumericUpDown1.TabIndex = 1
            Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(4, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "N° Ingreso :"
            '
            'dtpFechaIng
            '
            Me.dtpFechaIng.Location = New System.Drawing.Point(158, 67)
            Me.dtpFechaIng.Name = "dtpFechaIng"
            Me.dtpFechaIng.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIng.TabIndex = 5
            Me.dtpFechaIng.Value = "/  /"
            Me.dtpFechaIng.ValueLong = CType(0, Long)
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Location = New System.Drawing.Point(4, 70)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(115, 13)
            Me.Label33.TabIndex = 4
            Me.Label33.Text = "Fecha Ingreso al E.P. :"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.pnlGrabar)
            Me.Panel1.Controls.Add(Me.pnlEliminar)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Location = New System.Drawing.Point(0, 312)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(374, 45)
            Me.Panel1.TabIndex = 3
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnIngreso)
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(19, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(183, 45)
            Me.pnlGrabar.TabIndex = 0
            '
            'btnIngreso
            '
            Me.btnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnIngreso.Image = CType(resources.GetObject("btnIngreso.Image"), System.Drawing.Image)
            Me.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnIngreso.Location = New System.Drawing.Point(1, 2)
            Me.btnIngreso.Name = "btnIngreso"
            Me.btnIngreso.Size = New System.Drawing.Size(90, 40)
            Me.btnIngreso.TabIndex = 0
            Me.btnIngreso.Text = "Nuevo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            Me.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnIngreso.UseVisualStyleBackColor = True
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
            Me.btnGrabar.Location = New System.Drawing.Point(92, 2)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(90, 40)
            Me.btnGrabar.TabIndex = 1
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(202, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(86, 45)
            Me.pnlEliminar.TabIndex = 1
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(1, 2)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(83, 40)
            Me.btnEliminar.TabIndex = 0
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(288, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(86, 45)
            Me.Panel2.TabIndex = 2
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(1, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(84, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dgwIngreso
            '
            Me.dgwIngreso.AllowUserToAddRows = False
            Me.dgwIngreso.AllowUserToDeleteRows = False
            Me.dgwIngreso.BackgroundColor = System.Drawing.Color.White
            Me.dgwIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ing_id, Me.Column15, Me.col_ing_nro, Me.Column6, Me.col_fec_doc, Me.Column3, Me.col_fec_isp, Me.col_fec_ing_lng, Me.DataGridViewTextBoxColumn11, Me.Column11, Me.col_lib_id, Me.col_tip_lib_nom, Me.Column12, Me.col_fec_lib})
            Me.dgwIngreso.GridColor = System.Drawing.Color.LightGray
            Me.dgwIngreso.Location = New System.Drawing.Point(1, 32)
            Me.dgwIngreso.MultiSelect = False
            Me.dgwIngreso.Name = "dgwIngreso"
            Me.dgwIngreso.ReadOnly = True
            Me.dgwIngreso.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwIngreso.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwIngreso.Size = New System.Drawing.Size(370, 115)
            Me.dgwIngreso.TabIndex = 1
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "Codigo"
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            Me.col_ing_id.Width = 30
            '
            'Column15
            '
            Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column15.DataPropertyName = "LibertadIcon"
            Me.Column15.HeaderText = ""
            Me.Column15.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            Me.Column15.Width = 23
            '
            'col_ing_nro
            '
            Me.col_ing_nro.DataPropertyName = "IngresoNro"
            Me.col_ing_nro.HeaderText = "Nro Ing."
            Me.col_ing_nro.Name = "col_ing_nro"
            Me.col_ing_nro.ReadOnly = True
            Me.col_ing_nro.Width = 68
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "DocumentoIngreso"
            Me.Column6.HeaderText = "Documento"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Visible = False
            Me.Column6.Width = 200
            '
            'col_fec_doc
            '
            Me.col_fec_doc.DataPropertyName = "DocumentoIngresoFechaDate"
            Me.col_fec_doc.HeaderText = "Fecha Doc."
            Me.col_fec_doc.Name = "col_fec_doc"
            Me.col_fec_doc.ReadOnly = True
            Me.col_fec_doc.Visible = False
            Me.col_fec_doc.Width = 90
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column3.DataPropertyName = "MotivoIngresoNombre"
            Me.Column3.HeaderText = "Motivo"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Visible = False
            '
            'col_fec_isp
            '
            Me.col_fec_isp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_fec_isp.DataPropertyName = "FechaISPDate"
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.col_fec_isp.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_isp.HeaderText = "F. Ing. Sist. Pen."
            Me.col_fec_isp.Name = "col_fec_isp"
            Me.col_fec_isp.ReadOnly = True
            Me.col_fec_isp.Width = 110
            '
            'col_fec_ing_lng
            '
            Me.col_fec_ing_lng.DataPropertyName = "FechaIngreso"
            Me.col_fec_ing_lng.HeaderText = "Fecha Ingreso Long"
            Me.col_fec_ing_lng.Name = "col_fec_ing_lng"
            Me.col_fec_ing_lng.ReadOnly = True
            Me.col_fec_ing_lng.Visible = False
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "FechaIngresoDate"
            Me.DataGridViewTextBoxColumn11.HeaderText = "F. Ing. al E.P."
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            Me.DataGridViewTextBoxColumn11.Width = 94
            '
            'Column11
            '
            Me.Column11.DataPropertyName = "DocumentoLibertad"
            Me.Column11.HeaderText = "Doc. Libertad"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.Visible = False
            '
            'col_lib_id
            '
            Me.col_lib_id.HeaderText = "LibertadID"
            Me.col_lib_id.Name = "col_lib_id"
            Me.col_lib_id.ReadOnly = True
            Me.col_lib_id.Visible = False
            '
            'col_tip_lib_nom
            '
            Me.col_tip_lib_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_tip_lib_nom.DataPropertyName = "LibertadTipoNombre"
            Me.col_tip_lib_nom.HeaderText = "Tipo Libertad"
            Me.col_tip_lib_nom.Name = "col_tip_lib_nom"
            Me.col_tip_lib_nom.ReadOnly = True
            Me.col_tip_lib_nom.Visible = False
            '
            'Column12
            '
            Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column12.DataPropertyName = "FechaLibertadDate"
            Me.Column12.DividerWidth = 1
            Me.Column12.HeaderText = "F. Egre."
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            '
            'col_fec_lib
            '
            Me.col_fec_lib.DataPropertyName = "FechaLibertad"
            Me.col_fec_lib.HeaderText = "FechaLibertad"
            Me.col_fec_lib.Name = "col_fec_lib"
            Me.col_fec_lib.ReadOnly = True
            Me.col_fec_lib.Visible = False
            '
            'lblRegIngreso
            '
            Me.lblRegIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegIngreso.Location = New System.Drawing.Point(3, 10)
            Me.lblRegIngreso.Name = "lblRegIngreso"
            Me.lblRegIngreso.Size = New System.Drawing.Size(74, 13)
            Me.lblRegIngreso.TabIndex = 0
            Me.lblRegIngreso.Text = "0 Reg."
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.lblRegIngreso)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(374, 32)
            Me.Panel3.TabIndex = 0
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 357)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(374, 42)
            Me.UscAuditUser1.TabIndex = 4
            '
            'frmIngresoPopup3
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(374, 399)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmIngresoPopup3"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Ingreso(s) del Interno"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaIng As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
        Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents dtpFechaIngresoISP As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents dgwIngreso As System.Windows.Forms.DataGridView
        Friend WithEvents lblRegIngreso As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnIngreso As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column15 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_ing_nro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_isp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing_lng As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_lib_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_lib_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_lib As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ckbHistorico As CheckBox
    End Class

End Namespace