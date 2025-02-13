Imports Ionic.Zip
Imports System.IO
Imports Type.Enumeracion.Licencia

Namespace Registro.Captura
    Public Class frmOdontogramaPopup
        Dim bss As Bussines.Registro.Odontograma.InternoOdontograma
        Dim strPath_NomFileOdont As String = "" 'ruta y nombre del archivo digital de odontograma
#Region "propiedades publicas"
        Public Property _Codigo() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _PenalId() As Integer = -1
        Public Property _RegionId() As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "propiedades parametricas"
        Private Property Observaciones() As String
            Get
                Return txtObs.Text
            End Get
            Set(value As String)
                txtObs.Text = value
            End Set
        End Property
        Private Property Especificaciones() As String
            Get
                Return txtEspecific.Text
            End Get
            Set(value As String)
                txtEspecific.Text = value
            End Set
        End Property
        Private Property TipoOclusion() As Integer
            Get
                Dim v As Integer = -1
                If cbbTipoOclus.Text = "" Then
                    v = -1
                Else
                    v = cbbTipoOclus.SelectedValue
                End If
                Return v
            End Get
            Set(value As Integer)
                cbbTipoOclus.SelectedValue = value
            End Set
        End Property
        Private Property TipoDiente() As Integer
            Get
                Dim v As Integer = -1
                If cbbTipoDiente.Text = "" Then
                    v = -1
                Else
                    v = cbbTipoDiente.SelectedValue
                End If
                Return v
            End Get
            Set(value As Integer)
                cbbTipoDiente.SelectedValue = value
            End Set
        End Property
        Private Property TamanioDiente() As Integer
            Get
                Dim v As Integer = -1
                If cbbTamanioDiente.Text = "" Then
                    v = -1
                Else
                    v = cbbTamanioDiente.SelectedValue
                End If
                Return v
            End Get
            Set(value As Integer)
                cbbTamanioDiente.SelectedValue = value
            End Set
        End Property
        Private Property TamanioDentomaxilar() As Integer
            Get
                Dim v As Integer = -1
                If cbbTamDentomax.Text = "" Then
                    v = -1
                Else
                    v = cbbTamDentomax.SelectedValue
                End If
                Return v
            End Get
            Set(value As Integer)
                cbbTamDentomax.SelectedValue = value
            End Set
        End Property
        Private Property RugaPalatina() As Integer
            Get
                Dim id As Integer
                If rdbI.Checked Then id = Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_I
                If rdbII.Checked Then id = Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_II
                If rdbIII.Checked Then id = Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_III
                If rdbIV.Checked Then id = Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_IV
                If rbdNoRegistra.Checked Then id = Type.Enumeracion.Odontograma.enmRugaPalatina.No_Registra
                Return id
            End Get
            Set(value As Integer)
                Select Case value
                    Case Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_I
                        rdbI.Checked = True
                    Case Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_II
                        rdbII.Checked = True
                    Case Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_III
                        rdbIII.Checked = True
                    Case Type.Enumeracion.Odontograma.enmRugaPalatina.Tipo_IV
                        rdbIV.Checked = True
                    Case Else
                        rbdNoRegistra.Checked = True
                End Select
            End Set
        End Property
        Private Property ArcoDentarioSup() As Integer
            Get
                Dim id As Integer
                If rdbSupOvoide.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.Ovoide
                If rdbSupTriang.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.Triangular
                If rdbSupCuadrado.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.Cuadrado
                If rdbSupNoRegistra.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.No_Registra
                Return id
            End Get
            Set(value As Integer)
                Select Case value
                    Case Type.Enumeracion.Odontograma.enmArcoDentario.Ovoide
                        rdbSupOvoide.Checked = True
                    Case Type.Enumeracion.Odontograma.enmArcoDentario.Triangular
                        rdbSupTriang.Checked = True
                    Case Type.Enumeracion.Odontograma.enmArcoDentario.Cuadrado
                        rdbSupCuadrado.Checked = True
                    Case Else
                        rdbSupNoRegistra.Checked = True
                End Select
            End Set
        End Property
        Private Property ArcoDentarioInf() As Integer
            Get
                Dim id As Integer
                If rdbInfOvoide.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.Ovoide
                If rdbInfTriang.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.Triangular
                If rdbInfCuadrado.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.Cuadrado
                If rdbInfNoRegistra.Checked Then id = Type.Enumeracion.Odontograma.enmArcoDentario.No_Registra
                Return id
            End Get
            Set(value As Integer)
                Select Case value
                    Case Type.Enumeracion.Odontograma.enmArcoDentario.Ovoide
                        rdbInfOvoide.Checked = True
                    Case Type.Enumeracion.Odontograma.enmArcoDentario.Triangular
                        rdbInfTriang.Checked = True
                    Case Type.Enumeracion.Odontograma.enmArcoDentario.Cuadrado
                        rdbInfCuadrado.Checked = True
                    Case Else
                        rdbInfNoRegistra.Checked = True
                End Select
            End Set
        End Property
        'Private Property GloArchivoDigitalId() As Integer = -1
        'Private Property EntGloArchDig() As Entity.Globall.ArchivoDigital = Nothing
#End Region
#Region "Combos"
        Private Sub ComboTipoOclusion()
            With Me.cbbTipoOclus
                .ComboTipo = Type.Combo.ComboTipo.OdontogramaOclusionTipo
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboTipoDiente()
            With Me.cbbTipoDiente
                .ComboTipo = Type.Combo.ComboTipo.OdontogramaDienteTipo
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboTamanioDiente()
            With Me.cbbTamanioDiente
                .ComboTipo = Type.Combo.ComboTipo.OdontogramaTamanioDiente
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboTamanioDentomaxilar()
            With Me.cbbTamDentomax
                .ComboTipo = Type.Combo.ComboTipo.OdontogramaTamanioDentomaxilar
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Listar"

        Private Sub Listar()
            If Me._Codigo < 1 Then
                Me.TipoDiente = -1
                Me.TipoOclusion = -1
                Me.TamanioDentomaxilar = -1
                Me.TamanioDiente = -1
                Exit Sub
            End If
            Dim sms As String = ""
            Dim ent As Entity.Registro.Odontograma.InternoOdontograma
            Dim entArchDig As Entity.Globall.ArchivoDigitalizado
            Dim entArchDigCol As Entity.Globall.ArchivoDigitalizadoCol
            Dim entArchDigFiltro As New Entity.Globall.ArchivoDigitalizado

            ent = (New Bussines.Registro.Odontograma.InternoOdontograma).Listar(Me._Codigo)

            entArchDigFiltro.IdRegistroForaneo = ent.Codigo
            entArchDigFiltro.TipoArchivoDigital = 1 'odontograma

            entArchDigCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(entArchDigFiltro)
            With ent
                Me.Observaciones = .Observaciones
                Me.Especificaciones = .Especificaciones
                Me.TipoOclusion = .OclusionTipoId
                Me.TipoDiente = .DienteTipoId
                Me.TamanioDiente = .TamanioDienteId
                Me.TamanioDentomaxilar = .TamanioDentoMaxilarId
                Me.RugaPalatina = .RugaPalatinaId
                Me.ArcoDentarioSup = .ArcoDentarioSupId
                Me.ArcoDentarioInf = .ArcoDentarioInfId

                If entArchDigCol.Count = 0 Then Exit Sub
                entArchDig = entArchDigCol.Archivodigital(0)
                If entArchDig.ArchivoDigitalByte Is Nothing Then Exit Sub

                If sms.Trim.Length <> 0 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(sms)
                    Exit Sub
                End If


                Dim strRutaDIR As String = ""
                strRutaDIR = My.Computer.FileSystem.CurrentDirectory & "\tmp\odontograma"

                If System.IO.Directory.Exists(strRutaDIR) = False Then System.IO.Directory.CreateDirectory(strRutaDIR)

                Dim NomArch As String = ""
                NomArch = "tmp_odont_" & Now.ToFileTime & ".rar"
                System.IO.File.WriteAllBytes(strRutaDIR & "\" & NomArch, entArchDig.ArchivoDigitalByte)


                Dim z As ZipFile = ZipFile.Read(strRutaDIR & "\" & NomArch)
                z.ExtractAll(strRutaDIR, ExtractExistingFileAction.OverwriteSilently)
                z.Dispose()

                Me.strPath_NomFileOdont = strRutaDIR & "\" & z.Item(0).FileName
                Try
                    uscOdontograma.OpenOdontograma(Me.strPath_NomFileOdont)
                    System.IO.File.Delete(Me.strPath_NomFileOdont)
                    System.IO.File.Delete(strRutaDIR & "\" & NomArch)
                Catch ex As Exception

                End Try
                Me.Refresh()
            End With

            Me.UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.Auditoria.EnumTipTabla.int_mov_interno_odontograma)

        End Sub

#End Region
#Region "Accion"
        
        Private Function ExisteError() As Boolean
            Dim sms As String = ""
            Dim blnErr As Boolean = False
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._InternoIngresoInpeId <= 0 Then
                    sms = "IngresoInpeId =" & Me._InternoIngresoInpeId & " no válido"
                    blnErr = True
                End If
            Else
                If Me._InternoIngresoId <= 0 Then
                    sms = "IngresoId =" & Me._InternoIngresoId & " no válido"
                    blnErr = True
                End If
            End If
            If Me._InternoId <= 0 Then
                sms = If(sms = "", sms, sms & vbCrLf)
                sms = sms & "InternoId =" & Me._InternoId & " no válido"
                blnErr = True
            End If
            If Me._PenalId <= 0 Then
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

        Private Function AGrabar() As Boolean
            'validar pendiente
            If ExisteError() = True Then Return False

            '--------------------------------------------
            Dim strRutaDIR As String = ""
            If IO.File.Exists(strPath_NomFileOdont) = False Then
                strRutaDIR = My.Computer.FileSystem.CurrentDirectory & "\tmp\odontograma"

                If System.IO.Directory.Exists(strRutaDIR) = False Then System.IO.Directory.CreateDirectory(strRutaDIR)
                Me.strPath_NomFileOdont = strRutaDIR & "\tmp_odont_" & Now.ToFileTime & ".odo"
            End If

            uscOdontograma.SaveOdontograma(strPath_NomFileOdont) 'se reemplaza el archivo

            Dim zip As New ZipFile
            Dim sipPath As String = ""
            zip.AddFile(strPath_NomFileOdont, "")
            sipPath = strRutaDIR + "\tmp_odont_" + Now.ToFileTime.ToString + ".rar"
            zip.Save(sipPath)
            zip.Dispose()

            Dim file As Byte()
            file = IO.File.ReadAllBytes(sipPath)


            Dim ent As New Entity.Registro.Odontograma.InternoOdontograma
            With ent
                .Codigo = Me._Codigo
                .InternoId = Me._InternoId
                .IngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                        .IngresoId = -1
                    Case Else
                        .IngresoInpeId = -1
                End Select
                .Observaciones = Me.Observaciones
                .Especificaciones = Me.Especificaciones
                .OclusionTipoId = Me.TipoOclusion
                .DienteTipoId = Me.TipoDiente
                .TamanioDienteId = Me.TamanioDiente
                .TamanioDentoMaxilarId = Me.TamanioDentomaxilar
                .RugaPalatinaId = Me.RugaPalatina
                .ArcoDentarioSupId = Me.ArcoDentarioSup
                .ArcoDentarioInfId = Me.ArcoDentarioInf
                .RegionId = Me._RegionId
                .PenalId = Me._PenalId
                '.ArchivoDigitalId = Me.GloArchivoDigitalId
                '.OdontogramaByte = file
            End With


            Dim outSMS As String = ""
            Dim intOdontId As Integer = -1
            Dim intArchDigID As Integer = -1

            bss = New Bussines.Registro.Odontograma.InternoOdontograma

            intOdontId = bss.Grabar(ent, outSMS)

            If intOdontId = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSMS)
                Return False
            End If

            Dim entAD As New Entity.Globall.ArchivoDigitalizado
            Dim entADFiltro As New Entity.Globall.ArchivoDigitalizado
            Dim entADCol As New Entity.Globall.ArchivoDigitalizadoCol
            entADFiltro.IdRegistroForaneo = intOdontId
            entADFiltro.TipoArchivoDigital = 1 'odontograma
            entADCol = (New Bussines.Globall.ArchivoDigitalizado).Listar(entADFiltro)

            If Not entADCol Is Nothing Then
                If entADCol.Count > 0 Then entAD = entADCol.Archivodigital(0)
            End If

            With entAD
                .ArchivoDigitalByte = file
                .Extension = "rar"
                .IdRegistroForaneo = intOdontId
                .Ip = Legolas.Components.PC.GetIP
                .Mac = Legolas.Components.PC.GetMAC
                .NombrePc = Legolas.Components.PC.PCNombre
                .RegionId = Me._RegionId
                .PenalId = Me._PenalId
                .PesoByte = file.Length
                .TipoArchivoDigital = 1 'odontograma
            End With

            Dim id As Integer = -1
            outSMS = ""
            id = (New Bussines.Globall.ArchivoDigitalizado).Grabar(entAD, outSMS)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSMS)
                Return False
            End If
            Try
                My.Computer.FileSystem.DeleteDirectory(strRutaDIR, FileIO.DeleteDirectoryOption.DeleteAllContents) 'eliminar todo el contenido del directorio
            Catch ex As Exception
                'nada
            End Try

            Return True
        End Function
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()
            ComboTipoOclusion()
            ComboTipoDiente()
            ComboTamanioDiente()
            ComboTamanioDentomaxilar()
        End Sub

        Private Sub PermisosUsuario()
            pnlGrabarDatos.Visible = Me._FormEscritura
        End Sub
#End Region
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            btnSalir_Click(Nothing, Nothing)
        End Sub

        Private Sub frmOdontogramaPopup_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Try
                System.IO.File.Delete(strPath_NomFileOdont)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            If AGrabar() = False Then Exit Sub
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub frmOdontogramaPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ValoresxDefault()
            PermisosUsuario()
            Listar()

        End Sub

    End Class
End Namespace