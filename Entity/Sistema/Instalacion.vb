Namespace Sistema
    Public Class Instalacion
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private strNombre As String = ""
        Private intTipo As Integer = -1
        Private strDescripcion As String = ""
        Private strNombreCorto As String = ""
        Private intRegionID As Integer = -1
        Private blnLogmein As Boolean = False
        Private blnInternet As Boolean = False
        Private strVersionApp As String = ""
        Private strVersionBD As String = ""
        Private strObs As String = ""
        Private lngFecha As Long = 0
        Private strRegionNombre As String = ""
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property Nombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNombre)
            End Get
            Set(ByVal value As String)
                strNombre = value
            End Set
        End Property
        Public Property Tipo() As Integer
            Get
                Return intTipo
            End Get
            Set(ByVal value As Integer)
                intTipo = value
            End Set
        End Property
        Public Property Descripcion() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDescripcion)
            End Get
            Set(ByVal value As String)
                strDescripcion = value
            End Set
        End Property
        Public Property Fecha() As Long
            Get
                Return lngFecha
            End Get
            Set(ByVal value As Long)
                lngFecha = value
            End Set
        End Property
        Public ReadOnly Property FechaDate() As DateTime
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.Fecha)
            End Get
        End Property
        Public ReadOnly Property FechaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
            End Get
        End Property
        Public Property NombreCorto() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNombreCorto)
            End Get
            Set(ByVal value As String)
                strNombreCorto = value
            End Set
        End Property
        Public Property IDPenal As Integer = -1
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
        Public Property PenalNombre As String = ""
        Public Property Logmein() As Boolean
            Get
                Return blnLogmein
            End Get
            Set(ByVal value As Boolean)
                blnLogmein = value
            End Set
        End Property
        Public Property Internet() As Boolean
            Get
                Return blnInternet
            End Get
            Set(ByVal value As Boolean)
                blnInternet = value
            End Set
        End Property
        Public Property VersionApp() As String
            Get
                Return strVersionApp
            End Get
            Set(ByVal value As String)
                strVersionApp = value
            End Set
        End Property
        Public Property VersionBD() As String
            Get
                Return strVersionBD
            End Get
            Set(ByVal value As String)
                strVersionBD = value
            End Set
        End Property
        Public Property Obs() As String
            Get
                Return strObs
            End Get
            Set(ByVal value As String)
                strObs = value
            End Set
        End Property
#End Region
    End Class
#Region "InstalacionCol"
    Public Class InstalacionCol
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
        Public Function Add(ByVal obj As Instalacion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Instalacion(ByVal Index As Integer) As Instalacion
            Get
                Return CType(MyBase.List(Index), Instalacion)
            End Get
        End Property
        Public Function CloneCol() As Instalacion
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace