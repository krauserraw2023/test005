Namespace Registro
    Public Class InternoDomicilio
        Public Property Codigo As Integer = -1
        Public Property InternoId As Integer = -1
        'Public Property SedeInternoId As Integer = -1
        Public Property IngresoId As Integer = -1
        Public Property DepartamentoId As Integer = -1
        Public Property ProvinciaId As Integer = -1
        Public Property DistritoId As Integer = -1
        Public Property LugarReferencial As String = ""
        Public Property Direccion As String = ""
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1
        Public Property SedeRowId As Integer = -1
        '-------------- auxiliares -------------
        Public Property DepartamentoStr As String = ""
        Public Property ProvinciaStr As String = ""
        Public Property DistritoStr As String = ""
        Public Property IngresoInpeId As Integer = -1
        Public Property NumIngreso As Integer = 0
        Public Property IngresoNroInpe As String = ""
        Public ReadOnly Property UbigeoDireccion() As String
            Get
                Return Me.DepartamentoStr & "/" & Me.ProvinciaStr & "/" & Me.DistritoStr
            End Get
        End Property

    End Class

    Public Class InternoDomicilioCol
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
        Public Function Add(ByVal obj As InternoDomicilio) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoDomicilio(ByVal Index As Integer) As InternoDomicilio
            Get
                Return CType(MyBase.List(Index), InternoDomicilio)
            End Get
        End Property
    End Class
End Namespace