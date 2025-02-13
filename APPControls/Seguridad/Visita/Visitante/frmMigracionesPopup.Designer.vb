Namespace Visita.Visitante

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMigracionesPopup
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMigracionesPopup))
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.btnReemplazar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.txtNacionalidad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtCalidadMigra = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.txtTipoDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlBotones.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.btnReemplazar)
            Me.pnlBotones.Controls.Add(Me.Panel1)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(0, 343)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(605, 49)
            Me.pnlBotones.TabIndex = 0
            '
            'btnReemplazar
            '
            Me.btnReemplazar.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(88, Byte), Integer))
            Me.btnReemplazar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReemplazar.ForeColor = System.Drawing.Color.White
            Me.btnReemplazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReemplazar.Location = New System.Drawing.Point(12, 4)
            Me.btnReemplazar.Name = "btnReemplazar"
            Me.btnReemplazar.Size = New System.Drawing.Size(156, 41)
            Me.btnReemplazar.TabIndex = 2
            Me.btnReemplazar.Text = "^ Reemplazar datos"
            Me.btnReemplazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReemplazar.UseVisualStyleBackColor = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnOk)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(366, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(239, 49)
            Me.Panel1.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.ForeColor = System.Drawing.Color.White
            Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOk.Location = New System.Drawing.Point(0, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(118, 41)
            Me.btnOk.TabIndex = 1
            Me.btnOk.Text = "» Omitir datos"
            Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnOk.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.boton_cancelar
            Me.btnCancel.Location = New System.Drawing.Point(121, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(114, 41)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'txtNacionalidad
            '
            Me.txtNacionalidad._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNacionalidad._BloquearPaste = True
            Me.txtNacionalidad._SeleccionarTodo = False
            Me.txtNacionalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNacionalidad.Location = New System.Drawing.Point(379, 174)
            Me.txtNacionalidad.Name = "txtNacionalidad"
            Me.txtNacionalidad.ReadOnly = True
            Me.txtNacionalidad.Size = New System.Drawing.Size(207, 26)
            Me.txtNacionalidad.TabIndex = 13
            Me.txtNacionalidad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNacionalidad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(220, 178)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(104, 20)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Nacionalidad:"
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.txtCalidadMigra)
            Me.GroupBox9.Controls.Add(Me.Label2)
            Me.GroupBox9.Controls.Add(Me.picFoto)
            Me.GroupBox9.Controls.Add(Me.txtNacionalidad)
            Me.GroupBox9.Controls.Add(Me.Label1)
            Me.GroupBox9.Controls.Add(Me.txtTipoDoc)
            Me.GroupBox9.Controls.Add(Me.Label5)
            Me.GroupBox9.Controls.Add(Me.txtFechaNac)
            Me.GroupBox9.Controls.Add(Me.txtSexo)
            Me.GroupBox9.Controls.Add(Me.Label47)
            Me.GroupBox9.Controls.Add(Me.txtPrimerApellido)
            Me.GroupBox9.Controls.Add(Me.Label48)
            Me.GroupBox9.Controls.Add(Me.Label49)
            Me.GroupBox9.Controls.Add(Me.Label50)
            Me.GroupBox9.Controls.Add(Me.txtPrenombres)
            Me.GroupBox9.Controls.Add(Me.Label51)
            Me.GroupBox9.Controls.Add(Me.txtSegundoApellido)
            Me.GroupBox9.Controls.Add(Me.Label52)
            Me.GroupBox9.Controls.Add(Me.txtNumDoc)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(605, 334)
            Me.GroupBox9.TabIndex = 17
            Me.GroupBox9.TabStop = False
            '
            'txtCalidadMigra
            '
            Me.txtCalidadMigra._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCalidadMigra._BloquearPaste = True
            Me.txtCalidadMigra._SeleccionarTodo = False
            Me.txtCalidadMigra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCalidadMigra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCalidadMigra.Location = New System.Drawing.Point(224, 299)
            Me.txtCalidadMigra.Name = "txtCalidadMigra"
            Me.txtCalidadMigra.ReadOnly = True
            Me.txtCalidadMigra.Size = New System.Drawing.Size(362, 26)
            Me.txtCalidadMigra.TabIndex = 31
            Me.txtCalidadMigra.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCalidadMigra.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(220, 276)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(144, 20)
            Me.Label2.TabIndex = 30
            Me.Label2.Text = "Calidad Migratoria :"
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.PaleGoldenrod
            Me.picFoto.BackgroundImage = CType(resources.GetObject("picFoto.BackgroundImage"), System.Drawing.Image)
            Me.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.picFoto.Location = New System.Drawing.Point(6, 20)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(208, 265)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picFoto.TabIndex = 22
            Me.picFoto.TabStop = False
            '
            'txtTipoDoc
            '
            Me.txtTipoDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoDoc._BloquearPaste = False
            Me.txtTipoDoc._SeleccionarTodo = False
            Me.txtTipoDoc.BackColor = System.Drawing.SystemColors.Control
            Me.txtTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoDoc.Location = New System.Drawing.Point(379, 13)
            Me.txtTipoDoc.Name = "txtTipoDoc"
            Me.txtTipoDoc.ReadOnly = True
            Me.txtTipoDoc.Size = New System.Drawing.Size(207, 26)
            Me.txtTipoDoc.TabIndex = 29
            Me.txtTipoDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(220, 16)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(130, 20)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Tipo Documento:"
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaNac.Location = New System.Drawing.Point(379, 240)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(207, 26)
            Me.txtFechaNac.TabIndex = 17
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSexo
            '
            Me.txtSexo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(379, 207)
            Me.txtSexo.MaxLength = 3
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(207, 26)
            Me.txtSexo.TabIndex = 19
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(220, 79)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(122, 20)
            Me.Label47.TabIndex = 8
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrimerApellido.Location = New System.Drawing.Point(379, 77)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(207, 26)
            Me.txtPrimerApellido.TabIndex = 9
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.Location = New System.Drawing.Point(220, 112)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(142, 20)
            Me.Label48.TabIndex = 10
            Me.Label48.Text = "Segundo Apellido :"
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.Location = New System.Drawing.Point(220, 146)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(81, 20)
            Me.Label49.TabIndex = 14
            Me.Label49.Text = "Nombres :"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.Location = New System.Drawing.Point(220, 212)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(53, 20)
            Me.Label50.TabIndex = 18
            Me.Label50.Text = "Sexo :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrenombres.Location = New System.Drawing.Point(379, 141)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(207, 26)
            Me.txtPrenombres.TabIndex = 15
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(220, 246)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(98, 20)
            Me.Label51.TabIndex = 16
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSegundoApellido.Location = New System.Drawing.Point(379, 109)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(207, 26)
            Me.txtSegundoApellido.TabIndex = 11
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(220, 48)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(106, 20)
            Me.Label52.TabIndex = 2
            Me.Label52.Text = "Numero Doc.:"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDoc.Location = New System.Drawing.Point(379, 45)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.ReadOnly = True
            Me.txtNumDoc.Size = New System.Drawing.Size(207, 26)
            Me.txtNumDoc.TabIndex = 3
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'frmMigracionesPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(605, 392)
            Me.Controls.Add(Me.pnlBotones)
            Me.Controls.Add(Me.GroupBox9)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMigracionesPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Datos proporcionados por Migraciones"
            Me.pnlBotones.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents picFoto As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNacionalidad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtTipoDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents txtCalidadMigra As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents btnReemplazar As Button
    End Class
End Namespace