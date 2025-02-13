Namespace Registro.Siscrico


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReporte
        Inherits System.Windows.Forms.Form ' Legolas.APPUIComponents.FormPopup

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
            Me.crvVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuExportPdf = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
            Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'crvVisor
            '
            Me.crvVisor.ActiveViewIndex = -1
            Me.crvVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvVisor.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvVisor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvVisor.EnableDrillDown = False
            Me.crvVisor.Location = New System.Drawing.Point(0, 24)
            Me.crvVisor.Name = "crvVisor"
            Me.crvVisor.ShowCopyButton = False
            Me.crvVisor.ShowGroupTreeButton = False
            Me.crvVisor.ShowLogo = False
            Me.crvVisor.ShowParameterPanelButton = False
            Me.crvVisor.ShowRefreshButton = False
            Me.crvVisor.Size = New System.Drawing.Size(785, 404)
            Me.crvVisor.TabIndex = 8
            Me.crvVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.mnuSalir})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(785, 24)
            Me.MenuStrip1.TabIndex = 7
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ArchivoToolStripMenuItem
            '
            Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuImprimir, Me.mnuExportPdf})
            Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
            Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
            Me.ArchivoToolStripMenuItem.Text = "Archivo"
            '
            'mnuImprimir
            '
            Me.mnuImprimir.Name = "mnuImprimir"
            Me.mnuImprimir.Size = New System.Drawing.Size(141, 22)
            Me.mnuImprimir.Text = "Imprimir"
            '
            'mnuExportPdf
            '
            Me.mnuExportPdf.Name = "mnuExportPdf"
            Me.mnuExportPdf.Size = New System.Drawing.Size(141, 22)
            Me.mnuExportPdf.Text = "Exportar PDF"
            '
            'mnuSalir
            '
            Me.mnuSalir.Name = "mnuSalir"
            Me.mnuSalir.Size = New System.Drawing.Size(41, 20)
            Me.mnuSalir.Text = "&Salir"
            '
            'frmReporte
            '
            Me.ClientSize = New System.Drawing.Size(785, 428)
            Me.Controls.Add(Me.crvVisor)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Name = "frmReporte"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents crvVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuExportPdf As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    End Class

End Namespace