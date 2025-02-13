Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoPabellon_BE
        Public Property Codigo As Integer = -1
        Public Property IDInterno As Integer = -1
        Public Property IDIngreso As Integer = -1
        Public Property IDIngresoInpe As Integer = -1
        Public Property FechaClasificacionRegimen As Long = 0
        Public ReadOnly Property FechaClasificacionRegimenCadena As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaClasificacionRegimen, True)
            End Get
        End Property
        Public Property FechaClasificacionEtapa As Long = 0
        Public ReadOnly Property FechaClasificacionEtapaCadena As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaClasificacionEtapa, True)
            End Get
        End Property
        Public Property TipoProcesoClasificacion As String = "" 'Tipo de proceso de clasificacion, PC=Proceso completo (proceso regimen y etapa), PE=proceso solo etapa (sin regimen, aplicable para LM)
        Public Property IDSituacionJuridica As Short = -1
        Public ReadOnly Property SituacionJuridicaNombre As String
            Get
                Dim value As String = ""

                Select Case Me.IDSituacionJuridica
                    Case 1
                        value = "PROCESADO"
                    Case 2
                        value = "SENTENCIADO"
                End Select

                Return value
            End Get
        End Property

        Public Property IDFichaRegimen As Integer = -1
        Public Property IDFichaEtapa As Integer = -1
        Public Property IDRegimen As Short = -1
        Public ReadOnly Property RegimenNombre As String
            Get
                Dim value As String = ""
                Select Case Me.IDRegimen
                    Case 1
                        value = "ORDINARIO"
                    Case 2
                        value = "ESPECIAL"
                End Select
                Return value
            End Get
        End Property

        Public Property IDEtapa As Short = -1
        Public ReadOnly Property EtapaNombre As String
            Get
                Dim value As String = ""

                Select Case Me.IDEtapa
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

        Public Property NumeroClasificacionRegimen As Short = 0
        Public Property NumeroClasificacionEtapa As Short = 0
        Public Property IDPabellon As Integer = -1
        Public Property PabellonNombre As String = ""
        Public Property Estado As Short = -1
        Public ReadOnly Property EstadoNombre As String
            Get
                Dim value As String = ""
                Select Case Me.Estado
                    Case 1
                        value = "PENDIENTE"
                    Case 2
                        value = "FINALIZADO"
                End Select
                Return value
            End Get
        End Property
        Public Property Piso As String = ""
        Public Property Ambiente As String = ""
        Public Property AlaId As Integer = -1
        Public Property Ala As String = ""
        Public Property Cama As String = ""
        Public Property Observacion As String = ""
        Public Property IDRegion As Short = -1
        Public Property IDPenal As Short = -1

    End Class

End Namespace
