Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoFoto
        Private Shared strNameProcedure As String = "UP_INT_InternoFoto"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal EntIntFot As Entity.Registro.InternoFoto) As Integer
            'para version nueva
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = EntIntFot.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntIntFot.InternoID
                            .Parameters.Add(New SqlParameter("@int_fot_tip", SqlDbType.Int)).Value = EntIntFot.FotoTipo
                            .Parameters.Add(New SqlParameter("@int_fot_fec", SqlDbType.BigInt)).Value = EntIntFot.Fecha
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntIntFot.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntIntFot.PenalId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntIntFot.InternoIngresoId

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
        Public Shared Function ListarOutput_LM(ByVal accion As String, ByVal opcion As String, ByVal EntIntFot As Entity.Registro.InternoFoto) As Integer
            'para version nueva
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = EntIntFot.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntIntFot.InternoID
                            .Parameters.Add(New SqlParameter("@int_fot_tip", SqlDbType.Int)).Value = EntIntFot.FotoTipo
                            .Parameters.Add(New SqlParameter("@int_fot_fec", SqlDbType.BigInt)).Value = EntIntFot.Fecha
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntIntFot.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntIntFot.PenalId
                            .Parameters.Add(New SqlParameter("@int_ing_inp_id", SqlDbType.Int)).Value = EntIntFot.IngresoInpeId

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
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal FotoTipo As Integer, _
        ByVal Fecha As Long, ByVal RegionID As Integer, ByVal PenalID As Integer) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_fot_tip", SqlDbType.Int)).Value = FotoTipo
                            .Parameters.Add(New SqlParameter("@int_fot_fec", SqlDbType.BigInt)).Value = Fecha
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
     ByVal opcion As String, ByVal Codigo As Integer, ByVal InternoID As Integer, _
     ByVal FotoTipo As Integer, ByVal Fecha As Long) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_fot_tip", SqlDbType.Int)).Value = FotoTipo
                    '.Parameters.Add(New SqlParameter("@int_fot_lad", SqlDbType.Int)).Value = Perfil
                    .Parameters.Add(New SqlParameter("@int_fot_fec", SqlDbType.BigInt)).Value = Fecha
                    '.Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = ArchivoDigitalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
ent As Entity.Registro.InternoFoto) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = ent.InternoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.BigInt)).Value = ent.IngresoInpeId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
      ent As Entity.Registro.InternoFoto) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = ent.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.BigInt)).Value = ent.InternoIngresoId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region
     
#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, entIntFot As Entity.Registro.InternoFoto) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = entIntFot.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entIntFot.InternoID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = entIntFot.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = entIntFot.PenalId
                            .Parameters.Add(New SqlParameter("@int_fot_tip", SqlDbType.Int)).Value = entIntFot.FotoTipo
                            .Parameters.Add(New SqlParameter("@int_fot_per_izq", SqlDbType.Int)).Value = entIntFot.PIzquierdoID
                            .Parameters.Add(New SqlParameter("@int_fot_per_fre", SqlDbType.Int)).Value = entIntFot.PFrenteID
                            .Parameters.Add(New SqlParameter("@int_fot_per_der", SqlDbType.Int)).Value = entIntFot.PDerechoID
                            .Parameters.Add(New SqlParameter("@int_fot_fec", SqlDbType.BigInt)).Value = entIntFot.Fecha
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = entIntFot.InternoIngresoId
                            .Parameters.Add(New SqlParameter("@fot_ver_nue", SqlDbType.Int)).Value = entIntFot.FotoVersionNueva

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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, entIntFot As Entity.Registro.InternoFoto) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = entIntFot.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entIntFot.InternoID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = entIntFot.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = entIntFot.PenalId
                            .Parameters.Add(New SqlParameter("@int_fot_tip", SqlDbType.Int)).Value = entIntFot.FotoTipo
                            .Parameters.Add(New SqlParameter("@int_fot_per_izq", SqlDbType.Int)).Value = entIntFot.PIzquierdoID
                            .Parameters.Add(New SqlParameter("@int_fot_per_fre", SqlDbType.Int)).Value = entIntFot.PFrenteID
                            .Parameters.Add(New SqlParameter("@int_fot_per_der", SqlDbType.Int)).Value = entIntFot.PDerechoID
                            .Parameters.Add(New SqlParameter("@int_fot_fec", SqlDbType.BigInt)).Value = entIntFot.Fecha
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = entIntFot.InternoIngresoId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = entIntFot.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@fot_ver_nue", SqlDbType.Int)).Value = entIntFot.FotoVersionNueva

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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, ByVal RegionID As Integer, ByVal PenalID As Integer, _
        ByVal FotoTipo As Integer, _
        ByVal PerfilIzquierdo As Integer, ByVal PerfilFrente As Integer, ByVal PerfilDerecho As Integer, _
        ByVal Fecha As Long, _
        ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_fot_tip", SqlDbType.Int)).Value = FotoTipo
                            .Parameters.Add(New SqlParameter("@int_fot_per_izq", SqlDbType.Int)).Value = PerfilIzquierdo
                            .Parameters.Add(New SqlParameter("@int_fot_per_fre", SqlDbType.Int)).Value = PerfilFrente
                            .Parameters.Add(New SqlParameter("@int_fot_per_der", SqlDbType.Int)).Value = PerfilDerecho
                            .Parameters.Add(New SqlParameter("@int_fot_fec", SqlDbType.BigInt)).Value = Fecha

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
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
#End Region

#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, ByRef out_msg As String) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fot_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters.Add(New SqlParameter("@msg_out", SqlDbType.VarChar, 500))

                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            .Parameters("@msg_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            out_msg = .Parameters("@msg_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
#End Region

    End Class
End Namespace