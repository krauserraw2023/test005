<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscThumbFinger
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
        Me.lblDedo = New System.Windows.Forms.Label()
        Me.chkHuellaNoDisponible = New System.Windows.Forms.CheckBox()
        Me.pbVisor = New System.Windows.Forms.PictureBox()
        Me.btnObs = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDowBMP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDownANSI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDownWsq = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pbVisor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDedo
        '
        Me.lblDedo.BackColor = System.Drawing.SystemColors.Control
        Me.lblDedo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDedo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDedo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDedo.Location = New System.Drawing.Point(1, 140)
        Me.lblDedo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDedo.Name = "lblDedo"
        Me.lblDedo.Size = New System.Drawing.Size(127, 18)
        Me.lblDedo.TabIndex = 1
        '
        'chkHuellaNoDisponible
        '
        Me.chkHuellaNoDisponible.AutoSize = True
        Me.chkHuellaNoDisponible.BackColor = System.Drawing.Color.White
        Me.chkHuellaNoDisponible.Location = New System.Drawing.Point(1, 2)
        Me.chkHuellaNoDisponible.Name = "chkHuellaNoDisponible"
        Me.chkHuellaNoDisponible.Size = New System.Drawing.Size(15, 14)
        Me.chkHuellaNoDisponible.TabIndex = 37
        Me.chkHuellaNoDisponible.UseVisualStyleBackColor = False
        '
        'pbVisor
        '
        Me.pbVisor.BackColor = System.Drawing.Color.White
        Me.pbVisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbVisor.ContextMenuStrip = Me.ContextMenuStrip1
        Me.pbVisor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbVisor.Location = New System.Drawing.Point(1, 1)
        Me.pbVisor.Name = "pbVisor"
        Me.pbVisor.Size = New System.Drawing.Size(127, 139)
        Me.pbVisor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbVisor.TabIndex = 0
        Me.pbVisor.TabStop = False
        '
        'btnObs
        '
        Me.btnObs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnObs.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnObs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObs.Location = New System.Drawing.Point(100, 0)
        Me.btnObs.Name = "btnObs"
        Me.btnObs.Size = New System.Drawing.Size(28, 18)
        Me.btnObs.TabIndex = 38
        Me.btnObs.Text = "---"
        Me.btnObs.UseVisualStyleBackColor = False
        Me.btnObs.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDowBMP, Me.ToolStripMenuItem1, Me.mnuDownANSI, Me.mnuDownWsq})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(206, 98)
        '
        'mnuDowBMP
        '
        Me.mnuDowBMP.Name = "mnuDowBMP"
        Me.mnuDowBMP.Size = New System.Drawing.Size(205, 22)
        Me.mnuDowBMP.Text = "Descargar Imagen huella"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 6)
        '
        'mnuDownANSI
        '
        Me.mnuDownANSI.Name = "mnuDownANSI"
        Me.mnuDownANSI.Size = New System.Drawing.Size(205, 22)
        Me.mnuDownANSI.Text = "Descargar template ANSI"
        Me.mnuDownANSI.Visible = False
        '
        'mnuDownWsq
        '
        Me.mnuDownWsq.Name = "mnuDownWsq"
        Me.mnuDownWsq.Size = New System.Drawing.Size(205, 22)
        Me.mnuDownWsq.Text = "Descargar WSQ"
        Me.mnuDownWsq.Visible = False
        '
        'uscThumbFinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.btnObs)
        Me.Controls.Add(Me.chkHuellaNoDisponible)
        Me.Controls.Add(Me.pbVisor)
        Me.Controls.Add(Me.lblDedo)
        Me.Name = "uscThumbFinger"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(129, 159)
        CType(Me.pbVisor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbVisor As System.Windows.Forms.PictureBox
    Friend WithEvents lblDedo As System.Windows.Forms.Label
    Friend WithEvents chkHuellaNoDisponible As System.Windows.Forms.CheckBox
    Friend WithEvents btnObs As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuDowBMP As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDownANSI As Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDownWsq As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
End Class
