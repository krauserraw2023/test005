Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia

    Public Class InternoAsistencia
        Private Shared strNameProcedure As String = "usp_tra_tal_mov_InternoAsistencia"
#Region "Listar"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String,
                                            objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@n_tal_asi_fec", SqlDbType.BigInt)).Value = objEnt.Fecha

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_tal_asi_id", SqlDbType.VarChar, 20)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.VarChar, 20)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 100)).Value = objEnt.ApellidosNombres
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 100)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 100)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@n_tal_asi_fec", SqlDbType.VarChar, 100)).Value = objEnt.Fecha
                    .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.Int)).Value = objEnt.CodigoTaller
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.VarChar, 100)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@fechabusIni", SqlDbType.BigInt)).Value = objEnt.FechaInicioBusqueda
                    .Parameters.Add(New SqlParameter("@fechabusFin", SqlDbType.BigInt)).Value = objEnt.FechaFinBusqueda
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region
#Region "Grabar"

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_tal_asi_id", SqlDbType.Int)).Value = objInterno.Codigo
                            .Parameters.Add(New SqlParameter("@n_tal_asi_fec", SqlDbType.BigInt)).Value = objInterno.Fecha
                            .Parameters.Add(New SqlParameter("@c_tal_asi_hor_ent", SqlDbType.VarChar, 20)).Value = objInterno.HoraEntrada
                            .Parameters.Add(New SqlParameter("@c_tal_asi_hor_sal", SqlDbType.VarChar, 20)).Value = objInterno.HoraSalida
                            .Parameters.Add(New SqlParameter("@c_tal_asi_obs", SqlDbType.VarChar, 250)).Value = objInterno.Observacion
                            .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.Int)).Value = objInterno.CodigoTaller
                            .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objInterno.PenalID

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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
        Public Shared Function Grabar_v2(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_tal_asi_id", SqlDbType.Int)).Value = objInterno.Codigo
                            .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.Int)).Value = objInterno.CodigoTaller
                            .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@n_tal_asi_fec", SqlDbType.BigInt)).Value = objInterno.Fecha
                            .Parameters.Add(New SqlParameter("@c_tal_asi_hor_ent", SqlDbType.VarChar, 20)).Value = objInterno.HoraEntrada
                            .Parameters.Add(New SqlParameter("@c_tal_asi_hor_sal", SqlDbType.VarChar, 20)).Value = objInterno.HoraSalida
                            'Justificacion
                            .Parameters.Add(New SqlParameter("@kf_asi_jus_id", SqlDbType.Int)).Value = objInterno.MotivoJustificacionID
                            .Parameters.Add(New SqlParameter("@c_tal_asi_doc", SqlDbType.VarChar, 100)).Value = objInterno.Documento
                            .Parameters.Add(New SqlParameter("@n_tal_asi_fec_doc", SqlDbType.BigInt)).Value = objInterno.FechaDocumento
                            .Parameters.Add(New SqlParameter("@n_tal_asi_fec_ini", SqlDbType.BigInt)).Value = objInterno.FechaInicialRetiro
                            .Parameters.Add(New SqlParameter("@n_tal_asi_fec_fin", SqlDbType.BigInt)).Value = objInterno.FechaFinalRetiro
                            .Parameters.Add(New SqlParameter("@c_tal_asi_obs", SqlDbType.VarChar, 250)).Value = objInterno.Observacion
                            .Parameters.Add(New SqlParameter("@n_tal_asi_jus_est", SqlDbType.Int)).Value = objInterno.EstadoJustificacion
                            'Auditoria
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objInterno.PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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
#End Region
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_tal_asi_id", SqlDbType.Int)).Value = Codigo

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
                Return -1
            End Try
        End Function

    End Class
End Namespace
