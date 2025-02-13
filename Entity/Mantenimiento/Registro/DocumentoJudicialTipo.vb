Namespace Registro.Documento
    Public Class DocumentoJudicialTipo
        Public Property Codigo() As Integer = -1
        Public Property DocJudTipo As String = ""
    End Class
#Region "NotaEgresoCol"
    Public Class DocumentoJudicialTipoCol
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
        Public Function Add(ByVal obj As DocumentoJudicialTipo) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DocumentoJudicialTipo(ByVal Index As Integer) As DocumentoJudicialTipo
            Get
                Return CType(MyBase.List(Index), DocumentoJudicialTipo)
            End Get
        End Property
        Public Function CloneCol() As DocumentoJudicialTipo
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region

End Namespace