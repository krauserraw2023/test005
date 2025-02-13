Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.Licencia

Namespace Registro
    Public Class InternoBanda
        Private objEnt As Entity.Registro.InternoBanda = Nothing
        Private objEntCol As Entity.Registro.InternoBandaCol = Nothing
#Region "Validar"
        Public Function ValidarInterno(ByVal objIntBanda As Entity.Registro.InternoBanda) As Boolean
            Dim intValue As Integer = -1

            If objIntBanda.Codigo > 0 Then 'edicion
                intValue = Data.Registro.InternoBanda.ListarOutput("lst", "lst_validar_upd", objIntBanda.Codigo, objIntBanda.InternoID, objIntBanda.BandaID)
            Else 'nuevo
                intValue = Data.Registro.InternoBanda.ListarOutput("lst", "lst_validar_ins", objIntBanda.Codigo, objIntBanda.InternoID, objIntBanda.BandaID)
            End If

            If intValue <> 0 Then
                Return False
            End If

            Return True
        End Function
#End Region
#Region "Listar"
        Public Function Listar(ObjEntInternoBanda As Entity.Registro.InternoBanda) As Entity.Registro.InternoBandaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoBanda.Listar(sqlCon, "lst", "lst_mant", ObjEntInternoBanda)
            objEntCol = New Entity.Registro.InternoBandaCol
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoBanda
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .BandaNombre = sqlDr("ban_nom").ToString
                            .Observacion = sqlDr("int_ban_obs").ToString
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

        Public Function Listar2(ObjEntInternoBanda As Entity.Registro.InternoBanda) As Entity.Registro.InternoBandaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoBanda.Listar2(sqlCon, "lst", "lst_mant2", ObjEntInternoBanda)
            objEntCol = New Entity.Registro.InternoBandaCol
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoBanda
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("int_ing_nro").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .BandaNombre = sqlDr("ban_nom").ToString
                            .Observacion = sqlDr("int_ban_obs").ToString
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

        Function ListarInternosConSiscrico(objIntBand As Entity.Registro.InternoBanda) As Entity.Registro.InternoBandaCol

            'creado: 22/09/2015
            'por: HNRB
            'Retorna la lista de todos los interno que pertenecen a siscrico

            Dim listIntBand As New Entity.Registro.InternoBandaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoBanda.Listar(sqlCon, "lst", "lst_interno_con_siscrico", objIntBand)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoBanda
                        With objEnt
                            .CodigoInterno = sqlDr("int_cod_rp").ToString
                            .InternoID = sqlDr("int_id").ToString
                        End With
                        listIntBand.Add(objEnt)
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
            Return listIntBand
        End Function

        Public Function Listar_Grilla_LM(ObjEntInternoBanda As Entity.Registro.InternoBanda, TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.Registro.InternoBandaCol
            Dim opc As String = ""
            opc = "lst_grilla_LM"

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoBanda.Listar_LM(sqlCon, "lst", opc, ObjEntInternoBanda)
            objEntCol = New Entity.Registro.InternoBandaCol
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoBanda
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoNro = sqlDr("c_num_ing").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .BandaNombre = sqlDr("ban_nom").ToString
                            .Observacion = sqlDr("int_ban_obs").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                            .IngresoInpeNro = sqlDr("ing_inpe_nro").ToString
                            .PenalID = sqlDr("_penId").ToString
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

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.InternoBanda
            Dim entCol As New Entity.Registro.InternoBandaCol
            Dim ent As New Entity.Registro.InternoBanda
            ent.Codigo = Codigo

            entCol = Listar_LM(ent)

            If entCol.Count = 0 Then Return Nothing

            Return entCol.InternoBanda(0)
        End Function
        Public Function Listar_LM(ObjEntInternoBanda As Entity.Registro.InternoBanda) As Entity.Registro.InternoBandaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoBanda.Listar_LM(sqlCon, "lst", "lst_mant_LM", ObjEntInternoBanda)
            objEntCol = New Entity.Registro.InternoBandaCol
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoBanda
                        With objEnt
                            .Codigo = sqlDr("int_ban_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .BandaID = sqlDr("ban_id").ToString
                            .Observacion = sqlDr("int_ban_obs").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeID = sqlDr("fk_ing_inp_id").ToString
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
#End Region
#Region "Grabar"
        Public Function Grabar_LM(ByVal objIntBanda As Entity.Registro.InternoBanda) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntBanda.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            intValue = Data.Registro.InternoBanda.Grabar_LM(strAccion, strOpcion, objIntBanda)

            Return intValue
        End Function

        Public Function Grabar(ByVal objIntBanda As Entity.Registro.InternoBanda) As Integer

            'If ValidarInterno(objIntBanda) = False Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            '       "El interno ya pertenece a esta banda")
            '    Return -1
            'End If

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntBanda.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoBanda.Grabar(strAccion, strOpcion, objIntBanda)

            Return intValue
        End Function
        Public Function Grabar2(ByVal objIntBanda As Entity.Registro.InternoBanda) As Integer

            'If ValidarInterno(objIntBanda) = False Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            '       "El interno ya pertenece a esta banda")
            '    Return -1
            'End If

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntBanda.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_v2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v2"
            End If

            intValue = Data.Registro.InternoBanda.Grabar2(strAccion, strOpcion, objIntBanda)

            Return intValue
        End Function
        Public Function GrabarEstado(ByVal Codigo As Integer, ByVal Estado As Integer, IdDocJudAnulacion As Integer) As Integer

            Dim objEnt As New Entity.Registro.InternoBanda
            objEnt.Codigo = Codigo
            objEnt.Estado = Estado

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado"

            intValue = Data.Registro.InternoBanda.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.InternoBanda.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
#End Region


    End Class
End Namespace
