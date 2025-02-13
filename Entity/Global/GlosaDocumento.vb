Namespace Globall
    Public Class GlosaDocumento
        Public Property Codigo As Integer = -1
        Public ReadOnly Property CodigoString As String
            Get
                Return Format(Me.Codigo, "0000")
            End Get
        End Property
        Public Property DescripcionCorta As String = ""
        Public Property Texto As String = ""
        Public Property EstadoId As Integer = 1 '1:Activo,0:Inactivo(baja)
        Public Property TipoGlosaId As Integer = -1
    End Class
    Public Class GlosaDocumentoCol
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
        Public Function Add(ByVal obj As GlosaDocumento) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property CategoriaFicha(ByVal Index As Integer) As GlosaDocumento
            Get
                Return CType(MyBase.List(Index), GlosaDocumento)
            End Get
        End Property
    End Class
End Namespace