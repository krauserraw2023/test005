Imports System.Data.SqlClient
Namespace Biometria
    Public Class HuellaDigital
        Private Shared strNameProcedure As String = "pa_mov_huella_digital"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, accion As String, opcion As String, objEnt As Entity.Biometria.HuellaDigital,
                                      ByRef out_sms As String) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 1800
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_hue_dig_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@kf_tmp_id", SqlDbType.Int)).Value = objEnt.IDTemplateHuella
                    '/*region/penal*/
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output
                End With

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try

            Return sqlReader

        End Function

        Public Shared Function Grabar(accion As String, opcion As String, ByVal objEnt As Entity.Biometria.HuellaDigital, ByRef out_sms As String) As Integer

            Dim value As Integer = -1
            Dim sqlCon As SqlConnection
            Dim sqlCmd As SqlCommand

            Try
                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_hue_dig_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@kf_tmp_id", SqlDbType.Int)).Value = objEnt.IDTemplateHuella
                    '/*region/penal*/
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()
                    value = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function

        Public Shared Function Eliminar(accion As String, opcion As String, Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer

            Dim value As Integer = -1
            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_hue_dig_id", SqlDbType.Int)).Value = Codigo

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()
                    value = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return value
        End Function

    End Class
End Namespace
