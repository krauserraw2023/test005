Namespace Visita
    Public Class uscVisitaMovimientoDetalle
        Private intVisitanteId As Integer
        Private intRegionId As Integer = -1
        Private intPenalId As Integer = -1
        Private lngFecha As Long = 0


        Public Property RegionId() As Integer
            Get
                Return intRegionId
            End Get
            Set(ByVal value As Integer)
                intRegionId = value
            End Set
        End Property

        Public Property PenalId() As Integer
            Get
                Return intPenalId
            End Get
            Set(ByVal value As Integer)
                intPenalId = value
            End Set
        End Property


        Public Property FechaIngreso() As Long
            Get
                Return lngFecha
            End Get
            Set(ByVal value As Long)
                lngFecha = value
            End Set
        End Property

        Public Property FechaSalida() As Long
            Get
                Return lngFecha
            End Get
            Set(ByVal value As Long)
                lngFecha = value
            End Set
        End Property


        Public Property VisitanteId() As Integer
            Get
                Return intVisitanteId
            End Get
            Set(ByVal value As Integer)
                intVisitanteId = value
            End Set
        End Property

        Private Sub Listar()
            'If VisitanteId > 0 Then
            '    Dim obj As New Bussines.Visita.MovimientoAncon
            '    Dim ocol As Entity.Visita.MovimientoCol

            '    ocol = obj.ListarMovimientoDetalle(-1, VisitanteId, -1, FechaIngreso, FechaSalida, -1, RegionId, PenalId, -1)
            '    Me.dgwMovi.AutoGenerateColumns = False
            '    Me.dgwMovi.DataSource = ocol

            'End If
        End Sub




        Public Sub LoadParameter()
            If FechaIngreso = 0 Then
                FechaIngreso = Now.AddDays(-30).ToFileTime
            End If
            If FechaSalida = 0 Then
                FechaSalida = Now.ToFileTime
            End If
            Listar()

        End Sub





    End Class
End Namespace