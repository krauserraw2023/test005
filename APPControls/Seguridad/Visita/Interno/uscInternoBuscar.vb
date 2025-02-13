
Public Class uscInternoBuscar
    Private objBss As Bussines.Visita.Interno = Nothing
    Private objEntCol As Entity.Visita.InternoCol = Nothing
#Region "Eventos"
    Public Event _CellDoubleClick_Grilla()
    Public Event _RegionPenalSelectedIndexChanged()
#End Region
#Region "Propiedades_Grilla"

    Private ReadOnly Property GrillaInternoID() As Integer
        Get
            Dim _int As Integer = -1

            If dgwGrilla.SelectedRows.Count = 1 Then
                _int = dgwGrilla.SelectedRows(0).Cells("col_int_id").Value.ToString


            End If
            Return _int
        End Get
    End Property
    Private ReadOnly Property GrillaInterno() As String
        Get
            Dim value As String = ""

            If dgwGrilla.SelectedRows.Count = 1 Then

                value = dgwGrilla.SelectedRows(0).Cells("col_ape_pat").Value.ToString &
                " " & dgwGrilla.SelectedRows(0).Cells("col_ape_mat").Value.ToString &
                ", " &
                dgwGrilla.SelectedRows(0).Cells("col_nom").Value.ToString
            End If

            Return value
        End Get
    End Property
    Private ReadOnly Property GrillaInternoEtapa() As String
        Get
            Dim value As String = ""

            If dgwGrilla.SelectedRows.Count = 1 Then
                value = dgwGrilla.SelectedRows(0).Cells("col_etp_nom").Value.ToString
            End If

            Return value
        End Get
    End Property
    Private ReadOnly Property GrillaInternoPabellon() As String
        Get
            Dim value As String = ""

            If dgwGrilla.SelectedRows.Count = 1 Then
                value = dgwGrilla.SelectedRows(0).Cells("col_pab_nom").Value.ToString
            End If

            Return value
        End Get
    End Property
    Private ReadOnly Property GrillaRegionID() As Integer
        Get
            Dim value As Integer = -1
            Try
                If dgwGrilla.SelectedRows.Count = 1 Then
                    value = dgwGrilla.SelectedRows(0).Cells("col_reg_id").Value.ToString
                End If

            Catch ex As Exception

            End Try
            Return value
        End Get
    End Property
    Private ReadOnly Property GrillaRegionNombre() As String
        Get
            Dim value As String = ""

            If dgwGrilla.SelectedRows.Count = 1 Then

                value = dgwGrilla.SelectedRows(0).Cells("col_reg_nom").Value.ToString
            End If

            Return value
        End Get
    End Property
    Private Property GrillaPenalID() As Integer
        Get
            Dim _int As Integer = -1

            If dgwGrilla.SelectedRows.Count = 1 Then
                _int = dgwGrilla.SelectedRows(0).Cells("col_pen_id").Value.ToString

            End If
            Return _int
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property
    Private ReadOnly Property GrillaPenalNombre() As String
        Get
            Dim value As String = ""

            If dgwGrilla.SelectedRows.Count = 1 Then

                value = dgwGrilla.SelectedRows(0).Cells("col_pen_nom").Value.ToString
            End If

            Return value
        End Get
    End Property
#End Region
#Region "Propiedades_Publicos"
    Public ReadOnly Property _GrillaInternoID() As Integer
        Get
            Return Me.GrillaInternoID
        End Get
    End Property
    Public ReadOnly Property _GrillaInterno() As String
        Get
            Return Me.GrillaInterno
        End Get
    End Property
    Public ReadOnly Property _GrillaInternoEtapa() As String
        Get
            Return Me.GrillaInternoEtapa
        End Get
    End Property
    Public ReadOnly Property _GrillaInternoPabellon() As String
        Get
            Return Me.GrillaInternoPabellon
        End Get
    End Property
    Public ReadOnly Property _GrillaRegionID() As Integer
        Get
            Return Me.GrillaRegionID
        End Get
    End Property
    Public ReadOnly Property _GrillaRegionNombre() As String
        Get
            Return Me.GrillaRegionNombre
        End Get
    End Property
    Public ReadOnly Property _GrillaPenalID() As Integer
        Get
            Return Me.GrillaPenalID
        End Get
    End Property
    Public ReadOnly Property _GrillaPenalNombre() As String
        Get
            Return Me.GrillaPenalNombre
        End Get
    End Property

    Public Property _RegionID() As Integer
        Get
            Return Me.UsrRegionPenal1._RegionID
        End Get
        Set(ByVal value As Integer)
            Me.UsrRegionPenal1._RegionID = value
        End Set
    End Property
    Public Property _PenalID() As Integer
        Get
            Return Me.UsrRegionPenal1._PenalID
        End Get
        Set(ByVal value As Integer)
            Me.UsrRegionPenal1._PenalID = value
        End Set
    End Property
#End Region
#Region "Propiedades_Buscar"
    Private Property RegionID() As Integer
        Get
            Return Me.UsrRegionPenal1._RegionID
        End Get
        Set(ByVal value As Integer)
            Me.UsrRegionPenal1._RegionID = value
        End Set
    End Property
    Private ReadOnly Property RegionNombre() As String
        Get
            Return Me.UsrRegionPenal1._RegionNombre
        End Get
    End Property
    Private Property PenalID() As Integer
        Get
            Return Me.UsrRegionPenal1._PenalID
        End Get
        Set(ByVal value As Integer)
            Me.UsrRegionPenal1._PenalID = value
        End Set
    End Property
    Private ReadOnly Property PenalNombre() As String
        Get
            Return Me.UsrRegionPenal1._PenalNombre
        End Get
    End Property
    Private Property CodigoInterno() As String
        Get
            Return Me.txtCodInterno.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtCodInterno.Text = value
        End Set
    End Property
    Private Property IDTipoDocumento As Integer
        Get
            Return Me.cbbTipoDoc.SelectedValue
        End Get
        Set(value As Integer)
            Me.cbbTipoDoc.SelectedValue = value
        End Set
    End Property
    Private Property NumeroDocumento() As String
        Get
            Return Me.txtNumeroDoc.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtNumeroDoc.Text = value
        End Set
    End Property
    Private Property Paterno() As String
        Get
            Return Me.txtApePat.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtApePat.Text = value
        End Set
    End Property
    Private Property Materno() As String
        Get
            Return Me.txtApeMat.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtApeMat.Text = value
        End Set
    End Property
    Private Property Nombres() As String
        Get
            Return Me.txtNom.Text
        End Get
        Set(ByVal value As String)
            Me.txtNom.Text = value
        End Set
    End Property
    Private Property EtapaID() As Short
        Get
            If grbEtapa.Visible = True Then
                Return Me.cbbEtapa.SelectedValue
            Else
                Return -1
            End If
        End Get
        Set(value As Short)
            Me.cbbEtapa.SelectedValue = value
        End Set
    End Property
    Private Property PabellonID() As Short = -1
    Private Property PabellonNombre As String
        Get
            Return Me.txtPabellon.Text.Trim
        End Get
        Set(value As String)
            Me.txtPabellon.Text = value
        End Set
    End Property
    Public ReadOnly Property Estado() As Integer
        Get
            Dim _int As Integer = -1
            If Me.rb_activo.Checked Then
                _int = 1
            ElseIf rb_pasivo.Checked Then
                _int = 0
            End If
            Return _int
        End Get

    End Property
#End Region
#Region "Propiedades_Otros"
    Public Property _Visible_CheckSelect() As Boolean = False
#End Region
#Region "Combo"
    Private Sub ComboTipoDocumento()

        With Me.cbbTipoDoc
            .ComboTipo = Type.Combo.ComboTipo.TipoDoc
            ._Todos = True
            .LoadUsc()
        End With
        Me.IDTipoDocumento = -1 'todos

    End Sub
    Private Sub ComboPabellon()

        'With cbbPabellon
        '    .CodigoPadre = Me._PenalID
        '    ._Todos = True
        '    .LoadUsc()
        'End With

    End Sub
    Private Sub ComboEtapa()

        If Me.grbEtapa.Visible = True Then
            With Me.cbbEtapa
                ._Todos = True
                ._LoadUsc(Type.Combo.ComboTipo.VIS_Etapa)
            End With
        End If

    End Sub
#End Region
#Region "Functions"
    Private Function GrillaCountInternosPrincipal() As Integer

        Dim value As Integer = 0
        Dim intCount As Integer = 0

        With Me.dgwGrilla
            .CurrentCell = Nothing
            For Each dr As DataGridViewRow In .Rows

                If dr.Cells("col_pdr").Value = 0 Then
                    intCount = intCount + 1
                End If
            Next
        End With
        value = intCount

        Return value

    End Function
    Private Function CodigoPenalMultiple() As String

        Dim value As String = ""

        If Me.PenalID = -1 And Me.UsrRegionPenal1.cbbPenal.ItemsCount > 1 Then
            'sdswd
            Dim strPenalArray As New ArrayList
            Dim strCadena As String = ""

            For i As Integer = 1 To Me.UsrRegionPenal1.cbbPenal.ItemsCount - 1
                Me.UsrRegionPenal1.cbbPenal.SelectedIndex = i
                strCadena = Me.UsrRegionPenal1.cbbPenal.SelectedValue
                strPenalArray.Add(strCadena)
            Next
            Me.UsrRegionPenal1.cbbPenal.SelectedIndex = 0 'inicio

            strCadena = ""

            strPenalArray.Sort()
            For Each str As String In strPenalArray
                strCadena = strCadena & str & ","
            Next

            value = Legolas.Components.Cadena.Left(strCadena, strCadena.Length - 1)
        End If

        Return value

    End Function
#End Region
#Region "Validar_Busqueda"
    Private Function ValidarBusqueda() As Boolean

        Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
            Case 1 'sede central
                If Me.PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Selecione Penal")
                    Return False
                End If
        End Select

        Return True

    End Function
#End Region
#Region "Listar"
    Public Sub Buscar()

        If ValidarBusqueda() = False Then
            Exit Sub
        End If

        objBss = New Bussines.Visita.Interno
        objEntCol = New Entity.Visita.InternoCol

        Dim objEntFiltro As New Entity.Visita.Interno

        With objEntFiltro
            .CodigoRP = Me.CodigoInterno
            .TipoDocumentoID = Me.IDTipoDocumento
            .NumeroDocumento = Me.NumeroDocumento
            .ApellidoPaterno = Me.Paterno
            .ApellidoMaterno = Me.Materno
            .Nombres = Me.Nombres
            .EstadoID = Me.Estado
            .EtapaID = Me.EtapaID
            .PabellonID = Me.PabellonID
            .PabellonNombre = Me.PabellonNombre
            .IDRegion = Me.RegionID
            .IDPenal = Me.PenalID
            .PenalIDMultiple = Me.CodigoPenalMultiple
        End With

        objEntCol = objBss.ListarGrillaNombresAsociados(objEntFiltro)

        'no aparecen la columna en la exportacion
        Me.col_chk.Tag = "1"

        With Me.dgwGrilla
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
            .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
            .AutoGenerateColumns = False
            .MultiSelect = False
            .DataSource = objEntCol

            Me.lblReg.Text = GrillaCountInternosPrincipal() & " Reg."

        End With

        VisibleCampos()

    End Sub
    Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

        If InternoID < 1 Then
            Exit Sub
        End If

        If Me.UscFotografia_2v1._CheckImagen = False Then
            Me.UscFotografia_2v1._Limpiar()
            Exit Sub
        End If

        Me.UscFotografia_2v1._showFotoInternoPrincipal(InternoID, 2)

        If UscFotografia_2v1._HasImagen = False Then
            Me.UscFotografia_2v1._Limpiar()
        End If

    End Sub

#End Region
#Region "Accion"

    Public Sub _Exportar()
        Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
    End Sub
    Public Sub _InactivarInternoMasivo()

        'validar registro seleccionados
        Dim intCount As Integer = 0

        For Each fila As DataGridViewRow In Me.dgwGrilla.Rows
            If fila.Cells("col_chk").Value = True Then
                intCount = intCount + 1
            End If
        Next

        If intCount < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Selecione uno o mas internos, para utilizar esta opcion")
            Exit Sub
        End If

        If Legolas.Configuration.Aplication.MessageBox.Question("Esta seguro de inactivar a los interno(s) seleccionado(s)") _
            <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim intCodigo As Integer = -1

        For Each fila As DataGridViewRow In Me.dgwGrilla.Rows

            If fila.Cells("col_chk").Value = True Then
                intCodigo = fila.Cells("col_int_id").Value
                InactivarInterno(intCodigo)
            End If

        Next

        Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
        Buscar()

    End Sub
    Private Function InactivarInterno(Codigo As Integer) As Integer

        Dim value As Integer = -1

        objBss = New Bussines.Visita.Interno
        value = objBss.InactivarInterno(Codigo)

        Return value

    End Function
    Public Function _ActivarInterno() As Integer

        Dim value As Integer = -1

        If Me.GrillaInternoID < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Information("Seleccione el interno a Activar")
            Return value
        End If

        If Legolas.Configuration.Aplication.MessageBox.Question("Desea Activar el Interno: " & Me.GrillaInterno) = DialogResult.Yes Then

            Dim strMensajeOut As String = ""
            objBss = New Bussines.Visita.Interno
            value = objBss.ActivarInterno(Me.GrillaInternoID, strMensajeOut)

            If value > 0 Then
                Buscar()
            Else
                If strMensajeOut.Trim.Length > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Ha ocurrido un problema en la operacion. Vuelva a intentarlo")
                End If
            End If

        End If

        Return value

    End Function
    Private Sub ALimpiar()

        Me.CodigoInterno = ""
        Me.IDTipoDocumento = -1
        Me.NumeroDocumento = ""
        Me.Paterno = ""
        Me.Materno = ""
        Me.Nombres = ""
        Me.txtApePat.Focus()

    End Sub
#End Region
#Region "Permisos/Accesos"
    Private Property RegimenVisitaID As Short = -1
    Private Property RegimenTipoNombre As String = ""
    Private Property SolicitarAutoRegOrdinario As Boolean = False
    Public Property _SolicitaModuloPOPE As Boolean = True
    Private Sub Listar_VisitaConfig()

        Dim objBss As New Bussines.Visita.Config
        Dim objEnt As Entity.Visita.Config = Nothing

        Dim objEntFiltro As New Entity.Visita.Config

        With objEntFiltro
            .RegionID = Me._RegionID
            .PenalID = Me._PenalID
            .Estado = 1 'alta
        End With

        If PenalID > 0 Then
            objEnt = New Entity.Visita.Config
            objEnt = objBss.ListarConfigActual(objEntFiltro)
        End If

        If Not objEnt Is Nothing Then
            With objEnt
                Me.RegimenVisitaID = .RegimenTipoID
                Me.RegimenTipoNombre = .RegimenTipoNombre
                Me.SolicitarAutoRegOrdinario = .SolicitaAutoRegOrdinario
                Me._SolicitaModuloPOPE = .SolicitaModuloPOPE
            End With
        Else
            Me.RegimenVisitaID = -1
            Me.RegimenTipoNombre = "Regimen Ordinario"
            Me.SolicitarAutoRegOrdinario = False
            Me._SolicitaModuloPOPE = True
        End If

    End Sub
#End Region
#Region "Otros"
    Private Sub Visible_ColumnaCheck()

        Me.chkSelect.Visible = Me._Visible_CheckSelect
        Me.col_chk.Visible = Me._Visible_CheckSelect

    End Sub

    Private Sub VisibleCampos()

        Dim blnVisibleEtapa As Boolean = False
        Dim intVisibleEtapa As Byte = 0
        Dim intVisiblePabellon As Byte = 0

        Select Case Me.RegimenVisitaID
            Case 1 'ordinario
                blnVisibleEtapa = False
                intVisibleEtapa = 1
            Case 2, 3
                blnVisibleEtapa = True
                intVisibleEtapa = 0
        End Select

        Me.col_etp_nom.Visible = blnVisibleEtapa
        Me.col_etp_nom.DividerWidth = Integer.Parse(intVisibleEtapa)

        Me.chkSelect.Visible = False ' Me._Visible_CheckSelect
        Me.col_chk.Visible = False ' Me._Visible_CheckSelect


        'mostrar columnas de sistema
        Select Case Legolas.Configuration.Usuario.OficinaID

            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                Me.col_int_id.DividerWidth = 0
                Me.col_id_loc_row.DividerWidth = 0
                Me.col_reg_id.DividerWidth = 0
                Me.col_pen_id.DividerWidth = 0
                Me.col_id_sed_row.DividerWidth = 0
                Me.col_ver_int.DividerWidth = 0

        End Select

    End Sub
    Private Sub VisibleControles()

        Listar_VisitaConfig()

        Dim blnVisibleEtapa As Boolean = False

        Select Case Me.RegimenVisitaID
            Case 1 'ordinario
                blnVisibleEtapa = False
            Case 2, 3
                blnVisibleEtapa = True
        End Select

        Me.grbEtapa.Visible = blnVisibleEtapa

    End Sub
    Public Sub _LoadUsc()

        ValoresxDefault()
        'Buscar()

    End Sub
    Private Sub ValoresxDefault()

        With Me.UsrRegionPenal1
            ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
            ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
            ._LoadUsc()
        End With

        VisibleControles()

        ComboTipoDocumento()
        ComboEtapa()
        ComboPabellon()

        Visible_ColumnaCheck()

    End Sub
    Private Sub SeleccionarTodos(vf As Boolean)

        For Each fila As DataGridViewRow In Me.dgwGrilla.Rows
            fila.Cells("col_chk").Value = vf
        Next

    End Sub
#End Region

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

        Me.RegionID = Me.UsrRegionPenal1._RegionID
        Me.PenalID = Me.UsrRegionPenal1._PenalID

        Buscar()

    End Sub

    Private Sub dgw_interno_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

        Try
            With Me.dgwGrilla
                If e.RowIndex = -1 Then
                    Me.Cursor = Cursors.WaitCursor
                    objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End If
            End With

            'ListarInternoFoto(Me.GrillaInternoID)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgw_interno_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

        If e.RowIndex >= 0 And Me.dgwGrilla.RowCount > 0 Then
            RaiseEvent _CellDoubleClick_Grilla()
        End If

    End Sub

    Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtCodInterno.KeyPress,
       txtApePat.KeyPress,
       txtApeMat.KeyPress,
       txtNom.KeyPress,
       txtNumeroDoc.KeyPress,
       txtPabellon.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Buscar()
        End If

    End Sub

    Private Sub dgw_interno_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

        If Me.dgwGrilla.RowCount > 0 Then
            ListarInternoFotoVersion(Me.GrillaInternoID)
        End If

    End Sub

    Private Sub chkSelect_Click(sender As Object, e As System.EventArgs) Handles chkSelect.Click

        SeleccionarTodos(Me.chkSelect.Checked)

    End Sub

    Private Sub dgwGrilla_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgwGrilla.RowPrePaint

        With Me.dgwGrilla

            Select Case (.Item("col_pdr", e.RowIndex).Value) 'estado color
                Case 0 'padres
                    .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White 'Color.PowderBlue
                    .Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(65, 91, 133) 'Color.Black
                Case 1 'hijos
                    .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                    .Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(0, 128, 0) 'Color.Black                        
            End Select
            .Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
            .Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
        End With

    End Sub

    Private Sub UsrRegionPenal1__PenalSelectedIndexChanged() Handles UsrRegionPenal1._PenalSelectedIndexChanged

        Listar_VisitaConfig()
        VisibleControles()
        ComboPabellon()
        ComboEtapa()
        VisibleCampos()

        RaiseEvent _RegionPenalSelectedIndexChanged()

    End Sub

   
    Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick

        ListarInternoFotoVersion(Me.GrillaInternoID)

    End Sub


    Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

        With Me.dgwGrilla
            Select Case e.ColumnIndex

                Case .Columns("col_fec_nac").Index

                    If IsNumeric(e.Value) And e.Value > 1 Then
                        e.Value = Legolas.Components.FechaHora.FechaDate(e.Value).ToShortDateString
                        'e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                    Else
                        e.Value = ""
                    End If

            End Select
        End With

    End Sub

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click

        ALimpiar()

    End Sub
End Class
