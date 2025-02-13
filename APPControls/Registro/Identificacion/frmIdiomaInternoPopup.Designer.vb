Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmIdiomaInternoPopup
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbAvanzado = New System.Windows.Forms.RadioButton()
            Me.rdbIntermedio = New System.Windows.Forms.RadioButton()
            Me.rdbBasico = New System.Windows.Forms.RadioButton()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblNroIngreso = New System.Windows.Forms.Label()
            Me.cboIdiomaPrincipal = New APPControls.uscComboParametrica()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.lblNroIngreso)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.cboIdiomaPrincipal)
            Me.gbxFormChildContainer.Controls.Add(Me.Label2)
            Me.gbxFormChildContainer.Controls.Add(Me.Label3)
            Me.gbxFormChildContainer.Controls.Add(Me.Label1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(459, 156)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 110)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(459, 46)
            Me.Panel1.TabIndex = 0
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOK)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(255, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(204, 46)
            Me.Panel2.TabIndex = 7
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(104, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 97
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(4, 3)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(98, 40)
            Me.btnOK.TabIndex = 96
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(35, 38)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(41, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Idioma:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(28, 66)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(48, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Dominio:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbAvanzado)
            Me.GroupBox1.Controls.Add(Me.rdbIntermedio)
            Me.GroupBox1.Controls.Add(Me.rdbBasico)
            Me.GroupBox1.Location = New System.Drawing.Point(80, 57)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(368, 39)
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            '
            'rdbAvanzado
            '
            Me.rdbAvanzado.AutoSize = True
            Me.rdbAvanzado.Location = New System.Drawing.Point(271, 14)
            Me.rdbAvanzado.Name = "rdbAvanzado"
            Me.rdbAvanzado.Size = New System.Drawing.Size(73, 17)
            Me.rdbAvanzado.TabIndex = 2
            Me.rdbAvanzado.TabStop = True
            Me.rdbAvanzado.Text = "Avanzado"
            Me.rdbAvanzado.UseVisualStyleBackColor = True
            '
            'rdbIntermedio
            '
            Me.rdbIntermedio.AutoSize = True
            Me.rdbIntermedio.Location = New System.Drawing.Point(147, 14)
            Me.rdbIntermedio.Name = "rdbIntermedio"
            Me.rdbIntermedio.Size = New System.Drawing.Size(74, 17)
            Me.rdbIntermedio.TabIndex = 1
            Me.rdbIntermedio.TabStop = True
            Me.rdbIntermedio.Text = "Intermedio"
            Me.rdbIntermedio.UseVisualStyleBackColor = True
            '
            'rdbBasico
            '
            Me.rdbBasico.AutoSize = True
            Me.rdbBasico.Location = New System.Drawing.Point(27, 14)
            Me.rdbBasico.Name = "rdbBasico"
            Me.rdbBasico.Size = New System.Drawing.Size(57, 17)
            Me.rdbBasico.TabIndex = 0
            Me.rdbBasico.TabStop = True
            Me.rdbBasico.Text = "Básico"
            Me.rdbBasico.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(16, 11)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "N° Ingreso:"
            '
            'lblNroIngreso
            '
            Me.lblNroIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNroIngreso.Location = New System.Drawing.Point(80, 10)
            Me.lblNroIngreso.Name = "lblNroIngreso"
            Me.lblNroIngreso.Size = New System.Drawing.Size(221, 20)
            Me.lblNroIngreso.TabIndex = 5
            Me.lblNroIngreso.Text = "01"
            Me.lblNroIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboIdiomaPrincipal
            '
            Me.cboIdiomaPrincipal._NoIndica = False
            Me.cboIdiomaPrincipal._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cboIdiomaPrincipal._Todos = False
            Me.cboIdiomaPrincipal._TodosMensaje = ""
            Me.cboIdiomaPrincipal._Visible_Add = False
            Me.cboIdiomaPrincipal._Visible_Buscar = False
            Me.cboIdiomaPrincipal._Visible_Eliminar = False
            Me.cboIdiomaPrincipal.CodigoPadre = -1
            Me.cboIdiomaPrincipal.ComboTipo = CType(77, Short)
            Me.cboIdiomaPrincipal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cboIdiomaPrincipal.DropDownWidth = 281
            Me.cboIdiomaPrincipal.DropDownWidthAuto = False
            Me.cboIdiomaPrincipal.ListaIdsParaExcluir = Nothing
            Me.cboIdiomaPrincipal.Location = New System.Drawing.Point(80, 35)
            Me.cboIdiomaPrincipal.ModuloTratamiento = False
            Me.cboIdiomaPrincipal.Name = "cboIdiomaPrincipal"
            Me.cboIdiomaPrincipal.Parametro1 = -1
            Me.cboIdiomaPrincipal.Parametro2 = -1
            Me.cboIdiomaPrincipal.SelectedIndex = -1
            Me.cboIdiomaPrincipal.SelectedValue = 0
            Me.cboIdiomaPrincipal.Size = New System.Drawing.Size(367, 22)
            Me.cboIdiomaPrincipal.TabIndex = 3
            '
            'frmIdiomaInternoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(459, 156)
            Me.Name = "frmIdiomaInternoPopup"
            Me.Text = "Mantenimiento de idiomas del interno."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboIdiomaPrincipal As APPControls.uscComboParametrica
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbAvanzado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIntermedio As System.Windows.Forms.RadioButton
        Friend WithEvents rdbBasico As System.Windows.Forms.RadioButton
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblNroIngreso As System.Windows.Forms.Label
    End Class
End Namespace