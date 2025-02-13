Namespace Registro
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscGrillaNombresAsociadosV2
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.pnlAddNombreAsoc = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModNombreAsoc = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.rdbActivos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbTodos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbAnulados = New Legolas.APPUIComponents.myRadioButton()
            Me.pnlAnular = New System.Windows.Forms.Panel()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_aso_pri = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_exist = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAddNombreAsoc.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlAnular.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_id, Me.col_nro, Me.col_id, Me.col_int_id, Me.col_chk, Me.col_ing_nro, Me.col_ing_nro_inpe, Me.Column2, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_nom_aso_pri, Me.col_est_id, Me.Column1, Me.col_ing_id, Me.col_doc_nom_aso_id, Me.col_doc_jud_id, Me.col_doc_exist})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 46)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(759, 256)
            Me.dgwGrilla.TabIndex = 3
            '
            'pnlAddNombreAsoc
            '
            Me.pnlAddNombreAsoc.Controls.Add(Me.Panel3)
            Me.pnlAddNombreAsoc.Controls.Add(Me.Panel2)
            Me.pnlAddNombreAsoc.Controls.Add(Me.pnlAnular)
            Me.pnlAddNombreAsoc.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAddNombreAsoc.Location = New System.Drawing.Point(0, 0)
            Me.pnlAddNombreAsoc.Name = "pnlAddNombreAsoc"
            Me.pnlAddNombreAsoc.Size = New System.Drawing.Size(759, 46)
            Me.pnlAddNombreAsoc.TabIndex = 4
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnNuevo)
            Me.Panel3.Controls.Add(Me.btnModNombreAsoc)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(447, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(205, 46)
            Me.Panel3.TabIndex = 93
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnNuevo.Location = New System.Drawing.Point(2, 3)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(100, 40)
            Me.btnNuevo.TabIndex = 91
            Me.btnNuevo.Text = "Agregar "
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnModNombreAsoc
            '
            Me.btnModNombreAsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModNombreAsoc.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModNombreAsoc.Location = New System.Drawing.Point(103, 3)
            Me.btnModNombreAsoc.Name = "btnModNombreAsoc"
            Me.btnModNombreAsoc.Size = New System.Drawing.Size(100, 40)
            Me.btnModNombreAsoc.TabIndex = 90
            Me.btnModNombreAsoc.Text = "Modificar"
            Me.btnModNombreAsoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.rdbActivos)
            Me.Panel2.Controls.Add(Me.rdbTodos)
            Me.Panel2.Controls.Add(Me.rdbAnulados)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(233, 46)
            Me.Panel2.TabIndex = 92
            Me.Panel2.Visible = False
            '
            'rdbActivos
            '
            Me.rdbActivos.AutoSize = True
            Me.rdbActivos.Location = New System.Drawing.Point(3, 15)
            Me.rdbActivos.Name = "rdbActivos"
            Me.rdbActivos.Size = New System.Drawing.Size(60, 17)
            Me.rdbActivos.TabIndex = 89
            Me.rdbActivos.Text = "Activos"
            Me.rdbActivos.UseVisualStyleBackColor = True
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(167, 15)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 91
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbAnulados
            '
            Me.rdbAnulados.AutoSize = True
            Me.rdbAnulados.Location = New System.Drawing.Point(78, 15)
            Me.rdbAnulados.Name = "rdbAnulados"
            Me.rdbAnulados.Size = New System.Drawing.Size(69, 17)
            Me.rdbAnulados.TabIndex = 90
            Me.rdbAnulados.Text = "Anulados"
            Me.rdbAnulados.UseVisualStyleBackColor = True
            '
            'pnlAnular
            '
            Me.pnlAnular.Controls.Add(Me.btnAnular)
            Me.pnlAnular.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAnular.Location = New System.Drawing.Point(652, 0)
            Me.pnlAnular.Name = "pnlAnular"
            Me.pnlAnular.Size = New System.Drawing.Size(107, 46)
            Me.pnlAnular.TabIndex = 88
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnAnular.Location = New System.Drawing.Point(3, 3)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(100, 40)
            Me.btnAnular.TabIndex = 88
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblReg)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 302)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(759, 22)
            Me.Panel1.TabIndex = 11
            '
            'lblReg
            '
            Me.lblReg.AutoSize = True
            Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReg.Location = New System.Drawing.Point(6, 5)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(45, 13)
            Me.lblReg.TabIndex = 60
            Me.lblReg.Text = "0 Reg."
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.Visible = False
            '
            'col_nro
            '
            Me.col_nro.HeaderText = "N°"
            Me.col_nro.Name = "col_nro"
            Me.col_nro.Width = 25
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "NombreAsociadoID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Visible = False
            Me.col_chk.Width = 30
            '
            'col_ing_nro
            '
            Me.col_ing_nro.DataPropertyName = "IngresoNro"
            Me.col_ing_nro.HeaderText = "Nro Ingreso"
            Me.col_ing_nro.Name = "col_ing_nro"
            Me.col_ing_nro.Width = 50
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "Nro Ingreso"
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.Visible = False
            Me.col_ing_nro_inpe.Width = 50
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "PrincipalNombre"
            Me.Column2.HeaderText = "Tipo"
            Me.Column2.Name = "Column2"
            Me.Column2.Width = 80
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.HeaderText = "Apellido Paterno"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Width = 180
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "Apellido Materno"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Width = 180
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 180
            '
            'col_nom_aso_pri
            '
            Me.col_nom_aso_pri.DataPropertyName = "Principal"
            Me.col_nom_aso_pri.HeaderText = "Principal"
            Me.col_nom_aso_pri.Name = "col_nom_aso_pri"
            Me.col_nom_aso_pri.ReadOnly = True
            Me.col_nom_aso_pri.Visible = False
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "Estado"
            Me.col_est_id.HeaderText = "EstadoID"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.Visible = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "EstadoNombre"
            Me.Column1.HeaderText = "Estado"
            Me.Column1.Name = "Column1"
            Me.Column1.Width = 80
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoID"
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.Visible = False
            '
            'col_doc_nom_aso_id
            '
            Me.col_doc_nom_aso_id.DataPropertyName = "DocumentoNombreAsociadoID"
            Me.col_doc_nom_aso_id.HeaderText = "DocNombreAsociadoID"
            Me.col_doc_nom_aso_id.Name = "col_doc_nom_aso_id"
            Me.col_doc_nom_aso_id.Visible = False
            Me.col_doc_nom_aso_id.Width = 50
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "DocumentoJudicialID"
            Me.col_doc_jud_id.HeaderText = "DocumentoJudicialID"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 50
            '
            'col_doc_exist
            '
            Me.col_doc_exist.DataPropertyName = "DocumentoExiste"
            Me.col_doc_exist.HeaderText = "Docum."
            Me.col_doc_exist.Name = "col_doc_exist"
            Me.col_doc_exist.ToolTipText = "Documento Judicial"
            Me.col_doc_exist.Visible = False
            Me.col_doc_exist.Width = 50
            '
            'uscGrillaNombresAsociadosV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.pnlAddNombreAsoc)
            Me.Name = "uscGrillaNombresAsociadosV2"
            Me.Size = New System.Drawing.Size(759, 324)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAddNombreAsoc.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlAnular.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents pnlAddNombreAsoc As System.Windows.Forms.Panel
        Friend WithEvents pnlAnular As System.Windows.Forms.Panel
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents rdbTodos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbAnulados As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbActivos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnModNombreAsoc As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_chk As DataGridViewCheckBoxColumn
        Friend WithEvents col_ing_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_aso_pri As DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_nom_aso_id As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_exist As DataGridViewCheckBoxColumn
    End Class
End Namespace

