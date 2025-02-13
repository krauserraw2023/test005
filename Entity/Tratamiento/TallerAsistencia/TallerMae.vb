Namespace Tratamiento.TallerAsistencia
    Public Class TallerMae
        Public Property Codigo As Integer = -1
        Public Property TallerIdBiometrico As Integer = -1
        Public Property TipoActividadId As Integer = -1
        Public Property TipoActividadNombre As String = ""
        Public Property ActividadId As Integer = -1
        Public Property ActividadNombre As String = ""
        Public Property NombreTaller As String = ""
        Public Property DescripcionTaller As String = ""
        Public Property PabellonTaller As String = ""
        Public Property NombreRespControlLab As String = ""
        Public Property NombreGestorProd As String = ""

        Public Property PenalNom As String = ""
        Public Property RegionNom As String = ""
        Public Property GrupoUsuarioRaiz As String = "" 'guarda el la raiz del grupos de usuario(Debe contener un / al final) Ejm: All Users/GpoUSR_Carpinteria/
        Public Property GrupoUsuario As String = "" 'nomobre del grupo de usuario Ejm: 1-Carpinteria en madera
        Public Property GrupoAcceso As String = ""
    End Class
#Region "PlanillaCabeceraCol"
    Public Class TallerMaeCol
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
        Public Function Add(ByVal value As TallerMae) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As TallerMae) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As TallerMae) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As TallerMae)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As TallerMae
            Get
                Return DirectCast(List(index), TallerMae)
            End Get
            Set(ByVal value As TallerMae)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As TallerMae)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As TallerMae
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace