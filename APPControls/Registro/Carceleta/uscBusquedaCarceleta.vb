Namespace Registro.Main
    Public Class uscBusquedaCarceleta
        Private objEntCol As Entity.Registro.InternoMovimientoCol = Nothing
        Public Event _Grilla_CellDoubleClick()
        Public Event _Grilla_CellEnter()
        Public Event _Grilla_ValidarFiltro()

        Public Property _PerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
#Region "Propiedades"
        Private Property FiltroNuevo As String = ""
        Private Property FiltroActual As String = ""
#End Region
#Region "Propiedades_Buscar"
        Private ReadOnly Property InternoTraladadoCarceleta As Integer
            Get
                Dim v As Integer = -1
                If rdbActivo.Checked = True Then
                    v = 1 'no trasladado
                End If
                If rdbInactivo.Checked = True Then
                    v = 0 'traslado
                End If
                Return v
            End Get
        End Property
        Private ReadOnly Property TipoMov() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbNuevo.Checked = True Then
                    value = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                End If

                If Me.rdbTraslado.Checked = True Then
                    value = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                End If
                Return value
            End Get

        End Property
        Private ReadOnly Property TipoFecha() As Integer
            Get
                Dim value As Integer = -1

                If rdbFIngreso.Checked = True Then
                    value = 1
                End If

                If Me.rdbFClasificacion.Checked = True Then
                    value = 2
                End If

                Return value

            End Get
        End Property
        Private Property FechaInicio As Long
            Get
                Return Me.dtpFechaInicio.ValueLong
            End Get
            Set(value As Long)
                Me.dtpFechaInicio.ValueLong = value
            End Set
        End Property
        Private Property FechaFin As Long
            Get
                Return Me.dtpFechaFin.ValueLong
            End Get
            Set(value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
        Private ReadOnly Property TipoClasificacion() As Integer
            Get
                Dim value As Integer = -1

                If rdbClasificados.Checked = True Then
                    value = 1
                End If

                If Me.rdbPorClasificar.Checked = True Then
                    value = 0
                End If

                Return value

            End Get
        End Property
        Private Property Apellidos As String
            Get
                Return Me.txtApellidos.Text
            End Get
            Set(value As String)
                Me.txtApellidos.Text = value
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
        Private Property IDNacionalidad() As Integer
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property IDRegion() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property IDPenal() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
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
#End Region
#Region "Combo"
        Private blnComboPenal As Boolean = False
        Private Sub Combo()

            With Me.cbbNacionalidad
                .ComboTipo = Type.Combo.ComboTipo.Nacionalidad
                ._Todos = True
                .LoadUsc()
            End With

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.Region
                ._Todos = True
                .LoadUsc()
            End With

            ComboPenal(-1)
            Me.cbbPenal.Enabled = False

        End Sub
        Private Sub ComboPenal(IDRegion As Integer)

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.Penal
                ._Todos = True
                .CodigoPadre = IDRegion
                .LoadUsc()
            End With
            blnComboPenal = True
        End Sub
#End Region

#Region "Funciones_Publicas"
        Public Sub _LoadUsc()
            Combo()
            Me.FechaInicio = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            Me.FechaFin = Legolas.LBusiness.Globall.DateTime.FechaServerLong


            Select Case Me._PerfilUsuario
                Case Type.Enumeracion.Usuario.EnumDependencia.Legal,
                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                    Type.Enumeracion.Usuario.EnumDependencia.SecretariaJuntaClasificacion,
                    Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                    dgwGrilla.Columns("col_pen_des_clas").Visible = True
                    dgwGrilla.Columns("col_fec_cla").Visible = True

            End Select
        End Sub

        Public Sub _Limpiar()

            Me.rdbMovTodos.Checked = True
            Me.rdbFIngreso.Checked = True
            Me.FechaInicio = 0
            Me.FechaFin = 0
            Me.Apellidos = ""
            Me.Nombres = ""
            Me.rdbClasificacionTodos.Checked = True
            Me.IDNacionalidad = -1
            Me.IDRegion = -1
            Me.IDPenal = -1
            Me.txtApellidos.Focus()
            Me.rdbEstadoTodos.Checked = True
        End Sub

        Public Sub _Buscar(mostrarAlertaRegNoEncontrado As Boolean)

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            Me.FiltroActual = ConcatenarFiltro()

            Dim objBss As New Bussines.Registro.Interno_Grilla
            Dim objEntFiltro As New Entity.Registro.Interno_Grilla

            objEntCol = New Entity.Registro.InternoMovimientoCol

            With objEntFiltro
                .Apellidos = Me.Apellidos
                .PreNombres = Me.Nombres
                .IDNacionalidad = Me.IDNacionalidad
                .IDTipoMovimiento = Me.TipoMov
                .IDRegion = Me.IDRegion
                .IDPenal = Me.IDPenal
                .TipoFecha = Me.TipoFecha
                'If buscarRegConFechaHoy = True Then 'para buscar los registros de la fecha actual
                '    .FechaIngresoIni = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                '    .FechaIngresoFin = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                'Else
                .FechaIngresoIni = Me.FechaInicio
                .FechaIngresoFin = Me.FechaFin
                'End If
                .TipoClasificacion = Me.TipoClasificacion
                .EstadoInternoCarceletaId = Me.InternoTraladadoCarceleta
            End With

            objEntCol = objBss.ListarGrillaMovimientosCarceleta(objEntFiltro)

            With Me.dgwGrilla
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol

                If .RowCount < 1 And mostrarAlertaRegNoEncontrado = True Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Ningún registro encontrado.")
                End If

            End With

        End Sub

        Public Sub _Exportar()

            FormatoGrillaColumnas()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)

        End Sub
        Public Sub _Focus()

            Me.pnlCabecera.Focus()
            Me.gbBusqueda.Focus()
            Me.grbFiltro.Focus()
            Me.txtApellidos.Focus()

        End Sub

        Public Function _IDInternoSelect() As Long
            Return Me.GrillaIDInterno
        End Function

        Public Function _GrillaCount() As Integer
            Return Me.dgwGrilla.RowCount
        End Function
#End Region
#Region "Funciones"
        Private Function ConcatenarFiltro() As String

            Dim objLista As New ArrayList
            'radiobuton
            objLista.Add(Me.TipoMov)
            objLista.Add(Me.TipoFecha)
            objLista.Add(Me.TipoClasificacion)
            'fecha
            objLista.Add(Me.FechaInicio)
            objLista.Add(Me.FechaFin)
            'texto
            objLista.Add(Me.Apellidos)
            objLista.Add(Me.Nombres)
            'combo
            objLista.Add(Me.IDNacionalidad)
            objLista.Add(Me.IDRegion)
            objLista.Add(Me.IDPenal)

            Dim value As String = ""
            For Each str As String In objLista
                value = value & str
            Next

            Return value

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

        End Sub
        Private Function ValidarBusqueda() As Boolean

            Dim value As Boolean = False
            If Me.FechaInicio > 0 Or Me.FechaFin > 0 Then

                If Me.FechaFin < Me.FechaInicio Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser menor que la fecha de inicio")
                    Me.dtpFechaInicio.Focus()
                    Return value
                End If

            End If

            value = True

            Return value

        End Function
#End Region
#Region "Otros"

#End Region

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            If blnComboPenal = True Then

                ComboPenal(Me.IDRegion)

                If Me.IDRegion = -1 Then
                    Me.cbbPenal.Enabled = False
                Else
                    Me.cbbPenal.Enabled = True
                End If

                ValidarFiltro()

            End If

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

            If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
                RaiseEvent _Grilla_CellDoubleClick()
            End If

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            RaiseEvent _Grilla_CellEnter()

        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            '_PerfilUsuario
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

        Private Sub txtApellidos_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidos.KeyPress, txtNombres.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                _Buscar(True)
            End If

        End Sub

        Private Sub txtApellidos_TextChanged(sender As System.Object, e As System.EventArgs) Handles _
            txtApellidos.TextChanged,
             txtNombres.TextChanged

            ValidarFiltro()

        End Sub

        Private Sub rdbNuevo_Click(sender As Object, e As System.EventArgs) Handles _
            rdbNuevo.Click,
            rdbTraslado.Click,
            rdbMovTodos.Click,
            rdbFIngreso.Click,
            rdbFClasificacion.Click,
            rdbClasificados.Click,
            rdbPorClasificar.Click,
            rdbClasificacionTodos.Click


            ValidarFiltro()

        End Sub

        Private Sub cbbNacionalidad__SelectedIndexChanged() Handles _
            cbbNacionalidad._SelectedIndexChanged,
            cbbPenal._SelectedIndexChanged

            ValidarFiltro()

        End Sub

        Private Sub dtpFechaInicio__ValueChanged() Handles _
            dtpFechaInicio._ValueChanged,
             dtpFechaFin._ValueChanged

            ValidarFiltro()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub
    End Class

End Namespace
