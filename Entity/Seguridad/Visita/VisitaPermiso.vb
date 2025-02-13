Namespace Visita
    Public Class VisitaPermiso
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCODIGO As Integer = -1
        Private intVisitanteId As Integer = -1
        Private intInternoId As Integer = -1
        Private lngFechadsd As Long = 0
        Private lngFechahst As Long = 0

        Private strDocumento As String = ""
        Private intEstadoId As Integer = -1

        Private intPArentescoId As Integer = -1
        Private strParentesco As String = ""

        Private intTipoId As Integer = -1
        Private strTipo As String = ""
        Private intMotivoId As Integer = -1
        Private strMotivo As String = ""

        Private intPAbellonId As Integer = -1
        Private strPabellon As String = ""



        Private strInternoPaterno As String = ""
        Private strInternoMaterno As String = ""
        Private strInternoNombres As String = ""


        Public Property CODIGO() As Integer
            Get
                Return intCODIGO
            End Get
            Set(ByVal value As Integer)
                intCODIGO = value
            End Set
        End Property
        Public Property VisitanteId() As Integer
            Get
                Return intVisitanteId
            End Get
            Set(ByVal value As Integer)
                intVisitanteId = value
            End Set
        End Property
        Public Property InternoId() As Integer
            Get
                Return intInternoId
            End Get
            Set(ByVal value As Integer)
                intInternoId = value
            End Set
        End Property
        Public Property FechaDesde() As Long
            Get
                Return lngFechadsd
            End Get
            Set(ByVal value As Long)
                lngFechadsd = value
            End Set
        End Property
        Public ReadOnly Property FechaDesde_Date() As String
            Get
                Return System.DateTime.FromFileTime(FechaDesde).ToShortDateString

            End Get
        End Property
        Public ReadOnly Property FechaHasta_Date() As String
            Get
                Return System.DateTime.FromFileTime(FechaHasta).ToShortDateString

            End Get
        End Property
        Public Property FechaHasta() As Long
            Get
                Return lngFechahst
            End Get
            Set(ByVal value As Long)
                lngFechahst = value
            End Set
        End Property
        Public Property Documento() As String
            Get
                Return strDocumento
            End Get
            Set(ByVal value As String)
                strDocumento = value
            End Set
        End Property
        Public Property EstadoId() As Integer
            Get
                Return intEstadoId
            End Get
            Set(ByVal value As Integer)
                intEstadoId = value
            End Set
        End Property

        Public ReadOnly Property EstadoFecha() As Boolean
            Get
                Dim bol As Boolean = False
                If FechaDesde <= Date.Today.ToFileTime And FechaHasta >= Date.Today.ToFileTime Then
                    bol = True
                End If
                Return bol
            End Get
        End Property

        Public Property PArentescoID() As Integer
            Get
                Return intPArentescoId
            End Get
            Set(ByVal value As Integer)
                intPArentescoId = value
            End Set
        End Property
        Public Property PArentescoNombre() As String
            Get
                Return strParentesco
            End Get
            Set(ByVal value As String)
                strParentesco = value
            End Set
        End Property

        Public Property TipoID() As Integer
            Get
                Return intTipoId
            End Get
            Set(ByVal value As Integer)
                intTipoId = value
            End Set
        End Property
        Public Property TipoNombre() As String
            Get
                Return strTipo
            End Get
            Set(ByVal value As String)
                strTipo = value
            End Set
        End Property

        Public Property MotivoId() As Integer
            Get
                Return intMotivoId
            End Get
            Set(ByVal value As Integer)
                intMotivoId = value
            End Set
        End Property
        Public Property MotivoNombre() As String
            Get
                Return strMotivo
            End Get
            Set(ByVal value As String)
                strMotivo = value
            End Set
        End Property

        Public Property PabellonId() As Integer
            Get
                Return intPAbellonId
            End Get
            Set(ByVal value As Integer)
                intPAbellonId = value
            End Set
        End Property
        Public Property PabellonNombre() As String
            Get
                Return strPabellon
            End Get
            Set(ByVal value As String)
                strPabellon = value
            End Set
        End Property


        Public Property InternoPAterno() As String
            Get
                Return strInternoPaterno
            End Get
            Set(ByVal value As String)
                strInternoPaterno = value
            End Set
        End Property
        Public Property InternoMaterno() As String
            Get
                Return strInternoMaterno
            End Get
            Set(ByVal value As String)
                strInternoMaterno = value
            End Set
        End Property
        Public Property InternoNombre() As String
            Get
                Return strInternoNombres
            End Get
            Set(ByVal value As String)
                strInternoNombres = value
            End Set
        End Property
#End Region
    End Class
#Region "VisitaPermisoCol"
    Public Class VisitaPermisoCol
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
        Public Function Add(ByVal obj As VisitaPermiso) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Visitantesancion(ByVal Index As Integer) As VisitaPermiso
            Get
                Return CType(MyBase.List(Index), VisitaPermiso)
            End Get
        End Property
        Public Function CloneCol() As VisitaPermiso
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace