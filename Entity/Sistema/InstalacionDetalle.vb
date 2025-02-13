Namespace Sistema
    Public Class InstalacionDetalle
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intInstalacionID As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private strPenalCodigo As String = ""
        Private blnLectura As Boolean = False
        Private blnEscritura As Boolean = False
        Private strPenalNombre As String = ""
        Private strRegionNombre As String = ""
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property InstalacionID() As Integer
            Get
                Return intInstalacionID
            End Get
            Set(ByVal value As Integer)
                intInstalacionID = value
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
                Return Legolas.Components.Cadena.ProperCase(strRegionNombre)
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
        Public Property PenalCodigo() As String
            Get
                Return strPenalCodigo
            End Get
            Set(ByVal value As String)
                strPenalCodigo = value
            End Set
        End Property
        Public Property PenalNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strPenalNombre)
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property Lectura() As Boolean
            Get
                Return blnLectura
            End Get
            Set(ByVal value As Boolean)
                blnLectura = value
            End Set
        End Property
        Public Property Escritura() As Boolean
            Get
                Return blnEscritura
            End Get
            Set(ByVal value As Boolean)
                blnEscritura = value
            End Set
        End Property
#End Region
    End Class
#Region "InstalaciondetalleCol"
    Public Class InstalacionDetalleCol
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
        Public Function Add(ByVal obj As InstalacionDetalle) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Instalaciondetalle(ByVal Index As Integer) As InstalacionDetalle
            Get
                Return CType(MyBase.List(Index), InstalacionDetalle)
            End Get
        End Property
        Public Function CloneCol() As InstalacionDetalle
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace