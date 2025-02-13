Namespace Foto
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscFotografia
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.pnlFotoVis = New System.Windows.Forms.Panel()
            Me.pbFoto = New System.Windows.Forms.PictureBox()
            Me.lblAutorizado = New System.Windows.Forms.Label()
            Me.pnlCheck = New System.Windows.Forms.Panel()
            Me.chkVerFoto = New System.Windows.Forms.CheckBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlFotoVis.SuspendLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCheck.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlFotoVis
            '
            Me.pnlFotoVis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlFotoVis.Controls.Add(Me.pbFoto)
            Me.pnlFotoVis.Controls.Add(Me.lblAutorizado)
            Me.pnlFotoVis.Controls.Add(Me.pnlCheck)
            Me.pnlFotoVis.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlFotoVis.Location = New System.Drawing.Point(0, 0)
            Me.pnlFotoVis.Name = "pnlFotoVis"
            Me.pnlFotoVis.Size = New System.Drawing.Size(150, 190)
            Me.pnlFotoVis.TabIndex = 22
            '
            'pbFoto
            '
            Me.pbFoto.BackColor = System.Drawing.Color.White
            Me.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbFoto.Image = Global.APPControls.My.Resources.Resources.sin_foto
            Me.pbFoto.Location = New System.Drawing.Point(0, 40)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(146, 146)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbFoto.TabIndex = 19
            Me.pbFoto.TabStop = False
            '
            'lblAutorizado
            '
            Me.lblAutorizado.BackColor = System.Drawing.Color.Red
            Me.lblAutorizado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblAutorizado.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblAutorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAutorizado.ForeColor = System.Drawing.Color.White
            Me.lblAutorizado.Location = New System.Drawing.Point(0, 20)
            Me.lblAutorizado.Name = "lblAutorizado"
            Me.lblAutorizado.Size = New System.Drawing.Size(146, 20)
            Me.lblAutorizado.TabIndex = 21
            Me.lblAutorizado.Text = "NO AUTORIZADO"
            Me.lblAutorizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblAutorizado.Visible = False
            '
            'pnlCheck
            '
            Me.pnlCheck.Controls.Add(Me.chkVerFoto)
            Me.pnlCheck.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCheck.Location = New System.Drawing.Point(0, 0)
            Me.pnlCheck.Name = "pnlCheck"
            Me.pnlCheck.Size = New System.Drawing.Size(146, 20)
            Me.pnlCheck.TabIndex = 68
            '
            'chkVerFoto
            '
            Me.chkVerFoto.AutoSize = True
            Me.chkVerFoto.Checked = True
            Me.chkVerFoto.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkVerFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chkVerFoto.Location = New System.Drawing.Point(0, 0)
            Me.chkVerFoto.Name = "chkVerFoto"
            Me.chkVerFoto.Size = New System.Drawing.Size(146, 20)
            Me.chkVerFoto.TabIndex = 67
            Me.chkVerFoto.Text = "Ver Fotografia"
            Me.chkVerFoto.UseVisualStyleBackColor = True
            '
            'ToolTip1
            '
            Me.ToolTip1.ShowAlways = True
            '
            'uscFotografia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlFotoVis)
            Me.Name = "uscFotografia"
            Me.Size = New System.Drawing.Size(150, 190)
            Me.pnlFotoVis.ResumeLayout(False)
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCheck.ResumeLayout(False)
            Me.pnlCheck.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlFotoVis As System.Windows.Forms.Panel
        Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
        Friend WithEvents lblAutorizado As System.Windows.Forms.Label
        Friend WithEvents chkVerFoto As System.Windows.Forms.CheckBox
        Friend WithEvents pnlCheck As System.Windows.Forms.Panel
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    End Class
End Namespace

