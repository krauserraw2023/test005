<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfind
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfind))
        Me.images = New System.Windows.Forms.ImageList(Me.components)
        Me.lstviewseleccion = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.cbocriterio = New System.Windows.Forms.ComboBox()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'images
        '
        Me.images.ImageStream = CType(resources.GetObject("images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.images.TransparentColor = System.Drawing.Color.Magenta
        Me.images.Images.SetKeyName(0, "")
        Me.images.Images.SetKeyName(1, "")
        Me.images.Images.SetKeyName(2, "")
        Me.images.Images.SetKeyName(3, "")
        Me.images.Images.SetKeyName(4, "")
        Me.images.Images.SetKeyName(5, "")
        Me.images.Images.SetKeyName(6, "")
        Me.images.Images.SetKeyName(7, "")
        Me.images.Images.SetKeyName(8, "")
        Me.images.Images.SetKeyName(9, "")
        Me.images.Images.SetKeyName(10, "")
        Me.images.Images.SetKeyName(11, "")
        Me.images.Images.SetKeyName(12, "")
        Me.images.Images.SetKeyName(13, "folder_user.png")
        Me.images.Images.SetKeyName(14, "email_edit.png")
        Me.images.Images.SetKeyName(15, "email_error.png")
        Me.images.Images.SetKeyName(16, "email_go.png")
        Me.images.Images.SetKeyName(17, "email_link.png")
        Me.images.Images.SetKeyName(18, "email_open.png")
        Me.images.Images.SetKeyName(19, "folder.png")
        Me.images.Images.SetKeyName(20, "folder_add.png")
        Me.images.Images.SetKeyName(21, "folder_bell.png")
        Me.images.Images.SetKeyName(22, "folder_brick.png")
        Me.images.Images.SetKeyName(23, "folder_database.png")
        Me.images.Images.SetKeyName(24, "folder_edit.png")
        Me.images.Images.SetKeyName(25, "folder_error.png")
        Me.images.Images.SetKeyName(26, "folder_explore.png")
        Me.images.Images.SetKeyName(27, "folder_feed.png")
        Me.images.Images.SetKeyName(28, "folder_go.png")
        Me.images.Images.SetKeyName(29, "folder_image.png")
        Me.images.Images.SetKeyName(30, "folder_key.png")
        Me.images.Images.SetKeyName(31, "folder_lightbulb.png")
        Me.images.Images.SetKeyName(32, "folder_magnify.png")
        Me.images.Images.SetKeyName(33, "folder_page.png")
        Me.images.Images.SetKeyName(34, "folder_star.png")
        Me.images.Images.SetKeyName(35, "folder_table.png")
        Me.images.Images.SetKeyName(36, "cross.png")
        Me.images.Images.SetKeyName(37, "car_add.png")
        Me.images.Images.SetKeyName(38, "lorry_add.png")
        Me.images.Images.SetKeyName(39, "lorry_delete.png")
        Me.images.Images.SetKeyName(40, "magnifier.png")
        Me.images.Images.SetKeyName(41, "group_add.png")
        '
        'lstviewseleccion
        '
        Me.lstviewseleccion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstviewseleccion.FullRowSelect = True
        Me.lstviewseleccion.HideSelection = False
        Me.lstviewseleccion.Location = New System.Drawing.Point(4, 29)
        Me.lstviewseleccion.MultiSelect = False
        Me.lstviewseleccion.Name = "lstviewseleccion"
        Me.lstviewseleccion.Size = New System.Drawing.Size(380, 178)
        Me.lstviewseleccion.SmallImageList = Me.images
        Me.lstviewseleccion.TabIndex = 2
        Me.lstviewseleccion.UseCompatibleStateImageBehavior = False
        Me.lstviewseleccion.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fecha"
        Me.ColumnHeader2.Width = 295
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(278, 219)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdsalir.TabIndex = 4
        Me.cmdsalir.Text = "Cancelar"
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'cmdgrabar
        '
        Me.cmdgrabar.Location = New System.Drawing.Point(202, 219)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdgrabar.TabIndex = 3
        Me.cmdgrabar.Text = "&Aceptar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'cbocriterio
        '
        Me.cbocriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocriterio.FormattingEnabled = True
        Me.cbocriterio.Location = New System.Drawing.Point(51, 2)
        Me.cbocriterio.Name = "cbocriterio"
        Me.cbocriterio.Size = New System.Drawing.Size(99, 21)
        Me.cbocriterio.TabIndex = 0
        '
        'txtfind
        '
        Me.txtfind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfind.Location = New System.Drawing.Point(152, 3)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(232, 20)
        Me.txtfind.TabIndex = 1
        '
        'frmfind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 254)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.cbocriterio)
        Me.Controls.Add(Me.lstviewseleccion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmfind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents images As System.Windows.Forms.ImageList
    Friend WithEvents lstviewseleccion As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdsalir As System.Windows.Forms.Button
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents cbocriterio As System.Windows.Forms.ComboBox
    Friend WithEvents txtfind As System.Windows.Forms.TextBox

End Class
