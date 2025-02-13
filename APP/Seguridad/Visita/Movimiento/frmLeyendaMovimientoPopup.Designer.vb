Namespace Visita.Movimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmLeyendaMovimientoPopup
        Inherits Legolas.APPUIComponents.Form

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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgwIngresaPor = New Legolas.APPUIComponents.myDatagridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgwSalePor = New Legolas.APPUIComponents.myDatagridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_apenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgwIngresaPor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgwSalePor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.dgwIngresaPor)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(263, 242)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label4.Location = New System.Drawing.Point(3, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(257, 13)
            Me.Label4.TabIndex = 198
            Me.Label4.Text = "Ingresa por:"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(3, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(105, 40)
            Me.btnSalir.TabIndex = 199
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dgwIngresaPor
            '
            Me.dgwIngresaPor.AllowUserToAddRows = False
            Me.dgwIngresaPor.AllowUserToDeleteRows = False
            Me.dgwIngresaPor.AllowUserToResizeRows = False
            Me.dgwIngresaPor.BackgroundColor = System.Drawing.Color.White
            Me.dgwIngresaPor.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwIngresaPor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwIngresaPor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_vis_apenom})
            Me.dgwIngresaPor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwIngresaPor.Location = New System.Drawing.Point(3, 29)
            Me.dgwIngresaPor.Name = "dgwIngresaPor"
            Me.dgwIngresaPor.ReadOnly = True
            Me.dgwIngresaPor.RowHeadersVisible = False
            Me.dgwIngresaPor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwIngresaPor.Size = New System.Drawing.Size(257, 210)
            Me.dgwIngresaPor.TabIndex = 199
            Me.dgwIngresaPor.VisibleCampos = False
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.dgwSalePor)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Location = New System.Drawing.Point(290, 4)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(263, 242)
            Me.GroupBox2.TabIndex = 200
            Me.GroupBox2.TabStop = False
            '
            'dgwSalePor
            '
            Me.dgwSalePor.AllowUserToAddRows = False
            Me.dgwSalePor.AllowUserToDeleteRows = False
            Me.dgwSalePor.AllowUserToResizeRows = False
            Me.dgwSalePor.BackgroundColor = System.Drawing.Color.White
            Me.dgwSalePor.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwSalePor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwSalePor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
            Me.dgwSalePor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwSalePor.Location = New System.Drawing.Point(3, 29)
            Me.dgwSalePor.Name = "dgwSalePor"
            Me.dgwSalePor.ReadOnly = True
            Me.dgwSalePor.RowHeadersVisible = False
            Me.dgwSalePor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwSalePor.Size = New System.Drawing.Size(257, 210)
            Me.dgwSalePor.TabIndex = 199
            Me.dgwSalePor.VisibleCampos = False
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "MovimientoID"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "VisitanteApellidosyNombres"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Location = New System.Drawing.Point(3, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(257, 13)
            Me.Label1.TabIndex = 198
            Me.Label1.Text = "Sale por:"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 257)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(570, 47)
            Me.Panel1.TabIndex = 201
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(453, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(117, 47)
            Me.Panel2.TabIndex = 0
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "MovimientoID"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Width = 55
            '
            'col_vis_apenom
            '
            Me.col_vis_apenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_vis_apenom.DataPropertyName = "VisitanteApellidosyNombres"
            Me.col_vis_apenom.HeaderText = "Descripcion"
            Me.col_vis_apenom.Name = "col_vis_apenom"
            Me.col_vis_apenom.ReadOnly = True
            Me.col_vis_apenom.Width = 185
            '
            'frmDesbloquearHuella
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(570, 304)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDesbloquearHuella"
            Me.ShowInTaskbar = False
            Me.Text = "Leyenda..."
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgwIngresaPor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgwSalePor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dgwIngresaPor As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwSalePor As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_apenom As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace

