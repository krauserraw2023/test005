Namespace Reporte.CertificadoLibertad
    Public Class Restriccion
#Region "Propiedades"
        Private intItem As Integer = 0
        Private strDescripcion As String = ""
        Public Property Item() As Integer
            Get
                Return intItem
            End Get
            Set(ByVal value As Integer)
                intItem = value
            End Set
        End Property
        Public Property Descripcion() As String
            Get
                Return strDescripcion
            End Get
            Set(ByVal value As String)
                strDescripcion = value
            End Set
        End Property
#End Region
    End Class
#Region "RestriccionCol"
    Public Class RestriccionCol
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
        Public Function Add(ByVal obj As Restriccion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Restriccion(ByVal Index As Integer) As Restriccion
            Get
                Return CType(MyBase.List(Index), Restriccion)
            End Get
        End Property
        Public Sub RemoveID(ByVal Codigo As Integer)

            Try
                If Codigo < 1 Then
                    Exit Sub
                End If

                Dim obj As Restriccion = Nothing

                For Each objRun As Restriccion In Me.List
                    If Codigo = objRun.Item Then
                        obj = objRun
                        Me.List.Remove(obj)
                    End If
                Next

            Catch ex As Exception
             
            End Try


        End Sub
    End Class
#End Region
End Namespace