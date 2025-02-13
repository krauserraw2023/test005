Imports System.Data.SqlClient

Namespace Registro
    Public Class InternoDomicilio
        Public Function Listar(Codigo As Integer) As Entity.Registro.InternoDomicilio

            If Codigo <= -1 Then Return Nothing

            Dim col As Entity.EntityCol(Of Entity.Registro.InternoDomicilio)
            Dim ent As New Entity.Registro.InternoDomicilio

            ent.Codigo = Codigo
            col = Listar(ent)

            If col.Count = 0 Then Return Nothing

            Return col.Item(0)
        End Function

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.InternoDomicilio

            If Codigo <= -1 Then Return Nothing

            Dim col As Entity.EntityCol(Of Entity.Registro.InternoDomicilio)
            Dim ent As New Entity.Registro.InternoDomicilio

            ent.Codigo = Codigo
            col = Listar_LM(ent)

            If col.Count = 0 Then Return Nothing

            Return col.Item(0)
        End Function

        Public Function Listar_grilla(ent As Entity.Registro.InternoDomicilio) As Entity.Registro.InternoDomicilioCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDomicilio.Listar(sqlCon, "lst", "lst_grilla", ent)
            Dim objEntCol As New Entity.Registro.InternoDomicilioCol
            Dim objEnt As Entity.Registro.InternoDomicilio

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoDomicilio
                        With objEnt
                            .Codigo = sqlDr("pk_int_dom_id").ToString

                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .DepartamentoId = sqlDr("fk_dep_id").ToString
                            .ProvinciaId = sqlDr("fk_pro_id").ToString
                            .DistritoId = sqlDr("fk_dis_id").ToString
                            .LugarReferencial = sqlDr("c_lug_ref").ToString
                            .Direccion = sqlDr("c_dir_nom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .DistritoStr = sqlDr("dist_nom").ToString
                            .ProvinciaStr = sqlDr("pro_nom").ToString
                            .DepartamentoStr = sqlDr("dep_nom").ToString
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

        Public Function Listar_grilla_LM(ent As Entity.Registro.InternoDomicilio, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.Registro.InternoDomicilioCol
            Dim opc As String = ""
            opc = "lst_grilla_LM"
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDomicilio.Listar_LM(sqlCon, "lst", opc, ent)
            Dim objEntCol As New Entity.Registro.InternoDomicilioCol
            Dim objEnt As Entity.Registro.InternoDomicilio

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoDomicilio
                        With objEnt
                            .Codigo = sqlDr("pk_int_dom_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .DepartamentoId = sqlDr("fk_dep_id").ToString
                            .ProvinciaId = sqlDr("fk_pro_id").ToString
                            .DistritoId = sqlDr("fk_dis_id").ToString
                            .LugarReferencial = sqlDr("c_lug_ref").ToString
                            .Direccion = sqlDr("c_dir_nom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .DistritoStr = sqlDr("dist_nom").ToString
                            .ProvinciaStr = sqlDr("pro_nom").ToString
                            .DepartamentoStr = sqlDr("dep_nom").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IngresoNroInpe = sqlDr("ing_inp_nro").ToString
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

        Public Function Listar(ent As Entity.Registro.InternoDomicilio) As Entity.EntityCol(Of Entity.Registro.InternoDomicilio)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDomicilio.Listar(sqlCon, "lst", "lst_mant", ent)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.InternoDomicilio)
            Dim objEnt As Entity.Registro.InternoDomicilio

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoDomicilio
                        With objEnt
                            .Codigo = sqlDr("pk_int_dom_id").ToString

                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .DepartamentoId = sqlDr("fk_dep_id").ToString
                            .ProvinciaId = sqlDr("fk_pro_id").ToString
                            .DistritoId = sqlDr("fk_dis_id").ToString
                            .LugarReferencial = sqlDr("c_lug_ref").ToString
                            .Direccion = sqlDr("c_dir_nom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
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

        Public Function Listar_LM(ent As Entity.Registro.InternoDomicilio) As Entity.EntityCol(Of Entity.Registro.InternoDomicilio)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDomicilio.Listar_LM(sqlCon, "lst", "lst_mant_LM", ent)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.InternoDomicilio)
            Dim objEnt As Entity.Registro.InternoDomicilio

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoDomicilio
                        With objEnt
                            .Codigo = sqlDr("pk_int_dom_id").ToString

                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .DepartamentoId = sqlDr("fk_dep_id").ToString
                            .ProvinciaId = sqlDr("fk_pro_id").ToString
                            .DistritoId = sqlDr("fk_dis_id").ToString
                            .LugarReferencial = sqlDr("c_lug_ref").ToString
                            .Direccion = sqlDr("c_dir_nom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
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

        Public Function Validar(Ent As Entity.Registro.InternoDomicilio, ByRef outSms As String, Optional validarIngreso As Boolean = True) As Boolean
            Dim sms As String = ""
            If Ent.Codigo = -1 Then
                If validarIngreso = True And Ent.IngresoId = -1 Then
                    sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de ingreso no válido."
                End If
                If Ent.InternoId = -1 Then
                    sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de interno no válido."
                End If
            End If

            If Ent.DepartamentoId = -1 Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione el departamento."
            End If

            If Ent.ProvinciaId = -1 Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione provincia."
            End If

            If Ent.DistritoId = -1 Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione el distrito."
            End If

            If Ent.Direccion = "" Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Ingrese una dirección válida."
            End If

            If sms.Length > 2 Then
                outSms = sms
                Return False
            Else
                Return True
            End If
        End Function

        Public Function Grabar(Ent As Entity.Registro.InternoDomicilio, ByRef outSms As String, Optional validarIngreso As Boolean = True) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar(Ent, outSms, validarIngreso) = False Then Return -1

            If Ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoDomicilio.Grabar(strAccion, strOpcion, Ent)

            If intValue = -1 Then outSms = "No se pudo grabar el domicilio del interno."

            Return intValue
        End Function

        Public Function Validar_LM(Ent As Entity.Registro.InternoDomicilio, ByRef outSms As String, Optional validarIngreso As Boolean = True) As Boolean
            Dim sms As String = ""
            If Ent.Codigo = -1 Then
                If validarIngreso = True And Ent.IngresoInpeId = -1 And Ent.IngresoId = -1 Then
                    sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de ingreso no válido."
                End If
                If Ent.InternoId = -1 Then
                    sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de interno no válido."
                End If
            End If

            If Ent.DepartamentoId = -1 Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione el departamento."
            End If

            If Ent.ProvinciaId = -1 Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione provincia."
            End If

            If Ent.DistritoId = -1 Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione el distrito."
            End If

            If Ent.Direccion = "" Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Ingrese una dirección válida."
            End If

            If sms.Length > 2 Then
                outSms = sms
                Return False
            Else
                Return True
            End If
        End Function

        Public Function Grabar_LM(Ent As Entity.Registro.InternoDomicilio, ByRef outSms As String, Optional validarIngreso As Boolean = True) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar_LM(Ent, outSms, validarIngreso) = False Then Return -1

            If Ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            intValue = Data.Registro.InternoDomicilio.Grabar_LM(strAccion, strOpcion, Ent)

            If intValue = -1 Then outSms = "No se pudo grabar el domicilio del interno."

            Return intValue
        End Function

        Public Function Eliminar(Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = "del"
            Dim strOpcion As String = "del_mant"
            intValue = Data.Registro.InternoDomicilio.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
    End Class
End Namespace