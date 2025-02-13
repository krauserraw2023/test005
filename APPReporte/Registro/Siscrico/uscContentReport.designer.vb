Namespace Registro.Siscrico


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscContentReport
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.components = New System.ComponentModel.Container()
            Me.pnContenedor = New System.Windows.Forms.Panel()
            Me.txtNumActRpt = New System.Windows.Forms.ToolStripTextBox()
            Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
            Me.lblTotRep = New System.Windows.Forms.ToolStripLabel()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.tsBarraHerramienta = New System.Windows.Forms.ToolStrip()
            Me.cmdPrim = New System.Windows.Forms.ToolStripButton()
            Me.cmdAnt = New System.Windows.Forms.ToolStripButton()
            Me.cmdSig = New System.Windows.Forms.ToolStripButton()
            Me.cmdUlt = New System.Windows.Forms.ToolStripButton()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuPrintCompleta = New System.Windows.Forms.ToolStripMenuItem()
            Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsBarraHerramienta.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnContenedor
            '
            Me.pnContenedor.AutoScroll = True
            Me.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnContenedor.Location = New System.Drawing.Point(0, 54)
            Me.pnContenedor.Name = "pnContenedor"
            Me.pnContenedor.Size = New System.Drawing.Size(656, 316)
            Me.pnContenedor.TabIndex = 2
            '
            'txtNumActRpt
            '
            Me.txtNumActRpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtNumActRpt.Name = "txtNumActRpt"
            Me.txtNumActRpt.ReadOnly = True
            Me.txtNumActRpt.Size = New System.Drawing.Size(30, 30)
            Me.txtNumActRpt.Text = "1"
            Me.txtNumActRpt.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ToolStripLabel1
            '
            Me.ToolStripLabel1.Name = "ToolStripLabel1"
            Me.ToolStripLabel1.Size = New System.Drawing.Size(19, 27)
            Me.ToolStripLabel1.Text = "de"
            '
            'lblTotRep
            '
            Me.lblTotRep.Name = "lblTotRep"
            Me.lblTotRep.Size = New System.Drawing.Size(13, 27)
            Me.lblTotRep.Text = "0"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
            '
            'tsBarraHerramienta
            '
            Me.tsBarraHerramienta.AutoSize = False
            Me.tsBarraHerramienta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrim, Me.cmdAnt, Me.txtNumActRpt, Me.ToolStripLabel1, Me.lblTotRep, Me.cmdSig, Me.cmdUlt, Me.ToolStripSeparator1})
            Me.tsBarraHerramienta.Location = New System.Drawing.Point(0, 24)
            Me.tsBarraHerramienta.Name = "tsBarraHerramienta"
            Me.tsBarraHerramienta.Size = New System.Drawing.Size(656, 30)
            Me.tsBarraHerramienta.TabIndex = 1
            Me.tsBarraHerramienta.Text = "ToolStrip1"
            '
            'cmdPrim
            '
            Me.cmdPrim.AutoSize = False
            Me.cmdPrim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.cmdPrim.Image = Global.APPReporte.My.Resources.Resources.fle_pri1
            Me.cmdPrim.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.cmdPrim.Name = "cmdPrim"
            Me.cmdPrim.Size = New System.Drawing.Size(27, 27)
            Me.cmdPrim.Text = "<<"
            Me.cmdPrim.ToolTipText = "Ver la primera ficha de identificación"
            '
            'cmdAnt
            '
            Me.cmdAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.cmdAnt.Image = Global.APPReporte.My.Resources.Resources.fle_ant1
            Me.cmdAnt.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.cmdAnt.Name = "cmdAnt"
            Me.cmdAnt.Size = New System.Drawing.Size(23, 27)
            Me.cmdAnt.Tag = "<"
            Me.cmdAnt.Text = "<"
            Me.cmdAnt.ToolTipText = "Ver la ficha de identificación anterior"
            '
            'cmdSig
            '
            Me.cmdSig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.cmdSig.Image = Global.APPReporte.My.Resources.Resources.fle_pri11
            Me.cmdSig.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.cmdSig.Name = "cmdSig"
            Me.cmdSig.Size = New System.Drawing.Size(23, 27)
            Me.cmdSig.Tag = ">"
            Me.cmdSig.Text = ">"
            Me.cmdSig.ToolTipText = "Ver la siguiente ficha de identificación"
            '
            'cmdUlt
            '
            Me.cmdUlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.cmdUlt.Image = Global.APPReporte.My.Resources.Resources.fle_ult1
            Me.cmdUlt.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.cmdUlt.Name = "cmdUlt"
            Me.cmdUlt.Size = New System.Drawing.Size(23, 27)
            Me.cmdUlt.Text = ">>"
            Me.cmdUlt.ToolTipText = "Ver la última ficha de identificación"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(656, 24)
            Me.MenuStrip1.TabIndex = 3
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ArchivoToolStripMenuItem
            '
            Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintCompleta})
            Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
            Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
            Me.ArchivoToolStripMenuItem.Text = "Archivo"
            '
            'mnuPrintCompleta
            '
            Me.mnuPrintCompleta.Name = "mnuPrintCompleta"
            Me.mnuPrintCompleta.Size = New System.Drawing.Size(198, 22)
            Me.mnuPrintCompleta.Text = "Imprimir todas las paginas"
            '
            'SalirToolStripMenuItem
            '
            Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
            Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
            Me.SalirToolStripMenuItem.Text = "Salir"
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
            '
            'uscContentReport
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnContenedor)
            Me.Controls.Add(Me.tsBarraHerramienta)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Name = "uscContentReport"
            Me.Size = New System.Drawing.Size(656, 370)
            Me.tsBarraHerramienta.ResumeLayout(False)
            Me.tsBarraHerramienta.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pnContenedor As System.Windows.Forms.Panel
        Friend WithEvents cmdPrim As System.Windows.Forms.ToolStripButton
        Friend WithEvents cmdAnt As System.Windows.Forms.ToolStripButton
        Friend WithEvents txtNumActRpt As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
        Friend WithEvents lblTotRep As System.Windows.Forms.ToolStripLabel
        Friend WithEvents cmdSig As System.Windows.Forms.ToolStripButton
        Friend WithEvents cmdUlt As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tsBarraHerramienta As System.Windows.Forms.ToolStrip
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuPrintCompleta As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip

    End Class
End Namespace