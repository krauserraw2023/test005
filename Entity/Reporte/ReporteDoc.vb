Namespace Reporte
    Public Class ReporteDoc
        Public Property Codigo As Integer = -1
        Public Property ModuloNombre As String = ""
        Public Property NombreReporte As String = ""
        Public Property NombreFisicoReporte As String = ""
        Public Property NumeroReporte As Integer = 0
        Public Property NumeroExpediente As String = ""
        Public Property DepartamentoNombre As String = ""
        Public Property MudloNombreCorto As String = ""
        Public Property Version As String = ""
        Public Property Acta As String = ""
        Public Property TipoReporteId As Integer = -1
    End Class

    Public Class ReporteDocCol
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
        Public Function Add(ByVal obj As ReporteDoc) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property ReporteDoc(ByVal Index As Integer) As ReporteDoc
            Get
                Return CType(MyBase.List(Index), ReporteDoc)
            End Get
        End Property
    End Class
End Namespace