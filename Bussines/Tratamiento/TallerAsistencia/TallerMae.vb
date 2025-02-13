Imports System.Data.SqlClient

Namespace Tratamiento.TallerAsistencia
    Public Class TallerMae
        Private objEnt As Entity.Tratamiento.TallerAsistencia.TallerMae = Nothing
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.TallerMaeCol = Nothing

        Public Function Listar(ByVal Codigo As Integer) As Entity.Tratamiento.TallerAsistencia.TallerMae
            Dim col As New Entity.Tratamiento.TallerAsistencia.TallerMaeCol
            objEnt = New Entity.Tratamiento.TallerAsistencia.TallerMae
            objEnt.Codigo = Codigo

            col = Listar(objEnt)

            If col.Count = 0 Then Return Nothing

            Return col.Item(0)
        End Function

        Public Function Listar(ByVal objEntFiltro As Entity.Tratamiento.TallerAsistencia.TallerMae) As Entity.Tratamiento.TallerAsistencia.TallerMaeCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            objEntCol = New Entity.Tratamiento.TallerAsistencia.TallerMaeCol

            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.TallerMae.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)

            objEnt = New Entity.Tratamiento.TallerAsistencia.TallerMae

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.TallerMae
                        With objEnt
                            .Codigo = sqlDr("pk_tra_tal_id").ToString
                            .TallerIdBiometrico = sqlDr("n_pk_tal_id").ToString
                            .TipoActividadId = sqlDr("fk_tra_tal_tip_act_id").ToString
                            .TipoActividadNombre = sqlDr("c_tra_tal_tip_act_nom").ToString
                            .ActividadId = sqlDr("fk_tra_tal_act_id").ToString
                            .ActividadNombre = sqlDr("c_tra_tal_act_nom").ToString
                            .NombreTaller = sqlDr("c_tra_tal_nom").ToString
                            .DescripcionTaller = sqlDr("c_tra_tal_des").ToString
                            .NombreRespControlLab = sqlDr("c_ape_nom_res_con_per").ToString
                            .NombreGestorProd = sqlDr("c_ape_nom_ges_pro").ToString
                            .PabellonTaller = sqlDr("c_lug").ToString
                            .RegionNom = sqlDr("reg_nom").ToString
                            .PenalNom = sqlDr("pen_nom").ToString
                            .GrupoUsuarioRaiz = sqlDr("c_grup_usu_raiz").ToString
                            .GrupoUsuario = sqlDr("c_grup_usu").ToString
                            .GrupoAcceso = sqlDr("c_grup_acces").ToString
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
    End Class
End Namespace