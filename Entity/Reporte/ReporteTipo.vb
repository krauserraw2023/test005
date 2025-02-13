Namespace Reporte
    Public Class ReporteTipo
        Public Property Codigo As Integer = -1
        Public Property NombreTipo As String = ""
    End Class
    Public Class ReporteTipoCol
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
        Public Function Add(ByVal obj As ReporteTipo) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property ReporteTipo(ByVal Index As Integer) As ReporteTipo
            Get
                Return CType(MyBase.List(Index), ReporteTipo)
            End Get
        End Property
    End Class
End Namespace