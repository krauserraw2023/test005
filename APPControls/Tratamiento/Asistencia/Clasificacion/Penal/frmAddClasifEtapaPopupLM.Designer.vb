Namespace Tratamiento.Asistencia.Clasificacion.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmAddClasifEtapaPopupLM
        Inherits System.Windows.Forms.Form

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
            Me.PnlBotonesPrincipal = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnGrabarClasificacion = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.dtpFechaLM = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbSitJuridicaLM = New System.Windows.Forms.ComboBox()
            Me.lblRegimen = New System.Windows.Forms.Label()
            Me.cbbRegimenLM = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.rdbRegimenETL = New System.Windows.Forms.RadioButton()
            Me.rdbClasifRegimenPenal = New System.Windows.Forms.RadioButton()
            Me.grupLM = New System.Windows.Forms.GroupBox()
            Me.dtpHoraLM = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dtpHoraRegimen = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaRegimen = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.cbbSitJuridicaETL = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbRegimenETL = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpHoraETAPA = New System.Windows.Forms.DateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dtpFechaETAPA = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.PnlBotonesPrincipal.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.grupLM.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PnlBotonesPrincipal
            '
            Me.PnlBotonesPrincipal.Controls.Add(Me.Panel2)
            Me.PnlBotonesPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotonesPrincipal.Location = New System.Drawing.Point(0, 274)
            Me.PnlBotonesPrincipal.Name = "PnlBotonesPrincipal"
            Me.PnlBotonesPrincipal.Size = New System.Drawing.Size(630, 43)
            Me.PnlBotonesPrincipal.TabIndex = 5
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnGrabarClasificacion)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(444, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(186, 43)
            Me.Panel2.TabIndex = 3
            '
            'btnGrabarClasificacion
            '
            Me.btnGrabarClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarClasificacion.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnGrabarClasificacion.Location = New System.Drawing.Point(4, 1)
            Me.btnGrabarClasificacion.Name = "btnGrabarClasificacion"
            Me.btnGrabarClasificacion.Size = New System.Drawing.Size(89, 40)
            Me.btnGrabarClasificacion.TabIndex = 1
            Me.btnGrabarClasificacion.Text = "&Grabar"
            Me.btnGrabarClasificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(94, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(89, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dtpFechaLM
            '
            Me.dtpFechaLM.Enabled = False
            Me.dtpFechaLM.Location = New System.Drawing.Point(137, 15)
            Me.dtpFechaLM.Name = "dtpFechaLM"
            Me.dtpFechaLM.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaLM.TabIndex = 34
            Me.dtpFechaLM.Value = "/  /"
            Me.dtpFechaLM.ValueLong = CType(0, Long)
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(6, 19)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(127, 16)
            Me.Label11.TabIndex = 33
            Me.Label11.Text = "Fecha Clasificación:"
            '
            'Label9
            '
            Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(329, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(115, 16)
            Me.Label9.TabIndex = 37
            Me.Label9.Text = "Situación Jurídica:"
            '
            'cbbSitJuridicaLM
            '
            Me.cbbSitJuridicaLM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbbSitJuridicaLM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbSitJuridicaLM.Enabled = False
            Me.cbbSitJuridicaLM.FormattingEnabled = True
            Me.cbbSitJuridicaLM.Items.AddRange(New Object() {"[--SELECCIONE--]", "PROCESADO", "SENTENCIADO"})
            Me.cbbSitJuridicaLM.Location = New System.Drawing.Point(449, 14)
            Me.cbbSitJuridicaLM.Name = "cbbSitJuridicaLM"
            Me.cbbSitJuridicaLM.Size = New System.Drawing.Size(124, 21)
            Me.cbbSitJuridicaLM.TabIndex = 38
            '
            'lblRegimen
            '
            Me.lblRegimen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblRegimen.AutoSize = True
            Me.lblRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegimen.Location = New System.Drawing.Point(56, 46)
            Me.lblRegimen.Name = "lblRegimen"
            Me.lblRegimen.Size = New System.Drawing.Size(75, 16)
            Me.lblRegimen.TabIndex = 39
            Me.lblRegimen.Text = "REGIMEN :"
            Me.lblRegimen.Visible = False
            '
            'cbbRegimenLM
            '
            Me.cbbRegimenLM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimenLM.Enabled = False
            Me.cbbRegimenLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimenLM.Location = New System.Drawing.Point(137, 42)
            Me.cbbRegimenLM.Name = "cbbRegimenLM"
            Me.cbbRegimenLM.Size = New System.Drawing.Size(436, 23)
            Me.cbbRegimenLM.TabIndex = 40
            Me.cbbRegimenLM.Visible = False
            '
            'rdbRegimenETL
            '
            Me.rdbRegimenETL.AutoSize = True
            Me.rdbRegimenETL.Checked = True
            Me.rdbRegimenETL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbRegimenETL.ForeColor = System.Drawing.Color.Blue
            Me.rdbRegimenETL.Location = New System.Drawing.Point(23, 10)
            Me.rdbRegimenETL.Name = "rdbRegimenETL"
            Me.rdbRegimenETL.Size = New System.Drawing.Size(373, 17)
            Me.rdbRegimenETL.TabIndex = 41
            Me.rdbRegimenETL.TabStop = True
            Me.rdbRegimenETL.Text = "Cuando el interno ha sido clasificado a régimen en carceleta."
            Me.rdbRegimenETL.UseVisualStyleBackColor = True
            '
            'rdbClasifRegimenPenal
            '
            Me.rdbClasifRegimenPenal.AutoSize = True
            Me.rdbClasifRegimenPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbClasifRegimenPenal.ForeColor = System.Drawing.Color.Blue
            Me.rdbClasifRegimenPenal.Location = New System.Drawing.Point(23, 184)
            Me.rdbClasifRegimenPenal.Name = "rdbClasifRegimenPenal"
            Me.rdbClasifRegimenPenal.Size = New System.Drawing.Size(522, 17)
            Me.rdbClasifRegimenPenal.TabIndex = 42
            Me.rdbClasifRegimenPenal.Text = "Clasificación a etapa (Cuando el interno NO ha sido clasificado a régimen en carc" &
    "eleta)"
            Me.rdbClasifRegimenPenal.UseVisualStyleBackColor = True
            '
            'grupLM
            '
            Me.grupLM.Controls.Add(Me.dtpHoraLM)
            Me.grupLM.Controls.Add(Me.dtpFechaLM)
            Me.grupLM.Controls.Add(Me.Label11)
            Me.grupLM.Controls.Add(Me.lblRegimen)
            Me.grupLM.Controls.Add(Me.cbbRegimenLM)
            Me.grupLM.Controls.Add(Me.Label9)
            Me.grupLM.Controls.Add(Me.cbbSitJuridicaLM)
            Me.grupLM.Enabled = False
            Me.grupLM.Location = New System.Drawing.Point(45, 197)
            Me.grupLM.Name = "grupLM"
            Me.grupLM.Size = New System.Drawing.Size(579, 70)
            Me.grupLM.TabIndex = 43
            Me.grupLM.TabStop = False
            '
            'dtpHoraLM
            '
            Me.dtpHoraLM.CustomFormat = "hh:mm tt"
            Me.dtpHoraLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHoraLM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHoraLM.Location = New System.Drawing.Point(222, 14)
            Me.dtpHoraLM.Name = "dtpHoraLM"
            Me.dtpHoraLM.ShowUpDown = True
            Me.dtpHoraLM.Size = New System.Drawing.Size(85, 21)
            Me.dtpHoraLM.TabIndex = 46
            Me.dtpHoraLM.Value = New Date(2023, 11, 16, 0, 0, 0, 0)
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dtpHoraRegimen)
            Me.GroupBox2.Controls.Add(Me.dtpFechaRegimen)
            Me.GroupBox2.Controls.Add(Me.cbbSitJuridicaETL)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.cbbRegimenETL)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(45, 33)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(579, 74)
            Me.GroupBox2.TabIndex = 46
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Datos de carceleta sobre clasificación a RËGIMEN"
            '
            'dtpHoraRegimen
            '
            Me.dtpHoraRegimen.CustomFormat = "hh:mm tt"
            Me.dtpHoraRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHoraRegimen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHoraRegimen.Location = New System.Drawing.Point(222, 19)
            Me.dtpHoraRegimen.Name = "dtpHoraRegimen"
            Me.dtpHoraRegimen.ShowUpDown = True
            Me.dtpHoraRegimen.Size = New System.Drawing.Size(81, 21)
            Me.dtpHoraRegimen.TabIndex = 46
            Me.dtpHoraRegimen.Value = New Date(2023, 11, 16, 0, 0, 0, 0)
            '
            'dtpFechaRegimen
            '
            Me.dtpFechaRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaRegimen.Location = New System.Drawing.Point(138, 19)
            Me.dtpFechaRegimen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaRegimen.Name = "dtpFechaRegimen"
            Me.dtpFechaRegimen.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRegimen.TabIndex = 34
            Me.dtpFechaRegimen.Value = "/  /"
            Me.dtpFechaRegimen.ValueLong = CType(0, Long)
            '
            'cbbSitJuridicaETL
            '
            Me.cbbSitJuridicaETL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbbSitJuridicaETL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbSitJuridicaETL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbSitJuridicaETL.FormattingEnabled = True
            Me.cbbSitJuridicaETL.Items.AddRange(New Object() {"[--SELECCIONE--]", "PROCESADO", "SENTENCIADO"})
            Me.cbbSitJuridicaETL.Location = New System.Drawing.Point(443, 18)
            Me.cbbSitJuridicaETL.Name = "cbbSitJuridicaETL"
            Me.cbbSitJuridicaETL.Size = New System.Drawing.Size(131, 23)
            Me.cbbSitJuridicaETL.TabIndex = 38
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(324, 23)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(115, 16)
            Me.Label4.TabIndex = 37
            Me.Label4.Text = "Situación Jurídica:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(7, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(127, 16)
            Me.Label1.TabIndex = 33
            Me.Label1.Text = "Fecha Clasificación:"
            '
            'cbbRegimenETL
            '
            Me.cbbRegimenETL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimenETL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimenETL.Location = New System.Drawing.Point(133, 46)
            Me.cbbRegimenETL.Name = "cbbRegimenETL"
            Me.cbbRegimenETL.Size = New System.Drawing.Size(441, 23)
            Me.cbbRegimenETL.TabIndex = 40
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(52, 51)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(75, 16)
            Me.Label3.TabIndex = 39
            Me.Label3.Text = "REGIMEN :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dtpHoraETAPA)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.dtpFechaETAPA)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(45, 115)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(579, 45)
            Me.GroupBox1.TabIndex = 45
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Clasificación a ETAPA"
            '
            'dtpHoraETAPA
            '
            Me.dtpHoraETAPA.CustomFormat = "hh:mm tt"
            Me.dtpHoraETAPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHoraETAPA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHoraETAPA.Location = New System.Drawing.Point(226, 16)
            Me.dtpHoraETAPA.Name = "dtpHoraETAPA"
            Me.dtpHoraETAPA.ShowUpDown = True
            Me.dtpHoraETAPA.Size = New System.Drawing.Size(81, 21)
            Me.dtpHoraETAPA.TabIndex = 45
            Me.dtpHoraETAPA.Value = New Date(2023, 11, 16, 0, 0, 0, 0)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(6, 21)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(127, 16)
            Me.Label5.TabIndex = 41
            Me.Label5.Text = "Fecha Clasificación:"
            '
            'dtpFechaETAPA
            '
            Me.dtpFechaETAPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaETAPA.Location = New System.Drawing.Point(142, 17)
            Me.dtpFechaETAPA.Name = "dtpFechaETAPA"
            Me.dtpFechaETAPA.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaETAPA.TabIndex = 42
            Me.dtpFechaETAPA.Value = "/  /"
            Me.dtpFechaETAPA.ValueLong = CType(0, Long)
            '
            'frmAddClasifEtapaPopupLM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(630, 317)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.rdbClasifRegimenPenal)
            Me.Controls.Add(Me.rdbRegimenETL)
            Me.Controls.Add(Me.grupLM)
            Me.Controls.Add(Me.PnlBotonesPrincipal)
            Me.Name = "frmAddClasifEtapaPopupLM"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = ".::. "
            Me.PnlBotonesPrincipal.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.grupLM.ResumeLayout(False)
            Me.grupLM.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents PnlBotonesPrincipal As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnGrabarClasificacion As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents dtpFechaLM As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label11 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents cbbSitJuridicaLM As ComboBox
        Friend WithEvents lblRegimen As Label
        Friend WithEvents cbbRegimenLM As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents rdbRegimenETL As RadioButton
        Friend WithEvents rdbClasifRegimenPenal As RadioButton
        Friend WithEvents grupLM As GroupBox
        Friend WithEvents dtpFechaRegimen As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label1 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents cbbRegimenETL As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label4 As Label
        Friend WithEvents cbbSitJuridicaETL As ComboBox
        Friend WithEvents dtpFechaETAPA As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As Label
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents dtpHoraETAPA As DateTimePicker
        Friend WithEvents dtpHoraRegimen As DateTimePicker
        Friend WithEvents dtpHoraLM As DateTimePicker
    End Class
End Namespace