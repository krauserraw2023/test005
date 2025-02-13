Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVerificarSesion
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
            Me.components = New System.ComponentModel.Container()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtClave = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtUsuarioLogin = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 55)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 13)
            Me.Label3.TabIndex = 192
            Me.Label3.Text = "Contraseña :"
            '
            'txtClave
            '
            Me.txtClave._BloquearPaste = False
            Me.txtClave._SeleccionarTodo = False
            Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtClave.Location = New System.Drawing.Point(91, 50)
            Me.txtClave.MaxLength = 50
            Me.txtClave.Name = "txtClave"
            Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtClave.Size = New System.Drawing.Size(153, 22)
            Me.txtClave.TabIndex = 193
            Me.txtClave.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtClave.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.txtClave.UseSystemPasswordChar = True
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.txtUsuarioLogin)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtClave)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(257, 81)
            Me.GroupBox1.TabIndex = 197
            Me.GroupBox1.TabStop = False
            '
            'txtUsuarioLogin
            '
            Me.txtUsuarioLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUsuarioLogin.Location = New System.Drawing.Point(91, 17)
            Me.txtUsuarioLogin.MaxLength = 50
            Me.txtUsuarioLogin.Name = "txtUsuarioLogin"
            Me.txtUsuarioLogin.ReadOnly = True
            Me.txtUsuarioLogin.Size = New System.Drawing.Size(153, 22)
            Me.txtUsuarioLogin.TabIndex = 199
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 22)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(49, 13)
            Me.Label4.TabIndex = 198
            Me.Label4.Text = "Usuario :"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(67, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(61, 40)
            Me.btnSalir.TabIndex = 199
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(4, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(61, 40)
            Me.btnOk.TabIndex = 198
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOk.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 86)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(257, 46)
            Me.Panel1.TabIndex = 200
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(123, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(134, 46)
            Me.Panel2.TabIndex = 201
            '
            'frmVerificarSesion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(257, 132)
            Me.ControlBox = False
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmVerificarSesion"
            Me.ShowInTaskbar = False
            Me.Text = "Verificacion de dos pasos..."
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtClave As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents txtUsuarioLogin As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel

    End Class
End Namespace

