Imports System.Data.SqlClient

Namespace Registro.Carceleta.Clasificacion.InternoClasificacion
    Public Class InternoClasificacion_DA
        Private Shared strNameProcedure As String = "pa_tra_asi_mov_interno_ficha"


        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entFicha As Entity.Clasificacion.InternoClasificacion.InternoFicha) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_fic_id", SqlDbType.Int)).Value = entFicha.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = entFicha.InternoId
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = entFicha.InternoIngresoId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = entFicha.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = entFicha.TipoFichaId
                    .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = entFicha.FichaId
                    .Parameters.Add(New SqlParameter("@fk_cat_fic_id", SqlDbType.Int)).Value = entFicha.CategoriaFichaId
                    .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = entFicha.FichaFinalId
                    .Parameters.Add(New SqlParameter("@fk_reg_dest_id", SqlDbType.Int)).Value = entFicha.RegionDestinoId
                    .Parameters.Add(New SqlParameter("@fk_pen_dest_id", SqlDbType.Int)).Value = entFicha.PenalDestinoId
                    .Parameters.Add(New SqlParameter("@num_cla", SqlDbType.Int)).Value = entFicha.NumeroClasificacion
                    .Parameters.Add(New SqlParameter("@fec_clasif", SqlDbType.Int)).Value = entFicha.FechaClasificacion
                    .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = entFicha.EstadoId
                    .Parameters.Add(New SqlParameter("@_reg_id", SqlDbType.Int)).Value = entFicha.RegionId
                    .Parameters.Add(New SqlParameter("@_pen_id", SqlDbType.Int)).Value = entFicha.PenalId
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
        Public Shared Function Listar_pen(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entFicha As Entity.Clasificacion.InternoClasificacion.InternoFicha) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_fic_id", SqlDbType.Int)).Value = entFicha.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = entFicha.InternoId
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = entFicha.InternoIngresoId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = entFicha.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = entFicha.TipoFichaId
                    .Parameters.Add(New SqlParameter("@fk_grp_fic_id", SqlDbType.Int)).Value = entFicha.GrupoFichaId
                    .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = entFicha.FichaId
                    .Parameters.Add(New SqlParameter("@fk_cat_fic_id", SqlDbType.Int)).Value = entFicha.CategoriaFichaId
                    .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = entFicha.FichaFinalId
                    .Parameters.Add(New SqlParameter("@fk_reg_dest_id", SqlDbType.Int)).Value = entFicha.RegionDestinoId
                    .Parameters.Add(New SqlParameter("@fk_pen_dest_id", SqlDbType.Int)).Value = entFicha.PenalDestinoId
                    .Parameters.Add(New SqlParameter("@num_cla", SqlDbType.Int)).Value = entFicha.NumeroClasificacion
                    .Parameters.Add(New SqlParameter("@fec_clasif", SqlDbType.Int)).Value = entFicha.FechaClasificacion
                    .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = entFicha.EstadoId
                    .Parameters.Add(New SqlParameter("@_reg_id", SqlDbType.Int)).Value = entFicha.RegionId
                    .Parameters.Add(New SqlParameter("@_pen_id", SqlDbType.Int)).Value = entFicha.PenalId
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, Optional ByVal tipoFichaId As Integer = -1) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_fic_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = tipoFichaId
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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Clasificacion.InternoClasificacion.InternoFicha) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_int_fic_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = objEnt.FichaFinalId
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = objEnt.TipoFichaId
                            .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = objEnt.FichaId
                            .Parameters.Add(New SqlParameter("@fk_cat_fic_id", SqlDbType.Int)).Value = objEnt.CategoriaFichaId
                            .Parameters.Add(New SqlParameter("@num_cla", SqlDbType.Int)).Value = objEnt.NumeroClasificacion
                            .Parameters.Add(New SqlParameter("@fk_reg_dest_id", SqlDbType.Int)).Value = objEnt.RegionDestinoId
                            .Parameters.Add(New SqlParameter("@fk_pen_dest_id", SqlDbType.Int)).Value = objEnt.PenalDestinoId
                            .Parameters.Add(New SqlParameter("@fk_regimen_pen_id", SqlDbType.Int)).Value = objEnt.RegimenPenalId
                            .Parameters.Add(New SqlParameter("@fec_clasif", SqlDbType.BigInt)).Value = objEnt.FechaClasificacion
                            .Parameters.Add(New SqlParameter("@cla_punt", SqlDbType.VarChar, 400)).Value = objEnt.Puntaje
                            .Parameters.Add(New SqlParameter("@cla_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.EstadoId
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId
                            .Parameters.Add(New SqlParameter("@c_mot_mod_pen", SqlDbType.VarChar, 500)).Value = objEnt.MotivoModifPenalDet
                            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.SmallInt)).Value = objEnt.InternoSituacionJuridicaId
                            .Parameters.Add(New SqlParameter("@cla_obvs_2", SqlDbType.VarChar, -1)).Value = objEnt.Observacion_02_rtf
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
        Public Shared Function Grabar_clas(ByVal accion As String, ByVal opcion As String,
                                     ByVal objEnt As Entity.Clasificacion.InternoClasificacion.InternoFicha) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_int_fic_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = objEnt.FichaFinalId
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = objEnt.TipoFichaId
                            .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = objEnt.FichaId
                            .Parameters.Add(New SqlParameter("@fk_cat_fic_id", SqlDbType.Int)).Value = objEnt.CategoriaFichaId
                            .Parameters.Add(New SqlParameter("@num_cla", SqlDbType.Int)).Value = objEnt.NumeroClasificacion
                            .Parameters.Add(New SqlParameter("@fk_reg_dest_id", SqlDbType.Int)).Value = objEnt.RegionDestinoId
                            .Parameters.Add(New SqlParameter("@fk_pen_dest_id", SqlDbType.Int)).Value = objEnt.PenalDestinoId
                            .Parameters.Add(New SqlParameter("@fk_regimen_pen_id", SqlDbType.Int)).Value = objEnt.RegimenPenalId
                            .Parameters.Add(New SqlParameter("@fk_etapa_id", SqlDbType.Int)).Value = objEnt.EtapaId
                            .Parameters.Add(New SqlParameter("@fec_clasif", SqlDbType.BigInt)).Value = objEnt.FechaClasificacion
                            .Parameters.Add(New SqlParameter("@cla_punt", SqlDbType.VarChar, 400)).Value = objEnt.Puntaje
                            .Parameters.Add(New SqlParameter("@cla_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.EstadoId
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId
                            .Parameters.Add(New SqlParameter("@c_mot_mod_pen", SqlDbType.VarChar, 500)).Value = objEnt.MotivoModifPenalDet
                            .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.SmallInt)).Value = objEnt.InternoSituacionJuridicaId

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