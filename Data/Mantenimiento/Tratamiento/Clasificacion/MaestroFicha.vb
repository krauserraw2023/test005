Imports System.Data
Imports System.Data.SqlClient
Namespace Clasificacion
    Public Class MaestroFicha
        Private Shared strNameProcedure As String = "pa_tra_asi_mae_ficha"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entFicha As Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE) As SqlDataReader
            Dim colFich As New Entity.Registro.Carceleta.Clasificacion.MaestroFichaCol_BE
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_fic_id", SqlDbType.Int)).Value = entFicha.Codigo
                    .Parameters.Add(New SqlParameter("@fk_amb_cla_id", SqlDbType.Int)).Value = entFicha.AmbitoClasificacionId
                    .Parameters.Add(New SqlParameter("@c_fic_nom", SqlDbType.VarChar, 500)).Value = entFicha.Nombre

                    .Parameters.Add(New SqlParameter("@fic_tip_id", SqlDbType.Int)).Value = entFicha.TipoFicha
                    .Parameters.Add(New SqlParameter("@n_fic_des", SqlDbType.VarChar, 500)).Value = entFicha.Descripcion
                    .Parameters.Add(New SqlParameter("@n_fic_doc", SqlDbType.VarChar, 255)).Value = entFicha.DocAprobacion
                    .Parameters.Add(New SqlParameter("@n_fic_doc_fec", SqlDbType.BigInt)).Value = entFicha.DocAprobacionFecha
                    .Parameters.Add(New SqlParameter("@n_fic_est", SqlDbType.Int)).Value = entFicha.EstadoId
                    .Parameters.Add(New SqlParameter("@n_grp_sec", SqlDbType.Int)).Value = entFicha.GrupoSecuencial
                    .Parameters.Add(New SqlParameter("@n_grp_sec_str", SqlDbType.VarChar, 50)).Value = entFicha.GrupoSecuencialStr
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
        Public Shared Function Grabar(Accion As String, Opcion As String, Ent As Entity.Registro.Carceleta.Clasificacion.MaestroFicha_BE) As Integer
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = Accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = Opcion
                            .Parameters.Add(New SqlParameter("@pk_fic_id", SqlDbType.Int)).Value = Ent.Codigo
                            .Parameters.Add(New SqlParameter("@fk_amb_cla_id", SqlDbType.Int)).Value = Ent.AmbitoClasificacionId
                            .Parameters.Add(New SqlParameter("@c_fic_nom", SqlDbType.VarChar, 200)).Value = Ent.Nombre
                            .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = Ent.TipoFicha
                            .Parameters.Add(New SqlParameter("@n_fic_sec", SqlDbType.Int)).Value = Ent.Secuencia
                            .Parameters.Add(New SqlParameter("@n_fic_des", SqlDbType.VarChar, 500)).Value = Ent.Descripcion
                            .Parameters.Add(New SqlParameter("@n_fic_doc", SqlDbType.VarChar, 255)).Value = Ent.DocAprobacion

                            .Parameters.Add(New SqlParameter("@n_fic_doc_fec", SqlDbType.BigInt)).Value = Ent.DocAprobacionFecha
                            .Parameters.Add(New SqlParameter("@n_fic_est", SqlDbType.Int)).Value = Ent.EstadoId

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
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_fic_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
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
            Return intCodigo
        End Function

       

    End Class
End Namespace
