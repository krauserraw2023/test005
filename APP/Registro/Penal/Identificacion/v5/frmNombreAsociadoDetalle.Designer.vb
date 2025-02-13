Namespace Registro


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmNombreAsociadoDetalle
        Inherits Legolas.APPUIComponents.FormPopup


        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwNombreAsoc = New System.Windows.Forms.DataGridView()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_prin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_doc_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblInterno = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.ckbSeleccion = New System.Windows.Forms.CheckBox()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.dgwNombreAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.ckbSeleccion)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.dgwNombreAsoc)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(532, 288)
            '
            'dgwNombreAsoc
            '
            Me.dgwNombreAsoc.AllowUserToAddRows = False
            Me.dgwNombreAsoc.AllowUserToDeleteRows = False
            Me.dgwNombreAsoc.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwNombreAsoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwNombreAsoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwNombreAsoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel, Me.col_nom_aso_id, Me.col_int_id, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_est, Me.col_prin, Me.col_doc_nom_aso_id, Me.col_doc_jud_id})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwNombreAsoc.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwNombreAsoc.GridColor = System.Drawing.Color.LightGray
            Me.dgwNombreAsoc.Location = New System.Drawing.Point(0, 27)
            Me.dgwNombreAsoc.MultiSelect = False
            Me.dgwNombreAsoc.Name = "dgwNombreAsoc"
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwNombreAsoc.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwNombreAsoc.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwNombreAsoc.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwNombreAsoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwNombreAsoc.Size = New System.Drawing.Size(531, 209)
            Me.dgwNombreAsoc.TabIndex = 2
            '
            'col_sel
            '
            Me.col_sel.FalseValue = "0"
            Me.col_sel.HeaderText = ""
            Me.col_sel.Name = "col_sel"
            Me.col_sel.TrueValue = "1"
            Me.col_sel.Width = 30
            '
            'col_nom_aso_id
            '
            Me.col_nom_aso_id.DataPropertyName = "Codigo"
            Me.col_nom_aso_id.HeaderText = "NombreAsociadoID"
            Me.col_nom_aso_id.Name = "col_nom_aso_id"
            Me.col_nom_aso_id.Visible = False
            Me.col_nom_aso_id.Width = 35
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.Visible = False
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.HeaderText = "Primer Apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.Width = 140
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.Width = 140
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.Width = 140
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.HeaderText = "Estado"
            Me.col_est.Name = "col_est"
            Me.col_est.Visible = False
            '
            'col_prin
            '
            Me.col_prin.DataPropertyName = "Principal"
            Me.col_prin.HeaderText = "Principal"
            Me.col_prin.Name = "col_prin"
            Me.col_prin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_prin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_prin.Width = 48
            '
            'col_doc_nom_aso_id
            '
            Me.col_doc_nom_aso_id.DataPropertyName = "DocumentoNombreAsociadoID"
            Me.col_doc_nom_aso_id.HeaderText = "DocNombreAsociadoID"
            Me.col_doc_nom_aso_id.Name = "col_doc_nom_aso_id"
            Me.col_doc_nom_aso_id.Visible = False
            Me.col_doc_nom_aso_id.Width = 30
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "DocumentoJudicialID"
            Me.col_doc_jud_id.HeaderText = "DocJudicial"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 30
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblInterno)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(532, 27)
            Me.Panel1.TabIndex = 0
            '
            'lblInterno
            '
            Me.lblInterno.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblInterno.Location = New System.Drawing.Point(58, 0)
            Me.lblInterno.Name = "lblInterno"
            Me.lblInterno.Size = New System.Drawing.Size(474, 27)
            Me.lblInterno.TabIndex = 1
            Me.lblInterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 27)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Interno :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel6)
            Me.Panel2.Controls.Add(Me.lblNroExpedientes)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 242)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(532, 46)
            Me.Panel2.TabIndex = 93
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnCancel)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(422, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(110, 46)
            Me.Panel6.TabIndex = 90
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(7, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblNroExpedientes
            '
            Me.lblNroExpedientes.AutoSize = True
            Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroExpedientes.Location = New System.Drawing.Point(5, 6)
            Me.lblNroExpedientes.Name = "lblNroExpedientes"
            Me.lblNroExpedientes.Size = New System.Drawing.Size(146, 13)
            Me.lblNroExpedientes.TabIndex = 83
            Me.lblNroExpedientes.Text = "Nro de nombres : 0 Reg."
            '
            'ckbSeleccion
            '
            Me.ckbSeleccion.AutoSize = True
            Me.ckbSeleccion.Location = New System.Drawing.Point(9, 31)
            Me.ckbSeleccion.Name = "ckbSeleccion"
            Me.ckbSeleccion.Size = New System.Drawing.Size(15, 14)
            Me.ckbSeleccion.TabIndex = 94
            Me.ckbSeleccion.UseVisualStyleBackColor = True
            '
            'frmNombreAsociadoDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(532, 288)
            Me.Name = "frmNombreAsociadoDetalle"
            Me.Text = "Nombres Asociados"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            CType(Me.dgwNombreAsoc, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwNombreAsoc As System.Windows.Forms.DataGridView
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblInterno As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents ckbSeleccion As System.Windows.Forms.CheckBox
        Friend WithEvents col_sel As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_nom_aso_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_prin As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_doc_nom_aso_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace