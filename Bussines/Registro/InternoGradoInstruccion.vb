Imports System.Data.SqlClient

Namespace Registro
    Public Class InternoGradoInstruccion


        Public Function Listar(Codigo As Integer) As Entity.Registro.InternoGradoInstruccion

            If Codigo <= -1 Then Return Nothing

            Dim col As Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            Dim ent As New Entity.Registro.InternoGradoInstruccion
            ent.Codigo = Codigo
            col = Listar(ent)
            If col.Count = 0 Then Return Nothing
            Return col.Entity(0)
        End Function

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.InternoGradoInstruccion

            If Codigo <= -1 Then Return Nothing

            Dim col As Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            Dim ent As New Entity.Registro.InternoGradoInstruccion
            ent.Codigo = Codigo
            col = Listar_LM(ent)
            If col.Count = 0 Then Return Nothing
            Return col.Entity(0)
        End Function

        Public Function Listar_LM(ent As Entity.Registro.InternoGradoInstruccion) As Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            Dim opc As String = ""

            opc = "lst_mant_LM"

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGradoInstruccion.Listar_LM(sqlCon, "lst", opc, ent)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            Dim objEnt As Entity.Registro.InternoGradoInstruccion

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoGradoInstruccion
                        With objEnt
                            .Codigo = sqlDr("pk_int_gra_ins_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .GradoInstruccionId = sqlDr("fk_grd_ins_id").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .RegionId = sqlDr("reg_id").ToString
                            .PenalId = sqlDr("pen_id").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .GradoInstruccionStr = sqlDr("grado_desc").ToString
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

        Public Function Listar(ent As Entity.Registro.InternoGradoInstruccion) As Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGradoInstruccion.Listar(sqlCon, "lst", "lst_mant", ent)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            Dim objEnt As Entity.Registro.InternoGradoInstruccion

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoGradoInstruccion
                        With objEnt
                            .Codigo = sqlDr("pk_int_gra_ins_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .GradoInstruccionId = sqlDr("fk_grd_ins_id").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .RegionId = sqlDr("reg_id").ToString
                            .PenalId = sqlDr("pen_id").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .GradoInstruccionStr = sqlDr("grado_desc").ToString
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

        Public Function Listar_Grilla(ent As Entity.Registro.InternoGradoInstruccion) As Entity.Registro.InternoGradoInstruccionCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGradoInstruccion.Listar(sqlCon, "lst", "lst_grilla", ent)
            Dim objEntCol As New Entity.Registro.InternoGradoInstruccionCol
            Dim objEnt As Entity.Registro.InternoGradoInstruccion

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoGradoInstruccion
                        With objEnt
                            .Codigo = sqlDr("pk_int_gra_ins_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .GradoInstruccionId = sqlDr("fk_grd_ins_id").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .RegionId = sqlDr("reg_id").ToString
                            .PenalId = sqlDr("pen_id").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .GradoInstruccionStr = sqlDr("grado_desc").ToString
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

        Public Function Listar_Grilla_LM(ent As Entity.Registro.InternoGradoInstruccion, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.Registro.InternoGradoInstruccionCol
            Dim opc As String = ""

            opc = "lst_grilla_LM"

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoGradoInstruccion.Listar_LM(sqlCon, "lst", opc, ent)
            Dim objEntCol As New Entity.Registro.InternoGradoInstruccionCol
            Dim objEnt As Entity.Registro.InternoGradoInstruccion

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoGradoInstruccion
                        With objEnt
                            .Codigo = sqlDr("pk_int_gra_ins_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .GradoInstruccionId = sqlDr("fk_grd_ins_id").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .RegionId = sqlDr("reg_id").ToString
                            .PenalId = sqlDr("pen_id").ToString
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .GradoInstruccionStr = sqlDr("grado_desc").ToString
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

        Private Function validar(objEnt As Entity.Registro.InternoGradoInstruccion, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Boolean
            Dim sms As String = ""

            Dim tmpEnt As New Entity.Registro.InternoGradoInstruccion
            Dim tmpEntCol As New Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            tmpEnt.InternoId = objEnt.InternoId
            tmpEnt.GradoInstruccionId = objEnt.GradoInstruccionId
            tmpEntCol = Listar(tmpEnt)

            If tmpEntCol.Count > 0 Then
                tmpEnt = tmpEntCol.Item(0)
                If objEnt.Codigo > 0 Then
                    If objEnt.GradoInstruccionId = tmpEnt.GradoInstruccionId And objEnt.Codigo <> tmpEnt.Codigo Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Grado de instrucción duplicado."
                    End If
                Else
                    If tmpEnt.GradoInstruccionId = objEnt.GradoInstruccionId Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Grado de instrucción duplicado."
                    End If
                End If
            End If
            If objEnt.GradoInstruccionId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Grado de instrucción no especificado."
            If objEnt.Codigo = -1 Then
                If objEnt.InternoId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id del interno no especificado."
                If validarIngreso = True And objEnt.IngresoId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de ingreso no especificado."
                If objEnt.PenalId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Penal no especificado."
                If objEnt.RegionId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Región no especificado."
            End If
            If sms.Length > 2 Then
                outSMS = sms
                Return False
            Else
                Return True
            End If
        End Function

        Public Function Grabar(objEnt As Entity.Registro.InternoGradoInstruccion, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Try
                If validar(objEnt, outSMS, validarIngreso) = False Then Return -1

                If objEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Registro.InternoGradoInstruccion.Grabar(strAccion, strOpcion, objEnt)

                If intValue = -1 Then outSMS = "No se pudo grabar Grado de instrucción."

            Catch ex As Exception
                outSMS = ex.Message
            End Try

            Return intValue
        End Function


        Private Function validar_LM(objEnt As Entity.Registro.InternoGradoInstruccion, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Boolean
            Dim sms As String = ""

            Dim tmpEnt As New Entity.Registro.InternoGradoInstruccion
            Dim tmpEntCol As New Entity.EntityCol(Of Entity.Registro.InternoGradoInstruccion)
            tmpEnt.InternoId = objEnt.InternoId
            tmpEnt.GradoInstruccionId = objEnt.GradoInstruccionId
            tmpEntCol = Listar_LM(tmpEnt)

            If tmpEntCol.Count > 0 Then
                tmpEnt = tmpEntCol.Item(0)
                If objEnt.Codigo > 0 Then
                    If objEnt.GradoInstruccionId = tmpEnt.GradoInstruccionId And objEnt.Codigo <> tmpEnt.Codigo Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Grado de instrucción duplicado."
                    End If
                Else
                    If tmpEnt.GradoInstruccionId = objEnt.GradoInstruccionId Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Grado de instrucción duplicado."
                    End If
                End If
            End If
            If objEnt.GradoInstruccionId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Grado de instrucción no especificado."
            If objEnt.Codigo = -1 Then
                If objEnt.InternoId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id del interno no especificado."
                If validarIngreso = True And objEnt.IngresoInpeId = -1 And objEnt.IngresoId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de ingreso no especificado."
                If objEnt.PenalId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Penal no especificado."
                If objEnt.RegionId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Región no especificado."
            End If
            If sms.Length > 2 Then
                outSMS = sms
                Return False
            Else
                Return True
            End If
        End Function

        Public Function Grabar_LM(objEnt As Entity.Registro.InternoGradoInstruccion, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Try
                If validar_LM(objEnt, outSMS, validarIngreso) = False Then Return -1

                If objEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_LM"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant_LM"
                End If

                intValue = Data.Registro.InternoGradoInstruccion.Grabar_LM(strAccion, strOpcion, objEnt)

                If intValue = -1 Then outSMS = "No se pudo grabar Grado de instrucción."

            Catch ex As Exception
                outSMS = ex.Message
            End Try

            Return intValue
        End Function

        Public Function Eliminar(Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = "del"
            Dim strOpcion As String = "del_mant"
            intValue = Data.Registro.InternoGradoInstruccion.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function

    End Class
End Namespace