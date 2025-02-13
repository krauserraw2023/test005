Namespace Registro.Siscrico
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscGrillaOrgCriminalV2
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
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnModFamiliar = New System.Windows.Forms.Button()
            Me.btnAddIntBanda = New System.Windows.Forms.Button()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ban_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ban_tip_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ban_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mie_tip_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ban_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dist_jud_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fech_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre_doc_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ban_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.pnlGrabar)
            Me.pnlCabecera.Controls.Add(Me.pnlEliminar)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(785, 46)
            Me.pnlCabecera.TabIndex = 4
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnModFamiliar)
            Me.pnlGrabar.Controls.Add(Me.btnAddIntBanda)
            Me.pnlGrabar.Controls.Add(Me.btnAnular)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(377, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(302, 46)
            Me.pnlGrabar.TabIndex = 90
            '
            'btnModFamiliar
            '
            Me.btnModFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModFamiliar.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModFamiliar.Location = New System.Drawing.Point(100, 3)
            Me.btnModFamiliar.Name = "btnModFamiliar"
            Me.btnModFamiliar.Size = New System.Drawing.Size(100, 40)
            Me.btnModFamiliar.TabIndex = 89
            Me.btnModFamiliar.Text = "Modificar"
            Me.btnModFamiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAddIntBanda
            '
            Me.btnAddIntBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddIntBanda.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddIntBanda.Location = New System.Drawing.Point(1, 3)
            Me.btnAddIntBanda.Name = "btnAddIntBanda"
            Me.btnAddIntBanda.Size = New System.Drawing.Size(98, 40)
            Me.btnAddIntBanda.TabIndex = 87
            Me.btnAddIntBanda.Text = "&Agregar"
            Me.btnAddIntBanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.APPControls.My.Resources.Resources.Delete_32_2_
            Me.btnAnular.Location = New System.Drawing.Point(202, 3)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(100, 40)
            Me.btnAnular.TabIndex = 89
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(679, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(106, 46)
            Me.pnlEliminar.TabIndex = 88
            Me.pnlEliminar.Visible = False
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(2, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(100, 40)
            Me.btnEliminar.TabIndex = 92
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_int_id, Me.col_ban_id, Me.col_ing_nro, Me.col_ban_tip_nom, Me.col_ban_nom, Me.col_mie_tip_nom, Me.col_doc_jud_id, Me.col_int_ban_est, Me.col_dist_jud_nom, Me.col_sal_jud_nom, Me.col_num_doc_jud, Me.col_fech_doc_jud, Me.col_secre_doc_jud, Me.col_int_ban_est_nom, Me.col_ing_id})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 46)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(785, 289)
            Me.dgwGrilla.TabIndex = 81
            Me.dgwGrilla.VisibleCampos = True
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.DividerWidth = 1
            Me.col_id.HeaderText = "InternoBanda"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_ban_id
            '
            Me.col_ban_id.DataPropertyName = "BandaID"
            Me.col_ban_id.DividerWidth = 1
            Me.col_ban_id.HeaderText = "BandaID"
            Me.col_ban_id.Name = "col_ban_id"
            Me.col_ban_id.ReadOnly = True
            Me.col_ban_id.Visible = False
            '
            'col_ing_nro
            '
            Me.col_ing_nro.DataPropertyName = "IngresoNro"
            Me.col_ing_nro.HeaderText = "Nro Ingreso"
            Me.col_ing_nro.Name = "col_ing_nro"
            Me.col_ing_nro.ReadOnly = True
            Me.col_ing_nro.Width = 50
            '
            'col_ban_tip_nom
            '
            Me.col_ban_tip_nom.DataPropertyName = "BandaTipoNom_Ini"
            Me.col_ban_tip_nom.HeaderText = "Tipo Org. Criminal"
            Me.col_ban_tip_nom.Name = "col_ban_tip_nom"
            Me.col_ban_tip_nom.ReadOnly = True
            Me.col_ban_tip_nom.Width = 90
            '
            'col_ban_nom
            '
            Me.col_ban_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_ban_nom.DataPropertyName = "BandaNombre"
            Me.col_ban_nom.HeaderText = "Denominación organización"
            Me.col_ban_nom.Name = "col_ban_nom"
            Me.col_ban_nom.ReadOnly = True
            Me.col_ban_nom.Width = 149
            '
            'col_mie_tip_nom
            '
            Me.col_mie_tip_nom.DataPropertyName = "BandaMiembroTipoNombre_Ini"
            Me.col_mie_tip_nom.HeaderText = "Tipo Int."
            Me.col_mie_tip_nom.Name = "col_mie_tip_nom"
            Me.col_mie_tip_nom.ReadOnly = True
            Me.col_mie_tip_nom.Width = 38
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "DocJudicialID_Crea"
            Me.col_doc_jud_id.DividerWidth = 1
            Me.col_doc_jud_id.HeaderText = "DocJudicialID"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.ReadOnly = True
            Me.col_doc_jud_id.Visible = False
            '
            'col_int_ban_est
            '
            Me.col_int_ban_est.DataPropertyName = "Estado"
            Me.col_int_ban_est.DividerWidth = 1
            Me.col_int_ban_est.HeaderText = "EstadoId"
            Me.col_int_ban_est.Name = "col_int_ban_est"
            Me.col_int_ban_est.ReadOnly = True
            Me.col_int_ban_est.Visible = False
            '
            'col_dist_jud_nom
            '
            Me.col_dist_jud_nom.DataPropertyName = "DocJudDistNom"
            Me.col_dist_jud_nom.HeaderText = "Distrito Judicial"
            Me.col_dist_jud_nom.Name = "col_dist_jud_nom"
            Me.col_dist_jud_nom.ReadOnly = True
            Me.col_dist_jud_nom.Width = 150
            '
            'col_sal_jud_nom
            '
            Me.col_sal_jud_nom.DataPropertyName = "DocJudSalaNom"
            Me.col_sal_jud_nom.HeaderText = "Juzgado / Sala"
            Me.col_sal_jud_nom.Name = "col_sal_jud_nom"
            Me.col_sal_jud_nom.ReadOnly = True
            Me.col_sal_jud_nom.Width = 150
            '
            'col_num_doc_jud
            '
            Me.col_num_doc_jud.DataPropertyName = "DocJudNum"
            Me.col_num_doc_jud.HeaderText = "N° Doc. Jud."
            Me.col_num_doc_jud.Name = "col_num_doc_jud"
            Me.col_num_doc_jud.ReadOnly = True
            '
            'col_fech_doc_jud
            '
            Me.col_fech_doc_jud.DataPropertyName = "FechDocJudConFormato"
            Me.col_fech_doc_jud.HeaderText = "Fecha Doc. Jud."
            Me.col_fech_doc_jud.Name = "col_fech_doc_jud"
            Me.col_fech_doc_jud.ReadOnly = True
            Me.col_fech_doc_jud.Width = 78
            '
            'col_secre_doc_jud
            '
            Me.col_secre_doc_jud.DataPropertyName = "DocJudSecre"
            Me.col_secre_doc_jud.HeaderText = "Secretario Doc. Jud."
            Me.col_secre_doc_jud.Name = "col_secre_doc_jud"
            Me.col_secre_doc_jud.ReadOnly = True
            Me.col_secre_doc_jud.Width = 130
            '
            'col_int_ban_est_nom
            '
            Me.col_int_ban_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_int_ban_est_nom.HeaderText = "Estado"
            Me.col_int_ban_est_nom.Name = "col_int_ban_est_nom"
            Me.col_int_ban_est_nom.ReadOnly = True
            Me.col_int_ban_est_nom.Width = 65
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoID"
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            Me.col_ing_id.Width = 50
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Label37)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.Label38)
            Me.Panel2.Controls.Add(Me.Label42)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 294)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(785, 41)
            Me.Panel2.TabIndex = 82
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Location = New System.Drawing.Point(149, 22)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(85, 13)
            Me.Label37.TabIndex = 102
            Me.Label37.Text = "INT :  Integrante"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(240, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(85, 13)
            Me.Label1.TabIndex = 101
            Me.Label1.Text = "FNC : Financista"
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Location = New System.Drawing.Point(34, 22)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(105, 13)
            Me.Label38.TabIndex = 101
            Me.Label38.Text = "C/L : Cabecilla/Lider"
            '
            'Label42
            '
            Me.Label42.AutoSize = True
            Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label42.Location = New System.Drawing.Point(7, 7)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(154, 13)
            Me.Label42.TabIndex = 100
            Me.Label42.Text = "Tipo Int. (Tipo Integrante)"
            '
            'uscGrillaOrgCriminalV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Name = "uscGrillaOrgCriminalV2"
            Me.Size = New System.Drawing.Size(785, 335)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnAddIntBanda As System.Windows.Forms.Button
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents Label42 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ban_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ban_tip_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ban_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mie_tip_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_ban_est As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_dist_jud_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fech_doc_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_secre_doc_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_ban_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnModFamiliar As System.Windows.Forms.Button

    End Class
End Namespace
