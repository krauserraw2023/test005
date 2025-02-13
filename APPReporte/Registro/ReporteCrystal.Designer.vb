Namespace Registro

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ReporteCrystal
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ImpirmirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportarPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuExportarVarios = New System.Windows.Forms.ToolStripMenuItem()
            Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'CrystalReportViewer1
            '
            Me.CrystalReportViewer1.ActiveViewIndex = -1
            Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
            Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CrystalReportViewer1.EnableDrillDown = False
            Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
            Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
            Me.CrystalReportViewer1.ShowCopyButton = False
            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowLogo = False
            Me.CrystalReportViewer1.ShowParameterPanelButton = False
            Me.CrystalReportViewer1.ShowPrintButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False
            Me.CrystalReportViewer1.ShowTextSearchButton = False
            Me.CrystalReportViewer1.Size = New System.Drawing.Size(638, 322)
            Me.CrystalReportViewer1.TabIndex = 0
            Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(638, 24)
            Me.MenuStrip1.TabIndex = 1
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ArchivoToolStripMenuItem
            '
            Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpirmirToolStripMenuItem, Me.ExportarPDFToolStripMenuItem, Me.mnuExportarVarios})
            Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
            Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
            Me.ArchivoToolStripMenuItem.Text = "Archivo"
            '
            'ImpirmirToolStripMenuItem
            '
            Me.ImpirmirToolStripMenuItem.Name = "ImpirmirToolStripMenuItem"
            Me.ImpirmirToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
            Me.ImpirmirToolStripMenuItem.Text = "Imprimir"
            '
            'ExportarPDFToolStripMenuItem
            '
            Me.ExportarPDFToolStripMenuItem.Name = "ExportarPDFToolStripMenuItem"
            Me.ExportarPDFToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
            Me.ExportarPDFToolStripMenuItem.Text = "Exportar PDF"
            '
            'mnuExportarVarios
            '
            Me.mnuExportarVarios.Name = "mnuExportarVarios"
            Me.mnuExportarVarios.Size = New System.Drawing.Size(142, 22)
            Me.mnuExportarVarios.Text = "Exportar"
            Me.mnuExportarVarios.Visible = False
            '
            'SalirToolStripMenuItem
            '
            Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
            Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
            Me.SalirToolStripMenuItem.Text = "&Salir"
            '
            'ReporteCrystal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(638, 346)
            Me.Controls.Add(Me.CrystalReportViewer1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "ReporteCrystal"
            Me.Text = "ReporteCrystal"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ImpirmirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ExportarPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents mnuExportarVarios As System.Windows.Forms.ToolStripMenuItem
    End Class

End Namespace