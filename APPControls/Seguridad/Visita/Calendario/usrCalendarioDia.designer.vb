<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCalendarioDia
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCalendarioDia))
        Me.pn_titulo = New System.Windows.Forms.Panel
        Me.lbldia = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lst_visita = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoDeVisitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pn_titulo.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn_titulo
        '
        Me.pn_titulo.Controls.Add(Me.lbldia)
        Me.pn_titulo.Controls.Add(Me.btnAdd)
        Me.pn_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pn_titulo.Location = New System.Drawing.Point(0, 0)
        Me.pn_titulo.Name = "pn_titulo"
        Me.pn_titulo.Size = New System.Drawing.Size(150, 19)
        Me.pn_titulo.TabIndex = 0
        '
        'lbldia
        '
        Me.lbldia.AutoSize = True
        Me.lbldia.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldia.Location = New System.Drawing.Point(3, 5)
        Me.lbldia.Name = "lbldia"
        Me.lbldia.Size = New System.Drawing.Size(16, 16)
        Me.lbldia.TabIndex = 0
        Me.lbldia.Text = "0"
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Location = New System.Drawing.Point(121, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(29, 19)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lst_visita
        '
        Me.lst_visita.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lst_visita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_visita.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_visita.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lst_visita.Location = New System.Drawing.Point(0, 19)
        Me.lst_visita.MultiSelect = False
        Me.lst_visita.Name = "lst_visita"
        Me.lst_visita.Size = New System.Drawing.Size(150, 131)
        Me.lst_visita.TabIndex = 1
        Me.lst_visita.UseCompatibleStateImageBehavior = False
        Me.lst_visita.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 0
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiaToolStripMenuItem, Me.GrupoDeVisitaToolStripMenuItem})
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(158, 70)
        '
        'DiaToolStripMenuItem
        '
        Me.DiaToolStripMenuItem.Name = "DiaToolStripMenuItem"
        Me.DiaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DiaToolStripMenuItem.Text = "Día Establecido"
        '
        'GrupoDeVisitaToolStripMenuItem
        '
        Me.GrupoDeVisitaToolStripMenuItem.Name = "GrupoDeVisitaToolStripMenuItem"
        Me.GrupoDeVisitaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GrupoDeVisitaToolStripMenuItem.Text = "Grupo de Visita"
        '
        'usrCalendarioDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lst_visita)
        Me.Controls.Add(Me.pn_titulo)
        Me.Name = "usrCalendarioDia"
        Me.pn_titulo.ResumeLayout(False)
        Me.pn_titulo.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pn_titulo As System.Windows.Forms.Panel
    Friend WithEvents lbldia As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lst_visita As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoDeVisitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
