Namespace Reporte.FichaIdentificacion

    Public Class SituacionJuridicaExpediente
        Inherits Reporte.FichaIdentificacion.SituacionJuridica

    End Class
#Region "SituacionJuridicaExpedienteCol"
    Public Class SituacionJuridicaExpedienteCol
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
        Public Function Add(ByVal obj As SituacionJuridicaExpediente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property SituacionJuridicaExpediente(ByVal Index As Integer) As SituacionJuridicaExpediente
            Get
                Return CType(MyBase.List(Index), SituacionJuridicaExpediente)
            End Get
        End Property
    End Class
#End Region
End Namespace