Namespace Registro

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmListaDelitosHistoricos
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.grbFiltro = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dgwSentencias = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgwAgraviado = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbFiltro.SuspendLayout()
            CType(Me.dgwSentencias, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgwAgraviado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbFiltro)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(934, 378)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 333)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(934, 45)
            Me.Panel1.TabIndex = 102
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(834, 2)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 98
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbFiltro
            '
            Me.grbFiltro.Controls.Add(Me.Label2)
            Me.grbFiltro.Controls.Add(Me.dgwSentencias)
            Me.grbFiltro.Controls.Add(Me.dgwAgraviado)
            Me.grbFiltro.Controls.Add(Me.Label1)
            Me.grbFiltro.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbFiltro.Location = New System.Drawing.Point(0, 0)
            Me.grbFiltro.Name = "grbFiltro"
            Me.grbFiltro.Size = New System.Drawing.Size(934, 333)
            Me.grbFiltro.TabIndex = 103
            Me.grbFiltro.TabStop = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 162)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 18)
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "SMP"
            '
            'dgwSentencias
            '
            Me.dgwSentencias.AllowUserToAddRows = False
            Me.dgwSentencias.BackgroundColor = System.Drawing.Color.White
            Me.dgwSentencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwSentencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10})
            Me.dgwSentencias.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.dgwSentencias.GridColor = System.Drawing.Color.LightGray
            Me.dgwSentencias.Location = New System.Drawing.Point(3, 184)
            Me.dgwSentencias.MultiSelect = False
            Me.dgwSentencias.Name = "dgwSentencias"
            Me.dgwSentencias.ReadOnly = True
            Me.dgwSentencias.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwSentencias.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwSentencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwSentencias.Size = New System.Drawing.Size(928, 146)
            Me.dgwSentencias.TabIndex = 11
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
            Me.DataGridViewTextBoxColumn1.HeaderText = "DelitoID"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Visible = False
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "DelitoEspecificoNombre"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Delito Especifico"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.Width = 200
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "DelitoGenericoNombre"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Delito Genérico"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 150
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "Expedientenumero"
            Me.DataGridViewTextBoxColumn4.HeaderText = "N° Expediente"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 116
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "TipoDocumento"
            Me.Column4.HeaderText = "Tipo Documento"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaRecepcionString"
            Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Recep."
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            Me.DataGridViewTextBoxColumn5.Width = 70
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "Agraviados"
            Me.DataGridViewTextBoxColumn8.HeaderText = "Agraviados"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            Me.DataGridViewTextBoxColumn8.Width = 200
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.DataPropertyName = "FechaCreacionString"
            Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha Selec."
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.ReadOnly = True
            Me.DataGridViewTextBoxColumn10.Width = 130
            '
            'dgwAgraviado
            '
            Me.dgwAgraviado.AllowUserToAddRows = False
            Me.dgwAgraviado.BackgroundColor = System.Drawing.Color.White
            Me.dgwAgraviado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwAgraviado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.Column1, Me.Column14, Me.Column3, Me.DataGridViewTextBoxColumn6, Me.col_agr_nom, Me.Column2})
            Me.dgwAgraviado.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwAgraviado.GridColor = System.Drawing.Color.LightGray
            Me.dgwAgraviado.Location = New System.Drawing.Point(3, 34)
            Me.dgwAgraviado.MultiSelect = False
            Me.dgwAgraviado.Name = "dgwAgraviado"
            Me.dgwAgraviado.ReadOnly = True
            Me.dgwAgraviado.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwAgraviado.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwAgraviado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwAgraviado.Size = New System.Drawing.Size(928, 128)
            Me.dgwAgraviado.TabIndex = 8
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "Codigo"
            Me.DataGridViewTextBoxColumn7.HeaderText = "DelitoID"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.Visible = False
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "DelitoEspecificoNombre"
            Me.DataGridViewTextBoxColumn9.HeaderText = "Delito Especifico"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            Me.DataGridViewTextBoxColumn9.Width = 200
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "DelitoGenericoNombre"
            Me.Column1.HeaderText = "Delito Genérico"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 150
            '
            'Column14
            '
            Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column14.DataPropertyName = "Expedientenumero"
            Me.Column14.HeaderText = "N° Expediente"
            Me.Column14.Name = "Column14"
            Me.Column14.ReadOnly = True
            Me.Column14.Width = 116
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column3.DataPropertyName = "TipoDocumento"
            Me.Column3.HeaderText = "Tipo Documento"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaRecepcionString"
            Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Recep."
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 70
            '
            'col_agr_nom
            '
            Me.col_agr_nom.DataPropertyName = "Agraviados"
            Me.col_agr_nom.HeaderText = "Agraviados"
            Me.col_agr_nom.Name = "col_agr_nom"
            Me.col_agr_nom.ReadOnly = True
            Me.col_agr_nom.Width = 200
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "FechaCreacionString"
            Me.Column2.HeaderText = "Fecha Selec."
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 130
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(45, 18)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "DMP"
            '
            'frmListaDelitosHistoricos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(934, 378)
            Me.Name = "frmListaDelitosHistoricos"
            Me.Text = "Registro Histórico sobre Especificación de Delitos de Mayor Pena"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grbFiltro.ResumeLayout(False)
            Me.grbFiltro.PerformLayout()
            CType(Me.dgwSentencias, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgwAgraviado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
        Friend WithEvents dgwAgraviado As DataGridView
        Friend WithEvents Label1 As Label
        Friend WithEvents dgwSentencias As DataGridView
        Friend WithEvents Label2 As Label
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Column14 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
    End Class
End Namespace