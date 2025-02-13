Imports Type.Enumeracion.Licencia

Namespace Registro.Captura
    Public Class frmDocDigitalizadoPopup
        Dim dirTmp As String = My.Computer.FileSystem.CurrentDirectory & "\tmp\doc_digitalizado"

        Dim cNomArchTmp As String = ""
#Region "propiedades_publicas"
        Public Property _Codigo As Integer = -1
        Public Property _internoId As Integer = -1
        Public Property _IngresoId As Integer = -1
        Public Property _IngresoInpeId As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region

#Region "propiedades"
        Private Property Observaciones As String
            Get
                Return txtObs.Text
            End Get
            Set(value As String)
                txtObs.Text = value
            End Set
        End Property

        Private Property Titulo As String
            Get
                Return txtTituloDoc.Text
            End Get
            Set(value As String)
                txtTituloDoc.Text = value
            End Set
        End Property
#End Region

#Region "otros"
        Private Sub PermisosUsuario()
            pnlGrabarDatos.Visible = Me._FormEscritura
        End Sub

        Private Sub Listar()
            If Me._Codigo < 1 Then Exit Sub

            Dim sms As String = ""
            Dim ent As Entity.Registro.Documento.DocumentoDigitalizado
            Dim entArchDig As Entity.Globall.ArchivoDigitalizado
            Dim entArchDigCol As Entity.Globall.ArchivoDigitalizadoCol
            Dim entArchDigFiltro As New Entity.Globall.ArchivoDigitalizado

            ent = (New Bussines.Registro.Documento.DocumentoDigitalizado).Listar(Me._Codigo)

            entArchDigFiltro.IdRegistroForaneo = ent.Codigo
            entArchDigFiltro.TipoArchivoDigital = 2 'doc digital
            entArchDigCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(entArchDigFiltro)
            With ent
                Me.Observaciones = .Observaciones
                Me.Titulo = .TituloDoc

                If entArchDigCol.Count = 0 Then Exit Sub

                entArchDig = entArchDigCol.Archivodigital(0)

                If entArchDig.ArchivoDigitalByte Is Nothing Then Exit Sub

                If sms.Trim.Length <> 0 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(sms)
                    Exit Sub
                End If

                If System.IO.Directory.Exists(dirTmp) = False Then System.IO.Directory.CreateDirectory(dirTmp)


                cNomArchTmp = "tmp_doc_dig_" & Now.ToFileTime & ".pdf"
                System.IO.File.WriteAllBytes(dirTmp & "\" & cNomArchTmp, entArchDig.ArchivoDigitalByte)

                Try
                    WebBrowser1.Navigate(dirTmp & "\" & cNomArchTmp)
                Catch ex As Exception

                End Try
                Me.Refresh()
            End With
            'Me.UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoAlias) pendientehnrb
        End Sub
#End Region
        Private bFileModificado As Boolean = False 'indica si es archivo ha sido cambiado por otro

        Private Function ExisteError() As Boolean
            Dim sms As String = ""
            Dim blnErr As Boolean = False
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._IngresoInpeId <= 0 Then
                    sms = "IngresoInpeId =" & Me._IngresoInpeId & " no válido"
                    blnErr = True
                End If
            Else
                If Me._IngresoId <= 0 Then
                    sms = "IngresoId =" & Me._IngresoId & " no válido"
                    blnErr = True
                End If
            End If
            If Me._internoId <= 0 Then
                sms = If(sms = "", sms, sms & vbCrLf)
                sms = sms & "InternoId =" & Me._internoId & " no válido"
                blnErr = True
            End If
            If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana And Me._PenalId <= 0 Then
                sms = If(sms = "", sms, sms & vbCrLf)
                sms = sms & "PenalId =" & Me._PenalId & " no válido"
                blnErr = True
            End If
            If Me._RegionId <= 0 Then
                sms = If(sms = "", sms, sms & vbCrLf)
                sms = sms & "RegionId =" & Me._RegionId & " no válido"
                blnErr = True
            End If
            If blnErr = True Then Legolas.Configuration.Aplication.MessageBox.MensajeError(sms)
            Return blnErr
        End Function

        Private Sub AGrabar()

            If ExisteError() = True Then Exit Sub

            Dim ent As New Entity.Registro.Documento.DocumentoDigitalizado
            Dim bss As New Bussines.Registro.Documento.DocumentoDigitalizado
            Dim sms As String = ""
            Dim id As Integer = -1
            If Me._Codigo = -1 AndAlso txtRuta.Text.Trim.Length = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha cargado ningún documento digitalizado.")
                Exit Sub
            End If
            If Me._Codigo = -1 AndAlso System.IO.File.Exists(txtRuta.Text.Trim) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El documento pdf no se encuentra en el directorio, se movió o se eliminó.")
                Exit Sub
            End If
            If Me._Codigo > 0 Then
                ent = bss.Listar(Me._Codigo)
            Else
                ent.PenalId = Me._PenalId
                ent.RegionId = Me._RegionId
                ent.IngresoId = Me._IngresoId
                ent.IngresoInpeId = Me._IngresoInpeId
                ent.InternoId = Me._internoId
            End If

            ent.Observaciones = Me.Observaciones
            ent.TituloDoc = Me.Titulo

            id = bss.Grabar_LM(ent, sms)

            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Error al guardar el archivo digitalizado " & sms)
                Exit Sub
            End If

            Dim file As Byte()

            If Me._Codigo > -1 And bFileModificado = False Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Exit Sub
            End If

            file = IO.File.ReadAllBytes(txtRuta.Text.Trim)

            Dim entAD As New Entity.Globall.ArchivoDigitalizado
            Dim entADFiltro As New Entity.Globall.ArchivoDigitalizado
            Dim entADCol As New Entity.Globall.ArchivoDigitalizadoCol
            entADFiltro.IdRegistroForaneo = id
            entADFiltro.TipoArchivoDigital = 2 'doc digital
            entADCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(entADFiltro)

            If Not entADCol Is Nothing Then
                If entADCol.Count > 0 Then entAD = entADCol.Archivodigital(0)
            End If

            With entAD
                .ArchivoDigitalByte = file
                .Extension = "pdf"
                .IdRegistroForaneo = id
                .Ip = Legolas.Components.PC.GetIP
                .Mac = Legolas.Components.PC.GetMAC
                .NombrePc = Legolas.Components.PC.PCNombre
                .RegionId = Me._RegionId
                .PenalId = Me._PenalId
                .PesoByte = file.Length
                .TipoArchivoDigital = 2 '1=odontograma, 2=archivo digitalizado registro (tabla int_mov_doc_digital)
            End With

            Me._Codigo = id

            Dim id2 As Integer = -1
            Dim outSMS As String = ""

            id2 = (New Bussines.Globall.ArchivoDigitalizado).Grabar(entAD, outSMS)
            If id2 = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSMS)
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click, btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnAdjuntar_Click(sender As System.Object, e As System.EventArgs) Handles btnAdjuntar.Click
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Multiselect = False
            openFileDialog1.Filter = "Documentos digitalizado (*.pdf)|*.pdf"
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtRuta.Text = openFileDialog1.FileName
                WebBrowser1.Navigate(txtRuta.Text)
                bFileModificado = True
            End If
        End Sub

        Private Sub frmDocDigitalizadoPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            'ValoresxDefault()
            PermisosUsuario()
            Listar()
        End Sub

        Private Sub frmDocDigitalizadoPopup_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Try
                If System.IO.File.Exists(dirTmp & "\" & cNomArchTmp) Then System.IO.File.Delete(dirTmp & "\" & cNomArchTmp)
                If System.IO.File.Exists(txtRuta.Text) Then System.IO.File.Delete(txtRuta.Text)
            Catch ex As Exception

            End Try
            
        End Sub
    End Class
End Namespace