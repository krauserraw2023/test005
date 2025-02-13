Namespace Reporte.FichaIdentificacion
    Public Class SenasParticulares
#Region "Propiedades"
        Private strNaturaleza As String = ""
        Private strForma As String = ""
        Private strUbicacion As String = ""
        Public Property Naturaleza() As String
            Get
                Return strNaturaleza
            End Get
            Set(ByVal value As String)
                strNaturaleza = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property Forma() As String
            Get
                Return strForma
            End Get
            Set(ByVal value As String)
                strForma = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
        Public Property Ubicacion() As String
            Get
                Return strUbicacion
            End Get
            Set(ByVal value As String)
                strUbicacion = Legolas.Components.Cadena.ProperCase(value)
            End Set
        End Property
#End Region
    End Class
#Region "SenasParticularesCol"
    Public Class SenasParticularesCol
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
        Public Function Add(ByVal obj As SenasParticulares) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property SenasParticulares(ByVal Index As Integer) As SenasParticulares
            Get
                Return CType(MyBase.List(Index), SenasParticulares)
            End Get
        End Property
    End Class
#End Region
End Namespace