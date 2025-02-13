Imports System.Data.SqlClient

Namespace General
    Public Class TipoDocumento
        Public Shared Function Codigo(ByVal CodigoString As String) As Integer
            Dim value As Integer = 0

            value = Data.General.TipoDocumento.ListarOutput("lst", "lst_tipo_documento_codigo", -1, CodigoString)

            Return value
        End Function


        Public Shared Function TipoDocString(TipDocId As Integer) As String
            Dim value As String = ""

            value = Data.General.TipoDocumento.ListarOutput("lst", "lst_tipo_documento_x_id", TipDocId)

            Return value
        End Function

        Public Function ComboTipoDoc(Optional blnTodos As Boolean = False, Optional ByVal ComboMensaje As String = "[Todos]") As Entity.General.ParametricaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.TipoDocumento.Listar(sqlCon, "lst", "lst_mant")

            Dim objEntCol As New Entity.General.ParametricaCol
            Dim objEnt As Entity.General.Parametrica = Nothing

            If blnTodos = True Then
                objEnt = New Entity.General.Parametrica
                With objEnt
                    .Codigo = -1
                    .Nombre = ComboMensaje
                End With
                objEntCol.Add(objEnt)
            End If

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.General.Parametrica
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString
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