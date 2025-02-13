Namespace Registro
    Public Class InternoDatosComplementarios

#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property IDInterno() As Integer = -1
        Public Property pertenecePueblo As Short = -1
        Public Property IDGrupoPueblo() As Integer = -1
        Public Property IDPueblo() As Integer = -1
        Public Property OtroPueblo() As String = ""
        Public Property IDGrupoLenguaMaterna() As Integer = -1
        Public Property IDLenguaMaterna() As Integer = -1
        Public Property IDIdioma() As Integer = -1
        Public Property idRegion As Short = -1
        Public Property idPenal As Short = -1
#End Region
#Region "Filtro"
        Public Property idInternoHistorico As Integer = -1

#End Region
    End Class
#Region "InternoDatosComplementariosCol"
    Public Class InternoDatosComplementariosCol
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
        Public Function Add(ByVal value As InternoDatosComplementarios) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As InternoDatosComplementarios) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As InternoDatosComplementarios) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As InternoDatosComplementarios)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As InternoDatosComplementarios
            Get
                Return DirectCast(List(index), InternoDatosComplementarios)
            End Get
            Set(ByVal value As InternoDatosComplementarios)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As InternoDatosComplementarios)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As InternoDatosComplementarios
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace