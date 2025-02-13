Imports System.Data
Imports System.Data.SqlClient
Namespace Visita.Programacion
    Public Class CalendarioDetalle
        Private Shared strNameProcedure As String = "UP_VIS_CalendarioDetalle"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.CalendarioDetalle) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID
                            .Parameters.Add(New SqlParameter("@cal_id", SqlDbType.Int)).Value = objEnt.CalendarioID                            
                            .Parameters.Add(New SqlParameter("@vis_tip_id", SqlDbType.SmallInt)).Value = objEnt.VisitaTipoID
                            .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.SmallInt)).Value = objEnt.EtapaID
                            .Parameters.Add(New SqlParameter("@cal_det_sex_id", SqlDbType.SmallInt)).Value = objEnt.SexoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@cal_det_fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Value = .Parameters("@variable_out").Value
                            Return Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.CalendarioDetalle) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID
                    .Parameters.Add(New SqlParameter("@cal_id", SqlDbType.Int)).Value = objEnt.CalendarioID
                    .Parameters.Add(New SqlParameter("@vis_tip_id", SqlDbType.SmallInt)).Value = objEnt.VisitaTipoID
                    .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.SmallInt)).Value = objEnt.EtapaID
                    .Parameters.Add(New SqlParameter("@cal_det_sex_id", SqlDbType.SmallInt)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    '/*filtros*/
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEnt.RegimenVisitaID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.CalendarioDetalle) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID
                            .Parameters.Add(New SqlParameter("@cal_id", SqlDbType.Int)).Value = objEnt.CalendarioID
                            .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEnt.RegimenVisitaID
                            .Parameters.Add(New SqlParameter("@vis_tip_id", SqlDbType.SmallInt)).Value = objEnt.VisitaTipoID
                            .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.SmallInt)).Value = objEnt.EtapaID
                            .Parameters.Add(New SqlParameter("@cal_det_sex_id", SqlDbType.SmallInt)).Value = objEnt.SexoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.InternoApellidosyNombres

                            .Parameters.Add(New SqlParameter("@cal_det_fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                            .Parameters.Add(New SqlParameter("@cal_det_fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                            .Parameters.Add(New SqlParameter("@cal_det_fec_fin_ind", SqlDbType.BigInt)).Value = objEnt.FechaFinIndeterminado
                            .Parameters.Add(New SqlParameter("@cal_det_fre_id", SqlDbType.SmallInt)).Value = objEnt.FrecuenciaID
                            .Parameters.Add(New SqlParameter("@cal_det_fre_rep", SqlDbType.SmallInt)).Value = objEnt.FrecuenciaRepeticion
                            .Parameters.Add(New SqlParameter("@cal_det_dia_lun", SqlDbType.Bit)).Value = objEnt.DiaLunes
                            .Parameters.Add(New SqlParameter("@cal_det_dia_mar", SqlDbType.Bit)).Value = objEnt.DiaMartes
                            .Parameters.Add(New SqlParameter("@cal_det_dia_mie", SqlDbType.Bit)).Value = objEnt.DiaMiercoles
                            .Parameters.Add(New SqlParameter("@cal_det_dia_jue", SqlDbType.Bit)).Value = objEnt.DiaJueves
                            .Parameters.Add(New SqlParameter("@cal_det_dia_vie", SqlDbType.Bit)).Value = objEnt.DiaViernes
                            .Parameters.Add(New SqlParameter("@cal_det_dia_sab", SqlDbType.Bit)).Value = objEnt.DiaSabado
                            .Parameters.Add(New SqlParameter("@cal_det_dia_dom", SqlDbType.Bit)).Value = objEnt.DiaDomingo
                            .Parameters.Add(New SqlParameter("@cal_det_mes", SqlDbType.VarChar, 100)).Value = objEnt.MesArray
                            .Parameters.Add(New SqlParameter("@cal_det_mes_tip", SqlDbType.SmallInt)).Value = objEnt.MesTipo
                            .Parameters.Add(New SqlParameter("@cal_det_mes_dia", SqlDbType.VarChar, 100)).Value = objEnt.MesDiaArray
                            .Parameters.Add(New SqlParameter("@cal_det_mes_el", SqlDbType.VarChar, 100)).Value = objEnt.MesElArray
                            .Parameters.Add(New SqlParameter("@cal_det_mes_dia_sem", SqlDbType.VarChar, 100)).Value = objEnt.MesDiaSemanaArray
                            .Parameters.Add(New SqlParameter("@cal_det_hor_ini", SqlDbType.SmallInt)).Value = objEnt.HoraInicio
                            .Parameters.Add(New SqlParameter("@cal_det_hor_fin", SqlDbType.SmallInt)).Value = objEnt.HoraFin
                            .Parameters.Add(New SqlParameter("@cal_det_dur", SqlDbType.SmallInt)).Value = objEnt.Duracion

                            .Parameters.Add(New SqlParameter("@cal_det_lim_vis", SqlDbType.Bit)).Value = objEnt.LimiteVisita
                            .Parameters.Add(New SqlParameter("@cal_det_can_lim_vis", SqlDbType.SmallInt)).Value = objEnt.LimiteVisitaCantidad
                            .Parameters.Add(New SqlParameter("@cal_det_fam_con", SqlDbType.Bit)).Value = objEnt.FamiliaConsanguidad
                            .Parameters.Add(New SqlParameter("@cal_det_can_fam_con", SqlDbType.SmallInt)).Value = objEnt.FamiliaConsanguidadCantidad
                            .Parameters.Add(New SqlParameter("@cal_det_grd_fam_con", SqlDbType.SmallInt)).Value = objEnt.FamiliaConsanguidadGrado
                            .Parameters.Add(New SqlParameter("@cal_det_fam_afi", SqlDbType.Bit)).Value = objEnt.FamiliaAfinidad
                            .Parameters.Add(New SqlParameter("@cal_det_can_fam_afi", SqlDbType.SmallInt)).Value = objEnt.FamiliaAfinidadCantidad
                            .Parameters.Add(New SqlParameter("@cal_det_grd_fam_afi", SqlDbType.SmallInt)).Value = objEnt.FamiliaAfinidadGrado

                            .Parameters.Add(New SqlParameter("@cal_det_hab_ran_eda", SqlDbType.Bit)).Value = objEnt.HabilitarRangoEdad
                            .Parameters.Add(New SqlParameter("@cal_det_eda_ini", SqlDbType.SmallInt)).Value = objEnt.EdadInicio
                            .Parameters.Add(New SqlParameter("@cal_det_eda_fin", SqlDbType.SmallInt)).Value = objEnt.EdadFin

                            .Parameters.Add(New SqlParameter("@cal_det_con_con", SqlDbType.Bit)).Value = objEnt.IncluyeConyugueConcubina
                            .Parameters.Add(New SqlParameter("@cal_det_ami", SqlDbType.Bit)).Value = objEnt.IncluyeAmigo
                            .Parameters.Add(New SqlParameter("@cal_det_inc_abo", SqlDbType.Bit)).Value = objEnt.IncluyeAbogado
                            .Parameters.Add(New SqlParameter("@cal_det_vis_reg", SqlDbType.Bit)).Value = objEnt.VisitanteRegistradoPreviamente
                            .Parameters.Add(New SqlParameter("@cal_det_est", SqlDbType.Bit)).Value = objEnt.DetalleEstado

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.CalendarioDetalle) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID

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
    End Class
End Namespace