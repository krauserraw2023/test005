Imports System.Data.SqlClient

Namespace Sistema.Seguridad
    Public Class UsuarioHuella

        Private Shared strNameProcedure As String = "UP_SEC_UsuarioHuella"

        Public Shared Function Listar(objEnt As Entity.Sistema.Seguridad.UsuarioHuella) As Entity.Sistema.Seguridad.UsuarioHuellaCol
            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim col As New Entity.Sistema.Seguridad.UsuarioHuellaCol
                Try
                    sqlCon.Open()
                    Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)

                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "lst"
                    sqlCmd.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = "lst_mant"
                    sqlCmd.Parameters.Add(New SqlParameter("@pk_usuario_huella_id", SqlDbType.Int)).Value = objEnt.Codigo
                    sqlCmd.Parameters.Add(New SqlParameter("@fk_usuario_id", SqlDbType.Int)).Value = objEnt.UsuarioId

                    Using sqlDr As SqlDataReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If sqlDr.HasRows Then
                            While sqlDr.Read
                                objEnt = New Entity.Sistema.Seguridad.UsuarioHuella
                                With objEnt
                                    .Codigo = Integer.Parse(sqlDr("pk_usuario_huella_id").ToString)
                                    .UsuarioId = sqlDr("fk_usuario_id").ToString

                                    .Der_TipoDedoId = sqlDr("der_tip_dedo_id").ToString
                                    .Der_TemplateAnsi = If(IsDBNull(sqlDr("der_template_ansi")), Nothing, sqlDr("der_template_ansi"))
                                    .Der_Wsq = If(IsDBNull(sqlDr("der_wsq")), Nothing, sqlDr("der_wsq"))
                                    .Der_Wsq_alto = sqlDr("der_wsq_alto").ToString
                                    .Der_Wsq_ancho = sqlDr("der_wsq_ancho").ToString
                                    .Der_CalidadHuella = sqlDr("der_calidad_huella").ToString
                                    .Der_DispBiometricoId = sqlDr("der_tipo_dispo_id").ToString
                                    .Izq_TipoDedoId = sqlDr("izq_tip_dedo_id").ToString
                                    .Izq_TemplateAnsi = If(IsDBNull(sqlDr("izq_template_ansi")), Nothing, sqlDr("izq_template_ansi"))
                                    .Izq_Wsq = If(IsDBNull(sqlDr("izq_wsq")), Nothing, sqlDr("izq_wsq"))
                                    .Izq_Wsq_alto = sqlDr("izq_wsq_alto").ToString
                                    .Izq_Wsq_ancho = sqlDr("izq_wsq_ancho").ToString
                                    .Izq_CalidadHuella = sqlDr("izq_calidad_huella").ToString
                                    .Izq_DispBiometricoId = sqlDr("izq_tipo_dispo_id").ToString
                                End With
                                col.Add(objEnt)
                            End While
                        End If
                    End Using
                Catch ex As SqlException
                    Throw New Exception(ex.Message)
                End Try
                Return col
            End Using
        End Function

        Public Shared Function Listarxxxxxxx(objEnt As Entity.Sistema.Seguridad.UsuarioHuella) As Entity.Sistema.Seguridad.UsuarioHuellaCol
            Dim col As New Entity.Sistema.Seguridad.UsuarioHuellaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                sqlCmd.CommandType = CommandType.StoredProcedure

                sqlCmd.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "lst"
                sqlCmd.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = "lst_mant"
                sqlCmd.Parameters.Add(New SqlParameter("@pk_usuario_huella_id", SqlDbType.Int)).Value = objEnt.Codigo
                sqlCmd.Parameters.Add(New SqlParameter("@fk_usuario_id", SqlDbType.Int)).Value = objEnt.UsuarioId


                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException
                Throw New Exception(ex.Message)
            Finally

            End Try

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Sistema.Seguridad.UsuarioHuella

                        With objEnt
                            .Codigo = Integer.Parse(sqlDr("pk_usuario_huella_id").ToString)
                            .UsuarioId = sqlDr("fk_usuario_id").ToString

                            .Der_TipoDedoId = sqlDr("der_tip_dedo_id").ToString
                            .Der_TemplateAnsi = If(IsDBNull(sqlDr("der_template_ansi")), Nothing, sqlDr("der_template_ansi"))
                            .Der_Wsq = If(IsDBNull(sqlDr("der_wsq")), Nothing, sqlDr("der_wsq"))
                            .Der_Wsq_alto = sqlDr("der_wsq_alto").ToString
                            .Der_Wsq_ancho = sqlDr("der_wsq_ancho").ToString
                            .Der_CalidadHuella = sqlDr("der_calidad_huella").ToString
                            .Der_DispBiometricoId = sqlDr("der_tipo_dispo_id").ToString
                            .Izq_TipoDedoId = sqlDr("izq_tip_dedo_id").ToString
                            .Izq_TemplateAnsi = If(IsDBNull(sqlDr("izq_template_ansi")), Nothing, sqlDr("izq_template_ansi"))
                            .Izq_Wsq = If(IsDBNull(sqlDr("izq_wsq")), Nothing, sqlDr("izq_wsq"))
                            .Izq_Wsq_alto = sqlDr("izq_wsq_alto").ToString
                            .Izq_Wsq_ancho = sqlDr("izq_wsq_ancho").ToString
                            .Izq_CalidadHuella = sqlDr("izq_calidad_huella").ToString
                            .Izq_DispBiometricoId = sqlDr("izq_tipo_dispo_id").ToString

                        End With

                        col.Add(objEnt)
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

            Return col

        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Sistema.Seguridad.UsuarioHuella) As Integer

            Dim value As Integer = -1

            Try
                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)

                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 250)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_usuario_huella_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_usuario_id", SqlDbType.Int)).Value = objEnt.UsuarioId
                    .Parameters.Add(New SqlParameter("@der_tip_dedo_id", SqlDbType.Int)).Value = objEnt.Der_TipoDedoId
                    .Parameters.Add(New SqlParameter("@der_template_ansi", SqlDbType.VarBinary, 1500)).Value = objEnt.Der_TemplateAnsi
                    .Parameters.Add(New SqlParameter("@der_wsq", SqlDbType.VarBinary, 0)).Value = objEnt.Der_Wsq
                    .Parameters.Add(New SqlParameter("@der_wsq_alto", SqlDbType.Int)).Value = objEnt.Der_Wsq_alto
                    .Parameters.Add(New SqlParameter("@der_wsq_ancho", SqlDbType.Int)).Value = objEnt.Der_Wsq_ancho
                    .Parameters.Add(New SqlParameter("@der_calidad_huella", SqlDbType.Int)).Value = objEnt.Der_CalidadHuella
                    .Parameters.Add(New SqlParameter("@der_tipo_dispo_id", SqlDbType.Int)).Value = objEnt.Der_DispBiometricoId
                    .Parameters.Add(New SqlParameter("@izq_tip_dedo_id", SqlDbType.Int)).Value = objEnt.Izq_TipoDedoId
                    .Parameters.Add(New SqlParameter("@izq_template_ansi", SqlDbType.VarBinary, 1500)).Value = objEnt.Izq_TemplateAnsi
                    .Parameters.Add(New SqlParameter("@izq_wsq", SqlDbType.VarBinary, 0)).Value = objEnt.Izq_Wsq
                    .Parameters.Add(New SqlParameter("@izq_wsq_alto", SqlDbType.Int)).Value = objEnt.Izq_Wsq_alto
                    .Parameters.Add(New SqlParameter("@izq_wsq_ancho", SqlDbType.Int)).Value = objEnt.Izq_Wsq_ancho
                    .Parameters.Add(New SqlParameter("@izq_calidad_huella", SqlDbType.Int)).Value = objEnt.Izq_CalidadHuella
                    .Parameters.Add(New SqlParameter("@izq_tipo_dispo_id", SqlDbType.Int)).Value = objEnt.Izq_DispBiometricoId
                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

                    Dim PrmINSERTO As SqlParameter = sqlCmd.Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    PrmINSERTO.Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()

                    value = PrmINSERTO.Value

                    sqlCon.Close()
                End With
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

            Return value
        End Function

    End Class

End Namespace
