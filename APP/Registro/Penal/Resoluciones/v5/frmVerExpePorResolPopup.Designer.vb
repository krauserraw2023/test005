Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVerExpePorResolPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes .
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerExpePorResolPopup))
            Me.tvExpe = New System.Windows.Forms.TreeView()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.tvExpeHistorico = New System.Windows.Forms.TreeView()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.tvExpe)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.tvExpeHistorico)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(968, 532)
            '
            'tvExpe
            '
            Me.tvExpe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tvExpe.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvExpe.FullRowSelect = True
            Me.tvExpe.LineColor = System.Drawing.Color.Navy
            Me.tvExpe.Location = New System.Drawing.Point(0, 22)
            Me.tvExpe.Name = "tvExpe"
            Me.tvExpe.Size = New System.Drawing.Size(968, 249)
            Me.tvExpe.StateImageList = Me.ImageList1
            Me.tvExpe.TabIndex = 1
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "bullet_derecha_16x16.png")
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(24, 5)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(50, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "N° Exp."
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(968, 22)
            Me.Panel1.TabIndex = 3
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(784, 5)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Secretario"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(594, 5)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(76, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Sit. Jurídica"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(363, 6)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(85, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Juzgado/Sala"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(102, 5)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(108, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Autoridad Judicial"
            '
            'tvExpeHistorico
            '
            Me.tvExpeHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tvExpeHistorico.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.tvExpeHistorico.FullRowSelect = True
            Me.tvExpeHistorico.LineColor = System.Drawing.Color.Navy
            Me.tvExpeHistorico.Location = New System.Drawing.Point(0, 303)
            Me.tvExpeHistorico.Name = "tvExpeHistorico"
            Me.tvExpeHistorico.Size = New System.Drawing.Size(968, 181)
            Me.tvExpeHistorico.StateImageList = Me.ImageList1
            Me.tvExpeHistorico.TabIndex = 3
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel4.Location = New System.Drawing.Point(0, 271)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(968, 32)
            Me.Panel4.TabIndex = 0
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(4, 14)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(303, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "SEGUIMIENTO DE EXPEDIENTES (DOCUMENTOS)"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 484)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(968, 48)
            Me.Panel2.TabIndex = 76
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnSalir)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(872, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(96, 48)
            Me.Panel3.TabIndex = 102
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(2, 6)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(91, 40)
            Me.btnSalir.TabIndex = 98
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'frmVerExpePorResolPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(968, 532)
            Me.Name = "frmVerExpePorResolPopup"
            Me.Text = "Ver expedientes por resolución"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tvExpe As System.Windows.Forms.TreeView
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents tvExpeHistorico As System.Windows.Forms.TreeView
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
    End Class
End Namespace