Namespace Transferencia.Control

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmArchivoInfoPopup2
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArchivoInfoPopup2))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.cbbMes = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtRegion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlRefrescar = New System.Windows.Forms.Panel()
            Me.btnRefrescar = New System.Windows.Forms.Button()
            Me.btnPadinDetalle = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnQuitarError = New System.Windows.Forms.Button()
            Me.btnDescargarXML = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dgw_detalle = New Legolas.APPUIComponents.myDatagridView()
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.col_id_arch = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_arch = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_xml_mb = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_zip_mb = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_desde_string = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_hasta_string = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_sub_sede = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_proc_sed = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_desc_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_proc_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_error = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_path_arch = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_licencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_paq = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlRefrescar.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.dgw_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.dgw_detalle)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(972, 395)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.txtPenal)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.txtRegion)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(972, 36)
            Me.Panel1.TabIndex = 3
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.cbbAnio)
            Me.GroupBox1.Controls.Add(Me.cbbMes)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Location = New System.Drawing.Point(719, -2)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(250, 34)
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 2014
            Me.cbbAnio.Location = New System.Drawing.Point(37, 9)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(66, 21)
            Me.cbbAnio.TabIndex = 11
            Me.cbbAnio.Value = -1
            '
            'cbbMes
            '
            Me.cbbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbMes.FormattingEnabled = True
            Me.cbbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
            Me.cbbMes.Location = New System.Drawing.Point(141, 9)
            Me.cbbMes.Name = "cbbMes"
            Me.cbbMes.Size = New System.Drawing.Size(103, 21)
            Me.cbbMes.TabIndex = 8
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(107, 13)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(30, 13)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Mes:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 13)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(29, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Año:"
            '
            'txtPenal
            '
            Me.txtPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPenal._BloquearPaste = False
            Me.txtPenal._SeleccionarTodo = False
            Me.txtPenal.Location = New System.Drawing.Point(315, 8)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.ReadOnly = True
            Me.txtPenal.Size = New System.Drawing.Size(189, 20)
            Me.txtPenal.TabIndex = 7
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(271, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Penal :"
            '
            'txtRegion
            '
            Me.txtRegion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRegion._BloquearPaste = False
            Me.txtRegion._SeleccionarTodo = False
            Me.txtRegion.Location = New System.Drawing.Point(54, 8)
            Me.txtRegion.Name = "txtRegion"
            Me.txtRegion.ReadOnly = True
            Me.txtRegion.Size = New System.Drawing.Size(189, 20)
            Me.txtRegion.TabIndex = 5
            Me.txtRegion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(3, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Region :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(61, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(168, 13)
            Me.Label3.TabIndex = 70
            Me.Label3.Text = "Error de procesamiento en la sede"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label7.Location = New System.Drawing.Point(8, 18)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(51, 13)
            Me.Label7.TabIndex = 69
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlRefrescar)
            Me.Panel2.Controls.Add(Me.pnlReporte)
            Me.Panel2.Controls.Add(Me.pnlGrabar)
            Me.Panel2.Controls.Add(Me.pnlEliminar)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Controls.Add(Me.Label7)
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 352)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(972, 43)
            Me.Panel2.TabIndex = 75
            '
            'pnlRefrescar
            '
            Me.pnlRefrescar.Controls.Add(Me.btnRefrescar)
            Me.pnlRefrescar.Controls.Add(Me.btnPadinDetalle)
            Me.pnlRefrescar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlRefrescar.Location = New System.Drawing.Point(331, 0)
            Me.pnlRefrescar.Name = "pnlRefrescar"
            Me.pnlRefrescar.Size = New System.Drawing.Size(194, 43)
            Me.pnlRefrescar.TabIndex = 104
            '
            'btnRefrescar
            '
            Me.btnRefrescar.Image = Global.SIPPOPE.My.Resources.Resources.Refrescar
            Me.btnRefrescar.Location = New System.Drawing.Point(4, 2)
            Me.btnRefrescar.Name = "btnRefrescar"
            Me.btnRefrescar.Size = New System.Drawing.Size(94, 40)
            Me.btnRefrescar.TabIndex = 102
            Me.btnRefrescar.Text = "Refrescar"
            Me.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnRefrescar.UseVisualStyleBackColor = True
            '
            'btnPadinDetalle
            '
            Me.btnPadinDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPadinDetalle.Image = Global.SIPPOPE.My.Resources.Resources.eye_32x32
            Me.btnPadinDetalle.Location = New System.Drawing.Point(100, 2)
            Me.btnPadinDetalle.Name = "btnPadinDetalle"
            Me.btnPadinDetalle.Size = New System.Drawing.Size(91, 40)
            Me.btnPadinDetalle.TabIndex = 97
            Me.btnPadinDetalle.Text = "Ver XML"
            Me.btnPadinDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnPadinDetalle.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlReporte.Location = New System.Drawing.Point(525, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(93, 43)
            Me.pnlReporte.TabIndex = 105
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(1, 2)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(89, 40)
            Me.btnExportar.TabIndex = 100
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnQuitarError)
            Me.pnlGrabar.Controls.Add(Me.btnDescargarXML)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(618, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(175, 43)
            Me.pnlGrabar.TabIndex = 103
            '
            'btnQuitarError
            '
            Me.btnQuitarError.Image = Global.SIPPOPE.My.Resources.Resources.replace2
            Me.btnQuitarError.Location = New System.Drawing.Point(2, 2)
            Me.btnQuitarError.Name = "btnQuitarError"
            Me.btnQuitarError.Size = New System.Drawing.Size(85, 40)
            Me.btnQuitarError.TabIndex = 101
            Me.btnQuitarError.Text = "Setear error"
            Me.btnQuitarError.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnQuitarError, "Setear error del paquete seleccionado")
            Me.btnQuitarError.UseVisualStyleBackColor = True
            '
            'btnDescargarXML
            '
            Me.btnDescargarXML.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnDescargarXML.Location = New System.Drawing.Point(87, 2)
            Me.btnDescargarXML.Name = "btnDescargarXML"
            Me.btnDescargarXML.Size = New System.Drawing.Size(85, 40)
            Me.btnDescargarXML.TabIndex = 100
            Me.btnDescargarXML.Text = "XML y Zip"
            Me.btnDescargarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnDescargarXML, "Descargar paquete")
            Me.btnDescargarXML.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(793, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(90, 43)
            Me.pnlEliminar.TabIndex = 104
            '
            'btnEliminar
            '
            Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(2, 2)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(85, 40)
            Me.btnEliminar.TabIndex = 99
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnSalir)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(883, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(89, 43)
            Me.Panel3.TabIndex = 102
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(2, 2)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(85, 40)
            Me.btnSalir.TabIndex = 98
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnSalir, "Cerrar ventana")
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dgw_detalle
            '
            Me.dgw_detalle.AllowUserToAddRows = False
            Me.dgw_detalle.AllowUserToDeleteRows = False
            Me.dgw_detalle.AllowUserToResizeRows = False
            Me.dgw_detalle.BackgroundColor = System.Drawing.Color.White
            Me.dgw_detalle.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgw_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgw_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_arch, Me.DataGridViewTextBoxColumn1, Me.col_nom_arch, Me.DataGridViewTextBoxColumn3, Me.col_xml_mb, Me.DataGridViewTextBoxColumn4, Me.col_zip_mb, Me.col_fec, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.col_fec_desde_string, Me.col_fec_desde, Me.col_fec_hasta_string, Me.col_fec_hasta, Me.col_fec_sub_sede, Me.col_fec_proc_sed, Me.col_fec_desc_reg, Me.col_fec_proc_reg, Me.col_error, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn13, Me.col_path_arch, Me.col_correlativo, Me.col_licencia, Me.col_tip_paq})
            Me.dgw_detalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgw_detalle.GridColor = System.Drawing.Color.LightGray
            Me.dgw_detalle.Location = New System.Drawing.Point(0, 36)
            Me.dgw_detalle.MultiSelect = False
            Me.dgw_detalle.Name = "dgw_detalle"
            Me.dgw_detalle.ReadOnly = True
            Me.dgw_detalle.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw_detalle.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgw_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgw_detalle.Size = New System.Drawing.Size(972, 316)
            Me.dgw_detalle.TabIndex = 74
            Me.dgw_detalle.VisibleCampos = True
            '
            'col_id_arch
            '
            Me.col_id_arch.DataPropertyName = "Codigo"
            Me.col_id_arch.DividerWidth = 1
            Me.col_id_arch.HeaderText = "IdArchivo"
            Me.col_id_arch.Name = "col_id_arch"
            Me.col_id_arch.ReadOnly = True
            Me.col_id_arch.Visible = False
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "ArchivoNumero"
            Me.DataGridViewTextBoxColumn1.HeaderText = "Nº"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 40
            '
            'col_nom_arch
            '
            Me.col_nom_arch.DataPropertyName = "ArchivoNombre"
            Me.col_nom_arch.HeaderText = "Nombre Arch."
            Me.col_nom_arch.Name = "col_nom_arch"
            Me.col_nom_arch.ReadOnly = True
            Me.col_nom_arch.Width = 210
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "TamanioXmlEnBytes"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Xml bytes"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Visible = False
            '
            'col_xml_mb
            '
            Me.col_xml_mb.DataPropertyName = "TamanioXmlEnMb"
            Me.col_xml_mb.HeaderText = "xml MB"
            Me.col_xml_mb.Name = "col_xml_mb"
            Me.col_xml_mb.ReadOnly = True
            Me.col_xml_mb.Visible = False
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "TamanioZipEnBytes"
            Me.DataGridViewTextBoxColumn4.HeaderText = "Zip bytes"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Visible = False
            '
            'col_zip_mb
            '
            Me.col_zip_mb.DataPropertyName = "TamanioZipEnMb"
            Me.col_zip_mb.HeaderText = "Zip MB"
            Me.col_zip_mb.Name = "col_zip_mb"
            Me.col_zip_mb.ReadOnly = True
            Me.col_zip_mb.Visible = False
            '
            'col_fec
            '
            Me.col_fec.DataPropertyName = "ArchivoFechaString"
            Me.col_fec.HeaderText = "Fecha archivo"
            Me.col_fec.Name = "col_fec"
            Me.col_fec.ReadOnly = True
            Me.col_fec.Visible = False
            Me.col_fec.Width = 140
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "TotalInternos"
            Me.DataGridViewTextBoxColumn7.HeaderText = "Internos"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.Width = 50
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "TotalPro"
            Me.DataGridViewTextBoxColumn8.HeaderText = "Proc."
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            Me.DataGridViewTextBoxColumn8.Visible = False
            Me.DataGridViewTextBoxColumn8.Width = 50
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "TotalSen"
            Me.DataGridViewTextBoxColumn9.HeaderText = "Sent."
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            Me.DataGridViewTextBoxColumn9.Visible = False
            Me.DataGridViewTextBoxColumn9.Width = 57
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DataGridViewTextBoxColumn10.DataPropertyName = "TotalExpedientes"
            Me.DataGridViewTextBoxColumn10.HeaderText = "Exp."
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.ReadOnly = True
            Me.DataGridViewTextBoxColumn10.ToolTipText = "Total expedientes"
            Me.DataGridViewTextBoxColumn10.Visible = False
            Me.DataGridViewTextBoxColumn10.Width = 53
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "TotalDelitos"
            Me.DataGridViewTextBoxColumn11.HeaderText = "Delitos"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            Me.DataGridViewTextBoxColumn11.ToolTipText = "Total delitos"
            Me.DataGridViewTextBoxColumn11.Visible = False
            Me.DataGridViewTextBoxColumn11.Width = 50
            '
            'DataGridViewTextBoxColumn12
            '
            Me.DataGridViewTextBoxColumn12.DataPropertyName = "TotalAgraviados"
            Me.DataGridViewTextBoxColumn12.HeaderText = "Agraviados"
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            Me.DataGridViewTextBoxColumn12.ReadOnly = True
            Me.DataGridViewTextBoxColumn12.ToolTipText = "Total agraviados"
            Me.DataGridViewTextBoxColumn12.Visible = False
            Me.DataGridViewTextBoxColumn12.Width = 70
            '
            'col_fec_desde_string
            '
            Me.col_fec_desde_string.DataPropertyName = "FechaDesdeString"
            Me.col_fec_desde_string.HeaderText = "Datos Desde"
            Me.col_fec_desde_string.Name = "col_fec_desde_string"
            Me.col_fec_desde_string.ReadOnly = True
            Me.col_fec_desde_string.Width = 120
            '
            'col_fec_desde
            '
            Me.col_fec_desde.DataPropertyName = "FechaDesde"
            Me.col_fec_desde.DividerWidth = 1
            Me.col_fec_desde.HeaderText = "fecha desde"
            Me.col_fec_desde.Name = "col_fec_desde"
            Me.col_fec_desde.ReadOnly = True
            Me.col_fec_desde.Visible = False
            '
            'col_fec_hasta_string
            '
            Me.col_fec_hasta_string.DataPropertyName = "FechaHastaString"
            Me.col_fec_hasta_string.HeaderText = "Datos Hasta"
            Me.col_fec_hasta_string.Name = "col_fec_hasta_string"
            Me.col_fec_hasta_string.ReadOnly = True
            Me.col_fec_hasta_string.Width = 120
            '
            'col_fec_hasta
            '
            Me.col_fec_hasta.DataPropertyName = "FechaHasta"
            Me.col_fec_hasta.DividerWidth = 1
            Me.col_fec_hasta.HeaderText = "fecha hasta"
            Me.col_fec_hasta.Name = "col_fec_hasta"
            Me.col_fec_hasta.ReadOnly = True
            Me.col_fec_hasta.Visible = False
            '
            'col_fec_sub_sede
            '
            Me.col_fec_sub_sede.DataPropertyName = "FechaSubidaSedeString"
            Me.col_fec_sub_sede.HeaderText = "Subida sede"
            Me.col_fec_sub_sede.Name = "col_fec_sub_sede"
            Me.col_fec_sub_sede.ReadOnly = True
            Me.col_fec_sub_sede.ToolTipText = "fecha de subida del penal a la sede"
            Me.col_fec_sub_sede.Width = 120
            '
            'col_fec_proc_sed
            '
            Me.col_fec_proc_sed.DataPropertyName = "FechaProcesaSedeString"
            Me.col_fec_proc_sed.HeaderText = "Procesado Sede"
            Me.col_fec_proc_sed.Name = "col_fec_proc_sed"
            Me.col_fec_proc_sed.ReadOnly = True
            Me.col_fec_proc_sed.ToolTipText = "Fecha de procesamiento del archivo en sede"
            Me.col_fec_proc_sed.Width = 120
            '
            'col_fec_desc_reg
            '
            Me.col_fec_desc_reg.DataPropertyName = "FechaDescargaRegionString"
            Me.col_fec_desc_reg.HeaderText = "Descarga región"
            Me.col_fec_desc_reg.Name = "col_fec_desc_reg"
            Me.col_fec_desc_reg.ReadOnly = True
            Me.col_fec_desc_reg.ToolTipText = "Fecha de descarga de la region"
            Me.col_fec_desc_reg.Visible = False
            Me.col_fec_desc_reg.Width = 140
            '
            'col_fec_proc_reg
            '
            Me.col_fec_proc_reg.DataPropertyName = "FechaProcesaRegionString"
            Me.col_fec_proc_reg.HeaderText = "Procesado Región"
            Me.col_fec_proc_reg.Name = "col_fec_proc_reg"
            Me.col_fec_proc_reg.ReadOnly = True
            Me.col_fec_proc_reg.Width = 140
            '
            'col_error
            '
            Me.col_error.DataPropertyName = "ErrorProcesoEnSedeString"
            Me.col_error.DividerWidth = 1
            Me.col_error.HeaderText = ""
            Me.col_error.Name = "col_error"
            Me.col_error.ReadOnly = True
            Me.col_error.Visible = False
            '
            'DataGridViewTextBoxColumn14
            '
            Me.DataGridViewTextBoxColumn14.DataPropertyName = "VerApp"
            Me.DataGridViewTextBoxColumn14.HeaderText = "Ver APP"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.ReadOnly = True
            Me.DataGridViewTextBoxColumn14.Visible = False
            Me.DataGridViewTextBoxColumn14.Width = 50
            '
            'DataGridViewTextBoxColumn13
            '
            Me.DataGridViewTextBoxColumn13.DataPropertyName = "VerBD"
            Me.DataGridViewTextBoxColumn13.HeaderText = "Ver BD"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.ReadOnly = True
            Me.DataGridViewTextBoxColumn13.ToolTipText = "Version de base de datos"
            Me.DataGridViewTextBoxColumn13.Visible = False
            Me.DataGridViewTextBoxColumn13.Width = 50
            '
            'col_path_arch
            '
            Me.col_path_arch.DataPropertyName = "PathArchivoServer"
            Me.col_path_arch.DividerWidth = 1
            Me.col_path_arch.HeaderText = "Path"
            Me.col_path_arch.Name = "col_path_arch"
            Me.col_path_arch.ReadOnly = True
            Me.col_path_arch.Visible = False
            '
            'col_correlativo
            '
            Me.col_correlativo.DataPropertyName = "ArchivoNumero"
            Me.col_correlativo.DividerWidth = 1
            Me.col_correlativo.HeaderText = "Correlativo"
            Me.col_correlativo.Name = "col_correlativo"
            Me.col_correlativo.ReadOnly = True
            Me.col_correlativo.Visible = False
            '
            'col_licencia
            '
            Me.col_licencia.DataPropertyName = "Licencia"
            Me.col_licencia.DividerWidth = 1
            Me.col_licencia.HeaderText = "licencia"
            Me.col_licencia.Name = "col_licencia"
            Me.col_licencia.ReadOnly = True
            Me.col_licencia.Visible = False
            '
            'col_tip_paq
            '
            Me.col_tip_paq.DataPropertyName = "TipoPaquete"
            Me.col_tip_paq.DividerWidth = 1
            Me.col_tip_paq.HeaderText = "TipoPaquete"
            Me.col_tip_paq.Name = "col_tip_paq"
            Me.col_tip_paq.ReadOnly = True
            Me.col_tip_paq.Visible = False
            '
            'frmArchivoInfoPopup2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(972, 395)
            Me.Name = "frmArchivoInfoPopup2"
            Me.Text = "Detalle de Transferencia"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlRefrescar.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            CType(Me.dgw_detalle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtRegion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnPadinDetalle As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnDescargarXML As System.Windows.Forms.Button
        Friend WithEvents dgw_detalle As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents btnQuitarError As System.Windows.Forms.Button
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnRefrescar As System.Windows.Forms.Button
        Friend WithEvents pnlRefrescar As System.Windows.Forms.Panel
        Friend WithEvents cbbMes As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents col_id_arch As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_arch As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents col_xml_mb As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents col_zip_mb As DataGridViewTextBoxColumn
        Friend WithEvents col_fec As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_desde_string As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_desde As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_hasta_string As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_hasta As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_sub_sede As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_proc_sed As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_desc_reg As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_proc_reg As DataGridViewTextBoxColumn
        Friend WithEvents col_error As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
        Friend WithEvents col_path_arch As DataGridViewTextBoxColumn
        Friend WithEvents col_correlativo As DataGridViewTextBoxColumn
        Friend WithEvents col_licencia As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_paq As DataGridViewTextBoxColumn
    End Class
End Namespace