﻿Namespace Sistema.Seguridad.Usuario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmPermisoDetalle
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
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_doc_jdu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sit_jur = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_aut = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_juez_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminar = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_sele = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.colu_sele = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.txtAccion = New System.Windows.Forms.TextBox()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.txtFechahabilitacion = New System.Windows.Forms.TextBox()
            Me.txtUsuariohabilita = New System.Windows.Forms.TextBox()
            Me.txtFechadeshabilita = New System.Windows.Forms.TextBox()
            Me.txtUsuariodeshabilita = New System.Windows.Forms.TextBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(430, 241)
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel6)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 195)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(430, 46)
            Me.Panel2.TabIndex = 0
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnCancel)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(227, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(203, 46)
            Me.Panel6.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.revocatoria
            Me.btnCancel.Location = New System.Drawing.Point(108, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(90, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'col_sel
            '
            Me.col_sel.HeaderText = "Elegir"
            Me.col_sel.Name = "col_sel"
            Me.col_sel.Width = 37
            '
            'col_doc_jdu_id
            '
            Me.col_doc_jdu_id.DataPropertyName = "CreaDocJudicialId"
            Me.col_doc_jdu_id.DividerWidth = 1
            Me.col_doc_jdu_id.HeaderText = "DocJudicialId"
            Me.col_doc_jdu_id.Name = "col_doc_jdu_id"
            Me.col_doc_jdu_id.Visible = False
            Me.col_doc_jdu_id.Width = 70
            '
            'col_item
            '
            Me.col_item.DataPropertyName = "ExpedienteItem"
            Me.col_item.HeaderText = "Item"
            Me.col_item.Name = "col_item"
            Me.col_item.Visible = False
            Me.col_item.Width = 30
            '
            'col_num_exp
            '
            Me.col_num_exp.DataPropertyName = "ExpedienteNumero"
            Me.col_num_exp.HeaderText = "N° Exp."
            Me.col_num_exp.Name = "col_num_exp"
            '
            'col_sit_jur
            '
            Me.col_sit_jur.DataPropertyName = "SituacionJuridicaNombre"
            Me.col_sit_jur.HeaderText = "Sit. Juridica"
            Me.col_sit_jur.Name = "col_sit_jur"
            Me.col_sit_jur.Width = 85
            '
            'col_tip_aut
            '
            Me.col_tip_aut.DataPropertyName = "TipoAutoridadJudicialID"
            Me.col_tip_aut.HeaderText = "Tipo Aut."
            Me.col_tip_aut.Name = "col_tip_aut"
            Me.col_tip_aut.Visible = False
            Me.col_tip_aut.Width = 40
            '
            'col_aut_jud_id
            '
            Me.col_aut_jud_id.DataPropertyName = "AutoridadJudicialID"
            Me.col_aut_jud_id.HeaderText = "Aut. JudicialID"
            Me.col_aut_jud_id.Name = "col_aut_jud_id"
            Me.col_aut_jud_id.Visible = False
            Me.col_aut_jud_id.Width = 50
            '
            'col_aut_jud
            '
            Me.col_aut_jud.DataPropertyName = "AutoridadJudicialNombre"
            Me.col_aut_jud.HeaderText = "Aut. Judicial"
            Me.col_aut_jud.Name = "col_aut_jud"
            Me.col_aut_jud.Width = 225
            '
            'col_sal_jud_id
            '
            Me.col_sal_jud_id.DataPropertyName = "SalaJudicialID"
            Me.col_sal_jud_id.HeaderText = "SalaJudID"
            Me.col_sal_jud_id.Name = "col_sal_jud_id"
            Me.col_sal_jud_id.Visible = False
            Me.col_sal_jud_id.Width = 50
            '
            'col_sal_jud
            '
            Me.col_sal_jud.DataPropertyName = "SalaJudicialNombre"
            Me.col_sal_jud.HeaderText = "Sala Judicial"
            Me.col_sal_jud.Name = "col_sal_jud"
            Me.col_sal_jud.Width = 225
            '
            'col_juez_nom
            '
            Me.col_juez_nom.DataPropertyName = "ExpedienteJuez"
            Me.col_juez_nom.HeaderText = "Juez"
            Me.col_juez_nom.Name = "col_juez_nom"
            Me.col_juez_nom.Visible = False
            '
            'col_secre
            '
            Me.col_secre.DataPropertyName = "ExpedienteSecretario"
            Me.col_secre.HeaderText = "Secretario"
            Me.col_secre.Name = "col_secre"
            Me.col_secre.Width = 140
            '
            'col_eliminar
            '
            Me.col_eliminar.DataPropertyName = "Eliminar"
            Me.col_eliminar.HeaderText = ""
            Me.col_eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_eliminar.Name = "col_eliminar"
            Me.col_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_eliminar.Visible = False
            Me.col_eliminar.Width = 35
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.txtUsuariodeshabilita)
            Me.Panel1.Controls.Add(Me.txtFechadeshabilita)
            Me.Panel1.Controls.Add(Me.txtUsuariohabilita)
            Me.Panel1.Controls.Add(Me.txtMotivo)
            Me.Panel1.Controls.Add(Me.txtFechahabilitacion)
            Me.Panel1.Controls.Add(Me.txtAccion)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(430, 195)
            Me.Panel1.TabIndex = 94
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(3, 171)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(140, 16)
            Me.Label7.TabIndex = 7
            Me.Label7.Text = "Usuario que inhabilito:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(2, 116)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(130, 16)
            Me.Label6.TabIndex = 6
            Me.Label6.Text = "Usuario que habilito:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 48)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(54, 16)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Motivo :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(3, 143)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(130, 16)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Fecha Inhabilitación:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(2, 90)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(123, 16)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Fecha Habilitacion:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(2, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 16)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Acción :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(7, 61)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(414, 16)
            Me.Label8.TabIndex = 15
            Me.Label8.Text = "__________________________________________________________"
            '
            'DataGridViewCheckBoxColumn1
            '
            Me.DataGridViewCheckBoxColumn1.HeaderText = "Elegir"
            Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
            Me.DataGridViewCheckBoxColumn1.Width = 37
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "CreaDocJudicialId"
            Me.DataGridViewTextBoxColumn1.DividerWidth = 1
            Me.DataGridViewTextBoxColumn1.HeaderText = "DocJudicialId"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.Visible = False
            Me.DataGridViewTextBoxColumn1.Width = 70
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "ExpedienteItem"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.Visible = False
            Me.DataGridViewTextBoxColumn2.Width = 30
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "ExpedienteNumero"
            Me.DataGridViewTextBoxColumn3.HeaderText = "N° Exp."
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "SituacionJuridicaNombre"
            Me.DataGridViewTextBoxColumn4.HeaderText = "Sit. Juridica"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.Width = 85
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "TipoAutoridadJudicialID"
            Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo Aut."
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.Visible = False
            Me.DataGridViewTextBoxColumn5.Width = 40
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "AutoridadJudicialID"
            Me.DataGridViewTextBoxColumn6.HeaderText = "Aut. JudicialID"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.Visible = False
            Me.DataGridViewTextBoxColumn6.Width = 50
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "AutoridadJudicialNombre"
            Me.DataGridViewTextBoxColumn7.HeaderText = "Aut. Judicial"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.Width = 225
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "SalaJudicialID"
            Me.DataGridViewTextBoxColumn8.HeaderText = "SalaJudID"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.Visible = False
            Me.DataGridViewTextBoxColumn8.Width = 50
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "SalaJudicialNombre"
            Me.DataGridViewTextBoxColumn9.HeaderText = "Sala Judicial"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.Width = 225
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.DataPropertyName = "ExpedienteJuez"
            Me.DataGridViewTextBoxColumn10.HeaderText = "Juez"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.Visible = False
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "ExpedienteSecretario"
            Me.DataGridViewTextBoxColumn11.HeaderText = "Secretario"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.Width = 140
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.DataPropertyName = "Eliminar"
            Me.DataGridViewImageColumn1.HeaderText = ""
            Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn1.Visible = False
            Me.DataGridViewImageColumn1.Width = 35
            '
            'col_sele
            '
            Me.col_sele.HeaderText = "Elegir"
            Me.col_sele.Name = "col_sele"
            Me.col_sele.Width = 37
            '
            'DataGridViewTextBoxColumn12
            '
            Me.DataGridViewTextBoxColumn12.DataPropertyName = "CreaDocJudicialId"
            Me.DataGridViewTextBoxColumn12.DividerWidth = 1
            Me.DataGridViewTextBoxColumn12.HeaderText = "DocJudicialId"
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            Me.DataGridViewTextBoxColumn12.Visible = False
            Me.DataGridViewTextBoxColumn12.Width = 70
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "ExpedienteItem"
            Me.DataGridViewTextBoxColumn13.HeaderText = "Item"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.Visible = False
            Me.DataGridViewTextBoxColumn13.Width = 30
            '
            'DataGridViewTextBoxColumn14
            '
            Me.DataGridViewTextBoxColumn14.DataPropertyName = "ExpedienteNumero"
            Me.DataGridViewTextBoxColumn14.HeaderText = "N° Exp."
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            '
            'DataGridViewTextBoxColumn15
            '
            Me.DataGridViewTextBoxColumn15.DataPropertyName = "SituacionJuridicaNombre"
            Me.DataGridViewTextBoxColumn15.HeaderText = "Sit. Juridica"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.Width = 85
            '
            'DataGridViewTextBoxColumn16
            '
            Me.DataGridViewTextBoxColumn16.DataPropertyName = "TipoAutoridadJudicialID"
            Me.DataGridViewTextBoxColumn16.HeaderText = "Tipo Aut."
            Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
            Me.DataGridViewTextBoxColumn16.Visible = False
            Me.DataGridViewTextBoxColumn16.Width = 40
            '
            'DataGridViewTextBoxColumn17
            '
            Me.DataGridViewTextBoxColumn17.DataPropertyName = "AutoridadJudicialID"
            Me.DataGridViewTextBoxColumn17.HeaderText = "Aut. JudicialID"
            Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
            Me.DataGridViewTextBoxColumn17.Visible = False
            Me.DataGridViewTextBoxColumn17.Width = 50
            '
            'DataGridViewTextBoxColumn18
            '
            Me.DataGridViewTextBoxColumn18.DataPropertyName = "AutoridadJudicialNombre"
            Me.DataGridViewTextBoxColumn18.HeaderText = "Aut. Judicial"
            Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
            Me.DataGridViewTextBoxColumn18.Width = 225
            '
            'DataGridViewTextBoxColumn19
            '
            Me.DataGridViewTextBoxColumn19.DataPropertyName = "SalaJudicialID"
            Me.DataGridViewTextBoxColumn19.HeaderText = "SalaJudID"
            Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
            Me.DataGridViewTextBoxColumn19.Visible = False
            Me.DataGridViewTextBoxColumn19.Width = 50
            '
            'DataGridViewTextBoxColumn20
            '
            Me.DataGridViewTextBoxColumn20.DataPropertyName = "SalaJudicialNombre"
            Me.DataGridViewTextBoxColumn20.HeaderText = "Sala Judicial"
            Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
            Me.DataGridViewTextBoxColumn20.Width = 225
            '
            'DataGridViewTextBoxColumn21
            '
            Me.DataGridViewTextBoxColumn21.DataPropertyName = "ExpedienteJuez"
            Me.DataGridViewTextBoxColumn21.HeaderText = "Juez"
            Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
            Me.DataGridViewTextBoxColumn21.Visible = False
            '
            'DataGridViewTextBoxColumn22
            '
            Me.DataGridViewTextBoxColumn22.DataPropertyName = "ExpedienteSecretario"
            Me.DataGridViewTextBoxColumn22.HeaderText = "Secretario"
            Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
            Me.DataGridViewTextBoxColumn22.Width = 140
            '
            'DataGridViewImageColumn2
            '
            Me.DataGridViewImageColumn2.DataPropertyName = "Eliminar"
            Me.DataGridViewImageColumn2.HeaderText = ""
            Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
            Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn2.Visible = False
            Me.DataGridViewImageColumn2.Width = 35
            '
            'DataGridViewCheckBoxColumn2
            '
            Me.DataGridViewCheckBoxColumn2.HeaderText = "Elegir"
            Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
            Me.DataGridViewCheckBoxColumn2.Width = 37
            '
            'DataGridViewTextBoxColumn23
            '
            Me.DataGridViewTextBoxColumn23.DataPropertyName = "CreaDocJudicialId"
            Me.DataGridViewTextBoxColumn23.DividerWidth = 1
            Me.DataGridViewTextBoxColumn23.HeaderText = "DocJudicialId"
            Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
            Me.DataGridViewTextBoxColumn23.Visible = False
            Me.DataGridViewTextBoxColumn23.Width = 70
            '
            'DataGridViewTextBoxColumn24
            '
            Me.DataGridViewTextBoxColumn24.DataPropertyName = "ExpedienteItem"
            Me.DataGridViewTextBoxColumn24.HeaderText = "Item"
            Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
            Me.DataGridViewTextBoxColumn24.Visible = False
            Me.DataGridViewTextBoxColumn24.Width = 30
            '
            'DataGridViewTextBoxColumn25
            '
            Me.DataGridViewTextBoxColumn25.DataPropertyName = "ExpedienteNumero"
            Me.DataGridViewTextBoxColumn25.HeaderText = "N° Exp."
            Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
            '
            'DataGridViewTextBoxColumn26
            '
            Me.DataGridViewTextBoxColumn26.DataPropertyName = "SituacionJuridicaNombre"
            Me.DataGridViewTextBoxColumn26.HeaderText = "Sit. Juridica"
            Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
            Me.DataGridViewTextBoxColumn26.Width = 85
            '
            'DataGridViewTextBoxColumn27
            '
            Me.DataGridViewTextBoxColumn27.DataPropertyName = "TipoAutoridadJudicialID"
            Me.DataGridViewTextBoxColumn27.HeaderText = "Tipo Aut."
            Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
            Me.DataGridViewTextBoxColumn27.Visible = False
            Me.DataGridViewTextBoxColumn27.Width = 40
            '
            'DataGridViewTextBoxColumn28
            '
            Me.DataGridViewTextBoxColumn28.DataPropertyName = "AutoridadJudicialID"
            Me.DataGridViewTextBoxColumn28.HeaderText = "Aut. JudicialID"
            Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
            Me.DataGridViewTextBoxColumn28.Visible = False
            Me.DataGridViewTextBoxColumn28.Width = 50
            '
            'DataGridViewTextBoxColumn29
            '
            Me.DataGridViewTextBoxColumn29.DataPropertyName = "AutoridadJudicialNombre"
            Me.DataGridViewTextBoxColumn29.HeaderText = "Aut. Judicial"
            Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
            Me.DataGridViewTextBoxColumn29.Width = 225
            '
            'DataGridViewTextBoxColumn30
            '
            Me.DataGridViewTextBoxColumn30.DataPropertyName = "SalaJudicialID"
            Me.DataGridViewTextBoxColumn30.HeaderText = "SalaJudID"
            Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
            Me.DataGridViewTextBoxColumn30.Visible = False
            Me.DataGridViewTextBoxColumn30.Width = 50
            '
            'DataGridViewTextBoxColumn31
            '
            Me.DataGridViewTextBoxColumn31.DataPropertyName = "SalaJudicialNombre"
            Me.DataGridViewTextBoxColumn31.HeaderText = "Sala Judicial"
            Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
            Me.DataGridViewTextBoxColumn31.Width = 225
            '
            'DataGridViewTextBoxColumn32
            '
            Me.DataGridViewTextBoxColumn32.DataPropertyName = "ExpedienteJuez"
            Me.DataGridViewTextBoxColumn32.HeaderText = "Juez"
            Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
            Me.DataGridViewTextBoxColumn32.Visible = False
            '
            'DataGridViewTextBoxColumn33
            '
            Me.DataGridViewTextBoxColumn33.DataPropertyName = "ExpedienteSecretario"
            Me.DataGridViewTextBoxColumn33.HeaderText = "Secretario"
            Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
            Me.DataGridViewTextBoxColumn33.Width = 140
            '
            'DataGridViewImageColumn3
            '
            Me.DataGridViewImageColumn3.DataPropertyName = "Eliminar"
            Me.DataGridViewImageColumn3.HeaderText = ""
            Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
            Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn3.Visible = False
            Me.DataGridViewImageColumn3.Width = 35
            '
            'DataGridViewCheckBoxColumn3
            '
            Me.DataGridViewCheckBoxColumn3.HeaderText = "Elegir"
            Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
            Me.DataGridViewCheckBoxColumn3.Width = 37
            '
            'DataGridViewTextBoxColumn34
            '
            Me.DataGridViewTextBoxColumn34.DataPropertyName = "CreaDocJudicialId"
            Me.DataGridViewTextBoxColumn34.DividerWidth = 1
            Me.DataGridViewTextBoxColumn34.HeaderText = "DocJudicialId"
            Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
            Me.DataGridViewTextBoxColumn34.Visible = False
            Me.DataGridViewTextBoxColumn34.Width = 70
            '
            'DataGridViewTextBoxColumn35
            '
            Me.DataGridViewTextBoxColumn35.DataPropertyName = "ExpedienteItem"
            Me.DataGridViewTextBoxColumn35.HeaderText = "Item"
            Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
            Me.DataGridViewTextBoxColumn35.Visible = False
            Me.DataGridViewTextBoxColumn35.Width = 30
            '
            'DataGridViewTextBoxColumn36
            '
            Me.DataGridViewTextBoxColumn36.DataPropertyName = "ExpedienteNumero"
            Me.DataGridViewTextBoxColumn36.HeaderText = "N° Exp."
            Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
            '
            'DataGridViewTextBoxColumn37
            '
            Me.DataGridViewTextBoxColumn37.DataPropertyName = "SituacionJuridicaNombre"
            Me.DataGridViewTextBoxColumn37.HeaderText = "Sit. Juridica"
            Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
            Me.DataGridViewTextBoxColumn37.Width = 85
            '
            'DataGridViewTextBoxColumn38
            '
            Me.DataGridViewTextBoxColumn38.DataPropertyName = "TipoAutoridadJudicialID"
            Me.DataGridViewTextBoxColumn38.HeaderText = "Tipo Aut."
            Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
            Me.DataGridViewTextBoxColumn38.Visible = False
            Me.DataGridViewTextBoxColumn38.Width = 40
            '
            'DataGridViewTextBoxColumn39
            '
            Me.DataGridViewTextBoxColumn39.DataPropertyName = "AutoridadJudicialID"
            Me.DataGridViewTextBoxColumn39.HeaderText = "Aut. JudicialID"
            Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
            Me.DataGridViewTextBoxColumn39.Visible = False
            Me.DataGridViewTextBoxColumn39.Width = 50
            '
            'DataGridViewTextBoxColumn40
            '
            Me.DataGridViewTextBoxColumn40.DataPropertyName = "AutoridadJudicialNombre"
            Me.DataGridViewTextBoxColumn40.HeaderText = "Aut. Judicial"
            Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
            Me.DataGridViewTextBoxColumn40.Width = 225
            '
            'DataGridViewTextBoxColumn41
            '
            Me.DataGridViewTextBoxColumn41.DataPropertyName = "SalaJudicialID"
            Me.DataGridViewTextBoxColumn41.HeaderText = "SalaJudID"
            Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
            Me.DataGridViewTextBoxColumn41.Visible = False
            Me.DataGridViewTextBoxColumn41.Width = 50
            '
            'DataGridViewTextBoxColumn42
            '
            Me.DataGridViewTextBoxColumn42.DataPropertyName = "SalaJudicialNombre"
            Me.DataGridViewTextBoxColumn42.HeaderText = "Sala Judicial"
            Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
            Me.DataGridViewTextBoxColumn42.Width = 225
            '
            'DataGridViewTextBoxColumn43
            '
            Me.DataGridViewTextBoxColumn43.DataPropertyName = "ExpedienteJuez"
            Me.DataGridViewTextBoxColumn43.HeaderText = "Juez"
            Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
            Me.DataGridViewTextBoxColumn43.Visible = False
            '
            'DataGridViewTextBoxColumn44
            '
            Me.DataGridViewTextBoxColumn44.DataPropertyName = "ExpedienteSecretario"
            Me.DataGridViewTextBoxColumn44.HeaderText = "Secretario"
            Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
            Me.DataGridViewTextBoxColumn44.Width = 140
            '
            'DataGridViewImageColumn4
            '
            Me.DataGridViewImageColumn4.DataPropertyName = "Eliminar"
            Me.DataGridViewImageColumn4.HeaderText = ""
            Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
            Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn4.Visible = False
            Me.DataGridViewImageColumn4.Width = 35
            '
            'colu_sele
            '
            Me.colu_sele.HeaderText = "Elegir"
            Me.colu_sele.Name = "colu_sele"
            Me.colu_sele.Width = 37
            '
            'txtAccion
            '
            Me.txtAccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAccion.Location = New System.Drawing.Point(148, 18)
            Me.txtAccion.Name = "txtAccion"
            Me.txtAccion.ReadOnly = True
            Me.txtAccion.Size = New System.Drawing.Size(269, 20)
            Me.txtAccion.TabIndex = 16
            '
            'txtMotivo
            '
            Me.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMotivo.Location = New System.Drawing.Point(148, 48)
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.ReadOnly = True
            Me.txtMotivo.Size = New System.Drawing.Size(269, 20)
            Me.txtMotivo.TabIndex = 17
            '
            'txtFechahabilitacion
            '
            Me.txtFechahabilitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFechahabilitacion.Location = New System.Drawing.Point(148, 86)
            Me.txtFechahabilitacion.Name = "txtFechahabilitacion"
            Me.txtFechahabilitacion.ReadOnly = True
            Me.txtFechahabilitacion.Size = New System.Drawing.Size(269, 20)
            Me.txtFechahabilitacion.TabIndex = 18
            '
            'txtUsuariohabilita
            '
            Me.txtUsuariohabilita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtUsuariohabilita.Location = New System.Drawing.Point(148, 113)
            Me.txtUsuariohabilita.Name = "txtUsuariohabilita"
            Me.txtUsuariohabilita.ReadOnly = True
            Me.txtUsuariohabilita.Size = New System.Drawing.Size(269, 20)
            Me.txtUsuariohabilita.TabIndex = 19
            '
            'txtFechadeshabilita
            '
            Me.txtFechadeshabilita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFechadeshabilita.Location = New System.Drawing.Point(148, 141)
            Me.txtFechadeshabilita.Name = "txtFechadeshabilita"
            Me.txtFechadeshabilita.ReadOnly = True
            Me.txtFechadeshabilita.Size = New System.Drawing.Size(269, 20)
            Me.txtFechadeshabilita.TabIndex = 20
            '
            'txtUsuariodeshabilita
            '
            Me.txtUsuariodeshabilita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtUsuariodeshabilita.Location = New System.Drawing.Point(148, 168)
            Me.txtUsuariodeshabilita.Name = "txtUsuariodeshabilita"
            Me.txtUsuariodeshabilita.ReadOnly = True
            Me.txtUsuariodeshabilita.Size = New System.Drawing.Size(269, 20)
            Me.txtUsuariodeshabilita.TabIndex = 21
            '
            'frmPermisoDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(430, 241)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "frmPermisoDetalle"
            Me.Text = "Detalle permiso"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents col_sel As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_doc_jdu_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_exp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sit_jur As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_aut As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_juez_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_secre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eliminar As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colu_sele As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_sele As System.Windows.Forms.DataGridViewCheckBoxColumn
        'Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
        'Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
        'Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Label7 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents txtUsuariodeshabilita As TextBox
        Friend WithEvents txtFechadeshabilita As TextBox
        Friend WithEvents txtUsuariohabilita As TextBox
        Friend WithEvents txtMotivo As TextBox
        Friend WithEvents txtFechahabilitacion As TextBox
        Friend WithEvents txtAccion As TextBox
        'Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace