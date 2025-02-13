Namespace Registro.Main
    Public Class uscBusquedaMovimiento_LM
        Private objEntCol As Entity.Registro.InternoMovimientoCol = Nothing
        Public Event _Grilla_CellDoubleClick()
        Public Event _Grilla_CellEnter()
        Public Event _Grilla_ValidarFiltro()

        Public Property _PerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia
#Region "Propiedades_Publicas"
        Public Property _IDRegion() As Integer = -1
        Public Property _IDPenal() As Integer = -1
#End Region
#Region "Propiedades"
        Private Property FiltroNuevo As String = ""
        Private Property FiltroActual As String = ""
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property

        Public Property _ColorFondoGrilla() As Color
            Get
                Return dgwGrilla.BackgroundColor
            End Get
            Set(value As Color)
                dgwGrilla.BackgroundColor = value
            End Set
        End Property

        Public Property EstadoID() As Integer
            Get
                Return Me.cbbEstado.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEstado.SelectedValue = value
            End Set
        End Property
        Public Property EstadoTramiteID() As Integer = -1
        Public Property EstadoTramite() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(Me.cbbEstado.Text).ToUpper
            End Get
            Set(ByVal value As String)

            End Set
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private ReadOnly Property IDTipoGrupo() As Integer
            Get
                Dim value As Integer = -1
                If Me.rdbIngresos.Checked = True Then
                    value = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                ElseIf Me.rdbEgresos.Checked = True Then
                    value = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso
                Else
                    value = -1
                End If
                Return value
            End Get
        End Property
        Private Property TipoFecha As Short
            Get
                Dim value As Short = -1

                If Me.rdbFechaClasif.Checked = True Then
                    value = 1
                End If

                If Me.rdbFechaMov.Checked = True Then
                    value = 2
                End If
                Return value
            End Get
            Set(value As Short)

                Me.rdbFechaClasif.Checked = False
                Me.rdbFechaMov.Checked = False

                Select Case value
                    Case 1
                        Me.rdbFechaClasif.Checked = True
                    Case 2
                        Me.rdbFechaMov.Checked = True
                End Select
            End Set
        End Property
        Private Property FechaInicio() As Long
            Get
                Return Me.dtpFechaIni.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFinal() As Long
            Get
                Return Me.dtpFechaFin.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
        Private Property IDTipoMovimiento() As Integer
            Get
                Return Me.cbbMovimientoTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovimientoTipo.SelectedValue = value
            End Set
        End Property
        Private Property IDTipoMotivo() As Integer
            Get
                Return Me.cbbMovimientomotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovimientoTipo.SelectedValue = value
            End Set
        End Property

        Private Property CodigoRP As String
            Get
                Return Me.txtCodigoRp.Text
            End Get
            Set(value As String)
                Me.txtCodigoRp.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno As String
            Get
                Return Me.txtApellidoPaterno.Text
            End Get
            Set(value As String)
                Me.txtApellidoPaterno.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno As String
            Get
                Return Me.txtApellidoMaterno.Text
            End Get
            Set(value As String)
                Me.txtApellidoMaterno.Text = value
            End Set
        End Property
        Private Property Nombres As String
            Get
                Return Me.txtNombres.Text
            End Get
            Set(value As String)
                Me.txtNombres.Text = value
            End Set
        End Property

        Private Property IDRegionClasif As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property

        Private Property IDPenalClasif As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private Property IDNacionalidad As Short
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property

        Private Property IDMovimientoEstado() As Integer
            Get
                Return Me.cbbEstado.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEstado.SelectedValue = value
            End Set
        End Property
        Public Property _TipoBusqueda() As Boolean = False
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDInterno() As Long
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Public ReadOnly Property GrillaPenalID() As Integer
            Get
                Dim value As Long = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_pen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Public ReadOnly Property GrillaNombresCompleto() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_ape_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

#End Region
#Region "Combos"

        Private cargoComboMovimientoTipo As Boolean = False
        Private Sub ComboMovimientoTipo()
            With Me.cbbMovimientoTipo
                ._Todos = True
                .LoadUsc()
                ' .Enabled = False
            End With
            ComboEstado()
            cargoComboMovimientoTipo = True
        End Sub

        Private Sub ComboMovimientoMotivo()
            With Me.cbbMovimientomotivo
                .CodigoPadre = IIf(Me.IDTipoMovimiento > 0, Me.IDTipoMovimiento, -2)
                ._Todos = True
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboRegion()

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.Region
                ._Todos = False
                .LoadUsc()
                .SelectedValue = 3 'region lima 
                .Enabled = False
            End With

        End Sub
        Private Sub ComboPenal(intIDRegion As Short)

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = intIDRegion
                .Parametro1 = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboNacionalidad()

            With Me.cbbNacionalidad
                .ComboTipo = Type.Combo.ComboTipo.Nacionalidad
                ._Todos = True
                .LoadUsc()
            End With

        End Sub

        Private Sub ComboEstado()

            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbEstado
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"

                Select Case Me.IDTipoMovimiento
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental
                        .DataSource = objBss.ComboMovimientoEstadoOrdenTrasladoSaludMental(True)
                        .SelectedIndex = 0

                    Case Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental
                        .DataSource = objBss.ComboMovimientoEstadoRetornoTrasladoSaludMental(True)
                        .SelectedIndex = 0
                    Case Else
                        .DataSource = objBss.ComboMovimientoEstado(True)
                        .SelectedIndex = 0
                End Select
            End With

        End Sub
#End Region

#Region "Funciones_Publicas"

        Public Sub _LoadUsc()
            dgwGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgwGrilla.VisibleCampos = True
            ComboMovimientoTipo()
            ComboMovimientoMotivo()
            ComboRegion()
            ComboNacionalidad()
            ComboPenal(Me.IDRegionClasif)

            Me.FechaInicio = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            Me.FechaFinal = Legolas.LBusiness.Globall.DateTime.FechaServerLong

            dgwGrilla.Columns("col_fec_mov").Visible = True
            dgwGrilla.Columns("col_fec_cre_mov").Visible = False

        End Sub

        Public Sub _Limpiar()

            Me.rdbTodos.Checked = True
            Dim valor As Long = Legolas.Components.FechaHora.FechaLong(Now())
            Me.FechaInicio = Legolas.Components.FechaHora.FechaPrimerDiaMes(valor)
            Me.FechaFinal = Legolas.Components.FechaHora.FechaLong(Now())
            Me.cbbMovimientoTipo.SelectedValue = -1
            Me.cbbMovimientomotivo.SelectedValue = -1
            Me.txtCodigoRp.Text = ""
            Me.txtApellidoPaterno.Text = ""
            Me.txtApellidoMaterno.Text = ""
            Me.txtNombres.Text = ""
            cbbMovimientomotivo.Enabled = True
            dgwGrilla.DataSource = Nothing

            Me.txtApellidoPaterno.Focus()

        End Sub

        Public Sub _Buscar(Optional mostrarAlertaRegNoEncontrado As Boolean = True)

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            Me.FiltroActual = ConcatenarFiltro()

            Dim objBss As New Bussines.Registro.Interno_Grilla.RegionLima
            Dim objEntFiltro As New Entity.Registro.Interno_Grilla

            objEntCol = New Entity.Registro.InternoMovimientoCol

            With objEntFiltro
                .IDRegion = Me._IDRegion
                .IDPenal = Me._IDPenal
                .IDGrupoMovimiento = Me.IDTipoGrupo
                .IDMotivoMovimiento = Me.IDTipoMotivo
                .IDTipoMovimiento = Me.IDTipoMovimiento
                .IDMovimientoEstado = Me.IDMovimientoEstado ' e.c.cc.
                .InternoCodigoRP = Me.CodigoRP
                .PrimerApellido = Me.ApellidoPaterno
                .SegundoApellido = Me.ApellidoMaterno
                .PreNombres = Me.Nombres
                .TipoFecha = Me.TipoFecha
                .FechaIngresoIni = Me.FechaInicio
                .FechaIngresoFin = Me.FechaFinal

                If .TipoFecha = 1 Then 'fecha de clasificacion 
                    .IDRegionClasif = Me.IDRegionClasif
                    .IDPenalClasif = Me.IDPenalClasif
                Else
                    .IDRegionClasif = -1
                    .IDPenalClasif = -1
                End If

                .IDNacionalidad = Me.IDNacionalidad

                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    .TrasladadoDeCarceleta = 1
                End If

            End With

            objEntCol = objBss.ListarGrillaMovimientoRL(objEntFiltro)

            With Me.dgwGrilla
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                .CurrentCell = Nothing
            End With

            If mostrarAlertaRegNoEncontrado = True And objEntCol.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Ningún registro encontrado.")
            End If

        End Sub

        Public Sub _Exportar()

            FormatoGrillaColumnas()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub

        Public Function _PenIdSelect() As Long
            Return Me.GrillaPenalID
        End Function

        Public Function _IDInternoSelect() As Long
            Return Me.GrillaIDInterno
        End Function

        Public Function _GrillaCount() As Integer
            Return Me.dgwGrilla.RowCount
        End Function

        Public Function _NombresCompletoSelect() As String
            Return Me.GrillaNombresCompleto
        End Function
        Public Sub _Focus()

            Me.txtApellidoPaterno.Focus()

        End Sub
#End Region
#Region "Funciones"
        Private Function ConcatenarFiltro() As String
            Dim objLista As New ArrayList
            'texto
            objLista.Add(Me.CodigoRP)
            objLista.Add(Me.ApellidoPaterno)
            objLista.Add(Me.ApellidoMaterno)
            objLista.Add(Me.Nombres)
            'combos
            objLista.Add(Me._IDRegion)
            objLista.Add(Me._IDPenal)
            'radio buton
            objLista.Add(Me.IDTipoGrupo)
            'combox
            objLista.Add(Me.IDTipoMovimiento)
            objLista.Add(Me.IDTipoMotivo)
            'fecha
            objLista.Add(Me.FechaInicio)
            objLista.Add(Me.FechaFinal)

            Dim FiltroConcatenado As String = ""
            For Each obj As String In objLista
                FiltroConcatenado = FiltroConcatenado & obj
            Next
            Return FiltroConcatenado
        End Function
        Private Sub ValidarFiltro()

            Me.FiltroNuevo = ConcatenarFiltro()

            If Me.FiltroNuevo <> Me.FiltroActual Then
                Me.dgwGrilla.DataSource = Nothing
                RaiseEvent _Grilla_ValidarFiltro()
            End If

        End Sub
        Private Sub FormatoGrillaColumnas()

            Me.col_fec_cla.Tag = "fecha"
            Me.col_fec_mov.Tag = "fecha_hora"

            Me.col_fec_cre_mov.Tag = "fecha_hora"
        End Sub
        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False
            Dim strMensaje As String = ""

            'validar fecha inicio
            If Me.FechaInicio < 1 Then
                strMensaje = "Ingrese fecha de ingreso, para realizar la busqueda"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Me.dtpFechaIni.Focus()
                Return value
            End If

            'validar fecha fin
            If Me.FechaFinal < 1 Then
                strMensaje = "Ingrese fecha fin, para realizar la busqueda"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Me.dtpFechaFin.Focus()
                Return value
            End If

            'validar fecha inicio menor a fecha final
            If Me.FechaInicio > 0 Or Me.FechaFinal > 0 Then

                If Me.FechaFinal < Me.FechaInicio Then
                    Me.dtpFechaIni.Focus()
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser menor que la fecha de inicio")
                    Return value
                End If
            End If

            value = True

            Return value

        End Function

#End Region

#Region "Otros"
        Private Sub ALimpiarFecha()

            Select Case Me.TipoFecha
                Case 1 'fecha clasificacion                    
                    Me.cbbPenal.Enabled = True
                    Me.IDPenalClasif = -1
                Case 2 'fecha de movimiento
                    Me.IDPenalClasif = -1
                    Me.cbbPenal.Enabled = False
            End Select

            'Me.dtpFechaIni.ValueLong = 0
            'Me.dtpFechaFin.ValueLong = 0
            Me.dtpFechaIni.Focus()

        End Sub
#End Region
        Private Sub rdbTodos_Click(sender As Object, e As System.EventArgs) Handles _
            rdbTodos.Click,
            rdbIngresos.Click,
            rdbEgresos.Click

            ValidarFiltro()

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick
            With Me.dgwGrilla
                If e.RowIndex = -1 Then

                    Me.Cursor = Cursors.WaitCursor
                    objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    Me.Cursor = Cursors.Default
                    .Refresh()

                End If
            End With
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            Me.Cursor = Cursors.WaitCursor

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                Me._TipoBusqueda = True
                RaiseEvent _Grilla_CellDoubleClick()
                Me._TipoBusqueda = False
            End If

            Me.Cursor = Cursors.Default
        End Sub

        Private Sub dgwListarMovimiento_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_cla").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If
                    Case .Columns("col_fec_mov").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True).ToString("dd/MM/yyyy HH:mm")
                        Else
                            e.Value = ""
                        End If

                    Case .Columns("col_pen_des_clas").Index

                        Select Case Me._PerfilUsuario
                            Case Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                Type.Enumeracion.Usuario.EnumDependencia.Social,
                                Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                Type.Enumeracion.Usuario.EnumDependencia.SecretariaJuntaClasificacion

                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                            Case Else

                                If dgwGrilla.Item("col_doc_cla", e.RowIndex).Value.ToString.Length > 0 Then

                                Else
                                    e.Value = ""
                                End If

                        End Select

                End Select
            End With
        End Sub

        Private Sub dtpFechaIni__ValueChanged() Handles _
            dtpFechaIni._ValueChanged,
            dtpFechaFin._ValueChanged

            ValidarFiltro()

        End Sub

        Private Sub cbbMovimientoTipo__SelectedIndexChanged() Handles cbbMovimientoTipo._SelectedIndexChanged
            If cargoComboMovimientoTipo = True Then
                ComboMovimientoMotivo()
                ValidarFiltro()
                Select Case cbbMovimientoTipo.SelectedValue
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Fuga, Type.Enumeracion.Movimiento.EnumMovTipo.Fallecimiento
                        cbbMovimientomotivo.Enabled = False
                    Case Else
                        cbbMovimientomotivo.Enabled = True
                End Select
                ComboEstado()

            End If
        End Sub

        Private Sub txtCodigoRp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _
            txtCodigoRp.KeyPress,
            txtApellidoPaterno.KeyPress,
            txtApellidoMaterno.KeyPress,
            txtNombres.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                _Buscar()
            End If

        End Sub

        Private Sub txtCodigoRp_TextChanged(sender As System.Object, e As System.EventArgs) Handles _
            txtCodigoRp.TextChanged,
            txtApellidoPaterno.TextChanged,
            txtApellidoMaterno.TextChanged,
            txtNombres.TextChanged
            ValidarFiltro()

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            RaiseEvent _Grilla_CellEnter()
        End Sub

        Private Sub cbbMovimientomotivo__SelectedIndexChanged() Handles cbbMovimientomotivo._SelectedIndexChanged
            ValidarFiltro()
        End Sub

        Private Sub rdbFechaMov_Click(sender As Object, e As EventArgs) Handles rdbFechaMov.Click,
                rdbFechaClasif.Click

            ALimpiarFecha

        End Sub

        Private Sub gbTipoingreso_Enter(sender As Object, e As EventArgs) Handles gbTipoingreso.Enter

        End Sub
    End Class

End Namespace
