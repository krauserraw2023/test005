Namespace Sistema.Seguridad.Licencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPenal
        Inherits System.Windows.Forms.Form

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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.dgwPenal = New System.Windows.Forms.DataGridView()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_lec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_esc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbOpc2 = New System.Windows.Forms.RadioButton()
            Me.rdbOpc1 = New System.Windows.Forms.RadioButton()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgwPenal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(468, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(98, 40)
            Me.btnCancel.TabIndex = 46
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(371, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 45
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.chkTodos)
            Me.GroupBox4.Controls.Add(Me.dgwPenal)
            Me.GroupBox4.Controls.Add(Me.Panel3)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(572, 428)
            Me.GroupBox4.TabIndex = 54
            Me.GroupBox4.TabStop = False
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Location = New System.Drawing.Point(13, 104)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(15, 14)
            Me.chkTodos.TabIndex = 6
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'dgwPenal
            '
            Me.dgwPenal.AllowUserToAddRows = False
            Me.dgwPenal.AllowUserToDeleteRows = False
            Me.dgwPenal.AllowUserToOrderColumns = True
            Me.dgwPenal.BackgroundColor = System.Drawing.Color.White
            Me.dgwPenal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwPenal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_mac, Me.col_lec, Me.col_esc})
            Me.dgwPenal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwPenal.Location = New System.Drawing.Point(3, 99)
            Me.dgwPenal.MultiSelect = False
            Me.dgwPenal.Name = "dgwPenal"
            Me.dgwPenal.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwPenal.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwPenal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwPenal.Size = New System.Drawing.Size(566, 326)
            Me.dgwPenal.TabIndex = 4
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Width = 30
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.HeaderText = "RegionID"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "RegionNombre"
            Me.col_reg_nom.HeaderText = "Region"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.Width = 150
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "Codigo"
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_mac
            '
            Me.col_mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_mac.DataPropertyName = "Nombre"
            Me.col_mac.HeaderText = "Penal"
            Me.col_mac.Name = "col_mac"
            Me.col_mac.ReadOnly = True
            '
            'col_lec
            '
            Me.col_lec.HeaderText = "Lectura"
            Me.col_lec.Name = "col_lec"
            Me.col_lec.Visible = False
            Me.col_lec.Width = 55
            '
            'col_esc
            '
            Me.col_esc.HeaderText = "Escritura"
            Me.col_esc.Name = "col_esc"
            Me.col_esc.Visible = False
            Me.col_esc.Width = 55
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.GroupBox1)
            Me.Panel3.Controls.Add(Me.Label11)
            Me.Panel3.Controls.Add(Me.cbbRegion)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(566, 83)
            Me.Panel3.TabIndex = 5
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbOpc2)
            Me.GroupBox1.Controls.Add(Me.rdbOpc1)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 37)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(466, 40)
            Me.GroupBox1.TabIndex = 46
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Establecimiento"
            '
            'rdbOpc2
            '
            Me.rdbOpc2.AutoSize = True
            Me.rdbOpc2.Location = New System.Drawing.Point(217, 18)
            Me.rdbOpc2.Name = "rdbOpc2"
            Me.rdbOpc2.Size = New System.Drawing.Size(243, 17)
            Me.rdbOpc2.TabIndex = 1
            Me.rdbOpc2.Text = "Est. Post Penitenciario y Pena Limit. Derechos"
            Me.rdbOpc2.UseVisualStyleBackColor = True
            '
            'rdbOpc1
            '
            Me.rdbOpc1.AutoSize = True
            Me.rdbOpc1.Checked = True
            Me.rdbOpc1.Location = New System.Drawing.Point(6, 18)
            Me.rdbOpc1.Name = "rdbOpc1"
            Me.rdbOpc1.Size = New System.Drawing.Size(163, 17)
            Me.rdbOpc1.TabIndex = 0
            Me.rdbOpc1.TabStop = True
            Me.rdbOpc1.Text = "Establecimiento Penitenciario"
            Me.rdbOpc1.UseVisualStyleBackColor = True
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(5, 13)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(47, 13)
            Me.Label11.TabIndex = 44
            Me.Label11.Text = "Region :"
            '
            'cbbRegion
            '
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.Region
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 230
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.Location = New System.Drawing.Point(58, 9)
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(230, 22)
            Me.cbbRegion.TabIndex = 45
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 428)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(572, 45)
            Me.Panel2.TabIndex = 57
            '
            'frmPenal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(572, 473)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPenal"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Regiones y Penales - Licenciados"
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.dgwPenal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwPenal As System.Windows.Forms.DataGridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbOpc2 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbOpc1 As System.Windows.Forms.RadioButton
        Friend WithEvents col_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mac As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_lec As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_esc As System.Windows.Forms.DataGridViewCheckBoxColumn

    End Class
End Namespace

