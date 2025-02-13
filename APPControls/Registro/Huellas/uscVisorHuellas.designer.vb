Namespace Registro.Huellas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscVisorHuellas
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
            Me.pnlHuellaIzquierda = New System.Windows.Forms.Panel()
            Me.btnCapturaIzquierda = New System.Windows.Forms.Button()
            Me.pbVisorIzquierdo = New System.Windows.Forms.PictureBox()
            Me.lblDedoIzquierdo = New System.Windows.Forms.Label()
            Me.lblDedoSelIzquierdo = New System.Windows.Forms.Label()
            Me.gbHuellas = New System.Windows.Forms.GroupBox()
            Me.pnlHuellaDerecha = New System.Windows.Forms.Panel()
            Me.btnCapturaDerecha = New System.Windows.Forms.Button()
            Me.pbVisorDerecho = New System.Windows.Forms.PictureBox()
            Me.lblDedoDerecho = New System.Windows.Forms.Label()
            Me.lblDedoSelDerecho = New System.Windows.Forms.Label()
            Me.pnlHuellaIzquierda.SuspendLayout()
            CType(Me.pbVisorIzquierdo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbHuellas.SuspendLayout()
            Me.pnlHuellaDerecha.SuspendLayout()
            CType(Me.pbVisorDerecho, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlHuellaIzquierda
            '
            Me.pnlHuellaIzquierda.BackColor = System.Drawing.Color.Gray
            Me.pnlHuellaIzquierda.Controls.Add(Me.btnCapturaIzquierda)
            Me.pnlHuellaIzquierda.Controls.Add(Me.pbVisorIzquierdo)
            Me.pnlHuellaIzquierda.Controls.Add(Me.lblDedoIzquierdo)
            Me.pnlHuellaIzquierda.Controls.Add(Me.lblDedoSelIzquierdo)
            Me.pnlHuellaIzquierda.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlHuellaIzquierda.Location = New System.Drawing.Point(3, 16)
            Me.pnlHuellaIzquierda.Name = "pnlHuellaIzquierda"
            Me.pnlHuellaIzquierda.Padding = New System.Windows.Forms.Padding(1)
            Me.pnlHuellaIzquierda.Size = New System.Drawing.Size(250, 159)
            Me.pnlHuellaIzquierda.TabIndex = 24
            '
            'btnCapturaIzquierda
            '
            Me.btnCapturaIzquierda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCapturaIzquierda.Image = Global.APPControls.My.Resources.Resources.capturar
            Me.btnCapturaIzquierda.Location = New System.Drawing.Point(88, 128)
            Me.btnCapturaIzquierda.Name = "btnCapturaIzquierda"
            Me.btnCapturaIzquierda.Size = New System.Drawing.Size(90, 29)
            Me.btnCapturaIzquierda.TabIndex = 25
            Me.btnCapturaIzquierda.UseVisualStyleBackColor = True
            Me.btnCapturaIzquierda.Visible = False
            '
            'pbVisorIzquierdo
            '
            Me.pbVisorIzquierdo.BackColor = System.Drawing.Color.White
            Me.pbVisorIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.pbVisorIzquierdo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbVisorIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbVisorIzquierdo.Location = New System.Drawing.Point(1, 22)
            Me.pbVisorIzquierdo.Name = "pbVisorIzquierdo"
            Me.pbVisorIzquierdo.Size = New System.Drawing.Size(248, 106)
            Me.pbVisorIzquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbVisorIzquierdo.TabIndex = 5
            Me.pbVisorIzquierdo.TabStop = False
            '
            'lblDedoIzquierdo
            '
            Me.lblDedoIzquierdo.BackColor = System.Drawing.SystemColors.Control
            Me.lblDedoIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDedoIzquierdo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblDedoIzquierdo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblDedoIzquierdo.Location = New System.Drawing.Point(1, 128)
            Me.lblDedoIzquierdo.Margin = New System.Windows.Forms.Padding(0)
            Me.lblDedoIzquierdo.Name = "lblDedoIzquierdo"
            Me.lblDedoIzquierdo.Size = New System.Drawing.Size(248, 30)
            Me.lblDedoIzquierdo.TabIndex = 6
            '
            'lblDedoSelIzquierdo
            '
            Me.lblDedoSelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblDedoSelIzquierdo.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblDedoSelIzquierdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDedoSelIzquierdo.Location = New System.Drawing.Point(1, 1)
            Me.lblDedoSelIzquierdo.Name = "lblDedoSelIzquierdo"
            Me.lblDedoSelIzquierdo.Size = New System.Drawing.Size(248, 21)
            Me.lblDedoSelIzquierdo.TabIndex = 4
            Me.lblDedoSelIzquierdo.Text = "Mano Izquierda"
            Me.lblDedoSelIzquierdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gbHuellas
            '
            Me.gbHuellas.Controls.Add(Me.pnlHuellaDerecha)
            Me.gbHuellas.Controls.Add(Me.pnlHuellaIzquierda)
            Me.gbHuellas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbHuellas.Location = New System.Drawing.Point(0, 0)
            Me.gbHuellas.Name = "gbHuellas"
            Me.gbHuellas.Size = New System.Drawing.Size(509, 178)
            Me.gbHuellas.TabIndex = 25
            Me.gbHuellas.TabStop = False
            '
            'pnlHuellaDerecha
            '
            Me.pnlHuellaDerecha.BackColor = System.Drawing.Color.Gray
            Me.pnlHuellaDerecha.Controls.Add(Me.btnCapturaDerecha)
            Me.pnlHuellaDerecha.Controls.Add(Me.pbVisorDerecho)
            Me.pnlHuellaDerecha.Controls.Add(Me.lblDedoDerecho)
            Me.pnlHuellaDerecha.Controls.Add(Me.lblDedoSelDerecho)
            Me.pnlHuellaDerecha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlHuellaDerecha.Location = New System.Drawing.Point(253, 16)
            Me.pnlHuellaDerecha.Name = "pnlHuellaDerecha"
            Me.pnlHuellaDerecha.Padding = New System.Windows.Forms.Padding(1)
            Me.pnlHuellaDerecha.Size = New System.Drawing.Size(253, 159)
            Me.pnlHuellaDerecha.TabIndex = 25
            '
            'btnCapturaDerecha
            '
            Me.btnCapturaDerecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCapturaDerecha.Image = Global.APPControls.My.Resources.Resources.capturar
            Me.btnCapturaDerecha.Location = New System.Drawing.Point(88, 128)
            Me.btnCapturaDerecha.Name = "btnCapturaDerecha"
            Me.btnCapturaDerecha.Size = New System.Drawing.Size(93, 29)
            Me.btnCapturaDerecha.TabIndex = 25
            Me.btnCapturaDerecha.UseVisualStyleBackColor = True
            Me.btnCapturaDerecha.Visible = False
            '
            'pbVisorDerecho
            '
            Me.pbVisorDerecho.BackColor = System.Drawing.Color.White
            Me.pbVisorDerecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.pbVisorDerecho.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbVisorDerecho.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbVisorDerecho.Location = New System.Drawing.Point(1, 22)
            Me.pbVisorDerecho.Name = "pbVisorDerecho"
            Me.pbVisorDerecho.Size = New System.Drawing.Size(251, 106)
            Me.pbVisorDerecho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbVisorDerecho.TabIndex = 5
            Me.pbVisorDerecho.TabStop = False
            '
            'lblDedoDerecho
            '
            Me.lblDedoDerecho.BackColor = System.Drawing.SystemColors.Control
            Me.lblDedoDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblDedoDerecho.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblDedoDerecho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblDedoDerecho.Location = New System.Drawing.Point(1, 128)
            Me.lblDedoDerecho.Margin = New System.Windows.Forms.Padding(0)
            Me.lblDedoDerecho.Name = "lblDedoDerecho"
            Me.lblDedoDerecho.Size = New System.Drawing.Size(251, 30)
            Me.lblDedoDerecho.TabIndex = 6
            '
            'lblDedoSelDerecho
            '
            Me.lblDedoSelDerecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblDedoSelDerecho.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblDedoSelDerecho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDedoSelDerecho.Location = New System.Drawing.Point(1, 1)
            Me.lblDedoSelDerecho.Name = "lblDedoSelDerecho"
            Me.lblDedoSelDerecho.Size = New System.Drawing.Size(251, 21)
            Me.lblDedoSelDerecho.TabIndex = 4
            Me.lblDedoSelDerecho.Text = "Mano Izquierda"
            Me.lblDedoSelDerecho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'uscVisorHuellas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gbHuellas)
            Me.Name = "uscVisorHuellas"
            Me.Size = New System.Drawing.Size(509, 178)
            Me.pnlHuellaIzquierda.ResumeLayout(False)
            CType(Me.pbVisorIzquierdo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbHuellas.ResumeLayout(False)
            Me.pnlHuellaDerecha.ResumeLayout(False)
            CType(Me.pbVisorDerecho, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlHuellaIzquierda As Panel
        Friend WithEvents gbHuellas As GroupBox
        Friend WithEvents btnCapturaIzquierda As Button
        Friend WithEvents pbVisorIzquierdo As PictureBox
        Friend WithEvents lblDedoIzquierdo As Label
        Friend WithEvents lblDedoSelIzquierdo As Label
        Friend WithEvents pnlHuellaDerecha As Panel
        Friend WithEvents btnCapturaDerecha As Button
        Friend WithEvents pbVisorDerecho As PictureBox
        Friend WithEvents lblDedoDerecho As Label
        Friend WithEvents lblDedoSelDerecho As Label
    End Class
End Namespace