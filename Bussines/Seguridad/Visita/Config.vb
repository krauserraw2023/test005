Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Config
        Private objEnt As Entity.Visita.Config = Nothing
        Private objEntCol As Entity.Visita.ConfigCol = Nothing
#Region "Funciones"

        Public Function HabilitarSancionSede(intIDRegion As Short, intIDPenal As Short) As Boolean

            Dim value As Boolean = False
            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = intIDRegion
                .PenalID = intIDPenal
                .Estado = 1 'alta
            End With

            objEnt = New Entity.Visita.Config

            objEnt = ListarConfigActual(objEntFiltro)
            With objEnt
                value = .HabilitarSancionSede
            End With

            Return value

        End Function

#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Config

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Visita.Config
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Visita.Config.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Visita.Config
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("cnf_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .RegimenTipoID = sqlDr("reg_vis_id").ToString
                            .SexoID = sqlDr("cnf_sex_id").ToString
                            .InicioHora = sqlDr("cnf_ini_hor").ToString
                            .InicioMinuto = sqlDr("cnf_ini_min").ToString
                            .FinHora = sqlDr("cnf_fin_hor").ToString
                            .FinMinuto = sqlDr("cnf_fin_min").ToString
                            .CapacidadInternos = sqlDr("cnf_cap_int").ToString
                            .CapacidadAforo = sqlDr("cnf_cap_afo").ToString
                            .CapacidadVisitas = sqlDr("cnf_cap_vis").ToString
                            .SolicitaInfoPabellon = sqlDr("cnf_sol_inf_pab").ToString
                            .SolicitaAutoRegOrdinario = sqlDr("cnf_sol_aut_vis_reg_ord").ToString
                            .SolicitaAutoRegAbogado = sqlDr("cnf_sol_aut_abo").ToString
                            .SolicitaModuloPOPE = sqlDr("cnf_mod_reg").ToString

                            .HabilitaHuellaDigital = sqlDr("cnf_hab_hue_dig").ToString
                            .CapturarHuellaValReniec = sqlDr("b_cnf_cap_hue_vis_val_rnc").ToString
                            .HabilitarInternosPJ = sqlDr("b_cnf_hab_int_pj").ToString
                            .HabilitarSancionSede = sqlDr("b_cnf_hab_env_san").ToString
                            'reniec
                            .ValidarVisitanteConReniec = sqlDr("b_cnf_per_ing_vis_val_rnc").ToString
                            .ValidarModVisitaConReniec = sqlDr("b_cnf_val_rnc_mod_vis").ToString
                            'migraciones
                            .ValidarModVisitaConMigraciones = sqlDr("b_hab_mod_vis_con_mig").ToString
                            .ValidarVisitanteConMigraciones = sqlDr("b_per_ing_vis_val_con_mig").ToString
                            .Estado = sqlDr("cnf_est").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function
        Public Function ListarGrilla(ByVal objEntFiltro As Entity.Visita.Config) As Entity.Visita.ConfigCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Config.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.ConfigCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Config
                        With objEnt
                            .Codigo = sqlDr("cnf_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .RegimenTipoID = sqlDr("reg_vis_id").ToString
                            .RegimenTipoNombre = sqlDr("reg_vis_nom").ToString
                            .SexoID = sqlDr("cnf_sex_id").ToString
                            .InicioHora = sqlDr("cnf_ini_hor").ToString
                            .InicioMinuto = sqlDr("cnf_ini_min").ToString
                            .FinHora = sqlDr("cnf_fin_hor").ToString
                            .FinMinuto = sqlDr("cnf_fin_min").ToString
                            .CapacidadInternos = sqlDr("cnf_cap_int").ToString
                            .CapacidadVisitas = sqlDr("cnf_cap_vis").ToString
                            .SolicitaInfoPabellon = sqlDr("cnf_sol_inf_pab").ToString
                            .SolicitaAutoRegOrdinario = sqlDr("cnf_sol_aut_vis_reg_ord").ToString
                            .SolicitaAutoRegAbogado = sqlDr("cnf_sol_aut_abo").ToString
                            .Estado = sqlDr("cnf_est").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
        Public Function ListarConfigActual(ByVal objEntFiltro As Entity.Visita.Config) As Entity.Visita.Config

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Visita.Config.Listar(sqlCon, "lst", "lst_config_actual", objEntFiltro)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Config
                        With objEnt
                            .Codigo = sqlDr("cnf_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .RegimenTipoID = sqlDr("reg_vis_id").ToString
                            .RegimenTipoNombre = sqlDr("reg_vis_nom").ToString
                            .SexoID = sqlDr("cnf_sex_id").ToString
                            .InicioHora = sqlDr("cnf_ini_hor").ToString
                            .InicioMinuto = sqlDr("cnf_ini_min").ToString
                            .FinHora = sqlDr("cnf_fin_hor").ToString
                            .FinMinuto = sqlDr("cnf_fin_min").ToString
                            .CapacidadInternos = sqlDr("cnf_cap_int").ToString
                            .CapacidadVisitas = sqlDr("cnf_cap_vis").ToString
                            .SolicitaInfoPabellon = sqlDr("cnf_sol_inf_pab").ToString
                            .SolicitaAutoRegOrdinario = sqlDr("cnf_sol_aut_vis_reg_ord").ToString
                            .SolicitaAutoRegAbogado = sqlDr("cnf_sol_aut_abo").ToString
                            .SolicitaModuloPOPE = sqlDr("cnf_mod_reg").ToString

                            .HabilitaHuellaDigital = sqlDr("cnf_hab_hue_dig").ToString
                            .CapturarHuellaValReniec = sqlDr("b_cnf_cap_hue_vis_val_rnc").ToString

                            .HabilitarInternosPJ = sqlDr("b_cnf_hab_int_pj").ToString
                            .HabilitarSancionSede = sqlDr("b_cnf_hab_env_san").ToString

                            'reniec
                            .ValidarVisitanteConReniec = sqlDr("b_cnf_per_ing_vis_val_rnc").ToString
                            .ValidarModVisitaConReniec = sqlDr("b_cnf_val_rnc_mod_vis").ToString
                            'migraciones
                            .ValidarModVisitaConMigraciones = sqlDr("b_hab_mod_vis_con_mig").ToString
                            .ValidarVisitanteConMigraciones = sqlDr("b_per_ing_vis_val_con_mig").ToString
                            .Estado = sqlDr("cnf_est").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function
        Public Function ConfigActual_getSexo(intIDRegion As Short, intIDPenal As Short) As Short

            Dim value As Short = -1

            Dim objEntFiltro As New Entity.Visita.Config
            objEnt = New Entity.Visita.Config

            With objEntFiltro
                .RegionID = intIDRegion
                .PenalID = intIDPenal
                .Estado = 1 'alta
            End With

            objEnt = ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then
                value = objEnt.SexoID
            End If

            Return value

        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Visita.Config) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"

                    If .Estado = 0 Then 'baja then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "No se puede modificar el registro, porque se encuentra inactivo")
                        Return Value
                    End If

                End If

            End With

            Value = Data.Visita.Config.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.Config) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.Config.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace