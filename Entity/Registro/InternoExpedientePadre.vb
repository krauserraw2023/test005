Namespace Registro
    Public Class InternoExpedientePadre
        Inherits Auditoria.Transaccion
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeId() As Integer = -1
        Public Property DocJudicialID() As Integer = -1
        Public Property DocTipoID() As Integer = -1
        Public Property InternoExpedienteId() As Integer = -1
        Public Property InternoExpedienteRefPadreId() As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property DocJudPadre As Integer = -1
        Public Property DocJudTipoPadre As Integer = -1
        Public Property DocJudCategPadre As Integer = -1
    End Class
#Region "BandaCol"
    Public Class InternoExpedientePadreCol
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
        Public Function Add(ByVal obj As InternoExpedientePadre) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoExpedientePadre(ByVal Index As Integer) As InternoExpedientePadre
            Get
                Return CType(MyBase.List(Index), InternoExpedientePadre)
            End Get
        End Property
    End Class
#End Region
End Namespace
