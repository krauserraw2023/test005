Namespace Registro.Reniec
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscListaReniec2
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
            Me.grpListaDatosReniec = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgwGrillaListaReniec = New Legolas.APPUIComponents.myDatagridView()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dig_ver = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mostrar = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.grpListaDatosReniec.SuspendLayout()
            CType(Me.dgwGrillaListaReniec, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grpListaDatosReniec
            '
            Me.grpListaDatosReniec.Controls.Add(Me.Label1)
            Me.grpListaDatosReniec.Controls.Add(Me.dgwGrillaListaReniec)
            Me.grpListaDatosReniec.Location = New System.Drawing.Point(3, -6)
            Me.grpListaDatosReniec.Name = "grpListaDatosReniec"
            Me.grpListaDatosReniec.Size = New System.Drawing.Size(496, 430)
            Me.grpListaDatosReniec.TabIndex = 0
            Me.grpListaDatosReniec.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(189, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(156, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "REGISTROS ENCONTRADOS"
            '
            'dgwGrillaListaReniec
            '
            Me.dgwGrillaListaReniec.AllowUserToAddRows = False
            Me.dgwGrillaListaReniec.AllowUserToDeleteRows = False
            Me.dgwGrillaListaReniec.AllowUserToResizeRows = False
            Me.dgwGrillaListaReniec.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaListaReniec.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaListaReniec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaListaReniec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_num_dni, Me.col_dig_ver, Me.Column3, Me.Column4, Me.Column5, Me.col_mostrar})
            Me.dgwGrillaListaReniec.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaListaReniec.Location = New System.Drawing.Point(3, 26)
            Me.dgwGrillaListaReniec.MultiSelect = False
            Me.dgwGrillaListaReniec.Name = "dgwGrillaListaReniec"
            Me.dgwGrillaListaReniec.ReadOnly = True
            Me.dgwGrillaListaReniec.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaListaReniec.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaListaReniec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaListaReniec.Size = New System.Drawing.Size(490, 398)
            Me.dgwGrillaListaReniec.TabIndex = 1
            Me.dgwGrillaListaReniec.VisibleCampos = False
            '
            'col_num
            '
            Me.col_num.HeaderText = "N°"
            Me.col_num.Name = "col_num"
            Me.col_num.ReadOnly = True
            Me.col_num.Width = 25
            '
            'col_num_dni
            '
            Me.col_num_dni.HeaderText = "Nro DNI "
            Me.col_num_dni.Name = "col_num_dni"
            Me.col_num_dni.ReadOnly = True
            Me.col_num_dni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_num_dni.Width = 57
            '
            'col_dig_ver
            '
            Me.col_dig_ver.HeaderText = "Dig"
            Me.col_dig_ver.Name = "col_dig_ver"
            Me.col_dig_ver.ReadOnly = True
            Me.col_dig_ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_dig_ver.ToolTipText = "Digito de Verificación"
            Me.col_dig_ver.Width = 25
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column3.HeaderText = "Primer Apellido"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column4
            '
            Me.Column4.HeaderText = "Segundo Apellido"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column4.Width = 103
            '
            'Column5
            '
            Me.Column5.HeaderText = "Nombres"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column5.Width = 108
            '
            'col_mostrar
            '
            Me.col_mostrar.HeaderText = "Mostrar Datos"
            Me.col_mostrar.Name = "col_mostrar"
            Me.col_mostrar.ReadOnly = True
            Me.col_mostrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_mostrar.Width = 50
            '
            'uscListaReniec2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.grpListaDatosReniec)
            Me.Name = "uscListaReniec2"
            Me.Size = New System.Drawing.Size(502, 427)
            Me.grpListaDatosReniec.ResumeLayout(False)
            Me.grpListaDatosReniec.PerformLayout()
            CType(Me.dgwGrillaListaReniec, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grpListaDatosReniec As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrillaListaReniec As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_dni As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_dig_ver As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mostrar As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace

