Imports System.Data.SqlClient

Namespace Clasificacion
    Public Class CategoriaFicha
        Private Shared strNameProcedure As String = "pa_tra_asi_mae_categoria_ficha"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entFicha As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE) As SqlDataReader
            Dim colFich As New Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_cat_fic_id", SqlDbType.Int)).Value = entFicha.Codigo
                    .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = entFicha.FichaId
                    .Parameters.Add(New SqlParameter("@fk_cat_cla_id", SqlDbType.Int)).Value = entFicha.CategoriaClasificacionId
                    .Parameters.Add(New SqlParameter("@c_cat_nom", SqlDbType.VarChar, 250)).Value = entFicha.CategoriaNombre
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Grabar(Accion As String, Opcion As String, ent As Entity.Registro.Carceleta.Clasificacion.CategoriaFicha_BE) As Integer
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = Accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = Opcion
                            .Parameters.Add(New SqlParameter("@pk_cat_fic_id", SqlDbType.Int)).Value = ent.Codigo
                            .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = ent.FichaId
                            '.Parameters.Add(New SqlParameter("@c_cat_desc", SqlDbType.VarChar, 250)).Value = ent.CategoriaNombre
                            .Parameters.Add(New SqlParameter("@n_val_min", SqlDbType.Int)).Value = ent.ValorMinimo
                            .Parameters.Add(New SqlParameter("@n_val_max", SqlDbType.Int)).Value = ent.ValorMaximo
                            .Parameters.Add(New SqlParameter("@fk_cat_cla_id", SqlDbType.Int)).Value = ent.CategoriaClasificacionId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return intCodigo
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef outErr As String) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_cat_fic_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch sql As SqlException
                outErr = sql.Message
                Return -1
            Catch ex As Exception
                outErr = ex.Message
                Return -1
            End Try
        End Function
    End Class
End Namespace


