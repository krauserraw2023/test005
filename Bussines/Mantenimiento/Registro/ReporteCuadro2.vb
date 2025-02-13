Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento
    Public Class Reportecuadro2
        Private objEnt As Entity.Mantenimiento.Reportecuadro2 = Nothing
        Private objEntCol As Entity.Mantenimiento.Reportecuadro2Col = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Mantenimiento.ReporteCuadro2

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Reportecuadro2.Listar(sqlCon, "lst", "lst_mant",
            Codigo, "", "", -1, -1)

            objEnt = New Entity.Mantenimiento.ReporteCuadro2
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("rpt_cua_2_id").ToString
                            .GenericoID = sqlDr("del_gen_id").ToString
                            .Generico = sqlDr("del_gen_nom").ToString
                            .Especifico = sqlDr("del_esp_nom").ToString
                            .Cuadro = sqlDr("rpt_cua").ToString
                            .Orden = sqlDr("rpt_ord").ToString
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
        Public Function Listar(ByVal Codigo As Integer,
        ByVal Generico As String, ByVal Especifico As String, ByVal Cuadro As Integer) As Entity.Mantenimiento.ReporteCuadro2Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Reportecuadro2.Listar(sqlCon, "lst", "lst_grilla",
            Codigo, Generico, Especifico, Cuadro, -1)

            Try
                objEntCol = New Entity.Mantenimiento.ReporteCuadro2Col
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.ReporteCuadro2
                        With objEnt
                            .Codigo = sqlDr("rpt_cua_2_id").ToString
                            .GenericoID = sqlDr("del_gen_id").ToString
                            .Generico = sqlDr("del_gen_nom").ToString
                            .Especifico = sqlDr("del_esp_nom").ToString.ToUpper
                            .Cuadro = sqlDr("rpt_cua").ToString
                            .Orden = sqlDr("rpt_ord").ToString
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
        Public Function Grabar(ByVal Codigo As Integer, ByVal DelitoIDString As String) As Integer

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

            intValue = Data.Mantenimiento.Reportecuadro2.Grabar(strAccion, strOpcion, Codigo, _
            "", "", "", "", DelitoIDString, -1, -1, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
      
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Mantenimiento.Reportecuadro2.Eliminar(strAccion, strOpcion, Codigo, Usuario)
            Return intValue
        End Function
#End Region
    End Class
End Namespace