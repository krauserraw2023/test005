Namespace Registro.Carceleta.Clasificacion
    Partial Class frmEditorTextPopup
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditorTextPopup))
            Me.FontDialog1 = New System.Windows.Forms.FontDialog()
            Me.ilMenuItems = New System.Windows.Forms.ImageList(Me.components)
            Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
            Me.tsbBold = New System.Windows.Forms.ToolStripButton()
            Me.tsbUnderline = New System.Windows.Forms.ToolStripButton()
            Me.tsbItalic = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.tsbBullets = New System.Windows.Forms.ToolStripButton()
            Me.tsbIndentIn = New System.Windows.Forms.ToolStripButton()
            Me.tsbIndentOut = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
            Me.tsbTextColor = New System.Windows.Forms.ToolStripDropDownButton()
            Me.TextColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsbFont = New System.Windows.Forms.ToolStripButton()
            Me.rtbBody = New System.Windows.Forms.RichTextBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.ToolStrip2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.rtbBody)
            Me.gbxFormChildContainer.Controls.Add(Me.ToolStrip2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(835, 364)
            '
            'ilMenuItems
            '
            Me.ilMenuItems.ImageStream = CType(resources.GetObject("ilMenuItems.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ilMenuItems.TransparentColor = System.Drawing.Color.Transparent
            Me.ilMenuItems.Images.SetKeyName(0, "File Folder.ico")
            Me.ilMenuItems.Images.SetKeyName(1, "Floppy.ico")
            Me.ilMenuItems.Images.SetKeyName(2, "Save as.ico")
            Me.ilMenuItems.Images.SetKeyName(3, "printer.ico")
            Me.ilMenuItems.Images.SetKeyName(4, "Page setup.ico")
            Me.ilMenuItems.Images.SetKeyName(5, "editcopy.ico")
            Me.ilMenuItems.Images.SetKeyName(6, "editcut.ico")
            Me.ilMenuItems.Images.SetKeyName(7, "editpaste.ico")
            Me.ilMenuItems.Images.SetKeyName(8, "font_truetype.ico")
            Me.ilMenuItems.Images.SetKeyName(9, "find.ico")
            Me.ilMenuItems.Images.SetKeyName(10, "Calendar.ico")
            Me.ilMenuItems.Images.SetKeyName(11, "20.ico")
            Me.ilMenuItems.Images.SetKeyName(12, "bold.ico")
            Me.ilMenuItems.Images.SetKeyName(13, "italic.ico")
            Me.ilMenuItems.Images.SetKeyName(14, "Underline.ico")
            Me.ilMenuItems.Images.SetKeyName(15, "Strikeout.ico")
            Me.ilMenuItems.Images.SetKeyName(16, "Align, left.ico")
            Me.ilMenuItems.Images.SetKeyName(17, "Align, right.ico")
            Me.ilMenuItems.Images.SetKeyName(18, "Align, center.ico")
            Me.ilMenuItems.Images.SetKeyName(19, "Bullets.ico")
            Me.ilMenuItems.Images.SetKeyName(20, "Indent, in.ico")
            Me.ilMenuItems.Images.SetKeyName(21, "Indent, out.ico")
            Me.ilMenuItems.Images.SetKeyName(22, "button_ok.ico")
            Me.ilMenuItems.Images.SetKeyName(23, "button_cancel.ico")
            Me.ilMenuItems.Images.SetKeyName(24, "Help.ico")
            Me.ilMenuItems.Images.SetKeyName(25, "document blank.ico")
            Me.ilMenuItems.Images.SetKeyName(26, "Replace.ico")
            '
            'ToolStrip2
            '
            Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBold, Me.tsbUnderline, Me.tsbItalic, Me.ToolStripSeparator2, Me.tsbBullets, Me.tsbIndentIn, Me.tsbIndentOut, Me.ToolStripSeparator4, Me.tsbTextColor, Me.tsbFont})
            Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip2.Name = "ToolStrip2"
            Me.ToolStrip2.Size = New System.Drawing.Size(835, 25)
            Me.ToolStrip2.TabIndex = 2
            Me.ToolStrip2.Text = "ToolStrip2"
            '
            'tsbBold
            '
            Me.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbBold.Image = CType(resources.GetObject("tsbBold.Image"), System.Drawing.Image)
            Me.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbBold.Name = "tsbBold"
            Me.tsbBold.Size = New System.Drawing.Size(23, 22)
            Me.tsbBold.Text = "Bold"
            '
            'tsbUnderline
            '
            Me.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbUnderline.Image = CType(resources.GetObject("tsbUnderline.Image"), System.Drawing.Image)
            Me.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbUnderline.Name = "tsbUnderline"
            Me.tsbUnderline.Size = New System.Drawing.Size(23, 22)
            Me.tsbUnderline.Text = "Underline"
            '
            'tsbItalic
            '
            Me.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbItalic.Image = CType(resources.GetObject("tsbItalic.Image"), System.Drawing.Image)
            Me.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbItalic.Name = "tsbItalic"
            Me.tsbItalic.Size = New System.Drawing.Size(23, 22)
            Me.tsbItalic.Text = "Italic"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'tsbBullets
            '
            Me.tsbBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbBullets.Image = CType(resources.GetObject("tsbBullets.Image"), System.Drawing.Image)
            Me.tsbBullets.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbBullets.Name = "tsbBullets"
            Me.tsbBullets.Size = New System.Drawing.Size(23, 22)
            Me.tsbBullets.Text = "Toggle Bullets"
            '
            'tsbIndentIn
            '
            Me.tsbIndentIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbIndentIn.Image = CType(resources.GetObject("tsbIndentIn.Image"), System.Drawing.Image)
            Me.tsbIndentIn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbIndentIn.Name = "tsbIndentIn"
            Me.tsbIndentIn.Size = New System.Drawing.Size(23, 22)
            Me.tsbIndentIn.Text = "Indent left margin"
            '
            'tsbIndentOut
            '
            Me.tsbIndentOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbIndentOut.Image = CType(resources.GetObject("tsbIndentOut.Image"), System.Drawing.Image)
            Me.tsbIndentOut.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbIndentOut.Name = "tsbIndentOut"
            Me.tsbIndentOut.Size = New System.Drawing.Size(23, 22)
            Me.tsbIndentOut.Text = "Unindent left margin"
            '
            'ToolStripSeparator4
            '
            Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
            Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
            '
            'tsbTextColor
            '
            Me.tsbTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.tsbTextColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextColorToolStripMenuItem1, Me.BackgroundColorToolStripMenuItem})
            Me.tsbTextColor.Image = CType(resources.GetObject("tsbTextColor.Image"), System.Drawing.Image)
            Me.tsbTextColor.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbTextColor.Name = "tsbTextColor"
            Me.tsbTextColor.Size = New System.Drawing.Size(28, 22)
            Me.tsbTextColor.Text = "A"
            Me.tsbTextColor.ToolTipText = "Change text / background color"
            '
            'TextColorToolStripMenuItem1
            '
            Me.TextColorToolStripMenuItem1.Name = "TextColorToolStripMenuItem1"
            Me.TextColorToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
            Me.TextColorToolStripMenuItem1.Text = "Text Color"
            '
            'BackgroundColorToolStripMenuItem
            '
            Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
            Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
            Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
            '
            'tsbFont
            '
            Me.tsbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFont.Image = CType(resources.GetObject("tsbFont.Image"), System.Drawing.Image)
            Me.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFont.Name = "tsbFont"
            Me.tsbFont.Size = New System.Drawing.Size(23, 22)
            Me.tsbFont.Text = "Change font"
            '
            'rtbBody
            '
            Me.rtbBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.rtbBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rtbBody.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rtbBody.Location = New System.Drawing.Point(0, 25)
            Me.rtbBody.Name = "rtbBody"
            Me.rtbBody.Size = New System.Drawing.Size(835, 297)
            Me.rtbBody.TabIndex = 8
            Me.rtbBody.Text = ""
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 322)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(835, 42)
            Me.Panel2.TabIndex = 9
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Controls.Add(Me.btnOK)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(638, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(195, 40)
            Me.pnlGrabarDatos.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(96, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(2, 1)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmEditorTextPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(835, 364)
            Me.Name = "frmEditorTextPopup"
            Me.Text = ".::. INFORME FUNDAMENTADO A REGIMEN CERRADO ESPECIAL PARA INTERNOS PROCESADOS"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.ToolStrip2.ResumeLayout(False)
            Me.ToolStrip2.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents rtbBody As RichTextBox
        Friend WithEvents ToolStrip2 As ToolStrip
        Friend WithEvents tsbBold As ToolStripButton
        Friend WithEvents tsbUnderline As ToolStripButton
        Friend WithEvents tsbItalic As ToolStripButton
        Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
        Friend WithEvents tsbBullets As ToolStripButton
        Friend WithEvents tsbIndentIn As ToolStripButton
        Friend WithEvents tsbIndentOut As ToolStripButton
        Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
        Friend WithEvents tsbTextColor As ToolStripDropDownButton
        Friend WithEvents TextColorToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents tsbFont As ToolStripButton
        Friend WithEvents FontDialog1 As FontDialog
        Friend WithEvents ilMenuItems As ImageList
        Friend WithEvents Panel2 As Panel
        Friend WithEvents pnlGrabarDatos As Panel
        Friend WithEvents btnCancel As Button
        Friend WithEvents btnOK As Button
    End Class
End Namespace
