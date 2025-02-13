Imports System.Data.SqlClient

Namespace Registro
    Public Class InternoIdioma

        Public Function Listar(Codigo As Integer) As Entity.Registro.InternoIdioma

            If Codigo <= -1 Then Return Nothing

            Dim objEntCol As Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            Dim ent As New Entity.Registro.InternoIdioma
            ent.Codigo = Codigo
            objEntCol = Listar(ent)
            If objEntCol.Count = 0 Then
                Return Nothing
            Else
                Return objEntCol.Item(0)
            End If
        End Function

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.InternoIdioma

            If Codigo <= -1 Then Return Nothing

            Dim objEntCol As Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            Dim ent As New Entity.Registro.InternoIdioma
            ent.Codigo = Codigo
            objEntCol = Listar_LM(ent)
            If objEntCol.Count = 0 Then
                Return Nothing
            Else
                Return objEntCol.Item(0)
            End If
        End Function

        Private Function NivelDominioIdioma(NivelDominioId As Integer) As String
            Dim cad As String = ""
            Select Case NivelDominioId
                Case -1
                    cad = ""
                Case 1
                    cad = "BASICO"
                Case 2
                    cad = "INTERMEDIO"
                Case 3
                    cad = "AVANZADO"
            End Select
            Return cad
        End Function


        Public Function Listar_Grilla(ent As Entity.Registro.InternoIdioma) As Entity.Registro.InternoIdiomaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoIdioma.Listar(sqlCon, "lst", "lst_grilla", ent)
            Dim objEntCol As New Entity.Registro.InternoIdiomaCol
            Dim objEnt As Entity.Registro.InternoIdioma

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoIdioma
                        With objEnt
                            .Codigo = sqlDr("pk_int_idm_id").ToString
                            '.InternoId = sqlDr("fk_int_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .IdiomaId = sqlDr("fk_idm_id").ToString
                            .NivelDominioId = sqlDr("n_niv_dom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .IdiomaStr = sqlDr("idioma_str").ToString
                            .NivelDominioStr = NivelDominioIdioma(.NivelDominioId)
                            .NumIngreso = sqlDr("int_ing_nro").ToString
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

        Public Function Listar_Grilla_LM(ent As Entity.Registro.InternoIdioma, TipoLic As Type.Enumeracion.Licencia.enmTipoLicencia) As Entity.Registro.InternoIdiomaCol
            Dim opc As String = ""
            opc = "lst_grilla_LM"
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoIdioma.Listar_LM(sqlCon, "lst", opc, ent)
            Dim objEntCol As New Entity.Registro.InternoIdiomaCol
            Dim objEnt As Entity.Registro.InternoIdioma

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoIdioma
                        With objEnt
                            .Codigo = sqlDr("pk_int_idm_id").ToString
                            '.InternoId = sqlDr("fk_int_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .IdiomaId = sqlDr("fk_idm_id").ToString
                            .NivelDominioId = sqlDr("n_niv_dom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .IdiomaStr = sqlDr("idioma_str").ToString
                            .NivelDominioStr = NivelDominioIdioma(.NivelDominioId)
                            .NumIngreso = sqlDr("int_ing_nro").ToString
                            .IngresoNroInpe = sqlDr("ing_inp_nro").ToString
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

        Public Function Listar_LM(ent As Entity.Registro.InternoIdioma) As Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoIdioma.Listar_LM(sqlCon, "lst", "lst_mant_LM", ent)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            Dim objEnt As Entity.Registro.InternoIdioma

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoIdioma
                        With objEnt
                            .Codigo = sqlDr("pk_int_idm_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .IdiomaId = sqlDr("fk_idm_id").ToString
                            .NivelDominioId = sqlDr("n_niv_dom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .IdiomaStr = sqlDr("idioma_str").ToString
                            .NivelDominioStr = NivelDominioIdioma(.NivelDominioId)
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
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

        Public Function Listar(ent As Entity.Registro.InternoIdioma) As Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoIdioma.Listar(sqlCon, "lst", "lst_mant", ent)
            Dim objEntCol As New Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            Dim objEnt As Entity.Registro.InternoIdioma

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoIdioma
                        With objEnt
                            .Codigo = sqlDr("pk_int_idm_id").ToString
                            .IngresoId = sqlDr("fk_int_ing_id").ToString
                            .IdiomaId = sqlDr("fk_idm_id").ToString
                            .NivelDominioId = sqlDr("n_niv_dom").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .IdiomaStr = sqlDr("idioma_str").ToString
                            .NivelDominioStr = NivelDominioIdioma(.NivelDominioId)
                            .SedeRowId = sqlDr("_sed_rowid").ToString
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

        Private Function Validar(objEnt As Entity.Registro.InternoIdioma, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Boolean
            Dim sms As String = ""
            Dim tmpEnt As New Entity.Registro.InternoIdioma
            Dim tmpEntCol As New Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            If validarIngreso = True Then
                tmpEnt.IngresoId = objEnt.IngresoId
            End If
            tmpEnt.InternoId = objEnt.InternoId
            tmpEnt.IdiomaId = objEnt.IdiomaId
            tmpEnt.NivelDominioId = objEnt.NivelDominioId
            tmpEntCol = Listar(tmpEnt)

            If tmpEntCol.Count > 0 Then
                tmpEnt = tmpEntCol.Item(0)
                If objEnt.Codigo > 0 Then
                    If objEnt.IdiomaId = tmpEnt.IdiomaId And objEnt.Codigo <> tmpEnt.Codigo Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Idioma y nivel de dominio duplicado."
                    End If
                Else
                    If objEnt.IdiomaId = tmpEnt.IdiomaId Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Idioma y nivel de dominio duplicado."
                    End If
                End If
            End If

            If objEnt.IdiomaId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Idioma no especificado."

            If objEnt.Codigo = -1 Then
                If objEnt.InternoId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id del interno no especificado."
                If validarIngreso = True And objEnt.IngresoId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de ingreso no especificado."
                If objEnt.PenalId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Penal no especificado."
                If objEnt.RegionId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Región no especificado."
            End If
            If sms.Length > 2 Then
                outSMS = sms
                Return False
            Else
                Return True
            End If
        End Function

        Private Function Validar_LM(objEnt As Entity.Registro.InternoIdioma, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Boolean
            Dim sms As String = ""
            Dim tmpEnt As New Entity.Registro.InternoIdioma
            Dim tmpEntCol As New Entity.EntityCol(Of Entity.Registro.InternoIdioma)
            If validarIngreso = True Then
                tmpEnt.IngresoInpeId = objEnt.IngresoInpeId
            End If
            tmpEnt.InternoId = objEnt.InternoId
            tmpEnt.IdiomaId = objEnt.IdiomaId
            tmpEnt.NivelDominioId = objEnt.NivelDominioId
            tmpEntCol = Listar_LM(tmpEnt)

            If tmpEntCol.Count > 0 Then
                tmpEnt = tmpEntCol.Item(0)
                If objEnt.Codigo > 0 Then
                    If objEnt.IdiomaId = tmpEnt.IdiomaId And objEnt.Codigo <> tmpEnt.Codigo Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Idioma y nivel de dominio duplicado."
                    End If
                Else
                    If objEnt.IdiomaId = tmpEnt.IdiomaId Then
                        sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Idioma y nivel de dominio duplicado."
                    End If
                End If
            End If

            If objEnt.IdiomaId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Idioma no especificado."

            If objEnt.Codigo = -1 Then
                If objEnt.InternoId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id del interno no especificado."
                If validarIngreso = True And objEnt.IngresoInpeId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Id de ingreso no especificado."
                If objEnt.PenalId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Penal no especificado."
                If objEnt.RegionId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Región no especificado."
            End If
            If sms.Length > 2 Then
                outSMS = sms
                Return False
            Else
                Return True
            End If
        End Function

        Public Function Grabar(objEnt As Entity.Registro.InternoIdioma, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar(objEnt, outSMS, validarIngreso) = False Then Return -1

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoIdioma.Grabar(strAccion, strOpcion, objEnt)

            If intValue = -1 Then outSMS = "No se pudo grabar idioma de interno."

            Return intValue

        End Function

        Public Function Grabar_LM(objEnt As Entity.Registro.InternoIdioma, ByRef outSMS As String, Optional validarIngreso As Boolean = True) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar_LM(objEnt, outSMS, validarIngreso) = False Then Return -1

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            intValue = Data.Registro.InternoIdioma.Grabar_LM(strAccion, strOpcion, objEnt)

            If intValue = -1 Then outSMS = "No se pudo grabar idioma de interno."

            Return intValue

        End Function

        Public Function Eliminar(Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = "del"
            Dim strOpcion As String = "del_mant"
            intValue = Data.Registro.InternoIdioma.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
    End Class
End Namespace