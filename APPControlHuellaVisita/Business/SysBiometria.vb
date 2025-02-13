Imports Suprema
Imports ScanAPIHelper
Namespace Business
    Public Class SysBiometria
        Private bssTmpl As Business.Bss_HuellaTemplate
        Private bssWsq As Business.Bss_HuellaWSQ
        Private c_cnBD As String = ""

        Public Sub New(cnBD As String)
            Me.c_cnBD = cnBD
        End Sub

#Region "Validacion"
        Private Function ValidarPlantilla(Tmpl As Byte(), TipoTemplate As Type.Enumeracion.TipoPlantilla, ByRef out_sms As String) As Boolean
            Dim v As Boolean = True

            If Tmpl Is Nothing Then
                out_sms = "Plantilla de huella vacia"
                Return False
            End If

            Select Case TipoTemplate
                Case Type.Enumeracion.TipoPlantilla.ISO19794_2
                    out_sms = "El tipo de plantilla ISO19794 no está soportado"
                    v = False
                Case Type.Enumeracion.TipoPlantilla.NoEspecificado
                    out_sms = "Tipo de plantilla no especificado, plantillas soportados ANSI378=2, SUPREMA=0"
                    v = False
            End Select

            Return v
        End Function
#End Region

#Region "Funciones_RealScanG1"
        'retorna Id de template_huella coincidente
        Public Function VerificarHuella(TipoDoc As Integer, NumDoc As String, Tmpl As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, _
                                        TipoTmpl As Type.Enumeracion.TipoPlantilla, ratioAceptacion As Type.Enumeracion.enumRSE_NivelSeguridad, _
                                        ByRef outListIdRptaTemplate As List(Of Integer), ByRef out_sms As String) As String

            '-------------------- validar -----------------------> 
            If ValidarPlantilla(Tmpl, TipoTmpl, out_sms) = False Then Return -1

            If TipoDoc <= 0 Or NumDoc = "" Then
                out_sms = "Debe especificar el tipo y número de documento de identidad"
                Return -1
            End If

            If TipoDedo = Type.Enumeracion.TipoDedo.NoEspecificado Then
                out_sms = "Tipo de dedo no especificado"
                Return -1
            End If
            '<-----------------------------------------------------

            Dim str_idmatch As String = ""
            Dim entTmpl As New Entity.Ent_HuellaTemplate
            Dim tmlCol As New Entity.HuellaTemplateCol

            entTmpl.DocTipoId = TipoDoc
            entTmpl.NumDocumento = NumDoc
            entTmpl.TipoDedoId = TipoDedo

            tmlCol = Data.Dat_HuellaTemplate.Listar("lst", "lst_mant", Me.c_cnBD, entTmpl, out_sms) 'retorna todos los templates que coincidan con el tipDoc y numDoc.
            If tmlCol.Count = 0 Then 'no existe huellas(templates)
                out_sms = "Huella no encontrada, no existe huella registrada"
                Return 0
            End If

            Dim blnEncontrado As Boolean = False
            For Each obj As Entity.Ent_HuellaTemplate In tmlCol
                blnEncontrado = False

                Select Case TipoTmpl
                    Case Type.Enumeracion.TipoPlantilla.Suprema

                        If RSE_VerifyTemplateEx(obj.TemplatePropietario, obj.TemplatePropietario.Length, Tmpl, Tmpl.Length, TipoTmpl, ratioAceptacion) = RSE_SUCCESS Then
                            blnEncontrado = True
                        End If

                    Case Type.Enumeracion.TipoPlantilla.ANSI378

                        If RSE_VerifyTemplateEx(obj.TemplateANSI, obj.TemplateANSI.Length, Tmpl, Tmpl.Length, TipoTmpl, ratioAceptacion) = RSE_SUCCESS Then
                            blnEncontrado = True
                        End If

                End Select

                If blnEncontrado = True Then
                    outListIdRptaTemplate.Add(obj.Codigo)
                End If

            Next

            Return 0
        End Function

        'retorna array de enteros con los Id de template_huella coincidentes, implementacion de identificacion API SUPREMA
        Public Function Identificar(Tmpl As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, _
                                    filtrarPorDedo As Boolean, ByRef outListIdRptaTemplate As List(Of Integer), _
                                    ratioFalsaAcept As Type.Enumeracion.enumRSE_NivelSeguridad, ByRef outSms As String) As Integer

            If Tmpl Is Nothing Then
                outSms = "Plantilla de huella vacia"
                Return -1
            End If
            If TipoDedo = Type.Enumeracion.TipoDedo.NoEspecificado Then
                outSms = "Tipo de dedo no especificado"
                Return -1
            End If

            Dim n_rpta As Integer

            Dim entTmpl As New Entity.Ent_HuellaTemplate
            Dim tmlCol As DataTable

            If filtrarPorDedo = True Then entTmpl.TipoDedoId = TipoDedo

            tmlCol = Data.Dat_HuellaTemplate.Identificar("lst", "lst_identificar_suprema", c_cnBD, entTmpl, "", outSms) 'optimizar para la carga solo del template a identificar
            If tmlCol.Rows.Count = 0 Then 'no existe huellas(templates)
                outSms = "Huella no identificada."
                Return 0
            End If

            n_rpta = IdentificarTemplate_suprema(Tmpl, tmlCol, ratioFalsaAcept, outListIdRptaTemplate, outSms)

            Return n_rpta
        End Function

        Public Function Identificar(bytTemplate As Byte(), TipoTmpl As Type.Enumeracion.TipoPlantilla, TipoDedo As Type.Enumeracion.TipoDedo, _
                                    blnFiltrarxDedo As Boolean, ByRef lstOutIDRptaTemplate As List(Of Integer), _
                                    ratioFalsaAcept As Type.Enumeracion.enumRSE_NivelSeguridad, lstBuscarTemplIds As List(Of Integer),
                                    ByRef strOutSms As String) As Integer

            If bytTemplate Is Nothing Then
                strOutSms = "Plantilla de huella vacia"
                Return -1
            End If

            If TipoDedo = Type.Enumeracion.TipoDedo.NoEspecificado Then
                strOutSms = "Tipo de dedo no especificado"
                Return -1
            End If

            If lstBuscarTemplIds Is Nothing OrElse lstBuscarTemplIds.Count = 0 Then
                strOutSms = "No envió ningún id de template como array."
                Return -1
            End If

            Dim strTmplIds As String = ""

            For Each i As Integer In lstBuscarTemplIds
                strTmplIds = strTmplIds & "," & i
            Next
            strTmplIds = strTmplIds.Substring(1, strTmplIds.Length() - 1)

            Dim n_rpta As Integer = -1

            Dim entTmpl As New Entity.Ent_HuellaTemplate
            Dim tmlCol As DataTable

            If blnFiltrarxDedo = True Then
                entTmpl.TipoDedoId = TipoDedo
            End If

            Select Case TipoTmpl

                Case Type.Enumeracion.TipoPlantilla.ANSI378

                    tmlCol = Data.Dat_HuellaTemplate.Identificar("lst", "lst_identificar_ansi", c_cnBD, entTmpl, strTmplIds, strOutSms) 'optimizar para la carga solo del template a identificar

                Case Type.Enumeracion.TipoPlantilla.Suprema

                    tmlCol = Data.Dat_HuellaTemplate.Identificar("lst", "lst_identificar_suprema", c_cnBD, entTmpl, strTmplIds, strOutSms) 'optimizar para la carga solo del template a identificar

            End Select

            If tmlCol.Rows.Count = 0 Then 'no existe huellas(templates)
                strOutSms = "Huella no identificada."
                Return 0
            End If

              Select TipoTmpl

                Case Type.Enumeracion.TipoPlantilla.ANSI378

                    n_rpta = IdentificarTemplate_ansi(bytTemplate, tmlCol, ratioFalsaAcept, lstOutIDRptaTemplate, strOutSms)

                Case Type.Enumeracion.TipoPlantilla.Suprema

                    n_rpta = IdentificarTemplate_suprema(bytTemplate, tmlCol, ratioFalsaAcept, lstOutIDRptaTemplate, strOutSms)

            End Select

            Return n_rpta
        End Function

        Private Function IdentificarTemplate_suprema(Template As Byte(), objDtTemplate As DataTable, _
                                                     ratioFalsaAcept As Integer, ByRef outListIdRptaTemplate As List(Of Integer), ByRef outSms As String) As Integer
            Dim ufm_res As UFM_STATUS
            Dim m_Matcher As New UFMatcher
            Dim IdentifySucceed As Long
            Dim i As Long

            m_Matcher.SecurityLevel = ratioFalsaAcept
            m_Matcher.nTemplateType = Suprema.UFM_TEMPLATE_TYPE.UFM_TEMPLATE_TYPE_SUPREMA 'solo soporta suprema

            ufm_res = m_Matcher.IdentifyInit(Template, Template.Length)
            If (ufm_res <> UFM_STATUS.OK) Then
                outSms = "Ocurrio un error interno al identificar template, CodError:" & ufm_res
                Return -1
            End If
            IdentifySucceed = 0
            For i = 0 To objDtTemplate.Rows.Count - 1
                ufm_res = m_Matcher.IdentifyNext(objDtTemplate.Rows(i).Item("tmp_prop"), CType(objDtTemplate.Rows(i).Item("tmp_prop"), Byte()).Length, IdentifySucceed)
                If (ufm_res = UFM_STATUS.OK) Then
                    If IdentifySucceed <> 0 Then
                        outListIdRptaTemplate.Add(objDtTemplate.Rows(i).Item("pk_tmp_id"))
                    End If
                End If
            Next

            Return 0
        End Function

        Private Function IdentificarTemplate_ansi(Template As Byte(), objDtTemplate As DataTable, _
                                                      ratioAceptacion As Type.Enumeracion.enumRSE_NivelSeguridad,
                                                      ByRef lstOutIDRptaTemplate As List(Of Integer), ByRef strOutSms As String) As Integer

            For Each fila As DataRow In objDtTemplate.Rows

                If RSE_VerifyTemplateEx(fila.Item("tmp_ansi"), CType(fila.Item("tmp_ansi"), Byte()).Length, Template, Template.Length,
                                        Type.Enumeracion.TipoPlantilla.ANSI378, ratioAceptacion) = RSE_SUCCESS Then

                    lstOutIDRptaTemplate.Add(fila.Item("pk_tmp_id"))

                End If
            Next

            Return 0
        End Function

#End Region

#Region "Funciones_FS10"

        Public Function VerificarHuellaFS10(intTipoDoc As Integer, strNumDoc As String, bytTmpl As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, _
                                        enmTipoTmpl As Type.Enumeracion.TipoPlantilla, enmfMatchScore As Type.Enumeracion.enumfMatchScore, _
                                        ByRef lstOutListIdRptaTemplate As List(Of Integer), ByRef strOut_sms As String) As Short

            Dim value As Short = -1

            '-------------------- validar -----------------------> 
            If ValidarPlantilla(bytTmpl, enmTipoTmpl, strOut_sms) = False Then
                Return value
            End If

            If intTipoDoc <= 0 Or strNumDoc = "" Then
                strOut_sms = "Debe especificar el tipo y número de documento de identidad"
                Return value
            End If

            If TipoDedo = Type.Enumeracion.TipoDedo.NoEspecificado Then
                strOut_sms = "Tipo de dedo no especificado"
                Return value
            End If
            '<-----------------------------------------------------

            Dim objEntFiltro As New Entity.Ent_HuellaTemplate
            Dim objEntTemplateCol As New Entity.HuellaTemplateCol

            With objEntFiltro
                .DocTipoId = intTipoDoc
                .NumDocumento = strNumDoc
                .TipoDedoId = TipoDedo
            End With

            objEntTemplateCol = Data.Dat_HuellaTemplate.Listar("lst", "lst_mant", Me.c_cnBD, objEntFiltro, strOut_sms) 'retorna todos los templates que coincidan con el tipDoc y numDoc.
            If objEntTemplateCol.Count = 0 Then 'no existe huellas(templates)
                strOut_sms = "Huella no encontrada, no existe huella registrada"
                Return value
            End If

            Dim blnEncontrado As Boolean = False

            For Each obj As Entity.Ent_HuellaTemplate In objEntTemplateCol
                blnEncontrado = False
                Select Case enmTipoTmpl
                    Case Type.Enumeracion.TipoPlantilla.Suprema

                    Case Type.Enumeracion.TipoPlantilla.ANSI378

                        Dim m_hDevice As New Device
                        Dim score As Double = 0

                        m_hDevice.Open()

                        score = m_hDevice.MatchAnsiTemplates(bytTmpl, obj.TemplateANSI)
                        If (score >= enmfMatchScore) Then
                            strOut_sms = "LAS HUELLAS COINCIDEN. Score:" + score.ToString
                            blnEncontrado = True
                            value = 0
                        Else
                            strOut_sms = "LAS HUELLAS NO COINCIDEN. Score:" + score.ToString
                        End If

                End Select

                If blnEncontrado = True Then
                    lstOutListIdRptaTemplate.Add(obj.Codigo)
                End If

            Next

            Return value

        End Function

        Public Function IdentificarFS10(bytTemplate As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, _
                                    blnFiltrarxDedo As Boolean, enmfMatchScore As Type.Enumeracion.enumfMatchScore,
                                    ByRef lstOutListIdRptaTemplate As List(Of Integer), lstBuscarTemplIds As List(Of Integer),
                                    ByRef outSms As String) As Short

            If bytTemplate Is Nothing Then
                outSms = "Plantilla de huella vacia"
                Return -1
            End If

            If TipoDedo = Type.Enumeracion.TipoDedo.NoEspecificado Then
                outSms = "Tipo de dedo no especificado"
                Return -1
            End If

            If lstBuscarTemplIds Is Nothing OrElse lstBuscarTemplIds.Count = 0 Then
                outSms = "No envió ningún id de template como array."
                Return -1
            End If

            Dim strTmplIds As String = ""

            For Each i As Integer In lstBuscarTemplIds
                strTmplIds = strTmplIds & "," & i
            Next

            strTmplIds = strTmplIds.Substring(1, strTmplIds.Length() - 1)

            Dim value As Short = -1

            Dim objEntTmpl As New Entity.Ent_HuellaTemplate
            Dim dtTemplateCol As DataTable

            If blnFiltrarxDedo = True Then
                objEntTmpl.TipoDedoId = TipoDedo
            End If

            dtTemplateCol = Data.Dat_HuellaTemplate.Identificar("lst", "lst_identificar_ansi", c_cnBD, objEntTmpl, strTmplIds, outSms) 'optimizar para la carga solo del template a identificar

            If dtTemplateCol.Rows.Count = 0 Then 'no existe huellas(templates)
                outSms = "Huella no identificada."
                Return value
            End If

            value = IdentificarTemplate_Ansi(bytTemplate, dtTemplateCol, enmfMatchScore, lstOutListIdRptaTemplate, outSms)

            Return value
        End Function

        Private Function IdentificarTemplate_ansi(bytTemplate As Byte(), objDtTemplate As DataTable, _
                                                     enmfMatchScore As Type.Enumeracion.enumfMatchScore,
                                                     ByRef lstOutIDRptaTemplate As List(Of Integer), ByRef strOutSms As String) As Short

            Dim value As Short = -1
            Dim m_hDevice As New Device
            Dim score As Double = 0
            m_hDevice.Open()

            For Each fila As DataRow In objDtTemplate.Rows

                score = m_hDevice.MatchAnsiTemplates(bytTemplate, fila.Item("tmp_ansi"))
                If (score >= enmfMatchScore) Then

                    lstOutIDRptaTemplate.Add(fila.Item("pk_tmp_id"))
                    value = 0
                End If
            Next

            Return value
        End Function

#End Region

#Region "Funciones_FS60"
        Public Function getCompatibilidadDispositivoId() As Type.Enumeracion.enumTipoDispositivo
            Dim tipDisp As Type.Enumeracion.enumTipoDispositivo = Type.Enumeracion.enumTipoDispositivo.Ninguno
            Dim b As Boolean = False
            Try
                Dim ntip As Integer
                Dim hDevice As New ScanAPIHelperFS60.Device
                hDevice.Open()
                ntip = hDevice.Information.DeviceCompatibility
                Select Case ntip
                    Case 8
                        tipDisp = Type.Enumeracion.enumTipoDispositivo.Futronic_Deca_FS60
                    Case 10
                        tipDisp = Type.Enumeracion.enumTipoDispositivo.FutronicFS10
                    Case 15
                        tipDisp = Type.Enumeracion.enumTipoDispositivo.Futronic_Deca_FS64
                    Case Else
                        tipDisp = Type.Enumeracion.enumTipoDispositivo.Desconocido
                End Select
                hDevice.Close()
                b = True
            Catch ex As Exception
            End Try
            If b = False Then
                MsgBox("Dispositivo biométrico no conectado, por favor conecte en el puerto USB", MsgBoxStyle.Question)
            End If
            Return tipDisp
        End Function 'fdsds

        Public Function ObtenerImagenByteDesdeWSQ(WSQFile As Byte(), ByRef out_sms As String) As Byte()
            Dim bt As Byte()
            Dim ws As New Wsq2Bmp.WsqDecoder
            Try
                bt = ws.wsqToImaganByte(WSQFile)
            Catch ex As Exception
                out_sms = ex.ToString
                Return Nothing
            End Try

            Return bt
        End Function

        Public Function compararTemplateAnsi_futronic(templateAnsiByte_a As Byte(), templateAnsiByte_b As Byte(), ratioFAR As Type.Enumeracion.enumNivelSeguridadFAR, ByRef outSMS As String) As Integer
            Dim nRpta As Integer = 0
            Dim resp As Boolean
            Dim score As Integer

            Try
                Dim h_device As IntPtr
                h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

                resp = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkMatchTemplates(templateAnsiByte_a, templateAnsiByte_b, score)
                If resp = False Then
                    nRpta = -1
                Else
                    Select Case ratioFAR
                        Case Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_HIGH
                            If score >= 37 Then nRpta = 1
                        Case Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_HIGH_MEDIUM
                            If score >= 65 Then nRpta = 1
                        Case Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_LOW
                            If score >= 93 Then nRpta = 1
                        Case Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_LOW_MEDIUM
                            If score >= 121 Then nRpta = 1
                        Case Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_MEDIUM
                            If score >= 146 Then nRpta = 1
                        Case Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_VERY_HIGH
                            If score >= 189 Then nRpta = 1
                        Case Else
                            nRpta = 0
                    End Select
                End If

                Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)

            Catch ex As Futronic.MathAPIHelper.FutronicException
                outSMS = ex.ToString
                nRpta = -1 * ex.ErrorCode
            End Try
            Return nRpta
        End Function

#End Region
#Region "Listar"

        'retorna un unico registro de template por id
        Public Function ListarTemplate(Codigo As Integer, ByRef out_sms As String) As Entity.Ent_HuellaTemplate

            If Codigo <= 0 Then
                out_sms = "Parámetro Id no válido"
                Return Nothing
            End If

            bssTmpl = New Business.Bss_HuellaTemplate(Me.c_cnBD)

            Dim ent As New Entity.Ent_HuellaTemplate
            Dim list As Entity.HuellaTemplateCol

            ent.Codigo = Codigo
            list = ListarTemplate(ent, out_sms)

            Return If(list.Count < 1, Nothing, list.HuellaTemplate(0))

        End Function

        'retorna un conjunto de registros en base a filtro
        Public Function ListarTemplate(EntTmpl As Entity.Ent_HuellaTemplate, ByRef out_sms As String) As Entity.HuellaTemplateCol
            Dim col As New Entity.HuellaTemplateCol

            If EntTmpl Is Nothing Then Return col

            bssTmpl = New Business.Bss_HuellaTemplate(Me.c_cnBD)
            col = bssTmpl.Listar(EntTmpl, out_sms)
            Return col
        End Function

        'retorna un unico registro por id del template
        Public Function ListarWSQ_X_TemplateCod(TemplateId As Integer, ByRef out_sms As String) As Entity.Ent_HuellaWSQ
            If TemplateId <= 0 Then
                out_sms = "Parámetro TemplateId no válido"
                Return Nothing
            End If

            bssWsq = New Business.Bss_HuellaWSQ(Me.c_cnBD)

            Dim list As Entity.HuellaWSQCol

            Dim ent As New Entity.Ent_HuellaWSQ
            ent.HuellaTemplateId = TemplateId

            list = ListarWSQ(ent, out_sms)

            Return IIf(list.Count < 1, Nothing, list.HuellaWSQ(0))
        End Function

        Public Function ListarWSQ(EntWSQ As Entity.Ent_HuellaWSQ, ByRef out_sms As String) As Entity.HuellaWSQCol
            Dim col As New Entity.HuellaWSQCol

            If EntWSQ Is Nothing Then Return col

            bssWsq = New Business.Bss_HuellaWSQ(Me.c_cnBD)

            col = bssWsq.Listar(EntWSQ, out_sms)

            Return col
        End Function

        'retorna array de enteros con los Id de template_huella coincidentes, implementacion PROPIETARIA
        'Public Function IdentificarHuella_v2(Tmpl As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, TipoTmpl As Type.Enumeracion.TipoPlantilla, ByRef out_sms As String) As String
        '    '-------------------- validar -----------------------> 
        '    If Tmpl Is Nothing Then
        '        out_sms = "Plantilla de huella vacia"
        '        Return Nothing
        '    End If
        '    If TipoDedo = Type.Enumeracion.TipoDedo.NoEspecificado Then
        '        out_sms = "Tipo de dedo no especificado"
        '        Return Nothing
        '    End If
        '    '<-----------------------------------------------------

        '    Dim str_tmplId_match As String = ""
        '    Dim int_tot_filas As Integer = 0 'para capturar el numero total de filas que retorna la consulta
        '    Dim int_tot_paginas As Integer = 0 'numero total de paginas (bloques)
        '    Dim filas_x_pagina As Integer = 2000 'numero de registros por pagina

        '    Dim str_tmp As String = ""

        '    Dim entTmpl As New entity.Ent_HuellaTemplate
        '    Dim tmlCol As New entity.HuellaTemplateCol
        '    'entTmpl.TipoDedoId = TipoDedo

        '    int_tot_filas = BMT_Data.Biometria.Dat_HuellaTemplate.ListarOutput("lst", "cant_filas", entTmpl)
        '    If int_tot_filas <= filas_x_pagina Then
        '        int_tot_paginas = 1
        '    Else
        '        int_tot_paginas = ((int_tot_filas - (int_tot_filas Mod filas_x_pagina)) / filas_x_pagina) + 1
        '    End If

        '    If int_tot_filas = 0 Then 'no existe huellas(templates)
        '        out_sms = "No existe huella registrada con el tipo dedo especificado"
        '        Return -1
        '    End If

        '    For i As Integer = 0 To int_tot_paginas - 1
        '        tmlCol = Nothing
        '        tmlCol = New entity.HuellaTemplateCol

        '        Select Case TipoTmpl
        '            Case Type.Enumeracion.TipoPlantilla.Original
        '                tmlCol = BMT_Data.Biometria.Dat_HuellaTemplate.Listar_simple("lst", "lst_mant_suprema", entTmpl, (i * filas_x_pagina + 1), filas_x_pagina, out_sms)
        '            Case Type.Enumeracion.TipoPlantilla.ANSI378
        '                tmlCol = BMT_Data.Biometria.Dat_HuellaTemplate.Listar_simple("lst", "lst_mant_ansi", entTmpl, (i * filas_x_pagina + 1), filas_x_pagina, out_sms)
        '        End Select
        '        str_tmp = IndentificarTemplate_Propietario(Tmpl, tmlCol, TipoTmpl, RSE_SECURITY_1_TO_100000)
        '        If Len(str_tmp) > 0 Then str_tmplId_match = str_tmplId_match & "|" & str_tmp
        '    Next

        '    If Len(str_tmplId_match) > 1 Then : str_tmplId_match = Mid(str_tmplId_match, 2, Len(str_tmplId_match)) : Else : str_tmplId_match = "" : End If

        '    Return str_tmplId_match
        'End Function

        'Public Function IdentificarHuella_Avanzado(Tmpl_huella As Byte(), TipoDedo As Type_biometria.Enumeracion.TipoDedo, TipoTmpl As Type_biometria.Enumeracion.TipoPlantilla, filtrarPorDedo As Boolean, ByRef out_sms As String) As String
        '    '-------------------- validar -----------------------> 
        '    If Tmpl_huella Is Nothing Then
        '        out_sms = "Plantilla de huella vacia"
        '        Return ""
        '    End If
        '    If filtrarPorDedo = True And (TipoDedo = Type_biometria.Enumeracion.TipoDedo.Ninguno Or TipoDedo = Type_biometria.Enumeracion.TipoDedo.NoEspecificado) Then
        '        out_sms = "Tipo de dedo no especificado"
        '        Return out_sms
        '    End If
        '    If TipoTmpl <> Type_biometria.Enumeracion.TipoPlantilla.Original Then
        '        out_sms = "Para la identificación el único formato de plantilla soportado es la propietaria/SUPREMA"
        '        Return ""
        '    End If

        '    Dim int_tot_filas As Integer = 0 'para capturar el numero total de filas que retorna la consulta
        '    Dim int_tot_paginas As Integer = 0 'numero total de paginas (bloques)
        '    Dim filas_x_pagina As Integer = 2000 'numero de registros por pagina

        '    Dim str_tmplId_match As String = ""

        '    Dim entTmpl As New Entity_SolHuellaSede.Biometria.HuellaTemplate
        '    Dim tmlCol_IN As New Entity_SolHuellaSede.Biometria.HuellaTemplateCol
        '    Dim tmlCol_OUT As New Entity_SolHuellaSede.Biometria.HuellaTemplateCol

        '    If filtrarPorDedo = True Then entTmpl.TipoDedoId = TipoDedo

        '    int_tot_filas = Data_SolHuellaSede.Biometria.HuellaTemplate.ListarOutput("lst", "cant_filas", entTmpl)
        '    If int_tot_filas <= filas_x_pagina Then
        '        int_tot_paginas = 1
        '    Else
        '        int_tot_paginas = ((int_tot_filas - (int_tot_filas Mod filas_x_pagina)) / filas_x_pagina) + 1
        '    End If

        '    If int_tot_filas = 0 Then 'no existe huellas(templates)
        '        out_sms = "No existe huella registrada con el tipo dedo especificado"
        '        Return ""
        '    End If

        '    For i As Integer = 0 To int_tot_paginas - 1
        '        tmlCol_IN = Data_SolHuellaSede.Biometria.HuellaTemplate.Listar_simple("lst", "lst_mant_suprema", entTmpl, (i * filas_x_pagina + 1), filas_x_pagina, out_sms)
        '        tmlCol_IN = IdentificarTemplate_Avanzado(Tmpl_huella, tmlCol_IN, 4)
        '        For Each obj As Entity_SolHuellaSede.Biometria.HuellaTemplate In tmlCol_IN
        '            tmlCol_OUT.Add(obj)
        '        Next
        '    Next

        '    If tmlCol_OUT.Count > 1 Then
        '        For i As Integer = 5 To 7
        '            Dim tmlCol_aux As New Entity_SolHuellaSede.Biometria.HuellaTemplateCol

        '            tmlCol_aux = tmlCol_OUT

        '            tmlCol_OUT = IdentificarTemplate_Avanzado(Tmpl_huella, tmlCol_OUT, i)

        '            If tmlCol_OUT.Count = 1 Then Exit For

        '            If tmlCol_OUT.Count = 0 Then
        '                tmlCol_OUT = tmlCol_aux
        '                Exit For
        '            End If
        '        Next
        '    End If

        '    '----------------------------------- concatenar resultados de match ------------------------------
        '    For Each x As Entity_SolHuellaSede.Biometria.HuellaTemplate In tmlCol_OUT
        '        str_tmplId_match = str_tmplId_match & "|" & x.Codigo & " " & x.NumDocumento & "_" & x.Observacion & vbCrLf
        '    Next

        '    Return str_tmplId_match
        'End Function
#End Region

#Region "Grabar"
        Public Function GrabarHuella(EntTmpl As Entity.Ent_HuellaTemplate, EntWSQ As Entity.Ent_HuellaWSQ, IdUsuario As Integer, ByRef out_sms As String) As Integer

            bssTmpl = New Business.Bss_HuellaTemplate(Me.c_cnBD)
            bssWsq = New Business.Bss_HuellaWSQ(Me.c_cnBD)

            Dim accion As String = ""
            Dim opcion As String = ""
            Dim id_tmpl As Integer = -1

            id_tmpl = bssTmpl.Grabar(EntTmpl, EntWSQ, IdUsuario, out_sms)
            Return id_tmpl
        End Function

        'fs60
        Public Function GrabarHuella(idTemplate As Integer, tipCapturaHuella As Type.Enumeracion.enmTipoCapturaHuella, tipoDedo As Type.Enumeracion.TipoDedo,
                                     tipDispBio As Type.Enumeracion.enumTipoDispositivo, tmplAnsi As Byte(), _
                                         wsq As Byte(), anchoImgPx As Integer, largoImgPx As Integer, IndiceCalidadImg As Type.Enumeracion.IndiceCalidadHuella,
                                         estDedo As Type.Enumeracion.EstadoDedo, Obs As String, _
                                         tipDoIdent As Integer, numDocIdent As String, CodRp As String, ApePat As String, ApeMat As String, nomInt As String, _
                                         regId As Integer, penId As Integer, idUser As Integer, ByRef out_sms As String) As Integer
            'fs60

            If Me.c_cnBD = "" Then
                out_sms = "No es posible establecer conexión con la base de datos de las huellas."
                Return -1
            End If

            Dim bssHuella As New Business.Bss_HuellaTemplate(Me.c_cnBD)

            Dim tmp As New Entity.Ent_HuellaTemplate
            If idTemplate > 0 Then
                tmp.Codigo = idTemplate
                tmp = ListarTemplate(idTemplate, out_sms)
            End If
            With tmp
                .TipoDedoId = tipoDedo
                .DispBiometricoId = tipDispBio
                .TemplatePropietario = Nothing
                .TemplateANSI = tmplAnsi
                .NombrePC = ""
                .MacPC = ""
                .IndiceCalidadImg = IndiceCalidadImg
                .EstadoDedo = estDedo
                .Observacion = Obs
                .RegionId = regId
                .PenalId = penId
                .TipoCapturaHuella = tipCapturaHuella
                .DocTipoId = tipDoIdent
                .NumDocumento = numDocIdent
                .ApellidoPaterno = ApePat
                .ApellidoMaterno = ApeMat
                .Nombres = nomInt
                .CodigoRP = CodRp
            End With

            Dim entWsq As New Entity.Ent_HuellaWSQ

            If idTemplate > 0 Then
                entWsq.HuellaTemplateId = idTemplate
                Try
                    entWsq = (New Business.Bss_HuellaWSQ(c_cnBD)).Listar(entWsq, "").HuellaWSQ(0)
                Catch ex As Exception
                End Try
                If entWsq Is Nothing Then
                    entWsq = New Entity.Ent_HuellaWSQ
                    entWsq.HuellaTemplateId = idTemplate
                End If
            Else
                entWsq.HuellaTemplateId = -1
            End If
         
            entWsq.WSQFile = wsq
            entWsq.RegionId = regId
            entWsq.PenalId = penId
            entWsq.AnchoImagenPX = anchoImgPx
            entWsq.LargoImagenPX = largoImgPx

            Dim id As Integer = -1

            id = bssHuella.Grabar(tmp, entWsq, idUser, out_sms)

            Return id
        End Function
#End Region
        
    End Class
End Namespace