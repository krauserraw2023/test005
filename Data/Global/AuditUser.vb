Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    Public Class AuditUser
        Dim strNameProcedure As String = "UP_AuditUser"
        Public Function Listar(IdRegistro As Integer, TipoTabla As Integer, accion As String, opcion As String) As Entity.Globall.AuditUser
            '   Dim objEnt As New Entity.Registro.A
            Dim sqlDr As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Try
                Dim intValue As Integer = -1

                Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                    With sqlCmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                        .Parameters.Add(New SqlParameter("@id_registro", SqlDbType.Int)).Value = IdRegistro
                        .Parameters.Add(New SqlParameter("@id_tipo_tabla", SqlDbType.Int)).Value = TipoTabla

                        sqlCon.Open()
                        sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

                    End With
                End Using
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            End Try

            Dim objEnt As Entity.Globall.AuditUser = Nothing

            If sqlDr.HasRows Then
                While sqlDr.Read
                    objEnt = New Entity.Globall.AuditUser
                    With objEnt
                        .FechaActualiza = sqlDr("_fec_mod").ToString
                        .FechaCreacion = sqlDr("_fec_cre").ToString
                        .UsuarioActualiza = sqlDr("usu_nom_modific").ToString
                        .UsuarioCrea = sqlDr("usu_nom_crea").ToString
                    End With
                End While
            End If
          
            sqlCon.Dispose()
            sqlCon.Close()
            sqlCon = Nothing
            Return objEnt
        End Function
    End Class

End Namespace
