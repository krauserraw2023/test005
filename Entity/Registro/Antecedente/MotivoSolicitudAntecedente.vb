Namespace Registro.Antecedente
    Public Class MotivoSolicitudAntecedente
        Public Property Codigo As Integer = -1
        Public Property Motivo As String = ""
        Public Property TipoAutoridadJudicialId As Integer = -1
    End Class
#Region "BandaCol"
    Public Class MotivoSolicitudAntecedenteCol
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
        Public Function Add(ByVal obj As MotivoSolicitudAntecedente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property MotivoSolicitudAntecedente(ByVal Index As Integer) As MotivoSolicitudAntecedente
            Get
                Return CType(MyBase.List(Index), MotivoSolicitudAntecedente)
            End Get
        End Property
    End Class
#End Region
End Namespace