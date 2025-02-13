Imports System.Data
Imports System.Data.SqlClient
Namespace Visita.Programacion
    Public Class CalendarioDetalle
        Private objEnt As Entity.Visita.Programacion.CalendarioDetalle = Nothing
        Private objEntCol As Entity.Visita.Programacion.CalendarioDetalleCol = Nothing
#Region "Validar"
        Public Function BuscarCalendario(ByVal objEntValidar As Entity.Visita.Programacion.CalendarioValidar, _
                                          Optional ByVal MostrarMensaje As Boolean = True) As Integer

            Dim value As Integer = -1

            Dim strMensajeArray As New ArrayList

            'cambiar valores, antes de validar
            Select Case objEntValidar.SexoID
                Case 1 'varon
                    objEntValidar.SexoID = objEntValidar.SexoID
                Case 2 'mujer
                    objEntValidar.SexoID = 0
            End Select

            objEntCol = New Entity.Visita.Programacion.CalendarioDetalleCol
            Dim objEntFiltro As New Entity.Visita.Programacion.CalendarioDetalle

            With objEntFiltro
                .RegionID = objEntValidar.RegionID
                .PenalID = objEntValidar.PenalID
                .RegimenVisitaID = objEntValidar.RegimenVisitaID
                .VisitaTipoID = objEntValidar.TipoVisitaID
                .EtapaID = objEntValidar.EtapaID

                Select Case .VisitaTipoID
                    Case Type.Enumeracion.Visita.TipoVisita.Extraordinario
                        .InternoID = objEntValidar.InternoID
                End Select

            End With

            Dim blnPaso As Boolean = False
            Dim intTipoValicion As Type.Enumeracion.Visita.CalendarioValidacion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno

            objEntCol = ListarProgramacion(objEntFiltro)

            'si es visita intimas o vivistas extraordinarios y si no hay programacion salir de la validacion
            If objEntCol.Count < 1 And (objEntFiltro.VisitaTipoID = Type.Enumeracion.Visita.TipoVisita.Intimas _
                                        Or objEntFiltro.VisitaTipoID = Type.Enumeracion.Visita.TipoVisita.Extraordinario _
                                        Or objEntFiltro.VisitaTipoID = Type.Enumeracion.Visita.TipoVisita.Abogado) Then 'vis. intimas /vis. extraordinaria/ abogado
                value = -2 'salir
                Return value
            End If

            'parentesco
            objEntValidar.TipoParentesco = Bussines.Globall.Parentesco.Return_TipoParentesco(objEntValidar.ParentescoID)
            objEntValidar.GradoParentesco = Bussines.Globall.Parentesco.Return_GradoParentesco(objEntValidar.ParentescoID)

            For Each obj As Entity.Visita.Programacion.CalendarioDetalle In objEntCol

                With obj

                    intTipoValicion = ValidarCalendario(obj, objEntValidar)

                    If intTipoValicion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno Then
                        blnPaso = True
                    End If

                    Select Case intTipoValicion
                        Case Is <> Type.Enumeracion.Visita.CalendarioValidacion.Ninguno
                            strMensajeArray.Add(CalendarioMensajeValidacion(intTipoValicion))
                    End Select

                End With

                If blnPaso = True Then
                    value = obj.CalendarioDetalleID
                    Exit For
                End If

            Next

            If blnPaso = False And MostrarMensaje = True Then

                Dim strMensaje As String = "Se han encontrado las siguientes observaciones; " & Chr(13)
                strMensaje = strMensaje & objEntValidar.RegimenVisitaNombreReadonly & "-" & objEntValidar.VisitaTipoNombreReadonly & Chr(13)
                strMensaje = strMensaje & Chr(13)

                Dim intCount As Integer = 0

                If strMensajeArray.Count > 0 Then

                    strMensajeArray.Reverse()

                    For Each str As String In strMensajeArray
                        intCount = intCount + 1

                        strMensaje = strMensaje & intCount & ".-" & str & Chr(13)
                    Next

                Else
                    intCount = 1
                    strMensaje = strMensaje & intCount & ".-" & "No existen programaciones de horario para este régimen"
                End If

                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)

            End If

            Return value

        End Function
        Public Function Validar_CalendarioID(ByVal objEntValidar As Entity.Visita.Programacion.CalendarioValidar, _
                                          ByVal CalendarioDetalleID As Integer, _
                                          Optional ByVal MostrarMensaje As Boolean = True) As Boolean

            Dim value As Boolean = False
            Dim strMensajeArray As New ArrayList

            Select Case objEntValidar.SexoID
                Case 1 'varon
                    objEntValidar.SexoID = objEntValidar.SexoID
                Case 2 'mujer
                    objEntValidar.SexoID = 0
            End Select

            objEntCol = New Entity.Visita.Programacion.CalendarioDetalleCol
            Dim objEntFiltro As New Entity.Visita.Programacion.CalendarioDetalle

            With objEntFiltro
                .CalendarioDetalleID = CalendarioDetalleID
            End With

            Dim blnPaso As Boolean = False
            Dim intTipoValicion As Type.Enumeracion.Visita.CalendarioValidacion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno

            objEntCol = ListarProgramacion(objEntFiltro)

            'parentesco
            objEntValidar.TipoParentesco = Bussines.Globall.Parentesco.Return_TipoParentesco(objEntValidar.ParentescoID)
            objEntValidar.GradoParentesco = Bussines.Globall.Parentesco.Return_GradoParentesco(objEntValidar.ParentescoID)

            For Each obj As Entity.Visita.Programacion.CalendarioDetalle In objEntCol

                With obj

                    intTipoValicion = ValidarCalendarioGrabar(obj, objEntValidar)

                    If intTipoValicion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno Then
                        blnPaso = True
                    End If

                    Select Case intTipoValicion
                        Case Is <> Type.Enumeracion.Visita.CalendarioValidacion.Ninguno
                            strMensajeArray.Add(CalendarioMensajeValidacion(intTipoValicion))
                    End Select

                End With

                If blnPaso = True Then
                    value = True
                    Exit For
                End If

            Next

            If blnPaso = False And MostrarMensaje = True Then

                Dim strMensaje As String = "Se han encontrado las siguientes observaciones; " & Chr(13)
                strMensaje = strMensaje & objEntValidar.RegimenVisitaNombreReadonly & "-" & objEntValidar.VisitaTipoNombreReadonly & Chr(13)
                strMensaje = strMensaje & Chr(13)

                Dim intCount As Integer = 0

                strMensajeArray.Reverse()

                For Each str As String In strMensajeArray
                    intCount = intCount + 1

                    strMensaje = strMensaje & intCount & ".-" & str & Chr(13)
                Next

                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)

            End If

            Return value

        End Function
        Public Function Validar_ExtraordinarioMenorEdad(ByVal objEntValidar As Entity.Visita.Programacion.CalendarioValidar, _
                                          ByVal CalendarioDetalleID As Integer, _
                                          Optional ByVal MostrarMensaje As Boolean = True) As Boolean

            Dim value As Boolean = False
            Dim strMensajeArray As New ArrayList

            Select Case objEntValidar.SexoID
                Case 1 'varon
                    objEntValidar.SexoID = objEntValidar.SexoID
                Case 2 'mujer
                    objEntValidar.SexoID = 0
            End Select

            objEntCol = New Entity.Visita.Programacion.CalendarioDetalleCol
            Dim objEntFiltro As New Entity.Visita.Programacion.CalendarioDetalle

            With objEntFiltro
                .CalendarioDetalleID = CalendarioDetalleID
            End With

            Dim blnPaso As Boolean = False
            Dim intTipoValicion As Type.Enumeracion.Visita.CalendarioValidacion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno

            objEntCol = ListarProgramacion(objEntFiltro)

            'parentesco
            objEntValidar.TipoParentesco = Bussines.Globall.Parentesco.Return_TipoParentesco(objEntValidar.ParentescoID)
            objEntValidar.GradoParentesco = Bussines.Globall.Parentesco.Return_GradoParentesco(objEntValidar.ParentescoID)

            For Each obj As Entity.Visita.Programacion.CalendarioDetalle In objEntCol

                With obj

                    intTipoValicion = ValidarCalendario(obj, objEntValidar)

                    If intTipoValicion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno Then
                        blnPaso = True
                    End If

                    Select Case intTipoValicion
                        Case Is <> Type.Enumeracion.Visita.CalendarioValidacion.Ninguno
                            strMensajeArray.Add(CalendarioMensajeValidacion(intTipoValicion))
                    End Select

                End With

                If blnPaso = True Then
                    value = True
                    Exit For
                End If

            Next

            If blnPaso = False And MostrarMensaje = True Then

                Dim strMensaje As String = "Se han encontrado las siguientes observaciones; " & Chr(13)
                strMensaje = strMensaje & objEntValidar.RegimenVisitaNombreReadonly & "-" & objEntValidar.VisitaTipoNombreReadonly & Chr(13)
                strMensaje = strMensaje & Chr(13)

                Dim intCount As Integer = 0

                strMensajeArray.Reverse()

                For Each str As String In strMensajeArray
                    intCount = intCount + 1

                    strMensaje = strMensaje & intCount & ".-" & str & Chr(13)
                Next

                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)

            End If

            Return value

        End Function

        Private Function CalendarioMensajeValidacion(ByVal TipoValidacion As Type.Enumeracion.Visita.CalendarioValidacion) As String

            Dim value As String = ""

            Select Case TipoValidacion

                Case Type.Enumeracion.Visita.CalendarioValidacion.Sexo
                    value = "Tipo de sexo del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.FechaInicio
                    value = "Fecha de visita (visitante), no esta permitido en el regimen o etapa actual [Fecha Inicio]"

                Case Type.Enumeracion.Visita.CalendarioValidacion.FechaFin
                    value = "Fecha de visita (visitante), no esta permitido en el regimen o etapa actual [Fecha Fin]"

                Case Type.Enumeracion.Visita.CalendarioValidacion.DiaSemana
                    value = "Fecha de visita [dia de semana] del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.Mes
                    value = "Fecha de visita [numero de mes] del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.MesDias
                    value = "Fecha de visita [numeros de dia(s) del Mes] del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.HoraInicio
                    value = "Hora de inicio del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.HoraFin
                    value = "[Hora Fin] del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimiento
                    value = "Cantidad de visitas del interno ha llegado a su limite"

                Case Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimientoConsanguidad
                    value = "Cantidad de visitas por el tipo de parentesco consanguidad ha llegado a su limite"

                Case Type.Enumeracion.Visita.CalendarioValidacion.GradoConsanguidad
                    value = "Grado de parentesco por consanguidad del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimientoAfinidad
                    value = "Cantidad de visitas por el tipo de parentesco afinidad ha llegado a su limite"

                Case Type.Enumeracion.Visita.CalendarioValidacion.GradoAfinidad
                    value = "Grado de parentesco por afinidad del visitante, no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.IncluyeConyugue
                    value = "Tipo de parentesco [Conyugue], no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAmigo
                    value = "Tipo de parentesco [Amigo], no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAbogado
                    value = "Tipo de parentesco [Abogado], no esta permitido en el regimen o etapa actual"

                Case Type.Enumeracion.Visita.CalendarioValidacion.VisitanteAutorizado
                    value = "El Visitante, no se encuentra autorizado en la lista del interno"

                Case Type.Enumeracion.Visita.CalendarioValidacion.EdadInicio
                    value = "El Visitante (Menor de edad)-[Edad Inicio], no esta permitido segun la programacion del Penal"

                Case Type.Enumeracion.Visita.CalendarioValidacion.EdadFin
                    value = "El Visitante (Menor de edad)-[Edad Fin], no esta permitido segun la programacion del Penal"
            End Select

            Return value

        End Function
        Private Function ValidarCalendario(ByVal obj As Entity.Visita.Programacion.CalendarioDetalle, _
                                         ByVal objEntValidar As Entity.Visita.Programacion.CalendarioValidar) As Type.Enumeracion.Visita.CalendarioValidacion

            Dim value As Type.Enumeracion.Visita.CalendarioValidacion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno

            Dim blnPaso As Boolean = True
            Dim intDiaSemana As Integer = Legolas.Components.FechaHora.FechaDiaSemana(objEntValidar.Fecha)
            Dim intMesNumero As Integer = Legolas.Components.FechaHora.FechaMes(objEntValidar.Fecha)
            Dim intDiaNumero As Integer = Legolas.Components.FechaHora.FechaDia(objEntValidar.Fecha)
            Dim intHoraNumero As Integer = (objEntValidar.Hora * 60) + objEntValidar.Minuto

            Dim intCountVisitaxInterno As Integer = 0
            Dim intCountVisitaConsanguidad As Integer = 0
            Dim intCountVisitaAfinidad As Integer = 0

            Dim intTipoAutorizacion As Integer = -1
            Dim intCalendarioDetalleID As Integer = -1

            With obj

                If .VisitaTipoID = Type.Enumeracion.Visita.TipoVisita.Extraordinario Then 'extraordinario
                    intTipoAutorizacion = Type.Enumeracion.Visita.AutorizacionTipo.Extraordinario
                    intCalendarioDetalleID = .CalendarioDetalleID
                Else
                    intTipoAutorizacion = 1
                    intCalendarioDetalleID = -1 'si es autorizado el calendariodetalleid=-1
                End If

                'validar sexo
                'Select Case objEntValidar.ValidacionMenorAntes
                '    Case True

                '        Select Case objEntValidar.TipoVisitaID
                '            Case Type.Enumeracion.Visita.TipoVisita.MenorEdad, Type.Enumeracion.Visita.TipoVisita.Extraordinario
                '                'si es menor de edad y la validacion es antes de valdiar el menor de edad, pasa
                '            Case Else

                '                If .SexoID <> objEntValidar.SexoID And .SexoID <> 10 Then 'sexo ambos
                '                    value = Type.Enumeracion.Visita.CalendarioValidacion.Sexo
                '                    Return value
                '                End If

                '        End Select
                '    Case Else

                '        If .SexoID <> objEntValidar.SexoID And .SexoID <> 10 Then 'sexo ambos
                '            value = Type.Enumeracion.Visita.CalendarioValidacion.Sexo
                '            Return value
                '        End If

                'End Select

                If (objEntValidar.TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.MenorEdad Or _
                    objEntValidar.TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.Extraordinario) _
                    And objEntValidar.ValidacionMenorAntes = True Then
                    'si es menor de edad y la validacion es antes de valdiar el menor de edad, pasa
                Else

                    If objEntValidar.TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.Extraordinario Then
                        'si la programacion es extraordinaria, no debe validar el sexo

                    Else

                        If .SexoID <> objEntValidar.SexoID And .SexoID <> 10 Then 'sexo ambos
                            value = Type.Enumeracion.Visita.CalendarioValidacion.Sexo
                            Return value
                        End If

                    End If

                End If

                'validar fecha inicio
                If .FechaInicio > objEntValidar.Fecha Then
                    value = Type.Enumeracion.Visita.CalendarioValidacion.FechaInicio
                    Return value
                End If

                'validar fecha fin
                If .FechaFinIndeterminado = False Then
                    If .FechaFin < objEntValidar.Fecha Then
                        value = Type.Enumeracion.Visita.CalendarioValidacion.FechaFin
                        Return value
                    End If
                End If

                'ver que tipo es semanal o mensual
                Select Case .FrecuenciaID
                    Case Type.Enumeracion.Visita.Frecuencia.Semanal  'semanal

                        Select Case intDiaSemana
                            Case 1
                                blnPaso = .DiaLunes
                            Case 2
                                blnPaso = .DiaMartes
                            Case 3
                                blnPaso = .DiaMiercoles
                            Case 4
                                blnPaso = .DiaJueves
                            Case 5
                                blnPaso = .DiaViernes
                            Case 6
                                blnPaso = .DiaSabado
                            Case 7
                                blnPaso = .DiaDomingo
                        End Select

                        If blnPaso = False Then
                            value = Type.Enumeracion.Visita.CalendarioValidacion.DiaSemana
                            Return value
                        End If

                    Case Type.Enumeracion.Visita.Frecuencia.Mensual  'mensual

                        'validar si en el array se encuentra el mes que manda la app
                        If .MesTipo = 1 Then 'dias del calendario

                            blnPaso = False
                            Dim strMesArray As String() = .MesArray.Split(",")

                            For Each str As String In strMesArray
                                If Integer.Parse(str) = intMesNumero Then
                                    blnPaso = True
                                    Exit For
                                End If
                            Next

                            If blnPaso = False Then
                                value = Type.Enumeracion.Visita.CalendarioValidacion.Mes
                                Return value
                            End If

                        End If

                        'validar si en el array se encuentra el mesdia que manda el app
                        blnPaso = False
                        Dim strMesDiaArray As String() = .MesDiaArray.Split(",")

                        For Each str As String In strMesDiaArray
                            If Integer.Parse(str) = intDiaNumero Then
                                blnPaso = True
                                Exit For
                            End If
                        Next

                        If blnPaso = False Then
                            value = Type.Enumeracion.Visita.CalendarioValidacion.MesDias
                            Return value
                        End If

                End Select

                'hora inicio
                If .HoraInicio > intHoraNumero Then
                    value = Type.Enumeracion.Visita.CalendarioValidacion.HoraInicio
                    Return value
                End If

                'hora fin 
                If .HoraFin < intHoraNumero Then
                    value = Type.Enumeracion.Visita.CalendarioValidacion.HoraFin
                    Return value
                End If

                'verificar si es menor de edad, y aplicar los filtros x años de menores          
                Select Case objEntValidar.TipoVisitaID

                    Case Type.Enumeracion.Visita.TipoVisita.MenorEdad  'menor de edad

                        If .HabilitarRangoEdad = True Then
                            If objEntValidar.ValidacionMenorAntes = False Then

                                Dim intEdadMenor As Short = Legolas.Components.FechaHora.FechaCalcularAnio( _
                                objEntValidar.VisitanteFechaNacimiento, _
                                Legolas.Configuration.Aplication.FechayHora.FechaLong, True)

                                If .EdadInicio > intEdadMenor Then
                                    value = Type.Enumeracion.Visita.CalendarioValidacion.EdadInicio
                                    Return value
                                End If

                                If .EdadFin < intEdadMenor Then
                                    value = Type.Enumeracion.Visita.CalendarioValidacion.EdadFin
                                    Return value
                                End If

                            End If
                        End If

                End Select

                'limite de visitantes por interno
                If .LimiteVisita = True Then

                    'limite de cantidad

                    If .LimiteVisitaCantidad <> 0 Then

                        intCountVisitaxInterno = Bussines.Visita.Movimiento.ValidarNumeroVisitas(objEntValidar.RegionID, _
                        objEntValidar.PenalID, objEntValidar.Fecha, objEntValidar.InternoID, -1, _
                        objEntValidar.RegimenVisitaID, objEntValidar.TipoVisitaID)

                        If .LimiteVisitaCantidad <= intCountVisitaxInterno Then
                            value = Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimiento
                            Return value
                        End If

                    End If

                    Select Case .VisitaTipoID
                        Case Type.Enumeracion.Visita.TipoVisita.Extraordinario 'extra
                            'pasa
                        Case Else

                            Select Case objEntValidar.TipoParentesco

                                Case Type.Enumeracion.Parentesco.TipoGrado.Consanguinidad

                                    'familiares x consanguidad
                                    If .FamiliaConsanguidad = True Then

                                        'familaires x consanguidad, cantidad
                                        If .FamiliaConsanguidadCantidad <> 0 Then

                                            intCountVisitaConsanguidad = Bussines.Visita.Movimiento.ValidarNumeroVisitas(objEntValidar.RegionID, _
                                            objEntValidar.PenalID, objEntValidar.Fecha, objEntValidar.InternoID, 1, _
                                            objEntValidar.RegimenVisitaID, objEntValidar.TipoVisitaID)

                                            If .FamiliaConsanguidadCantidad < intCountVisitaConsanguidad Then
                                                value = Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimientoConsanguidad
                                                Return value
                                            End If
                                        End If

                                        'grado de consanguidad
                                        If .FamiliaConsanguidadGrado <> 0 And .FamiliaConsanguidadGrado < objEntValidar.GradoParentesco Then
                                            value = Type.Enumeracion.Visita.CalendarioValidacion.GradoConsanguidad
                                            Return value
                                        End If

                                    End If

                                Case Type.Enumeracion.Parentesco.TipoGrado.Ninguno, Type.Enumeracion.Parentesco.TipoGrado.Afinidad

                                    If .FamiliaAfinidad = True Then

                                        'familiares x afinidad, cantidad
                                        If .FamiliaAfinidadCantidad <> 0 Then

                                            intCountVisitaAfinidad = Bussines.Visita.Movimiento.ValidarNumeroVisitas(objEntValidar.RegionID, _
                                            objEntValidar.PenalID, objEntValidar.Fecha, objEntValidar.InternoID, 2, _
                                            objEntValidar.RegimenVisitaID, objEntValidar.TipoVisitaID)

                                            If .FamiliaAfinidadCantidad < intCountVisitaAfinidad Then
                                                value = Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimientoAfinidad
                                                Return value
                                            End If
                                        End If

                                        'grado de afinidad
                                        If .FamiliaAfinidadGrado <> 0 Then

                                            If objEntValidar.GradoParentesco <> 0 Then
                                                If (.FamiliaAfinidadGrado < objEntValidar.GradoParentesco) Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.GradoAfinidad
                                                    Return value
                                                End If
                                            Else

                                                'incluye conyugue/amigo
                                                Select Case objEntValidar.ParentescoID
                                                    Case Type.Enumeracion.Parentesco.ParentescoID.Conyugue, Type.Enumeracion.Parentesco.ParentescoID.Conviviente
                                                        If .IncluyeConyugueConcubina = False Then
                                                            value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeConyugue
                                                            Return value
                                                        End If
                                                    Case Type.Enumeracion.Parentesco.ParentescoID.Amigo   'amigo
                                                        If .IncluyeAmigo = False Then
                                                            value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAmigo
                                                            Return value
                                                        End If
                                                    Case Type.Enumeracion.Parentesco.ParentescoID.Abogado  'abogado
                                                        If .IncluyeAbogado = False Then
                                                            value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAbogado
                                                            Return value
                                                        End If
                                                End Select

                                            End If

                                        End If

                                    Else

                                        'incluye conyugue/amigo/abogado
                                        Select Case objEntValidar.ParentescoID
                                            Case Type.Enumeracion.Parentesco.ParentescoID.Conyugue, Type.Enumeracion.Parentesco.ParentescoID.Conviviente 'conyugue/conviviente
                                                If .IncluyeConyugueConcubina = False Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeConyugue
                                                    Return value
                                                End If
                                            Case Type.Enumeracion.Parentesco.ParentescoID.Amigo  'amigo
                                                If .IncluyeAmigo = False Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAmigo
                                                    Return value
                                                End If
                                            Case Type.Enumeracion.Parentesco.ParentescoID.Abogado 'abogado
                                                If .IncluyeAbogado = False Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAbogado
                                                    Return value
                                                End If
                                        End Select

                                    End If
                            End Select

                    End Select

                End If

                'verificar si el visitante esta registrado
                If .VisitanteRegistradoPreviamente = True Then

                    If (objEntValidar.TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.MenorEdad _
                        Or objEntValidar.TipoVisitaID = Type.Enumeracion.Visita.TipoVisita.Extraordinario) _
                        And objEntValidar.ValidacionMenorAntes = True Then

                        'si es menor de edad y la validacion es antes de validar el menor de edad, pasa normal
                    Else

                        If objEntValidar.VisitanteID < 1 Then
                            blnPaso = False
                        Else
                            'verifica la tabla autorizacion

                            Dim objBss As New Bussines.Visita.Autorizacion
                            Dim objEntFiltro As New Entity.Visita.Autorizacion
                            With objEntFiltro
                                .CalendarioDetalleID = intCalendarioDetalleID
                                .InternoID = objEntValidar.InternoID
                                .VisitanteID = objEntValidar.VisitanteID
                                .TipoID = intTipoAutorizacion
                                .ParentescoID = objEntValidar.ParentescoID
                            End With

                            blnPaso = objBss.ValidarVerificarVisitante(objEntFiltro)

                        End If

                        If blnPaso = False Then
                            value = Type.Enumeracion.Visita.CalendarioValidacion.VisitanteAutorizado
                            Return value
                        End If

                    End If

                End If

            End With

            Return value

        End Function
        Private Function ValidarCalendarioGrabar(ByVal obj As Entity.Visita.Programacion.CalendarioDetalle, _
                                         ByVal objEntValidar As Entity.Visita.Programacion.CalendarioValidar) As Type.Enumeracion.Visita.CalendarioValidacion

            Dim value As Type.Enumeracion.Visita.CalendarioValidacion = Type.Enumeracion.Visita.CalendarioValidacion.Ninguno

            Dim intCountVisitaxInterno As Integer = 0
            Dim intCountVisitaConsanguidad As Integer = 0
            Dim intCountVisitaAfinidad As Integer = 0

            With obj

                'limite de visitantes por interno
                If .LimiteVisita = True Then

                    'limite de cantidad

                    intCountVisitaxInterno = Bussines.Visita.Movimiento.ValidarNumeroVisitas(objEntValidar.RegionID, _
                    objEntValidar.PenalID, objEntValidar.Fecha, objEntValidar.InternoID, -1, _
                    objEntValidar.RegimenVisitaID, objEntValidar.TipoVisitaID)

                    If .LimiteVisitaCantidad <= intCountVisitaxInterno Then
                        value = Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimiento
                        Return value
                    End If

                    Select Case .VisitaTipoID
                        Case Type.Enumeracion.Visita.TipoVisita.Extraordinario  'extra
                            'pasa
                        Case Else

                            Select Case objEntValidar.TipoParentesco

                                Case Type.Enumeracion.Parentesco.TipoGrado.Consanguinidad  'consanguidad

                                    'familiares x consanguidad
                                    If .FamiliaConsanguidad = True Then

                                        'familaires x consanguidad, cantidad
                                        If .FamiliaConsanguidadCantidad <> 0 Then

                                            intCountVisitaConsanguidad = Bussines.Visita.Movimiento.ValidarNumeroVisitas(objEntValidar.RegionID, _
                                            objEntValidar.PenalID, objEntValidar.Fecha, objEntValidar.InternoID, 1, _
                                            objEntValidar.RegimenVisitaID, objEntValidar.TipoVisitaID)

                                            If .FamiliaConsanguidadCantidad < intCountVisitaConsanguidad Then
                                                value = Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimientoConsanguidad
                                                Return value
                                            End If
                                        End If

                                        'grado de consanguidad
                                        If .FamiliaConsanguidadGrado <> 0 And .FamiliaConsanguidadGrado < objEntValidar.GradoParentesco Then
                                            value = Type.Enumeracion.Visita.CalendarioValidacion.GradoConsanguidad
                                            Return value
                                        End If

                                    End If

                                Case Type.Enumeracion.Parentesco.TipoGrado.Ninguno, Type.Enumeracion.Parentesco.TipoGrado.Afinidad  'afinidad

                                    If .FamiliaAfinidad = True Then

                                        'familiares x afinidad, cantidad
                                        If .FamiliaAfinidadCantidad <> 0 Then

                                            intCountVisitaAfinidad = Bussines.Visita.Movimiento.ValidarNumeroVisitas(objEntValidar.RegionID, _
                                            objEntValidar.PenalID, objEntValidar.Fecha, objEntValidar.InternoID, 2, _
                                            objEntValidar.RegimenVisitaID, objEntValidar.TipoVisitaID)

                                            If .FamiliaAfinidadCantidad < intCountVisitaAfinidad Then
                                                value = Type.Enumeracion.Visita.CalendarioValidacion.CountInternoMovimientoAfinidad
                                                Return value
                                            End If
                                        End If

                                        'grado de afinidad
                                        If .FamiliaAfinidadGrado <> 0 Then

                                            If objEntValidar.GradoParentesco <> 0 Then
                                                If (.FamiliaAfinidadGrado < objEntValidar.GradoParentesco) Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.GradoAfinidad
                                                    Return value
                                                End If
                                            Else

                                                'incluye conyugue/amigo/abogado
                                                Select Case objEntValidar.ParentescoID
                                                    Case Type.Enumeracion.Parentesco.ParentescoID.Conyugue, Type.Enumeracion.Parentesco.ParentescoID.Conviviente   'conyugue/conviviente
                                                        If .IncluyeConyugueConcubina = False Then
                                                            value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeConyugue
                                                            Return value
                                                        End If
                                                    Case Type.Enumeracion.Parentesco.ParentescoID.Amigo  'amigo
                                                        If .IncluyeAmigo = False Then
                                                            value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAmigo
                                                            Return value
                                                        End If
                                                    Case Type.Enumeracion.Parentesco.ParentescoID.Abogado  'abogado
                                                        If .IncluyeAbogado = False Then
                                                            value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAbogado
                                                            Return value
                                                        End If
                                                End Select

                                            End If

                                        End If

                                    Else

                                        'incluye conyugue/amigo/abogado
                                        Select Case objEntValidar.ParentescoID
                                            Case Type.Enumeracion.Parentesco.ParentescoID.Conyugue, Type.Enumeracion.Parentesco.ParentescoID.Conviviente  'conyugue/conviviente
                                                If .IncluyeConyugueConcubina = False Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeConyugue
                                                    Return value
                                                End If
                                            Case Type.Enumeracion.Parentesco.ParentescoID.Amigo  'amigo
                                                If .IncluyeAmigo = False Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAmigo
                                                    Return value
                                                End If
                                            Case Type.Enumeracion.Parentesco.ParentescoID.Abogado  'abogado
                                                If .IncluyeAbogado = False Then
                                                    value = Type.Enumeracion.Visita.CalendarioValidacion.IncluyeAbogado
                                                    Return value
                                                End If
                                        End Select

                                    End If
                            End Select

                    End Select

                End If

                ''verificar si el visitante esta registrado
                'If .VisitanteRegistradoPreviamente = True Then

                '    Dim objBss As New Bussines.Visita.Autorizacion
                '    Dim objEntFiltro As New Entity.Visita.Autorizacion
                '    With objEntFiltro
                '        .InternoID = objEntValidar.InternoID
                '        .VisitanteID = objEntValidar.VisitanteID
                '    End With

                '    blnPaso = objBss.ValidarVerificarVisitante(objEntFiltro)

                '    If blnPaso = False Then
                '        value = Type.Enumeracion.Visita.CalendarioValidacion.VisitanteAutorizado
                '        Return value
                '    End If

                'End If

            End With

            Return value

        End Function
        Private Function Validar(ByVal objEnt As Entity.Visita.Programacion.Calendario) As Boolean

            Dim intValue As Integer = 0

            Select Case objEnt.VisitaTipoID
                Case 10 'extraordinario                    
                    intValue = Data.Visita.Programacion.CalendarioDetalle.ListarOutput("lst", "val_visita_extra", objEnt)
                Case Else
                    intValue = Data.Visita.Programacion.CalendarioDetalle.ListarOutput("lst", "val_etapa_sexo_fecha_ini", objEnt)
            End Select

            Return Not (intValue > 0)

        End Function
        Private Function ValidarMovimiento(ByVal objEnt As Entity.Visita.Programacion.Calendario) As Boolean

            'Dim value As Boolean = False
            Dim intValue As Integer = 0

            intValue = Data.Visita.Programacion.CalendarioDetalle.ListarOutput("lst", "val_calendarido_detalle_movimiento", objEnt)

            Return Not (intValue > 0)

        End Function
        Public Function _ValidarMovimiento(ByVal objEnt As Entity.Visita.Programacion.Calendario) As Boolean
            Return ValidarMovimiento(objEnt)
        End Function
            
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Programacion.CalendarioDetalle

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Visita.Programacion.CalendarioDetalle
            objEntFiltro.CalendarioDetalleID = Codigo

            Dim sqlDr As SqlDataReader = Data.Visita.Programacion.CalendarioDetalle.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Visita.Programacion.CalendarioDetalle

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .CalendarioDetalleID = sqlDr("cal_det_id").ToString
                            .CalendarioID = sqlDr("cal_id").ToString
                            .RegimenVisitaID = sqlDr("reg_vis_id").ToString
                            .VisitaTipoID = sqlDr("vis_tip_id").ToString
                            .EtapaID = sqlDr("etp_id").ToString
                            .SexoID = sqlDr("cal_det_sex_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString
                            .FechaInicio = sqlDr("cal_det_fec_ini").ToString
                            .FechaFin = sqlDr("cal_det_fec_fin").ToString
                            .FechaFinIndeterminado = sqlDr("cal_det_fec_fin_ind").ToString
                            .FrecuenciaID = sqlDr("cal_det_fre_id").ToString
                            .FrecuenciaRepeticion = sqlDr("cal_det_fre_rep").ToString
                            .DiaLunes = sqlDr("cal_det_dia_lun").ToString
                            .DiaMartes = sqlDr("cal_det_dia_mar").ToString
                            .DiaMiercoles = sqlDr("cal_det_dia_mie").ToString
                            .DiaJueves = sqlDr("cal_det_dia_jue").ToString
                            .DiaViernes = sqlDr("cal_det_dia_vie").ToString
                            .DiaSabado = sqlDr("cal_det_dia_sab").ToString
                            .DiaDomingo = sqlDr("cal_det_dia_dom").ToString
                            .MesArray = sqlDr("cal_det_mes").ToString
                            .MesTipo = sqlDr("cal_det_mes_tip").ToString
                            .MesDiaArray = sqlDr("cal_det_mes_dia").ToString
                            .MesElArray = sqlDr("cal_det_mes_el").ToString
                            .MesDiaSemanaArray = sqlDr("cal_det_mes_dia_sem").ToString
                            .HoraInicio = sqlDr("cal_det_hor_ini").ToString
                            .HoraFin = sqlDr("cal_det_hor_fin").ToString
                            .Duracion = sqlDr("cal_det_dur").ToString
                            .LimiteVisita = sqlDr("cal_det_lim_vis").ToString
                            .LimiteVisitaCantidad = sqlDr("cal_det_can_lim_vis").ToString
                            .FamiliaConsanguidad = sqlDr("cal_det_fam_con").ToString
                            .FamiliaConsanguidadCantidad = sqlDr("cal_det_can_fam_con").ToString
                            .FamiliaConsanguidadGrado = sqlDr("cal_det_grd_fam_con").ToString
                            .FamiliaAfinidad = sqlDr("cal_det_fam_afi").ToString
                            .FamiliaAfinidadCantidad = sqlDr("cal_det_can_fam_afi").ToString
                            .FamiliaAfinidadGrado = sqlDr("cal_det_grd_fam_afi").ToString
                            .HabilitarRangoEdad = sqlDr("cal_det_hab_ran_eda").ToString
                            .EdadInicio = sqlDr("cal_det_eda_ini").ToString
                            .EdadFin = sqlDr("cal_det_eda_fin").ToString
                            .IncluyeConyugueConcubina = sqlDr("cal_det_con_con").ToString
                            .IncluyeAmigo = sqlDr("cal_det_ami").ToString
                            .IncluyeAbogado = sqlDr("cal_det_inc_abo").ToString
                            .VisitanteRegistradoPreviamente = sqlDr("cal_det_vis_reg").ToString
                            .DetalleEstado = sqlDr("cal_det_est").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function
        Public Function Listar(ByVal objEntFiltro As Entity.Visita.Programacion.CalendarioDetalle) As Entity.Visita.Programacion.CalendarioDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Programacion.CalendarioDetalle.Listar(sqlCon, "lst", "lst_grilla", _
                                                                                           objEntFiltro)
            Try
                objEntCol = New Entity.Visita.Programacion.CalendarioDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Programacion.CalendarioDetalle
                        With objEnt
                            .CalendarioDetalleID = sqlDr("cal_det_id").ToString
                            .CalendarioID = sqlDr("cal_id").ToString
                            .EtapaID = sqlDr("etp_id").ToString
                            .Etapa = sqlDr("etp_nom").ToString

                            If .EtapaID < 1 Then
                                .Etapa = "S/E"
                            End If

                            .SexoID = sqlDr("cal_det_sex_id").ToString
                            .InternoApellidosyNombres = sqlDr("int_ape_nom").ToString.ToUpper
                            .FechaInicio = sqlDr("cal_det_fec_ini").ToString
                            .FechaFin = sqlDr("cal_det_fec_fin").ToString
                            .FechaFinIndeterminado = sqlDr("cal_det_fec_fin_ind").ToString
                            .FrecuenciaID = sqlDr("cal_det_fre_id").ToString
                            .DiaLunes = sqlDr("cal_det_dia_lun").ToString
                            .DiaMartes = sqlDr("cal_det_dia_mar").ToString
                            .DiaMiercoles = sqlDr("cal_det_dia_mie").ToString
                            .DiaJueves = sqlDr("cal_det_dia_jue").ToString
                            .DiaViernes = sqlDr("cal_det_dia_vie").ToString
                            .DiaSabado = sqlDr("cal_det_dia_sab").ToString
                            .DiaDomingo = sqlDr("cal_det_dia_dom").ToString
                            .MesArray = sqlDr("cal_det_mes").ToString
                            .MesDiaArray = sqlDr("cal_det_mes_dia").ToString

                            .HoraInicio = sqlDr("cal_det_hor_ini").ToString
                            .HoraFin = sqlDr("cal_det_hor_fin").ToString
                            .Duracion = sqlDr("cal_det_dur").ToString
                            .Estado = sqlDr("cal_det_est").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        Public Function ListarProgramacion(ByVal objEntFiltro As Entity.Visita.Programacion.CalendarioDetalle) As Entity.Visita.Programacion.CalendarioDetalleCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Programacion.CalendarioDetalle.Listar(sqlCon, "lst", "lst_programacion", _
                                                                                           objEntFiltro)
            Try
                objEntCol = New Entity.Visita.Programacion.CalendarioDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Programacion.CalendarioDetalle
                        With objEnt
                            .CalendarioDetalleID = sqlDr("cal_det_id").ToString
                            .CalendarioID = sqlDr("cal_id").ToString
                            .VisitaTipoID = sqlDr("vis_tip_id").ToString
                            .EtapaID = sqlDr("etp_id").ToString
                            .SexoID = sqlDr("cal_det_sex_id").ToString
                            .FechaInicio = sqlDr("cal_det_fec_ini").ToString
                            .FechaFin = sqlDr("cal_det_fec_fin").ToString
                            .FechaFinIndeterminado = sqlDr("cal_det_fec_fin_ind").ToString
                            .FrecuenciaID = sqlDr("cal_det_fre_id").ToString
                            .FrecuenciaRepeticion = sqlDr("cal_det_fre_rep").ToString
                            .DiaLunes = sqlDr("cal_det_dia_lun").ToString
                            .DiaMartes = sqlDr("cal_det_dia_mar").ToString
                            .DiaMiercoles = sqlDr("cal_det_dia_mie").ToString
                            .DiaJueves = sqlDr("cal_det_dia_jue").ToString
                            .DiaViernes = sqlDr("cal_det_dia_vie").ToString
                            .DiaSabado = sqlDr("cal_det_dia_sab").ToString
                            .DiaDomingo = sqlDr("cal_det_dia_dom").ToString
                            .MesArray = sqlDr("cal_det_mes").ToString
                            .MesTipo = sqlDr("cal_det_mes_tip").ToString
                            .MesDiaArray = sqlDr("cal_det_mes_dia").ToString
                            .MesElArray = sqlDr("cal_det_mes_el").ToString
                            .MesDiaSemanaArray = sqlDr("cal_det_mes_dia_sem").ToString
                            .HoraInicio = sqlDr("cal_det_hor_ini").ToString
                            .HoraFin = sqlDr("cal_det_hor_fin").ToString
                            .Duracion = sqlDr("cal_det_dur").ToString
                            .LimiteVisita = sqlDr("cal_det_lim_vis").ToString
                            .LimiteVisitaCantidad = sqlDr("cal_det_can_lim_vis").ToString
                            .FamiliaConsanguidad = sqlDr("cal_det_fam_con").ToString
                            .FamiliaConsanguidadCantidad = sqlDr("cal_det_can_fam_con").ToString
                            .FamiliaConsanguidadGrado = sqlDr("cal_det_grd_fam_con").ToString
                            .FamiliaAfinidad = sqlDr("cal_det_fam_afi").ToString
                            .FamiliaAfinidadCantidad = sqlDr("cal_det_can_fam_afi").ToString
                            .FamiliaAfinidadGrado = sqlDr("cal_det_grd_fam_afi").ToString
                            .IncluyeConyugueConcubina = sqlDr("cal_det_con_con").ToString
                            .IncluyeAmigo = sqlDr("cal_det_ami").ToString
                            .IncluyeAbogado = sqlDr("cal_det_inc_abo").ToString
                            .VisitanteRegistradoPreviamente = sqlDr("cal_det_vis_reg").ToString
                            .DetalleEstado = sqlDr("cal_det_est").ToString
                            .HabilitarRangoEdad = sqlDr("cal_det_hab_ran_eda").ToString
                            .EdadInicio = sqlDr("cal_det_eda_ini").ToString
                            .EdadFin = sqlDr("cal_det_eda_fin").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Visita.Programacion.CalendarioDetalle) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.EtapaID < 1 Then
                objEnt.EtapaID = -1
            End If

            If objEnt.InternoID < 1 Then
                objEnt.InternoApellidosyNombres = ""
            End If

            If ValidarMovimiento(objEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El registro actual no se puede actualizar, debido que ya se encuentra en uso en el modulo de visita")
                Return Value
            End If

            If Validar(objEnt) = False Then
                Select Case objEnt.VisitaTipoID
                    Case 10 'extra
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "El detalle del tipo de visita con los datos del Interno y la fecha de inicio ya existen")
                    Case Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "El detalle del tipo de visita con los datos; etapa, sexo y fecha inicio ya existen")
                End Select

                Return Value
            End If

            With objEnt
                If .CalendarioDetalleID < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
            End With
            Value = Data.Visita.Programacion.CalendarioDetalle.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
        Public Function GrabarEstado(ByVal Codigo As Integer, ByVal Estado As Integer) As Integer

            Dim Value As Integer = -1

            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_estado"

            objEnt = New Entity.Visita.Programacion.CalendarioDetalle
            With objEnt
                .CalendarioDetalleID = Codigo
                .DetalleEstado = Estado
            End With

            Value = Data.Visita.Programacion.CalendarioDetalle.Grabar(strAccion, strOpcion, objEnt)

            Return Value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.Programacion.CalendarioDetalle) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            'validar si el calendario detalle ya esta en uso.
            If ValidarMovimiento(ObjEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El registro actual no se puede eliminar, debido que ya se encuentra en uso en el modulo de visita")
                Return Value
            End If

            Value = Data.Visita.Programacion.CalendarioDetalle.Eliminar(strAccion, strOpcion, ObjEnt)

            Return Value
        End Function
#End Region
    End Class
End Namespace