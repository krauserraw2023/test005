Imports System.Data.SqlClient

Namespace Seguridad.Paquetes
    Public Class ArchivoDigital
        Private objEnt As Entity.Seguridad.Paquetes.ArchivoDigital = Nothing

        Public Function Listar(codigo As Integer) As Entity.Seguridad.Paquetes.ArchivoDigital

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Seguridad.Paquetes.ArchivoDigital
            objEntFiltro.codigo = codigo

            Dim sqlDr As SqlDataReader = Data.Seguridad.Paquetes.ArchivoDigital.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Seguridad.Paquetes.ArchivoDigital
                        With objEnt
                            .codigo = sqlDr("pk_arc_dig_id").ToString
                            Try
                                .archivoByte = If(IsDBNull(sqlDr("b_arc_byte")), Nothing, sqlDr("b_arc_byte"))
                            Catch ex As Exception

                            End Try
                            .nombreFisico = sqlDr("c_nom_fis").ToString
                            .idRegion = sqlDr("_regid").ToString
                            .idPenal = sqlDr("_penid").ToString
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
        Public Function getFotoByte(codigo As Integer) As Byte()

            Dim value As Byte() = Nothing

            value = Listar(codigo).archivoByte

            Return value

        End Function
        Public Function Grabar(ByVal objEnt As Entity.Seguridad.Paquetes.ArchivoDigital, ByRef outSMS As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Try
                intValue = Data.Seguridad.Paquetes.ArchivoDigital.Grabar(strAccion, strOpcion, objEnt)
            Catch ex As Exception
                outSMS = ex.Message.ToString
            End Try

            Return intValue
        End Function

        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Seguridad.Paquetes.ArchivoDigital.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
    End Class
End Namespace