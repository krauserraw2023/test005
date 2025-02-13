Imports System.Data.SqlClient

Namespace Mantenimiento.General

    Public Class Dependencia
        Private objEnt As Entity.Mantenimiento.General.Dependencia = Nothing
        Private objEntCol As List(Of Entity.Mantenimiento.General.Dependencia) = Nothing
        Public Function Listar(intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia,
                               ByVal Todos As Boolean, Optional ByVal ComboMensaje As String = "[Todos]") As List(Of Entity.Mantenimiento.General.Dependencia)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.Parametrica.Listar(sqlCon, "lst", "", 35, -1)
            Try
                objEntCol = New List(Of Entity.Mantenimiento.General.Dependencia)

                If Todos = True Then
                    Dim objEnt1 As New Entity.Mantenimiento.General.Dependencia
                    objEnt1.Codigo = -1
                    objEnt1.Nombre = ComboMensaje
                    objEntCol.Add(objEnt1)
                End If

                Dim strTipoLicenciaStr As String = ""
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        strTipoLicenciaStr = ""
                        objEnt = New Entity.Mantenimiento.General.Dependencia
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString
                            .TipoLicenciaStr = sqlDr("fk_tip_lic_id_str").ToString
                            strTipoLicenciaStr = .TipoLicenciaStr
                        End With

                        If intTipoLicencia < 1 Then
                            objEntCol.Add(objEnt)
                        Else

                            If strTipoLicenciaStr.Contains(intTipoLicencia) = True Then
                                objEntCol.Add(objEnt)
                            End If

                        End If

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
    End Class

End Namespace
