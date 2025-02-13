Namespace Registro
    Public Class InternoIdioma
        Public Property SedeRowId As Integer = -1
        Public Property Codigo As Integer = -1
        Public Property IdiomaId As Integer = -1
        Public Property IngresoId As Integer = -1
        'Public Property SedeInternoId As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property InternoId As Integer = -1
        Public Property NivelDominioId As Integer = -1
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1

        '-------------- auxiliares -------------
        Public Property NumIngreso As Integer = 0
        Public Property IdiomaStr As String = ""
        Public Property NivelDominioStr As String = ""
        Public Property IngresoNroInpe As String = ""
    End Class
#Region "InternoIdiomaCol"
    Public Class InternoIdiomaCol
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

        Public Function Add(ByVal obj As InternoIdioma) As Integer
            Return MyBase.List.Add(obj)
        End Function

        Public ReadOnly Property InternoIdioma(ByVal Index As Integer) As InternoIdioma
            Get
                Return CType(MyBase.List(Index), InternoIdioma)
            End Get
        End Property

        Public Sub Eliminar(ByVal Index As Integer)
            List.RemoveAt(Index)
        End Sub
    End Class
#End Region
End Namespace