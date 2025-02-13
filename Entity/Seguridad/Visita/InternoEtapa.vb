Namespace Visita
    Public Class InternoEtapa
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalNombre As String = ""
        Public Property InternoID() As Integer = -1
        Public Property InternoApePaterno() As String = ""
        Public Property InternoApeMaterno() As String = ""
        Public Property InternoNombres() As String = ""
        Public Property InternoApeNom() As String = ""
        Public Property EtapaID() As Integer = -1
        Public Property EtapaNombre() As String = -1
        Public Property FechaRegistro As Long = 0
        Public Property Documento() As String = ""
        Public Property DocumentoFecha() As Long = 0
        Public Property Obs() As String = ""
        Public Property Estado() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""
                Select Case Me.Estado
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select
                Return Value
            End Get
        End Property

#End Region
#Region "Filtro"
        Public Property InternoApellidos As String = ""        
#End Region
    End Class
#Region "InternoEtapaCol"
    Public Class InternoEtapaCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, SortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal value As InternoEtapa) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As InternoEtapa) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As InternoEtapa) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As InternoEtapa)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As InternoEtapa
            Get
                Return DirectCast(List(index), InternoEtapa)
            End Get
            Set(ByVal value As InternoEtapa)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As InternoEtapa)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As InternoEtapa
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace