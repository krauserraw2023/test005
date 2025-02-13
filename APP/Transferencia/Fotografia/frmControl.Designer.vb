Namespace Transferencia.Fotografia


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmControl
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControl))
            Me.dgwControl = New System.Windows.Forms.DataGridView()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_exi = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_fal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fot_dan = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            CType(Me.dgwControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.cbbRegion.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwControl
            '
            Me.dgwControl.AllowUserToAddRows = False
            Me.dgwControl.AllowUserToDeleteRows = False
            Me.dgwControl.BackgroundColor = System.Drawing.Color.White
            Me.dgwControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwControl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id, Me.col_pen_nom, Me.Column7, Me.col_fot_exi, Me.col_fot_fal, Me.col_fot_dan, Me.col_sen})
            Me.dgwControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwControl.Location = New System.Drawing.Point(0, 60)
            Me.dgwControl.MultiSelect = False
            Me.dgwControl.Name = "dgwControl"
            Me.dgwControl.RowHeadersVisible = False
            Me.dgwControl.RowHeadersWidth = 20
            Me.dgwControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwControl.Size = New System.Drawing.Size(973, 372)
            Me.dgwControl.TabIndex = 3
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Width = 35
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
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.HeaderText = "PenalID"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_pen_nom
            '
            Me.col_pen_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "CantidadRegistro"
            Me.Column7.HeaderText = "C.F.R."
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.ToolTipText = "Cantidad de fotos registradas"
            Me.Column7.Width = 50
            '
            'col_fot_exi
            '
            Me.col_fot_exi.DataPropertyName = "CantFotosExistentes"
            Me.col_fot_exi.HeaderText = "C.F.E."
            Me.col_fot_exi.Name = "col_fot_exi"
            Me.col_fot_exi.ReadOnly = True
            Me.col_fot_exi.ToolTipText = "Cantidad de fotos existentes"
            Me.col_fot_exi.Width = 50
            '
            'col_fot_fal
            '
            Me.col_fot_fal.DataPropertyName = "CantFotosFaltantes"
            Me.col_fot_fal.HeaderText = "C.F.F."
            Me.col_fot_fal.Name = "col_fot_fal"
            Me.col_fot_fal.ReadOnly = True
            Me.col_fot_fal.ToolTipText = "Cantidad de fotos faltantes"
            Me.col_fot_fal.Width = 50
            '
            'col_fot_dan
            '
            Me.col_fot_dan.DataPropertyName = "CantFotosDanadas"
            Me.col_fot_dan.HeaderText = "C.F.D."
            Me.col_fot_dan.Name = "col_fot_dan"
            Me.col_fot_dan.ReadOnly = True
            Me.col_fot_dan.ToolTipText = "Cantidad de fotos dañadas"
            Me.col_fot_dan.Width = 50
            '
            'col_sen
            '
            Me.col_sen.DataPropertyName = "FechayHora"
            Me.col_sen.HeaderText = "Fecha y Hora"
            Me.col_sen.Name = "col_sen"
            Me.col_sen.ReadOnly = True
            Me.col_sen.ToolTipText = "Sentenciados"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(973, 60)
            Me.GroupBox1.TabIndex = 7
            Me.GroupBox1.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.cbbRegion)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(967, 41)
            Me.Panel1.TabIndex = 10
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 53
            Me.Label1.Text = "Region :"
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = CType(37, Short)
            Me.cbbRegion.Controls.Add(Me.ComboBox1)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(62, 9)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(227, 22)
            Me.cbbRegion.TabIndex = 52
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 178
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(227, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 432)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(973, 65)
            Me.Panel2.TabIndex = 63
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnActualizar)
            Me.Panel3.Controls.Add(Me.btnSalir)
            Me.Panel3.Controls.Add(Me.btnExportar)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(703, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(270, 65)
            Me.Panel3.TabIndex = 67
            '
            'btnActualizar
            '
            Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnActualizar.Location = New System.Drawing.Point(3, 6)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(84, 53)
            Me.btnActualizar.TabIndex = 67
            Me.btnActualizar.Text = "&Actualizar"
            Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnActualizar.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(178, 6)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 53)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(88, 6)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(84, 53)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'frmControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(973, 497)
            Me.Controls.Add(Me.dgwControl)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "frmControl"
            Me.Text = "Control de Fotografias"
            CType(Me.dgwControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.cbbRegion.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwControl As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents col_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fot_exi As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fot_fal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fot_dan As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sen As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace