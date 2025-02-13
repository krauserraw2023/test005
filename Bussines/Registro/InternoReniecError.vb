Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoReniecError
        Private objEnt As Entity.Registro.Interno = Nothing
        Private objEntVal As Entity.Registro.InternoReniec = Nothing
        Private objInternoreniecError As Entity.Registro.InternoReniecError = Nothing
#Region "Listar"
        Public Function ObtenerNombreError(Codigo As Integer) As Entity.Registro.InternoReniecError
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim opcion As String = "lst_mant_rnc_error"
            Dim strValue As String = ""
            Dim sqlDr As SqlDataReader = Data.Registro.InternoReniecError.Listar(sqlCon, "lst", opcion, Codigo)
            objInternoreniecError = New Entity.Registro.InternoReniecError
            Dim entRnc As New Entity.Registro.InternoReniecError
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With entRnc 'objInternoreniecError
                            .Codigo = sqlDr("msj_err_cod").ToString
                            .Nombre = sqlDr("msj_err_des").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return entRnc
        End Function
#End Region
    End Class

End Namespace

