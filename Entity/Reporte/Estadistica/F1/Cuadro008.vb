Namespace Reporte.Estadistica.F1
    Public Class Cuadro008
#Region "Propiedades"
        Private strTiempoSentencia As String = ""
        Private intSetenciadoHom As Integer = 0
        Private intSetenciadoMuj As Integer = 0
        Public Property TiempoSentencia() As String
            Get
                Return strTiempoSentencia
            End Get
            Set(ByVal value As String)
                strTiempoSentencia = value
            End Set
        End Property
        Public Property SetenciadoHom() As Integer
            Get
                Return intSetenciadoHom
            End Get
            Set(ByVal value As Integer)
                intSetenciadoHom = value
            End Set
        End Property
        Public Property SetenciadoMuj() As Integer
            Get
                Return intSetenciadoMuj
            End Get
            Set(ByVal value As Integer)
                intSetenciadoMuj = value
            End Set
        End Property
        Public ReadOnly Property Total() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Me.SetenciadoHom + Me.SetenciadoMuj
                Return intValue
            End Get
        End Property
#End Region
    End Class
#Region "Cuadro008Col"
    Public Class Cuadro008Col
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
        Public Function Add(ByVal obj As Cuadro008) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Cuadro008(ByVal Index As Integer) As Cuadro008
            Get
                Return CType(MyBase.List(Index), Cuadro008)
            End Get
        End Property
    End Class
#End Region
End Namespace

