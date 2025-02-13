Namespace Tratamiento.TallerAsistencia
    Public Class Calendario
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property IDRegion() As Integer = -1
        Public Property IDPenal() As Integer = -1
        Public Property Nombre() As String = ""
        Public Property Anio() As Integer = -1
        Public Property Mes() As Integer = -1
        Public Property Dia() As Integer = -1
        Public Property Tipo() As Integer = -1
        Public ReadOnly Property TipoDiaNoLabStr As String
            Get
                Dim v As String = ""
                Select Case Tipo
                    Case 1
                        v = "FERIADO ANUAL"'feriado todo los años 25 dic, 01 enero, etc
                    Case 2
                        v = "FERIADO DIFERIDO"'feriados con fechas cambiantes, fecha de semana santa, dia de la madre, etc
                    Case 3
                        v = "FERIADO ESPECIFICO" 'feriado de fecha especifica, ejm. aniversario ep
                End Select
                Return v
            End Get
        End Property
        Public Property Obs() As String = ""
#End Region
    End Class
#Region "CalendarioCol"
    Public Class CalendarioCol
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
        Public Function Add(ByVal value As Calendario) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Calendario) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Calendario) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Calendario)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Calendario
            Get
                Return DirectCast(List(index), Calendario)
            End Get
            Set(ByVal value As Calendario)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Calendario)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Calendario
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace