Imports System.Data
Imports System.Data.SqlClient
Imports Data.Registro.Carceleta.Clasificacion.InternoClasificacion
Namespace Clasificacion.InternoClasificacion
    Public Class InternoDelito_BL
        Private objEnt As Entity.Clasificacion.InternoClasificacion.Delito = Nothing
        Private objEntCol As Entity.Clasificacion.InternoClasificacion.DelitoCol = Nothing
#Region "Listar"
        'Public Function Listar(ByVal Codigo As Integer) As Entity.Clasificacion.InternoClasificacion.Delito

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar(sqlCon, "lst", "lst_mant", _
        '    Codigo, -1, -1, -1, -1, -1)
        '    objEnt = New Entity.Clasificacion.InternoClasificacion.Delito
        '    Try
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                With objEnt
        '                    .Codigo = sqlDr("int_del_id").ToString
        '                    .IngresoID = sqlDr("int_ing_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .DelitoGenerico = sqlDr("int_del_gen_id").ToString
        '                    .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
        '                    .DelitoEspecificoEstado = sqlDr("del_esp_est").ToString
        '                    .Observacion = sqlDr("int_del_obs").ToString

        '                End With
        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing

        '    End Try
        '    Return objEnt
        'End Function


        'Public Function Listar2(objDelito As Entity.Registro.Delito) As Entity.Clasificacion.InternoClasificacion.DelitoCol

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim sqlDr As SqlDataReader = Data.Registro.InternoDelito.Listar(sqlCon, "lst", "lst_mant2", objDelito)

        '    Try
        '        objEntCol = New Entity.Clasificacion.InternoClasificacion.DelitoCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Clasificacion.InternoClasificacion.Delito
        '                With objEnt
        '                    .Codigo = sqlDr("int_del_id").ToString
        '                    .IngresoID = sqlDr("int_ing_id").ToString
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .DelitoGenerico = sqlDr("int_del_gen_id").ToString
        '                    .DelitoGenericoNombre = sqlDr("del_gen_nom").ToString
        '                    .DelitoEspecifico = sqlDr("int_del_esp_id").ToString
        '                    .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
        '                    .Estado = sqlDr("int_del_est").ToString
        '                    .DelitoMayorPena = sqlDr("int_del_dmp").ToString
        '                    .DelitoSentenciaMayorPena = sqlDr("int_del_sen_dmp").ToString
        '                    .ExpedienteID = sqlDr("int_exp_id").ToString
        '                    .Observacion = sqlDr("int_del_obs").ToString
        '                    .RegionID = sqlDr("_RegId").ToString
        '                    .PenalID = sqlDr("_PenId").ToString
        '                    .CreaDocJudicialId = sqlDr("crea_doc_jud_id").ToString
        '                End With
        '                objEntCol.Add(objEnt)
        '            End While
        '        End If
        '    Catch ex As Exception
        '        Dim s As String = ""
        '        s = ex.Message
        '        Throw New Exception(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing

        '    End Try
        '    Return objEntCol
        'End Function

#End Region
#Region "Validar"
        Private Function Validar(objEnt As Entity.Clasificacion.InternoClasificacion.Delito) As Boolean
            If objEnt.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Interno [Delito]")
                Return False
            End If
            If objEnt.IngresoInpeId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Ingreso [Delito]")
                Return False
            End If
            If objEnt.RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Region [Delito]")
                Return False
            End If
            If objEnt.PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Penal [Delito]")
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar_v2(ByVal objEnt As Entity.Clasificacion.InternoClasificacion.Delito) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If Validar(objEnt) = True Then
                If objEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v2"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
                intValue = InternoDelito_DA.Grabar_V2(strAccion, strOpcion, objEnt)
            Else
                Return -2
            End If
            Return intValue
        End Function


#End Region
#Region "Eliminar"
        'Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""

        '    strAccion = "del"
        '    strOpcion = "del_mant"
        '    intValue = Data.Registro.InternoDelito.Eliminar(strAccion, strOpcion, Codigo, Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)

        '    Return intValue

        'End Function
        'Public Function Eliminar2(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

        '    Return Data.Registro.InternoDelito.Eliminar("del", "del_mant_v2", Codigo, Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)

        'End Function
#End Region
    End Class
End Namespace