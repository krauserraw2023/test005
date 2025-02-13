Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.General
    Public Class Reportecuadro2_Detalle
        Private objEnt As Entity.Mantenimiento.General.ReporteCuadro2_Detalle = Nothing
        Private objEntCol As Entity.Mantenimiento.General.ReporteCuadro2_DetalleCol = Nothing
#Region "Listar"
        Public Function Listar(obj As Entity.Mantenimiento.General.ReporteCuadro2_Detalle) As Entity.Mantenimiento.General.ReporteCuadro2_DetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Reportecuadro2_Detalle.Listar(sqlCon, "lst", "lst_grilla", obj)

            Try
                objEntCol = New Entity.Mantenimiento.General.ReporteCuadro2_DetalleCol

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.ReporteCuadro2_Detalle
                        With objEnt
                            .Codigo = sqlDr("rpt_cua_2_det_id").ToString
                            .IDCuadroDelito  = sqlDr("rpt_cua_2_id").ToString
                            .IDDelitoEspecifico = sqlDr("del_esp_id").ToString
                            .NombreEspecifico = sqlDr("del_esp_nom").ToString
                            .Capitulo = sqlDr("del_cap_num").ToString & " " & sqlDr("del_cap_nom").ToString
                            .Generico = sqlDr("del_gen_nom").ToString
                            .Articulo = sqlDr("del_art_nom_cor").ToString
                            .Seccion = sqlDr("del_sec_num").ToString & " " & sqlDr("del_sec_nom").ToString
                            .CuadroVersion = sqlDr("cua_ver").ToString
                            'estado del delito
                            Dim strEstadoNombre As String = ""
                            Dim intEstado As Integer = sqlDr("del_esp_est").ToString
                            Select Case intEstado
                                Case 0
                                    strEstadoNombre = "Anulado"
                                Case 1
                                    strEstadoNombre = "Activo"
                                Case 2
                                    strEstadoNombre = "Derogado"
                                Case Else
                                    strEstadoNombre = "Por Regularizar"
                            End Select
                            .EstadoNombre = strEstadoNombre
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
#Region "Validar"
        Public Function ValidarSiExistDelitoEspeEnOtroCuadro(intIDDelitoEspecifico As Integer, strDelitoEspecificoNombre As String, intCuadroVersion As Short,
                                                             ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim intIDCuadroDelito As Integer = -1

            objEnt = New Entity.Mantenimiento.General.ReporteCuadro2_Detalle
            With objEnt
                .IDDelitoEspecifico = intIDDelitoEspecifico
                .CuadroVersion = intCuadroVersion
            End With

            intIDCuadroDelito = Data.Mantenimiento.General.Reportecuadro2_Detalle.ListarOutput("lst", "lst_get_cuadro_delito_especifico", objEnt)

            If intIDCuadroDelito < 1 Then
                strMensajeOut = ""
                value = True
            Else

                Dim objBssCuadro As New Bussines.Mantenimiento.Reportecuadro2
                Dim objEntCuadro As New Entity.Mantenimiento.ReporteCuadro2
                objEntCuadro = objBssCuadro.Listar(intIDCuadroDelito)
                strMensajeOut = "El delito especifico: " & strDelitoEspecificoNombre & ", existe en el grupo: " & objEntCuadro.Generico & "/" & objEntCuadro.Especifico

            End If

            Return value

        End Function
#End Region
#Region "Grabar"

        Public Function Grabar(objEntDet As Entity.Mantenimiento.General.ReporteCuadro2_Detalle, ByRef strMensajeout As String) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntDet.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                'validar si el delito especifico esta asignado a otro cuadro, no debe permitir grabar
                If ValidarSiExistDelitoEspeEnOtroCuadro(objEntDet.IDDelitoEspecifico, objEntDet.NombreEspecifico, objEntDet.CuadroVersion, strMensajeout) = False Then
                    Return value
                End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Data.Mantenimiento.General.Reportecuadro2_Detalle.Grabar(strAccion, strOpcion, objEntDet)

            Return value
        End Function

        Public Function Grabar(intIDGrupoDelitoDet As Integer, intIDGrupoDelito As Integer, intIDDelitoEspecifico As Integer, strDelitoEspNombre As String,
                               intCuadroVersion As Short, ByRef strMensajeout As String) As Integer

            Dim value As Integer = -1
            objEnt = New Entity.Mantenimiento.General.ReporteCuadro2_Detalle
            With objEnt
                .Codigo = -1
                .IDCuadroDelito = intIDGrupoDelito
                .IDDelitoEspecifico = intIDDelitoEspecifico
                .NombreEspecifico = strDelitoEspNombre
                .CuadroVersion = intCuadroVersion
            End With

            If intIDGrupoDelitoDet > 0 Then
                Eliminar(intIDGrupoDelitoDet)
                value = Grabar(objEnt, strMensajeout)
            Else
                value = Grabar(objEnt, strMensajeout)
            End If

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
            intValue = Data.Mantenimiento.General.Reportecuadro2_Detalle.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
#End Region
    End Class
End Namespace