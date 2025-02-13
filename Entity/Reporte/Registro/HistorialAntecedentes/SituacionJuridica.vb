Namespace Reporte.HistorialAntecedentes
    Public Class SituacionJuridica
        Inherits Reporte.FichaIdentificacion.SituacionJuridica
    End Class
#Region "SituacionJuridicaCol"
    Public Class SituacionJuridicaCol
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
        Public Function Add(ByVal obj As SituacionJuridica) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property SituacionJuridica(ByVal Index As Integer) As SituacionJuridica
            Get
                Return CType(MyBase.List(Index), SituacionJuridica)
            End Get
        End Property
    End Class
#End Region
End Namespace