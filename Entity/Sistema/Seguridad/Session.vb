Imports Entity.Registro
Namespace Sistema.Seguridad
    Public Class Session
        Public Property Codigo As Integer = -1
        Public Property UsuarioId As Integer = -1
        Public Property Login As String = ""
        Public Property MacPC As String = ""
        Public Property FechaHora As Long = 0
        Public Property SesionActivo As Boolean = False
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1
    End Class

#Region "SessionCol"
    Public Class SessionCol
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
        Public Function Add(ByVal obj As Session) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Session(ByVal Index As Integer) As Session
            Get
                Return CType(MyBase.List(Index), Session)
            End Get
        End Property
    End Class
#End Region

End Namespace
