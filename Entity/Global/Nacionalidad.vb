Namespace General
    Public Class Nacionalidad
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private strCodigoString As String = ""
        Private strPaisNombre As String = ""
        Private strNombre As String = ""
        Private intOrden As Integer = -1
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property CodigoString() As String
            Get
                Return strCodigoString
            End Get
            Set(ByVal value As String)
                strCodigoString = value
            End Set
        End Property
        Public Property PaisNombre() As String
            Get
                Return strPaisNombre
            End Get
            Set(ByVal value As String)
                strPaisNombre = value
            End Set
        End Property
        Public Property Nombre() As String
            Get
                Return strNombre
            End Get
            Set(ByVal value As String)
                strNombre = value
            End Set
        End Property
        Public Property Orden() As Integer
            Get
                Return intOrden
            End Get
            Set(ByVal value As Integer)
                intOrden = value
            End Set
        End Property
#End Region

    End Class
#Region "NacionalidadCol"
    Public Class NacionalidadCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, SortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As Nacionalidad) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Nacionalidad(ByVal Index As Integer) As Nacionalidad
            Get
                Return CType(MyBase.List(Index), Nacionalidad)
            End Get
        End Property
        Public Function CloneCol() As Nacionalidad
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace