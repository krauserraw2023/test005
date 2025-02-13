Namespace Registro.Reniec


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmTipoValidacionV2
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
            Me.rdbDni = New System.Windows.Forms.RadioButton()
            Me.rdbNombreprincipal = New System.Windows.Forms.RadioButton()
            Me.grpTipovalidacion = New System.Windows.Forms.GroupBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbNofigura = New System.Windows.Forms.RadioButton()
            Me.rdbNombresAsociados = New System.Windows.Forms.RadioButton()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.dgwGrillaNombresAsociados = New Legolas.APPUIComponents.myDatagridView()
            Me.col_int_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_reg_na = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.grpTipovalidacion.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            CType(Me.dgwGrillaNombresAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'rdbDni
            '
            Me.rdbDni.AutoSize = True
            Me.rdbDni.Checked = True
            Me.rdbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbDni.Location = New System.Drawing.Point(45, 20)
            Me.rdbDni.Name = "rdbDni"
            Me.rdbDni.Size = New System.Drawing.Size(44, 17)
            Me.rdbDni.TabIndex = 0
            Me.rdbDni.TabStop = True
            Me.rdbDni.Text = "DNI"
            Me.rdbDni.UseVisualStyleBackColor = True
            '
            'rdbNombreprincipal
            '
            Me.rdbNombreprincipal.AutoSize = True
            Me.rdbNombreprincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNombreprincipal.Location = New System.Drawing.Point(45, 48)
            Me.rdbNombreprincipal.Name = "rdbNombreprincipal"
            Me.rdbNombreprincipal.Size = New System.Drawing.Size(104, 17)
            Me.rdbNombreprincipal.TabIndex = 1
            Me.rdbNombreprincipal.Text = "Nombre principal"
            Me.rdbNombreprincipal.UseVisualStyleBackColor = True
            '
            'grpTipovalidacion
            '
            Me.grpTipovalidacion.Controls.Add(Me.GroupBox1)
            Me.grpTipovalidacion.Controls.Add(Me.PictureBox1)
            Me.grpTipovalidacion.Dock = System.Windows.Forms.DockStyle.Top
            Me.grpTipovalidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpTipovalidacion.Location = New System.Drawing.Point(0, 0)
            Me.grpTipovalidacion.Name = "grpTipovalidacion"
            Me.grpTipovalidacion.Size = New System.Drawing.Size(386, 143)
            Me.grpTipovalidacion.TabIndex = 4
            Me.grpTipovalidacion.TabStop = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbNofigura)
            Me.GroupBox1.Controls.Add(Me.rdbDni)
            Me.GroupBox1.Controls.Add(Me.rdbNombresAsociados)
            Me.GroupBox1.Controls.Add(Me.rdbNombreprincipal)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(175, 124)
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Validación por"
            '
            'rdbNofigura
            '
            Me.rdbNofigura.AutoSize = True
            Me.rdbNofigura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNofigura.Location = New System.Drawing.Point(45, 104)
            Me.rdbNofigura.Name = "rdbNofigura"
            Me.rdbNofigura.Size = New System.Drawing.Size(120, 17)
            Me.rdbNofigura.TabIndex = 3
            Me.rdbNofigura.Text = "No figura en Reniec"
            Me.rdbNofigura.UseVisualStyleBackColor = True
            '
            'rdbNombresAsociados
            '
            Me.rdbNombresAsociados.AutoSize = True
            Me.rdbNombresAsociados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNombresAsociados.Location = New System.Drawing.Point(45, 76)
            Me.rdbNombresAsociados.Name = "rdbNombresAsociados"
            Me.rdbNombresAsociados.Size = New System.Drawing.Size(118, 17)
            Me.rdbNombresAsociados.TabIndex = 2
            Me.rdbNombresAsociados.Text = "Nombres asociados"
            Me.rdbNombresAsociados.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.Image = Global.SIPPOPE.My.Resources.Resources.reniec_peru
            Me.PictureBox1.Location = New System.Drawing.Point(184, 7)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(198, 132)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 144)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(386, 46)
            Me.Panel2.TabIndex = 45
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(288, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(188, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 85
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgwGrillaNombresAsociados
            '
            Me.dgwGrillaNombresAsociados.AllowUserToAddRows = False
            Me.dgwGrillaNombresAsociados.AllowUserToDeleteRows = False
            Me.dgwGrillaNombresAsociados.AllowUserToResizeRows = False
            Me.dgwGrillaNombresAsociados.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaNombresAsociados.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaNombresAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaNombresAsociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_num, Me.col_int_id, Me.col_nom_aso_id, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_fec_reg_na})
            Me.dgwGrillaNombresAsociados.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.dgwGrillaNombresAsociados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
            Me.dgwGrillaNombresAsociados.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaNombresAsociados.Location = New System.Drawing.Point(0, 50)
            Me.dgwGrillaNombresAsociados.MultiSelect = False
            Me.dgwGrillaNombresAsociados.Name = "dgwGrillaNombresAsociados"
            Me.dgwGrillaNombresAsociados.ReadOnly = True
            Me.dgwGrillaNombresAsociados.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaNombresAsociados.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaNombresAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaNombresAsociados.Size = New System.Drawing.Size(386, 94)
            Me.dgwGrillaNombresAsociados.TabIndex = 1
            Me.dgwGrillaNombresAsociados.VisibleCampos = False
            '
            'col_int_num
            '
            Me.col_int_num.DividerWidth = 1
            Me.col_int_num.HeaderText = "Nº"
            Me.col_int_num.Name = "col_int_num"
            Me.col_int_num.ReadOnly = True
            Me.col_int_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_int_num.Width = 23
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "CodigoInterno"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_int_id.Visible = False
            Me.col_int_id.Width = 70
            '
            'col_nom_aso_id
            '
            Me.col_nom_aso_id.DataPropertyName = "Codigo"
            Me.col_nom_aso_id.DividerWidth = 1
            Me.col_nom_aso_id.HeaderText = "NombreAsociadoId"
            Me.col_nom_aso_id.Name = "col_nom_aso_id"
            Me.col_nom_aso_id.ReadOnly = True
            Me.col_nom_aso_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nom_aso_id.Visible = False
            Me.col_nom_aso_id.Width = 50
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.HeaderText = "Primer Apellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ape_pat.Width = 110
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ape_mat.Width = 110
            '
            'col_nom
            '
            Me.col_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'col_fec_reg_na
            '
            Me.col_fec_reg_na.DataPropertyName = "FechaRegNomAsoDate"
            Me.col_fec_reg_na.HeaderText = "Fec.Registro"
            Me.col_fec_reg_na.Name = "col_fec_reg_na"
            Me.col_fec_reg_na.ReadOnly = True
            Me.col_fec_reg_na.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fec_reg_na.Visible = False
            Me.col_fec_reg_na.Width = 70
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.grpTipovalidacion)
            Me.Panel1.Controls.Add(Me.dgwGrillaNombresAsociados)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(386, 144)
            Me.Panel1.TabIndex = 47
            '
            'frmTipoValidacionV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(386, 190)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmTipoValidacionV2"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Validacion de identidad con RENIEC"
            Me.grpTipovalidacion.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgwGrillaNombresAsociados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents rdbDni As System.Windows.Forms.RadioButton
        Friend WithEvents rdbNombreprincipal As System.Windows.Forms.RadioButton
        Friend WithEvents grpTipovalidacion As System.Windows.Forms.GroupBox
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents rdbNombresAsociados As System.Windows.Forms.RadioButton
        Friend WithEvents dgwGrillaNombresAsociados As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents col_int_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom_aso_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_reg_na As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbNofigura As System.Windows.Forms.RadioButton

    End Class

End Namespace