Imports System.Data.SqlClient

Namespace Registro.Documento
    Public Class DocumentoJudicialSubTipo
        Private Shared strNameProcedure As String = "UP_REG_DOC_SubTipo"
        Public Shared Function Listar(ByVal Codigo As Integer, Optional TipoLicInstalacion As Integer = -1, Optional ByVal CatDoc As Integer = 99) As Entity.Registro.Documento.DocumentoJudicialSubTipoCol
            Dim objEntCol As Entity.Registro.Documento.DocumentoJudicialSubTipoCol = Nothing
            Dim objEnt As Entity.Registro.Documento.DocumentoJudicialSubTipo = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "lst"
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = "lst_mant"
                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@lic_ins_id", SqlDbType.Int)).Value = TipoLicInstalacion
                    '.Parameters.Add(New SqlParameter("@doc_tip_cat", SqlDbType.SmallInt)).Value = CatDoc

                    '.Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objBanda.BandaPenalId
                    '.Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objBanda.BandaRegionId
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Try
                objEntCol = New Entity.Registro.Documento.DocumentoJudicialSubTipoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Documento.DocumentoJudicialSubTipo
                        With objEnt
                            .Codigo = sqlDr("doc_subtip_id").ToString
                            .NombreSubTipo = sqlDr("doc_subtip_nom").ToString
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