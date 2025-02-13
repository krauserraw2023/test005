Imports Type.Enumeracion.Tratamiento

Namespace Tratamiento.TallerAsistencia
    Public Class PlanillaDetalle
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property IDPlanilla() As Integer = -1
        Public Property IDInterno() As Integer = -1
        Public Property ApellidosNombres() As String = ""
        Public Property Dia01() As Integer = 0
        Public Property Dia02() As Integer = 0
        Public Property Dia03() As Integer = 0
        Public Property Dia04() As Integer = 0
        Public Property Dia05() As Integer = 0
        Public Property Dia06() As Integer = 0
        Public Property Dia07() As Integer = 0
        Public Property Dia08() As Integer = 0
        Public Property Dia09() As Integer = 0
        Public Property Dia10() As Integer = 0
        Public Property Dia11() As Integer = 0
        Public Property Dia12() As Integer = 0
        Public Property Dia13() As Integer = 0
        Public Property Dia_14() As Integer = 0
        Public Property Dia_15() As Integer = 0
        Public Property Dia_16() As Integer = 0
        Public Property Dia_17() As Integer = 0
        Public Property Dia_18() As Integer = 0
        Public Property Dia_19() As Integer = 0
        Public Property Dia_20() As Integer = 0
        Public Property Dia_21() As Integer = 0
        Public Property Dia_22() As Integer = 0
        Public Property Dia_23() As Integer = 0
        Public Property Dia_24() As Integer = 0
        Public Property Dia_25() As Integer = 0
        Public Property Dia_26() As Integer = 0
        Public Property Dia_27() As Integer = 0
        Public Property Dia_28() As Integer = 0
        Public Property Dia_29() As Integer = 0
        Public Property Dia_30() As Integer = 0
        Public Property Dia_31() As Integer = 0
        Public Property TotalDias() As Integer = 0
        Public Property IngresoTotal() As Decimal = 0
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property NumeroDocumento As String = ""
        Public Property Observacion As String = ""
        Public Property MotivoRetiroID() As Integer = -1
        Public Property FechaIniRetiro() As Long = 0
        Public Property FechaFinRetiro() As Long = 0
        Public ReadOnly Property StrDia01() As String
            Get
                Dim v As String = ""

                Select Case Dia01
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia02() As String
            Get
                Dim v As String = ""

                Select Case Dia02
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia03() As String
            Get
                Dim v As String = ""

                Select Case Dia03
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia04() As String
            Get
                Dim v As String = ""

                Select Case Dia04
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia05() As String
            Get
                Dim v As String = ""

                Select Case Dia05
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia06() As String
            Get
                Dim v As String = ""

                Select Case Dia06
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia07() As String
            Get
                Dim v As String = ""

                Select Case Dia07
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia08() As String
            Get
                Dim v As String = ""

                Select Case Dia08
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia09() As String
            Get
                Dim v As String = ""

                Select Case Dia09
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia10() As String
            Get
                Dim v As String = ""

                Select Case Dia10
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia11() As String
            Get
                Dim v As String = ""

                Select Case Dia11
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia12() As String
            Get
                Dim v As String = ""

                Select Case Dia12
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia13() As String
            Get
                Dim v As String = ""

                Select Case Dia13
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia14() As String
            Get
                Dim v As String = ""

                Select Case Dia_14
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia15() As String
            Get
                Dim v As String = ""

                Select Case Dia_15
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia16() As String
            Get
                Dim v As String = ""

                Select Case Dia_16
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia17() As String
            Get
                Dim v As String = ""

                Select Case Dia_17
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia18() As String
            Get
                Dim v As String = ""

                Select Case Dia_18
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia19() As String
            Get
                Dim v As String = ""

                Select Case Dia_19
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia20() As String
            Get
                Dim v As String = ""

                Select Case Dia_20
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia21() As String
            Get
                Dim v As String = ""

                Select Case Dia_21
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia22() As String
            Get
                Dim v As String = ""

                Select Case Dia_22
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia23() As String
            Get
                Dim v As String = ""

                Select Case Dia_23
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia24() As String
            Get
                Dim v As String = ""

                Select Case Dia_24
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia25() As String
            Get
                Dim v As String = ""

                Select Case Dia_25
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia26() As String
            Get
                Dim v As String = ""

                Select Case Dia_26
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia27() As String
            Get
                Dim v As String = ""

                Select Case Dia_27
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia28() As String
            Get
                Dim v As String = ""

                Select Case Dia_28
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia29() As String
            Get
                Dim v As String = ""

                Select Case Dia_29
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia30() As String
            Get
                Dim v As String = ""

                Select Case Dia_30
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property
        Public ReadOnly Property StrDia31() As String
            Get
                Dim v As String = ""

                Select Case Dia_31
                    Case enmMotivoDetallePlanilla.Falta
                        v = "F" 'faltó
                    Case enmMotivoDetallePlanilla.Asistio
                        v = "A" 'asistió
                    Case enmMotivoDetallePlanilla.Diligenciasjudiciales, enmMotivoDetallePlanilla.Diligenciashospitalarias
                        v = "D" 'falta justificada
                    Case enmMotivoDetallePlanilla.Atenciónmédica
                        v = "H" 'falta justificada
                    Case enmMotivoDetallePlanilla.Tratamientopenitenciario
                        v = "T" 'falta justificada
                    Case enmMotivoDetallePlanilla.Entrevistaabogado
                        v = "E" 'falta justificada
                    Case enmMotivoDetallePlanilla.Faltadisciplinaria
                        v = "S" 'falta justificada
                    Case enmMotivoDetallePlanilla.Libertad, enmMotivoDetallePlanilla.SancionDisciplinaria,
                         enmMotivoDetallePlanilla.Faltas02Consecutivas, enmMotivoDetallePlanilla.Faltas04InjustificadasMes,
                         enmMotivoDetallePlanilla.Endeudamiento, enmMotivoDetallePlanilla.Traslado, enmMotivoDetallePlanilla.SolicitudInterno
                        v = "---" 'Retirado del Taller
                    Case enmMotivoDetallePlanilla.Feriado, enmMotivoDetallePlanilla.DiaNoLaboral
                        v = "X" 'Feriado y dias no laborales
                    Case Else
                        v = ""
                End Select

                Return v
            End Get
        End Property

#End Region
    End Class
#Region "PlanillaDetalleCol"
    Public Class PlanillaDetalleCol
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
        Public Function Add(ByVal value As PlanillaDetalle) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As PlanillaDetalle) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As PlanillaDetalle) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As PlanillaDetalle)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As PlanillaDetalle
            Get
                Return DirectCast(List(index), PlanillaDetalle)
            End Get
            Set(ByVal value As PlanillaDetalle)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As PlanillaDetalle)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As PlanillaDetalle
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace