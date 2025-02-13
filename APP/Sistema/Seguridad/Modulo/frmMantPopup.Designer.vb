Namespace Seguridad.Modulo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantPopup
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.nudNivel = New System.Windows.Forms.NumericUpDown()
            Me.chkSubmodulo = New System.Windows.Forms.CheckBox()
            Me.txtTitulo = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtObjeto = New System.Windows.Forms.TextBox()
            Me.txtOrden = New System.Windows.Forms.TextBox()
            Me.txtRuta = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.chkActivo = New System.Windows.Forms.CheckBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.btnCambiar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.ofdPhoto = New System.Windows.Forms.OpenFileDialog()
            Me.GroupBox1.SuspendLayout()
            CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.nudNivel)
            Me.GroupBox1.Controls.Add(Me.chkSubmodulo)
            Me.GroupBox1.Controls.Add(Me.txtTitulo)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtObjeto)
            Me.GroupBox1.Controls.Add(Me.txtOrden)
            Me.GroupBox1.Controls.Add(Me.txtRuta)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.chkActivo)
            Me.GroupBox1.Controls.Add(Me.PictureBox1)
            Me.GroupBox1.Controls.Add(Me.btnCambiar)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(359, 212)
            Me.GroupBox1.TabIndex = 58
            Me.GroupBox1.TabStop = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 47)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(37, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "Nivel :"
            '
            'nudNivel
            '
            Me.nudNivel.Location = New System.Drawing.Point(73, 44)
            Me.nudNivel.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nudNivel.Name = "nudNivel"
            Me.nudNivel.Size = New System.Drawing.Size(44, 20)
            Me.nudNivel.TabIndex = 56
            Me.nudNivel.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'chkSubmodulo
            '
            Me.chkSubmodulo.AutoSize = True
            Me.chkSubmodulo.Location = New System.Drawing.Point(73, 149)
            Me.chkSubmodulo.Name = "chkSubmodulo"
            Me.chkSubmodulo.Size = New System.Drawing.Size(113, 17)
            Me.chkSubmodulo.TabIndex = 55
            Me.chkSubmodulo.Text = "Tiene Sub-Modulo"
            Me.chkSubmodulo.UseVisualStyleBackColor = True
            '
            'txtTitulo
            '
            Me.txtTitulo.Location = New System.Drawing.Point(73, 19)
            Me.txtTitulo.Name = "txtTitulo"
            Me.txtTitulo.Size = New System.Drawing.Size(158, 20)
            Me.txtTitulo.TabIndex = 42
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(8, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(50, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Nombre :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 74)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 13)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Objeto"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 100)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(30, 13)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Ruta"
            '
            'txtObjeto
            '
            Me.txtObjeto.Location = New System.Drawing.Point(73, 71)
            Me.txtObjeto.Name = "txtObjeto"
            Me.txtObjeto.Size = New System.Drawing.Size(158, 20)
            Me.txtObjeto.TabIndex = 43
            '
            'txtOrden
            '
            Me.txtOrden.Location = New System.Drawing.Point(73, 123)
            Me.txtOrden.Name = "txtOrden"
            Me.txtOrden.Size = New System.Drawing.Size(44, 20)
            Me.txtOrden.TabIndex = 52
            '
            'txtRuta
            '
            Me.txtRuta.Location = New System.Drawing.Point(73, 97)
            Me.txtRuta.Name = "txtRuta"
            Me.txtRuta.Size = New System.Drawing.Size(158, 20)
            Me.txtRuta.TabIndex = 44
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 126)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(42, 13)
            Me.Label4.TabIndex = 51
            Me.Label4.Text = "Orden :"
            '
            'chkActivo
            '
            Me.chkActivo.AutoSize = True
            Me.chkActivo.Checked = True
            Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkActivo.Location = New System.Drawing.Point(73, 172)
            Me.chkActivo.Name = "chkActivo"
            Me.chkActivo.Size = New System.Drawing.Size(56, 17)
            Me.chkActivo.TabIndex = 45
            Me.chkActivo.Text = "Activo"
            Me.chkActivo.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox1.Location = New System.Drawing.Point(250, 15)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(76, 76)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.PictureBox1.TabIndex = 46
            Me.PictureBox1.TabStop = False
            '
            'btnCambiar
            '
            Me.btnCambiar.Location = New System.Drawing.Point(250, 94)
            Me.btnCambiar.Name = "btnCambiar"
            Me.btnCambiar.Size = New System.Drawing.Size(76, 23)
            Me.btnCambiar.TabIndex = 47
            Me.btnCambiar.Text = "Cambiar"
            Me.btnCambiar.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOk)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 212)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(359, 47)
            Me.Panel1.TabIndex = 53
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(262, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 52
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(164, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 51
            Me.btnOk.Text = "&OK"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'ofdPhoto
            '
            Me.ofdPhoto.FileName = "OpenFileDialog1"
            '
            'frmMantPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(359, 259)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMantPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Mantenimiento de Modulos"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtObjeto As System.Windows.Forms.TextBox
        Friend WithEvents txtOrden As System.Windows.Forms.TextBox
        Friend WithEvents txtRuta As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents btnCambiar As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents ofdPhoto As System.Windows.Forms.OpenFileDialog
        Friend WithEvents chkSubmodulo As System.Windows.Forms.CheckBox
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents nudNivel As System.Windows.Forms.NumericUpDown

    End Class
End Namespace

