<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscVisorDocDigital
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.dgwGrilla = New System.Windows.Forms.DataGridView()
        Me.col_ver = New System.Windows.Forms.DataGridViewImageColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num_ing_inp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ing_inp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlIzqAdd = New System.Windows.Forms.Panel()
        Me.btnDelImgDig = New System.Windows.Forms.Button()
        Me.btnEditImgDig = New System.Windows.Forms.Button()
        Me.btnAddImgDig = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIzqAdd.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwGrilla
        '
        Me.dgwGrilla.AllowUserToAddRows = False
        Me.dgwGrilla.AllowUserToDeleteRows = False
        Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
        Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ver, Me.col_id, Me.col_num_ing, Me.col_ing_id, Me.col_num_ing_inp, Me.col_ing_inp_id, Me.col_titulo, Me.col_fec_reg})
        Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwGrilla.Location = New System.Drawing.Point(0, 32)
        Me.dgwGrilla.MultiSelect = False
        Me.dgwGrilla.Name = "dgwGrilla"
        Me.dgwGrilla.ReadOnly = True
        Me.dgwGrilla.RowHeadersVisible = False
        Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwGrilla.Size = New System.Drawing.Size(200, 579)
        Me.dgwGrilla.TabIndex = 1
        '
        'col_ver
        '
        Me.col_ver.HeaderText = ""
        Me.col_ver.Image = Global.APPControls.My.Resources.Resources.pdf_18x24
        Me.col_ver.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.col_ver.MinimumWidth = 20
        Me.col_ver.Name = "col_ver"
        Me.col_ver.ReadOnly = True
        Me.col_ver.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_ver.ToolTipText = "Ver archivo pdf"
        Me.col_ver.Width = 20
        '
        'col_id
        '
        Me.col_id.DataPropertyName = "Codigo"
        Me.col_id.HeaderText = "col_id"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        Me.col_id.Width = 20
        '
        'col_num_ing
        '
        Me.col_num_ing.DataPropertyName = "NumeroIngreso"
        Me.col_num_ing.HeaderText = "N° Ing."
        Me.col_num_ing.Name = "col_num_ing"
        Me.col_num_ing.ReadOnly = True
        Me.col_num_ing.Width = 30
        '
        'col_ing_id
        '
        Me.col_ing_id.DataPropertyName = "IngresoId"
        Me.col_ing_id.HeaderText = "col_ing_id"
        Me.col_ing_id.Name = "col_ing_id"
        Me.col_ing_id.ReadOnly = True
        Me.col_ing_id.Visible = False
        '
        'col_num_ing_inp
        '
        Me.col_num_ing_inp.DataPropertyName = "IngresoNroInpe"
        Me.col_num_ing_inp.HeaderText = "N° Ing."
        Me.col_num_ing_inp.Name = "col_num_ing_inp"
        Me.col_num_ing_inp.ReadOnly = True
        Me.col_num_ing_inp.Width = 30
        '
        'col_ing_inp_id
        '
        Me.col_ing_inp_id.DataPropertyName = "IngresoInpeId"
        Me.col_ing_inp_id.HeaderText = "col_ing_inp_id"
        Me.col_ing_inp_id.Name = "col_ing_inp_id"
        Me.col_ing_inp_id.ReadOnly = True
        Me.col_ing_inp_id.Visible = False
        '
        'col_titulo
        '
        Me.col_titulo.DataPropertyName = "TituloDoc"
        Me.col_titulo.HeaderText = "Titulo Doc."
        Me.col_titulo.Name = "col_titulo"
        Me.col_titulo.ReadOnly = True
        Me.col_titulo.Width = 150
        '
        'col_fec_reg
        '
        Me.col_fec_reg.DataPropertyName = "FechaRegistroDate"
        Me.col_fec_reg.HeaderText = "F. Registro"
        Me.col_fec_reg.Name = "col_fec_reg"
        Me.col_fec_reg.ReadOnly = True
        Me.col_fec_reg.Width = 72
        '
        'pnlIzqAdd
        '
        Me.pnlIzqAdd.Controls.Add(Me.btnDelImgDig)
        Me.pnlIzqAdd.Controls.Add(Me.btnEditImgDig)
        Me.pnlIzqAdd.Controls.Add(Me.btnAddImgDig)
        Me.pnlIzqAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlIzqAdd.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzqAdd.Name = "pnlIzqAdd"
        Me.pnlIzqAdd.Size = New System.Drawing.Size(200, 32)
        Me.pnlIzqAdd.TabIndex = 0
        '
        'btnDelImgDig
        '
        Me.btnDelImgDig.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
        Me.btnDelImgDig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDelImgDig.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelImgDig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelImgDig.Location = New System.Drawing.Point(60, 0)
        Me.btnDelImgDig.Name = "btnDelImgDig"
        Me.btnDelImgDig.Size = New System.Drawing.Size(30, 32)
        Me.btnDelImgDig.TabIndex = 95
        Me.btnDelImgDig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnEditImgDig
        '
        Me.btnEditImgDig.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
        Me.btnEditImgDig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditImgDig.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditImgDig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditImgDig.Location = New System.Drawing.Point(30, 0)
        Me.btnEditImgDig.Name = "btnEditImgDig"
        Me.btnEditImgDig.Size = New System.Drawing.Size(30, 32)
        Me.btnEditImgDig.TabIndex = 90
        Me.btnEditImgDig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnAddImgDig
        '
        Me.btnAddImgDig.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
        Me.btnAddImgDig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddImgDig.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddImgDig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddImgDig.Location = New System.Drawing.Point(0, 0)
        Me.btnAddImgDig.Name = "btnAddImgDig"
        Me.btnAddImgDig.Size = New System.Drawing.Size(30, 32)
        Me.btnAddImgDig.TabIndex = 88
        Me.btnAddImgDig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 25)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(793, 586)
        Me.WebBrowser1.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(793, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.APPControls.My.Resources.Resources.pdf_18x24
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 20
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Ver archivo pdf"
        Me.DataGridViewImageColumn1.Width = 40
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgwGrilla)
        Me.Panel1.Controls.Add(Me.pnlIzqAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 611)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 611)
        Me.Panel2.TabIndex = 5
        '
        'uscVisorDocDigital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uscVisorDocDigital"
        Me.Size = New System.Drawing.Size(993, 611)
        CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIzqAdd.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents pnlIzqAdd As System.Windows.Forms.Panel
    Friend WithEvents btnDelImgDig As System.Windows.Forms.Button
    Friend WithEvents btnEditImgDig As System.Windows.Forms.Button
    Friend WithEvents btnAddImgDig As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents col_ver As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_num_ing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_num_ing_inp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_ing_inp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
