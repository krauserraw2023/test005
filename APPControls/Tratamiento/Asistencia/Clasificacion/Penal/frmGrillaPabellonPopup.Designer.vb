Namespace Tratamiento.Asistencia.Clasificacion.Penal

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmGrillaPabellonPopup
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dgvGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pab_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pab_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel_btn = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(623, 334)
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.Panel2)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 288)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(623, 46)
            Me.PnlBotones.TabIndex = 3
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(431, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(192, 46)
            Me.Panel2.TabIndex = 3
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(95, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(89, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.dgvGrilla)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(623, 288)
            Me.Panel1.TabIndex = 4
            '
            'dgvGrilla
            '
            Me.dgvGrilla.AllowUserToAddRows = False
            Me.dgvGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_pab_id, Me.col_pab_nom, Me.Column1, Me.Column2, Me.col_sel_btn})
            Me.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgvGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgvGrilla.MultiSelect = False
            Me.dgvGrilla.Name = "dgvGrilla"
            Me.dgvGrilla.ReadOnly = True
            Me.dgvGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrilla.Size = New System.Drawing.Size(623, 288)
            Me.dgvGrilla.TabIndex = 1
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_id.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 50
            '
            'col_pab_id
            '
            Me.col_pab_id.DataPropertyName = "IDPabellon"
            Me.col_pab_id.HeaderText = "IDPabellon"
            Me.col_pab_id.Name = "col_pab_id"
            Me.col_pab_id.ReadOnly = True
            Me.col_pab_id.Visible = False
            '
            'col_pab_nom
            '
            Me.col_pab_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_pab_nom.DataPropertyName = "PabellonNombre"
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.col_pab_nom.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_pab_nom.HeaderText = "Pabelllon"
            Me.col_pab_nom.Name = "col_pab_nom"
            Me.col_pab_nom.ReadOnly = True
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "RegimenNombre"
            Me.Column1.HeaderText = "Regimen"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "EtapaNombre"
            Me.Column2.HeaderText = "Etapa"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 150
            '
            'col_sel_btn
            '
            Me.col_sel_btn.HeaderText = "-"
            Me.col_sel_btn.Name = "col_sel_btn"
            Me.col_sel_btn.ReadOnly = True
            Me.col_sel_btn.Text = "Seleccione"
            Me.col_sel_btn.ToolTipText = "Seleccione"
            Me.col_sel_btn.UseColumnTextForButtonValue = True
            '
            'frmGrillaPabellonPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(623, 334)
            Me.Name = "frmGrillaPabellonPopup"
            Me.Text = "Seleccione Pabellon"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents dgvGrilla As DataGridView
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pab_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pab_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents col_sel_btn As DataGridViewButtonColumn
    End Class
End Namespace