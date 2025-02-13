Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class CalendarioDetalle
        Private objEnt As Entity.Visita.CalendarioDetalle = Nothing
        Private objEntCol As Entity.Visita.CalendarioDetalleCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Opcion As String, ByVal Codigo As Integer, _
        ByVal Calendario As Integer, _
        ByVal Tipo As Integer, _
        ByVal FechaDesde As Long, _
        ByVal FechaDesdeDia As Integer, _
        ByVal FechaDesdeMes As Integer, _
        ByVal FechaDesdeAnio As Integer, _
        ByVal FechaHasta As Long, _
        ByVal FechaHastaDia As Integer, _
        ByVal FechaHastaMes As Integer, _
        ByVal FechaHastaAnio As Integer, _
        ByVal HoraDesde As Integer, _
        ByVal HoraHasta As Integer, _
        ByVal Sexo As Integer, _
        ByVal Menores As Integer, _
        ByVal Lunes As Boolean, _
        ByVal Martes As Boolean, _
        ByVal Miercoles As Boolean, _
        ByVal Jueves As Boolean, _
        ByVal Viernes As Boolean, _
        ByVal Sabado As Boolean, _
        ByVal Domingo As Boolean _
        ) As Entity.Visita.CalendarioDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.CalendarioDetalle.Listar(sqlCon, "lst", Opcion, Codigo, _
Calendario, _
             Tipo, _
            FechaDesde, _
            FechaDesdeDia, _
            FechaDesdeMes, _
            FechaDesdeAnio, _
            FechaHasta, _
            FechaHastaDia, _
            FechaHastaMes, _
            FechaHastaAnio, _
            HoraDesde, _
            HoraHasta, _
            Sexo, _
            Menores, _
            Lunes, _
            Martes, _
            Miercoles, _
            Jueves, _
            Viernes, _
            Sabado, _
            Domingo _
            )
            Try
                objEntCol = New Entity.Visita.CalendarioDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.CalendarioDetalle
                        With objEnt
                            .Codigo = sqlDr("cal_det_id").ToString
                            .CalendarioId = sqlDr("cal_tip_id").ToString
                            .Tipo = sqlDr("tip_id").ToString
                            .TipoStr = sqlDr("tip_nom").ToString
                            .FechaDesde = sqlDr("cal_det_fec_dsd").ToString
                            .FechaDesdeDia = sqlDr("cal_det_fec_dsd_dia").ToString
                            .FechaDesdeMes = sqlDr("cal_det_fec_dsd_mes").ToString
                            .FechaDesdeAnio = sqlDr("cal_det_fec_dsd_anio").ToString
                            .FechaHasta = sqlDr("cal_det_fec_hst").ToString
                            .FechaHastaDia = sqlDr("cal_det_fec_hst_dia").ToString
                            .FechaHastaMes = sqlDr("cal_det_fec_hst_mes").ToString
                            .FechaHastaAnio = sqlDr("cal_det_fec_jst_anio").ToString
                            .HoraDesde = sqlDr("cal_det_hor_dsd").ToString
                            .HoraHasta = sqlDr("cal_det_hor_hst").ToString
                            .Sexo = sqlDr("cal_det_sex").ToString
                            .Menores = sqlDr("cal_det_men").ToString
                            .Lunes = sqlDr("cal_det_lun").ToString
                            .Martes = sqlDr("cal_det_mar").ToString
                            .Miercoles = sqlDr("cal_det_mir").ToString
                            .Jueves = sqlDr("cal_det_jue").ToString
                            .Viernes = sqlDr("cal_det_vie").ToString
                            .Sabado = sqlDr("cal_det_sab").ToString
                            .Domingo = sqlDr("cal_det_dom").ToString
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
    End Class
End Namespace