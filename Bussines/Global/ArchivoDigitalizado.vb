Imports System.Data.SqlClient

Namespace Globall
    Public Class ArchivoDigitalizado
        Private objEnt As Entity.Globall.ArchivoDigitalizado = Nothing
        Public Function Listar(Codigo As Integer) As Entity.Globall.ArchivoDigitalizado
            Dim objEntCol As Entity.Globall.ArchivoDigitalizadoCol
            Dim tmpEnt As New Entity.Globall.ArchivoDigitalizado
            tmpEnt.Codigo = Codigo
            objEntCol = Listar(tmpEnt)
            If objEntCol.Count = 0 Then Return Nothing
            Return objEntCol.Archivodigital(0)
        End Function


        Public Function Listar(objEnt As Entity.Globall.ArchivoDigitalizado) As Entity.Globall.ArchivoDigitalizadoCol
            Dim objEntCol As Entity.Globall.ArchivoDigitalizadoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Globall.ArchivoDigitalizado.Listar(sqlCon, "lst", "lst_mant", objEnt)

            Try
                objEntCol = New Entity.Globall.ArchivoDigitalizadoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Globall.ArchivoDigitalizado
                        With objEnt
                            .Codigo = sqlDr("pk_arc_dig_id").ToString
                            .TipoArchivoDigital = sqlDr("n_arc_dig_tip_id").ToString
                            .IdRegistroForaneo = sqlDr("fk_reg_tbl_id").ToString
                            .Anio = sqlDr("n_arc_dig_anio").ToString
                            .Mes = sqlDr("n_arc_dig_mes").ToString
                            .Mac = sqlDr("c_arc_dig_pc_mac").ToString
                            .NombrePc = sqlDr("c_arc_dig_pc").ToString
                            .Ip = sqlDr("c_arc_dig_ip").ToString
                            .NombreArchivo = sqlDr("c_arc_dig_nom_fis").ToString
                            .Extension = sqlDr("c_arc_dig_ext").ToString
                            .PesoByte = sqlDr("n_arc_dig_pes").ToString
                            Try
                                .ArchivoDigitalByte = If(IsDBNull(sqlDr("b_arch_dig_byte")), Nothing, sqlDr("b_arch_dig_byte"))
                            Catch ex As Exception

                            End Try
                            .RegionId = sqlDr("_regid").ToString
                            .PenalId = sqlDr("_penid").ToString
                        End With
                        objEntCol.Add(objEnt)
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
            Return objEntCol
        End Function

        Public Function listarMant(idOdontograma As Integer) As Entity.Globall.ArchivoDigitalizado

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Globall.ArchivoDigitalizado.Listar(sqlCon, "lst", "lst_mant",
                                                                                 New Entity.Globall.ArchivoDigitalizado With {.IdRegistroForaneo = idOdontograma})

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Globall.ArchivoDigitalizado
                        With objEnt
                            .Codigo = sqlDr("pk_arc_dig_id").ToString
                            .TipoArchivoDigital = sqlDr("n_arc_dig_tip_id").ToString
                            .IdRegistroForaneo = sqlDr("fk_reg_tbl_id").ToString
                            .Anio = sqlDr("n_arc_dig_anio").ToString
                            .Mes = sqlDr("n_arc_dig_mes").ToString
                            .Mac = sqlDr("c_arc_dig_pc_mac").ToString
                            .NombrePc = sqlDr("c_arc_dig_pc").ToString
                            .Ip = sqlDr("c_arc_dig_ip").ToString
                            .NombreArchivo = sqlDr("c_arc_dig_nom_fis").ToString
                            .Extension = sqlDr("c_arc_dig_ext").ToString
                            .PesoByte = sqlDr("n_arc_dig_pes").ToString
                            Try
                                .ArchivoDigitalByte = If(IsDBNull(sqlDr("b_arch_dig_byte")), Nothing, sqlDr("b_arch_dig_byte"))
                            Catch ex As Exception

                            End Try
                            .RegionId = sqlDr("_regid").ToString
                            .PenalId = sqlDr("_penid").ToString
                        End With
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
            Return objEnt
        End Function

        Public Function Grabar(ByVal objEnt As Entity.Globall.ArchivoDigitalizado, ByRef outSMS As String) As Integer
            'If Validar(objEnt, outSMS) = True Then Return False

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            objEnt.NombreArchivo = "odo_" + objEnt.RegionId.ToString + "_" + objEnt.PenalId.ToString + "_" + objEnt.IdRegistroForaneo.ToString

            intValue = Data.Globall.ArchivoDigitalizado.Grabar(strAccion, strOpcion, objEnt)
            If intValue = -1 Then outSMS = "Error al guardar registro de odontograma"

            Return intValue
        End Function

        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Globall.ArchivoDigitalizado.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
    End Class
End Namespace