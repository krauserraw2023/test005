

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscLabelBusqueda
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
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.btnBuscar = New Legolas.APPUIComponents.myButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
        Me.pnlEliminar = New System.Windows.Forms.Panel()
        Me.btnEliminar = New Legolas.APPUIComponents.myButton()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.btnAdd = New Legolas.APPUIComponents.myButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlBusqueda.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlEliminar.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.btnBuscar)
        Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBusqueda.Location = New System.Drawing.Point(230, 0)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(23, 23)
        Me.pnlBusqueda.TabIndex = 11
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.APPControls.My.Resources.Resources._1345240399_search_button
        Me.btnBuscar.Location = New System.Drawing.Point(1, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(22, 22)
        Me.btnBuscar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Presione la tecla [F3], para buscar el registro")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.pnlEliminar)
        Me.Panel3.Controls.Add(Me.pnlAdd)
        Me.Panel3.Controls.Add(Me.pnlBusqueda)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 23)
        Me.Panel3.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNombre._BloquearPaste = False
        Me.txtNombre._SeleccionarTodo = False
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Location = New System.Drawing.Point(0, 0)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(184, 20)
        Me.txtNombre.TabIndex = 12
        Me.txtNombre.Text = "[SELECCIONE]"
        Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
        Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
        '
        'pnlEliminar
        '
        Me.pnlEliminar.Controls.Add(Me.btnEliminar)
        Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEliminar.Location = New System.Drawing.Point(184, 0)
        Me.pnlEliminar.Name = "pnlEliminar"
        Me.pnlEliminar.Size = New System.Drawing.Size(23, 23)
        Me.pnlEliminar.TabIndex = 14
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
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Limpiar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'pnlAdd
        '
        Me.pnlAdd.Controls.Add(Me.btnAdd)
        Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlAdd.Location = New System.Drawing.Point(207, 0)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(23, 23)
        Me.pnlAdd.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Location = New System.Drawing.Point(1, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(22, 22)
        Me.btnAdd.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Agregar nuevo")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'uscLabelBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uscLabelBusqueda"
        Me.Size = New System.Drawing.Size(253, 21)
        Me.pnlBusqueda.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlEliminar.ResumeLayout(False)
        Me.pnlAdd.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As Legolas.APPUIComponents.myButton
    Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As Legolas.APPUIComponents.myButton
    Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As Legolas.APPUIComponents.myButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
