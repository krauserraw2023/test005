Namespace Load
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmLoad
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.PictureBox1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(102, 74)
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Image = Global.APPControls.My.Resources.Resources.cargandov3
            Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(102, 74)
            Me.PictureBox1.TabIndex = 2
            Me.PictureBox1.TabStop = False
            '
            'frmLoad
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(102, 74)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "frmLoad"
            Me.Text = "frmEsperaPopup"
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    End Class
End Namespace

