Namespace Registro.Reniec


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDetalleNombresAsociadosPoput
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleNombresAsociadosPoput))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dgwGrillaNombresAsociados = New Legolas.APPUIComponents.myDatagridView()
            Me.col_int_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_aso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_reg_na = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgwGrillaNombresAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 184)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(451, 46)
            Me.Panel2.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(368, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.dgwGrillaNombresAsociados)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(451, 184)
            Me.Panel1.TabIndex = 47
            '
            'dgwGrillaNombresAsociados
            '
            Me.dgwGrillaNombresAsociados.AllowUserToAddRows = False
            Me.dgwGrillaNombresAsociados.AllowUserToDeleteRows = False
            Me.dgwGrillaNombresAsociados.AllowUserToResizeRows = False
            Me.dgwGrillaNombresAsociados.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaNombresAsociados.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaNombresAsociados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaNombresAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaNombresAsociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_num, Me.col_int_id, Me.col_nom_aso_id, Me.col_ape_pat, Me.col_ape_mat, Me.col_nom, Me.col_fec_reg_na})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaNombresAsociados.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillaNombresAsociados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaNombresAsociados.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaNombresAsociados.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrillaNombresAsociados.MultiSelect = False
            Me.dgwGrillaNombresAsociados.Name = "dgwGrillaNombresAsociados"
            Me.dgwGrillaNombresAsociados.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaNombresAsociados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrillaNombresAsociados.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaNombresAsociados.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrillaNombresAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaNombresAsociados.Size = New System.Drawing.Size(451, 184)
            Me.dgwGrillaNombresAsociados.TabIndex = 0
            Me.dgwGrillaNombresAsociados.VisibleCampos = False
            '
            'col_int_num
            '
            Me.col_int_num.DividerWidth = 1
            Me.col_int_num.HeaderText = "Nº"
            Me.col_int_num.Name = "col_int_num"
            Me.col_int_num.ReadOnly = True
            Me.col_int_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_int_num.Width = 30
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "Codigo"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "CodigoInterno"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_int_id.Visible = False
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
            Me.col_nom_aso_id.Width = 70
            '
            'col_ape_pat
            '
            Me.col_ape_pat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.HeaderText = "PrimerApellido"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ape_mat.Width = 130
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nom.Width = 140
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
            'frmDetalleNombresAsociadosPoput
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(451, 230)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDetalleNombresAsociadosPoput"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Detalle de Nombres asociados"
            Me.Panel2.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgwGrillaNombresAsociados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents dgwGrillaNombresAsociados As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_int_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom_aso_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_reg_na As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnSalir As System.Windows.Forms.Button

    End Class

End Namespace