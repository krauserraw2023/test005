Namespace Registro.Identificacion.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmSeleccionarIngresoPopup
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlAddExpediente = New System.Windows.Forms.Panel()
            Me.lblRegIngreso = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.gbrIngreso = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_isp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing_lng = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_lib_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_anulacion = New System.Windows.Forms.DataGridViewImageColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlAddExpediente.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.gbrIngreso.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.gbrIngreso)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlAddExpediente)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(335, 206)
            '
            'pnlAddExpediente
            '
            Me.pnlAddExpediente.Controls.Add(Me.lblRegIngreso)
            Me.pnlAddExpediente.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAddExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlAddExpediente.Name = "pnlAddExpediente"
            Me.pnlAddExpediente.Size = New System.Drawing.Size(335, 29)
            Me.pnlAddExpediente.TabIndex = 56
            '
            'lblRegIngreso
            '
            Me.lblRegIngreso.AutoSize = True
            Me.lblRegIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegIngreso.Location = New System.Drawing.Point(3, 7)
            Me.lblRegIngreso.Name = "lblRegIngreso"
            Me.lblRegIngreso.Size = New System.Drawing.Size(290, 13)
            Me.lblRegIngreso.TabIndex = 62
            Me.lblRegIngreso.Text = "Seleccione el Ingreso para regularizar el registro :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOk)
            Me.Panel1.Controls.Add(Me.lblReg)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 154)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(335, 52)
            Me.Panel1.TabIndex = 57
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(228, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 90
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(128, 5)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 89
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblReg
            '
            Me.lblReg.AutoSize = True
            Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReg.Location = New System.Drawing.Point(3, 19)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(45, 13)
            Me.lblReg.TabIndex = 60
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.Visible = False
            '
            'gbrIngreso
            '
            Me.gbrIngreso.Controls.Add(Me.dgwGrilla)
            Me.gbrIngreso.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbrIngreso.Location = New System.Drawing.Point(0, 29)
            Me.gbrIngreso.Name = "gbrIngreso"
            Me.gbrIngreso.Size = New System.Drawing.Size(335, 120)
            Me.gbrIngreso.TabIndex = 58
            Me.gbrIngreso.TabStop = False
            Me.gbrIngreso.Text = "Ingreso"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ing_id, Me.Column15, Me.Column13, Me.Column6, Me.col_fec_doc, Me.Column3, Me.col_fec_isp, Me.col_fec_ing_lng, Me.DataGridViewTextBoxColumn11, Me.Column11, Me.col_tip_lib_nom, Me.Column12, Me.col_ing_anulacion})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(329, 101)
            Me.dgwGrilla.TabIndex = 0
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
            Me.Column15.DataPropertyName = "LibertadIcon"
            Me.Column15.HeaderText = ""
            Me.Column15.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            Me.Column15.Width = 25
            '
            'Column13
            '
            Me.Column13.DataPropertyName = "IngresoNro"
            Me.Column13.HeaderText = "Nro Ing."
            Me.Column13.Name = "Column13"
            Me.Column13.ReadOnly = True
            Me.Column13.Width = 70
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
            Me.col_fec_isp.DataPropertyName = "FechaISP"
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.col_fec_isp.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_isp.HeaderText = "Fec. Ing. Sist. Pen."
            Me.col_fec_isp.Name = "col_fec_isp"
            Me.col_fec_isp.ReadOnly = True
            Me.col_fec_isp.Width = 120
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
            Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "FechaIngresoDate"
            Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha Ing."
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            '
            'Column11
            '
            Me.Column11.DataPropertyName = "DocumentoLibertad"
            Me.Column11.HeaderText = "Doc. Libertad"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.Visible = False
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
            Me.Column12.DataPropertyName = "FechaLibertadDate"
            Me.Column12.HeaderText = "Fecha Egre."
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            Me.Column12.Visible = False
            Me.Column12.Width = 90
            '
            'col_ing_anulacion
            '
            Me.col_ing_anulacion.DataPropertyName = "EstadoImage"
            Me.col_ing_anulacion.HeaderText = "Anul."
            Me.col_ing_anulacion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_ing_anulacion.Name = "col_ing_anulacion"
            Me.col_ing_anulacion.ReadOnly = True
            Me.col_ing_anulacion.Visible = False
            Me.col_ing_anulacion.Width = 30
            '
            'frmSeleccionarIngresoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(335, 206)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmSeleccionarIngresoPopup"
            Me.Text = "Selección Ingreso"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlAddExpediente.ResumeLayout(False)
            Me.pnlAddExpediente.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.gbrIngreso.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlAddExpediente As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents lblRegIngreso As System.Windows.Forms.Label
        Friend WithEvents gbrIngreso As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column15 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_isp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing_lng As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_lib_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_anulacion As System.Windows.Forms.DataGridViewImageColumn
    End Class
End Namespace

