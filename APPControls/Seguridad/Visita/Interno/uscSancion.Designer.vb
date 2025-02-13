Namespace Visita.Interno


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscSancion
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_est = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlAdd = New System.Windows.Forms.Panel()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.lblObs = New System.Windows.Forms.Label()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAdd.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlPie.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_est, Me.Column2, Me.col_id, Me.col_vis_id, Me.col_num_doc, Me.col_ape, Me.col_nom, Me.col_fec_ini, Me.col_fec_fin, Me.Column4, Me.Column3})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 55)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(697, 123)
            Me.dgwGrilla.TabIndex = 14
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.HeaderText = "Est."
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_est.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_est.ToolTipText = "Estado"
            Me.col_est.Visible = False
            Me.col_est.Width = 35
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "EstadoNombre"
            Me.Column2.HeaderText = "Estado"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 80
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "VisitanteSancionID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "VisitanteID"
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.ReadOnly = True
            Me.col_vis_id.Visible = False
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "NumeroDocumento"
            Me.col_num_doc.HeaderText = "NumeroDocumento"
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            Me.col_num_doc.Visible = False
            '
            'col_ape
            '
            Me.col_ape.DataPropertyName = "Apellidos"
            Me.col_ape.HeaderText = "Apellidos"
            Me.col_ape.Name = "col_ape"
            Me.col_ape.ReadOnly = True
            Me.col_ape.Visible = False
            Me.col_ape.Width = 150
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Visible = False
            Me.col_nom.Width = 150
            '
            'col_fec_ini
            '
            Me.col_fec_ini.DataPropertyName = "FechaInicio"
            DataGridViewCellStyle1.Format = "d"
            Me.col_fec_ini.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_ini.HeaderText = "Fecha Ini."
            Me.col_fec_ini.Name = "col_fec_ini"
            Me.col_fec_ini.ReadOnly = True
            '
            'col_fec_fin
            '
            Me.col_fec_fin.DataPropertyName = "FechaFin"
            DataGridViewCellStyle2.Format = "d"
            Me.col_fec_fin.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fec_fin.HeaderText = "Fecha Fin"
            Me.col_fec_fin.Name = "col_fec_fin"
            Me.col_fec_fin.ReadOnly = True
            '
            'Column4
            '
            Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column4.DataPropertyName = "Documento"
            Me.Column4.HeaderText = "Doc. Sancion"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column3.DataPropertyName = "TipoSancionNombre"
            Me.Column3.HeaderText = "Sancion"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            '
            'pnlAdd
            '
            Me.pnlAdd.Controls.Add(Me.btnAgregar)
            Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAdd.Location = New System.Drawing.Point(592, 0)
            Me.pnlAdd.Name = "pnlAdd"
            Me.pnlAdd.Size = New System.Drawing.Size(105, 55)
            Me.pnlAdd.TabIndex = 12
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregar.Location = New System.Drawing.Point(2, 9)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(97, 40)
            Me.btnAgregar.TabIndex = 10
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.pnlAdd)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(697, 55)
            Me.pnlCabecera.TabIndex = 15
            '
            'pnlPie
            '
            Me.pnlPie.Controls.Add(Me.lblObs)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 178)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(697, 23)
            Me.pnlPie.TabIndex = 16
            '
            'lblObs
            '
            Me.lblObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObs.ForeColor = System.Drawing.Color.Red
            Me.lblObs.Location = New System.Drawing.Point(0, 0)
            Me.lblObs.Name = "lblObs"
            Me.lblObs.Size = New System.Drawing.Size(697, 23)
            Me.lblObs.TabIndex = 0
            Me.lblObs.Text = "(*) Para anular la sancion, presione la tecla [suprimir] o [delete] y confirme la" & _
        " anulacion."
            Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'uscSancion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlPie)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Name = "uscSancion"
            Me.Size = New System.Drawing.Size(697, 201)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAdd.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlPie.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents pnlAdd As System.Windows.Forms.Panel
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents lblObs As System.Windows.Forms.Label
        Friend WithEvents col_est As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_fin As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace