Namespace Seguridad.Modulo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscar
        Inherits Legolas.APPUIComponents.Form

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
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtTitulo = New System.Windows.Forms.TextBox()
            Me.txtObjeto = New System.Windows.Forms.TextBox()
            Me.txtRuta = New System.Windows.Forms.TextBox()
            Me.chkActivo = New System.Windows.Forms.CheckBox()
            Me.tvwModulo = New System.Windows.Forms.TreeView()
            Me.ofdPhoto = New System.Windows.Forms.OpenFileDialog()
            Me.txtOrden = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkSubmodulo = New System.Windows.Forms.CheckBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.nudNivel = New System.Windows.Forms.NumericUpDown()
            Me.GroupBox1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 99)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(30, 13)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Ruta"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 73)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 13)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Objeto"
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
            'txtTitulo
            '
            Me.txtTitulo.BackColor = System.Drawing.SystemColors.Control
            Me.txtTitulo.Location = New System.Drawing.Point(73, 19)
            Me.txtTitulo.Name = "txtTitulo"
            Me.txtTitulo.ReadOnly = True
            Me.txtTitulo.Size = New System.Drawing.Size(158, 20)
            Me.txtTitulo.TabIndex = 42
            '
            'txtObjeto
            '
            Me.txtObjeto.Location = New System.Drawing.Point(73, 70)
            Me.txtObjeto.Name = "txtObjeto"
            Me.txtObjeto.ReadOnly = True
            Me.txtObjeto.Size = New System.Drawing.Size(158, 20)
            Me.txtObjeto.TabIndex = 43
            '
            'txtRuta
            '
            Me.txtRuta.Location = New System.Drawing.Point(73, 96)
            Me.txtRuta.Name = "txtRuta"
            Me.txtRuta.ReadOnly = True
            Me.txtRuta.Size = New System.Drawing.Size(158, 20)
            Me.txtRuta.TabIndex = 44
            '
            'chkActivo
            '
            Me.chkActivo.AutoSize = True
            Me.chkActivo.Location = New System.Drawing.Point(73, 169)
            Me.chkActivo.Name = "chkActivo"
            Me.chkActivo.Size = New System.Drawing.Size(56, 17)
            Me.chkActivo.TabIndex = 45
            Me.chkActivo.Text = "Activo"
            Me.chkActivo.UseVisualStyleBackColor = True
            '
            'tvwModulo
            '
            Me.tvwModulo.Dock = System.Windows.Forms.DockStyle.Left
            Me.tvwModulo.Location = New System.Drawing.Point(0, 0)
            Me.tvwModulo.Name = "tvwModulo"
            Me.tvwModulo.Size = New System.Drawing.Size(252, 488)
            Me.tvwModulo.TabIndex = 48
            '
            'ofdPhoto
            '
            Me.ofdPhoto.FileName = "OpenFileDialog1"
            '
            'txtOrden
            '
            Me.txtOrden.Location = New System.Drawing.Point(73, 122)
            Me.txtOrden.Name = "txtOrden"
            Me.txtOrden.ReadOnly = True
            Me.txtOrden.Size = New System.Drawing.Size(44, 20)
            Me.txtOrden.TabIndex = 52
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 125)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(42, 13)
            Me.Label4.TabIndex = 51
            Me.Label4.Text = "Orden :"
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(285, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(88, 53)
            Me.btnSalir.TabIndex = 56
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(191, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(88, 53)
            Me.btnEliminar.TabIndex = 55
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(252, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(588, 203)
            Me.GroupBox1.TabIndex = 57
            Me.GroupBox1.TabStop = False
            '
            'chkSubmodulo
            '
            Me.chkSubmodulo.AutoSize = True
            Me.chkSubmodulo.Location = New System.Drawing.Point(73, 148)
            Me.chkSubmodulo.Name = "chkSubmodulo"
            Me.chkSubmodulo.Size = New System.Drawing.Size(113, 17)
            Me.chkSubmodulo.TabIndex = 54
            Me.chkSubmodulo.Text = "Tiene Sub-Modulo"
            Me.chkSubmodulo.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox1.Location = New System.Drawing.Point(243, 15)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(121, 133)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.PictureBox1.TabIndex = 46
            Me.PictureBox1.TabStop = False
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.Location = New System.Drawing.Point(97, 3)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(88, 53)
            Me.btnModificar.TabIndex = 54
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.SIPPOPE.My.Resources.Resources._1277961158_folder_new
            Me.btnNuevo.Location = New System.Drawing.Point(3, 3)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 53)
            Me.btnNuevo.TabIndex = 53
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(252, 428)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(588, 60)
            Me.Panel1.TabIndex = 58
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.btnNuevo)
            Me.Panel2.Controls.Add(Me.btnModificar)
            Me.Panel2.Controls.Add(Me.btnEliminar)
            Me.Panel2.Controls.Add(Me.btnSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(379, 60)
            Me.Panel2.TabIndex = 59
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 48)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(37, 13)
            Me.Label5.TabIndex = 59
            Me.Label5.Text = "Nivel :"
            '
            'nudNivel
            '
            Me.nudNivel.Location = New System.Drawing.Point(73, 45)
            Me.nudNivel.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nudNivel.Name = "nudNivel"
            Me.nudNivel.Size = New System.Drawing.Size(44, 20)
            Me.nudNivel.TabIndex = 58
            Me.nudNivel.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'frmBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(840, 488)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.tvwModulo)
            Me.Name = "frmBuscar"
            Me.Text = "Gestion de Modulos"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
        Friend WithEvents txtObjeto As System.Windows.Forms.TextBox
        Friend WithEvents txtRuta As System.Windows.Forms.TextBox
        Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents tvwModulo As System.Windows.Forms.TreeView
        Friend WithEvents ofdPhoto As System.Windows.Forms.OpenFileDialog
        Friend WithEvents txtOrden As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents chkSubmodulo As System.Windows.Forms.CheckBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents nudNivel As System.Windows.Forms.NumericUpDown
    End Class
End Namespace

