Namespace Registro.Carceleta.Clasificacion
    Public Class MaestroIndicador_BE
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property IndicadorMae() As Integer = -1
        Public Property FichaId() As Integer = -1
        Public Property VariableID() As Integer = -1
        Public Property Secuencia() As Integer = -1 'numero de orden(secuencia)
        Public Property Descripcion() As String = ""
        Public Property PuntajeProcesado() As Integer = 0
        Public Property PuntajeSentenciado() As Integer = 0
        Public Property Puntaje() As Integer = 0
        Public Property Calificacion() As String = ""
        Public ReadOnly Property SecuenciaString() As String
            Get
                Return String.Format(Secuencia, "00") & ".-"
            End Get
        End Property
        '------------------------------ auxiliares ----------
        Public Property NombreVariable As String = ""

#End Region
    End Class
#Region "ValoresCol"
    Public Class MaestroIndicadorCol_BE
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
        Public Function Add(ByVal obj As MaestroIndicador_BE) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property MaestroIndicador(ByVal Index As Integer) As MaestroIndicador_BE
            Get
                Return CType(MyBase.List(Index), MaestroIndicador_BE)
            End Get
        End Property
    End Class
#End Region
End Namespace
