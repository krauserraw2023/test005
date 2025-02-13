Imports System.Data
Imports System.Data.SqlClient
Namespace Clasificacion
    Public Class MaestroVariable
        Private objEnt As Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE = Nothing
        Private objEntCol As Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
            Dim entVariable As New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
            entVariable.Codigo = Codigo
            objEntCol = Listar(entVariable)

            If objEntCol Is Nothing Then Return Nothing

            Return objEntCol.Variable(0)
        End Function

        Public Function Listar(entVariable As Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE) As Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroVariable.Listar(sqlCon, "lst", "lst_mant", entVariable)
            Try
                objEntCol = New Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
                        With objEnt
                            .Codigo = sqlDr("pk_var_id").ToString
                            .FichaID = sqlDr("fk_fic_id").ToString
                            .NumeroOrden = sqlDr("n_var_num_ord").ToString
                            .Nombre = sqlDr("c_var_nom").ToString
                            .Descripcion = sqlDr("c_var_des").ToString
                            .PuntajeNoPrevisto = sqlDr("ptje_no_pre").ToString
                            .Puntaje = sqlDr("num_pond").ToString
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
        Public Function Listar_pen(entVariable As Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE) As Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroVariable.Listar(sqlCon, "lst", "lst_mant_pen", entVariable)
            Try
                objEntCol = New Entity.Registro.Carceleta.Clasificacion.MaestroVariableCol_BE
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
                        With objEnt
                            .Codigo = sqlDr("pk_var_id").ToString
                            .FichaID = sqlDr("fk_fic_id").ToString
                            .VariableMaestraID = sqlDr("fk_var_mae_id").ToString
                            .NumeroOrden = sqlDr("n_var_num_ord").ToString
                            .Nombre = sqlDr("c_var_nom").ToString
                            .Descripcion = sqlDr("c_var_des").ToString
                            .PuntajeNoPrevisto = sqlDr("ptje_no_pre").ToString
                            .Puntaje = sqlDr("num_pond").ToString
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
        Private Function Validar(_objEnt As Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE, ByRef outErrSms As String) As Boolean
            If _objEnt.FichaID = -1 Then outErrSms = "FichaId no valido"
            If _objEnt.NumeroOrden <= 0 Then outErrSms = outErrSms & "Número de orden no erroneo" & vbCrLf
            If _objEnt.Nombre.Length = 0 Then outErrSms = outErrSms & "Ingrese el nombre de la variable" & vbCrLf

            'buscar nombres duplicados
            objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
            objEnt.Nombre = _objEnt.Nombre
            objEnt.FichaID = _objEnt.FichaID
            If _objEnt.Codigo = -1 Then
                If Listar(objEnt).Count > 0 Then outErrSms = outErrSms & "La variable con el nombre " & _objEnt.Nombre & " ya existe, cambie por otro nombre" & vbCrLf
            Else
                objEntCol = Listar(objEnt)
                If objEntCol.Count > 0 Then
                    If objEntCol.Variable(0).Codigo <> _objEnt.Codigo Then outErrSms = outErrSms & "La descripción con el nombre " & _objEnt.Nombre & " ya existe, cambie por otro nombre" & vbCrLf
                End If
            End If

            objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE
            objEnt.FichaID = _objEnt.FichaID
            objEnt.NumeroOrden = _objEnt.NumeroOrden
            objEntCol = Listar(objEnt)
            If objEntCol.Count > 0 Then
                If _objEnt.Codigo = -1 Then
                    outErrSms = outErrSms & "El número de orden ya fue asignado a otra variable, cambie por otro" & vbCrLf
                    Return False
                Else
                    If _objEnt.Codigo <> objEntCol.Variable(0).Codigo Then
                        outErrSms = outErrSms & "El número de orden ya fue asignado a otra variable, cambie por otro" & vbCrLf
                        Return False
                    End If
                End If
            End If
            
            If outErrSms.Length > 0 Then Return False
            Return True
        End Function

        Function Grabar(entCat As Entity.Registro.Carceleta.Clasificacion.MaestroVariable_BE, ByRef outErrSms As String) As Integer
            If Validar(entCat, outErrSms) = False Then Return -1

            entCat.Descripcion = entCat.Descripcion.Trim.ToUpper.Replace("  ", "")
            entCat.Nombre = entCat.Nombre.Trim.ToUpper.Replace("  ", "")

            Dim strOpcion As String
            Dim strAccion As String
            If entCat.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
            Dim v As Integer
            v = Data.Clasificacion.MaestroVariable.Grabar(strAccion, strOpcion, entCat)
            Return v
        End Function
#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByRef outErrSms As String) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Clasificacion.MaestroVariable.Eliminar(strAccion, strOpcion, Codigo, outErrSms)
            Return intValue
        End Function
#End Region
    End Class
End Namespace