Imports System.Data
Imports System.Data.SqlClient
Namespace Visita.Programacion
    Public Class Etapa
        Private objEnt As Entity.Visita.Programacion.Etapa = Nothing
        Private objEntCol As Entity.Visita.Programacion.EtapaCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Programacion.Etapa

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Visita.Programacion.Etapa
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Visita.Programacion.Etapa.Listar(sqlCon, "lst", "", objEntFiltro)
            objEnt = New Entity.Visita.Programacion.Etapa
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("etp_id").ToString
                            .Nombre = sqlDr("etp_nom").ToString
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
        Public Function Listar(ByVal objEntFiltro As Entity.Visita.Programacion.Etapa) As Entity.Visita.Programacion.EtapaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Programacion.Etapa.Listar(sqlCon, "lst", "", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.Programacion.EtapaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Programacion.Etapa
                        With objEnt
                            .Codigo = sqlDr("etp_id").ToString
                            .Nombre = sqlDr("etp_nom").ToString
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
        Public Function Grabar(ByVal objEnt As Entity.Visita.Programacion.Etapa) As Integer
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
            Value = Data.Visita.Programacion.Etapa.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.Programacion.Etapa) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.Programacion.Etapa.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace