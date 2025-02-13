Namespace Seguridad.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmUsuarioPenalPopup
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
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.grbUsuario = New System.Windows.Forms.GroupBox()
            Me.txtApeNom = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.dgwPenal = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mac = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnAddPenal = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.grbUsuario.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgwPenal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtUsuario
            '
            Me.txtUsuario.Location = New System.Drawing.Point(125, 24)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.ReadOnly = True
            Me.txtUsuario.Size = New System.Drawing.Size(128, 20)
            Me.txtUsuario.TabIndex = 43
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(6, 27)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(49, 13)
            Me.Label26.TabIndex = 44
            Me.Label26.Text = "Usuario :"
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(463, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 46
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(363, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 45
            Me.btnOk.Text = "&OK"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbUsuario
            '
            Me.grbUsuario.Controls.Add(Me.txtApeNom)
            Me.grbUsuario.Controls.Add(Me.txtUsuario)
            Me.grbUsuario.Controls.Add(Me.Label26)
            Me.grbUsuario.Controls.Add(Me.Label5)
            Me.grbUsuario.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbUsuario.Location = New System.Drawing.Point(0, 0)
            Me.grbUsuario.Name = "grbUsuario"
            Me.grbUsuario.Size = New System.Drawing.Size(569, 81)
            Me.grbUsuario.TabIndex = 52
            Me.grbUsuario.TabStop = False
            Me.grbUsuario.Text = "Datos de Usuario"
            '
            'txtApeNom
            '
            Me.txtApeNom.Location = New System.Drawing.Point(125, 50)
            Me.txtApeNom.Name = "txtApeNom"
            Me.txtApeNom.ReadOnly = True
            Me.txtApeNom.Size = New System.Drawing.Size(222, 20)
            Me.txtApeNom.TabIndex = 55
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 53)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(108, 13)
            Me.Label5.TabIndex = 54
            Me.Label5.Text = "Apellidos y Nombres :"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.chkTodos)
            Me.GroupBox4.Controls.Add(Me.dgwPenal)
            Me.GroupBox4.Controls.Add(Me.Panel3)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 81)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(569, 347)
            Me.GroupBox4.TabIndex = 54
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Region y Penales"
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Location = New System.Drawing.Point(14, 66)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(15, 14)
            Me.chkTodos.TabIndex = 48
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'dgwPenal
            '
            Me.dgwPenal.AllowUserToAddRows = False
            Me.dgwPenal.AllowUserToDeleteRows = False
            Me.dgwPenal.AllowUserToOrderColumns = True
            Me.dgwPenal.BackgroundColor = System.Drawing.Color.White
            Me.dgwPenal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwPenal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_chk, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_mac})
            Me.dgwPenal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwPenal.Location = New System.Drawing.Point(3, 61)
            Me.dgwPenal.MultiSelect = False
            Me.dgwPenal.Name = "dgwPenal"
            Me.dgwPenal.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwPenal.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwPenal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwPenal.Size = New System.Drawing.Size(563, 283)
            Me.dgwPenal.TabIndex = 4
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "CodigoID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
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
            Me.col_reg_nom.Width = 200
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
            Me.col_mac.DataPropertyName = "PenalNombre"
            Me.col_mac.HeaderText = "Penal"
            Me.col_mac.Name = "col_mac"
            Me.col_mac.ReadOnly = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnAddPenal)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(563, 45)
            Me.Panel3.TabIndex = 5
            '
            'btnAddPenal
            '
            Me.btnAddPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddPenal.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddPenal.Location = New System.Drawing.Point(460, 3)
            Me.btnAddPenal.Name = "btnAddPenal"
            Me.btnAddPenal.Size = New System.Drawing.Size(94, 40)
            Me.btnAddPenal.TabIndex = 88
            Me.btnAddPenal.Text = "&Penal"
            Me.btnAddPenal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnEliminar)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 428)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(569, 46)
            Me.Panel2.TabIndex = 57
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(3, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(96, 40)
            Me.btnEliminar.TabIndex = 47
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'frmUsuarioPenalPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(569, 474)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.grbUsuario)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmUsuarioPenalPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Mantenimiento de Permisos a Penales"
            Me.grbUsuario.ResumeLayout(False)
            Me.grbUsuario.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.dgwPenal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents grbUsuario As System.Windows.Forms.GroupBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwPenal As System.Windows.Forms.DataGridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents txtApeNom As System.Windows.Forms.TextBox
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mac As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnAddPenal As System.Windows.Forms.Button

    End Class
End Namespace

