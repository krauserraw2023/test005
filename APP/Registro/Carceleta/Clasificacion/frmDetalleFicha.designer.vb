Namespace Registro.Carceleta.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmDetalleFicha
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.dgvValores = New System.Windows.Forms.DataGridView()
            Me.col_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_var_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_ptje = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje_proc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje_sen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.chNoPrev = New System.Windows.Forms.CheckBox()
            Me.txtPtje = New System.Windows.Forms.Label()
            Me.txtPtjeNoPrevisto = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.btnVerDetalle = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            CType(Me.dgvValores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgvValores)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(873, 467)
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Button1)
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 425)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(873, 42)
            Me.Panel2.TabIndex = 2
            '
            'Button1
            '
            Me.Button1.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.view
            Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Button1.Location = New System.Drawing.Point(632, 0)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(44, 40)
            Me.Button1.TabIndex = 3
            Me.ToolTip1.SetToolTip(Me.Button1, "Ver a pantalla completa")
            Me.Button1.UseVisualStyleBackColor = True
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Controls.Add(Me.btnOK)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(676, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(195, 40)
            Me.pnlGrabarDatos.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(96, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(2, 1)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgvValores
            '
            Me.dgvValores.AllowUserToAddRows = False
            Me.dgvValores.AllowUserToDeleteRows = False
            Me.dgvValores.AllowUserToResizeColumns = False
            Me.dgvValores.AllowUserToResizeRows = False
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvValores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvValores.BackgroundColor = System.Drawing.Color.White
            Me.dgvValores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvValores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvValores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fic_id, Me.col_codigo, Me.col_num, Me.col_var_id, Me.col_est, Me.col_desc, Me.col_check, Me.col_ptje, Me.col_ptje_proc, Me.col_ptje_sen})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvValores.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvValores.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvValores.GridColor = System.Drawing.Color.SkyBlue
            Me.dgvValores.Location = New System.Drawing.Point(0, 0)
            Me.dgvValores.MultiSelect = False
            Me.dgvValores.Name = "dgvValores"
            Me.dgvValores.ReadOnly = True
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvValores.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(114, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
            Me.dgvValores.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvValores.RowTemplate.Height = 28
            Me.dgvValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvValores.Size = New System.Drawing.Size(873, 399)
            Me.dgvValores.TabIndex = 7
            '
            'col_fic_id
            '
            Me.col_fic_id.DataPropertyName = "FichaId"
            Me.col_fic_id.HeaderText = "FichaId"
            Me.col_fic_id.Name = "col_fic_id"
            Me.col_fic_id.ReadOnly = True
            Me.col_fic_id.Visible = False
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'col_num
            '
            Me.col_num.DataPropertyName = "SecuenciaString"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
            Me.col_num.DefaultCellStyle = DataGridViewCellStyle3
            Me.col_num.HeaderText = "Nro"
            Me.col_num.Name = "col_num"
            Me.col_num.ReadOnly = True
            Me.col_num.Visible = False
            Me.col_num.Width = 40
            '
            'col_var_id
            '
            Me.col_var_id.DataPropertyName = "VariableId"
            Me.col_var_id.HeaderText = "VariableId"
            Me.col_var_id.Name = "col_var_id"
            Me.col_var_id.ReadOnly = True
            Me.col_var_id.Visible = False
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.HeaderText = "Estado"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
            '
            'col_desc
            '
            Me.col_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_desc.DataPropertyName = "Descripcion"
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_desc.DefaultCellStyle = DataGridViewCellStyle4
            Me.col_desc.HeaderText = "Descripción"
            Me.col_desc.Name = "col_desc"
            Me.col_desc.ReadOnly = True
            '
            'col_check
            '
            Me.col_check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            DataGridViewCellStyle5.NullValue = False
            Me.col_check.DefaultCellStyle = DataGridViewCellStyle5
            Me.col_check.HeaderText = ""
            Me.col_check.Name = "col_check"
            Me.col_check.ReadOnly = True
            Me.col_check.Visible = False
            '
            'col_ptje
            '
            Me.col_ptje.DataPropertyName = "Puntaje"
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.col_ptje.DefaultCellStyle = DataGridViewCellStyle6
            Me.col_ptje.HeaderText = "Ptj."
            Me.col_ptje.Name = "col_ptje"
            Me.col_ptje.ReadOnly = True
            Me.col_ptje.Width = 30
            '
            'col_ptje_proc
            '
            Me.col_ptje_proc.DataPropertyName = "PuntajeProcesado"
            Me.col_ptje_proc.HeaderText = "Ptj. Proc."
            Me.col_ptje_proc.Name = "col_ptje_proc"
            Me.col_ptje_proc.ReadOnly = True
            Me.col_ptje_proc.Width = 50
            '
            'col_ptje_sen
            '
            Me.col_ptje_sen.DataPropertyName = "PuntajeSentenciado"
            Me.col_ptje_sen.HeaderText = "Ptj. Sent."
            Me.col_ptje_sen.Name = "col_ptje_sen"
            Me.col_ptje_sen.ReadOnly = True
            Me.col_ptje_sen.Width = 50
            '
            'chNoPrev
            '
            Me.chNoPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chNoPrev.AutoSize = True
            Me.chNoPrev.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chNoPrev.Location = New System.Drawing.Point(644, 4)
            Me.chNoPrev.Name = "chNoPrev"
            Me.chNoPrev.Size = New System.Drawing.Size(119, 17)
            Me.chNoPrev.TabIndex = 10
            Me.chNoPrev.Text = "Variable no previsto"
            Me.chNoPrev.UseVisualStyleBackColor = True
            '
            'txtPtje
            '
            Me.txtPtje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPtje.BackColor = System.Drawing.Color.White
            Me.txtPtje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPtje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPtje.Location = New System.Drawing.Point(821, 1)
            Me.txtPtje.Name = "txtPtje"
            Me.txtPtje.Size = New System.Drawing.Size(51, 26)
            Me.txtPtje.TabIndex = 12
            Me.txtPtje.Text = "0"
            Me.txtPtje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPtjeNoPrevisto
            '
            Me.txtPtjeNoPrevisto._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPtjeNoPrevisto._BloquearPaste = False
            Me.txtPtjeNoPrevisto._SeleccionarTodo = False
            Me.txtPtjeNoPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPtjeNoPrevisto.BackColor = System.Drawing.Color.LightGray
            Me.txtPtjeNoPrevisto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPtjeNoPrevisto.Enabled = False
            Me.txtPtjeNoPrevisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPtjeNoPrevisto.Location = New System.Drawing.Point(770, 1)
            Me.txtPtjeNoPrevisto.MaxLength = 2
            Me.txtPtjeNoPrevisto.Name = "txtPtjeNoPrevisto"
            Me.txtPtjeNoPrevisto.Size = New System.Drawing.Size(51, 26)
            Me.txtPtjeNoPrevisto.TabIndex = 13
            Me.txtPtjeNoPrevisto.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPtjeNoPrevisto.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'btnVerDetalle
            '
            Me.btnVerDetalle.Location = New System.Drawing.Point(1, 0)
            Me.btnVerDetalle.Name = "btnVerDetalle"
            Me.btnVerDetalle.Size = New System.Drawing.Size(71, 26)
            Me.btnVerDetalle.TabIndex = 14
            Me.btnVerDetalle.Text = "Detalle ..."
            Me.btnVerDetalle.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnVerDetalle)
            Me.Panel1.Controls.Add(Me.txtPtjeNoPrevisto)
            Me.Panel1.Controls.Add(Me.txtPtje)
            Me.Panel1.Controls.Add(Me.chNoPrev)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 399)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(873, 26)
            Me.Panel1.TabIndex = 6
            '
            'frmDetalleFicha
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(873, 467)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
            Me.MaximizeBox = True
            Me.Name = "frmDetalleFicha"
            Me.Text = "Seleccione indicador"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            CType(Me.dgvValores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents dgvValores As System.Windows.Forms.DataGridView
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents col_fic_id As DataGridViewTextBoxColumn
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_num As DataGridViewTextBoxColumn
        Friend WithEvents col_var_id As DataGridViewTextBoxColumn
        Friend WithEvents col_est As DataGridViewTextBoxColumn
        Friend WithEvents col_desc As DataGridViewTextBoxColumn
        Friend WithEvents col_check As DataGridViewCheckBoxColumn
        Friend WithEvents col_ptje As DataGridViewTextBoxColumn
        Friend WithEvents col_ptje_proc As DataGridViewTextBoxColumn
        Friend WithEvents col_ptje_sen As DataGridViewTextBoxColumn
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnVerDetalle As Button
        Friend WithEvents txtPtjeNoPrevisto As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPtje As Label
        Friend WithEvents chNoPrev As CheckBox
    End Class
End Namespace