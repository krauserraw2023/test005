Namespace Mantenimiento.Registro
    Public Class Movimiento
#Region "Propiedades"
        Public Property Codigo As Integer = -1
        Public Property MovimientoTipoID() As Integer = -1
        Public Property MovimientoTipoNombre() As String = ""
        Public Property MovimientoTipoDescripcion() As String = ""
        Public Property MovimientoMotivoNombre As String = ""
#End Region
#Region "Filtro"
        Public Property IDTipoLicencia As Short = -1
#End Region
    End Class
#Region "MovimientoCol"
    Public Class MovimientoCol
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
        Public Function Add(ByVal obj As Movimiento) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Movimiento(ByVal Index As Integer) As Movimiento
            Get
                Return CType(MyBase.List(Index), Movimiento)
            End Get
        End Property
    End Class
#End Region
End Namespace

