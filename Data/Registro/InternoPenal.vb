Imports System.Data.SqlClient

Namespace Registro
    Public Class InternoPenal
        Private Shared strNameProcedure As String = "usp_reg_mov_internopenal"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.InternoPenal) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_int_id_pen", SqlDbType.Int)).Value = objEnt.IDInternoPenal
                            .Parameters.Add(New SqlParameter("@fk_reg_id", SqlDbType.Int)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@fk_pen_id", SqlDbType.Int)).Value = objEnt.IDPenal

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.InternoPenal) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_int_pen_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id_sed", SqlDbType.Int)).Value = objEnt.IDInternoSede
                            .Parameters.Add(New SqlParameter("@fk_int_id_pen", SqlDbType.Int)).Value = objEnt.IDInternoPenal
                            .Parameters.Add(New SqlParameter("@fk_reg_id", SqlDbType.Int)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@fk_pen_id", SqlDbType.Int)).Value = objEnt.IDPenal
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.Int)).Value = objEnt.Estado

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
    End Class

End Namespace
