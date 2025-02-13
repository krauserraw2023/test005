Namespace Mantenimiento.Reporte
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmCuadro2Popup_v2
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox4_ = New System.Windows.Forms.GroupBox()
            Me.lblGrillaCount = New System.Windows.Forms.Label()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnAddPenal = New System.Windows.Forms.Button()
            Me.txtDelEsp = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDelGene = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cap_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox4_.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox4_
            '
            Me.GroupBox4_.Controls.Add(Me.lblGrillaCount)
            Me.GroupBox4_.Controls.Add(Me.btnExportar)
            Me.GroupBox4_.Controls.Add(Me.btnAddPenal)
            Me.GroupBox4_.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox4_.Location = New System.Drawing.Point(0, 61)
            Me.GroupBox4_.Name = "GroupBox4_"
            Me.GroupBox4_.Size = New System.Drawing.Size(740, 54)
            Me.GroupBox4_.TabIndex = 54
            Me.GroupBox4_.TabStop = False
            '
            'lblGrillaCount
            '
            Me.lblGrillaCount.AutoSize = True
            Me.lblGrillaCount.Location = New System.Drawing.Point(113, 37)
            Me.lblGrillaCount.Name = "lblGrillaCount"
            Me.lblGrillaCount.Size = New System.Drawing.Size(45, 13)
            Me.lblGrillaCount.TabIndex = 90
            Me.lblGrillaCount.Text = "0 Reg. :"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(6, 10)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(101, 40)
            Me.btnExportar.TabIndex = 73
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnAddPenal
            '
            Me.btnAddPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddPenal.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddPenal.Location = New System.Drawing.Point(642, 10)
            Me.btnAddPenal.Name = "btnAddPenal"
            Me.btnAddPenal.Size = New System.Drawing.Size(94, 40)
            Me.btnAddPenal.TabIndex = 89
            Me.btnAddPenal.Text = "Agregar"
            Me.btnAddPenal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'txtDelEsp
            '
            Me.txtDelEsp._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelEsp._BloquearPaste = False
            Me.txtDelEsp._SeleccionarTodo = False
            Me.txtDelEsp.Location = New System.Drawing.Point(125, 38)
            Me.txtDelEsp.Name = "txtDelEsp"
            Me.txtDelEsp.ReadOnly = True
            Me.txtDelEsp.Size = New System.Drawing.Size(523, 20)
            Me.txtDelEsp.TabIndex = 50
            Me.txtDelEsp.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelEsp.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDelGene
            '
            Me.txtDelGene._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelGene._BloquearPaste = False
            Me.txtDelGene._SeleccionarTodo = False
            Me.txtDelGene.Location = New System.Drawing.Point(125, 12)
            Me.txtDelGene.Name = "txtDelGene"
            Me.txtDelGene.ReadOnly = True
            Me.txtDelGene.Size = New System.Drawing.Size(523, 20)
            Me.txtDelGene.TabIndex = 49
            Me.txtDelGene.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelGene.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 41)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(94, 13)
            Me.Label1.TabIndex = 48
            Me.Label1.Text = "Grupo Especifico :"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(12, 15)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(88, 13)
            Me.Label26.TabIndex = 47
            Me.Label26.Text = "Grupo Generico :"
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Location = New System.Drawing.Point(6, 5)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(15, 14)
            Me.chkTodos.TabIndex = 6
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.col_id, Me.col_art, Me.col_del_esp_id, Me.col_del_esp, Me.col_del_gen, Me.col_cap_nom, Me.col_sec, Me.Column1})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(740, 361)
            Me.dgwGrilla.TabIndex = 4
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Width = 25
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 25
            '
            'col_art
            '
            Me.col_art.DataPropertyName = "Articulo"
            Me.col_art.HeaderText = "Articulo"
            Me.col_art.Name = "col_art"
            Me.col_art.ReadOnly = True
            Me.col_art.Width = 45
            '
            'col_del_esp_id
            '
            Me.col_del_esp_id.DataPropertyName = "IDDelitoEspecifico"
            Me.col_del_esp_id.HeaderText = "DelitoEspecificoID"
            Me.col_del_esp_id.Name = "col_del_esp_id"
            Me.col_del_esp_id.ReadOnly = True
            Me.col_del_esp_id.Visible = False
            Me.col_del_esp_id.Width = 25
            '
            'col_del_esp
            '
            Me.col_del_esp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_del_esp.DataPropertyName = "NombreEspecifico"
            Me.col_del_esp.HeaderText = "Delito Especifico"
            Me.col_del_esp.Name = "col_del_esp"
            Me.col_del_esp.ReadOnly = True
            '
            'col_del_gen
            '
            Me.col_del_gen.DataPropertyName = "Generico"
            Me.col_del_gen.HeaderText = "Titulo"
            Me.col_del_gen.Name = "col_del_gen"
            Me.col_del_gen.ReadOnly = True
            Me.col_del_gen.Width = 165
            '
            'col_cap_nom
            '
            Me.col_cap_nom.DataPropertyName = "Capitulo"
            Me.col_cap_nom.HeaderText = "Capitulo"
            Me.col_cap_nom.Name = "col_cap_nom"
            Me.col_cap_nom.ReadOnly = True
            '
            'col_sec
            '
            Me.col_sec.DataPropertyName = "Seccion"
            Me.col_sec.HeaderText = "Seccion"
            Me.col_sec.Name = "col_sec"
            Me.col_sec.ReadOnly = True
            Me.col_sec.Width = 55
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "EstadoNombre"
            Me.Column1.HeaderText = "Estado"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel4)
            Me.Panel2.Controls.Add(Me.btnEliminar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 476)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(740, 45)
            Me.Panel2.TabIndex = 57
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnOk)
            Me.Panel4.Controls.Add(Me.btnCancel)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel4.Location = New System.Drawing.Point(538, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(202, 45)
            Me.Panel4.TabIndex = 50
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 45
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(101, 2)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 46
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(5, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(96, 40)
            Me.btnEliminar.TabIndex = 49
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtDelEsp)
            Me.GroupBox4.Controls.Add(Me.txtDelGene)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.Label26)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(740, 61)
            Me.GroupBox4.TabIndex = 58
            Me.GroupBox4.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Panel1)
            Me.Panel3.Controls.Add(Me.GroupBox4_)
            Me.Panel3.Controls.Add(Me.GroupBox4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(740, 476)
            Me.Panel3.TabIndex = 59
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.chkTodos)
            Me.Panel1.Controls.Add(Me.dgwGrilla)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 115)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(740, 361)
            Me.Panel1.TabIndex = 90
            '
            'frmCuadro2Popup_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(740, 521)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCuadro2Popup_v2"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Reporte - Cuadro 2 - Detalle"
            Me.GroupBox4_.ResumeLayout(False)
            Me.GroupBox4_.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents GroupBox4_ As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents txtDelEsp As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDelGene As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents btnAddPenal As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents btnExportar As Button
        Friend WithEvents lblGrillaCount As Label
        Friend WithEvents col_chk As DataGridViewCheckBoxColumn
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_art As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp As DataGridViewTextBoxColumn
        Friend WithEvents col_del_gen As DataGridViewTextBoxColumn
        Friend WithEvents col_cap_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_sec As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
    End Class
End Namespace

