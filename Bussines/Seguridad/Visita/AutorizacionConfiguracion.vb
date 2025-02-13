Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class AutorizacionConfiguracion
        Private objEnt As Entity.Visita.AutorizacionConfiguracion = Nothing

#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer, ByVal IDPenal As Integer, ByVal IDRegion As Integer) As Entity.Visita.AutorizacionConfiguracion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Visita.AutorizacionConfiguracion
            objEntFiltro.Codigo = Codigo
            objEntFiltro.PenalID = IDPenal
            objEntFiltro.RegionID = IDRegion
            Dim sqlDr As SqlDataReader = Data.Visita.AutorizacionConfiguracion.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Visita.AutorizacionConfiguracion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("aut_conf_id").ToString
                            .ConfiguracionDiaMaximo = sqlDr("aut_conf_max_vis").ToString
                            .ConfiguracionEnero = sqlDr("aut_conf_ene").ToString
                            .ConfiguracionFebrero = sqlDr("aut_conf_feb").ToString
                            .ConfiguracionMarzo = sqlDr("aut_conf_mar").ToString
                            .ConfiguracionAbril = sqlDr("aut_conf_abr").ToString
                            .ConfiguracionMayo = sqlDr("aut_conf_may").ToString
                            .ConfiguracionJunio = sqlDr("aut_conf_jun").ToString
                            .ConfiguracionJulio = sqlDr("aut_conf_jul").ToString
                            .ConfiguracionAgosto = sqlDr("aut_conf_ago").ToString
                            .ConfiguracionSetiembre = sqlDr("aut_conf_set").ToString
                            .ConfiguracionOctubre = sqlDr("aut_conf_oct").ToString
                            .ConfiguracionNoviembre = sqlDr("aut_conf_nov").ToString
                            .ConfiguracionDiciembre = sqlDr("aut_conf_dic").ToString
                            .EstadoID = sqlDr("aut_conf_est").ToString
                            .ConfiguracionObs = sqlDr("aut_conf_obs").ToString
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
#End Region
#Region "Grabar"

        Public Function Grabar(ByVal objEnt As Entity.Visita.AutorizacionConfiguracion) As Integer

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

            Value = Data.Visita.AutorizacionConfiguracion.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function

#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.AutorizacionConfiguracion) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.AutorizacionConfiguracion.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace