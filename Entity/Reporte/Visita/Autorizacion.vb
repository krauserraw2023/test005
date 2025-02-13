Namespace Reporte.Visita
    Public Class Autorizacion
        Public Property InternoApeNom As String = ""
        Public Property VisitanteTipoDocumento As String = ""
        Public Property VisitanteNumeroDocumento As String = ""
        Public Property VisitantePrimerApellido As String = ""
        Public Property VisitanteSegundoApellido As String = ""
        Public Property VisitantePreNombres As String = ""
        Public ReadOnly Property VisitanteApellidosyNombresReadonly As String
            Get
                Dim value As String = ""
                value = Me.VisitantePrimerApellido & " " & Me.VisitanteSegundoApellido & ", " & Me.VisitantePreNombres
                Return value
            End Get
        End Property
        Public Property VisitanteApeNom As String = ""
        Public Property Parentesco As String = ""
        Public Property Observacion As String = ""
        Public Property Estado As String = ""
#Region "Propiedades_Licencia"
        Public Property LicenciaRegion() As String = ""
        Public Property LicenciaPenal() As String = ""
#End Region
    End Class
    Public Class AutorizacionCol
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
        Public Function Add(ByVal value As Autorizacion) As Integer

            Return List.Add(value)

        End Function
        Public Function Contains(ByVal value As Autorizacion) As Boolean

            Return List.Contains(value)

        End Function
        Public Function IndexOf(ByVal value As Autorizacion) As Integer

            Return List.IndexOf(value)

        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Autorizacion)

            List.Insert(index, value)

        End Sub
        Default Public Property Item(ByVal index As Integer) As Autorizacion

            Get

                Return DirectCast(List(index), Autorizacion)

            End Get

            Set(ByVal value As Autorizacion)

                List(index) = value

            End Set

        End Property
        Public Sub Remove(ByVal value As Autorizacion)

            List.Remove(value)

        End Sub
    End Class
End Namespace