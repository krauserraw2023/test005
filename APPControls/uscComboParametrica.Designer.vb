<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscComboParametrica
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
        Me.pnlCombo = New System.Windows.Forms.Panel()
        Me.pnlEliminar = New System.Windows.Forms.Panel()
        Me.btnEliminar = New Legolas.APPUIComponents.myButton()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.btnAdd = New Legolas.APPUIComponents.myButton()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.btnBuscar = New Legolas.APPUIComponents.myButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlCombo.SuspendLayout()
        Me.pnlEliminar.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.pnlBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'pnlCombo
        '
        Me.pnlCombo.Controls.Add(Me.ComboBox1)
        Me.pnlCombo.Controls.Add(Me.pnlEliminar)
        Me.pnlCombo.Controls.Add(Me.pnlAdd)
        Me.pnlCombo.Controls.Add(Me.pnlBusqueda)
        Me.pnlCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCombo.Location = New System.Drawing.Point(0, 0)
        Me.pnlCombo.Name = "pnlCombo"
        Me.pnlCombo.Size = New System.Drawing.Size(223, 21)
        Me.pnlCombo.TabIndex = 3
        '
        'pnlEliminar
        '
        Me.pnlEliminar.Controls.Add(Me.btnEliminar)
        Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEliminar.Location = New System.Drawing.Point(154, 0)
        Me.pnlEliminar.Name = "pnlEliminar"
        Me.pnlEliminar.Size = New System.Drawing.Size(23, 21)
        Me.pnlEliminar.TabIndex = 17
        Me.pnlEliminar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Location = New System.Drawing.Point(1, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(22, 22)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'pnlAdd
        '
        Me.pnlAdd.Controls.Add(Me.btnAdd)
        Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlAdd.Location = New System.Drawing.Point(177, 0)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(23, 21)
        Me.pnlAdd.TabIndex = 16
        Me.pnlAdd.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Location = New System.Drawing.Point(1, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(22, 22)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.btnBuscar)
        Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBusqueda.Location = New System.Drawing.Point(200, 0)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(23, 21)
        Me.pnlBusqueda.TabIndex = 15
        Me.pnlBusqueda.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.APPControls.My.Resources.Resources._1345240399_search_button
        Me.btnBuscar.Location = New System.Drawing.Point(1, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(22, 22)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'uscComboParametrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlCombo)
        Me.Name = "uscComboParametrica"
        Me.Size = New System.Drawing.Size(223, 21)
        Me.pnlCombo.ResumeLayout(False)
        Me.pnlEliminar.ResumeLayout(False)
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlBusqueda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
    Friend WithEvents pnlCombo As System.Windows.Forms.Panel
    Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As Legolas.APPUIComponents.myButton
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As Legolas.APPUIComponents.myButton
    Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As Legolas.APPUIComponents.myButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
