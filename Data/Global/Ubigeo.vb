Imports System.Data
Imports System.Data.SqlClient

Namespace General

    Public Class Ubigeo

#Region "Listar"
        Public Shared Function Listar( _
        ByVal Opcion As String, _
        ByVal Codigo As Integer, _
        ByVal Pais As Integer, _
        ByVal Departamento As Integer, _
        ByVal Provincia As Integer, _
        ByVal Distrito As Integer, _
        ByVal Nombre As String) As SqlDataReader

            Dim sqlCnn As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Nothing

            Try
                sqlCnn.Open()
                Dim sqlCmd As New SqlCommand("UP_GEN_Ubigeo", sqlCnn)
                sqlCmd.CommandType = CommandType.StoredProcedure

                With sqlCmd.Parameters
                    .Add("@accion", SqlDbType.VarChar, 3).Value = "lst"
                    .Add("@opcion", SqlDbType.VarChar, 255).Value = Opcion
                    .Add("@ubi_id", SqlDbType.Int).Value = Codigo
                    .Add("@ubi_pai_id", SqlDbType.Int).Value = Pais
                    .Add("@ubi_dep_id", SqlDbType.Int).Value = Departamento
                    .Add("@ubi_pro_id", SqlDbType.Int).Value = Provincia
                    .Add("@ubi_dis_id", SqlDbType.Int).Value = Distrito
                    .Add("@ubi_nom", SqlDbType.VarChar, 120).Value = Nombre
                End With

                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException

                Throw New Exception(ex.ToString)
            Catch ex As Exception

                Throw New Exception(ex.ToString)
            End Try

            Return sqlDr
        End Function
#End Region

    End Class

End Namespace