<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenalPopup
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbPenal = New APPControls.uscComboParametrica()
        Me.cbbRegion = New APPControls.uscComboParametrica()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Penal :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(12, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 13)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Region :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbbPenal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbbRegion)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 77)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'cbbPenal
        '
        Me.cbbPenal._Todos = False
        Me.cbbPenal._TodosMensaje = ""
        Me.cbbPenal.CodigoPadre = -1
        Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.PenalUsuario
        Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
        Me.cbbPenal.DropDownWidth = 217
        Me.cbbPenal.DropDownWidthAuto = False
        Me.cbbPenal.Location = New System.Drawing.Point(72, 44)
        Me.cbbPenal.Name = "cbbPenal"
        Me.cbbPenal.Parametro1 = -1
        Me.cbbPenal.Parametro2 = -1
        Me.cbbPenal.SelectedIndex = -1
        Me.cbbPenal.SelectedValue = 0
        Me.cbbPenal.Size = New System.Drawing.Size(217, 22)
        Me.cbbPenal.TabIndex = 52
        '
        'cbbRegion
        '
        Me.cbbRegion._Todos = False
        Me.cbbRegion._TodosMensaje = ""
        Me.cbbRegion.CodigoPadre = -1
        Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.RegionUsuario
        Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
        Me.cbbRegion.DropDownWidth = 217
        Me.cbbRegion.DropDownWidthAuto = False
        Me.cbbRegion.Location = New System.Drawing.Point(72, 16)
        Me.cbbRegion.Name = "cbbRegion"
        Me.cbbRegion.Parametro1 = -1
        Me.cbbRegion.Parametro2 = -1
        Me.cbbRegion.SelectedIndex = -1
        Me.cbbRegion.SelectedValue = 0
        Me.cbbRegion.Size = New System.Drawing.Size(217, 22)
        Me.cbbRegion.TabIndex = 53
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
        Me.btnCancel.Location = New System.Drawing.Point(198, 83)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 40)
        Me.btnCancel.TabIndex = 98
        Me.btnCancel.Text = "&Cancelar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
        Me.btnOk.Location = New System.Drawing.Point(99, 83)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(94, 40)
        Me.btnOk.TabIndex = 97
        Me.btnOk.Text = "&Aceptar"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmPenalPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 131)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPenalPopup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccionar Penal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbPenal As APPControls.uscComboParametrica
    Friend WithEvents cbbRegion As APPControls.uscComboParametrica
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button

End Class
