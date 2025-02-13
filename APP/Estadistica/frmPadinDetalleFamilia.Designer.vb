Namespace Estadistica


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPadinDetalleFamilia
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadinDetalleFamilia))
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtRegion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCuadro15 = New System.Windows.Forms.Button()
            Me.btnCuadro14 = New System.Windows.Forms.Button()
            Me.btnReporteF1 = New System.Windows.Forms.Button()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnExportar = New System.Windows.Forms.Button()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_reg_id, Me.col_reg_nom, Me.col_pen_id})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 40)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(936, 348)
            Me.dgwGrilla.TabIndex = 40
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.DividerWidth = 1
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 75
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "PenalCodigo"
            Me.col_reg_id.DividerWidth = 1
            Me.col_reg_id.HeaderText = "Codigo E.P."
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Width = 50
            '
            'col_reg_nom
            '
            Me.col_reg_nom.DataPropertyName = "InternoNumeroDocumento"
            Me.col_reg_nom.HeaderText = "Doc. Personal"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            Me.col_reg_nom.ToolTipText = "Documento personal (D.N.I.)"
            Me.col_reg_nom.Width = 75
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "InternoApellidosyNombres"
            Me.col_pen_id.DividerWidth = 1
            Me.col_pen_id.HeaderText = "Apellidos y Nombres"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Width = 250
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtRegion)
            Me.GroupBox1.Controls.Add(Me.txtPenal)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(936, 40)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            '
            'txtRegion
            '
            Me.txtRegion._BloquearPaste = False
            Me.txtRegion._SeleccionarTodo = False
            Me.txtRegion.Location = New System.Drawing.Point(57, 12)
            Me.txtRegion.Name = "txtRegion"
            Me.txtRegion.ReadOnly = True
            Me.txtRegion.Size = New System.Drawing.Size(218, 20)
            Me.txtRegion.TabIndex = 4
            Me.txtRegion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtPenal
            '
            Me.txtPenal._BloquearPaste = False
            Me.txtPenal._SeleccionarTodo = False
            Me.txtPenal.Location = New System.Drawing.Point(333, 12)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.ReadOnly = True
            Me.txtPenal.Size = New System.Drawing.Size(218, 20)
            Me.txtPenal.TabIndex = 5
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(5, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Region :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(287, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Penal :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCuadro15)
            Me.Panel2.Controls.Add(Me.btnCuadro14)
            Me.Panel2.Controls.Add(Me.btnReporteF1)
            Me.Panel2.Controls.Add(Me.lblReg)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Controls.Add(Me.btnExportar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 388)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(936, 49)
            Me.Panel2.TabIndex = 41
            '
            'btnCuadro15
            '
            Me.btnCuadro15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCuadro15.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnCuadro15.Location = New System.Drawing.Point(309, 4)
            Me.btnCuadro15.Name = "btnCuadro15"
            Me.btnCuadro15.Size = New System.Drawing.Size(97, 40)
            Me.btnCuadro15.TabIndex = 72
            Me.btnCuadro15.Text = "Cuadro 15"
            Me.btnCuadro15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCuadro15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCuadro15.UseVisualStyleBackColor = True
            '
            'btnCuadro14
            '
            Me.btnCuadro14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCuadro14.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnCuadro14.Location = New System.Drawing.Point(206, 4)
            Me.btnCuadro14.Name = "btnCuadro14"
            Me.btnCuadro14.Size = New System.Drawing.Size(97, 40)
            Me.btnCuadro14.TabIndex = 71
            Me.btnCuadro14.Text = "Cuadro 14"
            Me.btnCuadro14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCuadro14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCuadro14.UseVisualStyleBackColor = True
            '
            'btnReporteF1
            '
            Me.btnReporteF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporteF1.Image = Global.SIPPOPE.My.Resources.Resources.Distributor_report_32
            Me.btnReporteF1.Location = New System.Drawing.Point(103, 4)
            Me.btnReporteF1.Name = "btnReporteF1"
            Me.btnReporteF1.Size = New System.Drawing.Size(97, 40)
            Me.btnReporteF1.TabIndex = 67
            Me.btnReporteF1.Text = "Reporte F1"
            Me.btnReporteF1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporteF1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporteF1.UseVisualStyleBackColor = True
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Right
            Me.lblReg.Location = New System.Drawing.Point(879, 0)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(57, 49)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(412, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 40)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(9, 4)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'frmPadinDetalleFamilia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(936, 437)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "frmPadinDetalleFamilia"
            Me.Text = "frmBuscar"
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnReporteF1 As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents txtRegion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnCuadro15 As System.Windows.Forms.Button
        Friend WithEvents btnCuadro14 As System.Windows.Forms.Button
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace