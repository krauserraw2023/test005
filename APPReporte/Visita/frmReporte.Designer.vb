Namespace Visita
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReporte
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
            Me.components = New System.ComponentModel.Container()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Timer1
            '
            '
            'BackgroundWorker1
            '
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(427, 24)
            Me.MenuStrip1.TabIndex = 1
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ArchivoToolStripMenuItem
            '
            Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
            Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
            Me.ArchivoToolStripMenuItem.Text = "Archivo"
            '
            'SalirToolStripMenuItem
            '
            Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
            Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
            Me.SalirToolStripMenuItem.Text = "Salir"
            '
            'ReportViewer1
            '
            Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ReportViewer1.DocumentMapWidth = 85
            Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
            Me.ReportViewer1.Name = "ReportViewer1"
            Me.ReportViewer1.Size = New System.Drawing.Size(427, 380)
            Me.ReportViewer1.TabIndex = 2
            '
            'frmReporte
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(427, 404)
            Me.Controls.Add(Me.ReportViewer1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "frmReporte"
            Me.Text = "frmReporte"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
        'Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    End Class
End Namespace

