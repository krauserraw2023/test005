Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia


    Public Class PlanillaCabecera
        Private objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera = Nothing
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol = Nothing
#Region "Combo"
        Public Function ComboEstado(Optional blnTodos As Boolean = False) As DataTable

            Dim objDT As New DataTable("Combo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            Dim strMensaje As String = "[Seleccione]"

            If blnTodos = True Then
                strMensaje = "[Todos]"
            End If

            objDT.Rows.Add(New Object() {-1, strMensaje})
            objDT.Rows.Add(New Object() {0, "Anulado"})
            objDT.Rows.Add(New Object() {1, "Procesado"})
            objDT.Rows.Add(New Object() {2, "Terminado"})
            objDT.AcceptChanges()

            Return objDT

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.PlanillaCabecera.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pk_pla_id").ToString
                            .IDRegion = sqlDr("kf_reg_id").ToString
                            .IDPenal = sqlDr("kf_pen_id").ToString
                            .IDTaller = sqlDr("kf_tal_id").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .Mes = sqlDr("n_mes").ToString
                            .FechaInicio = sqlDr("n_fec_ini").ToString
                            .FechaFin = sqlDr("n_fec_fin").ToString
                            .Correlativo = sqlDr("n_cor").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .FechaProceso = sqlDr("n_fec_pro").ToString
                            .Estado = sqlDr("n_est").ToString
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
        Public Function Listar(ByVal objEntFiltro As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera) As Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.PlanillaCabecera.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try
                objEntCol = New Entity.Tratamiento.TallerAsistencia.PlanillaCabeceraCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
                        With objEnt
                            .Codigo = sqlDr("pk_pla_id").ToString
                            .IDRegion = sqlDr("kf_reg_id").ToString
                            .IDPenal = sqlDr("kf_pen_id").ToString
                            .RegionNombre = sqlDr("kf_reg_nom").ToString
                            .PenalNombre = sqlDr("kf_pen_nom").ToString
                            .IDTaller = sqlDr("kf_tal_id").ToString
                            .TallerNombre = sqlDr("kf_tal_nom").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .Mes = sqlDr("n_mes").ToString
                            .Correlativo = sqlDr("n_cor").ToString
                            .Pabellon = sqlDr("c_lug").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .Estado = sqlDr("n_est").ToString
                            .FechaProceso = sqlDr("n_fec_pro").ToString
                            .Audit_UsuarioCreacion = sqlDr("UsuarioCreacion").ToString
                            .Audit_UsuarioModificacion = sqlDr("UsuarioModific").ToString
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
        Public Function Grabar(ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera) As Integer
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
                End If
            End With
            Value = Data.Tratamiento.TallerAsistencia.PlanillaCabecera.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
        Public Function GrabarEstado(ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_mant_est"

            Value = Data.Tratamiento.TallerAsistencia.PlanillaCabecera.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(intIDCodigo As Integer) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            objEnt = New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera

            With objEnt
                .Codigo = intIDCodigo
            End With

            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Tratamiento.TallerAsistencia.PlanillaCabecera.Eliminar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region

    End Class
    
End Namespace