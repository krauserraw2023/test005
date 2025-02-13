Public Class EntityCol(Of t)
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

    Public Function Add(ByVal obj As t) As Integer
        Return MyBase.List.Add(obj)
    End Function

    Public Function Contains(ByVal value As t) As Boolean
        Return List.Contains(value)
    End Function

    Public Function IndexOf(ByVal value As t) As Integer
        Return List.IndexOf(value)
    End Function

    ''' <summary>
    ''' Retorna el elemento (Entity) de la lista.
    ''' </summary>
    ''' <param name="Index">Indice de la posición del elemento dentro de la lista.</param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Item(ByVal Index As Integer) As t
        Get
            Return CType(MyBase.List(Index), t)
        End Get
    End Property

    Public ReadOnly Property Entity(ByVal Index As Integer) As t
        Get
            Return Item(Index)
        End Get
    End Property

    ''' <summary>
    ''' Eliminar un elemento de la lista por objeto.
    ''' </summary>
    ''' <param name="entity">Entity a eliminar</param>
    ''' <remarks></remarks>
    Public Sub Remove(ByVal entity As t)
        List.Remove(entity)
    End Sub

    Public Function Delete(Index As Integer) As Boolean
        Try
            MyBase.List.RemoveAt(Index)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Elimina un elemento por la posición dentro de la lista.
    ''' </summary>
    ''' <param name="index">Posición dentro de la lista.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Remove(index As Integer) As Boolean
        Return Delete(index)
    End Function

    'Public Function Eliminar(index As Integer) As Boolean
    '    Return Delete(index)
    'End Function

    Public Function ClonarLista() As t
        Return MyBase.MemberwiseClone
    End Function
End Class





