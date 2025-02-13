<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectAleroPopup
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlBotonesPrincipal = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvFichaVariables = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.col_aleroId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_alero_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_piso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_piso_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_alero_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PnlBotonesPrincipal.SuspendLayout()
        CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBotonesPrincipal
        '
        Me.PnlBotonesPrincipal.Controls.Add(Me.btnCancel)
        Me.PnlBotonesPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBotonesPrincipal.Location = New System.Drawing.Point(0, 407)
        Me.PnlBotonesPrincipal.Name = "PnlBotonesPrincipal"
        Me.PnlBotonesPrincipal.Size = New System.Drawing.Size(800, 43)
        Me.PnlBotonesPrincipal.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
        Me.btnCancel.Location = New System.Drawing.Point(710, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 40)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancelar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'dgvFichaVariables
        '
        Me.dgvFichaVariables.AllowUserToAddRows = False
        Me.dgvFichaVariables.AllowUserToDeleteRows = False
        Me.dgvFichaVariables.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFichaVariables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFichaVariables.BackgroundColor = System.Drawing.Color.White
        Me.dgvFichaVariables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFichaVariables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFichaVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFichaVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_aleroId, Me.col_alero_id, Me.col_piso_id, Me.col_piso_nom, Me.col_alero_nom, Me.col_sel})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFichaVariables.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFichaVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFichaVariables.GridColor = System.Drawing.Color.SkyBlue
        Me.dgvFichaVariables.Location = New System.Drawing.Point(0, 41)
        Me.dgvFichaVariables.MultiSelect = False
        Me.dgvFichaVariables.Name = "dgvFichaVariables"
        Me.dgvFichaVariables.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFichaVariables.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFichaVariables.RowHeadersVisible = False
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFichaVariables.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFichaVariables.RowTemplate.Height = 44
        Me.dgvFichaVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFichaVariables.Size = New System.Drawing.Size(800, 366)
        Me.dgvFichaVariables.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 41)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(95, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(693, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pabellón:"
        '
        'col_aleroId
        '
        Me.col_aleroId.DataPropertyName = "Codigo"
        Me.col_aleroId.HeaderText = "Codigo"
        Me.col_aleroId.Name = "col_aleroId"
        Me.col_aleroId.ReadOnly = True
        Me.col_aleroId.Visible = False
        '
        'col_alero_id
        '
        Me.col_alero_id.DataPropertyName = "AleroId"
        Me.col_alero_id.HeaderText = "MaeVariableId"
        Me.col_alero_id.MinimumWidth = 20
        Me.col_alero_id.Name = "col_alero_id"
        Me.col_alero_id.ReadOnly = True
        Me.col_alero_id.Visible = False
        Me.col_alero_id.Width = 80
        '
        'col_piso_id
        '
        Me.col_piso_id.DataPropertyName = "PisoId"
        Me.col_piso_id.HeaderText = "PisoId"
        Me.col_piso_id.Name = "col_piso_id"
        Me.col_piso_id.ReadOnly = True
        Me.col_piso_id.Visible = False
        Me.col_piso_id.Width = 50
        '
        'col_piso_nom
        '
        Me.col_piso_nom.DataPropertyName = "PisoNombre"
        Me.col_piso_nom.HeaderText = "Piso"
        Me.col_piso_nom.MinimumWidth = 200
        Me.col_piso_nom.Name = "col_piso_nom"
        Me.col_piso_nom.ReadOnly = True
        Me.col_piso_nom.Width = 200
        '
        'col_alero_nom
        '
        Me.col_alero_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_alero_nom.DataPropertyName = "Nombre"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_alero_nom.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_alero_nom.HeaderText = "Alero"
        Me.col_alero_nom.Name = "col_alero_nom"
        Me.col_alero_nom.ReadOnly = True
        '
        'col_sel
        '
        Me.col_sel.HeaderText = "--"
        Me.col_sel.Name = "col_sel"
        Me.col_sel.ReadOnly = True
        Me.col_sel.Text = "Seleccione"
        Me.col_sel.ToolTipText = "Seleccionar ambiente"
        Me.col_sel.UseColumnTextForButtonValue = True
        Me.col_sel.Width = 80
        '
        'frmSelectAleroPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvFichaVariables)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlBotonesPrincipal)
        Me.Name = "frmSelectAleroPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".::. Seleccione ambiente"
        Me.PnlBotonesPrincipal.ResumeLayout(False)
        CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlBotonesPrincipal As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents dgvFichaVariables As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents col_aleroId As DataGridViewTextBoxColumn
    Friend WithEvents col_alero_id As DataGridViewTextBoxColumn
    Friend WithEvents col_piso_id As DataGridViewTextBoxColumn
    Friend WithEvents col_piso_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_alero_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_sel As DataGridViewButtonColumn
End Class
