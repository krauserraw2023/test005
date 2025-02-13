Namespace Reporte.FichaIdentificacion
    Public Class SituacionJuridicaAgraviado
#Region "Propiedades"
        Private strAgraviado As String = ""
        Public Property Agraviado() As String
            Get
                Return strAgraviado
            End Get
            Set(ByVal value As String)
                strAgraviado = value
            End Set
        End Property

#End Region
    End Class
#Region "SituacionJuridicaAgraviadoCol"
    Public Class SituacionJuridicaAgraviadoCol
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
        Public Function Add(ByVal obj As SituacionJuridicaAgraviado) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property SituacionJuridicaAgraviado(ByVal Index As Integer) As SituacionJuridicaAgraviado
            Get
                Return CType(MyBase.List(Index), SituacionJuridicaAgraviado)
            End Get
        End Property
    End Class
#End Region
End Namespace