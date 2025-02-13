Namespace Estadistica
    Public Class PadinDelito
        Inherits Auditoria.Transaccion
#Region "Propiedades"

        Public Property Codigo() As Integer = -1

        Public Property InternoId As Integer = -1
        Public Property IngresoId As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property TipoSituacionJuridica As Integer = -1
        Public Property InternoDelitoId As Integer = -1
        Public Property DelitoEspecificoId As Integer = -1
        Public Property DelitoEspecificoNombre As String = ""
        Public Property DelitoGenericoId As Integer = -1
        Public Property DelitoGenericoNombre As String = ""
        Public Property ExpedienteId As Integer = -1
        Public Property ExpedienteNumero As String = ""
        Public Property DocumentoJudicialId As Integer = -1
        Public Property TipoDocumento As String = ""
        Public Property FechaRecepcion As Long = 0
        Public Property Agraviados As String = ""
        Public Property DelitoMayorPena As Boolean = False
        Public Property DelitoSentenciaMayorPena As Boolean = False
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property Estado As Integer = -1

        Public Property UsuarioCreacion() As String = ""
        Public Property UsuarioModific() As String = ""
        Public Property FechaRegistro As Long = 0

        Public ReadOnly Property FechaRecepcionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaRecepcion, True)
            End Get
        End Property
        Public ReadOnly Property FechaCreacionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaRegistro, True)
            End Get
        End Property
#End Region
    End Class
#Region "PadinDelitoCol"
    Public Class PadinDelitoCol
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
        Public Function Add(ByVal obj As PadinDelito) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property PadinDelito(ByVal Index As Integer) As PadinDelito
            Get
                Return CType(MyBase.List(Index), PadinDelito)
            End Get
        End Property
        Public Function CloneCol() As Padin
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace