
Namespace Seguridad
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPCDatosPopup
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
            Me.txtHostname = New System.Windows.Forms.TextBox
            Me.lblIp = New System.Windows.Forms.Label
            Me.lblMac = New System.Windows.Forms.Label
            Me.lblHost = New System.Windows.Forms.Label
            Me.lblSerial = New System.Windows.Forms.Label
            Me.txtIP = New System.Windows.Forms.TextBox
            Me.txtMAC = New System.Windows.Forms.TextBox
            Me.txtSerialHD = New System.Windows.Forms.TextBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.txtObs = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.btnSalir = New System.Windows.Forms.Button
            Me.btnCorreo = New System.Windows.Forms.Button
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtHostname
            '
            Me.txtHostname.Location = New System.Drawing.Point(80, 13)
            Me.txtHostname.Name = "txtHostname"
            Me.txtHostname.ReadOnly = True
            Me.txtHostname.Size = New System.Drawing.Size(152, 20)
            Me.txtHostname.TabIndex = 0
            '
            'lblIp
            '
            Me.lblIp.AutoSize = True
            Me.lblIp.Location = New System.Drawing.Point(6, 42)
            Me.lblIp.Name = "lblIp"
            Me.lblIp.Size = New System.Drawing.Size(23, 13)
            Me.lblIp.TabIndex = 1
            Me.lblIp.Text = "IP :"
            '
            'lblMac
            '
            Me.lblMac.AutoSize = True
            Me.lblMac.Location = New System.Drawing.Point(6, 71)
            Me.lblMac.Name = "lblMac"
            Me.lblMac.Size = New System.Drawing.Size(36, 13)
            Me.lblMac.TabIndex = 2
            Me.lblMac.Text = "MAC :"
            '
            'lblHost
            '
            Me.lblHost.AutoSize = True
            Me.lblHost.Location = New System.Drawing.Point(6, 18)
            Me.lblHost.Name = "lblHost"
            Me.lblHost.Size = New System.Drawing.Size(63, 13)
            Me.lblHost.TabIndex = 3
            Me.lblHost.Text = "HostName :"
            '
            'lblSerial
            '
            Me.lblSerial.AutoSize = True
            Me.lblSerial.Location = New System.Drawing.Point(6, 97)
            Me.lblSerial.Name = "lblSerial"
            Me.lblSerial.Size = New System.Drawing.Size(58, 13)
            Me.lblSerial.TabIndex = 4
            Me.lblSerial.Text = "Serial HD :"
            '
            'txtIP
            '
            Me.txtIP.Location = New System.Drawing.Point(80, 39)
            Me.txtIP.Name = "txtIP"
            Me.txtIP.ReadOnly = True
            Me.txtIP.Size = New System.Drawing.Size(152, 20)
            Me.txtIP.TabIndex = 5
            '
            'txtMAC
            '
            Me.txtMAC.Location = New System.Drawing.Point(80, 64)
            Me.txtMAC.Name = "txtMAC"
            Me.txtMAC.ReadOnly = True
            Me.txtMAC.Size = New System.Drawing.Size(152, 20)
            Me.txtMAC.TabIndex = 6
            '
            'txtSerialHD
            '
            Me.txtSerialHD.Location = New System.Drawing.Point(80, 90)
            Me.txtSerialHD.Name = "txtSerialHD"
            Me.txtSerialHD.ReadOnly = True
            Me.txtSerialHD.Size = New System.Drawing.Size(152, 20)
            Me.txtSerialHD.TabIndex = 7
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtObs)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtSerialHD)
            Me.GroupBox1.Controls.Add(Me.txtMAC)
            Me.GroupBox1.Controls.Add(Me.txtIP)
            Me.GroupBox1.Controls.Add(Me.lblSerial)
            Me.GroupBox1.Controls.Add(Me.lblHost)
            Me.GroupBox1.Controls.Add(Me.lblMac)
            Me.GroupBox1.Controls.Add(Me.lblIp)
            Me.GroupBox1.Controls.Add(Me.txtHostname)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(244, 205)
            Me.GroupBox1.TabIndex = 49
            Me.GroupBox1.TabStop = False
            '
            'txtObs
            '
            Me.txtObs.Location = New System.Drawing.Point(9, 137)
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(223, 62)
            Me.txtObs.TabIndex = 9
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 121)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(84, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Observaciones :"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(167, 223)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(89, 40)
            Me.btnSalir.TabIndex = 51
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnCorreo
            '
            Me.btnCorreo.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCorreo.Image = Global.SIPPOPE.My.Resources.Resources.mail_32x32
            Me.btnCorreo.Location = New System.Drawing.Point(12, 223)
            Me.btnCorreo.Name = "btnCorreo"
            Me.btnCorreo.Size = New System.Drawing.Size(115, 40)
            Me.btnCorreo.TabIndex = 50
            Me.btnCorreo.Text = "&Enviar por Correo"
            Me.btnCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmPCDatosPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(269, 269)
            Me.Controls.Add(Me.btnSalir)
            Me.Controls.Add(Me.btnCorreo)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPCDatosPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Datos de la Pc."
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtHostname As System.Windows.Forms.TextBox
        Friend WithEvents lblIp As System.Windows.Forms.Label
        Friend WithEvents lblMac As System.Windows.Forms.Label
        Friend WithEvents lblHost As System.Windows.Forms.Label
        Friend WithEvents lblSerial As System.Windows.Forms.Label
        Friend WithEvents txtIP As System.Windows.Forms.TextBox
        Friend WithEvents txtMAC As System.Windows.Forms.TextBox
        Friend WithEvents txtSerialHD As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnCorreo As System.Windows.Forms.Button
        Friend WithEvents txtObs As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnSalir As System.Windows.Forms.Button

    End Class
End Namespace

