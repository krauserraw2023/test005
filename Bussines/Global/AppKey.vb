Imports System.Data
Imports System.Data.SqlClient
Namespace General
    Public Class AppKey
        Private objEnt As Entity.General.AppKey = Nothing
        Private objEntCol As Entity.General.AppKeyCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.General.AppKey

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.AppKey.Listar(sqlCon, "lst", "", Codigo, -1, "", "", 0, "")
            objEnt = New Entity.General.AppKey
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("win_app_id").ToString
                            .Modulo = sqlDr("win_app_mod").ToString
                            .Key = sqlDr("win_app_key").ToString
                            .Valor = sqlDr("win_app_val").ToString
                            .ValorIng = sqlDr("win_app_val_int").ToString
                            .Descripcion = sqlDr("win_app_des").ToString
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
        ByVal Modulo As Integer, _
        ByVal Key As String, _
        ByVal Valor As String, _
        ByVal ValorIng As Long, _
        ByVal Descripcion As String _
        ) As Entity.General.AppKeyCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.AppKey.Listar(sqlCon, "lst", "", Codigo, _
            Modulo, _
            Key, _
            Valor, _
            ValorIng, _
            Descripcion _
            )
            Try
                objEntCol = New Entity.General.AppKeyCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.General.AppKey
                        With objEnt
                            .Codigo = sqlDr("win_app_id").ToString
                            .Modulo = sqlDr("win_app_mod").ToString
                            .Key = sqlDr("win_app_key").ToString
                            .Valor = sqlDr("win_app_val").ToString
                            .ValorIng = sqlDr("win_app_val_int").ToString
                            .Descripcion = sqlDr("win_app_des").ToString
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
        ByVal Modulo As Integer, _
        ByVal Key As String, _
        ByVal Valor As String, _
        ByVal ValorIng As Long, _
        ByVal Descripcion As String, _
        ByVal Usuario As Integer) As Integer
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
            intValue = Data.General.AppKey.Grabar(strAccion, strOpcion, Codigo, _
            Modulo, _
            Key, _
            Valor, _
            ValorIng, _
            Descripcion, _
            Usuario)
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
            intValue = Data.General.AppKey.Eliminar(strAccion, strOpcion, Codigo, Usuario)
            Return intValue
        End Function
#End Region
    End Class
End Namespace