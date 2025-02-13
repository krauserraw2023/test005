Namespace Visita
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVisitaSalidaPopup
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.components = New System.ComponentModel.Container()
            Me.lblHoraSal = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Label1)
            Me.gbxFormChildContainer.Controls.Add(Me.txtObs)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(408, 171)
            '
            'lblHoraSal
            '
            Me.lblHoraSal.AutoSize = True
            Me.lblHoraSal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblHoraSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraSal.Location = New System.Drawing.Point(93, 13)
            Me.lblHoraSal.Name = "lblHoraSal"
            Me.lblHoraSal.Size = New System.Drawing.Size(130, 33)
            Me.lblHoraSal.TabIndex = 36
            Me.lblHoraSal.Text = "15:00:00"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Location = New System.Drawing.Point(10, 22)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(68, 13)
            Me.Label8.TabIndex = 35
            Me.Label8.Text = "Hora Salida :"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 123)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(408, 48)
            Me.Panel2.TabIndex = 37
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(298, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(102, 40)
            Me.btnCancel.TabIndex = 106
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(190, 5)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(102, 40)
            Me.btnOk.TabIndex = 105
            Me.btnOk.Text = "&OK"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'txtObs
            '
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObs.Location = New System.Drawing.Point(93, 51)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(303, 61)
            Me.txtObs.TabIndex = 202
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.txtObs.UseSystemPasswordChar = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(10, 59)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 13)
            Me.Label1.TabIndex = 203
            Me.Label1.Text = "Observacion :"
            '
            'frmVisitaSalidaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(408, 171)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.lblHoraSal)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmVisitaSalidaPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Hora de Salida"
            Me.Controls.SetChildIndex(Me.gbxFormChildContainer, 0)
            Me.Controls.SetChildIndex(Me.lblHoraSal, 0)
            Me.Controls.SetChildIndex(Me.Panel2, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblHoraSal As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label

    End Class
End Namespace

