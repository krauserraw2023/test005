Imports System.Data
Imports System.Data.SqlClient
Imports Entity

Namespace Estadistica
    Public Class Padin
        Private Shared strNameProcedure As String = "UP_RPT_Padin"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal RegionID As Integer, ByVal PenalID As Integer, ByVal InternoID As Integer, ByVal Anio As Integer, ByVal Mes As Integer, _
        ByVal Estado As Integer, ByVal FechaIni As Long, ByVal FechaCorte As Long, ByVal FechaProceso As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 1800
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@pad_anio", SqlDbType.Int)).Value = Anio
                    .Parameters.Add(New SqlParameter("@pad_mes", SqlDbType.Int)).Value = Mes
                    .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = Estado
                    '/*filtros*/
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = FechaIni
                    .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = FechaCorte
                    .Parameters.Add(New SqlParameter("@pad_fec_pro", SqlDbType.BigInt)).Value = FechaProceso
                End With

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, accion As String, opcion As String, objEnt As Entity.Estadistica.Padin) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 1800
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = -1
                    .Parameters.Add(New SqlParameter("@pad_anio", SqlDbType.Int)).Value = objEnt.Anio
                    .Parameters.Add(New SqlParameter("@pad_mes", SqlDbType.Int)).Value = objEnt.Mes
                    .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.Estado
                    '/*filtros*/
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.Fecha
                    .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = objEnt.FechaCorte
                    .Parameters.Add(New SqlParameter("@pad_fec_pro", SqlDbType.BigInt)).Value = objEnt.FechaProceso
                    .Parameters.Add(New SqlParameter("@tipo_mov", SqlDbType.Int)).Value = objEnt.TipoMovimiento
                End With

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal Estado As Integer _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = Estado
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal Numero As Integer, ByVal Anio As Integer, ByVal Mes As Integer, _
        ByVal Fecha As Long, ByVal FechaProceso As Long, _
        ByVal FechaEnvio As Long, _
        ByVal Estado As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@pad_num_cor", SqlDbType.Int)).Value = Numero

                            .Parameters.Add(New SqlParameter("@pad_anio", SqlDbType.Int)).Value = Anio
                            .Parameters.Add(New SqlParameter("@pad_mes", SqlDbType.Int)).Value = Mes

                            .Parameters.Add(New SqlParameter("@pad_fec", SqlDbType.BigInt)).Value = Fecha
                            .Parameters.Add(New SqlParameter("@pad_fec_pro", SqlDbType.BigInt)).Value = FechaProceso
                            .Parameters.Add(New SqlParameter("@pad_fec_env", SqlDbType.BigInt)).Value = FechaEnvio
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = Estado

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Estadistica.Padin) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@pad_num_cor", SqlDbType.Int)).Value = objEnt.Numero

                            .Parameters.Add(New SqlParameter("@pad_anio", SqlDbType.Int)).Value = objEnt.Anio
                            .Parameters.Add(New SqlParameter("@pad_mes", SqlDbType.Int)).Value = objEnt.Mes

                            .Parameters.Add(New SqlParameter("@pad_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@pad_fec_pro", SqlDbType.BigInt)).Value = objEnt.FechaProceso
                            .Parameters.Add(New SqlParameter("@pad_fec_env", SqlDbType.BigInt)).Value = objEnt.FechaEnvio
                            .Parameters.Add(New SqlParameter("@pad_fec_cor", SqlDbType.BigInt)).Value = objEnt.FechaCorte
                            .Parameters.Add(New SqlParameter("@pad_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@n_pad_ver", SqlDbType.SmallInt)).Value = objEnt.Version
                            .Parameters.Add(New SqlParameter("@n_ver_rpt", SqlDbType.SmallInt)).Value = objEnt.VersionReporte

                            .Parameters.Add(New SqlParameter("@pad_fec_rec", SqlDbType.BigInt)).Value = objEnt.FechaRecepcion
                            .Parameters.Add(New SqlParameter("@pad_res_reg_usu_id", SqlDbType.Int)).Value = objEnt.IDUsuarioResponsableRegion
                            .Parameters.Add(New SqlParameter("@pad_res_reg_usu_ape_nom ", SqlDbType.VarChar, 150)).Value = objEnt.UsuarioResponsableRegion
                            .Parameters.Add(New SqlParameter("@pad_reg_fec_rpt ", SqlDbType.BigInt)).Value = objEnt.FechaRegionRpta
                            .Parameters.Add(New SqlParameter("@pad_obs_anu", SqlDbType.VarChar, 500)).Value = objEnt.ObservacionAnulacion

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = objEnt.Audit_FechaLong
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        ''' <summary>
        ''' creado:11-01-2016 - hnrb
        ''' Permite anular el registro de padin
        ''' </summary>
        ''' <param name="accion">Accion a ejecutarse en el procedure</param>
        ''' <param name="opcion">Opción</param>
        ''' <param name="Codigo">Id del padin a eliminarse</param>
        ''' <returns>Id del padin anulado</returns>
        Public Shared Function Anular(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class
End Namespace