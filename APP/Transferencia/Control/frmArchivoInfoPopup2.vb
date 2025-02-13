Option Explicit On
Imports System.IO
Imports Ionic.Zip

Namespace Transferencia.Control
    Public Class frmArchivoInfoPopup2
        Private objBss As Bussines.Transferencia.ArchivoInfo2 = Nothing
        Private objEntCol As Entity.Transferencia.ArchivoInfo2Col = Nothing
        Private blnComboAnio As Boolean = False
#Region "Propiedades_Parametricas"
        Private intpRegionID As Integer = -1
        Private intpPenalID As Integer = -1
        Public Property _pRegionID() As Integer
            Get
                Return intpRegionID
            End Get
            Set(ByVal value As Integer)
                intpRegionID = value
            End Set
        End Property
        Public Property _pPenalID() As Integer
            Get
                Return intpPenalID
            End Get
            Set(ByVal value As Integer)
                intpPenalID = value
            End Set
        End Property
        Public Property _pRegionNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value
            End Set
        End Property
        Public Property _pPenalNombre() As String
            Get
                Return Me.txtPenal.Text
            End Get
            Set(ByVal value As String)
                Me.txtPenal.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_grilla"
        'col_id_arch
        Private ReadOnly Property Grilla_IdArchivo() As String
            Get
                Return dgw_detalle.Item("col_id_arch", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        Private ReadOnly Property Grilla_NombreArchivo() As String
            Get
                Return dgw_detalle.Item("col_nom_arch", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        Private ReadOnly Property Grilla_FechaDesde() As Long
            Get
                Return dgw_detalle.Item("col_fec_desde", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        Private ReadOnly Property Grilla_FechaHasta() As Long
            Get
                Return dgw_detalle.Item("col_fec_hasta", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        Private ReadOnly Property Grilla_PathArchivo() As String
            Get
                Return dgw_detalle.Item("col_path_arch", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        Public ReadOnly Property Grilla_Licencia() As Integer
            Get
                Return dgw_detalle.Item("col_licencia", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        Public ReadOnly Property Grilla_Correlativo() As Integer
            Get
                Return dgw_detalle.Item("col_correlativo", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        Public ReadOnly Property Grilla_GrupoPaquete() As Integer
            Get
                Return dgw_detalle.Item("col_tip_paq", dgw_detalle.CurrentRow.Index).Value
            End Get
        End Property
        '
#End Region
#Region "propiedades privadas"
        Private Property NumeroMes() As Integer
            Get
                Dim intVal As Integer = 0
                Select Case cbbMes.Text
                    Case "Enero"
                        intVal = 1
                    Case "Febrero"
                        intVal = 2
                    Case "Marzo"
                        intVal = 3
                    Case "Abril"
                        intVal = 4
                    Case "Mayo"
                        intVal = 5
                    Case "Junio"
                        intVal = 6
                    Case "Julio"
                        intVal = 7
                    Case "Agosto"
                        intVal = 8
                    Case "Setiembre"
                        intVal = 9
                    Case "Octubre"
                        intVal = 10
                    Case "Noviembre"
                        intVal = 11
                    Case "Diciembre"
                        intVal = 12
                End Select
                Return intVal
            End Get
            Set(value As Integer)
                Dim strMes As String = ""
                Select Case value
                    Case 1
                        strMes = "Enero"
                    Case 2
                        strMes = "Febrero"
                    Case 3
                        strMes = "Marzo"
                    Case 4
                        strMes = "Abril"
                    Case 5
                        strMes = "Mayo"
                    Case 6
                        strMes = "Junio"
                    Case 7
                        strMes = "Julio"
                    Case 8
                        strMes = "Agosto"
                    Case 9
                        strMes = "Setiembre"
                    Case 10
                        strMes = "Octubre"
                    Case 11
                        strMes = "Noviembre"
                    Case 12
                        strMes = "Diciembre"
                End Select
                cbbMes.Text = strMes
            End Set
        End Property

        Private Property Anio() As Integer
            Get
                Return Val(cbbAnio.Value)
            End Get
            Set(value As Integer)
                cbbAnio.Value = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()
            Dim sms As String = ""
            If Me._pRegionID < 1 Or Me._pPenalID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Transferencia.ArchivoInfo2
            objEntCol = New Entity.Transferencia.ArchivoInfo2Col

            Dim blnVerSede As Boolean = False
            If Legolas.LBusiness.Globall.WinApp.LicenciaApp() = 1 Then
                blnVerSede = True
            End If

            objEntCol = objBss.ListarArchivoTransferencia_ws(blnVerSede, -1, Me._pRegionID, Me._pPenalID, Me.Anio, Me.NumeroMes, sms)

            If sms <> "" Then
                Legolas.Configuration.Aplication.MessageBox.Information(sms)
                Exit Sub
            End If
            With Me.dgw_detalle
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()

            'Dim strMensaje As String = ""
            'strMensaje = "El Penal tiene implementado la transferencia version 7?"

            'If MessageBox.Show(strMensaje, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AEliminarFull()
            'Else
            '    AEliminarLite()
            'End If

        End Sub
        Private Sub AEliminarLite()

            If dgw_detalle.Rows.Count < 1 Then Exit Sub
            Dim strMensajeOut As String = ""
            objBss = New Bussines.Transferencia.ArchivoInfo2

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Confirma eliminar el registro seleccionado?") = Windows.Forms.DialogResult.Yes Then

                Dim strScriptSql As String
                strScriptSql = fn_CrearQueryUpdate()

                Me.Cursor = Cursors.WaitCursor

                If objBss.EliminarArchivo(Grilla_IdArchivo, Grilla_NombreArchivo, Me.Grilla_GrupoPaquete, strMensajeOut) = -1 Then

                    Legolas.Configuration.Aplication.MessageBox.Information("No se pudo eliminar el registro:" & strMensajeOut)

                Else

                    If strScriptSql.Length > 0 Then
                        Dim frm As New Transferencia.Control.frmShowSqlPopup
                        With frm
                            ._RegionNombre = Me._pRegionNombre
                            ._PenalNombre = Me._pPenalNombre
                            ._sms = strScriptSql
                            If .ShowDialog = True Then

                            End If
                        End With
                    End If

                    Listar()

                End If
                Me.Cursor = Cursors.Default
            End If

        End Sub
        Private Sub AEliminarFull()

            If dgw_detalle.Rows.Count < 1 Then Exit Sub
            Dim strMensajeOut As String = ""
            objBss = New Bussines.Transferencia.ArchivoInfo2

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Confirma eliminar el registro seleccionado?") = Windows.Forms.DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                If objBss.EliminarArchivo(Me._pRegionID, Me._pPenalID, Grilla_IdArchivo, Grilla_NombreArchivo, Me.Grilla_Correlativo, Me.Grilla_GrupoPaquete,
                                          fn_CrearQueryUpdateTipo, strMensajeOut) = True Then

                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Listar()
                Else
                    Legolas.Configuration.Aplication.MessageBox.Information("No se pudo eliminar el registro:" & strMensajeOut)
                End If
                Me.Cursor = Cursors.Default
            End If

        End Sub

#End Region
#Region "Form"
        Private Sub FRM_LeerXML()

            Me.Cursor = Cursors.WaitCursor

            If Me.dgw_detalle.RowCount < 1 Then
                Exit Sub
            End If

            Dim CodArchivoTransfer As Integer = Me.Grilla_IdArchivo
            Dim strNomArch As String = Me.Grilla_NombreArchivo
            Dim frm As New Transferencia.Control.frmLectorXML(CodArchivoTransfer, strNomArch)
            With frm
                'permisos 
                ._FormEscritura = Me._FormEscritura
                ._FormReporte = Me._FormReporte
                ._FormEliminar = Me._FormEliminar
                .ShowDialog()
            End With

            Me.Cursor = Cursors.Default

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlGrabar.Visible = Me._FormEscritura
            Me._FormReporte = Me._FormReporte

        End Sub

        Private Function getPassZip(NomFile As String) As String
            'Dim pas As String = ""

            'Dim cad As String() = NomFile.Split("_")

            'Dim regId As Integer
            'Dim penId As Integer
            'Dim anio As Integer

            'regId = Mid(cad(0), 1, 2)
            'penId = Mid(cad(0), 3)

            'anio = Mid(cad(2), 1, 4)


            'pas = NomFile & "|1np3@POPEtrf|" & penId & regId & "|" & anio
            'Return pas
            Dim pas As String = ""

            Dim cad As String() = NomFile.Split("_")

            Dim regId As Integer
            Dim penId As Integer
            Dim anio As Integer
            If cad(0) = "PACK" Then
                regId = Mid(cad(1), 1, 2)
                penId = Mid(cad(1), 3)

                anio = DateTime.FromFileTime(cad(3)).Year
            Else
                regId = Mid(cad(0), 1, 2)
                penId = Mid(cad(0), 3)

                anio = Mid(cad(3), 1, 4)
            End If


            pas = NomFile & "|1np3@POPEtrf|" & penId & regId & "|" & anio
            Return pas
        End Function

        Private Function DesZipear(ByVal FilePath As FileInfo) As Boolean
            Dim value As Boolean = True
            Dim intentoFallido As Boolean = False
            Try
                Dim zip1 As New ZipFile(FilePath.FullName)
                Try
                    'primer intento con nueva
                    Dim cad As String
                    cad = FilePath.Name
                    cad = cad.Replace(FilePath.Extension, "")


                    zip1.Password = getPassZip(cad)
                    zip1.Encryption = EncryptionAlgorithm.WinZipAes256
                    zip1.ExtractAll(My.Computer.FileSystem.CurrentDirectory, ExtractExistingFileAction.OverwriteSilently)
                    zip1.Dispose()
                Catch ex As Exception
                    intentoFallido = True
                    zip1.Dispose()
                End Try

                If intentoFallido = True Then 'segundo intento en caso fallo el primero
                    Dim zip As New ZipFile(FilePath.FullName)
                    zip.Password = "Z1pP0p3"
                    zip.ExtractAll(My.Computer.FileSystem.CurrentDirectory, ExtractExistingFileAction.OverwriteSilently)
                    zip.Dispose()
                End If
            Catch ex As Exception
                value = False
            End Try
            Return value
        End Function

        Private Sub HabilitarBotones()


            Dim blnEscritura As Boolean = Me._FormEscritura
            Dim blnEliminar As Boolean = Me._FormEliminar

            If Me._FormEscritura = True Then

                If Legolas.LBusiness.Globall.WinApp.LicenciaApp() = 1 Then
                    If Legolas.Configuration.Usuario.OficinaID <> 1 Then 'oficina de sistemas
                        blnEscritura = False
                    End If
                Else
                    blnEscritura = False
                End If
            End If

            If Me._FormEliminar = True Then

                If Legolas.LBusiness.Globall.WinApp.LicenciaApp() = 1 Then
                    If Legolas.Configuration.Usuario.OficinaID <> 1 Then 'oficina de sistemas
                        blnEliminar = False
                    End If
                Else
                    blnEliminar = False
                End If
            End If

            Me.pnlGrabar.Visible = blnEscritura
            Me.pnlEliminar.Visible = blnEliminar

        End Sub

        Private Sub DescargarXMLComprimido()
            If dgw_detalle.Rows.Count < 1 Then Exit Sub
            Dim btZip As Byte()
            Dim strSms As String = ""

            objBss = New Bussines.Transferencia.ArchivoInfo2
            btZip = objBss.DescargarArchivoZip_ws(Grilla_IdArchivo, Grilla_NombreArchivo, strSms)

            If btZip Is Nothing Then
                MsgBox("No se pudo descargar el archivo XML, intente nuevamente", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim rutTempZIP As String = ""
            Dim rutTempXML As String = ""


            rutTempZIP = My.Computer.FileSystem.CurrentDirectory & "\" & Grilla_NombreArchivo & ".zip"

            Dim ms As MemoryStream = New MemoryStream(btZip)
            Dim fs As FileStream = New FileStream(rutTempZIP, FileMode.Create)

            ms.WriteTo(fs)
            ms.Close()
            fs.Close()
            fs.Dispose()

            Dim fInfo As New FileInfo(rutTempZIP)

            If DesZipear(fInfo) = False Then
                MsgBox("No se pudo descomprimir el archivo XML", MsgBoxStyle.Information)
                Exit Sub
            End If



            rutTempXML = My.Computer.FileSystem.CurrentDirectory & "\" & Grilla_NombreArchivo & ".xml"

            '**********************************************************************************************
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "XML Archivo|*.xml"
            saveFileDialog1.Title = "Guardar archivo ZIP y XML"
            saveFileDialog1.AddExtension = True

            saveFileDialog1.FileName = Grilla_NombreArchivo
            Try
                If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim objFileInfo As New FileInfo(saveFileDialog1.FileName)

                    FileCopy(rutTempXML, objFileInfo.DirectoryName & "\" & Grilla_NombreArchivo & ".xml")
                    FileCopy(rutTempZIP, objFileInfo.DirectoryName & "\" & Grilla_NombreArchivo & ".rar")
                    File.Delete(rutTempXML)
                    File.Delete(rutTempZIP)

                End If
                saveFileDialog1.Dispose()
            Catch ex As Exception
                MsgBox("Ocurrio un problema al guardar, " & ex.Message, vbExclamation)
            End Try
        End Sub

        Private Function fn_CrearQueryUpdateTipo() As Dictionary(Of Short, String)

            Dim value As New Dictionary(Of Short, String)

            Dim ojQuerySIP As New Text.StringBuilder
            Dim ojQueryHuellaInterno As New Text.StringBuilder
            Dim ojQueryHuellaVisita As New Text.StringBuilder

            Dim strQuery As String = ""

            If dgw_detalle.Rows.Count < 1 Then Return Nothing

            For i As Integer = 0 To dgw_detalle.Rows.Count - 1
                Dim idArch As Integer = -1
                Dim nomArch As String = ""
                idArch = dgw_detalle.Item("col_id_arch", i).Value
                nomArch = dgw_detalle.Item("col_nom_arch", i).Value

                Dim btZip As Byte()
                Dim strSms As String = ""

                objBss = New Bussines.Transferencia.ArchivoInfo2
                btZip = objBss.DescargarArchivoZip_ws(idArch, nomArch, strSms)

                If btZip Is Nothing Then Exit For

                Dim rutTempZIP As String = ""
                Dim rutTempXML As String = ""

                rutTempZIP = My.Computer.FileSystem.CurrentDirectory & "\" & nomArch & ".zip"

                Dim ms As MemoryStream = New MemoryStream(btZip)
                Dim fs As FileStream = New FileStream(rutTempZIP, FileMode.Create)

                ms.WriteTo(fs)
                ms.Close()
                fs.Close()
                fs.Dispose()

                Dim fInfo As New FileInfo(rutTempZIP)

                If DesZipear(fInfo) = False Then Exit For

                rutTempXML = My.Computer.FileSystem.CurrentDirectory & "\" & nomArch & ".xml"

                Dim dts As New DataSet()
                Dim _fileXMLInfo As New FileInfo(rutTempXML)

                dts.ReadXml(_fileXMLInfo.FullName)

                For x As Integer = 0 To dts.Tables.Count - 1

                    Dim strSQLQuery As String = ""
                    Dim strNombreBD As String = "inpe_bd_sip"

                    Try
                        strNombreBD = dts.Tables(x).Rows(0).Item("base_datos")
                    Catch ex As Exception

                    End Try

                    Dim strNombreTabla As String = dts.Tables(x).Rows(0).Item("tabla")
                    Dim strNombreColumnaPK As String = dts.Tables(x).Rows(0).Item("key_name")
                    Dim intIDPenal As Integer = dts.Tables(x).Rows(0).Item("_PenId")
                    Dim t As DataTable = dts.Tables(x)
                    Dim strConcatenarRowID As String = ""

                    For Each f As DataRow In t.Rows
                        strConcatenarRowID = f("_RowId") & ", " & strConcatenarRowID
                    Next

                    strConcatenarRowID = strConcatenarRowID.Trim()
                    strConcatenarRowID = strConcatenarRowID.Substring(0, Len(strConcatenarRowID) - 1)

                    strQuery = ""
                    Select Case strNombreBD.ToLower
                        Case "inpe_bd_huella_visita".ToLower
                            strQuery = "UPDATE " & strNombreTabla & " SET _flg_trf = 1 WHERE _PenId = " & intIDPenal & " and " & strNombreColumnaPK & " IN (" & strConcatenarRowID & ")"
                            ojQueryHuellaVisita.AppendLine(strQuery)

                        Case "inpe_bd_huella_interno".ToLower
                            strQuery = "UPDATE " & strNombreTabla & " SET _flg_trf = 1 WHERE _PenId = " & intIDPenal & " and " & strNombreColumnaPK & " IN (" & strConcatenarRowID & ")"
                            ojQueryHuellaInterno.AppendLine(strQuery)

                        Case Else
                            strQuery = "UPDATE " & strNombreTabla & " SET _flg_trf = 1 WHERE _PenId = " & intIDPenal & " and " & strNombreColumnaPK & " IN (" & strConcatenarRowID & ")"
                            ojQuerySIP.AppendLine(strQuery)
                    End Select

                Next

                File.Delete(rutTempXML)
                File.Delete(rutTempZIP)

                If idArch = Me.Grilla_IdArchivo Then
                    Exit For
                End If
            Next

            value.Add(1, ojQuerySIP.ToString)
            value.Add(2, ojQueryHuellaInterno.ToString)
            value.Add(3, ojQueryHuellaVisita.ToString)

            Return value

        End Function

        Private Function fn_CrearQueryUpdate() As String

            Dim value As String = ""

            Dim ojQuerySIP As New Text.StringBuilder
            Dim ojQueryHuellaInterno As New Text.StringBuilder
            Dim ojQueryHuellaVisita As New Text.StringBuilder

            Dim strQuery As String = ""

            If dgw_detalle.Rows.Count < 1 Then Return Nothing

            For i As Integer = 0 To dgw_detalle.Rows.Count - 1
                Dim idArch As Integer = -1
                Dim nomArch As String = ""
                idArch = dgw_detalle.Item("col_id_arch", i).Value
                nomArch = dgw_detalle.Item("col_nom_arch", i).Value

                Dim btZip As Byte()
                Dim strSms As String = ""

                objBss = New Bussines.Transferencia.ArchivoInfo2
                btZip = objBss.DescargarArchivoZip_ws(idArch, nomArch, strSms)

                If btZip Is Nothing Then Exit For

                Dim rutTempZIP As String = ""
                Dim rutTempXML As String = ""

                rutTempZIP = My.Computer.FileSystem.CurrentDirectory & "\" & nomArch & ".zip"

                Dim ms As MemoryStream = New MemoryStream(btZip)
                Dim fs As FileStream = New FileStream(rutTempZIP, FileMode.Create)

                ms.WriteTo(fs)
                ms.Close()
                fs.Close()
                fs.Dispose()

                Dim fInfo As New FileInfo(rutTempZIP)

                If DesZipear(fInfo) = False Then Exit For

                rutTempXML = My.Computer.FileSystem.CurrentDirectory & "\" & nomArch & ".xml"

                Dim dts As New DataSet()
                Dim _fileXMLInfo As New FileInfo(rutTempXML)

                dts.ReadXml(_fileXMLInfo.FullName)

                For x As Integer = 0 To dts.Tables.Count - 1

                    Dim strSQLQuery As String = ""
                    Dim strNombreBD As String = "inpe_bd_sip"

                    Try
                        strNombreBD = dts.Tables(x).Rows(0).Item("base_datos")
                    Catch ex As Exception
                    End Try

                    Dim nomTabla As String = dts.Tables(x).Rows(0).Item("tabla")
                    Dim pk_name As String = dts.Tables(x).Rows(0).Item("key_name")
                    Dim penId As Integer = dts.Tables(x).Rows(0).Item("_PenId")
                    Dim t As DataTable = dts.Tables(x)
                    Dim idConcat As String = ""

                    For Each f As DataRow In t.Rows
                        idConcat = f("_RowId") & ", " & idConcat
                    Next

                    idConcat = idConcat.Trim()
                    idConcat = idConcat.Substring(0, Len(idConcat) - 1)

                    strQuery = ""
                    Select Case strNombreBD.ToLower
                        Case "inpe_bd_huella_visita".ToLower
                            strQuery = "UPDATE " & strNombreBD & ".dbo." & nomTabla & " SET _flg_trf = 1 WHERE _PenId = " & penId & " and " & pk_name & " IN (" & idConcat & ")"
                            ojQueryHuellaVisita.AppendLine(strQuery)

                        Case "inpe_bd_huella_interno".ToLower
                            strQuery = "UPDATE " & strNombreBD & ".dbo." & nomTabla & " SET _flg_trf = 1 WHERE _PenId = " & penId & " and " & pk_name & " IN (" & idConcat & ")"
                            ojQueryHuellaInterno.AppendLine(strQuery)

                        Case Else
                            strQuery = "UPDATE " & nomTabla & " SET _flg_trf = 1 WHERE _PenId = " & penId & " and " & pk_name & " IN (" & idConcat & ")"
                            ojQuerySIP.AppendLine(strQuery)
                    End Select

                Next

                File.Delete(rutTempXML)
                File.Delete(rutTempZIP)

                If idArch = Me.Grilla_IdArchivo Then Exit For

            Next

            Return ojQuerySIP.ToString & Chr(13) & ojQueryHuellaInterno.ToString & Chr(13) & ojQueryHuellaVisita.ToString

        End Function

#End Region


        Private Sub dgw_detalle_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw_detalle.CellClick

            If e.RowIndex = -1 Then Exit Sub
            If dgw_detalle.Item("col_error", e.RowIndex).Value = "ERROR" Then
                dgw_detalle.RowsDefaultCellStyle.SelectionForeColor = Color.Red
            Else
                dgw_detalle.RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
            End If

        End Sub

        Private Sub dgw_detalle_RowPrePaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgw_detalle.RowPrePaint

            If dgw_detalle.Item("col_fec_sub_sede", e.RowIndex).Value = "PENDIENTE" Then
                dgw_detalle.Rows(e.RowIndex).Cells("col_fec_sub_sede").Style.Font = New Font(dgw_detalle.Font, FontStyle.Bold)
            End If
            If dgw_detalle.Item("col_fec_proc_sed", e.RowIndex).Value = "PENDIENTE" Then
                dgw_detalle.Rows(e.RowIndex).Cells("col_fec_proc_sed").Style.Font = New Font(dgw_detalle.Font, FontStyle.Bold)
            End If
            If dgw_detalle.Item("col_fec_desc_reg", e.RowIndex).Value = "PENDIENTE" Then
                dgw_detalle.Rows(e.RowIndex).Cells("col_fec_desc_reg").Style.Font = New Font(dgw_detalle.Font, FontStyle.Bold)
            End If
            If dgw_detalle.Item("col_fec_proc_reg", e.RowIndex).Value = "PENDIENTE" Then
                dgw_detalle.Rows(e.RowIndex).Cells("col_fec_proc_reg").Style.Font = New Font(dgw_detalle.Font, FontStyle.Bold)
            End If

            If dgw_detalle.Item("col_error", e.RowIndex).Value = "ERROR" Then
                dgw_detalle.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
                dgw_detalle.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            End If

        End Sub

        Private Sub frmArchivoInfoPopup2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

            dgw_detalle.Columns("col_fec_sub_sede").DefaultCellStyle.BackColor = Color.LightGray
            dgw_detalle.Columns("col_fec_proc_sed").DefaultCellStyle.BackColor = Color.LightGray
            dgw_detalle.Columns("col_fec_desc_reg").DefaultCellStyle.BackColor = Color.LightGray
            dgw_detalle.Columns("col_fec_proc_reg").DefaultCellStyle.BackColor = Color.LightGray

            Me.NumeroMes = Month(Now)
            Me.Anio = Year(Now)
            Me.cbbAnio.AnioInicio = 2014
            Me.cbbAnio.AnioFin = Now.Year
            Me.cbbAnio.LoadUsc()
            Me.cbbAnio.Value = Now.Year
            blnComboAnio = True
        End Sub

        Private Sub frmArchivoInfoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Usuario_Permiso()
            HabilitarBotones()

            Me.Refresh()

            Me.Cursor = Cursors.WaitCursor
            Listar()
            Me.Cursor = Cursors.Default

        End Sub

        Private Sub btnPadinDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnPadinDetalle.Click
            If dgw_detalle.Rows.Count < 1 Then Exit Sub
            FRM_LeerXML()
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            AEliminar()

        End Sub

        Private Sub btnQuitarError_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarError.Click

            If dgw_detalle.Rows.Count < 1 Then Exit Sub
            Dim strSms As String = ""
            objBss = New Bussines.Transferencia.ArchivoInfo2
            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Confirma quitar la marca de error al registro seleccionado?") = Windows.Forms.DialogResult.Yes Then
                If objBss.SetearArchivoError_ws(Grilla_IdArchivo, Grilla_NombreArchivo, strSms) = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("No se pudo quitar el error del registro seleccionado")
                Else
                    Me.Cursor = Cursors.WaitCursor
                    Listar()
                    Me.Cursor = Cursors.Default
                End If
            End If

        End Sub

        Private Sub btnDescargar_Click(sender As System.Object, e As System.EventArgs) Handles btnDescargarXML.Click

            DescargarXMLComprimido()

        End Sub

        Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click

            Me.Cursor = Cursors.WaitCursor
            Listar()
            Me.Cursor = Cursors.Default

        End Sub

        Private Sub cbbMes_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbbMes.SelectionChangeCommitted

            Me.Cursor = Cursors.WaitCursor
            Listar()
            Me.Cursor = Cursors.Default

        End Sub

        Private Sub cbbAnio__SelectedIndexChanged() Handles cbbAnio._SelectedIndexChanged

            If blnComboAnio = True Then
                Me.Cursor = Cursors.WaitCursor
                Listar()
                Me.Cursor = Cursors.Default
            End If

        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgw_detalle)
        End Sub

        Private Sub dgw_detalle_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw_detalle.CellDoubleClick
            If dgw_detalle Is Nothing Then Exit Sub

            btnPadinDetalle.PerformClick()
        End Sub



        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub
    End Class
End Namespace


