<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrecuenciaPopup
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
        Me.chlbMes = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New Legolas.APPUIComponents.myButton()
        Me.btnCancelar = New Legolas.APPUIComponents.myButton()
        Me.gbxFormChildContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxFormChildContainer
        '
        Me.gbxFormChildContainer.Controls.Add(Me.chlbMes)
        Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
        Me.gbxFormChildContainer.Size = New System.Drawing.Size(184, 242)
        '
        'chlbMes
        '
        Me.chlbMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chlbMes.CheckOnClick = True
        Me.chlbMes.ColumnWidth = 50
        Me.chlbMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chlbMes.FormattingEnabled = True
        Me.chlbMes.HorizontalScrollbar = True
        Me.chlbMes.Location = New System.Drawing.Point(0, 0)
        Me.chlbMes.Name = "chlbMes"
        Me.chlbMes.Size = New System.Drawing.Size(184, 214)
        Me.chlbMes.TabIndex = 73
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 28)
        Me.Panel1.TabIndex = 74
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAceptar)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(51, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 28)
        Me.Panel2.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(2, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(63, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(66, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(63, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmProgramacionPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 242)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProgramacionPopup"
        Me.Text = "Seleccione..."
        Me.gbxFormChildContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chlbMes As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As Legolas.APPUIComponents.myButton
    Friend WithEvents btnAceptar As Legolas.APPUIComponents.myButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
