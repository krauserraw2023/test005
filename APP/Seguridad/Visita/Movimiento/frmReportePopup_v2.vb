Namespace Visita.Movimiento
    Public Class frmReportePopup_v2
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_x_Defecto"
        Public Property _IDRegion As Integer = -1
        Public Property _IDPenal As Integer = -1
        Public Property _FechaInicio As Long = 0
        Public Property _FechaFin As Long = 0

        Public Property _IDVisitanteSelect As Integer = -1
        Public Property _IDInternoSelect As Integer = -1
        Public Property _VisitanteApeNombres As String = ""
        Public Property _InternoApeNombres As String = ""
#End Region
#Region "Propiedades"
        Private Property IDRegion() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.cbbRegion.Text
            End Get
        End Property
        Private Property IDPenal() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.cbbPenal.Text.Trim
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

        Private Property IDVisitante As Integer = -1
        Private Property IDInterno As Integer = -1
        Private Property VisitanteApeNom As String
            Get
                Return Me.uscBusquedaVisitante._Value
            End Get
            Set(ByVal value As String)
                Me.uscBusquedaVisitante._Value = value.ToUpper
            End Set
        End Property
        Private Property InternoApeNom As String
            Get
                Return Me.uscBusquedaInterno._Value
            End Get
            Set(ByVal value As String)
                Me.uscBusquedaInterno._Value = value.ToUpper
            End Set
        End Property
        Private ReadOnly Property IDRegimenPenal As Short
            Get
                Dim value As Short = 1

                Dim objBss As New Bussines.Visita.Config
                Dim objEntfiltro As New Entity.Visita.Config

                With objEntfiltro
                    .RegionID = Me.IDRegion
                    .PenalID = Me.IDPenal
                End With

                Try
                    value = objBss.ListarConfigActual(objEntfiltro).RegimenTipoID
                Catch ex As Exception

                End Try

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Sicrico"
        Private Property TipoBanda() As Short
            Get
                Return Me.cbbBandaTipo.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbBandaTipo.SelectedValue = value
            End Set
        End Property
        Private Property BandaID() As Integer = -1
        Private Property BandaNombre() As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(value As String)
                If Trim(value) = "" Then
                    Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
                Else
                    Me.UscLabelBusqueda1._Value = value
                End If
            End Set
        End Property
        Private Property TipoIntegrante() As Short
            Get
                Return Me.cbbTipoIntegranteBan.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbTipoIntegranteBan.SelectedValue = value
            End Set
        End Property

#End Region

#Region "Combo"
        Private Sub ComboRegion()

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPenal()

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.IDRegion
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Private Sub CargarComboTipoBanda()
            With Me.cbbBandaTipo
                ._Todos = True
                .LoadUsc()
            End With
        End Sub
        Private Sub CargarComboTipoIntegranteBanda()
            With Me.cbbTipoIntegranteBan
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub ListarReporte()

            Dim strReporte As String = "23,38,39,40,41"

            Dim objEntFiltro As New Legolas.LEntity.Globall.Reporte
            Dim objEntCol As New Legolas.LEntity.Globall.ReporteCol

            Dim objBss As New Legolas.LBusiness.Globall.Reporte

            With objEntFiltro
                .CodigoMultiple = strReporte
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor

                .DataSource = objEntCol
            End With

        End Sub
        Private Sub HabilitarControlesReporte()

            Dim blnVisibleSicrico As Boolean = False
            Dim blnVisibleInternoVisitante As Boolean = False
            Dim blnVisibleInterno As Boolean = False
            Dim blnVisibleVisitante As Boolean = False

            Select Case Me.GrillaCodigo


                Case Type.Reporte.Visita.rpt_siscrico_visita

                    blnVisibleSicrico = True

                Case Type.Reporte.Visita.rpt_visita_visitante_historial

                    Me.lblTitulo.Text = "Visitante: "
                    blnVisibleVisitante = True
                    blnVisibleInternoVisitante = True

                Case Type.Reporte.Visita.rpt_visita_interno_historial

                    Me.lblTitulo.Text = "Interno: "
                    blnVisibleInterno = True
                    blnVisibleInternoVisitante = True

                Case Type.Reporte.Visita.rpt_visita_movimientos_x_fechas

                Case Type.Reporte.Visita.rpt_visita_resumen_movimientos_x_fechas


            End Select


            Me.grbSicrico.Visible = blnVisibleSicrico
            Me.grbInternoVisitante.Visible = blnVisibleInternoVisitante
            Me.uscBusquedaVisitante.Visible = blnVisibleVisitante
            Me.uscBusquedaInterno.Visible = blnVisibleInterno

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'validar
            Select Case Me.GrillaCodigo


                Case Type.Reporte.Visita.rpt_siscrico_visita


                Case Type.Reporte.Visita.rpt_visita_visitante_historial

                    If Me.IDVisitante < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "Seleccione el visitante")
                        Return value
                    End If

                Case Type.Reporte.Visita.rpt_visita_interno_historial

                    If Me.IDInterno < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "Seleccione el interno")
                        Return value
                    End If

                Case Type.Reporte.Visita.rpt_visita_movimientos_x_fechas


                Case Type.Reporte.Visita.rpt_visita_resumen_movimientos_x_fechas

            End Select

            'fecha inicio
            If Me.FechaInicio < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese una fecha inicio")
                Me.dtpFechaInicio.Focus()
                Return value
            End If

            'fecha fin 
            If Me.FechaFin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese una fecha fin")
                Me.dtpFechaFin.Focus()
                Return value
            End If

            'fecha fin 
            If Me.FechaFin < Me.FechaInicio Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La fecha fin no puede ser menor a la fecha de inicio")
                Me.dtpFechaFin.Focus()
                Return value
            End If

            value = True
            Return value

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            FRM_Reporte()

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_Reporte()

            Dim frm As New APPReporte.Visita.ReporteCrystal
            With frm
                'filtro primer nivel
                ._Filtro.Text = Me.Text
                ._Filtro.RegionID = Me.IDRegion
                ._Filtro.PenalID = Me.IDPenal
                'filtros segundo nivel
                ._Filtro.BandaTipoID = Me.TipoBanda
                ._Filtro.BandaID = Me.BandaID
                ._Filtro.BandaMiembroTipoID = Me.TipoIntegrante
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                ._Filtro.InternoID = Me.IDInterno
                ._Filtro.VisitanteID = Me.IDVisitante
                ._Filtro.IDRegimenPenal = Me.IDRegimenPenal
                ._TipoReporte = Me.GrillaCodigo
                .ShowDialog()
            End With

        End Sub

        Private Sub FRM_Banda()

            Dim frm As New Registro.Siscrico.frmBusquedaBanda
            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.BandaID = ._BandaIdSel
                    Me.BandaNombre = ._BandaNomSel()
                    Me.TipoBanda = ._BandaTipoIDSelect
                End If
            End With

        End Sub
        Private Sub FRM_BuscarVisitante()

            Dim frm As New Visita.Visitante.frmBuscarPopup
            With frm
                ._RegionID = Me.IDRegion
                ._PenalID = Me.IDPenal

                If .ShowDialog() = DialogResult.OK Then
                    Me.IDVisitante = ._GrillaVisitanteID
                    Me.VisitanteApeNom = ._GrillaVisitanteApellidosyNombres
                End If
            End With
        End Sub
        Private Sub FRM_BuscarInterno()

            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me.IDRegion
                ._PenalID = Me.IDPenal
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong
                ._VisibleRegionPenal = False
                ._visibleBotones(False)
                If .ShowDialog() = DialogResult.OK Then
                    Me.IDInterno = ._GrillaInternoID
                    Me.InternoApeNom = ._GrillaApellidosyNombres
                End If
            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarPropiedades_x_Defecto()

            If Me._IDRegion > 0 Then
                Me.IDRegion = Me._IDRegion
            End If

            If Me._IDPenal > 0 Then
                Me.IDPenal = Me._IDPenal
            End If

            If Me._FechaInicio > 0 Then
                Me.FechaInicio = Me._FechaInicio
            End If

            If Me._FechaFin > 0 Then
                Me.FechaFin = Me._FechaFin
            End If

            If Me._IDVisitanteSelect > 0 Then
                Me.IDVisitante = Me._IDVisitanteSelect
                Me.VisitanteApeNom = Me._VisitanteApeNombres
            End If

            If Me._IDInternoSelect > 0 Then
                Me.IDInterno = Me._IDInternoSelect
                Me.InternoApeNom = Me._InternoApeNombres
            End If

        End Sub

        Private Sub ValoresxDefault()

            ComboRegion()
            ComboPenal()
            CargarComboTipoBanda()
            CargarComboTipoIntegranteBanda()

            HabilitarPropiedades_x_Defecto()

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOK()

        End Sub

        Private Sub frmReporteHistorialPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmReportePopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarReporte()
            HabilitarControlesReporte()

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            HabilitarControlesReporte()

        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            ComboPenal()

        End Sub

        Private Sub UscLabelBusqueda1__Click_Buscar() Handles UscLabelBusqueda1._Click_Buscar

            FRM_Banda()

        End Sub

        Private Sub UscLabelBusqueda2__Click_Buscar() Handles uscBusquedaInterno._Click_Buscar

            FRM_BuscarInterno()

        End Sub


        Private Sub uscBusquedaVisitante__Click_Buscar() Handles uscBusquedaVisitante._Click_Buscar

            FRM_BuscarVisitante()

        End Sub

        Private Sub uscBusquedaVisitante_Load(sender As System.Object, e As System.EventArgs) Handles uscBusquedaVisitante.Load

        End Sub
    End Class
End Namespace