Namespace Visita
    Public Class VisitanteRestriccion
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private strTipoRestriccion As String = ""

        Public Property Codigo() As Integer = -1
        Public Property VisitanteID() As Integer = -1
        Public Property VisitanteApeNom As String = ""
        Public Property RestriccionTipoID() As Integer = -1
        Public Property RestriccionTipo() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoRestriccion)
            End Get
            Set(ByVal value As String)
                strTipoRestriccion = value
            End Set
        End Property
        Public Property InternoID() As Integer = -1
        Public Property InternoApeNom As String = ""
        Public Property Documento() As String = ""
        Public Property Fecha() As Long = 0
        Public Property FechaInicio() As Long = 0
        Public Property FechaFin() As Long = 0
        Public Property FechaFinIndeterminado() As Boolean = False
      
        Public Property EstadoID() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Anulado"
                    Case 1
                        value = "Activo"
                End Select
                Return value
            End Get
        End Property
        Public Property Observacion() As String = ""
#End Region
#Region "Otros"
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
#End Region
    End Class
#Region "VisitanteRestriccionCol"
    Public Class VisitanteRestriccionCol
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
        Public Function Add(ByVal value As VisitanteRestriccion) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As VisitanteRestriccion) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As VisitanteRestriccion) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As VisitanteRestriccion)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As VisitanteRestriccion
            Get
                Return DirectCast(List(index), VisitanteRestriccion)
            End Get
            Set(ByVal value As VisitanteRestriccion)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As VisitanteRestriccion)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As VisitanteRestriccion
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace