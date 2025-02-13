Namespace Registro
    Public Class MovimientoExpediente
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intMovimientoId As Integer = -1
        Private intInternoId As Integer = -1
        Private intExpedienteId As Integer = -1
        Private intRegionId As Integer = -1
        Private intPenalId As Integer = -1

        Public Property FlagTransferenciaSede As Integer = 0
        Public Property Indice As Integer = 0
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property MovimientoID() As Integer
            Get
                Return intMovimientoId
            End Get
            Set(ByVal value As Integer)
                intMovimientoId = value
            End Set
        End Property
        Public Property InternoID() As Integer
            Get
                Return intInternoId
            End Get
            Set(ByVal value As Integer)
                intInternoId = value
            End Set
        End Property
        Public Property ExpedienteID() As Integer
            Get
                Return intExpedienteId
            End Get
            Set(ByVal value As Integer)
                intExpedienteId = value
            End Set
        End Property
        Public Property _RegionID() As Integer
            Get
                Return intRegionId
            End Get
            Set(ByVal value As Integer)
                intRegionId = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalId
            End Get
            Set(ByVal value As Integer)
                intPenalId = value
            End Set
        End Property
#End Region
#Region "Propiedades_DocumentoJudicial"
        Public Property DocumentoJudicialID() As Integer = -1
        Public Property DocumentoJudicialNum() As String = ""
        Public Property DocumentoJudicialFechaRecepcion() As Long = 0
        Public Property DocumentoJudicialFecha() As Long = 0
        Public Property DocumentoTipoAutoridadJudicialID() As Integer = -1
        Public Property DocumentoAutoridadJudicialID() As Integer = -1
        Public Property DocumentoSalaJudidicalID() As Integer = -1
        Public Property DocumentoJudicialJuez() As String = ""
        Public Property DocumentoJudidicalSecretario() As String = ""
        Public Property DocumentoJudicialNombreAutoridad() As String = ""
        Public Property DocumentoJudidicalNombreCargo() As String = ""
        Public Property DocumentoJudidicalObservacion() As String = ""
#End Region
#Region "Propiedades_Expediente"

        Private strAutoridadJudicialNombre As String = ""
        Private strSalaJudicialNombre As String = ""
        Private strSituacionJuridicaNombre As String = ""


        Public Property IngresoID() As Integer = -1
        Public Property Internamiento() As Boolean = False
        Public Property AutoridadJudicialID() As Integer = -1
        Public Property AutoridadJudicialNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strAutoridadJudicialNombre)
            End Get
            Set(ByVal value As String)
                strAutoridadJudicialNombre = value
            End Set
        End Property
        Public Property SalaJudicialID() As Integer = -1
        Public Property SalaJudicialNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSalaJudicialNombre)
            End Get
            Set(ByVal value As String)
                strSalaJudicialNombre = value
            End Set
        End Property
        Public Property ExpedienteJuez() As String = ""
        Public Property ExpedienteSecretario() As String = ""
        Public Property ExpedienteNumero() As String = ""
        Public Property ExpedienteFechaDocRecepcion() As Long = 0
        Public Property ExpedienteFecha() As Long = 0
        Public ReadOnly Property ExpedienteFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.ExpedienteFecha)
            End Get
        End Property
        Public Property SituacionJuridicaID() As Integer = -1
        Public Property SituacionJuridicaNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSituacionJuridicaNombre)
            End Get
            Set(ByVal value As String)
                strSituacionJuridicaNombre = value
            End Set
        End Property
        Public Property Observacion() As String = ""
        Public Property Principal() As Boolean = False
        Public Property SentenciaPrincipal() As Boolean = False
        Public ReadOnly Property Eliminar() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image
                objImagen = My.Resources.delete_32
                Return objImagen
            End Get

        End Property
#End Region
    End Class

#Region "MovimientoExpedienteCol"
    Public Class MovimientoExpedienteCol
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
        Public Function Add(ByVal obj As MovimientoExpediente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property MovimientoExpediente(ByVal Index As Integer) As MovimientoExpediente
            Get
                Return CType(MyBase.List(Index), MovimientoExpediente)
            End Get
        End Property
    End Class
#End Region

End Namespace

