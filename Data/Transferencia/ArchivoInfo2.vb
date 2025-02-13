Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Namespace Transferencia
    Public Class ArchivoInfo2
        Private Shared strNameProcedure As String = "UP_TRA_ArchivoTransferLocal"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Long,
        ByVal Region As Integer,
        ByVal Penal As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandTimeout = 60 * 5
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_id", SqlDbType.BigInt)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = Region
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = Penal
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_num", SqlDbType.Int)).Value = ArchivoNumero
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_nom", SqlDbType.VarChar, 250)).Value = ArchivoNombre
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_fec", SqlDbType.BigInt)).Value = ArchivoFecha
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_hor", SqlDbType.VarChar, 20)).Value = ArchivoHora
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_ver_app", SqlDbType.Int)).Value = VerApp
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_ver_bd", SqlDbType.Int)).Value = VerBD
                    '            .Parameters.Add(New SqlParameter("@tra_arc_inf_lic_id", SqlDbType.Int)).Value = Licencia
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Class TRA_ArchivoTransfer
            Private Shared strNameProcedure As String = "UP_TRA_ArchivoTransfer"
            Public Shared Function Listar(strCNBD As String, ByVal accion As String, ByVal opcion As String,
                                          intCodigo As Integer, intIDRegion As Integer, intIDPenal As Integer,
                                          intAnioDirectorio As Integer, inrMesDirectorio As Integer,
                                          ByRef strMensajeOut As String) As DataSet

                Dim sqlCon As SqlConnection = Nothing
                Try
                    sqlCon = New SqlConnection(strCNBD)
                Catch ex As Exception
                    strMensajeOut = ex.Message.ToString
                    Return Nothing
                End Try

                Dim ds As DataSet = New DataSet
                Dim myComm As SqlClient.SqlDataAdapter = Nothing
                Try
                    sqlCon.Open()
                    Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                    With sqlCmd
                        .CommandTimeout = 60 * 5
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = intCodigo
                        .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = intIDRegion
                        .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = intIDPenal
                        .Parameters.Add(New SqlParameter("@tra_anio_dir", SqlDbType.Int)).Value = intAnioDirectorio
                        .Parameters.Add(New SqlParameter("@tra_mes_dir", SqlDbType.Int)).Value = inrMesDirectorio

                    End With
                    myComm = New SqlClient.SqlDataAdapter(sqlCmd)
                    myComm.Fill(ds, "Lista")
                    sqlCon.Close()
                Catch ex As SqlException
                    Throw New Exception(ex.Message)
                End Try
                Return ds

            End Function

            Public Shared Function Grabar(strCNBD As String, ByVal accion As String, ByVal opcion As String,
                                      intCodigo As Integer, strArchivoNombre As String, ByRef strMensajeOut As String) As Integer
                Try
                    Dim value As Integer = -1
                    Using sqlCon As SqlConnection = New SqlConnection(strCNBD)
                        Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                            With sqlCmd
                                .CommandTimeout = 60 * 5
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                                .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                                .Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = intCodigo
                                .Parameters.Add(New SqlParameter("@tra_arc_nom", SqlDbType.VarChar, 100)).Value = strArchivoNombre

                                .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

                                .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
                                .Parameters("@variable_out").Direction = ParameterDirection.Output
                                sqlCon.Open()
                                .ExecuteNonQuery()
                                value = .Parameters("@variable_out").Value
                                Return value
                            End With
                        End Using
                    End Using
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                    strMensajeOut = ex.Message.ToString
                    Return -1
                End Try
            End Function

            Public Shared Function Eliminar(strCNBD_Monitoreo As String, ByVal accion As String, ByVal opcion As String,
                                        ByVal intCodigo As Integer, ByVal strNombreArchivo As String, intGrupoPaquete As Short,
                                        ByRef strMensajeOut As String) As Integer
                Try
                    Dim value As Integer = -1
                    Using sqlCon As SqlConnection = New SqlConnection(strCNBD_Monitoreo)
                        Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                            With sqlCmd
                                .CommandTimeout = 60 * 5
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                                .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                                .Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = intCodigo
                                .Parameters.Add(New SqlParameter("@tra_arc_nom", SqlDbType.VarChar, 100)).Value = strNombreArchivo
                                .Parameters.Add(New SqlParameter("@tra_grp_paq", SqlDbType.SmallInt)).Value = intGrupoPaquete

                                .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

                                .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                                .Parameters("@variable_out").Direction = ParameterDirection.Output
                                sqlCon.Open()
                                .ExecuteNonQuery()
                                value = .Parameters("@variable_out").Value
                                Return value
                            End With
                        End Using
                    End Using
                Catch ex As Exception
                    'Throw New Exception(ex.Message)
                    strMensajeOut = ex.Message.ToString
                    Return -1
                End Try
            End Function
        End Class



    End Class
End Namespace