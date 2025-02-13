Imports System.Data.SqlClient

Namespace Registro.Documento
    Public Class DocumentoJudicialTipo
        Private Shared strNameProcedure As String = "UP_REG_DOC_Tipo"
        Public Shared Function Listar(intTipoLicencia As Short, intTipoTabla As Short, intPerfilUsuario As Short,
                                      Optional ByVal intCategoriaDoc As Short = 99) As Entity.Registro.Documento.DocumentoJudicialTipoCol

            Dim objEntCol As Entity.Registro.Documento.DocumentoJudicialTipoCol = Nothing
            Dim objEnt As Entity.Registro.Documento.DocumentoJudicialTipo = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "lst"
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = "lst_mant"
                    .Parameters.Add(New SqlParameter("@doc_tip_cat", SqlDbType.SmallInt)).Value = intCategoriaDoc
                    .Parameters.Add(New SqlParameter("@lic_ins_id", SqlDbType.SmallInt)).Value = intTipoLicencia 'licencia de instalacion
                    .Parameters.Add(New SqlParameter("@n_lic_tip_tbl", SqlDbType.SmallInt)).Value = intTipoTabla
                    .Parameters.Add(New SqlParameter("@fk_per_usu_id", SqlDbType.SmallInt)).Value = intPerfilUsuario
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try

            'coleccion
            Try
                objEntCol = New Entity.Registro.Documento.DocumentoJudicialTipoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.DocumentoJudicialTipo
                        With objEnt
                            .Codigo = sqlDr("doc_tip_id").ToString
                            .DocJudTipo = sqlDr("doc_tip_nom").ToString
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