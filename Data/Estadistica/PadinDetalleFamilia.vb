Imports System.Data
Imports System.Data.SqlClient
Namespace Estadistica
    Public Class PadinDetalleFamilia
        Private Shared strNameProcedure As String = "UP_RPT_PadinDetalleFamilia"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      ByVal Codigo As Integer, _
        ByVal PadinID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, _
        ByVal PrimerApellido As String, _
        ByVal SegundoApellido As String, _
        ByVal PreNombres As String, _
        ByVal FechaNacimiento As Long, _
        ByVal SexoID As Integer, _
        ByVal SexoNombre As String) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_det_fam_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = PadinID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@pad_det_fam_pre_ape", SqlDbType.VarChar, 50)).Value = PrimerApellido
                    .Parameters.Add(New SqlParameter("@pad_det_fam_seg_ape", SqlDbType.VarChar, 50)).Value = SegundoApellido
                    .Parameters.Add(New SqlParameter("@pad_det_fam_pre_nom", SqlDbType.VarChar, 50)).Value = PreNombres
                    .Parameters.Add(New SqlParameter("@pad_det_fam_fec_nac", SqlDbType.BigInt)).Value = FechaNacimiento
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = SexoID
                    .Parameters.Add(New SqlParameter("@pad_det_fam_sex_nom", SqlDbType.VarChar, 50)).Value = SexoNombre

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal PadinID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, _
        ByVal PrimerApellido As String, _
        ByVal SegundoApellido As String, _
        ByVal PreNombres As String, _
        ByVal FechaNacimiento As Long, _
        ByVal SexoID As Integer, _
        ByVal SexoNombre As String, _
        ByVal _regid As Integer, _
        ByVal _penid As Integer, _
        ByVal _rowid As Integer, _
        ByVal _arc_nom As String, _
        ByVal _flg_trf As Integer _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_det_fam_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = PadinID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@pad_det_fam_pre_ape", SqlDbType.VarChar, 50)).Value = PrimerApellido
                            .Parameters.Add(New SqlParameter("@pad_det_fam_seg_ape", SqlDbType.VarChar, 50)).Value = SegundoApellido
                            .Parameters.Add(New SqlParameter("@pad_det_fam_pre_nom", SqlDbType.VarChar, 50)).Value = PreNombres
                            .Parameters.Add(New SqlParameter("@pad_det_fam_fec_nac", SqlDbType.BigInt)).Value = FechaNacimiento
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = SexoID
                            .Parameters.Add(New SqlParameter("@pad_det_fam_sex_nom", SqlDbType.VarChar, 50)).Value = SexoNombre
                            '.Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = _regid
                            '.Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = _penid
                            '.Parameters.Add(New SqlParameter("@_rowid", SqlDbType.Int)).Value = _rowid
                            '.Parameters.Add(New SqlParameter("@_arc_nom", SqlDbType.VarChar, 500)).Value = _arc_nom
                            '.Parameters.Add(New SqlParameter("@_flg_trf", SqlDbType.Int)).Value = _flg_trf

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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal PadinID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, _
        ByVal PrimerApellido As String, _
        ByVal SegundoApellido As String, _
        ByVal PreNombres As String, _
        ByVal FechaNacimiento As Long, _
        ByVal SexoID As Integer, _
        ByVal SexoNombre As String, ByVal Vive As Boolean, ByVal Recluido As Boolean, _
        ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_det_fam_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = PadinID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@pad_det_fam_pri_ape", SqlDbType.VarChar, 50)).Value = PrimerApellido
                            .Parameters.Add(New SqlParameter("@pad_det_fam_seg_ape", SqlDbType.VarChar, 50)).Value = SegundoApellido
                            .Parameters.Add(New SqlParameter("@pad_det_fam_pre_nom", SqlDbType.VarChar, 50)).Value = PreNombres
                            .Parameters.Add(New SqlParameter("@pad_det_fam_fec_nac", SqlDbType.BigInt)).Value = FechaNacimiento
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = SexoID
                            .Parameters.Add(New SqlParameter("@pad_det_fam_sex_nom", SqlDbType.VarChar, 50)).Value = SexoNombre

                            .Parameters.Add(New SqlParameter("@pad_det_fam_viv", SqlDbType.Bit)).Value = Vive
                            .Parameters.Add(New SqlParameter("@pad_det_fam_rec", SqlDbType.Bit)).Value = Recluido
                            '.Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = _regid
                            '.Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = _penid
                            '.Parameters.Add(New SqlParameter("@_rowid", SqlDbType.Int)).Value = _rowid
                            '.Parameters.Add(New SqlParameter("@_arc_nom", SqlDbType.VarChar, 500)).Value = _arc_nom
                            '.Parameters.Add(New SqlParameter("@_flg_trf", SqlDbType.Int)).Value = _flg_trf

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
                            .Parameters.Add(New SqlParameter("@pad_det_fam_id", SqlDbType.Int)).Value = Codigo

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