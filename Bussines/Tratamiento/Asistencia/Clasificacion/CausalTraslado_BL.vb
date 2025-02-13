Imports Data.Tratamiento.Asistencia.Clasificacion
Imports Data.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports System.Data.SqlClient

Namespace Tratamiento.Asistencia.Clasificacion
    Public Class CausalTraslado_BL
        Public Function Listar(objEntFiltro As CausalTraslado_BE) As List(Of CausalTraslado_BE)
            Dim objEntCol As New List(Of CausalTraslado_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = CausalTraslado_DA.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New CausalTraslado_BE
                        With objEnt
                            .Codigo = sqlDr("pk_causal_traslado_id").ToString
                            .Causal = sqlDr("c_causal").ToString
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
    End Class
End Namespace