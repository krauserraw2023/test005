<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioSesion_v2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents pbClave As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grbAmbiente = New System.Windows.Forms.GroupBox()
        Me.rdbDesarrollo = New System.Windows.Forms.RadioButton()
        Me.rdbProduccion = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsuario = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.txtPassword = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pbClave = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar2 = New System.Windows.Forms.Button()
        Me.pnlValidadorHuella = New System.Windows.Forms.Panel()
        Me.UscAutenticacionDactilar1 = New APPControls.uscAutenticacionDactilar()
        Me.btnIngresar2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.grbAmbiente.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlValidadorHuella.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Location = New System.Drawing.Point(264, 86)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(49, 13)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Usuario :"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Location = New System.Drawing.Point(264, 135)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(40, 13)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Clave :"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(286, 202)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 30)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Ingresar"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(379, 202)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 30)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 50)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "SISTEMA INTEGRAL PENITENCIARIO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.grbAmbiente)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 92)
        Me.Panel1.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(0, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(468, 3)
        Me.Label5.TabIndex = 16
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbAmbiente
        '
        Me.grbAmbiente.Controls.Add(Me.rdbDesarrollo)
        Me.grbAmbiente.Controls.Add(Me.rdbProduccion)
        Me.grbAmbiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAmbiente.Location = New System.Drawing.Point(373, 8)
        Me.grbAmbiente.Name = "grbAmbiente"
        Me.grbAmbiente.Size = New System.Drawing.Size(105, 70)
        Me.grbAmbiente.TabIndex = 20
        Me.grbAmbiente.TabStop = False
        Me.grbAmbiente.Text = "Ambiente"
        Me.grbAmbiente.Visible = False
        '
        'rdbDesarrollo
        '
        Me.rdbDesarrollo.AutoSize = True
        Me.rdbDesarrollo.Checked = True
        Me.rdbDesarrollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDesarrollo.Location = New System.Drawing.Point(6, 46)
        Me.rdbDesarrollo.Name = "rdbDesarrollo"
        Me.rdbDesarrollo.Size = New System.Drawing.Size(72, 17)
        Me.rdbDesarrollo.TabIndex = 1
        Me.rdbDesarrollo.TabStop = True
        Me.rdbDesarrollo.Text = "Desarrollo"
        Me.rdbDesarrollo.UseVisualStyleBackColor = True
        '
        'rdbProduccion
        '
        Me.rdbProduccion.AutoSize = True
        Me.rdbProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProduccion.Location = New System.Drawing.Point(6, 23)
        Me.rdbProduccion.Name = "rdbProduccion"
        Me.rdbProduccion.Size = New System.Drawing.Size(79, 17)
        Me.rdbProduccion.TabIndex = 0
        Me.rdbProduccion.Text = "Produccion"
        Me.rdbProduccion.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SIPPOPE.My.Resources.Resources.logo_inpe
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(488, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(109, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Contacto: mesadeayuda@inpe.gob.pe"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtUsuario._BloquearPaste = False
        Me.txtUsuario._SeleccionarTodo = False
        Me.txtUsuario.Location = New System.Drawing.Point(266, 105)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(206, 20)
        Me.txtUsuario.TabIndex = 18
        Me.txtUsuario.Text = "demo"
        Me.txtUsuario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
        Me.txtUsuario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
        '
        'txtPassword
        '
        Me.txtPassword._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPassword._BloquearPaste = False
        Me.txtPassword._SeleccionarTodo = False
        Me.txtPassword.Location = New System.Drawing.Point(266, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(206, 20)
        Me.txtPassword.TabIndex = 19
        Me.txtPassword.Text = "123"
        Me.txtPassword.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtPassword.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 4)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Actualizar usuario"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbClave
        '
        Me.pbClave.BackColor = System.Drawing.Color.Transparent
        Me.pbClave.Image = Global.SIPPOPE.My.Resources.Resources.sip_02
        Me.pbClave.Location = New System.Drawing.Point(-25, -6)
        Me.pbClave.Name = "pbClave"
        Me.pbClave.Size = New System.Drawing.Size(301, 241)
        Me.pbClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClave.TabIndex = 0
        Me.pbClave.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 328)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 24)
        Me.Panel2.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(468, 3)
        Me.Label1.TabIndex = 17
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtUsuario)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.UsernameLabel)
        Me.Panel3.Controls.Add(Me.Cancel)
        Me.Panel3.Controls.Add(Me.OK)
        Me.Panel3.Controls.Add(Me.PasswordLabel)
        Me.Panel3.Controls.Add(Me.pbClave)
        Me.Panel3.Location = New System.Drawing.Point(0, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(485, 234)
        Me.Panel3.TabIndex = 23
        '
        'btnCancelar2
        '
        Me.btnCancelar2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar2.Location = New System.Drawing.Point(379, 200)
        Me.btnCancelar2.Name = "btnCancelar2"
        Me.btnCancelar2.Size = New System.Drawing.Size(94, 30)
        Me.btnCancelar2.TabIndex = 6
        Me.btnCancelar2.Text = "&Cancelar"
        '
        'pnlValidadorHuella
        '
        Me.pnlValidadorHuella.Controls.Add(Me.UscAutenticacionDactilar1)
        Me.pnlValidadorHuella.Controls.Add(Me.btnCancelar2)
        Me.pnlValidadorHuella.Controls.Add(Me.btnIngresar2)
        Me.pnlValidadorHuella.Location = New System.Drawing.Point(0, 94)
        Me.pnlValidadorHuella.Name = "pnlValidadorHuella"
        Me.pnlValidadorHuella.Size = New System.Drawing.Size(485, 231)
        Me.pnlValidadorHuella.TabIndex = 24
        Me.pnlValidadorHuella.Visible = False
        '
        'UscAutenticacionDactilar1
        '
        Me.UscAutenticacionDactilar1.BackColor = System.Drawing.SystemColors.Control
        Me.UscAutenticacionDactilar1.Location = New System.Drawing.Point(2, 2)
        Me.UscAutenticacionDactilar1.Name = "UscAutenticacionDactilar1"
        Me.UscAutenticacionDactilar1.Size = New System.Drawing.Size(479, 198)
        Me.UscAutenticacionDactilar1.TabIndex = 7
        '
        'btnIngresar2
        '
        Me.btnIngresar2.Location = New System.Drawing.Point(286, 200)
        Me.btnIngresar2.Name = "btnIngresar2"
        Me.btnIngresar2.Size = New System.Drawing.Size(94, 30)
        Me.btnIngresar2.TabIndex = 5
        Me.btnIngresar2.Text = "&Ingresar"
        '
        'frmInicioSesion_v2
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.fondo_degrade
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(468, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlValidadorHuella)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicioSesion_v2"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesi�n..."
        Me.Panel1.ResumeLayout(False)
        Me.grbAmbiente.ResumeLayout(False)
        Me.grbAmbiente.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlValidadorHuella.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents txtPassword As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents grbAmbiente As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDesarrollo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProduccion As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelar2 As Button
    Friend WithEvents pnlValidadorHuella As Panel
    Friend WithEvents UscAutenticacionDactilar1 As APPControls.uscAutenticacionDactilar
    Friend WithEvents btnIngresar2 As Button
End Class
