Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteDoc
        Public Function VersionRecienteReporte(TipoReporteId As Integer) As Entity.Reporte.ReporteDoc
            Dim list As New Entity.Reporte.ReporteDocCol
            Dim ent As New Entity.Reporte.ReporteDoc
            ent.TipoReporteId = TipoReporteId
            list = Listar(ent)
            If list.Count = 0 Then Return Nothing
            list.Sort("Codigo") 'de mayor a menor
            Return list.ReporteDoc(list.Count - 1) 'se toma el mayor
        End Function

        Public Function Listar(Ent As Entity.Reporte.ReporteDoc) As Entity.Reporte.ReporteDocCol
            Dim list As New Entity.Reporte.ReporteDocCol
            Dim objEnt As Entity.Reporte.ReporteDoc
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.ReporteDoc.Listar(sqlCon, "lst", "lst_mant_v2", Ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.ReporteDoc
                        With objEnt
                            .Codigo = sqlDr("rpt_id").ToString
                            .ModuloNombre = sqlDr("rpt_mod_nom").ToString
                            .NombreReporte = sqlDr("rpt_nom").ToString
                            .NombreFisicoReporte = sqlDr("rpt_nom_fis").ToString
                            .NumeroReporte = sqlDr("rpt_num").ToString
                            .NumeroExpediente = sqlDr("rpt_num_exp").ToString
                            .DepartamentoNombre = sqlDr("rpt_dep_nom").ToString
                            .MudloNombreCorto = sqlDr("rpt_mod").ToString
                            .Version = sqlDr("rpt_ver").ToString
                            .Acta = sqlDr("rpt_act").ToString
                            .TipoReporteId = sqlDr("fk_rpt_tip_id").ToString
                        End With
                        list.Add(objEnt)
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

            Return list
        End Function
    End Class
End Namespace