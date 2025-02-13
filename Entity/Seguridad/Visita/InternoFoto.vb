Namespace Visita
    Public Class InternoFoto
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private intInternoID As Integer = -1
        Private strCodigoRP As String = ""
        Private strPrimerApellido As String = ""
        Private strSegundoApellido As String = ""
        Private strPreNombres As String = ""
        Private strPathFoto As String = ""
        Private intFotoDescargada As Integer = -1
        Private intFotoPerfil As Integer = -1
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
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
        Public Property PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
        Public Property InternoCodigoRP() As String
            Get
                Return strCodigoRP
            End Get
            Set(ByVal value As String)
                strCodigoRP = value
            End Set
        End Property
        Public Property PrimerApellido() As String
            Get
                Return strPrimerApellido
            End Get
            Set(ByVal value As String)
                strPrimerApellido = value
            End Set
        End Property
        Public Property SegundoApellido() As String
            Get
                Return strSegundoApellido
            End Get
            Set(ByVal value As String)
                strSegundoApellido = value
            End Set
        End Property
        Public Property PreNombres() As String
            Get
                Return strPreNombres
            End Get
            Set(ByVal value As String)
                strPreNombres = value
            End Set
        End Property
        Public Property PathFoto() As String
            Get
                Return strPathFoto
            End Get
            Set(ByVal value As String)
                strPathFoto = value
            End Set
        End Property
        Public Property FotoPerfil() As Integer
            Get
                Return intFotoPerfil
            End Get
            Set(ByVal value As Integer)
                intFotoPerfil = value
            End Set
        End Property
        Public Property FotoDescargada() As Integer
            Get
                Return intFotoDescargada
            End Get
            Set(ByVal value As Integer)
                intFotoDescargada = value
            End Set
        End Property
#End Region
    End Class
#Region "InternoFotoCol"
    Public Class InternoFotoCol
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
        Public Function Add(ByVal obj As InternoFoto) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoFoto(ByVal Index As Integer) As InternoFoto
            Get
                Return CType(MyBase.List(Index), InternoFoto)
            End Get
        End Property
        Public Function CloneCol() As InternoFoto
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace