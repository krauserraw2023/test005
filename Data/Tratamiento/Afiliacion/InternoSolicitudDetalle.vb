Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.Afiliacion

    Public Class InternoSolicitudDetalle
        Private Shared strNameProcedure As String = "pa_tra_sis_det_solicitud"

#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, _
                                              ByVal opcion As String, objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objEnt.PenalID

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
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objInt As Entity.Registro.Interno) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInt.Codigo
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInt.CodigoRP
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInt.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@int_doc_num_aux", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumentoAux
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInt.Nombres
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objInt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objInt.PenalID

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
       

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_n_sol_id", SqlDbType.Int)).Value = objEnt.CodigoSolicitud
                  
                    .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEnt.RegionID

                    Try

                    Catch ex As Exception

                    End Try
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

       
       

#End Region

#Region "Grabar"

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Integer

            'nueva version del pope
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure

                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_n_sol_id", SqlDbType.Int)).Value = objInterno.CodigoSolicitud
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@c_det_sol_pri_ape", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@c_det_sol_seg_ape", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@c_det_sol_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            .Parameters.Add(New SqlParameter("@n_det_sol_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@c_det_sol_val_rnc", SqlDbType.Int)).Value = objInterno.EstadoRncID
                            .Parameters.Add(New SqlParameter("@n_det_sol_mov", SqlDbType.Int)).Value = objInterno.TipoMovimientoID
                            .Parameters.Add(New SqlParameter("@n_det_sol_fec_ing", SqlDbType.BigInt)).Value = objInterno.FechaIngreso
                            .Parameters.Add(New SqlParameter("@n_det_sol_fec_egr", SqlDbType.BigInt)).Value = objInterno.FechaLibertad
                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objInterno.PenalID
                            .Parameters.Add(New SqlParameter("@RegionRegId", SqlDbType.Int)).Value = objInterno.RegionRegistroID
                            .Parameters.Add(New SqlParameter("@PenalRegId", SqlDbType.Int)).Value = objInterno.PenalRegistroID
                            .Parameters.Add(New SqlParameter("@anio", SqlDbType.Int)).Value = objInterno.Anio
                            .Parameters.Add(New SqlParameter("@mes", SqlDbType.Int)).Value = objInterno.Mes
                            .Parameters.Add(New SqlParameter("@PenalCod", SqlDbType.VarChar, 10)).Value = objInterno.PenalCodigo
                            .Parameters.Add(New SqlParameter("@n_sol_fec_env", SqlDbType.BigInt)).Value = objInterno.FechaEnvio
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = objInterno.Eliminado
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



        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Tratamiento.Afiliacion.InternoSolicitudDetalle) As Integer

            'nueva version del pope
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure

                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_n_sol_id", SqlDbType.Int)).Value = objInterno.CodigoSolicitud
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInterno.CodigoRP
                            .Parameters.Add(New SqlParameter("@c_det_sol_pri_ape", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@c_det_sol_seg_ape", SqlDbType.VarChar, 100)).Value = objInterno.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@c_det_sol_nom", SqlDbType.VarChar, 150)).Value = objInterno.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objInterno.SexoID
                            .Parameters.Add(New SqlParameter("@n_det_sol_fec_nac", SqlDbType.BigInt)).Value = objInterno.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInterno.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objInterno.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@c_det_sol_val_rnc", SqlDbType.Int)).Value = objInterno.EstadoRncID
                            .Parameters.Add(New SqlParameter("@n_det_sol_mov", SqlDbType.Int)).Value = objInterno.TipoMovimientoID
                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objInterno.PenalID
                            .Parameters.Add(New SqlParameter("@RegionRegId", SqlDbType.Int)).Value = objInterno.RegionRegistroID
                            .Parameters.Add(New SqlParameter("@PenalRegId", SqlDbType.Int)).Value = objInterno.PenalRegistroID
                            .Parameters.Add(New SqlParameter("@anio", SqlDbType.Int)).Value = objInterno.Anio
                            .Parameters.Add(New SqlParameter("@mes", SqlDbType.Int)).Value = objInterno.Mes
                            .Parameters.Add(New SqlParameter("@PenalCod", SqlDbType.VarChar, 10)).Value = objInterno.PenalCodigo
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = objInterno.Eliminado
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede

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

        Public Shared Function Eliminar_x_ingreso(ByVal accion As String, ByVal opcion As String, ByVal ingresoId As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ingresoId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede

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
