Imports System.Data
Imports System.Data.SqlClient

Namespace Visita
    Public Class Tipo
        Private objEnt As Entity.Visita.Tipo = Nothing
        Private objEntCol As Entity.Visita.Tipos = Nothing

        Public Function Listar() As Entity.Visita.Tipos

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Tipo.Listar(sqlCon, "lst", "", -1, "", 0, -1, -1)

            objEntCol = New Entity.Visita.Tipos

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Tipo
                        With objEnt
                            .Codigo = sqlDr("tip_id").ToString
                            .Nombre = sqlDr("tip_nom").ToString
                            .Estado = sqlDr("tip_est").ToString
                            '.RequiereCalendario = sqlDr("tip_cal").ToString
                            '.RequiereInterno = sqlDr("tip_int").ToString
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

        Public Function ListarRegimenOrdinario() As Entity.Visita.Tipos

            Dim objEntColLista As New Entity.Visita.Tipos
            objEntColLista = Listar()

            objEntCol = New Entity.Visita.Tipos

            For Each obj As Entity.Visita.Tipo In objEntColLista

                Select Case obj.Codigo
                    Case 2, 10, 11, 12 'ordinario, extraordinario, MENORES DE EDAD, abogado, 
                        objEntCol.Add(obj)
                End Select

            Next

            Return objEntCol
        End Function

        Public Function ListarRegimenEspecial() As Entity.Visita.Tipos

            Dim objEntColLista As New Entity.Visita.Tipos
            objEntColLista = Listar()

            objEntCol = New Entity.Visita.Tipos

            For Each obj As Entity.Visita.Tipo In objEntColLista

                If obj.Codigo <> 2 Then 'ordinario
                    objEntCol.Add(obj)
                End If
            Next

            Return objEntCol
        End Function

    End Class
End Namespace

