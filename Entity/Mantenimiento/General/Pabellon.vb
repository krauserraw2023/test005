Namespace Mantenimiento.General
    Public Class Pabellon
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property Nombre() As String = ""
        Public Property NombreCorto() As String = ""
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalNombre As String = ""
        Public Property Obs() As String = ""
        Public Property Estado() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""
                Select Case Me.Estado
                    Case 1
                        value = "Activo"
                    Case Else
                        value = "Inactivo"
                End Select

                Return value

            End Get
        End Property
#End Region
    End Class
#Region "PabellonCol"
    Public Class PabellonCol
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
        Public Function Add(ByVal value As Pabellon) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Pabellon) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Pabellon) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Pabellon)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Pabellon
            Get
                Return DirectCast(List(index), Pabellon)
            End Get
            Set(ByVal value As Pabellon)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Pabellon)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Pabellon
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace
