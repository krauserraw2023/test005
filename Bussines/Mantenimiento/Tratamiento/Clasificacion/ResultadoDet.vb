Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Tratamiento.Clasificacion
    Public Class ResultadoDet

        Private objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE = Nothing
        Private objEntCol As Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE) = Nothing

#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            Dim entFich As New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
            entFich.Codigo = Codigo

            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing

            Return objEntCol.Entity(0)
        End Function

        Public Function Listar(ByVal ent As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE) As Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim lst As New Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet.Listar(sqlCon, "lst", "lst_mant", ent)


            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
                        With objEnt
                            .Codigo = sqlDr("pk_fic_res_det_id").ToString
                            .IDFichaResultado = sqlDr("fk_fic_res_id").ToString
                            .NacionalidadInterno = sqlDr("n_nac_int").ToString
                            .PuntajeInicial = sqlDr("n_ptj_ini").ToString
                            .PuntajeFinal = sqlDr("n_ptj_fin").ToString
                            .Descripcion = sqlDr("c_des").ToString
                            .IDTabla = sqlDr("n_tbl_id").ToString
                            .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                        End With
                        lst.Add(objEnt)
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
            Return lst
        End Function
        Public Function Listar_pen(ByVal ent As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE) As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDetCol_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim lst As New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDetCol_BE

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet.ListarPenal(sqlCon, "lst", "lst_mant_pen", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
                        With objEnt
                            .Codigo = sqlDr("pk_fic_res_det_id").ToString
                            .IDFichaResultado = sqlDr("fk_fic_res_id").ToString
                            .PuntajeInicial = sqlDr("fic_res_pen_det_ini").ToString
                            .PuntajeFinal = sqlDr("fic_res_pen_det_fin").ToString
                            '.Descripcion = sqlDr("c_des").ToString
                            .IDTabla = sqlDr("fk_tra_asi_var_pen").ToString
                            .NacionalidadInterno = sqlDr("fk_pab_id").ToString
                            '.SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                        End With
                        lst.Add(objEnt)
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
            Return lst
        End Function
        Public Function Listar_res(ByVal ent As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE) As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDetCol_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim lst As New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDetCol_BE

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet.ListarPenal(sqlCon, "lst", "lst_mant_pen", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE
                        With objEnt
                            .Codigo = sqlDr("pk_fic_res_det_id").ToString
                            .IDFichaResultado = sqlDr("fk_fic_res_id").ToString
                            .NacionalidadInterno = sqlDr("n_nac_int").ToString
                            .PuntajeInicial = sqlDr("n_ptj_ini").ToString
                            .PuntajeFinal = sqlDr("n_ptj_fin").ToString
                            .Descripcion = sqlDr("c_des").ToString
                            .IDTabla = sqlDr("n_tbl_id").ToString
                            .SituacionJuridicaId = sqlDr("sit_jur_id").ToString
                        End With
                        lst.Add(objEnt)
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
            Return lst
        End Function

#End Region


#Region "Grabar"

        Public Function Grabar(objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE, ByRef outSMS As String) As Short

            Dim value As Short
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Data.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef strMensaje As String) As Short

            Dim value As Integer = -1

            value = Data.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet.Eliminar(accion, opcion, Codigo, strMensaje)

            Return value

        End Function
#End Region

    End Class

End Namespace