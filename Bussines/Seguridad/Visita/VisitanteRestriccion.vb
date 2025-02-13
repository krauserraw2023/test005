Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class VisitanteRestriccion
        Private objEnt As Entity.Visita.VisitanteRestriccion = Nothing
        Private objEntCol As Entity.Visita.VisitanteRestriccionCol = Nothing
#Region "Functions"
        Public Function ValidarTieneRestriccionVisitante(objEnt As Entity.Visita.VisitanteRestriccion) As Boolean

            Dim value As Integer = 0
            value = Data.Visita.VisitanteRestriccion.ListarOutput("lst", "lst_count_restriccion_visitante", objEnt)

            Return value > 0

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.VisitanteRestriccion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Visita.VisitanteRestriccion
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Visita.VisitanteRestriccion.Listar(sqlCon, "lst", "", objEntFiltro)
            objEnt = New Entity.Visita.VisitanteRestriccion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("vis_res_id").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .RestriccionTipoID = sqlDr("res_tip_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .InternoApeNom = sqlDr("int_ape_nom").ToString
                            .Documento = sqlDr("vis_res_doc").ToString
                            .Fecha = sqlDr("vis_res_fec").ToString
                            .FechaInicio = sqlDr("vis_res_ini").ToString
                            .FechaFin = sqlDr("vis_res_fin").ToString
                            .FechaFinIndeterminado = sqlDr("vis_res_fec_fin_ind").ToString
                            .EstadoID = sqlDr("est_id").ToString
                            .Observacion = sqlDr("vis_res_obs").ToString
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
        Public Function Listar(ByVal objEntFiltro As Entity.Visita.VisitanteRestriccion) As Entity.Visita.VisitanteRestriccionCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.VisitanteRestriccion.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.VisitanteRestriccionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.VisitanteRestriccion
                        With objEnt
                            .Codigo = sqlDr("vis_res_id").ToString
                            .VisitanteID = sqlDr("vis_id").ToString
                            .Documento = sqlDr("vis_res_doc").ToString
                            .Fecha = sqlDr("vis_res_fec").ToString
                            .FechaInicio = sqlDr("vis_res_ini").ToString
                            .FechaFin = sqlDr("vis_res_fin").ToString
                            .FechaFinIndeterminado = sqlDr("vis_res_fec_fin_ind").ToString
                            .RestriccionTipoID = sqlDr("res_tip_id").ToString
                            .RestriccionTipo = sqlDr("res_tip_nom").ToString
                            .EstadoID = sqlDr("est_id").ToString
                            .Observacion = sqlDr("vis_res_obs").ToString
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
        Public Function Grabar(ByVal objEnt As Entity.Visita.VisitanteRestriccion) As Integer

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

                If .InternoID < 1 Then
                    .InternoID = -1
                End If
            End With

            Value = Data.Visita.VisitanteRestriccion.Grabar(strAccion, strOpcion, objEnt)

            Return Value

        End Function

        Public Function GrabarEstado(ByVal Codigo As Integer) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim intEstado As Integer = 0

            strAccion = "upd"
            strOpcion = "upd_estado"

            Dim objEnt As New Entity.Visita.VisitanteRestriccion

            With objEnt
                .Codigo = Codigo
                .EstadoID = intEstado
            End With

            Value = Data.Visita.VisitanteRestriccion.Grabar(strAccion, strOpcion, objEnt)

            Return Value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.VisitanteRestriccion) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.VisitanteRestriccion.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace