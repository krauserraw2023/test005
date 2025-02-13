Namespace Visita.Programacion
    Public Class CalendarioDetalle
        Inherits Entity.Visita.Programacion.Calendario
#Region "Propiedades"
        Public Property CalendarioDetalleID() As Integer = -1
        Public Property FechaInicio() As Long = 0
        Public Property FechaFin As Long = 0
        Public Property FechaFinIndeterminado As Boolean = False
        Public ReadOnly Property FechaFinSinFecha As String
            Get
                Dim value As String = ""
                If Me.FechaFinIndeterminado = True Then
                    value = "Fec. Ind."
                Else
                    value = Legolas.Components.FechaHora.FechaString(FechaFin)
                End If
                Return value
            End Get
        End Property
        Public Property FrecuenciaID() As Integer = -1
        Public ReadOnly Property FrecuenciaReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.FrecuenciaID
                    Case 1 'diario
                        value = "Diario"
                    Case 2 'semanal
                        value = "Semanal"
                    Case 3 'mensual
                        value = "Mensual"
                End Select
                Return value
            End Get
        End Property
        Public Property FrecuenciaRepeticion() As Integer = -1
        Public Property DiaLunes() As Boolean = False
        Public Property DiaMartes() As Boolean = False
        Public Property DiaMiercoles() As Boolean = False
        Public Property DiaJueves() As Boolean = False
        Public Property DiaViernes() As Boolean = False
        Public Property DiaSabado() As Boolean = False
        Public Property DiaDomingo() As Boolean = False
        Public Property MesArray() As String = ""
        Public Property MesTipo() As Integer = -1
        Public Property MesDiaArray() As String = ""
        Public Property MesElArray() As String = ""
        Public Property MesDiaSemanaArray() As String = ""
        Public ReadOnly Property Programacion() As String
            Get
                Dim value As String = ""

                Select Case Me.FrecuenciaID
                    Case 1 'diario

                        Dim strFechaIni As String = Legolas.Components.FechaHora.FechaString(FechaInicio)
                        Dim strFechaFin As String = Legolas.Components.FechaHora.FechaString(FechaFin)

                        value = "Del " & strFechaIni & " Hasta " & strFechaFin

                    Case 2 'semanal

                        Dim strDias As String = ""

                        If Me.DiaLunes = True Then
                            strDias = "Lun, "
                        End If

                        If Me.DiaMartes = True Then
                            strDias = strDias & "Mar, "
                        End If

                        If Me.DiaMiercoles = True Then
                            strDias = strDias & "Mie, "
                        End If

                        If Me.DiaJueves = True Then
                            strDias = strDias & "Jue, "
                        End If

                        If Me.DiaViernes = True Then
                            strDias = strDias & "Vie, "
                        End If

                        If Me.DiaSabado = True Then
                            strDias = strDias & "Sab, "
                        End If

                        If Me.DiaDomingo = True Then
                            strDias = strDias & "Dom"
                        End If

                        value = strDias

                    Case 3 'mensual

                        Dim strMes As String = ""

                        strMes = Legolas.Components.FechaHora.MesNombre(Me.MesArray)
                        strMes = strMes & " (" & Me.MesDiaArray & ")"

                        value = strMes

                End Select

                Return value
            End Get
        End Property
        Public Property HoraInicio() As Integer = -1
        Public ReadOnly Property HoraInicioReadonly() As String
            Get
                Dim value As String = ""

                If Me.HoraInicio < 1 Then
                    Return value
                End If

                Dim intHora As Integer = 0
                Dim intMinuto As Integer = 0

                intHora = Me.HoraInicio \ 60
                intMinuto = ((Me.HoraInicio / 60) - intHora) * 60

                value = Legolas.Components.Cadena.Format(intHora.ToString, "00") & ":" & Legolas.Components.Cadena.Format(intMinuto, "00")

                Return value
            End Get

        End Property
        Public Property HoraFin() As Integer = -1
        Public ReadOnly Property HoraFinReadonly() As String
            Get
                Dim value As String = ""

                If Me.HoraFin < 1 Then
                    Return value
                End If

                Dim intHora As Integer = 0
                Dim intMinuto As Integer = 0

                intHora = Me.HoraFin \ 60
                intMinuto = ((Me.HoraFin / 60) - intHora) * 60

                value = Legolas.Components.Cadena.Format(intHora.ToString, "00") & ":" & Legolas.Components.Cadena.Format(intMinuto, "00")

                Return value
            End Get

        End Property
        Public Property Duracion() As Integer = -1
        Public Property SexoID() As Integer = -1
        Public ReadOnly Property Sexo() As String
            Get
                Dim value As String = ""
                Select Case Me.SexoID
                    Case 0 'Femenino
                        value = "Mujeres"
                    Case 1 'Masculino
                        value = "Varones"
                    Case 10 'masculino, feminino
                        value = "Ambos"
                End Select
                Return value
            End Get
        End Property
        Public Property InternoID As Integer = -1
        Public Property InternoApellidosyNombres As String = ""
        Public Property LimiteVisita() As Boolean = False
        Public Property LimiteVisitaCantidad() As Integer = -1
        Public Property FamiliaConsanguidad() As Boolean = False
        Public Property FamiliaConsanguidadCantidad() As Integer = -1
        Public Property FamiliaConsanguidadGrado() As Integer = -1
        Public Property FamiliaAfinidad() As Boolean = False
        Public Property FamiliaAfinidadCantidad() As Integer = -1
        Public Property FamiliaAfinidadGrado() As Integer = -1
        Public Property IncluyeConyugueConcubina() As Boolean = False
        Public Property IncluyeAmigo() As Boolean = False
        Public Property IncluyeAbogado() As Boolean = False
        Public Property VisitanteRegistradoPreviamente As Boolean = False
        Public Property DetalleEstado As Integer = -1
        Public Property HabilitarRangoEdad As Boolean = False
        Public Property EdadInicio As Short = -1
        Public Property EdadFin As Short = -1
#End Region
    End Class
#Region "CalendarioDetalleCol"
    Public Class CalendarioDetalleCol
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
        Public Function Add(ByVal value As CalendarioDetalle) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As CalendarioDetalle) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As CalendarioDetalle) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As CalendarioDetalle)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As CalendarioDetalle
            Get
                Return DirectCast(List(index), CalendarioDetalle)
            End Get
            Set(ByVal value As CalendarioDetalle)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As CalendarioDetalle)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As CalendarioDetalle
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace