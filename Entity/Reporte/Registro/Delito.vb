Namespace Reporte
    Public Class Delito
#Region "Propiedades"
        Private lngCodigo As Long = -1
        Private strDelitoGenerico As String = ""
        Private strDelitoEspecifico As String = ""
        Public Property Codigo() As Long
            Get
                Return lngCodigo
            End Get
            Set(ByVal value As Long)
                lngCodigo = value
            End Set
        End Property
        Public Property DelitoGenerico() As String
            Get
                Return strDelitoGenerico
            End Get
            Set(ByVal value As String)
                strDelitoGenerico = value
            End Set
        End Property
        Public Property DelitoEspecifico() As String
            Get
                Return strDelitoEspecifico
            End Get
            Set(ByVal value As String)
                strDelitoEspecifico = value
            End Set
        End Property
        Public ReadOnly Property Delito() As String
            Get
                Dim value As String = ""
                value = Me.DelitoEspecifico & " [" & Me.DelitoGenerico & "]"
                Return value
            End Get
        End Property
#End Region
    End Class
#Region "DelitoCol"
    Public Class DelitoCol
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
        Public Function Add(ByVal obj As Delito) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Delito(ByVal Index As Integer) As Delito
            Get
                Return CType(MyBase.List(Index), Delito)
            End Get
        End Property
    End Class
#End Region
End Namespace