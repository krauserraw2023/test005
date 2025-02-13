Namespace Reporte.Visita
    Public Class HistorialVisitante
        Inherits Global.Legolas.LEntity.Globall.Persona
#Region "Propiedades"
        Public Property TipoInterno As Short = -1
        Public Property InternoPrimerApellido As String = ""
        Public Property InternoSegundoApellido As String = ""
        Public Property InternoPreNombres As String = ""
        Public ReadOnly Property InternoApellidosyNombresReadonly As String
            Get
                Dim value As String = ""
                value = Me.InternoPrimerApellido & " " & Me.InternoSegundoApellido & ", " & Me.InternoPreNombres
                Return value
            End Get
        End Property
        Public Property InternoApellidosyNombres As String = ""
        Public Property NumeroPase As String = ""
        Public Property Parentesco As String = ""
        Public Property FechaIngreso As Long = 0
        Public ReadOnly Property FechaIngresoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
            End Get
        End Property
        Public Property HoraIngreso As String = ""
        Public Property FechaSalida As Long = 0
        Public ReadOnly Property FechaSalidaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaSalida)
            End Get
        End Property
        Public Property HoraSalida As String = ""
        Public ReadOnly Property Permanencia() As String
            Get
                Dim value As String = ""

                If FechaSalida > 0 Then

                    Dim day1 As DateTime = CDate(Me.FechaIngresoString).ToShortDateString + " " + Me.HoraIngreso
                    Dim day2 As DateTime = CDate(Me.FechaSalidaString).ToShortDateString + " " + Me.HoraSalida

                    Dim intMinutos As Integer = 0
                    Dim intHoras As Integer = 0
                    Dim decMin As Decimal = 0

                    '_h = DateDiff(DateInterval.Hour, day1, day2)
                    intMinutos = DateDiff(DateInterval.Minute, day1, day2)

                    If intMinutos > 60 Then
                        intHoras = intMinutos \ 60
                        decMin = Decimal.Round(((intMinutos / 60) - intHoras) * 60)
                    Else
                        decMin = Decimal.Round(intMinutos)
                    End If

                    value = intHoras.ToString + " H " + decMin.ToString + " m"
                End If

                Return value
            End Get

        End Property
#End Region
#Region "Propiedades_Par"
        Public Property Par_Region() As String = ""
        Public Property Par_Penal() As String = ""
#End Region
    End Class
    Public Class HistorialVisitanteCol
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
        Public Function Add(ByVal value As HistorialVisitante) As Integer

            Return List.Add(value)

        End Function
        Public Function Contains(ByVal value As HistorialVisitante) As Boolean

            Return List.Contains(value)

        End Function
        Public Function IndexOf(ByVal value As HistorialVisitante) As Integer

            Return List.IndexOf(value)

        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As HistorialVisitante)

            List.Insert(index, value)

        End Sub
        Default Public Property Item(ByVal index As Integer) As HistorialVisitante

            Get

                Return DirectCast(List(index), HistorialVisitante)

            End Get

            Set(ByVal value As HistorialVisitante)

                List(index) = value

            End Set

        End Property
        Public Sub Remove(ByVal value As HistorialVisitante)

            List.Remove(value)

        End Sub
    End Class

End Namespace