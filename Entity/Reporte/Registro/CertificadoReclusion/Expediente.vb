Namespace Reporte.CertificadoReclusion
    Public Class Expediente
#Region "Propiedades"
        Private strNumeroExpediente As String = ""
        Private strDistritoJudicial As String = ""
        Private strJuzgadoSala As String = ""
        Private strSecretario As String = ""
        Private strSituacionJuridica As String = ""
        Public Property NumeroExpediente() As String
            Get
                Return strNumeroExpediente
            End Get
            Set(ByVal value As String)
                strNumeroExpediente = value
            End Set
        End Property
        Public Property DistritoJudicial() As String
            Get
                Return strDistritoJudicial
            End Get
            Set(ByVal value As String)
                strDistritoJudicial = value
            End Set
        End Property
        Public Property JuzgadoSala() As String
            Get
                Return strJuzgadoSala
            End Get
            Set(ByVal value As String)
                strJuzgadoSala = value
            End Set
        End Property
        Public Property Secretario() As String
            Get
                Return strSecretario
            End Get
            Set(ByVal value As String)
                strSecretario = value
            End Set
        End Property
        Public Property SituacionJuridica() As String
            Get
                Return strSituacionJuridica
            End Get
            Set(ByVal value As String)
                strSituacionJuridica = value
            End Set
        End Property
#End Region
    End Class
#Region "ExpedienteCol"
    Public Class ExpedienteCol
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
        Public Function Add(ByVal obj As Expediente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Expediente(ByVal Index As Integer) As Expediente
            Get
                Return CType(MyBase.List(Index), Expediente)
            End Get
        End Property
    End Class
#End Region
End Namespace