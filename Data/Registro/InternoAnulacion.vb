Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoAnulacion
        Private Shared strNameProcedure As String = "UP_INT_InternoAnulacion"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal AutoridadJudicialID As Integer, _
        ByVal SalaJudicialID As Integer, _
        ByVal DocumentoNumero As String, _
        ByVal Fecha As Long, _
        ByVal OtroCargo As String, _
        ByVal OtroNombre As String, _
        ByVal SecretarioNombre As String, _
        ByVal Observacion As String, _
        ByVal _RegId As Integer, _
        ByVal _PenId As Integer, _
        ByVal _RowId As Integer, _
        ByVal _arc_nom As String _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_anu_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = AutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = SalaJudicialID
                            .Parameters.Add(New SqlParameter("@int_anu_num", SqlDbType.VarChar, 120)).Value = DocumentoNumero
                            .Parameters.Add(New SqlParameter("@int_anu_fec", SqlDbType.BigInt)).Value = Fecha
                            .Parameters.Add(New SqlParameter("@int_anu_otr_cgo", SqlDbType.VarChar, 120)).Value = OtroCargo
                            .Parameters.Add(New SqlParameter("@int_anu_otr_nom", SqlDbType.VarChar, 120)).Value = OtroNombre
                            .Parameters.Add(New SqlParameter("@int_anu_sec_nom", SqlDbType.VarChar, 120)).Value = SecretarioNombre
                            .Parameters.Add(New SqlParameter("@int_anu_obs", SqlDbType.VarChar, 500)).Value = Observacion

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal AutoridadJudicialID As Integer, _
        ByVal SalaJudicialID As Integer, _
        ByVal DocumentoNumero As String, _
        ByVal Fecha As Long, _
        ByVal OtroCargo As String, _
        ByVal OtroNombre As String, _
        ByVal SecretarioNombre As String, _
        ByVal Observacion As String) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_anu_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = AutoridadJudicialID
                    .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = SalaJudicialID
                    .Parameters.Add(New SqlParameter("@int_anu_num", SqlDbType.VarChar, 120)).Value = DocumentoNumero
                    .Parameters.Add(New SqlParameter("@int_anu_fec", SqlDbType.BigInt)).Value = Fecha
                    .Parameters.Add(New SqlParameter("@int_anu_otr_cgo", SqlDbType.VarChar, 120)).Value = OtroCargo
                    .Parameters.Add(New SqlParameter("@int_anu_otr_nom", SqlDbType.VarChar, 120)).Value = OtroNombre
                    .Parameters.Add(New SqlParameter("@int_anu_sec_nom", SqlDbType.VarChar, 120)).Value = SecretarioNombre
                    .Parameters.Add(New SqlParameter("@int_anu_obs", SqlDbType.VarChar, 500)).Value = Observacion

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function


        Public Shared Function ListarDetalle(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
  ByVal InternoID As Integer, _
      ByVal IngresoId As Integer, _
        ByVal ExpedienteId As Integer, _
        ByVal DelitoId As Integer, _
        ByVal AgraviadoID As Integer, _
  ByVal AutoridadJudicialID As Integer, _
  ByVal SalaJudicialID As Integer, _
  ByVal DocumentoNumero As String, _
  ByVal Fecha As Long, _
  ByVal OtroCargo As String, _
  ByVal OtroNombre As String, _
  ByVal SecretarioNombre As String, _
  ByVal Observacion As String) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("up_int_internoanulaciondetalle", sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_anu_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoId
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteId
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = DelitoId
                    .Parameters.Add(New SqlParameter("@int_agr_id", SqlDbType.Int)).Value = AgraviadoID
                    '.Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = AutoridadJudicialID
                    '.Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = SalaJudicialID
                    '.Parameters.Add(New SqlParameter("@int_anu_num", SqlDbType.VarChar, 120)).Value = DocumentoNumero
                    '.Parameters.Add(New SqlParameter("@int_anu_fec", SqlDbType.BigInt)).Value = Fecha
                    '.Parameters.Add(New SqlParameter("@int_anu_otr_cgo", SqlDbType.VarChar, 120)).Value = OtroCargo
                    '.Parameters.Add(New SqlParameter("@int_anu_otr_nom", SqlDbType.VarChar, 120)).Value = OtroNombre
                    '.Parameters.Add(New SqlParameter("@int_anu_sec_nom", SqlDbType.VarChar, 120)).Value = SecretarioNombre
                    '.Parameters.Add(New SqlParameter("@int_anu_obs", SqlDbType.VarChar, 500)).Value = Observacion

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function



        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal AutoridadJudicialID As Integer, _
        ByVal SalaJudicialID As Integer, _
        ByVal DocumentoNumero As String, _
        ByVal Fecha As Long, _
        ByVal OtroCargo As String, _
        ByVal OtroNombre As String, _
        ByVal SecretarioNombre As String, _
        ByVal Observacion As String, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_anu_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@aut_jud_id", SqlDbType.Int)).Value = AutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@sal_jus_id", SqlDbType.Int)).Value = SalaJudicialID
                            .Parameters.Add(New SqlParameter("@int_anu_num", SqlDbType.VarChar, 120)).Value = DocumentoNumero
                            .Parameters.Add(New SqlParameter("@int_anu_fec", SqlDbType.BigInt)).Value = Fecha
                            .Parameters.Add(New SqlParameter("@int_anu_otr_cgo", SqlDbType.VarChar, 120)).Value = OtroCargo
                            .Parameters.Add(New SqlParameter("@int_anu_otr_nom", SqlDbType.VarChar, 120)).Value = OtroNombre
                            .Parameters.Add(New SqlParameter("@int_anu_sec_nom", SqlDbType.VarChar, 120)).Value = SecretarioNombre
                            .Parameters.Add(New SqlParameter("@int_anu_obs", SqlDbType.VarChar, 500)).Value = Observacion
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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_anu_id", SqlDbType.Int)).Value = Codigo

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
    End Class
End Namespace
