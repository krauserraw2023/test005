Namespace Visita
    Public Class uscMovimientosVisitas
        Private objBss As Bussines.Visita.Movimiento = Nothing
        Private objEntcol As Entity.Visita.MovimientoCol = Nothing
#Region "Enum"
        Public Enum enmTipo
            Ninguno = 0
            Visitante = 1
            Interno = 2
            InternoPJ = 3
        End Enum
#End Region
#Region "Propiedades_Usc"
        Public Property _VisiblePanelFiltroAnio() As Boolean
            Get
                Return Me.pnlFiltroAnio.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.pnlFiltroAnio.Visible = value
            End Set
        End Property
        Public Property _VisiblePanelFiltro() As Boolean
            Get
                Return Me.pnlBusqueda.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.pnlBusqueda.Visible = value
            End Set
        End Property
        Public Property _VisiblePanelCount() As Boolean
            Get
                Return Me.pnlCountRegistros.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.pnlCountRegistros.Visible = value
            End Set
        End Property
        Public Property _VisibleCountVisitante() As Boolean
            Get
                Return Me.lblRegVisitantes.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.lblRegVisitantes.Visible = value
            End Set
        End Property
        Public Property _VisibleCountInterno() As Boolean
            Get
                Return Me.lblRegInternos.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.lblRegInternos.Visible = value
            End Set
        End Property
#End Region
#Region "Propiedades_Buscar"
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _VisitanteID() As Integer=-1
        Public Property _IDInternoPJ As Integer = -1

        Private Property FechaIngreso() As Long
            Get
                Return dtpDesde.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpDesde.ValueLong = value
            End Set
        End Property
        Private Property FechaSalida() As Long
            Get
                Return dtpHasta.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpHasta.ValueLong = value
            End Set
        End Property
        Private Property Anio() As Integer
            Get
                Return Me.cbbAnio.Value
            End Get
            Set(value As Integer)
                Me.cbbAnio.Value = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Public Sub CountRegistros(ByVal Count As Integer)
            Me.lblRegistros.Text = Count & ". Reg."
        End Sub
        Public Sub CountRegistrosInternos(blnEsInternoPJ As Boolean)

            Dim blnExiste As Boolean = False
            Dim strArralist As New ArrayList
            Dim intCodigo As Integer = 0

            For Each obj As Entity.Visita.Movimiento In objEntcol

                If blnEsInternoPJ = False Then
                    intCodigo = obj.InternoID
                Else
                    intCodigo = obj.IDInternoPJ
                End If

                If intCodigo > 0 Then

                    For Each Codigo As Integer In strArralist
                        If Codigo = intCodigo Then
                            blnExiste = True
                            Exit For
                        Else
                            blnExiste = False
                        End If
                    Next

                    If blnExiste = False Then
                        strArralist.Add(intCodigo)
                        blnExiste = True
                    End If

                End If

            Next

            Me.lblRegInternos.Text = strArralist.Count & " Internos"

        End Sub
        Public Sub CountRegistrosVisitantes()

            Dim blnExiste As Boolean = False
            Dim strArralist As New ArrayList
            Dim intCodigo As Integer = 0

            For Each obj As Entity.Visita.Movimiento In objEntcol

                intCodigo = obj.VisitaID

                If intCodigo > 0 Then

                    For Each Codigo As Integer In strArralist
                        If Codigo = intCodigo Then
                            blnExiste = True
                            Exit For
                        Else
                            blnExiste = False
                        End If
                    Next

                    If blnExiste = False Then
                        strArralist.Add(intCodigo)
                        blnExiste = True
                    End If

                End If

            Next

            Me.lblRegVisitantes.Text = strArralist.Count & " Visitantes"
        End Sub
#End Region
#Region "Otros"
        Private objTipoBusqueda As enmTipo = enmTipo.Ninguno
        Public Property _TipoBusqueda() As enmTipo
            Get
                Return objTipoBusqueda
            End Get
            Set(ByVal value As enmTipo)
                objTipoBusqueda = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private blnComboCargoAnio As Boolean = False
        Private Sub ComboAnio()

            With Me.cbbAnio
                .AnioInicio = 2010
                .AnioFin = Now.Year
                .LoadUsc()
                .Value = .AnioFin
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarFechas()

            If blnComboCargoAnio = True Then

                Dim dteFechaAnio As Date = Legolas.Components.FechaHora.FechaDateConcatenar(Me.Anio, 1, 1)
                Dim lngFecha As Long = Legolas.Components.FechaHora.FechaLong(dteFechaAnio)

                Me.FechaIngreso = Legolas.Components.FechaHora.FechaPrimerDiaAnio(lngFecha)
                Me.FechaSalida = Legolas.Components.FechaHora.FechaUltimoDiaAnio(lngFecha)
                'Me.Refresh()
                Listar()

            End If

        End Sub
        Private Sub Listar()

            Me.col_int_ape_nom.Visible = False
            Me.col_vis_ape_nom.Visible = False

            Select Case Me._TipoBusqueda
                Case enmTipo.Visitante

                    Me._InternoID = -1
                    Me._IDInternoPJ = -1

                    Me.col_int_ape_nom.Visible = True

                    If Me._VisitanteID < 1 Then
                        Exit Sub
                    End If

                Case enmTipo.Interno

                    Me._VisitanteID = -1
                    Me._IDInternoPJ = -1

                    Me.col_vis_ape_nom.Visible = True

                    If Me._InternoID < 1 Then
                        Exit Sub
                    End If

                Case enmTipo.InternoPJ

                    Me._VisitanteID = -1
                    Me._InternoID = -1

                    Me.col_vis_ape_nom.Visible = True


                    If Me._IDInternoPJ < 1 Then
                        Exit Sub
                    End If

                Case Else

                    Me._InternoID = 0
                    Me._VisitanteID = 0
            End Select

            objBss = New Bussines.Visita.Movimiento
            objEntcol = New Entity.Visita.MovimientoCol

            objEntcol = objBss.ListarMovimiento(Me._InternoID, Me._IDInternoPJ, Me._VisitanteID, Me.FechaIngreso, Me.FechaSalida, _
                                                Me._RegionID, Me._PenalID)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AutoGenerateColumns = False
                .DataSource = objEntcol
            End With

            Dim blnEsInternoPJ As Boolean = False
            If Me._IDInternoPJ > 0 Then
                blnEsInternoPJ = True
            End If

            CountRegistros(Me.dgwGrilla.RowCount)
            CountRegistrosInternos(blnEsInternoPJ)
            CountRegistrosVisitantes()

        End Sub
#End Region
#Region "Otros"
        Public Sub _LoadUsc()

            ValoresxDefault()

        End Sub
        Public Sub ValoresxDefault()

            ComboAnio()

            Dim lngFecha As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong

            Me.FechaIngreso = Legolas.Components.FechaHora.FechaPrimerDiaAnio(lngFecha)
            Me.FechaSalida = lngFecha
            'Listar()

            blnComboCargoAnio = True

        End Sub
#End Region

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

            Listar()

        End Sub

        Private Sub dgwMovi_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick


            Try
                With Me.dgwGrilla
                    If e.RowIndex = -1 Then

                        Me.Cursor = Cursors.WaitCursor
                        objEntcol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                        Me.Cursor = Cursors.Default

                        .Refresh()

                    End If
                End With

            Catch ex As Exception

            End Try


        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_sal").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                            'e.Value = DateTime.FromFileTime(e.Value).ToShortDateString
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub cbbAnio__SelectedIndexChanged() Handles cbbAnio._SelectedIndexChanged

            ListarFechas()

        End Sub

        Private Sub cbbAnio_Load(sender As System.Object, e As System.EventArgs) Handles cbbAnio.Load

        End Sub
    End Class
End Namespace