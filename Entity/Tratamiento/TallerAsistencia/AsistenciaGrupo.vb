
Namespace Tratamiento.TallerAsistencia
    Public Class AsistenciaGrupo
#Region "Propiedades"

        Public Property Codigo As Integer = -1
        Public Property CodigoTaller As Integer = -1
        Public Property Nombre As String = ""
        Public Property Descripcion As String = ""
        Public Property FechaInicio As Long = 0
        Public Property FechaFin As Long = 0
        Public Property HoraEntrada As String = ""
        Public Property HoraSalida As String = ""
        Public Property CodigoHorario As Integer = -1
        '-----------------------------
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property Contador() As Integer = -1
        Public Property Tipo As Boolean = False

        Public Property EstadoID() As Integer = -1
        Public Property InternoHuellaID() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value.ToUpper
            End Get
        End Property
       
        Public ReadOnly Property EstadoSolicitudNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 1
                        value = "PENDIENTE"
                    Case 2
                        value = "ENVIADO"
                    Case 3
                        value = "ATENDIDO"
                End Select

                Return value
            End Get
        End Property
       
        Public Property Email() As String = ""
        Public Property EstadoRncID As Integer = -1

        Public ReadOnly Property EstadoRnc As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoRncID
                    Case 1
                        value = "VAL" 'validado
                    Case 2
                        value = "OBS" 'observado
                    Case 3
                        value = "NEC" 'no encontrado
                End Select
                Return value
            End Get
        End Property
        Public Property EstadoEspecificoID As Integer = -1
        'Public Property EstadoEspecificoNombre As Integer = -1
        Public ReadOnly Property EstadoEspecificoNombre As String
            Get
                Dim value As String = ""
                'If Me.CodigoRP = "" Then
                '    value = ""
                'Else
                Select Case Me.EstadoEspecificoID
                    Case 1
                        value = "RECLUIDO"
                    Case 2
                        value = "FUGA"
                    Case 3
                        value = "FALLECIDO"
                    Case 4
                        value = "EN CONDUCCION"
                    Case 5
                        value = "CON LIBERTAD"
                    Case 6
                        value = "EN TRASLADO"
                    Case 7
                        value = "Pendiente de Egreso"
                    Case 0, -1
                        value = "NO REGISTRA"
                    Case Else
                        value = ""
                End Select
                'End If
                Return value
            End Get
        End Property
        Public Property TipoPoblacion As String = "43"
        Public Property FechaInicioBusqueda As Long = 0
        Public Property FechaFinBusqueda As Long = 0
        Public Property Anio As Integer = -1
        Public Property Mes As Integer = -1

        Public Property IngresoSistemaPen As Long = 0
        Public Property Eliminado As Integer = 0
        Public Property NumeroDocumentoAux As String = ""
        Public Property Idioma() As String = ""

        '------- agregados 2017
        Public Property GeneroId As Integer = -1
        Public Property IdiomaNativoId As Integer = -1


#Region "Ubicacion"
        Private strPenalNombre As String = ""
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property RegionCodigo() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalCodigo() As String = ""
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property RegionRegistroID() As Integer = -1
        Public Property PenalRegistroID() As Integer = -1
        Public Property Cantidad() As Integer = 0
        Public Property Ingresos() As Integer = 0
        Public Property Egresos() As Integer = 0
        Public Property Traslados() As Integer = 0
#End Region
#End Region


#Region "Propiedades_Ingreso"
        Private intIngresoNumero As Integer = -1
        Private strTipoIngreso As String = ""
        Public Property IngresoNumero() As Integer
            Get
                Return intIngresoNumero
            End Get
            Set(ByVal value As Integer)
                intIngresoNumero = value
            End Set
        End Property
        Public Property IngresoAux() As Integer = -1
        Public Property SituacionJuridicaId() As Integer = -1
        Public Property SituacionJuridicaNom() As String = ""
        Public ReadOnly Property SituacionJuridicaReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.SituacionJuridicaId
                    Case 1
                        value = "PROC."
                    Case 2
                        value = "SENT."
                    Case 3
                        value = "SENT./PROC."
                    Case Else
                        value = ""
                End Select

                Return value

            End Get
        End Property

        Public Property MotivoIngresoID() As Integer = -1
        Public Property MotivoIngresoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoIngreso)
            End Get
            Set(ByVal value As String)
                strTipoIngreso = value
            End Set
        End Property
        Public Property MotivoTrasladoID() As Integer = -1


        Public Property Fecha() As Long = 0
        Public Property Tiempo() As Integer = 0
        Public ReadOnly Property FechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
            End Get
        End Property
        'Public ReadOnly Property FechaNacimientoStr() As String
        '    Get
        '        Dim value As String = ""
        '        If Me.FechaNacimiento > 0 Then
        '            Dim fecha As Date = Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)
        '            value = fecha.ToString("yyyyMMdd")
        '        End If
        '        Return value
        '    End Get
        'End Property
        Public Property NumeroDocumentoIngreso() As String = ""
        Public Property PenalOrigenNombre() As String = ""
        Public ReadOnly Property Permanencia() As String
            Get
                Dim Valor As String = ""
                If Me.HoraSalida = "00:00:00" Then
                    Valor = "No registra salida"
                Else
                    Dim f1 As DateTime = Me.HoraEntrada
                    Dim f2 As DateTime = Me.HoraSalida
                    Valor = DateDiff(DateInterval.Minute, f1, f2) & " min."
                End If
                Return Valor
            End Get
        End Property
#End Region
#Region "Propiedades_Filtro"
        Public Property NacionalidadExtranjero As Integer = -1
        Public Property DelitoGenericoID As Integer = -1
        Public Property DelitoEspecificoID As Integer = -1
        Public Property IngresoFechaDesde As Long = 0
        Public Property IngresoFechaHasta As Long = 0
        Public Property PenalMultiple As String = ""
        Public Property IDInternoString As String = ""
#End Region
    End Class
#Region "AsistencialGrupoCol"
    Public Class AsistencialGrupoCol
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
        Public Function Add(ByVal value As AsistenciaGrupo) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As AsistenciaGrupo) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As AsistenciaGrupo) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As AsistenciaGrupo)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As AsistenciaGrupo
            Get
                Return DirectCast(List(index), AsistenciaGrupo)
            End Get
            Set(ByVal value As AsistenciaGrupo)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As AsistenciaGrupo)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As AsistenciaGrupo
            Return MyBase.MemberwiseClone
        End Function
        Public Function toList() As List(Of AsistenciaGrupo)
            Dim a As New List(Of AsistenciaGrupo)
            For Each i As AsistenciaGrupo In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
