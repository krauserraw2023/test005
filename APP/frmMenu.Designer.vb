<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.lblTituloMenu = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.pbClave = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtIP = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.txtFecIng = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.txtPerfil = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.txtEsta = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.txtDepen = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.txtApeNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.txtLogin = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlMenu = New System.Windows.Forms.Panel
        Me.pnlDerecho = New System.Windows.Forms.Panel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbClave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.pnlDerecho.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(152, 324)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblTituloMenu
        '
        Me.lblTituloMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTituloMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloMenu.Location = New System.Drawing.Point(3, 8)
        Me.lblTituloMenu.Name = "lblTituloMenu"
        Me.lblTituloMenu.Size = New System.Drawing.Size(516, 26)
        Me.lblTituloMenu.TabIndex = 2
        Me.lblTituloMenu.Text = "Sistema Integral Penitenciario"
        Me.lblTituloMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTituloMenu)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(522, 37)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pbClave)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.txtIP)
        Me.GroupBox4.Controls.Add(Me.txtFecIng)
        Me.GroupBox4.Controls.Add(Me.txtPerfil)
        Me.GroupBox4.Controls.Add(Me.txtEsta)
        Me.GroupBox4.Controls.Add(Me.txtDepen)
        Me.GroupBox4.Controls.Add(Me.txtApeNom)
        Me.GroupBox4.Controls.Add(Me.txtLogin)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 365)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(522, 154)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'pbClave
        '
        Me.pbClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbClave.Image = Global.SIPPOPE.My.Resources.Resources.Key_32
        Me.pbClave.Location = New System.Drawing.Point(353, 13)
        Me.pbClave.Name = "pbClave"
        Me.pbClave.Size = New System.Drawing.Size(39, 43)
        Me.pbClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbClave.TabIndex = 15
        Me.pbClave.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.SIPPOPE.My.Resources.Resources.sin_foto
        Me.PictureBox1.Location = New System.Drawing.Point(394, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'txtIP
        '
        Me.txtIP._SeleccionarTodo = False
        Me.txtIP.Location = New System.Drawing.Point(286, 129)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.ReadOnly = True
        Me.txtIP.Size = New System.Drawing.Size(102, 20)
        Me.txtIP.TabIndex = 13
        Me.txtIP.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtIP.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'txtFecIng
        '
        Me.txtFecIng._SeleccionarTodo = False
        Me.txtFecIng.Location = New System.Drawing.Point(90, 129)
        Me.txtFecIng.Name = "txtFecIng"
        Me.txtFecIng.ReadOnly = True
        Me.txtFecIng.Size = New System.Drawing.Size(83, 20)
        Me.txtFecIng.TabIndex = 12
        Me.txtFecIng.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtFecIng.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'txtPerfil
        '
        Me.txtPerfil._SeleccionarTodo = False
        Me.txtPerfil.Location = New System.Drawing.Point(90, 106)
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.ReadOnly = True
        Me.txtPerfil.Size = New System.Drawing.Size(298, 20)
        Me.txtPerfil.TabIndex = 11
        Me.txtPerfil.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtPerfil.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'txtEsta
        '
        Me.txtEsta._SeleccionarTodo = False
        Me.txtEsta.Location = New System.Drawing.Point(90, 82)
        Me.txtEsta.Name = "txtEsta"
        Me.txtEsta.ReadOnly = True
        Me.txtEsta.Size = New System.Drawing.Size(298, 20)
        Me.txtEsta.TabIndex = 10
        Me.txtEsta.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtEsta.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'txtDepen
        '
        Me.txtDepen._SeleccionarTodo = False
        Me.txtDepen.Location = New System.Drawing.Point(90, 59)
        Me.txtDepen.Name = "txtDepen"
        Me.txtDepen.ReadOnly = True
        Me.txtDepen.Size = New System.Drawing.Size(298, 20)
        Me.txtDepen.TabIndex = 9
        Me.txtDepen.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtDepen.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'txtApeNom
        '
        Me.txtApeNom._SeleccionarTodo = False
        Me.txtApeNom.BackColor = System.Drawing.SystemColors.Control
        Me.txtApeNom.Location = New System.Drawing.Point(90, 36)
        Me.txtApeNom.Name = "txtApeNom"
        Me.txtApeNom.ReadOnly = True
        Me.txtApeNom.Size = New System.Drawing.Size(260, 20)
        Me.txtApeNom.TabIndex = 8
        Me.txtApeNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtApeNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'txtLogin
        '
        Me.txtLogin._SeleccionarTodo = False
        Me.txtLogin.Location = New System.Drawing.Point(90, 13)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.ReadOnly = True
        Me.txtLogin.Size = New System.Drawing.Size(83, 20)
        Me.txtLogin.TabIndex = 7
        Me.txtLogin.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtLogin.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "IP Maquina :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha Ingreso :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Perfil :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ubicacion :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Area / Oficina :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ap. Nombres :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario :"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMenu.Controls.Add(Me.pnlDerecho)
        Me.pnlMenu.Controls.Add(Me.ToolStrip2)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(0, 37)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(522, 328)
        Me.pnlMenu.TabIndex = 5
        '
        'pnlDerecho
        '
        Me.pnlDerecho.Controls.Add(Me.ToolStrip1)
        Me.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDerecho.Location = New System.Drawing.Point(366, 0)
        Me.pnlDerecho.Name = "pnlDerecho"
        Me.pnlDerecho.Size = New System.Drawing.Size(152, 324)
        Me.pnlDerecho.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 2, 20, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(366, 324)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip3"
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 519)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Integral Penitenciario - Regiones - Junio 2010"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pbClave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlDerecho.ResumeLayout(False)
        Me.pnlDerecho.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTituloMenu As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtIP As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtFecIng As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtPerfil As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtEsta As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtDepen As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtApeNom As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtLogin As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlDerecho As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbClave As System.Windows.Forms.PictureBox
End Class
