Namespace Reporte.Visita
    Public Class Filtro
        Public Property InternoID As Integer = -1
        Public Property VisitanteID As Integer = -1
        Public Property FechaInicio As Long = 0
        Public Property FechaFin As Long = 0
        Public Property RegionID As Integer = -1
        Public Property PenalID As Integer = -1
        Public Property PabellonID As Integer = -1
        Public Property EstadoID As Integer = -1
        Public Property Text As String = ""
        Public Property IDRegimenPenal As Short = -1
        Public Property IDMovimiento As Long = -1
        Public ReadOnly Property FechaFiltroText() As String
            Get
                Dim value As String = ""

                Dim strFechaIni As String = Legolas.Components.FechaHora.FechaString(Me.FechaInicio)
                Dim strFechaFin As String = Legolas.Components.FechaHora.FechaString(Me.FechaFin)

                value = "Del " & strFechaIni & " al " & strFechaFin

                Return value.ToUpper

            End Get
        End Property
        '/*siscrico*/
        Public Property BandaTipoID As Short = -1
        Public Property BandaID As Integer = -1
        Public Property BandaMiembroTipoID As Short = -1
    End Class
End Namespace