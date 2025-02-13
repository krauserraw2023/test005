Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoFichaOtro_BE
        Public Property Codigo As Integer = -1
        Public Property InternoId As Integer = -1
        Public Property IngresoId As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property TipoFichaId As Integer = -1
        Public Property Causal As String = ""
        Public Property CausalId As Integer = -1
        Public Property ResolAutorizacion As String = ""
        Public Property FechaResolucion As Long = 0
        Public ReadOnly Property FechaResolucionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaResolucion)
            End Get
        End Property
        Public Property FechaTraslado As Long = 0
        Public ReadOnly Property FechaTrasladoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaTraslado)
            End Get
        End Property
        Public Property RegionDestinoId As Integer = -1
        Public Property PenalDestinoId As Integer = -1
        Public Property PenalDestinoNom As String = ""
        Public Property RegionOrigenId As Integer = -1
        Public Property PenalOrigenId As Integer = -1
        Public Property PenalOrigenNom As String = ""
        Public Property RegimenId_PenalOrigen As Integer = -1
        Public Property RegimenNombre_PenalOrigen As String = ""
        Public Property EtapaId_PenalOrigen As Integer = -1
        Public Property EtapaNombre_PenalOrigen As String = ""
        Public Property InternoPenalFichaId As Integer = -1
        Public Property Ambiente As String = ""
        Public Property AleroId As Integer = -1
        Public Property Cama As String = ""
        Public Property PabellonId As Integer = -1
        Public Property PabellonNombre As String = ""
        Public Property Estado As Byte = 0
        Public Property EstadoClasificacionUbicacionOTT As Byte = 0

        Public ReadOnly Property EstadoClasificacionUbicacionOTTNom As String
            Get
                Dim value As String = ""
                Select Case Me.EstadoClasificacionUbicacionOTT
                    Case 0
                        value = "PENDIENTE"
                    Case 1
                        value = "FINALIZADO"
                    Case 3
                        value = "BLOQUEADO"
                End Select
                Return value
            End Get
        End Property
        Public Property IdRegion As Integer = -1
        Public Property IdPenal As Integer = -1

        Public ReadOnly Property EstadoNombre As String
            Get
                Dim value As String = ""
                Select Case Me.Estado
                    Case 0
                        value = "PENDIENTE"
                    Case 1
                        value = "FINALIZADO"
                    Case 3
                        value = "BLOQUEADO"
                End Select
                Return value
            End Get
        End Property
        Public ReadOnly Property InternoRegimenNombre_Clasif As String
            Get
                Dim value As String = ""
                Select Case Me.RegimenId_Clasificacion
                    Case 1
                        value = "Ordinario"
                    Case 2
                        value = "Especial"
                End Select
                Return value
            End Get
        End Property
        Public ReadOnly Property InternoEtapaNombre_Clasif As String
            Get
                Dim value As String = ""

                Select Case Me.EtapaId_Clasificacion
                    Case 1
                        value = "MINIMA SEGURIDAD"
                    Case 2
                        value = "MEDIANA SEGURIDAD"
                    Case 3
                        value = "MAXIMA SEGURIDAD"
                    Case 4
                        value = "A"
                    Case 5
                        value = "B"
                    Case 6
                        value = "C"
                End Select

                Return value
            End Get
        End Property
        '********************* auxiliares ***********
        Public Property Alero As String = ""
        Public Property Piso As String = ""
        Public Property RegimenId_Clasificacion As Integer = -1
        Public Property EtapaId_Clasificacion As Integer = -1
        Public Property NumeroClasificacion As Integer = 0
        Public Property FechaClasificacion As Long = 0
        Public ReadOnly Property FechaClasificacionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaClasificacion)
            End Get
        End Property
        Public Property FechaClasificacionUbicacion As Long = 0
        Public ReadOnly Property FechaClasificacionUbicacionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaClasificacionUbicacion)
            End Get
        End Property
    End Class
End Namespace
