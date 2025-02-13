Imports System.Data.SqlClient
Imports System.Drawing

Namespace Transferencia
    Public Class ProcesaZXP
        Private Property PenalId As Integer = -1
        Private Property RegionId As Integer = -1

        Public Sub LimpiarDocParaConfirmarZXP(ByRef dts As DataSet)
            For Each t As DataTable In dts.Tables
                Dim nom As New List(Of String)
                For Each c As DataColumn In t.Columns
                    If c.ColumnName.ToLower <> "_sed_rowid" And c.ColumnName.ToLower <> "tabla" And c.ColumnName.ToLower <> "_rowid" Then
                        nom.Add(c.ColumnName)
                    End If
                Next
                For Each n As String In nom
                    t.Columns.Remove(n)
                Next
            Next
        End Sub
        ''' <summary>
        ''' Procesa la data proveniente de la region hacia los penales (documentos + otros).
        ''' </summary>
        ''' <param name="dtsXml"></param>
        ''' <param name="n_int_id"></param>
        ''' <param name="n_inp_ing_id"></param>
        ''' <param name="n_ingId"></param>
        ''' <param name="outSMS"></param>
        ''' <returns></returns>
        Public Function ProcesarDocumentosORL_ZXP(ByRef ws As APPWebService.ws_pope_sede_plm_carceleta.Carceleta, ByRef dtsXml As DataSet,
                                                  n_int_id As Integer, n_inp_ing_id As Integer, ByRef outSMS As String) As Boolean
            Dim v As Boolean = True
            Dim n_sed_inp_ing_id As Integer = -1

            Dim entInp As New Entity.Registro.IngresoInpe
            Dim bss As New Bussines.Registro.IngresoInpe

            If n_inp_ing_id > 0 Then
                entInp = bss.Listar(n_inp_ing_id)

                If entInp Is Nothing Then Return False
                If entInp.SedeRowId = -1 Then
                    outSMS = "El registro de IngresoInpe no tiene SedeRowId por lo cual se deduce que aun no ha sido transferido a la sede."
                    Return False
                End If

                n_sed_inp_ing_id = entInp.SedeRowId
            End If

            For Each dtTablaXML As DataTable In dtsXml.Tables
                If dtTablaXML.Rows.Count = 0 Then Continue For

                Dim NomTabla As String = dtTablaXML.Rows(0).Item("tabla")

                Try
                    If CrearQueryDocumentoJudSQL(ws, dtTablaXML, NomTabla, n_int_id, n_inp_ing_id, n_sed_inp_ing_id, outSMS) = False Then
                        v = False
                        Exit For
                    End If
                Catch ex As Exception
                    outSMS = outSMS & vbCrLf & ex.ToString
                    v = False
                    Exit For
                End Try
            Next

            Return v
        End Function

        Private Function CrearQueryDocumentoJudSQL(ByRef ws As APPWebService.ws_pope_sede_plm_carceleta.Carceleta, ByRef dtTablaXML As DataTable,
                                                   NombreTabla As String, n_int_id As Integer, n_inp_ing_id As Integer, n_sed_inp_ing_id As Integer,
                                                   ByRef outSMS As String) As Boolean
            Dim tblTablaBD As DataTable = Nothing
            Dim bloqueaTransfer As Boolean = False
            Dim sms As String = ""
            Dim ListClaveFK_xml As New Dictionary(Of String, String)
            ListClaveFK_xml = ObtenerListaFK_XML_v_light(dtTablaXML)

            Dim ListFKValidacionOpcional As New Dictionary(Of String, String)
            ListFKValidacionOpcional = DeterminarFKOpcionales_v_light(dtTablaXML)

            Dim newRow As Dictionary(Of String, Object)

            tblTablaBD = LeerTablaBD(NombreTabla)

            If ComprobarExistenciaColumna_en_XML(dtTablaXML, tblTablaBD, NombreTabla, outSMS) = False Then Return False 'verificar si la columna de la tabla X esta presente en el xml.

            For Each filaXML As DataRow In dtTablaXML.Rows
                Dim intIngId As Integer = -1
                If ComprobarCampoEspecialTengaValor_XML(filaXML, NombreTabla, outSMS) = False Then Return False 'verificar que campos especiales de transferencias contengan valor
                If filaXML.Item("_sed_rowid") <= 0 Then
                    outSMS = "Error, existe fila con _sed_rowid=" & filaXML.Item("_sed_rowid") & ", Tabla " & NombreTabla
                    Return False
                End If

                If NombreTabla.ToUpper = "int_mov_interno_ingreso_inpe".ToUpper AndAlso n_sed_inp_ing_id = filaXML.Item("_sed_rowid") Then 'si es el mismo ingresoInpe no hacer nada
                    filaXML("_rowId") = n_inp_ing_id
                    filaXML.AcceptChanges()
                    'Continue For
                End If

                If filaXML.Item("_sed_rowid") > 0 AndAlso ExisteFilaDuplicadaEnTablaBD_x_SedRowId(filaXML, NombreTabla) = True Then 'si existe filas duplicadas por region/penal/_sed_rowid 
                    outSMS = "Existe fila duplicada al hacer una búsqueda por _sed_rowid=" & filaXML.Item("_sed_rowid") & ", Tabla " & NombreTabla
                    Return False
                End If
                'leer toda la fila columna=valor de xml
                newRow = New Dictionary(Of String, Object)()
                For Each colDB As DataColumn In tblTablaBD.Columns
                    If dtTablaXML.Columns.Contains(colDB.ColumnName) = False Then Continue For
                    If colDB.ColumnName.ToLower = "_rowid" Then Continue For

                    If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                    If colDB.ColumnName.ToLower.Trim = "_sed_flg_trf" Then newRow.Add(colDB.ColumnName, 0) : Continue For
                    If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then
                        Dim tmpId As Integer = -1

                        tmpId = ObtenerIDRegistroXSedeRowId("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", -1, filaXML.Item("fk_ing_inp_id"), -1, -1, outSMS)
                        If tmpId = -1 Then
                            outSMS = "Error en la tabla " & NombreTabla & ", Id=" & filaXML.Item("key_id") & " Tabla foranea int_mov_interno_ingreso_inpe, ObtenerIDRegistroXSedeRowId(....) _sed_rowid=" & filaXML.Item("fk_ing_inp_id")
                            Return False
                        End If
                        newRow.Add(colDB.ColumnName, tmpId)

                        Continue For
                    End If
                    If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then
                        Dim idIngInp As Integer = -1
                        Dim _sedRowIdIngInp As Integer = -1

                        idIngInp = ObtenerIDRegistroXSedeRowId("int_mov_interno_ingreso_inpe", "pk_ing_inp_id", -1, filaXML.Item("fk_ing_inp_id"), -1, -1, outSMS)

                        If idIngInp > -1 Then 'obtener ingreso x ingresoInpe
                            Dim entCol As Entity.EntityCol(Of Entity.Registro.Ingreso)
                            Dim entIng As New Entity.Registro.Ingreso
                            entIng.IngresoInpeId = idIngInp
                            entCol = (New Bussines.Registro.Ingreso).Listar_LM(entIng)
                            If entCol Is Nothing OrElse entCol.Count = 0 Then
                                newRow.Add(colDB.ColumnName, -1) 'la columna IngresoId =-1
                                Continue For
                            End If
                            If entCol.Count > 0 Then
                                intIngId = entCol.Item(0).Codigo
                                newRow.Add(colDB.ColumnName, intIngId)
                            End If
                        Else
                            newRow.Add(colDB.ColumnName, -1) 'la columna IngresoId =-1
                        End If

                        Continue For
                    End If

                    If colDB.ColumnName.ToLower.Trim = "_regid" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                    If colDB.ColumnName.ToLower.Trim = "_penid" Then
                        If NombreTabla.ToUpper = "int_mov_interno_ingreso_inpe".ToUpper Then
                            If filaXML.Item("_penid") = Me.PenalId Or filaXML.Item("clasif_pen_dest_id") = Me.PenalId Or filaXML.Item("mov_pen_dest_id") = Me.PenalId Or filaXML.Item("ing_pen_dest_id") = Me.PenalId Then
                                newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                            Else
                                bloqueaTransfer = True
                                newRow.Add(colDB.ColumnName, filaXML.Item("_penid")) : Continue For
                            End If
                        Else
                            newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For
                        End If
                    End If

                    If ExisteClaveForaneaEnXML(ListClaveFK_xml, colDB.ColumnName) = True Then
                        Dim blnValidar As Boolean = False
                        Dim intIDFK As Integer = -1

                        If ListFKValidacionOpcional.ContainsKey(colDB.ColumnName) = True And (Val(filaXML(colDB.ColumnName)) <= 0) Then
                            blnValidar = False
                            intIDFK = filaXML(colDB.ColumnName)
                        Else
                            blnValidar = True
                        End If

                        If blnValidar = True Then
                            Dim strNombreColPK_TablaForanea As String 'verificar que las claves foraneas tenga referencias, se debe exceptuar fk que no requieren validarse
                            strNombreColPK_TablaForanea = NombreCampoPK_EnTablaForanea(ListClaveFK_xml, colDB.ColumnName)

                            Dim strNombreCampoFkLocal As String
                            strNombreCampoFkLocal = NombreCampoFK_Local(ListClaveFK_xml, colDB.ColumnName)

                            Dim strNombreTablaForanea As String
                            strNombreTablaForanea = NombreTablaForanea(ListClaveFK_xml, colDB.ColumnName)

                            Dim _sed_rowid As Integer = -1
                            Dim strCadConcatVal As String() = Nothing
                            For Each x As KeyValuePair(Of String, String) In ListClaveFK_xml
                                Dim v As String = x.Key
                                If UCase(Mid(v, 1, v.IndexOf("|"))) = UCase(colDB.ColumnName) Then
                                    strCadConcatVal = Split(filaXML(x.Value), "|")
                                    Exit For
                                End If
                            Next

                            _sed_rowid = strCadConcatVal(1)

                            If _sed_rowid < 0 Then ' Or RegId < 1 Then
                                outSMS = "Error en la tabla " & NombreTabla & ", Id=" & filaXML.Item("key_id") & " Tabla foranea " & strNombreTablaForanea & " Campo PK foraneo=" & strNombreColPK_TablaForanea
                                Return False
                            End If

                            Try
                                If _sed_rowid > 0 Then
                                    intIDFK = ActualizarTransferenciaID_x_SedRowId(strNombreColPK_TablaForanea, _sed_rowid, strNombreTablaForanea, sms)
                                End If

                                If intIDFK = -1 Then
                                    outSMS = "No se puede obtener el id de la tabla foranea " & strNombreTablaForanea & ", tabla local " & NombreTabla & ", _sed_rowid=" & _sed_rowid & " " & sms
                                    Return False
                                End If

                            Catch ex As Exception
                                outSMS = "Tabla Foranea " & strNombreTablaForanea & ", tabla local " & NombreTabla & ", _sed_rowid=" & _sed_rowid & " Excepcion: " & ex.ToString
                                Return False
                            End Try
                        End If
                        newRow.Add(colDB.ColumnName, intIDFK)
                    Else
                        Try
                            Select Case filaXML(colDB.ColumnName).ToString.ToLower
                                Case "false"
                                    newRow.Add(colDB.ColumnName, 0)
                                Case "true"
                                    newRow.Add(colDB.ColumnName, 1)
                                Case Else
                                    If colDB.ColumnName.ToLower.Trim = "_sed_flg_trf" Or colDB.ColumnName.ToLower.Trim = "_flg_trf" Then
                                        newRow.Add(colDB.ColumnName, 0)
                                    ElseIf colDB.ColumnName.ToLower.Trim = "_fec_proc_trf" Then
                                        newRow.Add(colDB.ColumnName, Now.ToFileTime) 'actualiza la fecha de procesamiento del registro en la sede
                                    Else
                                        Select Case colDB.DataType.Name
                                            Case "Byte[]"
                                                newRow.Add(colDB.ColumnName, "CAST(N'' AS xml).value('xs:base64Binary(""" & filaXML(colDB.ColumnName) & """)', 'varbinary(max)')")
                                            Case Else
                                                newRow.Add(colDB.ColumnName, "'" + filaXML(colDB.ColumnName).ToString.Replace("'", "") + "'")
                                        End Select
                                    End If
                            End Select
                        Catch ex As Exception
                            outSMS = "tabla local " & NombreTabla & ", _sed_rowid=" & filaXML.Item("_sed_rowid") & ",  & Excepcion: " & ex.ToString
                            Return False
                        End Try
                    End If
                Next

                Dim strColum As String = "" 'para determinar las columnas de las tablas para insert/update
                Dim strValor As String = ""
                Dim strUpdate As String = ""

                Dim strNombreClavePrimaria As String = ""
                strNombreClavePrimaria = filaXML.Item("key_name")
                Try
                    For Each k As KeyValuePair(Of String, Object) In newRow
                        If strNombreClavePrimaria <> k.Key Then 'si es diferente de clave primaria
                            If LCase(k.Key) <> "_arc_nom" And LCase(k.Key) <> "_rowid" Then
                                strColum = strColum & ", " & k.Key 'concatena todas las columnas de la tabla: col01, col02, col03,...,col(n)
                                strValor = strValor & ", " & k.Value 'para el insert
                                If NombreTabla.ToLower.Trim = "INT_InternoExpediente".ToLower.Trim Or NombreTabla.ToLower.Trim = "INT_InternoDelito".ToLower.Trim Then
                                    If k.Key = "int_exp_pri" Then Continue For
                                    If k.Key = "int_exp_pri_sen" Then Continue For
                                    If k.Key = "int_del_dmp" Then Continue For
                                    If k.Key = "int_del_sen_dmp" Then Continue For
                                End If
                                strUpdate = strUpdate & ", " & k.Key & " = " & k.Value 'para el update
                            End If
                        End If
                    Next k
                Catch ex As Exception
                    Dim s As String
                    s = s
                End Try

                '_arc_nom
                If bloqueaTransfer = True Then
                    strValor = "'NO_TRANSFER_REG'" & strValor
                    strColum = "_arc_nom" & strColum
                    strUpdate = "_arc_nom='NO_TRANSFER_REG'" & strUpdate
                Else
                    strValor = "'TRF_DIRECTA'" & strValor
                    strColum = "_arc_nom" & strColum
                    strUpdate = "_arc_nom='TRF_DIRECTA'" & strUpdate
                End If

                '*******************'determinar si es insert o update
                Dim strSQL As String = ""
                Dim id As Integer = -1
                Dim nuevo As Boolean = False

                If "INT_Interno".ToUpper = NombreTabla.ToUpper Then
                    Dim entUltIngInp As New Entity.Registro.IngresoInpe
                    entUltIngInp = (New Bussines.Registro.IngresoInpe).ListarUltimoIngresoInpe(n_int_id, Me.PenalId)

                    If Not entUltIngInp Is Nothing Then
                        'obtener el ultimo ingresoInpe
                        If entUltIngInp.Codigo = n_inp_ing_id Then
                            Dim entHist As New Entity.Registro.InternoHistorico
                            Dim bssHist As New Bussines.Registro.InternoHistorico

                            entHist.IngresoInpeId = n_inp_ing_id

                            entHist = bssHist.Listar_LM(entHist)

                            If Not entHist Is Nothing Then
                                entHist.ApellidoPaterno = filaXML.Item("int_ape_pat")
                                entHist.ApellidoMaterno = filaXML.Item("int_ape_mat")
                                entHist.Nombres = filaXML.Item("int_nom")

                                Dim tmpIdHist As Integer = -1
                                tmpIdHist = bssHist.Grabar_LM(entHist)
                                tmpIdHist = tmpIdHist
                            End If

                        End If
                    End If
                End If

                filaXML.Item("_rowid") = -1
                filaXML.AcceptChanges()
                id = ObtenerIDRegistroXSedeRowId(NombreTabla, strNombreClavePrimaria, -1, filaXML.Item("_sed_rowid"), -1, -1, outSMS)


                If id = -100 Then Return False
                If id = -1 Then nuevo = True


                If nuevo = True Then
                    strSQL = strSQL & "INSERT INTO " & NombreTabla & "(" & strColum & ") VALUES (" & strValor & ");select scope_identity();" & vbCrLf
                Else
                    strSQL = strSQL & "UPDATE " & NombreTabla & " SET " & strUpdate & " WHERE " & strNombreClavePrimaria & " = " & id & "; select " & id & ";" & vbCrLf
                End If

                Try
                    Dim tmpId As Integer = -1
                    tmpId = EjecutarSentencia(strSQL) 'ejecutar sentencia SQL

                    If NombreTabla.ToUpper = "int_mov_interno_ingreso_inpe".ToUpper Then
                        If (filaXML.Item("clasif_pen_dest_id") = Me.PenalId Or filaXML.Item("mov_pen_dest_id") = Me.PenalId Or filaXML.Item("ing_pen_dest_id") = Me.PenalId) Then

                            'Sino tiene internoIngreso
                            Dim tmpIdHist As Integer = -1
                            Dim entInpe As New Entity.Registro.IngresoInpe
                            Dim entCol As Entity.EntityCol(Of Entity.Registro.Ingreso)
                            Dim entIng As New Entity.Registro.Ingreso
                            Dim bssIng As New Bussines.Registro.Ingreso

                            entInpe = (New Bussines.Registro.IngresoInpe).Listar(tmpId)

                            entIng.IngresoInpeId = tmpId
                            entCol = (New Bussines.Registro.Ingreso).Listar_LM(entIng)

                            If entCol.Count > 0 Then 'si existe ingtreso updatear numero y fechaISP
                                entIng = bssIng.Listar_LM(entCol.Item(0).Codigo)

                                If entInpe Is Nothing Then 'si ingresoInpe no existe significa que está eliminado
                                    bssIng.Eliminar_LM(entIng)
                                Else
                                    With entIng
                                        .IngresoNro = entInpe.IngresoNro
                                        .FechaISP = entInpe.FechaIngInpe
                                    End With

                                    bssIng.Grabar_LM(entIng, "")
                                End If

                            ElseIf Not entInpe Is Nothing Then '------------------------ insertar InternoIngreso ---------------------->

                                entIng = New Entity.Registro.Ingreso

                                With entIng
                                    .IngresoInpeId = tmpId
                                    .InternoID = entInpe.InternoID
                                    .FechaISP = entInpe.FechaIngInpe
                                    .IngresoNro = entInpe.IngresoNro
                                    .MotivoIngresoID = entInpe.MotivoIngresoID
                                    .PenalID = Me.PenalId
                                    .RegionID = Me.RegionId
                                End With

                                intIngId = bssIng.Grabar_LM(entIng, "")
                                '<----------------------------------------------------------------------

                                '------------------------- insertar historico en caso no cuenta-------->
                                Dim objEntDatosInterno As New Entity.Registro.Interno
                                Dim entHist As New Entity.Registro.InternoHistorico
                                Dim bssHist As New Bussines.Registro.InternoHistorico

                                entHist.IngresoInpeId = tmpId
                                entHist = bssHist.Listar_LM(entHist)

                                'obtener el ultimo ingresoInpe
                                If entHist Is Nothing Then
                                    objEntDatosInterno = (New Bussines.Registro.Interno).Listar_LM(n_int_id)
                                    entHist = bssHist.Listar_Convert_Historico_LM(objEntDatosInterno)

                                    With entHist
                                        .IngresoInpeId = tmpId
                                        .IngresoID = intIngId
                                        .RegionID = Me.RegionId
                                        .PenalID = Me.PenalId
                                    End With

                                    tmpIdHist = bssHist.Grabar_LM(entHist)

                                End If
                                '<------------------------------------------------------------------------
                            End If


                            '--------------- descargar otros datos del interno del ingresoInpeActual--->

                            Dim dts As DataSet
                            dts = ws.ListarDatIntOtrosZXP(filaXML.Item("_sed_rowid"))

                            If dts Is Nothing Then
                                outSMS = "Valor Nulo retornado por ListarDatIntOtrosZXP, ingInpId = " & tmpId

                                EjecutarSentencia("delete INT_InternoIngreso where int_ing_id=" & intIngId)
                                EjecutarSentencia("delete INT_InternoHistorico where int_hist_id=" & tmpIdHist)
                                'EjecutarSentencia("delete int_mov_interno_ingreso_inpe where pk_ing_inp_id=" & tmpId)
                                Return False
                            End If

                            Dim v As Boolean = True
                            For Each tbl As DataTable In dts.Tables
                                If tbl.Rows.Count = 0 Then Continue For

                                Dim strNomTabla As String = tbl.Rows(0).Item("tabla")

                                Try
                                    If CrearQuerySQLDatosInterno(tbl, strNomTabla, n_int_id, tmpId, intIngId, outSMS) = False Then
                                        outSMS = "Valor retornado falso al llamar a CrearQuerySQLDatosInterno(), strNomTabla=" & strNomTabla & " " & outSMS
                                        EjecutarSentencia("delete INT_InternoIngreso where int_ing_id=" & intIngId)
                                        EjecutarSentencia("delete INT_InternoHistorico where int_hist_id=" & tmpIdHist)
                                        'EjecutarSentencia("delete int_mov_interno_ingreso_inpe where pk_ing_inp_id=" & tmpId)
                                        Return False
                                        Exit For
                                    End If
                                Catch ex As Exception
                                    outSMS = outSMS & vbCrLf & ex.ToString
                                    EjecutarSentencia("delete INT_InternoIngreso where int_ing_id=" & intIngId)
                                    EjecutarSentencia("delete INT_InternoHistorico where int_hist_id=" & tmpIdHist)
                                    'EjecutarSentencia("delete int_mov_interno_ingreso_inpe where pk_ing_inp_id=" & tmpId)
                                    Return False
                                    Exit For
                                End Try
                            Next

                            '<------------------------------------------------------------------------
                        End If
                    End If

                    Try
                        Dim strTmp As String = ""
                        strTmp = "update " & NombreTabla & " set _flg_trf=0, _rowid=" & tmpId & " where " & strNombreClavePrimaria & " = " & tmpId
                        EjecutarSentencia(strTmp)
                    Catch ex As Exception

                    End Try
                    filaXML("_rowId") = tmpId
                    filaXML.AcceptChanges()
                    'End If
                Catch ex As Exception
                    outSMS = "Error al ejecutar " & ex.ToString
                    Return False
                End Try

            Next filaXML
            Return True
        End Function

        Private Function CrearQuerySQLDatosInterno(ByRef dtTablaXML As DataTable, NombreTabla As String, n_int_id As Integer, n_inp_ing_id As Integer, n_ing_id As Integer, ByRef outSMS As String) As Boolean

            Dim ListSqlP As Dictionary(Of String, Object)

            Dim tblTablaBD As DataTable = Nothing
            Dim sms As String = ""
            Dim ListClaveFK_xml As New Dictionary(Of String, String)
            ListClaveFK_xml = ObtenerListaFK_XML_v_light(dtTablaXML)

            Dim ListFKValidacionOpcional As New Dictionary(Of String, String)
            ListFKValidacionOpcional = DeterminarFKOpcionales_v_light(dtTablaXML)

            Dim newRow As Dictionary(Of String, Object)

            tblTablaBD = LeerTablaBD(NombreTabla)

            If ComprobarExistenciaColumna_en_XML(dtTablaXML, tblTablaBD, NombreTabla, outSMS) = False Then Return False 'verificar si la columna de la tabla X esta presente en el xml.

            For Each f As DataRow In dtTablaXML.Rows
                ListSqlP = New Dictionary(Of String, Object)

                If ComprobarCampoEspecialTengaValor_XML(f, NombreTabla, outSMS) = False Then Return False 'verificar que campos especiales de transferencias contengan valor
                If f.Item("_sed_rowid") <= 0 Then
                    outSMS = "Error, existe fila con _sed_rowid=" & f.Item("_sed_rowid") & ", Tabla " & NombreTabla
                    Return False
                End If

                If f.Item("_sed_rowid") > 0 AndAlso ExisteFilaDuplicadaEnTablaBD_x_SedRowId(f, NombreTabla) = True Then 'si existe filas duplicadas por region/penal/_sed_rowid 
                    outSMS = "Existe fila duplicada al hacer una búsqueda por _sed_rowid=" & f.Item("_sed_rowid") & ", Tabla " & NombreTabla
                    Return False
                End If
                'leer toda la fila columna=valor de xml
                newRow = New Dictionary(Of String, Object)()
                For Each colDB As DataColumn In tblTablaBD.Columns
                    If dtTablaXML.Columns.Contains(colDB.ColumnName) = False Then Continue For
                    If colDB.ColumnName.ToLower = "_rowid" Then Continue For

                    If colDB.ColumnName.ToLower.Trim = "int_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_id" Then newRow.Add(colDB.ColumnName, n_int_id) : Continue For
                    If colDB.ColumnName.ToLower.Trim = "_sed_flg_trf" Then newRow.Add(colDB.ColumnName, 0) : Continue For
                    If colDB.ColumnName.ToLower.Trim = "fk_ing_inp_id" Then
                        newRow.Add(colDB.ColumnName, n_inp_ing_id)

                        Continue For
                    End If
                    If colDB.ColumnName.ToLower.Trim = "int_ing_id" Or colDB.ColumnName.ToLower.Trim = "fk_int_ing_id" Then
                        newRow.Add(colDB.ColumnName, n_ing_id)
                        Continue For
                    End If

                    If colDB.ColumnName.ToLower.Trim = "_regid" Or colDB.ColumnName.ToLower.Trim = "reg_id" Then newRow.Add(colDB.ColumnName, Me.RegionId) : Continue For
                    If colDB.ColumnName.ToLower.Trim = "_penid" Or colDB.ColumnName.ToLower.Trim = "pen_id" Then newRow.Add(colDB.ColumnName, Me.PenalId) : Continue For

                    If ExisteClaveForaneaEnXML(ListClaveFK_xml, colDB.ColumnName) = True Then
                        Dim blnValidar As Boolean = False
                        Dim intIDFK As Integer = -1

                        If ListFKValidacionOpcional.ContainsKey(colDB.ColumnName) = True And (Val(f(colDB.ColumnName)) <= 0) Then
                            blnValidar = False
                            intIDFK = f(colDB.ColumnName)
                        Else
                            blnValidar = True
                        End If

                        If blnValidar = True Then
                            Dim strNombreColPK_TablaForanea As String 'verificar que las claves foraneas tenga referencias, se debe exceptuar fk que no requieren validarse
                            strNombreColPK_TablaForanea = NombreCampoPK_EnTablaForanea(ListClaveFK_xml, colDB.ColumnName)

                            Dim strNombreCampoFkLocal As String
                            strNombreCampoFkLocal = NombreCampoFK_Local(ListClaveFK_xml, colDB.ColumnName)

                            Dim strNombreTablaForanea As String
                            strNombreTablaForanea = NombreTablaForanea(ListClaveFK_xml, colDB.ColumnName)

                            Dim _sed_rowid As Integer = -1
                            Dim strCadConcatVal As String() = Nothing
                            For Each x As KeyValuePair(Of String, String) In ListClaveFK_xml
                                Dim v As String = x.Key
                                If UCase(Mid(v, 1, v.IndexOf("|"))) = UCase(colDB.ColumnName) Then
                                    strCadConcatVal = Split(f(x.Value), "|")
                                    Exit For
                                End If
                            Next

                            _sed_rowid = strCadConcatVal(1)

                            If _sed_rowid < 1 Then ' Or RegId < 1 Then
                                outSMS = "Error en la tabla " & NombreTabla & ", Id=" & f.Item("key_id") & " Tabla foranea " & strNombreTablaForanea & " Campo PK foraneo=" & strNombreColPK_TablaForanea
                                Return False
                            End If

                            Try
                                If _sed_rowid > 0 Then
                                    intIDFK = ActualizarTransferenciaID_x_SedRowId(strNombreColPK_TablaForanea, _sed_rowid, strNombreTablaForanea, sms)
                                End If

                                If intIDFK = -1 Then
                                    outSMS = "No se puede obtener el id de la tabla foranea " & strNombreTablaForanea & ", tabla local " & NombreTabla & ", _sed_rowid=" & _sed_rowid & " " & sms
                                    Return False
                                End If

                            Catch ex As Exception
                                outSMS = "Tabla Foranea " & strNombreTablaForanea & ", tabla local " & NombreTabla & ", _sed_rowid=" & _sed_rowid & " Excepcion: " & ex.ToString
                                Return False
                            End Try
                        End If
                        newRow.Add(colDB.ColumnName, intIDFK)
                    Else
                        Try
                            Select Case f(colDB.ColumnName).ToString.ToLower
                                Case "false"
                                    newRow.Add(colDB.ColumnName, 0)
                                Case "true"
                                    newRow.Add(colDB.ColumnName, 1)
                                Case Else
                                    If colDB.ColumnName.ToLower.Trim = "_sed_flg_trf" Or colDB.ColumnName.ToLower.Trim = "_flg_trf" Then
                                        newRow.Add(colDB.ColumnName, 0)
                                    ElseIf colDB.ColumnName.ToLower.Trim = "_fec_proc_trf" Then
                                        newRow.Add(colDB.ColumnName, Now.ToFileTime) 'actualiza la fecha de procesamiento del registro en la sede
                                    Else
                                        newRow.Add(colDB.ColumnName, f(colDB.ColumnName))
                                    End If
                            End Select
                        Catch ex As Exception
                            outSMS = "tabla local " & NombreTabla & ", _sed_rowid=" & f.Item("_sed_rowid") & ",  & Excepcion: " & ex.ToString
                            Return False
                        End Try
                    End If
                Next

                Dim strNombreClavePrimaria As String = ""
                strNombreClavePrimaria = f.Item("key_name")
                Try
                    For Each k As KeyValuePair(Of String, Object) In newRow
                        If strNombreClavePrimaria <> k.Key Then 'si es diferente de clave primaria
                            If LCase(k.Key) <> "_arc_nom" And LCase(k.Key) <> "_rowid" Then
                                ListSqlP.Add(k.Key, k.Value)
                            End If
                        End If
                    Next k
                Catch ex As Exception
                    Dim s As String
                    s = s
                End Try

                '*******************'determinar si es insert o update
                Dim strSQL As String = ""
                Dim id As Integer = -1
                Dim nuevo As Boolean = False

                f.Item("_rowid") = -1
                f.AcceptChanges()
                id = ObtenerIDRegistroXSedeRowId(NombreTabla, strNombreClavePrimaria, -1, f.Item("_sed_rowid"), -1, -1, outSMS)

                If id = -100 Then Return False
                If id = -1 Then nuevo = True

                Try
                    Dim tmpId As Integer = -1
                    If nuevo = True Then
                        tmpId = ExecuteInsert(ListSqlP, NombreTabla)
                    Else
                        tmpId = ExecuteUpdate(ListSqlP, NombreTabla, strNombreClavePrimaria, id)
                    End If

                    'jmr-02.03.2022. Validar y descargar que las fotos que no se encuentren en el penal
                    If NombreTabla.ToUpper = "GLO_ArchivoDigital".ToUpper Then

                        Try

                            Dim idArchivoDigitalLocal As Integer = tmpId
                            Dim subioFoto As Boolean = False

                            Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
                            Dim objWS As New APPWebService.ws_foto.PopeLocal
                            objWS.Timeout = -1
                            objWS.Url = APPWebService.PathURL.WSPopeLocal

                            r = objWS.ListarArchivoDigital(idArchivoDigitalLocal, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno)

                            'si la foto local en el penal no existe
                            If r.Resultado.ArchivoByte Is Nothing Then

                                'descargar la foto de sede
                                Dim fotoSedeByte As Byte() = Nothing
                                fotoSedeByte = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(f.Item("_sed_rowid"), 1, outSMS, True)

                                If fotoSedeByte Is Nothing Then
                                    outSMS = ""
                                Else

                                    Dim directorioServidor As String = f.Item("arc_dig_pth_ser").ToString
                                    Dim nombreFisico As String = f.Item("arc_dig_nom_fis")
                                    Dim extension As String = f.Item("arc_dig_ext")

                                    'si no tiene nueva ruta (año-mes-cor), entonces se trata de una foto antigua
                                    If directorioServidor.Length < 1 Then
                                        directorioServidor = f.Item("arc_dig_dir").ToString

                                        'si las fotos son de carceleta, entonces agregar region y penal (3/35)
                                        If directorioServidor.Contains("VOL0223") = True Then
                                            directorioServidor = "3/35/" + directorioServidor
                                        End If

                                    End If

                                    APPWebService.Fotografia.SubirFotoByte_v2(fotoSedeByte, nombreFisico, extension, directorioServidor,
                                                                                  APPWebService.Fotografia.enmDirectotioTipo.Interno,
                                                                                  outSMS)

                                End If

                            End If

                        Catch ex As Exception
                            Dim s As String
                            s = ""
                        End Try

                        Try
                            Dim strTmp As String = ""
                            strTmp = "update " & NombreTabla & " set _flg_trf=0, _rowid=" & tmpId & " where " & strNombreClavePrimaria & " = " & tmpId
                            EjecutarSentencia(strTmp)
                        Catch ex As Exception

                        End Try

                        f("_rowId") = tmpId
                        f.AcceptChanges()
                    End If
                Catch ex As Exception
                    outSMS = "Error al ejecutar " & ex.ToString
                    Return False
                End Try

            Next f

            Return True
        End Function

        Private Function ExecuteInsert(lstSqlPar As Dictionary(Of String, Object), nomTabla As String) As Integer
            Dim cmd As New SqlCommand
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim id As Integer = -1

            Dim strColum As String = ""
            Dim strValor As String = ""

            For Each k As KeyValuePair(Of String, Object) In lstSqlPar
                strColum = strColum & ", " & k.Key 'concatena todas las columnas de la tabla: col01, col02, col03,...,col(n)
                strValor = strValor & ", @" & k.Key 'para el insert
                cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
            Next

            strValor = "@_arc_nom" & strValor
            strColum = "_arc_nom" & strColum

            cmd.Parameters.Add(New SqlParameter("@_arc_nom", ""))

            Try
                cmd.CommandText = "INSERT INTO " & nomTabla & "(" & strColum & ") VALUES (" & strValor & ");select scope_identity();"
                cmd.Connection = sqlCon
                cmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = cmd.ExecuteScalar()
            Catch ex As Exception
                id = -1
            Finally
                sqlCon.Close()
                cmd.Dispose()
            End Try

            Return id

        End Function

        Private Function ExecuteUpdate(lstSqlPar As Dictionary(Of String, Object), nomTabla As String, nomPkTabla As String, valorPkTabla As Integer) As Integer
            Dim cmd As New SqlCommand
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim id As Integer = -1

            Dim strUpdate As String = ""

            For Each k As KeyValuePair(Of String, Object) In lstSqlPar
                strUpdate = strUpdate & ", " & k.Key & " = @" & k.Key
                cmd.Parameters.Add(New SqlParameter("@" & k.Key, k.Value))
            Next

            strUpdate = "_arc_nom=@_arc_nom" & strUpdate
            cmd.Parameters.Add(New SqlParameter("@_arc_nom", ""))

            cmd.Parameters.Add(New SqlParameter("@" & nomPkTabla, valorPkTabla))
            Try
                cmd.CommandText = "UPDATE " & nomTabla & " SET " & strUpdate & " WHERE " & nomPkTabla & " = @" & nomPkTabla & "; select " & valorPkTabla & ";"
                cmd.Connection = sqlCon
                cmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = cmd.ExecuteScalar()
            Catch ex As Exception
                id = -1
            Finally
                sqlCon.Close()
                cmd.Dispose()
            End Try

            Return id

        End Function

#Region "CrearQuerySQL"
        Private Function ObtenerListaFK_XML_v_light(dtTablaXML As DataTable) As Dictionary(Of String, String)
            '*******************************************************************************************************************************************
            ' Permite obtener las claves foraneas de una tabla transferida en el archivo XML y retornar en una lista Dictionary
            'Return: lista Dictionary, (clave,valor)=('col_fk|col_pk|relacion estricto/opcional','nombre_tabla_foranea')
            '*******************************************************************************************************************************************
            Dim claveFKxml As New Dictionary(Of String, String)
            For Each objCol As DataColumn In dtTablaXML.Columns
                If objCol.ColumnName <> "" Then
                    If Mid(objCol.ColumnName, 1, 4) = "xyz_" Then
                        claveFKxml.Add(dtTablaXML.Rows(0).Item(objCol.ColumnName), objCol.ColumnName)
                    End If
                End If
            Next
            Return claveFKxml
        End Function

        Private Function DeterminarFKOpcionales_v_light(dtTablaXML As DataTable) As Dictionary(Of String, String)
            Dim claveFKxml As New Dictionary(Of String, String)
            For Each objCol As DataColumn In dtTablaXML.Columns
                If objCol.ColumnName <> "" Then
                    If Mid(objCol.ColumnName, 1, 4) = "xyz_" Then
                        Dim strCad As String = ""
                        Dim nomColFK As String = ""
                        Dim strOpcion As String = "" 'opcional/estricto

                        Dim NombreTablaFK As String = objCol.ColumnName 'fk_1_int_interno, 
                        Try
                            NombreTablaFK = Mid(NombreTablaFK, NombreTablaFK.IndexOf("_", 4) + 2, Len(NombreTablaFK) - NombreTablaFK.IndexOf("_", 4))

                            strCad = dtTablaXML.Rows(0).Item(objCol.ColumnName) 'int_id|int_id|estricto
                            nomColFK = Mid(strCad, 1, strCad.IndexOf("|"))
                            strOpcion = Mid(strCad, strCad.LastIndexOf("|") + 2, Len(strCad) - strCad.LastIndexOf("|"))
                            If LCase(strOpcion) = "opcional" Then 'no validar si el valor del FK es -1
                                claveFKxml.Add(nomColFK, NombreTablaFK) 'dtTablaXML.Rows(0).Item(objCol.ColumnName))
                            End If
                        Catch ex As Exception
                            Throw New Exception("Excepción en Working/UsrBajar/DeterminarFKOpcionales, NombreTablaForanea=" & objCol.ColumnName)
                        End Try
                    End If
                End If
            Next
            Return claveFKxml
        End Function

        Private Function LeerTablaBD(NombreTabla As String) As DataTable
            '*******************************************************************************************************************************************
            ' Permite obtener todos los campos de una tabla de la bd local para comparar con los campos de la tabla del archivo de transferencia.
            '*******************************************************************************************************************************************
            Dim dtTabla As DataTable = Nothing
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCmd = New SqlCommand("select top 1 * from " & NombreTabla, sqlCon)
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader()
                dtTabla = Nothing
                dtTabla = New DataTable
                dtTabla.Load(sqlReader)
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
                sqlReader.Dispose()
                sqlReader.Close()
                sqlReader = Nothing
            End Try
            Return dtTabla
        End Function

        Private Function ComprobarExistenciaColumna_en_XML(TablaXML As DataTable, TablaBD As DataTable, NombreTabla As String, ByRef outSms As String) As Boolean
            '************************************************************************************************************************************************
            'Permite verificar que cada columna de la tabla se transfiera en el xml, caso contrario se cancela el procesamiento.
            '************************************************************************************************************************************************
            Dim blnExiteConlumnaEnXML As Boolean = True
            Dim strColumnaFaltante As String = ""
            Dim strNombreColumna As String = ""
            Try
                Dim aux As String
                strNombreColumna = "_RowId"
                If TablaXML.Columns.Contains(strNombreColumna) = False Then
                    strColumnaFaltante = strNombreColumna
                    blnExiteConlumnaEnXML = False
                End If

                strNombreColumna = "tabla"
                If TablaXML.Columns.Contains(strNombreColumna) = False Then
                    strColumnaFaltante = strColumnaFaltante & ", " & strNombreColumna
                    blnExiteConlumnaEnXML = False
                End If

                strNombreColumna = "key_name"
                If TablaXML.Columns.Contains(strNombreColumna) = False Then
                    strColumnaFaltante = strColumnaFaltante & ", " & strNombreColumna
                    blnExiteConlumnaEnXML = False
                End If

                strNombreColumna = "key_id"
                If TablaXML.Columns.Contains(strNombreColumna) = False Then
                    strColumnaFaltante = strColumnaFaltante & ", " & strNombreColumna
                    blnExiteConlumnaEnXML = False
                End If

                strNombreColumna = "_sed_rowid"
                If TablaXML.Columns.Contains(strNombreColumna) = False Then
                    strColumnaFaltante = strColumnaFaltante & ", " & strNombreColumna
                    blnExiteConlumnaEnXML = False
                End If

            Catch ex As Exception
                outSms = "No está especificada el campo " & strNombreColumna & " en la tabla " & NombreTabla & " del el archivo XML"
                Return False
            End Try

            If blnExiteConlumnaEnXML = False Then
                outSms = "No está especificada la(s) columna(s) " & strColumnaFaltante & " en la tabla " & NombreTabla & " del el archivo XML"
            End If

            Return blnExiteConlumnaEnXML
        End Function

        Private Function ComprobarCampoEspecialTengaValor_XML(FilaXML As DataRow, NombreTabla As String, ByRef outSms As String) As Boolean
            '************************************************************************************************************************************************
            'Permite verificar la existencia de ciertos campos obligatorios que debe contener el archivo XML.
            '************************************************************************************************************************************************
            Dim strSeccion As String = "Working/UsrBajar/ComprobarCampoEspecialTengaValor_XML"

            If Val(FilaXML.Item("_sed_rowid")) = -1 Then
                outSms = "El valor de _sed_rowid no es valido, _sed_rowid=" & Val(FilaXML.Item("_sed_rowid"))
                Return False
            End If
            If FilaXML.Item("tabla") = "" Then
                outSms = "El nombre de tabla no está especificado en el archivo de transferencia XML, _sed_rowid=" & Val(FilaXML.Item("_sed_rowid")) & " tabla " & NombreTabla
                Return False
            End If
            If FilaXML.Item("key_name") = "" Then
                outSms = "El nombre de la clave primaria de la tabla no esta especificada, campo key_name es vacio, _sed_rowid=" & Val(FilaXML.Item("_sed_rowid")) & " tabla " & NombreTabla
                Return False
            End If

            Return True
        End Function

        Private Function ExisteClaveForaneaEnXML(ClavesFaraneasXML As Dictionary(Of String, String), NombreCampoBD As String) As Boolean
            For Each x As KeyValuePair(Of String, String) In ClavesFaraneasXML
                Dim v As String = x.Key
                'NombreFK|RowIdFK|PenId|RegId|Nombre_PK_tablaReferenciada|(opcional/estricto)
                If UCase(Mid(v, 1, v.IndexOf("|"))) = UCase(NombreCampoBD) Then Return True
            Next
            Return False
        End Function

        Private Function NombreCampoPK_EnTablaForanea(ClavesFaraneasXML As Dictionary(Of String, String), NombreCampoFK_XML As String) As String
            'permite retornar el nombre de la campo clave primaria de la tabla referenciada en funcion a la relacion FK local, dado que el nombre del FK_local y PK_referenciado pueden ser diferentes
            For Each x As KeyValuePair(Of String, String) In ClavesFaraneasXML
                Dim s As String()
                s = Split(x.Key, "|")
                If UCase(s(0)) = UCase(NombreCampoFK_XML) Then Return s(2) 'Mid(v, v.IndexOf("|") + 2, v.LastIndexOf("|") - v.IndexOf("|") - 1)
            Next
            Return ""
        End Function

        Private Function NombreCampoFK_Local(ClavesFaraneasXML As Dictionary(Of String, String), NombreCampoBD As String) As String
            'retorna el nombre del campo FK de la tabla local
            Dim s As String = ""
            For Each x As KeyValuePair(Of String, String) In ClavesFaraneasXML
                Dim v As String = x.Key
                If UCase(Mid(v, 1, v.IndexOf("|"))) = UCase(NombreCampoBD) Then
                    s = UCase(Mid(v, 1, v.IndexOf("|")))
                    Exit For
                End If
            Next
            Return s
        End Function

        Private Function NombreTablaForanea(ClavesFaraneasXML As Dictionary(Of String, String), NombreCampoBD As String) As String
            'retorna el nombre del campo FK de la tabla local
            For Each x As KeyValuePair(Of String, String) In ClavesFaraneasXML
                Dim v As String = x.Key
                Dim strNomTablaForanea As String = x.Value
                strNomTablaForanea = Mid(strNomTablaForanea, 5)
                strNomTablaForanea = Mid(strNomTablaForanea, strNomTablaForanea.IndexOf("_") + 2)
                If UCase(Mid(v, 1, v.IndexOf("|"))) = UCase(NombreCampoBD) Then Return strNomTablaForanea
            Next
            Return ""
        End Function

        Private Function ActualizarTransferenciaID_x_SedRowId(ColumnaPK_EnTablaForanea As String, IdForanea As Integer, NombreTablaForanea As String, ByRef sms As String) As Integer
            '*******************************************************************************************************************************************
            ' Permite actualizar las claves foraneas transferidas a claves foraneas locales
            ' Parametros
            '       NombreTablaForanea: Nombre de la tabla foranea
            '       IdFK: Clave primaria de la tabla foranea, el cual viene a ser clave foranea en la tabla local.
            '*******************************************************************************************************************************************
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Dim value As Integer = -1
            Dim intCant As Integer = 0
            Dim sql As String = ""
            Try
                sql = "select " & ColumnaPK_EnTablaForanea & " from " & NombreTablaForanea & " where _sed_rowid=" & IdForanea
                sqlCmd = New SqlCommand(sql, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader
                If sqlReader.HasRows Then
                    While sqlReader.Read
                        intCant = intCant + 1
                        value = sqlReader(ColumnaPK_EnTablaForanea).ToString
                    End While
                End If
                If intCant > 1 Then
                    sms = "La consulta (" & sql & "), devuelve mas de un registro"
                    value = -1
                End If
                If intCant = 0 Then
                    sms = "La consulta (" & sql & "), no devuelve ningun registro"
                    value = -1
                End If
            Catch ex As Exception
                value = -1
                Throw New Exception("Working/UsrBajar/ActualizarTransferenciaID: " & ex.ToString)
            Finally
                If Not sqlReader Is Nothing Then
                    If Not sqlReader.IsClosed Then sqlReader.Close()
                End If
                If Not sqlCon Is Nothing Then
                    If sqlCon.State = ConnectionState.Open Then sqlCon.Close()
                End If
            End Try
            Return value
        End Function

        Private Function ObtenerIDRegistroXSedeRowId(NombreTabla As String, nomColPK As String, _RowID As Integer, _SedRowId As Integer, RegionID As Integer, PenalID As Integer, ByRef outSMS As String) As Integer
            '*******************************************************************************************************************************************
            ' Verifica la existencia de registros por el _RowId en la base de datos local, para determinar la accion de Insert o Update a ejecutarse.
            '*******************************************************************************************************************************************
            Dim sqlReader As SqlDataReader = Nothing
            Dim Id As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Dim sql As String = ""

            Try
                If _SedRowId > 0 And _RowID > 0 Then
                    sql = "select " & nomColPK & " from " & NombreTabla & " where _sed_rowid=" & _SedRowId & " and _RowId=" & _RowID
                ElseIf _SedRowId > 0 And _RowID < 0 Then
                    sql = "select " & nomColPK & " from " & NombreTabla & " where _sed_rowid=" & _SedRowId
                End If

                sqlCmd = New SqlCommand(sql, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader
                If sqlReader.HasRows Then
                    Dim cantReg As Integer = 0
                    While sqlReader.Read
                        cantReg = cantReg + 1
                        Id = sqlReader(nomColPK)
                    End While
                    If cantReg > 1 Then
                        outSMS = "La siguiente consulta (" & sql & ") ha devuelto mas de un registro en la base de datos local, tome nota del error y comunique a soporte."
                        Id = -100
                    End If
                End If
            Catch ex As Exception
                outSMS = ex.Message & ", no se pudo ejecutar " & sql & ", tome nota del error y comunique a soporte."
                Id = -100
            Finally
                Try
                    sqlReader.Close()
                    sqlCon.Close()
                    sqlCmd.Dispose()
                Catch ex As Exception
                End Try
            End Try
            Return Id
        End Function

        Private Function EjecutarSentencia(SQL As String) As Integer
            Dim id As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCmd = New SqlCommand(SQL, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = sqlCmd.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Error al ejecutar funcion UscBajar/EjecutarSentencia: " & ex.ToString & ", SQL:" & SQL)
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
            End Try
            Return id
        End Function

#End Region

        Private Function ExisteFilaDuplicadaEnTablaBD_x_SedRowId(filaTabla As DataRow, NombreTablaBD As String) As Boolean
            '*******************************************************************************************************************************************
            ' verificar que no existan duplicados por _sed_rowid, _PenId, _RegId
            '*******************************************************************************************************************************************
            Dim intCantFilas As Integer = 0
            Dim strSql As String = ""
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Try
                strSql = "select _sed_rowid from " & NombreTablaBD & " where _sed_rowid=" & filaTabla.Item("_sed_rowid").ToString
                sqlCmd = New SqlCommand(strSql, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()

                sqlReader = sqlCmd.ExecuteReader
                If sqlReader.HasRows Then
                    While sqlReader.Read
                        intCantFilas = intCantFilas + 1
                    End While
                    If intCantFilas > 1 Then Return True 'existe mas de un registro duplicado
                Else 'no existe ningun registro
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception("UscBajar/ExisteFilaDuplicadaEnTablaBD: Excepcion al verificar filas duplicadas por _sed_rowid en la tabla " & NombreTablaBD & " Excepcion:" & ex.ToString)
            Finally
                sqlReader.Close()
                sqlCon.Close()
                sqlCmd.Dispose()
            End Try
            Return False
        End Function

        Public Sub New(n_regid As Integer, n_penid As Integer)
            Me.RegionId = n_regid
            Me.PenalId = n_penid
        End Sub
    End Class
End Namespace