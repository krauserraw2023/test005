Namespace Visita.Programacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDetalleExtraordinarioPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtVisitante = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbbParentesco = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTipoDocNum = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(405, 159)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(53, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Visitante :"
            '
            'txtVisitante
            '
            Me.txtVisitante._BloquearPaste = False
            Me.txtVisitante._SeleccionarTodo = False
            Me.txtVisitante.Location = New System.Drawing.Point(109, 20)
            Me.txtVisitante.Name = "txtVisitante"
            Me.txtVisitante.ReadOnly = True
            Me.txtVisitante.Size = New System.Drawing.Size(291, 20)
            Me.txtVisitante.TabIndex = 81
            Me.txtVisitante.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtVisitante.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(11, 77)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(67, 13)
            Me.Label8.TabIndex = 84
            Me.Label8.Text = "Parentesco :"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.txtTipoDocNum)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtVisitante)
            Me.GroupBox2.Controls.Add(Me.cbbParentesco)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(405, 110)
            Me.GroupBox2.TabIndex = 86
            Me.GroupBox2.TabStop = False
            '
            'cbbParentesco
            '
            Me.cbbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbParentesco.FormattingEnabled = True
            Me.cbbParentesco.Location = New System.Drawing.Point(109, 72)
            Me.cbbParentesco.Name = "cbbParentesco"
            Me.cbbParentesco.Size = New System.Drawing.Size(291, 21)
            Me.cbbParentesco.TabIndex = 87
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOK)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(201, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(204, 49)
            Me.Panel1.TabIndex = 87
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(97, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(2, 4)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 85
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 110)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(405, 49)
            Me.Panel2.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(11, 49)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 88
            Me.Label2.Text = "Tipo y Num Doc. :"
            '
            'txtTipoDocNum
            '
            Me.txtTipoDocNum._BloquearPaste = False
            Me.txtTipoDocNum._SeleccionarTodo = False
            Me.txtTipoDocNum.Location = New System.Drawing.Point(109, 46)
            Me.txtTipoDocNum.Name = "txtTipoDocNum"
            Me.txtTipoDocNum.ReadOnly = True
            Me.txtTipoDocNum.Size = New System.Drawing.Size(291, 20)
            Me.txtTipoDocNum.TabIndex = 89
            Me.txtTipoDocNum.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoDocNum.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'frmDetalleExtraordinarioPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(405, 159)
            Me.Name = "frmDetalleExtraordinarioPopup"
            Me.Text = "Actualizar..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtVisitante As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents cbbParentesco As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtTipoDocNum As Legolas.APPUIComponents.MyTextBox

    End Class
End Namespace