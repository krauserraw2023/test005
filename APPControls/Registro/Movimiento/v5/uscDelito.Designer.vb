Namespace Registro.Documento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscDelito
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbrDelito = New System.Windows.Forms.GroupBox()
        Me.dgwDelito = New System.Windows.Forms.DataGridView()
        Me.col_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbrDelito.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbrDelito
            '
            Me.gbrDelito.Controls.Add(Me.dgwDelito)
            Me.gbrDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrDelito.Location = New System.Drawing.Point(0, 0)
            Me.gbrDelito.Name = "gbrDelito"
            Me.gbrDelito.Size = New System.Drawing.Size(818, 95)
            Me.gbrDelito.TabIndex = 50
            Me.gbrDelito.TabStop = False
            Me.gbrDelito.Text = "Delito"
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_del_id, Me.Column10, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.col_exp_id})
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(3, 16)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            Me.dgwDelito.ReadOnly = True
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(812, 76)
            Me.dgwDelito.TabIndex = 2
            '
            'col_del_id
            '
            Me.col_del_id.DataPropertyName = "Codigo"
            Me.col_del_id.HeaderText = "DelitoID"
            Me.col_del_id.Name = "col_del_id"
            Me.col_del_id.ReadOnly = True
            Me.col_del_id.Visible = False
            '
            'Column10
            '
            Me.Column10.DataPropertyName = "IngresoID"
            Me.Column10.HeaderText = "IngresoID"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Visible = False
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "DelitoEspecificoNombre"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Delito Especifico"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "DelitoGenericoNombre"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Delito Generico"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 380
            '
            'col_exp_id
            '
            Me.col_exp_id.DataPropertyName = "ExpedienteID"
            Me.col_exp_id.HeaderText = "ExpedienteID"
            Me.col_exp_id.Name = "col_exp_id"
            Me.col_exp_id.ReadOnly = True
            Me.col_exp_id.Visible = False
            '
        'uscDelito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.Controls.Add(Me.gbrDelito)
        Me.Name = "uscDelito"
        Me.Size = New System.Drawing.Size(818, 95)
        Me.gbrDelito.ResumeLayout(false)
        CType(Me.dgwDelito,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
        Friend WithEvents gbrDelito As System.Windows.Forms.GroupBox
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents col_del_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace

