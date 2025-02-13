Imports System.Data.SqlClient

Namespace Registro.Documento
    Public Class DocumentoDigitalizado

        Public Function Listar(Codigo As Integer) As Entity.Registro.Documento.DocumentoDigitalizado
            Dim objEnt As New Entity.Registro.Documento.DocumentoDigitalizado
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Documento.DocumentoDigitalizado)
            objEnt.Codigo = Codigo
            objEntCol = Listar(objEnt)

            If objEntCol.Count = 0 Then Return Nothing

            Return objEntCol.Item(0)
        End Function

        Public Function Listar(objEnt As Entity.Registro.Documento.DocumentoDigitalizado) As Entity.EntityCol(Of Entity.Registro.Documento.DocumentoDigitalizado)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.DocumentoDigitalizado.Listar(sqlCon, "lst", "lst_mant", objEnt)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Documento.DocumentoDigitalizado)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.DocumentoDigitalizado
                        With objEnt
                            .Codigo = sqlDr("pk_doc_dig_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .TituloDoc = sqlDr("c_titulo_doc").ToString
                            .Observaciones = sqlDr("c_obs").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
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
            Return objEntCol
        End Function

        Public Function Listar_grilla(objEnt As Entity.Registro.Documento.DocumentoDigitalizado, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.EntityCol(Of Entity.Registro.Documento.DocumentoDigitalizado)
            Dim opc As String = ""
            Select Case TipoLic
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta, Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana, Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    opc = "lst_grilla_sede_lm"
                    'Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    '   opc = "lst_grilla_sede_lm" 'lst_grilla_penal_lm"
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia, Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    opc = "lst_grilla_penal_pv"
            End Select

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Documento.DocumentoDigitalizado.Listar(sqlCon, "lst", opc, objEnt)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.Documento.DocumentoDigitalizado)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.DocumentoDigitalizado
                        With objEnt
                            .Codigo = sqlDr("pk_doc_dig_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .TituloDoc = sqlDr("c_titulo_doc").ToString
                            .Observaciones = sqlDr("c_obs").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoNroInpe = sqlDr("ing_inpe_nro").ToString
                            .NumeroIngreso = sqlDr("ing_nro").ToString
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

        Private Function Validar_LM(ByVal objEnt As Entity.Registro.Documento.DocumentoDigitalizado, ByRef sms As String, Optional validarIngreso As Boolean = True) As Boolean
            Dim blnErr As Boolean = False
            If objEnt.Codigo = -1 Then 'si es nuevo
                If objEnt.PenalId = -1 Then

                End If
                If objEnt.RegionId = -1 Then
                    sms = If(sms = "", sms, sms & vbCrLf)
                    sms = sms & "RegioId =" & objEnt.RegionId & " no válido"
                    blnErr = True
                End If
            Else

            End If

            Return blnErr
        End Function
        Public Function Grabar_LM(ByVal objEnt As Entity.Registro.Documento.DocumentoDigitalizado, ByRef outSMS As String) As Integer
            If Validar_LM(objEnt, outSMS, False) = True Then Return False

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_lm"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_lm"
            End If

            intValue = Data.Registro.Documento.DocumentoDigitalizado.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Documento.DocumentoDigitalizado.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
    End Class
End Namespace