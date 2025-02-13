Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia
    Public Class Calendario
        Private objEnt As Entity.Tratamiento.TallerAsistencia.Calendario = Nothing
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.CalendarioCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Tratamiento.TallerAsistencia.Calendario

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.Calendario
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.Calendario.Listar(sqlCon, "lst", "", objEntFiltro)
            objEnt = New Entity.Tratamiento.TallerAsistencia.Calendario
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pk_cal_id").ToString
                            .IDRegion = sqlDr("kf_reg_id").ToString
                            .IDPenal = sqlDr("kf_pen_id").ToString
                            .Nombre = sqlDr("c_nom").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .Mes = sqlDr("n_mes").ToString
                            .Dia = sqlDr("n_dia").ToString
                            .Tipo = sqlDr("n_tip").ToString
                            .Obs = sqlDr("c_obs").ToString                            
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
        Public Function Listar(ByVal objEntFiltro As Entity.Tratamiento.TallerAsistencia.Calendario) As Entity.Tratamiento.TallerAsistencia.CalendarioCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.Calendario.Listar(sqlCon, "lst", "lst_mant_fer", objEntFiltro)
            Try
                objEntCol = New Entity.Tratamiento.TallerAsistencia.CalendarioCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.Calendario
                        With objEnt
                            .Codigo = sqlDr("pk_cal_id").ToString
                            .IDRegion = sqlDr("kf_reg_id").ToString
                            .IDPenal = sqlDr("kf_pen_id").ToString
                            .Nombre = sqlDr("c_nom").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .Mes = sqlDr("n_mes").ToString
                            .Dia = sqlDr("n_dia").ToString
                            .Tipo = sqlDr("n_tip").ToString
                            .Obs = sqlDr("c_obs").ToString
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

        Public Function ListarGrilla(ByVal objEntFiltro As Entity.Tratamiento.TallerAsistencia.Calendario) As Entity.Tratamiento.TallerAsistencia.CalendarioCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.Calendario.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Tratamiento.TallerAsistencia.CalendarioCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.Calendario
                        With objEnt
                            .Codigo = sqlDr("pk_cal_id").ToString
                            .IDRegion = sqlDr("kf_reg_id").ToString
                            .IDPenal = sqlDr("kf_pen_id").ToString
                            .Nombre = sqlDr("c_nom").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .Mes = sqlDr("n_mes").ToString
                            .Dia = sqlDr("n_dia").ToString
                            .Tipo = sqlDr("n_tip").ToString
                            .Obs = sqlDr("c_obs").ToString
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
        Public Function Grabar(ByVal objEnt As Entity.Tratamiento.TallerAsistencia.Calendario) As Integer
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
            Value = Data.Tratamiento.TallerAsistencia.Calendario.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Tratamiento.TallerAsistencia.Calendario) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Tratamiento.TallerAsistencia.Calendario.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace