Namespace Visita
    Public Class ConfigHuella
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property Fecha() As Long = 0
        Public Property Estado() As Integer = -1
        Public Property FechaBaja() As Long = 0
        Public Property IDUsuarioBaja() As Integer = -1
        Public Property MotivoBaja() As String = ""
        Public Property FechaAlta() As Long = 0
        Public Property IDUsuarioAlta() As Integer = -1
        Public Property SolucionAlta() As String = ""
        Public Property IDRegion() As Short = -1
        Public Property IDPenal() As Short = -1
#End Region
    End Class
#Region "ConfigHuellaCol"
    Public Class ConfigHuellaCol
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
        Public Function Add(ByVal value As ConfigHuella) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As ConfigHuella) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As ConfigHuella) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As ConfigHuella)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As ConfigHuella
            Get
                Return DirectCast(List(index), ConfigHuella)
            End Get
            Set(ByVal value As ConfigHuella)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As ConfigHuella)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As ConfigHuella
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace