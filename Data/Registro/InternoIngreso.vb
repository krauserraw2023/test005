Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class Ingreso

        Private Shared strNameProcedure As String = "UP_INT_InternoIngreso"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
     ByVal InternoId As Integer, ByVal RegionId As Integer, ByVal PenalId As Integer, ByVal PenalNum As Integer, _
     ByVal IngresoFecha As Long, ByVal IngresoNro As Integer, ByVal MotivoIngresoId As Integer, ByVal IngresoDocumento As String, _
     ByVal IngresoDocumentoFecha As Long, ByVal LibertadTipoId As Integer, ByVal LibertadFecha As Long, _
     ByVal LibertadDocumento As String) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalId
                            .Parameters.Add(New SqlParameter("@Pen_num", SqlDbType.Int)).Value = PenalNum
                            .Parameters.Add(New SqlParameter("@int_ing_fec", SqlDbType.BigInt)).Value = IngresoFecha
                            .Parameters.Add(New SqlParameter("@int_ing_nro", SqlDbType.Int)).Value = IngresoNro
                            .Parameters.Add(New SqlParameter("@ing_mot_id", SqlDbType.Int)).Value = MotivoIngresoId
                            .Parameters.Add(New SqlParameter("@int_ing_doc", SqlDbType.VarChar, 100)).Value = IngresoDocumento
                            .Parameters.Add(New SqlParameter("@int_ing_doc_fec", SqlDbType.BigInt)).Value = IngresoDocumentoFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = LibertadTipoId
                            .Parameters.Add(New SqlParameter("@tip_lib_fec", SqlDbType.BigInt)).Value = LibertadFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_doc", SqlDbType.VarChar, 100)).Value = LibertadDocumento

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

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, EntIng As Entity.Registro.Ingreso) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntIng.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntIng.InternoID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntIng.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntIng.PenalID
                            .Parameters.Add(New SqlParameter("@Pen_num", SqlDbType.Int)).Value = EntIng.PenalNum
                            '.Parameters.Add(New SqlParameter("@int_ing_fec", SqlDbType.BigInt)).Value = EntIng.IngresoFecha
                            .Parameters.Add(New SqlParameter("@int_ing_nro", SqlDbType.Int)).Value = EntIng.IngresoNro
                            .Parameters.Add(New SqlParameter("@ing_mot_id", SqlDbType.Int)).Value = EntIng.MotivoIngresoID
                            .Parameters.Add(New SqlParameter("@int_ing_nro_aux", SqlDbType.Int)).Value = EntIng.IngresoNroAux
                           
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
   ByVal InternoId As Integer, _
   ByVal RegionId As Integer, _
   ByVal PenalId As Integer, _
   ByVal PenalNum As Integer, _
   ByVal IngresoFecha As Long, _
   ByVal IngresoNro As Integer, _
   ByVal MotivoIngresoId As Integer, _
   ByVal IngresoDocumento As String, _
   ByVal IngresoDocumentoFecha As Long, _
   ByVal LibertadTipoId As Integer, _
   ByVal LibertadFecha As Long, _
   ByVal LibertadDocumento As String _
   ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionId
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalId
                    .Parameters.Add(New SqlParameter("@Pen_num", SqlDbType.Int)).Value = PenalNum
                    .Parameters.Add(New SqlParameter("@int_ing_fec", SqlDbType.BigInt)).Value = IngresoFecha
                    .Parameters.Add(New SqlParameter("@int_ing_nro", SqlDbType.Int)).Value = IngresoNro
                    .Parameters.Add(New SqlParameter("@ing_mot_id", SqlDbType.Int)).Value = MotivoIngresoId
                    .Parameters.Add(New SqlParameter("@int_ing_doc", SqlDbType.VarChar, 100)).Value = IngresoDocumento
                    .Parameters.Add(New SqlParameter("@int_ing_doc_fec", SqlDbType.BigInt)).Value = IngresoDocumentoFecha
                    .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = LibertadTipoId
                    .Parameters.Add(New SqlParameter("@tip_lib_fec", SqlDbType.BigInt)).Value = LibertadFecha
                    .Parameters.Add(New SqlParameter("@tip_lib_doc", SqlDbType.VarChar, 100)).Value = LibertadDocumento
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Registro.Ingreso) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    '/*filtros*/
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                              ByVal objEnt As Entity.Registro.Ingreso) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300 'segundos
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    '/*filtros*/
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.PenalID
                    '.Parameters.Add(New SqlParameter("@per_usu_id", SqlDbType.Int)).Value = objEnt.PerfilUsuarioId 'no  deberia ir, esto se aplica a nivel de business
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.Ingreso) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            
                            .Parameters.Add(New SqlParameter("@int_ing_nro", SqlDbType.Int)).Value = objEnt.IngresoNro
                            .Parameters.Add(New SqlParameter("@int_ing_fec_isp", SqlDbType.BigInt)).Value = objEnt.FechaISP

                            .Parameters.Add(New SqlParameter("@int_ing_doc", SqlDbType.VarChar, 120)).Value = objEnt.DocumentoIngreso
                            .Parameters.Add(New SqlParameter("@int_ing_doc_fec_rcp", SqlDbType.BigInt)).Value = objEnt.DocumentoFechaRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_doc_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoIngresoFecha
                            .Parameters.Add(New SqlParameter("@ing_mot_id", SqlDbType.Int)).Value = objEnt.MotivoIngresoID
                            .Parameters.Add(New SqlParameter("@int_ing_fec", SqlDbType.BigInt)).Value = objEnt.FechaIngreso

                            .Parameters.Add(New SqlParameter("@tip_lib_doc", SqlDbType.VarChar, 100)).Value = objEnt.DocumentoLibertad
                            .Parameters.Add(New SqlParameter("@int_ing_lib_doc_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoLibertadFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = objEnt.LibertadTipoID
                            .Parameters.Add(New SqlParameter("@tip_lib_fec", SqlDbType.BigInt)).Value = objEnt.FechaLibertad
                            .Parameters.Add(New SqlParameter("@Pen_num", SqlDbType.Int)).Value = objEnt.PenalNum
                            .Parameters.Add(New SqlParameter("@int_ing_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@int_ing_hist", SqlDbType.Bit)).Value = objEnt.Historico
                            .Parameters.Add(New SqlParameter("@int_ing_est", SqlDbType.Bit)).Value = objEnt.Estado

                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEnt.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.Ingreso, ByRef outSMS As String) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_nro", SqlDbType.Int)).Value = objEnt.IngresoNro
                            .Parameters.Add(New SqlParameter("@int_ing_fec_isp", SqlDbType.BigInt)).Value = objEnt.FechaISP

                            .Parameters.Add(New SqlParameter("@int_ing_doc", SqlDbType.VarChar, 120)).Value = objEnt.DocumentoIngreso
                            .Parameters.Add(New SqlParameter("@int_ing_doc_fec_rcp", SqlDbType.BigInt)).Value = objEnt.DocumentoFechaRecepcion
                            .Parameters.Add(New SqlParameter("@int_ing_doc_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoIngresoFecha
                            .Parameters.Add(New SqlParameter("@fk_mov_tip_id", SqlDbType.SmallInt)).Value = objEnt.IDMovimientoTipo
                            .Parameters.Add(New SqlParameter("@ing_mot_id", SqlDbType.SmallInt)).Value = objEnt.MotivoIngresoID
                            .Parameters.Add(New SqlParameter("@int_ing_fec", SqlDbType.BigInt)).Value = objEnt.FechaIngreso

                            .Parameters.Add(New SqlParameter("@tip_lib_doc", SqlDbType.VarChar, 100)).Value = objEnt.DocumentoLibertad
                            .Parameters.Add(New SqlParameter("@int_ing_lib_doc_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoLibertadFecha
                            .Parameters.Add(New SqlParameter("@tip_lib_id", SqlDbType.Int)).Value = objEnt.LibertadTipoID
                            .Parameters.Add(New SqlParameter("@tip_lib_fec", SqlDbType.BigInt)).Value = objEnt.FechaLibertad
                            .Parameters.Add(New SqlParameter("@Pen_num", SqlDbType.Int)).Value = objEnt.PenalNum
                            .Parameters.Add(New SqlParameter("@int_ing_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@int_ing_est", SqlDbType.Bit)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId

                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEnt.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
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
                outSMS = ex.Message
                Return -1
            End Try
        End Function
#End Region

#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, EntIngreso As Entity.Registro.Ingreso) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntIngreso.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntIngreso.Codigo

                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = EntIngreso.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = EntIngreso.Audit_UsuarioCreacion
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
        
    End Class
End Namespace
