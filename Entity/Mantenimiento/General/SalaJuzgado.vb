Namespace Mantenimiento
    Public Class SalaJuzgado
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property DistritoJudID() As Integer = -1
        Public Property DistritoJudicialNombre() As String = ""
        Public Property DistritoJudCodigo() As String = ""
        Public Property SalaCodigo() As String = ""
        Public Property Nombre() As String = ""
        Public Property NombreCorto() As String = ""
        Public Property Estado() As Short = -1
        Public Property Eliminado As Boolean = False
        Public Property JurisdiccionId As Integer
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim strValue As String = ""

                Select Case Estado
                    Case 0
                        strValue = "Historico"
                    Case 1
                        strValue = "Vigente"
                    Case 100
                        strValue = "Inactivo"
                End Select

                Return strValue.ToUpper
            End Get
        End Property
#End Region
    End Class
#Region "SalaJuzgadoCol"
    Public Class SalaJuzgadoCol
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
        Public Function Add(ByVal obj As SalaJuzgado) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Sala(ByVal Index As Integer) As SalaJuzgado
            Get
                Return CType(MyBase.List(Index), SalaJuzgado)
            End Get
        End Property
        Public Function CloneCol() As SalaJuzgado
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace