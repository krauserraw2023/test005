Namespace Sistema.Seguridad.Usuario.Huella
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmRegistrarHuellaPopup
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
            Me.Label26 = New System.Windows.Forms.Label()
            Me.grbUsuario = New System.Windows.Forms.GroupBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtNumDocBuscar = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtNom = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtApeMat = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtApePaterno = New System.Windows.Forms.TextBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnCapturarHuellaIzq = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnCapturarHuellaDer = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.pbManoDerecha = New System.Windows.Forms.PictureBox()
            Me.lblManoDerecha = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pbManoizquierda = New System.Windows.Forms.PictureBox()
            Me.lblManoIzquierda = New System.Windows.Forms.Label()
            Me.grbUsuario.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.pbManoDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.pbManoizquierda, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(8, 52)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(72, 13)
            Me.Label26.TabIndex = 44
            Me.Label26.Text = "Numero DNI :"
            '
            'grbUsuario
            '
            Me.grbUsuario.Controls.Add(Me.btnBuscar)
            Me.grbUsuario.Controls.Add(Me.Label7)
            Me.grbUsuario.Controls.Add(Me.txtNumDocBuscar)
            Me.grbUsuario.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbUsuario.Location = New System.Drawing.Point(0, 0)
            Me.grbUsuario.Name = "grbUsuario"
            Me.grbUsuario.Size = New System.Drawing.Size(767, 51)
            Me.grbUsuario.TabIndex = 52
            Me.grbUsuario.TabStop = False
            Me.grbUsuario.Text = "Buscar Usuario:"
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Location = New System.Drawing.Point(215, 21)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(26, 24)
            Me.btnBuscar.TabIndex = 2
            Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(9, 26)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(110, 13)
            Me.Label7.TabIndex = 60
            Me.Label7.Text = "Ingrese Numero DNI :"
            '
            'txtNumDocBuscar
            '
            Me.txtNumDocBuscar._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocBuscar._BloquearPaste = False
            Me.txtNumDocBuscar._SeleccionarTodo = False
            Me.txtNumDocBuscar.Location = New System.Drawing.Point(125, 23)
            Me.txtNumDocBuscar.MaxLength = 8
            Me.txtNumDocBuscar.Name = "txtNumDocBuscar"
            Me.txtNumDocBuscar.Size = New System.Drawing.Size(89, 20)
            Me.txtNumDocBuscar.TabIndex = 1
            Me.txtNumDocBuscar.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDocBuscar.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(113, 49)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.ReadOnly = True
            Me.txtNumDoc.Size = New System.Drawing.Size(126, 20)
            Me.txtNumDoc.TabIndex = 3
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label26)
            Me.GroupBox3.Controls.Add(Me.txtNumDoc)
            Me.GroupBox3.Controls.Add(Me.txtNom)
            Me.GroupBox3.Controls.Add(Me.Label4)
            Me.GroupBox3.Controls.Add(Me.txtApeMat)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.txtApePaterno)
            Me.GroupBox3.Location = New System.Drawing.Point(12, 67)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(322, 269)
            Me.GroupBox3.TabIndex = 53
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Datos del Usuario:"
            '
            'txtNom
            '
            Me.txtNom.Location = New System.Drawing.Point(113, 127)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.ReadOnly = True
            Me.txtNom.Size = New System.Drawing.Size(190, 20)
            Me.txtNom.TabIndex = 6
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 130)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 58
            Me.Label4.Text = "Nombres :"
            '
            'txtApeMat
            '
            Me.txtApeMat.Location = New System.Drawing.Point(113, 101)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.ReadOnly = True
            Me.txtApeMat.Size = New System.Drawing.Size(190, 20)
            Me.txtApeMat.TabIndex = 5
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 78)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(79, 13)
            Me.Label5.TabIndex = 54
            Me.Label5.Text = "Primer Apellido:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(8, 104)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(93, 13)
            Me.Label6.TabIndex = 56
            Me.Label6.Text = "Segundo Apellido:"
            '
            'txtApePaterno
            '
            Me.txtApePaterno.Location = New System.Drawing.Point(113, 75)
            Me.txtApePaterno.Name = "txtApePaterno"
            Me.txtApePaterno.ReadOnly = True
            Me.txtApePaterno.Size = New System.Drawing.Size(190, 20)
            Me.txtApePaterno.TabIndex = 4
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel4)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 348)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(767, 45)
            Me.Panel2.TabIndex = 57
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnOk)
            Me.Panel4.Controls.Add(Me.btnCancel)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(207, 45)
            Me.Panel4.TabIndex = 47
            '
            'btnOk
            '
            Me.btnOk.BackColor = System.Drawing.SystemColors.Control
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 8
            Me.btnOk.Text = "&Grabar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnOk.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(102, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 9
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnCapturarHuellaIzq
            '
            Me.btnCapturarHuellaIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHuellaIzq.Image = Global.SIPPOPE.My.Resources.Resources.capturar
            Me.btnCapturarHuellaIzq.Location = New System.Drawing.Point(42, 225)
            Me.btnCapturarHuellaIzq.Name = "btnCapturarHuellaIzq"
            Me.btnCapturarHuellaIzq.Size = New System.Drawing.Size(99, 39)
            Me.btnCapturarHuellaIzq.TabIndex = 7
            Me.btnCapturarHuellaIzq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnCapturarHuellaDer)
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Controls.Add(Me.btnCapturarHuellaIzq)
            Me.GroupBox1.Location = New System.Drawing.Point(343, 67)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(415, 269)
            Me.GroupBox1.TabIndex = 58
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Datos de Las Huellas"
            '
            'btnCapturarHuellaDer
            '
            Me.btnCapturarHuellaDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHuellaDer.Image = Global.SIPPOPE.My.Resources.Resources.capturar
            Me.btnCapturarHuellaDer.Location = New System.Drawing.Point(262, 225)
            Me.btnCapturarHuellaDer.Name = "btnCapturarHuellaDer"
            Me.btnCapturarHuellaDer.Size = New System.Drawing.Size(99, 39)
            Me.btnCapturarHuellaDer.TabIndex = 104
            Me.btnCapturarHuellaDer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.pbManoDerecha)
            Me.Panel3.Controls.Add(Me.lblManoDerecha)
            Me.Panel3.Location = New System.Drawing.Point(225, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(176, 205)
            Me.Panel3.TabIndex = 102
            '
            'pbManoDerecha
            '
            Me.pbManoDerecha.BackColor = System.Drawing.Color.White
            Me.pbManoDerecha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbManoDerecha.Location = New System.Drawing.Point(0, 21)
            Me.pbManoDerecha.Name = "pbManoDerecha"
            Me.pbManoDerecha.Size = New System.Drawing.Size(176, 184)
            Me.pbManoDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbManoDerecha.TabIndex = 13
            Me.pbManoDerecha.TabStop = False
            '
            'lblManoDerecha
            '
            Me.lblManoDerecha.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblManoDerecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblManoDerecha.Location = New System.Drawing.Point(0, 0)
            Me.lblManoDerecha.Name = "lblManoDerecha"
            Me.lblManoDerecha.Size = New System.Drawing.Size(176, 21)
            Me.lblManoDerecha.TabIndex = 14
            Me.lblManoDerecha.Text = "Derecha"
            Me.lblManoDerecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.pbManoizquierda)
            Me.Panel1.Controls.Add(Me.lblManoIzquierda)
            Me.Panel1.Location = New System.Drawing.Point(6, 14)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(176, 205)
            Me.Panel1.TabIndex = 103
            '
            'pbManoizquierda
            '
            Me.pbManoizquierda.BackColor = System.Drawing.Color.White
            Me.pbManoizquierda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbManoizquierda.Location = New System.Drawing.Point(0, 21)
            Me.pbManoizquierda.Name = "pbManoizquierda"
            Me.pbManoizquierda.Size = New System.Drawing.Size(176, 184)
            Me.pbManoizquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbManoizquierda.TabIndex = 13
            Me.pbManoizquierda.TabStop = False
            '
            'lblManoIzquierda
            '
            Me.lblManoIzquierda.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblManoIzquierda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblManoIzquierda.Location = New System.Drawing.Point(0, 0)
            Me.lblManoIzquierda.Name = "lblManoIzquierda"
            Me.lblManoIzquierda.Size = New System.Drawing.Size(176, 21)
            Me.lblManoIzquierda.TabIndex = 16
            Me.lblManoIzquierda.Text = "Izquierda"
            Me.lblManoIzquierda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmRegistrarHuellaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(221, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(767, 393)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.grbUsuario)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRegistrarHuellaPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Registrar Huella de Usuario"
            Me.grbUsuario.ResumeLayout(False)
            Me.grbUsuario.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            CType(Me.pbManoDerecha, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.pbManoizquierda, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents grbUsuario As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtNom As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtApePaterno As System.Windows.Forms.TextBox
        Friend WithEvents txtNumDocBuscar As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents btnCapturarHuellaIzq As System.Windows.Forms.Button
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents Panel3 As Panel
        Friend WithEvents pbManoDerecha As PictureBox
        Friend WithEvents lblManoDerecha As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents pbManoizquierda As PictureBox
        Friend WithEvents lblManoIzquierda As Label
        Friend WithEvents btnBuscar As Button
        Friend WithEvents btnCapturarHuellaDer As Button
    End Class
End Namespace

