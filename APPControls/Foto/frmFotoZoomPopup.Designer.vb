Namespace Foto
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmFotoZoomPopup
        Inherits Legolas.APPUIComponents.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.ptbZoom = New System.Windows.Forms.PictureBox
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.lblSize = New System.Windows.Forms.Label
            CType(Me.ptbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ptbZoom
            '
            Me.ptbZoom.BackColor = System.Drawing.Color.Transparent
            Me.ptbZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.ptbZoom.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ptbZoom.Location = New System.Drawing.Point(0, 0)
            Me.ptbZoom.Name = "ptbZoom"
            Me.ptbZoom.Size = New System.Drawing.Size(318, 449)
            Me.ptbZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.ptbZoom.TabIndex = 0
            Me.ptbZoom.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.lblSize)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 449)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(318, 30)
            Me.Panel1.TabIndex = 1
            '
            'lblSize
            '
            Me.lblSize.AutoSize = True
            Me.lblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSize.Location = New System.Drawing.Point(12, 8)
            Me.lblSize.Name = "lblSize"
            Me.lblSize.Size = New System.Drawing.Size(106, 13)
            Me.lblSize.TabIndex = 1
            Me.lblSize.Text = "Ancho 0 por Alto "
            '
            'frmFotoZoomPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(318, 479)
            Me.Controls.Add(Me.ptbZoom)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmFotoZoomPopup"
            Me.Text = "Zoom"
            CType(Me.ptbZoom, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ptbZoom As System.Windows.Forms.PictureBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblSize As System.Windows.Forms.Label
    End Class
End Namespace