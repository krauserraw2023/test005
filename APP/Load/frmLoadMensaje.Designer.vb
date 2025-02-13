Namespace Load
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmLoadMensaje
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
            Me.lblMensaje = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'lblMensaje
            '
            Me.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMensaje.Location = New System.Drawing.Point(0, 0)
            Me.lblMensaje.Name = "lblMensaje"
            Me.lblMensaje.Size = New System.Drawing.Size(474, 89)
            Me.lblMensaje.TabIndex = 3
            Me.lblMensaje.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registro de ingreso satisfactorio..."
            Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(474, 20)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "MENSAJE"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'frmLoadMensaje
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ScrollBar
            Me.ClientSize = New System.Drawing.Size(474, 89)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblMensaje)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "frmLoadMensaje"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Conectando..."
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblMensaje As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace

