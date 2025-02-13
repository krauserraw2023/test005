Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class InternoSancion
        Private objEnt As Entity.Visita.InternoSancion = Nothing
        Private objEntCol As Entity.Visita.InternoSancionCol = Nothing
#Region "Functions"
        Public Function Sancion(ByVal InternoID As Integer, ByVal Fecha As Long) As Boolean

            Dim blnValue As Boolean = False
            Dim intValue As Integer = -1

            intValue = Data.Visita.InternoSancion.ListarOutput("lst", "lst_interno_sancion", _
            -1, InternoID, Fecha)

            If intValue > 0 Then
                blnValue = True
            End If

            Return blnValue

        End Function
        Public Function IDUltimaSancionVigente(ByVal InternoID As Integer, ByVal Fecha As Long) As Integer

            Dim value As Integer = -1

            value = Data.Visita.InternoSancion.ListarOutput("lst", "lst_id_ultimo_vigente", _
            -1, InternoID, Fecha)

            Return value

        End Function

#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.InternoSancion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.InternoSancion.Listar(sqlCon, "lst", "", _
            Codigo, -1, "", "", "", "", 0, 0, 0, -1, -1, -1)

            objEnt = New Entity.Visita.InternoSancion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_san_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Fecha = sqlDr("int_san_fec").ToString
                            .FechaInicio = sqlDr("int_san_ini").ToString
                            .FechaFin = sqlDr("int_san_fin").ToString
                            .FechaFinIndeterminado = sqlDr("int_san_fec_fin_ind").ToString
                            .Documento = sqlDr("int_san_doc").ToString
                            .TipoSancion = sqlDr("san_tip_id").ToString
                            .EstadoID = sqlDr("est_id").ToString
                            .Obs = sqlDr("int_san_obs").ToString
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
        ByVal InternoID As Integer, ByVal NumDoc As String, ByVal ApePat As String, _
        ByVal ApeMat As String, _
        ByVal Nombres As String, ByVal Fecha As Long, ByVal FechaIni As Long, ByVal FechaFin As Long, _
        ByVal TipoSancion As Integer, _
        ByVal regionid As Integer, _
        ByVal penalid As Integer) As Entity.Visita.InternoSancionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.InternoSancion.Listar(sqlCon, "lst", "lst_grilla", Codigo, _
            InternoID, NumDoc, ApePat, ApeMat, Nombres, Fecha, FechaIni, FechaFin, _
            TipoSancion, _
            regionid, _
            penalid)

            Try
                objEntCol = New Entity.Visita.InternoSancionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.InternoSancion
                        With objEnt
                            .Codigo = sqlDr("int_san_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .Fecha = sqlDr("int_san_fec").ToString
                            .FechaInicio = sqlDr("int_san_ini").ToString
                            .FechaFin = sqlDr("int_san_fin").ToString
                            .FechaFinIndeterminado = sqlDr("int_san_fec_fin_ind").ToString
                            .TipoSancion = sqlDr("san_tip_id").ToString
                            .TipoSancionNombre = sqlDr("san_tip_nom").ToString
                            .Documento = sqlDr("int_san_doc").ToString
                            .EstadoID = sqlDr("est_id").ToString
                            '.Obs = sqlDr("int_san_obs").ToString
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
        ByVal InternoID As Integer, ByVal TipoSancion As Integer, ByVal Fecha As Long, _
        ByVal FechaInicio As Long, _
        ByVal FechaFin As Long, ByVal Documento As String, _
        ByVal EstadoID As Integer, _
        ByVal Observacion As String, _
        ByVal REgionId As Integer, ByVal PenalId As Integer) As Integer

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

            intValue = Data.Visita.InternoSancion.Grabar(strAccion, strOpcion, Codigo, _
            InternoID, TipoSancion, Fecha, FechaInicio, FechaFin, Documento, EstadoID, _
            Observacion, _
            REgionId, PenalId, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue

        End Function
        Public Function Grabar(ByVal objEnt As Entity.Visita.InternoSancion) As Integer

            Dim intValue As Integer = -1
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

                intValue = Data.Visita.InternoSancion.Grabar(strAccion, strOpcion, objEnt)

            End With
        

            Return intValue

        End Function
        Public Function GrabarEstado(ByVal Codigo As Integer) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim intEstado As Integer = 0

            strAccion = "upd"
            strOpcion = "upd_estado"

            value = Data.Visita.InternoSancion.Grabar(strAccion, strOpcion, Codigo, _
            -1, -1, 0, 0, 0, "", intEstado, _
            "", -1, -1, _
            Legolas.Configuration.Usuario.Codigo)

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

            intValue = Data.Visita.InternoSancion.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
#End Region
    End Class
End Namespace