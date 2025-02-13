Imports System.Data.SqlClient

Namespace Registro

    Public Class Persona
        Private Shared strNameProcedure As String = "pa_reg_mae_persona"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.Persona) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_per_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@c_per_cui", SqlDbType.VarChar, 10)).Value = objEnt.CUP
                    .Parameters.Add(New SqlParameter("@c_per_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@c_per_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@c_per_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@n_per_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                    .Parameters.Add(New SqlParameter("@fk_sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@fk_ubg_pai_id", SqlDbType.Int)).Value = objEnt.NacimientoPaisID
                    .Parameters.Add(New SqlParameter("@fk_ubg_nac_id", SqlDbType.Int)).Value = objEnt.NacimientoUbigeoID
                    .Parameters.Add(New SqlParameter("@fk_nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID
                    .Parameters.Add(New SqlParameter("@fk_tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@c_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@fk_ubg_dir_id", SqlDbType.Int)).Value = objEnt.DomicilioDistritoId
                    .Parameters.Add(New SqlParameter("@c_dir_nom", SqlDbType.VarChar, 200)).Value = objEnt.DomicilioDireccion
                    .Parameters.Add(New SqlParameter("@fk_est_civ_id", SqlDbType.Int)).Value = objEnt.EstadoCivilID
                    .Parameters.Add(New SqlParameter("@fk_niv_aca_id", SqlDbType.Int)).Value = objEnt.NivelAcademicoId
                    .Parameters.Add(New SqlParameter("@fk_pro_id", SqlDbType.Int)).Value = objEnt.ProfesionId
                    .Parameters.Add(New SqlParameter("@fk_ocu_id", SqlDbType.Int)).Value = objEnt.OcupacionId
                    .Parameters.Add(New SqlParameter("@fk_dis_id", SqlDbType.Int)).Value = objEnt.DiscapacidadId
                    .Parameters.Add(New SqlParameter("@fk_com_id", SqlDbType.Int)).Value = objEnt.ComunidadId
                    .Parameters.Add(New SqlParameter("@fk_com_esp_id", SqlDbType.Int)).Value = objEnt.ComunidadEspecificaId
                    .Parameters.Add(New SqlParameter("@fk_fot_izq_id", SqlDbType.Int)).Value = objEnt.FotoPerfilIzquierdo
                    .Parameters.Add(New SqlParameter("@fk_fot_fre_id", SqlDbType.Int)).Value = objEnt.FotoPerfilFrente
                    .Parameters.Add(New SqlParameter("@fk_fot_der_id", SqlDbType.Int)).Value = objEnt.FotoPerfilDerecho
                    .Parameters.Add(New SqlParameter("@per_est_rnc", SqlDbType.Int)).Value = objEnt.EstadoRncID
                    .Parameters.Add(New SqlParameter("@b_per_hom", SqlDbType.Bit)).Value = objEnt.Homonimia
                    .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objEnt.IdiomaNativoId
                    .Parameters.Add(New SqlParameter("@fk_gro_id", SqlDbType.Int)).Value = objEnt.GeneroId
                    .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objEnt.ReligionId
                    .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objEnt.FuerzaArmadaId
                    .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objEnt.RangoCodigo
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                       ByVal objEnt As Entity.Registro.Persona) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_per_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@c_per_cui", SqlDbType.VarChar, 10)).Value = objEnt.CUP
                            .Parameters.Add(New SqlParameter("@c_per_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@c_per_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@c_per_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                            .Parameters.Add(New SqlParameter("@n_per_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@fk_sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                            .Parameters.Add(New SqlParameter("@fk_ubg_pai_id", SqlDbType.Int)).Value = objEnt.NacimientoPaisID
                            .Parameters.Add(New SqlParameter("@fk_ubg_nac_id", SqlDbType.Int)).Value = objEnt.NacimientoUbigeoID
                            .Parameters.Add(New SqlParameter("@c_ubg_nac_otro", SqlDbType.VarChar, 150)).Value = objEnt.NacimientoLugarOtros
                            .Parameters.Add(New SqlParameter("@fk_nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID
                            .Parameters.Add(New SqlParameter("@fk_tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@c_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@c_obs_dni", SqlDbType.VarChar, 200)).Value = objEnt.DNIObservacion
                            .Parameters.Add(New SqlParameter("@fk_ubg_dir_id", SqlDbType.Int)).Value = objEnt.DomicilioDistritoId
                            .Parameters.Add(New SqlParameter("@c_dir_nom", SqlDbType.VarChar, 200)).Value = objEnt.DomicilioDireccion
                            .Parameters.Add(New SqlParameter("@fk_est_civ_id", SqlDbType.Int)).Value = objEnt.EstadoCivilID
                            .Parameters.Add(New SqlParameter("@fk_niv_aca_id", SqlDbType.Int)).Value = objEnt.NivelAcademicoId
                            .Parameters.Add(New SqlParameter("@fk_pro_id", SqlDbType.Int)).Value = objEnt.ProfesionId
                            .Parameters.Add(New SqlParameter("@fk_ocu_id", SqlDbType.Int)).Value = objEnt.OcupacionId
                            .Parameters.Add(New SqlParameter("@fk_dis_id", SqlDbType.Int)).Value = objEnt.DiscapacidadId
                            .Parameters.Add(New SqlParameter("@fk_com_id", SqlDbType.Int)).Value = objEnt.ComunidadId
                            .Parameters.Add(New SqlParameter("@fk_com_esp_id", SqlDbType.Int)).Value = objEnt.ComunidadEspecificaId
                            .Parameters.Add(New SqlParameter("@c_aut_ali_nom", SqlDbType.VarChar, 300)).Value = objEnt.AliasPersona
                            .Parameters.Add(New SqlParameter("@c_aut_fam_pad", SqlDbType.VarChar, 120)).Value = objEnt.Padre
                            .Parameters.Add(New SqlParameter("@c_aut_fam_mad", SqlDbType.VarChar, 120)).Value = objEnt.Madre
                            .Parameters.Add(New SqlParameter("@c_aut_fam_coy", SqlDbType.VarChar, 120)).Value = objEnt.Conyuge
                            .Parameters.Add(New SqlParameter("@fk_fot_izq_id", SqlDbType.Int)).Value = objEnt.FotoPerfilIzquierdo
                            .Parameters.Add(New SqlParameter("@fk_fot_fre_id", SqlDbType.Int)).Value = objEnt.FotoPerfilFrente
                            .Parameters.Add(New SqlParameter("@fk_fot_der_id", SqlDbType.Int)).Value = objEnt.FotoPerfilDerecho
                            .Parameters.Add(New SqlParameter("@c_per_obs", SqlDbType.VarChar, 500)).Value = objEnt.ObservacionPersona
                            .Parameters.Add(New SqlParameter("@c_per_dec", SqlDbType.VarChar, 20)).Value = objEnt.Decadactilar
                            .Parameters.Add(New SqlParameter("@per_est_rnc", SqlDbType.Int)).Value = objEnt.EstadoRncID
                            .Parameters.Add(New SqlParameter("@b_per_hom", SqlDbType.Bit)).Value = objEnt.Homonimia
                            .Parameters.Add(New SqlParameter("@fk_idm_nat_id", SqlDbType.Int)).Value = objEnt.IdiomaNativoId
                            .Parameters.Add(New SqlParameter("@fk_gro_id", SqlDbType.Int)).Value = objEnt.GeneroId
                            .Parameters.Add(New SqlParameter("@c_cen_trab", SqlDbType.VarChar, 150)).Value = objEnt.CentroTrabajo
                            .Parameters.Add(New SqlParameter("@fk_rel_id", SqlDbType.Int)).Value = objEnt.ReligionId
                            .Parameters.Add(New SqlParameter("@fk_cod_fza_arm_id", SqlDbType.Int)).Value = objEnt.FuerzaArmadaId
                            .Parameters.Add(New SqlParameter("@fk_cod_ran_id", SqlDbType.Int)).Value = objEnt.RangoCodigo

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId


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
            Return -1
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef outSms As String) As Integer
            Dim intCodigo As Integer = -1

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_per_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return intCodigo
        End Function
    End Class
End Namespace