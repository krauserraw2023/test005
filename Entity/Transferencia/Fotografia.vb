Namespace Transferencia
    Public Class Fotografia
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private lngCodigo As Long = 0
        Private intRegionID As Integer = -1
        Private strRegionNombre As String = ""
        Private intPenalID As Integer = -1
        Private strPenalNombre As String = ""
        Private intCantidadRegistro As Integer = -1
        Private intCantFotosExistentes As Integer = -1
        Private intCantFotosFaltantes As Integer = -1
        Private intCantFotosDanadas As Integer = -1
        Private lngFechayHora As Long = 0
        Public Property Codigo() As Long
            Get
                Return lngCodigo
            End Get
            Set(ByVal value As Long)
                lngCodigo = value
            End Set
        End Property
        Public Property RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property RegionNombre() As String
            Get
                Return strRegionNombre
            End Get
            Set(ByVal value As String)
                strRegionNombre = value
            End Set
        End Property
        Public Property PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property CantidadRegistro() As Integer
            Get
                Return intCantidadRegistro
            End Get
            Set(ByVal value As Integer)
                intCantidadRegistro = value
            End Set
        End Property
        Public Property CantFotosExistentes() As Integer
            Get
                Return intCantFotosExistentes
            End Get
            Set(ByVal value As Integer)
                intCantFotosExistentes = value
            End Set
        End Property
        Public Property CantFotosFaltantes() As Integer
            Get
                Return intCantFotosFaltantes
            End Get
            Set(ByVal value As Integer)
                intCantFotosFaltantes = value
            End Set
        End Property
        Public Property CantFotosDanadas() As Integer
            Get
                Return intCantFotosDanadas
            End Get
            Set(ByVal value As Integer)
                intCantFotosDanadas = value
            End Set
        End Property
        Public Property FechayHora() As Long
            Get
                Return lngFechayHora
            End Get
            Set(ByVal value As Long)
                lngFechayHora = value
            End Set
        End Property
#End Region        
    End Class
#Region "FotografiaCol"
    Public Class FotografiaCol
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
        Public Function Add(ByVal obj As Fotografia) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Fotografia(ByVal Index As Integer) As Fotografia
            Get
                Return CType(MyBase.List(Index), Fotografia)
            End Get
        End Property
        Public Function CloneCol() As Fotografia
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace