Namespace Estadistica
    Public Class PadinDetalleFamilia
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intPadinID As Integer = -1
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private intInternoID As Integer = -1
        Private strPrimerApellido As String = ""
        Private strSegundoApellido As String = ""
        Private strPreNombres As String = ""
        Private lngFechaNacimiento As Long = 0
        Private intSexoID As Integer = -1
        Private strSexoNombre As String = ""
        Private blnVive As Boolean = False
        Private blnRecluido As Boolean = False
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property PadinID() As Integer
            Get
                Return intPadinID
            End Get
            Set(ByVal value As Integer)
                intPadinID = value
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
        Public Property FechaNacimiento() As Long
            Get
                Return lngFechaNacimiento
            End Get
            Set(ByVal value As Long)
                lngFechaNacimiento = value
            End Set
        End Property
        Public Property SexoID() As Integer
            Get
                Return intSexoID
            End Get
            Set(ByVal value As Integer)
                intSexoID = value
            End Set
        End Property
        Public Property SexoNombre() As String
            Get
                Return strSexoNombre
            End Get
            Set(ByVal value As String)
                strSexoNombre = value
            End Set
        End Property
        Public Property Vive() As Boolean
            Get
                Return blnVive
            End Get
            Set(ByVal value As Boolean)
                blnVive = value
            End Set
        End Property
        Public Property Recluido() As Boolean
            Get
                Return blnRecluido
            End Get
            Set(ByVal value As Boolean)
                blnRecluido = value
            End Set
        End Property
#End Region
    End Class
#Region "PadinDetalleFamiliaCol"
    Public Class PadinDetalleFamiliaCol
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
        Public Function Add(ByVal obj As PadinDetalleFamilia) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property PadinDetalleFamilia(ByVal Index As Integer) As PadinDetalleFamilia
            Get
                Return CType(MyBase.List(Index), PadinDetalleFamilia)
            End Get
        End Property
        Public Function CloneCol() As PadinDetalleFamilia
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace