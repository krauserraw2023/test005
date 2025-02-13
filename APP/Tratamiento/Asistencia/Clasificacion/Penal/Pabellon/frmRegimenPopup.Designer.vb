Namespace Tratamiento.Asistencia.Clasificacion.Penal.Pabellon
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmRegimenPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.components = New System.ComponentModel.Container()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbEtapa = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.pnlRegimen = New System.Windows.Forms.Panel()
            Me.lblRegimen = New System.Windows.Forms.Label()
            Me.cbbRegimen = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlRegimen.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(424, 175)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Controls.Add(Me.pnlRegimen)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(399, 99)
            Me.GroupBox1.TabIndex = 97
            Me.GroupBox1.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Controls.Add(Me.cbbEtapa)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 51)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(393, 35)
            Me.Panel3.TabIndex = 33
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(19, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(48, 13)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "ETAPA :"
            '
            'cbbEtapa
            '
            Me.cbbEtapa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbEtapa.Location = New System.Drawing.Point(89, 6)
            Me.cbbEtapa.Name = "cbbEtapa"
            Me.cbbEtapa.Size = New System.Drawing.Size(298, 23)
            Me.cbbEtapa.TabIndex = 8
            '
            'pnlRegimen
            '
            Me.pnlRegimen.Controls.Add(Me.lblRegimen)
            Me.pnlRegimen.Controls.Add(Me.cbbRegimen)
            Me.pnlRegimen.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRegimen.Location = New System.Drawing.Point(3, 16)
            Me.pnlRegimen.Name = "pnlRegimen"
            Me.pnlRegimen.Size = New System.Drawing.Size(393, 35)
            Me.pnlRegimen.TabIndex = 32
            '
            'lblRegimen
            '
            Me.lblRegimen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblRegimen.AutoSize = True
            Me.lblRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegimen.Location = New System.Drawing.Point(19, 11)
            Me.lblRegimen.Name = "lblRegimen"
            Me.lblRegimen.Size = New System.Drawing.Size(63, 13)
            Me.lblRegimen.TabIndex = 7
            Me.lblRegimen.Text = "REGIMEN :"
            '
            'cbbRegimen
            '
            Me.cbbRegimen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimen.Location = New System.Drawing.Point(89, 6)
            Me.cbbRegimen.Name = "cbbRegimen"
            Me.cbbRegimen.Size = New System.Drawing.Size(298, 23)
            Me.cbbRegimen.TabIndex = 8
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 129)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(424, 46)
            Me.Panel1.TabIndex = 98
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnOK)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(220, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(204, 46)
            Me.Panel2.TabIndex = 99
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(3, 3)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 4
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(103, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmRegimenPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(424, 175)
            Me.Name = "frmRegimenPopup"
            Me.Text = "Régimen / Etapa"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlRegimen.ResumeLayout(False)
            Me.pnlRegimen.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents cbbEtapa As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents pnlRegimen As Panel
        Friend WithEvents lblRegimen As Label
        Friend WithEvents cbbRegimen As Legolas.APPUIComponents.MyComboBox
    End Class
End Namespace