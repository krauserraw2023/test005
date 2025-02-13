Namespace Tratamiento.TallerAsistencia

    Public Class ProcesarPlanilla

        Public Function ProcesarPlanilla(intIDPlanilla As Integer) As Boolean

            Dim value As Boolean = False
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
            Dim objBss As New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera

            objEnt = objBss.Listar(intIDPlanilla)

            With objEnt
                value = AGenerarDetalle(intIDPlanilla, .IDTaller, .IDRegion, .IDPenal, .Anio, .Mes, .FechaInicio, .FechaFin)
            End With

            Return value

        End Function
        Private Function AGenerarDetalle(intIDPlanilla As Integer, intIDTaller As Integer, intIDRegion As Short, intIDPenal As Short,
                                          intAnio As Short, intMes As Short,
                                         FechaIni As Long, FechaFin As Long) As Boolean
            'Obtener Feriados
            Dim objCalCol As New Entity.Tratamiento.TallerAsistencia.CalendarioCol
            Dim objCalFiltro As New Entity.Tratamiento.TallerAsistencia.Calendario
            Dim bssCal As New Bussines.Tratamiento.TallerAsistencia.Calendario

            With objCalFiltro
                .Anio = intAnio
                .Mes = intMes
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
            End With
            objCalCol = bssCal.Listar(objCalFiltro)

            'Obtener Lista de Asistencia Internos por taller
            Dim objAsiCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim objBss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia

            With objEntFiltro
                .CodigoTaller = intIDTaller
                .FechaInicioBusqueda = FechaIni
                .FechaFinBusqueda = FechaFin
                .RegionID = intIDRegion
                .PenalID = intIDPenal
            End With

            objAsiCol = objBss.ListarAsistenciaInterno(objEntFiltro)

            Dim objBssPlanillaDetalle As New Bussines.Tratamiento.TallerAsistencia.PlanillaDetalle
            Try

                Dim intInternoID As Integer = -1
                Dim Ind As Integer = 0
                Dim entDet As New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
                Dim entDet2 As New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle

                For Each ent As Entity.Tratamiento.TallerAsistencia.InternoAsistencia In objAsiCol
                    Ind += 1
                    With ent
                        If ent.InternoID = intInternoID And 0 < intInternoID Then
                            entDet = InsertarDiaAsistencia(entDet, ent)
                            If Ind = objAsiCol.Count Then
                                entDet.ApellidosNombres = ent.ApellidosNombres
                                InsertarRegistroDetalle(intIDPlanilla, intIDRegion, intIDPenal, intAnio, intMes, entDet, ent, objCalCol, FechaIni, FechaFin)
                                entDet = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
                            End If
                        Else
                            If Ind > 1 Then
                                Dim ent_ As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                                ent_.InternoID = entDet2.IDInterno
                                ent_.ApellidosNombres = entDet2.ApellidosNombres
                                ent_.MotivoRetiroID = entDet2.MotivoRetiroID
                                ent_.FechaInicialRetiro = entDet2.FechaIniRetiro
                                ent_.FechaFinalRetiro = entDet2.FechaFinRetiro
                                InsertarRegistroDetalle(intIDPlanilla, intIDRegion, intIDPenal, intAnio, intMes, entDet2, ent_, objCalCol, FechaIni, FechaFin)
                                entDet2 = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
                                entDet = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
                            End If
                            intInternoID = ent.InternoID
                            entDet = InsertarDiaAsistencia(entDet, ent)
                            If Ind = objAsiCol.Count Then
                                entDet.ApellidosNombres = ent.ApellidosNombres
                                InsertarRegistroDetalle(intIDPlanilla, intIDRegion, intIDPenal, intAnio, intMes, entDet, ent, objCalCol, FechaIni, FechaFin)
                                entDet = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
                            End If
                        End If
                        entDet2 = entDet
                        entDet2.IDInterno = ent.InternoID
                        entDet2.ApellidosNombres = ent.ApellidosNombres
                        entDet2.MotivoRetiroID = ent.MotivoRetiroID
                        entDet2.FechaIniRetiro = ent.FechaInicialRetiro
                        entDet2.FechaFinRetiro = ent.FechaFinalRetiro
                    End With
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return True
        End Function
        Private Function InsertarRegistroDetalle(intIDPlanilla As Integer, intIDRegion As Short, intIDPenal As Short,
                                         intAnio As Short, intMes As Short,
                                         entDet As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle,
                                         ent As Entity.Tratamiento.TallerAsistencia.InternoAsistencia,
                                         objCol As Entity.Tratamiento.TallerAsistencia.CalendarioCol,
                                         FechaIni As Long, FechaFin As Long) As Integer
            Dim val As Integer = -1
            Dim objBssPlanillaDetalle As New Bussines.Tratamiento.TallerAsistencia.PlanillaDetalle

            entDet = ValidarSancionFeriados(intAnio, intMes, entDet, ent, objCol, FechaIni, FechaFin)
            entDet.IDPlanilla = intIDPlanilla
            entDet.IDInterno = ent.InternoID
            entDet.MotivoRetiroID = ent.MotivoRetiroID
            entDet.FechaIniRetiro = ent.FechaInicialRetiro
            entDet.FechaFinRetiro = ent.FechaFinalRetiro
            entDet.RegionID = intIDRegion
            entDet.PenalID = intIDPenal
            val = objBssPlanillaDetalle.Grabar(entDet)

            Return val
        End Function
        Private Function ValidarSancionFeriados(intAnio As Short, intMes As Short,
                                                entDet As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle,
                                         ent As Entity.Tratamiento.TallerAsistencia.InternoAsistencia,
                                         objCol As Entity.Tratamiento.TallerAsistencia.CalendarioCol,
                                         FechaIni As Long, FechaFin As Long) As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle

            Dim FechaUltimoDia As Date = Legolas.Components.FechaHora.FechaDate(FechaFin)

            If ent.MotivoRetiroID > 0 Then
                Dim DiaRetiro As Integer = Legolas.Components.FechaHora.FechaDate(ent.FechaInicialRetiro).Day
                Dim DiaRetiroFinal As Integer = Legolas.Components.FechaHora.FechaDate(ent.FechaFinalRetiro).Day
                Dim IdRetiro As Integer = -1
                Select Case ent.MotivoRetiroID
                    Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.FaltaDisciplinaria
                        '    IdRetiro = 5
                        '    For i As Integer = DiaRetiro To DiaRetiroFinal
                        '        With entDet
                        '            Select Case i
                        '                Case 1
                        '                    .Dia01 = IdRetiro
                        '                Case 2
                        '                    .Dia02 = IdRetiro
                        '                Case 3
                        '                    .Dia03 = IdRetiro
                        '                Case 4
                        '                    .Dia04 = IdRetiro
                        '                Case 5
                        '                    .Dia05 = IdRetiro
                        '                Case 6
                        '                    .Dia06 = IdRetiro
                        '                Case 7
                        '                    .Dia07 = IdRetiro
                        '                Case 8
                        '                    .Dia08 = IdRetiro
                        '                Case 9
                        '                    .Dia09 = IdRetiro
                        '                Case 10
                        '                    .Dia10 = IdRetiro
                        '                Case 11
                        '                    .Dia11 = IdRetiro
                        '                Case 12
                        '                    .Dia12 = IdRetiro
                        '                Case 13
                        '                    .Dia13 = IdRetiro
                        '                Case 14
                        '                    .Dia_14 = IdRetiro
                        '                Case 15
                        '                    .Dia_15 = IdRetiro
                        '                Case 16
                        '                    .Dia_16 = IdRetiro
                        '                Case 17
                        '                    .Dia_17 = IdRetiro
                        '                Case 18
                        '                    .Dia_18 = IdRetiro
                        '                Case 19
                        '                    .Dia_19 = IdRetiro
                        '                Case 20
                        '                    .Dia_20 = IdRetiro
                        '                Case 21
                        '                    .Dia_21 = IdRetiro
                        '                Case 22
                        '                    .Dia_22 = IdRetiro
                        '                Case 23
                        '                    .Dia_23 = IdRetiro
                        '                Case 24
                        '                    .Dia_24 = IdRetiro
                        '                Case 25
                        '                    .Dia_25 = IdRetiro
                        '                Case 26
                        '                    .Dia_26 = IdRetiro
                        '                Case 27
                        '                    .Dia_27 = IdRetiro
                        '                Case 28
                        '                    .Dia_28 = IdRetiro
                        '                Case 29
                        '                    .Dia_29 = IdRetiro
                        '                Case 30
                        '                    .Dia_30 = IdRetiro
                        '                Case 31
                        '                    .Dia_31 = IdRetiro
                        '            End Select
                        '        End With
                        '    Next
                    Case Else
                        Select Case ent.MotivoRetiroID
                            Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.Libertad
                                IdRetiro = 9
                            Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.SancionDisciplinaria
                                IdRetiro = 10
                            Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.FaltaConseInjus02
                                IdRetiro = 11
                            Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.FaltaConseInjus04
                                IdRetiro = 12
                            Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.PorEndeudamiento
                                IdRetiro = 13
                            Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.Traslado
                                IdRetiro = 14
                            Case Type.Enumeracion.Tratamiento.enmMotivoRetiro.SolicitudInterno
                                IdRetiro = 15
                        End Select

                        For i As Integer = DiaRetiro To FechaUltimoDia.Day
                            With entDet
                                Select Case i
                                    Case 1
                                        .Dia01 = IdRetiro
                                    Case 2
                                        .Dia02 = IdRetiro
                                    Case 3
                                        .Dia03 = IdRetiro
                                    Case 4
                                        .Dia04 = IdRetiro
                                    Case 5
                                        .Dia05 = IdRetiro
                                    Case 6
                                        .Dia06 = IdRetiro
                                    Case 7
                                        .Dia07 = IdRetiro
                                    Case 8
                                        .Dia08 = IdRetiro
                                    Case 9
                                        .Dia09 = IdRetiro
                                    Case 10
                                        .Dia10 = IdRetiro
                                    Case 11
                                        .Dia11 = IdRetiro
                                    Case 12
                                        .Dia12 = IdRetiro
                                    Case 13
                                        .Dia13 = IdRetiro
                                    Case 14
                                        .Dia_14 = IdRetiro
                                    Case 15
                                        .Dia_15 = IdRetiro
                                    Case 16
                                        .Dia_16 = IdRetiro
                                    Case 17
                                        .Dia_17 = IdRetiro
                                    Case 18
                                        .Dia_18 = IdRetiro
                                    Case 19
                                        .Dia_19 = IdRetiro
                                    Case 20
                                        .Dia_20 = IdRetiro
                                    Case 21
                                        .Dia_21 = IdRetiro
                                    Case 22
                                        .Dia_22 = IdRetiro
                                    Case 23
                                        .Dia_23 = IdRetiro
                                    Case 24
                                        .Dia_24 = IdRetiro
                                    Case 25
                                        .Dia_25 = IdRetiro
                                    Case 26
                                        .Dia_26 = IdRetiro
                                    Case 27
                                        .Dia_27 = IdRetiro
                                    Case 28
                                        .Dia_28 = IdRetiro
                                    Case 29
                                        .Dia_29 = IdRetiro
                                    Case 30
                                        .Dia_30 = IdRetiro
                                    Case 31
                                        .Dia_31 = IdRetiro
                                End Select
                            End With
                        Next
                End Select

            End If
            'Domingos y Feriados
            With entDet
                Dim idFer As Integer = 16
                For i As Integer = 1 To FechaUltimoDia.Day
                    Dim dia_ As String = IIf(i < 10, "0" & i, i)
                    Dim mes_ As String = IIf(intMes < 10, 0 & intMes, intMes)
                    Dim FechaDia As Date = dia_ & "/" & mes_ & "/" & intAnio
                    Dim Feriado As String = FechaDia.DayOfWeek.ToString()
                    If Feriado = "Sunday" Then
                        Select Case i
                            Case 1
                                .Dia01 = idFer
                            Case 2
                                .Dia02 = idFer
                            Case 3
                                .Dia03 = idFer
                            Case 4
                                .Dia04 = idFer
                            Case 5
                                .Dia05 = idFer
                            Case 6
                                .Dia06 = idFer
                            Case 7
                                .Dia07 = idFer
                            Case 8
                                .Dia08 = idFer
                            Case 9
                                .Dia09 = idFer
                            Case 10
                                .Dia10 = idFer
                            Case 11
                                .Dia11 = idFer
                            Case 12
                                .Dia12 = idFer
                            Case 13
                                .Dia13 = idFer
                            Case 14
                                .Dia_14 = idFer
                            Case 15
                                .Dia_15 = idFer
                            Case 16
                                .Dia_16 = idFer
                            Case 17
                                .Dia_17 = idFer
                            Case 18
                                .Dia_18 = idFer
                            Case 19
                                .Dia_19 = idFer
                            Case 20
                                .Dia_20 = idFer
                            Case 21
                                .Dia_21 = idFer
                            Case 22
                                .Dia_22 = idFer
                            Case 23
                                .Dia_23 = idFer
                            Case 24
                                .Dia_24 = idFer
                            Case 25
                                .Dia_25 = idFer
                            Case 26
                                .Dia_26 = idFer
                            Case 27
                                .Dia_27 = idFer
                            Case 28
                                .Dia_28 = idFer
                            Case 29
                                .Dia_29 = idFer
                            Case 30
                                .Dia_30 = idFer
                            Case 31
                                .Dia_31 = idFer
                        End Select
                    End If
                Next
                For i As Integer = 1 To FechaUltimoDia.Day
                    For j As Integer = 0 To objCol.Count - 1
                        If objCol.Item(j).Dia = i Then
                            Select Case i
                                Case 1
                                    .Dia01 = idFer
                                Case 2
                                    .Dia02 = idFer
                                Case 3
                                    .Dia03 = idFer
                                Case 4
                                    .Dia04 = idFer
                                Case 5
                                    .Dia05 = idFer
                                Case 6
                                    .Dia06 = idFer
                                Case 7
                                    .Dia07 = idFer
                                Case 8
                                    .Dia08 = idFer
                                Case 9
                                    .Dia09 = idFer
                                Case 10
                                    .Dia10 = idFer
                                Case 11
                                    .Dia11 = idFer
                                Case 12
                                    .Dia12 = idFer
                                Case 13
                                    .Dia13 = idFer
                                Case 14
                                    .Dia_14 = idFer
                                Case 15
                                    .Dia_15 = idFer
                                Case 16
                                    .Dia_16 = idFer
                                Case 17
                                    .Dia_17 = idFer
                                Case 18
                                    .Dia_18 = idFer
                                Case 19
                                    .Dia_19 = idFer
                                Case 20
                                    .Dia_20 = idFer
                                Case 21
                                    .Dia_21 = idFer
                                Case 22
                                    .Dia_22 = idFer
                                Case 23
                                    .Dia_23 = idFer
                                Case 24
                                    .Dia_24 = idFer
                                Case 25
                                    .Dia_25 = idFer
                                Case 26
                                    .Dia_26 = idFer
                                Case 27
                                    .Dia_27 = idFer
                                Case 28
                                    .Dia_28 = idFer
                                Case 29
                                    .Dia_29 = idFer
                                Case 30
                                    .Dia_30 = idFer
                                Case 31
                                    .Dia_31 = idFer
                            End Select
                        End If
                    Next
                Next
            End With

            Return entDet
        End Function
        Private Function InsertarDiaAsistencia(entDet As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle,
                                      ent As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
            Dim fechaDia As Integer = Legolas.Components.FechaHora.FechaDia(ent.Fecha)
            Dim tipAsi As Integer = -1
            With entDet
                Select Case ent.MotivoJustificacionID
                    Case 7 ' falta disciplinaria
                        tipAsi = 8
                    Case Else
                        If ent.EstadoJustificacion = 0 Then
                            Select Case ent.MotivoJustificacionID
                                Case 1
                                    tipAsi = 2 'otros
                                Case 2
                                    tipAsi = 3 'DJ
                                Case 3
                                    tipAsi = 4 'DH
                                Case 4  'tratamiento
                                    tipAsi = 5
                                Case 5 'Atencion medica
                                    tipAsi = 6
                                Case 6 'entrevista con abogado
                                    tipAsi = 7
                            End Select
                        Else
                            If ent.MotivoRetiroID > 0 Then
                                Dim fechaRetiroDia As Integer = Legolas.Components.FechaHora.FechaDia(ent.FechaInicialRetiro)
                                If fechaRetiroDia <= fechaDia Then
                                    tipAsi = 0 ' Falta
                                Else
                                    tipAsi = 1 ' Asistio
                                End If
                            Else
                                If ent.HoraSalida.Length > 0 Then
                                    tipAsi = 1 ' Asistio
                                Else
                                    tipAsi = 0 ' Falta
                                End If
                            End If
                        End If
                End Select
                Select Case fechaDia
                    Case 1
                        .Dia01 = tipAsi
                    Case 2
                        .Dia02 = tipAsi
                    Case 3
                        .Dia03 = tipAsi
                    Case 4
                        .Dia04 = tipAsi
                    Case 5
                        .Dia05 = tipAsi
                    Case 6
                        .Dia06 = tipAsi
                    Case 7
                        .Dia07 = tipAsi
                    Case 8
                        .Dia08 = tipAsi
                    Case 9
                        .Dia09 = tipAsi
                    Case 10
                        .Dia10 = tipAsi
                    Case 11
                        .Dia11 = tipAsi
                    Case 12
                        .Dia12 = tipAsi
                    Case 13
                        .Dia13 = tipAsi
                    Case 14
                        .Dia_14 = tipAsi
                    Case 15
                        .Dia_15 = tipAsi
                    Case 16
                        .Dia_16 = tipAsi
                    Case 17
                        .Dia_17 = tipAsi
                    Case 18
                        .Dia_18 = tipAsi
                    Case 19
                        .Dia_19 = tipAsi
                    Case 20
                        .Dia_20 = tipAsi
                    Case 21
                        .Dia_21 = tipAsi
                    Case 22
                        .Dia_22 = tipAsi
                    Case 23
                        .Dia_23 = tipAsi
                    Case 24
                        .Dia_24 = tipAsi
                    Case 25
                        .Dia_25 = tipAsi
                    Case 26
                        .Dia_26 = tipAsi
                    Case 27
                        .Dia_27 = tipAsi
                    Case 28
                        .Dia_28 = tipAsi
                    Case 29
                        .Dia_29 = tipAsi
                    Case 30
                        .Dia_30 = tipAsi
                    Case 31
                        .Dia_31 = tipAsi
                End Select
                If fechaDia > 0 And fechaDia < 32 And tipAsi = 1 Then
                    .TotalDias += 1
                End If
            End With
            Return entDet
        End Function
    End Class

End Namespace