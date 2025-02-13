Namespace Registro.Documento
    Public Class NotaEgreso
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private intDocumentoJudicialID As Integer = -1
        Private intInternoID As Integer = -1
        Private intIngresoID As Integer = -1
        Private intExpedienteID As Integer = -1
        Private intEgresoTipo As Integer = -1
        Private lngEgresoFecha As Long = 0
        Private strObservacion As String = ""
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property DocumentoJudicialID() As Integer
            Get
                Return intDocumentoJudicialID
            End Get
            Set(ByVal value As Integer)
                intDocumentoJudicialID = value
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
                Return intIngresoID
            End Get
            Set(ByVal value As Integer)
                intIngresoID = value
            End Set
        End Property
        Public Property ExpedienteID() As Integer
            Get
                Return intExpedienteID
            End Get
            Set(ByVal value As Integer)
                intExpedienteID = value
            End Set
        End Property
        Public Property EgresoTipo() As Integer
            Get
                Return intEgresoTipo
            End Get
            Set(ByVal value As Integer)
                intEgresoTipo = value
            End Set
        End Property
        Public Property EgresoFecha() As Long
            Get
                Return lngEgresoFecha
            End Get
            Set(ByVal value As Long)
                lngEgresoFecha = value
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
#End Region
    End Class
#Region "NotaEgresoCol"
    Public Class NotaEgresoCol
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
        Public Function Add(ByVal obj As NotaEgreso) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property NotaEgreso(ByVal Index As Integer) As NotaEgreso
            Get
                Return CType(MyBase.List(Index), NotaEgreso)
            End Get
        End Property
        Public Function CloneCol() As NotaEgreso
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace