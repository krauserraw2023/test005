Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class Familiar
        Private Shared strNameProcedure As String = "UP_INT_InternoFamiliar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal FamiliarTipoID As Integer, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, _
        ByVal Nombres As String, _
        ByVal Vive As Boolean _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = FamiliarTipoID
                            .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = Nombres
                            .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = Vive

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
        ByVal FamiliarTipoID As Integer, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, _
        ByVal Nombres As String, _
        ByVal Vive As Boolean _
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = FamiliarTipoID
                    .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = Nombres
                    .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = Vive
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, EntFam As Entity.Registro.Familiar
       ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = EntFam.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntFam.InternoID
                    .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = EntFam.FamiliarTipoID
                    .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = EntFam.Nombres
                    .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = EntFam.Vive
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntFam.IngresoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, EntFam As Entity.Registro.Familiar
       ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = EntFam.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntFam.InternoID
                    .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = EntFam.FamiliarTipoID
                    .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = EntFam.Nombres
                    .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = EntFam.Vive
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntFam.IngresoID
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = EntFam.SedeRowId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = EntFam.IngresoInpeID
                    .Parameters.Add(New SqlParameter("@_Penid", SqlDbType.Int)).Value = EntFam.PenalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal FamiliarTipoID As Integer, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, _
        ByVal Nombres As String, ByVal Sexo As Integer, ByVal FechaNacimiento As Long, _
        ByVal Vive As Boolean, ByVal HijoRecluido As Boolean, _
        ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = FamiliarTipoID
                            .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = Sexo
                            .Parameters.Add(New SqlParameter("@int_fam_fec_nac", SqlDbType.BigInt)).Value = FechaNacimiento
                            .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = Vive
                            .Parameters.Add(New SqlParameter("@int_fam_hij_rec", SqlDbType.Bit)).Value = HijoRecluido

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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, EntFam As Entity.Registro.Familiar) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = EntFam.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntFam.InternoID
                            .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = EntFam.FamiliarTipoID
                            .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = EntFam.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = EntFam.Sexo
                            .Parameters.Add(New SqlParameter("@int_fam_fec_nac", SqlDbType.BigInt)).Value = EntFam.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = EntFam.Vive
                            .Parameters.Add(New SqlParameter("@int_fam_hij_rec", SqlDbType.Bit)).Value = EntFam.HijoReclucido

                            .Parameters.Add(New SqlParameter("@_Regid", SqlDbType.Int)).Value = EntFam.RegionID
                            .Parameters.Add(New SqlParameter("@_Penid", SqlDbType.Int)).Value = EntFam.PenalID

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = EntFam.Audit_UsuarioCreacion
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
        Public Shared Function Grabar2(ByVal accion As String, ByVal opcion As String, EntFam As Entity.Registro.Familiar) As Integer

            'nueva version del pope
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = EntFam.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntFam.InternoID
                            .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = EntFam.FamiliarTipoID
                            .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = EntFam.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = EntFam.Sexo
                            .Parameters.Add(New SqlParameter("@int_fam_fec_nac", SqlDbType.BigInt)).Value = EntFam.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = EntFam.Vive
                            .Parameters.Add(New SqlParameter("@int_fam_hij_rec", SqlDbType.Bit)).Value = EntFam.HijoReclucido
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntFam.IngresoID
                            .Parameters.Add(New SqlParameter("@_Regid", SqlDbType.Int)).Value = EntFam.RegionID
                            .Parameters.Add(New SqlParameter("@_Penid", SqlDbType.Int)).Value = EntFam.PenalID

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = EntFam.Audit_UsuarioCreacion
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

        'se agrego @_sed_rowid
        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, EntFam As Entity.Registro.Familiar) As Integer

            'nueva version del pope
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = EntFam.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntFam.InternoID
                            .Parameters.Add(New SqlParameter("@int_fam_tip_id", SqlDbType.Int)).Value = EntFam.FamiliarTipoID
                            .Parameters.Add(New SqlParameter("@int_fam_ape_pat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_fam_ape_mat", SqlDbType.VarChar, 50)).Value = EntFam.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_fam_nom", SqlDbType.VarChar, 50)).Value = EntFam.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = EntFam.Sexo
                            .Parameters.Add(New SqlParameter("@int_fam_fec_nac", SqlDbType.BigInt)).Value = EntFam.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@int_fam_viv", SqlDbType.Bit)).Value = EntFam.Vive
                            .Parameters.Add(New SqlParameter("@int_fam_hij_rec", SqlDbType.Bit)).Value = EntFam.HijoReclucido
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntFam.IngresoID
                            .Parameters.Add(New SqlParameter("@_Regid", SqlDbType.Int)).Value = EntFam.RegionID
                            .Parameters.Add(New SqlParameter("@_Penid", SqlDbType.Int)).Value = EntFam.PenalID
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = EntFam.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = EntFam.IngresoInpeID

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = EntFam.Audit_UsuarioCreacion
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
                            .Parameters.Add(New SqlParameter("@int_fam_id", SqlDbType.Int)).Value = Codigo

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
