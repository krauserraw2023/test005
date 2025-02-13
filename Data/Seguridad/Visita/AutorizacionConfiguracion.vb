Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class AutorizacionConfiguracion
        Private Shared strNameProcedure As String = "UP_VIS_Autorizacion_Configuracion"
        'Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String,
        '                                    ByVal objEnt As Entity.Visita.AutorizacionConfiguracion) As Integer
        '    Try
        '        Dim Value As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@aut_id", SqlDbType.Int)).Value = objEnt.Codigo
        '                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalID
        '                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
        '                    .Parameters.Add(New SqlParameter("@aut_est_id", SqlDbType.SmallInt)).Value = objEnt.EstadoID

        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    Value = .Parameters("@variable_out").Value
        '                    Return Value
        '                End With
        '            End Using
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Visita.AutorizacionConfiguracion) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@aut_conf_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    ''.Parameters.Add(New SqlParameter("@aut_est_id", SqlDbType.SmallInt)).Value = objEnt.EstadoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Visita.AutorizacionConfiguracion) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@aut_conf_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@aut_conf_max_vis", SqlDbType.Int)).Value = objEnt.ConfiguracionDiaMaximo
                            .Parameters.Add(New SqlParameter("@aut_conf_ene", SqlDbType.Bit)).Value = objEnt.ConfiguracionEnero
                            .Parameters.Add(New SqlParameter("@aut_conf_feb", SqlDbType.Bit)).Value = objEnt.ConfiguracionFebrero
                            .Parameters.Add(New SqlParameter("@aut_conf_mar", SqlDbType.Bit)).Value = objEnt.ConfiguracionMarzo
                            .Parameters.Add(New SqlParameter("@aut_conf_abr", SqlDbType.Bit)).Value = objEnt.ConfiguracionAbril
                            .Parameters.Add(New SqlParameter("@aut_conf_may", SqlDbType.Bit)).Value = objEnt.ConfiguracionMayo
                            .Parameters.Add(New SqlParameter("@aut_conf_jun", SqlDbType.Bit)).Value = objEnt.ConfiguracionJunio
                            .Parameters.Add(New SqlParameter("@aut_conf_jul", SqlDbType.Bit)).Value = objEnt.ConfiguracionJulio
                            .Parameters.Add(New SqlParameter("@aut_conf_ago", SqlDbType.Bit)).Value = objEnt.ConfiguracionAgosto
                            .Parameters.Add(New SqlParameter("@aut_conf_set", SqlDbType.Bit)).Value = objEnt.ConfiguracionSetiembre
                            .Parameters.Add(New SqlParameter("@aut_conf_oct", SqlDbType.Bit)).Value = objEnt.ConfiguracionOctubre
                            .Parameters.Add(New SqlParameter("@aut_conf_nov", SqlDbType.Bit)).Value = objEnt.ConfiguracionNoviembre
                            .Parameters.Add(New SqlParameter("@aut_conf_dic", SqlDbType.Bit)).Value = objEnt.ConfiguracionDiciembre
                            .Parameters.Add(New SqlParameter("@aut_conf_est", SqlDbType.SmallInt)).Value = objEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@aut_conf_obs", SqlDbType.VarChar, 500)).Value = objEnt.ConfiguracionObs
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String,
                                        ByVal objEnt As Entity.Visita.AutorizacionConfiguracion) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@aut_conf_id", SqlDbType.Int)).Value = objEnt.Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
    End Class
End Namespace