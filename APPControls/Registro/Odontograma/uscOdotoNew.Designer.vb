<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscOdotoNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscOdotoNew))
        Me.btnaddodontograma = New System.Windows.Forms.Button()
        Me.pboxodonto = New System.Windows.Forms.PictureBox()
        Me.lstlista = New System.Windows.Forms.ListView()
        Me.imagelist1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.pboxodonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaddodontograma
        '
        Me.btnaddodontograma.Image = CType(resources.GetObject("btnaddodontograma.Image"), System.Drawing.Image)
        Me.btnaddodontograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddodontograma.Location = New System.Drawing.Point(670, 14)
        Me.btnaddodontograma.Name = "btnaddodontograma"
        Me.btnaddodontograma.Size = New System.Drawing.Size(96, 29)
        Me.btnaddodontograma.TabIndex = 1
        Me.btnaddodontograma.Text = "Odontograma"
        Me.btnaddodontograma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddodontograma.UseVisualStyleBackColor = True
        '
        'pboxodonto
        '
        Me.pboxodonto.Location = New System.Drawing.Point(0, 0)
        Me.pboxodonto.Name = "pboxodonto"
        Me.pboxodonto.Size = New System.Drawing.Size(492, 400)
        Me.pboxodonto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxodonto.TabIndex = 0
        Me.pboxodonto.TabStop = False
        '
        'lstlista
        '
        Me.lstlista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstlista.FullRowSelect = True
        Me.lstlista.HideSelection = False
        Me.lstlista.Location = New System.Drawing.Point(605, 49)
        Me.lstlista.Name = "lstlista"
        Me.lstlista.Size = New System.Drawing.Size(219, 136)
        Me.lstlista.SmallImageList = Me.imagelist1
        Me.lstlista.TabIndex = 2
        Me.lstlista.UseCompatibleStateImageBehavior = False
        '
        'imagelist1
        '
        Me.imagelist1.ImageStream = CType(resources.GetObject("imagelist1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagelist1.TransparentColor = System.Drawing.Color.Transparent
        Me.imagelist1.Images.SetKeyName(0, "page_green.png")
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fecha"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'uscOdotoNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstlista)
        Me.Controls.Add(Me.btnaddodontograma)
        Me.Controls.Add(Me.pboxodonto)
        Me.Name = "uscOdotoNew"
        Me.Size = New System.Drawing.Size(850, 448)
        CType(Me.pboxodonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pboxodonto As PictureBox
    Friend WithEvents btnaddodontograma As Button
    Friend WithEvents lstlista As ListView
    Friend WithEvents imagelist1 As ImageList
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
