Imports System.Data
Imports System.Data.SqlClient

Namespace Registro.Documento
    Public Class PeriodoCondenaSentencia
        Dim objEntCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol = Nothing
        Dim objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia = Nothing

#Region "Listar"
        Public Function Listar(ByVal objPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia) As Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            'no necesita metodo copia para Lima Metropolitana
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.PeriodoCondenaSentencia.Listar(sqlCon, "lst", "lst_mant", objPerCond)
            Try
                objEntCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.PeriodoCondenaSentencia
                        With objEnt
                            .Codigo = sqlDr("per_cond_id").ToString
                            .FechaInicio = sqlDr("fec_ini").ToString
                            .FechaFin = sqlDr("fec_fin").ToString
                            .DocJudicialId = sqlDr("doc_jud_id").ToString
                            .RegionId = sqlDr("_regid").ToString
                            .PenalId = sqlDr("_penid").ToString
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
        Public Function Listar_V2(ByVal objPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia) As Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            'no necesita metodo copia para Lima Metropolitana
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.PeriodoCondenaSentencia.Listar_V2(sqlCon, "lst", "lst_mant_v2", objPerCond)
            Try
                objEntCol = New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.PeriodoCondenaSentencia
                        With objEnt
                            .Codigo = sqlDr("per_cond_id").ToString
                            .Tipo = sqlDr("per_con_tip").ToString
                            .FechaInicio = sqlDr("fec_ini").ToString
                            .FechaFin = sqlDr("fec_fin").ToString
                            .Anio = sqlDr("per_con_anio").ToString
                            .Mes = sqlDr("per_con_mes").ToString
                            .Dia = sqlDr("per_con_dia").ToString
                            .DocJudicialId = sqlDr("doc_jud_id").ToString
                            .RegionId = sqlDr("_regid").ToString
                            .PenalId = sqlDr("_penid").ToString
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
#Region "Validar"
        Public Function Validar(anhos As String, mes As String, dias As String, EntPerCol As Entity.Registro.Documento.PeriodoCondenaSentenciaCol) As String

            Dim Percol As New Entity.Registro.Documento.PeriodoCondenaSentenciaCol
            Dim blnOrden As Boolean = False
            Dim valor As String = ""
            If anhos = "" Then anhos = 0
            If mes = "" Then mes = 0
            If dias = "" Then dias = 0
            ' Dim valor1, valor2, valor3 As String
            For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In EntPerCol
                If obj.FlgEliminado = False Then
                    If Not (IsDate(obj.FechaInicioString)) And Not (IsDate(obj.FechaFinString)) Then
                        valor = "El periodo de condena no tiene un formato de fecha correcta, modifique o elimine el registro"
                        Return valor
                        Exit For
                    End If
                    'Dim fechaIniaux As String = ""
                    'Dim fechaFinaux As String = ""
                    'If Not (IsDate(obj.FechaInicioString)) Then
                    '    fechaIniaux = "01/01/1900"
                    'End If
                    'If IsDate(obj.FechaFinString) Then
                    '    fechaFinaux = "01/01/1900"
                    'End If
                    'If EntPerCol.Count = 1 Then
                    '    valor1 = DateAdd(DateInterval.Year, CInt(anhos), CDate(fechaIniaux))
                    '    valor2 = DateAdd(DateInterval.Month, CInt(mes), CDate(Valor1))
                    '    valor3 = DateAdd(DateInterval.Day, CInt(dias), CDate(valor2))
                    '    If valor3 <> fechaFinaux Then
                    '        valor = "El periodo de condena (" & fechaIniaux & " al " & fechaFinaux & ")" + Chr(13) +
                    '                "no coincide con el tiempo de condena " & anhos & "a " & mes & "m " & dias & "d" + Chr(13) +
                    '                " " + Chr(13) +
                    '                valor
                    '    End If
                    'Else
                    '    Dim FechaEnt As New Entity.Registro.Documento.PeriodoCondenaSentencia
                    '    Dim Fecha As String = ""
                    '    Fecha = (DateDiff(DateInterval.Day, CDate(fechaIniaux), CDate(fechaFinaux)))
                    '    Dim NroAnhos As Integer = 0
                    '    Dim NroMeses As Integer = 0
                    '    Dim NroDias As Integer = 0
                    '    If CInt(Fecha) >= 365 Then
                    '        NroAnhos = CInt(Fecha) / 365
                    '        Dim ResAnho As Integer = CInt(Fecha) Mod 365
                    '        If ResAnho >= 30 Then
                    '            NroMeses = ResAnho / 30
                    '            NroDias = ResAnho Mod 30
                    '        Else
                    '            NroDias = ResAnho
                    '        End If
                    '    ElseIf CInt(Fecha) > 30 Then
                    '        'NroMeses = CInt(Fecha) / 30
                    '        NroMeses = (CInt(Fecha - NroDias)) / 30
                    '        If NroMeses * 30 > CInt(Fecha) Then
                    '            NroMeses = NroMeses - 1
                    '        End If
                    '        NroDias = CInt(Fecha) - 30 * NroMeses
                    '        If NroDias < 0 Then
                    '            NroDias = 0
                    '        End If
                    '        'NroDias = CInt(Fecha) Mod 30
                    '    Else
                    '        NroDias = CInt(Fecha)
                    '    End If
                    '    FechaEnt.fechaAnhos = NroAnhos
                    '    FechaEnt.fechaMeses = NroMeses
                    '    FechaEnt.fechaDias = NroDias
                    '    Percol.Add(FechaEnt)
                    '    blnOrden = True
                    'End If
                End If
            Next
            'If EntPerCol.Count > 1 And blnOrden = True Then
            '    Dim anhos2 As Integer = 0
            '    Dim meses2 As Integer = 0
            '    Dim dia2 As Integer = 0
            '    For Each obj As Entity.Registro.Documento.PeriodoCondenaSentencia In Percol
            '        anhos2 = anhos2 + obj.fechaAnhos
            '        meses2 = meses2 + obj.fechaMeses
            '        dia2 = dia2 + obj.fechaDias
            '    Next
            '    If dia2 >= 30 Then
            '        meses2 = meses2 + 1
            '        dia2 = (dia2 Mod 30)
            '    End If
            '    If anhos2 = anhos And mes = meses2 And dias = dia2 Then
            '    Else
            '        valor = "El periodo de condena no coincide con el tiempo de condena" + Chr(13) +
            '                " " + Chr(13) +
            '                valor
            '    End If
            'End If
            Return valor
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objPerCond.Codigo < 1 Then
                         strAccion = "ins"
                         strOpcion = "ins_mant"
                     Else
                         strAccion = "upd"
                         strOpcion = "upd_mant"
                     End If

                     intValue = Data.Registro.Documento.PeriodoCondenaSentencia.Grabar(strAccion, strOpcion, objPerCond)

                     Return intValue
        End Function
        Public Function Grabar_V2(ByVal objPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objPerCond.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_V2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_V2"
            End If

            intValue = Data.Registro.Documento.PeriodoCondenaSentencia.Grabar_V2(strAccion, strOpcion, objPerCond)

            Return intValue
        End Function
        Public Function Grabar_LM_V2(ByVal objPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objPerCond.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM_V2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_V2"
            End If

            intValue = Data.Registro.Documento.PeriodoCondenaSentencia.Grabar_LM_V2(strAccion, strOpcion, objPerCond)

            Return intValue
        End Function
        Public Function Grabar_LM(ByVal objPerCond As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objPerCond.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Documento.PeriodoCondenaSentencia.Grabar_LM(strAccion, strOpcion, objPerCond)

            Return intValue
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Documento.PeriodoCondenaSentencia.Eliminar(strAccion, strOpcion, Codigo, -1, FlagTransferenciaSede)
            Return intValue
        End Function
        Public Function EliminarV2(ByVal Codigo As Integer, Optional DocumentoId As Integer = -1, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_v2"
            intValue = Data.Registro.Documento.PeriodoCondenaSentencia.Eliminar(strAccion, strOpcion, Codigo, DocumentoId, FlagTransferenciaSede)
            Return intValue
        End Function
#End Region
    End Class
End Namespace