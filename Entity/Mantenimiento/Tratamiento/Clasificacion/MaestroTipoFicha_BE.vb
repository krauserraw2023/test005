Namespace Registro.Carceleta.Clasificacion
    Public Class MaestroTipoFicha_BE
        Public Property Codigo As Integer = -1
        Public Property TipoFichaNombre As String = ""
        Public Property NumOrden() As Integer = -1
    End Class
#Region "TipoCol"
    Public Class MaestroTipoFichaCol_BE
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
        Public Function Add(ByVal obj As MaestroTipoFicha_BE) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Tipo(ByVal Index As Integer) As MaestroTipoFicha_BE
            Get
                Return CType(MyBase.List(Index), MaestroTipoFicha_BE)
            End Get
        End Property
    End Class
#End Region
End Namespace
