Namespace Registro.Captura


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmFotoPerfiles
        Inherits Legolas.APPUIComponents.FormPopup

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFotoPerfiles))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnWebCamDer = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnCapurarDer = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnWebCamCen = New System.Windows.Forms.Button()
            Me.btnCapurarCen = New System.Windows.Forms.Button()
            Me.btnWebCamIzq = New System.Windows.Forms.Button()
            Me.btnCapurarIzq = New System.Windows.Forms.Button()
            Me.pbDerecho = New System.Windows.Forms.PictureBox()
            Me.pbIzquierdo = New System.Windows.Forms.PictureBox()
            Me.pbFrente = New System.Windows.Forms.PictureBox()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblNumIngreso = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.pbDerecho, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbIzquierdo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbFrente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(629, 367)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.UscAuditUser1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 321)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(629, 46)
            Me.Panel1.TabIndex = 46
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(429, 46)
            Me.UscAuditUser1.TabIndex = 91
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(429, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(200, 46)
            Me.Panel2.TabIndex = 87
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(99, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(4, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 85
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.NavajoWhite
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(421, 10)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(203, 17)
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "Perfil Derecho"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnWebCamDer
            '
            Me.btnWebCamDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnWebCamDer.ForeColor = System.Drawing.Color.Black
            Me.btnWebCamDer.Image = CType(resources.GetObject("btnWebCamDer.Image"), System.Drawing.Image)
            Me.btnWebCamDer.Location = New System.Drawing.Point(544, 277)
            Me.btnWebCamDer.Name = "btnWebCamDer"
            Me.btnWebCamDer.Size = New System.Drawing.Size(40, 40)
            Me.btnWebCamDer.TabIndex = 90
            Me.btnWebCamDer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWebCamDer.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.NavajoWhite
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(213, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(203, 17)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Perfil Frontal"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnCapurarDer
            '
            Me.btnCapurarDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapurarDer.ForeColor = System.Drawing.Color.Black
            Me.btnCapurarDer.Image = CType(resources.GetObject("btnCapurarDer.Image"), System.Drawing.Image)
            Me.btnCapurarDer.Location = New System.Drawing.Point(584, 277)
            Me.btnCapurarDer.Name = "btnCapurarDer"
            Me.btnCapurarDer.Size = New System.Drawing.Size(40, 40)
            Me.btnCapurarDer.TabIndex = 89
            Me.btnCapurarDer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCapurarDer.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.NavajoWhite
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(4, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(203, 17)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Perfil Izquierdo"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnWebCamCen
            '
            Me.btnWebCamCen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnWebCamCen.ForeColor = System.Drawing.Color.Black
            Me.btnWebCamCen.Image = CType(resources.GetObject("btnWebCamCen.Image"), System.Drawing.Image)
            Me.btnWebCamCen.Location = New System.Drawing.Point(336, 277)
            Me.btnWebCamCen.Name = "btnWebCamCen"
            Me.btnWebCamCen.Size = New System.Drawing.Size(40, 40)
            Me.btnWebCamCen.TabIndex = 88
            Me.btnWebCamCen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWebCamCen.UseVisualStyleBackColor = True
            '
            'btnCapurarCen
            '
            Me.btnCapurarCen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapurarCen.ForeColor = System.Drawing.Color.Black
            Me.btnCapurarCen.Image = CType(resources.GetObject("btnCapurarCen.Image"), System.Drawing.Image)
            Me.btnCapurarCen.Location = New System.Drawing.Point(376, 277)
            Me.btnCapurarCen.Name = "btnCapurarCen"
            Me.btnCapurarCen.Size = New System.Drawing.Size(40, 40)
            Me.btnCapurarCen.TabIndex = 87
            Me.btnCapurarCen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCapurarCen.UseVisualStyleBackColor = True
            '
            'btnWebCamIzq
            '
            Me.btnWebCamIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnWebCamIzq.ForeColor = System.Drawing.Color.Black
            Me.btnWebCamIzq.Image = CType(resources.GetObject("btnWebCamIzq.Image"), System.Drawing.Image)
            Me.btnWebCamIzq.Location = New System.Drawing.Point(127, 277)
            Me.btnWebCamIzq.Name = "btnWebCamIzq"
            Me.btnWebCamIzq.Size = New System.Drawing.Size(40, 40)
            Me.btnWebCamIzq.TabIndex = 86
            Me.btnWebCamIzq.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWebCamIzq.UseVisualStyleBackColor = True
            '
            'btnCapurarIzq
            '
            Me.btnCapurarIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapurarIzq.ForeColor = System.Drawing.Color.Black
            Me.btnCapurarIzq.Image = CType(resources.GetObject("btnCapurarIzq.Image"), System.Drawing.Image)
            Me.btnCapurarIzq.Location = New System.Drawing.Point(167, 277)
            Me.btnCapurarIzq.Name = "btnCapurarIzq"
            Me.btnCapurarIzq.Size = New System.Drawing.Size(40, 40)
            Me.btnCapurarIzq.TabIndex = 77
            Me.btnCapurarIzq.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCapurarIzq.UseVisualStyleBackColor = True
            '
            'pbDerecho
            '
            Me.pbDerecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.pbDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbDerecho.Location = New System.Drawing.Point(421, 26)
            Me.pbDerecho.Name = "pbDerecho"
            Me.pbDerecho.Size = New System.Drawing.Size(203, 250)
            Me.pbDerecho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbDerecho.TabIndex = 5
            Me.pbDerecho.TabStop = False
            '
            'pbIzquierdo
            '
            Me.pbIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.pbIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbIzquierdo.Location = New System.Drawing.Point(4, 26)
            Me.pbIzquierdo.Name = "pbIzquierdo"
            Me.pbIzquierdo.Size = New System.Drawing.Size(203, 250)
            Me.pbIzquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbIzquierdo.TabIndex = 3
            Me.pbIzquierdo.TabStop = False
            '
            'pbFrente
            '
            Me.pbFrente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.pbFrente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbFrente.Location = New System.Drawing.Point(213, 26)
            Me.pbFrente.Name = "pbFrente"
            Me.pbFrente.Size = New System.Drawing.Size(203, 250)
            Me.pbFrente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbFrente.TabIndex = 4
            Me.pbFrente.TabStop = False
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.pbIzquierdo)
            Me.GroupBox2.Controls.Add(Me.btnWebCamDer)
            Me.GroupBox2.Controls.Add(Me.pbFrente)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.pbDerecho)
            Me.GroupBox2.Controls.Add(Me.btnCapurarDer)
            Me.GroupBox2.Controls.Add(Me.btnCapurarIzq)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.btnWebCamIzq)
            Me.GroupBox2.Controls.Add(Me.btnWebCamCen)
            Me.GroupBox2.Controls.Add(Me.btnCapurarCen)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(629, 321)
            Me.GroupBox2.TabIndex = 49
            Me.GroupBox2.TabStop = False
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label37.Location = New System.Drawing.Point(7, 12)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(153, 13)
            Me.Label37.TabIndex = 5
            Me.Label37.Text = "Número de Ingreso del Interno:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblNumIngreso)
            Me.GroupBox1.Controls.Add(Me.Label37)
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(629, 34)
            Me.GroupBox1.TabIndex = 48
            Me.GroupBox1.TabStop = False
            '
            'lblNumIngreso
            '
            Me.lblNumIngreso.BackColor = System.Drawing.Color.White
            Me.lblNumIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNumIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumIngreso.Location = New System.Drawing.Point(163, 9)
            Me.lblNumIngreso.Name = "lblNumIngreso"
            Me.lblNumIngreso.Size = New System.Drawing.Size(58, 20)
            Me.lblNumIngreso.TabIndex = 6
            Me.lblNumIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmFotoPerfiles
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(629, 367)
            Me.Name = "frmFotoPerfiles"
            Me.Text = "Captura de fotografia..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.pbDerecho, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbIzquierdo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbFrente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnWebCamDer As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnCapurarDer As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnWebCamCen As System.Windows.Forms.Button
        Friend WithEvents btnCapurarCen As System.Windows.Forms.Button
        Friend WithEvents btnWebCamIzq As System.Windows.Forms.Button
        Friend WithEvents btnCapurarIzq As System.Windows.Forms.Button
        Friend WithEvents pbDerecho As System.Windows.Forms.PictureBox
        Friend WithEvents pbIzquierdo As System.Windows.Forms.PictureBox
        Friend WithEvents pbFrente As System.Windows.Forms.PictureBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblNumIngreso As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
    End Class
End Namespace