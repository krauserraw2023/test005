﻿Imports System.Data.SqlClient

Namespace Registro
    Public Class InternoDomicilio
        Private Shared strNameProcedure As String = "pa_int_mov_interno_domicilio"
        Public Shared Function Listar(sqlCon As SqlConnection, accion As String, opcion As String, objEnt As Entity.Registro.InternoDomicilio) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 180
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_dom_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(sqlCon As SqlConnection, accion As String, opcion As String, objEnt As Entity.Registro.InternoDomicilio) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 180
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_dom_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.InternoDomicilio) As Integer
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_dom_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId

                            .Parameters.Add(New SqlParameter("@fk_dep_id", SqlDbType.Int)).Value = objEnt.DepartamentoId
                            .Parameters.Add(New SqlParameter("@fk_pro_id", SqlDbType.Int)).Value = objEnt.ProvinciaId
                            .Parameters.Add(New SqlParameter("@fk_dis_id", SqlDbType.Int)).Value = objEnt.DistritoId

                            .Parameters.Add(New SqlParameter("@c_lug_ref", SqlDbType.VarChar, 150)).Value = objEnt.LugarReferencial
                            .Parameters.Add(New SqlParameter("@c_dir_nom", SqlDbType.VarChar, 200)).Value = objEnt.Direccion
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
                Return -1
            End Try
            Return intCodigo
        End Function

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.InternoDomicilio) As Integer
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_dom_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId

                            .Parameters.Add(New SqlParameter("@fk_dep_id", SqlDbType.Int)).Value = objEnt.DepartamentoId
                            .Parameters.Add(New SqlParameter("@fk_pro_id", SqlDbType.Int)).Value = objEnt.ProvinciaId
                            .Parameters.Add(New SqlParameter("@fk_dis_id", SqlDbType.Int)).Value = objEnt.DistritoId

                            .Parameters.Add(New SqlParameter("@c_lug_ref", SqlDbType.VarChar, 150)).Value = objEnt.LugarReferencial
                            .Parameters.Add(New SqlParameter("@c_dir_nom", SqlDbType.VarChar, 200)).Value = objEnt.Direccion
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
                Return -1
            End Try
            Return intCodigo
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_dom_id", SqlDbType.Int)).Value = Codigo
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