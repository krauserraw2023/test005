Imports System.Data
Imports System.Data.SqlClient
Imports Entity.Registro.Carceleta.Clasificacion

Namespace Clasificacion
    Public Class MaestroIndicador
        Private objEnt As MaestroIndicador_BE = Nothing
        Private objEntCol As MaestroIndicadorCol_BE = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As MaestroIndicador_BE
            If Codigo < 0 Then Return Nothing
            objEnt = New MaestroIndicador_BE
            objEnt.Codigo = Codigo
            objEntCol = Listar(objEnt)
            If objEntCol.Count <= 0 Then Return Nothing
            Return objEntCol.MaestroIndicador(0)
        End Function

        Public Function Listar2(ByVal Codigo As Integer, VarID As Integer, FichaId As Integer) As MaestroIndicador_BE
            If Codigo < 0 Then Return Nothing
            objEnt = New MaestroIndicador_BE
            objEnt.Codigo = Codigo
            objEnt.VariableID = VarID
            objEnt.FichaId = FichaId
            objEntCol = Listar2(objEnt)
            If objEntCol.Count <= 0 Then Return Nothing
            Return objEntCol.MaestroIndicador(0)
        End Function


        Public Function ListarGrillaAgrupada(entInd As MaestroIndicador_BE) As MaestroIndicadorCol_BE
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroIndicador.Listar(sqlCon, "lst", "lst_grilla_agrupada", entInd)
            Try
                objEntCol = New MaestroIndicadorCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New MaestroIndicador_BE
                        With objEnt
                            .Codigo = sqlDr("pk_ind_id").ToString
                            .FichaId = sqlDr("fk_fic_id").ToString
                            .VariableID = sqlDr("fk_var_id").ToString
                            .Secuencia = sqlDr("n_ind_num_ord").ToString
                            .Descripcion = sqlDr("c_ind_des").ToString
                            .Puntaje = sqlDr("n_ind_ptje").ToString
                            .PuntajeProcesado = sqlDr("n_ind_ptje_pro").ToString
                            .PuntajeSentenciado = sqlDr("n_ind_ptje_sen").ToString
                            .Calificacion = sqlDr("c_calificacion").ToString
                            .NombreVariable = sqlDr("c_var_nom").ToString
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
        Public Function Listar(entInd As MaestroIndicador_BE) As MaestroIndicadorCol_BE
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroIndicador.Listar(sqlCon, "lst", "lst_mant", entInd)
            Try
                objEntCol = New MaestroIndicadorCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New MaestroIndicador_BE
                        With objEnt
                            .Codigo = sqlDr("pk_ind_id").ToString
                            .FichaId = sqlDr("fk_fic_id").ToString
                            .VariableID = sqlDr("fk_var_id").ToString
                            .Secuencia = sqlDr("n_ind_num_ord").ToString
                            .Descripcion = sqlDr("c_ind_des").ToString
                            .Puntaje = sqlDr("n_ind_ptje").ToString
                            .PuntajeProcesado = sqlDr("n_ind_ptje_pro").ToString
                            .PuntajeSentenciado = sqlDr("n_ind_ptje_sen").ToString
                            .Calificacion = sqlDr("c_calificacion").ToString
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
        Public Function ListarClas(entInd As MaestroIndicador_BE) As MaestroIndicadorCol_BE
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroIndicador.Listar(sqlCon, "lst", "lst_mant_cla", entInd)
            Try
                objEntCol = New MaestroIndicadorCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New MaestroIndicador_BE
                        With objEnt
                            .Codigo = sqlDr("pk_ind_id").ToString
                            .IndicadorMae = sqlDr("fk_cri_cla_det_id").ToString
                            .FichaId = sqlDr("fk_fic_id").ToString
                            .VariableID = sqlDr("fk_var_id").ToString
                            .Secuencia = sqlDr("n_ind_num_ord").ToString
                            .Descripcion = sqlDr("c_ind_des").ToString
                            .Puntaje = sqlDr("n_ind_ptje").ToString
                            .PuntajeProcesado = sqlDr("n_ind_ptje_pro").ToString
                            .PuntajeSentenciado = sqlDr("n_ind_ptje_sen").ToString
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
        Public Function Listar2(entInd As MaestroIndicador_BE) As MaestroIndicadorCol_BE
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroIndicador.Listar(sqlCon, "lst", "lst_mant", entInd)
            Try
                objEntCol = New MaestroIndicadorCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New MaestroIndicador_BE
                        With objEnt
                            .Codigo = sqlDr("pk_ind_id").ToString
                            .FichaId = sqlDr("fk_fic_id").ToString
                            .VariableID = sqlDr("fk_var_id").ToString
                            .Secuencia = sqlDr("n_ind_num_ord").ToString
                            .Descripcion = sqlDr("c_ind_des").ToString
                            .Puntaje = sqlDr("n_ind_ptje").ToString
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
        Private Function Validar(entInd As MaestroIndicador_BE, ByRef outErrSms As String) As Boolean
            If entInd.FichaId = -1 Then outErrSms = "FichaId no válido"
            If entInd.VariableID = -1 Then outErrSms = "VariableId no válido"
            If entInd.Secuencia <= 0 Then outErrSms = outErrSms & "Número de orden incorrecto" & vbCrLf
            If entInd.Puntaje <= 0 Then outErrSms = outErrSms & "Puntaje no válido" & vbCrLf
            If entInd.Descripcion.Length = 0 Then outErrSms = outErrSms & "Ingrese un nombre de indicador válido" & vbCrLf

            'validar duplicados
            objEnt = New MaestroIndicador_BE
            objEnt.Descripcion = entInd.Descripcion
            objEnt.FichaId = entInd.FichaId
            objEnt.VariableID = entInd.VariableID
            If entInd.Codigo = -1 Then
                If Listar(objEnt).Count > 0 Then outErrSms = outErrSms & "El indicador con el nombre " & entInd.Descripcion & " ya existe, cambie por otro nombre" & vbCrLf
            Else
                objEntCol = Listar(objEnt)
                If objEntCol.Count > 0 Then
                    If objEntCol.MaestroIndicador(0).Codigo <> entInd.Codigo Then outErrSms = outErrSms & "El indicador con el nombre " & entInd.Descripcion & " ya existe, cambie por otro nombre" & vbCrLf
                End If
            End If

            objEnt = New MaestroIndicador_BE
            objEnt.FichaId = entInd.FichaId
            objEnt.VariableID = entInd.VariableID
            objEnt.Secuencia = entInd.Secuencia
            objEntCol = Listar(objEnt)

            If objEntCol.Count > 0 Then
                If entInd.Codigo = -1 Then
                    outErrSms = outErrSms & "El número de orden ya fue asignado a otro indicador, cambie por otro" & vbCrLf
                    Return False
                Else
                    If entInd.Codigo <> objEntCol.MaestroIndicador(0).Codigo Then
                        outErrSms = outErrSms & "El número de orden ya fue asignado a otro indicador, cambie por otro" & vbCrLf
                        Return False
                    End If
                End If
            End If

            If outErrSms.Length > 0 Then Return False
            Return True
        End Function

        Function Grabar(entInd As MaestroIndicador_BE, ByRef outErrSms As String) As Integer
            If Validar(entInd, outErrSms) = False Then Return -1
            Dim strOpcion As String
            Dim strAccion As String
            If entInd.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
            Dim v As Integer
            v = Data.Clasificacion.MaestroIndicador.Grabar(strAccion, strOpcion, entInd)
            Return v
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByRef outErrSms As String) As Integer
            If Codigo = -1 Then Return -1
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Clasificacion.MaestroIndicador.Eliminar(strAccion, strOpcion, Codigo, outErrSms)
            Return intValue
        End Function
#End Region
    End Class
End Namespace