Namespace Seguridad
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscarPC
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarPC))
            Me.dgwGrilla = New System.Windows.Forms.DataGridView
            Me.col_pc_id = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.Panel2 = New System.Windows.Forms.Panel
            Me.btnSalir = New System.Windows.Forms.Button
            Me.btnEliminar = New System.Windows.Forms.Button
            Me.btnModificar = New System.Windows.Forms.Button
            Me.btnNuevo = New System.Windows.Forms.Button
            Me.pnlBusqueda = New System.Windows.Forms.Panel
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.txtResp = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtSerialHD = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtMac = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtIp = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtHostName = New System.Windows.Forms.TextBox
            Me.Label26 = New System.Windows.Forms.Label
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.lblReg = New System.Windows.Forms.Label
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToOrderColumns = True
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pc_id, Me.DataGridViewTextBoxColumn12, Me.Column2, Me.Column3, Me.Column1, Me.Column4})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 112)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(616, 241)
            Me.dgwGrilla.TabIndex = 41
            '
            'col_pc_id
            '
            Me.col_pc_id.DataPropertyName = "Codigo"
            Me.col_pc_id.HeaderText = "PCID"
            Me.col_pc_id.Name = "col_pc_id"
            Me.col_pc_id.ReadOnly = True
            Me.col_pc_id.Visible = False
            '
            'DataGridViewTextBoxColumn12
            '
            Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.DataGridViewTextBoxColumn12.DataPropertyName = "HostName"
            Me.DataGridViewTextBoxColumn12.HeaderText = "HostName"
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            Me.DataGridViewTextBoxColumn12.ReadOnly = True
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "IP"
            Me.Column2.HeaderText = "IP"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "MAC"
            Me.Column3.HeaderText = "MAC"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "SerialHD"
            Me.Column1.HeaderText = "SerialHD"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 80
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "Responsable"
            Me.Column4.HeaderText = "Responsable Pc."
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 150
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Controls.Add(Me.btnEliminar)
            Me.Panel2.Controls.Add(Me.btnModificar)
            Me.Panel2.Controls.Add(Me.btnNuevo)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 353)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(616, 66)
            Me.Panel2.TabIndex = 42
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(285, 10)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 53)
            Me.btnSalir.TabIndex = 6
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(191, 10)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(88, 53)
            Me.btnEliminar.TabIndex = 2
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.Location = New System.Drawing.Point(97, 10)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(88, 53)
            Me.btnModificar.TabIndex = 1
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.SIPPOPE.My.Resources.Resources._1277961158_folder_new
            Me.btnNuevo.Location = New System.Drawing.Point(3, 10)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 53)
            Me.btnNuevo.TabIndex = 0
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox3)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(616, 112)
            Me.pnlBusqueda.TabIndex = 45
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtResp)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtSerialHD)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtMac)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtIp)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtHostName)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(533, 112)
            Me.GroupBox1.TabIndex = 43
            Me.GroupBox1.TabStop = False
            '
            'txtResp
            '
            Me.txtResp.Location = New System.Drawing.Point(330, 42)
            Me.txtResp.Name = "txtResp"
            Me.txtResp.Size = New System.Drawing.Size(185, 20)
            Me.txtResp.TabIndex = 49
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(231, 45)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 50
            Me.Label4.Text = "Responsable PC. :"
            '
            'txtSerialHD
            '
            Me.txtSerialHD.Location = New System.Drawing.Point(330, 16)
            Me.txtSerialHD.Name = "txtSerialHD"
            Me.txtSerialHD.Size = New System.Drawing.Size(185, 20)
            Me.txtSerialHD.TabIndex = 47
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(231, 18)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 13)
            Me.Label3.TabIndex = 48
            Me.Label3.Text = "Serial H.D. :"
            '
            'txtMac
            '
            Me.txtMac.Location = New System.Drawing.Point(74, 68)
            Me.txtMac.Name = "txtMac"
            Me.txtMac.Size = New System.Drawing.Size(138, 20)
            Me.txtMac.TabIndex = 45
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 71)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(36, 13)
            Me.Label2.TabIndex = 46
            Me.Label2.Text = "MAC :"
            '
            'txtIp
            '
            Me.txtIp.Location = New System.Drawing.Point(74, 42)
            Me.txtIp.Name = "txtIp"
            Me.txtIp.Size = New System.Drawing.Size(138, 20)
            Me.txtIp.TabIndex = 43
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 45)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(23, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "IP :"
            '
            'txtHostName
            '
            Me.txtHostName.Location = New System.Drawing.Point(74, 16)
            Me.txtHostName.Name = "txtHostName"
            Me.txtHostName.Size = New System.Drawing.Size(138, 20)
            Me.txtHostName.TabIndex = 41
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(5, 19)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(63, 13)
            Me.Label26.TabIndex = 42
            Me.Label26.Text = "HostName :"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.lblReg)
            Me.GroupBox3.Controls.Add(Me.ToolStrip1)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox3.Location = New System.Drawing.Point(533, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(83, 112)
            Me.GroupBox3.TabIndex = 39
            Me.GroupBox3.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Location = New System.Drawing.Point(10, 84)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(64, 22)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 93)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(75, 43)
            Me.tsbBuscar.Text = "Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'frmBuscarPC
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(616, 419)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscarPC"
            Me.Text = "Busqueda de PC."
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.pnlBusqueda.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtIp As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtHostName As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents txtResp As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtSerialHD As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMac As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents col_pc_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace

