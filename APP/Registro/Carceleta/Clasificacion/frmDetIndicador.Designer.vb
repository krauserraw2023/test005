Namespace Registro.Carceleta.Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDetIndicador
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetIndicador))
            Me.lblIndicador = New System.Windows.Forms.Label()
            Me.lblPtjIndicador = New System.Windows.Forms.Label()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.lblIndicador)
            Me.gbxFormChildContainer.Controls.Add(Me.lblPtjIndicador)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlSalir)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(981, 396)
            '
            'lblIndicador
            '
            Me.lblIndicador.BackColor = System.Drawing.Color.White
            Me.lblIndicador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblIndicador.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblIndicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIndicador.Location = New System.Drawing.Point(0, 0)
            Me.lblIndicador.Name = "lblIndicador"
            Me.lblIndicador.Size = New System.Drawing.Size(981, 329)
            Me.lblIndicador.TabIndex = 0
            '
            'lblPtjIndicador
            '
            Me.lblPtjIndicador.BackColor = System.Drawing.Color.White
            Me.lblPtjIndicador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblPtjIndicador.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblPtjIndicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPtjIndicador.Location = New System.Drawing.Point(0, 329)
            Me.lblPtjIndicador.Name = "lblPtjIndicador"
            Me.lblPtjIndicador.Size = New System.Drawing.Size(981, 28)
            Me.lblPtjIndicador.TabIndex = 1
            Me.lblPtjIndicador.Text = "PUNTAJE: "
            Me.lblPtjIndicador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlSalir.Location = New System.Drawing.Point(0, 357)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(981, 39)
            Me.pnlSalir.TabIndex = 2
            '
            'btnSalir
            '
            Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(899, 0)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 39)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'frmDetIndicador
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnSalir
            Me.ClientSize = New System.Drawing.Size(981, 396)
            Me.Name = "frmDetIndicador"
            Me.Text = "Indicador"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblPtjIndicador As System.Windows.Forms.Label
        Friend WithEvents lblIndicador As System.Windows.Forms.Label
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
    End Class
End Namespace