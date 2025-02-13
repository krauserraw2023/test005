Namespace Seguridad.Penal
    Public Class Region
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intUsuarioID As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private strRegionNombre As String = ""
        Private strPenalNombre As String = ""
        Private strUsuarioLogin As String = ""
        Private strUsuarioApePat As String = ""
        Private strUsuarioApeMat As String = ""
        Private strUsuarioNom As String = ""
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property UsuarioID() As Integer
            Get
                Return intUsuarioID
            End Get
            Set(ByVal value As Integer)
                intUsuarioID = value
            End Set
        End Property
        Public Property UsuarioLogin() As String
            Get
                Return strUsuarioLogin
            End Get
            Set(ByVal value As String)
                strUsuarioLogin = value
            End Set
        End Property
        Public Property UsuarioApePat() As String
            Get
                Return strUsuarioApePat
            End Get
            Set(ByVal value As String)
                strUsuarioApePat = value
            End Set
        End Property
        Public Property UsuarioApeMat() As String
            Get
                Return strUsuarioApeMat
            End Get
            Set(ByVal value As String)
                strUsuarioApeMat = value
            End Set
        End Property
        Public Property UsuarioNom() As String
            Get
                Return strUsuarioNom
            End Get
            Set(ByVal value As String)
                strUsuarioNom = value
            End Set
        End Property
        Public ReadOnly Property UsuarioApe() As String
            Get
                Dim strValue As String = ""
                strValue = Me.UsuarioApePat & " " & Me.UsuarioApeMat

                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
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
        Public Property PenalNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strPenalNombre)
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
#End Region
    End Class
#Region "RegionCol"
    Public Class RegionCol
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
        Public Function Add(ByVal obj As Region) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Region(ByVal Index As Integer) As Region
            Get
                Return CType(MyBase.List(Index), Region)
            End Get
        End Property
        Public Function CloneCol() As Region
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace