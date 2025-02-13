Namespace Registro.Documento
    Public Class DocumentoJudicialSubTipo
        Public Property Codigo() As Integer = -1
        Public Property NombreSubTipo As String = ""
    End Class
#Region "NotaEgresoCol"
    Public Class DocumentoJudicialSubTipoCol
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
        Public Function Add(ByVal obj As DocumentoJudicialSubTipo) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DocumentoJudicialSubTipo(ByVal Index As Integer) As DocumentoJudicialSubTipo
            Get
                Return CType(MyBase.List(Index), DocumentoJudicialSubTipo)
            End Get
        End Property
        Public Function CloneCol() As DocumentoJudicialSubTipo
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region

End Namespace