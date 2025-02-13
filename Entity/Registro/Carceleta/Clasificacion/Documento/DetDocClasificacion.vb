Namespace Clasificacion.Documento
    'tabla tra_asi_mov_det_documento
    Public Class DetDocClasificacion
        Public Property ID_CLASS() As String = "" 'id unico de clase
        Public Property OBJ_ELIMINADO() As Boolean = False  'id unico de clase

        Public Property Codigo As Integer = -1
        Public Property DocClasificacionId As Integer = -1
        Public Property InternoFichaId As Integer = -1 'fincha final
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1

        'auxiliares
        Public Property CodigoInterno As String = ""
        Public Property ApePatInterno As String = ""
        Public Property ApeMatInterno As String = ""
        Public Property NomInterno As String = ""
        Public ReadOnly Property NombresInterno As String
            Get
                Return Me.ApePatInterno & " " & Me.ApeMatInterno & ", " & Me.NomInterno
            End Get
        End Property
        Public Property NumIngreso As Integer = 0
        Public Property FechaClasificacion As Long = 0
        Public ReadOnly Property FechaClasificacionString As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaClasificacion)
            End Get
        End Property
        Public Property PenalDestinoNombre As String = ""
        Public Property InternoId As Integer = -1
        Public Sub New()
            ID_CLASS = System.Guid.NewGuid().ToString
            OBJ_ELIMINADO = False
        End Sub
    End Class
    Public Class DetDocClasificacionCol
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
        Public Function Add(ByVal obj As DetDocClasificacion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property DetDocClasificacion(ByVal Index As Integer) As DetDocClasificacion
            Get
                Return CType(MyBase.List(Index), DetDocClasificacion)
            End Get
        End Property

        Public Function DataSource() As List(Of DetDocClasificacion)
            Dim L As New List(Of DetDocClasificacion)
            For Each obj As DetDocClasificacion In InnerList
                L.Add(obj)
            Next
            Return L.FindAll(Function(c) (c.OBJ_ELIMINADO = False))
        End Function

    End Class
End Namespace