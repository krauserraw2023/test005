Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoExpedientePadre
        Private objEnt As Entity.Registro.InternoExpedientePadre = Nothing        
        Private objEntCol As Entity.Registro.InternoExpedientePadreCol = Nothing        
#Region "Listar"
        Public Function Listar(entPad As Entity.Registro.InternoExpedientePadre) As Entity.Registro.InternoExpedientePadre
            'AMC81004
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoExpedientePadre.Listar(sqlCon, "lst", "lst_mant", entPad)
            objEnt = New Entity.Registro.InternoExpedientePadre
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        With objEnt
                            .Codigo = sqlDr("int_exp_pad_id").ToString
                            '.InternoID = sqlDr("int_id").ToString
                            .InternoExpedienteId = sqlDr("int_exp_id").ToString
                            .InternoExpedienteRefPadreId = sqlDr("int_ex_pad_ref_id").ToString
                            .DocJudicialID = sqlDr("doc_jud_id").ToString
                            .DocJudPadre = sqlDr("doc_jud_id2").ToString
                            .DocTipoID = sqlDr("doc_tip_id").ToString
                            ._RegionId = sqlDr("_regId").ToString
                            ._PenalId = sqlDr("_penId").ToString
                            '.DocJudCategPadre = sqlDr("doc_tip_cat").ToString
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

        Public Function Listar_LM(entPad As Entity.Registro.InternoExpedientePadre) As Entity.Registro.InternoExpedientePadre
            'AMC81004
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoExpedientePadre.Listar(sqlCon, "lst", "lst_mant_LM", entPad)
            objEnt = New Entity.Registro.InternoExpedientePadre
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        With objEnt
                            .Codigo = sqlDr("int_exp_pad_id").ToString
                            '.InternoID = sqlDr("int_id").ToString
                            .InternoExpedienteId = sqlDr("int_exp_id").ToString
                            .InternoExpedienteRefPadreId = sqlDr("int_ex_pad_ref_id").ToString
                            .DocJudPadre = sqlDr("doc_jud_id").ToString
                            .DocJudicialID = sqlDr("doc_jud_id2").ToString
                            .DocJudTipoPadre = sqlDr("doc_tip_id").ToString
                            ._RegionId = sqlDr("_regId").ToString
                            ._PenalId = sqlDr("_penId").ToString
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
        Public Function ListarGrilla(entPad As Entity.Registro.InternoExpedientePadre) As Entity.Registro.InternoExpedientePadreCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoExpedientePadre.Listar(sqlCon, "lst", "lst_mant", entPad)
            Try
                objEntCol = New Entity.Registro.InternoExpedientePadreCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoExpedientePadre
                        With objEnt
                            .Codigo = sqlDr("int_exp_pad_id").ToString
                            .InternoExpedienteId = sqlDr("int_exp_id").ToString
                            .InternoExpedienteRefPadreId = sqlDr("int_ex_pad_ref_id").ToString
                            ._RegionId = sqlDr("_regId").ToString
                            ._PenalId = sqlDr("_penId").ToString
                            .DocJudTipoPadre = sqlDr("doc_tip_id").ToString
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
        'ListarGrilla
        Public Function ListarGrilla_LM(entPad As Entity.Registro.InternoExpedientePadre) As Entity.Registro.InternoExpedientePadreCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoExpedientePadre.Listar(sqlCon, "lst", "lst_mant_LM", entPad)
            Try
                objEntCol = New Entity.Registro.InternoExpedientePadreCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoExpedientePadre
                        With objEnt
                            .Codigo = sqlDr("int_exp_pad_id").ToString
                            .InternoExpedienteId = sqlDr("int_exp_id").ToString
                            .InternoExpedienteRefPadreId = sqlDr("int_ex_pad_ref_id").ToString
                            .DocJudPadre = sqlDr("doc_jud_id").ToString
                            .DocJudicialID = sqlDr("doc_jud_id2").ToString
                            .DocJudTipoPadre = sqlDr("doc_tip_id").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            ' .IngresoID = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            ._RegionId = sqlDr("_regId").ToString
                            ._PenalId = sqlDr("_penId").ToString
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
#Region "Validar"
        Public Function ValidarExpediente(expPadr As Entity.Registro.InternoExpedientePadre) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = 0

            intValue = Data.Registro.InternoExpedientePadre.ListarOutput("lst", "val_exp_padre", expPadr)
            If intValue = 1 Then
                blnValue = False
            End If
            Return blnValue
        End Function

        Public Function ValidarExpediente_LM(expPadr As Entity.Registro.InternoExpedientePadre) As Integer

            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoExpedientePadre.ListarOutput_LM("lst", "val_exp_padre_LM", expPadr)
            Return intValue

        End Function

        Public Function ExisteExpedienteHijo(expPadr As Entity.Registro.InternoExpedientePadre) As Integer
            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoExpedientePadre.ListarOutput("lst", "val_exp_hijo", expPadr)

            Return intValue
        End Function

        Public Function DocumentoReferenciado(expPadr As Entity.Registro.InternoExpedientePadre) As Integer
            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoExpedientePadre.ListarOutput("lst", "lst_ref", expPadr)

            Return intValue
        End Function

#End Region
#Region "Grabar"
        Public Function Grabar(objIntExp As Entity.Registro.InternoExpedientePadre) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntExp.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoExpedientePadre.Grabar(strAccion, strOpcion, objIntExp)

            Return intValue
        End Function

        Public Function Grabar_LM(objIntExp As Entity.Registro.InternoExpedientePadre) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objIntExp.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoExpedientePadre.Grabar_LM(strAccion, strOpcion, objIntExp)

            Return intValue
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.InternoExpedientePadre.Eliminar(strAccion, strOpcion, Codigo,
            Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)

            Return intValue

        End Function
        Public Function Eliminar(ObjPad As Entity.Registro.InternoExpedientePadre, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_lm"
            intValue = Data.Registro.InternoExpedientePadre.Eliminar(strAccion, strOpcion, ObjPad, Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)

            Return intValue

        End Function
#End Region
    End Class
End Namespace

