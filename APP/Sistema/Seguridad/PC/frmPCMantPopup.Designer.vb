
Namespace Seguridad
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPCMantPopup
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
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtIP = New System.Windows.Forms.TextBox
            Me.txtMAC = New System.Windows.Forms.TextBox
            Me.txtSerialHD = New System.Windows.Forms.TextBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.txtObs = New System.Windows.Forms.TextBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.txtResp = New System.Windows.Forms.TextBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.btnCancel = New System.Windows.Forms.Button
            Me.bntOk = New System.Windows.Forms.Button
            Me.btnPc = New System.Windows.Forms.Button
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtHostname
            '
            Me.txtHostname.Location = New System.Drawing.Point(80, 13)
            Me.txtHostname.Name = "txtHostname"
            Me.txtHostname.Size = New System.Drawing.Size(223, 20)
            Me.txtHostname.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 42)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(23, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "IP :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 68)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(36, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "MAC :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 16)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(63, 13)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "HostName :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 93)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(58, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Serial HD :"
            '
            'txtIP
            '
            Me.txtIP.Location = New System.Drawing.Point(80, 39)
            Me.txtIP.Name = "txtIP"
            Me.txtIP.Size = New System.Drawing.Size(223, 20)
            Me.txtIP.TabIndex = 5
            '
            'txtMAC
            '
            Me.txtMAC.Location = New System.Drawing.Point(80, 64)
            Me.txtMAC.Name = "txtMAC"
            Me.txtMAC.Size = New System.Drawing.Size(223, 20)
            Me.txtMAC.TabIndex = 6
            '
            'txtSerialHD
            '
            Me.txtSerialHD.Location = New System.Drawing.Point(80, 90)
            Me.txtSerialHD.Name = "txtSerialHD"
            Me.txtSerialHD.Size = New System.Drawing.Size(223, 20)
            Me.txtSerialHD.TabIndex = 7
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtObs)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtResp)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtSerialHD)
            Me.GroupBox1.Controls.Add(Me.txtMAC)
            Me.GroupBox1.Controls.Add(Me.txtIP)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtHostname)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(310, 231)
            Me.GroupBox1.TabIndex = 49
            Me.GroupBox1.TabStop = False
            '
            'txtObs
            '
            Me.txtObs.Location = New System.Drawing.Point(9, 161)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(294, 59)
            Me.txtObs.TabIndex = 11
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 145)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(73, 13)
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Observacion :"
            '
            'txtResp
            '
            Me.txtResp.Location = New System.Drawing.Point(80, 116)
            Me.txtResp.Name = "txtResp"
            Me.txtResp.Size = New System.Drawing.Size(223, 20)
            Me.txtResp.TabIndex = 9
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 121)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(58, 13)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Resp. PC :"
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(228, 249)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 54
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'bntOk
            '
            Me.bntOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.bntOk.Location = New System.Drawing.Point(130, 249)
            Me.bntOk.Name = "bntOk"
            Me.bntOk.Size = New System.Drawing.Size(94, 40)
            Me.bntOk.TabIndex = 53
            Me.bntOk.Text = "&OK"
            Me.bntOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnPc
            '
            Me.btnPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPc.Image = Global.SIPPOPE.My.Resources.Resources.Computer1_32
            Me.btnPc.Location = New System.Drawing.Point(12, 249)
            Me.btnPc.Name = "btnPc"
            Me.btnPc.Size = New System.Drawing.Size(101, 40)
            Me.btnPc.TabIndex = 50
            Me.btnPc.Text = "Registrar PC."
            Me.btnPc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmPCMantPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(332, 295)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.bntOk)
            Me.Controls.Add(Me.btnPc)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPCMantPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Datos de la Pc."
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtHostname As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtIP As System.Windows.Forms.TextBox
        Friend WithEvents txtMAC As System.Windows.Forms.TextBox
        Friend WithEvents txtSerialHD As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtObs As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtResp As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnPc As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents bntOk As System.Windows.Forms.Button

    End Class
End Namespace

