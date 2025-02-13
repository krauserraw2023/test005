Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEnviarCorreo
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtAsunto = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkAdjunto = New System.Windows.Forms.CheckBox()
            Me.txtCorreoPara = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.txtPathArchivo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 70)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 13)
            Me.Label3.TabIndex = 192
            Me.Label3.Text = "Mensaje;"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.txtPathArchivo)
            Me.GroupBox1.Controls.Add(Me.txtAsunto)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.chkAdjunto)
            Me.GroupBox1.Controls.Add(Me.txtCorreoPara)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.RichTextBox1)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(463, 339)
            Me.GroupBox1.TabIndex = 197
            Me.GroupBox1.TabStop = False
            '
            'txtAsunto
            '
            Me.txtAsunto._BloquearPaste = False
            Me.txtAsunto._SeleccionarTodo = False
            Me.txtAsunto.Location = New System.Drawing.Point(63, 19)
            Me.txtAsunto.Name = "txtAsunto"
            Me.txtAsunto.Size = New System.Drawing.Size(269, 20)
            Me.txtAsunto.TabIndex = 202
            Me.txtAsunto.Text = "Creacion/Restauracion de cuenta de usuario"
            Me.txtAsunto.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAsunto.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 13)
            Me.Label1.TabIndex = 201
            Me.Label1.Text = "Asunto :"
            '
            'chkAdjunto
            '
            Me.chkAdjunto.AutoSize = True
            Me.chkAdjunto.Location = New System.Drawing.Point(13, 285)
            Me.chkAdjunto.Name = "chkAdjunto"
            Me.chkAdjunto.Size = New System.Drawing.Size(132, 17)
            Me.chkAdjunto.TabIndex = 200
            Me.chkAdjunto.Text = "Enviar archivo adjunto"
            Me.chkAdjunto.UseVisualStyleBackColor = True
            '
            'txtCorreoPara
            '
            Me.txtCorreoPara._BloquearPaste = False
            Me.txtCorreoPara._SeleccionarTodo = False
            Me.txtCorreoPara.Location = New System.Drawing.Point(63, 45)
            Me.txtCorreoPara.Name = "txtCorreoPara"
            Me.txtCorreoPara.Size = New System.Drawing.Size(269, 20)
            Me.txtCorreoPara.TabIndex = 199
            Me.txtCorreoPara.Text = "jmondalgo@inpe.gob.pe"
            Me.txtCorreoPara.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCorreoPara.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 48)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(35, 13)
            Me.Label4.TabIndex = 198
            Me.Label4.Text = "Para :"
            '
            'RichTextBox1
            '
            Me.RichTextBox1.Location = New System.Drawing.Point(13, 86)
            Me.RichTextBox1.Name = "RichTextBox1"
            Me.RichTextBox1.Size = New System.Drawing.Size(437, 193)
            Me.RichTextBox1.TabIndex = 203
            Me.RichTextBox1.Text = ""
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(370, 357)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(105, 40)
            Me.btnSalir.TabIndex = 199
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(262, 357)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(105, 40)
            Me.btnOk.TabIndex = 198
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOk.UseVisualStyleBackColor = True
            '
            'txtPathArchivo
            '
            Me.txtPathArchivo._BloquearPaste = False
            Me.txtPathArchivo._SeleccionarTodo = False
            Me.txtPathArchivo.Enabled = False
            Me.txtPathArchivo.Location = New System.Drawing.Point(13, 308)
            Me.txtPathArchivo.Name = "txtPathArchivo"
            Me.txtPathArchivo.Size = New System.Drawing.Size(437, 20)
            Me.txtPathArchivo.TabIndex = 204
            Me.txtPathArchivo.Text = "D:\Desarrollo\DEV\SIP_POPE\Doc\replicar_usuario.png"
            Me.txtPathArchivo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPathArchivo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'frmEnviarCorreo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(487, 405)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnSalir)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmEnviarCorreo"
            Me.ShowInTaskbar = False
            Me.Text = "Enviar correo a usuario"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents chkAdjunto As System.Windows.Forms.CheckBox
        Friend WithEvents txtCorreoPara As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAsunto As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
        Friend WithEvents txtPathArchivo As Legolas.APPUIComponents.MyTextBox

    End Class
End Namespace

