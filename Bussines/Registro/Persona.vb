Imports System.Data.SqlClient
Namespace Registro
    Public Class Persona

#Region "listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Persona
            Dim list As New Entity.EntityCol(Of Entity.Registro.Persona)
            Dim ent As New Entity.Registro.Persona
            ent.Codigo = Codigo
            list = Listar(ent)
            If list.Count = 0 Then
                Return Nothing
            Else
                ent = list.Item(0)
            End If
            Return ent
        End Function

        Public Function Listar(ent As Entity.Registro.Persona) As Entity.EntityCol(Of Entity.Registro.Persona)
            Dim lst As New Entity.EntityCol(Of Entity.Registro.Persona)
            Dim objEnt As Entity.Registro.Persona

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Persona.Listar(sqlCon, "lst", "lst_mant", ent)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Persona
                        With objEnt
                            .Codigo = sqlDr("pk_per_id").ToString
                            .CUP = sqlDr("c_per_cui").ToString
                            .ApellidoPaterno = sqlDr("@c_per_ape_pat")
                            .ApellidoMaterno = sqlDr("@c_per_ape_mat")
                            .Nombres = sqlDr("@c_per_nom")
                            .FechaNacimiento = sqlDr("@n_per_fec_nac")
                            .SexoID = sqlDr("@fk_sex_id")
                            .NacimientoPaisID = sqlDr("@fk_ubg_pai_id")
                            .NacimientoUbigeoID = sqlDr("@fk_ubg_nac_id")
                            .NacimientoLugarOtros = sqlDr("@c_per_nom")
                            .NacionalidadID = sqlDr("@fk_nac_id")
                            .TipoDocumentoID = sqlDr("@fk_tip_doc_id")
                            .NumeroDocumento = sqlDr("@c_doc_num")
                            .DNIObservacion = sqlDr("@c_obs_dni")
                            .DomicilioDistritoId = sqlDr("@fk_ubg_dir_id")
                            .DomicilioDireccion = sqlDr("@int_dir_nom")
                            .EstadoCivilID = sqlDr("@fk_est_civ_id")
                            .NivelAcademicoId = sqlDr("@fk_niv_aca_id")
                            .ProfesionId = sqlDr("@fk_pro_id")
                            .OcupacionId = sqlDr("@fk_ocu_id")
                            .DiscapacidadId = sqlDr("@fk_dis_id")
                            .ComunidadId = sqlDr("@fk_com_id")
                            .ComunidadEspecificaId = sqlDr("@fk_com_esp_id")
                            .AliasPersona = sqlDr("@c_aut_ali_nom")
                            .Padre = sqlDr("@c_aut_fam_pad")
                            .Madre = sqlDr("@c_aut_fam_mad")
                            .Conyuge = sqlDr("@c_aut_fam_coy")
                            .FotoPerfilIzquierdo = sqlDr("@fk_fot_izq_id")
                            .FotoPerfilFrente = sqlDr("@fk_fot_fre_id")
                            .FotoPerfilDerecho = sqlDr("@fk_fot_der_id")
                            .ObservacionPersona = sqlDr("@c_per_obs")
                            .Decadactilar = sqlDr("@c_per_dec")
                            .EstadoRncID = sqlDr("@per_est_rnc")
                            .Homonimia = sqlDr("@b_per_hom")
                            .IdiomaNativoId = sqlDr("@fk_idm_nat_id")
                            .GeneroId = sqlDr("@fk_gro_id")
                            .CentroTrabajo = sqlDr("@c_cen_trab")
                            .ReligionId = sqlDr("@fk_rel_id")
                            .FuerzaArmadaId = sqlDr("@fk_cod_fza_arm_id")
                            .RangoCodigo = sqlDr("@fk_cod_ran_id")
                        End With
                        lst.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return lst
        End Function
#End Region

        Public Function Grabar(ent As Entity.Registro.Persona, ByRef outSMS As String) As Integer
            'validar()

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Persona.Grabar(strAccion, strOpcion, ent)

            Return intValue

        End Function

        Public Function Eliminar(ByVal Codigo As Integer, ByRef outSMS As String) As Integer
            Dim intValue As Integer = -1

            intValue = Data.Registro.Persona.Eliminar("del", "del_mant", Codigo, outSMS)
            Return intValue
        End Function

    End Class
End Namespace