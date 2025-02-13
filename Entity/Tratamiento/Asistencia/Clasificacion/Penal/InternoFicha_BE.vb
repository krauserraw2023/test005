Imports Type.Enumeracion.Clasificacion
Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoFicha_BE
        Public Property Codigo As Long = -1
        Public Property CodigoPadre As Long = -1 'referencia recursivo (lo mismo que FKCodigo))
        Public Property IDInterno As Long = -1
        Public Property IDInternoIngreso As Long = -1
        Public Property IDInternoIngresoInpe As Long = -1
        Public Property InternoIngresoNro As Short = 0
        Public Property IDRegion As Short = -1
        Public Property IDPenal As Short = -1
        Public Property IDFicha As Short = -1
        Public Property FichaNombre As String = ""
        Public Property FichaGrupo As Short = -1
        Public Property FichaGrupoLista As String = ""
        Public Property PerteneceOrgCriminal As String = "" 'S=Si pertenece, N=No pertenece
        Public Property FechaClasificacion As Long = 0
        Public ReadOnly Property FechaClasificacionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaClasificacion, True)
            End Get
        End Property
        Public Property Observacion As String = ""
        Public Property Estado As Short = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim str As String = ""
                Select Case Me.Estado
                    Case enmEstadoRegistroFicha.Bloqueado
                        str = "BLOQUEADO"
                    Case enmEstadoRegistroFicha.Finalizado
                        str = "FINALIZADO"
                    Case enmEstadoRegistroFicha.Pendiente
                        str = "PENDIENTE"
                End Select
                Return str
            End Get
        End Property
        Public Property Puntaje As Short = 0
        Public Property NumeroClasificacion As Short = 0
        Public Property IDFichaTipo As Short = -1
        Public Property FichaTipoNumOrden As Short = 0
        Public Property MotivoCambio As String = ""
        Public Property PenalNombre As String = ""
#Region "Propiedades_Interno"
        Public Property InternoPrimerApellido As String = ""
        Public Property InternoSegundoApellido As String = ""
        Public Property InternoNombres As String = ""
        Public Property InternoIDSituacionJuridica As Short = -1
        Public ReadOnly Property InternoSituacionJuridicaNombre As String
            Get
                Dim value As String = ""

                Select Case Me.InternoIDSituacionJuridica
                    Case 1
                        value = "PROCESADO"
                    Case 2
                        value = "SENTENCIADO"
                End Select

                Return value
            End Get
        End Property
        Public Property InternoIDRegimen As Short = -1
        Public Property FechaInicioRegimen As Long = 0
        Public ReadOnly Property FechaInicioRegimenString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInicioRegimen)
            End Get
        End Property
        Public ReadOnly Property InternoRegimenNombre As String
            Get
                Dim value As String = ""
                Select Case Me.InternoIDRegimen
                    Case 1
                        value = "ORDINARIO"
                    Case 2
                        value = "ESPECIAL"
                End Select
                Return value
            End Get
        End Property
        Public Property InternoIDEtapa As Short = -1
        Public Property FechaInicioEtapa As Long = 0
        Public ReadOnly Property FechaInicioEtapaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInicioEtapa)
            End Get
        End Property
        Public ReadOnly Property InternoEtapaNombre As String
            Get
                Dim value As String = ""

                Select Case Me.InternoIDEtapa
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
#End Region
    End Class

End Namespace

