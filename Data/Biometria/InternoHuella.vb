Imports System.Data.SqlClient
Namespace Biometria
    Public Class InternoHuella

        Private Shared strNameProcedure As String = "pa_mov_interno_huella"

        Public Shared Function Listar(accion As String, opcion As String, EntIntHuell As Entity.Biometria.InternoHuella, ByRef out_sms As String) As Entity.Biometria.InternoHuellaCol
            Dim intCodigo As Integer = -1

            Dim listIH As New Entity.Biometria.InternoHuellaCol

            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_int_hue_id", SqlDbType.Int)).Value = EntIntHuell.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = EntIntHuell.InternoId

                    .Parameters.Add(New SqlParameter("@fk_hue_Men_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMenIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Anu_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigAnuIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Med_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMedIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Ind_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigIndIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Pul_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigPulIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Men_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMenDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Anu_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMenDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Med_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMedDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Ind_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigIndDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Pul_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigPulDerId

                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntIntHuell.PenalId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntIntHuell.RegionId

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    sqlDr = sqlCmd.ExecuteReader
                    intCodigo = .Parameters("@variable_out").Value
                    Try
                        out_sms = .Parameters("@str_out_sms").Value
                    Catch ex As Exception
                    End Try
                End With

                Dim ent As Entity.Biometria.InternoHuella
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ent = New Entity.Biometria.InternoHuella

                        ent.Codigo = sqlDr("pk_int_hue_id").ToString

                        ent.InternoId = sqlDr("fk_int_id").ToString

                        ent.HuellaDigMenIzqId = sqlDr("fk_hue_Men_Izq_id").ToString
                        ent.HuellaDigAnuIzqId = sqlDr("fk_hue_Anu_Izq_id").ToString
                        ent.HuellaDigMedIzqId = sqlDr("fk_hue_Med_Izq_id").ToString
                        ent.HuellaDigIndIzqId = sqlDr("fk_hue_Ind_Izq_id").ToString
                        ent.HuellaDigPulIzqId = sqlDr("fk_hue_Pul_Izq_id").ToString
                        ent.HuellaDigMenDerId = sqlDr("fk_hue_Men_Der_id").ToString
                        ent.HuellaDigAnuDerId = sqlDr("fk_hue_Anu_Der_id").ToString
                        ent.HuellaDigMedDerId = sqlDr("fk_hue_Med_Der_id").ToString
                        ent.HuellaDigIndDerId = sqlDr("fk_hue_Ind_Der_id").ToString
                        ent.HuellaDigPulDerId = sqlDr("fk_hue_Pul_Der_id").ToString

                        ent.RegionId = sqlDr("_RegId").ToString
                        ent.PenalId = sqlDr("_PenId").ToString

                        listIH.Add(ent)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return listIH
        End Function

        Public Shared Function Grabar(accion As String, opcion As String, ByVal EntIntHuell As Entity.Biometria.InternoHuella, ByRef out_sms As String) As Integer
            Dim intCodigo As Integer = -1
            Dim sqlCon As SqlConnection
            Dim sqlCmd As SqlCommand
            Try
                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_int_hue_id", SqlDbType.Int)).Value = EntIntHuell.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = EntIntHuell.InternoId

                    .Parameters.Add(New SqlParameter("@fk_hue_Men_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMenIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Anu_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigAnuIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Med_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMedIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Ind_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigIndIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Pul_Izq_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigPulIzqId
                    .Parameters.Add(New SqlParameter("@fk_hue_Men_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMenDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Anu_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigAnuDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Med_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigMedDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Ind_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigIndDerId
                    .Parameters.Add(New SqlParameter("@fk_hue_Pul_Der_id", SqlDbType.Int)).Value = EntIntHuell.HuellaDigPulDerId

                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntIntHuell.RegionId
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntIntHuell.PenalId

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value
                    Try
                        out_sms = .Parameters("@str_out_sms").Value
                    Catch ex As Exception
                    End Try

                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return intCodigo
        End Function

        Public Shared Function Eliminar(accion As String, opcion As String, Codigo As Integer, ByRef out_sms As String) As Integer
            Dim intCodigo As Integer = -1
            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_hue_id", SqlDbType.Int)).Value = Codigo

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value
                    Try
                        out_sms = .Parameters("@str_out_sms").Value
                    Catch ex As Exception
                    End Try
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return intCodigo
        End Function

    End Class
End Namespace