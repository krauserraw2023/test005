Namespace Clasificacion.Documento
    'tra_asi_mov_documento
    Public Class DocClasificacion
        Public Property Codigo As Integer = -1
        Public Property AnioDoc As Integer = 0
        Public Property CorrelativoDoc As Integer = 0
        Public Property NumeroDoc As String = ""
        Public Property NombreDestinoDoc As String = "" 'cargo y/o nombre a donde va el documento
        Public Property Observacion As String = ""
        Public Property EstadoDocId As Integer = -1
        Public Property EstadoDocString As String = ""
        Public Property FechaEmision As Long = 0
        Public ReadOnly Property FechaEmisionString As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaEmision)
            End Get
        End Property
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1
        Public Property GlosaDocId As Integer = -1
        'auxiliares
        Public Property PenalNombre As String = ""
        Public Property RegionNombre As String = ""
        Public Property FechaEmisionDesde As Long = 0
        Public Property FechaEmisionHasta As Long = 0
    End Class

    Public Class DocClasificacionCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, sortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As DocClasificacion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DocClasificacion(ByVal Index As Integer) As DocClasificacion
            Get
                Return CType(MyBase.List(Index), DocClasificacion)
            End Get
        End Property
    End Class
End Namespace