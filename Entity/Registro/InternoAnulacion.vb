Namespace Registro
    Public Class InternoAnulacion
        Inherits Auditoria.Transaccion
        Public Property FlagTransferenciaSede As Integer = 0

        Private intCodigo As Integer = -1

        Private intInternoID As Integer = -1
        Private intInternoIngresoId As Integer = -1
        Private intInternoExpedienteId As Integer = -1
        Private intInternoDelitoId As Integer = -1
        Private intInternoAgraviadoId As Integer = -1

        Private intAutoridadJudicialID As Integer = -1
        Private intAutoridadJudicialNombre As String = ""
        Private intSalaJudicialID As Integer = -1
        Private intSalaJudicialNombre As String = ""
        Private strDocumentoNumero As String = ""
        Private lngFecha As Long = 0
        Private strOtroCargo As String = ""
        Private strOtroNombre As String = ""
        Private strSecretarioNombre As String = ""
        Private strObservacion As String = ""
        Private int_RegId As Integer = -1
        Private int_PenId As Integer = -1
        Private int_RowId As Integer = -1
        Private str_arc_nom As String = ""
#Region "Propiedades"
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
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

        Public Property IngresoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property

        Public Property ExpedienteID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property

        Public Property DelitoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property

        Public Property AgraviadoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property

        Public Property AutoridadJudicialID() As Integer
            Get
                Return intAutoridadJudicialID
            End Get
            Set(ByVal value As Integer)
                intAutoridadJudicialID = value
            End Set
        End Property
        Public Property AutoridadJudicialNombre() As String
            Get
                Return intAutoridadJudicialNombre
            End Get
            Set(ByVal value As String)
                intAutoridadJudicialNombre = value
            End Set
        End Property
        Public Property SalaJudicialID() As Integer
            Get
                Return intSalaJudicialID
            End Get
            Set(ByVal value As Integer)
                intSalaJudicialID = value
            End Set
        End Property
        Public Property SalaJudicialNombre() As String
            Get
                Return intSalaJudicialNombre
            End Get
            Set(ByVal value As String)
                intSalaJudicialNombre = value
            End Set
        End Property
        Public Property DocumentoNumero() As String
            Get
                Return strDocumentoNumero
            End Get
            Set(ByVal value As String)
                strDocumentoNumero = value
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
                Dim _str As String = ""
                If Fecha > 0 Then
                    _str = System.DateTime.FromFileTime(Fecha)
                End If
                Return _str
            End Get
        End Property
        Public Property OtroCargo() As String
            Get
                Return strOtroCargo
            End Get
            Set(ByVal value As String)
                strOtroCargo = value
            End Set
        End Property
        Public Property OtroNombre() As String
            Get
                Return strOtroNombre
            End Get
            Set(ByVal value As String)
                strOtroNombre = value
            End Set
        End Property
        Public Property SecretarioNombre() As String
            Get
                Return strSecretarioNombre
            End Get
            Set(ByVal value As String)
                strSecretarioNombre = value
            End Set
        End Property
        Public Property Observacion() As String
            Get
                Return strObservacion
            End Get
            Set(ByVal value As String)
                strObservacion = value
            End Set
        End Property
        Public Property _RegId() As Integer
            Get
                Return int_RegId
            End Get
            Set(ByVal value As Integer)
                int_RegId = value
            End Set
        End Property
        Public Property _PenId() As Integer
            Get
                Return int_PenId
            End Get
            Set(ByVal value As Integer)
                int_PenId = value
            End Set
        End Property
        Public Property _RowId() As Integer
            Get
                Return int_RowId
            End Get
            Set(ByVal value As Integer)
                int_RowId = value
            End Set
        End Property
        Public Property _arc_nom() As String
            Get
                Return str_arc_nom
            End Get
            Set(ByVal value As String)
                str_arc_nom = value
            End Set
        End Property
#End Region
    End Class
#Region "AnulacionCol"
    Public Class InternoAnulacionCol
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
        Public Function Add(ByVal obj As InternoAnulacion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Anulacion(ByVal Index As Integer) As InternoAnulacion
            Get
                Return CType(MyBase.List(Index), InternoAnulacion)
            End Get
        End Property
    End Class
#End Region
End Namespace

