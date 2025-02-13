Namespace Mantenimiento.Tratamiento.Clasificacion

    Public Class ResultadoDet_BE
        Public Property Codigo As Short = -1
        Public Property IDFichaResultado As Short = -1
        Public Property NacionalidadInterno As Short = -1 '1=Peruano, 2=Extranjero,3=Peruano y extranjero
        Public Property PuntajeInicial As Short = 0
        Public Property PuntajeFinal As Short = 0
        Public Property Descripcion As String = ""
        Public Property IDTabla As Integer = -1
        Public Property SituacionJuridicaId As Integer = -1
        Public Property PenalId As Integer = -1
    End Class
    Public Class ResultadoDetCol_BE
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
        Public Function Add(ByVal obj As ResultadoDet_BE) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property CategoriaFicha(ByVal Index As Integer) As ResultadoDet_BE
            Get
                Return CType(MyBase.List(Index), ResultadoDet_BE)
            End Get
        End Property
    End Class
End Namespace