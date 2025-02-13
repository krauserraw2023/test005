Namespace Registro.Huellas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscDatosInternoReniec
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.pnlCuerpo = New System.Windows.Forms.Panel()
            Me.lblCuerpo2 = New System.Windows.Forms.Label()
            Me.lblCuerpo1 = New System.Windows.Forms.Label()
            Me.gbLeyenda = New System.Windows.Forms.GroupBox()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.lblCabecera = New System.Windows.Forms.Label()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblsexo = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.pnlFotoVis = New System.Windows.Forms.Panel()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label49 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.txtDni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.pnlCuerpo.SuspendLayout()
            Me.gbLeyenda.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.pnlFotoVis.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlCuerpo
            '
            Me.pnlCuerpo.BackColor = System.Drawing.Color.ForestGreen
            Me.pnlCuerpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCuerpo.Controls.Add(Me.lblCuerpo2)
            Me.pnlCuerpo.Controls.Add(Me.lblCuerpo1)
            Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlCuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnlCuerpo.Location = New System.Drawing.Point(3, 39)
            Me.pnlCuerpo.Name = "pnlCuerpo"
            Me.pnlCuerpo.Size = New System.Drawing.Size(468, 73)
            Me.pnlCuerpo.TabIndex = 37
            '
            'lblCuerpo2
            '
            Me.lblCuerpo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCuerpo2.AutoSize = True
            Me.lblCuerpo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCuerpo2.ForeColor = System.Drawing.Color.White
            Me.lblCuerpo2.Location = New System.Drawing.Point(92, 17)
            Me.lblCuerpo2.Name = "lblCuerpo2"
            Me.lblCuerpo2.Size = New System.Drawing.Size(264, 52)
            Me.lblCuerpo2.TabIndex = 2
            Me.lblCuerpo2.Text = "La primera impresion dactilar capturada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "corresponde al DNI consultadoo. La segun" &
    "da" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "impresion dactilar capturada corresponde al" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DNI consultado."
            Me.lblCuerpo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCuerpo1
            '
            Me.lblCuerpo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCuerpo1.AutoSize = True
            Me.lblCuerpo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCuerpo1.ForeColor = System.Drawing.Color.White
            Me.lblCuerpo1.Location = New System.Drawing.Point(150, -1)
            Me.lblCuerpo1.Name = "lblCuerpo1"
            Me.lblCuerpo1.Size = New System.Drawing.Size(138, 18)
            Me.lblCuerpo1.TabIndex = 1
            Me.lblCuerpo1.Text = "CORRESPONDE"
            Me.lblCuerpo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'gbLeyenda
            '
            Me.gbLeyenda.Controls.Add(Me.pnlCabecera)
            Me.gbLeyenda.Controls.Add(Me.pnlCuerpo)
            Me.gbLeyenda.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gbLeyenda.Location = New System.Drawing.Point(3, 275)
            Me.gbLeyenda.Name = "gbLeyenda"
            Me.gbLeyenda.Size = New System.Drawing.Size(474, 115)
            Me.gbLeyenda.TabIndex = 1
            Me.gbLeyenda.TabStop = False
            '
            'pnlCabecera
            '
            Me.pnlCabecera.BackColor = System.Drawing.Color.MidnightBlue
            Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlCabecera.Controls.Add(Me.lblCabecera)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCabecera.Location = New System.Drawing.Point(3, 16)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(468, 23)
            Me.pnlCabecera.TabIndex = 38
            '
            'lblCabecera
            '
            Me.lblCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCabecera.AutoSize = True
            Me.lblCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCabecera.ForeColor = System.Drawing.Color.White
            Me.lblCabecera.Location = New System.Drawing.Point(124, 1)
            Me.lblCabecera.Name = "lblCabecera"
            Me.lblCabecera.Size = New System.Drawing.Size(203, 18)
            Me.lblCabecera.TabIndex = 2
            Me.lblCabecera.Text = "1 Nueva Autenticacion 1:1"
            Me.lblCabecera.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'GroupBox9
            '
            Me.GroupBox9.BackColor = System.Drawing.SystemColors.Window
            Me.GroupBox9.Controls.Add(Me.txtSexo)
            Me.GroupBox9.Controls.Add(Me.lblsexo)
            Me.GroupBox9.Controls.Add(Me.Label1)
            Me.GroupBox9.Controls.Add(Me.gbLeyenda)
            Me.GroupBox9.Controls.Add(Me.Label2)
            Me.GroupBox9.Controls.Add(Me.pnlFotoVis)
            Me.GroupBox9.Controls.Add(Me.txtFechaNac)
            Me.GroupBox9.Controls.Add(Me.Label47)
            Me.GroupBox9.Controls.Add(Me.txtPrimerApellido)
            Me.GroupBox9.Controls.Add(Me.Label49)
            Me.GroupBox9.Controls.Add(Me.txtPrenombres)
            Me.GroupBox9.Controls.Add(Me.Label51)
            Me.GroupBox9.Controls.Add(Me.txtSegundoApellido)
            Me.GroupBox9.Controls.Add(Me.Label52)
            Me.GroupBox9.Controls.Add(Me.txtDni)
            Me.GroupBox9.Controls.Add(Me.Label48)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(480, 393)
            Me.GroupBox9.TabIndex = 2
            Me.GroupBox9.TabStop = False
            '
            'txtSexo
            '
            Me.txtSexo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSexo._BloquearPaste = False
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.Location = New System.Drawing.Point(318, 221)
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(150, 20)
            Me.txtSexo.TabIndex = 35
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblsexo
            '
            Me.lblsexo.AutoSize = True
            Me.lblsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblsexo.Location = New System.Drawing.Point(215, 224)
            Me.lblsexo.Name = "lblsexo"
            Me.lblsexo.Size = New System.Drawing.Size(43, 13)
            Me.lblsexo.TabIndex = 34
            Me.lblsexo.Text = "Sexo :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(240, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(218, 16)
            Me.Label1.TabIndex = 33
            Me.Label1.Text = "        Información Personal        "
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(167, 12)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(120, 16)
            Me.Label2.TabIndex = 32
            Me.Label2.Text = "DATOS RENIEC"
            '
            'pnlFotoVis
            '
            Me.pnlFotoVis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlFotoVis.Controls.Add(Me.picFoto)
            Me.pnlFotoVis.Location = New System.Drawing.Point(4, 41)
            Me.pnlFotoVis.Name = "pnlFotoVis"
            Me.pnlFotoVis.Size = New System.Drawing.Size(207, 240)
            Me.pnlFotoVis.TabIndex = 29
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.picFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picFoto.Image = Global.APPControls.My.Resources.Resources.sin_fotografia
            Me.picFoto.Location = New System.Drawing.Point(0, 0)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(203, 236)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picFoto.TabIndex = 22
            Me.picFoto.TabStop = False
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Location = New System.Drawing.Point(318, 193)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(150, 20)
            Me.txtFechaNac.TabIndex = 11
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(215, 117)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(99, 13)
            Me.Label47.TabIndex = 4
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Location = New System.Drawing.Point(318, 114)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(150, 20)
            Me.txtPrimerApellido.TabIndex = 5
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.Location = New System.Drawing.Point(215, 170)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(87, 13)
            Me.Label49.TabIndex = 8
            Me.Label49.Text = "Pre Nombres :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Location = New System.Drawing.Point(318, 167)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(150, 20)
            Me.txtPrenombres.TabIndex = 9
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(215, 197)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(81, 13)
            Me.Label51.TabIndex = 10
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Location = New System.Drawing.Point(318, 140)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(150, 20)
            Me.txtSegundoApellido.TabIndex = 7
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(215, 89)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(55, 13)
            Me.Label52.TabIndex = 0
            Me.Label52.Text = "N° DNI :"
            '
            'txtDni
            '
            Me.txtDni._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDni._BloquearPaste = False
            Me.txtDni._SeleccionarTodo = False
            Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDni.Location = New System.Drawing.Point(318, 85)
            Me.txtDni.Name = "txtDni"
            Me.txtDni.ReadOnly = True
            Me.txtDni.Size = New System.Drawing.Size(150, 21)
            Me.txtDni.TabIndex = 1
            Me.txtDni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.Location = New System.Drawing.Point(215, 145)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(106, 13)
            Me.Label48.TabIndex = 6
            Me.Label48.Text = "Segundo Apellido"
            '
            'uscDatosInternoReniec
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.GroupBox9)
            Me.Name = "uscDatosInternoReniec"
            Me.Size = New System.Drawing.Size(480, 393)
            Me.pnlCuerpo.ResumeLayout(False)
            Me.pnlCuerpo.PerformLayout()
            Me.gbLeyenda.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.pnlFotoVis.ResumeLayout(False)
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlCuerpo As Panel
        Friend WithEvents lblCuerpo1 As Label
        Friend WithEvents gbLeyenda As GroupBox
        Friend WithEvents lblCuerpo2 As Label
        Friend WithEvents GroupBox9 As GroupBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents pnlFotoVis As Panel
        Friend WithEvents picFoto As PictureBox
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label47 As Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label49 As Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As Label
        Friend WithEvents txtDni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As Label
        Friend WithEvents pnlCabecera As Panel
        Friend WithEvents lblCabecera As Label
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblsexo As Label
    End Class
End Namespace
