Namespace Visita


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscVisitaMovimientoDetalle
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Me.dgwMovi = New System.Windows.Forms.DataGridView
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.col_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.col_pto_nom = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.col_hor_ing = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.col_hor_sal = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.col_perm = New System.Windows.Forms.DataGridViewTextBoxColumn
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgwMovi
            '
            Me.dgwMovi.AllowUserToAddRows = False
            Me.dgwMovi.BackgroundColor = System.Drawing.Color.White
            Me.dgwMovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwMovi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.col_det_id, Me.col_pto_nom, Me.col_hor_ing, Me.col_hor_sal, Me.col_perm})
            Me.dgwMovi.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwMovi.GridColor = System.Drawing.Color.LightGray
            Me.dgwMovi.Location = New System.Drawing.Point(0, 0)
            Me.dgwMovi.MultiSelect = False
            Me.dgwMovi.Name = "dgwMovi"
            Me.dgwMovi.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwMovi.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwMovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwMovi.Size = New System.Drawing.Size(542, 131)
            Me.dgwMovi.TabIndex = 11
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "codigo"
            Me.Column3.HeaderText = "Codigo"
            Me.Column3.Name = "Column3"
            Me.Column3.Visible = False
            Me.Column3.Width = 80
            '
            'col_det_id
            '
            Me.col_det_id.DataPropertyName = "DetalleId"
            Me.col_det_id.HeaderText = "detalleid"
            Me.col_det_id.Name = "col_det_id"
            Me.col_det_id.Visible = False
            '
            'col_pto_nom
            '
            Me.col_pto_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_pto_nom.DataPropertyName = "PuntoControlNombre"
            Me.col_pto_nom.HeaderText = "Punto de control"
            Me.col_pto_nom.Name = "col_pto_nom"
            Me.col_pto_nom.Width = 101
            '
            'col_hor_ing
            '
            Me.col_hor_ing.DataPropertyName = "HoraIngreso"
            Me.col_hor_ing.HeaderText = "Hora Ingreso"
            Me.col_hor_ing.Name = "col_hor_ing"
            '
            'col_hor_sal
            '
            Me.col_hor_sal.DataPropertyName = "HoraSalida"
            Me.col_hor_sal.HeaderText = "Hora Salida"
            Me.col_hor_sal.Name = "col_hor_sal"
            '
            'col_perm
            '
            Me.col_perm.DataPropertyName = "Permanencia"
            Me.col_perm.HeaderText = "Permanencia"
            Me.col_perm.Name = "col_perm"
            '
            'uscVisitanteMovimientoDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwMovi)
            Me.Name = "uscVisitanteMovimientoDetalle"
            Me.Size = New System.Drawing.Size(542, 131)
            CType(Me.dgwMovi, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwMovi As System.Windows.Forms.DataGridView
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pto_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hor_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hor_sal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_perm As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace