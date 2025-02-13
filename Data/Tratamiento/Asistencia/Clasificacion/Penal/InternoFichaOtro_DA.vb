Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Data.Registro
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoFichaOtro_DA
        Private Shared strNameProcedure As String = "usp_tra_asi_mov_interno_ficha_otro"


        Public Shared Function ListarGrilla(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String,
                                      objEnt As InternoFichaOtro_BE) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId

                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = objEnt.TipoFichaId

                    '.Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = objEnt.InternoPenalFichaId
                    ''.Parameters.Add(New SqlParameter("@c_causal", SqlDbType.VarChar, 250)).Value = objEnt.Causal
                    '.Parameters.Add(New SqlParameter("@c_resol_autoriza", SqlDbType.VarChar, 120)).Value = objEnt.ResolAutorizacion
                    ''.Parameters.Add(New SqlParameter("@f_fec_resol", SqlDbType.BigInt)).Value = objEnt.FechaResolucion
                    '.Parameters.Add(New SqlParameter("@f_fec_traslado", SqlDbType.BigInt)).Value = objEnt.FechaTraslado
                    '.Parameters.Add(New SqlParameter("@fk_reg_origen_id", SqlDbType.SmallInt)).Value = objEnt.RegionOrigenId
                    '.Parameters.Add(New SqlParameter("@fk_pen_origen_id", SqlDbType.SmallInt)).Value = objEnt.PenalOrigenId
                    '.Parameters.Add(New SqlParameter("@fk_reg_destino_id", SqlDbType.SmallInt)).Value = objEnt.RegionDestinoId
                    '.Parameters.Add(New SqlParameter("@fk_pen_destino_id", SqlDbType.SmallInt)).Value = objEnt.PenalDestinoId
                    '.Parameters.Add(New SqlParameter("@regimen_id_ep_origen", SqlDbType.SmallInt)).Value = objEnt.RegimenId_PenalOrigen
                    '.Parameters.Add(New SqlParameter("@etapa_id_ep_origen", SqlDbType.SmallInt)).Value = objEnt.EtapaId_PenalOrigen
                    '.Parameters.Add(New SqlParameter("@c_piso", SqlDbType.VarChar, 20)).Value = objEnt.Piso
                    '.Parameters.Add(New SqlParameter("@c_amb", SqlDbType.VarChar, 20)).Value = objEnt.Ambiente
                    '.Parameters.Add(New SqlParameter("@c_alero", SqlDbType.VarChar, 20)).Value = objEnt.Alero
                    '.Parameters.Add(New SqlParameter("@c_cama", SqlDbType.VarChar, 20)).Value = objEnt.Cama
                    '.Parameters.Add(New SqlParameter("@n_estado", SqlDbType.TinyInt)).Value = objEnt.Estado

                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IdRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IdPenal
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String,
                                      objEnt As InternoFichaOtro_BE) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                    .Parameters.Add(New SqlParameter("@pk_int_fic_otro_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = objEnt.InternoPenalFichaId
                    '.Parameters.Add(New SqlParameter("@c_causal", SqlDbType.VarChar, 250)).Value = objEnt.Causal
                    .Parameters.Add(New SqlParameter("@c_resol_autoriza", SqlDbType.VarChar, 120)).Value = objEnt.ResolAutorizacion
                    '.Parameters.Add(New SqlParameter("@f_fec_resol", SqlDbType.BigInt)).Value = objEnt.FechaResolucion
                    .Parameters.Add(New SqlParameter("@f_fec_traslado", SqlDbType.BigInt)).Value = objEnt.FechaTraslado
                    .Parameters.Add(New SqlParameter("@fk_reg_origen_id", SqlDbType.SmallInt)).Value = objEnt.RegionOrigenId
                    .Parameters.Add(New SqlParameter("@fk_pen_origen_id", SqlDbType.SmallInt)).Value = objEnt.PenalOrigenId
                    .Parameters.Add(New SqlParameter("@fk_reg_destino_id", SqlDbType.SmallInt)).Value = objEnt.RegionDestinoId
                    .Parameters.Add(New SqlParameter("@fk_pen_destino_id", SqlDbType.SmallInt)).Value = objEnt.PenalDestinoId
                    .Parameters.Add(New SqlParameter("@regimen_id_ep_origen", SqlDbType.SmallInt)).Value = objEnt.RegimenId_PenalOrigen
                    .Parameters.Add(New SqlParameter("@etapa_id_ep_origen", SqlDbType.SmallInt)).Value = objEnt.EtapaId_PenalOrigen
                    '.Parameters.Add(New SqlParameter("@c_piso", SqlDbType.VarChar, 20)).Value = objEnt.Piso
                    '.Parameters.Add(New SqlParameter("@c_amb", SqlDbType.VarChar, 20)).Value = objEnt.Ambiente
                    '.Parameters.Add(New SqlParameter("@c_alero", SqlDbType.VarChar, 20)).Value = objEnt.Alero
                    '.Parameters.Add(New SqlParameter("@c_cama", SqlDbType.VarChar, 20)).Value = objEnt.Cama

                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IdRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IdPenal
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function GrabarFichaClasifTralado(ByVal strAccion As String, ByVal strOpcion As String,
                                      entIntFic As InternoFicha_BE, objEntOtro As InternoFichaOtro_BE) As Integer
            Dim IntPenFicId As Integer = -1
            Using connection As New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                connection.Open()
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    Using sqlCmd As SqlCommand = New SqlCommand()
                        With sqlCmd
                            .CommandText = "usp_tra_asi_mov_interno_penal_ficha"
                            .Connection = connection
                            .CommandType = CommandType.StoredProcedure
                            .Transaction = transaction

                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@pk_int_pen_fic_id", SqlDbType.Int)).Value = entIntFic.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = entIntFic.IDInterno
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = entIntFic.IDInternoIngreso
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = entIntFic.IDInternoIngresoInpe
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = entIntFic.CodigoPadre
                            .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = entIntFic.IDFichaTipo
                            .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = entIntFic.IDFicha
                            .Parameters.Add(New SqlParameter("@n_sit_jur_id", SqlDbType.SmallInt)).Value = entIntFic.InternoIDSituacionJuridica
                            .Parameters.Add(New SqlParameter("@n_reg_id", SqlDbType.Int)).Value = entIntFic.InternoIDRegimen
                            .Parameters.Add(New SqlParameter("@n_etp_id", SqlDbType.Int)).Value = entIntFic.InternoIDEtapa
                            .Parameters.Add(New SqlParameter("@n_num_cla", SqlDbType.Int)).Value = entIntFic.NumeroClasificacion
                            .Parameters.Add(New SqlParameter("@n_fec_cla", SqlDbType.BigInt)).Value = entIntFic.FechaClasificacion
                            .Parameters.Add(New SqlParameter("@n_fech_ini_etapa", SqlDbType.BigInt)).Value = entIntFic.FechaInicioEtapa
                            .Parameters.Add(New SqlParameter("@n_fech_ini_regimen", SqlDbType.BigInt)).Value = entIntFic.FechaInicioRegimen

                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 1000)).Value = entIntFic.Observacion
                            .Parameters.Add(New SqlParameter("@n_pun", SqlDbType.VarChar, 400)).Value = entIntFic.Puntaje
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.Int)).Value = entIntFic.Estado
                            .Parameters.Add(New SqlParameter("@c_mot_cam_res", SqlDbType.VarChar, 500)).Value = entIntFic.MotivoCambio

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = entIntFic.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = entIntFic.IDPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output

                            .ExecuteNonQuery()
                            IntPenFicId = sqlCmd.Parameters("@variable_out").Value
                        End With
                    End Using

                    Dim strOpc As String = ""
                    If entIntFic.Codigo > 0 Then
                        strOpc = "upd_mant_x_fk_int_pen_fic_id"
                    Else
                        strOpc = "ins_mant"
                    End If

                    Using sqlCmd2 As SqlCommand = New SqlCommand(strNameProcedure, connection)
                        With sqlCmd2
                            .Transaction = transaction
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpc

                            .Parameters.Add(New SqlParameter("@pk_int_fic_otro_id", SqlDbType.Int)).Value = objEntOtro.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = IntPenFicId 'objEntOtro.InternoPenalFichaId
                            .Parameters.Add(New SqlParameter("@c_causal", SqlDbType.VarChar, 250)).Value = objEntOtro.Causal
                            .Parameters.Add(New SqlParameter("@fk_causal_traslado_id", SqlDbType.SmallInt)).Value = objEntOtro.CausalId
                            .Parameters.Add(New SqlParameter("@c_resol_autoriza", SqlDbType.VarChar, 120)).Value = objEntOtro.ResolAutorizacion
                            .Parameters.Add(New SqlParameter("@f_fec_resol", SqlDbType.BigInt)).Value = objEntOtro.FechaResolucion
                            .Parameters.Add(New SqlParameter("@f_fec_traslado", SqlDbType.BigInt)).Value = objEntOtro.FechaTraslado
                            .Parameters.Add(New SqlParameter("@fk_reg_origen_id", SqlDbType.SmallInt)).Value = objEntOtro.RegionOrigenId
                            .Parameters.Add(New SqlParameter("@fk_pen_origen_id", SqlDbType.SmallInt)).Value = objEntOtro.PenalOrigenId
                            .Parameters.Add(New SqlParameter("@fk_reg_destino_id", SqlDbType.SmallInt)).Value = objEntOtro.RegionDestinoId
                            .Parameters.Add(New SqlParameter("@fk_pen_destino_id", SqlDbType.SmallInt)).Value = objEntOtro.PenalDestinoId
                            .Parameters.Add(New SqlParameter("@regimen_id_ep_origen", SqlDbType.SmallInt)).Value = objEntOtro.RegimenId_PenalOrigen
                            .Parameters.Add(New SqlParameter("@etapa_id_ep_origen", SqlDbType.SmallInt)).Value = objEntOtro.EtapaId_PenalOrigen
                            '.Parameters.Add(New SqlParameter("@c_piso", SqlDbType.VarChar, 30)).Value = objEntOtro.Piso
                            '.Parameters.Add(New SqlParameter("@c_amb", SqlDbType.VarChar, 30)).Value = objEntOtro.Ambiente
                            '.Parameters.Add(New SqlParameter("@c_alero", SqlDbType.VarChar, 30)).Value = objEntOtro.Alero
                            .Parameters.Add(New SqlParameter("@c_cama", SqlDbType.VarChar, 30)).Value = objEntOtro.Cama
                            .Parameters.Add(New SqlParameter("@c_ambiente", SqlDbType.VarChar, 30)).Value = objEntOtro.Ambiente
                            .Parameters.Add(New SqlParameter("@fk_alero_id", SqlDbType.Int)).Value = objEntOtro.AleroId
                            .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = objEntOtro.PabellonId
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEntOtro.IdRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEntOtro.IdPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            .ExecuteNonQuery()
                            Dim value As Integer = .Parameters("@variable_out").Value

                        End With
                    End Using
                    transaction.Commit()
                Catch ex As Exception
                    ' Si ocurre un error, deshacer la transacción
                    transaction.Rollback()
                    Console.WriteLine("Error al insertar datos: " & ex.Message)
                End Try
            End Using

            Return IntPenFicId
        End Function


        Public Shared Function GrabarFichaRegresion(ByVal strAccion As String, ByVal strOpcion As String,
                                      entIntFic As InternoFicha_BE, objEntOtro As InternoFichaOtro_BE) As Integer
            Dim IntPenFicId As Integer = -1
            Using connection As New SqlConnection(Legolas.Configuration.Data.ConexionIni)

                connection.Open()
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    Using sqlCmd As SqlCommand = New SqlCommand()
                        With sqlCmd
                            .CommandText = "usp_tra_asi_mov_interno_penal_ficha"
                            .Connection = connection
                            .CommandType = CommandType.StoredProcedure
                            .Transaction = transaction

                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@pk_int_pen_fic_id", SqlDbType.Int)).Value = entIntFic.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = entIntFic.IDInterno
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = entIntFic.IDInternoIngreso
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = entIntFic.IDInternoIngresoInpe
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = entIntFic.CodigoPadre
                            .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = entIntFic.IDFichaTipo
                            .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = entIntFic.IDFicha
                            .Parameters.Add(New SqlParameter("@n_sit_jur_id", SqlDbType.SmallInt)).Value = entIntFic.InternoIDSituacionJuridica
                            .Parameters.Add(New SqlParameter("@n_reg_id", SqlDbType.Int)).Value = entIntFic.InternoIDRegimen
                            .Parameters.Add(New SqlParameter("@n_etp_id", SqlDbType.Int)).Value = entIntFic.InternoIDEtapa
                            .Parameters.Add(New SqlParameter("@n_num_cla", SqlDbType.Int)).Value = entIntFic.NumeroClasificacion
                            .Parameters.Add(New SqlParameter("@n_fec_cla", SqlDbType.BigInt)).Value = entIntFic.FechaClasificacion
                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 1000)).Value = entIntFic.Observacion
                            .Parameters.Add(New SqlParameter("@n_pun", SqlDbType.VarChar, 400)).Value = entIntFic.Puntaje
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.Int)).Value = entIntFic.Estado
                            .Parameters.Add(New SqlParameter("@c_mot_cam_res", SqlDbType.VarChar, 500)).Value = entIntFic.MotivoCambio

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = entIntFic.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = entIntFic.IDPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output

                            .ExecuteNonQuery()
                            IntPenFicId = sqlCmd.Parameters("@variable_out").Value
                        End With
                    End Using

                    Dim strOpc As String = ""
                    If entIntFic.Codigo > 0 Then
                        strOpc = "upd_mant_x_fk_int_pen_fic_id"
                    Else
                        strOpc = "ins_mant"
                    End If

                    Using sqlCmd2 As SqlCommand = New SqlCommand(strNameProcedure, connection)
                        With sqlCmd2
                            .Transaction = transaction
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpc

                            .Parameters.Add(New SqlParameter("@pk_int_fic_otro_id", SqlDbType.Int)).Value = objEntOtro.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = IntPenFicId 'objEntOtro.InternoPenalFichaId
                            .Parameters.Add(New SqlParameter("@c_causal", SqlDbType.VarChar, 250)).Value = objEntOtro.Causal
                            .Parameters.Add(New SqlParameter("@c_resol_autoriza", SqlDbType.VarChar, 120)).Value = objEntOtro.ResolAutorizacion
                            .Parameters.Add(New SqlParameter("@f_fec_resol", SqlDbType.BigInt)).Value = objEntOtro.FechaResolucion
                            .Parameters.Add(New SqlParameter("@f_fec_traslado", SqlDbType.BigInt)).Value = objEntOtro.FechaTraslado
                            .Parameters.Add(New SqlParameter("@fk_reg_origen_id", SqlDbType.SmallInt)).Value = objEntOtro.RegionOrigenId
                            .Parameters.Add(New SqlParameter("@fk_pen_origen_id", SqlDbType.SmallInt)).Value = objEntOtro.PenalOrigenId
                            .Parameters.Add(New SqlParameter("@fk_reg_destino_id", SqlDbType.SmallInt)).Value = objEntOtro.RegionDestinoId
                            .Parameters.Add(New SqlParameter("@fk_pen_destino_id", SqlDbType.SmallInt)).Value = objEntOtro.PenalDestinoId
                            .Parameters.Add(New SqlParameter("@regimen_id_ep_origen", SqlDbType.SmallInt)).Value = objEntOtro.RegimenId_PenalOrigen
                            .Parameters.Add(New SqlParameter("@etapa_id_ep_origen", SqlDbType.SmallInt)).Value = objEntOtro.EtapaId_PenalOrigen
                            .Parameters.Add(New SqlParameter("@c_ambiente", SqlDbType.VarChar, 30)).Value = objEntOtro.Ambiente
                            .Parameters.Add(New SqlParameter("@fk_alero_id", SqlDbType.Int)).Value = objEntOtro.AleroId
                            '.Parameters.Add(New SqlParameter("@c_piso", SqlDbType.VarChar, 30)).Value = objEntOtro.Piso
                            '.Parameters.Add(New SqlParameter("@c_amb", SqlDbType.VarChar, 30)).Value = objEntOtro.Ambiente
                            '.Parameters.Add(New SqlParameter("@c_alero", SqlDbType.VarChar, 30)).Value = objEntOtro.Alero
                            .Parameters.Add(New SqlParameter("@c_cama", SqlDbType.VarChar, 30)).Value = objEntOtro.Cama
                            .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = objEntOtro.PabellonId
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEntOtro.IdRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEntOtro.IdPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            .ExecuteNonQuery()
                            Dim value As Integer = .Parameters("@variable_out").Value

                        End With
                    End Using
                    transaction.Commit()
                Catch ex As Exception
                    IntPenFicId = -1
                    ' Si ocurre un error, deshacer la transacción
                    transaction.Rollback()
                    Console.WriteLine("Error al insertar datos: " & ex.Message)
                End Try
            End Using

            Return IntPenFicId
        End Function


        Public Shared Function Grabar(ByVal strAccion As String, ByVal strOpcion As String,
                                      ByVal objEnt As InternoFichaOtro_BE) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd2 As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd2
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@pk_int_fic_otro_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = objEnt.InternoPenalFichaId
                            .Parameters.Add(New SqlParameter("@c_causal", SqlDbType.VarChar, 250)).Value = objEnt.Causal
                            .Parameters.Add(New SqlParameter("@c_resol_autoriza", SqlDbType.VarChar, 120)).Value = objEnt.ResolAutorizacion
                            .Parameters.Add(New SqlParameter("@f_fec_resol", SqlDbType.BigInt)).Value = objEnt.FechaResolucion
                            .Parameters.Add(New SqlParameter("@f_fec_traslado", SqlDbType.BigInt)).Value = objEnt.FechaTraslado
                            .Parameters.Add(New SqlParameter("@fk_reg_origen_id", SqlDbType.SmallInt)).Value = objEnt.RegionOrigenId
                            .Parameters.Add(New SqlParameter("@fk_pen_origen_id", SqlDbType.SmallInt)).Value = objEnt.PenalOrigenId
                            .Parameters.Add(New SqlParameter("@fk_reg_destino_id", SqlDbType.SmallInt)).Value = objEnt.RegionDestinoId
                            .Parameters.Add(New SqlParameter("@fk_pen_destino_id", SqlDbType.SmallInt)).Value = objEnt.PenalDestinoId
                            .Parameters.Add(New SqlParameter("@regimen_id_ep_origen", SqlDbType.SmallInt)).Value = objEnt.RegimenId_PenalOrigen
                            .Parameters.Add(New SqlParameter("@etapa_id_ep_origen", SqlDbType.SmallInt)).Value = objEnt.EtapaId_PenalOrigen
                            .Parameters.Add(New SqlParameter("@c_ambiente", SqlDbType.VarChar, 30)).Value = objEnt.Ambiente
                            .Parameters.Add(New SqlParameter("@fk_alero_id", SqlDbType.Int)).Value = objEnt.AleroId
                            .Parameters.Add(New SqlParameter("@f_fec_clasif_ubi", SqlDbType.BigInt)).Value = objEnt.FechaClasificacionUbicacion
                            .Parameters.Add(New SqlParameter("@c_cama", SqlDbType.VarChar, 30)).Value = objEnt.Cama
                            .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = objEnt.PabellonId
                            .Parameters.Add(New SqlParameter("@n_estado", SqlDbType.TinyInt)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IdRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IdPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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
            End Try
        End Function

    End Class
End Namespace

