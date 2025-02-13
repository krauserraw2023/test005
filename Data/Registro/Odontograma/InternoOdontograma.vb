Imports System.Data.SqlClient

Namespace Registro.Odontograma
    Public Class InternoOdontograma
        Private Shared strNameProcedure As String = "pa_int_mov_interno_odontograma"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                    objEnt As Entity.Registro.Odontograma.InternoOdontograma) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_odn_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId
                    .Parameters.Add(New SqlParameter("@c_int_odn_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observaciones
                    .Parameters.Add(New SqlParameter("@c_int_odn_esp", SqlDbType.VarChar, 1000)).Value = objEnt.Especificaciones
                    .Parameters.Add(New SqlParameter("@fk_arc_dnt_tip_sup_id", SqlDbType.Int)).Value = objEnt.ArcoDentarioSupId
                    .Parameters.Add(New SqlParameter("@fk_arc_dnt_tip_inf_id", SqlDbType.Int)).Value = objEnt.ArcoDentarioInfId
                    .Parameters.Add(New SqlParameter("@fk_tam_dmx_id", SqlDbType.Int)).Value = objEnt.TamanioDentoMaxilarId
                    .Parameters.Add(New SqlParameter("@fk_tam_die_id", SqlDbType.Int)).Value = objEnt.TamanioDienteId
                    .Parameters.Add(New SqlParameter("@fk_die_tip_id", SqlDbType.Int)).Value = objEnt.DienteTipoId
                    .Parameters.Add(New SqlParameter("@fk_ocl_tip_id", SqlDbType.Int)).Value = objEnt.OclusionTipoId
                    .Parameters.Add(New SqlParameter("@fk_rug_pal_id", SqlDbType.Int)).Value = objEnt.RugaPalatinaId
                    '.Parameters.Add(New SqlParameter("@fk_arc_dig_id", SqlDbType.Int)).Value = objEnt.ArchivoDigitalId
                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionId
                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalId
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.Odontograma.InternoOdontograma) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_odn_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId
                            .Parameters.Add(New SqlParameter("@n_ver", SqlDbType.SmallInt)).Value = objEnt.version
                            .Parameters.Add(New SqlParameter("@c_nom_arc_odo", SqlDbType.VarChar, 50)).Value = objEnt.nombreArchivo
                            .Parameters.Add(New SqlParameter("@c_int_odn_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observaciones
                            .Parameters.Add(New SqlParameter("@c_int_odn_esp", SqlDbType.VarChar, 1000)).Value = objEnt.Especificaciones
                            .Parameters.Add(New SqlParameter("@fk_arc_dnt_tip_sup_id", SqlDbType.Int)).Value = objEnt.ArcoDentarioSupId
                            .Parameters.Add(New SqlParameter("@fk_arc_dnt_tip_inf_id", SqlDbType.Int)).Value = objEnt.ArcoDentarioInfId
                            .Parameters.Add(New SqlParameter("@fk_tam_dmx_id", SqlDbType.Int)).Value = objEnt.TamanioDentoMaxilarId
                            .Parameters.Add(New SqlParameter("@fk_tam_die_id", SqlDbType.Int)).Value = objEnt.TamanioDienteId
                            .Parameters.Add(New SqlParameter("@fk_die_tip_id", SqlDbType.Int)).Value = objEnt.DienteTipoId
                            .Parameters.Add(New SqlParameter("@fk_ocl_tip_id", SqlDbType.Int)).Value = objEnt.OclusionTipoId
                            .Parameters.Add(New SqlParameter("@fk_rug_pal_id", SqlDbType.Int)).Value = objEnt.RugaPalatinaId
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalId

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
                            .Parameters.Add(New SqlParameter("@pk_int_odn_id", SqlDbType.Int)).Value = Codigo

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