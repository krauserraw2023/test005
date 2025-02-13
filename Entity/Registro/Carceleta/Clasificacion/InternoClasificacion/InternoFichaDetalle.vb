Namespace Clasificacion.InternoClasificacion
    Public Class InternoFichaDetalle
        Public Property Codigo() As Integer = -1
        Public Property InternoFichaId() As Integer = -1
        Public Property VariableId() As Integer = -1
        Public Property IndicadorId() As Integer = -1
        Public Property Ponderacion() As Integer = 0
        Public Property PonderacionNoPrevista() As Integer = 0
        Public Property Estado() As Integer = -1
        Public Property RegionId() As Integer = -1
        Public Property PenalId() As Integer = -1
    End Class
    Public Class InternoFichaDetalleCol
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
        Public Function Add(ByVal obj As InternoFichaDetalle) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoFichaDetalle(ByVal Index As Integer) As InternoFichaDetalle
            Get
                Return CType(MyBase.List(Index), InternoFichaDetalle)
            End Get
        End Property
    End Class
End Namespace