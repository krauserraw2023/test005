Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteTipo
        Public Function Listar(Ent As Entity.Reporte.ReporteTipo) As Entity.Reporte.ReporteTipoCol
            Dim list As New Entity.Reporte.ReporteTipoCol
            Dim objEnt As Entity.Reporte.ReporteTipo
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.ReporteTipo.Listar(sqlCon, "lst", "lst_mant", Ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.ReporteTipo
                        With objEnt
                            .Codigo = sqlDr("pk_rpt_tip_id").ToString
                            .NombreTipo = sqlDr("c_nom").ToString
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