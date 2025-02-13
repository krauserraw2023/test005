Namespace Registro
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ReporteCrystal_v2
        Inherits System.Windows.Forms.Form

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
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportarPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuExportarVarios = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'CrystalReportViewer1
            '
            Me.CrystalReportViewer1.ActiveViewIndex = -1
            Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
            Me.CrystalReportViewer1.DisplayStatusBar = False
            Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CrystalReportViewer1.EnableDrillDown = False
            Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
            Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
            Me.CrystalReportViewer1.ShowCopyButton = False
            Me.CrystalReportViewer1.ShowExportButton = False
            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowLogo = False
            Me.CrystalReportViewer1.ShowParameterPanelButton = False
            Me.CrystalReportViewer1.ShowPrintButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False
            Me.CrystalReportViewer1.ShowTextSearchButton = False
            Me.CrystalReportViewer1.Size = New System.Drawing.Size(976, 437)
            Me.CrystalReportViewer1.TabIndex = 5
            Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'SalirToolStripMenuItem
            '
            Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
            Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
            Me.SalirToolStripMenuItem.Text = "&Salir"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(976, 24)
            Me.MenuStrip1.TabIndex = 6
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ArchivoToolStripMenuItem
            '
            Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem, Me.ExportarPDFToolStripMenuItem, Me.mnuExportarVarios})
            Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
            Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
            Me.ArchivoToolStripMenuItem.Text = "Archivo"
            '
            'ImprimirToolStripMenuItem
            '
            Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
            Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.ImprimirToolStripMenuItem.Text = "Imprimir"
            '
            'ExportarPDFToolStripMenuItem
            '
            Me.ExportarPDFToolStripMenuItem.Name = "ExportarPDFToolStripMenuItem"
            Me.ExportarPDFToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.ExportarPDFToolStripMenuItem.Text = "Exportar PDF"
            '
            'mnuExportarVarios
            '
            Me.mnuExportarVarios.Name = "mnuExportarVarios"
            Me.mnuExportarVarios.Size = New System.Drawing.Size(180, 22)
            Me.mnuExportarVarios.Text = "Exportar"
            Me.mnuExportarVarios.Visible = False
            '
            'ReporteCrystal_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(976, 461)
            Me.Controls.Add(Me.CrystalReportViewer1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Name = "ReporteCrystal_v2"
            Me.Text = "ReporteCrystal_v2"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ExportarPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuExportarVarios As ToolStripMenuItem
    End Class
End Namespace