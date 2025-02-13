Namespace Biometria
    Public Class HuellaDigital
        Inherits Auditoria.Transaccion

        Public Property Codigo() As Integer = -1
        Public Property IDTemplateHuella As Integer = -1
        Public Property CalidadTemplateHuella As Short = -1
        Public Property IDRegion() As Short = -1
        Public Property IDPenal() As Short = -1

    End Class

    Public Class HuellaDigitalCol
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
        Public Function Add(ByVal obj As HuellaDigital) As Integer
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
        Public ReadOnly Property Item(ByVal Index As Integer) As HuellaDigital
            Get
                Try
                    Return CType(MyBase.List(Index), HuellaDigital)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property HuellaDigital(ByVal Index As Integer) As HuellaDigital
            Get
                Try
                    Return CType(MyBase.List(Index), HuellaDigital)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
    End Class

End Namespace