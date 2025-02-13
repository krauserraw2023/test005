Option Explicit On
Imports System.Data.SqlClient
Imports System.Linq

Namespace Transferencia

    Public Class ImportarInterno

        Private Property CNBDHuellaVisita As String = ""
        Public Sub New(strCNBDHuellaVisita As String)
            Me.CNBDHuellaVisita = strCNBDHuellaVisita
        End Sub

        Public Function SedeCentral_a_Provincia(intIDInternoLocal As Integer, intIDInternoSede As Integer,
                                               intIDPenal As Integer, intIDRegion As Integer, ByRef strMensajeOut As String) As Integer

            Dim strLog As String = "RecepcionInternoTraslado/RecepcionTrasladoIntCarceleta"
            Dim value As Integer = -1

            Dim objDTS As DataSet
            Dim ws As New APPWebService.ws_pope_sede_plm_carceleta.Carceleta
            ws.Url = APPWebService.PathURL.ws_sede_plm_carceleta
            Try
                ws._test()
            Catch ex As Exception
                strMensajeOut = "El servicio " & ws.Url & " no se encuentra disponible." & vbCrLf & strMensajeOut
                Return -1
            End Try

            Try
                objDTS = ws.ListarInterno_Para_LimaProvincias(intIDInternoSede) 'cambiar el metodo x uno nuevo 
            Catch ex As Exception
                Type.LogSIP.getLog.Debug(strLog, "Error en ListarDetPaqueteEPLimMet(), " & ex.ToString)
                Legolas.Configuration.Aplication.MessageBox.MensajeError("El servicio presenta ciertos problemas de comunicación, intentelo mas tarde.")
                Return -1
            End Try

            If objDTS Is Nothing Then
                'Type.LogSIP.getLog.Debug(strLog, "Error en ListarDetPaqueteEPLimMet() retorna nulo.")
                Legolas.Configuration.Aplication.MessageBox.MensajeError("El servicio presenta ciertos problemas de comunicación, intentelo mas tarde, Objeto dataset devuelto por el servidor NULO.")
                Return -1
            End If

            Dim objDT As DataTable = objDTS.Tables("int_interno")
            If Not objDT Is Nothing Then
                value = GrabarSedeaProvincia(intIDInternoLocal, objDTS, intIDPenal, intIDRegion, strMensajeOut)
            End If

            Return value
        End Function

        Private Function GrabarSedeaProvincia(n_intId As Integer, ds As DataSet, PenalId As Integer, RegionId As Integer, ByRef outSMS As String) As Integer

            Dim strLog As String = "ImportarInterno/GrabarSedeaProvincia"
            Dim id As Integer = -1
            n_intId = GrabarInternoDatoBasico_Sede_Provincia(ds.Tables("int_interno"), PenalId, RegionId)
            If n_intId = -1 Then
                Return -1
            End If

            Dim objBssIntero As New Bussines.Registro.Interno

            '----- grabar datos complementarios
            If GrabarTemplateHuellaProv(ds.Tables("mov_template_huella"), n_intId, PenalId, RegionId, outSMS) = -1 Then
                objBssIntero.Eliminar(n_intId, "") 'si falla eliminamos el interno
                Return -1
            End If

            If GrabarWSQHuellaProv(ds.Tables("mov_huella_wsq"), ds.Tables("mov_template_huella"), n_intId, PenalId, RegionId, outSMS) = -1 Then
                objBssIntero.Eliminar(n_intId, "") 'si falla eliminamos el interno
                Return -1
            End If

            If GrabarInternoHuellaProv(ds.Tables("mov_interno_huella"), ds.Tables("mov_template_huella"), n_intId, PenalId, RegionId, outSMS) = -1 Then
                objBssIntero.Eliminar(n_intId, "") 'si falla eliminamos el interno
                Return -1
            End If

            Return n_intId

        End Function
        Private Function GrabarInternoDatoBasico_Sede_Provincia(t As DataTable, PenalId As Integer, RegionId As Integer) As Integer
            Dim bss As New Bussines.Registro.Interno

            Dim obEntInternoOrigen As New Entity.Registro.Interno
            With obEntInternoOrigen
                .CodigoRP = t.Rows(0).Item("int_cod_rp")
                .ApellidoPaterno = t.Rows(0).Item("int_ape_pat")
                .ApellidoMaterno = t.Rows(0).Item("int_ape_mat")
                .Nombres = t.Rows(0).Item("int_nom")
                .SexoID = t.Rows(0).Item("sex_id")
                .FechaNacimiento = t.Rows(0).Item("int_fec_nac")
                .NacimientoPaisID = t.Rows(0).Item("ubg_pai_id")
                .NacimientoUbigeoID = t.Rows(0).Item("ubg_id_nac")
                .NacimientoOtros = t.Rows(0).Item("ubg_nac_otro")
                .NacionalidadID = t.Rows(0).Item("nac_id")
                .TipoDocumentoID = t.Rows(0).Item("tip_doc_id")
                .NumeroDocumento = t.Rows(0).Item("int_doc_num")
                .Obs_DNI = t.Rows(0).Item("int_obs_dni")
                .DomicilioUbigeoID = t.Rows(0).Item("ubg_id_dir")
                .DomicilioDireccion = t.Rows(0).Item("int_dir_nom")
                .EstadoCivilID = t.Rows(0).Item("est_civ_id")
                .NivelAcademicoID = t.Rows(0).Item("niv_aca_id")
                .ProfesionID = t.Rows(0).Item("pro_id")
                .OcupacionID = t.Rows(0).Item("ocu_id")
                .Discapacidad = t.Rows(0).Item("int_dis_id")
                .ComunidadAndinaID = t.Rows(0).Item("int_com_id")
                .ComunidadAndinaEspID = t.Rows(0).Item("int_com_esp_id")
                .EstadoID = 0 'estado como inactivo, para que regularice sus datos del interno
                .Obs = t.Rows(0).Item("int_obs")
                .Decadactilar = t.Rows(0).Item("c_int_dec")
                .Homonimia = t.Rows(0).Item("b_int_hom")
                .CentroReclusionMenorId = t.Rows(0).Item("n_cen_men")
                .NombreClaveInterno = t.Rows(0).Item("c_int_nom_clav")
                .IdiomaNativoId = t.Rows(0).Item("fk_idm_nat_id")
                .GeneroId = t.Rows(0).Item("fk_gnro_id")
                .CentroTrabajo = t.Rows(0).Item("c_cen_trab")
                .ReligionId = t.Rows(0).Item("fk_rel_id")
                .CodigoFuerzaArmadaId = t.Rows(0).Item("fk_cod_fza_arm_id")
                .CodigoRangoId = t.Rows(0).Item("fk_cod_ran_id")
                .RegionID = RegionId
                .PenalID = PenalId
                .VersionRegistro = t.Rows(0).Item("c_ver_reg")
            End With

            Dim idInterno As Integer = -1
            Dim outSMS As String = ""
            idInterno = (New Bussines.Registro.Interno).GrabarProvincia(obEntInternoOrigen) 'cambiar a la opcion grabarprovincia
            If idInterno <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
                Return -1
            End If

            Return idInterno
        End Function
        Private Function GrabarTemplateHuellaProv(tblTemplateHuella As DataTable, n_int_id As Integer, PenalLocalId As Integer, RegionLocalId As Integer,
                                                  ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarTemplateHuella"
            If tblTemplateHuella Is Nothing OrElse tblTemplateHuella.Rows.Count = 0 Then Return 0

            Dim id As Integer = -1

            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim c_nomColPK As String = tblTemplateHuella.Rows(0).Item("key_name")

            Dim tblTablaBD As DataTable = Nothing
            c_nombTabla = "mov_template_huella" ' tblMand.Rows(0).Item("tabla")
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, 0, outSms)

            If tblTablaBD Is Nothing Then
                Return id
            End If

            Dim newRow As Dictionary(Of String, Object)

            Try
                For Each f As DataRow In tblTemplateHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblTemplateHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For
                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        'If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, RegionLocalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, PenalLocalId) : Continue For


                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        Try
                                            newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & Convert.ToBase64String(f(colDB.ColumnName)) & """)', 'varbinary(max)')")
                                        Catch ex As Exception
                                            newRow.Add(colDB.ColumnName, "null")
                                        End Try
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeHuellaInternoBD(Me.CNBDHuellaVisita, strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblTemplateHuella.AcceptChanges()
                Next

            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarWSQHuellaProv(tblWSQHuella As DataTable, tblTemplateHuella As DataTable, InternoLocalId As Integer, PenalLocalId As Integer, RegionLocalId As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarWSQHuella"
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object)


            If tblWSQHuella Is Nothing OrElse tblWSQHuella.Rows.Count = 0 Then Return 0

            Dim c_nomColPK As String = tblWSQHuella.Rows(0).Item("key_name")

            c_nombTabla = "mov_huella_wsq"
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, 0, "")

            newRow = New Dictionary(Of String, Object)()
            Try
                For Each f As DataRow In tblWSQHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblWSQHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        'If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                        'If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then newRow.Add(colDB.ColumnName, n_inpe_ing_id) : Continue For
                        'If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then newRow.Add(colDB.ColumnName, n_ingId) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "fk_tmp_id" And f.Item("fk_tmp_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_tmp_id"))
                            f.Item("fk_tmp_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, RegionLocalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, PenalLocalId) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        Try
                                            newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & Convert.ToBase64String(f(colDB.ColumnName)) & """)', 'varbinary(max)')")
                                        Catch ex As Exception
                                            newRow.Add(colDB.ColumnName, "null")
                                        End Try
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeHuellaInternoBD(Me.CNBDHuellaVisita, c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeHuellaInternoBD(Me.CNBDHuellaVisita, strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblWSQHuella.AcceptChanges()
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
        Private Function GrabarInternoHuellaProv(tblInternoHuella As DataTable, tblTemplateHuella As DataTable, n_int_id As Integer, PenalLocalId As Integer, RegionLocalId As Integer, ByRef outSms As String) As Integer
            Dim strLog As String = "Business/RecepcionInternoTraslado/GrabarInternoHuella"
            Dim id As Integer = -1
            Dim c_nombTabla As String = ""
            Dim n_ingPenId As Integer = -1
            Dim tblTablaBD As DataTable = Nothing
            Dim newRow As Dictionary(Of String, Object)


            If tblInternoHuella Is Nothing OrElse tblInternoHuella.Rows.Count = 0 Then Return 0

            Dim c_nomColPK As String = tblInternoHuella.Rows(0).Item("key_name")

            c_nombTabla = "mov_interno_huella"
            tblTablaBD = Bussines.Globall.UtilAccesoBD.LeerTablaBD_PopeBD(c_nombTabla, 0, "")

            newRow = New Dictionary(Of String, Object)()
            Try
                For Each f As DataRow In tblInternoHuella.Rows

                    newRow = New Dictionary(Of String, Object)()

                    For Each colDB As DataColumn In tblTablaBD.Columns
                        If tblInternoHuella.Columns.Contains(colDB.ColumnName) = False Then Continue For

                        If c_nomColPK.ToLower = colDB.ColumnName.ToLower Then Continue For 'si es clave primeria saltar
                        If colDB.ColumnName.ToLower = "_fec_proc_trf" Then Continue For

                        If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For

                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Men_Izq_id".ToLower And f.Item("fk_hue_Men_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Men_Izq_id"))
                            f.Item("fk_hue_Men_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Anu_Izq_id".ToLower And f.Item("fk_hue_Anu_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Anu_Izq_id"))
                            f.Item("fk_hue_Anu_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Med_Izq_id".ToLower And f.Item("fk_hue_Med_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Med_Izq_id"))
                            f.Item("fk_hue_Med_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Ind_Izq_id".ToLower And f.Item("fk_hue_Ind_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Ind_Izq_id"))
                            f.Item("fk_hue_Ind_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Pul_Izq_id".ToLower And f.Item("fk_hue_Pul_Izq_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Pul_Izq_id"))
                            f.Item("fk_hue_Pul_Izq_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Men_Der_id".ToLower And f.Item("fk_hue_Men_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Men_Der_id"))
                            f.Item("fk_hue_Men_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Anu_Der_id".ToLower And f.Item("fk_hue_Anu_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Anu_Der_id"))
                            f.Item("fk_hue_Anu_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Med_Der_id".ToLower And f.Item("fk_hue_Med_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Med_Der_id"))
                            f.Item("fk_hue_Med_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Ind_Der_id".ToLower And f.Item("fk_hue_Ind_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Ind_Der_id"))
                            f.Item("fk_hue_Ind_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If
                        If colDB.ColumnName.ToLower.Trim = "fk_hue_Pul_Der_id".ToLower And f.Item("fk_hue_Pul_Der_id") > 0 Then
                            Dim filas As DataRow()
                            filas = tblTemplateHuella.Select("pk_tmp_id=" & f.Item("fk_hue_Pul_Der_id"))
                            f.Item("fk_hue_Pul_Der_id") = If(filas.Count > 0, filas(0).Item("_rowid"), -1)
                            f.AcceptChanges()
                        End If

                        If colDB.ColumnName.ToLower.Trim = "_rowid" Then newRow.Add(colDB.ColumnName, -1) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, RegionLocalId) : Continue For
                        If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, PenalLocalId) : Continue For

                        Select Case f(colDB.ColumnName).ToString.ToLower
                            Case "false"
                                newRow.Add(colDB.ColumnName, 0)
                            Case "true"
                                newRow.Add(colDB.ColumnName, 1)
                            Case Else
                                Select Case colDB.DataType.Name
                                    Case "Byte[]"
                                        newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & f(colDB.ColumnName) & """)', 'varbinary(max)')")
                                    Case Else
                                        newRow.Add(colDB.ColumnName, "'" + f(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                End Select
                        End Select

                    Next

                    Dim strColum As String = ""
                    Dim strValor As String = ""
                    Dim strUpdate As String = ""

                    For Each k As KeyValuePair(Of String, Object) In newRow
                        strColum = strColum & ", " & k.Key
                        strValor = strValor & ", " & k.Value 'para el insert
                        strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                    Next
                    strColum = strColum.Substring(1, strColum.Length - 1)
                    strValor = strValor.Substring(1, strValor.Length - 1)
                    strUpdate = strUpdate.Substring(1, strUpdate.Length - 1)

                    Dim strSQL As String = ""
                    Dim n_idTablaLocal As Integer = -1
                    n_idTablaLocal = Bussines.Globall.UtilAccesoBD.ObtenerIDRegistroXSedRowId_PopeBD(c_nombTabla, c_nomColPK, f.Item("_sed_rowid"), 0, outSms)

                    If n_idTablaLocal = -1 Then
                        strSQL = strSQL & "INSERT INTO " & c_nombTabla & "(" & strColum & ") VALUES (" & strValor & "); select scope_identity() " & vbCrLf
                    Else
                        strSQL = strSQL & "UPDATE " & c_nombTabla & " SET " & strUpdate & " WHERE " & c_nomColPK & " = " & n_idTablaLocal & "; select " & n_idTablaLocal & vbCrLf
                    End If

                    id = Bussines.Globall.UtilAccesoBD.EjecutarSentencia_PopeBD(strSQL, 0, "")
                    f.Item("_rowid") = id
                    f.AcceptChanges()
                    tblInternoHuella.AcceptChanges()
                Next
            Catch ex As Exception
                outSms = outSms & ex.Message
                Return -1
            End Try
            Return id
        End Function
    End Class

End Namespace
