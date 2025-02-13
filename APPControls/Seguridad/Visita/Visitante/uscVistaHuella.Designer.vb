Namespace Visita.Visitante


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscVistaHuella
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtObsDer = New System.Windows.Forms.TextBox()
            Me.pbEstadoManoDer = New System.Windows.Forms.PictureBox()
            Me.pbManoDerecha = New System.Windows.Forms.PictureBox()
            Me.lblManoDerecha = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtObsIzq = New System.Windows.Forms.TextBox()
            Me.pbEstadoManoIzq = New System.Windows.Forms.PictureBox()
            Me.pbManoizquierda = New System.Windows.Forms.PictureBox()
            Me.lblManoIzquierda = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.lblFecha = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbHuella = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtUsuario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblFechaInac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtUsuarioInac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.pbEstadoManoDer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbManoDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            CType(Me.pbEstadoManoIzq, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbManoizquierda, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(736, 274)
            Me.Panel1.TabIndex = 15
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.txtObsDer)
            Me.Panel2.Controls.Add(Me.pbEstadoManoDer)
            Me.Panel2.Controls.Add(Me.pbManoDerecha)
            Me.Panel2.Controls.Add(Me.lblManoDerecha)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(214, 54)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(214, 220)
            Me.Panel2.TabIndex = 101
            '
            'txtObsDer
            '
            Me.txtObsDer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObsDer.Location = New System.Drawing.Point(0, 21)
            Me.txtObsDer.MaxLength = 500
            Me.txtObsDer.Multiline = True
            Me.txtObsDer.Name = "txtObsDer"
            Me.txtObsDer.ReadOnly = True
            Me.txtObsDer.Size = New System.Drawing.Size(214, 199)
            Me.txtObsDer.TabIndex = 17
            '
            'pbEstadoManoDer
            '
            Me.pbEstadoManoDer.BackColor = System.Drawing.Color.White
            Me.pbEstadoManoDer.Location = New System.Drawing.Point(166, 24)
            Me.pbEstadoManoDer.Name = "pbEstadoManoDer"
            Me.pbEstadoManoDer.Size = New System.Drawing.Size(36, 36)
            Me.pbEstadoManoDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbEstadoManoDer.TabIndex = 13
            Me.pbEstadoManoDer.TabStop = False
            '
            'pbManoDerecha
            '
            Me.pbManoDerecha.BackColor = System.Drawing.Color.White
            Me.pbManoDerecha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbManoDerecha.Image = Global.APPControls.My.Resources.Resources.huella_digital
            Me.pbManoDerecha.Location = New System.Drawing.Point(0, 21)
            Me.pbManoDerecha.Name = "pbManoDerecha"
            Me.pbManoDerecha.Size = New System.Drawing.Size(214, 199)
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
            Me.lblManoDerecha.Size = New System.Drawing.Size(214, 21)
            Me.lblManoDerecha.TabIndex = 16
            Me.lblManoDerecha.Text = "Indice Derecho"
            Me.lblManoDerecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.txtObsIzq)
            Me.Panel3.Controls.Add(Me.pbEstadoManoIzq)
            Me.Panel3.Controls.Add(Me.pbManoizquierda)
            Me.Panel3.Controls.Add(Me.lblManoIzquierda)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel3.Location = New System.Drawing.Point(0, 54)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(214, 220)
            Me.Panel3.TabIndex = 100
            '
            'txtObsIzq
            '
            Me.txtObsIzq.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObsIzq.Location = New System.Drawing.Point(0, 21)
            Me.txtObsIzq.MaxLength = 500
            Me.txtObsIzq.Multiline = True
            Me.txtObsIzq.Name = "txtObsIzq"
            Me.txtObsIzq.ReadOnly = True
            Me.txtObsIzq.Size = New System.Drawing.Size(214, 199)
            Me.txtObsIzq.TabIndex = 15
            '
            'pbEstadoManoIzq
            '
            Me.pbEstadoManoIzq.BackColor = System.Drawing.Color.White
            Me.pbEstadoManoIzq.Location = New System.Drawing.Point(166, 24)
            Me.pbEstadoManoIzq.Name = "pbEstadoManoIzq"
            Me.pbEstadoManoIzq.Size = New System.Drawing.Size(36, 36)
            Me.pbEstadoManoIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbEstadoManoIzq.TabIndex = 13
            Me.pbEstadoManoIzq.TabStop = False
            '
            'pbManoizquierda
            '
            Me.pbManoizquierda.BackColor = System.Drawing.Color.White
            Me.pbManoizquierda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbManoizquierda.Image = Global.APPControls.My.Resources.Resources.huella_digital
            Me.pbManoizquierda.Location = New System.Drawing.Point(0, 21)
            Me.pbManoizquierda.Name = "pbManoizquierda"
            Me.pbManoizquierda.Size = New System.Drawing.Size(214, 199)
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
            Me.lblManoIzquierda.Size = New System.Drawing.Size(214, 21)
            Me.lblManoIzquierda.TabIndex = 14
            Me.lblManoIzquierda.Text = "Indice Derecho"
            Me.lblManoIzquierda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.lblFechaInac)
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.txtUsuarioInac)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.lblFecha)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Controls.Add(Me.cbbHuella)
            Me.Panel4.Controls.Add(Me.txtUsuario)
            Me.Panel4.Controls.Add(Me.Label1)
            Me.Panel4.Controls.Add(Me.Label4)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(736, 54)
            Me.Panel4.TabIndex = 99
            '
            'lblFecha
            '
            Me.lblFecha._BloquearPaste = False
            Me.lblFecha._SeleccionarTodo = True
            Me.lblFecha.Location = New System.Drawing.Point(563, 10)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.ReadOnly = True
            Me.lblFecha.Size = New System.Drawing.Size(145, 20)
            Me.lblFecha.TabIndex = 100
            Me.lblFecha.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.lblFecha.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(494, 12)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 13)
            Me.Label2.TabIndex = 99
            Me.Label2.Text = "Fecha :"
            '
            'cbbHuella
            '
            Me.cbbHuella.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbHuella.DropDownWidth = 150
            Me.cbbHuella.Location = New System.Drawing.Point(72, 7)
            Me.cbbHuella.Name = "cbbHuella"
            Me.cbbHuella.Size = New System.Drawing.Size(142, 21)
            Me.cbbHuella.TabIndex = 95
            '
            'txtUsuario
            '
            Me.txtUsuario._BloquearPaste = False
            Me.txtUsuario._SeleccionarTodo = True
            Me.txtUsuario.Location = New System.Drawing.Point(295, 10)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.ReadOnly = True
            Me.txtUsuario.Size = New System.Drawing.Size(196, 20)
            Me.txtUsuario.TabIndex = 98
            Me.txtUsuario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtUsuario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(0, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 13)
            Me.Label1.TabIndex = 96
            Me.Label1.Text = "Seleccione :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(220, 12)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(49, 13)
            Me.Label4.TabIndex = 97
            Me.Label4.Text = "Usuario :"
            '
            'lblFechaInac
            '
            Me.lblFechaInac._BloquearPaste = False
            Me.lblFechaInac._SeleccionarTodo = True
            Me.lblFechaInac.Location = New System.Drawing.Point(563, 31)
            Me.lblFechaInac.Name = "lblFechaInac"
            Me.lblFechaInac.ReadOnly = True
            Me.lblFechaInac.Size = New System.Drawing.Size(145, 20)
            Me.lblFechaInac.TabIndex = 104
            Me.lblFechaInac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.lblFechaInac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(494, 33)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(70, 13)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Fecha Inac. :"
            '
            'txtUsuarioInac
            '
            Me.txtUsuarioInac._BloquearPaste = False
            Me.txtUsuarioInac._SeleccionarTodo = True
            Me.txtUsuarioInac.Location = New System.Drawing.Point(295, 31)
            Me.txtUsuarioInac.Name = "txtUsuarioInac"
            Me.txtUsuarioInac.ReadOnly = True
            Me.txtUsuarioInac.Size = New System.Drawing.Size(196, 20)
            Me.txtUsuarioInac.TabIndex = 102
            Me.txtUsuarioInac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtUsuarioInac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(220, 33)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(76, 13)
            Me.Label5.TabIndex = 101
            Me.Label5.Text = "Usuario Inac. :"
            '
            'uscVistaHuella
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Name = "uscVistaHuella"
            Me.Size = New System.Drawing.Size(736, 274)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            CType(Me.pbEstadoManoDer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbManoDerecha, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            CType(Me.pbEstadoManoIzq, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbManoizquierda, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cbbHuella As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pbEstadoManoDer As System.Windows.Forms.PictureBox
        Friend WithEvents pbManoDerecha As System.Windows.Forms.PictureBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents lblManoIzquierda As System.Windows.Forms.Label
        Friend WithEvents pbEstadoManoIzq As System.Windows.Forms.PictureBox
        Friend WithEvents pbManoizquierda As System.Windows.Forms.PictureBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents txtUsuario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblManoDerecha As System.Windows.Forms.Label
        Friend WithEvents lblFecha As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtObsIzq As System.Windows.Forms.TextBox
        Friend WithEvents txtObsDer As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaInac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtUsuarioInac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label

    End Class

End Namespace