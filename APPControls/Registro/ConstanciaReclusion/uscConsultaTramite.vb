Imports System.Data

Namespace Registro.ConsultaReclusion
    Public Class uscConsultaTramite
        Private objBss As Bussines.Registro.ConstanciaReclusion.Tramite = Nothing
        Private objFiltro As Entity.Registro.ConstanciaReclusion.Tramite = Nothing
        Private tipoLicencia As Short = 0
        Private esORL As Boolean = False

        Public Event _Grilla_CellEnter()
        Public Event _CellDoubleClick_Ver(idTramite As Integer)

#Region "Propiedades"
        Private Property idRegion As Integer
            Get
                Return cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegion.SelectedValue = value
            End Set
        End Property

        Private Property idPenal As Integer
            Get
                Return cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenal.SelectedValue = value
            End Set
        End Property

        Private Property idTipoSolicitante As Integer
            Get
                Return cbbTipSolicitante.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipSolicitante.SelectedValue = value
            End Set
        End Property

        Private Property idTipoDocumentoRef As Integer
            Get
                Return cbbTipoDocumentoRef.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoDocumentoRef.SelectedValue = value
            End Set
        End Property

        Private Property idEstado As Integer
            Get
                Return cbbTipoEstado.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoEstado.SelectedValue = value
            End Set
        End Property

        Private Property idTipoBusquedaFecha As Integer
            Get
                Return cbbtipoFechas.SelectedValue
            End Get
            Set(value As Integer)
                cbbtipoFechas.SelectedValue = value
            End Set
        End Property
        Private Property nroReferencia As String
            Get
                Return Me.txtNumeroRef.Text
            End Get
            Set(value As String)
                Me.txtNumeroRef.Text = value
            End Set
        End Property
        Private Property InternoCodigo As String
            Get
                Return Me.txtCodigoInterno.Text
            End Get
            Set(value As String)
                Me.txtCodigoInterno.Text = value
            End Set
        End Property
        Private Property ApellidosInterno As String
            Get
                Return Me.txtApellidosInterno.Text
            End Get
            Set(value As String)
                Me.txtApellidosInterno.Text = value
            End Set
        End Property

        Private Property nombresInterno As String
            Get
                Return Me.txtnombreInterno.Text
            End Get
            Set(value As String)
                Me.txtnombreInterno.Text = value
            End Set
        End Property

        Private Property fechaInicioBusqueda As DateTime
            Get
                Dim value As DateTime
                If Me.dtpFechaIni.ValueLong > 0 Then
                    value = Me.dtpFechaIni.Value
                Else
                    value = Nothing
                End If
                Return value
            End Get
            Set(value As DateTime)
                Me.dtpFechaIni.Value = value
            End Set
        End Property

        Private Property fechaFinBusqueda As DateTime
            Get
                Dim value As DateTime
                If Me.dtpFechaFin.ValueLong > 0 Then
                    value = Me.dtpFechaFin.Value
                Else
                    value = Nothing
                End If
                Return value
            End Get
            Set(value As DateTime)
                Me.dtpFechaFin.Value = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property grillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try

                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_codigo").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property grillaNumeroTramite() As String
            Get
                Dim value As String = ""
                Try

                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_num_Tram").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property grillaNumeroCR() As String
            Get
                Dim value As String = ""
                Try

                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_num_cr").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property _grillaIdInterno() As Integer
            Get
                Dim value As Integer = -1
                Try

                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_idInterno").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Public ReadOnly Property _grillaIdPenal As Short
            Get
                Dim value As Short = -1
                Try

                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_id_Penal").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property



#End Region
#Region "Combo"
        Private Sub comboRegion()

            Dim blnTodos As Boolean = False

            If Me.tipoLicencia = 1 And esORL = False Then 'sede central
                blnTodos = True
            End If

            With cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                ._Todos = blnTodos
                .Parametro1 = Me.tipoLicencia
                .LoadUsc()

                If esORL = True Then
                    .SelectedValue = 3 'region lima
                    .Enabled = False
                End If

            End With
        End Sub
        Private Sub comboPenal()

            Dim blnTodos As Boolean = False

            If Me.tipoLicencia = 1 Then 'sede central
                blnTodos = True
            Else
                Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
                Dim objBssLicencia As New Bussines.Sistema.Instalacion
                intTipoLicencia = objBssLicencia.ListarTipo(tipoLicencia)

                Select Case intTipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                        blnTodos = True
                End Select
            End If

            With Me.cbbPenal
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.idRegion
                .Parametro1 = Me.tipoLicencia
                .LoadUsc()
            End With

        End Sub
        Private Sub comboSolicitante()
            With cbbTipSolicitante
                .ComboTipo = Type.Combo.ComboTipo.TipoAutoridadJudicialSolicitante
                ._Todos = True
                .LoadUsc()
            End With
        End Sub

        Private Sub comboTipoFecha()

            Dim bssCombo As New Bussines.General.Parametrica.ConstanciaReclusion
            With cbbtipoFechas
                .DataSource = bssCombo.comboTipoFecha(True)
                .DisplayMember = "Nombre"
                .ValueMember = "Codigo"
                .SelectedIndex = 0
            End With

        End Sub

        Private Sub comboTipoDocumentoRef(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]")

            Dim bssCombo As New Bussines.General.Parametrica.ConstanciaReclusion
            With cbbTipoDocumentoRef
                .DataSource = bssCombo.comboDocumento(True, True, True, True)
                .DisplayMember = "Nombre"
                .ValueMember = "Codigo"
                .SelectedIndex = 0
            End With

        End Sub

        Private Sub comboTipoEstado(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]")

            Dim bssCombo As New Bussines.General.Parametrica.ConstanciaReclusion
            With cbbTipoEstado
                .DataSource = bssCombo.comboTipoEstado(True)
                .DisplayMember = "Nombre"
                .ValueMember = "Codigo"
                .SelectedIndex = Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente
            End With

        End Sub
#End Region
#Region "listar"
        Public Sub listarGrilla()

            Dim objFiltro As New Entity.Registro.ConstanciaReclusion.Tramite
            With objFiltro
                .idRegion = Me.idRegion
                .idPenal = Me.idPenal
                .idTipoSolicitante = Me.idTipoSolicitante
                .documentoReferenciaTipo = Me.idTipoDocumentoRef
                .documentoReferenciaNumero = Me.nroReferencia
                .internoCodigoRD = Me.InternoCodigo
                .internoApellidos = Me.ApellidosInterno
                .internoNombre = Me.nombresInterno
                .estado = Me.idEstado
                .tipoBusquedaFecha = Me.idTipoBusquedaFecha
                .fechaBusquedaInicio = Me.fechaInicioBusqueda
                .fechaBusquedaFinal = Me.fechaFinBusqueda
            End With

            Dim lista As New List(Of Entity.Registro.ConstanciaReclusion.Tramite)
            objBss = New Bussines.Registro.ConstanciaReclusion.Tramite

            lista = objBss.listarGrillaTramite(objFiltro)

            'columna region
            If Me.idRegion > 0 Then
                Me.col_reg_nom.Visible = False
            Else
                Me.col_reg_nom.Visible = True
            End If

            'columna penal
            If Me.idPenal > 0 Then
                Me.col_pen_nom.Visible = False
            Else
                Me.col_pen_nom.Visible = True
            End If

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = lista
            End With

        End Sub
#End Region
#Region "Formularios"
        Private Sub frmVerImpresiones()

            Dim frm As New Registro.ConstanciaReclusion.frmImpresion(Me.grillaCodigo, Me.grillaNumeroTramite, Me.grillaNumeroCR)
            With frm
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Otros"
        Public Sub _loadUsc(tipolicencia As Short, esORL As Boolean)

            Me.tipoLicencia = tipolicencia
            Me.esORL = esORL

            comboRegion()
            comboPenal()
            comboSolicitante()
            comboTipoFecha()
            comboTipoDocumentoRef()
            comboTipoEstado()

        End Sub

        Public Sub _exportar()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
        End Sub
        Public Sub _buscar()

            listarGrilla()

        End Sub
        Public Sub _limpiarFiltros()
            Me.idTipoSolicitante = -1
            Me.cbbtipoFechas.SelectedIndex = 0
            Me.idTipoDocumentoRef = -1
            Me.nroReferencia = ""
            Me.idEstado = -1
            Me.InternoCodigo = ""
            Me.ApellidosInterno = ""
            Me.nombresInterno = ""
        End Sub
        Public Function _count() As Integer
            Return Me.dgwGrilla.RowCount
        End Function
#End Region
        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            comboPenal()

        End Sub

        Private Sub cbbtipoFechas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbtipoFechas.SelectedIndexChanged

            If cbbtipoFechas.SelectedIndex = 0 Then
                dtpFechaIni.Enabled = False
                dtpFechaFin.Enabled = False
                dtpFechaIni.Value = ""
                dtpFechaFin.Value = ""
            Else
                dtpFechaIni.Enabled = True
                dtpFechaFin.Enabled = True
            End If

        End Sub

        Private Sub tsbBuscar_Click(sender As Object, e As EventArgs)
            listarGrilla()
        End Sub

        Private Sub txtNumeroRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroRef.KeyDown,
                txtCodigoInterno.KeyDown,
                txtApellidosInterno.KeyDown,
                txtnombreInterno.KeyDown

            If e.KeyCode = Keys.Enter Then
                listarGrilla()
            End If

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_cant_impr").Index

                        frmVerImpresiones()

                    Case Else

                        If Me.grillaCodigo > 0 Then

                            'If Me.esORL = True Then
                            '    If grillaPenalTipoLicencia <> Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Para ver el detalle de un E.P. de Provincia, debe ir al modulo [Registro Regional]")
                            '        Exit Sub
                            '    End If
                            'End If

                            RaiseEvent _CellDoubleClick_Ver(Me.grillaCodigo)
                        End If
                End Select
            End With

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            RaiseEvent _Grilla_CellEnter()

        End Sub
    End Class
End Namespace

