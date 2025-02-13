Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteContenido
        Public Function Listar(Codigo As Integer) As Entity.Reporte.ReporteContenido
            Dim ent As New Entity.Reporte.ReporteContenido
            Dim list As New Entity.Reporte.ReporteContenidoCol

            ent.Codigo = Codigo
            list = Listar(ent)

            If list.Count = 0 Then Return Nothing

            Return list.ReporteContenido(0)
        End Function

        Public Function Listar(Ent As Entity.Reporte.ReporteContenido) As Entity.Reporte.ReporteContenidoCol
            Dim list As New Entity.Reporte.ReporteContenidoCol
            Dim objEnt As Entity.Reporte.ReporteContenido
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.ReporteContenido.Listar(sqlCon, "lst", "lst_mant", Ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.ReporteContenido
                        With objEnt
                            .Codigo = sqlDr("pk_cont_id").ToString
                            .RptCabeceraId = sqlDr("fk_rpt_cab_id").ToString
                            .ClaveStr = sqlDr("c_clave").ToString
                            .ValorInt = sqlDr("c_valor").ToString
                            .ValorStr = sqlDr("n_valor").ToString
                            .RegionId = sqlDr("_regId").ToString
                            .PenalId = sqlDr("_penId").ToString
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

        Public Function Grabar(Ent As Entity.Reporte.ReporteContenido) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Reporte.ReporteContenido.Grabar(strAccion, strOpcion, Ent)

            Return intValue
        End Function
    End Class
End Namespace
