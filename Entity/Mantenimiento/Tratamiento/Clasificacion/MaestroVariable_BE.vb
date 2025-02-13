Namespace Registro.Carceleta.Clasificacion
    Public Class MaestroVariable_BE

#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property FichaID() As Integer = -1
        Public Property VariableMaestraID() As Integer = -1
        Public Property NumeroOrden() As Integer = -1
        Public ReadOnly Property NumeroOrdenString() As String
            Get
                Return String.Format(NumeroOrden, "00") & ".- "
            End Get
        End Property
        Public Property Nombre() As String = ""
        Public Property Descripcion() As String = ""
        Public Property Puntaje() As Integer = 0
        Public Property PuntajeNoPrevisto() As Integer = 0
        Public ReadOnly Property TipoPuntaje() As Boolean
            Get
                If Me.PuntajeNoPrevisto > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
#End Region
    End Class
#Region "VariableCol"
    Public Class MaestroVariableCol_BE
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
        Public Function Add(ByVal obj As MaestroVariable_BE) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Variable(ByVal Index As Integer) As MaestroVariable_BE
            Get
                Return CType(MyBase.List(Index), MaestroVariable_BE)
            End Get
        End Property
    End Class
#End Region
End Namespace
