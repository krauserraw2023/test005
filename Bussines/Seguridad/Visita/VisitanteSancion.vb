Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class VisitanteSancion
        Private objEnt As Entity.Visita.VisitanteSancion = Nothing
        Private objEntCol As Entity.Visita.VisitanteSancionCol = Nothing
#Region "Functions"
        Public Function Sancion(ByVal VisitanteID As Integer, ByVal Fecha As Long) As Boolean

            Dim blnValue As Boolean = False
            Dim intValue As Integer = -1

            intValue = Data.Visita.VisitanteSancion.ListarOutput("lst", "lst_visita_sancion", _
            -1, VisitanteID, Fecha)

            If intValue > 0 Then
                blnValue = True
            End If

            Return blnValue

        End Function
        Public Function IDUltimaSancionVigente(ByVal VisitanteID As Integer, ByVal Fecha As Long) As Integer

            Dim value As Integer = -1

            value = Data.Visita.VisitanteSancion.ListarOutput("lst", "lst_id_ultimo_vigente", _
            -1, VisitanteID, Fecha)

            Return value

        End Function
#End Region
#Region "Listar"        
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.VisitanteSancion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.VisitanteSancion.Listar(sqlCon, "lst", "lst_mant", _
            Codigo, -1, "", "", "", "", 0, 0, 0, -1, -1, -1)
            objEnt = New Entity.Visita.VisitanteSancion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("vis_san_id").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .FechaInicio = sqlDr("vis_san_ini").ToString
                            .FechaFin = sqlDr("vis_san_fin").ToString
                            .FechaFinIndeterminado = sqlDr("vis_san_fec_fin_ind").ToString
                            .Fecha = sqlDr("vis_san_fec").ToString
                            .TipoSancionID = sqlDr("san_tip_id").ToString
                            .TipoSancionNombre = sqlDr("san_tip_nom").ToString
                            .EstadoID = sqlDr("est_id").ToString
                            .Documento = sqlDr("vis_san_doc").ToString
                            .Observacion = sqlDr("vis_san_obs").ToString
                            '/*anulacion*/
                            .DocumentoAnulacion = sqlDr("c_vis_san_doc_anu").ToString
                            .MotivoAnulacion = sqlDr("c_vis_san_mot_anu").ToString
                            .FechaAnulacion = sqlDr("n_vis_san_fec_anu").ToString
                            .ObsAnulacion = sqlDr("c_vis_san_obs_anu").ToString
                            .IDUsuarioAnulacion = sqlDr("kf_usu_id_anu").ToString
                            '/*penal/region*/
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .IDRegionOrigen = sqlDr("kf_reg_id_org").ToString
                            .IDPenalOrigen = sqlDr("kf_pen_id_org").ToString
                            '/*auditoria*/
                            .IDUsuarioCreacion = sqlDr("_usu_cre").ToString
                            .FechaCreacion = sqlDr("_fec_cre").ToString
                            .IDUsuarioModificacion = sqlDr("_usu_mod").ToString
                            .FechaModificacion = sqlDr("_fec_mod").ToString
                            .Eliminado = sqlDr("_flg_eli").ToString
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
        Public Function Listar(ByVal Codigo As Integer, _
        ByVal VisitanteID As Integer, ByVal VisNumDoc As String, ByVal VisApePat As String, _
        ByVal VisApeMat As String, _
        ByVal VisNom As String, ByVal Fecha As Long, ByVal FechaIni As Long, ByVal FechaFin As Long, _
        ByVal TipoSancion As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalId As Integer) As Entity.Visita.VisitanteSancionCol
            ''
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.VisitanteSancion.Listar(sqlCon, "lst", "lst_grilla", Codigo, _
            VisitanteID, VisNumDoc, VisApePat, VisApeMat, VisNom, Fecha, FechaIni, _
            FechaFin, TipoSancion, _
            REgionID, _
            PenalId)

            Try
                objEntCol = New Entity.Visita.VisitanteSancionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.VisitanteSancion
                        With objEnt
                            .Codigo = sqlDr("vis_san_id").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .NumeroDocumento = sqlDr("vis_doc_num").ToString
                            .ApellidoPaterno = sqlDr("vis_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("vis_ape_mat").ToString
                            .Nombres = sqlDr("vis_nom").ToString
                            .Fecha = sqlDr("vis_san_fec").ToString
                            .FechaInicio = sqlDr("vis_san_ini").ToString
                            .FechaFin = sqlDr("vis_san_fin").ToString
                            .FechaFinIndeterminado = sqlDr("vis_san_fec_fin_ind").ToString
                            .TipoSancionID = sqlDr("san_tip_id").ToString
                            .TipoSancionNombre = sqlDr("san_tip_nom").ToString
                            .Documento = sqlDr("vis_san_doc").ToString
                            .EstadoID = sqlDr("est_id").ToString
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
                            '.Observacion = sqlDr("vis_san_obs").ToString
                            .IDVisitanteSancionSede = sqlDr("pk_san_id_sed").ToString
                            .IDRegionOrigen = sqlDr("kf_reg_id_org").ToString
                            .IDPenalOrigen = sqlDr("kf_pen_id_org").ToString
                            .strRegionOrigen = sqlDr("reg_nom_org").ToString
                            .strPenalOrigen = sqlDr("pen_nom_org").ToString
                            .FechaSede = sqlDr("n_vis_san_fec_sed").ToString
                            .FechaDestino = sqlDr("n_vis_san_fec_rcp").ToString
                            .FechaCreacion = sqlDr("_fec_cre").ToString
                            .FechaModificacion = sqlDr("_fec_mod").ToString
                            .FechaAnulacion = sqlDr("n_vis_san_fec_anu").ToString
                            .UsuarioCreacionNombres = Legolas.Components.Cadena.ProperCase(sqlDr("usu_nom").ToString)
                            .UsuarioAnulacionNombres = Legolas.Components.Cadena.ProperCase(sqlDr("usu_anu_nom").ToString)
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
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal Visitante As Integer, ByVal Fecha As Long, _
        ByVal FechaIni As Long, _
        ByVal fechaFin As Long, _
        ByVal TipoSancion As Integer, _
        ByVal Documento As String, ByVal Estado As Integer, _
        ByVal Obs As String, _
        ByVal RegionId As Integer, ByVal PenalId As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Visita.VisitanteSancion.Grabar(strAccion, strOpcion, Codigo, _
            Visitante, Fecha, FechaIni, fechaFin, TipoSancion, Documento, Estado, Obs, _
            RegionId, PenalId, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
        Public Function Grabar(ByVal objEnt As Entity.Visita.VisitanteSancion) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt

                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                value = Data.Visita.VisitanteSancion.Grabar(strAccion, strOpcion, objEnt)

            End With

            Return value
        End Function
        Public Function GrabarEstado(ByVal Codigo As Integer) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim intEstado As Integer = 0

            strAccion = "upd"
            strOpcion = "upd_estado"

            Value = Data.Visita.VisitanteSancion.Grabar(strAccion, strOpcion, Codigo, _
            -1, 0, 0, 0, -1, "", intEstado, "", -1, -1, _
            Legolas.Configuration.Usuario.Codigo)

            Return Value

        End Function
        Public Function GrabarAnu(ByVal objEnt As Entity.Visita.VisitanteSancion) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt

                strAccion = "upd"
                strOpcion = "upd_mant_anu"

                value = Data.Visita.VisitanteSancion.Grabar(strAccion, strOpcion, objEnt)

            End With

            Return value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            intValue = Data.Visita.VisitanteSancion.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue

        End Function
#End Region
    End Class
End Namespace