Namespace Tratamiento.Asistencia.Clasificacion.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMantFichPorRegresionPopup
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlBotonesPrincipal = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnFinalizar = New System.Windows.Forms.Button()
            Me.btnGrabarClasificacion = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAceptIncador = New System.Windows.Forms.Button()
            Me.btnCancelIndicador = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.cbbPenalDestino = New APPControls.uscComboParametrica()
            Me.cbbRegionDestino = New APPControls.uscComboParametrica()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.cbbRegionOrigen = New APPControls.uscComboParametrica()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.cbbPenalOrigen = New APPControls.uscComboParametrica()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.cbbRegimenEpOrigen = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label21 = New System.Windows.Forms.Label()
            Me.cbbEtapaEpOrigen = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.dtpFechaResol = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaTraslado = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtCausal = New System.Windows.Forms.TextBox()
            Me.txtResAutoriza = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgvFichaVariables = New System.Windows.Forms.DataGridView()
            Me.col_fic_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_variable_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_indicador_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_variable_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_indicador_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_etapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_button_elimina = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnBuscarPabellon = New System.Windows.Forms.Button()
            Me.lblPabellon = New System.Windows.Forms.Label()
            Me.nudMinutos = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.TextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox3 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox4 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.nudHora = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumClasificacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaClasif = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtObs = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbbEtapaClasif = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cbbRegimenClasif = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotonesPrincipal.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.nudMinutos.SuspendLayout()
            Me.nudHora.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlGrilla.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlGrilla)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotonesPrincipal)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(986, 541)
            '
            'PnlBotonesPrincipal
            '
            Me.PnlBotonesPrincipal.Controls.Add(Me.Panel2)
            Me.PnlBotonesPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotonesPrincipal.Location = New System.Drawing.Point(0, 498)
            Me.PnlBotonesPrincipal.Name = "PnlBotonesPrincipal"
            Me.PnlBotonesPrincipal.Size = New System.Drawing.Size(986, 43)
            Me.PnlBotonesPrincipal.TabIndex = 4
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnFinalizar)
            Me.Panel2.Controls.Add(Me.btnGrabarClasificacion)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(713, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(273, 43)
            Me.Panel2.TabIndex = 3
            '
            'btnFinalizar
            '
            Me.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFinalizar.Image = Global.APPControls.My.Resources.Resources.candado
            Me.btnFinalizar.Location = New System.Drawing.Point(0, 1)
            Me.btnFinalizar.Name = "btnFinalizar"
            Me.btnFinalizar.Size = New System.Drawing.Size(89, 40)
            Me.btnFinalizar.TabIndex = 98
            Me.btnFinalizar.Text = "Finalizar"
            Me.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnGrabarClasificacion
            '
            Me.btnGrabarClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarClasificacion.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnGrabarClasificacion.Location = New System.Drawing.Point(90, 1)
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
            Me.btnCancel.Location = New System.Drawing.Point(180, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(89, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.webBrowser1)
            Me.Panel3.Controls.Add(Me.Panel1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(986, 498)
            Me.Panel3.TabIndex = 6
            '
            'webBrowser1
            '
            Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
            Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.webBrowser1.Name = "webBrowser1"
            Me.webBrowser1.Size = New System.Drawing.Size(986, 456)
            Me.webBrowser1.TabIndex = 5
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnAceptIncador)
            Me.Panel1.Controls.Add(Me.btnCancelIndicador)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 456)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(986, 42)
            Me.Panel1.TabIndex = 6
            '
            'btnAceptIncador
            '
            Me.btnAceptIncador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAceptIncador.BackgroundImage = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnAceptIncador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnAceptIncador.Location = New System.Drawing.Point(903, 0)
            Me.btnAceptIncador.Name = "btnAceptIncador"
            Me.btnAceptIncador.Size = New System.Drawing.Size(38, 38)
            Me.btnAceptIncador.TabIndex = 1
            Me.btnAceptIncador.UseVisualStyleBackColor = True
            '
            'btnCancelIndicador
            '
            Me.btnCancelIndicador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancelIndicador.BackgroundImage = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancelIndicador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnCancelIndicador.Location = New System.Drawing.Point(942, 0)
            Me.btnCancelIndicador.Name = "btnCancelIndicador"
            Me.btnCancelIndicador.Size = New System.Drawing.Size(38, 38)
            Me.btnCancelIndicador.TabIndex = 0
            Me.btnCancelIndicador.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblEstado)
            Me.GroupBox1.Controls.Add(Me.Panel7)
            Me.GroupBox1.Controls.Add(Me.Panel6)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.cbbRegimenEpOrigen)
            Me.GroupBox1.Controls.Add(Me.Label21)
            Me.GroupBox1.Controls.Add(Me.cbbEtapaEpOrigen)
            Me.GroupBox1.Controls.Add(Me.dtpFechaResol)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.dtpFechaTraslado)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtCausal)
            Me.GroupBox1.Controls.Add(Me.txtResAutoriza)
            Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(968, 152)
            Me.GroupBox1.TabIndex = 52
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DATOS DE TRASLADO"
            '
            'lblEstado
            '
            Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstado.ForeColor = System.Drawing.Color.Black
            Me.lblEstado.Location = New System.Drawing.Point(764, 13)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(181, 20)
            Me.lblEstado.TabIndex = 72
            Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel7
            '
            Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel7.Controls.Add(Me.Label23)
            Me.Panel7.Controls.Add(Me.Label24)
            Me.Panel7.Controls.Add(Me.cbbPenalDestino)
            Me.Panel7.Controls.Add(Me.cbbRegionDestino)
            Me.Panel7.Location = New System.Drawing.Point(627, 88)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(318, 59)
            Me.Panel7.TabIndex = 64
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(3, 9)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(44, 13)
            Me.Label23.TabIndex = 61
            Me.Label23.Text = "Región:"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(11, 33)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(37, 13)
            Me.Label24.TabIndex = 60
            Me.Label24.Text = "Penal:"
            '
            'cbbPenalDestino
            '
            Me.cbbPenalDestino._NoIndica = False
            Me.cbbPenalDestino._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenalDestino._Todos = False
            Me.cbbPenalDestino._TodosMensaje = ""
            Me.cbbPenalDestino._Visible_Add = False
            Me.cbbPenalDestino._Visible_Buscar = False
            Me.cbbPenalDestino._Visible_Eliminar = False
            Me.cbbPenalDestino.CodigoPadre = -1
            Me.cbbPenalDestino.ComboTipo = CType(36, Short)
            Me.cbbPenalDestino.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenalDestino.DropDownWidth = 238
            Me.cbbPenalDestino.DropDownWidthAuto = False
            Me.cbbPenalDestino.ListaIdsParaExcluir = Nothing
            Me.cbbPenalDestino.Location = New System.Drawing.Point(51, 30)
            Me.cbbPenalDestino.ModuloTratamiento = False
            Me.cbbPenalDestino.Name = "cbbPenalDestino"
            Me.cbbPenalDestino.Parametro1 = -1
            Me.cbbPenalDestino.Parametro2 = -1
            Me.cbbPenalDestino.SelectedIndex = -1
            Me.cbbPenalDestino.SelectedValue = 0
            Me.cbbPenalDestino.Size = New System.Drawing.Size(260, 22)
            Me.cbbPenalDestino.TabIndex = 49
            Me.cbbPenalDestino.verToolTipItemSeleccionado = False
            '
            'cbbRegionDestino
            '
            Me.cbbRegionDestino._NoIndica = False
            Me.cbbRegionDestino._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionDestino._Todos = False
            Me.cbbRegionDestino._TodosMensaje = ""
            Me.cbbRegionDestino._Visible_Add = False
            Me.cbbRegionDestino._Visible_Buscar = False
            Me.cbbRegionDestino._Visible_Eliminar = False
            Me.cbbRegionDestino.CodigoPadre = -1
            Me.cbbRegionDestino.ComboTipo = CType(37, Short)
            Me.cbbRegionDestino.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionDestino.DropDownWidth = 178
            Me.cbbRegionDestino.DropDownWidthAuto = False
            Me.cbbRegionDestino.ListaIdsParaExcluir = Nothing
            Me.cbbRegionDestino.Location = New System.Drawing.Point(51, 5)
            Me.cbbRegionDestino.ModuloTratamiento = False
            Me.cbbRegionDestino.Name = "cbbRegionDestino"
            Me.cbbRegionDestino.Parametro1 = -1
            Me.cbbRegionDestino.Parametro2 = -1
            Me.cbbRegionDestino.SelectedIndex = -1
            Me.cbbRegionDestino.SelectedValue = 0
            Me.cbbRegionDestino.Size = New System.Drawing.Size(260, 22)
            Me.cbbRegionDestino.TabIndex = 48
            Me.cbbRegionDestino.verToolTipItemSeleccionado = False
            '
            'Panel6
            '
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel6.Controls.Add(Me.cbbRegionOrigen)
            Me.Panel6.Controls.Add(Me.Label20)
            Me.Panel6.Controls.Add(Me.cbbPenalOrigen)
            Me.Panel6.Controls.Add(Me.Label19)
            Me.Panel6.Location = New System.Drawing.Point(143, 88)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(322, 59)
            Me.Panel6.TabIndex = 63
            '
            'cbbRegionOrigen
            '
            Me.cbbRegionOrigen._NoIndica = False
            Me.cbbRegionOrigen._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionOrigen._Todos = False
            Me.cbbRegionOrigen._TodosMensaje = ""
            Me.cbbRegionOrigen._Visible_Add = False
            Me.cbbRegionOrigen._Visible_Buscar = False
            Me.cbbRegionOrigen._Visible_Eliminar = False
            Me.cbbRegionOrigen.CodigoPadre = -1
            Me.cbbRegionOrigen.ComboTipo = CType(37, Short)
            Me.cbbRegionOrigen.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionOrigen.DropDownWidth = 178
            Me.cbbRegionOrigen.DropDownWidthAuto = False
            Me.cbbRegionOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegionOrigen.ListaIdsParaExcluir = Nothing
            Me.cbbRegionOrigen.Location = New System.Drawing.Point(51, 6)
            Me.cbbRegionOrigen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.cbbRegionOrigen.ModuloTratamiento = False
            Me.cbbRegionOrigen.Name = "cbbRegionOrigen"
            Me.cbbRegionOrigen.Parametro1 = -1
            Me.cbbRegionOrigen.Parametro2 = -1
            Me.cbbRegionOrigen.SelectedIndex = -1
            Me.cbbRegionOrigen.SelectedValue = 0
            Me.cbbRegionOrigen.Size = New System.Drawing.Size(263, 22)
            Me.cbbRegionOrigen.TabIndex = 56
            Me.cbbRegionOrigen.verToolTipItemSeleccionado = False
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(3, 12)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(44, 13)
            Me.Label20.TabIndex = 59
            Me.Label20.Text = "Región:"
            '
            'cbbPenalOrigen
            '
            Me.cbbPenalOrigen._NoIndica = False
            Me.cbbPenalOrigen._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenalOrigen._Todos = False
            Me.cbbPenalOrigen._TodosMensaje = ""
            Me.cbbPenalOrigen._Visible_Add = False
            Me.cbbPenalOrigen._Visible_Buscar = False
            Me.cbbPenalOrigen._Visible_Eliminar = False
            Me.cbbPenalOrigen.CodigoPadre = -1
            Me.cbbPenalOrigen.ComboTipo = CType(36, Short)
            Me.cbbPenalOrigen.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenalOrigen.DropDownWidth = 238
            Me.cbbPenalOrigen.DropDownWidthAuto = False
            Me.cbbPenalOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPenalOrigen.ListaIdsParaExcluir = Nothing
            Me.cbbPenalOrigen.Location = New System.Drawing.Point(51, 31)
            Me.cbbPenalOrigen.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.cbbPenalOrigen.ModuloTratamiento = False
            Me.cbbPenalOrigen.Name = "cbbPenalOrigen"
            Me.cbbPenalOrigen.Parametro1 = -1
            Me.cbbPenalOrigen.Parametro2 = -1
            Me.cbbPenalOrigen.SelectedIndex = -1
            Me.cbbPenalOrigen.SelectedValue = 0
            Me.cbbPenalOrigen.Size = New System.Drawing.Size(263, 22)
            Me.cbbPenalOrigen.TabIndex = 57
            Me.cbbPenalOrigen.verToolTipItemSeleccionado = False
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(11, 32)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(37, 13)
            Me.Label19.TabIndex = 55
            Me.Label19.Text = "Penal:"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(96, 92)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(41, 13)
            Me.Label22.TabIndex = 61
            Me.Label22.Text = "Origen:"
            '
            'cbbRegimenEpOrigen
            '
            Me.cbbRegimenEpOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbRegimenEpOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimenEpOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimenEpOrigen.Location = New System.Drawing.Point(142, 62)
            Me.cbbRegimenEpOrigen.Name = "cbbRegimenEpOrigen"
            Me.cbbRegimenEpOrigen.Size = New System.Drawing.Size(322, 23)
            Me.cbbRegimenEpOrigen.TabIndex = 50
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(567, 92)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(54, 13)
            Me.Label21.TabIndex = 58
            Me.Label21.Text = "Receptor:"
            '
            'cbbEtapaEpOrigen
            '
            Me.cbbEtapaEpOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbEtapaEpOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEtapaEpOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbEtapaEpOrigen.Location = New System.Drawing.Point(625, 62)
            Me.cbbEtapaEpOrigen.Name = "cbbEtapaEpOrigen"
            Me.cbbEtapaEpOrigen.Size = New System.Drawing.Size(319, 23)
            Me.cbbEtapaEpOrigen.TabIndex = 51
            '
            'dtpFechaResol
            '
            Me.dtpFechaResol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaResol.Location = New System.Drawing.Point(625, 37)
            Me.dtpFechaResol.Name = "dtpFechaResol"
            Me.dtpFechaResol.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaResol.TabIndex = 46
            Me.dtpFechaResol.Value = "/  /"
            Me.dtpFechaResol.ValueLong = CType(0, Long)
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(510, 67)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(111, 13)
            Me.Label7.TabIndex = 36
            Me.Label7.Text = "Etapa en E.P.  origen:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(14, 41)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(124, 13)
            Me.Label2.TabIndex = 31
            Me.Label2.Text = "Resolución que autoriza:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(96, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(42, 13)
            Me.Label1.TabIndex = 30
            Me.Label1.Text = "Causal:"
            '
            'dtpFechaTraslado
            '
            Me.dtpFechaTraslado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaTraslado.Location = New System.Drawing.Point(861, 39)
            Me.dtpFechaTraslado.Name = "dtpFechaTraslado"
            Me.dtpFechaTraslado.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaTraslado.TabIndex = 47
            Me.dtpFechaTraslado.Value = "/  /"
            Me.dtpFechaTraslado.ValueLong = CType(0, Long)
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(525, 41)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(96, 13)
            Me.Label3.TabIndex = 32
            Me.Label3.Text = "Fecha Resolución:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(762, 42)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 33
            Me.Label4.Text = "Fecha de traslado:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(11, 67)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(127, 13)
            Me.Label6.TabIndex = 35
            Me.Label6.Text = "Régimen en E.P.  Origen:"
            '
            'txtCausal
            '
            Me.txtCausal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCausal.Location = New System.Drawing.Point(142, 14)
            Me.txtCausal.MaxLength = 250
            Me.txtCausal.Name = "txtCausal"
            Me.txtCausal.Size = New System.Drawing.Size(567, 20)
            Me.txtCausal.TabIndex = 38
            '
            'txtResAutoriza
            '
            Me.txtResAutoriza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtResAutoriza.Location = New System.Drawing.Point(142, 38)
            Me.txtResAutoriza.MaxLength = 120
            Me.txtResAutoriza.Name = "txtResAutoriza"
            Me.txtResAutoriza.Size = New System.Drawing.Size(322, 20)
            Me.txtResAutoriza.TabIndex = 39
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dgvFichaVariables)
            Me.GroupBox2.Controls.Add(Me.Panel5)
            Me.GroupBox2.Controls.Add(Me.Panel4)
            Me.GroupBox2.Location = New System.Drawing.Point(10, 164)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(971, 329)
            Me.GroupBox2.TabIndex = 53
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "DATOS DE CLASIFICACION"
            '
            'dgvFichaVariables
            '
            Me.dgvFichaVariables.AllowUserToAddRows = False
            Me.dgvFichaVariables.AllowUserToDeleteRows = False
            Me.dgvFichaVariables.AllowUserToResizeRows = False
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvFichaVariables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFichaVariables.BackgroundColor = System.Drawing.Color.White
            Me.dgvFichaVariables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFichaVariables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFichaVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFichaVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fic_det_id, Me.col_variable_id, Me.col_indicador_id, Me.col_fic_id, Me.DataGridViewTextBoxColumn4, Me.col_variable_nom, Me.col_indicador_nom, Me.col_etapa, Me.col_button_elimina})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFichaVariables.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvFichaVariables.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFichaVariables.GridColor = System.Drawing.Color.SkyBlue
            Me.dgvFichaVariables.Location = New System.Drawing.Point(3, 46)
            Me.dgvFichaVariables.MultiSelect = False
            Me.dgvFichaVariables.Name = "dgvFichaVariables"
            Me.dgvFichaVariables.ReadOnly = True
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFichaVariables.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvFichaVariables.RowHeadersVisible = False
            DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvFichaVariables.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvFichaVariables.RowTemplate.Height = 44
            Me.dgvFichaVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFichaVariables.Size = New System.Drawing.Size(965, 102)
            Me.dgvFichaVariables.TabIndex = 47
            '
            'col_fic_det_id
            '
            Me.col_fic_det_id.HeaderText = "FicDetId"
            Me.col_fic_det_id.Name = "col_fic_det_id"
            Me.col_fic_det_id.ReadOnly = True
            Me.col_fic_det_id.Visible = False
            '
            'col_variable_id
            '
            Me.col_variable_id.DataPropertyName = "Codigo"
            Me.col_variable_id.HeaderText = "MaeVariableId"
            Me.col_variable_id.MinimumWidth = 20
            Me.col_variable_id.Name = "col_variable_id"
            Me.col_variable_id.ReadOnly = True
            Me.col_variable_id.Visible = False
            Me.col_variable_id.Width = 80
            '
            'col_indicador_id
            '
            Me.col_indicador_id.HeaderText = "MaeIndicadorId"
            Me.col_indicador_id.Name = "col_indicador_id"
            Me.col_indicador_id.ReadOnly = True
            Me.col_indicador_id.Visible = False
            '
            'col_fic_id
            '
            Me.col_fic_id.DataPropertyName = "FichaId"
            Me.col_fic_id.HeaderText = "FichaId"
            Me.col_fic_id.Name = "col_fic_id"
            Me.col_fic_id.ReadOnly = True
            Me.col_fic_id.Visible = False
            Me.col_fic_id.Width = 50
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumeroOrdenString"
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
            Me.DataGridViewTextBoxColumn4.HeaderText = "N°"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 35
            '
            'col_variable_nom
            '
            Me.col_variable_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_variable_nom.DataPropertyName = "Nombre"
            Me.col_variable_nom.HeaderText = "Variables"
            Me.col_variable_nom.MinimumWidth = 200
            Me.col_variable_nom.Name = "col_variable_nom"
            Me.col_variable_nom.ReadOnly = True
            Me.col_variable_nom.Width = 200
            '
            'col_indicador_nom
            '
            Me.col_indicador_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_indicador_nom.DefaultCellStyle = DataGridViewCellStyle4
            Me.col_indicador_nom.HeaderText = "Indicador seleccionado"
            Me.col_indicador_nom.Name = "col_indicador_nom"
            Me.col_indicador_nom.ReadOnly = True
            '
            'col_etapa
            '
            Me.col_etapa.DataPropertyName = "Puntaje"
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.NullValue = "0"
            Me.col_etapa.DefaultCellStyle = DataGridViewCellStyle5
            Me.col_etapa.HeaderText = "Etapa"
            Me.col_etapa.Name = "col_etapa"
            Me.col_etapa.ReadOnly = True
            Me.col_etapa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_etapa.Width = 50
            '
            'col_button_elimina
            '
            Me.col_button_elimina.HeaderText = "--"
            Me.col_button_elimina.Name = "col_button_elimina"
            Me.col_button_elimina.ReadOnly = True
            Me.col_button_elimina.Text = "Eliminar"
            Me.col_button_elimina.ToolTipText = "Eliminar registro"
            Me.col_button_elimina.UseColumnTextForButtonValue = True
            Me.col_button_elimina.Width = 60
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.btnBuscarPabellon)
            Me.Panel5.Controls.Add(Me.lblPabellon)
            Me.Panel5.Controls.Add(Me.nudMinutos)
            Me.Panel5.Controls.Add(Me.nudHora)
            Me.Panel5.Controls.Add(Me.txtNumClasificacion)
            Me.Panel5.Controls.Add(Me.dtpFechaClasif)
            Me.Panel5.Controls.Add(Me.Label18)
            Me.Panel5.Controls.Add(Me.txtObs)
            Me.Panel5.Controls.Add(Me.Label11)
            Me.Panel5.Controls.Add(Me.Label8)
            Me.Panel5.Controls.Add(Me.cbbEtapaClasif)
            Me.Panel5.Controls.Add(Me.Label10)
            Me.Panel5.Controls.Add(Me.cbbRegimenClasif)
            Me.Panel5.Controls.Add(Me.Label9)
            Me.Panel5.Controls.Add(Me.Label17)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(3, 148)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(965, 178)
            Me.Panel5.TabIndex = 46
            '
            'btnBuscarPabellon
            '
            Me.btnBuscarPabellon.BackgroundImage = Global.APPControls.My.Resources.Resources._1345240399_search_button
            Me.btnBuscarPabellon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBuscarPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPabellon.Location = New System.Drawing.Point(928, 30)
            Me.btnBuscarPabellon.Name = "btnBuscarPabellon"
            Me.btnBuscarPabellon.Size = New System.Drawing.Size(28, 26)
            Me.btnBuscarPabellon.TabIndex = 72
            Me.btnBuscarPabellon.UseVisualStyleBackColor = True
            '
            'lblPabellon
            '
            Me.lblPabellon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblPabellon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPabellon.ForeColor = System.Drawing.Color.Black
            Me.lblPabellon.Location = New System.Drawing.Point(746, 33)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(181, 20)
            Me.lblPabellon.TabIndex = 71
            Me.lblPabellon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudMinutos
            '
            Me.nudMinutos._Formato = "00"
            Me.nudMinutos._Increment = 1
            Me.nudMinutos._Maximum = 59
            Me.nudMinutos._Minimum = 0
            Me.nudMinutos._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutos._Value = 0
            Me.nudMinutos.Controls.Add(Me.TextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox1)
            Me.nudMinutos.Controls.Add(Me.MyTextBox2)
            Me.nudMinutos.Controls.Add(Me.MyTextBox3)
            Me.nudMinutos.Controls.Add(Me.MyTextBox4)
            Me.nudMinutos.Location = New System.Drawing.Point(567, 8)
            Me.nudMinutos.Name = "nudMinutos"
            Me.nudMinutos.Size = New System.Drawing.Size(35, 20)
            Me.nudMinutos.TabIndex = 70
            '
            'TextBox1
            '
            Me.TextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.TextBox1._BloquearPaste = False
            Me.TextBox1._SeleccionarTodo = False
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox1.Location = New System.Drawing.Point(2, 3)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(15, 13)
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.Text = "00"
            Me.TextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.TextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox1
            '
            Me.MyTextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox1._BloquearPaste = False
            Me.MyTextBox1._SeleccionarTodo = False
            Me.MyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox1.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox1.Name = "MyTextBox1"
            Me.MyTextBox1.Size = New System.Drawing.Size(15, 13)
            Me.MyTextBox1.TabIndex = 0
            Me.MyTextBox1.Text = "00"
            Me.MyTextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox2
            '
            Me.MyTextBox2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox2._BloquearPaste = False
            Me.MyTextBox2._SeleccionarTodo = False
            Me.MyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox2.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox2.Name = "MyTextBox2"
            Me.MyTextBox2.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox2.TabIndex = 0
            Me.MyTextBox2.Text = "00"
            Me.MyTextBox2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox3
            '
            Me.MyTextBox3._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox3._BloquearPaste = False
            Me.MyTextBox3._SeleccionarTodo = False
            Me.MyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox3.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox3.Name = "MyTextBox3"
            Me.MyTextBox3.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox3.TabIndex = 0
            Me.MyTextBox3.Text = "5"
            Me.MyTextBox3.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox3.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox4
            '
            Me.MyTextBox4._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox4._BloquearPaste = False
            Me.MyTextBox4._SeleccionarTodo = False
            Me.MyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox4.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox4.Name = "MyTextBox4"
            Me.MyTextBox4.Size = New System.Drawing.Size(14, 13)
            Me.MyTextBox4.TabIndex = 0
            Me.MyTextBox4.Text = "5"
            Me.MyTextBox4.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox4.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'nudHora
            '
            Me.nudHora._Formato = "00"
            Me.nudHora._Increment = 1
            Me.nudHora._Maximum = 23
            Me.nudHora._Minimum = 0
            Me.nudHora._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHora._Value = 0
            Me.nudHora.Controls.Add(Me.object_5b148e84_5d51_4fce_9d46_b744170da755)
            Me.nudHora.Controls.Add(Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69)
            Me.nudHora.Controls.Add(Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41)
            Me.nudHora.Controls.Add(Me.object_360a1154_2066_4230_84c4_54434ae312f8)
            Me.nudHora.Controls.Add(Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004)
            Me.nudHora.Location = New System.Drawing.Point(528, 8)
            Me.nudHora.Name = "nudHora"
            Me.nudHora.Size = New System.Drawing.Size(35, 20)
            Me.nudHora.TabIndex = 69
            '
            'object_5b148e84_5d51_4fce_9d46_b744170da755
            '
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755._BloquearPaste = False
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755._SeleccionarTodo = False
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.Location = New System.Drawing.Point(2, 3)
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.Name = "object_5b148e84_5d51_4fce_9d46_b744170da755"
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.Size = New System.Drawing.Size(15, 13)
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.TabIndex = 0
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.Text = "00"
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_5b148e84_5d51_4fce_9d46_b744170da755.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_5baa2dfb_b0a8_491f_adce_81847bff4e69
            '
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69._BloquearPaste = False
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69._SeleccionarTodo = False
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.Location = New System.Drawing.Point(2, 3)
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.Name = "object_5baa2dfb_b0a8_491f_adce_81847bff4e69"
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.Size = New System.Drawing.Size(15, 13)
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.TabIndex = 0
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.Text = "08"
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_5baa2dfb_b0a8_491f_adce_81847bff4e69.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41
            '
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._BloquearPaste = False
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41._SeleccionarTodo = False
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Location = New System.Drawing.Point(2, 3)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Name = "object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41"
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Size = New System.Drawing.Size(14, 13)
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TabIndex = 0
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.Text = "08"
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_360a1154_2066_4230_84c4_54434ae312f8
            '
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._BloquearPaste = False
            Me.object_360a1154_2066_4230_84c4_54434ae312f8._SeleccionarTodo = False
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Location = New System.Drawing.Point(2, 3)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Name = "object_360a1154_2066_4230_84c4_54434ae312f8"
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Size = New System.Drawing.Size(14, 13)
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TabIndex = 0
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.Text = "5"
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_360a1154_2066_4230_84c4_54434ae312f8.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004
            '
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._BloquearPaste = False
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004._SeleccionarTodo = False
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Location = New System.Drawing.Point(2, 3)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Name = "object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004"
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Size = New System.Drawing.Size(14, 13)
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TabIndex = 0
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.Text = "5"
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtNumClasificacion
            '
            Me.txtNumClasificacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumClasificacion._BloquearPaste = False
            Me.txtNumClasificacion._SeleccionarTodo = False
            Me.txtNumClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumClasificacion.Location = New System.Drawing.Point(84, 8)
            Me.txtNumClasificacion.MaxLength = 2
            Me.txtNumClasificacion.Name = "txtNumClasificacion"
            Me.txtNumClasificacion.ReadOnly = True
            Me.txtNumClasificacion.Size = New System.Drawing.Size(250, 21)
            Me.txtNumClasificacion.TabIndex = 68
            Me.txtNumClasificacion.Text = "0"
            Me.txtNumClasificacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumClasificacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'dtpFechaClasif
            '
            Me.dtpFechaClasif.Location = New System.Drawing.Point(441, 8)
            Me.dtpFechaClasif.Name = "dtpFechaClasif"
            Me.dtpFechaClasif.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaClasif.TabIndex = 66
            Me.dtpFechaClasif.Value = "/  /"
            Me.dtpFechaClasif.ValueLong = CType(0, Long)
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(338, 13)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(101, 13)
            Me.Label18.TabIndex = 65
            Me.Label18.Text = "Fecha clasificación:"
            '
            'txtObs
            '
            Me.txtObs.Location = New System.Drawing.Point(84, 59)
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(871, 116)
            Me.txtObs.TabIndex = 29
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(697, 38)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(51, 13)
            Me.Label11.TabIndex = 54
            Me.Label11.Text = "Pabellón:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(16, 62)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(70, 13)
            Me.Label8.TabIndex = 37
            Me.Label8.Text = "Observación:"
            '
            'cbbEtapaClasif
            '
            Me.cbbEtapaClasif.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbEtapaClasif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEtapaClasif.Enabled = False
            Me.cbbEtapaClasif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbEtapaClasif.Location = New System.Drawing.Point(440, 32)
            Me.cbbEtapaClasif.Name = "cbbEtapaClasif"
            Me.cbbEtapaClasif.Size = New System.Drawing.Size(250, 23)
            Me.cbbEtapaClasif.TabIndex = 53
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(400, 38)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(38, 13)
            Me.Label10.TabIndex = 52
            Me.Label10.Text = "Etapa:"
            '
            'cbbRegimenClasif
            '
            Me.cbbRegimenClasif.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbRegimenClasif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimenClasif.Enabled = False
            Me.cbbRegimenClasif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimenClasif.Location = New System.Drawing.Point(84, 32)
            Me.cbbRegimenClasif.Name = "cbbRegimenClasif"
            Me.cbbRegimenClasif.Size = New System.Drawing.Size(250, 23)
            Me.cbbRegimenClasif.TabIndex = 51
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(34, 38)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(52, 13)
            Me.Label9.TabIndex = 36
            Me.Label9.Text = "Régimen:"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(1, 12)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(84, 13)
            Me.Label17.TabIndex = 67
            Me.Label17.Text = "N° Clasificación:"
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Panel4.Controls.Add(Me.btnAdd)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(3, 16)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(965, 30)
            Me.Panel4.TabIndex = 45
            '
            'btnAdd
            '
            Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAdd.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAdd.Location = New System.Drawing.Point(933, 0)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(30, 29)
            Me.btnAdd.TabIndex = 26
            Me.btnAdd.UseVisualStyleBackColor = True
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.GroupBox2)
            Me.pnlGrilla.Controls.Add(Me.GroupBox1)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrilla.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(986, 498)
            Me.pnlGrilla.TabIndex = 5
            '
            'frmMantFichPorRegresionPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(986, 541)
            Me.Name = "frmMantFichPorRegresionPopup"
            Me.Text = ".::. Clasificación por regresión"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotonesPrincipal.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.nudMinutos.ResumeLayout(False)
            Me.nudMinutos.PerformLayout()
            Me.nudHora.ResumeLayout(False)
            Me.nudHora.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.pnlGrilla.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents PnlBotonesPrincipal As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnGrabarClasificacion As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents btnFinalizar As Button
        Friend WithEvents Panel3 As Panel
        Private WithEvents webBrowser1 As WebBrowser
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnAceptIncador As Button
        Friend WithEvents btnCancelIndicador As Button
        Friend WithEvents pnlGrilla As Panel
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents Panel5 As Panel
        Friend WithEvents btnBuscarPabellon As Button
        Friend WithEvents lblPabellon As Label
        Friend WithEvents nudMinutos As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents TextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox3 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox4 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents nudHora As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents object_5b148e84_5d51_4fce_9d46_b744170da755 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_5baa2dfb_b0a8_491f_adce_81847bff4e69 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_4f8f4d32_4a44_454a_85ef_9c6f0eda1c41 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_360a1154_2066_4230_84c4_54434ae312f8 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents object_5a7c6f99_54c2_4ee7_9ef8_6d342206a004 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumClasificacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaClasif As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label18 As Label
        Friend WithEvents txtObs As TextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents cbbEtapaClasif As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label10 As Label
        Friend WithEvents cbbRegimenClasif As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label9 As Label
        Friend WithEvents Label17 As Label
        Friend WithEvents Panel4 As Panel
        Friend WithEvents btnAdd As Button
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents lblEstado As Label
        Friend WithEvents Panel7 As Panel
        Friend WithEvents Label23 As Label
        Friend WithEvents Label24 As Label
        Friend WithEvents cbbPenalDestino As uscComboParametrica
        Friend WithEvents cbbRegionDestino As uscComboParametrica
        Friend WithEvents Panel6 As Panel
        Friend WithEvents cbbRegionOrigen As uscComboParametrica
        Friend WithEvents Label20 As Label
        Friend WithEvents cbbPenalOrigen As uscComboParametrica
        Friend WithEvents Label19 As Label
        Friend WithEvents Label22 As Label
        Friend WithEvents cbbRegimenEpOrigen As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label21 As Label
        Friend WithEvents cbbEtapaEpOrigen As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents dtpFechaResol As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label7 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents dtpFechaTraslado As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents txtCausal As TextBox
        Friend WithEvents txtResAutoriza As TextBox
        Friend WithEvents dgvFichaVariables As DataGridView
        Friend WithEvents col_fic_det_id As DataGridViewTextBoxColumn
        Friend WithEvents col_variable_id As DataGridViewTextBoxColumn
        Friend WithEvents col_indicador_id As DataGridViewTextBoxColumn
        Friend WithEvents col_fic_id As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents col_variable_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_indicador_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_etapa As DataGridViewTextBoxColumn
        Friend WithEvents col_button_elimina As DataGridViewButtonColumn
    End Class

End Namespace
