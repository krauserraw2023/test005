Namespace Transferencia
    Public Class Archivo

        Inherits Auditoria.Transaccion
        Private intCodigo As Integer = -1
        Private intTipo As Integer = -1
        Private intNumero As Integer = -1
        Private lngFecha As Long = 0
        Private lngFechaDesde As Long = 0
        Private lngFechaHasta As Long = 0
        Private strRuta As String = ""
        Private strArchivoNombre As String = ""
        Private intRegionId As Integer = -1
        Private intPenalId As Integer = -1

        Private _CntTotal As Integer = 0
        Private _CntSentenciado As Integer = 0
        Private _CntPRocesado As Integer = 0
        Private _CntAlta As Integer = 0
        Private _CntBaja As Integer = 0
        Private _FechaSubida As Long = 0




#Region "Propiedades"
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
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
        Public Property Numero() As Integer
            Get
                Return intNumero
            End Get
            Set(ByVal value As Integer)
                intNumero = value
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
        Public ReadOnly Property FechaStr() As String
            Get
                Return System.DateTime.FromFileTime(lngFecha).ToShortDateString

            End Get
        End Property

        Public Property FechaDesde() As Long
            Get
                Return lngFechaDesde
            End Get
            Set(ByVal value As Long)
                lngFechaDesde = value
            End Set
        End Property
        Public Property FechaHasta() As Long
            Get
                Return lngFechaHasta
            End Get
            Set(ByVal value As Long)
                lngFechaHasta = value
            End Set
        End Property
        Public Property Ruta() As String
            Get
                Return strRuta
            End Get
            Set(ByVal value As String)
                strRuta = value
            End Set
        End Property

        Public Property ArchivoNombre() As String
            Get
                Return strArchivoNombre
            End Get
            Set(ByVal value As String)
                strArchivoNombre = value
            End Set
        End Property
        Public Property RegionId() As Integer
            Get
                Return intRegionId
            End Get
            Set(ByVal value As Integer)
                intRegionId = value
            End Set
        End Property
        Public Property PenalId() As Integer
            Get
                Return intPenalId
            End Get
            Set(ByVal value As Integer)
                intPenalId = value
            End Set
        End Property

        Public Property CntTotal() As Integer
            Get
                Return _CntTotal
            End Get
            Set(ByVal value As Integer)
                _CntTotal = value
            End Set
        End Property

        Public Property CntProcesado() As Integer
            Get
                Return _CntPRocesado
            End Get
            Set(ByVal value As Integer)
                _CntPRocesado = value
            End Set
        End Property

        Public Property CntSentenciado() As Integer
            Get
                Return _CntSentenciado
            End Get
            Set(ByVal value As Integer)
                _CntSentenciado = value
            End Set
        End Property

        Public Property CntAlta() As Integer
            Get
                Return _CntAlta
            End Get
            Set(ByVal value As Integer)
                _CntAlta = value
            End Set
        End Property

        Public Property CntBaja() As Integer
            Get
                Return _CntBaja
            End Get
            Set(ByVal value As Integer)
                _CntBaja = value
            End Set
        End Property


        Public Property FechaSubida() As Long
            Get
                Return _FechaSubida
            End Get
            Set(ByVal value As Long)
                _FechaSubida = value
            End Set
        End Property







#End Region
    End Class
#Region "ArchivoCol"
    Public Class ArchivoCol
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
        Public Function Add(ByVal obj As Archivo) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Archivo(ByVal Index As Integer) As Archivo
            Get
                Return CType(MyBase.List(Index), Archivo)
            End Get
        End Property
    End Class
#End Region
End Namespace
