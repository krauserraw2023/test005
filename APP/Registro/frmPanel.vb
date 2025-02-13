Imports System.Data
Imports System.Data.SqlClient

Namespace Registro
    Public Class frmPanel
        '#Region "Propiedades"
        '        Private Property _Region() As Integer
        '            Get
        '                Return Me.cbbregion.SelectedValue
        '            End Get
        '            Set(ByVal value As Integer)
        '                Me.cbbregion.SelectedValue = value
        '            End Set
        '        End Property
        '        Private Property _Penal() As Integer
        '            Get
        '                Return Me.cbbpenal.SelectedValue
        '            End Get
        '            Set(ByVal value As Integer)
        '                Me.cbbpenal.SelectedValue = value
        '            End Set
        '        End Property
        '        Private Property _IngresoDesde() As Long
        '            Get
        '                Return Me.dte_ingresodesde.ValueLong
        '            End Get
        '            Set(ByVal value As Long)
        '                Me.dte_ingresodesde.ValueLong = value
        '            End Set
        '        End Property
        '        Private Property _IngresoHasta() As Long
        '            Get
        '                Return Me.dte_ingresohasta.ValueLong
        '            End Get
        '            Set(ByVal value As Long)
        '                Me.dte_ingresohasta.ValueLong = value
        '            End Set
        '        End Property        
        '#End Region
        '#Region "Combo"
        '        Private Sub ComboRegion()

        '            Dim blnTodos As Boolean = False

        '            Select Case Configuracion.Usuario.NivelUsuario
        '                Case 1, 2
        '                    blnTodos = False
        '                Case 3
        '                    blnTodos = True
        '            End Select

        '            With Me.cbbregion
        '                ._Todos = blnTodos
        '                .Parametro1 = Configuracion.Usuario.Codigo
        '                .Parametro2 = Configuracion.Licencia.Codigo
        '                .LoadUsc()
        '            End With

        '        End Sub
        '        Private Sub ComboPenal()

        '            Dim blnTodos As Boolean = False

        '            Select Case Configuracion.Usuario.NivelUsuario
        '                Case 1
        '                    blnTodos = False
        '                Case 2, 3
        '                    blnTodos = True
        '            End Select

        '            With Me.cbbpenal
        '                ._Todos = blnTodos
        '                .CodigoPadre = Me._Region
        '                .Parametro1 = Configuracion.Usuario.Codigo
        '                .Parametro2 = Configuracion.Licencia.Codigo
        '                .LoadUsc()
        '            End With

        '        End Sub
        '#End Region
        '#Region "Listar"
        '        Private Sub MostrarData()

        '            If Validar() = False Then
        '                Exit Sub
        '            End If

        '            Dim _time As Date = Now

        '            Dim DS As DataSet

        '            DS = Bussines.Panel.Registro.LoadDataPanel1("panel_reporte", _IngresoDesde, _IngresoHasta, _Region, _Penal)

        '            '/*grilla situacion juridica
        '            PintaGrilla(dgwsituacion)
        '            With Me.dgwsituacion
        '                .Columns("col_pro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_sen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_mix").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .DataSource = DS.Tables(0)
        '            End With

        '            PintaGrilla(dgwPELIGROsidad)

        '            'grilla ingresos
        '            With Me.dgwPELIGROsidad
        '                .Columns("col_ing_1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_ing_2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_ing_4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .DataSource = DS.Tables(1)
        '            End With

        '            '/*grilla peligrosidad
        '            PintaGrilla(dgwnroingreso)
        '            With Me.dgwnroingreso
        '                .Columns("col_pel_1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_pel_2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_pel_3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .DataSource = DS.Tables(2)
        '            End With

        '            'grilla capacidad
        '            PintaGrilla(Me.dgwcapacidad)
        '            With Me.dgwcapacidad
        '                .Columns("col_par_cap").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_par_act").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .DataSource = DS.Tables(3)
        '            End With

        '            'grilla nacionaliad
        '            PintaGrilla(dgwnacionalidad, True)
        '            With Me.dgwnacionalidad
        '                .Columns("col_hom").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_muj").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .Columns("col_tot").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '                .DataSource = DS.Tables(4)
        '            End With

        '            CargarDelitos()
        '            CargarIngresos()

        '            MostrarTotales()
        '            CalcularTotales()

        '            Dim _time2 As Date = Now
        '            Me.lbltime.Text = DateDiff(DateInterval.Second, _time, _time2).ToString

        '        End Sub
        '        Private Sub MostrarTotales()

        '            Dim tbl As DataTable

        '            tbl = Bussines.Panel.Registro.LoadDataPanel1("panel_total", _IngresoDesde, _IngresoHasta, _Region, _Penal).Tables(0)

        '            If tbl.Rows.Count > 0 Then

        '                PintaTextBox(txthombre)
        '                PintaTextBox(txtmujer)
        '                PintaTextBox(txtincompletos)
        '                PintaTextBox(txtcompletos)
        '                '   PintaTextBox(txttotal)
        '                Me.txttotal.Text = tbl.Rows(0).Item("Total").ToString
        '                Me.txthombre.Text = tbl.Rows(0).Item("hombre").ToString
        '                Me.txtmujer.Text = tbl.Rows(0).Item("mujer").ToString
        '                Me.txtincompletos.Text = tbl.Rows(0).Item("incompleto").ToString
        '                Me.txtcompletos.Text = tbl.Rows(0).Item("completo").ToString

        '            End If

        '        End Sub
        '        Private Sub CargarIngresos()
        '            dgwingresos.RowsDefaultCellStyle.Font = New Font("Arial", 8)
        '            Me.dgwingresos.AutoGenerateColumns = False

        '            Dim DS As DataSet
        '            DS = Bussines.Panel.Registro.LoadDataPanel1("panel_ingreso", _IngresoDesde, _IngresoHasta, _Region, _Penal)
        '            Me.dgwingresos.DataSource = DS.Tables(0)

        '        End Sub
        '        Private Sub CargarDelitos()


        '            Me.treedelitos.ColumnSettings.ColumnSets.Clear()
        '            Me.treedelitos.SetDataBinding(Nothing, Nothing)
        '            Me.treedelitos.Font = New Font("Arial", 8)

        '            Dim DS As DataSet
        '            DS = Bussines.Panel.Registro.LoadDataPanel1("panel_delito", _IngresoDesde, _IngresoHasta, _Region, _Penal)

        '            '  Me.UltraTree1.datasource = 
        '            '			dataSet.Relations.Add("Employees", dataSet.Tables["Employees"].Columns["EmployeeID"], dataSet.Tables["Employees"].Columns["SupervisorID"], false);
        '            '   DS.WriteXml("C:\apg.xml")
        '            'DS.AcceptChanges()

        '            DS.Relations.Clear()
        '            DS.Relations.Add(DS.Tables(0).Columns("del_gen_id"), DS.Tables(1).Columns("del_gen_id"))

        '            'DS.Relations.Add("Delitos", DS.Tables(0).Columns(0), DS.Tables(1).Columns(0))
        '            '_ArmarTree(DS.Tables(5))
        '            '   Me.treedelitos.ColumnSettings.ColumnSets.Add("del_gen_nom")
        '            '  Me.treedelitos.ColumnSettings.ColumnSets.Add("Cantidad")

        '            Me.treedelitos.ColumnSettings.AutoGenerateColumnSets = True
        '            ' UltraTree1.SetDataBinding(DS, "table5")
        '            'Me.UltraTree1.DataSource = DS
        '            '  Me.UltraTree1.DataMember = "table"
        '            ' Me.treedelitos.ColumnSettings.AllowCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        '            Me.treedelitos.ColumnSettings.AutoFitColumns = Infragistics.Win.UltraWinTree.AutoFitColumns.ResizeAllColumns
        '            'Me.treedelitos.ColumnSettings.ColumnAutoSizeMode = Infragistics.Win.UltraWinTree.ColumnAutoSizeMode.AllNodesWithDescendants

        '            Me.treedelitos.SetDataBinding(DS, "table")

        '        End Sub
        '#End Region
        '#Region "Accion"
        '        Private Function Validar() As Boolean

        '            Dim blnValue As Boolean = True

        '            'region
        '            If Me._Region < 1 Then
        '                MessageBox.Show("Seleccione Region", _
        '                Legolas.Configurations.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, _
        '                MessageBoxIcon.Exclamation)
        '                Me.cbbregion.Focus()
        '                blnValue = False
        '                Return blnValue
        '            End If

        '            ''penal
        '            'If Me._Penal < 1 Then
        '            '    MessageBox.Show("Seleccione Penal", _
        '            '    legolas.Configurations.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, _
        '            '    MessageBoxIcon.Exclamation)
        '            '    Me.cbbpenal.Focus()
        '            '    blnValue = False
        '            '    Return blnValue
        '            'End If

        '            Return blnValue
        '        End Function
        '#End Region
        '#Region "Calcular"
        '        Private Sub CalcularTotales()

        '            'CAPACIDAD
        '            If Me.dgwcapacidad.Rows(0).Cells("col_par_tip").Value = "Pabellon" Then
        '                Me.dgwcapacidad.Columns("col_par_cap").Visible = False
        '            Else
        '                Me.dgwcapacidad.Columns("col_par_cap").Visible = True
        '            End If

        '            'NAcionalidad
        '            Dim _peruanos As Integer = 0
        '            Dim _extranjeros As Integer = 0
        '            Dim _nacionalidadotros As Integer = 0

        '            'nacionalidad por sexo
        '            Dim intNacHom As Integer = 0
        '            Dim intNacMuj As Integer = 0
        '            Dim intNacHomMuj As Integer = 0

        '            For Each dr As DataGridViewRow In Me.dgwnacionalidad.Rows

        '                If dr.Cells("col_nac_id").Value = 141 Then
        '                    _peruanos = _peruanos + dr.Cells("col_tot").Value.ToString
        '                ElseIf dr.Cells("col_nac_id").Value = -1 Then
        '                    _nacionalidadotros = _nacionalidadotros + dr.Cells("col_tot").Value.ToString
        '                Else
        '                    _extranjeros = _extranjeros + dr.Cells("col_tot").Value.ToString
        '                End If

        '                intNacHom = intNacHom + Integer.Parse(dr.Cells("col_hom").Value)
        '                intNacMuj = intNacMuj + Integer.Parse(dr.Cells("col_muj").Value)
        '                intNacHomMuj = intNacHomMuj + Integer.Parse(dr.Cells("col_tot").Value)

        '            Next

        '            PintaTextBox(txtextranjero)
        '            PintaTextBox(txtperuana)
        '            PintaTextBox(txtnacionalidad)

        '            PintaTextBox(Me.txtNacHom)
        '            PintaTextBox(Me.txtNacMuj)
        '            PintaTextBox(Me.txtNacTot)

        '            Me.txtperuana.Text = _peruanos.ToString
        '            Me.txtextranjero.Text = _extranjeros.ToString
        '            Me.txtnacionalidad.Text = _nacionalidadotros.ToString

        '            Me.txtNacHom.Text = intNacHom.ToString
        '            Me.txtNacMuj.Text = intNacMuj.ToString
        '            Me.txtNacTot.Text = intNacHomMuj.ToString

        '        End Sub
        '#End Region
        '#Region "Otros"
        '        Private Sub ValoresxDefault()

        '            'Configuracion.Usuario.Codigo = 1

        '            _IngresoDesde = Now.AddDays(-7).ToFileTime
        '            _IngresoHasta = Now.ToFileTime()

        '            ComboRegion()
        '            ComboPenal()

        '        End Sub
        '        Private Sub PintaGrilla(ByVal vgrilla As DataGridView)
        '            PintaGrilla(vgrilla, False)
        '        End Sub
        '        Private Sub PintaTextBox(ByVal vtext As TextBox)

        '            vtext.ReadOnly = True
        '            vtext.Font = New Font("Arial", 9)
        '            vtext.TextAlign = HorizontalAlignment.Right
        '            vtext.BorderStyle = BorderStyle.FixedSingle
        '            vtext.BackColor = Color.White

        '        End Sub
        '        Private Sub PintaGrilla(ByVal vgrilla As DataGridView, ByVal verticalbars As Boolean)

        '            vgrilla.AutoGenerateColumns = False

        '            vgrilla.RowsDefaultCellStyle.Font = New Font("Arial", 8)
        '            vgrilla.BackgroundColor = Color.White

        '            vgrilla.Columns(1).DefaultCellStyle.BackColor = Color.LightGray
        '            vgrilla.RowHeadersVisible = False
        '            vgrilla.RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
        '            vgrilla.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        '            If verticalbars Then
        '                vgrilla.ScrollBars = ScrollBars.Vertical
        '            Else
        '                vgrilla.ScrollBars = ScrollBars.None
        '            End If
        '            vgrilla.ScrollBars = ScrollBars.Both
        '        End Sub
        '#End Region
        '        Private Sub frmPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '            ValoresxDefault()

        '        End Sub

        '        Private Sub cbbregion__ValueChanged() Handles cbbregion._SelectedIndexChanged
        '            Me.ComboPenal()
        '        End Sub

        '        Private Sub treedelitos_ColumnSetGenerated(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinTree.ColumnSetGeneratedEventArgs) Handles treedelitos.ColumnSetGenerated

        '            If e.ColumnSet.Key = "Relation1" Then

        '                e.ColumnSet.Columns("del_esp_nom").CanShowExpansionIndicator = Infragistics.Win.DefaultableBoolean.False
        '            Else

        '                e.ColumnSet.Columns("del_gen_id").Visible = False

        '                e.ColumnSet.Columns("del_gen_nom").Text = "Descripción del Delito"
        '                ' e.ColumnSet.Columns("del_gen_nom").AutoSizeMode = Infragistics.Win.UltraWinTree.ColumnAutoSizeMode.AllNodes
        '                'e.ColumnSet.Columns("del_gen_nom").

        '                e.ColumnSet.Columns("del_gen_nom").Control.Width = "100" ' = Infragistics.Win.UltraWinTree.ColumnAutoSizeMode.AllNodes"
        '                'ltraTreeNodeColumn.LayoutInfo.PreferredCellSize()
        '                '   e.ColumnSet.Columns("del_gen_nom").LayoutInfo.PreferredCellSize = New System.Drawing.Size(400, 20)

        '                e.ColumnSet.Columns("del_gen_cnt").AutoSizeMode = Infragistics.Win.UltraWinTree.ColumnAutoSizeMode.AllNodes
        '                e.ColumnSet.Columns("del_gen_cnt").Text = "Cant."
        '                e.ColumnSet.Columns("del_gen_cnt").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

        '            End If

        '        End Sub

        '        Private Sub frmPanel_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        '            Me.WindowState = FormWindowState.Maximized
        '            'MostrarData()

        '        End Sub

        '        Private Sub cbbregion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbregion.Load

        '        End Sub

        '        Private Sub dgwcapacidad_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwcapacidad.CellDoubleClick, dgwingresos.CellDoubleClick, dgwnacionalidad.CellDoubleClick, dgwnroingreso.CellDoubleClick, dgwPELIGROsidad.CellDoubleClick, dgwsituacion.CellDoubleClick

        '            'Dim _control As String = sender.name

        '            'Dim _col As Integer = e.ColumnIndex
        '            'Dim _row As Integer = e.RowIndex

        '            'Dim frm As New Registro.frmBuscar
        '            'frm._panregion = Me._Region
        '            'frm._panpenal = Me._Penal
        '            'frm.MdiParent = Me.MdiParent
        '            'frm._panPanel = True




        '            'Select Case _control

        '            '    Case "dgwsituacion"


        '            '        Dim _sit As Integer = -1
        '            '        Dim _sexo = Me.dgwsituacion.Rows(_row).Cells("col_sex_sit").Value.ToString


        '            '        Select Case Me.dgwsituacion.Columns(_col).Name
        '            '            Case "col_sen"
        '            '                _sit = 1
        '            '            Case "col_pro"
        '            '                _sit = 2
        '            '            Case "col_mix"
        '            '                _sit = 3
        '            '        End Select
        '            '        frm._pansituacion = _sit
        '            '        frm._pansexo = _sexo


        '            '    Case "dgwnroingreso"


        '            '        Dim _peligrosidad As Integer = -1
        '            '        Dim _sexo = Me.dgwPELIGROsidad.Rows(_row).Cells("col_sex_ing").Value.ToString


        '            '        Select Case Me.dgwPELIGROsidad.Columns(_col).Name
        '            '            Case "col_pel_1"
        '            '                _peligrosidad = 1
        '            '            Case "col_pel_2"
        '            '                _peligrosidad = 2
        '            '            Case "col_pel_3"
        '            '                _peligrosidad = 3
        '            '        End Select

        '            '        frm._panpeligrosidad = _peligrosidad


        '            '    Case "dgwPELIGROsidad"


        '            '        Dim _peligrosidad As Integer = -1

        '            '        Dim _sexo = Me.dgwnroingreso.Rows(_row).Cells("col_sex_pel").Value.ToString



        '            '        Select Case Me.dgwnroingreso.Columns(_col).Name
        '            '            Case "col_ing_1"
        '            '                _peligrosidad = 1
        '            '            Case "col_ing_2"
        '            '                _peligrosidad = 2
        '            '            Case "col_ing_4"
        '            '                _peligrosidad = 4
        '            '        End Select

        '            '        frm._panpeligrosidad = _peligrosidad



        '            '    Case "dgwnacionalidad"



        '            '        Dim _sexo As Integer = -1
        '            '        Dim _nacionalidad As Integer = -1

        '            '        _nacionalidad = Me.dgwnacionalidad.Rows(_row).Cells("col_nac_id").Value.ToString

        '            '        Select Case Me.dgwnacionalidad.Columns(_col).Name
        '            '            Case "col_hom"
        '            '                _sexo = 1
        '            '            Case "col_muj"
        '            '                _sexo = 2
        '            '            Case "col_tot"
        '            '                _sexo = -1
        '            '        End Select

        '            '        If _nacionalidad = 141 Then
        '            '            frm._panextranjero = 1
        '            '        ElseIf _nacionalidad = -1 Then
        '            '            frm._panextranjero = -1
        '            '        Else
        '            '            frm._panextranjero = 2
        '            '        End If


        '            '        frm._pansexo = _sexo
        '            '        frm._pannacionalidad = _nacionalidad

        '            '    Case "dgwingresos"


        '            '        Dim _int_id As Integer = -1
        '            '        Dim _int_cod_rp As String = ""


        '            '        _int_id = Me.dgwingresos.Rows(_row).Cells("col_int_id").Value.ToString

        '            '        _int_cod_rp = Me.dgwingresos.Rows(_row).Cells("int_cod_rp").Value.ToString



        '            '        frm._panInternoId = _int_id
        '            '        frm._paninternoCodRP = _int_cod_rp



        '            'End Select


        '            'frm.Show()


        '        End Sub





        '        Private Sub treedelitos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treedelitos.MouseDoubleClick


        '            Dim _tree As Infragistics.Win.UltraWinTree.UltraTree = sender

        '            Dim _nodo As Infragistics.Win.UltraWinTree.UltraTreeNode = _tree.GetNodeFromPoint(e.Location)
        '            Dim _nodohijo As Windows.Forms.Control = _tree.GetChildAtPoint(e.Location)







        '            If _nodo IsNot Nothing Then

        '                If _nodo.Nodes.Count = 0 Then
        '                    MsgBox("H     " + _nodohijo.Name.ToString)
        '                Else
        '                    MsgBox("P     " + _nodo.Text.ToString)
        '                End If


        '                'Dim frm As New Registro.frmBuscar
        '                'frm._panregion = Me._Region
        '                'frm._panpenal = Me._Penal
        '                'frm.MdiParent = Me.MdiParent
        '                'frm._panPanel = True
        '                'frm._panDelitoGenerico = _nodo.Text
        '                'frm.Show()

        '            End If
        '        End Sub

        '        Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click

        '            MostrarData()

        '        End Sub
    End Class
End Namespace
