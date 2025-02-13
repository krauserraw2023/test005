Namespace Registro
    Public Class InternoMovimiento
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property FlagTransferenciaSede As Integer = 0
        'Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property IngresoNro() As Integer = 0
        Public Property IngresoInpeId As Integer = -1
        Public Property DocumentoTipoID() As Integer = -1
        Public Property DocumJudicialID() As Integer = -1
        Public Property DocumJudicialNum() As String = ""
        Public Property DocumJudicialFecharecepcion() As Long = 0
        Public Property DocumJudicialFecha() As Long = 0

        Public Property ExpedienteID() As Integer = -1
        Public Property ExpedienteNumero() As String = ""

        Public Property MovimientoGrupoID() As Integer = -1
        Public Property MovimientoGrupoNombre() As String = ""
        Public Property MovimientoTipoID() As Integer = -1
        Public Property MovimientoTipoNombre() As String = ""
        Public Property LibertadSubtipo() As String = ""
        Public Property MovimientoMotivoID() As Integer = -1
        Public Property MovimientoSubMotivoID() As Integer = -1
        Public Property MovimientoSubTipo() As String = ""
        Public Property MovimientoMotivoNombre() As String = ""
        Public Property ExpedienteFechaDocRecepcion() As Long = 0
        Public Property ExpedienteFecha() As Long = 0
        Public Property Fecha() As Long = 0
        Public ReadOnly Property FechaStr() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
            End Get
        End Property


        Public Property FechaISP() As Long = 0
        Public Property FechaRegistro() As Long = 0
        Public Property FechaInternamientoPenalOrigen() As Long = 0

        Public Property OrigenDestinoTipo As Boolean
        Public Property RegionOrigenID() As Integer = -1
        Public Property PenalOrigenID() As Integer = -1
        Public Property RegionDestinoID() As Integer = -1
        Public Property PenalDestinoID() As Integer = -1
        Public Property EstadoPenalDestinoID() As Integer = -1 'estado del movimiento del interno para traslados, 0=Pendiente(pendiente de recepcion en el ep destino), 1=confirmado(interno ingresó al ep destino)
        Public Property OrigenNombre() As String = ""
        Public Property DestinoNombre() As String = ""
        Public Property EstadoID() As Integer = -1
        Public Property EstadoTramiteID() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""
                Select Case EstadoID
                    Case Type.enumeracion.Movimiento.enmEstadoMovimiento.Pendiente
                        value = "PENDIENTE"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.EnProceso
                        value = "EN PROCESO"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.Terminado
                        value = "TERMINADO"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.EnDesarrollo
                        value = "EN DESARROLLO"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.EgresoTemporal
                        value = "EGRESO TEMPORAL"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.EgresoDifinitivo
                        value = "EGRESO DEFINITIVO DEL INTERNO"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion1
                        value = "NO TERMINADO/Por no ser recibido en hospital mental destino"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion2
                        value = "NO TERMINADO/Por orden judicial"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion3
                        value = "NO TERMINADO/Pendiente de ejecución, por tener otros procesos vigentes."

                End Select

                Return value
            End Get
        End Property
        Public Property EstadoNombreTramite() As String = ""

        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalNombre() As String

        Public Property Observacion() As String = ""
        Public Property FechaFallecimiento() As Long = 0

        Public Property PeriodoRetorno() As String = ""
        Public Property PeriodoTipo() As Integer = 0
        Public Property FechaRetorno() As Long = 0

        Public Property TipoAutoridadJudicialID As Integer = -1
        Public Property AutoridadJudicialID As Integer = -1
        Public Property SalaJudicialID As Integer = -1
        Public Property AutoridadJudicialNombre As String = ""
        Public Property SalaJudicialNombre As String = ""
        Public Property SituacionJuridicaNombre As String = ""
        Public Property DocJudJuez As String = ""
        Public Property DocJudSecretario As String = ""
        Public Property OtraAutoridadNombre As String = ""
        Public Property OtraAutoridadCargo As String = ""
        Public Property DocJudObservacion As String = ""
        Public Property DelitoGenericoNombre As String = ""
        Public Property DelitoEspecificoNombre As String = ""
        Public Property MovimientoRetorno As Boolean = False

        Public Property FechaIngresoIni As Long = 0
        Public Property FechaIngresoFin As Long = 0
        Public Property _Clasificacion As Boolean = False
        '---------------------------------------
        Public Property EstadoBloqueoId As Integer = 0 'para bloquear al interno en un penal cuando sea trasladado
        Public Property FechaCreaRegistro As Long = 0 'fecha de creacion de registro
        Public Property DocJudicialReferencia_OTHSM As Integer = -1
        Public Property Establecimientomental() As String = ""
        Public Property Estado_Ejecucion_Ejecutado As Integer = -1
        Public Property Movimiento_Observacion_Estado_Ejecucion_IM As String = ""
#End Region
#Region "Propiedades_Interno"
        Public Property CodigoRP() As String = ""
        Public Property ApellidoPaterno() As String = ""
        Public Property ApellidoMaterno() As String = ""        
        Public ReadOnly Property GrillaApellidosNombres() As String
            Get
                Dim value As String = ""

                value = Me.ApellidoPaterno & " " & Me.ApellidoMaterno & ", " & Me.Nombres

                Return value
            End Get
        End Property
        Public Property Nombres() As String = ""
        Public Property NacionalidadID() As Integer = -1
        Public Property NacionalidadNombre() As String = ""
        Public Property ApellidosNombres() As String
        Public Property Sexo() As String = ""
#End Region
#Region "Propiedades_Clasificacion"
        Public Property ClasificacionNumero As Integer = 0
        Public Property ClasificacionFecha As Long = 0
        Public Property ClasificacionPenalNombre As String = ""
        Public Property ClasificacionPenalOficio As String = ""
#End Region
    End Class

#Region "MovimientoCol"
    Public Class InternoMovimientoCol
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
        Public Function Add(ByVal obj As InternoMovimiento) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoMovimiento(ByVal Index As Integer) As InternoMovimiento
            Get
                Return CType(MyBase.List(Index), InternoMovimiento)
            End Get
        End Property
    End Class
#End Region
End Namespace


