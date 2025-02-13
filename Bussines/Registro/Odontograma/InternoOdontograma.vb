Imports System.Data.SqlClient

Namespace Registro.Odontograma
    Public Class InternoOdontograma

#Region "Listar"
        Public Function Listar(Codigo As Integer) As Entity.Registro.Odontograma.InternoOdontograma
            Dim objEnt As New Entity.Registro.Odontograma.InternoOdontograma
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)
            objEnt.Codigo = Codigo
            objEntCol = Listar(objEnt)

            If objEntCol.Count = 0 Then Return Nothing

            Return objEntCol.Item(0)
        End Function

        Public Function ListarOdontogramaActual_LM(InternoId As Integer) As Entity.Registro.Odontograma.InternoOdontograma 'lista el odontograma del ultimo ingreso
            Dim objEnt As New Entity.Registro.Odontograma.InternoOdontograma
            objEnt.InternoId = InternoId
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Odontograma.InternoOdontograma.Listar(sqlCon, "lst", "lst_odont_actual_lm", objEnt)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Odontograma.InternoOdontograma
                        With objEnt
                            .Codigo = sqlDr("pk_int_odn_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .Observaciones = sqlDr("c_int_odn_obs").ToString
                            .Especificaciones = sqlDr("c_int_odn_esp").ToString
                            .ArcoDentarioSupId = sqlDr("fk_arc_dnt_tip_sup_id").ToString
                            .ArcoDentarioSupNombre = sqlDr("arco_dent_sup").ToString
                            .ArcoDentarioInfId = sqlDr("fk_arc_dnt_tip_inf_id").ToString
                            .ArcoDentarioInfNombre = sqlDr("arco_dent_inf").ToString
                            .TamanioDentoMaxilarId = sqlDr("fk_tam_dmx_id").ToString
                            .TamanioDentoMaxilarNombre = sqlDr("tam_dentomax").ToString
                            .TamanioDienteId = sqlDr("fk_tam_die_id").ToString
                            .TamanioDienteNombre = sqlDr("tam_diente").ToString
                            .DienteTipoId = sqlDr("fk_die_tip_id").ToString
                            .DienteTipoNombre = sqlDr("tip_dient").ToString
                            .OclusionTipoId = sqlDr("fk_ocl_tip_id").ToString
                            .RugaPalatinaId = sqlDr("fk_rug_pal_id").ToString
                            .OclusionTipoNombre = sqlDr("tip_oclus").ToString
                            .RegionId = sqlDr("RegId").ToString
                            .PenalId = sqlDr("PenId").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
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

        Public Function ListarOdontogramaActual(InternoId As Integer) As Entity.Registro.Odontograma.InternoOdontograma 'lista el odontograma del ultimo ingreso
            Dim objEnt As New Entity.Registro.Odontograma.InternoOdontograma
            objEnt.InternoId = InternoId
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Odontograma.InternoOdontograma.Listar(sqlCon, "lst", "lst_odont_actual", objEnt)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Odontograma.InternoOdontograma
                        With objEnt
                            .Codigo = sqlDr("pk_int_odn_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .Observaciones = sqlDr("c_int_odn_obs").ToString
                            .Especificaciones = sqlDr("c_int_odn_esp").ToString
                            .ArcoDentarioSupId = sqlDr("fk_arc_dnt_tip_sup_id").ToString
                            .ArcoDentarioSupNombre = sqlDr("arco_dent_sup").ToString
                            .ArcoDentarioInfId = sqlDr("fk_arc_dnt_tip_inf_id").ToString
                            .ArcoDentarioInfNombre = sqlDr("arco_dent_inf").ToString
                            .TamanioDentoMaxilarId = sqlDr("fk_tam_dmx_id").ToString
                            .TamanioDentoMaxilarNombre = sqlDr("tam_dentomax").ToString
                            .TamanioDienteId = sqlDr("fk_tam_die_id").ToString
                            .TamanioDienteNombre = sqlDr("tam_diente").ToString
                            .DienteTipoId = sqlDr("fk_die_tip_id").ToString
                            .DienteTipoNombre = sqlDr("tip_dient").ToString
                            .OclusionTipoId = sqlDr("fk_ocl_tip_id").ToString
                            .RugaPalatinaId = sqlDr("fk_rug_pal_id").ToString
                            .OclusionTipoNombre = sqlDr("tip_oclus").ToString
                            .RegionId = sqlDr("RegId").ToString
                            .PenalId = sqlDr("PenId").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
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

        Public Function Listar(objEnt As Entity.Registro.Odontograma.InternoOdontograma) As Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Odontograma.InternoOdontograma.Listar(sqlCon, "lst", "lst_mant", objEnt)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Odontograma.InternoOdontograma
                        With objEnt
                            .Codigo = sqlDr("pk_int_odn_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .Observaciones = sqlDr("c_int_odn_obs").ToString
                            .Especificaciones = sqlDr("c_int_odn_esp").ToString
                            .ArcoDentarioSupId = sqlDr("fk_arc_dnt_tip_sup_id").ToString
                            .ArcoDentarioSupNombre = sqlDr("arco_dent_sup").ToString
                            .ArcoDentarioInfId = sqlDr("fk_arc_dnt_tip_inf_id").ToString
                            .ArcoDentarioInfNombre = sqlDr("arco_dent_inf").ToString
                            .TamanioDentoMaxilarId = sqlDr("fk_tam_dmx_id").ToString
                            .TamanioDentoMaxilarNombre = sqlDr("tam_dentomax").ToString
                            .TamanioDienteId = sqlDr("fk_tam_die_id").ToString
                            .TamanioDienteNombre = sqlDr("tam_diente").ToString
                            .DienteTipoId = sqlDr("fk_die_tip_id").ToString
                            .DienteTipoNombre = sqlDr("tip_dient").ToString
                            .OclusionTipoId = sqlDr("fk_ocl_tip_id").ToString
                            .RugaPalatinaId = sqlDr("fk_rug_pal_id").ToString
                            .OclusionTipoNombre = sqlDr("tip_oclus").ToString
                            '.ArchivoDigitalId = sqlDr("fk_arc_dig_id").ToString
                            .RegionId = sqlDr("RegId").ToString
                            .PenalId = sqlDr("PenId").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            '.NumeroIngreso = sqlDr("c_num_ing").ToString
                        End With

                        'Dim entAD As New Entity.Globall.ArchivoDigitalizado
                        'Dim entADCol As New Entity.Globall.ArchivoDigitalizadoCol
                        'entAD.IdRegistroForaneo = objEnt.Codigo
                        'entADCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(entAD)
                        'If Not entADCol Is Nothing Then
                        '    If entADCol.Count > 0 Then objEnt.OdontogramaByte = entADCol.Archivodigital(0).ArchivoDigitalByte
                        'End If

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

        Public Function Listar_grilla(objEnt As Entity.Registro.Odontograma.InternoOdontograma, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)
            Dim opc As String = ""
            Select Case TipoLic
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    opc = "lst_grilla_sede_lm"
                    'Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    'opc = "lst_grilla_penal_lm"
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    opc = "lst_grilla_penal"
            End Select

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Odontograma.InternoOdontograma.Listar(sqlCon, "lst", opc, objEnt)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Odontograma.InternoOdontograma
                        With objEnt
                            .Codigo = sqlDr("pk_int_odn_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .Observaciones = sqlDr("c_int_odn_obs").ToString
                            .Especificaciones = sqlDr("c_int_odn_esp").ToString
                            .ArcoDentarioSupId = sqlDr("fk_arc_dnt_tip_sup_id").ToString
                            .ArcoDentarioSupNombre = sqlDr("arco_dent_sup").ToString
                            .ArcoDentarioInfId = sqlDr("fk_arc_dnt_tip_inf_id").ToString
                            .ArcoDentarioInfNombre = sqlDr("arco_dent_inf").ToString
                            .TamanioDentoMaxilarId = sqlDr("fk_tam_dmx_id").ToString
                            .TamanioDentoMaxilarNombre = sqlDr("tam_dentomax").ToString
                            .TamanioDienteId = sqlDr("fk_tam_die_id").ToString
                            .TamanioDienteNombre = sqlDr("tam_diente").ToString
                            .DienteTipoId = sqlDr("fk_die_tip_id").ToString
                            .DienteTipoNombre = sqlDr("tip_dient").ToString
                            .OclusionTipoId = sqlDr("fk_ocl_tip_id").ToString
                            .RugaPalatinaId = sqlDr("fk_rug_pal_id").ToString
                            .OclusionTipoNombre = sqlDr("tip_oclus").ToString
                            '.ArchivoDigitalId = sqlDr("fk_arc_dig_id").ToString
                            .RegionId = sqlDr("RegId").ToString
                            .PenalId = sqlDr("PenId").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .NumeroIngreso = sqlDr("ing_pen_nro").ToString
                            .IngresoNroInpe = sqlDr("ing_inpe_nro").ToString
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

            objEntCol.Sort("FechaRegistro", Entity.SortDirection.Desc)

            Return objEntCol
        End Function

        Public Function listarGrilla(objEnt As Entity.Registro.Odontograma.InternoOdontograma) As Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)

            'Dim opcion As String = ""
            'Dim tipoLicencia As Integer = Bussines.Sistema.Instalacion.listarTipoLicencia(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            'Select Case tipoLicencia

            '    Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
            '         Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
            '         Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana

            '        opcion = "lst_grilla_sede_lm"

            '    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
            '         Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia

            '        opcion = "lst_grilla_penal"
            'End Select

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Odontograma.InternoOdontograma.Listar(sqlCon, "lst", "lst_grilla", objEnt)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Odontograma.InternoOdontograma)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Odontograma.InternoOdontograma
                        With objEnt
                            .Codigo = sqlDr("pk_int_odn_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .IngresoNroInpe = sqlDr("ing_inpe_nro").ToString
                            .NumeroIngreso = sqlDr("ing_pen_nro").ToString
                            .version = sqlDr("n_ver").ToString
                            .nombreArchivo = sqlDr("c_nom_arc_odo").ToString
                            .Observaciones = sqlDr("c_int_odn_obs").ToString
                            .Especificaciones = sqlDr("c_int_odn_esp").ToString
                            .RegionId = sqlDr("RegId").ToString
                            .PenalId = sqlDr("PenId").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
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

            objEntCol.Sort("FechaRegistro", Entity.SortDirection.Desc)

            Return objEntCol
        End Function
#End Region
#Region "Accion"
        Private Function Validar(ByVal objEnt As Entity.Registro.Odontograma.InternoOdontograma, ByRef sms As String, Optional validarIngreso As Boolean = True) As Boolean

            Dim blnErr As Boolean = False
            If validarIngreso = True And objEnt.IngresoId <= 0 Then
                sms = "IngresoId =" & objEnt.IngresoId & " no válido"
                blnErr = True
            End If
            'If objEnt.ArchivoDigitalId = -1 Then
            '    sms = If(sms = "", sms, sms & vbCrLf)
            '    sms = sms & "Id del archivo digital no válido"
            'End If
            If objEnt.InternoId <= 0 Then
                sms = If(sms = "", sms, sms & vbCrLf)
                sms = sms & "InternoId =" & objEnt.InternoId & " no válido"
                blnErr = True
            End If
            If objEnt.PenalId <= 0 Then
                sms = If(sms = "", sms, sms & vbCrLf)
                sms = sms & "PenalId =" & objEnt.PenalId & " válido"
                blnErr = True
            End If
            If objEnt.RegionId <= 0 Then
                sms = If(sms = "", sms, sms & vbCrLf)
                sms = sms & "RegionId =" & objEnt.RegionId & " válido"
                blnErr = True
            End If
            Return blnErr
        End Function

        Public Function Grabar(ByVal objEnt As Entity.Registro.Odontograma.InternoOdontograma, ByRef outSMS As String) As Integer

            If Validar(objEnt, outSMS, False) = True Then Return False

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Odontograma.InternoOdontograma.Grabar(strAccion, strOpcion, objEnt)
            If intValue = -1 Then outSMS = "Error al guardar registro de odontograma"

            Return intValue
        End Function

        Public Function grabarv2(ByVal objEnt As Entity.Registro.Odontograma.InternoOdontograma, ByRef outSMS As String) As Integer

            'jmr-20.04.2022, grabar nueva version del odontograma 
            If Validar(objEnt, outSMS, False) = True Then Return False

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            If objEnt.nombreArchivo.Length < 3 Then
                Try
                    Dim nombreArchivo As String = ""
                    Dim bssArchivoOdon As New Bussines.Globall.ArchivoDigitalizado
                    nombreArchivo = bssArchivoOdon.listarMant(objEnt.Codigo).NombreArchivo

                    objEnt.nombreArchivo = nombreArchivo

                Catch ex As Exception

                End Try
            End If

            intValue = Data.Registro.Odontograma.InternoOdontograma.Grabar(strAccion, strOpcion, objEnt)
            If intValue = -1 Then outSMS = "Error al guardar registro de odontograma"

            Return intValue
        End Function
        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Odontograma.InternoOdontograma.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
#End Region
    End Class
End Namespace
