Namespace Registro.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMovimientoTipoPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form overrides dispose to clean up the component list.
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.PnlGrilla = New System.Windows.Forms.Panel()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tipo_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tipo_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PnlGrilla.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.PnlGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(308, 275)
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Controls.Add(Me.btnOk)
            Me.PnlBotones.Controls.Add(Me.lblReg)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 229)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(308, 46)
            Me.PnlBotones.TabIndex = 57
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(216, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(89, 40)
            Me.btnCancel.TabIndex = 90
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(124, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(89, 40)
            Me.btnOk.TabIndex = 89
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblReg
            '
            Me.lblReg.AutoSize = True
            Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReg.Location = New System.Drawing.Point(3, 19)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(45, 13)
            Me.lblReg.TabIndex = 60
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.Visible = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_tipo_nom, Me.col_tipo_des})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(308, 229)
            Me.dgwGrilla.TabIndex = 0
            '
            'PnlGrilla
            '
            Me.PnlGrilla.Controls.Add(Me.dgwGrilla)
            Me.PnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PnlGrilla.Location = New System.Drawing.Point(0, 0)
            Me.PnlGrilla.Name = "PnlGrilla"
            Me.PnlGrilla.Size = New System.Drawing.Size(308, 229)
            Me.PnlGrilla.TabIndex = 58
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "MovimientoTipoID"
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_id.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_id.HeaderText = "ID Tipo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 50
            '
            'col_tipo_nom
            '
            Me.col_tipo_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_tipo_nom.DataPropertyName = "MovimientoTipoNombre"
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.col_tipo_nom.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_tipo_nom.HeaderText = "Nombre del Movimiento"
            Me.col_tipo_nom.Name = "col_tipo_nom"
            Me.col_tipo_nom.ReadOnly = True
            '
            'col_tipo_des
            '
            Me.col_tipo_des.DataPropertyName = "MovimientoTipoDescripcion"
            Me.col_tipo_des.HeaderText = "Tipo de Movimiento"
            Me.col_tipo_des.Name = "col_tipo_des"
            Me.col_tipo_des.ReadOnly = True
            '
            'frmMovimientoTipoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(308, 275)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoTipoPopup"
            Me.Text = "Seleccione tipo de movimiento"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.PnlBotones.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PnlGrilla.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents PnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tipo_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tipo_des As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace

