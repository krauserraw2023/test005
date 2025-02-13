Namespace Registro
    Public Class InternoFoto
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property FotoTipo() As Integer = -1
        Public Property PIzquierdoID() As Integer = -1
        Public Property PIzquierdoName() As String = ""
        Public Property PIzquierdoPath() As String = ""
        Public Property PIzquierdoServerPath() As String = ""
        Public Property PFrenteID() As Integer = -1
        Public Property PFrenteName() As String = ""
        Public Property PFrentePath() As String = ""
        Public Property PFrenteServerPath() As String = ""
        Public Property PDerechoID() As Integer = -1
        Public Property PDerechoName() As String = ""
        Public Property PDerechoPath() As String = ""
        Public Property PDerechoServerPath() As String = ""
        Public Property Fecha() As Long = 0
        Public ReadOnly Property FechaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Fecha)
            End Get
        End Property
        Public ReadOnly Property FechaHoraString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Fecha, True).ToString
            End Get
        End Property
        Public Property InternoIngresoId() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property NumIngreso() As String = ""
        Public Property PenalId() As Integer = -1
        Public Property RegionId() As Integer = -1
        Public Property FotoVersionNueva() As Boolean = False

#End Region
    End Class
#Region "InternoFotoCol"
    Public Class InternoFotoCol
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
        Public Function Add(ByVal obj As InternoFoto) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Internofoto(ByVal Index As Integer) As InternoFoto
            Get
                Return CType(MyBase.List(Index), InternoFoto)
            End Get
        End Property
        Public Function CloneCol() As InternoFoto
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace