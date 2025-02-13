Namespace Biometria
    Public Class InternoHuella
        Public Property Codigo() As Integer = -1

        Public Property InternoId() As Integer = -1

        Public Property HuellaDigMenIzqId As Integer = -1 'huella digital Id para el dedo meñique izquierdo
        Public Property HuellaDigAnuIzqId As Integer = -1 'anular
        Public Property HuellaDigMedIzqId As Integer = -1 'medio
        Public Property HuellaDigIndIzqId As Integer = -1 'indice
        Public Property HuellaDigPulIzqId As Integer = -1 'pulgar

        Public Property HuellaDigMenDerId As Integer = -1 'huella digital Id para el dedo meñique derecho
        Public Property HuellaDigAnuDerId As Integer = -1 'anular
        Public Property HuellaDigMedDerId As Integer = -1 'medio
        Public Property HuellaDigIndDerId As Integer = -1 'indice
        Public Property HuellaDigPulDerId As Integer = -1 'pulgar

        Public Property RegionId() As Integer = -1
        Public Property PenalId() As Integer = -1
    End Class

    Public Class InternoHuellaCol
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
        Public Function Add(ByVal obj As InternoHuella) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public Function Delete(Index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(Index)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Function Remove(index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(index)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
        Public ReadOnly Property Item(ByVal Index As Integer) As InternoHuella
            Get
                Try
                    Return CType(MyBase.List(Index), InternoHuella)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property InternoHuella(ByVal Index As Integer) As InternoHuella
            Get
                Try
                    Return CType(MyBase.List(Index), InternoHuella)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
    End Class

End Namespace