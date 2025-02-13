Imports System.Data.SqlClient

Namespace Registro.Integracion
    Public Class CodigoUnicoInterno
        Public Function Listar(ent As Entity.Registro.Integracion.CodigoUnicoInterno) As Entity.EntityCol(Of Entity.Registro.Integracion.CodigoUnicoInterno)
            Dim col As New Entity.EntityCol(Of Entity.Registro.Integracion.CodigoUnicoInterno)
            Dim objEnt As Entity.Registro.Integracion.CodigoUnicoInterno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Integracion.CodigoUnicoInterno.Listar(sqlCon, "lst", "ins_mant", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Integracion.CodigoUnicoInterno
                        With objEnt
                            .Codigo = sqlDr("pk_int_cod_uni_id").ToString
                            .TipoNacionalidad = sqlDr("c_tip_int").ToString
                            .CodigoSecuencialUnico = sqlDr("n_cod_sec_uni").ToString
                        End With
                        col.Add(objEnt)
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

            Return col
        End Function

        Public Function Eliminar(Codigo As Integer, ByRef outSMS As String) As Integer
            Dim intValue As Integer = -1
            
            If Codigo <= 0 Then Return -1

            intValue = Data.Registro.Integracion.CodigoUnicoInterno.Eliminar("del", "del_mant", Codigo, outSMS)
            Return intValue
        End Function

        Public Function Grabar(entCodUnicInt As Entity.Registro.Integracion.CodigoUnicoInterno) As Integer
            Dim id As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand
            Dim trs As SqlTransaction
            Dim b_error As Boolean = False

            Try
                sqlCon.Open()
                trs = sqlCon.BeginTransaction
                sqlCmd = sqlCon.CreateCommand
                sqlCmd.Transaction = trs

                id = Data.Registro.Integracion.CodigoUnicoInterno.Grabar(sqlCmd, "ins", "ins_mant", entCodUnicInt)

                If id = -1 Then
                    trs.Rollback()
                Else
                    trs.Commit()
                End If
            Catch ex As Exception
                'Try
                trs.Rollback()
                'Catch ex2 As Exception
                'End Try
            Finally
                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If
                sqlCmd = Nothing
            End Try

            Return id
        End Function

    End Class
End Namespace