Namespace Registro.Carceleta.Clasificacion
    Public Class CategoriaFicha_BE
        Public Property Codigo() As Integer = -1
        Public Property FichaId() As Integer = -1
        Public Property CategoriaClasificacionId() As Integer = -1
        Public Property CategoriaNombre() As String = ""
        Public Property ValorMinimo() As Integer = -1
        Public Property ValorMaximo() As Integer = -1
    End Class
    Public Class CategoriaFichaCol_BE
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
        Public Function Add(ByVal obj As CategoriaFicha_BE) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property CategoriaFicha(ByVal Index As Integer) As CategoriaFicha_BE
            Get
                Return CType(MyBase.List(Index), CategoriaFicha_BE)
            End Get
        End Property
    End Class
End Namespace