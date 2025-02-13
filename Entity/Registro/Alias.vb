Namespace Registro
    Public Class InternoAlias
        Inherits Auditoria.Transaccion                
        Private strNombres As String = ""
#Region "Propiedades"
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property Nombres() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNombres)
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Public Property IngresoID() As Integer = -1
        Public Property IngresoNro() As String = ""
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1

        Public Property IngresoNroInpe As Integer = 0

#End Region
    End Class
#Region "InternoAliasCol"
    Public Class InternoAliasCol
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
        Public Function Add(ByVal obj As InternoAlias) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoAlias(ByVal Index As Integer) As InternoAlias
            Get
                Return CType(MyBase.List(Index), InternoAlias)
            End Get
        End Property
    End Class
#End Region
End Namespace
