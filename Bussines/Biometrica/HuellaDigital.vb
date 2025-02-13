Imports System.Data
Imports System.Data.SqlClient
Namespace Biometria
    Public Class HuellaDigital
        Private objEnt As Entity.Biometria.HuellaDigital = Nothing
        Private objEntCol As Entity.Biometria.HuellaDigitalCol = Nothing
#Region "Listar"

        Public Function Listar(Codigo As Integer, ByRef out_sms As String) As Entity.Biometria.HuellaDigital

            Dim objEntFiltro As New Entity.Biometria.HuellaDigital
            objEntFiltro.Codigo = Codigo

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.HuellaDigital.Listar(sqlCon, "lst", "lst_buscar_idhuella", objEntFiltro, out_sms)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.HuellaDigital
                        With objEnt
                            .Codigo = sqlDr("pk_hue_dig_id").ToString
                            .IDTemplateHuella = sqlDr("kf_tmp_id").ToString
                            .IDRegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString
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
        'Public Function Listar(objEntFiltro As Entity.Biometria.HuellaDigital, ByRef out_sms As String) As Entity.Biometria.HuellaDigitalCol

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim sqlDr As SqlDataReader = Data.Biometria.HuellaDigital.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro, out_sms)

        '    Try
        '        objEntCol = New Entity.Biometria.HuellaDigitalCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Biometria.HuellaDigital
        '                With objEnt
        '                    .Codigo = sqlDr("pk_hue_dig_id").ToString
        '                    .IDTemplateHuella = sqlDr("kf_tmp_id").ToString
        '                    .IDRegion = sqlDr("_RegId").ToString
        '                    .IDPenal = sqlDr("_PenId").ToString
        '                End With
        '                objEntCol.Add(objEnt)
        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing
        '        sqlCon.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try

        '    Return objEntCol

        'End Function

        Public Function BuscarIDHuella(objEntFiltro As Entity.Biometria.HuellaDigital, ByRef out_sms As String) As Integer

            Dim value As Integer = -1

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Biometria.HuellaDigital.Listar(sqlCon, "lst", "lst_buscar_idhuella", objEntFiltro, out_sms)

            Try
                objEntCol = New Entity.Biometria.HuellaDigitalCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Biometria.HuellaDigital
                        With objEnt
                            .Codigo = sqlDr("pk_hue_dig_id").ToString
                            .IDTemplateHuella = sqlDr("kf_tmp_id").ToString
                            .CalidadTemplateHuella = sqlDr("n_hue_dig_cal_ded").ToString
                            .IDRegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString

                            value = .Codigo
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

            Return value

        End Function

#End Region
#Region "Grabar"
        Public Function Grabar(objEnt As Entity.Biometria.HuellaDigital, ByRef out_sms As String) As Integer

            Dim value As Integer = -1

            Dim opcion As String = ""
            Dim accion As String = ""

            'validar el objeto entity
            If objEnt Is Nothing Then
                out_sms = "El registro de huella digital no puede ser nulo"
                Return value
            End If

            If objEnt.Codigo < 0 Then
                accion = "ins"
                opcion = "ins_mant"
            Else
                accion = "upd"
                opcion = "upd_mant"
            End If

            value = Data.Biometria.HuellaDigital.Grabar(accion, opcion, objEnt, out_sms)

            Return value

        End Function

#End Region
#Region "Eliminar"
        Public Function Eliminar(Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer

            Dim value As Integer = -1

            If Codigo < 1 Then
                out_sms = "Id del registro no válido"
                Return value
            End If

            If IdUsuario < 1 Then
                out_sms = out_sms & " Id de usuario no válido"
                Return value
            End If

            value = Data.Biometria.HuellaDigital.Eliminar("del", "del_mant", Codigo, IdUsuario, out_sms)

            Return value

        End Function
#End Region
    End Class
End Namespace