
Namespace Seguridad.PC
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPCPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPCPopup))
            Me.dgwGrilla = New System.Windows.Forms.DataGridView
            Me.col_pc_id = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.col_hos_nam = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.col_mac = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pc_id, Me.col_hos_nam, Me.col_mac, Me.Column1, Me.Column2})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 148)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(518, 209)
            Me.dgwGrilla.TabIndex = 46
            '
            'col_pc_id
            '
            Me.col_pc_id.DataPropertyName = "Codigo"
            Me.col_pc_id.HeaderText = "PCID"
            Me.col_pc_id.Name = "col_pc_id"
            Me.col_pc_id.ReadOnly = True
            Me.col_pc_id.Visible = False
            '
            'col_hos_nam
            '
            Me.col_hos_nam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_hos_nam.DataPropertyName = "HostName"
            Me.col_hos_nam.HeaderText = "HostName"
            Me.col_hos_nam.Name = "col_hos_nam"
            Me.col_hos_nam.ReadOnly = True
            '
            'col_mac
            '
            Me.col_mac.DataPropertyName = "MAC"
            Me.col_mac.HeaderText = "MAC"
            Me.col_mac.Name = "col_mac"
            Me.col_mac.ReadOnly = True
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "SerialHD"
            Me.Column1.HeaderText = "Serial HD"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "Responsable"
            Me.Column2.HeaderText = "Responsable"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 200
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
            Me.pnlBusqueda.Controls.Add(Me.GroupBox3)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(518, 148)
            Me.pnlBusqueda.TabIndex = 47
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
            Me.GroupBox1.Size = New System.Drawing.Size(435, 148)
            Me.GroupBox1.TabIndex = 43
            Me.GroupBox1.TabStop = False
            '
            'txtResp
            '
            Me.txtResp.Location = New System.Drawing.Point(106, 120)
            Me.txtResp.Name = "txtResp"
            Me.txtResp.Size = New System.Drawing.Size(138, 20)
            Me.txtResp.TabIndex = 49
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 123)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 50
            Me.Label4.Text = "Responsable PC. :"
            '
            'txtSerialHD
            '
            Me.txtSerialHD.Location = New System.Drawing.Point(106, 94)
            Me.txtSerialHD.Name = "txtSerialHD"
            Me.txtSerialHD.Size = New System.Drawing.Size(138, 20)
            Me.txtSerialHD.TabIndex = 47
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 96)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 13)
            Me.Label3.TabIndex = 48
            Me.Label3.Text = "Serial H.D. :"
            '
            'txtMac
            '
            Me.txtMac.Location = New System.Drawing.Point(106, 68)
            Me.txtMac.Name = "txtMac"
            Me.txtMac.Size = New System.Drawing.Size(138, 20)
            Me.txtMac.TabIndex = 45
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 70)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(36, 13)
            Me.Label2.TabIndex = 46
            Me.Label2.Text = "MAC :"
            '
            'txtIp
            '
            Me.txtIp.Location = New System.Drawing.Point(106, 42)
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
            Me.txtHostName.Location = New System.Drawing.Point(106, 16)
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
            Me.GroupBox3.Location = New System.Drawing.Point(435, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(83, 148)
            Me.GroupBox3.TabIndex = 39
            Me.GroupBox3.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Location = New System.Drawing.Point(6, 120)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(71, 22)
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
            Me.ToolStrip1.Size = New System.Drawing.Size(77, 129)
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
            'frmPCPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(518, 357)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPCPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "PC"
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtResp As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtSerialHD As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMac As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtIp As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtHostName As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents col_pc_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hos_nam As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mac As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace

