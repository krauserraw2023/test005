Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Config
        Private Shared strNameProcedure As String = "UP_VIS_Config"
        
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Config) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@cnf_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@cnf_est", SqlDbType.SmallInt)).Value = objEnt.Estado

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Config) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cnf_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEnt.RegimenTipoID
                            .Parameters.Add(New SqlParameter("@cnf_sex_id", SqlDbType.SmallInt)).Value = objEnt.SexoID
                            .Parameters.Add(New SqlParameter("@cnf_ini_hor", SqlDbType.TinyInt)).Value = objEnt.InicioHora
                            .Parameters.Add(New SqlParameter("@cnf_ini_min", SqlDbType.TinyInt)).Value = objEnt.InicioMinuto
                            .Parameters.Add(New SqlParameter("@cnf_fin_hor", SqlDbType.TinyInt)).Value = objEnt.FinHora
                            .Parameters.Add(New SqlParameter("@cnf_fin_min", SqlDbType.TinyInt)).Value = objEnt.FinMinuto
                            .Parameters.Add(New SqlParameter("@cnf_cap_int", SqlDbType.SmallInt)).Value = objEnt.CapacidadInternos
                            .Parameters.Add(New SqlParameter("@cnf_cap_afo", SqlDbType.SmallInt)).Value = objEnt.CapacidadAforo
                            .Parameters.Add(New SqlParameter("@cnf_cap_vis", SqlDbType.SmallInt)).Value = objEnt.CapacidadVisitas
                            .Parameters.Add(New SqlParameter("@cnf_sol_inf_pab", SqlDbType.Bit)).Value = objEnt.SolicitaInfoPabellon
                            .Parameters.Add(New SqlParameter("@cnf_sol_aut_vis_reg_ord", SqlDbType.Bit)).Value = objEnt.SolicitaAutoRegOrdinario
                            .Parameters.Add(New SqlParameter("@cnf_sol_aut_abo", SqlDbType.Bit)).Value = objEnt.SolicitaAutoRegAbogado
                            .Parameters.Add(New SqlParameter("@b_cnf_hab_int_pj", SqlDbType.Bit)).Value = objEnt.HabilitarInternosPJ
                            .Parameters.Add(New SqlParameter("@b_cnf_hab_env_san", SqlDbType.Bit)).Value = objEnt.HabilitarSancionSede

                            .Parameters.Add(New SqlParameter("@cnf_mod_reg", SqlDbType.Bit)).Value = objEnt.SolicitaModuloPOPE

                            'huella
                            .Parameters.Add(New SqlParameter("@cnf_hab_hue_dig", SqlDbType.Bit)).Value = objEnt.HabilitaHuellaDigital
                            .Parameters.Add(New SqlParameter("@b_cnf_cap_hue_vis_val_rnc", SqlDbType.Bit)).Value = objEnt.CapturarHuellaValReniec
                            'reniec
                            .Parameters.Add(New SqlParameter("@b_cnf_val_rnc_mod_vis", SqlDbType.Bit)).Value = objEnt.ValidarModVisitaConReniec
                            .Parameters.Add(New SqlParameter("@b_cnf_per_ing_vis_val_rnc", SqlDbType.Bit)).Value = objEnt.ValidarVisitanteConReniec

                            'migraciones 
                            .Parameters.Add(New SqlParameter("@b_hab_mod_vis_con_mig", SqlDbType.Bit)).Value = objEnt.ValidarModVisitaConMigraciones
                            .Parameters.Add(New SqlParameter("@b_per_ing_vis_val_con_mig", SqlDbType.Bit)).Value = objEnt.ValidarVisitanteConMigraciones

                            .Parameters.Add(New SqlParameter("@cnf_est", SqlDbType.SmallInt)).Value = objEnt.Estado

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Config) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cnf_id", SqlDbType.Int)).Value = objEnt.Codigo

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