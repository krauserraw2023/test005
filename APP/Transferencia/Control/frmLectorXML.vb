Option Explicit On
Imports System.IO
Imports Ionic.Zip
Imports System.Xml

Namespace Transferencia.Control
    Public Class frmLectorXML
        Private _CodArchivoTransfer As Integer = -1
        Private _NomArchivo As String = ""
        Private _strCarpetaDeszipeado As String = "deszipeado"

        Private dts As DataSet
        Private dtTabla As DataTable
        Private dtTablaXML As DataTable

        Private pathXml As String = ""

#Region "acciones"
        Private Function getPassZip(NomFile As String) As String
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
                    zip1.ExtractAll(FilePath.DirectoryName, ExtractExistingFileAction.OverwriteSilently)
                    zip1.Dispose()
                Catch ex As Exception
                    intentoFallido = True
                    zip1.Dispose()
                End Try

                If intentoFallido = True Then 'segundo intento en caso fallo el primero
                    Dim zip As New ZipFile(FilePath.FullName)
                    zip.Password = "Z1pP0p3"
                    zip.ExtractAll(FilePath.DirectoryName, ExtractExistingFileAction.OverwriteSilently)
                    zip.Dispose()
                End If
            Catch ex As Exception
                value = False
            End Try
            Return value
        End Function
        Private Sub formateaXML()
            Dim reader As XmlTextReader = New XmlTextReader(pathXml)
            Do While (reader.Read())
                Select Case reader.NodeType
                    Case XmlNodeType.Element 'Mostrar comienzo del elemento.
                        resaltarNodo(txtVisorXML, "<" & reader.Name & ">", Color.Blue, False)
                        'Case XmlNodeType.Text 'Mostrar el texto en cada elemento.
                    Case XmlNodeType.EndElement 'Mostrar final del elemento.
                        resaltarNodo(txtVisorXML, "</" & reader.Name & ">", Color.Blue, False)
                End Select
            Loop
            reader.Close()
        End Sub
        Private Sub LeerTabla(indice As Integer)
            If indice >= dts.Tables.Count Then indice = 0
            dgwVisorTabla.DataSource = dts.Tables(indice)
            dtTablaXML = dts.Tables(indice)
            lblTotalRegistros.Text = dts.Tables(indice).Rows.Count
        End Sub
        Private Sub LeerXML()
            Dim btZip As Byte()
            Dim strSms As String = ""

            Dim objBss As New Bussines.Transferencia.ArchivoInfo2

            btZip = objBss.DescargarArchivoZip_ws(Me._CodArchivoTransfer, Me._NomArchivo, strSms)

            If btZip Is Nothing Then
                MsgBox("No se pudo descargar el archivo XML, intente nuevamente", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim rutTempZIP As String = ""

            Dim path_tmp_down As String = My.Computer.FileSystem.CurrentDirectory & "\tmp\tmp_down_xml"

            If System.IO.Directory.Exists(path_tmp_down) = False Then System.IO.Directory.CreateDirectory(path_tmp_down)

            rutTempZIP = path_tmp_down & "\" & Me._NomArchivo & ".zip"

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

            fInfo.Delete()

            pathXml = path_tmp_down & "\" & Me._NomArchivo & ".xml"

            dts = Nothing
            dts = New DataSet()
            Dim _fileXMLInfo As New FileInfo(pathXml)

            dts.ReadXml(_fileXMLInfo.FullName)
            lblTotalTablas.Text = dts.Tables.Count
            txtVisorXML.Font = New Font(txtVisorXML.Font, FontStyle.Regular)

            'cargar combo
            cboTablas.Items.Clear()
            For i As Integer = 0 To dts.Tables.Count - 1
                cboTablas.Items.Add(dts.Tables(i).Rows(0).Item("tabla"))
            Next
            cboTablas.SelectedIndex = 0

            cmdFormatearXML.Enabled = True

        End Sub
        Private Function resaltarNodo(rtb As RichTextBox, sFindString As String, colorText As Color, Optional ByVal Negrita As Boolean = False) As Integer
            Dim lFoundPos As Long
            Dim lFindLength As Long
            Dim lOriginalSelStart As Long
            Dim lOriginalSelLength As Long
            Dim iMatchCount As Integer

            lOriginalSelStart = rtb.SelectionStart
            lOriginalSelLength = rtb.SelectionLength

            lFindLength = Len(sFindString)

            lFoundPos = rtb.Find(sFindString, 0, rtb.TextLength, RichTextBoxFinds.None)
            While lFoundPos > -1 And iMatchCount < rtb.TextLength
                iMatchCount = iMatchCount + 1

                rtb.SelectionStart = lFoundPos
                rtb.SelectionLength = lFindLength
                rtb.SelectionColor = colorText
                If Negrita = True Then
                    rtb.SelectionFont = New Font(rtb.SelectionFont, FontStyle.Bold)
                Else
                    rtb.SelectionFont = New Font(rtb.SelectionFont, FontStyle.Regular)
                End If

                lFoundPos = rtb.Find(sFindString, lFoundPos + lFindLength, rtb.TextLength, RichTextBoxFinds.None)
            End While

            rtb.SelectionStart = lOriginalSelStart
            rtb.SelectionLength = lOriginalSelLength
        End Function
#End Region
#Region "Otros"
        Private Sub Usuario_Permisos()

            If Legolas.LBusiness.Globall.WinApp.LicenciaApp() = 1 Then

                If Legolas.Configuration.Usuario.OficinaID = 1 Then 'oficina de sistemas
                    'nada
                Else
                    TabControl1.TabPages.Remove(Me.tabVisorXML)
                    TabControl1.TabPages.Remove(Me.TabPage1)
                End If
            Else
                TabControl1.TabPages.Remove(Me.tabVisorXML)
                TabControl1.TabPages.Remove(Me.TabPage1)
            End If

            Me.btnExportar.Visible = Me._FormReporte

        End Sub
#End Region
        Public Sub New(CodArchivoTransfer As Integer, NomArchivo As String)
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            _CodArchivoTransfer = CodArchivoTransfer
            _NomArchivo = NomArchivo
            lblNombreArchivo.Text = NomArchivo & ".xml"
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            LeerXML()
        End Sub

        Private Sub cmdFormatearXML_Click(sender As System.Object, e As System.EventArgs) Handles cmdFormatearXML.Click

            txtVisorXML.Font = New Font(txtVisorXML.Font, FontStyle.Bold)
            'txtVisorXML.Text = dts.GetXml

            Dim archivoTemporal As String = Legolas.Configuration.Path.PathTemp & Now.ToFileTime & ".xml"
            dts.WriteXml(archivoTemporal, XmlWriteMode.WriteSchema)

            Try
                Dim doc As XmlDocument = New XmlDocument
                doc.Load(archivoTemporal)
                txtVisorXML.Text = doc.OuterXml

                IO.File.Delete(archivoTemporal)

            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El archivo xml a visualizar es demasiado pesado para mostrarlo.")
                IO.File.Delete(archivoTemporal)
            End Try

            'formateaXML()
        End Sub
        Private Sub cboTablas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTablas.SelectedIndexChanged
            LeerTabla(cboTablas.SelectedIndex)
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Try
                File.Delete(pathXml)
            Catch ex As Exception

            End Try
            Me.Close()
        End Sub

        Private Sub frmLectorXML_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Try
                File.Delete(pathXml)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwVisorTabla)

        End Sub

        Private Sub frmLectorXML_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Usuario_Permisos()

        End Sub

        Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
            txtCodigoActivaTrf.Text = ""
            txtVisorXML.Font = New Font(txtVisorXML.Font, FontStyle.Bold)
            For i As Integer = 0 To dts.Tables.Count - 1
                Dim sql As String = ""
                Dim nomTabla As String = dts.Tables(i).Rows(0).Item("tabla")
                Dim pk_name As String = dts.Tables(i).Rows(0).Item("key_name")
                Dim penId As Integer = dts.Tables(i).Rows(0).Item("_PenId")
                Dim t As DataTable = dts.Tables(i)
                Dim idConcat As String = ""
                For Each f As DataRow In t.Rows
                    idConcat = f("key_id") & ", " & idConcat

                Next
                idConcat = idConcat.Trim()
                idConcat = idConcat.Substring(0, Len(idConcat) - 1)
                sql = "UPDATE " & nomTabla & " SET _flg_trf=1 WHERE _PenId=" & penId & " and " & pk_name & " IN (" & idConcat & ")"

                txtCodigoActivaTrf.Text = txtCodigoActivaTrf.Text.Trim + vbCrLf & sql
            Next
        End Sub

        Private Sub btnOpenArchivoExterno_Click(sender As System.Object, e As System.EventArgs)

        End Sub
    End Class

End Namespace
