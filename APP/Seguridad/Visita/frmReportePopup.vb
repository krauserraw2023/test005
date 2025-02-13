Namespace Visita
    Public Class frmReportePopup
#Region "Propiedades_Parametricas"
        Public Property _TipoSancion As Type.Enumeracion.Visita.Sancion = Type.Enumeracion.Visita.Sancion.Ninguno
        Public Property _InternoID As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _VisitanteID As Integer = -1
        Public Property _VisitanteApeNom As String = ""
#End Region
#Region "Propiedades_Defecto"
        Public Property _SelectIDRegion As Short = -1
        Public Property _SelectIDPenal As Short = -1
#End Region
#Region "Propiedades_Busqueda"
        Private ReadOnly Property Tipo() As Integer
            Get

                Dim value As Integer = -1

                If Me.rdbOpcion1.Checked = True Then
                    value = 1
                End If

                If Me.rdbOpcion2.Checked = True Then
                    value = 2
                End If

                If Me.rdbOpcion3.Checked = True Then
                    value = 3
                End If

                'If Me.rdbOpcion4.Checked = True Then
                '    value = 4
                'End If

                Return value

            End Get

        End Property
        Private ReadOnly Property Filtro() As String
            Get

                Dim value As String = ""

                Select Case Me.Tipo
                    Case 1
                        value = Me.rdbOpcion1.Text
                    Case 2
                        value = Me.rdbOpcion2.Text
                    Case 3
                        value = Me.rdbOpcion3.Text
                    Case 4
                        'value = Me.rdbOpcion4.Text
                End Select

                Return value

            End Get
        End Property
        Private Property IDRegion As Short
            Get
                Return Me.UsrRegionPenal1._RegionID
            End Get
            Set(value As Short)
                Me.UsrRegionPenal1._RegionID = value
            End Set
        End Property
        Private Property IDPenal As Short
            Get
                Return Me.UsrRegionPenal1._PenalID
            End Get
            Set(value As Short)
                Me.UsrRegionPenal1._PenalID = value
            End Set
        End Property
        Private Property FechaIni() As Long          
        Private Property FechaFin() As Long        
        Private ReadOnly Property EstadoID() As Integer
            Get
                Dim value As Integer = -1
                Select Case Me.Tipo
                    Case 1 'vigentes
                        value = 1
                End Select
                Return value
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._PenalTodos = False
                ._LoadUsc()
            End With

            If Me._SelectIDPenal > 0 Then
                Me.IDRegion = Me._SelectIDRegion
                Me.IDPenal = Me._SelectIDPenal
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_Reporte()

            'Select Case Me.Tipo
            '    Case 4

            '        Dim frm As New Visita.Visitante.frmReporteHistorialPopup
            '        With frm
            '            ._RegionID = Me.IDRegion
            '            ._PenalID = Me.IDPenal
            '            ._InternoID = Me._InternoID
            '            ._InternoApeNom = Me._InternoApeNom
            '            ._VisitanteID = Me._VisitanteID
            '            ._VisitanteApeNom = Me._VisitanteApeNom

            '            If Me._TipoSancion = Type.Enumeracion.Visita.Sancion.Interno Then
            '                ._TipoReporte = Type.Reporte.Visita.rptHistorialInterno
            '            Else
            '                ._TipoReporte = Type.Reporte.Visita.rptHistorialVisitante
            '            End If

            '            .ShowDialog()
            '        End With

            '    Case Else

            ProcesarFechas()

                    Dim frm As New APPReporte.Visita.frmReporte
                    With frm
                        ._Filtro.RegionID = Me.IDRegion
                        ._Filtro.PenalID = Me.IDPenal

                        If Me._TipoSancion = Type.Enumeracion.Visita.Sancion.Interno Then
                            ._TipoReporte = Type.Reporte.Visita.rptSancionInterno
                        Else
                            ._TipoReporte = Type.Reporte.Visita.rptSancionVisitante
                        End If

                        ._Filtro.FechaInicio = Me.FechaIni
                        ._Filtro.FechaFin = Me.FechaFin
                        ._Filtro.EstadoID = Me.EstadoID
                        ._Filtro.Text = Me.Filtro
                        .Show()
                    End With
            'End Select

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Combo()

            Select Case Me._TipoSancion
                Case Type.Enumeracion.Visita.Sancion.Interno
                    Me.rdbOpcion1.Text = "Registro de Sanciones de Internos - Vigentes"
                    Me.rdbOpcion2.Text = "Registro de Sanciones de Internos - Historicos"
                    Me.rdbOpcion3.Text = "Registro de Sanciones de Internos - Todos"
                    'Me.rdbOpcion4.Text = "Movimiento de Historial de Internos"
                Case Type.Enumeracion.Visita.Sancion.Visitante
                    Me.rdbOpcion1.Text = "Registro de Sanciones de Visita - Vigentes"
                    Me.rdbOpcion2.Text = "Registro de Sanciones de Visita - Historicos"
                    Me.rdbOpcion3.Text = "Registro de Sanciones de Visita - Todos"
                    'Me.rdbOpcion4.Text = "Movimiento de Historial de Visitantes"
            End Select

        End Sub
        Private Sub ProcesarFechas()

            Select Case Me.Tipo
                Case 1 'vigentes
                    Me.FechaIni = Legolas.Configuration.Aplication.FechayHora.FechaLong
                    Me.FechaFin = 0
                Case 2 'historicos
                    Me.FechaIni = 0
                    Me.FechaFin = Legolas.Configuration.Aplication.FechayHora.FechaLong
                Case 3 'todos
                    Me.FechaIni = 0
                    Me.FechaFin = 0
            End Select
        End Sub
#End Region
        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            FRM_Reporte()

        End Sub

        Private Sub frmReportePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub
    End Class
End Namespace