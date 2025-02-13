Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    'ninguna
    Public Class ArchivoDigital
        Private Shared strNameProcedure As String = "UP_GLO_ArchivoDigital"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal NombreRed As String, _
        ByVal DirectorioRed As String, _
        ByVal PC As String, _
        ByVal IP As String, _
        ByVal Directorio As String, _
        ByVal NombreFisico As String, _
        ByVal Extension As String, _
        ByVal Peso As Integer, _
        ByVal FechaCreacion As Long, _
        ByVal FechaModificacion As Long, _
        ByVal FechaImportacion As Long, _
        ByVal Descripcion As String, _
        ByVal VigenciaIni As Long, _
        ByVal VigenciaFin As Long, _
        ByVal ArchivoByte As Byte() _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@arc_dig_nom_red", SqlDbType.VarChar, 255)).Value = NombreRed
                            .Parameters.Add(New SqlParameter("@arc_dig_dir_red", SqlDbType.VarChar, 255)).Value = DirectorioRed
                            .Parameters.Add(New SqlParameter("@arc_dig_pc", SqlDbType.VarChar, 50)).Value = PC
                            .Parameters.Add(New SqlParameter("@arc_dig_ip", SqlDbType.VarChar, 50)).Value = IP
                            .Parameters.Add(New SqlParameter("@arc_dig_dir", SqlDbType.VarChar, 255)).Value = Directorio
                            .Parameters.Add(New SqlParameter("@arc_dig_nom_fis", SqlDbType.VarChar, 255)).Value = NombreFisico
                            .Parameters.Add(New SqlParameter("@arc_dig_ext", SqlDbType.VarChar, 10)).Value = Extension
                            .Parameters.Add(New SqlParameter("@arc_dig_pes", SqlDbType.Int)).Value = Peso
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_cre", SqlDbType.BigInt)).Value = FechaCreacion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_mod", SqlDbType.BigInt)).Value = FechaModificacion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_imp", SqlDbType.BigInt)).Value = FechaImportacion
                            .Parameters.Add(New SqlParameter("@arc_dig_des", SqlDbType.VarChar, 1200)).Value = Descripcion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_ini", SqlDbType.BigInt)).Value = VigenciaIni
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_fin", SqlDbType.BigInt)).Value = VigenciaFin
                            .Parameters.Add(New SqlParameter("@arc_dig_img", SqlDbType.Image)).Value = ArchivoByte

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      ByVal Codigo As Integer, _
    ByVal NombreRed As String, _
    ByVal DirectorioRed As String, _
    ByVal PC As String, _
    ByVal IP As String, _
    ByVal Directorio As String, _
    ByVal NombreFisico As String, _
    ByVal Extension As String, _
    ByVal Peso As Integer, _
    ByVal FechaCreacion As Long, _
    ByVal FechaModificacion As Long, _
    ByVal FechaImportacion As Long, _
    ByVal Descripcion As String, _
    ByVal VigenciaIni As Long, _
    ByVal VigenciaFin As Long, _
    ByVal ArchivoByte As Byte() _
    ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@arc_dig_nom_red", SqlDbType.VarChar, 255)).Value = NombreRed
                    .Parameters.Add(New SqlParameter("@arc_dig_dir_red", SqlDbType.VarChar, 255)).Value = DirectorioRed
                    .Parameters.Add(New SqlParameter("@arc_dig_pc", SqlDbType.VarChar, 50)).Value = PC
                    .Parameters.Add(New SqlParameter("@arc_dig_ip", SqlDbType.VarChar, 50)).Value = IP
                    .Parameters.Add(New SqlParameter("@arc_dig_dir", SqlDbType.VarChar, 255)).Value = Directorio
                    .Parameters.Add(New SqlParameter("@arc_dig_nom_fis", SqlDbType.VarChar, 255)).Value = NombreFisico
                    .Parameters.Add(New SqlParameter("@arc_dig_ext", SqlDbType.VarChar, 10)).Value = Extension
                    .Parameters.Add(New SqlParameter("@arc_dig_pes", SqlDbType.Int)).Value = Peso
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_cre", SqlDbType.BigInt)).Value = FechaCreacion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_mod", SqlDbType.BigInt)).Value = FechaModificacion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_imp", SqlDbType.BigInt)).Value = FechaImportacion
                    .Parameters.Add(New SqlParameter("@arc_dig_des", SqlDbType.VarChar, 1200)).Value = Descripcion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_ini", SqlDbType.BigInt)).Value = VigenciaIni
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_fin", SqlDbType.BigInt)).Value = VigenciaFin
                    .Parameters.Add(New SqlParameter("@arc_dig_img", SqlDbType.Image)).Value = ArchivoByte
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_ArchivoDigital(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                     ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal NombreRed As String, _
       ByVal DirectorioRed As String, _
       ByVal PC As String, _
       ByVal IP As String, _
       ByVal Directorio As String, _
       ByVal NombreFisico As String, _
       ByVal Extension As String, _
       ByVal Peso As Integer, _
       ByVal FechaCreacion As Long, _
       ByVal FechaModificacion As Long, _
       ByVal FechaImportacion As Long, _
       ByVal Descripcion As String, _
       ByVal VigenciaIni As Long, _
       ByVal VigenciaFin As Long) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@arc_dig_nom_red", SqlDbType.VarChar, 255)).Value = NombreRed
                    .Parameters.Add(New SqlParameter("@arc_dig_dir_red", SqlDbType.VarChar, 255)).Value = DirectorioRed
                    .Parameters.Add(New SqlParameter("@arc_dig_pc", SqlDbType.VarChar, 50)).Value = PC
                    .Parameters.Add(New SqlParameter("@arc_dig_ip", SqlDbType.VarChar, 50)).Value = IP
                    .Parameters.Add(New SqlParameter("@arc_dig_dir", SqlDbType.VarChar, 255)).Value = Directorio
                    .Parameters.Add(New SqlParameter("@arc_dig_nom_fis", SqlDbType.VarChar, 255)).Value = NombreFisico
                    .Parameters.Add(New SqlParameter("@arc_dig_ext", SqlDbType.VarChar, 10)).Value = Extension
                    .Parameters.Add(New SqlParameter("@arc_dig_pes", SqlDbType.Int)).Value = Peso
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_cre", SqlDbType.BigInt)).Value = FechaCreacion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_mod", SqlDbType.BigInt)).Value = FechaModificacion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_imp", SqlDbType.BigInt)).Value = FechaImportacion
                    .Parameters.Add(New SqlParameter("@arc_dig_des", SqlDbType.VarChar, 1200)).Value = Descripcion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_ini", SqlDbType.BigInt)).Value = VigenciaIni
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_fin", SqlDbType.BigInt)).Value = VigenciaFin
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function Listar_ArchivoDigital_v2(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entArchDig As Entity.Globall.ArchivoDigital) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = entArchDig.Codigo
                    .Parameters.Add(New SqlParameter("@arc_dig_tip_img", SqlDbType.Int)).Value = entArchDig.Tipo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entArchDig.CodigoExt_id
                    .Parameters.Add(New SqlParameter("@arc_dig_anio", SqlDbType.Int)).Value = entArchDig.Anio
                    .Parameters.Add(New SqlParameter("@arc_dig_mes", SqlDbType.Int)).Value = entArchDig.Mes
                    .Parameters.Add(New SqlParameter("@arc_dig_mes_cor", SqlDbType.Int)).Value = IIf(entArchDig.MesCorrelativo = "", -1, Val(entArchDig.MesCorrelativo))
                    .Parameters.Add(New SqlParameter("@arc_dig_pc_mac", SqlDbType.VarChar, 20)).Value = entArchDig.MAC
                    .Parameters.Add(New SqlParameter("@arc_dig_pc", SqlDbType.VarChar, 50)).Value = entArchDig.PC
                    .Parameters.Add(New SqlParameter("@arc_dig_ip", SqlDbType.VarChar, 50)).Value = entArchDig.IP
                    .Parameters.Add(New SqlParameter("@arc_dig_nom_fis", SqlDbType.VarChar, 255)).Value = entArchDig.NombreFisico
                    .Parameters.Add(New SqlParameter("@arc_dig_ext", SqlDbType.VarChar, 10)).Value = entArchDig.Extension
                    .Parameters.Add(New SqlParameter("@arc_dig_pes", SqlDbType.Int)).Value = entArchDig.Peso
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_mod", SqlDbType.BigInt)).Value = entArchDig.FechaModificacion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_cre", SqlDbType.BigInt)).Value = entArchDig.FechaCreacion
                    .Parameters.Add(New SqlParameter("@arc_dig_fec_imp", SqlDbType.BigInt)).Value = entArchDig.FechaImportacion
                    .Parameters.Add(New SqlParameter("@arc_dig_pth_ser", SqlDbType.VarChar, 50)).Value = entArchDig.RutaServidor
                    .Parameters.Add(New SqlParameter("@arc_dig_sub_web", SqlDbType.Bit)).Value = entArchDig.ImagenUploadWeb
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region
        
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal IDInterno As Integer, _
        ByVal IDPenal As Integer, ByVal IDRegion As Integer, _
        ByVal NombreRed As String, _
        ByVal DirectorioRed As String, _
        ByVal PC As String, _
        ByVal IP As String, _
        ByVal Directorio As String, _
        ByVal NombreFisico As String, _
        ByVal Extension As String, _
        ByVal Peso As Integer, _
        ByVal FechaCreacion As Long, _
        ByVal FechaModificacion As Long, _
        ByVal FechaImportacion As Long, _
        ByVal Descripcion As String, _
        ByVal VigenciaIni As Long, _
        ByVal VigenciaFin As Long, _
        ByVal ArchivoByte As Byte(), ByVal Tipo As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = Codigo                            
                            .Parameters.Add(New SqlParameter("@arc_dig_pc", SqlDbType.VarChar, 20)).Value = PC
                            .Parameters.Add(New SqlParameter("@arc_dig_ip", SqlDbType.VarChar, 20)).Value = IP
                            .Parameters.Add(New SqlParameter("@arc_dig_dir", SqlDbType.VarChar, 255)).Value = Directorio
                            .Parameters.Add(New SqlParameter("@arc_dig_nom_fis", SqlDbType.VarChar, 255)).Value = NombreFisico
                            .Parameters.Add(New SqlParameter("@arc_dig_ext", SqlDbType.VarChar, 10)).Value = Extension
                            .Parameters.Add(New SqlParameter("@arc_dig_pes", SqlDbType.Int)).Value = Peso
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_cre", SqlDbType.BigInt)).Value = FechaCreacion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_mod", SqlDbType.BigInt)).Value = FechaModificacion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_imp", SqlDbType.BigInt)).Value = FechaImportacion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_ini", SqlDbType.BigInt)).Value = VigenciaIni
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_vig_fin", SqlDbType.BigInt)).Value = VigenciaFin                            
                            .Parameters.Add(New SqlParameter("@arc_dig_tip_img", SqlDbType.SmallInt)).Value = Tipo

                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = IDInterno
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = IDPenal
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = IDRegion

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Legolas.Configuration.Aplication.FechayHora.FechaLong
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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objDig As Entity.Globall.ArchivoDigital) As Integer

            '16-12-2014
            'VERSION2
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = objDig.Codigo
                            .Parameters.Add(New SqlParameter("@arc_dig_anio", SqlDbType.VarChar, 50)).Value = objDig.Anio
                            .Parameters.Add(New SqlParameter("@arc_dig_mes", SqlDbType.VarChar, 50)).Value = objDig.Mes
                            .Parameters.Add(New SqlParameter("@arc_dig_mes_cor", SqlDbType.VarChar, 100)).Value = objDig.MesCorrelativo
                            .Parameters.Add(New SqlParameter("@arc_dig_pc_mac", SqlDbType.VarChar, 50)).Value = objDig.MAC
                            .Parameters.Add(New SqlParameter("@arc_dig_pc", SqlDbType.VarChar, 50)).Value = objDig.PC
                            .Parameters.Add(New SqlParameter("@arc_dig_ip", SqlDbType.VarChar, 50)).Value = objDig.IP
                            .Parameters.Add(New SqlParameter("@arc_dig_dir", SqlDbType.VarChar, 255)).Value = objDig.Directorio
                            .Parameters.Add(New SqlParameter("@arc_dig_nom_fis", SqlDbType.VarChar, 255)).Value = objDig.NombreFisico
                            .Parameters.Add(New SqlParameter("@arc_dig_ext", SqlDbType.VarChar, 10)).Value = objDig.Extension
                            .Parameters.Add(New SqlParameter("@arc_dig_pes", SqlDbType.Int)).Value = objDig.Peso
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_cre", SqlDbType.BigInt)).Value = objDig.FechaCreacion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_mod", SqlDbType.BigInt)).Value = objDig.FechaModificacion
                            .Parameters.Add(New SqlParameter("@arc_dig_fec_imp", SqlDbType.BigInt)).Value = objDig.FechaImportacion

                            .Parameters.Add(New SqlParameter("@arc_dig_tip_img", SqlDbType.Int)).Value = objDig.Tipo

                            .Parameters.Add(New SqlParameter("@arc_dig_pth_ser", SqlDbType.VarChar, 50)).Value = objDig.RutaServidor
                            .Parameters.Add(New SqlParameter("@arc_dig_sub_web", SqlDbType.Bit)).Value = objDig.ImagenUploadWeb

                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objDig.CodigoExt_id
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objDig.Penal
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objDig.Region
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
                Throw New Exception(ex.ToString)
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
                            .Parameters.Add(New SqlParameter("@arc_dig_id", SqlDbType.Int)).Value = Codigo

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