Namespace Visita.Autorizacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscAutorizacionGrilla
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
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_par_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.col_id, Me.col_num_doc, Me.col_vis_id, Me.col_vis_ape_nom, Me.col_par_id, Me.Column3})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(226, 191)
            Me.dgwGrilla.TabIndex = 87
            Me.dgwGrilla.VisibleCampos = False
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "SeleccionarCheck"
            Me.Column5.HeaderText = ""
            Me.Column5.Name = "Column5"
            Me.Column5.Visible = False
            Me.Column5.Width = 35
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "VisitanteTipoDoc_Numero"
            Me.col_num_doc.HeaderText = "Tipo y N° Doc."
            Me.col_num_doc.Name = "col_num_doc"
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "VisitanteID"
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.ReadOnly = True
            Me.col_vis_id.Visible = False
            '
            'col_vis_ape_nom
            '
            Me.col_vis_ape_nom.DataPropertyName = "VisitanteApeNom"
            Me.col_vis_ape_nom.HeaderText = "Visitante"
            Me.col_vis_ape_nom.Name = "col_vis_ape_nom"
            Me.col_vis_ape_nom.ReadOnly = True
            Me.col_vis_ape_nom.Width = 150
            '
            'col_par_id
            '
            Me.col_par_id.DataPropertyName = "ParentescoID"
            Me.col_par_id.HeaderText = "ParentescoID"
            Me.col_par_id.Name = "col_par_id"
            Me.col_par_id.ReadOnly = True
            Me.col_par_id.Visible = False
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Parentesco"
            Me.Column3.HeaderText = "Parentesco"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 70
            '
            'uscAutorizacionGrilla
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Name = "uscAutorizacionGrilla"
            Me.Size = New System.Drawing.Size(226, 191)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_ape_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_par_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace