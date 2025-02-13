Namespace Mantenimiento.General

    Public Class RegimenPenitenciario
        Public Property Codigo() As Integer = -1
        Public Property Regimen() As String = ""
    End Class

#Region "RegimenPenitenciarioCol"
    Public Class RegimenPenitenciarioCol
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
        Public Function Add(ByVal value As RegimenPenitenciario) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As RegimenPenitenciario) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As RegimenPenitenciario) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As RegimenPenitenciario)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As RegimenPenitenciario
            Get
                Return DirectCast(List(index), RegimenPenitenciario)
            End Get
            Set(ByVal value As RegimenPenitenciario)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As RegimenPenitenciario)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As RegimenPenitenciario
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace

