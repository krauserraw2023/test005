Namespace Visita.Programacion
    Public Class Calendario
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property CalendarioID() As Integer = -1
        'Public Property Codigo() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalNombre As String = ""
        Public Property RegimenVisitaID() As Integer = -1
        Public Property RegimenVisita() As String = ""
        Public Property VisitaTipoID() As Integer = -1
        Public Property VisitaTipo() As String = ""
        Public Property EtapaID() As Integer = -1
        Public Property Etapa() As String = ""
        Public Property FechaRegistro() As Long = 0
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
                Return value
            End Get
        End Property
#End Region
    End Class
#Region "CalendarioCol"
    Public Class CalendarioCol
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
        Public Function Add(ByVal value As Calendario) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Calendario) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Calendario) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Calendario)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Calendario
            Get
                Return DirectCast(List(index), Calendario)
            End Get
            Set(ByVal value As Calendario)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Calendario)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Calendario
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace