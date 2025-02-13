Namespace Tratamiento.TallerAsistencia
    Public Class PlanillaCabecera
        Inherits Auditoria.Transaccion
#Region "Propiedades"

        Public Property Codigo() As Integer = -1
        Public Property IDRegion() As Integer = -1
        Public Property IDPenal() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalNombre() As String = ""
        Public Property IDTaller() As Integer = -1
        Public Property TallerNombre() As String = ""
        Public Property FechaInscripcion() As Long = 0
        Public Property FechaRetiro() As Long = 0
        Public Property Anio() As Integer = -1
        Public Property Mes() As Integer = -1
        Public Property FechaInicio As Long = 0
        Public Property FechaFin As Long = 0
        Public Property Correlativo() As Integer = -1
        Public Property Pabellon As String = ""
        Public Property Observacion As String = ""
        Public Property FechaProceso As Long = 0        
        Public Property Estado() As Integer = -1
        Public ReadOnly Property NombreMes() As String
            Get
                Dim intVal As String = ""
                Select Case Mes
                    Case 1
                        intVal = "Enero"
                    Case 2
                        intVal = "Febrero"
                    Case 3
                        intVal = "Marzo"
                    Case 4
                        intVal = "Abril"
                    Case 5
                        intVal = "Mayo"
                    Case 6
                        intVal = "Junio"
                    Case 7
                        intVal = "Julio"
                    Case 8
                        intVal = "Agosto"
                    Case 9
                        intVal = "Setiembre"
                    Case 10
                        intVal = "Octubre"
                    Case 11
                        intVal = "Noviembre"
                    Case 12
                        intVal = "Diciembre"
                End Select
                Return intVal
            End Get
        End Property
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim strVal As String = ""
                Select Case Estado
                    Case 0
                        strVal = "ANULADO"
                    Case 1
                        strVal = "PROCESADO"
                    Case 2
                        strVal = "TERMINADO"
                    Case Else
                        strVal = ""
                End Select
                Return strVal
            End Get
        End Property
        Public ReadOnly Property strFechaInscripcion() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInscripcion)
            End Get
        End Property
        Public ReadOnly Property strFechaRetiro() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaRetiro)
            End Get
        End Property
#End Region
    End Class
#Region "PlanillaCabeceraCol"
    Public Class PlanillaCabeceraCol
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
        Public Function Add(ByVal value As PlanillaCabecera) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As PlanillaCabecera) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As PlanillaCabecera) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As PlanillaCabecera)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As PlanillaCabecera
            Get
                Return DirectCast(List(index), PlanillaCabecera)
            End Get
            Set(ByVal value As PlanillaCabecera)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As PlanillaCabecera)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As PlanillaCabecera
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region

End Namespace